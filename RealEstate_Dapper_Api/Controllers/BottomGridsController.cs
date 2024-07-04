using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Repositories.BottomGridRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllBottomAsync()
        {
            var values = await _bottomGridRepository.GetAllBottomAsync();
            return Ok(values);
        }


        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto  createBottomGridDto)
        {
            _bottomGridRepository.CreateBottomGrid(createBottomGridDto);
            return Ok("Kategoryi Başarılı bir şekilde eklendi.");
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            _bottomGridRepository.DeleteBottomGrid(id);
            return Ok("Kategori Başarılı bir şekilde silindi.");
        }


        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDto  updateBottomGridDto)
        {
            _bottomGridRepository.UpdateBottomGrid(updateBottomGridDto);
            return Ok("Kategori Başarılı şekilde güncellendi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGrid(int id)
        {
            var values = await _bottomGridRepository.GetBottomGrid(id);
            return Ok(values);
        }
    }
}
