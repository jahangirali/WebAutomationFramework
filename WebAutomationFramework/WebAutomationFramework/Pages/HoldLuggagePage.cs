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
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var addHoldLuggageClick = Driver.FindElement(By.CssSelector("input[ng-click*=AddBagIfLimitNotReached]"));
            addHoldLuggageClick.Click();
        }

        public void HoldLuggageSkipButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var holdLuggageSkipButtonClick = Driver.FindElement(By.ClassName("class[*=skip-link]"));
            holdLuggageSkipButtonClick.Click();
        }

        public void HoldLuggageInfoButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var holdLuggageInfoButtonClick = Driver.FindElement(By.ClassName("info-icon"));
            holdLuggageInfoButtonClick.Click();
        }

        public void HoldLuggageInfoCloseDraw()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var holdLuggageInfoCloseDraw = Driver.FindElement(By.ClassName("back-button"));
            holdLuggageInfoCloseDraw.Click();
            //close-drawer-link
        }
        public void ContinueButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var continueButtonClick = Driver.FindElement(By.CssSelector("button[ng-class*=IsALink]"));
            continueButtonClick.Click();

        }
    }
}
