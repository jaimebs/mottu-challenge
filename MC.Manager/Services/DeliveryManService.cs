using AutoMapper;
using MC.Core.Domain;
using MC.Data.Interfaces;
using MC.Manager.Dtos;
using MC.Manager.Interfaces;

namespace MC.Manager.Services
{
    public class DeliveryManService : IDeliveryManService
    {
        private readonly IDeliveryManRepository repository;
        private readonly IMapper mapper;

        public DeliveryManService(IDeliveryManRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<DeliveryMan>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<DeliveryMan?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<DeliveryMan> SaveAsync(InputDeliveryManDto newDeliveryMan)
        {   
            var deliveryMan = mapper.Map<DeliveryMan>(newDeliveryMan);

            return await repository.SaveAsync(deliveryMan);
        }
    }
}
