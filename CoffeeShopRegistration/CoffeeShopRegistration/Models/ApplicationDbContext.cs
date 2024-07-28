using Microsoft.EntityFrameworkCore;
namespace CoffeeShopRegistration.Models.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}
	//What tables are in my database?
	public DbSet<User> Products { get; set; }
}
