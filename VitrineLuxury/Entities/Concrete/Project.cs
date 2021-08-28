using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitrineLuxury.Entities.Concrete
{
    public class Project: BaseEntity
    {

        public string Name { get; set; }

        public ICollection<ImageUrl> ImageUrls { get; set; }

        public string Description { get; set; }

    }
}
