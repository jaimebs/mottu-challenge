using MC.Core.Domain;

namespace MC.Manager.Interfaces
{
    public interface IMotorcycleRepository
    {
        Task<List<Motorcycle>> GetAllAsync();
        Task<Motorcycle> GetByPlaceAsync(string place);
        Task<Motorcycle> Save(Motorcycle motorcycle);
    }
}
