namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblRptMgrInvoicesList/{RptMgr_ID?}", Name = "TblRptMgrInvoicesList-tblRptMgrInvoices-list")]
    [Route("Home/TblRptMgrInvoicesList/{RptMgr_ID?}", Name = "TblRptMgrInvoicesList-tblRptMgrInvoices-list-2")]
    public async Task<IActionResult> TblRptMgrInvoicesList()
    {
        // Create page object
        tblRptMgrInvoicesList = new GLOBALS.TblRptMgrInvoicesList(this);
        tblRptMgrInvoicesList.Cache = _cache;

        // Run the page
        return await tblRptMgrInvoicesList.Run();
    }

    // add
    [Route("TblRptMgrInvoicesAdd/{RptMgr_ID?}", Name = "TblRptMgrInvoicesAdd-tblRptMgrInvoices-add")]
    [Route("Home/TblRptMgrInvoicesAdd/{RptMgr_ID?}", Name = "TblRptMgrInvoicesAdd-tblRptMgrInvoices-add-2")]
    public async Task<IActionResult> TblRptMgrInvoicesAdd()
    {
        // Create page object
        tblRptMgrInvoicesAdd = new GLOBALS.TblRptMgrInvoicesAdd(this);

        // Run the page
        return await tblRptMgrInvoicesAdd.Run();
    }

    // view
    [Route("TblRptMgrInvoicesView/{RptMgr_ID?}", Name = "TblRptMgrInvoicesView-tblRptMgrInvoices-view")]
    [Route("Home/TblRptMgrInvoicesView/{RptMgr_ID?}", Name = "TblRptMgrInvoicesView-tblRptMgrInvoices-view-2")]
    public async Task<IActionResult> TblRptMgrInvoicesView()
    {
        // Create page object
        tblRptMgrInvoicesView = new GLOBALS.TblRptMgrInvoicesView(this);

        // Run the page
        return await tblRptMgrInvoicesView.Run();
    }
}
