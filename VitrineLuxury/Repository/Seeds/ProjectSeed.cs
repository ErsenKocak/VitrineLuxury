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
    public class ProjectSeed : IEntityTypeConfiguration<Project>
    {

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(
                    new Project
                    {
                        Id = 1,
                        Name = "Project Name Test",
                        CreatedTime = DateTime.Now,
                        Description = "Project Description Test",
                    },
                     new Project
                     {
                         Id = 2,
                         Name = "Project Name Test 2",
                         CreatedTime = DateTime.Now,
                         Description = "Project Description Test 2",
                     }

                ); ;
        }
    }
}
