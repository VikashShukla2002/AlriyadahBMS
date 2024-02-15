namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblStudentEnrollmentList/{int_Enrollement_Id?}", Name = "TblStudentEnrollmentList-tblStudentEnrollment-list")]
    [Route("Home/TblStudentEnrollmentList/{int_Enrollement_Id?}", Name = "TblStudentEnrollmentList-tblStudentEnrollment-list-2")]
    public async Task<IActionResult> TblStudentEnrollmentList()
    {
        // Create page object
        tblStudentEnrollmentList = new GLOBALS.TblStudentEnrollmentList(this);
        tblStudentEnrollmentList.Cache = _cache;

        // Run the page
        return await tblStudentEnrollmentList.Run();
    }

    // add
    [Route("TblStudentEnrollmentAdd/{int_Enrollement_Id?}", Name = "TblStudentEnrollmentAdd-tblStudentEnrollment-add")]
    [Route("Home/TblStudentEnrollmentAdd/{int_Enrollement_Id?}", Name = "TblStudentEnrollmentAdd-tblStudentEnrollment-add-2")]
    public async Task<IActionResult> TblStudentEnrollmentAdd()
    {
        // Create page object
        tblStudentEnrollmentAdd = new GLOBALS.TblStudentEnrollmentAdd(this);

        // Run the page
        return await tblStudentEnrollmentAdd.Run();
    }

    // addopt
    [Route("TblStudentEnrollmentAddopt", Name = "TblStudentEnrollmentAddopt-tblStudentEnrollment-addopt")]
    [Route("Home/TblStudentEnrollmentAddopt", Name = "TblStudentEnrollmentAddopt-tblStudentEnrollment-addopt-2")]
    public async Task<IActionResult> TblStudentEnrollmentAddopt()
    {
        // Create page object
        tblStudentEnrollmentAddopt = new GLOBALS.TblStudentEnrollmentAddopt(this);

        // Run the page
        return await tblStudentEnrollmentAddopt.Run();
    }

    // view
    [Route("TblStudentEnrollmentView/{int_Enrollement_Id?}", Name = "TblStudentEnrollmentView-tblStudentEnrollment-view")]
    [Route("Home/TblStudentEnrollmentView/{int_Enrollement_Id?}", Name = "TblStudentEnrollmentView-tblStudentEnrollment-view-2")]
    public async Task<IActionResult> TblStudentEnrollmentView()
    {
        // Create page object
        tblStudentEnrollmentView = new GLOBALS.TblStudentEnrollmentView(this);

        // Run the page
        return await tblStudentEnrollmentView.Run();
    }

    // edit
    [Route("TblStudentEnrollmentEdit/{int_Enrollement_Id?}", Name = "TblStudentEnrollmentEdit-tblStudentEnrollment-edit")]
    [Route("Home/TblStudentEnrollmentEdit/{int_Enrollement_Id?}", Name = "TblStudentEnrollmentEdit-tblStudentEnrollment-edit-2")]
    public async Task<IActionResult> TblStudentEnrollmentEdit()
    {
        // Create page object
        tblStudentEnrollmentEdit = new GLOBALS.TblStudentEnrollmentEdit(this);

        // Run the page
        return await tblStudentEnrollmentEdit.Run();
    }

    // search
    [Route("TblStudentEnrollmentSearch", Name = "TblStudentEnrollmentSearch-tblStudentEnrollment-search")]
    [Route("Home/TblStudentEnrollmentSearch", Name = "TblStudentEnrollmentSearch-tblStudentEnrollment-search-2")]
    public async Task<IActionResult> TblStudentEnrollmentSearch()
    {
        // Create page object
        tblStudentEnrollmentSearch = new GLOBALS.TblStudentEnrollmentSearch(this);

        // Run the page
        return await tblStudentEnrollmentSearch.Run();
    }

    // preview
    [Route("TblStudentEnrollmentPreview", Name = "TblStudentEnrollmentPreview-tblStudentEnrollment-preview")]
    [Route("Home/TblStudentEnrollmentPreview", Name = "TblStudentEnrollmentPreview-tblStudentEnrollment-preview-2")]
    [HttpCacheExpiration(CacheLocation = CacheLocation.Private, NoStore = true, MaxAge = 0)]
    public async Task<IActionResult> TblStudentEnrollmentPreview()
    {
        // Create page object
        tblStudentEnrollmentPreview = new GLOBALS.TblStudentEnrollmentPreview(this);

        // Run the page
        return await tblStudentEnrollmentPreview.Run();
    }
}
