using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebAutomationFramework
{
    class Wait
    {
        private IWebDriver Driver { get; set; }

        public Wait(IWebDriver driver)
        {
            Driver = driver;
            
        }

        public void WaitForElement()
        {
            WebDriverWait wait = new WebDriverWait(driver, 30);
            //Thread.Sleep(TimeSpan.FromSeconds(3));
            //var skipButtonClick = Driver.FindElement(By.CssSelector("button[class*=skip-link]"));
            //skipButtonClick.Click();

            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("skipButtonClick")));

            //    Thread.Sleep(TimeSpan.FromSeconds(3));
            //var skipButtonClick = Driver.FindElement(By.CssSelector("button[class*=skip-link]"));
            

        }
    }
}
