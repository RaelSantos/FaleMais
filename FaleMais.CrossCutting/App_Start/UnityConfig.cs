using FaleMais.Dominio.User.Repositories;
using FaleMais.Infra.Persistence.Contexts;
using FaleMais.Infra.Repositories.User;
using FaleMais.Infra.Transaction;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace FaleMais.CrossCutting
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<FaleMaisDataContext, FaleMaisDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<IPlanRepository, PlanRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IAreaCodeRepository, AreaCodeRepository>(new HierarchicalLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}