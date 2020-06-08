using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;



namespace BlogCore.AccesoDatos.Data.Repository
{
    public interface IRepository<T> where T : class
    {

        T Get(int id);

        IEnumerable<T> GetAll(

            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy= null,
            string includePropertis = null
            );

        T GetFirstOrDefault(

            Expression<Func<T, bool>> filter = null,
            string includePropertis = null
            );

        void Add(T entity);

        void Remove(int id);

        void Remove(T intity);

    }
}
