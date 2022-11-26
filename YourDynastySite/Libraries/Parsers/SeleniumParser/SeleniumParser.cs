using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumParser
{
    public class SeleniumParser
    {
        public SeleniumParser()
        {
        }

        public string GetSiteContent(string url)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("//body")));
            driver.Close();
            return firstResult.Text;
        }

    }
}