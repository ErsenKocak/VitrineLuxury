using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Core.DataAccess;

namespace VitrineLuxury.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {

        //public IProjectRepository projectRepository{ get; }
        Task CommitAsync();

        void Commit();
    }
}
