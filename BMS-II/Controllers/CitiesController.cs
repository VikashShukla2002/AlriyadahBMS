namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("CitiesList", Name = "CitiesList-Cities-list")]
    [Route("Home/CitiesList", Name = "CitiesList-Cities-list-2")]
    public async Task<IActionResult> CitiesList()
    {
        // Create page object
        citiesList = new GLOBALS.CitiesList(this);
        citiesList.Cache = _cache;

        // Run the page
        return await citiesList.Run();
    }
}
