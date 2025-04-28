using Microsoft.AspNetCore.Mvc;
using DiningReview.Models;
using DiningReview.Repositories;

namespace DiningReview.Controllers
{
    [ApiController]
    [Route("dining-reviews")]
    public class DiningReviewController : ControllerBase
    {
        private readonly IDiningReviewRepository _diningReviewRepository;
        private readonly IRestaurantRepository _restaurantRepository;

        public DiningReviewController(IDiningReviewRepository diningReviewRepository, IRestaurantRepository restaurantRepository)
        {
            _diningReviewRepository = diningReviewRepository;
            _restaurantRepository = restaurantRepository;
        }

        [HttpPost]
        public IActionResult SubmitReview([FromBody] Models.DiningReview review)
        {
            var restaurant = _restaurantRepository.FindById(review.RestaurantId);
            if (restaurant == null)
            {
                return NotFound("Restaurant not found.");
            }

            var savedReview = _diningReviewRepository.Save(review);
            return CreatedAtAction(nameof(GetReview), new { id = savedReview.Id }, savedReview);
        }

        [HttpGet("{id}")]
        public IActionResult GetReview(long id)
        {
            var review = _diningReviewRepository.FindById(id);
            if (review == null)
            {
                return NotFound("Review not found.");
            }

            return Ok(review);
        }

        [HttpGet("restaurant/{restaurantId}")]
        public IActionResult GetReviewsByRestaurant(long restaurantId)
        {
            var reviews = _diningReviewRepository.FindByRestaurantId(restaurantId);
            return Ok(reviews);
        }

        [HttpPut("{id}/status")]
        public IActionResult UpdateReviewStatus(long id, [FromBody] DiningReviewStatus status)
        {
            var review = _diningReviewRepository.FindById(id);
            if (review == null)
            {
                return NotFound("Review not found.");
            }

            review.Status = status;
            _diningReviewRepository.Update(review);
            return NoContent();
        }
    }
}