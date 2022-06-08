using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Helpers;
using Web.Services;

namespace Web.Controllers
{
	public class GraduateController : Controller
	{
		private GraduateService _graduateService;

		public GraduateController(GraduateService graduateService)
		{
			this._graduateService = graduateService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		[Route("student/add")]
		public IActionResult AddStudent()
		{
			return View(new Student());

			//if (Logged.IsLogged())
			//{
			//	return View(new Student());
			//}
			//else
			//{
			//	return Unauthorized();
			//}
		}

		[HttpPost]
		[Route("student/add")]
		public IActionResult AddStudent([FromForm]Student student)
		{
			this._graduateService.AddStudent(student);
			return RedirectToAction("AddStudent", "Graduate");
		}

		[HttpGet]
		[Route("graduate/classOf/{year}")]
		public IActionResult ClassOf([FromRoute] string year)
		{
			List<Class> classes = this._graduateService.GetClassesOfYear(year);
			return View(classes);
		}
	}
}
