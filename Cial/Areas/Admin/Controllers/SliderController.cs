using Microsoft.AspNetCore.Mvc;

namespace Cial.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
