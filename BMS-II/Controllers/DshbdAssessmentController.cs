namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("DshbdAssessmentList/{AssessmentID?}", Name = "DshbdAssessmentList-dshbdAssessment-list")]
    [Route("Home/DshbdAssessmentList/{AssessmentID?}", Name = "DshbdAssessmentList-dshbdAssessment-list-2")]
    public async Task<IActionResult> DshbdAssessmentList()
    {
        // Create page object
        dshbdAssessmentList = new GLOBALS.DshbdAssessmentList(this);
        dshbdAssessmentList.Cache = _cache;

        // Run the page
        return await dshbdAssessmentList.Run();
    }
}
