using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ContactRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        [HttpGet("GetAllContactAsync")]
        public  async Task<IActionResult> GetAllContactAsync()
        {
            var values = await contactRepository.GetLastFourContanctAsync();
            return Ok(values);
        }
    }
}
