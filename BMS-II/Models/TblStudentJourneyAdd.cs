namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStudentJourneyAdd
    /// </summary>
    public static TblStudentJourneyAdd tblStudentJourneyAdd
    {
        get => HttpData.Get<TblStudentJourneyAdd>("tblStudentJourneyAdd")!;
        set => HttpData["tblStudentJourneyAdd"] = value;
    }

    /// <summary>
    /// Page class for tblStudentJourney
    /// </summary>
    public class TblStudentJourneyAdd : TblStudentJourneyAddBase
    {
        // Constructor
        public TblStudentJourneyAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblStudentJourneyAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblStudentJourneyAddBase : TblStudentJourney
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblStudentJourney";

        // Page object name
        public string PageObjName = "tblStudentJourneyAdd";

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
        public TblStudentJourneyAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblStudentJourney)
            if (tblStudentJourney == null || tblStudentJourney is TblStudentJourney)
                tblStudentJourney = this;

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
        public string PageName => "TblStudentJourneyAdd";

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
            STDJ_ID.SetVisibility();
            FullName.SetVisibility();
            str_Username.SetVisibility();
            Number_ID.SetVisibility();
            Journey_ID.SetVisibility();
            Journey.SetVisibility();
            Start_Date.SetVisibility();
            End_Date.SetVisibility();
            Total_Days.SetVisibility();
            Status.SetVisibility();
            Package_Name.SetVisibility();
            Product_Name.SetVisibility();
            Price.SetVisibility();
        }

        // Constructor
        public TblStudentJourneyAddBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblStudentJourneyView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("STDJ_ID") ? dict["STDJ_ID"] : STDJ_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
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
                if (RouteValues.TryGetValue("STDJ_ID", out rv)) { // DN
                    STDJ_ID.QueryValue = UrlDecode(rv); // DN
                } else if (Get("STDJ_ID", out sv)) {
                    STDJ_ID.QueryValue = sv.ToString();
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
                        return Terminate("TblStudentJourneyList"); // No matching record, return to List page // DN
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
                        if (GetPageName(returnUrl) == "TblStudentJourneyList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "TblStudentJourneyView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblStudentJourneyList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblStudentJourneyList"; // Return list page content
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
                tblStudentJourneyAdd?.PageRender();
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
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'STDJ_ID' before field var 'x_STDJ_ID'
            val = CurrentForm.HasValue("STDJ_ID") ? CurrentForm.GetValue("STDJ_ID") : CurrentForm.GetValue("x_STDJ_ID");
            if (!STDJ_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("STDJ_ID") && !CurrentForm.HasValue("x_STDJ_ID")) // DN
                    STDJ_ID.Visible = false; // Disable update for API request
                else
                    STDJ_ID.SetFormValue(val, true, validate);
            }

            // Check field name 'FullName' before field var 'x_FullName'
            val = CurrentForm.HasValue("FullName") ? CurrentForm.GetValue("FullName") : CurrentForm.GetValue("x_FullName");
            if (!FullName.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("FullName") && !CurrentForm.HasValue("x_FullName")) // DN
                    FullName.Visible = false; // Disable update for API request
                else
                    FullName.SetFormValue(val);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }

            // Check field name 'Number_ID' before field var 'x_Number_ID'
            val = CurrentForm.HasValue("Number_ID") ? CurrentForm.GetValue("Number_ID") : CurrentForm.GetValue("x_Number_ID");
            if (!Number_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Number_ID") && !CurrentForm.HasValue("x_Number_ID")) // DN
                    Number_ID.Visible = false; // Disable update for API request
                else
                    Number_ID.SetFormValue(val, true, validate);
            }

            // Check field name 'Journey_ID' before field var 'x_Journey_ID'
            val = CurrentForm.HasValue("Journey_ID") ? CurrentForm.GetValue("Journey_ID") : CurrentForm.GetValue("x_Journey_ID");
            if (!Journey_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Journey_ID") && !CurrentForm.HasValue("x_Journey_ID")) // DN
                    Journey_ID.Visible = false; // Disable update for API request
                else
                    Journey_ID.SetFormValue(val, true, validate);
            }

            // Check field name 'Journey' before field var 'x_Journey'
            val = CurrentForm.HasValue("Journey") ? CurrentForm.GetValue("Journey") : CurrentForm.GetValue("x_Journey");
            if (!Journey.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Journey") && !CurrentForm.HasValue("x_Journey")) // DN
                    Journey.Visible = false; // Disable update for API request
                else
                    Journey.SetFormValue(val);
            }

            // Check field name 'Start_Date' before field var 'x_Start_Date'
            val = CurrentForm.HasValue("Start_Date") ? CurrentForm.GetValue("Start_Date") : CurrentForm.GetValue("x_Start_Date");
            if (!Start_Date.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Start_Date") && !CurrentForm.HasValue("x_Start_Date")) // DN
                    Start_Date.Visible = false; // Disable update for API request
                else
                    Start_Date.SetFormValue(val, true, validate);
                Start_Date.CurrentValue = UnformatDateTime(Start_Date.CurrentValue, Start_Date.FormatPattern);
            }

            // Check field name 'End_Date' before field var 'x_End_Date'
            val = CurrentForm.HasValue("End_Date") ? CurrentForm.GetValue("End_Date") : CurrentForm.GetValue("x_End_Date");
            if (!End_Date.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("End_Date") && !CurrentForm.HasValue("x_End_Date")) // DN
                    End_Date.Visible = false; // Disable update for API request
                else
                    End_Date.SetFormValue(val, true, validate);
                End_Date.CurrentValue = UnformatDateTime(End_Date.CurrentValue, End_Date.FormatPattern);
            }

            // Check field name 'Total_Days' before field var 'x_Total_Days'
            val = CurrentForm.HasValue("Total_Days") ? CurrentForm.GetValue("Total_Days") : CurrentForm.GetValue("x_Total_Days");
            if (!Total_Days.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Total_Days") && !CurrentForm.HasValue("x_Total_Days")) // DN
                    Total_Days.Visible = false; // Disable update for API request
                else
                    Total_Days.SetFormValue(val, true, validate);
            }

            // Check field name 'Status' before field var 'x_Status'
            val = CurrentForm.HasValue("Status") ? CurrentForm.GetValue("Status") : CurrentForm.GetValue("x_Status");
            if (!Status.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Status") && !CurrentForm.HasValue("x_Status")) // DN
                    Status.Visible = false; // Disable update for API request
                else
                    Status.SetFormValue(val);
            }

            // Check field name 'Package_Name' before field var 'x_Package_Name'
            val = CurrentForm.HasValue("Package_Name") ? CurrentForm.GetValue("Package_Name") : CurrentForm.GetValue("x_Package_Name");
            if (!Package_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Package_Name") && !CurrentForm.HasValue("x_Package_Name")) // DN
                    Package_Name.Visible = false; // Disable update for API request
                else
                    Package_Name.SetFormValue(val);
            }

            // Check field name 'Product_Name' before field var 'x_Product_Name'
            val = CurrentForm.HasValue("Product_Name") ? CurrentForm.GetValue("Product_Name") : CurrentForm.GetValue("x_Product_Name");
            if (!Product_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Product_Name") && !CurrentForm.HasValue("x_Product_Name")) // DN
                    Product_Name.Visible = false; // Disable update for API request
                else
                    Product_Name.SetFormValue(val);
            }

            // Check field name 'Price' before field var 'x_Price'
            val = CurrentForm.HasValue("Price") ? CurrentForm.GetValue("Price") : CurrentForm.GetValue("x_Price");
            if (!Price.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Price") && !CurrentForm.HasValue("x_Price")) // DN
                    Price.Visible = false; // Disable update for API request
                else
                    Price.SetFormValue(val, true, validate);
            }
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            STDJ_ID.CurrentValue = STDJ_ID.FormValue;
            FullName.CurrentValue = FullName.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            Number_ID.CurrentValue = Number_ID.FormValue;
            Journey_ID.CurrentValue = Journey_ID.FormValue;
            Journey.CurrentValue = Journey.FormValue;
            Start_Date.CurrentValue = Start_Date.FormValue;
            Start_Date.CurrentValue = UnformatDateTime(Start_Date.CurrentValue, Start_Date.FormatPattern);
            End_Date.CurrentValue = End_Date.FormValue;
            End_Date.CurrentValue = UnformatDateTime(End_Date.CurrentValue, End_Date.FormatPattern);
            Total_Days.CurrentValue = Total_Days.FormValue;
            Status.CurrentValue = Status.FormValue;
            Package_Name.CurrentValue = Package_Name.FormValue;
            Product_Name.CurrentValue = Product_Name.FormValue;
            Price.CurrentValue = Price.FormValue;
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
            STDJ_ID.SetDbValue(row["STDJ_ID"]);
            FullName.SetDbValue(row["FullName"]);
            str_Username.SetDbValue(row["str_Username"]);
            Number_ID.SetDbValue(row["Number_ID"]);
            Journey_ID.SetDbValue(row["Journey_ID"]);
            Journey.SetDbValue(row["Journey"]);
            Start_Date.SetDbValue(row["Start_Date"]);
            End_Date.SetDbValue(row["End_Date"]);
            Total_Days.SetDbValue(row["Total_Days"]);
            Status.SetDbValue(row["Status"]);
            Package_Name.SetDbValue(row["Package_Name"]);
            Product_Name.SetDbValue(row["Product_Name"]);
            Price.SetDbValue(row["Price"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("STDJ_ID", STDJ_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("FullName", FullName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("Number_ID", Number_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Journey_ID", Journey_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Journey", Journey.DefaultValue ?? DbNullValue); // DN
            row.Add("Start_Date", Start_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("End_Date", End_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("Total_Days", Total_Days.DefaultValue ?? DbNullValue); // DN
            row.Add("Status", Status.DefaultValue ?? DbNullValue); // DN
            row.Add("Package_Name", Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("Product_Name", Product_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("Price", Price.DefaultValue ?? DbNullValue); // DN
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

            // STDJ_ID
            STDJ_ID.RowCssClass = "row";

            // FullName
            FullName.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // Number_ID
            Number_ID.RowCssClass = "row";

            // Journey_ID
            Journey_ID.RowCssClass = "row";

            // Journey
            Journey.RowCssClass = "row";

            // Start_Date
            Start_Date.RowCssClass = "row";

            // End_Date
            End_Date.RowCssClass = "row";

            // Total_Days
            Total_Days.RowCssClass = "row";

            // Status
            Status.RowCssClass = "row";

            // Package_Name
            Package_Name.RowCssClass = "row";

            // Product_Name
            Product_Name.RowCssClass = "row";

            // Price
            Price.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // STDJ_ID
                STDJ_ID.ViewValue = STDJ_ID.CurrentValue;
                STDJ_ID.ViewValue = FormatNumber(STDJ_ID.ViewValue, STDJ_ID.FormatPattern);
                STDJ_ID.ViewCustomAttributes = "";

                // FullName
                FullName.ViewValue = ConvertToString(FullName.CurrentValue); // DN
                FullName.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // Number_ID
                Number_ID.ViewValue = Number_ID.CurrentValue;
                Number_ID.ViewValue = FormatNumber(Number_ID.ViewValue, Number_ID.FormatPattern);
                Number_ID.ViewCustomAttributes = "";

                // Journey_ID
                Journey_ID.ViewValue = Journey_ID.CurrentValue;
                Journey_ID.ViewValue = FormatNumber(Journey_ID.ViewValue, Journey_ID.FormatPattern);
                Journey_ID.ViewCustomAttributes = "";

                // Journey
                Journey.ViewValue = ConvertToString(Journey.CurrentValue); // DN
                Journey.ViewCustomAttributes = "";

                // Start_Date
                Start_Date.ViewValue = Start_Date.CurrentValue;
                Start_Date.ViewValue = FormatDateTime(Start_Date.ViewValue, Start_Date.FormatPattern);
                Start_Date.ViewCustomAttributes = "";

                // End_Date
                End_Date.ViewValue = End_Date.CurrentValue;
                End_Date.ViewValue = FormatDateTime(End_Date.ViewValue, End_Date.FormatPattern);
                End_Date.ViewCustomAttributes = "";

                // Total_Days
                Total_Days.ViewValue = Total_Days.CurrentValue;
                Total_Days.ViewValue = FormatNumber(Total_Days.ViewValue, Total_Days.FormatPattern);
                Total_Days.ViewCustomAttributes = "";

                // Status
                Status.ViewValue = ConvertToString(Status.CurrentValue); // DN
                Status.ViewCustomAttributes = "";

                // Package_Name
                Package_Name.ViewValue = ConvertToString(Package_Name.CurrentValue); // DN
                Package_Name.ViewCustomAttributes = "";

                // Product_Name
                Product_Name.ViewValue = ConvertToString(Product_Name.CurrentValue); // DN
                Product_Name.ViewCustomAttributes = "";

                // Price
                Price.ViewValue = Price.CurrentValue;
                Price.ViewValue = FormatNumber(Price.ViewValue, Price.FormatPattern);
                Price.ViewCustomAttributes = "";

                // STDJ_ID
                STDJ_ID.HrefValue = "";

                // FullName
                FullName.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // Number_ID
                Number_ID.HrefValue = "";

                // Journey_ID
                Journey_ID.HrefValue = "";

                // Journey
                Journey.HrefValue = "";

                // Start_Date
                Start_Date.HrefValue = "";

                // End_Date
                End_Date.HrefValue = "";

                // Total_Days
                Total_Days.HrefValue = "";

                // Status
                Status.HrefValue = "";

                // Package_Name
                Package_Name.HrefValue = "";

                // Product_Name
                Product_Name.HrefValue = "";

                // Price
                Price.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // STDJ_ID
                STDJ_ID.SetupEditAttributes();
                STDJ_ID.EditValue = STDJ_ID.CurrentValue; // DN
                STDJ_ID.PlaceHolder = RemoveHtml(STDJ_ID.Caption);
                if (!Empty(STDJ_ID.EditValue) && IsNumeric(STDJ_ID.EditValue))
                    STDJ_ID.EditValue = FormatNumber(STDJ_ID.EditValue, null);

                // FullName
                FullName.SetupEditAttributes();
                if (!FullName.Raw)
                    FullName.CurrentValue = HtmlDecode(FullName.CurrentValue);
                FullName.EditValue = HtmlEncode(FullName.CurrentValue);
                FullName.PlaceHolder = RemoveHtml(FullName.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!str_Username.Raw)
                    str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // Number_ID
                Number_ID.SetupEditAttributes();
                Number_ID.EditValue = Number_ID.CurrentValue; // DN
                Number_ID.PlaceHolder = RemoveHtml(Number_ID.Caption);
                if (!Empty(Number_ID.EditValue) && IsNumeric(Number_ID.EditValue))
                    Number_ID.EditValue = FormatNumber(Number_ID.EditValue, null);

                // Journey_ID
                Journey_ID.SetupEditAttributes();
                Journey_ID.EditValue = Journey_ID.CurrentValue; // DN
                Journey_ID.PlaceHolder = RemoveHtml(Journey_ID.Caption);
                if (!Empty(Journey_ID.EditValue) && IsNumeric(Journey_ID.EditValue))
                    Journey_ID.EditValue = FormatNumber(Journey_ID.EditValue, null);

                // Journey
                Journey.SetupEditAttributes();
                if (!Journey.Raw)
                    Journey.CurrentValue = HtmlDecode(Journey.CurrentValue);
                Journey.EditValue = HtmlEncode(Journey.CurrentValue);
                Journey.PlaceHolder = RemoveHtml(Journey.Caption);

                // Start_Date
                Start_Date.SetupEditAttributes();
                Start_Date.EditValue = FormatDateTime(Start_Date.CurrentValue, Start_Date.FormatPattern); // DN
                Start_Date.PlaceHolder = RemoveHtml(Start_Date.Caption);

                // End_Date
                End_Date.SetupEditAttributes();
                End_Date.EditValue = FormatDateTime(End_Date.CurrentValue, End_Date.FormatPattern); // DN
                End_Date.PlaceHolder = RemoveHtml(End_Date.Caption);

                // Total_Days
                Total_Days.SetupEditAttributes();
                Total_Days.EditValue = Total_Days.CurrentValue; // DN
                Total_Days.PlaceHolder = RemoveHtml(Total_Days.Caption);
                if (!Empty(Total_Days.EditValue) && IsNumeric(Total_Days.EditValue))
                    Total_Days.EditValue = FormatNumber(Total_Days.EditValue, null);

                // Status
                Status.SetupEditAttributes();
                if (!Status.Raw)
                    Status.CurrentValue = HtmlDecode(Status.CurrentValue);
                Status.EditValue = HtmlEncode(Status.CurrentValue);
                Status.PlaceHolder = RemoveHtml(Status.Caption);

                // Package_Name
                Package_Name.SetupEditAttributes();
                if (!Package_Name.Raw)
                    Package_Name.CurrentValue = HtmlDecode(Package_Name.CurrentValue);
                Package_Name.EditValue = HtmlEncode(Package_Name.CurrentValue);
                Package_Name.PlaceHolder = RemoveHtml(Package_Name.Caption);

                // Product_Name
                Product_Name.SetupEditAttributes();
                if (!Product_Name.Raw)
                    Product_Name.CurrentValue = HtmlDecode(Product_Name.CurrentValue);
                Product_Name.EditValue = HtmlEncode(Product_Name.CurrentValue);
                Product_Name.PlaceHolder = RemoveHtml(Product_Name.Caption);

                // Price
                Price.SetupEditAttributes();
                Price.EditValue = Price.CurrentValue; // DN
                Price.PlaceHolder = RemoveHtml(Price.Caption);
                if (!Empty(Price.EditValue) && IsNumeric(Price.EditValue))
                    Price.EditValue = FormatNumber(Price.EditValue, null);

                // Add refer script

                // STDJ_ID
                STDJ_ID.HrefValue = "";

                // FullName
                FullName.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // Number_ID
                Number_ID.HrefValue = "";

                // Journey_ID
                Journey_ID.HrefValue = "";

                // Journey
                Journey.HrefValue = "";

                // Start_Date
                Start_Date.HrefValue = "";

                // End_Date
                End_Date.HrefValue = "";

                // Total_Days
                Total_Days.HrefValue = "";

                // Status
                Status.HrefValue = "";

                // Package_Name
                Package_Name.HrefValue = "";

                // Product_Name
                Product_Name.HrefValue = "";

                // Price
                Price.HrefValue = "";
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
            if (STDJ_ID.Required) {
                if (!STDJ_ID.IsDetailKey && Empty(STDJ_ID.FormValue)) {
                    STDJ_ID.AddErrorMessage(ConvertToString(STDJ_ID.RequiredErrorMessage).Replace("%s", STDJ_ID.Caption));
                }
            }
            if (!CheckInteger(STDJ_ID.FormValue)) {
                STDJ_ID.AddErrorMessage(STDJ_ID.GetErrorMessage(false));
            }
            if (FullName.Required) {
                if (!FullName.IsDetailKey && Empty(FullName.FormValue)) {
                    FullName.AddErrorMessage(ConvertToString(FullName.RequiredErrorMessage).Replace("%s", FullName.Caption));
                }
            }
            if (str_Username.Required) {
                if (!str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (Number_ID.Required) {
                if (!Number_ID.IsDetailKey && Empty(Number_ID.FormValue)) {
                    Number_ID.AddErrorMessage(ConvertToString(Number_ID.RequiredErrorMessage).Replace("%s", Number_ID.Caption));
                }
            }
            if (!CheckInteger(Number_ID.FormValue)) {
                Number_ID.AddErrorMessage(Number_ID.GetErrorMessage(false));
            }
            if (Journey_ID.Required) {
                if (!Journey_ID.IsDetailKey && Empty(Journey_ID.FormValue)) {
                    Journey_ID.AddErrorMessage(ConvertToString(Journey_ID.RequiredErrorMessage).Replace("%s", Journey_ID.Caption));
                }
            }
            if (!CheckInteger(Journey_ID.FormValue)) {
                Journey_ID.AddErrorMessage(Journey_ID.GetErrorMessage(false));
            }
            if (Journey.Required) {
                if (!Journey.IsDetailKey && Empty(Journey.FormValue)) {
                    Journey.AddErrorMessage(ConvertToString(Journey.RequiredErrorMessage).Replace("%s", Journey.Caption));
                }
            }
            if (Start_Date.Required) {
                if (!Start_Date.IsDetailKey && Empty(Start_Date.FormValue)) {
                    Start_Date.AddErrorMessage(ConvertToString(Start_Date.RequiredErrorMessage).Replace("%s", Start_Date.Caption));
                }
            }
            if (!CheckDate(Start_Date.FormValue, Start_Date.FormatPattern)) {
                Start_Date.AddErrorMessage(Start_Date.GetErrorMessage(false));
            }
            if (End_Date.Required) {
                if (!End_Date.IsDetailKey && Empty(End_Date.FormValue)) {
                    End_Date.AddErrorMessage(ConvertToString(End_Date.RequiredErrorMessage).Replace("%s", End_Date.Caption));
                }
            }
            if (!CheckDate(End_Date.FormValue, End_Date.FormatPattern)) {
                End_Date.AddErrorMessage(End_Date.GetErrorMessage(false));
            }
            if (Total_Days.Required) {
                if (!Total_Days.IsDetailKey && Empty(Total_Days.FormValue)) {
                    Total_Days.AddErrorMessage(ConvertToString(Total_Days.RequiredErrorMessage).Replace("%s", Total_Days.Caption));
                }
            }
            if (!CheckInteger(Total_Days.FormValue)) {
                Total_Days.AddErrorMessage(Total_Days.GetErrorMessage(false));
            }
            if (Status.Required) {
                if (!Status.IsDetailKey && Empty(Status.FormValue)) {
                    Status.AddErrorMessage(ConvertToString(Status.RequiredErrorMessage).Replace("%s", Status.Caption));
                }
            }
            if (Package_Name.Required) {
                if (!Package_Name.IsDetailKey && Empty(Package_Name.FormValue)) {
                    Package_Name.AddErrorMessage(ConvertToString(Package_Name.RequiredErrorMessage).Replace("%s", Package_Name.Caption));
                }
            }
            if (Product_Name.Required) {
                if (!Product_Name.IsDetailKey && Empty(Product_Name.FormValue)) {
                    Product_Name.AddErrorMessage(ConvertToString(Product_Name.RequiredErrorMessage).Replace("%s", Product_Name.Caption));
                }
            }
            if (Price.Required) {
                if (!Price.IsDetailKey && Empty(Price.FormValue)) {
                    Price.AddErrorMessage(ConvertToString(Price.RequiredErrorMessage).Replace("%s", Price.Caption));
                }
            }
            if (!CheckNumber(Price.FormValue)) {
                Price.AddErrorMessage(Price.GetErrorMessage(false));
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
                // STDJ_ID
                STDJ_ID.SetDbValue(rsnew, STDJ_ID.CurrentValue);

                // FullName
                FullName.SetDbValue(rsnew, FullName.CurrentValue);

                // str_Username
                str_Username.SetDbValue(rsnew, str_Username.CurrentValue);

                // Number_ID
                Number_ID.SetDbValue(rsnew, Number_ID.CurrentValue);

                // Journey_ID
                Journey_ID.SetDbValue(rsnew, Journey_ID.CurrentValue);

                // Journey
                Journey.SetDbValue(rsnew, Journey.CurrentValue);

                // Start_Date
                Start_Date.SetDbValue(rsnew, ConvertToDateTime(Start_Date.CurrentValue, Start_Date.FormatPattern));

                // End_Date
                End_Date.SetDbValue(rsnew, ConvertToDateTime(End_Date.CurrentValue, End_Date.FormatPattern));

                // Total_Days
                Total_Days.SetDbValue(rsnew, Total_Days.CurrentValue);

                // Status
                Status.SetDbValue(rsnew, Status.CurrentValue);

                // Package_Name
                Package_Name.SetDbValue(rsnew, Package_Name.CurrentValue);

                // Product_Name
                Product_Name.SetDbValue(rsnew, Product_Name.CurrentValue);

                // Price
                Price.SetDbValue(rsnew, Price.CurrentValue);
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }

            // Update current values
            SetCurrentValues(rsnew);
            if (!Empty(STDJ_ID.CurrentValue)) { // Check field with unique index
                var filter = "(STDJ_ID = " + AdjustSql(STDJ_ID.CurrentValue, DbId) + ")";
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupIndex").Replace("%f", STDJ_ID.Caption).Replace("%v", ConvertToString(STDJ_ID.CurrentValue));
                    return JsonBoolResult.FalseResult;
                }
            }

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);

            // Check if key value entered
            if (insertRow && ValidateKey && Empty(rsnew["STDJ_ID"])) {
                FailureMessage = Language.Phrase("InvalidKeyValue");
                insertRow = false;
            }

            // Check for duplicate key
            if (insertRow && ValidateKey) {
                string filter = GetRecordFilter(rsnew);
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupKey").Replace("%f", filter);
                    insertRow = false;
                }
            }
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblStudentJourneyList")), "", TableVar, true);
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
