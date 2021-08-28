using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Core.DataAccess;
using VitrineLuxury.Core.UnitOfWorks;
using VitrineLuxury.DataAccess.Concrete;

namespace VitrineLuxury.DataAccess.UnitOfWorks
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        //private readonly IProjectRepository _projectRepository;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //public IProjectRepository projectRepository { get => _projectRepository ?? new ProjectRepository(_appDbContext); }

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
