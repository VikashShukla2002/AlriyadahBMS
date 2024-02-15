namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblCrSessionsList/{int_CRSession_ID?}", Name = "TblCrSessionsList-tblCRSessions-list")]
    [Route("Home/TblCrSessionsList/{int_CRSession_ID?}", Name = "TblCrSessionsList-tblCRSessions-list-2")]
    public async Task<IActionResult> TblCrSessionsList()
    {
        // Create page object
        tblCrSessionsList = new GLOBALS.TblCrSessionsList(this);
        tblCrSessionsList.Cache = _cache;

        // Run the page
        return await tblCrSessionsList.Run();
    }

    // add
    [Route("TblCrSessionsAdd/{int_CRSession_ID?}", Name = "TblCrSessionsAdd-tblCRSessions-add")]
    [Route("Home/TblCrSessionsAdd/{int_CRSession_ID?}", Name = "TblCrSessionsAdd-tblCRSessions-add-2")]
    public async Task<IActionResult> TblCrSessionsAdd()
    {
        // Create page object
        tblCrSessionsAdd = new GLOBALS.TblCrSessionsAdd(this);

        // Run the page
        return await tblCrSessionsAdd.Run();
    }

    // view
    [Route("TblCrSessionsView/{int_CRSession_ID?}", Name = "TblCrSessionsView-tblCRSessions-view")]
    [Route("Home/TblCrSessionsView/{int_CRSession_ID?}", Name = "TblCrSessionsView-tblCRSessions-view-2")]
    public async Task<IActionResult> TblCrSessionsView()
    {
        // Create page object
        tblCrSessionsView = new GLOBALS.TblCrSessionsView(this);

        // Run the page
        return await tblCrSessionsView.Run();
    }

    // edit
    [Route("TblCrSessionsEdit/{int_CRSession_ID?}", Name = "TblCrSessionsEdit-tblCRSessions-edit")]
    [Route("Home/TblCrSessionsEdit/{int_CRSession_ID?}", Name = "TblCrSessionsEdit-tblCRSessions-edit-2")]
    public async Task<IActionResult> TblCrSessionsEdit()
    {
        // Create page object
        tblCrSessionsEdit = new GLOBALS.TblCrSessionsEdit(this);

        // Run the page
        return await tblCrSessionsEdit.Run();
    }

    // delete
    [Route("TblCrSessionsDelete/{int_CRSession_ID?}", Name = "TblCrSessionsDelete-tblCRSessions-delete")]
    [Route("Home/TblCrSessionsDelete/{int_CRSession_ID?}", Name = "TblCrSessionsDelete-tblCRSessions-delete-2")]
    public async Task<IActionResult> TblCrSessionsDelete()
    {
        // Create page object
        tblCrSessionsDelete = new GLOBALS.TblCrSessionsDelete(this);

        // Run the page
        return await tblCrSessionsDelete.Run();
    }
}
