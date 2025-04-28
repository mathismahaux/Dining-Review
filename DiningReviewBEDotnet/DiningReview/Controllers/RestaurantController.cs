using Microsoft.AspNetCore.Mvc;
using DiningReview.Models;
using DiningReview.Repositories;

namespace DiningReview.Controllers
{
    [ApiController]
    [Route("restaurants")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantController(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        [HttpPost]
        public IActionResult CreateRestaurant([FromBody] Restaurant restaurant)
        {
            var savedRestaurant = _restaurantRepository.Save(restaurant);
            return CreatedAtAction(nameof(GetRestaurant), new { id = savedRestaurant.Id }, savedRestaurant);
        }

        [HttpGet("{id}")]
        public IActionResult GetRestaurant(long id)
        {
            var restaurant = _restaurantRepository.FindById(id);
            if (restaurant == null)
            {
                return NotFound("Restaurant not found.");
            }

            return Ok(restaurant);
        }

        [HttpGet]
        public IActionResult GetAllRestaurants()
        {
            var restaurants = _restaurantRepository.FindAll();
            return Ok(restaurants);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRestaurant(long id, [FromBody] Restaurant restaurant)
        {
            var existingRestaurant = _restaurantRepository.FindById(id);
            if (existingRestaurant == null)
            {
                return NotFound("Restaurant not found.");
            }

            existingRestaurant.Name = restaurant.Name;
            existingRestaurant.Address = restaurant.Address;
            existingRestaurant.Zipcode = restaurant.Zipcode;
            existingRestaurant.PeanutScore = restaurant.PeanutScore;
            existingRestaurant.EggScore = restaurant.EggScore;
            existingRestaurant.DairyScore = restaurant.DairyScore;
            existingRestaurant.OverallScore = restaurant.OverallScore;

            _restaurantRepository.Update(existingRestaurant);
            return NoContent();
        }
    }
}