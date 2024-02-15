namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("DshbdPayList", Name = "DshbdPayList-dshbdPay-list")]
    [Route("Home/DshbdPayList", Name = "DshbdPayList-dshbdPay-list-2")]
    public async Task<IActionResult> DshbdPayList()
    {
        // Create page object
        dshbdPayList = new GLOBALS.DshbdPayList(this);
        dshbdPayList.Cache = _cache;

        // Run the page
        return await dshbdPayList.Run();
    }
}
