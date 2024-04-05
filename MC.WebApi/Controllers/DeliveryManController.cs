using MC.Manager.Dtos;
using MC.Manager.Interfaces;
using MC.Manager.Services;
using Microsoft.AspNetCore.Mvc;

namespace MC.WebApi.Controllers
{
    [ApiController]
    [Route("delivery-man")]
    public class DeliveryManController : ControllerBase
    {
        private readonly IDeliveryManService deliveryManService;

        public DeliveryManController(IDeliveryManService deliveryManService)
        {
            this.deliveryManService = deliveryManService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var deliveryMan = await deliveryManService.GetAllAsync();
            return Ok(deliveryMan); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var deliveryMan = await deliveryManService.GetByIdAsync(id);

            if (deliveryMan == null)
            {
                return BadRequest($"Entregador não encontrado!");
            }
            return Ok(deliveryMan);
        }

        [HttpPost]
        public async Task<IActionResult> Save(InputDeliveryManDto deliveMan)
        {
            var result = await deliveryManService.SaveAsync(deliveMan);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }
    }
}
