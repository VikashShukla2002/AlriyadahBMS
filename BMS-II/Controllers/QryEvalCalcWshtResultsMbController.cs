namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryEvalCalcWshtResultsMbList/{Eval_ID?}", Name = "QryEvalCalcWshtResultsMbList-qryEvalCalcWsht_ResultsMB-list")]
    [Route("Home/QryEvalCalcWshtResultsMbList/{Eval_ID?}", Name = "QryEvalCalcWshtResultsMbList-qryEvalCalcWsht_ResultsMB-list-2")]
    public async Task<IActionResult> QryEvalCalcWshtResultsMbList()
    {
        // Create page object
        qryEvalCalcWshtResultsMbList = new GLOBALS.QryEvalCalcWshtResultsMbList(this);
        qryEvalCalcWshtResultsMbList.Cache = _cache;

        // Run the page
        return await qryEvalCalcWshtResultsMbList.Run();
    }
}
