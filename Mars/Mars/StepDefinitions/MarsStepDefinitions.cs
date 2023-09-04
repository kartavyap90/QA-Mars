using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            driver.Quit();
        }

        [Given(@"Open mars portal")]
        public void GivenOpenMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User can navigate and click on the Sign button")]
        public void WhenUserCanNavigateAndClickOnTheSignButton()
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
        }

        [Then(@"Login window should open")]
        public void ThenLoginWindowShouldOpen()
        {
            Login_Or_Registration_Page_Object.Login_Window(driver);
        }
        [Given(@"Navigate to Mars portal")]
        public void GivenNavigateToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Click on Sign In button")]
        public void WhenClickOnSignInButton()
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
        }

        [When(@"Enter Email address and Password '([^']*)' '([^']*)'")]
        public void WhenEnterEmailAddressAndPassword(string email_id, string password)
        {
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver,  email_id,  password);
        }

        [Then(@"User should navigate to dashboard")]
        public void ThenUserShouldNavigateToDashboard()
        {
            Login_Or_Registration_Page_Object.dashboard(driver);
        }


    }
}
