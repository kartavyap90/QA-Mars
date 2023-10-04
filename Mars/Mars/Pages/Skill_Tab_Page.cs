using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Skill_Tab_Page
    {
        public void Add_Skill(IWebDriver driver, string skill)
        {
            IWebElement skill_label = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            skill_label.Click();
            IWebElement add_new_button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            add_new_button.Click();
            Thread.Sleep(1000);
            IWebElement skill_textbox = driver.FindElement(By.Name("name"));
            skill_textbox.Click();
            skill_textbox.SendKeys(skill);
            Thread.Sleep(1000);
            IWebElement skill_drop_down = driver.FindElement(By.Name("level"));
            skill_drop_down.Click();
            Thread.Sleep(1000);
            IWebElement skill_level_selection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            skill_level_selection.Click();
            Thread.Sleep(1000);
            IWebElement add_buuton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            add_buuton.Click();
        }
        public void Skill_Added(IWebDriver driver, string skill)
        {
            Thread.Sleep(1000);
            IWebElement added_skill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
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
            Thread.Sleep(1000);
            IWebElement skill_drop_down = driver.FindElement(By.Name("level"));
            skill_drop_down.Click();
            Thread.Sleep(1000);
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
            Thread.Sleep(1000);
            IWebElement skill_label = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            skill_label.Click();
            Thread.Sleep(1000);
            IWebElement edit_button = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            edit_button.Click();
            Thread.Sleep(1000);
            IWebElement name_skill_textbox = driver.FindElement(By.Name("name"));
            name_skill_textbox.Click(); name_skill_textbox.Clear();
            name_skill_textbox.SendKeys(new_skill);
            Thread.Sleep(1000);
            IWebElement new_skill_level_drop_down = driver.FindElement(By.XPath("//select[@name='level']"));//relative xpath
            new_skill_level_drop_down.Click();
            Thread.Sleep(1000);
            IWebElement select_new_skill_level = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
            select_new_skill_level.Click();
            Thread.Sleep(1000);
            IWebElement update_button = driver.FindElement(By.XPath("//input[@value='Update']"));
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

            IWebElement skill_label = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            skill_label.Click();
            Thread.Sleep(1000);
            IWebElement delete_icon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            delete_icon.Click();
            Thread.Sleep(1000);
        }
        public void Deleted_Skill_And_Level(IWebDriver driver)
        {
            Console.WriteLine("\n Skill and Levle deleted successfully.");
            driver.Close();
        }
    }
}
