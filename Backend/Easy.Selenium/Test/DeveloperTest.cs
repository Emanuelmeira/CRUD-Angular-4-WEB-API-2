using Easy.Domain.Entities;
using Easy.Selenium.Core;
using Easy.Selenium.DAL;
using Easy.Selenium.Interaction;
using Easy.Selenium.MockEtities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace Easy.Selenium.Test
{
    [TestClass]
    public class DeveloperTest 
    {
        AutomationCore automationCore;
        MockDeveloper mockDeveloper;
        DataAcess data;

        public DeveloperTest()
        {
            automationCore = new AutomationCore();
            data = new DataAcess();
            mockDeveloper  = new MockDeveloper();
        }

        [TestMethod]
        public void AddDeveloper()
        {
            IWebDriver driver = automationCore.Init();

            InteractionBtn.ClickById(driver, "btn-add");

            Developer developer = mockDeveloper.Prepare();

            //Set values page 1
            InteractionInput.WriteTxtById(driver, "email", developer.Email);
            InteractionInput.WriteTxtById(driver, "name", "EmanuelMeira");
            InteractionInput.WriteTxtById(driver, "skype", developer.Skype);
            InteractionInput.WriteTxtById(driver, "phone", developer.Phone);

            InteractionInput.WriteTxtById(driver, "linkedin", developer.Linkedin);
            InteractionInput.WriteTxtById(driver, "city", developer.City);
            InteractionInput.WriteTxtById(driver, "state", developer.State);
            InteractionInput.WriteTxtById(driver, "portfolio", developer.Portfolio);

            InteractionBtn.ClickById(driver, "hourUntilFour");
            InteractionBtn.ClickById(driver, "hourFourToSix");
            InteractionBtn.ClickById(driver, "hoursOfWeekend");

            InteractionBtn.ClickById(driver, "morningPeriod");
            InteractionBtn.ClickById(driver, "businessPeriod");

            InteractionInput.WriteTxtById(driver, "pretension", Convert.ToString(developer.Pretension));
            InteractionInput.WriteTxtById(driver, "bank", developer.Bank);

            //To Page 2
            string xpathTable2 = "/html/body/app-root/div/div[2]/div/app-form/div[2]/div/form/tabset/ul/li[2]";
            InteractionBtn.ClickByXpath(driver, xpathTable2);

            //Set values page 2
            InteractionInput.WriteTxtById(driver, "bankInf_name", developer.Name);
            InteractionInput.WriteTxtById(driver, "bankInf_cpf", developer.BankInf.CPF);
            InteractionInput.WriteTxtById(driver, "bankInf_bank", developer.BankInf.Bank);
            InteractionInput.WriteTxtById(driver, "bankInf_agency", developer.BankInf.Agency);
            InteractionBtn.ClickById(driver, "bankInf_chain");
            InteractionInput.WriteTxtById(driver, "bankInf_account", developer.BankInf.Account);

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

            InteractionInput.WriteTxtById(driver, "otherKnowledge", developer.Knowledge.OtherKnowledge);
            InteractionInput.WriteTxtById(driver, "crud", developer.Crud);

            InteractionBtn.ClickById(driver, "submit-dev");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            bool isValid = data.ExistDeveloperByName("EmanuelMeira");

            Assert.IsTrue(isValid);
            automationCore.Cleanup();
        }

        [TestMethod]
        public void EditDeveloper()
        {
            IWebDriver driver = automationCore.Init();

            InteractionBtn.ClickById(driver, "btn-edit");            

            //Set values page 1
            InteractionInput.WriteTxtById(driver, "email", "pedro@teste.com");
            InteractionInput.WriteTxtById(driver, "name", "Teste name");
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

            bool isValid = data.ExistDeveloperByName("Test name");

            Assert.IsTrue(isValid);
            automationCore.Cleanup();
        }

        [TestMethod]
        public void DetailsDeveloper()
        {
            IWebDriver driver = automationCore.Init();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            InteractionBtn.ClickById(driver, "btn-details");
            automationCore.Cleanup();
        }
    }
}
