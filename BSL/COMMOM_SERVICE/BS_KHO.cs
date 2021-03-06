﻿using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
namespace BSL.COMMOM_SERVICE
{
    public class BS_KHO
    {
        #region Singleton
        private static BS_KHO _service;
        public static BS_KHO Instance
        {
            get
            {
                if(_service == null)
                {
                    _service = new BS_KHO();
                }
                return _service;
            }
        }
        #endregion

        public List<DM_KHO> GetListKho()
        {
            using(var uow = new UnitOfWork())
            {
                return uow.Repository<DM_KHO>().GetAll().ToList();
            }
        }
    }
}
