using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using NUnit.Framework;


namespace SeleniumQualityLab
{
    class PageObject
    {
        private IWebDriver driver;
        By login_element;
        By password_element;
        By enter_button;
        By write_button;
        By address_to;
        By send_button;
        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void MailLoginPage()
        {
            string login = "mushtekenov"; /*Input your login*/
            string password = "Musashi1584_GoRinNoSho";/*Input your password*/
            driver.Navigate().GoToUrl("https://mail.ru/");
            Assert.IsTrue(driver.Url=="https://mail.ru/");
            login_element = By.Name("login");
            Assert.NotNull(login_element);
            driver.FindElement(login_element).SendKeys(login); 
            password_element= By.Name("password");
            Assert.NotNull(password_element);
            driver.FindElement(password_element).SendKeys(password);
            enter_button = By.XPath("//input[@value='Войти']");
            Assert.NotNull(enter_button);
            driver.FindElement(enter_button).Click();
            Thread.Sleep(5000);
           
        }
        public void SendMessage()
        {
            write_button = By.XPath("//span[text()='Написать письмо']");
            Assert.NotNull(write_button);
            driver.FindElement(write_button).Click();
            address_to = By.XPath("//textarea[@data-original-name='To']");
            Assert.NotNull(address_to);
            driver.FindElement(address_to).SendKeys("test@gmail.com");
            send_button= By.XPath("//span[text()='Отправить']");
            Assert.NotNull(send_button);
            driver.FindElement(send_button).Click();
        }
    }
}
