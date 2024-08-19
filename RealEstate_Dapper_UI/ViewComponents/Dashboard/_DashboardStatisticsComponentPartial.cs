using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace RealEstate_Dapper_UI.ViewComponents.Dashboard
{
    public class _DashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            #region İstatistik1 -- ToplamİlanSayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44300/api/Statistic/ProductCaount");
            var jsondata1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.productCaount = jsondata1;
            #endregion

            #region İstatistik12-- En Başarılı Personel
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44300/api/Statistic/EmployeeNameByMaxProductCount");
            var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = jsondata2;
            #endregion

            #region İstatistik3-- İlanadaki Şehir Sayıları
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44300/api/Statistic/DiffrentCityCount");
            var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.diffrentCityCount = jsondata3;
            #endregion

            #region İstatistik4 -- Ortalama Kira Fiyatı
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44300/api/Statistic/AverageProductPriceBySale");
            var jsondata4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.averageProductPriceBySale = jsondata4;
            #endregion

            return View();
        }
    }
}
