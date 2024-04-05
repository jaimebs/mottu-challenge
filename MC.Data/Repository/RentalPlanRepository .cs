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
    public class RentalPlanRepository : IRentalPlanRepository
    {
        private readonly MCContext context;

        public RentalPlanRepository(MCContext context)
        {
            this.context = context;
        }

        public async Task<List<RentalPlan>> GetAllAsync()
        {
            return await context.RentalPlans.ToListAsync();
        }

        public async Task<RentalPlan?> GetByIdAsync(int id)
        {
            return await context.RentalPlans.FirstOrDefaultAsync(x => x.Id == id);    
        }

        public async Task<RentalPlan> SaveAsync(RentalPlan rentalPlan)
        {
            await context.RentalPlans.AddAsync(rentalPlan);
            await context.SaveChangesAsync();
            return rentalPlan;
        }
    }
}
