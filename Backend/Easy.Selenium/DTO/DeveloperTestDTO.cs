using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Selenium.DTO
{
    public class DeveloperTestDTO
    {
        public DeveloperTestDTO()
        {
            this.Email = "emanuelmeira@outlook.com";
            this.Name = "Emanuel Meira";
            this.Skype = "EmamitSkype";
            this.Phone = "557199325148";
            this.Linkedin = "https://br.linkedin.com/in/emanuel";
            this.City = "Salvador";
            this.State = "Bahia";
            this.Portfolio = "www.portifolio.com";            
            this.Pretension = "20";
            this.Bank_Information = "information bank";

            this.Bank_Name = "Banco inter";
            this.Bank_Agency = "0154";
            this.Bank_cpf = "12345678901";
            this.Bank_Account_Number = "21544444";

            this.Crud = "www.github.com/teste";
            this.Other_knowledge = "Xamarin Forms";
        }

        public string Email { get; set; }
        public string Name { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Linkedin { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Portfolio { get; set; }
        public string Pretension { get; set; }
        public string Bank_Information { get; set; }
        
        public string Bank_Name { get; set; }
        public string Bank_Agency { get; set; }
        public string Bank_cpf { get; set; }
        public string Bank_Account_Number { get; set; }

        public string Other_knowledge { get; set; }
        public string Crud { get; set; }
    }
}
