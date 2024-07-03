using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ServiceRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceReposityory _serviceReposityory;

        public ServicesController(IServiceReposityory serviceReposityory)
        {
            _serviceReposityory = serviceReposityory;
        }

        [HttpGet]
        public async Task< IActionResult> GetServiceList()
        {
            var value = await _serviceReposityory.GetAllServiceAsync();
            return Ok(value);
        }
    }
}
