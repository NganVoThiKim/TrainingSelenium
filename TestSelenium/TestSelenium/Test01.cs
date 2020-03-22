using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace TestSelenium
{
    [TestFixture]
    class Test01
    {
        [Test]
        public void test()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--start-maximized");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");

            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://dmscoreqas.myanmar-brewery.com/dispatcher/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement cbxCompany;
            cbxCompany = driver.FindElement(By.CssSelector("select#sbo_company"));
            SelectElement DropdownOptions = new SelectElement(cbxCompany);
            DropdownOptions.SelectByValue("MBL");
            IWebElement user;
            user = driver.FindElement(By.CssSelector("input#sbo_user"));
            user.SendKeys("qc03");
            IWebElement pass;
            pass=driver.FindElement(By.CssSelector("input#sbo_password"));
            pass.SendKeys("123456");
            IWebElement btnLogOn;
            btnLogOn = driver.FindElement(By.CssSelector("input#logon_sbo_btn"));
            btnLogOn.Click();
            IWebElement btnClose;
            btnClose = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-2']]//button[@class='c1']"));
            btnClose.Click();
            IWebElement btnCancel;
            btnCancel = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-23']]//button[@class='c1320000002']"));
            btnCancel.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement btnCloseMess;
            btnCloseMess = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-14']]//span[@class='ui-button-icon ui-icon ui-icon-closethick']"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            btnCloseMess.Click();
            
            //IWebElement btnSearchMenu;
            //btnSearchMenu = driver.FindElement(By.CssSelector("button.c1320000021"));
            //btnSearchMenu.Click();

            IWebElement btnSearchMenu;
            btnSearchMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            btnSearchMenu.SendKeys(Keys.Control + Keys.F3);
            //IWebElement inputMenu;
            //inputMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            //inputMenu.SendKeys("EMD");
            btnSearchMenu.Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys("Employee Master Data");
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys(Keys.Enter);
            //Actions action = new Actions(driver);
            //action.MoveToElement(f).Perform(); // move to the button
            System.Threading.Thread.Sleep(2000);
            IWebElement txtFirstName;
            txtFirstName = driver.FindElement(By.CssSelector("input.c38"));
            txtFirstName.SendKeys("a");

            System.Threading.Thread.Sleep(2000);
            IWebElement btnFind;
            btnFind = driver.FindElement(By.CssSelector("button.c2"));
            btnFind.Click();

            System.Threading.Thread.Sleep(2000);
            IWebElement txtLastName;
            txtLastName = driver.FindElement(By.CssSelector("input.c37"));
            Console.WriteLine("Last Name = " + txtLastName.GetAttribute("title"));

            System.Threading.Thread.Sleep(2000);
            IWebElement cboPosition;          
            SelectElement select = new SelectElement(cboPosition = driver.FindElement(By.CssSelector("select.c44")));
            string a = select.SelectedOption.Text;
            Console.WriteLine("Position = " + a);
        }
        [Test]
        public void testTable()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--start-maximized");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");

            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://dmscoreqas.myanmar-brewery.com/dispatcher/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement cbxCompany;
            cbxCompany = driver.FindElement(By.CssSelector("select#sbo_company"));
            SelectElement DropdownOptions = new SelectElement(cbxCompany);
            DropdownOptions.SelectByValue("MBL");
            IWebElement user;
            user = driver.FindElement(By.CssSelector("input#sbo_user"));
            user.SendKeys("qc03");
            IWebElement pass;
            pass = driver.FindElement(By.CssSelector("input#sbo_password"));
            pass.SendKeys("123456");
            IWebElement btnLogOn;
            btnLogOn = driver.FindElement(By.CssSelector("input#logon_sbo_btn"));
            btnLogOn.Click();
            IWebElement btnClose;
            btnClose = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-2']]//button[@class='c1']"));
            btnClose.Click();
            IWebElement btnCancel;
            btnCancel = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-23']]//button[@class='c1320000002']"));
            btnCancel.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement btnCloseMess;
            btnCloseMess = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-14']]//span[@class='ui-button-icon ui-icon ui-icon-closethick']"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            btnCloseMess.Click();
            IWebElement btnSearchMenu;
            btnSearchMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            btnSearchMenu.SendKeys(Keys.Control + Keys.F3);
            btnSearchMenu.Click();
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys("Region");
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys(Keys.Enter);

            IEnumerable<IWebElement> listRow;
            listRow = driver.FindElements(By.CssSelector("div.slick-row"));
            foreach (var row in listRow)
            {
                var codeCell = row.FindElement(By.CssSelector("div.l1>div"));
                string codeValue = codeCell.Text;
                Console.WriteLine(codeValue);
            }

            //Actions action = new Actions(driver);
            //action.ClickAndHold().Release();
            //action.DoubleClick().Build().Perform();
        }

        public void testRegion()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--start-maximized");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");

            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://dmscoreqas.myanmar-brewery.com/dispatcher/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement cbxCompany;
            cbxCompany = driver.FindElement(By.CssSelector("select#sbo_company"));
            SelectElement DropdownOptions = new SelectElement(cbxCompany);
            DropdownOptions.SelectByValue("MBL");
            IWebElement user;
            user = driver.FindElement(By.CssSelector("input#sbo_user"));
            user.SendKeys("qc03");
            IWebElement pass;
            pass = driver.FindElement(By.CssSelector("input#sbo_password"));
            pass.SendKeys("123456");
            IWebElement btnLogOn;
            btnLogOn = driver.FindElement(By.CssSelector("input#logon_sbo_btn"));
            btnLogOn.Click();
            IWebElement btnClose;
            System.Threading.Thread.Sleep(5000);
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
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            btnSearchMenu.SendKeys(Keys.Control + Keys.F3);
            btnSearchMenu.Click();
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys("Region");
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys(Keys.Enter);

            var listRow = driver.FindElements(By.CssSelector("div.slick-row"));
            bool isExistBAGO = false, isExistVN = false;
            int indexRow = 1;
            foreach (var row in listRow)
            {               
                var cellName = row.FindElement(By.CssSelector("div>div.l2"));
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("Name:" + cellName.Text);
                var cellCountry = row.FindElement(By.CssSelector("div>div.l3"));
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("Country:" + cellCountry.Text);
                var cellCode = row.FindElement(By.CssSelector("div>div.l1"));
                System.Threading.Thread.Sleep(2000);

                switch (cellCode.Text)
                {
                    case "BAGO":
                        isExistBAGO = true;
                        Actions action = new Actions(driver);
                        action.DoubleClick(driver.FindElement(By.CssSelector("div.row_2>div.r1"))).Build().Perform();
                        System.Threading.Thread.Sleep(2000);
                        //var valueCodeField = driver.FindElement(By.CssSelector("input[Class = 'cedCode']"));
                        //Console.WriteLine("Value of Code field:" + valueCodeField.Text);
                        System.Threading.Thread.Sleep(2000);

                        action = new Actions(driver);
                        var firstcell = driver.FindElement(By.CssSelector("div.row_2>div.r0"));
                        action.ContextClick(firstcell).Build().Perform();

                        action = new Actions(driver);
                        //action.ContextClick(driver.FindElement(By.CssSelector("div.row_2>div.r0"))).Build().Perform();
                        System.Threading.Thread.Sleep(2000);
                        //var removeItem = 
                        action.Click(driver.FindElement(By.XPath("//div[@id='ctxmenu']//a[text()='Remove']"))).Build().Perform();
                        break;
                    case "VN":
                        isExistVN = true;
                        break;
                    case "SHAN":
                        Console.WriteLine("IndexRow = {0}", indexRow);
                        break;
                    default:
                        break;
                }
                indexRow++;
            }

            //if(isExistBAGO)
            //{
            //    Console.WriteLine("BAGO is exist");

            //}
            if (isExistVN)
            {
                Console.WriteLine("VN is exist");
            }
            else
            {
                Console.WriteLine("VN is Not exist");
            }
        }
        [Test]
        public void TestWait()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--start-maximized");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");

            IWebDriver driver = new ChromeDriver(options);
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

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
            //////////Use Explicit with Visible 
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class = 'loader-container']//div[@class = 'cssload-square small']")));

            //////////Use Explicit with Invisible
            ///wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class = 'loader-container']//div[@class = 'cssload-square small']")));

            IWebElement btnClose;
            System.Threading.Thread.Sleep(10000);
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
            //IWebElement btnSearchMenu;
            //System.Threading.Thread.Sleep(2000);
            //btnSearchMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            //btnSearchMenu.SendKeys(Keys.Control + Keys.F3);
            //btnSearchMenu.Click();
            //System.Threading.Thread.Sleep(2000);
            //btnSearchMenu.SendKeys("Region");
            //System.Threading.Thread.Sleep(2000);
            //btnSearchMenu.SendKeys(Keys.Enter);

            
            
            IWebElement btnSearchMenu;
            btnSearchMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            btnSearchMenu.SendKeys(Keys.Control + Keys.F3);
            btnSearchMenu.Click();
            ///////Use ImplicitWait with not set, 0s, 1s, 10s, 50s
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(0);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(10);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(50);
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            //wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("input.c1170000007")));
            btnSearchMenu.SendKeys("Employee Master Data");
            //System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys(Keys.Enter);

            ///////// Syntax of Explicit
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(_By(locator)));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@class = 'loader-container']//div[@class = 'cssload-square small']")));

        }
        [Test]
        public void UploadFile()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--disable-extensions");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--start-maximized");
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");

            IWebDriver driver = new ChromeDriver(options);
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
            IWebElement btnClose;
            System.Threading.Thread.Sleep(5000);
            btnClose = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-2']]//button[@class='c1']"));
            btnClose.Click();
            IWebElement btnCancel;
            System.Threading.Thread.Sleep(5000);
            btnCancel = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-23']]//button[@class='c1320000002']"));
            btnCancel.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement btnCloseMess;
            System.Threading.Thread.Sleep(2000);
            btnCloseMess = driver.FindElement(By.XPath("//div[div/span[@id='ui-id-14']]//span[@class='ui-button-icon ui-icon ui-icon-closethick']"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            btnCloseMess.Click();
            IWebElement btnSearchMenu;
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu = driver.FindElement(By.CssSelector("input.c1170000007"));
            btnSearchMenu.SendKeys(Keys.Control + Keys.F3);
            btnSearchMenu.Click();
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys("Region");
            System.Threading.Thread.Sleep(2000);
            btnSearchMenu.SendKeys(Keys.Enter);
            
            AutoItX3 autoIT = new AutoItX3();
            IWebElement btnImport;
            btnImport = driver.FindElement(By.XPath("//div[div/span[text()='Region']]//button[@class='cbtImport']"));
            btnImport.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement btnChooseFilePath;
            btnChooseFilePath = driver.FindElement(By.XPath("//div[div/span[text()='Import & Export']]//button[@id='UDMSpro000002__btChoose']"));
            btnChooseFilePath.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement btnChooseFile;
            btnChooseFile = driver.FindElement(By.XPath("//div[div/span[text()='Upload File']]//button[@id='_tmpForm__1']"));
            btnChooseFile.Click();
            System.Threading.Thread.Sleep(5000);
            var windowName = "";
            if (driver.ToString().Contains("chrome"))
                windowName = "Open";
            autoIT.WinActivate(windowName);
            System.Threading.Thread.Sleep(2000);
            autoIT.Send("Downloads\\RegionTemplate");
            System.Threading.Thread.Sleep(2000);
            autoIT.Send("{ENTER}");
            IWebElement btnImportFileExcel;
            btnImportFileExcel = driver.FindElement(By.XPath("//div[div/span[text()='Import & Export']]//button[@id='UDMSpro000002__btImport']"));
            btnImportFileExcel.Click();

            ///////Syntax
            //AutoItX3 autoIT = new AutoItX3();
            //var windowName = "File Upload";
            //if (driver.ToString().Contains("chrome"))
            //    windowName = "Open";
            //autoIT.WinActivate(windowName);
            //autoIT.Send(_value);
            //staticWait(1);
            //autoIT.Send("{ENTER}");
            //

        }
    }
}
