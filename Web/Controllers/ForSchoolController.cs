using DataAccess.Models;
using DataAccess.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Web.Helpers;
using Web.Services;

namespace Web.Controllers
{
	public class ForSchoolController : Controller
	{
		private ArticleService _articleService;

		public ForSchoolController(ArticleService articleService)
		{
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
		[Route("forSchool/grading")]
		public IActionResult Grading()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("Grading");
			Display.PageTitle = "Оценяване";
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
		[Route("forSchool/modelDocuments")]
		public IActionResult ModelDocuments()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("ModelDocument");
			Display.PageTitle = "Документи - образци";
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/normDocuments")]
		public IActionResult NormDocuments()
		{
			return View();
		}

		[HttpGet]
		[Route("forSchool/normDocuments/laws")]
		public IActionResult Laws()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("NormDocument").Where(x => x.NormType.Value == NormDocumentType.Law).ToList();
			Display.PageTitle = "Закони";
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/normDocuments/regulations")]
		public IActionResult Regulations()
		{
			Display.PageTitle = "Наредби";
			List<Article> articles = this._articleService.GetArticlesFromType("NormDocument").Where(x => x.NormType.Value == NormDocumentType.Regulation).ToList();
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/normDocuments/orders")]
		public IActionResult Orders()
		{
			Display.PageTitle = "Заповеди";
			List<Article> articles = this._articleService.GetArticlesFromType("NormDocument").Where(x => x.NormType.Value == NormDocumentType.Order).ToList();
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/normDocuments/schoolDocs")]
		public IActionResult SchoolDocs()
		{
			Display.PageTitle = "Училищни документи";
			List<Article> articles = this._articleService.GetArticlesFromType("NormDocument").Where(x => x.NormType.Value == NormDocumentType.School).ToList();
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/projects")]
		public IActionResult Projects()
		{
			Display.PageTitle = "Проекти";
			List<Article> articles = this._articleService.GetArticlesFromType("Project");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/budget")]
		public IActionResult Budget()
		{
			Display.PageTitle = "Бюджет";
			List<Article> articles = this._articleService.GetArticlesFromType("Budget");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/buyerProfile")]
		public IActionResult BuyerProfile()
		{
			Display.PageTitle = "Профил на купувача";
			List<Article> articles = this._articleService.GetArticlesFromType("BuyerProfile");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/helpfulLinks")]
		public IActionResult HelpfulLinks()
		{
			Display.PageTitle = "Полезни връзки";
			List<Article> articles = this._articleService.GetArticlesFromType("HelpfulLink");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/graduates")]
		public IActionResult Graduates()
		{
			Display.PageTitle = "Наши възпитаници";
			List<Article> articles = this._articleService.GetArticlesFromType("Graduate");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/contact")]
		public IActionResult Contact()
		{
			return View();
		}
	}
}
