using MODEL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class DM_NHA_CUNG_CAP : Entity
    {

        #region Public Behavior

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }
        public string MA_NCC { get; private set; }
        public string TEN_NCC { get; private set; }
        public string SDT_LIEN_LAC { get; private set; }
        public string DIA_CHI { get; private set; }
        #endregion
    }
}
