using Easy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Unit.Test.MockEtities
{
    public class MockDeveloper
    {

        private Developer developer;

        public MockDeveloper()
        {            
            developer = new Developer
            {
                BankInf = new BankInformation(),
                Knowledge = new Knowledge()
            };
        }
         
        public Developer Prepare()
        {

            developer.Email = "emanuelmeira@outlook.com";
            developer.Name = "Emanuel Meira";
            developer.Skype = "EmamitSkype";
            developer.Phone = "557199325148";
            developer.Linkedin = "https://br.linkedin.com/in/emanuel";
            developer.City = "Salvador";
            developer.State = "Bahia";
            developer.Portfolio = "www.portifolio.com";

            developer.HourUntilFour = true;
            developer.HourFourToSix = true;
            developer.HourFourToEight = true;
            developer.HourAboveEight = false;
            developer.HoursOfWeekend = false;

            developer.MorningPeriod = false;
            developer.AfternoonPeriod = false;
            developer.NightPeriod = true;
            developer.DawnPeriod = true;
            developer.BusinessPeriod = true;
            
            developer.Pretension = 20;
            developer.Bank = "information bank";
            developer.Crud = "www.github.com/teste";

            developer.Knowledge = this.PrepareKnowledge();
            developer.BankInf = this.PrepareBankInformation();

            return developer;
        }

        private BankInformation PrepareBankInformation()
        {
            BankInformation BankInf = new BankInformation();

            BankInf.Name = "Emanuel Meira";
            BankInf.Bank = "bank inter";
            BankInf.Agency = "0154";
            BankInf.CPF = "12345678901";
            BankInf.Account = "21544444";
            BankInf.Chain = true;
            BankInf.Savings = false;

            return BankInf;
        }

        private Knowledge PrepareKnowledge()
        {
            Knowledge knowledge = new Knowledge();

            knowledge.Ionic = 2;
            knowledge.Android = 2;
            knowledge.Ios = 2;
            knowledge.Html = 2;
            knowledge.Css = 2;

            knowledge.Bootstrap = 2;
            knowledge.Jquery = 2;
            knowledge.AngularJs = 2;
            knowledge.Java = 2;
            knowledge.Aspnet = 2;

            knowledge.C = 3;
            knowledge.Cplusplus = 3;
            knowledge.Cake = 3;
            knowledge.Django = 3;
            knowledge.Majento = 3;

            knowledge.Php = 4;
            knowledge.Wordpress = 4;
            knowledge.Phyton = 4;
            knowledge.Ruby = 4;
            knowledge.SqlServer = 4;

            knowledge.MySql = 5;
            knowledge.Salesforce = 5;
            knowledge.Photoshop = 5;
            knowledge.Illustrator = 5;
            knowledge.Seo = 5;

            knowledge.OtherKnowledge = "Xamarin Forms";

            return knowledge;
        }        

    }
}
