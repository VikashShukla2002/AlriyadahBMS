namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblClassRoomList/{int_CR_ID?}", Name = "TblClassRoomList-tblClassRoom-list")]
    [Route("Home/TblClassRoomList/{int_CR_ID?}", Name = "TblClassRoomList-tblClassRoom-list-2")]
    public async Task<IActionResult> TblClassRoomList()
    {
        // Create page object
        tblClassRoomList = new GLOBALS.TblClassRoomList(this);
        tblClassRoomList.Cache = _cache;

        // Run the page
        return await tblClassRoomList.Run();
    }

    // add
    [Route("TblClassRoomAdd/{int_CR_ID?}", Name = "TblClassRoomAdd-tblClassRoom-add")]
    [Route("Home/TblClassRoomAdd/{int_CR_ID?}", Name = "TblClassRoomAdd-tblClassRoom-add-2")]
    public async Task<IActionResult> TblClassRoomAdd()
    {
        // Create page object
        tblClassRoomAdd = new GLOBALS.TblClassRoomAdd(this);

        // Run the page
        return await tblClassRoomAdd.Run();
    }

    // view
    [Route("TblClassRoomView/{int_CR_ID?}", Name = "TblClassRoomView-tblClassRoom-view")]
    [Route("Home/TblClassRoomView/{int_CR_ID?}", Name = "TblClassRoomView-tblClassRoom-view-2")]
    public async Task<IActionResult> TblClassRoomView()
    {
        // Create page object
        tblClassRoomView = new GLOBALS.TblClassRoomView(this);

        // Run the page
        return await tblClassRoomView.Run();
    }

    // edit
    [Route("TblClassRoomEdit/{int_CR_ID?}", Name = "TblClassRoomEdit-tblClassRoom-edit")]
    [Route("Home/TblClassRoomEdit/{int_CR_ID?}", Name = "TblClassRoomEdit-tblClassRoom-edit-2")]
    public async Task<IActionResult> TblClassRoomEdit()
    {
        // Create page object
        tblClassRoomEdit = new GLOBALS.TblClassRoomEdit(this);

        // Run the page
        return await tblClassRoomEdit.Run();
    }
}
