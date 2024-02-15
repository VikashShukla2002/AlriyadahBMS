namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("DshbdAssessmentv1List/{AssessmentID?}", Name = "DshbdAssessmentv1List-dshbdAssessmentv1-list")]
    [Route("Home/DshbdAssessmentv1List/{AssessmentID?}", Name = "DshbdAssessmentv1List-dshbdAssessmentv1-list-2")]
    public async Task<IActionResult> DshbdAssessmentv1List()
    {
        // Create page object
        dshbdAssessmentv1List = new GLOBALS.DshbdAssessmentv1List(this);
        dshbdAssessmentv1List.Cache = _cache;

        // Run the page
        return await dshbdAssessmentv1List.Run();
    }
}
