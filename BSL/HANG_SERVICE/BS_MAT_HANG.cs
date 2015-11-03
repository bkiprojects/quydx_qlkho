using MODEL.HANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
namespace BSL.HANG_SERVICE
{
    public class BS_MAT_HANG
    {
        #region Singleton
        private static BS_MAT_HANG _service;
        public static BS_MAT_HANG Instance
        {
            get
            {
                if(_service == null)
                {
                    _service = new BS_MAT_HANG();
                }
                return _service;
            }
        }
        #endregion

        public List<DM_MAT_HANG> GetListMatHang()
        {
            using(var uow = new UnitOfWork())
            {
                return uow.Repository<DM_MAT_HANG>().GetAll().ToList();
            }
        }
    }
}
