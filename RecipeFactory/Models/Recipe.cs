using System.ComponentModel.DataAnnotations;

namespace RecipeFactoryWeb.Models
{
	public class Recipe
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		public string Name { get; set; }
		
		[Required]
		public string Ingredients { get; set; }
		
		[Required]
		public string Instructions { get; set; }

		[Required]
		public string Type { get; set; }

		public string? Nutritions { get; set; }

		public string? Image { get; set; }

		public DateTime CreatedDateTime { get; set; } = DateTime.Now;
		
	}
}