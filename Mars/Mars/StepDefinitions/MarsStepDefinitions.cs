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
        LoginOrRegistrationPage LoginOrRegistrationPageObject = new LoginOrRegistrationPage();
        ProfilePanelDashboardPage ProfilePanelDashboardPageObject = new ProfilePanelDashboardPage();
        DescriptionTabPage DescriptionTabPageObject = new DescriptionTabPage();
        LanguageTabPage LanguageTabObject = new LanguageTabPage();
        SkillTabPage SkillTabPageObject = new SkillTabPage();
        EducationTabPage EducationTabPageObject = new EducationTabPage();
        CertificationTabPage CertificationTabPageObject = new CertificationTabPage();

        [Given(@"Log into Mars portal")]
        public void GivenLogIntoMarsPortal()
        {

            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"New User can navigate and click on the Join button")]
        public void WhenNewUserCanNavigateAndClickOnTheJoinButton()
        {
            LoginOrRegistrationPageObject.ClickJoinButton(driver);
        }

        [Then(@"The registration window should open")]
        public void ThenTheRegistrationWindowShouldOpen()
        {
            LoginOrRegistrationPageObject.RegistrationWindow(driver);
        }

        [Given(@"Navigate to into Mars portal")]
        public void GivenNavigateToIntoMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Click on the Join button")]
        public void WhenClickOnTheJoinButton()
        {
            LoginOrRegistrationPageObject.ClickJoinButton(driver);
        }

        [When(@"Enter the registration details '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenEnterTheRegistrationDetails(string FirstName, string LastName, string emailid, string password, string confirmpassword)
        {
            LoginOrRegistrationPageObject.EnterRegistrationDetails(driver,FirstName,LastName,emailid,password,confirmpassword);
        }

        [When(@"Chcked the Checkbox and click submit button")]
        public void WhenChckedTheCheckboxOfTermsAndConditions()
        {
            LoginOrRegistrationPageObject.CheckedCheckboxAndSubmitButton(driver);
        }

        [Then(@"User details should registered")]
        public void ThenUserDetailsShouldRegistered()
        {
            LoginOrRegistrationPageObject.UsersDetailsRegistered(driver);
        }

        [Given(@"Open mars portal")]
        public void GivenOpenMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User can navigate and click on the Sign button")]
        public void WhenUserCanNavigateAndClickOnTheSignButton()
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
        }

        [Then(@"Login window should open")]
        public void ThenLoginWindowShouldOpen()
        {
            LoginOrRegistrationPageObject.LoginWindow(driver);
        }
        [Given(@"Navigate to Mars portal")]
        public void GivenNavigateToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Click on Sign In button")]
        public void WhenClickOnSignInButton()
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
        }

        [When(@"Enter Email Address and Password '([^']*)' '([^']*)'")]
        public void WhenEnterEmailAddressAndPassword(string emailid, string password)
        {
            LoginOrRegistrationPageObject.EnterLoginDetails(driver,  emailid,  password);
        }

        [Then(@"User should navigate to Dashboard")]
        public void ThenUserShouldNavigateToDashboard()
        {
            LoginOrRegistrationPageObject.Dashboard(driver);
        }

        [Given(@"Open portal")]
        public void GivenOpenPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User click on Sign In button\.")]
        public void WhenUserCanClickOnSignInButton()
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
        }

        [When(@"User click on Join button\.")]
        public void WhenUserCanClickOnJoinButton()
        {
            LoginOrRegistrationPageObject.ClickJoinButton(driver);
        }

        [When(@"User enter registration details '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserEnterRegistrationDetails(string FirstName, string LastName, string emailid, string password, string confirmpassword)
        {
            LoginOrRegistrationPageObject.EnterRegistrationDetails(driver, FirstName, LastName, emailid, password, confirmpassword);
        }

        [Then(@"User's deatils should registered")]
        public void ThenUsersDeatilsShouldRegistered()
        {
           LoginOrRegistrationPageObject.CheckedCheckboxAndSubmitButton(driver);
           LoginOrRegistrationPageObject.UsersDetailsRegistered(driver);
        }
      
        [Given(@"Nav\. to Mars portal")]
        public void GivenNavToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User click on Sign In button")]
        public void WhenUserClickOnSignInButton()
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
        }

        [When(@"User click on Forget your password link text")]
        public void WhenUserClickOnForgetYourPasswordLinkText()
        {
           LoginOrRegistrationPageObject.ForgetYourPasswordLinkText(driver);
        }

        [When(@"Enter registered email id '([^']*)'")]
        public void WhenEnterRegisteredEmailIdAndClickOnSendVerificationEmailButton(string emailid)
        {
            LoginOrRegistrationPageObject.EnterEmailId(driver, emailid);
        }

        [Then(@"Password reset link should sent to user")]
        public void ThenPasswordResetLinkShouldSentToUser()
        {
           LoginOrRegistrationPageObject.PasswordResetLink(driver);
        }
        [Given(@"Open MARS posrtal")]
        public void GivenOpenMARSPosrtal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Clcik on SIGN IN button")]
        public void WhenClcikOnSignInButton()
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
        }

        [When(@"Enter wrong credentials '([^']*)' '([^']*)'")]
        public void WhenEnterWrongCredentials(string wrongemailid, string wrongpassword)
        {
            LoginOrRegistrationPageObject.EnterWrongLoginDetails(driver, wrongemailid, wrongpassword);
        }

        [Then(@"User should not login '([^']*)'")]
        public void ThenUserShouldNotLogin(string WrongEmailId1)
        {
            LoginOrRegistrationPageObject.UserNavToSendVerificationPopup(driver, WrongEmailId1);
        }

        [Given(@"Opening Mars portal")]
        public void GivenOpeningMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User login into portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoPortal(string emailid, string password)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver,  emailid,  password);
        }

        [When(@"User click on AddNew button and enter details '([^']*)'")]
        public void WhenUserClickOnAddNewButtonAndEnterDetails(string language)
        {
            LanguageTabObject.AddLanguage(driver, language);
        }

        [Then(@"User's detail should registered '([^']*)'")]
        public void ThenUsersDetailShouldRegistered(string lang)
        {
            LanguageTabObject.LanguageAdded(driver, lang);
        }
        [Given(@"Opening to Mars portal")]
        public void GivenOpeningToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login into Portal '([^']*)' '([^']*)'")]
        public void WhenLoginIntoPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
;        }

        [When(@"User click on AddNew button withoust entering details")]
        public void WhenUserClickOnAddNewButtonWithoustEnteringDetails()
        {
            LanguageTabObject.AddLanguageWithoutData(driver);
        }

        [Then(@"User received error message")]
        public void ThenUserReceivedErrorMessage()
        {
            LanguageTabObject.ErrorMessageForLanguageAdd(driver);
        }

        [Given(@"open portal mars")]
        public void GivenOpenPortalMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login to Portal '([^']*)' '([^']*)'")]
        public void WhenLoginToPortal(string email, string password)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, email, password);
        }

        [When(@"Edit the language and level '([^']*)'")]
        public void WhenEditTheLanguageAndLevel(string newlang)
        {
            LanguageTabObject.EditLanguageAndLevel(driver, newlang);
        }

        [Then(@"User should successfully edited language and level")]
        public void ThenUserShouldSuccessfullyEditedLanguageAndLevel()
        {
            LanguageTabObject.EditedLanguageAndLevel(driver);
        }
        [Given(@"User open mars portal")]
        public void GivenUserOpenMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Login to portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginToPortal(string emailid, string password)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, emailid, password);
        }

        [When(@"User click on delete button to delete language entry")]
        public void WhenUserClickOnDeleteButtonToDeleteLanguageEntry()
        {
            LanguageTabObject.DeleteLanguageAndLevel(driver);
        }

        [Then(@"User should successfully deleted the language")]
        public void ThenUserShouldSuccessfullyDeletedTheLanguage()
        {
            LanguageTabObject.DeletedLanguageAndLevel(driver);
        }
        [Given(@"User Opening Mars portal")]
        public void GivenUserOpeningMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Login to mars portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginToMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User Click on AddNew button and enter Skill '([^']*)'")]
        public void WhenUserClickOnAddNewButtonAndEnterSkill(string p0)
        {
            SkillTabPageObject.AddSkill(driver, p0);
        }

        [Then(@"User details should registered '([^']*)'")]
        public void ThenUserDetailsShouldRegistered(string p0)
        {
            SkillTabPageObject.SkillAdded(driver, p0);
        }
        [Given(@"Opening to portal Mars")]
        public void GivenOpeningToPortalMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login to Mars Portal '([^']*)' '([^']*)'")]
        public void WhenLoginToMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on AddNew button without entering Skill details")]
        public void WhenUserClickOnAddNewButtonWithoutEnteringSkillDetails()
        {
            SkillTabPageObject.AddSkillwithoutData(driver);
        }

        [Then(@"User received error message for it")]
        public void ThenUserReceivedErrorMessageForIt()
        {
            SkillTabPageObject.ErrorMessageForAddSkillwithoutData(driver);
        }
        [Given(@"open to portal mars")]
        public void GivenOpenToPortalMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login to Portal Mars '([^']*)' '([^']*)'")]
        public void WhenLoginToPortalMars(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"Edit the Skill and level '([^']*)'")]
        public void WhenEditTheSkillAndLevel(string p0)
        {
            SkillTabPageObject.EditSkillAndLevel(driver, p0);
        }

        [Then(@"User should successfully edited Skill and level")]
        public void ThenUserShouldSuccessfullyEditedSkillAndLevel()
        {
            SkillTabPageObject.EditedSkillAndLevel(driver);
        }
        [Given(@"User open to mars portal")]
        public void GivenUserOpenToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Login to portal mars '([^']*)' '([^']*)'")]
        public void WhenUserLoginToPortalMars(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on delete button to delete Skill entry")]
        public void WhenUserClickOnDeleteButtonToDeleteSkillEntry()
        {
            SkillTabPageObject.DeleteSkillAndLevel(driver);
        }

        [Then(@"User should successfully deleted the Skill")]
        public void ThenUserShouldSuccessfullyDeletedTheSkill()
        {
            SkillTabPageObject.DeletedSkillAndLevel(driver);
        }
        [Given(@"Launch portal")]
        public void GivenLaunchPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User login to portal with details '([^']*)' '([^']*)'")]
        public void WhenUserLoginToPortalWithDetails(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User can click on the edit Dropdown")]
        public void WhenUserCanClickOnTheEditDropdown()
        {
            ProfilePanelDashboardPageObject.ClickEditDropdown(driver);
        }

        [Then(@"User should successfully click on edit Dropdown")]
        public void ThenUserShouldSuccessfullyClickOnEditDropdown()
        {
            ProfilePanelDashboardPageObject.ClickedEditDropdown(driver);
        }
        [Given(@"User can Launch portal")]
        public void GivenUserCanLaunchPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User can login to portal with details '([^']*)' '([^']*)'")]
        public void WhenUserCanLoginToPortalWithDetails(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User can edit the First name and Last name '([^']*)' '([^']*)'")]
        public void WhenUserCanEditTheFirstNameAndLastNameDEF(string p0, string p1)
        {
            ProfilePanelDashboardPageObject.EditFirstAndLastName(driver, p0, p1);
        }

        [Then(@"User should successfully edit the First and Last name '([^']*)' '([^']*)'")]
        public void ThenUserShouldSuccessfullyEditTheFirstAndLastName(string p0, string p1)
        {
            ProfilePanelDashboardPageObject.EditedFirstAndLastName(driver, p0, p1);
        }
        [Given(@"User can Launch the Mars portal")]
        public void GivenUserCanLaunchTheMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User can login into the Mars portal with details '([^']*)' '([^']*)'")]
        public void WhenUserCanLoginIntoTheMarsPortalWithDetails(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User enter the First name and Last name as blank")]
        public void WhenUserEnterTheFirstNameAndLastNameAsBlank()
        {
            ProfilePanelDashboardPageObject.FirstAndLastNameAsBlank(driver);
        }

        [Then(@"User should receive error message for blank First and Last name")]
        public void ThenUserShouldReceiveErrorMessageForBlankFirstAndLastName()
        {
            ProfilePanelDashboardPageObject.ErrorMessageFirstAndLastNameAsBlank(driver);
        }
        [Given(@"User can Launch Mars portal")]
        public void GivenUserCanLaunchMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User can login to Mars portal with details '([^']*)' '([^']*)'")]
        public void WhenUserCanLoginToMarsPortalWithDetails(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User can enter the First name and Last name as white space '([^']*)' '([^']*)'")]
        public void WhenUserCanEnterTheFirstNameAndLastNameAsWhiteSpace(string p0, string p1)
        {
            ProfilePanelDashboardPageObject.FirstAndLastNameAsWhiteSpace(driver, p0, p1);
        }

        [Then(@"User should receive error message for white space First and Last name '([^']*)' '([^']*)'")]
        public void ThenUserShouldReceiveErrorMessageForWhiteSpaceFirstAndLastName(string p0, string p1)
        {
            ProfilePanelDashboardPageObject.ErrorMessageFirstAndLastNameAsWhiteSpace(driver, p0, p1);
        }
        [Given(@"Users nav to mars portal")]
        public void GivenUsersNavToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User login into the portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoThePortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the edit icon of the availability")]
        public void WhenUserClickOnTheEditIconOfTheAvailability()
        {
            ProfilePanelDashboardPageObject.ClickEditIconOfAvailability(driver);
        }

        [Then(@"User should successfully click on the edit icon")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIcon()
        {
            ProfilePanelDashboardPageObject.ClickedEditIconOfAvailability(driver);
        }
        [Given(@"User nav\. to mars portal")]
        public void GivenUserNavToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User login into the mars portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the cross icon of the availability")]
        public void WhenUserClickOnTheCrossIconOfTheAvailability()
        {
            ProfilePanelDashboardPageObject.ClickEditIconOfAvailability(driver);
            ProfilePanelDashboardPageObject.ClickCrossIconOfAvailability(driver);
        }

        [Then(@"User should successfully click on the cross icon")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIcon()
        {
            ProfilePanelDashboardPageObject.ClickedCrossIconOfAvailability(driver);
        }
        [Given(@"User launch to mars portal")]
        public void GivenUserLaunchToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"The Mars Portal: User Sign-In '([^']*)' '([^']*)'")]
        public void WhenTheMarsPortalUserSignIn(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the edit icon and change the value of the availability")]
        public void WhenUserClickOnTheEditIconAndChangeTheValueOfTheAvailability()
        {
            ProfilePanelDashboardPageObject.ChangeValueOfAvailability(driver);
        }

        [Then(@"User should successfully change the value of the availability")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheAvailability()
        {
            ProfilePanelDashboardPageObject.ChangedValueOfAvailability(driver);
        }

        [Given(@"User navi\. to mars portal")]
        public void GivenUserNaviToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Logging into the Mars portal as a user '([^']*)' '([^']*)'")]
        public void WhenLoggingIntoTheMarsPortalAsAUser(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the edit icon of the hours")]
        public void WhenUserClickOnTheEditIconOfTheHours()
        {
            ProfilePanelDashboardPageObject.ClickEditIconOfHours(driver);
        }

        [Then(@"User should successfully click on the edit icon of the hours")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIconOfTheHours()
        {
            ProfilePanelDashboardPageObject.ClickedEditIconOfHours(driver);
        }
        [Given(@"User navig\. to mars portal")]
        public void GivenUserNavigToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);

        }

        [When(@"User Accessing the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserAccessingTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the cross icon of the hours")]
        public void WhenUserClickOnTheCrossIconOfTheHours()
        {
            ProfilePanelDashboardPageObject.ClickEditIconOfHours(driver);
            ProfilePanelDashboardPageObject.ClickCrossIconOfHours(driver);
        }

        [Then(@"User should successfully click on the cross icon of hours")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIconOfHours()
        {
            ProfilePanelDashboardPageObject.ClickedCrossIconOfHours(driver);
        }
        [Given(@"User Launch to the mars portal")]
        public void GivenUserLaunchToTheMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login to the Martian Portal as a User '([^']*)' '([^']*)'")]
        public void WhenLoginToTheMartianPortalAsAUser(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the edit icon and change the value of the hours")]
        public void WhenUserClickOnTheEditIconAndChangeTheValueOfTheHours()
        {
            ProfilePanelDashboardPageObject.ChangeValueOfHours(driver);
        }

        [Then(@"User should successfully change the value of the hours")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheHours()
        {
            ProfilePanelDashboardPageObject.ChangedValueOfHours(driver);
        }
        [Given(@"User naviga\. to mars portal")]
        public void GivenUserNavigaToMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Logging Into Mars portal as a user '([^']*)' '([^']*)'")]
        public void WhenLoggingIntoMarsPortalAsAUser(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the edit icon of the earn target")]
        public void WhenUserClickOnTheEditIconOfTheEarnTarget()
        {
            ProfilePanelDashboardPageObject.ClickEditIconOfEarnTarget(driver);
        }

        [Then(@"User should successfully click on the edit icon of the earn target")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIconOfTheEarnTarget()
        {
            ProfilePanelDashboardPageObject.ClickedEditIconOfEarnTarget(driver);
        }
        [Given(@"User launch the mars portal")]
        public void GivenUserLaunchTheMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Mars Portal User Access '([^']*)' '([^']*)'")]
        public void WhenMarsPortalUserAccess(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the cross icon of the earn target")]
        public void WhenUserClickOnTheCrossIconOfTheEarnTarget()
        {
            ProfilePanelDashboardPageObject.ClickEditIconOfEarnTarget(driver);
            ProfilePanelDashboardPageObject.ClickCrossIconOfEarnTarget(driver);
        }

        [Then(@"User should successfully click on the cross icon of earn target")]
        public void ThenUserShouldSuccessfullyClickOnTheCrossIconOfEarnTarget()
        {
            ProfilePanelDashboardPageObject.ClickedCrossIconOfEarnTarget(driver);
        }
        [Given(@"User to Launch the mars portal")]
        public void GivenUserToLaunchTheMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login to Martian Portal as a User '([^']*)' '([^']*)'")]
        public void WhenLoginToMartianPortalAsAUser(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the edit icon and change the value of the earn target")]
        public void WhenUserClickOnTheEditIconAndChangeTheValueOfTheEarnTarget()
        {
            ProfilePanelDashboardPageObject.ChangeValueOfEarnTarget(driver);
        }

        [Then(@"User should successfully change the value of the earn target")]
        public void ThenUserShouldSuccessfullyChangeTheValueOfTheEarnTarget()
        {
            ProfilePanelDashboardPageObject.ChangedValueOfEarnTarget(driver);
        }
        [Given(@"Launch the mars portal")]
        public void GivenLaunchTheMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Entering the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenEnteringTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the edit icon of the description")]
        public void WhenUserClickOnTheEditIconOfTheDescription()
        {
            DescriptionTabPageObject.ClickEditIconOfDescription(driver);
        }

        [Then(@"User should successfully click on the edit icon of the description")]
        public void ThenUserShouldSuccessfullyClickOnTheEditIconOfTheDescription()
        {
            DescriptionTabPageObject.ClickedEditIconOfDescription(driver);
        }

        [Given(@"Launch Mars portal")]
        public void GivenLaunchMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Enter to the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenEnterToTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1); ;
        }

        [When(@"User can receive error while entering description without First character of digit or letter")]
        public void WhenUserCanReceiveErrorWhileEnteringDescriptionWithoutFirstCharacterOfDigitOrLetter()
        {
            DescriptionTabPageObject.ClickEditIconOfDescription(driver);
            DescriptionTabPageObject.ErrorEnteringDescriptionWithoutDigitOrLetter(driver);
        }

        [Then(@"User should receive error while entering description without First character of digit or letter")]
        public void ThenUserShouldReceiveErrorWhileEnteringDescriptionWithoutFirstCharacterOfDigitOrLetter()
        {
            DescriptionTabPageObject.ReceivedErrorEnteringDescriptionWithoutDigitOrLetter(driver);
        }

        [Given(@"Launch to the portal mars")]
        public void GivenLaunchToThePortalMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Sign-In for the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserSignInForTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User enter description in box")]
        public void WhenUserEnterDescriptionInBox()
        {
            DescriptionTabPageObject.ClickEditIconOfDescription(driver);
            DescriptionTabPageObject.EnterDescription(driver);
        }

        [Then(@"User should successfully enter description in box")]
        public void ThenUserShouldSuccessfullyEnterDescriptionInBox()
        {
            DescriptionTabPageObject.EnteredDescription(driver);
        }
        [Given(@"Launch the portal")]
        public void GivenLaunchThePortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Users SignIn for the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUsersSignInForTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User can click on the Education tab")]
        public void WhenUserCanClickOnTheEducationTab()
        {
            EducationTabPageObject.ClickEducationTab(driver);
        }

        [Then(@"User should successfully click on the Education tab")]
        public void ThenUserShouldSuccessfullyClickOnTheEducationTab()
        {
            EducationTabPageObject.ClickedEducationTab(driver);
        }

        [Given(@"Launch the QA Mars Portal")]
        public void GivenLaunchTheQAMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }
        [When(@"User Sign-In the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserSignInTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the Add New button from the Education tab")]
        public void WhenUserClickOnTheAddNewButtonFromTheEducationTab()
        {
            EducationTabPageObject.ClickAddNewButtonEducation(driver);
        }

        [Then(@"User should successfully click on the Add New button from the Education tab")]
        public void ThenUserShouldSuccessfullyClickOnTheAddNewButtonFromTheEducationTab()
        {
            EducationTabPageObject.ClickedAddNewButtonEducation(driver);
        }
        [Given(@"Launch QA Mars Portal")]
        public void GivenLaunchQAMarsPortal()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Login the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User not Add the educations and other details and click Add button")]
        public void WhenUserNotAddTheEducationsAndOtherDetailsAndClickAddButton()
        {
            EducationTabPageObject.ClickEducationTab(driver);
            EducationTabPageObject.ClickAddNewButtonEducation(driver);
            EducationTabPageObject.ClickAddButtonWithoutEducationDetails(driver);
        }

        [Then(@"User should successfully receive error")]
        public void ThenUserShouldSuccessfullyReceiveError()
        {
            EducationTabPageObject.ClickedAddButtonWithoutEducationDetails(driver);
        }
        [Given(@"Launch the Portal QA Mars")]
        public void GivenLaunchThePortalQAMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Login Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click Cancel button")]
        public void WhenUserClickCancelButton()
        {
            EducationTabPageObject.ClickEducationTab(driver);
            EducationTabPageObject.ClickAddNewButtonEducation(driver);
            EducationTabPageObject.ClickCancelButtonEducation(driver);
        }

        [Then(@"User should successfully click Cancel button")]
        public void ThenUserShouldSuccessfullyClickCancelButton()
        {
            EducationTabPageObject.ClickedCancelButtonEducation(driver);
        }
        [Given(@"Launch the QA Mars")]
        public void GivenLaunchTheQAMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Login into Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User enter education details and click Add button '([^']*)' '([^']*)'")]
        public void WhenUserEnterEducationDetailsAndClickAddButton(string collegeuniversityname, string degreename)
        {
            EducationTabPageObject.ClickEducationTab(driver);
            EducationTabPageObject.ClickAddNewButtonEducation(driver);
            EducationTabPageObject.EnterEducationDetails(driver, collegeuniversityname, degreename);
        }

        [Then(@"User should successfully enter education details")]
        public void ThenUserShouldSuccessfullyEnterEducationDetails()
        {
            EducationTabPageObject.EnteredEducationDetails(driver);
        }
        [Given(@"Launch QA Mars")]
        public void GivenLaunchQAMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login into Mars Portal '([^']*)' '([^']*)'")]
        public void WhenLoginIntoMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }


        [When(@"User edit education details and click Add button '([^']*)' '([^']*)'")]
        public void WhenUserEditEducationDetailsAndClickAddButton(string collegeuniversityname, string degreename)
        {
            EducationTabPageObject.ClickEducationTab(driver);
            EducationTabPageObject.EditEducationDetails(driver, collegeuniversityname, degreename);
        }

        [Then(@"User should successfully edited education details")]
        public void ThenUserShouldSuccessfullyEditedEducationDetails()
        {
            EducationTabPageObject.EditedEducationDetails(driver);
        }
        [Given(@"Launch QA portal Mars")]
        public void GivenLaunchQAPortalMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login Mars Portal '([^']*)' '([^']*)'")]
        public void WhenLoginMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User delete education details by clicking on the cross icon")]
        public void WhenUserDeleteEducationDetailsByClickingOnTheCrossIcon()
        {
            EducationTabPageObject.ClickEducationTab(driver);
            EducationTabPageObject.ClickCrossIconEducation(driver);
        }

        [Then(@"User should successfully delete education details")]
        public void ThenUserShouldSuccessfullyDeleteEducationDetails()
        {
            EducationTabPageObject.ClickedCrossIconEducation(driver);
        }
        [Given(@"Launch Portal qa mars")]
        public void GivenLaunchPortalQaMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Users SignIn the Mars Portal '([^']*)' '([^']*)'")]
        public void WhenUsersSignInTheMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User can click on the Certification  tab")]
        public void WhenUserCanClickOnTheCertificationTab()
        {
            CertificationTabPageObject.ClickCertificationTab(driver);
        }

        [Then(@"User should successfully click on the Certification  tab")]
        public void ThenUserShouldSuccessfullyClickOnTheCertificationTab()
        {
            CertificationTabPageObject.ClickedCertificationTab(driver);
        }
        [Given(@"Launch the QA Mars website")]
        public void GivenLaunchTheQAMarsWebsite()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Sign-In the Mars website '([^']*)' '([^']*)'")]
        public void WhenUserSignInTheMarsWebsite(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click on the Add New button from the Certification tab")]
        public void WhenUserClickOnTheAddNewButtonFromTheCertificationTab()
        {
            CertificationTabPageObject.ClickCertificationTab(driver);
            CertificationTabPageObject.ClickAddNewButtonCertification(driver);
        }

        [Then(@"User should successfully click on the Add New button from the Certification tab")]
        public void ThenUserShouldSuccessfullyClickOnTheAddNewButtonFromTheCertificationTab()
        {
            CertificationTabPageObject.ClickedAddNewButtonCertification(driver);
        }
        [Given(@"Launch QA Mars URL")]
        public void GivenLaunchQAMarsURL()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"User Login into the Mars Portal website '([^']*)' '([^']*)'")]
        public void WhenUserLoginIntoTheMarsPortalWebsite(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User not Add the certification and other details and click Add button")]
        public void WhenUserNotAddTheCertificationAndOtherDetailsAndClickAddButton()
        {
            CertificationTabPageObject.ClickCertificationTab(driver);
            CertificationTabPageObject.ClickAddNewButtonCertification(driver);
            CertificationTabPageObject.ClickAddButtonWithoutCertificationDetails(driver);
        }

        [Then(@"User should successfully receive error for it")]
        public void ThenUserShouldSuccessfullyReceiveErrorForIt()
        {
            CertificationTabPageObject.ClickedAddButtonWithoutCertificationDetails(driver);
        }
        [Given(@"User Launch the Portal QA Mars")]
        public void GivenUserLaunchThePortalQAMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Registered User Login to Mars Portal '([^']*)' '([^']*)'")]
        public void WhenRegisteredUserLoginToMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User click Cancel button in Certification tab")]
        public void WhenUserClickCancelButtonInCertificationTab()
        {
            CertificationTabPageObject.ClickCertificationTab(driver);
            CertificationTabPageObject.ClickAddNewButtonCertification(driver);
            CertificationTabPageObject.ClickCancelButtonCertification(driver);

        }

        [Then(@"User should successfully click Cancel button in Certification tab")]
        public void ThenUserShouldSuccessfullyClickCancelButtonInCertificationTab()
        {
            CertificationTabPageObject.Clickedcancelbuttoncertification(driver);
        }
        [Given(@"Launch Mars")]
        public void GivenLaunchMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Existing User Login into Mars Portal '([^']*)' '([^']*)'")]
        public void WhenExistingUserLoginIntoMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User enter certification details and click Add button '([^']*)' '([^']*)'")]
        public void WhenUserEnterCertificationDetailsAndClickAddButton(string p0, string p1)
        {
            CertificationTabPageObject.ClickCertificationTab(driver);
            CertificationTabPageObject.ClickAddNewButtonCertification(driver);
            CertificationTabPageObject.EnterCertificationDetails(driver, p0, p1);
        }

        [Then(@"User should successfully enter certification details")]
        public void ThenUserShouldSuccessfullyEnterCertificationDetails()
        {
            CertificationTabPageObject.EnteredCertificationDetails(driver);
        }
        [Given(@"Launch QA Mars website")]
        public void GivenLaunchQAMarsWebsite()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login into Mars Portal website '([^']*)' '([^']*)'")]
        public void WhenLoginIntoMarsPortalWebsite(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User edit certification details and click Add button '([^']*)' '([^']*)'")]
        public void WhenUserEditCertificationDetailsAndClickAddButton(string p0, string p1)
        {
            CertificationTabPageObject.ClickCertificationTab(driver);
            CertificationTabPageObject.EditCertificationDetails(driver, p0, p1);
        }

        [Then(@"User should successfully edited certification details")]
        public void ThenUserShouldSuccessfullyEditedCertificationDetails()
        {
            CertificationTabPageObject.EditedCertificationDetails(driver);
        }
        [Given(@"Launch website Mars")]
        public void GivenLaunchWebsiteMars()
        {
            LoginOrRegistrationPageObject.NavigateToURL(driver);
        }

        [When(@"Login QA Mars Portal '([^']*)' '([^']*)'")]
        public void WhenLoginQAMarsPortal(string p0, string p1)
        {
            LoginOrRegistrationPageObject.ClickSignInButton(driver);
            LoginOrRegistrationPageObject.EnterLoginDetails(driver, p0, p1);
        }

        [When(@"User delete certification details by clicking on the cross icon")]
        public void WhenUserDeleteCertificationDetailsByClickingOnTheCrossIcon()
        {
            CertificationTabPageObject.ClickCertificationTab(driver);
            CertificationTabPageObject.ClickCrossIconCertification(driver);
        }

        [Then(@"User should successfully delete certification details")]
        public void ThenUserShouldSuccessfullyDeleteCertificationDetails()
        {
            CertificationTabPageObject.ClickedCrossIconCertification(driver);
        }



    }
}
