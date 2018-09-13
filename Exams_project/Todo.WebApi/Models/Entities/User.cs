using System;

namespace TODO.WebApi.Models.Entities
{
	/// <summary>
	/// Задача.
	/// </summary>
	public class User
	{
		public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; } 
    }
}