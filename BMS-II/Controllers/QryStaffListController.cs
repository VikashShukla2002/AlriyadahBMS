namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryStaffListList/{int_Staff_Id?}", Name = "QryStaffListList-qryStaffList-list")]
    [Route("Home/QryStaffListList/{int_Staff_Id?}", Name = "QryStaffListList-qryStaffList-list-2")]
    public async Task<IActionResult> QryStaffListList()
    {
        // Create page object
        qryStaffListList = new GLOBALS.QryStaffListList(this);
        qryStaffListList.Cache = _cache;

        // Run the page
        return await qryStaffListList.Run();
    }
}
