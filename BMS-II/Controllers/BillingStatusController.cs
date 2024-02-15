namespace ASPNETMaker2023.Controllers;

// Partial class
public partial class HomeController : Controller
{
    // Billing Status (summary)
    [Route("BillingStatus", Name = "BillingStatus-Billing_Status-summary")]
    [Route("Home/BillingStatus", Name = "BillingStatus-Billing_Status-summary-2")]
    public async Task<IActionResult> BillingStatus()
    {
        // Create page object
        billingStatusSummary = new GLOBALS.BillingStatusSummary(this);

        // Run the page
        return await billingStatusSummary.Run();
    }
}
