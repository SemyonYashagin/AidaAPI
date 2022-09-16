using Microsoft.EntityFrameworkCore;

namespace AIDA_API.Models
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options) { 
            //Database.EnsureCreated();
        }

        public DbSet<User> User { get; set; }
    }
}
