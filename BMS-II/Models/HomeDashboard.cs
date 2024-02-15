namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// homeDashboard
    /// </summary>
    public static HomeDashboard homeDashboard
    {
        get => HttpData.Get<HomeDashboard>("homeDashboard")!;
        set => HttpData["homeDashboard"] = value;
    }

    /// <summary>
    /// Page class for Home-Dashboard
    /// </summary>
    public class HomeDashboard : HomeDashboardBase
    {
        // Constructor
        public HomeDashboard(Controller controller) : base(controller)
        {
        }

        // Constructor
        public HomeDashboard() : base()
        {
        }

        // Page Data Rendering event
        public override void PageDataRendering(ref string header) {
        header = ("<p class=MsoNormal align=right style='text-align:right'><b><span style='font-size:16.0pt;line-height:115%;font-family:Segoe UI,sans-serif;color:#243F92'>Welcome "  + CurrentUserName() + "</span></b></p>");
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class HomeDashboardBase : ReportTable
    {
        // Page ID
        public string PageID = "dashboard";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Home-Dashboard";

        // Page object name
        public string PageObjName = "homeDashboard";

        // Title
        public string? Title = null; // Title for <title> tag

        // Page headings
        public string Heading = "";

        public string Subheading = "";

        public string PageHeader = "";

        public string PageFooter = "";

        // CSS
        public string ReportContainerClass = "ew-grid";

        // Token
        public string? Token = null; // DN

        public bool CheckToken = Config.CheckToken;

        // Action result // DN
        public IActionResult? ActionResult;

        // Cache // DN
        public IMemoryCache? Cache;

        // Page layout
        public bool UseLayout = true;

        // Page terminated // DN
        private bool _terminated = false;

        // Is terminated
        public bool IsTerminated => _terminated;

        // Is lookup
        public bool IsLookup => IsApi() && RouteValues.TryGetValue("controller", out object? name) && SameText(name, Config.ApiLookupAction);

        // Is AutoFill
        public bool IsAutoFill => IsLookup && SameText(Post("ajax"), "autofill");

        // Is AutoSuggest
        public bool IsAutoSuggest => IsLookup && SameText(Post("ajax"), "autosuggest");

        // Is modal lookup
        public bool IsModalLookup => IsLookup && SameText(Post("ajax"), "modal");

        // Page URL
        private string _pageUrl = "";

        // Constructor
        public HomeDashboardBase()
        {
            TableVar = "Home_Dashboard";
            Name = "Home-Dashboard";
            Type = "REPORT";
            TableReportType = "dashboard";
            ExportPageOrientation = "portrait"; // Page orientation (PDF only)
            ExportPageSize = "a4"; // Page size (PDF only)
            ExportColumnWidths = new float[] {  }; // Column widths (PDF only) // DN
            ExportExcelPageOrientation = "Portrait"; // Page orientation (EPPlus only)
            ExportExcelPageSize = "A4"; // Page size (EPPlus only)
            ExportWordPageOrientation = "Portrait"; // Page orientation (Word only)

            // Initialize
            TableVar = "Home_Dashboard"; // DN

            // Set running dashboard report
            DashboardReport = true;
            CurrentPage = this;

            // Language object
            Language = ResolveLanguage();

            // Table object (tblStudents)
            tblStudents = Resolve("tblStudents")!;

            // Table object (Billing_Status)
            billingStatus = Resolve("Billing_Status")!;

            // Table object (Assessment_Status)
            assessmentStatus = Resolve("Assessment_Status")!;

            // Table object (Registration_Status)
            registrationStatus = Resolve("Registration_Status")!;

            // Table object (Enrollment_Status)
            enrollmentStatus = Resolve("Enrollment_Status")!;

            // Report Page object (registrationStatusSummary)
            registrationStatusSummary = Resolve("RegistrationStatusSummary")!;

            // Report Page object (assessmentStatusSummary)
            assessmentStatusSummary = Resolve("AssessmentStatusSummary")!;

            // Report Page object (billingStatusSummary)
            billingStatusSummary = Resolve("BillingStatusSummary")!;

            // Report Page object (enrollmentStatusSummary)
            enrollmentStatusSummary = Resolve("EnrollmentStatusSummary")!;

            // Start time
            StartTime = Environment.TickCount;

            // Debug message
            LoadDebugMessage();

            // Open connection
            Conn = GetConnection();

            // User table object (tblStudents)
            UserTable = Resolve("usertable")!;
            UserTableConn = GetConnection(UserTable.DbId);
        }

        // Page action result
        public IActionResult PageResult()
        {
            if (ActionResult != null)
                return ActionResult;
            SetupMenus();
            return Controller.View();
        }

        // Page heading
        public string PageHeading
        {
            get {
                if (!Empty(Heading))
                    return Heading;
                else if (!Empty(Caption))
                    return Caption;
                else
                    return "";
            }
        }

        // Page subheading
        public string PageSubheading
        {
            get {
                if (!Empty(Subheading))
                    return Subheading;
                return "";
            }
        }

        // Page name
        public string PageName => "HomeDashboard";

        // Page URL
        public string PageUrl
        {
            get {
                if (_pageUrl == "") {
                    _pageUrl = PageName + "?";
                }
                return _pageUrl;
            }
        }

        // Show Page Header
        public IHtmlContent ShowPageHeader()
        {
            string header = PageHeader;
            PageDataRendering(ref header);
            if (!Empty(header)) // Header exists, display
                return new HtmlString("<p id=\"ew-page-header\">" + header + "</p>");
            return HtmlString.Empty;
        }

        // Show Page Footer
        public IHtmlContent ShowPageFooter()
        {
            string footer = PageFooter;
            PageDataRendered(ref footer);
            if (!Empty(footer)) // Footer exists, display
                return new HtmlString("<p id=\"ew-page-footer\">" + footer + "</p>");
            return HtmlString.Empty;
        }

        // Valid post
        protected async Task<bool> ValidPost() => !CheckToken || !IsPost() || IsApi() || Antiforgery != null && HttpContext != null && await Antiforgery.IsRequestValidAsync(HttpContext);

        // Create token
        public void CreateToken()
        {
            Token ??= HttpContext != null ? Antiforgery?.GetAndStoreTokens(HttpContext).RequestToken : null;
            CurrentToken = Token ?? ""; // Save to global variable
        }

        // Constructor
        public HomeDashboardBase(Controller? controller = null): this() { // DN
            if (controller != null)
                Controller = controller;
        }

        /// <summary>
        /// Terminate page
        /// </summary>
        /// <param name="url">URL to rediect to</param>
        /// <returns>Page result</returns>
        public override IActionResult Terminate(string url = "") { // DN
            if (_terminated) // DN
                return new EmptyResult();

            // Page Unload event
            PageUnload();

            // Global Page Unloaded event
            PageUnloaded();
            if (!IsApi())
                PageRedirecting(ref url);

            // Gargage collection
            Collect(); // DN

            // Terminate
            _terminated = true; // DN

            // Return for API
            if (IsApi()) {
                var result = new Dictionary<string, string> { { "version", Config.ProductVersion } };
                if (!Empty(url)) // Add url
                    result.Add("url", GetUrl(url));
                foreach (var (key, value) in GetMessages()) // Add messages
                    result.Add(key, value);
                return Controller.Json(result);
            } else if (ActionResult != null) { // Check action result
                return ActionResult;
            }

            // Go to URL if specified
            if (!Empty(url)) {
                if (!Config.Debug)
                    ResponseClear();
                if (Response != null && !Response.HasStarted) {
                    SaveDebugMessage();
                    return Controller.LocalRedirect(AppPath(url));
                }
            }
            return new EmptyResult();
        }

        // Dashboard properties
        public string DashboardType = "horizontal";

        public List<string> ItemClassNames = new () { "col-sm-auto", "col-sm-auto", "col-sm-auto", "col-sm-auto" };

        // Dashboard options
        public bool LoadOnInit = true;

        public bool CanRefresh = true;

        public bool CanMaximize = true;

        public bool CanCollapse = true;

        /// <summary>
        /// Page run
        /// </summary>
        /// <returns>Page result</returns>
        public override async Task<IActionResult> Run() {
            // Use layout
            if (!Empty(Param("layout")) && !Param<bool>("layout"))
                UseLayout = false;

            // User profile
            Profile = ResolveProfile();

            // Security
            Security = ResolveSecurity();
            if (TableVar != "")
                Security.LoadTablePermissions(TableVar);

            // Get export parameters
            string custom = "";
            if (!Empty(Param("export"))) {
                Export = Param("export");
                custom = Param("custom");
            }
            ExportType = Export; // Get export parameter, used in header
            if (!Empty(ExportType))
                SkipHeaderFooter = true;
            if (!Empty(Export) && !SameText(Export, "print") && Empty(custom)) // No layout for export // DN
                UseLayout = false;

            // Setup export options
            SetupExportOptions();

            // Global Page Loading event
            PageLoading();

            // Page Load event
            PageLoad();

            // Check token
            if (!await ValidPost())
                End(Language.Phrase("InvalidPostRequest"));

            // Check action result
            if (ActionResult != null) // Action result set by server event // DN
                return ActionResult;

            // Create token
            CreateToken();

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Hide export options if export
            if (IsExport()) {
                ExportOptions.HideAllOptions();
                LoadOnInit = false;
            }

            // Render initial template for custom layout
            if (DashboardType == "custom")
                LoadOnInit = false;

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                homeDashboard?.PageRender();
            }
            return PageResult();
        }

        /// <summary>
        /// Get dashboard item output
        /// </summary>
        /// <param name="id">Item ID</param>
        /// <returns>Dashboard item output</returns>
        public async Task<string> GetItem(int id) { // DN
            string content = "";
            dynamic? page;
            if (LoadOnInit)
                return content; // To be rendered by JavaScript
            if (id == 1) {
                page = Resolve("RegistrationStatusSummary");
                if (page != null) {
                    page.Export = Export;
                    page.UseAjaxActions = true; // Use Ajax actions for pager/sort
                    await page.Run();
                    content = await GetViewOutput("RegistrationStatus", page);
                }
            }
            if (id == 2) {
                page = Resolve("AssessmentStatusSummary");
                if (page != null) {
                    page.Export = Export;
                    page.UseAjaxActions = true; // Use Ajax actions for pager/sort
                    await page.Run();
                    content = await GetViewOutput("AssessmentStatus", page);
                }
            }
            if (id == 3) {
                page = Resolve("BillingStatusSummary");
                if (page != null) {
                    page.Export = Export;
                    page.UseAjaxActions = true; // Use Ajax actions for pager/sort
                    await page.Run();
                    content = await GetViewOutput("BillingStatus", page);
                }
            }
            if (id == 4) {
                page = Resolve("EnrollmentStatusSummary");
                if (page != null) {
                    page.Export = Export;
                    page.UseAjaxActions = true; // Use Ajax actions for pager/sort
                    await page.Run();
                    content = await GetViewOutput("EnrollmentStatus", page);
                }
            }
            return content;
        }

        // API page name
        public string GetApiPageName(string action) {
            return "HomeDashboard";
        }

        // Get export HTML tag
        protected string GetExportTag(string type, bool custom = false) {
            string exportUrl = AppPath(CurrentPageName()); // DN
            if (type == "print" || custom) { // Printer friendly / custom export
                exportUrl += "?export=" + type + (custom ? "&amp;custom=1" : "");
            } else {
                exportUrl = AppPath(Config.ApiUrl + Config.ApiExportAction + "/" + type + "/" + TableVar);
            }
            return type.ToLower() switch {
                "excel" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) +
                    "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToExcel") + "</button>",
                "word" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) +
                    "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToWord") + "</button>",
                "pdf" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPDF", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPDF", true)) +
                    "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToPDF") + "</button>",
                "html" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-html\" title=\"" + HtmlEncode(Language.Phrase("ExportToHtml", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToHtml", true)) +
                    "\" data-ew-action=\"export\" data-export=\"html\" data-custom=\"true\" data-export-selected=\"false\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToHtml") + "</button>",
                "email" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + HtmlEncode(Language.Phrase("ExportToEmail", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToEmail", true)) +
                    "\" data-ew-action=\"email\" data-custom=\"true\" data-export-selected=\"false\" data-hdr=\"" + HtmlEncode(Language.Phrase("ExportToEmail", true)) + "\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToEmail") + "</button>",
                "print" => "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-print\" title=\"" + HtmlEncode(Language.Phrase("PrinterFriendly", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("PrinterFriendly", true)) + "\">" + Language.Phrase("PrinterFriendly") + "</a>",
                _ => ""
            };
        }

        // Set up export options
        protected void SetupExportOptions() {
            ListOption item;

            // Printer friendly
            item = ExportOptions.Add("print");
            item.Body = GetExportTag("print");
            item.Visible = true;

            // Export to Excel
            item = ExportOptions.Add("excel");
            item.Body = GetExportTag("excel", true);
            item.Visible = true;

            // Export to Word
            item = ExportOptions.Add("word");
            item.Body = GetExportTag("word", true);
            item.Visible = false;

            // Export to HTML
            item = ExportOptions.Add("html");
            item.Body = GetExportTag("html", true);
            item.Visible = false;

            // Export to PDF
            item = ExportOptions.Add("pdf");
            item.Body = GetExportTag("pdf", true);
            item.Visible = true;

            // Export to Email
            item = ExportOptions.Add("email");
            item.Body = GetExportTag("email", true);
            item.Visible = true;

            // Drop down button for export
            ExportOptions.UseButtonGroup = true;
            ExportOptions.UseDropDownButton = false;
            if (ExportOptions.UseButtonGroup && IsMobile())
                ExportOptions.UseDropDownButton = true;
            ExportOptions.DropDownButtonPhrase = "ButtonExport";

            // Add group option item
            item = ExportOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;
            if (!Security.CanExport) // Export not allowed
                ExportOptions.HideAllOptions();
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            url = Regex.Replace(url, @"\?cmd=reset(all)?$", ""); // Remove cmd=reset / cmd=resetall
            breadcrumb.Add("dashboard", TableVar, url, "", TableVar, true);
            CurrentBreadcrumb = breadcrumb;
        }

        // Set up other options
        public void SetupOtherOptions()
        {
            // Filter button
            var item = FilterOptions.Add("savecurrentfilter");
            item.Body = "<a class=\"ew-save-filter\" data-form=\"fHome_Dashboardsrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"fHome_Dashboardsrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
            item.Visible = false;
            FilterOptions.UseDropDownButton = true;
            FilterOptions.UseButtonGroup = !FilterOptions.UseDropDownButton;
            FilterOptions.DropDownButtonPhrase = "Filters";

            // Add group option item
            item = FilterOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;
        }

        // Page Load event
        public virtual void PageLoad() {
            //Log("Page Load");
        }

        // Page Unload event
        public virtual void PageUnload() {
            //Log("Page Unload");
        }

        // Page Redirecting event
        public virtual void PageRedirecting(ref string url) {
            //url = newurl;
        }

        // Message Showing event
        // type = ""|"success"|"failure"|"warning"
        public virtual void MessageShowing(ref string msg, string type) {
            // Note: Do not change msg outside the following 4 cases.
            if (type == "success") {
                //msg = "your success message";
            } else if (type == "failure") {
                //msg = "your failure message";
            } else if (type == "warning") {
                //msg = "your warning message";
            } else {
                //msg = "your message";
            }
        }

        // Page Load event
        public virtual void PageRender() {
            //Log("Page Render");
        }

        // Page Data Rendering event
        public virtual void PageDataRendering(ref string header) {
            // Example:
            //header = "your header";
        }

        // Page Data Rendered event
        public virtual void PageDataRendered(ref string footer) {
            // Example:
            //footer = "your footer";
        }

        // Page Breaking event
        public void PageBreaking(ref bool brk, ref string content) {
            // Example:
            //	brk = false; // Skip page break, or
            //	content = "<div style=\"page-break-after:always;\">&nbsp;</div>"; // Modify page break content
        }
    } // End page class
} // End Partial class
