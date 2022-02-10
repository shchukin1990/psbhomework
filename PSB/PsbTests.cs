using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using PSB.pageObject;
using System;

namespace PSB

{
    public class PsbTests
    {

        public ChromeDriver driver;

       

        [SetUp]
        public void Setup()
        {
           
        driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void TitleСonsumerLoans()
        {
            driver.Navigate().GoToUrl("https://www.psbank.ru/");

            //Assert.IsTrue();
            PsbMainPage LoginPage = new PsbMainPage(driver);
            LoginPage.CreditButton();
           
            //var header = driver.FindElement(By.XPath("//h1[contains(@class, 'main-title')]"));
            CreditPage creditPage = new CreditPage(driver);
            //WebElement explicitWait = (new WebDriverWait(driver, 10));
            //WebDriverWait wait = new WebDriverWait(driver, Timeout.FromSeconds(10)); ;
            //IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("//h1[contains(@class, 'main-title')]")));
            //var foo = new WebDriverWait(driver, TimeSpan.FromSeconds(3))
            // .Until(drv => drv.FindElement(By.Name("Потребительские кредиты")));
            //driver.Manage().Timeouts().ImplicitWait = Timeout.FromSeconds(10);
            //WebDriverWait wait = new WebDriverWait(driver, timeout: TimeSpan.FromSeconds(30))
            //{
            //    PollingInterval = TimeSpan.FromSeconds(5),
            //};
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30.00));

            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            var a = creditPage.TitleСonsumerLoans.Text;
            Assert.IsTrue(creditPage.TitleСonsumerLoans.Text.Contains("Потребительские"));

        }

        
           
            
        ////}

        [Test]

        public void LeaveARequest()
        {
            driver.Navigate().GoToUrl("https://www.psbank.ru/");
            PsbMainPage LoginPage = new PsbMainPage(driver);
            CreditPage CreditPage = new CreditPage(driver);

            LoginPage.CreditButton();
            CreditPage.LeaveARequestButton();
            try
            {
                CreditPage.AllUnderstandButton();
            }
            catch
            {

            }
            CreditPage.SurnameInput();
            CreditPage.NameInput();
            CreditPage.PatronymicInput();
            CreditPage.Male();
            CreditPage.DateOfBirth();
            CreditPage.PhoneNumber();
            CreditPage.CitizenShipLocator().Click();
            CreditPage.SelectOption("РФ");
            CreditPage.RussianEmployment().Click();
            CreditPage.SelectOption("Есть");

        }

        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //}
    }
}
