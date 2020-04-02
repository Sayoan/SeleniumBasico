using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoNUnit
{
    class Test5
    {
        IWebDriver driver;
        By tfAutor = By.Id("et_pb_contact_name_0");
        By tfMensagem = By.Id("et_pb_contact_message_0");
        By btSubmeter = By.Name("et_builder_submit_button");
        By txtValidacao = By.ClassName("et-pb-contact-message");


        [Test]
        public void Desafio2_FillingForms_Final()
        {
            string nome = "Sayoan Cristian";
            string mensagem = "Test 123 Valendo!";

            waitElement(tfAutor).SendKeys(nome);
            waitElement(tfMensagem).SendKeys(mensagem);
            waitElement(btSubmeter).Click();

            Assert.AreEqual("Form filled out successfully", waitElement(txtValidacao).Text);
        }

        [TestCase("Sayoan Oliveira")]
        public void Desafio2_FillingForms_ValidacaoObrigatorio_Final(string nome)
        {
            waitElement(tfAutor).SendKeys(nome);
            waitElement(tfMensagem).Clear();
            waitElement(btSubmeter).Click();

            Assert.AreEqual("Please, fill in the following fields:\r\nMessage", waitElement(txtValidacao).Text);
        }

        public IWebElement waitElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(element)); //para injeções de JS
            IWebElement elemetIWeb = driver.FindElement(element);
            wait.Until(ExpectedConditions.ElementToBeClickable(elemetIWeb));

            return elemetIWeb;
        }

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
        }
        [TearDown]
        public void teardown()
        {
            driver.Close();
        }
    }

   
}
