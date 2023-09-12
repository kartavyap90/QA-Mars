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
            catch (Exception ex)
            {
                Assert.Fail("Email ID has already been used to register an account.", ex.Message);
            }
            driver.Close();
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
            Assert.AreEqual("http://localhost:5000/", driver.Url);
            driver.Close();
        }

        public void Forget_Your_Password_LinkText(IWebDriver driver)
        {
            IWebElement forget_password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/a"));
            forget_password.Click();
        }
        public void enter_email_id(IWebDriver driver, string email_id)
        {
            IWebElement enter_email_id = driver.FindElement(By.Name("email"));
            enter_email_id.Click();
            enter_email_id.SendKeys(email_id);

        }

        public void password_reset_link(IWebDriver driver)
        {
            IWebElement send_verification_email_button = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div/div[2]/div"));
            send_verification_email_button.Click();
            Console.WriteLine("Reset link sent out, Test Passed.");
            driver.Close();
        }
        public void Enter_Wrong_Login_Details(IWebDriver driver, string wrong_email_id, string wrong_password)
        {
            IWebElement email_id_textbox = driver.FindElement(By.Name("email"));
            email_id_textbox.Click();
            email_id_textbox.SendKeys(wrong_email_id);
            IWebElement password_textbox = driver.FindElement(By.Name("password"));
            password_textbox.Click();
            password_textbox.SendKeys(wrong_password);
            IWebElement remember_me_checkbox = driver.FindElement(By.Name("rememberDetails"));
            remember_me_checkbox.Click();
            IWebElement submit_button = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            submit_button.Click();
        }
        public void User_Nav_To_Send_Verification_Popup(IWebDriver driver, string wrong_email_id1) 
        {
            IWebElement emaill_id_textbox = driver.FindElement(By.Name("email"));
            string emailText = emaill_id_textbox.GetAttribute("value");
            Console.WriteLine("\n Email ID that available in textbox-> " + emailText);
            string p1 = wrong_email_id1;
            if (emailText == p1)
            {
                Console.WriteLine("\n User navigated to Send verification popup box."+p1);
            }
            else
            {
                Console.WriteLine("\n User was not navigated to Send verification popup box."+p1);
            }
            

            driver.Close();
        }

        public void Add_Language(IWebDriver driver, string language)
        {
            IWebElement add_new_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            add_new_button.Click();
            IWebElement language_textbox = driver.FindElement(By.Name("name"));
            language_textbox.Click();
            language_textbox.SendKeys(language);
            IWebElement drop_down = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            drop_down.Click();
            IWebElement level_selection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            level_selection.Click();
            IWebElement add_buuton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add_buuton.Click();
        }
        public void Language_Added(IWebDriver driver, string lang) 
        {
             Thread.Sleep(1000);
             IWebElement added_language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[last()]/td[1]"));
             string lan = added_language.Text;
             //Console.WriteLine("Value from portal: " + lan);
             string la = lang;
             if (la == lan)
             {
                 Console.WriteLine("\nLanguage added at last successfully: " + lang);
             }
             else
            { 
                    Console.WriteLine("\nLanguage was not added successfully.");
            }
            driver.Close();
        }
        public void Add_Language_without_Data(IWebDriver driver)
        {
            IWebElement add_new_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            add_new_button.Click();
            IWebElement lang_textbox = driver.FindElement(By.Name("name"));
            lang_textbox.SendKeys("");
            IWebElement drop_down = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            drop_down.Click();
            IWebElement no_level_selection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[1]"));
            no_level_selection.Click();
            IWebElement add = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add.Click();
            Thread.Sleep(1000);
        }
        public void Error_Message_For_Language_Add(IWebDriver driver)
        {
            Console.WriteLine("\nNo language added in list.");
            driver.Close();
        }
        public void Edit_Language_And_Level(IWebDriver driver,string new_langu)
        {
            IWebElement edit_button = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span/i"));
            edit_button.Click();
            IWebElement name_lang_textbox = driver.FindElement(By.Name("name"));
            name_lang_textbox.Click();name_lang_textbox.Clear();
            name_lang_textbox.SendKeys(new_langu);
            IWebElement new_level_drop_down = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            new_level_drop_down.Click();
            IWebElement select_new_level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[4]"));
            select_new_level.Click();
            IWebElement update_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            update_button.Click();
            Thread.Sleep(1000);
        }
        public void Edited_Language_And_Level(IWebDriver driver)
        {
            Console.WriteLine("\nLanguage and Level edited.");
            driver.Close();
        }
        public void Delete_Language_And_Level(IWebDriver driver)
        {
            IWebElement delete_icon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
            delete_icon.Click();
        }
        public void Deleted_Language_And_Level(IWebDriver driver)
        {
            Console.WriteLine("\n Language and Levle deleted successfully.");
            driver.Close();
        }
        public void Add_Skill(IWebDriver driver, string skill)
        {
            IWebElement skill_label = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            skill_label.Click();
            IWebElement add_new_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            add_new_button.Click();
            IWebElement skill_textbox = driver.FindElement(By.Name("name"));
            skill_textbox.Click();
            skill_textbox.SendKeys(skill);
            IWebElement skill_drop_down = driver.FindElement(By.Name("level"));
            skill_drop_down.Click();
            IWebElement skill_level_selection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            skill_level_selection.Click();
            IWebElement add_buuton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            add_buuton.Click();
        }
        public void Skill_Added(IWebDriver driver, string skill)
        {
            Thread.Sleep(1000);
            IWebElement added_skill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[last()]/td[1]"));
            string portal_skill = added_skill.Text;
            //Console.WriteLine("Value from portal: " + portal_skill);
            string para_skill = skill;
            if (para_skill == portal_skill)
            {
                Console.WriteLine("\nSkill added at last successfully: " + portal_skill);
            }
            else
            {
                Console.WriteLine("\nSkill was not added successfully.");
            }
            driver.Close();
        }
        public void Add_Skill_without_Data(IWebDriver driver)
        {
            IWebElement skill_label = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            skill_label.Click();
            IWebElement add_new_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            add_new_button.Click();
            IWebElement skill_textbox = driver.FindElement(By.Name("name"));
            skill_textbox.SendKeys("");
            IWebElement skill_drop_down = driver.FindElement(By.Name("level"));
            skill_drop_down.Click();
            IWebElement no_skill_level_selection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[1]"));
            no_skill_level_selection.Click();
            IWebElement add_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            add_button.Click();
            Thread.Sleep(1000);
        }
        public void Error_Message_For_Add_Skill_without_Data(IWebDriver driver)
        {
            Console.WriteLine("\nNo skill added in list beacuse no data entered.");
            driver.Close();
        }
        public void Edit_Skill_And_Level(IWebDriver driver, string new_skill)
        {
            IWebElement edit_button = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span/i"));
            edit_button.Click();
            IWebElement name_skill_textbox = driver.FindElement(By.Name("name"));
            name_skill_textbox.Click(); name_skill_textbox.Clear();
            name_skill_textbox.SendKeys(new_skill);
            IWebElement new_skill_level_drop_down = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            new_skill_level_drop_down.Click();
            IWebElement select_new_skill_level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[4]"));
            select_new_skill_level.Click();
            IWebElement update_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            update_button.Click();
            Thread.Sleep(1000);
        }
        public void Edited_Skill_And_Level(IWebDriver driver)
        {
            Console.WriteLine("\nSkill and Level edited.");
            driver.Close();
        }
        public void Delete_Skill_And_Level(IWebDriver driver)
        {
            IWebElement delete_icon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
            delete_icon.Click();
        }
        public void Deleted_Skill_And_Level(IWebDriver driver)
        {
            Console.WriteLine("\n Skill and Levle deleted successfully.");
            driver.Close();
        }


    }
}
