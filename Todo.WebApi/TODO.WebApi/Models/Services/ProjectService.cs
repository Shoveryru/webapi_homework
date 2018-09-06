using System.Collections.Generic;
using System.Threading.Tasks;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;

namespace TODO.WebApi.Models.Services
{
	public class ProjectService : IProjectService
	{

		private readonly IRepository<Project> _repository;

		public ProjectService(IRepository<Project> repository)
		{
			_repository = repository;
		}

		public async Task<IEnumerable<Project>> ReadAll()
		{
			return await _repository.ReadAll();
		}
	}
}