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

		public ArticleController(IWebHostEnvironment webHost, ArticleService articleService)
		{
			this._webHost = webHost;
			this._articleService = articleService;
		}

		public IActionResult Index()
		{
			List<Article> articles = this._articleService.GetArticles().OrderByDescending(x => x.CreatedOn).ToList();
			return View(articles);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View(new CreateArticleViewModel());

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
		public IActionResult Create(CreateArticleViewModel model)
		{
			if (ModelState.IsValid)
			{
				Article article = new Article();
				article.Title = model.Title;
				article.Content = model.Content;
				article.Subtitle = model.Subtitle;
				article.CreatedOn = DateTime.Now;
				article.PostedBy = null;

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
