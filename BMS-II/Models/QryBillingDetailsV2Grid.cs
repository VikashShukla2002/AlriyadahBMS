namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// qryBillingDetailsV2Grid
    /// </summary>
    public static QryBillingDetailsV2Grid qryBillingDetailsV2Grid
    {
        get => HttpData.Get<QryBillingDetailsV2Grid>("qryBillingDetailsV2Grid")!;
        set => HttpData["qryBillingDetailsV2Grid"] = value;
    }

    /// <summary>
    /// Page class for qryBillingDetails_v2
    /// </summary>
    public class QryBillingDetailsV2Grid : QryBillingDetailsV2GridBase
    {
        // Constructor
        public QryBillingDetailsV2Grid() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class QryBillingDetailsV2GridBase : QryBillingDetailsV2
    {
        // Page ID
        public string PageID = "grid";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "qryBillingDetails_v2";

        // Page object name
        public string PageObjName = "qryBillingDetailsV2Grid";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "fqryBillingDetails_v2grid";

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
        public QryBillingDetailsV2GridBase()
        {
            // CSS class name as context
            TableVar = "qryBillingDetails_v2";
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
            AddUrl = "QryBillingDetailsV2Add";

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
        public string PageName => "QryBillingDetailsV2Grid";

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
            int_Bill_ID.Visible = false;
            Payment_Number.SetVisibility();
            str_Username.Visible = false;
            NationalID.SetVisibility();
            date_Paid.SetVisibility();
            Amount_Paid.SetVisibility();
            running_payments.SetVisibility();
            running_balance.SetVisibility();
            date_Created.Visible = false;
            date_Modified.Visible = false;
            str_ApprovalCode.SetVisibility();
            Package_Name.SetVisibility();
            int_Package_ID.SetVisibility();
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Bill_ID") ? dict["int_Bill_ID"] : int_Bill_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Bill_ID.Visible = false;
            if (IsAddOrEdit)
                Payment_Number.Visible = false;
            if (IsAddOrEdit)
                Amount_Paid.Visible = false;
            if (IsAddOrEdit)
                running_payments.Visible = false;
            if (IsAddOrEdit)
                running_balance.Visible = false;
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

            // Load default values for add
            LoadDefaultValues();

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "fqryBillingDetails_v2grid";

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
                qryBillingDetailsV2Grid?.PageRender();
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
            Amount_Paid.SetFormValue("", false); // Clear form value
            running_payments.SetFormValue("", false); // Clear form value
            running_balance.SetFormValue("", false); // Clear form value
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
                ClearInlineMode(); // Clear inline edit mode
            } else {
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
                ClearInlineMode(); // Clear grid add mode
            } else {
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
            if (CurrentForm.HasValue("x_Payment_Number") && CurrentForm.HasValue("o_Payment_Number") && !SameString(Payment_Number.CurrentValue, Payment_Number.DefaultValue) &&
            !(Payment_Number.IsForeignKey && CurrentMasterTable != "" && SameString(Payment_Number.CurrentValue, Payment_Number.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_NationalID") && CurrentForm.HasValue("o_NationalID") && !SameString(NationalID.CurrentValue, NationalID.DefaultValue) &&
            !(NationalID.IsForeignKey && CurrentMasterTable != "" && SameString(NationalID.CurrentValue, NationalID.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_date_Paid") && CurrentForm.HasValue("o_date_Paid") && !SameString(FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), FormatDateTime(date_Paid.DefaultValue, date_Paid.FormatPattern)) &&
            !(date_Paid.IsForeignKey && CurrentMasterTable != "" && SameString(FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), FormatDateTime(date_Paid.SessionValue, date_Paid.FormatPattern))))
                return false;
            if (CurrentForm.HasValue("x_Amount_Paid") && CurrentForm.HasValue("o_Amount_Paid") && !SameString(Amount_Paid.CurrentValue, Amount_Paid.DefaultValue) &&
            !(Amount_Paid.IsForeignKey && CurrentMasterTable != "" && SameString(Amount_Paid.CurrentValue, Amount_Paid.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_running_payments") && CurrentForm.HasValue("o_running_payments") && !SameString(running_payments.CurrentValue, running_payments.DefaultValue) &&
            !(running_payments.IsForeignKey && CurrentMasterTable != "" && SameString(running_payments.CurrentValue, running_payments.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_running_balance") && CurrentForm.HasValue("o_running_balance") && !SameString(running_balance.CurrentValue, running_balance.DefaultValue) &&
            !(running_balance.IsForeignKey && CurrentMasterTable != "" && SameString(running_balance.CurrentValue, running_balance.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_ApprovalCode") && CurrentForm.HasValue("o_str_ApprovalCode") && !SameString(str_ApprovalCode.CurrentValue, str_ApprovalCode.DefaultValue) &&
            !(str_ApprovalCode.IsForeignKey && CurrentMasterTable != "" && SameString(str_ApprovalCode.CurrentValue, str_ApprovalCode.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_Package_Name") && CurrentForm.HasValue("o_Package_Name") && !SameString(Package_Name.CurrentValue, Package_Name.DefaultValue) &&
            !(Package_Name.IsForeignKey && CurrentMasterTable != "" && SameString(Package_Name.CurrentValue, Package_Name.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_int_Package_ID") && CurrentForm.HasValue("o_int_Package_ID") && !SameString(int_Package_ID.CurrentValue, int_Package_ID.DefaultValue) &&
            !(int_Package_ID.IsForeignKey && CurrentMasterTable != "" && SameString(int_Package_ID.CurrentValue, int_Package_ID.SessionValue)))
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
            Payment_Number.ClearErrorMessage();
            NationalID.ClearErrorMessage();
            date_Paid.ClearErrorMessage();
            Amount_Paid.ClearErrorMessage();
            running_payments.ClearErrorMessage();
            running_balance.ClearErrorMessage();
            str_ApprovalCode.ClearErrorMessage();
            Package_Name.ClearErrorMessage();
            int_Package_ID.ClearErrorMessage();
        }

        // Set up sort parameters
        protected void SetupSortOrder() {
            // Load default Sorting Order
            if (Command != "json") {
                string defaultSort = str_Username.Expression + " ASC" + ", " + Payment_Number.Expression + " ASC"; // Set up default sort
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
                    NationalID.SessionValue = "";
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
            if (CurrentMode == "view") { // View mode
            } // End View mode
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
                    RowAttrs.Add("id", "r0_qryBillingDetails_v2");
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
            RowAttrs.Add("data-rowindex", ConvertToString(qryBillingDetailsV2Grid.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(qryBillingDetailsV2Grid.RowCount) + "_qryBillingDetails_v2");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(qryBillingDetailsV2Grid.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && qryBillingDetailsV2Grid.RowType == RowType.Add || IsEdit && qryBillingDetailsV2Grid.RowType == RowType.Edit) // Inline-Add/Edit row
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
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            CurrentForm.FormName = FormName;
            bool validate = !Config.ServerValidate;
            string val;

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

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_NationalID"))
                NationalID.OldValue = CurrentForm.GetValue("o_NationalID");

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

            // Check field name 'Amount_Paid' before field var 'x_Amount_Paid'
            val = CurrentForm.HasValue("Amount_Paid") ? CurrentForm.GetValue("Amount_Paid") : CurrentForm.GetValue("x_Amount_Paid");
            if (!Amount_Paid.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Amount_Paid") && !CurrentForm.HasValue("x_Amount_Paid")) // DN
                    Amount_Paid.Visible = false; // Disable update for API request
                else
                    Amount_Paid.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_Amount_Paid"))
                Amount_Paid.OldValue = CurrentForm.GetValue("o_Amount_Paid");

            // Check field name 'running_payments' before field var 'x_running_payments'
            val = CurrentForm.HasValue("running_payments") ? CurrentForm.GetValue("running_payments") : CurrentForm.GetValue("x_running_payments");
            if (!running_payments.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("running_payments") && !CurrentForm.HasValue("x_running_payments")) // DN
                    running_payments.Visible = false; // Disable update for API request
                else
                    running_payments.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_running_payments"))
                running_payments.OldValue = CurrentForm.GetValue("o_running_payments");

            // Check field name 'running_balance' before field var 'x_running_balance'
            val = CurrentForm.HasValue("running_balance") ? CurrentForm.GetValue("running_balance") : CurrentForm.GetValue("x_running_balance");
            if (!running_balance.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("running_balance") && !CurrentForm.HasValue("x_running_balance")) // DN
                    running_balance.Visible = false; // Disable update for API request
                else
                    running_balance.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_running_balance"))
                running_balance.OldValue = CurrentForm.GetValue("o_running_balance");

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

            // Check field name 'Package_Name' before field var 'x_Package_Name'
            val = CurrentForm.HasValue("Package_Name") ? CurrentForm.GetValue("Package_Name") : CurrentForm.GetValue("x_Package_Name");
            if (!Package_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Package_Name") && !CurrentForm.HasValue("x_Package_Name")) // DN
                    Package_Name.Visible = false; // Disable update for API request
                else
                    Package_Name.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_Package_Name"))
                Package_Name.OldValue = CurrentForm.GetValue("o_Package_Name");

            // Check field name 'int_Package_ID' before field var 'x_int_Package_ID'
            val = CurrentForm.HasValue("int_Package_ID") ? CurrentForm.GetValue("int_Package_ID") : CurrentForm.GetValue("x_int_Package_ID");
            if (!int_Package_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Package_ID") && !CurrentForm.HasValue("x_int_Package_ID")) // DN
                    int_Package_ID.Visible = false; // Disable update for API request
                else
                    int_Package_ID.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_int_Package_ID"))
                int_Package_ID.OldValue = CurrentForm.GetValue("o_int_Package_ID");

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
            Payment_Number.CurrentValue = Payment_Number.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            date_Paid.CurrentValue = date_Paid.FormValue;
            date_Paid.CurrentValue = UnformatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern);
            Amount_Paid.CurrentValue = Amount_Paid.FormValue;
            running_payments.CurrentValue = running_payments.FormValue;
            running_balance.CurrentValue = running_balance.FormValue;
            str_ApprovalCode.CurrentValue = str_ApprovalCode.FormValue;
            Package_Name.CurrentValue = Package_Name.FormValue;
            int_Package_ID.CurrentValue = int_Package_ID.FormValue;
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
            Payment_Number.SetDbValue(row["Payment_Number"]);
            str_Username.SetDbValue(row["str_Username"]);
            NationalID.SetDbValue(row["NationalID"]);
            date_Paid.SetDbValue(row["date_Paid"]);
            Amount_Paid.SetDbValue(row["Amount_Paid"]);
            running_payments.SetDbValue(row["running_payments"]);
            running_balance.SetDbValue(row["running_balance"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            str_ApprovalCode.SetDbValue(row["str_ApprovalCode"]);
            Package_Name.SetDbValue(row["Package_Name"]);
            int_Package_ID.SetDbValue(row["int_Package_ID"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Bill_ID", int_Bill_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Payment_Number", Payment_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Paid", date_Paid.DefaultValue ?? DbNullValue); // DN
            row.Add("Amount_Paid", Amount_Paid.DefaultValue ?? DbNullValue); // DN
            row.Add("running_payments", running_payments.DefaultValue ?? DbNullValue); // DN
            row.Add("running_balance", running_balance.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ApprovalCode", str_ApprovalCode.DefaultValue ?? DbNullValue); // DN
            row.Add("Package_Name", Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Package_ID", int_Package_ID.DefaultValue ?? DbNullValue); // DN
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

            // Payment_Number

            // str_Username

            // NationalID

            // date_Paid

            // Amount_Paid

            // running_payments

            // running_balance

            // date_Created

            // date_Modified

            // str_ApprovalCode

            // Package_Name

            // int_Package_ID

            // View row
            if (RowType == RowType.View) {
                // int_Bill_ID
                int_Bill_ID.ViewValue = int_Bill_ID.CurrentValue;
                int_Bill_ID.ViewCustomAttributes = "";

                // Payment_Number
                Payment_Number.ViewValue = Payment_Number.CurrentValue;
                Payment_Number.ViewValue = FormatNumber(Payment_Number.ViewValue, Payment_Number.FormatPattern);
                Payment_Number.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
                NationalID.ViewCustomAttributes = "";

                // date_Paid
                date_Paid.ViewValue = date_Paid.CurrentValue;
                date_Paid.ViewValue = FormatDateTime(date_Paid.ViewValue, date_Paid.FormatPattern);
                date_Paid.ViewCustomAttributes = "";

                // Amount_Paid
                Amount_Paid.ViewValue = Amount_Paid.CurrentValue;
                Amount_Paid.ViewValue = FormatNumber(Amount_Paid.ViewValue, Amount_Paid.FormatPattern);
                Amount_Paid.ViewCustomAttributes = "";

                // running_payments
                running_payments.ViewValue = running_payments.CurrentValue;
                running_payments.ViewValue = FormatNumber(running_payments.ViewValue, running_payments.FormatPattern);
                running_payments.ViewCustomAttributes = "";

                // running_balance
                running_balance.ViewValue = running_balance.CurrentValue;
                running_balance.ViewValue = FormatNumber(running_balance.ViewValue, running_balance.FormatPattern);
                running_balance.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // date_Modified
                date_Modified.ViewValue = date_Modified.CurrentValue;
                date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
                date_Modified.ViewCustomAttributes = "";

                // str_ApprovalCode
                str_ApprovalCode.ViewValue = ConvertToString(str_ApprovalCode.CurrentValue); // DN
                str_ApprovalCode.ViewCustomAttributes = "";

                // Package_Name
                Package_Name.ViewValue = ConvertToString(Package_Name.CurrentValue); // DN
                Package_Name.ViewCustomAttributes = "";

                // int_Package_ID
                int_Package_ID.ViewValue = int_Package_ID.CurrentValue;
                int_Package_ID.ViewValue = FormatNumber(int_Package_ID.ViewValue, int_Package_ID.FormatPattern);
                int_Package_ID.ViewCustomAttributes = "";

                // Payment_Number
                Payment_Number.HrefValue = "";
                Payment_Number.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // date_Paid
                date_Paid.HrefValue = "";
                date_Paid.TooltipValue = "";

                // Amount_Paid
                Amount_Paid.HrefValue = "";
                Amount_Paid.TooltipValue = "";

                // running_payments
                running_payments.HrefValue = "";
                running_payments.TooltipValue = "";

                // running_balance
                running_balance.HrefValue = "";
                running_balance.TooltipValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";
                str_ApprovalCode.TooltipValue = "";

                // Package_Name
                Package_Name.HrefValue = "";
                Package_Name.TooltipValue = "";

                // int_Package_ID
                int_Package_ID.HrefValue = "";
                int_Package_ID.TooltipValue = "";
            } else if (RowType == RowType.Add) {
                // Payment_Number
                Payment_Number.SetupEditAttributes();
                Payment_Number.EditValue = Payment_Number.CurrentValue; // DN
                Payment_Number.PlaceHolder = RemoveHtml(Payment_Number.Caption);
                if (!Empty(Payment_Number.EditValue) && IsNumeric(Payment_Number.EditValue)) {
                    Payment_Number.EditValue = FormatNumber(Payment_Number.EditValue, null);
                }

                // NationalID
                NationalID.SetupEditAttributes();
                if (!Empty(NationalID.SessionValue)) {
                    NationalID.CurrentValue = ForeignKeyValue(NationalID.SessionValue);
                    NationalID.OldValue = NationalID.CurrentValue;
                    NationalID.ViewValue = NationalID.CurrentValue;
                    NationalID.ViewCustomAttributes = "";
                } else {
                    NationalID.EditValue = NationalID.CurrentValue; // DN
                    NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                    if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue)) {
                    }
                }

                // date_Paid
                date_Paid.SetupEditAttributes();
                date_Paid.EditValue = FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern); // DN
                date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

                // Amount_Paid
                Amount_Paid.SetupEditAttributes();
                Amount_Paid.EditValue = Amount_Paid.CurrentValue; // DN
                Amount_Paid.PlaceHolder = RemoveHtml(Amount_Paid.Caption);
                if (!Empty(Amount_Paid.EditValue) && IsNumeric(Amount_Paid.EditValue)) {
                    Amount_Paid.EditValue = FormatNumber(Amount_Paid.EditValue, null);
                }

                // running_payments
                running_payments.SetupEditAttributes();
                running_payments.EditValue = running_payments.CurrentValue; // DN
                running_payments.PlaceHolder = RemoveHtml(running_payments.Caption);
                if (!Empty(running_payments.EditValue) && IsNumeric(running_payments.EditValue)) {
                    running_payments.EditValue = FormatNumber(running_payments.EditValue, null);
                }

                // running_balance
                running_balance.SetupEditAttributes();
                running_balance.EditValue = running_balance.CurrentValue; // DN
                running_balance.PlaceHolder = RemoveHtml(running_balance.Caption);
                if (!Empty(running_balance.EditValue) && IsNumeric(running_balance.EditValue)) {
                    running_balance.EditValue = FormatNumber(running_balance.EditValue, null);
                }

                // str_ApprovalCode
                str_ApprovalCode.SetupEditAttributes();
                if (!str_ApprovalCode.Raw)
                    str_ApprovalCode.CurrentValue = HtmlDecode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

                // Package_Name
                Package_Name.SetupEditAttributes();
                if (!Package_Name.Raw)
                    Package_Name.CurrentValue = HtmlDecode(Package_Name.CurrentValue);
                Package_Name.EditValue = HtmlEncode(Package_Name.CurrentValue);
                Package_Name.PlaceHolder = RemoveHtml(Package_Name.Caption);

                // int_Package_ID
                int_Package_ID.SetupEditAttributes();
                int_Package_ID.EditValue = int_Package_ID.CurrentValue; // DN
                int_Package_ID.PlaceHolder = RemoveHtml(int_Package_ID.Caption);
                if (!Empty(int_Package_ID.EditValue) && IsNumeric(int_Package_ID.EditValue)) {
                    int_Package_ID.EditValue = FormatNumber(int_Package_ID.EditValue, null);
                }

                // Add refer script

                // Payment_Number
                Payment_Number.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // Amount_Paid
                Amount_Paid.HrefValue = "";

                // running_payments
                running_payments.HrefValue = "";

                // running_balance
                running_balance.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

                // Package_Name
                Package_Name.HrefValue = "";

                // int_Package_ID
                int_Package_ID.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // Payment_Number
                Payment_Number.SetupEditAttributes();
                Payment_Number.EditValue = Payment_Number.CurrentValue; // DN
                Payment_Number.PlaceHolder = RemoveHtml(Payment_Number.Caption);
                if (!Empty(Payment_Number.EditValue) && IsNumeric(Payment_Number.EditValue)) {
                    Payment_Number.EditValue = FormatNumber(Payment_Number.EditValue, null);
                }

                // NationalID
                NationalID.SetupEditAttributes();
                if (!Empty(NationalID.SessionValue)) {
                    NationalID.CurrentValue = ForeignKeyValue(NationalID.SessionValue);
                    NationalID.OldValue = NationalID.CurrentValue;
                    NationalID.ViewValue = NationalID.CurrentValue;
                    NationalID.ViewCustomAttributes = "";
                } else {
                    NationalID.EditValue = NationalID.CurrentValue; // DN
                    NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                    if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue)) {
                    }
                }

                // date_Paid
                date_Paid.SetupEditAttributes();
                date_Paid.EditValue = FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern); // DN
                date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

                // Amount_Paid
                Amount_Paid.SetupEditAttributes();
                Amount_Paid.EditValue = Amount_Paid.CurrentValue; // DN
                Amount_Paid.PlaceHolder = RemoveHtml(Amount_Paid.Caption);
                if (!Empty(Amount_Paid.EditValue) && IsNumeric(Amount_Paid.EditValue)) {
                    Amount_Paid.EditValue = FormatNumber(Amount_Paid.EditValue, null);
                }

                // running_payments
                running_payments.SetupEditAttributes();
                running_payments.EditValue = running_payments.CurrentValue; // DN
                running_payments.PlaceHolder = RemoveHtml(running_payments.Caption);
                if (!Empty(running_payments.EditValue) && IsNumeric(running_payments.EditValue)) {
                    running_payments.EditValue = FormatNumber(running_payments.EditValue, null);
                }

                // running_balance
                running_balance.SetupEditAttributes();
                running_balance.EditValue = running_balance.CurrentValue; // DN
                running_balance.PlaceHolder = RemoveHtml(running_balance.Caption);
                if (!Empty(running_balance.EditValue) && IsNumeric(running_balance.EditValue)) {
                    running_balance.EditValue = FormatNumber(running_balance.EditValue, null);
                }

                // str_ApprovalCode
                str_ApprovalCode.SetupEditAttributes();
                if (!str_ApprovalCode.Raw)
                    str_ApprovalCode.CurrentValue = HtmlDecode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

                // Package_Name
                Package_Name.SetupEditAttributes();
                if (!Package_Name.Raw)
                    Package_Name.CurrentValue = HtmlDecode(Package_Name.CurrentValue);
                Package_Name.EditValue = HtmlEncode(Package_Name.CurrentValue);
                Package_Name.PlaceHolder = RemoveHtml(Package_Name.Caption);

                // int_Package_ID
                int_Package_ID.SetupEditAttributes();
                int_Package_ID.EditValue = int_Package_ID.CurrentValue; // DN
                int_Package_ID.PlaceHolder = RemoveHtml(int_Package_ID.Caption);
                if (!Empty(int_Package_ID.EditValue) && IsNumeric(int_Package_ID.EditValue)) {
                    int_Package_ID.EditValue = FormatNumber(int_Package_ID.EditValue, null);
                }

                // Edit refer script

                // Payment_Number
                Payment_Number.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // Amount_Paid
                Amount_Paid.HrefValue = "";

                // running_payments
                running_payments.HrefValue = "";

                // running_balance
                running_balance.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

                // Package_Name
                Package_Name.HrefValue = "";

                // int_Package_ID
                int_Package_ID.HrefValue = "";
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
            if (Payment_Number.Required) {
                if (!Payment_Number.IsDetailKey && Empty(Payment_Number.FormValue)) {
                    Payment_Number.AddErrorMessage(ConvertToString(Payment_Number.RequiredErrorMessage).Replace("%s", Payment_Number.Caption));
                }
            }
            if (!CheckInteger(Payment_Number.FormValue)) {
                Payment_Number.AddErrorMessage(Payment_Number.GetErrorMessage(false));
            }
            if (NationalID.Required) {
                if (!NationalID.IsDetailKey && Empty(NationalID.FormValue)) {
                    NationalID.AddErrorMessage(ConvertToString(NationalID.RequiredErrorMessage).Replace("%s", NationalID.Caption));
                }
            }
            if (!CheckInteger(NationalID.FormValue)) {
                NationalID.AddErrorMessage(NationalID.GetErrorMessage(false));
            }
            if (date_Paid.Required) {
                if (!date_Paid.IsDetailKey && Empty(date_Paid.FormValue)) {
                    date_Paid.AddErrorMessage(ConvertToString(date_Paid.RequiredErrorMessage).Replace("%s", date_Paid.Caption));
                }
            }
            if (!CheckDate(date_Paid.FormValue, date_Paid.FormatPattern)) {
                date_Paid.AddErrorMessage(date_Paid.GetErrorMessage(false));
            }
            if (Amount_Paid.Required) {
                if (!Amount_Paid.IsDetailKey && Empty(Amount_Paid.FormValue)) {
                    Amount_Paid.AddErrorMessage(ConvertToString(Amount_Paid.RequiredErrorMessage).Replace("%s", Amount_Paid.Caption));
                }
            }
            if (!CheckNumber(Amount_Paid.FormValue)) {
                Amount_Paid.AddErrorMessage(Amount_Paid.GetErrorMessage(false));
            }
            if (running_payments.Required) {
                if (!running_payments.IsDetailKey && Empty(running_payments.FormValue)) {
                    running_payments.AddErrorMessage(ConvertToString(running_payments.RequiredErrorMessage).Replace("%s", running_payments.Caption));
                }
            }
            if (!CheckNumber(running_payments.FormValue)) {
                running_payments.AddErrorMessage(running_payments.GetErrorMessage(false));
            }
            if (running_balance.Required) {
                if (!running_balance.IsDetailKey && Empty(running_balance.FormValue)) {
                    running_balance.AddErrorMessage(ConvertToString(running_balance.RequiredErrorMessage).Replace("%s", running_balance.Caption));
                }
            }
            if (!CheckNumber(running_balance.FormValue)) {
                running_balance.AddErrorMessage(running_balance.GetErrorMessage(false));
            }
            if (str_ApprovalCode.Required) {
                if (!str_ApprovalCode.IsDetailKey && Empty(str_ApprovalCode.FormValue)) {
                    str_ApprovalCode.AddErrorMessage(ConvertToString(str_ApprovalCode.RequiredErrorMessage).Replace("%s", str_ApprovalCode.Caption));
                }
            }
            if (Package_Name.Required) {
                if (!Package_Name.IsDetailKey && Empty(Package_Name.FormValue)) {
                    Package_Name.AddErrorMessage(ConvertToString(Package_Name.RequiredErrorMessage).Replace("%s", Package_Name.Caption));
                }
            }
            if (int_Package_ID.Required) {
                if (!int_Package_ID.IsDetailKey && Empty(int_Package_ID.FormValue)) {
                    int_Package_ID.AddErrorMessage(ConvertToString(int_Package_ID.RequiredErrorMessage).Replace("%s", int_Package_ID.Caption));
                }
            }
            if (!CheckInteger(int_Package_ID.FormValue)) {
                int_Package_ID.AddErrorMessage(int_Package_ID.GetErrorMessage(false));
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

            // NationalID
            if (!Empty(NationalID.SessionValue))
                NationalID.ReadOnly = true;
            NationalID.SetDbValue(rsnew, NationalID.CurrentValue, NationalID.ReadOnly);

            // date_Paid
            date_Paid.SetDbValue(rsnew, ConvertToDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), date_Paid.ReadOnly);

            // str_ApprovalCode
            str_ApprovalCode.SetDbValue(rsnew, str_ApprovalCode.CurrentValue, str_ApprovalCode.ReadOnly);

            // Package_Name
            Package_Name.SetDbValue(rsnew, Package_Name.CurrentValue, Package_Name.ReadOnly);

            // int_Package_ID
            int_Package_ID.SetDbValue(rsnew, int_Package_ID.CurrentValue, int_Package_ID.ReadOnly);

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
            if (CurrentMasterTable == "tblBillingInfo") {
                NationalID.CurrentValue = NationalID.SessionValue;
            }

            // Set new row
            Dictionary<string, object> rsnew = new ();
            try {
                // NationalID
                NationalID.SetDbValue(rsnew, NationalID.CurrentValue);

                // date_Paid
                date_Paid.SetDbValue(rsnew, ConvertToDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern));

                // str_ApprovalCode
                str_ApprovalCode.SetDbValue(rsnew, str_ApprovalCode.CurrentValue);

                // Package_Name
                Package_Name.SetDbValue(rsnew, Package_Name.CurrentValue);

                // int_Package_ID
                int_Package_ID.SetDbValue(rsnew, int_Package_ID.CurrentValue);

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
            if (masterTblVar == "tblBillingInfo") {
                NationalID.Visible = false;

                //if (tblBillingInfo.EventCancelled) EventCancelled = true;
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
