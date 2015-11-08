using MODEL.Common;
using MODEL.TU_DIEN_DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class CHUNG_TU_INFO : Entity
    {
        public long ID { get; set; }
        public string SO_CHUNG_TU { get; set; }
        public DateTime NGAY_CHUNG_TU { get; set; }

        public long? ID_NHAN_VIEN_LIEN_QUAN { get; set; }
        [ForeignKey("ID_NHAN_VIEN_LIEN_QUAN")]
        public DM_NHAN_VIEN DM_NHAN_VIEN { get; set; }

        public DateTime? NGAY_NHAP_PHAN_MEM { get; set; }
        public string TEN_NGUOI_NHAP { get; set; }

        public long? ID_TRANG_THAI_CHUNG_TU { get; set; }
        [ForeignKey("ID_TRANG_THAI_CHUNG_TU")]
        public TU_DIEN TRANG_THAI_CHUNG_TU { get; set; }
    }
}
