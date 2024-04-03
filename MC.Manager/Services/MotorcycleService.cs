using AutoMapper;
using MC.Core.Domain;
using MC.Data.Interfaces;
using MC.Manager.Dtos;
using MC.Manager.Interfaces;

namespace MC.Manager.Services
{
    public class MotorcycleService : IMotorcycleService
    {
        private readonly IMotorcycleRepository repository;
        private readonly IMapper mapper;

        public MotorcycleService(IMotorcycleRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        
        public async Task<List<Motorcycle>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Motorcycle?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<Motorcycle?> GetByPlaceAsync(string place)
        {
            return await repository.GetByPlaceAsync(place);
        }

        public async Task<Motorcycle> SaveAsync(InputMotorcycleDto newMotorcycle)
        {
            var motorcycle = mapper.Map<Motorcycle>(newMotorcycle);

            return await repository.SaveAsync(motorcycle);
        }

        public async Task<Motorcycle?> UpdatePlaceAsync(int id, string place)
        {
            return await repository.UpdatePlaceAsync(id, place);
        }

        public async Task DeleteAsync(int id)
        {
            await repository.DeleteAsync(id);
        }
                
    }
}
