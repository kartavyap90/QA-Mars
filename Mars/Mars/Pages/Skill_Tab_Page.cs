using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class SkillTabPage
    {
        public void AddSkill(IWebDriver driver, string Skill)
        {
            IWebElement SkillLabel = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            SkillLabel.Click();
            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
            Thread.Sleep(1000);
            IWebElement SkillTextbox = driver.FindElement(By.Name("name"));
            SkillTextbox.Click();
            SkillTextbox.SendKeys(Skill);
            Thread.Sleep(1000);
            IWebElement SkillDropdown = driver.FindElement(By.Name("level"));
            SkillDropdown.Click();
            Thread.Sleep(1000);
            IWebElement SkillLevelSelection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
            SkillLevelSelection.Click();
            Thread.Sleep(1000);
            IWebElement Addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            Addbutton.Click();
        }
        public void SkillAdded(IWebDriver driver, string Skill)
        {
            Thread.Sleep(1000);
            IWebElement AddedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[Last()]/tr/td[1]"));
            string PortalSkill = AddedSkill.Text;
            //Console.WriteLine("Value from portal: " + PortalSkill);
            string ParaSkill = Skill;
            if (ParaSkill == PortalSkill)
            {
                Console.WriteLine("\nSkill Added at Last successfully: " + PortalSkill);
            }
            else
            {
                Console.WriteLine("\nSkill was not Added successfully.");
            }
            driver.Close();
        }
        public void AddSkillwithoutData(IWebDriver driver)
        {
            IWebElement SkillLabel = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            SkillLabel.Click();
            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
            IWebElement SkillTextbox = driver.FindElement(By.Name("name"));
            SkillTextbox.SendKeys("");
            Thread.Sleep(1000);
            IWebElement SkillDropdown = driver.FindElement(By.Name("level"));
            SkillDropdown.Click();
            Thread.Sleep(1000);
            IWebElement NoSkillLevelSelection = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[1]"));
            NoSkillLevelSelection.Click();
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButton.Click();
            Thread.Sleep(1000);
        }
        public void ErrorMessageForAddSkillwithoutData(IWebDriver driver)
        {
            Console.WriteLine("\nNo Skill Added in list beacuse no data entered.");
            driver.Close();
        }
        public void EditSkillAndLevel(IWebDriver driver, string newSkill)
        {
            Thread.Sleep(1000);
            IWebElement SkillLabel = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            SkillLabel.Click();
            Thread.Sleep(1000);
            IWebElement EditButton = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            EditButton.Click();
            Thread.Sleep(1000);
            IWebElement NameSkillTextbox = driver.FindElement(By.Name("name"));
            NameSkillTextbox.Click(); NameSkillTextbox.Clear();
            NameSkillTextbox.SendKeys(newSkill);
            Thread.Sleep(1000);
            IWebElement NewSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));//relative xpath
            NewSkillLevelDropdown.Click();
            Thread.Sleep(1000);
            IWebElement SelectNewSkillLevel = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
            SelectNewSkillLevel.Click();
            Thread.Sleep(1000);
            IWebElement UpdateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateButton.Click();
            Thread.Sleep(1000);
        }
        public void EditedSkillAndLevel(IWebDriver driver)
        {
            Console.WriteLine("\nSkill and Level edited.");
            driver.Close();
        }
        public void DeleteSkillAndLevel(IWebDriver driver)
        {

            IWebElement SkillLabel = driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div/a[2]"));
            SkillLabel.Click();
            Thread.Sleep(1000);
            IWebElement DeleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[Last()]/tr/td[3]/span[2]/i"));
            DeleteIcon.Click();
            Thread.Sleep(1000);
        }
        public void DeletedSkillAndLevel(IWebDriver driver)
        {
            Console.WriteLine("\n Skill and Levle deleted successfully.");
            driver.Close();
        }
    }
}
