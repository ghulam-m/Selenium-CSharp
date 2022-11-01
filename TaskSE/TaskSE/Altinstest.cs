using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Internal;
namespace TaskSE
{
    internal class Altinstest
    {
        [Test]
        public void ExecuteTest()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("--headless");
            option.AddArguments("--start-maximized");
            option.AddArguments("--safebrowsing-disable-download-protection");
            option.AddArguments("--safebrowsing-disable-extension-blacklist");
            IWebDriver driver = new ChromeDriver("C:\\Users\\Dev\\source\\repos\\Selenium-CSharp\\TaskSE\\Webdrivers", option);
            driver.Navigate().GoToUrl("https://www.emsisoft.com/en/anti-malware-home/");
            var Btn = driver.FindElement(By.XPath("//a[normalize-space()='Alternative installation options']"));
            Assert.IsTrue(Btn.Displayed);
            Btn.Click();
            var WebInstaller = driver.FindElement(By.XPath("//a[normalize-space()='Web installer']"));
            Assert.IsTrue(WebInstaller.Displayed);
            WebInstaller.Click();
        }
    }
}