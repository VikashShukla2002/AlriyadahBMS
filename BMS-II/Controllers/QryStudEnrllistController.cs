namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryStudEnrllistList/{int_Enrollement_Id?}", Name = "QryStudEnrllistList-qryStudEnrllist-list")]
    [Route("Home/QryStudEnrllistList/{int_Enrollement_Id?}", Name = "QryStudEnrllistList-qryStudEnrllist-list-2")]
    public async Task<IActionResult> QryStudEnrllistList()
    {
        // Create page object
        qryStudEnrllistList = new GLOBALS.QryStudEnrllistList(this);
        qryStudEnrllistList.Cache = _cache;

        // Run the page
        return await qryStudEnrllistList.Run();
    }
}
