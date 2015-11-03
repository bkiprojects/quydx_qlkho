using MODEL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.HANG
{
    public class DM_PHU_KIEN : Entity
    {

        #region Public Behavior

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }

        
        public long ID_MAT_HANG { get; private set; }
        [ForeignKey("ID_MAT_HANG")]
        public DM_MAT_HANG DM_MAT_HANG { get; private set; }

        public string TEN_PHU_KIEN { get; private set; }
        public int THOI_GIAN_BAO_HANH { get; private set; }
        #endregion
    }
}
