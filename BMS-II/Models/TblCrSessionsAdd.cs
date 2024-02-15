namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblCrSessionsAdd
    /// </summary>
    public static TblCrSessionsAdd tblCrSessionsAdd
    {
        get => HttpData.Get<TblCrSessionsAdd>("tblCrSessionsAdd")!;
        set => HttpData["tblCrSessionsAdd"] = value;
    }

    /// <summary>
    /// Page class for tblCRSessions
    /// </summary>
    public class TblCrSessionsAdd : TblCrSessionsAddBase
    {
        // Constructor
        public TblCrSessionsAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblCrSessionsAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblCrSessionsAddBase : TblCrSessions
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblCRSessions";

        // Page object name
        public string PageObjName = "tblCrSessionsAdd";

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
        public TblCrSessionsAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblCrSessions)
            if (tblCrSessions == null || tblCrSessions is TblCrSessions)
                tblCrSessions = this;

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
        public string PageName => "TblCrSessionsAdd";

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
            int_CRSession_ID.Visible = false;
            str_CR_Number.Visible = false;
            int_Status.Visible = false;
            int_Staff_Id.Visible = false;
            Instructor.SetVisibility();
            int_Location_Id.Visible = false;
            Location.SetVisibility();
            int_Session_ID.Visible = false;
            str_Session_Date.Visible = false;
            int_Day_ID.Visible = false;
            str_Day_Name.Visible = false;
            str_Time_Start.Visible = false;
            str_Time_End.Visible = false;
            date_Created.Visible = false;
            int_CR_Id.Visible = false;
            str_Notes.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            date_Modified.Visible = false;
            bit_IsDeleted.Visible = false;
            str_Session_Notes.Visible = false;
            is_Rescheduled.Visible = false;
            instructorSignature.Visible = false;
            IsZoomMeet.Visible = false;
            str_ZoomHostUrl.Visible = false;
            str_ZoomUserUrl.Visible = false;
            CR_Row_Index.Visible = false;
            CRSS_ID.Visible = false;
            int_Student_Id.SetVisibility();
            str_Username.SetVisibility();
            str_Status.SetVisibility();
        }

        // Constructor
        public TblCrSessionsAddBase(Controller? controller = null): this() { // DN
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
        public string FormClassName = "ew-form ew-add-form";

        public bool IsModal = false;

        public bool IsMobileOrModal = false;

        public string DbMasterFilter = "";

        public string DbDetailFilter = "";

        public int StartRecord;

        public DbDataReader? Recordset = null; // Reserved // DN

        public bool CopyRecord;

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
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(IsZoomMeet);

            // Load default values for add
            LoadDefaultValues();

            // Check modal
            if (IsModal)
                SkipHeaderFooter = true;
            IsMobileOrModal = IsMobile() || IsModal;
            bool postBack = false;
            StringValues sv;

            // Set up current action
            if (IsApi()) {
                CurrentAction = "insert"; // Add record directly
                postBack = true;
            } else if (!Empty(Post("action"))) {
                CurrentAction = Post("action"); // Get form action
                if (Post(OldKeyName, out sv))
                    SetKey(sv.ToString());
                postBack = true;
            } else {
                // Load key from QueryString
                string[] keyValues = {};
                object? rv;
                if (RouteValues.TryGetValue("key", out object? k))
                    keyValues = ConvertToString(k).Split('/'); // For Copy page
                if (RouteValues.TryGetValue("int_CRSession_ID", out rv)) { // DN
                    int_CRSession_ID.QueryValue = UrlDecode(rv); // DN
                } else if (Get("int_CRSession_ID", out sv)) {
                    int_CRSession_ID.QueryValue = sv.ToString();
                }
                OldKey = GetKey(true); // Get from CurrentValue
                CopyRecord = !Empty(OldKey);
                if (CopyRecord) {
                    CurrentAction = "copy"; // Copy record
                    SetKey(OldKey); // Set up record key
                } else {
                    CurrentAction = "show"; // Display blank record
                }
            }

            // Load old record / default values
            var rsold = await LoadOldRecord();

            // Load form values
            if (postBack) {
                await LoadFormValues(); // Load form values
            }

            // Validate form if post back
            if (postBack) {
                if (!await ValidateForm()) {
                    EventCancelled = true; // Event cancelled
                    RestoreFormValues(); // Restore form values
                    if (IsApi())
                        return Terminate();
                    else
                        CurrentAction = "show"; // Form error, reset action
                }
            }

            // Perform current action
            switch (CurrentAction) {
                case "copy": // Copy an existing record
                    if (rsold == null) { // Record not loaded
                        if (Empty(FailureMessage))
                            FailureMessage = Language.Phrase("NoRecord"); // No record found
                        return Terminate("TblCrSessionsList"); // No matching record, return to List page // DN
                    }
                    break;
                case "insert": // Add new record // DN
                    SendEmail = true; // Send email on add success
                    var res = await AddRow(rsold);
                    if (res) { // Add successful
                        if (Empty(SuccessMessage) && Post("addopt") != "1") // Skip success message for addopt (done in JavaScript)
                            SuccessMessage = Language.Phrase("AddSuccess"); // Set up success message
                        string returnUrl = "";
                        returnUrl = ReturnUrl;
                        if (GetPageName(returnUrl) == "TblCrSessionsList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "TblCrSessionsView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblCrSessionsList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblCrSessionsList"; // Return list page content
                            }
                        }
                        if (IsJsonResponse()) { // Return to caller
                            ClearMessages(); // Clear messages for Json response
                            return res;
                        } else {
                            return Terminate(returnUrl);
                        }
                    } else if (IsApi()) { // API request, return
                        return Terminate();
                    } else {
                        EventCancelled = true; // Event cancelled
                        RestoreFormValues(); // Add failed, restore form values
                    }
                    break;
            }

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Render row based on row type
            RowType = RowType.Add; // Render add type

            // Render row
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
                tblCrSessionsAdd?.PageRender();
            }
            return PageResult();
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
            IsZoomMeet.DefaultValue = IsZoomMeet.GetDefault(); // DN
            IsZoomMeet.OldValue = IsZoomMeet.DefaultValue;
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'Instructor' before field var 'x_Instructor'
            val = CurrentForm.HasValue("Instructor") ? CurrentForm.GetValue("Instructor") : CurrentForm.GetValue("x_Instructor");
            if (!Instructor.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Instructor") && !CurrentForm.HasValue("x_Instructor")) // DN
                    Instructor.Visible = false; // Disable update for API request
                else
                    Instructor.SetFormValue(val);
            }

            // Check field name 'Location' before field var 'x_Location'
            val = CurrentForm.HasValue("Location") ? CurrentForm.GetValue("Location") : CurrentForm.GetValue("x_Location");
            if (!Location.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Location") && !CurrentForm.HasValue("x_Location")) // DN
                    Location.Visible = false; // Disable update for API request
                else
                    Location.SetFormValue(val);
            }

            // Check field name 'int_Student_Id' before field var 'x_int_Student_Id'
            val = CurrentForm.HasValue("int_Student_Id") ? CurrentForm.GetValue("int_Student_Id") : CurrentForm.GetValue("x_int_Student_Id");
            if (!int_Student_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Student_Id") && !CurrentForm.HasValue("x_int_Student_Id")) // DN
                    int_Student_Id.Visible = false; // Disable update for API request
                else
                    int_Student_Id.SetFormValue(val, true, validate);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }

            // Check field name 'str_Status' before field var 'x_str_Status'
            val = CurrentForm.HasValue("str_Status") ? CurrentForm.GetValue("str_Status") : CurrentForm.GetValue("x_str_Status");
            if (!str_Status.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Status") && !CurrentForm.HasValue("x_str_Status")) // DN
                    str_Status.Visible = false; // Disable update for API request
                else
                    str_Status.SetFormValue(val);
            }

            // Check field name 'int_CRSession_ID' before field var 'x_int_CRSession_ID'
            val = CurrentForm.HasValue("int_CRSession_ID") ? CurrentForm.GetValue("int_CRSession_ID") : CurrentForm.GetValue("x_int_CRSession_ID");
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            Instructor.CurrentValue = Instructor.FormValue;
            Location.CurrentValue = Location.FormValue;
            int_Student_Id.CurrentValue = int_Student_Id.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            str_Status.CurrentValue = str_Status.FormValue;
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

            // int_CRSession_ID
            int_CRSession_ID.RowCssClass = "row";

            // str_CR_Number
            str_CR_Number.RowCssClass = "row";

            // int_Status
            int_Status.RowCssClass = "row";

            // int_Staff_Id
            int_Staff_Id.RowCssClass = "row";

            // Instructor
            Instructor.RowCssClass = "row";

            // int_Location_Id
            int_Location_Id.RowCssClass = "row";

            // Location
            Location.RowCssClass = "row";

            // int_Session_ID
            int_Session_ID.RowCssClass = "row";

            // str_Session_Date
            str_Session_Date.RowCssClass = "row";

            // int_Day_ID
            int_Day_ID.RowCssClass = "row";

            // str_Day_Name
            str_Day_Name.RowCssClass = "row";

            // str_Time_Start
            str_Time_Start.RowCssClass = "row";

            // str_Time_End
            str_Time_End.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // int_CR_Id
            int_CR_Id.RowCssClass = "row";

            // str_Notes
            str_Notes.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // bit_IsDeleted
            bit_IsDeleted.RowCssClass = "row";

            // str_Session_Notes
            str_Session_Notes.RowCssClass = "row";

            // is_Rescheduled
            is_Rescheduled.RowCssClass = "row";

            // instructorSignature
            instructorSignature.RowCssClass = "row";

            // IsZoomMeet
            IsZoomMeet.RowCssClass = "row";

            // str_ZoomHostUrl
            str_ZoomHostUrl.RowCssClass = "row";

            // str_ZoomUserUrl
            str_ZoomUserUrl.RowCssClass = "row";

            // CR_Row_Index
            CR_Row_Index.RowCssClass = "row";

            // CRSS_ID
            CRSS_ID.RowCssClass = "row";

            // int_Student_Id
            int_Student_Id.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // str_Status
            str_Status.RowCssClass = "row";

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

                // Instructor
                Instructor.HrefValue = "";

                // Location
                Location.HrefValue = "";

                // int_Student_Id
                int_Student_Id.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // str_Status
                str_Status.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // Instructor
                Instructor.SetupEditAttributes();
                if (!Instructor.Raw)
                    Instructor.CurrentValue = HtmlDecode(Instructor.CurrentValue);
                Instructor.EditValue = HtmlEncode(Instructor.CurrentValue);
                Instructor.PlaceHolder = RemoveHtml(Instructor.Caption);

                // Location
                Location.SetupEditAttributes();
                if (!Location.Raw)
                    Location.CurrentValue = HtmlDecode(Location.CurrentValue);
                Location.EditValue = HtmlEncode(Location.CurrentValue);
                Location.PlaceHolder = RemoveHtml(Location.Caption);

                // int_Student_Id
                int_Student_Id.SetupEditAttributes();
                int_Student_Id.EditValue = int_Student_Id.CurrentValue; // DN
                int_Student_Id.PlaceHolder = RemoveHtml(int_Student_Id.Caption);
                if (!Empty(int_Student_Id.EditValue) && IsNumeric(int_Student_Id.EditValue))
                    int_Student_Id.EditValue = FormatNumber(int_Student_Id.EditValue, null);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!str_Username.Raw)
                    str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // str_Status
                str_Status.SetupEditAttributes();
                if (!str_Status.Raw)
                    str_Status.CurrentValue = HtmlDecode(str_Status.CurrentValue);
                str_Status.EditValue = HtmlEncode(str_Status.CurrentValue);
                str_Status.PlaceHolder = RemoveHtml(str_Status.Caption);

                // Add refer script

                // Instructor
                Instructor.HrefValue = "";

                // Location
                Location.HrefValue = "";

                // int_Student_Id
                int_Student_Id.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // str_Status
                str_Status.HrefValue = "";
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
            if (Instructor.Required) {
                if (!Instructor.IsDetailKey && Empty(Instructor.FormValue)) {
                    Instructor.AddErrorMessage(ConvertToString(Instructor.RequiredErrorMessage).Replace("%s", Instructor.Caption));
                }
            }
            if (Location.Required) {
                if (!Location.IsDetailKey && Empty(Location.FormValue)) {
                    Location.AddErrorMessage(ConvertToString(Location.RequiredErrorMessage).Replace("%s", Location.Caption));
                }
            }
            if (int_Student_Id.Required) {
                if (!int_Student_Id.IsDetailKey && Empty(int_Student_Id.FormValue)) {
                    int_Student_Id.AddErrorMessage(ConvertToString(int_Student_Id.RequiredErrorMessage).Replace("%s", int_Student_Id.Caption));
                }
            }
            if (!CheckInteger(int_Student_Id.FormValue)) {
                int_Student_Id.AddErrorMessage(int_Student_Id.GetErrorMessage(false));
            }
            if (str_Username.Required) {
                if (!str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (str_Status.Required) {
                if (!str_Status.IsDetailKey && Empty(str_Status.FormValue)) {
                    str_Status.AddErrorMessage(ConvertToString(str_Status.RequiredErrorMessage).Replace("%s", str_Status.Caption));
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

        // Add record
        #pragma warning disable 168, 219

        protected async Task<JsonBoolResult> AddRow(Dictionary<string, object>? rsold = null) { // DN
            bool result = false;

            // Set new row
            Dictionary<string, object> rsnew = new ();
            try {
                // Instructor
                Instructor.SetDbValue(rsnew, Instructor.CurrentValue);

                // Location
                Location.SetDbValue(rsnew, Location.CurrentValue);

                // int_Student_Id
                int_Student_Id.SetDbValue(rsnew, int_Student_Id.CurrentValue);

                // str_Username
                str_Username.SetDbValue(rsnew, str_Username.CurrentValue);

                // str_Status
                str_Status.SetDbValue(rsnew, str_Status.CurrentValue);
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }

            // Update current values
            SetCurrentValues(rsnew);

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
                    rsnew["int_CRSession_ID"] = int_CRSession_ID.CurrentValue!;
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

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblCrSessionsList")), "", TableVar, true);
            string pageId = IsCopy ? "Copy" : "Add";
            breadcrumb.Add("add", pageId, url);
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
