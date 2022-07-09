using AKARCAFE.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AKARCAFE.Core.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T  : IEntity , new ()
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T GetObject(Expression<Func<T, bool>> where = null, params Expression<Func<T, object>>[] includeProperty);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where = null, params Expression<Func<T, object>>[] includeProperty);

    }
}
