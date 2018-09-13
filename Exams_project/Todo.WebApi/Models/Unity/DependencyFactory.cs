using System.Web.Http;
using TODO.WebApi.Models.DataAccess;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;
using TODO.WebApi.Models.MockDataBase;
using TODO.WebApi.Models.Repositories;
using TODO.WebApi.Models.Services;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace TODO.WebApi.Models.Unity
{
	public static class DependencyFactory
	{

		public static IUnityContainer Container;

		public static void Initialize()
		{
			Container = new UnityContainer();

            Container.RegisterInstance("ConnectionString", "LocalDbConnection", new ContainerControlledLifetimeManager());
            var cs = new InjectionConstructor(new ResolvedParameter<string>("ConnectionString"));
            Container.RegisterType<MyContext>(new ContainerControlledLifetimeManager(), cs);

            Container.RegisterType<IRepository<User>, ProjectRepository>();
			Container.RegisterType<IMockDb, MockProjectsDb>();
			Container.RegisterType<IProjectService, ProjectService>();
		}
	}
}