using MODEL.Common;
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

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }
        public string MA_KHACH_HANG { get; private set; }
        public string TEN_KHACH_HANG { get; private set; }
        public string DIA_CHI { get; private set; }
        public string SDT { get; private set; }
        public string EMAIL { get; private set; }
        #endregion
    }
}
