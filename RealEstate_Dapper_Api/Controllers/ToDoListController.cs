using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ToDoListRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListRepository _toDoListRepository;

        public ToDoListController(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ToDoList()
        {
            var values = await _toDoListRepository.GetAllToDoListAsync();
            return Ok(values);
        }
    }
}
