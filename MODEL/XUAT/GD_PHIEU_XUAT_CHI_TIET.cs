using MODEL.Common;
using MODEL.HANG;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XUAT
{
    public class GD_PHIEU_XUAT_CHI_TIET : Entity
    {
        public GD_PHIEU_XUAT_CHI_TIET()
        {

        }
        public long ID { get; private set; }

        public long ID_GD_PHIEU_XUAT { get; set; }
        [ForeignKey("ID_GD_PHIEU_XUAT")]
        public GD_PHIEU_XUAT GD_PHIEU_XUAT { get; set; }

        public long ID_HANG { get; set; }
        [ForeignKey("ID_HANG")]
        public GD_HANG GD_HANG { get; set; }
    }
}
