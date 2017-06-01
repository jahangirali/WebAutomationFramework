using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
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
            //Wait.WaitForElement(Driver, By.CssSelector("input[ng-class*='HasReachedMaximumBaggageAllowance']"));
            //var addHoldLuggageClick = Driver.FindElement(By.CssSelector("input[ng-class*='HasReachedMaximumBaggageAllowance']"));
            Wait.WaitForElement(Driver, By.CssSelector("input[ng-click*='bagOption.Bag']:last-child"));
            
            var addHoldLuggageClick = Driver.FindElement(By.CssSelector("input[ng-click*='bagOption.Bag']:last-child"));
            addHoldLuggageClick.Click();
        }

        public void HoldLuggageSkipButtonClick()
        {
            //Wait.WaitForElement(Driver, By.ClassName("class[*=skip-link]"));
            var holdLuggageSkipButtonClick = Driver.FindElement(By.ClassName("class[*=skip-link]"));
            holdLuggageSkipButtonClick.Click();
        }

        public void HoldLuggageInfoButtonClick()
        {
            //Wait.WaitForElement(Driver, By.CssSelector("a[ng-click*='DoInfoIconClick']"));
            //var holdLuggageInfoButtonClick = Driver.FindElement(By.CssSelector("a[ng-click*='DoInfoIconClick']"));
            Wait.WaitForElement(Driver, By.ClassName("info-icon"));
            var holdLuggageInfoButtonClick = Driver.FindElement(By.ClassName("info-icon"));
            holdLuggageInfoButtonClick.Click();
        }

        public void HoldLuggageInfoCloseDraw()
        {
            Wait.WaitForElement(Driver, By.Id("close-drawer-link"));
            var holdLuggageInfoCloseDraw = Driver.FindElement(By.Id("close-drawer-link"));
            holdLuggageInfoCloseDraw.Click();
            
        }
        public void ContinueButtonClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[ng-if*='ShowContinueButton']"));
            var continueButtonClick = Driver.FindElement(By.CssSelector("button[ng-if*='ShowContinueButton']"));
            continueButtonClick.Click();

        }
    }
}
