using MODEL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class DM_NHAN_VIEN : Entity
    {
        #region Public Behavior

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }
        public string MA_NHAN_VIEN { get; private set; }
        public string TEN_NHAN_VIEN { get; private set; }
        public string SDT { get; private set; }
        public string CONG_VIEC_PHU_TRACH { get; private set; }

        #endregion
    }
}
