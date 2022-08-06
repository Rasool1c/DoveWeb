using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports.Model;
using DoveWeb.Hooks;
using Serilog;
using Log = Serilog.Log;
using OpenQA.Selenium;
using System.Threading;
using NUnit.Framework;
using DoveWeb.Utilities;

namespace DoveWeb.Pages
{
    public class TermsOfUse
    {
        public static void ClickOnTermsOfUse()
        {
            
            Thread.Sleep(5000);
            // accepting the cookies
            DoveHooks.driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']")).Click();
            // clicking on terms of use in footer
            DoveHooks.driver.FindElement(By.XPath("//a[@title='Terms of use']")).Click();
            Log.Information("clicked on Terms of use");
        }
        public static void VerfiyTermsOfUseText()
        {
            Thread.Sleep(5000);
            // storing the actual data into a string
            string TermsText = DoveHooks.driver.FindElement(By.XPath("//b[normalize-space()='2. Prohibited Uses']")).Text;
            Log.Debug("extracting the text");
            string ExpectedText = "Prohibited Uses";
            // asserting the actual data with expected data
            Assert.IsTrue(TermsText.Contains("Prohibited Uses"), ExpectedText);
            Log.Information("Prohibited Uses section text is present and verfied succcessfully");
            if (TermsText.Contains("Prohibited Uses"))
            {
                Console.WriteLine("Prohibited Uses section text is present and verified successfully");
            }
            else
            {
                Console.WriteLine("Prohibited Uses section text is not present and cannot be verified");
            }
        }
    }
}
