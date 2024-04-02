using MC.Core.Domain;
using MC.Data.Context;
using MC.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MC.Data.Repository
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        private readonly MCContext context;

        public MotorcycleRepository(MCContext context)
        {
            this.context = context;
        }

        public async Task<List<Motorcycle>> GetAllAsync()
        {
            return await context.Motorcycles.ToListAsync();
        }

        public async Task<Motorcycle> GetByPlaceAsync(string place)
        {
            var motorcycle = await context.Motorcycles.SingleOrDefaultAsync(c=> c.Place == place);

            return motorcycle ?? throw new Exception(message: $"Moto não encontrada pela placa {place}.");
        }

        public async Task<Motorcycle> Save(Motorcycle motorcycle)
        {
            await context.Motorcycles.AddAsync(motorcycle);
            await context.SaveChangesAsync();
            return motorcycle;

        }
    }
}
