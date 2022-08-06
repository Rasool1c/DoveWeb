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
    public class DiscoveMore
    {
        public static void ClickOnDiscoverMore()
        {
            Thread.Sleep(10000);
            // accepting the cookies
            DoveHooks.driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']")).Click();
            // clicking on the discover more under Let's #StopTheBeautyTes
            DoveHooks.driver.FindElement(By.XPath("//a[@data-title='Discover more']")).Click();
            Log.Information("clicked on discover more");
        }
        public static void VerifyDiscoverMoreText()
        {
           
            Thread.Sleep(5000);
            // storing the actual data into a string
            string DiscoverText = DoveHooks.driver.FindElement(By.XPath("(//*[@class='o-text__heading-2'])[1]")).Text;
            Log.Debug("extracting the text");
            string ExpectedText = "The Real Women behind #StopTheBeautyTest";
            // asserting the actual data with expected data
            Assert.IsTrue(DiscoverText.Contains("The Real Women behind #StopTheBeautyTest"), ExpectedText);
            Log.Information("The Real Women behind #StopTheBeautyTest text is present and verfied succcessfully");
            if (DiscoverText.Contains("The Real Women behind #StopTheBeautyTest"))
            {
                Console.WriteLine("The text The Real Women behind #StopTheBeautyTest is present and verified successfully");
            }
            else
            {
                Console.WriteLine("The text The Real Women behind #StopTheBeautyTest is not present and cannot be verified");
            }
        }
    }
}
