﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestcaseStepByStep
{
    class RegionPage:LoginPage
    {
        public void Check_something()
        {

            IWebElement btnSearchMenu;
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("input.c1170000007")));
            btnSearchMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            btnSearchMenu.SendKeys("Region");
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys(Keys.Enter);
        }
    }
}