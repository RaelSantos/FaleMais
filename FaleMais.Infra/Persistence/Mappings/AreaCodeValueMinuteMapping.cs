using FaleMais.Dominio.User.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FaleMais.Infra.Persistence.Mappings
{
    public class AreaCodeValueMinuteMapping : EntityTypeConfiguration<AreaCodeValueMinute>
    {
        public AreaCodeValueMinuteMapping()
        {
            ToTable("AreaCodeValueMinute");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.ValueMin).IsRequired();
            
            HasRequired(p => p.AreaCodeSource)
              .WithMany()
              .HasForeignKey(p => p.AreaCodeSourceId);

            HasRequired(p => p.AreaCodeDestiny)
            .WithMany()
            .HasForeignKey(p => p.AreaCodeDestinyId);

        }
    }
}
