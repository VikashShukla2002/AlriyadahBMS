namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblNationalityAdd
    /// </summary>
    public static TblNationalityAdd tblNationalityAdd
    {
        get => HttpData.Get<TblNationalityAdd>("tblNationalityAdd")!;
        set => HttpData["tblNationalityAdd"] = value;
    }

    /// <summary>
    /// Page class for tblNationality
    /// </summary>
    public class TblNationalityAdd : TblNationalityAddBase
    {
        // Constructor
        public TblNationalityAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblNationalityAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblNationalityAddBase : TblNationality
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblNationality";

        // Page object name
        public string PageObjName = "tblNationalityAdd";

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
        public TblNationalityAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblNationality)
            if (tblNationality == null || tblNationality is TblNationality)
                tblNationality = this;

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
        public string PageName => "TblNationalityAdd";

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
            ID.SetVisibility();
            Nationality_en.SetVisibility();
            Nationality_arabic.SetVisibility();
            IsActive.SetVisibility();
            IsDeleted.SetVisibility();
            int_Status.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
        }

        // Constructor
        public TblNationalityAddBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblNationalityView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("ID") ? dict["ID"] : ID.CurrentValue));
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

            // Set up lookup cache
            await SetupLookupOptions(IsActive);
            await SetupLookupOptions(IsDeleted);

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
                if (RouteValues.TryGetValue("ID", out rv)) { // DN
                    ID.QueryValue = UrlDecode(rv); // DN
                } else if (Get("ID", out sv)) {
                    ID.QueryValue = sv.ToString();
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
                        return Terminate("TblNationalityList"); // No matching record, return to List page // DN
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
                        if (GetPageName(returnUrl) == "TblNationalityList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "TblNationalityView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblNationalityList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblNationalityList"; // Return list page content
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
                tblNationalityAdd?.PageRender();
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

            // Check field name 'ID' before field var 'x_ID'
            val = CurrentForm.HasValue("ID") ? CurrentForm.GetValue("ID") : CurrentForm.GetValue("x_ID");
            if (!ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("ID") && !CurrentForm.HasValue("x_ID")) // DN
                    ID.Visible = false; // Disable update for API request
                else
                    ID.SetFormValue(val, true, validate);
            }

            // Check field name 'Nationality_en' before field var 'x_Nationality_en'
            val = CurrentForm.HasValue("Nationality_en") ? CurrentForm.GetValue("Nationality_en") : CurrentForm.GetValue("x_Nationality_en");
            if (!Nationality_en.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Nationality_en") && !CurrentForm.HasValue("x_Nationality_en")) // DN
                    Nationality_en.Visible = false; // Disable update for API request
                else
                    Nationality_en.SetFormValue(val);
            }

            // Check field name 'Nationality_arabic' before field var 'x_Nationality_arabic'
            val = CurrentForm.HasValue("Nationality_arabic") ? CurrentForm.GetValue("Nationality_arabic") : CurrentForm.GetValue("x_Nationality_arabic");
            if (!Nationality_arabic.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Nationality_arabic") && !CurrentForm.HasValue("x_Nationality_arabic")) // DN
                    Nationality_arabic.Visible = false; // Disable update for API request
                else
                    Nationality_arabic.SetFormValue(val);
            }

            // Check field name 'IsActive' before field var 'x_IsActive'
            val = CurrentForm.HasValue("IsActive") ? CurrentForm.GetValue("IsActive") : CurrentForm.GetValue("x_IsActive");
            if (!IsActive.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsActive") && !CurrentForm.HasValue("x_IsActive")) // DN
                    IsActive.Visible = false; // Disable update for API request
                else
                    IsActive.SetFormValue(val);
            }

            // Check field name 'IsDeleted' before field var 'x_IsDeleted'
            val = CurrentForm.HasValue("IsDeleted") ? CurrentForm.GetValue("IsDeleted") : CurrentForm.GetValue("x_IsDeleted");
            if (!IsDeleted.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDeleted") && !CurrentForm.HasValue("x_IsDeleted")) // DN
                    IsDeleted.Visible = false; // Disable update for API request
                else
                    IsDeleted.SetFormValue(val);
            }

            // Check field name 'int_Status' before field var 'x_int_Status'
            val = CurrentForm.HasValue("int_Status") ? CurrentForm.GetValue("int_Status") : CurrentForm.GetValue("x_int_Status");
            if (!int_Status.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Status") && !CurrentForm.HasValue("x_int_Status")) // DN
                    int_Status.Visible = false; // Disable update for API request
                else
                    int_Status.SetFormValue(val, true, validate);
            }

            // Check field name 'int_Created_By' before field var 'x_int_Created_By'
            val = CurrentForm.HasValue("int_Created_By") ? CurrentForm.GetValue("int_Created_By") : CurrentForm.GetValue("x_int_Created_By");
            if (!int_Created_By.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Created_By") && !CurrentForm.HasValue("x_int_Created_By")) // DN
                    int_Created_By.Visible = false; // Disable update for API request
                else
                    int_Created_By.SetFormValue(val, true, validate);
            }

            // Check field name 'int_Modified_By' before field var 'x_int_Modified_By'
            val = CurrentForm.HasValue("int_Modified_By") ? CurrentForm.GetValue("int_Modified_By") : CurrentForm.GetValue("x_int_Modified_By");
            if (!int_Modified_By.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Modified_By") && !CurrentForm.HasValue("x_int_Modified_By")) // DN
                    int_Modified_By.Visible = false; // Disable update for API request
                else
                    int_Modified_By.SetFormValue(val, true, validate);
            }

            // Check field name 'date_Created' before field var 'x_date_Created'
            val = CurrentForm.HasValue("date_Created") ? CurrentForm.GetValue("date_Created") : CurrentForm.GetValue("x_date_Created");
            if (!date_Created.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Created") && !CurrentForm.HasValue("x_date_Created")) // DN
                    date_Created.Visible = false; // Disable update for API request
                else
                    date_Created.SetFormValue(val, true, validate);
                date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            }

            // Check field name 'date_Modified' before field var 'x_date_Modified'
            val = CurrentForm.HasValue("date_Modified") ? CurrentForm.GetValue("date_Modified") : CurrentForm.GetValue("x_date_Modified");
            if (!date_Modified.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Modified") && !CurrentForm.HasValue("x_date_Modified")) // DN
                    date_Modified.Visible = false; // Disable update for API request
                else
                    date_Modified.SetFormValue(val, true, validate);
                date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            }
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            ID.CurrentValue = ID.FormValue;
            Nationality_en.CurrentValue = Nationality_en.FormValue;
            Nationality_arabic.CurrentValue = Nationality_arabic.FormValue;
            IsActive.CurrentValue = IsActive.FormValue;
            IsDeleted.CurrentValue = IsDeleted.FormValue;
            int_Status.CurrentValue = int_Status.FormValue;
            int_Created_By.CurrentValue = int_Created_By.FormValue;
            int_Modified_By.CurrentValue = int_Modified_By.FormValue;
            date_Created.CurrentValue = date_Created.FormValue;
            date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            date_Modified.CurrentValue = date_Modified.FormValue;
            date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
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
            ID.SetDbValue(row["ID"]);
            Nationality_en.SetDbValue(row["Nationality_en"]);
            Nationality_arabic.SetDbValue(row["Nationality_arabic"]);
            IsActive.SetDbValue((ConvertToBool(row["IsActive"]) ? "1" : "0"));
            IsDeleted.SetDbValue((ConvertToBool(row["IsDeleted"]) ? "1" : "0"));
            int_Status.SetDbValue(row["int_Status"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("ID", ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Nationality_en", Nationality_en.DefaultValue ?? DbNullValue); // DN
            row.Add("Nationality_arabic", Nationality_arabic.DefaultValue ?? DbNullValue); // DN
            row.Add("IsActive", IsActive.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDeleted", IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
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

            // ID
            ID.RowCssClass = "row";

            // Nationality_en
            Nationality_en.RowCssClass = "row";

            // Nationality_arabic
            Nationality_arabic.RowCssClass = "row";

            // IsActive
            IsActive.RowCssClass = "row";

            // IsDeleted
            IsDeleted.RowCssClass = "row";

            // int_Status
            int_Status.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // ID
                ID.ViewValue = ID.CurrentValue;
                ID.ViewCustomAttributes = "";

                // Nationality_en
                Nationality_en.ViewValue = ConvertToString(Nationality_en.CurrentValue); // DN
                Nationality_en.ViewCustomAttributes = "";

                // Nationality_arabic
                Nationality_arabic.ViewValue = ConvertToString(Nationality_arabic.CurrentValue); // DN
                Nationality_arabic.ViewCustomAttributes = "";

                // IsActive
                if (ConvertToBool(IsActive.CurrentValue)) {
                    IsActive.ViewValue = IsActive.TagCaption(1) != "" ? IsActive.TagCaption(1) : "Yes";
                } else {
                    IsActive.ViewValue = IsActive.TagCaption(2) != "" ? IsActive.TagCaption(2) : "No";
                }
                IsActive.ViewCustomAttributes = "";

                // IsDeleted
                if (ConvertToBool(IsDeleted.CurrentValue)) {
                    IsDeleted.ViewValue = IsDeleted.TagCaption(1) != "" ? IsDeleted.TagCaption(1) : "Yes";
                } else {
                    IsDeleted.ViewValue = IsDeleted.TagCaption(2) != "" ? IsDeleted.TagCaption(2) : "No";
                }
                IsDeleted.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

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

                // ID
                ID.HrefValue = "";

                // Nationality_en
                Nationality_en.HrefValue = "";

                // Nationality_arabic
                Nationality_arabic.HrefValue = "";

                // IsActive
                IsActive.HrefValue = "";

                // IsDeleted
                IsDeleted.HrefValue = "";

                // int_Status
                int_Status.HrefValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";

                // date_Created
                date_Created.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // ID
                ID.SetupEditAttributes();
                ID.EditValue = ID.CurrentValue; // DN
                ID.PlaceHolder = RemoveHtml(ID.Caption);

                // Nationality_en
                Nationality_en.SetupEditAttributes();
                if (!Nationality_en.Raw)
                    Nationality_en.CurrentValue = HtmlDecode(Nationality_en.CurrentValue);
                Nationality_en.EditValue = HtmlEncode(Nationality_en.CurrentValue);
                Nationality_en.PlaceHolder = RemoveHtml(Nationality_en.Caption);

                // Nationality_arabic
                Nationality_arabic.SetupEditAttributes();
                if (!Nationality_arabic.Raw)
                    Nationality_arabic.CurrentValue = HtmlDecode(Nationality_arabic.CurrentValue);
                Nationality_arabic.EditValue = HtmlEncode(Nationality_arabic.CurrentValue);
                Nationality_arabic.PlaceHolder = RemoveHtml(Nationality_arabic.Caption);

                // IsActive
                IsActive.EditValue = IsActive.Options(false);
                IsActive.PlaceHolder = RemoveHtml(IsActive.Caption);

                // IsDeleted
                IsDeleted.EditValue = IsDeleted.Options(false);
                IsDeleted.PlaceHolder = RemoveHtml(IsDeleted.Caption);

                // int_Status
                int_Status.SetupEditAttributes();
                int_Status.EditValue = int_Status.CurrentValue; // DN
                int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
                if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                    int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

                // int_Created_By
                int_Created_By.SetupEditAttributes();
                int_Created_By.EditValue = int_Created_By.CurrentValue; // DN
                int_Created_By.PlaceHolder = RemoveHtml(int_Created_By.Caption);
                if (!Empty(int_Created_By.EditValue) && IsNumeric(int_Created_By.EditValue))
                    int_Created_By.EditValue = FormatNumber(int_Created_By.EditValue, null);

                // int_Modified_By
                int_Modified_By.SetupEditAttributes();
                int_Modified_By.EditValue = int_Modified_By.CurrentValue; // DN
                int_Modified_By.PlaceHolder = RemoveHtml(int_Modified_By.Caption);
                if (!Empty(int_Modified_By.EditValue) && IsNumeric(int_Modified_By.EditValue))
                    int_Modified_By.EditValue = FormatNumber(int_Modified_By.EditValue, null);

                // date_Created
                date_Created.SetupEditAttributes();
                date_Created.EditValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern); // DN
                date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

                // date_Modified
                date_Modified.SetupEditAttributes();
                date_Modified.EditValue = FormatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern); // DN
                date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

                // Add refer script

                // ID
                ID.HrefValue = "";

                // Nationality_en
                Nationality_en.HrefValue = "";

                // Nationality_arabic
                Nationality_arabic.HrefValue = "";

                // IsActive
                IsActive.HrefValue = "";

                // IsDeleted
                IsDeleted.HrefValue = "";

                // int_Status
                int_Status.HrefValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";

                // date_Created
                date_Created.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
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
            if (ID.Required) {
                if (!ID.IsDetailKey && Empty(ID.FormValue)) {
                    ID.AddErrorMessage(ConvertToString(ID.RequiredErrorMessage).Replace("%s", ID.Caption));
                }
            }
            if (!CheckInteger(ID.FormValue)) {
                ID.AddErrorMessage(ID.GetErrorMessage(false));
            }
            if (Nationality_en.Required) {
                if (!Nationality_en.IsDetailKey && Empty(Nationality_en.FormValue)) {
                    Nationality_en.AddErrorMessage(ConvertToString(Nationality_en.RequiredErrorMessage).Replace("%s", Nationality_en.Caption));
                }
            }
            if (Nationality_arabic.Required) {
                if (!Nationality_arabic.IsDetailKey && Empty(Nationality_arabic.FormValue)) {
                    Nationality_arabic.AddErrorMessage(ConvertToString(Nationality_arabic.RequiredErrorMessage).Replace("%s", Nationality_arabic.Caption));
                }
            }
            if (IsActive.Required) {
                if (Empty(IsActive.FormValue)) {
                    IsActive.AddErrorMessage(ConvertToString(IsActive.RequiredErrorMessage).Replace("%s", IsActive.Caption));
                }
            }
            if (IsDeleted.Required) {
                if (Empty(IsDeleted.FormValue)) {
                    IsDeleted.AddErrorMessage(ConvertToString(IsDeleted.RequiredErrorMessage).Replace("%s", IsDeleted.Caption));
                }
            }
            if (int_Status.Required) {
                if (!int_Status.IsDetailKey && Empty(int_Status.FormValue)) {
                    int_Status.AddErrorMessage(ConvertToString(int_Status.RequiredErrorMessage).Replace("%s", int_Status.Caption));
                }
            }
            if (!CheckInteger(int_Status.FormValue)) {
                int_Status.AddErrorMessage(int_Status.GetErrorMessage(false));
            }
            if (int_Created_By.Required) {
                if (!int_Created_By.IsDetailKey && Empty(int_Created_By.FormValue)) {
                    int_Created_By.AddErrorMessage(ConvertToString(int_Created_By.RequiredErrorMessage).Replace("%s", int_Created_By.Caption));
                }
            }
            if (!CheckNumber(int_Created_By.FormValue)) {
                int_Created_By.AddErrorMessage(int_Created_By.GetErrorMessage(false));
            }
            if (int_Modified_By.Required) {
                if (!int_Modified_By.IsDetailKey && Empty(int_Modified_By.FormValue)) {
                    int_Modified_By.AddErrorMessage(ConvertToString(int_Modified_By.RequiredErrorMessage).Replace("%s", int_Modified_By.Caption));
                }
            }
            if (!CheckNumber(int_Modified_By.FormValue)) {
                int_Modified_By.AddErrorMessage(int_Modified_By.GetErrorMessage(false));
            }
            if (date_Created.Required) {
                if (!date_Created.IsDetailKey && Empty(date_Created.FormValue)) {
                    date_Created.AddErrorMessage(ConvertToString(date_Created.RequiredErrorMessage).Replace("%s", date_Created.Caption));
                }
            }
            if (!CheckDate(date_Created.FormValue, date_Created.FormatPattern)) {
                date_Created.AddErrorMessage(date_Created.GetErrorMessage(false));
            }
            if (date_Modified.Required) {
                if (!date_Modified.IsDetailKey && Empty(date_Modified.FormValue)) {
                    date_Modified.AddErrorMessage(ConvertToString(date_Modified.RequiredErrorMessage).Replace("%s", date_Modified.Caption));
                }
            }
            if (!CheckDate(date_Modified.FormValue, date_Modified.FormatPattern)) {
                date_Modified.AddErrorMessage(date_Modified.GetErrorMessage(false));
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
                // ID
                ID.SetDbValue(rsnew, ID.CurrentValue);

                // Nationality_en
                Nationality_en.SetDbValue(rsnew, Nationality_en.CurrentValue);

                // Nationality_arabic
                Nationality_arabic.SetDbValue(rsnew, Nationality_arabic.CurrentValue);

                // IsActive
                IsActive.SetDbValue(rsnew, ConvertToBool(IsActive.CurrentValue));

                // IsDeleted
                IsDeleted.SetDbValue(rsnew, ConvertToBool(IsDeleted.CurrentValue));

                // int_Status
                int_Status.SetDbValue(rsnew, int_Status.CurrentValue);

                // int_Created_By
                int_Created_By.SetDbValue(rsnew, int_Created_By.CurrentValue);

                // int_Modified_By
                int_Modified_By.SetDbValue(rsnew, int_Modified_By.CurrentValue);

                // date_Created
                date_Created.SetDbValue(rsnew, ConvertToDateTime(date_Created.CurrentValue, date_Created.FormatPattern));

                // date_Modified
                date_Modified.SetDbValue(rsnew, ConvertToDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern));
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }

            // Update current values
            SetCurrentValues(rsnew);
            if (!Empty(ID.CurrentValue)) { // Check field with unique index
                var filter = "(ID = " + AdjustSql(ID.CurrentValue, DbId) + ")";
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupIndex").Replace("%f", ID.Caption).Replace("%v", ConvertToString(ID.CurrentValue));
                    return JsonBoolResult.FalseResult;
                }
            }

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);

            // Check if key value entered
            if (insertRow && ValidateKey && Empty(rsnew["ID"])) {
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblNationalityList")), "", TableVar, true);
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
