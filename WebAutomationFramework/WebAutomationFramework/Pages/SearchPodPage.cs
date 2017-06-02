using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework
{
    class SearchPodPage
    {
        private IWebDriver Driver { get; set; }

        public SearchPodPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void CheckBoxClick()
        {
            var checkBox = Driver.FindElement(By.ClassName("checkbox"));
            Console.WriteLine("On Search Pod Page");
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

    

