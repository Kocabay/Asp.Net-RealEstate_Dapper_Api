using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
    public interface IServiceReposityory
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto  createServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto  updateServiceDto);
        Task<GetByIdServiceDto> GetService(int id);
    }
}
