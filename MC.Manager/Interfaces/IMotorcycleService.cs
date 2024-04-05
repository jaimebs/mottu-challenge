using MC.Core.Domain;
using MC.Manager.Dtos;

namespace MC.Manager.Interfaces
{
    public interface IMotorcycleService
    {
        Task<List<Motorcycle>> GetAllAsync();
        Task<Motorcycle?> GetByIdAsync(int id);
        Task<Motorcycle?> GetByPlateAsync(string plate);
        Task<Motorcycle> SaveAsync(InputMotorcycleDto motorcycle);
        Task<Motorcycle?> UpdatePlateAsync(int id, string plate);
        Task DeleteAsync(int id);
    }
}
