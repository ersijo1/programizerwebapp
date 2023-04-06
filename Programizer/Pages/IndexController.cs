using Microsoft.AspNetCore.Mvc;

namespace Programizer.Pages;
[ApiController]
[Route("api/[controller]")]
public class IndexController : Controller
{
    [HttpGet()]
    public IActionResult Index()
    {
        var model = new IndexModel
        {
            WorkoutLabel = "Bouldering"
        };
        return View(model);
    }
}