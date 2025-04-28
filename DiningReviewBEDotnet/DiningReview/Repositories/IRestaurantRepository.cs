using DiningReview.Models;

namespace DiningReview.Repositories
{
    public interface IRestaurantRepository
    {
        Restaurant FindById(long id);
        Restaurant Save(Restaurant restaurant);
        IEnumerable<Restaurant> FindAll();
        void Update(Restaurant restaurant);
    }
}