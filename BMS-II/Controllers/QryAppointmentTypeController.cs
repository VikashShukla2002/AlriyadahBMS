namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryAppointmentTypeList", Name = "QryAppointmentTypeList-qryAppointmentType-list")]
    [Route("Home/QryAppointmentTypeList", Name = "QryAppointmentTypeList-qryAppointmentType-list-2")]
    public async Task<IActionResult> QryAppointmentTypeList()
    {
        // Create page object
        qryAppointmentTypeList = new GLOBALS.QryAppointmentTypeList(this);
        qryAppointmentTypeList.Cache = _cache;

        // Run the page
        return await qryAppointmentTypeList.Run();
    }
}
