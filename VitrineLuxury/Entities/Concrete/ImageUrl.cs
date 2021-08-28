using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitrineLuxury.Entities.Concrete
{
   public class ImageUrl: BaseEntity
    {


        public int ProjectId { get; set; }
        public virtual Project Project{ get; set; }

        public string Url { get; set; }
    }
}
