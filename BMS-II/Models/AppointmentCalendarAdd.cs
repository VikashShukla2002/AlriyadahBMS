namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// appointmentCalendarAdd
    /// </summary>
    public static AppointmentCalendarAdd appointmentCalendarAdd
    {
        get => HttpData.Get<AppointmentCalendarAdd>("appointmentCalendarAdd")!;
        set => HttpData["appointmentCalendarAdd"] = value;
    }

    /// <summary>
    /// Page class for Appointment_Calendar
    /// </summary>
    public class AppointmentCalendarAdd : AppointmentCalendarAddBase
    {
        // Constructor
        public AppointmentCalendarAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public AppointmentCalendarAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class AppointmentCalendarAddBase : AppointmentCalendar
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Appointment_Calendar";

        // Page object name
        public string PageObjName = "appointmentCalendarAdd";

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
        public AppointmentCalendarAddBase()
        {
            // Initialize
            TableVar = "Appointment_Calendar"; // DN
            if (!DashboardReport)
                CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

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
        public string PageName => "AppointmentCalendarAdd";

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
        public AppointmentCalendarAddBase(Controller? controller = null): this() { // DN
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
                if (RouteValues.TryGetValue("Id", out rv)) { // DN
                    Id.QueryValue = UrlDecode(rv); // DN
                } else if (Get("Id", out sv)) {
                    Id.QueryValue = sv.ToString();
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
                        return Terminate(""); // No matching record, return to List page // DN
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
                        if (GetPageName(returnUrl) == "")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = ""; // Return list page content
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
                appointmentCalendarAdd?.PageRender();
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
            appointmentCalendarAdd.Start.DefaultValue = Param("Start");
            if (Empty(appointmentCalendarAdd.Start.DefaultValue))
                appointmentCalendarAdd.Start.OldValue = appointmentCalendarAdd.Start.DefaultValue;
            appointmentCalendarAdd.End.DefaultValue = Param("End");
            if (Empty(appointmentCalendarAdd.End.DefaultValue))
                appointmentCalendarAdd.End.OldValue = appointmentCalendarAdd.End.DefaultValue;
            appointmentCalendarAdd.AllDay.DefaultValue = Param("AllDay");
            if (Empty(appointmentCalendarAdd.AllDay.DefaultValue))
                appointmentCalendarAdd.AllDay.DefaultValue = appointmentCalendarAdd.AllDay.GetDefault();
            if (Empty(appointmentCalendarAdd.AllDay.DefaultValue))
                appointmentCalendarAdd.AllDay.OldValue = appointmentCalendarAdd.AllDay.DefaultValue;
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

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

            // Check field name 'Id' before field var 'x_Id'
            val = CurrentForm.HasValue("Id") ? CurrentForm.GetValue("Id") : CurrentForm.GetValue("x_Id");
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Enrollement_Id.CurrentValue = int_Enrollement_Id.FormValue;
            int_PackageID.CurrentValue = int_PackageID.FormValue;
            _Title.CurrentValue = _Title.FormValue;
            Start.CurrentValue = Start.FormValue;
            Start.CurrentValue = UnformatDateTime(Start.CurrentValue, Start.FormatPattern);
            End.CurrentValue = End.FormValue;
            End.CurrentValue = UnformatDateTime(End.CurrentValue, End.FormatPattern);
            AllDay.CurrentValue = AllDay.FormValue;
            Description.CurrentValue = Description.FormValue;
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
                res = ShowOptionLink("add");
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
            appointmentCalendarAdd.Id.RowCssClass = "row";

            // int_Enrollement_Id
            appointmentCalendarAdd.int_Enrollement_Id.RowCssClass = "row";

            // int_PackageID
            appointmentCalendarAdd.int_PackageID.RowCssClass = "row";

            // Title
            appointmentCalendarAdd._Title.RowCssClass = "row";

            // Start
            appointmentCalendarAdd.Start.RowCssClass = "row";

            // End
            appointmentCalendarAdd.End.RowCssClass = "row";

            // AllDay
            appointmentCalendarAdd.AllDay.RowCssClass = "row";

            // Description
            appointmentCalendarAdd.Description.RowCssClass = "row";

            // Url
            appointmentCalendarAdd._Url.RowCssClass = "row";

            // Display
            appointmentCalendarAdd.Display.RowCssClass = "row";

            // BackgroundColor
            appointmentCalendarAdd.BackgroundColor.RowCssClass = "row";

            // CRSS_ID
            appointmentCalendarAdd.CRSS_ID.RowCssClass = "row";

            // str_AppointmentType
            appointmentCalendarAdd.str_AppointmentType.RowCssClass = "row";

            // str_AppointmentStatus
            appointmentCalendarAdd.str_AppointmentStatus.RowCssClass = "row";

            // str_Username
            appointmentCalendarAdd.str_Username.RowCssClass = "row";

            // str_CRSS_IDUSER
            appointmentCalendarAdd.str_CRSS_IDUSER.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // Id
                appointmentCalendarAdd.Id.ViewValue = appointmentCalendarAdd.Id.CurrentValue;
                appointmentCalendarAdd.Id.ViewCustomAttributes = "";

                // int_Enrollement_Id
                curVal = SameString(appointmentCalendarAdd.int_Enrollement_Id.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarAdd.int_Enrollement_Id.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (appointmentCalendarAdd.int_Enrollement_Id.Lookup != null && IsDictionary(appointmentCalendarAdd.int_Enrollement_Id.Lookup?.Options) && appointmentCalendarAdd.int_Enrollement_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        appointmentCalendarAdd.int_Enrollement_Id.ViewValue = appointmentCalendarAdd.int_Enrollement_Id.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Enrollement_Id]", "=", appointmentCalendarAdd.int_Enrollement_Id.CurrentValue, DataType.Number, "");
                        sqlWrk = appointmentCalendarAdd.int_Enrollement_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && appointmentCalendarAdd.int_Enrollement_Id.Lookup != null) { // Lookup values found
                            var listwrk = appointmentCalendarAdd.int_Enrollement_Id.Lookup?.RenderViewRow(rswrk[0]);
                            appointmentCalendarAdd.int_Enrollement_Id.ViewValue = appointmentCalendarAdd.int_Enrollement_Id.HighlightLookup(ConvertToString(rswrk[0]), appointmentCalendarAdd.int_Enrollement_Id.DisplayValue(listwrk));
                        } else {
                            appointmentCalendarAdd.int_Enrollement_Id.ViewValue = FormatNumber(appointmentCalendarAdd.int_Enrollement_Id.CurrentValue, appointmentCalendarAdd.int_Enrollement_Id.FormatPattern);
                        }
                    }
                } else {
                    appointmentCalendarAdd.int_Enrollement_Id.ViewValue = DbNullValue;
                }
                appointmentCalendarAdd.int_Enrollement_Id.ViewCustomAttributes = "";

                // int_PackageID
                curVal = SameString(appointmentCalendarAdd.int_PackageID.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarAdd.int_PackageID.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (appointmentCalendarAdd.int_PackageID.Lookup != null && IsDictionary(appointmentCalendarAdd.int_PackageID.Lookup?.Options) && appointmentCalendarAdd.int_PackageID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        appointmentCalendarAdd.int_PackageID.ViewValue = appointmentCalendarAdd.int_PackageID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", appointmentCalendarAdd.int_PackageID.CurrentValue, DataType.Number, "");
                        sqlWrk = appointmentCalendarAdd.int_PackageID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && appointmentCalendarAdd.int_PackageID.Lookup != null) { // Lookup values found
                            var listwrk = appointmentCalendarAdd.int_PackageID.Lookup?.RenderViewRow(rswrk[0]);
                            appointmentCalendarAdd.int_PackageID.ViewValue = appointmentCalendarAdd.int_PackageID.HighlightLookup(ConvertToString(rswrk[0]), appointmentCalendarAdd.int_PackageID.DisplayValue(listwrk));
                        } else {
                            appointmentCalendarAdd.int_PackageID.ViewValue = FormatNumber(appointmentCalendarAdd.int_PackageID.CurrentValue, appointmentCalendarAdd.int_PackageID.FormatPattern);
                        }
                    }
                } else {
                    appointmentCalendarAdd.int_PackageID.ViewValue = DbNullValue;
                }
                appointmentCalendarAdd.int_PackageID.ViewCustomAttributes = "";

                // Title
                curVal = SameString(appointmentCalendarAdd._Title.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarAdd._Title.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (appointmentCalendarAdd._Title.Lookup != null && IsDictionary(appointmentCalendarAdd._Title.Lookup?.Options) && appointmentCalendarAdd._Title.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        appointmentCalendarAdd._Title.ViewValue = appointmentCalendarAdd._Title.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Title]", "=", appointmentCalendarAdd._Title.CurrentValue, DataType.String, "");
                        sqlWrk = appointmentCalendarAdd._Title.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && appointmentCalendarAdd._Title.Lookup != null) { // Lookup values found
                            var listwrk = appointmentCalendarAdd._Title.Lookup?.RenderViewRow(rswrk[0]);
                            appointmentCalendarAdd._Title.ViewValue = appointmentCalendarAdd._Title.HighlightLookup(ConvertToString(rswrk[0]), appointmentCalendarAdd._Title.DisplayValue(listwrk));
                        } else {
                            appointmentCalendarAdd._Title.ViewValue = appointmentCalendarAdd._Title.CurrentValue;
                        }
                    }
                } else {
                    appointmentCalendarAdd._Title.ViewValue = DbNullValue;
                }
                appointmentCalendarAdd._Title.ViewCustomAttributes = "";

                // Start
                appointmentCalendarAdd.Start.ViewValue = appointmentCalendarAdd.Start.CurrentValue;
                appointmentCalendarAdd.Start.ViewValue = FormatDateTime(appointmentCalendarAdd.Start.ViewValue, appointmentCalendarAdd.Start.FormatPattern);
                appointmentCalendarAdd.Start.ViewCustomAttributes = "";

                // End
                appointmentCalendarAdd.End.ViewValue = appointmentCalendarAdd.End.CurrentValue;
                appointmentCalendarAdd.End.ViewValue = FormatDateTime(appointmentCalendarAdd.End.ViewValue, appointmentCalendarAdd.End.FormatPattern);
                appointmentCalendarAdd.End.ViewCustomAttributes = "";

                // AllDay
                if (ConvertToBool(appointmentCalendarAdd.AllDay.CurrentValue)) {
                    appointmentCalendarAdd.AllDay.ViewValue = appointmentCalendarAdd.AllDay.TagCaption(1) != "" ? appointmentCalendarAdd.AllDay.TagCaption(1) : "Yes";
                } else {
                    appointmentCalendarAdd.AllDay.ViewValue = appointmentCalendarAdd.AllDay.TagCaption(2) != "" ? appointmentCalendarAdd.AllDay.TagCaption(2) : "No";
                }
                appointmentCalendarAdd.AllDay.ViewCustomAttributes = "";

                // Description
                appointmentCalendarAdd.Description.ViewValue = appointmentCalendarAdd.Description.CurrentValue;
                appointmentCalendarAdd.Description.ViewCustomAttributes = "";

                // Url
                appointmentCalendarAdd._Url.ViewValue = ConvertToString(appointmentCalendarAdd._Url.CurrentValue); // DN
                appointmentCalendarAdd._Url.ViewCustomAttributes = "";

                // Display
                appointmentCalendarAdd.Display.ViewValue = ConvertToString(appointmentCalendarAdd.Display.CurrentValue); // DN
                appointmentCalendarAdd.Display.ViewCustomAttributes = "";

                // BackgroundColor
                appointmentCalendarAdd.BackgroundColor.ViewValue = ConvertToString(appointmentCalendarAdd.BackgroundColor.CurrentValue); // DN
                appointmentCalendarAdd.BackgroundColor.ViewCustomAttributes = "";

                // CRSS_ID
                appointmentCalendarAdd.CRSS_ID.ViewValue = ConvertToString(appointmentCalendarAdd.CRSS_ID.CurrentValue); // DN
                appointmentCalendarAdd.CRSS_ID.ViewCustomAttributes = "";

                // str_AppointmentType
                curVal = SameString(appointmentCalendarAdd.str_AppointmentType.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarAdd.str_AppointmentType.CurrentValue)?.Trim() ?? "";
                if (!Empty(curVal)) {
                    if (appointmentCalendarAdd.str_AppointmentType.Lookup != null && IsDictionary(appointmentCalendarAdd.str_AppointmentType.Lookup?.Options) && appointmentCalendarAdd.str_AppointmentType.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        appointmentCalendarAdd.str_AppointmentType.ViewValue = appointmentCalendarAdd.str_AppointmentType.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Journey]", "=", appointmentCalendarAdd.str_AppointmentType.CurrentValue, DataType.String, "");
                        sqlWrk = appointmentCalendarAdd.str_AppointmentType.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && appointmentCalendarAdd.str_AppointmentType.Lookup != null) { // Lookup values found
                            var listwrk = appointmentCalendarAdd.str_AppointmentType.Lookup?.RenderViewRow(rswrk[0]);
                            appointmentCalendarAdd.str_AppointmentType.ViewValue = appointmentCalendarAdd.str_AppointmentType.HighlightLookup(ConvertToString(rswrk[0]), appointmentCalendarAdd.str_AppointmentType.DisplayValue(listwrk));
                        } else {
                            appointmentCalendarAdd.str_AppointmentType.ViewValue = appointmentCalendarAdd.str_AppointmentType.CurrentValue;
                        }
                    }
                } else {
                    appointmentCalendarAdd.str_AppointmentType.ViewValue = DbNullValue;
                }
                appointmentCalendarAdd.str_AppointmentType.ViewCustomAttributes = "";

                // str_AppointmentStatus
                if (!Empty(appointmentCalendarAdd.str_AppointmentStatus.CurrentValue)) {
                    appointmentCalendarAdd.str_AppointmentStatus.ViewValue = str_AppointmentStatus.HighlightLookup(ConvertToString(appointmentCalendarAdd.str_AppointmentStatus.CurrentValue), appointmentCalendarAdd.str_AppointmentStatus.OptionCaption(ConvertToString(appointmentCalendarAdd.str_AppointmentStatus.CurrentValue)));
                } else {
                    appointmentCalendarAdd.str_AppointmentStatus.ViewValue = DbNullValue;
                }
                appointmentCalendarAdd.str_AppointmentStatus.ViewCustomAttributes = "";

                // str_Username
                appointmentCalendarAdd.str_Username.ViewValue = appointmentCalendarAdd.str_Username.CurrentValue;
                appointmentCalendarAdd.str_Username.ViewCustomAttributes = "";

                // str_CRSS_IDUSER
                appointmentCalendarAdd.str_CRSS_IDUSER.ViewValue = ConvertToString(appointmentCalendarAdd.str_CRSS_IDUSER.CurrentValue); // DN
                appointmentCalendarAdd.str_CRSS_IDUSER.ViewCustomAttributes = "";

                // int_Enrollement_Id
                appointmentCalendarAdd.int_Enrollement_Id.HrefValue = "";

                // int_PackageID
                appointmentCalendarAdd.int_PackageID.HrefValue = "";

                // Title
                appointmentCalendarAdd._Title.HrefValue = "";

                // Start
                appointmentCalendarAdd.Start.HrefValue = "";

                // End
                appointmentCalendarAdd.End.HrefValue = "";

                // AllDay
                appointmentCalendarAdd.AllDay.HrefValue = "";

                // Description
                appointmentCalendarAdd.Description.HrefValue = "";

                // str_AppointmentType
                appointmentCalendarAdd.str_AppointmentType.HrefValue = "";

                // str_AppointmentStatus
                appointmentCalendarAdd.str_AppointmentStatus.HrefValue = "";

                // str_Username
                appointmentCalendarAdd.str_Username.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // int_Enrollement_Id
                appointmentCalendarAdd.int_Enrollement_Id.SetupEditAttributes();
                curVal = SameString(appointmentCalendarAdd.int_Enrollement_Id.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarAdd.int_Enrollement_Id.CurrentValue)?.Trim() ?? "";
                if (appointmentCalendarAdd.int_Enrollement_Id.Lookup != null && IsDictionary(appointmentCalendarAdd.int_Enrollement_Id.Lookup?.Options) && appointmentCalendarAdd.int_Enrollement_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    appointmentCalendarAdd.int_Enrollement_Id.EditValue = appointmentCalendarAdd.int_Enrollement_Id.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Enrollement_Id]", "=", appointmentCalendarAdd.int_Enrollement_Id.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = appointmentCalendarAdd.int_Enrollement_Id.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    appointmentCalendarAdd.int_Enrollement_Id.EditValue = rswrk;
                }
                appointmentCalendarAdd.int_Enrollement_Id.PlaceHolder = RemoveHtml(appointmentCalendarAdd.int_Enrollement_Id.Caption);
                if (!Empty(appointmentCalendarAdd.int_Enrollement_Id.EditValue) && IsNumeric(appointmentCalendarAdd.int_Enrollement_Id.EditValue))
                    appointmentCalendarAdd.int_Enrollement_Id.EditValue = FormatNumber(appointmentCalendarAdd.int_Enrollement_Id.EditValue, null);

                // int_PackageID
                appointmentCalendarAdd.int_PackageID.SetupEditAttributes();
                curVal = SameString(appointmentCalendarAdd.int_PackageID.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarAdd.int_PackageID.CurrentValue)?.Trim() ?? "";
                if (appointmentCalendarAdd.int_PackageID.Lookup != null && IsDictionary(appointmentCalendarAdd.int_PackageID.Lookup?.Options) && appointmentCalendarAdd.int_PackageID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    appointmentCalendarAdd.int_PackageID.EditValue = appointmentCalendarAdd.int_PackageID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Package_Id]", "=", appointmentCalendarAdd.int_PackageID.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = appointmentCalendarAdd.int_PackageID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    appointmentCalendarAdd.int_PackageID.EditValue = rswrk;
                }
                appointmentCalendarAdd.int_PackageID.PlaceHolder = RemoveHtml(appointmentCalendarAdd.int_PackageID.Caption);
                if (!Empty(appointmentCalendarAdd.int_PackageID.EditValue) && IsNumeric(appointmentCalendarAdd.int_PackageID.EditValue))
                    appointmentCalendarAdd.int_PackageID.EditValue = FormatNumber(appointmentCalendarAdd.int_PackageID.EditValue, null);

                // Title
                appointmentCalendarAdd._Title.SetupEditAttributes();
                curVal = SameString(appointmentCalendarAdd._Title.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarAdd._Title.CurrentValue)?.Trim() ?? "";
                if (appointmentCalendarAdd._Title.Lookup != null && IsDictionary(appointmentCalendarAdd._Title.Lookup?.Options) && appointmentCalendarAdd._Title.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    appointmentCalendarAdd._Title.EditValue = appointmentCalendarAdd._Title.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Title]", "=", appointmentCalendarAdd._Title.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = appointmentCalendarAdd._Title.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    appointmentCalendarAdd._Title.EditValue = rswrk;
                }
                appointmentCalendarAdd._Title.PlaceHolder = RemoveHtml(appointmentCalendarAdd._Title.Caption);

                // Start
                appointmentCalendarAdd.Start.SetupEditAttributes();
                appointmentCalendarAdd.Start.EditValue = FormatDateTime(appointmentCalendarAdd.Start.CurrentValue, appointmentCalendarAdd.Start.FormatPattern); // DN
                appointmentCalendarAdd.Start.PlaceHolder = RemoveHtml(appointmentCalendarAdd.Start.Caption);

                // End
                appointmentCalendarAdd.End.SetupEditAttributes();
                appointmentCalendarAdd.End.EditValue = FormatDateTime(appointmentCalendarAdd.End.CurrentValue, appointmentCalendarAdd.End.FormatPattern); // DN
                appointmentCalendarAdd.End.PlaceHolder = RemoveHtml(appointmentCalendarAdd.End.Caption);

                // AllDay
                appointmentCalendarAdd.AllDay.EditValue = appointmentCalendarAdd.AllDay.Options(false);
                appointmentCalendarAdd.AllDay.PlaceHolder = RemoveHtml(appointmentCalendarAdd.AllDay.Caption);

                // Description
                appointmentCalendarAdd.Description.SetupEditAttributes();
                appointmentCalendarAdd.Description.EditValue = appointmentCalendarAdd.Description.CurrentValue; // DN
                appointmentCalendarAdd.Description.PlaceHolder = RemoveHtml(appointmentCalendarAdd.Description.Caption);

                // str_AppointmentType
                appointmentCalendarAdd.str_AppointmentType.SetupEditAttributes();
                curVal = SameString(appointmentCalendarAdd.str_AppointmentType.CurrentValue, Config.InitValue) ? "" : ConvertToString(appointmentCalendarAdd.str_AppointmentType.CurrentValue)?.Trim() ?? "";
                if (appointmentCalendarAdd.str_AppointmentType.Lookup != null && IsDictionary(appointmentCalendarAdd.str_AppointmentType.Lookup?.Options) && appointmentCalendarAdd.str_AppointmentType.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    appointmentCalendarAdd.str_AppointmentType.EditValue = appointmentCalendarAdd.str_AppointmentType.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Journey]", "=", appointmentCalendarAdd.str_AppointmentType.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = appointmentCalendarAdd.str_AppointmentType.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    appointmentCalendarAdd.str_AppointmentType.EditValue = rswrk;
                }
                appointmentCalendarAdd.str_AppointmentType.PlaceHolder = RemoveHtml(appointmentCalendarAdd.str_AppointmentType.Caption);

                // str_AppointmentStatus
                appointmentCalendarAdd.str_AppointmentStatus.SetupEditAttributes();
                appointmentCalendarAdd.str_AppointmentStatus.EditValue = appointmentCalendarAdd.str_AppointmentStatus.Options(true);
                appointmentCalendarAdd.str_AppointmentStatus.PlaceHolder = RemoveHtml(appointmentCalendarAdd.str_AppointmentStatus.Caption);

                // str_Username

                // Add refer script

                // int_Enrollement_Id
                appointmentCalendarAdd.int_Enrollement_Id.HrefValue = "";

                // int_PackageID
                appointmentCalendarAdd.int_PackageID.HrefValue = "";

                // Title
                appointmentCalendarAdd._Title.HrefValue = "";

                // Start
                appointmentCalendarAdd.Start.HrefValue = "";

                // End
                appointmentCalendarAdd.End.HrefValue = "";

                // AllDay
                appointmentCalendarAdd.AllDay.HrefValue = "";

                // Description
                appointmentCalendarAdd.Description.HrefValue = "";

                // str_AppointmentType
                appointmentCalendarAdd.str_AppointmentType.HrefValue = "";

                // str_AppointmentStatus
                appointmentCalendarAdd.str_AppointmentStatus.HrefValue = "";

                // str_Username
                appointmentCalendarAdd.str_Username.HrefValue = "";
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
            if (int_Enrollement_Id.Required) {
                if (!appointmentCalendarAdd.int_Enrollement_Id.IsDetailKey && Empty(appointmentCalendarAdd.int_Enrollement_Id.FormValue)) {
                    appointmentCalendarAdd.int_Enrollement_Id.AddErrorMessage(ConvertToString(appointmentCalendarAdd.int_Enrollement_Id.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.int_Enrollement_Id.Caption));
                }
            }
            if (int_PackageID.Required) {
                if (!appointmentCalendarAdd.int_PackageID.IsDetailKey && Empty(appointmentCalendarAdd.int_PackageID.FormValue)) {
                    appointmentCalendarAdd.int_PackageID.AddErrorMessage(ConvertToString(appointmentCalendarAdd.int_PackageID.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.int_PackageID.Caption));
                }
            }
            if (_Title.Required) {
                if (!appointmentCalendarAdd._Title.IsDetailKey && Empty(appointmentCalendarAdd._Title.FormValue)) {
                    appointmentCalendarAdd._Title.AddErrorMessage(ConvertToString(appointmentCalendarAdd._Title.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd._Title.Caption));
                }
            }
            if (Start.Required) {
                if (!appointmentCalendarAdd.Start.IsDetailKey && Empty(appointmentCalendarAdd.Start.FormValue)) {
                    appointmentCalendarAdd.Start.AddErrorMessage(ConvertToString(appointmentCalendarAdd.Start.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.Start.Caption));
                }
            }
            if (!CheckDate(appointmentCalendarAdd.Start.FormValue, appointmentCalendarAdd.Start.FormatPattern)) {
                appointmentCalendarAdd.Start.AddErrorMessage(appointmentCalendarAdd.Start.GetErrorMessage(false));
            }
            if (End.Required) {
                if (!appointmentCalendarAdd.End.IsDetailKey && Empty(appointmentCalendarAdd.End.FormValue)) {
                    appointmentCalendarAdd.End.AddErrorMessage(ConvertToString(appointmentCalendarAdd.End.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.End.Caption));
                }
            }
            if (!CheckDate(appointmentCalendarAdd.End.FormValue, appointmentCalendarAdd.End.FormatPattern)) {
                appointmentCalendarAdd.End.AddErrorMessage(appointmentCalendarAdd.End.GetErrorMessage(false));
            }
            if (AllDay.Required) {
                if (Empty(appointmentCalendarAdd.AllDay.FormValue)) {
                    appointmentCalendarAdd.AllDay.AddErrorMessage(ConvertToString(appointmentCalendarAdd.AllDay.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.AllDay.Caption));
                }
            }
            if (Description.Required) {
                if (!appointmentCalendarAdd.Description.IsDetailKey && Empty(appointmentCalendarAdd.Description.FormValue)) {
                    appointmentCalendarAdd.Description.AddErrorMessage(ConvertToString(appointmentCalendarAdd.Description.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.Description.Caption));
                }
            }
            if (str_AppointmentType.Required) {
                if (!appointmentCalendarAdd.str_AppointmentType.IsDetailKey && Empty(appointmentCalendarAdd.str_AppointmentType.FormValue)) {
                    appointmentCalendarAdd.str_AppointmentType.AddErrorMessage(ConvertToString(appointmentCalendarAdd.str_AppointmentType.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.str_AppointmentType.Caption));
                }
            }
            if (str_AppointmentStatus.Required) {
                if (!appointmentCalendarAdd.str_AppointmentStatus.IsDetailKey && Empty(appointmentCalendarAdd.str_AppointmentStatus.FormValue)) {
                    appointmentCalendarAdd.str_AppointmentStatus.AddErrorMessage(ConvertToString(appointmentCalendarAdd.str_AppointmentStatus.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.str_AppointmentStatus.Caption));
                }
            }
            if (str_Username.Required) {
                if (!appointmentCalendarAdd.str_Username.IsDetailKey && Empty(appointmentCalendarAdd.str_Username.FormValue)) {
                    appointmentCalendarAdd.str_Username.AddErrorMessage(ConvertToString(appointmentCalendarAdd.str_Username.RequiredErrorMessage).Replace("%s", appointmentCalendarAdd.str_Username.Caption));
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
                // int_Enrollement_Id
                appointmentCalendarAdd.int_Enrollement_Id.SetDbValue(rsnew, appointmentCalendarAdd.int_Enrollement_Id.CurrentValue);

                // int_PackageID
                appointmentCalendarAdd.int_PackageID.SetDbValue(rsnew, appointmentCalendarAdd.int_PackageID.CurrentValue);

                // Title
                appointmentCalendarAdd._Title.SetDbValue(rsnew, appointmentCalendarAdd._Title.CurrentValue);

                // Start
                appointmentCalendarAdd.Start.SetDbValue(rsnew, ConvertToDateTime(appointmentCalendarAdd.Start.CurrentValue, Start.FormatPattern));

                // End
                appointmentCalendarAdd.End.SetDbValue(rsnew, ConvertToDateTime(appointmentCalendarAdd.End.CurrentValue, End.FormatPattern));

                // AllDay
                appointmentCalendarAdd.AllDay.SetDbValue(rsnew, ConvertToBool(appointmentCalendarAdd.AllDay.CurrentValue));

                // Description
                appointmentCalendarAdd.Description.SetDbValue(rsnew, appointmentCalendarAdd.Description.CurrentValue);

                // str_AppointmentType
                appointmentCalendarAdd.str_AppointmentType.SetDbValue(rsnew, appointmentCalendarAdd.str_AppointmentType.CurrentValue);

                // str_AppointmentStatus
                appointmentCalendarAdd.str_AppointmentStatus.SetDbValue(rsnew, appointmentCalendarAdd.str_AppointmentStatus.CurrentValue);

                // str_Username
                appointmentCalendarAdd.str_Username.CurrentValue = str_Username.GetAutoUpdateValue();
                appointmentCalendarAdd.str_Username.SetDbValue(rsnew, appointmentCalendarAdd.str_Username.CurrentValue, false);
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
                    rsnew["Id"] = Id.CurrentValue!;
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
                    string table = UpdateTable;
                    if (FieldByName("Id")?.CurrentValue is var id && id != null) // Get event ID // DN
                        row["id"] = id;
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

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("")), "", TableVar, true);
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
