using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class CarHirePage
    {

        private IWebDriver Driver { get; set; }

        public CarHirePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SkipButtonClick()
        {

            Wait.WaitForElement(Driver, By.CssSelector("button[class*=skip-link]"));
            var skipButtonClick = Driver.FindElement(By.CssSelector("button[class*=skip-link]"));
            skipButtonClick.Click();
        }
    }
}

