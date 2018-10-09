using System;
using System.Diagnostics;
using OpenQA.Selenium;

namespace AutomationFramework.Automation
{
    public static class Extensions
    {
        public static void WaitForCondition(this object caller, Func<bool> condition, int timeout)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (timeout <= sw.ElapsedMilliseconds)
            {
                try
                {
                    if (condition())
                    {
                        return;
                    }
                }
                catch (StaleElementReferenceException)
                {
                    throw;
                }
            }
        }
    }
}
