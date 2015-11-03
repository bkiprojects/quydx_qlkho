using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
namespace BSL.COMMOM_SERVICE
{
    public class BS_NhanVien
    {
        #region Singleton
        private static BS_NhanVien _service;
        public static BS_NhanVien Instance
        {
            get
            {
                if(_service == null)
                {
                    _service = new BS_NhanVien();
                }
                return _service;
            }
        }
        #endregion

        public List<DM_NHAN_VIEN> GetListNhanVien()
        {
            using(var uow = new IVTContext())
            {
                List<DM_NHAN_VIEN> listResult = uow.DM_NHAN_VIEN.ToList();
                return listResult;
            }
        }
    }
}
