using DataAccess.Models;
using System.Collections.Generic;

namespace Web.Models
{
	public class CategoryViewModel
	{
		public List<Article> Articles { get; set; }

		public string Heading { get; set; }
	}
}
