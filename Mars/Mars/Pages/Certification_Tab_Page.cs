using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    public class CertificationTabPage
    {
        public void ClickCertificationTab(IWebDriver driver)
        {
            IWebElement ClickCertificationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            ClickCertificationTab.Click();
            Thread.Sleep(1000);
        }
        public void ClickedCertificationTab(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked on certification tab.");
            driver.Close();
        }
        public void ClickAddNewButtonCertification(IWebDriver driver)
        {
            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            AddNewButton.Click();
            Thread.Sleep(1000);
        }
        public void ClickedAddNewButtonCertification(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Add New button in certification tab.");
            driver.Close();
        }
        public void ClickAddButtonWithoutCertificationDetails(IWebDriver driver)
        {
            IWebElement AddButtoncertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            AddButtoncertification.Click();
            Thread.Sleep(2000);
        }
        public void ClickedAddButtonWithoutCertificationDetails(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Add button without certification details and received an error.");
            driver.Close();
        }

        public void ClickCancelButtonCertification(IWebDriver driver)
        {
            IWebElement cancelbuttoncertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[2]"));
            cancelbuttoncertification.Click();
            Thread.Sleep(2000);
        }
        public void Clickedcancelbuttoncertification(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully clicked Cancel button in certification tab.");
            driver.Close();
        }
        public void EnterCertificationDetails(IWebDriver driver, string certificateawardname, string certificationfromname)
        {
            IWebElement certificateawardnametextbox = driver.FindElement(By.Name("certificationName"));
            certificateawardnametextbox.Click();
            certificateawardnametextbox.Clear();
            certificateawardnametextbox.SendKeys(certificateawardname);
            Thread.Sleep(1000);

            IWebElement certificationfromtextbox = driver.FindElement(By.Name("certificationFrom"));
            certificationfromtextbox.Click();
            certificationfromtextbox.Clear();
            certificationfromtextbox.SendKeys(certificationfromname);
            Thread.Sleep(1000);

            IWebElement certificateyearDropdown = driver.FindElement(By.Name("certificationYear"));
            certificateyearDropdown.Click();
            IWebElement selectcertificateyear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[5]"));
            selectcertificateyear.Click();
            Thread.Sleep(1000);

            IWebElement AddButtoncertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            AddButtoncertification.Click();
            Thread.Sleep(1000);
        }
        public void EnteredCertificationDetails(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully entered certification details in certification tab.");
            driver.Close();
        }
        public void EditCertificationDetails(IWebDriver driver, string newcertificateawardname, string newcertificationfromname)
        {
            IWebElement editiconcertifications = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[Last()]/tr/td[4]/span[1]/i"));
            editiconcertifications.Click();
            Thread.Sleep(1000);

            IWebElement certificateawardnametextbox = driver.FindElement(By.Name("certificationName"));
            certificateawardnametextbox.Click();
            certificateawardnametextbox.Clear();
            certificateawardnametextbox.SendKeys(newcertificateawardname);
            Thread.Sleep(1000);

            IWebElement certificationfromtextbox = driver.FindElement(By.Name("certificationFrom"));
            certificationfromtextbox.Click();
            certificationfromtextbox.Clear();
            certificationfromtextbox.SendKeys(newcertificationfromname);
            Thread.Sleep(1000);

            IWebElement certificateyearDropdown = driver.FindElement(By.Name("certificationYear"));
            certificateyearDropdown.Click();
            IWebElement selectcertificateyear = driver.FindElement(By.XPath("//option[contains(text(),'2021')]")); //relative xpath with text function
            selectcertificateyear.Click();
            Thread.Sleep(1000);

            IWebElement UpdateButtoncertification = driver.FindElement(By.XPath("//input[@value='Update']")); //relative xpath
            Thread.Sleep(1000); 
            UpdateButtoncertification.Click();
        }
        public void EditedCertificationDetails(IWebDriver driver)
        {
            Console.WriteLine("\n User successfully edited certification details.");
            driver.Close();
        }
        public void ClickCrossIconCertification(IWebDriver driver)
        {
            IWebElement CrossIconEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[Last()]/tr/td[4]/span[2]/i"));
            CrossIconEducation.Click();
            Thread.Sleep(2000);
        }
        public void ClickedCrossIconCertification(IWebDriver driver)
        {
            Console.WriteLine("\n Certification details successfully deleted by the user.");
            driver.Close();
        }
    }
}
