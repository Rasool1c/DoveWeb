using DoveWeb.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoveWeb.Utilities
{
    public class Screenshot
    {
        public static void Sshot(string name)
        {

            ((ITakesScreenshot)DoveHooks.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may214\source\repos\DoveWeb\Utilities\ScreenShots\Screenshot" + name + ".png");
        }
    }
}
