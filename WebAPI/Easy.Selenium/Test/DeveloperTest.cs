using Easy.Selenium.DTO;
using Easy.Selenium.Interaction;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Easy.Selenium.Test
{
    [TestClass]
    public class DeveloperTest //TODO: implementar isso aqui AutomationCore 
    {
        AutomationCore automationCore;

        public DeveloperTest()
        {
            automationCore = new AutomationCore();
        }

        [TestMethod]
        public void AddDeveloper()
        {
            IWebDriver driver = automationCore.Init();
                        
            InteratorBtn.ClickById(driver, "btn-add");

            DeveloperTestDTO devoloper = new DeveloperTestDTO();
            //continuar 

            //Set values page 1
            InteratorInput.WriteTxtById(driver, "email", devoloper.Email);
            InteratorInput.WriteTxtById(driver, "name", devoloper.Name);
            InteratorInput.WriteTxtById(driver, "skype", "Skype-Carlos");
            InteratorInput.WriteTxtById(driver, "phone", "71-993254865");

            InteratorInput.WriteTxtById(driver, "linkedin", "https://br.linkedin.com/in/emanuel");
            InteratorInput.WriteTxtById(driver, "city", "Salvador");
            InteratorInput.WriteTxtById(driver, "state", "Bahia");
            InteratorInput.WriteTxtById(driver, "portfolio", "Github.com/teste");

            InteratorBtn.ClickById(driver, "hourUntilFour");
            InteratorBtn.ClickById(driver, "hourFourToSix");
            InteratorBtn.ClickById(driver, "hoursOfWeekend");

            InteratorBtn.ClickById(driver, "morningPeriod");
            InteratorBtn.ClickById(driver, "businessPeriod");

            InteratorInput.WriteTxtById(driver, "pretension", "20");
            InteratorInput.WriteTxtById(driver, "bank", "Banco santander 3432");

            //To Page 2
            string xpathTable2 = "/html/body/app-root/div/div[2]/div/app-form/div[2]/div/form/tabset/ul/li[2]";
            InteratorBtn.ClickByXpath(driver, xpathTable2);

            //Set values page 2
            InteratorInput.WriteTxtById(driver, "bankInf_name", "Emanuele Meira");
            InteratorInput.WriteTxtById(driver, "bankInf_cpf", "038.798.835-14");
            InteratorInput.WriteTxtById(driver, "bankInf_bank", "Santander");
            InteratorInput.WriteTxtById(driver, "bankInf_agency", "4152");
            InteratorBtn.ClickById(driver, "bankInf_chain");
            InteratorInput.WriteTxtById(driver, "bankInf_account", "21544444");

            //To Page 3
            string xpathTable3 = "/html/body/app-root/div/div[2]/div/app-form/div[2]/div/form/tabset/ul/li[3]";
            InteratorBtn.ClickByXpath(driver, xpathTable3);

            //Set values page 3
            InteratorBtn.ClickknowledgeSpecific(driver, "inoic", 3);
            InteratorBtn.ClickknowledgeSpecific(driver, "android", 1);
            InteratorBtn.ClickknowledgeSpecific(driver, "ios", 0);
            InteratorBtn.ClickknowledgeRandom(driver, "html");
            InteratorBtn.ClickknowledgeRandom(driver, "css");
            InteratorBtn.ClickknowledgeRandom(driver, "bootstrap");
            InteratorBtn.ClickknowledgeRandom(driver, "jquery");
            InteratorBtn.ClickknowledgeRandom(driver, "angularJs");
            InteratorBtn.ClickknowledgeRandom(driver, "java");
            InteratorBtn.ClickknowledgeRandom(driver, "aspnet");
            InteratorBtn.ClickknowledgeRandom(driver, "c");
            InteratorBtn.ClickknowledgeRandom(driver, "cplusplus");
            InteratorBtn.ClickknowledgeRandom(driver, "cake");
            InteratorBtn.ClickknowledgeRandom(driver, "django");
            InteratorBtn.ClickknowledgeRandom(driver, "majento");
            InteratorBtn.ClickknowledgeRandom(driver, "php");
            InteratorBtn.ClickknowledgeRandom(driver, "wordpress");
            InteratorBtn.ClickknowledgeRandom(driver, "phyton");
            InteratorBtn.ClickknowledgeRandom(driver, "ruby");
            InteratorBtn.ClickknowledgeRandom(driver, "sqlServer");
            InteratorBtn.ClickknowledgeRandom(driver, "mySql");
            InteratorBtn.ClickknowledgeRandom(driver, "salesforce");
            InteratorBtn.ClickknowledgeRandom(driver, "photoshop");
            InteratorBtn.ClickknowledgeRandom(driver, "illustrator");
            InteratorBtn.ClickknowledgeRandom(driver, "seo");
            InteratorBtn.ClickknowledgeRandom(driver, "html");

            InteratorInput.WriteTxtById(driver, "otherKnowledge", "Xamarin Forms");
            InteratorInput.WriteTxtById(driver, "crud", "githut.com/crud");

            InteratorBtn.ClickById(driver, "submit-dev");

            //Verificação de inclusão 

            //Assert.AreEqual(driver.Title, "Developers");
            automationCore.Cleanup();
        }


    }
}
