﻿using FaleMais.Dominio.User.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FaleMais.Infra.Persistence.Mappings
{
    public class AreaCodeSourceMapping : EntityTypeConfiguration<AreaCodeSource>
    {
        public AreaCodeSourceMapping()
        {
            ToTable("AreaCodeSource");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Code).IsRequired().HasMaxLength(3);
        }
    }
}
