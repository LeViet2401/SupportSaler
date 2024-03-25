using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSaler.Model.Abstractor
{
    public interface IWebAction
    {
        public string DoWebAction(IWebDriver driver);
    }
}
