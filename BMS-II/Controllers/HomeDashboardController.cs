namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Home-Dashboard (dashboard)
    [Route("HomeDashboard", Name = "HomeDashboard-Home_Dashboard-dashboard")]
    [Route("Home/HomeDashboard", Name = "HomeDashboard-Home_Dashboard-dashboard-2")]
    public async Task<IActionResult> HomeDashboard()
    {
        // Create page object
        homeDashboard = new GLOBALS.HomeDashboard(this);

        // Run the page
        return await homeDashboard.Run();
    }
}
