using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RecipeFactory.Models;
using RecipeFactoryWeb.Data;
using RecipeFactoryWeb.Models;

namespace RecipeFactory.Controllers;

public class HomeController : Controller
{
	private readonly ApplicationDbContext _db;

	public HomeController(ApplicationDbContext db)
	{
		_db = db;
	}

	public IActionResult Index()
	{
		IEnumerable<Recipe> objRecipeList = _db.Recipes;
		return View(objRecipeList);
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