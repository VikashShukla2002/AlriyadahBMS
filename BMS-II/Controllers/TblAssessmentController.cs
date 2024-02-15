namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblAssessmentList/{AssessmentID?}", Name = "TblAssessmentList-tblAssessment-list")]
    [Route("Home/TblAssessmentList/{AssessmentID?}", Name = "TblAssessmentList-tblAssessment-list-2")]
    public async Task<IActionResult> TblAssessmentList()
    {
        // Create page object
        tblAssessmentList = new GLOBALS.TblAssessmentList(this);
        tblAssessmentList.Cache = _cache;

        // Run the page
        return await tblAssessmentList.Run();
    }

    // view
    [Route("TblAssessmentView/{AssessmentID?}", Name = "TblAssessmentView-tblAssessment-view")]
    [Route("Home/TblAssessmentView/{AssessmentID?}", Name = "TblAssessmentView-tblAssessment-view-2")]
    public async Task<IActionResult> TblAssessmentView()
    {
        // Create page object
        tblAssessmentView = new GLOBALS.TblAssessmentView(this);

        // Run the page
        return await tblAssessmentView.Run();
    }

    // edit
    [Route("TblAssessmentEdit/{AssessmentID?}", Name = "TblAssessmentEdit-tblAssessment-edit")]
    [Route("Home/TblAssessmentEdit/{AssessmentID?}", Name = "TblAssessmentEdit-tblAssessment-edit-2")]
    public async Task<IActionResult> TblAssessmentEdit()
    {
        // Create page object
        tblAssessmentEdit = new GLOBALS.TblAssessmentEdit(this);

        // Run the page
        return await tblAssessmentEdit.Run();
    }

    // search
    [Route("TblAssessmentSearch", Name = "TblAssessmentSearch-tblAssessment-search")]
    [Route("Home/TblAssessmentSearch", Name = "TblAssessmentSearch-tblAssessment-search-2")]
    public async Task<IActionResult> TblAssessmentSearch()
    {
        // Create page object
        tblAssessmentSearch = new GLOBALS.TblAssessmentSearch(this);

        // Run the page
        return await tblAssessmentSearch.Run();
    }

    // preview
    [Route("TblAssessmentPreview", Name = "TblAssessmentPreview-tblAssessment-preview")]
    [Route("Home/TblAssessmentPreview", Name = "TblAssessmentPreview-tblAssessment-preview-2")]
    [HttpCacheExpiration(CacheLocation = CacheLocation.Private, NoStore = true, MaxAge = 0)]
    public async Task<IActionResult> TblAssessmentPreview()
    {
        // Create page object
        tblAssessmentPreview = new GLOBALS.TblAssessmentPreview(this);

        // Run the page
        return await tblAssessmentPreview.Run();
    }
}
