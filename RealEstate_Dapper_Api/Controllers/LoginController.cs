using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Context _context;
        public LoginController(Context context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> SignIn()
        {
            
        }
    }
}
