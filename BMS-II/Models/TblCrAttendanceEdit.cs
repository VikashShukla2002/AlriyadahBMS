namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblCrAttendanceEdit
    /// </summary>
    public static TblCrAttendanceEdit tblCrAttendanceEdit
    {
        get => HttpData.Get<TblCrAttendanceEdit>("tblCrAttendanceEdit")!;
        set => HttpData["tblCrAttendanceEdit"] = value;
    }

    /// <summary>
    /// Page class for tblCRAttendance
    /// </summary>
    public class TblCrAttendanceEdit : TblCrAttendanceEditBase
    {
        // Constructor
        public TblCrAttendanceEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblCrAttendanceEdit() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblCrAttendanceEditBase : TblCrAttendance
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblCRAttendance";

        // Page object name
        public string PageObjName = "tblCrAttendanceEdit";

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
        public TblCrAttendanceEditBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblCrAttendance)
            if (tblCrAttendance == null || tblCrAttendance is TblCrAttendance)
                tblCrAttendance = this;

            // Start time
            StartTime = Environment.TickCount;

            // Debug message
            LoadDebugMessage();

            // Open connection
            Conn = Connection; // DN

            // User table object (tblStudents)
            UserTable = Resolve("usertable")!;
            UserTableConn = GetConnection(UserTable.DbId);
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
        public string PageName => "TblCrAttendanceEdit";

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
            int_Attendance_ID.Visible = false;
            int_Student_ID.Visible = false;
            str_FullName.SetVisibility();
            str_Username.SetVisibility();
            int_CR_ID.SetVisibility();
            int_CRSession_ID.SetVisibility();
            Is_All_Attend.SetVisibility();
            idnumber.SetVisibility();
            course_id.Visible = false;
            str_Test_Score.Visible = false;
            str_Notes.Visible = false;
            bit_IsDeleted.Visible = false;
            int_Created_BY.Visible = false;
            int_Modified_BY.Visible = false;
            date_Created.Visible = false;
            date_Modified.Visible = false;
            bit_IsMakeUP.SetVisibility();
            dec_Orginal_SessionID.Visible = false;
            dec_CR_ID_For_Del.Visible = false;
            int_Session_ID_For_Del.Visible = false;
            RemM1.SetVisibility();
            RemM2.Visible = false;
            RemM3.Visible = false;
            studentSignature.Visible = false;
            SMSReminder1.SetVisibility();
            SMSReminder2.Visible = false;
            SMSReminder3.Visible = false;
            VoiceReminder1.Visible = false;
            VoiceReminder2.Visible = false;
            VoiceReminder3.Visible = false;
            strParentName.Visible = false;
            strParentState.Visible = false;
            strParentLicenseNumber.Visible = false;
            CRSS_ID.Visible = false;
            str_CR_Number.SetVisibility();
        }

        // Constructor
        public TblCrAttendanceEditBase(Controller? controller = null): this() { // DN
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

        public int DisplayRecords = 1; // Number of display records

        public int StartRecord;

        public int StopRecord;

        public int TotalRecords = -1;

        public int RecordRange = 10;

        public int RecordCount;

        public Dictionary<string, string> RecordKeys = new ();

        public string FormClassName = "ew-form ew-edit-form overlay-wrapper";

        public bool IsModal = false;

        public bool IsMobileOrModal = false;

        public string DbMasterFilter = "";

        public string DbDetailFilter = "";

        public DbDataReader? Recordset; // DN

        #pragma warning disable 219
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

            // Create form object
            CurrentForm ??= new ();
            await CurrentForm.Init();
            CurrentAction = Param("action"); // Set up current action
            SetVisibility();
            str_Username.Required = false;
            int_CR_ID.Required = false;
            int_CRSession_ID.Required = false;

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
            IsMobileOrModal = IsMobile() || IsModal;
            bool loaded = false;
            bool postBack = false;
            StringValues sv;
            object? rv;

            // Set up current action and primary key
            if (IsApi()) {
                loaded = true;

                // Load key from form
                string[] keyValues = {};
                if (RouteValues.TryGetValue("key", out object? k))
                    keyValues = ConvertToString(k).Split('/');
                if (RouteValues.TryGetValue("int_Attendance_ID", out rv)) { // DN
                    int_Attendance_ID.FormValue = UrlDecode(rv); // DN
                    int_Attendance_ID.OldValue = int_Attendance_ID.FormValue;
                } else if (CurrentForm.HasValue("x_int_Attendance_ID")) {
                    int_Attendance_ID.FormValue = CurrentForm.GetValue("x_int_Attendance_ID");
                    int_Attendance_ID.OldValue = int_Attendance_ID.FormValue;
                } else if (!Empty(keyValues)) {
                    int_Attendance_ID.OldValue = ConvertToString(keyValues[0]);
                } else {
                    loaded = false; // Unable to load key
                }

                // Load record
                if (loaded)
                    loaded = await LoadRow();
                if (!loaded) {
                    FailureMessage = Language.Phrase("NoRecord"); // Set no record message
                    return Terminate();
                }
                CurrentAction = "update"; // Update record directly
                OldKey = GetKey(true); // Get from CurrentValue
                postBack = true;
            } else {
                if (!Empty(Post("action"))) {
                    CurrentAction = Post("action"); // Get action code
                    if (!IsShow) // Not reload record, handle as postback
                        postBack = true;

                    // Get key from Form
                    if (Post(OldKeyName, out sv))
                        SetKey(sv.ToString(), IsShow);
                } else {
                    CurrentAction = "show"; // Default action is display

                    // Load key from QueryString
                    bool loadByQuery = false;
                    if (RouteValues.TryGetValue("int_Attendance_ID", out rv)) { // DN
                        int_Attendance_ID.QueryValue = UrlDecode(rv); // DN
                        loadByQuery = true;
                    } else if (Get("int_Attendance_ID", out sv)) {
                        int_Attendance_ID.QueryValue = sv.ToString();
                        loadByQuery = true;
                    } else {
                        int_Attendance_ID.CurrentValue = DbNullValue;
                    }
                }

                // Load recordset
                if (IsShow) {
                    // Load current record
                    loaded = await LoadRow();
                OldKey = loaded ? GetKey(true) : ""; // Get from CurrentValue
            }
        }

        // Process form if post back
        if (postBack) {
            await LoadFormValues(); // Get form values
            if (IsApi() && RouteValues.TryGetValue("key", out object? k)) {
                var keyValues = ConvertToString(k).Split('/');
                int_Attendance_ID.FormValue = ConvertToString(keyValues[0]);
            }

            // Set up detail parameters
            SetupDetailParms();
        }

        // Validate form if post back
        if (postBack) {
            if (!await ValidateForm()) {
                EventCancelled = true; // Event cancelled
                RestoreFormValues();
                if (IsApi())
                    return Terminate();
                else
                    CurrentAction = ""; // Form error, reset action
            }
        }

        // Perform current action
        switch (CurrentAction) {
                case "show": // Get a record to display
                        if (!loaded) { // Load record based on key
                            if (Empty(FailureMessage))
                                FailureMessage = Language.Phrase("NoRecord"); // No record found
                            return Terminate("TblCrAttendanceList"); // No matching record, return to list
                        }

                    // Set up detail parameters
                    SetupDetailParms();
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = "";
                    if (!Empty(CurrentDetailTable)) // Master/detail edit
                        returnUrl = GetViewUrl(Config.TableShowDetail + "=" + CurrentDetailTable); // Master/Detail view page
                    else
                        returnUrl = ReturnUrl;
                    if (GetPageName(returnUrl) == "TblCrAttendanceList")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblCrAttendanceList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblCrAttendanceList"; // Return list page content
                            }
                        }
                        if (IsJsonResponse()) {
                            ClearMessages(); // Clear messages for Json response
                            return res;
                        } else {
                            return Terminate(returnUrl); // Return to caller
                        }
                    } else if (IsApi()) { // API request, return
                        return Terminate();
                    } else if (IsModal && UseAjaxActions) { // Return JSON error message
                        return Controller.Json(new { success = false, error = GetFailureMessage() });
                    } else if (FailureMessage == Language.Phrase("NoRecord")) {
                        return Terminate(returnUrl); // Return to caller
                    } else {
                        EventCancelled = true; // Event cancelled
                        RestoreFormValues(); // Restore form values if update failed

                        // Set up detail parameters
                        SetupDetailParms();
                    }
                    break;
            }

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Render the record
            if (IsConfirm) { // Confirm page
                RowType = RowType.View; // Render as View
            } else {
                RowType = RowType.Edit; // Render as Edit
            }
            ResetAttributes();
            await RenderRow();

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                tblCrAttendanceEdit?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 219

        // Confirm page
        public bool ConfirmPage = true; // DN

        #pragma warning disable 1998
        // Get upload files
        public async Task GetUploadFiles()
        {
            // Get upload data
        }
        #pragma warning restore 1998

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'str_FullName' before field var 'x_str_FullName'
            val = CurrentForm.HasValue("str_FullName") ? CurrentForm.GetValue("str_FullName") : CurrentForm.GetValue("x_str_FullName");
            if (!str_FullName.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_FullName") && !CurrentForm.HasValue("x_str_FullName")) // DN
                    str_FullName.Visible = false; // Disable update for API request
                else
                    str_FullName.SetFormValue(val);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }

            // Check field name 'int_CR_ID' before field var 'x_int_CR_ID'
            val = CurrentForm.HasValue("int_CR_ID") ? CurrentForm.GetValue("int_CR_ID") : CurrentForm.GetValue("x_int_CR_ID");
            if (!int_CR_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CR_ID") && !CurrentForm.HasValue("x_int_CR_ID")) // DN
                    int_CR_ID.Visible = false; // Disable update for API request
                else
                    int_CR_ID.SetFormValue(val);
            }

            // Check field name 'int_CRSession_ID' before field var 'x_int_CRSession_ID'
            val = CurrentForm.HasValue("int_CRSession_ID") ? CurrentForm.GetValue("int_CRSession_ID") : CurrentForm.GetValue("x_int_CRSession_ID");
            if (!int_CRSession_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CRSession_ID") && !CurrentForm.HasValue("x_int_CRSession_ID")) // DN
                    int_CRSession_ID.Visible = false; // Disable update for API request
                else
                    int_CRSession_ID.SetFormValue(val);
            }

            // Check field name 'Is_All_Attend' before field var 'x_Is_All_Attend'
            val = CurrentForm.HasValue("Is_All_Attend") ? CurrentForm.GetValue("Is_All_Attend") : CurrentForm.GetValue("x_Is_All_Attend");
            if (!Is_All_Attend.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Is_All_Attend") && !CurrentForm.HasValue("x_Is_All_Attend")) // DN
                    Is_All_Attend.Visible = false; // Disable update for API request
                else
                    Is_All_Attend.SetFormValue(val);
            }

            // Check field name 'idnumber' before field var 'x_idnumber'
            val = CurrentForm.HasValue("idnumber") ? CurrentForm.GetValue("idnumber") : CurrentForm.GetValue("x_idnumber");
            if (!idnumber.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("idnumber") && !CurrentForm.HasValue("x_idnumber")) // DN
                    idnumber.Visible = false; // Disable update for API request
                else
                    idnumber.SetFormValue(val);
            }

            // Check field name 'bit_IsMakeUP' before field var 'x_bit_IsMakeUP'
            val = CurrentForm.HasValue("bit_IsMakeUP") ? CurrentForm.GetValue("bit_IsMakeUP") : CurrentForm.GetValue("x_bit_IsMakeUP");
            if (!bit_IsMakeUP.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsMakeUP") && !CurrentForm.HasValue("x_bit_IsMakeUP")) // DN
                    bit_IsMakeUP.Visible = false; // Disable update for API request
                else
                    bit_IsMakeUP.SetFormValue(val);
            }

            // Check field name 'RemM1' before field var 'x_RemM1'
            val = CurrentForm.HasValue("RemM1") ? CurrentForm.GetValue("RemM1") : CurrentForm.GetValue("x_RemM1");
            if (!RemM1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("RemM1") && !CurrentForm.HasValue("x_RemM1")) // DN
                    RemM1.Visible = false; // Disable update for API request
                else
                    RemM1.SetFormValue(val);
            }

            // Check field name 'SMSReminder1' before field var 'x_SMSReminder1'
            val = CurrentForm.HasValue("SMSReminder1") ? CurrentForm.GetValue("SMSReminder1") : CurrentForm.GetValue("x_SMSReminder1");
            if (!SMSReminder1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("SMSReminder1") && !CurrentForm.HasValue("x_SMSReminder1")) // DN
                    SMSReminder1.Visible = false; // Disable update for API request
                else
                    SMSReminder1.SetFormValue(val);
            }

            // Check field name 'str_CR_Number' before field var 'x_str_CR_Number'
            val = CurrentForm.HasValue("str_CR_Number") ? CurrentForm.GetValue("str_CR_Number") : CurrentForm.GetValue("x_str_CR_Number");
            if (!str_CR_Number.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_CR_Number") && !CurrentForm.HasValue("x_str_CR_Number")) // DN
                    str_CR_Number.Visible = false; // Disable update for API request
                else
                    str_CR_Number.SetFormValue(val);
            }

            // Check field name 'int_Attendance_ID' before field var 'x_int_Attendance_ID'
            val = CurrentForm.HasValue("int_Attendance_ID") ? CurrentForm.GetValue("int_Attendance_ID") : CurrentForm.GetValue("x_int_Attendance_ID");
            if (!int_Attendance_ID.IsDetailKey)
                int_Attendance_ID.SetFormValue(val);
            ResetDetailParms();
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Attendance_ID.CurrentValue = int_Attendance_ID.FormValue;
            str_FullName.CurrentValue = str_FullName.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            int_CR_ID.CurrentValue = int_CR_ID.FormValue;
            int_CRSession_ID.CurrentValue = int_CRSession_ID.FormValue;
            Is_All_Attend.CurrentValue = Is_All_Attend.FormValue;
            idnumber.CurrentValue = idnumber.FormValue;
            bit_IsMakeUP.CurrentValue = bit_IsMakeUP.FormValue;
            RemM1.CurrentValue = RemM1.FormValue;
            SMSReminder1.CurrentValue = SMSReminder1.FormValue;
            str_CR_Number.CurrentValue = str_CR_Number.FormValue;
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

            // int_Attendance_ID
            int_Attendance_ID.RowCssClass = "row";

            // int_Student_ID
            int_Student_ID.RowCssClass = "row";

            // str_FullName
            str_FullName.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // int_CR_ID
            int_CR_ID.RowCssClass = "row";

            // int_CRSession_ID
            int_CRSession_ID.RowCssClass = "row";

            // Is_All_Attend
            Is_All_Attend.RowCssClass = "row";

            // idnumber
            idnumber.RowCssClass = "row";

            // course_id
            course_id.RowCssClass = "row";

            // str_Test_Score
            str_Test_Score.RowCssClass = "row";

            // str_Notes
            str_Notes.RowCssClass = "row";

            // bit_IsDeleted
            bit_IsDeleted.RowCssClass = "row";

            // int_Created_BY
            int_Created_BY.RowCssClass = "row";

            // int_Modified_BY
            int_Modified_BY.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // bit_IsMakeUP
            bit_IsMakeUP.RowCssClass = "row";

            // dec_Orginal_SessionID
            dec_Orginal_SessionID.RowCssClass = "row";

            // dec_CR_ID_For_Del
            dec_CR_ID_For_Del.RowCssClass = "row";

            // int_Session_ID_For_Del
            int_Session_ID_For_Del.RowCssClass = "row";

            // RemM1
            RemM1.RowCssClass = "row";

            // RemM2
            RemM2.RowCssClass = "row";

            // RemM3
            RemM3.RowCssClass = "row";

            // studentSignature
            studentSignature.RowCssClass = "row";

            // SMSReminder1
            SMSReminder1.RowCssClass = "row";

            // SMSReminder2
            SMSReminder2.RowCssClass = "row";

            // SMSReminder3
            SMSReminder3.RowCssClass = "row";

            // VoiceReminder1
            VoiceReminder1.RowCssClass = "row";

            // VoiceReminder2
            VoiceReminder2.RowCssClass = "row";

            // VoiceReminder3
            VoiceReminder3.RowCssClass = "row";

            // strParentName
            strParentName.RowCssClass = "row";

            // strParentState
            strParentState.RowCssClass = "row";

            // strParentLicenseNumber
            strParentLicenseNumber.RowCssClass = "row";

            // CRSS_ID
            CRSS_ID.RowCssClass = "row";

            // str_CR_Number
            str_CR_Number.RowCssClass = "row";

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

                // idnumber
                idnumber.HrefValue = "";
                idnumber.TooltipValue = "";

                // bit_IsMakeUP
                bit_IsMakeUP.HrefValue = "";

                // RemM1
                RemM1.HrefValue = "";

                // SMSReminder1
                SMSReminder1.HrefValue = "";

                // str_CR_Number
                str_CR_Number.HrefValue = "";
                str_CR_Number.TooltipValue = "";
            } else if (RowType == RowType.Edit) {
                // str_FullName
                str_FullName.SetupEditAttributes();
                str_FullName.EditValue = ConvertToString(str_FullName.CurrentValue); // DN
                str_FullName.ViewCustomAttributes = "";

                // str_Username
                str_Username.SetupEditAttributes();
                curVal = ConvertToString(str_Username.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Username.EditValue = str_Username.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                        sqlWrk = str_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Username.Lookup != null) { // Lookup values found
                            var listwrk = str_Username.Lookup?.RenderViewRow(rswrk[0]);
                            str_Username.EditValue = str_Username.HighlightLookup(ConvertToString(rswrk[0]), str_Username.DisplayValue(listwrk));
                        } else {
                            str_Username.EditValue = str_Username.CurrentValue;
                        }
                    }
                } else {
                    str_Username.EditValue = DbNullValue;
                }
                str_Username.ViewCustomAttributes = "";

                // int_CR_ID
                int_CR_ID.SetupEditAttributes();
                int_CR_ID.EditValue = int_CR_ID.CurrentValue;
                int_CR_ID.EditValue = FormatNumber(int_CR_ID.EditValue, int_CR_ID.FormatPattern);
                int_CR_ID.ViewCustomAttributes = "";

                // int_CRSession_ID
                int_CRSession_ID.SetupEditAttributes();
                int_CRSession_ID.EditValue = int_CRSession_ID.CurrentValue;
                int_CRSession_ID.EditValue = FormatNumber(int_CRSession_ID.EditValue, int_CRSession_ID.FormatPattern);
                int_CRSession_ID.ViewCustomAttributes = "";

                // Is_All_Attend
                Is_All_Attend.EditValue = Is_All_Attend.Options(false);
                Is_All_Attend.PlaceHolder = RemoveHtml(Is_All_Attend.Caption);

                // idnumber
                idnumber.SetupEditAttributes();
                idnumber.EditValue = ConvertToString(idnumber.CurrentValue); // DN
                curVal = ConvertToString(idnumber.CurrentValue);
                if (!Empty(curVal)) {
                    if (idnumber.Lookup != null && IsDictionary(idnumber.Lookup?.Options) && idnumber.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        idnumber.EditValue = idnumber.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[course]", "=", idnumber.CurrentValue, DataType.String, "");
                        sqlWrk = idnumber.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && idnumber.Lookup != null) { // Lookup values found
                            var listwrk = idnumber.Lookup?.RenderViewRow(rswrk[0]);
                            idnumber.EditValue = idnumber.HighlightLookup(ConvertToString(rswrk[0]), idnumber.DisplayValue(listwrk));
                        } else {
                            idnumber.EditValue = idnumber.CurrentValue;
                        }
                    }
                } else {
                    idnumber.EditValue = DbNullValue;
                }
                idnumber.ViewCustomAttributes = "";

                // bit_IsMakeUP
                bit_IsMakeUP.EditValue = bit_IsMakeUP.Options(false);
                bit_IsMakeUP.PlaceHolder = RemoveHtml(bit_IsMakeUP.Caption);

                // RemM1
                RemM1.EditValue = RemM1.Options(false);
                RemM1.PlaceHolder = RemoveHtml(RemM1.Caption);

                // SMSReminder1
                SMSReminder1.EditValue = SMSReminder1.Options(false);
                SMSReminder1.PlaceHolder = RemoveHtml(SMSReminder1.Caption);

                // str_CR_Number
                str_CR_Number.SetupEditAttributes();
                curVal = ConvertToString(str_CR_Number.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_CR_Number.Lookup != null && IsDictionary(str_CR_Number.Lookup?.Options) && str_CR_Number.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_CR_Number.EditValue = str_CR_Number.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_CR_Number]", "=", str_CR_Number.CurrentValue, DataType.String, "");
                        sqlWrk = str_CR_Number.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_CR_Number.Lookup != null) { // Lookup values found
                            var listwrk = str_CR_Number.Lookup?.RenderViewRow(rswrk[0]);
                            str_CR_Number.EditValue = str_CR_Number.HighlightLookup(ConvertToString(rswrk[0]), str_CR_Number.DisplayValue(listwrk));
                        } else {
                            str_CR_Number.EditValue = str_CR_Number.CurrentValue;
                        }
                    }
                } else {
                    str_CR_Number.EditValue = DbNullValue;
                }
                str_CR_Number.ViewCustomAttributes = "";

                // Edit refer script

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

                // idnumber
                idnumber.HrefValue = "";
                idnumber.TooltipValue = "";

                // bit_IsMakeUP
                bit_IsMakeUP.HrefValue = "";

                // RemM1
                RemM1.HrefValue = "";

                // SMSReminder1
                SMSReminder1.HrefValue = "";

                // str_CR_Number
                str_CR_Number.HrefValue = "";
                str_CR_Number.TooltipValue = "";
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
            if (str_FullName.Required) {
                if (!str_FullName.IsDetailKey && Empty(str_FullName.FormValue)) {
                    str_FullName.AddErrorMessage(ConvertToString(str_FullName.RequiredErrorMessage).Replace("%s", str_FullName.Caption));
                }
            }
            if (str_Username.Required) {
                if (!str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (int_CR_ID.Required) {
                if (!int_CR_ID.IsDetailKey && Empty(int_CR_ID.FormValue)) {
                    int_CR_ID.AddErrorMessage(ConvertToString(int_CR_ID.RequiredErrorMessage).Replace("%s", int_CR_ID.Caption));
                }
            }
            if (int_CRSession_ID.Required) {
                if (!int_CRSession_ID.IsDetailKey && Empty(int_CRSession_ID.FormValue)) {
                    int_CRSession_ID.AddErrorMessage(ConvertToString(int_CRSession_ID.RequiredErrorMessage).Replace("%s", int_CRSession_ID.Caption));
                }
            }
            if (Is_All_Attend.Required) {
                if (Empty(Is_All_Attend.FormValue)) {
                    Is_All_Attend.AddErrorMessage(ConvertToString(Is_All_Attend.RequiredErrorMessage).Replace("%s", Is_All_Attend.Caption));
                }
            }
            if (idnumber.Required) {
                if (!idnumber.IsDetailKey && Empty(idnumber.FormValue)) {
                    idnumber.AddErrorMessage(ConvertToString(idnumber.RequiredErrorMessage).Replace("%s", idnumber.Caption));
                }
            }
            if (bit_IsMakeUP.Required) {
                if (Empty(bit_IsMakeUP.FormValue)) {
                    bit_IsMakeUP.AddErrorMessage(ConvertToString(bit_IsMakeUP.RequiredErrorMessage).Replace("%s", bit_IsMakeUP.Caption));
                }
            }
            if (RemM1.Required) {
                if (Empty(RemM1.FormValue)) {
                    RemM1.AddErrorMessage(ConvertToString(RemM1.RequiredErrorMessage).Replace("%s", RemM1.Caption));
                }
            }
            if (SMSReminder1.Required) {
                if (Empty(SMSReminder1.FormValue)) {
                    SMSReminder1.AddErrorMessage(ConvertToString(SMSReminder1.RequiredErrorMessage).Replace("%s", SMSReminder1.Caption));
                }
            }
            if (str_CR_Number.Required) {
                if (!str_CR_Number.IsDetailKey && Empty(str_CR_Number.FormValue)) {
                    str_CR_Number.AddErrorMessage(ConvertToString(str_CR_Number.RequiredErrorMessage).Replace("%s", str_CR_Number.Caption));
                }
            }

            // Validate detail grid
            var detailTblVar = CurrentDetailTables;

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

            // Is_All_Attend
            Is_All_Attend.SetDbValue(rsnew, ConvertToBool(Is_All_Attend.CurrentValue), Is_All_Attend.ReadOnly);

            // bit_IsMakeUP
            bit_IsMakeUP.SetDbValue(rsnew, ConvertToBool(bit_IsMakeUP.CurrentValue), bit_IsMakeUP.ReadOnly);

            // RemM1
            RemM1.SetDbValue(rsnew, ConvertToBool(RemM1.CurrentValue), RemM1.ReadOnly);

            // SMSReminder1
            SMSReminder1.SetDbValue(rsnew, ConvertToBool(SMSReminder1.CurrentValue), SMSReminder1.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

            // Begin transaction
            if (!Empty(CurrentDetailTable) && UseTransaction)
                Connection.BeginTrans();

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

                    // Update detail records
                    var detailTblVar = CurrentDetailTables;

                    // Commit/Rollback transaction
                    if (!Empty(CurrentDetailTable) && UseTransaction) {
                        if (result) {
                            Connection.CommitTrans(); // Commit transaction
                        } else {
                            Connection.RollbackTrans(); // Rollback transaction
                        }
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

        // Reset detail parms
        protected void ResetDetailParms() {
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
            string pageId = "edit";
            breadcrumb.Add("edit", pageId, url);
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

        // Form Custom Validate event
        public virtual bool FormCustomValidate(ref string customError) {
            //Return error message in customError
            return true;
        }
    } // End page class
} // End Partial class
