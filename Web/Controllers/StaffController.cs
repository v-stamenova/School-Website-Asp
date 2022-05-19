using Microsoft.AspNetCore.Mvc;
using Web.Services;

namespace Web.Controllers
{
	public class StaffController : Controller
	{
		private TeacherService _teacherService;

		public StaffController(TeacherService teacherService)
		{
			this._teacherService = teacherService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Leading()
		{
			return View(_teacherService.GetLeadingTeam());
		}
	}
}
