namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryClassroomCldrListList", Name = "QryClassroomCldrListList-qryClassroomCldrList-list")]
    [Route("Home/QryClassroomCldrListList", Name = "QryClassroomCldrListList-qryClassroomCldrList-list-2")]
    public async Task<IActionResult> QryClassroomCldrListList()
    {
        // Create page object
        qryClassroomCldrListList = new GLOBALS.QryClassroomCldrListList(this);
        qryClassroomCldrListList.Cache = _cache;

        // Run the page
        return await qryClassroomCldrListList.Run();
    }
}
