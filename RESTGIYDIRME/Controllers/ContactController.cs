using Microsoft.AspNetCore.Mvc;

namespace RESTGIYDIRME.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
