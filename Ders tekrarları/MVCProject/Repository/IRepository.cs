using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(int id);
        IEnumerable<TEntity> GetAll();
        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);
    }
}
