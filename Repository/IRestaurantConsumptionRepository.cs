using System.Collections.Generic;
using AppRestaurant.Models;

namespace AppRestaurant.Repository
{
    public interface IRestaurantConsumptionRepository
    {
        void Create(RestaurantConsumption restaurant);

         void Update(RestaurantConsumption restaurant);

         void Delete(int id);

         RestaurantConsumption GetById(int id);

         List<RestaurantConsumption> GetAll();   
    }
}