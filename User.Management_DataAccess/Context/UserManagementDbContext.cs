using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management_Domain.Entities;

namespace User.Management_DataAccess.Context
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options) : base(options) 
        {
            
            
        }
        public DbSet<NewUser> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
