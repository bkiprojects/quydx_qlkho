using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BO_HANG
    {
        public long ID { get; private set; }
        public string TEN_MAT_HANG { get; private set; }
        public decimal GIA_NHAP { get; private set; }
        public decimal GIA_XUAT_DE_XUAT { get; private set; }
        public decimal GIA_XUAT { get; private set; }
        public int THOI_GIAN_BAO_HANH { get; private set; }

        public string BARCODE { get; private set; }
    }
}
