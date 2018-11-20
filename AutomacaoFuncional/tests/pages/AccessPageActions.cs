using AutomacaoFuncional.tests.utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class AccessPageActions : AccessElementsMap
    {
        private ClassUtilities util = new ClassUtilities();
        private string screenshots;
        int contador = 1;
        private IJavaScriptExecutor js;

        public AccessPageActions()
        {
            PageFactory.InitElements(ClassDriver.GetInstance().Driver, this);
        }

        public void AccessPage(string url)
        {
            try
            {
                ClassDriver.GetInstance().Driver.Navigate().GoToUrl(url);
            }
            catch (Exception)
            {

            }
            
        }

        public bool ValidAccessPage()
        {
            screenshots = @"C:\Users\Leonardo\Desktop\Screenshots\";
            bool _result = false;
            try
            {
                util.WaitForElementVisible(logo, 10);

                if (logo.Displayed)
                {
                    js = (IJavaScriptExecutor)ClassDriver.GetInstance().Driver; //Permite executar Javascript
                    js.ExecuteScript("window.scrollBy(0, 900)", ""); //rola para baixo
                    _result = true;
                }               
            }
            catch (Exception)
            {
                ClassInfo.GetInstance().LogMessage = "Error accessing the page";
            }
            return _result;
        }
    }
}
