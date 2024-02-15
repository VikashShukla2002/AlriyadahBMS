namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblAppointmentsInfoList/{int_Appt_id?}", Name = "TblAppointmentsInfoList-tblAppointmentsInfo-list")]
    [Route("Home/TblAppointmentsInfoList/{int_Appt_id?}", Name = "TblAppointmentsInfoList-tblAppointmentsInfo-list-2")]
    public async Task<IActionResult> TblAppointmentsInfoList()
    {
        // Create page object
        tblAppointmentsInfoList = new GLOBALS.TblAppointmentsInfoList(this);
        tblAppointmentsInfoList.Cache = _cache;

        // Run the page
        return await tblAppointmentsInfoList.Run();
    }

    // add
    [Route("TblAppointmentsInfoAdd/{int_Appt_id?}", Name = "TblAppointmentsInfoAdd-tblAppointmentsInfo-add")]
    [Route("Home/TblAppointmentsInfoAdd/{int_Appt_id?}", Name = "TblAppointmentsInfoAdd-tblAppointmentsInfo-add-2")]
    public async Task<IActionResult> TblAppointmentsInfoAdd()
    {
        // Create page object
        tblAppointmentsInfoAdd = new GLOBALS.TblAppointmentsInfoAdd(this);

        // Run the page
        return await tblAppointmentsInfoAdd.Run();
    }

    // view
    [Route("TblAppointmentsInfoView/{int_Appt_id?}", Name = "TblAppointmentsInfoView-tblAppointmentsInfo-view")]
    [Route("Home/TblAppointmentsInfoView/{int_Appt_id?}", Name = "TblAppointmentsInfoView-tblAppointmentsInfo-view-2")]
    public async Task<IActionResult> TblAppointmentsInfoView()
    {
        // Create page object
        tblAppointmentsInfoView = new GLOBALS.TblAppointmentsInfoView(this);

        // Run the page
        return await tblAppointmentsInfoView.Run();
    }

    // edit
    [Route("TblAppointmentsInfoEdit/{int_Appt_id?}", Name = "TblAppointmentsInfoEdit-tblAppointmentsInfo-edit")]
    [Route("Home/TblAppointmentsInfoEdit/{int_Appt_id?}", Name = "TblAppointmentsInfoEdit-tblAppointmentsInfo-edit-2")]
    public async Task<IActionResult> TblAppointmentsInfoEdit()
    {
        // Create page object
        tblAppointmentsInfoEdit = new GLOBALS.TblAppointmentsInfoEdit(this);

        // Run the page
        return await tblAppointmentsInfoEdit.Run();
    }

    // delete
    [Route("TblAppointmentsInfoDelete/{int_Appt_id?}", Name = "TblAppointmentsInfoDelete-tblAppointmentsInfo-delete")]
    [Route("Home/TblAppointmentsInfoDelete/{int_Appt_id?}", Name = "TblAppointmentsInfoDelete-tblAppointmentsInfo-delete-2")]
    public async Task<IActionResult> TblAppointmentsInfoDelete()
    {
        // Create page object
        tblAppointmentsInfoDelete = new GLOBALS.TblAppointmentsInfoDelete(this);

        // Run the page
        return await tblAppointmentsInfoDelete.Run();
    }
}
