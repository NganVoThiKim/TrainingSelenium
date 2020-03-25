using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestcaseStepByStep
{
    public class CommonMethod
    {
        public void SelectValueOfDropdown(SelectElement dropdownOptions, string value)
        {
            dropdownOptions.SelectByValue(value);
        }
        public void SendKeys(IWebElement element, string text)
        {
            System.Threading.Thread.Sleep(2000);
            element.SendKeys(text);
        }
        public void ClickOnButton(IWebElement element)
        {
            element.Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
