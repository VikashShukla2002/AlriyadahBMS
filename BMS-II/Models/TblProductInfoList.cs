namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblProductInfoList
    /// </summary>
    public static TblProductInfoList tblProductInfoList
    {
        get => HttpData.Get<TblProductInfoList>("tblProductInfoList")!;
        set => HttpData["tblProductInfoList"] = value;
    }

    /// <summary>
    /// Page class for tblProductInfo
    /// </summary>
    public class TblProductInfoList : TblProductInfoListBase
    {
        // Constructor
        public TblProductInfoList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblProductInfoList() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblProductInfoListBase : TblProductInfo
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblProductInfo";

        // Page object name
        public string PageObjName = "tblProductInfoList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblProductInfolist";

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
        public TblProductInfoListBase()
        {
            // CSS class name as context
            TableVar = "tblProductInfo";
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

            // Table object (tblProductInfo)
            if (tblProductInfo == null || tblProductInfo is TblProductInfo)
                tblProductInfo = this;

            // Initialize URLs
            AddUrl = "TblProductInfoAdd";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblProductInfoDelete";
            MultiUpdateUrl = "TblProductInfoUpdate";

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
        public string PageName => "TblProductInfoList";

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
            int_Product_Id.SetVisibility();
            str_Product_Name.SetVisibility();
            str_Item_Code.SetVisibility();
            mny_Price.SetVisibility();
            bit_IsTaxable.SetVisibility();
            str_Web_Description.SetVisibility();
            dec_StateTax.SetVisibility();
            dec_AddTax.SetVisibility();
            mny_TotalPrice.SetVisibility();
            int_Product_Type.SetVisibility();
            int_Product_Sub_Type.SetVisibility();
            int_Status.SetVisibility();
            bit_Is_Web_Purchase.SetVisibility();
            str_BTW_Hours.SetVisibility();
            str_Hour.SetVisibility();
            Str_Minutes.SetVisibility();
            str_Appointment_Duration.SetVisibility();
            str_Notes.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            int_Dollar.SetVisibility();
            bit_PortalPurchase.SetVisibility();
            str_WebName.SetVisibility();
            bit_ExtraChk1.SetVisibility();
            bit_ExtraChk2.SetVisibility();
            str_ExtraDrpDown1.SetVisibility();
            str_ExtraDrpDown2.SetVisibility();
            str_Extratxt1.SetVisibility();
            str_Extratxt2.SetVisibility();
            str_OBHours.SetVisibility();
            str_OBMinutes.SetVisibility();
            str_TotalOB_Mins.SetVisibility();
            LMSProductID.SetVisibility();
            LMSNoOfAttempts.SetVisibility();
            int_LMSLinkExpirationDays.SetVisibility();
            IGD_product_id.SetVisibility();
            IEC_product_id.SetVisibility();
            Somastream_Product_ID.SetVisibility();
            ProTREAD_Product_ID.SetVisibility();
            ASD_product_id.SetVisibility();
            D2L_product_Id.SetVisibility();
            int_Course_Duration.SetVisibility();
            Moodle_product_Id.SetVisibility();
        }

        // Constructor
        public TblProductInfoListBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblProductInfoView" ? "1" : "0"); // If View page, no primary button
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
            await SetupLookupOptions(bit_IsTaxable);
            await SetupLookupOptions(bit_Is_Web_Purchase);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_PortalPurchase);
            await SetupLookupOptions(bit_ExtraChk1);
            await SetupLookupOptions(bit_ExtraChk2);

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblProductInfogrid";

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
                tblProductInfoList?.PageRender();
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
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblProductInfosrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Product_Id.AdvancedSearch.ToJson())); // Field int_Product_Id
            filters.Merge(JObject.Parse(str_Product_Name.AdvancedSearch.ToJson())); // Field str_Product_Name
            filters.Merge(JObject.Parse(str_Item_Code.AdvancedSearch.ToJson())); // Field str_Item_Code
            filters.Merge(JObject.Parse(mny_Price.AdvancedSearch.ToJson())); // Field mny_Price
            filters.Merge(JObject.Parse(bit_IsTaxable.AdvancedSearch.ToJson())); // Field bit_IsTaxable
            filters.Merge(JObject.Parse(str_Web_Description.AdvancedSearch.ToJson())); // Field str_Web_Description
            filters.Merge(JObject.Parse(dec_StateTax.AdvancedSearch.ToJson())); // Field dec_StateTax
            filters.Merge(JObject.Parse(dec_AddTax.AdvancedSearch.ToJson())); // Field dec_AddTax
            filters.Merge(JObject.Parse(mny_TotalPrice.AdvancedSearch.ToJson())); // Field mny_TotalPrice
            filters.Merge(JObject.Parse(int_Product_Type.AdvancedSearch.ToJson())); // Field int_Product_Type
            filters.Merge(JObject.Parse(int_Product_Sub_Type.AdvancedSearch.ToJson())); // Field int_Product_Sub_Type
            filters.Merge(JObject.Parse(int_Status.AdvancedSearch.ToJson())); // Field int_Status
            filters.Merge(JObject.Parse(bit_Is_Web_Purchase.AdvancedSearch.ToJson())); // Field bit_Is_Web_Purchase
            filters.Merge(JObject.Parse(str_BTW_Hours.AdvancedSearch.ToJson())); // Field str_BTW_Hours
            filters.Merge(JObject.Parse(str_Hour.AdvancedSearch.ToJson())); // Field str_Hour
            filters.Merge(JObject.Parse(Str_Minutes.AdvancedSearch.ToJson())); // Field Str_Minutes
            filters.Merge(JObject.Parse(str_Appointment_Duration.AdvancedSearch.ToJson())); // Field str_Appointment_Duration
            filters.Merge(JObject.Parse(str_Notes.AdvancedSearch.ToJson())); // Field str_Notes
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(int_Dollar.AdvancedSearch.ToJson())); // Field int_Dollar
            filters.Merge(JObject.Parse(bit_PortalPurchase.AdvancedSearch.ToJson())); // Field bit_PortalPurchase
            filters.Merge(JObject.Parse(str_WebName.AdvancedSearch.ToJson())); // Field str_WebName
            filters.Merge(JObject.Parse(bit_ExtraChk1.AdvancedSearch.ToJson())); // Field bit_ExtraChk1
            filters.Merge(JObject.Parse(bit_ExtraChk2.AdvancedSearch.ToJson())); // Field bit_ExtraChk2
            filters.Merge(JObject.Parse(str_ExtraDrpDown1.AdvancedSearch.ToJson())); // Field str_ExtraDrpDown1
            filters.Merge(JObject.Parse(str_ExtraDrpDown2.AdvancedSearch.ToJson())); // Field str_ExtraDrpDown2
            filters.Merge(JObject.Parse(str_Extratxt1.AdvancedSearch.ToJson())); // Field str_Extratxt1
            filters.Merge(JObject.Parse(str_Extratxt2.AdvancedSearch.ToJson())); // Field str_Extratxt2
            filters.Merge(JObject.Parse(str_OBHours.AdvancedSearch.ToJson())); // Field str_OBHours
            filters.Merge(JObject.Parse(str_OBMinutes.AdvancedSearch.ToJson())); // Field str_OBMinutes
            filters.Merge(JObject.Parse(str_TotalOB_Mins.AdvancedSearch.ToJson())); // Field str_TotalOB_Mins
            filters.Merge(JObject.Parse(LMSProductID.AdvancedSearch.ToJson())); // Field LMSProductID
            filters.Merge(JObject.Parse(LMSNoOfAttempts.AdvancedSearch.ToJson())); // Field LMSNoOfAttempts
            filters.Merge(JObject.Parse(int_LMSLinkExpirationDays.AdvancedSearch.ToJson())); // Field int_LMSLinkExpirationDays
            filters.Merge(JObject.Parse(IGD_product_id.AdvancedSearch.ToJson())); // Field IGD_product_id
            filters.Merge(JObject.Parse(IEC_product_id.AdvancedSearch.ToJson())); // Field IEC_product_id
            filters.Merge(JObject.Parse(Somastream_Product_ID.AdvancedSearch.ToJson())); // Field Somastream_Product_ID
            filters.Merge(JObject.Parse(ProTREAD_Product_ID.AdvancedSearch.ToJson())); // Field ProTREAD_Product_ID
            filters.Merge(JObject.Parse(ASD_product_id.AdvancedSearch.ToJson())); // Field ASD_product_id
            filters.Merge(JObject.Parse(D2L_product_Id.AdvancedSearch.ToJson())); // Field D2L_product_Id
            filters.Merge(JObject.Parse(int_Course_Duration.AdvancedSearch.ToJson())); // Field int_Course_Duration
            filters.Merge(JObject.Parse(Moodle_product_Id.AdvancedSearch.ToJson())); // Field Moodle_product_Id
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblProductInfosrch", filters);
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

            // Field int_Product_Id
            if (filter?.TryGetValue("x_int_Product_Id", out sv) ?? false) {
                int_Product_Id.AdvancedSearch.SearchValue = sv;
                int_Product_Id.AdvancedSearch.SearchOperator = filter["z_int_Product_Id"];
                int_Product_Id.AdvancedSearch.SearchCondition = filter["v_int_Product_Id"];
                int_Product_Id.AdvancedSearch.SearchValue2 = filter["y_int_Product_Id"];
                int_Product_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Product_Id"];
                int_Product_Id.AdvancedSearch.Save();
            }

            // Field str_Product_Name
            if (filter?.TryGetValue("x_str_Product_Name", out sv) ?? false) {
                str_Product_Name.AdvancedSearch.SearchValue = sv;
                str_Product_Name.AdvancedSearch.SearchOperator = filter["z_str_Product_Name"];
                str_Product_Name.AdvancedSearch.SearchCondition = filter["v_str_Product_Name"];
                str_Product_Name.AdvancedSearch.SearchValue2 = filter["y_str_Product_Name"];
                str_Product_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Product_Name"];
                str_Product_Name.AdvancedSearch.Save();
            }

            // Field str_Item_Code
            if (filter?.TryGetValue("x_str_Item_Code", out sv) ?? false) {
                str_Item_Code.AdvancedSearch.SearchValue = sv;
                str_Item_Code.AdvancedSearch.SearchOperator = filter["z_str_Item_Code"];
                str_Item_Code.AdvancedSearch.SearchCondition = filter["v_str_Item_Code"];
                str_Item_Code.AdvancedSearch.SearchValue2 = filter["y_str_Item_Code"];
                str_Item_Code.AdvancedSearch.SearchOperator2 = filter["w_str_Item_Code"];
                str_Item_Code.AdvancedSearch.Save();
            }

            // Field mny_Price
            if (filter?.TryGetValue("x_mny_Price", out sv) ?? false) {
                mny_Price.AdvancedSearch.SearchValue = sv;
                mny_Price.AdvancedSearch.SearchOperator = filter["z_mny_Price"];
                mny_Price.AdvancedSearch.SearchCondition = filter["v_mny_Price"];
                mny_Price.AdvancedSearch.SearchValue2 = filter["y_mny_Price"];
                mny_Price.AdvancedSearch.SearchOperator2 = filter["w_mny_Price"];
                mny_Price.AdvancedSearch.Save();
            }

            // Field bit_IsTaxable
            if (filter?.TryGetValue("x_bit_IsTaxable", out sv) ?? false) {
                bit_IsTaxable.AdvancedSearch.SearchValue = sv;
                bit_IsTaxable.AdvancedSearch.SearchOperator = filter["z_bit_IsTaxable"];
                bit_IsTaxable.AdvancedSearch.SearchCondition = filter["v_bit_IsTaxable"];
                bit_IsTaxable.AdvancedSearch.SearchValue2 = filter["y_bit_IsTaxable"];
                bit_IsTaxable.AdvancedSearch.SearchOperator2 = filter["w_bit_IsTaxable"];
                bit_IsTaxable.AdvancedSearch.Save();
            }

            // Field str_Web_Description
            if (filter?.TryGetValue("x_str_Web_Description", out sv) ?? false) {
                str_Web_Description.AdvancedSearch.SearchValue = sv;
                str_Web_Description.AdvancedSearch.SearchOperator = filter["z_str_Web_Description"];
                str_Web_Description.AdvancedSearch.SearchCondition = filter["v_str_Web_Description"];
                str_Web_Description.AdvancedSearch.SearchValue2 = filter["y_str_Web_Description"];
                str_Web_Description.AdvancedSearch.SearchOperator2 = filter["w_str_Web_Description"];
                str_Web_Description.AdvancedSearch.Save();
            }

            // Field dec_StateTax
            if (filter?.TryGetValue("x_dec_StateTax", out sv) ?? false) {
                dec_StateTax.AdvancedSearch.SearchValue = sv;
                dec_StateTax.AdvancedSearch.SearchOperator = filter["z_dec_StateTax"];
                dec_StateTax.AdvancedSearch.SearchCondition = filter["v_dec_StateTax"];
                dec_StateTax.AdvancedSearch.SearchValue2 = filter["y_dec_StateTax"];
                dec_StateTax.AdvancedSearch.SearchOperator2 = filter["w_dec_StateTax"];
                dec_StateTax.AdvancedSearch.Save();
            }

            // Field dec_AddTax
            if (filter?.TryGetValue("x_dec_AddTax", out sv) ?? false) {
                dec_AddTax.AdvancedSearch.SearchValue = sv;
                dec_AddTax.AdvancedSearch.SearchOperator = filter["z_dec_AddTax"];
                dec_AddTax.AdvancedSearch.SearchCondition = filter["v_dec_AddTax"];
                dec_AddTax.AdvancedSearch.SearchValue2 = filter["y_dec_AddTax"];
                dec_AddTax.AdvancedSearch.SearchOperator2 = filter["w_dec_AddTax"];
                dec_AddTax.AdvancedSearch.Save();
            }

            // Field mny_TotalPrice
            if (filter?.TryGetValue("x_mny_TotalPrice", out sv) ?? false) {
                mny_TotalPrice.AdvancedSearch.SearchValue = sv;
                mny_TotalPrice.AdvancedSearch.SearchOperator = filter["z_mny_TotalPrice"];
                mny_TotalPrice.AdvancedSearch.SearchCondition = filter["v_mny_TotalPrice"];
                mny_TotalPrice.AdvancedSearch.SearchValue2 = filter["y_mny_TotalPrice"];
                mny_TotalPrice.AdvancedSearch.SearchOperator2 = filter["w_mny_TotalPrice"];
                mny_TotalPrice.AdvancedSearch.Save();
            }

            // Field int_Product_Type
            if (filter?.TryGetValue("x_int_Product_Type", out sv) ?? false) {
                int_Product_Type.AdvancedSearch.SearchValue = sv;
                int_Product_Type.AdvancedSearch.SearchOperator = filter["z_int_Product_Type"];
                int_Product_Type.AdvancedSearch.SearchCondition = filter["v_int_Product_Type"];
                int_Product_Type.AdvancedSearch.SearchValue2 = filter["y_int_Product_Type"];
                int_Product_Type.AdvancedSearch.SearchOperator2 = filter["w_int_Product_Type"];
                int_Product_Type.AdvancedSearch.Save();
            }

            // Field int_Product_Sub_Type
            if (filter?.TryGetValue("x_int_Product_Sub_Type", out sv) ?? false) {
                int_Product_Sub_Type.AdvancedSearch.SearchValue = sv;
                int_Product_Sub_Type.AdvancedSearch.SearchOperator = filter["z_int_Product_Sub_Type"];
                int_Product_Sub_Type.AdvancedSearch.SearchCondition = filter["v_int_Product_Sub_Type"];
                int_Product_Sub_Type.AdvancedSearch.SearchValue2 = filter["y_int_Product_Sub_Type"];
                int_Product_Sub_Type.AdvancedSearch.SearchOperator2 = filter["w_int_Product_Sub_Type"];
                int_Product_Sub_Type.AdvancedSearch.Save();
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

            // Field bit_Is_Web_Purchase
            if (filter?.TryGetValue("x_bit_Is_Web_Purchase", out sv) ?? false) {
                bit_Is_Web_Purchase.AdvancedSearch.SearchValue = sv;
                bit_Is_Web_Purchase.AdvancedSearch.SearchOperator = filter["z_bit_Is_Web_Purchase"];
                bit_Is_Web_Purchase.AdvancedSearch.SearchCondition = filter["v_bit_Is_Web_Purchase"];
                bit_Is_Web_Purchase.AdvancedSearch.SearchValue2 = filter["y_bit_Is_Web_Purchase"];
                bit_Is_Web_Purchase.AdvancedSearch.SearchOperator2 = filter["w_bit_Is_Web_Purchase"];
                bit_Is_Web_Purchase.AdvancedSearch.Save();
            }

            // Field str_BTW_Hours
            if (filter?.TryGetValue("x_str_BTW_Hours", out sv) ?? false) {
                str_BTW_Hours.AdvancedSearch.SearchValue = sv;
                str_BTW_Hours.AdvancedSearch.SearchOperator = filter["z_str_BTW_Hours"];
                str_BTW_Hours.AdvancedSearch.SearchCondition = filter["v_str_BTW_Hours"];
                str_BTW_Hours.AdvancedSearch.SearchValue2 = filter["y_str_BTW_Hours"];
                str_BTW_Hours.AdvancedSearch.SearchOperator2 = filter["w_str_BTW_Hours"];
                str_BTW_Hours.AdvancedSearch.Save();
            }

            // Field str_Hour
            if (filter?.TryGetValue("x_str_Hour", out sv) ?? false) {
                str_Hour.AdvancedSearch.SearchValue = sv;
                str_Hour.AdvancedSearch.SearchOperator = filter["z_str_Hour"];
                str_Hour.AdvancedSearch.SearchCondition = filter["v_str_Hour"];
                str_Hour.AdvancedSearch.SearchValue2 = filter["y_str_Hour"];
                str_Hour.AdvancedSearch.SearchOperator2 = filter["w_str_Hour"];
                str_Hour.AdvancedSearch.Save();
            }

            // Field Str_Minutes
            if (filter?.TryGetValue("x_Str_Minutes", out sv) ?? false) {
                Str_Minutes.AdvancedSearch.SearchValue = sv;
                Str_Minutes.AdvancedSearch.SearchOperator = filter["z_Str_Minutes"];
                Str_Minutes.AdvancedSearch.SearchCondition = filter["v_Str_Minutes"];
                Str_Minutes.AdvancedSearch.SearchValue2 = filter["y_Str_Minutes"];
                Str_Minutes.AdvancedSearch.SearchOperator2 = filter["w_Str_Minutes"];
                Str_Minutes.AdvancedSearch.Save();
            }

            // Field str_Appointment_Duration
            if (filter?.TryGetValue("x_str_Appointment_Duration", out sv) ?? false) {
                str_Appointment_Duration.AdvancedSearch.SearchValue = sv;
                str_Appointment_Duration.AdvancedSearch.SearchOperator = filter["z_str_Appointment_Duration"];
                str_Appointment_Duration.AdvancedSearch.SearchCondition = filter["v_str_Appointment_Duration"];
                str_Appointment_Duration.AdvancedSearch.SearchValue2 = filter["y_str_Appointment_Duration"];
                str_Appointment_Duration.AdvancedSearch.SearchOperator2 = filter["w_str_Appointment_Duration"];
                str_Appointment_Duration.AdvancedSearch.Save();
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

            // Field int_Dollar
            if (filter?.TryGetValue("x_int_Dollar", out sv) ?? false) {
                int_Dollar.AdvancedSearch.SearchValue = sv;
                int_Dollar.AdvancedSearch.SearchOperator = filter["z_int_Dollar"];
                int_Dollar.AdvancedSearch.SearchCondition = filter["v_int_Dollar"];
                int_Dollar.AdvancedSearch.SearchValue2 = filter["y_int_Dollar"];
                int_Dollar.AdvancedSearch.SearchOperator2 = filter["w_int_Dollar"];
                int_Dollar.AdvancedSearch.Save();
            }

            // Field bit_PortalPurchase
            if (filter?.TryGetValue("x_bit_PortalPurchase", out sv) ?? false) {
                bit_PortalPurchase.AdvancedSearch.SearchValue = sv;
                bit_PortalPurchase.AdvancedSearch.SearchOperator = filter["z_bit_PortalPurchase"];
                bit_PortalPurchase.AdvancedSearch.SearchCondition = filter["v_bit_PortalPurchase"];
                bit_PortalPurchase.AdvancedSearch.SearchValue2 = filter["y_bit_PortalPurchase"];
                bit_PortalPurchase.AdvancedSearch.SearchOperator2 = filter["w_bit_PortalPurchase"];
                bit_PortalPurchase.AdvancedSearch.Save();
            }

            // Field str_WebName
            if (filter?.TryGetValue("x_str_WebName", out sv) ?? false) {
                str_WebName.AdvancedSearch.SearchValue = sv;
                str_WebName.AdvancedSearch.SearchOperator = filter["z_str_WebName"];
                str_WebName.AdvancedSearch.SearchCondition = filter["v_str_WebName"];
                str_WebName.AdvancedSearch.SearchValue2 = filter["y_str_WebName"];
                str_WebName.AdvancedSearch.SearchOperator2 = filter["w_str_WebName"];
                str_WebName.AdvancedSearch.Save();
            }

            // Field bit_ExtraChk1
            if (filter?.TryGetValue("x_bit_ExtraChk1", out sv) ?? false) {
                bit_ExtraChk1.AdvancedSearch.SearchValue = sv;
                bit_ExtraChk1.AdvancedSearch.SearchOperator = filter["z_bit_ExtraChk1"];
                bit_ExtraChk1.AdvancedSearch.SearchCondition = filter["v_bit_ExtraChk1"];
                bit_ExtraChk1.AdvancedSearch.SearchValue2 = filter["y_bit_ExtraChk1"];
                bit_ExtraChk1.AdvancedSearch.SearchOperator2 = filter["w_bit_ExtraChk1"];
                bit_ExtraChk1.AdvancedSearch.Save();
            }

            // Field bit_ExtraChk2
            if (filter?.TryGetValue("x_bit_ExtraChk2", out sv) ?? false) {
                bit_ExtraChk2.AdvancedSearch.SearchValue = sv;
                bit_ExtraChk2.AdvancedSearch.SearchOperator = filter["z_bit_ExtraChk2"];
                bit_ExtraChk2.AdvancedSearch.SearchCondition = filter["v_bit_ExtraChk2"];
                bit_ExtraChk2.AdvancedSearch.SearchValue2 = filter["y_bit_ExtraChk2"];
                bit_ExtraChk2.AdvancedSearch.SearchOperator2 = filter["w_bit_ExtraChk2"];
                bit_ExtraChk2.AdvancedSearch.Save();
            }

            // Field str_ExtraDrpDown1
            if (filter?.TryGetValue("x_str_ExtraDrpDown1", out sv) ?? false) {
                str_ExtraDrpDown1.AdvancedSearch.SearchValue = sv;
                str_ExtraDrpDown1.AdvancedSearch.SearchOperator = filter["z_str_ExtraDrpDown1"];
                str_ExtraDrpDown1.AdvancedSearch.SearchCondition = filter["v_str_ExtraDrpDown1"];
                str_ExtraDrpDown1.AdvancedSearch.SearchValue2 = filter["y_str_ExtraDrpDown1"];
                str_ExtraDrpDown1.AdvancedSearch.SearchOperator2 = filter["w_str_ExtraDrpDown1"];
                str_ExtraDrpDown1.AdvancedSearch.Save();
            }

            // Field str_ExtraDrpDown2
            if (filter?.TryGetValue("x_str_ExtraDrpDown2", out sv) ?? false) {
                str_ExtraDrpDown2.AdvancedSearch.SearchValue = sv;
                str_ExtraDrpDown2.AdvancedSearch.SearchOperator = filter["z_str_ExtraDrpDown2"];
                str_ExtraDrpDown2.AdvancedSearch.SearchCondition = filter["v_str_ExtraDrpDown2"];
                str_ExtraDrpDown2.AdvancedSearch.SearchValue2 = filter["y_str_ExtraDrpDown2"];
                str_ExtraDrpDown2.AdvancedSearch.SearchOperator2 = filter["w_str_ExtraDrpDown2"];
                str_ExtraDrpDown2.AdvancedSearch.Save();
            }

            // Field str_Extratxt1
            if (filter?.TryGetValue("x_str_Extratxt1", out sv) ?? false) {
                str_Extratxt1.AdvancedSearch.SearchValue = sv;
                str_Extratxt1.AdvancedSearch.SearchOperator = filter["z_str_Extratxt1"];
                str_Extratxt1.AdvancedSearch.SearchCondition = filter["v_str_Extratxt1"];
                str_Extratxt1.AdvancedSearch.SearchValue2 = filter["y_str_Extratxt1"];
                str_Extratxt1.AdvancedSearch.SearchOperator2 = filter["w_str_Extratxt1"];
                str_Extratxt1.AdvancedSearch.Save();
            }

            // Field str_Extratxt2
            if (filter?.TryGetValue("x_str_Extratxt2", out sv) ?? false) {
                str_Extratxt2.AdvancedSearch.SearchValue = sv;
                str_Extratxt2.AdvancedSearch.SearchOperator = filter["z_str_Extratxt2"];
                str_Extratxt2.AdvancedSearch.SearchCondition = filter["v_str_Extratxt2"];
                str_Extratxt2.AdvancedSearch.SearchValue2 = filter["y_str_Extratxt2"];
                str_Extratxt2.AdvancedSearch.SearchOperator2 = filter["w_str_Extratxt2"];
                str_Extratxt2.AdvancedSearch.Save();
            }

            // Field str_OBHours
            if (filter?.TryGetValue("x_str_OBHours", out sv) ?? false) {
                str_OBHours.AdvancedSearch.SearchValue = sv;
                str_OBHours.AdvancedSearch.SearchOperator = filter["z_str_OBHours"];
                str_OBHours.AdvancedSearch.SearchCondition = filter["v_str_OBHours"];
                str_OBHours.AdvancedSearch.SearchValue2 = filter["y_str_OBHours"];
                str_OBHours.AdvancedSearch.SearchOperator2 = filter["w_str_OBHours"];
                str_OBHours.AdvancedSearch.Save();
            }

            // Field str_OBMinutes
            if (filter?.TryGetValue("x_str_OBMinutes", out sv) ?? false) {
                str_OBMinutes.AdvancedSearch.SearchValue = sv;
                str_OBMinutes.AdvancedSearch.SearchOperator = filter["z_str_OBMinutes"];
                str_OBMinutes.AdvancedSearch.SearchCondition = filter["v_str_OBMinutes"];
                str_OBMinutes.AdvancedSearch.SearchValue2 = filter["y_str_OBMinutes"];
                str_OBMinutes.AdvancedSearch.SearchOperator2 = filter["w_str_OBMinutes"];
                str_OBMinutes.AdvancedSearch.Save();
            }

            // Field str_TotalOB_Mins
            if (filter?.TryGetValue("x_str_TotalOB_Mins", out sv) ?? false) {
                str_TotalOB_Mins.AdvancedSearch.SearchValue = sv;
                str_TotalOB_Mins.AdvancedSearch.SearchOperator = filter["z_str_TotalOB_Mins"];
                str_TotalOB_Mins.AdvancedSearch.SearchCondition = filter["v_str_TotalOB_Mins"];
                str_TotalOB_Mins.AdvancedSearch.SearchValue2 = filter["y_str_TotalOB_Mins"];
                str_TotalOB_Mins.AdvancedSearch.SearchOperator2 = filter["w_str_TotalOB_Mins"];
                str_TotalOB_Mins.AdvancedSearch.Save();
            }

            // Field LMSProductID
            if (filter?.TryGetValue("x_LMSProductID", out sv) ?? false) {
                LMSProductID.AdvancedSearch.SearchValue = sv;
                LMSProductID.AdvancedSearch.SearchOperator = filter["z_LMSProductID"];
                LMSProductID.AdvancedSearch.SearchCondition = filter["v_LMSProductID"];
                LMSProductID.AdvancedSearch.SearchValue2 = filter["y_LMSProductID"];
                LMSProductID.AdvancedSearch.SearchOperator2 = filter["w_LMSProductID"];
                LMSProductID.AdvancedSearch.Save();
            }

            // Field LMSNoOfAttempts
            if (filter?.TryGetValue("x_LMSNoOfAttempts", out sv) ?? false) {
                LMSNoOfAttempts.AdvancedSearch.SearchValue = sv;
                LMSNoOfAttempts.AdvancedSearch.SearchOperator = filter["z_LMSNoOfAttempts"];
                LMSNoOfAttempts.AdvancedSearch.SearchCondition = filter["v_LMSNoOfAttempts"];
                LMSNoOfAttempts.AdvancedSearch.SearchValue2 = filter["y_LMSNoOfAttempts"];
                LMSNoOfAttempts.AdvancedSearch.SearchOperator2 = filter["w_LMSNoOfAttempts"];
                LMSNoOfAttempts.AdvancedSearch.Save();
            }

            // Field int_LMSLinkExpirationDays
            if (filter?.TryGetValue("x_int_LMSLinkExpirationDays", out sv) ?? false) {
                int_LMSLinkExpirationDays.AdvancedSearch.SearchValue = sv;
                int_LMSLinkExpirationDays.AdvancedSearch.SearchOperator = filter["z_int_LMSLinkExpirationDays"];
                int_LMSLinkExpirationDays.AdvancedSearch.SearchCondition = filter["v_int_LMSLinkExpirationDays"];
                int_LMSLinkExpirationDays.AdvancedSearch.SearchValue2 = filter["y_int_LMSLinkExpirationDays"];
                int_LMSLinkExpirationDays.AdvancedSearch.SearchOperator2 = filter["w_int_LMSLinkExpirationDays"];
                int_LMSLinkExpirationDays.AdvancedSearch.Save();
            }

            // Field IGD_product_id
            if (filter?.TryGetValue("x_IGD_product_id", out sv) ?? false) {
                IGD_product_id.AdvancedSearch.SearchValue = sv;
                IGD_product_id.AdvancedSearch.SearchOperator = filter["z_IGD_product_id"];
                IGD_product_id.AdvancedSearch.SearchCondition = filter["v_IGD_product_id"];
                IGD_product_id.AdvancedSearch.SearchValue2 = filter["y_IGD_product_id"];
                IGD_product_id.AdvancedSearch.SearchOperator2 = filter["w_IGD_product_id"];
                IGD_product_id.AdvancedSearch.Save();
            }

            // Field IEC_product_id
            if (filter?.TryGetValue("x_IEC_product_id", out sv) ?? false) {
                IEC_product_id.AdvancedSearch.SearchValue = sv;
                IEC_product_id.AdvancedSearch.SearchOperator = filter["z_IEC_product_id"];
                IEC_product_id.AdvancedSearch.SearchCondition = filter["v_IEC_product_id"];
                IEC_product_id.AdvancedSearch.SearchValue2 = filter["y_IEC_product_id"];
                IEC_product_id.AdvancedSearch.SearchOperator2 = filter["w_IEC_product_id"];
                IEC_product_id.AdvancedSearch.Save();
            }

            // Field Somastream_Product_ID
            if (filter?.TryGetValue("x_Somastream_Product_ID", out sv) ?? false) {
                Somastream_Product_ID.AdvancedSearch.SearchValue = sv;
                Somastream_Product_ID.AdvancedSearch.SearchOperator = filter["z_Somastream_Product_ID"];
                Somastream_Product_ID.AdvancedSearch.SearchCondition = filter["v_Somastream_Product_ID"];
                Somastream_Product_ID.AdvancedSearch.SearchValue2 = filter["y_Somastream_Product_ID"];
                Somastream_Product_ID.AdvancedSearch.SearchOperator2 = filter["w_Somastream_Product_ID"];
                Somastream_Product_ID.AdvancedSearch.Save();
            }

            // Field ProTREAD_Product_ID
            if (filter?.TryGetValue("x_ProTREAD_Product_ID", out sv) ?? false) {
                ProTREAD_Product_ID.AdvancedSearch.SearchValue = sv;
                ProTREAD_Product_ID.AdvancedSearch.SearchOperator = filter["z_ProTREAD_Product_ID"];
                ProTREAD_Product_ID.AdvancedSearch.SearchCondition = filter["v_ProTREAD_Product_ID"];
                ProTREAD_Product_ID.AdvancedSearch.SearchValue2 = filter["y_ProTREAD_Product_ID"];
                ProTREAD_Product_ID.AdvancedSearch.SearchOperator2 = filter["w_ProTREAD_Product_ID"];
                ProTREAD_Product_ID.AdvancedSearch.Save();
            }

            // Field ASD_product_id
            if (filter?.TryGetValue("x_ASD_product_id", out sv) ?? false) {
                ASD_product_id.AdvancedSearch.SearchValue = sv;
                ASD_product_id.AdvancedSearch.SearchOperator = filter["z_ASD_product_id"];
                ASD_product_id.AdvancedSearch.SearchCondition = filter["v_ASD_product_id"];
                ASD_product_id.AdvancedSearch.SearchValue2 = filter["y_ASD_product_id"];
                ASD_product_id.AdvancedSearch.SearchOperator2 = filter["w_ASD_product_id"];
                ASD_product_id.AdvancedSearch.Save();
            }

            // Field D2L_product_Id
            if (filter?.TryGetValue("x_D2L_product_Id", out sv) ?? false) {
                D2L_product_Id.AdvancedSearch.SearchValue = sv;
                D2L_product_Id.AdvancedSearch.SearchOperator = filter["z_D2L_product_Id"];
                D2L_product_Id.AdvancedSearch.SearchCondition = filter["v_D2L_product_Id"];
                D2L_product_Id.AdvancedSearch.SearchValue2 = filter["y_D2L_product_Id"];
                D2L_product_Id.AdvancedSearch.SearchOperator2 = filter["w_D2L_product_Id"];
                D2L_product_Id.AdvancedSearch.Save();
            }

            // Field int_Course_Duration
            if (filter?.TryGetValue("x_int_Course_Duration", out sv) ?? false) {
                int_Course_Duration.AdvancedSearch.SearchValue = sv;
                int_Course_Duration.AdvancedSearch.SearchOperator = filter["z_int_Course_Duration"];
                int_Course_Duration.AdvancedSearch.SearchCondition = filter["v_int_Course_Duration"];
                int_Course_Duration.AdvancedSearch.SearchValue2 = filter["y_int_Course_Duration"];
                int_Course_Duration.AdvancedSearch.SearchOperator2 = filter["w_int_Course_Duration"];
                int_Course_Duration.AdvancedSearch.Save();
            }

            // Field Moodle_product_Id
            if (filter?.TryGetValue("x_Moodle_product_Id", out sv) ?? false) {
                Moodle_product_Id.AdvancedSearch.SearchValue = sv;
                Moodle_product_Id.AdvancedSearch.SearchOperator = filter["z_Moodle_product_Id"];
                Moodle_product_Id.AdvancedSearch.SearchCondition = filter["v_Moodle_product_Id"];
                Moodle_product_Id.AdvancedSearch.SearchValue2 = filter["y_Moodle_product_Id"];
                Moodle_product_Id.AdvancedSearch.SearchOperator2 = filter["w_Moodle_product_Id"];
                Moodle_product_Id.AdvancedSearch.Save();
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
            searchFlds.Add(str_Product_Name);
            searchFlds.Add(str_Item_Code);
            searchFlds.Add(str_Web_Description);
            searchFlds.Add(str_BTW_Hours);
            searchFlds.Add(str_Hour);
            searchFlds.Add(Str_Minutes);
            searchFlds.Add(str_Appointment_Duration);
            searchFlds.Add(str_Notes);
            searchFlds.Add(str_WebName);
            searchFlds.Add(str_ExtraDrpDown1);
            searchFlds.Add(str_ExtraDrpDown2);
            searchFlds.Add(str_Extratxt1);
            searchFlds.Add(str_Extratxt2);
            searchFlds.Add(str_OBHours);
            searchFlds.Add(str_OBMinutes);
            searchFlds.Add(str_TotalOB_Mins);
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
                UpdateSort(int_Product_Id, ctrl); // int_Product_Id
                UpdateSort(str_Product_Name, ctrl); // str_Product_Name
                UpdateSort(str_Item_Code, ctrl); // str_Item_Code
                UpdateSort(mny_Price, ctrl); // mny_Price
                UpdateSort(bit_IsTaxable, ctrl); // bit_IsTaxable
                UpdateSort(str_Web_Description, ctrl); // str_Web_Description
                UpdateSort(dec_StateTax, ctrl); // dec_StateTax
                UpdateSort(dec_AddTax, ctrl); // dec_AddTax
                UpdateSort(mny_TotalPrice, ctrl); // mny_TotalPrice
                UpdateSort(int_Product_Type, ctrl); // int_Product_Type
                UpdateSort(int_Product_Sub_Type, ctrl); // int_Product_Sub_Type
                UpdateSort(int_Status, ctrl); // int_Status
                UpdateSort(bit_Is_Web_Purchase, ctrl); // bit_Is_Web_Purchase
                UpdateSort(str_BTW_Hours, ctrl); // str_BTW_Hours
                UpdateSort(str_Hour, ctrl); // str_Hour
                UpdateSort(Str_Minutes, ctrl); // Str_Minutes
                UpdateSort(str_Appointment_Duration, ctrl); // str_Appointment_Duration
                UpdateSort(str_Notes, ctrl); // str_Notes
                UpdateSort(int_Created_By, ctrl); // int_Created_By
                UpdateSort(int_Modified_By, ctrl); // int_Modified_By
                UpdateSort(date_Created, ctrl); // date_Created
                UpdateSort(date_Modified, ctrl); // date_Modified
                UpdateSort(bit_IsDeleted, ctrl); // bit_IsDeleted
                UpdateSort(int_Dollar, ctrl); // int_Dollar
                UpdateSort(bit_PortalPurchase, ctrl); // bit_PortalPurchase
                UpdateSort(str_WebName, ctrl); // str_WebName
                UpdateSort(bit_ExtraChk1, ctrl); // bit_ExtraChk1
                UpdateSort(bit_ExtraChk2, ctrl); // bit_ExtraChk2
                UpdateSort(str_ExtraDrpDown1, ctrl); // str_ExtraDrpDown1
                UpdateSort(str_ExtraDrpDown2, ctrl); // str_ExtraDrpDown2
                UpdateSort(str_Extratxt1, ctrl); // str_Extratxt1
                UpdateSort(str_Extratxt2, ctrl); // str_Extratxt2
                UpdateSort(str_OBHours, ctrl); // str_OBHours
                UpdateSort(str_OBMinutes, ctrl); // str_OBMinutes
                UpdateSort(str_TotalOB_Mins, ctrl); // str_TotalOB_Mins
                UpdateSort(LMSProductID, ctrl); // LMSProductID
                UpdateSort(LMSNoOfAttempts, ctrl); // LMSNoOfAttempts
                UpdateSort(int_LMSLinkExpirationDays, ctrl); // int_LMSLinkExpirationDays
                UpdateSort(IGD_product_id, ctrl); // IGD_product_id
                UpdateSort(IEC_product_id, ctrl); // IEC_product_id
                UpdateSort(Somastream_Product_ID, ctrl); // Somastream_Product_ID
                UpdateSort(ProTREAD_Product_ID, ctrl); // ProTREAD_Product_ID
                UpdateSort(ASD_product_id, ctrl); // ASD_product_id
                UpdateSort(D2L_product_Id, ctrl); // D2L_product_Id
                UpdateSort(int_Course_Duration, ctrl); // int_Course_Duration
                UpdateSort(Moodle_product_Id, ctrl); // Moodle_product_Id
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
                    int_Product_Id.Sort = "";
                    str_Product_Name.Sort = "";
                    str_Item_Code.Sort = "";
                    mny_Price.Sort = "";
                    bit_IsTaxable.Sort = "";
                    str_Web_Description.Sort = "";
                    dec_StateTax.Sort = "";
                    dec_AddTax.Sort = "";
                    mny_TotalPrice.Sort = "";
                    int_Product_Type.Sort = "";
                    int_Product_Sub_Type.Sort = "";
                    int_Status.Sort = "";
                    bit_Is_Web_Purchase.Sort = "";
                    str_BTW_Hours.Sort = "";
                    str_Hour.Sort = "";
                    Str_Minutes.Sort = "";
                    str_Appointment_Duration.Sort = "";
                    str_Notes.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    bit_IsDeleted.Sort = "";
                    int_Dollar.Sort = "";
                    bit_PortalPurchase.Sort = "";
                    str_WebName.Sort = "";
                    bit_ExtraChk1.Sort = "";
                    bit_ExtraChk2.Sort = "";
                    str_ExtraDrpDown1.Sort = "";
                    str_ExtraDrpDown2.Sort = "";
                    str_Extratxt1.Sort = "";
                    str_Extratxt2.Sort = "";
                    str_OBHours.Sort = "";
                    str_OBMinutes.Sort = "";
                    str_TotalOB_Mins.Sort = "";
                    LMSProductID.Sort = "";
                    LMSNoOfAttempts.Sort = "";
                    int_LMSLinkExpirationDays.Sort = "";
                    IGD_product_id.Sort = "";
                    IEC_product_id.Sort = "";
                    Somastream_Product_ID.Sort = "";
                    ProTREAD_Product_ID.Sort = "";
                    ASD_product_id.Sort = "";
                    D2L_product_Id.Sort = "";
                    int_Course_Duration.Sort = "";
                    Moodle_product_Id.Sort = "";
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblProductInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblProductInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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
                item.Body = $@"<a class=""ew-add-edit ew-add"" title=""{addTitle}"" data-table=""tblProductInfo"" data-caption=""{addTitle}"" data-ew-action=""modal"" data-action=""add"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(AddUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("AddLink") + "</a>";
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblProductInfolist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblProductInfosrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblProductInfosrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblProductInfolist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                    RowAttrs.Add("id", "r0_tblProductInfo");
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblProductInfoList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblProductInfoList.RowCount) + "_tblProductInfo");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblProductInfoList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblProductInfoList.RowType == RowType.Add || IsEdit && tblProductInfoList.RowType == RowType.Edit) // Inline-Add/Edit row
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
            int_Product_Id.SetDbValue(row["int_Product_Id"]);
            str_Product_Name.SetDbValue(row["str_Product_Name"]);
            str_Item_Code.SetDbValue(row["str_Item_Code"]);
            mny_Price.SetDbValue(row["mny_Price"]);
            bit_IsTaxable.SetDbValue((ConvertToBool(row["bit_IsTaxable"]) ? "1" : "0"));
            str_Web_Description.SetDbValue(row["str_Web_Description"]);
            dec_StateTax.SetDbValue(row["dec_StateTax"]);
            dec_AddTax.SetDbValue(IsNull(row["dec_AddTax"]) ? DbNullValue : ConvertToDouble(row["dec_AddTax"]));
            mny_TotalPrice.SetDbValue(row["mny_TotalPrice"]);
            int_Product_Type.SetDbValue(row["int_Product_Type"]);
            int_Product_Sub_Type.SetDbValue(row["int_Product_Sub_Type"]);
            int_Status.SetDbValue(row["int_Status"]);
            bit_Is_Web_Purchase.SetDbValue((ConvertToBool(row["bit_Is_Web_Purchase"]) ? "1" : "0"));
            str_BTW_Hours.SetDbValue(row["str_BTW_Hours"]);
            str_Hour.SetDbValue(row["str_Hour"]);
            Str_Minutes.SetDbValue(row["Str_Minutes"]);
            str_Appointment_Duration.SetDbValue(row["str_Appointment_Duration"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            int_Dollar.SetDbValue(row["int_Dollar"]);
            bit_PortalPurchase.SetDbValue((ConvertToBool(row["bit_PortalPurchase"]) ? "1" : "0"));
            str_WebName.SetDbValue(row["str_WebName"]);
            bit_ExtraChk1.SetDbValue((ConvertToBool(row["bit_ExtraChk1"]) ? "1" : "0"));
            bit_ExtraChk2.SetDbValue((ConvertToBool(row["bit_ExtraChk2"]) ? "1" : "0"));
            str_ExtraDrpDown1.SetDbValue(row["str_ExtraDrpDown1"]);
            str_ExtraDrpDown2.SetDbValue(row["str_ExtraDrpDown2"]);
            str_Extratxt1.SetDbValue(row["str_Extratxt1"]);
            str_Extratxt2.SetDbValue(row["str_Extratxt2"]);
            str_OBHours.SetDbValue(row["str_OBHours"]);
            str_OBMinutes.SetDbValue(row["str_OBMinutes"]);
            str_TotalOB_Mins.SetDbValue(row["str_TotalOB_Mins"]);
            LMSProductID.SetDbValue(row["LMSProductID"]);
            LMSNoOfAttempts.SetDbValue(row["LMSNoOfAttempts"]);
            int_LMSLinkExpirationDays.SetDbValue(row["int_LMSLinkExpirationDays"]);
            IGD_product_id.SetDbValue(row["IGD_product_id"]);
            IEC_product_id.SetDbValue(row["IEC_product_id"]);
            Somastream_Product_ID.SetDbValue(row["Somastream_Product_ID"]);
            ProTREAD_Product_ID.SetDbValue(row["ProTREAD_Product_ID"]);
            ASD_product_id.SetDbValue(row["ASD_product_id"]);
            D2L_product_Id.SetDbValue(row["D2L_product_Id"]);
            int_Course_Duration.SetDbValue(row["int_Course_Duration"]);
            Moodle_product_Id.SetDbValue(row["Moodle_product_Id"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Product_Id", int_Product_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Product_Name", str_Product_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Item_Code", str_Item_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Price", mny_Price.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsTaxable", bit_IsTaxable.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Web_Description", str_Web_Description.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_StateTax", dec_StateTax.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_AddTax", dec_AddTax.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_TotalPrice", mny_TotalPrice.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Product_Type", int_Product_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Product_Sub_Type", int_Product_Sub_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Is_Web_Purchase", bit_Is_Web_Purchase.DefaultValue ?? DbNullValue); // DN
            row.Add("str_BTW_Hours", str_BTW_Hours.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Hour", str_Hour.DefaultValue ?? DbNullValue); // DN
            row.Add("Str_Minutes", Str_Minutes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Appointment_Duration", str_Appointment_Duration.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Dollar", int_Dollar.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_PortalPurchase", bit_PortalPurchase.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebName", str_WebName.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_ExtraChk1", bit_ExtraChk1.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_ExtraChk2", bit_ExtraChk2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ExtraDrpDown1", str_ExtraDrpDown1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ExtraDrpDown2", str_ExtraDrpDown2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Extratxt1", str_Extratxt1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Extratxt2", str_Extratxt2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OBHours", str_OBHours.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OBMinutes", str_OBMinutes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_TotalOB_Mins", str_TotalOB_Mins.DefaultValue ?? DbNullValue); // DN
            row.Add("LMSProductID", LMSProductID.DefaultValue ?? DbNullValue); // DN
            row.Add("LMSNoOfAttempts", LMSNoOfAttempts.DefaultValue ?? DbNullValue); // DN
            row.Add("int_LMSLinkExpirationDays", int_LMSLinkExpirationDays.DefaultValue ?? DbNullValue); // DN
            row.Add("IGD_product_id", IGD_product_id.DefaultValue ?? DbNullValue); // DN
            row.Add("IEC_product_id", IEC_product_id.DefaultValue ?? DbNullValue); // DN
            row.Add("Somastream_Product_ID", Somastream_Product_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("ProTREAD_Product_ID", ProTREAD_Product_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("ASD_product_id", ASD_product_id.DefaultValue ?? DbNullValue); // DN
            row.Add("D2L_product_Id", D2L_product_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Course_Duration", int_Course_Duration.DefaultValue ?? DbNullValue); // DN
            row.Add("Moodle_product_Id", Moodle_product_Id.DefaultValue ?? DbNullValue); // DN
            return row;
        }

        #pragma warning disable 618, 1998
        // Load old record
        protected async Task<Dictionary<string, object>?> LoadOldRecord(DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType>? cnn = null) {
            await LoadRowValues(); // Load default row values
            return null;
        }
        #pragma warning restore 618, 1998

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_Product_Id

            // str_Product_Name

            // str_Item_Code

            // mny_Price

            // bit_IsTaxable

            // str_Web_Description

            // dec_StateTax

            // dec_AddTax

            // mny_TotalPrice

            // int_Product_Type

            // int_Product_Sub_Type

            // int_Status

            // bit_Is_Web_Purchase

            // str_BTW_Hours

            // str_Hour

            // Str_Minutes

            // str_Appointment_Duration

            // str_Notes

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // int_Dollar

            // bit_PortalPurchase

            // str_WebName

            // bit_ExtraChk1

            // bit_ExtraChk2

            // str_ExtraDrpDown1

            // str_ExtraDrpDown2

            // str_Extratxt1

            // str_Extratxt2

            // str_OBHours

            // str_OBMinutes

            // str_TotalOB_Mins

            // LMSProductID

            // LMSNoOfAttempts

            // int_LMSLinkExpirationDays

            // IGD_product_id

            // IEC_product_id

            // Somastream_Product_ID

            // ProTREAD_Product_ID

            // ASD_product_id

            // D2L_product_Id

            // int_Course_Duration

            // Moodle_product_Id

            // View row
            if (RowType == RowType.View) {
                // int_Product_Id
                int_Product_Id.ViewValue = int_Product_Id.CurrentValue;
                int_Product_Id.ViewValue = FormatNumber(int_Product_Id.ViewValue, int_Product_Id.FormatPattern);
                int_Product_Id.ViewCustomAttributes = "";

                // str_Product_Name
                str_Product_Name.ViewValue = ConvertToString(str_Product_Name.CurrentValue); // DN
                str_Product_Name.ViewCustomAttributes = "";

                // str_Item_Code
                str_Item_Code.ViewValue = ConvertToString(str_Item_Code.CurrentValue); // DN
                str_Item_Code.ViewCustomAttributes = "";

                // mny_Price
                mny_Price.ViewValue = mny_Price.CurrentValue;
                mny_Price.ViewValue = FormatNumber(mny_Price.ViewValue, mny_Price.FormatPattern);
                mny_Price.ViewCustomAttributes = "";

                // bit_IsTaxable
                if (ConvertToBool(bit_IsTaxable.CurrentValue)) {
                    bit_IsTaxable.ViewValue = bit_IsTaxable.TagCaption(1) != "" ? bit_IsTaxable.TagCaption(1) : "Yes";
                } else {
                    bit_IsTaxable.ViewValue = bit_IsTaxable.TagCaption(2) != "" ? bit_IsTaxable.TagCaption(2) : "No";
                }
                bit_IsTaxable.ViewCustomAttributes = "";

                // str_Web_Description
                str_Web_Description.ViewValue = ConvertToString(str_Web_Description.CurrentValue); // DN
                str_Web_Description.ViewCustomAttributes = "";

                // dec_StateTax
                dec_StateTax.ViewValue = dec_StateTax.CurrentValue;
                dec_StateTax.ViewValue = FormatNumber(dec_StateTax.ViewValue, dec_StateTax.FormatPattern);
                dec_StateTax.ViewCustomAttributes = "";

                // dec_AddTax
                dec_AddTax.ViewValue = dec_AddTax.CurrentValue;
                dec_AddTax.ViewValue = FormatNumber(dec_AddTax.ViewValue, dec_AddTax.FormatPattern);
                dec_AddTax.ViewCustomAttributes = "";

                // mny_TotalPrice
                mny_TotalPrice.ViewValue = mny_TotalPrice.CurrentValue;
                mny_TotalPrice.ViewValue = FormatNumber(mny_TotalPrice.ViewValue, mny_TotalPrice.FormatPattern);
                mny_TotalPrice.ViewCustomAttributes = "";

                // int_Product_Type
                int_Product_Type.ViewValue = int_Product_Type.CurrentValue;
                int_Product_Type.ViewValue = FormatNumber(int_Product_Type.ViewValue, int_Product_Type.FormatPattern);
                int_Product_Type.ViewCustomAttributes = "";

                // int_Product_Sub_Type
                int_Product_Sub_Type.ViewValue = int_Product_Sub_Type.CurrentValue;
                int_Product_Sub_Type.ViewValue = FormatNumber(int_Product_Sub_Type.ViewValue, int_Product_Sub_Type.FormatPattern);
                int_Product_Sub_Type.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // bit_Is_Web_Purchase
                if (ConvertToBool(bit_Is_Web_Purchase.CurrentValue)) {
                    bit_Is_Web_Purchase.ViewValue = bit_Is_Web_Purchase.TagCaption(1) != "" ? bit_Is_Web_Purchase.TagCaption(1) : "Yes";
                } else {
                    bit_Is_Web_Purchase.ViewValue = bit_Is_Web_Purchase.TagCaption(2) != "" ? bit_Is_Web_Purchase.TagCaption(2) : "No";
                }
                bit_Is_Web_Purchase.ViewCustomAttributes = "";

                // str_BTW_Hours
                str_BTW_Hours.ViewValue = ConvertToString(str_BTW_Hours.CurrentValue); // DN
                str_BTW_Hours.ViewCustomAttributes = "";

                // str_Hour
                str_Hour.ViewValue = ConvertToString(str_Hour.CurrentValue); // DN
                str_Hour.ViewCustomAttributes = "";

                // Str_Minutes
                Str_Minutes.ViewValue = ConvertToString(Str_Minutes.CurrentValue); // DN
                Str_Minutes.ViewCustomAttributes = "";

                // str_Appointment_Duration
                str_Appointment_Duration.ViewValue = ConvertToString(str_Appointment_Duration.CurrentValue); // DN
                str_Appointment_Duration.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

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

                // int_Dollar
                int_Dollar.ViewValue = int_Dollar.CurrentValue;
                int_Dollar.ViewValue = FormatNumber(int_Dollar.ViewValue, int_Dollar.FormatPattern);
                int_Dollar.ViewCustomAttributes = "";

                // bit_PortalPurchase
                if (ConvertToBool(bit_PortalPurchase.CurrentValue)) {
                    bit_PortalPurchase.ViewValue = bit_PortalPurchase.TagCaption(1) != "" ? bit_PortalPurchase.TagCaption(1) : "Yes";
                } else {
                    bit_PortalPurchase.ViewValue = bit_PortalPurchase.TagCaption(2) != "" ? bit_PortalPurchase.TagCaption(2) : "No";
                }
                bit_PortalPurchase.ViewCustomAttributes = "";

                // str_WebName
                str_WebName.ViewValue = ConvertToString(str_WebName.CurrentValue); // DN
                str_WebName.ViewCustomAttributes = "";

                // bit_ExtraChk1
                if (ConvertToBool(bit_ExtraChk1.CurrentValue)) {
                    bit_ExtraChk1.ViewValue = bit_ExtraChk1.TagCaption(1) != "" ? bit_ExtraChk1.TagCaption(1) : "Yes";
                } else {
                    bit_ExtraChk1.ViewValue = bit_ExtraChk1.TagCaption(2) != "" ? bit_ExtraChk1.TagCaption(2) : "No";
                }
                bit_ExtraChk1.ViewCustomAttributes = "";

                // bit_ExtraChk2
                if (ConvertToBool(bit_ExtraChk2.CurrentValue)) {
                    bit_ExtraChk2.ViewValue = bit_ExtraChk2.TagCaption(1) != "" ? bit_ExtraChk2.TagCaption(1) : "Yes";
                } else {
                    bit_ExtraChk2.ViewValue = bit_ExtraChk2.TagCaption(2) != "" ? bit_ExtraChk2.TagCaption(2) : "No";
                }
                bit_ExtraChk2.ViewCustomAttributes = "";

                // str_ExtraDrpDown1
                str_ExtraDrpDown1.ViewValue = ConvertToString(str_ExtraDrpDown1.CurrentValue); // DN
                str_ExtraDrpDown1.ViewCustomAttributes = "";

                // str_ExtraDrpDown2
                str_ExtraDrpDown2.ViewValue = ConvertToString(str_ExtraDrpDown2.CurrentValue); // DN
                str_ExtraDrpDown2.ViewCustomAttributes = "";

                // str_Extratxt1
                str_Extratxt1.ViewValue = ConvertToString(str_Extratxt1.CurrentValue); // DN
                str_Extratxt1.ViewCustomAttributes = "";

                // str_Extratxt2
                str_Extratxt2.ViewValue = ConvertToString(str_Extratxt2.CurrentValue); // DN
                str_Extratxt2.ViewCustomAttributes = "";

                // str_OBHours
                str_OBHours.ViewValue = ConvertToString(str_OBHours.CurrentValue); // DN
                str_OBHours.ViewCustomAttributes = "";

                // str_OBMinutes
                str_OBMinutes.ViewValue = ConvertToString(str_OBMinutes.CurrentValue); // DN
                str_OBMinutes.ViewCustomAttributes = "";

                // str_TotalOB_Mins
                str_TotalOB_Mins.ViewValue = ConvertToString(str_TotalOB_Mins.CurrentValue); // DN
                str_TotalOB_Mins.ViewCustomAttributes = "";

                // LMSProductID
                LMSProductID.ViewValue = LMSProductID.CurrentValue;
                LMSProductID.ViewValue = FormatNumber(LMSProductID.ViewValue, LMSProductID.FormatPattern);
                LMSProductID.ViewCustomAttributes = "";

                // LMSNoOfAttempts
                LMSNoOfAttempts.ViewValue = LMSNoOfAttempts.CurrentValue;
                LMSNoOfAttempts.ViewValue = FormatNumber(LMSNoOfAttempts.ViewValue, LMSNoOfAttempts.FormatPattern);
                LMSNoOfAttempts.ViewCustomAttributes = "";

                // int_LMSLinkExpirationDays
                int_LMSLinkExpirationDays.ViewValue = int_LMSLinkExpirationDays.CurrentValue;
                int_LMSLinkExpirationDays.ViewValue = FormatNumber(int_LMSLinkExpirationDays.ViewValue, int_LMSLinkExpirationDays.FormatPattern);
                int_LMSLinkExpirationDays.ViewCustomAttributes = "";

                // IGD_product_id
                IGD_product_id.ViewValue = IGD_product_id.CurrentValue;
                IGD_product_id.ViewValue = FormatNumber(IGD_product_id.ViewValue, IGD_product_id.FormatPattern);
                IGD_product_id.ViewCustomAttributes = "";

                // IEC_product_id
                IEC_product_id.ViewValue = IEC_product_id.CurrentValue;
                IEC_product_id.ViewValue = FormatNumber(IEC_product_id.ViewValue, IEC_product_id.FormatPattern);
                IEC_product_id.ViewCustomAttributes = "";

                // Somastream_Product_ID
                Somastream_Product_ID.ViewValue = Somastream_Product_ID.CurrentValue;
                Somastream_Product_ID.ViewValue = FormatNumber(Somastream_Product_ID.ViewValue, Somastream_Product_ID.FormatPattern);
                Somastream_Product_ID.ViewCustomAttributes = "";

                // ProTREAD_Product_ID
                ProTREAD_Product_ID.ViewValue = ProTREAD_Product_ID.CurrentValue;
                ProTREAD_Product_ID.ViewValue = FormatNumber(ProTREAD_Product_ID.ViewValue, ProTREAD_Product_ID.FormatPattern);
                ProTREAD_Product_ID.ViewCustomAttributes = "";

                // ASD_product_id
                ASD_product_id.ViewValue = ASD_product_id.CurrentValue;
                ASD_product_id.ViewValue = FormatNumber(ASD_product_id.ViewValue, ASD_product_id.FormatPattern);
                ASD_product_id.ViewCustomAttributes = "";

                // D2L_product_Id
                D2L_product_Id.ViewValue = D2L_product_Id.CurrentValue;
                D2L_product_Id.ViewValue = FormatNumber(D2L_product_Id.ViewValue, D2L_product_Id.FormatPattern);
                D2L_product_Id.ViewCustomAttributes = "";

                // int_Course_Duration
                int_Course_Duration.ViewValue = int_Course_Duration.CurrentValue;
                int_Course_Duration.ViewValue = FormatNumber(int_Course_Duration.ViewValue, int_Course_Duration.FormatPattern);
                int_Course_Duration.ViewCustomAttributes = "";

                // Moodle_product_Id
                Moodle_product_Id.ViewValue = Moodle_product_Id.CurrentValue;
                Moodle_product_Id.ViewValue = FormatNumber(Moodle_product_Id.ViewValue, Moodle_product_Id.FormatPattern);
                Moodle_product_Id.ViewCustomAttributes = "";

                // int_Product_Id
                int_Product_Id.HrefValue = "";
                int_Product_Id.TooltipValue = "";

                // str_Product_Name
                str_Product_Name.HrefValue = "";
                str_Product_Name.TooltipValue = "";

                // str_Item_Code
                str_Item_Code.HrefValue = "";
                str_Item_Code.TooltipValue = "";

                // mny_Price
                mny_Price.HrefValue = "";
                mny_Price.TooltipValue = "";

                // bit_IsTaxable
                bit_IsTaxable.HrefValue = "";
                bit_IsTaxable.TooltipValue = "";

                // str_Web_Description
                str_Web_Description.HrefValue = "";
                str_Web_Description.TooltipValue = "";

                // dec_StateTax
                dec_StateTax.HrefValue = "";
                dec_StateTax.TooltipValue = "";

                // dec_AddTax
                dec_AddTax.HrefValue = "";
                dec_AddTax.TooltipValue = "";

                // mny_TotalPrice
                mny_TotalPrice.HrefValue = "";
                mny_TotalPrice.TooltipValue = "";

                // int_Product_Type
                int_Product_Type.HrefValue = "";
                int_Product_Type.TooltipValue = "";

                // int_Product_Sub_Type
                int_Product_Sub_Type.HrefValue = "";
                int_Product_Sub_Type.TooltipValue = "";

                // int_Status
                int_Status.HrefValue = "";
                int_Status.TooltipValue = "";

                // bit_Is_Web_Purchase
                bit_Is_Web_Purchase.HrefValue = "";
                bit_Is_Web_Purchase.TooltipValue = "";

                // str_BTW_Hours
                str_BTW_Hours.HrefValue = "";
                str_BTW_Hours.TooltipValue = "";

                // str_Hour
                str_Hour.HrefValue = "";
                str_Hour.TooltipValue = "";

                // Str_Minutes
                Str_Minutes.HrefValue = "";
                Str_Minutes.TooltipValue = "";

                // str_Appointment_Duration
                str_Appointment_Duration.HrefValue = "";
                str_Appointment_Duration.TooltipValue = "";

                // str_Notes
                str_Notes.HrefValue = "";
                str_Notes.TooltipValue = "";

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

                // int_Dollar
                int_Dollar.HrefValue = "";
                int_Dollar.TooltipValue = "";

                // bit_PortalPurchase
                bit_PortalPurchase.HrefValue = "";
                bit_PortalPurchase.TooltipValue = "";

                // str_WebName
                str_WebName.HrefValue = "";
                str_WebName.TooltipValue = "";

                // bit_ExtraChk1
                bit_ExtraChk1.HrefValue = "";
                bit_ExtraChk1.TooltipValue = "";

                // bit_ExtraChk2
                bit_ExtraChk2.HrefValue = "";
                bit_ExtraChk2.TooltipValue = "";

                // str_ExtraDrpDown1
                str_ExtraDrpDown1.HrefValue = "";
                str_ExtraDrpDown1.TooltipValue = "";

                // str_ExtraDrpDown2
                str_ExtraDrpDown2.HrefValue = "";
                str_ExtraDrpDown2.TooltipValue = "";

                // str_Extratxt1
                str_Extratxt1.HrefValue = "";
                str_Extratxt1.TooltipValue = "";

                // str_Extratxt2
                str_Extratxt2.HrefValue = "";
                str_Extratxt2.TooltipValue = "";

                // str_OBHours
                str_OBHours.HrefValue = "";
                str_OBHours.TooltipValue = "";

                // str_OBMinutes
                str_OBMinutes.HrefValue = "";
                str_OBMinutes.TooltipValue = "";

                // str_TotalOB_Mins
                str_TotalOB_Mins.HrefValue = "";
                str_TotalOB_Mins.TooltipValue = "";

                // LMSProductID
                LMSProductID.HrefValue = "";
                LMSProductID.TooltipValue = "";

                // LMSNoOfAttempts
                LMSNoOfAttempts.HrefValue = "";
                LMSNoOfAttempts.TooltipValue = "";

                // int_LMSLinkExpirationDays
                int_LMSLinkExpirationDays.HrefValue = "";
                int_LMSLinkExpirationDays.TooltipValue = "";

                // IGD_product_id
                IGD_product_id.HrefValue = "";
                IGD_product_id.TooltipValue = "";

                // IEC_product_id
                IEC_product_id.HrefValue = "";
                IEC_product_id.TooltipValue = "";

                // Somastream_Product_ID
                Somastream_Product_ID.HrefValue = "";
                Somastream_Product_ID.TooltipValue = "";

                // ProTREAD_Product_ID
                ProTREAD_Product_ID.HrefValue = "";
                ProTREAD_Product_ID.TooltipValue = "";

                // ASD_product_id
                ASD_product_id.HrefValue = "";
                ASD_product_id.TooltipValue = "";

                // D2L_product_Id
                D2L_product_Id.HrefValue = "";
                D2L_product_Id.TooltipValue = "";

                // int_Course_Duration
                int_Course_Duration.HrefValue = "";
                int_Course_Duration.TooltipValue = "";

                // Moodle_product_Id
                Moodle_product_Id.HrefValue = "";
                Moodle_product_Id.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblProductInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblProductInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblProductInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblProductInfolist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblProductInfosrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
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
