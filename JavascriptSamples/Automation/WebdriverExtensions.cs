using System;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;

namespace AutomationFramework.Automation
{
    public static class WebdriverExtensions
    {
        public static void WaitForPageLoad(this IWebDriver  driver, int timeoutms)
        {
            const int Interval = 300;
            var stopwatch = Stopwatch.StartNew();
            while(stopwatch.ElapsedMilliseconds < timeoutms)
            {
                Thread.Sleep(Interval);
                var message = GetUnloadedResources(driver);
                if(string.IsNullOrEmpty(message))
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Verify the unloaded resources
        /// </summary>
        /// <param name="webDriver"></param>
        /// <returns></returns>
        private static string GetUnloadedResources(IWebDriver webDriver)
        {
            try
            {
                const string Script = @"if(document.readyState !== 'complete') {return 'document.readyState !== 'complete'};
                                        if(typeof $ === 'undefined') {return 'typeof $ === undefined'};
                                        if(window.monitor.ajaxCalls === 'undefined') {return 'windows.monitor.ajaxCalls'};
                                        if(window.monitor.ajaxCalls !== 0) {return 'window.monitor.ajaxCalls !== 0'};
                                        if($.active !== 0) {return '$.active !== 0'}
                                        return ''";
                return webDriver.ExecuteJavascript<string>(Script);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        private static T ExecuteJavascript<T>(this IWebDriver webDriver, string script, params object[] parms)
        {
            if(!script.Contains("return"))
            {
                throw new ArgumentException($"ExecuteJavascript<T> cannot return a type becuase no return statement exists in the script");
            }
            try
            {
                return (T)webDriver.GetJavascriptExecutor().ExecuteScript(script, parms);
            }
            catch (Exception ex)
            {
                if(ex is InvalidCastException)
                {
                    throw new InvalidCastException($"Exception executing Javascript '{script}' : {ex}");
                }
                throw;
            }                   
        }

        public static IJavaScriptExecutor GetJavascriptExecutor(this IWebDriver webDriver)
        {
            return (IJavaScriptExecutor)webDriver;
        }       
    }
}
