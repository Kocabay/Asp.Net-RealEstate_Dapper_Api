using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.ProductDetailDtos;
using RealEstate_Dapper_UI.Dtos.ProductDtos;

namespace RealEstate_Dapper_UI.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PropertyController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44300/api/Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDtos>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> PropertListWithSearch(string searchKeyValue, int propertyCategoryId, string city)
        {
      
            searchKeyValue = TempData["searchKeyValue"].ToString();
            propertyCategoryId = int.Parse(TempData["propertyCategoryId"].ToString());
            city = TempData["city"].ToString();
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44300/api/Products/ResultProductWithSearchList?searchKeyValue={searchKeyValue}&propertyCategoryId={propertyCategoryId}&city={city}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithSearchListDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PropertySingle(int id)
        {
            id = 1;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44300/api/Products/GetProductByProductId?id=" + id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ResultProductDtos>(jsonData);


            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44300/api/ProductDetails/GetProductDetailByProductId?id=" + id);
            var jsonData2 = await responseMessage.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<GetProductDetailById>(jsonData);

            ViewBag.productID = values.ProductID;
            ViewBag.title1 = values.Title.ToString();
            ViewBag.price = values.Price;
            ViewBag.city = values.City;
            ViewBag.district = values.District;
            ViewBag.address = values.Adres;
            ViewBag.type = values.Type;
            ViewBag.description = values.description;
            ViewBag.date = values.AdvertisementDate;
            ViewBag.slugUrl = values.SlugUrl;

            ViewBag.roomCount = values2.roomCount;
            ViewBag.bedCount = values2.bedRoomCount;
            ViewBag.bathCount = values2.bathCount;
            ViewBag.size = values2.productSize; // metrekare cinsinden boyutunu ifade etmektedir
            ViewBag.garageCount = values2.garageSize;
            ViewBag.buildYear = values2.buildYear;
            ViewBag.location = values2.location;
            ViewBag.videoUrl = values2.videoUrl;


            DateTime date1 = DateTime.Now; // Simdiki zaman
            DateTime date2 = values.AdvertisementDate; // ilanin yayin tarihi
            TimeSpan timeSpan = date1 - date2; // Simdiki zaman ile ilan arasinda ne kadar gun var
            int days = timeSpan.Days; // Gun sayisini 30'a bolunce ay bilgisine ulasilir. Fakat biz yalnizca gun sayisini gosterelim.

            ViewBag.datediff = days;

            // Slug Url olusturm islemi icin
            //string slugFromTitle = CreateSlug(values.Title);
            //ViewBag.slugUrl = slugFromTitle;




            return View();


        }
    }
}
