using MC.Manager.Dtos;
using MC.Manager.Interfaces;
using MC.Manager.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC.WebApi.Controllers
{
    [ApiController]
    [Route("rental-plans")]
    public class RentalPlanController : ControllerBase
    {
        private readonly IRentalPlanService rentalPlanService;

        public RentalPlanController(IRentalPlanService rentalPlanService)
        {
            this.rentalPlanService = rentalPlanService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var rentalPlan = await rentalPlanService.GetByIdAsync(id);

            if (rentalPlan == null)
            {
                return BadRequest("Plano não encontrado!");
            }
            return Ok(rentalPlan);
        }

        [HttpPost]
        public async Task<IActionResult> Save(InputRentalPlanDto rentalPlanDto)
        {
            var result = await rentalPlanService.SaveAsync(rentalPlanDto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }
    }
}
