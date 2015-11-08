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
        public decimal ID_MAT_HANG { get; set; }
        public string TEN_MAT_HANG { get; set; }
        public decimal GIA_NHAP { get; set; }
        public decimal GIA_XUAT_DE_XUAT { get; set; }
        public decimal GIA_XUAT { get; set; }
        public int THOI_GIAN_BAO_HANH { get; set; }

        public string BARCODE { get; set; }
    }
}
