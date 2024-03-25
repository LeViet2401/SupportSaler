using OpenQA.Selenium;
using SupportSaler.Model.Abstractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSaler.Model.Builder
{
    public class Comment : IWebAction
    {
        public string DoWebAction(IWebDriver driver)
        {
            return "Comment Completed";
        }
    }
}
