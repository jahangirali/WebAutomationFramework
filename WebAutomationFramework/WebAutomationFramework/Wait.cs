using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebAutomationFramework
{
    public static class Wait
    {
        public static void WaitForElement(IWebDriver driver, By by)
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));          
           wait.Until(ExpectedConditions.ElementIsVisible(by));            
        }

        public static void WaitForDrawToClose(IWebDriver driver)
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
           wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div[class=drawer drawer-angular anim-slide-rtr ng-hide]")));
        }
    }
}
