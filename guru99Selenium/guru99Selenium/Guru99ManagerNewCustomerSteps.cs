using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace guru99Selenium
{
    [Binding]
    public class Guru99ManagerNewCustomerSteps
    {
        private RemoteWebDriver driver;

        [Given(@"I open firefox as the browser")]
        public void GivenIOpenFirefoxAsTheBrowser()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I visit (.*)")]
        public void GivenIVisitHttpWww_Demo_Guru_ComV(string url)
        {
            driver.Navigate().GoToUrl(url);
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter (.*) as the userID")]
        public void WhenIEnterMngrAsTheUserID(string userID)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElementByName("uid").SendKeys(userID);
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter '(.*)' as the password")]
        public void WhenIEnterUsEzavAAsThePassword(string pswd)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElementByName("password").SendKeys(pswd);
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the new customer tab")]
        public void WhenIClickTheNewCustomerTab()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElementByName("btnLogin").Click();
            driver.FindElementByXPath("/html/body/div[2]/div/ul/li[2]").Click();
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*) as the customer name")]
        public void WhenIEnterJoelAsTheCustomerName(string name)
        {
            driver.FindElementByName("name").SendKeys(name);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I select male as the gender")]
        public void WhenISelectMaleAsTheGender()
        {
            driver.FindElementByName("rad1").Click();
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*)/(.*)/(.*) as the date of birth")]
        public void WhenIEnterAsTheDateOfBirth(string day, string month, string year)
        {
            driver.FindElementByName("dob").SendKeys(day + month + year);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*) as the address")]
        public void WhenIEnterStreetAsTheAddress(string address)
        {
            driver.FindElementByName("addr").SendKeys(address);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*) as the city")]
        public void WhenIEnterNewYorkAsTheCity(string city)
        {
            driver.FindElementByName("city").SendKeys(city);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*) as the state")]
        public void WhenIEnterNewYorkAsTheState(string state)
        {
            driver.FindElementByName("state").SendKeys(state);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*) as the pin")]
        public void WhenIEnterAsThePin(string pin)
        {
            driver.FindElementByName("pinno").SendKeys(pin);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*) as the mobile number")]
        public void WhenIEnterAsTheMobileNumber(string mobileNo)
        {
            driver.FindElementByName("telephoneno").SendKeys(mobileNo);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*) as the email")]
        public void WhenIEnterJoelEmail_ComAsTheEmail(string email)
        {
            driver.FindElementByName("emailid").SendKeys(email);
            //ScenarioContext.Current.Pending();
        }

        [When(@"I enter (.*) as the password")]
        public void WhenIEnterPasswordAsThePassword(string password)
        {
            driver.FindElementByName("password").SendKeys(password);
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I should see '(.*)' as a success message")]
        public void ThenIShouldSeeAsASuccessMessage(string message)
        {
            driver.FindElementByName("sub").Click();
            string res = driver.FindElementByXPath("//*[@id='customer']/tbody/tr[1]/td/p").Text;
            Assert.AreEqual(message, res, "Error, Failed to log in");
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I clean the test environment")]
        public void ThenICleanTheTestEnvironment()
        {
            driver.Quit();
            //ScenarioContext.Current.Pending();
        }
    }
}
