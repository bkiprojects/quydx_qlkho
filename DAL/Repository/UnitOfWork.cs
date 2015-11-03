using DAL.Context;
using MODEL.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class UnitOfWork
    {
        /// <summary>
        /// Context toàn bộ dự án
        /// </summary>
        private readonly IVTContext _context;
        private bool _disposed = false;
        public bool Disposed
        {
            get
            {
                return _disposed;
            }
            set
            {
                _disposed = value;
            }
        }

        private Hashtable _repositories;
        public UnitOfWork(IVTContext context)
        {
            _context = context;
        }

        public UnitOfWork()
        {
            _context = new IVTContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Chua biet dung
        /// </summary>
        /// <param name="disposing"></param>
        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                    if (_repositories != null)
                    {
                        _repositories = null;
                    }
                }
                _disposed = true;
            }
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : Entity
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);

                var repositoryInstance =
                    Activator.CreateInstance(repositoryType
                            .MakeGenericType(typeof(TEntity)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<TEntity>)_repositories[type];
        }
    }
}
