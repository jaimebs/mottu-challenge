using AutoMapper;
using MC.Core.Domain;
using MC.Data.Interfaces;
using MC.Manager.Dtos;
using MC.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Manager.Services
{
    public class RentalPlanService : IRentalPlanService
    {
        private readonly IRentalPlanRepository repository;
        private readonly IMapper mapper;

        public RentalPlanService(IRentalPlanRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<RentalPlan>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<RentalPlan?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task<RentalPlan> SaveAsync(InputRentalPlanDto newRentalPlan)
        {
            var rentalPlan = mapper.Map<RentalPlan>(newRentalPlan);
            return await repository.SaveAsync(rentalPlan);
        }
    }
}
