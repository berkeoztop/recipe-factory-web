using Microsoft.AspNetCore.Mvc;
using RecipeFactoryWeb.Data;
using RecipeFactoryWeb.Models;

namespace RecipeFactoryWeb.Controllers;

public class RecipeController : Controller
{
	private readonly ApplicationDbContext _db;

	public RecipeController(ApplicationDbContext db)
	{
		_db = db;
	}

	public IActionResult Index()
	{
		IEnumerable<Recipe> objRecipeList = _db.Recipes;
		return View(objRecipeList);
	}

	public IActionResult RecipeDetail()
	{
		IEnumerable<Recipe> objRecipeList = _db.Recipes;
		return View(objRecipeList);
	}


	public IActionResult SearchResult()
	{
		IEnumerable<Recipe> objRecipeList = _db.Recipes;
		return View(objRecipeList);
	}

	//GET
	public IActionResult Create()
	{
		return View();
	}

	//POST
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult Create(Recipe obj)
	{
		if (ModelState.IsValid)
		{
			_db.Recipes.Add(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		return View(obj);
	}

	//GET
	public IActionResult Edit(int? id)
	{
		if (id == null || id == 0) return NotFound();
		var recipeFromDb = _db.Recipes.Find(id);

		if (recipeFromDb == null) return NotFound();

		return View(recipeFromDb);
	}

	//POST
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult Edit(Recipe obj)
	{
		if (ModelState.IsValid)
		{
			_db.Recipes.Update(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		return View(obj);
	}

	//GET
	public IActionResult Delete(int? id)
	{
		if (id == null || id == 0) return NotFound();
		var recipeFromDb = _db.Recipes.Find(id);

		if (recipeFromDb == null) return NotFound();

		return View(recipeFromDb);
	}

	//POST
	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult DeletePost(int? id)
	{
		var obj = _db.Recipes.Find(id);
		if (obj == null) return NotFound();

		_db.Recipes.Remove(obj);
		_db.SaveChanges();
		return RedirectToAction("Index");
	}
}