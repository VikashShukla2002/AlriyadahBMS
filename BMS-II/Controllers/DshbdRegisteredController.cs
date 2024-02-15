namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("DshbdRegisteredList", Name = "DshbdRegisteredList-dshbdRegistered-list")]
    [Route("Home/DshbdRegisteredList", Name = "DshbdRegisteredList-dshbdRegistered-list-2")]
    public async Task<IActionResult> DshbdRegisteredList()
    {
        // Create page object
        dshbdRegisteredList = new GLOBALS.DshbdRegisteredList(this);
        dshbdRegisteredList.Cache = _cache;

        // Run the page
        return await dshbdRegisteredList.Run();
    }
}
