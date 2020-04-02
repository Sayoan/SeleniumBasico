using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjetoNUnit
{
    class Test3
    {
        [Test]
        public void BuscarTempoGoogle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com.br");

            driver.FindElement(By.Name("q")).SendKeys("Tempo em bh");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            Assert.AreEqual("Belo Horizonte, MG", driver.FindElement(By.Id("wob_loc")).Text);
        }

        [Test]
        public void Desafio2_FillingForms()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

            driver.FindElement(By.Id("et_pb_contact_name_0")).SendKeys("Sayoan Cristian");
            driver.FindElement(By.Id("et_pb_contact_message_0")).SendKeys("Teste 123 Valendo!");
            driver.FindElement(By.Name("et_builder_submit_button")).Click();

            Thread.Sleep(2000);
            Assert.AreEqual("Form filled out successfully", driver.FindElement(By.ClassName("et-pb-contact-message")).Text);
        }

        [Test]
        public void Desafio2_FillingForms_ValidacaoObrigatorio()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

            driver.FindElement(By.Id("et_pb_contact_name_0")).SendKeys("Sayoan Cristian");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("et_pb_contact_message_0")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Name("et_builder_submit_button")).Click();
            Thread.Sleep(2000);

            Assert.AreEqual("Please, fill in the following fields:\r\nMessage", driver.FindElement(By.ClassName("et-pb-contact-message")).Text);
        }

       

        
    } 
}
