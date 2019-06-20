using FaleMais.Dominio.User.Entities;
using FaleMais.Infra.Persistence.Mappings;
using System.Data.Entity;

namespace FaleMais.Infra.Persistence.Contexts
{
    public class FaleMaisDataContext : DbContext
    {
        public FaleMaisDataContext() : base("FaleMais")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

       
        public DbSet<Plan> Plans { get; set; }
        public DbSet<AreaCodeSource> AreaCodeSources { get; set; }
        public DbSet<AreaCodeDestiny> AreaCodeDestinys { get; set; }
        public DbSet<AreaCodeValueMinute> AreaCodeValueMinutes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlanMapping());
            modelBuilder.Configurations.Add(new AreaCodeSourceMapping());
            modelBuilder.Configurations.Add(new AreaCodeDestinyMapping());
            modelBuilder.Configurations.Add(new AreaCodeValueMinuteMapping());
        }
    }
}
