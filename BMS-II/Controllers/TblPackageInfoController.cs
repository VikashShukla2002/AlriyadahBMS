namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblPackageInfoList", Name = "TblPackageInfoList-tblPackageInfo-list")]
    [Route("Home/TblPackageInfoList", Name = "TblPackageInfoList-tblPackageInfo-list-2")]
    public async Task<IActionResult> TblPackageInfoList()
    {
        // Create page object
        tblPackageInfoList = new GLOBALS.TblPackageInfoList(this);
        tblPackageInfoList.Cache = _cache;

        // Run the page
        return await tblPackageInfoList.Run();
    }
}
