using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoNUnit
{
    class Test4
    {
        WebDriverWait wait;
        IWebDriver driver;
        By tfAutor = By.Id("et_pb_contact_name_0");
        By tfMensagem = By.Id("et_pb_contact_message_0");
        By btSubmeter = By.Name("et_builder_submit_button");
        By txtValidacao = By.ClassName("et-pb-contact-message");


        [Test]
        public void Desafio2_FillingForms_EsperaExplicita()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
            
            wait.Until(ExpectedConditions.ElementExists(tfAutor));
            driver.FindElement(tfAutor).SendKeys("Sayoan Cristian");

            wait.Until(ExpectedConditions.ElementExists(tfMensagem));
            driver.FindElement(tfMensagem).SendKeys("Teste 123 Valendo!");

            wait.Until(ExpectedConditions.ElementExists(btSubmeter));
            driver.FindElement(btSubmeter).Click();

            wait.Until(ExpectedConditions.ElementExists(txtValidacao));
            Assert.AreEqual("Form filled out successfully", driver.FindElement(txtValidacao).Text);
        }

        [Test]
        public void Desafio2_FillingForms_ValidacaoObrigatorio_EsperaExplicita()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

            wait.Until(ExpectedConditions.ElementExists(tfAutor));
            driver.FindElement(tfAutor).SendKeys("Sayoan Cristian");

            wait.Until(ExpectedConditions.ElementExists(btSubmeter));
            driver.FindElement(btSubmeter).Click();

            wait.Until(ExpectedConditions.ElementExists(txtValidacao));
            Assert.AreEqual("Please, fill in the following fields:\r\nMessage", driver.FindElement(txtValidacao).Text);
        }
      
   
    }
}
