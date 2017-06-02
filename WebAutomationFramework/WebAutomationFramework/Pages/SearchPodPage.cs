using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WebAutomationFramework.Pages;

namespace WebAutomationFramework
{
    class SearchPodPage: BasePage
    {
        private IWebDriver Driver { get; set; }
        private static By PageLocator = By.ClassName("checkbox");

        public SearchPodPage(IWebDriver driver) : base(driver, PageLocator)
        {
            Driver = driver;
            Console.WriteLine("Search Pod Page has loaded");
        }

        public void CheckBoxClick()
        {
            var checkBox = Driver.FindElement(By.ClassName("checkbox"));
            checkBox.Click();

        }

        public bool IsCheckBoxChecked()
        {
            var checkBox = Driver.FindElement(By.ClassName("checkbox"));
            return checkBox.Enabled;
        }

        public void OriginFieldClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("input[id^= origin-]"));
            var originTextField = Driver.FindElement(By.CssSelector("input[id^= origin-]"));
            originTextField.Click();
        }

        public void OriginFieldSendKeys(String originAirport)
        {
            Wait.WaitForElement(Driver, By.CssSelector("input[id^= origin-]"));
            var originTextField = Driver.FindElement(By.CssSelector("input[id^= origin-]"));
            originTextField.SendKeys(originAirport + Keys.Enter);
        }

        public void DestinationFieldClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("input[id^= origin-]"));
            var destinationTestField = Driver.FindElement(By.CssSelector("input[id^=destination-]"));
            destinationTestField.Click();
        }

        public void DestinationFieldSendKeys(String destinationAirport)
        {
            var destinationTextField = Driver.FindElement(By.CssSelector("input[id^= destination-]"));
            destinationTextField.SendKeys(destinationAirport + Keys.Enter);

        }
        public void DepartingCalendarClick()
        {
            var departingCalendar = Driver.FindElement(By.ClassName("calendar"));
            departingCalendar.Click();
        }
        public void OriginCalendarDateSelect()
        {
            var originDateInsert = DateTime.UtcNow.AddDays(7).ToString("yyyy-MM-dd");
            var originDate = Driver.FindElement(By.CssSelector($"div[data-date='{originDateInsert}'] a"));
            originDate.Click();
        }
        public void ShowFlightsButtonClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("button[class*= search-submit]"));
            var showFlights = Driver.FindElement(By.CssSelector("button[class*= search-submit]"));
            showFlights.Click();
        }

        public void HotelsTabClick()
        {
            Wait.WaitForElement(Driver, By.CssSelector("class[title*=Hotels]"));
            var hotelsTabClick = Driver.FindElement(By.CssSelector("class[title*=Hotels]"));
            hotelsTabClick.Click();
        }

    }
}

    

