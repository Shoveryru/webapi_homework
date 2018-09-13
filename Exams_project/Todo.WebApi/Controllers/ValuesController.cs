using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;

namespace TODO.WebApi.Controllers
{
	public class ValuesController : ApiController
	{

		private readonly IProjectService _service;

		public ValuesController(IProjectService service)
		{
			_service = service;
		}

		// GET api/values
		public IEnumerable<User> Get()
		{
			return _service.ReadAll();
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
            var user = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(value);
            _service.Add(user);
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
