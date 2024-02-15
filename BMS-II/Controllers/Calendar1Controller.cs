namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Calendar1 (calendar)
    [Route("Calendar1", Name = "Calendar1-Calendar1-calendar")]
    [Route("Home/Calendar1", Name = "Calendar1-Calendar1-calendar-2")]
    public async Task<IActionResult> Calendar1()
    {
        // Create page object
        calendar1Calendar = new GLOBALS.Calendar1Calendar(this);

        // Run the page
        return await calendar1Calendar.Run();
    }

    // Calendar1 (add)
    [Route("Calendar1Add/{Id?}", Name = "Calendar1Add-Calendar1-add")]
    [Route("Home/Calendar1Add/{Id?}", Name = "Calendar1Add-Calendar1-add-2")]
    public async Task<IActionResult> Calendar1Add()
    {
        // Create page object
        calendar1Add = new GLOBALS.Calendar1Add(this);

        // Run the page
        return await calendar1Add.Run();
    }

    // Calendar1 (view)
    [Route("Calendar1View/{Id?}", Name = "Calendar1View-Calendar1-view")]
    [Route("Home/Calendar1View/{Id?}", Name = "Calendar1View-Calendar1-view-2")]
    public async Task<IActionResult> Calendar1View()
    {
        // Create page object
        calendar1View = new GLOBALS.Calendar1View(this);

        // Run the page
        return await calendar1View.Run();
    }

    // Calendar1 (edit)
    [Route("Calendar1Edit/{Id?}", Name = "Calendar1Edit-Calendar1-edit")]
    [Route("Home/Calendar1Edit/{Id?}", Name = "Calendar1Edit-Calendar1-edit-2")]
    public async Task<IActionResult> Calendar1Edit()
    {
        // Create page object
        calendar1Edit = new GLOBALS.Calendar1Edit(this);

        // Run the page
        return await calendar1Edit.Run();
    }

    // Calendar1 (delete)
    [Route("Calendar1Delete/{Id?}", Name = "Calendar1Delete-Calendar1-delete")]
    [Route("Home/Calendar1Delete/{Id?}", Name = "Calendar1Delete-Calendar1-delete-2")]
    public async Task<IActionResult> Calendar1Delete()
    {
        // Create page object
        calendar1Delete = new GLOBALS.Calendar1Delete(this);

        // Run the page
        return await calendar1Delete.Run();
    }
}
