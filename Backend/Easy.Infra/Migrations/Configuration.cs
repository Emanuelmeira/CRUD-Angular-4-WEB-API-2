using Easy.Domain.Entities;
using Easy.Infra.Context;
using System.Data.Entity.Migrations;

namespace Easy.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Easy.Infra.Context.EFContext";
        }

        protected override void Seed(EFContext context)
        {  
            
            context.BankInformation.Add(new BankInformation
            {
                Id = 1,
                Name = "Pedro",
                Bank = "Bradesco",
                Agency = "1234-1",
                Account = "1234565",
                Chain = true,
                CPF = "123456789"
            });
            context.SaveChanges();

            context.Knowledge.Add(new Knowledge
            {
                Id = 1,
                Ionic = 3,
                Android = 3,
                Ios = 3,
                Html = 4,
                Css = 4,
                Bootstrap = 3,
                Jquery = 3,
                AngularJs = 3,
                Java = 4,
                Aspnet = 3,
                C = 4,
                Cplusplus = 4,
                Cake = 4,
                Django = 4,
                Majento = 4,
                Php = 3,
                Wordpress = 3,

                Phyton = 4,
                Ruby = 4,
                SqlServer = 4,
                MySql = 4,
                Salesforce = 4,
                Photoshop = 4,
                Illustrator = 4,
                Seo = 4,

                OtherKnowledge = "Selenium IDE"
            });
            context.SaveChanges();

            context.Developers.Add(new Developer
            {
                Id = 1,

                Email = "pedrohttp@gmail.com",

                Name = "Pedro juca",
                Skype = "pedrohttp",
                Phone = "719933154265",
                Linkedin = "linkedin.com/tesds",
                City = "Salvador",
                State = "Bahia",
                Portfolio = "Portifolio",

                HourUntilFour = true,
                HourFourToSix = false,
                HourFourToEight = true,
                HourAboveEight = false,
                HoursOfWeekend = true,

                MorningPeriod = true,
                AfternoonPeriod = true,
                NightPeriod = false,
                DawnPeriod = false,
                BusinessPeriod = false,

                Pretension = 40,
                Bank = "dados do banco",
                Crud = "www.gtihub.com/crud",

                BankInformationId = 1,
                KnowledgeId = 1

            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
