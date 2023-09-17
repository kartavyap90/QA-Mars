using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class Description_Tab_Page
    {
        public void Click_Edit_Icon_Of_Description(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement pencil_icon_description = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            pencil_icon_description.Click();
            Thread.Sleep(1000);
        }
        public void Clicked_Edit_Icon_Of_Description(IWebDriver driver)
        {
            Console.WriteLine("\n Edit icon clicked by user.");
            driver.Close();
        }
        public void Error_Entering_Description_Without_Digit_Or_Letter(IWebDriver driver)
        {
            IWebElement description_value = driver.FindElement(By.Name("value"));
            description_value.Click();
            description_value.Clear();
            description_value.SendKeys(" This is a sample description.");
            Thread.Sleep(1000);
            IWebElement save_button_description = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            save_button_description.Click();
            Thread.Sleep(2000);
        }
        public void Received_Error_Entering_Description_Without_Digit_Or_Letter(IWebDriver driver)
        {
            Console.WriteLine("\n User received error while without entering first character as letter or digit in description box.");
            driver.Close();
        }
        public void Enter_Description(IWebDriver driver)
        {
            IWebElement description_value = driver.FindElement(By.Name("value"));
            description_value.Click();
            description_value.Clear();
            description_value.SendKeys("This is a sample description.");
            IWebElement save_button_description = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            save_button_description.Click();
        }
        public void Entered_Description(IWebDriver driver)
        {
            Console.WriteLine("\n Description added successfully by the user.");
            driver.Close();
        }
    }
}
