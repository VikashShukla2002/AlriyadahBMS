namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblLocationList
    /// </summary>
    public static TblLocationList tblLocationList
    {
        get => HttpData.Get<TblLocationList>("tblLocationList")!;
        set => HttpData["tblLocationList"] = value;
    }

    /// <summary>
    /// Page class for tblLocation
    /// </summary>
    public class TblLocationList : TblLocationListBase
    {
        // Constructor
        public TblLocationList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblLocationList() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblLocationListBase : TblLocation
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblLocation";

        // Page object name
        public string PageObjName = "tblLocationList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblLocationlist";

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
        public TblLocationListBase()
        {
            // CSS class name as context
            TableVar = "tblLocation";
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

            // Table object (tblLocation)
            if (tblLocation == null || tblLocation is TblLocation)
                tblLocation = this;

            // Initialize URLs
            AddUrl = "TblLocationAdd";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblLocationDelete";
            MultiUpdateUrl = "TblLocationUpdate";

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
        public string PageName => "TblLocationList";

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
            int_Location_Id.SetVisibility();
            str_Name.SetVisibility();
            str_Code.SetVisibility();
            str_Location_Type.SetVisibility();
            str_Address1.SetVisibility();
            str_Address2.SetVisibility();
            str_City.SetVisibility();
            int_State.SetVisibility();
            str_Zip.SetVisibility();
            str_County.SetVisibility();
            str_Manager.SetVisibility();
            str_Phone_Main.SetVisibility();
            str_Phone_Fax.SetVisibility();
            str_Phone_Other.SetVisibility();
            str_Notes.SetVisibility();
            str_Coverage_Code.Visible = false;
            int_Status.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_LocCapacity.SetVisibility();
            str_ContactEmail.SetVisibility();
            str_SchoolHours.SetVisibility();
            str_EmerName.SetVisibility();
            str_EmerPhone.SetVisibility();
            str_Room.SetVisibility();
            str_Email_Content.SetVisibility();
            bit_appointmentColor.SetVisibility();
            str_appointmentColorCode.SetVisibility();
            isKnowledgeTest.SetVisibility();
            isRoadTest.SetVisibility();
            dec_Latitude.SetVisibility();
            dec_Longitude.SetVisibility();
            str_nameAr.SetVisibility();
            IsDistanceBasedScheduling.SetVisibility();
            str_ZoomEmail.SetVisibility();
            str_ProviderLocationId.SetVisibility();
            int_RoadDistanceCoverage.SetVisibility();
            IsCashDrawer.SetVisibility();
        }

        // Constructor
        public TblLocationListBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblLocationView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Location_Id") ? dict["int_Location_Id"] : int_Location_Id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
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
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_appointmentColor);
            await SetupLookupOptions(isKnowledgeTest);
            await SetupLookupOptions(isRoadTest);

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblLocationgrid";

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
                tblLocationList?.PageRender();
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
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblLocationsrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Location_Id.AdvancedSearch.ToJson())); // Field int_Location_Id
            filters.Merge(JObject.Parse(str_Name.AdvancedSearch.ToJson())); // Field str_Name
            filters.Merge(JObject.Parse(str_Code.AdvancedSearch.ToJson())); // Field str_Code
            filters.Merge(JObject.Parse(str_Location_Type.AdvancedSearch.ToJson())); // Field str_Location_Type
            filters.Merge(JObject.Parse(str_Address1.AdvancedSearch.ToJson())); // Field str_Address1
            filters.Merge(JObject.Parse(str_Address2.AdvancedSearch.ToJson())); // Field str_Address2
            filters.Merge(JObject.Parse(str_City.AdvancedSearch.ToJson())); // Field str_City
            filters.Merge(JObject.Parse(int_State.AdvancedSearch.ToJson())); // Field int_State
            filters.Merge(JObject.Parse(str_Zip.AdvancedSearch.ToJson())); // Field str_Zip
            filters.Merge(JObject.Parse(str_County.AdvancedSearch.ToJson())); // Field str_County
            filters.Merge(JObject.Parse(str_Manager.AdvancedSearch.ToJson())); // Field str_Manager
            filters.Merge(JObject.Parse(str_Phone_Main.AdvancedSearch.ToJson())); // Field str_Phone_Main
            filters.Merge(JObject.Parse(str_Phone_Fax.AdvancedSearch.ToJson())); // Field str_Phone_Fax
            filters.Merge(JObject.Parse(str_Phone_Other.AdvancedSearch.ToJson())); // Field str_Phone_Other
            filters.Merge(JObject.Parse(str_Notes.AdvancedSearch.ToJson())); // Field str_Notes
            filters.Merge(JObject.Parse(str_Coverage_Code.AdvancedSearch.ToJson())); // Field str_Coverage_Code
            filters.Merge(JObject.Parse(int_Status.AdvancedSearch.ToJson())); // Field int_Status
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(str_LocCapacity.AdvancedSearch.ToJson())); // Field str_LocCapacity
            filters.Merge(JObject.Parse(str_ContactEmail.AdvancedSearch.ToJson())); // Field str_ContactEmail
            filters.Merge(JObject.Parse(str_SchoolHours.AdvancedSearch.ToJson())); // Field str_SchoolHours
            filters.Merge(JObject.Parse(str_EmerName.AdvancedSearch.ToJson())); // Field str_EmerName
            filters.Merge(JObject.Parse(str_EmerPhone.AdvancedSearch.ToJson())); // Field str_EmerPhone
            filters.Merge(JObject.Parse(str_Room.AdvancedSearch.ToJson())); // Field str_Room
            filters.Merge(JObject.Parse(str_Email_Content.AdvancedSearch.ToJson())); // Field str_Email_Content
            filters.Merge(JObject.Parse(bit_appointmentColor.AdvancedSearch.ToJson())); // Field bit_appointmentColor
            filters.Merge(JObject.Parse(str_appointmentColorCode.AdvancedSearch.ToJson())); // Field str_appointmentColorCode
            filters.Merge(JObject.Parse(isKnowledgeTest.AdvancedSearch.ToJson())); // Field isKnowledgeTest
            filters.Merge(JObject.Parse(isRoadTest.AdvancedSearch.ToJson())); // Field isRoadTest
            filters.Merge(JObject.Parse(dec_Latitude.AdvancedSearch.ToJson())); // Field dec_Latitude
            filters.Merge(JObject.Parse(dec_Longitude.AdvancedSearch.ToJson())); // Field dec_Longitude
            filters.Merge(JObject.Parse(str_nameAr.AdvancedSearch.ToJson())); // Field str_nameAr
            filters.Merge(JObject.Parse(IsDistanceBasedScheduling.AdvancedSearch.ToJson())); // Field IsDistanceBasedScheduling
            filters.Merge(JObject.Parse(str_ZoomEmail.AdvancedSearch.ToJson())); // Field str_ZoomEmail
            filters.Merge(JObject.Parse(str_ProviderLocationId.AdvancedSearch.ToJson())); // Field str_ProviderLocationId
            filters.Merge(JObject.Parse(int_RoadDistanceCoverage.AdvancedSearch.ToJson())); // Field int_RoadDistanceCoverage
            filters.Merge(JObject.Parse(IsCashDrawer.AdvancedSearch.ToJson())); // Field IsCashDrawer
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblLocationsrch", filters);
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

            // Field int_Location_Id
            if (filter?.TryGetValue("x_int_Location_Id", out sv) ?? false) {
                int_Location_Id.AdvancedSearch.SearchValue = sv;
                int_Location_Id.AdvancedSearch.SearchOperator = filter["z_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchCondition = filter["v_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchValue2 = filter["y_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Location_Id"];
                int_Location_Id.AdvancedSearch.Save();
            }

            // Field str_Name
            if (filter?.TryGetValue("x_str_Name", out sv) ?? false) {
                str_Name.AdvancedSearch.SearchValue = sv;
                str_Name.AdvancedSearch.SearchOperator = filter["z_str_Name"];
                str_Name.AdvancedSearch.SearchCondition = filter["v_str_Name"];
                str_Name.AdvancedSearch.SearchValue2 = filter["y_str_Name"];
                str_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Name"];
                str_Name.AdvancedSearch.Save();
            }

            // Field str_Code
            if (filter?.TryGetValue("x_str_Code", out sv) ?? false) {
                str_Code.AdvancedSearch.SearchValue = sv;
                str_Code.AdvancedSearch.SearchOperator = filter["z_str_Code"];
                str_Code.AdvancedSearch.SearchCondition = filter["v_str_Code"];
                str_Code.AdvancedSearch.SearchValue2 = filter["y_str_Code"];
                str_Code.AdvancedSearch.SearchOperator2 = filter["w_str_Code"];
                str_Code.AdvancedSearch.Save();
            }

            // Field str_Location_Type
            if (filter?.TryGetValue("x_str_Location_Type", out sv) ?? false) {
                str_Location_Type.AdvancedSearch.SearchValue = sv;
                str_Location_Type.AdvancedSearch.SearchOperator = filter["z_str_Location_Type"];
                str_Location_Type.AdvancedSearch.SearchCondition = filter["v_str_Location_Type"];
                str_Location_Type.AdvancedSearch.SearchValue2 = filter["y_str_Location_Type"];
                str_Location_Type.AdvancedSearch.SearchOperator2 = filter["w_str_Location_Type"];
                str_Location_Type.AdvancedSearch.Save();
            }

            // Field str_Address1
            if (filter?.TryGetValue("x_str_Address1", out sv) ?? false) {
                str_Address1.AdvancedSearch.SearchValue = sv;
                str_Address1.AdvancedSearch.SearchOperator = filter["z_str_Address1"];
                str_Address1.AdvancedSearch.SearchCondition = filter["v_str_Address1"];
                str_Address1.AdvancedSearch.SearchValue2 = filter["y_str_Address1"];
                str_Address1.AdvancedSearch.SearchOperator2 = filter["w_str_Address1"];
                str_Address1.AdvancedSearch.Save();
            }

            // Field str_Address2
            if (filter?.TryGetValue("x_str_Address2", out sv) ?? false) {
                str_Address2.AdvancedSearch.SearchValue = sv;
                str_Address2.AdvancedSearch.SearchOperator = filter["z_str_Address2"];
                str_Address2.AdvancedSearch.SearchCondition = filter["v_str_Address2"];
                str_Address2.AdvancedSearch.SearchValue2 = filter["y_str_Address2"];
                str_Address2.AdvancedSearch.SearchOperator2 = filter["w_str_Address2"];
                str_Address2.AdvancedSearch.Save();
            }

            // Field str_City
            if (filter?.TryGetValue("x_str_City", out sv) ?? false) {
                str_City.AdvancedSearch.SearchValue = sv;
                str_City.AdvancedSearch.SearchOperator = filter["z_str_City"];
                str_City.AdvancedSearch.SearchCondition = filter["v_str_City"];
                str_City.AdvancedSearch.SearchValue2 = filter["y_str_City"];
                str_City.AdvancedSearch.SearchOperator2 = filter["w_str_City"];
                str_City.AdvancedSearch.Save();
            }

            // Field int_State
            if (filter?.TryGetValue("x_int_State", out sv) ?? false) {
                int_State.AdvancedSearch.SearchValue = sv;
                int_State.AdvancedSearch.SearchOperator = filter["z_int_State"];
                int_State.AdvancedSearch.SearchCondition = filter["v_int_State"];
                int_State.AdvancedSearch.SearchValue2 = filter["y_int_State"];
                int_State.AdvancedSearch.SearchOperator2 = filter["w_int_State"];
                int_State.AdvancedSearch.Save();
            }

            // Field str_Zip
            if (filter?.TryGetValue("x_str_Zip", out sv) ?? false) {
                str_Zip.AdvancedSearch.SearchValue = sv;
                str_Zip.AdvancedSearch.SearchOperator = filter["z_str_Zip"];
                str_Zip.AdvancedSearch.SearchCondition = filter["v_str_Zip"];
                str_Zip.AdvancedSearch.SearchValue2 = filter["y_str_Zip"];
                str_Zip.AdvancedSearch.SearchOperator2 = filter["w_str_Zip"];
                str_Zip.AdvancedSearch.Save();
            }

            // Field str_County
            if (filter?.TryGetValue("x_str_County", out sv) ?? false) {
                str_County.AdvancedSearch.SearchValue = sv;
                str_County.AdvancedSearch.SearchOperator = filter["z_str_County"];
                str_County.AdvancedSearch.SearchCondition = filter["v_str_County"];
                str_County.AdvancedSearch.SearchValue2 = filter["y_str_County"];
                str_County.AdvancedSearch.SearchOperator2 = filter["w_str_County"];
                str_County.AdvancedSearch.Save();
            }

            // Field str_Manager
            if (filter?.TryGetValue("x_str_Manager", out sv) ?? false) {
                str_Manager.AdvancedSearch.SearchValue = sv;
                str_Manager.AdvancedSearch.SearchOperator = filter["z_str_Manager"];
                str_Manager.AdvancedSearch.SearchCondition = filter["v_str_Manager"];
                str_Manager.AdvancedSearch.SearchValue2 = filter["y_str_Manager"];
                str_Manager.AdvancedSearch.SearchOperator2 = filter["w_str_Manager"];
                str_Manager.AdvancedSearch.Save();
            }

            // Field str_Phone_Main
            if (filter?.TryGetValue("x_str_Phone_Main", out sv) ?? false) {
                str_Phone_Main.AdvancedSearch.SearchValue = sv;
                str_Phone_Main.AdvancedSearch.SearchOperator = filter["z_str_Phone_Main"];
                str_Phone_Main.AdvancedSearch.SearchCondition = filter["v_str_Phone_Main"];
                str_Phone_Main.AdvancedSearch.SearchValue2 = filter["y_str_Phone_Main"];
                str_Phone_Main.AdvancedSearch.SearchOperator2 = filter["w_str_Phone_Main"];
                str_Phone_Main.AdvancedSearch.Save();
            }

            // Field str_Phone_Fax
            if (filter?.TryGetValue("x_str_Phone_Fax", out sv) ?? false) {
                str_Phone_Fax.AdvancedSearch.SearchValue = sv;
                str_Phone_Fax.AdvancedSearch.SearchOperator = filter["z_str_Phone_Fax"];
                str_Phone_Fax.AdvancedSearch.SearchCondition = filter["v_str_Phone_Fax"];
                str_Phone_Fax.AdvancedSearch.SearchValue2 = filter["y_str_Phone_Fax"];
                str_Phone_Fax.AdvancedSearch.SearchOperator2 = filter["w_str_Phone_Fax"];
                str_Phone_Fax.AdvancedSearch.Save();
            }

            // Field str_Phone_Other
            if (filter?.TryGetValue("x_str_Phone_Other", out sv) ?? false) {
                str_Phone_Other.AdvancedSearch.SearchValue = sv;
                str_Phone_Other.AdvancedSearch.SearchOperator = filter["z_str_Phone_Other"];
                str_Phone_Other.AdvancedSearch.SearchCondition = filter["v_str_Phone_Other"];
                str_Phone_Other.AdvancedSearch.SearchValue2 = filter["y_str_Phone_Other"];
                str_Phone_Other.AdvancedSearch.SearchOperator2 = filter["w_str_Phone_Other"];
                str_Phone_Other.AdvancedSearch.Save();
            }

            // Field str_Notes
            if (filter?.TryGetValue("x_str_Notes", out sv) ?? false) {
                str_Notes.AdvancedSearch.SearchValue = sv;
                str_Notes.AdvancedSearch.SearchOperator = filter["z_str_Notes"];
                str_Notes.AdvancedSearch.SearchCondition = filter["v_str_Notes"];
                str_Notes.AdvancedSearch.SearchValue2 = filter["y_str_Notes"];
                str_Notes.AdvancedSearch.SearchOperator2 = filter["w_str_Notes"];
                str_Notes.AdvancedSearch.Save();
            }

            // Field str_Coverage_Code
            if (filter?.TryGetValue("x_str_Coverage_Code", out sv) ?? false) {
                str_Coverage_Code.AdvancedSearch.SearchValue = sv;
                str_Coverage_Code.AdvancedSearch.SearchOperator = filter["z_str_Coverage_Code"];
                str_Coverage_Code.AdvancedSearch.SearchCondition = filter["v_str_Coverage_Code"];
                str_Coverage_Code.AdvancedSearch.SearchValue2 = filter["y_str_Coverage_Code"];
                str_Coverage_Code.AdvancedSearch.SearchOperator2 = filter["w_str_Coverage_Code"];
                str_Coverage_Code.AdvancedSearch.Save();
            }

            // Field int_Status
            if (filter?.TryGetValue("x_int_Status", out sv) ?? false) {
                int_Status.AdvancedSearch.SearchValue = sv;
                int_Status.AdvancedSearch.SearchOperator = filter["z_int_Status"];
                int_Status.AdvancedSearch.SearchCondition = filter["v_int_Status"];
                int_Status.AdvancedSearch.SearchValue2 = filter["y_int_Status"];
                int_Status.AdvancedSearch.SearchOperator2 = filter["w_int_Status"];
                int_Status.AdvancedSearch.Save();
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

            // Field bit_IsDeleted
            if (filter?.TryGetValue("x_bit_IsDeleted", out sv) ?? false) {
                bit_IsDeleted.AdvancedSearch.SearchValue = sv;
                bit_IsDeleted.AdvancedSearch.SearchOperator = filter["z_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchCondition = filter["v_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchValue2 = filter["y_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchOperator2 = filter["w_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.Save();
            }

            // Field str_LocCapacity
            if (filter?.TryGetValue("x_str_LocCapacity", out sv) ?? false) {
                str_LocCapacity.AdvancedSearch.SearchValue = sv;
                str_LocCapacity.AdvancedSearch.SearchOperator = filter["z_str_LocCapacity"];
                str_LocCapacity.AdvancedSearch.SearchCondition = filter["v_str_LocCapacity"];
                str_LocCapacity.AdvancedSearch.SearchValue2 = filter["y_str_LocCapacity"];
                str_LocCapacity.AdvancedSearch.SearchOperator2 = filter["w_str_LocCapacity"];
                str_LocCapacity.AdvancedSearch.Save();
            }

            // Field str_ContactEmail
            if (filter?.TryGetValue("x_str_ContactEmail", out sv) ?? false) {
                str_ContactEmail.AdvancedSearch.SearchValue = sv;
                str_ContactEmail.AdvancedSearch.SearchOperator = filter["z_str_ContactEmail"];
                str_ContactEmail.AdvancedSearch.SearchCondition = filter["v_str_ContactEmail"];
                str_ContactEmail.AdvancedSearch.SearchValue2 = filter["y_str_ContactEmail"];
                str_ContactEmail.AdvancedSearch.SearchOperator2 = filter["w_str_ContactEmail"];
                str_ContactEmail.AdvancedSearch.Save();
            }

            // Field str_SchoolHours
            if (filter?.TryGetValue("x_str_SchoolHours", out sv) ?? false) {
                str_SchoolHours.AdvancedSearch.SearchValue = sv;
                str_SchoolHours.AdvancedSearch.SearchOperator = filter["z_str_SchoolHours"];
                str_SchoolHours.AdvancedSearch.SearchCondition = filter["v_str_SchoolHours"];
                str_SchoolHours.AdvancedSearch.SearchValue2 = filter["y_str_SchoolHours"];
                str_SchoolHours.AdvancedSearch.SearchOperator2 = filter["w_str_SchoolHours"];
                str_SchoolHours.AdvancedSearch.Save();
            }

            // Field str_EmerName
            if (filter?.TryGetValue("x_str_EmerName", out sv) ?? false) {
                str_EmerName.AdvancedSearch.SearchValue = sv;
                str_EmerName.AdvancedSearch.SearchOperator = filter["z_str_EmerName"];
                str_EmerName.AdvancedSearch.SearchCondition = filter["v_str_EmerName"];
                str_EmerName.AdvancedSearch.SearchValue2 = filter["y_str_EmerName"];
                str_EmerName.AdvancedSearch.SearchOperator2 = filter["w_str_EmerName"];
                str_EmerName.AdvancedSearch.Save();
            }

            // Field str_EmerPhone
            if (filter?.TryGetValue("x_str_EmerPhone", out sv) ?? false) {
                str_EmerPhone.AdvancedSearch.SearchValue = sv;
                str_EmerPhone.AdvancedSearch.SearchOperator = filter["z_str_EmerPhone"];
                str_EmerPhone.AdvancedSearch.SearchCondition = filter["v_str_EmerPhone"];
                str_EmerPhone.AdvancedSearch.SearchValue2 = filter["y_str_EmerPhone"];
                str_EmerPhone.AdvancedSearch.SearchOperator2 = filter["w_str_EmerPhone"];
                str_EmerPhone.AdvancedSearch.Save();
            }

            // Field str_Room
            if (filter?.TryGetValue("x_str_Room", out sv) ?? false) {
                str_Room.AdvancedSearch.SearchValue = sv;
                str_Room.AdvancedSearch.SearchOperator = filter["z_str_Room"];
                str_Room.AdvancedSearch.SearchCondition = filter["v_str_Room"];
                str_Room.AdvancedSearch.SearchValue2 = filter["y_str_Room"];
                str_Room.AdvancedSearch.SearchOperator2 = filter["w_str_Room"];
                str_Room.AdvancedSearch.Save();
            }

            // Field str_Email_Content
            if (filter?.TryGetValue("x_str_Email_Content", out sv) ?? false) {
                str_Email_Content.AdvancedSearch.SearchValue = sv;
                str_Email_Content.AdvancedSearch.SearchOperator = filter["z_str_Email_Content"];
                str_Email_Content.AdvancedSearch.SearchCondition = filter["v_str_Email_Content"];
                str_Email_Content.AdvancedSearch.SearchValue2 = filter["y_str_Email_Content"];
                str_Email_Content.AdvancedSearch.SearchOperator2 = filter["w_str_Email_Content"];
                str_Email_Content.AdvancedSearch.Save();
            }

            // Field bit_appointmentColor
            if (filter?.TryGetValue("x_bit_appointmentColor", out sv) ?? false) {
                bit_appointmentColor.AdvancedSearch.SearchValue = sv;
                bit_appointmentColor.AdvancedSearch.SearchOperator = filter["z_bit_appointmentColor"];
                bit_appointmentColor.AdvancedSearch.SearchCondition = filter["v_bit_appointmentColor"];
                bit_appointmentColor.AdvancedSearch.SearchValue2 = filter["y_bit_appointmentColor"];
                bit_appointmentColor.AdvancedSearch.SearchOperator2 = filter["w_bit_appointmentColor"];
                bit_appointmentColor.AdvancedSearch.Save();
            }

            // Field str_appointmentColorCode
            if (filter?.TryGetValue("x_str_appointmentColorCode", out sv) ?? false) {
                str_appointmentColorCode.AdvancedSearch.SearchValue = sv;
                str_appointmentColorCode.AdvancedSearch.SearchOperator = filter["z_str_appointmentColorCode"];
                str_appointmentColorCode.AdvancedSearch.SearchCondition = filter["v_str_appointmentColorCode"];
                str_appointmentColorCode.AdvancedSearch.SearchValue2 = filter["y_str_appointmentColorCode"];
                str_appointmentColorCode.AdvancedSearch.SearchOperator2 = filter["w_str_appointmentColorCode"];
                str_appointmentColorCode.AdvancedSearch.Save();
            }

            // Field isKnowledgeTest
            if (filter?.TryGetValue("x_isKnowledgeTest", out sv) ?? false) {
                isKnowledgeTest.AdvancedSearch.SearchValue = sv;
                isKnowledgeTest.AdvancedSearch.SearchOperator = filter["z_isKnowledgeTest"];
                isKnowledgeTest.AdvancedSearch.SearchCondition = filter["v_isKnowledgeTest"];
                isKnowledgeTest.AdvancedSearch.SearchValue2 = filter["y_isKnowledgeTest"];
                isKnowledgeTest.AdvancedSearch.SearchOperator2 = filter["w_isKnowledgeTest"];
                isKnowledgeTest.AdvancedSearch.Save();
            }

            // Field isRoadTest
            if (filter?.TryGetValue("x_isRoadTest", out sv) ?? false) {
                isRoadTest.AdvancedSearch.SearchValue = sv;
                isRoadTest.AdvancedSearch.SearchOperator = filter["z_isRoadTest"];
                isRoadTest.AdvancedSearch.SearchCondition = filter["v_isRoadTest"];
                isRoadTest.AdvancedSearch.SearchValue2 = filter["y_isRoadTest"];
                isRoadTest.AdvancedSearch.SearchOperator2 = filter["w_isRoadTest"];
                isRoadTest.AdvancedSearch.Save();
            }

            // Field dec_Latitude
            if (filter?.TryGetValue("x_dec_Latitude", out sv) ?? false) {
                dec_Latitude.AdvancedSearch.SearchValue = sv;
                dec_Latitude.AdvancedSearch.SearchOperator = filter["z_dec_Latitude"];
                dec_Latitude.AdvancedSearch.SearchCondition = filter["v_dec_Latitude"];
                dec_Latitude.AdvancedSearch.SearchValue2 = filter["y_dec_Latitude"];
                dec_Latitude.AdvancedSearch.SearchOperator2 = filter["w_dec_Latitude"];
                dec_Latitude.AdvancedSearch.Save();
            }

            // Field dec_Longitude
            if (filter?.TryGetValue("x_dec_Longitude", out sv) ?? false) {
                dec_Longitude.AdvancedSearch.SearchValue = sv;
                dec_Longitude.AdvancedSearch.SearchOperator = filter["z_dec_Longitude"];
                dec_Longitude.AdvancedSearch.SearchCondition = filter["v_dec_Longitude"];
                dec_Longitude.AdvancedSearch.SearchValue2 = filter["y_dec_Longitude"];
                dec_Longitude.AdvancedSearch.SearchOperator2 = filter["w_dec_Longitude"];
                dec_Longitude.AdvancedSearch.Save();
            }

            // Field str_nameAr
            if (filter?.TryGetValue("x_str_nameAr", out sv) ?? false) {
                str_nameAr.AdvancedSearch.SearchValue = sv;
                str_nameAr.AdvancedSearch.SearchOperator = filter["z_str_nameAr"];
                str_nameAr.AdvancedSearch.SearchCondition = filter["v_str_nameAr"];
                str_nameAr.AdvancedSearch.SearchValue2 = filter["y_str_nameAr"];
                str_nameAr.AdvancedSearch.SearchOperator2 = filter["w_str_nameAr"];
                str_nameAr.AdvancedSearch.Save();
            }

            // Field IsDistanceBasedScheduling
            if (filter?.TryGetValue("x_IsDistanceBasedScheduling", out sv) ?? false) {
                IsDistanceBasedScheduling.AdvancedSearch.SearchValue = sv;
                IsDistanceBasedScheduling.AdvancedSearch.SearchOperator = filter["z_IsDistanceBasedScheduling"];
                IsDistanceBasedScheduling.AdvancedSearch.SearchCondition = filter["v_IsDistanceBasedScheduling"];
                IsDistanceBasedScheduling.AdvancedSearch.SearchValue2 = filter["y_IsDistanceBasedScheduling"];
                IsDistanceBasedScheduling.AdvancedSearch.SearchOperator2 = filter["w_IsDistanceBasedScheduling"];
                IsDistanceBasedScheduling.AdvancedSearch.Save();
            }

            // Field str_ZoomEmail
            if (filter?.TryGetValue("x_str_ZoomEmail", out sv) ?? false) {
                str_ZoomEmail.AdvancedSearch.SearchValue = sv;
                str_ZoomEmail.AdvancedSearch.SearchOperator = filter["z_str_ZoomEmail"];
                str_ZoomEmail.AdvancedSearch.SearchCondition = filter["v_str_ZoomEmail"];
                str_ZoomEmail.AdvancedSearch.SearchValue2 = filter["y_str_ZoomEmail"];
                str_ZoomEmail.AdvancedSearch.SearchOperator2 = filter["w_str_ZoomEmail"];
                str_ZoomEmail.AdvancedSearch.Save();
            }

            // Field str_ProviderLocationId
            if (filter?.TryGetValue("x_str_ProviderLocationId", out sv) ?? false) {
                str_ProviderLocationId.AdvancedSearch.SearchValue = sv;
                str_ProviderLocationId.AdvancedSearch.SearchOperator = filter["z_str_ProviderLocationId"];
                str_ProviderLocationId.AdvancedSearch.SearchCondition = filter["v_str_ProviderLocationId"];
                str_ProviderLocationId.AdvancedSearch.SearchValue2 = filter["y_str_ProviderLocationId"];
                str_ProviderLocationId.AdvancedSearch.SearchOperator2 = filter["w_str_ProviderLocationId"];
                str_ProviderLocationId.AdvancedSearch.Save();
            }

            // Field int_RoadDistanceCoverage
            if (filter?.TryGetValue("x_int_RoadDistanceCoverage", out sv) ?? false) {
                int_RoadDistanceCoverage.AdvancedSearch.SearchValue = sv;
                int_RoadDistanceCoverage.AdvancedSearch.SearchOperator = filter["z_int_RoadDistanceCoverage"];
                int_RoadDistanceCoverage.AdvancedSearch.SearchCondition = filter["v_int_RoadDistanceCoverage"];
                int_RoadDistanceCoverage.AdvancedSearch.SearchValue2 = filter["y_int_RoadDistanceCoverage"];
                int_RoadDistanceCoverage.AdvancedSearch.SearchOperator2 = filter["w_int_RoadDistanceCoverage"];
                int_RoadDistanceCoverage.AdvancedSearch.Save();
            }

            // Field IsCashDrawer
            if (filter?.TryGetValue("x_IsCashDrawer", out sv) ?? false) {
                IsCashDrawer.AdvancedSearch.SearchValue = sv;
                IsCashDrawer.AdvancedSearch.SearchOperator = filter["z_IsCashDrawer"];
                IsCashDrawer.AdvancedSearch.SearchCondition = filter["v_IsCashDrawer"];
                IsCashDrawer.AdvancedSearch.SearchValue2 = filter["y_IsCashDrawer"];
                IsCashDrawer.AdvancedSearch.SearchOperator2 = filter["w_IsCashDrawer"];
                IsCashDrawer.AdvancedSearch.Save();
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
            searchFlds.Add(str_Name);
            searchFlds.Add(str_Code);
            searchFlds.Add(str_Location_Type);
            searchFlds.Add(str_Address1);
            searchFlds.Add(str_Address2);
            searchFlds.Add(str_City);
            searchFlds.Add(str_Zip);
            searchFlds.Add(str_County);
            searchFlds.Add(str_Manager);
            searchFlds.Add(str_Phone_Main);
            searchFlds.Add(str_Phone_Fax);
            searchFlds.Add(str_Phone_Other);
            searchFlds.Add(str_Notes);
            searchFlds.Add(str_Coverage_Code);
            searchFlds.Add(str_LocCapacity);
            searchFlds.Add(str_ContactEmail);
            searchFlds.Add(str_SchoolHours);
            searchFlds.Add(str_EmerName);
            searchFlds.Add(str_EmerPhone);
            searchFlds.Add(str_Room);
            searchFlds.Add(str_Email_Content);
            searchFlds.Add(str_appointmentColorCode);
            searchFlds.Add(str_nameAr);
            searchFlds.Add(str_ZoomEmail);
            searchFlds.Add(str_ProviderLocationId);
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
                UpdateSort(int_Location_Id, ctrl); // int_Location_Id
                UpdateSort(str_Name, ctrl); // str_Name
                UpdateSort(str_Code, ctrl); // str_Code
                UpdateSort(str_Location_Type, ctrl); // str_Location_Type
                UpdateSort(str_Address1, ctrl); // str_Address1
                UpdateSort(str_Address2, ctrl); // str_Address2
                UpdateSort(str_City, ctrl); // str_City
                UpdateSort(int_State, ctrl); // int_State
                UpdateSort(str_Zip, ctrl); // str_Zip
                UpdateSort(str_County, ctrl); // str_County
                UpdateSort(str_Manager, ctrl); // str_Manager
                UpdateSort(str_Phone_Main, ctrl); // str_Phone_Main
                UpdateSort(str_Phone_Fax, ctrl); // str_Phone_Fax
                UpdateSort(str_Phone_Other, ctrl); // str_Phone_Other
                UpdateSort(str_Notes, ctrl); // str_Notes
                UpdateSort(int_Status, ctrl); // int_Status
                UpdateSort(date_Created, ctrl); // date_Created
                UpdateSort(date_Modified, ctrl); // date_Modified
                UpdateSort(int_Created_By, ctrl); // int_Created_By
                UpdateSort(int_Modified_By, ctrl); // int_Modified_By
                UpdateSort(bit_IsDeleted, ctrl); // bit_IsDeleted
                UpdateSort(str_LocCapacity, ctrl); // str_LocCapacity
                UpdateSort(str_ContactEmail, ctrl); // str_ContactEmail
                UpdateSort(str_SchoolHours, ctrl); // str_SchoolHours
                UpdateSort(str_EmerName, ctrl); // str_EmerName
                UpdateSort(str_EmerPhone, ctrl); // str_EmerPhone
                UpdateSort(str_Room, ctrl); // str_Room
                UpdateSort(str_Email_Content, ctrl); // str_Email_Content
                UpdateSort(bit_appointmentColor, ctrl); // bit_appointmentColor
                UpdateSort(str_appointmentColorCode, ctrl); // str_appointmentColorCode
                UpdateSort(isKnowledgeTest, ctrl); // isKnowledgeTest
                UpdateSort(isRoadTest, ctrl); // isRoadTest
                UpdateSort(dec_Latitude, ctrl); // dec_Latitude
                UpdateSort(dec_Longitude, ctrl); // dec_Longitude
                UpdateSort(str_nameAr, ctrl); // str_nameAr
                UpdateSort(IsDistanceBasedScheduling, ctrl); // IsDistanceBasedScheduling
                UpdateSort(str_ZoomEmail, ctrl); // str_ZoomEmail
                UpdateSort(str_ProviderLocationId, ctrl); // str_ProviderLocationId
                UpdateSort(int_RoadDistanceCoverage, ctrl); // int_RoadDistanceCoverage
                UpdateSort(IsCashDrawer, ctrl); // IsCashDrawer
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
                    int_Location_Id.Sort = "";
                    str_Name.Sort = "";
                    str_Code.Sort = "";
                    str_Location_Type.Sort = "";
                    str_Address1.Sort = "";
                    str_Address2.Sort = "";
                    str_City.Sort = "";
                    int_State.Sort = "";
                    str_Zip.Sort = "";
                    str_County.Sort = "";
                    str_Manager.Sort = "";
                    str_Phone_Main.Sort = "";
                    str_Phone_Fax.Sort = "";
                    str_Phone_Other.Sort = "";
                    str_Notes.Sort = "";
                    str_Coverage_Code.Sort = "";
                    int_Status.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    bit_IsDeleted.Sort = "";
                    str_LocCapacity.Sort = "";
                    str_ContactEmail.Sort = "";
                    str_SchoolHours.Sort = "";
                    str_EmerName.Sort = "";
                    str_EmerPhone.Sort = "";
                    str_Room.Sort = "";
                    str_Email_Content.Sort = "";
                    bit_appointmentColor.Sort = "";
                    str_appointmentColorCode.Sort = "";
                    isKnowledgeTest.Sort = "";
                    isRoadTest.Sort = "";
                    dec_Latitude.Sort = "";
                    dec_Longitude.Sort = "";
                    str_nameAr.Sort = "";
                    IsDistanceBasedScheduling.Sort = "";
                    str_ZoomEmail.Sort = "";
                    str_ProviderLocationId.Sort = "";
                    int_RoadDistanceCoverage.Sort = "";
                    IsCashDrawer.Sort = "";
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblLocationlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblLocationlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(int_Location_Id.CurrentValue) + "\"></div>");
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
            option = options["addedit"];

            // Add
            item = option.Add("add");
            string addTitle = Language.Phrase("AddLink", true);
            if (ModalAdd && !IsMobile())
                item.Body = $@"<a class=""ew-add-edit ew-add"" title=""{addTitle}"" data-table=""tblLocation"" data-caption=""{addTitle}"" data-ew-action=""modal"" data-action=""add"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(AddUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("AddLink") + "</a>";
            else
                item.Body = $@"<a class=""ew-add-edit ew-add"" title=""{addTitle}"" data-caption=""{addTitle}"" href=""" + HtmlEncode(AppPath(AddUrl)) + "\">" + Language.Phrase("AddLink") + "</a>";
            item.Visible = AddUrl != "" && Security.CanAdd;
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblLocationlist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblLocationsrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblLocationsrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblLocationlist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                    RowAttrs.Add("id", "r0_tblLocation");
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblLocationList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblLocationList.RowCount) + "_tblLocation");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblLocationList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblLocationList.RowType == RowType.Add || IsEdit && tblLocationList.RowType == RowType.Edit) // Inline-Add/Edit row
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
            int_Location_Id.SetDbValue(row["int_Location_Id"]);
            str_Name.SetDbValue(row["str_Name"]);
            str_Code.SetDbValue(row["str_Code"]);
            str_Location_Type.SetDbValue(row["str_Location_Type"]);
            str_Address1.SetDbValue(row["str_Address1"]);
            str_Address2.SetDbValue(row["str_Address2"]);
            str_City.SetDbValue(row["str_City"]);
            int_State.SetDbValue(row["int_State"]);
            str_Zip.SetDbValue(row["str_Zip"]);
            str_County.SetDbValue(row["str_County"]);
            str_Manager.SetDbValue(row["str_Manager"]);
            str_Phone_Main.SetDbValue(row["str_Phone_Main"]);
            str_Phone_Fax.SetDbValue(row["str_Phone_Fax"]);
            str_Phone_Other.SetDbValue(row["str_Phone_Other"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            str_Coverage_Code.SetDbValue(row["str_Coverage_Code"]);
            int_Status.SetDbValue(row["int_Status"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_LocCapacity.SetDbValue(row["str_LocCapacity"]);
            str_ContactEmail.SetDbValue(row["str_ContactEmail"]);
            str_SchoolHours.SetDbValue(row["str_SchoolHours"]);
            str_EmerName.SetDbValue(row["str_EmerName"]);
            str_EmerPhone.SetDbValue(row["str_EmerPhone"]);
            str_Room.SetDbValue(row["str_Room"]);
            str_Email_Content.SetDbValue(row["str_Email_Content"]);
            bit_appointmentColor.SetDbValue((ConvertToBool(row["bit_appointmentColor"]) ? "1" : "0"));
            str_appointmentColorCode.SetDbValue(row["str_appointmentColorCode"]);
            isKnowledgeTest.SetDbValue((ConvertToBool(row["isKnowledgeTest"]) ? "1" : "0"));
            isRoadTest.SetDbValue((ConvertToBool(row["isRoadTest"]) ? "1" : "0"));
            dec_Latitude.SetDbValue(IsNull(row["dec_Latitude"]) ? DbNullValue : ConvertToDouble(row["dec_Latitude"]));
            dec_Longitude.SetDbValue(IsNull(row["dec_Longitude"]) ? DbNullValue : ConvertToDouble(row["dec_Longitude"]));
            str_nameAr.SetDbValue(row["str_nameAr"]);
            IsDistanceBasedScheduling.SetDbValue(row["IsDistanceBasedScheduling"]);
            str_ZoomEmail.SetDbValue(row["str_ZoomEmail"]);
            str_ProviderLocationId.SetDbValue(row["str_ProviderLocationId"]);
            int_RoadDistanceCoverage.SetDbValue(row["int_RoadDistanceCoverage"]);
            IsCashDrawer.SetDbValue(row["IsCashDrawer"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Location_Id", int_Location_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Name", str_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Code", str_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Location_Type", str_Location_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Address1", str_Address1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Address2", str_Address2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_City", str_City.DefaultValue ?? DbNullValue); // DN
            row.Add("int_State", int_State.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Zip", str_Zip.DefaultValue ?? DbNullValue); // DN
            row.Add("str_County", str_County.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Manager", str_Manager.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Phone_Main", str_Phone_Main.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Phone_Fax", str_Phone_Fax.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Phone_Other", str_Phone_Other.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Coverage_Code", str_Coverage_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_LocCapacity", str_LocCapacity.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ContactEmail", str_ContactEmail.DefaultValue ?? DbNullValue); // DN
            row.Add("str_SchoolHours", str_SchoolHours.DefaultValue ?? DbNullValue); // DN
            row.Add("str_EmerName", str_EmerName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_EmerPhone", str_EmerPhone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Room", str_Room.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email_Content", str_Email_Content.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_appointmentColor", bit_appointmentColor.DefaultValue ?? DbNullValue); // DN
            row.Add("str_appointmentColorCode", str_appointmentColorCode.DefaultValue ?? DbNullValue); // DN
            row.Add("isKnowledgeTest", isKnowledgeTest.DefaultValue ?? DbNullValue); // DN
            row.Add("isRoadTest", isRoadTest.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Latitude", dec_Latitude.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Longitude", dec_Longitude.DefaultValue ?? DbNullValue); // DN
            row.Add("str_nameAr", str_nameAr.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDistanceBasedScheduling", IsDistanceBasedScheduling.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ZoomEmail", str_ZoomEmail.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ProviderLocationId", str_ProviderLocationId.DefaultValue ?? DbNullValue); // DN
            row.Add("int_RoadDistanceCoverage", int_RoadDistanceCoverage.DefaultValue ?? DbNullValue); // DN
            row.Add("IsCashDrawer", IsCashDrawer.DefaultValue ?? DbNullValue); // DN
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

            // int_Location_Id

            // str_Name

            // str_Code

            // str_Location_Type

            // str_Address1

            // str_Address2

            // str_City

            // int_State

            // str_Zip

            // str_County

            // str_Manager

            // str_Phone_Main

            // str_Phone_Fax

            // str_Phone_Other

            // str_Notes

            // str_Coverage_Code

            // int_Status

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By

            // bit_IsDeleted

            // str_LocCapacity

            // str_ContactEmail

            // str_SchoolHours

            // str_EmerName

            // str_EmerPhone

            // str_Room

            // str_Email_Content

            // bit_appointmentColor

            // str_appointmentColorCode

            // isKnowledgeTest

            // isRoadTest

            // dec_Latitude

            // dec_Longitude

            // str_nameAr

            // IsDistanceBasedScheduling

            // str_ZoomEmail

            // str_ProviderLocationId

            // int_RoadDistanceCoverage

            // IsCashDrawer

            // View row
            if (RowType == RowType.View) {
                // int_Location_Id
                listWrk = new List<object?>();
                listWrk.Add(int_Location_Id.CurrentValue); // DN
                listWrk.Add(int_Location_Id.CurrentValue);
                listWrk.Add(str_Name.CurrentValue);
                listWrk = int_Location_Id.Lookup?.RenderViewRow(listWrk, this);
                dispVal = int_Location_Id.DisplayValue(listWrk);
                if (!Empty(dispVal))
                    int_Location_Id.ViewValue = dispVal;
                int_Location_Id.ViewCustomAttributes = "";

                // str_Name
                str_Name.ViewValue = ConvertToString(str_Name.CurrentValue); // DN
                str_Name.ViewCustomAttributes = "";

                // str_Code
                str_Code.ViewValue = ConvertToString(str_Code.CurrentValue); // DN
                str_Code.ViewCustomAttributes = "";

                // str_Location_Type
                str_Location_Type.ViewValue = ConvertToString(str_Location_Type.CurrentValue); // DN
                str_Location_Type.ViewCustomAttributes = "";

                // str_Address1
                str_Address1.ViewValue = ConvertToString(str_Address1.CurrentValue); // DN
                str_Address1.ViewCustomAttributes = "";

                // str_Address2
                str_Address2.ViewValue = ConvertToString(str_Address2.CurrentValue); // DN
                str_Address2.ViewCustomAttributes = "";

                // str_City
                str_City.ViewValue = ConvertToString(str_City.CurrentValue); // DN
                str_City.ViewCustomAttributes = "";

                // int_State
                int_State.ViewValue = int_State.CurrentValue;
                int_State.ViewValue = FormatNumber(int_State.ViewValue, int_State.FormatPattern);
                int_State.ViewCustomAttributes = "";

                // str_Zip
                str_Zip.ViewValue = ConvertToString(str_Zip.CurrentValue); // DN
                str_Zip.ViewCustomAttributes = "";

                // str_County
                str_County.ViewValue = ConvertToString(str_County.CurrentValue); // DN
                str_County.ViewCustomAttributes = "";

                // str_Manager
                str_Manager.ViewValue = ConvertToString(str_Manager.CurrentValue); // DN
                str_Manager.ViewCustomAttributes = "";

                // str_Phone_Main
                str_Phone_Main.ViewValue = ConvertToString(str_Phone_Main.CurrentValue); // DN
                str_Phone_Main.ViewCustomAttributes = "";

                // str_Phone_Fax
                str_Phone_Fax.ViewValue = ConvertToString(str_Phone_Fax.CurrentValue); // DN
                str_Phone_Fax.ViewCustomAttributes = "";

                // str_Phone_Other
                str_Phone_Other.ViewValue = ConvertToString(str_Phone_Other.CurrentValue); // DN
                str_Phone_Other.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // date_Modified
                date_Modified.ViewValue = date_Modified.CurrentValue;
                date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
                date_Modified.ViewCustomAttributes = "";

                // int_Created_By
                int_Created_By.ViewValue = int_Created_By.CurrentValue;
                int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
                int_Created_By.ViewCustomAttributes = "";

                // int_Modified_By
                int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
                int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
                int_Modified_By.ViewCustomAttributes = "";

                // bit_IsDeleted
                if (ConvertToBool(bit_IsDeleted.CurrentValue)) {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
                } else {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(2) != "" ? bit_IsDeleted.TagCaption(2) : "No";
                }
                bit_IsDeleted.ViewCustomAttributes = "";

                // str_LocCapacity
                str_LocCapacity.ViewValue = ConvertToString(str_LocCapacity.CurrentValue); // DN
                str_LocCapacity.ViewCustomAttributes = "";

                // str_ContactEmail
                str_ContactEmail.ViewValue = ConvertToString(str_ContactEmail.CurrentValue); // DN
                str_ContactEmail.ViewCustomAttributes = "";

                // str_SchoolHours
                str_SchoolHours.ViewValue = ConvertToString(str_SchoolHours.CurrentValue); // DN
                str_SchoolHours.ViewCustomAttributes = "";

                // str_EmerName
                str_EmerName.ViewValue = ConvertToString(str_EmerName.CurrentValue); // DN
                str_EmerName.ViewCustomAttributes = "";

                // str_EmerPhone
                str_EmerPhone.ViewValue = ConvertToString(str_EmerPhone.CurrentValue); // DN
                str_EmerPhone.ViewCustomAttributes = "";

                // str_Room
                str_Room.ViewValue = ConvertToString(str_Room.CurrentValue); // DN
                str_Room.ViewCustomAttributes = "";

                // str_Email_Content
                str_Email_Content.ViewValue = ConvertToString(str_Email_Content.CurrentValue); // DN
                str_Email_Content.ViewCustomAttributes = "";

                // bit_appointmentColor
                if (ConvertToBool(bit_appointmentColor.CurrentValue)) {
                    bit_appointmentColor.ViewValue = bit_appointmentColor.TagCaption(1) != "" ? bit_appointmentColor.TagCaption(1) : "Yes";
                } else {
                    bit_appointmentColor.ViewValue = bit_appointmentColor.TagCaption(2) != "" ? bit_appointmentColor.TagCaption(2) : "No";
                }
                bit_appointmentColor.ViewCustomAttributes = "";

                // str_appointmentColorCode
                str_appointmentColorCode.ViewValue = ConvertToString(str_appointmentColorCode.CurrentValue); // DN
                str_appointmentColorCode.ViewCustomAttributes = "";

                // isKnowledgeTest
                if (ConvertToBool(isKnowledgeTest.CurrentValue)) {
                    isKnowledgeTest.ViewValue = isKnowledgeTest.TagCaption(1) != "" ? isKnowledgeTest.TagCaption(1) : "Yes";
                } else {
                    isKnowledgeTest.ViewValue = isKnowledgeTest.TagCaption(2) != "" ? isKnowledgeTest.TagCaption(2) : "No";
                }
                isKnowledgeTest.ViewCustomAttributes = "";

                // isRoadTest
                if (ConvertToBool(isRoadTest.CurrentValue)) {
                    isRoadTest.ViewValue = isRoadTest.TagCaption(1) != "" ? isRoadTest.TagCaption(1) : "Yes";
                } else {
                    isRoadTest.ViewValue = isRoadTest.TagCaption(2) != "" ? isRoadTest.TagCaption(2) : "No";
                }
                isRoadTest.ViewCustomAttributes = "";

                // dec_Latitude
                dec_Latitude.ViewValue = dec_Latitude.CurrentValue;
                dec_Latitude.ViewValue = FormatNumber(dec_Latitude.ViewValue, dec_Latitude.FormatPattern);
                dec_Latitude.ViewCustomAttributes = "";

                // dec_Longitude
                dec_Longitude.ViewValue = dec_Longitude.CurrentValue;
                dec_Longitude.ViewValue = FormatNumber(dec_Longitude.ViewValue, dec_Longitude.FormatPattern);
                dec_Longitude.ViewCustomAttributes = "";

                // str_nameAr
                str_nameAr.ViewValue = ConvertToString(str_nameAr.CurrentValue); // DN
                str_nameAr.ViewCustomAttributes = "";

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.ViewValue = IsDistanceBasedScheduling.CurrentValue;
                IsDistanceBasedScheduling.ViewValue = FormatNumber(IsDistanceBasedScheduling.ViewValue, IsDistanceBasedScheduling.FormatPattern);
                IsDistanceBasedScheduling.ViewCustomAttributes = "";

                // str_ZoomEmail
                str_ZoomEmail.ViewValue = ConvertToString(str_ZoomEmail.CurrentValue); // DN
                str_ZoomEmail.ViewCustomAttributes = "";

                // str_ProviderLocationId
                str_ProviderLocationId.ViewValue = ConvertToString(str_ProviderLocationId.CurrentValue); // DN
                str_ProviderLocationId.ViewCustomAttributes = "";

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.ViewValue = int_RoadDistanceCoverage.CurrentValue;
                int_RoadDistanceCoverage.ViewValue = FormatNumber(int_RoadDistanceCoverage.ViewValue, int_RoadDistanceCoverage.FormatPattern);
                int_RoadDistanceCoverage.ViewCustomAttributes = "";

                // IsCashDrawer
                IsCashDrawer.ViewValue = IsCashDrawer.CurrentValue;
                IsCashDrawer.ViewValue = FormatNumber(IsCashDrawer.ViewValue, IsCashDrawer.FormatPattern);
                IsCashDrawer.ViewCustomAttributes = "";

                // int_Location_Id
                int_Location_Id.HrefValue = "";
                int_Location_Id.TooltipValue = "";

                // str_Name
                str_Name.HrefValue = "";
                str_Name.TooltipValue = "";

                // str_Code
                str_Code.HrefValue = "";
                str_Code.TooltipValue = "";

                // str_Location_Type
                str_Location_Type.HrefValue = "";
                str_Location_Type.TooltipValue = "";

                // str_Address1
                str_Address1.HrefValue = "";
                str_Address1.TooltipValue = "";

                // str_Address2
                str_Address2.HrefValue = "";
                str_Address2.TooltipValue = "";

                // str_City
                str_City.HrefValue = "";
                str_City.TooltipValue = "";

                // int_State
                int_State.HrefValue = "";
                int_State.TooltipValue = "";

                // str_Zip
                str_Zip.HrefValue = "";
                str_Zip.TooltipValue = "";

                // str_County
                str_County.HrefValue = "";
                str_County.TooltipValue = "";

                // str_Manager
                str_Manager.HrefValue = "";
                str_Manager.TooltipValue = "";

                // str_Phone_Main
                str_Phone_Main.HrefValue = "";
                str_Phone_Main.TooltipValue = "";

                // str_Phone_Fax
                str_Phone_Fax.HrefValue = "";
                str_Phone_Fax.TooltipValue = "";

                // str_Phone_Other
                str_Phone_Other.HrefValue = "";
                str_Phone_Other.TooltipValue = "";

                // str_Notes
                str_Notes.HrefValue = "";
                str_Notes.TooltipValue = "";

                // int_Status
                int_Status.HrefValue = "";
                int_Status.TooltipValue = "";

                // date_Created
                date_Created.HrefValue = "";
                date_Created.TooltipValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";
                int_Created_By.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";
                int_Modified_By.TooltipValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";
                bit_IsDeleted.TooltipValue = "";

                // str_LocCapacity
                str_LocCapacity.HrefValue = "";
                str_LocCapacity.TooltipValue = "";

                // str_ContactEmail
                str_ContactEmail.HrefValue = "";
                str_ContactEmail.TooltipValue = "";

                // str_SchoolHours
                str_SchoolHours.HrefValue = "";
                str_SchoolHours.TooltipValue = "";

                // str_EmerName
                str_EmerName.HrefValue = "";
                str_EmerName.TooltipValue = "";

                // str_EmerPhone
                str_EmerPhone.HrefValue = "";
                str_EmerPhone.TooltipValue = "";

                // str_Room
                str_Room.HrefValue = "";
                str_Room.TooltipValue = "";

                // str_Email_Content
                str_Email_Content.HrefValue = "";
                str_Email_Content.TooltipValue = "";

                // bit_appointmentColor
                bit_appointmentColor.HrefValue = "";
                bit_appointmentColor.TooltipValue = "";

                // str_appointmentColorCode
                str_appointmentColorCode.HrefValue = "";
                str_appointmentColorCode.TooltipValue = "";

                // isKnowledgeTest
                isKnowledgeTest.HrefValue = "";
                isKnowledgeTest.TooltipValue = "";

                // isRoadTest
                isRoadTest.HrefValue = "";
                isRoadTest.TooltipValue = "";

                // dec_Latitude
                dec_Latitude.HrefValue = "";
                dec_Latitude.TooltipValue = "";

                // dec_Longitude
                dec_Longitude.HrefValue = "";
                dec_Longitude.TooltipValue = "";

                // str_nameAr
                str_nameAr.HrefValue = "";
                str_nameAr.TooltipValue = "";

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.HrefValue = "";
                IsDistanceBasedScheduling.TooltipValue = "";

                // str_ZoomEmail
                str_ZoomEmail.HrefValue = "";
                str_ZoomEmail.TooltipValue = "";

                // str_ProviderLocationId
                str_ProviderLocationId.HrefValue = "";
                str_ProviderLocationId.TooltipValue = "";

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.HrefValue = "";
                int_RoadDistanceCoverage.TooltipValue = "";

                // IsCashDrawer
                IsCashDrawer.HrefValue = "";
                IsCashDrawer.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblLocationlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblLocationlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblLocationlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblLocationlist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblLocationsrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
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
