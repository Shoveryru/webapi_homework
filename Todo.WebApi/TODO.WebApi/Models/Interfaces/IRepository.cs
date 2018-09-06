using System.Collections.Generic;
using System.Threading.Tasks;

namespace TODO.WebApi.Models.Interfaces
{
	/// <summary>
	/// Интерфейс для репозиториев.
	/// </summary>
	public interface IRepository<T> where T : class
	{
		/// <summary>
		/// Метод чтения всех проектов из базы данных.
		/// </summary>
		Task<IEnumerable<T>> ReadAll();
	}
}