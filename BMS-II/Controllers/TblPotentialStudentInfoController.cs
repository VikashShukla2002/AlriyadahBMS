namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("TblPotentialStudentInfoList/{int_Potential_Student_ID?}", Name = "TblPotentialStudentInfoList-tblPotentialStudentInfo-list")]
    [Route("Home/TblPotentialStudentInfoList/{int_Potential_Student_ID?}", Name = "TblPotentialStudentInfoList-tblPotentialStudentInfo-list-2")]
    public async Task<IActionResult> TblPotentialStudentInfoList()
    {
        // Create page object
        tblPotentialStudentInfoList = new GLOBALS.TblPotentialStudentInfoList(this);
        tblPotentialStudentInfoList.Cache = _cache;

        // Run the page
        return await tblPotentialStudentInfoList.Run();
    }

    // edit
    [Route("TblPotentialStudentInfoEdit/{int_Potential_Student_ID?}", Name = "TblPotentialStudentInfoEdit-tblPotentialStudentInfo-edit")]
    [Route("Home/TblPotentialStudentInfoEdit/{int_Potential_Student_ID?}", Name = "TblPotentialStudentInfoEdit-tblPotentialStudentInfo-edit-2")]
    public async Task<IActionResult> TblPotentialStudentInfoEdit()
    {
        // Create page object
        tblPotentialStudentInfoEdit = new GLOBALS.TblPotentialStudentInfoEdit(this);

        // Run the page
        return await tblPotentialStudentInfoEdit.Run();
    }

    // search
    [Route("TblPotentialStudentInfoSearch", Name = "TblPotentialStudentInfoSearch-tblPotentialStudentInfo-search")]
    [Route("Home/TblPotentialStudentInfoSearch", Name = "TblPotentialStudentInfoSearch-tblPotentialStudentInfo-search-2")]
    public async Task<IActionResult> TblPotentialStudentInfoSearch()
    {
        // Create page object
        tblPotentialStudentInfoSearch = new GLOBALS.TblPotentialStudentInfoSearch(this);

        // Run the page
        return await tblPotentialStudentInfoSearch.Run();
    }
}
