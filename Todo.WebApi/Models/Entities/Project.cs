using System;

namespace TODO.WebApi.Models.Entities
{
	/// <summary>
	/// Задача.
	/// </summary>
	public class Project
	{
		/// <summary>
		/// Ключ для поиска по базе.
		/// </summary>
		public int Id;
		/// <summary>
		/// Название проекта.
		/// </summary>
		public string Title;
		/// <summary>
		/// Дата создания проекта.
		/// </summary>
		public DateTime DateCreated;
	}
}