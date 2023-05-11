using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using User.Management_Domain.Repository;
using User.Management_Domain.Data;


namespace User.Management_DataAccess.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context) 
        {
            _context = context;
        
        }

        public virtual Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual  Task<T> Get(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }

     
    }
}
