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
    public class RentalService : IRentalService
    {
        private readonly IRentalRepository rentalRepository;
        private readonly IMapper mapper;

        public RentalService(IRentalRepository rentalRepository, IMapper mapper)
        {
            this.rentalRepository = rentalRepository;
            this.mapper = mapper;
        }

        public async Task<List<Rental>> GetAllAsync()
        {   var teste = await rentalRepository.GetAllAsync();
            return teste;
        }

        public async Task<Rental?> GetByIdAsync(int id)
        {
            return await rentalRepository.GetByIdAsync(id);
        }

        public async Task<Rental> SaveAsync(InputRentalDto newRental)
        {
            var rental = mapper.Map<Rental>(newRental);
            return await rentalRepository.SaveAsync(rental);
        }
    }
}
