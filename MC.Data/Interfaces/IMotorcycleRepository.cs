using MC.Core.Domain;

namespace MC.Data.Interfaces
{
    public interface IMotorcycleRepository
    {
        Task<List<Motorcycle>> GetAllAsync();
        Task<Motorcycle?> GetByIdAsync(int id);
        Task<Motorcycle?> GetByPlaceAsync(string place);
        Task<Motorcycle> SaveAsync(Motorcycle motorcycle);
        Task<Motorcycle?> UpdatePlaceAsync(int id, string place);
        Task DeleteAsync(int id);
    }
}
