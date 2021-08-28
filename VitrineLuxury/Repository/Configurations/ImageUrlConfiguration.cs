using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Entities.Concrete;

namespace VitrineLuxury.DataAccess.Configurations
{
    public class ImageUrlConfiguration : IEntityTypeConfiguration<ImageUrl>
    {
        public void Configure(EntityTypeBuilder<ImageUrl> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Url).IsRequired();

            builder.Property(x => x.ProjectId).IsRequired();

            builder.ToTable("ImageUrls");
        }
    }
}
