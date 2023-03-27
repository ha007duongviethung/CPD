using Microsoft.AspNetCore.Mvc;

namespace Service_ASP.NET_CPD.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
