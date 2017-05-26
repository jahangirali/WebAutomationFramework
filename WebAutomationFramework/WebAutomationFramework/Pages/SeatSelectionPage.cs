using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class SeatSelectionPage
    {
        private IWebDriver Driver { get; set; }

        public SeatSelectionPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void InfoIconClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var infoIcon = Driver.FindElement(By.ClassName("info-icon"));
            infoIcon.Click();
        }

        public void EasyJetPlusDrawLinkClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            //var easyJetPlusDrawLink = Driver.FindElement(By.ClassName("navigation-link"));
            //var continueButtonClick = Driver.FindElement(By.CssSelector("button[ng-class*=IsALink]"));
            //continueButtonClick.Click();
            var easyJetPlusDrawLink = Driver.FindElement(By.XPath("//a[text()='easyJet Plus'] "));
            easyJetPlusDrawLink.Click();
        }

        public void SelectSeatClose()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var selectSeatDrawClose = Driver.FindElement(By.Id("close-drawer-link"));
            selectSeatDrawClose.Click();
        }

        public void SelectSeatSkipClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var selectSeatSkipClick = Driver.FindElement(By.CssSelector("button[ng-click*=SkipButtonHandler]"));
            selectSeatSkipClick.Click();
        }
    }
}

    

