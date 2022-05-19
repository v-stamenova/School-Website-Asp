using System.Collections.Generic;

namespace DataAccess.Models
{
	public class User
	{
		public User()
		{
			this.Articles = new List<Article>();
		}

		public string Username { get; set; }

		public string Password { get; set; }

		public ICollection<Article> Articles { get; set; }
	}
}
