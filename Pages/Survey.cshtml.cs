using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Coffee_Website_ASPNetCore.Pages;

public class SurveyModel : PageModel
{
    private readonly ILogger<SurveyModel> _logger;

    public SurveyModel(ILogger<SurveyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

