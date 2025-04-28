using DiningReview.Data;
using DiningReview.Models;

namespace DiningReview.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool ExistsByDisplayName(string displayName)
        {
            return _context.Users.Any(u => u.DisplayName == displayName);
        }

        public User FindByDisplayName(string displayName)
        {
            return _context.Users.FirstOrDefault(u => u.DisplayName == displayName);
        }

        public User Save(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}