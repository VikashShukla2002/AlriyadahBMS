namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblEvaluationList/{Eval_ID?}", Name = "TblEvaluationList-tblEvaluation-list")]
    [Route("Home/TblEvaluationList/{Eval_ID?}", Name = "TblEvaluationList-tblEvaluation-list-2")]
    public async Task<IActionResult> TblEvaluationList()
    {
        // Create page object
        tblEvaluationList = new GLOBALS.TblEvaluationList(this);
        tblEvaluationList.Cache = _cache;

        // Run the page
        return await tblEvaluationList.Run();
    }

    // view
    [Route("TblEvaluationView/{Eval_ID?}", Name = "TblEvaluationView-tblEvaluation-view")]
    [Route("Home/TblEvaluationView/{Eval_ID?}", Name = "TblEvaluationView-tblEvaluation-view-2")]
    public async Task<IActionResult> TblEvaluationView()
    {
        // Create page object
        tblEvaluationView = new GLOBALS.TblEvaluationView(this);

        // Run the page
        return await tblEvaluationView.Run();
    }

    // edit
    [Route("TblEvaluationEdit/{Eval_ID?}", Name = "TblEvaluationEdit-tblEvaluation-edit")]
    [Route("Home/TblEvaluationEdit/{Eval_ID?}", Name = "TblEvaluationEdit-tblEvaluation-edit-2")]
    public async Task<IActionResult> TblEvaluationEdit()
    {
        // Create page object
        tblEvaluationEdit = new GLOBALS.TblEvaluationEdit(this);

        // Run the page
        return await tblEvaluationEdit.Run();
    }

    // search
    [Route("TblEvaluationSearch", Name = "TblEvaluationSearch-tblEvaluation-search")]
    [Route("Home/TblEvaluationSearch", Name = "TblEvaluationSearch-tblEvaluation-search-2")]
    public async Task<IActionResult> TblEvaluationSearch()
    {
        // Create page object
        tblEvaluationSearch = new GLOBALS.TblEvaluationSearch(this);

        // Run the page
        return await tblEvaluationSearch.Run();
    }

    // preview
    [Route("TblEvaluationPreview", Name = "TblEvaluationPreview-tblEvaluation-preview")]
    [Route("Home/TblEvaluationPreview", Name = "TblEvaluationPreview-tblEvaluation-preview-2")]
    [HttpCacheExpiration(CacheLocation = CacheLocation.Private, NoStore = true, MaxAge = 0)]
    public async Task<IActionResult> TblEvaluationPreview()
    {
        // Create page object
        tblEvaluationPreview = new GLOBALS.TblEvaluationPreview(this);

        // Run the page
        return await tblEvaluationPreview.Run();
    }
}
