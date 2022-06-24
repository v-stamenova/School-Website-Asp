using DataAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace Web.Services
{
	public class ArticleTypeService
	{
		private SchoolDbContext _dbContext;

		public ArticleTypeService(SchoolDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public ArticleType GetType(string name) => this.GetTypes().FirstOrDefault(x => x.Name == name);

		public List<ArticleType> GetTypes() => this._dbContext.Types.ToList();
	}
}
