namespace Easy.Domain.Entities
{
    public class Developer
    {       
        
        public int Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Linkedin { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Portfolio { get; set; }
        
        public bool HourUntilFour { get; set; }
        public bool HourFourToSix { get; set; }
        public bool HourSixToEight { get; set; }
        public bool HourAboveEight { get; set; }
        public bool HoursOfWeekend { get; set; }
               

        public bool MorningPeriod { get; set; }
        public bool AfternoonPeriod { get; set; }
        public bool NightPeriod { get; set; }
        public bool DawnPeriod { get; set; }
        public bool BusinessPeriod { get; set; }        

        public int Pretension { get; set; }        
        public string Bank { get; set; }        
        public string Crud { get; set; }

        public int BankInformationId { get; set; }
        public virtual BankInformation BankInf { get; set; }

        public int KnowledgeId { get; set; }
        public virtual Knowledge Knowledge { get; set; }
        
    }
}
