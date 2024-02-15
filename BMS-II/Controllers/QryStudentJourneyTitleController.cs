namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryStudentJourneyTitleList/{int_Enrollement_Id?}", Name = "QryStudentJourneyTitleList-qryStudentJourneyTitle-list")]
    [Route("Home/QryStudentJourneyTitleList/{int_Enrollement_Id?}", Name = "QryStudentJourneyTitleList-qryStudentJourneyTitle-list-2")]
    public async Task<IActionResult> QryStudentJourneyTitleList()
    {
        // Create page object
        qryStudentJourneyTitleList = new GLOBALS.QryStudentJourneyTitleList(this);
        qryStudentJourneyTitleList.Cache = _cache;

        // Run the page
        return await qryStudentJourneyTitleList.Run();
    }
}
