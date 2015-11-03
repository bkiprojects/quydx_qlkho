using MODEL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.TU_DIEN_DATA
{
    public class TU_DIEN : Entity
    {

        #region Public Behavior

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }
        public string MA_TU_DIEN { get; private set; }
        public string TEN_TU_DIEN { get; private set; }

        public long ID_LOAI_TU_DIEN { get; private set; }
        [ForeignKey("ID_LOAI_TU_DIEN")]
        public LOAI_TU_DIEN LOAI_TU_DIEN { get; set; }
        #endregion
    }
}
