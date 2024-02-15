namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryEvalCalcWshtResultsList/{Eval_ID?}", Name = "QryEvalCalcWshtResultsList-qryEvalCalcWsht_Results-list")]
    [Route("Home/QryEvalCalcWshtResultsList/{Eval_ID?}", Name = "QryEvalCalcWshtResultsList-qryEvalCalcWsht_Results-list-2")]
    public async Task<IActionResult> QryEvalCalcWshtResultsList()
    {
        // Create page object
        qryEvalCalcWshtResultsList = new GLOBALS.QryEvalCalcWshtResultsList(this);
        qryEvalCalcWshtResultsList.Cache = _cache;

        // Run the page
        return await qryEvalCalcWshtResultsList.Run();
    }
}
