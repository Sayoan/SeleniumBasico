using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoNUnit.Modulo_3
{
    class FillingPageObjects : PageBase
    {

        By tfAutor = By.Id("et_pb_contact_name_0");
        By tfMensagem = By.Id("et_pb_contact_message_0");
        By btSubmeter = By.Name("et_builder_submit_button");
        By txtValidacao = By.ClassName("et-pb-contact-message");


        public void Submeter()
        {
          waitElement(btSubmeter).Click();
        }

        public void PreencherFormulario(string autor, string mensagem)
        {
            waitElement(tfAutor).Clear();
            waitElement(tfMensagem).Clear();

            waitElement(tfAutor).SendKeys(autor);
            waitElement(tfMensagem).SendKeys(mensagem);
        }

        public string RetornoCadastro()
        {
            return waitElement(txtValidacao).Text;
        }
    }
}
