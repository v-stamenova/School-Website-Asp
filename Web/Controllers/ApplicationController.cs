using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
	public class ApplicationController : Controller
	{
		private ArticleService _articleService;

		public ApplicationController(ArticleService articleService)
		{
			this._articleService = articleService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult AfterSeventhGrade()
		{
			CategoryViewModel model = new CategoryViewModel();
			model.Articles = this._articleService.GetArticlesFromType("AfterSeventhGrade");
			model.Heading = "След 7. клас";
			return View("Category", model);
		}

		[HttpGet]
		public IActionResult AfterFourthGrade()
		{
			CategoryViewModel model = new CategoryViewModel();
			model.Articles = this._articleService.GetArticlesFromType("AfterFourthGrade");
			model.Heading = "След 4. клас";
			return View("Category", model);
		}

		[HttpGet]
		public IActionResult Course()
		{
			CategoryViewModel model = new CategoryViewModel();
			model.Articles = this._articleService.GetArticlesFromType("Course");
			model.Heading = "Курсове";
			return View("Category", model);
		}

		[HttpGet]
		public IActionResult SchoolPlan()
		{
			CategoryViewModel model = new CategoryViewModel();
			model.Articles = this._articleService.GetArticlesFromType("SchoolPlan");
			model.Heading = "Учебен план";
			return View("Category", model);
		}
	}
}
