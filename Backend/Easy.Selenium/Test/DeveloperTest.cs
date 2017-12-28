using Easy.Selenium.DTO;
using Easy.Selenium.Interaction;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

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

            InteractionBtn.ClickById(driver, "btn-add");

            DeveloperTestDTO devoloper = new DeveloperTestDTO();

            //Set values page 1
            InteractionInput.WriteTxtById(driver, "email", devoloper.Email);
            InteractionInput.WriteTxtById(driver, "name", devoloper.Name);
            InteractionInput.WriteTxtById(driver, "skype", devoloper.Skype);
            InteractionInput.WriteTxtById(driver, "phone", devoloper.Phone);

            InteractionInput.WriteTxtById(driver, "linkedin", devoloper.Linkedin);
            InteractionInput.WriteTxtById(driver, "city", devoloper.City);
            InteractionInput.WriteTxtById(driver, "state", devoloper.State);
            InteractionInput.WriteTxtById(driver, "portfolio", devoloper.Portfolio);

            InteractionBtn.ClickById(driver, "hourUntilFour");
            InteractionBtn.ClickById(driver, "hourFourToSix");
            InteractionBtn.ClickById(driver, "hoursOfWeekend");

            InteractionBtn.ClickById(driver, "morningPeriod");
            InteractionBtn.ClickById(driver, "businessPeriod");

            InteractionInput.WriteTxtById(driver, "pretension", devoloper.Pretension);
            InteractionInput.WriteTxtById(driver, "bank", devoloper.Bank_Information);

            //To Page 2
            string xpathTable2 = "/html/body/app-root/div/div[2]/div/app-form/div[2]/div/form/tabset/ul/li[2]";
            InteractionBtn.ClickByXpath(driver, xpathTable2);

            //Set values page 2
            InteractionInput.WriteTxtById(driver, "bankInf_name", devoloper.Name);
            InteractionInput.WriteTxtById(driver, "bankInf_cpf", devoloper.Bank_cpf);
            InteractionInput.WriteTxtById(driver, "bankInf_bank", devoloper.Bank_Name);
            InteractionInput.WriteTxtById(driver, "bankInf_agency", devoloper.Bank_Agency);
            InteractionBtn.ClickById(driver, "bankInf_chain");
            InteractionInput.WriteTxtById(driver, "bankInf_account", devoloper.Bank_Account_Number);

            //To Page 3
            string xpathTable3 = "/html/body/app-root/div/div[2]/div/app-form/div[2]/div/form/tabset/ul/li[3]";
            InteractionBtn.ClickByXpath(driver, xpathTable3);

            //Set values page 3
            InteractionBtn.ClickknowledgeSpecific(driver, "inoic", 3);
            InteractionBtn.ClickknowledgeSpecific(driver, "android", 1);
            InteractionBtn.ClickknowledgeSpecific(driver, "ios", 0);
            InteractionBtn.ClickknowledgeRandom(driver, "html");
            InteractionBtn.ClickknowledgeRandom(driver, "css");
            InteractionBtn.ClickknowledgeRandom(driver, "bootstrap");
            InteractionBtn.ClickknowledgeRandom(driver, "jquery");
            InteractionBtn.ClickknowledgeRandom(driver, "angularJs");
            InteractionBtn.ClickknowledgeRandom(driver, "java");
            InteractionBtn.ClickknowledgeRandom(driver, "aspnet");
            InteractionBtn.ClickknowledgeRandom(driver, "c");
            InteractionBtn.ClickknowledgeRandom(driver, "cplusplus");
            InteractionBtn.ClickknowledgeRandom(driver, "cake");
            InteractionBtn.ClickknowledgeRandom(driver, "django");
            InteractionBtn.ClickknowledgeRandom(driver, "majento");
            InteractionBtn.ClickknowledgeRandom(driver, "php");
            InteractionBtn.ClickknowledgeRandom(driver, "wordpress");
            InteractionBtn.ClickknowledgeRandom(driver, "phyton");
            InteractionBtn.ClickknowledgeRandom(driver, "ruby");
            InteractionBtn.ClickknowledgeRandom(driver, "sqlServer");
            InteractionBtn.ClickknowledgeRandom(driver, "mySql");
            InteractionBtn.ClickknowledgeRandom(driver, "salesforce");
            InteractionBtn.ClickknowledgeRandom(driver, "photoshop");
            InteractionBtn.ClickknowledgeRandom(driver, "illustrator");
            InteractionBtn.ClickknowledgeRandom(driver, "seo");
            InteractionBtn.ClickknowledgeRandom(driver, "html");

            InteractionInput.WriteTxtById(driver, "otherKnowledge", devoloper.Other_knowledge);
            InteractionInput.WriteTxtById(driver, "crud", devoloper.Crud);

            InteractionBtn.ClickById(driver, "submit-dev");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            bool developerInTable = Verify.CheckElementTable(driver, devoloper.Name);
            
            Assert.IsTrue(developerInTable);
            automationCore.Cleanup();
        }

        [TestMethod]
        public void EditDeveloper()
        {
            IWebDriver driver = automationCore.Init();

            InteractionBtn.ClickById(driver, "btn-edit");

            DeveloperTestDTO devoloper = new DeveloperTestDTO();

            //Set values page 1
            InteractionInput.WriteTxtById(driver, "email", "pedro@teste.com");
            InteractionInput.WriteTxtById(driver, "name", "edit name");
            InteractionInput.WriteTxtById(driver, "skype", "Edit Skype");

            InteractionInput.WriteTxtById(driver, "city", "miami beach ;)");
            InteractionInput.WriteTxtById(driver, "state", "Florida");

            //To Page 2
            string xpathTable2 = "/html/body/app-root/div/div[2]/div/app-form/div[2]/div/form/tabset/ul/li[2]";
            InteractionBtn.ClickByXpath(driver, xpathTable2);

            //Set values page 2            
            InteractionInput.WriteTxtById(driver, "bankInf_bank", "edit bank name");
            InteractionBtn.ClickById(driver, "bankInf_chain");

            //To Page 3
            string xpathTable3 = "/html/body/app-root/div/div[2]/div/app-form/div[2]/div/form/tabset/ul/li[3]";
            InteractionBtn.ClickByXpath(driver, xpathTable3);

            //Set values page 3            
            InteractionBtn.ClickknowledgeRandom(driver, "html");
            InteractionBtn.ClickknowledgeRandom(driver, "css");
            InteractionBtn.ClickknowledgeRandom(driver, "bootstrap");
            InteractionBtn.ClickknowledgeRandom(driver, "jquery");
            InteractionBtn.ClickknowledgeRandom(driver, "java");
            InteractionBtn.ClickknowledgeRandom(driver, "aspnet");
            InteractionBtn.ClickknowledgeRandom(driver, "wordpress");
            InteractionBtn.ClickknowledgeRandom(driver, "ruby");
            InteractionBtn.ClickknowledgeRandom(driver, "sqlServer");
            InteractionBtn.ClickknowledgeRandom(driver, "mySql");
            InteractionBtn.ClickknowledgeRandom(driver, "seo");
            InteractionBtn.ClickknowledgeRandom(driver, "html");

            InteractionInput.WriteTxtById(driver, "otherKnowledge", "IA");

            InteractionBtn.ClickById(driver, "submit-dev");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            
            //TODO: quebrando
            bool developerInTable = Verify.CheckElementTable(driver, "pedro@teste.com");

            Assert.IsTrue(developerInTable);
            automationCore.Cleanup();
        }

        [TestMethod]
        public void DetailsDeveloper()
        {
            IWebDriver driver = automationCore.Init();

            InteractionBtn.ClickById(driver, "btn-details");
            automationCore.Cleanup();
        }
    }
}
