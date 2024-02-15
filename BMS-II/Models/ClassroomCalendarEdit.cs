namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// classroomCalendarEdit
    /// </summary>
    public static ClassroomCalendarEdit classroomCalendarEdit
    {
        get => HttpData.Get<ClassroomCalendarEdit>("classroomCalendarEdit")!;
        set => HttpData["classroomCalendarEdit"] = value;
    }

    /// <summary>
    /// Page class for Classroom_Calendar
    /// </summary>
    public class ClassroomCalendarEdit : ClassroomCalendarEditBase
    {
        // Constructor
        public ClassroomCalendarEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public ClassroomCalendarEdit() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class ClassroomCalendarEditBase : ClassroomCalendar
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Classroom_Calendar";

        // Page object name
        public string PageObjName = "classroomCalendarEdit";

        // Title
        public string? Title = null; // Title for <title> tag

        // Page headings
        public string Heading = "";

        public string Subheading = "";

        public string PageHeader = "";

        public string PageFooter = "";

        // CSS
        public string ReportContainerClass = "ew-grid";

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
        public ClassroomCalendarEditBase()
        {
            // Initialize
            TableVar = "Classroom_Calendar"; // DN
            if (!DashboardReport)
                CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (classroomCalendar)
            if (classroomCalendar == null || classroomCalendar is ClassroomCalendar)
                classroomCalendar = this;

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
                return "";
            }
        }

        // Page name
        public string PageName => "ClassroomCalendarEdit";

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

        // Constructor
        public ClassroomCalendarEditBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("Id") ? dict["Id"] : Id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                Id.Visible = false;
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
                if (RouteValues.TryGetValue("Id", out rv)) { // DN
                    Id.FormValue = UrlDecode(rv); // DN
                    Id.OldValue = Id.FormValue;
                } else if (CurrentForm.HasValue("x_Id")) {
                    Id.FormValue = CurrentForm.GetValue("x_Id");
                    Id.OldValue = Id.FormValue;
                } else if (!Empty(keyValues)) {
                    Id.OldValue = ConvertToString(keyValues[0]);
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
                    if (RouteValues.TryGetValue("Id", out rv)) { // DN
                        Id.QueryValue = UrlDecode(rv); // DN
                        loadByQuery = true;
                    } else if (Get("Id", out sv)) {
                        Id.QueryValue = sv.ToString();
                        loadByQuery = true;
                    } else {
                        Id.CurrentValue = DbNullValue;
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
                Id.FormValue = ConvertToString(keyValues[0]);
            }
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
                            return Terminate(""); // No matching record, return to list
                        }
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = ReturnUrl;
                    if (GetPageName(returnUrl) == "")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = ""; // Return list page content
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
                    }
                    break;
            }

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Render the record
            RowType = RowType.Edit; // Render as Edit
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
                classroomCalendarEdit?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 219

        // Confirm page
        public bool ConfirmPage = false; // DN

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

            // Check field name 'Title' before field var 'x__Title'
            val = CurrentForm.HasValue("Title") ? CurrentForm.GetValue("Title") : CurrentForm.GetValue("x__Title");
            if (!_Title.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Title") && !CurrentForm.HasValue("x__Title")) // DN
                    _Title.Visible = false; // Disable update for API request
                else
                    _Title.SetFormValue(val);
            }

            // Check field name 'Start' before field var 'x_Start'
            val = CurrentForm.HasValue("Start") ? CurrentForm.GetValue("Start") : CurrentForm.GetValue("x_Start");
            if (!Start.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Start") && !CurrentForm.HasValue("x_Start")) // DN
                    Start.Visible = false; // Disable update for API request
                else
                    Start.SetFormValue(val, true, validate);
                Start.CurrentValue = UnformatDateTime(Start.CurrentValue, Start.FormatPattern);
            }

            // Check field name 'End' before field var 'x_End'
            val = CurrentForm.HasValue("End") ? CurrentForm.GetValue("End") : CurrentForm.GetValue("x_End");
            if (!End.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("End") && !CurrentForm.HasValue("x_End")) // DN
                    End.Visible = false; // Disable update for API request
                else
                    End.SetFormValue(val, true, validate);
                End.CurrentValue = UnformatDateTime(End.CurrentValue, End.FormatPattern);
            }

            // Check field name 'AllDay' before field var 'x_AllDay'
            val = CurrentForm.HasValue("AllDay") ? CurrentForm.GetValue("AllDay") : CurrentForm.GetValue("x_AllDay");
            if (!AllDay.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AllDay") && !CurrentForm.HasValue("x_AllDay")) // DN
                    AllDay.Visible = false; // Disable update for API request
                else
                    AllDay.SetFormValue(val);
            }

            // Check field name 'Notes' before field var 'x_Notes'
            val = CurrentForm.HasValue("Notes") ? CurrentForm.GetValue("Notes") : CurrentForm.GetValue("x_Notes");
            if (!Notes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Notes") && !CurrentForm.HasValue("x_Notes")) // DN
                    Notes.Visible = false; // Disable update for API request
                else
                    Notes.SetFormValue(val);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }

            // Check field name 'ClassNames' before field var 'x_ClassNames'
            val = CurrentForm.HasValue("ClassNames") ? CurrentForm.GetValue("ClassNames") : CurrentForm.GetValue("x_ClassNames");
            if (!ClassNames.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("ClassNames") && !CurrentForm.HasValue("x_ClassNames")) // DN
                    ClassNames.Visible = false; // Disable update for API request
                else
                    ClassNames.SetFormValue(val);
            }

            // Check field name 'Display' before field var 'x_Display'
            val = CurrentForm.HasValue("Display") ? CurrentForm.GetValue("Display") : CurrentForm.GetValue("x_Display");
            if (!Display.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Display") && !CurrentForm.HasValue("x_Display")) // DN
                    Display.Visible = false; // Disable update for API request
                else
                    Display.SetFormValue(val);
            }

            // Check field name 'Id' before field var 'x_Id'
            val = CurrentForm.HasValue("Id") ? CurrentForm.GetValue("Id") : CurrentForm.GetValue("x_Id");
            if (!Id.IsDetailKey)
                Id.SetFormValue(val);
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            Id.CurrentValue = Id.FormValue;
            _Title.CurrentValue = _Title.FormValue;
            Start.CurrentValue = Start.FormValue;
            Start.CurrentValue = UnformatDateTime(Start.CurrentValue, Start.FormatPattern);
            End.CurrentValue = End.FormValue;
            End.CurrentValue = UnformatDateTime(End.CurrentValue, End.FormatPattern);
            AllDay.CurrentValue = AllDay.FormValue;
            Notes.CurrentValue = Notes.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            ClassNames.CurrentValue = ClassNames.FormValue;
            Display.CurrentValue = Display.FormValue;
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

            // Check if valid User ID
            if (res) {
                res = ShowOptionLink("edit");
                if (!res)
                    FailureMessage = DeniedMessage();
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
            Id.SetDbValue(row["Id"]);
            _Title.SetDbValue(row["Title"]);
            Start.SetDbValue(row["Start"]);
            End.SetDbValue(row["End"]);
            AllDay.SetDbValue((ConvertToBool(row["AllDay"]) ? "1" : "0"));
            Notes.SetDbValue(row["Notes"]);
            str_Username.SetDbValue(row["str_Username"]);
            _Url.SetDbValue(row["Url"]);
            ClassNames.SetDbValue(row["ClassNames"]);
            Display.SetDbValue(row["Display"]);
            BackgroundColor.SetDbValue(row["BackgroundColor"]);
            CRSS_ID.SetDbValue(row["CRSS_ID"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("Id", Id.DefaultValue ?? DbNullValue); // DN
            row.Add("Title", _Title.DefaultValue ?? DbNullValue); // DN
            row.Add("Start", Start.DefaultValue ?? DbNullValue); // DN
            row.Add("End", End.DefaultValue ?? DbNullValue); // DN
            row.Add("AllDay", AllDay.DefaultValue ?? DbNullValue); // DN
            row.Add("Notes", Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("Url", _Url.DefaultValue ?? DbNullValue); // DN
            row.Add("ClassNames", ClassNames.DefaultValue ?? DbNullValue); // DN
            row.Add("Display", Display.DefaultValue ?? DbNullValue); // DN
            row.Add("BackgroundColor", BackgroundColor.DefaultValue ?? DbNullValue); // DN
            row.Add("CRSS_ID", CRSS_ID.DefaultValue ?? DbNullValue); // DN
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

            // Id
            classroomCalendarEdit.Id.RowCssClass = "row";

            // Title
            classroomCalendarEdit._Title.RowCssClass = "row";

            // Start
            classroomCalendarEdit.Start.RowCssClass = "row";

            // End
            classroomCalendarEdit.End.RowCssClass = "row";

            // AllDay
            classroomCalendarEdit.AllDay.RowCssClass = "row";

            // Notes
            classroomCalendarEdit.Notes.RowCssClass = "row";

            // str_Username
            classroomCalendarEdit.str_Username.RowCssClass = "row";

            // Url
            classroomCalendarEdit._Url.RowCssClass = "row";

            // ClassNames
            classroomCalendarEdit.ClassNames.RowCssClass = "row";

            // Display
            classroomCalendarEdit.Display.RowCssClass = "row";

            // BackgroundColor
            classroomCalendarEdit.BackgroundColor.RowCssClass = "row";

            // CRSS_ID
            classroomCalendarEdit.CRSS_ID.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // Id
                classroomCalendarEdit.Id.ViewValue = classroomCalendarEdit.Id.CurrentValue;
                classroomCalendarEdit.Id.ViewCustomAttributes = "";

                // Title
                curVal = SameString(classroomCalendarEdit._Title.CurrentValue, Config.InitValue) ? "" : ConvertToString(classroomCalendarEdit._Title.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (classroomCalendarEdit._Title.Lookup != null && IsDictionary(classroomCalendarEdit._Title.Lookup?.Options) && classroomCalendarEdit._Title.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        classroomCalendarEdit._Title.ViewValue = classroomCalendarEdit._Title.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Title]", "=", classroomCalendarEdit._Title.CurrentValue, DataType.Memo, "");
                        sqlWrk = classroomCalendarEdit._Title.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && classroomCalendarEdit._Title.Lookup != null) { // Lookup values found
                            var listwrk = classroomCalendarEdit._Title.Lookup?.RenderViewRow(rswrk[0]);
                            classroomCalendarEdit._Title.ViewValue = classroomCalendarEdit._Title.HighlightLookup(ConvertToString(rswrk[0]), classroomCalendarEdit._Title.DisplayValue(listwrk));
                        } else {
                            classroomCalendarEdit._Title.ViewValue = classroomCalendarEdit._Title.CurrentValue;
                        }
                    }
                } else {
                    classroomCalendarEdit._Title.ViewValue = DbNullValue;
                }
                classroomCalendarEdit._Title.ViewCustomAttributes = "";

                // Start
                classroomCalendarEdit.Start.ViewValue = classroomCalendarEdit.Start.CurrentValue;
                classroomCalendarEdit.Start.ViewValue = FormatDateTime(classroomCalendarEdit.Start.ViewValue, classroomCalendarEdit.Start.FormatPattern);
                classroomCalendarEdit.Start.ViewCustomAttributes = "";

                // End
                classroomCalendarEdit.End.ViewValue = classroomCalendarEdit.End.CurrentValue;
                classroomCalendarEdit.End.ViewValue = FormatDateTime(classroomCalendarEdit.End.ViewValue, classroomCalendarEdit.End.FormatPattern);
                classroomCalendarEdit.End.ViewCustomAttributes = "";

                // AllDay
                if (ConvertToBool(classroomCalendarEdit.AllDay.CurrentValue)) {
                    classroomCalendarEdit.AllDay.ViewValue = classroomCalendarEdit.AllDay.TagCaption(1) != "" ? classroomCalendarEdit.AllDay.TagCaption(1) : "Yes";
                } else {
                    classroomCalendarEdit.AllDay.ViewValue = classroomCalendarEdit.AllDay.TagCaption(2) != "" ? classroomCalendarEdit.AllDay.TagCaption(2) : "No";
                }
                classroomCalendarEdit.AllDay.ViewCustomAttributes = "";

                // Notes
                classroomCalendarEdit.Notes.ViewValue = classroomCalendarEdit.Notes.CurrentValue;
                classroomCalendarEdit.Notes.ViewCustomAttributes = "";

                // str_Username
                classroomCalendarEdit.str_Username.ViewValue = classroomCalendarEdit.str_Username.CurrentValue;
                classroomCalendarEdit.str_Username.ViewCustomAttributes = "";

                // Url
                classroomCalendarEdit._Url.ViewValue = ConvertToString(classroomCalendarEdit._Url.CurrentValue); // DN
                classroomCalendarEdit._Url.ViewCustomAttributes = "";

                // ClassNames
                classroomCalendarEdit.ClassNames.ViewValue = ConvertToString(classroomCalendarEdit.ClassNames.CurrentValue); // DN
                classroomCalendarEdit.ClassNames.ViewCustomAttributes = "";

                // Display
                classroomCalendarEdit.Display.ViewValue = ConvertToString(classroomCalendarEdit.Display.CurrentValue); // DN
                classroomCalendarEdit.Display.ViewCustomAttributes = "";

                // BackgroundColor
                classroomCalendarEdit.BackgroundColor.ViewValue = ConvertToString(classroomCalendarEdit.BackgroundColor.CurrentValue); // DN
                classroomCalendarEdit.BackgroundColor.ViewCustomAttributes = "";

                // CRSS_ID
                classroomCalendarEdit.CRSS_ID.ViewValue = classroomCalendarEdit.CRSS_ID.CurrentValue;
                classroomCalendarEdit.CRSS_ID.ViewValue = FormatNumber(classroomCalendarEdit.CRSS_ID.ViewValue, classroomCalendarEdit.CRSS_ID.FormatPattern);
                classroomCalendarEdit.CRSS_ID.ViewCustomAttributes = "";

                // Title
                classroomCalendarEdit._Title.HrefValue = "";

                // Start
                classroomCalendarEdit.Start.HrefValue = "";

                // End
                classroomCalendarEdit.End.HrefValue = "";

                // AllDay
                classroomCalendarEdit.AllDay.HrefValue = "";

                // Notes
                classroomCalendarEdit.Notes.HrefValue = "";

                // str_Username
                classroomCalendarEdit.str_Username.HrefValue = "";

                // ClassNames
                classroomCalendarEdit.ClassNames.HrefValue = "";

                // Display
                classroomCalendarEdit.Display.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // Title
                classroomCalendarEdit._Title.SetupEditAttributes();
                curVal = SameString(classroomCalendarEdit._Title.CurrentValue, Config.InitValue) ? "" : ConvertToString(classroomCalendarEdit._Title.CurrentValue)?.Trim() ?? "";
                if (classroomCalendarEdit._Title.Lookup != null && IsDictionary(classroomCalendarEdit._Title.Lookup?.Options) && classroomCalendarEdit._Title.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    classroomCalendarEdit._Title.EditValue = classroomCalendarEdit._Title.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Title]", "=", classroomCalendarEdit._Title.CurrentValue, DataType.Memo, "");
                    }
                    sqlWrk = classroomCalendarEdit._Title.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    classroomCalendarEdit._Title.EditValue = rswrk;
                }
                classroomCalendarEdit._Title.PlaceHolder = RemoveHtml(classroomCalendarEdit._Title.Caption);

                // Start
                classroomCalendarEdit.Start.SetupEditAttributes();
                classroomCalendarEdit.Start.EditValue = FormatDateTime(classroomCalendarEdit.Start.CurrentValue, classroomCalendarEdit.Start.FormatPattern); // DN
                classroomCalendarEdit.Start.PlaceHolder = RemoveHtml(classroomCalendarEdit.Start.Caption);

                // End
                classroomCalendarEdit.End.SetupEditAttributes();
                classroomCalendarEdit.End.EditValue = FormatDateTime(classroomCalendarEdit.End.CurrentValue, classroomCalendarEdit.End.FormatPattern); // DN
                classroomCalendarEdit.End.PlaceHolder = RemoveHtml(classroomCalendarEdit.End.Caption);

                // AllDay
                classroomCalendarEdit.AllDay.EditValue = classroomCalendarEdit.AllDay.Options(false);
                classroomCalendarEdit.AllDay.PlaceHolder = RemoveHtml(classroomCalendarEdit.AllDay.Caption);

                // Notes
                classroomCalendarEdit.Notes.SetupEditAttributes();
                classroomCalendarEdit.Notes.EditValue = classroomCalendarEdit.Notes.CurrentValue; // DN
                classroomCalendarEdit.Notes.PlaceHolder = RemoveHtml(classroomCalendarEdit.Notes.Caption);

                // str_Username

                // ClassNames
                classroomCalendarEdit.ClassNames.SetupEditAttributes();
                if (!classroomCalendarEdit.ClassNames.Raw)
                    classroomCalendarEdit.ClassNames.CurrentValue = HtmlDecode(classroomCalendarEdit.ClassNames.CurrentValue);
                classroomCalendarEdit.ClassNames.EditValue = HtmlEncode(classroomCalendarEdit.ClassNames.CurrentValue);
                classroomCalendarEdit.ClassNames.PlaceHolder = RemoveHtml(classroomCalendarEdit.ClassNames.Caption);

                // Display
                classroomCalendarEdit.Display.SetupEditAttributes();
                if (!classroomCalendarEdit.Display.Raw)
                    classroomCalendarEdit.Display.CurrentValue = HtmlDecode(classroomCalendarEdit.Display.CurrentValue);
                classroomCalendarEdit.Display.EditValue = HtmlEncode(classroomCalendarEdit.Display.CurrentValue);
                classroomCalendarEdit.Display.PlaceHolder = RemoveHtml(classroomCalendarEdit.Display.Caption);

                // Edit refer script

                // Title
                classroomCalendarEdit._Title.HrefValue = "";

                // Start
                classroomCalendarEdit.Start.HrefValue = "";

                // End
                classroomCalendarEdit.End.HrefValue = "";

                // AllDay
                classroomCalendarEdit.AllDay.HrefValue = "";

                // Notes
                classroomCalendarEdit.Notes.HrefValue = "";

                // str_Username
                classroomCalendarEdit.str_Username.HrefValue = "";

                // ClassNames
                classroomCalendarEdit.ClassNames.HrefValue = "";

                // Display
                classroomCalendarEdit.Display.HrefValue = "";
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
            if (_Title.Required) {
                if (!classroomCalendarEdit._Title.IsDetailKey && Empty(classroomCalendarEdit._Title.FormValue)) {
                    classroomCalendarEdit._Title.AddErrorMessage(ConvertToString(classroomCalendarEdit._Title.RequiredErrorMessage).Replace("%s", classroomCalendarEdit._Title.Caption));
                }
            }
            if (Start.Required) {
                if (!classroomCalendarEdit.Start.IsDetailKey && Empty(classroomCalendarEdit.Start.FormValue)) {
                    classroomCalendarEdit.Start.AddErrorMessage(ConvertToString(classroomCalendarEdit.Start.RequiredErrorMessage).Replace("%s", classroomCalendarEdit.Start.Caption));
                }
            }
            if (!CheckDate(classroomCalendarEdit.Start.FormValue, classroomCalendarEdit.Start.FormatPattern)) {
                classroomCalendarEdit.Start.AddErrorMessage(classroomCalendarEdit.Start.GetErrorMessage(false));
            }
            if (End.Required) {
                if (!classroomCalendarEdit.End.IsDetailKey && Empty(classroomCalendarEdit.End.FormValue)) {
                    classroomCalendarEdit.End.AddErrorMessage(ConvertToString(classroomCalendarEdit.End.RequiredErrorMessage).Replace("%s", classroomCalendarEdit.End.Caption));
                }
            }
            if (!CheckDate(classroomCalendarEdit.End.FormValue, classroomCalendarEdit.End.FormatPattern)) {
                classroomCalendarEdit.End.AddErrorMessage(classroomCalendarEdit.End.GetErrorMessage(false));
            }
            if (AllDay.Required) {
                if (Empty(classroomCalendarEdit.AllDay.FormValue)) {
                    classroomCalendarEdit.AllDay.AddErrorMessage(ConvertToString(classroomCalendarEdit.AllDay.RequiredErrorMessage).Replace("%s", classroomCalendarEdit.AllDay.Caption));
                }
            }
            if (Notes.Required) {
                if (!classroomCalendarEdit.Notes.IsDetailKey && Empty(classroomCalendarEdit.Notes.FormValue)) {
                    classroomCalendarEdit.Notes.AddErrorMessage(ConvertToString(classroomCalendarEdit.Notes.RequiredErrorMessage).Replace("%s", classroomCalendarEdit.Notes.Caption));
                }
            }
            if (str_Username.Required) {
                if (!classroomCalendarEdit.str_Username.IsDetailKey && Empty(classroomCalendarEdit.str_Username.FormValue)) {
                    classroomCalendarEdit.str_Username.AddErrorMessage(ConvertToString(classroomCalendarEdit.str_Username.RequiredErrorMessage).Replace("%s", classroomCalendarEdit.str_Username.Caption));
                }
            }
            if (ClassNames.Required) {
                if (!classroomCalendarEdit.ClassNames.IsDetailKey && Empty(classroomCalendarEdit.ClassNames.FormValue)) {
                    classroomCalendarEdit.ClassNames.AddErrorMessage(ConvertToString(classroomCalendarEdit.ClassNames.RequiredErrorMessage).Replace("%s", classroomCalendarEdit.ClassNames.Caption));
                }
            }
            if (Display.Required) {
                if (!classroomCalendarEdit.Display.IsDetailKey && Empty(classroomCalendarEdit.Display.FormValue)) {
                    classroomCalendarEdit.Display.AddErrorMessage(ConvertToString(classroomCalendarEdit.Display.RequiredErrorMessage).Replace("%s", classroomCalendarEdit.Display.Caption));
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

            // Title
            classroomCalendarEdit._Title.SetDbValue(rsnew, classroomCalendarEdit._Title.CurrentValue, classroomCalendarEdit._Title.ReadOnly);

            // Start
            classroomCalendarEdit.Start.SetDbValue(rsnew, ConvertToDateTime(classroomCalendarEdit.Start.CurrentValue, Start.FormatPattern), classroomCalendarEdit.Start.ReadOnly);

            // End
            classroomCalendarEdit.End.SetDbValue(rsnew, ConvertToDateTime(classroomCalendarEdit.End.CurrentValue, End.FormatPattern), classroomCalendarEdit.End.ReadOnly);

            // AllDay
            classroomCalendarEdit.AllDay.SetDbValue(rsnew, ConvertToBool(classroomCalendarEdit.AllDay.CurrentValue), classroomCalendarEdit.AllDay.ReadOnly);

            // Notes
            classroomCalendarEdit.Notes.SetDbValue(rsnew, classroomCalendarEdit.Notes.CurrentValue, classroomCalendarEdit.Notes.ReadOnly);

            // str_Username
            classroomCalendarEdit.str_Username.CurrentValue = str_Username.GetAutoUpdateValue();
            classroomCalendarEdit.str_Username.SetDbValue(rsnew, classroomCalendarEdit.str_Username.CurrentValue, false);

            // ClassNames
            classroomCalendarEdit.ClassNames.SetDbValue(rsnew, classroomCalendarEdit.ClassNames.CurrentValue, classroomCalendarEdit.ClassNames.ReadOnly);

            // Display
            classroomCalendarEdit.Display.SetDbValue(rsnew, classroomCalendarEdit.Display.CurrentValue, classroomCalendarEdit.Display.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

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
                    string table = UpdateTable;
                    if (FieldByName("Id")?.CurrentValue is var id && id != null) // Get event ID // DN
                        row["id"] = id;
                    d.Add(table, row);
                }
                d.Add("action", Config.ApiEditAction);
                d.Add("version", Config.ProductVersion);
                return new JsonBoolResult(d, true);
            }
            return new JsonBoolResult(d, result);
        }

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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("")), "", TableVar, true);
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
