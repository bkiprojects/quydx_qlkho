using MODEL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.XUAT
{
    public class GD_PHIEU_XUAT : CHUNG_TU_INFO
    {
        public long? ID_KHACH_HANG { get; set; }
        [ForeignKey("ID_KHACH_HANG")]
        public DM_KHACH_HANG DM_KHACH_HANG { get; set; }
    }
}
