using Microsoft.EntityFrameworkCore;
using User.Management_Domain.Entities;

namespace User.Management_Domain.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Entities.User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
