using System.Linq.Expressions;

namespace Pay.Data.Infrestructure
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Insert
        void Insert(TEntity entity);
        Task InsertAsync(TEntity entity);
        #endregion
        #region Update
        void Update(TEntity entity);
        #endregion
        #region Delete
        void Delete(object id);
        void Delete(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);
        #endregion
        #region Get
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> where);
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<IEnumerable<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where);
        #endregion
    }
}
