using System.Collections.Generic;
using System.Threading.Tasks;
using TODO.WebApi.Models.Entities;

namespace TODO.WebApi.Models.Interfaces
{
	/// <summary>
	/// Сервис проектов.
	/// </summary>
	public interface IProjectService
	{
		/// <summary>
		/// Получить все проекты из базы.
		/// </summary>
		/// <returns></returns>
		Task<IEnumerable<Project>> ReadAll();
	}
}