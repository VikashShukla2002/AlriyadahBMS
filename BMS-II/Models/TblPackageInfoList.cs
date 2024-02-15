namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblPackageInfoList
    /// </summary>
    public static TblPackageInfoList tblPackageInfoList
    {
        get => HttpData.Get<TblPackageInfoList>("tblPackageInfoList")!;
        set => HttpData["tblPackageInfoList"] = value;
    }

    /// <summary>
    /// Page class for tblPackageInfo
    /// </summary>
    public class TblPackageInfoList : TblPackageInfoListBase
    {
        // Constructor
        public TblPackageInfoList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblPackageInfoList() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblPackageInfoListBase : TblPackageInfo
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblPackageInfo";

        // Page object name
        public string PageObjName = "tblPackageInfoList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblPackageInfolist";

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
        public TblPackageInfoListBase()
        {
            // CSS class name as context
            TableVar = "tblPackageInfo";
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

            // Table object (tblPackageInfo)
            if (tblPackageInfo == null || tblPackageInfo is TblPackageInfo)
                tblPackageInfo = this;

            // Initialize URLs
            AddUrl = "TblPackageInfoAdd";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblPackageInfoDelete";
            MultiUpdateUrl = "TblPackageInfoUpdate";

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
        public string PageName => "TblPackageInfoList";

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
            int_Package_Id.SetVisibility();
            str_Package_Name.SetVisibility();
            str_Package_Code.SetVisibility();
            int_Status.SetVisibility();
            str_Discount.SetVisibility();
            mny_Price.SetVisibility();
            str_Notes.SetVisibility();
            bit_IswebSignUp.SetVisibility();
            str_Items.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_WebDescription.Visible = false;
            bit_PortalPurchase.SetVisibility();
            str_WebName.SetVisibility();
            bit_ExtraChk1.SetVisibility();
            bit_ExtraChk2.SetVisibility();
            str_ExtraDrpDown1.SetVisibility();
            str_ExtraDrpDown2.SetVisibility();
            str_Extratxt1.SetVisibility();
            str_Extratxt2.SetVisibility();
            is_Show.SetVisibility();
            is_ShowGridColumn.SetVisibility();
            rowIndex.SetVisibility();
            bit_referral.SetVisibility();
            str_Locations.Visible = false;
            str_PackageType.SetVisibility();
            int_ParentClass_Id.SetVisibility();
            str_CRcostHour.SetVisibility();
            str_BTWcostHour.SetVisibility();
            bit_OfferSpanishServices.SetVisibility();
            ByPassCRSelectionCentralizedOE.SetVisibility();
            str_WebNameArabic.SetVisibility();
            str_WebDescriptionArabic.Visible = false;
            PackageContractType.SetVisibility();
            blob_path.Visible = false;
            StudentSignXCordinate.SetVisibility();
            StudentSignYCordinate.SetVisibility();
            ParentSignXCordinate.SetVisibility();
            ParentSignYCordinate.SetVisibility();
            ParentSignPageNo.SetVisibility();
            StudentSignPageNo.SetVisibility();
            int_CDLProgramType.SetVisibility();
            int_CDLEndorsementCode.SetVisibility();
            int_CDLClassroom.SetVisibility();
            int_CDLRange.SetVisibility();
            int_CDLRoad.SetVisibility();
            bit_TPR_Package.SetVisibility();
            licenseTypeId.SetVisibility();
            bit_IsServiceForCertification.SetVisibility();
            intMinAgeYearToEnroll.SetVisibility();
            intMinAgeMonthToEnroll.SetVisibility();
            intMaxAgeYearToEnroll.SetVisibility();
            intMaxAgeMonthToEnroll.SetVisibility();
            intCompletionDeadlineYear.SetVisibility();
            intCompletionDeadlineMonth.SetVisibility();
            intCompletionDeadlineDay.SetVisibility();
            intCompletionDeadlineFrom.SetVisibility();
            bit_IsTexable.SetVisibility();
            str_Base_price.SetVisibility();
            str_Tax.SetVisibility();
        }

        // Constructor
        public TblPackageInfoListBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblPackageInfoView" ? "1" : "0"); // If View page, no primary button
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
            await SetupLookupOptions(bit_IswebSignUp);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_PortalPurchase);
            await SetupLookupOptions(bit_ExtraChk1);
            await SetupLookupOptions(bit_ExtraChk2);
            await SetupLookupOptions(is_Show);
            await SetupLookupOptions(is_ShowGridColumn);
            await SetupLookupOptions(bit_referral);
            await SetupLookupOptions(bit_OfferSpanishServices);
            await SetupLookupOptions(ByPassCRSelectionCentralizedOE);
            await SetupLookupOptions(bit_TPR_Package);
            await SetupLookupOptions(bit_IsServiceForCertification);
            await SetupLookupOptions(bit_IsTexable);

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblPackageInfogrid";

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
                tblPackageInfoList?.PageRender();
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
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblPackageInfosrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Package_Id.AdvancedSearch.ToJson())); // Field int_Package_Id
            filters.Merge(JObject.Parse(str_Package_Name.AdvancedSearch.ToJson())); // Field str_Package_Name
            filters.Merge(JObject.Parse(str_Package_Code.AdvancedSearch.ToJson())); // Field str_Package_Code
            filters.Merge(JObject.Parse(int_Status.AdvancedSearch.ToJson())); // Field int_Status
            filters.Merge(JObject.Parse(str_Discount.AdvancedSearch.ToJson())); // Field str_Discount
            filters.Merge(JObject.Parse(mny_Price.AdvancedSearch.ToJson())); // Field mny_Price
            filters.Merge(JObject.Parse(str_Notes.AdvancedSearch.ToJson())); // Field str_Notes
            filters.Merge(JObject.Parse(bit_IswebSignUp.AdvancedSearch.ToJson())); // Field bit_IswebSignUp
            filters.Merge(JObject.Parse(str_Items.AdvancedSearch.ToJson())); // Field str_Items
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(str_WebDescription.AdvancedSearch.ToJson())); // Field str_WebDescription
            filters.Merge(JObject.Parse(bit_PortalPurchase.AdvancedSearch.ToJson())); // Field bit_PortalPurchase
            filters.Merge(JObject.Parse(str_WebName.AdvancedSearch.ToJson())); // Field str_WebName
            filters.Merge(JObject.Parse(bit_ExtraChk1.AdvancedSearch.ToJson())); // Field bit_ExtraChk1
            filters.Merge(JObject.Parse(bit_ExtraChk2.AdvancedSearch.ToJson())); // Field bit_ExtraChk2
            filters.Merge(JObject.Parse(str_ExtraDrpDown1.AdvancedSearch.ToJson())); // Field str_ExtraDrpDown1
            filters.Merge(JObject.Parse(str_ExtraDrpDown2.AdvancedSearch.ToJson())); // Field str_ExtraDrpDown2
            filters.Merge(JObject.Parse(str_Extratxt1.AdvancedSearch.ToJson())); // Field str_Extratxt1
            filters.Merge(JObject.Parse(str_Extratxt2.AdvancedSearch.ToJson())); // Field str_Extratxt2
            filters.Merge(JObject.Parse(is_Show.AdvancedSearch.ToJson())); // Field is_Show
            filters.Merge(JObject.Parse(is_ShowGridColumn.AdvancedSearch.ToJson())); // Field is_ShowGridColumn
            filters.Merge(JObject.Parse(rowIndex.AdvancedSearch.ToJson())); // Field rowIndex
            filters.Merge(JObject.Parse(bit_referral.AdvancedSearch.ToJson())); // Field bit_referral
            filters.Merge(JObject.Parse(str_Locations.AdvancedSearch.ToJson())); // Field str_Locations
            filters.Merge(JObject.Parse(str_PackageType.AdvancedSearch.ToJson())); // Field str_PackageType
            filters.Merge(JObject.Parse(int_ParentClass_Id.AdvancedSearch.ToJson())); // Field int_ParentClass_Id
            filters.Merge(JObject.Parse(str_CRcostHour.AdvancedSearch.ToJson())); // Field str_CRcostHour
            filters.Merge(JObject.Parse(str_BTWcostHour.AdvancedSearch.ToJson())); // Field str_BTWcostHour
            filters.Merge(JObject.Parse(bit_OfferSpanishServices.AdvancedSearch.ToJson())); // Field bit_OfferSpanishServices
            filters.Merge(JObject.Parse(ByPassCRSelectionCentralizedOE.AdvancedSearch.ToJson())); // Field ByPassCRSelectionCentralizedOE
            filters.Merge(JObject.Parse(str_WebNameArabic.AdvancedSearch.ToJson())); // Field str_WebNameArabic
            filters.Merge(JObject.Parse(str_WebDescriptionArabic.AdvancedSearch.ToJson())); // Field str_WebDescriptionArabic
            filters.Merge(JObject.Parse(PackageContractType.AdvancedSearch.ToJson())); // Field PackageContractType
            filters.Merge(JObject.Parse(blob_path.AdvancedSearch.ToJson())); // Field blob_path
            filters.Merge(JObject.Parse(StudentSignXCordinate.AdvancedSearch.ToJson())); // Field StudentSignXCordinate
            filters.Merge(JObject.Parse(StudentSignYCordinate.AdvancedSearch.ToJson())); // Field StudentSignYCordinate
            filters.Merge(JObject.Parse(ParentSignXCordinate.AdvancedSearch.ToJson())); // Field ParentSignXCordinate
            filters.Merge(JObject.Parse(ParentSignYCordinate.AdvancedSearch.ToJson())); // Field ParentSignYCordinate
            filters.Merge(JObject.Parse(ParentSignPageNo.AdvancedSearch.ToJson())); // Field ParentSignPageNo
            filters.Merge(JObject.Parse(StudentSignPageNo.AdvancedSearch.ToJson())); // Field StudentSignPageNo
            filters.Merge(JObject.Parse(int_CDLProgramType.AdvancedSearch.ToJson())); // Field int_CDLProgramType
            filters.Merge(JObject.Parse(int_CDLEndorsementCode.AdvancedSearch.ToJson())); // Field int_CDLEndorsementCode
            filters.Merge(JObject.Parse(int_CDLClassroom.AdvancedSearch.ToJson())); // Field int_CDLClassroom
            filters.Merge(JObject.Parse(int_CDLRange.AdvancedSearch.ToJson())); // Field int_CDLRange
            filters.Merge(JObject.Parse(int_CDLRoad.AdvancedSearch.ToJson())); // Field int_CDLRoad
            filters.Merge(JObject.Parse(bit_TPR_Package.AdvancedSearch.ToJson())); // Field bit_TPR_Package
            filters.Merge(JObject.Parse(licenseTypeId.AdvancedSearch.ToJson())); // Field licenseTypeId
            filters.Merge(JObject.Parse(bit_IsServiceForCertification.AdvancedSearch.ToJson())); // Field bit_IsServiceForCertification
            filters.Merge(JObject.Parse(intMinAgeYearToEnroll.AdvancedSearch.ToJson())); // Field intMinAgeYearToEnroll
            filters.Merge(JObject.Parse(intMinAgeMonthToEnroll.AdvancedSearch.ToJson())); // Field intMinAgeMonthToEnroll
            filters.Merge(JObject.Parse(intMaxAgeYearToEnroll.AdvancedSearch.ToJson())); // Field intMaxAgeYearToEnroll
            filters.Merge(JObject.Parse(intMaxAgeMonthToEnroll.AdvancedSearch.ToJson())); // Field intMaxAgeMonthToEnroll
            filters.Merge(JObject.Parse(intCompletionDeadlineYear.AdvancedSearch.ToJson())); // Field intCompletionDeadlineYear
            filters.Merge(JObject.Parse(intCompletionDeadlineMonth.AdvancedSearch.ToJson())); // Field intCompletionDeadlineMonth
            filters.Merge(JObject.Parse(intCompletionDeadlineDay.AdvancedSearch.ToJson())); // Field intCompletionDeadlineDay
            filters.Merge(JObject.Parse(intCompletionDeadlineFrom.AdvancedSearch.ToJson())); // Field intCompletionDeadlineFrom
            filters.Merge(JObject.Parse(bit_IsTexable.AdvancedSearch.ToJson())); // Field bit_IsTexable
            filters.Merge(JObject.Parse(str_Base_price.AdvancedSearch.ToJson())); // Field str_Base_price
            filters.Merge(JObject.Parse(str_Tax.AdvancedSearch.ToJson())); // Field str_Tax
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblPackageInfosrch", filters);
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

            // Field str_Package_Code
            if (filter?.TryGetValue("x_str_Package_Code", out sv) ?? false) {
                str_Package_Code.AdvancedSearch.SearchValue = sv;
                str_Package_Code.AdvancedSearch.SearchOperator = filter["z_str_Package_Code"];
                str_Package_Code.AdvancedSearch.SearchCondition = filter["v_str_Package_Code"];
                str_Package_Code.AdvancedSearch.SearchValue2 = filter["y_str_Package_Code"];
                str_Package_Code.AdvancedSearch.SearchOperator2 = filter["w_str_Package_Code"];
                str_Package_Code.AdvancedSearch.Save();
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

            // Field str_Discount
            if (filter?.TryGetValue("x_str_Discount", out sv) ?? false) {
                str_Discount.AdvancedSearch.SearchValue = sv;
                str_Discount.AdvancedSearch.SearchOperator = filter["z_str_Discount"];
                str_Discount.AdvancedSearch.SearchCondition = filter["v_str_Discount"];
                str_Discount.AdvancedSearch.SearchValue2 = filter["y_str_Discount"];
                str_Discount.AdvancedSearch.SearchOperator2 = filter["w_str_Discount"];
                str_Discount.AdvancedSearch.Save();
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

            // Field str_Notes
            if (filter?.TryGetValue("x_str_Notes", out sv) ?? false) {
                str_Notes.AdvancedSearch.SearchValue = sv;
                str_Notes.AdvancedSearch.SearchOperator = filter["z_str_Notes"];
                str_Notes.AdvancedSearch.SearchCondition = filter["v_str_Notes"];
                str_Notes.AdvancedSearch.SearchValue2 = filter["y_str_Notes"];
                str_Notes.AdvancedSearch.SearchOperator2 = filter["w_str_Notes"];
                str_Notes.AdvancedSearch.Save();
            }

            // Field bit_IswebSignUp
            if (filter?.TryGetValue("x_bit_IswebSignUp", out sv) ?? false) {
                bit_IswebSignUp.AdvancedSearch.SearchValue = sv;
                bit_IswebSignUp.AdvancedSearch.SearchOperator = filter["z_bit_IswebSignUp"];
                bit_IswebSignUp.AdvancedSearch.SearchCondition = filter["v_bit_IswebSignUp"];
                bit_IswebSignUp.AdvancedSearch.SearchValue2 = filter["y_bit_IswebSignUp"];
                bit_IswebSignUp.AdvancedSearch.SearchOperator2 = filter["w_bit_IswebSignUp"];
                bit_IswebSignUp.AdvancedSearch.Save();
            }

            // Field str_Items
            if (filter?.TryGetValue("x_str_Items", out sv) ?? false) {
                str_Items.AdvancedSearch.SearchValue = sv;
                str_Items.AdvancedSearch.SearchOperator = filter["z_str_Items"];
                str_Items.AdvancedSearch.SearchCondition = filter["v_str_Items"];
                str_Items.AdvancedSearch.SearchValue2 = filter["y_str_Items"];
                str_Items.AdvancedSearch.SearchOperator2 = filter["w_str_Items"];
                str_Items.AdvancedSearch.Save();
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

            // Field str_WebDescription
            if (filter?.TryGetValue("x_str_WebDescription", out sv) ?? false) {
                str_WebDescription.AdvancedSearch.SearchValue = sv;
                str_WebDescription.AdvancedSearch.SearchOperator = filter["z_str_WebDescription"];
                str_WebDescription.AdvancedSearch.SearchCondition = filter["v_str_WebDescription"];
                str_WebDescription.AdvancedSearch.SearchValue2 = filter["y_str_WebDescription"];
                str_WebDescription.AdvancedSearch.SearchOperator2 = filter["w_str_WebDescription"];
                str_WebDescription.AdvancedSearch.Save();
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

            // Field bit_referral
            if (filter?.TryGetValue("x_bit_referral", out sv) ?? false) {
                bit_referral.AdvancedSearch.SearchValue = sv;
                bit_referral.AdvancedSearch.SearchOperator = filter["z_bit_referral"];
                bit_referral.AdvancedSearch.SearchCondition = filter["v_bit_referral"];
                bit_referral.AdvancedSearch.SearchValue2 = filter["y_bit_referral"];
                bit_referral.AdvancedSearch.SearchOperator2 = filter["w_bit_referral"];
                bit_referral.AdvancedSearch.Save();
            }

            // Field str_Locations
            if (filter?.TryGetValue("x_str_Locations", out sv) ?? false) {
                str_Locations.AdvancedSearch.SearchValue = sv;
                str_Locations.AdvancedSearch.SearchOperator = filter["z_str_Locations"];
                str_Locations.AdvancedSearch.SearchCondition = filter["v_str_Locations"];
                str_Locations.AdvancedSearch.SearchValue2 = filter["y_str_Locations"];
                str_Locations.AdvancedSearch.SearchOperator2 = filter["w_str_Locations"];
                str_Locations.AdvancedSearch.Save();
            }

            // Field str_PackageType
            if (filter?.TryGetValue("x_str_PackageType", out sv) ?? false) {
                str_PackageType.AdvancedSearch.SearchValue = sv;
                str_PackageType.AdvancedSearch.SearchOperator = filter["z_str_PackageType"];
                str_PackageType.AdvancedSearch.SearchCondition = filter["v_str_PackageType"];
                str_PackageType.AdvancedSearch.SearchValue2 = filter["y_str_PackageType"];
                str_PackageType.AdvancedSearch.SearchOperator2 = filter["w_str_PackageType"];
                str_PackageType.AdvancedSearch.Save();
            }

            // Field int_ParentClass_Id
            if (filter?.TryGetValue("x_int_ParentClass_Id", out sv) ?? false) {
                int_ParentClass_Id.AdvancedSearch.SearchValue = sv;
                int_ParentClass_Id.AdvancedSearch.SearchOperator = filter["z_int_ParentClass_Id"];
                int_ParentClass_Id.AdvancedSearch.SearchCondition = filter["v_int_ParentClass_Id"];
                int_ParentClass_Id.AdvancedSearch.SearchValue2 = filter["y_int_ParentClass_Id"];
                int_ParentClass_Id.AdvancedSearch.SearchOperator2 = filter["w_int_ParentClass_Id"];
                int_ParentClass_Id.AdvancedSearch.Save();
            }

            // Field str_CRcostHour
            if (filter?.TryGetValue("x_str_CRcostHour", out sv) ?? false) {
                str_CRcostHour.AdvancedSearch.SearchValue = sv;
                str_CRcostHour.AdvancedSearch.SearchOperator = filter["z_str_CRcostHour"];
                str_CRcostHour.AdvancedSearch.SearchCondition = filter["v_str_CRcostHour"];
                str_CRcostHour.AdvancedSearch.SearchValue2 = filter["y_str_CRcostHour"];
                str_CRcostHour.AdvancedSearch.SearchOperator2 = filter["w_str_CRcostHour"];
                str_CRcostHour.AdvancedSearch.Save();
            }

            // Field str_BTWcostHour
            if (filter?.TryGetValue("x_str_BTWcostHour", out sv) ?? false) {
                str_BTWcostHour.AdvancedSearch.SearchValue = sv;
                str_BTWcostHour.AdvancedSearch.SearchOperator = filter["z_str_BTWcostHour"];
                str_BTWcostHour.AdvancedSearch.SearchCondition = filter["v_str_BTWcostHour"];
                str_BTWcostHour.AdvancedSearch.SearchValue2 = filter["y_str_BTWcostHour"];
                str_BTWcostHour.AdvancedSearch.SearchOperator2 = filter["w_str_BTWcostHour"];
                str_BTWcostHour.AdvancedSearch.Save();
            }

            // Field bit_OfferSpanishServices
            if (filter?.TryGetValue("x_bit_OfferSpanishServices", out sv) ?? false) {
                bit_OfferSpanishServices.AdvancedSearch.SearchValue = sv;
                bit_OfferSpanishServices.AdvancedSearch.SearchOperator = filter["z_bit_OfferSpanishServices"];
                bit_OfferSpanishServices.AdvancedSearch.SearchCondition = filter["v_bit_OfferSpanishServices"];
                bit_OfferSpanishServices.AdvancedSearch.SearchValue2 = filter["y_bit_OfferSpanishServices"];
                bit_OfferSpanishServices.AdvancedSearch.SearchOperator2 = filter["w_bit_OfferSpanishServices"];
                bit_OfferSpanishServices.AdvancedSearch.Save();
            }

            // Field ByPassCRSelectionCentralizedOE
            if (filter?.TryGetValue("x_ByPassCRSelectionCentralizedOE", out sv) ?? false) {
                ByPassCRSelectionCentralizedOE.AdvancedSearch.SearchValue = sv;
                ByPassCRSelectionCentralizedOE.AdvancedSearch.SearchOperator = filter["z_ByPassCRSelectionCentralizedOE"];
                ByPassCRSelectionCentralizedOE.AdvancedSearch.SearchCondition = filter["v_ByPassCRSelectionCentralizedOE"];
                ByPassCRSelectionCentralizedOE.AdvancedSearch.SearchValue2 = filter["y_ByPassCRSelectionCentralizedOE"];
                ByPassCRSelectionCentralizedOE.AdvancedSearch.SearchOperator2 = filter["w_ByPassCRSelectionCentralizedOE"];
                ByPassCRSelectionCentralizedOE.AdvancedSearch.Save();
            }

            // Field str_WebNameArabic
            if (filter?.TryGetValue("x_str_WebNameArabic", out sv) ?? false) {
                str_WebNameArabic.AdvancedSearch.SearchValue = sv;
                str_WebNameArabic.AdvancedSearch.SearchOperator = filter["z_str_WebNameArabic"];
                str_WebNameArabic.AdvancedSearch.SearchCondition = filter["v_str_WebNameArabic"];
                str_WebNameArabic.AdvancedSearch.SearchValue2 = filter["y_str_WebNameArabic"];
                str_WebNameArabic.AdvancedSearch.SearchOperator2 = filter["w_str_WebNameArabic"];
                str_WebNameArabic.AdvancedSearch.Save();
            }

            // Field str_WebDescriptionArabic
            if (filter?.TryGetValue("x_str_WebDescriptionArabic", out sv) ?? false) {
                str_WebDescriptionArabic.AdvancedSearch.SearchValue = sv;
                str_WebDescriptionArabic.AdvancedSearch.SearchOperator = filter["z_str_WebDescriptionArabic"];
                str_WebDescriptionArabic.AdvancedSearch.SearchCondition = filter["v_str_WebDescriptionArabic"];
                str_WebDescriptionArabic.AdvancedSearch.SearchValue2 = filter["y_str_WebDescriptionArabic"];
                str_WebDescriptionArabic.AdvancedSearch.SearchOperator2 = filter["w_str_WebDescriptionArabic"];
                str_WebDescriptionArabic.AdvancedSearch.Save();
            }

            // Field PackageContractType
            if (filter?.TryGetValue("x_PackageContractType", out sv) ?? false) {
                PackageContractType.AdvancedSearch.SearchValue = sv;
                PackageContractType.AdvancedSearch.SearchOperator = filter["z_PackageContractType"];
                PackageContractType.AdvancedSearch.SearchCondition = filter["v_PackageContractType"];
                PackageContractType.AdvancedSearch.SearchValue2 = filter["y_PackageContractType"];
                PackageContractType.AdvancedSearch.SearchOperator2 = filter["w_PackageContractType"];
                PackageContractType.AdvancedSearch.Save();
            }

            // Field blob_path
            if (filter?.TryGetValue("x_blob_path", out sv) ?? false) {
                blob_path.AdvancedSearch.SearchValue = sv;
                blob_path.AdvancedSearch.SearchOperator = filter["z_blob_path"];
                blob_path.AdvancedSearch.SearchCondition = filter["v_blob_path"];
                blob_path.AdvancedSearch.SearchValue2 = filter["y_blob_path"];
                blob_path.AdvancedSearch.SearchOperator2 = filter["w_blob_path"];
                blob_path.AdvancedSearch.Save();
            }

            // Field StudentSignXCordinate
            if (filter?.TryGetValue("x_StudentSignXCordinate", out sv) ?? false) {
                StudentSignXCordinate.AdvancedSearch.SearchValue = sv;
                StudentSignXCordinate.AdvancedSearch.SearchOperator = filter["z_StudentSignXCordinate"];
                StudentSignXCordinate.AdvancedSearch.SearchCondition = filter["v_StudentSignXCordinate"];
                StudentSignXCordinate.AdvancedSearch.SearchValue2 = filter["y_StudentSignXCordinate"];
                StudentSignXCordinate.AdvancedSearch.SearchOperator2 = filter["w_StudentSignXCordinate"];
                StudentSignXCordinate.AdvancedSearch.Save();
            }

            // Field StudentSignYCordinate
            if (filter?.TryGetValue("x_StudentSignYCordinate", out sv) ?? false) {
                StudentSignYCordinate.AdvancedSearch.SearchValue = sv;
                StudentSignYCordinate.AdvancedSearch.SearchOperator = filter["z_StudentSignYCordinate"];
                StudentSignYCordinate.AdvancedSearch.SearchCondition = filter["v_StudentSignYCordinate"];
                StudentSignYCordinate.AdvancedSearch.SearchValue2 = filter["y_StudentSignYCordinate"];
                StudentSignYCordinate.AdvancedSearch.SearchOperator2 = filter["w_StudentSignYCordinate"];
                StudentSignYCordinate.AdvancedSearch.Save();
            }

            // Field ParentSignXCordinate
            if (filter?.TryGetValue("x_ParentSignXCordinate", out sv) ?? false) {
                ParentSignXCordinate.AdvancedSearch.SearchValue = sv;
                ParentSignXCordinate.AdvancedSearch.SearchOperator = filter["z_ParentSignXCordinate"];
                ParentSignXCordinate.AdvancedSearch.SearchCondition = filter["v_ParentSignXCordinate"];
                ParentSignXCordinate.AdvancedSearch.SearchValue2 = filter["y_ParentSignXCordinate"];
                ParentSignXCordinate.AdvancedSearch.SearchOperator2 = filter["w_ParentSignXCordinate"];
                ParentSignXCordinate.AdvancedSearch.Save();
            }

            // Field ParentSignYCordinate
            if (filter?.TryGetValue("x_ParentSignYCordinate", out sv) ?? false) {
                ParentSignYCordinate.AdvancedSearch.SearchValue = sv;
                ParentSignYCordinate.AdvancedSearch.SearchOperator = filter["z_ParentSignYCordinate"];
                ParentSignYCordinate.AdvancedSearch.SearchCondition = filter["v_ParentSignYCordinate"];
                ParentSignYCordinate.AdvancedSearch.SearchValue2 = filter["y_ParentSignYCordinate"];
                ParentSignYCordinate.AdvancedSearch.SearchOperator2 = filter["w_ParentSignYCordinate"];
                ParentSignYCordinate.AdvancedSearch.Save();
            }

            // Field ParentSignPageNo
            if (filter?.TryGetValue("x_ParentSignPageNo", out sv) ?? false) {
                ParentSignPageNo.AdvancedSearch.SearchValue = sv;
                ParentSignPageNo.AdvancedSearch.SearchOperator = filter["z_ParentSignPageNo"];
                ParentSignPageNo.AdvancedSearch.SearchCondition = filter["v_ParentSignPageNo"];
                ParentSignPageNo.AdvancedSearch.SearchValue2 = filter["y_ParentSignPageNo"];
                ParentSignPageNo.AdvancedSearch.SearchOperator2 = filter["w_ParentSignPageNo"];
                ParentSignPageNo.AdvancedSearch.Save();
            }

            // Field StudentSignPageNo
            if (filter?.TryGetValue("x_StudentSignPageNo", out sv) ?? false) {
                StudentSignPageNo.AdvancedSearch.SearchValue = sv;
                StudentSignPageNo.AdvancedSearch.SearchOperator = filter["z_StudentSignPageNo"];
                StudentSignPageNo.AdvancedSearch.SearchCondition = filter["v_StudentSignPageNo"];
                StudentSignPageNo.AdvancedSearch.SearchValue2 = filter["y_StudentSignPageNo"];
                StudentSignPageNo.AdvancedSearch.SearchOperator2 = filter["w_StudentSignPageNo"];
                StudentSignPageNo.AdvancedSearch.Save();
            }

            // Field int_CDLProgramType
            if (filter?.TryGetValue("x_int_CDLProgramType", out sv) ?? false) {
                int_CDLProgramType.AdvancedSearch.SearchValue = sv;
                int_CDLProgramType.AdvancedSearch.SearchOperator = filter["z_int_CDLProgramType"];
                int_CDLProgramType.AdvancedSearch.SearchCondition = filter["v_int_CDLProgramType"];
                int_CDLProgramType.AdvancedSearch.SearchValue2 = filter["y_int_CDLProgramType"];
                int_CDLProgramType.AdvancedSearch.SearchOperator2 = filter["w_int_CDLProgramType"];
                int_CDLProgramType.AdvancedSearch.Save();
            }

            // Field int_CDLEndorsementCode
            if (filter?.TryGetValue("x_int_CDLEndorsementCode", out sv) ?? false) {
                int_CDLEndorsementCode.AdvancedSearch.SearchValue = sv;
                int_CDLEndorsementCode.AdvancedSearch.SearchOperator = filter["z_int_CDLEndorsementCode"];
                int_CDLEndorsementCode.AdvancedSearch.SearchCondition = filter["v_int_CDLEndorsementCode"];
                int_CDLEndorsementCode.AdvancedSearch.SearchValue2 = filter["y_int_CDLEndorsementCode"];
                int_CDLEndorsementCode.AdvancedSearch.SearchOperator2 = filter["w_int_CDLEndorsementCode"];
                int_CDLEndorsementCode.AdvancedSearch.Save();
            }

            // Field int_CDLClassroom
            if (filter?.TryGetValue("x_int_CDLClassroom", out sv) ?? false) {
                int_CDLClassroom.AdvancedSearch.SearchValue = sv;
                int_CDLClassroom.AdvancedSearch.SearchOperator = filter["z_int_CDLClassroom"];
                int_CDLClassroom.AdvancedSearch.SearchCondition = filter["v_int_CDLClassroom"];
                int_CDLClassroom.AdvancedSearch.SearchValue2 = filter["y_int_CDLClassroom"];
                int_CDLClassroom.AdvancedSearch.SearchOperator2 = filter["w_int_CDLClassroom"];
                int_CDLClassroom.AdvancedSearch.Save();
            }

            // Field int_CDLRange
            if (filter?.TryGetValue("x_int_CDLRange", out sv) ?? false) {
                int_CDLRange.AdvancedSearch.SearchValue = sv;
                int_CDLRange.AdvancedSearch.SearchOperator = filter["z_int_CDLRange"];
                int_CDLRange.AdvancedSearch.SearchCondition = filter["v_int_CDLRange"];
                int_CDLRange.AdvancedSearch.SearchValue2 = filter["y_int_CDLRange"];
                int_CDLRange.AdvancedSearch.SearchOperator2 = filter["w_int_CDLRange"];
                int_CDLRange.AdvancedSearch.Save();
            }

            // Field int_CDLRoad
            if (filter?.TryGetValue("x_int_CDLRoad", out sv) ?? false) {
                int_CDLRoad.AdvancedSearch.SearchValue = sv;
                int_CDLRoad.AdvancedSearch.SearchOperator = filter["z_int_CDLRoad"];
                int_CDLRoad.AdvancedSearch.SearchCondition = filter["v_int_CDLRoad"];
                int_CDLRoad.AdvancedSearch.SearchValue2 = filter["y_int_CDLRoad"];
                int_CDLRoad.AdvancedSearch.SearchOperator2 = filter["w_int_CDLRoad"];
                int_CDLRoad.AdvancedSearch.Save();
            }

            // Field bit_TPR_Package
            if (filter?.TryGetValue("x_bit_TPR_Package", out sv) ?? false) {
                bit_TPR_Package.AdvancedSearch.SearchValue = sv;
                bit_TPR_Package.AdvancedSearch.SearchOperator = filter["z_bit_TPR_Package"];
                bit_TPR_Package.AdvancedSearch.SearchCondition = filter["v_bit_TPR_Package"];
                bit_TPR_Package.AdvancedSearch.SearchValue2 = filter["y_bit_TPR_Package"];
                bit_TPR_Package.AdvancedSearch.SearchOperator2 = filter["w_bit_TPR_Package"];
                bit_TPR_Package.AdvancedSearch.Save();
            }

            // Field licenseTypeId
            if (filter?.TryGetValue("x_licenseTypeId", out sv) ?? false) {
                licenseTypeId.AdvancedSearch.SearchValue = sv;
                licenseTypeId.AdvancedSearch.SearchOperator = filter["z_licenseTypeId"];
                licenseTypeId.AdvancedSearch.SearchCondition = filter["v_licenseTypeId"];
                licenseTypeId.AdvancedSearch.SearchValue2 = filter["y_licenseTypeId"];
                licenseTypeId.AdvancedSearch.SearchOperator2 = filter["w_licenseTypeId"];
                licenseTypeId.AdvancedSearch.Save();
            }

            // Field bit_IsServiceForCertification
            if (filter?.TryGetValue("x_bit_IsServiceForCertification", out sv) ?? false) {
                bit_IsServiceForCertification.AdvancedSearch.SearchValue = sv;
                bit_IsServiceForCertification.AdvancedSearch.SearchOperator = filter["z_bit_IsServiceForCertification"];
                bit_IsServiceForCertification.AdvancedSearch.SearchCondition = filter["v_bit_IsServiceForCertification"];
                bit_IsServiceForCertification.AdvancedSearch.SearchValue2 = filter["y_bit_IsServiceForCertification"];
                bit_IsServiceForCertification.AdvancedSearch.SearchOperator2 = filter["w_bit_IsServiceForCertification"];
                bit_IsServiceForCertification.AdvancedSearch.Save();
            }

            // Field intMinAgeYearToEnroll
            if (filter?.TryGetValue("x_intMinAgeYearToEnroll", out sv) ?? false) {
                intMinAgeYearToEnroll.AdvancedSearch.SearchValue = sv;
                intMinAgeYearToEnroll.AdvancedSearch.SearchOperator = filter["z_intMinAgeYearToEnroll"];
                intMinAgeYearToEnroll.AdvancedSearch.SearchCondition = filter["v_intMinAgeYearToEnroll"];
                intMinAgeYearToEnroll.AdvancedSearch.SearchValue2 = filter["y_intMinAgeYearToEnroll"];
                intMinAgeYearToEnroll.AdvancedSearch.SearchOperator2 = filter["w_intMinAgeYearToEnroll"];
                intMinAgeYearToEnroll.AdvancedSearch.Save();
            }

            // Field intMinAgeMonthToEnroll
            if (filter?.TryGetValue("x_intMinAgeMonthToEnroll", out sv) ?? false) {
                intMinAgeMonthToEnroll.AdvancedSearch.SearchValue = sv;
                intMinAgeMonthToEnroll.AdvancedSearch.SearchOperator = filter["z_intMinAgeMonthToEnroll"];
                intMinAgeMonthToEnroll.AdvancedSearch.SearchCondition = filter["v_intMinAgeMonthToEnroll"];
                intMinAgeMonthToEnroll.AdvancedSearch.SearchValue2 = filter["y_intMinAgeMonthToEnroll"];
                intMinAgeMonthToEnroll.AdvancedSearch.SearchOperator2 = filter["w_intMinAgeMonthToEnroll"];
                intMinAgeMonthToEnroll.AdvancedSearch.Save();
            }

            // Field intMaxAgeYearToEnroll
            if (filter?.TryGetValue("x_intMaxAgeYearToEnroll", out sv) ?? false) {
                intMaxAgeYearToEnroll.AdvancedSearch.SearchValue = sv;
                intMaxAgeYearToEnroll.AdvancedSearch.SearchOperator = filter["z_intMaxAgeYearToEnroll"];
                intMaxAgeYearToEnroll.AdvancedSearch.SearchCondition = filter["v_intMaxAgeYearToEnroll"];
                intMaxAgeYearToEnroll.AdvancedSearch.SearchValue2 = filter["y_intMaxAgeYearToEnroll"];
                intMaxAgeYearToEnroll.AdvancedSearch.SearchOperator2 = filter["w_intMaxAgeYearToEnroll"];
                intMaxAgeYearToEnroll.AdvancedSearch.Save();
            }

            // Field intMaxAgeMonthToEnroll
            if (filter?.TryGetValue("x_intMaxAgeMonthToEnroll", out sv) ?? false) {
                intMaxAgeMonthToEnroll.AdvancedSearch.SearchValue = sv;
                intMaxAgeMonthToEnroll.AdvancedSearch.SearchOperator = filter["z_intMaxAgeMonthToEnroll"];
                intMaxAgeMonthToEnroll.AdvancedSearch.SearchCondition = filter["v_intMaxAgeMonthToEnroll"];
                intMaxAgeMonthToEnroll.AdvancedSearch.SearchValue2 = filter["y_intMaxAgeMonthToEnroll"];
                intMaxAgeMonthToEnroll.AdvancedSearch.SearchOperator2 = filter["w_intMaxAgeMonthToEnroll"];
                intMaxAgeMonthToEnroll.AdvancedSearch.Save();
            }

            // Field intCompletionDeadlineYear
            if (filter?.TryGetValue("x_intCompletionDeadlineYear", out sv) ?? false) {
                intCompletionDeadlineYear.AdvancedSearch.SearchValue = sv;
                intCompletionDeadlineYear.AdvancedSearch.SearchOperator = filter["z_intCompletionDeadlineYear"];
                intCompletionDeadlineYear.AdvancedSearch.SearchCondition = filter["v_intCompletionDeadlineYear"];
                intCompletionDeadlineYear.AdvancedSearch.SearchValue2 = filter["y_intCompletionDeadlineYear"];
                intCompletionDeadlineYear.AdvancedSearch.SearchOperator2 = filter["w_intCompletionDeadlineYear"];
                intCompletionDeadlineYear.AdvancedSearch.Save();
            }

            // Field intCompletionDeadlineMonth
            if (filter?.TryGetValue("x_intCompletionDeadlineMonth", out sv) ?? false) {
                intCompletionDeadlineMonth.AdvancedSearch.SearchValue = sv;
                intCompletionDeadlineMonth.AdvancedSearch.SearchOperator = filter["z_intCompletionDeadlineMonth"];
                intCompletionDeadlineMonth.AdvancedSearch.SearchCondition = filter["v_intCompletionDeadlineMonth"];
                intCompletionDeadlineMonth.AdvancedSearch.SearchValue2 = filter["y_intCompletionDeadlineMonth"];
                intCompletionDeadlineMonth.AdvancedSearch.SearchOperator2 = filter["w_intCompletionDeadlineMonth"];
                intCompletionDeadlineMonth.AdvancedSearch.Save();
            }

            // Field intCompletionDeadlineDay
            if (filter?.TryGetValue("x_intCompletionDeadlineDay", out sv) ?? false) {
                intCompletionDeadlineDay.AdvancedSearch.SearchValue = sv;
                intCompletionDeadlineDay.AdvancedSearch.SearchOperator = filter["z_intCompletionDeadlineDay"];
                intCompletionDeadlineDay.AdvancedSearch.SearchCondition = filter["v_intCompletionDeadlineDay"];
                intCompletionDeadlineDay.AdvancedSearch.SearchValue2 = filter["y_intCompletionDeadlineDay"];
                intCompletionDeadlineDay.AdvancedSearch.SearchOperator2 = filter["w_intCompletionDeadlineDay"];
                intCompletionDeadlineDay.AdvancedSearch.Save();
            }

            // Field intCompletionDeadlineFrom
            if (filter?.TryGetValue("x_intCompletionDeadlineFrom", out sv) ?? false) {
                intCompletionDeadlineFrom.AdvancedSearch.SearchValue = sv;
                intCompletionDeadlineFrom.AdvancedSearch.SearchOperator = filter["z_intCompletionDeadlineFrom"];
                intCompletionDeadlineFrom.AdvancedSearch.SearchCondition = filter["v_intCompletionDeadlineFrom"];
                intCompletionDeadlineFrom.AdvancedSearch.SearchValue2 = filter["y_intCompletionDeadlineFrom"];
                intCompletionDeadlineFrom.AdvancedSearch.SearchOperator2 = filter["w_intCompletionDeadlineFrom"];
                intCompletionDeadlineFrom.AdvancedSearch.Save();
            }

            // Field bit_IsTexable
            if (filter?.TryGetValue("x_bit_IsTexable", out sv) ?? false) {
                bit_IsTexable.AdvancedSearch.SearchValue = sv;
                bit_IsTexable.AdvancedSearch.SearchOperator = filter["z_bit_IsTexable"];
                bit_IsTexable.AdvancedSearch.SearchCondition = filter["v_bit_IsTexable"];
                bit_IsTexable.AdvancedSearch.SearchValue2 = filter["y_bit_IsTexable"];
                bit_IsTexable.AdvancedSearch.SearchOperator2 = filter["w_bit_IsTexable"];
                bit_IsTexable.AdvancedSearch.Save();
            }

            // Field str_Base_price
            if (filter?.TryGetValue("x_str_Base_price", out sv) ?? false) {
                str_Base_price.AdvancedSearch.SearchValue = sv;
                str_Base_price.AdvancedSearch.SearchOperator = filter["z_str_Base_price"];
                str_Base_price.AdvancedSearch.SearchCondition = filter["v_str_Base_price"];
                str_Base_price.AdvancedSearch.SearchValue2 = filter["y_str_Base_price"];
                str_Base_price.AdvancedSearch.SearchOperator2 = filter["w_str_Base_price"];
                str_Base_price.AdvancedSearch.Save();
            }

            // Field str_Tax
            if (filter?.TryGetValue("x_str_Tax", out sv) ?? false) {
                str_Tax.AdvancedSearch.SearchValue = sv;
                str_Tax.AdvancedSearch.SearchOperator = filter["z_str_Tax"];
                str_Tax.AdvancedSearch.SearchCondition = filter["v_str_Tax"];
                str_Tax.AdvancedSearch.SearchValue2 = filter["y_str_Tax"];
                str_Tax.AdvancedSearch.SearchOperator2 = filter["w_str_Tax"];
                str_Tax.AdvancedSearch.Save();
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
            searchFlds.Add(str_Package_Name);
            searchFlds.Add(str_Package_Code);
            searchFlds.Add(str_Discount);
            searchFlds.Add(str_Notes);
            searchFlds.Add(str_Items);
            searchFlds.Add(str_WebDescription);
            searchFlds.Add(str_WebName);
            searchFlds.Add(str_ExtraDrpDown1);
            searchFlds.Add(str_ExtraDrpDown2);
            searchFlds.Add(str_Extratxt1);
            searchFlds.Add(str_Extratxt2);
            searchFlds.Add(rowIndex);
            searchFlds.Add(str_Locations);
            searchFlds.Add(str_PackageType);
            searchFlds.Add(str_WebNameArabic);
            searchFlds.Add(str_WebDescriptionArabic);
            searchFlds.Add(blob_path);
            searchFlds.Add(intMinAgeYearToEnroll);
            searchFlds.Add(intMinAgeMonthToEnroll);
            searchFlds.Add(intMaxAgeYearToEnroll);
            searchFlds.Add(intMaxAgeMonthToEnroll);
            searchFlds.Add(intCompletionDeadlineYear);
            searchFlds.Add(intCompletionDeadlineMonth);
            searchFlds.Add(intCompletionDeadlineDay);
            searchFlds.Add(intCompletionDeadlineFrom);
            searchFlds.Add(str_Base_price);
            searchFlds.Add(str_Tax);
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
                UpdateSort(int_Package_Id, ctrl); // int_Package_Id
                UpdateSort(str_Package_Name, ctrl); // str_Package_Name
                UpdateSort(str_Package_Code, ctrl); // str_Package_Code
                UpdateSort(int_Status, ctrl); // int_Status
                UpdateSort(str_Discount, ctrl); // str_Discount
                UpdateSort(mny_Price, ctrl); // mny_Price
                UpdateSort(str_Notes, ctrl); // str_Notes
                UpdateSort(bit_IswebSignUp, ctrl); // bit_IswebSignUp
                UpdateSort(str_Items, ctrl); // str_Items
                UpdateSort(int_Created_By, ctrl); // int_Created_By
                UpdateSort(int_Modified_By, ctrl); // int_Modified_By
                UpdateSort(date_Created, ctrl); // date_Created
                UpdateSort(date_Modified, ctrl); // date_Modified
                UpdateSort(bit_IsDeleted, ctrl); // bit_IsDeleted
                UpdateSort(bit_PortalPurchase, ctrl); // bit_PortalPurchase
                UpdateSort(str_WebName, ctrl); // str_WebName
                UpdateSort(bit_ExtraChk1, ctrl); // bit_ExtraChk1
                UpdateSort(bit_ExtraChk2, ctrl); // bit_ExtraChk2
                UpdateSort(str_ExtraDrpDown1, ctrl); // str_ExtraDrpDown1
                UpdateSort(str_ExtraDrpDown2, ctrl); // str_ExtraDrpDown2
                UpdateSort(str_Extratxt1, ctrl); // str_Extratxt1
                UpdateSort(str_Extratxt2, ctrl); // str_Extratxt2
                UpdateSort(is_Show, ctrl); // is_Show
                UpdateSort(is_ShowGridColumn, ctrl); // is_ShowGridColumn
                UpdateSort(rowIndex, ctrl); // rowIndex
                UpdateSort(bit_referral, ctrl); // bit_referral
                UpdateSort(str_PackageType, ctrl); // str_PackageType
                UpdateSort(int_ParentClass_Id, ctrl); // int_ParentClass_Id
                UpdateSort(str_CRcostHour, ctrl); // str_CRcostHour
                UpdateSort(str_BTWcostHour, ctrl); // str_BTWcostHour
                UpdateSort(bit_OfferSpanishServices, ctrl); // bit_OfferSpanishServices
                UpdateSort(ByPassCRSelectionCentralizedOE, ctrl); // ByPassCRSelectionCentralizedOE
                UpdateSort(str_WebNameArabic, ctrl); // str_WebNameArabic
                UpdateSort(PackageContractType, ctrl); // PackageContractType
                UpdateSort(StudentSignXCordinate, ctrl); // StudentSignXCordinate
                UpdateSort(StudentSignYCordinate, ctrl); // StudentSignYCordinate
                UpdateSort(ParentSignXCordinate, ctrl); // ParentSignXCordinate
                UpdateSort(ParentSignYCordinate, ctrl); // ParentSignYCordinate
                UpdateSort(ParentSignPageNo, ctrl); // ParentSignPageNo
                UpdateSort(StudentSignPageNo, ctrl); // StudentSignPageNo
                UpdateSort(int_CDLProgramType, ctrl); // int_CDLProgramType
                UpdateSort(int_CDLEndorsementCode, ctrl); // int_CDLEndorsementCode
                UpdateSort(int_CDLClassroom, ctrl); // int_CDLClassroom
                UpdateSort(int_CDLRange, ctrl); // int_CDLRange
                UpdateSort(int_CDLRoad, ctrl); // int_CDLRoad
                UpdateSort(bit_TPR_Package, ctrl); // bit_TPR_Package
                UpdateSort(licenseTypeId, ctrl); // licenseTypeId
                UpdateSort(bit_IsServiceForCertification, ctrl); // bit_IsServiceForCertification
                UpdateSort(intMinAgeYearToEnroll, ctrl); // intMinAgeYearToEnroll
                UpdateSort(intMinAgeMonthToEnroll, ctrl); // intMinAgeMonthToEnroll
                UpdateSort(intMaxAgeYearToEnroll, ctrl); // intMaxAgeYearToEnroll
                UpdateSort(intMaxAgeMonthToEnroll, ctrl); // intMaxAgeMonthToEnroll
                UpdateSort(intCompletionDeadlineYear, ctrl); // intCompletionDeadlineYear
                UpdateSort(intCompletionDeadlineMonth, ctrl); // intCompletionDeadlineMonth
                UpdateSort(intCompletionDeadlineDay, ctrl); // intCompletionDeadlineDay
                UpdateSort(intCompletionDeadlineFrom, ctrl); // intCompletionDeadlineFrom
                UpdateSort(bit_IsTexable, ctrl); // bit_IsTexable
                UpdateSort(str_Base_price, ctrl); // str_Base_price
                UpdateSort(str_Tax, ctrl); // str_Tax
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
                    int_Package_Id.Sort = "";
                    str_Package_Name.Sort = "";
                    str_Package_Code.Sort = "";
                    int_Status.Sort = "";
                    str_Discount.Sort = "";
                    mny_Price.Sort = "";
                    str_Notes.Sort = "";
                    bit_IswebSignUp.Sort = "";
                    str_Items.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    bit_IsDeleted.Sort = "";
                    str_WebDescription.Sort = "";
                    bit_PortalPurchase.Sort = "";
                    str_WebName.Sort = "";
                    bit_ExtraChk1.Sort = "";
                    bit_ExtraChk2.Sort = "";
                    str_ExtraDrpDown1.Sort = "";
                    str_ExtraDrpDown2.Sort = "";
                    str_Extratxt1.Sort = "";
                    str_Extratxt2.Sort = "";
                    is_Show.Sort = "";
                    is_ShowGridColumn.Sort = "";
                    rowIndex.Sort = "";
                    bit_referral.Sort = "";
                    str_Locations.Sort = "";
                    str_PackageType.Sort = "";
                    int_ParentClass_Id.Sort = "";
                    str_CRcostHour.Sort = "";
                    str_BTWcostHour.Sort = "";
                    bit_OfferSpanishServices.Sort = "";
                    ByPassCRSelectionCentralizedOE.Sort = "";
                    str_WebNameArabic.Sort = "";
                    str_WebDescriptionArabic.Sort = "";
                    PackageContractType.Sort = "";
                    blob_path.Sort = "";
                    StudentSignXCordinate.Sort = "";
                    StudentSignYCordinate.Sort = "";
                    ParentSignXCordinate.Sort = "";
                    ParentSignYCordinate.Sort = "";
                    ParentSignPageNo.Sort = "";
                    StudentSignPageNo.Sort = "";
                    int_CDLProgramType.Sort = "";
                    int_CDLEndorsementCode.Sort = "";
                    int_CDLClassroom.Sort = "";
                    int_CDLRange.Sort = "";
                    int_CDLRoad.Sort = "";
                    bit_TPR_Package.Sort = "";
                    licenseTypeId.Sort = "";
                    bit_IsServiceForCertification.Sort = "";
                    intMinAgeYearToEnroll.Sort = "";
                    intMinAgeMonthToEnroll.Sort = "";
                    intMaxAgeYearToEnroll.Sort = "";
                    intMaxAgeMonthToEnroll.Sort = "";
                    intCompletionDeadlineYear.Sort = "";
                    intCompletionDeadlineMonth.Sort = "";
                    intCompletionDeadlineDay.Sort = "";
                    intCompletionDeadlineFrom.Sort = "";
                    bit_IsTexable.Sort = "";
                    str_Base_price.Sort = "";
                    str_Tax.Sort = "";
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblPackageInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblPackageInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblPackageInfolist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblPackageInfosrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblPackageInfosrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblPackageInfolist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                    RowAttrs.Add("id", "r0_tblPackageInfo");
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblPackageInfoList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblPackageInfoList.RowCount) + "_tblPackageInfo");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblPackageInfoList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblPackageInfoList.RowType == RowType.Add || IsEdit && tblPackageInfoList.RowType == RowType.Edit) // Inline-Add/Edit row
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
            int_Package_Id.SetDbValue(row["int_Package_Id"]);
            str_Package_Name.SetDbValue(row["str_Package_Name"]);
            str_Package_Code.SetDbValue(row["str_Package_Code"]);
            int_Status.SetDbValue(row["int_Status"]);
            str_Discount.SetDbValue(row["str_Discount"]);
            mny_Price.SetDbValue(row["mny_Price"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            bit_IswebSignUp.SetDbValue((ConvertToBool(row["bit_IswebSignUp"]) ? "1" : "0"));
            str_Items.SetDbValue(row["str_Items"]);
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_WebDescription.SetDbValue(row["str_WebDescription"]);
            bit_PortalPurchase.SetDbValue((ConvertToBool(row["bit_PortalPurchase"]) ? "1" : "0"));
            str_WebName.SetDbValue(row["str_WebName"]);
            bit_ExtraChk1.SetDbValue((ConvertToBool(row["bit_ExtraChk1"]) ? "1" : "0"));
            bit_ExtraChk2.SetDbValue((ConvertToBool(row["bit_ExtraChk2"]) ? "1" : "0"));
            str_ExtraDrpDown1.SetDbValue(row["str_ExtraDrpDown1"]);
            str_ExtraDrpDown2.SetDbValue(row["str_ExtraDrpDown2"]);
            str_Extratxt1.SetDbValue(row["str_Extratxt1"]);
            str_Extratxt2.SetDbValue(row["str_Extratxt2"]);
            is_Show.SetDbValue((ConvertToBool(row["is_Show"]) ? "1" : "0"));
            is_ShowGridColumn.SetDbValue((ConvertToBool(row["is_ShowGridColumn"]) ? "1" : "0"));
            rowIndex.SetDbValue(row["rowIndex"]);
            bit_referral.SetDbValue((ConvertToBool(row["bit_referral"]) ? "1" : "0"));
            str_Locations.SetDbValue(row["str_Locations"]);
            str_PackageType.SetDbValue(row["str_PackageType"]);
            int_ParentClass_Id.SetDbValue(row["int_ParentClass_Id"]);
            str_CRcostHour.SetDbValue(IsNull(row["str_CRcostHour"]) ? DbNullValue : ConvertToDouble(row["str_CRcostHour"]));
            str_BTWcostHour.SetDbValue(IsNull(row["str_BTWcostHour"]) ? DbNullValue : ConvertToDouble(row["str_BTWcostHour"]));
            bit_OfferSpanishServices.SetDbValue((ConvertToBool(row["bit_OfferSpanishServices"]) ? "1" : "0"));
            ByPassCRSelectionCentralizedOE.SetDbValue((ConvertToBool(row["ByPassCRSelectionCentralizedOE"]) ? "1" : "0"));
            str_WebNameArabic.SetDbValue(row["str_WebNameArabic"]);
            str_WebDescriptionArabic.SetDbValue(row["str_WebDescriptionArabic"]);
            PackageContractType.SetDbValue(row["PackageContractType"]);
            blob_path.SetDbValue(row["blob_path"]);
            StudentSignXCordinate.SetDbValue(row["StudentSignXCordinate"]);
            StudentSignYCordinate.SetDbValue(row["StudentSignYCordinate"]);
            ParentSignXCordinate.SetDbValue(row["ParentSignXCordinate"]);
            ParentSignYCordinate.SetDbValue(row["ParentSignYCordinate"]);
            ParentSignPageNo.SetDbValue(row["ParentSignPageNo"]);
            StudentSignPageNo.SetDbValue(row["StudentSignPageNo"]);
            int_CDLProgramType.SetDbValue(row["int_CDLProgramType"]);
            int_CDLEndorsementCode.SetDbValue(row["int_CDLEndorsementCode"]);
            int_CDLClassroom.SetDbValue(row["int_CDLClassroom"]);
            int_CDLRange.SetDbValue(row["int_CDLRange"]);
            int_CDLRoad.SetDbValue(row["int_CDLRoad"]);
            bit_TPR_Package.SetDbValue((ConvertToBool(row["bit_TPR_Package"]) ? "1" : "0"));
            licenseTypeId.SetDbValue(row["licenseTypeId"]);
            bit_IsServiceForCertification.SetDbValue((ConvertToBool(row["bit_IsServiceForCertification"]) ? "1" : "0"));
            intMinAgeYearToEnroll.SetDbValue(row["intMinAgeYearToEnroll"]);
            intMinAgeMonthToEnroll.SetDbValue(row["intMinAgeMonthToEnroll"]);
            intMaxAgeYearToEnroll.SetDbValue(row["intMaxAgeYearToEnroll"]);
            intMaxAgeMonthToEnroll.SetDbValue(row["intMaxAgeMonthToEnroll"]);
            intCompletionDeadlineYear.SetDbValue(row["intCompletionDeadlineYear"]);
            intCompletionDeadlineMonth.SetDbValue(row["intCompletionDeadlineMonth"]);
            intCompletionDeadlineDay.SetDbValue(row["intCompletionDeadlineDay"]);
            intCompletionDeadlineFrom.SetDbValue(row["intCompletionDeadlineFrom"]);
            bit_IsTexable.SetDbValue((ConvertToBool(row["bit_IsTexable"]) ? "1" : "0"));
            str_Base_price.SetDbValue(row["str_Base_price"]);
            str_Tax.SetDbValue(row["str_Tax"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Package_Id", int_Package_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Package_Name", str_Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Package_Code", str_Package_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Discount", str_Discount.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Price", mny_Price.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IswebSignUp", bit_IswebSignUp.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Items", str_Items.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebDescription", str_WebDescription.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_PortalPurchase", bit_PortalPurchase.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebName", str_WebName.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_ExtraChk1", bit_ExtraChk1.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_ExtraChk2", bit_ExtraChk2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ExtraDrpDown1", str_ExtraDrpDown1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ExtraDrpDown2", str_ExtraDrpDown2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Extratxt1", str_Extratxt1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Extratxt2", str_Extratxt2.DefaultValue ?? DbNullValue); // DN
            row.Add("is_Show", is_Show.DefaultValue ?? DbNullValue); // DN
            row.Add("is_ShowGridColumn", is_ShowGridColumn.DefaultValue ?? DbNullValue); // DN
            row.Add("rowIndex", rowIndex.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_referral", bit_referral.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Locations", str_Locations.DefaultValue ?? DbNullValue); // DN
            row.Add("str_PackageType", str_PackageType.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ParentClass_Id", int_ParentClass_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CRcostHour", str_CRcostHour.DefaultValue ?? DbNullValue); // DN
            row.Add("str_BTWcostHour", str_BTWcostHour.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_OfferSpanishServices", bit_OfferSpanishServices.DefaultValue ?? DbNullValue); // DN
            row.Add("ByPassCRSelectionCentralizedOE", ByPassCRSelectionCentralizedOE.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebNameArabic", str_WebNameArabic.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebDescriptionArabic", str_WebDescriptionArabic.DefaultValue ?? DbNullValue); // DN
            row.Add("PackageContractType", PackageContractType.DefaultValue ?? DbNullValue); // DN
            row.Add("blob_path", blob_path.DefaultValue ?? DbNullValue); // DN
            row.Add("StudentSignXCordinate", StudentSignXCordinate.DefaultValue ?? DbNullValue); // DN
            row.Add("StudentSignYCordinate", StudentSignYCordinate.DefaultValue ?? DbNullValue); // DN
            row.Add("ParentSignXCordinate", ParentSignXCordinate.DefaultValue ?? DbNullValue); // DN
            row.Add("ParentSignYCordinate", ParentSignYCordinate.DefaultValue ?? DbNullValue); // DN
            row.Add("ParentSignPageNo", ParentSignPageNo.DefaultValue ?? DbNullValue); // DN
            row.Add("StudentSignPageNo", StudentSignPageNo.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CDLProgramType", int_CDLProgramType.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CDLEndorsementCode", int_CDLEndorsementCode.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CDLClassroom", int_CDLClassroom.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CDLRange", int_CDLRange.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CDLRoad", int_CDLRoad.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_TPR_Package", bit_TPR_Package.DefaultValue ?? DbNullValue); // DN
            row.Add("licenseTypeId", licenseTypeId.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsServiceForCertification", bit_IsServiceForCertification.DefaultValue ?? DbNullValue); // DN
            row.Add("intMinAgeYearToEnroll", intMinAgeYearToEnroll.DefaultValue ?? DbNullValue); // DN
            row.Add("intMinAgeMonthToEnroll", intMinAgeMonthToEnroll.DefaultValue ?? DbNullValue); // DN
            row.Add("intMaxAgeYearToEnroll", intMaxAgeYearToEnroll.DefaultValue ?? DbNullValue); // DN
            row.Add("intMaxAgeMonthToEnroll", intMaxAgeMonthToEnroll.DefaultValue ?? DbNullValue); // DN
            row.Add("intCompletionDeadlineYear", intCompletionDeadlineYear.DefaultValue ?? DbNullValue); // DN
            row.Add("intCompletionDeadlineMonth", intCompletionDeadlineMonth.DefaultValue ?? DbNullValue); // DN
            row.Add("intCompletionDeadlineDay", intCompletionDeadlineDay.DefaultValue ?? DbNullValue); // DN
            row.Add("intCompletionDeadlineFrom", intCompletionDeadlineFrom.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsTexable", bit_IsTexable.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Base_price", str_Base_price.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Tax", str_Tax.DefaultValue ?? DbNullValue); // DN
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

            // int_Package_Id

            // str_Package_Name

            // str_Package_Code

            // int_Status

            // str_Discount

            // mny_Price

            // str_Notes

            // bit_IswebSignUp

            // str_Items

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // str_WebDescription

            // bit_PortalPurchase

            // str_WebName

            // bit_ExtraChk1

            // bit_ExtraChk2

            // str_ExtraDrpDown1

            // str_ExtraDrpDown2

            // str_Extratxt1

            // str_Extratxt2

            // is_Show

            // is_ShowGridColumn

            // rowIndex

            // bit_referral

            // str_Locations

            // str_PackageType

            // int_ParentClass_Id

            // str_CRcostHour

            // str_BTWcostHour

            // bit_OfferSpanishServices

            // ByPassCRSelectionCentralizedOE

            // str_WebNameArabic

            // str_WebDescriptionArabic

            // PackageContractType

            // blob_path

            // StudentSignXCordinate

            // StudentSignYCordinate

            // ParentSignXCordinate

            // ParentSignYCordinate

            // ParentSignPageNo

            // StudentSignPageNo

            // int_CDLProgramType

            // int_CDLEndorsementCode

            // int_CDLClassroom

            // int_CDLRange

            // int_CDLRoad

            // bit_TPR_Package

            // licenseTypeId

            // bit_IsServiceForCertification

            // intMinAgeYearToEnroll

            // intMinAgeMonthToEnroll

            // intMaxAgeYearToEnroll

            // intMaxAgeMonthToEnroll

            // intCompletionDeadlineYear

            // intCompletionDeadlineMonth

            // intCompletionDeadlineDay

            // intCompletionDeadlineFrom

            // bit_IsTexable

            // str_Base_price

            // str_Tax

            // View row
            if (RowType == RowType.View) {
                // int_Package_Id
                int_Package_Id.ViewValue = int_Package_Id.CurrentValue;
                int_Package_Id.ViewValue = FormatNumber(int_Package_Id.ViewValue, int_Package_Id.FormatPattern);
                int_Package_Id.ViewCustomAttributes = "";

                // str_Package_Name
                str_Package_Name.ViewValue = ConvertToString(str_Package_Name.CurrentValue); // DN
                str_Package_Name.ViewCustomAttributes = "";

                // str_Package_Code
                str_Package_Code.ViewValue = ConvertToString(str_Package_Code.CurrentValue); // DN
                str_Package_Code.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // str_Discount
                str_Discount.ViewValue = ConvertToString(str_Discount.CurrentValue); // DN
                str_Discount.ViewCustomAttributes = "";

                // mny_Price
                mny_Price.ViewValue = mny_Price.CurrentValue;
                mny_Price.ViewValue = FormatNumber(mny_Price.ViewValue, mny_Price.FormatPattern);
                mny_Price.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // bit_IswebSignUp
                if (ConvertToBool(bit_IswebSignUp.CurrentValue)) {
                    bit_IswebSignUp.ViewValue = bit_IswebSignUp.TagCaption(1) != "" ? bit_IswebSignUp.TagCaption(1) : "Yes";
                } else {
                    bit_IswebSignUp.ViewValue = bit_IswebSignUp.TagCaption(2) != "" ? bit_IswebSignUp.TagCaption(2) : "No";
                }
                bit_IswebSignUp.ViewCustomAttributes = "";

                // str_Items
                str_Items.ViewValue = ConvertToString(str_Items.CurrentValue); // DN
                str_Items.ViewCustomAttributes = "";

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

                // bit_referral
                if (ConvertToBool(bit_referral.CurrentValue)) {
                    bit_referral.ViewValue = bit_referral.TagCaption(1) != "" ? bit_referral.TagCaption(1) : "Yes";
                } else {
                    bit_referral.ViewValue = bit_referral.TagCaption(2) != "" ? bit_referral.TagCaption(2) : "No";
                }
                bit_referral.ViewCustomAttributes = "";

                // str_PackageType
                str_PackageType.ViewValue = ConvertToString(str_PackageType.CurrentValue); // DN
                str_PackageType.ViewCustomAttributes = "";

                // int_ParentClass_Id
                int_ParentClass_Id.ViewValue = int_ParentClass_Id.CurrentValue;
                int_ParentClass_Id.ViewValue = FormatNumber(int_ParentClass_Id.ViewValue, int_ParentClass_Id.FormatPattern);
                int_ParentClass_Id.ViewCustomAttributes = "";

                // str_CRcostHour
                str_CRcostHour.ViewValue = str_CRcostHour.CurrentValue;
                str_CRcostHour.ViewValue = FormatNumber(str_CRcostHour.ViewValue, str_CRcostHour.FormatPattern);
                str_CRcostHour.ViewCustomAttributes = "";

                // str_BTWcostHour
                str_BTWcostHour.ViewValue = str_BTWcostHour.CurrentValue;
                str_BTWcostHour.ViewValue = FormatNumber(str_BTWcostHour.ViewValue, str_BTWcostHour.FormatPattern);
                str_BTWcostHour.ViewCustomAttributes = "";

                // bit_OfferSpanishServices
                if (ConvertToBool(bit_OfferSpanishServices.CurrentValue)) {
                    bit_OfferSpanishServices.ViewValue = bit_OfferSpanishServices.TagCaption(1) != "" ? bit_OfferSpanishServices.TagCaption(1) : "Yes";
                } else {
                    bit_OfferSpanishServices.ViewValue = bit_OfferSpanishServices.TagCaption(2) != "" ? bit_OfferSpanishServices.TagCaption(2) : "No";
                }
                bit_OfferSpanishServices.ViewCustomAttributes = "";

                // ByPassCRSelectionCentralizedOE
                if (ConvertToBool(ByPassCRSelectionCentralizedOE.CurrentValue)) {
                    ByPassCRSelectionCentralizedOE.ViewValue = ByPassCRSelectionCentralizedOE.TagCaption(1) != "" ? ByPassCRSelectionCentralizedOE.TagCaption(1) : "Yes";
                } else {
                    ByPassCRSelectionCentralizedOE.ViewValue = ByPassCRSelectionCentralizedOE.TagCaption(2) != "" ? ByPassCRSelectionCentralizedOE.TagCaption(2) : "No";
                }
                ByPassCRSelectionCentralizedOE.ViewCustomAttributes = "";

                // str_WebNameArabic
                str_WebNameArabic.ViewValue = ConvertToString(str_WebNameArabic.CurrentValue); // DN
                str_WebNameArabic.ViewCustomAttributes = "";

                // PackageContractType
                PackageContractType.ViewValue = PackageContractType.CurrentValue;
                PackageContractType.ViewValue = FormatNumber(PackageContractType.ViewValue, PackageContractType.FormatPattern);
                PackageContractType.ViewCustomAttributes = "";

                // StudentSignXCordinate
                StudentSignXCordinate.ViewValue = StudentSignXCordinate.CurrentValue;
                StudentSignXCordinate.ViewValue = FormatNumber(StudentSignXCordinate.ViewValue, StudentSignXCordinate.FormatPattern);
                StudentSignXCordinate.ViewCustomAttributes = "";

                // StudentSignYCordinate
                StudentSignYCordinate.ViewValue = StudentSignYCordinate.CurrentValue;
                StudentSignYCordinate.ViewValue = FormatNumber(StudentSignYCordinate.ViewValue, StudentSignYCordinate.FormatPattern);
                StudentSignYCordinate.ViewCustomAttributes = "";

                // ParentSignXCordinate
                ParentSignXCordinate.ViewValue = ParentSignXCordinate.CurrentValue;
                ParentSignXCordinate.ViewValue = FormatNumber(ParentSignXCordinate.ViewValue, ParentSignXCordinate.FormatPattern);
                ParentSignXCordinate.ViewCustomAttributes = "";

                // ParentSignYCordinate
                ParentSignYCordinate.ViewValue = ParentSignYCordinate.CurrentValue;
                ParentSignYCordinate.ViewValue = FormatNumber(ParentSignYCordinate.ViewValue, ParentSignYCordinate.FormatPattern);
                ParentSignYCordinate.ViewCustomAttributes = "";

                // ParentSignPageNo
                ParentSignPageNo.ViewValue = ParentSignPageNo.CurrentValue;
                ParentSignPageNo.ViewValue = FormatNumber(ParentSignPageNo.ViewValue, ParentSignPageNo.FormatPattern);
                ParentSignPageNo.ViewCustomAttributes = "";

                // StudentSignPageNo
                StudentSignPageNo.ViewValue = StudentSignPageNo.CurrentValue;
                StudentSignPageNo.ViewValue = FormatNumber(StudentSignPageNo.ViewValue, StudentSignPageNo.FormatPattern);
                StudentSignPageNo.ViewCustomAttributes = "";

                // int_CDLProgramType
                int_CDLProgramType.ViewValue = int_CDLProgramType.CurrentValue;
                int_CDLProgramType.ViewValue = FormatNumber(int_CDLProgramType.ViewValue, int_CDLProgramType.FormatPattern);
                int_CDLProgramType.ViewCustomAttributes = "";

                // int_CDLEndorsementCode
                int_CDLEndorsementCode.ViewValue = int_CDLEndorsementCode.CurrentValue;
                int_CDLEndorsementCode.ViewValue = FormatNumber(int_CDLEndorsementCode.ViewValue, int_CDLEndorsementCode.FormatPattern);
                int_CDLEndorsementCode.ViewCustomAttributes = "";

                // int_CDLClassroom
                int_CDLClassroom.ViewValue = int_CDLClassroom.CurrentValue;
                int_CDLClassroom.ViewValue = FormatNumber(int_CDLClassroom.ViewValue, int_CDLClassroom.FormatPattern);
                int_CDLClassroom.ViewCustomAttributes = "";

                // int_CDLRange
                int_CDLRange.ViewValue = int_CDLRange.CurrentValue;
                int_CDLRange.ViewValue = FormatNumber(int_CDLRange.ViewValue, int_CDLRange.FormatPattern);
                int_CDLRange.ViewCustomAttributes = "";

                // int_CDLRoad
                int_CDLRoad.ViewValue = int_CDLRoad.CurrentValue;
                int_CDLRoad.ViewValue = FormatNumber(int_CDLRoad.ViewValue, int_CDLRoad.FormatPattern);
                int_CDLRoad.ViewCustomAttributes = "";

                // bit_TPR_Package
                if (ConvertToBool(bit_TPR_Package.CurrentValue)) {
                    bit_TPR_Package.ViewValue = bit_TPR_Package.TagCaption(1) != "" ? bit_TPR_Package.TagCaption(1) : "Yes";
                } else {
                    bit_TPR_Package.ViewValue = bit_TPR_Package.TagCaption(2) != "" ? bit_TPR_Package.TagCaption(2) : "No";
                }
                bit_TPR_Package.ViewCustomAttributes = "";

                // licenseTypeId
                licenseTypeId.ViewValue = licenseTypeId.CurrentValue;
                licenseTypeId.ViewValue = FormatNumber(licenseTypeId.ViewValue, licenseTypeId.FormatPattern);
                licenseTypeId.ViewCustomAttributes = "";

                // bit_IsServiceForCertification
                if (ConvertToBool(bit_IsServiceForCertification.CurrentValue)) {
                    bit_IsServiceForCertification.ViewValue = bit_IsServiceForCertification.TagCaption(1) != "" ? bit_IsServiceForCertification.TagCaption(1) : "Yes";
                } else {
                    bit_IsServiceForCertification.ViewValue = bit_IsServiceForCertification.TagCaption(2) != "" ? bit_IsServiceForCertification.TagCaption(2) : "No";
                }
                bit_IsServiceForCertification.ViewCustomAttributes = "";

                // intMinAgeYearToEnroll
                intMinAgeYearToEnroll.ViewValue = ConvertToString(intMinAgeYearToEnroll.CurrentValue); // DN
                intMinAgeYearToEnroll.ViewCustomAttributes = "";

                // intMinAgeMonthToEnroll
                intMinAgeMonthToEnroll.ViewValue = ConvertToString(intMinAgeMonthToEnroll.CurrentValue); // DN
                intMinAgeMonthToEnroll.ViewCustomAttributes = "";

                // intMaxAgeYearToEnroll
                intMaxAgeYearToEnroll.ViewValue = ConvertToString(intMaxAgeYearToEnroll.CurrentValue); // DN
                intMaxAgeYearToEnroll.ViewCustomAttributes = "";

                // intMaxAgeMonthToEnroll
                intMaxAgeMonthToEnroll.ViewValue = ConvertToString(intMaxAgeMonthToEnroll.CurrentValue); // DN
                intMaxAgeMonthToEnroll.ViewCustomAttributes = "";

                // intCompletionDeadlineYear
                intCompletionDeadlineYear.ViewValue = ConvertToString(intCompletionDeadlineYear.CurrentValue); // DN
                intCompletionDeadlineYear.ViewCustomAttributes = "";

                // intCompletionDeadlineMonth
                intCompletionDeadlineMonth.ViewValue = ConvertToString(intCompletionDeadlineMonth.CurrentValue); // DN
                intCompletionDeadlineMonth.ViewCustomAttributes = "";

                // intCompletionDeadlineDay
                intCompletionDeadlineDay.ViewValue = ConvertToString(intCompletionDeadlineDay.CurrentValue); // DN
                intCompletionDeadlineDay.ViewCustomAttributes = "";

                // intCompletionDeadlineFrom
                intCompletionDeadlineFrom.ViewValue = ConvertToString(intCompletionDeadlineFrom.CurrentValue); // DN
                intCompletionDeadlineFrom.ViewCustomAttributes = "";

                // bit_IsTexable
                if (ConvertToBool(bit_IsTexable.CurrentValue)) {
                    bit_IsTexable.ViewValue = bit_IsTexable.TagCaption(1) != "" ? bit_IsTexable.TagCaption(1) : "Yes";
                } else {
                    bit_IsTexable.ViewValue = bit_IsTexable.TagCaption(2) != "" ? bit_IsTexable.TagCaption(2) : "No";
                }
                bit_IsTexable.ViewCustomAttributes = "";

                // str_Base_price
                str_Base_price.ViewValue = ConvertToString(str_Base_price.CurrentValue); // DN
                str_Base_price.ViewCustomAttributes = "";

                // str_Tax
                str_Tax.ViewValue = ConvertToString(str_Tax.CurrentValue); // DN
                str_Tax.ViewCustomAttributes = "";

                // int_Package_Id
                int_Package_Id.HrefValue = "";
                int_Package_Id.TooltipValue = "";

                // str_Package_Name
                str_Package_Name.HrefValue = "";
                str_Package_Name.TooltipValue = "";

                // str_Package_Code
                str_Package_Code.HrefValue = "";
                str_Package_Code.TooltipValue = "";

                // int_Status
                int_Status.HrefValue = "";
                int_Status.TooltipValue = "";

                // str_Discount
                str_Discount.HrefValue = "";
                str_Discount.TooltipValue = "";

                // mny_Price
                mny_Price.HrefValue = "";
                mny_Price.TooltipValue = "";

                // str_Notes
                str_Notes.HrefValue = "";
                str_Notes.TooltipValue = "";

                // bit_IswebSignUp
                bit_IswebSignUp.HrefValue = "";
                bit_IswebSignUp.TooltipValue = "";

                // str_Items
                str_Items.HrefValue = "";
                str_Items.TooltipValue = "";

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

                // is_Show
                is_Show.HrefValue = "";
                is_Show.TooltipValue = "";

                // is_ShowGridColumn
                is_ShowGridColumn.HrefValue = "";
                is_ShowGridColumn.TooltipValue = "";

                // rowIndex
                rowIndex.HrefValue = "";
                rowIndex.TooltipValue = "";

                // bit_referral
                bit_referral.HrefValue = "";
                bit_referral.TooltipValue = "";

                // str_PackageType
                str_PackageType.HrefValue = "";
                str_PackageType.TooltipValue = "";

                // int_ParentClass_Id
                int_ParentClass_Id.HrefValue = "";
                int_ParentClass_Id.TooltipValue = "";

                // str_CRcostHour
                str_CRcostHour.HrefValue = "";
                str_CRcostHour.TooltipValue = "";

                // str_BTWcostHour
                str_BTWcostHour.HrefValue = "";
                str_BTWcostHour.TooltipValue = "";

                // bit_OfferSpanishServices
                bit_OfferSpanishServices.HrefValue = "";
                bit_OfferSpanishServices.TooltipValue = "";

                // ByPassCRSelectionCentralizedOE
                ByPassCRSelectionCentralizedOE.HrefValue = "";
                ByPassCRSelectionCentralizedOE.TooltipValue = "";

                // str_WebNameArabic
                str_WebNameArabic.HrefValue = "";
                str_WebNameArabic.TooltipValue = "";

                // PackageContractType
                PackageContractType.HrefValue = "";
                PackageContractType.TooltipValue = "";

                // StudentSignXCordinate
                StudentSignXCordinate.HrefValue = "";
                StudentSignXCordinate.TooltipValue = "";

                // StudentSignYCordinate
                StudentSignYCordinate.HrefValue = "";
                StudentSignYCordinate.TooltipValue = "";

                // ParentSignXCordinate
                ParentSignXCordinate.HrefValue = "";
                ParentSignXCordinate.TooltipValue = "";

                // ParentSignYCordinate
                ParentSignYCordinate.HrefValue = "";
                ParentSignYCordinate.TooltipValue = "";

                // ParentSignPageNo
                ParentSignPageNo.HrefValue = "";
                ParentSignPageNo.TooltipValue = "";

                // StudentSignPageNo
                StudentSignPageNo.HrefValue = "";
                StudentSignPageNo.TooltipValue = "";

                // int_CDLProgramType
                int_CDLProgramType.HrefValue = "";
                int_CDLProgramType.TooltipValue = "";

                // int_CDLEndorsementCode
                int_CDLEndorsementCode.HrefValue = "";
                int_CDLEndorsementCode.TooltipValue = "";

                // int_CDLClassroom
                int_CDLClassroom.HrefValue = "";
                int_CDLClassroom.TooltipValue = "";

                // int_CDLRange
                int_CDLRange.HrefValue = "";
                int_CDLRange.TooltipValue = "";

                // int_CDLRoad
                int_CDLRoad.HrefValue = "";
                int_CDLRoad.TooltipValue = "";

                // bit_TPR_Package
                bit_TPR_Package.HrefValue = "";
                bit_TPR_Package.TooltipValue = "";

                // licenseTypeId
                licenseTypeId.HrefValue = "";
                licenseTypeId.TooltipValue = "";

                // bit_IsServiceForCertification
                bit_IsServiceForCertification.HrefValue = "";
                bit_IsServiceForCertification.TooltipValue = "";

                // intMinAgeYearToEnroll
                intMinAgeYearToEnroll.HrefValue = "";
                intMinAgeYearToEnroll.TooltipValue = "";

                // intMinAgeMonthToEnroll
                intMinAgeMonthToEnroll.HrefValue = "";
                intMinAgeMonthToEnroll.TooltipValue = "";

                // intMaxAgeYearToEnroll
                intMaxAgeYearToEnroll.HrefValue = "";
                intMaxAgeYearToEnroll.TooltipValue = "";

                // intMaxAgeMonthToEnroll
                intMaxAgeMonthToEnroll.HrefValue = "";
                intMaxAgeMonthToEnroll.TooltipValue = "";

                // intCompletionDeadlineYear
                intCompletionDeadlineYear.HrefValue = "";
                intCompletionDeadlineYear.TooltipValue = "";

                // intCompletionDeadlineMonth
                intCompletionDeadlineMonth.HrefValue = "";
                intCompletionDeadlineMonth.TooltipValue = "";

                // intCompletionDeadlineDay
                intCompletionDeadlineDay.HrefValue = "";
                intCompletionDeadlineDay.TooltipValue = "";

                // intCompletionDeadlineFrom
                intCompletionDeadlineFrom.HrefValue = "";
                intCompletionDeadlineFrom.TooltipValue = "";

                // bit_IsTexable
                bit_IsTexable.HrefValue = "";
                bit_IsTexable.TooltipValue = "";

                // str_Base_price
                str_Base_price.HrefValue = "";
                str_Base_price.TooltipValue = "";

                // str_Tax
                str_Tax.HrefValue = "";
                str_Tax.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblPackageInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblPackageInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblPackageInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblPackageInfolist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblPackageInfosrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
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
