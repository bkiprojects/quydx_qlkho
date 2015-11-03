using MODEL.Common;
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

        #endregion
    }
}
