namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("UserLevelPermissionsList/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsList-UserLevelPermissions-list")]
    [Route("Home/UserLevelPermissionsList/{UserLevelID?}/{_TableName?}", Name = "UserLevelPermissionsList-UserLevelPermissions-list-2")]
    public async Task<IActionResult> UserLevelPermissionsList()
    {
        // Create page object
        userLevelPermissionsList = new GLOBALS.UserLevelPermissionsList(this);
        userLevelPermissionsList.Cache = _cache;

        // Run the page
        return await userLevelPermissionsList.Run();
    }
}
