using MODEL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IUnitOfWork
    {
        bool Disposed { set; get; }
        void Dispose();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : Entity;
        void Save();
    }
}
