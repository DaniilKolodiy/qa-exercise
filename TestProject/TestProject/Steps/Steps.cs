using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestProject.Helpers;
using TestProject.Pages;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject
{
    [Binding]
    public class Steps
    {

        private IWebDriver _driver;
        [AfterScenario]
        public void CloseDriver()
        {
            _driver.Quit();
        }
        [Given(@"I go to home page on (.*)")]
        public void GivenIGoToHomePageOn(string Browser)
        {
            switch (Browser)
            {
                case "Chrome":
                    _driver = new DriversClass().Create(BrowserType.Chrome);
                    _driver.Navigate().GoToUrl("https://www.valtech.com/en-gb/");
                    break;
                case "Edge":
                    _driver = new DriversClass().Create(BrowserType.Edge);
                    _driver.Navigate().GoToUrl("https://www.valtech.com/en-gb/");
                    break;
                case "Firefox":
                    _driver = new DriversClass().Create(BrowserType.Firefox);
                    _driver.Navigate().GoToUrl("https://www.valtech.com/en-gb/");
                    break;
            }


        }
        [Given(@"I close coockie banner")]
        public void GivenICloseCoockieBanner()
        {
            HomePage myHomePage = new HomePage(_driver);
            myHomePage.ICloseCoockieBanner();
        }

        [Given(@"I see Our Parters")]
        public void GivenISeeOurParters()
        {
            HomePage myHomePage = new HomePage(_driver);
            Assert.IsTrue(myHomePage.ISeeOurPartners());
        }

        [Given(@"I click on menu button")]
        public void GivenIClickOnMenuButton()
        {
            HomePage myHomePage = new HomePage(_driver);
            myHomePage.IClickOnMenu();
        }
        [When(@"I click on Partners button")]
        public void WhenIClickOnPartnersButton()
        {
            HomePage myHomePage = new HomePage(_driver);
            myHomePage.IClickOnPartners();
        }

        [When(@"I click on Our Partners")]
        public void WhenIClickOnOurPartners()
        {
            HomePage myHomePage = new HomePage(_driver);
            myHomePage.IClickOnOurPartners();
        }
        [Then(@"I can get list of our partners")]
        public void ThenICanGetListOfOurPartners()
        {
            OurPartnersPage myOurPartnersPage = new OurPartnersPage(_driver);
            myOurPartnersPage.GetAllPartners();
        }

        [When(@"I click on Ofices button")]
        public void WhenIClickOnOficesButton()
        {
            HomePage myHomePage = new HomePage(_driver);
            myHomePage.IClickOnOffices();
        }
        [When(@"I click on UK section")]
        public void WhenIClickOnUKSection()
        {
            OfficesPage myOfficesPage = new OfficesPage(_driver);
            myOfficesPage.IClickOnUkButton();
        }

        [Then(@"I can get list of UK offices")]
        public void ThenICanGetListOfUKOffices()
        {
            OfficesPage myOfficesPage = new OfficesPage(_driver);
            myOfficesPage.IGetUKOffices();
        }

        [Given(@"I close cookie banner")]
        public void GivenICloseCookieBanner()
        {
            HomePage myHomePage = new HomePage(_driver);
            myHomePage.ICloseCoockieBanner();
        }

    }
}
