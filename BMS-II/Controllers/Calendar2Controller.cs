namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("Calendar2List/{Id?}", Name = "Calendar2List-Calendar2-list")]
    [Route("Home/Calendar2List/{Id?}", Name = "Calendar2List-Calendar2-list-2")]
    public async Task<IActionResult> Calendar2List()
    {
        // Create page object
        calendar2List = new GLOBALS.Calendar2List(this);
        calendar2List.Cache = _cache;

        // Run the page
        return await calendar2List.Run();
    }

    // add
    [Route("Calendar2Add/{Id?}", Name = "Calendar2Add-Calendar2-add")]
    [Route("Home/Calendar2Add/{Id?}", Name = "Calendar2Add-Calendar2-add-2")]
    public async Task<IActionResult> Calendar2Add()
    {
        // Create page object
        calendar2Add = new GLOBALS.Calendar2Add(this);

        // Run the page
        return await calendar2Add.Run();
    }

    // view
    [Route("Calendar2View/{Id?}", Name = "Calendar2View-Calendar2-view")]
    [Route("Home/Calendar2View/{Id?}", Name = "Calendar2View-Calendar2-view-2")]
    public async Task<IActionResult> Calendar2View()
    {
        // Create page object
        calendar2View = new GLOBALS.Calendar2View(this);

        // Run the page
        return await calendar2View.Run();
    }

    // edit
    [Route("Calendar2Edit/{Id?}", Name = "Calendar2Edit-Calendar2-edit")]
    [Route("Home/Calendar2Edit/{Id?}", Name = "Calendar2Edit-Calendar2-edit-2")]
    public async Task<IActionResult> Calendar2Edit()
    {
        // Create page object
        calendar2Edit = new GLOBALS.Calendar2Edit(this);

        // Run the page
        return await calendar2Edit.Run();
    }

    // delete
    [Route("Calendar2Delete/{Id?}", Name = "Calendar2Delete-Calendar2-delete")]
    [Route("Home/Calendar2Delete/{Id?}", Name = "Calendar2Delete-Calendar2-delete-2")]
    public async Task<IActionResult> Calendar2Delete()
    {
        // Create page object
        calendar2Delete = new GLOBALS.Calendar2Delete(this);

        // Run the page
        return await calendar2Delete.Run();
    }
}
