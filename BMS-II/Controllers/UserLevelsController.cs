namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("UserLevelsList/{UserLevelID?}", Name = "UserLevelsList-UserLevels-list")]
    [Route("Home/UserLevelsList/{UserLevelID?}", Name = "UserLevelsList-UserLevels-list-2")]
    public async Task<IActionResult> UserLevelsList()
    {
        // Create page object
        userLevelsList = new GLOBALS.UserLevelsList(this);
        userLevelsList.Cache = _cache;

        // Run the page
        return await userLevelsList.Run();
    }

    // add
    [Route("UserLevelsAdd/{UserLevelID?}", Name = "UserLevelsAdd-UserLevels-add")]
    [Route("Home/UserLevelsAdd/{UserLevelID?}", Name = "UserLevelsAdd-UserLevels-add-2")]
    public async Task<IActionResult> UserLevelsAdd()
    {
        // Create page object
        userLevelsAdd = new GLOBALS.UserLevelsAdd(this);

        // Run the page
        return await userLevelsAdd.Run();
    }

    // edit
    [Route("UserLevelsEdit/{UserLevelID?}", Name = "UserLevelsEdit-UserLevels-edit")]
    [Route("Home/UserLevelsEdit/{UserLevelID?}", Name = "UserLevelsEdit-UserLevels-edit-2")]
    public async Task<IActionResult> UserLevelsEdit()
    {
        // Create page object
        userLevelsEdit = new GLOBALS.UserLevelsEdit(this);

        // Run the page
        return await userLevelsEdit.Run();
    }
}
