using MODEL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.TU_DIEN_DATA;
using MODEL.NHAP;
namespace MODEL.HANG
{
    public class GD_HANG : Entity
    {
        #region Public Behavior

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }

        public long? ID_MAT_HANG { get; private set; }
        [ForeignKey("ID_MAT_HANG")]
        public DM_MAT_HANG DM_MAT_HANG { get; private set; }

        public string BARCODE { get; private set; }
        public string TEN_HANG { get; private set; }


        public long? ID_TRANG_THAI { get; private set; }
        [ForeignKey("ID_TRANG_THAI")]
        public TU_DIEN TRANG_THAI { get; private set; }


        public decimal GIA_NHAP { get; private set; }
        public decimal GIA_XUAT_DE_XUAT { get; private set; }
        public decimal GIA_XUAT { get; private set; }
        public int THOI_GIAN_BAO_HANH { get; private set; }
        

        public DateTime? NGAY_NHAT_HANG { get; private set; }
        public DateTime? NGAY_XUAT_HANG { get; private set; }

        public DateTime? NGAY_BAT_DAU_BAO_HANH { get; private set; }
        public DateTime? NGAY_KET_THUC_BAO_HANH { get; private set; }


        public ICollection<GD_PHU_KIEN> LIST_PHU_KIEN { get; set; }

        #endregion
    }
}
