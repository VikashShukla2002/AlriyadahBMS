namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// appointmentCalendarEdit
    /// </summary>
    public static AppointmentCalendarEdit appointmentCalendarEdit
    {
        get => HttpData.Get<AppointmentCalendarEdit>("appointmentCalendarEdit")!;
        set => HttpData["appointmentCalendarEdit"] = value;
    }

    /// <summary>
    /// Page class for Appointment_Calendar
    /// </summary>
    public class AppointmentCalendarEdit : AppointmentCalendarEditBase
    {
        // Constructor
        public AppointmentCalendarEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public AppointmentCalendarEdit() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class AppointmentCalendarEditBase : AppointmentCalendar
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Appointment_Calendar";

        // Page object name
        public string PageObjName = "appointmentCalendarEdit";

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
        public AppointmentCalendarEditBase()
        {
            // Initialize
            TableVar = "Appointment_Calendar"; // DN
            if (!DashboardReport)
                CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (appointmentCalendar)
            if (appointmentCalendar == null || appointmentCalendar is AppointmentCalendar)
                appointmentCalendar = this;

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
        public string PageName => "AppointmentCalendarEdit";

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
        public AppointmentCalendarEditBase(Controller? controller = null): this() { // DN
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
                appointmentCalendarEdit?.PageRender();
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

            // Check field name 'Id' before field var 'x_Id'
            val = CurrentForm.HasValue("Id") ? CurrentForm.GetValue("Id") : CurrentForm.GetValue("x_Id");
            if (!Id.IsDetailKey)
                Id.SetFormValue(val);

            // Check field name 'int_Enrollement_Id' before field var 'x_int_Enrollement_Id'
            val = CurrentForm.HasValue("int_Enrollement_Id") ? CurrentForm.GetValue("int_Enrollement_Id") : CurrentForm.GetValue("x_int_Enrollement_Id");
            if (!int_Enrollement_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Enrollement_Id") && !CurrentForm.HasValue("x_int_Enrollement_Id")) // DN
                    int_Enrollement_Id.Visible = false; // Disable update for API request
                else
                    int_Enrollement_Id.SetFormValue(val);
            }

            // Check field name 'int_PackageID' before field var 'x_int_PackageID'
            val = CurrentForm.HasValue("int_PackageID") ? CurrentForm.GetValue("int_PackageID") : CurrentForm.GetValue("x_int_PackageID");
            if (!int_PackageID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_PackageID") && !CurrentForm.HasValue("x_int_PackageID")) // DN
                    int_PackageID.Visible = false; // Disable update for API request
                else
                    int_PackageID.SetFormValue(val);
            }

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

            // Check field name 'Description' before field var 'x_Description'
            val = CurrentForm.HasValue("Description") ? CurrentForm.GetValue("Description") : CurrentForm.GetValue("x_Description");
            if (!Description.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Description") && !CurrentForm.HasValue("x_Description")) // DN
                    Description.Visible = false; // Disable update for API request
                else
                    Description.SetFormValue(val);
            }

            // Check field name 'Url' before field var 'x__Url'
            val = CurrentForm.HasValue("Url") ? CurrentForm.GetValue("Url") : CurrentForm.GetValue("x__Url");
            if (!_Url.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Url") && !CurrentForm.HasValue("x__Url")) // DN
                    _Url.Visible = false; // Disable update for API request
                else
                    _Url.SetFormValue(val);
            }

            // Check field name 'Display' before field var 'x_Display'
            val = CurrentForm.HasValue("Display") ? CurrentForm.GetValue("Display") : CurrentForm.GetValue("x_Display");
            if (!Display.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Display") && !CurrentForm.HasValue("x_Display")) // DN
                    Display.Visible = false; // Disable update for API request
                else
                    Display.SetFormValue(val);
            }

            // Check field name 'BackgroundColor' before field var 'x_BackgroundColor'
            val = CurrentForm.HasValue("BackgroundColor") ? CurrentForm.GetValue("BackgroundColor") : CurrentForm.GetValue("x_BackgroundColor");
            if (!BackgroundColor.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("BackgroundColor") && !CurrentForm.HasValue("x_BackgroundColor")) // DN
                    BackgroundColor.Visible = false; // Disable update for API request
                else
                    BackgroundColor.SetFormValue(val);
            }

            // Check field name 'CRSS_ID' before field var 'x_CRSS_ID'
            val = CurrentForm.HasValue("CRSS_ID") ? CurrentForm.GetValue("CRSS_ID") : CurrentForm.GetValue("x_CRSS_ID");
            if (!CRSS_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("CRSS_ID") && !CurrentForm.HasValue("x_CRSS_ID")) // DN
                    CRSS_ID.Visible = false; // Disable update for API request
                else
                    CRSS_ID.SetFormValue(val);
            }

            // Check field name 'str_AppointmentType' before field var 'x_str_AppointmentType'
            val = CurrentForm.HasValue("str_AppointmentType") ? CurrentForm.GetValue("str_AppointmentType") : CurrentForm.GetValue("x_str_AppointmentType");
            if (!str_AppointmentType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_AppointmentType") && !CurrentForm.HasValue("x_str_AppointmentType")) // DN
                    str_AppointmentType.Visible = false; // Disable update for API request
                else
                    str_AppointmentType.SetFormValue(val);
            }

            // Check field name 'str_AppointmentStatus' before field var 'x_str_AppointmentStatus'
            val = CurrentForm.HasValue("str_AppointmentStatus") ? CurrentForm.GetValue("str_AppointmentStatus") : CurrentForm.GetValue("x_str_AppointmentStatus");
            if (!str_AppointmentStatus.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_AppointmentStatus") && !CurrentForm.HasValue("x_str_AppointmentStatus")) // DN
                    str_AppointmentStatus.Visible = false; // Disable update for API request
                else
                    str_AppointmentStatus.SetFormValue(val);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            Id.CurrentValue = Id.FormValue;
            int_Enrollement_Id.CurrentValue = int_Enrollement_Id.FormValue;
            int_PackageID.CurrentValue = int_PackageID.FormValue;
            _Title.CurrentValue = _Title.FormValue;
            Start.CurrentValue = Start.FormValue;
            Start.CurrentValue = UnformatDateTime(Start.CurrentValue, Start.FormatPattern);
            End.CurrentValue = End.FormValue;
            End.CurrentValue = UnformatDateTime(End.CurrentValue, End.FormatPattern);
            AllDay.CurrentValue = AllDay.FormValue;
            Description.CurrentValue = Description.FormValue;
            _Url.CurrentValue = _Url.FormValue;
            Display.CurrentValue = Display.FormValue;
            BackgroundColor.CurrentValue = BackgroundColor.FormValue;
            CRSS_ID.CurrentValue = CRSS_ID.FormValue;
            str_AppointmentType.CurrentValue = str_AppointmentType.FormValue;
            str_AppointmentStatus.CurrentValue = str_AppointmentStatus.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
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
            int_Enrollement_Id.SetDbValue(row["int_Enrollement_Id"]);
            int_PackageID.SetDbValue(row["int_PackageID"]);
            _Title.SetDbValue(row["Title"]);
            Start.SetDbValue(row["Start"]);
            End.SetDbValue(row["End"]);
            AllDay.SetDbValue((ConvertToBool(row["AllDay"]) ? "1" : "0"));
            Description.SetDbValue(row["Description"]);
            _Url.SetDbValue(row["Url"]);
            Display.SetDbValue(row["Display"]);
            BackgroundColor.SetDbValue(row["BackgroundColor"]);
            CRSS_ID.SetDbValue(row["CRSS_ID"]);
            str_AppointmentType.SetDbValue(row["str_AppointmentType"]);
            str_AppointmentStatus.SetDbValue(row["str_AppointmentStatus"]);
            str_Username.SetDbValue(row["str_Username"]);
            str_CRSS_IDUSER.SetDbValue(row["str_CRSS_IDUSER"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("Id", Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Enrollement_Id", int_Enrollement_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PackageID", int_PackageID.DefaultValue ?? DbNullValue); // DN
            row.Add("Title", _Title.DefaultValue ?? DbNullValue); // DN
            row.Add("Start", Start.DefaultValue ?? DbNullValue); // DN
            row.Add("End", End.DefaultValue ?? DbNullValue); // DN
            row.Add("AllDay", AllDay.DefaultValue ?? DbNullValue); // DN
            row.Add("Description", Description.DefaultValue ?? DbNullValue); // DN
            row.Add("Url", _Url.DefaultValue ?? DbNullValue); // DN
            row.Add("Display", Display.DefaultValue ?? DbNullValue); // DN
            row.Add("BackgroundColor", BackgroundColor.DefaultValue ?? DbNullValue); // DN
            row.Add("CRSS_ID", CRSS_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AppointmentType", str_AppointmentType.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AppointmentStatus", str_AppointmentStatus.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CRSS_IDUSER", str_CRSS_IDUSER.DefaultValue ?? DbNullValue); // DN
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
            appointmentCalendarEdit.Id.RowCssClass = "row";

            // int_Enrollement_Id
            appointmentCalendarEdit.int_Enrollement_Id.RowCssClass = "row";

            // int_PackageID
            appointmentCalendarEdit.int_PackageID.RowCssClass = "row";

            // Title
            appointmentCalendarEdit._Title.RowCssClass = "row";

            // Start
            appointmentCalendarEdit.Start.RowCssClass = "row";

            // End
            appointmentCalendarEdit.End.RowCssClass = "row";

            // AllDay
            appointmentCalendarEdit.AllDay.RowCssClass = "row";

            // Description
            appointmentCalendarEdit.Description.RowCssClass = "row";

            // Url
            appointmentCalendarEdit._Url.RowCssClass = "row";

            // Display
            appointmentCalendarEdit.Display.RowCssClass = "row";

            // BackgroundColor
            appointmentCalendarEdit.BackgroundColor.RowCssClass = "row";

            // CRSS_ID
            appointmentCalendarEdit.CRSS_ID.RowCssClass = "row";

            // str_AppointmentType
            appointmentCalendarEdit.str_AppointmentType.RowCssClass = "row";

            // str_AppointmentStatus
            appointmentCalendarEdit.str_AppointmentStatus.RowCssClass = "row";

            // str_Username
            appointmentCalendarEdit.str_Username.RowCssClass = "row";

            // str_CRSS_IDUSER
            appointmentCalendarEdit.str_CRSS_IDUSER.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // Id
                appointmentCalendarEdit.Id.ViewValue = appointmentCalendarEdit.Id.CurrentValue;
                appointmentCalendarEdit.Id.ViewCustomAttributes = "";

                // int_Enrollement_Id
                curVal = SameString(appointmentCalendarEdit.int_Enrollement_Id.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarEdit.int_Enrollement_Id.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (appointmentCalendarEdit.int_Enrollement_Id.Lookup != null && IsDictionary(appointmentCalendarEdit.int_Enrollement_Id.Lookup?.Options) && appointmentCalendarEdit.int_Enrollement_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        appointmentCalendarEdit.int_Enrollement_Id.ViewValue = appointmentCalendarEdit.int_Enrollement_Id.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Enrollement_Id]", "=", appointmentCalendarEdit.int_Enrollement_Id.CurrentValue, DataType.Number, "");
                        sqlWrk = appointmentCalendarEdit.int_Enrollement_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && appointmentCalendarEdit.int_Enrollement_Id.Lookup != null) { // Lookup values found
                            var listwrk = appointmentCalendarEdit.int_Enrollement_Id.Lookup?.RenderViewRow(rswrk[0]);
                            appointmentCalendarEdit.int_Enrollement_Id.ViewValue = appointmentCalendarEdit.int_Enrollement_Id.HighlightLookup(ConvertToString(rswrk[0]), appointmentCalendarEdit.int_Enrollement_Id.DisplayValue(listwrk));
                        } else {
                            appointmentCalendarEdit.int_Enrollement_Id.ViewValue = FormatNumber(appointmentCalendarEdit.int_Enrollement_Id.CurrentValue, appointmentCalendarEdit.int_Enrollement_Id.FormatPattern);
                        }
                    }
                } else {
                    appointmentCalendarEdit.int_Enrollement_Id.ViewValue = DbNullValue;
                }
                appointmentCalendarEdit.int_Enrollement_Id.ViewCustomAttributes = "";

                // int_PackageID
                curVal = SameString(appointmentCalendarEdit.int_PackageID.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarEdit.int_PackageID.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (appointmentCalendarEdit.int_PackageID.Lookup != null && IsDictionary(appointmentCalendarEdit.int_PackageID.Lookup?.Options) && appointmentCalendarEdit.int_PackageID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        appointmentCalendarEdit.int_PackageID.ViewValue = appointmentCalendarEdit.int_PackageID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", appointmentCalendarEdit.int_PackageID.CurrentValue, DataType.Number, "");
                        sqlWrk = appointmentCalendarEdit.int_PackageID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && appointmentCalendarEdit.int_PackageID.Lookup != null) { // Lookup values found
                            var listwrk = appointmentCalendarEdit.int_PackageID.Lookup?.RenderViewRow(rswrk[0]);
                            appointmentCalendarEdit.int_PackageID.ViewValue = appointmentCalendarEdit.int_PackageID.HighlightLookup(ConvertToString(rswrk[0]), appointmentCalendarEdit.int_PackageID.DisplayValue(listwrk));
                        } else {
                            appointmentCalendarEdit.int_PackageID.ViewValue = FormatNumber(appointmentCalendarEdit.int_PackageID.CurrentValue, appointmentCalendarEdit.int_PackageID.FormatPattern);
                        }
                    }
                } else {
                    appointmentCalendarEdit.int_PackageID.ViewValue = DbNullValue;
                }
                appointmentCalendarEdit.int_PackageID.ViewCustomAttributes = "";

                // Title
                curVal = SameString(appointmentCalendarEdit._Title.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarEdit._Title.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (appointmentCalendarEdit._Title.Lookup != null && IsDictionary(appointmentCalendarEdit._Title.Lookup?.Options) && appointmentCalendarEdit._Title.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        appointmentCalendarEdit._Title.ViewValue = appointmentCalendarEdit._Title.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Title]", "=", appointmentCalendarEdit._Title.CurrentValue, DataType.String, "");
                        sqlWrk = appointmentCalendarEdit._Title.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && appointmentCalendarEdit._Title.Lookup != null) { // Lookup values found
                            var listwrk = appointmentCalendarEdit._Title.Lookup?.RenderViewRow(rswrk[0]);
                            appointmentCalendarEdit._Title.ViewValue = appointmentCalendarEdit._Title.HighlightLookup(ConvertToString(rswrk[0]), appointmentCalendarEdit._Title.DisplayValue(listwrk));
                        } else {
                            appointmentCalendarEdit._Title.ViewValue = appointmentCalendarEdit._Title.CurrentValue;
                        }
                    }
                } else {
                    appointmentCalendarEdit._Title.ViewValue = DbNullValue;
                }
                appointmentCalendarEdit._Title.ViewCustomAttributes = "";

                // Start
                appointmentCalendarEdit.Start.ViewValue = appointmentCalendarEdit.Start.CurrentValue;
                appointmentCalendarEdit.Start.ViewValue = FormatDateTime(appointmentCalendarEdit.Start.ViewValue, appointmentCalendarEdit.Start.FormatPattern);
                appointmentCalendarEdit.Start.ViewCustomAttributes = "";

                // End
                appointmentCalendarEdit.End.ViewValue = appointmentCalendarEdit.End.CurrentValue;
                appointmentCalendarEdit.End.ViewValue = FormatDateTime(appointmentCalendarEdit.End.ViewValue, appointmentCalendarEdit.End.FormatPattern);
                appointmentCalendarEdit.End.ViewCustomAttributes = "";

                // AllDay
                if (ConvertToBool(appointmentCalendarEdit.AllDay.CurrentValue)) {
                    appointmentCalendarEdit.AllDay.ViewValue = appointmentCalendarEdit.AllDay.TagCaption(1) != "" ? appointmentCalendarEdit.AllDay.TagCaption(1) : "Yes";
                } else {
                    appointmentCalendarEdit.AllDay.ViewValue = appointmentCalendarEdit.AllDay.TagCaption(2) != "" ? appointmentCalendarEdit.AllDay.TagCaption(2) : "No";
                }
                appointmentCalendarEdit.AllDay.ViewCustomAttributes = "";

                // Description
                appointmentCalendarEdit.Description.ViewValue = appointmentCalendarEdit.Description.CurrentValue;
                appointmentCalendarEdit.Description.ViewCustomAttributes = "";

                // Url
                appointmentCalendarEdit._Url.ViewValue = ConvertToString(appointmentCalendarEdit._Url.CurrentValue); // DN
                appointmentCalendarEdit._Url.ViewCustomAttributes = "";

                // Display
                appointmentCalendarEdit.Display.ViewValue = ConvertToString(appointmentCalendarEdit.Display.CurrentValue); // DN
                appointmentCalendarEdit.Display.ViewCustomAttributes = "";

                // BackgroundColor
                appointmentCalendarEdit.BackgroundColor.ViewValue = ConvertToString(appointmentCalendarEdit.BackgroundColor.CurrentValue); // DN
                appointmentCalendarEdit.BackgroundColor.ViewCustomAttributes = "";

                // CRSS_ID
                appointmentCalendarEdit.CRSS_ID.ViewValue = ConvertToString(appointmentCalendarEdit.CRSS_ID.CurrentValue); // DN
                appointmentCalendarEdit.CRSS_ID.ViewCustomAttributes = "";

                // str_AppointmentType
                curVal = SameString(appointmentCalendarEdit.str_AppointmentType.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarEdit.str_AppointmentType.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (appointmentCalendarEdit.str_AppointmentType.Lookup != null && IsDictionary(appointmentCalendarEdit.str_AppointmentType.Lookup?.Options) && appointmentCalendarEdit.str_AppointmentType.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        appointmentCalendarEdit.str_AppointmentType.ViewValue = appointmentCalendarEdit.str_AppointmentType.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Journey]", "=", appointmentCalendarEdit.str_AppointmentType.CurrentValue, DataType.String, "");
                        sqlWrk = appointmentCalendarEdit.str_AppointmentType.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && appointmentCalendarEdit.str_AppointmentType.Lookup != null) { // Lookup values found
                            var listwrk = appointmentCalendarEdit.str_AppointmentType.Lookup?.RenderViewRow(rswrk[0]);
                            appointmentCalendarEdit.str_AppointmentType.ViewValue = appointmentCalendarEdit.str_AppointmentType.HighlightLookup(ConvertToString(rswrk[0]), appointmentCalendarEdit.str_AppointmentType.DisplayValue(listwrk));
                        } else {
                            appointmentCalendarEdit.str_AppointmentType.ViewValue = appointmentCalendarEdit.str_AppointmentType.CurrentValue;
                        }
                    }
                } else {
                    appointmentCalendarEdit.str_AppointmentType.ViewValue = DbNullValue;
                }
                appointmentCalendarEdit.str_AppointmentType.ViewCustomAttributes = "";

                // str_AppointmentStatus
                if (!Empty(appointmentCalendarEdit.str_AppointmentStatus.CurrentValue)) {
                    appointmentCalendarEdit.str_AppointmentStatus.ViewValue = str_AppointmentStatus.HighlightLookup(ConvertToString(appointmentCalendarEdit.str_AppointmentStatus.CurrentValue), appointmentCalendarEdit.str_AppointmentStatus.OptionCaption(ConvertToString(appointmentCalendarEdit.str_AppointmentStatus.CurrentValue)));
                } else {
                    appointmentCalendarEdit.str_AppointmentStatus.ViewValue = DbNullValue;
                }
                appointmentCalendarEdit.str_AppointmentStatus.ViewCustomAttributes = "";

                // str_Username
                appointmentCalendarEdit.str_Username.ViewValue = appointmentCalendarEdit.str_Username.CurrentValue;
                appointmentCalendarEdit.str_Username.ViewCustomAttributes = "";

                // str_CRSS_IDUSER
                appointmentCalendarEdit.str_CRSS_IDUSER.ViewValue = ConvertToString(appointmentCalendarEdit.str_CRSS_IDUSER.CurrentValue); // DN
                appointmentCalendarEdit.str_CRSS_IDUSER.ViewCustomAttributes = "";

                // Id
                appointmentCalendarEdit.Id.HrefValue = "";

                // int_Enrollement_Id
                appointmentCalendarEdit.int_Enrollement_Id.HrefValue = "";

                // int_PackageID
                appointmentCalendarEdit.int_PackageID.HrefValue = "";

                // Title
                appointmentCalendarEdit._Title.HrefValue = "";

                // Start
                appointmentCalendarEdit.Start.HrefValue = "";

                // End
                appointmentCalendarEdit.End.HrefValue = "";

                // AllDay
                appointmentCalendarEdit.AllDay.HrefValue = "";

                // Description
                appointmentCalendarEdit.Description.HrefValue = "";

                // Url
                appointmentCalendarEdit._Url.HrefValue = "";

                // Display
                appointmentCalendarEdit.Display.HrefValue = "";

                // BackgroundColor
                appointmentCalendarEdit.BackgroundColor.HrefValue = "";

                // CRSS_ID
                appointmentCalendarEdit.CRSS_ID.HrefValue = "";

                // str_AppointmentType
                appointmentCalendarEdit.str_AppointmentType.HrefValue = "";

                // str_AppointmentStatus
                appointmentCalendarEdit.str_AppointmentStatus.HrefValue = "";

                // str_Username
                appointmentCalendarEdit.str_Username.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // Id
                appointmentCalendarEdit.Id.SetupEditAttributes();
                appointmentCalendarEdit.Id.EditValue = appointmentCalendarEdit.Id.CurrentValue;
                appointmentCalendarEdit.Id.ViewCustomAttributes = "";

                // int_Enrollement_Id
                appointmentCalendarEdit.int_Enrollement_Id.SetupEditAttributes();
                curVal = SameString(appointmentCalendarEdit.int_Enrollement_Id.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarEdit.int_Enrollement_Id.CurrentValue)?.Trim() ?? "";
                if (appointmentCalendarEdit.int_Enrollement_Id.Lookup != null && IsDictionary(appointmentCalendarEdit.int_Enrollement_Id.Lookup?.Options) && appointmentCalendarEdit.int_Enrollement_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    appointmentCalendarEdit.int_Enrollement_Id.EditValue = appointmentCalendarEdit.int_Enrollement_Id.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Enrollement_Id]", "=", appointmentCalendarEdit.int_Enrollement_Id.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = appointmentCalendarEdit.int_Enrollement_Id.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    appointmentCalendarEdit.int_Enrollement_Id.EditValue = rswrk;
                }
                appointmentCalendarEdit.int_Enrollement_Id.PlaceHolder = RemoveHtml(appointmentCalendarEdit.int_Enrollement_Id.Caption);
                if (!Empty(appointmentCalendarEdit.int_Enrollement_Id.EditValue) && IsNumeric(appointmentCalendarEdit.int_Enrollement_Id.EditValue))
                    appointmentCalendarEdit.int_Enrollement_Id.EditValue = FormatNumber(appointmentCalendarEdit.int_Enrollement_Id.EditValue, null);

                // int_PackageID
                appointmentCalendarEdit.int_PackageID.SetupEditAttributes();
                curVal = SameString(appointmentCalendarEdit.int_PackageID.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarEdit.int_PackageID.CurrentValue)?.Trim() ?? "";
                if (appointmentCalendarEdit.int_PackageID.Lookup != null && IsDictionary(appointmentCalendarEdit.int_PackageID.Lookup?.Options) && appointmentCalendarEdit.int_PackageID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    appointmentCalendarEdit.int_PackageID.EditValue = appointmentCalendarEdit.int_PackageID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Package_Id]", "=", appointmentCalendarEdit.int_PackageID.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = appointmentCalendarEdit.int_PackageID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    appointmentCalendarEdit.int_PackageID.EditValue = rswrk;
                }
                appointmentCalendarEdit.int_PackageID.PlaceHolder = RemoveHtml(appointmentCalendarEdit.int_PackageID.Caption);
                if (!Empty(appointmentCalendarEdit.int_PackageID.EditValue) && IsNumeric(appointmentCalendarEdit.int_PackageID.EditValue))
                    appointmentCalendarEdit.int_PackageID.EditValue = FormatNumber(appointmentCalendarEdit.int_PackageID.EditValue, null);

                // Title
                appointmentCalendarEdit._Title.SetupEditAttributes();
                curVal = SameString(appointmentCalendarEdit._Title.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarEdit._Title.CurrentValue)?.Trim() ?? "";
                if (appointmentCalendarEdit._Title.Lookup != null && IsDictionary(appointmentCalendarEdit._Title.Lookup?.Options) && appointmentCalendarEdit._Title.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    appointmentCalendarEdit._Title.EditValue = appointmentCalendarEdit._Title.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Title]", "=", appointmentCalendarEdit._Title.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = appointmentCalendarEdit._Title.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    appointmentCalendarEdit._Title.EditValue = rswrk;
                }
                appointmentCalendarEdit._Title.PlaceHolder = RemoveHtml(appointmentCalendarEdit._Title.Caption);

                // Start
                appointmentCalendarEdit.Start.SetupEditAttributes();
                appointmentCalendarEdit.Start.EditValue = FormatDateTime(appointmentCalendarEdit.Start.CurrentValue, appointmentCalendarEdit.Start.FormatPattern); // DN
                appointmentCalendarEdit.Start.PlaceHolder = RemoveHtml(appointmentCalendarEdit.Start.Caption);

                // End
                appointmentCalendarEdit.End.SetupEditAttributes();
                appointmentCalendarEdit.End.EditValue = FormatDateTime(appointmentCalendarEdit.End.CurrentValue, appointmentCalendarEdit.End.FormatPattern); // DN
                appointmentCalendarEdit.End.PlaceHolder = RemoveHtml(appointmentCalendarEdit.End.Caption);

                // AllDay
                appointmentCalendarEdit.AllDay.EditValue = appointmentCalendarEdit.AllDay.Options(false);
                appointmentCalendarEdit.AllDay.PlaceHolder = RemoveHtml(appointmentCalendarEdit.AllDay.Caption);

                // Description
                appointmentCalendarEdit.Description.SetupEditAttributes();
                appointmentCalendarEdit.Description.EditValue = appointmentCalendarEdit.Description.CurrentValue; // DN
                appointmentCalendarEdit.Description.PlaceHolder = RemoveHtml(appointmentCalendarEdit.Description.Caption);

                // Url
                appointmentCalendarEdit._Url.SetupEditAttributes();
                if (!appointmentCalendarEdit._Url.Raw)
                    appointmentCalendarEdit._Url.CurrentValue = HtmlDecode(appointmentCalendarEdit._Url.CurrentValue);
                appointmentCalendarEdit._Url.EditValue = HtmlEncode(appointmentCalendarEdit._Url.CurrentValue);
                appointmentCalendarEdit._Url.PlaceHolder = RemoveHtml(appointmentCalendarEdit._Url.Caption);

                // Display
                appointmentCalendarEdit.Display.SetupEditAttributes();
                if (!appointmentCalendarEdit.Display.Raw)
                    appointmentCalendarEdit.Display.CurrentValue = HtmlDecode(appointmentCalendarEdit.Display.CurrentValue);
                appointmentCalendarEdit.Display.EditValue = HtmlEncode(appointmentCalendarEdit.Display.CurrentValue);
                appointmentCalendarEdit.Display.PlaceHolder = RemoveHtml(appointmentCalendarEdit.Display.Caption);

                // BackgroundColor
                appointmentCalendarEdit.BackgroundColor.SetupEditAttributes();
                if (!appointmentCalendarEdit.BackgroundColor.Raw)
                    appointmentCalendarEdit.BackgroundColor.CurrentValue = HtmlDecode(appointmentCalendarEdit.BackgroundColor.CurrentValue);
                appointmentCalendarEdit.BackgroundColor.EditValue = HtmlEncode(appointmentCalendarEdit.BackgroundColor.CurrentValue);
                appointmentCalendarEdit.BackgroundColor.PlaceHolder = RemoveHtml(appointmentCalendarEdit.BackgroundColor.Caption);

                // CRSS_ID
                appointmentCalendarEdit.CRSS_ID.SetupEditAttributes();
                if (!appointmentCalendarEdit.CRSS_ID.Raw)
                    appointmentCalendarEdit.CRSS_ID.CurrentValue = HtmlDecode(appointmentCalendarEdit.CRSS_ID.CurrentValue);
                appointmentCalendarEdit.CRSS_ID.EditValue = HtmlEncode(appointmentCalendarEdit.CRSS_ID.CurrentValue);
                appointmentCalendarEdit.CRSS_ID.PlaceHolder = RemoveHtml(appointmentCalendarEdit.CRSS_ID.Caption);

                // str_AppointmentType
                appointmentCalendarEdit.str_AppointmentType.SetupEditAttributes();
                curVal = SameString(appointmentCalendarEdit.str_AppointmentType.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarEdit.str_AppointmentType.CurrentValue)?.Trim() ?? "";
                if (appointmentCalendarEdit.str_AppointmentType.Lookup != null && IsDictionary(appointmentCalendarEdit.str_AppointmentType.Lookup?.Options) && appointmentCalendarEdit.str_AppointmentType.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    appointmentCalendarEdit.str_AppointmentType.EditValue = appointmentCalendarEdit.str_AppointmentType.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Journey]", "=", appointmentCalendarEdit.str_AppointmentType.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = appointmentCalendarEdit.str_AppointmentType.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    appointmentCalendarEdit.str_AppointmentType.EditValue = rswrk;
                }
                appointmentCalendarEdit.str_AppointmentType.PlaceHolder = RemoveHtml(appointmentCalendarEdit.str_AppointmentType.Caption);

                // str_AppointmentStatus
                appointmentCalendarEdit.str_AppointmentStatus.SetupEditAttributes();
                appointmentCalendarEdit.str_AppointmentStatus.EditValue = appointmentCalendarEdit.str_AppointmentStatus.Options(true);
                appointmentCalendarEdit.str_AppointmentStatus.PlaceHolder = RemoveHtml(appointmentCalendarEdit.str_AppointmentStatus.Caption);

                // str_Username

                // Edit refer script

                // Id
                appointmentCalendarEdit.Id.HrefValue = "";

                // int_Enrollement_Id
                appointmentCalendarEdit.int_Enrollement_Id.HrefValue = "";

                // int_PackageID
                appointmentCalendarEdit.int_PackageID.HrefValue = "";

                // Title
                appointmentCalendarEdit._Title.HrefValue = "";

                // Start
                appointmentCalendarEdit.Start.HrefValue = "";

                // End
                appointmentCalendarEdit.End.HrefValue = "";

                // AllDay
                appointmentCalendarEdit.AllDay.HrefValue = "";

                // Description
                appointmentCalendarEdit.Description.HrefValue = "";

                // Url
                appointmentCalendarEdit._Url.HrefValue = "";

                // Display
                appointmentCalendarEdit.Display.HrefValue = "";

                // BackgroundColor
                appointmentCalendarEdit.BackgroundColor.HrefValue = "";

                // CRSS_ID
                appointmentCalendarEdit.CRSS_ID.HrefValue = "";

                // str_AppointmentType
                appointmentCalendarEdit.str_AppointmentType.HrefValue = "";

                // str_AppointmentStatus
                appointmentCalendarEdit.str_AppointmentStatus.HrefValue = "";

                // str_Username
                appointmentCalendarEdit.str_Username.HrefValue = "";
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
            if (Id.Required) {
                if (!appointmentCalendarEdit.Id.IsDetailKey && Empty(appointmentCalendarEdit.Id.FormValue)) {
                    appointmentCalendarEdit.Id.AddErrorMessage(ConvertToString(appointmentCalendarEdit.Id.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.Id.Caption));
                }
            }
            if (int_Enrollement_Id.Required) {
                if (!appointmentCalendarEdit.int_Enrollement_Id.IsDetailKey && Empty(appointmentCalendarEdit.int_Enrollement_Id.FormValue)) {
                    appointmentCalendarEdit.int_Enrollement_Id.AddErrorMessage(ConvertToString(appointmentCalendarEdit.int_Enrollement_Id.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.int_Enrollement_Id.Caption));
                }
            }
            if (int_PackageID.Required) {
                if (!appointmentCalendarEdit.int_PackageID.IsDetailKey && Empty(appointmentCalendarEdit.int_PackageID.FormValue)) {
                    appointmentCalendarEdit.int_PackageID.AddErrorMessage(ConvertToString(appointmentCalendarEdit.int_PackageID.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.int_PackageID.Caption));
                }
            }
            if (_Title.Required) {
                if (!appointmentCalendarEdit._Title.IsDetailKey && Empty(appointmentCalendarEdit._Title.FormValue)) {
                    appointmentCalendarEdit._Title.AddErrorMessage(ConvertToString(appointmentCalendarEdit._Title.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit._Title.Caption));
                }
            }
            if (Start.Required) {
                if (!appointmentCalendarEdit.Start.IsDetailKey && Empty(appointmentCalendarEdit.Start.FormValue)) {
                    appointmentCalendarEdit.Start.AddErrorMessage(ConvertToString(appointmentCalendarEdit.Start.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.Start.Caption));
                }
            }
            if (!CheckDate(appointmentCalendarEdit.Start.FormValue, appointmentCalendarEdit.Start.FormatPattern)) {
                appointmentCalendarEdit.Start.AddErrorMessage(appointmentCalendarEdit.Start.GetErrorMessage(false));
            }
            if (End.Required) {
                if (!appointmentCalendarEdit.End.IsDetailKey && Empty(appointmentCalendarEdit.End.FormValue)) {
                    appointmentCalendarEdit.End.AddErrorMessage(ConvertToString(appointmentCalendarEdit.End.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.End.Caption));
                }
            }
            if (!CheckDate(appointmentCalendarEdit.End.FormValue, appointmentCalendarEdit.End.FormatPattern)) {
                appointmentCalendarEdit.End.AddErrorMessage(appointmentCalendarEdit.End.GetErrorMessage(false));
            }
            if (AllDay.Required) {
                if (Empty(appointmentCalendarEdit.AllDay.FormValue)) {
                    appointmentCalendarEdit.AllDay.AddErrorMessage(ConvertToString(appointmentCalendarEdit.AllDay.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.AllDay.Caption));
                }
            }
            if (Description.Required) {
                if (!appointmentCalendarEdit.Description.IsDetailKey && Empty(appointmentCalendarEdit.Description.FormValue)) {
                    appointmentCalendarEdit.Description.AddErrorMessage(ConvertToString(appointmentCalendarEdit.Description.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.Description.Caption));
                }
            }
            if (_Url.Required) {
                if (!appointmentCalendarEdit._Url.IsDetailKey && Empty(appointmentCalendarEdit._Url.FormValue)) {
                    appointmentCalendarEdit._Url.AddErrorMessage(ConvertToString(appointmentCalendarEdit._Url.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit._Url.Caption));
                }
            }
            if (Display.Required) {
                if (!appointmentCalendarEdit.Display.IsDetailKey && Empty(appointmentCalendarEdit.Display.FormValue)) {
                    appointmentCalendarEdit.Display.AddErrorMessage(ConvertToString(appointmentCalendarEdit.Display.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.Display.Caption));
                }
            }
            if (BackgroundColor.Required) {
                if (!appointmentCalendarEdit.BackgroundColor.IsDetailKey && Empty(appointmentCalendarEdit.BackgroundColor.FormValue)) {
                    appointmentCalendarEdit.BackgroundColor.AddErrorMessage(ConvertToString(appointmentCalendarEdit.BackgroundColor.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.BackgroundColor.Caption));
                }
            }
            if (CRSS_ID.Required) {
                if (!appointmentCalendarEdit.CRSS_ID.IsDetailKey && Empty(appointmentCalendarEdit.CRSS_ID.FormValue)) {
                    appointmentCalendarEdit.CRSS_ID.AddErrorMessage(ConvertToString(appointmentCalendarEdit.CRSS_ID.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.CRSS_ID.Caption));
                }
            }
            if (str_AppointmentType.Required) {
                if (!appointmentCalendarEdit.str_AppointmentType.IsDetailKey && Empty(appointmentCalendarEdit.str_AppointmentType.FormValue)) {
                    appointmentCalendarEdit.str_AppointmentType.AddErrorMessage(ConvertToString(appointmentCalendarEdit.str_AppointmentType.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.str_AppointmentType.Caption));
                }
            }
            if (str_AppointmentStatus.Required) {
                if (!appointmentCalendarEdit.str_AppointmentStatus.IsDetailKey && Empty(appointmentCalendarEdit.str_AppointmentStatus.FormValue)) {
                    appointmentCalendarEdit.str_AppointmentStatus.AddErrorMessage(ConvertToString(appointmentCalendarEdit.str_AppointmentStatus.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.str_AppointmentStatus.Caption));
                }
            }
            if (str_Username.Required) {
                if (!appointmentCalendarEdit.str_Username.IsDetailKey && Empty(appointmentCalendarEdit.str_Username.FormValue)) {
                    appointmentCalendarEdit.str_Username.AddErrorMessage(ConvertToString(appointmentCalendarEdit.str_Username.RequiredErrorMessage).Replace("%s", appointmentCalendarEdit.str_Username.Caption));
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

            // int_Enrollement_Id
            appointmentCalendarEdit.int_Enrollement_Id.SetDbValue(rsnew, appointmentCalendarEdit.int_Enrollement_Id.CurrentValue, appointmentCalendarEdit.int_Enrollement_Id.ReadOnly);

            // int_PackageID
            appointmentCalendarEdit.int_PackageID.SetDbValue(rsnew, appointmentCalendarEdit.int_PackageID.CurrentValue, appointmentCalendarEdit.int_PackageID.ReadOnly);

            // Title
            appointmentCalendarEdit._Title.SetDbValue(rsnew, appointmentCalendarEdit._Title.CurrentValue, appointmentCalendarEdit._Title.ReadOnly);

            // Start
            appointmentCalendarEdit.Start.SetDbValue(rsnew, ConvertToDateTime(appointmentCalendarEdit.Start.CurrentValue, Start.FormatPattern), appointmentCalendarEdit.Start.ReadOnly);

            // End
            appointmentCalendarEdit.End.SetDbValue(rsnew, ConvertToDateTime(appointmentCalendarEdit.End.CurrentValue, End.FormatPattern), appointmentCalendarEdit.End.ReadOnly);

            // AllDay
            appointmentCalendarEdit.AllDay.SetDbValue(rsnew, ConvertToBool(appointmentCalendarEdit.AllDay.CurrentValue), appointmentCalendarEdit.AllDay.ReadOnly);

            // Description
            appointmentCalendarEdit.Description.SetDbValue(rsnew, appointmentCalendarEdit.Description.CurrentValue, appointmentCalendarEdit.Description.ReadOnly);

            // Url
            appointmentCalendarEdit._Url.SetDbValue(rsnew, appointmentCalendarEdit._Url.CurrentValue, appointmentCalendarEdit._Url.ReadOnly);

            // Display
            appointmentCalendarEdit.Display.SetDbValue(rsnew, appointmentCalendarEdit.Display.CurrentValue, appointmentCalendarEdit.Display.ReadOnly);

            // BackgroundColor
            appointmentCalendarEdit.BackgroundColor.SetDbValue(rsnew, appointmentCalendarEdit.BackgroundColor.CurrentValue, appointmentCalendarEdit.BackgroundColor.ReadOnly);

            // CRSS_ID
            appointmentCalendarEdit.CRSS_ID.SetDbValue(rsnew, appointmentCalendarEdit.CRSS_ID.CurrentValue, appointmentCalendarEdit.CRSS_ID.ReadOnly);

            // str_AppointmentType
            appointmentCalendarEdit.str_AppointmentType.SetDbValue(rsnew, appointmentCalendarEdit.str_AppointmentType.CurrentValue, appointmentCalendarEdit.str_AppointmentType.ReadOnly);

            // str_AppointmentStatus
            appointmentCalendarEdit.str_AppointmentStatus.SetDbValue(rsnew, appointmentCalendarEdit.str_AppointmentStatus.CurrentValue, appointmentCalendarEdit.str_AppointmentStatus.ReadOnly);

            // str_Username
            appointmentCalendarEdit.str_Username.CurrentValue = str_Username.GetAutoUpdateValue();
            appointmentCalendarEdit.str_Username.SetDbValue(rsnew, appointmentCalendarEdit.str_Username.CurrentValue, false);

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
