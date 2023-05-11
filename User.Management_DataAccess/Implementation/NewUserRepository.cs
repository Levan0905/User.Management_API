using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management_DataAccess.Context;
using User.Management_Domain.Entities;
using User.Management_Domain.Repository;

namespace User.Management_DataAccess.Implementation
{
    public class NewUserRepository: GenericRepository<NewUser>, INewUserRepository
    {
        public NewUserRepository(UserManagementDbContext context) : base(context) 
        {
            
        }
    }
}
