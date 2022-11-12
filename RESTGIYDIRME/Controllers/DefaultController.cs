using Microsoft.AspNetCore.Mvc;
using RESTGIYDIRME.Models;
using RESTGIYDIRME.Models.ResponseObjects;

namespace RESTGIYDIRME.Controllers
{
    public class DefaultController : Controller
    {
        RestartDbContext c = new();
        public IActionResult Index()
        {
            var listIndexInfo = c.IndexInfos.ToList();
            var listSliderInfo = c.Sliders.ToList();
            var listPortfolioInfo = c.Portfolios.OrderByDescending(x => x.Date).ToList();

            DefaultResponse response = new()
            {
                Sliders = listSliderInfo,
                Portfolios = listPortfolioInfo,
                IndexInfos = listIndexInfo
            };
            return View(response);
        }
    }
}
