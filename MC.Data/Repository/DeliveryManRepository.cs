using MC.Core.Domain;
using MC.Data.Context;
using MC.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Data.Repository
{
    public class DeliveryManRepository : IDeliveryManRepository
    {
        private readonly MCContext context;
        public DeliveryManRepository(MCContext context)
        {
            this.context = context;
        }

        public async Task<List<DeliveryMan>> GetAllAsync()
        {
            return await context.DeliveryMan.ToListAsync();
        }

        public async Task<DeliveryMan?> GetByIdAsync(int id)
        {
            var deliveryMan = await context.DeliveryMan.SingleOrDefaultAsync(c => c.Id == id);

            return deliveryMan;
        }

        public async Task<DeliveryMan> SaveAsync(DeliveryMan deliveryMan)
        {
            await context.DeliveryMan.AddAsync(deliveryMan);
            await context.SaveChangesAsync();
            return deliveryMan;
        }
    }
}
