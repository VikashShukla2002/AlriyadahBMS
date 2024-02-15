namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblLocationList/{int_Location_Id?}", Name = "TblLocationList-tblLocation-list")]
    [Route("Home/TblLocationList/{int_Location_Id?}", Name = "TblLocationList-tblLocation-list-2")]
    public async Task<IActionResult> TblLocationList()
    {
        // Create page object
        tblLocationList = new GLOBALS.TblLocationList(this);
        tblLocationList.Cache = _cache;

        // Run the page
        return await tblLocationList.Run();
    }

    // add
    [Route("TblLocationAdd/{int_Location_Id?}", Name = "TblLocationAdd-tblLocation-add")]
    [Route("Home/TblLocationAdd/{int_Location_Id?}", Name = "TblLocationAdd-tblLocation-add-2")]
    public async Task<IActionResult> TblLocationAdd()
    {
        // Create page object
        tblLocationAdd = new GLOBALS.TblLocationAdd(this);

        // Run the page
        return await tblLocationAdd.Run();
    }
}
