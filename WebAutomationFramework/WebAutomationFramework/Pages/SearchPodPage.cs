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
            checkBox.Click();

        }

        public bool IsCheckBoxChecked()
        {
            var checkBox = Driver.FindElement(By.ClassName("checkbox"));
            return checkBox.Enabled;
        }

        public void OriginFieldClick()
        {
            var originTextField = Driver.FindElement(By.CssSelector("input[id^= origin-]"));
            originTextField.Click();
        }

        public void OriginFieldSendKeys(String originAirport)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var originTextField = Driver.FindElement(By.CssSelector("input[id^= origin-]"));
            originTextField.SendKeys(originAirport + Keys.Enter);

        }

        public void DestinationFieldClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
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
            var originDate = Driver.FindElement(By.CssSelector($"div[data-date='2017-05-31'] a"));
            originDate.Click();
        }
        public void ShowFlightsButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            var showFlights = Driver.FindElement(By.CssSelector("button[class*= search-submit]"));
            showFlights.Click();
        }

        public void HotelsTabClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var hotelsTabClick = Driver.FindElement(By.CssSelector("class[title*=Hotels]"));
            hotelsTabClick.Click();
        }

    }
}

    

