namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblEvaluationMbList/{Eval_ID?}", Name = "TblEvaluationMbList-tblEvaluationMB-list")]
    [Route("Home/TblEvaluationMbList/{Eval_ID?}", Name = "TblEvaluationMbList-tblEvaluationMB-list-2")]
    public async Task<IActionResult> TblEvaluationMbList()
    {
        // Create page object
        tblEvaluationMbList = new GLOBALS.TblEvaluationMbList(this);
        tblEvaluationMbList.Cache = _cache;

        // Run the page
        return await tblEvaluationMbList.Run();
    }

    // view
    [Route("TblEvaluationMbView/{Eval_ID?}", Name = "TblEvaluationMbView-tblEvaluationMB-view")]
    [Route("Home/TblEvaluationMbView/{Eval_ID?}", Name = "TblEvaluationMbView-tblEvaluationMB-view-2")]
    public async Task<IActionResult> TblEvaluationMbView()
    {
        // Create page object
        tblEvaluationMbView = new GLOBALS.TblEvaluationMbView(this);

        // Run the page
        return await tblEvaluationMbView.Run();
    }

    // edit
    [Route("TblEvaluationMbEdit/{Eval_ID?}", Name = "TblEvaluationMbEdit-tblEvaluationMB-edit")]
    [Route("Home/TblEvaluationMbEdit/{Eval_ID?}", Name = "TblEvaluationMbEdit-tblEvaluationMB-edit-2")]
    public async Task<IActionResult> TblEvaluationMbEdit()
    {
        // Create page object
        tblEvaluationMbEdit = new GLOBALS.TblEvaluationMbEdit(this);

        // Run the page
        return await tblEvaluationMbEdit.Run();
    }

    // search
    [Route("TblEvaluationMbSearch", Name = "TblEvaluationMbSearch-tblEvaluationMB-search")]
    [Route("Home/TblEvaluationMbSearch", Name = "TblEvaluationMbSearch-tblEvaluationMB-search-2")]
    public async Task<IActionResult> TblEvaluationMbSearch()
    {
        // Create page object
        tblEvaluationMbSearch = new GLOBALS.TblEvaluationMbSearch(this);

        // Run the page
        return await tblEvaluationMbSearch.Run();
    }

    // preview
    [Route("TblEvaluationMbPreview", Name = "TblEvaluationMbPreview-tblEvaluationMB-preview")]
    [Route("Home/TblEvaluationMbPreview", Name = "TblEvaluationMbPreview-tblEvaluationMB-preview-2")]
    [HttpCacheExpiration(CacheLocation = CacheLocation.Private, NoStore = true, MaxAge = 0)]
    public async Task<IActionResult> TblEvaluationMbPreview()
    {
        // Create page object
        tblEvaluationMbPreview = new GLOBALS.TblEvaluationMbPreview(this);

        // Run the page
        return await tblEvaluationMbPreview.Run();
    }
}
