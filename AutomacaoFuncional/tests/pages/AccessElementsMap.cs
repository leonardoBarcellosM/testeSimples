using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.pages
{
    class AccessElementsMap
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='col-sm-6 col-xs-6 logo-container']//a")]
        [CacheLookup]
        public IWebElement logo { get; set; }
    }
}
