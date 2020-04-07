using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProjetoNUnit.Modulo_3
{
    class TestBase
    {
        public static IWebDriver driver { get; set; } = null;

        [SetUp]
        public void setup()
        {
            if (driver == null)
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                //chromeOptions.AddUserProfilePreference("download.default_directory", getPathChromeBin());
                //chromeOptions.AddArguments("headless");
                chromeOptions.AddArgument("start-maximized"); // open Browser in maximized mode
                chromeOptions.AddArgument("disable-infobars"); // disabling infobars
                chromeOptions.AddArgument("--disable-extensions"); // disabling extensions
                chromeOptions.AddArgument("--disable-gpu"); // applicable to windows os only
                chromeOptions.AddArgument("--disable-dev-shm-usage"); // overcome limited resource problems
                chromeOptions.AddArgument("--no-sandbox"); // Bypass OS security model
                
                driver = new ChromeDriver(chromeOptions); //usar este para chrome dentro do projeto
                driver.Manage().Window.Size = new Size(1024, 768);

                driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
            }
        }
        [TearDown]
        public void teardown()
        {
            driver.Quit();
            driver = null;
        }
    }
}
