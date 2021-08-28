using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Entities.Concrete;
using VitrineLuxury.Core.DataAccess;


namespace VitrineLuxury.Core.DataAccess
{
    public interface IProjectRepository: IRepository<Project>
    {

        Task<Project> GetProjectWithImageUrlByIdAsync(int projectId);

        Task<IEnumerable<Project>> GetProjectsWithImageUrlByIdAsync();
    }
}
