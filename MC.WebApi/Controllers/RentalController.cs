using MC.Core.Domain;
using MC.Manager.Dtos;
using MC.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MC.WebApi.Controllers
{
    [ApiController]
    [Route("rentals")]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService rentalService;

        public RentalController(IRentalService rentalService)
        {
            this.rentalService = rentalService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var rentalPlan = await rentalService.GetByIdAsync(id);

            if (rentalPlan == null)
            {
                return BadRequest("Aluguel não encontrado!");
            }
            return Ok(rentalPlan);
        }

        [HttpPost]
        public async Task<IActionResult> Save(InputRentalDto newRental)
        {
            var result = await rentalService.SaveAsync(newRental);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }
    }
}
