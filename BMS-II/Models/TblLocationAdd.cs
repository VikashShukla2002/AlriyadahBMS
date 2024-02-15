namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblLocationAdd
    /// </summary>
    public static TblLocationAdd tblLocationAdd
    {
        get => HttpData.Get<TblLocationAdd>("tblLocationAdd")!;
        set => HttpData["tblLocationAdd"] = value;
    }

    /// <summary>
    /// Page class for tblLocation
    /// </summary>
    public class TblLocationAdd : TblLocationAddBase
    {
        // Constructor
        public TblLocationAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblLocationAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblLocationAddBase : TblLocation
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblLocation";

        // Page object name
        public string PageObjName = "tblLocationAdd";

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
        public TblLocationAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblLocation)
            if (tblLocation == null || tblLocation is TblLocation)
                tblLocation = this;

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
        public string PageName => "TblLocationAdd";

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
            int_Location_Id.SetVisibility();
            str_Name.SetVisibility();
            str_Code.SetVisibility();
            str_Location_Type.SetVisibility();
            str_Address1.SetVisibility();
            str_Address2.SetVisibility();
            str_City.SetVisibility();
            int_State.SetVisibility();
            str_Zip.SetVisibility();
            str_County.SetVisibility();
            str_Manager.SetVisibility();
            str_Phone_Main.SetVisibility();
            str_Phone_Fax.SetVisibility();
            str_Phone_Other.SetVisibility();
            str_Notes.SetVisibility();
            str_Coverage_Code.SetVisibility();
            int_Status.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_LocCapacity.SetVisibility();
            str_ContactEmail.SetVisibility();
            str_SchoolHours.SetVisibility();
            str_EmerName.SetVisibility();
            str_EmerPhone.SetVisibility();
            str_Room.SetVisibility();
            str_Email_Content.SetVisibility();
            bit_appointmentColor.SetVisibility();
            str_appointmentColorCode.SetVisibility();
            isKnowledgeTest.SetVisibility();
            isRoadTest.SetVisibility();
            dec_Latitude.SetVisibility();
            dec_Longitude.SetVisibility();
            str_nameAr.SetVisibility();
            IsDistanceBasedScheduling.SetVisibility();
            str_ZoomEmail.SetVisibility();
            str_ProviderLocationId.SetVisibility();
            int_RoadDistanceCoverage.SetVisibility();
            IsCashDrawer.SetVisibility();
        }

        // Constructor
        public TblLocationAddBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblLocationView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Location_Id") ? dict["int_Location_Id"] : int_Location_Id.CurrentValue));
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
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_appointmentColor);
            await SetupLookupOptions(isKnowledgeTest);
            await SetupLookupOptions(isRoadTest);

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
                if (RouteValues.TryGetValue("int_Location_Id", out rv)) { // DN
                    int_Location_Id.QueryValue = UrlDecode(rv); // DN
                } else if (Get("int_Location_Id", out sv)) {
                    int_Location_Id.QueryValue = sv.ToString();
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
                        return Terminate("TblLocationList"); // No matching record, return to List page // DN
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
                        if (GetPageName(returnUrl) == "TblLocationList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "TblLocationView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblLocationList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblLocationList"; // Return list page content
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
                tblLocationAdd?.PageRender();
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

            // Check field name 'int_Location_Id' before field var 'x_int_Location_Id'
            val = CurrentForm.HasValue("int_Location_Id") ? CurrentForm.GetValue("int_Location_Id") : CurrentForm.GetValue("x_int_Location_Id");
            if (!int_Location_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Location_Id") && !CurrentForm.HasValue("x_int_Location_Id")) // DN
                    int_Location_Id.Visible = false; // Disable update for API request
                else
                    int_Location_Id.SetFormValue(val);
            }

            // Check field name 'str_Name' before field var 'x_str_Name'
            val = CurrentForm.HasValue("str_Name") ? CurrentForm.GetValue("str_Name") : CurrentForm.GetValue("x_str_Name");
            if (!str_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Name") && !CurrentForm.HasValue("x_str_Name")) // DN
                    str_Name.Visible = false; // Disable update for API request
                else
                    str_Name.SetFormValue(val);
            }

            // Check field name 'str_Code' before field var 'x_str_Code'
            val = CurrentForm.HasValue("str_Code") ? CurrentForm.GetValue("str_Code") : CurrentForm.GetValue("x_str_Code");
            if (!str_Code.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Code") && !CurrentForm.HasValue("x_str_Code")) // DN
                    str_Code.Visible = false; // Disable update for API request
                else
                    str_Code.SetFormValue(val);
            }

            // Check field name 'str_Location_Type' before field var 'x_str_Location_Type'
            val = CurrentForm.HasValue("str_Location_Type") ? CurrentForm.GetValue("str_Location_Type") : CurrentForm.GetValue("x_str_Location_Type");
            if (!str_Location_Type.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Location_Type") && !CurrentForm.HasValue("x_str_Location_Type")) // DN
                    str_Location_Type.Visible = false; // Disable update for API request
                else
                    str_Location_Type.SetFormValue(val);
            }

            // Check field name 'str_Address1' before field var 'x_str_Address1'
            val = CurrentForm.HasValue("str_Address1") ? CurrentForm.GetValue("str_Address1") : CurrentForm.GetValue("x_str_Address1");
            if (!str_Address1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Address1") && !CurrentForm.HasValue("x_str_Address1")) // DN
                    str_Address1.Visible = false; // Disable update for API request
                else
                    str_Address1.SetFormValue(val);
            }

            // Check field name 'str_Address2' before field var 'x_str_Address2'
            val = CurrentForm.HasValue("str_Address2") ? CurrentForm.GetValue("str_Address2") : CurrentForm.GetValue("x_str_Address2");
            if (!str_Address2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Address2") && !CurrentForm.HasValue("x_str_Address2")) // DN
                    str_Address2.Visible = false; // Disable update for API request
                else
                    str_Address2.SetFormValue(val);
            }

            // Check field name 'str_City' before field var 'x_str_City'
            val = CurrentForm.HasValue("str_City") ? CurrentForm.GetValue("str_City") : CurrentForm.GetValue("x_str_City");
            if (!str_City.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_City") && !CurrentForm.HasValue("x_str_City")) // DN
                    str_City.Visible = false; // Disable update for API request
                else
                    str_City.SetFormValue(val);
            }

            // Check field name 'int_State' before field var 'x_int_State'
            val = CurrentForm.HasValue("int_State") ? CurrentForm.GetValue("int_State") : CurrentForm.GetValue("x_int_State");
            if (!int_State.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_State") && !CurrentForm.HasValue("x_int_State")) // DN
                    int_State.Visible = false; // Disable update for API request
                else
                    int_State.SetFormValue(val, true, validate);
            }

            // Check field name 'str_Zip' before field var 'x_str_Zip'
            val = CurrentForm.HasValue("str_Zip") ? CurrentForm.GetValue("str_Zip") : CurrentForm.GetValue("x_str_Zip");
            if (!str_Zip.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Zip") && !CurrentForm.HasValue("x_str_Zip")) // DN
                    str_Zip.Visible = false; // Disable update for API request
                else
                    str_Zip.SetFormValue(val);
            }

            // Check field name 'str_County' before field var 'x_str_County'
            val = CurrentForm.HasValue("str_County") ? CurrentForm.GetValue("str_County") : CurrentForm.GetValue("x_str_County");
            if (!str_County.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_County") && !CurrentForm.HasValue("x_str_County")) // DN
                    str_County.Visible = false; // Disable update for API request
                else
                    str_County.SetFormValue(val);
            }

            // Check field name 'str_Manager' before field var 'x_str_Manager'
            val = CurrentForm.HasValue("str_Manager") ? CurrentForm.GetValue("str_Manager") : CurrentForm.GetValue("x_str_Manager");
            if (!str_Manager.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Manager") && !CurrentForm.HasValue("x_str_Manager")) // DN
                    str_Manager.Visible = false; // Disable update for API request
                else
                    str_Manager.SetFormValue(val);
            }

            // Check field name 'str_Phone_Main' before field var 'x_str_Phone_Main'
            val = CurrentForm.HasValue("str_Phone_Main") ? CurrentForm.GetValue("str_Phone_Main") : CurrentForm.GetValue("x_str_Phone_Main");
            if (!str_Phone_Main.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Phone_Main") && !CurrentForm.HasValue("x_str_Phone_Main")) // DN
                    str_Phone_Main.Visible = false; // Disable update for API request
                else
                    str_Phone_Main.SetFormValue(val);
            }

            // Check field name 'str_Phone_Fax' before field var 'x_str_Phone_Fax'
            val = CurrentForm.HasValue("str_Phone_Fax") ? CurrentForm.GetValue("str_Phone_Fax") : CurrentForm.GetValue("x_str_Phone_Fax");
            if (!str_Phone_Fax.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Phone_Fax") && !CurrentForm.HasValue("x_str_Phone_Fax")) // DN
                    str_Phone_Fax.Visible = false; // Disable update for API request
                else
                    str_Phone_Fax.SetFormValue(val);
            }

            // Check field name 'str_Phone_Other' before field var 'x_str_Phone_Other'
            val = CurrentForm.HasValue("str_Phone_Other") ? CurrentForm.GetValue("str_Phone_Other") : CurrentForm.GetValue("x_str_Phone_Other");
            if (!str_Phone_Other.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Phone_Other") && !CurrentForm.HasValue("x_str_Phone_Other")) // DN
                    str_Phone_Other.Visible = false; // Disable update for API request
                else
                    str_Phone_Other.SetFormValue(val);
            }

            // Check field name 'str_Notes' before field var 'x_str_Notes'
            val = CurrentForm.HasValue("str_Notes") ? CurrentForm.GetValue("str_Notes") : CurrentForm.GetValue("x_str_Notes");
            if (!str_Notes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Notes") && !CurrentForm.HasValue("x_str_Notes")) // DN
                    str_Notes.Visible = false; // Disable update for API request
                else
                    str_Notes.SetFormValue(val);
            }

            // Check field name 'str_Coverage_Code' before field var 'x_str_Coverage_Code'
            val = CurrentForm.HasValue("str_Coverage_Code") ? CurrentForm.GetValue("str_Coverage_Code") : CurrentForm.GetValue("x_str_Coverage_Code");
            if (!str_Coverage_Code.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Coverage_Code") && !CurrentForm.HasValue("x_str_Coverage_Code")) // DN
                    str_Coverage_Code.Visible = false; // Disable update for API request
                else
                    str_Coverage_Code.SetFormValue(val);
            }

            // Check field name 'int_Status' before field var 'x_int_Status'
            val = CurrentForm.HasValue("int_Status") ? CurrentForm.GetValue("int_Status") : CurrentForm.GetValue("x_int_Status");
            if (!int_Status.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Status") && !CurrentForm.HasValue("x_int_Status")) // DN
                    int_Status.Visible = false; // Disable update for API request
                else
                    int_Status.SetFormValue(val, true, validate);
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

            // Check field name 'bit_IsDeleted' before field var 'x_bit_IsDeleted'
            val = CurrentForm.HasValue("bit_IsDeleted") ? CurrentForm.GetValue("bit_IsDeleted") : CurrentForm.GetValue("x_bit_IsDeleted");
            if (!bit_IsDeleted.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsDeleted") && !CurrentForm.HasValue("x_bit_IsDeleted")) // DN
                    bit_IsDeleted.Visible = false; // Disable update for API request
                else
                    bit_IsDeleted.SetFormValue(val);
            }

            // Check field name 'str_LocCapacity' before field var 'x_str_LocCapacity'
            val = CurrentForm.HasValue("str_LocCapacity") ? CurrentForm.GetValue("str_LocCapacity") : CurrentForm.GetValue("x_str_LocCapacity");
            if (!str_LocCapacity.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_LocCapacity") && !CurrentForm.HasValue("x_str_LocCapacity")) // DN
                    str_LocCapacity.Visible = false; // Disable update for API request
                else
                    str_LocCapacity.SetFormValue(val);
            }

            // Check field name 'str_ContactEmail' before field var 'x_str_ContactEmail'
            val = CurrentForm.HasValue("str_ContactEmail") ? CurrentForm.GetValue("str_ContactEmail") : CurrentForm.GetValue("x_str_ContactEmail");
            if (!str_ContactEmail.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ContactEmail") && !CurrentForm.HasValue("x_str_ContactEmail")) // DN
                    str_ContactEmail.Visible = false; // Disable update for API request
                else
                    str_ContactEmail.SetFormValue(val);
            }

            // Check field name 'str_SchoolHours' before field var 'x_str_SchoolHours'
            val = CurrentForm.HasValue("str_SchoolHours") ? CurrentForm.GetValue("str_SchoolHours") : CurrentForm.GetValue("x_str_SchoolHours");
            if (!str_SchoolHours.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_SchoolHours") && !CurrentForm.HasValue("x_str_SchoolHours")) // DN
                    str_SchoolHours.Visible = false; // Disable update for API request
                else
                    str_SchoolHours.SetFormValue(val);
            }

            // Check field name 'str_EmerName' before field var 'x_str_EmerName'
            val = CurrentForm.HasValue("str_EmerName") ? CurrentForm.GetValue("str_EmerName") : CurrentForm.GetValue("x_str_EmerName");
            if (!str_EmerName.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_EmerName") && !CurrentForm.HasValue("x_str_EmerName")) // DN
                    str_EmerName.Visible = false; // Disable update for API request
                else
                    str_EmerName.SetFormValue(val);
            }

            // Check field name 'str_EmerPhone' before field var 'x_str_EmerPhone'
            val = CurrentForm.HasValue("str_EmerPhone") ? CurrentForm.GetValue("str_EmerPhone") : CurrentForm.GetValue("x_str_EmerPhone");
            if (!str_EmerPhone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_EmerPhone") && !CurrentForm.HasValue("x_str_EmerPhone")) // DN
                    str_EmerPhone.Visible = false; // Disable update for API request
                else
                    str_EmerPhone.SetFormValue(val);
            }

            // Check field name 'str_Room' before field var 'x_str_Room'
            val = CurrentForm.HasValue("str_Room") ? CurrentForm.GetValue("str_Room") : CurrentForm.GetValue("x_str_Room");
            if (!str_Room.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Room") && !CurrentForm.HasValue("x_str_Room")) // DN
                    str_Room.Visible = false; // Disable update for API request
                else
                    str_Room.SetFormValue(val);
            }

            // Check field name 'str_Email_Content' before field var 'x_str_Email_Content'
            val = CurrentForm.HasValue("str_Email_Content") ? CurrentForm.GetValue("str_Email_Content") : CurrentForm.GetValue("x_str_Email_Content");
            if (!str_Email_Content.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Email_Content") && !CurrentForm.HasValue("x_str_Email_Content")) // DN
                    str_Email_Content.Visible = false; // Disable update for API request
                else
                    str_Email_Content.SetFormValue(val);
            }

            // Check field name 'bit_appointmentColor' before field var 'x_bit_appointmentColor'
            val = CurrentForm.HasValue("bit_appointmentColor") ? CurrentForm.GetValue("bit_appointmentColor") : CurrentForm.GetValue("x_bit_appointmentColor");
            if (!bit_appointmentColor.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_appointmentColor") && !CurrentForm.HasValue("x_bit_appointmentColor")) // DN
                    bit_appointmentColor.Visible = false; // Disable update for API request
                else
                    bit_appointmentColor.SetFormValue(val);
            }

            // Check field name 'str_appointmentColorCode' before field var 'x_str_appointmentColorCode'
            val = CurrentForm.HasValue("str_appointmentColorCode") ? CurrentForm.GetValue("str_appointmentColorCode") : CurrentForm.GetValue("x_str_appointmentColorCode");
            if (!str_appointmentColorCode.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_appointmentColorCode") && !CurrentForm.HasValue("x_str_appointmentColorCode")) // DN
                    str_appointmentColorCode.Visible = false; // Disable update for API request
                else
                    str_appointmentColorCode.SetFormValue(val);
            }

            // Check field name 'isKnowledgeTest' before field var 'x_isKnowledgeTest'
            val = CurrentForm.HasValue("isKnowledgeTest") ? CurrentForm.GetValue("isKnowledgeTest") : CurrentForm.GetValue("x_isKnowledgeTest");
            if (!isKnowledgeTest.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("isKnowledgeTest") && !CurrentForm.HasValue("x_isKnowledgeTest")) // DN
                    isKnowledgeTest.Visible = false; // Disable update for API request
                else
                    isKnowledgeTest.SetFormValue(val);
            }

            // Check field name 'isRoadTest' before field var 'x_isRoadTest'
            val = CurrentForm.HasValue("isRoadTest") ? CurrentForm.GetValue("isRoadTest") : CurrentForm.GetValue("x_isRoadTest");
            if (!isRoadTest.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("isRoadTest") && !CurrentForm.HasValue("x_isRoadTest")) // DN
                    isRoadTest.Visible = false; // Disable update for API request
                else
                    isRoadTest.SetFormValue(val);
            }

            // Check field name 'dec_Latitude' before field var 'x_dec_Latitude'
            val = CurrentForm.HasValue("dec_Latitude") ? CurrentForm.GetValue("dec_Latitude") : CurrentForm.GetValue("x_dec_Latitude");
            if (!dec_Latitude.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_Latitude") && !CurrentForm.HasValue("x_dec_Latitude")) // DN
                    dec_Latitude.Visible = false; // Disable update for API request
                else
                    dec_Latitude.SetFormValue(val, true, validate);
            }

            // Check field name 'dec_Longitude' before field var 'x_dec_Longitude'
            val = CurrentForm.HasValue("dec_Longitude") ? CurrentForm.GetValue("dec_Longitude") : CurrentForm.GetValue("x_dec_Longitude");
            if (!dec_Longitude.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_Longitude") && !CurrentForm.HasValue("x_dec_Longitude")) // DN
                    dec_Longitude.Visible = false; // Disable update for API request
                else
                    dec_Longitude.SetFormValue(val, true, validate);
            }

            // Check field name 'str_nameAr' before field var 'x_str_nameAr'
            val = CurrentForm.HasValue("str_nameAr") ? CurrentForm.GetValue("str_nameAr") : CurrentForm.GetValue("x_str_nameAr");
            if (!str_nameAr.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_nameAr") && !CurrentForm.HasValue("x_str_nameAr")) // DN
                    str_nameAr.Visible = false; // Disable update for API request
                else
                    str_nameAr.SetFormValue(val);
            }

            // Check field name 'IsDistanceBasedScheduling' before field var 'x_IsDistanceBasedScheduling'
            val = CurrentForm.HasValue("IsDistanceBasedScheduling") ? CurrentForm.GetValue("IsDistanceBasedScheduling") : CurrentForm.GetValue("x_IsDistanceBasedScheduling");
            if (!IsDistanceBasedScheduling.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDistanceBasedScheduling") && !CurrentForm.HasValue("x_IsDistanceBasedScheduling")) // DN
                    IsDistanceBasedScheduling.Visible = false; // Disable update for API request
                else
                    IsDistanceBasedScheduling.SetFormValue(val, true, validate);
            }

            // Check field name 'str_ZoomEmail' before field var 'x_str_ZoomEmail'
            val = CurrentForm.HasValue("str_ZoomEmail") ? CurrentForm.GetValue("str_ZoomEmail") : CurrentForm.GetValue("x_str_ZoomEmail");
            if (!str_ZoomEmail.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ZoomEmail") && !CurrentForm.HasValue("x_str_ZoomEmail")) // DN
                    str_ZoomEmail.Visible = false; // Disable update for API request
                else
                    str_ZoomEmail.SetFormValue(val);
            }

            // Check field name 'str_ProviderLocationId' before field var 'x_str_ProviderLocationId'
            val = CurrentForm.HasValue("str_ProviderLocationId") ? CurrentForm.GetValue("str_ProviderLocationId") : CurrentForm.GetValue("x_str_ProviderLocationId");
            if (!str_ProviderLocationId.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ProviderLocationId") && !CurrentForm.HasValue("x_str_ProviderLocationId")) // DN
                    str_ProviderLocationId.Visible = false; // Disable update for API request
                else
                    str_ProviderLocationId.SetFormValue(val);
            }

            // Check field name 'int_RoadDistanceCoverage' before field var 'x_int_RoadDistanceCoverage'
            val = CurrentForm.HasValue("int_RoadDistanceCoverage") ? CurrentForm.GetValue("int_RoadDistanceCoverage") : CurrentForm.GetValue("x_int_RoadDistanceCoverage");
            if (!int_RoadDistanceCoverage.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_RoadDistanceCoverage") && !CurrentForm.HasValue("x_int_RoadDistanceCoverage")) // DN
                    int_RoadDistanceCoverage.Visible = false; // Disable update for API request
                else
                    int_RoadDistanceCoverage.SetFormValue(val, true, validate);
            }

            // Check field name 'IsCashDrawer' before field var 'x_IsCashDrawer'
            val = CurrentForm.HasValue("IsCashDrawer") ? CurrentForm.GetValue("IsCashDrawer") : CurrentForm.GetValue("x_IsCashDrawer");
            if (!IsCashDrawer.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsCashDrawer") && !CurrentForm.HasValue("x_IsCashDrawer")) // DN
                    IsCashDrawer.Visible = false; // Disable update for API request
                else
                    IsCashDrawer.SetFormValue(val, true, validate);
            }
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Location_Id.CurrentValue = int_Location_Id.FormValue;
            str_Name.CurrentValue = str_Name.FormValue;
            str_Code.CurrentValue = str_Code.FormValue;
            str_Location_Type.CurrentValue = str_Location_Type.FormValue;
            str_Address1.CurrentValue = str_Address1.FormValue;
            str_Address2.CurrentValue = str_Address2.FormValue;
            str_City.CurrentValue = str_City.FormValue;
            int_State.CurrentValue = int_State.FormValue;
            str_Zip.CurrentValue = str_Zip.FormValue;
            str_County.CurrentValue = str_County.FormValue;
            str_Manager.CurrentValue = str_Manager.FormValue;
            str_Phone_Main.CurrentValue = str_Phone_Main.FormValue;
            str_Phone_Fax.CurrentValue = str_Phone_Fax.FormValue;
            str_Phone_Other.CurrentValue = str_Phone_Other.FormValue;
            str_Notes.CurrentValue = str_Notes.FormValue;
            str_Coverage_Code.CurrentValue = str_Coverage_Code.FormValue;
            int_Status.CurrentValue = int_Status.FormValue;
            date_Created.CurrentValue = date_Created.FormValue;
            date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            date_Modified.CurrentValue = date_Modified.FormValue;
            date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            int_Created_By.CurrentValue = int_Created_By.FormValue;
            int_Modified_By.CurrentValue = int_Modified_By.FormValue;
            bit_IsDeleted.CurrentValue = bit_IsDeleted.FormValue;
            str_LocCapacity.CurrentValue = str_LocCapacity.FormValue;
            str_ContactEmail.CurrentValue = str_ContactEmail.FormValue;
            str_SchoolHours.CurrentValue = str_SchoolHours.FormValue;
            str_EmerName.CurrentValue = str_EmerName.FormValue;
            str_EmerPhone.CurrentValue = str_EmerPhone.FormValue;
            str_Room.CurrentValue = str_Room.FormValue;
            str_Email_Content.CurrentValue = str_Email_Content.FormValue;
            bit_appointmentColor.CurrentValue = bit_appointmentColor.FormValue;
            str_appointmentColorCode.CurrentValue = str_appointmentColorCode.FormValue;
            isKnowledgeTest.CurrentValue = isKnowledgeTest.FormValue;
            isRoadTest.CurrentValue = isRoadTest.FormValue;
            dec_Latitude.CurrentValue = dec_Latitude.FormValue;
            dec_Longitude.CurrentValue = dec_Longitude.FormValue;
            str_nameAr.CurrentValue = str_nameAr.FormValue;
            IsDistanceBasedScheduling.CurrentValue = IsDistanceBasedScheduling.FormValue;
            str_ZoomEmail.CurrentValue = str_ZoomEmail.FormValue;
            str_ProviderLocationId.CurrentValue = str_ProviderLocationId.FormValue;
            int_RoadDistanceCoverage.CurrentValue = int_RoadDistanceCoverage.FormValue;
            IsCashDrawer.CurrentValue = IsCashDrawer.FormValue;
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
            int_Location_Id.SetDbValue(row["int_Location_Id"]);
            str_Name.SetDbValue(row["str_Name"]);
            str_Code.SetDbValue(row["str_Code"]);
            str_Location_Type.SetDbValue(row["str_Location_Type"]);
            str_Address1.SetDbValue(row["str_Address1"]);
            str_Address2.SetDbValue(row["str_Address2"]);
            str_City.SetDbValue(row["str_City"]);
            int_State.SetDbValue(row["int_State"]);
            str_Zip.SetDbValue(row["str_Zip"]);
            str_County.SetDbValue(row["str_County"]);
            str_Manager.SetDbValue(row["str_Manager"]);
            str_Phone_Main.SetDbValue(row["str_Phone_Main"]);
            str_Phone_Fax.SetDbValue(row["str_Phone_Fax"]);
            str_Phone_Other.SetDbValue(row["str_Phone_Other"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            str_Coverage_Code.SetDbValue(row["str_Coverage_Code"]);
            int_Status.SetDbValue(row["int_Status"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_LocCapacity.SetDbValue(row["str_LocCapacity"]);
            str_ContactEmail.SetDbValue(row["str_ContactEmail"]);
            str_SchoolHours.SetDbValue(row["str_SchoolHours"]);
            str_EmerName.SetDbValue(row["str_EmerName"]);
            str_EmerPhone.SetDbValue(row["str_EmerPhone"]);
            str_Room.SetDbValue(row["str_Room"]);
            str_Email_Content.SetDbValue(row["str_Email_Content"]);
            bit_appointmentColor.SetDbValue((ConvertToBool(row["bit_appointmentColor"]) ? "1" : "0"));
            str_appointmentColorCode.SetDbValue(row["str_appointmentColorCode"]);
            isKnowledgeTest.SetDbValue((ConvertToBool(row["isKnowledgeTest"]) ? "1" : "0"));
            isRoadTest.SetDbValue((ConvertToBool(row["isRoadTest"]) ? "1" : "0"));
            dec_Latitude.SetDbValue(IsNull(row["dec_Latitude"]) ? DbNullValue : ConvertToDouble(row["dec_Latitude"]));
            dec_Longitude.SetDbValue(IsNull(row["dec_Longitude"]) ? DbNullValue : ConvertToDouble(row["dec_Longitude"]));
            str_nameAr.SetDbValue(row["str_nameAr"]);
            IsDistanceBasedScheduling.SetDbValue(row["IsDistanceBasedScheduling"]);
            str_ZoomEmail.SetDbValue(row["str_ZoomEmail"]);
            str_ProviderLocationId.SetDbValue(row["str_ProviderLocationId"]);
            int_RoadDistanceCoverage.SetDbValue(row["int_RoadDistanceCoverage"]);
            IsCashDrawer.SetDbValue(row["IsCashDrawer"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Location_Id", int_Location_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Name", str_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Code", str_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Location_Type", str_Location_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Address1", str_Address1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Address2", str_Address2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_City", str_City.DefaultValue ?? DbNullValue); // DN
            row.Add("int_State", int_State.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Zip", str_Zip.DefaultValue ?? DbNullValue); // DN
            row.Add("str_County", str_County.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Manager", str_Manager.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Phone_Main", str_Phone_Main.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Phone_Fax", str_Phone_Fax.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Phone_Other", str_Phone_Other.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Coverage_Code", str_Coverage_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_LocCapacity", str_LocCapacity.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ContactEmail", str_ContactEmail.DefaultValue ?? DbNullValue); // DN
            row.Add("str_SchoolHours", str_SchoolHours.DefaultValue ?? DbNullValue); // DN
            row.Add("str_EmerName", str_EmerName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_EmerPhone", str_EmerPhone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Room", str_Room.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email_Content", str_Email_Content.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_appointmentColor", bit_appointmentColor.DefaultValue ?? DbNullValue); // DN
            row.Add("str_appointmentColorCode", str_appointmentColorCode.DefaultValue ?? DbNullValue); // DN
            row.Add("isKnowledgeTest", isKnowledgeTest.DefaultValue ?? DbNullValue); // DN
            row.Add("isRoadTest", isRoadTest.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Latitude", dec_Latitude.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Longitude", dec_Longitude.DefaultValue ?? DbNullValue); // DN
            row.Add("str_nameAr", str_nameAr.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDistanceBasedScheduling", IsDistanceBasedScheduling.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ZoomEmail", str_ZoomEmail.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ProviderLocationId", str_ProviderLocationId.DefaultValue ?? DbNullValue); // DN
            row.Add("int_RoadDistanceCoverage", int_RoadDistanceCoverage.DefaultValue ?? DbNullValue); // DN
            row.Add("IsCashDrawer", IsCashDrawer.DefaultValue ?? DbNullValue); // DN
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

            // int_Location_Id
            int_Location_Id.RowCssClass = "row";

            // str_Name
            str_Name.RowCssClass = "row";

            // str_Code
            str_Code.RowCssClass = "row";

            // str_Location_Type
            str_Location_Type.RowCssClass = "row";

            // str_Address1
            str_Address1.RowCssClass = "row";

            // str_Address2
            str_Address2.RowCssClass = "row";

            // str_City
            str_City.RowCssClass = "row";

            // int_State
            int_State.RowCssClass = "row";

            // str_Zip
            str_Zip.RowCssClass = "row";

            // str_County
            str_County.RowCssClass = "row";

            // str_Manager
            str_Manager.RowCssClass = "row";

            // str_Phone_Main
            str_Phone_Main.RowCssClass = "row";

            // str_Phone_Fax
            str_Phone_Fax.RowCssClass = "row";

            // str_Phone_Other
            str_Phone_Other.RowCssClass = "row";

            // str_Notes
            str_Notes.RowCssClass = "row";

            // str_Coverage_Code
            str_Coverage_Code.RowCssClass = "row";

            // int_Status
            int_Status.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // bit_IsDeleted
            bit_IsDeleted.RowCssClass = "row";

            // str_LocCapacity
            str_LocCapacity.RowCssClass = "row";

            // str_ContactEmail
            str_ContactEmail.RowCssClass = "row";

            // str_SchoolHours
            str_SchoolHours.RowCssClass = "row";

            // str_EmerName
            str_EmerName.RowCssClass = "row";

            // str_EmerPhone
            str_EmerPhone.RowCssClass = "row";

            // str_Room
            str_Room.RowCssClass = "row";

            // str_Email_Content
            str_Email_Content.RowCssClass = "row";

            // bit_appointmentColor
            bit_appointmentColor.RowCssClass = "row";

            // str_appointmentColorCode
            str_appointmentColorCode.RowCssClass = "row";

            // isKnowledgeTest
            isKnowledgeTest.RowCssClass = "row";

            // isRoadTest
            isRoadTest.RowCssClass = "row";

            // dec_Latitude
            dec_Latitude.RowCssClass = "row";

            // dec_Longitude
            dec_Longitude.RowCssClass = "row";

            // str_nameAr
            str_nameAr.RowCssClass = "row";

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.RowCssClass = "row";

            // str_ZoomEmail
            str_ZoomEmail.RowCssClass = "row";

            // str_ProviderLocationId
            str_ProviderLocationId.RowCssClass = "row";

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.RowCssClass = "row";

            // IsCashDrawer
            IsCashDrawer.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // int_Location_Id
                listWrk = new List<object?>();
                listWrk.Add(int_Location_Id.CurrentValue); // DN
                listWrk.Add(int_Location_Id.CurrentValue);
                listWrk.Add(str_Name.CurrentValue);
                listWrk = int_Location_Id.Lookup?.RenderViewRow(listWrk, this);
                dispVal = int_Location_Id.DisplayValue(listWrk);
                if (!Empty(dispVal))
                    int_Location_Id.ViewValue = dispVal;
                int_Location_Id.ViewCustomAttributes = "";

                // str_Name
                str_Name.ViewValue = ConvertToString(str_Name.CurrentValue); // DN
                str_Name.ViewCustomAttributes = "";

                // str_Code
                str_Code.ViewValue = ConvertToString(str_Code.CurrentValue); // DN
                str_Code.ViewCustomAttributes = "";

                // str_Location_Type
                str_Location_Type.ViewValue = ConvertToString(str_Location_Type.CurrentValue); // DN
                str_Location_Type.ViewCustomAttributes = "";

                // str_Address1
                str_Address1.ViewValue = ConvertToString(str_Address1.CurrentValue); // DN
                str_Address1.ViewCustomAttributes = "";

                // str_Address2
                str_Address2.ViewValue = ConvertToString(str_Address2.CurrentValue); // DN
                str_Address2.ViewCustomAttributes = "";

                // str_City
                str_City.ViewValue = ConvertToString(str_City.CurrentValue); // DN
                str_City.ViewCustomAttributes = "";

                // int_State
                int_State.ViewValue = int_State.CurrentValue;
                int_State.ViewValue = FormatNumber(int_State.ViewValue, int_State.FormatPattern);
                int_State.ViewCustomAttributes = "";

                // str_Zip
                str_Zip.ViewValue = ConvertToString(str_Zip.CurrentValue); // DN
                str_Zip.ViewCustomAttributes = "";

                // str_County
                str_County.ViewValue = ConvertToString(str_County.CurrentValue); // DN
                str_County.ViewCustomAttributes = "";

                // str_Manager
                str_Manager.ViewValue = ConvertToString(str_Manager.CurrentValue); // DN
                str_Manager.ViewCustomAttributes = "";

                // str_Phone_Main
                str_Phone_Main.ViewValue = ConvertToString(str_Phone_Main.CurrentValue); // DN
                str_Phone_Main.ViewCustomAttributes = "";

                // str_Phone_Fax
                str_Phone_Fax.ViewValue = ConvertToString(str_Phone_Fax.CurrentValue); // DN
                str_Phone_Fax.ViewCustomAttributes = "";

                // str_Phone_Other
                str_Phone_Other.ViewValue = ConvertToString(str_Phone_Other.CurrentValue); // DN
                str_Phone_Other.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // str_Coverage_Code
                str_Coverage_Code.ViewValue = str_Coverage_Code.CurrentValue;
                str_Coverage_Code.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // date_Modified
                date_Modified.ViewValue = date_Modified.CurrentValue;
                date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
                date_Modified.ViewCustomAttributes = "";

                // int_Created_By
                int_Created_By.ViewValue = int_Created_By.CurrentValue;
                int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
                int_Created_By.ViewCustomAttributes = "";

                // int_Modified_By
                int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
                int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
                int_Modified_By.ViewCustomAttributes = "";

                // bit_IsDeleted
                if (ConvertToBool(bit_IsDeleted.CurrentValue)) {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(1) != "" ? bit_IsDeleted.TagCaption(1) : "Yes";
                } else {
                    bit_IsDeleted.ViewValue = bit_IsDeleted.TagCaption(2) != "" ? bit_IsDeleted.TagCaption(2) : "No";
                }
                bit_IsDeleted.ViewCustomAttributes = "";

                // str_LocCapacity
                str_LocCapacity.ViewValue = ConvertToString(str_LocCapacity.CurrentValue); // DN
                str_LocCapacity.ViewCustomAttributes = "";

                // str_ContactEmail
                str_ContactEmail.ViewValue = ConvertToString(str_ContactEmail.CurrentValue); // DN
                str_ContactEmail.ViewCustomAttributes = "";

                // str_SchoolHours
                str_SchoolHours.ViewValue = ConvertToString(str_SchoolHours.CurrentValue); // DN
                str_SchoolHours.ViewCustomAttributes = "";

                // str_EmerName
                str_EmerName.ViewValue = ConvertToString(str_EmerName.CurrentValue); // DN
                str_EmerName.ViewCustomAttributes = "";

                // str_EmerPhone
                str_EmerPhone.ViewValue = ConvertToString(str_EmerPhone.CurrentValue); // DN
                str_EmerPhone.ViewCustomAttributes = "";

                // str_Room
                str_Room.ViewValue = ConvertToString(str_Room.CurrentValue); // DN
                str_Room.ViewCustomAttributes = "";

                // str_Email_Content
                str_Email_Content.ViewValue = ConvertToString(str_Email_Content.CurrentValue); // DN
                str_Email_Content.ViewCustomAttributes = "";

                // bit_appointmentColor
                if (ConvertToBool(bit_appointmentColor.CurrentValue)) {
                    bit_appointmentColor.ViewValue = bit_appointmentColor.TagCaption(1) != "" ? bit_appointmentColor.TagCaption(1) : "Yes";
                } else {
                    bit_appointmentColor.ViewValue = bit_appointmentColor.TagCaption(2) != "" ? bit_appointmentColor.TagCaption(2) : "No";
                }
                bit_appointmentColor.ViewCustomAttributes = "";

                // str_appointmentColorCode
                str_appointmentColorCode.ViewValue = ConvertToString(str_appointmentColorCode.CurrentValue); // DN
                str_appointmentColorCode.ViewCustomAttributes = "";

                // isKnowledgeTest
                if (ConvertToBool(isKnowledgeTest.CurrentValue)) {
                    isKnowledgeTest.ViewValue = isKnowledgeTest.TagCaption(1) != "" ? isKnowledgeTest.TagCaption(1) : "Yes";
                } else {
                    isKnowledgeTest.ViewValue = isKnowledgeTest.TagCaption(2) != "" ? isKnowledgeTest.TagCaption(2) : "No";
                }
                isKnowledgeTest.ViewCustomAttributes = "";

                // isRoadTest
                if (ConvertToBool(isRoadTest.CurrentValue)) {
                    isRoadTest.ViewValue = isRoadTest.TagCaption(1) != "" ? isRoadTest.TagCaption(1) : "Yes";
                } else {
                    isRoadTest.ViewValue = isRoadTest.TagCaption(2) != "" ? isRoadTest.TagCaption(2) : "No";
                }
                isRoadTest.ViewCustomAttributes = "";

                // dec_Latitude
                dec_Latitude.ViewValue = dec_Latitude.CurrentValue;
                dec_Latitude.ViewValue = FormatNumber(dec_Latitude.ViewValue, dec_Latitude.FormatPattern);
                dec_Latitude.ViewCustomAttributes = "";

                // dec_Longitude
                dec_Longitude.ViewValue = dec_Longitude.CurrentValue;
                dec_Longitude.ViewValue = FormatNumber(dec_Longitude.ViewValue, dec_Longitude.FormatPattern);
                dec_Longitude.ViewCustomAttributes = "";

                // str_nameAr
                str_nameAr.ViewValue = ConvertToString(str_nameAr.CurrentValue); // DN
                str_nameAr.ViewCustomAttributes = "";

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.ViewValue = IsDistanceBasedScheduling.CurrentValue;
                IsDistanceBasedScheduling.ViewValue = FormatNumber(IsDistanceBasedScheduling.ViewValue, IsDistanceBasedScheduling.FormatPattern);
                IsDistanceBasedScheduling.ViewCustomAttributes = "";

                // str_ZoomEmail
                str_ZoomEmail.ViewValue = ConvertToString(str_ZoomEmail.CurrentValue); // DN
                str_ZoomEmail.ViewCustomAttributes = "";

                // str_ProviderLocationId
                str_ProviderLocationId.ViewValue = ConvertToString(str_ProviderLocationId.CurrentValue); // DN
                str_ProviderLocationId.ViewCustomAttributes = "";

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.ViewValue = int_RoadDistanceCoverage.CurrentValue;
                int_RoadDistanceCoverage.ViewValue = FormatNumber(int_RoadDistanceCoverage.ViewValue, int_RoadDistanceCoverage.FormatPattern);
                int_RoadDistanceCoverage.ViewCustomAttributes = "";

                // IsCashDrawer
                IsCashDrawer.ViewValue = IsCashDrawer.CurrentValue;
                IsCashDrawer.ViewValue = FormatNumber(IsCashDrawer.ViewValue, IsCashDrawer.FormatPattern);
                IsCashDrawer.ViewCustomAttributes = "";

                // int_Location_Id
                int_Location_Id.HrefValue = "";

                // str_Name
                str_Name.HrefValue = "";

                // str_Code
                str_Code.HrefValue = "";

                // str_Location_Type
                str_Location_Type.HrefValue = "";

                // str_Address1
                str_Address1.HrefValue = "";

                // str_Address2
                str_Address2.HrefValue = "";

                // str_City
                str_City.HrefValue = "";

                // int_State
                int_State.HrefValue = "";

                // str_Zip
                str_Zip.HrefValue = "";

                // str_County
                str_County.HrefValue = "";

                // str_Manager
                str_Manager.HrefValue = "";

                // str_Phone_Main
                str_Phone_Main.HrefValue = "";

                // str_Phone_Fax
                str_Phone_Fax.HrefValue = "";

                // str_Phone_Other
                str_Phone_Other.HrefValue = "";

                // str_Notes
                str_Notes.HrefValue = "";

                // str_Coverage_Code
                str_Coverage_Code.HrefValue = "";

                // int_Status
                int_Status.HrefValue = "";

                // date_Created
                date_Created.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";

                // str_LocCapacity
                str_LocCapacity.HrefValue = "";

                // str_ContactEmail
                str_ContactEmail.HrefValue = "";

                // str_SchoolHours
                str_SchoolHours.HrefValue = "";

                // str_EmerName
                str_EmerName.HrefValue = "";

                // str_EmerPhone
                str_EmerPhone.HrefValue = "";

                // str_Room
                str_Room.HrefValue = "";

                // str_Email_Content
                str_Email_Content.HrefValue = "";

                // bit_appointmentColor
                bit_appointmentColor.HrefValue = "";

                // str_appointmentColorCode
                str_appointmentColorCode.HrefValue = "";

                // isKnowledgeTest
                isKnowledgeTest.HrefValue = "";

                // isRoadTest
                isRoadTest.HrefValue = "";

                // dec_Latitude
                dec_Latitude.HrefValue = "";

                // dec_Longitude
                dec_Longitude.HrefValue = "";

                // str_nameAr
                str_nameAr.HrefValue = "";

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.HrefValue = "";

                // str_ZoomEmail
                str_ZoomEmail.HrefValue = "";

                // str_ProviderLocationId
                str_ProviderLocationId.HrefValue = "";

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.HrefValue = "";

                // IsCashDrawer
                IsCashDrawer.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // int_Location_Id
                int_Location_Id.SetupEditAttributes();
                curVal = ConvertToString(int_Location_Id.CurrentValue)?.Trim() ?? "";
                if (int_Location_Id.Lookup != null && IsDictionary(int_Location_Id.Lookup?.Options) && int_Location_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Location_Id.EditValue = int_Location_Id.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_Id.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_Location_Id.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Location_Id.EditValue = rswrk;
                }
                int_Location_Id.PlaceHolder = RemoveHtml(int_Location_Id.Caption);
                if (!Empty(int_Location_Id.EditValue) && IsNumeric(int_Location_Id.EditValue))
                    int_Location_Id.EditValue = FormatNumber(int_Location_Id.EditValue, null);

                // str_Name
                str_Name.SetupEditAttributes();
                if (!str_Name.Raw)
                    str_Name.CurrentValue = HtmlDecode(str_Name.CurrentValue);
                str_Name.EditValue = HtmlEncode(str_Name.CurrentValue);
                str_Name.PlaceHolder = RemoveHtml(str_Name.Caption);

                // str_Code
                str_Code.SetupEditAttributes();
                if (!str_Code.Raw)
                    str_Code.CurrentValue = HtmlDecode(str_Code.CurrentValue);
                str_Code.EditValue = HtmlEncode(str_Code.CurrentValue);
                str_Code.PlaceHolder = RemoveHtml(str_Code.Caption);

                // str_Location_Type
                str_Location_Type.SetupEditAttributes();
                if (!str_Location_Type.Raw)
                    str_Location_Type.CurrentValue = HtmlDecode(str_Location_Type.CurrentValue);
                str_Location_Type.EditValue = HtmlEncode(str_Location_Type.CurrentValue);
                str_Location_Type.PlaceHolder = RemoveHtml(str_Location_Type.Caption);

                // str_Address1
                str_Address1.SetupEditAttributes();
                if (!str_Address1.Raw)
                    str_Address1.CurrentValue = HtmlDecode(str_Address1.CurrentValue);
                str_Address1.EditValue = HtmlEncode(str_Address1.CurrentValue);
                str_Address1.PlaceHolder = RemoveHtml(str_Address1.Caption);

                // str_Address2
                str_Address2.SetupEditAttributes();
                if (!str_Address2.Raw)
                    str_Address2.CurrentValue = HtmlDecode(str_Address2.CurrentValue);
                str_Address2.EditValue = HtmlEncode(str_Address2.CurrentValue);
                str_Address2.PlaceHolder = RemoveHtml(str_Address2.Caption);

                // str_City
                str_City.SetupEditAttributes();
                if (!str_City.Raw)
                    str_City.CurrentValue = HtmlDecode(str_City.CurrentValue);
                str_City.EditValue = HtmlEncode(str_City.CurrentValue);
                str_City.PlaceHolder = RemoveHtml(str_City.Caption);

                // int_State
                int_State.SetupEditAttributes();
                int_State.EditValue = int_State.CurrentValue; // DN
                int_State.PlaceHolder = RemoveHtml(int_State.Caption);
                if (!Empty(int_State.EditValue) && IsNumeric(int_State.EditValue))
                    int_State.EditValue = FormatNumber(int_State.EditValue, null);

                // str_Zip
                str_Zip.SetupEditAttributes();
                if (!str_Zip.Raw)
                    str_Zip.CurrentValue = HtmlDecode(str_Zip.CurrentValue);
                str_Zip.EditValue = HtmlEncode(str_Zip.CurrentValue);
                str_Zip.PlaceHolder = RemoveHtml(str_Zip.Caption);

                // str_County
                str_County.SetupEditAttributes();
                if (!str_County.Raw)
                    str_County.CurrentValue = HtmlDecode(str_County.CurrentValue);
                str_County.EditValue = HtmlEncode(str_County.CurrentValue);
                str_County.PlaceHolder = RemoveHtml(str_County.Caption);

                // str_Manager
                str_Manager.SetupEditAttributes();
                if (!str_Manager.Raw)
                    str_Manager.CurrentValue = HtmlDecode(str_Manager.CurrentValue);
                str_Manager.EditValue = HtmlEncode(str_Manager.CurrentValue);
                str_Manager.PlaceHolder = RemoveHtml(str_Manager.Caption);

                // str_Phone_Main
                str_Phone_Main.SetupEditAttributes();
                if (!str_Phone_Main.Raw)
                    str_Phone_Main.CurrentValue = HtmlDecode(str_Phone_Main.CurrentValue);
                str_Phone_Main.EditValue = HtmlEncode(str_Phone_Main.CurrentValue);
                str_Phone_Main.PlaceHolder = RemoveHtml(str_Phone_Main.Caption);

                // str_Phone_Fax
                str_Phone_Fax.SetupEditAttributes();
                if (!str_Phone_Fax.Raw)
                    str_Phone_Fax.CurrentValue = HtmlDecode(str_Phone_Fax.CurrentValue);
                str_Phone_Fax.EditValue = HtmlEncode(str_Phone_Fax.CurrentValue);
                str_Phone_Fax.PlaceHolder = RemoveHtml(str_Phone_Fax.Caption);

                // str_Phone_Other
                str_Phone_Other.SetupEditAttributes();
                if (!str_Phone_Other.Raw)
                    str_Phone_Other.CurrentValue = HtmlDecode(str_Phone_Other.CurrentValue);
                str_Phone_Other.EditValue = HtmlEncode(str_Phone_Other.CurrentValue);
                str_Phone_Other.PlaceHolder = RemoveHtml(str_Phone_Other.Caption);

                // str_Notes
                str_Notes.SetupEditAttributes();
                if (!str_Notes.Raw)
                    str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
                str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
                str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

                // str_Coverage_Code
                str_Coverage_Code.SetupEditAttributes();
                str_Coverage_Code.EditValue = str_Coverage_Code.CurrentValue; // DN
                str_Coverage_Code.PlaceHolder = RemoveHtml(str_Coverage_Code.Caption);

                // int_Status
                int_Status.SetupEditAttributes();
                int_Status.EditValue = int_Status.CurrentValue; // DN
                int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
                if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                    int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

                // date_Created
                date_Created.SetupEditAttributes();
                date_Created.EditValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern); // DN
                date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

                // date_Modified
                date_Modified.SetupEditAttributes();
                date_Modified.EditValue = FormatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern); // DN
                date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

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

                // bit_IsDeleted
                bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
                bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

                // str_LocCapacity
                str_LocCapacity.SetupEditAttributes();
                if (!str_LocCapacity.Raw)
                    str_LocCapacity.CurrentValue = HtmlDecode(str_LocCapacity.CurrentValue);
                str_LocCapacity.EditValue = HtmlEncode(str_LocCapacity.CurrentValue);
                str_LocCapacity.PlaceHolder = RemoveHtml(str_LocCapacity.Caption);

                // str_ContactEmail
                str_ContactEmail.SetupEditAttributes();
                if (!str_ContactEmail.Raw)
                    str_ContactEmail.CurrentValue = HtmlDecode(str_ContactEmail.CurrentValue);
                str_ContactEmail.EditValue = HtmlEncode(str_ContactEmail.CurrentValue);
                str_ContactEmail.PlaceHolder = RemoveHtml(str_ContactEmail.Caption);

                // str_SchoolHours
                str_SchoolHours.SetupEditAttributes();
                if (!str_SchoolHours.Raw)
                    str_SchoolHours.CurrentValue = HtmlDecode(str_SchoolHours.CurrentValue);
                str_SchoolHours.EditValue = HtmlEncode(str_SchoolHours.CurrentValue);
                str_SchoolHours.PlaceHolder = RemoveHtml(str_SchoolHours.Caption);

                // str_EmerName
                str_EmerName.SetupEditAttributes();
                if (!str_EmerName.Raw)
                    str_EmerName.CurrentValue = HtmlDecode(str_EmerName.CurrentValue);
                str_EmerName.EditValue = HtmlEncode(str_EmerName.CurrentValue);
                str_EmerName.PlaceHolder = RemoveHtml(str_EmerName.Caption);

                // str_EmerPhone
                str_EmerPhone.SetupEditAttributes();
                if (!str_EmerPhone.Raw)
                    str_EmerPhone.CurrentValue = HtmlDecode(str_EmerPhone.CurrentValue);
                str_EmerPhone.EditValue = HtmlEncode(str_EmerPhone.CurrentValue);
                str_EmerPhone.PlaceHolder = RemoveHtml(str_EmerPhone.Caption);

                // str_Room
                str_Room.SetupEditAttributes();
                if (!str_Room.Raw)
                    str_Room.CurrentValue = HtmlDecode(str_Room.CurrentValue);
                str_Room.EditValue = HtmlEncode(str_Room.CurrentValue);
                str_Room.PlaceHolder = RemoveHtml(str_Room.Caption);

                // str_Email_Content
                str_Email_Content.SetupEditAttributes();
                if (!str_Email_Content.Raw)
                    str_Email_Content.CurrentValue = HtmlDecode(str_Email_Content.CurrentValue);
                str_Email_Content.EditValue = HtmlEncode(str_Email_Content.CurrentValue);
                str_Email_Content.PlaceHolder = RemoveHtml(str_Email_Content.Caption);

                // bit_appointmentColor
                bit_appointmentColor.EditValue = bit_appointmentColor.Options(false);
                bit_appointmentColor.PlaceHolder = RemoveHtml(bit_appointmentColor.Caption);

                // str_appointmentColorCode
                str_appointmentColorCode.SetupEditAttributes();
                if (!str_appointmentColorCode.Raw)
                    str_appointmentColorCode.CurrentValue = HtmlDecode(str_appointmentColorCode.CurrentValue);
                str_appointmentColorCode.EditValue = HtmlEncode(str_appointmentColorCode.CurrentValue);
                str_appointmentColorCode.PlaceHolder = RemoveHtml(str_appointmentColorCode.Caption);

                // isKnowledgeTest
                isKnowledgeTest.EditValue = isKnowledgeTest.Options(false);
                isKnowledgeTest.PlaceHolder = RemoveHtml(isKnowledgeTest.Caption);

                // isRoadTest
                isRoadTest.EditValue = isRoadTest.Options(false);
                isRoadTest.PlaceHolder = RemoveHtml(isRoadTest.Caption);

                // dec_Latitude
                dec_Latitude.SetupEditAttributes();
                dec_Latitude.EditValue = dec_Latitude.CurrentValue; // DN
                dec_Latitude.PlaceHolder = RemoveHtml(dec_Latitude.Caption);
                if (!Empty(dec_Latitude.EditValue) && IsNumeric(dec_Latitude.EditValue))
                    dec_Latitude.EditValue = FormatNumber(dec_Latitude.EditValue, null);

                // dec_Longitude
                dec_Longitude.SetupEditAttributes();
                dec_Longitude.EditValue = dec_Longitude.CurrentValue; // DN
                dec_Longitude.PlaceHolder = RemoveHtml(dec_Longitude.Caption);
                if (!Empty(dec_Longitude.EditValue) && IsNumeric(dec_Longitude.EditValue))
                    dec_Longitude.EditValue = FormatNumber(dec_Longitude.EditValue, null);

                // str_nameAr
                str_nameAr.SetupEditAttributes();
                if (!str_nameAr.Raw)
                    str_nameAr.CurrentValue = HtmlDecode(str_nameAr.CurrentValue);
                str_nameAr.EditValue = HtmlEncode(str_nameAr.CurrentValue);
                str_nameAr.PlaceHolder = RemoveHtml(str_nameAr.Caption);

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.SetupEditAttributes();
                IsDistanceBasedScheduling.EditValue = IsDistanceBasedScheduling.CurrentValue; // DN
                IsDistanceBasedScheduling.PlaceHolder = RemoveHtml(IsDistanceBasedScheduling.Caption);
                if (!Empty(IsDistanceBasedScheduling.EditValue) && IsNumeric(IsDistanceBasedScheduling.EditValue))
                    IsDistanceBasedScheduling.EditValue = FormatNumber(IsDistanceBasedScheduling.EditValue, null);

                // str_ZoomEmail
                str_ZoomEmail.SetupEditAttributes();
                if (!str_ZoomEmail.Raw)
                    str_ZoomEmail.CurrentValue = HtmlDecode(str_ZoomEmail.CurrentValue);
                str_ZoomEmail.EditValue = HtmlEncode(str_ZoomEmail.CurrentValue);
                str_ZoomEmail.PlaceHolder = RemoveHtml(str_ZoomEmail.Caption);

                // str_ProviderLocationId
                str_ProviderLocationId.SetupEditAttributes();
                if (!str_ProviderLocationId.Raw)
                    str_ProviderLocationId.CurrentValue = HtmlDecode(str_ProviderLocationId.CurrentValue);
                str_ProviderLocationId.EditValue = HtmlEncode(str_ProviderLocationId.CurrentValue);
                str_ProviderLocationId.PlaceHolder = RemoveHtml(str_ProviderLocationId.Caption);

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.SetupEditAttributes();
                int_RoadDistanceCoverage.EditValue = int_RoadDistanceCoverage.CurrentValue; // DN
                int_RoadDistanceCoverage.PlaceHolder = RemoveHtml(int_RoadDistanceCoverage.Caption);
                if (!Empty(int_RoadDistanceCoverage.EditValue) && IsNumeric(int_RoadDistanceCoverage.EditValue))
                    int_RoadDistanceCoverage.EditValue = FormatNumber(int_RoadDistanceCoverage.EditValue, null);

                // IsCashDrawer
                IsCashDrawer.SetupEditAttributes();
                IsCashDrawer.EditValue = IsCashDrawer.CurrentValue; // DN
                IsCashDrawer.PlaceHolder = RemoveHtml(IsCashDrawer.Caption);
                if (!Empty(IsCashDrawer.EditValue) && IsNumeric(IsCashDrawer.EditValue))
                    IsCashDrawer.EditValue = FormatNumber(IsCashDrawer.EditValue, null);

                // Add refer script

                // int_Location_Id
                int_Location_Id.HrefValue = "";

                // str_Name
                str_Name.HrefValue = "";

                // str_Code
                str_Code.HrefValue = "";

                // str_Location_Type
                str_Location_Type.HrefValue = "";

                // str_Address1
                str_Address1.HrefValue = "";

                // str_Address2
                str_Address2.HrefValue = "";

                // str_City
                str_City.HrefValue = "";

                // int_State
                int_State.HrefValue = "";

                // str_Zip
                str_Zip.HrefValue = "";

                // str_County
                str_County.HrefValue = "";

                // str_Manager
                str_Manager.HrefValue = "";

                // str_Phone_Main
                str_Phone_Main.HrefValue = "";

                // str_Phone_Fax
                str_Phone_Fax.HrefValue = "";

                // str_Phone_Other
                str_Phone_Other.HrefValue = "";

                // str_Notes
                str_Notes.HrefValue = "";

                // str_Coverage_Code
                str_Coverage_Code.HrefValue = "";

                // int_Status
                int_Status.HrefValue = "";

                // date_Created
                date_Created.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";

                // str_LocCapacity
                str_LocCapacity.HrefValue = "";

                // str_ContactEmail
                str_ContactEmail.HrefValue = "";

                // str_SchoolHours
                str_SchoolHours.HrefValue = "";

                // str_EmerName
                str_EmerName.HrefValue = "";

                // str_EmerPhone
                str_EmerPhone.HrefValue = "";

                // str_Room
                str_Room.HrefValue = "";

                // str_Email_Content
                str_Email_Content.HrefValue = "";

                // bit_appointmentColor
                bit_appointmentColor.HrefValue = "";

                // str_appointmentColorCode
                str_appointmentColorCode.HrefValue = "";

                // isKnowledgeTest
                isKnowledgeTest.HrefValue = "";

                // isRoadTest
                isRoadTest.HrefValue = "";

                // dec_Latitude
                dec_Latitude.HrefValue = "";

                // dec_Longitude
                dec_Longitude.HrefValue = "";

                // str_nameAr
                str_nameAr.HrefValue = "";

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.HrefValue = "";

                // str_ZoomEmail
                str_ZoomEmail.HrefValue = "";

                // str_ProviderLocationId
                str_ProviderLocationId.HrefValue = "";

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.HrefValue = "";

                // IsCashDrawer
                IsCashDrawer.HrefValue = "";
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
            if (int_Location_Id.Required) {
                if (!int_Location_Id.IsDetailKey && Empty(int_Location_Id.FormValue)) {
                    int_Location_Id.AddErrorMessage(ConvertToString(int_Location_Id.RequiredErrorMessage).Replace("%s", int_Location_Id.Caption));
                }
            }
            if (str_Name.Required) {
                if (!str_Name.IsDetailKey && Empty(str_Name.FormValue)) {
                    str_Name.AddErrorMessage(ConvertToString(str_Name.RequiredErrorMessage).Replace("%s", str_Name.Caption));
                }
            }
            if (str_Code.Required) {
                if (!str_Code.IsDetailKey && Empty(str_Code.FormValue)) {
                    str_Code.AddErrorMessage(ConvertToString(str_Code.RequiredErrorMessage).Replace("%s", str_Code.Caption));
                }
            }
            if (str_Location_Type.Required) {
                if (!str_Location_Type.IsDetailKey && Empty(str_Location_Type.FormValue)) {
                    str_Location_Type.AddErrorMessage(ConvertToString(str_Location_Type.RequiredErrorMessage).Replace("%s", str_Location_Type.Caption));
                }
            }
            if (str_Address1.Required) {
                if (!str_Address1.IsDetailKey && Empty(str_Address1.FormValue)) {
                    str_Address1.AddErrorMessage(ConvertToString(str_Address1.RequiredErrorMessage).Replace("%s", str_Address1.Caption));
                }
            }
            if (str_Address2.Required) {
                if (!str_Address2.IsDetailKey && Empty(str_Address2.FormValue)) {
                    str_Address2.AddErrorMessage(ConvertToString(str_Address2.RequiredErrorMessage).Replace("%s", str_Address2.Caption));
                }
            }
            if (str_City.Required) {
                if (!str_City.IsDetailKey && Empty(str_City.FormValue)) {
                    str_City.AddErrorMessage(ConvertToString(str_City.RequiredErrorMessage).Replace("%s", str_City.Caption));
                }
            }
            if (int_State.Required) {
                if (!int_State.IsDetailKey && Empty(int_State.FormValue)) {
                    int_State.AddErrorMessage(ConvertToString(int_State.RequiredErrorMessage).Replace("%s", int_State.Caption));
                }
            }
            if (!CheckInteger(int_State.FormValue)) {
                int_State.AddErrorMessage(int_State.GetErrorMessage(false));
            }
            if (str_Zip.Required) {
                if (!str_Zip.IsDetailKey && Empty(str_Zip.FormValue)) {
                    str_Zip.AddErrorMessage(ConvertToString(str_Zip.RequiredErrorMessage).Replace("%s", str_Zip.Caption));
                }
            }
            if (str_County.Required) {
                if (!str_County.IsDetailKey && Empty(str_County.FormValue)) {
                    str_County.AddErrorMessage(ConvertToString(str_County.RequiredErrorMessage).Replace("%s", str_County.Caption));
                }
            }
            if (str_Manager.Required) {
                if (!str_Manager.IsDetailKey && Empty(str_Manager.FormValue)) {
                    str_Manager.AddErrorMessage(ConvertToString(str_Manager.RequiredErrorMessage).Replace("%s", str_Manager.Caption));
                }
            }
            if (str_Phone_Main.Required) {
                if (!str_Phone_Main.IsDetailKey && Empty(str_Phone_Main.FormValue)) {
                    str_Phone_Main.AddErrorMessage(ConvertToString(str_Phone_Main.RequiredErrorMessage).Replace("%s", str_Phone_Main.Caption));
                }
            }
            if (str_Phone_Fax.Required) {
                if (!str_Phone_Fax.IsDetailKey && Empty(str_Phone_Fax.FormValue)) {
                    str_Phone_Fax.AddErrorMessage(ConvertToString(str_Phone_Fax.RequiredErrorMessage).Replace("%s", str_Phone_Fax.Caption));
                }
            }
            if (str_Phone_Other.Required) {
                if (!str_Phone_Other.IsDetailKey && Empty(str_Phone_Other.FormValue)) {
                    str_Phone_Other.AddErrorMessage(ConvertToString(str_Phone_Other.RequiredErrorMessage).Replace("%s", str_Phone_Other.Caption));
                }
            }
            if (str_Notes.Required) {
                if (!str_Notes.IsDetailKey && Empty(str_Notes.FormValue)) {
                    str_Notes.AddErrorMessage(ConvertToString(str_Notes.RequiredErrorMessage).Replace("%s", str_Notes.Caption));
                }
            }
            if (str_Coverage_Code.Required) {
                if (!str_Coverage_Code.IsDetailKey && Empty(str_Coverage_Code.FormValue)) {
                    str_Coverage_Code.AddErrorMessage(ConvertToString(str_Coverage_Code.RequiredErrorMessage).Replace("%s", str_Coverage_Code.Caption));
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
            if (bit_IsDeleted.Required) {
                if (Empty(bit_IsDeleted.FormValue)) {
                    bit_IsDeleted.AddErrorMessage(ConvertToString(bit_IsDeleted.RequiredErrorMessage).Replace("%s", bit_IsDeleted.Caption));
                }
            }
            if (str_LocCapacity.Required) {
                if (!str_LocCapacity.IsDetailKey && Empty(str_LocCapacity.FormValue)) {
                    str_LocCapacity.AddErrorMessage(ConvertToString(str_LocCapacity.RequiredErrorMessage).Replace("%s", str_LocCapacity.Caption));
                }
            }
            if (str_ContactEmail.Required) {
                if (!str_ContactEmail.IsDetailKey && Empty(str_ContactEmail.FormValue)) {
                    str_ContactEmail.AddErrorMessage(ConvertToString(str_ContactEmail.RequiredErrorMessage).Replace("%s", str_ContactEmail.Caption));
                }
            }
            if (str_SchoolHours.Required) {
                if (!str_SchoolHours.IsDetailKey && Empty(str_SchoolHours.FormValue)) {
                    str_SchoolHours.AddErrorMessage(ConvertToString(str_SchoolHours.RequiredErrorMessage).Replace("%s", str_SchoolHours.Caption));
                }
            }
            if (str_EmerName.Required) {
                if (!str_EmerName.IsDetailKey && Empty(str_EmerName.FormValue)) {
                    str_EmerName.AddErrorMessage(ConvertToString(str_EmerName.RequiredErrorMessage).Replace("%s", str_EmerName.Caption));
                }
            }
            if (str_EmerPhone.Required) {
                if (!str_EmerPhone.IsDetailKey && Empty(str_EmerPhone.FormValue)) {
                    str_EmerPhone.AddErrorMessage(ConvertToString(str_EmerPhone.RequiredErrorMessage).Replace("%s", str_EmerPhone.Caption));
                }
            }
            if (str_Room.Required) {
                if (!str_Room.IsDetailKey && Empty(str_Room.FormValue)) {
                    str_Room.AddErrorMessage(ConvertToString(str_Room.RequiredErrorMessage).Replace("%s", str_Room.Caption));
                }
            }
            if (str_Email_Content.Required) {
                if (!str_Email_Content.IsDetailKey && Empty(str_Email_Content.FormValue)) {
                    str_Email_Content.AddErrorMessage(ConvertToString(str_Email_Content.RequiredErrorMessage).Replace("%s", str_Email_Content.Caption));
                }
            }
            if (bit_appointmentColor.Required) {
                if (Empty(bit_appointmentColor.FormValue)) {
                    bit_appointmentColor.AddErrorMessage(ConvertToString(bit_appointmentColor.RequiredErrorMessage).Replace("%s", bit_appointmentColor.Caption));
                }
            }
            if (str_appointmentColorCode.Required) {
                if (!str_appointmentColorCode.IsDetailKey && Empty(str_appointmentColorCode.FormValue)) {
                    str_appointmentColorCode.AddErrorMessage(ConvertToString(str_appointmentColorCode.RequiredErrorMessage).Replace("%s", str_appointmentColorCode.Caption));
                }
            }
            if (isKnowledgeTest.Required) {
                if (Empty(isKnowledgeTest.FormValue)) {
                    isKnowledgeTest.AddErrorMessage(ConvertToString(isKnowledgeTest.RequiredErrorMessage).Replace("%s", isKnowledgeTest.Caption));
                }
            }
            if (isRoadTest.Required) {
                if (Empty(isRoadTest.FormValue)) {
                    isRoadTest.AddErrorMessage(ConvertToString(isRoadTest.RequiredErrorMessage).Replace("%s", isRoadTest.Caption));
                }
            }
            if (dec_Latitude.Required) {
                if (!dec_Latitude.IsDetailKey && Empty(dec_Latitude.FormValue)) {
                    dec_Latitude.AddErrorMessage(ConvertToString(dec_Latitude.RequiredErrorMessage).Replace("%s", dec_Latitude.Caption));
                }
            }
            if (!CheckNumber(dec_Latitude.FormValue)) {
                dec_Latitude.AddErrorMessage(dec_Latitude.GetErrorMessage(false));
            }
            if (dec_Longitude.Required) {
                if (!dec_Longitude.IsDetailKey && Empty(dec_Longitude.FormValue)) {
                    dec_Longitude.AddErrorMessage(ConvertToString(dec_Longitude.RequiredErrorMessage).Replace("%s", dec_Longitude.Caption));
                }
            }
            if (!CheckNumber(dec_Longitude.FormValue)) {
                dec_Longitude.AddErrorMessage(dec_Longitude.GetErrorMessage(false));
            }
            if (str_nameAr.Required) {
                if (!str_nameAr.IsDetailKey && Empty(str_nameAr.FormValue)) {
                    str_nameAr.AddErrorMessage(ConvertToString(str_nameAr.RequiredErrorMessage).Replace("%s", str_nameAr.Caption));
                }
            }
            if (IsDistanceBasedScheduling.Required) {
                if (!IsDistanceBasedScheduling.IsDetailKey && Empty(IsDistanceBasedScheduling.FormValue)) {
                    IsDistanceBasedScheduling.AddErrorMessage(ConvertToString(IsDistanceBasedScheduling.RequiredErrorMessage).Replace("%s", IsDistanceBasedScheduling.Caption));
                }
            }
            if (!CheckInteger(IsDistanceBasedScheduling.FormValue)) {
                IsDistanceBasedScheduling.AddErrorMessage(IsDistanceBasedScheduling.GetErrorMessage(false));
            }
            if (str_ZoomEmail.Required) {
                if (!str_ZoomEmail.IsDetailKey && Empty(str_ZoomEmail.FormValue)) {
                    str_ZoomEmail.AddErrorMessage(ConvertToString(str_ZoomEmail.RequiredErrorMessage).Replace("%s", str_ZoomEmail.Caption));
                }
            }
            if (str_ProviderLocationId.Required) {
                if (!str_ProviderLocationId.IsDetailKey && Empty(str_ProviderLocationId.FormValue)) {
                    str_ProviderLocationId.AddErrorMessage(ConvertToString(str_ProviderLocationId.RequiredErrorMessage).Replace("%s", str_ProviderLocationId.Caption));
                }
            }
            if (int_RoadDistanceCoverage.Required) {
                if (!int_RoadDistanceCoverage.IsDetailKey && Empty(int_RoadDistanceCoverage.FormValue)) {
                    int_RoadDistanceCoverage.AddErrorMessage(ConvertToString(int_RoadDistanceCoverage.RequiredErrorMessage).Replace("%s", int_RoadDistanceCoverage.Caption));
                }
            }
            if (!CheckInteger(int_RoadDistanceCoverage.FormValue)) {
                int_RoadDistanceCoverage.AddErrorMessage(int_RoadDistanceCoverage.GetErrorMessage(false));
            }
            if (IsCashDrawer.Required) {
                if (!IsCashDrawer.IsDetailKey && Empty(IsCashDrawer.FormValue)) {
                    IsCashDrawer.AddErrorMessage(ConvertToString(IsCashDrawer.RequiredErrorMessage).Replace("%s", IsCashDrawer.Caption));
                }
            }
            if (!CheckInteger(IsCashDrawer.FormValue)) {
                IsCashDrawer.AddErrorMessage(IsCashDrawer.GetErrorMessage(false));
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
                // int_Location_Id
                int_Location_Id.SetDbValue(rsnew, int_Location_Id.CurrentValue);

                // str_Name
                str_Name.SetDbValue(rsnew, str_Name.CurrentValue);

                // str_Code
                str_Code.SetDbValue(rsnew, str_Code.CurrentValue);

                // str_Location_Type
                str_Location_Type.SetDbValue(rsnew, str_Location_Type.CurrentValue);

                // str_Address1
                str_Address1.SetDbValue(rsnew, str_Address1.CurrentValue);

                // str_Address2
                str_Address2.SetDbValue(rsnew, str_Address2.CurrentValue);

                // str_City
                str_City.SetDbValue(rsnew, str_City.CurrentValue);

                // int_State
                int_State.SetDbValue(rsnew, int_State.CurrentValue);

                // str_Zip
                str_Zip.SetDbValue(rsnew, str_Zip.CurrentValue);

                // str_County
                str_County.SetDbValue(rsnew, str_County.CurrentValue);

                // str_Manager
                str_Manager.SetDbValue(rsnew, str_Manager.CurrentValue);

                // str_Phone_Main
                str_Phone_Main.SetDbValue(rsnew, str_Phone_Main.CurrentValue);

                // str_Phone_Fax
                str_Phone_Fax.SetDbValue(rsnew, str_Phone_Fax.CurrentValue);

                // str_Phone_Other
                str_Phone_Other.SetDbValue(rsnew, str_Phone_Other.CurrentValue);

                // str_Notes
                str_Notes.SetDbValue(rsnew, str_Notes.CurrentValue);

                // str_Coverage_Code
                str_Coverage_Code.SetDbValue(rsnew, str_Coverage_Code.CurrentValue);

                // int_Status
                int_Status.SetDbValue(rsnew, int_Status.CurrentValue);

                // date_Created
                date_Created.SetDbValue(rsnew, ConvertToDateTime(date_Created.CurrentValue, date_Created.FormatPattern));

                // date_Modified
                date_Modified.SetDbValue(rsnew, ConvertToDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern));

                // int_Created_By
                int_Created_By.SetDbValue(rsnew, int_Created_By.CurrentValue);

                // int_Modified_By
                int_Modified_By.SetDbValue(rsnew, int_Modified_By.CurrentValue);

                // bit_IsDeleted
                bit_IsDeleted.SetDbValue(rsnew, ConvertToBool(bit_IsDeleted.CurrentValue));

                // str_LocCapacity
                str_LocCapacity.SetDbValue(rsnew, str_LocCapacity.CurrentValue);

                // str_ContactEmail
                str_ContactEmail.SetDbValue(rsnew, str_ContactEmail.CurrentValue);

                // str_SchoolHours
                str_SchoolHours.SetDbValue(rsnew, str_SchoolHours.CurrentValue);

                // str_EmerName
                str_EmerName.SetDbValue(rsnew, str_EmerName.CurrentValue);

                // str_EmerPhone
                str_EmerPhone.SetDbValue(rsnew, str_EmerPhone.CurrentValue);

                // str_Room
                str_Room.SetDbValue(rsnew, str_Room.CurrentValue);

                // str_Email_Content
                str_Email_Content.SetDbValue(rsnew, str_Email_Content.CurrentValue);

                // bit_appointmentColor
                bit_appointmentColor.SetDbValue(rsnew, ConvertToBool(bit_appointmentColor.CurrentValue));

                // str_appointmentColorCode
                str_appointmentColorCode.SetDbValue(rsnew, str_appointmentColorCode.CurrentValue);

                // isKnowledgeTest
                isKnowledgeTest.SetDbValue(rsnew, ConvertToBool(isKnowledgeTest.CurrentValue));

                // isRoadTest
                isRoadTest.SetDbValue(rsnew, ConvertToBool(isRoadTest.CurrentValue));

                // dec_Latitude
                dec_Latitude.SetDbValue(rsnew, dec_Latitude.CurrentValue);

                // dec_Longitude
                dec_Longitude.SetDbValue(rsnew, dec_Longitude.CurrentValue);

                // str_nameAr
                str_nameAr.SetDbValue(rsnew, str_nameAr.CurrentValue);

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.SetDbValue(rsnew, IsDistanceBasedScheduling.CurrentValue);

                // str_ZoomEmail
                str_ZoomEmail.SetDbValue(rsnew, str_ZoomEmail.CurrentValue);

                // str_ProviderLocationId
                str_ProviderLocationId.SetDbValue(rsnew, str_ProviderLocationId.CurrentValue);

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.SetDbValue(rsnew, int_RoadDistanceCoverage.CurrentValue);

                // IsCashDrawer
                IsCashDrawer.SetDbValue(rsnew, IsCashDrawer.CurrentValue);
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }

            // Update current values
            SetCurrentValues(rsnew);
            if (!Empty(int_Location_Id.CurrentValue)) { // Check field with unique index
                var filter = "(int_Location_Id = " + AdjustSql(int_Location_Id.CurrentValue, DbId) + ")";
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupIndex").Replace("%f", int_Location_Id.Caption).Replace("%v", ConvertToString(int_Location_Id.CurrentValue));
                    return JsonBoolResult.FalseResult;
                }
            }

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);

            // Check if key value entered
            if (insertRow && ValidateKey && Empty(rsnew["int_Location_Id"])) {
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblLocationList")), "", TableVar, true);
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
