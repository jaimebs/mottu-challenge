using MC.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Manager.Interfaces
{
    public interface IMotorcycleService
    {
        Task<List<Motorcycle>> GetAllAsync();
        Task<Motorcycle> GetByPlaceAsync(string place);
        Task<Motorcycle> Save(Motorcycle motorcycle);
    }
}
