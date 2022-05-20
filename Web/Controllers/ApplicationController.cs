using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
	public class ApplicationController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult AfterSeventhGrade()
		{
			return View();
		}

		[HttpGet]
		public IActionResult AfterFourthGrade()
		{
			return View();
		}
	}
}
