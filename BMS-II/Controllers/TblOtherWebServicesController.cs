namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblOtherWebServicesList/{OTWEB_ID?}", Name = "TblOtherWebServicesList-tblOtherWebServices-list")]
    [Route("Home/TblOtherWebServicesList/{OTWEB_ID?}", Name = "TblOtherWebServicesList-tblOtherWebServices-list-2")]
    public async Task<IActionResult> TblOtherWebServicesList()
    {
        // Create page object
        tblOtherWebServicesList = new GLOBALS.TblOtherWebServicesList(this);
        tblOtherWebServicesList.Cache = _cache;

        // Run the page
        return await tblOtherWebServicesList.Run();
    }

    // add
    [Route("TblOtherWebServicesAdd/{OTWEB_ID?}", Name = "TblOtherWebServicesAdd-tblOtherWebServices-add")]
    [Route("Home/TblOtherWebServicesAdd/{OTWEB_ID?}", Name = "TblOtherWebServicesAdd-tblOtherWebServices-add-2")]
    public async Task<IActionResult> TblOtherWebServicesAdd()
    {
        // Create page object
        tblOtherWebServicesAdd = new GLOBALS.TblOtherWebServicesAdd(this);

        // Run the page
        return await tblOtherWebServicesAdd.Run();
    }
}
