using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Diagnostics;

namespace JavascriptSamples.Automation
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
