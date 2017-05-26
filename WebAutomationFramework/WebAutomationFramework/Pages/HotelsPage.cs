using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class HotelsPage
    {

        private IWebDriver Driver { get; set; }

        public HotelsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SkipButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var skipButtonClick = Driver.FindElement(By.CssSelector("button[class*=skip-link]"));

            //("input[ng-click*=AddBagIfLimitNotReached]"));
            skipButtonClick.Click();
        }

        public void InfoButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var InfoButtonClick = Driver.FindElement(By.ClassName("info-icon"));
            InfoButtonClick.Click();
        }

        public void ViewRoomsButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var viewRoomsButtonClick = Driver.FindElement(By.ClassName("class[class*=button hotel"));
            viewRoomsButtonClick.Click();
        }

        public void CloseDrawClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var closeDrawClick = Driver.FindElement(By.Id("close-drawer-link"));
            closeDrawClick.Click();
        }
    }
}

    

