namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("AppointmentCldrList/{Id?}", Name = "AppointmentCldrList-Appointment_Cldr-list")]
    [Route("Home/AppointmentCldrList/{Id?}", Name = "AppointmentCldrList-Appointment_Cldr-list-2")]
    public async Task<IActionResult> AppointmentCldrList()
    {
        // Create page object
        appointmentCldrList = new GLOBALS.AppointmentCldrList(this);
        appointmentCldrList.Cache = _cache;

        // Run the page
        return await appointmentCldrList.Run();
    }

    // add
    [Route("AppointmentCldrAdd/{Id?}", Name = "AppointmentCldrAdd-Appointment_Cldr-add")]
    [Route("Home/AppointmentCldrAdd/{Id?}", Name = "AppointmentCldrAdd-Appointment_Cldr-add-2")]
    public async Task<IActionResult> AppointmentCldrAdd()
    {
        // Create page object
        appointmentCldrAdd = new GLOBALS.AppointmentCldrAdd(this);

        // Run the page
        return await appointmentCldrAdd.Run();
    }

    // view
    [Route("AppointmentCldrView/{Id?}", Name = "AppointmentCldrView-Appointment_Cldr-view")]
    [Route("Home/AppointmentCldrView/{Id?}", Name = "AppointmentCldrView-Appointment_Cldr-view-2")]
    public async Task<IActionResult> AppointmentCldrView()
    {
        // Create page object
        appointmentCldrView = new GLOBALS.AppointmentCldrView(this);

        // Run the page
        return await appointmentCldrView.Run();
    }

    // edit
    [Route("AppointmentCldrEdit/{Id?}", Name = "AppointmentCldrEdit-Appointment_Cldr-edit")]
    [Route("Home/AppointmentCldrEdit/{Id?}", Name = "AppointmentCldrEdit-Appointment_Cldr-edit-2")]
    public async Task<IActionResult> AppointmentCldrEdit()
    {
        // Create page object
        appointmentCldrEdit = new GLOBALS.AppointmentCldrEdit(this);

        // Run the page
        return await appointmentCldrEdit.Run();
    }

    // delete
    [Route("AppointmentCldrDelete/{Id?}", Name = "AppointmentCldrDelete-Appointment_Cldr-delete")]
    [Route("Home/AppointmentCldrDelete/{Id?}", Name = "AppointmentCldrDelete-Appointment_Cldr-delete-2")]
    public async Task<IActionResult> AppointmentCldrDelete()
    {
        // Create page object
        appointmentCldrDelete = new GLOBALS.AppointmentCldrDelete(this);

        // Run the page
        return await appointmentCldrDelete.Run();
    }
}
