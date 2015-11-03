using MODEL;
using MODEL.Common;
using MODEL.HANG;
using MODEL.NHAP;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.DynamicFilters;
namespace DAL.Context
{
    public class IVTContext : DbContext, IDisposable
    {
        public DbSet<DM_MAT_HANG> DM_MAT_HANG { get; set; }
        public DbSet<GD_HANG> GD_HANG { get; set; }
        public DbSet<DM_PHU_KIEN> DM_PHU_KIEN { get; set; }
        public DbSet<GD_PHU_KIEN> GD_PHU_KIEN { get; set; }

        public DbSet<GD_PHIEU_NHAP> GD_PHIEU_NHAP { get; set; }
        public DbSet<GD_PHIEU_NHAP_CHI_TIET> GD_PHIEU_NHAP_CHI_TIET { get; set; }
        public DbSet<DM_NHAN_VIEN> DM_NHAN_VIEN { get; set; }
        public IVTContext()
            : base("name=IVTContext")
        {
           // Database.SetInitializer(new MigrateLastest());
            // Database.SetInitializer<PMSContext>(new CreateDatabaseIfNotExists<PMSContext>());
            // Database.SetInitializer<PMSContext>(null);
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }
        //public new DbSet<TEntity> Set<TEntity>() where TEntity : Entity
        //{
        //    return base.Set<TEntity>();
        //}
        public override int SaveChanges()
        {
            SyncObjectsStatePreCommit();
            var changes = base.SaveChanges();
            SyncObjectsStatePostCommit();
            return changes;
        }
        public void SyncObjectState<TEntity>(TEntity entity) where TEntity : Entity, IObjectState
        {
            Entry(entity).State = StateHelper.ConvertState(entity.ObjectState);
        }
        private void SyncObjectsStatePreCommit()
        {
            foreach (var dbEntityEntry in ChangeTracker.Entries())
            {
                dbEntityEntry.State = StateHelper.ConvertState(((IObjectState)dbEntityEntry.Entity).ObjectState);
            }
        }

        public void SyncObjectsStatePostCommit()
        {
            foreach (var dbEntityEntry in ChangeTracker.Entries())
            {
                ((IObjectState)dbEntityEntry.Entity).ObjectState = StateHelper.ConvertState(dbEntityEntry.State);
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Xóa các auto Convention, để tự định nghĩa
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //Begin TuyenNT
            modelBuilder.Filter("IsDeleted", (Entity bs) => bs.IsDeleted, false);
        }
    }
}
