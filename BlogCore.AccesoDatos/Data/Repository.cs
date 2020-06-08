using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BlogCore.AccesoDatos.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace BlogCore.AccesoDatos.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly DbContext Context;
        internal DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            Context = context;
            this.dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
          

            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includePropertis = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);

            }


            //Include propertis separadas por comas

            if (includePropertis != null)
            {
                foreach (var includeProperty in includePropertis.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includePropertis);
                }

            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            return query.ToList();

        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includePropertis = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }


            if (includePropertis != null)
            {
                foreach (var includeProperty in includePropertis.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includePropertis);
                }

            }
            return query.FirstOrDefault();


        }

        public void Remove(int id)
        {
            T entityToRemove = dbSet.Find(id);

            Remove(entityToRemove);
        }

        public void Remove(T intity)
        {
            dbSet.Remove(intity);
        }
    }
}
