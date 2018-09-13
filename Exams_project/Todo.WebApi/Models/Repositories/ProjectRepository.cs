using System.Collections.Generic;
using TODO.WebApi.Models.DataAccess;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;

namespace TODO.WebApi.Models.Repositories
{
    public class ProjectRepository : IRepository<User>
	{

        private MyContext _context;

		public ProjectRepository(MyContext context)
		{
            _context = context;
		}

        public void Add(User item)
        {
            _context.UserSet.Add(item);
        }

        public IEnumerable<User> ReadAll()
		{
            return _context.UserSet;
		}
	}
}