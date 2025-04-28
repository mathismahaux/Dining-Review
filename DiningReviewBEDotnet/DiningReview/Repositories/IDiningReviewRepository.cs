using DiningReview.Models;

namespace DiningReview.Repositories
{
    public interface IDiningReviewRepository
    {
        Models.DiningReview Save(Models.DiningReview review);
        IEnumerable<Models.DiningReview> FindByRestaurantId(long restaurantId);
        Models.DiningReview FindById(long id);
        void Update(Models.DiningReview review);
    }
}