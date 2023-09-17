using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Profile_Panel_Dashboard_Page
    {
        public void Click_Edit_Dropdown(IWebDriver driver)
        {
            IWebElement edit_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            edit_dropdown.Click();
        }
        public void Clicked_Edit_Dropdown(IWebDriver driver)
        {
            Console.WriteLine("\n User clicked Edit dropdown successfully.");
            Thread.Sleep(1000);
            driver.Close();
        }
        public void Edit_First_And_Last_Name(IWebDriver driver, string first_name, string last_name)
        {
            IWebElement edit_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            edit_dropdown.Click();
            IWebElement first_name_textbox = driver.FindElement(By.Name("firstName"));
            first_name_textbox.Click();
            first_name_textbox.Clear();
            first_name_textbox.SendKeys(first_name);
            IWebElement last_name_textbox = driver.FindElement(By.Name("lastName"));
            last_name_textbox.Click();
            last_name_textbox.Clear();
            last_name_textbox.SendKeys(last_name);
            IWebElement save_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            save_button.Click();
            Thread.Sleep(1000);
        }
        public void Edited_First_And_Last_Name(IWebDriver driver, string first_name, string last_name)
        {
            IWebElement edit_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            edit_dropdown.Click();
            IWebElement first_name_textbox = driver.FindElement(By.Name("firstName"));
            IWebElement last_name_textbox = driver.FindElement(By.Name("lastName"));
            string f = first_name_textbox.GetAttribute("value");
            string l = last_name_textbox.GetAttribute("value");
            string para_first = first_name;
            string para_last = last_name;
            if (f == para_first && l == para_last)
            {

                Console.WriteLine("\n First and last name edited successfully.");

            }
            else
            {
                Console.WriteLine("\n First and last name not matched with parameter passed from feature file.");
            }
            driver.Close();
        }
        public void First_And_Last_Name_As_Blank(IWebDriver driver)
        {
            IWebElement edit_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            edit_dropdown.Click();
            IWebElement first_name_textbox = driver.FindElement(By.Name("firstName"));
            IWebElement last_name_textbox = driver.FindElement(By.Name("lastName"));
            first_name_textbox.Clear();
            last_name_textbox.Clear();
            //first_name_textbox.SendKeys("");
            //last_name_textbox.SendKeys("");
            Thread.Sleep(3000);
            IWebElement save_button = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            Thread.Sleep(3000);
            save_button.Click();

        }
        public void Error_Message_First_And_Last_Name_As_Blank(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement edit_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            edit_dropdown.Click();
            Thread.Sleep(1000);
            IWebElement first_name_textbox = driver.FindElement(By.Name("firstName"));
            IWebElement last_name_textbox = driver.FindElement(By.Name("lastName"));
            string f = first_name_textbox.GetAttribute("value");
            string l = first_name_textbox.GetAttribute("value");
            if (f == "" && l == "")
            {
                Console.WriteLine("\n First and last name are blank, User need to enter first and last name.");
            }
            else
            {
                Console.WriteLine("\n First and last name are not blank.");
            }
            driver.Close();
        }
        public void First_And_Last_Name_As_White_Space(IWebDriver driver, string first, string last)
        {
            IWebElement edit_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            edit_dropdown.Click();
            IWebElement first_name_textbox = driver.FindElement(By.Name("firstName"));
            first_name_textbox.Click();
            first_name_textbox.Clear();
            first_name_textbox.SendKeys(first);
            IWebElement last_name_textbox = driver.FindElement(By.Name("lastName"));
            last_name_textbox.Click();
            last_name_textbox.Clear();
            last_name_textbox.SendKeys(last);
            IWebElement save_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            save_button.Click();
            Thread.Sleep(1000);
        }
        public void Error_Message_First_And_Last_Name_As_White_Space(IWebDriver driver, string first, string last)
        {
            IWebElement edit_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            edit_dropdown.Click();
            Thread.Sleep(1000);
            IWebElement first_name_textbox = driver.FindElement(By.Name("firstName"));
            IWebElement last_name_textbox = driver.FindElement(By.Name("lastName"));
            string f = first_name_textbox.GetAttribute("value");
            string l = last_name_textbox.GetAttribute("value");
            string para_first = first;
            string para_last = last;
            if (f == para_first && l == para_last)
            {

                Console.WriteLine("\n First and last name has no value.");

            }
            else
            {
                Console.WriteLine("\n First and last name has value");
            }
            driver.Close();
        }
        public void Click_Edit_Icon_Of_Availability(IWebDriver driver)
        {
            IWebElement edit_icon_availability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            edit_icon_availability.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Edit_Icon_Of_Availability(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on edit icon of availability.");
            driver.Close();
        }
        public void Click_Cross_Icon_Of_Availability(IWebDriver driver)
        {
            IWebElement cross_icon_availability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            cross_icon_availability.Click();
            Thread.Sleep(2000);
        }
        public void Clicked_Cross_Icon_Of_Availability(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on cross icon of availability.");
            driver.Close();
        }
        public void Change_Value_Of_Availability(IWebDriver driver)
        {
            IWebElement edit_icon_availability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            edit_icon_availability.Click();
            Thread.Sleep(1000);
            IWebElement availability_dropdown = driver.FindElement(By.Name("availabiltyType"));
            availability_dropdown.Click();
            IWebElement select_availability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
            select_availability.Click();
        }
        public void Changed_Value_Of_Availability(IWebDriver driver)
        {
            Console.WriteLine("\n Availability valued changed.");
            driver.Close();
        }
        public void Click_Edit_Icon_Of_Hours(IWebDriver driver)
        {
            IWebElement edit_icon_hours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            edit_icon_hours.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Edit_Icon_Of_Hours(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on edit icon of hours.");
            driver.Close();
        }
        public void Click_Cross_Icon_Of_Hours(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement cross_icon_hours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            cross_icon_hours.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Cross_Icon_Of_Hours(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on cross icon of hours.");
            driver.Close();
        }
        public void Change_Value_Of_Hours(IWebDriver driver)
        {
            IWebElement edit_icon_hours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            edit_icon_hours.Click();
            Thread.Sleep(1000);
            IWebElement hours_dropdown = driver.FindElement(By.Name("availabiltyHour"));
            hours_dropdown.Click();
            IWebElement select_hours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]"));
            select_hours.Click();
            Thread.Sleep(1000);
        }
        public void Changed_Value_Of_Hours(IWebDriver driver)
        {
            Console.WriteLine("\n Hours valued changed.");
            driver.Close();
        }
        public void Click_Edit_Icon_Of_Earn_Target(IWebDriver driver)
        {
            IWebElement edit_icon_earn_target = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            edit_icon_earn_target.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Edit_Icon_Of_Earn_Target(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on edit icon of earn_target.");
            driver.Close();
        }
        public void Click_Cross_Icon_Of_Earn_Target(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement cross_icon_earn_target = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            cross_icon_earn_target.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Cross_Icon_Of_Earn_Target(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on cross icon of earn target.");
            driver.Close();
        }
        public void Change_Value_Of_Earn_Target(IWebDriver driver)
        {
            IWebElement edit_icon_earn_target = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            edit_icon_earn_target.Click();
            Thread.Sleep(1000);
            IWebElement earn_target_dropdown = driver.FindElement(By.Name("availabiltyTarget"));
            earn_target_dropdown.Click();
            IWebElement select_earn_target = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));
            select_earn_target.Click();
            Thread.Sleep(1000);
        }
        public void Changed_Value_Of_Earn_Target(IWebDriver driver)
        {
            Console.WriteLine("\n Earn_target valued changed.");
            driver.Close();
        }
    }
}
