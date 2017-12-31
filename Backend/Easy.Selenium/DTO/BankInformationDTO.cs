using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Selenium.DTO
{
    public class BankInformationDTO
    {

        public BankInformationDTO()
        {
            this.Name = "Emanuel Meira";
            this.CPF = "123456789";
            this.Bank = "Santander";
            this.Agency = "1234";
            this.Account = "1234324234";

            this.Chain = true;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Bank { get; set; }
        public string Agency { get; set; }
        public string Account { get; set; }

        //Account Type 
        public bool Chain { get; set; }
        public bool Savings { get; set; }
    }
}
