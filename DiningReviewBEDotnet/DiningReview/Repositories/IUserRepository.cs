using DiningReview.Models;

namespace DiningReview.Repositories
{
    public interface IUserRepository
    {
        bool ExistsByDisplayName(string displayName);
        User FindByDisplayName(string displayName);
        User Save(User user);
    }
}