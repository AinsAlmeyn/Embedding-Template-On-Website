using Microsoft.AspNetCore.Mvc;
using RESTGIYDIRME.Models;
using RESTGIYDIRME.Models.ResponseObjects;

namespace RESTGIYDIRME.Controllers
{
    public class ReferanceController : Controller
    {
        RestartDbContext c = new();
        public IActionResult Referance()
        {
            var referances = c.Referances.ToList();
            ReferanceResponse response = new()
            {
                Referances = referances
            };
            return View(response);
        }
    }
}
