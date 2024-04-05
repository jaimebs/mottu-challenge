using MC.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Data.Interfaces
{
    public interface IRentalPlanRepository
    {
        Task<List<RentalPlan>> GetAllAsync();
        Task<RentalPlan?> GetByIdAsync(int id);
        Task<RentalPlan> SaveAsync(RentalPlan rentalPlan);
    }
}
