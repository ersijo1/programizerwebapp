using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Programizer.Pages;

// public class IndexModel : PageModel
// {
//     private readonly ILogger<IndexModel>? _logger;
//     
//     public string? WorkoutLabel { get; set; }
//
//     //public IndexModel(ILogger<IndexModel> logger)
//     //{
//     //    _logger = logger;
//     //}
//     
//     public void OnGet()
//     {
//     }
// }
public class IndexModel
{
    public string? WorkoutLabel { get; init; }
}