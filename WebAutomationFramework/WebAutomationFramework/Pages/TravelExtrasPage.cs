using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class TravelExtrasPage
    {

        private IWebDriver Driver { get; set; }

        public TravelExtrasPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SkipButtonClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[class*=skip-link]"));
            Console.WriteLine("Travel Extras Page");
            var skipButtonClick = Driver.FindElement(By.CssSelector("button[class*=skip-link]"));
            skipButtonClick.Click();
        }

        public void AddInsuranceCoverClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("panel[class*=extra-change]"));
            var addInsuranceCoverClick = Driver.FindElement(By.CssSelector("panel[class*=extra-change]"));
            addInsuranceCoverClick.Click();
        }

        public void TakeMeToInsuranceSelectionCloseClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("class[ng-if*=SmartMessageSettings.CloseIconUrl]"));
            var takeMeToInsuranceSelectionCloseClick = Driver.FindElement(By.CssSelector("class[ng-if*=SmartMessageSettings.CloseIconUrl]"));
            takeMeToInsuranceSelectionCloseClick.Click();

        }
    }
}

    