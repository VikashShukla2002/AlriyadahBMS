namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAppointmentsInfoView
    /// </summary>
    public static TblAppointmentsInfoView tblAppointmentsInfoView
    {
        get => HttpData.Get<TblAppointmentsInfoView>("tblAppointmentsInfoView")!;
        set => HttpData["tblAppointmentsInfoView"] = value;
    }

    /// <summary>
    /// Page class for tblAppointmentsInfo
    /// </summary>
    public class TblAppointmentsInfoView : TblAppointmentsInfoViewBase
    {
        // Constructor
        public TblAppointmentsInfoView(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAppointmentsInfoView() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblAppointmentsInfoViewBase : TblAppointmentsInfo
    {
        // Page ID
        public string PageID = "view";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAppointmentsInfo";

        // Page object name
        public string PageObjName = "tblAppointmentsInfoView";

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
        public TblAppointmentsInfoViewBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-view-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblAppointmentsInfo)
            if (tblAppointmentsInfo == null || tblAppointmentsInfo is TblAppointmentsInfo)
                tblAppointmentsInfo = this;

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
                    RecordKeys["int_Appt_id"] = keys[0];
            } else {
                RecordKeys["int_Appt_id"] = RouteValues.TryGetValue("int_Appt_id", out obj) && obj != null ? UrlDecode(obj) : Get("int_Appt_id"); // DN
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
        public string PageName => "TblAppointmentsInfoView";

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
            int_Appt_id.SetVisibility();
            str_AppName.SetVisibility();
            str_App_Date.SetVisibility();
            str_StartTime.SetVisibility();
            str_EndTime.SetVisibility();
            str_PickupTime.SetVisibility();
            str_DropOffTime.SetVisibility();
            int_VehicleID.SetVisibility();
            dec_InstID.SetVisibility();
            dec_StudentID.SetVisibility();
            dec_Observed_StudentID.SetVisibility();
            int_Apptype.SetVisibility();
            int_AppStatus.SetVisibility();
            mny_AppCost.SetVisibility();
            mny_AmountPaid.SetVisibility();
            bit_CheckAppPaid.SetVisibility();
            bit_Confirmation.SetVisibility();
            str_Instructions.SetVisibility();
            str_Instructions1.SetVisibility();
            str_AppNotes.SetVisibility();
            str_PickupLocation.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_Interval.SetVisibility();
            RemM1.SetVisibility();
            RemM2.SetVisibility();
            RemM3.SetVisibility();
            int_Location_ID.SetVisibility();
            SPID.SetVisibility();
            Chk_Trace.SetVisibility();
            str_DropOffLocation.SetVisibility();
            imgInstructorSignature.SetVisibility();
            imgStudentSignature.SetVisibility();
            imgObserverSignature.SetVisibility();
            dt_apptstart.SetVisibility();
            dt_apptComplete.SetVisibility();
            int_apptstartedBy.SetVisibility();
            int_apptCompletedBy.SetVisibility();
            SMSReminder1.SetVisibility();
            SMSReminder2.SetVisibility();
            SMSReminder3.SetVisibility();
            VoiceReminder1.SetVisibility();
            VoiceReminder2.SetVisibility();
            VoiceReminder3.SetVisibility();
            bit_isroadtest.SetVisibility();
            int_slotType.SetVisibility();
            bit_VisibleOnPortal.SetVisibility();
            IsDataRetrieved.SetVisibility();
            bit_chargesApplied.SetVisibility();
            dec_DistanceTravelled.SetVisibility();
            btwProductIdsforSSRules.SetVisibility();
            int_evaluateApptWithEmail.SetVisibility();
            PublicNotesId.SetVisibility();
            NationalID.SetVisibility();
            str_Username.SetVisibility();
            int_PackageID.SetVisibility();
            int_ApptCldr_ID.SetVisibility();
            str_CRSS_ID.SetVisibility();
        }

        // Constructor
        public TblAppointmentsInfoViewBase(Controller? controller = null): this() { // DN
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Appt_id") ? dict["int_Appt_id"] : int_Appt_id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Appt_id.Visible = false;
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
            if (RouteValues.TryGetValue("int_Appt_id", out v) && !Empty(v)) { // DN
                int_Appt_id.QueryValue = UrlDecode(v); // DN
                RecordKeys["int_Appt_id"] = int_Appt_id.QueryValue;
            } else if (Get("int_Appt_id", out sv)) {
                int_Appt_id.QueryValue = sv.ToString();
                RecordKeys["int_Appt_id"] = int_Appt_id.QueryValue;
            } else if (IsApi() && !Empty(keyValues)) {
                int_Appt_id.QueryValue = ConvertToString(keyValues[0]);
                RecordKeys["int_Appt_id"] = int_Appt_id.QueryValue;
            } else if (!loadCurrentRecord) {
                returnUrl = "TblAppointmentsInfoList"; // Return to list
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
                                return Terminate("TblAppointmentsInfoList"); // Return to list page
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
                tblAppointmentsInfoView?.PageRender();
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
                item.Visible = EditUrl != "" && Security.CanEdit && ShowOptionLink("edit");

            // Copy
            item = option.Add("copy");
            var copyTitle = Language.Phrase("ViewPageCopyLink", true);
            if (IsModal) // Modal
                item.Body = "<a class=\"ew-action ew-copy\" title=\"" + copyTitle + "\" data-caption=\"" + copyTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(AppPath(CopyUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("ViewPageCopyLink") + "</a>";
            else
                item.Body = "<a class=\"ew-action ew-copy\" title=\"" + copyTitle + "\" data-caption=\"" + copyTitle + "\" href=\"" + HtmlEncode(AppPath(CopyUrl)) + "\">" + Language.Phrase("ViewPageCopyLink") + "</a>";
                item.Visible = CopyUrl != "" && Security.CanAdd && ShowOptionLink("add");

            // Delete
            item = option.Add("delete");
            string url = AppPath(DeleteUrl);
            item.Body = "<a class=\"ew-action ew-delete\"" +
                (InlineDelete || IsModal ? " data-ew-action=\"inline-delete\"" : "") +
                " title=\"" + Language.Phrase("ViewPageDeleteLink", true) + "\" data-caption=\"" + Language.Phrase("ViewPageDeleteLink", true) +
                "\" href=\"" + HtmlEncode(url) + "\">" + Language.Phrase("ViewPageDeleteLink") + "</a>";
            item.Visible = DeleteUrl != "" && Security.CanDelete && ShowOptionLink("delete");

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

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            SetupOtherOptions();

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

                // imgInstructorSignature
                if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                    imgInstructorSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgInstructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgInstructorSignature.Upload.DbValue));
                } else {
                    imgInstructorSignature.ViewValue = "";
                }
                imgInstructorSignature.ViewCustomAttributes = "";

                // imgStudentSignature
                if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                    imgStudentSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgStudentSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgStudentSignature.Upload.DbValue));
                } else {
                    imgStudentSignature.ViewValue = "";
                }
                imgStudentSignature.ViewCustomAttributes = "";

                // imgObserverSignature
                if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                    imgObserverSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgObserverSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgObserverSignature.Upload.DbValue));
                } else {
                    imgObserverSignature.ViewValue = "";
                }
                imgObserverSignature.ViewCustomAttributes = "";

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

                // btwProductIdsforSSRules
                btwProductIdsforSSRules.ViewValue = btwProductIdsforSSRules.CurrentValue;
                btwProductIdsforSSRules.ViewCustomAttributes = "";

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.ViewValue = int_evaluateApptWithEmail.CurrentValue;
                int_evaluateApptWithEmail.ViewValue = FormatNumber(int_evaluateApptWithEmail.ViewValue, int_evaluateApptWithEmail.FormatPattern);
                int_evaluateApptWithEmail.ViewCustomAttributes = "";

                // PublicNotesId
                PublicNotesId.ViewValue = PublicNotesId.CurrentValue;
                PublicNotesId.ViewCustomAttributes = "";

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

                // int_Appt_id
                int_Appt_id.HrefValue = "";
                int_Appt_id.TooltipValue = "";

                // str_AppName
                str_AppName.HrefValue = "";
                str_AppName.TooltipValue = "";

                // str_App_Date
                str_App_Date.HrefValue = "";
                str_App_Date.TooltipValue = "";

                // str_StartTime
                str_StartTime.HrefValue = "";
                str_StartTime.TooltipValue = "";

                // str_EndTime
                str_EndTime.HrefValue = "";
                str_EndTime.TooltipValue = "";

                // str_PickupTime
                str_PickupTime.HrefValue = "";
                str_PickupTime.TooltipValue = "";

                // str_DropOffTime
                str_DropOffTime.HrefValue = "";
                str_DropOffTime.TooltipValue = "";

                // int_VehicleID
                int_VehicleID.HrefValue = "";
                int_VehicleID.TooltipValue = "";

                // dec_InstID
                dec_InstID.HrefValue = "";
                dec_InstID.TooltipValue = "";

                // dec_StudentID
                dec_StudentID.HrefValue = "";
                dec_StudentID.TooltipValue = "";

                // dec_Observed_StudentID
                dec_Observed_StudentID.HrefValue = "";
                dec_Observed_StudentID.TooltipValue = "";

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

                // bit_CheckAppPaid
                bit_CheckAppPaid.HrefValue = "";
                bit_CheckAppPaid.TooltipValue = "";

                // bit_Confirmation
                bit_Confirmation.HrefValue = "";
                bit_Confirmation.TooltipValue = "";

                // str_Instructions
                str_Instructions.HrefValue = "";
                str_Instructions.TooltipValue = "";

                // str_Instructions1
                str_Instructions1.HrefValue = "";
                str_Instructions1.TooltipValue = "";

                // str_AppNotes
                str_AppNotes.HrefValue = "";
                str_AppNotes.TooltipValue = "";

                // str_PickupLocation
                str_PickupLocation.HrefValue = "";
                str_PickupLocation.TooltipValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";
                int_Created_By.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";
                int_Modified_By.TooltipValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";
                bit_IsDeleted.TooltipValue = "";

                // str_Interval
                str_Interval.HrefValue = "";
                str_Interval.TooltipValue = "";

                // RemM1
                RemM1.HrefValue = "";
                RemM1.TooltipValue = "";

                // RemM2
                RemM2.HrefValue = "";
                RemM2.TooltipValue = "";

                // RemM3
                RemM3.HrefValue = "";
                RemM3.TooltipValue = "";

                // int_Location_ID
                int_Location_ID.HrefValue = "";
                int_Location_ID.TooltipValue = "";

                // SPID
                SPID.HrefValue = "";
                SPID.TooltipValue = "";

                // Chk_Trace
                Chk_Trace.HrefValue = "";
                Chk_Trace.TooltipValue = "";

                // str_DropOffLocation
                str_DropOffLocation.HrefValue = "";
                str_DropOffLocation.TooltipValue = "";

                // imgInstructorSignature
                if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                    imgInstructorSignature.HrefValue = AppPath(GetFileUploadUrl(imgInstructorSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgInstructorSignature.LinkAttrs["target"] = "";
                    if (imgInstructorSignature.IsBlobImage && Empty(imgInstructorSignature.LinkAttrs["target"]))
                        imgInstructorSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgInstructorSignature.HrefValue = FullUrl(ConvertToString(imgInstructorSignature.HrefValue), "href");
                } else {
                    imgInstructorSignature.HrefValue = "";
                }
                imgInstructorSignature.ExportHrefValue = GetFileUploadUrl(imgInstructorSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));
                imgInstructorSignature.TooltipValue = "";

                // imgStudentSignature
                if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                    imgStudentSignature.HrefValue = AppPath(GetFileUploadUrl(imgStudentSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgStudentSignature.LinkAttrs["target"] = "";
                    if (imgStudentSignature.IsBlobImage && Empty(imgStudentSignature.LinkAttrs["target"]))
                        imgStudentSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgStudentSignature.HrefValue = FullUrl(ConvertToString(imgStudentSignature.HrefValue), "href");
                } else {
                    imgStudentSignature.HrefValue = "";
                }
                imgStudentSignature.ExportHrefValue = GetFileUploadUrl(imgStudentSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));
                imgStudentSignature.TooltipValue = "";

                // imgObserverSignature
                if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                    imgObserverSignature.HrefValue = AppPath(GetFileUploadUrl(imgObserverSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgObserverSignature.LinkAttrs["target"] = "";
                    if (imgObserverSignature.IsBlobImage && Empty(imgObserverSignature.LinkAttrs["target"]))
                        imgObserverSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgObserverSignature.HrefValue = FullUrl(ConvertToString(imgObserverSignature.HrefValue), "href");
                } else {
                    imgObserverSignature.HrefValue = "";
                }
                imgObserverSignature.ExportHrefValue = GetFileUploadUrl(imgObserverSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));
                imgObserverSignature.TooltipValue = "";

                // dt_apptstart
                dt_apptstart.HrefValue = "";
                dt_apptstart.TooltipValue = "";

                // dt_apptComplete
                dt_apptComplete.HrefValue = "";
                dt_apptComplete.TooltipValue = "";

                // int_apptstartedBy
                int_apptstartedBy.HrefValue = "";
                int_apptstartedBy.TooltipValue = "";

                // int_apptCompletedBy
                int_apptCompletedBy.HrefValue = "";
                int_apptCompletedBy.TooltipValue = "";

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

                // bit_isroadtest
                bit_isroadtest.HrefValue = "";
                bit_isroadtest.TooltipValue = "";

                // int_slotType
                int_slotType.HrefValue = "";
                int_slotType.TooltipValue = "";

                // bit_VisibleOnPortal
                bit_VisibleOnPortal.HrefValue = "";
                bit_VisibleOnPortal.TooltipValue = "";

                // IsDataRetrieved
                IsDataRetrieved.HrefValue = "";
                IsDataRetrieved.TooltipValue = "";

                // bit_chargesApplied
                bit_chargesApplied.HrefValue = "";
                bit_chargesApplied.TooltipValue = "";

                // dec_DistanceTravelled
                dec_DistanceTravelled.HrefValue = "";
                dec_DistanceTravelled.TooltipValue = "";

                // btwProductIdsforSSRules
                btwProductIdsforSSRules.HrefValue = "";
                btwProductIdsforSSRules.TooltipValue = "";

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.HrefValue = "";
                int_evaluateApptWithEmail.TooltipValue = "";

                // PublicNotesId
                PublicNotesId.HrefValue = "";
                PublicNotesId.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // int_PackageID
                int_PackageID.HrefValue = "";
                int_PackageID.TooltipValue = "";

                // int_ApptCldr_ID
                int_ApptCldr_ID.HrefValue = "";
                int_ApptCldr_ID.TooltipValue = "";

                // str_CRSS_ID
                str_CRSS_ID.HrefValue = "";
                str_CRSS_ID.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblAppointmentsInfoview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblAppointmentsInfoview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblAppointmentsInfoview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblAppointmentsInfoview\" data-ew-action=\"email\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-key='" + HtmlEncode(ConvertToJsonAttribute(RecordKeys)) + "' data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
                int_Appt_id.OldValue = keys[0];
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblAppointmentsInfoList")), "", TableVar, true);
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
