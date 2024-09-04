using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task< IActionResult> Index()
        {
            #region İstatistik1
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44300/api/Statistic/ActiveCategoryCount");
            var jsondata = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = jsondata;
            #endregion

            #region İstatistik2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("https://localhost:44300/api/Statistic/ActiveEmployeeCount");
            var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = jsondata2;
            #endregion

            #region İstatistik3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3= await client.GetAsync("https://localhost:44300/api/Statistic/ApartmentCount");
            var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.apartmenCount = jsondata3;
            #endregion

            #region İstatistik4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client.GetAsync("https://localhost:44300/api/Statistic/AverageProductPriceBySale");
            var jsondata4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsondata4;
            #endregion

            #region İstatistik5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client.GetAsync("https://localhost:44300/api/Statistic/AverageProductPriceByRent");
            var jsondata5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceByRent = jsondata4;
            #endregion

            #region İstatistik6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client.GetAsync("https://localhost:44300/api/Statistic/AverageRoomCount");
            var jsondata6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = jsondata6;
            #endregion

            #region İstatistik7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:44300/api/Statistic/CategoryCount");
            var jsondata7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.categoryCount = jsondata7;
            #endregion

            #region İstatistik8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client.GetAsync("https://localhost:44300/api/Statistic/CategoryNameByMaxProductCount");
            var jsondata8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsondata8;
            #endregion

            #region İstatistik9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client.GetAsync("https://localhost:44300/api/Statistic/CityNameByMaxProductCount");
            var jsondata9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.cityNameByMaxProductCount = jsondata9;
            #endregion

            #region İstatistik10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client.GetAsync("https://localhost:44300/api/Statistic/DiffrentCityCount");
            var jsondata10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.diffrentCityCount = jsondata10;
            #endregion

            #region İstatistik11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client.GetAsync("https://localhost:44300/api/Statistic/EmployeeNameByMaxProductCount");
            var jsondata11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsondata11;
            #endregion

            #region İstatistik12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client.GetAsync("https://localhost:44300/api/Statistic/LastProductPrice");
            var jsondata12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = jsondata12;
            #endregion

            #region İstatistik13
            var client13 = _httpClientFactory.CreateClient();
            var responseMessage13 = await client.GetAsync("https://localhost:44300/api/Statistic/NewestBuildingYear");
            var jsondata13 = await responseMessage13.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = jsondata13;
            #endregion

            #region İstatistik14
            var client14 = _httpClientFactory.CreateClient();
            var responseMessage14 = await client.GetAsync("https://localhost:44300/api/Statistic/OldestBuildingYear");
            var jsondata14 = await responseMessage14.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsondata14;
            #endregion

            #region İstatistik15
            var client15 = _httpClientFactory.CreateClient();
            var responseMessage15 = await client.GetAsync("https://localhost:44300/api/Statistic/PassiveCategoryCount");
            var jsondata15 = await responseMessage15.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = jsondata15;
            #endregion

            #region İstatistik16
            var client16 = _httpClientFactory.CreateClient();
            var responseMessage16 = await client.GetAsync("https://localhost:44300/api/Statistic/ProductCaount");
            var jsondata16 = await responseMessage16.Content.ReadAsStringAsync();
            ViewBag.productCaount = jsondata16;
            #endregion

            return View();
        }
    }
}
