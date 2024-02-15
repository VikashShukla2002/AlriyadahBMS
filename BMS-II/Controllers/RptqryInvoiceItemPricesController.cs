namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("RptqryInvoiceItemPricesList", Name = "RptqryInvoiceItemPricesList-rptqryInvoiceItemPrices-list")]
    [Route("Home/RptqryInvoiceItemPricesList", Name = "RptqryInvoiceItemPricesList-rptqryInvoiceItemPrices-list-2")]
    public async Task<IActionResult> RptqryInvoiceItemPricesList()
    {
        // Create page object
        rptqryInvoiceItemPricesList = new GLOBALS.RptqryInvoiceItemPricesList(this);
        rptqryInvoiceItemPricesList.Cache = _cache;

        // Run the page
        return await rptqryInvoiceItemPricesList.Run();
    }
}
