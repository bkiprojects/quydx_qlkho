using MODEL.Common;
using MODEL.HANG;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.NHAP
{
    public class GD_PHIEU_NHAP_CHI_TIET : Entity
    {
        #region Public Behavior

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }

        public long ID_GD_PHIEU_NHAP { get; private set; }
        [ForeignKey("ID_GD_PHIEU_NHAP")]
        public GD_PHIEU_NHAP GD_PHIEU_NHAP { get; private set; }

        public long ID_HANG { get; private set; }
        [ForeignKey("ID_HANG")]
        public GD_HANG GD_HANG { get; private set; }

        public decimal GIA_NHAP { get; private set; }
        public decimal GIA_XUAT_DE_XUAT { get; private set; }
        public int THOI_HAN_BAO_HANH { get; private set; }
        #endregion
    }
}
