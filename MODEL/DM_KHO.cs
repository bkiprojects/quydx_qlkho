using MODEL.Common;
using MODEL.HANG;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class DM_KHO : Entity
    {

        #region Public Behavior
        public DM_KHO()
        {
            LIST_HANG = new HashSet<GD_HANG>();
        }
        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }
        public string MA_KHO { get; private set; }
        public string TEN_KHO { get; private set; }

        public long ID_THU_KHO { get; private set; }
        [ForeignKey("ID_THU_KHO")]
        public DM_NHAN_VIEN DM_NHAN_VIEN { get; private set; }

        public ICollection<GD_HANG> LIST_HANG { get; set; }
        #endregion
    }
}
