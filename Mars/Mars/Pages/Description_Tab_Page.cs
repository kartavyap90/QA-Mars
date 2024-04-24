using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class DescriptionTabPage
    {
        public void ClickEditIconOfDescription(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement pencilicondescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            pencilicondescription.Click();
            Thread.Sleep(1000);
        }
        public void ClickedEditIconOfDescription(IWebDriver driver)
        {
            Console.WriteLine("\n Edit icon clicked by user.");
            driver.Close();
        }
        public void ErrorEnteringDescriptionWithoutDigitOrLetter(IWebDriver driver)
        {
            IWebElement descriptionvalue = driver.FindElement(By.Name("value"));
            descriptionvalue.Click();
            descriptionvalue.Clear();
            descriptionvalue.SendKeys(" Entering description with First character as white space..");
            Thread.Sleep(1000);
            IWebElement SaveButtondescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            SaveButtondescription.Click();
            Thread.Sleep(2000);
        }
        public void ReceivedErrorEnteringDescriptionWithoutDigitOrLetter(IWebDriver driver)
        {
            Console.WriteLine("\n User received error while without entering First character as letter or digit in description box.");
            driver.Close();
        }
        public void EnterDescription(IWebDriver driver)
        {
            IWebElement descriptionvalue = driver.FindElement(By.Name("value"));
            descriptionvalue.Click();
            descriptionvalue.Clear();
            Thread.Sleep(1000);
            descriptionvalue.SendKeys("This is a sample description.");
            Thread.Sleep(1000);
            IWebElement SaveButtondescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            SaveButtondescription.Click();
            Thread.Sleep(1000);
        }
        public void EnteredDescription(IWebDriver driver)
        {
            Console.WriteLine("\n Description Added successfully by the user.");
            driver.Close();
        }
    }
}
