using System.Web;
using System.Web.Optimization;

namespace TODO.WebApi
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			#region Libraries

			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
				"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
				"~/Scripts/bootstrap.js"));

			bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
				"~/Scripts/knockout-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/popper").Include(
				"~/Scripts/umd/popper.js",
				"~/Scripts/umd/popper-utils.js"));

			bundles.Add(new ScriptBundle("~/bundles/momentjs").Include(
				"~/Scripts/moment-with-locales.js"));

			bundles.Add(new ScriptBundle("~/bundles/lodash").Include(
				"~/Scripts/lodash.js",
				"~/Scripts/lodash.core.js"));

			#endregion

			// View Models & Styles

			bundles.Add(new ScriptBundle("~/bundles/projects-view-model").Include(
				"~/Scripts/custom/ProjectsViewModel.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/bootstrap.css",
				"~/Content/site.css"));
		}
	}
}
