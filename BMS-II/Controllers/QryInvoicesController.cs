namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryInvoicesList", Name = "QryInvoicesList-qryInvoices-list")]
    [Route("Home/QryInvoicesList", Name = "QryInvoicesList-qryInvoices-list-2")]
    public async Task<IActionResult> QryInvoicesList()
    {
        // Create page object
        qryInvoicesList = new GLOBALS.QryInvoicesList(this);
        qryInvoicesList.Cache = _cache;

        // Run the page
        return await qryInvoicesList.Run();
    }
}
