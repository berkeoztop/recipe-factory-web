using Microsoft.EntityFrameworkCore;
using RecipeFactoryWeb.Models;

namespace RecipeFactoryWeb.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Recipe> Recipes { get; set; }
	}
}
