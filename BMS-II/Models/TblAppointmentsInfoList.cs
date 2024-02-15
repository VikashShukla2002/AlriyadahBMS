namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAppointmentsInfoList
    /// </summary>
    public static TblAppointmentsInfoList tblAppointmentsInfoList
    {
        get => HttpData.Get<TblAppointmentsInfoList>("tblAppointmentsInfoList")!;
        set => HttpData["tblAppointmentsInfoList"] = value;
    }

    /// <summary>
    /// Page class for tblAppointmentsInfo
    /// </summary>
    public class TblAppointmentsInfoList : TblAppointmentsInfoListBase
    {
        // Constructor
        public TblAppointmentsInfoList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAppointmentsInfoList() : base()
        {
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
    public class TblAppointmentsInfoListBase : TblAppointmentsInfo
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAppointmentsInfo";

        // Page object name
        public string PageObjName = "tblAppointmentsInfoList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblAppointmentsInfolist";

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
        public TblAppointmentsInfoListBase()
        {
            // CSS class name as context
            TableVar = "tblAppointmentsInfo";
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

            // Table object (tblAppointmentsInfo)
            if (tblAppointmentsInfo == null || tblAppointmentsInfo is TblAppointmentsInfo)
                tblAppointmentsInfo = this;

            // Initialize URLs
            AddUrl = "TblAppointmentsInfoAdd";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblAppointmentsInfoDelete";
            MultiUpdateUrl = "TblAppointmentsInfoUpdate";

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
        public string PageName => "TblAppointmentsInfoList";

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
            int_Appt_id.Visible = false;
            str_AppName.SetVisibility();
            str_App_Date.SetVisibility();
            str_StartTime.SetVisibility();
            str_EndTime.Visible = false;
            str_PickupTime.Visible = false;
            str_DropOffTime.Visible = false;
            int_VehicleID.Visible = false;
            dec_InstID.Visible = false;
            dec_StudentID.Visible = false;
            dec_Observed_StudentID.Visible = false;
            int_Apptype.SetVisibility();
            int_AppStatus.SetVisibility();
            mny_AppCost.SetVisibility();
            mny_AmountPaid.SetVisibility();
            bit_CheckAppPaid.Visible = false;
            bit_Confirmation.Visible = false;
            str_Instructions.Visible = false;
            str_Instructions1.Visible = false;
            str_AppNotes.Visible = false;
            str_PickupLocation.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            date_Created.Visible = false;
            date_Modified.Visible = false;
            bit_IsDeleted.Visible = false;
            str_Interval.Visible = false;
            RemM1.Visible = false;
            RemM2.Visible = false;
            RemM3.Visible = false;
            int_Location_ID.Visible = false;
            SPID.Visible = false;
            Chk_Trace.Visible = false;
            str_DropOffLocation.Visible = false;
            imgInstructorSignature.Visible = false;
            imgStudentSignature.Visible = false;
            imgObserverSignature.Visible = false;
            dt_apptstart.Visible = false;
            dt_apptComplete.Visible = false;
            int_apptstartedBy.Visible = false;
            int_apptCompletedBy.Visible = false;
            SMSReminder1.Visible = false;
            SMSReminder2.Visible = false;
            SMSReminder3.Visible = false;
            VoiceReminder1.Visible = false;
            VoiceReminder2.Visible = false;
            VoiceReminder3.Visible = false;
            bit_isroadtest.Visible = false;
            int_slotType.Visible = false;
            bit_VisibleOnPortal.Visible = false;
            IsDataRetrieved.Visible = false;
            bit_chargesApplied.Visible = false;
            dec_DistanceTravelled.Visible = false;
            btwProductIdsforSSRules.Visible = false;
            int_evaluateApptWithEmail.Visible = false;
            PublicNotesId.Visible = false;
            NationalID.SetVisibility();
            str_Username.Visible = false;
            int_PackageID.Visible = false;
            int_ApptCldr_ID.Visible = false;
            str_CRSS_ID.Visible = false;
        }

        // Constructor
        public TblAppointmentsInfoListBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblAppointmentsInfoView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Appt_id") ? dict["int_Appt_id"] : int_Appt_id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Appt_id.Visible = false;
            if (IsAddOrEdit)
                date_Created.Visible = false;
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
            await SetupLookupOptions(int_Apptype);
            await SetupLookupOptions(int_AppStatus);
            await SetupLookupOptions(bit_CheckAppPaid);
            await SetupLookupOptions(bit_Confirmation);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(RemM1);
            await SetupLookupOptions(RemM2);
            await SetupLookupOptions(RemM3);
            await SetupLookupOptions(SMSReminder1);
            await SetupLookupOptions(SMSReminder2);
            await SetupLookupOptions(SMSReminder3);
            await SetupLookupOptions(VoiceReminder1);
            await SetupLookupOptions(VoiceReminder2);
            await SetupLookupOptions(VoiceReminder3);
            await SetupLookupOptions(bit_isroadtest);
            await SetupLookupOptions(bit_VisibleOnPortal);
            await SetupLookupOptions(IsDataRetrieved);
            await SetupLookupOptions(bit_chargesApplied);

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblAppointmentsInfogrid";

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
                tblAppointmentsInfoList?.PageRender();
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
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblAppointmentsInfosrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Appt_id.AdvancedSearch.ToJson())); // Field int_Appt_id
            filters.Merge(JObject.Parse(str_AppName.AdvancedSearch.ToJson())); // Field str_AppName
            filters.Merge(JObject.Parse(str_App_Date.AdvancedSearch.ToJson())); // Field str_App_Date
            filters.Merge(JObject.Parse(str_StartTime.AdvancedSearch.ToJson())); // Field str_StartTime
            filters.Merge(JObject.Parse(str_EndTime.AdvancedSearch.ToJson())); // Field str_EndTime
            filters.Merge(JObject.Parse(str_PickupTime.AdvancedSearch.ToJson())); // Field str_PickupTime
            filters.Merge(JObject.Parse(str_DropOffTime.AdvancedSearch.ToJson())); // Field str_DropOffTime
            filters.Merge(JObject.Parse(int_VehicleID.AdvancedSearch.ToJson())); // Field int_VehicleID
            filters.Merge(JObject.Parse(dec_InstID.AdvancedSearch.ToJson())); // Field dec_InstID
            filters.Merge(JObject.Parse(dec_StudentID.AdvancedSearch.ToJson())); // Field dec_StudentID
            filters.Merge(JObject.Parse(dec_Observed_StudentID.AdvancedSearch.ToJson())); // Field dec_Observed_StudentID
            filters.Merge(JObject.Parse(int_Apptype.AdvancedSearch.ToJson())); // Field int_Apptype
            filters.Merge(JObject.Parse(int_AppStatus.AdvancedSearch.ToJson())); // Field int_AppStatus
            filters.Merge(JObject.Parse(mny_AppCost.AdvancedSearch.ToJson())); // Field mny_AppCost
            filters.Merge(JObject.Parse(mny_AmountPaid.AdvancedSearch.ToJson())); // Field mny_AmountPaid
            filters.Merge(JObject.Parse(bit_CheckAppPaid.AdvancedSearch.ToJson())); // Field bit_CheckAppPaid
            filters.Merge(JObject.Parse(bit_Confirmation.AdvancedSearch.ToJson())); // Field bit_Confirmation
            filters.Merge(JObject.Parse(str_Instructions.AdvancedSearch.ToJson())); // Field str_Instructions
            filters.Merge(JObject.Parse(str_Instructions1.AdvancedSearch.ToJson())); // Field str_Instructions1
            filters.Merge(JObject.Parse(str_AppNotes.AdvancedSearch.ToJson())); // Field str_AppNotes
            filters.Merge(JObject.Parse(str_PickupLocation.AdvancedSearch.ToJson())); // Field str_PickupLocation
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(str_Interval.AdvancedSearch.ToJson())); // Field str_Interval
            filters.Merge(JObject.Parse(RemM1.AdvancedSearch.ToJson())); // Field RemM1
            filters.Merge(JObject.Parse(RemM2.AdvancedSearch.ToJson())); // Field RemM2
            filters.Merge(JObject.Parse(RemM3.AdvancedSearch.ToJson())); // Field RemM3
            filters.Merge(JObject.Parse(int_Location_ID.AdvancedSearch.ToJson())); // Field int_Location_ID
            filters.Merge(JObject.Parse(SPID.AdvancedSearch.ToJson())); // Field SPID
            filters.Merge(JObject.Parse(Chk_Trace.AdvancedSearch.ToJson())); // Field Chk_Trace
            filters.Merge(JObject.Parse(str_DropOffLocation.AdvancedSearch.ToJson())); // Field str_DropOffLocation
            filters.Merge(JObject.Parse(dt_apptstart.AdvancedSearch.ToJson())); // Field dt_apptstart
            filters.Merge(JObject.Parse(dt_apptComplete.AdvancedSearch.ToJson())); // Field dt_apptComplete
            filters.Merge(JObject.Parse(int_apptstartedBy.AdvancedSearch.ToJson())); // Field int_apptstartedBy
            filters.Merge(JObject.Parse(int_apptCompletedBy.AdvancedSearch.ToJson())); // Field int_apptCompletedBy
            filters.Merge(JObject.Parse(SMSReminder1.AdvancedSearch.ToJson())); // Field SMSReminder1
            filters.Merge(JObject.Parse(SMSReminder2.AdvancedSearch.ToJson())); // Field SMSReminder2
            filters.Merge(JObject.Parse(SMSReminder3.AdvancedSearch.ToJson())); // Field SMSReminder3
            filters.Merge(JObject.Parse(VoiceReminder1.AdvancedSearch.ToJson())); // Field VoiceReminder1
            filters.Merge(JObject.Parse(VoiceReminder2.AdvancedSearch.ToJson())); // Field VoiceReminder2
            filters.Merge(JObject.Parse(VoiceReminder3.AdvancedSearch.ToJson())); // Field VoiceReminder3
            filters.Merge(JObject.Parse(bit_isroadtest.AdvancedSearch.ToJson())); // Field bit_isroadtest
            filters.Merge(JObject.Parse(int_slotType.AdvancedSearch.ToJson())); // Field int_slotType
            filters.Merge(JObject.Parse(bit_VisibleOnPortal.AdvancedSearch.ToJson())); // Field bit_VisibleOnPortal
            filters.Merge(JObject.Parse(IsDataRetrieved.AdvancedSearch.ToJson())); // Field IsDataRetrieved
            filters.Merge(JObject.Parse(bit_chargesApplied.AdvancedSearch.ToJson())); // Field bit_chargesApplied
            filters.Merge(JObject.Parse(dec_DistanceTravelled.AdvancedSearch.ToJson())); // Field dec_DistanceTravelled
            filters.Merge(JObject.Parse(btwProductIdsforSSRules.AdvancedSearch.ToJson())); // Field btwProductIdsforSSRules
            filters.Merge(JObject.Parse(int_evaluateApptWithEmail.AdvancedSearch.ToJson())); // Field int_evaluateApptWithEmail
            filters.Merge(JObject.Parse(PublicNotesId.AdvancedSearch.ToJson())); // Field PublicNotesId
            filters.Merge(JObject.Parse(NationalID.AdvancedSearch.ToJson())); // Field NationalID
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(int_PackageID.AdvancedSearch.ToJson())); // Field int_PackageID
            filters.Merge(JObject.Parse(int_ApptCldr_ID.AdvancedSearch.ToJson())); // Field int_ApptCldr_ID
            filters.Merge(JObject.Parse(str_CRSS_ID.AdvancedSearch.ToJson())); // Field str_CRSS_ID
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblAppointmentsInfosrch", filters);
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

            // Field int_Appt_id
            if (filter?.TryGetValue("x_int_Appt_id", out sv) ?? false) {
                int_Appt_id.AdvancedSearch.SearchValue = sv;
                int_Appt_id.AdvancedSearch.SearchOperator = filter["z_int_Appt_id"];
                int_Appt_id.AdvancedSearch.SearchCondition = filter["v_int_Appt_id"];
                int_Appt_id.AdvancedSearch.SearchValue2 = filter["y_int_Appt_id"];
                int_Appt_id.AdvancedSearch.SearchOperator2 = filter["w_int_Appt_id"];
                int_Appt_id.AdvancedSearch.Save();
            }

            // Field str_AppName
            if (filter?.TryGetValue("x_str_AppName", out sv) ?? false) {
                str_AppName.AdvancedSearch.SearchValue = sv;
                str_AppName.AdvancedSearch.SearchOperator = filter["z_str_AppName"];
                str_AppName.AdvancedSearch.SearchCondition = filter["v_str_AppName"];
                str_AppName.AdvancedSearch.SearchValue2 = filter["y_str_AppName"];
                str_AppName.AdvancedSearch.SearchOperator2 = filter["w_str_AppName"];
                str_AppName.AdvancedSearch.Save();
            }

            // Field str_App_Date
            if (filter?.TryGetValue("x_str_App_Date", out sv) ?? false) {
                str_App_Date.AdvancedSearch.SearchValue = sv;
                str_App_Date.AdvancedSearch.SearchOperator = filter["z_str_App_Date"];
                str_App_Date.AdvancedSearch.SearchCondition = filter["v_str_App_Date"];
                str_App_Date.AdvancedSearch.SearchValue2 = filter["y_str_App_Date"];
                str_App_Date.AdvancedSearch.SearchOperator2 = filter["w_str_App_Date"];
                str_App_Date.AdvancedSearch.Save();
            }

            // Field str_StartTime
            if (filter?.TryGetValue("x_str_StartTime", out sv) ?? false) {
                str_StartTime.AdvancedSearch.SearchValue = sv;
                str_StartTime.AdvancedSearch.SearchOperator = filter["z_str_StartTime"];
                str_StartTime.AdvancedSearch.SearchCondition = filter["v_str_StartTime"];
                str_StartTime.AdvancedSearch.SearchValue2 = filter["y_str_StartTime"];
                str_StartTime.AdvancedSearch.SearchOperator2 = filter["w_str_StartTime"];
                str_StartTime.AdvancedSearch.Save();
            }

            // Field str_EndTime
            if (filter?.TryGetValue("x_str_EndTime", out sv) ?? false) {
                str_EndTime.AdvancedSearch.SearchValue = sv;
                str_EndTime.AdvancedSearch.SearchOperator = filter["z_str_EndTime"];
                str_EndTime.AdvancedSearch.SearchCondition = filter["v_str_EndTime"];
                str_EndTime.AdvancedSearch.SearchValue2 = filter["y_str_EndTime"];
                str_EndTime.AdvancedSearch.SearchOperator2 = filter["w_str_EndTime"];
                str_EndTime.AdvancedSearch.Save();
            }

            // Field str_PickupTime
            if (filter?.TryGetValue("x_str_PickupTime", out sv) ?? false) {
                str_PickupTime.AdvancedSearch.SearchValue = sv;
                str_PickupTime.AdvancedSearch.SearchOperator = filter["z_str_PickupTime"];
                str_PickupTime.AdvancedSearch.SearchCondition = filter["v_str_PickupTime"];
                str_PickupTime.AdvancedSearch.SearchValue2 = filter["y_str_PickupTime"];
                str_PickupTime.AdvancedSearch.SearchOperator2 = filter["w_str_PickupTime"];
                str_PickupTime.AdvancedSearch.Save();
            }

            // Field str_DropOffTime
            if (filter?.TryGetValue("x_str_DropOffTime", out sv) ?? false) {
                str_DropOffTime.AdvancedSearch.SearchValue = sv;
                str_DropOffTime.AdvancedSearch.SearchOperator = filter["z_str_DropOffTime"];
                str_DropOffTime.AdvancedSearch.SearchCondition = filter["v_str_DropOffTime"];
                str_DropOffTime.AdvancedSearch.SearchValue2 = filter["y_str_DropOffTime"];
                str_DropOffTime.AdvancedSearch.SearchOperator2 = filter["w_str_DropOffTime"];
                str_DropOffTime.AdvancedSearch.Save();
            }

            // Field int_VehicleID
            if (filter?.TryGetValue("x_int_VehicleID", out sv) ?? false) {
                int_VehicleID.AdvancedSearch.SearchValue = sv;
                int_VehicleID.AdvancedSearch.SearchOperator = filter["z_int_VehicleID"];
                int_VehicleID.AdvancedSearch.SearchCondition = filter["v_int_VehicleID"];
                int_VehicleID.AdvancedSearch.SearchValue2 = filter["y_int_VehicleID"];
                int_VehicleID.AdvancedSearch.SearchOperator2 = filter["w_int_VehicleID"];
                int_VehicleID.AdvancedSearch.Save();
            }

            // Field dec_InstID
            if (filter?.TryGetValue("x_dec_InstID", out sv) ?? false) {
                dec_InstID.AdvancedSearch.SearchValue = sv;
                dec_InstID.AdvancedSearch.SearchOperator = filter["z_dec_InstID"];
                dec_InstID.AdvancedSearch.SearchCondition = filter["v_dec_InstID"];
                dec_InstID.AdvancedSearch.SearchValue2 = filter["y_dec_InstID"];
                dec_InstID.AdvancedSearch.SearchOperator2 = filter["w_dec_InstID"];
                dec_InstID.AdvancedSearch.Save();
            }

            // Field dec_StudentID
            if (filter?.TryGetValue("x_dec_StudentID", out sv) ?? false) {
                dec_StudentID.AdvancedSearch.SearchValue = sv;
                dec_StudentID.AdvancedSearch.SearchOperator = filter["z_dec_StudentID"];
                dec_StudentID.AdvancedSearch.SearchCondition = filter["v_dec_StudentID"];
                dec_StudentID.AdvancedSearch.SearchValue2 = filter["y_dec_StudentID"];
                dec_StudentID.AdvancedSearch.SearchOperator2 = filter["w_dec_StudentID"];
                dec_StudentID.AdvancedSearch.Save();
            }

            // Field dec_Observed_StudentID
            if (filter?.TryGetValue("x_dec_Observed_StudentID", out sv) ?? false) {
                dec_Observed_StudentID.AdvancedSearch.SearchValue = sv;
                dec_Observed_StudentID.AdvancedSearch.SearchOperator = filter["z_dec_Observed_StudentID"];
                dec_Observed_StudentID.AdvancedSearch.SearchCondition = filter["v_dec_Observed_StudentID"];
                dec_Observed_StudentID.AdvancedSearch.SearchValue2 = filter["y_dec_Observed_StudentID"];
                dec_Observed_StudentID.AdvancedSearch.SearchOperator2 = filter["w_dec_Observed_StudentID"];
                dec_Observed_StudentID.AdvancedSearch.Save();
            }

            // Field int_Apptype
            if (filter?.TryGetValue("x_int_Apptype", out sv) ?? false) {
                int_Apptype.AdvancedSearch.SearchValue = sv;
                int_Apptype.AdvancedSearch.SearchOperator = filter["z_int_Apptype"];
                int_Apptype.AdvancedSearch.SearchCondition = filter["v_int_Apptype"];
                int_Apptype.AdvancedSearch.SearchValue2 = filter["y_int_Apptype"];
                int_Apptype.AdvancedSearch.SearchOperator2 = filter["w_int_Apptype"];
                int_Apptype.AdvancedSearch.Save();
            }

            // Field int_AppStatus
            if (filter?.TryGetValue("x_int_AppStatus", out sv) ?? false) {
                int_AppStatus.AdvancedSearch.SearchValue = sv;
                int_AppStatus.AdvancedSearch.SearchOperator = filter["z_int_AppStatus"];
                int_AppStatus.AdvancedSearch.SearchCondition = filter["v_int_AppStatus"];
                int_AppStatus.AdvancedSearch.SearchValue2 = filter["y_int_AppStatus"];
                int_AppStatus.AdvancedSearch.SearchOperator2 = filter["w_int_AppStatus"];
                int_AppStatus.AdvancedSearch.Save();
            }

            // Field mny_AppCost
            if (filter?.TryGetValue("x_mny_AppCost", out sv) ?? false) {
                mny_AppCost.AdvancedSearch.SearchValue = sv;
                mny_AppCost.AdvancedSearch.SearchOperator = filter["z_mny_AppCost"];
                mny_AppCost.AdvancedSearch.SearchCondition = filter["v_mny_AppCost"];
                mny_AppCost.AdvancedSearch.SearchValue2 = filter["y_mny_AppCost"];
                mny_AppCost.AdvancedSearch.SearchOperator2 = filter["w_mny_AppCost"];
                mny_AppCost.AdvancedSearch.Save();
            }

            // Field mny_AmountPaid
            if (filter?.TryGetValue("x_mny_AmountPaid", out sv) ?? false) {
                mny_AmountPaid.AdvancedSearch.SearchValue = sv;
                mny_AmountPaid.AdvancedSearch.SearchOperator = filter["z_mny_AmountPaid"];
                mny_AmountPaid.AdvancedSearch.SearchCondition = filter["v_mny_AmountPaid"];
                mny_AmountPaid.AdvancedSearch.SearchValue2 = filter["y_mny_AmountPaid"];
                mny_AmountPaid.AdvancedSearch.SearchOperator2 = filter["w_mny_AmountPaid"];
                mny_AmountPaid.AdvancedSearch.Save();
            }

            // Field bit_CheckAppPaid
            if (filter?.TryGetValue("x_bit_CheckAppPaid", out sv) ?? false) {
                bit_CheckAppPaid.AdvancedSearch.SearchValue = sv;
                bit_CheckAppPaid.AdvancedSearch.SearchOperator = filter["z_bit_CheckAppPaid"];
                bit_CheckAppPaid.AdvancedSearch.SearchCondition = filter["v_bit_CheckAppPaid"];
                bit_CheckAppPaid.AdvancedSearch.SearchValue2 = filter["y_bit_CheckAppPaid"];
                bit_CheckAppPaid.AdvancedSearch.SearchOperator2 = filter["w_bit_CheckAppPaid"];
                bit_CheckAppPaid.AdvancedSearch.Save();
            }

            // Field bit_Confirmation
            if (filter?.TryGetValue("x_bit_Confirmation", out sv) ?? false) {
                bit_Confirmation.AdvancedSearch.SearchValue = sv;
                bit_Confirmation.AdvancedSearch.SearchOperator = filter["z_bit_Confirmation"];
                bit_Confirmation.AdvancedSearch.SearchCondition = filter["v_bit_Confirmation"];
                bit_Confirmation.AdvancedSearch.SearchValue2 = filter["y_bit_Confirmation"];
                bit_Confirmation.AdvancedSearch.SearchOperator2 = filter["w_bit_Confirmation"];
                bit_Confirmation.AdvancedSearch.Save();
            }

            // Field str_Instructions
            if (filter?.TryGetValue("x_str_Instructions", out sv) ?? false) {
                str_Instructions.AdvancedSearch.SearchValue = sv;
                str_Instructions.AdvancedSearch.SearchOperator = filter["z_str_Instructions"];
                str_Instructions.AdvancedSearch.SearchCondition = filter["v_str_Instructions"];
                str_Instructions.AdvancedSearch.SearchValue2 = filter["y_str_Instructions"];
                str_Instructions.AdvancedSearch.SearchOperator2 = filter["w_str_Instructions"];
                str_Instructions.AdvancedSearch.Save();
            }

            // Field str_Instructions1
            if (filter?.TryGetValue("x_str_Instructions1", out sv) ?? false) {
                str_Instructions1.AdvancedSearch.SearchValue = sv;
                str_Instructions1.AdvancedSearch.SearchOperator = filter["z_str_Instructions1"];
                str_Instructions1.AdvancedSearch.SearchCondition = filter["v_str_Instructions1"];
                str_Instructions1.AdvancedSearch.SearchValue2 = filter["y_str_Instructions1"];
                str_Instructions1.AdvancedSearch.SearchOperator2 = filter["w_str_Instructions1"];
                str_Instructions1.AdvancedSearch.Save();
            }

            // Field str_AppNotes
            if (filter?.TryGetValue("x_str_AppNotes", out sv) ?? false) {
                str_AppNotes.AdvancedSearch.SearchValue = sv;
                str_AppNotes.AdvancedSearch.SearchOperator = filter["z_str_AppNotes"];
                str_AppNotes.AdvancedSearch.SearchCondition = filter["v_str_AppNotes"];
                str_AppNotes.AdvancedSearch.SearchValue2 = filter["y_str_AppNotes"];
                str_AppNotes.AdvancedSearch.SearchOperator2 = filter["w_str_AppNotes"];
                str_AppNotes.AdvancedSearch.Save();
            }

            // Field str_PickupLocation
            if (filter?.TryGetValue("x_str_PickupLocation", out sv) ?? false) {
                str_PickupLocation.AdvancedSearch.SearchValue = sv;
                str_PickupLocation.AdvancedSearch.SearchOperator = filter["z_str_PickupLocation"];
                str_PickupLocation.AdvancedSearch.SearchCondition = filter["v_str_PickupLocation"];
                str_PickupLocation.AdvancedSearch.SearchValue2 = filter["y_str_PickupLocation"];
                str_PickupLocation.AdvancedSearch.SearchOperator2 = filter["w_str_PickupLocation"];
                str_PickupLocation.AdvancedSearch.Save();
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

            // Field str_Interval
            if (filter?.TryGetValue("x_str_Interval", out sv) ?? false) {
                str_Interval.AdvancedSearch.SearchValue = sv;
                str_Interval.AdvancedSearch.SearchOperator = filter["z_str_Interval"];
                str_Interval.AdvancedSearch.SearchCondition = filter["v_str_Interval"];
                str_Interval.AdvancedSearch.SearchValue2 = filter["y_str_Interval"];
                str_Interval.AdvancedSearch.SearchOperator2 = filter["w_str_Interval"];
                str_Interval.AdvancedSearch.Save();
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

            // Field int_Location_ID
            if (filter?.TryGetValue("x_int_Location_ID", out sv) ?? false) {
                int_Location_ID.AdvancedSearch.SearchValue = sv;
                int_Location_ID.AdvancedSearch.SearchOperator = filter["z_int_Location_ID"];
                int_Location_ID.AdvancedSearch.SearchCondition = filter["v_int_Location_ID"];
                int_Location_ID.AdvancedSearch.SearchValue2 = filter["y_int_Location_ID"];
                int_Location_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Location_ID"];
                int_Location_ID.AdvancedSearch.Save();
            }

            // Field SPID
            if (filter?.TryGetValue("x_SPID", out sv) ?? false) {
                SPID.AdvancedSearch.SearchValue = sv;
                SPID.AdvancedSearch.SearchOperator = filter["z_SPID"];
                SPID.AdvancedSearch.SearchCondition = filter["v_SPID"];
                SPID.AdvancedSearch.SearchValue2 = filter["y_SPID"];
                SPID.AdvancedSearch.SearchOperator2 = filter["w_SPID"];
                SPID.AdvancedSearch.Save();
            }

            // Field Chk_Trace
            if (filter?.TryGetValue("x_Chk_Trace", out sv) ?? false) {
                Chk_Trace.AdvancedSearch.SearchValue = sv;
                Chk_Trace.AdvancedSearch.SearchOperator = filter["z_Chk_Trace"];
                Chk_Trace.AdvancedSearch.SearchCondition = filter["v_Chk_Trace"];
                Chk_Trace.AdvancedSearch.SearchValue2 = filter["y_Chk_Trace"];
                Chk_Trace.AdvancedSearch.SearchOperator2 = filter["w_Chk_Trace"];
                Chk_Trace.AdvancedSearch.Save();
            }

            // Field str_DropOffLocation
            if (filter?.TryGetValue("x_str_DropOffLocation", out sv) ?? false) {
                str_DropOffLocation.AdvancedSearch.SearchValue = sv;
                str_DropOffLocation.AdvancedSearch.SearchOperator = filter["z_str_DropOffLocation"];
                str_DropOffLocation.AdvancedSearch.SearchCondition = filter["v_str_DropOffLocation"];
                str_DropOffLocation.AdvancedSearch.SearchValue2 = filter["y_str_DropOffLocation"];
                str_DropOffLocation.AdvancedSearch.SearchOperator2 = filter["w_str_DropOffLocation"];
                str_DropOffLocation.AdvancedSearch.Save();
            }

            // Field dt_apptstart
            if (filter?.TryGetValue("x_dt_apptstart", out sv) ?? false) {
                dt_apptstart.AdvancedSearch.SearchValue = sv;
                dt_apptstart.AdvancedSearch.SearchOperator = filter["z_dt_apptstart"];
                dt_apptstart.AdvancedSearch.SearchCondition = filter["v_dt_apptstart"];
                dt_apptstart.AdvancedSearch.SearchValue2 = filter["y_dt_apptstart"];
                dt_apptstart.AdvancedSearch.SearchOperator2 = filter["w_dt_apptstart"];
                dt_apptstart.AdvancedSearch.Save();
            }

            // Field dt_apptComplete
            if (filter?.TryGetValue("x_dt_apptComplete", out sv) ?? false) {
                dt_apptComplete.AdvancedSearch.SearchValue = sv;
                dt_apptComplete.AdvancedSearch.SearchOperator = filter["z_dt_apptComplete"];
                dt_apptComplete.AdvancedSearch.SearchCondition = filter["v_dt_apptComplete"];
                dt_apptComplete.AdvancedSearch.SearchValue2 = filter["y_dt_apptComplete"];
                dt_apptComplete.AdvancedSearch.SearchOperator2 = filter["w_dt_apptComplete"];
                dt_apptComplete.AdvancedSearch.Save();
            }

            // Field int_apptstartedBy
            if (filter?.TryGetValue("x_int_apptstartedBy", out sv) ?? false) {
                int_apptstartedBy.AdvancedSearch.SearchValue = sv;
                int_apptstartedBy.AdvancedSearch.SearchOperator = filter["z_int_apptstartedBy"];
                int_apptstartedBy.AdvancedSearch.SearchCondition = filter["v_int_apptstartedBy"];
                int_apptstartedBy.AdvancedSearch.SearchValue2 = filter["y_int_apptstartedBy"];
                int_apptstartedBy.AdvancedSearch.SearchOperator2 = filter["w_int_apptstartedBy"];
                int_apptstartedBy.AdvancedSearch.Save();
            }

            // Field int_apptCompletedBy
            if (filter?.TryGetValue("x_int_apptCompletedBy", out sv) ?? false) {
                int_apptCompletedBy.AdvancedSearch.SearchValue = sv;
                int_apptCompletedBy.AdvancedSearch.SearchOperator = filter["z_int_apptCompletedBy"];
                int_apptCompletedBy.AdvancedSearch.SearchCondition = filter["v_int_apptCompletedBy"];
                int_apptCompletedBy.AdvancedSearch.SearchValue2 = filter["y_int_apptCompletedBy"];
                int_apptCompletedBy.AdvancedSearch.SearchOperator2 = filter["w_int_apptCompletedBy"];
                int_apptCompletedBy.AdvancedSearch.Save();
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

            // Field bit_isroadtest
            if (filter?.TryGetValue("x_bit_isroadtest", out sv) ?? false) {
                bit_isroadtest.AdvancedSearch.SearchValue = sv;
                bit_isroadtest.AdvancedSearch.SearchOperator = filter["z_bit_isroadtest"];
                bit_isroadtest.AdvancedSearch.SearchCondition = filter["v_bit_isroadtest"];
                bit_isroadtest.AdvancedSearch.SearchValue2 = filter["y_bit_isroadtest"];
                bit_isroadtest.AdvancedSearch.SearchOperator2 = filter["w_bit_isroadtest"];
                bit_isroadtest.AdvancedSearch.Save();
            }

            // Field int_slotType
            if (filter?.TryGetValue("x_int_slotType", out sv) ?? false) {
                int_slotType.AdvancedSearch.SearchValue = sv;
                int_slotType.AdvancedSearch.SearchOperator = filter["z_int_slotType"];
                int_slotType.AdvancedSearch.SearchCondition = filter["v_int_slotType"];
                int_slotType.AdvancedSearch.SearchValue2 = filter["y_int_slotType"];
                int_slotType.AdvancedSearch.SearchOperator2 = filter["w_int_slotType"];
                int_slotType.AdvancedSearch.Save();
            }

            // Field bit_VisibleOnPortal
            if (filter?.TryGetValue("x_bit_VisibleOnPortal", out sv) ?? false) {
                bit_VisibleOnPortal.AdvancedSearch.SearchValue = sv;
                bit_VisibleOnPortal.AdvancedSearch.SearchOperator = filter["z_bit_VisibleOnPortal"];
                bit_VisibleOnPortal.AdvancedSearch.SearchCondition = filter["v_bit_VisibleOnPortal"];
                bit_VisibleOnPortal.AdvancedSearch.SearchValue2 = filter["y_bit_VisibleOnPortal"];
                bit_VisibleOnPortal.AdvancedSearch.SearchOperator2 = filter["w_bit_VisibleOnPortal"];
                bit_VisibleOnPortal.AdvancedSearch.Save();
            }

            // Field IsDataRetrieved
            if (filter?.TryGetValue("x_IsDataRetrieved", out sv) ?? false) {
                IsDataRetrieved.AdvancedSearch.SearchValue = sv;
                IsDataRetrieved.AdvancedSearch.SearchOperator = filter["z_IsDataRetrieved"];
                IsDataRetrieved.AdvancedSearch.SearchCondition = filter["v_IsDataRetrieved"];
                IsDataRetrieved.AdvancedSearch.SearchValue2 = filter["y_IsDataRetrieved"];
                IsDataRetrieved.AdvancedSearch.SearchOperator2 = filter["w_IsDataRetrieved"];
                IsDataRetrieved.AdvancedSearch.Save();
            }

            // Field bit_chargesApplied
            if (filter?.TryGetValue("x_bit_chargesApplied", out sv) ?? false) {
                bit_chargesApplied.AdvancedSearch.SearchValue = sv;
                bit_chargesApplied.AdvancedSearch.SearchOperator = filter["z_bit_chargesApplied"];
                bit_chargesApplied.AdvancedSearch.SearchCondition = filter["v_bit_chargesApplied"];
                bit_chargesApplied.AdvancedSearch.SearchValue2 = filter["y_bit_chargesApplied"];
                bit_chargesApplied.AdvancedSearch.SearchOperator2 = filter["w_bit_chargesApplied"];
                bit_chargesApplied.AdvancedSearch.Save();
            }

            // Field dec_DistanceTravelled
            if (filter?.TryGetValue("x_dec_DistanceTravelled", out sv) ?? false) {
                dec_DistanceTravelled.AdvancedSearch.SearchValue = sv;
                dec_DistanceTravelled.AdvancedSearch.SearchOperator = filter["z_dec_DistanceTravelled"];
                dec_DistanceTravelled.AdvancedSearch.SearchCondition = filter["v_dec_DistanceTravelled"];
                dec_DistanceTravelled.AdvancedSearch.SearchValue2 = filter["y_dec_DistanceTravelled"];
                dec_DistanceTravelled.AdvancedSearch.SearchOperator2 = filter["w_dec_DistanceTravelled"];
                dec_DistanceTravelled.AdvancedSearch.Save();
            }

            // Field btwProductIdsforSSRules
            if (filter?.TryGetValue("x_btwProductIdsforSSRules", out sv) ?? false) {
                btwProductIdsforSSRules.AdvancedSearch.SearchValue = sv;
                btwProductIdsforSSRules.AdvancedSearch.SearchOperator = filter["z_btwProductIdsforSSRules"];
                btwProductIdsforSSRules.AdvancedSearch.SearchCondition = filter["v_btwProductIdsforSSRules"];
                btwProductIdsforSSRules.AdvancedSearch.SearchValue2 = filter["y_btwProductIdsforSSRules"];
                btwProductIdsforSSRules.AdvancedSearch.SearchOperator2 = filter["w_btwProductIdsforSSRules"];
                btwProductIdsforSSRules.AdvancedSearch.Save();
            }

            // Field int_evaluateApptWithEmail
            if (filter?.TryGetValue("x_int_evaluateApptWithEmail", out sv) ?? false) {
                int_evaluateApptWithEmail.AdvancedSearch.SearchValue = sv;
                int_evaluateApptWithEmail.AdvancedSearch.SearchOperator = filter["z_int_evaluateApptWithEmail"];
                int_evaluateApptWithEmail.AdvancedSearch.SearchCondition = filter["v_int_evaluateApptWithEmail"];
                int_evaluateApptWithEmail.AdvancedSearch.SearchValue2 = filter["y_int_evaluateApptWithEmail"];
                int_evaluateApptWithEmail.AdvancedSearch.SearchOperator2 = filter["w_int_evaluateApptWithEmail"];
                int_evaluateApptWithEmail.AdvancedSearch.Save();
            }

            // Field PublicNotesId
            if (filter?.TryGetValue("x_PublicNotesId", out sv) ?? false) {
                PublicNotesId.AdvancedSearch.SearchValue = sv;
                PublicNotesId.AdvancedSearch.SearchOperator = filter["z_PublicNotesId"];
                PublicNotesId.AdvancedSearch.SearchCondition = filter["v_PublicNotesId"];
                PublicNotesId.AdvancedSearch.SearchValue2 = filter["y_PublicNotesId"];
                PublicNotesId.AdvancedSearch.SearchOperator2 = filter["w_PublicNotesId"];
                PublicNotesId.AdvancedSearch.Save();
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

            // Field str_Username
            if (filter?.TryGetValue("x_str_Username", out sv) ?? false) {
                str_Username.AdvancedSearch.SearchValue = sv;
                str_Username.AdvancedSearch.SearchOperator = filter["z_str_Username"];
                str_Username.AdvancedSearch.SearchCondition = filter["v_str_Username"];
                str_Username.AdvancedSearch.SearchValue2 = filter["y_str_Username"];
                str_Username.AdvancedSearch.SearchOperator2 = filter["w_str_Username"];
                str_Username.AdvancedSearch.Save();
            }

            // Field int_PackageID
            if (filter?.TryGetValue("x_int_PackageID", out sv) ?? false) {
                int_PackageID.AdvancedSearch.SearchValue = sv;
                int_PackageID.AdvancedSearch.SearchOperator = filter["z_int_PackageID"];
                int_PackageID.AdvancedSearch.SearchCondition = filter["v_int_PackageID"];
                int_PackageID.AdvancedSearch.SearchValue2 = filter["y_int_PackageID"];
                int_PackageID.AdvancedSearch.SearchOperator2 = filter["w_int_PackageID"];
                int_PackageID.AdvancedSearch.Save();
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

            // Field str_CRSS_ID
            if (filter?.TryGetValue("x_str_CRSS_ID", out sv) ?? false) {
                str_CRSS_ID.AdvancedSearch.SearchValue = sv;
                str_CRSS_ID.AdvancedSearch.SearchOperator = filter["z_str_CRSS_ID"];
                str_CRSS_ID.AdvancedSearch.SearchCondition = filter["v_str_CRSS_ID"];
                str_CRSS_ID.AdvancedSearch.SearchValue2 = filter["y_str_CRSS_ID"];
                str_CRSS_ID.AdvancedSearch.SearchOperator2 = filter["w_str_CRSS_ID"];
                str_CRSS_ID.AdvancedSearch.Save();
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
            searchFlds.Add(str_AppName);
            searchFlds.Add(str_App_Date);
            searchFlds.Add(str_StartTime);
            searchFlds.Add(str_EndTime);
            searchFlds.Add(str_PickupTime);
            searchFlds.Add(str_DropOffTime);
            searchFlds.Add(str_Instructions);
            searchFlds.Add(str_Instructions1);
            searchFlds.Add(str_AppNotes);
            searchFlds.Add(str_PickupLocation);
            searchFlds.Add(str_Interval);
            searchFlds.Add(Chk_Trace);
            searchFlds.Add(str_DropOffLocation);
            searchFlds.Add(btwProductIdsforSSRules);
            searchFlds.Add(PublicNotesId);
            searchFlds.Add(str_Username);
            searchFlds.Add(str_CRSS_ID);
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
                UpdateSort(str_AppName, ctrl); // str_AppName
                UpdateSort(str_App_Date, ctrl); // str_App_Date
                UpdateSort(str_StartTime, ctrl); // str_StartTime
                UpdateSort(int_Apptype, ctrl); // int_Apptype
                UpdateSort(int_AppStatus, ctrl); // int_AppStatus
                UpdateSort(mny_AppCost, ctrl); // mny_AppCost
                UpdateSort(mny_AmountPaid, ctrl); // mny_AmountPaid
                UpdateSort(NationalID, ctrl); // NationalID
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
                    int_Appt_id.Sort = "";
                    str_AppName.Sort = "";
                    str_App_Date.Sort = "";
                    str_StartTime.Sort = "";
                    str_EndTime.Sort = "";
                    str_PickupTime.Sort = "";
                    str_DropOffTime.Sort = "";
                    int_VehicleID.Sort = "";
                    dec_InstID.Sort = "";
                    dec_StudentID.Sort = "";
                    dec_Observed_StudentID.Sort = "";
                    int_Apptype.Sort = "";
                    int_AppStatus.Sort = "";
                    mny_AppCost.Sort = "";
                    mny_AmountPaid.Sort = "";
                    bit_CheckAppPaid.Sort = "";
                    bit_Confirmation.Sort = "";
                    str_Instructions.Sort = "";
                    str_Instructions1.Sort = "";
                    str_AppNotes.Sort = "";
                    str_PickupLocation.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    bit_IsDeleted.Sort = "";
                    str_Interval.Sort = "";
                    RemM1.Sort = "";
                    RemM2.Sort = "";
                    RemM3.Sort = "";
                    int_Location_ID.Sort = "";
                    SPID.Sort = "";
                    Chk_Trace.Sort = "";
                    str_DropOffLocation.Sort = "";
                    dt_apptstart.Sort = "";
                    dt_apptComplete.Sort = "";
                    int_apptstartedBy.Sort = "";
                    int_apptCompletedBy.Sort = "";
                    SMSReminder1.Sort = "";
                    SMSReminder2.Sort = "";
                    SMSReminder3.Sort = "";
                    VoiceReminder1.Sort = "";
                    VoiceReminder2.Sort = "";
                    VoiceReminder3.Sort = "";
                    bit_isroadtest.Sort = "";
                    int_slotType.Sort = "";
                    bit_VisibleOnPortal.Sort = "";
                    IsDataRetrieved.Sort = "";
                    bit_chargesApplied.Sort = "";
                    dec_DistanceTravelled.Sort = "";
                    btwProductIdsforSSRules.Sort = "";
                    int_evaluateApptWithEmail.Sort = "";
                    PublicNotesId.Sort = "";
                    NationalID.Sort = "";
                    str_Username.Sort = "";
                    int_PackageID.Sort = "";
                    int_ApptCldr_ID.Sort = "";
                    str_CRSS_ID.Sort = "";
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

            // "copy"
            item = ListOptions.Add("copy");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanAdd;
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;

            // "delete"
            item = ListOptions.Add("delete");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanDelete;
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
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-table=""tblAppointmentsInfo"" data-caption=""{viewcaption}"" data-ew-action=""modal"" data-action=""view"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(ViewUrl)) + "\" data-btn=\"null\">" + Language.Phrase("ViewLink") + "</a>");
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
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblAppointmentsInfo"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
                else
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-caption=""{editcaption}"" href=""" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("EditLink") + "</a>");
            } else {
                listOption?.Clear();
            }

            // "copy"
            listOption = ListOptions["copy"];
            string copycaption = Language.Phrase("CopyLink", true);
            isVisible = Security.CanAdd && ShowOptionLink("add");
            if (isVisible) {
                if (ModalAdd && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-copy"" title=""{copycaption}"" data-table=""tblAppointmentsInfo"" data-caption=""{copycaption}"" data-ew-action=""modal"" data-action=""add"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(CopyUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("CopyLink") + "</a>");
                else
                    listOption?.SetBody($@"<a class=""ew-row-link ew-copy"" title=""{copycaption}"" data-caption=""{copycaption}"" href=""" + HtmlEncode(AppPath(CopyUrl)) + "\">" + Language.Phrase("CopyLink") + "</a>");
            } else {
                listOption?.Clear();
            }

            // "delete"
            listOption = ListOptions["delete"];
            isVisible = Security.CanDelete && ShowOptionLink("delete");
            if (isVisible) {
                string deleteCaption = Language.Phrase("DeleteLink");
                string deleteTitle = Language.Phrase("DeleteLink", true);
                if (UseAjaxActions)
                    listOption?.SetBody($@"<a class=""ew-row-link ew-delete"" data-ew-action=""inline"" data-action=""delete"" title=""{deleteTitle}"" data-caption=""{deleteTitle}"" data-key=""" + HtmlEncode(GetKey(true)) + "\" data-url=\"" + HtmlEncode(AppPath(DeleteUrl)) + "\">" + deleteCaption + "</a>");
                else
                    listOption?.SetBody(@"<a class=""ew-row-link ew-delete""" +
                        (InlineDelete ? @" data-ew-action=""inline-delete""" : "") +
                        $@" title=""{deleteTitle}"" data-caption=""{deleteTitle}"" href=""" + HtmlEncode(AppPath(DeleteUrl)) + "\">" + deleteCaption + "</a>");
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblAppointmentsInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblAppointmentsInfolist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(int_Appt_id.CurrentValue) + "\"></div>");
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
                item.Body = $@"<a class=""ew-add-edit ew-add"" title=""{addTitle}"" data-table=""tblAppointmentsInfo"" data-caption=""{addTitle}"" data-ew-action=""modal"" data-action=""add"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(AddUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("AddLink") + "</a>";
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblAppointmentsInfolist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblAppointmentsInfosrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblAppointmentsInfosrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblAppointmentsInfolist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                    RowAttrs.Add("id", "r0_tblAppointmentsInfo");
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblAppointmentsInfoList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblAppointmentsInfoList.RowCount) + "_tblAppointmentsInfo");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblAppointmentsInfoList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblAppointmentsInfoList.RowType == RowType.Add || IsEdit && tblAppointmentsInfoList.RowType == RowType.Edit) // Inline-Add/Edit row
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
            int_Appt_id.SetDbValue(row["int_Appt_id"]);
            str_AppName.SetDbValue(row["str_AppName"]);
            str_App_Date.SetDbValue(row["str_App_Date"]);
            str_StartTime.SetDbValue(row["str_StartTime"]);
            str_EndTime.SetDbValue(row["str_EndTime"]);
            str_PickupTime.SetDbValue(row["str_PickupTime"]);
            str_DropOffTime.SetDbValue(row["str_DropOffTime"]);
            int_VehicleID.SetDbValue(row["int_VehicleID"]);
            dec_InstID.SetDbValue(IsNull(row["dec_InstID"]) ? DbNullValue : ConvertToDouble(row["dec_InstID"]));
            dec_StudentID.SetDbValue(row["dec_StudentID"]);
            dec_Observed_StudentID.SetDbValue(row["dec_Observed_StudentID"]);
            int_Apptype.SetDbValue(row["int_Apptype"]);
            int_AppStatus.SetDbValue(row["int_AppStatus"]);
            mny_AppCost.SetDbValue(row["mny_AppCost"]);
            mny_AmountPaid.SetDbValue(row["mny_AmountPaid"]);
            bit_CheckAppPaid.SetDbValue((ConvertToBool(row["bit_CheckAppPaid"]) ? "1" : "0"));
            bit_Confirmation.SetDbValue((ConvertToBool(row["bit_Confirmation"]) ? "1" : "0"));
            str_Instructions.SetDbValue(row["str_Instructions"]);
            str_Instructions1.SetDbValue(row["str_Instructions1"]);
            str_AppNotes.SetDbValue(row["str_AppNotes"]);
            str_PickupLocation.SetDbValue(row["str_PickupLocation"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_Interval.SetDbValue(row["str_Interval"]);
            RemM1.SetDbValue((ConvertToBool(row["RemM1"]) ? "1" : "0"));
            RemM2.SetDbValue((ConvertToBool(row["RemM2"]) ? "1" : "0"));
            RemM3.SetDbValue((ConvertToBool(row["RemM3"]) ? "1" : "0"));
            int_Location_ID.SetDbValue(IsNull(row["int_Location_ID"]) ? DbNullValue : ConvertToDouble(row["int_Location_ID"]));
            SPID.SetDbValue(IsNull(row["SPID"]) ? DbNullValue : ConvertToDouble(row["SPID"]));
            Chk_Trace.SetDbValue(row["Chk_Trace"]);
            str_DropOffLocation.SetDbValue(row["str_DropOffLocation"]);
            imgInstructorSignature.Upload.DbValue = row["imgInstructorSignature"];
            imgStudentSignature.Upload.DbValue = row["imgStudentSignature"];
            imgObserverSignature.Upload.DbValue = row["imgObserverSignature"];
            dt_apptstart.SetDbValue(row["dt_apptstart"]);
            dt_apptComplete.SetDbValue(row["dt_apptComplete"]);
            int_apptstartedBy.SetDbValue(row["int_apptstartedBy"]);
            int_apptCompletedBy.SetDbValue(row["int_apptCompletedBy"]);
            SMSReminder1.SetDbValue((ConvertToBool(row["SMSReminder1"]) ? "1" : "0"));
            SMSReminder2.SetDbValue((ConvertToBool(row["SMSReminder2"]) ? "1" : "0"));
            SMSReminder3.SetDbValue((ConvertToBool(row["SMSReminder3"]) ? "1" : "0"));
            VoiceReminder1.SetDbValue((ConvertToBool(row["VoiceReminder1"]) ? "1" : "0"));
            VoiceReminder2.SetDbValue((ConvertToBool(row["VoiceReminder2"]) ? "1" : "0"));
            VoiceReminder3.SetDbValue((ConvertToBool(row["VoiceReminder3"]) ? "1" : "0"));
            bit_isroadtest.SetDbValue((ConvertToBool(row["bit_isroadtest"]) ? "1" : "0"));
            int_slotType.SetDbValue(row["int_slotType"]);
            bit_VisibleOnPortal.SetDbValue((ConvertToBool(row["bit_VisibleOnPortal"]) ? "1" : "0"));
            IsDataRetrieved.SetDbValue((ConvertToBool(row["IsDataRetrieved"]) ? "1" : "0"));
            bit_chargesApplied.SetDbValue((ConvertToBool(row["bit_chargesApplied"]) ? "1" : "0"));
            dec_DistanceTravelled.SetDbValue(IsNull(row["dec_DistanceTravelled"]) ? DbNullValue : ConvertToDouble(row["dec_DistanceTravelled"]));
            btwProductIdsforSSRules.SetDbValue(row["btwProductIdsforSSRules"]);
            int_evaluateApptWithEmail.SetDbValue(row["int_evaluateApptWithEmail"]);
            PublicNotesId.SetDbValue(row["PublicNotesId"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_PackageID.SetDbValue(row["int_PackageID"]);
            int_ApptCldr_ID.SetDbValue(row["int_ApptCldr_ID"]);
            str_CRSS_ID.SetDbValue(row["str_CRSS_ID"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Appt_id", int_Appt_id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AppName", str_AppName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_App_Date", str_App_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("str_StartTime", str_StartTime.DefaultValue ?? DbNullValue); // DN
            row.Add("str_EndTime", str_EndTime.DefaultValue ?? DbNullValue); // DN
            row.Add("str_PickupTime", str_PickupTime.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DropOffTime", str_DropOffTime.DefaultValue ?? DbNullValue); // DN
            row.Add("int_VehicleID", int_VehicleID.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_InstID", dec_InstID.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_StudentID", dec_StudentID.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Observed_StudentID", dec_Observed_StudentID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Apptype", int_Apptype.DefaultValue ?? DbNullValue); // DN
            row.Add("int_AppStatus", int_AppStatus.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_AppCost", mny_AppCost.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_AmountPaid", mny_AmountPaid.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_CheckAppPaid", bit_CheckAppPaid.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Confirmation", bit_Confirmation.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Instructions", str_Instructions.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Instructions1", str_Instructions1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AppNotes", str_AppNotes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_PickupLocation", str_PickupLocation.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Interval", str_Interval.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM1", RemM1.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM2", RemM2.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM3", RemM3.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_ID", int_Location_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("SPID", SPID.DefaultValue ?? DbNullValue); // DN
            row.Add("Chk_Trace", Chk_Trace.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DropOffLocation", str_DropOffLocation.DefaultValue ?? DbNullValue); // DN
            row.Add("imgInstructorSignature", imgInstructorSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("imgStudentSignature", imgStudentSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("imgObserverSignature", imgObserverSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_apptstart", dt_apptstart.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_apptComplete", dt_apptComplete.DefaultValue ?? DbNullValue); // DN
            row.Add("int_apptstartedBy", int_apptstartedBy.DefaultValue ?? DbNullValue); // DN
            row.Add("int_apptCompletedBy", int_apptCompletedBy.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder1", SMSReminder1.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder2", SMSReminder2.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder3", SMSReminder3.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder1", VoiceReminder1.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder2", VoiceReminder2.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder3", VoiceReminder3.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_isroadtest", bit_isroadtest.DefaultValue ?? DbNullValue); // DN
            row.Add("int_slotType", int_slotType.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_VisibleOnPortal", bit_VisibleOnPortal.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDataRetrieved", IsDataRetrieved.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_chargesApplied", bit_chargesApplied.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_DistanceTravelled", dec_DistanceTravelled.DefaultValue ?? DbNullValue); // DN
            row.Add("btwProductIdsforSSRules", btwProductIdsforSSRules.DefaultValue ?? DbNullValue); // DN
            row.Add("int_evaluateApptWithEmail", int_evaluateApptWithEmail.DefaultValue ?? DbNullValue); // DN
            row.Add("PublicNotesId", PublicNotesId.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PackageID", int_PackageID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ApptCldr_ID", int_ApptCldr_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CRSS_ID", str_CRSS_ID.DefaultValue ?? DbNullValue); // DN
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

            // int_Appt_id

            // str_AppName

            // str_App_Date

            // str_StartTime

            // str_EndTime

            // str_PickupTime

            // str_DropOffTime

            // int_VehicleID

            // dec_InstID

            // dec_StudentID

            // dec_Observed_StudentID

            // int_Apptype

            // int_AppStatus

            // mny_AppCost

            // mny_AmountPaid

            // bit_CheckAppPaid

            // bit_Confirmation

            // str_Instructions

            // str_Instructions1

            // str_AppNotes

            // str_PickupLocation

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // str_Interval

            // RemM1

            // RemM2

            // RemM3

            // int_Location_ID

            // SPID

            // Chk_Trace

            // str_DropOffLocation

            // imgInstructorSignature

            // imgStudentSignature

            // imgObserverSignature

            // dt_apptstart

            // dt_apptComplete

            // int_apptstartedBy

            // int_apptCompletedBy

            // SMSReminder1

            // SMSReminder2

            // SMSReminder3

            // VoiceReminder1

            // VoiceReminder2

            // VoiceReminder3

            // bit_isroadtest

            // int_slotType

            // bit_VisibleOnPortal

            // IsDataRetrieved

            // bit_chargesApplied

            // dec_DistanceTravelled

            // btwProductIdsforSSRules

            // int_evaluateApptWithEmail

            // PublicNotesId

            // NationalID

            // str_Username

            // int_PackageID

            // int_ApptCldr_ID

            // str_CRSS_ID

            // View row
            if (RowType == RowType.View) {
                // int_Appt_id
                int_Appt_id.ViewValue = int_Appt_id.CurrentValue;
                int_Appt_id.ViewCustomAttributes = "";

                // str_AppName
                str_AppName.ViewValue = ConvertToString(str_AppName.CurrentValue); // DN
                str_AppName.ViewCustomAttributes = "";

                // str_App_Date
                str_App_Date.ViewValue = ConvertToString(str_App_Date.CurrentValue); // DN
                str_App_Date.ViewCustomAttributes = "";

                // str_StartTime
                str_StartTime.ViewValue = ConvertToString(str_StartTime.CurrentValue); // DN
                str_StartTime.ViewCustomAttributes = "";

                // str_EndTime
                str_EndTime.ViewValue = ConvertToString(str_EndTime.CurrentValue); // DN
                str_EndTime.ViewCustomAttributes = "";

                // str_PickupTime
                str_PickupTime.ViewValue = ConvertToString(str_PickupTime.CurrentValue); // DN
                str_PickupTime.ViewCustomAttributes = "";

                // str_DropOffTime
                str_DropOffTime.ViewValue = ConvertToString(str_DropOffTime.CurrentValue); // DN
                str_DropOffTime.ViewCustomAttributes = "";

                // int_VehicleID
                int_VehicleID.ViewValue = int_VehicleID.CurrentValue;
                int_VehicleID.ViewValue = FormatNumber(int_VehicleID.ViewValue, int_VehicleID.FormatPattern);
                int_VehicleID.ViewCustomAttributes = "";

                // dec_InstID
                dec_InstID.ViewValue = dec_InstID.CurrentValue;
                dec_InstID.ViewValue = FormatNumber(dec_InstID.ViewValue, dec_InstID.FormatPattern);
                dec_InstID.ViewCustomAttributes = "";

                // dec_StudentID
                dec_StudentID.ViewValue = dec_StudentID.CurrentValue;
                dec_StudentID.ViewValue = FormatNumber(dec_StudentID.ViewValue, dec_StudentID.FormatPattern);
                dec_StudentID.ViewCustomAttributes = "";

                // dec_Observed_StudentID
                dec_Observed_StudentID.ViewValue = dec_Observed_StudentID.CurrentValue;
                dec_Observed_StudentID.ViewValue = FormatNumber(dec_Observed_StudentID.ViewValue, dec_Observed_StudentID.FormatPattern);
                dec_Observed_StudentID.ViewCustomAttributes = "";

                // int_Apptype
                int_Apptype.ViewValue = int_Apptype.CurrentValue;
                curVal = ConvertToString(int_Apptype.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Apptype.Lookup != null && IsDictionary(int_Apptype.Lookup?.Options) && int_Apptype.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Apptype.ViewValue = int_Apptype.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_AppType]", "=", int_Apptype.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Apptype.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Apptype.Lookup != null) { // Lookup values found
                            var listwrk = int_Apptype.Lookup?.RenderViewRow(rswrk[0]);
                            int_Apptype.ViewValue = int_Apptype.HighlightLookup(ConvertToString(rswrk[0]), int_Apptype.DisplayValue(listwrk));
                        } else {
                            int_Apptype.ViewValue = FormatNumber(int_Apptype.CurrentValue, int_Apptype.FormatPattern);
                        }
                    }
                } else {
                    int_Apptype.ViewValue = DbNullValue;
                }
                int_Apptype.ViewCustomAttributes = "";

                // int_AppStatus
                if (!Empty(int_AppStatus.CurrentValue)) {
                    int_AppStatus.ViewValue = int_AppStatus.HighlightLookup(ConvertToString(int_AppStatus.CurrentValue), int_AppStatus.OptionCaption(ConvertToString(int_AppStatus.CurrentValue)));
                } else {
                    int_AppStatus.ViewValue = DbNullValue;
                }
                int_AppStatus.ViewCustomAttributes = "";

                // mny_AppCost
                mny_AppCost.ViewValue = mny_AppCost.CurrentValue;
                mny_AppCost.ViewValue = FormatNumber(mny_AppCost.ViewValue, mny_AppCost.FormatPattern);
                mny_AppCost.ViewCustomAttributes = "";

                // mny_AmountPaid
                mny_AmountPaid.ViewValue = mny_AmountPaid.CurrentValue;
                mny_AmountPaid.ViewValue = FormatNumber(mny_AmountPaid.ViewValue, mny_AmountPaid.FormatPattern);
                mny_AmountPaid.ViewCustomAttributes = "";

                // bit_CheckAppPaid
                if (ConvertToBool(bit_CheckAppPaid.CurrentValue)) {
                    bit_CheckAppPaid.ViewValue = bit_CheckAppPaid.TagCaption(1) != "" ? bit_CheckAppPaid.TagCaption(1) : "Yes";
                } else {
                    bit_CheckAppPaid.ViewValue = bit_CheckAppPaid.TagCaption(2) != "" ? bit_CheckAppPaid.TagCaption(2) : "No";
                }
                bit_CheckAppPaid.ViewCustomAttributes = "";

                // bit_Confirmation
                if (ConvertToBool(bit_Confirmation.CurrentValue)) {
                    bit_Confirmation.ViewValue = bit_Confirmation.TagCaption(1) != "" ? bit_Confirmation.TagCaption(1) : "Yes";
                } else {
                    bit_Confirmation.ViewValue = bit_Confirmation.TagCaption(2) != "" ? bit_Confirmation.TagCaption(2) : "No";
                }
                bit_Confirmation.ViewCustomAttributes = "";

                // str_Instructions
                str_Instructions.ViewValue = ConvertToString(str_Instructions.CurrentValue); // DN
                str_Instructions.ViewCustomAttributes = "";

                // str_Instructions1
                str_Instructions1.ViewValue = ConvertToString(str_Instructions1.CurrentValue); // DN
                str_Instructions1.ViewCustomAttributes = "";

                // str_AppNotes
                str_AppNotes.ViewValue = ConvertToString(str_AppNotes.CurrentValue); // DN
                str_AppNotes.ViewCustomAttributes = "";

                // str_PickupLocation
                str_PickupLocation.ViewValue = ConvertToString(str_PickupLocation.CurrentValue); // DN
                str_PickupLocation.ViewCustomAttributes = "";

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

                // str_Interval
                str_Interval.ViewValue = ConvertToString(str_Interval.CurrentValue); // DN
                str_Interval.ViewCustomAttributes = "";

                // RemM1
                if (ConvertToBool(RemM1.CurrentValue)) {
                    RemM1.ViewValue = RemM1.TagCaption(1) != "" ? RemM1.TagCaption(1) : "Yes";
                } else {
                    RemM1.ViewValue = RemM1.TagCaption(2) != "" ? RemM1.TagCaption(2) : "No";
                }
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

                // int_Location_ID
                int_Location_ID.ViewValue = int_Location_ID.CurrentValue;
                int_Location_ID.ViewValue = FormatNumber(int_Location_ID.ViewValue, int_Location_ID.FormatPattern);
                int_Location_ID.ViewCustomAttributes = "";

                // SPID
                SPID.ViewValue = SPID.CurrentValue;
                SPID.ViewValue = FormatNumber(SPID.ViewValue, SPID.FormatPattern);
                SPID.ViewCustomAttributes = "";

                // Chk_Trace
                Chk_Trace.ViewValue = ConvertToString(Chk_Trace.CurrentValue); // DN
                Chk_Trace.ViewCustomAttributes = "";

                // str_DropOffLocation
                str_DropOffLocation.ViewValue = ConvertToString(str_DropOffLocation.CurrentValue); // DN
                str_DropOffLocation.ViewCustomAttributes = "";

                // dt_apptstart
                dt_apptstart.ViewValue = dt_apptstart.CurrentValue;
                dt_apptstart.ViewValue = FormatDateTime(dt_apptstart.ViewValue, dt_apptstart.FormatPattern);
                dt_apptstart.ViewCustomAttributes = "";

                // dt_apptComplete
                dt_apptComplete.ViewValue = dt_apptComplete.CurrentValue;
                dt_apptComplete.ViewValue = FormatDateTime(dt_apptComplete.ViewValue, dt_apptComplete.FormatPattern);
                dt_apptComplete.ViewCustomAttributes = "";

                // int_apptstartedBy
                int_apptstartedBy.ViewValue = int_apptstartedBy.CurrentValue;
                int_apptstartedBy.ViewValue = FormatNumber(int_apptstartedBy.ViewValue, int_apptstartedBy.FormatPattern);
                int_apptstartedBy.ViewCustomAttributes = "";

                // int_apptCompletedBy
                int_apptCompletedBy.ViewValue = int_apptCompletedBy.CurrentValue;
                int_apptCompletedBy.ViewValue = FormatNumber(int_apptCompletedBy.ViewValue, int_apptCompletedBy.FormatPattern);
                int_apptCompletedBy.ViewCustomAttributes = "";

                // SMSReminder1
                if (ConvertToBool(SMSReminder1.CurrentValue)) {
                    SMSReminder1.ViewValue = SMSReminder1.TagCaption(1) != "" ? SMSReminder1.TagCaption(1) : "Yes";
                } else {
                    SMSReminder1.ViewValue = SMSReminder1.TagCaption(2) != "" ? SMSReminder1.TagCaption(2) : "No";
                }
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

                // bit_isroadtest
                if (ConvertToBool(bit_isroadtest.CurrentValue)) {
                    bit_isroadtest.ViewValue = bit_isroadtest.TagCaption(1) != "" ? bit_isroadtest.TagCaption(1) : "Yes";
                } else {
                    bit_isroadtest.ViewValue = bit_isroadtest.TagCaption(2) != "" ? bit_isroadtest.TagCaption(2) : "No";
                }
                bit_isroadtest.ViewCustomAttributes = "";

                // int_slotType
                int_slotType.ViewValue = int_slotType.CurrentValue;
                int_slotType.ViewValue = FormatNumber(int_slotType.ViewValue, int_slotType.FormatPattern);
                int_slotType.ViewCustomAttributes = "";

                // bit_VisibleOnPortal
                if (ConvertToBool(bit_VisibleOnPortal.CurrentValue)) {
                    bit_VisibleOnPortal.ViewValue = bit_VisibleOnPortal.TagCaption(1) != "" ? bit_VisibleOnPortal.TagCaption(1) : "Yes";
                } else {
                    bit_VisibleOnPortal.ViewValue = bit_VisibleOnPortal.TagCaption(2) != "" ? bit_VisibleOnPortal.TagCaption(2) : "No";
                }
                bit_VisibleOnPortal.ViewCustomAttributes = "";

                // IsDataRetrieved
                if (ConvertToBool(IsDataRetrieved.CurrentValue)) {
                    IsDataRetrieved.ViewValue = IsDataRetrieved.TagCaption(1) != "" ? IsDataRetrieved.TagCaption(1) : "Yes";
                } else {
                    IsDataRetrieved.ViewValue = IsDataRetrieved.TagCaption(2) != "" ? IsDataRetrieved.TagCaption(2) : "No";
                }
                IsDataRetrieved.ViewCustomAttributes = "";

                // bit_chargesApplied
                if (ConvertToBool(bit_chargesApplied.CurrentValue)) {
                    bit_chargesApplied.ViewValue = bit_chargesApplied.TagCaption(1) != "" ? bit_chargesApplied.TagCaption(1) : "Yes";
                } else {
                    bit_chargesApplied.ViewValue = bit_chargesApplied.TagCaption(2) != "" ? bit_chargesApplied.TagCaption(2) : "No";
                }
                bit_chargesApplied.ViewCustomAttributes = "";

                // dec_DistanceTravelled
                dec_DistanceTravelled.ViewValue = dec_DistanceTravelled.CurrentValue;
                dec_DistanceTravelled.ViewValue = FormatNumber(dec_DistanceTravelled.ViewValue, dec_DistanceTravelled.FormatPattern);
                dec_DistanceTravelled.ViewCustomAttributes = "";

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.ViewValue = int_evaluateApptWithEmail.CurrentValue;
                int_evaluateApptWithEmail.ViewValue = FormatNumber(int_evaluateApptWithEmail.ViewValue, int_evaluateApptWithEmail.FormatPattern);
                int_evaluateApptWithEmail.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
                NationalID.ViewValue = FormatNumber(NationalID.ViewValue, NationalID.FormatPattern);
                NationalID.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // int_PackageID
                int_PackageID.ViewValue = int_PackageID.CurrentValue;
                int_PackageID.ViewValue = FormatNumber(int_PackageID.ViewValue, int_PackageID.FormatPattern);
                int_PackageID.ViewCustomAttributes = "";

                // int_ApptCldr_ID
                int_ApptCldr_ID.ViewValue = int_ApptCldr_ID.CurrentValue;
                int_ApptCldr_ID.ViewValue = FormatNumber(int_ApptCldr_ID.ViewValue, int_ApptCldr_ID.FormatPattern);
                int_ApptCldr_ID.ViewCustomAttributes = "";

                // str_CRSS_ID
                str_CRSS_ID.ViewValue = ConvertToString(str_CRSS_ID.CurrentValue); // DN
                str_CRSS_ID.ViewCustomAttributes = "";

                // str_AppName
                str_AppName.HrefValue = "";
                str_AppName.TooltipValue = "";

                // str_App_Date
                str_App_Date.HrefValue = "";
                str_App_Date.TooltipValue = "";

                // str_StartTime
                str_StartTime.HrefValue = "";
                str_StartTime.TooltipValue = "";

                // int_Apptype
                int_Apptype.HrefValue = "";
                int_Apptype.TooltipValue = "";

                // int_AppStatus
                int_AppStatus.HrefValue = "";
                int_AppStatus.TooltipValue = "";

                // mny_AppCost
                mny_AppCost.HrefValue = "";
                mny_AppCost.TooltipValue = "";

                // mny_AmountPaid
                mny_AmountPaid.HrefValue = "";
                mny_AmountPaid.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblAppointmentsInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblAppointmentsInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblAppointmentsInfolist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblAppointmentsInfolist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblAppointmentsInfosrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
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

        // Show link optionally based on User ID
        protected bool ShowOptionLink(string pageId = "") { // DN
            if (Security.IsLoggedIn && !Security.IsAdmin && !UserIDAllow(pageId))
                return Security.IsValidUserID(str_Username.CurrentValue);
            return true;
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
