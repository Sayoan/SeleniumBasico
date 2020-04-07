using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ProjetoNUnit.Modulo_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoNUnit
{
    class TestFilling : TestBase
    {

        FillingPageObjects fillingPageObjects;


        [Test]
        public void Desafio2_FillingForms_Final()
        {
            fillingPageObjects = new FillingPageObjects();
            string nome = "Sayoan Cristian";
            string mensagem = "Test 123 Valendo!";

            fillingPageObjects.PreencherFormulario(nome, mensagem);
            fillingPageObjects.Submeter();

            Assert.AreEqual("Form filled out successfully", fillingPageObjects.RetornoCadastro());
        }

        [TestCase("Sayoan Oliveira, ")]
        public void Desafio2_FillingForms_ValidacaoObrigatorio_Final(string nome, string mensagem)
        {
            fillingPageObjects = new FillingPageObjects();
            fillingPageObjects.PreencherFormulario(nome, mensagem);
            fillingPageObjects.Submeter();

            Assert.AreEqual("Please, fill in the following fields:\r\nMessage", fillingPageObjects.RetornoCadastro());
        }

       

     

 
    }

   
}
