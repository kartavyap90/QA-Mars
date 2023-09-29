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
        Profile_Panel_Dashboard_Page Profile_Panel_Dashboard_Page_Object = new Profile_Panel_Dashboard_Page();
        Description_Tab_Page Description_Tab_Page_Object = new Description_Tab_Page();
        Language_Tab_Page Language_Tab_Object = new Language_Tab_Page();
        Skill_Tab_Page Skill_Tab_Page_Object = new Skill_Tab_Page();
        Education_Tab_Page Education_Tab_Page_Object = new Education_Tab_Page();
        Certification_Tab_Page Certification_Tab_Page_Object = new Certification_Tab_Page();

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
            Login_Or_Registration_Page_Object.Users_Details_Registered(driver);
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
           Login_Or_Registration_Page_Object.Users_Details_Registered(driver);
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
            Language_Tab_Object.Add_Language(driver, language);
        }

        [Then(@"User's detail shoul registered '([^']*)'")]
        public void ThenUsersDetailShoulRegistered(string lang)
        {
            Language_Tab_Object.Language_Added(driver, lang);
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
            Language_Tab_Object.Add_Language_without_Data(driver);
        }

        [Then(@"User received error message")]
        public void ThenUserReceivedErrorMessage()
        {
            Language_Tab_Object.Error_Message_For_Language_Add(driver);
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
            Language_Tab_Object.Edit_Language_And_Level(driver, new_lang);
        }

        [Then(@"User should successfully edited language and level")]
        public void ThenUserShouldSuccessfullyEditedLanguageAndLevel()
        {
            Language_Tab_Object.Edited_Language_And_Level(driver);
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
            Language_Tab_Object.Delete_Language_And_Level(driver);
        }

        [Then(@"User should successfully deleted the language")]
        public void ThenUserShouldSuccessfullyDeletedTheLanguage()
        {
            Language_Tab_Object.Deleted_Language_And_Level(driver);
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
            Skill_Tab_Page_Object.Add_Skill(driver, p0);
        }

        [Then(@"User details should registered '([^']*)'")]
        public void ThenUserDetailsShouldRegistered(string p0)
        {
            Skill_Tab_Page_Object.Skill_Added(driver, p0);
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
            Skill_Tab_Page_Object.Add_Skill_without_Data(driver);
        }

        [Then(@"User received error message for it")]
        public void ThenUserReceivedErrorMessageForIt()
        {
            Skill_Tab_Page_Object.Error_Message_For_Add_Skill_without_Data(driver);
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
            Skill_Tab_Page_Object.Edit_Skill_And_Level(driver, p0);
        }

        [Then(@"User should successfully edited skill and level")]
        public void ThenUserShouldSuccessfullyEditedSkillAndLevel()
        {
            Skill_Tab_Page_Object.Edited_Skill_And_Level(driver);
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
            Skill_Tab_Page_Object.Delete_Skill_And_Level(driver);
        }

        [Then(@"User should successfully deleted the skill")]
        public void ThenUserShouldSuccessfullyDeletedTheSkill()
        {
            Skill_Tab_Page_Object.Deleted_Skill_And_Level(driver);
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
            Profile_Panel_Dashboard_Page_Object.Click_Edit_Dropdown(driver);
        }

        [Then(@"User should successfully click on edit dropdown")]
        public void ThenUserShouldSuccessfullyClickOnEditDropdown()
        {
            Profile_Panel_Dashboard_Page_Object.Clicked_Edit_Dropdown(driver);
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
            Profile_Panel_Dashboard_Page_Object.Edit_First_And_Last_Name(driver, p0, p1);
        }

        [Then(@"User should successfully edit the First and last name '([^']*)' '([^']*)'")]
        public void ThenUserShouldSuccessfullyEditTheFirstAndLastName_(string p0, string p1)
        {
            Profile_Panel_Dashboard_Page_Object.Edited_First_And_Last_Name(driver, p0, p1);
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
            Profile_Panel_Dashboard_Page_Object.First_And_Last_Name_As_Blank(driver);
        }

        [Then(@"User should receive error message for blank first and last name")]
        public void ThenUserShouldReceiveErrorMessageForBlankFirstAndLastName()
        {
            Profile_Panel_Dashboard_Page_Object.Error_Message_First_And_Last_Name_As_Blank(driver);
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
            Profile_Panel_Dashboard_Page_Object.First_And_Last_Name_As_White_Space(driver, p0, p1);
        }

        [Then(@"User should receive error message for white space first and last name '([^']*)' '([^']*)'")]
        public void ThenUserShouldReceiveErrorMessageForWhiteSpaceFirstAndLastName(string p0, string p1)
        {
            Profile_Panel_Dashboard_Page_Object.Error_Message_First_And_Last_Name_As_White_Space(driver, p0, p1);
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
            Profile_Panel_Dashboard_Page_Object.Click_Edit_Icon_Of_Availability(driver);
        }

        [Then(@"User should successfully click on the edit icon")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIcon()
        {
            Profile_Panel_Dashboard_Page_Object.Clicked_Edit_Icon_Of_Availability(driver);
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
            Profile_Panel_Dashboard_Page_Object.Click_Edit_Icon_Of_Availability(driver);
            Profile_Panel_Dashboard_Page_Object.Click_Cross_Icon_Of_Availability(driver);
        }

        [Then(@"User should successfully click on the cross icon")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIcon()
        {
            Profile_Panel_Dashboard_Page_Object.Clicked_Cross_Icon_Of_Availability(driver);
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
            Profile_Panel_Dashboard_Page_Object.Change_Value_Of_Availability(driver);
        }

        [Then(@"User should successfully change the value of the availability")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheAvailability()
        {
            Profile_Panel_Dashboard_Page_Object.Changed_Value_Of_Availability(driver);
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
            Profile_Panel_Dashboard_Page_Object.Click_Edit_Icon_Of_Hours(driver);
        }

        [Then(@"User should successfully click on the edit icon of the hours")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIconOfTheHours()
        {
            Profile_Panel_Dashboard_Page_Object.Clicked_Edit_Icon_Of_Hours(driver);
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
            Profile_Panel_Dashboard_Page_Object.Click_Edit_Icon_Of_Hours(driver);
            Profile_Panel_Dashboard_Page_Object.Click_Cross_Icon_Of_Hours(driver);
        }

        [Then(@"User should successfully click on the cross icon of hours")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIconOfHours()
        {
            Profile_Panel_Dashboard_Page_Object.Clicked_Cross_Icon_Of_Hours(driver);
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
            Profile_Panel_Dashboard_Page_Object.Change_Value_Of_Hours(driver);
        }

        [Then(@"User should successfully change the value of the hours")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheHours()
        {
            Profile_Panel_Dashboard_Page_Object.Changed_Value_Of_Hours(driver);
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
            Profile_Panel_Dashboard_Page_Object.Click_Edit_Icon_Of_Earn_Target(driver);
        }

        [Then(@"User should successfully click on the edit icon of the earn target")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIconOfTheEarnTarget()
        {
            Profile_Panel_Dashboard_Page_Object.Clicked_Edit_Icon_Of_Earn_Target(driver);
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
            Profile_Panel_Dashboard_Page_Object.Click_Edit_Icon_Of_Earn_Target(driver);
            Profile_Panel_Dashboard_Page_Object.Click_Cross_Icon_Of_Earn_Target(driver);
        }

        [Then(@"User should successfully click on the cross icon of earn target")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIconOfEarnTarget()
        {
            Profile_Panel_Dashboard_Page_Object.Clicked_Cross_Icon_Of_Earn_Target(driver);
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
            Profile_Panel_Dashboard_Page_Object.Change_Value_Of_Earn_Target(driver);
        }

        [Then(@"User should successfully change the value of the earn target")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheEarnTarget()
        {
            Profile_Panel_Dashboard_Page_Object.Changed_Value_Of_Earn_Target(driver);
        }
        [Given(@"Launch the mars portal")]
        public void GivenLaunchTheMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Entering the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenEnteringTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the edit icon of the description")]
        public void WhenUserClickOnTheEditIconOfTheDescription()
        {
            Description_Tab_Page_Object.Click_Edit_Icon_Of_Description(driver);
        }

        [Then(@"User should successfully click on the edit icon of the description")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIconOfTheDescription()
        {
            Description_Tab_Page_Object.Clicked_Edit_Icon_Of_Description(driver);
        }

        [Given(@"Launch Mars portal")]
        public void GivenLaunchMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Enter to the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenEnterToTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1); ;
        }

        [When(@"User can receive error while entering description without first character of digit or letter")]
        public void WhenUserCanReceiveErrorWhileEnteringDescriptionWithoutFirstCharacterOfDigitOrLetter()
        {
            Description_Tab_Page_Object.Click_Edit_Icon_Of_Description(driver);
            Description_Tab_Page_Object.Error_Entering_Description_Without_Digit_Or_Letter(driver);
        }

        [Then(@"User should receive error while entering description without first character of digit or letter")]
        public void ThenUserShouldReceiveErrorWhileEnteringDescriptionWithoutFirstCharacterOfDigitOrLetter()
        {
            Description_Tab_Page_Object.Received_Error_Entering_Description_Without_Digit_Or_Letter(driver);
        }

        [Given(@"Launch to the portal mars")]
        public void GivenLaunchToThePortalMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Sign-In for the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserSign_InForTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User enter description in box")]
        public void WhenUserEnterDescriptionInBox()
        {
            Description_Tab_Page_Object.Click_Edit_Icon_Of_Description(driver);
            Description_Tab_Page_Object.Enter_Description(driver);
        }

        [Then(@"User should successfully enter description in box")]
        public void ThenUserShouldSuccessfullyEnterDescriptionInBox()
        {
            Description_Tab_Page_Object.Entered_Description(driver);
        }
        [Given(@"Launch the portal")]
        public void GivenLaunchThePortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User SignIn for the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserSignInForTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User can click on the Education tab")]
        public void WhenUserCanClickOnTheEducationTab()
        {
            Education_Tab_Page_Object.Click_Education_Tab(driver);
        }

        [Then(@"User should successfully click on the Education tab")]
        public void ThenUserShouldSuccessfullyClickOnTheEducationTab()
        {
            Education_Tab_Page_Object.Clicked_Education_Tab(driver);
        }

        [Given(@"Launch the QA Mars Portal")]
        public void GivenLaunchTheQAMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }
        [When(@"User Sign-In the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserSign_InTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the Add New button from the Education tab")]
        public void WhenUserClickOnTheAddNewButtonFromTheEducationTab()
        {
            Education_Tab_Page_Object.Click_Add_New_Button_Education(driver);
        }

        [Then(@"User should successfully click on the Add New button from the Education tab")]
        public void ThenUserShouldSuccessfullyClickOnTheAddNewButtonFromTheEducationTab()
        {
            Education_Tab_Page_Object.Clicked_Add_New_Button_Education(driver);
        }
        [Given(@"Launch QA Mars Portal")]
        public void GivenLaunchQAMarsPortal()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User not add the educations and other details and click Add button")]
        public void WhenUserNotAddTheEducationsAndOtherDetailsAndClickAddButton()
        {
            Education_Tab_Page_Object.Click_Education_Tab(driver);
            Education_Tab_Page_Object.Click_Add_New_Button_Education(driver);
            Education_Tab_Page_Object.Click_Add_Button_Without_Education_Details(driver);
        }

        [Then(@"User should successfully receive error")]
        public void ThenUserShouldSuccessfullyReceiveError()
        {
            Education_Tab_Page_Object.Clicked_Add_Button_Without_Education_Details(driver);
        }
        [Given(@"Launch the Portal QA Mars")]
        public void GivenLaunchThePortalQAMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click Cancel button")]
        public void WhenUserClickCancelButton()
        {
            Education_Tab_Page_Object.Click_Education_Tab(driver);
            Education_Tab_Page_Object.Click_Add_New_Button_Education(driver);
            Education_Tab_Page_Object.Click_Cancel_Button_Education(driver);
        }

        [Then(@"User should successfully click Cancel button")]
        public void ThenUserShouldSuccessfullyClickCancelButton()
        {
            Education_Tab_Page_Object.Clicked_Cancel_Button_Education(driver);
        }
        [Given(@"Launch the QA Mars")]
        public void GivenLaunchTheQAMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login into Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User enter education details and click add button '([^']*)' '([^']*)'")]
        public void WhenUserEnterEducationDetailsAndClickAddButton(string college_university_name, string degree_name)
        {
            Education_Tab_Page_Object.Click_Education_Tab(driver);
            Education_Tab_Page_Object.Click_Add_New_Button_Education(driver);
            Education_Tab_Page_Object.Enter_Education_Details(driver, college_university_name, degree_name);
        }

        [Then(@"User should successfully enter education details")]
        public void ThenUserShouldSuccessfullyEnterEducationDetails()
        {
            Education_Tab_Page_Object.Entered_Education_Details(driver);
        }
        [Given(@"Launch QA Mars")]
        public void GivenLaunchQAMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login into Mars Portal '([^']*)' '([^']*)'")]
        public void WhenLoginIntoMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User edited education details and click add button '([^']*)' '([^']*)'")]
        public void WhenUserEditedEducationDetailsAndClickAddButton(string college_university_name, string degree_name)
        {
            Education_Tab_Page_Object.Click_Education_Tab(driver);
            Education_Tab_Page_Object.Click_Add_New_Button_Education(driver);
            Education_Tab_Page_Object.Edited_Education_Details(driver, college_university_name, degree_name);
        }

        [Then(@"User should successfully edited education details")]
        public void ThenUserShouldSuccessfullyEditedEducationDetails()
        {
            Education_Tab_Page_Object.Edited_Education_Details(driver);
        }
        [Given(@"Launch QA portal Mars")]
        public void GivenLaunchQAPortalMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login Mars Portal '([^']*)' '([^']*)'")]
        public void WhenLoginMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User delete education details by clicking on the cross icon")]
        public void WhenUserDeleteEducationDetailsByClickingOnTheCrossIcon()
        {
            Education_Tab_Page_Object.Click_Education_Tab(driver);
            Education_Tab_Page_Object.Click_Cross_Icon_Education(driver);
        }

        [Then(@"User should successfully delete education details")]
        public void ThenUserShouldSuccessfullyDeleteEducationDetails()
        {
            Education_Tab_Page_Object.Clicked_Cross_Icon_Education(driver);
        }
        [Given(@"Launch Portal qa mars")]
        public void GivenLaunchPortalQaMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User SignIn the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserSignInTheMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User can click on the Certification  tab")]
        public void WhenUserCanClickOnTheCertificationTab()
        {
            Certification_Tab_Page_Object.Click_Certification_Tab(driver);
        }

        [Then(@"User should successfully click on the Certification  tab")]
        public void ThenUserShouldSuccessfullyClickOnTheCertificationTab()
        {
            Certification_Tab_Page_Object.Clicked_Certification_Tab(driver);
        }
        [Given(@"Launch the QA Mars website")]
        public void GivenLaunchTheQAMarsWebsite()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Sign-In the Mars website '([^']*)' '([^']*)'")]
        public void WhenUserSign_InTheMarsWebsite(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click on the Add New button from the Certification tab")]
        public void WhenUserClickOnTheAddNewButtonFromTheCertificationTab()
        {
            Certification_Tab_Page_Object.Click_Certification_Tab(driver);
            Certification_Tab_Page_Object.Click_Add_New_Button_Certification(driver);
        }

        [Then(@"User should successfully click on the Add New button from the Certification tab")]
        public void ThenUserShouldSuccessfullyClickOnTheAddNewButtonFromTheCertificationTab()
        {
            Certification_Tab_Page_Object.Clicked_Add_New_Button_Certification(driver);
        }
        [Given(@"Launch QA Mars URL")]
        public void GivenLaunchQAMarsURL()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"User Login into the Mars Portal website '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoTheMarsPortalWebsite(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User not add the certification and other details and click Add button")]
        public void WhenUserNotAddTheCertificationAndOtherDetailsAndClickAddButton()
        {
            Certification_Tab_Page_Object.Click_Certification_Tab(driver);
            Certification_Tab_Page_Object.Click_Add_New_Button_Certification(driver);
            Certification_Tab_Page_Object.Click_Add_Button_Without_Certification_Details(driver);
        }

        [Then(@"User should successfully receive error for it")]
        public void ThenUserShouldSuccessfullyReceiveErrorForIt()
        {
            Certification_Tab_Page_Object.Clicked_Add_Button_Without_Certification_Details(driver);
        }
        [Given(@"User Launch the Portal QA Mars")]
        public void GivenUserLaunchThePortalQAMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Registered User Login to Mars Portal '([^']*)' '([^']*)'")]
        public void WhenRegisteredUserLoginToMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User click Cancel button in Certification tab")]
        public void WhenUserClickCancelButtonInCertificationTab()
        {
            Certification_Tab_Page_Object.Click_Certification_Tab(driver);
            Certification_Tab_Page_Object.Click_Add_New_Button_Certification(driver);
            Certification_Tab_Page_Object.Click_Cancel_Button_Certification(driver);

        }

        [Then(@"User should successfully click Cancel button in Certification tab")]
        public void ThenUserShouldSuccessfullyClickCancelButtonInCertificationTab()
        {
            Certification_Tab_Page_Object.Clicked_Cancel_Button_Certification(driver);
        }
        [Given(@"Launch Mars")]
        public void GivenLaunchMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Existing User Login into Mars Portal '([^']*)' '([^']*)'")]
        public void WhenExistingUserLoginIntoMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User enter certification details and click add button '([^']*)' '([^']*)'")]
        public void WhenUserEnterCertificationDetailsAndClickAddButton(string p0, string p1)
        {
            Certification_Tab_Page_Object.Click_Certification_Tab(driver);
            Certification_Tab_Page_Object.Click_Add_New_Button_Certification(driver);
            Certification_Tab_Page_Object.Enter_Certification_Details(driver, p0, p1);
        }

        [Then(@"User should successfully enter certification details")]
        public void ThenUserShouldSuccessfullyEnterCertificationDetails()
        {
            Certification_Tab_Page_Object.Entered_Certification_Details(driver);
        }
        [Given(@"Launch QA Mars website")]
        public void GivenLaunchQAMarsWebsite()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login into Mars Portal website '([^']*)' '([^']*)'")]
        public void WhenLoginIntoMarsPortalWebsite(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User edited certification details and click add button '([^']*)' '([^']*)'")]
        public void WhenUserEditedCertificationDetailsAndClickAddButton(string p0, string p1)
        {
            Certification_Tab_Page_Object.Click_Certification_Tab(driver);
            Certification_Tab_Page_Object.Edit_Certification_Details(driver, p0, p1);
        }

        [Then(@"User should successfully edited certification details")]
        public void ThenUserShouldSuccessfullyEditedCertificationDetails()
        {
            Certification_Tab_Page_Object.Edited_Certification_Details(driver);
        }
        [Given(@"Launch website Mars")]
        public void GivenLaunchWebsiteMars()
        {
            Login_Or_Registration_Page_Object.Navigate_To_URL(driver);
        }

        [When(@"Login QA Mars Portal '([^']*)' '([^']*)'")]
        public void WhenLoginQAMarsPortal(string p0, string p1)
        {
            Login_Or_Registration_Page_Object.Click_Sign_In_Button(driver);
            Login_Or_Registration_Page_Object.Enter_Login_Details(driver, p0, p1);
        }

        [When(@"User delete certification details by clicking on the cross icon")]
        public void WhenUserDeleteCertificationDetailsByClickingOnTheCrossIcon()
        {
            Certification_Tab_Page_Object.Click_Certification_Tab(driver);
            Certification_Tab_Page_Object.Click_Cross_Icon_Certification(driver);
        }

        [Then(@"User should successfully delete certification details")]
        public void ThenUserShouldSuccessfullyDeleteCertificationDetails()
        {
            Certification_Tab_Page_Object.Clicked_Cross_Icon_Certification(driver);
        }



    }
}
