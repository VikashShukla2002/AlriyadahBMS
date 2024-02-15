namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Registration Status (summary)
    [Route("RegistrationStatus", Name = "RegistrationStatus-Registration_Status-summary")]
    [Route("Home/RegistrationStatus", Name = "RegistrationStatus-Registration_Status-summary-2")]
    public async Task<IActionResult> RegistrationStatus()
    {
        // Create page object
        registrationStatusSummary = new GLOBALS.RegistrationStatusSummary(this);

        // Run the page
        return await registrationStatusSummary.Run();
    }
}
