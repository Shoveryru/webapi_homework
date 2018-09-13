using System.Web.Http;
using TODO.WebApi.Models.Unity;

namespace TODO.WebApi
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			DependencyFactory.Initialize();
			config.DependencyResolver = new UnityResolver(DependencyFactory.Container);

			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
