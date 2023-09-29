using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Certification_Tab_Page
    {
        public void Click_Certification_Tab(IWebDriver driver)
        {
            IWebElement click_certification_tab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            click_certification_tab.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Certification_Tab(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked on certification tab.");
            driver.Close();
        }
        public void Click_Add_New_Button_Certification(IWebDriver driver)
        {
            IWebElement add_new_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            add_new_button.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Add_New_Button_Certification(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Add New button in certification tab.");
            driver.Close();
        }
        public void Click_Add_Button_Without_Certification_Details(IWebDriver driver)
        {
            IWebElement add_button_certification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            add_button_certification.Click();
            Thread.Sleep(2000);
        }
        public void Clicked_Add_Button_Without_Certification_Details(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Add button without certification details and received an error.");
            driver.Close();
        }

        public void Click_Cancel_Button_Certification(IWebDriver driver)
        {
            IWebElement cancel_button_certification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[2]"));
            cancel_button_certification.Click();
            Thread.Sleep(2000);
        }
        public void Clicked_Cancel_Button_Certification(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Cancel button in certification tab.");
            driver.Close();
        }
        public void Enter_Certification_Details(IWebDriver driver, string certificate_award_name, string certification_from_name)
        {
            IWebElement certificate_award_name_textbox = driver.FindElement(By.Name("certificationName"));
            certificate_award_name_textbox.Click();
            certificate_award_name_textbox.Clear();
            certificate_award_name_textbox.SendKeys(certificate_award_name);
            Thread.Sleep(1000);

            IWebElement certification_from_textbox = driver.FindElement(By.Name("certificationFrom"));
            certification_from_textbox.Click();
            certification_from_textbox.Clear();
            certification_from_textbox.SendKeys(certification_from_name);
            Thread.Sleep(1000);

            IWebElement certificate_year_dropdown = driver.FindElement(By.Name("certificationYear"));
            certificate_year_dropdown.Click();
            IWebElement select_certificate_year = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[5]"));
            select_certificate_year.Click();
            Thread.Sleep(1000);

            IWebElement add_button_certification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            add_button_certification.Click();
            Thread.Sleep(1000);
        }
        public void Entered_Certification_Details(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully entered certification details in certification tab.");
            driver.Close();
        }
        public void Edit_Certification_Details(IWebDriver driver, string new_certificate_award_name, string new_certification_from_name)
        {
            IWebElement edit_icon_certifications = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
            edit_icon_certifications.Click();
            Thread.Sleep(1000);

            IWebElement certificate_award_name_textbox = driver.FindElement(By.Name("certificationName"));
            certificate_award_name_textbox.Click();
            certificate_award_name_textbox.Clear();
            certificate_award_name_textbox.SendKeys(new_certificate_award_name);
            Thread.Sleep(1000);

            IWebElement certification_from_textbox = driver.FindElement(By.Name("certificationFrom"));
            certification_from_textbox.Click();
            certification_from_textbox.Clear();
            certification_from_textbox.SendKeys(new_certification_from_name);
            Thread.Sleep(1000);

            IWebElement certificate_year_dropdown = driver.FindElement(By.Name("certificationYear"));
            certificate_year_dropdown.Click();
            IWebElement select_certificate_year = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[3]/tr/td/div/div/div[3]/select/option[6]"));
            select_certificate_year.Click();
            Thread.Sleep(2000);

            IWebElement update_button_certification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[3]/tr/td/div/span/input[1]"));
            update_button_certification.Click();
            Thread.Sleep(1000);
        }
        public void Edited_Certification_Details(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully edited certification details.");
            driver.Close();
        }
        public void Click_Cross_Icon_Certification(IWebDriver driver)
        {
            IWebElement cross_icon_education = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
            cross_icon_education.Click();
            Thread.Sleep(2000);
        }
        public void Clicked_Cross_Icon_Certification(IWebDriver driver)
        {
            Console.WriteLine("\n Certification details successfully deleted by the user.");
            driver.Close();
        }
    }
}
