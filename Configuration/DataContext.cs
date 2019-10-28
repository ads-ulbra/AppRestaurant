using AppRestaurant.Models;
using Microsoft.EntityFrameworkCore;

namespace AppRestaurant.Configuration
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurant { get; set; }
    }
}