using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestcaseStepByStep
{
    class HomePage
    {
        public void Open_dialog_with_name(IWebDriver _driver)
        {
            //ChromeOptions options = new ChromeOptions();
            //IWeb_driver _driver = new Chrome_driver(options);
            //_driver.Navigate().GoToUrl("https://dmscoreqas.myanmar-brewery.com/dispatcher/");
            //System.Threading.Thread.Sleep(10000);
            IWebElement btnClose;
            btnClose = _driver.FindElement(By.XPath("//div[div/span[@id='ui-id-2']]//button[@class='c1']"));
            btnClose.Click();
            IWebElement btnCancel;
            System.Threading.Thread.Sleep(2000);
            btnCancel = _driver.FindElement(By.XPath("//div[div/span[@id='ui-id-23']]//button[@class='c1320000002']"));
            btnCancel.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement btnCloseMess;
            System.Threading.Thread.Sleep(2000);
            btnCloseMess = _driver.FindElement(By.XPath("//div[div/span[@id='ui-id-14']]//span[@class='ui-button-icon ui-icon ui-icon-closethick']"));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            btnCloseMess.Click();

            IWebElement btnSearchMenu;
            btnSearchMenu = _driver.FindElement(By.CssSelector("input.c1170000007"));
            btnSearchMenu.SendKeys(Keys.Control + Keys.F3);
            btnSearchMenu.Click();
        }
    }
}
