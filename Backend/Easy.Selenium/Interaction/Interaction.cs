using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Selenium.Interaction
{    
    public class InteractionBtn
    {
        #region Generic Methods 
        public static void ClickById(IWebDriver driver, string id)
        {
            driver.FindElement(By.Id(id)).Click();
        }               

        public static void ClickByName(IWebDriver driver, string name)
        {
            driver.FindElement(By.Name(name)).Click();
        }

        public static void ClickByXpath(IWebDriver driver, string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }
        #endregion

        #region Custom Methods
        public static void ClickknowledgeRandom(IWebDriver driver, string id)
        {
            var Elements = driver.FindElements(By.Id(id));

            Random random = new Random();
            var value = random.Next(5);

            var Element = Elements.ElementAt(value);
            Element.Click();
        }

        public static void ClickknowledgeSpecific(IWebDriver driver, string id, int value)
        {
            var Elements = driver.FindElements(By.Id(id));            

            var Element = Elements.ElementAt(value);
            Element.Click();
        }

        #endregion
    }


    public class InteractionInput
    {
        #region Generic Methods 
        public static void WriteTxtById(IWebDriver driver, string id, string text)
        {
            var element = driver.FindElement(By.Id(id));
            element.Clear();
            element.SendKeys(text);
        }

        public static void WriteTxtByName(IWebDriver driver, string name, string text)
        {
            var element = driver.FindElement(By.Name(name));
            element.Clear();
            element.SendKeys(text);
        }
        #endregion
        

    }        
}
