using AppRestaurant.Models;
using Microsoft.EntityFrameworkCore;

namespace AppRestaurant.Configuration
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> restaurant { get; set; }

        public DbSet<RestaurantConsumption> restaurantConsumption { get; set; }
    }
}