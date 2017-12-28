using Easy.Domain.Entities;
using Easy.Infra.Mappings;
using Easy.Infra.Mappings.Seed;
using System.Data.Entity;

namespace Easy.Infra.Context
{
    public class EFContext : DbContext
    {        
        public EFContext() : base("CRUD-EASY")
        {
            //Seed Data Initializer
            //Database.SetInitializer<EFContext>( new EasyDataContextInitializer());

            //Proxy off
            Configuration.ProxyCreationEnabled = false;
            //LazyLoad off
            Configuration.LazyLoadingEnabled = false;
        }
        
        public IDbSet<Developer> Developers { get; set; }
        public IDbSet<Knowledge> Knowledge { get; set; }
        public IDbSet<BankInformation> BankInformation { get; set; }
        
        //FluentMap
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BankInformationMap());
            modelBuilder.Configurations.Add(new KnowledgeMap());
            modelBuilder.Configurations.Add(new DeveloperMap());
            base.OnModelCreating(modelBuilder);
        }

        //Factory
        public static EFContext ContextFactory()
        {
            return new EFContext();
        }

    }
}