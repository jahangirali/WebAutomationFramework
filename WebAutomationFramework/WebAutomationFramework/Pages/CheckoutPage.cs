using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
