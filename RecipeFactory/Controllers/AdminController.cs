using Microsoft.AspNetCore.Mvc;

namespace RecipeFactory.Controllers
{
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
