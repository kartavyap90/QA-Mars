using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

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
            IWebElement join_button = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
            join_button.Click();
        }
        
        public void Registration_Window(IWebDriver driver)
        {
            IWebElement first_textbox = driver.FindElement(By.Name("firstName"));
            if (first_textbox.Text == "" ) 
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
        public void Enter_Registration_Details(IWebDriver driver,string first_name,string last_name, string email_id,string password, string confirm_password)
        {
            IWebElement first_name_textbox = driver.FindElement(By.Name("firstName"));
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
                Thread.Sleep(2000);
                IWebElement submit_button = driver.FindElement(By.Id("submit-btn"));
                submit_button.Click();
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement popup = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ns-box-inner")));
                string popupText = popup.Text;
                Assert.IsTrue(popupText.Contains("Registration successful"));
            }
            catch(Exception ex) 
            { 
                Assert.Fail("Email ID has already been used to register an account.",ex.Message);
            }
        }
        public void Click_Sign_In_Button(IWebDriver driver)
        {
            IWebElement sign_in_button = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            sign_in_button.Click();
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

        public void Enter_Login_Details(IWebDriver driver, string email_id,string password) 
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
            }
            catch(Exception ex) 
            {
                Assert.Fail(ex.Message);
                driver.Close();
            }
        }

        public void dashboard(IWebDriver driver)
        {
            Assert.AreEqual("http://localhost:5000/", driver.Url);
            driver.Close();
        }


    }
}
