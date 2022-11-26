using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumParsers
{
    public class SeleniumParser
    {
        private readonly IWebDriver _webDriver;
        public SeleniumParser()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            _webDriver = new ChromeDriver(options);
        }

        public string GetSiteContent(string url, string waitXPath)
        {
            _webDriver.Navigate().GoToUrl(url);
            WebDriverWait wait = new (_webDriver, TimeSpan.FromSeconds(10));
            IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath(waitXPath)));
            return _webDriver.PageSource;
        }

        public void CloseConnection() => _webDriver.Close();

    }
}