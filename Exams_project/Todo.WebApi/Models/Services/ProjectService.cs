using System.Collections.Generic;
using System.Threading.Tasks;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;

namespace TODO.WebApi.Models.Services
{
	public class ProjectService : IProjectService
	{

		private readonly IRepository<User> _repository;

		public ProjectService(IRepository<User> repository)
		{
			_repository = repository;
		}

        public void Add(User item)
        {
            _repository.Add(item);
        }

        public IEnumerable<User> ReadAll()
		{
			return _repository.ReadAll();
		}
	}
}