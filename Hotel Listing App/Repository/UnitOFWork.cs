using Hotel_Listing_App.Data;
using Hotel_Listing_App.IRepository;
using System;
using System.Threading.Tasks;

namespace Hotel_Listing_App.Repository
{
    public class UnitOFWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<country> _countries;
        private IGenericRepository<hotel> _hotels;
        public UnitOFWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<country> Countries => _countries ??= new GenericRepository<country>(_context);

        public IGenericRepository<hotel> Hotels => _hotels ??= new GenericRepository<hotel>(_context);

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
