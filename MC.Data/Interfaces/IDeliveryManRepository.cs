using MC.Core.Domain;

namespace MC.Data.Interfaces
{
    public interface IDeliveryManRepository
    {
        Task<List<DeliveryMan>> GetAllAsync();
        Task<DeliveryMan?> GetByIdAsync(int id);
        Task<DeliveryMan> SaveAsync(DeliveryMan deliveryMan);
    }
}
