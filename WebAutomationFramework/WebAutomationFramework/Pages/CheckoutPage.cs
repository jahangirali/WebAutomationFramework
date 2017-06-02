using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class CheckoutPage
    {
        private IWebDriver Driver { get; set; }

        public CheckoutPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void TravelReasonBusiness()
        {
            Wait.WaitForElement(Driver, By.CssSelector("input[id*=reason-1]"));
            Console.WriteLine("On Checkout Page");
            var travelReasonBusiness = Driver.FindElement(By.CssSelector("input[id*=reason-1]"));
            travelReasonBusiness.Click();
        }

        public void TitleField()
        {
            Wait.WaitForElement(Driver, By.Id("title-dropdown-adult-1"));
            var titleField = Driver.FindElement(By.Id("title-dropdown-adult-1"));
            titleField.Click();
            titleField.SendKeys("Mr");

        }
        public void FirstNameField()
        {
            Wait.WaitForElement(Driver, By.Id("firstname-textbox-adult-1"));
            var firstName = Driver.FindElement(By.Id("firstname-textbox-adult-1"));
            firstName.Click();
            firstName.SendKeys("Bruce");
         }
        public void LastNameField()
        {
            Wait.WaitForElement(Driver, By.Id("lastname-textbox-adult-1"));
            var lastNameFieldClick = Driver.FindElement(By.Id("lastname-textbox-adult-1"));
            lastNameFieldClick.Click();
            lastNameFieldClick.SendKeys("Wayne");
        }
        public void AgeField()
        {
            Wait.WaitForElement(Driver, By.Id("age-dropdown-adult-1"));
            var ageField = Driver.FindElement(By.Id("age-dropdown-adult-1"));
            ageField.Click();
            ageField.SendKeys("18+"+Keys.Tab);
            
        }

        public void ContinueButtonClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[ng-click*=Continue]"));
            var continueButtonClick = Driver.FindElement(By.CssSelector("button[ng-click*=Continue]"));
            continueButtonClick.Click();            
        }
    }

}
