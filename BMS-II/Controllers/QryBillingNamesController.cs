namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryBillingNamesList/{int_Student_ID?}", Name = "QryBillingNamesList-qryBillingNames-list")]
    [Route("Home/QryBillingNamesList/{int_Student_ID?}", Name = "QryBillingNamesList-qryBillingNames-list-2")]
    public async Task<IActionResult> QryBillingNamesList()
    {
        // Create page object
        qryBillingNamesList = new GLOBALS.QryBillingNamesList(this);
        qryBillingNamesList.Cache = _cache;

        // Run the page
        return await qryBillingNamesList.Run();
    }
}
