using MC.Core.Domain;
using MC.Manager.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Manager.Interfaces
{
    public interface IRentalService
    {
        Task<List<Rental>> GetAllAsync();
        Task<Rental?> GetByIdAsync(int id);
        Task<Rental> SaveAsync(InputRentalDto newRental);
    }
}
