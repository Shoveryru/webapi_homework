using System;
using System.Collections.Generic;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;

namespace TODO.WebApi.Models.MockDataBase
{
	public class MockProjectsDb : IMockDb
	{
		public IEnumerable<Project> DateBase { get; } = new List<Project>
		{
			new Project
			{
				Id = 1,
				Title = "Angular 6  CSS  HTTP",
				DateCreated = DateTime.Today
			},
			new Project
			{
				Id = 2,
				Title = "Web API",
				DateCreated = DateTime.Today
			},
			new Project
			{
				Id = 3,
				Title = "ASP.NET Core 2.1",
				DateCreated = DateTime.Today
			}
		};
	}
}