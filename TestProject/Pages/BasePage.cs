using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public WebDriverWait Wait()
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }

    }
}