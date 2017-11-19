using Domain.Entities;
using System.Data.Entity;

namespace Projeto.Infra.Context
{
    public class EFContext : DbContext
    {        
        public EFContext() : base("CRUD-EASY")
        {           
        }
        
        public IDbSet<Developer> Developers { get; set; }
        public IDbSet<Knowledge> Knowledge { get; set; }
        public IDbSet<BankInformation> BankInformation { get; set; }
        

        //Factory
        public static EFContext ContextFactory()
        {            
            return new EFContext();
        }
    }
}