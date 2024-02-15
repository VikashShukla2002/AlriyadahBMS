namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblNationalityList/{ID?}", Name = "TblNationalityList-tblNationality-list")]
    [Route("Home/TblNationalityList/{ID?}", Name = "TblNationalityList-tblNationality-list-2")]
    public async Task<IActionResult> TblNationalityList()
    {
        // Create page object
        tblNationalityList = new GLOBALS.TblNationalityList(this);
        tblNationalityList.Cache = _cache;

        // Run the page
        return await tblNationalityList.Run();
    }

    // add
    [Route("TblNationalityAdd/{ID?}", Name = "TblNationalityAdd-tblNationality-add")]
    [Route("Home/TblNationalityAdd/{ID?}", Name = "TblNationalityAdd-tblNationality-add-2")]
    public async Task<IActionResult> TblNationalityAdd()
    {
        // Create page object
        tblNationalityAdd = new GLOBALS.TblNationalityAdd(this);

        // Run the page
        return await tblNationalityAdd.Run();
    }
}
