using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestcaseStepByStep
{
    class HomePage:CommonMethod
    {
        public void Open_dialog_with_name(IWebDriver _driver)
        {
            //ChromeOptions options = new ChromeOptions();
            //IWeb_driver _driver = new Chrome_driver(options);
            //_driver.Navigate().GoToUrl("https://dmscoreqas.myanmar-brewery.com/dispatcher/");
            //System.Threading.Thread.Sleep(10000);
            IWebElement btnCloseWarning;
            btnCloseWarning = _driver.FindElement(By.XPath(Locator.WARNING_CLOSE_BUTTON));
            //btnCloseWarning.Click();
            ClickOnButton(btnCloseWarning);
            IWebElement btnCancelSelectBranch;
            System.Threading.Thread.Sleep(2000);
            btnCancelSelectBranch = _driver.FindElement(By.XPath(Locator.SELECTBRANCH_CANCEL_BUTTON));
            //btnCancelSelectBranch.Click();
            ClickOnButton(btnCancelSelectBranch);
            //System.Threading.Thread.Sleep(2000);
            IWebElement btnCloseMess;
            System.Threading.Thread.Sleep(2000);
            btnCloseMess = _driver.FindElement(By.XPath(Locator.MESSAGELOG_CLOSE_BUTTON));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //btnCloseMess.Click();
            ClickOnButton(btnCloseMess);
            IWebElement txtSearchMenu;
            txtSearchMenu = _driver.FindElement(By.CssSelector(Locator.SEARCHMENU_TEXTBOX));
            //txtSearchMenu.SendKeys(Keys.Control + Keys.F3);
            SendKeys(txtSearchMenu, Keys.Control + Keys.F3);
            //txtSearchMenu.Click();
            ClickOnButton(txtSearchMenu);
        }
    }
}
