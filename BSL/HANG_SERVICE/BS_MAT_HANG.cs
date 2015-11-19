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
using MODEL.NHAP;
using MODEL.XUAT;
using MODEL.NHAN_BH;
using MODEL.CHUYEN_KHO;
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

        public List<BO_HANG> LayDanhSachHangTrongKho(long ip_id_kho)
        {
            List<BO_HANG> resultList = new List<BO_HANG>();
            using(var uow = new UnitOfWork())
            {
                var lst_hang = uow.Repository<GD_HANG>().GetWithInclude(x=>x.TRANG_THAI).Where(x => x.ID_KHO == ip_id_kho).ToList();
                foreach(var item in lst_hang)
                {
                    var r = convert_to_BO(item);
                    r.TEN_TRANG_THAI = item.TRANG_THAI.TEN_TU_DIEN;
                    r.ID_TRANG_THAI = item.ID_TRANG_THAI;
                    resultList.Add(r);
                }
            }
            return resultList;
        }
        public bool IsXuatKho(string barcode, long id_kho)
        {
            using(var uow = new UnitOfWork())
            {
                var entity = uow.Repository<GD_HANG>().GetManyQueryable(x => x.BARCODE == barcode && x.ID_KHO == id_kho).SingleOrDefault();
                if(entity == null)
                {
                    return false;
                }
                if(entity.ID_TRANG_THAI == Convert.ToInt64(ReadDataConfig.ReadByKey("NHAP_KHO")))
                {
                    return false;
                }
                return true;
            }
        }
        public List<DM_MAT_HANG> GetListMatHang()
        {
            using(var uow = new UnitOfWork())
            {
                return uow.Repository<DM_MAT_HANG>().GetAll().ToList();
            }
        }
        public GD_HANG LayEntity(string barcode)
        {
            using(var uow = new UnitOfWork())
            {
                if(!IsExistBarcode(barcode))
                {
                    return null;
                }
                var entity = uow.Repository<GD_HANG>().GetManyQueryable(x => x.BARCODE == barcode).Single();
                return entity;
            }
        }
        public BO_HANG LayBOHang(string barcode)
        {
            using(var uow = new UnitOfWork())
            {
                if(!IsExistBarcode(barcode))
                {
                    return null;
                }
                var entity = uow.Repository<GD_HANG>().GetManyQueryable(x => x.BARCODE == barcode).Single();
                var output = convert_to_BO(entity);
                return output;
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
        public bool IsExistBarcodeNhapKho(string ip_str_barcode)
        {
            using(var uow = new UnitOfWork())
            {
                var id_nhap_kho = Convert.ToInt64(ReadDataConfig.ReadByKey("NHAP_KHO"));
                var sl = uow.Repository<GD_HANG>().GetManyQueryable(x => x.BARCODE == ip_str_barcode && x.ID_TRANG_THAI == id_nhap_kho).Count();
                if(sl > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public void LapPhieuNhap(GD_PHIEU_NHAP phieu_nhap, BindingList<BO_HANG> ip_lst_to_insert)
        {
            using(var uow = new UnitOfWork())
            {
                uow.Repository<GD_PHIEU_NHAP>().Insert(phieu_nhap);

                foreach(var item in ip_lst_to_insert)
                {
                    var entity = convert_to_entity_insert(item);
                    uow.Repository<GD_HANG>().Insert(entity);

                    var chiTietPhieu = new GD_PHIEU_NHAP_CHI_TIET();
                    chiTietPhieu.ObjectState = MODEL.Common.ObjectState.Added;
                    uow.Repository<GD_PHIEU_NHAP_CHI_TIET>().SaveWithSyncObjectState(chiTietPhieu);
                    chiTietPhieu.GD_HANG = entity;

                }
                uow.Save();
            }
        }
        public void LapPhieuXuat(GD_PHIEU_XUAT phieu_xuat, BindingList<GD_HANG> ip_lst_to_insert)
        {
            using(var uow = new UnitOfWork())
            {
                uow.Repository<GD_PHIEU_XUAT>().Insert(phieu_xuat);
                foreach(var item in ip_lst_to_insert)
                {
                    item.ObjectState = MODEL.Common.ObjectState.Modified;
                    item.ID_TRANG_THAI = Convert.ToInt64(ReadDataConfig.ReadByKey("XUAT_KHO"));
                    uow.Repository<GD_HANG>().Update(item);

                    var chiTietPhieu = new GD_PHIEU_XUAT_CHI_TIET();
                    chiTietPhieu.ObjectState = MODEL.Common.ObjectState.Added;
                    uow.Repository<GD_PHIEU_XUAT_CHI_TIET>().SaveWithSyncObjectState(chiTietPhieu);
                    chiTietPhieu.GD_HANG = item;
                }
                uow.Save();
            }
        }
        public void LapPhieuNhanBaoHanh(GD_PHIEU_NHAN_BAO_HANH phieu_nhan_bh, string barcode)
        {
            using(var uow = new UnitOfWork())
            {
                uow.Repository<GD_PHIEU_NHAN_BAO_HANH>().Insert(phieu_nhan_bh);
                var entity = uow.Repository<GD_HANG>().GetManyQueryable(x => x.BARCODE == barcode).Single();
                entity.ID_TRANG_THAI = Convert.ToInt64(ReadDataConfig.ReadByKey("GUI_BAO_HANH"));
                entity.SO_LAN_BAO_HANH = entity.SO_LAN_BAO_HANH + 1;
                uow.Save();
            }
        }
        public void LapPhieuChuyenKho(GD_CHUYEN_KHO phieu_chuyen_kho, long id_hang, long id_kho_chuyen)
        {
            using(var uow = new UnitOfWork())
            {
                uow.Repository<GD_CHUYEN_KHO>().Insert(phieu_chuyen_kho);

                var entity = uow.Repository<GD_HANG>().GetByID(id_hang);

                entity.ID_KHO = id_kho_chuyen;
                uow.Repository<GD_HANG>().Update(entity);

                uow.Save();
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
            obj_result.ID_KHO = ip_obj_bo.ID_KHO;
            return obj_result;
        }
        private BO_HANG convert_to_BO(GD_HANG entity)
        {
            BO_HANG output = new BO_HANG();
            output.BARCODE = entity.BARCODE;
            output.GIA_NHAP = entity.GIA_NHAP;
            output.GIA_XUAT_DE_XUAT = entity.GIA_XUAT_DE_XUAT;
            output.ID = entity.ID;
            output.ID_MAT_HANG = entity.ID_MAT_HANG;
            output.THOI_GIAN_BAO_HANH = entity.THOI_GIAN_BAO_HANH;
            output.NGAY_NHAP_HANG = entity.NGAY_NHAT_HANG;
            output.ID_KHACH_HANG = entity.ID_KHACH_HANG;

            output.ID_KHACH_HANG = entity.ID_KHACH_HANG;
            output.THOI_GIAN_BAT_DAU_BAO_HANH = entity.NGAY_BAT_DAU_BAO_HANH;
            output.THOI_GIAN_KET_THUC_BAO_HANH = entity.NGAY_KET_THUC_BAO_HANH;
            output.SO_LAN_BAO_HANH = entity.SO_LAN_BAO_HANH;
            output.ID_KHO = entity.ID_KHO;

            output.NGAY_NHAP_HANG = entity.NGAY_NHAT_HANG;
            output.NGAY_XUAT_HANG = entity.NGAY_XUAT_HANG;
            output.NGAY_BAT_DAU_BAO_HANH = entity.NGAY_BAT_DAU_BAO_HANH;
            output.NGAY_KET_THUC_BAO_HANH = entity.NGAY_KET_THUC_BAO_HANH;
            return output;
        }
    }
}
