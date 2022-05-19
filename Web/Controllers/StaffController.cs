using Microsoft.AspNetCore.Mvc;
using Web.Services;

namespace Web.Controllers
{
	public class StaffController : Controller
	{
		private TeacherService _teacherService;
		private EmployeeService _employeeService;
		private MemberService _memberService;

		public StaffController(TeacherService teacherService, EmployeeService employeeService, MemberService memberService)
		{
			this._teacherService = teacherService;
			this._employeeService = employeeService;
			this._memberService = memberService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Leading()
		{
			return View(this._teacherService.GetLeadingTeam());
		}

		[HttpGet]
		public IActionResult Administration()
		{
			return View(this._employeeService.GetAdministration());
		}

		[HttpGet]
		public IActionResult Specialists()
		{
			return View();
		}

		[HttpGet]
		public IActionResult HeadTeachers()
		{
			return View("Teachers", this._teacherService.GetHeadTeachers());
		}

		[HttpGet]
		public IActionResult Teachers()
		{
			return View(this._teacherService.GetTeachers());
		}

		[HttpGet]
		public IActionResult SchoolBoard()
		{
			return View("Board", this._memberService.GetSchoolBoardMembers());
		}

		[HttpGet]
		public IActionResult MuncipalityBoard()
		{
			return View("Board", this._memberService.GetMuncipalityBoardMembers());
		}
	}
}
