namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAssessmentGrid
    /// </summary>
    public static TblAssessmentGrid tblAssessmentGrid
    {
        get => HttpData.Get<TblAssessmentGrid>("tblAssessmentGrid")!;
        set => HttpData["tblAssessmentGrid"] = value;
    }

    /// <summary>
    /// Page class for tblAssessment
    /// </summary>
    public class TblAssessmentGrid : TblAssessmentGridBase
    {
        // Constructor
        public TblAssessmentGrid() : base()
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
    public class TblAssessmentGridBase : TblAssessment
    {
        // Page ID
        public string PageID = "grid";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAssessment";

        // Page object name
        public string PageObjName = "tblAssessmentGrid";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblAssessmentgrid";

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
        public TblAssessmentGridBase()
        {
            // CSS class name as context
            TableVar = "tblAssessment";
            ContextClass = CheckClassName(TableVar);
            TableGridClass = AppendClass(TableGridClass, ContextClass);
            FormActionName = Config.FormRowActionName;
            FormBlankRowName = Config.FormBlankRowName;
            FormKeyCountName = Config.FormKeyCountName;

            // Initialize
            FormActionName += "_" + FormName;
            OldKeyName += "_" + FormName;
            FormBlankRowName += "_" + FormName;
            FormKeyCountName += "_" + FormName;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-table";

            // CSS class name as context
            ContextClass = CheckClassName(TableVar);
            TableGridClass = AppendClass(TableGridClass, ContextClass);

            // Language object
            Language = ResolveLanguage();
            AddUrl = "TblAssessmentAdd";

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
        public string PageName => "TblAssessmentGrid";

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

        /// <summary>
        /// Terminate page
        /// </summary>
        /// <param name="url">URL to rediect to</param>
        /// <returns>Page result</returns>
        public override IActionResult Terminate(string url = "") { // DN
            if (_terminated) // DN
                return new EmptyResult();
            if (Empty(url))
                return new EmptyResult();
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

        #pragma warning disable 169

        public bool ShowOtherOptions = false;

        private DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType>? _connection;
        #pragma warning restore 169

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

        public string MultiColumnGridClass = "row-cols-md";

        public string MultiColumnEditClass = "col-12 w-100";

        public string MultiColumnCardClass = "card h-100 ew-card";

        public string MultiColumnListOptionsPosition = "bottom-start";

        public string DbMasterFilter = ""; // Master filter

        public string DbDetailFilter = ""; // Detail filter

        public bool MasterRecordExists;

        public string MultiSelectKey = "";

        public string UserAction = ""; // User action

        public bool RestoreSearch = false;

        public SubPages? DetailPages; // Detail pages object

        public DbDataReader? Recordset;

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

        #pragma warning disable 618
        // Connection
        public override DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType> Connection
        {
            get {
                _connection ??= GetConnection2(DbId);
                return _connection;
            }
        }
        #pragma warning restore 618

        /// <summary>
        /// Load recordset from filter
        /// <param name="filter">Record filter</param>
        /// </summary>
        public async Task LoadRecordsetFromFilter(string filter)
        {
            // Set up list options
            await SetupListOptions();

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

            // Get grid add count
            int gridaddcnt = Get<int>(Config.TableGridAddRowCount);
            if (gridaddcnt > 0)
                GridAddRowCount = gridaddcnt;

            // Set up list options
            await SetupListOptions();
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

            // Set up lookup cache
            await SetupLookupOptions(str_Full_Name_Hdr);
            await SetupLookupOptions(NationalID);
            await SetupLookupOptions(Assessment_Type);
            await SetupLookupOptions(isAssessmentDone);
            await SetupLookupOptions(Assessment_Instructor);
            await SetupLookupOptions(IsDrivingexperience);
            await SetupLookupOptions(AccidentOccurrence);

            // Load default values for add
            LoadDefaultValues();

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

            // Set up records per page
            SetupDisplayRecords();

            // Handle reset command
            ResetCommand();

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

            // Show grid delete link for grid add / grid edit
            if (AllowAddDeleteRow) {
                if (IsGridAdd || IsGridEdit) {
                    var item = ListOptions["griddelete"];
                    if (item != null)
                        item.Visible = false;
                }
            }

            // Set up sorting order
            SetupSortOrder();

            // Restore display records
            if (Command != "json" && (RecordsPerPage == -1 || RecordsPerPage > 0)) {
                DisplayRecords = RecordsPerPage; // Restore from Session
            } else {
                DisplayRecords = 20; // Load default
                RecordsPerPage = DisplayRecords; // Save default to session
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
                if (CurrentMode == "copy") {
                    TotalRecords = await ListRecordCountAsync();
                    Recordset = await LoadRecordset(StartRecord - 1, TotalRecords);
                    StartRecord = 1;
                    DisplayRecords = TotalRecords;
                } else {
                    CurrentFilter = "0=1";
                    StartRecord = 1;
                    DisplayRecords = GridAddRowCount;
                }
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
                DisplayRecords = TotalRecords; // Display all records

                // Recordset
                bool selectLimit = UseSelectLimit;
                if (selectLimit)
                    Recordset = await LoadRecordset(StartRecord - 1, DisplayRecords);
            }

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
                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                tblAssessmentGrid?.PageRender();
            }
            return new EmptyResult();
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

        // Switch to grid add mode
        protected void GridAddMode() {
            CurrentAction = "gridadd";
            Session[Config.SessionInlineMode] = "gridadd"; // Enabled grid add
            HideFieldsForAddEdit();
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
                FilterForModalActions = wrkFilter;

                // Get new recordset
                List<Dictionary<string, object>> rsnew = await Connection.GetRowsAsync(sql, true); // Use main connection (faster) // DN

                // Call Grid Updated event
                GridUpdated(rsold, rsnew);
                if (AuditTrailOnEdit)
                    await WriteAuditTrailLog(Language.Phrase("BatchUpdateSuccess")); // Batch update success
                ClearInlineMode(); // Clear inline edit mode

                // Send notify email
                string table = "tblAssessment";
                string subject = table + " " + Language.Phrase("RecordUpdated");
                string action = Language.Phrase("ActionUpdatedGridEdit");
                var email = new Email();
                await email.Load(Config.EmailNotifyTemplate);
                email.ReplaceSender(Config.SenderEmail); // Replace Sender
                email.ReplaceRecipient(Config.RecipientEmail); // Replace Recipient
                email.ReplaceSubject(subject); // Replace Subject
                email.ReplaceContent("<!--table-->", table);
                email.ReplaceContent("<!--key-->", key);
                email.ReplaceContent("<!--action-->", action);
                bool emailSent = false;
                if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsold = rsold, rsnew = rsnew })))
                    emailSent = await email.SendAsync();

                // Set up error message
                if (!emailSent)
                    FailureMessage = email.SendError;
            } else {
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
                            key += ConvertToString(AssessmentID.CurrentValue);

                            // Add filter for this record
                            AddFilter(ref wrkFilter, GetRecordFilter(), "OR");
                        } else {
                            EventCancelled = true;
                            break;
                        }
                    }
                }
                if (addcnt == 0) { // No record inserted
                    ClearInlineMode(); // Clear grid add mode and return
                    return true;
                }
            } catch (Exception e) {
                FailureMessage = e.Message;
                gridInsert = false;
            }
            if (gridInsert) {
                // Get new recordset
                CurrentFilter = wrkFilter;
                FilterForModalActions = wrkFilter;
                string sql = CurrentSql;
                List<Dictionary<string, object>> rsnew = await Connection.GetRowsAsync(sql, true); // Use main connection (faster) // DN

                // Call Grid Inserted event
                GridInserted(rsnew);
                if (AuditTrailOnAdd)
                    await WriteAuditTrailLog(Language.Phrase("BatchInsertSuccess")); // Batch insert success
                ClearInlineMode(); // Clear grid add mode
            } else {
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
            if (CurrentForm.HasValue("x_str_First_Name") && CurrentForm.HasValue("o_str_First_Name") && !SameString(str_First_Name.CurrentValue, str_First_Name.DefaultValue) &&
            !(str_First_Name.IsForeignKey && CurrentMasterTable != "" && SameString(str_First_Name.CurrentValue, str_First_Name.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Middle_Name") && CurrentForm.HasValue("o_str_Middle_Name") && !SameString(str_Middle_Name.CurrentValue, str_Middle_Name.DefaultValue) &&
            !(str_Middle_Name.IsForeignKey && CurrentMasterTable != "" && SameString(str_Middle_Name.CurrentValue, str_Middle_Name.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Last_Name") && CurrentForm.HasValue("o_str_Last_Name") && !SameString(str_Last_Name.CurrentValue, str_Last_Name.DefaultValue) &&
            !(str_Last_Name.IsForeignKey && CurrentMasterTable != "" && SameString(str_Last_Name.CurrentValue, str_Last_Name.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Username") && CurrentForm.HasValue("o_str_Username") && !SameString(str_Username.CurrentValue, str_Username.DefaultValue) &&
            !(str_Username.IsForeignKey && CurrentMasterTable != "" && SameString(str_Username.CurrentValue, str_Username.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_Assessment_Type") && CurrentForm.HasValue("o_Assessment_Type") && !SameString(Assessment_Type.CurrentValue, Assessment_Type.DefaultValue) &&
            !(Assessment_Type.IsForeignKey && CurrentMasterTable != "" && SameString(Assessment_Type.CurrentValue, Assessment_Type.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_AssessmentDate") && CurrentForm.HasValue("o_AssessmentDate") && !SameString(FormatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern), FormatDateTime(AssessmentDate.DefaultValue, AssessmentDate.FormatPattern)) &&
            !(AssessmentDate.IsForeignKey && CurrentMasterTable != "" && SameString(FormatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern), FormatDateTime(AssessmentDate.SessionValue, AssessmentDate.FormatPattern))))
                return false;
            if (CurrentForm.HasValue("x_isAssessmentDone") && CurrentForm.HasValue("o_isAssessmentDone") && !SameString(isAssessmentDone.CurrentValue, isAssessmentDone.DefaultValue) &&
            !(isAssessmentDone.IsForeignKey && CurrentMasterTable != "" && SameString(isAssessmentDone.CurrentValue, isAssessmentDone.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_AssessmentScore") && CurrentForm.HasValue("o_AssessmentScore") && !SameString(AssessmentScore.CurrentValue, AssessmentScore.DefaultValue) &&
            !(AssessmentScore.IsForeignKey && CurrentMasterTable != "" && SameString(AssessmentScore.CurrentValue, AssessmentScore.SessionValue)))
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
            str_First_Name.ClearErrorMessage();
            str_Middle_Name.ClearErrorMessage();
            str_Last_Name.ClearErrorMessage();
            str_Username.ClearErrorMessage();
            Assessment_Type.ClearErrorMessage();
            AssessmentDate.ClearErrorMessage();
            isAssessmentDone.ClearErrorMessage();
            AssessmentScore.ClearErrorMessage();
        }

        // Set up sort parameters
        protected void SetupSortOrder() {
            // Load default Sorting Order
            if (Command != "json") {
                string defaultSort = ""; // Set up default sort
                if (Empty(SessionOrderBy) && !Empty(defaultSort))
                    SessionOrderBy = defaultSort;
            }

            // Check for "order" parameter
            if (Get("order", out StringValues sv)) {
                CurrentOrder = sv.ToString();
                CurrentOrderType = Get("ordertype");
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

            // "griddelete"
            if (AllowAddDeleteRow) {
                item = ListOptions.Add("griddelete");
                item.CssClass = "text-nowrap";
                item.OnLeft = true;
                item.Visible = false; // Default hidden
            }

            // Add group option item
            item = ListOptions.AddGroupOption();
            item.Body = "";
            item.OnLeft = true;
            item.Visible = false;

            // "view"
            item = ListOptions.Add("view");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanView;
            item.OnLeft = true;

            // "edit"
            item = ListOptions.Add("edit");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanEdit;
            item.OnLeft = true;

            // Drop down button for ListOptions
            ListOptions.UseDropDownButton = false;
            ListOptions.DropDownButtonPhrase = "ButtonListOptions";
            ListOptions.UseButtonGroup = false;
            if (ListOptions.UseButtonGroup && IsMobile())
                ListOptions.UseDropDownButton = true;

            //ListOptions.ButtonClass = ""; // Class for button group
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
                if (CurrentMode == "add" || CurrentMode == "copy" || CurrentMode == "edit") {
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
            if (CurrentMode == "view") {
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
            } // End View mode
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
                option.OnLeft = true;
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
            option = OtherOptions["addedit"];
            option.UseDropDownButton = false;
            option.DropDownButtonPhrase = "ButtonAddEdit";
            option.UseButtonGroup = true;
            option.ButtonClass = ""; // Class for button group
            item = option.AddGroupOption();
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
                if ((CurrentMode == "add" || CurrentMode == "copy" || CurrentMode == "edit") && !IsConfirm) { // Check add/copy/edit mode
                    if (AllowAddDeleteRow) {
                        option = options["addedit"];
                        option.UseDropDownButton = false;
                        item = option.Add("addblankrow");
                        item.Body = "<a class=\"ew-add-edit ew-add-blank-row\" title=\"" + Language.Phrase("AddBlankRow", true) + "\" data-caption=\"" + Language.Phrase("AddBlankRow", true) + "\" data-ew-action=\"add-grid-row\">" + Language.Phrase("AddBlankRow") + "</a>";
                        item.Visible = false;
                        ShowOtherOptions = item.Visible;
                    }
                }
                if (CurrentMode == "view") { // Check view mode
                    option = options["addedit"];
                    item = option.GetItem("add");
                    ShowOtherOptions = !Empty(item) && item.Visible;
                }
        }

        // Set up Grid
        public async Task SetupGrid()
        {
            StartRecord = 1;
            StopRecord = TotalRecords; // Show all records

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
            if ((IsGridAdd || IsGridEdit)) // Render template row first
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
            if (IsGridAdd) {
                if (CurrentMode == "copy") {
                    await LoadRowValues(Recordset); // Load row values
                    OldKey = GetKey(true); // Get from CurrentValue
                } else {
                    await LoadRowValues(); // Load default values
                    OldKey = "";
                }
            } else {
                await LoadRowValues(Recordset); // Load row values
                OldKey = GetKey(true); // Get from CurrentValue
            }
            SetKey(OldKey);
            RowType = RowType.View; // Render view
            if ((IsAdd || IsCopy) && InlineRowCount == 0 || IsGridAdd) // Add
                RowType = RowType.Add; // Render add
            if (IsGridAdd && EventCancelled && !CurrentForm!.HasValue(FormBlankRowName)) // Insert failed
                await RestoreCurrentRowFormValues(RowIndex); // Restore form values
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
            if (IsConfirm) // Confirm row
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblAssessmentGrid.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblAssessmentGrid.RowCount) + "_tblAssessment");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblAssessmentGrid.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblAssessmentGrid.RowType == RowType.Add || IsEdit && tblAssessmentGrid.RowType == RowType.Edit) // Inline-Add/Edit row
                RowAttrs.AppendClass("table-active");

            // Render row
            await RenderRow();

            // Render list options
            await RenderListOptions();
        }

        // Confirm page
        public bool ConfirmPage = false; // DN

        #pragma warning disable 1998
        // Get upload files
        public async Task GetUploadFiles()
        {
            // Get upload data
        }
        #pragma warning restore 1998

        // Load default values
        protected void LoadDefaultValues() {
            str_Username.DefaultValue = CurrentUserID();
            str_Username.OldValue = str_Username.DefaultValue;
            Absherphoto.Upload.Index = ConvertToInt(RowIndex);
            DriveTypelink.DefaultValue = DriveTypelink.GetDefault(); // DN
            DriveTypelink.OldValue = DriveTypelink.DefaultValue;
            Calendar_ID.DefaultValue = Calendar_ID.GetDefault(); // DN
            Calendar_ID.OldValue = Calendar_ID.DefaultValue;
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            CurrentForm.FormName = FormName;
            bool validate = !Config.ServerValidate;
            string val;

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

            // Check field name 'str_Middle_Name' before field var 'x_str_Middle_Name'
            val = CurrentForm.HasValue("str_Middle_Name") ? CurrentForm.GetValue("str_Middle_Name") : CurrentForm.GetValue("x_str_Middle_Name");
            if (!str_Middle_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Middle_Name") && !CurrentForm.HasValue("x_str_Middle_Name")) // DN
                    str_Middle_Name.Visible = false; // Disable update for API request
                else
                    str_Middle_Name.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_Middle_Name"))
                str_Middle_Name.OldValue = CurrentForm.GetValue("o_str_Middle_Name");

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

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_Username"))
                str_Username.OldValue = CurrentForm.GetValue("o_str_Username");

            // Check field name 'Assessment_Type' before field var 'x_Assessment_Type'
            val = CurrentForm.HasValue("Assessment_Type") ? CurrentForm.GetValue("Assessment_Type") : CurrentForm.GetValue("x_Assessment_Type");
            if (!Assessment_Type.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Assessment_Type") && !CurrentForm.HasValue("x_Assessment_Type")) // DN
                    Assessment_Type.Visible = false; // Disable update for API request
                else
                    Assessment_Type.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_Assessment_Type"))
                Assessment_Type.OldValue = CurrentForm.GetValue("o_Assessment_Type");

            // Check field name 'AssessmentDate' before field var 'x_AssessmentDate'
            val = CurrentForm.HasValue("AssessmentDate") ? CurrentForm.GetValue("AssessmentDate") : CurrentForm.GetValue("x_AssessmentDate");
            if (!AssessmentDate.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AssessmentDate") && !CurrentForm.HasValue("x_AssessmentDate")) // DN
                    AssessmentDate.Visible = false; // Disable update for API request
                else
                    AssessmentDate.SetFormValue(val, true, validate);
                AssessmentDate.CurrentValue = UnformatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern);
            }
            AssessmentDate.OldValue = UnformatDateTime(CurrentForm.GetValue("o_AssessmentDate"), AssessmentDate.FormatPattern);

            // Check field name 'isAssessmentDone' before field var 'x_isAssessmentDone'
            val = CurrentForm.HasValue("isAssessmentDone") ? CurrentForm.GetValue("isAssessmentDone") : CurrentForm.GetValue("x_isAssessmentDone");
            if (!isAssessmentDone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("isAssessmentDone") && !CurrentForm.HasValue("x_isAssessmentDone")) // DN
                    isAssessmentDone.Visible = false; // Disable update for API request
                else
                    isAssessmentDone.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_isAssessmentDone"))
                isAssessmentDone.OldValue = CurrentForm.GetValue("o_isAssessmentDone");

            // Check field name 'AssessmentScore' before field var 'x_AssessmentScore'
            val = CurrentForm.HasValue("AssessmentScore") ? CurrentForm.GetValue("AssessmentScore") : CurrentForm.GetValue("x_AssessmentScore");
            if (!AssessmentScore.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AssessmentScore") && !CurrentForm.HasValue("x_AssessmentScore")) // DN
                    AssessmentScore.Visible = false; // Disable update for API request
                else
                    AssessmentScore.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_AssessmentScore"))
                AssessmentScore.OldValue = CurrentForm.GetValue("o_AssessmentScore");

            // Check field name 'AssessmentID' before field var 'x_AssessmentID'
            val = CurrentForm.HasValue("AssessmentID") ? CurrentForm.GetValue("AssessmentID") : CurrentForm.GetValue("x_AssessmentID");
            if (!AssessmentID.IsDetailKey && !IsGridAdd && !IsAdd)
                AssessmentID.SetFormValue(val);
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            if (!IsGridAdd && !IsAdd)
                AssessmentID.CurrentValue = AssessmentID.FormValue;
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Middle_Name.CurrentValue = str_Middle_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            Assessment_Type.CurrentValue = Assessment_Type.FormValue;
            AssessmentDate.CurrentValue = AssessmentDate.FormValue;
            AssessmentDate.CurrentValue = UnformatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern);
            isAssessmentDone.CurrentValue = isAssessmentDone.FormValue;
            AssessmentScore.CurrentValue = AssessmentScore.FormValue;
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
            Absherphoto.Upload.Index = ConvertToInt(RowIndex);
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
            } else if (RowType == RowType.Add) {
                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.CurrentValue = HtmlDecode(str_First_Name.CurrentValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.CurrentValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Middle_Name
                str_Middle_Name.SetupEditAttributes();
                if (!str_Middle_Name.Raw)
                    str_Middle_Name.CurrentValue = HtmlDecode(str_Middle_Name.CurrentValue);
                str_Middle_Name.EditValue = HtmlEncode(str_Middle_Name.CurrentValue);
                str_Middle_Name.PlaceHolder = RemoveHtml(str_Middle_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.CurrentValue = HtmlDecode(str_Last_Name.CurrentValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.CurrentValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!Empty(str_Username.SessionValue)) {
                    str_Username.CurrentValue = ForeignKeyValue(str_Username.SessionValue);
                    str_Username.OldValue = str_Username.CurrentValue;
                    str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                    str_Username.ViewCustomAttributes = "";
                } else if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("grid")) { // Non system admin
                    str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
                } else {
                    if (!str_Username.Raw)
                        str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                    str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                    str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
                }

                // Assessment_Type
                Assessment_Type.SetupEditAttributes();
                Assessment_Type.EditValue = Assessment_Type.Options(true);
                Assessment_Type.PlaceHolder = RemoveHtml(Assessment_Type.Caption);

                // AssessmentDate
                AssessmentDate.SetupEditAttributes();
                AssessmentDate.EditValue = FormatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern); // DN
                AssessmentDate.PlaceHolder = RemoveHtml(AssessmentDate.Caption);

                // isAssessmentDone
                isAssessmentDone.EditValue = isAssessmentDone.Options(false);
                isAssessmentDone.PlaceHolder = RemoveHtml(isAssessmentDone.Caption);

                // AssessmentScore
                AssessmentScore.SetupEditAttributes();
                if (!AssessmentScore.Raw)
                    AssessmentScore.CurrentValue = HtmlDecode(AssessmentScore.CurrentValue);
                AssessmentScore.EditValue = HtmlEncode(AssessmentScore.CurrentValue);
                AssessmentScore.PlaceHolder = RemoveHtml(AssessmentScore.Caption);

                // Add refer script

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // Assessment_Type
                Assessment_Type.HrefValue = "";

                // AssessmentDate
                AssessmentDate.HrefValue = "";

                // isAssessmentDone
                isAssessmentDone.HrefValue = "";

                // AssessmentScore
                AssessmentScore.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.CurrentValue = HtmlDecode(str_First_Name.CurrentValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.CurrentValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Middle_Name
                str_Middle_Name.SetupEditAttributes();
                if (!str_Middle_Name.Raw)
                    str_Middle_Name.CurrentValue = HtmlDecode(str_Middle_Name.CurrentValue);
                str_Middle_Name.EditValue = HtmlEncode(str_Middle_Name.CurrentValue);
                str_Middle_Name.PlaceHolder = RemoveHtml(str_Middle_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.CurrentValue = HtmlDecode(str_Last_Name.CurrentValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.CurrentValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!Empty(str_Username.SessionValue)) {
                    str_Username.CurrentValue = ForeignKeyValue(str_Username.SessionValue);
                    str_Username.OldValue = str_Username.CurrentValue;
                    str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                    str_Username.ViewCustomAttributes = "";
                } else if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("grid")) { // Non system admin
                    str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
                } else {
                    if (!str_Username.Raw)
                        str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                    str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                    str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
                }

                // Assessment_Type
                Assessment_Type.SetupEditAttributes();
                Assessment_Type.EditValue = Assessment_Type.Options(true);
                Assessment_Type.PlaceHolder = RemoveHtml(Assessment_Type.Caption);

                // AssessmentDate
                AssessmentDate.SetupEditAttributes();
                AssessmentDate.EditValue = FormatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern); // DN
                AssessmentDate.PlaceHolder = RemoveHtml(AssessmentDate.Caption);

                // isAssessmentDone
                isAssessmentDone.EditValue = isAssessmentDone.Options(false);
                isAssessmentDone.PlaceHolder = RemoveHtml(isAssessmentDone.Caption);

                // AssessmentScore
                AssessmentScore.SetupEditAttributes();
                AssessmentScore.EditValue = ConvertToString(AssessmentScore.CurrentValue); // DN
                AssessmentScore.ViewCustomAttributes = "";

                // Edit refer script

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // Assessment_Type
                Assessment_Type.HrefValue = "";

                // AssessmentDate
                AssessmentDate.HrefValue = "";

                // isAssessmentDone
                isAssessmentDone.HrefValue = "";

                // AssessmentScore
                AssessmentScore.HrefValue = "";
                AssessmentScore.TooltipValue = "";
            }
            if (RowType == RowType.Add || RowType == RowType.Edit || RowType == RowType.Search) // Add/Edit/Search row
                SetupFieldTitles();

            // Call Row Rendered event
            if (RowType != RowType.AggregateInit)
                RowRendered();
        }
        #pragma warning restore 1998

        #pragma warning disable 1998
        // Validate form
        protected async Task<bool> ValidateForm() {
            // Check if validation required
            if (!Config.ServerValidate)
                return true;
            bool validateForm = true;
            if (str_First_Name.Required) {
                if (!str_First_Name.IsDetailKey && Empty(str_First_Name.FormValue)) {
                    str_First_Name.AddErrorMessage(ConvertToString(str_First_Name.RequiredErrorMessage).Replace("%s", str_First_Name.Caption));
                }
            }
            if (str_Middle_Name.Required) {
                if (!str_Middle_Name.IsDetailKey && Empty(str_Middle_Name.FormValue)) {
                    str_Middle_Name.AddErrorMessage(ConvertToString(str_Middle_Name.RequiredErrorMessage).Replace("%s", str_Middle_Name.Caption));
                }
            }
            if (str_Last_Name.Required) {
                if (!str_Last_Name.IsDetailKey && Empty(str_Last_Name.FormValue)) {
                    str_Last_Name.AddErrorMessage(ConvertToString(str_Last_Name.RequiredErrorMessage).Replace("%s", str_Last_Name.Caption));
                }
            }
            if (str_Username.Required) {
                if (!str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (Assessment_Type.Required) {
                if (!Assessment_Type.IsDetailKey && Empty(Assessment_Type.FormValue)) {
                    Assessment_Type.AddErrorMessage(ConvertToString(Assessment_Type.RequiredErrorMessage).Replace("%s", Assessment_Type.Caption));
                }
            }
            if (AssessmentDate.Required) {
                if (!AssessmentDate.IsDetailKey && Empty(AssessmentDate.FormValue)) {
                    AssessmentDate.AddErrorMessage(ConvertToString(AssessmentDate.RequiredErrorMessage).Replace("%s", AssessmentDate.Caption));
                }
            }
            if (!CheckDate(AssessmentDate.FormValue, AssessmentDate.FormatPattern)) {
                AssessmentDate.AddErrorMessage(AssessmentDate.GetErrorMessage(false));
            }
            if (isAssessmentDone.Required) {
                if (Empty(isAssessmentDone.FormValue)) {
                    isAssessmentDone.AddErrorMessage(ConvertToString(isAssessmentDone.RequiredErrorMessage).Replace("%s", isAssessmentDone.Caption));
                }
            }
            if (AssessmentScore.Required) {
                if (!AssessmentScore.IsDetailKey && Empty(AssessmentScore.FormValue)) {
                    AssessmentScore.AddErrorMessage(ConvertToString(AssessmentScore.RequiredErrorMessage).Replace("%s", AssessmentScore.Caption));
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

            // str_First_Name
            str_First_Name.SetDbValue(rsnew, str_First_Name.CurrentValue, str_First_Name.ReadOnly);

            // str_Middle_Name
            str_Middle_Name.SetDbValue(rsnew, str_Middle_Name.CurrentValue, str_Middle_Name.ReadOnly);

            // str_Last_Name
            str_Last_Name.SetDbValue(rsnew, str_Last_Name.CurrentValue, str_Last_Name.ReadOnly);

            // str_Username
            if (!Empty(str_Username.SessionValue))
                str_Username.ReadOnly = true;
            str_Username.SetDbValue(rsnew, str_Username.CurrentValue, str_Username.ReadOnly);

            // Assessment_Type
            Assessment_Type.SetDbValue(rsnew, Assessment_Type.CurrentValue, Assessment_Type.ReadOnly);

            // AssessmentDate
            AssessmentDate.SetDbValue(rsnew, ConvertToDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern), AssessmentDate.ReadOnly);

            // isAssessmentDone
            isAssessmentDone.SetDbValue(rsnew, isAssessmentDone.CurrentValue, isAssessmentDone.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);
            bool validMasterRecord;
            object keyValue;
            object? v;
            string? masterFilter;
            Dictionary<string, object?> detailKeys;

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

        // Add record
        #pragma warning disable 168, 219

        protected async Task<JsonBoolResult> AddRow(Dictionary<string, object>? rsold = null) { // DN
            bool result = false;

            // Set up foreign key field value from Session
            if (CurrentMasterTable == "tblStudents") {
                str_Username.CurrentValue = str_Username.SessionValue;
            }

            // Set new row
            Dictionary<string, object> rsnew = new ();
            try {
                // str_First_Name
                str_First_Name.SetDbValue(rsnew, str_First_Name.CurrentValue);

                // str_Middle_Name
                str_Middle_Name.SetDbValue(rsnew, str_Middle_Name.CurrentValue);

                // str_Last_Name
                str_Last_Name.SetDbValue(rsnew, str_Last_Name.CurrentValue);

                // str_Username
                str_Username.SetDbValue(rsnew, str_Username.CurrentValue);

                // Assessment_Type
                Assessment_Type.SetDbValue(rsnew, Assessment_Type.CurrentValue);

                // AssessmentDate
                AssessmentDate.SetDbValue(rsnew, ConvertToDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern));

                // isAssessmentDone
                isAssessmentDone.SetDbValue(rsnew, isAssessmentDone.CurrentValue, Empty(isAssessmentDone.CurrentValue));

                // AssessmentScore
                AssessmentScore.SetDbValue(rsnew, AssessmentScore.CurrentValue);
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
            bool validMasterRecord;

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
                    rsnew["AssessmentID"] = AssessmentID.CurrentValue!;
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

        // Show link optionally based on User ID
        protected bool ShowOptionLink(string pageId = "") { // DN
            if (Security.IsLoggedIn && !Security.IsAdmin && !UserIDAllow(pageId))
                return Security.IsValidUserID(str_Username.CurrentValue);
            return true;
        }

        // Set up master/detail based on QueryString
        protected void SetupMasterParms() {
            // Hide foreign keys
            string masterTblVar = CurrentMasterTable;
            if (masterTblVar == "tblStudents") {
                str_Username.Visible = false;

                //if (tblStudents.EventCancelled) EventCancelled = true;
                if (Get<bool>("mastereventcancelled"))
                    EventCancelled = true;
            }
            DbMasterFilter = MasterFilterFromSession; // Get master filter from session
            DbDetailFilter = DetailFilterFromSession; // Get detail filter from session
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
