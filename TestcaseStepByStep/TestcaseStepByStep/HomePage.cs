using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestcaseStepByStep
{
    class HomePage : LoginPage
    {
        public void Open_dialog_with_name()
        {           
            ChromeOptions options = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(options);
            System.Threading.Thread.Sleep(10000);
            IWebElement btnClose;
            btnClose = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-2']]//button[@class='c1']"));
            btnClose.Click();
            IWebElement btnCancel;
            System.Threading.Thread.Sleep(2000);
            btnCancel = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-23']]//button[@class='c1320000002']"));
            btnCancel.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement btnCloseMess;
            System.Threading.Thread.Sleep(2000);
            btnCloseMess = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-14']]//span[@class='ui-button-icon ui-icon ui-icon-closethick']"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            btnCloseMess.Click();

            IWebElement btnSearchMenu;
            btnSearchMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            btnSearchMenu.SendKeys(Keys.Control + Keys.F3);
            btnSearchMenu.Click();
        }
    }
}
