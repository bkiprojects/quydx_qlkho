﻿using MODEL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.HANG
{
    public class GD_PHU_KIEN : Entity
    {

        #region Public Behavior

        #endregion

        #region Private Behavior

        #endregion

        #region Property
        public long ID { get; private set; }

        public long ID_HANG { get; private set; }
        public GD_HANG GD_HANG { get; private set; }

        public long ID_PHU_KIEN { get; private set; }
        [ForeignKey("ID_PHU_KIEN")]
        public DM_PHU_KIEN DM_PHU_KIEN { get; private set; }

        public int THOI_GIAN_BAO_HANH { get; private set; }
        public bool KEM_THEO_YN { get; private set; }
        #endregion
    }
}
