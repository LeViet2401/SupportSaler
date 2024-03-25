using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SupportSaler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ip = "72.10.160.173:28947";
            EdgeDriverService service = EdgeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            EdgeOptions options = new EdgeOptions();
            Proxy proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.HttpProxy = $"http://{ip}";
            proxy.SslProxy = ip;
            options.Proxy = proxy;
            options.AddArgument("ignore-certificate-errors");
            IWebDriver driver = new EdgeDriver(service, options);

            try
            {
                driver.Url = ("https://www.speedtest.net//");

                driver.Navigate();
            }
            catch
            { }

            /*
            driver.FindElement(By.Id("email")).SendKeys("leviet241@gmail.com");

            driver.FindElement(By.Id("pass")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.Id("pass")).SendKeys("letrangviet2401!");

            driver.FindElement(By.Name("login")).Click();

            if(driver.FindElement(By.Name("login")) != null)
            {
                driver.FindElement(By.Id("pass")).Click();

                Thread.Sleep(1000);

                driver.FindElement(By.Id("pass")).SendKeys("letrangviet2401!");

                driver.FindElement(By.Name("login")).Click();
            }

            */
        }
    }
}