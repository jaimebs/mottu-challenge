using MC.Manager.Dtos;
using MC.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MC.WebApi.Controllers
{
    [ApiController]
    [Route("motorcycles")]
    public class MotorcycleController : ControllerBase
    {
        private readonly IMotorcycleService motorcycleService;

        public MotorcycleController(IMotorcycleService motorcycleService)
        {
            this.motorcycleService = motorcycleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var motorcycles = await motorcycleService.GetAllAsync();
            return Ok(motorcycles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var motorcycle = await motorcycleService.GetByIdAsync(id);

            if (motorcycle == null)
            {
                return BadRequest($"Moto não encontrada!");
            }
            return Ok(motorcycle);
        }

        [HttpGet("place/{place}")]
        public async Task<IActionResult> GetByPlace(string place)
        {
            var motorcycle = await motorcycleService.GetByPlaceAsync(place);

            if(motorcycle == null) {
                return BadRequest($"Moto não encontrada para esta placa {place}");
            }
            return Ok(motorcycle);
        }

        [HttpPost]
        public async Task<IActionResult> Save(InputMotorcycleDto motorcycle)
        {
            var IsMotorcycleAlearyExist = await motorcycleService.GetByPlaceAsync(motorcycle.Place);

            if(IsMotorcycleAlearyExist != null)
            {
                return BadRequest("Moto já cadastrada no sistema!");
            }

            var result = await motorcycleService.SaveAsync(motorcycle);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("/{id}")]
        public async Task<IActionResult> UpdatePlace(int id, string place)
        {
            var motorcycle = await motorcycleService.UpdatePlaceAsync(id, place);

            if (motorcycle == null)
            {
                return BadRequest("Moto não encontrada no sistema!");
            }

            return Ok(motorcycle);
        }

        [HttpDelete("/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await motorcycleService.DeleteAsync(id);

            return NoContent();
        }
    }
}
