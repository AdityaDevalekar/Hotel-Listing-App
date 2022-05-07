using System.Threading.Tasks;
using Universtiy_Portal.Data;
using Universtiy_Portal.IRepository;
using System;

namespace Universtiy_Portal.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<College> _colleges;
        private IGenericRepository<Admin> _admins;
        private IGenericRepository<Student> _students;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<College> Colleges => _colleges ??= new GenericRepository<College>(_context);

        public IGenericRepository<Admin> Admins => _admins ??= new GenericRepository<Admin>(_context);
        public IGenericRepository<Student> Students => _students ??= new GenericRepository<Student>(_context);

        public void Dispose()
        {

            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
