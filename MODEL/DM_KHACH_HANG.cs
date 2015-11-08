using MODEL.Common;
using MODEL.HANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class DM_KHACH_HANG : Entity
    {

        #region Public Behavior
        public DM_KHACH_HANG()
        {
            LIST_HANG = new HashSet<GD_HANG>();
        }
        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; set; }
        public string MA_KHACH_HANG { get; set; }
        public string TEN_KHACH_HANG { get; set; }
        public string DIA_CHI { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }

        public ICollection<GD_HANG> LIST_HANG { get; set; }
        #endregion
    }
}
