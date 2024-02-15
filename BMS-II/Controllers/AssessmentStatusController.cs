namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Assessment Status (summary)
    [Route("AssessmentStatus", Name = "AssessmentStatus-Assessment_Status-summary")]
    [Route("Home/AssessmentStatus", Name = "AssessmentStatus-Assessment_Status-summary-2")]
    public async Task<IActionResult> AssessmentStatus()
    {
        // Create page object
        assessmentStatusSummary = new GLOBALS.AssessmentStatusSummary(this);

        // Run the page
        return await assessmentStatusSummary.Run();
    }
}
