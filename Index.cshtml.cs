using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chekers.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    // Define board as a property
    public int[,] Board { get; set; } = new int[8, 8] {
    { 0, 1, 0, 1, 0, 1, 0, 1 },
    { 1, 0, 1, 0, 1, 0, 1, 0 },
    { 0, 1, 0, 1, 0, 1, 0, 1 },
    { 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0 },
    { 2, 0, 2, 0, 2, 0, 2, 0 },
    { 0, 2, 0, 2, 0, 2, 0, 2 },
    { 2, 0, 2, 0, 2, 0, 2, 0 }
};




    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        
    }

   public void OnGet()
   {
       ViewData["Board"] = Board;
   }

}
