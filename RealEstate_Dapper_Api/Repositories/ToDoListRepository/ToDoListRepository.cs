using Dapper;
using RealEstate_Dapper_Api.Dtos.ToDoListDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ToDoListRepository
{
    public class ToDoListRepository : IToDoListRepository
    {
        Context _context;

        public ToDoListRepository(Context context)
        {
            _context = context;
        }

        public void CreateToDoList(CreateToDoListDto ToDoListDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultToDoListDto>> GetAllToDoListAsync()
        {
            string query = "Select * From ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdToDoListDto> GetToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateToDoList(UpdateToDoListDto ToDoListDto)
        {
            throw new NotImplementedException();
        }
    }
}
