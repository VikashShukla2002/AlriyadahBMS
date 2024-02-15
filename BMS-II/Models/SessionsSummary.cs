namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// sessionsSummary
    /// </summary>
    public static SessionsSummary sessionsSummary
    {
        get => HttpData.Get<SessionsSummary>("sessionsSummary")!;
        set => HttpData["sessionsSummary"] = value;
    }

    /// <summary>
    /// Page class for Sessions
    /// </summary>
    public class SessionsSummary : SessionsSummaryBase
    {
        // Constructor
        public SessionsSummary(Controller controller) : base(controller)
        {
        }

        // Constructor
        public SessionsSummary() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class SessionsSummaryBase : Sessions
    {
        // Page ID
        public string PageID = "summary";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Sessions";

        // Page object name
        public string PageObjName = "sessionsSummary";

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
        public SessionsSummaryBase()
        {
            // CSS class name as context
            TableVar = "Sessions";
            ContextClass = CheckClassName(TableVar);
            ReportContainerClass = AppendClass(ReportContainerClass, ContextClass);

            // Initialize
            TableVar = "Sessions"; // DN
            if (!DashboardReport)
                CurrentPage = this;

            // CSS class name as context
            ContextClass = CheckClassName(TableVar);
            ReportContainerClass = AppendClass(ReportContainerClass, ContextClass);

            // Language object
            Language = ResolveLanguage();

            // Table object (sessions)
            if (sessions == null || sessions is Sessions)
                sessions = this;

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
        public string PageName => "Sessions";

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
        public SessionsSummaryBase(Controller? controller = null): this() { // DN
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
            FirstGroupField = str_CR_Number; // DN

            // Set field visibility for detail fields
            int_CRSession_ID.SetVisibility();
            int_Status.SetVisibility();
            str_Day_Name.SetVisibility();
            str_Time_Start.SetVisibility();
            str_Time_End.SetVisibility();

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

            // Set up master/detail parameters
            SetupMasterParms();

            // Reset master/detail keys
            if (SameText(Get("cmd"), "resetall")) {
                CurrentMasterTable = ""; // Clear master table
                DbMasterFilter = "";
                DbDetailFilter = "";
                str_CR_Number.SessionValue = "";
            }

            // Add detail filter
            AddFilter(ref Filter, DbDetailFilter);

            // Get total group count
            string sql = BuildReportSql(SqlSelectGroup, SqlWhere, SqlGroupBy, SqlHaving, "", Filter, "");
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

            // Get group records
            if (TotalGroups > 0) {
                string groupSort = UpdateSortFields(SqlOrderByGroup, Sort, 2); // Get grouping field only // DN
                sql = BuildReportSql(SqlSelectGroup, SqlWhere, SqlGroupBy, SqlHaving, SqlOrderByGroup, Filter, groupSort);
                GroupRecords = await GetRecords(sql, StartGroup, DisplayGroups); // DN
                LoadGroupRowValues();
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
                sessionsSummary?.PageRender();
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

        // Load group row values
        public void LoadGroupRowValues()
        {
            int cnt = GroupRecords.Count;
            if (FirstGroupField != null)
                FirstGroupField.GroupValue = GroupCount < cnt ? GroupRecords[GroupCount].FirstOrDefault().Value : "";
        }

        // Load row values
        public void LoadRowValues(Dictionary<string, object> record)
        {
            Dictionary<string, object?> data = new ();
            data["int_CRSession_ID"] = record["int_CRSession_ID"];
            data["str_CR_Number"] = record["str_CR_Number"];
            data["int_Status"] = record["int_Status"];
            data["int_Staff_Id"] = record["int_Staff_Id"];
            data["Instructor"] = record["Instructor"];
            data["int_Location_Id"] = record["int_Location_Id"];
            data["Location"] = record["Location"];
            data["int_Session_ID"] = record["int_Session_ID"];
            data["str_Session_Date"] = record["str_Session_Date"];
            data["int_Day_ID"] = record["int_Day_ID"];
            data["str_Day_Name"] = record["str_Day_Name"];
            data["str_Time_Start"] = record["str_Time_Start"];
            data["str_Time_End"] = record["str_Time_End"];
            data["date_Created"] = record["date_Created"];
            data["int_CR_Id"] = record["int_CR_Id"];
            data["str_Notes"] = record["str_Notes"];
            data["int_Created_By"] = record["int_Created_By"];
            data["int_Modified_By"] = record["int_Modified_By"];
            data["date_Modified"] = record["date_Modified"];
            data["bit_IsDeleted"] = record["bit_IsDeleted"];
            data["str_Session_Notes"] = record["str_Session_Notes"];
            data["is_Rescheduled"] = record["is_Rescheduled"];
            data["IsZoomMeet"] = record["IsZoomMeet"];
            data["str_ZoomHostUrl"] = record["str_ZoomHostUrl"];
            data["str_ZoomUserUrl"] = record["str_ZoomUserUrl"];
            data["CR_Row_Index"] = record["CR_Row_Index"];
            data["CRSS_ID"] = record["CRSS_ID"];
            data["int_Student_Id"] = record["int_Student_Id"];
            data["str_Username"] = record["str_Username"];
            data["str_Status"] = record["str_Status"];
            Rows.Add(data);
            int_CRSession_ID.SetDbValue(record["int_CRSession_ID"]);
            str_CR_Number.SetDbValue(GroupValue(str_CR_Number, record["str_CR_Number"]));
            int_Status.SetDbValue(record["int_Status"]);
            int_Staff_Id.SetDbValue(record["int_Staff_Id"]);
            Instructor.SetDbValue(record["Instructor"]);
            int_Location_Id.SetDbValue(record["int_Location_Id"]);
            Location.SetDbValue(record["Location"]);
            int_Session_ID.SetDbValue(record["int_Session_ID"]);
            str_Session_Date.SetDbValue(record["str_Session_Date"]);
            int_Day_ID.SetDbValue(record["int_Day_ID"]);
            str_Day_Name.SetDbValue(record["str_Day_Name"]);
            str_Time_Start.SetDbValue(record["str_Time_Start"]);
            str_Time_End.SetDbValue(record["str_Time_End"]);
            date_Created.SetDbValue(record["date_Created"]);
            int_CR_Id.SetDbValue(record["int_CR_Id"]);
            str_Notes.SetDbValue(record["str_Notes"]);
            int_Created_By.SetDbValue(record["int_Created_By"]);
            int_Modified_By.SetDbValue(record["int_Modified_By"]);
            date_Modified.SetDbValue(record["date_Modified"]);
            bit_IsDeleted.SetDbValue(record["bit_IsDeleted"]);
            str_Session_Notes.SetDbValue(record["str_Session_Notes"]);
            is_Rescheduled.SetDbValue(record["is_Rescheduled"]);
            instructorSignature.Upload.DbValue = record["instructorSignature"];
            instructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])instructorSignature.Upload.DbValue));
            IsZoomMeet.SetDbValue(record["IsZoomMeet"]);
            str_ZoomHostUrl.SetDbValue(record["str_ZoomHostUrl"]);
            str_ZoomUserUrl.SetDbValue(record["str_ZoomUserUrl"]);
            CR_Row_Index.SetDbValue(record["CR_Row_Index"]);
            CRSS_ID.SetDbValue(record["CRSS_ID"]);
            int_Student_Id.SetDbValue(record["int_Student_Id"]);
            str_Username.SetDbValue(record["str_Username"]);
            str_Status.SetDbValue(record["str_Status"]);
        }

        #pragma warning disable 168
        // Render row
        public async Task RenderRow()
        {
            if (RowType == RowType.Total && RowTotalSubType == RowTotal.Footer && RowTotalType == RowSummary.Page) { // Get Page total
                List<Dictionary<string, object>>? records = null;

                // Build detail SQL
                FirstGroupField?.GetDistinctValues(GroupRecords);
                string where = DetailFilterSql(FirstGroupField, SqlFirstGroupField, FirstGroupField?.DistinctValues, DbId);
                if (!Empty(Filter))
                    AddFilter(ref where, Filter);
                string sql = BuildReportSql(SqlSelect, SqlWhere, SqlGroupBy, SqlHaving, SqlOrderBy, where, Sort);
                records = await GetRecords(sql);
                int_CRSession_ID.GetCnt(records);
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
                    int_CRSession_ID.Count = TotalCount;
                    int_CRSession_ID.CntValue = rsagg["cnt_int_crsession_id"];
                    int_Status.Count = TotalCount;
                    str_Day_Name.Count = TotalCount;
                    str_Time_Start.Count = TotalCount;
                    str_Time_End.Count = TotalCount;
                    hasSummary = true;
                }

                // Accumulate grand summary from detail records
                if (!hasCount || !hasSummary) {
                    sql = BuildReportSql(SqlSelect, SqlWhere, SqlGroupBy, SqlHaving, "", Filter, "");
                    DetailRecords = await GetRecords(sql);
                    int_CRSession_ID.GetCnt(DetailRecords);
                }
            }

            // Call Row Rendering event
            RowRendering();

            // str_CR_Number

            // str_Session_Date

            // int_CRSession_ID

            // int_Status

            // str_Day_Name

            // str_Time_Start

            // str_Time_End
            if (RowType == RowType.Search) { // Search row
            } else if (RowType == RowType.Total && !(RowTotalType == RowSummary.Group && RowTotalSubType == RowTotal.Header)) { // Summary row
                RowAttrs["class"] = PrependClass(ConvertToString(RowAttrs["class"]), (RowTotalType == RowSummary.Page || RowTotalType == RowSummary.Grand) ? "ew-rpt-grp-aggregate" : ""); // Set up row class
                if (RowTotalType == RowSummary.Group)
                    RowAttrs["data-group"] = ConvertToString(str_CR_Number.GroupValue); // Set up group attribute
                if (RowTotalType == RowSummary.Group && RowGroupLevel >= 2)
                    RowAttrs["data-group-2"] = ConvertToString(str_Session_Date.GroupValue); // Set up group attribute 2

                // str_CR_Number
                str_CR_Number.GroupViewValue = ConvertToString(str_CR_Number.GroupValue); // DN
                str_CR_Number.CellCssClass = (RowGroupLevel == 1 ? "ew-rpt-grp-summary-1" : "ew-rpt-grp-field-1");
                str_CR_Number.ViewCustomAttributes = "";
                str_CR_Number.GroupViewValue = DisplayGroupValue(str_CR_Number, str_CR_Number.GroupViewValue);

                // str_Session_Date
                str_Session_Date.GroupViewValue = ConvertToString(str_Session_Date.GroupValue); // DN
                str_Session_Date.CellCssClass = (RowGroupLevel == 2 ? "ew-rpt-grp-summary-2" : "ew-rpt-grp-field-2");
                str_Session_Date.ViewCustomAttributes = "";
                str_Session_Date.GroupViewValue = DisplayGroupValue(str_Session_Date, str_Session_Date.GroupViewValue);

                // int_CRSession_ID
                int_CRSession_ID.CntViewValue = int_CRSession_ID.CntValue;
                int_CRSession_ID.CntViewValue = FormatNumber(int_CRSession_ID.CntViewValue, int_CRSession_ID.FormatPattern);
                int_CRSession_ID.ViewCustomAttributes = "";
                int_CRSession_ID.CellAttrs["class"] = (RowTotalType == RowSummary.Page || RowTotalType == RowSummary.Grand) ? "ew-rpt-grp-aggregate" : "ew-rpt-grp-summary-" + RowGroupLevel;

                // str_CR_Number
                str_CR_Number.HrefValue = "";

                // str_Session_Date
                str_Session_Date.HrefValue = "";

                // int_CRSession_ID
                int_CRSession_ID.HrefValue = "";

                // int_Status
                int_Status.HrefValue = "";

                // str_Day_Name
                str_Day_Name.HrefValue = "";

                // str_Time_Start
                str_Time_Start.HrefValue = "";

                // str_Time_End
                str_Time_End.HrefValue = "";
            } else {
                if (RowTotalType == RowSummary.Group && RowTotalSubType == RowTotal.Header) {
                    RowAttrs["data-group"] = ConvertToString(str_CR_Number.GroupValue); // Set up group attribute
                    if (RowGroupLevel >= 2)
                        RowAttrs["data-group-2"] = ConvertToString(str_Session_Date.GroupValue); // Set up group attribute 2
                } else {
                    RowAttrs["data-group"] = ConvertToString(str_CR_Number.GroupValue); // Set up group attribute
                    RowAttrs["data-group-2"] = ConvertToString(str_Session_Date.GroupValue); // Set up group attribute 2
                }

                // str_CR_Number
                str_CR_Number.GroupViewValue = ConvertToString(str_CR_Number.GroupValue); // DN
                str_CR_Number.CellCssClass = "ew-rpt-grp-field-1";
                str_CR_Number.ViewCustomAttributes = "";
                str_CR_Number.GroupViewValue = DisplayGroupValue(str_CR_Number, str_CR_Number.GroupViewValue);
                if (!str_CR_Number.LevelBreak)
                    str_CR_Number.GroupViewValue = "&nbsp;";
                else
                    str_CR_Number.LevelBreak = false;

                // str_Session_Date
                str_Session_Date.GroupViewValue = ConvertToString(str_Session_Date.GroupValue); // DN
                str_Session_Date.CellCssClass = "ew-rpt-grp-field-2";
                str_Session_Date.ViewCustomAttributes = "";
                str_Session_Date.GroupViewValue = DisplayGroupValue(str_Session_Date, str_Session_Date.GroupViewValue);
                if (!str_Session_Date.LevelBreak)
                    str_Session_Date.GroupViewValue = "&nbsp;";
                else
                    str_Session_Date.LevelBreak = false;

                // int_CRSession_ID
                int_CRSession_ID.ViewValue = int_CRSession_ID.CurrentValue;
                int_CRSession_ID.CellCssClass = (RecordCount % 2 != 1 ? "ew-table-alt-row" : "");
                int_CRSession_ID.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.CellCssClass = (RecordCount % 2 != 1 ? "ew-table-alt-row" : "");
                int_Status.ViewCustomAttributes = "";

                // str_Day_Name
                str_Day_Name.ViewValue = ConvertToString(str_Day_Name.CurrentValue); // DN
                str_Day_Name.CellCssClass = (RecordCount % 2 != 1 ? "ew-table-alt-row" : "");
                str_Day_Name.ViewCustomAttributes = "";

                // str_Time_Start
                str_Time_Start.ViewValue = ConvertToString(str_Time_Start.CurrentValue); // DN
                str_Time_Start.CellCssClass = (RecordCount % 2 != 1 ? "ew-table-alt-row" : "");
                str_Time_Start.ViewCustomAttributes = "";

                // str_Time_End
                str_Time_End.ViewValue = ConvertToString(str_Time_End.CurrentValue); // DN
                str_Time_End.CellCssClass = (RecordCount % 2 != 1 ? "ew-table-alt-row" : "");
                str_Time_End.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.HrefValue = "";
                str_CR_Number.TooltipValue = "";

                // str_Session_Date
                str_Session_Date.HrefValue = "";
                str_Session_Date.TooltipValue = "";

                // int_CRSession_ID
                int_CRSession_ID.HrefValue = "";
                int_CRSession_ID.TooltipValue = "";

                // int_Status
                int_Status.HrefValue = "";
                int_Status.TooltipValue = "";

                // str_Day_Name
                str_Day_Name.HrefValue = "";
                str_Day_Name.TooltipValue = "";

                // str_Time_Start
                str_Time_Start.HrefValue = "";
                str_Time_Start.TooltipValue = "";

                // str_Time_End
                str_Time_End.HrefValue = "";
                str_Time_End.TooltipValue = "";
            }

            // Call Cell Rendered event
            object? viewValue; // DN
            if (RowType == RowType.Total) {
                // str_CR_Number
                CellRendered(str_CR_Number, str_CR_Number.GroupViewValue, ref str_CR_Number.GroupViewValue, str_CR_Number.ViewAttrs, str_CR_Number.CellAttrs, ref str_CR_Number.HrefValue, str_CR_Number.LinkAttrs);

                // str_Session_Date
                CellRendered(str_Session_Date, str_Session_Date.GroupViewValue, ref str_Session_Date.GroupViewValue, str_Session_Date.ViewAttrs, str_Session_Date.CellAttrs, ref str_Session_Date.HrefValue, str_Session_Date.LinkAttrs);

                // int_CRSession_ID
                viewValue = int_CRSession_ID.CntViewValue;
                CellRendered(int_CRSession_ID, viewValue, ref viewValue, int_CRSession_ID.ViewAttrs, int_CRSession_ID.CellAttrs, ref int_CRSession_ID.HrefValue, int_CRSession_ID.LinkAttrs);
                int_CRSession_ID.CntViewValue = ConvertToString(viewValue);
            } else {
                // str_CR_Number
                CellRendered(str_CR_Number, str_CR_Number.CurrentValue, ref str_CR_Number.ViewValue, str_CR_Number.ViewAttrs, str_CR_Number.CellAttrs, ref str_CR_Number.HrefValue, str_CR_Number.LinkAttrs);

                // str_Session_Date
                CellRendered(str_Session_Date, str_Session_Date.CurrentValue, ref str_Session_Date.ViewValue, str_Session_Date.ViewAttrs, str_Session_Date.CellAttrs, ref str_Session_Date.HrefValue, str_Session_Date.LinkAttrs);

                // int_CRSession_ID
                CellRendered(int_CRSession_ID, int_CRSession_ID.CurrentValue, ref int_CRSession_ID.ViewValue, int_CRSession_ID.ViewAttrs, int_CRSession_ID.CellAttrs, ref int_CRSession_ID.HrefValue, int_CRSession_ID.LinkAttrs);

                // int_Status
                CellRendered(int_Status, int_Status.CurrentValue, ref int_Status.ViewValue, int_Status.ViewAttrs, int_Status.CellAttrs, ref int_Status.HrefValue, int_Status.LinkAttrs);

                // str_Day_Name
                CellRendered(str_Day_Name, str_Day_Name.CurrentValue, ref str_Day_Name.ViewValue, str_Day_Name.ViewAttrs, str_Day_Name.CellAttrs, ref str_Day_Name.HrefValue, str_Day_Name.LinkAttrs);

                // str_Time_Start
                CellRendered(str_Time_Start, str_Time_Start.CurrentValue, ref str_Time_Start.ViewValue, str_Time_Start.ViewAttrs, str_Time_Start.CellAttrs, ref str_Time_Start.HrefValue, str_Time_Start.LinkAttrs);

                // str_Time_End
                CellRendered(str_Time_End, str_Time_End.CurrentValue, ref str_Time_End.ViewValue, str_Time_End.ViewAttrs, str_Time_End.CellAttrs, ref str_Time_End.HrefValue, str_Time_End.LinkAttrs);
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
            if (str_CR_Number.Visible)
                GroupColumnCount++;
            if (str_Session_Date.Visible) {
                GroupColumnCount++;
                SubGroupColumnCount++;
            }
            if (int_CRSession_ID.Visible)
                DetailColumnCount++;
            if (int_Status.Visible)
                DetailColumnCount++;
            if (str_Day_Name.Visible)
                DetailColumnCount++;
            if (str_Time_Start.Visible)
                DetailColumnCount++;
            if (str_Time_End.Visible)
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

        // Set up master/detail based on QueryString
        protected void SetupMasterParms() {
            bool validMaster = false;
            StringValues masterTblVar;
            StringValues fk;
            Dictionary<string, object> foreignKeys = new ();

            // Get the keys for master table
            if (Query.TryGetValue(Config.TableShowMaster, out masterTblVar) || Query.TryGetValue(Config.TableMaster, out masterTblVar)) { // Do not use Get()
                if (Empty(masterTblVar)) {
                    validMaster = true;
                    DbMasterFilter = "";
                    DbDetailFilter = "";
                }
                if (masterTblVar == "tblCRAttendance") {
                    validMaster = true;
                    if (tblCrAttendance != null && (Get("fk_str_CR_Number", out fk) || Get("str_CR_Number", out fk))) {
                        tblCrAttendance.str_CR_Number.QueryValue = fk;
                        str_CR_Number.QueryValue = tblCrAttendance.str_CR_Number.QueryValue;
                        str_CR_Number.SessionValue = str_CR_Number.QueryValue;
                        foreignKeys.Add("str_CR_Number", fk);
                    } else {
                        validMaster = false;
                    }
                }
            } else if (Form.TryGetValue(Config.TableShowMaster, out masterTblVar) || Form.TryGetValue(Config.TableMaster, out masterTblVar)) {
                if (masterTblVar == "") {
                    validMaster = true;
                    DbMasterFilter = "";
                    DbDetailFilter = "";
                }
                if (masterTblVar == "tblCRAttendance") {
                    validMaster = true;
                    if (tblCrAttendance != null && (Post("fk_str_CR_Number", out fk) || Post("str_CR_Number", out fk))) {
                        tblCrAttendance.str_CR_Number.FormValue = fk;
                        str_CR_Number.FormValue = tblCrAttendance.str_CR_Number.FormValue;
                        str_CR_Number.SessionValue = str_CR_Number.FormValue;
                        foreignKeys.Add("str_CR_Number", fk);
                    } else {
                        validMaster = false;
                    }
                }
            }
            if (validMaster) {
                // Save current master table
                CurrentMasterTable = masterTblVar.ToString();

                // Clear previous master key from Session
                if (masterTblVar != "tblCRAttendance") {
                    if (!foreignKeys.ContainsKey("str_CR_Number")) // Not current foreign key
                        str_CR_Number.SessionValue = "";
                }
            }
            DbMasterFilter = MasterFilterFromSession; // Get master filter from session
            DbDetailFilter = DetailFilterFromSession; // Get detail filter from session
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"fSessionssrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"fSessionssrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                return "int_CRSession_ID ASC";
            bool resetSort = Param("cmd") == "resetsort";
            string orderBy = Param("order"), orderType = Param("ordertype");

            // Check for Ctrl pressed
            bool ctrl = !Empty(Param("ctrl"));

            // Check for a resetsort command
            if (resetSort) {
                OrderBy = "";
                SessionStartGroup = 1;
                int_CRSession_ID.Sort = "";
                str_CR_Number.Sort = "";
                int_Status.Sort = "";
                str_Session_Date.Sort = "";
                str_Day_Name.Sort = "";
                str_Time_Start.Sort = "";
                str_Time_End.Sort = "";

            // Check for an Order parameter
            } else if (!Empty(orderBy)) {
                CurrentOrder = orderBy;
                CurrentOrderType = orderType;
                UpdateSort(int_CRSession_ID, ctrl); // int_CRSession_ID
                UpdateSort(str_CR_Number, ctrl); // str_CR_Number
                UpdateSort(int_Status, ctrl); // int_Status
                UpdateSort(str_Session_Date, ctrl); // str_Session_Date
                UpdateSort(str_Day_Name, ctrl); // str_Day_Name
                UpdateSort(str_Time_Start, ctrl); // str_Time_Start
                UpdateSort(str_Time_End, ctrl); // str_Time_End
                OrderBy = SortSql;
                SessionStartGroup = 1;
            }

            // Set up default sort
            if (Empty(OrderBy)) {
                bool useDefaultSort = true;
                if (useDefaultSort) {
                    OrderBy = "int_CRSession_ID ASC";
                }
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
