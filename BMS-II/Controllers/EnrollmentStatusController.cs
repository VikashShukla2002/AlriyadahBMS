namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Enrollment Status (summary)
    [Route("EnrollmentStatus", Name = "EnrollmentStatus-Enrollment_Status-summary")]
    [Route("Home/EnrollmentStatus", Name = "EnrollmentStatus-Enrollment_Status-summary-2")]
    public async Task<IActionResult> EnrollmentStatus()
    {
        // Create page object
        enrollmentStatusSummary = new GLOBALS.EnrollmentStatusSummary(this);

        // Run the page
        return await enrollmentStatusSummary.Run();
    }
}
