namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblBillingInfoList/{int_Bill_ID?}", Name = "TblBillingInfoList-tblBillingInfo-list")]
    [Route("Home/TblBillingInfoList/{int_Bill_ID?}", Name = "TblBillingInfoList-tblBillingInfo-list-2")]
    public async Task<IActionResult> TblBillingInfoList()
    {
        // Create page object
        tblBillingInfoList = new GLOBALS.TblBillingInfoList(this);
        tblBillingInfoList.Cache = _cache;

        // Run the page
        return await tblBillingInfoList.Run();
    }

    // add
    [Route("TblBillingInfoAdd/{int_Bill_ID?}", Name = "TblBillingInfoAdd-tblBillingInfo-add")]
    [Route("Home/TblBillingInfoAdd/{int_Bill_ID?}", Name = "TblBillingInfoAdd-tblBillingInfo-add-2")]
    public async Task<IActionResult> TblBillingInfoAdd()
    {
        // Create page object
        tblBillingInfoAdd = new GLOBALS.TblBillingInfoAdd(this);

        // Run the page
        return await tblBillingInfoAdd.Run();
    }

    // view
    [Route("TblBillingInfoView/{int_Bill_ID?}", Name = "TblBillingInfoView-tblBillingInfo-view")]
    [Route("Home/TblBillingInfoView/{int_Bill_ID?}", Name = "TblBillingInfoView-tblBillingInfo-view-2")]
    public async Task<IActionResult> TblBillingInfoView()
    {
        // Create page object
        tblBillingInfoView = new GLOBALS.TblBillingInfoView(this);

        // Run the page
        return await tblBillingInfoView.Run();
    }

    // edit
    [Route("TblBillingInfoEdit/{int_Bill_ID?}", Name = "TblBillingInfoEdit-tblBillingInfo-edit")]
    [Route("Home/TblBillingInfoEdit/{int_Bill_ID?}", Name = "TblBillingInfoEdit-tblBillingInfo-edit-2")]
    public async Task<IActionResult> TblBillingInfoEdit()
    {
        // Create page object
        tblBillingInfoEdit = new GLOBALS.TblBillingInfoEdit(this);

        // Run the page
        return await tblBillingInfoEdit.Run();
    }

    // preview
    [Route("TblBillingInfoPreview", Name = "TblBillingInfoPreview-tblBillingInfo-preview")]
    [Route("Home/TblBillingInfoPreview", Name = "TblBillingInfoPreview-tblBillingInfo-preview-2")]
    [HttpCacheExpiration(CacheLocation = CacheLocation.Private, NoStore = true, MaxAge = 0)]
    public async Task<IActionResult> TblBillingInfoPreview()
    {
        // Create page object
        tblBillingInfoPreview = new GLOBALS.TblBillingInfoPreview(this);

        // Run the page
        return await tblBillingInfoPreview.Run();
    }
}
