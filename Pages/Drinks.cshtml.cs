using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coffee_Website_ASPNetCore.Pages;

public class DrinksModel : PageModel
{
    private readonly ILogger<DrinksModel> _logger;

    public DrinksModel(ILogger<DrinksModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

