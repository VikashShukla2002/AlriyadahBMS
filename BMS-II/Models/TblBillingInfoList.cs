namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblBillingInfoList
    /// </summary>
    public static TblBillingInfoList tblBillingInfoList
    {
        get => HttpData.Get<TblBillingInfoList>("tblBillingInfoList")!;
        set => HttpData["tblBillingInfoList"] = value;
    }

    /// <summary>
    /// Page class for tblBillingInfo
    /// </summary>
    public class TblBillingInfoList : TblBillingInfoListBase
    {
        // Constructor
        public TblBillingInfoList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblBillingInfoList() : base()
        {
        }

        // Page Load event
        public override void PageLoad() {
        //UPD_Package_Name;
            string sUpdateSq24 = "UPD_Package_Name";
        Execute (sUpdateSq24); 

        //UPD_BILL_RB;
            string sUpdateSq241 = "UPD_BILL_RB";
        Execute (sUpdateSq241); 

        //UPD_BILL_Pricelist;
            string sUpdateSq242 = "UPD_BILL_PriceList";
        Execute (sUpdateSq242);

        //UPD_BILL_Names;
            string sUpdateSq245 = "UPD_BILL_Names";
        Execute (sUpdateSq245);
        }

        // Page Data Rendering event
        public override void PageDataRendering(ref string header) {
            header = $"<p class='text-end'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{CurrentUserName()}</span></p>";
        }
        // Page Data Rendered event
        public override void PageDataRendered(ref string footer) {
            footer = $"<p class='text-start'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{GetCurrentUserLevelName()}</span></p>";
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblBillingInfoListBase : TblBillingInfo
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblBillingInfo";

        // Page object name
        public string PageObjName = "tblBillingInfoList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblBillingInfolist";

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
        public TblBillingInfoListBase()
        {
            // CSS class name as context
            TableVar = "tblBillingInfo";
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

            // Table object (tblBillingInfo)
            if (tblBillingInfo == null || tblBillingInfo is TblBillingInfo)
                tblBillingInfo = this;

            // Initialize URLs
            AddUrl = "TblBillingInfoAdd?" + Config.TableShowDetail + "=";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblBillingInfoDelete";
            MultiUpdateUrl = "TblBillingInfoUpdate";

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
        public string PageName => "TblBillingInfoList";

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
            int_Bill_ID.Visible = false;
            NationalID.SetVisibility();
            str_First_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Username.Visible = false;
            int_Student_ID.Visible = false;
            int_Payment_Method.Visible = false;
            date_Paid.SetVisibility();
            str_ApprovalCode.SetVisibility();
            Payment_Number.SetVisibility();
            Pricelist.SetVisibility();
            date_Created.Visible = false;
            str_Amount.Visible = false;
            str_CC_Holder_Name.Visible = false;
            str_CC_Number.Visible = false;
            int_CC_ExpMonth.Visible = false;
            int_CC_ExpYear.Visible = false;
            int_CC_Type.Visible = false;
            str_Card_Id.Visible = false;
            str_CC_ValidationNum.Visible = false;
            str_reference.Visible = false;
            str_Amount_Pay.SetVisibility();
            mny_Running_Payments.SetVisibility();
            mny_Running_Balance.SetVisibility();
            str_Payment_Reference.Visible = false;
            int_Accepted_By.Visible = false;
            str_Check_Number.Visible = false;
            bit_Is_Check_Deposited.Visible = false;
            str_Adjustment_Type.Visible = false;
            str_Adjust_Sub_Type.Visible = false;
            bit_Archive.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            date_Modified.Visible = false;
            bit_IsDeleted.Visible = false;
            str_CardHolder_Address.Visible = false;
            str_CH_City.Visible = false;
            str_CH_Zip.Visible = false;
            int_State.Visible = false;
            bit_IsAuthDotNet.Visible = false;
            bit_IsRefund.Visible = false;
            str_Receipt.Visible = false;
            str_TransactionNumber.Visible = false;
            str_OrderId.Visible = false;
            str_TransactionTime.Visible = false;
            int_Location_Id.Visible = false;
            str_Enrollment_Id.Visible = false;
            str_Notes.Visible = false;
            str_Payment_Note.Visible = false;
            int_Package_ID.Visible = false;
            Package_Name.Visible = false;
            Price.Visible = false;
            AssessmentID.Visible = false;
            course.Visible = false;
            institution.Visible = false;
            UniqueIdx.Visible = false;
        }

        // Constructor
        public TblBillingInfoListBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblBillingInfoView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Bill_ID") ? dict["int_Bill_ID"] : int_Bill_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Bill_ID.Visible = false;
            if (IsAddOrEdit)
                date_Created.Visible = false;
            if (IsAddOrEdit)
                int_Accepted_By.Visible = false;
            if (IsAddOrEdit)
                int_Modified_By.Visible = false;
            if (IsAddOrEdit)
                date_Modified.Visible = false;
            if (IsAddOrEdit)
                str_TransactionTime.Visible = false;
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

            // Set up master detail parameters
            SetupMasterParms();

            // Setup other options
            SetupOtherOptions();

            // Set up custom action (compatible with old version)
            ListActions.Add(CustomActions);

            // Set up lookup cache
            await SetupLookupOptions(NationalID);
            await SetupLookupOptions(str_Username);
            await SetupLookupOptions(int_Student_ID);
            await SetupLookupOptions(int_Payment_Method);
            await SetupLookupOptions(bit_Is_Check_Deposited);
            await SetupLookupOptions(bit_Archive);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_IsAuthDotNet);
            await SetupLookupOptions(bit_IsRefund);
            await SetupLookupOptions(int_Package_ID);
            await SetupLookupOptions(Package_Name);
            await SetupLookupOptions(Price);

            // Load default values for add
            LoadDefaultValues();

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblBillingInfogrid";

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
                }
            }

            // Clear inline mode
            if (IsCancel)
                ClearInlineMode();

            // Switch to grid add mode
            if (IsGridAdd) {
                GridAddMode();
            // Grid Insert
            } else if (IsPost() && IsGridInsert && SameString(Session[Config.SessionInlineMode], "gridadd")) {
                var gridInsert = false;
                if (await ValidateGridForm())
                    gridInsert = await GridInsert();
                if (gridInsert) {
                    // Handle modal grid add, redirect to list page directly
                    if (IsModal && !UseAjaxActions)
                        return Terminate("TblBillingInfoList");
                } else {
                    EventCancelled = true;
                    if (UseAjaxActions) {
                        if (IsModal)
                            AddHeader("Modal-Error", "?1");
                        else
                            return Controller.Json(new { success = false, error = GetFailureMessage() });
                    }
                    GridAddMode(); // Stay in grid add mode
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

            // Restore master/detail filter from session
            DbMasterFilter = MasterFilterFromSession;
            DbDetailFilter = DetailFilterFromSession;

            // Add master User ID filter
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin) { // Non system admin
                if (CurrentMasterTable == "tblPotentialStudentInfo")
                    DbMasterFilter = AddMasterUserIDFilter(DbMasterFilter, "tblPotentialStudentInfo"); // Add master User ID filter
            }
            AddFilter(ref filter, DbDetailFilter);
            AddFilter(ref filter, SearchWhere);

            // Load master record
            if (CurrentMode != "add" && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblPotentialStudentInfo") {
                tblPotentialStudentInfo = Resolve("tblPotentialStudentInfo")!;
                if (tblPotentialStudentInfo != null) {
                    using (var rsmaster = await tblPotentialStudentInfo.LoadReader(DbMasterFilter)) { // Note: Use {}
                        MasterRecordExists = rsmaster != null && await rsmaster.ReadAsync();
                        if (!MasterRecordExists) {
                            FailureMessage = Language.Phrase("NoRecord"); // Set no record found
                            return Terminate("TblPotentialStudentInfoList"); // Return to master page
                        } else {
                            tblPotentialStudentInfo.LoadListRowValues(rsmaster);
                        }
                    }
                    tblPotentialStudentInfo.RowType = RowType.Master; // Master row
                    await tblPotentialStudentInfo.RenderListRow(); // Note: Do it outside "using" // DN
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
                tblBillingInfoList?.PageRender();
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
            Pricelist.SetFormValue("", false); // Clear form value
            mny_Running_Payments.SetFormValue("", false); // Clear form value
            mny_Running_Balance.SetFormValue("", false); // Clear form value
            LastAction = CurrentAction; // Save last action
            CurrentAction = ""; // Clear action
            Session[Config.SessionInlineMode] = ""; // Clear inline mode
        }

        // Switch to grid add mode
        protected void GridAddMode() {
            CurrentAction = "gridadd";
            Session[Config.SessionInlineMode] = "gridadd"; // Enabled grid add
            HideFieldsForAddEdit();
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

        // Perform Grid Add
        #pragma warning disable 168, 219

        public async Task<bool> GridInsert()
        {
            int addcnt = 0;
            bool gridInsert = false;

            // Call Grid Inserting event
            if (!GridInserting()) {
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("GridAddCancelled"); // Set grid add cancelled message
                EventCancelled = true;
                return false;
            }

            // Begin transaction
            if (UseTransaction)
                Connection.BeginTrans();

            // Init key filter
            string wrkFilter = "";
            if (AuditTrailOnAdd)
                await WriteAuditTrailLog(Language.Phrase("BatchInsertBegin")); // Batch insert begin
            string key = "";

            // Get row count
            CurrentForm?.ResetIndex();
            int rowcnt = CurrentForm?.GetInt(FormKeyCountName) ?? 0;

            // Load default values for emptyRow checking // DN
            LoadDefaultValues();

            // Insert all rows
            try {
                for (int rowindex = 1; rowindex <= rowcnt; rowindex++) {
                    // Load current row values
                    CurrentForm!.Index = rowindex;
                    string rowaction = CurrentForm.GetValue(FormActionName);
                    Dictionary<string, object>? rsold = null;
                    if (!Empty(rowaction) && rowaction != "insert")
                        continue; // Skip
                    if (rowaction == "insert") {
                        OldKey = CurrentForm.GetValue(OldKeyName);
                        rsold = await LoadOldRecord(); // Load old record
                    }
                    await LoadFormValues(); // Get form values
                    if (!EmptyRow()) {
                        addcnt++;
                        SendEmail = false; // Do not send email on insert success
                        gridInsert = await AddRow(rsold); // Insert row (already validated by validateGridForm())
                        if (gridInsert) {
                            if (!Empty(key))
                                key += Config.CompositeKeySeparator;
                            key += ConvertToString(int_Bill_ID.CurrentValue);

                            // Add filter for this record
                            AddFilter(ref wrkFilter, GetRecordFilter(), "OR");
                        } else {
                            EventCancelled = true;
                            break;
                        }
                    }
                }
                if (addcnt == 0) { // No record inserted
                    FailureMessage = Language.Phrase("NoAddRecord");
                    gridInsert = false;
                }
            } catch (Exception e) {
                FailureMessage = e.Message;
                gridInsert = false;
            }
            if (gridInsert) {
                if (UseTransaction)
                    Connection.CommitTrans(); // Commit transaction

                // Get new recordset
                CurrentFilter = wrkFilter;
                FilterForModalActions = wrkFilter;
                string sql = CurrentSql;
                List<Dictionary<string, object>> rsnew = await Connection.GetRowsAsync(sql, true); // Use main connection (faster) // DN

                // Call Grid Inserted event
                GridInserted(rsnew);
                if (AuditTrailOnAdd)
                    await WriteAuditTrailLog(Language.Phrase("BatchInsertSuccess")); // Batch insert success
                if (Empty(SuccessMessage))
                    SuccessMessage = Language.Phrase("InsertSuccess"); // Set up insert success message
                ClearInlineMode(); // Clear grid add mode

                // Send notify email
                string table = "tblBillingInfo";
                string subject = table + " " + Language.Phrase("RecordInserted");
                string action = Language.Phrase("ActionInsertedGridAdd");
                var email = new Email();
                await email.Load(Config.EmailNotifyTemplate);
                email.ReplaceSender(Config.SenderEmail); // Replace Sender
                email.ReplaceRecipient(Config.RecipientEmail); // Replace Recipient
                email.ReplaceSubject(subject); // Replace Subject
                email.ReplaceContent("<!--table-->", table);
                email.ReplaceContent("<!--key-->", key);
                email.ReplaceContent("<!--action-->", action);
                bool emailSent = false;
                if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsnew = rsnew })))
                    emailSent = await email.SendAsync();
                if (!emailSent)
                    FailureMessage = email.SendError;
            } else {
                if (UseTransaction)
                    Connection.RollbackTrans(); // Rollback transaction
                if (AuditTrailOnAdd)
                    await WriteAuditTrailLog(Language.Phrase("BatchInsertRollback")); // Batch insert rollback
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("InsertFailed"); // Set insert failed message
            }
            return gridInsert;
        }
        #pragma warning restore 168, 219

        // Check if empty row
        public bool EmptyRow()
        {
            if (CurrentForm == null)
                return true;
            if (CurrentForm.HasValue("x_NationalID") && CurrentForm.HasValue("o_NationalID") && !SameString(NationalID.CurrentValue, NationalID.DefaultValue) &&
            !(NationalID.IsForeignKey && CurrentMasterTable != "" && SameString(NationalID.CurrentValue, NationalID.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_First_Name") && CurrentForm.HasValue("o_str_First_Name") && !SameString(str_First_Name.CurrentValue, str_First_Name.DefaultValue) &&
            !(str_First_Name.IsForeignKey && CurrentMasterTable != "" && SameString(str_First_Name.CurrentValue, str_First_Name.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Last_Name") && CurrentForm.HasValue("o_str_Last_Name") && !SameString(str_Last_Name.CurrentValue, str_Last_Name.DefaultValue) &&
            !(str_Last_Name.IsForeignKey && CurrentMasterTable != "" && SameString(str_Last_Name.CurrentValue, str_Last_Name.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_date_Paid") && CurrentForm.HasValue("o_date_Paid") && !SameString(FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), FormatDateTime(date_Paid.DefaultValue, date_Paid.FormatPattern)) &&
            !(date_Paid.IsForeignKey && CurrentMasterTable != "" && SameString(FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), FormatDateTime(date_Paid.SessionValue, date_Paid.FormatPattern))))
                return false;
            if (CurrentForm.HasValue("x_str_ApprovalCode") && CurrentForm.HasValue("o_str_ApprovalCode") && !SameString(str_ApprovalCode.CurrentValue, str_ApprovalCode.DefaultValue) &&
            !(str_ApprovalCode.IsForeignKey && CurrentMasterTable != "" && SameString(str_ApprovalCode.CurrentValue, str_ApprovalCode.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_Payment_Number") && CurrentForm.HasValue("o_Payment_Number") && !SameString(Payment_Number.CurrentValue, Payment_Number.DefaultValue) &&
            !(Payment_Number.IsForeignKey && CurrentMasterTable != "" && SameString(Payment_Number.CurrentValue, Payment_Number.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_Pricelist") && CurrentForm.HasValue("o_Pricelist") && !SameString(Pricelist.CurrentValue, Pricelist.DefaultValue) &&
            !(Pricelist.IsForeignKey && CurrentMasterTable != "" && SameString(Pricelist.CurrentValue, Pricelist.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Amount_Pay") && CurrentForm.HasValue("o_str_Amount_Pay") && !SameString(str_Amount_Pay.CurrentValue, str_Amount_Pay.DefaultValue) &&
            !(str_Amount_Pay.IsForeignKey && CurrentMasterTable != "" && SameString(str_Amount_Pay.CurrentValue, str_Amount_Pay.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_mny_Running_Payments") && CurrentForm.HasValue("o_mny_Running_Payments") && !SameString(mny_Running_Payments.CurrentValue, mny_Running_Payments.DefaultValue) &&
            !(mny_Running_Payments.IsForeignKey && CurrentMasterTable != "" && SameString(mny_Running_Payments.CurrentValue, mny_Running_Payments.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_mny_Running_Balance") && CurrentForm.HasValue("o_mny_Running_Balance") && !SameString(mny_Running_Balance.CurrentValue, mny_Running_Balance.DefaultValue) &&
            !(mny_Running_Balance.IsForeignKey && CurrentMasterTable != "" && SameString(mny_Running_Balance.CurrentValue, mny_Running_Balance.SessionValue)))
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
            NationalID.ClearErrorMessage();
            str_First_Name.ClearErrorMessage();
            str_Last_Name.ClearErrorMessage();
            date_Paid.ClearErrorMessage();
            str_ApprovalCode.ClearErrorMessage();
            Payment_Number.ClearErrorMessage();
            Pricelist.ClearErrorMessage();
            str_Amount_Pay.ClearErrorMessage();
            mny_Running_Payments.ClearErrorMessage();
            mny_Running_Balance.ClearErrorMessage();
        }

        #pragma warning disable 162, 1998
        // Get list of filters
        public async Task<string> GetFilterList()
        {
            string filterList = "";
            string savedFilterList = "";

            // Load server side filters
            if (Config.SearchFilterOption == "Server")
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblBillingInfosrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Bill_ID.AdvancedSearch.ToJson())); // Field int_Bill_ID
            filters.Merge(JObject.Parse(NationalID.AdvancedSearch.ToJson())); // Field NationalID
            filters.Merge(JObject.Parse(str_First_Name.AdvancedSearch.ToJson())); // Field str_First_Name
            filters.Merge(JObject.Parse(str_Last_Name.AdvancedSearch.ToJson())); // Field str_Last_Name
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(int_Student_ID.AdvancedSearch.ToJson())); // Field int_Student_ID
            filters.Merge(JObject.Parse(int_Payment_Method.AdvancedSearch.ToJson())); // Field int_Payment_Method
            filters.Merge(JObject.Parse(date_Paid.AdvancedSearch.ToJson())); // Field date_Paid
            filters.Merge(JObject.Parse(str_ApprovalCode.AdvancedSearch.ToJson())); // Field str_ApprovalCode
            filters.Merge(JObject.Parse(Payment_Number.AdvancedSearch.ToJson())); // Field Payment_Number
            filters.Merge(JObject.Parse(Pricelist.AdvancedSearch.ToJson())); // Field Pricelist
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(str_Amount.AdvancedSearch.ToJson())); // Field str_Amount
            filters.Merge(JObject.Parse(str_CC_Holder_Name.AdvancedSearch.ToJson())); // Field str_CC_Holder_Name
            filters.Merge(JObject.Parse(str_CC_Number.AdvancedSearch.ToJson())); // Field str_CC_Number
            filters.Merge(JObject.Parse(int_CC_ExpMonth.AdvancedSearch.ToJson())); // Field int_CC_ExpMonth
            filters.Merge(JObject.Parse(int_CC_ExpYear.AdvancedSearch.ToJson())); // Field int_CC_ExpYear
            filters.Merge(JObject.Parse(int_CC_Type.AdvancedSearch.ToJson())); // Field int_CC_Type
            filters.Merge(JObject.Parse(str_Card_Id.AdvancedSearch.ToJson())); // Field str_Card_Id
            filters.Merge(JObject.Parse(str_CC_ValidationNum.AdvancedSearch.ToJson())); // Field str_CC_ValidationNum
            filters.Merge(JObject.Parse(str_reference.AdvancedSearch.ToJson())); // Field str_reference
            filters.Merge(JObject.Parse(str_Amount_Pay.AdvancedSearch.ToJson())); // Field str_Amount_Pay
            filters.Merge(JObject.Parse(mny_Running_Payments.AdvancedSearch.ToJson())); // Field mny_Running_Payments
            filters.Merge(JObject.Parse(mny_Running_Balance.AdvancedSearch.ToJson())); // Field mny_Running_Balance
            filters.Merge(JObject.Parse(str_Payment_Reference.AdvancedSearch.ToJson())); // Field str_Payment_Reference
            filters.Merge(JObject.Parse(int_Accepted_By.AdvancedSearch.ToJson())); // Field int_Accepted_By
            filters.Merge(JObject.Parse(str_Check_Number.AdvancedSearch.ToJson())); // Field str_Check_Number
            filters.Merge(JObject.Parse(bit_Is_Check_Deposited.AdvancedSearch.ToJson())); // Field bit_Is_Check_Deposited
            filters.Merge(JObject.Parse(str_Adjustment_Type.AdvancedSearch.ToJson())); // Field str_Adjustment_Type
            filters.Merge(JObject.Parse(str_Adjust_Sub_Type.AdvancedSearch.ToJson())); // Field str_Adjust_Sub_Type
            filters.Merge(JObject.Parse(bit_Archive.AdvancedSearch.ToJson())); // Field bit_Archive
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(str_CardHolder_Address.AdvancedSearch.ToJson())); // Field str_CardHolder_Address
            filters.Merge(JObject.Parse(str_CH_City.AdvancedSearch.ToJson())); // Field str_CH_City
            filters.Merge(JObject.Parse(str_CH_Zip.AdvancedSearch.ToJson())); // Field str_CH_Zip
            filters.Merge(JObject.Parse(int_State.AdvancedSearch.ToJson())); // Field int_State
            filters.Merge(JObject.Parse(bit_IsAuthDotNet.AdvancedSearch.ToJson())); // Field bit_IsAuthDotNet
            filters.Merge(JObject.Parse(bit_IsRefund.AdvancedSearch.ToJson())); // Field bit_IsRefund
            filters.Merge(JObject.Parse(str_Receipt.AdvancedSearch.ToJson())); // Field str_Receipt
            filters.Merge(JObject.Parse(str_TransactionNumber.AdvancedSearch.ToJson())); // Field str_TransactionNumber
            filters.Merge(JObject.Parse(str_OrderId.AdvancedSearch.ToJson())); // Field str_OrderId
            filters.Merge(JObject.Parse(str_TransactionTime.AdvancedSearch.ToJson())); // Field str_TransactionTime
            filters.Merge(JObject.Parse(int_Location_Id.AdvancedSearch.ToJson())); // Field int_Location_Id
            filters.Merge(JObject.Parse(str_Enrollment_Id.AdvancedSearch.ToJson())); // Field str_Enrollment_Id
            filters.Merge(JObject.Parse(str_Notes.AdvancedSearch.ToJson())); // Field str_Notes
            filters.Merge(JObject.Parse(str_Payment_Note.AdvancedSearch.ToJson())); // Field str_Payment_Note
            filters.Merge(JObject.Parse(int_Package_ID.AdvancedSearch.ToJson())); // Field int_Package_ID
            filters.Merge(JObject.Parse(Package_Name.AdvancedSearch.ToJson())); // Field Package_Name
            filters.Merge(JObject.Parse(Price.AdvancedSearch.ToJson())); // Field Price
            filters.Merge(JObject.Parse(AssessmentID.AdvancedSearch.ToJson())); // Field AssessmentID
            filters.Merge(JObject.Parse(course.AdvancedSearch.ToJson())); // Field course
            filters.Merge(JObject.Parse(institution.AdvancedSearch.ToJson())); // Field institution
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblBillingInfosrch", filters);
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

            // Field int_Bill_ID
            if (filter?.TryGetValue("x_int_Bill_ID", out sv) ?? false) {
                int_Bill_ID.AdvancedSearch.SearchValue = sv;
                int_Bill_ID.AdvancedSearch.SearchOperator = filter["z_int_Bill_ID"];
                int_Bill_ID.AdvancedSearch.SearchCondition = filter["v_int_Bill_ID"];
                int_Bill_ID.AdvancedSearch.SearchValue2 = filter["y_int_Bill_ID"];
                int_Bill_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Bill_ID"];
                int_Bill_ID.AdvancedSearch.Save();
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

            // Field str_First_Name
            if (filter?.TryGetValue("x_str_First_Name", out sv) ?? false) {
                str_First_Name.AdvancedSearch.SearchValue = sv;
                str_First_Name.AdvancedSearch.SearchOperator = filter["z_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchCondition = filter["v_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchValue2 = filter["y_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchOperator2 = filter["w_str_First_Name"];
                str_First_Name.AdvancedSearch.Save();
            }

            // Field str_Last_Name
            if (filter?.TryGetValue("x_str_Last_Name", out sv) ?? false) {
                str_Last_Name.AdvancedSearch.SearchValue = sv;
                str_Last_Name.AdvancedSearch.SearchOperator = filter["z_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchCondition = filter["v_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchValue2 = filter["y_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Last_Name"];
                str_Last_Name.AdvancedSearch.Save();
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

            // Field int_Student_ID
            if (filter?.TryGetValue("x_int_Student_ID", out sv) ?? false) {
                int_Student_ID.AdvancedSearch.SearchValue = sv;
                int_Student_ID.AdvancedSearch.SearchOperator = filter["z_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchCondition = filter["v_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchValue2 = filter["y_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Student_ID"];
                int_Student_ID.AdvancedSearch.Save();
            }

            // Field int_Payment_Method
            if (filter?.TryGetValue("x_int_Payment_Method", out sv) ?? false) {
                int_Payment_Method.AdvancedSearch.SearchValue = sv;
                int_Payment_Method.AdvancedSearch.SearchOperator = filter["z_int_Payment_Method"];
                int_Payment_Method.AdvancedSearch.SearchCondition = filter["v_int_Payment_Method"];
                int_Payment_Method.AdvancedSearch.SearchValue2 = filter["y_int_Payment_Method"];
                int_Payment_Method.AdvancedSearch.SearchOperator2 = filter["w_int_Payment_Method"];
                int_Payment_Method.AdvancedSearch.Save();
            }

            // Field date_Paid
            if (filter?.TryGetValue("x_date_Paid", out sv) ?? false) {
                date_Paid.AdvancedSearch.SearchValue = sv;
                date_Paid.AdvancedSearch.SearchOperator = filter["z_date_Paid"];
                date_Paid.AdvancedSearch.SearchCondition = filter["v_date_Paid"];
                date_Paid.AdvancedSearch.SearchValue2 = filter["y_date_Paid"];
                date_Paid.AdvancedSearch.SearchOperator2 = filter["w_date_Paid"];
                date_Paid.AdvancedSearch.Save();
            }

            // Field str_ApprovalCode
            if (filter?.TryGetValue("x_str_ApprovalCode", out sv) ?? false) {
                str_ApprovalCode.AdvancedSearch.SearchValue = sv;
                str_ApprovalCode.AdvancedSearch.SearchOperator = filter["z_str_ApprovalCode"];
                str_ApprovalCode.AdvancedSearch.SearchCondition = filter["v_str_ApprovalCode"];
                str_ApprovalCode.AdvancedSearch.SearchValue2 = filter["y_str_ApprovalCode"];
                str_ApprovalCode.AdvancedSearch.SearchOperator2 = filter["w_str_ApprovalCode"];
                str_ApprovalCode.AdvancedSearch.Save();
            }

            // Field Payment_Number
            if (filter?.TryGetValue("x_Payment_Number", out sv) ?? false) {
                Payment_Number.AdvancedSearch.SearchValue = sv;
                Payment_Number.AdvancedSearch.SearchOperator = filter["z_Payment_Number"];
                Payment_Number.AdvancedSearch.SearchCondition = filter["v_Payment_Number"];
                Payment_Number.AdvancedSearch.SearchValue2 = filter["y_Payment_Number"];
                Payment_Number.AdvancedSearch.SearchOperator2 = filter["w_Payment_Number"];
                Payment_Number.AdvancedSearch.Save();
            }

            // Field Pricelist
            if (filter?.TryGetValue("x_Pricelist", out sv) ?? false) {
                Pricelist.AdvancedSearch.SearchValue = sv;
                Pricelist.AdvancedSearch.SearchOperator = filter["z_Pricelist"];
                Pricelist.AdvancedSearch.SearchCondition = filter["v_Pricelist"];
                Pricelist.AdvancedSearch.SearchValue2 = filter["y_Pricelist"];
                Pricelist.AdvancedSearch.SearchOperator2 = filter["w_Pricelist"];
                Pricelist.AdvancedSearch.Save();
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

            // Field str_Amount
            if (filter?.TryGetValue("x_str_Amount", out sv) ?? false) {
                str_Amount.AdvancedSearch.SearchValue = sv;
                str_Amount.AdvancedSearch.SearchOperator = filter["z_str_Amount"];
                str_Amount.AdvancedSearch.SearchCondition = filter["v_str_Amount"];
                str_Amount.AdvancedSearch.SearchValue2 = filter["y_str_Amount"];
                str_Amount.AdvancedSearch.SearchOperator2 = filter["w_str_Amount"];
                str_Amount.AdvancedSearch.Save();
            }

            // Field str_CC_Holder_Name
            if (filter?.TryGetValue("x_str_CC_Holder_Name", out sv) ?? false) {
                str_CC_Holder_Name.AdvancedSearch.SearchValue = sv;
                str_CC_Holder_Name.AdvancedSearch.SearchOperator = filter["z_str_CC_Holder_Name"];
                str_CC_Holder_Name.AdvancedSearch.SearchCondition = filter["v_str_CC_Holder_Name"];
                str_CC_Holder_Name.AdvancedSearch.SearchValue2 = filter["y_str_CC_Holder_Name"];
                str_CC_Holder_Name.AdvancedSearch.SearchOperator2 = filter["w_str_CC_Holder_Name"];
                str_CC_Holder_Name.AdvancedSearch.Save();
            }

            // Field str_CC_Number
            if (filter?.TryGetValue("x_str_CC_Number", out sv) ?? false) {
                str_CC_Number.AdvancedSearch.SearchValue = sv;
                str_CC_Number.AdvancedSearch.SearchOperator = filter["z_str_CC_Number"];
                str_CC_Number.AdvancedSearch.SearchCondition = filter["v_str_CC_Number"];
                str_CC_Number.AdvancedSearch.SearchValue2 = filter["y_str_CC_Number"];
                str_CC_Number.AdvancedSearch.SearchOperator2 = filter["w_str_CC_Number"];
                str_CC_Number.AdvancedSearch.Save();
            }

            // Field int_CC_ExpMonth
            if (filter?.TryGetValue("x_int_CC_ExpMonth", out sv) ?? false) {
                int_CC_ExpMonth.AdvancedSearch.SearchValue = sv;
                int_CC_ExpMonth.AdvancedSearch.SearchOperator = filter["z_int_CC_ExpMonth"];
                int_CC_ExpMonth.AdvancedSearch.SearchCondition = filter["v_int_CC_ExpMonth"];
                int_CC_ExpMonth.AdvancedSearch.SearchValue2 = filter["y_int_CC_ExpMonth"];
                int_CC_ExpMonth.AdvancedSearch.SearchOperator2 = filter["w_int_CC_ExpMonth"];
                int_CC_ExpMonth.AdvancedSearch.Save();
            }

            // Field int_CC_ExpYear
            if (filter?.TryGetValue("x_int_CC_ExpYear", out sv) ?? false) {
                int_CC_ExpYear.AdvancedSearch.SearchValue = sv;
                int_CC_ExpYear.AdvancedSearch.SearchOperator = filter["z_int_CC_ExpYear"];
                int_CC_ExpYear.AdvancedSearch.SearchCondition = filter["v_int_CC_ExpYear"];
                int_CC_ExpYear.AdvancedSearch.SearchValue2 = filter["y_int_CC_ExpYear"];
                int_CC_ExpYear.AdvancedSearch.SearchOperator2 = filter["w_int_CC_ExpYear"];
                int_CC_ExpYear.AdvancedSearch.Save();
            }

            // Field int_CC_Type
            if (filter?.TryGetValue("x_int_CC_Type", out sv) ?? false) {
                int_CC_Type.AdvancedSearch.SearchValue = sv;
                int_CC_Type.AdvancedSearch.SearchOperator = filter["z_int_CC_Type"];
                int_CC_Type.AdvancedSearch.SearchCondition = filter["v_int_CC_Type"];
                int_CC_Type.AdvancedSearch.SearchValue2 = filter["y_int_CC_Type"];
                int_CC_Type.AdvancedSearch.SearchOperator2 = filter["w_int_CC_Type"];
                int_CC_Type.AdvancedSearch.Save();
            }

            // Field str_Card_Id
            if (filter?.TryGetValue("x_str_Card_Id", out sv) ?? false) {
                str_Card_Id.AdvancedSearch.SearchValue = sv;
                str_Card_Id.AdvancedSearch.SearchOperator = filter["z_str_Card_Id"];
                str_Card_Id.AdvancedSearch.SearchCondition = filter["v_str_Card_Id"];
                str_Card_Id.AdvancedSearch.SearchValue2 = filter["y_str_Card_Id"];
                str_Card_Id.AdvancedSearch.SearchOperator2 = filter["w_str_Card_Id"];
                str_Card_Id.AdvancedSearch.Save();
            }

            // Field str_CC_ValidationNum
            if (filter?.TryGetValue("x_str_CC_ValidationNum", out sv) ?? false) {
                str_CC_ValidationNum.AdvancedSearch.SearchValue = sv;
                str_CC_ValidationNum.AdvancedSearch.SearchOperator = filter["z_str_CC_ValidationNum"];
                str_CC_ValidationNum.AdvancedSearch.SearchCondition = filter["v_str_CC_ValidationNum"];
                str_CC_ValidationNum.AdvancedSearch.SearchValue2 = filter["y_str_CC_ValidationNum"];
                str_CC_ValidationNum.AdvancedSearch.SearchOperator2 = filter["w_str_CC_ValidationNum"];
                str_CC_ValidationNum.AdvancedSearch.Save();
            }

            // Field str_reference
            if (filter?.TryGetValue("x_str_reference", out sv) ?? false) {
                str_reference.AdvancedSearch.SearchValue = sv;
                str_reference.AdvancedSearch.SearchOperator = filter["z_str_reference"];
                str_reference.AdvancedSearch.SearchCondition = filter["v_str_reference"];
                str_reference.AdvancedSearch.SearchValue2 = filter["y_str_reference"];
                str_reference.AdvancedSearch.SearchOperator2 = filter["w_str_reference"];
                str_reference.AdvancedSearch.Save();
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

            // Field mny_Running_Payments
            if (filter?.TryGetValue("x_mny_Running_Payments", out sv) ?? false) {
                mny_Running_Payments.AdvancedSearch.SearchValue = sv;
                mny_Running_Payments.AdvancedSearch.SearchOperator = filter["z_mny_Running_Payments"];
                mny_Running_Payments.AdvancedSearch.SearchCondition = filter["v_mny_Running_Payments"];
                mny_Running_Payments.AdvancedSearch.SearchValue2 = filter["y_mny_Running_Payments"];
                mny_Running_Payments.AdvancedSearch.SearchOperator2 = filter["w_mny_Running_Payments"];
                mny_Running_Payments.AdvancedSearch.Save();
            }

            // Field mny_Running_Balance
            if (filter?.TryGetValue("x_mny_Running_Balance", out sv) ?? false) {
                mny_Running_Balance.AdvancedSearch.SearchValue = sv;
                mny_Running_Balance.AdvancedSearch.SearchOperator = filter["z_mny_Running_Balance"];
                mny_Running_Balance.AdvancedSearch.SearchCondition = filter["v_mny_Running_Balance"];
                mny_Running_Balance.AdvancedSearch.SearchValue2 = filter["y_mny_Running_Balance"];
                mny_Running_Balance.AdvancedSearch.SearchOperator2 = filter["w_mny_Running_Balance"];
                mny_Running_Balance.AdvancedSearch.Save();
            }

            // Field str_Payment_Reference
            if (filter?.TryGetValue("x_str_Payment_Reference", out sv) ?? false) {
                str_Payment_Reference.AdvancedSearch.SearchValue = sv;
                str_Payment_Reference.AdvancedSearch.SearchOperator = filter["z_str_Payment_Reference"];
                str_Payment_Reference.AdvancedSearch.SearchCondition = filter["v_str_Payment_Reference"];
                str_Payment_Reference.AdvancedSearch.SearchValue2 = filter["y_str_Payment_Reference"];
                str_Payment_Reference.AdvancedSearch.SearchOperator2 = filter["w_str_Payment_Reference"];
                str_Payment_Reference.AdvancedSearch.Save();
            }

            // Field int_Accepted_By
            if (filter?.TryGetValue("x_int_Accepted_By", out sv) ?? false) {
                int_Accepted_By.AdvancedSearch.SearchValue = sv;
                int_Accepted_By.AdvancedSearch.SearchOperator = filter["z_int_Accepted_By"];
                int_Accepted_By.AdvancedSearch.SearchCondition = filter["v_int_Accepted_By"];
                int_Accepted_By.AdvancedSearch.SearchValue2 = filter["y_int_Accepted_By"];
                int_Accepted_By.AdvancedSearch.SearchOperator2 = filter["w_int_Accepted_By"];
                int_Accepted_By.AdvancedSearch.Save();
            }

            // Field str_Check_Number
            if (filter?.TryGetValue("x_str_Check_Number", out sv) ?? false) {
                str_Check_Number.AdvancedSearch.SearchValue = sv;
                str_Check_Number.AdvancedSearch.SearchOperator = filter["z_str_Check_Number"];
                str_Check_Number.AdvancedSearch.SearchCondition = filter["v_str_Check_Number"];
                str_Check_Number.AdvancedSearch.SearchValue2 = filter["y_str_Check_Number"];
                str_Check_Number.AdvancedSearch.SearchOperator2 = filter["w_str_Check_Number"];
                str_Check_Number.AdvancedSearch.Save();
            }

            // Field bit_Is_Check_Deposited
            if (filter?.TryGetValue("x_bit_Is_Check_Deposited", out sv) ?? false) {
                bit_Is_Check_Deposited.AdvancedSearch.SearchValue = sv;
                bit_Is_Check_Deposited.AdvancedSearch.SearchOperator = filter["z_bit_Is_Check_Deposited"];
                bit_Is_Check_Deposited.AdvancedSearch.SearchCondition = filter["v_bit_Is_Check_Deposited"];
                bit_Is_Check_Deposited.AdvancedSearch.SearchValue2 = filter["y_bit_Is_Check_Deposited"];
                bit_Is_Check_Deposited.AdvancedSearch.SearchOperator2 = filter["w_bit_Is_Check_Deposited"];
                bit_Is_Check_Deposited.AdvancedSearch.Save();
            }

            // Field str_Adjustment_Type
            if (filter?.TryGetValue("x_str_Adjustment_Type", out sv) ?? false) {
                str_Adjustment_Type.AdvancedSearch.SearchValue = sv;
                str_Adjustment_Type.AdvancedSearch.SearchOperator = filter["z_str_Adjustment_Type"];
                str_Adjustment_Type.AdvancedSearch.SearchCondition = filter["v_str_Adjustment_Type"];
                str_Adjustment_Type.AdvancedSearch.SearchValue2 = filter["y_str_Adjustment_Type"];
                str_Adjustment_Type.AdvancedSearch.SearchOperator2 = filter["w_str_Adjustment_Type"];
                str_Adjustment_Type.AdvancedSearch.Save();
            }

            // Field str_Adjust_Sub_Type
            if (filter?.TryGetValue("x_str_Adjust_Sub_Type", out sv) ?? false) {
                str_Adjust_Sub_Type.AdvancedSearch.SearchValue = sv;
                str_Adjust_Sub_Type.AdvancedSearch.SearchOperator = filter["z_str_Adjust_Sub_Type"];
                str_Adjust_Sub_Type.AdvancedSearch.SearchCondition = filter["v_str_Adjust_Sub_Type"];
                str_Adjust_Sub_Type.AdvancedSearch.SearchValue2 = filter["y_str_Adjust_Sub_Type"];
                str_Adjust_Sub_Type.AdvancedSearch.SearchOperator2 = filter["w_str_Adjust_Sub_Type"];
                str_Adjust_Sub_Type.AdvancedSearch.Save();
            }

            // Field bit_Archive
            if (filter?.TryGetValue("x_bit_Archive", out sv) ?? false) {
                bit_Archive.AdvancedSearch.SearchValue = sv;
                bit_Archive.AdvancedSearch.SearchOperator = filter["z_bit_Archive"];
                bit_Archive.AdvancedSearch.SearchCondition = filter["v_bit_Archive"];
                bit_Archive.AdvancedSearch.SearchValue2 = filter["y_bit_Archive"];
                bit_Archive.AdvancedSearch.SearchOperator2 = filter["w_bit_Archive"];
                bit_Archive.AdvancedSearch.Save();
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

            // Field str_CardHolder_Address
            if (filter?.TryGetValue("x_str_CardHolder_Address", out sv) ?? false) {
                str_CardHolder_Address.AdvancedSearch.SearchValue = sv;
                str_CardHolder_Address.AdvancedSearch.SearchOperator = filter["z_str_CardHolder_Address"];
                str_CardHolder_Address.AdvancedSearch.SearchCondition = filter["v_str_CardHolder_Address"];
                str_CardHolder_Address.AdvancedSearch.SearchValue2 = filter["y_str_CardHolder_Address"];
                str_CardHolder_Address.AdvancedSearch.SearchOperator2 = filter["w_str_CardHolder_Address"];
                str_CardHolder_Address.AdvancedSearch.Save();
            }

            // Field str_CH_City
            if (filter?.TryGetValue("x_str_CH_City", out sv) ?? false) {
                str_CH_City.AdvancedSearch.SearchValue = sv;
                str_CH_City.AdvancedSearch.SearchOperator = filter["z_str_CH_City"];
                str_CH_City.AdvancedSearch.SearchCondition = filter["v_str_CH_City"];
                str_CH_City.AdvancedSearch.SearchValue2 = filter["y_str_CH_City"];
                str_CH_City.AdvancedSearch.SearchOperator2 = filter["w_str_CH_City"];
                str_CH_City.AdvancedSearch.Save();
            }

            // Field str_CH_Zip
            if (filter?.TryGetValue("x_str_CH_Zip", out sv) ?? false) {
                str_CH_Zip.AdvancedSearch.SearchValue = sv;
                str_CH_Zip.AdvancedSearch.SearchOperator = filter["z_str_CH_Zip"];
                str_CH_Zip.AdvancedSearch.SearchCondition = filter["v_str_CH_Zip"];
                str_CH_Zip.AdvancedSearch.SearchValue2 = filter["y_str_CH_Zip"];
                str_CH_Zip.AdvancedSearch.SearchOperator2 = filter["w_str_CH_Zip"];
                str_CH_Zip.AdvancedSearch.Save();
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

            // Field bit_IsAuthDotNet
            if (filter?.TryGetValue("x_bit_IsAuthDotNet", out sv) ?? false) {
                bit_IsAuthDotNet.AdvancedSearch.SearchValue = sv;
                bit_IsAuthDotNet.AdvancedSearch.SearchOperator = filter["z_bit_IsAuthDotNet"];
                bit_IsAuthDotNet.AdvancedSearch.SearchCondition = filter["v_bit_IsAuthDotNet"];
                bit_IsAuthDotNet.AdvancedSearch.SearchValue2 = filter["y_bit_IsAuthDotNet"];
                bit_IsAuthDotNet.AdvancedSearch.SearchOperator2 = filter["w_bit_IsAuthDotNet"];
                bit_IsAuthDotNet.AdvancedSearch.Save();
            }

            // Field bit_IsRefund
            if (filter?.TryGetValue("x_bit_IsRefund", out sv) ?? false) {
                bit_IsRefund.AdvancedSearch.SearchValue = sv;
                bit_IsRefund.AdvancedSearch.SearchOperator = filter["z_bit_IsRefund"];
                bit_IsRefund.AdvancedSearch.SearchCondition = filter["v_bit_IsRefund"];
                bit_IsRefund.AdvancedSearch.SearchValue2 = filter["y_bit_IsRefund"];
                bit_IsRefund.AdvancedSearch.SearchOperator2 = filter["w_bit_IsRefund"];
                bit_IsRefund.AdvancedSearch.Save();
            }

            // Field str_Receipt
            if (filter?.TryGetValue("x_str_Receipt", out sv) ?? false) {
                str_Receipt.AdvancedSearch.SearchValue = sv;
                str_Receipt.AdvancedSearch.SearchOperator = filter["z_str_Receipt"];
                str_Receipt.AdvancedSearch.SearchCondition = filter["v_str_Receipt"];
                str_Receipt.AdvancedSearch.SearchValue2 = filter["y_str_Receipt"];
                str_Receipt.AdvancedSearch.SearchOperator2 = filter["w_str_Receipt"];
                str_Receipt.AdvancedSearch.Save();
            }

            // Field str_TransactionNumber
            if (filter?.TryGetValue("x_str_TransactionNumber", out sv) ?? false) {
                str_TransactionNumber.AdvancedSearch.SearchValue = sv;
                str_TransactionNumber.AdvancedSearch.SearchOperator = filter["z_str_TransactionNumber"];
                str_TransactionNumber.AdvancedSearch.SearchCondition = filter["v_str_TransactionNumber"];
                str_TransactionNumber.AdvancedSearch.SearchValue2 = filter["y_str_TransactionNumber"];
                str_TransactionNumber.AdvancedSearch.SearchOperator2 = filter["w_str_TransactionNumber"];
                str_TransactionNumber.AdvancedSearch.Save();
            }

            // Field str_OrderId
            if (filter?.TryGetValue("x_str_OrderId", out sv) ?? false) {
                str_OrderId.AdvancedSearch.SearchValue = sv;
                str_OrderId.AdvancedSearch.SearchOperator = filter["z_str_OrderId"];
                str_OrderId.AdvancedSearch.SearchCondition = filter["v_str_OrderId"];
                str_OrderId.AdvancedSearch.SearchValue2 = filter["y_str_OrderId"];
                str_OrderId.AdvancedSearch.SearchOperator2 = filter["w_str_OrderId"];
                str_OrderId.AdvancedSearch.Save();
            }

            // Field str_TransactionTime
            if (filter?.TryGetValue("x_str_TransactionTime", out sv) ?? false) {
                str_TransactionTime.AdvancedSearch.SearchValue = sv;
                str_TransactionTime.AdvancedSearch.SearchOperator = filter["z_str_TransactionTime"];
                str_TransactionTime.AdvancedSearch.SearchCondition = filter["v_str_TransactionTime"];
                str_TransactionTime.AdvancedSearch.SearchValue2 = filter["y_str_TransactionTime"];
                str_TransactionTime.AdvancedSearch.SearchOperator2 = filter["w_str_TransactionTime"];
                str_TransactionTime.AdvancedSearch.Save();
            }

            // Field int_Location_Id
            if (filter?.TryGetValue("x_int_Location_Id", out sv) ?? false) {
                int_Location_Id.AdvancedSearch.SearchValue = sv;
                int_Location_Id.AdvancedSearch.SearchOperator = filter["z_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchCondition = filter["v_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchValue2 = filter["y_int_Location_Id"];
                int_Location_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Location_Id"];
                int_Location_Id.AdvancedSearch.Save();
            }

            // Field str_Enrollment_Id
            if (filter?.TryGetValue("x_str_Enrollment_Id", out sv) ?? false) {
                str_Enrollment_Id.AdvancedSearch.SearchValue = sv;
                str_Enrollment_Id.AdvancedSearch.SearchOperator = filter["z_str_Enrollment_Id"];
                str_Enrollment_Id.AdvancedSearch.SearchCondition = filter["v_str_Enrollment_Id"];
                str_Enrollment_Id.AdvancedSearch.SearchValue2 = filter["y_str_Enrollment_Id"];
                str_Enrollment_Id.AdvancedSearch.SearchOperator2 = filter["w_str_Enrollment_Id"];
                str_Enrollment_Id.AdvancedSearch.Save();
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

            // Field str_Payment_Note
            if (filter?.TryGetValue("x_str_Payment_Note", out sv) ?? false) {
                str_Payment_Note.AdvancedSearch.SearchValue = sv;
                str_Payment_Note.AdvancedSearch.SearchOperator = filter["z_str_Payment_Note"];
                str_Payment_Note.AdvancedSearch.SearchCondition = filter["v_str_Payment_Note"];
                str_Payment_Note.AdvancedSearch.SearchValue2 = filter["y_str_Payment_Note"];
                str_Payment_Note.AdvancedSearch.SearchOperator2 = filter["w_str_Payment_Note"];
                str_Payment_Note.AdvancedSearch.Save();
            }

            // Field int_Package_ID
            if (filter?.TryGetValue("x_int_Package_ID", out sv) ?? false) {
                int_Package_ID.AdvancedSearch.SearchValue = sv;
                int_Package_ID.AdvancedSearch.SearchOperator = filter["z_int_Package_ID"];
                int_Package_ID.AdvancedSearch.SearchCondition = filter["v_int_Package_ID"];
                int_Package_ID.AdvancedSearch.SearchValue2 = filter["y_int_Package_ID"];
                int_Package_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Package_ID"];
                int_Package_ID.AdvancedSearch.Save();
            }

            // Field Package_Name
            if (filter?.TryGetValue("x_Package_Name", out sv) ?? false) {
                Package_Name.AdvancedSearch.SearchValue = sv;
                Package_Name.AdvancedSearch.SearchOperator = filter["z_Package_Name"];
                Package_Name.AdvancedSearch.SearchCondition = filter["v_Package_Name"];
                Package_Name.AdvancedSearch.SearchValue2 = filter["y_Package_Name"];
                Package_Name.AdvancedSearch.SearchOperator2 = filter["w_Package_Name"];
                Package_Name.AdvancedSearch.Save();
            }

            // Field Price
            if (filter?.TryGetValue("x_Price", out sv) ?? false) {
                Price.AdvancedSearch.SearchValue = sv;
                Price.AdvancedSearch.SearchOperator = filter["z_Price"];
                Price.AdvancedSearch.SearchCondition = filter["v_Price"];
                Price.AdvancedSearch.SearchValue2 = filter["y_Price"];
                Price.AdvancedSearch.SearchOperator2 = filter["w_Price"];
                Price.AdvancedSearch.Save();
            }

            // Field AssessmentID
            if (filter?.TryGetValue("x_AssessmentID", out sv) ?? false) {
                AssessmentID.AdvancedSearch.SearchValue = sv;
                AssessmentID.AdvancedSearch.SearchOperator = filter["z_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchCondition = filter["v_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchValue2 = filter["y_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchOperator2 = filter["w_AssessmentID"];
                AssessmentID.AdvancedSearch.Save();
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
            BuildSearchSql(ref where, int_Bill_ID, def, false); // int_Bill_ID
            BuildSearchSql(ref where, NationalID, def, false); // NationalID
            BuildSearchSql(ref where, str_First_Name, def, false); // str_First_Name
            BuildSearchSql(ref where, str_Last_Name, def, false); // str_Last_Name
            BuildSearchSql(ref where, str_Username, def, false); // str_Username
            BuildSearchSql(ref where, int_Student_ID, def, false); // int_Student_ID
            BuildSearchSql(ref where, int_Payment_Method, def, false); // int_Payment_Method
            BuildSearchSql(ref where, date_Paid, def, false); // date_Paid
            BuildSearchSql(ref where, str_ApprovalCode, def, false); // str_ApprovalCode
            BuildSearchSql(ref where, Payment_Number, def, false); // Payment_Number
            BuildSearchSql(ref where, Pricelist, def, false); // Pricelist
            BuildSearchSql(ref where, date_Created, def, false); // date_Created
            BuildSearchSql(ref where, str_Amount, def, false); // str_Amount
            BuildSearchSql(ref where, str_CC_Holder_Name, def, false); // str_CC_Holder_Name
            BuildSearchSql(ref where, str_CC_Number, def, false); // str_CC_Number
            BuildSearchSql(ref where, int_CC_ExpMonth, def, false); // int_CC_ExpMonth
            BuildSearchSql(ref where, int_CC_ExpYear, def, false); // int_CC_ExpYear
            BuildSearchSql(ref where, int_CC_Type, def, false); // int_CC_Type
            BuildSearchSql(ref where, str_Card_Id, def, false); // str_Card_Id
            BuildSearchSql(ref where, str_CC_ValidationNum, def, false); // str_CC_ValidationNum
            BuildSearchSql(ref where, str_reference, def, false); // str_reference
            BuildSearchSql(ref where, str_Amount_Pay, def, false); // str_Amount_Pay
            BuildSearchSql(ref where, mny_Running_Payments, def, false); // mny_Running_Payments
            BuildSearchSql(ref where, mny_Running_Balance, def, false); // mny_Running_Balance
            BuildSearchSql(ref where, str_Payment_Reference, def, false); // str_Payment_Reference
            BuildSearchSql(ref where, int_Accepted_By, def, false); // int_Accepted_By
            BuildSearchSql(ref where, str_Check_Number, def, false); // str_Check_Number
            BuildSearchSql(ref where, bit_Is_Check_Deposited, def, false); // bit_Is_Check_Deposited
            BuildSearchSql(ref where, str_Adjustment_Type, def, false); // str_Adjustment_Type
            BuildSearchSql(ref where, str_Adjust_Sub_Type, def, false); // str_Adjust_Sub_Type
            BuildSearchSql(ref where, bit_Archive, def, false); // bit_Archive
            BuildSearchSql(ref where, int_Created_By, def, false); // int_Created_By
            BuildSearchSql(ref where, int_Modified_By, def, false); // int_Modified_By
            BuildSearchSql(ref where, date_Modified, def, false); // date_Modified
            BuildSearchSql(ref where, bit_IsDeleted, def, false); // bit_IsDeleted
            BuildSearchSql(ref where, str_CardHolder_Address, def, false); // str_CardHolder_Address
            BuildSearchSql(ref where, str_CH_City, def, false); // str_CH_City
            BuildSearchSql(ref where, str_CH_Zip, def, false); // str_CH_Zip
            BuildSearchSql(ref where, int_State, def, false); // int_State
            BuildSearchSql(ref where, bit_IsAuthDotNet, def, false); // bit_IsAuthDotNet
            BuildSearchSql(ref where, bit_IsRefund, def, false); // bit_IsRefund
            BuildSearchSql(ref where, str_Receipt, def, false); // str_Receipt
            BuildSearchSql(ref where, str_TransactionNumber, def, false); // str_TransactionNumber
            BuildSearchSql(ref where, str_OrderId, def, false); // str_OrderId
            BuildSearchSql(ref where, str_TransactionTime, def, false); // str_TransactionTime
            BuildSearchSql(ref where, int_Location_Id, def, false); // int_Location_Id
            BuildSearchSql(ref where, str_Enrollment_Id, def, false); // str_Enrollment_Id
            BuildSearchSql(ref where, str_Notes, def, false); // str_Notes
            BuildSearchSql(ref where, str_Payment_Note, def, false); // str_Payment_Note
            BuildSearchSql(ref where, int_Package_ID, def, false); // int_Package_ID
            BuildSearchSql(ref where, Package_Name, def, false); // Package_Name
            BuildSearchSql(ref where, Price, def, false); // Price
            BuildSearchSql(ref where, AssessmentID, def, false); // AssessmentID
            BuildSearchSql(ref where, course, def, false); // course
            BuildSearchSql(ref where, institution, def, false); // institution
            BuildSearchSql(ref where, UniqueIdx, def, false); // UniqueIdx

            // Set up search command
            if (!def && !Empty(where) && (new[] { "", "reset", "resetall" }).Contains(Command))
                Command = "search";
            if (!def && Command == "search") {
                int_Bill_ID.AdvancedSearch.Save(); // int_Bill_ID
                NationalID.AdvancedSearch.Save(); // NationalID
                str_First_Name.AdvancedSearch.Save(); // str_First_Name
                str_Last_Name.AdvancedSearch.Save(); // str_Last_Name
                str_Username.AdvancedSearch.Save(); // str_Username
                int_Student_ID.AdvancedSearch.Save(); // int_Student_ID
                int_Payment_Method.AdvancedSearch.Save(); // int_Payment_Method
                date_Paid.AdvancedSearch.Save(); // date_Paid
                str_ApprovalCode.AdvancedSearch.Save(); // str_ApprovalCode
                Payment_Number.AdvancedSearch.Save(); // Payment_Number
                Pricelist.AdvancedSearch.Save(); // Pricelist
                date_Created.AdvancedSearch.Save(); // date_Created
                str_Amount.AdvancedSearch.Save(); // str_Amount
                str_CC_Holder_Name.AdvancedSearch.Save(); // str_CC_Holder_Name
                str_CC_Number.AdvancedSearch.Save(); // str_CC_Number
                int_CC_ExpMonth.AdvancedSearch.Save(); // int_CC_ExpMonth
                int_CC_ExpYear.AdvancedSearch.Save(); // int_CC_ExpYear
                int_CC_Type.AdvancedSearch.Save(); // int_CC_Type
                str_Card_Id.AdvancedSearch.Save(); // str_Card_Id
                str_CC_ValidationNum.AdvancedSearch.Save(); // str_CC_ValidationNum
                str_reference.AdvancedSearch.Save(); // str_reference
                str_Amount_Pay.AdvancedSearch.Save(); // str_Amount_Pay
                mny_Running_Payments.AdvancedSearch.Save(); // mny_Running_Payments
                mny_Running_Balance.AdvancedSearch.Save(); // mny_Running_Balance
                str_Payment_Reference.AdvancedSearch.Save(); // str_Payment_Reference
                int_Accepted_By.AdvancedSearch.Save(); // int_Accepted_By
                str_Check_Number.AdvancedSearch.Save(); // str_Check_Number
                bit_Is_Check_Deposited.AdvancedSearch.Save(); // bit_Is_Check_Deposited
                str_Adjustment_Type.AdvancedSearch.Save(); // str_Adjustment_Type
                str_Adjust_Sub_Type.AdvancedSearch.Save(); // str_Adjust_Sub_Type
                bit_Archive.AdvancedSearch.Save(); // bit_Archive
                int_Created_By.AdvancedSearch.Save(); // int_Created_By
                int_Modified_By.AdvancedSearch.Save(); // int_Modified_By
                date_Modified.AdvancedSearch.Save(); // date_Modified
                bit_IsDeleted.AdvancedSearch.Save(); // bit_IsDeleted
                str_CardHolder_Address.AdvancedSearch.Save(); // str_CardHolder_Address
                str_CH_City.AdvancedSearch.Save(); // str_CH_City
                str_CH_Zip.AdvancedSearch.Save(); // str_CH_Zip
                int_State.AdvancedSearch.Save(); // int_State
                bit_IsAuthDotNet.AdvancedSearch.Save(); // bit_IsAuthDotNet
                bit_IsRefund.AdvancedSearch.Save(); // bit_IsRefund
                str_Receipt.AdvancedSearch.Save(); // str_Receipt
                str_TransactionNumber.AdvancedSearch.Save(); // str_TransactionNumber
                str_OrderId.AdvancedSearch.Save(); // str_OrderId
                str_TransactionTime.AdvancedSearch.Save(); // str_TransactionTime
                int_Location_Id.AdvancedSearch.Save(); // int_Location_Id
                str_Enrollment_Id.AdvancedSearch.Save(); // str_Enrollment_Id
                str_Notes.AdvancedSearch.Save(); // str_Notes
                str_Payment_Note.AdvancedSearch.Save(); // str_Payment_Note
                int_Package_ID.AdvancedSearch.Save(); // int_Package_ID
                Package_Name.AdvancedSearch.Save(); // Package_Name
                Price.AdvancedSearch.Save(); // Price
                AssessmentID.AdvancedSearch.Save(); // AssessmentID
                course.AdvancedSearch.Save(); // course
                institution.AdvancedSearch.Save(); // institution
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

            // Field NationalID
            filter = QueryBuilderWhere("NationalID");
            if (Empty(filter))
                BuildSearchSql(ref filter, NationalID, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + NationalID.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_First_Name
            filter = QueryBuilderWhere("str_First_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_First_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_First_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Last_Name
            filter = QueryBuilderWhere("str_Last_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Last_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Last_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field date_Paid
            filter = QueryBuilderWhere("date_Paid");
            if (Empty(filter))
                BuildSearchSql(ref filter, date_Paid, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + date_Paid.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_ApprovalCode
            filter = QueryBuilderWhere("str_ApprovalCode");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_ApprovalCode, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_ApprovalCode.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field Payment_Number
            filter = QueryBuilderWhere("Payment_Number");
            if (Empty(filter))
                BuildSearchSql(ref filter, Payment_Number, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + Payment_Number.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field Pricelist
            filter = QueryBuilderWhere("Pricelist");
            if (Empty(filter))
                BuildSearchSql(ref filter, Pricelist, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + Pricelist.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Amount_Pay
            filter = QueryBuilderWhere("str_Amount_Pay");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Amount_Pay, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Amount_Pay.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field mny_Running_Payments
            filter = QueryBuilderWhere("mny_Running_Payments");
            if (Empty(filter))
                BuildSearchSql(ref filter, mny_Running_Payments, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + mny_Running_Payments.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field mny_Running_Balance
            filter = QueryBuilderWhere("mny_Running_Balance");
            if (Empty(filter))
                BuildSearchSql(ref filter, mny_Running_Balance, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + mny_Running_Balance.Caption + "</span>" + captionSuffix + filter + "</div>";
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
            searchFlds.Add(str_First_Name);
            searchFlds.Add(str_Last_Name);
            searchFlds.Add(str_Username);
            searchFlds.Add(str_ApprovalCode);
            searchFlds.Add(str_Amount);
            searchFlds.Add(str_CC_Holder_Name);
            searchFlds.Add(str_CC_Number);
            searchFlds.Add(str_Card_Id);
            searchFlds.Add(str_CC_ValidationNum);
            searchFlds.Add(str_reference);
            searchFlds.Add(str_Amount_Pay);
            searchFlds.Add(mny_Running_Balance);
            searchFlds.Add(str_Payment_Reference);
            searchFlds.Add(str_Check_Number);
            searchFlds.Add(str_Adjustment_Type);
            searchFlds.Add(str_Adjust_Sub_Type);
            searchFlds.Add(str_CardHolder_Address);
            searchFlds.Add(str_CH_City);
            searchFlds.Add(str_CH_Zip);
            searchFlds.Add(str_Receipt);
            searchFlds.Add(str_TransactionNumber);
            searchFlds.Add(str_OrderId);
            searchFlds.Add(str_TransactionTime);
            searchFlds.Add(str_Enrollment_Id);
            searchFlds.Add(str_Notes);
            searchFlds.Add(str_Payment_Note);
            searchFlds.Add(Package_Name);
            searchFlds.Add(course);
            searchFlds.Add(institution);
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
            if (int_Bill_ID.AdvancedSearch.IssetSession)
                return true;
            if (NationalID.AdvancedSearch.IssetSession)
                return true;
            if (str_First_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Last_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Username.AdvancedSearch.IssetSession)
                return true;
            if (int_Student_ID.AdvancedSearch.IssetSession)
                return true;
            if (int_Payment_Method.AdvancedSearch.IssetSession)
                return true;
            if (date_Paid.AdvancedSearch.IssetSession)
                return true;
            if (str_ApprovalCode.AdvancedSearch.IssetSession)
                return true;
            if (Payment_Number.AdvancedSearch.IssetSession)
                return true;
            if (Pricelist.AdvancedSearch.IssetSession)
                return true;
            if (date_Created.AdvancedSearch.IssetSession)
                return true;
            if (str_Amount.AdvancedSearch.IssetSession)
                return true;
            if (str_CC_Holder_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_CC_Number.AdvancedSearch.IssetSession)
                return true;
            if (int_CC_ExpMonth.AdvancedSearch.IssetSession)
                return true;
            if (int_CC_ExpYear.AdvancedSearch.IssetSession)
                return true;
            if (int_CC_Type.AdvancedSearch.IssetSession)
                return true;
            if (str_Card_Id.AdvancedSearch.IssetSession)
                return true;
            if (str_CC_ValidationNum.AdvancedSearch.IssetSession)
                return true;
            if (str_reference.AdvancedSearch.IssetSession)
                return true;
            if (str_Amount_Pay.AdvancedSearch.IssetSession)
                return true;
            if (mny_Running_Payments.AdvancedSearch.IssetSession)
                return true;
            if (mny_Running_Balance.AdvancedSearch.IssetSession)
                return true;
            if (str_Payment_Reference.AdvancedSearch.IssetSession)
                return true;
            if (int_Accepted_By.AdvancedSearch.IssetSession)
                return true;
            if (str_Check_Number.AdvancedSearch.IssetSession)
                return true;
            if (bit_Is_Check_Deposited.AdvancedSearch.IssetSession)
                return true;
            if (str_Adjustment_Type.AdvancedSearch.IssetSession)
                return true;
            if (str_Adjust_Sub_Type.AdvancedSearch.IssetSession)
                return true;
            if (bit_Archive.AdvancedSearch.IssetSession)
                return true;
            if (int_Created_By.AdvancedSearch.IssetSession)
                return true;
            if (int_Modified_By.AdvancedSearch.IssetSession)
                return true;
            if (date_Modified.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsDeleted.AdvancedSearch.IssetSession)
                return true;
            if (str_CardHolder_Address.AdvancedSearch.IssetSession)
                return true;
            if (str_CH_City.AdvancedSearch.IssetSession)
                return true;
            if (str_CH_Zip.AdvancedSearch.IssetSession)
                return true;
            if (int_State.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsAuthDotNet.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsRefund.AdvancedSearch.IssetSession)
                return true;
            if (str_Receipt.AdvancedSearch.IssetSession)
                return true;
            if (str_TransactionNumber.AdvancedSearch.IssetSession)
                return true;
            if (str_OrderId.AdvancedSearch.IssetSession)
                return true;
            if (str_TransactionTime.AdvancedSearch.IssetSession)
                return true;
            if (int_Location_Id.AdvancedSearch.IssetSession)
                return true;
            if (str_Enrollment_Id.AdvancedSearch.IssetSession)
                return true;
            if (str_Notes.AdvancedSearch.IssetSession)
                return true;
            if (str_Payment_Note.AdvancedSearch.IssetSession)
                return true;
            if (int_Package_ID.AdvancedSearch.IssetSession)
                return true;
            if (Package_Name.AdvancedSearch.IssetSession)
                return true;
            if (Price.AdvancedSearch.IssetSession)
                return true;
            if (AssessmentID.AdvancedSearch.IssetSession)
                return true;
            if (course.AdvancedSearch.IssetSession)
                return true;
            if (institution.AdvancedSearch.IssetSession)
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
            int_Bill_ID.AdvancedSearch.UnsetSession();
            NationalID.AdvancedSearch.UnsetSession();
            str_First_Name.AdvancedSearch.UnsetSession();
            str_Last_Name.AdvancedSearch.UnsetSession();
            str_Username.AdvancedSearch.UnsetSession();
            int_Student_ID.AdvancedSearch.UnsetSession();
            int_Payment_Method.AdvancedSearch.UnsetSession();
            date_Paid.AdvancedSearch.UnsetSession();
            str_ApprovalCode.AdvancedSearch.UnsetSession();
            Payment_Number.AdvancedSearch.UnsetSession();
            Pricelist.AdvancedSearch.UnsetSession();
            date_Created.AdvancedSearch.UnsetSession();
            str_Amount.AdvancedSearch.UnsetSession();
            str_CC_Holder_Name.AdvancedSearch.UnsetSession();
            str_CC_Number.AdvancedSearch.UnsetSession();
            int_CC_ExpMonth.AdvancedSearch.UnsetSession();
            int_CC_ExpYear.AdvancedSearch.UnsetSession();
            int_CC_Type.AdvancedSearch.UnsetSession();
            str_Card_Id.AdvancedSearch.UnsetSession();
            str_CC_ValidationNum.AdvancedSearch.UnsetSession();
            str_reference.AdvancedSearch.UnsetSession();
            str_Amount_Pay.AdvancedSearch.UnsetSession();
            mny_Running_Payments.AdvancedSearch.UnsetSession();
            mny_Running_Balance.AdvancedSearch.UnsetSession();
            str_Payment_Reference.AdvancedSearch.UnsetSession();
            int_Accepted_By.AdvancedSearch.UnsetSession();
            str_Check_Number.AdvancedSearch.UnsetSession();
            bit_Is_Check_Deposited.AdvancedSearch.UnsetSession();
            str_Adjustment_Type.AdvancedSearch.UnsetSession();
            str_Adjust_Sub_Type.AdvancedSearch.UnsetSession();
            bit_Archive.AdvancedSearch.UnsetSession();
            int_Created_By.AdvancedSearch.UnsetSession();
            int_Modified_By.AdvancedSearch.UnsetSession();
            date_Modified.AdvancedSearch.UnsetSession();
            bit_IsDeleted.AdvancedSearch.UnsetSession();
            str_CardHolder_Address.AdvancedSearch.UnsetSession();
            str_CH_City.AdvancedSearch.UnsetSession();
            str_CH_Zip.AdvancedSearch.UnsetSession();
            int_State.AdvancedSearch.UnsetSession();
            bit_IsAuthDotNet.AdvancedSearch.UnsetSession();
            bit_IsRefund.AdvancedSearch.UnsetSession();
            str_Receipt.AdvancedSearch.UnsetSession();
            str_TransactionNumber.AdvancedSearch.UnsetSession();
            str_OrderId.AdvancedSearch.UnsetSession();
            str_TransactionTime.AdvancedSearch.UnsetSession();
            int_Location_Id.AdvancedSearch.UnsetSession();
            str_Enrollment_Id.AdvancedSearch.UnsetSession();
            str_Notes.AdvancedSearch.UnsetSession();
            str_Payment_Note.AdvancedSearch.UnsetSession();
            int_Package_ID.AdvancedSearch.UnsetSession();
            Package_Name.AdvancedSearch.UnsetSession();
            Price.AdvancedSearch.UnsetSession();
            AssessmentID.AdvancedSearch.UnsetSession();
            course.AdvancedSearch.UnsetSession();
            institution.AdvancedSearch.UnsetSession();
            UniqueIdx.AdvancedSearch.UnsetSession();
        }

        // Restore all search parameters
        protected void RestoreSearchParms() {
            RestoreSearch = true;

            // Restore basic search values
            BasicSearch.Load();

            // Restore advanced search values
            int_Bill_ID.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            str_First_Name.AdvancedSearch.Load();
            str_Last_Name.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            int_Student_ID.AdvancedSearch.Load();
            int_Payment_Method.AdvancedSearch.Load();
            date_Paid.AdvancedSearch.Load();
            str_ApprovalCode.AdvancedSearch.Load();
            Payment_Number.AdvancedSearch.Load();
            Pricelist.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            str_Amount.AdvancedSearch.Load();
            str_CC_Holder_Name.AdvancedSearch.Load();
            str_CC_Number.AdvancedSearch.Load();
            int_CC_ExpMonth.AdvancedSearch.Load();
            int_CC_ExpYear.AdvancedSearch.Load();
            int_CC_Type.AdvancedSearch.Load();
            str_Card_Id.AdvancedSearch.Load();
            str_CC_ValidationNum.AdvancedSearch.Load();
            str_reference.AdvancedSearch.Load();
            str_Amount_Pay.AdvancedSearch.Load();
            mny_Running_Payments.AdvancedSearch.Load();
            mny_Running_Balance.AdvancedSearch.Load();
            str_Payment_Reference.AdvancedSearch.Load();
            int_Accepted_By.AdvancedSearch.Load();
            str_Check_Number.AdvancedSearch.Load();
            bit_Is_Check_Deposited.AdvancedSearch.Load();
            str_Adjustment_Type.AdvancedSearch.Load();
            str_Adjust_Sub_Type.AdvancedSearch.Load();
            bit_Archive.AdvancedSearch.Load();
            int_Created_By.AdvancedSearch.Load();
            int_Modified_By.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            bit_IsDeleted.AdvancedSearch.Load();
            str_CardHolder_Address.AdvancedSearch.Load();
            str_CH_City.AdvancedSearch.Load();
            str_CH_Zip.AdvancedSearch.Load();
            int_State.AdvancedSearch.Load();
            bit_IsAuthDotNet.AdvancedSearch.Load();
            bit_IsRefund.AdvancedSearch.Load();
            str_Receipt.AdvancedSearch.Load();
            str_TransactionNumber.AdvancedSearch.Load();
            str_OrderId.AdvancedSearch.Load();
            str_TransactionTime.AdvancedSearch.Load();
            int_Location_Id.AdvancedSearch.Load();
            str_Enrollment_Id.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            str_Payment_Note.AdvancedSearch.Load();
            int_Package_ID.AdvancedSearch.Load();
            Package_Name.AdvancedSearch.Load();
            Price.AdvancedSearch.Load();
            AssessmentID.AdvancedSearch.Load();
            course.AdvancedSearch.Load();
            institution.AdvancedSearch.Load();
            UniqueIdx.AdvancedSearch.Load();
        }

        // Set up sort parameters
        protected void SetupSortOrder() {
            // Load default Sorting Order
            if (Command != "json") {
                string defaultSort = NationalID.Expression + " ASC" + ", " + date_Paid.Expression + " ASC"; // Set up default sort
                if (Empty(SessionOrderBy) && !Empty(defaultSort))
                    SessionOrderBy = defaultSort;
            }

            // Check for Ctrl pressed
            bool ctrl = Get<bool>("ctrl");

            // Check for "order" parameter
            if (Get("order", out StringValues sv)) {
                CurrentOrder = sv.ToString();
                CurrentOrderType = Get("ordertype");
                UpdateSort(NationalID, ctrl); // NationalID
                UpdateSort(str_First_Name, ctrl); // str_First_Name
                UpdateSort(str_Last_Name, ctrl); // str_Last_Name
                UpdateSort(date_Paid, ctrl); // date_Paid
                UpdateSort(str_ApprovalCode, ctrl); // str_ApprovalCode
                UpdateSort(Payment_Number, ctrl); // Payment_Number
                UpdateSort(Pricelist, ctrl); // Pricelist
                UpdateSort(str_Amount_Pay, ctrl); // str_Amount_Pay
                UpdateSort(mny_Running_Payments, ctrl); // mny_Running_Payments
                UpdateSort(mny_Running_Balance, ctrl); // mny_Running_Balance
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
                    int_Bill_ID.Sort = "";
                    NationalID.Sort = "";
                    str_First_Name.Sort = "";
                    str_Last_Name.Sort = "";
                    str_Username.Sort = "";
                    int_Student_ID.Sort = "";
                    int_Payment_Method.Sort = "";
                    date_Paid.Sort = "";
                    str_ApprovalCode.Sort = "";
                    Payment_Number.Sort = "";
                    Pricelist.Sort = "";
                    date_Created.Sort = "";
                    str_Amount.Sort = "";
                    str_CC_Holder_Name.Sort = "";
                    str_CC_Number.Sort = "";
                    int_CC_ExpMonth.Sort = "";
                    int_CC_ExpYear.Sort = "";
                    int_CC_Type.Sort = "";
                    str_Card_Id.Sort = "";
                    str_CC_ValidationNum.Sort = "";
                    str_reference.Sort = "";
                    str_Amount_Pay.Sort = "";
                    mny_Running_Payments.Sort = "";
                    mny_Running_Balance.Sort = "";
                    str_Payment_Reference.Sort = "";
                    int_Accepted_By.Sort = "";
                    str_Check_Number.Sort = "";
                    bit_Is_Check_Deposited.Sort = "";
                    str_Adjustment_Type.Sort = "";
                    str_Adjust_Sub_Type.Sort = "";
                    bit_Archive.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    date_Modified.Sort = "";
                    bit_IsDeleted.Sort = "";
                    str_CardHolder_Address.Sort = "";
                    str_CH_City.Sort = "";
                    str_CH_Zip.Sort = "";
                    int_State.Sort = "";
                    bit_IsAuthDotNet.Sort = "";
                    bit_IsRefund.Sort = "";
                    str_Receipt.Sort = "";
                    str_TransactionNumber.Sort = "";
                    str_OrderId.Sort = "";
                    str_TransactionTime.Sort = "";
                    int_Location_Id.Sort = "";
                    str_Enrollment_Id.Sort = "";
                    str_Notes.Sort = "";
                    str_Payment_Note.Sort = "";
                    int_Package_ID.Sort = "";
                    Package_Name.Sort = "";
                    Price.Sort = "";
                    AssessmentID.Sort = "";
                    course.Sort = "";
                    institution.Sort = "";
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

            // "detail_tblStudentEnrollment"
            item = ListOptions.Add("detail_tblStudentEnrollment");
            item.CssClass = "text-nowrap";
            item.Visible = Security.AllowList(CurrentProjectID + "tblStudentEnrollment");
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.ShowInButtonGroup = false;
            tblStudentEnrollmentGrid = Resolve("TblStudentEnrollmentGrid")!;

            // "detail_qryBillingDetails_v2"
            item = ListOptions.Add("detail_qryBillingDetails_v2");
            item.CssClass = "text-nowrap";
            item.Visible = Security.AllowList(CurrentProjectID + "qryBillingDetails_v2");
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.ShowInButtonGroup = false;
            qryBillingDetailsV2Grid = Resolve("QryBillingDetailsV2Grid")!;

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
            _pages.Add("tblStudentEnrollment");
            _pages.Add("qryBillingDetails_v2");
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
            isVisible = Security.CanView && ShowOptionLink("view");
            if (isVisible) {
                if (ModalView && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-table=""tblBillingInfo"" data-caption=""{viewcaption}"" data-ew-action=""modal"" data-action=""view"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(ViewUrl)) + "\" data-btn=\"null\">" + Language.Phrase("ViewLink") + "</a>");
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
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblBillingInfo"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblBillingInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblBillingInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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

            // "detail_tblStudentEnrollment"
            listOption = ListOptions["detail_tblStudentEnrollment"];
            isVisible = Security.AllowList(CurrentProjectID + "tblStudentEnrollment") && ShowOptionLink();
            if (isVisible) {
                string caption, title, url;
                var body = Language.Phrase("DetailLink") + Language.TablePhrase("tblStudentEnrollment", "TblCaption");
                body = "<a class=\"btn btn-default ew-row-link ew-detail" + (ListOptions.UseDropDownButton ? " dropdown-toggle" : "") + "\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblStudentEnrollmentList?" + Config.TableShowMaster + "=tblBillingInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "")) + "\">" + body + "</a>";
                string links = "";
                detailPage = Resolve("TblStudentEnrollmentGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink", null);
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = GetViewUrl(Config.TableShowDetail + "=tblStudentEnrollment");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailViewTblVar))
                        detailViewTblVar += ",";
                    detailViewTblVar += "tblStudentEnrollment";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink", null);
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = GetEditUrl(Config.TableShowDetail + "=tblStudentEnrollment");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailEditTblVar))
                        detailEditTblVar += ",";
                    detailEditTblVar += "tblStudentEnrollment";
                }
                if (!Empty(links)) {
                    body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-detail\" data-bs-toggle=\"dropdown\"></button>";
                    body += "<ul class=\"dropdown-menu\">" + links + "</ul>";
                } else {
                    body = Regex.Replace(body, @"\b\s+dropdown-toggle\b", "");
                }
                body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
                listOption?.SetBody(body);
                if (ShowMultipleDetails)
                    listOption?.SetVisible(false);
            }

            // "detail_qryBillingDetails_v2"
            listOption = ListOptions["detail_qryBillingDetails_v2"];
            isVisible = Security.AllowList(CurrentProjectID + "qryBillingDetails_v2") && ShowOptionLink();
            if (isVisible) {
                string caption, title, url;
                var body = Language.Phrase("DetailLink") + Language.TablePhrase("qryBillingDetails_v2", "TblCaption");
                body = "<a class=\"btn btn-default ew-row-link ew-detail" + (ListOptions.UseDropDownButton ? " dropdown-toggle" : "") + "\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("QryBillingDetailsV2List?" + Config.TableShowMaster + "=tblBillingInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "")) + "\">" + body + "</a>";
                string links = "";
                detailPage = Resolve("QryBillingDetailsV2Grid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink", null);
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = GetViewUrl(Config.TableShowDetail + "=qryBillingDetails_v2");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailViewTblVar))
                        detailViewTblVar += ",";
                    detailViewTblVar += "qryBillingDetails_v2";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink", null);
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = GetEditUrl(Config.TableShowDetail + "=qryBillingDetails_v2");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailEditTblVar))
                        detailEditTblVar += ",";
                    detailEditTblVar += "qryBillingDetails_v2";
                }
                if (!Empty(links)) {
                    body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-detail\" data-bs-toggle=\"dropdown\"></button>";
                    body += "<ul class=\"dropdown-menu\">" + links + "</ul>";
                } else {
                    body = Regex.Replace(body, @"\b\s+dropdown-toggle\b", "");
                }
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
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(int_Bill_ID.CurrentValue) + "\"></div>");
            RenderListOptionsExt();

            // Call ListOptions Rendered event
            ListOptionsRendered();
        }

        // Render list options (extensions)
        protected void RenderListOptionsExt() {
            // Preview extension
            string links = "", btngrps = "", sqlwrk, detaillnk, link, url, btngrp, caption, title, icon, detailFilter;
            List<string> masterKeys = new ();
            ListOption? option;
            dynamic? detailTbl = null, detailPage = null;
            masterKeys.Clear();
            sqlwrk = KeyFilter(Resolve("tblStudentEnrollment")!.NationalID, NationalID.CurrentValue, NationalID.DataType, DbId);
            masterKeys.Add(ConvertToString(NationalID.CurrentValue));

            // Column "detail_tblStudentEnrollment"
            if ((DetailPages?["tblStudentEnrollment"]?.Visible ?? false) && Security.AllowList(CurrentProjectID + "tblStudentEnrollment")) {
                link = "";
                option = ListOptions["detail_tblStudentEnrollment"];
                url = "TblStudentEnrollmentPreview?t=tblBillingInfo&f=" + Encrypt(sqlwrk + "|" + String.Join("|", masterKeys));
                btngrp = "<div data-table=\"tblStudentEnrollment\" data-url=\"" + AppPath(url) + "\" class=\"ew-detail-btn-group d-none\">";
                if (Security.AllowList(CurrentProjectID + "tblBillingInfo")) {
                    string label = Language.TablePhrase("tblStudentEnrollment", "TblCaption");
                    link = "<button class=\"nav-link\" data-bs-toggle=\"tab\" data-table=\"tblStudentEnrollment\" data-url=\"" + AppPath(url) + "\" type=\"button\" role=\"tab\" aria-selected=\"false\">" + label + "</button>";
                    detaillnk = AppPath("TblStudentEnrollmentList?" + Config.TableShowMaster + "=tblBillingInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "");
                    title = Language.TablePhrase("tblStudentEnrollment", "TblCaption");
                    caption = Language.Phrase("MasterDetailListLink");
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(detaillnk) + "\">" + caption + "</a>";
                }
                detailPage = Resolve("TblStudentEnrollmentGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink");
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = AppPath(GetViewUrl(Config.TableShowDetail + "=tblStudentEnrollment"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink");
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = AppPath(GetEditUrl(Config.TableShowDetail + "=tblStudentEnrollment"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                btngrp += "</div>";
                if (link != "") {
                    link = "<li class=\"nav-item\">" + btngrp + link + "</li>";  // Note: Place btngrp before link
                    links += link;
                    option?.AddBody("<div class=\"ew-preview d-none\">" + link + "</div>");
                }
            }
            masterKeys.Clear();
            sqlwrk = KeyFilter(Resolve("qryBillingDetails_v2")!.NationalID, NationalID.CurrentValue, NationalID.DataType, DbId);
            masterKeys.Add(ConvertToString(NationalID.CurrentValue));

            // Column "detail_qryBillingDetails_v2"
            if ((DetailPages?["qryBillingDetails_v2"]?.Visible ?? false) && Security.AllowList(CurrentProjectID + "qryBillingDetails_v2")) {
                link = "";
                option = ListOptions["detail_qryBillingDetails_v2"];
                url = "QryBillingDetailsV2Preview?t=tblBillingInfo&f=" + Encrypt(sqlwrk + "|" + String.Join("|", masterKeys));
                btngrp = "<div data-table=\"qryBillingDetails_v2\" data-url=\"" + AppPath(url) + "\" class=\"ew-detail-btn-group d-none\">";
                if (Security.AllowList(CurrentProjectID + "tblBillingInfo")) {
                    string label = Language.TablePhrase("qryBillingDetails_v2", "TblCaption");
                    link = "<button class=\"nav-link\" data-bs-toggle=\"tab\" data-table=\"qryBillingDetails_v2\" data-url=\"" + AppPath(url) + "\" type=\"button\" role=\"tab\" aria-selected=\"false\">" + label + "</button>";
                    detaillnk = AppPath("QryBillingDetailsV2List?" + Config.TableShowMaster + "=tblBillingInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "");
                    title = Language.TablePhrase("qryBillingDetails_v2", "TblCaption");
                    caption = Language.Phrase("MasterDetailListLink");
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(detaillnk) + "\">" + caption + "</a>";
                }
                detailPage = Resolve("QryBillingDetailsV2Grid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink");
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = AppPath(GetViewUrl(Config.TableShowDetail + "=qryBillingDetails_v2"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink");
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = AppPath(GetEditUrl(Config.TableShowDetail + "=qryBillingDetails_v2"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                btngrp += "</div>";
                if (link != "") {
                    link = "<li class=\"nav-item\">" + btngrp + link + "</li>";  // Note: Place btngrp before link
                    links += link;
                    option?.AddBody("<div class=\"ew-preview d-none\">" + link + "</div>");
                }
            }

            // Add row attributes for expandable row
            if (RowType == RowType.View) {
                RowAttrs["data-widget"] = "expandable-table";
                RowAttrs["aria-expanded"] = "false";
            }

            // Column "preview"
            option = ListOptions["preview"];
            if (option == null) { // Add preview column
                option = ListOptions.Add("preview");
                option.OnLeft = MultiColumnLayout == "cards" ? false : true;
                option.MoveTo(option.OnLeft ? ListOptions.GetItemIndex("checkbox") + 1 : ListOptions.GetItemIndex("checkbox"));
                option.Visible = !(IsExport() || IsGridAdd || IsGridEdit || IsMultiEdit);
                option.ShowInDropDown = false;
                option.ShowInButtonGroup = false;
            }
            icon = "fa-solid fa-caret-right"; // Right
            if (SameText(GetPropertyValue(this, "MultiColumnLayout"), "table")) {
                option.CssStyle = "width: 1%;";
                if (!option.OnLeft)
                    icon = Regex.Replace(icon, @"\bright\b", "left");
            }
            if (IsRTL) { // Reverse
                if (Regex.IsMatch(icon, @"\bleft\b"))
                    icon = Regex.Replace(icon, @"\bleft\b", "right");
                else if (Regex.IsMatch(icon, @"\bright\b"))
                    icon = Regex.Replace(icon, @"\bright\b", "left");
            }
            option.SetBody("<i role=\"button\" class=\"ew-preview-btn expandable-table-caret ew-icon " + icon + "\"></i>" +
                "<div class=\"ew-preview d-none\">" + links + "</div>");
            if (option.Visible)
                option.Visible = links != "";

            // Column "details" (Multiple details)
            option = ListOptions["details"];
            option?.AddBody("<div class=\"ew-preview d-none\">" + links + "</div>");
            if (option?.Visible ?? false)
                option.Visible = links != "";
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
                item.Body = $@"<a class=""ew-add-edit ew-add"" title=""{addTitle}"" data-table=""tblBillingInfo"" data-caption=""{addTitle}"" data-ew-action=""modal"" data-action=""add"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(AddUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("AddLink") + "</a>";
            else
                item.Body = $@"<a class=""ew-add-edit ew-add"" title=""{addTitle}"" data-caption=""{addTitle}"" href=""" + HtmlEncode(AppPath(AddUrl)) + "\">" + Language.Phrase("AddLink") + "</a>";
            item.Visible = AddUrl != "" && Security.CanAdd;
            item = option.Add("gridadd");
            string gridAddTitle = Language.Phrase("GridAddLink", true);
            if (ModalGridAdd && !IsMobile())
                item.Body = $@"<button class=""ew-add-edit ew-grid-add"" title=""{gridAddTitle}"" data-caption=""{gridAddTitle}"" data-ew-action=""modal"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-action=\"add\" data-position=\"top\" data-btn=\"AddBtn\" data-url=\"" + HtmlEncode(AppPath(GridAddUrl)) + "\">" + Language.Phrase("GridAddLink") + "</button>";
            else
                item.Body = $@"<a class=""ew-add-edit ew-grid-add"" title=""{gridAddTitle}"" data-caption=""{gridAddTitle}"" href=""" + HtmlEncode(AppPath(GridAddUrl)) + "\">" + Language.Phrase("GridAddLink") + "</a>";
            item.Visible = GridAddUrl != "" && Security.CanAdd;
            option = options["detail"];
            var detailTableLink = "";
            string caption, title;
            item = option.Add("detailadd_tblStudentEnrollment");
            tblStudentEnrollment = Resolve("tblStudentEnrollment")!;
            if (tblStudentEnrollment != null) {
                caption = Language.Phrase("Add") + "&nbsp;" + Caption + "/" + tblStudentEnrollment.Caption;
                title = Language.Phrase("Add", true) + "&nbsp;" + Caption + "/" + tblStudentEnrollment.Caption;
                item.Body = "<a class=\"ew-detail-add-group ew-detail-add\" title=\"" + title + "\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(GetAddUrl(Config.TableShowDetail + "=tblStudentEnrollment"))) + "\">" + caption + "</a>";
                item.Visible = (tblStudentEnrollment.DetailAdd && Security.AllowAdd(CurrentProjectID + "tblBillingInfo") && Security.CanAdd);
                if (item.Visible) {
                    if (detailTableLink != "")
                        detailTableLink += ",";
                    detailTableLink += "tblStudentEnrollment";
                }
            }
            item = option.Add("detailadd_qryBillingDetails_v2");
            qryBillingDetailsV2 = Resolve("qryBillingDetails_v2")!;
            if (qryBillingDetailsV2 != null) {
                caption = Language.Phrase("Add") + "&nbsp;" + Caption + "/" + qryBillingDetailsV2.Caption;
                title = Language.Phrase("Add", true) + "&nbsp;" + Caption + "/" + qryBillingDetailsV2.Caption;
                item.Body = "<a class=\"ew-detail-add-group ew-detail-add\" title=\"" + title + "\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(GetAddUrl(Config.TableShowDetail + "=qryBillingDetails_v2"))) + "\">" + caption + "</a>";
                item.Visible = (qryBillingDetailsV2.DetailAdd && Security.AllowAdd(CurrentProjectID + "tblBillingInfo") && Security.CanAdd);
                if (item.Visible) {
                    if (detailTableLink != "")
                        detailTableLink += ",";
                    detailTableLink += "qryBillingDetails_v2";
                }
            }

            // Add multiple details
            if (ShowMultipleDetails) {
                item = option.Add("detailsadd");
                string url = GetAddUrl(Config.TableShowDetail + "=" + detailTableLink);
                caption = Language.Phrase("AddMasterDetailLink");
                title = Language.Phrase("AddMasterDetailLink", true);
                item.Body = "<a class=\"ew-detail-add-group ew-detail-add\" title=\"" + title + "\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a>";
                item.Visible = (detailTableLink != "" && Security.CanAdd);

                // Hide single master/detail items
                detailTableLink?.Split(',').ToList().ForEach(s => option["detailadd_" + s]?.SetVisible(false));
            }
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblBillingInfolist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblBillingInfosrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblBillingInfosrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblBillingInfolist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                if (IsGridAdd) {
                    if (MultiColumnLayout == "table") { // Check if table layout
                        if (AllowAddDeleteRow) {
                            // Add add blank row
                            option = options["addedit"];
                            option.UseDropDownButton = false;
                            item = option.Add("addblankrow");
                            item.Body = "<a type=\"button\" class=\"ew-add-edit ew-add-blank-row\" title=\"" + Language.Phrase("AddBlankRow", true) + "\" data-caption=\"" + Language.Phrase("AddBlankRow", true) + "\" data-ew-action=\"add-grid-row\">" + Language.Phrase("AddBlankRow") + "</a>";
                            item.Visible = Security.CanAdd;
                        }
                    }
                    if (!(ModalGridAdd && !IsMobile())) {
                        option = options["action"];
                        option.UseDropDownButton = false;
                        // Add grid insert
                        item = option.Add("gridinsert");
                        item.Body = "<button class=\"ew-action ew-grid-insert\" title=\"" + Language.Phrase("GridInsertLink", true) + "\" data-caption=\"" + Language.Phrase("GridInsertLink", true) + "\" form=\"ftblBillingInfolist\" formaction=\"" + AppPath(PageName) + "\">" + Language.Phrase("GridInsertLink") + "</button>";
                        // Add grid cancel
                        item = option.Add("gridcancel");
                        item.Body = "<a type=\"button\" class=\"ew-action ew-grid-cancel\" title=\"" + Language.Phrase("GridCancelLink", true) + "\" data-caption=\"" + Language.Phrase("GridCancelLink", true) + "\" href=\"" + HtmlEncode(AppPath(AddMasterUrl(PageUrl + "action=cancel"))) + "\">" + Language.Phrase("GridCancelLink") + "</a>";
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
                    RowAttrs.Add("id", "r0_tblBillingInfo");
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
            if (IsGridAdd && EventCancelled && !CurrentForm!.HasValue(FormBlankRowName)) // Insert failed
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblBillingInfoList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblBillingInfoList.RowCount) + "_tblBillingInfo");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblBillingInfoList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblBillingInfoList.RowType == RowType.Add || IsEdit && tblBillingInfoList.RowType == RowType.Edit) // Inline-Add/Edit row
                RowAttrs.AppendClass("table-active");

            // Render row
            await RenderRow();

            // Render list options
            await RenderListOptions();
        }

        // Load default values
        protected void LoadDefaultValues() {
            str_Username.DefaultValue = CurrentUserID();
            str_Username.OldValue = str_Username.DefaultValue;
            bit_IsDeleted.DefaultValue = bit_IsDeleted.GetDefault(); // DN
            bit_IsDeleted.OldValue = bit_IsDeleted.DefaultValue;
            bit_IsAuthDotNet.DefaultValue = bit_IsAuthDotNet.GetDefault(); // DN
            bit_IsAuthDotNet.OldValue = bit_IsAuthDotNet.DefaultValue;
            bit_IsRefund.DefaultValue = bit_IsRefund.GetDefault(); // DN
            bit_IsRefund.OldValue = bit_IsRefund.DefaultValue;
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
            if (Query.ContainsKey("v_NationalID"))
                NationalID.AdvancedSearch.SearchCondition = Get("v_NationalID");
            if (Query.ContainsKey("y_NationalID"))
                NationalID.AdvancedSearch.SearchValue2 = Get("y_NationalID");
            if (!Empty(NationalID.AdvancedSearch.SearchValue2) && Command == "")
                Command = "search";
            if (Query.ContainsKey("w_NationalID"))
                NationalID.AdvancedSearch.SearchOperator2 = Get("w_NationalID");

            // str_First_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_First_Name"))
                    str_First_Name.AdvancedSearch.SearchValue = Get("x_str_First_Name");
                else
                    str_First_Name.AdvancedSearch.SearchValue = Get("str_First_Name"); // Default Value // DN
            if (!Empty(str_First_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_First_Name"))
                str_First_Name.AdvancedSearch.SearchOperator = Get("z_str_First_Name");

            // str_Last_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Last_Name"))
                    str_Last_Name.AdvancedSearch.SearchValue = Get("x_str_Last_Name");
                else
                    str_Last_Name.AdvancedSearch.SearchValue = Get("str_Last_Name"); // Default Value // DN
            if (!Empty(str_Last_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Last_Name"))
                str_Last_Name.AdvancedSearch.SearchOperator = Get("z_str_Last_Name");

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

            // int_Payment_Method
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Payment_Method"))
                    int_Payment_Method.AdvancedSearch.SearchValue = Get("x_int_Payment_Method");
                else
                    int_Payment_Method.AdvancedSearch.SearchValue = Get("int_Payment_Method"); // Default Value // DN
            if (!Empty(int_Payment_Method.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Payment_Method"))
                int_Payment_Method.AdvancedSearch.SearchOperator = Get("z_int_Payment_Method");

            // date_Paid
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Paid"))
                    date_Paid.AdvancedSearch.SearchValue = Get("x_date_Paid");
                else
                    date_Paid.AdvancedSearch.SearchValue = Get("date_Paid"); // Default Value // DN
            if (!Empty(date_Paid.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Paid"))
                date_Paid.AdvancedSearch.SearchOperator = Get("z_date_Paid");

            // str_ApprovalCode
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_ApprovalCode"))
                    str_ApprovalCode.AdvancedSearch.SearchValue = Get("x_str_ApprovalCode");
                else
                    str_ApprovalCode.AdvancedSearch.SearchValue = Get("str_ApprovalCode"); // Default Value // DN
            if (!Empty(str_ApprovalCode.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_ApprovalCode"))
                str_ApprovalCode.AdvancedSearch.SearchOperator = Get("z_str_ApprovalCode");

            // Payment_Number
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Payment_Number"))
                    Payment_Number.AdvancedSearch.SearchValue = Get("x_Payment_Number");
                else
                    Payment_Number.AdvancedSearch.SearchValue = Get("Payment_Number"); // Default Value // DN
            if (!Empty(Payment_Number.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Payment_Number"))
                Payment_Number.AdvancedSearch.SearchOperator = Get("z_Payment_Number");

            // Pricelist
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Pricelist"))
                    Pricelist.AdvancedSearch.SearchValue = Get("x_Pricelist");
                else
                    Pricelist.AdvancedSearch.SearchValue = Get("Pricelist"); // Default Value // DN
            if (!Empty(Pricelist.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Pricelist"))
                Pricelist.AdvancedSearch.SearchOperator = Get("z_Pricelist");

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

            // str_Amount
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Amount"))
                    str_Amount.AdvancedSearch.SearchValue = Get("x_str_Amount");
                else
                    str_Amount.AdvancedSearch.SearchValue = Get("str_Amount"); // Default Value // DN
            if (!Empty(str_Amount.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Amount"))
                str_Amount.AdvancedSearch.SearchOperator = Get("z_str_Amount");

            // str_CC_Holder_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CC_Holder_Name"))
                    str_CC_Holder_Name.AdvancedSearch.SearchValue = Get("x_str_CC_Holder_Name");
                else
                    str_CC_Holder_Name.AdvancedSearch.SearchValue = Get("str_CC_Holder_Name"); // Default Value // DN
            if (!Empty(str_CC_Holder_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CC_Holder_Name"))
                str_CC_Holder_Name.AdvancedSearch.SearchOperator = Get("z_str_CC_Holder_Name");

            // str_CC_Number
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CC_Number"))
                    str_CC_Number.AdvancedSearch.SearchValue = Get("x_str_CC_Number");
                else
                    str_CC_Number.AdvancedSearch.SearchValue = Get("str_CC_Number"); // Default Value // DN
            if (!Empty(str_CC_Number.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CC_Number"))
                str_CC_Number.AdvancedSearch.SearchOperator = Get("z_str_CC_Number");

            // int_CC_ExpMonth
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_CC_ExpMonth"))
                    int_CC_ExpMonth.AdvancedSearch.SearchValue = Get("x_int_CC_ExpMonth");
                else
                    int_CC_ExpMonth.AdvancedSearch.SearchValue = Get("int_CC_ExpMonth"); // Default Value // DN
            if (!Empty(int_CC_ExpMonth.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_CC_ExpMonth"))
                int_CC_ExpMonth.AdvancedSearch.SearchOperator = Get("z_int_CC_ExpMonth");

            // int_CC_ExpYear
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_CC_ExpYear"))
                    int_CC_ExpYear.AdvancedSearch.SearchValue = Get("x_int_CC_ExpYear");
                else
                    int_CC_ExpYear.AdvancedSearch.SearchValue = Get("int_CC_ExpYear"); // Default Value // DN
            if (!Empty(int_CC_ExpYear.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_CC_ExpYear"))
                int_CC_ExpYear.AdvancedSearch.SearchOperator = Get("z_int_CC_ExpYear");

            // int_CC_Type
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_CC_Type"))
                    int_CC_Type.AdvancedSearch.SearchValue = Get("x_int_CC_Type");
                else
                    int_CC_Type.AdvancedSearch.SearchValue = Get("int_CC_Type"); // Default Value // DN
            if (!Empty(int_CC_Type.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_CC_Type"))
                int_CC_Type.AdvancedSearch.SearchOperator = Get("z_int_CC_Type");

            // str_Card_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Card_Id"))
                    str_Card_Id.AdvancedSearch.SearchValue = Get("x_str_Card_Id");
                else
                    str_Card_Id.AdvancedSearch.SearchValue = Get("str_Card_Id"); // Default Value // DN
            if (!Empty(str_Card_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Card_Id"))
                str_Card_Id.AdvancedSearch.SearchOperator = Get("z_str_Card_Id");

            // str_CC_ValidationNum
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CC_ValidationNum"))
                    str_CC_ValidationNum.AdvancedSearch.SearchValue = Get("x_str_CC_ValidationNum");
                else
                    str_CC_ValidationNum.AdvancedSearch.SearchValue = Get("str_CC_ValidationNum"); // Default Value // DN
            if (!Empty(str_CC_ValidationNum.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CC_ValidationNum"))
                str_CC_ValidationNum.AdvancedSearch.SearchOperator = Get("z_str_CC_ValidationNum");

            // str_reference
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_reference"))
                    str_reference.AdvancedSearch.SearchValue = Get("x_str_reference");
                else
                    str_reference.AdvancedSearch.SearchValue = Get("str_reference"); // Default Value // DN
            if (!Empty(str_reference.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_reference"))
                str_reference.AdvancedSearch.SearchOperator = Get("z_str_reference");

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

            // mny_Running_Payments
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_mny_Running_Payments"))
                    mny_Running_Payments.AdvancedSearch.SearchValue = Get("x_mny_Running_Payments");
                else
                    mny_Running_Payments.AdvancedSearch.SearchValue = Get("mny_Running_Payments"); // Default Value // DN
            if (!Empty(mny_Running_Payments.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_mny_Running_Payments"))
                mny_Running_Payments.AdvancedSearch.SearchOperator = Get("z_mny_Running_Payments");

            // mny_Running_Balance
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_mny_Running_Balance"))
                    mny_Running_Balance.AdvancedSearch.SearchValue = Get("x_mny_Running_Balance");
                else
                    mny_Running_Balance.AdvancedSearch.SearchValue = Get("mny_Running_Balance"); // Default Value // DN
            if (!Empty(mny_Running_Balance.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_mny_Running_Balance"))
                mny_Running_Balance.AdvancedSearch.SearchOperator = Get("z_mny_Running_Balance");

            // str_Payment_Reference
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Payment_Reference"))
                    str_Payment_Reference.AdvancedSearch.SearchValue = Get("x_str_Payment_Reference");
                else
                    str_Payment_Reference.AdvancedSearch.SearchValue = Get("str_Payment_Reference"); // Default Value // DN
            if (!Empty(str_Payment_Reference.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Payment_Reference"))
                str_Payment_Reference.AdvancedSearch.SearchOperator = Get("z_str_Payment_Reference");

            // int_Accepted_By
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Accepted_By"))
                    int_Accepted_By.AdvancedSearch.SearchValue = Get("x_int_Accepted_By");
                else
                    int_Accepted_By.AdvancedSearch.SearchValue = Get("int_Accepted_By"); // Default Value // DN
            if (!Empty(int_Accepted_By.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Accepted_By"))
                int_Accepted_By.AdvancedSearch.SearchOperator = Get("z_int_Accepted_By");

            // str_Check_Number
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Check_Number"))
                    str_Check_Number.AdvancedSearch.SearchValue = Get("x_str_Check_Number");
                else
                    str_Check_Number.AdvancedSearch.SearchValue = Get("str_Check_Number"); // Default Value // DN
            if (!Empty(str_Check_Number.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Check_Number"))
                str_Check_Number.AdvancedSearch.SearchOperator = Get("z_str_Check_Number");

            // bit_Is_Check_Deposited
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_Is_Check_Deposited"))
                    bit_Is_Check_Deposited.AdvancedSearch.SearchValue = Get("x_bit_Is_Check_Deposited");
                else
                    bit_Is_Check_Deposited.AdvancedSearch.SearchValue = Get("bit_Is_Check_Deposited"); // Default Value // DN
            if (!Empty(bit_Is_Check_Deposited.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_Is_Check_Deposited"))
                bit_Is_Check_Deposited.AdvancedSearch.SearchOperator = Get("z_bit_Is_Check_Deposited");

            // str_Adjustment_Type
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Adjustment_Type"))
                    str_Adjustment_Type.AdvancedSearch.SearchValue = Get("x_str_Adjustment_Type");
                else
                    str_Adjustment_Type.AdvancedSearch.SearchValue = Get("str_Adjustment_Type"); // Default Value // DN
            if (!Empty(str_Adjustment_Type.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Adjustment_Type"))
                str_Adjustment_Type.AdvancedSearch.SearchOperator = Get("z_str_Adjustment_Type");

            // str_Adjust_Sub_Type
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Adjust_Sub_Type"))
                    str_Adjust_Sub_Type.AdvancedSearch.SearchValue = Get("x_str_Adjust_Sub_Type");
                else
                    str_Adjust_Sub_Type.AdvancedSearch.SearchValue = Get("str_Adjust_Sub_Type"); // Default Value // DN
            if (!Empty(str_Adjust_Sub_Type.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Adjust_Sub_Type"))
                str_Adjust_Sub_Type.AdvancedSearch.SearchOperator = Get("z_str_Adjust_Sub_Type");

            // bit_Archive
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_Archive"))
                    bit_Archive.AdvancedSearch.SearchValue = Get("x_bit_Archive");
                else
                    bit_Archive.AdvancedSearch.SearchValue = Get("bit_Archive"); // Default Value // DN
            if (!Empty(bit_Archive.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_Archive"))
                bit_Archive.AdvancedSearch.SearchOperator = Get("z_bit_Archive");

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

            // str_CardHolder_Address
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CardHolder_Address"))
                    str_CardHolder_Address.AdvancedSearch.SearchValue = Get("x_str_CardHolder_Address");
                else
                    str_CardHolder_Address.AdvancedSearch.SearchValue = Get("str_CardHolder_Address"); // Default Value // DN
            if (!Empty(str_CardHolder_Address.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CardHolder_Address"))
                str_CardHolder_Address.AdvancedSearch.SearchOperator = Get("z_str_CardHolder_Address");

            // str_CH_City
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CH_City"))
                    str_CH_City.AdvancedSearch.SearchValue = Get("x_str_CH_City");
                else
                    str_CH_City.AdvancedSearch.SearchValue = Get("str_CH_City"); // Default Value // DN
            if (!Empty(str_CH_City.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CH_City"))
                str_CH_City.AdvancedSearch.SearchOperator = Get("z_str_CH_City");

            // str_CH_Zip
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CH_Zip"))
                    str_CH_Zip.AdvancedSearch.SearchValue = Get("x_str_CH_Zip");
                else
                    str_CH_Zip.AdvancedSearch.SearchValue = Get("str_CH_Zip"); // Default Value // DN
            if (!Empty(str_CH_Zip.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CH_Zip"))
                str_CH_Zip.AdvancedSearch.SearchOperator = Get("z_str_CH_Zip");

            // int_State
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_State"))
                    int_State.AdvancedSearch.SearchValue = Get("x_int_State");
                else
                    int_State.AdvancedSearch.SearchValue = Get("int_State"); // Default Value // DN
            if (!Empty(int_State.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_State"))
                int_State.AdvancedSearch.SearchOperator = Get("z_int_State");

            // bit_IsAuthDotNet
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_IsAuthDotNet"))
                    bit_IsAuthDotNet.AdvancedSearch.SearchValue = Get("x_bit_IsAuthDotNet");
                else
                    bit_IsAuthDotNet.AdvancedSearch.SearchValue = Get("bit_IsAuthDotNet"); // Default Value // DN
            if (!Empty(bit_IsAuthDotNet.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_IsAuthDotNet"))
                bit_IsAuthDotNet.AdvancedSearch.SearchOperator = Get("z_bit_IsAuthDotNet");

            // bit_IsRefund
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_IsRefund"))
                    bit_IsRefund.AdvancedSearch.SearchValue = Get("x_bit_IsRefund");
                else
                    bit_IsRefund.AdvancedSearch.SearchValue = Get("bit_IsRefund"); // Default Value // DN
            if (!Empty(bit_IsRefund.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_IsRefund"))
                bit_IsRefund.AdvancedSearch.SearchOperator = Get("z_bit_IsRefund");

            // str_Receipt
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Receipt"))
                    str_Receipt.AdvancedSearch.SearchValue = Get("x_str_Receipt");
                else
                    str_Receipt.AdvancedSearch.SearchValue = Get("str_Receipt"); // Default Value // DN
            if (!Empty(str_Receipt.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Receipt"))
                str_Receipt.AdvancedSearch.SearchOperator = Get("z_str_Receipt");

            // str_TransactionNumber
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_TransactionNumber"))
                    str_TransactionNumber.AdvancedSearch.SearchValue = Get("x_str_TransactionNumber");
                else
                    str_TransactionNumber.AdvancedSearch.SearchValue = Get("str_TransactionNumber"); // Default Value // DN
            if (!Empty(str_TransactionNumber.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_TransactionNumber"))
                str_TransactionNumber.AdvancedSearch.SearchOperator = Get("z_str_TransactionNumber");

            // str_OrderId
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_OrderId"))
                    str_OrderId.AdvancedSearch.SearchValue = Get("x_str_OrderId");
                else
                    str_OrderId.AdvancedSearch.SearchValue = Get("str_OrderId"); // Default Value // DN
            if (!Empty(str_OrderId.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_OrderId"))
                str_OrderId.AdvancedSearch.SearchOperator = Get("z_str_OrderId");

            // str_TransactionTime
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_TransactionTime"))
                    str_TransactionTime.AdvancedSearch.SearchValue = Get("x_str_TransactionTime");
                else
                    str_TransactionTime.AdvancedSearch.SearchValue = Get("str_TransactionTime"); // Default Value // DN
            if (!Empty(str_TransactionTime.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_TransactionTime"))
                str_TransactionTime.AdvancedSearch.SearchOperator = Get("z_str_TransactionTime");

            // int_Location_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Location_Id"))
                    int_Location_Id.AdvancedSearch.SearchValue = Get("x_int_Location_Id");
                else
                    int_Location_Id.AdvancedSearch.SearchValue = Get("int_Location_Id"); // Default Value // DN
            if (!Empty(int_Location_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Location_Id"))
                int_Location_Id.AdvancedSearch.SearchOperator = Get("z_int_Location_Id");

            // str_Enrollment_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Enrollment_Id"))
                    str_Enrollment_Id.AdvancedSearch.SearchValue = Get("x_str_Enrollment_Id");
                else
                    str_Enrollment_Id.AdvancedSearch.SearchValue = Get("str_Enrollment_Id"); // Default Value // DN
            if (!Empty(str_Enrollment_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Enrollment_Id"))
                str_Enrollment_Id.AdvancedSearch.SearchOperator = Get("z_str_Enrollment_Id");

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

            // str_Payment_Note
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Payment_Note"))
                    str_Payment_Note.AdvancedSearch.SearchValue = Get("x_str_Payment_Note");
                else
                    str_Payment_Note.AdvancedSearch.SearchValue = Get("str_Payment_Note"); // Default Value // DN
            if (!Empty(str_Payment_Note.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Payment_Note"))
                str_Payment_Note.AdvancedSearch.SearchOperator = Get("z_str_Payment_Note");

            // int_Package_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Package_ID"))
                    int_Package_ID.AdvancedSearch.SearchValue = Get("x_int_Package_ID");
                else
                    int_Package_ID.AdvancedSearch.SearchValue = Get("int_Package_ID"); // Default Value // DN
            if (!Empty(int_Package_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Package_ID"))
                int_Package_ID.AdvancedSearch.SearchOperator = Get("z_int_Package_ID");

            // Package_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Package_Name"))
                    Package_Name.AdvancedSearch.SearchValue = Get("x_Package_Name");
                else
                    Package_Name.AdvancedSearch.SearchValue = Get("Package_Name"); // Default Value // DN
            if (!Empty(Package_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Package_Name"))
                Package_Name.AdvancedSearch.SearchOperator = Get("z_Package_Name");

            // Price
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Price"))
                    Price.AdvancedSearch.SearchValue = Get("x_Price");
                else
                    Price.AdvancedSearch.SearchValue = Get("Price"); // Default Value // DN
            if (!Empty(Price.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Price"))
                Price.AdvancedSearch.SearchOperator = Get("z_Price");

            // AssessmentID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AssessmentID"))
                    AssessmentID.AdvancedSearch.SearchValue = Get("x_AssessmentID");
                else
                    AssessmentID.AdvancedSearch.SearchValue = Get("AssessmentID"); // Default Value // DN
            if (!Empty(AssessmentID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AssessmentID"))
                AssessmentID.AdvancedSearch.SearchOperator = Get("z_AssessmentID");

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

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_NationalID"))
                NationalID.OldValue = CurrentForm.GetValue("o_NationalID");

            // Check field name 'str_First_Name' before field var 'x_str_First_Name'
            val = CurrentForm.HasValue("str_First_Name") ? CurrentForm.GetValue("str_First_Name") : CurrentForm.GetValue("x_str_First_Name");
            if (!str_First_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_First_Name") && !CurrentForm.HasValue("x_str_First_Name")) // DN
                    str_First_Name.Visible = false; // Disable update for API request
                else
                    str_First_Name.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_First_Name"))
                str_First_Name.OldValue = CurrentForm.GetValue("o_str_First_Name");

            // Check field name 'str_Last_Name' before field var 'x_str_Last_Name'
            val = CurrentForm.HasValue("str_Last_Name") ? CurrentForm.GetValue("str_Last_Name") : CurrentForm.GetValue("x_str_Last_Name");
            if (!str_Last_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Last_Name") && !CurrentForm.HasValue("x_str_Last_Name")) // DN
                    str_Last_Name.Visible = false; // Disable update for API request
                else
                    str_Last_Name.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_Last_Name"))
                str_Last_Name.OldValue = CurrentForm.GetValue("o_str_Last_Name");

            // Check field name 'date_Paid' before field var 'x_date_Paid'
            val = CurrentForm.HasValue("date_Paid") ? CurrentForm.GetValue("date_Paid") : CurrentForm.GetValue("x_date_Paid");
            if (!date_Paid.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Paid") && !CurrentForm.HasValue("x_date_Paid")) // DN
                    date_Paid.Visible = false; // Disable update for API request
                else
                    date_Paid.SetFormValue(val, true, validate);
                date_Paid.CurrentValue = UnformatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern);
            }
            date_Paid.OldValue = UnformatDateTime(CurrentForm.GetValue("o_date_Paid"), date_Paid.FormatPattern);

            // Check field name 'str_ApprovalCode' before field var 'x_str_ApprovalCode'
            val = CurrentForm.HasValue("str_ApprovalCode") ? CurrentForm.GetValue("str_ApprovalCode") : CurrentForm.GetValue("x_str_ApprovalCode");
            if (!str_ApprovalCode.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ApprovalCode") && !CurrentForm.HasValue("x_str_ApprovalCode")) // DN
                    str_ApprovalCode.Visible = false; // Disable update for API request
                else
                    str_ApprovalCode.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_ApprovalCode"))
                str_ApprovalCode.OldValue = CurrentForm.GetValue("o_str_ApprovalCode");

            // Check field name 'Payment_Number' before field var 'x_Payment_Number'
            val = CurrentForm.HasValue("Payment_Number") ? CurrentForm.GetValue("Payment_Number") : CurrentForm.GetValue("x_Payment_Number");
            if (!Payment_Number.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Payment_Number") && !CurrentForm.HasValue("x_Payment_Number")) // DN
                    Payment_Number.Visible = false; // Disable update for API request
                else
                    Payment_Number.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_Payment_Number"))
                Payment_Number.OldValue = CurrentForm.GetValue("o_Payment_Number");

            // Check field name 'Pricelist' before field var 'x_Pricelist'
            val = CurrentForm.HasValue("Pricelist") ? CurrentForm.GetValue("Pricelist") : CurrentForm.GetValue("x_Pricelist");
            if (!Pricelist.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Pricelist") && !CurrentForm.HasValue("x_Pricelist")) // DN
                    Pricelist.Visible = false; // Disable update for API request
                else
                    Pricelist.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_Pricelist"))
                Pricelist.OldValue = CurrentForm.GetValue("o_Pricelist");

            // Check field name 'str_Amount_Pay' before field var 'x_str_Amount_Pay'
            val = CurrentForm.HasValue("str_Amount_Pay") ? CurrentForm.GetValue("str_Amount_Pay") : CurrentForm.GetValue("x_str_Amount_Pay");
            if (!str_Amount_Pay.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Amount_Pay") && !CurrentForm.HasValue("x_str_Amount_Pay")) // DN
                    str_Amount_Pay.Visible = false; // Disable update for API request
                else
                    str_Amount_Pay.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_Amount_Pay"))
                str_Amount_Pay.OldValue = CurrentForm.GetValue("o_str_Amount_Pay");

            // Check field name 'mny_Running_Payments' before field var 'x_mny_Running_Payments'
            val = CurrentForm.HasValue("mny_Running_Payments") ? CurrentForm.GetValue("mny_Running_Payments") : CurrentForm.GetValue("x_mny_Running_Payments");
            if (!mny_Running_Payments.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_Running_Payments") && !CurrentForm.HasValue("x_mny_Running_Payments")) // DN
                    mny_Running_Payments.Visible = false; // Disable update for API request
                else
                    mny_Running_Payments.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_mny_Running_Payments"))
                mny_Running_Payments.OldValue = CurrentForm.GetValue("o_mny_Running_Payments");

            // Check field name 'mny_Running_Balance' before field var 'x_mny_Running_Balance'
            val = CurrentForm.HasValue("mny_Running_Balance") ? CurrentForm.GetValue("mny_Running_Balance") : CurrentForm.GetValue("x_mny_Running_Balance");
            if (!mny_Running_Balance.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_Running_Balance") && !CurrentForm.HasValue("x_mny_Running_Balance")) // DN
                    mny_Running_Balance.Visible = false; // Disable update for API request
                else
                    mny_Running_Balance.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_mny_Running_Balance"))
                mny_Running_Balance.OldValue = CurrentForm.GetValue("o_mny_Running_Balance");

            // Check field name 'int_Bill_ID' before field var 'x_int_Bill_ID'
            val = CurrentForm.HasValue("int_Bill_ID") ? CurrentForm.GetValue("int_Bill_ID") : CurrentForm.GetValue("x_int_Bill_ID");
            if (!int_Bill_ID.IsDetailKey && !IsGridAdd && !IsAdd)
                int_Bill_ID.SetFormValue(val);
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            if (!IsGridAdd && !IsAdd)
                int_Bill_ID.CurrentValue = int_Bill_ID.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            date_Paid.CurrentValue = date_Paid.FormValue;
            date_Paid.CurrentValue = UnformatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern);
            str_ApprovalCode.CurrentValue = str_ApprovalCode.FormValue;
            Payment_Number.CurrentValue = Payment_Number.FormValue;
            Pricelist.CurrentValue = Pricelist.FormValue;
            str_Amount_Pay.CurrentValue = str_Amount_Pay.FormValue;
            mny_Running_Payments.CurrentValue = mny_Running_Payments.FormValue;
            mny_Running_Balance.CurrentValue = mny_Running_Balance.FormValue;
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
            int_Bill_ID.SetDbValue(row["int_Bill_ID"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_First_Name.SetDbValue(row["str_First_Name"]);
            str_Last_Name.SetDbValue(row["str_Last_Name"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            int_Payment_Method.SetDbValue(row["int_Payment_Method"]);
            date_Paid.SetDbValue(row["date_Paid"]);
            str_ApprovalCode.SetDbValue(row["str_ApprovalCode"]);
            Payment_Number.SetDbValue(row["Payment_Number"]);
            Pricelist.SetDbValue(row["Pricelist"]);
            date_Created.SetDbValue(row["date_Created"]);
            str_Amount.SetDbValue(row["str_Amount"]);
            str_CC_Holder_Name.SetDbValue(row["str_CC_Holder_Name"]);
            str_CC_Number.SetDbValue(row["str_CC_Number"]);
            int_CC_ExpMonth.SetDbValue(row["int_CC_ExpMonth"]);
            int_CC_ExpYear.SetDbValue(row["int_CC_ExpYear"]);
            int_CC_Type.SetDbValue(row["int_CC_Type"]);
            str_Card_Id.SetDbValue(row["str_Card_Id"]);
            str_CC_ValidationNum.SetDbValue(row["str_CC_ValidationNum"]);
            str_reference.SetDbValue(row["str_reference"]);
            str_Amount_Pay.SetDbValue(row["str_Amount_Pay"]);
            mny_Running_Payments.SetDbValue(row["mny_Running_Payments"]);
            mny_Running_Balance.SetDbValue(row["mny_Running_Balance"]);
            str_Payment_Reference.SetDbValue(row["str_Payment_Reference"]);
            int_Accepted_By.SetDbValue(row["int_Accepted_By"]);
            str_Check_Number.SetDbValue(row["str_Check_Number"]);
            bit_Is_Check_Deposited.SetDbValue((ConvertToBool(row["bit_Is_Check_Deposited"]) ? "1" : "0"));
            str_Adjustment_Type.SetDbValue(row["str_Adjustment_Type"]);
            str_Adjust_Sub_Type.SetDbValue(row["str_Adjust_Sub_Type"]);
            bit_Archive.SetDbValue((ConvertToBool(row["bit_Archive"]) ? "1" : "0"));
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_CardHolder_Address.SetDbValue(row["str_CardHolder_Address"]);
            str_CH_City.SetDbValue(row["str_CH_City"]);
            str_CH_Zip.SetDbValue(row["str_CH_Zip"]);
            int_State.SetDbValue(row["int_State"]);
            bit_IsAuthDotNet.SetDbValue((ConvertToBool(row["bit_IsAuthDotNet"]) ? "1" : "0"));
            bit_IsRefund.SetDbValue((ConvertToBool(row["bit_IsRefund"]) ? "1" : "0"));
            str_Receipt.SetDbValue(row["str_Receipt"]);
            str_TransactionNumber.SetDbValue(row["str_TransactionNumber"]);
            str_OrderId.SetDbValue(row["str_OrderId"]);
            str_TransactionTime.SetDbValue(row["str_TransactionTime"]);
            int_Location_Id.SetDbValue(row["int_Location_Id"]);
            str_Enrollment_Id.SetDbValue(row["str_Enrollment_Id"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            str_Payment_Note.SetDbValue(row["str_Payment_Note"]);
            int_Package_ID.SetDbValue(row["int_Package_ID"]);
            Package_Name.SetDbValue(row["Package_Name"]);
            Price.SetDbValue(row["Price"]);
            AssessmentID.SetDbValue(row["AssessmentID"]);
            course.SetDbValue(row["course"]);
            institution.SetDbValue(row["institution"]);
            UniqueIdx.SetDbValue(row["UniqueIdx"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Bill_ID", int_Bill_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_First_Name", str_First_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last_Name", str_Last_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Payment_Method", int_Payment_Method.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Paid", date_Paid.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ApprovalCode", str_ApprovalCode.DefaultValue ?? DbNullValue); // DN
            row.Add("Payment_Number", Payment_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("Pricelist", Pricelist.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Amount", str_Amount.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_Holder_Name", str_CC_Holder_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_Number", str_CC_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_ExpMonth", int_CC_ExpMonth.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_ExpYear", int_CC_ExpYear.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_Type", int_CC_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Card_Id", str_Card_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_ValidationNum", str_CC_ValidationNum.DefaultValue ?? DbNullValue); // DN
            row.Add("str_reference", str_reference.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Amount_Pay", str_Amount_Pay.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Running_Payments", mny_Running_Payments.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Running_Balance", mny_Running_Balance.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Payment_Reference", str_Payment_Reference.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Accepted_By", int_Accepted_By.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Check_Number", str_Check_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Is_Check_Deposited", bit_Is_Check_Deposited.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Adjustment_Type", str_Adjustment_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Adjust_Sub_Type", str_Adjust_Sub_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Archive", bit_Archive.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardHolder_Address", str_CardHolder_Address.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CH_City", str_CH_City.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CH_Zip", str_CH_Zip.DefaultValue ?? DbNullValue); // DN
            row.Add("int_State", int_State.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsAuthDotNet", bit_IsAuthDotNet.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsRefund", bit_IsRefund.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Receipt", str_Receipt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_TransactionNumber", str_TransactionNumber.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OrderId", str_OrderId.DefaultValue ?? DbNullValue); // DN
            row.Add("str_TransactionTime", str_TransactionTime.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_Id", int_Location_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Enrollment_Id", str_Enrollment_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Payment_Note", str_Payment_Note.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Package_ID", int_Package_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Package_Name", Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("Price", Price.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentID", AssessmentID.DefaultValue ?? DbNullValue); // DN
            row.Add("course", course.DefaultValue ?? DbNullValue); // DN
            row.Add("institution", institution.DefaultValue ?? DbNullValue); // DN
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

            // int_Bill_ID

            // NationalID

            // str_First_Name

            // str_Last_Name

            // str_Username

            // int_Student_ID

            // int_Payment_Method

            // date_Paid
            date_Paid.CellCssStyle = "white-space: nowrap;";

            // str_ApprovalCode

            // Payment_Number

            // Pricelist

            // date_Created

            // str_Amount

            // str_CC_Holder_Name

            // str_CC_Number

            // int_CC_ExpMonth

            // int_CC_ExpYear

            // int_CC_Type

            // str_Card_Id

            // str_CC_ValidationNum

            // str_reference

            // str_Amount_Pay

            // mny_Running_Payments

            // mny_Running_Balance

            // str_Payment_Reference

            // int_Accepted_By

            // str_Check_Number

            // bit_Is_Check_Deposited

            // str_Adjustment_Type

            // str_Adjust_Sub_Type

            // bit_Archive

            // int_Created_By

            // int_Modified_By

            // date_Modified

            // bit_IsDeleted

            // str_CardHolder_Address

            // str_CH_City

            // str_CH_Zip

            // int_State

            // bit_IsAuthDotNet

            // bit_IsRefund

            // str_Receipt

            // str_TransactionNumber

            // str_OrderId

            // str_TransactionTime

            // int_Location_Id

            // str_Enrollment_Id

            // str_Notes

            // str_Payment_Note

            // int_Package_ID

            // Package_Name

            // Price

            // AssessmentID

            // course

            // institution

            // UniqueIdx

            // View row
            if (RowType == RowType.View) {
                // int_Bill_ID
                int_Bill_ID.ViewValue = int_Bill_ID.CurrentValue;
                int_Bill_ID.ViewCustomAttributes = "";

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

                // str_First_Name
                str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

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

                // int_Student_ID
                curVal = ConvertToString(int_Student_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Student_ID.Lookup != null && IsDictionary(int_Student_ID.Lookup?.Options) && int_Student_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Student_ID.ViewValue = int_Student_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Student_ID]", "=", int_Student_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Student_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Student_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Student_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Student_ID.ViewValue = int_Student_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Student_ID.DisplayValue(listwrk));
                        } else {
                            int_Student_ID.ViewValue = FormatNumber(int_Student_ID.CurrentValue, int_Student_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Student_ID.ViewValue = DbNullValue;
                }
                int_Student_ID.ViewCustomAttributes = "";

                // int_Payment_Method
                if (!Empty(int_Payment_Method.CurrentValue)) {
                    int_Payment_Method.ViewValue = int_Payment_Method.HighlightLookup(ConvertToString(int_Payment_Method.CurrentValue), int_Payment_Method.OptionCaption(ConvertToString(int_Payment_Method.CurrentValue)));
                } else {
                    int_Payment_Method.ViewValue = DbNullValue;
                }
                int_Payment_Method.ViewCustomAttributes = "";

                // date_Paid
                date_Paid.ViewValue = date_Paid.CurrentValue;
                date_Paid.ViewValue = FormatDateTime(date_Paid.ViewValue, date_Paid.FormatPattern);
                date_Paid.ViewCustomAttributes = "";

                // str_ApprovalCode
                str_ApprovalCode.ViewValue = ConvertToString(str_ApprovalCode.CurrentValue); // DN
                str_ApprovalCode.ViewCustomAttributes = "";

                // Payment_Number
                Payment_Number.ViewValue = Payment_Number.CurrentValue;
                Payment_Number.ViewValue = FormatNumber(Payment_Number.ViewValue, Payment_Number.FormatPattern);
                Payment_Number.CellCssStyle += "text-align: center;";
                Payment_Number.ViewCustomAttributes = "";

                // Pricelist
                Pricelist.ViewValue = Pricelist.CurrentValue;
                Pricelist.ViewValue = FormatNumber(Pricelist.ViewValue, Pricelist.FormatPattern);
                Pricelist.CellCssStyle += "text-align: right;";
                Pricelist.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // str_Amount
                str_Amount.ViewValue = ConvertToString(str_Amount.CurrentValue); // DN
                str_Amount.ViewCustomAttributes = "";

                // str_CC_Holder_Name
                str_CC_Holder_Name.ViewValue = ConvertToString(str_CC_Holder_Name.CurrentValue); // DN
                str_CC_Holder_Name.ViewCustomAttributes = "";

                // str_CC_Number
                str_CC_Number.ViewValue = ConvertToString(str_CC_Number.CurrentValue); // DN
                str_CC_Number.ViewCustomAttributes = "";

                // int_CC_ExpMonth
                int_CC_ExpMonth.ViewValue = int_CC_ExpMonth.CurrentValue;
                int_CC_ExpMonth.ViewValue = FormatNumber(int_CC_ExpMonth.ViewValue, int_CC_ExpMonth.FormatPattern);
                int_CC_ExpMonth.ViewCustomAttributes = "";

                // int_CC_ExpYear
                int_CC_ExpYear.ViewValue = int_CC_ExpYear.CurrentValue;
                int_CC_ExpYear.ViewValue = FormatNumber(int_CC_ExpYear.ViewValue, int_CC_ExpYear.FormatPattern);
                int_CC_ExpYear.ViewCustomAttributes = "";

                // int_CC_Type
                int_CC_Type.ViewValue = int_CC_Type.CurrentValue;
                int_CC_Type.ViewValue = FormatNumber(int_CC_Type.ViewValue, int_CC_Type.FormatPattern);
                int_CC_Type.ViewCustomAttributes = "";

                // str_Card_Id
                str_Card_Id.ViewValue = ConvertToString(str_Card_Id.CurrentValue); // DN
                str_Card_Id.ViewCustomAttributes = "";

                // str_CC_ValidationNum
                str_CC_ValidationNum.ViewValue = ConvertToString(str_CC_ValidationNum.CurrentValue); // DN
                str_CC_ValidationNum.ViewCustomAttributes = "";

                // str_reference
                str_reference.ViewValue = ConvertToString(str_reference.CurrentValue); // DN
                str_reference.ViewCustomAttributes = "";

                // str_Amount_Pay
                str_Amount_Pay.ViewValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
                str_Amount_Pay.CellCssStyle += "text-align: right;";
                str_Amount_Pay.ViewCustomAttributes = "";

                // mny_Running_Payments
                mny_Running_Payments.ViewValue = mny_Running_Payments.CurrentValue;
                mny_Running_Payments.ViewValue = FormatNumber(mny_Running_Payments.ViewValue, mny_Running_Payments.FormatPattern);
                mny_Running_Payments.CellCssStyle += "text-align: right;";
                mny_Running_Payments.ViewCustomAttributes = "";

                // mny_Running_Balance
                mny_Running_Balance.ViewValue = mny_Running_Balance.CurrentValue;
                mny_Running_Balance.ViewValue = FormatNumber(mny_Running_Balance.ViewValue, mny_Running_Balance.FormatPattern);
                mny_Running_Balance.CellCssStyle += "text-align: right;";
                mny_Running_Balance.ViewCustomAttributes = "";

                // str_Payment_Reference
                str_Payment_Reference.ViewValue = ConvertToString(str_Payment_Reference.CurrentValue); // DN
                str_Payment_Reference.ViewCustomAttributes = "";

                // int_Accepted_By
                int_Accepted_By.ViewValue = int_Accepted_By.CurrentValue;
                int_Accepted_By.ViewValue = FormatNumber(int_Accepted_By.ViewValue, int_Accepted_By.FormatPattern);
                int_Accepted_By.ViewCustomAttributes = "";

                // str_Check_Number
                str_Check_Number.ViewValue = ConvertToString(str_Check_Number.CurrentValue); // DN
                str_Check_Number.ViewCustomAttributes = "";

                // bit_Is_Check_Deposited
                if (ConvertToBool(bit_Is_Check_Deposited.CurrentValue)) {
                    bit_Is_Check_Deposited.ViewValue = bit_Is_Check_Deposited.TagCaption(1) != "" ? bit_Is_Check_Deposited.TagCaption(1) : "Yes";
                } else {
                    bit_Is_Check_Deposited.ViewValue = bit_Is_Check_Deposited.TagCaption(2) != "" ? bit_Is_Check_Deposited.TagCaption(2) : "No";
                }
                bit_Is_Check_Deposited.ViewCustomAttributes = "";

                // str_Adjustment_Type
                str_Adjustment_Type.ViewValue = ConvertToString(str_Adjustment_Type.CurrentValue); // DN
                str_Adjustment_Type.ViewCustomAttributes = "";

                // str_Adjust_Sub_Type
                str_Adjust_Sub_Type.ViewValue = ConvertToString(str_Adjust_Sub_Type.CurrentValue); // DN
                str_Adjust_Sub_Type.ViewCustomAttributes = "";

                // bit_Archive
                if (ConvertToBool(bit_Archive.CurrentValue)) {
                    bit_Archive.ViewValue = bit_Archive.TagCaption(1) != "" ? bit_Archive.TagCaption(1) : "Yes";
                } else {
                    bit_Archive.ViewValue = bit_Archive.TagCaption(2) != "" ? bit_Archive.TagCaption(2) : "No";
                }
                bit_Archive.ViewCustomAttributes = "";

                // int_Created_By
                int_Created_By.ViewValue = int_Created_By.CurrentValue;
                int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
                int_Created_By.ViewCustomAttributes = "";

                // int_Modified_By
                int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
                int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
                int_Modified_By.ViewCustomAttributes = "";

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

                // str_CardHolder_Address
                str_CardHolder_Address.ViewValue = ConvertToString(str_CardHolder_Address.CurrentValue); // DN
                str_CardHolder_Address.ViewCustomAttributes = "";

                // str_CH_City
                str_CH_City.ViewValue = ConvertToString(str_CH_City.CurrentValue); // DN
                str_CH_City.ViewCustomAttributes = "";

                // str_CH_Zip
                str_CH_Zip.ViewValue = ConvertToString(str_CH_Zip.CurrentValue); // DN
                str_CH_Zip.ViewCustomAttributes = "";

                // int_State
                int_State.ViewValue = int_State.CurrentValue;
                int_State.ViewValue = FormatNumber(int_State.ViewValue, int_State.FormatPattern);
                int_State.ViewCustomAttributes = "";

                // bit_IsAuthDotNet
                if (ConvertToBool(bit_IsAuthDotNet.CurrentValue)) {
                    bit_IsAuthDotNet.ViewValue = bit_IsAuthDotNet.TagCaption(1) != "" ? bit_IsAuthDotNet.TagCaption(1) : "Yes";
                } else {
                    bit_IsAuthDotNet.ViewValue = bit_IsAuthDotNet.TagCaption(2) != "" ? bit_IsAuthDotNet.TagCaption(2) : "No";
                }
                bit_IsAuthDotNet.ViewCustomAttributes = "";

                // bit_IsRefund
                if (ConvertToBool(bit_IsRefund.CurrentValue)) {
                    bit_IsRefund.ViewValue = bit_IsRefund.TagCaption(1) != "" ? bit_IsRefund.TagCaption(1) : "Yes";
                } else {
                    bit_IsRefund.ViewValue = bit_IsRefund.TagCaption(2) != "" ? bit_IsRefund.TagCaption(2) : "No";
                }
                bit_IsRefund.ViewCustomAttributes = "";

                // str_Receipt
                str_Receipt.ViewValue = ConvertToString(str_Receipt.CurrentValue); // DN
                str_Receipt.ViewCustomAttributes = "";

                // str_TransactionNumber
                str_TransactionNumber.ViewValue = ConvertToString(str_TransactionNumber.CurrentValue); // DN
                str_TransactionNumber.ViewCustomAttributes = "";

                // str_OrderId
                str_OrderId.ViewValue = ConvertToString(str_OrderId.CurrentValue); // DN
                str_OrderId.ViewCustomAttributes = "";

                // str_TransactionTime
                str_TransactionTime.ViewValue = str_TransactionTime.CurrentValue;
                str_TransactionTime.ViewCustomAttributes = "";

                // int_Location_Id
                int_Location_Id.ViewValue = int_Location_Id.CurrentValue;
                int_Location_Id.ViewValue = FormatNumber(int_Location_Id.ViewValue, int_Location_Id.FormatPattern);
                int_Location_Id.ViewCustomAttributes = "";

                // str_Enrollment_Id
                str_Enrollment_Id.ViewValue = ConvertToString(str_Enrollment_Id.CurrentValue); // DN
                str_Enrollment_Id.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // str_Payment_Note
                str_Payment_Note.ViewValue = str_Payment_Note.CurrentValue;
                str_Payment_Note.ViewCustomAttributes = "";

                // int_Package_ID
                curVal = ConvertToString(int_Package_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Package_ID.Lookup != null && IsDictionary(int_Package_ID.Lookup?.Options) && int_Package_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Package_ID.ViewValue = int_Package_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_Package_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Package_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Package_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Package_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Package_ID.ViewValue = int_Package_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Package_ID.DisplayValue(listwrk));
                        } else {
                            int_Package_ID.ViewValue = FormatNumber(int_Package_ID.CurrentValue, int_Package_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Package_ID.ViewValue = DbNullValue;
                }
                int_Package_ID.ViewCustomAttributes = "";

                // Package_Name
                Package_Name.ViewValue = ConvertToString(Package_Name.CurrentValue); // DN
                curVal = ConvertToString(Package_Name.CurrentValue);
                if (!Empty(curVal)) {
                    if (Package_Name.Lookup != null && IsDictionary(Package_Name.Lookup?.Options) && Package_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Package_Name.ViewValue = Package_Name.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Package_Name]", "=", Package_Name.CurrentValue, DataType.String, "");
                        sqlWrk = Package_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Package_Name.Lookup != null) { // Lookup values found
                            var listwrk = Package_Name.Lookup?.RenderViewRow(rswrk[0]);
                            Package_Name.ViewValue = Package_Name.HighlightLookup(ConvertToString(rswrk[0]), Package_Name.DisplayValue(listwrk));
                        } else {
                            Package_Name.ViewValue = Package_Name.CurrentValue;
                        }
                    }
                } else {
                    Package_Name.ViewValue = DbNullValue;
                }
                Package_Name.ViewCustomAttributes = "";

                // Price
                curVal = ConvertToString(Price.CurrentValue);
                if (!Empty(curVal)) {
                    if (Price.Lookup != null && IsDictionary(Price.Lookup?.Options) && Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Price.ViewValue = Price.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[mny_Price]", "=", Price.CurrentValue, DataType.Number, "");
                        sqlWrk = Price.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Price.Lookup != null) { // Lookup values found
                            var listwrk = Price.Lookup?.RenderViewRow(rswrk[0]);
                            Price.ViewValue = Price.HighlightLookup(ConvertToString(rswrk[0]), Price.DisplayValue(listwrk));
                        } else {
                            Price.ViewValue = FormatCurrency(Price.CurrentValue, Price.FormatPattern);
                        }
                    }
                } else {
                    Price.ViewValue = DbNullValue;
                }
                Price.ViewCustomAttributes = "";

                // AssessmentID
                AssessmentID.ViewValue = AssessmentID.CurrentValue;
                AssessmentID.ViewValue = FormatNumber(AssessmentID.ViewValue, AssessmentID.FormatPattern);
                AssessmentID.ViewCustomAttributes = "";

                // course
                course.ViewValue = ConvertToString(course.CurrentValue); // DN
                course.ViewCustomAttributes = "";

                // institution
                institution.ViewValue = ConvertToString(institution.CurrentValue); // DN
                institution.ViewCustomAttributes = "";

                // UniqueIdx
                UniqueIdx.ViewValue = ConvertToString(UniqueIdx.CurrentValue); // DN
                UniqueIdx.ViewCustomAttributes = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // date_Paid
                date_Paid.HrefValue = "";
                date_Paid.TooltipValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";
                str_ApprovalCode.TooltipValue = "";

                // Payment_Number
                Payment_Number.HrefValue = "";
                Payment_Number.TooltipValue = "";

                // Pricelist
                Pricelist.HrefValue = "";
                Pricelist.TooltipValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";
                str_Amount_Pay.TooltipValue = "";

                // mny_Running_Payments
                mny_Running_Payments.HrefValue = "";
                mny_Running_Payments.TooltipValue = "";

                // mny_Running_Balance
                mny_Running_Balance.HrefValue = "";
                mny_Running_Balance.TooltipValue = "";
            } else if (RowType == RowType.Add) {
                // NationalID
                NationalID.SetupEditAttributes();
                if (!Empty(NationalID.SessionValue)) {
                    NationalID.CurrentValue = ForeignKeyValue(NationalID.SessionValue);
                    NationalID.OldValue = NationalID.CurrentValue;
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
                } else {
                    curVal = ConvertToString(NationalID.CurrentValue)?.Trim() ?? "";
                    if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        NationalID.EditValue = NationalID.Lookup?.Options.Values.ToList();
                    } else { // Lookup from database
                        if (curVal == "") {
                            filterWrk = "0=1";
                        } else {
                            filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                        }
                        sqlWrk = NationalID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        NationalID.EditValue = rswrk;
                    }
                    NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                }

                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.CurrentValue = HtmlDecode(str_First_Name.CurrentValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.CurrentValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.CurrentValue = HtmlDecode(str_Last_Name.CurrentValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.CurrentValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // date_Paid
                date_Paid.SetupEditAttributes();
                date_Paid.EditValue = FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern); // DN
                date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

                // str_ApprovalCode
                str_ApprovalCode.SetupEditAttributes();
                if (!str_ApprovalCode.Raw)
                    str_ApprovalCode.CurrentValue = HtmlDecode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

                // Payment_Number
                Payment_Number.SetupEditAttributes();
                Payment_Number.EditValue = Payment_Number.CurrentValue; // DN
                Payment_Number.PlaceHolder = RemoveHtml(Payment_Number.Caption);
                if (!Empty(Payment_Number.EditValue) && IsNumeric(Payment_Number.EditValue)) {
                    Payment_Number.EditValue = FormatNumber(Payment_Number.EditValue, null);
                }

                // Pricelist
                Pricelist.SetupEditAttributes();
                Pricelist.EditValue = Pricelist.CurrentValue; // DN
                Pricelist.PlaceHolder = RemoveHtml(Pricelist.Caption);
                if (!Empty(Pricelist.EditValue) && IsNumeric(Pricelist.EditValue)) {
                    Pricelist.EditValue = FormatNumber(Pricelist.EditValue, null);
                }

                // str_Amount_Pay
                str_Amount_Pay.SetupEditAttributes();
                if (!str_Amount_Pay.Raw)
                    str_Amount_Pay.CurrentValue = HtmlDecode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

                // mny_Running_Payments
                mny_Running_Payments.SetupEditAttributes();
                mny_Running_Payments.EditValue = mny_Running_Payments.CurrentValue; // DN
                mny_Running_Payments.PlaceHolder = RemoveHtml(mny_Running_Payments.Caption);
                if (!Empty(mny_Running_Payments.EditValue) && IsNumeric(mny_Running_Payments.EditValue)) {
                    mny_Running_Payments.EditValue = FormatNumber(mny_Running_Payments.EditValue, null);
                }

                // mny_Running_Balance
                mny_Running_Balance.SetupEditAttributes();
                mny_Running_Balance.EditValue = mny_Running_Balance.CurrentValue; // DN
                mny_Running_Balance.PlaceHolder = RemoveHtml(mny_Running_Balance.Caption);
                if (!Empty(mny_Running_Balance.EditValue) && IsNumeric(mny_Running_Balance.EditValue)) {
                    mny_Running_Balance.EditValue = FormatNumber(mny_Running_Balance.EditValue, null);
                }

                // Add refer script

                // NationalID
                NationalID.HrefValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

                // Payment_Number
                Payment_Number.HrefValue = "";

                // Pricelist
                Pricelist.HrefValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";

                // mny_Running_Payments
                mny_Running_Payments.HrefValue = "";

                // mny_Running_Balance
                mny_Running_Balance.HrefValue = "";
            } else if (RowType == RowType.Search) {
                // NationalID
                NationalID.SetupEditAttributes();
                curVal = ConvertToString(NationalID.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    NationalID.EditValue = NationalID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[NationalID]", "=", NationalID.AdvancedSearch.SearchValue, DataType.Number, "");
                    }
                    sqlWrk = NationalID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    NationalID.EditValue = rswrk;
                }
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                NationalID.SetupEditAttributes();
                curVal = ConvertToString(NationalID.AdvancedSearch.SearchValue2)?.Trim() ?? "";
                if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    NationalID.EditValue2 = NationalID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[NationalID]", "=", NationalID.AdvancedSearch.SearchValue2, DataType.Number, "");
                    }
                    sqlWrk = NationalID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    NationalID.EditValue2 = rswrk;
                }
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.AdvancedSearch.SearchValue = HtmlDecode(str_First_Name.AdvancedSearch.SearchValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.AdvancedSearch.SearchValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // date_Paid
                date_Paid.SetupEditAttributes();
                date_Paid.EditValue = FormatDateTime(UnformatDateTime(date_Paid.AdvancedSearch.SearchValue, date_Paid.FormatPattern), date_Paid.FormatPattern); // DN
                date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

                // str_ApprovalCode
                str_ApprovalCode.SetupEditAttributes();
                if (!str_ApprovalCode.Raw)
                    str_ApprovalCode.AdvancedSearch.SearchValue = HtmlDecode(str_ApprovalCode.AdvancedSearch.SearchValue);
                str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.AdvancedSearch.SearchValue);
                str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

                // Payment_Number
                Payment_Number.SetupEditAttributes();
                Payment_Number.EditValue = Payment_Number.AdvancedSearch.SearchValue; // DN
                Payment_Number.PlaceHolder = RemoveHtml(Payment_Number.Caption);

                // Pricelist
                Pricelist.SetupEditAttributes();
                Pricelist.EditValue = Pricelist.AdvancedSearch.SearchValue; // DN
                Pricelist.PlaceHolder = RemoveHtml(Pricelist.Caption);

                // str_Amount_Pay
                str_Amount_Pay.SetupEditAttributes();
                if (!str_Amount_Pay.Raw)
                    str_Amount_Pay.AdvancedSearch.SearchValue = HtmlDecode(str_Amount_Pay.AdvancedSearch.SearchValue);
                str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.AdvancedSearch.SearchValue);
                str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

                // mny_Running_Payments
                mny_Running_Payments.SetupEditAttributes();
                mny_Running_Payments.EditValue = mny_Running_Payments.AdvancedSearch.SearchValue; // DN
                mny_Running_Payments.PlaceHolder = RemoveHtml(mny_Running_Payments.Caption);

                // mny_Running_Balance
                mny_Running_Balance.SetupEditAttributes();
                mny_Running_Balance.EditValue = mny_Running_Balance.AdvancedSearch.SearchValue; // DN
                mny_Running_Balance.PlaceHolder = RemoveHtml(mny_Running_Balance.Caption);
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
            if (NationalID.Required) {
                if (!NationalID.IsDetailKey && Empty(NationalID.FormValue)) {
                    NationalID.AddErrorMessage(ConvertToString(NationalID.RequiredErrorMessage).Replace("%s", NationalID.Caption));
                }
            }
            if (str_First_Name.Required) {
                if (!str_First_Name.IsDetailKey && Empty(str_First_Name.FormValue)) {
                    str_First_Name.AddErrorMessage(ConvertToString(str_First_Name.RequiredErrorMessage).Replace("%s", str_First_Name.Caption));
                }
            }
            if (str_Last_Name.Required) {
                if (!str_Last_Name.IsDetailKey && Empty(str_Last_Name.FormValue)) {
                    str_Last_Name.AddErrorMessage(ConvertToString(str_Last_Name.RequiredErrorMessage).Replace("%s", str_Last_Name.Caption));
                }
            }
            if (date_Paid.Required) {
                if (!date_Paid.IsDetailKey && Empty(date_Paid.FormValue)) {
                    date_Paid.AddErrorMessage(ConvertToString(date_Paid.RequiredErrorMessage).Replace("%s", date_Paid.Caption));
                }
            }
            if (!CheckDate(date_Paid.FormValue, date_Paid.FormatPattern)) {
                date_Paid.AddErrorMessage(date_Paid.GetErrorMessage(false));
            }
            if (str_ApprovalCode.Required) {
                if (!str_ApprovalCode.IsDetailKey && Empty(str_ApprovalCode.FormValue)) {
                    str_ApprovalCode.AddErrorMessage(ConvertToString(str_ApprovalCode.RequiredErrorMessage).Replace("%s", str_ApprovalCode.Caption));
                }
            }
            if (Payment_Number.Required) {
                if (!Payment_Number.IsDetailKey && Empty(Payment_Number.FormValue)) {
                    Payment_Number.AddErrorMessage(ConvertToString(Payment_Number.RequiredErrorMessage).Replace("%s", Payment_Number.Caption));
                }
            }
            if (!CheckInteger(Payment_Number.FormValue)) {
                Payment_Number.AddErrorMessage(Payment_Number.GetErrorMessage(false));
            }
            if (Pricelist.Required) {
                if (!Pricelist.IsDetailKey && Empty(Pricelist.FormValue)) {
                    Pricelist.AddErrorMessage(ConvertToString(Pricelist.RequiredErrorMessage).Replace("%s", Pricelist.Caption));
                }
            }
            if (!CheckNumber(Pricelist.FormValue)) {
                Pricelist.AddErrorMessage(Pricelist.GetErrorMessage(false));
            }
            if (str_Amount_Pay.Required) {
                if (!str_Amount_Pay.IsDetailKey && Empty(str_Amount_Pay.FormValue)) {
                    str_Amount_Pay.AddErrorMessage(ConvertToString(str_Amount_Pay.RequiredErrorMessage).Replace("%s", str_Amount_Pay.Caption));
                }
            }
            if (mny_Running_Payments.Required) {
                if (!mny_Running_Payments.IsDetailKey && Empty(mny_Running_Payments.FormValue)) {
                    mny_Running_Payments.AddErrorMessage(ConvertToString(mny_Running_Payments.RequiredErrorMessage).Replace("%s", mny_Running_Payments.Caption));
                }
            }
            if (!CheckNumber(mny_Running_Payments.FormValue)) {
                mny_Running_Payments.AddErrorMessage(mny_Running_Payments.GetErrorMessage(false));
            }
            if (mny_Running_Balance.Required) {
                if (!mny_Running_Balance.IsDetailKey && Empty(mny_Running_Balance.FormValue)) {
                    mny_Running_Balance.AddErrorMessage(ConvertToString(mny_Running_Balance.RequiredErrorMessage).Replace("%s", mny_Running_Balance.Caption));
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

        // Add record
        #pragma warning disable 168, 219

        protected async Task<JsonBoolResult> AddRow(Dictionary<string, object>? rsold = null) { // DN
            bool result = false;

            // Set new row
            Dictionary<string, object> rsnew = new ();
            try {
                // NationalID
                NationalID.SetDbValue(rsnew, NationalID.CurrentValue);

                // str_First_Name
                str_First_Name.SetDbValue(rsnew, str_First_Name.CurrentValue);

                // str_Last_Name
                str_Last_Name.SetDbValue(rsnew, str_Last_Name.CurrentValue);

                // date_Paid
                date_Paid.SetDbValue(rsnew, ConvertToDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern));

                // str_ApprovalCode
                str_ApprovalCode.SetDbValue(rsnew, str_ApprovalCode.CurrentValue);

                // Payment_Number
                Payment_Number.SetDbValue(rsnew, Payment_Number.CurrentValue);

                // Pricelist
                Pricelist.SetDbValue(rsnew, Pricelist.CurrentValue);

                // str_Amount_Pay
                str_Amount_Pay.SetDbValue(rsnew, str_Amount_Pay.CurrentValue);

                // mny_Running_Payments
                mny_Running_Payments.SetDbValue(rsnew, mny_Running_Payments.CurrentValue);

                // mny_Running_Balance
                mny_Running_Balance.SetDbValue(rsnew, mny_Running_Balance.CurrentValue);

                // str_Username
                if (!Security.IsAdmin && Security.IsLoggedIn) { // Non system admin
                    rsnew["str_Username"] = CurrentUserID();
                }
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }

            // Update current values
            SetCurrentValues(rsnew);

            // Check if valid User ID
            bool validUser = false;
            string userIdMsg;
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin) { // Non system admin
                validUser = Security.IsValidUserID(str_Username.CurrentValue);
                if (!validUser) {
                    userIdMsg = Language.Phrase("UnAuthorizedUserID").Replace("%c", ConvertToString(Security.CurrentUserID));
                    userIdMsg = userIdMsg.Replace("%u", ConvertToString(str_Username.CurrentValue));
                    FailureMessage = userIdMsg;
                    return JsonBoolResult.FalseResult;
                }
            }
            string? masterFilter;
            Dictionary<string, object?> detailKeys;

            // Check if valid key values for master user
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin) { // Non system admin
                detailKeys = new ();
                detailKeys.Add("NationalID", NationalID.CurrentValue);
                masterFilter = MasterFilter(tblPotentialStudentInfo, detailKeys); // DN
                if (!Empty(masterFilter) && tblPotentialStudentInfo != null) {
                    bool validMasterKey = true;
                    using var rsmaster = await tblPotentialStudentInfo.LoadReader(masterFilter);
                    if (rsmaster?.HasRows ?? false) { // DN
                        await rsmaster.ReadAsync();
                        validMasterKey = Security.IsValidUserID(rsmaster["str_Username"]);
                    } else if (CurrentMasterTable == "tblPotentialStudentInfo") {
                        validMasterKey = false;
                    }
                    if (!validMasterKey) {
                        string masterUserIdMsg = Language.Phrase("UnAuthorizedMasterUserID").Replace("%c", ConvertToString(Security.CurrentUserID));
                        masterUserIdMsg = masterUserIdMsg.Replace("%f", masterFilter);
                        FailureMessage = masterUserIdMsg;
                        return JsonBoolResult.FalseResult;
                    }
                }
            }
            if (!Empty(str_ApprovalCode.CurrentValue)) { // Check field with unique index
                var filter = "(str_ApprovalCode = '" + AdjustSql(str_ApprovalCode.CurrentValue, DbId) + "')";
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupIndex").Replace("%f", str_ApprovalCode.Caption).Replace("%v", ConvertToString(str_ApprovalCode.CurrentValue));
                    return JsonBoolResult.FalseResult;
                }
            }
            bool validMasterRecord;

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
                    rsnew["int_Bill_ID"] = int_Bill_ID.CurrentValue!;
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
            if (result && SendEmail) {
                var res = await SendEmailOnAdd(rsnew); // DN
                if (res != "OK")
                    FailureMessage = res;
            }

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
            int_Bill_ID.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            str_First_Name.AdvancedSearch.Load();
            str_Last_Name.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            int_Student_ID.AdvancedSearch.Load();
            int_Payment_Method.AdvancedSearch.Load();
            date_Paid.AdvancedSearch.Load();
            str_ApprovalCode.AdvancedSearch.Load();
            Payment_Number.AdvancedSearch.Load();
            Pricelist.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            str_Amount.AdvancedSearch.Load();
            str_CC_Holder_Name.AdvancedSearch.Load();
            str_CC_Number.AdvancedSearch.Load();
            int_CC_ExpMonth.AdvancedSearch.Load();
            int_CC_ExpYear.AdvancedSearch.Load();
            int_CC_Type.AdvancedSearch.Load();
            str_Card_Id.AdvancedSearch.Load();
            str_CC_ValidationNum.AdvancedSearch.Load();
            str_reference.AdvancedSearch.Load();
            str_Amount_Pay.AdvancedSearch.Load();
            mny_Running_Payments.AdvancedSearch.Load();
            mny_Running_Balance.AdvancedSearch.Load();
            str_Payment_Reference.AdvancedSearch.Load();
            int_Accepted_By.AdvancedSearch.Load();
            str_Check_Number.AdvancedSearch.Load();
            bit_Is_Check_Deposited.AdvancedSearch.Load();
            str_Adjustment_Type.AdvancedSearch.Load();
            str_Adjust_Sub_Type.AdvancedSearch.Load();
            bit_Archive.AdvancedSearch.Load();
            int_Created_By.AdvancedSearch.Load();
            int_Modified_By.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            bit_IsDeleted.AdvancedSearch.Load();
            str_CardHolder_Address.AdvancedSearch.Load();
            str_CH_City.AdvancedSearch.Load();
            str_CH_Zip.AdvancedSearch.Load();
            int_State.AdvancedSearch.Load();
            bit_IsAuthDotNet.AdvancedSearch.Load();
            bit_IsRefund.AdvancedSearch.Load();
            str_Receipt.AdvancedSearch.Load();
            str_TransactionNumber.AdvancedSearch.Load();
            str_OrderId.AdvancedSearch.Load();
            str_TransactionTime.AdvancedSearch.Load();
            int_Location_Id.AdvancedSearch.Load();
            str_Enrollment_Id.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            str_Payment_Note.AdvancedSearch.Load();
            int_Package_ID.AdvancedSearch.Load();
            Package_Name.AdvancedSearch.Load();
            Price.AdvancedSearch.Load();
            AssessmentID.AdvancedSearch.Load();
            course.AdvancedSearch.Load();
            institution.AdvancedSearch.Load();
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblBillingInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblBillingInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblBillingInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblBillingInfolist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblBillingInfosrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
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
            string exportStyle;

            // Export master record
            if (Config.ExportMasterRecord && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblPotentialStudentInfo") {
                tblPotentialStudentInfo = new TblPotentialStudentInfoList();
                if (tblPotentialStudentInfo != null) {
                    var c = await GetConnection2Async(tblPotentialStudentInfo.DbId); // Note: Use new connection for master record // DN
                    using var rsmaster = await tblPotentialStudentInfo.LoadReader(DbMasterFilter, "", c); // Load master record
                    if (rsmaster?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("v"); // Change to vertical
                        if (!IsExport("csv") || Config.ExportMasterRecordForCsv) {
                            doc.Table = tblPotentialStudentInfo;
                            await tblPotentialStudentInfo.ExportDocument(doc, rsmaster, 1, 1);
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
                if (masterTblVar == "tblPotentialStudentInfo") {
                    validMaster = true;
                    if (tblPotentialStudentInfo != null && (Get("fk_NationalID", out fk) || Get("NationalID", out fk))) {
                        tblPotentialStudentInfo.NationalID.QueryValue = fk;
                        NationalID.QueryValue = tblPotentialStudentInfo.NationalID.QueryValue;
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
                if (masterTblVar == "tblPotentialStudentInfo") {
                    validMaster = true;
                    if (tblPotentialStudentInfo != null && (Post("fk_NationalID", out fk) || Post("NationalID", out fk))) {
                        tblPotentialStudentInfo.NationalID.FormValue = fk;
                        NationalID.FormValue = tblPotentialStudentInfo.NationalID.FormValue;
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
                if (masterTblVar != "tblPotentialStudentInfo") {
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
