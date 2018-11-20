using AutomacaoFuncional.tests.pages;
using AutomacaoFuncional.tests.utils;
using System;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{

    [Binding]
    public class AccessSteps
    {
        private AccessPageActions pageAction = new AccessPageActions();

        [Given(@"Access to page ""(.*)""")]
        public void GivenAccessToPage(string url)
        {

            pageAction.AccessPage(url);

        }
        
        [Then(@"Page loaded with sucess")]
        public void ThenPageLoadedWithSucess()
        {
            ClassInfo.GetInstance().ResultScenario = pageAction.ValidAccessPage();
        }
    }
}
