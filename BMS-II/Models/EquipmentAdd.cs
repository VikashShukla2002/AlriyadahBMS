namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// equipmentAdd
    /// </summary>
    public static EquipmentAdd equipmentAdd
    {
        get => HttpData.Get<EquipmentAdd>("equipmentAdd")!;
        set => HttpData["equipmentAdd"] = value;
    }

    /// <summary>
    /// Page class for Equipment
    /// </summary>
    public class EquipmentAdd : EquipmentAddBase
    {
        // Constructor
        public EquipmentAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public EquipmentAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class EquipmentAddBase : Equipment
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Equipment";

        // Page object name
        public string PageObjName = "equipmentAdd";

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
        public EquipmentAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (equipment)
            if (equipment == null || equipment is Equipment)
                equipment = this;

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
        public string PageName => "EquipmentAdd";

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
            Equipment_ID.Visible = false;
            int_Location.SetVisibility();
            Equipment_Type_ID.SetVisibility();
            Equipment_Type_Name.Visible = false;
            Manufacturer_Name.SetVisibility();
            Serial_VIN_Number.SetVisibility();
            Retailer_Name.SetVisibility();
            DatePurchased.SetVisibility();
            ServiceInception_Date.SetVisibility();
            UsefulLife.SetVisibility();
            Price.SetVisibility();
            VAT.SetVisibility();
            Creation_Date.SetVisibility();
            Modified_Date.SetVisibility();
            Created_by.SetVisibility();
            Modified_by.SetVisibility();
        }

        // Constructor
        public EquipmentAddBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "EquipmentView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("Equipment_ID") ? dict["Equipment_ID"] : Equipment_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                Equipment_ID.Visible = false;
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
            await SetupLookupOptions(Equipment_Type_ID);

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
                if (RouteValues.TryGetValue("Equipment_ID", out rv)) { // DN
                    Equipment_ID.QueryValue = UrlDecode(rv); // DN
                } else if (Get("Equipment_ID", out sv)) {
                    Equipment_ID.QueryValue = sv.ToString();
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
                        return Terminate("EquipmentList"); // No matching record, return to List page // DN
                    }
                    break;
                case "insert": // Add new record // DN
                    SendEmail = true; // Send email on add success
                    var res = await AddRow(rsold);
                    if (res) { // Add successful
                        if (Empty(SuccessMessage) && Post("addopt") != "1") // Skip success message for addopt (done in JavaScript)
                            SuccessMessage = Language.Phrase("AddSuccess"); // Set up success message
                        string returnUrl = "";
                        returnUrl = "EquipmentList";
                        if (GetPageName(returnUrl) == "EquipmentList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "EquipmentView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "EquipmentList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "EquipmentList"; // Return list page content
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
                equipmentAdd?.PageRender();
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

            // Check field name 'int_Location' before field var 'x_int_Location'
            val = CurrentForm.HasValue("int_Location") ? CurrentForm.GetValue("int_Location") : CurrentForm.GetValue("x_int_Location");
            if (!int_Location.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Location") && !CurrentForm.HasValue("x_int_Location")) // DN
                    int_Location.Visible = false; // Disable update for API request
                else
                    int_Location.SetFormValue(val);
            }

            // Check field name 'Equipment_Type_ID' before field var 'x_Equipment_Type_ID'
            val = CurrentForm.HasValue("Equipment_Type_ID") ? CurrentForm.GetValue("Equipment_Type_ID") : CurrentForm.GetValue("x_Equipment_Type_ID");
            if (!Equipment_Type_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Equipment_Type_ID") && !CurrentForm.HasValue("x_Equipment_Type_ID")) // DN
                    Equipment_Type_ID.Visible = false; // Disable update for API request
                else
                    Equipment_Type_ID.SetFormValue(val);
            }

            // Check field name 'Manufacturer_Name' before field var 'x_Manufacturer_Name'
            val = CurrentForm.HasValue("Manufacturer_Name") ? CurrentForm.GetValue("Manufacturer_Name") : CurrentForm.GetValue("x_Manufacturer_Name");
            if (!Manufacturer_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Manufacturer_Name") && !CurrentForm.HasValue("x_Manufacturer_Name")) // DN
                    Manufacturer_Name.Visible = false; // Disable update for API request
                else
                    Manufacturer_Name.SetFormValue(val);
            }

            // Check field name 'Serial_VIN_Number' before field var 'x_Serial_VIN_Number'
            val = CurrentForm.HasValue("Serial_VIN_Number") ? CurrentForm.GetValue("Serial_VIN_Number") : CurrentForm.GetValue("x_Serial_VIN_Number");
            if (!Serial_VIN_Number.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Serial_VIN_Number") && !CurrentForm.HasValue("x_Serial_VIN_Number")) // DN
                    Serial_VIN_Number.Visible = false; // Disable update for API request
                else
                    Serial_VIN_Number.SetFormValue(val);
            }

            // Check field name 'Retailer_Name' before field var 'x_Retailer_Name'
            val = CurrentForm.HasValue("Retailer_Name") ? CurrentForm.GetValue("Retailer_Name") : CurrentForm.GetValue("x_Retailer_Name");
            if (!Retailer_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Retailer_Name") && !CurrentForm.HasValue("x_Retailer_Name")) // DN
                    Retailer_Name.Visible = false; // Disable update for API request
                else
                    Retailer_Name.SetFormValue(val);
            }

            // Check field name 'DatePurchased' before field var 'x_DatePurchased'
            val = CurrentForm.HasValue("DatePurchased") ? CurrentForm.GetValue("DatePurchased") : CurrentForm.GetValue("x_DatePurchased");
            if (!DatePurchased.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("DatePurchased") && !CurrentForm.HasValue("x_DatePurchased")) // DN
                    DatePurchased.Visible = false; // Disable update for API request
                else
                    DatePurchased.SetFormValue(val, true, validate);
                DatePurchased.CurrentValue = UnformatDateTime(DatePurchased.CurrentValue, DatePurchased.FormatPattern);
            }

            // Check field name 'ServiceInception_Date' before field var 'x_ServiceInception_Date'
            val = CurrentForm.HasValue("ServiceInception_Date") ? CurrentForm.GetValue("ServiceInception_Date") : CurrentForm.GetValue("x_ServiceInception_Date");
            if (!ServiceInception_Date.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("ServiceInception_Date") && !CurrentForm.HasValue("x_ServiceInception_Date")) // DN
                    ServiceInception_Date.Visible = false; // Disable update for API request
                else
                    ServiceInception_Date.SetFormValue(val, true, validate);
                ServiceInception_Date.CurrentValue = UnformatDateTime(ServiceInception_Date.CurrentValue, ServiceInception_Date.FormatPattern);
            }

            // Check field name 'UsefulLife' before field var 'x_UsefulLife'
            val = CurrentForm.HasValue("UsefulLife") ? CurrentForm.GetValue("UsefulLife") : CurrentForm.GetValue("x_UsefulLife");
            if (!UsefulLife.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("UsefulLife") && !CurrentForm.HasValue("x_UsefulLife")) // DN
                    UsefulLife.Visible = false; // Disable update for API request
                else
                    UsefulLife.SetFormValue(val, true, validate);
            }

            // Check field name 'Price' before field var 'x_Price'
            val = CurrentForm.HasValue("Price") ? CurrentForm.GetValue("Price") : CurrentForm.GetValue("x_Price");
            if (!Price.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Price") && !CurrentForm.HasValue("x_Price")) // DN
                    Price.Visible = false; // Disable update for API request
                else
                    Price.SetFormValue(val, true, validate);
            }

            // Check field name 'VAT' before field var 'x_VAT'
            val = CurrentForm.HasValue("VAT") ? CurrentForm.GetValue("VAT") : CurrentForm.GetValue("x_VAT");
            if (!VAT.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("VAT") && !CurrentForm.HasValue("x_VAT")) // DN
                    VAT.Visible = false; // Disable update for API request
                else
                    VAT.SetFormValue(val, true, validate);
            }

            // Check field name 'Creation_Date' before field var 'x_Creation_Date'
            val = CurrentForm.HasValue("Creation_Date") ? CurrentForm.GetValue("Creation_Date") : CurrentForm.GetValue("x_Creation_Date");
            if (!Creation_Date.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Creation_Date") && !CurrentForm.HasValue("x_Creation_Date")) // DN
                    Creation_Date.Visible = false; // Disable update for API request
                else
                    Creation_Date.SetFormValue(val);
                Creation_Date.CurrentValue = UnformatDateTime(Creation_Date.CurrentValue, Creation_Date.FormatPattern);
            }

            // Check field name 'Modified_Date' before field var 'x_Modified_Date'
            val = CurrentForm.HasValue("Modified_Date") ? CurrentForm.GetValue("Modified_Date") : CurrentForm.GetValue("x_Modified_Date");
            if (!Modified_Date.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Modified_Date") && !CurrentForm.HasValue("x_Modified_Date")) // DN
                    Modified_Date.Visible = false; // Disable update for API request
                else
                    Modified_Date.SetFormValue(val);
                Modified_Date.CurrentValue = UnformatDateTime(Modified_Date.CurrentValue, Modified_Date.FormatPattern);
            }

            // Check field name 'Created_by' before field var 'x_Created_by'
            val = CurrentForm.HasValue("Created_by") ? CurrentForm.GetValue("Created_by") : CurrentForm.GetValue("x_Created_by");
            if (!Created_by.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Created_by") && !CurrentForm.HasValue("x_Created_by")) // DN
                    Created_by.Visible = false; // Disable update for API request
                else
                    Created_by.SetFormValue(val);
            }

            // Check field name 'Modified_by' before field var 'x_Modified_by'
            val = CurrentForm.HasValue("Modified_by") ? CurrentForm.GetValue("Modified_by") : CurrentForm.GetValue("x_Modified_by");
            if (!Modified_by.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Modified_by") && !CurrentForm.HasValue("x_Modified_by")) // DN
                    Modified_by.Visible = false; // Disable update for API request
                else
                    Modified_by.SetFormValue(val);
            }

            // Check field name 'Equipment_ID' before field var 'x_Equipment_ID'
            val = CurrentForm.HasValue("Equipment_ID") ? CurrentForm.GetValue("Equipment_ID") : CurrentForm.GetValue("x_Equipment_ID");
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Location.CurrentValue = int_Location.FormValue;
            Equipment_Type_ID.CurrentValue = Equipment_Type_ID.FormValue;
            Manufacturer_Name.CurrentValue = Manufacturer_Name.FormValue;
            Serial_VIN_Number.CurrentValue = Serial_VIN_Number.FormValue;
            Retailer_Name.CurrentValue = Retailer_Name.FormValue;
            DatePurchased.CurrentValue = DatePurchased.FormValue;
            DatePurchased.CurrentValue = UnformatDateTime(DatePurchased.CurrentValue, DatePurchased.FormatPattern);
            ServiceInception_Date.CurrentValue = ServiceInception_Date.FormValue;
            ServiceInception_Date.CurrentValue = UnformatDateTime(ServiceInception_Date.CurrentValue, ServiceInception_Date.FormatPattern);
            UsefulLife.CurrentValue = UsefulLife.FormValue;
            Price.CurrentValue = Price.FormValue;
            VAT.CurrentValue = VAT.FormValue;
            Creation_Date.CurrentValue = Creation_Date.FormValue;
            Creation_Date.CurrentValue = UnformatDateTime(Creation_Date.CurrentValue, Creation_Date.FormatPattern);
            Modified_Date.CurrentValue = Modified_Date.FormValue;
            Modified_Date.CurrentValue = UnformatDateTime(Modified_Date.CurrentValue, Modified_Date.FormatPattern);
            Created_by.CurrentValue = Created_by.FormValue;
            Modified_by.CurrentValue = Modified_by.FormValue;
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
            Equipment_ID.SetDbValue(row["Equipment_ID"]);
            int_Location.SetDbValue(row["int_Location"]);
            Equipment_Type_ID.SetDbValue(row["Equipment_Type_ID"]);
            Equipment_Type_Name.SetDbValue(row["Equipment_Type_Name"]);
            Manufacturer_Name.SetDbValue(row["Manufacturer_Name"]);
            Serial_VIN_Number.SetDbValue(row["Serial_VIN_Number"]);
            Retailer_Name.SetDbValue(row["Retailer_Name"]);
            DatePurchased.SetDbValue(row["DatePurchased"]);
            ServiceInception_Date.SetDbValue(row["ServiceInception_Date"]);
            UsefulLife.SetDbValue(row["UsefulLife"]);
            Price.SetDbValue(row["Price"]);
            VAT.SetDbValue(row["VAT"]);
            Creation_Date.SetDbValue(row["Creation_Date"]);
            Modified_Date.SetDbValue(row["Modified_Date"]);
            Created_by.SetDbValue(row["Created_by"]);
            Modified_by.SetDbValue(row["Modified_by"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("Equipment_ID", Equipment_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location", int_Location.DefaultValue ?? DbNullValue); // DN
            row.Add("Equipment_Type_ID", Equipment_Type_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Equipment_Type_Name", Equipment_Type_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("Manufacturer_Name", Manufacturer_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("Serial_VIN_Number", Serial_VIN_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("Retailer_Name", Retailer_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("DatePurchased", DatePurchased.DefaultValue ?? DbNullValue); // DN
            row.Add("ServiceInception_Date", ServiceInception_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("UsefulLife", UsefulLife.DefaultValue ?? DbNullValue); // DN
            row.Add("Price", Price.DefaultValue ?? DbNullValue); // DN
            row.Add("VAT", VAT.DefaultValue ?? DbNullValue); // DN
            row.Add("Creation_Date", Creation_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("Modified_Date", Modified_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("Created_by", Created_by.DefaultValue ?? DbNullValue); // DN
            row.Add("Modified_by", Modified_by.DefaultValue ?? DbNullValue); // DN
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

            // Equipment_ID
            Equipment_ID.RowCssClass = "row";

            // int_Location
            int_Location.RowCssClass = "row";

            // Equipment_Type_ID
            Equipment_Type_ID.RowCssClass = "row";

            // Equipment_Type_Name
            Equipment_Type_Name.RowCssClass = "row";

            // Manufacturer_Name
            Manufacturer_Name.RowCssClass = "row";

            // Serial_VIN_Number
            Serial_VIN_Number.RowCssClass = "row";

            // Retailer_Name
            Retailer_Name.RowCssClass = "row";

            // DatePurchased
            DatePurchased.RowCssClass = "row";

            // ServiceInception_Date
            ServiceInception_Date.RowCssClass = "row";

            // UsefulLife
            UsefulLife.RowCssClass = "row";

            // Price
            Price.RowCssClass = "row";

            // VAT
            VAT.RowCssClass = "row";

            // Creation_Date
            Creation_Date.RowCssClass = "row";

            // Modified_Date
            Modified_Date.RowCssClass = "row";

            // Created_by
            Created_by.RowCssClass = "row";

            // Modified_by
            Modified_by.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // Equipment_ID
                Equipment_ID.ViewValue = Equipment_ID.CurrentValue;
                Equipment_ID.ViewCustomAttributes = "";

                // int_Location
                curVal = ConvertToString(int_Location.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Location.Lookup != null && IsDictionary(int_Location.Lookup?.Options) && int_Location.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Location.ViewValue = int_Location.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Location.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Location.Lookup != null) { // Lookup values found
                            var listwrk = int_Location.Lookup?.RenderViewRow(rswrk[0]);
                            int_Location.ViewValue = int_Location.HighlightLookup(ConvertToString(rswrk[0]), int_Location.DisplayValue(listwrk));
                        } else {
                            int_Location.ViewValue = FormatNumber(int_Location.CurrentValue, int_Location.FormatPattern);
                        }
                    }
                } else {
                    int_Location.ViewValue = DbNullValue;
                }
                int_Location.ViewCustomAttributes = "";

                // Equipment_Type_ID
                if (!Empty(Equipment_Type_ID.CurrentValue)) {
                    Equipment_Type_ID.ViewValue = Equipment_Type_ID.HighlightLookup(ConvertToString(Equipment_Type_ID.CurrentValue), Equipment_Type_ID.OptionCaption(ConvertToString(Equipment_Type_ID.CurrentValue)));
                } else {
                    Equipment_Type_ID.ViewValue = DbNullValue;
                }
                Equipment_Type_ID.ViewCustomAttributes = "";

                // Equipment_Type_Name
                Equipment_Type_Name.ViewValue = ConvertToString(Equipment_Type_Name.CurrentValue); // DN
                Equipment_Type_Name.ViewCustomAttributes = "";

                // Manufacturer_Name
                Manufacturer_Name.ViewValue = ConvertToString(Manufacturer_Name.CurrentValue); // DN
                Manufacturer_Name.ViewCustomAttributes = "";

                // Serial_VIN_Number
                Serial_VIN_Number.ViewValue = ConvertToString(Serial_VIN_Number.CurrentValue); // DN
                Serial_VIN_Number.ViewCustomAttributes = "";

                // Retailer_Name
                Retailer_Name.ViewValue = ConvertToString(Retailer_Name.CurrentValue); // DN
                Retailer_Name.ViewCustomAttributes = "";

                // DatePurchased
                DatePurchased.ViewValue = DatePurchased.CurrentValue;
                DatePurchased.ViewValue = FormatDateTime(DatePurchased.ViewValue, DatePurchased.FormatPattern);
                DatePurchased.ViewCustomAttributes = "";

                // ServiceInception_Date
                ServiceInception_Date.ViewValue = ServiceInception_Date.CurrentValue;
                ServiceInception_Date.ViewValue = FormatDateTime(ServiceInception_Date.ViewValue, ServiceInception_Date.FormatPattern);
                ServiceInception_Date.ViewCustomAttributes = "";

                // UsefulLife
                UsefulLife.ViewValue = UsefulLife.CurrentValue;
                UsefulLife.ViewValue = FormatNumber(UsefulLife.ViewValue, UsefulLife.FormatPattern);
                UsefulLife.ViewCustomAttributes = "";

                // Price
                Price.ViewValue = Price.CurrentValue;
                Price.ViewValue = FormatNumber(Price.ViewValue, Price.FormatPattern);
                Price.ViewCustomAttributes = "";

                // VAT
                VAT.ViewValue = VAT.CurrentValue;
                VAT.ViewValue = FormatNumber(VAT.ViewValue, VAT.FormatPattern);
                VAT.ViewCustomAttributes = "";

                // Creation_Date
                Creation_Date.ViewValue = Creation_Date.CurrentValue;
                Creation_Date.ViewValue = FormatDateTime(Creation_Date.ViewValue, Creation_Date.FormatPattern);
                Creation_Date.ViewCustomAttributes = "";

                // Modified_Date
                Modified_Date.ViewValue = Modified_Date.CurrentValue;
                Modified_Date.ViewValue = FormatDateTime(Modified_Date.ViewValue, Modified_Date.FormatPattern);
                Modified_Date.ViewCustomAttributes = "";

                // Created_by
                Created_by.ViewValue = Created_by.CurrentValue;
                Created_by.ViewCustomAttributes = "";

                // Modified_by
                Modified_by.ViewValue = Modified_by.CurrentValue;
                Modified_by.ViewCustomAttributes = "";

                // int_Location
                int_Location.HrefValue = "";

                // Equipment_Type_ID
                Equipment_Type_ID.HrefValue = "";

                // Manufacturer_Name
                Manufacturer_Name.HrefValue = "";

                // Serial_VIN_Number
                Serial_VIN_Number.HrefValue = "";

                // Retailer_Name
                Retailer_Name.HrefValue = "";

                // DatePurchased
                DatePurchased.HrefValue = "";

                // ServiceInception_Date
                ServiceInception_Date.HrefValue = "";

                // UsefulLife
                UsefulLife.HrefValue = "";

                // Price
                Price.HrefValue = "";

                // VAT
                VAT.HrefValue = "";

                // Creation_Date
                Creation_Date.HrefValue = "";
                Creation_Date.TooltipValue = "";

                // Modified_Date
                Modified_Date.HrefValue = "";

                // Created_by
                Created_by.HrefValue = "";
                Created_by.TooltipValue = "";

                // Modified_by
                Modified_by.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // int_Location
                int_Location.SetupEditAttributes();
                curVal = ConvertToString(int_Location.CurrentValue)?.Trim() ?? "";
                if (int_Location.Lookup != null && IsDictionary(int_Location.Lookup?.Options) && int_Location.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Location.EditValue = int_Location.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_Location.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Location.EditValue = rswrk;
                }
                int_Location.PlaceHolder = RemoveHtml(int_Location.Caption);
                if (!Empty(int_Location.EditValue) && IsNumeric(int_Location.EditValue))
                    int_Location.EditValue = FormatNumber(int_Location.EditValue, null);

                // Equipment_Type_ID
                Equipment_Type_ID.SetupEditAttributes();
                Equipment_Type_ID.EditValue = Equipment_Type_ID.Options(true);
                Equipment_Type_ID.PlaceHolder = RemoveHtml(Equipment_Type_ID.Caption);
                if (!Empty(Equipment_Type_ID.EditValue) && IsNumeric(Equipment_Type_ID.EditValue))
                    Equipment_Type_ID.EditValue = FormatNumber(Equipment_Type_ID.EditValue, null);

                // Manufacturer_Name
                Manufacturer_Name.SetupEditAttributes();
                if (!Manufacturer_Name.Raw)
                    Manufacturer_Name.CurrentValue = HtmlDecode(Manufacturer_Name.CurrentValue);
                Manufacturer_Name.EditValue = HtmlEncode(Manufacturer_Name.CurrentValue);
                Manufacturer_Name.PlaceHolder = RemoveHtml(Manufacturer_Name.Caption);

                // Serial_VIN_Number
                Serial_VIN_Number.SetupEditAttributes();
                if (!Serial_VIN_Number.Raw)
                    Serial_VIN_Number.CurrentValue = HtmlDecode(Serial_VIN_Number.CurrentValue);
                Serial_VIN_Number.EditValue = HtmlEncode(Serial_VIN_Number.CurrentValue);
                Serial_VIN_Number.PlaceHolder = RemoveHtml(Serial_VIN_Number.Caption);

                // Retailer_Name
                Retailer_Name.SetupEditAttributes();
                if (!Retailer_Name.Raw)
                    Retailer_Name.CurrentValue = HtmlDecode(Retailer_Name.CurrentValue);
                Retailer_Name.EditValue = HtmlEncode(Retailer_Name.CurrentValue);
                Retailer_Name.PlaceHolder = RemoveHtml(Retailer_Name.Caption);

                // DatePurchased
                DatePurchased.SetupEditAttributes();
                DatePurchased.EditValue = FormatDateTime(DatePurchased.CurrentValue, DatePurchased.FormatPattern); // DN
                DatePurchased.PlaceHolder = RemoveHtml(DatePurchased.Caption);

                // ServiceInception_Date
                ServiceInception_Date.SetupEditAttributes();
                ServiceInception_Date.EditValue = FormatDateTime(ServiceInception_Date.CurrentValue, ServiceInception_Date.FormatPattern); // DN
                ServiceInception_Date.PlaceHolder = RemoveHtml(ServiceInception_Date.Caption);

                // UsefulLife
                UsefulLife.SetupEditAttributes();
                UsefulLife.EditValue = UsefulLife.CurrentValue; // DN
                UsefulLife.PlaceHolder = RemoveHtml(UsefulLife.Caption);
                if (!Empty(UsefulLife.EditValue) && IsNumeric(UsefulLife.EditValue))
                    UsefulLife.EditValue = FormatNumber(UsefulLife.EditValue, null);

                // Price
                Price.SetupEditAttributes();
                Price.EditValue = Price.CurrentValue; // DN
                Price.PlaceHolder = RemoveHtml(Price.Caption);
                if (!Empty(Price.EditValue) && IsNumeric(Price.EditValue))
                    Price.EditValue = FormatNumber(Price.EditValue, null);

                // VAT
                VAT.SetupEditAttributes();
                VAT.EditValue = VAT.CurrentValue; // DN
                VAT.PlaceHolder = RemoveHtml(VAT.Caption);
                if (!Empty(VAT.EditValue) && IsNumeric(VAT.EditValue))
                    VAT.EditValue = FormatNumber(VAT.EditValue, null);

                // Creation_Date

                // Modified_Date

                // Created_by

                // Modified_by

                // Add refer script

                // int_Location
                int_Location.HrefValue = "";

                // Equipment_Type_ID
                Equipment_Type_ID.HrefValue = "";

                // Manufacturer_Name
                Manufacturer_Name.HrefValue = "";

                // Serial_VIN_Number
                Serial_VIN_Number.HrefValue = "";

                // Retailer_Name
                Retailer_Name.HrefValue = "";

                // DatePurchased
                DatePurchased.HrefValue = "";

                // ServiceInception_Date
                ServiceInception_Date.HrefValue = "";

                // UsefulLife
                UsefulLife.HrefValue = "";

                // Price
                Price.HrefValue = "";

                // VAT
                VAT.HrefValue = "";

                // Creation_Date
                Creation_Date.HrefValue = "";

                // Modified_Date
                Modified_Date.HrefValue = "";

                // Created_by
                Created_by.HrefValue = "";

                // Modified_by
                Modified_by.HrefValue = "";
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
            if (int_Location.Required) {
                if (!int_Location.IsDetailKey && Empty(int_Location.FormValue)) {
                    int_Location.AddErrorMessage(ConvertToString(int_Location.RequiredErrorMessage).Replace("%s", int_Location.Caption));
                }
            }
            if (Equipment_Type_ID.Required) {
                if (!Equipment_Type_ID.IsDetailKey && Empty(Equipment_Type_ID.FormValue)) {
                    Equipment_Type_ID.AddErrorMessage(ConvertToString(Equipment_Type_ID.RequiredErrorMessage).Replace("%s", Equipment_Type_ID.Caption));
                }
            }
            if (Manufacturer_Name.Required) {
                if (!Manufacturer_Name.IsDetailKey && Empty(Manufacturer_Name.FormValue)) {
                    Manufacturer_Name.AddErrorMessage(ConvertToString(Manufacturer_Name.RequiredErrorMessage).Replace("%s", Manufacturer_Name.Caption));
                }
            }
            if (Serial_VIN_Number.Required) {
                if (!Serial_VIN_Number.IsDetailKey && Empty(Serial_VIN_Number.FormValue)) {
                    Serial_VIN_Number.AddErrorMessage(ConvertToString(Serial_VIN_Number.RequiredErrorMessage).Replace("%s", Serial_VIN_Number.Caption));
                }
            }
            if (Retailer_Name.Required) {
                if (!Retailer_Name.IsDetailKey && Empty(Retailer_Name.FormValue)) {
                    Retailer_Name.AddErrorMessage(ConvertToString(Retailer_Name.RequiredErrorMessage).Replace("%s", Retailer_Name.Caption));
                }
            }
            if (DatePurchased.Required) {
                if (!DatePurchased.IsDetailKey && Empty(DatePurchased.FormValue)) {
                    DatePurchased.AddErrorMessage(ConvertToString(DatePurchased.RequiredErrorMessage).Replace("%s", DatePurchased.Caption));
                }
            }
            if (!CheckDate(DatePurchased.FormValue, DatePurchased.FormatPattern)) {
                DatePurchased.AddErrorMessage(DatePurchased.GetErrorMessage(false));
            }
            if (ServiceInception_Date.Required) {
                if (!ServiceInception_Date.IsDetailKey && Empty(ServiceInception_Date.FormValue)) {
                    ServiceInception_Date.AddErrorMessage(ConvertToString(ServiceInception_Date.RequiredErrorMessage).Replace("%s", ServiceInception_Date.Caption));
                }
            }
            if (!CheckDate(ServiceInception_Date.FormValue, ServiceInception_Date.FormatPattern)) {
                ServiceInception_Date.AddErrorMessage(ServiceInception_Date.GetErrorMessage(false));
            }
            if (UsefulLife.Required) {
                if (!UsefulLife.IsDetailKey && Empty(UsefulLife.FormValue)) {
                    UsefulLife.AddErrorMessage(ConvertToString(UsefulLife.RequiredErrorMessage).Replace("%s", UsefulLife.Caption));
                }
            }
            if (!CheckInteger(UsefulLife.FormValue)) {
                UsefulLife.AddErrorMessage(UsefulLife.GetErrorMessage(false));
            }
            if (Price.Required) {
                if (!Price.IsDetailKey && Empty(Price.FormValue)) {
                    Price.AddErrorMessage(ConvertToString(Price.RequiredErrorMessage).Replace("%s", Price.Caption));
                }
            }
            if (!CheckNumber(Price.FormValue)) {
                Price.AddErrorMessage(Price.GetErrorMessage(false));
            }
            if (VAT.Required) {
                if (!VAT.IsDetailKey && Empty(VAT.FormValue)) {
                    VAT.AddErrorMessage(ConvertToString(VAT.RequiredErrorMessage).Replace("%s", VAT.Caption));
                }
            }
            if (!CheckNumber(VAT.FormValue)) {
                VAT.AddErrorMessage(VAT.GetErrorMessage(false));
            }
            if (Creation_Date.Required) {
                if (!Creation_Date.IsDetailKey && Empty(Creation_Date.FormValue)) {
                    Creation_Date.AddErrorMessage(ConvertToString(Creation_Date.RequiredErrorMessage).Replace("%s", Creation_Date.Caption));
                }
            }
            if (Modified_Date.Required) {
                if (!Modified_Date.IsDetailKey && Empty(Modified_Date.FormValue)) {
                    Modified_Date.AddErrorMessage(ConvertToString(Modified_Date.RequiredErrorMessage).Replace("%s", Modified_Date.Caption));
                }
            }
            if (Created_by.Required) {
                if (!Created_by.IsDetailKey && Empty(Created_by.FormValue)) {
                    Created_by.AddErrorMessage(ConvertToString(Created_by.RequiredErrorMessage).Replace("%s", Created_by.Caption));
                }
            }
            if (Modified_by.Required) {
                if (!Modified_by.IsDetailKey && Empty(Modified_by.FormValue)) {
                    Modified_by.AddErrorMessage(ConvertToString(Modified_by.RequiredErrorMessage).Replace("%s", Modified_by.Caption));
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
                // int_Location
                int_Location.SetDbValue(rsnew, int_Location.CurrentValue);

                // Equipment_Type_ID
                Equipment_Type_ID.SetDbValue(rsnew, Equipment_Type_ID.CurrentValue);

                // Manufacturer_Name
                Manufacturer_Name.SetDbValue(rsnew, Manufacturer_Name.CurrentValue);

                // Serial_VIN_Number
                Serial_VIN_Number.SetDbValue(rsnew, Serial_VIN_Number.CurrentValue);

                // Retailer_Name
                Retailer_Name.SetDbValue(rsnew, Retailer_Name.CurrentValue);

                // DatePurchased
                DatePurchased.SetDbValue(rsnew, ConvertToDateTime(DatePurchased.CurrentValue, DatePurchased.FormatPattern));

                // ServiceInception_Date
                ServiceInception_Date.SetDbValue(rsnew, ConvertToDateTime(ServiceInception_Date.CurrentValue, ServiceInception_Date.FormatPattern));

                // UsefulLife
                UsefulLife.SetDbValue(rsnew, UsefulLife.CurrentValue);

                // Price
                Price.SetDbValue(rsnew, Price.CurrentValue);

                // VAT
                VAT.SetDbValue(rsnew, VAT.CurrentValue);

                // Creation_Date
                Creation_Date.CurrentValue = Creation_Date.GetAutoUpdateValue();
                Creation_Date.SetDbValue(rsnew, Creation_Date.CurrentValue, false);

                // Modified_Date
                Modified_Date.CurrentValue = Modified_Date.GetAutoUpdateValue();
                Modified_Date.SetDbValue(rsnew, Modified_Date.CurrentValue, false);

                // Created_by
                Created_by.CurrentValue = Created_by.GetAutoUpdateValue();
                Created_by.SetDbValue(rsnew, Created_by.CurrentValue, false);

                // Modified_by
                Modified_by.CurrentValue = Modified_by.GetAutoUpdateValue();
                Modified_by.SetDbValue(rsnew, Modified_by.CurrentValue, false);
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
                    rsnew["Equipment_ID"] = Equipment_ID.CurrentValue!;
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("EquipmentList")), "", TableVar, true);
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
