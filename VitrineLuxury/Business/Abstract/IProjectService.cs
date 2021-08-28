using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Core.Service;
using VitrineLuxury.Entities.Concrete;

namespace VitrineLuxury.Service.Abstract
{
   public interface IProjectService:IService<Project>
    {
        Task<Project> GetProjectWithImageUrlByIdAsync(int projectId);

        Task<IEnumerable<Project>> GetProjectsWithImageUrlsAsync();
    }
}
