namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// classStatusSummary
    /// </summary>
    public static ClassStatusSummary classStatusSummary
    {
        get => HttpData.Get<ClassStatusSummary>("classStatusSummary")!;
        set => HttpData["classStatusSummary"] = value;
    }

    /// <summary>
    /// Page class for Class Status
    /// </summary>
    public class ClassStatusSummary : ClassStatusSummaryBase
    {
        // Constructor
        public ClassStatusSummary(Controller controller) : base(controller)
        {
        }

        // Constructor
        public ClassStatusSummary() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class ClassStatusSummaryBase : ClassStatus
    {
        // Page ID
        public string PageID = "summary";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Class Status";

        // Page object name
        public string PageObjName = "classStatusSummary";

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
        public ClassStatusSummaryBase()
        {
            // CSS class name as context
            TableVar = "Class_Status";
            ContextClass = CheckClassName(TableVar);
            ReportContainerClass = AppendClass(ReportContainerClass, ContextClass);

            // Initialize
            TableVar = "Class_Status"; // DN
            if (!DashboardReport)
                CurrentPage = this;

            // CSS class name as context
            ContextClass = CheckClassName(TableVar);
            ReportContainerClass = AppendClass(ReportContainerClass, ContextClass);

            // Language object
            Language = ResolveLanguage();

            // Table object (classStatus)
            if (classStatus == null || classStatus is ClassStatus)
                classStatus = this;

            // Initialize URLs

            // Start time
            StartTime = Environment.TickCount;

            // Debug message
            LoadDebugMessage();

            // Open connection
            Conn = Connection; // DN

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
        public string PageName => "ClassStatus";

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
        public ClassStatusSummaryBase(Controller? controller = null): this() { // DN
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

        /// <summary>
        /// Run chart
        /// </summary>
        /// <param name="chartVar">Chart variable name</param>
        /// <returns>Page result</returns>
        public async Task<IActionResult> RunChart(string chartVar = "") { // DN
            IActionResult res = await Run();
            DbChart? chart = ChartByParam(chartVar);
            if (!IsTerminated && chart != null) {
                string chartClass = (chart.PageBreakType == "before") ? "ew-chart-bottom" : "ew-chart-top";
                int chartWidth = Query.TryGetValue("width", out StringValues sv) ? ConvertToInt(sv) : -1;
                int chartHeight = Query.TryGetValue("height", out StringValues sv2) ? ConvertToInt(sv2) : -1;
                return Controller.Content(ConvertToString(await chart.Render(chartClass, chartWidth, chartHeight)), "text/html", Encoding.UTF8);
            }
            return res;
        }

        #pragma warning disable 219
        /// <summary>
        /// Lookup data from table
        /// </summary>
        public async Task<Dictionary<string, object>> Lookup(Dictionary<string, string>? dict = null)
        {
            Language = ResolveLanguage();
            Security = ResolveSecurity();
            string? v;

            // Get lookup object
            string fieldName = IsDictionary(dict) && dict.TryGetValue("field", out v) && v != null ? v : Post("field");
            var lookupField = FieldByName(fieldName);
            var lookup = lookupField?.Lookup;
            if (lookup == null) // DN
                return new Dictionary<string, object>();
            if ((new[] { ReportSourceTable, TableVar }).Contains(lookup.LinkTable))
                lookup.RenderViewFunc = "RenderLookup"; // Set up view renderer
            lookup.RenderEditFunc = ""; // Set up edit renderer
            string lookupType = IsDictionary(dict) && dict.TryGetValue("ajax", out v) && v != null ? v : (Post("ajax") ?? "unknown");
            int pageSize = -1;
            int offset = -1;
            string searchValue = "";
            if (SameText(lookupType, "modal") || SameText(lookupType, "filter")) {
                searchValue = IsDictionary(dict) && (dict.TryGetValue("q", out v) && v != null || dict.TryGetValue("sv", out v) && v != null)
                    ? v
                    : (Param("q") ?? Post("sv"));
                pageSize = IsDictionary(dict) && (dict.TryGetValue("n", out v) || dict.TryGetValue("recperpage", out v))
                    ? ConvertToInt(v)
                    : (IsNumeric(Param("n")) ? Param<int>("n") : (Post("recperpage", out StringValues rpp) ? ConvertToInt(rpp.ToString()) : 10));
            } else if (SameText(lookupType, "autosuggest")) {
                searchValue = IsDictionary(dict) && dict.TryGetValue("q", out v) && v != null ? v : Param("q");
                pageSize = IsDictionary(dict) && dict.TryGetValue("n", out v) ? ConvertToInt(v) : (IsNumeric(Param("n")) ? Param<int>("n") : -1);
                if (pageSize <= 0)
                    pageSize = Config.AutoSuggestMaxEntries;
            }
            int start = IsDictionary(dict) && dict.TryGetValue("start", out v) ? ConvertToInt(v) : (IsNumeric(Param("start")) ? Param<int>("start") : -1);
            int page = IsDictionary(dict) && dict.TryGetValue("page", out v) ? ConvertToInt(v) : (IsNumeric(Param("page")) ? Param<int>("page") : -1);
            offset = start >= 0 ? start : (page > 0 && pageSize > 0 ? (page - 1) * pageSize : 0);
            string userSelect = Decrypt(IsDictionary(dict) && dict.TryGetValue("s", out v) && v != null ? v : Post("s"));
            string userFilter = Decrypt(IsDictionary(dict) && dict.TryGetValue("f", out v) && v != null ? v : Post("f"));
            string userOrderBy = Decrypt(IsDictionary(dict) && dict.TryGetValue("o", out v) && v != null ? v : Post("o"));

            // Selected records from modal, skip parent/filter fields and show all records
            lookup.LookupType = lookupType; // Lookup type
            lookup.FilterValues.Clear(); // Clear filter values first
            StringValues keys = IsDictionary(dict) && dict.TryGetValue("keys", out v) && !Empty(v)
                ? (StringValues)v
                : (Post("keys[]", out StringValues k) ? (StringValues)k : StringValues.Empty);
            if (!Empty(keys)) { // Selected records from modal
                lookup.FilterFields = new (); // Skip parent fields if any
                pageSize = -1; // Show all records
                lookup.FilterValues.Add(String.Join(",", keys.ToArray()));
            } else { // Lookup values
                string lookupValue = IsDictionary(dict) && (dict.TryGetValue("v0", out v) && v != null || dict.TryGetValue("lookupValue", out v) && v != null)
                    ? v
                    : (Post<string>("v0") ?? Post("lookupValue"));
                lookup.FilterValues.Add(lookupValue);
            }
            int cnt = IsDictionary(lookup.FilterFields) ? lookup.FilterFields.Count : 0;
            for (int i = 1; i <= cnt; i++) {
                var val = UrlDecode(IsDictionary(dict) && dict.TryGetValue("v" + i, out v) ? v : Post("v" + i));
                if (val != null) // DN
                    lookup.FilterValues.Add(val);
            }
            lookup.SearchValue = searchValue;
            lookup.PageSize = pageSize;
            lookup.Offset = offset;
            if (userSelect != "")
                lookup.UserSelect = userSelect;
            if (userFilter != "")
                lookup.UserFilter = userFilter;
            if (userOrderBy != "")
                lookup.UserOrderBy = userOrderBy;
            return await lookup.ToJson(this);
        }
        #pragma warning restore 219

        // Properties
        private Pager? _pager; // DN

        public int GroupIndex = 0;

        public int RowIndex = 0;

        public bool HideOptions = false;

        // Records
        public int DetailRecordCount = 0;

        public List<Dictionary<string, object>> DetailRecords = new (); // DN

        public List<Dictionary<string, object>> GroupRecords = new (); // DN

        // Paging variables
        public int RecordIndex = 0; // Record index

        public int RecordCount = 0; // Record count

        public int StartGroup = 0; // Start group

        public int StopGroup = 0; // Stop group

        public int TotalGroups = 0; // Total groups

        public int GroupCount = 0; // Group count

        public Dictionary<int, int> GroupCounter = new (); // Group counter

        public int DisplayGroups = 3; // Groups per page

        public int GroupRange = 10;

        public string PageSizes = "1,2,3,5,-1"; // Group sizes (comma separated)

        public string PageFirstGroupFilter = "";

        public string UserIDFilter = "";

        public string DefaultSearchWhere = ""; // Default search WHERE clause

        public string SearchWhere = "";

        public string SearchPanelClass = "ew-search-panel collapse show"; // Search Panel class

        public int SearchColumnCount = 0; // For extended search

        public int SearchFieldsPerRow = 1; // For extended search

        public string DrillDownList = "";

        public string DbMasterFilter = ""; // Master filter

        public string DbDetailFilter = ""; // Detail filter

        public bool SearchCommand = false;

        public bool ShowHeader = true;

        public int GroupColumnCount = 0;

        public int SubGroupColumnCount = 0;

        public int DetailColumnCount = 0;

        public int TotalCount;

        public int PageTotalCount;

        public string TopContentClass = "ew-top";

        public string MiddleContentClass = "ew-middle";

        public string BottomContentClass = "ew-bottom";

        // Pager
        public Pager Pager
        {
            get {
                _pager ??= new PrevNextPager(this, StartGroup, GroupPerPage == -1 ? -1 : DisplayGroups, TotalGroups, PageSizes, GroupRange, AutoHidePager, AutoHidePageSizeSelector, !DashboardReport);
                return _pager;
            }
        }

        #pragma warning disable 168, 219
        /// <summary>
        /// Page run
        /// </summary>
        /// <returns>Page result</returns>
        public override async Task<IActionResult> Run() {
            // Set up dashboard report
            DashboardReport = DashboardReport || Param<bool>(Config.PageDashboard);
            if (DashboardReport)
                UseAjaxActions = true;

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
            CurrentAction = Param("action"); // Set up current action

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

            // Setup other options
            SetupOtherOptions();

            // Set up table class
            if (IsExport("word") || IsExport("excel") || IsExport("pdf"))
                TableClass = "ew-table table-bordered";
            else
                TableClass = PrependClass(TableClass, "table ew-table table-bordered");

            // Set up report container class
            if (!IsExport("word") && !IsExport("excel"))
                ReportContainerClass += " card ew-card";

            // Set field visibility for detail fields
            Numberofopenclasses.SetVisibility();

            // Set up groups per page dynamically
            SetupDisplayGroups();

            // Set up Breadcrumb
            if (!IsExport() && !DashboardReport)
                SetupBreadcrumb();

            // Load custom filters
            PageFilterLoad();

            // No filter
            FilterOptions["savecurrentfilter"]?.SetVisible(false);
            FilterOptions["deletefilter"]?.SetVisible(false);

            // Call Page Selecting event
            PageSelecting(ref SearchWhere);

            // Search options
            SetupSearchOptions();

            // Set up search panel class
            if (!Empty(SearchWhere))
                SearchPanelClass = AppendClass(SearchPanelClass, "show");

            // Get sort
            Sort = GetSort();

            // Update filter
            AddFilter(ref Filter, SearchWhere);

            // Get total count
            string sql = BuildReportSql(SqlSelect, SqlWhere, SqlGroupBy, SqlHaving, "", Filter, "");
            TotalGroups = await TryGetRecordCountAsync(sql); // DN
            if (DisplayGroups <= 0 || DrillDown) // Display all groups
                DisplayGroups = TotalGroups;
            StartGroup = 1;

            // Set up start position if not export all
            if (ExportAll && IsExport())
                DisplayGroups = TotalGroups;
            else
                SetupStartGroup();

            // Set no record found message
            if (TotalGroups == 0) {
                ShowHeader = false;
                if (Security.CanList) {
                    if (SearchWhere == "0=101") {
                        WarningMessage = Language.Phrase("EnterSearchCriteria");
                    } else {
                        WarningMessage = Language.Phrase("NoRecord");
                    }
                } else {
                    WarningMessage = DeniedMessage();
                }
            }

            // Hide all options if export/dashboard//hide options
            if (IsExport() || DashboardReport || HideOptions)
                ExportOptions.HideAllOptions();

            // Hide search/filter options if export/drilldown/dashboard/hide options
            if (IsExport() || DrillDown || DashboardReport || HideOptions) {
                SearchOptions.HideAllOptions();
                FilterOptions.HideAllOptions();
            }

            // Get current page records
            if (TotalGroups > 0) {
                sql = BuildReportSql(SqlSelect, SqlWhere, SqlGroupBy, SqlHaving, "", Filter, Sort);
                DetailRecords = await GetRecords(sql, StartGroup, DisplayGroups); // DN
                GroupCount = 1;
            }

            // Setup field count
            SetupFieldCount();

            // Set the last group to display if not export all
            if (ExportAll && IsExport()) {
                StopGroup = TotalGroups;
            } else {
                StopGroup = StartGroup + DisplayGroups - 1;
            }

            // Stop group <= total number of groups
            if (StopGroup > TotalGroups)
                StopGroup = TotalGroups;
            RecordCount = 0;
            RecordIndex = 0;
            SetGroupCount(StopGroup - StartGroup + 1, 1);

            // Check if no records
            if (TotalGroups == 0)
                ReportContainerClass += " ew-no-record";

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                classStatusSummary?.PageRender();
            }

            // Result
            return PageResult();
        }
        #pragma warning restore 168, 219

        // Get records // DN
        public async Task<List<Dictionary<string, object>>> GetRecords(string sql, int start = 1, int grps = int.MaxValue)
        {
            var records = await Connection.GetRowsAsync(sql);
            int idx = start - 1;
            return records.GetRange(idx, Math.Min(grps, records.Count - idx));
        }

        // Load row values
        public void LoadRowValues(Dictionary<string, object> record)
        {
            Dictionary<string, object?> data = new ();
            data["ClassStatus2"] = record["Class Status"];
            data["str_Package_Name"] = record["str_Package_Name"];
            data["Numberofopenclasses"] = record["Number of open classes"];
            Rows.Add(data);
            ClassStatus2.SetDbValue(record["Class Status"]);
            str_Package_Name.SetDbValue(record["str_Package_Name"]);
            Numberofopenclasses.SetDbValue(record["Number of open classes"]);
        }

        #pragma warning disable 168
        // Render row
        public async Task RenderRow()
        {
            if (RowType == RowType.Total && RowTotalSubType == RowTotal.Footer && RowTotalType == RowSummary.Page) { // Get Page total
                List<Dictionary<string, object>>? records = null;
                records = DetailRecords;
                Numberofopenclasses.GetCnt(records);
                PageTotalCount = records?.Count ?? 0;
            } else if (RowType == RowType.Total && RowTotalSubType == RowTotal.Footer && RowTotalType == RowSummary.Grand) { // Get Grand total
                bool hasCount = false;
                bool hasSummary = false;

                // Get total count from SQL directly
                string sql = BuildReportSql(SqlSelectCount, SqlWhere, SqlGroupBy, SqlHaving, "", Filter, "");
                var total = await Connection.ExecuteScalarAsync(sql); // DN
                if (total != null) { // DN
                    TotalCount = ConvertToInt(total);
                    hasCount = true;
                } else {
                    TotalCount = 0;
                }

                // Get total from SQL directly
                sql = BuildReportSql(SqlSelectAggregate, SqlWhere, SqlGroupBy, SqlHaving, "", Filter, "");
                sql = SqlAggregatePrefix + sql + SqlAggregateSuffix;
                var rsagg = await Connection.GetRowAsync(sql);
                if (rsagg != null) {
                    Numberofopenclasses.Count = TotalCount;
                    Numberofopenclasses.CntValue = rsagg["cnt_numberofopenclasses"];
                    hasSummary = true;
                }

                // Accumulate grand summary from detail records
                if (!hasCount || !hasSummary) {
                    sql = BuildReportSql(SqlSelect, SqlWhere, SqlGroupBy, SqlHaving, "", Filter, "");
                    DetailRecords = await GetRecords(sql);
                    Numberofopenclasses.GetCnt(DetailRecords);
                }
            }

            // Call Row Rendering event
            RowRendering();

            // Number of open classes
            if (RowType == RowType.Search) { // Search row
            } else if (RowType == RowType.Total && !(RowTotalType == RowSummary.Group && RowTotalSubType == RowTotal.Header)) { // Summary row
                RowAttrs["class"] = PrependClass(ConvertToString(RowAttrs["class"]), (RowTotalType == RowSummary.Page || RowTotalType == RowSummary.Grand) ? "ew-rpt-grp-aggregate" : ""); // Set up row class

                // Number of open classes
                Numberofopenclasses.CntViewValue = Numberofopenclasses.CntValue;
                Numberofopenclasses.CntViewValue = FormatNumber(Numberofopenclasses.CntViewValue, Numberofopenclasses.FormatPattern);
                Numberofopenclasses.CellCssStyle += "text-align: center;";
                Numberofopenclasses.ViewCustomAttributes = "";
                Numberofopenclasses.CellAttrs["class"] = (RowTotalType == RowSummary.Page || RowTotalType == RowSummary.Grand) ? "ew-rpt-grp-aggregate" : "ew-rpt-grp-summary-" + RowGroupLevel;

                // Number of open classes
                Numberofopenclasses.HrefValue = "";
            } else {
                if (RowTotalType == RowSummary.Group && RowTotalSubType == RowTotal.Header) {
                } else {
                }

                // Number of open classes
                Numberofopenclasses.ViewValue = Numberofopenclasses.CurrentValue;
                Numberofopenclasses.ViewValue = FormatNumber(Numberofopenclasses.ViewValue, Numberofopenclasses.FormatPattern);
                Numberofopenclasses.CellCssClass = (RecordCount % 2 != 1 ? "ew-table-alt-row" : "");
                Numberofopenclasses.CellCssStyle += "text-align: center;";
                Numberofopenclasses.ViewCustomAttributes = "";

                // Number of open classes
                Numberofopenclasses.HrefValue = "";
                Numberofopenclasses.TooltipValue = "";
            }

            // Call Cell Rendered event
            object? viewValue; // DN
            if (RowType == RowType.Total) {
                // Number of open classes
                viewValue = Numberofopenclasses.CntViewValue;
                CellRendered(Numberofopenclasses, viewValue, ref viewValue, Numberofopenclasses.ViewAttrs, Numberofopenclasses.CellAttrs, ref Numberofopenclasses.HrefValue, Numberofopenclasses.LinkAttrs);
                Numberofopenclasses.CntViewValue = ConvertToString(viewValue);
            } else {
                // Number of open classes
                CellRendered(Numberofopenclasses, Numberofopenclasses.CurrentValue, ref Numberofopenclasses.ViewValue, Numberofopenclasses.ViewAttrs, Numberofopenclasses.CellAttrs, ref Numberofopenclasses.HrefValue, Numberofopenclasses.LinkAttrs);
            }

            // Call Row Rendered event
            RowRendered();

            // Setup field count
            SetupFieldCount();
        }
        #pragma warning restore 168

        // Group count
        private Dictionary<string, int> _groupCounts = new ();

        // Get group count
        public int GetGroupCount(params int[] args)
        {
            string key = String.Join("_", args.Select(arg => arg.ToString()));
            if (Empty(key)) {
                return -1;
            } else if (key == "0") { // Number of first level groups
                int i = 1;
                while (_groupCounts.ContainsKey(i.ToString()))
                    i++;
                return i - 1;
            }
            return _groupCounts.TryGetValue(key, out int cnt) ? cnt : -1;
        }

        // Set group count
        public void SetGroupCount(int value, params int[] args)
        {
            string key = String.Join("_", args.Select(arg => arg.ToString()));
            if (Empty(key))
                return;
            _groupCounts[key] = value;
        }

        // Setup field count
        public void SetupFieldCount()
        {
            GroupColumnCount = 0;
            SubGroupColumnCount = 0;
            DetailColumnCount = 0;
            if (Numberofopenclasses.Visible)
                DetailColumnCount++;
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
                    "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"false\" data-export-selected=\"false\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToExcel") + "</button>",
                "word" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) +
                    "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"false\" data-export-selected=\"false\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToWord") + "</button>",
                "pdf" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPDF", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPDF", true)) +
                    "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"false\" data-export-selected=\"false\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToPDF") + "</button>",
                "html" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-html\" title=\"" + HtmlEncode(Language.Phrase("ExportToHtml", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToHtml", true)) +
                    "\" data-ew-action=\"export\" data-export=\"html\" data-custom=\"false\" data-export-selected=\"false\" data-url=\"" + exportUrl + "\">" +
                    Language.Phrase("ExportToHtml") + "</button>",
                "email" => "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + HtmlEncode(Language.Phrase("ExportToEmail", true)) +
                    "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToEmail", true)) +
                    "\" data-ew-action=\"email\" data-custom=\"false\" data-export-selected=\"false\" data-hdr=\"" + HtmlEncode(Language.Phrase("ExportToEmail", true)) + "\" data-url=\"" + exportUrl + "\">" +
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
            item.Body = GetExportTag("excel");
            item.Visible = true;

            // Export to Word
            item = ExportOptions.Add("word");
            item.Body = GetExportTag("word");
            item.Visible = false;

            // Export to HTML
            item = ExportOptions.Add("html");
            item.Body = GetExportTag("html");
            item.Visible = false;

            // Export to PDF
            item = ExportOptions.Add("pdf");
            item.Body = GetExportTag("pdf");
            item.Visible = true;

            // Export to Email
            item = ExportOptions.Add("email");
            item.Body = GetExportTag("email");
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

            // Hide options for export
            if (IsExport())
                ExportOptions.HideAllOptions();
            if (!Security.CanExport) // Export not allowed
                ExportOptions.HideAllOptions();
        }

        // Set up search options
        protected void SetupSearchOptions() {
            ListOption item;

            // Button group for search
            SearchOptions.UseDropDownButton = false;
            SearchOptions.UseButtonGroup = true;
            SearchOptions.DropDownButtonPhrase = "ButtonSearch";

            // Add group option item
            item = SearchOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;

            // Hide search options
            if (IsExport() || !Empty(CurrentAction) && CurrentAction != "search")
                SearchOptions.HideAllOptions();
            if (!Security.CanSearch) {
                SearchOptions.HideAllOptions();
                FilterOptions.HideAllOptions();
            }
        }

        // Check if any search fields
        public bool HasSearchFields()
        {
            return false;
        }

        // Render search options
        protected void RenderSearchOptions()
        {
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            url = Regex.Replace(url, @"\?cmd=reset(all)?$", ""); // Remove cmd=reset / cmd=resetall
            breadcrumb.Add("summary", TableVar, url, "", TableVar, true);
            CurrentBreadcrumb = breadcrumb;
        }

        // Setup lookup options
        public async Task SetupLookupOptions(DbField fld)
        {
            if (fld.Lookup == null)
                return;
            Func<string>? lookupFilter = null;
            dynamic conn = Connection;
            if (fld.Lookup.Options.Count is int c && c == 0) {
                // Always call to Lookup.GetSql so that user can setup Lookup.Options in Lookup Selecting server event
                var sql = fld.Lookup.GetSql(false, "", lookupFilter, this);

                // Set up lookup cache
                if (!fld.HasLookupOptions && fld.UseLookupCache && !Empty(sql) && fld.Lookup.ParentFields.Count == 0 && fld.Lookup.Options.Count == 0) {
                    int totalCnt = await TryGetRecordCountAsync(sql, conn);
                    if (totalCnt > fld.LookupCacheCount) // Total count > cache count, do not cache
                        return;
                    var dict = new Dictionary<string, Dictionary<string, object>>();
                    var values = new List<object>();
                    List<Dictionary<string, object>> rs = await conn.GetRowsAsync(sql);
                    if (rs != null) {
                        for (int i = 0; i < rs.Count; i++) {
                            var row = rs[i];
                            row = fld.Lookup?.RenderViewRow(row, Resolve(fld.Lookup.LinkTable));
                            string key = row?.Values.First()?.ToString() ?? String.Empty;
                            if (!dict.ContainsKey(key) && row != null)
                                dict.Add(key, row);
                        }
                    }
                    fld.Lookup?.SetOptions(dict);
                }
            }
        }

        // Set up other options
        public void SetupOtherOptions()
        {
            // Filter button
            var item = FilterOptions.Add("savecurrentfilter");
            item.Body = "<a class=\"ew-save-filter\" data-form=\"fClass_Statussrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"fClass_Statussrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
            item.Visible = false;
            FilterOptions.UseDropDownButton = true;
            FilterOptions.UseButtonGroup = !FilterOptions.UseDropDownButton;
            FilterOptions.DropDownButtonPhrase = "Filters";

            // Add group option item
            item = FilterOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;
        }

        // Set up starting group
        public void SetupStartGroup()
        {
            // Exit if no groups
            if (DisplayGroups == 0)
                return;
            string startGrp = Param(Config.TableStartRec);
            string pageNo = Param(Config.TablePageNumber);

            // Check for a 'start' parameter
            if (!Empty(startGrp) &&
                IsNumeric(startGrp)) {
                StartGroup = ConvertToInt(startGrp);
                SessionStartGroup = StartGroup;
            } else if (!Empty(pageNo)) {
                if (IsNumeric(pageNo)) {
                    long? p = ParseInteger(pageNo);
                    if (p != null)
                        StartGroup = ((int)p - 1) * DisplayGroups + 1;
                    if (StartGroup <= 0) {
                        StartGroup = 1;
                    } else if (StartGroup >= (TotalGroups - 1) / DisplayGroups * DisplayGroups + 1) {
                        StartGroup = (TotalGroups - 1) / DisplayGroups * DisplayGroups + 1;
                    }
                    SessionStartGroup = StartGroup;
                } else {
                    StartGroup = SessionStartGroup;
                }
            } else {
                StartGroup = SessionStartGroup;
            }

            // Check if correct start group counter
            if (StartGroup <= 0) {
                StartGroup = 1; // Reset start group counter
                SessionStartGroup = StartGroup;
            } else if (StartGroup > TotalGroups) { // Avoid starting group > total groups
                StartGroup = (TotalGroups - 1) / DisplayGroups * DisplayGroups + 1; // Point to last page first group
                SessionStartGroup = StartGroup;
            } else if ((StartGroup - 1) % DisplayGroups != 0) {
                StartGroup = (StartGroup - 1) / DisplayGroups * DisplayGroups + 1; // Point to page boundary
                SessionStartGroup = StartGroup;
            }
        }

        // Reset pager
        public void ResetPager()
        {
            StartGroup = 1;
            SessionStartGroup = StartGroup;
        }

        // Set up number of groups displayed per page
        public void SetupDisplayGroups()
        {
            DisplayGroups = 3; // Non-numeric, load default
            string wrk = Param(Config.TableRecordsPerPage);
            if (!Empty(wrk)) {
                if (IsNumeric(wrk)) {
                    DisplayGroups = ConvertToInt(wrk);
                } else if (SameText(wrk, "all")) { // Display all records
                    DisplayGroups = -1; // All records
                }
                // Reset start position (reset command)
                StartGroup = 1;
                SessionStartGroup = StartGroup;
            } else if (GroupPerPage == -1 || GroupPerPage > 0) { // DN
                DisplayGroups = GroupPerPage; // Restore from session
            }
            GroupPerPage = DisplayGroups; // Save to session
        }

        // Get sort parameters based on sort links clicked
        public string GetSort()
        {
            if (DrillDown)
                return "";
            bool resetSort = Param("cmd") == "resetsort";
            string orderBy = Param("order"), orderType = Param("ordertype");

            // Check for Ctrl pressed
            bool ctrl = !Empty(Param("ctrl"));

            // Check for a resetsort command
            if (resetSort) {
                OrderBy = "";
                SessionStartGroup = 1;
                ClassStatus2.Sort = "";
                str_Package_Name.Sort = "";
                Numberofopenclasses.Sort = "";

            // Check for an Order parameter
            } else if (!Empty(orderBy)) {
                CurrentOrder = orderBy;
                CurrentOrderType = orderType;
                UpdateSort(ClassStatus2, ctrl); // Class Status
                UpdateSort(str_Package_Name, ctrl); // str_Package_Name
                UpdateSort(Numberofopenclasses, ctrl); // Number of open classes
                OrderBy = SortSql;
                SessionStartGroup = 1;
            }
            return OrderBy;
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

        // Page Selecting event
        public void PageSelecting(ref string filter) {
            // Enter your code here
        }

        // Load Filters event
        public void PageFilterLoad() {
            // Enter your code here
            // Example: Register/Unregister Custom Extended Filter
            //	RegisterFilter(<Field>, "StartsWithA", "Starts With A", "GetStartsWithAFilter"); // With function, or
            //	RegisterFilter(<Field>, "StartsWithA", "Starts With A"); // No function, use Page_Filtering event
            //	UnregisterFilter(<Field>, "StartsWithA");
        }

        // Page Filter Validated event
        public void PageFilterValidated() {
            // Example:
            //MyField1.AdvancedSearch.SearchValue = "your search criteria"; // Search value
        }

        // Page Filtering event
        public void PageFiltering(ReportField fld, ref string filter, string typ, string opr, string val, string cond, string opr2, string val2) {
            // Note: ALWAYS CHECK THE FILTER TYPE (typ)! Example:
            //	if (typ == "dropdown" && fld.Name == "MyField") // Dropdown filter
            //		filter = "..."; // Modify the filter
            //	if (typ == "extended" && fld.Name == "MyField") // Extended filter
            //		filter = "..."; // Modify the filter
            //	if (typ == "popup" && fld.Name == "MyField") // Popup filter
            //		filter = "..."; // Modify the filter
            //	if (typ == "custom" && opr == "..." && fld.Name == "MyField") // Custom filter, opr is the custom filter ID
            //		filter = "..."; // Modify the filter
        }

        // Cell Rendered event
        public void CellRendered(ReportField field, object? currentValue, ref object? viewValue, Attributes viewAttrs, Attributes CellAttrs, ref object? hrefValue, Attributes linkAttrs) {
            //ViewValue = "xxx";
            //ViewAttrs["style"] = "xxx";
        }

        // Form Custom Validate event
        public virtual bool FormCustomValidate(ref string customError) {
            //Return error message in customError
            return true;
        }
    } // End page class
} // End Partial class
