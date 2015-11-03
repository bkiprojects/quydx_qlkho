using MODEL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.TU_DIEN_DATA
{
    public class LOAI_TU_DIEN : Entity
    {

        #region Public Behavior

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }
        public string TEN { get; private set; }
        public ICollection<TU_DIEN> LIST_TU_DIEN { get; private set; }
        #endregion
    }
}
