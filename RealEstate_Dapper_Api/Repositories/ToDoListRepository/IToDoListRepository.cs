using RealEstate_Dapper_Api.Dtos.ToDoListDtos;

namespace RealEstate_Dapper_Api.Repositories.ToDoListRepository
{
    public interface IToDoListRepository
    {
         Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        void CreateToDoList(CreateToDoListDto ToDoListDto);
        void DeleteToDoList(int id);
        void UpdateToDoList(UpdateToDoListDto ToDoListDto);
        Task<GetByIdToDoListDto> GetToDoList(int id);
    }
}
