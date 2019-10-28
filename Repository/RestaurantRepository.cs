using System.Collections.Generic;
using System.Linq;
using AppRestaurant.Configuration;
using AppRestaurant.Models;

namespace AppRestaurant.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private DataContext context;

        public RestaurantRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Restaurant restaurant)
        {
            context.restaurant.Add(restaurant);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.restaurant.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Restaurant> GetAll()
        {
            return context.restaurant.ToList();
        }

        public Restaurant GetById(int id)
        {
            return context.restaurant.SingleOrDefault(restaurant => restaurant.id == id);
        }

        public void Update(Restaurant restaurant)
        {
            var objRestaurant = GetById(restaurant.id);
            objRestaurant.name = restaurant.name;
            objRestaurant.address = restaurant.address;
            objRestaurant.number = restaurant.number;
            objRestaurant.city = restaurant.city;
            objRestaurant.state = restaurant.state;
            context.SaveChanges();
        }
    }
}
