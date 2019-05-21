using System.Web.Mvc;
using FaleMais.Dominio.User.Repositories;
using FaleMais.Infra.Persistence.Contexts;
using FaleMais.Infra.Repositories.User;
using FaleMais.Infra.Transaction;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace FaleMais.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
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