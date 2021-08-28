using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Entities.Concrete;

namespace VitrineLuxury.Entities.DTO
{
    public class ProjectWithImageUrlDto: BaseDto
    {

        public string Name { get; set; }

        public ICollection<ImageUrl> ImageUrls { get; set; }

        public string Description { get; set; }
    }
}
