using Easy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Infra.Mappings
{
    class DeveloperMap : EntityTypeConfiguration<Developer>
    {
        public DeveloperMap()
        {
            ToTable("DEVELOPER");

            HasKey(x => x.Id);
            Property(x => x.Email).HasMaxLength(40).IsRequired();
            Property(x => x.Name).HasMaxLength(40).IsRequired();
            Property(x => x.Skype).HasMaxLength(305).IsRequired();
            Property(x => x.Phone).HasMaxLength(30).IsRequired();

            Property(x => x.Linkedin).HasMaxLength(50).IsRequired();
            Property(x => x.City).HasMaxLength(15).IsRequired();
            Property(x => x.State).HasMaxLength(10).IsRequired();
            Property(x => x.Portfolio).HasMaxLength(50).IsRequired();

            Property(x => x.Pretension).IsRequired();
            Property(x => x.Bank).HasMaxLength(20).IsRequired();
            Property(x => x.Crud).HasMaxLength(30).IsRequired();
            
            HasRequired(x => x.BankInf);
            HasRequired(x => x.Knowledge);


        }
    }
}
