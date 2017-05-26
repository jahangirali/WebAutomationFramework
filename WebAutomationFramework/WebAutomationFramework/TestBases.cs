using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAutomationFramework.Pages
{
    public class TestBases
    {
        public IWebDriver driver;
        String url = "https://easyjet.com/en/";


        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--test-type");
            options.AddArguments("chrome.switches", "--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(url);

        }

        //[OneTimeTearDown]
        //public void TestTearDown()
        //{
        //    driver.Quit();
        //}
    }
}

