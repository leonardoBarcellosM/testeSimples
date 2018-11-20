using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AutomacaoFuncional.tests.utils
{
    class ClassUtilities
    {

        public bool WaitForElementVisible(IWebElement element, int timeoutSecond)
        {
            int count = 0;

            do
            {
                try
                {
                    return element.Displayed && element.Enabled;
                }
                catch (Exception)
                {
                    Thread.Sleep(250);
                    count++;
                }

            } while (count < timeoutSecond * 4);

            return false;

        }       

        public void ScrollElementoPage(IWebElement element)
        {
            try
            {

                Point point = new Point();

                if (element != null)
                {
                    point = element.Location;
                    IJavaScriptExecutor js = ClassDriver.GetInstance().Driver as IJavaScriptExecutor;

                    js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                    //js.ExecuteScript("window.scrollBy(" + (point.Y - space) + ");");

                }
            }
            catch (Exception)
            {
            }
        }

        internal void ClickJS()
        {
            throw new NotImplementedException();
        }

        internal void WaitForElementVisible(IWebElement nameProduct)
        {
            throw new NotImplementedException();
        }

        public void SendKeyJS(IWebElement element, string value)
        {
            try
            {
                IJavaScriptExecutor js = ClassDriver.GetInstance().Driver as IJavaScriptExecutor;
                js.ExecuteScript("arguments[0].setAttribute('value', '" + value + "')", element);
            }
            catch (Exception)
            {

            }
           
        }

        public void ClickJS(IWebElement element)
        {
            try
            {
                IJavaScriptExecutor js = ClassDriver.GetInstance().Driver as IJavaScriptExecutor;
                js.ExecuteScript("arguments[0].click()", element);
            }
            catch (Exception)
            {

            }

        }

        public void HoverMenu(IWebDriver driver, IWebElement element)
        {
            try
            {
                string mouseOverScript = "if(document.createEvent){var evObj = document.createEvent('MouseEvents');evObj.initEvent('mouseover', true, false); arguments[0].dispatchEvent(evObj);} else if(document.createEventObject) { arguments[0].fireEvent('onmouseover');}";
                IJavaScriptExecutor js = driver as IJavaScriptExecutor;
                js.ExecuteScript(mouseOverScript, element);

            }
            catch (Exception)
            {

            }
        }

        public void Screenshot(IWebDriver driver, string screenshotPasta)
        {
            ITakesScreenshot camera = driver as ITakesScreenshot;
            Screenshot foto = camera.GetScreenshot();
            foto.SaveAsFile(screenshotPasta, ScreenshotImageFormat.Png);
        }

        internal void Screenshot(IWebDriver driver, object p)
        {
            throw new NotImplementedException();
        }


        /*
         * Faz o clique no elemento passado como parâmetro
         *
         */

        //public void ClickJS(IWebElement element)
        //{
        //    try
        //    {
        //        // this.HigthLine(element, true);
        //        IJavaScriptExecutor executor = (IJavaScriptExecutor)ClassDriver.GetInstance().Driver;
        //        executor.ExecuteScript("arguments[0].click();", element);

        //    }
        //    catch (Exception) { }

        //}

    }
}
