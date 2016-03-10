using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateMePlease.Entities
{
	public class Profile
	{
		public int Id { get; set; }

		public string LookingFor { get; set; }
		public string Introduction { get; set; }
		public string Pitch { get; set; }

		public Member Member { get; set; }
		public Demographics Demographics { get; set; }

		public ICollection<Interest> Interests { get; set; }
		public ICollection<Photo> Photos { get; set; }
	}
}
