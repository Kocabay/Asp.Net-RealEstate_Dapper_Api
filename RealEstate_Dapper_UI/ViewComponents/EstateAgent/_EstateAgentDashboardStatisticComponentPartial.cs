using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Services;

namespace RealEstate_Dapper_UI.ViewComponents.EstateAgent
{
    public class _EstateAgentDashboardStatisticComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;

        public _EstateAgentDashboardStatisticComponentPartial(IHttpClientFactory httpClientFactory, ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserId;
            #region İstatistik1 -- ToplamİlanSayısı
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44300/api/EstateAgentDashboardStatistic/AllProductCount");
            var jsondata1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.productCaount = jsondata1;
            #endregion

            #region İstatistik12-- KullanıcıİlanSayısı
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:44300/api/EstateAgentDashboardStatistic/ProductCountByEmployeeId?id=" +id);
            var jsondata2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.employeeByProductCount = jsondata2;
            #endregion

            #region İstatistik3-- AktifİlanSayısı
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:44300/api/EstateAgentDashboardStatistic/ProductCountByStatusTrue?id=" +id);
            var jsondata3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.ProductCountByStatusTrue = jsondata3;
            #endregion

            #region İstatistik4 -- Ortalama Kira Fiyatı
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:44300/api/EstateAgentDashboardStatistic/ProductCountByStatusFalse?id=" + id);
            var jsondata4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.ProductCountByStatusFalse = jsondata4;
            #endregion

            return View();
        }
    }
}
