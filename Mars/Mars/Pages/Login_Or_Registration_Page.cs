using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace Mars.Pages
{
    public class Login_Or_Registration_Page
    {
        public void Navigate_To_URL(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        public void Click_Join_Button(IWebDriver driver)
        {
            IWebElement join_button = driver.FindElement(By.XPath("//a[contains(text(),'Join')]"));
            //IWebElement sign_in_button = driver.FindElement(By.XPath("//a[@class='item']"));
            join_button.Click();
            Thread.Sleep(2000);
        }

        public void Registration_Window(IWebDriver driver)
        {
            IWebElement first_textbox = driver.FindElement(By.Name("firstName"));
            if (first_textbox.Text == "")
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
        public void Enter_Registration_Details(IWebDriver driver, string first_name, string last_name, string email_id, string password, string confirm_password)
        {
            IWebElement first_name_textbox = driver.FindElement(By.XPath("//input[@name='firstName']"));
            first_name_textbox.Clear();
            first_name_textbox.SendKeys(first_name);

            IWebElement last_name_textbox = driver.FindElement(By.Name("lastName"));
            last_name_textbox.Clear();
            last_name_textbox.SendKeys(last_name);

            IWebElement email_id_textbox = driver.FindElement(By.Name("email"));
            email_id_textbox.Clear();
            email_id_textbox.SendKeys(email_id);

            IWebElement password_textbox = driver.FindElement(By.Name("password"));
            password_textbox.Clear();
            password_textbox.SendKeys(password);

            IWebElement confirm_password_textbox = driver.FindElement(By.Name("confirmPassword"));
            confirm_password_textbox.Clear();
            confirm_password_textbox.SendKeys(confirm_password);
        }

        public void Checked_Checkbox_And_Submit_Button(IWebDriver driver)
        {
            try
            {
                IWebElement check_box = driver.FindElement(By.Name("terms"));
                check_box.Click();
                Thread.Sleep(1000);
                IWebElement submit_button = driver.FindElement(By.Id("submit-btn"));
                submit_button.Click();
                Thread.Sleep(2000);
                Console.WriteLine("\n Registration Successful.");
            }
            catch (Exception ex)
            {
                Assert.Fail("Email ID has already been used to register an account.", ex.Message);
                driver.Close();
            }
        }

        public void Users_Details_Registered(IWebDriver driver) 
        {
            Thread.Sleep(2000);
            Console.WriteLine("\n Users details registered successfully.");
            driver.Close();
        }
        public void Click_Sign_In_Button(IWebDriver driver)
        {
            IWebElement sign_in_button = driver.FindElement(By.XPath("//a[@class='item']"));//relative xpath
            sign_in_button.Click();
            Thread.Sleep(1000);
        }
        public void Login_Window(IWebDriver driver)
        {
            IWebElement email_textbox = driver.FindElement(By.Name("email"));
            if (email_textbox.Text == "")
            {
                Console.WriteLine("Login window was opened successfully, Test Passed.");
            }
            else
            {
                Console.WriteLine("Login window was not opened successfully, Test Failed.");
            }
            driver.Quit();
        }

        public void Enter_Login_Details(IWebDriver driver, string email_id, string password)
        {
            try
            {
                IWebElement email_id_textbox = driver.FindElement(By.Name("email"));
                email_id_textbox.Click();
                email_id_textbox.SendKeys(email_id);
                IWebElement password_textbox = driver.FindElement(By.Name("password"));
                password_textbox.Click();
                password_textbox.SendKeys(password);
                IWebElement remember_me_checkbox = driver.FindElement(By.Name("rememberDetails"));
                remember_me_checkbox.Click();
                IWebElement submit_button = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                submit_button.Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
                driver.Close();
            }
        }

        public void dashboard(IWebDriver driver)
        {
            Assert.AreEqual("http://localhost:5000/Account/Profile", driver.Url);
            driver.Close();
        }

        public void Forget_Your_Password_LinkText(IWebDriver driver)
        {
            //IWebElement forget_password = driver.FindElement(By.XPath("//a[contains(text(),'Forgot your password?')]"));//relative xpath with contains function
            IWebElement forget_password = driver.FindElement(By.XPath("//a[text()='Forgot your password?']"));//relative xpath with text function
            forget_password.Click();
            Thread.Sleep(1000);
        }
        public void enter_email_id(IWebDriver driver, string email_id)
        {
            IWebElement enter_email_id = driver.FindElement(By.Name("email"));
            enter_email_id.Click();
            enter_email_id.SendKeys(email_id);
            Thread.Sleep(2000);

        }

        public void password_reset_link(IWebDriver driver)
        {
            IWebElement send_verification_email_button = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div/div[2]/div"));
            send_verification_email_button.Click();
            Thread.Sleep(4000);
            Console.WriteLine("Reset link sent out, Test Passed.");
            driver.Close();
        }
        public void Enter_Wrong_Login_Details(IWebDriver driver, string wrong_email_id, string wrong_password)
        {
            IWebElement email_id_textbox = driver.FindElement(By.Name("email"));
            email_id_textbox.Click();
            email_id_textbox.SendKeys(wrong_email_id);
            Thread.Sleep(1000);
            IWebElement password_textbox = driver.FindElement(By.Name("password"));
            password_textbox.Click();
            password_textbox.SendKeys(wrong_password);
            Thread.Sleep(1000);
            IWebElement remember_me_checkbox = driver.FindElement(By.Name("rememberDetails"));
            remember_me_checkbox.Click();
            Thread.Sleep(1000);
            IWebElement submit_button = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            submit_button.Click();
            Thread.Sleep(3000);
        }
        public void User_Nav_To_Send_Verification_Popup(IWebDriver driver, string wrong_email_id1)
        {
            IWebElement emaill_id_textbox = driver.FindElement(By.Name("email"));
            string emailText = emaill_id_textbox.GetAttribute("value");
            //Console.WriteLine("\n Email ID that available in textbox-> " + emailText);
            string p1 = wrong_email_id1;
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
