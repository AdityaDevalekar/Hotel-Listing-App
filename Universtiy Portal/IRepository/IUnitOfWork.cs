using System;
using System.Threading.Tasks;
using Universtiy_Portal.Data;

namespace Universtiy_Portal.IRepository
{
    public interface IUnitOfWork :IDisposable
    {
        IGenericRepository<College> Colleges { get; }
        IGenericRepository<Admin> Admins { get; }
        IGenericRepository<Student> Students { get; }

        Task Save();
    }
}
