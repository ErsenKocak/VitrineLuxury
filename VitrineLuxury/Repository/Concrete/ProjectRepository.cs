using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Core.DataAccess;
using VitrineLuxury.DataAccess.Concrete;
using VitrineLuxury.Entities.Concrete;

namespace VitrineLuxury.DataAccess.Concrete
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<Project>> GetProjectsWithImageUrlByIdAsync()
        {
            var response = await _appDbContext.Projects.Include("ImageUrls").ToListAsync();
            return response;
        }

        public async Task<Project> GetProjectWithImageUrlByIdAsync(int projectId)
        {
            return await _appDbContext.Projects.Include("ImageUrls").SingleOrDefaultAsync(x => x.Id == projectId);
        }
    }
}
