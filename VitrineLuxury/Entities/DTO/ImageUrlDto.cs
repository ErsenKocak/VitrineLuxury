using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitrineLuxury.Entities.DTO
{
    public class ImageUrlDto: BaseDto
    {
        

            public int ProjectId { get; set; }
            public virtual ProjectDto Project { get; set; }

            public string Url { get; set; }
        
    }
}
