using FaleMais.Dominio.User.Entities;
using FaleMais.Infra.Persistence.Mappings;
using System.Data.Entity;

namespace FaleMais.Infra.Persistence.Contexts
{
    public class FaleMaisDataContext : DbContext
    {
        public FaleMaisDataContext() : base("FaleMaisConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<AreaCode> AreaCodes { get; set; }
        public DbSet<Plan> Plans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AreaCodeMapping());
            modelBuilder.Configurations.Add(new PlanMapping());
        }

    }
}
