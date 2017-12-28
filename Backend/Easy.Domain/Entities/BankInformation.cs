namespace Easy.Domain.Entities
{
    public class BankInformation
    {
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
