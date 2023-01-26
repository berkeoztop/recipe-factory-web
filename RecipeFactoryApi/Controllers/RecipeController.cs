using Microsoft.AspNetCore.Mvc;

namespace RecipeFactoryApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RecipeController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		private readonly ILogger<RecipeController> _logger;

		public RecipeController(ILogger<RecipeController> logger)
		{
			_logger = logger;
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<Recipe> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new Recipe
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}
	}
}