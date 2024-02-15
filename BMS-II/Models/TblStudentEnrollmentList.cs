namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStudentEnrollmentList
    /// </summary>
    public static TblStudentEnrollmentList tblStudentEnrollmentList
    {
        get => HttpData.Get<TblStudentEnrollmentList>("tblStudentEnrollmentList")!;
        set => HttpData["tblStudentEnrollmentList"] = value;
    }

    /// <summary>
    /// Page class for tblStudentEnrollment
    /// </summary>
    public class TblStudentEnrollmentList : TblStudentEnrollmentListBase
    {
        // Constructor
        public TblStudentEnrollmentList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblStudentEnrollmentList() : base()
        {
        }

        // Page Load event
        public override void PageLoad() {
             //Update Classroom Enrollment
        string sUpdateSq77 = "UPD_CR_ENROL";
        Execute (sUpdateSq77); 
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblStudentEnrollmentListBase : TblStudentEnrollment
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblStudentEnrollment";

        // Page object name
        public string PageObjName = "tblStudentEnrollmentList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblStudentEnrollmentlist";

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
        public TblStudentEnrollmentListBase()
        {
            // CSS class name as context
            TableVar = "tblStudentEnrollment";
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

            // Table object (tblStudentEnrollment)
            if (tblStudentEnrollment == null || tblStudentEnrollment is TblStudentEnrollment)
                tblStudentEnrollment = this;

            // Initialize URLs
            AddUrl = "TblStudentEnrollmentAdd";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblStudentEnrollmentDelete";
            MultiUpdateUrl = "TblStudentEnrollmentUpdate";

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
        public string PageName => "TblStudentEnrollmentList";

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
            int_Enrollement_Id.Visible = false;
            str_Full_Name.SetVisibility();
            str_Username.SetVisibility();
            NationalID.Visible = false;
            int_CR_ID.Visible = false;
            int_Student_Id.Visible = false;
            int_BTW_Id.Visible = false;
            int_Item_Id.Visible = false;
            int_Package_Id.Visible = false;
            str_Package_Name.SetVisibility();
            int_PackageCR_Id.Visible = false;
            date_Created.Visible = false;
            date_Modified.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            str_PurchaseAmount.Visible = false;
            int_ApptId.Visible = false;
            course.Visible = false;
            institution.Visible = false;
            str_Notes.Visible = false;
            int_SoldBy.Visible = false;
            int_Bill_ID.Visible = false;
            str_Amount_Pay.Visible = false;
            int_ApptCldr_ID.Visible = false;
            UniqueIdx.Visible = false;
        }

        // Constructor
        public TblStudentEnrollmentListBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblStudentEnrollmentView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Enrollement_Id") ? dict["int_Enrollement_Id"] : int_Enrollement_Id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Enrollement_Id.Visible = false;
            if (IsAddOrEdit)
                str_Username.Visible = false;
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

            // Set up master detail parameters
            SetupMasterParms();

            // Setup other options
            SetupOtherOptions();

            // Set up custom action (compatible with old version)
            ListActions.Add(CustomActions);

            // Set up lookup cache
            await SetupLookupOptions(str_Full_Name);
            await SetupLookupOptions(NationalID);
            await SetupLookupOptions(int_CR_ID);
            await SetupLookupOptions(int_Package_Id);
            await SetupLookupOptions(course);

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblStudentEnrollmentgrid";

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

            // Restore master/detail filter from session
            DbMasterFilter = MasterFilterFromSession;
            DbDetailFilter = DetailFilterFromSession;

            // Add master User ID filter
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin) { // Non system admin
                if (CurrentMasterTable == "tblBillingInfo")
                    DbMasterFilter = AddMasterUserIDFilter(DbMasterFilter, "tblBillingInfo"); // Add master User ID filter
            }
            AddFilter(ref filter, DbDetailFilter);
            AddFilter(ref filter, SearchWhere);

            // Load master record
            if (CurrentMode != "add" && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblBillingInfo") {
                tblBillingInfo = Resolve("tblBillingInfo")!;
                if (tblBillingInfo != null) {
                    using (var rsmaster = await tblBillingInfo.LoadReader(DbMasterFilter)) { // Note: Use {}
                        MasterRecordExists = rsmaster != null && await rsmaster.ReadAsync();
                        if (!MasterRecordExists) {
                            FailureMessage = Language.Phrase("NoRecord"); // Set no record found
                            return Terminate("TblBillingInfoList"); // Return to master page
                        } else {
                            tblBillingInfo.LoadListRowValues(rsmaster);
                        }
                    }
                    tblBillingInfo.RowType = RowType.Master; // Master row
                    await tblBillingInfo.RenderListRow(); // Note: Do it outside "using" // DN
                }
            }

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
                tblStudentEnrollmentList?.PageRender();
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
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblStudentEnrollmentsrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Enrollement_Id.AdvancedSearch.ToJson())); // Field int_Enrollement_Id
            filters.Merge(JObject.Parse(str_Full_Name.AdvancedSearch.ToJson())); // Field str_Full_Name
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(NationalID.AdvancedSearch.ToJson())); // Field NationalID
            filters.Merge(JObject.Parse(int_CR_ID.AdvancedSearch.ToJson())); // Field int_CR_ID
            filters.Merge(JObject.Parse(int_Student_Id.AdvancedSearch.ToJson())); // Field int_Student_Id
            filters.Merge(JObject.Parse(int_BTW_Id.AdvancedSearch.ToJson())); // Field int_BTW_Id
            filters.Merge(JObject.Parse(int_Item_Id.AdvancedSearch.ToJson())); // Field int_Item_Id
            filters.Merge(JObject.Parse(int_Package_Id.AdvancedSearch.ToJson())); // Field int_Package_Id
            filters.Merge(JObject.Parse(str_Package_Name.AdvancedSearch.ToJson())); // Field str_Package_Name
            filters.Merge(JObject.Parse(int_PackageCR_Id.AdvancedSearch.ToJson())); // Field int_PackageCR_Id
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(str_PurchaseAmount.AdvancedSearch.ToJson())); // Field str_PurchaseAmount
            filters.Merge(JObject.Parse(int_ApptId.AdvancedSearch.ToJson())); // Field int_ApptId
            filters.Merge(JObject.Parse(course.AdvancedSearch.ToJson())); // Field course
            filters.Merge(JObject.Parse(institution.AdvancedSearch.ToJson())); // Field institution
            filters.Merge(JObject.Parse(str_Notes.AdvancedSearch.ToJson())); // Field str_Notes
            filters.Merge(JObject.Parse(int_SoldBy.AdvancedSearch.ToJson())); // Field int_SoldBy
            filters.Merge(JObject.Parse(int_Bill_ID.AdvancedSearch.ToJson())); // Field int_Bill_ID
            filters.Merge(JObject.Parse(str_Amount_Pay.AdvancedSearch.ToJson())); // Field str_Amount_Pay
            filters.Merge(JObject.Parse(int_ApptCldr_ID.AdvancedSearch.ToJson())); // Field int_ApptCldr_ID
            filters.Merge(JObject.Parse(UniqueIdx.AdvancedSearch.ToJson())); // Field UniqueIdx
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblStudentEnrollmentsrch", filters);
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

            // Field int_Enrollement_Id
            if (filter?.TryGetValue("x_int_Enrollement_Id", out sv) ?? false) {
                int_Enrollement_Id.AdvancedSearch.SearchValue = sv;
                int_Enrollement_Id.AdvancedSearch.SearchOperator = filter["z_int_Enrollement_Id"];
                int_Enrollement_Id.AdvancedSearch.SearchCondition = filter["v_int_Enrollement_Id"];
                int_Enrollement_Id.AdvancedSearch.SearchValue2 = filter["y_int_Enrollement_Id"];
                int_Enrollement_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Enrollement_Id"];
                int_Enrollement_Id.AdvancedSearch.Save();
            }

            // Field str_Full_Name
            if (filter?.TryGetValue("x_str_Full_Name", out sv) ?? false) {
                str_Full_Name.AdvancedSearch.SearchValue = sv;
                str_Full_Name.AdvancedSearch.SearchOperator = filter["z_str_Full_Name"];
                str_Full_Name.AdvancedSearch.SearchCondition = filter["v_str_Full_Name"];
                str_Full_Name.AdvancedSearch.SearchValue2 = filter["y_str_Full_Name"];
                str_Full_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Full_Name"];
                str_Full_Name.AdvancedSearch.Save();
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

            // Field NationalID
            if (filter?.TryGetValue("x_NationalID", out sv) ?? false) {
                NationalID.AdvancedSearch.SearchValue = sv;
                NationalID.AdvancedSearch.SearchOperator = filter["z_NationalID"];
                NationalID.AdvancedSearch.SearchCondition = filter["v_NationalID"];
                NationalID.AdvancedSearch.SearchValue2 = filter["y_NationalID"];
                NationalID.AdvancedSearch.SearchOperator2 = filter["w_NationalID"];
                NationalID.AdvancedSearch.Save();
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

            // Field int_Student_Id
            if (filter?.TryGetValue("x_int_Student_Id", out sv) ?? false) {
                int_Student_Id.AdvancedSearch.SearchValue = sv;
                int_Student_Id.AdvancedSearch.SearchOperator = filter["z_int_Student_Id"];
                int_Student_Id.AdvancedSearch.SearchCondition = filter["v_int_Student_Id"];
                int_Student_Id.AdvancedSearch.SearchValue2 = filter["y_int_Student_Id"];
                int_Student_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Student_Id"];
                int_Student_Id.AdvancedSearch.Save();
            }

            // Field int_BTW_Id
            if (filter?.TryGetValue("x_int_BTW_Id", out sv) ?? false) {
                int_BTW_Id.AdvancedSearch.SearchValue = sv;
                int_BTW_Id.AdvancedSearch.SearchOperator = filter["z_int_BTW_Id"];
                int_BTW_Id.AdvancedSearch.SearchCondition = filter["v_int_BTW_Id"];
                int_BTW_Id.AdvancedSearch.SearchValue2 = filter["y_int_BTW_Id"];
                int_BTW_Id.AdvancedSearch.SearchOperator2 = filter["w_int_BTW_Id"];
                int_BTW_Id.AdvancedSearch.Save();
            }

            // Field int_Item_Id
            if (filter?.TryGetValue("x_int_Item_Id", out sv) ?? false) {
                int_Item_Id.AdvancedSearch.SearchValue = sv;
                int_Item_Id.AdvancedSearch.SearchOperator = filter["z_int_Item_Id"];
                int_Item_Id.AdvancedSearch.SearchCondition = filter["v_int_Item_Id"];
                int_Item_Id.AdvancedSearch.SearchValue2 = filter["y_int_Item_Id"];
                int_Item_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Item_Id"];
                int_Item_Id.AdvancedSearch.Save();
            }

            // Field int_Package_Id
            if (filter?.TryGetValue("x_int_Package_Id", out sv) ?? false) {
                int_Package_Id.AdvancedSearch.SearchValue = sv;
                int_Package_Id.AdvancedSearch.SearchOperator = filter["z_int_Package_Id"];
                int_Package_Id.AdvancedSearch.SearchCondition = filter["v_int_Package_Id"];
                int_Package_Id.AdvancedSearch.SearchValue2 = filter["y_int_Package_Id"];
                int_Package_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Package_Id"];
                int_Package_Id.AdvancedSearch.Save();
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

            // Field int_PackageCR_Id
            if (filter?.TryGetValue("x_int_PackageCR_Id", out sv) ?? false) {
                int_PackageCR_Id.AdvancedSearch.SearchValue = sv;
                int_PackageCR_Id.AdvancedSearch.SearchOperator = filter["z_int_PackageCR_Id"];
                int_PackageCR_Id.AdvancedSearch.SearchCondition = filter["v_int_PackageCR_Id"];
                int_PackageCR_Id.AdvancedSearch.SearchValue2 = filter["y_int_PackageCR_Id"];
                int_PackageCR_Id.AdvancedSearch.SearchOperator2 = filter["w_int_PackageCR_Id"];
                int_PackageCR_Id.AdvancedSearch.Save();
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

            // Field str_PurchaseAmount
            if (filter?.TryGetValue("x_str_PurchaseAmount", out sv) ?? false) {
                str_PurchaseAmount.AdvancedSearch.SearchValue = sv;
                str_PurchaseAmount.AdvancedSearch.SearchOperator = filter["z_str_PurchaseAmount"];
                str_PurchaseAmount.AdvancedSearch.SearchCondition = filter["v_str_PurchaseAmount"];
                str_PurchaseAmount.AdvancedSearch.SearchValue2 = filter["y_str_PurchaseAmount"];
                str_PurchaseAmount.AdvancedSearch.SearchOperator2 = filter["w_str_PurchaseAmount"];
                str_PurchaseAmount.AdvancedSearch.Save();
            }

            // Field int_ApptId
            if (filter?.TryGetValue("x_int_ApptId", out sv) ?? false) {
                int_ApptId.AdvancedSearch.SearchValue = sv;
                int_ApptId.AdvancedSearch.SearchOperator = filter["z_int_ApptId"];
                int_ApptId.AdvancedSearch.SearchCondition = filter["v_int_ApptId"];
                int_ApptId.AdvancedSearch.SearchValue2 = filter["y_int_ApptId"];
                int_ApptId.AdvancedSearch.SearchOperator2 = filter["w_int_ApptId"];
                int_ApptId.AdvancedSearch.Save();
            }

            // Field course
            if (filter?.TryGetValue("x_course", out sv) ?? false) {
                course.AdvancedSearch.SearchValue = sv;
                course.AdvancedSearch.SearchOperator = filter["z_course"];
                course.AdvancedSearch.SearchCondition = filter["v_course"];
                course.AdvancedSearch.SearchValue2 = filter["y_course"];
                course.AdvancedSearch.SearchOperator2 = filter["w_course"];
                course.AdvancedSearch.Save();
            }

            // Field institution
            if (filter?.TryGetValue("x_institution", out sv) ?? false) {
                institution.AdvancedSearch.SearchValue = sv;
                institution.AdvancedSearch.SearchOperator = filter["z_institution"];
                institution.AdvancedSearch.SearchCondition = filter["v_institution"];
                institution.AdvancedSearch.SearchValue2 = filter["y_institution"];
                institution.AdvancedSearch.SearchOperator2 = filter["w_institution"];
                institution.AdvancedSearch.Save();
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

            // Field int_SoldBy
            if (filter?.TryGetValue("x_int_SoldBy", out sv) ?? false) {
                int_SoldBy.AdvancedSearch.SearchValue = sv;
                int_SoldBy.AdvancedSearch.SearchOperator = filter["z_int_SoldBy"];
                int_SoldBy.AdvancedSearch.SearchCondition = filter["v_int_SoldBy"];
                int_SoldBy.AdvancedSearch.SearchValue2 = filter["y_int_SoldBy"];
                int_SoldBy.AdvancedSearch.SearchOperator2 = filter["w_int_SoldBy"];
                int_SoldBy.AdvancedSearch.Save();
            }

            // Field int_Bill_ID
            if (filter?.TryGetValue("x_int_Bill_ID", out sv) ?? false) {
                int_Bill_ID.AdvancedSearch.SearchValue = sv;
                int_Bill_ID.AdvancedSearch.SearchOperator = filter["z_int_Bill_ID"];
                int_Bill_ID.AdvancedSearch.SearchCondition = filter["v_int_Bill_ID"];
                int_Bill_ID.AdvancedSearch.SearchValue2 = filter["y_int_Bill_ID"];
                int_Bill_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Bill_ID"];
                int_Bill_ID.AdvancedSearch.Save();
            }

            // Field str_Amount_Pay
            if (filter?.TryGetValue("x_str_Amount_Pay", out sv) ?? false) {
                str_Amount_Pay.AdvancedSearch.SearchValue = sv;
                str_Amount_Pay.AdvancedSearch.SearchOperator = filter["z_str_Amount_Pay"];
                str_Amount_Pay.AdvancedSearch.SearchCondition = filter["v_str_Amount_Pay"];
                str_Amount_Pay.AdvancedSearch.SearchValue2 = filter["y_str_Amount_Pay"];
                str_Amount_Pay.AdvancedSearch.SearchOperator2 = filter["w_str_Amount_Pay"];
                str_Amount_Pay.AdvancedSearch.Save();
            }

            // Field int_ApptCldr_ID
            if (filter?.TryGetValue("x_int_ApptCldr_ID", out sv) ?? false) {
                int_ApptCldr_ID.AdvancedSearch.SearchValue = sv;
                int_ApptCldr_ID.AdvancedSearch.SearchOperator = filter["z_int_ApptCldr_ID"];
                int_ApptCldr_ID.AdvancedSearch.SearchCondition = filter["v_int_ApptCldr_ID"];
                int_ApptCldr_ID.AdvancedSearch.SearchValue2 = filter["y_int_ApptCldr_ID"];
                int_ApptCldr_ID.AdvancedSearch.SearchOperator2 = filter["w_int_ApptCldr_ID"];
                int_ApptCldr_ID.AdvancedSearch.Save();
            }

            // Field UniqueIdx
            if (filter?.TryGetValue("x_UniqueIdx", out sv) ?? false) {
                UniqueIdx.AdvancedSearch.SearchValue = sv;
                UniqueIdx.AdvancedSearch.SearchOperator = filter["z_UniqueIdx"];
                UniqueIdx.AdvancedSearch.SearchCondition = filter["v_UniqueIdx"];
                UniqueIdx.AdvancedSearch.SearchValue2 = filter["y_UniqueIdx"];
                UniqueIdx.AdvancedSearch.SearchOperator2 = filter["w_UniqueIdx"];
                UniqueIdx.AdvancedSearch.Save();
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
            BuildSearchSql(ref where, int_Enrollement_Id, def, false); // int_Enrollement_Id
            BuildSearchSql(ref where, str_Full_Name, def, false); // str_Full_Name
            BuildSearchSql(ref where, str_Username, def, false); // str_Username
            BuildSearchSql(ref where, NationalID, def, false); // NationalID
            BuildSearchSql(ref where, int_CR_ID, def, false); // int_CR_ID
            BuildSearchSql(ref where, int_Student_Id, def, false); // int_Student_Id
            BuildSearchSql(ref where, int_BTW_Id, def, false); // int_BTW_Id
            BuildSearchSql(ref where, int_Item_Id, def, false); // int_Item_Id
            BuildSearchSql(ref where, int_Package_Id, def, false); // int_Package_Id
            BuildSearchSql(ref where, str_Package_Name, def, false); // str_Package_Name
            BuildSearchSql(ref where, int_PackageCR_Id, def, false); // int_PackageCR_Id
            BuildSearchSql(ref where, date_Created, def, false); // date_Created
            BuildSearchSql(ref where, date_Modified, def, false); // date_Modified
            BuildSearchSql(ref where, int_Created_By, def, false); // int_Created_By
            BuildSearchSql(ref where, int_Modified_By, def, false); // int_Modified_By
            BuildSearchSql(ref where, str_PurchaseAmount, def, false); // str_PurchaseAmount
            BuildSearchSql(ref where, int_ApptId, def, false); // int_ApptId
            BuildSearchSql(ref where, course, def, false); // course
            BuildSearchSql(ref where, institution, def, false); // institution
            BuildSearchSql(ref where, str_Notes, def, false); // str_Notes
            BuildSearchSql(ref where, int_SoldBy, def, false); // int_SoldBy
            BuildSearchSql(ref where, int_Bill_ID, def, false); // int_Bill_ID
            BuildSearchSql(ref where, str_Amount_Pay, def, false); // str_Amount_Pay
            BuildSearchSql(ref where, int_ApptCldr_ID, def, false); // int_ApptCldr_ID
            BuildSearchSql(ref where, UniqueIdx, def, false); // UniqueIdx

            // Set up search command
            if (!def && !Empty(where) && (new[] { "", "reset", "resetall" }).Contains(Command))
                Command = "search";
            if (!def && Command == "search") {
                int_Enrollement_Id.AdvancedSearch.Save(); // int_Enrollement_Id
                str_Full_Name.AdvancedSearch.Save(); // str_Full_Name
                str_Username.AdvancedSearch.Save(); // str_Username
                NationalID.AdvancedSearch.Save(); // NationalID
                int_CR_ID.AdvancedSearch.Save(); // int_CR_ID
                int_Student_Id.AdvancedSearch.Save(); // int_Student_Id
                int_BTW_Id.AdvancedSearch.Save(); // int_BTW_Id
                int_Item_Id.AdvancedSearch.Save(); // int_Item_Id
                int_Package_Id.AdvancedSearch.Save(); // int_Package_Id
                str_Package_Name.AdvancedSearch.Save(); // str_Package_Name
                int_PackageCR_Id.AdvancedSearch.Save(); // int_PackageCR_Id
                date_Created.AdvancedSearch.Save(); // date_Created
                date_Modified.AdvancedSearch.Save(); // date_Modified
                int_Created_By.AdvancedSearch.Save(); // int_Created_By
                int_Modified_By.AdvancedSearch.Save(); // int_Modified_By
                str_PurchaseAmount.AdvancedSearch.Save(); // str_PurchaseAmount
                int_ApptId.AdvancedSearch.Save(); // int_ApptId
                course.AdvancedSearch.Save(); // course
                institution.AdvancedSearch.Save(); // institution
                str_Notes.AdvancedSearch.Save(); // str_Notes
                int_SoldBy.AdvancedSearch.Save(); // int_SoldBy
                int_Bill_ID.AdvancedSearch.Save(); // int_Bill_ID
                str_Amount_Pay.AdvancedSearch.Save(); // str_Amount_Pay
                int_ApptCldr_ID.AdvancedSearch.Save(); // int_ApptCldr_ID
                UniqueIdx.AdvancedSearch.Save(); // UniqueIdx

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

            // Field str_Full_Name
            filter = QueryBuilderWhere("str_Full_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Full_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Full_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Username
            filter = QueryBuilderWhere("str_Username");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Username, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Username.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Package_Name
            filter = QueryBuilderWhere("str_Package_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Package_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Package_Name.Caption + "</span>" + captionSuffix + filter + "</div>";
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
            searchFlds.Add(str_Full_Name);
            searchFlds.Add(str_Username);
            searchFlds.Add(str_Package_Name);
            searchFlds.Add(course);
            searchFlds.Add(institution);
            searchFlds.Add(str_Notes);
            searchFlds.Add(str_Amount_Pay);
            searchFlds.Add(UniqueIdx);
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
            if (int_Enrollement_Id.AdvancedSearch.IssetSession)
                return true;
            if (str_Full_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Username.AdvancedSearch.IssetSession)
                return true;
            if (NationalID.AdvancedSearch.IssetSession)
                return true;
            if (int_CR_ID.AdvancedSearch.IssetSession)
                return true;
            if (int_Student_Id.AdvancedSearch.IssetSession)
                return true;
            if (int_BTW_Id.AdvancedSearch.IssetSession)
                return true;
            if (int_Item_Id.AdvancedSearch.IssetSession)
                return true;
            if (int_Package_Id.AdvancedSearch.IssetSession)
                return true;
            if (str_Package_Name.AdvancedSearch.IssetSession)
                return true;
            if (int_PackageCR_Id.AdvancedSearch.IssetSession)
                return true;
            if (date_Created.AdvancedSearch.IssetSession)
                return true;
            if (date_Modified.AdvancedSearch.IssetSession)
                return true;
            if (int_Created_By.AdvancedSearch.IssetSession)
                return true;
            if (int_Modified_By.AdvancedSearch.IssetSession)
                return true;
            if (str_PurchaseAmount.AdvancedSearch.IssetSession)
                return true;
            if (int_ApptId.AdvancedSearch.IssetSession)
                return true;
            if (course.AdvancedSearch.IssetSession)
                return true;
            if (institution.AdvancedSearch.IssetSession)
                return true;
            if (str_Notes.AdvancedSearch.IssetSession)
                return true;
            if (int_SoldBy.AdvancedSearch.IssetSession)
                return true;
            if (int_Bill_ID.AdvancedSearch.IssetSession)
                return true;
            if (str_Amount_Pay.AdvancedSearch.IssetSession)
                return true;
            if (int_ApptCldr_ID.AdvancedSearch.IssetSession)
                return true;
            if (UniqueIdx.AdvancedSearch.IssetSession)
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
            int_Enrollement_Id.AdvancedSearch.UnsetSession();
            str_Full_Name.AdvancedSearch.UnsetSession();
            str_Username.AdvancedSearch.UnsetSession();
            NationalID.AdvancedSearch.UnsetSession();
            int_CR_ID.AdvancedSearch.UnsetSession();
            int_Student_Id.AdvancedSearch.UnsetSession();
            int_BTW_Id.AdvancedSearch.UnsetSession();
            int_Item_Id.AdvancedSearch.UnsetSession();
            int_Package_Id.AdvancedSearch.UnsetSession();
            str_Package_Name.AdvancedSearch.UnsetSession();
            int_PackageCR_Id.AdvancedSearch.UnsetSession();
            date_Created.AdvancedSearch.UnsetSession();
            date_Modified.AdvancedSearch.UnsetSession();
            int_Created_By.AdvancedSearch.UnsetSession();
            int_Modified_By.AdvancedSearch.UnsetSession();
            str_PurchaseAmount.AdvancedSearch.UnsetSession();
            int_ApptId.AdvancedSearch.UnsetSession();
            course.AdvancedSearch.UnsetSession();
            institution.AdvancedSearch.UnsetSession();
            str_Notes.AdvancedSearch.UnsetSession();
            int_SoldBy.AdvancedSearch.UnsetSession();
            int_Bill_ID.AdvancedSearch.UnsetSession();
            str_Amount_Pay.AdvancedSearch.UnsetSession();
            int_ApptCldr_ID.AdvancedSearch.UnsetSession();
            UniqueIdx.AdvancedSearch.UnsetSession();
        }

        // Restore all search parameters
        protected void RestoreSearchParms() {
            RestoreSearch = true;

            // Restore basic search values
            BasicSearch.Load();

            // Restore advanced search values
            int_Enrollement_Id.AdvancedSearch.Load();
            str_Full_Name.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            int_CR_ID.AdvancedSearch.Load();
            int_Student_Id.AdvancedSearch.Load();
            int_BTW_Id.AdvancedSearch.Load();
            int_Item_Id.AdvancedSearch.Load();
            int_Package_Id.AdvancedSearch.Load();
            str_Package_Name.AdvancedSearch.Load();
            int_PackageCR_Id.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            int_Created_By.AdvancedSearch.Load();
            int_Modified_By.AdvancedSearch.Load();
            str_PurchaseAmount.AdvancedSearch.Load();
            int_ApptId.AdvancedSearch.Load();
            course.AdvancedSearch.Load();
            institution.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            int_SoldBy.AdvancedSearch.Load();
            int_Bill_ID.AdvancedSearch.Load();
            str_Amount_Pay.AdvancedSearch.Load();
            int_ApptCldr_ID.AdvancedSearch.Load();
            UniqueIdx.AdvancedSearch.Load();
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
                UpdateSort(str_Full_Name, ctrl); // str_Full_Name
                UpdateSort(str_Username, ctrl); // str_Username
                UpdateSort(str_Package_Name, ctrl); // str_Package_Name
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

                // Reset master/detail keys
                if (SameText(Command, "resetall")) {
                    CurrentMasterTable = ""; // Clear master table
                    DbMasterFilter = "";
                    DbDetailFilter = "";
                    NationalID.SessionValue = "";
                }

                // Reset (clear) sorting order
                if (SameText(Command, "resetsort")) {
                    string orderBy = "";
                    SessionOrderBy = orderBy;
                    int_Enrollement_Id.Sort = "";
                    str_Full_Name.Sort = "";
                    str_Username.Sort = "";
                    NationalID.Sort = "";
                    int_CR_ID.Sort = "";
                    int_Student_Id.Sort = "";
                    int_BTW_Id.Sort = "";
                    int_Item_Id.Sort = "";
                    int_Package_Id.Sort = "";
                    str_Package_Name.Sort = "";
                    int_PackageCR_Id.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    str_PurchaseAmount.Sort = "";
                    int_ApptId.Sort = "";
                    course.Sort = "";
                    institution.Sort = "";
                    str_Notes.Sort = "";
                    int_SoldBy.Sort = "";
                    int_Bill_ID.Sort = "";
                    str_Amount_Pay.Sort = "";
                    int_ApptCldr_ID.Sort = "";
                    UniqueIdx.Sort = "";
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

            // "view"
            listOption = ListOptions["view"];
            string viewcaption = Language.Phrase("ViewLink", true);
            isVisible = Security.CanView && ShowOptionLink("view");
            if (isVisible) {
                if (ModalView && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-table=""tblStudentEnrollment"" data-caption=""{viewcaption}"" data-ew-action=""modal"" data-action=""view"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(ViewUrl)) + "\" data-btn=\"null\">" + Language.Phrase("ViewLink") + "</a>");
                else
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-caption=""{viewcaption}"" href=""" + HtmlEncode(AppPath(ViewUrl)) + "\">" + Language.Phrase("ViewLink") + "</a>");
            } else {
                listOption?.Clear();
            }

            // "edit"
            listOption = ListOptions["edit"];
            string editcaption = Language.Phrase("EditLink", true);
            isVisible = Security.CanEdit && ShowOptionLink("edit");
            if (isVisible) {
                if (ModalEdit && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblStudentEnrollment"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblStudentEnrollmentlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblStudentEnrollmentlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(int_Enrollement_Id.CurrentValue) + "\"></div>");
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
                item.Body = $@"<a class=""ew-add-edit ew-add"" title=""{addTitle}"" data-table=""tblStudentEnrollment"" data-caption=""{addTitle}"" data-ew-action=""modal"" data-action=""add"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(AddUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("AddLink") + "</a>";
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblStudentEnrollmentlist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblStudentEnrollmentsrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblStudentEnrollmentsrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblStudentEnrollmentlist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                    RowAttrs.Add("id", "r0_tblStudentEnrollment");
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblStudentEnrollmentList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblStudentEnrollmentList.RowCount) + "_tblStudentEnrollment");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblStudentEnrollmentList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblStudentEnrollmentList.RowType == RowType.Add || IsEdit && tblStudentEnrollmentList.RowType == RowType.Edit) // Inline-Add/Edit row
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

        // Load search values for validation // DN
        protected void LoadSearchValues() {
            // Load query builder rules
            string rules = Post("rules");
            if (!Empty(rules) && Empty(Command)) {
                QueryRules = rules;
                Command = "search";
            }

            // int_Enrollement_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Enrollement_Id"))
                    int_Enrollement_Id.AdvancedSearch.SearchValue = Get("x_int_Enrollement_Id");
                else
                    int_Enrollement_Id.AdvancedSearch.SearchValue = Get("int_Enrollement_Id"); // Default Value // DN
            if (!Empty(int_Enrollement_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Enrollement_Id"))
                int_Enrollement_Id.AdvancedSearch.SearchOperator = Get("z_int_Enrollement_Id");

            // str_Full_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Full_Name"))
                    str_Full_Name.AdvancedSearch.SearchValue = Get("x_str_Full_Name");
                else
                    str_Full_Name.AdvancedSearch.SearchValue = Get("str_Full_Name"); // Default Value // DN
            if (!Empty(str_Full_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Full_Name"))
                str_Full_Name.AdvancedSearch.SearchOperator = Get("z_str_Full_Name");

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

            // NationalID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_NationalID"))
                    NationalID.AdvancedSearch.SearchValue = Get("x_NationalID");
                else
                    NationalID.AdvancedSearch.SearchValue = Get("NationalID"); // Default Value // DN
            if (!Empty(NationalID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_NationalID"))
                NationalID.AdvancedSearch.SearchOperator = Get("z_NationalID");

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

            // int_Student_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Student_Id"))
                    int_Student_Id.AdvancedSearch.SearchValue = Get("x_int_Student_Id");
                else
                    int_Student_Id.AdvancedSearch.SearchValue = Get("int_Student_Id"); // Default Value // DN
            if (!Empty(int_Student_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Student_Id"))
                int_Student_Id.AdvancedSearch.SearchOperator = Get("z_int_Student_Id");

            // int_BTW_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_BTW_Id"))
                    int_BTW_Id.AdvancedSearch.SearchValue = Get("x_int_BTW_Id");
                else
                    int_BTW_Id.AdvancedSearch.SearchValue = Get("int_BTW_Id"); // Default Value // DN
            if (!Empty(int_BTW_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_BTW_Id"))
                int_BTW_Id.AdvancedSearch.SearchOperator = Get("z_int_BTW_Id");

            // int_Item_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Item_Id"))
                    int_Item_Id.AdvancedSearch.SearchValue = Get("x_int_Item_Id");
                else
                    int_Item_Id.AdvancedSearch.SearchValue = Get("int_Item_Id"); // Default Value // DN
            if (!Empty(int_Item_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Item_Id"))
                int_Item_Id.AdvancedSearch.SearchOperator = Get("z_int_Item_Id");

            // int_Package_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Package_Id"))
                    int_Package_Id.AdvancedSearch.SearchValue = Get("x_int_Package_Id");
                else
                    int_Package_Id.AdvancedSearch.SearchValue = Get("int_Package_Id"); // Default Value // DN
            if (!Empty(int_Package_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Package_Id"))
                int_Package_Id.AdvancedSearch.SearchOperator = Get("z_int_Package_Id");

            // str_Package_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Package_Name"))
                    str_Package_Name.AdvancedSearch.SearchValue = Get("x_str_Package_Name");
                else
                    str_Package_Name.AdvancedSearch.SearchValue = Get("str_Package_Name"); // Default Value // DN
            if (!Empty(str_Package_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Package_Name"))
                str_Package_Name.AdvancedSearch.SearchOperator = Get("z_str_Package_Name");

            // int_PackageCR_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_PackageCR_Id"))
                    int_PackageCR_Id.AdvancedSearch.SearchValue = Get("x_int_PackageCR_Id");
                else
                    int_PackageCR_Id.AdvancedSearch.SearchValue = Get("int_PackageCR_Id"); // Default Value // DN
            if (!Empty(int_PackageCR_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_PackageCR_Id"))
                int_PackageCR_Id.AdvancedSearch.SearchOperator = Get("z_int_PackageCR_Id");

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

            // int_Created_By
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Created_By"))
                    int_Created_By.AdvancedSearch.SearchValue = Get("x_int_Created_By");
                else
                    int_Created_By.AdvancedSearch.SearchValue = Get("int_Created_By"); // Default Value // DN
            if (!Empty(int_Created_By.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Created_By"))
                int_Created_By.AdvancedSearch.SearchOperator = Get("z_int_Created_By");

            // int_Modified_By
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Modified_By"))
                    int_Modified_By.AdvancedSearch.SearchValue = Get("x_int_Modified_By");
                else
                    int_Modified_By.AdvancedSearch.SearchValue = Get("int_Modified_By"); // Default Value // DN
            if (!Empty(int_Modified_By.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Modified_By"))
                int_Modified_By.AdvancedSearch.SearchOperator = Get("z_int_Modified_By");

            // str_PurchaseAmount
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_PurchaseAmount"))
                    str_PurchaseAmount.AdvancedSearch.SearchValue = Get("x_str_PurchaseAmount");
                else
                    str_PurchaseAmount.AdvancedSearch.SearchValue = Get("str_PurchaseAmount"); // Default Value // DN
            if (!Empty(str_PurchaseAmount.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_PurchaseAmount"))
                str_PurchaseAmount.AdvancedSearch.SearchOperator = Get("z_str_PurchaseAmount");

            // int_ApptId
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_ApptId"))
                    int_ApptId.AdvancedSearch.SearchValue = Get("x_int_ApptId");
                else
                    int_ApptId.AdvancedSearch.SearchValue = Get("int_ApptId"); // Default Value // DN
            if (!Empty(int_ApptId.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_ApptId"))
                int_ApptId.AdvancedSearch.SearchOperator = Get("z_int_ApptId");

            // course
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_course"))
                    course.AdvancedSearch.SearchValue = Get("x_course");
                else
                    course.AdvancedSearch.SearchValue = Get("course"); // Default Value // DN
            if (!Empty(course.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_course"))
                course.AdvancedSearch.SearchOperator = Get("z_course");

            // institution
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_institution"))
                    institution.AdvancedSearch.SearchValue = Get("x_institution");
                else
                    institution.AdvancedSearch.SearchValue = Get("institution"); // Default Value // DN
            if (!Empty(institution.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_institution"))
                institution.AdvancedSearch.SearchOperator = Get("z_institution");

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

            // int_SoldBy
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_SoldBy"))
                    int_SoldBy.AdvancedSearch.SearchValue = Get("x_int_SoldBy");
                else
                    int_SoldBy.AdvancedSearch.SearchValue = Get("int_SoldBy"); // Default Value // DN
            if (!Empty(int_SoldBy.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_SoldBy"))
                int_SoldBy.AdvancedSearch.SearchOperator = Get("z_int_SoldBy");

            // int_Bill_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Bill_ID"))
                    int_Bill_ID.AdvancedSearch.SearchValue = Get("x_int_Bill_ID");
                else
                    int_Bill_ID.AdvancedSearch.SearchValue = Get("int_Bill_ID"); // Default Value // DN
            if (!Empty(int_Bill_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Bill_ID"))
                int_Bill_ID.AdvancedSearch.SearchOperator = Get("z_int_Bill_ID");

            // str_Amount_Pay
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Amount_Pay"))
                    str_Amount_Pay.AdvancedSearch.SearchValue = Get("x_str_Amount_Pay");
                else
                    str_Amount_Pay.AdvancedSearch.SearchValue = Get("str_Amount_Pay"); // Default Value // DN
            if (!Empty(str_Amount_Pay.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Amount_Pay"))
                str_Amount_Pay.AdvancedSearch.SearchOperator = Get("z_str_Amount_Pay");

            // int_ApptCldr_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_ApptCldr_ID"))
                    int_ApptCldr_ID.AdvancedSearch.SearchValue = Get("x_int_ApptCldr_ID");
                else
                    int_ApptCldr_ID.AdvancedSearch.SearchValue = Get("int_ApptCldr_ID"); // Default Value // DN
            if (!Empty(int_ApptCldr_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_ApptCldr_ID"))
                int_ApptCldr_ID.AdvancedSearch.SearchOperator = Get("z_int_ApptCldr_ID");

            // UniqueIdx
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_UniqueIdx"))
                    UniqueIdx.AdvancedSearch.SearchValue = Get("x_UniqueIdx");
                else
                    UniqueIdx.AdvancedSearch.SearchValue = Get("UniqueIdx"); // Default Value // DN
            if (!Empty(UniqueIdx.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_UniqueIdx"))
                UniqueIdx.AdvancedSearch.SearchOperator = Get("z_UniqueIdx");
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
            int_Enrollement_Id.SetDbValue(row["int_Enrollement_Id"]);
            str_Full_Name.SetDbValue(row["str_Full_Name"]);
            str_Username.SetDbValue(row["str_Username"]);
            NationalID.SetDbValue(row["NationalID"]);
            int_CR_ID.SetDbValue(row["int_CR_ID"]);
            int_Student_Id.SetDbValue(row["int_Student_Id"]);
            int_BTW_Id.SetDbValue(row["int_BTW_Id"]);
            int_Item_Id.SetDbValue(row["int_Item_Id"]);
            int_Package_Id.SetDbValue(row["int_Package_Id"]);
            str_Package_Name.SetDbValue(row["str_Package_Name"]);
            int_PackageCR_Id.SetDbValue(row["int_PackageCR_Id"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            str_PurchaseAmount.SetDbValue(IsNull(row["str_PurchaseAmount"]) ? DbNullValue : ConvertToDouble(row["str_PurchaseAmount"]));
            int_ApptId.SetDbValue(row["int_ApptId"]);
            course.SetDbValue(row["course"]);
            institution.SetDbValue(row["institution"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            int_SoldBy.SetDbValue(row["int_SoldBy"]);
            int_Bill_ID.SetDbValue(row["int_Bill_ID"]);
            str_Amount_Pay.SetDbValue(row["str_Amount_Pay"]);
            int_ApptCldr_ID.SetDbValue(row["int_ApptCldr_ID"]);
            UniqueIdx.SetDbValue(row["UniqueIdx"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Enrollement_Id", int_Enrollement_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Full_Name", str_Full_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_ID", int_CR_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_Id", int_Student_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_BTW_Id", int_BTW_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Item_Id", int_Item_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Package_Id", int_Package_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Package_Name", str_Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PackageCR_Id", int_PackageCR_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("str_PurchaseAmount", str_PurchaseAmount.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ApptId", int_ApptId.DefaultValue ?? DbNullValue); // DN
            row.Add("course", course.DefaultValue ?? DbNullValue); // DN
            row.Add("institution", institution.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_SoldBy", int_SoldBy.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Bill_ID", int_Bill_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Amount_Pay", str_Amount_Pay.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ApptCldr_ID", int_ApptCldr_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("UniqueIdx", UniqueIdx.DefaultValue ?? DbNullValue); // DN
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

            // int_Enrollement_Id

            // str_Full_Name

            // str_Username

            // NationalID

            // int_CR_ID

            // int_Student_Id

            // int_BTW_Id

            // int_Item_Id

            // int_Package_Id

            // str_Package_Name

            // int_PackageCR_Id

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By

            // str_PurchaseAmount

            // int_ApptId

            // course

            // institution

            // str_Notes

            // int_SoldBy

            // int_Bill_ID

            // str_Amount_Pay

            // int_ApptCldr_ID

            // UniqueIdx

            // View row
            if (RowType == RowType.View) {
                // int_Enrollement_Id
                int_Enrollement_Id.ViewValue = int_Enrollement_Id.CurrentValue;
                int_Enrollement_Id.ViewCustomAttributes = "";

                // str_Full_Name
                curVal = ConvertToString(str_Full_Name.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Full_Name.Lookup != null && IsDictionary(str_Full_Name.Lookup?.Options) && str_Full_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Full_Name.ViewValue = str_Full_Name.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name.CurrentValue, DataType.String, "");
                        sqlWrk = str_Full_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Full_Name.Lookup != null) { // Lookup values found
                            var listwrk = str_Full_Name.Lookup?.RenderViewRow(rswrk[0]);
                            str_Full_Name.ViewValue = str_Full_Name.HighlightLookup(ConvertToString(rswrk[0]), str_Full_Name.DisplayValue(listwrk));
                        } else {
                            str_Full_Name.ViewValue = str_Full_Name.CurrentValue;
                        }
                    }
                } else {
                    str_Full_Name.ViewValue = DbNullValue;
                }
                str_Full_Name.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = str_Username.CurrentValue;
                str_Username.ViewCustomAttributes = "";

                // NationalID
                curVal = ConvertToString(NationalID.CurrentValue);
                if (!Empty(curVal)) {
                    if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        NationalID.ViewValue = NationalID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                        sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && NationalID.Lookup != null) { // Lookup values found
                            var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                            NationalID.ViewValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                        } else {
                            NationalID.ViewValue = NationalID.CurrentValue;
                        }
                    }
                } else {
                    NationalID.ViewValue = DbNullValue;
                }
                NationalID.ViewCustomAttributes = "";

                // int_CR_ID
                curVal = ConvertToString(int_CR_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_CR_ID.Lookup != null && IsDictionary(int_CR_ID.Lookup?.Options) && int_CR_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_CR_ID.ViewValue = int_CR_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_CR_ID]", "=", int_CR_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_CR_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_CR_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_CR_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_CR_ID.ViewValue = int_CR_ID.HighlightLookup(ConvertToString(rswrk[0]), int_CR_ID.DisplayValue(listwrk));
                        } else {
                            int_CR_ID.ViewValue = FormatNumber(int_CR_ID.CurrentValue, int_CR_ID.FormatPattern);
                        }
                    }
                } else {
                    int_CR_ID.ViewValue = DbNullValue;
                }
                int_CR_ID.ViewCustomAttributes = "";

                // int_Student_Id
                int_Student_Id.ViewValue = int_Student_Id.CurrentValue;
                int_Student_Id.ViewValue = FormatNumber(int_Student_Id.ViewValue, int_Student_Id.FormatPattern);
                int_Student_Id.ViewCustomAttributes = "";

                // int_BTW_Id
                int_BTW_Id.ViewValue = int_BTW_Id.CurrentValue;
                int_BTW_Id.ViewValue = FormatNumber(int_BTW_Id.ViewValue, int_BTW_Id.FormatPattern);
                int_BTW_Id.ViewCustomAttributes = "";

                // int_Item_Id
                int_Item_Id.ViewValue = int_Item_Id.CurrentValue;
                int_Item_Id.ViewValue = FormatNumber(int_Item_Id.ViewValue, int_Item_Id.FormatPattern);
                int_Item_Id.ViewCustomAttributes = "";

                // int_Package_Id
                curVal = ConvertToString(int_Package_Id.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Package_Id.Lookup != null && IsDictionary(int_Package_Id.Lookup?.Options) && int_Package_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Package_Id.ViewValue = int_Package_Id.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_CR_Product_ID]", "=", int_Package_Id.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Package_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Package_Id.Lookup != null) { // Lookup values found
                            var listwrk = int_Package_Id.Lookup?.RenderViewRow(rswrk[0]);
                            int_Package_Id.ViewValue = int_Package_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Package_Id.DisplayValue(listwrk));
                        } else {
                            int_Package_Id.ViewValue = FormatNumber(int_Package_Id.CurrentValue, int_Package_Id.FormatPattern);
                        }
                    }
                } else {
                    int_Package_Id.ViewValue = DbNullValue;
                }
                int_Package_Id.ViewCustomAttributes = "";

                // str_Package_Name
                str_Package_Name.ViewValue = ConvertToString(str_Package_Name.CurrentValue); // DN
                str_Package_Name.ViewCustomAttributes = "";

                // int_PackageCR_Id
                int_PackageCR_Id.ViewValue = FormatNumber(int_PackageCR_Id.ViewValue, int_PackageCR_Id.FormatPattern);
                int_PackageCR_Id.ViewCustomAttributes = "";

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

                // str_PurchaseAmount
                str_PurchaseAmount.ViewValue = str_PurchaseAmount.CurrentValue;
                str_PurchaseAmount.ViewValue = FormatNumber(str_PurchaseAmount.ViewValue, str_PurchaseAmount.FormatPattern);
                str_PurchaseAmount.ViewCustomAttributes = "";

                // int_ApptId
                int_ApptId.ViewValue = int_ApptId.CurrentValue;
                int_ApptId.ViewValue = FormatNumber(int_ApptId.ViewValue, int_ApptId.FormatPattern);
                int_ApptId.ViewCustomAttributes = "";

                // course
                course.ViewValue = ConvertToString(course.CurrentValue); // DN
                course.ViewCustomAttributes = "";

                // institution
                institution.ViewValue = ConvertToString(institution.CurrentValue); // DN
                institution.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // int_SoldBy
                int_SoldBy.ViewValue = int_SoldBy.CurrentValue;
                int_SoldBy.ViewValue = FormatNumber(int_SoldBy.ViewValue, int_SoldBy.FormatPattern);
                int_SoldBy.ViewCustomAttributes = "";

                // int_Bill_ID
                int_Bill_ID.ViewValue = int_Bill_ID.CurrentValue;
                int_Bill_ID.ViewValue = FormatNumber(int_Bill_ID.ViewValue, int_Bill_ID.FormatPattern);
                int_Bill_ID.ViewCustomAttributes = "";

                // str_Amount_Pay
                str_Amount_Pay.ViewValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
                str_Amount_Pay.ViewCustomAttributes = "";

                // int_ApptCldr_ID
                int_ApptCldr_ID.ViewValue = int_ApptCldr_ID.CurrentValue;
                int_ApptCldr_ID.ViewValue = FormatNumber(int_ApptCldr_ID.ViewValue, int_ApptCldr_ID.FormatPattern);
                int_ApptCldr_ID.ViewCustomAttributes = "";

                // UniqueIdx
                UniqueIdx.ViewValue = ConvertToString(UniqueIdx.CurrentValue); // DN
                UniqueIdx.ViewCustomAttributes = "";

                // str_Full_Name
                str_Full_Name.HrefValue = "";
                str_Full_Name.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // str_Package_Name
                str_Package_Name.HrefValue = "";
                str_Package_Name.TooltipValue = "";
            } else if (RowType == RowType.Search) {
                // str_Full_Name
                str_Full_Name.SetupEditAttributes();
                str_Full_Name.PlaceHolder = RemoveHtml(str_Full_Name.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!str_Username.Raw)
                    str_Username.AdvancedSearch.SearchValue = HtmlDecode(str_Username.AdvancedSearch.SearchValue);
                str_Username.EditValue = HtmlEncode(str_Username.AdvancedSearch.SearchValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // str_Package_Name
                str_Package_Name.SetupEditAttributes();
                if (!str_Package_Name.Raw)
                    str_Package_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Package_Name.AdvancedSearch.SearchValue);
                str_Package_Name.EditValue = HtmlEncode(str_Package_Name.AdvancedSearch.SearchValue);
                str_Package_Name.PlaceHolder = RemoveHtml(str_Package_Name.Caption);
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

        // Load advanced search
        public void LoadAdvancedSearch()
        {
            int_Enrollement_Id.AdvancedSearch.Load();
            str_Full_Name.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            int_CR_ID.AdvancedSearch.Load();
            int_Student_Id.AdvancedSearch.Load();
            int_BTW_Id.AdvancedSearch.Load();
            int_Item_Id.AdvancedSearch.Load();
            int_Package_Id.AdvancedSearch.Load();
            str_Package_Name.AdvancedSearch.Load();
            int_PackageCR_Id.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            int_Created_By.AdvancedSearch.Load();
            int_Modified_By.AdvancedSearch.Load();
            str_PurchaseAmount.AdvancedSearch.Load();
            int_ApptId.AdvancedSearch.Load();
            course.AdvancedSearch.Load();
            institution.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            int_SoldBy.AdvancedSearch.Load();
            int_Bill_ID.AdvancedSearch.Load();
            str_Amount_Pay.AdvancedSearch.Load();
            int_ApptCldr_ID.AdvancedSearch.Load();
            UniqueIdx.AdvancedSearch.Load();
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblStudentEnrollmentlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblStudentEnrollmentlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblStudentEnrollmentlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblStudentEnrollmentlist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblStudentEnrollmentsrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
            item.Visible = true;

            // Show all button
            item = SearchOptions.Add("showall");
            if (UseCustomTemplate || !UseAjaxActions)
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ShowAll") + "\" data-caption=\"" + Language.Phrase("ShowAll") + "\" href=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ShowAllBtn") + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ShowAll") + "\" data-caption=\"" + Language.Phrase("ShowAll") + "\" data-ew-action=\"refresh\" data-url=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ShowAllBtn") + "</a>";
            item.Visible = (SearchWhere != DefaultSearchWhere && SearchWhere != "0=101");

            // Advanced search button
            item = SearchOptions.Add("advancedsearch");
            if (ModalSearch && !IsMobile())
                item.Body = "<a class=\"btn btn-default ew-advanced-search\" title=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-table=\"tblStudentEnrollment\" data-caption=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-ew-action=\"modal\" data-url=\"" + AppPath("TblStudentEnrollmentSearch") + "\" data-btn=\"SearchBtn\">" + Language.Phrase("AdvancedSearch", false) + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-advanced-search\" title=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-caption=\"" + Language.Phrase("AdvancedSearch", true) + "\" href=\"" + AppPath("TblStudentEnrollmentSearch") + "\">" + Language.Phrase("AdvancedSearch", false) + "</a>";
            item.Visible = true;

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
            string exportStyle;

            // Export master record
            if (Config.ExportMasterRecord && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblBillingInfo") {
                tblBillingInfo = new TblBillingInfoList();
                if (tblBillingInfo != null) {
                    var c = await GetConnection2Async(tblBillingInfo.DbId); // Note: Use new connection for master record // DN
                    using var rsmaster = await tblBillingInfo.LoadReader(DbMasterFilter, "", c); // Load master record
                    if (rsmaster?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("v"); // Change to vertical
                        if (!IsExport("csv") || Config.ExportMasterRecordForCsv) {
                            doc.Table = tblBillingInfo;
                            await tblBillingInfo.ExportDocument(doc, rsmaster, 1, 1);
                            doc.ExportEmptyRow();
                            doc.Table = this;
                        }
                        doc.SetStyle(exportStyle); // Restore
                    }
                }
            }

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

        // Show link optionally based on User ID
        protected bool ShowOptionLink(string pageId = "") { // DN
            if (Security.IsLoggedIn && !Security.IsAdmin && !UserIDAllow(pageId))
                return Security.IsValidUserID(str_Username.CurrentValue);
            return true;
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
                if (masterTblVar == "tblBillingInfo") {
                    validMaster = true;
                    if (tblBillingInfo != null && (Get("fk_NationalID", out fk) || Get("NationalID", out fk))) {
                        tblBillingInfo.NationalID.QueryValue = fk;
                        NationalID.QueryValue = tblBillingInfo.NationalID.QueryValue;
                        NationalID.SessionValue = NationalID.QueryValue;
                        foreignKeys.Add("NationalID", fk);
                        if (!IsNumeric(NationalID.QueryValue))
                            validMaster = false;
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
                if (masterTblVar == "tblBillingInfo") {
                    validMaster = true;
                    if (tblBillingInfo != null && (Post("fk_NationalID", out fk) || Post("NationalID", out fk))) {
                        tblBillingInfo.NationalID.FormValue = fk;
                        NationalID.FormValue = tblBillingInfo.NationalID.FormValue;
                        NationalID.SessionValue = NationalID.FormValue;
                        foreignKeys.Add("NationalID", fk);
                        if (!IsNumeric(NationalID.FormValue))
                            validMaster = false;
                    } else {
                        validMaster = false;
                    }
                }
            }
            if (validMaster) {
                // Save current master table
                CurrentMasterTable = masterTblVar.ToString();

                // Update URL
                AddUrl = AddMasterUrl(AddUrl);
                InlineAddUrl = AddMasterUrl(InlineAddUrl);
                GridAddUrl = AddMasterUrl(GridAddUrl);
                GridEditUrl = AddMasterUrl(GridEditUrl);
                MultiEditUrl = AddMasterUrl(MultiEditUrl);

                // Reset start record counter (new master key)
                if (!IsAddOrEdit) {
                    StartRecord = 1;
                    StartRecordNumber = StartRecord;
                }

                // Clear previous master key from Session
                if (masterTblVar != "tblBillingInfo") {
                    if (!foreignKeys.ContainsKey("NationalID")) // Not current foreign key
                        NationalID.SessionValue = "";
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
