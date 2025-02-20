using Microsoft.AspNetCore.Mvc;

namespace EcommApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult test()
        {
            return View();
        }
    }
}
