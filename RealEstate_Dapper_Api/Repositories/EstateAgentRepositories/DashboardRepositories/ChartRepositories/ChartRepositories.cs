﻿using Dapper;
using RealEstate_Dapper_Api.Dtos.ChartDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.ChartRepositories
{
    public class ChartRepositories : IChartRepositories
    {
        private readonly Context _context;
        public ChartRepositories(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultChartDto>> Get5CityForChartAsync()
        {
            string query = "Select top(5) City,Count(*) as 'CityCount' From Product Group By City Order By CityCount Desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultChartDto>(query);
                return values.ToList();
            }
        }
    }
}
