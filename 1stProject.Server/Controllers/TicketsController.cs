using Microsoft.AspNetCore.Mvc;

namespace 1stProject.Server.Controllers
{
    public class TicketsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}
