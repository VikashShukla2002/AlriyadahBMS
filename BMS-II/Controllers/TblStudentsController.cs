namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblStudentsList/{int_Student_ID?}", Name = "TblStudentsList-tblStudents-list")]
    [Route("Home/TblStudentsList/{int_Student_ID?}", Name = "TblStudentsList-tblStudents-list-2")]
    public async Task<IActionResult> TblStudentsList()
    {
        // Create page object
        tblStudentsList = new GLOBALS.TblStudentsList(this);
        tblStudentsList.Cache = _cache;

        // Run the page
        return await tblStudentsList.Run();
    }

    // view
    [Route("TblStudentsView/{int_Student_ID?}", Name = "TblStudentsView-tblStudents-view")]
    [Route("Home/TblStudentsView/{int_Student_ID?}", Name = "TblStudentsView-tblStudents-view-2")]
    public async Task<IActionResult> TblStudentsView()
    {
        // Create page object
        tblStudentsView = new GLOBALS.TblStudentsView(this);

        // Run the page
        return await tblStudentsView.Run();
    }

    // edit
    [Route("TblStudentsEdit/{int_Student_ID?}", Name = "TblStudentsEdit-tblStudents-edit")]
    [Route("Home/TblStudentsEdit/{int_Student_ID?}", Name = "TblStudentsEdit-tblStudents-edit-2")]
    public async Task<IActionResult> TblStudentsEdit()
    {
        // Create page object
        tblStudentsEdit = new GLOBALS.TblStudentsEdit(this);

        // Run the page
        return await tblStudentsEdit.Run();
    }

    // update
    [Route("TblStudentsUpdate", Name = "TblStudentsUpdate-tblStudents-update")]
    [Route("Home/TblStudentsUpdate", Name = "TblStudentsUpdate-tblStudents-update-2")]
    public async Task<IActionResult> TblStudentsUpdate()
    {
        // Create page object
        tblStudentsUpdate = new GLOBALS.TblStudentsUpdate(this);

        // Run the page
        return await tblStudentsUpdate.Run();
    }
}
