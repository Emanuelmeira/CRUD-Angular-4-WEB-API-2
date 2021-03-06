﻿using Easy.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Easy.Infra.Mappings
{
    class BankInformationMap : EntityTypeConfiguration<BankInformation>
    {
        public BankInformationMap()
        {
            ToTable("BANK_INFORMATION");

            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(30);
            Property(x => x.CPF).HasMaxLength(15);
            Property(x => x.Bank).HasMaxLength(15);
            Property(x => x.Agency).HasMaxLength(10);
            Property(x => x.Account).HasMaxLength(25);
        }

    }
}
