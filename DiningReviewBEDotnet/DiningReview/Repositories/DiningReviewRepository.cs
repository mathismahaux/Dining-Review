using DiningReview.Data;
using DiningReview.Models;

namespace DiningReview.Repositories
{
    public class DiningReviewRepository : IDiningReviewRepository
    {
        private readonly ApplicationDbContext _context;

        public DiningReviewRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.DiningReview Save(Models.DiningReview review)
        {
            _context.DiningReviews.Add(review);
            _context.SaveChanges();
            return review;
        }

        public IEnumerable<Models.DiningReview> FindByRestaurantId(long restaurantId)
        {
            return _context.DiningReviews.Where(r => r.RestaurantId == restaurantId).ToList();
        }

        public Models.DiningReview FindById(long id)
        {
            return _context.DiningReviews.FirstOrDefault(r => r.Id == id);
        }

        public void Update(Models.DiningReview review)
        {
            _context.DiningReviews.Update(review);
            _context.SaveChanges();
        }
    }
}