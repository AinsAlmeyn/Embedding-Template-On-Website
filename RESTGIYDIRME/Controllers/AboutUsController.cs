using Microsoft.AspNetCore.Mvc;
using RESTGIYDIRME.Models;
using RESTGIYDIRME.Models.ResponseObjects;

namespace RESTGIYDIRME.Controllers
{
    public class AboutUsController : Controller
    {
        RestartDbContext c = new();
        public IActionResult AboutUs()
        {
            var listTeams = c.Teams.ToList();
            var reAbout = c.Abouts.FirstOrDefault(x => x.Id == 1);

            AboutUsResponse response = new()
            {
                About = reAbout,
                Teams = listTeams
            };
            return View(response);
        }
    }
}
