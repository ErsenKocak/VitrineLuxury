using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Core.DataAccess;
using VitrineLuxury.Core.UnitOfWorks;
using VitrineLuxury.DataAccess.Concrete;
using VitrineLuxury.Entities.Concrete;
using VitrineLuxury.Service.Abstract;

namespace VitrineLuxury.Service.Concrete
{
    public class ProjectService : Service<Project>, IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProjectService(IProjectRepository repository,IUnitOfWork unitOfWork) : base(repository,unitOfWork)
        {
            _projectRepository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Project>> GetProjectsWithImageUrlsAsync()
        {
            return await _projectRepository.GetProjectsWithImageUrlByIdAsync();
        }

        public async Task<Project> GetProjectWithImageUrlByIdAsync(int projectId)
        {
            return await _projectRepository.GetProjectWithImageUrlByIdAsync(projectId);
        }
    }
}
