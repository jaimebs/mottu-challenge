using MC.Core.Domain;
using MC.Data.Context;
using MC.Data.Interfaces;
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

        public async Task<Motorcycle?> GetByIdAsync(int id)
        {
            var motorcycle = await context.Motorcycles.SingleOrDefaultAsync(c=> c.Id == id);

            return motorcycle;
        }

        public async Task<Motorcycle?> GetByPlateAsync(string plate)
        {
            var motorcycle = await context.Motorcycles.SingleOrDefaultAsync(c=> c.Plate.ToLower() == plate.ToLower());

            return motorcycle;
        }

        public async Task<Motorcycle> SaveAsync(Motorcycle motorcycle)
        {
            await context.Motorcycles.AddAsync(motorcycle);
            await context.SaveChangesAsync();
            return motorcycle;

        }

        public async Task<Motorcycle?> UpdatePlateAsync(int id, string plate)
        {
           var data = await context.Motorcycles.FindAsync(id);

            if( data == null) {
                return null;
            }

            data.Plate = plate;

            context.Motorcycles.Update(data);
            await context.SaveChangesAsync();

            return data;
        }

        public async Task DeleteAsync(int id)
        {
            var data = await context.Motorcycles.FindAsync(id);

            context.Motorcycles.Remove(data);
            await context.SaveChangesAsync();
        }

       
    }
}
