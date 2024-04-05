using MC.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Data.Interfaces
{
    public interface IRentalRepository
    {
        Task<List<Rental>> GetAllAsync();
        Task<Rental?> GetByIdAsync(int id);
        Task<Rental> SaveAsync(Rental rental);
    }
}
