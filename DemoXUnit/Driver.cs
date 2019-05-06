using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoXUnit
{
    public class Driver : IDisposable
    {
        public static IWebDriver driver;

        public Driver()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://stackoverflow.com");
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
