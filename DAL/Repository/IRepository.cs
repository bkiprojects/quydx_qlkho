using MODEL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Attach(TEntity entityToAttack);
        void SaveWithSyncObjectState(TEntity entityToSave);
        void SaveWithSyncObjectState(IEnumerable<TEntity> listEntityToSave);

        IQueryable<TEntity> GetAll();

        IEnumerable<TEntity> GetManyIEnumerable(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetManyQueryable(Expression<Func<TEntity, bool>> predicate);

        void Insert(TEntity entityToInsert);
        void Insert(IEnumerable<TEntity> listEntityToDelete);


        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void Delete(IEnumerable<TEntity> listEntityToDelete);

        void HardDelete(object id);
        void HardDelete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);
        void Update(IEnumerable<TEntity> listEntityToUpdate);

        TEntity GetByID(long? id);
        bool IsExist(long primaryKey);
        IQueryable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includes);
    }
}
