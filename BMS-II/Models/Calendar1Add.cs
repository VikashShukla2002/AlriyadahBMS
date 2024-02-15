namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// calendar1Add
    /// </summary>
    public static Calendar1Add calendar1Add
    {
        get => HttpData.Get<Calendar1Add>("calendar1Add")!;
        set => HttpData["calendar1Add"] = value;
    }

    /// <summary>
    /// Page class for Calendar1
    /// </summary>
    public class Calendar1Add : Calendar1AddBase
    {
        // Constructor
        public Calendar1Add(Controller controller) : base(controller)
        {
        }

        // Constructor
        public Calendar1Add() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class Calendar1AddBase : Calendar1
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Calendar1";

        // Page object name
        public string PageObjName = "calendar1Add";

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
        public Calendar1AddBase()
        {
            // Initialize
            TableVar = "Calendar1"; // DN
            if (!DashboardReport)
                CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (calendar1)
            if (calendar1 == null || calendar1 is Calendar1)
                calendar1 = this;

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
        public string PageName => "Calendar1Add";

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
        public Calendar1AddBase(Controller? controller = null): this() { // DN
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
                calendar1Add?.PageRender();
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
            calendar1Add.Start.DefaultValue = Param("Start");
            if (Empty(calendar1Add.Start.DefaultValue))
                calendar1Add.Start.OldValue = calendar1Add.Start.DefaultValue;
            calendar1Add.End.DefaultValue = Param("End");
            if (Empty(calendar1Add.End.DefaultValue))
                calendar1Add.End.OldValue = calendar1Add.End.DefaultValue;
            calendar1Add.AllDay.DefaultValue = Param("AllDay");
            if (Empty(calendar1Add.AllDay.DefaultValue))
                calendar1Add.AllDay.OldValue = calendar1Add.AllDay.DefaultValue;
        }

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

            // Check field name 'BackgroundColor' before field var 'x_BackgroundColor'
            val = CurrentForm.HasValue("BackgroundColor") ? CurrentForm.GetValue("BackgroundColor") : CurrentForm.GetValue("x_BackgroundColor");
            if (!BackgroundColor.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("BackgroundColor") && !CurrentForm.HasValue("x_BackgroundColor")) // DN
                    BackgroundColor.Visible = false; // Disable update for API request
                else
                    BackgroundColor.SetFormValue(val);
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
            _Title.CurrentValue = _Title.FormValue;
            Start.CurrentValue = Start.FormValue;
            Start.CurrentValue = UnformatDateTime(Start.CurrentValue, Start.FormatPattern);
            End.CurrentValue = End.FormValue;
            End.CurrentValue = UnformatDateTime(End.CurrentValue, End.FormatPattern);
            AllDay.CurrentValue = AllDay.FormValue;
            Description.CurrentValue = Description.FormValue;
            _Url.CurrentValue = _Url.FormValue;
            ClassNames.CurrentValue = ClassNames.FormValue;
            Display.CurrentValue = Display.FormValue;
            BackgroundColor.CurrentValue = BackgroundColor.FormValue;
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
            _Title.SetDbValue(row["Title"]);
            Start.SetDbValue(row["Start"]);
            End.SetDbValue(row["End"]);
            AllDay.SetDbValue((ConvertToBool(row["AllDay"]) ? "1" : "0"));
            Description.SetDbValue(row["Description"]);
            _Url.SetDbValue(row["Url"]);
            ClassNames.SetDbValue(row["ClassNames"]);
            Display.SetDbValue(row["Display"]);
            BackgroundColor.SetDbValue(row["BackgroundColor"]);
            str_Username.SetDbValue(row["str_Username"]);
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
            row.Add("Description", Description.DefaultValue ?? DbNullValue); // DN
            row.Add("Url", _Url.DefaultValue ?? DbNullValue); // DN
            row.Add("ClassNames", ClassNames.DefaultValue ?? DbNullValue); // DN
            row.Add("Display", Display.DefaultValue ?? DbNullValue); // DN
            row.Add("BackgroundColor", BackgroundColor.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
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
            calendar1Add.Id.RowCssClass = "row";

            // Title
            calendar1Add._Title.RowCssClass = "row";

            // Start
            calendar1Add.Start.RowCssClass = "row";

            // End
            calendar1Add.End.RowCssClass = "row";

            // AllDay
            calendar1Add.AllDay.RowCssClass = "row";

            // Description
            calendar1Add.Description.RowCssClass = "row";

            // Url
            calendar1Add._Url.RowCssClass = "row";

            // ClassNames
            calendar1Add.ClassNames.RowCssClass = "row";

            // Display
            calendar1Add.Display.RowCssClass = "row";

            // BackgroundColor
            calendar1Add.BackgroundColor.RowCssClass = "row";

            // str_Username
            calendar1Add.str_Username.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // Id
                calendar1Add.Id.ViewValue = calendar1Add.Id.CurrentValue;
                calendar1Add.Id.ViewCustomAttributes = "";

                // Title
                calendar1Add._Title.ViewValue = ConvertToString(calendar1Add._Title.CurrentValue); // DN
                calendar1Add._Title.ViewCustomAttributes = "";

                // Start
                calendar1Add.Start.ViewValue = calendar1Add.Start.CurrentValue;
                calendar1Add.Start.ViewValue = FormatDateTime(calendar1Add.Start.ViewValue, calendar1Add.Start.FormatPattern);
                calendar1Add.Start.ViewCustomAttributes = "";

                // End
                calendar1Add.End.ViewValue = calendar1Add.End.CurrentValue;
                calendar1Add.End.ViewValue = FormatDateTime(calendar1Add.End.ViewValue, calendar1Add.End.FormatPattern);
                calendar1Add.End.ViewCustomAttributes = "";

                // AllDay
                if (ConvertToBool(calendar1Add.AllDay.CurrentValue)) {
                    calendar1Add.AllDay.ViewValue = calendar1Add.AllDay.TagCaption(1) != "" ? calendar1Add.AllDay.TagCaption(1) : "Yes";
                } else {
                    calendar1Add.AllDay.ViewValue = calendar1Add.AllDay.TagCaption(2) != "" ? calendar1Add.AllDay.TagCaption(2) : "No";
                }
                calendar1Add.AllDay.ViewCustomAttributes = "";

                // Description
                calendar1Add.Description.ViewValue = calendar1Add.Description.CurrentValue;
                calendar1Add.Description.ViewCustomAttributes = "";

                // Url
                calendar1Add._Url.ViewValue = ConvertToString(calendar1Add._Url.CurrentValue); // DN
                calendar1Add._Url.ViewCustomAttributes = "";

                // ClassNames
                calendar1Add.ClassNames.ViewValue = ConvertToString(calendar1Add.ClassNames.CurrentValue); // DN
                calendar1Add.ClassNames.ViewCustomAttributes = "";

                // Display
                calendar1Add.Display.ViewValue = ConvertToString(calendar1Add.Display.CurrentValue); // DN
                calendar1Add.Display.ViewCustomAttributes = "";

                // BackgroundColor
                calendar1Add.BackgroundColor.ViewValue = ConvertToString(calendar1Add.BackgroundColor.CurrentValue); // DN
                calendar1Add.BackgroundColor.ViewCustomAttributes = "";

                // str_Username
                calendar1Add.str_Username.ViewValue = ConvertToString(calendar1Add.str_Username.CurrentValue); // DN
                calendar1Add.str_Username.ViewCustomAttributes = "";

                // Title
                calendar1Add._Title.HrefValue = "";

                // Start
                calendar1Add.Start.HrefValue = "";

                // End
                calendar1Add.End.HrefValue = "";

                // AllDay
                calendar1Add.AllDay.HrefValue = "";

                // Description
                calendar1Add.Description.HrefValue = "";

                // Url
                calendar1Add._Url.HrefValue = "";

                // ClassNames
                calendar1Add.ClassNames.HrefValue = "";

                // Display
                calendar1Add.Display.HrefValue = "";

                // BackgroundColor
                calendar1Add.BackgroundColor.HrefValue = "";

                // str_Username
                calendar1Add.str_Username.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // Title
                calendar1Add._Title.SetupEditAttributes();
                if (!calendar1Add._Title.Raw)
                    calendar1Add._Title.CurrentValue = HtmlDecode(calendar1Add._Title.CurrentValue);
                calendar1Add._Title.EditValue = HtmlEncode(calendar1Add._Title.CurrentValue);
                calendar1Add._Title.PlaceHolder = RemoveHtml(calendar1Add._Title.Caption);

                // Start
                calendar1Add.Start.SetupEditAttributes();
                calendar1Add.Start.EditValue = FormatDateTime(calendar1Add.Start.CurrentValue, calendar1Add.Start.FormatPattern); // DN
                calendar1Add.Start.PlaceHolder = RemoveHtml(calendar1Add.Start.Caption);

                // End
                calendar1Add.End.SetupEditAttributes();
                calendar1Add.End.EditValue = FormatDateTime(calendar1Add.End.CurrentValue, calendar1Add.End.FormatPattern); // DN
                calendar1Add.End.PlaceHolder = RemoveHtml(calendar1Add.End.Caption);

                // AllDay
                calendar1Add.AllDay.EditValue = calendar1Add.AllDay.Options(false);
                calendar1Add.AllDay.PlaceHolder = RemoveHtml(calendar1Add.AllDay.Caption);

                // Description
                calendar1Add.Description.SetupEditAttributes();
                calendar1Add.Description.EditValue = calendar1Add.Description.CurrentValue; // DN
                calendar1Add.Description.PlaceHolder = RemoveHtml(calendar1Add.Description.Caption);

                // Url
                calendar1Add._Url.SetupEditAttributes();
                if (!calendar1Add._Url.Raw)
                    calendar1Add._Url.CurrentValue = HtmlDecode(calendar1Add._Url.CurrentValue);
                calendar1Add._Url.EditValue = HtmlEncode(calendar1Add._Url.CurrentValue);
                calendar1Add._Url.PlaceHolder = RemoveHtml(calendar1Add._Url.Caption);

                // ClassNames
                calendar1Add.ClassNames.SetupEditAttributes();
                if (!calendar1Add.ClassNames.Raw)
                    calendar1Add.ClassNames.CurrentValue = HtmlDecode(calendar1Add.ClassNames.CurrentValue);
                calendar1Add.ClassNames.EditValue = HtmlEncode(calendar1Add.ClassNames.CurrentValue);
                calendar1Add.ClassNames.PlaceHolder = RemoveHtml(calendar1Add.ClassNames.Caption);

                // Display
                calendar1Add.Display.SetupEditAttributes();
                if (!calendar1Add.Display.Raw)
                    calendar1Add.Display.CurrentValue = HtmlDecode(calendar1Add.Display.CurrentValue);
                calendar1Add.Display.EditValue = HtmlEncode(calendar1Add.Display.CurrentValue);
                calendar1Add.Display.PlaceHolder = RemoveHtml(calendar1Add.Display.Caption);

                // BackgroundColor
                calendar1Add.BackgroundColor.SetupEditAttributes();
                if (!calendar1Add.BackgroundColor.Raw)
                    calendar1Add.BackgroundColor.CurrentValue = HtmlDecode(calendar1Add.BackgroundColor.CurrentValue);
                calendar1Add.BackgroundColor.EditValue = HtmlEncode(calendar1Add.BackgroundColor.CurrentValue);
                calendar1Add.BackgroundColor.PlaceHolder = RemoveHtml(calendar1Add.BackgroundColor.Caption);

                // str_Username
                calendar1Add.str_Username.SetupEditAttributes();
                if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("add")) { // Non system admin
                    calendar1Add.str_Username.CurrentValue = Empty(calendar1Add.str_Username.CurrentValue) ? CurrentUserID() : calendar1Add.str_Username.CurrentValue;
                } else {
                    if (!calendar1Add.str_Username.Raw)
                        calendar1Add.str_Username.CurrentValue = HtmlDecode(calendar1Add.str_Username.CurrentValue);
                    calendar1Add.str_Username.EditValue = HtmlEncode(calendar1Add.str_Username.CurrentValue);
                    calendar1Add.str_Username.PlaceHolder = RemoveHtml(calendar1Add.str_Username.Caption);
                }

                // Add refer script

                // Title
                calendar1Add._Title.HrefValue = "";

                // Start
                calendar1Add.Start.HrefValue = "";

                // End
                calendar1Add.End.HrefValue = "";

                // AllDay
                calendar1Add.AllDay.HrefValue = "";

                // Description
                calendar1Add.Description.HrefValue = "";

                // Url
                calendar1Add._Url.HrefValue = "";

                // ClassNames
                calendar1Add.ClassNames.HrefValue = "";

                // Display
                calendar1Add.Display.HrefValue = "";

                // BackgroundColor
                calendar1Add.BackgroundColor.HrefValue = "";

                // str_Username
                calendar1Add.str_Username.HrefValue = "";
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
                if (!calendar1Add._Title.IsDetailKey && Empty(calendar1Add._Title.FormValue)) {
                    calendar1Add._Title.AddErrorMessage(ConvertToString(calendar1Add._Title.RequiredErrorMessage).Replace("%s", calendar1Add._Title.Caption));
                }
            }
            if (Start.Required) {
                if (!calendar1Add.Start.IsDetailKey && Empty(calendar1Add.Start.FormValue)) {
                    calendar1Add.Start.AddErrorMessage(ConvertToString(calendar1Add.Start.RequiredErrorMessage).Replace("%s", calendar1Add.Start.Caption));
                }
            }
            if (!CheckDate(calendar1Add.Start.FormValue, calendar1Add.Start.FormatPattern)) {
                calendar1Add.Start.AddErrorMessage(calendar1Add.Start.GetErrorMessage(false));
            }
            if (End.Required) {
                if (!calendar1Add.End.IsDetailKey && Empty(calendar1Add.End.FormValue)) {
                    calendar1Add.End.AddErrorMessage(ConvertToString(calendar1Add.End.RequiredErrorMessage).Replace("%s", calendar1Add.End.Caption));
                }
            }
            if (!CheckDate(calendar1Add.End.FormValue, calendar1Add.End.FormatPattern)) {
                calendar1Add.End.AddErrorMessage(calendar1Add.End.GetErrorMessage(false));
            }
            if (AllDay.Required) {
                if (Empty(calendar1Add.AllDay.FormValue)) {
                    calendar1Add.AllDay.AddErrorMessage(ConvertToString(calendar1Add.AllDay.RequiredErrorMessage).Replace("%s", calendar1Add.AllDay.Caption));
                }
            }
            if (Description.Required) {
                if (!calendar1Add.Description.IsDetailKey && Empty(calendar1Add.Description.FormValue)) {
                    calendar1Add.Description.AddErrorMessage(ConvertToString(calendar1Add.Description.RequiredErrorMessage).Replace("%s", calendar1Add.Description.Caption));
                }
            }
            if (_Url.Required) {
                if (!calendar1Add._Url.IsDetailKey && Empty(calendar1Add._Url.FormValue)) {
                    calendar1Add._Url.AddErrorMessage(ConvertToString(calendar1Add._Url.RequiredErrorMessage).Replace("%s", calendar1Add._Url.Caption));
                }
            }
            if (ClassNames.Required) {
                if (!calendar1Add.ClassNames.IsDetailKey && Empty(calendar1Add.ClassNames.FormValue)) {
                    calendar1Add.ClassNames.AddErrorMessage(ConvertToString(calendar1Add.ClassNames.RequiredErrorMessage).Replace("%s", calendar1Add.ClassNames.Caption));
                }
            }
            if (Display.Required) {
                if (!calendar1Add.Display.IsDetailKey && Empty(calendar1Add.Display.FormValue)) {
                    calendar1Add.Display.AddErrorMessage(ConvertToString(calendar1Add.Display.RequiredErrorMessage).Replace("%s", calendar1Add.Display.Caption));
                }
            }
            if (BackgroundColor.Required) {
                if (!calendar1Add.BackgroundColor.IsDetailKey && Empty(calendar1Add.BackgroundColor.FormValue)) {
                    calendar1Add.BackgroundColor.AddErrorMessage(ConvertToString(calendar1Add.BackgroundColor.RequiredErrorMessage).Replace("%s", calendar1Add.BackgroundColor.Caption));
                }
            }
            if (str_Username.Required) {
                if (!calendar1Add.str_Username.IsDetailKey && Empty(calendar1Add.str_Username.FormValue)) {
                    calendar1Add.str_Username.AddErrorMessage(ConvertToString(calendar1Add.str_Username.RequiredErrorMessage).Replace("%s", calendar1Add.str_Username.Caption));
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
                // Title
                calendar1Add._Title.SetDbValue(rsnew, calendar1Add._Title.CurrentValue);

                // Start
                calendar1Add.Start.SetDbValue(rsnew, ConvertToDateTime(calendar1Add.Start.CurrentValue, Start.FormatPattern));

                // End
                calendar1Add.End.SetDbValue(rsnew, ConvertToDateTime(calendar1Add.End.CurrentValue, End.FormatPattern));

                // AllDay
                calendar1Add.AllDay.SetDbValue(rsnew, ConvertToBool(calendar1Add.AllDay.CurrentValue));

                // Description
                calendar1Add.Description.SetDbValue(rsnew, calendar1Add.Description.CurrentValue);

                // Url
                calendar1Add._Url.SetDbValue(rsnew, calendar1Add._Url.CurrentValue);

                // ClassNames
                calendar1Add.ClassNames.SetDbValue(rsnew, calendar1Add.ClassNames.CurrentValue);

                // Display
                calendar1Add.Display.SetDbValue(rsnew, calendar1Add.Display.CurrentValue);

                // BackgroundColor
                calendar1Add.BackgroundColor.SetDbValue(rsnew, calendar1Add.BackgroundColor.CurrentValue);

                // str_Username
                calendar1Add.str_Username.SetDbValue(rsnew, calendar1Add.str_Username.CurrentValue);
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
