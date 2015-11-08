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
        public long ID { get; private set; }
        public string TEN_MAT_HANG { get; private set; }
        public decimal GIA_NHAP_DE_XUAT { get; private set; }
        public decimal GIA_XUAT_DE_XUAT { get; private set; }
        public int THOI_GIAN_BAO_HANH_DE_XUAT { get; private set; }

        #endregion
    }
}
