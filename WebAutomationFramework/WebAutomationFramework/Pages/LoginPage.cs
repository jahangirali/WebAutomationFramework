using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAutomationFramework.Pages
{
    class LoginPage
    {
        private IWebDriver Driver { get; set; }

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void EmailAddress()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var emailAddressField = Driver.FindElement(By.Id("signin-username"));
            emailAddressField.SendKeys("jahangir.ali@easyjet.com");
        }

        public void Password()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var passwordField = Driver.FindElement(By.Id("signin-password"));
            passwordField.SendKeys("password123");
        }

        public void SignInButtonClick()
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var signInButtonClick = Driver.FindElement(By.Id("signin-login"));
            signInButtonClick.Click();

        }
    }
}
