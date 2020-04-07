using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoNUnit.Modulo_3
{
    class PageBase
    {
        protected IWebDriver _driver { get; private set; }  //Otimiza o uso do INSTANCE estático
        public PageBase()
        {
           _driver = TestBase.driver;           
        }
        public IWebElement waitElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(element)); //para injeções de JS
            IWebElement elemetIWeb = _driver.FindElement(element);
            wait.Until(ExpectedConditions.ElementToBeClickable(elemetIWeb));

            return elemetIWeb;
        }



    }
}
