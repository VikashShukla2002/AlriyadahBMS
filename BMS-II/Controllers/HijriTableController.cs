namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("HijriTableList/{ID?}", Name = "HijriTableList-Hijri_Table-list")]
    [Route("Home/HijriTableList/{ID?}", Name = "HijriTableList-Hijri_Table-list-2")]
    public async Task<IActionResult> HijriTableList()
    {
        // Create page object
        hijriTableList = new GLOBALS.HijriTableList(this);
        hijriTableList.Cache = _cache;

        // Run the page
        return await hijriTableList.Run();
    }
}
