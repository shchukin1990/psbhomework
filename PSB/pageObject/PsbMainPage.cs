using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using SeleniumExtras.WaitHelpers;
namespace PSB.pageObject

{
    public class PsbMainPage
    {
        public ChromeDriver driver;
        public PsbMainPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement CreditButtonLocator => driver.FindElement(By.XPath("//a[@title='Кредиты']"));
        
        public void CreditButton() => CreditButtonLocator.Click();


        public IWebElement MortgageButtonLocator => driver.FindElement(By.XPath("//a[@title='Ипотека']"));
        public void MortgageButton() => MortgageButtonLocator.Click();

    }
}
