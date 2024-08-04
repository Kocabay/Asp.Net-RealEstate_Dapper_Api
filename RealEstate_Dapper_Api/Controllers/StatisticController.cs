using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.StatisticRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticRepository _statisticRepository;

        public StatisticController(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }
        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_statisticRepository.ActiveCategoryCount());

        }
        [HttpGet("ActiveEmployeeCount")]
        public IActionResult ActiveEmployeeCount()
        {
            return Ok(_statisticRepository.ActiveEmployeeCount());
        }
        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticRepository.ApartmentCount());
        }
        [HttpGet("AverageProductPriceBySale")]
        public IActionResult AverageProductPriceBySale()
        {
            return Ok(_statisticRepository.AverageProductPriceBySale());
        }
        [HttpGet("AverageProductPriceByRent")]
        public IActionResult AverageProductPriceByRent()
        {
            return Ok(_statisticRepository.AverageProductPriceByRent());
        }
        [HttpGet("AverageRoomCount")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticRepository.AverageRoomCount());
        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_statisticRepository.CategoryCount());
        }
        [HttpGet("CategoryNameByMaxProductCount")]
        public IActionResult CategoryNameByMaxProductCount()
        {
            return Ok(_statisticRepository.CategoryNameByMaxProductCount());
        }
        [HttpGet("CityNameByMaxProductCount")]
        public IActionResult CityNameByMaxProductCount()
        {
            return Ok(_statisticRepository.CityNameByMaxProductCount());
        }
        [HttpGet("DiffrentCityCount")]
        public IActionResult DiffrentCityCount()
        {
            return Ok(_statisticRepository.DiffrentCityCount());
        }
        [HttpGet("EmployeeNameByMaxProductCount")]
        public IActionResult EmployeeNameByMaxProductCount()
        {
            return Ok(_statisticRepository.EmployeeNameByMaxProductCount());
        }
        [HttpGet("LastProductPrice")]
        public IActionResult LastProductPrice()
        {
            return Ok(_statisticRepository.LastProductPrice());
        }
        [HttpGet("NewestBuildingYear")]
        public IActionResult NewestBuildingYear()
        {
            return Ok(_statisticRepository.NewestBuildingYear());
        }
        [HttpGet("OldestBuildingYear")]
        public IActionResult OldestBuildingYear()
        {
            return Ok(_statisticRepository.OldestBuildingYear());
        }
        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_statisticRepository.PassiveCategoryCount());
        }
        [HttpGet("ProductCaount")]
        public IActionResult ProductCaount()
        {
            return Ok(_statisticRepository.ProductCaount());
        }
    }
}
