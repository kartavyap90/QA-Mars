using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace Mars.Pages
{
    public class LoginOrRegistrationPage
    {
        public void NavigateToURL(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        public void ClickJoinButton(IWebDriver driver)
        {
            IWebElement JoinButton = driver.FindElement(By.XPath("//button[contains(text(),'Join')]"));// relative xpath
            //IWebElement JoinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button")); // absolute xpath
            Thread.Sleep(2000);
            JoinButton.Click();
            Thread.Sleep(3000);
        }

        public void RegistrationWindow(IWebDriver driver)
        {
            IWebElement FirstTextbox = driver.FindElement(By.XPath("//input"));
            if (FirstTextbox.Text == "")
            {
                Console.WriteLine("Registration window was opened successfully, Test Passed.");
            }

            else
            {
                Console.WriteLine("Registration window was not opened successfully, Test Failed.");
            }
            driver.Quit();
        }

        public void SignIn(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        public void EnterRegistrationDetails(IWebDriver driver, string FirstName, string LastName, string emailid, string password, string confirmpassword)
        {
            IWebElement FirstNameTextbox = driver.FindElement(By.XPath("//input[@name='firstName']"));
            FirstNameTextbox.Clear();
            FirstNameTextbox.SendKeys(FirstName);

            IWebElement LastNameTextbox = driver.FindElement(By.Name("lastName"));
            LastNameTextbox.Clear();
            LastNameTextbox.SendKeys(LastName);

            IWebElement EmailIdTextbox = driver.FindElement(By.Name("email"));
            EmailIdTextbox.Clear();
            EmailIdTextbox.SendKeys(emailid);

            IWebElement PasswordTextbox = driver.FindElement(By.Name("password"));
            PasswordTextbox.Clear();
            PasswordTextbox.SendKeys(password);

            IWebElement ConfirmPasswordTextbox = driver.FindElement(By.Name("confirmPassword"));
            ConfirmPasswordTextbox.Clear();
            ConfirmPasswordTextbox.SendKeys(confirmpassword);
            Thread.Sleep(2000);
        }

        public void CheckedCheckboxAndSubmitButton(IWebDriver driver)
        {
            try
            {
                IWebElement Checkbox = driver.FindElement(By.Name("terms"));
                Checkbox.Click();
                Thread.Sleep(1000);
                IWebElement SubmitButton = driver.FindElement(By.Id("submit-btn"));
                SubmitButton.Click();
                Thread.Sleep(2000);
                Console.WriteLine("\n Registration Successful.");
            }
            catch (Exception ex)
            {
                Assert.Fail("Email ID has already been used to register an account.", ex.Message);
                driver.Close();
            }
        }

        public void UsersDetailsRegistered(IWebDriver driver) 
        {
            Thread.Sleep(2000);
            Console.WriteLine("\n Users details registered successfully.");
            driver.Close();
        }
        public void ClickSignInButton(IWebDriver driver)
        {
            IWebElement SignInButton = driver.FindElement(By.XPath("//a[@class='item']"));//relative xpath
            SignInButton.Click();
            Thread.Sleep(1000);
        }
        public void LoginWindow(IWebDriver driver)
        {
            IWebElement EmailTextbox = driver.FindElement(By.Name("email"));
            if (EmailTextbox.Text == "")
            {
                Console.WriteLine("Login window was opened successfully, Test Passed.");
            }
            else
            {
                Console.WriteLine("Login window was not opened successfully, Test Failed.");
            }
            driver.Quit();
        }

        public void EnterLoginDetails(IWebDriver driver, string emailid, string password)
        {
            try
            {
                IWebElement EmailIdTextbox = driver.FindElement(By.Name("email"));
                EmailIdTextbox.Click();
                EmailIdTextbox.SendKeys(emailid);
                IWebElement PasswordTextbox = driver.FindElement(By.Name("password"));
                PasswordTextbox.Click();
                PasswordTextbox.SendKeys(password);
                IWebElement RemembermeCheckbox = driver.FindElement(By.Name("rememberDetails"));
                RemembermeCheckbox.Click();
                IWebElement SubmitButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                SubmitButton.Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                driver.Close();
            }
        }

        public void Dashboard(IWebDriver driver)
        {
            Assert.AreEqual("http://localhost:5000/Account/Profile", driver.Url);
            driver.Close();
        }

        public void ForgetYourPasswordLinkText(IWebDriver driver)
        {
            //IWebElement ForgetPassword = driver.FindElement(By.XPath("//a[contains(text(),'Forgot your password?')]"));//relative xpath with contains function
            IWebElement ForgetPassword = driver.FindElement(By.XPath("//a[text()='Forgot your password?']"));//relative xpath with text function
            ForgetPassword.Click();
            Thread.Sleep(1000);
        }
        public void EnterEmailId(IWebDriver driver, string emailid)
        {
            IWebElement EnterEmailId = driver.FindElement(By.Name("email"));
            EnterEmailId.Click();
            EnterEmailId.SendKeys(emailid);
            Thread.Sleep(2000);

        }

        public void PasswordResetLink(IWebDriver driver)
        {
            IWebElement SendVerificationEmailButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div/div[2]/div"));
            SendVerificationEmailButton.Click();
            Thread.Sleep(4000);
            Console.WriteLine("Reset link sent out, Test Passed.");
            driver.Close();
        }
        public void EnterWrongLoginDetails(IWebDriver driver, string wrongemailid, string wrongpassword)
        {
            IWebElement EmailIdTextbox = driver.FindElement(By.Name("email"));
            EmailIdTextbox.Click();
            EmailIdTextbox.SendKeys(wrongemailid);
            Thread.Sleep(1000);
            IWebElement PasswordTextbox = driver.FindElement(By.Name("password"));
            PasswordTextbox.Click();
            PasswordTextbox.SendKeys(wrongpassword);
            Thread.Sleep(1000);
            IWebElement RemembermeCheckbox = driver.FindElement(By.Name("rememberDetails"));
            RemembermeCheckbox.Click();
            Thread.Sleep(1000);
            IWebElement SubmitButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            SubmitButton.Click();
            Thread.Sleep(3000);
        }
        public void UserNavToSendVerificationPopup(IWebDriver driver, string WrongEmailId1)
        {
            IWebElement EmailIdTextbox = driver.FindElement(By.Name("email"));
            string emailText = EmailIdTextbox.GetAttribute("value");
            //Console.WriteLine("\n Email ID that available in textbox-> " + emailText);
            string p1 = WrongEmailId1;
            if (emailText == p1)
            {
                Console.WriteLine("\n User navigated to Send verification popup box." + p1);
            }
            else
            {
                Console.WriteLine("\n User was not navigated to Send verification popup box." + p1);
            }
            driver.Close();
        }

        
        

        
        
        
        
    }
}
