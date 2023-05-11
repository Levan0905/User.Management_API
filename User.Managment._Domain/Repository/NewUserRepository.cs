using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management_Domain.Entities;
using User.Management_Domain.Repository;
using User.Managment._Domain.Data;

namespace User.Management_DataAccess.Implementation
{
    public class NewUserRepository: GenericRepository<NewUser>, INewUserRepository
    {
        public NewUserRepository(ApplicationDbContext context): base(context)
        {
            
        }
    }
}
