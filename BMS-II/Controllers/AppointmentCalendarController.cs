namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Appointment_Calendar (calendar)
    [Route("AppointmentCalendar", Name = "AppointmentCalendar-Appointment_Calendar-calendar")]
    [Route("Home/AppointmentCalendar", Name = "AppointmentCalendar-Appointment_Calendar-calendar-2")]
    public async Task<IActionResult> AppointmentCalendar()
    {
        // Create page object
        appointmentCalendarCalendar = new GLOBALS.AppointmentCalendarCalendar(this);

        // Run the page
        return await appointmentCalendarCalendar.Run();
    }

    // Appointment_Calendar (add)
    [Route("AppointmentCalendarAdd/{Id?}", Name = "AppointmentCalendarAdd-Appointment_Calendar-add")]
    [Route("Home/AppointmentCalendarAdd/{Id?}", Name = "AppointmentCalendarAdd-Appointment_Calendar-add-2")]
    public async Task<IActionResult> AppointmentCalendarAdd()
    {
        // Create page object
        appointmentCalendarAdd = new GLOBALS.AppointmentCalendarAdd(this);

        // Run the page
        return await appointmentCalendarAdd.Run();
    }

    // Appointment_Calendar (view)
    [Route("AppointmentCalendarView/{Id?}", Name = "AppointmentCalendarView-Appointment_Calendar-view")]
    [Route("Home/AppointmentCalendarView/{Id?}", Name = "AppointmentCalendarView-Appointment_Calendar-view-2")]
    public async Task<IActionResult> AppointmentCalendarView()
    {
        // Create page object
        appointmentCalendarView = new GLOBALS.AppointmentCalendarView(this);

        // Run the page
        return await appointmentCalendarView.Run();
    }

    // Appointment_Calendar (edit)
    [Route("AppointmentCalendarEdit/{Id?}", Name = "AppointmentCalendarEdit-Appointment_Calendar-edit")]
    [Route("Home/AppointmentCalendarEdit/{Id?}", Name = "AppointmentCalendarEdit-Appointment_Calendar-edit-2")]
    public async Task<IActionResult> AppointmentCalendarEdit()
    {
        // Create page object
        appointmentCalendarEdit = new GLOBALS.AppointmentCalendarEdit(this);

        // Run the page
        return await appointmentCalendarEdit.Run();
    }

    // Appointment_Calendar (delete)
    [Route("AppointmentCalendarDelete/{Id?}", Name = "AppointmentCalendarDelete-Appointment_Calendar-delete")]
    [Route("Home/AppointmentCalendarDelete/{Id?}", Name = "AppointmentCalendarDelete-Appointment_Calendar-delete-2")]
    public async Task<IActionResult> AppointmentCalendarDelete()
    {
        // Create page object
        appointmentCalendarDelete = new GLOBALS.AppointmentCalendarDelete(this);

        // Run the page
        return await appointmentCalendarDelete.Run();
    }
}
