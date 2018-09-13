using System;
using System.Collections.Generic;
using TODO.WebApi.Models.Entities;
using TODO.WebApi.Models.Interfaces;

namespace TODO.WebApi.Models.MockDataBase
{
	public class MockProjectsDb : IMockDb
	{
		public IEnumerable<User> DateBase { get; } = new List<User>
		{
			new User
			{
				Id = 1,
				FirstName = "Вася",
				LastName = "Васечкин",
                MiddleName = "Васильевич",
                MobilePhone = "+79271234567",
                Email = "vasya@mail.ru"
			},
			new User
			{
                FirstName = "Петя",
                LastName = "Петечкин",
                MiddleName = "Петрович",
                MobilePhone = "+79271234567",
                Email = "petya@mail.ru"
            },
			new User
			{
                FirstName = "Иван",
                LastName = "Иванович",
                MiddleName = "Иванов",
                MobilePhone = "+79271234567",
                Email = "vanya@mail.ru"
            }
		};
	}
}