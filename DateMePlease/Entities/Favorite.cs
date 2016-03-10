using System;

namespace DateMePlease.Entities
{
	public class Favorite
	{
		public int Id { get; set; }

		public int MemberId { get; set; }
		public DateTime DateFavorited { get; set; }
	}
}