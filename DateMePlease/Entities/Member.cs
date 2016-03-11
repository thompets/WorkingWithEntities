using System;
using System.Collections.Generic;

namespace DateMePlease.Entities
{
	public class Member
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public DateTime LastLogin { get; set; }
		public DateTime Created { get; set; }

		public Profile Profile { get; set; }

		public ICollection<Message> Messages { get; set; }
		public ICollection<Favorite> Favorites { get; set; }
	}	
}
