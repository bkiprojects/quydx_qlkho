using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using MODEL;
namespace BSL.COMMOM_SERVICE
{
    public class BS_KhachHang
    {
        #region Singleton
        private static BS_KhachHang _service;
        public static BS_KhachHang Instance
        {
            get
            {
                if(_service == null)
                {
                    _service = new BS_KhachHang();
                }
                return _service;
            }
        }
        #endregion

        public List<DM_KHACH_HANG> GetListKhachHang()
        {
            using(var uow = new UnitOfWork())
            {
                return uow.Repository<DM_KHACH_HANG>().GetAll().ToList();
            }
        }
    }
}
