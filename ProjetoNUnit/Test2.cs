using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoNUnit
{
    class Test2
    {
        [Test]
        public void Test_Web()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com.br");
            Assert.AreEqual("https://www.google.com.br/", driver.Url);
            
        }
        [Test]
        public void Test_Web_2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com.br");
            Assert.AreEqual("Google", driver.Title);
             
        }

        [Test]
        [Ignore("")]
        public void acoesElemento()
        {
            IWebDriver driver = new ChromeDriver();
            By botao = By.Id("elementoid");

            driver.FindElement(botao).Click();
        }

       

    }
}

