using Mars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Numerics;

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

        [When(@"User click on AddNew button withoust entering details")]
        public void WhenUserClickOnAddNewButtonWithoustEnteringDetails()
        {
            Login_Or_Registration_Page_Object.Add_Language_without_Data(driver);
        }

        [Then(@"User received error message")]
        public void ThenUserReceivedErrorMessage()
        {
           Login_Or_Registration_Page_Object.Error_Message_For_Language_Add(driver);
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
        [Given(@"User Opening Mars portal")]
        public void GivenUserOpeningMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login to mars portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginToMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User Click on AddNew button and enter skill '([^']*)'")]
        public void WhenUserClickOnAddNewButtonAndEnterSkill(string p0)
        {
            Login_Or_Registration_Page_Object.Add_Skill(driver, p0);
        }

        [Then(@"User details should registered '([^']*)'")]
        public void ThenUserDetailsShouldRegistered(string p0)
        {
            Login_Or_Registration_Page_Object.Skill_Added(driver, p0);
        }
        [Given(@"Opening to portal Mars")]
        public void GivenOpeningToPortalMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login to Mars Portal '([^']*)' '([^']*)'")]
        public void WhenLoginToMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on AddNew button without entering skill details")]
        public void WhenUserClickOnAddNewButtonWithoutEnteringSkillDetails()
        {
            Login_Or_Registration_Page_Object.Add_Skill_without_Data(driver);
        }

        [Then(@"User received error message for it")]
        public void ThenUserReceivedErrorMessageForIt()
        {
            Login_Or_Registration_Page_Object.Error_Message_For_Add_Skill_without_Data(driver);
        }
        [Given(@"open to portal mars")]
        public void GivenOpenToPortalMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login to Portal Mars '([^']*)' '([^']*)'")]
        public void WhenLoginToPortalMars(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"Edit the skill and level '([^']*)'")]
        public void WhenEditTheSkillAndLevel(string p0)
        {
            Login_Or_Registration_Page_Object.Edit_Skill_And_Level(driver, p0);
        }

        [Then(@"User should successfully edited skill and level")]
        public void ThenUserShouldSuccessfullyEditedSkillAndLevel()
        {
            Login_Or_Registration_Page_Object.Edited_Skill_And_Level(driver);
        }
        [Given(@"User open to mars portal")]
        public void GivenUserOpenToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login to portal mars '([^']*)' '([^']*)'")]
        public void WhenUserLoginToPortalMars(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on delete button to delete skill entry")]
        public void WhenUserClickOnDeleteButtonToDeleteSkillEntry()
        {
            Login_Or_Registration_Page_Object.Delete_Skill_And_Level(driver);
        }

        [Then(@"User should successfully deleted the skill")]
        public void ThenUserShouldSuccessfullyDeletedTheSkill()
        {
            Login_Or_Registration_Page_Object.Deleted_Skill_And_Level(driver);
        }
        [Given(@"Launch portal")]
        public void GivenLaunchPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User login to portal with details '([^']*)' '([^']*)'")]
        public void WhenUserLoginToPortalWithDetails(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User can click on the edit dropdown")]
        public void WhenUserCanClickOnTheEditDropdown()
        {
            Login_Or_Registration_Page_Object.Click_Edit_Dropdown(driver);
        }

        [Then(@"User should successfully click on edit dropdown")]
        public void ThenUserShouldSuccessfullyClickOnEditDropdown()
        {
            Login_Or_Registration_Page_Object.Clicked_Edit_Dropdown(driver);
        }
        [Given(@"User can Launch portal")]
        public void GivenUserCanLaunchPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User can login to portal with details '([^']*)' '([^']*)'")]
        public void WhenUserCanLoginToPortalWithDetails(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User can edit the First name and last name '([^']*)' '([^']*)'")]
        public void WhenUserCanEditTheFirstNameAndLastNameDEF(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Edit_First_And_Last_Name(driver, p0, p1);
        }

        [Then(@"User should successfully edit the First and last name '([^']*)' '([^']*)'")]
        public void ThenUserShouldSuccessfullyEditTheFirstAndLastName_(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Edited_First_And_Last_Name(driver, p0, p1);
        }
        [Given(@"User can Launch the Mars portal")]
        public void GivenUserCanLaunchTheMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User can login into the Mars portal with details '([^']*)' '([^']*)'")]
        public void WhenUserCanLoginIntoTheMarsPortalWithDetails(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User enter the First name and last name as blank")]
        public void WhenUserEnterTheFirstNameAndLastNameAsBlank()
        {
            Login_Or_Registration_Page_Object.First_And_Last_Name_As_Blank(driver);
        }

        [Then(@"User should receive error message for blank first and last name")]
        public void ThenUserShouldReceiveErrorMessageForBlankFirstAndLastName()
        {
            Login_Or_Registration_Page_Object.Error_Message_First_And_Last_Name_As_Blank(driver);
        }
        [Given(@"User can Launch Mars portal")]
        public void GivenUserCanLaunchMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User can login to Mars portal with details '([^']*)' '([^']*)'")]
        public void WhenUserCanLoginToMarsPortalWithDetails(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User can enter the First name and last name as white space '([^']*)' '([^']*)'")]
        public void WhenUserCanEnterTheFirstNameAndLastNameAsWhiteSpace(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.First_And_Last_Name_As_White_Space(driver, p0, p1);
        }

        [Then(@"User should receive error message for white space first and last name '([^']*)' '([^']*)'")]
        public void ThenUserShouldReceiveErrorMessageForWhiteSpaceFirstAndLastName(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Error_Message_First_And_Last_Name_As_White_Space(driver, p0, p1);
        }
        [Given(@"User nav to mars portal")]
        public void GivenUserNavToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User login into the portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoThePortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the edit icon of the availability")]
        public void WhenUserClickOnTheEditIconOfTheAvailability()
        {
            Login_Or_Registration_Page_Object.Click_Edit_Icon_Of_Availability(driver);
        }

        [Then(@"User should successfully click on the edit icon")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIcon()
        {
            Login_Or_Registration_Page_Object.Clicked_Edit_Icon_Of_Availability(driver);
        }
        [Given(@"User nav\. to mars portal")]
        public void GivenUserNav_ToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User login into the mars portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the cross icon of the availability")]
        public void WhenUserClickOnTheCrossIconOfTheAvailability()
        {
            Login_Or_Registration_Page_Object.Click_Edit_Icon_Of_Availability(driver);
            Login_Or_Registration_Page_Object.Click_Cross_Icon_Of_Availability(driver);
        }

        [Then(@"User should successfully click on the cross icon")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIcon()
        {
            Login_Or_Registration_Page_Object.Clicked_Cross_Icon_Of_Availability(driver);
        }
        [Given(@"User launch to mars portal")]
        public void GivenUserLaunchToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"The Mars Portal: User Sign-In '([^']*)' '([^']*)'")]
        public void WhenTheMarsPortalUserSign_In(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the edit icon and change the value of the availability")]
        public void WhenUserClickOnTheEditIconAndChangeTheValueOfTheAvailability()
        {
            Login_Or_Registration_Page_Object.Change_Value_Of_Availability(driver);
        }

        [Then(@"User should successfully change the value of the availability")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheAvailability()
        {
            Login_Or_Registration_Page_Object.Changed_Value_Of_Availability(driver);
        }

        [Given(@"User navi\. to mars portal")]
        public void GivenUserNavi_ToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Logging into the Mars portal as a user '([^']*)' '([^']*)'")]
        public void WhenLoggingIntoTheMarsPortalAsAUser(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the edit icon of the hours")]
        public void WhenUserClickOnTheEditIconOfTheHours()
        {
            Login_Or_Registration_Page_Object.Click_Edit_Icon_Of_Hours(driver);
        }

        [Then(@"User should successfully click on the edit icon of the hours")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIconOfTheHours()
        {
            Login_Or_Registration_Page_Object.Clicked_Edit_Icon_Of_Hours(driver);
        }
        [Given(@"User navig\. to mars portal")]
        public void GivenUserNavig_ToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);

        }

        [When(@"User Accessing the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserAccessingTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the cross icon of the hours")]
        public void WhenUserClickOnTheCrossIconOfTheHours()
        {
            Login_Or_Registration_Page_Object.Click_Edit_Icon_Of_Hours(driver);
            Login_Or_Registration_Page_Object.Click_Cross_Icon_Of_Hours(driver);
        }

        [Then(@"User should successfully click on the cross icon of hours")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIconOfHours()
        {
            Login_Or_Registration_Page_Object.Clicked_Cross_Icon_Of_Hours(driver);
        }
        [Given(@"User Launch to the mars portal")]
        public void GivenUserLaunchToTheMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login to the Martian Portal as a User '([^']*)' '([^']*)'")]
        public void WhenLoginToTheMartianPortalAsAUser(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the edit icon and change the value of the hours")]
        public void WhenUserClickOnTheEditIconAndChangeTheValueOfTheHours()
        {
            Login_Or_Registration_Page_Object.Change_Value_Of_Hours(driver);
        }

        [Then(@"User should successfully change the value of the hours")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheHours()
        {
            Login_Or_Registration_Page_Object.Changed_Value_Of_Hours(driver);
        }
        [Given(@"User naviga\. to mars portal")]
        public void GivenUserNaviga_ToMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Logging Into Mars portal as a user '([^']*)' '([^']*)'")]
        public void WhenLoggingIntoMarsPortalAsAUser(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the edit icon of the earn target")]
        public void WhenUserClickOnTheEditIconOfTheEarnTarget()
        {
            Login_Or_Registration_Page_Object.Click_Edit_Icon_Of_Earn_Target(driver);
        }

        [Then(@"User should successfully click on the edit icon of the earn target")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIconOfTheEarnTarget()
        {
            Login_Or_Registration_Page_Object.Clicked_Edit_Icon_Of_Earn_Target(driver);
        }
        [Given(@"User launch the mars portal")]
        public void GivenUserLaunchTheMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Mars Portal User Access '([^']*)' '([^']*)'")]
        public void WhenMarsPortalUserAccess(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the cross icon of the earn target")]
        public void WhenUserClickOnTheCrossIconOfTheEarnTarget()
        {
            Login_Or_Registration_Page_Object.Click_Edit_Icon_Of_Earn_Target(driver);
            Login_Or_Registration_Page_Object.Click_Cross_Icon_Of_Earn_Target(driver);
        }

        [Then(@"User should successfully click on the cross icon of earn target")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIconOfEarnTarget()
        {
            Login_Or_Registration_Page_Object.Clicked_Cross_Icon_Of_Earn_Target(driver);
        }
        [Given(@"User to Launch the mars portal")]
        public void GivenUserToLaunchTheMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login to Martian Portal as a User '([^']*)' '([^']*)'")]
        public void WhenLoginToMartianPortalAsAUser(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the edit icon and change the value of the earn target")]
        public void WhenUserClickOnTheEditIconAndChangeTheValueOfTheEarnTarget()
        {
            Login_Or_Registration_Page_Object.Change_Value_Of_Earn_Target(driver);
        }

        [Then(@"User should successfully change the value of the earn target")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheEarnTarget()
        {
            Login_Or_Registration_Page_Object.Changed_Value_Of_Earn_Target(driver);
        }


    }
}
