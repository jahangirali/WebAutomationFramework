using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class TravelExtras
    {

        private IWebDriver Driver { get; set; }

        public TravelExtrasPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SkipButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            var skipButtonClick = Driver.FindElement(By.CssSelector("button[class*=skip-link]"));
            skipButtonClick.Click();
        }

        public void AddInsuranceCoverClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            var addInsuranceCoverClick = Driver.FindElement(By.CssSelector("panel[class*=extra-change]"));
            addInsuranceCoverClick.Click();
        }

        public void TakeMeToInsuranceSelectionCloseClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            //var takeMeToInsuranceSelectionCloseClick = Driver.FindElement(By.ClassName("close-icon"));
            var takeMeToInsuranceSelectionCloseClick = Driver.FindElement(By.CssSelector("class[ng-if*=SmartMessageSettings.CloseIconUrl"));
            takeMeToInsuranceSelectionCloseClick.Click();

        }
    }
}

    