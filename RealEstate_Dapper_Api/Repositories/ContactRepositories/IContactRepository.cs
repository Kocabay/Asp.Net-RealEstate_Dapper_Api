using RealEstate_Dapper_Api.Dtos.ContactDtos;

namespace RealEstate_Dapper_Api.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDtos>> GetAllContactAsync();
        Task<List<Last4ContactResultDto>> GetLastFourContanctAsync();
        void CreateEmployee(CreateContactDto  createContactDto);
        void DeleteContact(int id);
        Task<GetByIDContactDto> GetContact(int id);
    }
}
