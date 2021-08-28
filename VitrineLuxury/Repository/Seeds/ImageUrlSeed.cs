using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Entities.Concrete;

namespace VitrineLuxury.Repository.Seeds
{
    class ImageUrlSeed : IEntityTypeConfiguration<ImageUrl>
    {
        private readonly int[] _ids;

        public ImageUrlSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ImageUrl> builder)
        {
            builder.HasData(
                    new ImageUrl
                    {
                        Id = 1,
                        CreatedTime = DateTime.Now,
                        ProjectId = _ids[0],
                        Url = "https://image.freepik.com/free-photo/yellow-sofa-wooden-table-living-room-interior-with-plant_41470-3559.jpg"


                    },
                    new ImageUrl
                    {
                        Id = 2,
                        CreatedTime = DateTime.Now,
                        ProjectId = _ids[0],
                        Url = "https://image.freepik.com/free-photo/yellow-sofa-wooden-table-living-room-interior-with-plant_41470-3559.jpg"


                    }, new ImageUrl
                    {
                        Id = 3,
                        CreatedTime = DateTime.Now,
                        ProjectId = _ids[1],
                        Url = "https://image.freepik.com/free-photo/empty-living-room-with-blue-sofa-plants-table-empty-white-wall-background-3d-rendering_41470-1778.jpg"


                    }





                );
        }
    }
}
