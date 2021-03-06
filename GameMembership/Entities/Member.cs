using GameMembership.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMembership
{
	public class Member:IEntity
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NationalId { get; set; }
		public DateTime DateOfBirth { get; set; }

	}
}
