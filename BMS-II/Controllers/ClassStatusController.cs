namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Class Status (summary)
    [Route("ClassStatus", Name = "ClassStatus-Class_Status-summary")]
    [Route("Home/ClassStatus", Name = "ClassStatus-Class_Status-summary-2")]
    public async Task<IActionResult> ClassStatus()
    {
        // Create page object
        classStatusSummary = new GLOBALS.ClassStatusSummary(this);

        // Run the page
        return await classStatusSummary.Run();
    }
}
