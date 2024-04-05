using MC.Core.Domain;
using MC.Manager.Dtos;

namespace MC.Manager.Interfaces
{
    public interface IDeliveryManService
    {
        Task<List<DeliveryMan>> GetAllAsync();
        Task<DeliveryMan?> GetByIdAsync(int id);
        Task<DeliveryMan> SaveAsync(InputDeliveryManDto deliveryMan);
    }
}
