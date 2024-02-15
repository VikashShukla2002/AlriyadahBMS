namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Classroom_Calendar (calendar)
    [Route("ClassroomCalendar", Name = "ClassroomCalendar-Classroom_Calendar-calendar")]
    [Route("Home/ClassroomCalendar", Name = "ClassroomCalendar-Classroom_Calendar-calendar-2")]
    public async Task<IActionResult> ClassroomCalendar()
    {
        // Create page object
        classroomCalendarCalendar = new GLOBALS.ClassroomCalendarCalendar(this);

        // Run the page
        return await classroomCalendarCalendar.Run();
    }

    // Classroom_Calendar (add)
    [Route("ClassroomCalendarAdd/{Id?}", Name = "ClassroomCalendarAdd-Classroom_Calendar-add")]
    [Route("Home/ClassroomCalendarAdd/{Id?}", Name = "ClassroomCalendarAdd-Classroom_Calendar-add-2")]
    public async Task<IActionResult> ClassroomCalendarAdd()
    {
        // Create page object
        classroomCalendarAdd = new GLOBALS.ClassroomCalendarAdd(this);

        // Run the page
        return await classroomCalendarAdd.Run();
    }

    // Classroom_Calendar (view)
    [Route("ClassroomCalendarView/{Id?}", Name = "ClassroomCalendarView-Classroom_Calendar-view")]
    [Route("Home/ClassroomCalendarView/{Id?}", Name = "ClassroomCalendarView-Classroom_Calendar-view-2")]
    public async Task<IActionResult> ClassroomCalendarView()
    {
        // Create page object
        classroomCalendarView = new GLOBALS.ClassroomCalendarView(this);

        // Run the page
        return await classroomCalendarView.Run();
    }

    // Classroom_Calendar (edit)
    [Route("ClassroomCalendarEdit/{Id?}", Name = "ClassroomCalendarEdit-Classroom_Calendar-edit")]
    [Route("Home/ClassroomCalendarEdit/{Id?}", Name = "ClassroomCalendarEdit-Classroom_Calendar-edit-2")]
    public async Task<IActionResult> ClassroomCalendarEdit()
    {
        // Create page object
        classroomCalendarEdit = new GLOBALS.ClassroomCalendarEdit(this);

        // Run the page
        return await classroomCalendarEdit.Run();
    }

    // Classroom_Calendar (delete)
    [Route("ClassroomCalendarDelete/{Id?}", Name = "ClassroomCalendarDelete-Classroom_Calendar-delete")]
    [Route("Home/ClassroomCalendarDelete/{Id?}", Name = "ClassroomCalendarDelete-Classroom_Calendar-delete-2")]
    public async Task<IActionResult> ClassroomCalendarDelete()
    {
        // Create page object
        classroomCalendarDelete = new GLOBALS.ClassroomCalendarDelete(this);

        // Run the page
        return await classroomCalendarDelete.Run();
    }
}
