using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Common
{
    public class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }

        //[ScaffoldColumn(false)]
        public bool IsDeleted { get; set; }
    }
}
