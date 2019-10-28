using System;

namespace AppRestaurant.Models
{
    public class RestaurantConsumption
    {
        public RestaurantConsumption()
        {

        }

        public RestaurantConsumption(int id, DateTime date, double value, Restaurant restaurant)
        {
            this.id = id;
            this.date = date;
            this.value = value;
            this.restaurant = restaurant;

        }

        public int id { get; set; }

        public DateTime date { get; set; }

        public double value { get; set; }

        public Restaurant restaurant { get; set; }
    }
}