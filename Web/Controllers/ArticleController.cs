using DataAccess.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web.Helpers;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
	public class ArticleController : Controller
	{
		private IWebHostEnvironment _webHost;
		private ArticleService _articleService;
		private ArticleTypeService _articleTypeService;

		public ArticleController(IWebHostEnvironment webHost, ArticleService articleService, ArticleTypeService articleTypeService)
		{
			this._webHost = webHost;
			this._articleService = articleService;
			this._articleTypeService = articleTypeService;
		}

		public IActionResult Index()
		{
			List<Article> newsArticles = this._articleService.GetArticlesFromType("news");
			return View(newsArticles);
		}

		[HttpGet]
		[Route("article/create/{typeString}")]
		public IActionResult Create([FromRoute] string typeString)
		{
			CreateArticleViewModel model = new CreateArticleViewModel();
			model.Type = typeString;
			model.Heading = this._articleTypeService.GetType(model.Type).Heading;
			return View(model);

			//if (Logged.IsLogged())
			//{
			//	return View(new CreateArticleViewModel());
			//}
			//else
			//{
			//	return Unauthorized();
			//}
		}

		[HttpPost]
		[Route("article/create/{typeString}")]
		public IActionResult Create([FromForm] CreateArticleViewModel model)
		{
			if (ModelState.IsValid)
			{
				Article article = new Article();
				article.Title = model.Title;
				article.Content = model.Content;
				article.Subtitle = model.Subtitle;
				article.CreatedOn = DateTime.Now;
				article.PostedBy = null;
				article.Type = this._articleTypeService.GetType(model.Type);

				if (model.File != null)
				{
					string patern = Path.Combine(this._webHost.WebRootPath, "files");
					string fileName = Guid.NewGuid() + "-" + model.File.FileName;
					string filePathern = Path.Combine(patern, fileName);

					using (var fileStream = new FileStream(filePathern, FileMode.Create))
					{
						model.File.CopyTo(fileStream);
					}
					article.FilePath = Path.Combine("Files", fileName);
				}
				else
				{
					article.FilePath = null;
				}

				try
				{
					this._articleService.CreateArticle(article);
				}
				catch
				{
					return BadRequest();
				}

				return RedirectToAction("Index", "Article");
			}
			else
			{
				return View(model);
			}
		}
		
		[HttpGet]
		[Route("article/open/{id}")]
		public IActionResult Open([FromRoute] string id)
		{
			return View(this._articleService.GetArticle(id));
		}
	}
}
