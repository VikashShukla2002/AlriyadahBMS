namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // list
    [Route("EquipmentList/{Equipment_ID?}", Name = "EquipmentList-Equipment-list")]
    [Route("Home/EquipmentList/{Equipment_ID?}", Name = "EquipmentList-Equipment-list-2")]
    public async Task<IActionResult> EquipmentList()
    {
        // Create page object
        equipmentList = new GLOBALS.EquipmentList(this);
        equipmentList.Cache = _cache;

        // Run the page
        return await equipmentList.Run();
    }

    // add
    [Route("EquipmentAdd/{Equipment_ID?}", Name = "EquipmentAdd-Equipment-add")]
    [Route("Home/EquipmentAdd/{Equipment_ID?}", Name = "EquipmentAdd-Equipment-add-2")]
    public async Task<IActionResult> EquipmentAdd()
    {
        // Create page object
        equipmentAdd = new GLOBALS.EquipmentAdd(this);

        // Run the page
        return await equipmentAdd.Run();
    }

    // view
    [Route("EquipmentView/{Equipment_ID?}", Name = "EquipmentView-Equipment-view")]
    [Route("Home/EquipmentView/{Equipment_ID?}", Name = "EquipmentView-Equipment-view-2")]
    public async Task<IActionResult> EquipmentView()
    {
        // Create page object
        equipmentView = new GLOBALS.EquipmentView(this);

        // Run the page
        return await equipmentView.Run();
    }

    // edit
    [Route("EquipmentEdit/{Equipment_ID?}", Name = "EquipmentEdit-Equipment-edit")]
    [Route("Home/EquipmentEdit/{Equipment_ID?}", Name = "EquipmentEdit-Equipment-edit-2")]
    public async Task<IActionResult> EquipmentEdit()
    {
        // Create page object
        equipmentEdit = new GLOBALS.EquipmentEdit(this);

        // Run the page
        return await equipmentEdit.Run();
    }

    // delete
    [Route("EquipmentDelete/{Equipment_ID?}", Name = "EquipmentDelete-Equipment-delete")]
    [Route("Home/EquipmentDelete/{Equipment_ID?}", Name = "EquipmentDelete-Equipment-delete-2")]
    public async Task<IActionResult> EquipmentDelete()
    {
        // Create page object
        equipmentDelete = new GLOBALS.EquipmentDelete(this);

        // Run the page
        return await equipmentDelete.Run();
    }
}
