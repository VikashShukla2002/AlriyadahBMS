namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblCrAttendanceList
    /// </summary>
    public static TblCrAttendanceList tblCrAttendanceList
    {
        get => HttpData.Get<TblCrAttendanceList>("tblCrAttendanceList")!;
        set => HttpData["tblCrAttendanceList"] = value;
    }

    /// <summary>
    /// Page class for tblCRAttendance
    /// </summary>
    public class TblCrAttendanceList : TblCrAttendanceListBase
    {
        // Constructor
        public TblCrAttendanceList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblCrAttendanceList() : base()
        {
        }

        // Page Data Rendering event
        public override void PageDataRendering(ref string header) {
            header = $"<p class='text-end'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{CurrentUserName()}</span></p>";
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblCrAttendanceListBase : TblCrAttendance
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblCRAttendance";

        // Page object name
        public string PageObjName = "tblCrAttendanceList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblCRAttendancelist";

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
        public TblCrAttendanceListBase()
        {
            // CSS class name as context
            TableVar = "tblCRAttendance";
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

            // Table object (tblCrAttendance)
            if (tblCrAttendance == null || tblCrAttendance is TblCrAttendance)
                tblCrAttendance = this;

            // Initialize URLs
            AddUrl = "TblCrAttendanceAdd?" + Config.TableShowDetail + "=";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblCrAttendanceDelete";
            MultiUpdateUrl = "TblCrAttendanceUpdate";

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
        public string PageName => "TblCrAttendanceList";

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
            int_Attendance_ID.Visible = false;
            int_Student_ID.Visible = false;
            str_FullName.SetVisibility();
            str_Username.SetVisibility();
            int_CR_ID.SetVisibility();
            int_CRSession_ID.SetVisibility();
            Is_All_Attend.SetVisibility();
            idnumber.SetVisibility();
            course_id.Visible = false;
            str_Test_Score.Visible = false;
            str_Notes.Visible = false;
            bit_IsDeleted.Visible = false;
            int_Created_BY.Visible = false;
            int_Modified_BY.Visible = false;
            date_Created.Visible = false;
            date_Modified.Visible = false;
            bit_IsMakeUP.SetVisibility();
            dec_Orginal_SessionID.Visible = false;
            dec_CR_ID_For_Del.Visible = false;
            int_Session_ID_For_Del.Visible = false;
            RemM1.SetVisibility();
            RemM2.Visible = false;
            RemM3.Visible = false;
            studentSignature.Visible = false;
            SMSReminder1.SetVisibility();
            SMSReminder2.Visible = false;
            SMSReminder3.Visible = false;
            VoiceReminder1.Visible = false;
            VoiceReminder2.Visible = false;
            VoiceReminder3.Visible = false;
            strParentName.Visible = false;
            strParentState.Visible = false;
            strParentLicenseNumber.Visible = false;
            CRSS_ID.Visible = false;
            str_CR_Number.Visible = false;
        }

        // Constructor
        public TblCrAttendanceListBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblCrAttendanceView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Attendance_ID") ? dict["int_Attendance_ID"] : int_Attendance_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Attendance_ID.Visible = false;
            if (IsAddOrEdit)
                int_Modified_BY.Visible = false;
            if (IsAddOrEdit)
                date_Modified.Visible = false;
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

        public string HashValue = ""; // Hash Value

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

            // Create form object
            CurrentForm ??= new ();
            await CurrentForm.Init();

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
            await SetupLookupOptions(str_Username);
            await SetupLookupOptions(Is_All_Attend);
            await SetupLookupOptions(idnumber);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_IsMakeUP);
            await SetupLookupOptions(RemM1);
            await SetupLookupOptions(RemM2);
            await SetupLookupOptions(RemM3);
            await SetupLookupOptions(SMSReminder1);
            await SetupLookupOptions(SMSReminder2);
            await SetupLookupOptions(SMSReminder3);
            await SetupLookupOptions(VoiceReminder1);
            await SetupLookupOptions(VoiceReminder2);
            await SetupLookupOptions(VoiceReminder3);
            await SetupLookupOptions(str_CR_Number);

            // Load default values for add
            LoadDefaultValues();

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblCRAttendancegrid";

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
            StringValues sv;

            // Check QueryString parameters
            if (Get("action", out sv)) {
                CurrentAction = sv.ToString();
            } else {
                if (Post("action", out sv)) {
                    if (sv.ToString() != UserAction)
                        CurrentAction = sv.ToString(); // Get action
                } else if (SameString(Session[Config.SessionInlineMode], "gridedit")) { // Previously in grid edit mode
                    if (Query.ContainsKey(Config.TableStartRec) || Query.ContainsKey(Config.TablePageNumber)) // Stay in grid edit mode if paging
                        GridEditMode();
                    else // Reset grid edit
                        ClearInlineMode();
                }
            }

            // Clear inline mode
            if (IsCancel)
                ClearInlineMode();

            // Switch to grid edit mode
            if (IsGridEdit)
                GridEditMode();
            var gridUpdate = false;
            // Grid Update
            if (IsPost() && (IsGridUpdate || IsMultiUpdate || IsGridOverwrite) && (SameString(Session[Config.SessionInlineMode], "gridedit") || SameString(Session[Config.SessionInlineMode], "multiedit"))) {
                if (await ValidateGridForm()) {
                    gridUpdate = await GridUpdate();
                } else {
                    gridUpdate = false;
                }
                if (gridUpdate) {
                    // Handle modal grid edit and multi edit, redirect to list page directly
                    if (IsModal && !UseAjaxActions)
                        return Terminate("TblCrAttendanceList");
                } else {
                    EventCancelled = true;
                    if (UseAjaxActions) {
                        if (IsModal)
                            AddHeader("Modal-Error", "?1");
                        else
                            return Controller.Json(new { success = false, error = GetFailureMessage() });
                    }
                    if (IsMultiUpdate) { // Stay in Multi-Edit mode
                        var records = GetGridFormValues().Select(row => row.ToDictionary(kvp => kvp.Key, kvp => (object)(kvp.Value ?? "")));
                        FilterForModalActions = GetFilterFromRecords(records);
                    } else { // Stay in grid edit mode
                        GridEditMode();
                    }
                }
            }

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

            // Show grid delete link for grid add / grid edit
            if (AllowAddDeleteRow) {
                if (IsGridAdd || IsGridEdit) {
                    var item = ListOptions["griddelete"];
                    if (item != null)
                        item.Visible = false;
                }
            }

            // Get default search criteria
            AddFilter(ref DefaultSearchWhere, BasicSearchWhere(true));
            AddFilter(ref DefaultSearchWhere, AdvancedSearchWhere(true));

            // Get basic search values
            LoadBasicSearchValues();

            // Get and validate search values for advanced search
            if (Empty(UserAction)) // Skip if user action
                LoadSearchValues(); // Get search values

            // Process filter list
            var filterResult = await ProcessFilterList();
            if (filterResult != null) {
                // Clean output buffer
                if (!Config.Debug)
                    Response?.Clear();
                return Controller.Json(filterResult);
            }
            CurrentForm?.ResetIndex();
            if (!ValidateSearch()) {
                // Nothing to do
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

            // Get search criteria for advanced search
            if (!HasInvalidFields())
                srchAdvanced = AdvancedSearchWhere();

            // Get query builder criteria
            query = QueryBuilderWhere();

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

                // Load advanced search from default
                if (LoadAdvancedSearchDefault())
                    srchAdvanced = AdvancedSearchWhere(); // Save to session
            }

            // Restore search settings from Session
            if (!HasInvalidFields())
                LoadAdvancedSearch();

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
                tblCrAttendanceList?.PageRender();
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

        // Exit inline mode
        protected void ClearInlineMode() {
            LastAction = CurrentAction; // Save last action
            CurrentAction = ""; // Clear action
            Session[Config.SessionInlineMode] = ""; // Clear inline mode
        }

        // Switch to grid edit mode
        protected void GridEditMode() {
            CurrentAction = "gridedit";
            Session[Config.SessionInlineMode] = "gridedit"; // Enabled grid edit
            HideFieldsForAddEdit();
        }

        // Perform update to grid
        public async Task<bool> GridUpdate()
        {
            bool gridUpdate = true;

            // Get old recordset
            CurrentFilter = BuildKeyFilter();
            if (Empty(CurrentFilter))
                CurrentFilter = "0=1";
            string sql = CurrentSql;
            List<Dictionary<string, object>> rsold = await Connection.GetRowsAsync(sql);

            // Call Grid Updating event
            if (!GridUpdating(rsold)) {
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("GridEditCancelled"); // Set grid edit cancelled message
                EventCancelled = true;
                return false;
            }

            // Begin transaction
            if (UseTransaction)
                Connection.BeginTrans();
            if (AuditTrailOnEdit) await WriteAuditTrailLog(Language.Phrase("BatchUpdateBegin")); // Batch update begin
            string wrkFilter = "";
            string key = "";

            // Update row index and get row key
            CurrentForm?.ResetIndex();
            int rowcnt = CurrentForm?.GetInt(FormKeyCountName) ?? 0;

            // Load default values for emptyRow checking // DN
            LoadDefaultValues();

            // Update all rows based on key
            try {
                for (int rowindex = 1; rowindex <= rowcnt; rowindex++) {
                    CurrentForm!.Index = rowindex;
                    SetKey(CurrentForm.GetValue(OldKeyName));
                    string rowaction = CurrentForm.GetValue(FormActionName);

                    // Load all values and keys
                    if (rowaction != "insertdelete" && rowaction != "hide") { // Skip insert then deleted rows / hidden rows for grid edit
                        await LoadFormValues(); // Get form values
                        if (Empty(rowaction) || rowaction == "edit" || rowaction == "delete") {
                            gridUpdate = !Empty(OldKey); // Key must not be empty
                        } else {
                            gridUpdate = true;
                        }

                        // Skip empty row
                        if (rowaction == "insert" && EmptyRow()) {
                            // No action required
                        } else if (gridUpdate) { // Validate form and insert/update/delete record
                            if (rowaction == "delete") {
                                CurrentFilter = GetRecordFilter();
                                gridUpdate = await DeleteRows(); // Delete this row
                            } else {
                                if (rowaction == "insert") {
                                    gridUpdate = await AddRow(); // Insert this row
                                } else {
                                    if (!Empty(OldKey)) {
                                        SendEmail = false; // Do not send email on update success
                                        gridUpdate = await EditRow(); // Update this row
                                    }
                                } // End update
                                if (gridUpdate) // Get inserted or updated filter
                                    AddFilter(ref wrkFilter, GetRecordFilter(), "OR");
                            }
                        }
                        if (gridUpdate) {
                            if (!Empty(key))
                                key += ", ";
                            key += OldKey;
                        } else {
                            EventCancelled = true;
                            break;
                        }
                    }
                }
            } catch (Exception e) {
                FailureMessage = e.Message;
                gridUpdate = false;
            }
            if (gridUpdate) {
                if (UseTransaction)
                    Connection.CommitTrans(); // Commit transaction
                FilterForModalActions = wrkFilter;

                // Get new recordset
                List<Dictionary<string, object>> rsnew = await Connection.GetRowsAsync(sql, true); // Use main connection (faster) // DN

                // Call Grid Updated event
                GridUpdated(rsold, rsnew);
                if (AuditTrailOnEdit)
                    await WriteAuditTrailLog(Language.Phrase("BatchUpdateSuccess")); // Batch update success
                if (Empty(SuccessMessage))
                    SuccessMessage = Language.Phrase("UpdateSuccess"); // Set up update success message
                ClearInlineMode(); // Clear inline edit mode
            } else {
                if (UseTransaction)
                    Connection.RollbackTrans(); // Rollback transaction
                if (AuditTrailOnEdit)
                    await WriteAuditTrailLog(Language.Phrase("BatchUpdateRollback")); // Batch update rollback
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("UpdateFailed"); // Set update failed message
            }
            return gridUpdate;
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
        public bool EmptyRow()
        {
            if (CurrentForm == null)
                return true;
            if (CurrentForm.HasValue("x_str_FullName") && CurrentForm.HasValue("o_str_FullName") && !SameString(str_FullName.CurrentValue, str_FullName.DefaultValue) &&
            !(str_FullName.IsForeignKey && CurrentMasterTable != "" && SameString(str_FullName.CurrentValue, str_FullName.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Username") && CurrentForm.HasValue("o_str_Username") && !SameString(str_Username.CurrentValue, str_Username.DefaultValue) &&
            !(str_Username.IsForeignKey && CurrentMasterTable != "" && SameString(str_Username.CurrentValue, str_Username.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_int_CR_ID") && CurrentForm.HasValue("o_int_CR_ID") && !SameString(int_CR_ID.CurrentValue, int_CR_ID.DefaultValue) &&
            !(int_CR_ID.IsForeignKey && CurrentMasterTable != "" && SameString(int_CR_ID.CurrentValue, int_CR_ID.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_int_CRSession_ID") && CurrentForm.HasValue("o_int_CRSession_ID") && !SameString(int_CRSession_ID.CurrentValue, int_CRSession_ID.DefaultValue) &&
            !(int_CRSession_ID.IsForeignKey && CurrentMasterTable != "" && SameString(int_CRSession_ID.CurrentValue, int_CRSession_ID.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_Is_All_Attend") && CurrentForm.HasValue("o_Is_All_Attend") && ConvertToBool(Is_All_Attend.CurrentValue) != ConvertToBool(Is_All_Attend.DefaultValue) &&
            !(Is_All_Attend.IsForeignKey && CurrentMasterTable != "" && ConvertToBool(Is_All_Attend.CurrentValue) == ConvertToBool(Is_All_Attend.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_idnumber") && CurrentForm.HasValue("o_idnumber") && !SameString(idnumber.CurrentValue, idnumber.DefaultValue) &&
            !(idnumber.IsForeignKey && CurrentMasterTable != "" && SameString(idnumber.CurrentValue, idnumber.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_bit_IsMakeUP") && CurrentForm.HasValue("o_bit_IsMakeUP") && ConvertToBool(bit_IsMakeUP.CurrentValue) != ConvertToBool(bit_IsMakeUP.DefaultValue) &&
            !(bit_IsMakeUP.IsForeignKey && CurrentMasterTable != "" && ConvertToBool(bit_IsMakeUP.CurrentValue) == ConvertToBool(bit_IsMakeUP.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_RemM1") && CurrentForm.HasValue("o_RemM1") && ConvertToBool(RemM1.CurrentValue) != ConvertToBool(RemM1.DefaultValue) &&
            !(RemM1.IsForeignKey && CurrentMasterTable != "" && ConvertToBool(RemM1.CurrentValue) == ConvertToBool(RemM1.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_SMSReminder1") && CurrentForm.HasValue("o_SMSReminder1") && ConvertToBool(SMSReminder1.CurrentValue) != ConvertToBool(SMSReminder1.DefaultValue) &&
            !(SMSReminder1.IsForeignKey && CurrentMasterTable != "" && ConvertToBool(SMSReminder1.CurrentValue) == ConvertToBool(SMSReminder1.SessionValue)))
                return false;
            return true;
        }

        // Validate grid form
        public async Task<bool> ValidateGridForm()
        {
            // Get row count
            CurrentForm?.ResetIndex();
            int rowcnt = CurrentForm?.GetInt(FormKeyCountName) ?? 0;

            // Load default values for emptyRow checking
            LoadDefaultValues();

            // Validate all records
            for (int rowindex = 1; rowindex <= rowcnt; rowindex++) {
                // Load current row values
                CurrentForm!.Index = rowindex;
                string rowaction = CurrentForm.GetValue(FormActionName);
                if (rowaction != "delete" && rowaction != "insertdelete" && rowaction != "hide") {
                    await LoadFormValues(); // Get form values
                    if (rowaction == "insert" && EmptyRow()) {
                        // Ignore
                    } else if (!await ValidateForm()) {
                        return false;
                    }
                }
            }
            return true;
        }

        // Get all form values of the grid
        public List<Dictionary<string, string?>> GetGridFormValues()
        {
            // Get row count
            CurrentForm?.ResetIndex();
            int rowcnt = CurrentForm?.GetInt(FormKeyCountName) ?? 0;
            List<Dictionary<string, string?>> rows = new ();

            // Loop through all records
            for (int rowindex = 1; rowindex <= rowcnt; rowindex++) {
                // Load current row values
                CurrentForm!.Index = rowindex;
                string rowaction = CurrentForm.GetValue(FormActionName);
                if (rowaction != "delete" && rowaction != "insertdelete") {
                    LoadFormValues().GetAwaiter().GetResult(); // Load form values (sync)
                    if (rowaction == "insert" && EmptyRow()) {
                        // Ignore
                    } else {
                        rows.Add(GetFormValues()); // Return row as array
                    }
                }
            }
            return rows; // Return as array of array
        }

        // Restore form values for current row
        public async Task RestoreCurrentRowFormValues(object index)
        {
            // Get row based on current index
            if (index is int idx)
                CurrentForm!.Index = idx;
            string rowaction = CurrentForm.GetValue(FormActionName);
            await LoadFormValues(); // Load form values
            // Set up invalid status correctly
            ResetFormError();
            if (rowaction == "insert" && EmptyRow()) {
                // Ignore
            } else {
                await ValidateForm();
            }
        }

        // Reset form status
        public void ResetFormError()
        {
            str_FullName.ClearErrorMessage();
            str_Username.ClearErrorMessage();
            int_CR_ID.ClearErrorMessage();
            int_CRSession_ID.ClearErrorMessage();
            Is_All_Attend.ClearErrorMessage();
            idnumber.ClearErrorMessage();
            bit_IsMakeUP.ClearErrorMessage();
            RemM1.ClearErrorMessage();
            SMSReminder1.ClearErrorMessage();
        }

        #pragma warning disable 162, 1998
        // Get list of filters
        public async Task<string> GetFilterList()
        {
            string filterList = "";
            string savedFilterList = "";

            // Load server side filters
            if (Config.SearchFilterOption == "Server")
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblCRAttendancesrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Attendance_ID.AdvancedSearch.ToJson())); // Field int_Attendance_ID
            filters.Merge(JObject.Parse(int_Student_ID.AdvancedSearch.ToJson())); // Field int_Student_ID
            filters.Merge(JObject.Parse(str_FullName.AdvancedSearch.ToJson())); // Field str_FullName
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(int_CR_ID.AdvancedSearch.ToJson())); // Field int_CR_ID
            filters.Merge(JObject.Parse(int_CRSession_ID.AdvancedSearch.ToJson())); // Field int_CRSession_ID
            filters.Merge(JObject.Parse(Is_All_Attend.AdvancedSearch.ToJson())); // Field Is_All_Attend
            filters.Merge(JObject.Parse(idnumber.AdvancedSearch.ToJson())); // Field idnumber
            filters.Merge(JObject.Parse(course_id.AdvancedSearch.ToJson())); // Field course_id
            filters.Merge(JObject.Parse(str_Test_Score.AdvancedSearch.ToJson())); // Field str_Test_Score
            filters.Merge(JObject.Parse(str_Notes.AdvancedSearch.ToJson())); // Field str_Notes
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(int_Created_BY.AdvancedSearch.ToJson())); // Field int_Created_BY
            filters.Merge(JObject.Parse(int_Modified_BY.AdvancedSearch.ToJson())); // Field int_Modified_BY
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(bit_IsMakeUP.AdvancedSearch.ToJson())); // Field bit_IsMakeUP
            filters.Merge(JObject.Parse(dec_Orginal_SessionID.AdvancedSearch.ToJson())); // Field dec_Orginal_SessionID
            filters.Merge(JObject.Parse(dec_CR_ID_For_Del.AdvancedSearch.ToJson())); // Field dec_CR_ID_For_Del
            filters.Merge(JObject.Parse(int_Session_ID_For_Del.AdvancedSearch.ToJson())); // Field int_Session_ID_For_Del
            filters.Merge(JObject.Parse(RemM1.AdvancedSearch.ToJson())); // Field RemM1
            filters.Merge(JObject.Parse(RemM2.AdvancedSearch.ToJson())); // Field RemM2
            filters.Merge(JObject.Parse(RemM3.AdvancedSearch.ToJson())); // Field RemM3
            filters.Merge(JObject.Parse(SMSReminder1.AdvancedSearch.ToJson())); // Field SMSReminder1
            filters.Merge(JObject.Parse(SMSReminder2.AdvancedSearch.ToJson())); // Field SMSReminder2
            filters.Merge(JObject.Parse(SMSReminder3.AdvancedSearch.ToJson())); // Field SMSReminder3
            filters.Merge(JObject.Parse(VoiceReminder1.AdvancedSearch.ToJson())); // Field VoiceReminder1
            filters.Merge(JObject.Parse(VoiceReminder2.AdvancedSearch.ToJson())); // Field VoiceReminder2
            filters.Merge(JObject.Parse(VoiceReminder3.AdvancedSearch.ToJson())); // Field VoiceReminder3
            filters.Merge(JObject.Parse(strParentName.AdvancedSearch.ToJson())); // Field strParentName
            filters.Merge(JObject.Parse(strParentState.AdvancedSearch.ToJson())); // Field strParentState
            filters.Merge(JObject.Parse(strParentLicenseNumber.AdvancedSearch.ToJson())); // Field strParentLicenseNumber
            filters.Merge(JObject.Parse(CRSS_ID.AdvancedSearch.ToJson())); // Field CRSS_ID
            filters.Merge(JObject.Parse(str_CR_Number.AdvancedSearch.ToJson())); // Field str_CR_Number
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblCRAttendancesrch", filters);
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

            // Field int_Attendance_ID
            if (filter?.TryGetValue("x_int_Attendance_ID", out sv) ?? false) {
                int_Attendance_ID.AdvancedSearch.SearchValue = sv;
                int_Attendance_ID.AdvancedSearch.SearchOperator = filter["z_int_Attendance_ID"];
                int_Attendance_ID.AdvancedSearch.SearchCondition = filter["v_int_Attendance_ID"];
                int_Attendance_ID.AdvancedSearch.SearchValue2 = filter["y_int_Attendance_ID"];
                int_Attendance_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Attendance_ID"];
                int_Attendance_ID.AdvancedSearch.Save();
            }

            // Field int_Student_ID
            if (filter?.TryGetValue("x_int_Student_ID", out sv) ?? false) {
                int_Student_ID.AdvancedSearch.SearchValue = sv;
                int_Student_ID.AdvancedSearch.SearchOperator = filter["z_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchCondition = filter["v_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchValue2 = filter["y_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Student_ID"];
                int_Student_ID.AdvancedSearch.Save();
            }

            // Field str_FullName
            if (filter?.TryGetValue("x_str_FullName", out sv) ?? false) {
                str_FullName.AdvancedSearch.SearchValue = sv;
                str_FullName.AdvancedSearch.SearchOperator = filter["z_str_FullName"];
                str_FullName.AdvancedSearch.SearchCondition = filter["v_str_FullName"];
                str_FullName.AdvancedSearch.SearchValue2 = filter["y_str_FullName"];
                str_FullName.AdvancedSearch.SearchOperator2 = filter["w_str_FullName"];
                str_FullName.AdvancedSearch.Save();
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

            // Field int_CR_ID
            if (filter?.TryGetValue("x_int_CR_ID", out sv) ?? false) {
                int_CR_ID.AdvancedSearch.SearchValue = sv;
                int_CR_ID.AdvancedSearch.SearchOperator = filter["z_int_CR_ID"];
                int_CR_ID.AdvancedSearch.SearchCondition = filter["v_int_CR_ID"];
                int_CR_ID.AdvancedSearch.SearchValue2 = filter["y_int_CR_ID"];
                int_CR_ID.AdvancedSearch.SearchOperator2 = filter["w_int_CR_ID"];
                int_CR_ID.AdvancedSearch.Save();
            }

            // Field int_CRSession_ID
            if (filter?.TryGetValue("x_int_CRSession_ID", out sv) ?? false) {
                int_CRSession_ID.AdvancedSearch.SearchValue = sv;
                int_CRSession_ID.AdvancedSearch.SearchOperator = filter["z_int_CRSession_ID"];
                int_CRSession_ID.AdvancedSearch.SearchCondition = filter["v_int_CRSession_ID"];
                int_CRSession_ID.AdvancedSearch.SearchValue2 = filter["y_int_CRSession_ID"];
                int_CRSession_ID.AdvancedSearch.SearchOperator2 = filter["w_int_CRSession_ID"];
                int_CRSession_ID.AdvancedSearch.Save();
            }

            // Field Is_All_Attend
            if (filter?.TryGetValue("x_Is_All_Attend", out sv) ?? false) {
                Is_All_Attend.AdvancedSearch.SearchValue = sv;
                Is_All_Attend.AdvancedSearch.SearchOperator = filter["z_Is_All_Attend"];
                Is_All_Attend.AdvancedSearch.SearchCondition = filter["v_Is_All_Attend"];
                Is_All_Attend.AdvancedSearch.SearchValue2 = filter["y_Is_All_Attend"];
                Is_All_Attend.AdvancedSearch.SearchOperator2 = filter["w_Is_All_Attend"];
                Is_All_Attend.AdvancedSearch.Save();
            }

            // Field idnumber
            if (filter?.TryGetValue("x_idnumber", out sv) ?? false) {
                idnumber.AdvancedSearch.SearchValue = sv;
                idnumber.AdvancedSearch.SearchOperator = filter["z_idnumber"];
                idnumber.AdvancedSearch.SearchCondition = filter["v_idnumber"];
                idnumber.AdvancedSearch.SearchValue2 = filter["y_idnumber"];
                idnumber.AdvancedSearch.SearchOperator2 = filter["w_idnumber"];
                idnumber.AdvancedSearch.Save();
            }

            // Field course_id
            if (filter?.TryGetValue("x_course_id", out sv) ?? false) {
                course_id.AdvancedSearch.SearchValue = sv;
                course_id.AdvancedSearch.SearchOperator = filter["z_course_id"];
                course_id.AdvancedSearch.SearchCondition = filter["v_course_id"];
                course_id.AdvancedSearch.SearchValue2 = filter["y_course_id"];
                course_id.AdvancedSearch.SearchOperator2 = filter["w_course_id"];
                course_id.AdvancedSearch.Save();
            }

            // Field str_Test_Score
            if (filter?.TryGetValue("x_str_Test_Score", out sv) ?? false) {
                str_Test_Score.AdvancedSearch.SearchValue = sv;
                str_Test_Score.AdvancedSearch.SearchOperator = filter["z_str_Test_Score"];
                str_Test_Score.AdvancedSearch.SearchCondition = filter["v_str_Test_Score"];
                str_Test_Score.AdvancedSearch.SearchValue2 = filter["y_str_Test_Score"];
                str_Test_Score.AdvancedSearch.SearchOperator2 = filter["w_str_Test_Score"];
                str_Test_Score.AdvancedSearch.Save();
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

            // Field bit_IsDeleted
            if (filter?.TryGetValue("x_bit_IsDeleted", out sv) ?? false) {
                bit_IsDeleted.AdvancedSearch.SearchValue = sv;
                bit_IsDeleted.AdvancedSearch.SearchOperator = filter["z_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchCondition = filter["v_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchValue2 = filter["y_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchOperator2 = filter["w_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.Save();
            }

            // Field int_Created_BY
            if (filter?.TryGetValue("x_int_Created_BY", out sv) ?? false) {
                int_Created_BY.AdvancedSearch.SearchValue = sv;
                int_Created_BY.AdvancedSearch.SearchOperator = filter["z_int_Created_BY"];
                int_Created_BY.AdvancedSearch.SearchCondition = filter["v_int_Created_BY"];
                int_Created_BY.AdvancedSearch.SearchValue2 = filter["y_int_Created_BY"];
                int_Created_BY.AdvancedSearch.SearchOperator2 = filter["w_int_Created_BY"];
                int_Created_BY.AdvancedSearch.Save();
            }

            // Field int_Modified_BY
            if (filter?.TryGetValue("x_int_Modified_BY", out sv) ?? false) {
                int_Modified_BY.AdvancedSearch.SearchValue = sv;
                int_Modified_BY.AdvancedSearch.SearchOperator = filter["z_int_Modified_BY"];
                int_Modified_BY.AdvancedSearch.SearchCondition = filter["v_int_Modified_BY"];
                int_Modified_BY.AdvancedSearch.SearchValue2 = filter["y_int_Modified_BY"];
                int_Modified_BY.AdvancedSearch.SearchOperator2 = filter["w_int_Modified_BY"];
                int_Modified_BY.AdvancedSearch.Save();
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

            // Field bit_IsMakeUP
            if (filter?.TryGetValue("x_bit_IsMakeUP", out sv) ?? false) {
                bit_IsMakeUP.AdvancedSearch.SearchValue = sv;
                bit_IsMakeUP.AdvancedSearch.SearchOperator = filter["z_bit_IsMakeUP"];
                bit_IsMakeUP.AdvancedSearch.SearchCondition = filter["v_bit_IsMakeUP"];
                bit_IsMakeUP.AdvancedSearch.SearchValue2 = filter["y_bit_IsMakeUP"];
                bit_IsMakeUP.AdvancedSearch.SearchOperator2 = filter["w_bit_IsMakeUP"];
                bit_IsMakeUP.AdvancedSearch.Save();
            }

            // Field dec_Orginal_SessionID
            if (filter?.TryGetValue("x_dec_Orginal_SessionID", out sv) ?? false) {
                dec_Orginal_SessionID.AdvancedSearch.SearchValue = sv;
                dec_Orginal_SessionID.AdvancedSearch.SearchOperator = filter["z_dec_Orginal_SessionID"];
                dec_Orginal_SessionID.AdvancedSearch.SearchCondition = filter["v_dec_Orginal_SessionID"];
                dec_Orginal_SessionID.AdvancedSearch.SearchValue2 = filter["y_dec_Orginal_SessionID"];
                dec_Orginal_SessionID.AdvancedSearch.SearchOperator2 = filter["w_dec_Orginal_SessionID"];
                dec_Orginal_SessionID.AdvancedSearch.Save();
            }

            // Field dec_CR_ID_For_Del
            if (filter?.TryGetValue("x_dec_CR_ID_For_Del", out sv) ?? false) {
                dec_CR_ID_For_Del.AdvancedSearch.SearchValue = sv;
                dec_CR_ID_For_Del.AdvancedSearch.SearchOperator = filter["z_dec_CR_ID_For_Del"];
                dec_CR_ID_For_Del.AdvancedSearch.SearchCondition = filter["v_dec_CR_ID_For_Del"];
                dec_CR_ID_For_Del.AdvancedSearch.SearchValue2 = filter["y_dec_CR_ID_For_Del"];
                dec_CR_ID_For_Del.AdvancedSearch.SearchOperator2 = filter["w_dec_CR_ID_For_Del"];
                dec_CR_ID_For_Del.AdvancedSearch.Save();
            }

            // Field int_Session_ID_For_Del
            if (filter?.TryGetValue("x_int_Session_ID_For_Del", out sv) ?? false) {
                int_Session_ID_For_Del.AdvancedSearch.SearchValue = sv;
                int_Session_ID_For_Del.AdvancedSearch.SearchOperator = filter["z_int_Session_ID_For_Del"];
                int_Session_ID_For_Del.AdvancedSearch.SearchCondition = filter["v_int_Session_ID_For_Del"];
                int_Session_ID_For_Del.AdvancedSearch.SearchValue2 = filter["y_int_Session_ID_For_Del"];
                int_Session_ID_For_Del.AdvancedSearch.SearchOperator2 = filter["w_int_Session_ID_For_Del"];
                int_Session_ID_For_Del.AdvancedSearch.Save();
            }

            // Field RemM1
            if (filter?.TryGetValue("x_RemM1", out sv) ?? false) {
                RemM1.AdvancedSearch.SearchValue = sv;
                RemM1.AdvancedSearch.SearchOperator = filter["z_RemM1"];
                RemM1.AdvancedSearch.SearchCondition = filter["v_RemM1"];
                RemM1.AdvancedSearch.SearchValue2 = filter["y_RemM1"];
                RemM1.AdvancedSearch.SearchOperator2 = filter["w_RemM1"];
                RemM1.AdvancedSearch.Save();
            }

            // Field RemM2
            if (filter?.TryGetValue("x_RemM2", out sv) ?? false) {
                RemM2.AdvancedSearch.SearchValue = sv;
                RemM2.AdvancedSearch.SearchOperator = filter["z_RemM2"];
                RemM2.AdvancedSearch.SearchCondition = filter["v_RemM2"];
                RemM2.AdvancedSearch.SearchValue2 = filter["y_RemM2"];
                RemM2.AdvancedSearch.SearchOperator2 = filter["w_RemM2"];
                RemM2.AdvancedSearch.Save();
            }

            // Field RemM3
            if (filter?.TryGetValue("x_RemM3", out sv) ?? false) {
                RemM3.AdvancedSearch.SearchValue = sv;
                RemM3.AdvancedSearch.SearchOperator = filter["z_RemM3"];
                RemM3.AdvancedSearch.SearchCondition = filter["v_RemM3"];
                RemM3.AdvancedSearch.SearchValue2 = filter["y_RemM3"];
                RemM3.AdvancedSearch.SearchOperator2 = filter["w_RemM3"];
                RemM3.AdvancedSearch.Save();
            }

            // Field SMSReminder1
            if (filter?.TryGetValue("x_SMSReminder1", out sv) ?? false) {
                SMSReminder1.AdvancedSearch.SearchValue = sv;
                SMSReminder1.AdvancedSearch.SearchOperator = filter["z_SMSReminder1"];
                SMSReminder1.AdvancedSearch.SearchCondition = filter["v_SMSReminder1"];
                SMSReminder1.AdvancedSearch.SearchValue2 = filter["y_SMSReminder1"];
                SMSReminder1.AdvancedSearch.SearchOperator2 = filter["w_SMSReminder1"];
                SMSReminder1.AdvancedSearch.Save();
            }

            // Field SMSReminder2
            if (filter?.TryGetValue("x_SMSReminder2", out sv) ?? false) {
                SMSReminder2.AdvancedSearch.SearchValue = sv;
                SMSReminder2.AdvancedSearch.SearchOperator = filter["z_SMSReminder2"];
                SMSReminder2.AdvancedSearch.SearchCondition = filter["v_SMSReminder2"];
                SMSReminder2.AdvancedSearch.SearchValue2 = filter["y_SMSReminder2"];
                SMSReminder2.AdvancedSearch.SearchOperator2 = filter["w_SMSReminder2"];
                SMSReminder2.AdvancedSearch.Save();
            }

            // Field SMSReminder3
            if (filter?.TryGetValue("x_SMSReminder3", out sv) ?? false) {
                SMSReminder3.AdvancedSearch.SearchValue = sv;
                SMSReminder3.AdvancedSearch.SearchOperator = filter["z_SMSReminder3"];
                SMSReminder3.AdvancedSearch.SearchCondition = filter["v_SMSReminder3"];
                SMSReminder3.AdvancedSearch.SearchValue2 = filter["y_SMSReminder3"];
                SMSReminder3.AdvancedSearch.SearchOperator2 = filter["w_SMSReminder3"];
                SMSReminder3.AdvancedSearch.Save();
            }

            // Field VoiceReminder1
            if (filter?.TryGetValue("x_VoiceReminder1", out sv) ?? false) {
                VoiceReminder1.AdvancedSearch.SearchValue = sv;
                VoiceReminder1.AdvancedSearch.SearchOperator = filter["z_VoiceReminder1"];
                VoiceReminder1.AdvancedSearch.SearchCondition = filter["v_VoiceReminder1"];
                VoiceReminder1.AdvancedSearch.SearchValue2 = filter["y_VoiceReminder1"];
                VoiceReminder1.AdvancedSearch.SearchOperator2 = filter["w_VoiceReminder1"];
                VoiceReminder1.AdvancedSearch.Save();
            }

            // Field VoiceReminder2
            if (filter?.TryGetValue("x_VoiceReminder2", out sv) ?? false) {
                VoiceReminder2.AdvancedSearch.SearchValue = sv;
                VoiceReminder2.AdvancedSearch.SearchOperator = filter["z_VoiceReminder2"];
                VoiceReminder2.AdvancedSearch.SearchCondition = filter["v_VoiceReminder2"];
                VoiceReminder2.AdvancedSearch.SearchValue2 = filter["y_VoiceReminder2"];
                VoiceReminder2.AdvancedSearch.SearchOperator2 = filter["w_VoiceReminder2"];
                VoiceReminder2.AdvancedSearch.Save();
            }

            // Field VoiceReminder3
            if (filter?.TryGetValue("x_VoiceReminder3", out sv) ?? false) {
                VoiceReminder3.AdvancedSearch.SearchValue = sv;
                VoiceReminder3.AdvancedSearch.SearchOperator = filter["z_VoiceReminder3"];
                VoiceReminder3.AdvancedSearch.SearchCondition = filter["v_VoiceReminder3"];
                VoiceReminder3.AdvancedSearch.SearchValue2 = filter["y_VoiceReminder3"];
                VoiceReminder3.AdvancedSearch.SearchOperator2 = filter["w_VoiceReminder3"];
                VoiceReminder3.AdvancedSearch.Save();
            }

            // Field strParentName
            if (filter?.TryGetValue("x_strParentName", out sv) ?? false) {
                strParentName.AdvancedSearch.SearchValue = sv;
                strParentName.AdvancedSearch.SearchOperator = filter["z_strParentName"];
                strParentName.AdvancedSearch.SearchCondition = filter["v_strParentName"];
                strParentName.AdvancedSearch.SearchValue2 = filter["y_strParentName"];
                strParentName.AdvancedSearch.SearchOperator2 = filter["w_strParentName"];
                strParentName.AdvancedSearch.Save();
            }

            // Field strParentState
            if (filter?.TryGetValue("x_strParentState", out sv) ?? false) {
                strParentState.AdvancedSearch.SearchValue = sv;
                strParentState.AdvancedSearch.SearchOperator = filter["z_strParentState"];
                strParentState.AdvancedSearch.SearchCondition = filter["v_strParentState"];
                strParentState.AdvancedSearch.SearchValue2 = filter["y_strParentState"];
                strParentState.AdvancedSearch.SearchOperator2 = filter["w_strParentState"];
                strParentState.AdvancedSearch.Save();
            }

            // Field strParentLicenseNumber
            if (filter?.TryGetValue("x_strParentLicenseNumber", out sv) ?? false) {
                strParentLicenseNumber.AdvancedSearch.SearchValue = sv;
                strParentLicenseNumber.AdvancedSearch.SearchOperator = filter["z_strParentLicenseNumber"];
                strParentLicenseNumber.AdvancedSearch.SearchCondition = filter["v_strParentLicenseNumber"];
                strParentLicenseNumber.AdvancedSearch.SearchValue2 = filter["y_strParentLicenseNumber"];
                strParentLicenseNumber.AdvancedSearch.SearchOperator2 = filter["w_strParentLicenseNumber"];
                strParentLicenseNumber.AdvancedSearch.Save();
            }

            // Field CRSS_ID
            if (filter?.TryGetValue("x_CRSS_ID", out sv) ?? false) {
                CRSS_ID.AdvancedSearch.SearchValue = sv;
                CRSS_ID.AdvancedSearch.SearchOperator = filter["z_CRSS_ID"];
                CRSS_ID.AdvancedSearch.SearchCondition = filter["v_CRSS_ID"];
                CRSS_ID.AdvancedSearch.SearchValue2 = filter["y_CRSS_ID"];
                CRSS_ID.AdvancedSearch.SearchOperator2 = filter["w_CRSS_ID"];
                CRSS_ID.AdvancedSearch.Save();
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
            if (filter?.TryGetValue(Config.TableBasicSearch, out string? keyword) ?? false)
                BasicSearch.SessionKeyword = keyword;
            if (filter?.TryGetValue(Config.TableBasicSearchType, out string? type) ?? false)
                BasicSearch.SessionType = type;
            return true;
        }

        // Advanced search WHERE clause based on QueryString
        public string AdvancedSearchWhere(bool def = false) {
            string where = "";
            if (!Security.CanSearch)
                return "";
            BuildSearchSql(ref where, int_Attendance_ID, def, false); // int_Attendance_ID
            BuildSearchSql(ref where, int_Student_ID, def, false); // int_Student_ID
            BuildSearchSql(ref where, str_FullName, def, false); // str_FullName
            BuildSearchSql(ref where, str_Username, def, false); // str_Username
            BuildSearchSql(ref where, int_CR_ID, def, false); // int_CR_ID
            BuildSearchSql(ref where, int_CRSession_ID, def, false); // int_CRSession_ID
            BuildSearchSql(ref where, Is_All_Attend, def, false); // Is_All_Attend
            BuildSearchSql(ref where, idnumber, def, false); // idnumber
            BuildSearchSql(ref where, course_id, def, false); // course_id
            BuildSearchSql(ref where, str_Test_Score, def, false); // str_Test_Score
            BuildSearchSql(ref where, str_Notes, def, false); // str_Notes
            BuildSearchSql(ref where, bit_IsDeleted, def, false); // bit_IsDeleted
            BuildSearchSql(ref where, int_Created_BY, def, false); // int_Created_BY
            BuildSearchSql(ref where, int_Modified_BY, def, false); // int_Modified_BY
            BuildSearchSql(ref where, date_Created, def, false); // date_Created
            BuildSearchSql(ref where, date_Modified, def, false); // date_Modified
            BuildSearchSql(ref where, bit_IsMakeUP, def, false); // bit_IsMakeUP
            BuildSearchSql(ref where, dec_Orginal_SessionID, def, false); // dec_Orginal_SessionID
            BuildSearchSql(ref where, dec_CR_ID_For_Del, def, false); // dec_CR_ID_For_Del
            BuildSearchSql(ref where, int_Session_ID_For_Del, def, false); // int_Session_ID_For_Del
            BuildSearchSql(ref where, RemM1, def, false); // RemM1
            BuildSearchSql(ref where, RemM2, def, false); // RemM2
            BuildSearchSql(ref where, RemM3, def, false); // RemM3
            BuildSearchSql(ref where, SMSReminder1, def, false); // SMSReminder1
            BuildSearchSql(ref where, SMSReminder2, def, false); // SMSReminder2
            BuildSearchSql(ref where, SMSReminder3, def, false); // SMSReminder3
            BuildSearchSql(ref where, VoiceReminder1, def, false); // VoiceReminder1
            BuildSearchSql(ref where, VoiceReminder2, def, false); // VoiceReminder2
            BuildSearchSql(ref where, VoiceReminder3, def, false); // VoiceReminder3
            BuildSearchSql(ref where, strParentName, def, false); // strParentName
            BuildSearchSql(ref where, strParentState, def, false); // strParentState
            BuildSearchSql(ref where, strParentLicenseNumber, def, false); // strParentLicenseNumber
            BuildSearchSql(ref where, CRSS_ID, def, false); // CRSS_ID
            BuildSearchSql(ref where, str_CR_Number, def, false); // str_CR_Number

            // Set up search command
            if (!def && !Empty(where) && (new[] { "", "reset", "resetall" }).Contains(Command))
                Command = "search";
            if (!def && Command == "search") {
                int_Attendance_ID.AdvancedSearch.Save(); // int_Attendance_ID
                int_Student_ID.AdvancedSearch.Save(); // int_Student_ID
                str_FullName.AdvancedSearch.Save(); // str_FullName
                str_Username.AdvancedSearch.Save(); // str_Username
                int_CR_ID.AdvancedSearch.Save(); // int_CR_ID
                int_CRSession_ID.AdvancedSearch.Save(); // int_CRSession_ID
                Is_All_Attend.AdvancedSearch.Save(); // Is_All_Attend
                idnumber.AdvancedSearch.Save(); // idnumber
                course_id.AdvancedSearch.Save(); // course_id
                str_Test_Score.AdvancedSearch.Save(); // str_Test_Score
                str_Notes.AdvancedSearch.Save(); // str_Notes
                bit_IsDeleted.AdvancedSearch.Save(); // bit_IsDeleted
                int_Created_BY.AdvancedSearch.Save(); // int_Created_BY
                int_Modified_BY.AdvancedSearch.Save(); // int_Modified_BY
                date_Created.AdvancedSearch.Save(); // date_Created
                date_Modified.AdvancedSearch.Save(); // date_Modified
                bit_IsMakeUP.AdvancedSearch.Save(); // bit_IsMakeUP
                dec_Orginal_SessionID.AdvancedSearch.Save(); // dec_Orginal_SessionID
                dec_CR_ID_For_Del.AdvancedSearch.Save(); // dec_CR_ID_For_Del
                int_Session_ID_For_Del.AdvancedSearch.Save(); // int_Session_ID_For_Del
                RemM1.AdvancedSearch.Save(); // RemM1
                RemM2.AdvancedSearch.Save(); // RemM2
                RemM3.AdvancedSearch.Save(); // RemM3
                SMSReminder1.AdvancedSearch.Save(); // SMSReminder1
                SMSReminder2.AdvancedSearch.Save(); // SMSReminder2
                SMSReminder3.AdvancedSearch.Save(); // SMSReminder3
                VoiceReminder1.AdvancedSearch.Save(); // VoiceReminder1
                VoiceReminder2.AdvancedSearch.Save(); // VoiceReminder2
                VoiceReminder3.AdvancedSearch.Save(); // VoiceReminder3
                strParentName.AdvancedSearch.Save(); // strParentName
                strParentState.AdvancedSearch.Save(); // strParentState
                strParentLicenseNumber.AdvancedSearch.Save(); // strParentLicenseNumber
                CRSS_ID.AdvancedSearch.Save(); // CRSS_ID
                str_CR_Number.AdvancedSearch.Save(); // str_CR_Number

                // Clear rules for QueryBuilder
                SessionRules = "";
            }
            return where;
        }

        // Parse query builder rule function
        protected string ParseRules(Dictionary<string, object>? group, string fieldName = "") {
            if (group == null)
                return "";
            string condition = group.ContainsKey("condition") ? ConvertToString(group["condition"]) : "AND";
            if (!(new [] { "AND", "OR" }).Contains(condition))
                throw new System.Exception("Unable to build SQL query with condition '" + condition + "'");
            List<string> parts = new ();
            string where = "";
            var groupRules = group.ContainsKey("rules") ? group["rules"] : null;
            if (groupRules is IEnumerable<object> rules) {
                foreach (object rule in rules) {
                    var subRules = JObject.FromObject(rule).ToObject<Dictionary<string, object>>();
                    if (subRules == null)
                        continue;
                    if (subRules.ContainsKey("rules")) {
                        parts.Add("(" + " " + ParseRules(subRules, fieldName) + " " + ")" + " ");
                    } else {
                        string field = subRules.ContainsKey("field") ? ConvertToString(subRules["field"]) : "";
                        var fld = FieldByParam(field);
                        if (fld == null)
                            throw new System.Exception("Failed to find field '" + field + "'");
                        if (Empty(fieldName) || fld.Name == fieldName) { // Field name not specified or matched field name
                            string opr = subRules.ContainsKey("operator") ? ConvertToString(subRules["operator"]) : "";
                            string fldOpr = Config.ClientSearchOperators.FirstOrDefault(o => o.Value == opr).Key;
                            Dictionary<string, object>? ope = Config.QueryBuilderOperators.ContainsKey(opr) ? Config.QueryBuilderOperators[opr] : null;
                            if (ope == null || Empty(fldOpr))
                                throw new System.Exception("Unknown SQL operation for operator '" + opr + "'");
                            int nb_inputs = ope.ContainsKey("nb_inputs") ? ConvertToInt(ope["nb_inputs"]) : 0;
                            object val = subRules.ContainsKey("value") ? subRules["value"] : "";
                            if (nb_inputs > 0 && !Empty(val) || IsNullOrEmptyOperator(fldOpr)) {
                                string fldVal = val is List<object> list
                                    ? (list[0] is IEnumerable<string> ? String.Join(Config.MultipleOptionSeparator, list[0]) : ConvertToString(list[0]))
                                    : ConvertToString(val);
                                bool useFilter = fld.UseFilter; // Query builder does not use filter
                                try {
                                    if (fld.IsMultiSelect) {
                                        parts.Add(!Empty(fldVal) ? GetMultiSearchSql(fld, fldOpr, ConvertSearchValue(fldVal, fldOpr, fld), DbId) : "");
                                    } else {
                                        string fldVal2 = fldOpr.Contains("BETWEEN")
                                            ? (val is List<object> list2 && list2.Count > 1
                                                ? (list2[1] is IEnumerable<string> ? String.Join(Config.MultipleOptionSeparator, list2[1]) : ConvertToString(list2[1]))
                                                : "")
                                            : ""; // BETWEEN
                                        parts.Add(GetSearchSql(
                                            fld,
                                            ConvertSearchValue(fldVal, fldOpr, fld), // fldVal
                                            fldOpr,
                                            "", // fldCond not used
                                            ConvertSearchValue(fldVal2, fldOpr, fld), // $fldVal2
                                            "", // fldOpr2 not used
                                            DbId
                                        ));
                                    }
                                } finally {
                                    fld.UseFilter = useFilter;
                                }
                            }
                        }
                    }
                }
                where = String.Join(" " + condition + " ", parts);
                bool not = group.ContainsKey("not") ? ConvertToBool(group["not"]) : false;
                if (not)
                    where = "NOT (" + where + ")";
            }
            return where;
        }

        // Quey builder WHERE clause
        public string QueryBuilderWhere(string fieldName = "")
        {
            if (!Security.CanSearch)
                return "";

            // Get rules by query builder
            string rules = "";
            if (Post("rules", out StringValues sv))
                rules = sv.ToString();
            else
                rules = SessionRules;

            // Decode and parse rules
            string where = !Empty(rules) ? ParseRules(JsonConvert.DeserializeObject<Dictionary<string, object>>(rules), fieldName) : "";

            // Clear other search and save rules to session
            if (!Empty(where) && Empty(fieldName)) { // Skip if get query for specific field
                ResetSearchParms();
                SessionRules = rules;
            }

            // Return query
            return where;
        }

        // Build search SQL
        public void BuildSearchSql(ref string where, DbField fld, bool def, bool multiValue)
        {
            string fldParm = fld.Param;
            string fldVal = def ? ConvertToString(fld.AdvancedSearch.SearchValueDefault) : ConvertToString(fld.AdvancedSearch.SearchValue);
            string fldOpr = def ? fld.AdvancedSearch.SearchOperatorDefault : fld.AdvancedSearch.SearchOperator;
            string fldCond = def ? fld.AdvancedSearch.SearchConditionDefault : fld.AdvancedSearch.SearchCondition;
            string fldVal2 = def ? ConvertToString(fld.AdvancedSearch.SearchValue2Default) : ConvertToString(fld.AdvancedSearch.SearchValue2);
            string fldOpr2 = def ? fld.AdvancedSearch.SearchOperator2Default : fld.AdvancedSearch.SearchOperator2;
            fldVal = ConvertSearchValue(fldVal, fldOpr, fld);
            fldVal2 = ConvertSearchValue(fldVal2, fldOpr2, fld);
            fldOpr = ConvertSearchOperator(fldOpr, fld, fldVal);
            fldOpr2 = ConvertSearchOperator(fldOpr2, fld, fldVal2);
            string wrk = "";
            if (Config.SearchMultiValueOption == 1 && !fld.UseFilter || !IsMultiSearchOperator(fldOpr))
                multiValue = false;
            if (multiValue) {
                wrk = !Empty(fldVal) ? GetMultiSearchSql(fld, fldOpr, fldVal, DbId) : ""; // Field value 1
                string wrk2 = !Empty(fldVal2) ? GetMultiSearchSql(fld, fldOpr2, fldVal2, DbId) : ""; // Field value 2
                AddFilter(ref wrk, wrk2, fldCond);
            } else {
                wrk = GetSearchSql(fld, fldVal, fldOpr, fldCond, fldVal2, fldOpr2, DbId);
            }
            string cond = SearchOption == "AUTO" && (new[] {"AND", "OR"}).Contains(BasicSearch.Type)
                ? BasicSearch.Type
                : SameText(SearchOption, "OR") ? "OR" : "AND";
            AddFilter(ref where, wrk, cond);
        }

        // Show list of filters
        public void ShowFilterList()
        {
            // Initialize
            string filterList = "",
                filter = "",
                captionClass = IsExport("email") ? "ew-filter-caption-email" : "ew-filter-caption",
                captionSuffix = IsExport("email") ? ": " : "";

            // Field str_FullName
            filter = QueryBuilderWhere("str_FullName");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_FullName, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_FullName.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Username
            filter = QueryBuilderWhere("str_Username");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Username, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Username.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field int_CR_ID
            filter = QueryBuilderWhere("int_CR_ID");
            if (Empty(filter))
                BuildSearchSql(ref filter, int_CR_ID, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + int_CR_ID.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field int_CRSession_ID
            filter = QueryBuilderWhere("int_CRSession_ID");
            if (Empty(filter))
                BuildSearchSql(ref filter, int_CRSession_ID, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + int_CRSession_ID.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field Is_All_Attend
            filter = QueryBuilderWhere("Is_All_Attend");
            if (Empty(filter))
                BuildSearchSql(ref filter, Is_All_Attend, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + Is_All_Attend.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field idnumber
            filter = QueryBuilderWhere("idnumber");
            if (Empty(filter))
                BuildSearchSql(ref filter, idnumber, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + idnumber.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field bit_IsMakeUP
            filter = QueryBuilderWhere("bit_IsMakeUP");
            if (Empty(filter))
                BuildSearchSql(ref filter, bit_IsMakeUP, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + bit_IsMakeUP.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field RemM1
            filter = QueryBuilderWhere("RemM1");
            if (Empty(filter))
                BuildSearchSql(ref filter, RemM1, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + RemM1.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field SMSReminder1
            filter = QueryBuilderWhere("SMSReminder1");
            if (Empty(filter))
                BuildSearchSql(ref filter, SMSReminder1, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + SMSReminder1.Caption + "</span>" + captionSuffix + filter + "</div>";
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
            searchFlds.Add(str_FullName);
            searchFlds.Add(str_Username);
            searchFlds.Add(idnumber);
            searchFlds.Add(str_Test_Score);
            searchFlds.Add(str_Notes);
            searchFlds.Add(strParentName);
            searchFlds.Add(strParentState);
            searchFlds.Add(strParentLicenseNumber);
            searchFlds.Add(str_CR_Number);
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
            if (int_Attendance_ID.AdvancedSearch.IssetSession)
                return true;
            if (int_Student_ID.AdvancedSearch.IssetSession)
                return true;
            if (str_FullName.AdvancedSearch.IssetSession)
                return true;
            if (str_Username.AdvancedSearch.IssetSession)
                return true;
            if (int_CR_ID.AdvancedSearch.IssetSession)
                return true;
            if (int_CRSession_ID.AdvancedSearch.IssetSession)
                return true;
            if (Is_All_Attend.AdvancedSearch.IssetSession)
                return true;
            if (idnumber.AdvancedSearch.IssetSession)
                return true;
            if (course_id.AdvancedSearch.IssetSession)
                return true;
            if (str_Test_Score.AdvancedSearch.IssetSession)
                return true;
            if (str_Notes.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsDeleted.AdvancedSearch.IssetSession)
                return true;
            if (int_Created_BY.AdvancedSearch.IssetSession)
                return true;
            if (int_Modified_BY.AdvancedSearch.IssetSession)
                return true;
            if (date_Created.AdvancedSearch.IssetSession)
                return true;
            if (date_Modified.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsMakeUP.AdvancedSearch.IssetSession)
                return true;
            if (dec_Orginal_SessionID.AdvancedSearch.IssetSession)
                return true;
            if (dec_CR_ID_For_Del.AdvancedSearch.IssetSession)
                return true;
            if (int_Session_ID_For_Del.AdvancedSearch.IssetSession)
                return true;
            if (RemM1.AdvancedSearch.IssetSession)
                return true;
            if (RemM2.AdvancedSearch.IssetSession)
                return true;
            if (RemM3.AdvancedSearch.IssetSession)
                return true;
            if (SMSReminder1.AdvancedSearch.IssetSession)
                return true;
            if (SMSReminder2.AdvancedSearch.IssetSession)
                return true;
            if (SMSReminder3.AdvancedSearch.IssetSession)
                return true;
            if (VoiceReminder1.AdvancedSearch.IssetSession)
                return true;
            if (VoiceReminder2.AdvancedSearch.IssetSession)
                return true;
            if (VoiceReminder3.AdvancedSearch.IssetSession)
                return true;
            if (strParentName.AdvancedSearch.IssetSession)
                return true;
            if (strParentState.AdvancedSearch.IssetSession)
                return true;
            if (strParentLicenseNumber.AdvancedSearch.IssetSession)
                return true;
            if (CRSS_ID.AdvancedSearch.IssetSession)
                return true;
            if (str_CR_Number.AdvancedSearch.IssetSession)
                return true;
            return false;
        }

        // Clear all search parameters
        protected void ResetSearchParms() {
            SearchWhere = "";
            SessionSearchWhere = SearchWhere;

            // Clear basic search parameters
            ResetBasicSearchParms();

            // Clear advanced search parameters
            ResetAdvancedSearchParms();

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

        // Clear all advanced search parameters
        protected void ResetAdvancedSearchParms() {
            int_Attendance_ID.AdvancedSearch.UnsetSession();
            int_Student_ID.AdvancedSearch.UnsetSession();
            str_FullName.AdvancedSearch.UnsetSession();
            str_Username.AdvancedSearch.UnsetSession();
            int_CR_ID.AdvancedSearch.UnsetSession();
            int_CRSession_ID.AdvancedSearch.UnsetSession();
            Is_All_Attend.AdvancedSearch.UnsetSession();
            idnumber.AdvancedSearch.UnsetSession();
            course_id.AdvancedSearch.UnsetSession();
            str_Test_Score.AdvancedSearch.UnsetSession();
            str_Notes.AdvancedSearch.UnsetSession();
            bit_IsDeleted.AdvancedSearch.UnsetSession();
            int_Created_BY.AdvancedSearch.UnsetSession();
            int_Modified_BY.AdvancedSearch.UnsetSession();
            date_Created.AdvancedSearch.UnsetSession();
            date_Modified.AdvancedSearch.UnsetSession();
            bit_IsMakeUP.AdvancedSearch.UnsetSession();
            dec_Orginal_SessionID.AdvancedSearch.UnsetSession();
            dec_CR_ID_For_Del.AdvancedSearch.UnsetSession();
            int_Session_ID_For_Del.AdvancedSearch.UnsetSession();
            RemM1.AdvancedSearch.UnsetSession();
            RemM2.AdvancedSearch.UnsetSession();
            RemM3.AdvancedSearch.UnsetSession();
            SMSReminder1.AdvancedSearch.UnsetSession();
            SMSReminder2.AdvancedSearch.UnsetSession();
            SMSReminder3.AdvancedSearch.UnsetSession();
            VoiceReminder1.AdvancedSearch.UnsetSession();
            VoiceReminder2.AdvancedSearch.UnsetSession();
            VoiceReminder3.AdvancedSearch.UnsetSession();
            strParentName.AdvancedSearch.UnsetSession();
            strParentState.AdvancedSearch.UnsetSession();
            strParentLicenseNumber.AdvancedSearch.UnsetSession();
            CRSS_ID.AdvancedSearch.UnsetSession();
            str_CR_Number.AdvancedSearch.UnsetSession();
        }

        // Restore all search parameters
        protected void RestoreSearchParms() {
            RestoreSearch = true;

            // Restore basic search values
            BasicSearch.Load();

            // Restore advanced search values
            int_Attendance_ID.AdvancedSearch.Load();
            int_Student_ID.AdvancedSearch.Load();
            str_FullName.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            int_CR_ID.AdvancedSearch.Load();
            int_CRSession_ID.AdvancedSearch.Load();
            Is_All_Attend.AdvancedSearch.Load();
            idnumber.AdvancedSearch.Load();
            course_id.AdvancedSearch.Load();
            str_Test_Score.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            bit_IsDeleted.AdvancedSearch.Load();
            int_Created_BY.AdvancedSearch.Load();
            int_Modified_BY.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            bit_IsMakeUP.AdvancedSearch.Load();
            dec_Orginal_SessionID.AdvancedSearch.Load();
            dec_CR_ID_For_Del.AdvancedSearch.Load();
            int_Session_ID_For_Del.AdvancedSearch.Load();
            RemM1.AdvancedSearch.Load();
            RemM2.AdvancedSearch.Load();
            RemM3.AdvancedSearch.Load();
            SMSReminder1.AdvancedSearch.Load();
            SMSReminder2.AdvancedSearch.Load();
            SMSReminder3.AdvancedSearch.Load();
            VoiceReminder1.AdvancedSearch.Load();
            VoiceReminder2.AdvancedSearch.Load();
            VoiceReminder3.AdvancedSearch.Load();
            strParentName.AdvancedSearch.Load();
            strParentState.AdvancedSearch.Load();
            strParentLicenseNumber.AdvancedSearch.Load();
            CRSS_ID.AdvancedSearch.Load();
            str_CR_Number.AdvancedSearch.Load();
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
                UpdateSort(str_FullName, ctrl); // str_FullName
                UpdateSort(str_Username, ctrl); // str_Username
                UpdateSort(int_CR_ID, ctrl); // int_CR_ID
                UpdateSort(int_CRSession_ID, ctrl); // int_CRSession_ID
                UpdateSort(Is_All_Attend, ctrl); // Is_All_Attend
                UpdateSort(idnumber, ctrl); // idnumber
                UpdateSort(bit_IsMakeUP, ctrl); // bit_IsMakeUP
                UpdateSort(RemM1, ctrl); // RemM1
                UpdateSort(SMSReminder1, ctrl); // SMSReminder1
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
                    int_Attendance_ID.Sort = "";
                    int_Student_ID.Sort = "";
                    str_FullName.Sort = "";
                    str_Username.Sort = "";
                    int_CR_ID.Sort = "";
                    int_CRSession_ID.Sort = "";
                    Is_All_Attend.Sort = "";
                    idnumber.Sort = "";
                    course_id.Sort = "";
                    str_Test_Score.Sort = "";
                    str_Notes.Sort = "";
                    bit_IsDeleted.Sort = "";
                    int_Created_BY.Sort = "";
                    int_Modified_BY.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    bit_IsMakeUP.Sort = "";
                    dec_Orginal_SessionID.Sort = "";
                    dec_CR_ID_For_Del.Sort = "";
                    int_Session_ID_For_Del.Sort = "";
                    RemM1.Sort = "";
                    RemM2.Sort = "";
                    RemM3.Sort = "";
                    SMSReminder1.Sort = "";
                    SMSReminder2.Sort = "";
                    SMSReminder3.Sort = "";
                    VoiceReminder1.Sort = "";
                    VoiceReminder2.Sort = "";
                    VoiceReminder3.Sort = "";
                    strParentName.Sort = "";
                    strParentState.Sort = "";
                    strParentLicenseNumber.Sort = "";
                    CRSS_ID.Sort = "";
                    str_CR_Number.Sort = "";
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

            // "griddelete"
            if (AllowAddDeleteRow) {
                item = ListOptions.Add("griddelete");
                item.CssClass = "text-nowrap";
                item.OnLeft = MultiColumnLayout == "cards" ? false : true;
                item.Visible = false; // Default hidden
            }

            // Add group option item
            item = ListOptions.AddGroupOption();
            item.Body = "";
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.Visible = false;

            // "view"
            item = ListOptions.Add("view");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanView;
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;

            // "edit"
            item = ListOptions.Add("edit");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanEdit;
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;

            // "detail_Sessions"
            item = ListOptions.Add("detailreport_Sessions");
            item.CssClass = "text-nowrap";
            item.Visible = Security.AllowList(CurrentProjectID + "Sessions");
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.ShowInButtonGroup = false;

            // Multiple details
            if (ShowMultipleDetails) {
                item = ListOptions.Add("details");
                item.CssClass = "text-nowrap";
                item.Visible = ShowMultipleDetails && ListOptions.DetailVisible();
                item.OnLeft = MultiColumnLayout == "cards" ? false : true;
                item.ShowInButtonGroup = false;
            }

            // Set up detail pages
            var _pages = new SubPages();
            DetailPages = _pages;

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

            // Set up row action and key
            if (IsNumeric(RowIndex) && RowType != RowType.View) {
                CurrentForm!.Index = ConvertToInt(RowIndex);
                var actionName = FormActionName.Replace("k_", "k" + ConvertToString(RowIndex) + "_");
                var oldKeyName = OldKeyName.Replace("k_", "k" + ConvertToString(RowIndex) + "_");
                var blankRowName = FormBlankRowName.Replace("k_", "k" + ConvertToString(RowIndex) + "_");
                if (!Empty(RowAction))
                    MultiSelectKey += "<input type=\"hidden\" name=\"" + actionName + "\" id=\"" + actionName + "\" value=\"" + RowAction + "\">";
                string oldKey = GetKey(false); // Get from OldValue
                if (!Empty(oldKeyName) && !Empty(oldKey)) {
                    MultiSelectKey += "<input type=\"hidden\" name=\"" + oldKeyName + "\" id=\"" + oldKeyName + "\" value=\"" + HtmlEncode(oldKey) + "\">";
                }
                if (RowAction == "insert" && IsConfirm && EmptyRow())
                    MultiSelectKey += "<input type=\"hidden\" name=\"" + blankRowName + "\" id=\"" + blankRowName + "\" value=\"1\">";
            }

            // "delete"
            if (AllowAddDeleteRow) {
                if (IsGridAdd || IsGridEdit) {
                    var options = ListOptions;
                    options.UseButtonGroup = true; // Use button group for grid delete button
                    listOption = options["griddelete"];
                    if (IsNumeric(RowIndex) && (RowAction == "" || RowAction == "edit")) { // Do not allow delete existing record
                        listOption?.SetBody("&nbsp;");
                    } else {
                        listOption?.SetBody("<a class=\"ew-grid-link ew-grid-delete\" title=\"" + Language.Phrase("DeleteLink", true) + "\" data-caption=\"" + Language.Phrase("DeleteLink", true) + "\" data-ew-action=\"delete-grid-row\" data-rowindex=\"" + RowIndex + "\">" + Language.Phrase("DeleteLink") + "</a>");
                    }
                }
            }

            // "view"
            listOption = ListOptions["view"];
            string viewcaption = Language.Phrase("ViewLink", true);
            isVisible = Security.CanView;
            if (isVisible) {
                if (ModalView && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-table=""tblCRAttendance"" data-caption=""{viewcaption}"" data-ew-action=""modal"" data-action=""view"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(ViewUrl)) + "\" data-btn=\"null\">" + Language.Phrase("ViewLink") + "</a>");
                else
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-caption=""{viewcaption}"" href=""" + HtmlEncode(AppPath(ViewUrl)) + "\">" + Language.Phrase("ViewLink") + "</a>");
            } else {
                listOption?.Clear();
            }

            // "edit"
            listOption = ListOptions["edit"];
            string editcaption = Language.Phrase("EditLink", true);
            isVisible = Security.CanEdit;
            if (isVisible) {
                if (ModalEdit && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblCRAttendance"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
                else
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-caption=""{editcaption}"" href=""" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("EditLink") + "</a>");
            } else {
                listOption?.Clear();
            }

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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblCRAttendancelist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblCRAttendancelist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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
            var detailViewTblVar = "";
            var detailCopyTblVar = "";
            var detailEditTblVar = "";
            dynamic? detailPage = null;
            string detailFilter = "";

            // "detail_Sessions"
            listOption = ListOptions["detailreport_Sessions"];
            isVisible = Security.AllowList(CurrentProjectID + "Sessions");
            if (isVisible) {
                string caption, title, url;
                var body = Language.Phrase("DetailLink") + Language.TablePhrase("Sessions", "TblCaption");
                body = "<a class=\"btn btn-default ew-row-link\" href=\"" + HtmlEncode(AppPath("Sessions?" + Config.TableShowMaster + "=tblCRAttendance&" + ForeignKeyUrl("fk_str_CR_Number", str_CR_Number.CurrentValue) + "")) + "\">" + body + "</a>";
                body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
                listOption?.SetBody(body);
                if (ShowMultipleDetails)
                    listOption?.SetVisible(false);
            }
            if (ShowMultipleDetails) {
                var body = Language.Phrase("MultipleMasterDetails");
                body = "<div class=\"btn-group btn-group-sm ew-btn-group\">";
                string links = "";
                if (!Empty(detailViewTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailViewLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetViewUrl(Config.TableShowDetail + "=" + detailViewTblVar))) + "\">" + Language.Phrase("MasterDetailViewLink", null) + "</a></li>";
                }
                if (!Empty(detailEditTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailEditLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetEditUrl(Config.TableShowDetail + "=" + detailEditTblVar))) + "\">" + Language.Phrase("MasterDetailEditLink", null) + "</a></li>";
                }
                if (!Empty(detailCopyTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-copy\" data-action=\"add\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailCopyLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetCopyUrl(Config.TableShowDetail + "=" + detailCopyTblVar))) + "\">" + Language.Phrase("MasterDetailCopyLink", null) + "</a></li>";
                }
                if (!Empty(links)) {
                    body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-master-detail\" title=\"" + HtmlEncode(Language.Phrase("MultipleMasterDetails", true)) + "\" data-bs-toggle=\"dropdown\">" + Language.Phrase("MultipleMasterDetails") + "</button>";
                    body += "<ul class=\"dropdown-menu ew-dropdown-menu\">" + links + "</ul>";
                }
                body += "</div>";
                // Multiple details
                listOption = ListOptions["details"];
                listOption?.SetBody(body);
            }

            // "checkbox"
            listOption = ListOptions["checkbox"];
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(int_Attendance_ID.CurrentValue) + "\"></div>");
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

            // Add grid edit
            option = options["addedit"];
            item = option.Add("gridedit");
            string gridEditTitle = Language.Phrase("GridEditLink", true);
            if (ModalGridEdit && !IsMobile())
                item.Body = $@"<a class=""ew-add-edit ew-grid-edit"" title=""{gridEditTitle}"" data-caption=""{gridEditTitle}"" data-ew-action=""modal"" data-btn=""GridSaveLink"" data-url=""" + HtmlEncode(AppPath(GridEditUrl)) + "\">" + Language.Phrase("GridEditLink") + "</a>";
            else
                item.Body = $@"<a class=""ew-add-edit ew-grid-edit"" title=""{gridEditTitle}"" data-caption=""{gridEditTitle}"" href=""" + HtmlEncode(AppPath(GridEditUrl)) + "\">" + Language.Phrase("GridEditLink") + "</a>";
            item.Visible = GridEditUrl != "" && Security.CanEdit;
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblCRAttendancelist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblCRAttendancesrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblCRAttendancesrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
            if (!IsGridAdd && !IsGridEdit && !IsMultiEdit) { // Not grid add/grid edit/multi edit mode
                option = options["action"];

                // Set up list action buttons
                foreach (var (key, act) in ListActions.Items.Where(kvp => kvp.Value.Select == Config.ActionMultiple)) {
                    item = option.Add("custom_" + act.Action);
                    string caption = act.Caption;
                    var icon = (act.Icon != "") ? "<i class=\"" + HtmlEncode(act.Icon) + "\" data-caption=\"" + HtmlEncode(caption) + "\"></i>" + caption : caption;
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblCRAttendancelist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
                    item.Visible = act.Allowed;
                }

                // Hide multi edit, grid edit and other options
                if (TotalRecords <= 0) {
                    option = options["addedit"];
                    option?["gridedit"]?.SetVisible(false);
                    option = options["action"];
                    option.HideAllOptions();
                }
            } else {
                // Hide all options first
                foreach (var (key, opt) in options)
                    opt.HideAllOptions();
                if (IsGridEdit) {
                    if (MultiColumnLayout == "table") { // Check if table layout
                        if (AllowAddDeleteRow) {
                            // Add add blank row
                            option = options["addedit"];
                            option.UseDropDownButton = false;
                            item = option.Add("addblankrow");
                            item.Body = "<button class=\"ew-add-edit ew-add-blank-row\" title=\"" + Language.Phrase("AddBlankRow", true) + "\" data-caption=\"" + Language.Phrase("AddBlankRow", true) + "\" data-ew-action=\"add-grid-row\">" + Language.Phrase("AddBlankRow") + "</button>";
                            item.Visible = false;
                        }
                    }
                    if (!(ModalGridEdit && !IsMobile())) {
                        option = options["action"];
                        option.UseDropDownButton = false;
                            item = option.Add("gridsave");
                            item.Body = "<button class=\"ew-action ew-grid-save\" title=\"" + Language.Phrase("GridSaveLink", true) + "\" data-caption=\"" + Language.Phrase("GridSaveLink", true) + "\" form=\"ftblCRAttendancelist\" formaction=\"" + AppPath(PageName) + "\">" + Language.Phrase("GridSaveLink") + "</button>";
                            item = option.Add("gridcancel");
                            item.Body = "<a class=\"ew-action ew-grid-cancel\" title=\"" + Language.Phrase("GridCancelLink", true) + "\" data-caption=\"" + Language.Phrase("GridCancelLink", true) + "\" href=\"" + HtmlEncode(AppPath(AddMasterUrl(PageUrl + "action=cancel"))) + "\">" + Language.Phrase("GridCancelLink") + "</a>";
                    }
                }
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

            // Restore number of post back records
            if (CurrentForm != null && (IsConfirm || EventCancelled)) {
                CurrentForm!.ResetIndex(); // DN
                if (CurrentForm!.HasValue(FormKeyCountName) && (IsGridAdd || IsGridEdit || IsConfirm)) {
                    KeyCount = CurrentForm.GetInt(FormKeyCountName);
                    StopRecord = StartRecord + KeyCount - 1;
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
                    RowAttrs.Add("id", "r0_tblCRAttendance");
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
            if (CurrentForm != null && (IsGridAdd || IsGridEdit || IsConfirm || IsMultiEdit)) {
                RowIndex = ConvertToInt(RowIndex) + 1;
                CurrentForm!.SetIndex(ConvertToInt(RowIndex));
                if (CurrentForm!.HasValue(FormActionName) && (IsConfirm || EventCancelled))
                    RowAction = CurrentForm.GetValue(FormActionName);
                else if (IsGridAdd)
                    RowAction = "insert";
                else
                    RowAction = "";
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
            if (IsGridEdit) { // Grid edit
                if (EventCancelled)
                    await RestoreCurrentRowFormValues(RowIndex); // Restore form values
                if (RowAction == "insert")
                    RowType = RowType.Add; // Render add
                else
                    RowType = RowType.Edit; // Render edit
            }
            if (IsGridEdit && (RowType == RowType.Edit || RowType == RowType.Add) && EventCancelled) // Update failed
                await RestoreCurrentRowFormValues(RowIndex); // Restore form values

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
            RowAttrs.Add("data-rowindex", ConvertToString(tblCrAttendanceList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblCrAttendanceList.RowCount) + "_tblCRAttendance");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblCrAttendanceList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblCrAttendanceList.RowType == RowType.Add || IsEdit && tblCrAttendanceList.RowType == RowType.Edit) // Inline-Add/Edit row
                RowAttrs.AppendClass("table-active");

            // Render row
            await RenderRow();

            // Render list options
            await RenderListOptions();
        }

        // Load default values
        protected void LoadDefaultValues() {
            str_Test_Score.DefaultValue = str_Test_Score.GetDefault(); // DN
            str_Test_Score.OldValue = str_Test_Score.DefaultValue;
            RemM1.DefaultValue = RemM1.GetDefault(); // DN
            RemM1.OldValue = RemM1.DefaultValue;
            RemM2.DefaultValue = RemM2.GetDefault(); // DN
            RemM2.OldValue = RemM2.DefaultValue;
            RemM3.DefaultValue = RemM3.GetDefault(); // DN
            RemM3.OldValue = RemM3.DefaultValue;
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

        // Load search values for validation // DN
        protected void LoadSearchValues() {
            // Load query builder rules
            string rules = Post("rules");
            if (!Empty(rules) && Empty(Command)) {
                QueryRules = rules;
                Command = "search";
            }

            // int_Attendance_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Attendance_ID"))
                    int_Attendance_ID.AdvancedSearch.SearchValue = Get("x_int_Attendance_ID");
                else
                    int_Attendance_ID.AdvancedSearch.SearchValue = Get("int_Attendance_ID"); // Default Value // DN
            if (!Empty(int_Attendance_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Attendance_ID"))
                int_Attendance_ID.AdvancedSearch.SearchOperator = Get("z_int_Attendance_ID");

            // int_Student_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Student_ID"))
                    int_Student_ID.AdvancedSearch.SearchValue = Get("x_int_Student_ID");
                else
                    int_Student_ID.AdvancedSearch.SearchValue = Get("int_Student_ID"); // Default Value // DN
            if (!Empty(int_Student_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Student_ID"))
                int_Student_ID.AdvancedSearch.SearchOperator = Get("z_int_Student_ID");

            // str_FullName
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_FullName"))
                    str_FullName.AdvancedSearch.SearchValue = Get("x_str_FullName");
                else
                    str_FullName.AdvancedSearch.SearchValue = Get("str_FullName"); // Default Value // DN
            if (!Empty(str_FullName.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_FullName"))
                str_FullName.AdvancedSearch.SearchOperator = Get("z_str_FullName");

            // str_Username
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Username"))
                    str_Username.AdvancedSearch.SearchValue = Get("x_str_Username");
                else
                    str_Username.AdvancedSearch.SearchValue = Get("str_Username"); // Default Value // DN
            if (!Empty(str_Username.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Username"))
                str_Username.AdvancedSearch.SearchOperator = Get("z_str_Username");

            // int_CR_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_CR_ID"))
                    int_CR_ID.AdvancedSearch.SearchValue = Get("x_int_CR_ID");
                else
                    int_CR_ID.AdvancedSearch.SearchValue = Get("int_CR_ID"); // Default Value // DN
            if (!Empty(int_CR_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_CR_ID"))
                int_CR_ID.AdvancedSearch.SearchOperator = Get("z_int_CR_ID");

            // int_CRSession_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_CRSession_ID"))
                    int_CRSession_ID.AdvancedSearch.SearchValue = Get("x_int_CRSession_ID");
                else
                    int_CRSession_ID.AdvancedSearch.SearchValue = Get("int_CRSession_ID"); // Default Value // DN
            if (!Empty(int_CRSession_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_CRSession_ID"))
                int_CRSession_ID.AdvancedSearch.SearchOperator = Get("z_int_CRSession_ID");

            // Is_All_Attend
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Is_All_Attend"))
                    Is_All_Attend.AdvancedSearch.SearchValue = Get("x_Is_All_Attend");
                else
                    Is_All_Attend.AdvancedSearch.SearchValue = Get("Is_All_Attend"); // Default Value // DN
            if (!Empty(Is_All_Attend.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Is_All_Attend"))
                Is_All_Attend.AdvancedSearch.SearchOperator = Get("z_Is_All_Attend");

            // idnumber
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_idnumber"))
                    idnumber.AdvancedSearch.SearchValue = Get("x_idnumber");
                else
                    idnumber.AdvancedSearch.SearchValue = Get("idnumber"); // Default Value // DN
            if (!Empty(idnumber.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_idnumber"))
                idnumber.AdvancedSearch.SearchOperator = Get("z_idnumber");

            // course_id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_course_id"))
                    course_id.AdvancedSearch.SearchValue = Get("x_course_id");
                else
                    course_id.AdvancedSearch.SearchValue = Get("course_id"); // Default Value // DN
            if (!Empty(course_id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_course_id"))
                course_id.AdvancedSearch.SearchOperator = Get("z_course_id");

            // str_Test_Score
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Test_Score"))
                    str_Test_Score.AdvancedSearch.SearchValue = Get("x_str_Test_Score");
                else
                    str_Test_Score.AdvancedSearch.SearchValue = Get("str_Test_Score"); // Default Value // DN
            if (!Empty(str_Test_Score.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Test_Score"))
                str_Test_Score.AdvancedSearch.SearchOperator = Get("z_str_Test_Score");

            // str_Notes
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Notes"))
                    str_Notes.AdvancedSearch.SearchValue = Get("x_str_Notes");
                else
                    str_Notes.AdvancedSearch.SearchValue = Get("str_Notes"); // Default Value // DN
            if (!Empty(str_Notes.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Notes"))
                str_Notes.AdvancedSearch.SearchOperator = Get("z_str_Notes");

            // bit_IsDeleted
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_IsDeleted"))
                    bit_IsDeleted.AdvancedSearch.SearchValue = Get("x_bit_IsDeleted");
                else
                    bit_IsDeleted.AdvancedSearch.SearchValue = Get("bit_IsDeleted"); // Default Value // DN
            if (!Empty(bit_IsDeleted.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_IsDeleted"))
                bit_IsDeleted.AdvancedSearch.SearchOperator = Get("z_bit_IsDeleted");

            // int_Created_BY
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Created_BY"))
                    int_Created_BY.AdvancedSearch.SearchValue = Get("x_int_Created_BY");
                else
                    int_Created_BY.AdvancedSearch.SearchValue = Get("int_Created_BY"); // Default Value // DN
            if (!Empty(int_Created_BY.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Created_BY"))
                int_Created_BY.AdvancedSearch.SearchOperator = Get("z_int_Created_BY");

            // int_Modified_BY
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Modified_BY"))
                    int_Modified_BY.AdvancedSearch.SearchValue = Get("x_int_Modified_BY");
                else
                    int_Modified_BY.AdvancedSearch.SearchValue = Get("int_Modified_BY"); // Default Value // DN
            if (!Empty(int_Modified_BY.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Modified_BY"))
                int_Modified_BY.AdvancedSearch.SearchOperator = Get("z_int_Modified_BY");

            // date_Created
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Created"))
                    date_Created.AdvancedSearch.SearchValue = Get("x_date_Created");
                else
                    date_Created.AdvancedSearch.SearchValue = Get("date_Created"); // Default Value // DN
            if (!Empty(date_Created.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Created"))
                date_Created.AdvancedSearch.SearchOperator = Get("z_date_Created");

            // date_Modified
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Modified"))
                    date_Modified.AdvancedSearch.SearchValue = Get("x_date_Modified");
                else
                    date_Modified.AdvancedSearch.SearchValue = Get("date_Modified"); // Default Value // DN
            if (!Empty(date_Modified.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Modified"))
                date_Modified.AdvancedSearch.SearchOperator = Get("z_date_Modified");

            // bit_IsMakeUP
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_IsMakeUP"))
                    bit_IsMakeUP.AdvancedSearch.SearchValue = Get("x_bit_IsMakeUP");
                else
                    bit_IsMakeUP.AdvancedSearch.SearchValue = Get("bit_IsMakeUP"); // Default Value // DN
            if (!Empty(bit_IsMakeUP.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_IsMakeUP"))
                bit_IsMakeUP.AdvancedSearch.SearchOperator = Get("z_bit_IsMakeUP");

            // dec_Orginal_SessionID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dec_Orginal_SessionID"))
                    dec_Orginal_SessionID.AdvancedSearch.SearchValue = Get("x_dec_Orginal_SessionID");
                else
                    dec_Orginal_SessionID.AdvancedSearch.SearchValue = Get("dec_Orginal_SessionID"); // Default Value // DN
            if (!Empty(dec_Orginal_SessionID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dec_Orginal_SessionID"))
                dec_Orginal_SessionID.AdvancedSearch.SearchOperator = Get("z_dec_Orginal_SessionID");

            // dec_CR_ID_For_Del
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dec_CR_ID_For_Del"))
                    dec_CR_ID_For_Del.AdvancedSearch.SearchValue = Get("x_dec_CR_ID_For_Del");
                else
                    dec_CR_ID_For_Del.AdvancedSearch.SearchValue = Get("dec_CR_ID_For_Del"); // Default Value // DN
            if (!Empty(dec_CR_ID_For_Del.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dec_CR_ID_For_Del"))
                dec_CR_ID_For_Del.AdvancedSearch.SearchOperator = Get("z_dec_CR_ID_For_Del");

            // int_Session_ID_For_Del
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Session_ID_For_Del"))
                    int_Session_ID_For_Del.AdvancedSearch.SearchValue = Get("x_int_Session_ID_For_Del");
                else
                    int_Session_ID_For_Del.AdvancedSearch.SearchValue = Get("int_Session_ID_For_Del"); // Default Value // DN
            if (!Empty(int_Session_ID_For_Del.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Session_ID_For_Del"))
                int_Session_ID_For_Del.AdvancedSearch.SearchOperator = Get("z_int_Session_ID_For_Del");

            // RemM1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_RemM1"))
                    RemM1.AdvancedSearch.SearchValue = Get("x_RemM1");
                else
                    RemM1.AdvancedSearch.SearchValue = Get("RemM1"); // Default Value // DN
            if (!Empty(RemM1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_RemM1"))
                RemM1.AdvancedSearch.SearchOperator = Get("z_RemM1");

            // RemM2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_RemM2"))
                    RemM2.AdvancedSearch.SearchValue = Get("x_RemM2");
                else
                    RemM2.AdvancedSearch.SearchValue = Get("RemM2"); // Default Value // DN
            if (!Empty(RemM2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_RemM2"))
                RemM2.AdvancedSearch.SearchOperator = Get("z_RemM2");

            // RemM3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_RemM3"))
                    RemM3.AdvancedSearch.SearchValue = Get("x_RemM3");
                else
                    RemM3.AdvancedSearch.SearchValue = Get("RemM3"); // Default Value // DN
            if (!Empty(RemM3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_RemM3"))
                RemM3.AdvancedSearch.SearchOperator = Get("z_RemM3");

            // SMSReminder1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SMSReminder1"))
                    SMSReminder1.AdvancedSearch.SearchValue = Get("x_SMSReminder1");
                else
                    SMSReminder1.AdvancedSearch.SearchValue = Get("SMSReminder1"); // Default Value // DN
            if (!Empty(SMSReminder1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SMSReminder1"))
                SMSReminder1.AdvancedSearch.SearchOperator = Get("z_SMSReminder1");

            // SMSReminder2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SMSReminder2"))
                    SMSReminder2.AdvancedSearch.SearchValue = Get("x_SMSReminder2");
                else
                    SMSReminder2.AdvancedSearch.SearchValue = Get("SMSReminder2"); // Default Value // DN
            if (!Empty(SMSReminder2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SMSReminder2"))
                SMSReminder2.AdvancedSearch.SearchOperator = Get("z_SMSReminder2");

            // SMSReminder3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_SMSReminder3"))
                    SMSReminder3.AdvancedSearch.SearchValue = Get("x_SMSReminder3");
                else
                    SMSReminder3.AdvancedSearch.SearchValue = Get("SMSReminder3"); // Default Value // DN
            if (!Empty(SMSReminder3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_SMSReminder3"))
                SMSReminder3.AdvancedSearch.SearchOperator = Get("z_SMSReminder3");

            // VoiceReminder1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_VoiceReminder1"))
                    VoiceReminder1.AdvancedSearch.SearchValue = Get("x_VoiceReminder1");
                else
                    VoiceReminder1.AdvancedSearch.SearchValue = Get("VoiceReminder1"); // Default Value // DN
            if (!Empty(VoiceReminder1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_VoiceReminder1"))
                VoiceReminder1.AdvancedSearch.SearchOperator = Get("z_VoiceReminder1");

            // VoiceReminder2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_VoiceReminder2"))
                    VoiceReminder2.AdvancedSearch.SearchValue = Get("x_VoiceReminder2");
                else
                    VoiceReminder2.AdvancedSearch.SearchValue = Get("VoiceReminder2"); // Default Value // DN
            if (!Empty(VoiceReminder2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_VoiceReminder2"))
                VoiceReminder2.AdvancedSearch.SearchOperator = Get("z_VoiceReminder2");

            // VoiceReminder3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_VoiceReminder3"))
                    VoiceReminder3.AdvancedSearch.SearchValue = Get("x_VoiceReminder3");
                else
                    VoiceReminder3.AdvancedSearch.SearchValue = Get("VoiceReminder3"); // Default Value // DN
            if (!Empty(VoiceReminder3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_VoiceReminder3"))
                VoiceReminder3.AdvancedSearch.SearchOperator = Get("z_VoiceReminder3");

            // strParentName
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strParentName"))
                    strParentName.AdvancedSearch.SearchValue = Get("x_strParentName");
                else
                    strParentName.AdvancedSearch.SearchValue = Get("strParentName"); // Default Value // DN
            if (!Empty(strParentName.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strParentName"))
                strParentName.AdvancedSearch.SearchOperator = Get("z_strParentName");

            // strParentState
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strParentState"))
                    strParentState.AdvancedSearch.SearchValue = Get("x_strParentState");
                else
                    strParentState.AdvancedSearch.SearchValue = Get("strParentState"); // Default Value // DN
            if (!Empty(strParentState.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strParentState"))
                strParentState.AdvancedSearch.SearchOperator = Get("z_strParentState");

            // strParentLicenseNumber
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strParentLicenseNumber"))
                    strParentLicenseNumber.AdvancedSearch.SearchValue = Get("x_strParentLicenseNumber");
                else
                    strParentLicenseNumber.AdvancedSearch.SearchValue = Get("strParentLicenseNumber"); // Default Value // DN
            if (!Empty(strParentLicenseNumber.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strParentLicenseNumber"))
                strParentLicenseNumber.AdvancedSearch.SearchOperator = Get("z_strParentLicenseNumber");

            // CRSS_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_CRSS_ID"))
                    CRSS_ID.AdvancedSearch.SearchValue = Get("x_CRSS_ID");
                else
                    CRSS_ID.AdvancedSearch.SearchValue = Get("CRSS_ID"); // Default Value // DN
            if (!Empty(CRSS_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_CRSS_ID"))
                CRSS_ID.AdvancedSearch.SearchOperator = Get("z_CRSS_ID");

            // str_CR_Number
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CR_Number"))
                    str_CR_Number.AdvancedSearch.SearchValue = Get("x_str_CR_Number");
                else
                    str_CR_Number.AdvancedSearch.SearchValue = Get("str_CR_Number"); // Default Value // DN
            if (!Empty(str_CR_Number.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CR_Number"))
                str_CR_Number.AdvancedSearch.SearchOperator = Get("z_str_CR_Number");
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'str_FullName' before field var 'x_str_FullName'
            val = CurrentForm.HasValue("str_FullName") ? CurrentForm.GetValue("str_FullName") : CurrentForm.GetValue("x_str_FullName");
            if (!str_FullName.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_FullName") && !CurrentForm.HasValue("x_str_FullName")) // DN
                    str_FullName.Visible = false; // Disable update for API request
                else
                    str_FullName.SetFormValue(val);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }

            // Check field name 'int_CR_ID' before field var 'x_int_CR_ID'
            val = CurrentForm.HasValue("int_CR_ID") ? CurrentForm.GetValue("int_CR_ID") : CurrentForm.GetValue("x_int_CR_ID");
            if (!int_CR_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CR_ID") && !CurrentForm.HasValue("x_int_CR_ID")) // DN
                    int_CR_ID.Visible = false; // Disable update for API request
                else
                    int_CR_ID.SetFormValue(val);
            }

            // Check field name 'int_CRSession_ID' before field var 'x_int_CRSession_ID'
            val = CurrentForm.HasValue("int_CRSession_ID") ? CurrentForm.GetValue("int_CRSession_ID") : CurrentForm.GetValue("x_int_CRSession_ID");
            if (!int_CRSession_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CRSession_ID") && !CurrentForm.HasValue("x_int_CRSession_ID")) // DN
                    int_CRSession_ID.Visible = false; // Disable update for API request
                else
                    int_CRSession_ID.SetFormValue(val);
            }

            // Check field name 'Is_All_Attend' before field var 'x_Is_All_Attend'
            val = CurrentForm.HasValue("Is_All_Attend") ? CurrentForm.GetValue("Is_All_Attend") : CurrentForm.GetValue("x_Is_All_Attend");
            if (!Is_All_Attend.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Is_All_Attend") && !CurrentForm.HasValue("x_Is_All_Attend")) // DN
                    Is_All_Attend.Visible = false; // Disable update for API request
                else
                    Is_All_Attend.SetFormValue(val);
            }

            // Check field name 'idnumber' before field var 'x_idnumber'
            val = CurrentForm.HasValue("idnumber") ? CurrentForm.GetValue("idnumber") : CurrentForm.GetValue("x_idnumber");
            if (!idnumber.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("idnumber") && !CurrentForm.HasValue("x_idnumber")) // DN
                    idnumber.Visible = false; // Disable update for API request
                else
                    idnumber.SetFormValue(val);
            }

            // Check field name 'bit_IsMakeUP' before field var 'x_bit_IsMakeUP'
            val = CurrentForm.HasValue("bit_IsMakeUP") ? CurrentForm.GetValue("bit_IsMakeUP") : CurrentForm.GetValue("x_bit_IsMakeUP");
            if (!bit_IsMakeUP.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsMakeUP") && !CurrentForm.HasValue("x_bit_IsMakeUP")) // DN
                    bit_IsMakeUP.Visible = false; // Disable update for API request
                else
                    bit_IsMakeUP.SetFormValue(val);
            }

            // Check field name 'RemM1' before field var 'x_RemM1'
            val = CurrentForm.HasValue("RemM1") ? CurrentForm.GetValue("RemM1") : CurrentForm.GetValue("x_RemM1");
            if (!RemM1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("RemM1") && !CurrentForm.HasValue("x_RemM1")) // DN
                    RemM1.Visible = false; // Disable update for API request
                else
                    RemM1.SetFormValue(val);
            }

            // Check field name 'SMSReminder1' before field var 'x_SMSReminder1'
            val = CurrentForm.HasValue("SMSReminder1") ? CurrentForm.GetValue("SMSReminder1") : CurrentForm.GetValue("x_SMSReminder1");
            if (!SMSReminder1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("SMSReminder1") && !CurrentForm.HasValue("x_SMSReminder1")) // DN
                    SMSReminder1.Visible = false; // Disable update for API request
                else
                    SMSReminder1.SetFormValue(val);
            }

            // Check field name 'int_Attendance_ID' before field var 'x_int_Attendance_ID'
            val = CurrentForm.HasValue("int_Attendance_ID") ? CurrentForm.GetValue("int_Attendance_ID") : CurrentForm.GetValue("x_int_Attendance_ID");
            if (!int_Attendance_ID.IsDetailKey && !IsGridAdd && !IsAdd)
                int_Attendance_ID.SetFormValue(val);
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            if (!IsGridAdd && !IsAdd)
                int_Attendance_ID.CurrentValue = int_Attendance_ID.FormValue;
            str_FullName.CurrentValue = str_FullName.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            int_CR_ID.CurrentValue = int_CR_ID.FormValue;
            int_CRSession_ID.CurrentValue = int_CRSession_ID.FormValue;
            Is_All_Attend.CurrentValue = Is_All_Attend.FormValue;
            idnumber.CurrentValue = idnumber.FormValue;
            bit_IsMakeUP.CurrentValue = bit_IsMakeUP.FormValue;
            RemM1.CurrentValue = RemM1.FormValue;
            SMSReminder1.CurrentValue = SMSReminder1.FormValue;
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
                    if (!EventCancelled)
                        HashValue = GetRowHash(row); // Get hash value for record
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
            int_Attendance_ID.SetDbValue(row["int_Attendance_ID"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            str_FullName.SetDbValue(row["str_FullName"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_CR_ID.SetDbValue(row["int_CR_ID"]);
            int_CRSession_ID.SetDbValue(row["int_CRSession_ID"]);
            Is_All_Attend.SetDbValue((ConvertToBool(row["Is_All_Attend"]) ? "1" : "0"));
            idnumber.SetDbValue(row["idnumber"]);
            course_id.SetDbValue(row["course_id"]);
            str_Test_Score.SetDbValue(row["str_Test_Score"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            int_Created_BY.SetDbValue(IsNull(row["int_Created_BY"]) ? DbNullValue : ConvertToDouble(row["int_Created_BY"]));
            int_Modified_BY.SetDbValue(IsNull(row["int_Modified_BY"]) ? DbNullValue : ConvertToDouble(row["int_Modified_BY"]));
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsMakeUP.SetDbValue((ConvertToBool(row["bit_IsMakeUP"]) ? "1" : "0"));
            dec_Orginal_SessionID.SetDbValue(IsNull(row["dec_Orginal_SessionID"]) ? DbNullValue : ConvertToDouble(row["dec_Orginal_SessionID"]));
            dec_CR_ID_For_Del.SetDbValue(IsNull(row["dec_CR_ID_For_Del"]) ? DbNullValue : ConvertToDouble(row["dec_CR_ID_For_Del"]));
            int_Session_ID_For_Del.SetDbValue(row["int_Session_ID_For_Del"]);
            RemM1.SetDbValue((ConvertToBool(row["RemM1"]) ? "1" : "0"));
            RemM2.SetDbValue((ConvertToBool(row["RemM2"]) ? "1" : "0"));
            RemM3.SetDbValue((ConvertToBool(row["RemM3"]) ? "1" : "0"));
            studentSignature.Upload.DbValue = row["studentSignature"];
            SMSReminder1.SetDbValue((ConvertToBool(row["SMSReminder1"]) ? "1" : "0"));
            SMSReminder2.SetDbValue((ConvertToBool(row["SMSReminder2"]) ? "1" : "0"));
            SMSReminder3.SetDbValue((ConvertToBool(row["SMSReminder3"]) ? "1" : "0"));
            VoiceReminder1.SetDbValue((ConvertToBool(row["VoiceReminder1"]) ? "1" : "0"));
            VoiceReminder2.SetDbValue((ConvertToBool(row["VoiceReminder2"]) ? "1" : "0"));
            VoiceReminder3.SetDbValue((ConvertToBool(row["VoiceReminder3"]) ? "1" : "0"));
            strParentName.SetDbValue(row["strParentName"]);
            strParentState.SetDbValue(row["strParentState"]);
            strParentLicenseNumber.SetDbValue(row["strParentLicenseNumber"]);
            CRSS_ID.SetDbValue(row["CRSS_ID"]);
            str_CR_Number.SetDbValue(row["str_CR_Number"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Attendance_ID", int_Attendance_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_FullName", str_FullName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_ID", int_CR_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CRSession_ID", int_CRSession_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Is_All_Attend", Is_All_Attend.DefaultValue ?? DbNullValue); // DN
            row.Add("idnumber", idnumber.DefaultValue ?? DbNullValue); // DN
            row.Add("course_id", course_id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Test_Score", str_Test_Score.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_BY", int_Created_BY.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_BY", int_Modified_BY.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsMakeUP", bit_IsMakeUP.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Orginal_SessionID", dec_Orginal_SessionID.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_CR_ID_For_Del", dec_CR_ID_For_Del.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Session_ID_For_Del", int_Session_ID_For_Del.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM1", RemM1.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM2", RemM2.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM3", RemM3.DefaultValue ?? DbNullValue); // DN
            row.Add("studentSignature", studentSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder1", SMSReminder1.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder2", SMSReminder2.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder3", SMSReminder3.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder1", VoiceReminder1.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder2", VoiceReminder2.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder3", VoiceReminder3.DefaultValue ?? DbNullValue); // DN
            row.Add("strParentName", strParentName.DefaultValue ?? DbNullValue); // DN
            row.Add("strParentState", strParentState.DefaultValue ?? DbNullValue); // DN
            row.Add("strParentLicenseNumber", strParentLicenseNumber.DefaultValue ?? DbNullValue); // DN
            row.Add("CRSS_ID", CRSS_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Number", str_CR_Number.DefaultValue ?? DbNullValue); // DN
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

            // int_Attendance_ID

            // int_Student_ID

            // str_FullName

            // str_Username

            // int_CR_ID

            // int_CRSession_ID

            // Is_All_Attend

            // idnumber

            // course_id

            // str_Test_Score

            // str_Notes

            // bit_IsDeleted

            // int_Created_BY

            // int_Modified_BY

            // date_Created

            // date_Modified

            // bit_IsMakeUP

            // dec_Orginal_SessionID

            // dec_CR_ID_For_Del

            // int_Session_ID_For_Del

            // RemM1

            // RemM2

            // RemM3

            // studentSignature

            // SMSReminder1

            // SMSReminder2

            // SMSReminder3

            // VoiceReminder1

            // VoiceReminder2

            // VoiceReminder3

            // strParentName

            // strParentState

            // strParentLicenseNumber

            // CRSS_ID

            // str_CR_Number

            // View row
            if (RowType == RowType.View) {
                // int_Attendance_ID
                int_Attendance_ID.ViewValue = int_Attendance_ID.CurrentValue;
                int_Attendance_ID.ViewCustomAttributes = "";

                // int_Student_ID
                int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
                int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
                int_Student_ID.ViewCustomAttributes = "";

                // str_FullName
                str_FullName.ViewValue = ConvertToString(str_FullName.CurrentValue); // DN
                str_FullName.ViewCustomAttributes = "";

                // str_Username
                curVal = ConvertToString(str_Username.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Username.ViewValue = str_Username.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                        sqlWrk = str_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Username.Lookup != null) { // Lookup values found
                            var listwrk = str_Username.Lookup?.RenderViewRow(rswrk[0]);
                            str_Username.ViewValue = str_Username.HighlightLookup(ConvertToString(rswrk[0]), str_Username.DisplayValue(listwrk));
                        } else {
                            str_Username.ViewValue = str_Username.CurrentValue;
                        }
                    }
                } else {
                    str_Username.ViewValue = DbNullValue;
                }
                str_Username.ViewCustomAttributes = "";

                // int_CR_ID
                int_CR_ID.ViewValue = int_CR_ID.CurrentValue;
                int_CR_ID.ViewValue = FormatNumber(int_CR_ID.ViewValue, int_CR_ID.FormatPattern);
                int_CR_ID.ViewCustomAttributes = "";

                // int_CRSession_ID
                int_CRSession_ID.ViewValue = int_CRSession_ID.CurrentValue;
                int_CRSession_ID.ViewValue = FormatNumber(int_CRSession_ID.ViewValue, int_CRSession_ID.FormatPattern);
                int_CRSession_ID.ViewCustomAttributes = "";

                // Is_All_Attend
                if (ConvertToBool(Is_All_Attend.CurrentValue)) {
                    Is_All_Attend.ViewValue = Is_All_Attend.TagCaption(1) != "" ? Is_All_Attend.TagCaption(1) : "Yes";
                } else {
                    Is_All_Attend.ViewValue = Is_All_Attend.TagCaption(2) != "" ? Is_All_Attend.TagCaption(2) : "No";
                }
                Is_All_Attend.CellCssStyle += "text-align: center;";
                Is_All_Attend.ViewCustomAttributes = "";

                // idnumber
                idnumber.ViewValue = ConvertToString(idnumber.CurrentValue); // DN
                curVal = ConvertToString(idnumber.CurrentValue);
                if (!Empty(curVal)) {
                    if (idnumber.Lookup != null && IsDictionary(idnumber.Lookup?.Options) && idnumber.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        idnumber.ViewValue = idnumber.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[course]", "=", idnumber.CurrentValue, DataType.String, "");
                        sqlWrk = idnumber.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && idnumber.Lookup != null) { // Lookup values found
                            var listwrk = idnumber.Lookup?.RenderViewRow(rswrk[0]);
                            idnumber.ViewValue = idnumber.HighlightLookup(ConvertToString(rswrk[0]), idnumber.DisplayValue(listwrk));
                        } else {
                            idnumber.ViewValue = idnumber.CurrentValue;
                        }
                    }
                } else {
                    idnumber.ViewValue = DbNullValue;
                }
                idnumber.ViewCustomAttributes = "";

                // course_id
                course_id.ViewValue = course_id.CurrentValue;
                course_id.ViewValue = FormatNumber(course_id.ViewValue, course_id.FormatPattern);
                course_id.ViewCustomAttributes = "";

                // str_Test_Score
                str_Test_Score.ViewValue = ConvertToString(str_Test_Score.CurrentValue); // DN
                str_Test_Score.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // bit_IsDeleted
                if (ConvertToBool(bit_IsDeleted.CurrentValue)) {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
                } else {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(2) != "" ? bit_IsDeleted.TagCaption(2) : "No";
                }
                bit_IsDeleted.CellCssStyle += "text-align: center;";
                bit_IsDeleted.ViewCustomAttributes = "";

                // int_Created_BY
                int_Created_BY.ViewValue = int_Created_BY.CurrentValue;
                int_Created_BY.ViewValue = FormatNumber(int_Created_BY.ViewValue, int_Created_BY.FormatPattern);
                int_Created_BY.ViewCustomAttributes = "";

                // int_Modified_BY
                int_Modified_BY.ViewValue = int_Modified_BY.CurrentValue;
                int_Modified_BY.ViewValue = FormatNumber(int_Modified_BY.ViewValue, int_Modified_BY.FormatPattern);
                int_Modified_BY.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // date_Modified
                date_Modified.ViewValue = date_Modified.CurrentValue;
                date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
                date_Modified.ViewCustomAttributes = "";

                // bit_IsMakeUP
                if (ConvertToBool(bit_IsMakeUP.CurrentValue)) {
                    bit_IsMakeUP.ViewValue = bit_IsMakeUP.TagCaption(1) != "" ? bit_IsMakeUP.TagCaption(1) : "Yes";
                } else {
                    bit_IsMakeUP.ViewValue = bit_IsMakeUP.TagCaption(2) != "" ? bit_IsMakeUP.TagCaption(2) : "No";
                }
                bit_IsMakeUP.CellCssStyle += "text-align: center;";
                bit_IsMakeUP.ViewCustomAttributes = "";

                // dec_Orginal_SessionID
                dec_Orginal_SessionID.ViewValue = dec_Orginal_SessionID.CurrentValue;
                dec_Orginal_SessionID.ViewValue = FormatNumber(dec_Orginal_SessionID.ViewValue, dec_Orginal_SessionID.FormatPattern);
                dec_Orginal_SessionID.ViewCustomAttributes = "";

                // dec_CR_ID_For_Del
                dec_CR_ID_For_Del.ViewValue = dec_CR_ID_For_Del.CurrentValue;
                dec_CR_ID_For_Del.ViewValue = FormatNumber(dec_CR_ID_For_Del.ViewValue, dec_CR_ID_For_Del.FormatPattern);
                dec_CR_ID_For_Del.ViewCustomAttributes = "";

                // int_Session_ID_For_Del
                int_Session_ID_For_Del.ViewValue = int_Session_ID_For_Del.CurrentValue;
                int_Session_ID_For_Del.ViewValue = FormatNumber(int_Session_ID_For_Del.ViewValue, int_Session_ID_For_Del.FormatPattern);
                int_Session_ID_For_Del.ViewCustomAttributes = "";

                // RemM1
                if (ConvertToBool(RemM1.CurrentValue)) {
                    RemM1.ViewValue = RemM1.TagCaption(1) != "" ? RemM1.TagCaption(1) : "Yes";
                } else {
                    RemM1.ViewValue = RemM1.TagCaption(2) != "" ? RemM1.TagCaption(2) : "No";
                }
                RemM1.CellCssStyle += "text-align: center;";
                RemM1.ViewCustomAttributes = "";

                // RemM2
                if (ConvertToBool(RemM2.CurrentValue)) {
                    RemM2.ViewValue = RemM2.TagCaption(1) != "" ? RemM2.TagCaption(1) : "Yes";
                } else {
                    RemM2.ViewValue = RemM2.TagCaption(2) != "" ? RemM2.TagCaption(2) : "No";
                }
                RemM2.ViewCustomAttributes = "";

                // RemM3
                if (ConvertToBool(RemM3.CurrentValue)) {
                    RemM3.ViewValue = RemM3.TagCaption(1) != "" ? RemM3.TagCaption(1) : "Yes";
                } else {
                    RemM3.ViewValue = RemM3.TagCaption(2) != "" ? RemM3.TagCaption(2) : "No";
                }
                RemM3.ViewCustomAttributes = "";

                // SMSReminder1
                if (ConvertToBool(SMSReminder1.CurrentValue)) {
                    SMSReminder1.ViewValue = SMSReminder1.TagCaption(1) != "" ? SMSReminder1.TagCaption(1) : "Yes";
                } else {
                    SMSReminder1.ViewValue = SMSReminder1.TagCaption(2) != "" ? SMSReminder1.TagCaption(2) : "No";
                }
                SMSReminder1.CellCssStyle += "text-align: center;";
                SMSReminder1.ViewCustomAttributes = "";

                // SMSReminder2
                if (ConvertToBool(SMSReminder2.CurrentValue)) {
                    SMSReminder2.ViewValue = SMSReminder2.TagCaption(1) != "" ? SMSReminder2.TagCaption(1) : "Yes";
                } else {
                    SMSReminder2.ViewValue = SMSReminder2.TagCaption(2) != "" ? SMSReminder2.TagCaption(2) : "No";
                }
                SMSReminder2.ViewCustomAttributes = "";

                // SMSReminder3
                if (ConvertToBool(SMSReminder3.CurrentValue)) {
                    SMSReminder3.ViewValue = SMSReminder3.TagCaption(1) != "" ? SMSReminder3.TagCaption(1) : "Yes";
                } else {
                    SMSReminder3.ViewValue = SMSReminder3.TagCaption(2) != "" ? SMSReminder3.TagCaption(2) : "No";
                }
                SMSReminder3.ViewCustomAttributes = "";

                // VoiceReminder1
                if (ConvertToBool(VoiceReminder1.CurrentValue)) {
                    VoiceReminder1.ViewValue = VoiceReminder1.TagCaption(1) != "" ? VoiceReminder1.TagCaption(1) : "Yes";
                } else {
                    VoiceReminder1.ViewValue = VoiceReminder1.TagCaption(2) != "" ? VoiceReminder1.TagCaption(2) : "No";
                }
                VoiceReminder1.ViewCustomAttributes = "";

                // VoiceReminder2
                if (ConvertToBool(VoiceReminder2.CurrentValue)) {
                    VoiceReminder2.ViewValue = VoiceReminder2.TagCaption(1) != "" ? VoiceReminder2.TagCaption(1) : "Yes";
                } else {
                    VoiceReminder2.ViewValue = VoiceReminder2.TagCaption(2) != "" ? VoiceReminder2.TagCaption(2) : "No";
                }
                VoiceReminder2.ViewCustomAttributes = "";

                // VoiceReminder3
                if (ConvertToBool(VoiceReminder3.CurrentValue)) {
                    VoiceReminder3.ViewValue = VoiceReminder3.TagCaption(1) != "" ? VoiceReminder3.TagCaption(1) : "Yes";
                } else {
                    VoiceReminder3.ViewValue = VoiceReminder3.TagCaption(2) != "" ? VoiceReminder3.TagCaption(2) : "No";
                }
                VoiceReminder3.ViewCustomAttributes = "";

                // strParentName
                strParentName.ViewValue = ConvertToString(strParentName.CurrentValue); // DN
                strParentName.ViewCustomAttributes = "";

                // strParentState
                strParentState.ViewValue = ConvertToString(strParentState.CurrentValue); // DN
                strParentState.ViewCustomAttributes = "";

                // strParentLicenseNumber
                strParentLicenseNumber.ViewValue = ConvertToString(strParentLicenseNumber.CurrentValue); // DN
                strParentLicenseNumber.ViewCustomAttributes = "";

                // CRSS_ID
                CRSS_ID.ViewValue = CRSS_ID.CurrentValue;
                CRSS_ID.ViewValue = FormatNumber(CRSS_ID.ViewValue, CRSS_ID.FormatPattern);
                CRSS_ID.ViewCustomAttributes = "";

                // str_CR_Number
                curVal = ConvertToString(str_CR_Number.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_CR_Number.Lookup != null && IsDictionary(str_CR_Number.Lookup?.Options) && str_CR_Number.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_CR_Number.ViewValue = str_CR_Number.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_CR_Number]", "=", str_CR_Number.CurrentValue, DataType.String, "");
                        sqlWrk = str_CR_Number.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_CR_Number.Lookup != null) { // Lookup values found
                            var listwrk = str_CR_Number.Lookup?.RenderViewRow(rswrk[0]);
                            str_CR_Number.ViewValue = str_CR_Number.HighlightLookup(ConvertToString(rswrk[0]), str_CR_Number.DisplayValue(listwrk));
                        } else {
                            str_CR_Number.ViewValue = str_CR_Number.CurrentValue;
                        }
                    }
                } else {
                    str_CR_Number.ViewValue = DbNullValue;
                }
                str_CR_Number.ViewCustomAttributes = "";

                // str_FullName
                str_FullName.HrefValue = "";
                str_FullName.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // int_CR_ID
                int_CR_ID.HrefValue = "";
                int_CR_ID.TooltipValue = "";

                // int_CRSession_ID
                int_CRSession_ID.HrefValue = "";
                int_CRSession_ID.TooltipValue = "";

                // Is_All_Attend
                Is_All_Attend.HrefValue = "";
                Is_All_Attend.TooltipValue = "";

                // idnumber
                idnumber.HrefValue = "";
                idnumber.TooltipValue = "";

                // bit_IsMakeUP
                bit_IsMakeUP.HrefValue = "";
                bit_IsMakeUP.TooltipValue = "";

                // RemM1
                RemM1.HrefValue = "";
                RemM1.TooltipValue = "";

                // SMSReminder1
                SMSReminder1.HrefValue = "";
                SMSReminder1.TooltipValue = "";
            } else if (RowType == RowType.Add) {
                // str_FullName
                str_FullName.SetupEditAttributes();
                if (!str_FullName.Raw)
                    str_FullName.CurrentValue = HtmlDecode(str_FullName.CurrentValue);
                str_FullName.EditValue = HtmlEncode(str_FullName.CurrentValue);
                str_FullName.PlaceHolder = RemoveHtml(str_FullName.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                curVal = ConvertToString(str_Username.CurrentValue)?.Trim() ?? "";
                if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Username.EditValue = str_Username.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = str_Username.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_Username.EditValue = rswrk;
                }
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // int_CR_ID
                int_CR_ID.SetupEditAttributes();
                int_CR_ID.EditValue = int_CR_ID.CurrentValue; // DN
                int_CR_ID.PlaceHolder = RemoveHtml(int_CR_ID.Caption);
                if (!Empty(int_CR_ID.EditValue) && IsNumeric(int_CR_ID.EditValue))
                    int_CR_ID.EditValue = FormatNumber(int_CR_ID.EditValue, null);

                // int_CRSession_ID
                int_CRSession_ID.SetupEditAttributes();
                int_CRSession_ID.EditValue = int_CRSession_ID.CurrentValue; // DN
                int_CRSession_ID.PlaceHolder = RemoveHtml(int_CRSession_ID.Caption);
                if (!Empty(int_CRSession_ID.EditValue) && IsNumeric(int_CRSession_ID.EditValue))
                    int_CRSession_ID.EditValue = FormatNumber(int_CRSession_ID.EditValue, null);

                // Is_All_Attend
                Is_All_Attend.EditValue = Is_All_Attend.Options(false);
                Is_All_Attend.PlaceHolder = RemoveHtml(Is_All_Attend.Caption);

                // idnumber
                idnumber.SetupEditAttributes();
                if (!idnumber.Raw)
                    idnumber.CurrentValue = HtmlDecode(idnumber.CurrentValue);
                idnumber.EditValue = HtmlEncode(idnumber.CurrentValue);
                curVal = ConvertToString(idnumber.CurrentValue);
                if (!Empty(curVal)) {
                    if (idnumber.Lookup != null && IsDictionary(idnumber.Lookup?.Options) && idnumber.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        idnumber.EditValue = idnumber.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[course]", "=", idnumber.CurrentValue, DataType.String, "");
                        sqlWrk = idnumber.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && idnumber.Lookup != null) { // Lookup values found
                            var listwrk = idnumber.Lookup?.RenderViewRow(rswrk[0]);
                            idnumber.EditValue = idnumber.HighlightLookup(ConvertToString(rswrk[0]), idnumber.DisplayValue(listwrk));
                        } else {
                            idnumber.EditValue = HtmlEncode(idnumber.CurrentValue);
                        }
                    }
                } else {
                    idnumber.EditValue = DbNullValue;
                }
                idnumber.PlaceHolder = RemoveHtml(idnumber.Caption);

                // bit_IsMakeUP
                bit_IsMakeUP.EditValue = bit_IsMakeUP.Options(false);
                bit_IsMakeUP.PlaceHolder = RemoveHtml(bit_IsMakeUP.Caption);

                // RemM1
                RemM1.EditValue = RemM1.Options(false);
                RemM1.PlaceHolder = RemoveHtml(RemM1.Caption);

                // SMSReminder1
                SMSReminder1.EditValue = SMSReminder1.Options(false);
                SMSReminder1.PlaceHolder = RemoveHtml(SMSReminder1.Caption);

                // Add refer script

                // str_FullName
                str_FullName.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // int_CR_ID
                int_CR_ID.HrefValue = "";

                // int_CRSession_ID
                int_CRSession_ID.HrefValue = "";

                // Is_All_Attend
                Is_All_Attend.HrefValue = "";

                // idnumber
                idnumber.HrefValue = "";

                // bit_IsMakeUP
                bit_IsMakeUP.HrefValue = "";

                // RemM1
                RemM1.HrefValue = "";

                // SMSReminder1
                SMSReminder1.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // str_FullName
                str_FullName.SetupEditAttributes();
                str_FullName.EditValue = ConvertToString(str_FullName.CurrentValue); // DN
                str_FullName.ViewCustomAttributes = "";

                // str_Username
                str_Username.SetupEditAttributes();
                curVal = ConvertToString(str_Username.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Username.EditValue = str_Username.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                        sqlWrk = str_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Username.Lookup != null) { // Lookup values found
                            var listwrk = str_Username.Lookup?.RenderViewRow(rswrk[0]);
                            str_Username.EditValue = str_Username.HighlightLookup(ConvertToString(rswrk[0]), str_Username.DisplayValue(listwrk));
                        } else {
                            str_Username.EditValue = str_Username.CurrentValue;
                        }
                    }
                } else {
                    str_Username.EditValue = DbNullValue;
                }
                str_Username.ViewCustomAttributes = "";

                // int_CR_ID
                int_CR_ID.SetupEditAttributes();
                int_CR_ID.EditValue = int_CR_ID.CurrentValue;
                int_CR_ID.EditValue = FormatNumber(int_CR_ID.EditValue, int_CR_ID.FormatPattern);
                int_CR_ID.ViewCustomAttributes = "";

                // int_CRSession_ID
                int_CRSession_ID.SetupEditAttributes();
                int_CRSession_ID.EditValue = int_CRSession_ID.CurrentValue;
                int_CRSession_ID.EditValue = FormatNumber(int_CRSession_ID.EditValue, int_CRSession_ID.FormatPattern);
                int_CRSession_ID.ViewCustomAttributes = "";

                // Is_All_Attend
                Is_All_Attend.EditValue = Is_All_Attend.Options(false);
                Is_All_Attend.PlaceHolder = RemoveHtml(Is_All_Attend.Caption);

                // idnumber
                idnumber.SetupEditAttributes();
                idnumber.EditValue = ConvertToString(idnumber.CurrentValue); // DN
                curVal = ConvertToString(idnumber.CurrentValue);
                if (!Empty(curVal)) {
                    if (idnumber.Lookup != null && IsDictionary(idnumber.Lookup?.Options) && idnumber.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        idnumber.EditValue = idnumber.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[course]", "=", idnumber.CurrentValue, DataType.String, "");
                        sqlWrk = idnumber.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && idnumber.Lookup != null) { // Lookup values found
                            var listwrk = idnumber.Lookup?.RenderViewRow(rswrk[0]);
                            idnumber.EditValue = idnumber.HighlightLookup(ConvertToString(rswrk[0]), idnumber.DisplayValue(listwrk));
                        } else {
                            idnumber.EditValue = idnumber.CurrentValue;
                        }
                    }
                } else {
                    idnumber.EditValue = DbNullValue;
                }
                idnumber.ViewCustomAttributes = "";

                // bit_IsMakeUP
                bit_IsMakeUP.EditValue = bit_IsMakeUP.Options(false);
                bit_IsMakeUP.PlaceHolder = RemoveHtml(bit_IsMakeUP.Caption);

                // RemM1
                RemM1.EditValue = RemM1.Options(false);
                RemM1.PlaceHolder = RemoveHtml(RemM1.Caption);

                // SMSReminder1
                SMSReminder1.EditValue = SMSReminder1.Options(false);
                SMSReminder1.PlaceHolder = RemoveHtml(SMSReminder1.Caption);

                // Edit refer script

                // str_FullName
                str_FullName.HrefValue = "";
                str_FullName.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // int_CR_ID
                int_CR_ID.HrefValue = "";
                int_CR_ID.TooltipValue = "";

                // int_CRSession_ID
                int_CRSession_ID.HrefValue = "";
                int_CRSession_ID.TooltipValue = "";

                // Is_All_Attend
                Is_All_Attend.HrefValue = "";

                // idnumber
                idnumber.HrefValue = "";
                idnumber.TooltipValue = "";

                // bit_IsMakeUP
                bit_IsMakeUP.HrefValue = "";

                // RemM1
                RemM1.HrefValue = "";

                // SMSReminder1
                SMSReminder1.HrefValue = "";
            } else if (RowType == RowType.Search) {
                // str_FullName
                str_FullName.SetupEditAttributes();
                if (!str_FullName.Raw)
                    str_FullName.AdvancedSearch.SearchValue = HtmlDecode(str_FullName.AdvancedSearch.SearchValue);
                str_FullName.EditValue = HtmlEncode(str_FullName.AdvancedSearch.SearchValue);
                str_FullName.PlaceHolder = RemoveHtml(str_FullName.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                curVal = ConvertToString(str_Username.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Username.EditValue = str_Username.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Username]", "=", str_Username.AdvancedSearch.SearchValue, DataType.String, "");
                    }
                    sqlWrk = str_Username.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_Username.EditValue = rswrk;
                }
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // int_CR_ID
                int_CR_ID.SetupEditAttributes();
                int_CR_ID.EditValue = int_CR_ID.AdvancedSearch.SearchValue; // DN
                int_CR_ID.PlaceHolder = RemoveHtml(int_CR_ID.Caption);

                // int_CRSession_ID
                int_CRSession_ID.SetupEditAttributes();
                int_CRSession_ID.EditValue = int_CRSession_ID.AdvancedSearch.SearchValue; // DN
                int_CRSession_ID.PlaceHolder = RemoveHtml(int_CRSession_ID.Caption);

                // Is_All_Attend
                Is_All_Attend.EditValue = Is_All_Attend.Options(false);
                Is_All_Attend.PlaceHolder = RemoveHtml(Is_All_Attend.Caption);

                // idnumber
                idnumber.SetupEditAttributes();
                if (!idnumber.Raw)
                    idnumber.AdvancedSearch.SearchValue = HtmlDecode(idnumber.AdvancedSearch.SearchValue);
                idnumber.EditValue = HtmlEncode(idnumber.AdvancedSearch.SearchValue);
                curVal = ConvertToString(idnumber.AdvancedSearch.SearchValue);
                if (!Empty(curVal)) {
                    if (idnumber.Lookup != null && IsDictionary(idnumber.Lookup?.Options) && idnumber.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        idnumber.EditValue = idnumber.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[course]", "=", idnumber.AdvancedSearch.SearchValue, DataType.String, "");
                        sqlWrk = idnumber.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && idnumber.Lookup != null) { // Lookup values found
                            var listwrk = idnumber.Lookup?.RenderViewRow(rswrk[0]);
                            idnumber.EditValue = idnumber.HighlightLookup(ConvertToString(rswrk[0]), idnumber.DisplayValue(listwrk));
                        } else {
                            idnumber.EditValue = HtmlEncode(idnumber.AdvancedSearch.SearchValue);
                        }
                    }
                } else {
                    idnumber.EditValue = DbNullValue;
                }
                idnumber.PlaceHolder = RemoveHtml(idnumber.Caption);

                // bit_IsMakeUP
                bit_IsMakeUP.EditValue = bit_IsMakeUP.Options(false);
                bit_IsMakeUP.PlaceHolder = RemoveHtml(bit_IsMakeUP.Caption);

                // RemM1
                RemM1.EditValue = RemM1.Options(false);
                RemM1.PlaceHolder = RemoveHtml(RemM1.Caption);

                // SMSReminder1
                SMSReminder1.EditValue = SMSReminder1.Options(false);
                SMSReminder1.PlaceHolder = RemoveHtml(SMSReminder1.Caption);
            }
            if (RowType == RowType.Add || RowType == RowType.Edit || RowType == RowType.Search) // Add/Edit/Search row
                SetupFieldTitles();

            // Call Row Rendered event
            if (RowType != RowType.AggregateInit)
                RowRendered();
        }
        #pragma warning restore 1998

        // Validate search
        protected bool ValidateSearch() {
            // Check if validation required
            if (!Config.ServerValidate)
                return true;

            // Return validate result
            bool validateSearch = !HasInvalidFields();

            // Call Form CustomValidate event
            string formCustomError = "";
            validateSearch = validateSearch && FormCustomValidate(ref formCustomError);
            if (!Empty(formCustomError))
                FailureMessage = formCustomError;
            return validateSearch;
        }

        #pragma warning disable 1998
        // Validate form
        protected async Task<bool> ValidateForm() {
            // Check if validation required
            if (!Config.ServerValidate)
                return true;
            bool validateForm = true;
            if (str_FullName.Required) {
                if (!str_FullName.IsDetailKey && Empty(str_FullName.FormValue)) {
                    str_FullName.AddErrorMessage(ConvertToString(str_FullName.RequiredErrorMessage).Replace("%s", str_FullName.Caption));
                }
            }
            if (str_Username.Required) {
                if (!str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (int_CR_ID.Required) {
                if (!int_CR_ID.IsDetailKey && Empty(int_CR_ID.FormValue)) {
                    int_CR_ID.AddErrorMessage(ConvertToString(int_CR_ID.RequiredErrorMessage).Replace("%s", int_CR_ID.Caption));
                }
            }
            if (int_CRSession_ID.Required) {
                if (!int_CRSession_ID.IsDetailKey && Empty(int_CRSession_ID.FormValue)) {
                    int_CRSession_ID.AddErrorMessage(ConvertToString(int_CRSession_ID.RequiredErrorMessage).Replace("%s", int_CRSession_ID.Caption));
                }
            }
            if (Is_All_Attend.Required) {
                if (Empty(Is_All_Attend.FormValue)) {
                    Is_All_Attend.AddErrorMessage(ConvertToString(Is_All_Attend.RequiredErrorMessage).Replace("%s", Is_All_Attend.Caption));
                }
            }
            if (idnumber.Required) {
                if (!idnumber.IsDetailKey && Empty(idnumber.FormValue)) {
                    idnumber.AddErrorMessage(ConvertToString(idnumber.RequiredErrorMessage).Replace("%s", idnumber.Caption));
                }
            }
            if (bit_IsMakeUP.Required) {
                if (Empty(bit_IsMakeUP.FormValue)) {
                    bit_IsMakeUP.AddErrorMessage(ConvertToString(bit_IsMakeUP.RequiredErrorMessage).Replace("%s", bit_IsMakeUP.Caption));
                }
            }
            if (RemM1.Required) {
                if (Empty(RemM1.FormValue)) {
                    RemM1.AddErrorMessage(ConvertToString(RemM1.RequiredErrorMessage).Replace("%s", RemM1.Caption));
                }
            }
            if (SMSReminder1.Required) {
                if (Empty(SMSReminder1.FormValue)) {
                    SMSReminder1.AddErrorMessage(ConvertToString(SMSReminder1.RequiredErrorMessage).Replace("%s", SMSReminder1.Caption));
                }
            }

            // Return validate result
            validateForm = validateForm && !HasInvalidFields();

            // Call Form CustomValidate event
            string formCustomError = "";
            validateForm = validateForm && FormCustomValidate(ref formCustomError);
            if (!Empty(formCustomError))
                FailureMessage = formCustomError;
            return validateForm;
        }
        #pragma warning restore 1998

        // Delete records (based on current filter)
        protected async Task<JsonBoolResult> DeleteRows() { // DN
            if (!Security.CanDelete) {
                FailureMessage = Language.Phrase("NoDeletePermission"); // No delete permission
                return JsonBoolResult.FalseResult; // No delete permission
            }
            List<Dictionary<string, object>>? rsold = null;
            bool result = true;
            try {
                string sql = CurrentSql;
                using var rs = await Connection.GetDataReaderAsync(sql);
                if (rs == null) {
                    return JsonBoolResult.FalseResult;
                } else if (!rs.HasRows) {
                    FailureMessage = Language.Phrase("NoRecord"); // No record found
                    return JsonBoolResult.FalseResult;
                } else { // Clone old rows
                    rsold = await Connection.GetRowsAsync(rs);
                }
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }
            if (AuditTrailOnDelete)
                await WriteAuditTrailLog(Language.Phrase("BatchDeleteBegin")); // Batch delete begin
            List<string> successKeys = new (), failKeys = new ();
            try {
                // Call Row Deleting event
                if (result)
                    result = rsold.All(row => RowDeleting(row));
                if (result) {
                    foreach (var row in rsold) {
                        try {
                            result = await DeleteAsync(row) > 0;
                        } catch (Exception e) {
                            if (Config.Debug)
                                throw;
                            FailureMessage = e.Message; // Set up error message
                            result = false;
                        }
                        if (!result) {
                            if (UseTransaction) {
                                successKeys.Clear();
                                break;
                            }
                            failKeys.Add(GetKey(row)); // DN
                        } else {
                            if (Config.DeleteUploadFiles)
                                DeleteUploadedFiles(row);
                            RowDeleted(row);
                            successKeys.Add(GetKey(row)); // DN
                        }
                    }
                }
                result = successKeys.Count > 0;
                if (!result) {
                    // Set up error message
                    if (!Empty(SuccessMessage) || !Empty(FailureMessage)) {
                        // Use the message, do nothing
                    } else if (!Empty(CancelMessage)) {
                        FailureMessage = CancelMessage;
                        CancelMessage = "";
                    } else {
                        FailureMessage = Language.Phrase("DeleteCancelled");
                    }
                }
            } catch (Exception e) {
                FailureMessage = e.Message;
                result = false;
            }

            // Write JSON for API request
            Dictionary<string, object> d = new ();
            d.Add("success", result);
            if (IsJsonResponse() && result) {
                var rows = await GetRecordsFromRecordset(rsold);
                string table = TableVar;
                d.Add(table, RouteValues.Count > 2 && rows.Count == 1 ? rows[0] : rows); // If single-delete, route values are controller/action/id (count > 2)
                d.Add("action", Config.ApiDeleteAction);
                d.Add("version", Config.ProductVersion);
                return new JsonBoolResult(d, true);
            }
            return new JsonBoolResult(d, result);
        }

        // Update record based on key values
        #pragma warning disable 168, 219

        protected async Task<JsonBoolResult> EditRow() { // DN
            bool result = false;
            Dictionary<string, object> rsold;
            string oldKeyFilter = GetRecordFilter();
            string filter = ApplyUserIDFilters(oldKeyFilter);

            // Load old row
            CurrentFilter = filter;
            string sql = CurrentSql;
            try {
                using var rsedit = await Connection.GetDataReaderAsync(sql);
                if (rsedit == null || !await rsedit.ReadAsync()) {
                    FailureMessage = Language.Phrase("NoRecord"); // Set no record message
                    return JsonBoolResult.FalseResult;
                }
                rsold = Connection.GetRow(rsedit);
                LoadDbValues(rsold);
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }

            // Set new row
            Dictionary<string, object> rsnew = new ();

            // Is_All_Attend
            Is_All_Attend.SetDbValue(rsnew, ConvertToBool(Is_All_Attend.CurrentValue), Is_All_Attend.ReadOnly);

            // bit_IsMakeUP
            bit_IsMakeUP.SetDbValue(rsnew, ConvertToBool(bit_IsMakeUP.CurrentValue), bit_IsMakeUP.ReadOnly);

            // RemM1
            RemM1.SetDbValue(rsnew, ConvertToBool(RemM1.CurrentValue), RemM1.ReadOnly);

            // SMSReminder1
            SMSReminder1.SetDbValue(rsnew, ConvertToBool(SMSReminder1.CurrentValue), SMSReminder1.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

            // Call Row Updating event
            bool updateRow = RowUpdating(rsold, rsnew);
            if (updateRow) {
                try {
                    if (rsnew.Count > 0)
                        result = await UpdateAsync(rsnew, null, rsold) > 0;
                    else
                        result = true;
                    if (result) {
                    }
                } catch (Exception e) {
                    if (Config.Debug)
                        throw;
                    FailureMessage = e.Message;
                    return JsonBoolResult.FalseResult;
                }
            } else {
                if (!Empty(SuccessMessage) || !Empty(FailureMessage)) {
                    // Use the message, do nothing
                } else if (!Empty(CancelMessage)) {
                    FailureMessage = CancelMessage;
                    CancelMessage = "";
                } else {
                    FailureMessage = Language.Phrase("UpdateCancelled");
                }
                result = false;
            }

            // Call Row Updated event
            if (result)
                RowUpdated(rsold, rsnew);

            // Write JSON for API request
            Dictionary<string, object> d = new ();
            d.Add("success", result);
            if (IsJsonResponse() && result) {
                if (GetRecordFromDictionary(rsnew) is var row && row != null) {
                    string table = TableVar;
                    d.Add(table, row);
                }
                d.Add("action", Config.ApiEditAction);
                d.Add("version", Config.ProductVersion);
                return new JsonBoolResult(d, true);
            }
            return new JsonBoolResult(d, result);
        }

        // Load row hash
        protected async Task LoadRowHash() {
            string filter = GetRecordFilter();

            // Load SQL based on filter
            CurrentFilter = filter;
            string sql = CurrentSql;
            try {
                var row = await Connection.GetRowAsync(sql);
                if (row != null) {
                    HashValue = GetRowHash(row);
                } else {
                    HashValue = "";
                }
            } catch {
                if (Config.Debug)
                    throw;
                HashValue = "";
            }
        }

        // Get Row Hash
        public string GetRowHash(Dictionary<string, object>? row)
        {
            if (row == null)
                return "";
            string hash = "";
            hash += GetFieldHash(row["Is_All_Attend"], DataType.Boolean); // Is_All_Attend
            hash += GetFieldHash(row["bit_IsMakeUP"], DataType.Boolean); // bit_IsMakeUP
            hash += GetFieldHash(row["RemM1"], DataType.Boolean); // RemM1
            hash += GetFieldHash(row["SMSReminder1"], DataType.Boolean); // SMSReminder1
            return hash;
        }

        // Get Row Hash
        public string GetRowHash(DbDataReader? dr)
        {
            if (dr == null)
                return "";
            var row = new Dictionary<string, object>();
            row.Add("Is_All_Attend", dr["Is_All_Attend"]); // Is_All_Attend
            row.Add("bit_IsMakeUP", dr["bit_IsMakeUP"]); // bit_IsMakeUP
            row.Add("RemM1", dr["RemM1"]); // RemM1
            row.Add("SMSReminder1", dr["SMSReminder1"]); // SMSReminder1
            return GetRowHash(row);
        }

        // Add record
        #pragma warning disable 168, 219

        protected async Task<JsonBoolResult> AddRow(Dictionary<string, object>? rsold = null) { // DN
            bool result = false;

            // Set new row
            Dictionary<string, object> rsnew = new ();
            try {
                // str_FullName
                str_FullName.SetDbValue(rsnew, str_FullName.CurrentValue);

                // str_Username
                str_Username.SetDbValue(rsnew, str_Username.CurrentValue);

                // int_CR_ID
                int_CR_ID.SetDbValue(rsnew, int_CR_ID.CurrentValue);

                // int_CRSession_ID
                int_CRSession_ID.SetDbValue(rsnew, int_CRSession_ID.CurrentValue);

                // Is_All_Attend
                Is_All_Attend.SetDbValue(rsnew, ConvertToBool(Is_All_Attend.CurrentValue));

                // idnumber
                idnumber.SetDbValue(rsnew, idnumber.CurrentValue);

                // bit_IsMakeUP
                bit_IsMakeUP.SetDbValue(rsnew, ConvertToBool(bit_IsMakeUP.CurrentValue));

                // RemM1
                RemM1.SetDbValue(rsnew, ConvertToBool(RemM1.CurrentValue));

                // SMSReminder1
                SMSReminder1.SetDbValue(rsnew, ConvertToBool(SMSReminder1.CurrentValue));
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }

            // Update current values
            SetCurrentValues(rsnew);

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
                    rsnew["int_Attendance_ID"] = int_Attendance_ID.CurrentValue!;
                } catch (Exception e) {
                    if (Config.Debug)
                        throw;
                    FailureMessage = e.Message;
                    result = false;
                }
            } else {
                if (SuccessMessage != "" || FailureMessage != "") {
                    // Use the message, do nothing
                } else if (CancelMessage != "") {
                    FailureMessage = CancelMessage;
                    CancelMessage = "";
                } else {
                    FailureMessage = Language.Phrase("InsertCancelled");
                }
                result = false;
            }

            // Call Row Inserted event
            if (result)
                RowInserted(rsold, rsnew);

            // Write JSON for API request
            Dictionary<string, object> d = new ();
            d.Add("success", result);
            if (IsJsonResponse() && result) {
                if (GetRecordFromDictionary(rsnew) is var row && row != null) {
                    string table = TableVar;
                    d.Add(table, row);
                }
                d.Add("action", Config.ApiAddAction);
                d.Add("version", Config.ProductVersion);
                return new JsonBoolResult(d, result);
            }
            return new JsonBoolResult(d, result);
        }

        // Load advanced search
        public void LoadAdvancedSearch()
        {
            int_Attendance_ID.AdvancedSearch.Load();
            int_Student_ID.AdvancedSearch.Load();
            str_FullName.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            int_CR_ID.AdvancedSearch.Load();
            int_CRSession_ID.AdvancedSearch.Load();
            Is_All_Attend.AdvancedSearch.Load();
            idnumber.AdvancedSearch.Load();
            course_id.AdvancedSearch.Load();
            str_Test_Score.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            bit_IsDeleted.AdvancedSearch.Load();
            int_Created_BY.AdvancedSearch.Load();
            int_Modified_BY.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            bit_IsMakeUP.AdvancedSearch.Load();
            dec_Orginal_SessionID.AdvancedSearch.Load();
            dec_CR_ID_For_Del.AdvancedSearch.Load();
            int_Session_ID_For_Del.AdvancedSearch.Load();
            RemM1.AdvancedSearch.Load();
            RemM2.AdvancedSearch.Load();
            RemM3.AdvancedSearch.Load();
            SMSReminder1.AdvancedSearch.Load();
            SMSReminder2.AdvancedSearch.Load();
            SMSReminder3.AdvancedSearch.Load();
            VoiceReminder1.AdvancedSearch.Load();
            VoiceReminder2.AdvancedSearch.Load();
            VoiceReminder3.AdvancedSearch.Load();
            strParentName.AdvancedSearch.Load();
            strParentState.AdvancedSearch.Load();
            strParentLicenseNumber.AdvancedSearch.Load();
            CRSS_ID.AdvancedSearch.Load();
            str_CR_Number.AdvancedSearch.Load();
        }

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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblCRAttendancelist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblCRAttendancelist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblCRAttendancelist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblCRAttendancelist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblCRAttendancesrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
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
