namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblCrSessionsView
    /// </summary>
    public static TblCrSessionsView tblCrSessionsView
    {
        get => HttpData.Get<TblCrSessionsView>("tblCrSessionsView")!;
        set => HttpData["tblCrSessionsView"] = value;
    }

    /// <summary>
    /// Page class for tblCRSessions
    /// </summary>
    public class TblCrSessionsView : TblCrSessionsViewBase
    {
        // Constructor
        public TblCrSessionsView(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblCrSessionsView() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblCrSessionsViewBase : TblCrSessions
    {
        // Page ID
        public string PageID = "view";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblCRSessions";

        // Page object name
        public string PageObjName = "tblCrSessionsView";

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
        public TblCrSessionsViewBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-view-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblCrSessions)
            if (tblCrSessions == null || tblCrSessions is TblCrSessions)
                tblCrSessions = this;

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
                    RecordKeys["int_CRSession_ID"] = keys[0];
            } else {
                RecordKeys["int_CRSession_ID"] = RouteValues.TryGetValue("int_CRSession_ID", out obj) && obj != null ? UrlDecode(obj) : Get("int_CRSession_ID"); // DN
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
        public string PageName => "TblCrSessionsView";

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
            int_CRSession_ID.SetVisibility();
            str_CR_Number.SetVisibility();
            int_Status.SetVisibility();
            int_Staff_Id.SetVisibility();
            Instructor.SetVisibility();
            int_Location_Id.SetVisibility();
            Location.SetVisibility();
            int_Session_ID.SetVisibility();
            str_Session_Date.SetVisibility();
            int_Day_ID.SetVisibility();
            str_Day_Name.SetVisibility();
            str_Time_Start.SetVisibility();
            str_Time_End.SetVisibility();
            date_Created.SetVisibility();
            int_CR_Id.SetVisibility();
            str_Notes.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_Session_Notes.SetVisibility();
            is_Rescheduled.SetVisibility();
            instructorSignature.SetVisibility();
            IsZoomMeet.SetVisibility();
            str_ZoomHostUrl.SetVisibility();
            str_ZoomUserUrl.SetVisibility();
            CR_Row_Index.SetVisibility();
            CRSS_ID.SetVisibility();
            int_Student_Id.SetVisibility();
            str_Username.SetVisibility();
            str_Status.SetVisibility();
        }

        // Constructor
        public TblCrSessionsViewBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblCrSessionsView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_CRSession_ID") ? dict["int_CRSession_ID"] : int_CRSession_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_CRSession_ID.Visible = false;
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
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(IsZoomMeet);

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
            if (RouteValues.TryGetValue("int_CRSession_ID", out v) && !Empty(v)) { // DN
                int_CRSession_ID.QueryValue = UrlDecode(v); // DN
                RecordKeys["int_CRSession_ID"] = int_CRSession_ID.QueryValue;
            } else if (Get("int_CRSession_ID", out sv)) {
                int_CRSession_ID.QueryValue = sv.ToString();
                RecordKeys["int_CRSession_ID"] = int_CRSession_ID.QueryValue;
            } else if (IsApi() && !Empty(keyValues)) {
                int_CRSession_ID.QueryValue = ConvertToString(keyValues[0]);
                RecordKeys["int_CRSession_ID"] = int_CRSession_ID.QueryValue;
            } else if (!loadCurrentRecord) {
                returnUrl = "TblCrSessionsList"; // Return to list
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
                                return Terminate("TblCrSessionsList"); // Return to list page
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
                tblCrSessionsView?.PageRender();
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

            // Copy
            item = option.Add("copy");
            var copyTitle = Language.Phrase("ViewPageCopyLink", true);
            if (IsModal) // Modal
                item.Body = "<a class=\"ew-action ew-copy\" title=\"" + copyTitle + "\" data-caption=\"" + copyTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(AppPath(CopyUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("ViewPageCopyLink") + "</a>";
            else
                item.Body = "<a class=\"ew-action ew-copy\" title=\"" + copyTitle + "\" data-caption=\"" + copyTitle + "\" href=\"" + HtmlEncode(AppPath(CopyUrl)) + "\">" + Language.Phrase("ViewPageCopyLink") + "</a>";
                item.Visible = CopyUrl != "" && Security.CanAdd;

            // Delete
            item = option.Add("delete");
            string url = AppPath(DeleteUrl);
            item.Body = "<a class=\"ew-action ew-delete\"" +
                (InlineDelete || IsModal ? " data-ew-action=\"inline-delete\"" : "") +
                " title=\"" + Language.Phrase("ViewPageDeleteLink", true) + "\" data-caption=\"" + Language.Phrase("ViewPageDeleteLink", true) +
                "\" href=\"" + HtmlEncode(url) + "\">" + Language.Phrase("ViewPageDeleteLink") + "</a>";
            item.Visible = DeleteUrl != "" && Security.CanDelete;

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
            int_CRSession_ID.SetDbValue(row["int_CRSession_ID"]);
            str_CR_Number.SetDbValue(row["str_CR_Number"]);
            int_Status.SetDbValue(row["int_Status"]);
            int_Staff_Id.SetDbValue(row["int_Staff_Id"]);
            Instructor.SetDbValue(row["Instructor"]);
            int_Location_Id.SetDbValue(row["int_Location_Id"]);
            Location.SetDbValue(row["Location"]);
            int_Session_ID.SetDbValue(row["int_Session_ID"]);
            str_Session_Date.SetDbValue(row["str_Session_Date"]);
            int_Day_ID.SetDbValue(row["int_Day_ID"]);
            str_Day_Name.SetDbValue(row["str_Day_Name"]);
            str_Time_Start.SetDbValue(row["str_Time_Start"]);
            str_Time_End.SetDbValue(row["str_Time_End"]);
            date_Created.SetDbValue(row["date_Created"]);
            int_CR_Id.SetDbValue(row["int_CR_Id"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_Session_Notes.SetDbValue(row["str_Session_Notes"]);
            is_Rescheduled.SetDbValue(row["is_Rescheduled"]);
            instructorSignature.Upload.DbValue = row["instructorSignature"];
            IsZoomMeet.SetDbValue((ConvertToBool(row["IsZoomMeet"]) ? "1" : "0"));
            str_ZoomHostUrl.SetDbValue(row["str_ZoomHostUrl"]);
            str_ZoomUserUrl.SetDbValue(row["str_ZoomUserUrl"]);
            CR_Row_Index.SetDbValue(row["CR_Row_Index"]);
            CRSS_ID.SetDbValue(row["CRSS_ID"]);
            int_Student_Id.SetDbValue(row["int_Student_Id"]);
            str_Username.SetDbValue(row["str_Username"]);
            str_Status.SetDbValue(row["str_Status"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_CRSession_ID", int_CRSession_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Number", str_CR_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Staff_Id", int_Staff_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("Instructor", Instructor.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_Id", int_Location_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("Location", Location.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Session_ID", int_Session_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Session_Date", str_Session_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Day_ID", int_Day_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Day_Name", str_Day_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Time_Start", str_Time_Start.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Time_End", str_Time_End.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Id", int_CR_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Session_Notes", str_Session_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("is_Rescheduled", is_Rescheduled.DefaultValue ?? DbNullValue); // DN
            row.Add("instructorSignature", instructorSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("IsZoomMeet", IsZoomMeet.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ZoomHostUrl", str_ZoomHostUrl.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ZoomUserUrl", str_ZoomUserUrl.DefaultValue ?? DbNullValue); // DN
            row.Add("CR_Row_Index", CR_Row_Index.DefaultValue ?? DbNullValue); // DN
            row.Add("CRSS_ID", CRSS_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_Id", int_Student_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Status", str_Status.DefaultValue ?? DbNullValue); // DN
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

            // int_CRSession_ID

            // str_CR_Number

            // int_Status

            // int_Staff_Id

            // Instructor

            // int_Location_Id

            // Location

            // int_Session_ID

            // str_Session_Date

            // int_Day_ID

            // str_Day_Name

            // str_Time_Start

            // str_Time_End

            // date_Created

            // int_CR_Id

            // str_Notes

            // int_Created_By

            // int_Modified_By

            // date_Modified

            // bit_IsDeleted

            // str_Session_Notes

            // is_Rescheduled

            // instructorSignature

            // IsZoomMeet

            // str_ZoomHostUrl

            // str_ZoomUserUrl

            // CR_Row_Index

            // CRSS_ID

            // int_Student_Id

            // str_Username

            // str_Status

            // View row
            if (RowType == RowType.View) {
                // int_CRSession_ID
                int_CRSession_ID.ViewValue = int_CRSession_ID.CurrentValue;
                int_CRSession_ID.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.ViewValue = ConvertToString(str_CR_Number.CurrentValue); // DN
                str_CR_Number.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // int_Staff_Id
                int_Staff_Id.ViewValue = int_Staff_Id.CurrentValue;
                int_Staff_Id.ViewValue = FormatNumber(int_Staff_Id.ViewValue, int_Staff_Id.FormatPattern);
                int_Staff_Id.ViewCustomAttributes = "";

                // Instructor
                Instructor.ViewValue = ConvertToString(Instructor.CurrentValue); // DN
                Instructor.ViewCustomAttributes = "";

                // int_Location_Id
                int_Location_Id.ViewValue = int_Location_Id.CurrentValue;
                int_Location_Id.ViewValue = FormatNumber(int_Location_Id.ViewValue, int_Location_Id.FormatPattern);
                int_Location_Id.ViewCustomAttributes = "";

                // Location
                Location.ViewValue = ConvertToString(Location.CurrentValue); // DN
                Location.ViewCustomAttributes = "";

                // int_Session_ID
                int_Session_ID.ViewValue = int_Session_ID.CurrentValue;
                int_Session_ID.ViewValue = FormatNumber(int_Session_ID.ViewValue, int_Session_ID.FormatPattern);
                int_Session_ID.ViewCustomAttributes = "";

                // str_Session_Date
                str_Session_Date.ViewValue = ConvertToString(str_Session_Date.CurrentValue); // DN
                str_Session_Date.ViewCustomAttributes = "";

                // int_Day_ID
                int_Day_ID.ViewValue = int_Day_ID.CurrentValue;
                int_Day_ID.ViewValue = FormatNumber(int_Day_ID.ViewValue, int_Day_ID.FormatPattern);
                int_Day_ID.ViewCustomAttributes = "";

                // str_Day_Name
                str_Day_Name.ViewValue = ConvertToString(str_Day_Name.CurrentValue); // DN
                str_Day_Name.ViewCustomAttributes = "";

                // str_Time_Start
                str_Time_Start.ViewValue = ConvertToString(str_Time_Start.CurrentValue); // DN
                str_Time_Start.ViewCustomAttributes = "";

                // str_Time_End
                str_Time_End.ViewValue = ConvertToString(str_Time_End.CurrentValue); // DN
                str_Time_End.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // int_CR_Id
                int_CR_Id.ViewValue = int_CR_Id.CurrentValue;
                int_CR_Id.ViewValue = FormatNumber(int_CR_Id.ViewValue, int_CR_Id.FormatPattern);
                int_CR_Id.ViewCustomAttributes = "";

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

                // str_Session_Notes
                str_Session_Notes.ViewValue = ConvertToString(str_Session_Notes.CurrentValue); // DN
                str_Session_Notes.ViewCustomAttributes = "";

                // is_Rescheduled
                is_Rescheduled.ViewValue = is_Rescheduled.CurrentValue;
                is_Rescheduled.ViewValue = FormatNumber(is_Rescheduled.ViewValue, is_Rescheduled.FormatPattern);
                is_Rescheduled.ViewCustomAttributes = "";

                // instructorSignature
                if (!IsNull(instructorSignature.Upload.DbValue)) {
                    instructorSignature.ViewValue = RawUrlEncode(int_CRSession_ID.CurrentValue);
                    instructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])instructorSignature.Upload.DbValue));
                } else {
                    instructorSignature.ViewValue = "";
                }
                instructorSignature.ViewCustomAttributes = "";

                // IsZoomMeet
                if (ConvertToBool(IsZoomMeet.CurrentValue)) {
                    IsZoomMeet.ViewValue = IsZoomMeet.TagCaption(1) != "" ? IsZoomMeet.TagCaption(1) : "Yes";
                } else {
                    IsZoomMeet.ViewValue = IsZoomMeet.TagCaption(2) != "" ? IsZoomMeet.TagCaption(2) : "No";
                }
                IsZoomMeet.ViewCustomAttributes = "";

                // str_ZoomHostUrl
                str_ZoomHostUrl.ViewValue = ConvertToString(str_ZoomHostUrl.CurrentValue); // DN
                str_ZoomHostUrl.ViewCustomAttributes = "";

                // str_ZoomUserUrl
                str_ZoomUserUrl.ViewValue = ConvertToString(str_ZoomUserUrl.CurrentValue); // DN
                str_ZoomUserUrl.ViewCustomAttributes = "";

                // CR_Row_Index
                CR_Row_Index.ViewValue = CR_Row_Index.CurrentValue;
                CR_Row_Index.ViewValue = FormatNumber(CR_Row_Index.ViewValue, CR_Row_Index.FormatPattern);
                CR_Row_Index.ViewCustomAttributes = "";

                // CRSS_ID
                CRSS_ID.ViewValue = CRSS_ID.CurrentValue;
                CRSS_ID.ViewValue = FormatNumber(CRSS_ID.ViewValue, CRSS_ID.FormatPattern);
                CRSS_ID.ViewCustomAttributes = "";

                // int_Student_Id
                int_Student_Id.ViewValue = int_Student_Id.CurrentValue;
                int_Student_Id.ViewValue = FormatNumber(int_Student_Id.ViewValue, int_Student_Id.FormatPattern);
                int_Student_Id.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // str_Status
                str_Status.ViewValue = ConvertToString(str_Status.CurrentValue); // DN
                str_Status.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.HrefValue = "";
                str_CR_Number.TooltipValue = "";

                // int_Status
                int_Status.HrefValue = "";
                int_Status.TooltipValue = "";

                // Instructor
                Instructor.HrefValue = "";
                Instructor.TooltipValue = "";

                // Location
                Location.HrefValue = "";
                Location.TooltipValue = "";

                // int_Session_ID
                int_Session_ID.HrefValue = "";
                int_Session_ID.TooltipValue = "";

                // str_Session_Date
                str_Session_Date.HrefValue = "";
                str_Session_Date.TooltipValue = "";

                // int_Day_ID
                int_Day_ID.HrefValue = "";
                int_Day_ID.TooltipValue = "";

                // str_Time_Start
                str_Time_Start.HrefValue = "";
                str_Time_Start.TooltipValue = "";

                // str_Time_End
                str_Time_End.HrefValue = "";
                str_Time_End.TooltipValue = "";

                // str_Session_Notes
                str_Session_Notes.HrefValue = "";
                str_Session_Notes.TooltipValue = "";

                // is_Rescheduled
                is_Rescheduled.HrefValue = "";
                is_Rescheduled.TooltipValue = "";

                // instructorSignature
                if (!IsNull(instructorSignature.Upload.DbValue)) {
                    instructorSignature.HrefValue = AppPath(GetFileUploadUrl(instructorSignature, ConvertToString(RawUrlEncode(int_CRSession_ID.CurrentValue)))); // DN
                    instructorSignature.LinkAttrs["target"] = "";
                    if (instructorSignature.IsBlobImage && Empty(instructorSignature.LinkAttrs["target"]))
                        instructorSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        instructorSignature.HrefValue = FullUrl(ConvertToString(instructorSignature.HrefValue), "href");
                } else {
                    instructorSignature.HrefValue = "";
                }
                instructorSignature.ExportHrefValue = GetFileUploadUrl(instructorSignature, ConvertToString(RawUrlEncode(int_CRSession_ID.CurrentValue)));
                instructorSignature.TooltipValue = "";

                // IsZoomMeet
                IsZoomMeet.HrefValue = "";
                IsZoomMeet.TooltipValue = "";

                // str_ZoomHostUrl
                str_ZoomHostUrl.HrefValue = "";
                str_ZoomHostUrl.TooltipValue = "";

                // str_ZoomUserUrl
                str_ZoomUserUrl.HrefValue = "";
                str_ZoomUserUrl.TooltipValue = "";

                // int_Student_Id
                int_Student_Id.HrefValue = "";
                int_Student_Id.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // str_Status
                str_Status.HrefValue = "";
                str_Status.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblCRSessionsview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblCRSessionsview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblCRSessionsview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblCRSessionsview\" data-ew-action=\"email\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-key='" + HtmlEncode(ConvertToJsonAttribute(RecordKeys)) + "' data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
                int_CRSession_ID.OldValue = keys[0];
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblCrSessionsList")), "", TableVar, true);
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
