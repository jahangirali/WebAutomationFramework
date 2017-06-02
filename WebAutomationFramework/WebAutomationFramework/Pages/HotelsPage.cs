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
    class HotelsPage
    {

        private IWebDriver Driver { get; set; }

        public HotelsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void SkipButtonClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[class*=skip-link]"));
            Console.WriteLine("Hotels Page");
            var skipButtonClick = Driver.FindElement(By.CssSelector("button[class*=skip-link]"));
            skipButtonClick.Click();
        }

        public void InfoButtonClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("class[*='info-icon']"));
            var InfoButtonClick = Driver.FindElement(By.CssSelector("class[*='info-icon']"));
            InfoButtonClick.Click();
        }

        public void ViewRoomsButtonClick()
        {
            Wait.WaitForElement(Driver, By.ClassName("class[class*='button hotel']"));
            var viewRoomsButtonClick = Driver.FindElement(By.ClassName("class[class*='button hotel']"));
            viewRoomsButtonClick.Click();
        }

        public void CloseDrawClick()
        {
            Wait.WaitForElement(Driver, By.Id("close-drawer-link"));
            var closeDrawClick = Driver.FindElement(By.Id("close-drawer-link"));
            closeDrawClick.Click();
        }

        public void CheckOnHotelsPage()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[title='Load more']"));
            var checkOnHotelsPage = Driver.FindElement(By.CssSelector("button[title='Load more']"));
            Assert.That(checkOnHotelsPage.Displayed, Is.True);
        }
    }
}

    

