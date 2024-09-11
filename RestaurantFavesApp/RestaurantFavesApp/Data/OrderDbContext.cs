using Microsoft.EntityFrameworkCore;
using RestaurantFavesApp.Models;
namespace RestaurantFavesApp.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
    }
}
