namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// appointmentCldrEdit
    /// </summary>
    public static AppointmentCldrEdit appointmentCldrEdit
    {
        get => HttpData.Get<AppointmentCldrEdit>("appointmentCldrEdit")!;
        set => HttpData["appointmentCldrEdit"] = value;
    }

    /// <summary>
    /// Page class for Appointment_Cldr
    /// </summary>
    public class AppointmentCldrEdit : AppointmentCldrEditBase
    {
        // Constructor
        public AppointmentCldrEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public AppointmentCldrEdit() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class AppointmentCldrEditBase : AppointmentCldr
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Appointment_Cldr";

        // Page object name
        public string PageObjName = "appointmentCldrEdit";

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
        public AppointmentCldrEditBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (appointmentCldr)
            if (appointmentCldr == null || appointmentCldr is AppointmentCldr)
                appointmentCldr = this;

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
        public string PageName => "AppointmentCldrEdit";

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
            Id.Visible = false;
            int_Enrollement_Id.SetVisibility();
            int_PackageID.SetVisibility();
            _Title.SetVisibility();
            Start.SetVisibility();
            End.SetVisibility();
            AllDay.Visible = false;
            Description.SetVisibility();
            _Url.Visible = false;
            Display.Visible = false;
            BackgroundColor.Visible = false;
            CRSS_ID.Visible = false;
            str_AppointmentType.SetVisibility();
            str_AppointmentStatus.SetVisibility();
            str_Username.Visible = false;
            str_CRSS_IDUSER.Visible = false;
        }

        // Constructor
        public AppointmentCldrEditBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "AppointmentCldrView" ? "1" : "0"); // If View page, no primary button
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
            await SetupLookupOptions(int_Enrollement_Id);
            await SetupLookupOptions(int_PackageID);
            await SetupLookupOptions(AllDay);
            await SetupLookupOptions(str_AppointmentType);
            await SetupLookupOptions(str_AppointmentStatus);

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
                            return Terminate("AppointmentCldrList"); // No matching record, return to list
                        }
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = ReturnUrl;
                    if (GetPageName(returnUrl) == "AppointmentCldrList")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "AppointmentCldrList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "AppointmentCldrList"; // Return list page content
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
                appointmentCldrEdit?.PageRender();
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
            int_Enrollement_Id.CurrentValue = int_Enrollement_Id.FormValue;
            int_PackageID.CurrentValue = int_PackageID.FormValue;
            _Title.CurrentValue = _Title.FormValue;
            Start.CurrentValue = Start.FormValue;
            Start.CurrentValue = UnformatDateTime(Start.CurrentValue, Start.FormatPattern);
            End.CurrentValue = End.FormValue;
            End.CurrentValue = UnformatDateTime(End.CurrentValue, End.FormatPattern);
            Description.CurrentValue = Description.FormValue;
            str_AppointmentType.CurrentValue = str_AppointmentType.FormValue;
            str_AppointmentStatus.CurrentValue = str_AppointmentStatus.FormValue;
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
            Id.RowCssClass = "row";

            // int_Enrollement_Id
            int_Enrollement_Id.RowCssClass = "row";

            // int_PackageID
            int_PackageID.RowCssClass = "row";

            // Title
            _Title.RowCssClass = "row";

            // Start
            Start.RowCssClass = "row";

            // End
            End.RowCssClass = "row";

            // AllDay
            AllDay.RowCssClass = "row";

            // Description
            Description.RowCssClass = "row";

            // Url
            _Url.RowCssClass = "row";

            // Display
            Display.RowCssClass = "row";

            // BackgroundColor
            BackgroundColor.RowCssClass = "row";

            // CRSS_ID
            CRSS_ID.RowCssClass = "row";

            // str_AppointmentType
            str_AppointmentType.RowCssClass = "row";

            // str_AppointmentStatus
            str_AppointmentStatus.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // str_CRSS_IDUSER
            str_CRSS_IDUSER.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // Id
                Id.ViewValue = Id.CurrentValue;
                Id.ViewCustomAttributes = "";

                // int_Enrollement_Id
                curVal = ConvertToString(int_Enrollement_Id.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Enrollement_Id.Lookup != null && IsDictionary(int_Enrollement_Id.Lookup?.Options) && int_Enrollement_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Enrollement_Id.ViewValue = int_Enrollement_Id.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Enrollement_Id]", "=", int_Enrollement_Id.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Enrollement_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Enrollement_Id.Lookup != null) { // Lookup values found
                            var listwrk = int_Enrollement_Id.Lookup?.RenderViewRow(rswrk[0]);
                            int_Enrollement_Id.ViewValue = int_Enrollement_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Enrollement_Id.DisplayValue(listwrk));
                        } else {
                            int_Enrollement_Id.ViewValue = FormatNumber(int_Enrollement_Id.CurrentValue, int_Enrollement_Id.FormatPattern);
                        }
                    }
                } else {
                    int_Enrollement_Id.ViewValue = DbNullValue;
                }
                int_Enrollement_Id.ViewCustomAttributes = "";

                // int_PackageID
                curVal = ConvertToString(int_PackageID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_PackageID.Lookup != null && IsDictionary(int_PackageID.Lookup?.Options) && int_PackageID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_PackageID.ViewValue = int_PackageID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_PackageID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_PackageID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_PackageID.Lookup != null) { // Lookup values found
                            var listwrk = int_PackageID.Lookup?.RenderViewRow(rswrk[0]);
                            int_PackageID.ViewValue = int_PackageID.HighlightLookup(ConvertToString(rswrk[0]), int_PackageID.DisplayValue(listwrk));
                        } else {
                            int_PackageID.ViewValue = FormatNumber(int_PackageID.CurrentValue, int_PackageID.FormatPattern);
                        }
                    }
                } else {
                    int_PackageID.ViewValue = DbNullValue;
                }
                int_PackageID.ViewCustomAttributes = "";

                // Title
                _Title.ViewValue = ConvertToString(_Title.CurrentValue); // DN
                _Title.ViewCustomAttributes = "";

                // Start
                Start.ViewValue = Start.CurrentValue;
                Start.ViewValue = FormatDateTime(Start.ViewValue, Start.FormatPattern);
                Start.ViewCustomAttributes = "";

                // End
                End.ViewValue = End.CurrentValue;
                End.ViewValue = FormatDateTime(End.ViewValue, End.FormatPattern);
                End.ViewCustomAttributes = "";

                // AllDay
                if (ConvertToBool(AllDay.CurrentValue)) {
                    AllDay.ViewValue = AllDay.TagCaption(1) != "" ? AllDay.TagCaption(1) : "Yes";
                } else {
                    AllDay.ViewValue = AllDay.TagCaption(2) != "" ? AllDay.TagCaption(2) : "No";
                }
                AllDay.ViewCustomAttributes = "";

                // Description
                Description.ViewValue = Description.CurrentValue;
                Description.ViewCustomAttributes = "";

                // Url
                _Url.ViewValue = ConvertToString(_Url.CurrentValue); // DN
                _Url.ViewCustomAttributes = "";

                // Display
                Display.ViewValue = ConvertToString(Display.CurrentValue); // DN
                Display.ViewCustomAttributes = "";

                // BackgroundColor
                BackgroundColor.ViewValue = ConvertToString(BackgroundColor.CurrentValue); // DN
                BackgroundColor.ViewCustomAttributes = "";

                // CRSS_ID
                CRSS_ID.ViewValue = ConvertToString(CRSS_ID.CurrentValue); // DN
                CRSS_ID.ViewCustomAttributes = "";

                // str_AppointmentType
                curVal = ConvertToString(str_AppointmentType.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_AppointmentType.Lookup != null && IsDictionary(str_AppointmentType.Lookup?.Options) && str_AppointmentType.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_AppointmentType.ViewValue = str_AppointmentType.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Service_Description]", "=", str_AppointmentType.CurrentValue, DataType.String, "");
                        sqlWrk = str_AppointmentType.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_AppointmentType.Lookup != null) { // Lookup values found
                            var listwrk = str_AppointmentType.Lookup?.RenderViewRow(rswrk[0]);
                            str_AppointmentType.ViewValue = str_AppointmentType.HighlightLookup(ConvertToString(rswrk[0]), str_AppointmentType.DisplayValue(listwrk));
                        } else {
                            str_AppointmentType.ViewValue = str_AppointmentType.CurrentValue;
                        }
                    }
                } else {
                    str_AppointmentType.ViewValue = DbNullValue;
                }
                str_AppointmentType.ViewCustomAttributes = "";

                // str_AppointmentStatus
                if (!Empty(str_AppointmentStatus.CurrentValue)) {
                    str_AppointmentStatus.ViewValue = str_AppointmentStatus.HighlightLookup(ConvertToString(str_AppointmentStatus.CurrentValue), str_AppointmentStatus.OptionCaption(ConvertToString(str_AppointmentStatus.CurrentValue)));
                } else {
                    str_AppointmentStatus.ViewValue = DbNullValue;
                }
                str_AppointmentStatus.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = str_Username.CurrentValue;
                str_Username.ViewCustomAttributes = "";

                // str_CRSS_IDUSER
                str_CRSS_IDUSER.ViewValue = ConvertToString(str_CRSS_IDUSER.CurrentValue); // DN
                str_CRSS_IDUSER.ViewCustomAttributes = "";

                // int_Enrollement_Id
                int_Enrollement_Id.HrefValue = "";

                // int_PackageID
                int_PackageID.HrefValue = "";

                // Title
                _Title.HrefValue = "";

                // Start
                Start.HrefValue = "";

                // End
                End.HrefValue = "";

                // Description
                Description.HrefValue = "";

                // str_AppointmentType
                str_AppointmentType.HrefValue = "";

                // str_AppointmentStatus
                str_AppointmentStatus.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // int_Enrollement_Id
                int_Enrollement_Id.SetupEditAttributes();
                curVal = ConvertToString(int_Enrollement_Id.CurrentValue)?.Trim() ?? "";
                if (int_Enrollement_Id.Lookup != null && IsDictionary(int_Enrollement_Id.Lookup?.Options) && int_Enrollement_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Enrollement_Id.EditValue = int_Enrollement_Id.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Enrollement_Id]", "=", int_Enrollement_Id.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_Enrollement_Id.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Enrollement_Id.EditValue = rswrk;
                }
                int_Enrollement_Id.PlaceHolder = RemoveHtml(int_Enrollement_Id.Caption);
                if (!Empty(int_Enrollement_Id.EditValue) && IsNumeric(int_Enrollement_Id.EditValue))
                    int_Enrollement_Id.EditValue = FormatNumber(int_Enrollement_Id.EditValue, null);

                // int_PackageID
                int_PackageID.SetupEditAttributes();
                curVal = ConvertToString(int_PackageID.CurrentValue)?.Trim() ?? "";
                if (int_PackageID.Lookup != null && IsDictionary(int_PackageID.Lookup?.Options) && int_PackageID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_PackageID.EditValue = int_PackageID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_PackageID.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_PackageID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_PackageID.EditValue = rswrk;
                }
                int_PackageID.PlaceHolder = RemoveHtml(int_PackageID.Caption);
                if (!Empty(int_PackageID.EditValue) && IsNumeric(int_PackageID.EditValue))
                    int_PackageID.EditValue = FormatNumber(int_PackageID.EditValue, null);

                // Title
                _Title.SetupEditAttributes();
                if (!_Title.Raw)
                    _Title.CurrentValue = HtmlDecode(_Title.CurrentValue);
                _Title.EditValue = HtmlEncode(_Title.CurrentValue);
                _Title.PlaceHolder = RemoveHtml(_Title.Caption);

                // Start
                Start.SetupEditAttributes();
                Start.EditValue = FormatDateTime(Start.CurrentValue, Start.FormatPattern); // DN
                Start.PlaceHolder = RemoveHtml(Start.Caption);

                // End
                End.SetupEditAttributes();
                End.EditValue = FormatDateTime(End.CurrentValue, End.FormatPattern); // DN
                End.PlaceHolder = RemoveHtml(End.Caption);

                // Description
                Description.SetupEditAttributes();
                Description.EditValue = Description.CurrentValue; // DN
                Description.PlaceHolder = RemoveHtml(Description.Caption);

                // str_AppointmentType
                str_AppointmentType.SetupEditAttributes();
                curVal = ConvertToString(str_AppointmentType.CurrentValue)?.Trim() ?? "";
                if (str_AppointmentType.Lookup != null && IsDictionary(str_AppointmentType.Lookup?.Options) && str_AppointmentType.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_AppointmentType.EditValue = str_AppointmentType.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Service_Description]", "=", str_AppointmentType.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = str_AppointmentType.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_AppointmentType.EditValue = rswrk;
                }
                str_AppointmentType.PlaceHolder = RemoveHtml(str_AppointmentType.Caption);

                // str_AppointmentStatus
                str_AppointmentStatus.SetupEditAttributes();
                str_AppointmentStatus.EditValue = str_AppointmentStatus.Options(true);
                str_AppointmentStatus.PlaceHolder = RemoveHtml(str_AppointmentStatus.Caption);

                // Edit refer script

                // int_Enrollement_Id
                int_Enrollement_Id.HrefValue = "";

                // int_PackageID
                int_PackageID.HrefValue = "";

                // Title
                _Title.HrefValue = "";

                // Start
                Start.HrefValue = "";

                // End
                End.HrefValue = "";

                // Description
                Description.HrefValue = "";

                // str_AppointmentType
                str_AppointmentType.HrefValue = "";

                // str_AppointmentStatus
                str_AppointmentStatus.HrefValue = "";
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
                if (!int_Enrollement_Id.IsDetailKey && Empty(int_Enrollement_Id.FormValue)) {
                    int_Enrollement_Id.AddErrorMessage(ConvertToString(int_Enrollement_Id.RequiredErrorMessage).Replace("%s", int_Enrollement_Id.Caption));
                }
            }
            if (int_PackageID.Required) {
                if (!int_PackageID.IsDetailKey && Empty(int_PackageID.FormValue)) {
                    int_PackageID.AddErrorMessage(ConvertToString(int_PackageID.RequiredErrorMessage).Replace("%s", int_PackageID.Caption));
                }
            }
            if (_Title.Required) {
                if (!_Title.IsDetailKey && Empty(_Title.FormValue)) {
                    _Title.AddErrorMessage(ConvertToString(_Title.RequiredErrorMessage).Replace("%s", _Title.Caption));
                }
            }
            if (Start.Required) {
                if (!Start.IsDetailKey && Empty(Start.FormValue)) {
                    Start.AddErrorMessage(ConvertToString(Start.RequiredErrorMessage).Replace("%s", Start.Caption));
                }
            }
            if (!CheckDate(Start.FormValue, Start.FormatPattern)) {
                Start.AddErrorMessage(Start.GetErrorMessage(false));
            }
            if (End.Required) {
                if (!End.IsDetailKey && Empty(End.FormValue)) {
                    End.AddErrorMessage(ConvertToString(End.RequiredErrorMessage).Replace("%s", End.Caption));
                }
            }
            if (!CheckDate(End.FormValue, End.FormatPattern)) {
                End.AddErrorMessage(End.GetErrorMessage(false));
            }
            if (Description.Required) {
                if (!Description.IsDetailKey && Empty(Description.FormValue)) {
                    Description.AddErrorMessage(ConvertToString(Description.RequiredErrorMessage).Replace("%s", Description.Caption));
                }
            }
            if (str_AppointmentType.Required) {
                if (!str_AppointmentType.IsDetailKey && Empty(str_AppointmentType.FormValue)) {
                    str_AppointmentType.AddErrorMessage(ConvertToString(str_AppointmentType.RequiredErrorMessage).Replace("%s", str_AppointmentType.Caption));
                }
            }
            if (str_AppointmentStatus.Required) {
                if (!str_AppointmentStatus.IsDetailKey && Empty(str_AppointmentStatus.FormValue)) {
                    str_AppointmentStatus.AddErrorMessage(ConvertToString(str_AppointmentStatus.RequiredErrorMessage).Replace("%s", str_AppointmentStatus.Caption));
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
            int_Enrollement_Id.SetDbValue(rsnew, int_Enrollement_Id.CurrentValue, int_Enrollement_Id.ReadOnly);

            // int_PackageID
            int_PackageID.SetDbValue(rsnew, int_PackageID.CurrentValue, int_PackageID.ReadOnly);

            // Title
            _Title.SetDbValue(rsnew, _Title.CurrentValue, _Title.ReadOnly);

            // Start
            Start.SetDbValue(rsnew, ConvertToDateTime(Start.CurrentValue, Start.FormatPattern), Start.ReadOnly);

            // End
            End.SetDbValue(rsnew, ConvertToDateTime(End.CurrentValue, End.FormatPattern), End.ReadOnly);

            // Description
            Description.SetDbValue(rsnew, Description.CurrentValue, Description.ReadOnly);

            // str_AppointmentType
            str_AppointmentType.SetDbValue(rsnew, str_AppointmentType.CurrentValue, str_AppointmentType.ReadOnly);

            // str_AppointmentStatus
            str_AppointmentStatus.SetDbValue(rsnew, str_AppointmentStatus.CurrentValue, str_AppointmentStatus.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

            // Check field with unique index (End)
            if (!Empty(End.CurrentValue)) {
                string filterChk = "([End] = '" + AdjustSql(End.CurrentValue, DbId) + "')";
                filterChk = filterChk + " AND NOT (" + filter + ")";
                try {
                    using var rschk = await LoadReader(filterChk);
                    if (rschk?.HasRows ?? false) {
                        var idxErrMsg = Language.Phrase("DupIndex").Replace("%f", End.Caption);
                        idxErrMsg = idxErrMsg.Replace("%v", ConvertToString(End.CurrentValue));
                        FailureMessage = idxErrMsg;
                        return JsonBoolResult.FalseResult;
                    }
                } catch (Exception e) {
                    if (Config.Debug)
                        throw;
                    FailureMessage = e.Message;
                    return JsonBoolResult.FalseResult;
                }
            }

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
                    string table = TableVar;
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("AppointmentCldrList")), "", TableVar, true);
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
