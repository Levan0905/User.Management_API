using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management_Domain.Repository;
using User.Managment._Domain.Data;

namespace User.Management_DataAccess.Implementation
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public INewUserRepository NewUser { get; private set; }
        public IRoleRepository Role { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            NewUser=new NewUserRepository(_context);
            Role=new RoleRepository(_context);
        }

        public int Save() 
        {
            return _context.SaveChanges();
        
        }
        public void Dispose() 
        { 
            _context.Dispose();
        
        }
    }
}
