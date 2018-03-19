using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace FourthSelenium
{
    public class BrowserDriver
    {
        public static IWebDriver Instance { get; set; }
        public static IJavaScriptExecutor Jse { get; set; }
        //public static SelectElement Sel { get; set; }
        public static string DriverPath { get; set; }
        public static string ChromeDriverPath { get; set; }
        public void Initialise()
        {

            //ChromeDriverPath = @"C:\Users\hamid.iqbal\Downloads\chromedriver_win32\chromedriver.exe";

            //Instance = new InternetExplorerDriver(DriverPath,IESettings);
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Jse = ((IJavaScriptExecutor)BrowserDriver.Instance);
            
        }
    }
}
