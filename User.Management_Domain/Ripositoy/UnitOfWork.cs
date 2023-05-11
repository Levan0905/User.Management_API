using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management_Domain.Data;
using User.Management_Domain.Repository;

namespace User.Management_DataAccess.Implementation
{
    public class UnitOfWork: IUnitOfWork
    {
        public readonly ApplicationDbContext _context;
       
        public IUserRepository NewUser { get; private set; }
        public IRoleRepository Role { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            NewUser = new UserRepository(_context);
            Role = new RoleRepository(_context);
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
