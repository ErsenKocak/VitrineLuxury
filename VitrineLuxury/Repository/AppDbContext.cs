using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.DataAccess.Configurations;
using VitrineLuxury.Entities.Concrete;
using VitrineLuxury.Repository.Configurations;
using VitrineLuxury.Repository.Seeds;

namespace VitrineLuxury.DataAccess
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects{ get; set; }
        public DbSet<ImageUrl> ImageUrls{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());

            modelBuilder.ApplyConfiguration(new ImageUrlConfiguration());

            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.ApplyConfiguration(new ProjectSeed());

            modelBuilder.ApplyConfiguration(new ImageUrlSeed(new int[] { 1,2}));

        }

    }
}
