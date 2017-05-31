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
            Wait.WaitForElement(Driver, By.ClassName("info-icon"));
            var infoIcon = Driver.FindElement(By.ClassName("info-icon"));
            infoIcon.Click();
        }

        public void EasyJetPlusDrawLinkClick()
        {
            Wait.WaitForElement(Driver, By.XPath("//a[text()='easyJet Plus'] "));
            var easyJetPlusDrawLink = Driver.FindElement(By.XPath("//a[text()='easyJet Plus'] "));
            easyJetPlusDrawLink.Click();
        }

        public void SelectSeatClose()
        {
            Wait.WaitForElement(Driver, By.Id("close-drawer-link"));
            var selectSeatDrawClose = Driver.FindElement(By.Id("close-drawer-link"));
            selectSeatDrawClose.Click();
            Wait.WaitForDrawToClose(Driver);
        }

        public void SelectSeatSkipClick()
        {            
            Wait.WaitForElement(Driver, By.CssSelector("button[class*=button-link]"));
            var selectSeatSkipClick = Driver.FindElement(By.CssSelector("button[class*=button-link]"));
            selectSeatSkipClick.Click();
        }
    }
}

    

