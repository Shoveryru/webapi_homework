using System.Web.Http;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;
using TODO.WebApi.Models.MockDataBase;
using TODO.WebApi.Models.Repositories;
using TODO.WebApi.Models.Services;
using Unity;

namespace TODO.WebApi.Models.Unity
{
	public static class DependencyFactory
	{

		public static IUnityContainer Container;

		public static void Initialize()
		{
			Container = new UnityContainer();
			Container.RegisterType<IRepository<Project>, ProjectRepository>();
			Container.RegisterType<IMockDb, MockProjectsDb>();
			Container.RegisterType<IProjectService, ProjectService>();
		}
	}
}