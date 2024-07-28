using Microsoft.EntityFrameworkCore;

namespace CoffeeShopRegistration.Models.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	//What tables are in my database?
	public DbSet<User> Users { get; set; }
}
