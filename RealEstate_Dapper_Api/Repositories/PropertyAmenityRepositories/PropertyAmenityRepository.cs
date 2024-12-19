using Dapper;
using RealEstate_Dapper_Api.Dtos.PropertyAmenityDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.PropertyAmenityRepositories
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;
        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultPropertAmenityByStatusTrueDto>> ResultPropertAmenityByStatusTrue(int id)
        {
            string query = "select PropertyAmenityId ,title from PropertyAmenity Inner Join Amenity On Amenity.AmenityId =PropertyAmenity.AmenityId Where PropertyId =@propertyId And Status = 1";
            var parameters = new DynamicParameters();
            parameters.Add("propertyId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertAmenityByStatusTrueDto>(query,parameters);
                return values.ToList();
            }
        }
    }
}
