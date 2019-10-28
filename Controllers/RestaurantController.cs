using AppRestaurant.Models;
using AppRestaurant.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AppRestaurant.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantRepository restaurantRepository;

        public RestaurantController(IRestaurantRepository restaurantRepository)
        {
            this.restaurantRepository = restaurantRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listRestaurants = restaurantRepository.GetAll();
            return View(listRestaurants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            restaurantRepository.Create(restaurant);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var restaurant = restaurantRepository.GetById(id);
            return View(restaurant);
        }


        [HttpPost]
        public IActionResult Edit(Restaurant restaurant)
        {
            restaurantRepository.Update(restaurant);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            restaurantRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}