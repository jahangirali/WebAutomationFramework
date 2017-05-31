using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class PickFlightsPage
    {

        private IWebDriver Driver { get; set; }

        public PickFlightsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ThreeWeekView()
        {
            var threeWeekViewLink = Driver.FindElement(By.ClassName("banner-gap"));
        }

        public void FlightsGridClick()
        {
            Wait.WaitForElement(Driver, By.ClassName("banner-gap"));
            var flightsGridClick = Driver.FindElement(By.ClassName("banner-gap"));
            flightsGridClick.Click();            
        }

        public void ContinueButtonClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[ng-if*=ShowContinueButton]"));
            var continueButtonClick = Driver.FindElement(By.CssSelector("button[ng-if*=ShowContinueButton]"));
            continueButtonClick.Click();
        }

        public void ChangeSearchClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[ng-click*=ShowChangeSearch]"));
            var changeSearchClick = Driver.FindElement(By.CssSelector("button[ng-click*=ShowChangeSearch]"));
            changeSearchClick.Click();
        }

        public void HideSearchClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[ng-click*=HideChangeSearch]"));
            var hideSearchClick = Driver.FindElement(By.CssSelector("button[ng-click*=HideChangeSearch]"));
            hideSearchClick.Click();
        }

        public void RadioButtonCreditCardClick()
        {
            Wait.WaitForElement(Driver, By.Id("credit-radio"));
            var radioButtonCreditCard = Driver.FindElement(By.Id("credit-radio"));
            radioButtonCreditCard.Click();
        }
    }
}
    

