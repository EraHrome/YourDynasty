using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumParsers
{
    public class SeleniumParser
    {
        public SeleniumParser()
        {
        }

        public string GetSiteContent(string url, string waitXPath)
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(url);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath(waitXPath)));
            var html = driver.PageSource;
            driver.Close();
            return html;
        }

    }
}