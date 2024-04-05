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
    public class RentalRepository : IRentalRepository
    {
        private readonly MCContext context;

        public RentalRepository(MCContext context)
        {
            this.context = context;
        }

        public async Task<List<Rental>> GetAllAsync()
        {
            return await context.Rentals.ToListAsync();
        }

        public async Task<Rental?> GetByIdAsync(int id)
        {
            return await context.Rentals
                .Include(r => r.Motorcycle)
                .Include(r => r.DeliveryMan)
                .Include(r => r.RentalPlan)
                .Select(r => new Rental
                {
                    Id = r.Id,
                    StartDate = r.StartDate,
                    EndDate = r.EndDate,
                    ExpectedReturnDate = r.ExpectedReturnDate,
                    TotalCost = r.TotalCost,
                    Motorcycle = r.Motorcycle,
                    DeliveryMan = r.DeliveryMan,
                    RentalPlan = r.RentalPlan

                }
                )
                .FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<Rental> SaveAsync(Rental rental)
        {
            await context.Rentals.AddAsync(rental);
            await context.SaveChangesAsync();
            return rental;
        }
    }
}
