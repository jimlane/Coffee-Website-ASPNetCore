using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coffee_Website_ASPNetCore.Pages;

public class GrindingModel : PageModel
{
    private readonly ILogger<GrindingModel> _logger;

    public GrindingModel(ILogger<GrindingModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

