using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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
            var counter = DateTime.Now.Ticks.ToString();
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            var filePath = @"C:\screenshot\ss_"+counter+".png";
            screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Jpeg);
            driver.Quit();
        }

        
    }
    }

