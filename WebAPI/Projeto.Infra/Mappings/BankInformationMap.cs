using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Infra.Mappings
{
    class BankInformationMap : EntityTypeConfiguration<BankInformation>
    {
        public BankInformationMap()
        {
            ToTable("BANK_INFORMATION");

            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(30).IsRequired();
            Property(x => x.CPF).HasMaxLength(11).IsRequired();
            Property(x => x.Bank).HasMaxLength(15).IsRequired();
            Property(x => x.Agency).HasMaxLength(10).IsRequired();
            Property(x => x.Account).HasMaxLength(25).IsRequired();            
        }

    }
}
