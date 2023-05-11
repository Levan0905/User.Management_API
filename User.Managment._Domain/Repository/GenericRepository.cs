﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Management_Domain.Repository;
using User.Managment._Domain.Data;

namespace User.Management_DataAccess.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context) 
        {
            _context = context;
        
        }


        public void Add(T entity)
        {
            
            _context.Set<T>().Add(entity);
        }

        public void ChangeRole(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find()
        {
            throw new NotImplementedException();
        }

        public T GetByRole(string rolename)
        {
            throw new NotImplementedException();
        }

        public void SetRole(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
