using SupportSaler.Model.Abstractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Collections.ObjectModel;
using System.Windows.Media.Effects;
using Microsoft.VisualBasic.FileIO;

namespace SupportSaler.Model.Builder
{
    public class LoginAccount : IWebAction
    {
        private MyAccount myAccount;

        public LoginAccount(MyAccount myAccount)
        {
            this.myAccount = myAccount;
        }

        public string DoWebAction(IWebDriver driver)
        {
            try
            {


            }
            catch
            { 

            }

            return "Login Account Completed";
        }
    }
}
