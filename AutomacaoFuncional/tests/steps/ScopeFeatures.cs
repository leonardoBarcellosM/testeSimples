using AutomacaoFuncional.tests.utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomacaoFuncional.tests.steps
{
    [Binding]
    class ScopeFeatures
    {

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureInfo featureInfo)
        {
            string typeBrowser = featureInfo.Title.Contains("-") ? featureInfo.Title.Split('-')[0] : null;
            ClassDriver.GetInstance().StartDriver(typeBrowser);
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {

        }

        [BeforeStep]
        public static void BeforeStep()
        {

        }


        [AfterStep]
        public static void AfterStep()
        {
            
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Assert.True(ClassInfo.GetInstance().ResultScenario, ClassInfo.GetInstance().LogMessage, null);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            ClassDriver.GetInstance().QuitDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {

        }           

    }
}
