using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    public class BasePage
    {
        private readonly IWebDriver _driver;

        public BasePage(IWebDriver driver, By pageLocator)
        {
            _driver = driver;
            AssertElementIsDisplayed(pageLocator, 20);
        }

        private void AssertElementIsDisplayed(By elementId, int timeout)
        {
            for (var i = 0; i < timeout; i++)
            {
                try
                {
                    _driver.FindElement(elementId);
                    return;
                }
                catch (NoSuchElementException)
                {
                }
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            throw new Exception($"Could not find element {elementId} on page {GetType().Name}");
        }

    }
}
