using System.Collections.Generic;

namespace DataAccess.Models
{
	public class ArticleType
	{
		public ArticleType()
		{
			this.Articles = new List<Article>();
		}

		public string Name { get; set; }

		public string Heading { get; set; }

		public ICollection<Article> Articles { get; set; }
	}
}
