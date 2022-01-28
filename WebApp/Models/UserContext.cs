using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> TodoItems { get; set; } = null!;
    }
}
