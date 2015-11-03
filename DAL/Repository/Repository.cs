using DAL.Context;
using MODEL.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected IVTContext _context;
        protected DbSet<TEntity> _dbSet;
        public Repository(IVTContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public virtual void Attach(TEntity entityToAttack)
        {
            _dbSet.Attach(entityToAttack);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }
        public virtual IEnumerable<TEntity> GetManyIEnumerable(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            IEnumerable<TEntity> query = _dbSet.Where(predicate).AsEnumerable();
            return query;
        }
        public virtual IQueryable<TEntity> GetManyQueryable(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }



        public virtual void Insert(TEntity entityToInsert)
        {
            entityToInsert.ObjectState = ObjectState.Added;
            entityToInsert.IsDeleted = false;
            _dbSet.Add(entityToInsert);
            _context.SyncObjectState(entityToInsert);
        }
        public virtual void Insert(IEnumerable<TEntity> listEntityToInsert)
        {
            foreach(var item in listEntityToInsert)
            {
                Insert(item);
            }
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }
        public virtual void Delete(TEntity entityToDelete)
        {
            //if (_context.Entry(entityToDelete).State == EntityState.Detached)
            //{
            //    _dbSet.Attach(entityToDelete);
            //}
            //_dbSet.Remove(entityToDelete);
            entityToDelete.ObjectState = ObjectState.Modified;
            entityToDelete.IsDeleted = true;
            _dbSet.Add(entityToDelete);
            _context.SyncObjectState(entityToDelete);
        }
        public virtual void Delete(IEnumerable<TEntity> listEntityToDelete)
        {
            foreach(var item in listEntityToDelete)
            {
                Delete(item);
            }
        }


        public virtual void Update(TEntity entityToUpdate)
        {
            _dbSet.Add(entityToUpdate);
            entityToUpdate.ObjectState = ObjectState.Modified;
            _context.SyncObjectState(entityToUpdate);
        }
        public virtual void Update(IEnumerable<TEntity> listEntityToUpdate)
        {
            foreach(var item in listEntityToUpdate)
            {
                Update(item);
            }
        }






        public virtual TEntity GetByID(long? id)
        {
            return _dbSet.Find(id);
        }
        public virtual bool IsExist(long primaryKey)
        {
            return _dbSet.Find(primaryKey) != null;
        }


        public virtual void HardDelete(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            HardDelete(entityToDelete);
        }

        public virtual void HardDelete(TEntity entityToDelete)
        {
            entityToDelete.ObjectState = ObjectState.Deleted;
            _dbSet.Add(entityToDelete);
            _context.SyncObjectState(entityToDelete);
        }


        public virtual void SaveWithSyncObjectState(TEntity entityToSave)
        {
            _context.Entry(entityToSave).State = EntityState.Added;
            _context.SyncObjectState(entityToSave);
        }
        public void SaveWithSyncObjectState(IEnumerable<TEntity> listEntityToSave)
        {
            foreach(var item in listEntityToSave)
            {
                SaveWithSyncObjectState(item);
            }
        }

        public virtual IQueryable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = null;
            foreach(var include in includes)
            {
                query = _dbSet.Include(include);
            }

            return query == null ? _dbSet : query;
        }
    }
}
