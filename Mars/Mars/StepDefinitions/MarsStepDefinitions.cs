using Mars.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class MarsStepDefinitions
    {
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
            driver.Quit();
        }
    }
}
