namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblCrAttendanceList/{int_Attendance_ID?}", Name = "TblCrAttendanceList-tblCRAttendance-list")]
    [Route("Home/TblCrAttendanceList/{int_Attendance_ID?}", Name = "TblCrAttendanceList-tblCRAttendance-list-2")]
    public async Task<IActionResult> TblCrAttendanceList()
    {
        // Create page object
        tblCrAttendanceList = new GLOBALS.TblCrAttendanceList(this);
        tblCrAttendanceList.Cache = _cache;

        // Run the page
        return await tblCrAttendanceList.Run();
    }

    // view
    [Route("TblCrAttendanceView/{int_Attendance_ID?}", Name = "TblCrAttendanceView-tblCRAttendance-view")]
    [Route("Home/TblCrAttendanceView/{int_Attendance_ID?}", Name = "TblCrAttendanceView-tblCRAttendance-view-2")]
    public async Task<IActionResult> TblCrAttendanceView()
    {
        // Create page object
        tblCrAttendanceView = new GLOBALS.TblCrAttendanceView(this);

        // Run the page
        return await tblCrAttendanceView.Run();
    }

    // edit
    [Route("TblCrAttendanceEdit/{int_Attendance_ID?}", Name = "TblCrAttendanceEdit-tblCRAttendance-edit")]
    [Route("Home/TblCrAttendanceEdit/{int_Attendance_ID?}", Name = "TblCrAttendanceEdit-tblCRAttendance-edit-2")]
    public async Task<IActionResult> TblCrAttendanceEdit()
    {
        // Create page object
        tblCrAttendanceEdit = new GLOBALS.TblCrAttendanceEdit(this);

        // Run the page
        return await tblCrAttendanceEdit.Run();
    }
}
