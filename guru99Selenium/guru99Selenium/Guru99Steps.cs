using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace guru99Selenium
{
    [Binding]
    public class Guru99Steps
    {
        private RemoteWebDriver driver;


        [Given(@"I open firefox")]
        public void GivenIOpenFirefox()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I go to (.*)")]
        public void GivenIGoToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter (.*) as a userID")]
        public void WhenIEnterMngrAsAUserID(string uID)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElementByName("uid").SendKeys(uID);
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter (.*) as a password")]
        public void WhenIEnterUsEzavAAsAPassword(string pswd)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElementByName("password").SendKeys(pswd);
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be logged in and see '(.*)' as a welcome message")]
        public void ThenIShouldBeLoggedInAndSeeWelcomeToManagerSPageOfGuruBankAsAWelcomeMessage(string message)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElementByName("btnLogin").Click();
            string res = driver.FindElementByXPath("/html/body/table/tbody/tr/td/table/tbody/tr[2]/td/marquee").Text;
            string expMessage = "Welcome To " + message + " Page of Guru99 Bank";
            Assert.AreEqual(expMessage, res, "Error, Failed to log in");
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I clean up the test environment")]
        public void ThenICleanUpTheTestEnvironment()
        {
            driver.Quit();
            //ScenarioContext.Current.Pending();
        }
    }
}
