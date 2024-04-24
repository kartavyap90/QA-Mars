using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class ProfilePanelDashboardPage
    {
        public void ClickEditDropdown(IWebDriver driver)
        {
            IWebElement EditDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            EditDropdown.Click();
            Thread.Sleep(1000);
        }
        public void ClickedEditDropdown(IWebDriver driver)
        {
            Console.WriteLine("\n User clicked Edit Dropdown successfully.");
            Thread.Sleep(1000);
            driver.Close();
        }
        public void EditFirstAndLastName(IWebDriver driver, string FirstName, string LastName)
        {
            IWebElement EditDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            EditDropdown.Click();
            Thread.Sleep(1000);
            IWebElement FirstNameTextbox = driver.FindElement(By.Name("FirstName"));
            FirstNameTextbox.Click();
            Thread.Sleep(1000);
            FirstNameTextbox.Clear();
            FirstNameTextbox.SendKeys(FirstName);
            IWebElement LastNameTextbox = driver.FindElement(By.Name("LastName"));
            LastNameTextbox.Click();
            Thread.Sleep(1000);
            LastNameTextbox.Clear();
            LastNameTextbox.SendKeys(LastName);
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            SaveButton.Click();
            Thread.Sleep(1000);
        }
        public void EditedFirstAndLastName(IWebDriver driver, string FirstName, string LastName)
        {
            IWebElement EditDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            EditDropdown.Click();
            IWebElement FirstNameTextbox = driver.FindElement(By.Name("FirstName"));
            IWebElement LastNameTextbox = driver.FindElement(By.Name("LastName"));
            string f = FirstNameTextbox.GetAttribute("value");
            string l = LastNameTextbox.GetAttribute("value");
            string ParaFirst = FirstName;
            string ParaLast = LastName;
            if (f == ParaFirst && l == ParaLast)
            {

                Console.WriteLine("\n First and Last name edited successfully.");

            }
            else
            {
                Console.WriteLine("\n First and Last name not matched with parameter passed from feature file.");
            }
            driver.Close();
        }
        public void FirstAndLastNameAsBlank(IWebDriver driver)
        {
                Thread.Sleep(1000);
                IWebElement EditDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
                EditDropdown.Click();
                Thread.Sleep(1000);
                IWebElement FirstNameTextbox = driver.FindElement(By.Name("FirstName"));
                IWebElement LastNameTextbox = driver.FindElement(By.Name("LastName"));
                FirstNameTextbox.Click();
                FirstNameTextbox.Clear();
                Thread.Sleep(500);
                LastNameTextbox.Click() ;
                LastNameTextbox.Clear();
                Thread.Sleep(500);
                IWebElement SaveButton = driver.FindElement(By.XPath("//button[contains(text(),'Save')]"));
                SaveButton.Click();
                Thread.Sleep(1000);
        }
        public void ErrorMessageFirstAndLastNameAsBlank(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement EditDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            EditDropdown.Click();
            Thread.Sleep(1000);
            IWebElement FirstNameTextbox = driver.FindElement(By.Name("FirstName"));
            IWebElement LastNameTextbox = driver.FindElement(By.Name("LastName"));
            string f = FirstNameTextbox.GetAttribute("value");
            string l = LastNameTextbox.GetAttribute("value");
            if (string.IsNullOrWhiteSpace(f) && string.IsNullOrWhiteSpace(l))
            {
                Console.WriteLine("\n First and Last name are blank, User need to enter First and Last name.");
            }
            else
            {
                Console.WriteLine("\n First and Last name are not blank.");
            }
            driver.Close();
        }
        public void FirstAndLastNameAsWhiteSpace(IWebDriver driver, string First, string Last)
        {
            IWebElement EditDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            EditDropdown.Click();
            Thread.Sleep(1000);
            IWebElement FirstNameTextbox = driver.FindElement(By.Name("FirstName"));
            FirstNameTextbox.Click();
            FirstNameTextbox.Clear();
            FirstNameTextbox.SendKeys(First);
            Thread.Sleep(1000);
            IWebElement LastNameTextbox = driver.FindElement(By.Name("LastName"));
            LastNameTextbox.Click();
            LastNameTextbox.Clear();
            LastNameTextbox.SendKeys(Last);
            Thread.Sleep(1000);
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            SaveButton.Click();
            Thread.Sleep(1000);
        }
        public void ErrorMessageFirstAndLastNameAsWhiteSpace(IWebDriver driver, string First, string Last)
        {
            IWebElement EditDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            EditDropdown.Click();
            Thread.Sleep(1000);
            IWebElement FirstNameTextbox = driver.FindElement(By.Name("FirstName"));
            IWebElement LastNameTextbox = driver.FindElement(By.Name("LastName"));
            string f = FirstNameTextbox.GetAttribute("value");
            string l = LastNameTextbox.GetAttribute("value");
            string ParaFirst = First;
            string ParaLast = Last;
            if (f == ParaFirst && l == ParaLast)
            {

                Console.WriteLine("\n First and Last name has no value.");

            }
            else
            {
                Console.WriteLine("\n First and Last name has value");
            }
            Thread.Sleep(1000);
            driver.Close();
        }
        public void ClickEditIconOfAvailability(IWebDriver driver)
        {
            IWebElement EditIconAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            EditIconAvailability.Click();
            Thread.Sleep(1000);
        }
        public void ClickedEditIconOfAvailability(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on edit icon of availability.");
            driver.Close();
        }
        public void ClickCrossIconOfAvailability(IWebDriver driver)
        {
            IWebElement CrossIconAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            CrossIconAvailability.Click();
            Thread.Sleep(1000);
        }
        public void ClickedCrossIconOfAvailability(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on cross icon of availability.");
            driver.Close();
        }
        public void ChangeValueOfAvailability(IWebDriver driver)
        {
            IWebElement EditIconAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            EditIconAvailability.Click();
            Thread.Sleep(1000);
            IWebElement AvailabilityDropdown = driver.FindElement(By.Name("availabiltyType"));
            AvailabilityDropdown.Click();
            Thread.Sleep(1000);
            IWebElement SelectAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
            SelectAvailability.Click();
            Thread.Sleep(1000);
        }
        public void ChangedValueOfAvailability(IWebDriver driver)
        {
            Console.WriteLine("\n Availability valued changed.");
            driver.Close();
        }
        public void ClickEditIconOfHours(IWebDriver driver)
        {
            IWebElement EditIconHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            EditIconHours.Click();
            Thread.Sleep(1000);
        }
        public void ClickedEditIconOfHours(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on edit icon of hours.");
            driver.Close();
        }
        public void ClickCrossIconOfHours(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement CrossIconHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            CrossIconHours.Click();
            Thread.Sleep(1000);
        }
        public void ClickedCrossIconOfHours(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on cross icon of hours.");
            driver.Close();
        }
        public void ChangeValueOfHours(IWebDriver driver)
        {
            IWebElement EditIconHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            EditIconHours.Click();
            Thread.Sleep(1000);
            IWebElement HoursDropdown = driver.FindElement(By.Name("availabiltyHour"));
            HoursDropdown.Click();
            Thread.Sleep(1000);
            IWebElement SelectHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[4]"));
            SelectHours.Click();
            Thread.Sleep(1000);
        }
        public void ChangedValueOfHours(IWebDriver driver)
        {
            Console.WriteLine("\n Hours valued changed.");
            driver.Close();
        }
        public void ClickEditIconOfEarnTarget(IWebDriver driver)
        {
            IWebElement EditIconEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            EditIconEarnTarget.Click();
            Thread.Sleep(1000);
        }
        public void ClickedEditIconOfEarnTarget(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on edit icon of earntarget.");
            driver.Close();
        }
        public void ClickCrossIconOfEarnTarget(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement CrossIconEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            CrossIconEarnTarget.Click();
            Thread.Sleep(1000);
        }
        public void ClickedCrossIconOfEarnTarget(IWebDriver driver)
        {
            Console.WriteLine("\nUser clicked on cross icon of earn target.");
            driver.Close();
        }
        public void ChangeValueOfEarnTarget(IWebDriver driver)
        {
            IWebElement EditIconEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
            EditIconEarnTarget.Click();
            Thread.Sleep(1000);
            IWebElement EarnTargetDropdown = driver.FindElement(By.Name("availabiltyTarget"));
            EarnTargetDropdown.Click();
            Thread.Sleep(500);
            IWebElement SelectEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[4]"));
            SelectEarnTarget.Click();
            Thread.Sleep(1000);
        }
        public void ChangedValueOfEarnTarget(IWebDriver driver)
        {
            Console.WriteLine("\n Earntarget valued changed.");
            driver.Close();
        }
    }
}
