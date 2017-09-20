using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using Domain.Entities;

namespace Domain.Context
{
    public class EFContext : DbContext
    {        
        public EFContext() : base("CRUD-EASY")
        {
        }
        
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<BankInformation> BankInformation { get; set; }
        

        //Factory para contexto
        public static EFContext ContextFactory()
        {            
            return new EFContext();
        }
    }
}