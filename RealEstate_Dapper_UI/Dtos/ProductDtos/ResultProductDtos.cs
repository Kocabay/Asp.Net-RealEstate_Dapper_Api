namespace RealEstate_Dapper_UI.Dtos.ProductDtos
{
    public class ResultProductDtos
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProductCategory { get; set; }
        public string CoverImage { get; set; }
        public string Type { get; set; }
        public string Adres { get; set; }
    }
}
