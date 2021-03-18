using InventoryFull.Domain.Core.Base;
using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InvetoryFull.Infrastructure.Data.Persistence.Core.Base
{
    public abstract class RepositoryBase<TGeneric> : IRepositoryBase<TGeneric> where TGeneric : class
    {
        private readonly IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork => _unitOfWork;

        public RepositoryBase(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
        public async Task<T> Insert<T>(T entity) where T : class
        {
            var response = await _unitOfWork.Set<T>().AddAsync(entity);
            _unitOfWork.Commit();
            return response.Entity;
        }
        public bool Update<T>(T entity) where T : class
        {
            try
            {
                var response = _unitOfWork.Set<T>().Update(entity);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool Delete<T>(T entity) where T : class
        {
            try
            {
                var entityToDelete = _unitOfWork.Set<T>().First(x => x == entity);
                _unitOfWork.Set<T>().Remove(entityToDelete);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable SearchMatching<T>(Expression<Func<T, bool>> predicate) where T : class =>
            _unitOfWork.Set<T>().Where(predicate);

        public IEnumerable GetAll<T>() where T : class => _unitOfWork.Set<T>().ToArray();

        public T SearchMatchingOneResult<T>(Expression<Func<T, bool>> predicate) where T : class =>
            _unitOfWork.Set<T>().First(predicate);

    }
}
