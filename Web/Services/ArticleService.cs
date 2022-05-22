using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Web.Services
{
	public class ArticleService
	{
		private SchoolDbContext _dbContext;

		public ArticleService(SchoolDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public List<Article> GetArticles() => this._dbContext.Articles.Include(x => x.PostedBy).ToList();

		public List<Article> GetArticlesFromType(string typeId) => this._dbContext.Articles.Include(x => x.PostedBy)
			.Include(x => x.Type).Where(x => x.TypeId == typeId).OrderByDescending(x => x.CreatedOn).ToList();

		public void CreateArticle(Article article)
		{
			this._dbContext.Add(article);
			this._dbContext.SaveChanges();
		}

		public Article GetArticle(string id) => this.GetArticles().FirstOrDefault(x => x.Id.ToString() == id);
	}
}
