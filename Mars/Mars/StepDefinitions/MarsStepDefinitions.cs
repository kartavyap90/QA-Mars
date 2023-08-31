using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class MarsStepDefinitions
    {
        private const string Expected = "http://localhost:5000/";
        IWebDriver driver = new ChromeDriver();
        Login_Or_Registration_Page Login_Or_Registration_Page_Object = new Login_Or_Registration_Page();    

        [Given(@"Log into Mars portal")]
        public void GivenLogIntoMarsPortal()
        {

            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"New User can navigate and click on the Join button")]
        public void WhenNewUserCanNavigateAndClickOnTheJoinButton()
        {
            Login_Or_Registration_Page_Object.Click_Join_Button(driver);
        }

        [Then(@"The registration window should open")]
        public void ThenTheRegistrationWindowShouldOpen()
        {
            Login_Or_Registration_Page_Object.Registration_Window(driver);
            //driver.Quit();
        }

        [Given(@"Navigate to into Mars portal")]
        public void GivenNavigateToIntoMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Click on the Join button")]
        public void WhenClickOnTheJoinButton()
        {
            Login_Or_Registration_Page_Object.Click_Join_Button(driver);
        }

        [When(@"Enter the registration details '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenEnterTheRegistrationDetails(string first_name, string last_name, string email_id, string password, string confirm_password)
        {
            Login_Or_Registration_Page_Object.Enter_Registration_Details(driver,first_name,last_name,email_id,password,confirm_password);
        }

        [When(@"Chcked the checkbox and click submit button")]
        public void WhenChckedTheCheckboxOfTermsAndConditions()
        {
            Login_Or_Registration_Page_Object.Checked_Checkbox_And_Submit_Button(driver);
        }

        [Then(@"User details should registered")]
        public void ThenUserDetailsShouldRegistered()
        {
            Assert.AreEqual(Expected, driver.Url);
        }
    }
}
