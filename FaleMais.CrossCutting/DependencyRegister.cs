using FaleMais.Dominio.User.Repositories;
using FaleMais.Infra.Persistence.Contexts;
using FaleMais.Infra.Repositories.User;
using FaleMais.Infra.Transaction;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace FaleMais.CrossCutting
{
    public static class DependencyRegister
    {
       /* public static void Register(UnityContainer container)
        {
            container.RegisterType<FaleMaisDataContext, FaleMaisDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<IPlanRepository, PlanRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IAreaCodeRepository, AreaCodeRepository>(new HierarchicalLifetimeManager());
        }*/

        public static void Register()
        {
            var container = new UnityContainer();
            container.RegisterType<FaleMaisDataContext, FaleMaisDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<IPlanRepository, PlanRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IAreaCodeRepository, AreaCodeRepository>(new HierarchicalLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
