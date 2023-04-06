using Microsoft.AspNetCore.Mvc;

namespace Programizer.Pages.Today;
[ApiController]
[Route("api/controller")]
public class TodayController : Controller
{
    [HttpGet()]
    public IActionResult Today()
    {
        // var model = new TodayModel
        // {
        //     WorkoutLabel = "Bouldering"
        // };
        // return View(model);
        return null;
    }
}