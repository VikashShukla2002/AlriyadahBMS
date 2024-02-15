namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("DshbdAssessmentScoreList", Name = "DshbdAssessmentScoreList-dshbdAssessmentScore-list")]
    [Route("Home/DshbdAssessmentScoreList", Name = "DshbdAssessmentScoreList-dshbdAssessmentScore-list-2")]
    public async Task<IActionResult> DshbdAssessmentScoreList()
    {
        // Create page object
        dshbdAssessmentScoreList = new GLOBALS.DshbdAssessmentScoreList(this);
        dshbdAssessmentScoreList.Cache = _cache;

        // Run the page
        return await dshbdAssessmentScoreList.Run();
    }
}
