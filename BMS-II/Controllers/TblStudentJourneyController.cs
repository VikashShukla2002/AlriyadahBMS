namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblStudentJourneyList/{STDJ_ID?}", Name = "TblStudentJourneyList-tblStudentJourney-list")]
    [Route("Home/TblStudentJourneyList/{STDJ_ID?}", Name = "TblStudentJourneyList-tblStudentJourney-list-2")]
    public async Task<IActionResult> TblStudentJourneyList()
    {
        // Create page object
        tblStudentJourneyList = new GLOBALS.TblStudentJourneyList(this);
        tblStudentJourneyList.Cache = _cache;

        // Run the page
        return await tblStudentJourneyList.Run();
    }

    // add
    [Route("TblStudentJourneyAdd/{STDJ_ID?}", Name = "TblStudentJourneyAdd-tblStudentJourney-add")]
    [Route("Home/TblStudentJourneyAdd/{STDJ_ID?}", Name = "TblStudentJourneyAdd-tblStudentJourney-add-2")]
    public async Task<IActionResult> TblStudentJourneyAdd()
    {
        // Create page object
        tblStudentJourneyAdd = new GLOBALS.TblStudentJourneyAdd(this);

        // Run the page
        return await tblStudentJourneyAdd.Run();
    }

    // view
    [Route("TblStudentJourneyView/{STDJ_ID?}", Name = "TblStudentJourneyView-tblStudentJourney-view")]
    [Route("Home/TblStudentJourneyView/{STDJ_ID?}", Name = "TblStudentJourneyView-tblStudentJourney-view-2")]
    public async Task<IActionResult> TblStudentJourneyView()
    {
        // Create page object
        tblStudentJourneyView = new GLOBALS.TblStudentJourneyView(this);

        // Run the page
        return await tblStudentJourneyView.Run();
    }

    // edit
    [Route("TblStudentJourneyEdit/{STDJ_ID?}", Name = "TblStudentJourneyEdit-tblStudentJourney-edit")]
    [Route("Home/TblStudentJourneyEdit/{STDJ_ID?}", Name = "TblStudentJourneyEdit-tblStudentJourney-edit-2")]
    public async Task<IActionResult> TblStudentJourneyEdit()
    {
        // Create page object
        tblStudentJourneyEdit = new GLOBALS.TblStudentJourneyEdit(this);

        // Run the page
        return await tblStudentJourneyEdit.Run();
    }

    // delete
    [Route("TblStudentJourneyDelete/{STDJ_ID?}", Name = "TblStudentJourneyDelete-tblStudentJourney-delete")]
    [Route("Home/TblStudentJourneyDelete/{STDJ_ID?}", Name = "TblStudentJourneyDelete-tblStudentJourney-delete-2")]
    public async Task<IActionResult> TblStudentJourneyDelete()
    {
        // Create page object
        tblStudentJourneyDelete = new GLOBALS.TblStudentJourneyDelete(this);

        // Run the page
        return await tblStudentJourneyDelete.Run();
    }
}
