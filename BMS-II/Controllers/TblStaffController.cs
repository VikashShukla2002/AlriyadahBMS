namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblStaffList/{int_Staff_Id?}", Name = "TblStaffList-tblStaff-list")]
    [Route("Home/TblStaffList/{int_Staff_Id?}", Name = "TblStaffList-tblStaff-list-2")]
    public async Task<IActionResult> TblStaffList()
    {
        // Create page object
        tblStaffList = new GLOBALS.TblStaffList(this);
        tblStaffList.Cache = _cache;

        // Run the page
        return await tblStaffList.Run();
    }

    // add
    [Route("TblStaffAdd/{int_Staff_Id?}", Name = "TblStaffAdd-tblStaff-add")]
    [Route("Home/TblStaffAdd/{int_Staff_Id?}", Name = "TblStaffAdd-tblStaff-add-2")]
    public async Task<IActionResult> TblStaffAdd()
    {
        // Create page object
        tblStaffAdd = new GLOBALS.TblStaffAdd(this);

        // Run the page
        return await tblStaffAdd.Run();
    }

    // view
    [Route("TblStaffView/{int_Staff_Id?}", Name = "TblStaffView-tblStaff-view")]
    [Route("Home/TblStaffView/{int_Staff_Id?}", Name = "TblStaffView-tblStaff-view-2")]
    public async Task<IActionResult> TblStaffView()
    {
        // Create page object
        tblStaffView = new GLOBALS.TblStaffView(this);

        // Run the page
        return await tblStaffView.Run();
    }

    // edit
    [Route("TblStaffEdit/{int_Staff_Id?}", Name = "TblStaffEdit-tblStaff-edit")]
    [Route("Home/TblStaffEdit/{int_Staff_Id?}", Name = "TblStaffEdit-tblStaff-edit-2")]
    public async Task<IActionResult> TblStaffEdit()
    {
        // Create page object
        tblStaffEdit = new GLOBALS.TblStaffEdit(this);

        // Run the page
        return await tblStaffEdit.Run();
    }
}
