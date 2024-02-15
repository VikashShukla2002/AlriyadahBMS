namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblProductInfoList", Name = "TblProductInfoList-tblProductInfo-list")]
    [Route("Home/TblProductInfoList", Name = "TblProductInfoList-tblProductInfo-list-2")]
    public async Task<IActionResult> TblProductInfoList()
    {
        // Create page object
        tblProductInfoList = new GLOBALS.TblProductInfoList(this);
        tblProductInfoList.Cache = _cache;

        // Run the page
        return await tblProductInfoList.Run();
    }

    // add
    [Route("TblProductInfoAdd", Name = "TblProductInfoAdd-tblProductInfo-add")]
    [Route("Home/TblProductInfoAdd", Name = "TblProductInfoAdd-tblProductInfo-add-2")]
    public async Task<IActionResult> TblProductInfoAdd()
    {
        // Create page object
        tblProductInfoAdd = new GLOBALS.TblProductInfoAdd(this);

        // Run the page
        return await tblProductInfoAdd.Run();
    }
}
