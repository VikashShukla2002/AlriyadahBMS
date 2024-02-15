namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("DshbdClassesList", Name = "DshbdClassesList-dshbdClasses-list")]
    [Route("Home/DshbdClassesList", Name = "DshbdClassesList-dshbdClasses-list-2")]
    public async Task<IActionResult> DshbdClassesList()
    {
        // Create page object
        dshbdClassesList = new GLOBALS.DshbdClassesList(this);
        dshbdClassesList.Cache = _cache;

        // Run the page
        return await dshbdClassesList.Run();
    }
}
