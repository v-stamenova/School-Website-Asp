﻿using DataAccess.Models;
using DataAccess.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/normDocuments/regulations")]
		public IActionResult Regulations()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("NormDocument").Where(x => x.NormType.Value == NormDocumentType.Regulation).ToList();
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/normDocuments/orders")]
		public IActionResult Orders()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("NormDocument").Where(x => x.NormType.Value == NormDocumentType.Order).ToList();
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/normDocuments/schoolDocs")]
		public IActionResult SchoolDocs()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("NormDocument").Where(x => x.NormType.Value == NormDocumentType.School).ToList();
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/projects")]
		public IActionResult Projects()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("Project");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/budget")]
		public IActionResult Budget()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("Budget");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/buyerProfile")]
		public IActionResult BuyerProfile()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("BuyerProfile");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/helpfulLinks")]
		public IActionResult HelpfulLinks()
		{
			List<Article> articles = this._articleService.GetArticlesFromType("HelpfulLink");
			return View("ArticlesWithoutDate", articles);
		}

		[HttpGet]
		[Route("forSchool/graduates")]
		public IActionResult Graduates()
		{
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
