﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantDataAccessLayer.IRepository
{
  
   
        public interface IRepositoryBase<T>
        {
            void Insert(T entity);
            void Delete(T entity);
            IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
            IQueryable<T> GetAll();
        }
    
}
