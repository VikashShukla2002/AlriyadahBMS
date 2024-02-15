namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAssessmentList
    /// </summary>
    public static TblAssessmentList tblAssessmentList
    {
        get => HttpData.Get<TblAssessmentList>("tblAssessmentList")!;
        set => HttpData["tblAssessmentList"] = value;
    }

    /// <summary>
    /// Page class for tblAssessment
    /// </summary>
    public class TblAssessmentList : TblAssessmentListBase
    {
        // Constructor
        public TblAssessmentList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAssessmentList() : base()
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
    public class TblAssessmentListBase : TblAssessment
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAssessment";

        // Page object name
        public string PageObjName = "tblAssessmentList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblAssessmentlist";

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
        public TblAssessmentListBase()
        {
            // CSS class name as context
            TableVar = "tblAssessment";
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

            // Table object (tblAssessment)
            if (tblAssessment == null || tblAssessment is TblAssessment)
                tblAssessment = this;

            // Initialize URLs
            AddUrl = "TblAssessmentAdd?" + Config.TableShowDetail + "=";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblAssessmentDelete";
            MultiUpdateUrl = "TblAssessmentUpdate";

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
        public string PageName => "TblAssessmentList";

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
            AssessmentID.Visible = false;
            str_Full_Name_Hdr.Visible = false;
            str_First_Name.SetVisibility();
            str_Middle_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Username.SetVisibility();
            int_Student_ID.Visible = false;
            NationalID.Visible = false;
            Assessment_Type.SetVisibility();
            AssessmentDate.SetVisibility();
            AssessmentTime.Visible = false;
            isAssessmentDone.SetVisibility();
            AssessmentScore.SetVisibility();
            Assessment_Instructor.Visible = false;
            Date_Entered.Visible = false;
            IsDrivingexperience.Visible = false;
            intDrivinglicenseType.Visible = false;
            AbsherApptNbr.Visible = false;
            Absherphoto.Visible = false;
            date_Birth.Visible = false;
            date_Birth_Hijri.Visible = false;
            str_Cell_Phone.Visible = false;
            str_Email.Visible = false;
            UserlevelID.Visible = false;
            BackDateChk.Visible = false;
            DriveTypelink.Visible = false;
            Calendar_ID.Visible = false;
            Assessmnt_Time.Visible = false;
            Institution.Visible = false;
            TheoreticalScore.Visible = false;
            dt_TheoreticalScore.Visible = false;
            RoadTestScore.Visible = false;
            dt_RoadTestScore.Visible = false;
            AccidentOccurrence.Visible = false;
            Dt_AccidentOccurrence.Visible = false;
            AccidentNotes.Visible = false;
        }

        // Constructor
        public TblAssessmentListBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblAssessmentView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("AssessmentID") ? dict["AssessmentID"] : AssessmentID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                AssessmentID.Visible = false;
            if (IsAddOrEdit)
                Date_Entered.Visible = false;
            if (IsAddOrEdit)
                BackDateChk.Visible = false;
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
            await SetupLookupOptions(str_Full_Name_Hdr);
            await SetupLookupOptions(NationalID);
            await SetupLookupOptions(Assessment_Type);
            await SetupLookupOptions(isAssessmentDone);
            await SetupLookupOptions(Assessment_Instructor);
            await SetupLookupOptions(IsDrivingexperience);
            await SetupLookupOptions(AccidentOccurrence);

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblAssessmentgrid";

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
                if (CurrentMasterTable == "tblStudents")
                    DbMasterFilter = AddMasterUserIDFilter(DbMasterFilter, "tblStudents"); // Add master User ID filter
            }
            AddFilter(ref filter, DbDetailFilter);
            AddFilter(ref filter, SearchWhere);
            if (Empty(filter)) {
                filter = "0=101";
                SearchWhere = filter;
            }

            // Load master record
            if (CurrentMode != "add" && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblStudents") {
                tblStudents = Resolve("tblStudents")!;
                if (tblStudents != null) {
                    using (var rsmaster = await tblStudents.LoadReader(DbMasterFilter)) { // Note: Use {}
                        MasterRecordExists = rsmaster != null && await rsmaster.ReadAsync();
                        if (!MasterRecordExists) {
                            FailureMessage = Language.Phrase("NoRecord"); // Set no record found
                            return Terminate("TblStudentsList"); // Return to master page
                        } else {
                            tblStudents.LoadListRowValues(rsmaster);
                        }
                    }
                    tblStudents.RowType = RowType.Master; // Master row
                    await tblStudents.RenderListRow(); // Note: Do it outside "using" // DN
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
                tblAssessmentList?.PageRender();
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
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblAssessmentsrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(AssessmentID.AdvancedSearch.ToJson())); // Field AssessmentID
            filters.Merge(JObject.Parse(str_Full_Name_Hdr.AdvancedSearch.ToJson())); // Field str_Full_Name_Hdr
            filters.Merge(JObject.Parse(str_First_Name.AdvancedSearch.ToJson())); // Field str_First_Name
            filters.Merge(JObject.Parse(str_Middle_Name.AdvancedSearch.ToJson())); // Field str_Middle_Name
            filters.Merge(JObject.Parse(str_Last_Name.AdvancedSearch.ToJson())); // Field str_Last_Name
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(int_Student_ID.AdvancedSearch.ToJson())); // Field int_Student_ID
            filters.Merge(JObject.Parse(NationalID.AdvancedSearch.ToJson())); // Field NationalID
            filters.Merge(JObject.Parse(Assessment_Type.AdvancedSearch.ToJson())); // Field Assessment_Type
            filters.Merge(JObject.Parse(AssessmentDate.AdvancedSearch.ToJson())); // Field AssessmentDate
            filters.Merge(JObject.Parse(AssessmentTime.AdvancedSearch.ToJson())); // Field AssessmentTime
            filters.Merge(JObject.Parse(isAssessmentDone.AdvancedSearch.ToJson())); // Field isAssessmentDone
            filters.Merge(JObject.Parse(AssessmentScore.AdvancedSearch.ToJson())); // Field AssessmentScore
            filters.Merge(JObject.Parse(Assessment_Instructor.AdvancedSearch.ToJson())); // Field Assessment_Instructor
            filters.Merge(JObject.Parse(Date_Entered.AdvancedSearch.ToJson())); // Field Date_Entered
            filters.Merge(JObject.Parse(IsDrivingexperience.AdvancedSearch.ToJson())); // Field IsDrivingexperience
            filters.Merge(JObject.Parse(intDrivinglicenseType.AdvancedSearch.ToJson())); // Field intDrivinglicenseType
            filters.Merge(JObject.Parse(AbsherApptNbr.AdvancedSearch.ToJson())); // Field AbsherApptNbr
            filters.Merge(JObject.Parse(Absherphoto.AdvancedSearch.ToJson())); // Field Absherphoto
            filters.Merge(JObject.Parse(date_Birth.AdvancedSearch.ToJson())); // Field date_Birth
            filters.Merge(JObject.Parse(date_Birth_Hijri.AdvancedSearch.ToJson())); // Field date_Birth_Hijri
            filters.Merge(JObject.Parse(str_Cell_Phone.AdvancedSearch.ToJson())); // Field str_Cell_Phone
            filters.Merge(JObject.Parse(str_Email.AdvancedSearch.ToJson())); // Field str_Email
            filters.Merge(JObject.Parse(UserlevelID.AdvancedSearch.ToJson())); // Field UserlevelID
            filters.Merge(JObject.Parse(DriveTypelink.AdvancedSearch.ToJson())); // Field DriveTypelink
            filters.Merge(JObject.Parse(Calendar_ID.AdvancedSearch.ToJson())); // Field Calendar_ID
            filters.Merge(JObject.Parse(Assessmnt_Time.AdvancedSearch.ToJson())); // Field Assessmnt_Time
            filters.Merge(JObject.Parse(Institution.AdvancedSearch.ToJson())); // Field Institution
            filters.Merge(JObject.Parse(TheoreticalScore.AdvancedSearch.ToJson())); // Field TheoreticalScore
            filters.Merge(JObject.Parse(dt_TheoreticalScore.AdvancedSearch.ToJson())); // Field dt_TheoreticalScore
            filters.Merge(JObject.Parse(RoadTestScore.AdvancedSearch.ToJson())); // Field RoadTestScore
            filters.Merge(JObject.Parse(dt_RoadTestScore.AdvancedSearch.ToJson())); // Field dt_RoadTestScore
            filters.Merge(JObject.Parse(AccidentOccurrence.AdvancedSearch.ToJson())); // Field AccidentOccurrence
            filters.Merge(JObject.Parse(Dt_AccidentOccurrence.AdvancedSearch.ToJson())); // Field Dt_AccidentOccurrence
            filters.Merge(JObject.Parse(AccidentNotes.AdvancedSearch.ToJson())); // Field AccidentNotes
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblAssessmentsrch", filters);
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

            // Field AssessmentID
            if (filter?.TryGetValue("x_AssessmentID", out sv) ?? false) {
                AssessmentID.AdvancedSearch.SearchValue = sv;
                AssessmentID.AdvancedSearch.SearchOperator = filter["z_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchCondition = filter["v_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchValue2 = filter["y_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchOperator2 = filter["w_AssessmentID"];
                AssessmentID.AdvancedSearch.Save();
            }

            // Field str_Full_Name_Hdr
            if (filter?.TryGetValue("x_str_Full_Name_Hdr", out sv) ?? false) {
                str_Full_Name_Hdr.AdvancedSearch.SearchValue = sv;
                str_Full_Name_Hdr.AdvancedSearch.SearchOperator = filter["z_str_Full_Name_Hdr"];
                str_Full_Name_Hdr.AdvancedSearch.SearchCondition = filter["v_str_Full_Name_Hdr"];
                str_Full_Name_Hdr.AdvancedSearch.SearchValue2 = filter["y_str_Full_Name_Hdr"];
                str_Full_Name_Hdr.AdvancedSearch.SearchOperator2 = filter["w_str_Full_Name_Hdr"];
                str_Full_Name_Hdr.AdvancedSearch.Save();
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

            // Field str_Middle_Name
            if (filter?.TryGetValue("x_str_Middle_Name", out sv) ?? false) {
                str_Middle_Name.AdvancedSearch.SearchValue = sv;
                str_Middle_Name.AdvancedSearch.SearchOperator = filter["z_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchCondition = filter["v_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchValue2 = filter["y_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.Save();
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

            // Field NationalID
            if (filter?.TryGetValue("x_NationalID", out sv) ?? false) {
                NationalID.AdvancedSearch.SearchValue = sv;
                NationalID.AdvancedSearch.SearchOperator = filter["z_NationalID"];
                NationalID.AdvancedSearch.SearchCondition = filter["v_NationalID"];
                NationalID.AdvancedSearch.SearchValue2 = filter["y_NationalID"];
                NationalID.AdvancedSearch.SearchOperator2 = filter["w_NationalID"];
                NationalID.AdvancedSearch.Save();
            }

            // Field Assessment_Type
            if (filter?.TryGetValue("x_Assessment_Type", out sv) ?? false) {
                Assessment_Type.AdvancedSearch.SearchValue = sv;
                Assessment_Type.AdvancedSearch.SearchOperator = filter["z_Assessment_Type"];
                Assessment_Type.AdvancedSearch.SearchCondition = filter["v_Assessment_Type"];
                Assessment_Type.AdvancedSearch.SearchValue2 = filter["y_Assessment_Type"];
                Assessment_Type.AdvancedSearch.SearchOperator2 = filter["w_Assessment_Type"];
                Assessment_Type.AdvancedSearch.Save();
            }

            // Field AssessmentDate
            if (filter?.TryGetValue("x_AssessmentDate", out sv) ?? false) {
                AssessmentDate.AdvancedSearch.SearchValue = sv;
                AssessmentDate.AdvancedSearch.SearchOperator = filter["z_AssessmentDate"];
                AssessmentDate.AdvancedSearch.SearchCondition = filter["v_AssessmentDate"];
                AssessmentDate.AdvancedSearch.SearchValue2 = filter["y_AssessmentDate"];
                AssessmentDate.AdvancedSearch.SearchOperator2 = filter["w_AssessmentDate"];
                AssessmentDate.AdvancedSearch.Save();
            }

            // Field AssessmentTime
            if (filter?.TryGetValue("x_AssessmentTime", out sv) ?? false) {
                AssessmentTime.AdvancedSearch.SearchValue = sv;
                AssessmentTime.AdvancedSearch.SearchOperator = filter["z_AssessmentTime"];
                AssessmentTime.AdvancedSearch.SearchCondition = filter["v_AssessmentTime"];
                AssessmentTime.AdvancedSearch.SearchValue2 = filter["y_AssessmentTime"];
                AssessmentTime.AdvancedSearch.SearchOperator2 = filter["w_AssessmentTime"];
                AssessmentTime.AdvancedSearch.Save();
            }

            // Field isAssessmentDone
            if (filter?.TryGetValue("x_isAssessmentDone", out sv) ?? false) {
                isAssessmentDone.AdvancedSearch.SearchValue = sv;
                isAssessmentDone.AdvancedSearch.SearchOperator = filter["z_isAssessmentDone"];
                isAssessmentDone.AdvancedSearch.SearchCondition = filter["v_isAssessmentDone"];
                isAssessmentDone.AdvancedSearch.SearchValue2 = filter["y_isAssessmentDone"];
                isAssessmentDone.AdvancedSearch.SearchOperator2 = filter["w_isAssessmentDone"];
                isAssessmentDone.AdvancedSearch.Save();
            }

            // Field AssessmentScore
            if (filter?.TryGetValue("x_AssessmentScore", out sv) ?? false) {
                AssessmentScore.AdvancedSearch.SearchValue = sv;
                AssessmentScore.AdvancedSearch.SearchOperator = filter["z_AssessmentScore"];
                AssessmentScore.AdvancedSearch.SearchCondition = filter["v_AssessmentScore"];
                AssessmentScore.AdvancedSearch.SearchValue2 = filter["y_AssessmentScore"];
                AssessmentScore.AdvancedSearch.SearchOperator2 = filter["w_AssessmentScore"];
                AssessmentScore.AdvancedSearch.Save();
            }

            // Field Assessment_Instructor
            if (filter?.TryGetValue("x_Assessment_Instructor", out sv) ?? false) {
                Assessment_Instructor.AdvancedSearch.SearchValue = sv;
                Assessment_Instructor.AdvancedSearch.SearchOperator = filter["z_Assessment_Instructor"];
                Assessment_Instructor.AdvancedSearch.SearchCondition = filter["v_Assessment_Instructor"];
                Assessment_Instructor.AdvancedSearch.SearchValue2 = filter["y_Assessment_Instructor"];
                Assessment_Instructor.AdvancedSearch.SearchOperator2 = filter["w_Assessment_Instructor"];
                Assessment_Instructor.AdvancedSearch.Save();
            }

            // Field Date_Entered
            if (filter?.TryGetValue("x_Date_Entered", out sv) ?? false) {
                Date_Entered.AdvancedSearch.SearchValue = sv;
                Date_Entered.AdvancedSearch.SearchOperator = filter["z_Date_Entered"];
                Date_Entered.AdvancedSearch.SearchCondition = filter["v_Date_Entered"];
                Date_Entered.AdvancedSearch.SearchValue2 = filter["y_Date_Entered"];
                Date_Entered.AdvancedSearch.SearchOperator2 = filter["w_Date_Entered"];
                Date_Entered.AdvancedSearch.Save();
            }

            // Field IsDrivingexperience
            if (filter?.TryGetValue("x_IsDrivingexperience", out sv) ?? false) {
                IsDrivingexperience.AdvancedSearch.SearchValue = sv;
                IsDrivingexperience.AdvancedSearch.SearchOperator = filter["z_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchCondition = filter["v_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchValue2 = filter["y_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchOperator2 = filter["w_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.Save();
            }

            // Field intDrivinglicenseType
            if (filter?.TryGetValue("x_intDrivinglicenseType", out sv) ?? false) {
                intDrivinglicenseType.AdvancedSearch.SearchValue = sv;
                intDrivinglicenseType.AdvancedSearch.SearchOperator = filter["z_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchCondition = filter["v_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchValue2 = filter["y_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchOperator2 = filter["w_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.Save();
            }

            // Field AbsherApptNbr
            if (filter?.TryGetValue("x_AbsherApptNbr", out sv) ?? false) {
                AbsherApptNbr.AdvancedSearch.SearchValue = sv;
                AbsherApptNbr.AdvancedSearch.SearchOperator = filter["z_AbsherApptNbr"];
                AbsherApptNbr.AdvancedSearch.SearchCondition = filter["v_AbsherApptNbr"];
                AbsherApptNbr.AdvancedSearch.SearchValue2 = filter["y_AbsherApptNbr"];
                AbsherApptNbr.AdvancedSearch.SearchOperator2 = filter["w_AbsherApptNbr"];
                AbsherApptNbr.AdvancedSearch.Save();
            }

            // Field Absherphoto
            if (filter?.TryGetValue("x_Absherphoto", out sv) ?? false) {
                Absherphoto.AdvancedSearch.SearchValue = sv;
                Absherphoto.AdvancedSearch.SearchOperator = filter["z_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchCondition = filter["v_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchValue2 = filter["y_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchOperator2 = filter["w_Absherphoto"];
                Absherphoto.AdvancedSearch.Save();
            }

            // Field date_Birth
            if (filter?.TryGetValue("x_date_Birth", out sv) ?? false) {
                date_Birth.AdvancedSearch.SearchValue = sv;
                date_Birth.AdvancedSearch.SearchOperator = filter["z_date_Birth"];
                date_Birth.AdvancedSearch.SearchCondition = filter["v_date_Birth"];
                date_Birth.AdvancedSearch.SearchValue2 = filter["y_date_Birth"];
                date_Birth.AdvancedSearch.SearchOperator2 = filter["w_date_Birth"];
                date_Birth.AdvancedSearch.Save();
            }

            // Field date_Birth_Hijri
            if (filter?.TryGetValue("x_date_Birth_Hijri", out sv) ?? false) {
                date_Birth_Hijri.AdvancedSearch.SearchValue = sv;
                date_Birth_Hijri.AdvancedSearch.SearchOperator = filter["z_date_Birth_Hijri"];
                date_Birth_Hijri.AdvancedSearch.SearchCondition = filter["v_date_Birth_Hijri"];
                date_Birth_Hijri.AdvancedSearch.SearchValue2 = filter["y_date_Birth_Hijri"];
                date_Birth_Hijri.AdvancedSearch.SearchOperator2 = filter["w_date_Birth_Hijri"];
                date_Birth_Hijri.AdvancedSearch.Save();
            }

            // Field str_Cell_Phone
            if (filter?.TryGetValue("x_str_Cell_Phone", out sv) ?? false) {
                str_Cell_Phone.AdvancedSearch.SearchValue = sv;
                str_Cell_Phone.AdvancedSearch.SearchOperator = filter["z_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchCondition = filter["v_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.Save();
            }

            // Field str_Email
            if (filter?.TryGetValue("x_str_Email", out sv) ?? false) {
                str_Email.AdvancedSearch.SearchValue = sv;
                str_Email.AdvancedSearch.SearchOperator = filter["z_str_Email"];
                str_Email.AdvancedSearch.SearchCondition = filter["v_str_Email"];
                str_Email.AdvancedSearch.SearchValue2 = filter["y_str_Email"];
                str_Email.AdvancedSearch.SearchOperator2 = filter["w_str_Email"];
                str_Email.AdvancedSearch.Save();
            }

            // Field UserlevelID
            if (filter?.TryGetValue("x_UserlevelID", out sv) ?? false) {
                UserlevelID.AdvancedSearch.SearchValue = sv;
                UserlevelID.AdvancedSearch.SearchOperator = filter["z_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchCondition = filter["v_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchValue2 = filter["y_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchOperator2 = filter["w_UserlevelID"];
                UserlevelID.AdvancedSearch.Save();
            }

            // Field DriveTypelink
            if (filter?.TryGetValue("x_DriveTypelink", out sv) ?? false) {
                DriveTypelink.AdvancedSearch.SearchValue = sv;
                DriveTypelink.AdvancedSearch.SearchOperator = filter["z_DriveTypelink"];
                DriveTypelink.AdvancedSearch.SearchCondition = filter["v_DriveTypelink"];
                DriveTypelink.AdvancedSearch.SearchValue2 = filter["y_DriveTypelink"];
                DriveTypelink.AdvancedSearch.SearchOperator2 = filter["w_DriveTypelink"];
                DriveTypelink.AdvancedSearch.Save();
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

            // Field Assessmnt_Time
            if (filter?.TryGetValue("x_Assessmnt_Time", out sv) ?? false) {
                Assessmnt_Time.AdvancedSearch.SearchValue = sv;
                Assessmnt_Time.AdvancedSearch.SearchOperator = filter["z_Assessmnt_Time"];
                Assessmnt_Time.AdvancedSearch.SearchCondition = filter["v_Assessmnt_Time"];
                Assessmnt_Time.AdvancedSearch.SearchValue2 = filter["y_Assessmnt_Time"];
                Assessmnt_Time.AdvancedSearch.SearchOperator2 = filter["w_Assessmnt_Time"];
                Assessmnt_Time.AdvancedSearch.Save();
            }

            // Field Institution
            if (filter?.TryGetValue("x_Institution", out sv) ?? false) {
                Institution.AdvancedSearch.SearchValue = sv;
                Institution.AdvancedSearch.SearchOperator = filter["z_Institution"];
                Institution.AdvancedSearch.SearchCondition = filter["v_Institution"];
                Institution.AdvancedSearch.SearchValue2 = filter["y_Institution"];
                Institution.AdvancedSearch.SearchOperator2 = filter["w_Institution"];
                Institution.AdvancedSearch.Save();
            }

            // Field TheoreticalScore
            if (filter?.TryGetValue("x_TheoreticalScore", out sv) ?? false) {
                TheoreticalScore.AdvancedSearch.SearchValue = sv;
                TheoreticalScore.AdvancedSearch.SearchOperator = filter["z_TheoreticalScore"];
                TheoreticalScore.AdvancedSearch.SearchCondition = filter["v_TheoreticalScore"];
                TheoreticalScore.AdvancedSearch.SearchValue2 = filter["y_TheoreticalScore"];
                TheoreticalScore.AdvancedSearch.SearchOperator2 = filter["w_TheoreticalScore"];
                TheoreticalScore.AdvancedSearch.Save();
            }

            // Field dt_TheoreticalScore
            if (filter?.TryGetValue("x_dt_TheoreticalScore", out sv) ?? false) {
                dt_TheoreticalScore.AdvancedSearch.SearchValue = sv;
                dt_TheoreticalScore.AdvancedSearch.SearchOperator = filter["z_dt_TheoreticalScore"];
                dt_TheoreticalScore.AdvancedSearch.SearchCondition = filter["v_dt_TheoreticalScore"];
                dt_TheoreticalScore.AdvancedSearch.SearchValue2 = filter["y_dt_TheoreticalScore"];
                dt_TheoreticalScore.AdvancedSearch.SearchOperator2 = filter["w_dt_TheoreticalScore"];
                dt_TheoreticalScore.AdvancedSearch.Save();
            }

            // Field RoadTestScore
            if (filter?.TryGetValue("x_RoadTestScore", out sv) ?? false) {
                RoadTestScore.AdvancedSearch.SearchValue = sv;
                RoadTestScore.AdvancedSearch.SearchOperator = filter["z_RoadTestScore"];
                RoadTestScore.AdvancedSearch.SearchCondition = filter["v_RoadTestScore"];
                RoadTestScore.AdvancedSearch.SearchValue2 = filter["y_RoadTestScore"];
                RoadTestScore.AdvancedSearch.SearchOperator2 = filter["w_RoadTestScore"];
                RoadTestScore.AdvancedSearch.Save();
            }

            // Field dt_RoadTestScore
            if (filter?.TryGetValue("x_dt_RoadTestScore", out sv) ?? false) {
                dt_RoadTestScore.AdvancedSearch.SearchValue = sv;
                dt_RoadTestScore.AdvancedSearch.SearchOperator = filter["z_dt_RoadTestScore"];
                dt_RoadTestScore.AdvancedSearch.SearchCondition = filter["v_dt_RoadTestScore"];
                dt_RoadTestScore.AdvancedSearch.SearchValue2 = filter["y_dt_RoadTestScore"];
                dt_RoadTestScore.AdvancedSearch.SearchOperator2 = filter["w_dt_RoadTestScore"];
                dt_RoadTestScore.AdvancedSearch.Save();
            }

            // Field AccidentOccurrence
            if (filter?.TryGetValue("x_AccidentOccurrence", out sv) ?? false) {
                AccidentOccurrence.AdvancedSearch.SearchValue = sv;
                AccidentOccurrence.AdvancedSearch.SearchOperator = filter["z_AccidentOccurrence"];
                AccidentOccurrence.AdvancedSearch.SearchCondition = filter["v_AccidentOccurrence"];
                AccidentOccurrence.AdvancedSearch.SearchValue2 = filter["y_AccidentOccurrence"];
                AccidentOccurrence.AdvancedSearch.SearchOperator2 = filter["w_AccidentOccurrence"];
                AccidentOccurrence.AdvancedSearch.Save();
            }

            // Field Dt_AccidentOccurrence
            if (filter?.TryGetValue("x_Dt_AccidentOccurrence", out sv) ?? false) {
                Dt_AccidentOccurrence.AdvancedSearch.SearchValue = sv;
                Dt_AccidentOccurrence.AdvancedSearch.SearchOperator = filter["z_Dt_AccidentOccurrence"];
                Dt_AccidentOccurrence.AdvancedSearch.SearchCondition = filter["v_Dt_AccidentOccurrence"];
                Dt_AccidentOccurrence.AdvancedSearch.SearchValue2 = filter["y_Dt_AccidentOccurrence"];
                Dt_AccidentOccurrence.AdvancedSearch.SearchOperator2 = filter["w_Dt_AccidentOccurrence"];
                Dt_AccidentOccurrence.AdvancedSearch.Save();
            }

            // Field AccidentNotes
            if (filter?.TryGetValue("x_AccidentNotes", out sv) ?? false) {
                AccidentNotes.AdvancedSearch.SearchValue = sv;
                AccidentNotes.AdvancedSearch.SearchOperator = filter["z_AccidentNotes"];
                AccidentNotes.AdvancedSearch.SearchCondition = filter["v_AccidentNotes"];
                AccidentNotes.AdvancedSearch.SearchValue2 = filter["y_AccidentNotes"];
                AccidentNotes.AdvancedSearch.SearchOperator2 = filter["w_AccidentNotes"];
                AccidentNotes.AdvancedSearch.Save();
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
            BuildSearchSql(ref where, AssessmentID, def, false); // AssessmentID
            BuildSearchSql(ref where, str_Full_Name_Hdr, def, false); // str_Full_Name_Hdr
            BuildSearchSql(ref where, str_First_Name, def, false); // str_First_Name
            BuildSearchSql(ref where, str_Middle_Name, def, false); // str_Middle_Name
            BuildSearchSql(ref where, str_Last_Name, def, false); // str_Last_Name
            BuildSearchSql(ref where, str_Username, def, true); // str_Username
            BuildSearchSql(ref where, int_Student_ID, def, false); // int_Student_ID
            BuildSearchSql(ref where, NationalID, def, false); // NationalID
            BuildSearchSql(ref where, Assessment_Type, def, false); // Assessment_Type
            BuildSearchSql(ref where, AssessmentDate, def, true); // AssessmentDate
            BuildSearchSql(ref where, AssessmentTime, def, false); // AssessmentTime
            BuildSearchSql(ref where, isAssessmentDone, def, false); // isAssessmentDone
            BuildSearchSql(ref where, AssessmentScore, def, true); // AssessmentScore
            BuildSearchSql(ref where, Assessment_Instructor, def, false); // Assessment_Instructor
            BuildSearchSql(ref where, Date_Entered, def, false); // Date_Entered
            BuildSearchSql(ref where, IsDrivingexperience, def, false); // IsDrivingexperience
            BuildSearchSql(ref where, intDrivinglicenseType, def, false); // intDrivinglicenseType
            BuildSearchSql(ref where, AbsherApptNbr, def, false); // AbsherApptNbr
            BuildSearchSql(ref where, Absherphoto, def, false); // Absherphoto
            BuildSearchSql(ref where, date_Birth, def, false); // date_Birth
            BuildSearchSql(ref where, date_Birth_Hijri, def, false); // date_Birth_Hijri
            BuildSearchSql(ref where, str_Cell_Phone, def, false); // str_Cell_Phone
            BuildSearchSql(ref where, str_Email, def, false); // str_Email
            BuildSearchSql(ref where, UserlevelID, def, false); // UserlevelID
            BuildSearchSql(ref where, DriveTypelink, def, false); // DriveTypelink
            BuildSearchSql(ref where, Calendar_ID, def, false); // Calendar_ID
            BuildSearchSql(ref where, Assessmnt_Time, def, false); // Assessmnt_Time
            BuildSearchSql(ref where, Institution, def, false); // Institution
            BuildSearchSql(ref where, TheoreticalScore, def, false); // TheoreticalScore
            BuildSearchSql(ref where, dt_TheoreticalScore, def, false); // dt_TheoreticalScore
            BuildSearchSql(ref where, RoadTestScore, def, false); // RoadTestScore
            BuildSearchSql(ref where, dt_RoadTestScore, def, false); // dt_RoadTestScore
            BuildSearchSql(ref where, AccidentOccurrence, def, false); // AccidentOccurrence
            BuildSearchSql(ref where, Dt_AccidentOccurrence, def, false); // Dt_AccidentOccurrence
            BuildSearchSql(ref where, AccidentNotes, def, false); // AccidentNotes

            // Set up search command
            if (!def && !Empty(where) && (new[] { "", "reset", "resetall" }).Contains(Command))
                Command = "search";
            if (!def && Command == "search") {
                AssessmentID.AdvancedSearch.Save(); // AssessmentID
                str_Full_Name_Hdr.AdvancedSearch.Save(); // str_Full_Name_Hdr
                str_First_Name.AdvancedSearch.Save(); // str_First_Name
                str_Middle_Name.AdvancedSearch.Save(); // str_Middle_Name
                str_Last_Name.AdvancedSearch.Save(); // str_Last_Name
                str_Username.AdvancedSearch.Save(); // str_Username
                int_Student_ID.AdvancedSearch.Save(); // int_Student_ID
                NationalID.AdvancedSearch.Save(); // NationalID
                Assessment_Type.AdvancedSearch.Save(); // Assessment_Type
                AssessmentDate.AdvancedSearch.Save(); // AssessmentDate
                AssessmentTime.AdvancedSearch.Save(); // AssessmentTime
                isAssessmentDone.AdvancedSearch.Save(); // isAssessmentDone
                AssessmentScore.AdvancedSearch.Save(); // AssessmentScore
                Assessment_Instructor.AdvancedSearch.Save(); // Assessment_Instructor
                Date_Entered.AdvancedSearch.Save(); // Date_Entered
                IsDrivingexperience.AdvancedSearch.Save(); // IsDrivingexperience
                intDrivinglicenseType.AdvancedSearch.Save(); // intDrivinglicenseType
                AbsherApptNbr.AdvancedSearch.Save(); // AbsherApptNbr
                Absherphoto.AdvancedSearch.Save(); // Absherphoto
                date_Birth.AdvancedSearch.Save(); // date_Birth
                date_Birth_Hijri.AdvancedSearch.Save(); // date_Birth_Hijri
                str_Cell_Phone.AdvancedSearch.Save(); // str_Cell_Phone
                str_Email.AdvancedSearch.Save(); // str_Email
                UserlevelID.AdvancedSearch.Save(); // UserlevelID
                DriveTypelink.AdvancedSearch.Save(); // DriveTypelink
                Calendar_ID.AdvancedSearch.Save(); // Calendar_ID
                Assessmnt_Time.AdvancedSearch.Save(); // Assessmnt_Time
                Institution.AdvancedSearch.Save(); // Institution
                TheoreticalScore.AdvancedSearch.Save(); // TheoreticalScore
                dt_TheoreticalScore.AdvancedSearch.Save(); // dt_TheoreticalScore
                RoadTestScore.AdvancedSearch.Save(); // RoadTestScore
                dt_RoadTestScore.AdvancedSearch.Save(); // dt_RoadTestScore
                AccidentOccurrence.AdvancedSearch.Save(); // AccidentOccurrence
                Dt_AccidentOccurrence.AdvancedSearch.Save(); // Dt_AccidentOccurrence
                AccidentNotes.AdvancedSearch.Save(); // AccidentNotes

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

            // Field str_First_Name
            filter = QueryBuilderWhere("str_First_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_First_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_First_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Middle_Name
            filter = QueryBuilderWhere("str_Middle_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Middle_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Middle_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Last_Name
            filter = QueryBuilderWhere("str_Last_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Last_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Last_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Username
            filter = QueryBuilderWhere("str_Username");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Username, false, true);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Username.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field Assessment_Type
            filter = QueryBuilderWhere("Assessment_Type");
            if (Empty(filter))
                BuildSearchSql(ref filter, Assessment_Type, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + Assessment_Type.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field AssessmentDate
            filter = QueryBuilderWhere("AssessmentDate");
            if (Empty(filter))
                BuildSearchSql(ref filter, AssessmentDate, false, true);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + AssessmentDate.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field isAssessmentDone
            filter = QueryBuilderWhere("isAssessmentDone");
            if (Empty(filter))
                BuildSearchSql(ref filter, isAssessmentDone, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + isAssessmentDone.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field AssessmentScore
            filter = QueryBuilderWhere("AssessmentScore");
            if (Empty(filter))
                BuildSearchSql(ref filter, AssessmentScore, false, true);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + AssessmentScore.Caption + "</span>" + captionSuffix + filter + "</div>";
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
            searchFlds.Add(str_Full_Name_Hdr);
            searchFlds.Add(str_First_Name);
            searchFlds.Add(str_Middle_Name);
            searchFlds.Add(str_Last_Name);
            searchFlds.Add(str_Username);
            searchFlds.Add(Assessment_Type);
            searchFlds.Add(AssessmentDate);
            searchFlds.Add(AssessmentTime);
            searchFlds.Add(Assessment_Instructor);
            searchFlds.Add(AbsherApptNbr);
            searchFlds.Add(Absherphoto);
            searchFlds.Add(date_Birth_Hijri);
            searchFlds.Add(str_Cell_Phone);
            searchFlds.Add(str_Email);
            searchFlds.Add(Institution);
            searchFlds.Add(TheoreticalScore);
            searchFlds.Add(RoadTestScore);
            searchFlds.Add(AccidentNotes);
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
            if (AssessmentID.AdvancedSearch.IssetSession)
                return true;
            if (str_Full_Name_Hdr.AdvancedSearch.IssetSession)
                return true;
            if (str_First_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Middle_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Last_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Username.AdvancedSearch.IssetSession)
                return true;
            if (int_Student_ID.AdvancedSearch.IssetSession)
                return true;
            if (NationalID.AdvancedSearch.IssetSession)
                return true;
            if (Assessment_Type.AdvancedSearch.IssetSession)
                return true;
            if (AssessmentDate.AdvancedSearch.IssetSession)
                return true;
            if (AssessmentTime.AdvancedSearch.IssetSession)
                return true;
            if (isAssessmentDone.AdvancedSearch.IssetSession)
                return true;
            if (AssessmentScore.AdvancedSearch.IssetSession)
                return true;
            if (Assessment_Instructor.AdvancedSearch.IssetSession)
                return true;
            if (Date_Entered.AdvancedSearch.IssetSession)
                return true;
            if (IsDrivingexperience.AdvancedSearch.IssetSession)
                return true;
            if (intDrivinglicenseType.AdvancedSearch.IssetSession)
                return true;
            if (AbsherApptNbr.AdvancedSearch.IssetSession)
                return true;
            if (Absherphoto.AdvancedSearch.IssetSession)
                return true;
            if (date_Birth.AdvancedSearch.IssetSession)
                return true;
            if (date_Birth_Hijri.AdvancedSearch.IssetSession)
                return true;
            if (str_Cell_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Email.AdvancedSearch.IssetSession)
                return true;
            if (UserlevelID.AdvancedSearch.IssetSession)
                return true;
            if (DriveTypelink.AdvancedSearch.IssetSession)
                return true;
            if (Calendar_ID.AdvancedSearch.IssetSession)
                return true;
            if (Assessmnt_Time.AdvancedSearch.IssetSession)
                return true;
            if (Institution.AdvancedSearch.IssetSession)
                return true;
            if (TheoreticalScore.AdvancedSearch.IssetSession)
                return true;
            if (dt_TheoreticalScore.AdvancedSearch.IssetSession)
                return true;
            if (RoadTestScore.AdvancedSearch.IssetSession)
                return true;
            if (dt_RoadTestScore.AdvancedSearch.IssetSession)
                return true;
            if (AccidentOccurrence.AdvancedSearch.IssetSession)
                return true;
            if (Dt_AccidentOccurrence.AdvancedSearch.IssetSession)
                return true;
            if (AccidentNotes.AdvancedSearch.IssetSession)
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
            AssessmentID.AdvancedSearch.UnsetSession();
            str_Full_Name_Hdr.AdvancedSearch.UnsetSession();
            str_First_Name.AdvancedSearch.UnsetSession();
            str_Middle_Name.AdvancedSearch.UnsetSession();
            str_Last_Name.AdvancedSearch.UnsetSession();
            str_Username.AdvancedSearch.UnsetSession();
            int_Student_ID.AdvancedSearch.UnsetSession();
            NationalID.AdvancedSearch.UnsetSession();
            Assessment_Type.AdvancedSearch.UnsetSession();
            AssessmentDate.AdvancedSearch.UnsetSession();
            AssessmentTime.AdvancedSearch.UnsetSession();
            isAssessmentDone.AdvancedSearch.UnsetSession();
            AssessmentScore.AdvancedSearch.UnsetSession();
            Assessment_Instructor.AdvancedSearch.UnsetSession();
            Date_Entered.AdvancedSearch.UnsetSession();
            IsDrivingexperience.AdvancedSearch.UnsetSession();
            intDrivinglicenseType.AdvancedSearch.UnsetSession();
            AbsherApptNbr.AdvancedSearch.UnsetSession();
            Absherphoto.AdvancedSearch.UnsetSession();
            date_Birth.AdvancedSearch.UnsetSession();
            date_Birth_Hijri.AdvancedSearch.UnsetSession();
            str_Cell_Phone.AdvancedSearch.UnsetSession();
            str_Email.AdvancedSearch.UnsetSession();
            UserlevelID.AdvancedSearch.UnsetSession();
            DriveTypelink.AdvancedSearch.UnsetSession();
            Calendar_ID.AdvancedSearch.UnsetSession();
            Assessmnt_Time.AdvancedSearch.UnsetSession();
            Institution.AdvancedSearch.UnsetSession();
            TheoreticalScore.AdvancedSearch.UnsetSession();
            dt_TheoreticalScore.AdvancedSearch.UnsetSession();
            RoadTestScore.AdvancedSearch.UnsetSession();
            dt_RoadTestScore.AdvancedSearch.UnsetSession();
            AccidentOccurrence.AdvancedSearch.UnsetSession();
            Dt_AccidentOccurrence.AdvancedSearch.UnsetSession();
            AccidentNotes.AdvancedSearch.UnsetSession();
        }

        // Restore all search parameters
        protected void RestoreSearchParms() {
            RestoreSearch = true;

            // Restore basic search values
            BasicSearch.Load();

            // Restore advanced search values
            AssessmentID.AdvancedSearch.Load();
            str_Full_Name_Hdr.AdvancedSearch.Load();
            str_First_Name.AdvancedSearch.Load();
            str_Middle_Name.AdvancedSearch.Load();
            str_Last_Name.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            int_Student_ID.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            Assessment_Type.AdvancedSearch.Load();
            AssessmentDate.AdvancedSearch.Load();
            AssessmentTime.AdvancedSearch.Load();
            isAssessmentDone.AdvancedSearch.Load();
            AssessmentScore.AdvancedSearch.Load();
            Assessment_Instructor.AdvancedSearch.Load();
            Date_Entered.AdvancedSearch.Load();
            IsDrivingexperience.AdvancedSearch.Load();
            intDrivinglicenseType.AdvancedSearch.Load();
            AbsherApptNbr.AdvancedSearch.Load();
            Absherphoto.AdvancedSearch.Load();
            date_Birth.AdvancedSearch.Load();
            date_Birth_Hijri.AdvancedSearch.Load();
            str_Cell_Phone.AdvancedSearch.Load();
            str_Email.AdvancedSearch.Load();
            UserlevelID.AdvancedSearch.Load();
            DriveTypelink.AdvancedSearch.Load();
            Calendar_ID.AdvancedSearch.Load();
            Assessmnt_Time.AdvancedSearch.Load();
            Institution.AdvancedSearch.Load();
            TheoreticalScore.AdvancedSearch.Load();
            dt_TheoreticalScore.AdvancedSearch.Load();
            RoadTestScore.AdvancedSearch.Load();
            dt_RoadTestScore.AdvancedSearch.Load();
            AccidentOccurrence.AdvancedSearch.Load();
            Dt_AccidentOccurrence.AdvancedSearch.Load();
            AccidentNotes.AdvancedSearch.Load();
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
                UpdateSort(str_First_Name, ctrl); // str_First_Name
                UpdateSort(str_Middle_Name, ctrl); // str_Middle_Name
                UpdateSort(str_Last_Name, ctrl); // str_Last_Name
                UpdateSort(str_Username, ctrl); // str_Username
                UpdateSort(Assessment_Type, ctrl); // Assessment_Type
                UpdateSort(AssessmentDate, ctrl); // AssessmentDate
                UpdateSort(isAssessmentDone, ctrl); // isAssessmentDone
                UpdateSort(AssessmentScore, ctrl); // AssessmentScore
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
                    str_Username.SessionValue = "";
                }

                // Reset (clear) sorting order
                if (SameText(Command, "resetsort")) {
                    string orderBy = "";
                    SessionOrderBy = orderBy;
                    AssessmentID.Sort = "";
                    str_Full_Name_Hdr.Sort = "";
                    str_First_Name.Sort = "";
                    str_Middle_Name.Sort = "";
                    str_Last_Name.Sort = "";
                    str_Username.Sort = "";
                    int_Student_ID.Sort = "";
                    NationalID.Sort = "";
                    Assessment_Type.Sort = "";
                    AssessmentDate.Sort = "";
                    AssessmentTime.Sort = "";
                    isAssessmentDone.Sort = "";
                    AssessmentScore.Sort = "";
                    Assessment_Instructor.Sort = "";
                    Date_Entered.Sort = "";
                    IsDrivingexperience.Sort = "";
                    intDrivinglicenseType.Sort = "";
                    AbsherApptNbr.Sort = "";
                    Absherphoto.Sort = "";
                    date_Birth.Sort = "";
                    date_Birth_Hijri.Sort = "";
                    str_Cell_Phone.Sort = "";
                    str_Email.Sort = "";
                    UserlevelID.Sort = "";
                    BackDateChk.Sort = "";
                    DriveTypelink.Sort = "";
                    Calendar_ID.Sort = "";
                    Assessmnt_Time.Sort = "";
                    Institution.Sort = "";
                    TheoreticalScore.Sort = "";
                    dt_TheoreticalScore.Sort = "";
                    RoadTestScore.Sort = "";
                    dt_RoadTestScore.Sort = "";
                    AccidentOccurrence.Sort = "";
                    Dt_AccidentOccurrence.Sort = "";
                    AccidentNotes.Sort = "";
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

            // "detail_tblEvaluation"
            item = ListOptions.Add("detail_tblEvaluation");
            item.CssClass = "text-nowrap";
            item.Visible = Security.AllowList(CurrentProjectID + "tblEvaluation");
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.ShowInButtonGroup = false;
            tblEvaluationGrid = Resolve("TblEvaluationGrid")!;

            // "detail_tblEvaluationMB"
            item = ListOptions.Add("detail_tblEvaluationMB");
            item.CssClass = "text-nowrap";
            item.Visible = Security.AllowList(CurrentProjectID + "tblEvaluationMB");
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.ShowInButtonGroup = false;
            tblEvaluationMbGrid = Resolve("TblEvaluationMbGrid")!;

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
            _pages.Add("tblEvaluation");
            _pages.Add("tblEvaluationMB");
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

            // "view"
            listOption = ListOptions["view"];
            string viewcaption = Language.Phrase("ViewLink", true);
            isVisible = Security.CanView && ShowOptionLink("view");
            if (isVisible) {
                if (ModalView && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-table=""tblAssessment"" data-caption=""{viewcaption}"" data-ew-action=""modal"" data-action=""view"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(ViewUrl)) + "\" data-btn=\"null\">" + Language.Phrase("ViewLink") + "</a>");
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
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblAssessment"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblAssessmentlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblAssessmentlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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

            // "detail_tblEvaluation"
            listOption = ListOptions["detail_tblEvaluation"];
            isVisible = Security.AllowList(CurrentProjectID + "tblEvaluation") && ShowOptionLink();
            if (isVisible) {
                string caption, title, url;
                var body = Language.Phrase("DetailLink") + Language.TablePhrase("tblEvaluation", "TblCaption");
                body = "<a class=\"btn btn-default ew-row-link ew-detail" + (ListOptions.UseDropDownButton ? " dropdown-toggle" : "") + "\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblEvaluationList?" + Config.TableShowMaster + "=tblAssessment&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.CurrentValue) + "")) + "\">" + body + "</a>";
                string links = "";
                detailPage = Resolve("TblEvaluationGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblAssessment") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink", null);
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = GetViewUrl(Config.TableShowDetail + "=tblEvaluation");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailViewTblVar))
                        detailViewTblVar += ",";
                    detailViewTblVar += "tblEvaluation";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblAssessment") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink", null);
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = GetEditUrl(Config.TableShowDetail + "=tblEvaluation");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailEditTblVar))
                        detailEditTblVar += ",";
                    detailEditTblVar += "tblEvaluation";
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

            // "detail_tblEvaluationMB"
            listOption = ListOptions["detail_tblEvaluationMB"];
            isVisible = Security.AllowList(CurrentProjectID + "tblEvaluationMB") && ShowOptionLink();
            if (isVisible) {
                string caption, title, url;
                var body = Language.Phrase("DetailLink") + Language.TablePhrase("tblEvaluationMB", "TblCaption");
                body = "<a class=\"btn btn-default ew-row-link ew-detail" + (ListOptions.UseDropDownButton ? " dropdown-toggle" : "") + "\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblEvaluationMbList?" + Config.TableShowMaster + "=tblAssessment&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.CurrentValue) + "")) + "\">" + body + "</a>";
                string links = "";
                detailPage = Resolve("TblEvaluationMbGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblAssessment") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink", null);
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = GetViewUrl(Config.TableShowDetail + "=tblEvaluationMB");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailViewTblVar))
                        detailViewTblVar += ",";
                    detailViewTblVar += "tblEvaluationMB";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblAssessment") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink", null);
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = GetEditUrl(Config.TableShowDetail + "=tblEvaluationMB");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailEditTblVar))
                        detailEditTblVar += ",";
                    detailEditTblVar += "tblEvaluationMB";
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
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(AssessmentID.CurrentValue) + "\"></div>");
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
            sqlwrk = KeyFilter(Resolve("tblEvaluation")!.AssessmentID, AssessmentID.CurrentValue, AssessmentID.DataType, DbId);
            masterKeys.Add(ConvertToString(AssessmentID.CurrentValue));

            // Column "detail_tblEvaluation"
            if ((DetailPages?["tblEvaluation"]?.Visible ?? false) && Security.AllowList(CurrentProjectID + "tblEvaluation")) {
                link = "";
                option = ListOptions["detail_tblEvaluation"];
                url = "TblEvaluationPreview?t=tblAssessment&f=" + Encrypt(sqlwrk + "|" + String.Join("|", masterKeys));
                btngrp = "<div data-table=\"tblEvaluation\" data-url=\"" + AppPath(url) + "\" class=\"ew-detail-btn-group d-none\">";
                if (Security.AllowList(CurrentProjectID + "tblAssessment")) {
                    string label = Language.TablePhrase("tblEvaluation", "TblCaption");
                    link = "<button class=\"nav-link\" data-bs-toggle=\"tab\" data-table=\"tblEvaluation\" data-url=\"" + AppPath(url) + "\" type=\"button\" role=\"tab\" aria-selected=\"false\">" + label + "</button>";
                    detaillnk = AppPath("TblEvaluationList?" + Config.TableShowMaster + "=tblAssessment&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.CurrentValue) + "");
                    title = Language.TablePhrase("tblEvaluation", "TblCaption");
                    caption = Language.Phrase("MasterDetailListLink");
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(detaillnk) + "\">" + caption + "</a>";
                }
                detailPage = Resolve("TblEvaluationGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblAssessment") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink");
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = AppPath(GetViewUrl(Config.TableShowDetail + "=tblEvaluation"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblAssessment") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink");
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = AppPath(GetEditUrl(Config.TableShowDetail + "=tblEvaluation"));
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
            sqlwrk = KeyFilter(Resolve("tblEvaluationMB")!.AssessmentID, AssessmentID.CurrentValue, AssessmentID.DataType, DbId);
            masterKeys.Add(ConvertToString(AssessmentID.CurrentValue));

            // Column "detail_tblEvaluationMB"
            if ((DetailPages?["tblEvaluationMB"]?.Visible ?? false) && Security.AllowList(CurrentProjectID + "tblEvaluationMB")) {
                link = "";
                option = ListOptions["detail_tblEvaluationMB"];
                url = "TblEvaluationMbPreview?t=tblAssessment&f=" + Encrypt(sqlwrk + "|" + String.Join("|", masterKeys));
                btngrp = "<div data-table=\"tblEvaluationMB\" data-url=\"" + AppPath(url) + "\" class=\"ew-detail-btn-group d-none\">";
                if (Security.AllowList(CurrentProjectID + "tblAssessment")) {
                    string label = Language.TablePhrase("tblEvaluationMB", "TblCaption");
                    link = "<button class=\"nav-link\" data-bs-toggle=\"tab\" data-table=\"tblEvaluationMB\" data-url=\"" + AppPath(url) + "\" type=\"button\" role=\"tab\" aria-selected=\"false\">" + label + "</button>";
                    detaillnk = AppPath("TblEvaluationMbList?" + Config.TableShowMaster + "=tblAssessment&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.CurrentValue) + "");
                    title = Language.TablePhrase("tblEvaluationMB", "TblCaption");
                    caption = Language.Phrase("MasterDetailListLink");
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(detaillnk) + "\">" + caption + "</a>";
                }
                detailPage = Resolve("TblEvaluationMbGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblAssessment") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink");
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = AppPath(GetViewUrl(Config.TableShowDetail + "=tblEvaluationMB"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblAssessment") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink");
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = AppPath(GetEditUrl(Config.TableShowDetail + "=tblEvaluationMB"));
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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblAssessmentlist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblAssessmentsrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblAssessmentsrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblAssessmentlist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                    RowAttrs.Add("id", "r0_tblAssessment");
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblAssessmentList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblAssessmentList.RowCount) + "_tblAssessment");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblAssessmentList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblAssessmentList.RowType == RowType.Add || IsEdit && tblAssessmentList.RowType == RowType.Edit) // Inline-Add/Edit row
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

            // str_Full_Name_Hdr
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Full_Name_Hdr"))
                    str_Full_Name_Hdr.AdvancedSearch.SearchValue = Get("x_str_Full_Name_Hdr");
                else
                    str_Full_Name_Hdr.AdvancedSearch.SearchValue = Get("str_Full_Name_Hdr"); // Default Value // DN
            if (!Empty(str_Full_Name_Hdr.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Full_Name_Hdr"))
                str_Full_Name_Hdr.AdvancedSearch.SearchOperator = Get("z_str_Full_Name_Hdr");

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

            // str_Middle_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Middle_Name"))
                    str_Middle_Name.AdvancedSearch.SearchValue = Get("x_str_Middle_Name");
                else
                    str_Middle_Name.AdvancedSearch.SearchValue = Get("str_Middle_Name"); // Default Value // DN
            if (!Empty(str_Middle_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Middle_Name"))
                str_Middle_Name.AdvancedSearch.SearchOperator = Get("z_str_Middle_Name");

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
                if (Query.ContainsKey("x_str_Username[]"))
                    str_Username.AdvancedSearch.SearchValue = Get("x_str_Username[]");
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

            // Assessment_Type
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Assessment_Type"))
                    Assessment_Type.AdvancedSearch.SearchValue = Get("x_Assessment_Type");
                else
                    Assessment_Type.AdvancedSearch.SearchValue = Get("Assessment_Type"); // Default Value // DN
            if (!Empty(Assessment_Type.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Assessment_Type"))
                Assessment_Type.AdvancedSearch.SearchOperator = Get("z_Assessment_Type");

            // AssessmentDate
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AssessmentDate[]"))
                    AssessmentDate.AdvancedSearch.SearchValue = Get("x_AssessmentDate[]");
                else
                    AssessmentDate.AdvancedSearch.SearchValue = Get("AssessmentDate"); // Default Value // DN
            if (!Empty(AssessmentDate.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AssessmentDate"))
                AssessmentDate.AdvancedSearch.SearchOperator = Get("z_AssessmentDate");

            // AssessmentTime
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AssessmentTime"))
                    AssessmentTime.AdvancedSearch.SearchValue = Get("x_AssessmentTime");
                else
                    AssessmentTime.AdvancedSearch.SearchValue = Get("AssessmentTime"); // Default Value // DN
            if (!Empty(AssessmentTime.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AssessmentTime"))
                AssessmentTime.AdvancedSearch.SearchOperator = Get("z_AssessmentTime");

            // isAssessmentDone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_isAssessmentDone"))
                    isAssessmentDone.AdvancedSearch.SearchValue = Get("x_isAssessmentDone");
                else
                    isAssessmentDone.AdvancedSearch.SearchValue = Get("isAssessmentDone"); // Default Value // DN
            if (!Empty(isAssessmentDone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_isAssessmentDone"))
                isAssessmentDone.AdvancedSearch.SearchOperator = Get("z_isAssessmentDone");

            // AssessmentScore
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AssessmentScore[]"))
                    AssessmentScore.AdvancedSearch.SearchValue = Get("x_AssessmentScore[]");
                else
                    AssessmentScore.AdvancedSearch.SearchValue = Get("AssessmentScore"); // Default Value // DN
            if (!Empty(AssessmentScore.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AssessmentScore"))
                AssessmentScore.AdvancedSearch.SearchOperator = Get("z_AssessmentScore");

            // Assessment_Instructor
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Assessment_Instructor"))
                    Assessment_Instructor.AdvancedSearch.SearchValue = Get("x_Assessment_Instructor");
                else
                    Assessment_Instructor.AdvancedSearch.SearchValue = Get("Assessment_Instructor"); // Default Value // DN
            if (!Empty(Assessment_Instructor.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Assessment_Instructor"))
                Assessment_Instructor.AdvancedSearch.SearchOperator = Get("z_Assessment_Instructor");

            // Date_Entered
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Date_Entered"))
                    Date_Entered.AdvancedSearch.SearchValue = Get("x_Date_Entered");
                else
                    Date_Entered.AdvancedSearch.SearchValue = Get("Date_Entered"); // Default Value // DN
            if (!Empty(Date_Entered.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Date_Entered"))
                Date_Entered.AdvancedSearch.SearchOperator = Get("z_Date_Entered");

            // IsDrivingexperience
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_IsDrivingexperience"))
                    IsDrivingexperience.AdvancedSearch.SearchValue = Get("x_IsDrivingexperience");
                else
                    IsDrivingexperience.AdvancedSearch.SearchValue = Get("IsDrivingexperience"); // Default Value // DN
            if (!Empty(IsDrivingexperience.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_IsDrivingexperience"))
                IsDrivingexperience.AdvancedSearch.SearchOperator = Get("z_IsDrivingexperience");

            // intDrivinglicenseType
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_intDrivinglicenseType"))
                    intDrivinglicenseType.AdvancedSearch.SearchValue = Get("x_intDrivinglicenseType");
                else
                    intDrivinglicenseType.AdvancedSearch.SearchValue = Get("intDrivinglicenseType"); // Default Value // DN
            if (!Empty(intDrivinglicenseType.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchOperator = Get("z_intDrivinglicenseType");

            // AbsherApptNbr
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AbsherApptNbr"))
                    AbsherApptNbr.AdvancedSearch.SearchValue = Get("x_AbsherApptNbr");
                else
                    AbsherApptNbr.AdvancedSearch.SearchValue = Get("AbsherApptNbr"); // Default Value // DN
            if (!Empty(AbsherApptNbr.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AbsherApptNbr"))
                AbsherApptNbr.AdvancedSearch.SearchOperator = Get("z_AbsherApptNbr");

            // Absherphoto
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Absherphoto"))
                    Absherphoto.AdvancedSearch.SearchValue = Get("x_Absherphoto");
                else
                    Absherphoto.AdvancedSearch.SearchValue = Get("Absherphoto"); // Default Value // DN
            if (!Empty(Absherphoto.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Absherphoto"))
                Absherphoto.AdvancedSearch.SearchOperator = Get("z_Absherphoto");

            // date_Birth
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Birth"))
                    date_Birth.AdvancedSearch.SearchValue = Get("x_date_Birth");
                else
                    date_Birth.AdvancedSearch.SearchValue = Get("date_Birth"); // Default Value // DN
            if (!Empty(date_Birth.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Birth"))
                date_Birth.AdvancedSearch.SearchOperator = Get("z_date_Birth");

            // date_Birth_Hijri
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Birth_Hijri"))
                    date_Birth_Hijri.AdvancedSearch.SearchValue = Get("x_date_Birth_Hijri");
                else
                    date_Birth_Hijri.AdvancedSearch.SearchValue = Get("date_Birth_Hijri"); // Default Value // DN
            if (!Empty(date_Birth_Hijri.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Birth_Hijri"))
                date_Birth_Hijri.AdvancedSearch.SearchOperator = Get("z_date_Birth_Hijri");

            // str_Cell_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Cell_Phone"))
                    str_Cell_Phone.AdvancedSearch.SearchValue = Get("x_str_Cell_Phone");
                else
                    str_Cell_Phone.AdvancedSearch.SearchValue = Get("str_Cell_Phone"); // Default Value // DN
            if (!Empty(str_Cell_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Cell_Phone"))
                str_Cell_Phone.AdvancedSearch.SearchOperator = Get("z_str_Cell_Phone");

            // str_Email
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Email"))
                    str_Email.AdvancedSearch.SearchValue = Get("x_str_Email");
                else
                    str_Email.AdvancedSearch.SearchValue = Get("str_Email"); // Default Value // DN
            if (!Empty(str_Email.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Email"))
                str_Email.AdvancedSearch.SearchOperator = Get("z_str_Email");

            // UserlevelID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_UserlevelID"))
                    UserlevelID.AdvancedSearch.SearchValue = Get("x_UserlevelID");
                else
                    UserlevelID.AdvancedSearch.SearchValue = Get("UserlevelID"); // Default Value // DN
            if (!Empty(UserlevelID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_UserlevelID"))
                UserlevelID.AdvancedSearch.SearchOperator = Get("z_UserlevelID");

            // DriveTypelink
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_DriveTypelink"))
                    DriveTypelink.AdvancedSearch.SearchValue = Get("x_DriveTypelink");
                else
                    DriveTypelink.AdvancedSearch.SearchValue = Get("DriveTypelink"); // Default Value // DN
            if (!Empty(DriveTypelink.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_DriveTypelink"))
                DriveTypelink.AdvancedSearch.SearchOperator = Get("z_DriveTypelink");

            // Calendar_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Calendar_ID"))
                    Calendar_ID.AdvancedSearch.SearchValue = Get("x_Calendar_ID");
                else
                    Calendar_ID.AdvancedSearch.SearchValue = Get("Calendar_ID"); // Default Value // DN
            if (!Empty(Calendar_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Calendar_ID"))
                Calendar_ID.AdvancedSearch.SearchOperator = Get("z_Calendar_ID");

            // Assessmnt_Time
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Assessmnt_Time"))
                    Assessmnt_Time.AdvancedSearch.SearchValue = Get("x_Assessmnt_Time");
                else
                    Assessmnt_Time.AdvancedSearch.SearchValue = Get("Assessmnt_Time"); // Default Value // DN
            if (!Empty(Assessmnt_Time.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Assessmnt_Time"))
                Assessmnt_Time.AdvancedSearch.SearchOperator = Get("z_Assessmnt_Time");

            // Institution
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Institution"))
                    Institution.AdvancedSearch.SearchValue = Get("x_Institution");
                else
                    Institution.AdvancedSearch.SearchValue = Get("Institution"); // Default Value // DN
            if (!Empty(Institution.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Institution"))
                Institution.AdvancedSearch.SearchOperator = Get("z_Institution");

            // TheoreticalScore
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_TheoreticalScore"))
                    TheoreticalScore.AdvancedSearch.SearchValue = Get("x_TheoreticalScore");
                else
                    TheoreticalScore.AdvancedSearch.SearchValue = Get("TheoreticalScore"); // Default Value // DN
            if (!Empty(TheoreticalScore.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_TheoreticalScore"))
                TheoreticalScore.AdvancedSearch.SearchOperator = Get("z_TheoreticalScore");

            // dt_TheoreticalScore
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_TheoreticalScore"))
                    dt_TheoreticalScore.AdvancedSearch.SearchValue = Get("x_dt_TheoreticalScore");
                else
                    dt_TheoreticalScore.AdvancedSearch.SearchValue = Get("dt_TheoreticalScore"); // Default Value // DN
            if (!Empty(dt_TheoreticalScore.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_TheoreticalScore"))
                dt_TheoreticalScore.AdvancedSearch.SearchOperator = Get("z_dt_TheoreticalScore");

            // RoadTestScore
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_RoadTestScore"))
                    RoadTestScore.AdvancedSearch.SearchValue = Get("x_RoadTestScore");
                else
                    RoadTestScore.AdvancedSearch.SearchValue = Get("RoadTestScore"); // Default Value // DN
            if (!Empty(RoadTestScore.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_RoadTestScore"))
                RoadTestScore.AdvancedSearch.SearchOperator = Get("z_RoadTestScore");

            // dt_RoadTestScore
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_dt_RoadTestScore"))
                    dt_RoadTestScore.AdvancedSearch.SearchValue = Get("x_dt_RoadTestScore");
                else
                    dt_RoadTestScore.AdvancedSearch.SearchValue = Get("dt_RoadTestScore"); // Default Value // DN
            if (!Empty(dt_RoadTestScore.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_dt_RoadTestScore"))
                dt_RoadTestScore.AdvancedSearch.SearchOperator = Get("z_dt_RoadTestScore");

            // AccidentOccurrence
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AccidentOccurrence"))
                    AccidentOccurrence.AdvancedSearch.SearchValue = Get("x_AccidentOccurrence");
                else
                    AccidentOccurrence.AdvancedSearch.SearchValue = Get("AccidentOccurrence"); // Default Value // DN
            if (!Empty(AccidentOccurrence.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AccidentOccurrence"))
                AccidentOccurrence.AdvancedSearch.SearchOperator = Get("z_AccidentOccurrence");

            // Dt_AccidentOccurrence
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Dt_AccidentOccurrence"))
                    Dt_AccidentOccurrence.AdvancedSearch.SearchValue = Get("x_Dt_AccidentOccurrence");
                else
                    Dt_AccidentOccurrence.AdvancedSearch.SearchValue = Get("Dt_AccidentOccurrence"); // Default Value // DN
            if (!Empty(Dt_AccidentOccurrence.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Dt_AccidentOccurrence"))
                Dt_AccidentOccurrence.AdvancedSearch.SearchOperator = Get("z_Dt_AccidentOccurrence");

            // AccidentNotes
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AccidentNotes"))
                    AccidentNotes.AdvancedSearch.SearchValue = Get("x_AccidentNotes");
                else
                    AccidentNotes.AdvancedSearch.SearchValue = Get("AccidentNotes"); // Default Value // DN
            if (!Empty(AccidentNotes.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AccidentNotes"))
                AccidentNotes.AdvancedSearch.SearchOperator = Get("z_AccidentNotes");
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
            AssessmentID.SetDbValue(row["AssessmentID"]);
            str_Full_Name_Hdr.SetDbValue(row["str_Full_Name_Hdr"]);
            str_First_Name.SetDbValue(row["str_First_Name"]);
            str_Middle_Name.SetDbValue(row["str_Middle_Name"]);
            str_Last_Name.SetDbValue(row["str_Last_Name"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            NationalID.SetDbValue(row["NationalID"]);
            Assessment_Type.SetDbValue(row["Assessment_Type"]);
            AssessmentDate.SetDbValue(row["AssessmentDate"]);
            AssessmentTime.SetDbValue(row["AssessmentTime"]);
            isAssessmentDone.SetDbValue(row["isAssessmentDone"]);
            AssessmentScore.SetDbValue(row["AssessmentScore"]);
            Assessment_Instructor.SetDbValue(row["Assessment_Instructor"]);
            Date_Entered.SetDbValue(row["Date_Entered"]);
            IsDrivingexperience.SetDbValue((ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"));
            intDrivinglicenseType.SetDbValue(row["intDrivinglicenseType"]);
            AbsherApptNbr.SetDbValue(row["AbsherApptNbr"]);
            Absherphoto.Upload.DbValue = row["Absherphoto"];
            Absherphoto.SetDbValue(Absherphoto.Upload.DbValue);
            date_Birth.SetDbValue(row["date_Birth"]);
            date_Birth_Hijri.SetDbValue(row["date_Birth_Hijri"]);
            str_Cell_Phone.SetDbValue(row["str_Cell_Phone"]);
            str_Email.SetDbValue(row["str_Email"]);
            UserlevelID.SetDbValue(row["UserlevelID"]);
            BackDateChk.SetDbValue(row["BackDateChk"]);
            DriveTypelink.SetDbValue(row["DriveTypelink"]);
            Calendar_ID.SetDbValue(row["Calendar_ID"]);
            Assessmnt_Time.SetDbValue(row["Assessmnt_Time"]);
            Institution.SetDbValue(row["Institution"]);
            TheoreticalScore.SetDbValue(IsNull(row["TheoreticalScore"]) ? DbNullValue : ConvertToDouble(row["TheoreticalScore"]));
            dt_TheoreticalScore.SetDbValue(row["dt_TheoreticalScore"]);
            RoadTestScore.SetDbValue(IsNull(row["RoadTestScore"]) ? DbNullValue : ConvertToDouble(row["RoadTestScore"]));
            dt_RoadTestScore.SetDbValue(row["dt_RoadTestScore"]);
            AccidentOccurrence.SetDbValue((ConvertToBool(row["AccidentOccurrence"]) ? "1" : "0"));
            Dt_AccidentOccurrence.SetDbValue(row["Dt_AccidentOccurrence"]);
            AccidentNotes.SetDbValue(row["AccidentNotes"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("AssessmentID", AssessmentID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Full_Name_Hdr", str_Full_Name_Hdr.DefaultValue ?? DbNullValue); // DN
            row.Add("str_First_Name", str_First_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Middle_Name", str_Middle_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last_Name", str_Last_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("Assessment_Type", Assessment_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentDate", AssessmentDate.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentTime", AssessmentTime.DefaultValue ?? DbNullValue); // DN
            row.Add("isAssessmentDone", isAssessmentDone.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentScore", AssessmentScore.DefaultValue ?? DbNullValue); // DN
            row.Add("Assessment_Instructor", Assessment_Instructor.DefaultValue ?? DbNullValue); // DN
            row.Add("Date_Entered", Date_Entered.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDrivingexperience", IsDrivingexperience.DefaultValue ?? DbNullValue); // DN
            row.Add("intDrivinglicenseType", intDrivinglicenseType.DefaultValue ?? DbNullValue); // DN
            row.Add("AbsherApptNbr", AbsherApptNbr.DefaultValue ?? DbNullValue); // DN
            row.Add("Absherphoto", Absherphoto.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth", date_Birth.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth_Hijri", date_Birth_Hijri.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Cell_Phone", str_Cell_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email", str_Email.DefaultValue ?? DbNullValue); // DN
            row.Add("UserlevelID", UserlevelID.DefaultValue ?? DbNullValue); // DN
            row.Add("BackDateChk", BackDateChk.DefaultValue ?? DbNullValue); // DN
            row.Add("DriveTypelink", DriveTypelink.DefaultValue ?? DbNullValue); // DN
            row.Add("Calendar_ID", Calendar_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Assessmnt_Time", Assessmnt_Time.DefaultValue ?? DbNullValue); // DN
            row.Add("Institution", Institution.DefaultValue ?? DbNullValue); // DN
            row.Add("TheoreticalScore", TheoreticalScore.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_TheoreticalScore", dt_TheoreticalScore.DefaultValue ?? DbNullValue); // DN
            row.Add("RoadTestScore", RoadTestScore.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_RoadTestScore", dt_RoadTestScore.DefaultValue ?? DbNullValue); // DN
            row.Add("AccidentOccurrence", AccidentOccurrence.DefaultValue ?? DbNullValue); // DN
            row.Add("Dt_AccidentOccurrence", Dt_AccidentOccurrence.DefaultValue ?? DbNullValue); // DN
            row.Add("AccidentNotes", AccidentNotes.DefaultValue ?? DbNullValue); // DN
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

            // AssessmentID

            // str_Full_Name_Hdr

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Username

            // int_Student_ID

            // NationalID
            NationalID.CellCssStyle = "white-space: nowrap;";

            // Assessment_Type

            // AssessmentDate

            // AssessmentTime

            // isAssessmentDone

            // AssessmentScore

            // Assessment_Instructor
            Assessment_Instructor.CellCssStyle = "white-space: nowrap;";

            // Date_Entered

            // IsDrivingexperience

            // intDrivinglicenseType

            // AbsherApptNbr

            // Absherphoto

            // date_Birth

            // date_Birth_Hijri
            date_Birth_Hijri.CellCssStyle = "white-space: nowrap;";

            // str_Cell_Phone

            // str_Email

            // UserlevelID

            // BackDateChk
            BackDateChk.CellCssStyle = "white-space: nowrap;";

            // DriveTypelink
            DriveTypelink.CellCssStyle = "white-space: nowrap;";

            // Calendar_ID
            Calendar_ID.CellCssStyle = "white-space: nowrap;";

            // Assessmnt_Time
            Assessmnt_Time.CellCssStyle = "white-space: nowrap;";

            // Institution

            // TheoreticalScore

            // dt_TheoreticalScore

            // RoadTestScore

            // dt_RoadTestScore

            // AccidentOccurrence

            // Dt_AccidentOccurrence

            // AccidentNotes

            // View row
            if (RowType == RowType.View) {
                // AssessmentID
                AssessmentID.ViewValue = AssessmentID.CurrentValue;
                AssessmentID.ViewCustomAttributes = "";

                // str_Full_Name_Hdr
                curVal = ConvertToString(str_Full_Name_Hdr.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Full_Name_Hdr.Lookup != null && IsDictionary(str_Full_Name_Hdr.Lookup?.Options) && str_Full_Name_Hdr.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name_Hdr.CurrentValue, DataType.String, "");
                        lookupFilter = () => str_Full_Name_Hdr.GetSelectFilter();
                        sqlWrk = str_Full_Name_Hdr.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Full_Name_Hdr.Lookup != null) { // Lookup values found
                            var listwrk = str_Full_Name_Hdr.Lookup?.RenderViewRow(rswrk[0]);
                            str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.HighlightLookup(ConvertToString(rswrk[0]), str_Full_Name_Hdr.DisplayValue(listwrk));
                        } else {
                            str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.CurrentValue;
                        }
                    }
                } else {
                    str_Full_Name_Hdr.ViewValue = DbNullValue;
                }
                str_Full_Name_Hdr.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Middle_Name
                str_Middle_Name.ViewValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
                str_Middle_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // int_Student_ID
                int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
                int_Student_ID.ImageAlt = int_Student_ID.Alt;
                    int_Student_ID.ImageCssClass = "ew-image";
                int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
                int_Student_ID.ViewCustomAttributes = "";

                // Assessment_Type
                if (!Empty(Assessment_Type.CurrentValue)) {
                    Assessment_Type.ViewValue = Assessment_Type.HighlightLookup(ConvertToString(Assessment_Type.CurrentValue), Assessment_Type.OptionCaption(ConvertToString(Assessment_Type.CurrentValue)));
                } else {
                    Assessment_Type.ViewValue = DbNullValue;
                }
                Assessment_Type.ViewCustomAttributes = "";

                // AssessmentDate
                AssessmentDate.ViewValue = AssessmentDate.CurrentValue;
                AssessmentDate.ViewValue = FormatDateTime(AssessmentDate.ViewValue, AssessmentDate.FormatPattern);
                AssessmentDate.ViewCustomAttributes = "";

                // AssessmentTime
                AssessmentTime.ViewValue = ConvertToString(AssessmentTime.CurrentValue); // DN
                AssessmentTime.ViewCustomAttributes = "";

                // isAssessmentDone
                if (!Empty(isAssessmentDone.CurrentValue)) {
                    isAssessmentDone.ViewValue = isAssessmentDone.HighlightLookup(ConvertToString(isAssessmentDone.CurrentValue), isAssessmentDone.OptionCaption(ConvertToString(isAssessmentDone.CurrentValue)));
                } else {
                    isAssessmentDone.ViewValue = DbNullValue;
                }
                isAssessmentDone.ViewCustomAttributes = "";

                // AssessmentScore
                AssessmentScore.ViewValue = ConvertToString(AssessmentScore.CurrentValue); // DN
                AssessmentScore.ViewCustomAttributes = "";

                // Assessment_Instructor
                curVal = ConvertToString(Assessment_Instructor.CurrentValue);
                if (!Empty(curVal)) {
                    if (Assessment_Instructor.Lookup != null && IsDictionary(Assessment_Instructor.Lookup?.Options) && Assessment_Instructor.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Assessment_Instructor.ViewValue = Assessment_Instructor.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Full_Name]", "=", Assessment_Instructor.CurrentValue, DataType.String, "");
                        sqlWrk = Assessment_Instructor.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Assessment_Instructor.Lookup != null) { // Lookup values found
                            var listwrk = Assessment_Instructor.Lookup?.RenderViewRow(rswrk[0]);
                            Assessment_Instructor.ViewValue = Assessment_Instructor.HighlightLookup(ConvertToString(rswrk[0]), Assessment_Instructor.DisplayValue(listwrk));
                        } else {
                            Assessment_Instructor.ViewValue = Assessment_Instructor.CurrentValue;
                        }
                    }
                } else {
                    Assessment_Instructor.ViewValue = DbNullValue;
                }
                Assessment_Instructor.ViewCustomAttributes = "";

                // Date_Entered
                Date_Entered.ViewValue = Date_Entered.CurrentValue;
                Date_Entered.ViewValue = FormatDateTime(Date_Entered.ViewValue, Date_Entered.FormatPattern);
                Date_Entered.ViewCustomAttributes = "";

                // IsDrivingexperience
                if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
                } else {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
                }
                IsDrivingexperience.ViewCustomAttributes = "";

                // intDrivinglicenseType
                intDrivinglicenseType.ViewValue = intDrivinglicenseType.CurrentValue;
                intDrivinglicenseType.ViewValue = FormatNumber(intDrivinglicenseType.ViewValue, intDrivinglicenseType.FormatPattern);
                intDrivinglicenseType.ViewCustomAttributes = "";

                // AbsherApptNbr
                AbsherApptNbr.ViewValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
                AbsherApptNbr.ViewCustomAttributes = "";

                // Absherphoto
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.ImageWidth = 200;
                    Absherphoto.ImageHeight = 200;
                    Absherphoto.ImageAlt = Absherphoto.Alt;
                    Absherphoto.ImageCssClass = "ew-image";
                    Absherphoto.ViewValue = Absherphoto.Upload.DbValue;
                } else {
                    Absherphoto.ViewValue = "";
                }
                Absherphoto.ViewCustomAttributes = "";

                // date_Birth
                date_Birth.ViewValue = date_Birth.CurrentValue;
                date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
                date_Birth.ViewCustomAttributes = "";

                // date_Birth_Hijri
                date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // str_Cell_Phone
                str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
                str_Cell_Phone.ViewCustomAttributes = "";

                // str_Email
                str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
                str_Email.ViewCustomAttributes = "";

                // UserlevelID
                UserlevelID.ViewValue = UserlevelID.CurrentValue;
                UserlevelID.ViewValue = FormatNumber(UserlevelID.ViewValue, UserlevelID.FormatPattern);
                UserlevelID.ViewCustomAttributes = "";

                // Calendar_ID
                Calendar_ID.ViewValue = Calendar_ID.CurrentValue;
                Calendar_ID.ViewValue = FormatNumber(Calendar_ID.ViewValue, Calendar_ID.FormatPattern);
                Calendar_ID.ViewCustomAttributes = "";

                // Assessmnt_Time
                Assessmnt_Time.ViewValue = Assessmnt_Time.CurrentValue;
                Assessmnt_Time.ViewValue = FormatDateTime(Assessmnt_Time.ViewValue, Assessmnt_Time.FormatPattern);
                Assessmnt_Time.ViewCustomAttributes = "";

                // Institution
                Institution.ViewValue = ConvertToString(Institution.CurrentValue); // DN
                Institution.ViewCustomAttributes = "";

                // TheoreticalScore
                TheoreticalScore.ViewValue = TheoreticalScore.CurrentValue;
                TheoreticalScore.ViewValue = FormatNumber(TheoreticalScore.ViewValue, TheoreticalScore.FormatPattern);
                TheoreticalScore.ViewCustomAttributes = "";

                // dt_TheoreticalScore
                dt_TheoreticalScore.ViewValue = dt_TheoreticalScore.CurrentValue;
                dt_TheoreticalScore.ViewValue = FormatDateTime(dt_TheoreticalScore.ViewValue, dt_TheoreticalScore.FormatPattern);
                dt_TheoreticalScore.ViewCustomAttributes = "";

                // RoadTestScore
                RoadTestScore.ViewValue = RoadTestScore.CurrentValue;
                RoadTestScore.ViewValue = FormatNumber(RoadTestScore.ViewValue, RoadTestScore.FormatPattern);
                RoadTestScore.ViewCustomAttributes = "";

                // dt_RoadTestScore
                dt_RoadTestScore.ViewValue = dt_RoadTestScore.CurrentValue;
                dt_RoadTestScore.ViewValue = FormatDateTime(dt_RoadTestScore.ViewValue, dt_RoadTestScore.FormatPattern);
                dt_RoadTestScore.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";
                str_Middle_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // Assessment_Type
                Assessment_Type.HrefValue = "";
                Assessment_Type.TooltipValue = "";

                // AssessmentDate
                AssessmentDate.HrefValue = "";
                AssessmentDate.TooltipValue = "";

                // isAssessmentDone
                isAssessmentDone.HrefValue = "";
                isAssessmentDone.TooltipValue = "";

                // AssessmentScore
                AssessmentScore.HrefValue = "";
                AssessmentScore.TooltipValue = "";
            } else if (RowType == RowType.Search) {
                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.AdvancedSearch.SearchValue = HtmlDecode(str_First_Name.AdvancedSearch.SearchValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.AdvancedSearch.SearchValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Middle_Name
                str_Middle_Name.SetupEditAttributes();
                if (!str_Middle_Name.Raw)
                    str_Middle_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Middle_Name.AdvancedSearch.SearchValue);
                str_Middle_Name.EditValue = HtmlEncode(str_Middle_Name.AdvancedSearch.SearchValue);
                str_Middle_Name.PlaceHolder = RemoveHtml(str_Middle_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Username
                if (str_Username.UseFilter && !Empty(str_Username.AdvancedSearch.SearchValue)) {
                    str_Username.EditValue = ConvertToString(str_Username.AdvancedSearch.SearchValue).Split(Config.MultipleOptionSeparator).ToList();
                }

                // Assessment_Type
                Assessment_Type.SetupEditAttributes();
                Assessment_Type.EditValue = Assessment_Type.Options(true);
                Assessment_Type.PlaceHolder = RemoveHtml(Assessment_Type.Caption);

                // AssessmentDate
                if (AssessmentDate.UseFilter && !Empty(AssessmentDate.AdvancedSearch.SearchValue)) {
                    AssessmentDate.EditValue = ConvertToString(AssessmentDate.AdvancedSearch.SearchValue).Split(Config.MultipleOptionSeparator).ToList();
                }

                // isAssessmentDone
                isAssessmentDone.EditValue = isAssessmentDone.Options(false);
                isAssessmentDone.PlaceHolder = RemoveHtml(isAssessmentDone.Caption);

                // AssessmentScore
                if (AssessmentScore.UseFilter && !Empty(AssessmentScore.AdvancedSearch.SearchValue)) {
                    AssessmentScore.EditValue = ConvertToString(AssessmentScore.AdvancedSearch.SearchValue).Split(Config.MultipleOptionSeparator).ToList();
                }
            }

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
            AssessmentID.AdvancedSearch.Load();
            str_Full_Name_Hdr.AdvancedSearch.Load();
            str_First_Name.AdvancedSearch.Load();
            str_Middle_Name.AdvancedSearch.Load();
            str_Last_Name.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            int_Student_ID.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            Assessment_Type.AdvancedSearch.Load();
            AssessmentDate.AdvancedSearch.Load();
            AssessmentTime.AdvancedSearch.Load();
            isAssessmentDone.AdvancedSearch.Load();
            AssessmentScore.AdvancedSearch.Load();
            Assessment_Instructor.AdvancedSearch.Load();
            Date_Entered.AdvancedSearch.Load();
            IsDrivingexperience.AdvancedSearch.Load();
            intDrivinglicenseType.AdvancedSearch.Load();
            AbsherApptNbr.AdvancedSearch.Load();
            Absherphoto.AdvancedSearch.Load();
            date_Birth.AdvancedSearch.Load();
            date_Birth_Hijri.AdvancedSearch.Load();
            str_Cell_Phone.AdvancedSearch.Load();
            str_Email.AdvancedSearch.Load();
            UserlevelID.AdvancedSearch.Load();
            DriveTypelink.AdvancedSearch.Load();
            Calendar_ID.AdvancedSearch.Load();
            Assessmnt_Time.AdvancedSearch.Load();
            Institution.AdvancedSearch.Load();
            TheoreticalScore.AdvancedSearch.Load();
            dt_TheoreticalScore.AdvancedSearch.Load();
            RoadTestScore.AdvancedSearch.Load();
            dt_RoadTestScore.AdvancedSearch.Load();
            AccidentOccurrence.AdvancedSearch.Load();
            Dt_AccidentOccurrence.AdvancedSearch.Load();
            AccidentNotes.AdvancedSearch.Load();
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblAssessmentlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblAssessmentlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblAssessmentlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblAssessmentlist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblAssessmentsrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
            item.Visible = true;

            // Show all button
            item = SearchOptions.Add("showall");
            if (UseCustomTemplate || !UseAjaxActions)
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ResetSearch") + "\" data-caption=\"" + Language.Phrase("ResetSearch") + "\" href=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ResetSearchBtn") + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ResetSearch") + "\" data-caption=\"" + Language.Phrase("ResetSearch") + "\" data-ew-action=\"refresh\" data-url=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ResetSearchBtn") + "</a>";
            item.Visible = (SearchWhere != DefaultSearchWhere && SearchWhere != "0=101");

            // Advanced search button
            item = SearchOptions.Add("advancedsearch");
            if (ModalSearch && !IsMobile())
                item.Body = "<a class=\"btn btn-default ew-advanced-search\" title=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-table=\"tblAssessment\" data-caption=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-ew-action=\"modal\" data-url=\"" + AppPath("TblAssessmentSearch") + "\" data-btn=\"SearchBtn\">" + Language.Phrase("AdvancedSearch", false) + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-advanced-search\" title=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-caption=\"" + Language.Phrase("AdvancedSearch", true) + "\" href=\"" + AppPath("TblAssessmentSearch") + "\">" + Language.Phrase("AdvancedSearch", false) + "</a>";
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
            if (Config.ExportMasterRecord && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblStudents") {
                tblStudents = new TblStudentsList();
                if (tblStudents != null) {
                    var c = await GetConnection2Async(tblStudents.DbId); // Note: Use new connection for master record // DN
                    using var rsmaster = await tblStudents.LoadReader(DbMasterFilter, "", c); // Load master record
                    if (rsmaster?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("v"); // Change to vertical
                        if (!IsExport("csv") || Config.ExportMasterRecordForCsv) {
                            doc.Table = tblStudents;
                            await tblStudents.ExportDocument(doc, rsmaster, 1, 1);
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
                if (masterTblVar == "tblStudents") {
                    validMaster = true;
                    if (tblStudents != null && (Get("fk_str_Username", out fk) || Get("str_Username", out fk))) {
                        tblStudents.str_Username.QueryValue = fk;
                        str_Username.QueryValue = tblStudents.str_Username.QueryValue;
                        str_Username.SessionValue = str_Username.QueryValue;
                        foreignKeys.Add("str_Username", fk);
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
                if (masterTblVar == "tblStudents") {
                    validMaster = true;
                    if (tblStudents != null && (Post("fk_str_Username", out fk) || Post("str_Username", out fk))) {
                        tblStudents.str_Username.FormValue = fk;
                        str_Username.FormValue = tblStudents.str_Username.FormValue;
                        str_Username.SessionValue = str_Username.FormValue;
                        foreignKeys.Add("str_Username", fk);
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
                if (masterTblVar != "tblStudents") {
                    if (!foreignKeys.ContainsKey("str_Username")) // Not current foreign key
                        str_Username.SessionValue = "";
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
                // Set up lookup SQL
                switch (fld.FieldVar) {
                    case "x_str_Full_Name_Hdr":
                        lookupFilter = () => fld.GetSelectFilter();
                        break;
                }

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
