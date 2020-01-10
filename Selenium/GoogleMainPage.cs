using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    public class GoogleMainPage
    {
        private static ChromeDriver _driver;

        public void startChrome()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void navigateGoogleMainPage()
        {
            _driver.Url = "http://www.google.com";
        }

        public void findGoogleLogo()
        {
            _driver.FindElement(By.Id("hplogo"));
        }

        public void checkElement(string xpath)
        {
            _driver.FindElementByXPath(xpath);
        }

        /// <summary>
        ///  closes Chrome brwoser AND quits chromdriver.exe
        /// </summary>
        public void closeChrome()
        {
            _driver.Quit();
        }
    }
}
