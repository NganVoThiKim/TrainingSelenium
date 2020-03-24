using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestcaseStepByStep
{
    
    public class TestCase
    {
        [Test]
        public void TC1()
        {
            var login = new LoginPage();
            login.Login_to_DMSpro();
             var homePage = new HomePage();
            homePage.Open_dialog_with_name();
            var regionPage = new RegionPage();
            regionPage.Check_something();
        }
    }
}
