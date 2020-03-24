using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestcaseStepByStep
{
    public class LoginPage
    {       
        public ChromeOptions options;
        public IWebDriver driver;
        
        [Test]
        public void Login_to_DMSpro()
        {
            options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--start-maximized");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");

            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://dmscoreqas.myanmar-brewery.com/dispatcher/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement cbxCompany;
            cbxCompany = driver.FindElement(By.CssSelector("select#sbo_company"));
            SelectElement DropdownOptions = new SelectElement(cbxCompany);
            DropdownOptions.SelectByValue("MBL");
            IWebElement user;
            user = driver.FindElement(By.CssSelector("input#sbo_user"));
            user.SendKeys("qc07");
            IWebElement pass;
            pass = driver.FindElement(By.CssSelector("input#sbo_password"));
            pass.SendKeys("123456");
            IWebElement btnLogOn;
            btnLogOn = driver.FindElement(By.CssSelector("input#logon_sbo_btn"));
            btnLogOn.Click();
        }
    }
}
