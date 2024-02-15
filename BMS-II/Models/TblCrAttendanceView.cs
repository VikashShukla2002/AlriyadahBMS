namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblCrAttendanceView
    /// </summary>
    public static TblCrAttendanceView tblCrAttendanceView
    {
        get => HttpData.Get<TblCrAttendanceView>("tblCrAttendanceView")!;
        set => HttpData["tblCrAttendanceView"] = value;
    }

    /// <summary>
    /// Page class for tblCRAttendance
    /// </summary>
    public class TblCrAttendanceView : TblCrAttendanceViewBase
    {
        // Constructor
        public TblCrAttendanceView(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblCrAttendanceView() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblCrAttendanceViewBase : TblCrAttendance
    {
        // Page ID
        public string PageID = "view";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblCRAttendance";

        // Page object name
        public string PageObjName = "tblCrAttendanceView";

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
        public TblCrAttendanceViewBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-view-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblCrAttendance)
            if (tblCrAttendance == null || tblCrAttendance is TblCrAttendance)
                tblCrAttendance = this;

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
                    RecordKeys["int_Attendance_ID"] = keys[0];
            } else {
                RecordKeys["int_Attendance_ID"] = RouteValues.TryGetValue("int_Attendance_ID", out obj) && obj != null ? UrlDecode(obj) : Get("int_Attendance_ID"); // DN
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
        public string PageName => "TblCrAttendanceView";

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
            int_Attendance_ID.SetVisibility();
            int_Student_ID.SetVisibility();
            str_FullName.SetVisibility();
            str_Username.SetVisibility();
            int_CR_ID.SetVisibility();
            int_CRSession_ID.SetVisibility();
            Is_All_Attend.SetVisibility();
            idnumber.SetVisibility();
            course_id.SetVisibility();
            str_Test_Score.SetVisibility();
            str_Notes.SetVisibility();
            bit_IsDeleted.SetVisibility();
            int_Created_BY.SetVisibility();
            int_Modified_BY.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsMakeUP.SetVisibility();
            dec_Orginal_SessionID.SetVisibility();
            dec_CR_ID_For_Del.SetVisibility();
            int_Session_ID_For_Del.SetVisibility();
            RemM1.SetVisibility();
            RemM2.SetVisibility();
            RemM3.SetVisibility();
            studentSignature.SetVisibility();
            SMSReminder1.SetVisibility();
            SMSReminder2.SetVisibility();
            SMSReminder3.SetVisibility();
            VoiceReminder1.SetVisibility();
            VoiceReminder2.SetVisibility();
            VoiceReminder3.SetVisibility();
            strParentName.SetVisibility();
            strParentState.SetVisibility();
            strParentLicenseNumber.SetVisibility();
            CRSS_ID.SetVisibility();
            str_CR_Number.SetVisibility();
        }

        // Constructor
        public TblCrAttendanceViewBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblCrAttendanceView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Attendance_ID") ? dict["int_Attendance_ID"] : int_Attendance_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Attendance_ID.Visible = false;
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
            await SetupLookupOptions(str_Username);
            await SetupLookupOptions(Is_All_Attend);
            await SetupLookupOptions(idnumber);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_IsMakeUP);
            await SetupLookupOptions(RemM1);
            await SetupLookupOptions(RemM2);
            await SetupLookupOptions(RemM3);
            await SetupLookupOptions(SMSReminder1);
            await SetupLookupOptions(SMSReminder2);
            await SetupLookupOptions(SMSReminder3);
            await SetupLookupOptions(VoiceReminder1);
            await SetupLookupOptions(VoiceReminder2);
            await SetupLookupOptions(VoiceReminder3);
            await SetupLookupOptions(str_CR_Number);

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
            if (RouteValues.TryGetValue("int_Attendance_ID", out v) && !Empty(v)) { // DN
                int_Attendance_ID.QueryValue = UrlDecode(v); // DN
                RecordKeys["int_Attendance_ID"] = int_Attendance_ID.QueryValue;
            } else if (Get("int_Attendance_ID", out sv)) {
                int_Attendance_ID.QueryValue = sv.ToString();
                RecordKeys["int_Attendance_ID"] = int_Attendance_ID.QueryValue;
            } else if (IsApi() && !Empty(keyValues)) {
                int_Attendance_ID.QueryValue = ConvertToString(keyValues[0]);
                RecordKeys["int_Attendance_ID"] = int_Attendance_ID.QueryValue;
            } else if (!loadCurrentRecord) {
                returnUrl = "TblCrAttendanceList"; // Return to list
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
                                return Terminate("TblCrAttendanceList"); // Return to list page
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

            // Set up detail parameters
            SetupDetailParms();

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
                tblCrAttendanceView?.PageRender();
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

            // Edit
            item = option.Add("edit");
            var editTitle = Language.Phrase("ViewPageEditLink", true);
            if (IsModal) // Modal
                item.Body = "<a class=\"ew-action ew-edit\" title=\"" + editTitle + "\" data-caption=\"" + editTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("ViewPageEditLink") + "</a>";
            else
                item.Body = "<a class=\"ew-action ew-edit\" title=\"" + editTitle + "\" data-caption=\"" + editTitle + "\" href=\"" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("ViewPageEditLink") + "</a>";
                item.Visible = EditUrl != "" && Security.CanEdit;
            string body = "";
            option = options["detail"];
            string detailTableLink = "";
            string detailViewTblVar = "";
            string detailCopyTblVar = "";
            string detailEditTblVar = "";
            dynamic? detailPage = null;
            string detailFilter = "";

            // "detailreport_Sessions"
            item = option.Add("detailreport_Sessions");
            body = Language.Phrase("ViewPageDetailLink") + Language.TablePhrase("Sessions", "TblCaption");
            body = "<a class=\"btn btn-default btn-sm ew-row-link\" href=\"" + HtmlEncode(AppPath("Sessions?" + Config.TableShowMaster + "=tblCRAttendance&" + ForeignKeyUrl("fk_str_CR_Number", str_CR_Number.CurrentValue) + "")) + "\">" + body + "</a>";
            body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
            item.Body = body;
            item.Visible = Security.AllowList(CurrentProjectID + "Sessions");
            if (item.Visible) {
                if (!Empty(detailTableLink))
                    detailTableLink += ",";
                detailTableLink += "Sessions";
            }
            if (ShowMultipleDetails)
                item.Visible = false;

            // Multiple details
            if (ShowMultipleDetails) {
                body = "<div class=\"btn-group btn-group-sm ew-btn-group\">";
                links = "";
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
                    body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default btn-sm ew-master-detail\" title=\"" + HtmlEncode(Language.Phrase("MultipleMasterDetails", true)) + "\" data-bs-toggle=\"dropdown\">" + Language.Phrase("MultipleMasterDetails") + "</button>";
                    body += "<ul class=\"dropdown-menu ew-dropdown-menu\">" + links + "</ul>";
                }
                body += "</div>";
                // Multiple details
                item = option.Add("details");
                item.Body = body;
            }

            // Set up detail default
            option = options["detail"];
            options["detail"].DropDownButtonPhrase = "ButtonDetails";
            var ar = detailTableLink.Split(',');
            option.UseDropDownButton = (ar.Length > 1);
            option.UseButtonGroup = true;
            item = option.AddGroupOption();
            item.Body = "";
            item.Visible = false;

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
            int_Attendance_ID.SetDbValue(row["int_Attendance_ID"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            str_FullName.SetDbValue(row["str_FullName"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_CR_ID.SetDbValue(row["int_CR_ID"]);
            int_CRSession_ID.SetDbValue(row["int_CRSession_ID"]);
            Is_All_Attend.SetDbValue((ConvertToBool(row["Is_All_Attend"]) ? "1" : "0"));
            idnumber.SetDbValue(row["idnumber"]);
            course_id.SetDbValue(row["course_id"]);
            str_Test_Score.SetDbValue(row["str_Test_Score"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            int_Created_BY.SetDbValue(IsNull(row["int_Created_BY"]) ? DbNullValue : ConvertToDouble(row["int_Created_BY"]));
            int_Modified_BY.SetDbValue(IsNull(row["int_Modified_BY"]) ? DbNullValue : ConvertToDouble(row["int_Modified_BY"]));
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsMakeUP.SetDbValue((ConvertToBool(row["bit_IsMakeUP"]) ? "1" : "0"));
            dec_Orginal_SessionID.SetDbValue(IsNull(row["dec_Orginal_SessionID"]) ? DbNullValue : ConvertToDouble(row["dec_Orginal_SessionID"]));
            dec_CR_ID_For_Del.SetDbValue(IsNull(row["dec_CR_ID_For_Del"]) ? DbNullValue : ConvertToDouble(row["dec_CR_ID_For_Del"]));
            int_Session_ID_For_Del.SetDbValue(row["int_Session_ID_For_Del"]);
            RemM1.SetDbValue((ConvertToBool(row["RemM1"]) ? "1" : "0"));
            RemM2.SetDbValue((ConvertToBool(row["RemM2"]) ? "1" : "0"));
            RemM3.SetDbValue((ConvertToBool(row["RemM3"]) ? "1" : "0"));
            studentSignature.Upload.DbValue = row["studentSignature"];
            SMSReminder1.SetDbValue((ConvertToBool(row["SMSReminder1"]) ? "1" : "0"));
            SMSReminder2.SetDbValue((ConvertToBool(row["SMSReminder2"]) ? "1" : "0"));
            SMSReminder3.SetDbValue((ConvertToBool(row["SMSReminder3"]) ? "1" : "0"));
            VoiceReminder1.SetDbValue((ConvertToBool(row["VoiceReminder1"]) ? "1" : "0"));
            VoiceReminder2.SetDbValue((ConvertToBool(row["VoiceReminder2"]) ? "1" : "0"));
            VoiceReminder3.SetDbValue((ConvertToBool(row["VoiceReminder3"]) ? "1" : "0"));
            strParentName.SetDbValue(row["strParentName"]);
            strParentState.SetDbValue(row["strParentState"]);
            strParentLicenseNumber.SetDbValue(row["strParentLicenseNumber"]);
            CRSS_ID.SetDbValue(row["CRSS_ID"]);
            str_CR_Number.SetDbValue(row["str_CR_Number"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Attendance_ID", int_Attendance_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_FullName", str_FullName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_ID", int_CR_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CRSession_ID", int_CRSession_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Is_All_Attend", Is_All_Attend.DefaultValue ?? DbNullValue); // DN
            row.Add("idnumber", idnumber.DefaultValue ?? DbNullValue); // DN
            row.Add("course_id", course_id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Test_Score", str_Test_Score.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_BY", int_Created_BY.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_BY", int_Modified_BY.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsMakeUP", bit_IsMakeUP.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Orginal_SessionID", dec_Orginal_SessionID.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_CR_ID_For_Del", dec_CR_ID_For_Del.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Session_ID_For_Del", int_Session_ID_For_Del.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM1", RemM1.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM2", RemM2.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM3", RemM3.DefaultValue ?? DbNullValue); // DN
            row.Add("studentSignature", studentSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder1", SMSReminder1.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder2", SMSReminder2.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder3", SMSReminder3.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder1", VoiceReminder1.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder2", VoiceReminder2.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder3", VoiceReminder3.DefaultValue ?? DbNullValue); // DN
            row.Add("strParentName", strParentName.DefaultValue ?? DbNullValue); // DN
            row.Add("strParentState", strParentState.DefaultValue ?? DbNullValue); // DN
            row.Add("strParentLicenseNumber", strParentLicenseNumber.DefaultValue ?? DbNullValue); // DN
            row.Add("CRSS_ID", CRSS_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Number", str_CR_Number.DefaultValue ?? DbNullValue); // DN
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

            // int_Attendance_ID

            // int_Student_ID

            // str_FullName

            // str_Username

            // int_CR_ID

            // int_CRSession_ID

            // Is_All_Attend

            // idnumber

            // course_id

            // str_Test_Score

            // str_Notes

            // bit_IsDeleted

            // int_Created_BY

            // int_Modified_BY

            // date_Created

            // date_Modified

            // bit_IsMakeUP

            // dec_Orginal_SessionID

            // dec_CR_ID_For_Del

            // int_Session_ID_For_Del

            // RemM1

            // RemM2

            // RemM3

            // studentSignature

            // SMSReminder1

            // SMSReminder2

            // SMSReminder3

            // VoiceReminder1

            // VoiceReminder2

            // VoiceReminder3

            // strParentName

            // strParentState

            // strParentLicenseNumber

            // CRSS_ID

            // str_CR_Number

            // View row
            if (RowType == RowType.View) {
                // int_Attendance_ID
                int_Attendance_ID.ViewValue = int_Attendance_ID.CurrentValue;
                int_Attendance_ID.ViewCustomAttributes = "";

                // int_Student_ID
                int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
                int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
                int_Student_ID.ViewCustomAttributes = "";

                // str_FullName
                str_FullName.ViewValue = ConvertToString(str_FullName.CurrentValue); // DN
                str_FullName.ViewCustomAttributes = "";

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

                // int_CR_ID
                int_CR_ID.ViewValue = int_CR_ID.CurrentValue;
                int_CR_ID.ViewValue = FormatNumber(int_CR_ID.ViewValue, int_CR_ID.FormatPattern);
                int_CR_ID.ViewCustomAttributes = "";

                // int_CRSession_ID
                int_CRSession_ID.ViewValue = int_CRSession_ID.CurrentValue;
                int_CRSession_ID.ViewValue = FormatNumber(int_CRSession_ID.ViewValue, int_CRSession_ID.FormatPattern);
                int_CRSession_ID.ViewCustomAttributes = "";

                // Is_All_Attend
                if (ConvertToBool(Is_All_Attend.CurrentValue)) {
                    Is_All_Attend.ViewValue = Is_All_Attend.TagCaption(1) != "" ? Is_All_Attend.TagCaption(1) : "Yes";
                } else {
                    Is_All_Attend.ViewValue = Is_All_Attend.TagCaption(2) != "" ? Is_All_Attend.TagCaption(2) : "No";
                }
                Is_All_Attend.CellCssStyle += "text-align: center;";
                Is_All_Attend.ViewCustomAttributes = "";

                // idnumber
                idnumber.ViewValue = ConvertToString(idnumber.CurrentValue); // DN
                curVal = ConvertToString(idnumber.CurrentValue);
                if (!Empty(curVal)) {
                    if (idnumber.Lookup != null && IsDictionary(idnumber.Lookup?.Options) && idnumber.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        idnumber.ViewValue = idnumber.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[course]", "=", idnumber.CurrentValue, DataType.String, "");
                        sqlWrk = idnumber.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && idnumber.Lookup != null) { // Lookup values found
                            var listwrk = idnumber.Lookup?.RenderViewRow(rswrk[0]);
                            idnumber.ViewValue = idnumber.HighlightLookup(ConvertToString(rswrk[0]), idnumber.DisplayValue(listwrk));
                        } else {
                            idnumber.ViewValue = idnumber.CurrentValue;
                        }
                    }
                } else {
                    idnumber.ViewValue = DbNullValue;
                }
                idnumber.ViewCustomAttributes = "";

                // course_id
                course_id.ViewValue = course_id.CurrentValue;
                course_id.ViewValue = FormatNumber(course_id.ViewValue, course_id.FormatPattern);
                course_id.ViewCustomAttributes = "";

                // str_Test_Score
                str_Test_Score.ViewValue = ConvertToString(str_Test_Score.CurrentValue); // DN
                str_Test_Score.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // bit_IsDeleted
                if (ConvertToBool(bit_IsDeleted.CurrentValue)) {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
                } else {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(2) != "" ? bit_IsDeleted.TagCaption(2) : "No";
                }
                bit_IsDeleted.CellCssStyle += "text-align: center;";
                bit_IsDeleted.ViewCustomAttributes = "";

                // int_Created_BY
                int_Created_BY.ViewValue = int_Created_BY.CurrentValue;
                int_Created_BY.ViewValue = FormatNumber(int_Created_BY.ViewValue, int_Created_BY.FormatPattern);
                int_Created_BY.ViewCustomAttributes = "";

                // int_Modified_BY
                int_Modified_BY.ViewValue = int_Modified_BY.CurrentValue;
                int_Modified_BY.ViewValue = FormatNumber(int_Modified_BY.ViewValue, int_Modified_BY.FormatPattern);
                int_Modified_BY.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // date_Modified
                date_Modified.ViewValue = date_Modified.CurrentValue;
                date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
                date_Modified.ViewCustomAttributes = "";

                // bit_IsMakeUP
                if (ConvertToBool(bit_IsMakeUP.CurrentValue)) {
                    bit_IsMakeUP.ViewValue = bit_IsMakeUP.TagCaption(1) != "" ? bit_IsMakeUP.TagCaption(1) : "Yes";
                } else {
                    bit_IsMakeUP.ViewValue = bit_IsMakeUP.TagCaption(2) != "" ? bit_IsMakeUP.TagCaption(2) : "No";
                }
                bit_IsMakeUP.CellCssStyle += "text-align: center;";
                bit_IsMakeUP.ViewCustomAttributes = "";

                // dec_Orginal_SessionID
                dec_Orginal_SessionID.ViewValue = dec_Orginal_SessionID.CurrentValue;
                dec_Orginal_SessionID.ViewValue = FormatNumber(dec_Orginal_SessionID.ViewValue, dec_Orginal_SessionID.FormatPattern);
                dec_Orginal_SessionID.ViewCustomAttributes = "";

                // dec_CR_ID_For_Del
                dec_CR_ID_For_Del.ViewValue = dec_CR_ID_For_Del.CurrentValue;
                dec_CR_ID_For_Del.ViewValue = FormatNumber(dec_CR_ID_For_Del.ViewValue, dec_CR_ID_For_Del.FormatPattern);
                dec_CR_ID_For_Del.ViewCustomAttributes = "";

                // int_Session_ID_For_Del
                int_Session_ID_For_Del.ViewValue = int_Session_ID_For_Del.CurrentValue;
                int_Session_ID_For_Del.ViewValue = FormatNumber(int_Session_ID_For_Del.ViewValue, int_Session_ID_For_Del.FormatPattern);
                int_Session_ID_For_Del.ViewCustomAttributes = "";

                // RemM1
                if (ConvertToBool(RemM1.CurrentValue)) {
                    RemM1.ViewValue = RemM1.TagCaption(1) != "" ? RemM1.TagCaption(1) : "Yes";
                } else {
                    RemM1.ViewValue = RemM1.TagCaption(2) != "" ? RemM1.TagCaption(2) : "No";
                }
                RemM1.CellCssStyle += "text-align: center;";
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

                // studentSignature
                if (!IsNull(studentSignature.Upload.DbValue)) {
                    studentSignature.ViewValue = RawUrlEncode(int_Attendance_ID.CurrentValue);
                    studentSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])studentSignature.Upload.DbValue));
                } else {
                    studentSignature.ViewValue = "";
                }
                studentSignature.ViewCustomAttributes = "";

                // SMSReminder1
                if (ConvertToBool(SMSReminder1.CurrentValue)) {
                    SMSReminder1.ViewValue = SMSReminder1.TagCaption(1) != "" ? SMSReminder1.TagCaption(1) : "Yes";
                } else {
                    SMSReminder1.ViewValue = SMSReminder1.TagCaption(2) != "" ? SMSReminder1.TagCaption(2) : "No";
                }
                SMSReminder1.CellCssStyle += "text-align: center;";
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

                // strParentName
                strParentName.ViewValue = ConvertToString(strParentName.CurrentValue); // DN
                strParentName.ViewCustomAttributes = "";

                // strParentState
                strParentState.ViewValue = ConvertToString(strParentState.CurrentValue); // DN
                strParentState.ViewCustomAttributes = "";

                // strParentLicenseNumber
                strParentLicenseNumber.ViewValue = ConvertToString(strParentLicenseNumber.CurrentValue); // DN
                strParentLicenseNumber.ViewCustomAttributes = "";

                // CRSS_ID
                CRSS_ID.ViewValue = CRSS_ID.CurrentValue;
                CRSS_ID.ViewValue = FormatNumber(CRSS_ID.ViewValue, CRSS_ID.FormatPattern);
                CRSS_ID.ViewCustomAttributes = "";

                // str_CR_Number
                curVal = ConvertToString(str_CR_Number.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_CR_Number.Lookup != null && IsDictionary(str_CR_Number.Lookup?.Options) && str_CR_Number.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_CR_Number.ViewValue = str_CR_Number.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_CR_Number]", "=", str_CR_Number.CurrentValue, DataType.String, "");
                        sqlWrk = str_CR_Number.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_CR_Number.Lookup != null) { // Lookup values found
                            var listwrk = str_CR_Number.Lookup?.RenderViewRow(rswrk[0]);
                            str_CR_Number.ViewValue = str_CR_Number.HighlightLookup(ConvertToString(rswrk[0]), str_CR_Number.DisplayValue(listwrk));
                        } else {
                            str_CR_Number.ViewValue = str_CR_Number.CurrentValue;
                        }
                    }
                } else {
                    str_CR_Number.ViewValue = DbNullValue;
                }
                str_CR_Number.ViewCustomAttributes = "";

                // int_Attendance_ID
                int_Attendance_ID.HrefValue = "";
                int_Attendance_ID.TooltipValue = "";

                // int_Student_ID
                int_Student_ID.HrefValue = "";
                int_Student_ID.TooltipValue = "";

                // str_FullName
                str_FullName.HrefValue = "";
                str_FullName.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // int_CR_ID
                int_CR_ID.HrefValue = "";
                int_CR_ID.TooltipValue = "";

                // int_CRSession_ID
                int_CRSession_ID.HrefValue = "";
                int_CRSession_ID.TooltipValue = "";

                // Is_All_Attend
                Is_All_Attend.HrefValue = "";
                Is_All_Attend.TooltipValue = "";

                // idnumber
                idnumber.HrefValue = "";
                idnumber.TooltipValue = "";

                // course_id
                course_id.HrefValue = "";
                course_id.TooltipValue = "";

                // str_Test_Score
                str_Test_Score.HrefValue = "";
                str_Test_Score.TooltipValue = "";

                // str_Notes
                str_Notes.HrefValue = "";
                str_Notes.TooltipValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";
                bit_IsDeleted.TooltipValue = "";

                // int_Created_BY
                int_Created_BY.HrefValue = "";
                int_Created_BY.TooltipValue = "";

                // int_Modified_BY
                int_Modified_BY.HrefValue = "";
                int_Modified_BY.TooltipValue = "";

                // date_Created
                date_Created.HrefValue = "";
                date_Created.TooltipValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // bit_IsMakeUP
                bit_IsMakeUP.HrefValue = "";
                bit_IsMakeUP.TooltipValue = "";

                // dec_Orginal_SessionID
                dec_Orginal_SessionID.HrefValue = "";
                dec_Orginal_SessionID.TooltipValue = "";

                // dec_CR_ID_For_Del
                dec_CR_ID_For_Del.HrefValue = "";
                dec_CR_ID_For_Del.TooltipValue = "";

                // int_Session_ID_For_Del
                int_Session_ID_For_Del.HrefValue = "";
                int_Session_ID_For_Del.TooltipValue = "";

                // RemM1
                RemM1.HrefValue = "";
                RemM1.TooltipValue = "";

                // RemM2
                RemM2.HrefValue = "";
                RemM2.TooltipValue = "";

                // RemM3
                RemM3.HrefValue = "";
                RemM3.TooltipValue = "";

                // studentSignature
                if (!IsNull(studentSignature.Upload.DbValue)) {
                    studentSignature.HrefValue = AppPath(GetFileUploadUrl(studentSignature, ConvertToString(RawUrlEncode(int_Attendance_ID.CurrentValue)))); // DN
                    studentSignature.LinkAttrs["target"] = "";
                    if (studentSignature.IsBlobImage && Empty(studentSignature.LinkAttrs["target"]))
                        studentSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        studentSignature.HrefValue = FullUrl(ConvertToString(studentSignature.HrefValue), "href");
                } else {
                    studentSignature.HrefValue = "";
                }
                studentSignature.ExportHrefValue = GetFileUploadUrl(studentSignature, ConvertToString(RawUrlEncode(int_Attendance_ID.CurrentValue)));
                studentSignature.TooltipValue = "";

                // SMSReminder1
                SMSReminder1.HrefValue = "";
                SMSReminder1.TooltipValue = "";

                // SMSReminder2
                SMSReminder2.HrefValue = "";
                SMSReminder2.TooltipValue = "";

                // SMSReminder3
                SMSReminder3.HrefValue = "";
                SMSReminder3.TooltipValue = "";

                // VoiceReminder1
                VoiceReminder1.HrefValue = "";
                VoiceReminder1.TooltipValue = "";

                // VoiceReminder2
                VoiceReminder2.HrefValue = "";
                VoiceReminder2.TooltipValue = "";

                // VoiceReminder3
                VoiceReminder3.HrefValue = "";
                VoiceReminder3.TooltipValue = "";

                // strParentName
                strParentName.HrefValue = "";
                strParentName.TooltipValue = "";

                // strParentState
                strParentState.HrefValue = "";
                strParentState.TooltipValue = "";

                // strParentLicenseNumber
                strParentLicenseNumber.HrefValue = "";
                strParentLicenseNumber.TooltipValue = "";

                // CRSS_ID
                CRSS_ID.HrefValue = "";
                CRSS_ID.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblCRAttendanceview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblCRAttendanceview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblCRAttendanceview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblCRAttendanceview\" data-ew-action=\"email\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-key='" + HtmlEncode(ConvertToJsonAttribute(RecordKeys)) + "' data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
                int_Attendance_ID.OldValue = keys[0];
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
            string exportStyle;

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

        // Set up detail parms based on QueryString
        protected void SetupDetailParms() {
            StringValues detailTblVar = "";
            // Get the keys for master table
            if (Query.TryGetValue(Config.TableShowDetail, out detailTblVar)) { // Do not use Get()
                CurrentDetailTable = detailTblVar.ToString();
            } else {
                detailTblVar = CurrentDetailTable;
            }
            if (!Empty(detailTblVar)) {
                var detailTblVars = detailTblVar.ToString().Split(',');
            }
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblCrAttendanceList")), "", TableVar, true);
            string pageId = "view";
            breadcrumb.Add("view", pageId, url);
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
