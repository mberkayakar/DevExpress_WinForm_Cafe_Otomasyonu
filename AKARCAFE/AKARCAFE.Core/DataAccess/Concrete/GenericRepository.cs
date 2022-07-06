using AKARCAFE.Core.DataAccess.Abstract;
using AKARCAFE.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AKARCAFE.Core.DataAccess.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity, new()

    {

        private readonly DbContext _db;
        public GenericRepository(DbContext db)
        {
            _db = db;
        }



        public void Add(T item)
        {

            _db.Set<T>().Add(item);
            _db.SaveChanges();
        
        }

        public void Delete(T item)
        {
            _db.Set<T>().Remove(item);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where = null, params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> model = _db.Set<T>();

            if (where != null)
            {
                model.Where(where);
            }
            if (includeProperty.Any())
            {
                foreach (var item in includeProperty)
                {
                    model = model.Include(item);
                }
            }
            return model;
        }

        public T GetObject(Expression<Func<T, bool>> where = null, params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> model = _db.Set<T>();

            if (where != null)
            {
                model.Where(where);
            }

            if (includeProperty.Any())
            {
                foreach (var item in includeProperty)
                {
                    model = model.Include(item);
                }
            }

            return model.FirstOrDefault();
        }

        public void Update(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }

     
}
