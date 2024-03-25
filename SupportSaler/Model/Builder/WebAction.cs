using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using SupportSaler.Model.Abstractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSaler.Model.Builder
{
    public class WebAction
    {
        private List<IWebAction> _parts = new List<IWebAction>();

        public void Add(IWebAction webaction)
        {
            this._parts.Add(webaction);
        }

        public string ListParts(string profile)
        {
            IWebDriver driver = CreateWebDriver(profile, "Microsoft Edge");
            string str = string.Empty;

            str += this._parts[0].DoWebAction(driver) + Environment.NewLine;

            if (str == "Login Account Completed")
            {
                for (int i = 1; i < this._parts.Count - 1; i++)
                {
                    str += this._parts[i].DoWebAction(driver) + Environment.NewLine;
                }

                str += this._parts[this._parts.Count - 1].DoWebAction(driver) + Environment.NewLine;
            }
            return "Product parts: " + Environment.NewLine + str;
        }

        private IWebDriver CreateWebDriver(string profile, string type)
        {
            IWebDriver driver;
            switch(type)
            {
                case "Microsoft Edge":
                    EdgeDriverService edgeservice = EdgeDriverService.CreateDefaultService();
                    edgeservice.HideCommandPromptWindow = true;
                    EdgeOptions edgeoptions = new EdgeOptions();
                    edgeoptions.AddAdditionalEdgeOption("useAutomationExtension", false);
                    edgeoptions.AddExcludedArgument("enable-automation");
                    /*
                    Proxy proxy = new Proxy();
                    proxy.Kind = ProxyKind.Manual;
                    proxy.IsAutoDetect = false;
                    //proxy.HttpProxy = $"http://{ip}";
                    //proxy.SslProxy = ip;
                    edgeoptions.Proxy = proxy;
                    */
                    edgeoptions.AddArgument("ignore-certificate-errors");
                    edgeoptions.AddArgument("user-data-dir=D:\\Project\\FacebookAPI\\Account1");
                    driver = new EdgeDriver(edgeservice, edgeoptions);
                    driver.Url = ("https://www.facebook.com//");
                    driver.Navigate();
                    return driver;
                case "Google Chrome":
                    ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                    chromeDriverService.HideCommandPromptWindow = true;
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddAdditionalChromeOption("useAutomationExtension", false);
                    chromeOptions.AddExcludedArgument("enable-automation");
                    /*
                    Proxy proxy = new Proxy();
                    proxy.Kind = ProxyKind.Manual;
                    proxy.IsAutoDetect = false;
                    //proxy.HttpProxy = $"http://{ip}";
                    //proxy.SslProxy = ip;
                    chromeOptions.Proxy = proxy;
                    */
                    chromeOptions.AddArgument("ignore-certificate-errors");
                    chromeOptions.AddArgument("user-data-dir=D:\\Project\\FacebookAPI\\Account1");
                    driver = new ChromeDriver(chromeDriverService, chromeOptions);
                    driver.Url = ("https://www.facebook.com//");
                    driver.Navigate();
                    return driver;
                default:
                    ChromeDriverService defaultDriverService = ChromeDriverService.CreateDefaultService();
                    defaultDriverService.HideCommandPromptWindow = true;
                    ChromeOptions defaultOptions = new ChromeOptions();
                    defaultOptions.AddAdditionalChromeOption("useAutomationExtension", false);
                    defaultOptions.AddExcludedArgument("enable-automation");
                    /*
                    Proxy proxy = new Proxy();
                    proxy.Kind = ProxyKind.Manual;
                    proxy.IsAutoDetect = false;
                    //proxy.HttpProxy = $"http://{ip}";
                    //proxy.SslProxy = ip;
                    defaultOptions.Proxy = proxy;
                    */
                    defaultOptions.AddArgument("ignore-certificate-errors");
                    defaultOptions.AddArgument("user-data-dir=D:\\Project\\FacebookAPI\\Account1");
                    driver = new ChromeDriver(defaultDriverService, defaultOptions);
                    driver.Url = ("https://www.facebook.com//");
                    driver.Navigate();
                    return driver;
            }
        }
    }
}
