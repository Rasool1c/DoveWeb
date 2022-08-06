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
    public class Search
    {
        public static void OpenUrl()
        {
            // opening web url
            DoveHooks.driver.Navigate().GoToUrl("https://www.dove.com/in/home.html");
            DoveHooks.driver.Manage().Window.Maximize();
            Log.Information("dove web application opened");
        }
        public static void ClickOnSearch()
        {
            Thread.Sleep(5000);
            // clicking on search icon
            DoveHooks.driver.FindElement(By.XPath("//*[@class='o-navbar-label js-search-btn']")).Click();
            Log.Information("Clicked on the search button");
        }
        public static void SearchingShampoo()
        {
            Thread.Sleep(3000);
            // entering the search data through ecxcel sheet 
            DoveHooks.driver.FindElement(By.XPath("(//input[@placeholder='Type something here...'])[2]")).SendKeys(ReadExcel.ReadExcelData(0,1));
            Log.Information("search text shampooo entered");
            Thread.Sleep(2000);         
            Utilities.Screenshot.Sshot("SearchShampoo");
            // clicking on search button
            DoveHooks.driver.FindElement(By.XPath("(//button[@title='search'])[3]")).Click();
            
        }
        public static void VerifyShampoo()
        {
            Thread.Sleep(7000);
            // storing the actual data into a string
            string ShampooText = DoveHooks.driver.FindElement(By.XPath("//h2[normalize-space()='Baby Shampoo']")).Text;
            Log.Debug("extracting the text");
            string ExpectedText = "Shampoo";
            // asserting the actual data with expected data
            Assert.IsTrue(ShampooText.Contains("Shampoo"), ExpectedText);
            Log.Information("shampoo text is present and verfied succcessfully");
            if (ShampooText.Contains("Shampoo"))
            {
                Console.WriteLine("The text shampoo is present and verified successfully");
            }
            else
            {
                Console.WriteLine("The text shampoo is not present and cannot be verified");
            }
        }
    }
}
