using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Language_Tab_Page
    {
        public void Add_Language(IWebDriver driver, string language)
        {
            Thread.Sleep(1000);
            IWebElement add_new_button = driver.FindElement(By.XPath("//div[@class='ui teal button ']"));//relative xpath
            add_new_button.Click();
            Thread.Sleep(1000);
            IWebElement language_textbox = driver.FindElement(By.Name("name"));
            language_textbox.Click();
            Thread.Sleep(1000);
            language_textbox.SendKeys(language);
            IWebElement drop_down = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            drop_down.Click();
            Thread.Sleep(1000);
            IWebElement level_selection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            level_selection.Click();
            Thread.Sleep(1000);
            IWebElement add_buuton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add_buuton.Click();
            Thread.Sleep(1000);
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
        public void Edit_Language_And_Level(IWebDriver driver, string new_langu)
        {
            IWebElement edit_button = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span/i"));
            edit_button.Click();
            IWebElement name_lang_textbox = driver.FindElement(By.Name("name"));
            name_lang_textbox.Click(); name_lang_textbox.Clear();
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
            Thread.Sleep(2000);
        }
        public void Deleted_Language_And_Level(IWebDriver driver)
        {
            Console.WriteLine("\n Language and Levle deleted successfully.");
            driver.Close();
        }
    }
}
