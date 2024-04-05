using MC.Core.Domain;

namespace MC.Data.Interfaces
{
    public interface IMotorcycleRepository
    {
        Task<List<Motorcycle>> GetAllAsync();
        Task<Motorcycle?> GetByIdAsync(int id);
        Task<Motorcycle?> GetByPlateAsync(string plate);
        Task<Motorcycle> SaveAsync(Motorcycle motorcycle);
        Task<Motorcycle?> UpdatePlateAsync(int id, string plate);
        Task DeleteAsync(int id);
    }
}
