using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestcaseStepByStep
{
    public class Locator
    {
        //Login page
        public const string COMPANY_DROPDOWN = "select#sbo_company";

        public const string USER_TEXTBOX = "input#sbo_user";
        public const string PASSWORD_TEXTBOX = "input#sbo_password";
        public const string LOGIN_BUTTON = "input#logon_sbo_btn";
        //Home page
        public const string WARNING_CLOSE_BUTTON = "//div[div/span[@id='ui-id-2']]//button[@class='c1']";
        public const string SELECTBRANCH_CANCEL_BUTTON = "//div[div/span[@id='ui-id-23']]//button[@class='c1320000002']";
        public const string MESSAGELOG_CLOSE_BUTTON = "//div[div/span[@id='ui-id-14']]//span[@class='ui-button-icon ui-icon ui-icon-closethick']";
        public const string SEARCHMENU_TEXTBOX = "input.c1170000007";
    }
}
