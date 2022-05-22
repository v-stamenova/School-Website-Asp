using DataAccess;
using DataAccess.Models;
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

		public ArticleType GetType(string name) => this._dbContext.Types.FirstOrDefault(x => x.Name == name);
	}
}
