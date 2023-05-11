using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using User.Management_Domain.Entities;

namespace User.Managment._Domain.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public  DbSet<NewUser> NewUsers { get; set; }
        public DbSet<Role> NewRoles { get; set; }
    }
}