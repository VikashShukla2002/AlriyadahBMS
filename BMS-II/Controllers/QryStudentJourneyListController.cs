namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryStudentJourneyListList", Name = "QryStudentJourneyListList-qryStudentJourneyList-list")]
    [Route("Home/QryStudentJourneyListList", Name = "QryStudentJourneyListList-qryStudentJourneyList-list-2")]
    public async Task<IActionResult> QryStudentJourneyListList()
    {
        // Create page object
        qryStudentJourneyListList = new GLOBALS.QryStudentJourneyListList(this);
        qryStudentJourneyListList.Cache = _cache;

        // Run the page
        return await qryStudentJourneyListList.Run();
    }
}
