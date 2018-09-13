using System.Collections.Generic;
using System.Threading.Tasks;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;

namespace TODO.WebApi.Models.Repositories
{
	public class ProjectRepository : IRepository<Project>
	{

		private readonly IEnumerable<Project> _localStorage;

		public ProjectRepository(IMockDb mockDb)
		{
			_localStorage = mockDb.DateBase;
		}

		public async Task<IEnumerable<Project>> ReadAll()
		{
			return await Task.FromResult(_localStorage);
		}
	}
}