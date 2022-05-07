using System;
using Hotel_Listing_App.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Listing_App.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<country> Countries { get; }
        IGenericRepository<hotel> Hotels { get; }
        Task Save();
        
    }
}
