using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class EducationTabPage
    {
        public void ClickEducationTab(IWebDriver driver)
        {
            IWebElement ClickEducationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            ClickEducationTab.Click();
            Thread.Sleep(1000);
        }
        public void ClickedEducationTab(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked on education tab.");
            driver.Close();
        }
        public void ClickAddNewButtonEducation(IWebDriver driver)
        {
            IWebElement EducationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            EducationTab.Click();
            Thread.Sleep(1000);
            IWebElement AddNewButtonEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            AddNewButtonEducation.Click();
            Thread.Sleep(1000);
        }
        public void ClickedAddNewButtonEducation(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Add New button in education tab.");
            driver.Close();
        }
        public void ClickAddButtonWithoutEducationDetails(IWebDriver driver)
        {
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(1000);
        }
        public void ClickedAddButtonWithoutEducationDetails(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Add button without education details and received an error.");
            driver.Close();
        }
        public void ClickCancelButtonEducation(IWebDriver driver)
        {
            IWebElement CancelButtonEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[2]"));
            CancelButtonEducation.Click();
            Thread.Sleep(1000);
        }
        public void ClickedCancelButtonEducation(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Cancel button in education tab.");
            driver.Close();
        }
        public void EnterEducationDetails(IWebDriver driver, string collegeuniversityname, string degreename)
        {
            IWebElement CollegeUniversityTextbox = driver.FindElement(By.Name("instituteName"));
            CollegeUniversityTextbox.Click();
            CollegeUniversityTextbox.Clear();
            CollegeUniversityTextbox.SendKeys(collegeuniversityname);
            Thread.Sleep(1000);

            IWebElement CountryCollegeUniversityDropdown = driver.FindElement(By.Name("country"));
            CountryCollegeUniversityDropdown.Click();
            IWebElement SelectCountryCollegeUniversityDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            SelectCountryCollegeUniversityDropdown.Click();
            Thread.Sleep(1000);

            IWebElement TitleDropdown = driver.FindElement(By.Name("title"));
            TitleDropdown.Click();
            IWebElement SelectTitleDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[11]"));
            SelectTitleDropdown.Click();
            Thread.Sleep(1000);

            IWebElement DegreeTextbox = driver.FindElement(By.Name("degree"));
            DegreeTextbox.Click();
            DegreeTextbox.Clear();
            DegreeTextbox.SendKeys(degreename);
            Thread.Sleep(1000);

            IWebElement GraduationDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            GraduationDropdown.Click();
            IWebElement SelectGraduationDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[2]"));
            SelectGraduationDropdown.Click();
            Thread.Sleep(1000);

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            Thread.Sleep(1000);
        }
        public void EnteredEducationDetails(IWebDriver driver)
        {
            Console.WriteLine("\n Education Details successfully entered by the user.");
            driver.Close();
        }
        public void EditEducationDetails(IWebDriver driver, string collegeuniversityname, string degreename)
        {
            Thread.Sleep(1000);
            IWebElement EditiconEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[Last()]/tr/td[6]/span[1]/i"));
            EditiconEducation.Click();
            Thread.Sleep(1000);




            IWebElement CollegeUniversityTextbox = driver.FindElement(By.XPath("//input[@name='instituteName']"));
            CollegeUniversityTextbox.Click();
            CollegeUniversityTextbox.Clear();
            CollegeUniversityTextbox.SendKeys(collegeuniversityname);
            Thread.Sleep(1000);

            IWebElement CountryCollegeUniversityDropdown = driver.FindElement(By.XPath("//select[@name='country']"));
            CountryCollegeUniversityDropdown.Click();
            Thread.Sleep(1000);
            IWebElement SelectCountryCollegeUniversityDropdown = driver.FindElement(By.XPath("//option[contains(text(),'Australia')]"));
            SelectCountryCollegeUniversityDropdown.Click();
            Thread.Sleep(1000);

            IWebElement TitleDropdown = driver.FindElement(By.XPath("//select[@name='title']"));
            TitleDropdown.Click();
            Thread.Sleep(1000);
            IWebElement SelectTitleDropdown = driver.FindElement(By.XPath("//option[contains(text(),'BFA')]"));
            SelectTitleDropdown.Click();
            Thread.Sleep(1000);

            IWebElement DegreeTextbox = driver.FindElement(By.Name("degree"));
            DegreeTextbox.Click();
            DegreeTextbox.Clear();
            DegreeTextbox.SendKeys(degreename);
            Thread.Sleep(1000);

            IWebElement GraduationDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            GraduationDropdown.Click();
            IWebElement SelectGraduationDropdown = driver.FindElement(By.XPath("//option[contains(text(),'2020')]"));
            SelectGraduationDropdown.Click();
            Thread.Sleep(1000);

            IWebElement AddButton = driver.FindElement(By.XPath("//input[@value='Update']")); //relative xpath
            AddButton.Click();
            Thread.Sleep(2000);
        }
        public void EditedEducationDetails(IWebDriver driver)
        {
            Console.WriteLine("\n Education Details successfully edited by the user.");
            driver.Close();
        }
        public void ClickCrossIconEducation(IWebDriver driver)
        {
            IWebElement CrossIconEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[Last()]/tr/td[6]/span[2]/i"));
            CrossIconEducation.Click();
            Thread.Sleep(1000);
        }
        public void ClickedCrossIconEducation(IWebDriver driver)
        {
            Console.WriteLine("\n Education Details successfully deleted by the user.");
            driver.Close();
        }
    }
}
