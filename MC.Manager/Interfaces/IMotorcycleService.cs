using MC.Core.Domain;
using MC.Manager.Dtos;

namespace MC.Manager.Interfaces
{
    public interface IMotorcycleService
    {
        Task<List<Motorcycle>> GetAllAsync();
        Task<Motorcycle?> GetByIdAsync(int id);
        Task<Motorcycle?> GetByPlaceAsync(string place);
        Task<Motorcycle> SaveAsync(InputMotorcycleDto motorcycle);
        Task<Motorcycle?> UpdatePlaceAsync(int id, string place);
        Task DeleteAsync(int id);
    }
}
