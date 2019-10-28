using System.Collections.Generic;
using System.Linq;
using AppRestaurant.Configuration;
using AppRestaurant.Models;

namespace AppRestaurant.Repository
{
    public class RestaurantConsumptionRepository : IRestaurantConsumptionRepository
    {
        private DataContext context;

        public RestaurantConsumptionRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(RestaurantConsumption restaurantConsumption)
        {
            context.restaurantConsumption.Add(restaurantConsumption);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.restaurantConsumption.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<RestaurantConsumption> GetAll()
        {
            return context.restaurantConsumption.ToList();
        }

        public RestaurantConsumption GetById(int id)
        {
            return context.restaurantConsumption.SingleOrDefault(restaurantConsumption => restaurantConsumption.id == id);
        }

        public void Update(RestaurantConsumption restaurantConsumption)
        {
            var objRestaurantConsumption = GetById(restaurantConsumption.id);
            objRestaurantConsumption.date = restaurantConsumption.date;
            objRestaurantConsumption.value = restaurantConsumption.value;
            objRestaurantConsumption.restaurant = restaurantConsumption.restaurant;
            context.SaveChanges();
        }
    }
}