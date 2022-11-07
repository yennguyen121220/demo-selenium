using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestInstall
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LaunchChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ww.google.com");
            driver.Close();
        }

        [Test]
        public void Capture()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");

            var title = driver.Title;
            Console.WriteLine("Page title: ");
            Console.WriteLine(title);

            var url = driver.Url;
            Console.WriteLine("Page url: ");
            Console.WriteLine(url);

            var pageSource = driver.PageSource;
            Console.WriteLine("Page source: ");
            Console.WriteLine(pageSource);

            Thread.Sleep(3000);
            driver.Close();
        }
        [Test]
        public void PlayWithTextBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com");

            IWebElement email = driver.FindElement(By.XPath("//input[@id='email']"));
            email.SendKeys("test1212@gmail.com");

            IWebElement pass = driver.FindElement(By.XPath("//input[@id='pass']"));
            pass.SendKeys("1234");

            Thread.Sleep(3000);
            driver.Close();
        }
    }
}