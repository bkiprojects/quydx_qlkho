using MODEL.HANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using BO;
using System.ComponentModel;
using COMMON;
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
        public bool IsExistBarcode(string ip_str_barcode)
        {
            using(var uow = new UnitOfWork())
            {
                var sl = uow.Repository<GD_HANG>().GetManyQueryable(x => x.BARCODE == ip_str_barcode).Count();
                if(sl > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public void LapPhieuNhap(BindingList<BO_HANG> ip_lst_to_insert)
        {
            using(var uow = new UnitOfWork())
            {
                foreach(var item in ip_lst_to_insert)
                {
                    var entity = convert_to_entity_insert(item);
                    uow.Repository<GD_HANG>().Insert(entity);
                    uow.Save();
                }

            }
        }
        private GD_HANG convert_to_entity_insert(BO_HANG ip_obj_bo)
        {
            GD_HANG obj_result = new GD_HANG();
            obj_result.BARCODE = ip_obj_bo.BARCODE;
            obj_result.GIA_NHAP = ip_obj_bo.GIA_NHAP;
            obj_result.GIA_XUAT_DE_XUAT = ip_obj_bo.GIA_XUAT_DE_XUAT;
            obj_result.ID = ip_obj_bo.ID;
            obj_result.ID_MAT_HANG = ip_obj_bo.ID_MAT_HANG;
            obj_result.ID_TRANG_THAI = Convert.ToInt64(ReadDataConfig.ReadByKey("NHAP_KHO").ToString());
            obj_result.IsDeleted = false;
            obj_result.ObjectState = MODEL.Common.ObjectState.Added;
            obj_result.THOI_GIAN_BAO_HANH = ip_obj_bo.THOI_GIAN_BAO_HANH;
            obj_result.NGAY_NHAT_HANG = ip_obj_bo.NGAY_NHAP_HANG;
            return obj_result;
        }
    }
}
