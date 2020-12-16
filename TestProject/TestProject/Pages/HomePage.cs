using OpenQA.Selenium;
using TestProject.Helpers;

namespace TestProject.Pages
{
    public class HomePage : BasePage
    {

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void ICloseCoockieBanner()
        {
            Wait().Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@id='CybotCookiebotDialogBodyButtonAccept']"))).Click();
        }

        public bool ISeeOurPartners()
        {
            IWebElement partners =
                Wait().Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class='site-nav__main__item__title' and text()[contains(.,'Partners')]]")));
            return partners.Displayed;
        }

        public void IClickOnMenu()
        {
            Wait().Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='icon-menu']"))).Click();
        }

        public void IClickOnPartners()
        {
            Wait().Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='site-nav__main__item__title' and text()[contains(.,'Partners')]]"))).Click();
        }

        public void IClickOnOurPartners()
        {

            Wait().Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@data-om-navcta='Partners']"))).Click();
        }

        public void IClickOnOffices()
        {

            Wait().Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='site-nav__main__item__title' and text()[contains(.,'Our offices')]]"))).Click();
        }

    }
}