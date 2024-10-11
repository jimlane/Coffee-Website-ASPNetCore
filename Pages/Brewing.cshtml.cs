using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coffee_Website_ASPNetCore.Pages;

public class BrewingModel : PageModel
{
    private readonly ILogger<BrewingModel> _logger;

    public BrewingModel(ILogger<BrewingModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

