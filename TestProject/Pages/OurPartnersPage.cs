using System;
using OpenQA.Selenium;
using TestProject.Helpers;

namespace TestProject.Pages
{
    public class OurPartnersPage : BasePage
    {
        public OurPartnersPage(IWebDriver driver) : base(driver)
        {
        }

        public void GetAllPartners()
        {
            var partners = Wait().Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("//a[@class='partners-block__logo']")));
            foreach (var partner in partners)
            {
                Console.WriteLine(partner.GetAttribute("href"));
            }

        }
    }
}