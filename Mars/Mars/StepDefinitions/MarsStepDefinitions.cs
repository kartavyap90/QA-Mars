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

        [Given(@"Open portal")]
        public void GivenOpenPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User click on Sign In button\.")]
        public void WhenUserCanClickOnSignInButton_()
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
        }

        [When(@"User click on Join button\.")]
        public void WhenUserCanClickOnJoinButton_()
        {
            Login_Or_Registration_Page_Object.Click_Join_Button(driver);
        }

        [When(@"User enter registration details '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEnterRegistrationDetails(string first_name, string last_name, string email_id, string password, string confirm_password)
        {
            Login_Or_Registration_Page_Object.Enter_Registration_Details(driver, first_name, last_name, email_id, password, confirm_password);
        }

        [Then(@"User's deatils should registered")]
        public void ThenUsersDeatilsShouldRegistered()
        {
           Login_Or_Registration_Page_Object.Checked_Checkbox_And_Submit_Button(driver);
        }
      
        [Given(@"Nav\. to Mars portal")]
        public void GivenNav_ToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User click on Sign In button")]
        public void WhenUserClickOnSignInButton()
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
        }

        [When(@"User click on Forget your password link text")]
        public void WhenUserClickOnForgetYourPasswordLinkText()
        {
           Login_Or_Registration_Page_Object.Forget_Your_Password_LinkText(driver);
        }

        [When(@"Enter registered email id '([^']*)'")]
        public void WhenEnterRegisteredEmailIdAndClickOnSendVerificationEmailButton(string email_id)
        {
            Login_Or_Registration_Page_Object.enter_email_id(driver, email_id);
        }

        [Then(@"Password reset link should sent to user")]
        public void ThenPasswordResetLinkShouldSentToUser()
        {
           Login_Or_Registration_Page_Object.password_reset_link(driver);
        }
        [Given(@"Open MARS posrtal")]
        public void GivenOpenMARSPosrtal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Clcik on SIGN IN button")]
        public void WhenClcikOnSIGNINButton()
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
        }

        [When(@"Enter wrong credentials '([^']*)' '([^']*)'")]
        public void WhenEnterWrongCredentials(string wrong_email_id, string wrong_password)
        {
            Login_Or_Registration_Page_Object.Enter_Wrong_Login_Details(driver, wrong_email_id, wrong_password);
        }

        [Then(@"User should not login '([^']*)'")]
        public void ThenUserShouldNotLogin(string wrong_email_id1)
        {
            Login_Or_Registration_Page_Object.User_Nav_To_Send_Verification_Popup(driver, wrong_email_id1);
        }

        [Given(@"Opening Mars portal")]
        public void GivenOpeningMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User login into portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoPortal(string email_id, string password)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver,  email_id,  password);
        }

        [When(@"User click on AddNew button and enter details '([^']*)'")]
        public void WhenUserClickOnAddNewButtonAndEnterDetails(string language)
        {
            Login_Or_Registration_Page_Object.Add_Language(driver, language);
        }

        [Then(@"User's detail shoul registered '([^']*)'")]
        public void ThenUsersDetailShoulRegistered(string lang)
        {
            Login_Or_Registration_Page_Object.Language_Added(driver, lang);
        }
        [Given(@"Opening to Mars portal")]
        public void GivenOpeningToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login into Portal '([^']*)' '([^']*)'")]
        public void WhenLoginIntoPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
;        }

        [When(@"User click on AddNew button without entering details")]
        public void WhenUserClickOnAddNewButtonWithoutEnteringDetails()
        {
            Login_Or_Registration_Page_Object.Add_Language_without_Data(driver);
        }

        [Then(@"User received error message")]
        public void ThenUserReceivedErrorMessage()
        {
           Login_Or_Registration_Page_Object.Error_Message_For_Add_Language_without_Data(driver);
        }

        [Given(@"open portal mars")]
        public void GivenOpenPortalMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login to Portal '([^']*)' '([^']*)'")]
        public void WhenLoginToPortal(string email, string password)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, email, password);
        }

        [When(@"Edit the language and level '([^']*)'")]
        public void WhenEditTheLanguageAndLevel(string new_lang)
        {
            Login_Or_Registration_Page_Object.Edit_Language_And_Level(driver, new_lang);
        }

        [Then(@"User should successfully edited language and level")]
        public void ThenUserShouldSuccessfullyEditedLanguageAndLevel()
        {
            Login_Or_Registration_Page_Object.Edited_Language_And_Level(driver);
        }
        [Given(@"User open mars portal")]
        public void GivenUserOpenMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login to portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginToPortal(string email_id, string password)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, email_id, password);
        }

        [When(@"User click on delete button to delete language entry")]
        public void WhenUserClickOnDeleteButtonToDeleteLanguageEntry()
        {
            Login_Or_Registration_Page_Object.Delete_Language_And_Level(driver);
        }

        [Then(@"User should successfully deleted the language")]
        public void ThenUserShouldSuccessfullyDeletedTheLanguage()
        {
            Login_Or_Registration_Page_Object.Deleted_Language_And_Level(driver);
        }

        [Given(@"User Open Mars portal url")]
        public void GivenUserOpenMarsPortalUrl()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User login to portal with creddentials '([^']*)' '([^']*)'")]
        public void WhenUserLoginToPortalwithCreddentials(string email_id, string password)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, email_id, password);
        }

        [When(@"User click on Skill section and enter new skills '([^']*)'")]
        public void WhenUserClickOnSkillsSectionAndEnterNewSkills(string skill)
        {
            Login_Or_Registration_Page_Object.Add_Skill(driver, skill);
        }

        [Then(@"User's skills shoul registedred '([^']*)'")]
        public void ThenUsersSkillsShoulRegistedred(string skill)
        {
            Login_Or_Registration_Page_Object.Skill_Added(driver, skill);
        }
        [Given(@"User Opening to Mars portal")]
        public void GivenUserOpeningToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login into MARS Portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on Add button without entering details")]
        public void WhenUserClickOnAddButtonWithoutEnteringDetails()
        {
            Login_Or_Registration_Page_Object.Add_Skill_without_Data(driver);
        }

        [Then(@"User received error message for it")]
        public void ThenUserReceivedErrorMessageForIt()
        {
            Login_Or_Registration_Page_Object.Error_Message_For_Add_Skill_without_Data(driver);
        }
        [Given(@"User open portal")]
        public void GivenUserOpenPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login Portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User Edit the skill and level '([^']*)'")]
        public void WhenUserEditTheSkillAndLevel(string p0)
        {
            Login_Or_Registration_Page_Object.Edit_Skill_And_Level(driver, p0);
        }

        [Then(@"User should successfully edited skill and level")]
        public void ThenUserShouldSuccessfullyEditedSkillAndLevel()
        {
            Login_Or_Registration_Page_Object.Edited_Skill_And_Level(driver);
        }
        [Given(@"User Nav\. to mars portal")]
        public void GivenUserNav_ToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login to Portal with this credentials '([^']*)' '([^']*)'")]
        public void WhenUserLoginToPortalWithThisCredentials(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on delete icon to delete skill entry")]
        public void WhenUserClickOnDeleteIconToDeleteSkillEntry()
        {
            Login_Or_Registration_Page_Object.Delete_Skill_And_Level(driver);
        }

        [Then(@"User should successfully deleted the skill")]
        public void ThenUserShouldSuccessfullyDeletedTheSkill()
        {
            Login_Or_Registration_Page_Object.Deleted_Skill_And_Level(driver);
        }



    }
}
