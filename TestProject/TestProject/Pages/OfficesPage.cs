using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestProject.Helpers;

namespace TestProject.Pages
{
    public class OfficesPage : BasePage
    {
        public OfficesPage(IWebDriver driver) : base(driver)
        {
        }

        public void IClickOnUkButton()
        {
            Actions act = new Actions(Driver);
            Thread.Sleep(7000);
            //var wait = new WebDriverWait(Driver,TimeSpan.FromSeconds(7));
            IWebElement ukSection = Wait().Until(ExpectedConditions.ElementIsVisible(By.XPath("//img[@alt='United Kingdom']")));
            act.MoveToElement(ukSection).Click().Perform();
            // Driver.FindElement(By.XPath("//img[@alt='United Kingdom']")).Click();
            //div[@class='contact-item__clickfield']//.//img[@alt='United Kingdom']
        }

        public void IGetUKOffices()
        {
            Thread.Sleep(1000);
            var partners = Wait().Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//address[@class='contact-item__office-description']")));
            foreach (var partner in partners)
            {
                Console.WriteLine(partner.Text);
            }
        }
    }
}