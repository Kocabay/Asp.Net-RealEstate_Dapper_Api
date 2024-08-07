namespace RealEstate_Dapper_Api.Dtos.PopularLocationDto
{
    public class GetByIdPopularLocationDto
    {
        public int LocationID { get; set; }
        public string? CityName { get; set; }
        public string? ImageUrl { get; set; }
    }
}
