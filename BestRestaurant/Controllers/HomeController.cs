using Microsoft.AspNetCore.Mvc;

namespace BestRestaurant.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}