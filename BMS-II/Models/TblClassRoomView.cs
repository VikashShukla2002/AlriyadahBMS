namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblClassRoomView
    /// </summary>
    public static TblClassRoomView tblClassRoomView
    {
        get => HttpData.Get<TblClassRoomView>("tblClassRoomView")!;
        set => HttpData["tblClassRoomView"] = value;
    }

    /// <summary>
    /// Page class for tblClassRoom
    /// </summary>
    public class TblClassRoomView : TblClassRoomViewBase
    {
        // Constructor
        public TblClassRoomView(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblClassRoomView() : base()
        {
        }

        // Page Load event
        public override void PageLoad() {
        //Description:	Update Class Days [str_CR_Days]
        string sUpdateSq23 = "UPD_STR_CR_DAYS";
        Execute (sUpdateSq23); 
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblClassRoomViewBase : TblClassRoom
    {
        // Page ID
        public string PageID = "view";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblClassRoom";

        // Page object name
        public string PageObjName = "tblClassRoomView";

        // Title
        public string? Title = null; // Title for <title> tag

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
        public TblClassRoomViewBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-view-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblClassRoom)
            if (tblClassRoom == null || tblClassRoom is TblClassRoom)
                tblClassRoom = this;

            // DN
            string[] keys = new string[0];
            StringValues str = "";
            object? obj = null;
            string currentPageName = CurrentPageName();
            string currentUrl = AppPath(currentPageName); // DN
            if (IsApi()) {
                if (RouteValues.TryGetValue("key", out object? k) && !Empty(k))
                    keys = ConvertToString(k).Split('/');
                if (keys.Length > 0)
                    RecordKeys["int_CR_ID"] = keys[0];
            } else {
                RecordKeys["int_CR_ID"] = RouteValues.TryGetValue("int_CR_ID", out obj) && obj != null ? UrlDecode(obj) : Get("int_CR_ID"); // DN
            }

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
        public string PageName => "TblClassRoomView";

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
            int_CR_ID.SetVisibility();
            str_CR_Number.SetVisibility();
            int_CR_Product_ID.SetVisibility();
            str_Package_Name.SetVisibility();
            date_Start.SetVisibility();
            mon_CR_Price.SetVisibility();
            int_CR_Size.SetVisibility();
            int_MU_Size.SetVisibility();
            int_CR_Status.SetVisibility();
            Is_Web_SignUp.SetVisibility();
            int_TotSession.SetVisibility();
            int_PerDaySession.SetVisibility();
            int_Location_ID.SetVisibility();
            int_Teacher_ID.SetVisibility();
            str_CR_Notes.SetVisibility();
            is_ZoomMeet.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            bit_AllTeacher.SetVisibility();
            int_Manual_Change.SetVisibility();
            str_WebDesc.SetVisibility();
            is_Show.SetVisibility();
            is_ShowGridColumn.SetVisibility();
            rowIndex.SetVisibility();
            Classroom_Internal_Cr_Notes.SetVisibility();
            BulkCR_Set.SetVisibility();
            str_Username.SetVisibility();
            Calendar_ID.SetVisibility();
            int_Day_Incremental.SetVisibility();
            int_Reoccurrence.SetVisibility();
            date_Start2.SetVisibility();
            date_Start3.SetVisibility();
            date_Start4.SetVisibility();
            str_CR_Days.SetVisibility();
        }

        // Constructor
        public TblClassRoomViewBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblClassRoomView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_CR_ID") ? dict["int_CR_ID"] : int_CR_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_CR_ID.Visible = false;
        }

        public int DisplayRecords = 1; // Number of display records

        public int StartRecord;

        public int StopRecord;

        public int TotalRecords = -1;

        public int RecordRange = 10;

        public int RecordCount;

        public Dictionary<string, string> RecordKeys = new ();

        public bool IsModal = false;

        public string SearchWhere = "";

        public string DbMasterFilter = "";

        public string DbDetailFilter = "";

        public bool MasterRecordExists;

        public DbDataReader? Recordset = null;

        public SubPages? MultiPages; // Multi pages object

        #pragma warning disable 168, 219
        /// <summary>
        /// Page run
        /// </summary>
        /// <returns>Page result</returns>
        public override async Task<IActionResult> Run()
        {
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
            SetVisibility();

            // Do not use lookup cache
            if (!Config.LookupCachePageIds.Contains(PageID))
                SetUseLookupCache(false);

            // Set up multi page object
            SetupMultiPages();

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

            // Set up lookup cache
            await SetupLookupOptions(int_CR_Product_ID);
            await SetupLookupOptions(str_Package_Name);
            await SetupLookupOptions(mon_CR_Price);
            await SetupLookupOptions(int_CR_Size);
            await SetupLookupOptions(int_MU_Size);
            await SetupLookupOptions(int_CR_Status);
            await SetupLookupOptions(Is_Web_SignUp);
            await SetupLookupOptions(int_TotSession);
            await SetupLookupOptions(int_PerDaySession);
            await SetupLookupOptions(int_Teacher_ID);
            await SetupLookupOptions(is_ZoomMeet);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_AllTeacher);
            await SetupLookupOptions(is_Show);
            await SetupLookupOptions(is_ShowGridColumn);
            await SetupLookupOptions(BulkCR_Set);
            await SetupLookupOptions(str_CR_Days);

            // Check modal
            if (IsModal)
                SkipHeaderFooter = true;

            // Load current record
            bool loadCurrentRecord = false;
            string returnUrl = "";
            bool matchRecord = false;
            string[] keyValues = {};
            object? v;
            StringValues sv;
            if (IsApi()) {
                if (RouteValues.TryGetValue(Config.ApiKeyName, out object? k)) {
                    if (!Empty(k))
                        keyValues = ConvertToString(k).Split('/');
                } else { // Get key from query string
                    string key = Get(Config.ApiKeyName);
                    if (!Empty(key))
                        keyValues = key.Split(',');
                }
                if (keyValues.Length == 0)
                    return new JsonBoolResult(new { success = false, error = Language.Phrase("NoRecord"), version = Config.ProductVersion }, false);
            }
            if (RouteValues.TryGetValue("int_CR_ID", out v) && !Empty(v)) { // DN
                int_CR_ID.QueryValue = UrlDecode(v); // DN
                RecordKeys["int_CR_ID"] = int_CR_ID.QueryValue;
            } else if (Get("int_CR_ID", out sv)) {
                int_CR_ID.QueryValue = sv.ToString();
                RecordKeys["int_CR_ID"] = int_CR_ID.QueryValue;
            } else if (IsApi() && !Empty(keyValues)) {
                int_CR_ID.QueryValue = ConvertToString(keyValues[0]);
                RecordKeys["int_CR_ID"] = int_CR_ID.QueryValue;
            } else if (!loadCurrentRecord) {
                returnUrl = "TblClassRoomList"; // Return to list
            }

            // Get action
            CurrentAction = "show"; // Display form
            switch (CurrentAction) {
                case "show": // Get a record to display
                        bool res;
                        if (IsApi()) {
                            string filter = GetRecordFilter();
                            CurrentFilter = filter;
                            string sql = CurrentSql;
                            var conn = await GetConnectionAsync();
                            Recordset = await conn.GetDataReaderAsync(sql);
                            res = !Empty(Recordset) && await Recordset.ReadAsync();
                        } else {
                            res = await LoadRow();
                        }
                        if (!res) { // Load record based on key
                            if (Empty(SuccessMessage) && Empty(FailureMessage))
                                FailureMessage = Language.Phrase("NoRecord"); // Set no record message
                            if (IsApi()) {
                                if (!Empty(SuccessMessage))
                                    return new JsonBoolResult(new { success = true, message = SuccessMessage, version = Config.ProductVersion }, true);
                                else
                                    return new JsonBoolResult(new { success = false, error = FailureMessage, version = Config.ProductVersion }, false);
                            } else {
                                return Terminate("TblClassRoomList"); // Return to list page
                            }
                        }
                    break;
            }
            if (!Empty(returnUrl))
                return Terminate(returnUrl);

            // Render row
            RowType = RowType.View;
            ResetAttributes();
            await RenderRow();

            // Setup export options
            SetupExportOptions();

            // Set up Breadcrumb
            if (!IsExport())
                SetupBreadcrumb();

            // Normal return
            if (IsApi()) // Get current record only
                if (!IsExport())
                    return Controller.Json(new { success = true, TableVar = await GetRecordFromRecordset(Recordset), version = Config.ProductVersion });

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                tblClassRoomView?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 168, 219

        // Set up other options
        #pragma warning disable 168, 219

        public void SetupOtherOptions()
        {
            var options = OtherOptions;
            var option = options["action"];
            ListOption item;
            string links = "";

            // Add
            item = option.Add("add");
            string addTitle = Language.Phrase("ViewPageAddLink", true);
            if (IsModal) // Modal
                item.Body = "<a class=\"ew-action ew-add\" title=\"" + addTitle + "\" data-caption=\"" + addTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(AppPath(AddUrl)) + "\">" + Language.Phrase("ViewPageAddLink") + "</a>";
            else
                item.Body = "<a class=\"ew-action ew-add\" title=\"" + addTitle + "\" data-caption=\"" + addTitle + "\" href=\"" + HtmlEncode(AppPath(AddUrl)) + "\">" + Language.Phrase("ViewPageAddLink") + "</a>";
                item.Visible = AddUrl != "" && Security.CanAdd;

            // Edit
            item = option.Add("edit");
            var editTitle = Language.Phrase("ViewPageEditLink", true);
            if (IsModal) // Modal
                item.Body = "<a class=\"ew-action ew-edit\" title=\"" + editTitle + "\" data-caption=\"" + editTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("ViewPageEditLink") + "</a>";
            else
                item.Body = "<a class=\"ew-action ew-edit\" title=\"" + editTitle + "\" data-caption=\"" + editTitle + "\" href=\"" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("ViewPageEditLink") + "</a>";
                item.Visible = EditUrl != "" && Security.CanEdit;

            // Set up action default
            option = options["action"];
            option.DropDownButtonPhrase = "ButtonActions";
            option.UseDropDownButton = !IsJsonResponse() && false;
            option.UseButtonGroup = true;
            item = option.AddGroupOption();
            item.Body = "";
            item.Visible = false;
        }
        #pragma warning restore 168, 219

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
            int_CR_ID.SetDbValue(row["int_CR_ID"]);
            str_CR_Number.SetDbValue(row["str_CR_Number"]);
            int_CR_Product_ID.SetDbValue(row["int_CR_Product_ID"]);
            str_Package_Name.SetDbValue(row["str_Package_Name"]);
            date_Start.SetDbValue(row["date_Start"]);
            mon_CR_Price.SetDbValue(row["mon_CR_Price"]);
            int_CR_Size.SetDbValue(row["int_CR_Size"]);
            int_MU_Size.SetDbValue(row["int_MU_Size"]);
            int_CR_Status.SetDbValue(row["int_CR_Status"]);
            Is_Web_SignUp.SetDbValue((ConvertToBool(row["Is_Web_SignUp"]) ? "1" : "0"));
            int_TotSession.SetDbValue(row["int_TotSession"]);
            int_PerDaySession.SetDbValue(row["int_PerDaySession"]);
            int_Location_ID.SetDbValue(row["int_Location_ID"]);
            int_Teacher_ID.SetDbValue(row["int_Teacher_ID"]);
            str_CR_Notes.SetDbValue(row["str_CR_Notes"]);
            is_ZoomMeet.SetDbValue((ConvertToBool(row["is_ZoomMeet"]) ? "1" : "0"));
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            bit_AllTeacher.SetDbValue((ConvertToBool(row["bit_AllTeacher"]) ? "1" : "0"));
            int_Manual_Change.SetDbValue(row["int_Manual_Change"]);
            str_WebDesc.SetDbValue(row["str_WebDesc"]);
            is_Show.SetDbValue((ConvertToBool(row["is_Show"]) ? "1" : "0"));
            is_ShowGridColumn.SetDbValue((ConvertToBool(row["is_ShowGridColumn"]) ? "1" : "0"));
            rowIndex.SetDbValue(row["rowIndex"]);
            Classroom_Internal_Cr_Notes.SetDbValue(row["Classroom_Internal_Cr_Notes"]);
            BulkCR_Set.SetDbValue(row["BulkCR_Set"]);
            str_Username.SetDbValue(row["str_Username"]);
            Calendar_ID.SetDbValue(row["Calendar_ID"]);
            int_Day_Incremental.SetDbValue(row["int_Day_Incremental"]);
            int_Reoccurrence.SetDbValue(row["int_Reoccurrence"]);
            date_Start2.SetDbValue(row["date_Start2"]);
            date_Start3.SetDbValue(row["date_Start3"]);
            date_Start4.SetDbValue(row["date_Start4"]);
            str_CR_Days.SetDbValue(row["str_CR_Days"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_CR_ID", int_CR_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Number", str_CR_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Product_ID", int_CR_Product_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Package_Name", str_Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start", date_Start.DefaultValue ?? DbNullValue); // DN
            row.Add("mon_CR_Price", mon_CR_Price.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Size", int_CR_Size.DefaultValue ?? DbNullValue); // DN
            row.Add("int_MU_Size", int_MU_Size.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Status", int_CR_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("Is_Web_SignUp", Is_Web_SignUp.DefaultValue ?? DbNullValue); // DN
            row.Add("int_TotSession", int_TotSession.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PerDaySession", int_PerDaySession.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_ID", int_Location_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Teacher_ID", int_Teacher_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Notes", str_CR_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("is_ZoomMeet", is_ZoomMeet.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_AllTeacher", bit_AllTeacher.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Manual_Change", int_Manual_Change.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebDesc", str_WebDesc.DefaultValue ?? DbNullValue); // DN
            row.Add("is_Show", is_Show.DefaultValue ?? DbNullValue); // DN
            row.Add("is_ShowGridColumn", is_ShowGridColumn.DefaultValue ?? DbNullValue); // DN
            row.Add("rowIndex", rowIndex.DefaultValue ?? DbNullValue); // DN
            row.Add("Classroom_Internal_Cr_Notes", Classroom_Internal_Cr_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("BulkCR_Set", BulkCR_Set.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("Calendar_ID", Calendar_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Day_Incremental", int_Day_Incremental.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Reoccurrence", int_Reoccurrence.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start2", date_Start2.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start3", date_Start3.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start4", date_Start4.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Days", str_CR_Days.DefaultValue ?? DbNullValue); // DN
            return row;
        }

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            SetupOtherOptions();

            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_CR_ID

            // str_CR_Number

            // int_CR_Product_ID

            // str_Package_Name

            // date_Start

            // mon_CR_Price

            // int_CR_Size

            // int_MU_Size

            // int_CR_Status

            // Is_Web_SignUp

            // int_TotSession

            // int_PerDaySession

            // int_Location_ID

            // int_Teacher_ID

            // str_CR_Notes

            // is_ZoomMeet

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // bit_AllTeacher

            // int_Manual_Change

            // str_WebDesc

            // is_Show

            // is_ShowGridColumn

            // rowIndex

            // Classroom_Internal_Cr_Notes

            // BulkCR_Set

            // str_Username

            // Calendar_ID

            // int_Day_Incremental

            // int_Reoccurrence

            // date_Start2

            // date_Start3

            // date_Start4

            // str_CR_Days

            // View row
            if (RowType == RowType.View) {
                // int_CR_ID
                int_CR_ID.ViewValue = int_CR_ID.CurrentValue;
                int_CR_ID.ViewValue = FormatNumber(int_CR_ID.ViewValue, int_CR_ID.FormatPattern);
                int_CR_ID.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.ViewValue = ConvertToString(str_CR_Number.CurrentValue); // DN
                str_CR_Number.ViewCustomAttributes = "";

                // int_CR_Product_ID
                curVal = ConvertToString(int_CR_Product_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_CR_Product_ID.Lookup != null && IsDictionary(int_CR_Product_ID.Lookup?.Options) && int_CR_Product_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_CR_Product_ID.ViewValue = int_CR_Product_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_CR_Product_ID.CurrentValue, DataType.Number, "");
                        lookupFilter = () => int_CR_Product_ID.GetSelectFilter();
                        sqlWrk = int_CR_Product_ID.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_CR_Product_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_CR_Product_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_CR_Product_ID.ViewValue = int_CR_Product_ID.HighlightLookup(ConvertToString(rswrk[0]), int_CR_Product_ID.DisplayValue(listwrk));
                        } else {
                            int_CR_Product_ID.ViewValue = FormatNumber(int_CR_Product_ID.CurrentValue, int_CR_Product_ID.FormatPattern);
                        }
                    }
                } else {
                    int_CR_Product_ID.ViewValue = DbNullValue;
                }
                int_CR_Product_ID.ViewCustomAttributes = "";

                // str_Package_Name
                curVal = ConvertToString(str_Package_Name.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Package_Name.Lookup != null && IsDictionary(str_Package_Name.Lookup?.Options) && str_Package_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Package_Name.ViewValue = str_Package_Name.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Package_Name]", "=", str_Package_Name.CurrentValue, DataType.String, "");
                        sqlWrk = str_Package_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Package_Name.Lookup != null) { // Lookup values found
                            var listwrk = str_Package_Name.Lookup?.RenderViewRow(rswrk[0]);
                            str_Package_Name.ViewValue = str_Package_Name.HighlightLookup(ConvertToString(rswrk[0]), str_Package_Name.DisplayValue(listwrk));
                        } else {
                            str_Package_Name.ViewValue = str_Package_Name.CurrentValue;
                        }
                    }
                } else {
                    str_Package_Name.ViewValue = DbNullValue;
                }
                str_Package_Name.ViewCustomAttributes = "";

                // date_Start
                date_Start.ViewValue = date_Start.CurrentValue;
                date_Start.ViewValue = FormatDateTime(date_Start.ViewValue, date_Start.FormatPattern);
                date_Start.ViewCustomAttributes = "";

                // mon_CR_Price
                curVal = ConvertToString(mon_CR_Price.CurrentValue);
                if (!Empty(curVal)) {
                    if (mon_CR_Price.Lookup != null && IsDictionary(mon_CR_Price.Lookup?.Options) && mon_CR_Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        mon_CR_Price.ViewValue = mon_CR_Price.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[mny_Price]", "=", mon_CR_Price.CurrentValue, DataType.Number, "");
                        sqlWrk = mon_CR_Price.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && mon_CR_Price.Lookup != null) { // Lookup values found
                            var listwrk = mon_CR_Price.Lookup?.RenderViewRow(rswrk[0]);
                            mon_CR_Price.ViewValue = mon_CR_Price.HighlightLookup(ConvertToString(rswrk[0]), mon_CR_Price.DisplayValue(listwrk));
                        } else {
                            mon_CR_Price.ViewValue = FormatCurrency(mon_CR_Price.CurrentValue, mon_CR_Price.FormatPattern);
                        }
                    }
                } else {
                    mon_CR_Price.ViewValue = DbNullValue;
                }
                mon_CR_Price.ViewCustomAttributes = "";

                // int_CR_Size
                if (!Empty(int_CR_Size.CurrentValue)) {
                    int_CR_Size.ViewValue = int_CR_Size.HighlightLookup(ConvertToString(int_CR_Size.CurrentValue), int_CR_Size.OptionCaption(ConvertToString(int_CR_Size.CurrentValue)));
                } else {
                    int_CR_Size.ViewValue = DbNullValue;
                }
                int_CR_Size.ViewCustomAttributes = "";

                // int_MU_Size
                if (!Empty(int_MU_Size.CurrentValue)) {
                    int_MU_Size.ViewValue = int_MU_Size.HighlightLookup(ConvertToString(int_MU_Size.CurrentValue), int_MU_Size.OptionCaption(ConvertToString(int_MU_Size.CurrentValue)));
                } else {
                    int_MU_Size.ViewValue = DbNullValue;
                }
                int_MU_Size.ViewCustomAttributes = "";

                // int_CR_Status
                if (!Empty(int_CR_Status.CurrentValue)) {
                    int_CR_Status.ViewValue = int_CR_Status.HighlightLookup(ConvertToString(int_CR_Status.CurrentValue), int_CR_Status.OptionCaption(ConvertToString(int_CR_Status.CurrentValue)));
                } else {
                    int_CR_Status.ViewValue = DbNullValue;
                }
                int_CR_Status.ViewCustomAttributes = "";

                // Is_Web_SignUp
                if (ConvertToBool(Is_Web_SignUp.CurrentValue)) {
                    Is_Web_SignUp.ViewValue = Is_Web_SignUp.TagCaption(1) != "" ? Is_Web_SignUp.TagCaption(1) : "Yes";
                } else {
                    Is_Web_SignUp.ViewValue = Is_Web_SignUp.TagCaption(2) != "" ? Is_Web_SignUp.TagCaption(2) : "No";
                }
                Is_Web_SignUp.ViewCustomAttributes = "";

                // int_TotSession
                if (!Empty(int_TotSession.CurrentValue)) {
                    int_TotSession.ViewValue = int_TotSession.HighlightLookup(ConvertToString(int_TotSession.CurrentValue), int_TotSession.OptionCaption(ConvertToString(int_TotSession.CurrentValue)));
                } else {
                    int_TotSession.ViewValue = DbNullValue;
                }
                int_TotSession.ViewCustomAttributes = "";

                // int_PerDaySession
                if (!Empty(int_PerDaySession.CurrentValue)) {
                    int_PerDaySession.ViewValue = int_PerDaySession.HighlightLookup(ConvertToString(int_PerDaySession.CurrentValue), int_PerDaySession.OptionCaption(ConvertToString(int_PerDaySession.CurrentValue)));
                } else {
                    int_PerDaySession.ViewValue = DbNullValue;
                }
                int_PerDaySession.ViewCustomAttributes = "";

                // int_Location_ID
                curVal = ConvertToString(int_Location_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Location_ID.Lookup != null && IsDictionary(int_Location_ID.Lookup?.Options) && int_Location_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Location_ID.ViewValue = int_Location_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Location_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Location_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Location_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Location_ID.ViewValue = int_Location_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Location_ID.DisplayValue(listwrk));
                        } else {
                            int_Location_ID.ViewValue = FormatNumber(int_Location_ID.CurrentValue, int_Location_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Location_ID.ViewValue = DbNullValue;
                }
                int_Location_ID.ViewCustomAttributes = "";

                // int_Teacher_ID
                curVal = ConvertToString(int_Teacher_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Teacher_ID.Lookup != null && IsDictionary(int_Teacher_ID.Lookup?.Options) && int_Teacher_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Teacher_ID.ViewValue = int_Teacher_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Staff_Id]", "=", int_Teacher_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Teacher_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Teacher_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Teacher_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Teacher_ID.ViewValue = int_Teacher_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Teacher_ID.DisplayValue(listwrk));
                        } else {
                            int_Teacher_ID.ViewValue = FormatNumber(int_Teacher_ID.CurrentValue, int_Teacher_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Teacher_ID.ViewValue = DbNullValue;
                }
                int_Teacher_ID.ViewCustomAttributes = "";

                // str_CR_Notes
                str_CR_Notes.ViewValue = str_CR_Notes.CurrentValue;
                str_CR_Notes.ViewCustomAttributes = "";

                // is_ZoomMeet
                if (ConvertToBool(is_ZoomMeet.CurrentValue)) {
                    is_ZoomMeet.ViewValue = is_ZoomMeet.TagCaption(1) != "" ? is_ZoomMeet.TagCaption(1) : "Yes";
                } else {
                    is_ZoomMeet.ViewValue = is_ZoomMeet.TagCaption(2) != "" ? is_ZoomMeet.TagCaption(2) : "No";
                }
                is_ZoomMeet.ViewCustomAttributes = "";

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

                // bit_AllTeacher
                if (ConvertToBool(bit_AllTeacher.CurrentValue)) {
                    bit_AllTeacher.ViewValue = bit_AllTeacher.TagCaption(1) != "" ? bit_AllTeacher.TagCaption(1) : "Yes";
                } else {
                    bit_AllTeacher.ViewValue = bit_AllTeacher.TagCaption(2) != "" ? bit_AllTeacher.TagCaption(2) : "No";
                }
                bit_AllTeacher.ViewCustomAttributes = "";

                // int_Manual_Change
                int_Manual_Change.ViewValue = int_Manual_Change.CurrentValue;
                int_Manual_Change.ViewValue = FormatNumber(int_Manual_Change.ViewValue, int_Manual_Change.FormatPattern);
                int_Manual_Change.ViewCustomAttributes = "";

                // str_WebDesc
                str_WebDesc.ViewValue = ConvertToString(str_WebDesc.CurrentValue); // DN
                str_WebDesc.ViewCustomAttributes = "";

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

                // BulkCR_Set
                if (!Empty(BulkCR_Set.CurrentValue)) {
                    var optionsWrk = new OptionValues();
                    arWrk = ConvertToString(BulkCR_Set.CurrentValue).Split(Config.MultipleOptionSeparator);
                    for (int i = 0; i < arWrk.Length; i++) {
                        optionsWrk.Add(BulkCR_Set.HighlightLookup(arWrk[i].Trim(), BulkCR_Set.OptionCaption(arWrk[i].Trim())));
                    }
                    BulkCR_Set.ViewValue = optionsWrk.ToString(); // DN
                } else {
                    BulkCR_Set.ViewValue = DbNullValue;
                }
                BulkCR_Set.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = str_Username.CurrentValue;
                str_Username.ViewCustomAttributes = "";

                // Calendar_ID
                Calendar_ID.ViewValue = Calendar_ID.CurrentValue;
                Calendar_ID.ViewValue = FormatNumber(Calendar_ID.ViewValue, Calendar_ID.FormatPattern);
                Calendar_ID.ViewCustomAttributes = "";

                // int_Day_Incremental
                int_Day_Incremental.ViewValue = int_Day_Incremental.CurrentValue;
                int_Day_Incremental.ViewValue = FormatNumber(int_Day_Incremental.ViewValue, int_Day_Incremental.FormatPattern);
                int_Day_Incremental.ViewCustomAttributes = "";

                // int_Reoccurrence
                int_Reoccurrence.ViewValue = int_Reoccurrence.CurrentValue;
                int_Reoccurrence.ViewValue = FormatNumber(int_Reoccurrence.ViewValue, int_Reoccurrence.FormatPattern);
                int_Reoccurrence.ViewCustomAttributes = "";

                // date_Start2
                date_Start2.ViewValue = date_Start2.CurrentValue;
                date_Start2.ViewValue = FormatDateTime(date_Start2.ViewValue, date_Start2.FormatPattern);
                date_Start2.ViewCustomAttributes = "";

                // date_Start3
                date_Start3.ViewValue = date_Start3.CurrentValue;
                date_Start3.ViewValue = FormatDateTime(date_Start3.ViewValue, date_Start3.FormatPattern);
                date_Start3.ViewCustomAttributes = "";

                // date_Start4
                date_Start4.ViewValue = date_Start4.CurrentValue;
                date_Start4.ViewValue = FormatDateTime(date_Start4.ViewValue, date_Start4.FormatPattern);
                date_Start4.ViewCustomAttributes = "";

                // str_CR_Days
                if (!Empty(str_CR_Days.CurrentValue)) {
                    var optionsWrk = new OptionValues();
                    arWrk = ConvertToString(str_CR_Days.CurrentValue).Split(Config.MultipleOptionSeparator);
                    for (int i = 0; i < arWrk.Length; i++) {
                        optionsWrk.Add(str_CR_Days.HighlightLookup(arWrk[i].Trim(), str_CR_Days.OptionCaption(arWrk[i].Trim())));
                    }
                    str_CR_Days.ViewValue = optionsWrk.ToString(); // DN
                } else {
                    str_CR_Days.ViewValue = DbNullValue;
                }
                str_CR_Days.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.HrefValue = "";
                str_CR_Number.TooltipValue = "";

                // int_CR_Product_ID
                int_CR_Product_ID.HrefValue = "";
                int_CR_Product_ID.TooltipValue = "";

                // str_Package_Name
                str_Package_Name.HrefValue = "";
                str_Package_Name.TooltipValue = "";

                // date_Start
                date_Start.HrefValue = "";
                date_Start.TooltipValue = "";

                // mon_CR_Price
                mon_CR_Price.HrefValue = "";
                mon_CR_Price.TooltipValue = "";

                // int_CR_Size
                int_CR_Size.HrefValue = "";
                int_CR_Size.TooltipValue = "";

                // int_MU_Size
                int_MU_Size.HrefValue = "";
                int_MU_Size.TooltipValue = "";

                // int_CR_Status
                int_CR_Status.HrefValue = "";
                int_CR_Status.TooltipValue = "";

                // Is_Web_SignUp
                Is_Web_SignUp.HrefValue = "";
                Is_Web_SignUp.TooltipValue = "";

                // int_TotSession
                int_TotSession.HrefValue = "";
                int_TotSession.TooltipValue = "";

                // int_PerDaySession
                int_PerDaySession.HrefValue = "";
                int_PerDaySession.TooltipValue = "";

                // int_Location_ID
                int_Location_ID.HrefValue = "";
                int_Location_ID.TooltipValue = "";

                // int_Teacher_ID
                int_Teacher_ID.HrefValue = "";
                int_Teacher_ID.TooltipValue = "";

                // str_CR_Notes
                str_CR_Notes.HrefValue = "";
                str_CR_Notes.TooltipValue = "";

                // is_ZoomMeet
                is_ZoomMeet.HrefValue = "";
                is_ZoomMeet.TooltipValue = "";

                // date_Created
                date_Created.HrefValue = "";
                date_Created.TooltipValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // BulkCR_Set
                BulkCR_Set.HrefValue = "";
                BulkCR_Set.TooltipValue = "";

                // int_Day_Incremental
                int_Day_Incremental.HrefValue = "";
                int_Day_Incremental.TooltipValue = "";

                // int_Reoccurrence
                int_Reoccurrence.HrefValue = "";
                int_Reoccurrence.TooltipValue = "";

                // date_Start2
                date_Start2.HrefValue = "";
                date_Start2.TooltipValue = "";

                // date_Start3
                date_Start3.HrefValue = "";
                date_Start3.TooltipValue = "";

                // date_Start4
                date_Start4.HrefValue = "";
                date_Start4.TooltipValue = "";

                // str_CR_Days
                str_CR_Days.HrefValue = "";
                str_CR_Days.TooltipValue = "";
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
                List<string> keys = GetKey(true).Split(Config.CompositeKeySeparator).ToList();
                foreach (string key in keys)
                    exportUrl += "/" + UrlEncode(key);
                exportUrl += "?export=" + type + (custom ? "&amp;custom=1" : "");
            } else {
                exportUrl = AppPath(Config.ApiUrl + Config.ApiExportAction + "/" + type + "/" + TableVar);
                exportUrl += "?" + Config.ApiKeyName + "=" + GetKey(true);
            }
            if (SameText(type, "excel")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblClassRoomview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblClassRoomview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblClassRoomview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblClassRoomview\" data-ew-action=\"email\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-key='" + HtmlEncode(ConvertToJsonAttribute(RecordKeys)) + "' data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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

            // Hide options for export
            if (IsExport())
                ExportOptions.HideAllOptions();

            // Hide options if json response
            if (IsJsonResponse())
                ExportOptions.HideAllOptions();
            if (!Security.CanExport) // Export not allowed
                ExportOptions.HideAllOptions();
        }

        #pragma warning disable 168

        /// <summary>
        /// Export data
        /// </summary>
        public async Task ExportData(dynamic? doc, string[] keys)
        {
            // Load recordset // DN
            DbDataReader? dr = null;
            if (TotalRecords < 0)
                TotalRecords = await ListRecordCountAsync();
            StartRecord = 1;
            if (keys.Length >= 1) {
                int_CR_ID.OldValue = keys[0];
                var c = await GetConnection2Async(DbId); // Note: Use new connection for view page export // DN
                dr = await LoadReader(GetRecordFilter(), "", c);
            }
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
                await ExportDocument(doc, dr, StartRecord, StopRecord, "view");

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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblClassRoomList")), "", TableVar, true);
            string pageId = "view";
            breadcrumb.Add("view", pageId, url);
            CurrentBreadcrumb = breadcrumb;
        }

        // Set up multi pages
        protected void SetupMultiPages() {
            var pages = new SubPages();
            pages.Style = "tabs";
            pages.Add(0);
            pages.Add(1);
            pages.Add(2);
            pages.Add(3);
            pages.Add(4);
            pages.Add(5);
            pages.Add(6);
            MultiPages = pages;
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
                    case "x_int_CR_Product_ID":
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
            string recordNo = !Empty(pageNo) ? pageNo : startRec; // Record number = page number or start record
            if (!Empty(recordNo) && IsNumeric(recordNo))
                StartRecord = ConvertToInt(recordNo);
            else
                StartRecord = StartRecordNumber;

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
    } // End page class
} // End Partial class
