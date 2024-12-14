namespace RealEstate_Dapper_Api.Dtos.ProductImageDtos
{
    public class GetProductImageByProductDto
    {
        public int ProductImageId { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
    }
}
