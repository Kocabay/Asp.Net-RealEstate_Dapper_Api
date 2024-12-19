using RealEstate_Dapper_Api.Dtos.PropertyAmenityDtos;

namespace RealEstate_Dapper_Api.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
      Task<List<ResultPropertAmenityByStatusTrueDto>> ResultPropertAmenityByStatusTrue(int id);
    }
}
