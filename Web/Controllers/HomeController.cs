using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private ArticleService _articleService;

		public HomeController(ILogger<HomeController> logger, ArticleService articleService)
		{
			_logger = logger;
			this._articleService = articleService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Class()
		{
			return View();
		}

		[HttpGet]
		[Route("home/grading")]
		public IActionResult Grading()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("Grading");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		public IActionResult History()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Documents()
		{
			return View();
		}

		[HttpGet]
		public IActionResult ModelDocuments()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("ModelDocument");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		public IActionResult NormDocuments()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("NormDocument");
			return View("ArticlesWithoutDate", articles);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
