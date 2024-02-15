namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// qryClassRoomListList
    /// </summary>
    public static QryClassRoomListList qryClassRoomListList
    {
        get => HttpData.Get<QryClassRoomListList>("qryClassRoomListList")!;
        set => HttpData["qryClassRoomListList"] = value;
    }

    /// <summary>
    /// Page class for qryClassRoomList
    /// </summary>
    public class QryClassRoomListList : QryClassRoomListListBase
    {
        // Constructor
        public QryClassRoomListList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public QryClassRoomListList() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class QryClassRoomListListBase : QryClassRoomList
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "qryClassRoomList";

        // Page object name
        public string PageObjName = "qryClassRoomListList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "fqryClassRoomListlist";

        public string FormActionName = "";

        public string FormBlankRowName = "";

        public string FormKeyCountName = "";

        // Page headings
        public string Heading = "";

        public string Subheading = "";

        public string PageHeader = "";

        public string PageFooter = "";

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
        public QryClassRoomListListBase()
        {
            // CSS class name as context
            TableVar = "qryClassRoomList";
            ContextClass = CheckClassName(TableVar);
            TableGridClass = AppendClass(TableGridClass, ContextClass);
            FormActionName = Config.FormRowActionName;
            FormBlankRowName = Config.FormBlankRowName;
            FormKeyCountName = Config.FormKeyCountName;

            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-table";

            // CSS class name as context
            ContextClass = CheckClassName(TableVar);
            TableGridClass = AppendClass(TableGridClass, ContextClass);

            // Language object
            Language = ResolveLanguage();

            // Table object (qryClassRoomList)
            if (qryClassRoomList == null || qryClassRoomList is QryClassRoomList)
                qryClassRoomList = this;

            // Initialize URLs
            AddUrl = "QryClassRoomListAdd";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "QryClassRoomListDelete";
            MultiUpdateUrl = "QryClassRoomListUpdate";

            // Start time
            StartTime = Environment.TickCount;

            // Debug message
            LoadDebugMessage();

            // Open connection
            Conn = Connection; // DN

            // User table object (tblStudents)
            UserTable = Resolve("usertable")!;
            UserTableConn = GetConnection(UserTable.DbId);

            // Other options
            OtherOptions["addedit"] = new () {
                TagClassName = "ew-add-edit-option",
                UseDropDownButton = false,
                DropDownButtonPhrase = "ButtonAddEdit",
                UseButtonGroup = true
            };

            // Other options
            OtherOptions["detail"] = new () { TagClassName = "ew-detail-option" };
            OtherOptions["action"] = new () { TagClassName = "ew-action-option" };
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
                if (!Empty(TableName))
                    return Language.Phrase(PageID);
                return "";
            }
        }

        // Page name
        public string PageName => "QryClassRoomListList";

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

        // Update URLs
        public string InlineAddUrl = "";

        public string GridAddUrl = "";

        public string GridEditUrl = "";

        public string MultiEditUrl = "";

        public string MultiDeleteUrl = "";

        public string MultiUpdateUrl = "";

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

        // Set field visibility
        public void SetVisibility()
        {
            int_CR_ID.SetVisibility();
            int_CR_Product_ID.SetVisibility();
            str_CR_Number.SetVisibility();
            mon_CR_Price.SetVisibility();
            int_CR_Size.SetVisibility();
            int_MU_Size.SetVisibility();
            int_CR_Status.SetVisibility();
            Is_Web_SignUp.SetVisibility();
            int_Location_ID.SetVisibility();
            int_Teacher_ID.SetVisibility();
            date_Start.SetVisibility();
            int_TotSession.SetVisibility();
            int_PerDaySession.SetVisibility();
            str_CR_Days.SetVisibility();
            str_CR_Notes.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            bit_AllTeacher.SetVisibility();
            int_Manual_Change.SetVisibility();
            str_WebDesc.SetVisibility();
            is_Show.SetVisibility();
            is_ShowGridColumn.SetVisibility();
            rowIndex.SetVisibility();
            is_ZoomMeet.SetVisibility();
            Classroom_Internal_Cr_Notes.Visible = false;
            BulkCR_Set.SetVisibility();
            int_Day_Incremental.SetVisibility();
            int_Reoccurrence.SetVisibility();
            str_Username.SetVisibility();
            Calendar_ID.SetVisibility();
            str_Package_Name.SetVisibility();
            date_Start2.SetVisibility();
            date_Start3.SetVisibility();
            date_Start4.SetVisibility();
        }

        // Constructor
        public QryClassRoomListListBase(Controller? controller = null): this() { // DN
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
                    // Handle modal response (Assume return to modal for simplicity)
                    if (IsModal) { // Show as modal
                        var result = new Dictionary<string, string> { {"url", GetUrl(url)}, {"modal", "1"} };
                        string pageName = GetPageName(url);
                        if (pageName != ListUrl) { // Not List page
                            result.Add("caption", GetModalCaption(pageName));
                            result.Add("view", pageName == "QryClassRoomListView" ? "1" : "0"); // If View page, no primary button
                        } else { // List page
                            // result.Add("list", PageID == "search" ? "1" : "0"); // Refresh List page if current page is Search page
                            result.Add("error", FailureMessage); // List page should not be shown as modal => error
                            ClearFailureMessage();
                        }
                        return Controller.Json(result);
                    } else {
                        SaveDebugMessage();
                        return Controller.LocalRedirect(AppPath(url));
                    }
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

        // Get all records from datareader
        [return: NotNullIfNotNull("dr")]
        protected async Task<List<Dictionary<string, object>>> GetRecordsFromRecordset(DbDataReader? dr)
        {
            var rows = new List<Dictionary<string, object>>();
            while (dr != null && await dr.ReadAsync()) {
                await LoadRowValues(dr); // Set up DbValue/CurrentValue
                if (GetRecordFromDictionary(GetDictionary(dr)) is Dictionary<string, object> row)
                    rows.Add(row);
            }
            return rows;
        }

        // Get all records from the list of records
        #pragma warning disable 1998

        protected async Task<List<Dictionary<string, object>>> GetRecordsFromRecordset(List<Dictionary<string, object>>? list)
        {
            var rows = new List<Dictionary<string, object>>();
            if (list != null) {
                foreach (var row in list) {
                    if (GetRecordFromDictionary(row) is Dictionary<string, object> d)
                       rows.Add(row);
                }
            }
            return rows;
        }
        #pragma warning restore 1998

        // Get the first record from datareader
        [return: NotNullIfNotNull("dr")]
        protected async Task<Dictionary<string, object>?> GetRecordFromRecordset(DbDataReader? dr)
        {
            if (dr != null) {
                await LoadRowValues(dr); // Set up DbValue/CurrentValue
                return GetRecordFromDictionary(GetDictionary(dr));
            }
            return null;
        }

        // Get the first record from the list of records
        protected Dictionary<string, object>? GetRecordFromRecordset(List<Dictionary<string, object>>? list) =>
            list != null && list.Count > 0 ? GetRecordFromDictionary(list[0]) : null;

        // Get record from Dictionary
        protected Dictionary<string, object>? GetRecordFromDictionary(Dictionary<string, object>? dict) {
            if (dict == null)
                return null;
            var row = new Dictionary<string, object>();
            foreach (var (key, value) in dict) {
                if (Fields.TryGetValue(key, out DbField? fld)) {
                    if (fld.Visible || fld.IsPrimaryKey) { // Primary key or Visible
                        if (fld.HtmlTag == "FILE") { // Upload field
                            if (Empty(value)) {
                                // row[key] = null;
                            } else {
                                if (fld.DataType == DataType.Blob) {
                                    string url = FullUrl(GetPageName(Config.ApiUrl) + "/" + Config.ApiFileAction + "/" + fld.TableVar + "/" + fld.Param + "/" + GetRecordKeyValue(dict)); // Query string format
                                    row[key] = new Dictionary<string, object> { { "type", ContentType((byte[])value) }, { "url", url }, { "name", fld.Param + ContentExtension((byte[])value) } };
                                } else if (!fld.UploadMultiple || !ConvertToString(value).Contains(Config.MultipleUploadSeparator)) { // Single file
                                    string url = FullUrl(GetPageName(Config.ApiUrl) + "/" + Config.ApiFileAction + "/" + fld.TableVar + "/" + Encrypt(fld.PhysicalUploadPath + ConvertToString(value))); // Query string format
                                    row[key] = new Dictionary<string, object> { { "type", ContentType(ConvertToString(value)) }, { "url", url }, { "name", ConvertToString(value) } };
                                } else { // Multiple files
                                    var files = ConvertToString(value).Split(Config.MultipleUploadSeparator);
                                    row[key] = files.Where(file => !Empty(file)).Select(file => new Dictionary<string, object> { { "type", ContentType(file) }, { "url", FullUrl(GetPageName(Config.ApiUrl) + "/" + Config.ApiFileAction + "/" + fld.TableVar + "/" + Encrypt(fld.PhysicalUploadPath + file)) }, { "name", file } });
                                }
                            }
                        } else {
                            string val = ConvertToString(value);
                            if (fld.DataType == DataType.Date && value is DateTime dt)
                                val = dt.ToString("s");
                            if (fld.DataType == DataType.Memo && fld.MemoMaxLength > 0 && !Empty(val))
                                val = TruncateMemo(val, fld.MemoMaxLength, fld.TruncateMemoRemoveHtml);
                            row[key] = ConvertToString(val);
                        }
                    }
                }
            }
            return row;
        }

        // Get record key value from array
        protected string GetRecordKeyValue(Dictionary<string, object> dict) {
            string key = "";
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_CR_ID") ? dict["int_CR_ID"] : int_CR_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_CR_ID.Visible = false;
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

        public int SelectedCount = 0;

        public int SelectedIndex = 0;

        public int DisplayRecords = 20; // Number of display records

        public int StartRecord;

        public int StopRecord;

        public int TotalRecords = -1;

        public int RecordRange = 10;

        public string PageSizes = "10,20,50,-1"; // Page sizes (comma separated)

        public string DefaultSearchWhere = ""; // Default search WHERE clause

        public string SearchWhere = ""; // Search WHERE clause

        public string SearchPanelClass = "ew-search-panel collapse show"; // Search panel class

        public int SearchColumnCount = 0; // For extended search

        public int SearchFieldsPerRow = 1; // For extended search

        public int RecordCount = 0; // Record count

        public int InlineRowCount = 0;

        public int StartRowCount = 1;

        public List<Tuple<string, Dictionary<string, string>>> Attributes = new (); // Row attributes and cell attributes

        public object RowIndex = 0; // Row index

        public int KeyCount = 0; // Key count

        public string MultiColumnGridClass = "row-cols-md-2";

        public string MultiColumnEditClass = "col-12 w-100";

        public string MultiColumnCardClass = "card h-100 ew-card";

        public string MultiColumnListOptionsPosition = "bottom-start";

        public string MultiColumnLayout = "cards";

        public string DbMasterFilter = ""; // Master filter

        public string DbDetailFilter = ""; // Detail filter

        public bool MasterRecordExists;

        public string MultiSelectKey = "";

        public string UserAction = ""; // User action

        public bool RestoreSearch = false;

        public SubPages? DetailPages; // Detail pages object

        public DbDataReader? Recordset;

        public string TopContentClass = "ew-top";

        public string MiddleContentClass = "ew-middle";

        public string BottomContentClass = "ew-bottom";

        public List<string> RecordKeys = new ();

        public bool IsModal = false;

        private string FilterForModalActions = "";

        private bool UseInfiniteScroll = false;

        // Pager
        public Pager Pager
        {
            get {
                _pager ??= new PrevNextPager(this, StartRecord, RecordsPerPage, TotalRecords, PageSizes, RecordRange, AutoHidePager, AutoHidePageSizeSelector);
                return _pager;
            }
        }

        /// <summary>
        /// Load recordset from filter
        /// <param name="filter">Record filter</param>
        /// </summary>
        public async Task LoadRecordsetFromFilter(string filter)
        {
            // Set up list options
            await SetupListOptions();

            // Search options
            SetupSearchOptions();

            // Other options
            SetupOtherOptions();

            // Set visibility
            SetVisibility();

            // Load recordset
            TotalRecords = LoadRecordCount(filter);
            StartRecord = 1;
            StopRecord = DisplayRecords;
            CurrentFilter = filter;
            Recordset = await LoadRecordset();
        }

        #pragma warning disable 219
        /// <summary>
        /// Page run
        /// </summary>
        /// <returns>Page result</returns>
        public override async Task<IActionResult> Run()
        {
            // Multi column button position
            MultiColumnListOptionsPosition = Config.MultiColumnListOptionsPosition;
            DashboardReport = DashboardReport || Param<bool>(Config.PageDashboard);

            // Is modal
            IsModal = Param<bool>("modal");
            UseLayout = UseLayout && !IsModal;

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
            } else {
                ExportReturnUrl = CurrentUrl();
            }
            ExportType = Export; // Get export parameter, used in header
            if (!Empty(ExportType))
                SkipHeaderFooter = true;
            if (!Empty(Export) && !SameText(Export, "print") && Empty(custom)) // No layout for export // DN
                UseLayout = false;
            CurrentAction = Param("action"); // Set up current action

            // Get grid add count
            int gridaddcnt = Get<int>(Config.TableGridAddRowCount);
            if (gridaddcnt > 0)
                GridAddRowCount = gridaddcnt;

            // Set up list options
            await SetupListOptions();

            // Setup export options
            SetupExportOptions();
            SetVisibility();

            // Do not use lookup cache
            if (!Config.LookupCachePageIds.Contains(PageID))
                SetUseLookupCache(false);

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

            // Hide fields for add/edit
            if (!UseAjaxActions)
                HideFieldsForAddEdit();
            // Use inline delete
            if (UseAjaxActions)
                InlineDelete = true;

            // Setup other options
            SetupOtherOptions();

            // Set up custom action (compatible with old version)
            ListActions.Add(CustomActions);

            // Set up lookup cache
            await SetupLookupOptions(Is_Web_SignUp);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_AllTeacher);
            await SetupLookupOptions(is_Show);
            await SetupLookupOptions(is_ShowGridColumn);
            await SetupLookupOptions(is_ZoomMeet);

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "fqryClassRoomListgrid";

            // Set up infinite scroll
            UseInfiniteScroll = Param<bool>("infinitescroll");

            // Search filters
            string srchAdvanced = ""; // Advanced search filter
            string srchBasic = ""; // Basic search filter
            string filter = ""; // Filter
            string query = ""; // Query builder

            // Get command
            Command = Get("cmd").ToLower();

            // Process list action first
            var result = await ProcessListAction();
            if (result is not EmptyResult) // Ajax request
                return result;

            // Set up records per page
            SetupDisplayRecords();

            // Handle reset command
            ResetCommand();

            // Set up Breadcrumb
            if (!IsExport())
                SetupBreadcrumb();

            // Hide list options
            if (IsExport()) {
                ListOptions.HideAllOptions(new () {"sequence"});
                ListOptions.UseDropDownButton = false; // Disable drop down button
                ListOptions.UseButtonGroup = false; // Disable button group
            } else if (IsGridAdd || IsGridEdit || IsMultiEdit || IsConfirm) {
                ListOptions.HideAllOptions();
                ListOptions.UseDropDownButton = false; // Disable drop down button
                ListOptions.UseButtonGroup = false; // Disable button group
            }

            // Hide options
            if (IsExport() || !Empty(CurrentAction) || IsSearch) {
                ExportOptions.HideAllOptions();
                FilterOptions.HideAllOptions();
                ImportOptions.HideAllOptions();
            }

            // Hide other options
            if (IsExport()) {
                foreach (var (key, value) in OtherOptions)
                    value.HideAllOptions();
            }

            // Get default search criteria
            AddFilter(ref DefaultSearchWhere, BasicSearchWhere(true));

            // Get basic search values
            LoadBasicSearchValues();

            // Process filter list
            var filterResult = await ProcessFilterList();
            if (filterResult != null) {
                // Clean output buffer
                if (!Config.Debug)
                    Response?.Clear();
                return Controller.Json(filterResult);
            }

            // Restore search parms from Session if not searching / reset / export
            if ((IsExport() || Command != "search" && Command != "reset" && Command != "resetall") && Command != "json" && CheckSearchParms())
                RestoreSearchParms();

            // Call Recordset SearchValidated event
            RecordsetSearchValidated();

            // Set up sorting order
            SetupSortOrder();

            // Get basic search criteria
            if (!HasInvalidFields())
                srchBasic = BasicSearchWhere();

            // Restore display records
            if (Command != "json" && (RecordsPerPage == -1 || RecordsPerPage > 0)) {
                DisplayRecords = RecordsPerPage; // Restore from Session
            } else {
                DisplayRecords = 20; // Load default
                RecordsPerPage = DisplayRecords; // Save default to session
            }

            // Load search default if no existing search criteria
            if (!CheckSearchParms() && Empty(query)) {
                // Load basic search from default
                BasicSearch.LoadDefault();
                if (!Empty(BasicSearch.Keyword))
                    srchBasic = BasicSearchWhere(); // Save to session
            }

            // Build search criteria
            if (!Empty(query)) {
                AddFilter(ref SearchWhere, query);
            } else {
                AddFilter(ref SearchWhere, srchAdvanced);
                AddFilter(ref SearchWhere, srchBasic);
            }

            // Call Recordset Searching event
            RecordsetSearching(ref SearchWhere);

            // Save search criteria
            if (Command == "search" && !RestoreSearch) {
                SessionSearchWhere = SearchWhere; // Save to Session (rename as SessionSearchWhere property)
                StartRecord = 1; // Reset start record counter
                StartRecordNumber = StartRecord;
            } else if (Command != "json" && Empty(query)) {
                SearchWhere = SessionSearchWhere;
            }

            // Build filter
            filter = "";
            if (!Security.CanList)
                filter = "(0=1)"; // Filter all records
            AddFilter(ref filter, DbDetailFilter);
            AddFilter(ref filter, SearchWhere);

            // Set up filter
            if (Command == "json") {
                UseSessionForListSql = false; // Do not use session for ListSql
                CurrentFilter = filter;
            } else {
                SessionWhere = filter;
                CurrentFilter = "";
            }
            Filter = ApplyUserIDFilters(filter);
            if (IsGridAdd) {
                CurrentFilter = "0=1";
                StartRecord = 1;
                DisplayRecords = GridAddRowCount;
                TotalRecords = DisplayRecords;
                StopRecord = DisplayRecords;
            } else if ((IsEdit || IsCopy || IsInlineInserted || IsInlineUpdated) && UseInfiniteScroll) { // Get current record only
                CurrentFilter = IsInlineUpdated ? GetRecordFilter() : GetFilterFromRecordKeys();
                TotalRecords = ListRecordCount();
                StartRecord = 1;
                StopRecord = DisplayRecords;
                Recordset = await LoadRecordset();
            } else if (
                UseInfiniteScroll && IsGridInserted ||
                UseInfiniteScroll && (IsGridEdit || IsGridUpdated) ||
                IsMultiEdit ||
                UseInfiniteScroll && IsMultiUpdated
            ) { // Get current records only
                CurrentFilter = FilterForModalActions; // Restore filter
                TotalRecords = ListRecordCount();
                StartRecord = 1;
                StopRecord = DisplayRecords;
                Recordset = await LoadRecordset();
            } else {
                TotalRecords = await ListRecordCountAsync();
                StopRecord = DisplayRecords;
                StartRecord = 1;
                if (DisplayRecords <= 0 || (IsExport() && ExportAll)) // Display all records
                    DisplayRecords = TotalRecords;
                if (!(IsExport() && ExportAll)) // Set up start record position
                    SetupStartRecord();

                // Recordset
                bool selectLimit = UseSelectLimit;

                // Set up list action columns, must be before LoadRecordset // DN
                foreach (var (key, act) in ListActions.Items.Where(kvp => kvp.Value.Allowed)) {
                    if (act.Select == Config.ActionMultiple && ListOptions["checkbox"] is ListOption listOpt) { // Show checkbox column if multiple action
                        listOpt.Visible = true;
                    } else if (act.Select == Config.ActionSingle) { // Show list action column
                            ListOptions["listactions"]?.SetVisible(true); // Set visible if any list action is allowed
                    }
                }
                if (selectLimit)
                    Recordset = await LoadRecordset(StartRecord - 1, DisplayRecords);

                // Set no record found message
                if ((Empty(CurrentAction) || IsSearch) && TotalRecords == 0) {
                    if (!Security.CanList)
                        WarningMessage = DeniedMessage();
                    if (SearchWhere == "0=101")
                        WarningMessage = Language.Phrase("EnterSearchCriteria");
                    else
                        WarningMessage = Language.Phrase("NoRecord");
                }
            }

            // Search options
            SetupSearchOptions();

            // Set up search panel class
            if (!Empty(SearchWhere)) {
                if (!Empty(query)) { // Hide search panel if using QueryBuilder
                    SearchPanelClass = RemoveClass(SearchPanelClass, "show");
                } else {
                    SearchPanelClass = AppendClass(SearchPanelClass, "show");
                }
            }

            // Handle inline add for custom template in table layout with no records
            if (UseCustomTemplate && MultiColumnLayout == "table" && IsAdd && TotalRecords == 0)
                MultiColumnLayout = "cards";

            // No custom template for cards layout
            if (MultiColumnLayout == "cards")
                UseCustomTemplate = false;

            // API list action
            if (IsApi()) {
                if (CurrentPageName().EndsWith(Config.ApiListAction)) { // DN
                    if (!IsExport()) {
                        if (!Connection.SelectOffset && Recordset != null) { // DN
                            for (var i = 1; i <= StartRecord - 1; i++) // Move to first record
                                await Recordset.ReadAsync();
                        }
                        using (Recordset) {
                            return Controller.Json(new Dictionary<string, object> { {"success", true}, {TableVar, await GetRecordsFromRecordset(Recordset)}, {"totalRecordCount", TotalRecords}, {"version", Config.ProductVersion} });
                        }
                    }
                } else if (!Empty(FailureMessage)) {
                    return Controller.Json(new { success = false, error = GetFailureMessage() });
                }
                return new EmptyResult();
            }

            // Render other options
            RenderOtherOptions();

            // Set ReturnUrl in header if necessary
            if (TempData["Return-Url"] != null)
                AddHeader("Return-Url", ConvertToString(TempData["Return-Url"]));

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                qryClassRoomListList?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 219

        // Get page number
        public int PageNumber => DisplayRecords > 0 && StartRecord > 0 ? ConvertToInt(Math.Ceiling((double)StartRecord / DisplayRecords)) : 1;

        // Set up number of records displayed per page
        protected void SetupDisplayRecords() {
            string wrk = Get(Config.TableRecordsPerPage);
            if (!Empty(wrk)) {
                if (IsNumeric(wrk)) {
                    DisplayRecords = ConvertToInt(wrk);
                } else {
                    if (SameText(wrk, "all")) { // Display all records
                        DisplayRecords = -1;
                    } else {
                        DisplayRecords = 20; // Non-numeric, load default
                    }
                }
                RecordsPerPage = DisplayRecords; // Save to Session
                // Reset start position
                StartRecord = 1;
                StartRecordNumber = StartRecord;
            }
        }

        // Build filter for all keys
        protected string BuildKeyFilter() {
            string wrkFilter = "";

            // Update row index and get row key
            int rowindex = 1;
            CurrentForm!.Index = rowindex;
            string thisKey = CurrentForm.GetValue(OldKeyName);
            while (!Empty(thisKey)) {
                SetKey(thisKey);
                if (!Empty(OldKey)) {
                    string filter = GetRecordFilter();
                    if (!Empty(wrkFilter))
                        wrkFilter += " OR ";
                    wrkFilter += filter;
                } else {
                    wrkFilter = "0=1";
                    break;
                }

                // Update row index and get row key
                rowindex++; // next row
                CurrentForm!.Index = rowindex;
                thisKey = CurrentForm.GetValue(OldKeyName);
            }
            return wrkFilter;
        }

        // Check if empty row
        public bool EmptyRow() => false;

        #pragma warning disable 162, 1998
        // Get list of filters
        public async Task<string> GetFilterList()
        {
            string filterList = "";
            string savedFilterList = "";

            // Load server side filters
            if (Config.SearchFilterOption == "Server")
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "fqryClassRoomListsrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_CR_ID.AdvancedSearch.ToJson())); // Field int_CR_ID
            filters.Merge(JObject.Parse(int_CR_Product_ID.AdvancedSearch.ToJson())); // Field int_CR_Product_ID
            filters.Merge(JObject.Parse(str_CR_Number.AdvancedSearch.ToJson())); // Field str_CR_Number
            filters.Merge(JObject.Parse(mon_CR_Price.AdvancedSearch.ToJson())); // Field mon_CR_Price
            filters.Merge(JObject.Parse(int_CR_Size.AdvancedSearch.ToJson())); // Field int_CR_Size
            filters.Merge(JObject.Parse(int_MU_Size.AdvancedSearch.ToJson())); // Field int_MU_Size
            filters.Merge(JObject.Parse(int_CR_Status.AdvancedSearch.ToJson())); // Field int_CR_Status
            filters.Merge(JObject.Parse(Is_Web_SignUp.AdvancedSearch.ToJson())); // Field Is_Web_SignUp
            filters.Merge(JObject.Parse(int_Location_ID.AdvancedSearch.ToJson())); // Field int_Location_ID
            filters.Merge(JObject.Parse(int_Teacher_ID.AdvancedSearch.ToJson())); // Field int_Teacher_ID
            filters.Merge(JObject.Parse(date_Start.AdvancedSearch.ToJson())); // Field date_Start
            filters.Merge(JObject.Parse(int_TotSession.AdvancedSearch.ToJson())); // Field int_TotSession
            filters.Merge(JObject.Parse(int_PerDaySession.AdvancedSearch.ToJson())); // Field int_PerDaySession
            filters.Merge(JObject.Parse(str_CR_Days.AdvancedSearch.ToJson())); // Field str_CR_Days
            filters.Merge(JObject.Parse(str_CR_Notes.AdvancedSearch.ToJson())); // Field str_CR_Notes
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(bit_AllTeacher.AdvancedSearch.ToJson())); // Field bit_AllTeacher
            filters.Merge(JObject.Parse(int_Manual_Change.AdvancedSearch.ToJson())); // Field int_Manual_Change
            filters.Merge(JObject.Parse(str_WebDesc.AdvancedSearch.ToJson())); // Field str_WebDesc
            filters.Merge(JObject.Parse(is_Show.AdvancedSearch.ToJson())); // Field is_Show
            filters.Merge(JObject.Parse(is_ShowGridColumn.AdvancedSearch.ToJson())); // Field is_ShowGridColumn
            filters.Merge(JObject.Parse(rowIndex.AdvancedSearch.ToJson())); // Field rowIndex
            filters.Merge(JObject.Parse(is_ZoomMeet.AdvancedSearch.ToJson())); // Field is_ZoomMeet
            filters.Merge(JObject.Parse(Classroom_Internal_Cr_Notes.AdvancedSearch.ToJson())); // Field Classroom_Internal_Cr_Notes
            filters.Merge(JObject.Parse(BulkCR_Set.AdvancedSearch.ToJson())); // Field BulkCR_Set
            filters.Merge(JObject.Parse(int_Day_Incremental.AdvancedSearch.ToJson())); // Field int_Day_Incremental
            filters.Merge(JObject.Parse(int_Reoccurrence.AdvancedSearch.ToJson())); // Field int_Reoccurrence
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(Calendar_ID.AdvancedSearch.ToJson())); // Field Calendar_ID
            filters.Merge(JObject.Parse(str_Package_Name.AdvancedSearch.ToJson())); // Field str_Package_Name
            filters.Merge(JObject.Parse(date_Start2.AdvancedSearch.ToJson())); // Field date_Start2
            filters.Merge(JObject.Parse(date_Start3.AdvancedSearch.ToJson())); // Field date_Start3
            filters.Merge(JObject.Parse(date_Start4.AdvancedSearch.ToJson())); // Field date_Start4
            filters.Merge(JObject.Parse(BasicSearch.ToJson()));

            // Return filter list in JSON
            if (filters.HasValues)
                filterList = "\"data\":" + filters.ToString();
            if (savedFilterList != "") {
                if (filterList != "")
                    filterList += ",";
                filterList += "\"filters\":" + savedFilterList;
            }
            return (filterList != "") ? "{" + filterList + "}" : "null";
        }

        // Process filter list
        protected async Task<object?> ProcessFilterList() {
            if (Post("ajax") == "savefilters") {
                string filters = Post("filters");
                await Profile.SetSearchFilters(CurrentUserName(), "fqryClassRoomListsrch", filters);
                return new [] { new { success = true } }; // Return success
            } else if (Post("cmd") == "resetfilter") {
                RestoreFilterList();
            }
            return null;
        }
        #pragma warning restore 162, 1998

        // Restore list of filters
        protected bool RestoreFilterList() {
            // Return if not reset filter
            if (Post("cmd") != "resetfilter")
                return false;
            var filter = JsonConvert.DeserializeObject<Dictionary<string, string>>(Post("filter"));
            Command = "search";
            string? sv;

            // Field int_CR_ID
            if (filter?.TryGetValue("x_int_CR_ID", out sv) ?? false) {
                int_CR_ID.AdvancedSearch.SearchValue = sv;
                int_CR_ID.AdvancedSearch.SearchOperator = filter["z_int_CR_ID"];
                int_CR_ID.AdvancedSearch.SearchCondition = filter["v_int_CR_ID"];
                int_CR_ID.AdvancedSearch.SearchValue2 = filter["y_int_CR_ID"];
                int_CR_ID.AdvancedSearch.SearchOperator2 = filter["w_int_CR_ID"];
                int_CR_ID.AdvancedSearch.Save();
            }

            // Field int_CR_Product_ID
            if (filter?.TryGetValue("x_int_CR_Product_ID", out sv) ?? false) {
                int_CR_Product_ID.AdvancedSearch.SearchValue = sv;
                int_CR_Product_ID.AdvancedSearch.SearchOperator = filter["z_int_CR_Product_ID"];
                int_CR_Product_ID.AdvancedSearch.SearchCondition = filter["v_int_CR_Product_ID"];
                int_CR_Product_ID.AdvancedSearch.SearchValue2 = filter["y_int_CR_Product_ID"];
                int_CR_Product_ID.AdvancedSearch.SearchOperator2 = filter["w_int_CR_Product_ID"];
                int_CR_Product_ID.AdvancedSearch.Save();
            }

            // Field str_CR_Number
            if (filter?.TryGetValue("x_str_CR_Number", out sv) ?? false) {
                str_CR_Number.AdvancedSearch.SearchValue = sv;
                str_CR_Number.AdvancedSearch.SearchOperator = filter["z_str_CR_Number"];
                str_CR_Number.AdvancedSearch.SearchCondition = filter["v_str_CR_Number"];
                str_CR_Number.AdvancedSearch.SearchValue2 = filter["y_str_CR_Number"];
                str_CR_Number.AdvancedSearch.SearchOperator2 = filter["w_str_CR_Number"];
                str_CR_Number.AdvancedSearch.Save();
            }

            // Field mon_CR_Price
            if (filter?.TryGetValue("x_mon_CR_Price", out sv) ?? false) {
                mon_CR_Price.AdvancedSearch.SearchValue = sv;
                mon_CR_Price.AdvancedSearch.SearchOperator = filter["z_mon_CR_Price"];
                mon_CR_Price.AdvancedSearch.SearchCondition = filter["v_mon_CR_Price"];
                mon_CR_Price.AdvancedSearch.SearchValue2 = filter["y_mon_CR_Price"];
                mon_CR_Price.AdvancedSearch.SearchOperator2 = filter["w_mon_CR_Price"];
                mon_CR_Price.AdvancedSearch.Save();
            }

            // Field int_CR_Size
            if (filter?.TryGetValue("x_int_CR_Size", out sv) ?? false) {
                int_CR_Size.AdvancedSearch.SearchValue = sv;
                int_CR_Size.AdvancedSearch.SearchOperator = filter["z_int_CR_Size"];
                int_CR_Size.AdvancedSearch.SearchCondition = filter["v_int_CR_Size"];
                int_CR_Size.AdvancedSearch.SearchValue2 = filter["y_int_CR_Size"];
                int_CR_Size.AdvancedSearch.SearchOperator2 = filter["w_int_CR_Size"];
                int_CR_Size.AdvancedSearch.Save();
            }

            // Field int_MU_Size
            if (filter?.TryGetValue("x_int_MU_Size", out sv) ?? false) {
                int_MU_Size.AdvancedSearch.SearchValue = sv;
                int_MU_Size.AdvancedSearch.SearchOperator = filter["z_int_MU_Size"];
                int_MU_Size.AdvancedSearch.SearchCondition = filter["v_int_MU_Size"];
                int_MU_Size.AdvancedSearch.SearchValue2 = filter["y_int_MU_Size"];
                int_MU_Size.AdvancedSearch.SearchOperator2 = filter["w_int_MU_Size"];
                int_MU_Size.AdvancedSearch.Save();
            }

            // Field int_CR_Status
            if (filter?.TryGetValue("x_int_CR_Status", out sv) ?? false) {
                int_CR_Status.AdvancedSearch.SearchValue = sv;
                int_CR_Status.AdvancedSearch.SearchOperator = filter["z_int_CR_Status"];
                int_CR_Status.AdvancedSearch.SearchCondition = filter["v_int_CR_Status"];
                int_CR_Status.AdvancedSearch.SearchValue2 = filter["y_int_CR_Status"];
                int_CR_Status.AdvancedSearch.SearchOperator2 = filter["w_int_CR_Status"];
                int_CR_Status.AdvancedSearch.Save();
            }

            // Field Is_Web_SignUp
            if (filter?.TryGetValue("x_Is_Web_SignUp", out sv) ?? false) {
                Is_Web_SignUp.AdvancedSearch.SearchValue = sv;
                Is_Web_SignUp.AdvancedSearch.SearchOperator = filter["z_Is_Web_SignUp"];
                Is_Web_SignUp.AdvancedSearch.SearchCondition = filter["v_Is_Web_SignUp"];
                Is_Web_SignUp.AdvancedSearch.SearchValue2 = filter["y_Is_Web_SignUp"];
                Is_Web_SignUp.AdvancedSearch.SearchOperator2 = filter["w_Is_Web_SignUp"];
                Is_Web_SignUp.AdvancedSearch.Save();
            }

            // Field int_Location_ID
            if (filter?.TryGetValue("x_int_Location_ID", out sv) ?? false) {
                int_Location_ID.AdvancedSearch.SearchValue = sv;
                int_Location_ID.AdvancedSearch.SearchOperator = filter["z_int_Location_ID"];
                int_Location_ID.AdvancedSearch.SearchCondition = filter["v_int_Location_ID"];
                int_Location_ID.AdvancedSearch.SearchValue2 = filter["y_int_Location_ID"];
                int_Location_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Location_ID"];
                int_Location_ID.AdvancedSearch.Save();
            }

            // Field int_Teacher_ID
            if (filter?.TryGetValue("x_int_Teacher_ID", out sv) ?? false) {
                int_Teacher_ID.AdvancedSearch.SearchValue = sv;
                int_Teacher_ID.AdvancedSearch.SearchOperator = filter["z_int_Teacher_ID"];
                int_Teacher_ID.AdvancedSearch.SearchCondition = filter["v_int_Teacher_ID"];
                int_Teacher_ID.AdvancedSearch.SearchValue2 = filter["y_int_Teacher_ID"];
                int_Teacher_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Teacher_ID"];
                int_Teacher_ID.AdvancedSearch.Save();
            }

            // Field date_Start
            if (filter?.TryGetValue("x_date_Start", out sv) ?? false) {
                date_Start.AdvancedSearch.SearchValue = sv;
                date_Start.AdvancedSearch.SearchOperator = filter["z_date_Start"];
                date_Start.AdvancedSearch.SearchCondition = filter["v_date_Start"];
                date_Start.AdvancedSearch.SearchValue2 = filter["y_date_Start"];
                date_Start.AdvancedSearch.SearchOperator2 = filter["w_date_Start"];
                date_Start.AdvancedSearch.Save();
            }

            // Field int_TotSession
            if (filter?.TryGetValue("x_int_TotSession", out sv) ?? false) {
                int_TotSession.AdvancedSearch.SearchValue = sv;
                int_TotSession.AdvancedSearch.SearchOperator = filter["z_int_TotSession"];
                int_TotSession.AdvancedSearch.SearchCondition = filter["v_int_TotSession"];
                int_TotSession.AdvancedSearch.SearchValue2 = filter["y_int_TotSession"];
                int_TotSession.AdvancedSearch.SearchOperator2 = filter["w_int_TotSession"];
                int_TotSession.AdvancedSearch.Save();
            }

            // Field int_PerDaySession
            if (filter?.TryGetValue("x_int_PerDaySession", out sv) ?? false) {
                int_PerDaySession.AdvancedSearch.SearchValue = sv;
                int_PerDaySession.AdvancedSearch.SearchOperator = filter["z_int_PerDaySession"];
                int_PerDaySession.AdvancedSearch.SearchCondition = filter["v_int_PerDaySession"];
                int_PerDaySession.AdvancedSearch.SearchValue2 = filter["y_int_PerDaySession"];
                int_PerDaySession.AdvancedSearch.SearchOperator2 = filter["w_int_PerDaySession"];
                int_PerDaySession.AdvancedSearch.Save();
            }

            // Field str_CR_Days
            if (filter?.TryGetValue("x_str_CR_Days", out sv) ?? false) {
                str_CR_Days.AdvancedSearch.SearchValue = sv;
                str_CR_Days.AdvancedSearch.SearchOperator = filter["z_str_CR_Days"];
                str_CR_Days.AdvancedSearch.SearchCondition = filter["v_str_CR_Days"];
                str_CR_Days.AdvancedSearch.SearchValue2 = filter["y_str_CR_Days"];
                str_CR_Days.AdvancedSearch.SearchOperator2 = filter["w_str_CR_Days"];
                str_CR_Days.AdvancedSearch.Save();
            }

            // Field str_CR_Notes
            if (filter?.TryGetValue("x_str_CR_Notes", out sv) ?? false) {
                str_CR_Notes.AdvancedSearch.SearchValue = sv;
                str_CR_Notes.AdvancedSearch.SearchOperator = filter["z_str_CR_Notes"];
                str_CR_Notes.AdvancedSearch.SearchCondition = filter["v_str_CR_Notes"];
                str_CR_Notes.AdvancedSearch.SearchValue2 = filter["y_str_CR_Notes"];
                str_CR_Notes.AdvancedSearch.SearchOperator2 = filter["w_str_CR_Notes"];
                str_CR_Notes.AdvancedSearch.Save();
            }

            // Field int_Created_By
            if (filter?.TryGetValue("x_int_Created_By", out sv) ?? false) {
                int_Created_By.AdvancedSearch.SearchValue = sv;
                int_Created_By.AdvancedSearch.SearchOperator = filter["z_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchCondition = filter["v_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchValue2 = filter["y_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchOperator2 = filter["w_int_Created_By"];
                int_Created_By.AdvancedSearch.Save();
            }

            // Field int_Modified_By
            if (filter?.TryGetValue("x_int_Modified_By", out sv) ?? false) {
                int_Modified_By.AdvancedSearch.SearchValue = sv;
                int_Modified_By.AdvancedSearch.SearchOperator = filter["z_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchCondition = filter["v_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchValue2 = filter["y_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchOperator2 = filter["w_int_Modified_By"];
                int_Modified_By.AdvancedSearch.Save();
            }

            // Field date_Created
            if (filter?.TryGetValue("x_date_Created", out sv) ?? false) {
                date_Created.AdvancedSearch.SearchValue = sv;
                date_Created.AdvancedSearch.SearchOperator = filter["z_date_Created"];
                date_Created.AdvancedSearch.SearchCondition = filter["v_date_Created"];
                date_Created.AdvancedSearch.SearchValue2 = filter["y_date_Created"];
                date_Created.AdvancedSearch.SearchOperator2 = filter["w_date_Created"];
                date_Created.AdvancedSearch.Save();
            }

            // Field date_Modified
            if (filter?.TryGetValue("x_date_Modified", out sv) ?? false) {
                date_Modified.AdvancedSearch.SearchValue = sv;
                date_Modified.AdvancedSearch.SearchOperator = filter["z_date_Modified"];
                date_Modified.AdvancedSearch.SearchCondition = filter["v_date_Modified"];
                date_Modified.AdvancedSearch.SearchValue2 = filter["y_date_Modified"];
                date_Modified.AdvancedSearch.SearchOperator2 = filter["w_date_Modified"];
                date_Modified.AdvancedSearch.Save();
            }

            // Field bit_IsDeleted
            if (filter?.TryGetValue("x_bit_IsDeleted", out sv) ?? false) {
                bit_IsDeleted.AdvancedSearch.SearchValue = sv;
                bit_IsDeleted.AdvancedSearch.SearchOperator = filter["z_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchCondition = filter["v_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchValue2 = filter["y_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchOperator2 = filter["w_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.Save();
            }

            // Field bit_AllTeacher
            if (filter?.TryGetValue("x_bit_AllTeacher", out sv) ?? false) {
                bit_AllTeacher.AdvancedSearch.SearchValue = sv;
                bit_AllTeacher.AdvancedSearch.SearchOperator = filter["z_bit_AllTeacher"];
                bit_AllTeacher.AdvancedSearch.SearchCondition = filter["v_bit_AllTeacher"];
                bit_AllTeacher.AdvancedSearch.SearchValue2 = filter["y_bit_AllTeacher"];
                bit_AllTeacher.AdvancedSearch.SearchOperator2 = filter["w_bit_AllTeacher"];
                bit_AllTeacher.AdvancedSearch.Save();
            }

            // Field int_Manual_Change
            if (filter?.TryGetValue("x_int_Manual_Change", out sv) ?? false) {
                int_Manual_Change.AdvancedSearch.SearchValue = sv;
                int_Manual_Change.AdvancedSearch.SearchOperator = filter["z_int_Manual_Change"];
                int_Manual_Change.AdvancedSearch.SearchCondition = filter["v_int_Manual_Change"];
                int_Manual_Change.AdvancedSearch.SearchValue2 = filter["y_int_Manual_Change"];
                int_Manual_Change.AdvancedSearch.SearchOperator2 = filter["w_int_Manual_Change"];
                int_Manual_Change.AdvancedSearch.Save();
            }

            // Field str_WebDesc
            if (filter?.TryGetValue("x_str_WebDesc", out sv) ?? false) {
                str_WebDesc.AdvancedSearch.SearchValue = sv;
                str_WebDesc.AdvancedSearch.SearchOperator = filter["z_str_WebDesc"];
                str_WebDesc.AdvancedSearch.SearchCondition = filter["v_str_WebDesc"];
                str_WebDesc.AdvancedSearch.SearchValue2 = filter["y_str_WebDesc"];
                str_WebDesc.AdvancedSearch.SearchOperator2 = filter["w_str_WebDesc"];
                str_WebDesc.AdvancedSearch.Save();
            }

            // Field is_Show
            if (filter?.TryGetValue("x_is_Show", out sv) ?? false) {
                is_Show.AdvancedSearch.SearchValue = sv;
                is_Show.AdvancedSearch.SearchOperator = filter["z_is_Show"];
                is_Show.AdvancedSearch.SearchCondition = filter["v_is_Show"];
                is_Show.AdvancedSearch.SearchValue2 = filter["y_is_Show"];
                is_Show.AdvancedSearch.SearchOperator2 = filter["w_is_Show"];
                is_Show.AdvancedSearch.Save();
            }

            // Field is_ShowGridColumn
            if (filter?.TryGetValue("x_is_ShowGridColumn", out sv) ?? false) {
                is_ShowGridColumn.AdvancedSearch.SearchValue = sv;
                is_ShowGridColumn.AdvancedSearch.SearchOperator = filter["z_is_ShowGridColumn"];
                is_ShowGridColumn.AdvancedSearch.SearchCondition = filter["v_is_ShowGridColumn"];
                is_ShowGridColumn.AdvancedSearch.SearchValue2 = filter["y_is_ShowGridColumn"];
                is_ShowGridColumn.AdvancedSearch.SearchOperator2 = filter["w_is_ShowGridColumn"];
                is_ShowGridColumn.AdvancedSearch.Save();
            }

            // Field rowIndex
            if (filter?.TryGetValue("x_rowIndex", out sv) ?? false) {
                rowIndex.AdvancedSearch.SearchValue = sv;
                rowIndex.AdvancedSearch.SearchOperator = filter["z_rowIndex"];
                rowIndex.AdvancedSearch.SearchCondition = filter["v_rowIndex"];
                rowIndex.AdvancedSearch.SearchValue2 = filter["y_rowIndex"];
                rowIndex.AdvancedSearch.SearchOperator2 = filter["w_rowIndex"];
                rowIndex.AdvancedSearch.Save();
            }

            // Field is_ZoomMeet
            if (filter?.TryGetValue("x_is_ZoomMeet", out sv) ?? false) {
                is_ZoomMeet.AdvancedSearch.SearchValue = sv;
                is_ZoomMeet.AdvancedSearch.SearchOperator = filter["z_is_ZoomMeet"];
                is_ZoomMeet.AdvancedSearch.SearchCondition = filter["v_is_ZoomMeet"];
                is_ZoomMeet.AdvancedSearch.SearchValue2 = filter["y_is_ZoomMeet"];
                is_ZoomMeet.AdvancedSearch.SearchOperator2 = filter["w_is_ZoomMeet"];
                is_ZoomMeet.AdvancedSearch.Save();
            }

            // Field Classroom_Internal_Cr_Notes
            if (filter?.TryGetValue("x_Classroom_Internal_Cr_Notes", out sv) ?? false) {
                Classroom_Internal_Cr_Notes.AdvancedSearch.SearchValue = sv;
                Classroom_Internal_Cr_Notes.AdvancedSearch.SearchOperator = filter["z_Classroom_Internal_Cr_Notes"];
                Classroom_Internal_Cr_Notes.AdvancedSearch.SearchCondition = filter["v_Classroom_Internal_Cr_Notes"];
                Classroom_Internal_Cr_Notes.AdvancedSearch.SearchValue2 = filter["y_Classroom_Internal_Cr_Notes"];
                Classroom_Internal_Cr_Notes.AdvancedSearch.SearchOperator2 = filter["w_Classroom_Internal_Cr_Notes"];
                Classroom_Internal_Cr_Notes.AdvancedSearch.Save();
            }

            // Field BulkCR_Set
            if (filter?.TryGetValue("x_BulkCR_Set", out sv) ?? false) {
                BulkCR_Set.AdvancedSearch.SearchValue = sv;
                BulkCR_Set.AdvancedSearch.SearchOperator = filter["z_BulkCR_Set"];
                BulkCR_Set.AdvancedSearch.SearchCondition = filter["v_BulkCR_Set"];
                BulkCR_Set.AdvancedSearch.SearchValue2 = filter["y_BulkCR_Set"];
                BulkCR_Set.AdvancedSearch.SearchOperator2 = filter["w_BulkCR_Set"];
                BulkCR_Set.AdvancedSearch.Save();
            }

            // Field int_Day_Incremental
            if (filter?.TryGetValue("x_int_Day_Incremental", out sv) ?? false) {
                int_Day_Incremental.AdvancedSearch.SearchValue = sv;
                int_Day_Incremental.AdvancedSearch.SearchOperator = filter["z_int_Day_Incremental"];
                int_Day_Incremental.AdvancedSearch.SearchCondition = filter["v_int_Day_Incremental"];
                int_Day_Incremental.AdvancedSearch.SearchValue2 = filter["y_int_Day_Incremental"];
                int_Day_Incremental.AdvancedSearch.SearchOperator2 = filter["w_int_Day_Incremental"];
                int_Day_Incremental.AdvancedSearch.Save();
            }

            // Field int_Reoccurrence
            if (filter?.TryGetValue("x_int_Reoccurrence", out sv) ?? false) {
                int_Reoccurrence.AdvancedSearch.SearchValue = sv;
                int_Reoccurrence.AdvancedSearch.SearchOperator = filter["z_int_Reoccurrence"];
                int_Reoccurrence.AdvancedSearch.SearchCondition = filter["v_int_Reoccurrence"];
                int_Reoccurrence.AdvancedSearch.SearchValue2 = filter["y_int_Reoccurrence"];
                int_Reoccurrence.AdvancedSearch.SearchOperator2 = filter["w_int_Reoccurrence"];
                int_Reoccurrence.AdvancedSearch.Save();
            }

            // Field str_Username
            if (filter?.TryGetValue("x_str_Username", out sv) ?? false) {
                str_Username.AdvancedSearch.SearchValue = sv;
                str_Username.AdvancedSearch.SearchOperator = filter["z_str_Username"];
                str_Username.AdvancedSearch.SearchCondition = filter["v_str_Username"];
                str_Username.AdvancedSearch.SearchValue2 = filter["y_str_Username"];
                str_Username.AdvancedSearch.SearchOperator2 = filter["w_str_Username"];
                str_Username.AdvancedSearch.Save();
            }

            // Field Calendar_ID
            if (filter?.TryGetValue("x_Calendar_ID", out sv) ?? false) {
                Calendar_ID.AdvancedSearch.SearchValue = sv;
                Calendar_ID.AdvancedSearch.SearchOperator = filter["z_Calendar_ID"];
                Calendar_ID.AdvancedSearch.SearchCondition = filter["v_Calendar_ID"];
                Calendar_ID.AdvancedSearch.SearchValue2 = filter["y_Calendar_ID"];
                Calendar_ID.AdvancedSearch.SearchOperator2 = filter["w_Calendar_ID"];
                Calendar_ID.AdvancedSearch.Save();
            }

            // Field str_Package_Name
            if (filter?.TryGetValue("x_str_Package_Name", out sv) ?? false) {
                str_Package_Name.AdvancedSearch.SearchValue = sv;
                str_Package_Name.AdvancedSearch.SearchOperator = filter["z_str_Package_Name"];
                str_Package_Name.AdvancedSearch.SearchCondition = filter["v_str_Package_Name"];
                str_Package_Name.AdvancedSearch.SearchValue2 = filter["y_str_Package_Name"];
                str_Package_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Package_Name"];
                str_Package_Name.AdvancedSearch.Save();
            }

            // Field date_Start2
            if (filter?.TryGetValue("x_date_Start2", out sv) ?? false) {
                date_Start2.AdvancedSearch.SearchValue = sv;
                date_Start2.AdvancedSearch.SearchOperator = filter["z_date_Start2"];
                date_Start2.AdvancedSearch.SearchCondition = filter["v_date_Start2"];
                date_Start2.AdvancedSearch.SearchValue2 = filter["y_date_Start2"];
                date_Start2.AdvancedSearch.SearchOperator2 = filter["w_date_Start2"];
                date_Start2.AdvancedSearch.Save();
            }

            // Field date_Start3
            if (filter?.TryGetValue("x_date_Start3", out sv) ?? false) {
                date_Start3.AdvancedSearch.SearchValue = sv;
                date_Start3.AdvancedSearch.SearchOperator = filter["z_date_Start3"];
                date_Start3.AdvancedSearch.SearchCondition = filter["v_date_Start3"];
                date_Start3.AdvancedSearch.SearchValue2 = filter["y_date_Start3"];
                date_Start3.AdvancedSearch.SearchOperator2 = filter["w_date_Start3"];
                date_Start3.AdvancedSearch.Save();
            }

            // Field date_Start4
            if (filter?.TryGetValue("x_date_Start4", out sv) ?? false) {
                date_Start4.AdvancedSearch.SearchValue = sv;
                date_Start4.AdvancedSearch.SearchOperator = filter["z_date_Start4"];
                date_Start4.AdvancedSearch.SearchCondition = filter["v_date_Start4"];
                date_Start4.AdvancedSearch.SearchValue2 = filter["y_date_Start4"];
                date_Start4.AdvancedSearch.SearchOperator2 = filter["w_date_Start4"];
                date_Start4.AdvancedSearch.Save();
            }
            if (filter?.TryGetValue(Config.TableBasicSearch, out string? keyword) ?? false)
                BasicSearch.SessionKeyword = keyword;
            if (filter?.TryGetValue(Config.TableBasicSearchType, out string? type) ?? false)
                BasicSearch.SessionType = type;
            return true;
        }

        // Show list of filters
        public void ShowFilterList()
        {
            // Initialize
            string filterList = "",
                captionClass = IsExport("email") ? "ew-filter-caption-email" : "ew-filter-caption",
                captionSuffix = IsExport("email") ? ": " : "";
            if (!Empty(BasicSearch.Keyword))
                filterList += "<div><span class=\"" + captionClass + "\">" + Language.Phrase("BasicSearchKeyword") + "</span>" + captionSuffix + BasicSearch.Keyword + "</div>";

            // Show Filters
            if (!Empty(filterList)) {
                string message = "<div id=\"ew-filter-list\" class=\"callout callout-info d-table\"><div id=\"ew-current-filters\">" +
                    Language.Phrase("CurrentFilters") + "</div>" + filterList + "</div>";
                MessageShowing(ref message, "");
                Write(message);
            } else { // Output empty tag
                Write("<div id=\"ew-filter-list\"></div>");
            }
        }

        // Return basic search WHERE clause based on search keyword and type
        public string BasicSearchWhere(bool def = false) {
            string searchStr = "";
            if (!Security.CanSearch)
                return "";

            // Fields to search
            List<DbField> searchFlds = new ();
            searchFlds.Add(str_CR_Number);
            searchFlds.Add(str_CR_Days);
            searchFlds.Add(str_CR_Notes);
            searchFlds.Add(str_WebDesc);
            searchFlds.Add(rowIndex);
            searchFlds.Add(Classroom_Internal_Cr_Notes);
            searchFlds.Add(BulkCR_Set);
            searchFlds.Add(str_Username);
            searchFlds.Add(str_Package_Name);
            string searchKeyword = def ? BasicSearch.KeywordDefault : BasicSearch.Keyword;
            string searchType = def ? BasicSearch.TypeDefault : BasicSearch.Type;

            // Get search SQL
            if (!Empty(searchKeyword)) {
                List<string> list = BasicSearch.KeywordList(def);
                searchStr = GetQuickSearchFilter(searchFlds, list, searchType, BasicSearch.BasicSearchAnyFields, DbId);
                if (!def && (new[] {"", "reset", "resetall"}).Contains(Command))
                    Command = "search";
            }
            if (!def && Command == "search") {
                BasicSearch.SessionKeyword = searchKeyword;
                BasicSearch.SessionType = searchType;

                // Clear rules for QueryBuilder
                SessionRules = "";
            }
            return searchStr;
        }

        // Check if search parm exists
        protected bool CheckSearchParms() {
            // Check basic search
            if (BasicSearch.IssetSession)
                return true;
            return false;
        }

        // Clear all search parameters
        protected void ResetSearchParms() {
            SearchWhere = "";
            SessionSearchWhere = SearchWhere;

            // Clear basic search parameters
            ResetBasicSearchParms();

            // Clear queryBuilder
            SessionRules = "";
        }

        // Load advanced search default values
        protected bool LoadAdvancedSearchDefault() {
        return false;
        }

        // Clear all basic search parameters
        protected void ResetBasicSearchParms() {
            BasicSearch.UnsetSession();
        }

        // Restore all search parameters
        protected void RestoreSearchParms() {
            RestoreSearch = true;

            // Restore basic search values
            BasicSearch.Load();
        }

        // Set up sort parameters
        protected void SetupSortOrder() {
            // Load default Sorting Order
            if (Command != "json") {
                string defaultSort = ""; // Set up default sort
                if (Empty(SessionOrderBy) && !Empty(defaultSort))
                    SessionOrderBy = defaultSort;
            }

            // Check for Ctrl pressed
            bool ctrl = Get<bool>("ctrl");

            // Check for "order" parameter
            if (Get("order", out StringValues sv)) {
                CurrentOrder = sv.ToString();
                CurrentOrderType = Get("ordertype");
                UpdateSort(int_CR_ID, ctrl); // int_CR_ID
                UpdateSort(int_CR_Product_ID, ctrl); // int_CR_Product_ID
                UpdateSort(str_CR_Number, ctrl); // str_CR_Number
                UpdateSort(mon_CR_Price, ctrl); // mon_CR_Price
                UpdateSort(int_CR_Size, ctrl); // int_CR_Size
                UpdateSort(int_MU_Size, ctrl); // int_MU_Size
                UpdateSort(int_CR_Status, ctrl); // int_CR_Status
                UpdateSort(Is_Web_SignUp, ctrl); // Is_Web_SignUp
                UpdateSort(int_Location_ID, ctrl); // int_Location_ID
                UpdateSort(int_Teacher_ID, ctrl); // int_Teacher_ID
                UpdateSort(date_Start, ctrl); // date_Start
                UpdateSort(int_TotSession, ctrl); // int_TotSession
                UpdateSort(int_PerDaySession, ctrl); // int_PerDaySession
                UpdateSort(str_CR_Days, ctrl); // str_CR_Days
                UpdateSort(str_CR_Notes, ctrl); // str_CR_Notes
                UpdateSort(int_Created_By, ctrl); // int_Created_By
                UpdateSort(int_Modified_By, ctrl); // int_Modified_By
                UpdateSort(date_Created, ctrl); // date_Created
                UpdateSort(date_Modified, ctrl); // date_Modified
                UpdateSort(bit_IsDeleted, ctrl); // bit_IsDeleted
                UpdateSort(bit_AllTeacher, ctrl); // bit_AllTeacher
                UpdateSort(int_Manual_Change, ctrl); // int_Manual_Change
                UpdateSort(str_WebDesc, ctrl); // str_WebDesc
                UpdateSort(is_Show, ctrl); // is_Show
                UpdateSort(is_ShowGridColumn, ctrl); // is_ShowGridColumn
                UpdateSort(rowIndex, ctrl); // rowIndex
                UpdateSort(is_ZoomMeet, ctrl); // is_ZoomMeet
                UpdateSort(BulkCR_Set, ctrl); // BulkCR_Set
                UpdateSort(int_Day_Incremental, ctrl); // int_Day_Incremental
                UpdateSort(int_Reoccurrence, ctrl); // int_Reoccurrence
                UpdateSort(str_Username, ctrl); // str_Username
                UpdateSort(Calendar_ID, ctrl); // Calendar_ID
                UpdateSort(str_Package_Name, ctrl); // str_Package_Name
                UpdateSort(date_Start2, ctrl); // date_Start2
                UpdateSort(date_Start3, ctrl); // date_Start3
                UpdateSort(date_Start4, ctrl); // date_Start4
                StartRecordNumber = 1; // Reset start position
            }

            // Update field sort
            UpdateFieldSort();
        }

        /// <summary>
        /// Reset command
        /// cmd=reset (Reset search parameters)
        /// cmd=resetall (Reset search and master/detail parameters)
        /// cmd=resetsort (Reset sort parameters)
        /// </summary>
        protected void ResetCommand() {
            // Get reset cmd
            if (Command.ToLower().StartsWith("reset")) {
                // Reset search criteria
                if (SameText(Command, "reset") || SameText(Command, "resetall"))
                    ResetSearchParms();

                // Reset (clear) sorting order
                if (SameText(Command, "resetsort")) {
                    string orderBy = "";
                    SessionOrderBy = orderBy;
                    int_CR_ID.Sort = "";
                    int_CR_Product_ID.Sort = "";
                    str_CR_Number.Sort = "";
                    mon_CR_Price.Sort = "";
                    int_CR_Size.Sort = "";
                    int_MU_Size.Sort = "";
                    int_CR_Status.Sort = "";
                    Is_Web_SignUp.Sort = "";
                    int_Location_ID.Sort = "";
                    int_Teacher_ID.Sort = "";
                    date_Start.Sort = "";
                    int_TotSession.Sort = "";
                    int_PerDaySession.Sort = "";
                    str_CR_Days.Sort = "";
                    str_CR_Notes.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    bit_IsDeleted.Sort = "";
                    bit_AllTeacher.Sort = "";
                    int_Manual_Change.Sort = "";
                    str_WebDesc.Sort = "";
                    is_Show.Sort = "";
                    is_ShowGridColumn.Sort = "";
                    rowIndex.Sort = "";
                    is_ZoomMeet.Sort = "";
                    Classroom_Internal_Cr_Notes.Sort = "";
                    BulkCR_Set.Sort = "";
                    int_Day_Incremental.Sort = "";
                    int_Reoccurrence.Sort = "";
                    str_Username.Sort = "";
                    Calendar_ID.Sort = "";
                    str_Package_Name.Sort = "";
                    date_Start2.Sort = "";
                    date_Start3.Sort = "";
                    date_Start4.Sort = "";
                }

                // Reset start position
                StartRecord = 1;
                StartRecordNumber = StartRecord;
            }
        }

        #pragma warning disable 1998
        // Set up list options
        protected async Task SetupListOptions() {
            ListOption item;
            MultiColumnLayout = Param(Config.PageLayout);
            if (Config.PageLayouts.Contains(MultiColumnLayout))
                SessionLayout = MultiColumnLayout;
            else
                MultiColumnLayout = !Empty(SessionLayout) ? SessionLayout : "cards";

            // Add group option item
            item = ListOptions.AddGroupOption();
            item.Body = "";
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.Visible = false;

            // List actions
            item = ListOptions.Add("listactions");
            item.CssClass = "text-nowrap";
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.Visible = false;
            item.ShowInButtonGroup = false;
            item.ShowInDropDown = false;

            // "checkbox"
            item = ListOptions.Add("checkbox");
            item.CssStyle = "white-space: nowrap; text-align: center; vertical-align: middle; margin: 0px;";
            item.Visible = false;
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.Header = "<div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\"></div>";
            if (item.OnLeft)
                item.MoveTo(0);
            item.ShowInDropDown = false;
            item.ShowInButtonGroup = false;

            // Drop down button for ListOptions
            ListOptions.UseDropDownButton = false;
            if (MultiColumnLayout == "cards") { // Multi column layout
                ListOptions.DropDownButtonPhrase = "ButtonListOptionsCard";
                ListOptions.TagClassName = "ew-multi-column-list-option-card m-1";
            } else {
                ListOptions.DropDownButtonPhrase = "ButtonListOptions";
                ListOptions.TagClassName = "ew-multi-column-list-option-table";
            }
            ListOptions.UseButtonGroup = false;
            if (ListOptions.UseButtonGroup && IsMobile())
                ListOptions.UseDropDownButton = true;

            //ListOptions.ButtonClass = ""; // Class for button group

            // Call ListOptions Load event
            ListOptionsLoad();
            SetupListOptionsExt();
            ListOptions[ListOptions.GroupOptionName]?.SetVisible(ListOptions.GroupOptionVisible);
        }
        #pragma warning restore 1998

        // Set up list options (extensions)
        protected void SetupListOptionsExt() {
            // Preview extension
            ListOptions.HideDetailItemsForDropDown(); // Hide detail items for dropdown if necessary
        }

        // Add "hash" parameter to URL
        public string UrlAddHash(string url, string hash)
        {
            return UseAjaxActions ? url : UrlAddQuery(url, "hash=" + hash);
        }

        // Render list options
        #pragma warning disable 168, 219, 1998

        public async Task RenderListOptions()
        {
            ListOption? listOption;
            bool isVisible = false; // DN
            ListOptions.LoadDefault();

            // Call ListOptions Rendering event
            ListOptionsRendering();

            // Set up list action buttons
            listOption = ListOptions["listactions"];
            if (listOption != null && !IsExport() && CurrentAction == "") {
                string body = "";
                var links = new List<string>();
                foreach (var (key, act) in ListActions.Items) {
                    if (act.Select == Config.ActionSingle && act.Allowed) {
                        var action = act.Action;
                        string caption = act.Caption;
                        var icon = (act.Icon != "") ? "<i class=\"" + HtmlEncode(act.Icon.Replace(" ew-icon", "")) + "\" data-caption=\"" + HtmlTitle(caption) + "\"></i> " : "";
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"fqryClassRoomListlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"fqryClassRoomListlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
                        }
                    }
                }
                if (links.Count > 1) { // More than one buttons, use dropdown
                    body = "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-actions\" title=\"" + Language.Phrase("ListActionButton", true) + "\" data-bs-toggle=\"dropdown\">" + Language.Phrase("ListActionButton") + "</button>";
                    string content = links.Aggregate("", (result, link) => result + "<li>" + link + "</li>");
                    body += "<ul class=\"dropdown-menu" + (listOption?.OnLeft ?? false ? "" : " dropdown-menu-right") + "\">" + content + "</ul>";
                    body = "<div class=\"btn-group btn-group-sm\">" + body + "</div>";
                }
                if (links.Count > 0)
                    listOption?.SetBody(body);
            }

            // "checkbox"
            listOption = ListOptions["checkbox"];
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(int_CR_ID.CurrentValue) + "\"></div>");
            RenderListOptionsExt();

            // Call ListOptions Rendered event
            ListOptionsRendered();
        }

        // Render list options (extensions)
        protected void RenderListOptionsExt() {
            // Render list options (to be implemented by extensions)
        }

        // Set up other options
        protected void SetupOtherOptions() {
            ListOptions option;
            ListOption item;
            var options = OtherOptions;
            option = options["action"];

            // Set up layout buttons/select all checkbox for multi column list page
            item = LayoutOptions.Add("cards");
            string classname = MultiColumnLayout == "cards" ? " disabled" : "";
            item.Body = "<button type=\"button\" class=\"btn btn-default " + classname + "\" title=\"" + Language.Phrase("MultiColumnCards", true) + "\" data-ew-action=\"layout\" data-layout=\"cards\" data-url=\"" + PageUrl + "\">" + Language.Phrase("MultiColumnCards") + "</button>";
            item.Visible = true;
            item = LayoutOptions.Add("table");
            classname = MultiColumnLayout == "table" ? " disabled" : "";
            item.Body = "<button type=\"button\" class=\"btn btn-default " + classname + "\" title=\"" + Language.Phrase("MultiColumnTable", true) + "\" data-ew-action=\"layout\" data-layout=\"table\" data-url=\"" + PageUrl + "\">" + Language.Phrase("MultiColumnTable") + "</button>";
            item.Visible = true;
            item = LayoutOptions.Add("checkbox");
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"fqryClassRoomListlist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
            item.ShowInButtonGroup = true;
            item.Visible = false && MultiColumnLayout == "cards";
            LayoutOptions.AddGroupOption();
            LayoutOptions.UseDropDownButton = false;
            LayoutOptions.UseButtonGroup = true;
            if (IsExport("print") || IsModal)
                LayoutOptions.HideAllOptions();

            // Set up options default
            foreach (var (key, opt) in options) {
                if (key != "column") { // Always use dropdown for column
                    opt.UseDropDownButton = true;
                    opt.UseButtonGroup = true;
                }
                //opt.ButtonClass = ""; // Class for button group
                item = opt.AddGroupOption();
                item.Body = "";
                item.Visible = false;
            }
            options["addedit"].DropDownButtonPhrase = "ButtonAddEdit";
            options["detail"].DropDownButtonPhrase = "ButtonDetails";
            options["action"].DropDownButtonPhrase = "ButtonActions";

            // Filter button
            item = FilterOptions.Add("savecurrentfilter");
            item.Body = "<a class=\"ew-save-filter\" data-form=\"fqryClassRoomListsrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"fqryClassRoomListsrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
            item.Visible = true;
            FilterOptions.UseDropDownButton = true;
            FilterOptions.UseButtonGroup = !FilterOptions.UseDropDownButton;
            FilterOptions.DropDownButtonPhrase = "Filters";

            // Add group option item
            item = FilterOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;
        }

        // Create new column option // DN
        public void CreateColumnOption(ListOption item)
        {
            var field = FieldByName(item.Name);
            if (field?.Visible ?? false) {
                item.Body = "<button class=\"dropdown-item\">" +
                    "<div class=\"form-check ew-dropdown-checkbox\">" +
                    "<div class=\"form-check-input ew-dropdown-check-input\" data-field=\"" + field.Param + "\"></div>" +
                    "<label class=\"form-check-label ew-dropdown-check-label\">" + field.Caption + "</label></div></button>";
            }
        }

        // Render other options
        public void RenderOtherOptions()
        {
            ListOptions option;
            ListOption? item;
            var options = OtherOptions;
                option = options["action"];

                // Set up list action buttons
                foreach (var (key, act) in ListActions.Items.Where(kvp => kvp.Value.Select == Config.ActionMultiple)) {
                    item = option.Add("custom_" + act.Action);
                    string caption = act.Caption;
                    var icon = (act.Icon != "") ? "<i class=\"" + HtmlEncode(act.Icon) + "\" data-caption=\"" + HtmlEncode(caption) + "\"></i>" + caption : caption;
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"fqryClassRoomListlist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
                    item.Visible = act.Allowed;
                }

                // Hide multi edit, grid edit and other options
                if (TotalRecords <= 0) {
                    option = options["addedit"];
                    option?["gridedit"]?.SetVisible(false);
                    option = options["action"];
                    option.HideAllOptions();
                }
        }

        // Process list action
        public async Task<IActionResult> ProcessListAction()
        {
            string filter = GetFilterFromRecordKeys();
            string userAction = Post("action");
            if (filter != "" && userAction != "") {
                // Check permission first
                string actionCaption = userAction;
                foreach (var (key, act) in ListActions.Items) {
                    if (SameString(key, userAction)) {
                        actionCaption = act.Caption;
                        if (CustomActions.ContainsKey(userAction)) {
                            UserAction = userAction;
                            CurrentAction = "";
                        }
                        if (!act.Allowed) {
                            string errmsg = Language.Phrase("CustomActionNotAllowed").Replace("%s", actionCaption);
                            if (Post("ajax") == userAction) // Ajax
                                return Controller.Content("<p class=\"text-danger\">" + errmsg + "</p>", "text/plain", Encoding.UTF8);
                            else
                                FailureMessage = errmsg;
                            return new EmptyResult();
                        }
                    }
                }
                CurrentFilter = filter;
                string sql = CurrentSql;
                var rsuser = await Connection.GetRowsAsync(sql);
                ActionValue = Post("actionvalue");

                // Call row custom action event
                if (rsuser != null) {
                    if (UseTransaction)
                        Connection.BeginTrans();
                    bool processed = true;
                    SelectedCount = rsuser.Count();
                    SelectedIndex = 0;
                    foreach (var row in rsuser) {
                        SelectedIndex++;
                        processed = RowCustomAction(userAction, row);
                        if (!processed)
                            break;
                    }
                    if (processed) {
                        if (UseTransaction)
                            Connection.CommitTrans(); // Commit the changes
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("CustomActionCompleted").Replace("%s", actionCaption); // Set up success message
                    } else {
                        if (UseTransaction)
                            Connection.RollbackTrans(); // Rollback changes

                        // Set up error message
                        if (!Empty(SuccessMessage) || !Empty(FailureMessage)) {
                            // Use the message, do nothing
                        } else if (!Empty(CancelMessage)) {
                            FailureMessage = CancelMessage;
                            CancelMessage = "";
                        } else {
                            FailureMessage = Language.Phrase("CustomActionFailed").Replace("%s", actionCaption);
                        }
                    }
                }
                CurrentAction = ""; // Clear action
                if (Post("ajax") == userAction) { // Ajax
                    if (ActionResult != null) // Action result set by Row CustomAction event // DN
                        return ActionResult;
                    string msg = "";
                    if (SuccessMessage != "") {
                        msg = "<p class=\"text-success\">" + SuccessMessage + "</p>";
                        ClearSuccessMessage(); // Clear message
                    }
                    if (FailureMessage != "") {
                        msg = "<p class=\"text-danger\">" + FailureMessage + "</p>";
                        ClearFailureMessage(); // Clear message
                    }
                    if (!Empty(msg))
                        return Controller.Content(msg, "text/plain", Encoding.UTF8);
                }
            }
            return new EmptyResult(); // Not ajax request
        }

        // Get multi-column row CSS class
        public string GetMultiColumnRowClass()
        {
            if (IsAddOrEdit && (RowType == RowType.Add || RowType == RowType.Edit))
                return "row"; // Full row
            return "row row-cols-1 " + MultiColumnGridClass + " g-4 ew-multi-column-row";
        }

        // Get multi-column col-* CSS class
        public string GetMultiColumnColClass()
        {
            if (IsAddOrEdit && (RowType == RowType.Add || RowType == RowType.Edit))
                return MultiColumnEditClass; // Full row
            return "col";
        }

        // Set up Grid
        public async Task SetupGrid()
        {
            if (ExportAll && IsExport()) {
                StopRecord = TotalRecords;
            } else {
                // Set the last record to display
                if (TotalRecords > StartRecord + DisplayRecords - 1) {
                    StopRecord = StartRecord + DisplayRecords - 1;
                } else {
                    StopRecord = TotalRecords;
                }
            }
            if (Recordset != null && Recordset.HasRows) {
                if (!Connection.SelectOffset) { // DN
                    for (int i = 1; i <= StartRecord - 1; i++) { // Move to first record
                        if (await Recordset.ReadAsync())
                            RecordCount++;
                    }
                } else {
                    RecordCount = StartRecord - 1;
                }
            } else if (IsGridAdd && !AllowAddDeleteRow && StopRecord == 0) { // Grid-Add with no records
                StopRecord = GridAddRowCount;
            } else if (IsAdd && TotalRecords == 0) { // Inline-Add with no records
                StopRecord = 1;
            }

            // Initialize aggregate
            RowType = RowType.AggregateInit;
            ResetAttributes();
            await RenderRow();
            if ((IsGridAdd || IsGridEdit) && MultiColumnLayout == "table") // Render template row first
                RowIndex = "$rowindex$";
        }

        // Set up Row
        public async Task SetupRow()
        {
            if (IsGridAdd || IsGridEdit) {
                if (SameString(RowIndex, "$rowindex$")) { // Render template row first
                    await LoadRowValues();

                    // Set row properties
                    ResetAttributes();
                    RowAttrs.Add("data-rowindex", ConvertToString(RowIndex));
                    RowAttrs.Add("id", "r0_qryClassRoomList");
                    RowAttrs.Add("data-rowtype", ConvertToString((int)RowType.Add));
                    RowAttrs.Add("data-inline", (IsAdd || IsCopy || IsEdit) ? "true" : "false");
                    RowAttrs.AppendClass("ew-template");

                    // Render row
                    RowType = RowType.Add;
                    await RenderRow();

                    // Render list options
                    await RenderListOptions();

                    // Reset record count for template row
                    RecordCount--;
                    return;
                }
            }

            // Set up key count
            KeyCount = ConvertToInt(RowIndex);

            // Init row class and style
            ResetAttributes();
            CssClass = "";
            if (IsCopy && InlineRowCount == 0 && !await LoadRow()) { // Inline copy
                CurrentAction = "add";
            }
            if (IsAdd && InlineRowCount == 0 || IsGridAdd) {
                await LoadRowValues(); // Load default values
                OldKey = "";
                SetKey(OldKey);
            } else if (IsInlineInserted && UseInfiniteScroll) {
                // Nothing to do, just use current values
            } else if (!(IsCopy && InlineRowCount == 0)) {
                await LoadRowValues(Recordset); // Load row values
                if (IsGridEdit || IsMultiEdit) {
                    OldKey = GetKey(true); // Get from CurrentValue
                    SetKey(OldKey);
                }
            }
            RowType = RowType.View; // Render view
            if ((IsAdd || IsCopy) && InlineRowCount == 0 || IsGridAdd) // Add
                RowType = RowType.Add; // Render add

            // Inline Add/Copy row (row 0)
            if (RowType == RowType.Add && (IsAdd || IsCopy)) {
                InlineRowCount++;
                RecordCount--; // Reset record count for inline add/copy row
                if (TotalRecords == 0) // Reset stop record if no records
                    StopRecord = 0;
            } else {
                // Inline Edit row
                if (RowType == RowType.Edit && IsEdit)
                    InlineRowCount++;
                RowCount++; // Increment row count
            }

            // Set up row attributes
            RowAttrs.Add("data-rowindex", ConvertToString(qryClassRoomListList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(qryClassRoomListList.RowCount) + "_qryClassRoomList");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(qryClassRoomListList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && qryClassRoomListList.RowType == RowType.Add || IsEdit && qryClassRoomListList.RowType == RowType.Edit) // Inline-Add/Edit row
                RowAttrs.AppendClass("table-active");

            // Render row
            await RenderRow();

            // Render list options
            await RenderListOptions();
        }

        // Load basic search values // DN
        protected void LoadBasicSearchValues() {
            if (Get(Config.TableBasicSearch, out StringValues keyword))
                BasicSearch.Keyword = keyword.ToString();
            if (!Empty(BasicSearch.Keyword) && Empty(Command))
                Command = "search";
            if (Get(Config.TableBasicSearchType, out StringValues type))
                BasicSearch.Type = type.ToString();
        }

        // Load recordset // DN
        public async Task<DbDataReader?> LoadRecordset(int offset = -1, int rowcnt = -1)
        {
            // Load list page SQL
            string sql = ListSql;

            // Load recordset // DN
            var dr = await Connection.SelectLimit(sql, rowcnt, offset, !Empty(OrderBy) || !Empty(SessionOrderBy));

            // Call Recordset Selected event
            RecordsetSelected(dr);
            return dr;
        }

        // Load rows // DN
        public async Task<List<Dictionary<string, object>>> LoadRows(int offset = -1, int rowcnt = -1)
        {
            // Load list page SQL
            string sql = ListSql;

            // Load rows // DN
            using var dr = await Connection.SelectLimit(sql, rowcnt, offset, !Empty(OrderBy) || !Empty(SessionOrderBy));
            var rows = await Connection.GetRowsAsync(dr);
            dr.Close(); // Close datareader before return
            return rows;
        }

        // Load row based on key values
        public async Task<bool> LoadRow()
        {
            string filter = GetRecordFilter();

            // Call Row Selecting event
            RowSelecting(ref filter);

            // Load SQL based on filter
            CurrentFilter = filter;
            string sql = CurrentSql;
            bool res = false;
            try {
                var row = await Connection.GetRowAsync(sql);
                if (row != null) {
                    await LoadRowValues(row);
                    res = true;
                } else {
                    return false;
                }
            } catch {
                if (Config.Debug)
                    throw;
            }
            return res;
        }

        #pragma warning disable 162, 168, 1998, 4014
        // Load row values from data reader
        public async Task LoadRowValues(DbDataReader? dr = null) => await LoadRowValues(GetDictionary(dr));

        // Load row values from recordset
        public async Task LoadRowValues(Dictionary<string, object>? row)
        {
            row ??= NewRow();

            // Call Row Selected event
            RowSelected(row);
            int_CR_ID.SetDbValue(row["int_CR_ID"]);
            int_CR_Product_ID.SetDbValue(row["int_CR_Product_ID"]);
            str_CR_Number.SetDbValue(row["str_CR_Number"]);
            mon_CR_Price.SetDbValue(row["mon_CR_Price"]);
            int_CR_Size.SetDbValue(row["int_CR_Size"]);
            int_MU_Size.SetDbValue(row["int_MU_Size"]);
            int_CR_Status.SetDbValue(row["int_CR_Status"]);
            Is_Web_SignUp.SetDbValue((ConvertToBool(row["Is_Web_SignUp"]) ? "1" : "0"));
            int_Location_ID.SetDbValue(row["int_Location_ID"]);
            int_Teacher_ID.SetDbValue(row["int_Teacher_ID"]);
            date_Start.SetDbValue(row["date_Start"]);
            int_TotSession.SetDbValue(row["int_TotSession"]);
            int_PerDaySession.SetDbValue(row["int_PerDaySession"]);
            str_CR_Days.SetDbValue(row["str_CR_Days"]);
            str_CR_Notes.SetDbValue(row["str_CR_Notes"]);
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            bit_AllTeacher.SetDbValue((ConvertToBool(row["bit_AllTeacher"]) ? "1" : "0"));
            int_Manual_Change.SetDbValue(row["int_Manual_Change"]);
            str_WebDesc.SetDbValue(row["str_WebDesc"]);
            is_Show.SetDbValue((ConvertToBool(row["is_Show"]) ? "1" : "0"));
            is_ShowGridColumn.SetDbValue((ConvertToBool(row["is_ShowGridColumn"]) ? "1" : "0"));
            rowIndex.SetDbValue(row["rowIndex"]);
            is_ZoomMeet.SetDbValue((ConvertToBool(row["is_ZoomMeet"]) ? "1" : "0"));
            Classroom_Internal_Cr_Notes.SetDbValue(row["Classroom_Internal_Cr_Notes"]);
            BulkCR_Set.SetDbValue(row["BulkCR_Set"]);
            int_Day_Incremental.SetDbValue(row["int_Day_Incremental"]);
            int_Reoccurrence.SetDbValue(row["int_Reoccurrence"]);
            str_Username.SetDbValue(row["str_Username"]);
            Calendar_ID.SetDbValue(row["Calendar_ID"]);
            str_Package_Name.SetDbValue(row["str_Package_Name"]);
            date_Start2.SetDbValue(row["date_Start2"]);
            date_Start3.SetDbValue(row["date_Start3"]);
            date_Start4.SetDbValue(row["date_Start4"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_CR_ID", int_CR_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Product_ID", int_CR_Product_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Number", str_CR_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("mon_CR_Price", mon_CR_Price.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Size", int_CR_Size.DefaultValue ?? DbNullValue); // DN
            row.Add("int_MU_Size", int_MU_Size.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Status", int_CR_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("Is_Web_SignUp", Is_Web_SignUp.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_ID", int_Location_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Teacher_ID", int_Teacher_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start", date_Start.DefaultValue ?? DbNullValue); // DN
            row.Add("int_TotSession", int_TotSession.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PerDaySession", int_PerDaySession.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Days", str_CR_Days.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Notes", str_CR_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_AllTeacher", bit_AllTeacher.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Manual_Change", int_Manual_Change.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebDesc", str_WebDesc.DefaultValue ?? DbNullValue); // DN
            row.Add("is_Show", is_Show.DefaultValue ?? DbNullValue); // DN
            row.Add("is_ShowGridColumn", is_ShowGridColumn.DefaultValue ?? DbNullValue); // DN
            row.Add("rowIndex", rowIndex.DefaultValue ?? DbNullValue); // DN
            row.Add("is_ZoomMeet", is_ZoomMeet.DefaultValue ?? DbNullValue); // DN
            row.Add("Classroom_Internal_Cr_Notes", Classroom_Internal_Cr_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("BulkCR_Set", BulkCR_Set.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Day_Incremental", int_Day_Incremental.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Reoccurrence", int_Reoccurrence.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("Calendar_ID", Calendar_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Package_Name", str_Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start2", date_Start2.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start3", date_Start3.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start4", date_Start4.DefaultValue ?? DbNullValue); // DN
            return row;
        }

        #pragma warning disable 618, 1998
        // Load old record
        protected async Task<Dictionary<string, object>?> LoadOldRecord(DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType>? cnn = null) {
            // Load old record
            Dictionary<string, object>? row = null;
            bool validKey = !Empty(OldKey);
            if (validKey) {
                SetKey(OldKey);
                CurrentFilter = GetRecordFilter();
                string sql = CurrentSql;
                try {
                    row = await (cnn ?? Connection).GetRowAsync(sql);
                } catch {
                    row = null;
                }
            }
            await LoadRowValues(row); // Load row values
            return row;
        }
        #pragma warning restore 618, 1998

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_CR_ID

            // int_CR_Product_ID

            // str_CR_Number

            // mon_CR_Price

            // int_CR_Size

            // int_MU_Size

            // int_CR_Status

            // Is_Web_SignUp

            // int_Location_ID

            // int_Teacher_ID

            // date_Start

            // int_TotSession

            // int_PerDaySession

            // str_CR_Days

            // str_CR_Notes

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // bit_AllTeacher

            // int_Manual_Change

            // str_WebDesc

            // is_Show

            // is_ShowGridColumn

            // rowIndex

            // is_ZoomMeet

            // Classroom_Internal_Cr_Notes

            // BulkCR_Set

            // int_Day_Incremental

            // int_Reoccurrence

            // str_Username

            // Calendar_ID

            // str_Package_Name

            // date_Start2

            // date_Start3

            // date_Start4

            // View row
            if (RowType == RowType.View) {
                // int_CR_ID
                int_CR_ID.ViewValue = int_CR_ID.CurrentValue;
                int_CR_ID.ViewCustomAttributes = "";

                // int_CR_Product_ID
                int_CR_Product_ID.ViewValue = int_CR_Product_ID.CurrentValue;
                int_CR_Product_ID.ViewValue = FormatNumber(int_CR_Product_ID.ViewValue, int_CR_Product_ID.FormatPattern);
                int_CR_Product_ID.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.ViewValue = ConvertToString(str_CR_Number.CurrentValue); // DN
                str_CR_Number.ViewCustomAttributes = "";

                // mon_CR_Price
                mon_CR_Price.ViewValue = mon_CR_Price.CurrentValue;
                mon_CR_Price.ViewValue = FormatNumber(mon_CR_Price.ViewValue, mon_CR_Price.FormatPattern);
                mon_CR_Price.ViewCustomAttributes = "";

                // int_CR_Size
                int_CR_Size.ViewValue = int_CR_Size.CurrentValue;
                int_CR_Size.ViewValue = FormatNumber(int_CR_Size.ViewValue, int_CR_Size.FormatPattern);
                int_CR_Size.ViewCustomAttributes = "";

                // int_MU_Size
                int_MU_Size.ViewValue = int_MU_Size.CurrentValue;
                int_MU_Size.ViewValue = FormatNumber(int_MU_Size.ViewValue, int_MU_Size.FormatPattern);
                int_MU_Size.ViewCustomAttributes = "";

                // int_CR_Status
                int_CR_Status.ViewValue = int_CR_Status.CurrentValue;
                int_CR_Status.ViewValue = FormatNumber(int_CR_Status.ViewValue, int_CR_Status.FormatPattern);
                int_CR_Status.ViewCustomAttributes = "";

                // Is_Web_SignUp
                if (ConvertToBool(Is_Web_SignUp.CurrentValue)) {
                    Is_Web_SignUp.ViewValue = Is_Web_SignUp.TagCaption(1) != "" ? Is_Web_SignUp.TagCaption(1) : "Yes";
                } else {
                    Is_Web_SignUp.ViewValue = Is_Web_SignUp.TagCaption(2) != "" ? Is_Web_SignUp.TagCaption(2) : "No";
                }
                Is_Web_SignUp.ViewCustomAttributes = "";

                // int_Location_ID
                int_Location_ID.ViewValue = int_Location_ID.CurrentValue;
                int_Location_ID.ViewValue = FormatNumber(int_Location_ID.ViewValue, int_Location_ID.FormatPattern);
                int_Location_ID.ViewCustomAttributes = "";

                // int_Teacher_ID
                int_Teacher_ID.ViewValue = int_Teacher_ID.CurrentValue;
                int_Teacher_ID.ViewValue = FormatNumber(int_Teacher_ID.ViewValue, int_Teacher_ID.FormatPattern);
                int_Teacher_ID.ViewCustomAttributes = "";

                // date_Start
                date_Start.ViewValue = date_Start.CurrentValue;
                date_Start.ViewValue = FormatDateTime(date_Start.ViewValue, date_Start.FormatPattern);
                date_Start.ViewCustomAttributes = "";

                // int_TotSession
                int_TotSession.ViewValue = int_TotSession.CurrentValue;
                int_TotSession.ViewValue = FormatNumber(int_TotSession.ViewValue, int_TotSession.FormatPattern);
                int_TotSession.ViewCustomAttributes = "";

                // int_PerDaySession
                int_PerDaySession.ViewValue = int_PerDaySession.CurrentValue;
                int_PerDaySession.ViewValue = FormatNumber(int_PerDaySession.ViewValue, int_PerDaySession.FormatPattern);
                int_PerDaySession.ViewCustomAttributes = "";

                // str_CR_Days
                str_CR_Days.ViewValue = ConvertToString(str_CR_Days.CurrentValue); // DN
                str_CR_Days.ViewCustomAttributes = "";

                // str_CR_Notes
                str_CR_Notes.ViewValue = ConvertToString(str_CR_Notes.CurrentValue); // DN
                str_CR_Notes.ViewCustomAttributes = "";

                // int_Created_By
                int_Created_By.ViewValue = int_Created_By.CurrentValue;
                int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
                int_Created_By.ViewCustomAttributes = "";

                // int_Modified_By
                int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
                int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
                int_Modified_By.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // date_Modified
                date_Modified.ViewValue = date_Modified.CurrentValue;
                date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
                date_Modified.ViewCustomAttributes = "";

                // bit_IsDeleted
                if (ConvertToBool(bit_IsDeleted.CurrentValue)) {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
                } else {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(2) != "" ? bit_IsDeleted.TagCaption(2) : "No";
                }
                bit_IsDeleted.ViewCustomAttributes = "";

                // bit_AllTeacher
                if (ConvertToBool(bit_AllTeacher.CurrentValue)) {
                    bit_AllTeacher.ViewValue = bit_AllTeacher.TagCaption(1) != "" ? bit_AllTeacher.TagCaption(1) : "Yes";
                } else {
                    bit_AllTeacher.ViewValue = bit_AllTeacher.TagCaption(2) != "" ? bit_AllTeacher.TagCaption(2) : "No";
                }
                bit_AllTeacher.ViewCustomAttributes = "";

                // int_Manual_Change
                int_Manual_Change.ViewValue = int_Manual_Change.CurrentValue;
                int_Manual_Change.ViewValue = FormatNumber(int_Manual_Change.ViewValue, int_Manual_Change.FormatPattern);
                int_Manual_Change.ViewCustomAttributes = "";

                // str_WebDesc
                str_WebDesc.ViewValue = ConvertToString(str_WebDesc.CurrentValue); // DN
                str_WebDesc.ViewCustomAttributes = "";

                // is_Show
                if (ConvertToBool(is_Show.CurrentValue)) {
                    is_Show.ViewValue = is_Show.TagCaption(1) != "" ? is_Show.TagCaption(1) : "Yes";
                } else {
                    is_Show.ViewValue = is_Show.TagCaption(2) != "" ? is_Show.TagCaption(2) : "No";
                }
                is_Show.ViewCustomAttributes = "";

                // is_ShowGridColumn
                if (ConvertToBool(is_ShowGridColumn.CurrentValue)) {
                    is_ShowGridColumn.ViewValue = is_ShowGridColumn.TagCaption(1) != "" ? is_ShowGridColumn.TagCaption(1) : "Yes";
                } else {
                    is_ShowGridColumn.ViewValue = is_ShowGridColumn.TagCaption(2) != "" ? is_ShowGridColumn.TagCaption(2) : "No";
                }
                is_ShowGridColumn.ViewCustomAttributes = "";

                // rowIndex
                rowIndex.ViewValue = ConvertToString(rowIndex.CurrentValue); // DN
                rowIndex.ViewCustomAttributes = "";

                // is_ZoomMeet
                if (ConvertToBool(is_ZoomMeet.CurrentValue)) {
                    is_ZoomMeet.ViewValue = is_ZoomMeet.TagCaption(1) != "" ? is_ZoomMeet.TagCaption(1) : "Yes";
                } else {
                    is_ZoomMeet.ViewValue = is_ZoomMeet.TagCaption(2) != "" ? is_ZoomMeet.TagCaption(2) : "No";
                }
                is_ZoomMeet.ViewCustomAttributes = "";

                // BulkCR_Set
                BulkCR_Set.ViewValue = ConvertToString(BulkCR_Set.CurrentValue); // DN
                BulkCR_Set.ViewCustomAttributes = "";

                // int_Day_Incremental
                int_Day_Incremental.ViewValue = int_Day_Incremental.CurrentValue;
                int_Day_Incremental.ViewValue = FormatNumber(int_Day_Incremental.ViewValue, int_Day_Incremental.FormatPattern);
                int_Day_Incremental.ViewCustomAttributes = "";

                // int_Reoccurrence
                int_Reoccurrence.ViewValue = int_Reoccurrence.CurrentValue;
                int_Reoccurrence.ViewValue = FormatNumber(int_Reoccurrence.ViewValue, int_Reoccurrence.FormatPattern);
                int_Reoccurrence.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // Calendar_ID
                Calendar_ID.ViewValue = Calendar_ID.CurrentValue;
                Calendar_ID.ViewValue = FormatNumber(Calendar_ID.ViewValue, Calendar_ID.FormatPattern);
                Calendar_ID.ViewCustomAttributes = "";

                // str_Package_Name
                str_Package_Name.ViewValue = ConvertToString(str_Package_Name.CurrentValue); // DN
                str_Package_Name.ViewCustomAttributes = "";

                // date_Start2
                date_Start2.ViewValue = date_Start2.CurrentValue;
                date_Start2.ViewValue = FormatDateTime(date_Start2.ViewValue, date_Start2.FormatPattern);
                date_Start2.ViewCustomAttributes = "";

                // date_Start3
                date_Start3.ViewValue = date_Start3.CurrentValue;
                date_Start3.ViewValue = FormatDateTime(date_Start3.ViewValue, date_Start3.FormatPattern);
                date_Start3.ViewCustomAttributes = "";

                // date_Start4
                date_Start4.ViewValue = date_Start4.CurrentValue;
                date_Start4.ViewValue = FormatDateTime(date_Start4.ViewValue, date_Start4.FormatPattern);
                date_Start4.ViewCustomAttributes = "";

                // int_CR_ID
                int_CR_ID.HrefValue = "";
                int_CR_ID.TooltipValue = "";

                // int_CR_Product_ID
                int_CR_Product_ID.HrefValue = "";
                int_CR_Product_ID.TooltipValue = "";

                // str_CR_Number
                str_CR_Number.HrefValue = "";
                str_CR_Number.TooltipValue = "";

                // mon_CR_Price
                mon_CR_Price.HrefValue = "";
                mon_CR_Price.TooltipValue = "";

                // int_CR_Size
                int_CR_Size.HrefValue = "";
                int_CR_Size.TooltipValue = "";

                // int_MU_Size
                int_MU_Size.HrefValue = "";
                int_MU_Size.TooltipValue = "";

                // int_CR_Status
                int_CR_Status.HrefValue = "";
                int_CR_Status.TooltipValue = "";

                // Is_Web_SignUp
                Is_Web_SignUp.HrefValue = "";
                Is_Web_SignUp.TooltipValue = "";

                // int_Location_ID
                int_Location_ID.HrefValue = "";
                int_Location_ID.TooltipValue = "";

                // int_Teacher_ID
                int_Teacher_ID.HrefValue = "";
                int_Teacher_ID.TooltipValue = "";

                // date_Start
                date_Start.HrefValue = "";
                date_Start.TooltipValue = "";

                // int_TotSession
                int_TotSession.HrefValue = "";
                int_TotSession.TooltipValue = "";

                // int_PerDaySession
                int_PerDaySession.HrefValue = "";
                int_PerDaySession.TooltipValue = "";

                // str_CR_Days
                str_CR_Days.HrefValue = "";
                str_CR_Days.TooltipValue = "";

                // str_CR_Notes
                str_CR_Notes.HrefValue = "";
                str_CR_Notes.TooltipValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";
                int_Created_By.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";
                int_Modified_By.TooltipValue = "";

                // date_Created
                date_Created.HrefValue = "";
                date_Created.TooltipValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";
                bit_IsDeleted.TooltipValue = "";

                // bit_AllTeacher
                bit_AllTeacher.HrefValue = "";
                bit_AllTeacher.TooltipValue = "";

                // int_Manual_Change
                int_Manual_Change.HrefValue = "";
                int_Manual_Change.TooltipValue = "";

                // str_WebDesc
                str_WebDesc.HrefValue = "";
                str_WebDesc.TooltipValue = "";

                // is_Show
                is_Show.HrefValue = "";
                is_Show.TooltipValue = "";

                // is_ShowGridColumn
                is_ShowGridColumn.HrefValue = "";
                is_ShowGridColumn.TooltipValue = "";

                // rowIndex
                rowIndex.HrefValue = "";
                rowIndex.TooltipValue = "";

                // is_ZoomMeet
                is_ZoomMeet.HrefValue = "";
                is_ZoomMeet.TooltipValue = "";

                // BulkCR_Set
                BulkCR_Set.HrefValue = "";
                BulkCR_Set.TooltipValue = "";

                // int_Day_Incremental
                int_Day_Incremental.HrefValue = "";
                int_Day_Incremental.TooltipValue = "";

                // int_Reoccurrence
                int_Reoccurrence.HrefValue = "";
                int_Reoccurrence.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // Calendar_ID
                Calendar_ID.HrefValue = "";
                Calendar_ID.TooltipValue = "";

                // str_Package_Name
                str_Package_Name.HrefValue = "";
                str_Package_Name.TooltipValue = "";

                // date_Start2
                date_Start2.HrefValue = "";
                date_Start2.TooltipValue = "";

                // date_Start3
                date_Start3.HrefValue = "";
                date_Start3.TooltipValue = "";

                // date_Start4
                date_Start4.HrefValue = "";
                date_Start4.TooltipValue = "";
            }

            // Call Row Rendered event
            if (RowType != RowType.AggregateInit)
                RowRendered();
        }
        #pragma warning restore 1998

        // Get export HTML tag
        protected string GetExportTag(string type, bool custom = false) {
            string exportUrl = AppPath(CurrentPageName()); // DN
            if (type == "print" || custom) { // Printer friendly / custom export
                exportUrl += "?export=" + type + (custom ? "&amp;custom=1" : "");
            } else {
                exportUrl = AppPath(Config.ApiUrl + Config.ApiExportAction + "/" + type + "/" + TableVar);
            }
            if (SameText(type, "excel")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"fqryClassRoomListlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"fqryClassRoomListlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"fqryClassRoomListlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\">" + Language.Phrase("ExportToPDF") + "</a>";
            } else if (SameText(type, "html")) {
                return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-html\" title=\"" + HtmlEncode(Language.Phrase("ExportToHtml", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToHtml", true)) + "\">" + Language.Phrase("ExportToHtml") + "</a>";
            } else if (SameText(type, "xml")) {
                return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-xml\" title=\"" + HtmlEncode(Language.Phrase("ExportToXml", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToXml", true)) + "\">" + Language.Phrase("ExportToXml") + "</a>";
            } else if (SameText(type, "csv")) {
                return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-csv\" title=\"" + HtmlEncode(Language.Phrase("ExportToCsv", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToCsv", true)) + "\">" + Language.Phrase("ExportToCsv") + "</a>";
            } else if (SameText(type, "email")) {
                string url = custom ? " data-url=\"" + exportUrl + "\"" : "";
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"fqryClassRoomListlist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
            } else if (SameText(type, "print")) {
                return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-print\" title=\"" + HtmlEncode(Language.Phrase("PrinterFriendly", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("PrinterFriendly", true)) + "\">" + Language.Phrase("PrinterFriendly") + "</a>";
            }
            return "";
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

            // Export to XML
            item = ExportOptions.Add("xml");
            item.Body = GetExportTag("xml");
            item.Visible = false;

            // Export to CSV
            item = ExportOptions.Add("csv");
            item.Body = GetExportTag("csv");
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
            if (!Security.CanExport) // Export not allowed
                ExportOptions.HideAllOptions();
        }

        // Set up search options
        protected void SetupSearchOptions() {
            ListOption item;

            // Search button
            item = SearchOptions.Add("searchtoggle");
            var searchToggleClass = !Empty(SearchWhere) ? " active" : " active";
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"fqryClassRoomListsrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
            item.Visible = true;

            // Show all button
            item = SearchOptions.Add("showall");
            if (UseCustomTemplate || !UseAjaxActions)
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ShowAll") + "\" data-caption=\"" + Language.Phrase("ShowAll") + "\" href=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ShowAllBtn") + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ShowAll") + "\" data-caption=\"" + Language.Phrase("ShowAll") + "\" data-ew-action=\"refresh\" data-url=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ShowAllBtn") + "</a>";
            item.Visible = (SearchWhere != DefaultSearchWhere && SearchWhere != "0=101");

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
            return true;
        }

        // Render search options
        protected void RenderSearchOptions()
        {
            if (!HasSearchFields() && SearchOptions["searchtoggle"] is ListOption opt)
                opt.Visible = false;
        }

        #pragma warning disable 168

        /// <summary>
        /// Export data
        /// </summary>
        public async Task ExportData(dynamic? doc)
        {
            // Load recordset // DN
            DbDataReader? dr = null;
            if (TotalRecords < 0)
                TotalRecords = await ListRecordCountAsync();
            StartRecord = 1;

            // Export all
            if (ExportAll) {
                DisplayRecords = TotalRecords;
                StopRecord = TotalRecords;
            } else { // Export one page only
                SetupStartRecord(); // Set up start record position
                // Set the last record to display
                if (DisplayRecords < 0) {
                    StopRecord = TotalRecords;
                } else {
                    StopRecord = StartRecord + DisplayRecords - 1;
                }
            }
            CloseRecordset(); // DN
            dr = await LoadRecordset(StartRecord - 1, (DisplayRecords <= 0) ? TotalRecords : DisplayRecords); // DN
            if (doc == null) { // DN
                RemoveHeader("Content-Type"); // Remove header
                RemoveHeader("Content-Disposition");
                FailureMessage = Language.Phrase("ExportClassNotFound"); // Export class not found
                return;
            }

            // Call Page Exporting server event
            doc.ExportCustom = !PageExporting(ref doc);

            // Page header
            string header = PageHeader;
            PageDataRendering(ref header);
            doc.Text.Append(header);

            // Export
            if (dr != null)
                await ExportDocument(doc, dr, StartRecord, StopRecord, "");

            // Page footer
            string footer = PageFooter;
            PageDataRendered(ref footer);
            doc.Text.Append(footer);

            // Close recordset
            using (dr) {} // Dispose

            // Export header and footer
            await doc.ExportHeaderAndFooter();

            // Call Page Exported server event
            PageExported(doc);
        }
        #pragma warning restore 168

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            url = Regex.Replace(url, @"\?cmd=reset(all)?$", ""); // Remove cmd=reset / cmd=resetall
            breadcrumb.Add("list", TableVar, url, "", TableVar, true);
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

        // Close recordset
        public void CloseRecordset()
        {
            using (Recordset) {} // Dispose
        }

        // Set up starting record parameters
        public void SetupStartRecord()
        {
            // Exit if DisplayRecords = 0
            if (DisplayRecords == 0)
                return;
            string pageNo = Get(Config.TablePageNumber);
            string startRec = Get(Config.TableStartRec);
            bool infiniteScroll = false;
            infiniteScroll = Param<bool>("infinitescroll");
            if (!Empty(pageNo) && IsNumeric(pageNo)) {
                int page = ConvertToInt(pageNo);
                StartRecord = (page - 1) * DisplayRecords + 1;
                if (StartRecord <= 0)
                    StartRecord = 1;
                else if (StartRecord >= ((TotalRecords - 1) / DisplayRecords) * DisplayRecords + 1)
                    StartRecord = ((TotalRecords - 1) / DisplayRecords) * DisplayRecords + 1;
            } else if (!Empty(startRec) && IsNumeric(startRec)) {
                StartRecord = ConvertToInt(startRec);
            } else if (!infiniteScroll) {
                StartRecord = StartRecordNumber;
            }

            // Check if correct start record counter
            if (StartRecord <= 0) // Avoid invalid start record counter
                StartRecord = 1; // Reset start record counter
            else if (StartRecord > TotalRecords) // Avoid starting record > total records
                StartRecord = ((TotalRecords - 1) / DisplayRecords) * DisplayRecords + 1; // Point to last page first record
            else if ((StartRecord - 1) % DisplayRecords != 0)
                StartRecord = ((StartRecord - 1) / DisplayRecords) * DisplayRecords + 1; // Point to page boundary
            if (!infiniteScroll)
                StartRecordNumber = StartRecord;
        }

        // Get page count
        public int PageCount
        {
            get {
                return ConvertToInt(Math.Ceiling((double)TotalRecords / DisplayRecords));
            }
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

        // Form Custom Validate event
        public virtual bool FormCustomValidate(ref string customError) {
            //Return error message in customError
            return true;
        }

        // ListOptions Load event
        public virtual void ListOptionsLoad() {
            // Example:
            //var opt = ListOptions.Add("new");
            //opt.Header = "xxx";
            //opt.OnLeft = true; // Link on left
            //opt.MoveTo(0); // Move to first column
        }

        // ListOptions Rendering event
        public virtual void ListOptionsRendering() {
            //xxxGrid.DetailAdd = (...condition...); // Set to true or false conditionally
            //xxxGrid.DetailEdit = (...condition...); // Set to true or false conditionally
            //xxxGrid.DetailView = (...condition...); // Set to true or false conditionally
        }

        // ListOptions Rendered event
        public virtual void ListOptionsRendered() {
            //Example:
            //ListOptions["new"].Body = "xxx";
        }

        // Row Custom Action event
        public virtual bool RowCustomAction(string action, Dictionary<string, object> row) {
            // Return false to abort
            return true;
        }

        // Page Exporting event
        // doc = export document object
        public virtual bool PageExporting(ref dynamic doc) {
            //doc.Text.Append("<p>" + "my header" + "</p>"); // Export header
            //return false; // Return false to skip default export and use Row_Export event
            return true; // Return true to use default export and skip Row_Export event
        }

        // Page Exported event
        // doc = export document object
        public virtual void PageExported(dynamic doc) {
            //doc.Text.Append("my footer"); // Export footer
            //Log("Text: {Text}", doc.Text.ToString());
        }

        // Grid Inserting event
        public virtual bool GridInserting() {
            // Enter your code here
            // To reject grid insert, set return value to false
            return true;
        }

        // Grid Inserted event
        public virtual void GridInserted(List<Dictionary<string, object>> rsnew) {
            //Log("Grid Inserted");
        }

        // Grid Updating event
        public virtual bool GridUpdating(List<Dictionary<string, object>> rsold) {
            // Enter your code here
            // To reject grid update, set return value to false
            return true;
        }

        // Grid Updated event
        public virtual void GridUpdated(List<Dictionary<string, object>> rsold, List<Dictionary<string, object>> rsnew) {
            //Log("Grid Updated");
        }
    } // End page class
} // End Partial class
