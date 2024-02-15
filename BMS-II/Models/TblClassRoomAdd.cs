namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblClassRoomAdd
    /// </summary>
    public static TblClassRoomAdd tblClassRoomAdd
    {
        get => HttpData.Get<TblClassRoomAdd>("tblClassRoomAdd")!;
        set => HttpData["tblClassRoomAdd"] = value;
    }

    /// <summary>
    /// Page class for tblClassRoom
    /// </summary>
    public class TblClassRoomAdd : TblClassRoomAddBase
    {
        // Constructor
        public TblClassRoomAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblClassRoomAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblClassRoomAddBase : TblClassRoom
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblClassRoom";

        // Page object name
        public string PageObjName = "tblClassRoomAdd";

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
        public TblClassRoomAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblClassRoom)
            if (tblClassRoom == null || tblClassRoom is TblClassRoom)
                tblClassRoom = this;

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
        public string PageName => "TblClassRoomAdd";

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
            int_CR_ID.Visible = false;
            str_CR_Number.Visible = false;
            int_CR_Product_ID.SetVisibility();
            str_Package_Name.Visible = false;
            date_Start.SetVisibility();
            mon_CR_Price.SetVisibility();
            int_CR_Size.SetVisibility();
            int_MU_Size.SetVisibility();
            int_CR_Status.SetVisibility();
            Is_Web_SignUp.SetVisibility();
            int_TotSession.SetVisibility();
            int_PerDaySession.SetVisibility();
            int_Location_ID.SetVisibility();
            int_Teacher_ID.SetVisibility();
            str_CR_Notes.SetVisibility();
            is_ZoomMeet.SetVisibility();
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            date_Created.Visible = false;
            date_Modified.Visible = false;
            bit_IsDeleted.Visible = false;
            bit_AllTeacher.Visible = false;
            int_Manual_Change.Visible = false;
            str_WebDesc.Visible = false;
            is_Show.Visible = false;
            is_ShowGridColumn.Visible = false;
            rowIndex.Visible = false;
            Classroom_Internal_Cr_Notes.Visible = false;
            BulkCR_Set.SetVisibility();
            str_Username.SetVisibility();
            Calendar_ID.Visible = false;
            int_Day_Incremental.SetVisibility();
            int_Reoccurrence.SetVisibility();
            date_Start2.SetVisibility();
            date_Start3.SetVisibility();
            date_Start4.SetVisibility();
            str_CR_Days.Visible = false;
        }

        // Constructor
        public TblClassRoomAddBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblClassRoomView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_CR_ID") ? dict["int_CR_ID"] : int_CR_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_CR_ID.Visible = false;
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

        public SubPages? MultiPages; // Multi-Page object

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

            // Set up multi page object
            SetupMultiPages();

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
            await SetupLookupOptions(int_CR_Product_ID);
            await SetupLookupOptions(str_Package_Name);
            await SetupLookupOptions(mon_CR_Price);
            await SetupLookupOptions(int_CR_Size);
            await SetupLookupOptions(int_MU_Size);
            await SetupLookupOptions(int_CR_Status);
            await SetupLookupOptions(Is_Web_SignUp);
            await SetupLookupOptions(int_TotSession);
            await SetupLookupOptions(int_PerDaySession);
            await SetupLookupOptions(int_Teacher_ID);
            await SetupLookupOptions(is_ZoomMeet);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_AllTeacher);
            await SetupLookupOptions(is_Show);
            await SetupLookupOptions(is_ShowGridColumn);
            await SetupLookupOptions(BulkCR_Set);
            await SetupLookupOptions(str_CR_Days);

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
                if (RouteValues.TryGetValue("int_CR_ID", out rv)) { // DN
                    int_CR_ID.QueryValue = UrlDecode(rv); // DN
                } else if (Get("int_CR_ID", out sv)) {
                    int_CR_ID.QueryValue = sv.ToString();
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
                        return Terminate("TblClassRoomList"); // No matching record, return to List page // DN
                    }
                    break;
                case "insert": // Add new record // DN
                    SendEmail = true; // Send email on add success
                    var res = await AddRow(rsold);
                    if (res) { // Add successful
                        if (Empty(SuccessMessage) && Post("addopt") != "1") // Skip success message for addopt (done in JavaScript)
                            SuccessMessage = Language.Phrase("AddSuccess"); // Set up success message
                        string returnUrl = "";
                        returnUrl = ViewUrl;
                        if (GetPageName(returnUrl) == "TblClassRoomList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "TblClassRoomView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblClassRoomList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblClassRoomList"; // Return list page content
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
                tblClassRoomAdd?.PageRender();
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
            is_ZoomMeet.DefaultValue = is_ZoomMeet.GetDefault(); // DN
            is_ZoomMeet.OldValue = is_ZoomMeet.DefaultValue;
            str_CR_Days.DefaultValue = str_CR_Days.GetDefault(); // DN
            str_CR_Days.OldValue = str_CR_Days.DefaultValue;
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'int_CR_Product_ID' before field var 'x_int_CR_Product_ID'
            val = CurrentForm.HasValue("int_CR_Product_ID") ? CurrentForm.GetValue("int_CR_Product_ID") : CurrentForm.GetValue("x_int_CR_Product_ID");
            if (!int_CR_Product_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CR_Product_ID") && !CurrentForm.HasValue("x_int_CR_Product_ID")) // DN
                    int_CR_Product_ID.Visible = false; // Disable update for API request
                else
                    int_CR_Product_ID.SetFormValue(val);
            }

            // Check field name 'date_Start' before field var 'x_date_Start'
            val = CurrentForm.HasValue("date_Start") ? CurrentForm.GetValue("date_Start") : CurrentForm.GetValue("x_date_Start");
            if (!date_Start.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Start") && !CurrentForm.HasValue("x_date_Start")) // DN
                    date_Start.Visible = false; // Disable update for API request
                else
                    date_Start.SetFormValue(val, true, validate);
                date_Start.CurrentValue = UnformatDateTime(date_Start.CurrentValue, date_Start.FormatPattern);
            }

            // Check field name 'mon_CR_Price' before field var 'x_mon_CR_Price'
            val = CurrentForm.HasValue("mon_CR_Price") ? CurrentForm.GetValue("mon_CR_Price") : CurrentForm.GetValue("x_mon_CR_Price");
            if (!mon_CR_Price.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mon_CR_Price") && !CurrentForm.HasValue("x_mon_CR_Price")) // DN
                    mon_CR_Price.Visible = false; // Disable update for API request
                else
                    mon_CR_Price.SetFormValue(val);
            }

            // Check field name 'int_CR_Size' before field var 'x_int_CR_Size'
            val = CurrentForm.HasValue("int_CR_Size") ? CurrentForm.GetValue("int_CR_Size") : CurrentForm.GetValue("x_int_CR_Size");
            if (!int_CR_Size.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CR_Size") && !CurrentForm.HasValue("x_int_CR_Size")) // DN
                    int_CR_Size.Visible = false; // Disable update for API request
                else
                    int_CR_Size.SetFormValue(val);
            }

            // Check field name 'int_MU_Size' before field var 'x_int_MU_Size'
            val = CurrentForm.HasValue("int_MU_Size") ? CurrentForm.GetValue("int_MU_Size") : CurrentForm.GetValue("x_int_MU_Size");
            if (!int_MU_Size.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_MU_Size") && !CurrentForm.HasValue("x_int_MU_Size")) // DN
                    int_MU_Size.Visible = false; // Disable update for API request
                else
                    int_MU_Size.SetFormValue(val);
            }

            // Check field name 'int_CR_Status' before field var 'x_int_CR_Status'
            val = CurrentForm.HasValue("int_CR_Status") ? CurrentForm.GetValue("int_CR_Status") : CurrentForm.GetValue("x_int_CR_Status");
            if (!int_CR_Status.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CR_Status") && !CurrentForm.HasValue("x_int_CR_Status")) // DN
                    int_CR_Status.Visible = false; // Disable update for API request
                else
                    int_CR_Status.SetFormValue(val);
            }

            // Check field name 'Is_Web_SignUp' before field var 'x_Is_Web_SignUp'
            val = CurrentForm.HasValue("Is_Web_SignUp") ? CurrentForm.GetValue("Is_Web_SignUp") : CurrentForm.GetValue("x_Is_Web_SignUp");
            if (!Is_Web_SignUp.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Is_Web_SignUp") && !CurrentForm.HasValue("x_Is_Web_SignUp")) // DN
                    Is_Web_SignUp.Visible = false; // Disable update for API request
                else
                    Is_Web_SignUp.SetFormValue(val);
            }

            // Check field name 'int_TotSession' before field var 'x_int_TotSession'
            val = CurrentForm.HasValue("int_TotSession") ? CurrentForm.GetValue("int_TotSession") : CurrentForm.GetValue("x_int_TotSession");
            if (!int_TotSession.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_TotSession") && !CurrentForm.HasValue("x_int_TotSession")) // DN
                    int_TotSession.Visible = false; // Disable update for API request
                else
                    int_TotSession.SetFormValue(val);
            }

            // Check field name 'int_PerDaySession' before field var 'x_int_PerDaySession'
            val = CurrentForm.HasValue("int_PerDaySession") ? CurrentForm.GetValue("int_PerDaySession") : CurrentForm.GetValue("x_int_PerDaySession");
            if (!int_PerDaySession.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_PerDaySession") && !CurrentForm.HasValue("x_int_PerDaySession")) // DN
                    int_PerDaySession.Visible = false; // Disable update for API request
                else
                    int_PerDaySession.SetFormValue(val);
            }

            // Check field name 'int_Location_ID' before field var 'x_int_Location_ID'
            val = CurrentForm.HasValue("int_Location_ID") ? CurrentForm.GetValue("int_Location_ID") : CurrentForm.GetValue("x_int_Location_ID");
            if (!int_Location_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Location_ID") && !CurrentForm.HasValue("x_int_Location_ID")) // DN
                    int_Location_ID.Visible = false; // Disable update for API request
                else
                    int_Location_ID.SetFormValue(val);
            }

            // Check field name 'int_Teacher_ID' before field var 'x_int_Teacher_ID'
            val = CurrentForm.HasValue("int_Teacher_ID") ? CurrentForm.GetValue("int_Teacher_ID") : CurrentForm.GetValue("x_int_Teacher_ID");
            if (!int_Teacher_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Teacher_ID") && !CurrentForm.HasValue("x_int_Teacher_ID")) // DN
                    int_Teacher_ID.Visible = false; // Disable update for API request
                else
                    int_Teacher_ID.SetFormValue(val);
            }

            // Check field name 'str_CR_Notes' before field var 'x_str_CR_Notes'
            val = CurrentForm.HasValue("str_CR_Notes") ? CurrentForm.GetValue("str_CR_Notes") : CurrentForm.GetValue("x_str_CR_Notes");
            if (!str_CR_Notes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_CR_Notes") && !CurrentForm.HasValue("x_str_CR_Notes")) // DN
                    str_CR_Notes.Visible = false; // Disable update for API request
                else
                    str_CR_Notes.SetFormValue(val);
            }

            // Check field name 'is_ZoomMeet' before field var 'x_is_ZoomMeet'
            val = CurrentForm.HasValue("is_ZoomMeet") ? CurrentForm.GetValue("is_ZoomMeet") : CurrentForm.GetValue("x_is_ZoomMeet");
            if (!is_ZoomMeet.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("is_ZoomMeet") && !CurrentForm.HasValue("x_is_ZoomMeet")) // DN
                    is_ZoomMeet.Visible = false; // Disable update for API request
                else
                    is_ZoomMeet.SetFormValue(val);
            }

            // Check field name 'BulkCR_Set' before field var 'x_BulkCR_Set[]'
            val = CurrentForm.HasValue("BulkCR_Set") ? CurrentForm.GetValue("BulkCR_Set") : CurrentForm.GetValue("x_BulkCR_Set[]");
            if (!BulkCR_Set.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("BulkCR_Set") && !CurrentForm.HasValue("x_BulkCR_Set[]")) // DN
                    BulkCR_Set.Visible = false; // Disable update for API request
                else
                    BulkCR_Set.SetFormValue(val);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }

            // Check field name 'int_Day_Incremental' before field var 'x_int_Day_Incremental'
            val = CurrentForm.HasValue("int_Day_Incremental") ? CurrentForm.GetValue("int_Day_Incremental") : CurrentForm.GetValue("x_int_Day_Incremental");
            if (!int_Day_Incremental.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Day_Incremental") && !CurrentForm.HasValue("x_int_Day_Incremental")) // DN
                    int_Day_Incremental.Visible = false; // Disable update for API request
                else
                    int_Day_Incremental.SetFormValue(val, true, validate);
            }

            // Check field name 'int_Reoccurrence' before field var 'x_int_Reoccurrence'
            val = CurrentForm.HasValue("int_Reoccurrence") ? CurrentForm.GetValue("int_Reoccurrence") : CurrentForm.GetValue("x_int_Reoccurrence");
            if (!int_Reoccurrence.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Reoccurrence") && !CurrentForm.HasValue("x_int_Reoccurrence")) // DN
                    int_Reoccurrence.Visible = false; // Disable update for API request
                else
                    int_Reoccurrence.SetFormValue(val, true, validate);
            }

            // Check field name 'date_Start2' before field var 'x_date_Start2'
            val = CurrentForm.HasValue("date_Start2") ? CurrentForm.GetValue("date_Start2") : CurrentForm.GetValue("x_date_Start2");
            if (!date_Start2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Start2") && !CurrentForm.HasValue("x_date_Start2")) // DN
                    date_Start2.Visible = false; // Disable update for API request
                else
                    date_Start2.SetFormValue(val, true, validate);
                date_Start2.CurrentValue = UnformatDateTime(date_Start2.CurrentValue, date_Start2.FormatPattern);
            }

            // Check field name 'date_Start3' before field var 'x_date_Start3'
            val = CurrentForm.HasValue("date_Start3") ? CurrentForm.GetValue("date_Start3") : CurrentForm.GetValue("x_date_Start3");
            if (!date_Start3.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Start3") && !CurrentForm.HasValue("x_date_Start3")) // DN
                    date_Start3.Visible = false; // Disable update for API request
                else
                    date_Start3.SetFormValue(val, true, validate);
                date_Start3.CurrentValue = UnformatDateTime(date_Start3.CurrentValue, date_Start3.FormatPattern);
            }

            // Check field name 'date_Start4' before field var 'x_date_Start4'
            val = CurrentForm.HasValue("date_Start4") ? CurrentForm.GetValue("date_Start4") : CurrentForm.GetValue("x_date_Start4");
            if (!date_Start4.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Start4") && !CurrentForm.HasValue("x_date_Start4")) // DN
                    date_Start4.Visible = false; // Disable update for API request
                else
                    date_Start4.SetFormValue(val, true, validate);
                date_Start4.CurrentValue = UnformatDateTime(date_Start4.CurrentValue, date_Start4.FormatPattern);
            }

            // Check field name 'int_CR_ID' before field var 'x_int_CR_ID'
            val = CurrentForm.HasValue("int_CR_ID") ? CurrentForm.GetValue("int_CR_ID") : CurrentForm.GetValue("x_int_CR_ID");
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_CR_Product_ID.CurrentValue = int_CR_Product_ID.FormValue;
            date_Start.CurrentValue = date_Start.FormValue;
            date_Start.CurrentValue = UnformatDateTime(date_Start.CurrentValue, date_Start.FormatPattern);
            mon_CR_Price.CurrentValue = mon_CR_Price.FormValue;
            int_CR_Size.CurrentValue = int_CR_Size.FormValue;
            int_MU_Size.CurrentValue = int_MU_Size.FormValue;
            int_CR_Status.CurrentValue = int_CR_Status.FormValue;
            Is_Web_SignUp.CurrentValue = Is_Web_SignUp.FormValue;
            int_TotSession.CurrentValue = int_TotSession.FormValue;
            int_PerDaySession.CurrentValue = int_PerDaySession.FormValue;
            int_Location_ID.CurrentValue = int_Location_ID.FormValue;
            int_Teacher_ID.CurrentValue = int_Teacher_ID.FormValue;
            str_CR_Notes.CurrentValue = str_CR_Notes.FormValue;
            is_ZoomMeet.CurrentValue = is_ZoomMeet.FormValue;
            BulkCR_Set.CurrentValue = BulkCR_Set.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            int_Day_Incremental.CurrentValue = int_Day_Incremental.FormValue;
            int_Reoccurrence.CurrentValue = int_Reoccurrence.FormValue;
            date_Start2.CurrentValue = date_Start2.FormValue;
            date_Start2.CurrentValue = UnformatDateTime(date_Start2.CurrentValue, date_Start2.FormatPattern);
            date_Start3.CurrentValue = date_Start3.FormValue;
            date_Start3.CurrentValue = UnformatDateTime(date_Start3.CurrentValue, date_Start3.FormatPattern);
            date_Start4.CurrentValue = date_Start4.FormValue;
            date_Start4.CurrentValue = UnformatDateTime(date_Start4.CurrentValue, date_Start4.FormatPattern);
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
            int_CR_ID.SetDbValue(row["int_CR_ID"]);
            str_CR_Number.SetDbValue(row["str_CR_Number"]);
            int_CR_Product_ID.SetDbValue(row["int_CR_Product_ID"]);
            str_Package_Name.SetDbValue(row["str_Package_Name"]);
            date_Start.SetDbValue(row["date_Start"]);
            mon_CR_Price.SetDbValue(row["mon_CR_Price"]);
            int_CR_Size.SetDbValue(row["int_CR_Size"]);
            int_MU_Size.SetDbValue(row["int_MU_Size"]);
            int_CR_Status.SetDbValue(row["int_CR_Status"]);
            Is_Web_SignUp.SetDbValue((ConvertToBool(row["Is_Web_SignUp"]) ? "1" : "0"));
            int_TotSession.SetDbValue(row["int_TotSession"]);
            int_PerDaySession.SetDbValue(row["int_PerDaySession"]);
            int_Location_ID.SetDbValue(row["int_Location_ID"]);
            int_Teacher_ID.SetDbValue(row["int_Teacher_ID"]);
            str_CR_Notes.SetDbValue(row["str_CR_Notes"]);
            is_ZoomMeet.SetDbValue((ConvertToBool(row["is_ZoomMeet"]) ? "1" : "0"));
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            bit_AllTeacher.SetDbValue((ConvertToBool(row["bit_AllTeacher"]) ? "1" : "0"));
            int_Manual_Change.SetDbValue(row["int_Manual_Change"]);
            str_WebDesc.SetDbValue(row["str_WebDesc"]);
            is_Show.SetDbValue((ConvertToBool(row["is_Show"]) ? "1" : "0"));
            is_ShowGridColumn.SetDbValue((ConvertToBool(row["is_ShowGridColumn"]) ? "1" : "0"));
            rowIndex.SetDbValue(row["rowIndex"]);
            Classroom_Internal_Cr_Notes.SetDbValue(row["Classroom_Internal_Cr_Notes"]);
            BulkCR_Set.SetDbValue(row["BulkCR_Set"]);
            str_Username.SetDbValue(row["str_Username"]);
            Calendar_ID.SetDbValue(row["Calendar_ID"]);
            int_Day_Incremental.SetDbValue(row["int_Day_Incremental"]);
            int_Reoccurrence.SetDbValue(row["int_Reoccurrence"]);
            date_Start2.SetDbValue(row["date_Start2"]);
            date_Start3.SetDbValue(row["date_Start3"]);
            date_Start4.SetDbValue(row["date_Start4"]);
            str_CR_Days.SetDbValue(row["str_CR_Days"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_CR_ID", int_CR_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Number", str_CR_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Product_ID", int_CR_Product_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Package_Name", str_Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start", date_Start.DefaultValue ?? DbNullValue); // DN
            row.Add("mon_CR_Price", mon_CR_Price.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Size", int_CR_Size.DefaultValue ?? DbNullValue); // DN
            row.Add("int_MU_Size", int_MU_Size.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Status", int_CR_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("Is_Web_SignUp", Is_Web_SignUp.DefaultValue ?? DbNullValue); // DN
            row.Add("int_TotSession", int_TotSession.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PerDaySession", int_PerDaySession.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_ID", int_Location_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Teacher_ID", int_Teacher_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Notes", str_CR_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("is_ZoomMeet", is_ZoomMeet.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_AllTeacher", bit_AllTeacher.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Manual_Change", int_Manual_Change.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebDesc", str_WebDesc.DefaultValue ?? DbNullValue); // DN
            row.Add("is_Show", is_Show.DefaultValue ?? DbNullValue); // DN
            row.Add("is_ShowGridColumn", is_ShowGridColumn.DefaultValue ?? DbNullValue); // DN
            row.Add("rowIndex", rowIndex.DefaultValue ?? DbNullValue); // DN
            row.Add("Classroom_Internal_Cr_Notes", Classroom_Internal_Cr_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("BulkCR_Set", BulkCR_Set.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("Calendar_ID", Calendar_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Day_Incremental", int_Day_Incremental.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Reoccurrence", int_Reoccurrence.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start2", date_Start2.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start3", date_Start3.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Start4", date_Start4.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Days", str_CR_Days.DefaultValue ?? DbNullValue); // DN
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

            // int_CR_ID
            int_CR_ID.RowCssClass = "row";

            // str_CR_Number
            str_CR_Number.RowCssClass = "row";

            // int_CR_Product_ID
            int_CR_Product_ID.RowCssClass = "row";

            // str_Package_Name
            str_Package_Name.RowCssClass = "row";

            // date_Start
            date_Start.RowCssClass = "row";

            // mon_CR_Price
            mon_CR_Price.RowCssClass = "row";

            // int_CR_Size
            int_CR_Size.RowCssClass = "row";

            // int_MU_Size
            int_MU_Size.RowCssClass = "row";

            // int_CR_Status
            int_CR_Status.RowCssClass = "row";

            // Is_Web_SignUp
            Is_Web_SignUp.RowCssClass = "row";

            // int_TotSession
            int_TotSession.RowCssClass = "row";

            // int_PerDaySession
            int_PerDaySession.RowCssClass = "row";

            // int_Location_ID
            int_Location_ID.RowCssClass = "row";

            // int_Teacher_ID
            int_Teacher_ID.RowCssClass = "row";

            // str_CR_Notes
            str_CR_Notes.RowCssClass = "row";

            // is_ZoomMeet
            is_ZoomMeet.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // bit_IsDeleted
            bit_IsDeleted.RowCssClass = "row";

            // bit_AllTeacher
            bit_AllTeacher.RowCssClass = "row";

            // int_Manual_Change
            int_Manual_Change.RowCssClass = "row";

            // str_WebDesc
            str_WebDesc.RowCssClass = "row";

            // is_Show
            is_Show.RowCssClass = "row";

            // is_ShowGridColumn
            is_ShowGridColumn.RowCssClass = "row";

            // rowIndex
            rowIndex.RowCssClass = "row";

            // Classroom_Internal_Cr_Notes
            Classroom_Internal_Cr_Notes.RowCssClass = "row";

            // BulkCR_Set
            BulkCR_Set.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // Calendar_ID
            Calendar_ID.RowCssClass = "row";

            // int_Day_Incremental
            int_Day_Incremental.RowCssClass = "row";

            // int_Reoccurrence
            int_Reoccurrence.RowCssClass = "row";

            // date_Start2
            date_Start2.RowCssClass = "row";

            // date_Start3
            date_Start3.RowCssClass = "row";

            // date_Start4
            date_Start4.RowCssClass = "row";

            // str_CR_Days
            str_CR_Days.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // int_CR_ID
                int_CR_ID.ViewValue = int_CR_ID.CurrentValue;
                int_CR_ID.ViewValue = FormatNumber(int_CR_ID.ViewValue, int_CR_ID.FormatPattern);
                int_CR_ID.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.ViewValue = ConvertToString(str_CR_Number.CurrentValue); // DN
                str_CR_Number.ViewCustomAttributes = "";

                // int_CR_Product_ID
                curVal = ConvertToString(int_CR_Product_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_CR_Product_ID.Lookup != null && IsDictionary(int_CR_Product_ID.Lookup?.Options) && int_CR_Product_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_CR_Product_ID.ViewValue = int_CR_Product_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_CR_Product_ID.CurrentValue, DataType.Number, "");
                        lookupFilter = () => int_CR_Product_ID.GetSelectFilter();
                        sqlWrk = int_CR_Product_ID.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_CR_Product_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_CR_Product_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_CR_Product_ID.ViewValue = int_CR_Product_ID.HighlightLookup(ConvertToString(rswrk[0]), int_CR_Product_ID.DisplayValue(listwrk));
                        } else {
                            int_CR_Product_ID.ViewValue = FormatNumber(int_CR_Product_ID.CurrentValue, int_CR_Product_ID.FormatPattern);
                        }
                    }
                } else {
                    int_CR_Product_ID.ViewValue = DbNullValue;
                }
                int_CR_Product_ID.ViewCustomAttributes = "";

                // str_Package_Name
                curVal = ConvertToString(str_Package_Name.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Package_Name.Lookup != null && IsDictionary(str_Package_Name.Lookup?.Options) && str_Package_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Package_Name.ViewValue = str_Package_Name.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Package_Name]", "=", str_Package_Name.CurrentValue, DataType.String, "");
                        sqlWrk = str_Package_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Package_Name.Lookup != null) { // Lookup values found
                            var listwrk = str_Package_Name.Lookup?.RenderViewRow(rswrk[0]);
                            str_Package_Name.ViewValue = str_Package_Name.HighlightLookup(ConvertToString(rswrk[0]), str_Package_Name.DisplayValue(listwrk));
                        } else {
                            str_Package_Name.ViewValue = str_Package_Name.CurrentValue;
                        }
                    }
                } else {
                    str_Package_Name.ViewValue = DbNullValue;
                }
                str_Package_Name.ViewCustomAttributes = "";

                // date_Start
                date_Start.ViewValue = date_Start.CurrentValue;
                date_Start.ViewValue = FormatDateTime(date_Start.ViewValue, date_Start.FormatPattern);
                date_Start.ViewCustomAttributes = "";

                // mon_CR_Price
                curVal = ConvertToString(mon_CR_Price.CurrentValue);
                if (!Empty(curVal)) {
                    if (mon_CR_Price.Lookup != null && IsDictionary(mon_CR_Price.Lookup?.Options) && mon_CR_Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        mon_CR_Price.ViewValue = mon_CR_Price.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[mny_Price]", "=", mon_CR_Price.CurrentValue, DataType.Number, "");
                        sqlWrk = mon_CR_Price.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && mon_CR_Price.Lookup != null) { // Lookup values found
                            var listwrk = mon_CR_Price.Lookup?.RenderViewRow(rswrk[0]);
                            mon_CR_Price.ViewValue = mon_CR_Price.HighlightLookup(ConvertToString(rswrk[0]), mon_CR_Price.DisplayValue(listwrk));
                        } else {
                            mon_CR_Price.ViewValue = FormatCurrency(mon_CR_Price.CurrentValue, mon_CR_Price.FormatPattern);
                        }
                    }
                } else {
                    mon_CR_Price.ViewValue = DbNullValue;
                }
                mon_CR_Price.ViewCustomAttributes = "";

                // int_CR_Size
                if (!Empty(int_CR_Size.CurrentValue)) {
                    int_CR_Size.ViewValue = int_CR_Size.HighlightLookup(ConvertToString(int_CR_Size.CurrentValue), int_CR_Size.OptionCaption(ConvertToString(int_CR_Size.CurrentValue)));
                } else {
                    int_CR_Size.ViewValue = DbNullValue;
                }
                int_CR_Size.ViewCustomAttributes = "";

                // int_MU_Size
                if (!Empty(int_MU_Size.CurrentValue)) {
                    int_MU_Size.ViewValue = int_MU_Size.HighlightLookup(ConvertToString(int_MU_Size.CurrentValue), int_MU_Size.OptionCaption(ConvertToString(int_MU_Size.CurrentValue)));
                } else {
                    int_MU_Size.ViewValue = DbNullValue;
                }
                int_MU_Size.ViewCustomAttributes = "";

                // int_CR_Status
                if (!Empty(int_CR_Status.CurrentValue)) {
                    int_CR_Status.ViewValue = int_CR_Status.HighlightLookup(ConvertToString(int_CR_Status.CurrentValue), int_CR_Status.OptionCaption(ConvertToString(int_CR_Status.CurrentValue)));
                } else {
                    int_CR_Status.ViewValue = DbNullValue;
                }
                int_CR_Status.ViewCustomAttributes = "";

                // Is_Web_SignUp
                if (ConvertToBool(Is_Web_SignUp.CurrentValue)) {
                    Is_Web_SignUp.ViewValue = Is_Web_SignUp.TagCaption(1) != "" ? Is_Web_SignUp.TagCaption(1) : "Yes";
                } else {
                    Is_Web_SignUp.ViewValue = Is_Web_SignUp.TagCaption(2) != "" ? Is_Web_SignUp.TagCaption(2) : "No";
                }
                Is_Web_SignUp.ViewCustomAttributes = "";

                // int_TotSession
                if (!Empty(int_TotSession.CurrentValue)) {
                    int_TotSession.ViewValue = int_TotSession.HighlightLookup(ConvertToString(int_TotSession.CurrentValue), int_TotSession.OptionCaption(ConvertToString(int_TotSession.CurrentValue)));
                } else {
                    int_TotSession.ViewValue = DbNullValue;
                }
                int_TotSession.ViewCustomAttributes = "";

                // int_PerDaySession
                if (!Empty(int_PerDaySession.CurrentValue)) {
                    int_PerDaySession.ViewValue = int_PerDaySession.HighlightLookup(ConvertToString(int_PerDaySession.CurrentValue), int_PerDaySession.OptionCaption(ConvertToString(int_PerDaySession.CurrentValue)));
                } else {
                    int_PerDaySession.ViewValue = DbNullValue;
                }
                int_PerDaySession.ViewCustomAttributes = "";

                // int_Location_ID
                curVal = ConvertToString(int_Location_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Location_ID.Lookup != null && IsDictionary(int_Location_ID.Lookup?.Options) && int_Location_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Location_ID.ViewValue = int_Location_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Location_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Location_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Location_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Location_ID.ViewValue = int_Location_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Location_ID.DisplayValue(listwrk));
                        } else {
                            int_Location_ID.ViewValue = FormatNumber(int_Location_ID.CurrentValue, int_Location_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Location_ID.ViewValue = DbNullValue;
                }
                int_Location_ID.ViewCustomAttributes = "";

                // int_Teacher_ID
                curVal = ConvertToString(int_Teacher_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Teacher_ID.Lookup != null && IsDictionary(int_Teacher_ID.Lookup?.Options) && int_Teacher_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Teacher_ID.ViewValue = int_Teacher_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Staff_Id]", "=", int_Teacher_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Teacher_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Teacher_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Teacher_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Teacher_ID.ViewValue = int_Teacher_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Teacher_ID.DisplayValue(listwrk));
                        } else {
                            int_Teacher_ID.ViewValue = FormatNumber(int_Teacher_ID.CurrentValue, int_Teacher_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Teacher_ID.ViewValue = DbNullValue;
                }
                int_Teacher_ID.ViewCustomAttributes = "";

                // str_CR_Notes
                str_CR_Notes.ViewValue = str_CR_Notes.CurrentValue;
                str_CR_Notes.ViewCustomAttributes = "";

                // is_ZoomMeet
                if (ConvertToBool(is_ZoomMeet.CurrentValue)) {
                    is_ZoomMeet.ViewValue = is_ZoomMeet.TagCaption(1) != "" ? is_ZoomMeet.TagCaption(1) : "Yes";
                } else {
                    is_ZoomMeet.ViewValue = is_ZoomMeet.TagCaption(2) != "" ? is_ZoomMeet.TagCaption(2) : "No";
                }
                is_ZoomMeet.ViewCustomAttributes = "";

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

                // bit_AllTeacher
                if (ConvertToBool(bit_AllTeacher.CurrentValue)) {
                    bit_AllTeacher.ViewValue = bit_AllTeacher.TagCaption(1) != "" ? bit_AllTeacher.TagCaption(1) : "Yes";
                } else {
                    bit_AllTeacher.ViewValue = bit_AllTeacher.TagCaption(2) != "" ? bit_AllTeacher.TagCaption(2) : "No";
                }
                bit_AllTeacher.ViewCustomAttributes = "";

                // int_Manual_Change
                int_Manual_Change.ViewValue = int_Manual_Change.CurrentValue;
                int_Manual_Change.ViewValue = FormatNumber(int_Manual_Change.ViewValue, int_Manual_Change.FormatPattern);
                int_Manual_Change.ViewCustomAttributes = "";

                // str_WebDesc
                str_WebDesc.ViewValue = ConvertToString(str_WebDesc.CurrentValue); // DN
                str_WebDesc.ViewCustomAttributes = "";

                // is_Show
                if (ConvertToBool(is_Show.CurrentValue)) {
                    is_Show.ViewValue = is_Show.TagCaption(1) != "" ? is_Show.TagCaption(1) : "Yes";
                } else {
                    is_Show.ViewValue = is_Show.TagCaption(2) != "" ? is_Show.TagCaption(2) : "No";
                }
                is_Show.ViewCustomAttributes = "";

                // is_ShowGridColumn
                if (ConvertToBool(is_ShowGridColumn.CurrentValue)) {
                    is_ShowGridColumn.ViewValue = is_ShowGridColumn.TagCaption(1) != "" ? is_ShowGridColumn.TagCaption(1) : "Yes";
                } else {
                    is_ShowGridColumn.ViewValue = is_ShowGridColumn.TagCaption(2) != "" ? is_ShowGridColumn.TagCaption(2) : "No";
                }
                is_ShowGridColumn.ViewCustomAttributes = "";

                // rowIndex
                rowIndex.ViewValue = ConvertToString(rowIndex.CurrentValue); // DN
                rowIndex.ViewCustomAttributes = "";

                // BulkCR_Set
                if (!Empty(BulkCR_Set.CurrentValue)) {
                    var optionsWrk = new OptionValues();
                    arWrk = ConvertToString(BulkCR_Set.CurrentValue).Split(Config.MultipleOptionSeparator);
                    for (int i = 0; i < arWrk.Length; i++) {
                        optionsWrk.Add(BulkCR_Set.HighlightLookup(arWrk[i].Trim(), BulkCR_Set.OptionCaption(arWrk[i].Trim())));
                    }
                    BulkCR_Set.ViewValue = optionsWrk.ToString(); // DN
                } else {
                    BulkCR_Set.ViewValue = DbNullValue;
                }
                BulkCR_Set.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = str_Username.CurrentValue;
                str_Username.ViewCustomAttributes = "";

                // Calendar_ID
                Calendar_ID.ViewValue = Calendar_ID.CurrentValue;
                Calendar_ID.ViewValue = FormatNumber(Calendar_ID.ViewValue, Calendar_ID.FormatPattern);
                Calendar_ID.ViewCustomAttributes = "";

                // int_Day_Incremental
                int_Day_Incremental.ViewValue = int_Day_Incremental.CurrentValue;
                int_Day_Incremental.ViewValue = FormatNumber(int_Day_Incremental.ViewValue, int_Day_Incremental.FormatPattern);
                int_Day_Incremental.ViewCustomAttributes = "";

                // int_Reoccurrence
                int_Reoccurrence.ViewValue = int_Reoccurrence.CurrentValue;
                int_Reoccurrence.ViewValue = FormatNumber(int_Reoccurrence.ViewValue, int_Reoccurrence.FormatPattern);
                int_Reoccurrence.ViewCustomAttributes = "";

                // date_Start2
                date_Start2.ViewValue = date_Start2.CurrentValue;
                date_Start2.ViewValue = FormatDateTime(date_Start2.ViewValue, date_Start2.FormatPattern);
                date_Start2.ViewCustomAttributes = "";

                // date_Start3
                date_Start3.ViewValue = date_Start3.CurrentValue;
                date_Start3.ViewValue = FormatDateTime(date_Start3.ViewValue, date_Start3.FormatPattern);
                date_Start3.ViewCustomAttributes = "";

                // date_Start4
                date_Start4.ViewValue = date_Start4.CurrentValue;
                date_Start4.ViewValue = FormatDateTime(date_Start4.ViewValue, date_Start4.FormatPattern);
                date_Start4.ViewCustomAttributes = "";

                // str_CR_Days
                if (!Empty(str_CR_Days.CurrentValue)) {
                    var optionsWrk = new OptionValues();
                    arWrk = ConvertToString(str_CR_Days.CurrentValue).Split(Config.MultipleOptionSeparator);
                    for (int i = 0; i < arWrk.Length; i++) {
                        optionsWrk.Add(str_CR_Days.HighlightLookup(arWrk[i].Trim(), str_CR_Days.OptionCaption(arWrk[i].Trim())));
                    }
                    str_CR_Days.ViewValue = optionsWrk.ToString(); // DN
                } else {
                    str_CR_Days.ViewValue = DbNullValue;
                }
                str_CR_Days.ViewCustomAttributes = "";

                // int_CR_Product_ID
                int_CR_Product_ID.HrefValue = "";

                // date_Start
                date_Start.HrefValue = "";

                // mon_CR_Price
                mon_CR_Price.HrefValue = "";

                // int_CR_Size
                int_CR_Size.HrefValue = "";

                // int_MU_Size
                int_MU_Size.HrefValue = "";

                // int_CR_Status
                int_CR_Status.HrefValue = "";

                // Is_Web_SignUp
                Is_Web_SignUp.HrefValue = "";

                // int_TotSession
                int_TotSession.HrefValue = "";

                // int_PerDaySession
                int_PerDaySession.HrefValue = "";

                // int_Location_ID
                int_Location_ID.HrefValue = "";

                // int_Teacher_ID
                int_Teacher_ID.HrefValue = "";

                // str_CR_Notes
                str_CR_Notes.HrefValue = "";

                // is_ZoomMeet
                is_ZoomMeet.HrefValue = "";

                // BulkCR_Set
                BulkCR_Set.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // int_Day_Incremental
                int_Day_Incremental.HrefValue = "";

                // int_Reoccurrence
                int_Reoccurrence.HrefValue = "";

                // date_Start2
                date_Start2.HrefValue = "";

                // date_Start3
                date_Start3.HrefValue = "";

                // date_Start4
                date_Start4.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // int_CR_Product_ID
                int_CR_Product_ID.SetupEditAttributes();
                curVal = ConvertToString(int_CR_Product_ID.CurrentValue)?.Trim() ?? "";
                if (int_CR_Product_ID.Lookup != null && IsDictionary(int_CR_Product_ID.Lookup?.Options) && int_CR_Product_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_CR_Product_ID.EditValue = int_CR_Product_ID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_CR_Product_ID.CurrentValue, DataType.Number, "");
                    }
                    lookupFilter = () => int_CR_Product_ID.GetSelectFilter();
                    sqlWrk = int_CR_Product_ID.Lookup?.GetSql(true, filterWrk, lookupFilter, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_CR_Product_ID.EditValue = rswrk;
                }
                int_CR_Product_ID.PlaceHolder = RemoveHtml(int_CR_Product_ID.Caption);
                if (!Empty(int_CR_Product_ID.EditValue) && IsNumeric(int_CR_Product_ID.EditValue))
                    int_CR_Product_ID.EditValue = FormatNumber(int_CR_Product_ID.EditValue, null);

                // date_Start
                date_Start.SetupEditAttributes();
                date_Start.EditValue = FormatDateTime(date_Start.CurrentValue, date_Start.FormatPattern); // DN
                date_Start.PlaceHolder = RemoveHtml(date_Start.Caption);

                // mon_CR_Price
                mon_CR_Price.SetupEditAttributes();
                curVal = ConvertToString(mon_CR_Price.CurrentValue)?.Trim() ?? "";
                if (mon_CR_Price.Lookup != null && IsDictionary(mon_CR_Price.Lookup?.Options) && mon_CR_Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    mon_CR_Price.EditValue = mon_CR_Price.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[mny_Price]", "=", mon_CR_Price.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = mon_CR_Price.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    mon_CR_Price.EditValue = rswrk;
                }
                mon_CR_Price.PlaceHolder = RemoveHtml(mon_CR_Price.Caption);
                if (!Empty(mon_CR_Price.EditValue) && IsNumeric(mon_CR_Price.EditValue))
                    mon_CR_Price.EditValue = FormatNumber(mon_CR_Price.EditValue, null);

                // int_CR_Size
                int_CR_Size.SetupEditAttributes();
                int_CR_Size.EditValue = int_CR_Size.Options(true);
                int_CR_Size.PlaceHolder = RemoveHtml(int_CR_Size.Caption);
                if (!Empty(int_CR_Size.EditValue) && IsNumeric(int_CR_Size.EditValue))
                    int_CR_Size.EditValue = FormatNumber(int_CR_Size.EditValue, null);

                // int_MU_Size
                int_MU_Size.SetupEditAttributes();
                int_MU_Size.EditValue = int_MU_Size.Options(true);
                int_MU_Size.PlaceHolder = RemoveHtml(int_MU_Size.Caption);
                if (!Empty(int_MU_Size.EditValue) && IsNumeric(int_MU_Size.EditValue))
                    int_MU_Size.EditValue = FormatNumber(int_MU_Size.EditValue, null);

                // int_CR_Status
                int_CR_Status.SetupEditAttributes();
                int_CR_Status.EditValue = int_CR_Status.Options(true);
                int_CR_Status.PlaceHolder = RemoveHtml(int_CR_Status.Caption);
                if (!Empty(int_CR_Status.EditValue) && IsNumeric(int_CR_Status.EditValue))
                    int_CR_Status.EditValue = FormatNumber(int_CR_Status.EditValue, null);

                // Is_Web_SignUp
                Is_Web_SignUp.EditValue = Is_Web_SignUp.Options(false);
                Is_Web_SignUp.PlaceHolder = RemoveHtml(Is_Web_SignUp.Caption);

                // int_TotSession
                int_TotSession.SetupEditAttributes();
                int_TotSession.EditValue = int_TotSession.Options(true);
                int_TotSession.PlaceHolder = RemoveHtml(int_TotSession.Caption);
                if (!Empty(int_TotSession.EditValue) && IsNumeric(int_TotSession.EditValue))
                    int_TotSession.EditValue = FormatNumber(int_TotSession.EditValue, null);

                // int_PerDaySession
                int_PerDaySession.SetupEditAttributes();
                int_PerDaySession.EditValue = int_PerDaySession.Options(true);
                int_PerDaySession.PlaceHolder = RemoveHtml(int_PerDaySession.Caption);
                if (!Empty(int_PerDaySession.EditValue) && IsNumeric(int_PerDaySession.EditValue))
                    int_PerDaySession.EditValue = FormatNumber(int_PerDaySession.EditValue, null);

                // int_Location_ID
                int_Location_ID.SetupEditAttributes();
                curVal = ConvertToString(int_Location_ID.CurrentValue)?.Trim() ?? "";
                if (int_Location_ID.Lookup != null && IsDictionary(int_Location_ID.Lookup?.Options) && int_Location_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Location_ID.EditValue = int_Location_ID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_ID.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_Location_ID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Location_ID.EditValue = rswrk;
                }
                int_Location_ID.PlaceHolder = RemoveHtml(int_Location_ID.Caption);
                if (!Empty(int_Location_ID.EditValue) && IsNumeric(int_Location_ID.EditValue))
                    int_Location_ID.EditValue = FormatNumber(int_Location_ID.EditValue, null);

                // int_Teacher_ID
                int_Teacher_ID.SetupEditAttributes();
                curVal = ConvertToString(int_Teacher_ID.CurrentValue)?.Trim() ?? "";
                if (int_Teacher_ID.Lookup != null && IsDictionary(int_Teacher_ID.Lookup?.Options) && int_Teacher_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Teacher_ID.EditValue = int_Teacher_ID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Staff_Id]", "=", int_Teacher_ID.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_Teacher_ID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Teacher_ID.EditValue = rswrk;
                }
                int_Teacher_ID.PlaceHolder = RemoveHtml(int_Teacher_ID.Caption);
                if (!Empty(int_Teacher_ID.EditValue) && IsNumeric(int_Teacher_ID.EditValue))
                    int_Teacher_ID.EditValue = FormatNumber(int_Teacher_ID.EditValue, null);

                // str_CR_Notes
                str_CR_Notes.SetupEditAttributes();
                str_CR_Notes.EditValue = str_CR_Notes.CurrentValue; // DN
                str_CR_Notes.PlaceHolder = RemoveHtml(str_CR_Notes.Caption);

                // is_ZoomMeet
                is_ZoomMeet.EditValue = is_ZoomMeet.Options(false);
                is_ZoomMeet.PlaceHolder = RemoveHtml(is_ZoomMeet.Caption);

                // BulkCR_Set
                BulkCR_Set.EditValue = BulkCR_Set.Options(false);
                BulkCR_Set.PlaceHolder = RemoveHtml(BulkCR_Set.Caption);

                // str_Username

                // int_Day_Incremental
                int_Day_Incremental.SetupEditAttributes();
                int_Day_Incremental.EditValue = int_Day_Incremental.CurrentValue; // DN
                int_Day_Incremental.PlaceHolder = RemoveHtml(int_Day_Incremental.Caption);
                if (!Empty(int_Day_Incremental.EditValue) && IsNumeric(int_Day_Incremental.EditValue))
                    int_Day_Incremental.EditValue = FormatNumber(int_Day_Incremental.EditValue, null);

                // int_Reoccurrence
                int_Reoccurrence.SetupEditAttributes();
                int_Reoccurrence.EditValue = int_Reoccurrence.CurrentValue; // DN
                int_Reoccurrence.PlaceHolder = RemoveHtml(int_Reoccurrence.Caption);
                if (!Empty(int_Reoccurrence.EditValue) && IsNumeric(int_Reoccurrence.EditValue))
                    int_Reoccurrence.EditValue = FormatNumber(int_Reoccurrence.EditValue, null);

                // date_Start2
                date_Start2.SetupEditAttributes();
                date_Start2.EditValue = FormatDateTime(date_Start2.CurrentValue, date_Start2.FormatPattern); // DN
                date_Start2.PlaceHolder = RemoveHtml(date_Start2.Caption);

                // date_Start3
                date_Start3.SetupEditAttributes();
                date_Start3.EditValue = FormatDateTime(date_Start3.CurrentValue, date_Start3.FormatPattern); // DN
                date_Start3.PlaceHolder = RemoveHtml(date_Start3.Caption);

                // date_Start4
                date_Start4.SetupEditAttributes();
                date_Start4.EditValue = FormatDateTime(date_Start4.CurrentValue, date_Start4.FormatPattern); // DN
                date_Start4.PlaceHolder = RemoveHtml(date_Start4.Caption);

                // Add refer script

                // int_CR_Product_ID
                int_CR_Product_ID.HrefValue = "";

                // date_Start
                date_Start.HrefValue = "";

                // mon_CR_Price
                mon_CR_Price.HrefValue = "";

                // int_CR_Size
                int_CR_Size.HrefValue = "";

                // int_MU_Size
                int_MU_Size.HrefValue = "";

                // int_CR_Status
                int_CR_Status.HrefValue = "";

                // Is_Web_SignUp
                Is_Web_SignUp.HrefValue = "";

                // int_TotSession
                int_TotSession.HrefValue = "";

                // int_PerDaySession
                int_PerDaySession.HrefValue = "";

                // int_Location_ID
                int_Location_ID.HrefValue = "";

                // int_Teacher_ID
                int_Teacher_ID.HrefValue = "";

                // str_CR_Notes
                str_CR_Notes.HrefValue = "";

                // is_ZoomMeet
                is_ZoomMeet.HrefValue = "";

                // BulkCR_Set
                BulkCR_Set.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // int_Day_Incremental
                int_Day_Incremental.HrefValue = "";

                // int_Reoccurrence
                int_Reoccurrence.HrefValue = "";

                // date_Start2
                date_Start2.HrefValue = "";

                // date_Start3
                date_Start3.HrefValue = "";

                // date_Start4
                date_Start4.HrefValue = "";
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
            if (int_CR_Product_ID.Required) {
                if (!int_CR_Product_ID.IsDetailKey && Empty(int_CR_Product_ID.FormValue)) {
                    int_CR_Product_ID.AddErrorMessage(ConvertToString(int_CR_Product_ID.RequiredErrorMessage).Replace("%s", int_CR_Product_ID.Caption));
                }
            }
            if (date_Start.Required) {
                if (!date_Start.IsDetailKey && Empty(date_Start.FormValue)) {
                    date_Start.AddErrorMessage(ConvertToString(date_Start.RequiredErrorMessage).Replace("%s", date_Start.Caption));
                }
            }
            if (!CheckDate(date_Start.FormValue, date_Start.FormatPattern)) {
                date_Start.AddErrorMessage(date_Start.GetErrorMessage(false));
            }
            if (mon_CR_Price.Required) {
                if (!mon_CR_Price.IsDetailKey && Empty(mon_CR_Price.FormValue)) {
                    mon_CR_Price.AddErrorMessage(ConvertToString(mon_CR_Price.RequiredErrorMessage).Replace("%s", mon_CR_Price.Caption));
                }
            }
            if (int_CR_Size.Required) {
                if (!int_CR_Size.IsDetailKey && Empty(int_CR_Size.FormValue)) {
                    int_CR_Size.AddErrorMessage(ConvertToString(int_CR_Size.RequiredErrorMessage).Replace("%s", int_CR_Size.Caption));
                }
            }
            if (int_MU_Size.Required) {
                if (!int_MU_Size.IsDetailKey && Empty(int_MU_Size.FormValue)) {
                    int_MU_Size.AddErrorMessage(ConvertToString(int_MU_Size.RequiredErrorMessage).Replace("%s", int_MU_Size.Caption));
                }
            }
            if (int_CR_Status.Required) {
                if (!int_CR_Status.IsDetailKey && Empty(int_CR_Status.FormValue)) {
                    int_CR_Status.AddErrorMessage(ConvertToString(int_CR_Status.RequiredErrorMessage).Replace("%s", int_CR_Status.Caption));
                }
            }
            if (Is_Web_SignUp.Required) {
                if (Empty(Is_Web_SignUp.FormValue)) {
                    Is_Web_SignUp.AddErrorMessage(ConvertToString(Is_Web_SignUp.RequiredErrorMessage).Replace("%s", Is_Web_SignUp.Caption));
                }
            }
            if (int_TotSession.Required) {
                if (!int_TotSession.IsDetailKey && Empty(int_TotSession.FormValue)) {
                    int_TotSession.AddErrorMessage(ConvertToString(int_TotSession.RequiredErrorMessage).Replace("%s", int_TotSession.Caption));
                }
            }
            if (int_PerDaySession.Required) {
                if (!int_PerDaySession.IsDetailKey && Empty(int_PerDaySession.FormValue)) {
                    int_PerDaySession.AddErrorMessage(ConvertToString(int_PerDaySession.RequiredErrorMessage).Replace("%s", int_PerDaySession.Caption));
                }
            }
            if (int_Location_ID.Required) {
                if (!int_Location_ID.IsDetailKey && Empty(int_Location_ID.FormValue)) {
                    int_Location_ID.AddErrorMessage(ConvertToString(int_Location_ID.RequiredErrorMessage).Replace("%s", int_Location_ID.Caption));
                }
            }
            if (int_Teacher_ID.Required) {
                if (!int_Teacher_ID.IsDetailKey && Empty(int_Teacher_ID.FormValue)) {
                    int_Teacher_ID.AddErrorMessage(ConvertToString(int_Teacher_ID.RequiredErrorMessage).Replace("%s", int_Teacher_ID.Caption));
                }
            }
            if (str_CR_Notes.Required) {
                if (!str_CR_Notes.IsDetailKey && Empty(str_CR_Notes.FormValue)) {
                    str_CR_Notes.AddErrorMessage(ConvertToString(str_CR_Notes.RequiredErrorMessage).Replace("%s", str_CR_Notes.Caption));
                }
            }
            if (is_ZoomMeet.Required) {
                if (Empty(is_ZoomMeet.FormValue)) {
                    is_ZoomMeet.AddErrorMessage(ConvertToString(is_ZoomMeet.RequiredErrorMessage).Replace("%s", is_ZoomMeet.Caption));
                }
            }
            if (BulkCR_Set.Required) {
                if (Empty(BulkCR_Set.FormValue)) {
                    BulkCR_Set.AddErrorMessage(ConvertToString(BulkCR_Set.RequiredErrorMessage).Replace("%s", BulkCR_Set.Caption));
                }
            }
            if (str_Username.Required) {
                if (!str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (int_Day_Incremental.Required) {
                if (!int_Day_Incremental.IsDetailKey && Empty(int_Day_Incremental.FormValue)) {
                    int_Day_Incremental.AddErrorMessage(ConvertToString(int_Day_Incremental.RequiredErrorMessage).Replace("%s", int_Day_Incremental.Caption));
                }
            }
            if (!CheckInteger(int_Day_Incremental.FormValue)) {
                int_Day_Incremental.AddErrorMessage(int_Day_Incremental.GetErrorMessage(false));
            }
            if (int_Reoccurrence.Required) {
                if (!int_Reoccurrence.IsDetailKey && Empty(int_Reoccurrence.FormValue)) {
                    int_Reoccurrence.AddErrorMessage(ConvertToString(int_Reoccurrence.RequiredErrorMessage).Replace("%s", int_Reoccurrence.Caption));
                }
            }
            if (!CheckInteger(int_Reoccurrence.FormValue)) {
                int_Reoccurrence.AddErrorMessage(int_Reoccurrence.GetErrorMessage(false));
            }
            if (date_Start2.Required) {
                if (!date_Start2.IsDetailKey && Empty(date_Start2.FormValue)) {
                    date_Start2.AddErrorMessage(ConvertToString(date_Start2.RequiredErrorMessage).Replace("%s", date_Start2.Caption));
                }
            }
            if (!CheckDate(date_Start2.FormValue, date_Start2.FormatPattern)) {
                date_Start2.AddErrorMessage(date_Start2.GetErrorMessage(false));
            }
            if (date_Start3.Required) {
                if (!date_Start3.IsDetailKey && Empty(date_Start3.FormValue)) {
                    date_Start3.AddErrorMessage(ConvertToString(date_Start3.RequiredErrorMessage).Replace("%s", date_Start3.Caption));
                }
            }
            if (!CheckDate(date_Start3.FormValue, date_Start3.FormatPattern)) {
                date_Start3.AddErrorMessage(date_Start3.GetErrorMessage(false));
            }
            if (date_Start4.Required) {
                if (!date_Start4.IsDetailKey && Empty(date_Start4.FormValue)) {
                    date_Start4.AddErrorMessage(ConvertToString(date_Start4.RequiredErrorMessage).Replace("%s", date_Start4.Caption));
                }
            }
            if (!CheckDate(date_Start4.FormValue, date_Start4.FormatPattern)) {
                date_Start4.AddErrorMessage(date_Start4.GetErrorMessage(false));
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
                // int_CR_Product_ID
                int_CR_Product_ID.SetDbValue(rsnew, int_CR_Product_ID.CurrentValue);

                // date_Start
                date_Start.SetDbValue(rsnew, ConvertToDateTime(date_Start.CurrentValue, date_Start.FormatPattern));

                // mon_CR_Price
                mon_CR_Price.SetDbValue(rsnew, mon_CR_Price.CurrentValue);

                // int_CR_Size
                int_CR_Size.SetDbValue(rsnew, int_CR_Size.CurrentValue);

                // int_MU_Size
                int_MU_Size.SetDbValue(rsnew, int_MU_Size.CurrentValue);

                // int_CR_Status
                int_CR_Status.SetDbValue(rsnew, int_CR_Status.CurrentValue);

                // Is_Web_SignUp
                Is_Web_SignUp.SetDbValue(rsnew, ConvertToBool(Is_Web_SignUp.CurrentValue));

                // int_TotSession
                int_TotSession.SetDbValue(rsnew, int_TotSession.CurrentValue);

                // int_PerDaySession
                int_PerDaySession.SetDbValue(rsnew, int_PerDaySession.CurrentValue);

                // int_Location_ID
                int_Location_ID.SetDbValue(rsnew, int_Location_ID.CurrentValue);

                // int_Teacher_ID
                int_Teacher_ID.SetDbValue(rsnew, int_Teacher_ID.CurrentValue);

                // str_CR_Notes
                str_CR_Notes.SetDbValue(rsnew, str_CR_Notes.CurrentValue);

                // is_ZoomMeet
                is_ZoomMeet.SetDbValue(rsnew, ConvertToBool(is_ZoomMeet.CurrentValue));

                // BulkCR_Set
                BulkCR_Set.SetDbValue(rsnew, BulkCR_Set.CurrentValue);

                // str_Username
                str_Username.CurrentValue = str_Username.GetAutoUpdateValue();
                str_Username.SetDbValue(rsnew, str_Username.CurrentValue, false);

                // int_Day_Incremental
                int_Day_Incremental.SetDbValue(rsnew, int_Day_Incremental.CurrentValue);

                // int_Reoccurrence
                int_Reoccurrence.SetDbValue(rsnew, int_Reoccurrence.CurrentValue);

                // date_Start2
                date_Start2.SetDbValue(rsnew, ConvertToDateTime(date_Start2.CurrentValue, date_Start2.FormatPattern));

                // date_Start3
                date_Start3.SetDbValue(rsnew, ConvertToDateTime(date_Start3.CurrentValue, date_Start3.FormatPattern));

                // date_Start4
                date_Start4.SetDbValue(rsnew, ConvertToDateTime(date_Start4.CurrentValue, date_Start4.FormatPattern));
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
                    rsnew["int_CR_ID"] = int_CR_ID.CurrentValue!;
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblClassRoomList")), "", TableVar, true);
            string pageId = IsCopy ? "Copy" : "Add";
            breadcrumb.Add("add", pageId, url);
            CurrentBreadcrumb = breadcrumb;
        }

        // Set up multi pages
        protected void SetupMultiPages() {
            var pages = new SubPages();
            pages.Style = "tabs";
            pages.Add(0);
            pages.Add(1);
            pages.Add(2);
            pages.Add(3);
            pages.Add(4);
            pages.Add(5);
            pages.Add(6);
            MultiPages = pages;
        }

        // Setup lookup options
        public async Task SetupLookupOptions(DbField fld)
        {
            if (fld.Lookup == null)
                return;
            Func<string>? lookupFilter = null;
            dynamic conn = Connection;
            if (fld.Lookup.Options.Count is int c && c == 0) {
                // Set up lookup SQL
                switch (fld.FieldVar) {
                    case "x_int_CR_Product_ID":
                        lookupFilter = () => fld.GetSelectFilter();
                        break;
                }

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
