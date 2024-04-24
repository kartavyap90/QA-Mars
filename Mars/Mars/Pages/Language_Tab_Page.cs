using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class LanguageTabPage
    {
        public void AddLanguage(IWebDriver driver, string language)
        {
            Thread.Sleep(1000);
            IWebElement AddNewButton = driver.FindElement(By.XPath("//div[@class='ui teal button ']"));//relative xpath
            AddNewButton.Click();
            Thread.Sleep(1000);
            IWebElement LanguageTextbox = driver.FindElement(By.Name("name"));
            LanguageTextbox.Click();
            Thread.Sleep(1000);
            LanguageTextbox.SendKeys(language);
            IWebElement Dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            Dropdown.Click();
            Thread.Sleep(1000);
            IWebElement LevelSelection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            LevelSelection.Click();
            Thread.Sleep(1000);
            IWebElement Addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            Addbutton.Click();
            Thread.Sleep(1000);
        }
        public void LanguageAdded(IWebDriver driver, string lang)
        {
            Thread.Sleep(1000);
            IWebElement AddedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[Last()]/td[1]"));
            string lan = AddedLanguage.Text;
            //Console.WriteLine("Value from portal: " + lan);
            string la = lang;
            if (la == lan)
            {
                Console.WriteLine("\nLanguage Added at Last successfully: " + lang);
            }
            else
            {
                Console.WriteLine("\nLanguage was not Added successfully.");
            }
            driver.Close();
        }
        public void AddLanguageWithoutData(IWebDriver driver)
        {
            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
            IWebElement LangTextbox = driver.FindElement(By.Name("name"));
            LangTextbox.SendKeys("");
            IWebElement Dropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            Dropdown.Click();
            IWebElement NoLevelSelection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[1]"));
            NoLevelSelection.Click();
            IWebElement Add = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            Add.Click();
            Thread.Sleep(1000);
        }
        public void ErrorMessageForLanguageAdd(IWebDriver driver)
        {
            Console.WriteLine("\nNo language Added in list.");
            driver.Close();
        }
        public void EditLanguageAndLevel(IWebDriver driver, string newlangu)
        {
            IWebElement EditButton = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[Last()]/tr/td[3]/span/i"));
            EditButton.Click();
            IWebElement NameLangTextbox = driver.FindElement(By.Name("name"));
            NameLangTextbox.Click(); NameLangTextbox.Clear();
            NameLangTextbox.SendKeys(newlangu);
            IWebElement NewLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[Last()]/tr/td/div/div[2]/select"));
            NewLevelDropdown.Click();
            IWebElement SelectNewLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[Last()]/tr/td/div/div[2]/select/option[4]"));
            SelectNewLevel.Click();
            IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[Last()]/tr/td/div/span/input[1]"));
            UpdateButton.Click();
            Thread.Sleep(1000);
        }
        public void EditedLanguageAndLevel(IWebDriver driver)
        {
            Console.WriteLine("\nLanguage and Level edited.");
            driver.Close();
        }
        public void DeleteLanguageAndLevel(IWebDriver driver)
        {
            IWebElement DeleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[Last()]/tr/td[3]/span[2]"));
            DeleteIcon.Click();
            Thread.Sleep(2000);
        }
        public void DeletedLanguageAndLevel(IWebDriver driver)
        {
            Console.WriteLine("\n Language and Levle deleted successfully.");
            driver.Close();
        }
    }
}
