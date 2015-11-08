using MODEL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.HANG
{
    public class DM_MAT_HANG : Entity
    {
        #region Public Behavior
        public DM_MAT_HANG()
        {
        }
        #endregion

        #region Private Behavior
        #endregion

        #region Property
        public long ID { get; set; }
        public string TEN_MAT_HANG { get; set; }
        public decimal GIA_NHAP_DE_XUAT { get; set; }
        public decimal GIA_XUAT_DE_XUAT { get; set; }
        public int THOI_GIAN_BAO_HANH_DE_XUAT { get; set; }

        public ICollection<GD_HANG> LIST_HANG { get; set; }
        #endregion
    }
}
