using FaleMais.Dominio.User.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FaleMais.Infra.Persistence.Mappings
{
    public class PlanMapping : EntityTypeConfiguration<Plan>
    {
        public PlanMapping()
        {
            ToTable("Plan");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Name).IsRequired().HasMaxLength(50);

        }
    }
}
