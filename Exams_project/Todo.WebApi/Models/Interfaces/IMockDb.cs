using System.Collections.Generic;
using TODO.WebApi.Models.Entities;

namespace TODO.WebApi.Models.Interfaces
{
	/// <summary>
	/// Для инъекции мок БД.
	/// </summary>
	public interface IMockDb
	{
		IEnumerable<User> DateBase { get; }
	}
}