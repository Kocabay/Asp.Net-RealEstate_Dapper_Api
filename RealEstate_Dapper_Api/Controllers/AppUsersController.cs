using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.AppUserRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IAppUserRepository _appUserRepository;

        public AppUsersController(IAppUserRepository appUserRepository)
        {
            this._appUserRepository = appUserRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAppUserByProductId(int id)
        {
            var value = await _appUserRepository.GetAppUserByProduct(id);
            return Ok(value);
        }
    }
}
