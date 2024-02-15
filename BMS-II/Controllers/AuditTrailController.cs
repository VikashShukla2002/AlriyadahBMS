namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("AuditTrailList/{Id?}", Name = "AuditTrailList-AuditTrail-list")]
    [Route("Home/AuditTrailList/{Id?}", Name = "AuditTrailList-AuditTrail-list-2")]
    public async Task<IActionResult> AuditTrailList()
    {
        // Create page object
        auditTrailList = new GLOBALS.AuditTrailList(this);
        auditTrailList.Cache = _cache;

        // Run the page
        return await auditTrailList.Run();
    }

    // add
    [Route("AuditTrailAdd/{Id?}", Name = "AuditTrailAdd-AuditTrail-add")]
    [Route("Home/AuditTrailAdd/{Id?}", Name = "AuditTrailAdd-AuditTrail-add-2")]
    public async Task<IActionResult> AuditTrailAdd()
    {
        // Create page object
        auditTrailAdd = new GLOBALS.AuditTrailAdd(this);

        // Run the page
        return await auditTrailAdd.Run();
    }

    // view
    [Route("AuditTrailView/{Id?}", Name = "AuditTrailView-AuditTrail-view")]
    [Route("Home/AuditTrailView/{Id?}", Name = "AuditTrailView-AuditTrail-view-2")]
    public async Task<IActionResult> AuditTrailView()
    {
        // Create page object
        auditTrailView = new GLOBALS.AuditTrailView(this);

        // Run the page
        return await auditTrailView.Run();
    }
}
