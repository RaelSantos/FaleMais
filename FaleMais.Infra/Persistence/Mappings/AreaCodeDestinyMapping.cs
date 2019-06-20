using FaleMais.Dominio.User.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FaleMais.Infra.Persistence.Mappings
{
    public class AreaCodeDestinyMapping : EntityTypeConfiguration<AreaCodeDestiny>
    {
        public AreaCodeDestinyMapping()
        {
            ToTable("AreaCodeDestiny");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Code).IsRequired().HasMaxLength(3);
        }
    }
}
