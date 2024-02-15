namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("QryClassRoomListList/{int_CR_ID?}", Name = "QryClassRoomListList-qryClassRoomList-list")]
    [Route("Home/QryClassRoomListList/{int_CR_ID?}", Name = "QryClassRoomListList-qryClassRoomList-list-2")]
    public async Task<IActionResult> QryClassRoomListList()
    {
        // Create page object
        qryClassRoomListList = new GLOBALS.QryClassRoomListList(this);
        qryClassRoomListList.Cache = _cache;

        // Run the page
        return await qryClassRoomListList.Run();
    }
}
