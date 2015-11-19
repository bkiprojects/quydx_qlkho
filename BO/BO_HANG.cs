using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.HANG;
namespace BO
{
    public class BO_HANG
    {
        public long ID { get; set; }
        public long? ID_MAT_HANG { get; set; }
        public string TEN_MAT_HANG { get; set; }
        public decimal GIA_NHAP { get; set; }
        public decimal GIA_XUAT_DE_XUAT { get; set; }
        public decimal GIA_XUAT { get; set; }
        public int THOI_GIAN_BAO_HANH { get; set; }

        public string BARCODE { get; set; }
        public DateTime? NGAY_NHAP_HANG { get; set; }
        public DateTime? NGAY_XUAT_HANG { get; set; }
        public DateTime? NGAY_BAT_DAU_BAO_HANH { get; set; }
        public DateTime? NGAY_KET_THUC_BAO_HANH { get; set; }
        public long? ID_KHACH_HANG { get; set; }
        public DateTime? THOI_GIAN_BAT_DAU_BAO_HANH { get; set; }
        public DateTime? THOI_GIAN_KET_THUC_BAO_HANH { get; set; }
        public int? SO_LAN_BAO_HANH { get; set; }

        public long? ID_TRANG_THAI { get; set; }
        public string TEN_TRANG_THAI { get; set; }

        public long? ID_KHO { get; set; }
        public string TEN_KHO { get; set; }
    }
}
