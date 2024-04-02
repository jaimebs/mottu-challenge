using MC.Core.Domain;
using MC.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

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

        [HttpPost]
        public async Task<IActionResult> Save(Motorcycle motorcycle)
        {
            var motorcycles = await motorcycleService.Save(motorcycle);
            return Ok(motorcycles);
        }
    }
}
