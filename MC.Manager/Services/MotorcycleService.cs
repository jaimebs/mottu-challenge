using MC.Core.Domain;
using MC.Data.Interfaces;
using MC.Manager.Interfaces;

namespace MC.Manager.Services
{
    public class MotorcycleService : IMotorcycleService
    {
        private readonly IMotorcycleRepository repository;

        public MotorcycleService(IMotorcycleRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<Motorcycle>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Motorcycle> GetByPlaceAsync(string place)
        {
            return await repository.GetByPlaceAsync(place);
        }

        public Task<Motorcycle> Save(Motorcycle motorcycle)
        {
            return repository.Save(motorcycle);
        }
    }
}
