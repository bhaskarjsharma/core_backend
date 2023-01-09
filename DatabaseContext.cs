using core_backend;
using core_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace core_backend
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}

