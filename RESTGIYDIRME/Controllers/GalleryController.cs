using Microsoft.AspNetCore.Mvc;
using RESTGIYDIRME.Models;
using RESTGIYDIRME.Models.ResponseObjects;

namespace RESTGIYDIRME.Controllers
{
    public class GalleryController : Controller
    {
        RestartDbContext c = new();
        public IActionResult Gallery()
        {
            var Portfolios = c.Portfolios.ToList();
            GalleryResponseModel response = new()
            {
                portfolios = Portfolios
            };
            return View(response);
        }

        public IActionResult GalleryDetail(int id)
        {
            var fPortfolio = c.Portfolios.FirstOrDefault(x => x.Id == id);
            var Sliders = c.PortfolioSliders.Where(x => x.PortId == id).ToList();
            GalleryDetailResponseModel response = new()
            {
                portfolio = fPortfolio,
                slider = Sliders
            };
            return View(response);
        }
    }
}
