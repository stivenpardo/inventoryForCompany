using System;
using System.Collections;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryFull.Domain.Core.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        IUnitOfWork UnitOfWork { get; }
        public Task<T> Insert<T>(T entity) where T : class;
        public bool Update<T>(T entity) where T : class;
        public bool Delete<T>(T entity) where T : class;
        public IEnumerable SearchMatching<T>(Expression<Func<T, bool>> predicate) where T : class;
        public T SearchMatchingOneResult<T>(Expression<Func<T, bool>> predicate) where T : class;
        public IEnumerable GetAll<T>() where T : class;
    }
}
