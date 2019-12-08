using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kimberly_DPSM.Interfaces
{
    public interface IRepository<T>
    {
        bool Any(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> GetbyCriteria(Expression<Func<T, bool>> expression);

        Task<T> GetById(Expression<Func<T, bool>> expresion);

        Task<int> CreateEntity(T entity);

        Task<int> UpdateEntity(T entity);
    }
}
