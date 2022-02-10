using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace PSB.pageObject
{
    public class CreditPage
    {
        public ChromeDriver driver;
        public CreditPage(ChromeDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement TitleСonsumerLoans => driver.FindElement(By.XPath("//h1[contains(@class, 'main-title')]"));
        public IWebElement LeaveARequestButtonLocator => driver.FindElement(By.XPath("//a[@class='button button--spotlight']"));
        public void LeaveARequestButton() => LeaveARequestButtonLocator.Click();
        public IWebElement SurnameInputLocator => driver.FindElement(By.XPath("//input[@id='mat-input-1']"));
        public void SurnameInput() => SurnameInputLocator.SendKeys("плплпврлвдвр");
        public IWebElement NameInputLocator => driver.FindElement(By.XPath("//input[@id='mat-input-2']"));
        public void NameInput() => NameInputLocator.SendKeys("аорараоо");
        public IWebElement PatronymicInputLocator => driver.FindElement(By.XPath("//input[@id = 'mat-input-3']"));
        public void PatronymicInput() => PatronymicInputLocator.SendKeys("аорараоо");
        public IWebElement MaleLocator => driver.FindElement(By.XPath("//div[@class = 'rui-radio__label']"));
        public void Male() => MaleLocator.Click();
        public IWebElement DateOfBirthLocator => driver.FindElement(By.XPath("//input[@data-mat-calendar = 'mat-datepicker-1']"));
        public void DateOfBirth() {
            DateOfBirthLocator.Click();
            DateOfBirthLocator.SendKeys("11112000");
                }//не вводит дату
        public IWebElement PhoneNumberLocator => driver.FindElement(By.XPath("//input[@id = 'formly_21_input_Phone_1']"));
      
        public void PhoneNumber() {
            PhoneNumberLocator.Click();
            PhoneNumberLocator.SendKeys("98544589756"); }
        public IWebElement CitizenshipLocator => driver.FindElement(By.XPath("//div[@class='mat - select - arrow ng - tns - c66 - 10']"));
        public void Citizenship() => CitizenshipLocator.Click();
        public IWebElement AllUnderstandButtonLocator => driver.FindElement(By.XPath("//button[@class = 'rui-space_all-3']"));
        public void AllUnderstandButton() => AllUnderstandButtonLocator.Click();
        public IWebElement CitizenShipLocator() => driver.FindElement(By.XPath("//mat-select[@name = 'RussianFederationResident']"));
        public IWebElement RussianEmployment() => driver.FindElement(By.XPath("//mat-select[@name = 'RussianEmployment']"));


        public void SelectOption(string option)
        {

            driver.FindElement(By.XPath($"//mat-option//span[text() = '{option}']")).Click();
        }
    }
}
