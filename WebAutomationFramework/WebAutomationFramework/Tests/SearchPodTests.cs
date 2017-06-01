using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebAutomationFramework.Pages;

namespace WebAutomationFramework.Tests
{
    [TestFixture]
    public class SearchPodTests: TestBases
    {
        //IWebDriver driver = new ChromeDriver();
        //String url = "https://easyjet.com/en/";

        [Test]
        public void Test01AssertDefaultValues()
        {
            var closeDrawer = driver.FindElement(By.Id("close-drawer-link"));
            closeDrawer.Click();

            // /////////////////
            //01 Search Pod Page
            // ////////////////
            SearchPodPage spPage = new SearchPodPage(driver);

            spPage.CheckBoxClick();
            Assert.That(spPage.IsCheckBoxChecked, Is.True);

            spPage.OriginFieldClick();
            spPage.OriginFieldSendKeys("AMS");

            spPage.DestinationFieldClick();
            spPage.DestinationFieldSendKeys("LTN");

            spPage.DepartingCalendarClick();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            spPage.OriginCalendarDateSelect();

            spPage.ShowFlightsButtonClick();

            // /////////////////
            //02 Pick Flights Page
            // ////////////////
            PickFlightsPage pfPage = new PickFlightsPage(driver);
            pfPage.FlightsGridClick();

            pfPage.RadioButtonCreditCardClick();
            // pfPage.ChangeSearchClick();

            // pfPage.HideSearchClick();
            pfPage.ContinueButtonClick();

            // /////////////////
            //03 Seat Selection Page
            // ////////////////
            SeatSelectionPage ssPage = new SeatSelectionPage(driver);
            ssPage.InfoIconClick();

            //ssPage.EasyJetPlusDrawLinkClick();
            ssPage.SelectSeatClose();

            ssPage.SelectSeatSkipClick();

            // /////////////////
            //04 Hold Luggage Page
            // ////////////////
            HoldLuggagePage hlPage = new HoldLuggagePage(driver);
            hlPage.AddHoldLuggageClick();
            hlPage.HoldLuggageInfoButtonClick();

            hlPage.HoldLuggageInfoCloseDraw();

            hlPage.AddHoldLuggageClick();
            hlPage.ContinueButtonClick();

            // /////////////////
            //05 Travel Extras Page
            // ////////////////

            var tePage = new TravelExtrasPage(driver);
            // tePage.TakeMeToInsuranceSelectionCloseClick();
            // tePage.AddInsuranceCoverClick();
            tePage.SkipButtonClick();

            // /////////////////
            //06 Hotels
            // ////////////////

            HotelsPage hPage = new HotelsPage(driver);

            //hPage.ViewRoomsButtonClick();
            hPage.CheckOnHotelsPage();
            hPage.InfoButtonClick();
            hPage.CloseDrawClick();
            hPage.SkipButtonClick();


            // /////////////////
            //07 Car Hire
            // ////////////////

            var chPage = new CarHirePage(driver);
            chPage.SkipButtonClick();


            // /////////////////
            //08 Login Page
            // ////////////////

            var lpPage = new LoginPage(driver);
            lpPage.EmailAddress();
            lpPage.Password();
            lpPage.SignInButtonClick();

            // /////////////////
            //09 Login Page
            // ////////////////
            var coPage = new CheckoutPage(driver);

            coPage.TravelReasonBusiness();
            //// coPage.TravelReasonsLeisure();

            coPage.TitleField();
            coPage.FirstNameField();
            coPage.LastNameField();
            coPage.AgeField();
            //coPage.RequestSpecialAssistanceClick();
            //coPage.BlindClick();
            coPage.ContinueButtonClick();

        }

        [Test]
        public void Test02()
        {

            var closeDrawer = driver.FindElement(By.Id("close-drawer-link"));
            closeDrawer.Click();


            var checkBox = driver.FindElement(By.ClassName("checkbox"));
            checkBox.Click();
            var originTextField = driver.FindElement(By.CssSelector("input[id^= origin-]"));
            var destinationTextField = driver.FindElement(By.CssSelector("input[id^=destination-]"));
            //var departureAirportButton = driver.FindElement(By.CssSelector("text[id^origin-"));
            var outBoundDatePicker = driver.FindElement(By.ClassName("route-date-picker-control"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Equals(outBoundDatePicker.Enabled.Equals(true));
            outBoundDatePicker.Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));
            var outBoundDatePickerDraw = driver.FindElement(By.CssSelector($"div[data-date='2017-05-20'] a"));
            outBoundDatePickerDraw.Click();


            var showFlightsButton = driver.FindElement(By.CssSelector($"button[class$='search-submit']"));

            Console.WriteLine(destinationTextField.GetAttribute("placeholder"));
            Assert.That(originTextField.GetAttribute("placeholder").Contains("London"));
            Assert.That(destinationTextField.GetAttribute("placeholder").Contains("Nice"));
            Assert.That(checkBox.Enabled, Is.True);

            showFlightsButton.Click();
        }

        [Test]
        public void Test03()
        {

            var checkBox = driver.FindElement(By.ClassName("checkbox"));
            checkBox.Click();

            var originTextField = driver.FindElement(By.CssSelector("input[id^= origin-]"));
            originTextField.Click();
            originTextField.SendKeys("Barcelona");
            originTextField.SendKeys(Keys.Enter);

            var destinationTextField = driver.FindElement(By.CssSelector("input[id^=destination-]"));
            destinationTextField.Click();
            destinationTextField.SendKeys("Basel");
            destinationTextField.SendKeys(Keys.Enter);

            var adultsPlus = driver.FindElement(By.ClassName("quantity-button-add"));
            adultsPlus.Click();

            var specialAssistanceLink = driver.FindElement(By.CssSelector($"button[class^='special-assistance']"));
            specialAssistanceLink.Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));
            var specialAssistanceDraw = driver.FindElement(By.CssSelector($"button[ng-click='DoConfirm()']"));
            Thread.Sleep(TimeSpan.FromSeconds(2));

            specialAssistanceDraw.Click();
            var showFlightsButton = driver.FindElement(By.CssSelector($"button[class^='search-submit']"));
            showFlightsButton.Click();

        }

        [Test]
        public void Test04()
        {
            var spPage = new SearchPodPage(driver);

            var closeDrawer = driver.FindElement(By.Id("close-drawer-link"));
            closeDrawer.Click();

            spPage.CheckBoxClick();
            //spPage.HotelsTabClick();
        }

        [Test]
        public void Step01SearchPodTests()
        {
            var spPage = new SearchPodPage(driver);

            var closeDrawer = driver.FindElement(By.Id("close-drawer-link"));
            closeDrawer.Click();

            spPage.CheckBoxClick();
            spPage.CheckBoxClick();

        }


    }

}

