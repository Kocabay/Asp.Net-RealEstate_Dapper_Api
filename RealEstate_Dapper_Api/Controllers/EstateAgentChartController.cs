using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentChartController : ControllerBase
    {
        private readonly IChartRepositories _chartRepositories;

        public EstateAgentChartController(IChartRepositories chartRepositories)
        {
            _chartRepositories = chartRepositories;
        }

        [HttpGet]
        public async Task< IActionResult> GetChart5()
        {
            return Ok(await _chartRepositories.Get5CityForChartAsync());
        }
    }
}
