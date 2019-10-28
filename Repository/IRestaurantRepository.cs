using System.Collections.Generic;
using AppRestaurant.Models;

namespace AppRestaurant.Repository
{
    public interface IRestaurantRepository
    {
         void Create(Restaurant restaurant);

         void Update(Restaurant restaurant);

         void Delete(int id);

         Restaurant GetById(int id);

         List<Restaurant> GetAll();
    }
}