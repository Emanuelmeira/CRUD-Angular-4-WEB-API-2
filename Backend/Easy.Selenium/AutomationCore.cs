using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Easy.Selenium
{
   //[TestClass]
    public class AutomationCore
    {        
        IWebDriver driver;
        string baseURL = "http://localhost:4200/list";

        [TestInitialize]
        public IWebDriver Init()
        {
            driver = new ChromeDriver();
            driver.Url = baseURL;
            
            //TODO: maximizar driver
            return driver;
        }              

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();// Quit();            
        }


    }
}
