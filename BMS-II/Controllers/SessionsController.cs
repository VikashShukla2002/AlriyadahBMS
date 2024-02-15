namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Sessions (summary)
    [Route("Sessions", Name = "Sessions-Sessions-summary")]
    [Route("Home/Sessions", Name = "Sessions-Sessions-summary-2")]
    public async Task<IActionResult> Sessions()
    {
        // Create page object
        sessionsSummary = new GLOBALS.SessionsSummary(this);

        // Run the page
        return await sessionsSummary.Run();
    }
}
