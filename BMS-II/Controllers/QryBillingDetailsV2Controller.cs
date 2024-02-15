namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryBillingDetailsV2List/{int_Bill_ID?}", Name = "QryBillingDetailsV2List-qryBillingDetails_v2-list")]
    [Route("Home/QryBillingDetailsV2List/{int_Bill_ID?}", Name = "QryBillingDetailsV2List-qryBillingDetails_v2-list-2")]
    public async Task<IActionResult> QryBillingDetailsV2List()
    {
        // Create page object
        qryBillingDetailsV2List = new GLOBALS.QryBillingDetailsV2List(this);
        qryBillingDetailsV2List.Cache = _cache;

        // Run the page
        return await qryBillingDetailsV2List.Run();
    }

    // preview
    [Route("QryBillingDetailsV2Preview", Name = "QryBillingDetailsV2Preview-qryBillingDetails_v2-preview")]
    [Route("Home/QryBillingDetailsV2Preview", Name = "QryBillingDetailsV2Preview-qryBillingDetails_v2-preview-2")]
    [HttpCacheExpiration(CacheLocation = CacheLocation.Private, NoStore = true, MaxAge = 0)]
    public async Task<IActionResult> QryBillingDetailsV2Preview()
    {
        // Create page object
        qryBillingDetailsV2Preview = new GLOBALS.QryBillingDetailsV2Preview(this);

        // Run the page
        return await qryBillingDetailsV2Preview.Run();
    }
}
