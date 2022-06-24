using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
	public class UserController : Controller
	{
		private UserService _userService;
		private ArticleTypeService _typeService;

		public UserController(UserService userService, ArticleTypeService typeService)
		{
			this._userService = userService;
			this._typeService = typeService;
		}

		[HttpGet]
		public IActionResult Login()
		{
			LoginViewModel model = new LoginViewModel();

			return View(model);
		}

		[HttpPost]
		public IActionResult Login(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				try
				{
					string username = model.Username;
					string password = model.Password;
					this._userService.Login(username, password);
				}
				catch (Exception)
				{
					ModelState.AddModelError("loginError", "Невалидно потребителско име или парола");
					return View(model);
				}
			}
			else
			{
				return View(model);
			}

			return RedirectToAction("Index", "Home");
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		[Route("user/articles/{category}")]
		public IActionResult Articles ([FromRoute] string category)
		{
			ArticleType type = this._typeService.GetType(category);
			return View("Category", type);
		}
	}
}
