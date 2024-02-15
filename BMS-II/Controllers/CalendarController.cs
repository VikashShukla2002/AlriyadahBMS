namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("CalendarList/{Id?}", Name = "CalendarList-Calendar-list")]
    [Route("Home/CalendarList/{Id?}", Name = "CalendarList-Calendar-list-2")]
    public async Task<IActionResult> CalendarList()
    {
        // Create page object
        calendarList = new GLOBALS.CalendarList(this);
        calendarList.Cache = _cache;

        // Run the page
        return await calendarList.Run();
    }

    // add
    [Route("CalendarAdd/{Id?}", Name = "CalendarAdd-Calendar-add")]
    [Route("Home/CalendarAdd/{Id?}", Name = "CalendarAdd-Calendar-add-2")]
    public async Task<IActionResult> CalendarAdd()
    {
        // Create page object
        calendarAdd = new GLOBALS.CalendarAdd(this);

        // Run the page
        return await calendarAdd.Run();
    }

    // view
    [Route("CalendarView/{Id?}", Name = "CalendarView-Calendar-view")]
    [Route("Home/CalendarView/{Id?}", Name = "CalendarView-Calendar-view-2")]
    public async Task<IActionResult> CalendarView()
    {
        // Create page object
        calendarView = new GLOBALS.CalendarView(this);

        // Run the page
        return await calendarView.Run();
    }

    // edit
    [Route("CalendarEdit/{Id?}", Name = "CalendarEdit-Calendar-edit")]
    [Route("Home/CalendarEdit/{Id?}", Name = "CalendarEdit-Calendar-edit-2")]
    public async Task<IActionResult> CalendarEdit()
    {
        // Create page object
        calendarEdit = new GLOBALS.CalendarEdit(this);

        // Run the page
        return await calendarEdit.Run();
    }

    // delete
    [Route("CalendarDelete/{Id?}", Name = "CalendarDelete-Calendar-delete")]
    [Route("Home/CalendarDelete/{Id?}", Name = "CalendarDelete-Calendar-delete-2")]
    public async Task<IActionResult> CalendarDelete()
    {
        // Create page object
        calendarDelete = new GLOBALS.CalendarDelete(this);

        // Run the page
        return await calendarDelete.Run();
    }
}
