using aadhu.Models;
using Microsoft.EntityFrameworkCore;

namespace aadhu.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserDetails>Employees { get; set; }
    }
}
