using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Education_Tab_Page
    {
        public void Click_Education_Tab(IWebDriver driver)
        {
            IWebElement click_education_tab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            click_education_tab.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Education_Tab(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked on education tab.");
            driver.Close();
        }
        public void Click_Add_New_Button_Education(IWebDriver driver)
        {
            IWebElement education_tab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            education_tab.Click();
            Thread.Sleep(1000);
            IWebElement add_new_button_education = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            add_new_button_education.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Add_New_Button_Education(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Add New button in education tab.");
            driver.Close();
        }
        public void Click_Add_Button_Without_Education_Details(IWebDriver driver)
        {
            IWebElement add_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            add_button.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Add_Button_Without_Education_Details(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Add button without education details and received an error.");
            driver.Close();
        }
        public void Click_Cancel_Button_Education(IWebDriver driver)
        {
            IWebElement cancel_button_education = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[2]"));
            cancel_button_education.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Cancel_Button_Education(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Cancel button in education tab.");
            driver.Close();
        }
        public void Enter_Education_Details(IWebDriver driver, string college_university_name, string degree_name)
        {
            IWebElement college_university_textbox = driver.FindElement(By.Name("instituteName"));
            college_university_textbox.Click();
            college_university_textbox.Clear();
            college_university_textbox.SendKeys(college_university_name);
            Thread.Sleep(1000);

            IWebElement country_college_university_dropdown = driver.FindElement(By.Name("country"));
            country_college_university_dropdown.Click();
            IWebElement select_country_college_university_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            select_country_college_university_dropdown.Click();
            Thread.Sleep(1000);

            IWebElement title_dropdown = driver.FindElement(By.Name("title"));
            title_dropdown.Click();
            IWebElement select_title_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[11]"));
            select_title_dropdown.Click();
            Thread.Sleep(1000);

            IWebElement degree_textbox = driver.FindElement(By.Name("degree"));
            degree_textbox.Click();
            degree_textbox.Clear();
            degree_textbox.SendKeys(degree_name);
            Thread.Sleep(1000);

            IWebElement graduation_dropdown = driver.FindElement(By.Name("yearOfGraduation"));
            graduation_dropdown.Click();
            IWebElement select_graduation_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[2]"));
            select_graduation_dropdown.Click();
            Thread.Sleep(1000);

            IWebElement add_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            add_button.Click();
            Thread.Sleep(1000);
        }
        public void Entered_Education_Details(IWebDriver driver)
        {
            Console.WriteLine("\n Education Details successfully entered by the user.");
            driver.Close();
        }
        public void Edited_Education_Details(IWebDriver driver, string college_university_name, string degree_name)
        {
            IWebElement college_university_textbox = driver.FindElement(By.Name("instituteName"));
            college_university_textbox.Click();
            college_university_textbox.Clear();
            college_university_textbox.SendKeys(college_university_name);
            Thread.Sleep(1000);

            IWebElement country_college_university_dropdown = driver.FindElement(By.Name("country"));
            country_college_university_dropdown.Click();
            IWebElement select_country_college_university_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[11]"));
            select_country_college_university_dropdown.Click();
            Thread.Sleep(1000);

            IWebElement title_dropdown = driver.FindElement(By.Name("title"));
            title_dropdown.Click();
            IWebElement select_title_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[12]"));
            select_title_dropdown.Click();
            Thread.Sleep(1000);

            IWebElement degree_textbox = driver.FindElement(By.Name("degree"));
            degree_textbox.Click();
            degree_textbox.Clear();
            degree_textbox.SendKeys(degree_name);
            Thread.Sleep(1000);

            IWebElement graduation_dropdown = driver.FindElement(By.Name("yearOfGraduation"));
            graduation_dropdown.Click();
            IWebElement select_graduation_dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[3]"));
            select_graduation_dropdown.Click();
            Thread.Sleep(1000);

            IWebElement add_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            add_button.Click();
            Thread.Sleep(1000);
        }
        public void Edited_Education_Details(IWebDriver driver)
        {
            Console.WriteLine("\n Education Details successfully edited by the user.");
            driver.Close();
        }
        public void Click_Cross_Icon_Education(IWebDriver driver)
        {
            IWebElement cross_icon_education = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i"));
            cross_icon_education.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Cross_Icon_Education(IWebDriver driver)
        {
            Console.WriteLine("\n Education Details successfully deleted by the user.");
            driver.Close();
        }
    }
}
