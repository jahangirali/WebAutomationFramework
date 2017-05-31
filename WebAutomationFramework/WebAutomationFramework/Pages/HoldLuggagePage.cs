using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class HoldLuggagePage
    {

        private IWebDriver Driver { get; set; }

        public HoldLuggagePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void AddHoldLuggageClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("input[ng-click*=AddBagIfLimitNotReached]"));
            var addHoldLuggageClick = Driver.FindElement(By.CssSelector("input[ng-click*=AddBagIfLimitNotReached]"));
            addHoldLuggageClick.Click();
        }

        public void HoldLuggageSkipButtonClick()
        {
            Wait.WaitForElement(Driver, By.ClassName("class[*=skip-link]"));
            var holdLuggageSkipButtonClick = Driver.FindElement(By.ClassName("class[*=skip-link]"));
            holdLuggageSkipButtonClick.Click();
        }

        public void HoldLuggageInfoButtonClick()
        {
            Wait.WaitForElement(Driver, By.ClassName("info-icon"));
            var holdLuggageInfoButtonClick = Driver.FindElement(By.ClassName("info-icon"));
            holdLuggageInfoButtonClick.Click();
        }

        public void HoldLuggageInfoCloseDraw()
        {
            Wait.WaitForElement(Driver, By.ClassName("back-button"));
            var holdLuggageInfoCloseDraw = Driver.FindElement(By.ClassName("back-button"));
            holdLuggageInfoCloseDraw.Click();
            //close-drawer-link
        }
        public void ContinueButtonClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[ng-class*=IsALink]"));
            var continueButtonClick = Driver.FindElement(By.CssSelector("button[ng-class*=IsALink]"));
            continueButtonClick.Click();

        }
    }
}
