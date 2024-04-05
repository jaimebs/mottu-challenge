using MC.Core.Domain;
using MC.Manager.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Manager.Interfaces
{
    public interface IRentalPlanService
    {
        Task<List<RentalPlan>> GetAllAsync();
        Task<RentalPlan?> GetByIdAsync(int id);
        Task<RentalPlan> SaveAsync(InputRentalPlanDto newRentalPlan);
    }
}
