namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblProductInfoAdd
    /// </summary>
    public static TblProductInfoAdd tblProductInfoAdd
    {
        get => HttpData.Get<TblProductInfoAdd>("tblProductInfoAdd")!;
        set => HttpData["tblProductInfoAdd"] = value;
    }

    /// <summary>
    /// Page class for tblProductInfo
    /// </summary>
    public class TblProductInfoAdd : TblProductInfoAddBase
    {
        // Constructor
        public TblProductInfoAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblProductInfoAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblProductInfoAddBase : TblProductInfo
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblProductInfo";

        // Page object name
        public string PageObjName = "tblProductInfoAdd";

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
        public TblProductInfoAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblProductInfo)
            if (tblProductInfo == null || tblProductInfo is TblProductInfo)
                tblProductInfo = this;

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
        public string PageName => "TblProductInfoAdd";

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
            int_Product_Id.SetVisibility();
            str_Product_Name.SetVisibility();
            str_Item_Code.SetVisibility();
            mny_Price.SetVisibility();
            bit_IsTaxable.SetVisibility();
            str_Web_Description.SetVisibility();
            dec_StateTax.SetVisibility();
            dec_AddTax.SetVisibility();
            mny_TotalPrice.SetVisibility();
            int_Product_Type.SetVisibility();
            int_Product_Sub_Type.SetVisibility();
            int_Status.SetVisibility();
            bit_Is_Web_Purchase.SetVisibility();
            str_BTW_Hours.SetVisibility();
            str_Hour.SetVisibility();
            Str_Minutes.SetVisibility();
            str_Appointment_Duration.SetVisibility();
            str_Notes.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            int_Dollar.SetVisibility();
            bit_PortalPurchase.SetVisibility();
            str_WebName.SetVisibility();
            bit_ExtraChk1.SetVisibility();
            bit_ExtraChk2.SetVisibility();
            str_ExtraDrpDown1.SetVisibility();
            str_ExtraDrpDown2.SetVisibility();
            str_Extratxt1.SetVisibility();
            str_Extratxt2.SetVisibility();
            str_OBHours.SetVisibility();
            str_OBMinutes.SetVisibility();
            str_TotalOB_Mins.SetVisibility();
            LMSProductID.SetVisibility();
            LMSNoOfAttempts.SetVisibility();
            int_LMSLinkExpirationDays.SetVisibility();
            IGD_product_id.SetVisibility();
            IEC_product_id.SetVisibility();
            Somastream_Product_ID.SetVisibility();
            ProTREAD_Product_ID.SetVisibility();
            ASD_product_id.SetVisibility();
            D2L_product_Id.SetVisibility();
            int_Course_Duration.SetVisibility();
            Moodle_product_Id.SetVisibility();
        }

        // Constructor
        public TblProductInfoAddBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblProductInfoView" ? "1" : "0"); // If View page, no primary button
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
            await SetupLookupOptions(bit_IsTaxable);
            await SetupLookupOptions(bit_Is_Web_Purchase);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_PortalPurchase);
            await SetupLookupOptions(bit_ExtraChk1);
            await SetupLookupOptions(bit_ExtraChk2);

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
            } else { // Not post back
                CopyRecord = false;
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
                        return Terminate("TblProductInfoList"); // No matching record, return to List page // DN
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
                        if (GetPageName(returnUrl) == "TblProductInfoList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "TblProductInfoView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblProductInfoList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblProductInfoList"; // Return list page content
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
                tblProductInfoAdd?.PageRender();
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

            // Check field name 'int_Product_Id' before field var 'x_int_Product_Id'
            val = CurrentForm.HasValue("int_Product_Id") ? CurrentForm.GetValue("int_Product_Id") : CurrentForm.GetValue("x_int_Product_Id");
            if (!int_Product_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Product_Id") && !CurrentForm.HasValue("x_int_Product_Id")) // DN
                    int_Product_Id.Visible = false; // Disable update for API request
                else
                    int_Product_Id.SetFormValue(val, true, validate);
            }

            // Check field name 'str_Product_Name' before field var 'x_str_Product_Name'
            val = CurrentForm.HasValue("str_Product_Name") ? CurrentForm.GetValue("str_Product_Name") : CurrentForm.GetValue("x_str_Product_Name");
            if (!str_Product_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Product_Name") && !CurrentForm.HasValue("x_str_Product_Name")) // DN
                    str_Product_Name.Visible = false; // Disable update for API request
                else
                    str_Product_Name.SetFormValue(val);
            }

            // Check field name 'str_Item_Code' before field var 'x_str_Item_Code'
            val = CurrentForm.HasValue("str_Item_Code") ? CurrentForm.GetValue("str_Item_Code") : CurrentForm.GetValue("x_str_Item_Code");
            if (!str_Item_Code.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Item_Code") && !CurrentForm.HasValue("x_str_Item_Code")) // DN
                    str_Item_Code.Visible = false; // Disable update for API request
                else
                    str_Item_Code.SetFormValue(val);
            }

            // Check field name 'mny_Price' before field var 'x_mny_Price'
            val = CurrentForm.HasValue("mny_Price") ? CurrentForm.GetValue("mny_Price") : CurrentForm.GetValue("x_mny_Price");
            if (!mny_Price.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_Price") && !CurrentForm.HasValue("x_mny_Price")) // DN
                    mny_Price.Visible = false; // Disable update for API request
                else
                    mny_Price.SetFormValue(val, true, validate);
            }

            // Check field name 'bit_IsTaxable' before field var 'x_bit_IsTaxable'
            val = CurrentForm.HasValue("bit_IsTaxable") ? CurrentForm.GetValue("bit_IsTaxable") : CurrentForm.GetValue("x_bit_IsTaxable");
            if (!bit_IsTaxable.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsTaxable") && !CurrentForm.HasValue("x_bit_IsTaxable")) // DN
                    bit_IsTaxable.Visible = false; // Disable update for API request
                else
                    bit_IsTaxable.SetFormValue(val);
            }

            // Check field name 'str_Web_Description' before field var 'x_str_Web_Description'
            val = CurrentForm.HasValue("str_Web_Description") ? CurrentForm.GetValue("str_Web_Description") : CurrentForm.GetValue("x_str_Web_Description");
            if (!str_Web_Description.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Web_Description") && !CurrentForm.HasValue("x_str_Web_Description")) // DN
                    str_Web_Description.Visible = false; // Disable update for API request
                else
                    str_Web_Description.SetFormValue(val);
            }

            // Check field name 'dec_StateTax' before field var 'x_dec_StateTax'
            val = CurrentForm.HasValue("dec_StateTax") ? CurrentForm.GetValue("dec_StateTax") : CurrentForm.GetValue("x_dec_StateTax");
            if (!dec_StateTax.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_StateTax") && !CurrentForm.HasValue("x_dec_StateTax")) // DN
                    dec_StateTax.Visible = false; // Disable update for API request
                else
                    dec_StateTax.SetFormValue(val, true, validate);
            }

            // Check field name 'dec_AddTax' before field var 'x_dec_AddTax'
            val = CurrentForm.HasValue("dec_AddTax") ? CurrentForm.GetValue("dec_AddTax") : CurrentForm.GetValue("x_dec_AddTax");
            if (!dec_AddTax.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_AddTax") && !CurrentForm.HasValue("x_dec_AddTax")) // DN
                    dec_AddTax.Visible = false; // Disable update for API request
                else
                    dec_AddTax.SetFormValue(val, true, validate);
            }

            // Check field name 'mny_TotalPrice' before field var 'x_mny_TotalPrice'
            val = CurrentForm.HasValue("mny_TotalPrice") ? CurrentForm.GetValue("mny_TotalPrice") : CurrentForm.GetValue("x_mny_TotalPrice");
            if (!mny_TotalPrice.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_TotalPrice") && !CurrentForm.HasValue("x_mny_TotalPrice")) // DN
                    mny_TotalPrice.Visible = false; // Disable update for API request
                else
                    mny_TotalPrice.SetFormValue(val, true, validate);
            }

            // Check field name 'int_Product_Type' before field var 'x_int_Product_Type'
            val = CurrentForm.HasValue("int_Product_Type") ? CurrentForm.GetValue("int_Product_Type") : CurrentForm.GetValue("x_int_Product_Type");
            if (!int_Product_Type.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Product_Type") && !CurrentForm.HasValue("x_int_Product_Type")) // DN
                    int_Product_Type.Visible = false; // Disable update for API request
                else
                    int_Product_Type.SetFormValue(val, true, validate);
            }

            // Check field name 'int_Product_Sub_Type' before field var 'x_int_Product_Sub_Type'
            val = CurrentForm.HasValue("int_Product_Sub_Type") ? CurrentForm.GetValue("int_Product_Sub_Type") : CurrentForm.GetValue("x_int_Product_Sub_Type");
            if (!int_Product_Sub_Type.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Product_Sub_Type") && !CurrentForm.HasValue("x_int_Product_Sub_Type")) // DN
                    int_Product_Sub_Type.Visible = false; // Disable update for API request
                else
                    int_Product_Sub_Type.SetFormValue(val, true, validate);
            }

            // Check field name 'int_Status' before field var 'x_int_Status'
            val = CurrentForm.HasValue("int_Status") ? CurrentForm.GetValue("int_Status") : CurrentForm.GetValue("x_int_Status");
            if (!int_Status.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Status") && !CurrentForm.HasValue("x_int_Status")) // DN
                    int_Status.Visible = false; // Disable update for API request
                else
                    int_Status.SetFormValue(val, true, validate);
            }

            // Check field name 'bit_Is_Web_Purchase' before field var 'x_bit_Is_Web_Purchase'
            val = CurrentForm.HasValue("bit_Is_Web_Purchase") ? CurrentForm.GetValue("bit_Is_Web_Purchase") : CurrentForm.GetValue("x_bit_Is_Web_Purchase");
            if (!bit_Is_Web_Purchase.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_Is_Web_Purchase") && !CurrentForm.HasValue("x_bit_Is_Web_Purchase")) // DN
                    bit_Is_Web_Purchase.Visible = false; // Disable update for API request
                else
                    bit_Is_Web_Purchase.SetFormValue(val);
            }

            // Check field name 'str_BTW_Hours' before field var 'x_str_BTW_Hours'
            val = CurrentForm.HasValue("str_BTW_Hours") ? CurrentForm.GetValue("str_BTW_Hours") : CurrentForm.GetValue("x_str_BTW_Hours");
            if (!str_BTW_Hours.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_BTW_Hours") && !CurrentForm.HasValue("x_str_BTW_Hours")) // DN
                    str_BTW_Hours.Visible = false; // Disable update for API request
                else
                    str_BTW_Hours.SetFormValue(val);
            }

            // Check field name 'str_Hour' before field var 'x_str_Hour'
            val = CurrentForm.HasValue("str_Hour") ? CurrentForm.GetValue("str_Hour") : CurrentForm.GetValue("x_str_Hour");
            if (!str_Hour.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Hour") && !CurrentForm.HasValue("x_str_Hour")) // DN
                    str_Hour.Visible = false; // Disable update for API request
                else
                    str_Hour.SetFormValue(val);
            }

            // Check field name 'Str_Minutes' before field var 'x_Str_Minutes'
            val = CurrentForm.HasValue("Str_Minutes") ? CurrentForm.GetValue("Str_Minutes") : CurrentForm.GetValue("x_Str_Minutes");
            if (!Str_Minutes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Str_Minutes") && !CurrentForm.HasValue("x_Str_Minutes")) // DN
                    Str_Minutes.Visible = false; // Disable update for API request
                else
                    Str_Minutes.SetFormValue(val);
            }

            // Check field name 'str_Appointment_Duration' before field var 'x_str_Appointment_Duration'
            val = CurrentForm.HasValue("str_Appointment_Duration") ? CurrentForm.GetValue("str_Appointment_Duration") : CurrentForm.GetValue("x_str_Appointment_Duration");
            if (!str_Appointment_Duration.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Appointment_Duration") && !CurrentForm.HasValue("x_str_Appointment_Duration")) // DN
                    str_Appointment_Duration.Visible = false; // Disable update for API request
                else
                    str_Appointment_Duration.SetFormValue(val);
            }

            // Check field name 'str_Notes' before field var 'x_str_Notes'
            val = CurrentForm.HasValue("str_Notes") ? CurrentForm.GetValue("str_Notes") : CurrentForm.GetValue("x_str_Notes");
            if (!str_Notes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Notes") && !CurrentForm.HasValue("x_str_Notes")) // DN
                    str_Notes.Visible = false; // Disable update for API request
                else
                    str_Notes.SetFormValue(val);
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

            // Check field name 'bit_IsDeleted' before field var 'x_bit_IsDeleted'
            val = CurrentForm.HasValue("bit_IsDeleted") ? CurrentForm.GetValue("bit_IsDeleted") : CurrentForm.GetValue("x_bit_IsDeleted");
            if (!bit_IsDeleted.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsDeleted") && !CurrentForm.HasValue("x_bit_IsDeleted")) // DN
                    bit_IsDeleted.Visible = false; // Disable update for API request
                else
                    bit_IsDeleted.SetFormValue(val);
            }

            // Check field name 'int_Dollar' before field var 'x_int_Dollar'
            val = CurrentForm.HasValue("int_Dollar") ? CurrentForm.GetValue("int_Dollar") : CurrentForm.GetValue("x_int_Dollar");
            if (!int_Dollar.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Dollar") && !CurrentForm.HasValue("x_int_Dollar")) // DN
                    int_Dollar.Visible = false; // Disable update for API request
                else
                    int_Dollar.SetFormValue(val, true, validate);
            }

            // Check field name 'bit_PortalPurchase' before field var 'x_bit_PortalPurchase'
            val = CurrentForm.HasValue("bit_PortalPurchase") ? CurrentForm.GetValue("bit_PortalPurchase") : CurrentForm.GetValue("x_bit_PortalPurchase");
            if (!bit_PortalPurchase.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_PortalPurchase") && !CurrentForm.HasValue("x_bit_PortalPurchase")) // DN
                    bit_PortalPurchase.Visible = false; // Disable update for API request
                else
                    bit_PortalPurchase.SetFormValue(val);
            }

            // Check field name 'str_WebName' before field var 'x_str_WebName'
            val = CurrentForm.HasValue("str_WebName") ? CurrentForm.GetValue("str_WebName") : CurrentForm.GetValue("x_str_WebName");
            if (!str_WebName.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_WebName") && !CurrentForm.HasValue("x_str_WebName")) // DN
                    str_WebName.Visible = false; // Disable update for API request
                else
                    str_WebName.SetFormValue(val);
            }

            // Check field name 'bit_ExtraChk1' before field var 'x_bit_ExtraChk1'
            val = CurrentForm.HasValue("bit_ExtraChk1") ? CurrentForm.GetValue("bit_ExtraChk1") : CurrentForm.GetValue("x_bit_ExtraChk1");
            if (!bit_ExtraChk1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_ExtraChk1") && !CurrentForm.HasValue("x_bit_ExtraChk1")) // DN
                    bit_ExtraChk1.Visible = false; // Disable update for API request
                else
                    bit_ExtraChk1.SetFormValue(val);
            }

            // Check field name 'bit_ExtraChk2' before field var 'x_bit_ExtraChk2'
            val = CurrentForm.HasValue("bit_ExtraChk2") ? CurrentForm.GetValue("bit_ExtraChk2") : CurrentForm.GetValue("x_bit_ExtraChk2");
            if (!bit_ExtraChk2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_ExtraChk2") && !CurrentForm.HasValue("x_bit_ExtraChk2")) // DN
                    bit_ExtraChk2.Visible = false; // Disable update for API request
                else
                    bit_ExtraChk2.SetFormValue(val);
            }

            // Check field name 'str_ExtraDrpDown1' before field var 'x_str_ExtraDrpDown1'
            val = CurrentForm.HasValue("str_ExtraDrpDown1") ? CurrentForm.GetValue("str_ExtraDrpDown1") : CurrentForm.GetValue("x_str_ExtraDrpDown1");
            if (!str_ExtraDrpDown1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ExtraDrpDown1") && !CurrentForm.HasValue("x_str_ExtraDrpDown1")) // DN
                    str_ExtraDrpDown1.Visible = false; // Disable update for API request
                else
                    str_ExtraDrpDown1.SetFormValue(val);
            }

            // Check field name 'str_ExtraDrpDown2' before field var 'x_str_ExtraDrpDown2'
            val = CurrentForm.HasValue("str_ExtraDrpDown2") ? CurrentForm.GetValue("str_ExtraDrpDown2") : CurrentForm.GetValue("x_str_ExtraDrpDown2");
            if (!str_ExtraDrpDown2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ExtraDrpDown2") && !CurrentForm.HasValue("x_str_ExtraDrpDown2")) // DN
                    str_ExtraDrpDown2.Visible = false; // Disable update for API request
                else
                    str_ExtraDrpDown2.SetFormValue(val);
            }

            // Check field name 'str_Extratxt1' before field var 'x_str_Extratxt1'
            val = CurrentForm.HasValue("str_Extratxt1") ? CurrentForm.GetValue("str_Extratxt1") : CurrentForm.GetValue("x_str_Extratxt1");
            if (!str_Extratxt1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Extratxt1") && !CurrentForm.HasValue("x_str_Extratxt1")) // DN
                    str_Extratxt1.Visible = false; // Disable update for API request
                else
                    str_Extratxt1.SetFormValue(val);
            }

            // Check field name 'str_Extratxt2' before field var 'x_str_Extratxt2'
            val = CurrentForm.HasValue("str_Extratxt2") ? CurrentForm.GetValue("str_Extratxt2") : CurrentForm.GetValue("x_str_Extratxt2");
            if (!str_Extratxt2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Extratxt2") && !CurrentForm.HasValue("x_str_Extratxt2")) // DN
                    str_Extratxt2.Visible = false; // Disable update for API request
                else
                    str_Extratxt2.SetFormValue(val);
            }

            // Check field name 'str_OBHours' before field var 'x_str_OBHours'
            val = CurrentForm.HasValue("str_OBHours") ? CurrentForm.GetValue("str_OBHours") : CurrentForm.GetValue("x_str_OBHours");
            if (!str_OBHours.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_OBHours") && !CurrentForm.HasValue("x_str_OBHours")) // DN
                    str_OBHours.Visible = false; // Disable update for API request
                else
                    str_OBHours.SetFormValue(val);
            }

            // Check field name 'str_OBMinutes' before field var 'x_str_OBMinutes'
            val = CurrentForm.HasValue("str_OBMinutes") ? CurrentForm.GetValue("str_OBMinutes") : CurrentForm.GetValue("x_str_OBMinutes");
            if (!str_OBMinutes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_OBMinutes") && !CurrentForm.HasValue("x_str_OBMinutes")) // DN
                    str_OBMinutes.Visible = false; // Disable update for API request
                else
                    str_OBMinutes.SetFormValue(val);
            }

            // Check field name 'str_TotalOB_Mins' before field var 'x_str_TotalOB_Mins'
            val = CurrentForm.HasValue("str_TotalOB_Mins") ? CurrentForm.GetValue("str_TotalOB_Mins") : CurrentForm.GetValue("x_str_TotalOB_Mins");
            if (!str_TotalOB_Mins.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_TotalOB_Mins") && !CurrentForm.HasValue("x_str_TotalOB_Mins")) // DN
                    str_TotalOB_Mins.Visible = false; // Disable update for API request
                else
                    str_TotalOB_Mins.SetFormValue(val);
            }

            // Check field name 'LMSProductID' before field var 'x_LMSProductID'
            val = CurrentForm.HasValue("LMSProductID") ? CurrentForm.GetValue("LMSProductID") : CurrentForm.GetValue("x_LMSProductID");
            if (!LMSProductID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("LMSProductID") && !CurrentForm.HasValue("x_LMSProductID")) // DN
                    LMSProductID.Visible = false; // Disable update for API request
                else
                    LMSProductID.SetFormValue(val, true, validate);
            }

            // Check field name 'LMSNoOfAttempts' before field var 'x_LMSNoOfAttempts'
            val = CurrentForm.HasValue("LMSNoOfAttempts") ? CurrentForm.GetValue("LMSNoOfAttempts") : CurrentForm.GetValue("x_LMSNoOfAttempts");
            if (!LMSNoOfAttempts.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("LMSNoOfAttempts") && !CurrentForm.HasValue("x_LMSNoOfAttempts")) // DN
                    LMSNoOfAttempts.Visible = false; // Disable update for API request
                else
                    LMSNoOfAttempts.SetFormValue(val, true, validate);
            }

            // Check field name 'int_LMSLinkExpirationDays' before field var 'x_int_LMSLinkExpirationDays'
            val = CurrentForm.HasValue("int_LMSLinkExpirationDays") ? CurrentForm.GetValue("int_LMSLinkExpirationDays") : CurrentForm.GetValue("x_int_LMSLinkExpirationDays");
            if (!int_LMSLinkExpirationDays.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_LMSLinkExpirationDays") && !CurrentForm.HasValue("x_int_LMSLinkExpirationDays")) // DN
                    int_LMSLinkExpirationDays.Visible = false; // Disable update for API request
                else
                    int_LMSLinkExpirationDays.SetFormValue(val, true, validate);
            }

            // Check field name 'IGD_product_id' before field var 'x_IGD_product_id'
            val = CurrentForm.HasValue("IGD_product_id") ? CurrentForm.GetValue("IGD_product_id") : CurrentForm.GetValue("x_IGD_product_id");
            if (!IGD_product_id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IGD_product_id") && !CurrentForm.HasValue("x_IGD_product_id")) // DN
                    IGD_product_id.Visible = false; // Disable update for API request
                else
                    IGD_product_id.SetFormValue(val, true, validate);
            }

            // Check field name 'IEC_product_id' before field var 'x_IEC_product_id'
            val = CurrentForm.HasValue("IEC_product_id") ? CurrentForm.GetValue("IEC_product_id") : CurrentForm.GetValue("x_IEC_product_id");
            if (!IEC_product_id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IEC_product_id") && !CurrentForm.HasValue("x_IEC_product_id")) // DN
                    IEC_product_id.Visible = false; // Disable update for API request
                else
                    IEC_product_id.SetFormValue(val, true, validate);
            }

            // Check field name 'Somastream_Product_ID' before field var 'x_Somastream_Product_ID'
            val = CurrentForm.HasValue("Somastream_Product_ID") ? CurrentForm.GetValue("Somastream_Product_ID") : CurrentForm.GetValue("x_Somastream_Product_ID");
            if (!Somastream_Product_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Somastream_Product_ID") && !CurrentForm.HasValue("x_Somastream_Product_ID")) // DN
                    Somastream_Product_ID.Visible = false; // Disable update for API request
                else
                    Somastream_Product_ID.SetFormValue(val, true, validate);
            }

            // Check field name 'ProTREAD_Product_ID' before field var 'x_ProTREAD_Product_ID'
            val = CurrentForm.HasValue("ProTREAD_Product_ID") ? CurrentForm.GetValue("ProTREAD_Product_ID") : CurrentForm.GetValue("x_ProTREAD_Product_ID");
            if (!ProTREAD_Product_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("ProTREAD_Product_ID") && !CurrentForm.HasValue("x_ProTREAD_Product_ID")) // DN
                    ProTREAD_Product_ID.Visible = false; // Disable update for API request
                else
                    ProTREAD_Product_ID.SetFormValue(val, true, validate);
            }

            // Check field name 'ASD_product_id' before field var 'x_ASD_product_id'
            val = CurrentForm.HasValue("ASD_product_id") ? CurrentForm.GetValue("ASD_product_id") : CurrentForm.GetValue("x_ASD_product_id");
            if (!ASD_product_id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("ASD_product_id") && !CurrentForm.HasValue("x_ASD_product_id")) // DN
                    ASD_product_id.Visible = false; // Disable update for API request
                else
                    ASD_product_id.SetFormValue(val, true, validate);
            }

            // Check field name 'D2L_product_Id' before field var 'x_D2L_product_Id'
            val = CurrentForm.HasValue("D2L_product_Id") ? CurrentForm.GetValue("D2L_product_Id") : CurrentForm.GetValue("x_D2L_product_Id");
            if (!D2L_product_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("D2L_product_Id") && !CurrentForm.HasValue("x_D2L_product_Id")) // DN
                    D2L_product_Id.Visible = false; // Disable update for API request
                else
                    D2L_product_Id.SetFormValue(val, true, validate);
            }

            // Check field name 'int_Course_Duration' before field var 'x_int_Course_Duration'
            val = CurrentForm.HasValue("int_Course_Duration") ? CurrentForm.GetValue("int_Course_Duration") : CurrentForm.GetValue("x_int_Course_Duration");
            if (!int_Course_Duration.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Course_Duration") && !CurrentForm.HasValue("x_int_Course_Duration")) // DN
                    int_Course_Duration.Visible = false; // Disable update for API request
                else
                    int_Course_Duration.SetFormValue(val, true, validate);
            }

            // Check field name 'Moodle_product_Id' before field var 'x_Moodle_product_Id'
            val = CurrentForm.HasValue("Moodle_product_Id") ? CurrentForm.GetValue("Moodle_product_Id") : CurrentForm.GetValue("x_Moodle_product_Id");
            if (!Moodle_product_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Moodle_product_Id") && !CurrentForm.HasValue("x_Moodle_product_Id")) // DN
                    Moodle_product_Id.Visible = false; // Disable update for API request
                else
                    Moodle_product_Id.SetFormValue(val, true, validate);
            }
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Product_Id.CurrentValue = int_Product_Id.FormValue;
            str_Product_Name.CurrentValue = str_Product_Name.FormValue;
            str_Item_Code.CurrentValue = str_Item_Code.FormValue;
            mny_Price.CurrentValue = mny_Price.FormValue;
            bit_IsTaxable.CurrentValue = bit_IsTaxable.FormValue;
            str_Web_Description.CurrentValue = str_Web_Description.FormValue;
            dec_StateTax.CurrentValue = dec_StateTax.FormValue;
            dec_AddTax.CurrentValue = dec_AddTax.FormValue;
            mny_TotalPrice.CurrentValue = mny_TotalPrice.FormValue;
            int_Product_Type.CurrentValue = int_Product_Type.FormValue;
            int_Product_Sub_Type.CurrentValue = int_Product_Sub_Type.FormValue;
            int_Status.CurrentValue = int_Status.FormValue;
            bit_Is_Web_Purchase.CurrentValue = bit_Is_Web_Purchase.FormValue;
            str_BTW_Hours.CurrentValue = str_BTW_Hours.FormValue;
            str_Hour.CurrentValue = str_Hour.FormValue;
            Str_Minutes.CurrentValue = Str_Minutes.FormValue;
            str_Appointment_Duration.CurrentValue = str_Appointment_Duration.FormValue;
            str_Notes.CurrentValue = str_Notes.FormValue;
            int_Created_By.CurrentValue = int_Created_By.FormValue;
            int_Modified_By.CurrentValue = int_Modified_By.FormValue;
            date_Created.CurrentValue = date_Created.FormValue;
            date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            date_Modified.CurrentValue = date_Modified.FormValue;
            date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            bit_IsDeleted.CurrentValue = bit_IsDeleted.FormValue;
            int_Dollar.CurrentValue = int_Dollar.FormValue;
            bit_PortalPurchase.CurrentValue = bit_PortalPurchase.FormValue;
            str_WebName.CurrentValue = str_WebName.FormValue;
            bit_ExtraChk1.CurrentValue = bit_ExtraChk1.FormValue;
            bit_ExtraChk2.CurrentValue = bit_ExtraChk2.FormValue;
            str_ExtraDrpDown1.CurrentValue = str_ExtraDrpDown1.FormValue;
            str_ExtraDrpDown2.CurrentValue = str_ExtraDrpDown2.FormValue;
            str_Extratxt1.CurrentValue = str_Extratxt1.FormValue;
            str_Extratxt2.CurrentValue = str_Extratxt2.FormValue;
            str_OBHours.CurrentValue = str_OBHours.FormValue;
            str_OBMinutes.CurrentValue = str_OBMinutes.FormValue;
            str_TotalOB_Mins.CurrentValue = str_TotalOB_Mins.FormValue;
            LMSProductID.CurrentValue = LMSProductID.FormValue;
            LMSNoOfAttempts.CurrentValue = LMSNoOfAttempts.FormValue;
            int_LMSLinkExpirationDays.CurrentValue = int_LMSLinkExpirationDays.FormValue;
            IGD_product_id.CurrentValue = IGD_product_id.FormValue;
            IEC_product_id.CurrentValue = IEC_product_id.FormValue;
            Somastream_Product_ID.CurrentValue = Somastream_Product_ID.FormValue;
            ProTREAD_Product_ID.CurrentValue = ProTREAD_Product_ID.FormValue;
            ASD_product_id.CurrentValue = ASD_product_id.FormValue;
            D2L_product_Id.CurrentValue = D2L_product_Id.FormValue;
            int_Course_Duration.CurrentValue = int_Course_Duration.FormValue;
            Moodle_product_Id.CurrentValue = Moodle_product_Id.FormValue;
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
            int_Product_Id.SetDbValue(row["int_Product_Id"]);
            str_Product_Name.SetDbValue(row["str_Product_Name"]);
            str_Item_Code.SetDbValue(row["str_Item_Code"]);
            mny_Price.SetDbValue(row["mny_Price"]);
            bit_IsTaxable.SetDbValue((ConvertToBool(row["bit_IsTaxable"]) ? "1" : "0"));
            str_Web_Description.SetDbValue(row["str_Web_Description"]);
            dec_StateTax.SetDbValue(row["dec_StateTax"]);
            dec_AddTax.SetDbValue(IsNull(row["dec_AddTax"]) ? DbNullValue : ConvertToDouble(row["dec_AddTax"]));
            mny_TotalPrice.SetDbValue(row["mny_TotalPrice"]);
            int_Product_Type.SetDbValue(row["int_Product_Type"]);
            int_Product_Sub_Type.SetDbValue(row["int_Product_Sub_Type"]);
            int_Status.SetDbValue(row["int_Status"]);
            bit_Is_Web_Purchase.SetDbValue((ConvertToBool(row["bit_Is_Web_Purchase"]) ? "1" : "0"));
            str_BTW_Hours.SetDbValue(row["str_BTW_Hours"]);
            str_Hour.SetDbValue(row["str_Hour"]);
            Str_Minutes.SetDbValue(row["Str_Minutes"]);
            str_Appointment_Duration.SetDbValue(row["str_Appointment_Duration"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            int_Dollar.SetDbValue(row["int_Dollar"]);
            bit_PortalPurchase.SetDbValue((ConvertToBool(row["bit_PortalPurchase"]) ? "1" : "0"));
            str_WebName.SetDbValue(row["str_WebName"]);
            bit_ExtraChk1.SetDbValue((ConvertToBool(row["bit_ExtraChk1"]) ? "1" : "0"));
            bit_ExtraChk2.SetDbValue((ConvertToBool(row["bit_ExtraChk2"]) ? "1" : "0"));
            str_ExtraDrpDown1.SetDbValue(row["str_ExtraDrpDown1"]);
            str_ExtraDrpDown2.SetDbValue(row["str_ExtraDrpDown2"]);
            str_Extratxt1.SetDbValue(row["str_Extratxt1"]);
            str_Extratxt2.SetDbValue(row["str_Extratxt2"]);
            str_OBHours.SetDbValue(row["str_OBHours"]);
            str_OBMinutes.SetDbValue(row["str_OBMinutes"]);
            str_TotalOB_Mins.SetDbValue(row["str_TotalOB_Mins"]);
            LMSProductID.SetDbValue(row["LMSProductID"]);
            LMSNoOfAttempts.SetDbValue(row["LMSNoOfAttempts"]);
            int_LMSLinkExpirationDays.SetDbValue(row["int_LMSLinkExpirationDays"]);
            IGD_product_id.SetDbValue(row["IGD_product_id"]);
            IEC_product_id.SetDbValue(row["IEC_product_id"]);
            Somastream_Product_ID.SetDbValue(row["Somastream_Product_ID"]);
            ProTREAD_Product_ID.SetDbValue(row["ProTREAD_Product_ID"]);
            ASD_product_id.SetDbValue(row["ASD_product_id"]);
            D2L_product_Id.SetDbValue(row["D2L_product_Id"]);
            int_Course_Duration.SetDbValue(row["int_Course_Duration"]);
            Moodle_product_Id.SetDbValue(row["Moodle_product_Id"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Product_Id", int_Product_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Product_Name", str_Product_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Item_Code", str_Item_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Price", mny_Price.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsTaxable", bit_IsTaxable.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Web_Description", str_Web_Description.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_StateTax", dec_StateTax.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_AddTax", dec_AddTax.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_TotalPrice", mny_TotalPrice.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Product_Type", int_Product_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Product_Sub_Type", int_Product_Sub_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Is_Web_Purchase", bit_Is_Web_Purchase.DefaultValue ?? DbNullValue); // DN
            row.Add("str_BTW_Hours", str_BTW_Hours.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Hour", str_Hour.DefaultValue ?? DbNullValue); // DN
            row.Add("Str_Minutes", Str_Minutes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Appointment_Duration", str_Appointment_Duration.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Dollar", int_Dollar.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_PortalPurchase", bit_PortalPurchase.DefaultValue ?? DbNullValue); // DN
            row.Add("str_WebName", str_WebName.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_ExtraChk1", bit_ExtraChk1.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_ExtraChk2", bit_ExtraChk2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ExtraDrpDown1", str_ExtraDrpDown1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ExtraDrpDown2", str_ExtraDrpDown2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Extratxt1", str_Extratxt1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Extratxt2", str_Extratxt2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OBHours", str_OBHours.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OBMinutes", str_OBMinutes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_TotalOB_Mins", str_TotalOB_Mins.DefaultValue ?? DbNullValue); // DN
            row.Add("LMSProductID", LMSProductID.DefaultValue ?? DbNullValue); // DN
            row.Add("LMSNoOfAttempts", LMSNoOfAttempts.DefaultValue ?? DbNullValue); // DN
            row.Add("int_LMSLinkExpirationDays", int_LMSLinkExpirationDays.DefaultValue ?? DbNullValue); // DN
            row.Add("IGD_product_id", IGD_product_id.DefaultValue ?? DbNullValue); // DN
            row.Add("IEC_product_id", IEC_product_id.DefaultValue ?? DbNullValue); // DN
            row.Add("Somastream_Product_ID", Somastream_Product_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("ProTREAD_Product_ID", ProTREAD_Product_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("ASD_product_id", ASD_product_id.DefaultValue ?? DbNullValue); // DN
            row.Add("D2L_product_Id", D2L_product_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Course_Duration", int_Course_Duration.DefaultValue ?? DbNullValue); // DN
            row.Add("Moodle_product_Id", Moodle_product_Id.DefaultValue ?? DbNullValue); // DN
            return row;
        }

        #pragma warning disable 618, 1998
        // Load old record
        protected async Task<Dictionary<string, object>?> LoadOldRecord(DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType>? cnn = null) {
            await LoadRowValues(); // Load default row values
            return null;
        }
        #pragma warning restore 618, 1998

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_Product_Id
            int_Product_Id.RowCssClass = "row";

            // str_Product_Name
            str_Product_Name.RowCssClass = "row";

            // str_Item_Code
            str_Item_Code.RowCssClass = "row";

            // mny_Price
            mny_Price.RowCssClass = "row";

            // bit_IsTaxable
            bit_IsTaxable.RowCssClass = "row";

            // str_Web_Description
            str_Web_Description.RowCssClass = "row";

            // dec_StateTax
            dec_StateTax.RowCssClass = "row";

            // dec_AddTax
            dec_AddTax.RowCssClass = "row";

            // mny_TotalPrice
            mny_TotalPrice.RowCssClass = "row";

            // int_Product_Type
            int_Product_Type.RowCssClass = "row";

            // int_Product_Sub_Type
            int_Product_Sub_Type.RowCssClass = "row";

            // int_Status
            int_Status.RowCssClass = "row";

            // bit_Is_Web_Purchase
            bit_Is_Web_Purchase.RowCssClass = "row";

            // str_BTW_Hours
            str_BTW_Hours.RowCssClass = "row";

            // str_Hour
            str_Hour.RowCssClass = "row";

            // Str_Minutes
            Str_Minutes.RowCssClass = "row";

            // str_Appointment_Duration
            str_Appointment_Duration.RowCssClass = "row";

            // str_Notes
            str_Notes.RowCssClass = "row";

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

            // int_Dollar
            int_Dollar.RowCssClass = "row";

            // bit_PortalPurchase
            bit_PortalPurchase.RowCssClass = "row";

            // str_WebName
            str_WebName.RowCssClass = "row";

            // bit_ExtraChk1
            bit_ExtraChk1.RowCssClass = "row";

            // bit_ExtraChk2
            bit_ExtraChk2.RowCssClass = "row";

            // str_ExtraDrpDown1
            str_ExtraDrpDown1.RowCssClass = "row";

            // str_ExtraDrpDown2
            str_ExtraDrpDown2.RowCssClass = "row";

            // str_Extratxt1
            str_Extratxt1.RowCssClass = "row";

            // str_Extratxt2
            str_Extratxt2.RowCssClass = "row";

            // str_OBHours
            str_OBHours.RowCssClass = "row";

            // str_OBMinutes
            str_OBMinutes.RowCssClass = "row";

            // str_TotalOB_Mins
            str_TotalOB_Mins.RowCssClass = "row";

            // LMSProductID
            LMSProductID.RowCssClass = "row";

            // LMSNoOfAttempts
            LMSNoOfAttempts.RowCssClass = "row";

            // int_LMSLinkExpirationDays
            int_LMSLinkExpirationDays.RowCssClass = "row";

            // IGD_product_id
            IGD_product_id.RowCssClass = "row";

            // IEC_product_id
            IEC_product_id.RowCssClass = "row";

            // Somastream_Product_ID
            Somastream_Product_ID.RowCssClass = "row";

            // ProTREAD_Product_ID
            ProTREAD_Product_ID.RowCssClass = "row";

            // ASD_product_id
            ASD_product_id.RowCssClass = "row";

            // D2L_product_Id
            D2L_product_Id.RowCssClass = "row";

            // int_Course_Duration
            int_Course_Duration.RowCssClass = "row";

            // Moodle_product_Id
            Moodle_product_Id.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // int_Product_Id
                int_Product_Id.ViewValue = int_Product_Id.CurrentValue;
                int_Product_Id.ViewValue = FormatNumber(int_Product_Id.ViewValue, int_Product_Id.FormatPattern);
                int_Product_Id.ViewCustomAttributes = "";

                // str_Product_Name
                str_Product_Name.ViewValue = ConvertToString(str_Product_Name.CurrentValue); // DN
                str_Product_Name.ViewCustomAttributes = "";

                // str_Item_Code
                str_Item_Code.ViewValue = ConvertToString(str_Item_Code.CurrentValue); // DN
                str_Item_Code.ViewCustomAttributes = "";

                // mny_Price
                mny_Price.ViewValue = mny_Price.CurrentValue;
                mny_Price.ViewValue = FormatNumber(mny_Price.ViewValue, mny_Price.FormatPattern);
                mny_Price.ViewCustomAttributes = "";

                // bit_IsTaxable
                if (ConvertToBool(bit_IsTaxable.CurrentValue)) {
                    bit_IsTaxable.ViewValue = bit_IsTaxable.TagCaption(1) != "" ? bit_IsTaxable.TagCaption(1) : "Yes";
                } else {
                    bit_IsTaxable.ViewValue = bit_IsTaxable.TagCaption(2) != "" ? bit_IsTaxable.TagCaption(2) : "No";
                }
                bit_IsTaxable.ViewCustomAttributes = "";

                // str_Web_Description
                str_Web_Description.ViewValue = ConvertToString(str_Web_Description.CurrentValue); // DN
                str_Web_Description.ViewCustomAttributes = "";

                // dec_StateTax
                dec_StateTax.ViewValue = dec_StateTax.CurrentValue;
                dec_StateTax.ViewValue = FormatNumber(dec_StateTax.ViewValue, dec_StateTax.FormatPattern);
                dec_StateTax.ViewCustomAttributes = "";

                // dec_AddTax
                dec_AddTax.ViewValue = dec_AddTax.CurrentValue;
                dec_AddTax.ViewValue = FormatNumber(dec_AddTax.ViewValue, dec_AddTax.FormatPattern);
                dec_AddTax.ViewCustomAttributes = "";

                // mny_TotalPrice
                mny_TotalPrice.ViewValue = mny_TotalPrice.CurrentValue;
                mny_TotalPrice.ViewValue = FormatNumber(mny_TotalPrice.ViewValue, mny_TotalPrice.FormatPattern);
                mny_TotalPrice.ViewCustomAttributes = "";

                // int_Product_Type
                int_Product_Type.ViewValue = int_Product_Type.CurrentValue;
                int_Product_Type.ViewValue = FormatNumber(int_Product_Type.ViewValue, int_Product_Type.FormatPattern);
                int_Product_Type.ViewCustomAttributes = "";

                // int_Product_Sub_Type
                int_Product_Sub_Type.ViewValue = int_Product_Sub_Type.CurrentValue;
                int_Product_Sub_Type.ViewValue = FormatNumber(int_Product_Sub_Type.ViewValue, int_Product_Sub_Type.FormatPattern);
                int_Product_Sub_Type.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // bit_Is_Web_Purchase
                if (ConvertToBool(bit_Is_Web_Purchase.CurrentValue)) {
                    bit_Is_Web_Purchase.ViewValue = bit_Is_Web_Purchase.TagCaption(1) != "" ? bit_Is_Web_Purchase.TagCaption(1) : "Yes";
                } else {
                    bit_Is_Web_Purchase.ViewValue = bit_Is_Web_Purchase.TagCaption(2) != "" ? bit_Is_Web_Purchase.TagCaption(2) : "No";
                }
                bit_Is_Web_Purchase.ViewCustomAttributes = "";

                // str_BTW_Hours
                str_BTW_Hours.ViewValue = ConvertToString(str_BTW_Hours.CurrentValue); // DN
                str_BTW_Hours.ViewCustomAttributes = "";

                // str_Hour
                str_Hour.ViewValue = ConvertToString(str_Hour.CurrentValue); // DN
                str_Hour.ViewCustomAttributes = "";

                // Str_Minutes
                Str_Minutes.ViewValue = ConvertToString(Str_Minutes.CurrentValue); // DN
                Str_Minutes.ViewCustomAttributes = "";

                // str_Appointment_Duration
                str_Appointment_Duration.ViewValue = ConvertToString(str_Appointment_Duration.CurrentValue); // DN
                str_Appointment_Duration.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

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

                // int_Dollar
                int_Dollar.ViewValue = int_Dollar.CurrentValue;
                int_Dollar.ViewValue = FormatNumber(int_Dollar.ViewValue, int_Dollar.FormatPattern);
                int_Dollar.ViewCustomAttributes = "";

                // bit_PortalPurchase
                if (ConvertToBool(bit_PortalPurchase.CurrentValue)) {
                    bit_PortalPurchase.ViewValue = bit_PortalPurchase.TagCaption(1) != "" ? bit_PortalPurchase.TagCaption(1) : "Yes";
                } else {
                    bit_PortalPurchase.ViewValue = bit_PortalPurchase.TagCaption(2) != "" ? bit_PortalPurchase.TagCaption(2) : "No";
                }
                bit_PortalPurchase.ViewCustomAttributes = "";

                // str_WebName
                str_WebName.ViewValue = ConvertToString(str_WebName.CurrentValue); // DN
                str_WebName.ViewCustomAttributes = "";

                // bit_ExtraChk1
                if (ConvertToBool(bit_ExtraChk1.CurrentValue)) {
                    bit_ExtraChk1.ViewValue = bit_ExtraChk1.TagCaption(1) != "" ? bit_ExtraChk1.TagCaption(1) : "Yes";
                } else {
                    bit_ExtraChk1.ViewValue = bit_ExtraChk1.TagCaption(2) != "" ? bit_ExtraChk1.TagCaption(2) : "No";
                }
                bit_ExtraChk1.ViewCustomAttributes = "";

                // bit_ExtraChk2
                if (ConvertToBool(bit_ExtraChk2.CurrentValue)) {
                    bit_ExtraChk2.ViewValue = bit_ExtraChk2.TagCaption(1) != "" ? bit_ExtraChk2.TagCaption(1) : "Yes";
                } else {
                    bit_ExtraChk2.ViewValue = bit_ExtraChk2.TagCaption(2) != "" ? bit_ExtraChk2.TagCaption(2) : "No";
                }
                bit_ExtraChk2.ViewCustomAttributes = "";

                // str_ExtraDrpDown1
                str_ExtraDrpDown1.ViewValue = ConvertToString(str_ExtraDrpDown1.CurrentValue); // DN
                str_ExtraDrpDown1.ViewCustomAttributes = "";

                // str_ExtraDrpDown2
                str_ExtraDrpDown2.ViewValue = ConvertToString(str_ExtraDrpDown2.CurrentValue); // DN
                str_ExtraDrpDown2.ViewCustomAttributes = "";

                // str_Extratxt1
                str_Extratxt1.ViewValue = ConvertToString(str_Extratxt1.CurrentValue); // DN
                str_Extratxt1.ViewCustomAttributes = "";

                // str_Extratxt2
                str_Extratxt2.ViewValue = ConvertToString(str_Extratxt2.CurrentValue); // DN
                str_Extratxt2.ViewCustomAttributes = "";

                // str_OBHours
                str_OBHours.ViewValue = ConvertToString(str_OBHours.CurrentValue); // DN
                str_OBHours.ViewCustomAttributes = "";

                // str_OBMinutes
                str_OBMinutes.ViewValue = ConvertToString(str_OBMinutes.CurrentValue); // DN
                str_OBMinutes.ViewCustomAttributes = "";

                // str_TotalOB_Mins
                str_TotalOB_Mins.ViewValue = ConvertToString(str_TotalOB_Mins.CurrentValue); // DN
                str_TotalOB_Mins.ViewCustomAttributes = "";

                // LMSProductID
                LMSProductID.ViewValue = LMSProductID.CurrentValue;
                LMSProductID.ViewValue = FormatNumber(LMSProductID.ViewValue, LMSProductID.FormatPattern);
                LMSProductID.ViewCustomAttributes = "";

                // LMSNoOfAttempts
                LMSNoOfAttempts.ViewValue = LMSNoOfAttempts.CurrentValue;
                LMSNoOfAttempts.ViewValue = FormatNumber(LMSNoOfAttempts.ViewValue, LMSNoOfAttempts.FormatPattern);
                LMSNoOfAttempts.ViewCustomAttributes = "";

                // int_LMSLinkExpirationDays
                int_LMSLinkExpirationDays.ViewValue = int_LMSLinkExpirationDays.CurrentValue;
                int_LMSLinkExpirationDays.ViewValue = FormatNumber(int_LMSLinkExpirationDays.ViewValue, int_LMSLinkExpirationDays.FormatPattern);
                int_LMSLinkExpirationDays.ViewCustomAttributes = "";

                // IGD_product_id
                IGD_product_id.ViewValue = IGD_product_id.CurrentValue;
                IGD_product_id.ViewValue = FormatNumber(IGD_product_id.ViewValue, IGD_product_id.FormatPattern);
                IGD_product_id.ViewCustomAttributes = "";

                // IEC_product_id
                IEC_product_id.ViewValue = IEC_product_id.CurrentValue;
                IEC_product_id.ViewValue = FormatNumber(IEC_product_id.ViewValue, IEC_product_id.FormatPattern);
                IEC_product_id.ViewCustomAttributes = "";

                // Somastream_Product_ID
                Somastream_Product_ID.ViewValue = Somastream_Product_ID.CurrentValue;
                Somastream_Product_ID.ViewValue = FormatNumber(Somastream_Product_ID.ViewValue, Somastream_Product_ID.FormatPattern);
                Somastream_Product_ID.ViewCustomAttributes = "";

                // ProTREAD_Product_ID
                ProTREAD_Product_ID.ViewValue = ProTREAD_Product_ID.CurrentValue;
                ProTREAD_Product_ID.ViewValue = FormatNumber(ProTREAD_Product_ID.ViewValue, ProTREAD_Product_ID.FormatPattern);
                ProTREAD_Product_ID.ViewCustomAttributes = "";

                // ASD_product_id
                ASD_product_id.ViewValue = ASD_product_id.CurrentValue;
                ASD_product_id.ViewValue = FormatNumber(ASD_product_id.ViewValue, ASD_product_id.FormatPattern);
                ASD_product_id.ViewCustomAttributes = "";

                // D2L_product_Id
                D2L_product_Id.ViewValue = D2L_product_Id.CurrentValue;
                D2L_product_Id.ViewValue = FormatNumber(D2L_product_Id.ViewValue, D2L_product_Id.FormatPattern);
                D2L_product_Id.ViewCustomAttributes = "";

                // int_Course_Duration
                int_Course_Duration.ViewValue = int_Course_Duration.CurrentValue;
                int_Course_Duration.ViewValue = FormatNumber(int_Course_Duration.ViewValue, int_Course_Duration.FormatPattern);
                int_Course_Duration.ViewCustomAttributes = "";

                // Moodle_product_Id
                Moodle_product_Id.ViewValue = Moodle_product_Id.CurrentValue;
                Moodle_product_Id.ViewValue = FormatNumber(Moodle_product_Id.ViewValue, Moodle_product_Id.FormatPattern);
                Moodle_product_Id.ViewCustomAttributes = "";

                // int_Product_Id
                int_Product_Id.HrefValue = "";

                // str_Product_Name
                str_Product_Name.HrefValue = "";

                // str_Item_Code
                str_Item_Code.HrefValue = "";

                // mny_Price
                mny_Price.HrefValue = "";

                // bit_IsTaxable
                bit_IsTaxable.HrefValue = "";

                // str_Web_Description
                str_Web_Description.HrefValue = "";

                // dec_StateTax
                dec_StateTax.HrefValue = "";

                // dec_AddTax
                dec_AddTax.HrefValue = "";

                // mny_TotalPrice
                mny_TotalPrice.HrefValue = "";

                // int_Product_Type
                int_Product_Type.HrefValue = "";

                // int_Product_Sub_Type
                int_Product_Sub_Type.HrefValue = "";

                // int_Status
                int_Status.HrefValue = "";

                // bit_Is_Web_Purchase
                bit_Is_Web_Purchase.HrefValue = "";

                // str_BTW_Hours
                str_BTW_Hours.HrefValue = "";

                // str_Hour
                str_Hour.HrefValue = "";

                // Str_Minutes
                Str_Minutes.HrefValue = "";

                // str_Appointment_Duration
                str_Appointment_Duration.HrefValue = "";

                // str_Notes
                str_Notes.HrefValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";

                // date_Created
                date_Created.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";

                // int_Dollar
                int_Dollar.HrefValue = "";

                // bit_PortalPurchase
                bit_PortalPurchase.HrefValue = "";

                // str_WebName
                str_WebName.HrefValue = "";

                // bit_ExtraChk1
                bit_ExtraChk1.HrefValue = "";

                // bit_ExtraChk2
                bit_ExtraChk2.HrefValue = "";

                // str_ExtraDrpDown1
                str_ExtraDrpDown1.HrefValue = "";

                // str_ExtraDrpDown2
                str_ExtraDrpDown2.HrefValue = "";

                // str_Extratxt1
                str_Extratxt1.HrefValue = "";

                // str_Extratxt2
                str_Extratxt2.HrefValue = "";

                // str_OBHours
                str_OBHours.HrefValue = "";

                // str_OBMinutes
                str_OBMinutes.HrefValue = "";

                // str_TotalOB_Mins
                str_TotalOB_Mins.HrefValue = "";

                // LMSProductID
                LMSProductID.HrefValue = "";

                // LMSNoOfAttempts
                LMSNoOfAttempts.HrefValue = "";

                // int_LMSLinkExpirationDays
                int_LMSLinkExpirationDays.HrefValue = "";

                // IGD_product_id
                IGD_product_id.HrefValue = "";

                // IEC_product_id
                IEC_product_id.HrefValue = "";

                // Somastream_Product_ID
                Somastream_Product_ID.HrefValue = "";

                // ProTREAD_Product_ID
                ProTREAD_Product_ID.HrefValue = "";

                // ASD_product_id
                ASD_product_id.HrefValue = "";

                // D2L_product_Id
                D2L_product_Id.HrefValue = "";

                // int_Course_Duration
                int_Course_Duration.HrefValue = "";

                // Moodle_product_Id
                Moodle_product_Id.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // int_Product_Id
                int_Product_Id.SetupEditAttributes();
                int_Product_Id.EditValue = int_Product_Id.CurrentValue; // DN
                int_Product_Id.PlaceHolder = RemoveHtml(int_Product_Id.Caption);
                if (!Empty(int_Product_Id.EditValue) && IsNumeric(int_Product_Id.EditValue))
                    int_Product_Id.EditValue = FormatNumber(int_Product_Id.EditValue, null);

                // str_Product_Name
                str_Product_Name.SetupEditAttributes();
                if (!str_Product_Name.Raw)
                    str_Product_Name.CurrentValue = HtmlDecode(str_Product_Name.CurrentValue);
                str_Product_Name.EditValue = HtmlEncode(str_Product_Name.CurrentValue);
                str_Product_Name.PlaceHolder = RemoveHtml(str_Product_Name.Caption);

                // str_Item_Code
                str_Item_Code.SetupEditAttributes();
                if (!str_Item_Code.Raw)
                    str_Item_Code.CurrentValue = HtmlDecode(str_Item_Code.CurrentValue);
                str_Item_Code.EditValue = HtmlEncode(str_Item_Code.CurrentValue);
                str_Item_Code.PlaceHolder = RemoveHtml(str_Item_Code.Caption);

                // mny_Price
                mny_Price.SetupEditAttributes();
                mny_Price.EditValue = mny_Price.CurrentValue; // DN
                mny_Price.PlaceHolder = RemoveHtml(mny_Price.Caption);
                if (!Empty(mny_Price.EditValue) && IsNumeric(mny_Price.EditValue))
                    mny_Price.EditValue = FormatNumber(mny_Price.EditValue, null);

                // bit_IsTaxable
                bit_IsTaxable.EditValue = bit_IsTaxable.Options(false);
                bit_IsTaxable.PlaceHolder = RemoveHtml(bit_IsTaxable.Caption);

                // str_Web_Description
                str_Web_Description.SetupEditAttributes();
                if (!str_Web_Description.Raw)
                    str_Web_Description.CurrentValue = HtmlDecode(str_Web_Description.CurrentValue);
                str_Web_Description.EditValue = HtmlEncode(str_Web_Description.CurrentValue);
                str_Web_Description.PlaceHolder = RemoveHtml(str_Web_Description.Caption);

                // dec_StateTax
                dec_StateTax.SetupEditAttributes();
                dec_StateTax.EditValue = dec_StateTax.CurrentValue; // DN
                dec_StateTax.PlaceHolder = RemoveHtml(dec_StateTax.Caption);
                if (!Empty(dec_StateTax.EditValue) && IsNumeric(dec_StateTax.EditValue))
                    dec_StateTax.EditValue = FormatNumber(dec_StateTax.EditValue, null);

                // dec_AddTax
                dec_AddTax.SetupEditAttributes();
                dec_AddTax.EditValue = dec_AddTax.CurrentValue; // DN
                dec_AddTax.PlaceHolder = RemoveHtml(dec_AddTax.Caption);
                if (!Empty(dec_AddTax.EditValue) && IsNumeric(dec_AddTax.EditValue))
                    dec_AddTax.EditValue = FormatNumber(dec_AddTax.EditValue, null);

                // mny_TotalPrice
                mny_TotalPrice.SetupEditAttributes();
                mny_TotalPrice.EditValue = mny_TotalPrice.CurrentValue; // DN
                mny_TotalPrice.PlaceHolder = RemoveHtml(mny_TotalPrice.Caption);
                if (!Empty(mny_TotalPrice.EditValue) && IsNumeric(mny_TotalPrice.EditValue))
                    mny_TotalPrice.EditValue = FormatNumber(mny_TotalPrice.EditValue, null);

                // int_Product_Type
                int_Product_Type.SetupEditAttributes();
                int_Product_Type.EditValue = int_Product_Type.CurrentValue; // DN
                int_Product_Type.PlaceHolder = RemoveHtml(int_Product_Type.Caption);
                if (!Empty(int_Product_Type.EditValue) && IsNumeric(int_Product_Type.EditValue))
                    int_Product_Type.EditValue = FormatNumber(int_Product_Type.EditValue, null);

                // int_Product_Sub_Type
                int_Product_Sub_Type.SetupEditAttributes();
                int_Product_Sub_Type.EditValue = int_Product_Sub_Type.CurrentValue; // DN
                int_Product_Sub_Type.PlaceHolder = RemoveHtml(int_Product_Sub_Type.Caption);
                if (!Empty(int_Product_Sub_Type.EditValue) && IsNumeric(int_Product_Sub_Type.EditValue))
                    int_Product_Sub_Type.EditValue = FormatNumber(int_Product_Sub_Type.EditValue, null);

                // int_Status
                int_Status.SetupEditAttributes();
                int_Status.EditValue = int_Status.CurrentValue; // DN
                int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
                if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                    int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

                // bit_Is_Web_Purchase
                bit_Is_Web_Purchase.EditValue = bit_Is_Web_Purchase.Options(false);
                bit_Is_Web_Purchase.PlaceHolder = RemoveHtml(bit_Is_Web_Purchase.Caption);

                // str_BTW_Hours
                str_BTW_Hours.SetupEditAttributes();
                if (!str_BTW_Hours.Raw)
                    str_BTW_Hours.CurrentValue = HtmlDecode(str_BTW_Hours.CurrentValue);
                str_BTW_Hours.EditValue = HtmlEncode(str_BTW_Hours.CurrentValue);
                str_BTW_Hours.PlaceHolder = RemoveHtml(str_BTW_Hours.Caption);

                // str_Hour
                str_Hour.SetupEditAttributes();
                if (!str_Hour.Raw)
                    str_Hour.CurrentValue = HtmlDecode(str_Hour.CurrentValue);
                str_Hour.EditValue = HtmlEncode(str_Hour.CurrentValue);
                str_Hour.PlaceHolder = RemoveHtml(str_Hour.Caption);

                // Str_Minutes
                Str_Minutes.SetupEditAttributes();
                if (!Str_Minutes.Raw)
                    Str_Minutes.CurrentValue = HtmlDecode(Str_Minutes.CurrentValue);
                Str_Minutes.EditValue = HtmlEncode(Str_Minutes.CurrentValue);
                Str_Minutes.PlaceHolder = RemoveHtml(Str_Minutes.Caption);

                // str_Appointment_Duration
                str_Appointment_Duration.SetupEditAttributes();
                if (!str_Appointment_Duration.Raw)
                    str_Appointment_Duration.CurrentValue = HtmlDecode(str_Appointment_Duration.CurrentValue);
                str_Appointment_Duration.EditValue = HtmlEncode(str_Appointment_Duration.CurrentValue);
                str_Appointment_Duration.PlaceHolder = RemoveHtml(str_Appointment_Duration.Caption);

                // str_Notes
                str_Notes.SetupEditAttributes();
                if (!str_Notes.Raw)
                    str_Notes.CurrentValue = HtmlDecode(str_Notes.CurrentValue);
                str_Notes.EditValue = HtmlEncode(str_Notes.CurrentValue);
                str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

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

                // bit_IsDeleted
                bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
                bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

                // int_Dollar
                int_Dollar.SetupEditAttributes();
                int_Dollar.EditValue = int_Dollar.CurrentValue; // DN
                int_Dollar.PlaceHolder = RemoveHtml(int_Dollar.Caption);
                if (!Empty(int_Dollar.EditValue) && IsNumeric(int_Dollar.EditValue))
                    int_Dollar.EditValue = FormatNumber(int_Dollar.EditValue, null);

                // bit_PortalPurchase
                bit_PortalPurchase.EditValue = bit_PortalPurchase.Options(false);
                bit_PortalPurchase.PlaceHolder = RemoveHtml(bit_PortalPurchase.Caption);

                // str_WebName
                str_WebName.SetupEditAttributes();
                if (!str_WebName.Raw)
                    str_WebName.CurrentValue = HtmlDecode(str_WebName.CurrentValue);
                str_WebName.EditValue = HtmlEncode(str_WebName.CurrentValue);
                str_WebName.PlaceHolder = RemoveHtml(str_WebName.Caption);

                // bit_ExtraChk1
                bit_ExtraChk1.EditValue = bit_ExtraChk1.Options(false);
                bit_ExtraChk1.PlaceHolder = RemoveHtml(bit_ExtraChk1.Caption);

                // bit_ExtraChk2
                bit_ExtraChk2.EditValue = bit_ExtraChk2.Options(false);
                bit_ExtraChk2.PlaceHolder = RemoveHtml(bit_ExtraChk2.Caption);

                // str_ExtraDrpDown1
                str_ExtraDrpDown1.SetupEditAttributes();
                if (!str_ExtraDrpDown1.Raw)
                    str_ExtraDrpDown1.CurrentValue = HtmlDecode(str_ExtraDrpDown1.CurrentValue);
                str_ExtraDrpDown1.EditValue = HtmlEncode(str_ExtraDrpDown1.CurrentValue);
                str_ExtraDrpDown1.PlaceHolder = RemoveHtml(str_ExtraDrpDown1.Caption);

                // str_ExtraDrpDown2
                str_ExtraDrpDown2.SetupEditAttributes();
                if (!str_ExtraDrpDown2.Raw)
                    str_ExtraDrpDown2.CurrentValue = HtmlDecode(str_ExtraDrpDown2.CurrentValue);
                str_ExtraDrpDown2.EditValue = HtmlEncode(str_ExtraDrpDown2.CurrentValue);
                str_ExtraDrpDown2.PlaceHolder = RemoveHtml(str_ExtraDrpDown2.Caption);

                // str_Extratxt1
                str_Extratxt1.SetupEditAttributes();
                if (!str_Extratxt1.Raw)
                    str_Extratxt1.CurrentValue = HtmlDecode(str_Extratxt1.CurrentValue);
                str_Extratxt1.EditValue = HtmlEncode(str_Extratxt1.CurrentValue);
                str_Extratxt1.PlaceHolder = RemoveHtml(str_Extratxt1.Caption);

                // str_Extratxt2
                str_Extratxt2.SetupEditAttributes();
                if (!str_Extratxt2.Raw)
                    str_Extratxt2.CurrentValue = HtmlDecode(str_Extratxt2.CurrentValue);
                str_Extratxt2.EditValue = HtmlEncode(str_Extratxt2.CurrentValue);
                str_Extratxt2.PlaceHolder = RemoveHtml(str_Extratxt2.Caption);

                // str_OBHours
                str_OBHours.SetupEditAttributes();
                if (!str_OBHours.Raw)
                    str_OBHours.CurrentValue = HtmlDecode(str_OBHours.CurrentValue);
                str_OBHours.EditValue = HtmlEncode(str_OBHours.CurrentValue);
                str_OBHours.PlaceHolder = RemoveHtml(str_OBHours.Caption);

                // str_OBMinutes
                str_OBMinutes.SetupEditAttributes();
                if (!str_OBMinutes.Raw)
                    str_OBMinutes.CurrentValue = HtmlDecode(str_OBMinutes.CurrentValue);
                str_OBMinutes.EditValue = HtmlEncode(str_OBMinutes.CurrentValue);
                str_OBMinutes.PlaceHolder = RemoveHtml(str_OBMinutes.Caption);

                // str_TotalOB_Mins
                str_TotalOB_Mins.SetupEditAttributes();
                if (!str_TotalOB_Mins.Raw)
                    str_TotalOB_Mins.CurrentValue = HtmlDecode(str_TotalOB_Mins.CurrentValue);
                str_TotalOB_Mins.EditValue = HtmlEncode(str_TotalOB_Mins.CurrentValue);
                str_TotalOB_Mins.PlaceHolder = RemoveHtml(str_TotalOB_Mins.Caption);

                // LMSProductID
                LMSProductID.SetupEditAttributes();
                LMSProductID.EditValue = LMSProductID.CurrentValue; // DN
                LMSProductID.PlaceHolder = RemoveHtml(LMSProductID.Caption);
                if (!Empty(LMSProductID.EditValue) && IsNumeric(LMSProductID.EditValue))
                    LMSProductID.EditValue = FormatNumber(LMSProductID.EditValue, null);

                // LMSNoOfAttempts
                LMSNoOfAttempts.SetupEditAttributes();
                LMSNoOfAttempts.EditValue = LMSNoOfAttempts.CurrentValue; // DN
                LMSNoOfAttempts.PlaceHolder = RemoveHtml(LMSNoOfAttempts.Caption);
                if (!Empty(LMSNoOfAttempts.EditValue) && IsNumeric(LMSNoOfAttempts.EditValue))
                    LMSNoOfAttempts.EditValue = FormatNumber(LMSNoOfAttempts.EditValue, null);

                // int_LMSLinkExpirationDays
                int_LMSLinkExpirationDays.SetupEditAttributes();
                int_LMSLinkExpirationDays.EditValue = int_LMSLinkExpirationDays.CurrentValue; // DN
                int_LMSLinkExpirationDays.PlaceHolder = RemoveHtml(int_LMSLinkExpirationDays.Caption);
                if (!Empty(int_LMSLinkExpirationDays.EditValue) && IsNumeric(int_LMSLinkExpirationDays.EditValue))
                    int_LMSLinkExpirationDays.EditValue = FormatNumber(int_LMSLinkExpirationDays.EditValue, null);

                // IGD_product_id
                IGD_product_id.SetupEditAttributes();
                IGD_product_id.EditValue = IGD_product_id.CurrentValue; // DN
                IGD_product_id.PlaceHolder = RemoveHtml(IGD_product_id.Caption);
                if (!Empty(IGD_product_id.EditValue) && IsNumeric(IGD_product_id.EditValue))
                    IGD_product_id.EditValue = FormatNumber(IGD_product_id.EditValue, null);

                // IEC_product_id
                IEC_product_id.SetupEditAttributes();
                IEC_product_id.EditValue = IEC_product_id.CurrentValue; // DN
                IEC_product_id.PlaceHolder = RemoveHtml(IEC_product_id.Caption);
                if (!Empty(IEC_product_id.EditValue) && IsNumeric(IEC_product_id.EditValue))
                    IEC_product_id.EditValue = FormatNumber(IEC_product_id.EditValue, null);

                // Somastream_Product_ID
                Somastream_Product_ID.SetupEditAttributes();
                Somastream_Product_ID.EditValue = Somastream_Product_ID.CurrentValue; // DN
                Somastream_Product_ID.PlaceHolder = RemoveHtml(Somastream_Product_ID.Caption);
                if (!Empty(Somastream_Product_ID.EditValue) && IsNumeric(Somastream_Product_ID.EditValue))
                    Somastream_Product_ID.EditValue = FormatNumber(Somastream_Product_ID.EditValue, null);

                // ProTREAD_Product_ID
                ProTREAD_Product_ID.SetupEditAttributes();
                ProTREAD_Product_ID.EditValue = ProTREAD_Product_ID.CurrentValue; // DN
                ProTREAD_Product_ID.PlaceHolder = RemoveHtml(ProTREAD_Product_ID.Caption);
                if (!Empty(ProTREAD_Product_ID.EditValue) && IsNumeric(ProTREAD_Product_ID.EditValue))
                    ProTREAD_Product_ID.EditValue = FormatNumber(ProTREAD_Product_ID.EditValue, null);

                // ASD_product_id
                ASD_product_id.SetupEditAttributes();
                ASD_product_id.EditValue = ASD_product_id.CurrentValue; // DN
                ASD_product_id.PlaceHolder = RemoveHtml(ASD_product_id.Caption);
                if (!Empty(ASD_product_id.EditValue) && IsNumeric(ASD_product_id.EditValue))
                    ASD_product_id.EditValue = FormatNumber(ASD_product_id.EditValue, null);

                // D2L_product_Id
                D2L_product_Id.SetupEditAttributes();
                D2L_product_Id.EditValue = D2L_product_Id.CurrentValue; // DN
                D2L_product_Id.PlaceHolder = RemoveHtml(D2L_product_Id.Caption);
                if (!Empty(D2L_product_Id.EditValue) && IsNumeric(D2L_product_Id.EditValue))
                    D2L_product_Id.EditValue = FormatNumber(D2L_product_Id.EditValue, null);

                // int_Course_Duration
                int_Course_Duration.SetupEditAttributes();
                int_Course_Duration.EditValue = int_Course_Duration.CurrentValue; // DN
                int_Course_Duration.PlaceHolder = RemoveHtml(int_Course_Duration.Caption);
                if (!Empty(int_Course_Duration.EditValue) && IsNumeric(int_Course_Duration.EditValue))
                    int_Course_Duration.EditValue = FormatNumber(int_Course_Duration.EditValue, null);

                // Moodle_product_Id
                Moodle_product_Id.SetupEditAttributes();
                Moodle_product_Id.EditValue = Moodle_product_Id.CurrentValue; // DN
                Moodle_product_Id.PlaceHolder = RemoveHtml(Moodle_product_Id.Caption);
                if (!Empty(Moodle_product_Id.EditValue) && IsNumeric(Moodle_product_Id.EditValue))
                    Moodle_product_Id.EditValue = FormatNumber(Moodle_product_Id.EditValue, null);

                // Add refer script

                // int_Product_Id
                int_Product_Id.HrefValue = "";

                // str_Product_Name
                str_Product_Name.HrefValue = "";

                // str_Item_Code
                str_Item_Code.HrefValue = "";

                // mny_Price
                mny_Price.HrefValue = "";

                // bit_IsTaxable
                bit_IsTaxable.HrefValue = "";

                // str_Web_Description
                str_Web_Description.HrefValue = "";

                // dec_StateTax
                dec_StateTax.HrefValue = "";

                // dec_AddTax
                dec_AddTax.HrefValue = "";

                // mny_TotalPrice
                mny_TotalPrice.HrefValue = "";

                // int_Product_Type
                int_Product_Type.HrefValue = "";

                // int_Product_Sub_Type
                int_Product_Sub_Type.HrefValue = "";

                // int_Status
                int_Status.HrefValue = "";

                // bit_Is_Web_Purchase
                bit_Is_Web_Purchase.HrefValue = "";

                // str_BTW_Hours
                str_BTW_Hours.HrefValue = "";

                // str_Hour
                str_Hour.HrefValue = "";

                // Str_Minutes
                Str_Minutes.HrefValue = "";

                // str_Appointment_Duration
                str_Appointment_Duration.HrefValue = "";

                // str_Notes
                str_Notes.HrefValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";

                // date_Created
                date_Created.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";

                // int_Dollar
                int_Dollar.HrefValue = "";

                // bit_PortalPurchase
                bit_PortalPurchase.HrefValue = "";

                // str_WebName
                str_WebName.HrefValue = "";

                // bit_ExtraChk1
                bit_ExtraChk1.HrefValue = "";

                // bit_ExtraChk2
                bit_ExtraChk2.HrefValue = "";

                // str_ExtraDrpDown1
                str_ExtraDrpDown1.HrefValue = "";

                // str_ExtraDrpDown2
                str_ExtraDrpDown2.HrefValue = "";

                // str_Extratxt1
                str_Extratxt1.HrefValue = "";

                // str_Extratxt2
                str_Extratxt2.HrefValue = "";

                // str_OBHours
                str_OBHours.HrefValue = "";

                // str_OBMinutes
                str_OBMinutes.HrefValue = "";

                // str_TotalOB_Mins
                str_TotalOB_Mins.HrefValue = "";

                // LMSProductID
                LMSProductID.HrefValue = "";

                // LMSNoOfAttempts
                LMSNoOfAttempts.HrefValue = "";

                // int_LMSLinkExpirationDays
                int_LMSLinkExpirationDays.HrefValue = "";

                // IGD_product_id
                IGD_product_id.HrefValue = "";

                // IEC_product_id
                IEC_product_id.HrefValue = "";

                // Somastream_Product_ID
                Somastream_Product_ID.HrefValue = "";

                // ProTREAD_Product_ID
                ProTREAD_Product_ID.HrefValue = "";

                // ASD_product_id
                ASD_product_id.HrefValue = "";

                // D2L_product_Id
                D2L_product_Id.HrefValue = "";

                // int_Course_Duration
                int_Course_Duration.HrefValue = "";

                // Moodle_product_Id
                Moodle_product_Id.HrefValue = "";
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
            if (int_Product_Id.Required) {
                if (!int_Product_Id.IsDetailKey && Empty(int_Product_Id.FormValue)) {
                    int_Product_Id.AddErrorMessage(ConvertToString(int_Product_Id.RequiredErrorMessage).Replace("%s", int_Product_Id.Caption));
                }
            }
            if (!CheckInteger(int_Product_Id.FormValue)) {
                int_Product_Id.AddErrorMessage(int_Product_Id.GetErrorMessage(false));
            }
            if (str_Product_Name.Required) {
                if (!str_Product_Name.IsDetailKey && Empty(str_Product_Name.FormValue)) {
                    str_Product_Name.AddErrorMessage(ConvertToString(str_Product_Name.RequiredErrorMessage).Replace("%s", str_Product_Name.Caption));
                }
            }
            if (str_Item_Code.Required) {
                if (!str_Item_Code.IsDetailKey && Empty(str_Item_Code.FormValue)) {
                    str_Item_Code.AddErrorMessage(ConvertToString(str_Item_Code.RequiredErrorMessage).Replace("%s", str_Item_Code.Caption));
                }
            }
            if (mny_Price.Required) {
                if (!mny_Price.IsDetailKey && Empty(mny_Price.FormValue)) {
                    mny_Price.AddErrorMessage(ConvertToString(mny_Price.RequiredErrorMessage).Replace("%s", mny_Price.Caption));
                }
            }
            if (!CheckNumber(mny_Price.FormValue)) {
                mny_Price.AddErrorMessage(mny_Price.GetErrorMessage(false));
            }
            if (bit_IsTaxable.Required) {
                if (Empty(bit_IsTaxable.FormValue)) {
                    bit_IsTaxable.AddErrorMessage(ConvertToString(bit_IsTaxable.RequiredErrorMessage).Replace("%s", bit_IsTaxable.Caption));
                }
            }
            if (str_Web_Description.Required) {
                if (!str_Web_Description.IsDetailKey && Empty(str_Web_Description.FormValue)) {
                    str_Web_Description.AddErrorMessage(ConvertToString(str_Web_Description.RequiredErrorMessage).Replace("%s", str_Web_Description.Caption));
                }
            }
            if (dec_StateTax.Required) {
                if (!dec_StateTax.IsDetailKey && Empty(dec_StateTax.FormValue)) {
                    dec_StateTax.AddErrorMessage(ConvertToString(dec_StateTax.RequiredErrorMessage).Replace("%s", dec_StateTax.Caption));
                }
            }
            if (!CheckInteger(dec_StateTax.FormValue)) {
                dec_StateTax.AddErrorMessage(dec_StateTax.GetErrorMessage(false));
            }
            if (dec_AddTax.Required) {
                if (!dec_AddTax.IsDetailKey && Empty(dec_AddTax.FormValue)) {
                    dec_AddTax.AddErrorMessage(ConvertToString(dec_AddTax.RequiredErrorMessage).Replace("%s", dec_AddTax.Caption));
                }
            }
            if (!CheckNumber(dec_AddTax.FormValue)) {
                dec_AddTax.AddErrorMessage(dec_AddTax.GetErrorMessage(false));
            }
            if (mny_TotalPrice.Required) {
                if (!mny_TotalPrice.IsDetailKey && Empty(mny_TotalPrice.FormValue)) {
                    mny_TotalPrice.AddErrorMessage(ConvertToString(mny_TotalPrice.RequiredErrorMessage).Replace("%s", mny_TotalPrice.Caption));
                }
            }
            if (!CheckNumber(mny_TotalPrice.FormValue)) {
                mny_TotalPrice.AddErrorMessage(mny_TotalPrice.GetErrorMessage(false));
            }
            if (int_Product_Type.Required) {
                if (!int_Product_Type.IsDetailKey && Empty(int_Product_Type.FormValue)) {
                    int_Product_Type.AddErrorMessage(ConvertToString(int_Product_Type.RequiredErrorMessage).Replace("%s", int_Product_Type.Caption));
                }
            }
            if (!CheckInteger(int_Product_Type.FormValue)) {
                int_Product_Type.AddErrorMessage(int_Product_Type.GetErrorMessage(false));
            }
            if (int_Product_Sub_Type.Required) {
                if (!int_Product_Sub_Type.IsDetailKey && Empty(int_Product_Sub_Type.FormValue)) {
                    int_Product_Sub_Type.AddErrorMessage(ConvertToString(int_Product_Sub_Type.RequiredErrorMessage).Replace("%s", int_Product_Sub_Type.Caption));
                }
            }
            if (!CheckInteger(int_Product_Sub_Type.FormValue)) {
                int_Product_Sub_Type.AddErrorMessage(int_Product_Sub_Type.GetErrorMessage(false));
            }
            if (int_Status.Required) {
                if (!int_Status.IsDetailKey && Empty(int_Status.FormValue)) {
                    int_Status.AddErrorMessage(ConvertToString(int_Status.RequiredErrorMessage).Replace("%s", int_Status.Caption));
                }
            }
            if (!CheckInteger(int_Status.FormValue)) {
                int_Status.AddErrorMessage(int_Status.GetErrorMessage(false));
            }
            if (bit_Is_Web_Purchase.Required) {
                if (Empty(bit_Is_Web_Purchase.FormValue)) {
                    bit_Is_Web_Purchase.AddErrorMessage(ConvertToString(bit_Is_Web_Purchase.RequiredErrorMessage).Replace("%s", bit_Is_Web_Purchase.Caption));
                }
            }
            if (str_BTW_Hours.Required) {
                if (!str_BTW_Hours.IsDetailKey && Empty(str_BTW_Hours.FormValue)) {
                    str_BTW_Hours.AddErrorMessage(ConvertToString(str_BTW_Hours.RequiredErrorMessage).Replace("%s", str_BTW_Hours.Caption));
                }
            }
            if (str_Hour.Required) {
                if (!str_Hour.IsDetailKey && Empty(str_Hour.FormValue)) {
                    str_Hour.AddErrorMessage(ConvertToString(str_Hour.RequiredErrorMessage).Replace("%s", str_Hour.Caption));
                }
            }
            if (Str_Minutes.Required) {
                if (!Str_Minutes.IsDetailKey && Empty(Str_Minutes.FormValue)) {
                    Str_Minutes.AddErrorMessage(ConvertToString(Str_Minutes.RequiredErrorMessage).Replace("%s", Str_Minutes.Caption));
                }
            }
            if (str_Appointment_Duration.Required) {
                if (!str_Appointment_Duration.IsDetailKey && Empty(str_Appointment_Duration.FormValue)) {
                    str_Appointment_Duration.AddErrorMessage(ConvertToString(str_Appointment_Duration.RequiredErrorMessage).Replace("%s", str_Appointment_Duration.Caption));
                }
            }
            if (str_Notes.Required) {
                if (!str_Notes.IsDetailKey && Empty(str_Notes.FormValue)) {
                    str_Notes.AddErrorMessage(ConvertToString(str_Notes.RequiredErrorMessage).Replace("%s", str_Notes.Caption));
                }
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
            if (bit_IsDeleted.Required) {
                if (Empty(bit_IsDeleted.FormValue)) {
                    bit_IsDeleted.AddErrorMessage(ConvertToString(bit_IsDeleted.RequiredErrorMessage).Replace("%s", bit_IsDeleted.Caption));
                }
            }
            if (int_Dollar.Required) {
                if (!int_Dollar.IsDetailKey && Empty(int_Dollar.FormValue)) {
                    int_Dollar.AddErrorMessage(ConvertToString(int_Dollar.RequiredErrorMessage).Replace("%s", int_Dollar.Caption));
                }
            }
            if (!CheckInteger(int_Dollar.FormValue)) {
                int_Dollar.AddErrorMessage(int_Dollar.GetErrorMessage(false));
            }
            if (bit_PortalPurchase.Required) {
                if (Empty(bit_PortalPurchase.FormValue)) {
                    bit_PortalPurchase.AddErrorMessage(ConvertToString(bit_PortalPurchase.RequiredErrorMessage).Replace("%s", bit_PortalPurchase.Caption));
                }
            }
            if (str_WebName.Required) {
                if (!str_WebName.IsDetailKey && Empty(str_WebName.FormValue)) {
                    str_WebName.AddErrorMessage(ConvertToString(str_WebName.RequiredErrorMessage).Replace("%s", str_WebName.Caption));
                }
            }
            if (bit_ExtraChk1.Required) {
                if (Empty(bit_ExtraChk1.FormValue)) {
                    bit_ExtraChk1.AddErrorMessage(ConvertToString(bit_ExtraChk1.RequiredErrorMessage).Replace("%s", bit_ExtraChk1.Caption));
                }
            }
            if (bit_ExtraChk2.Required) {
                if (Empty(bit_ExtraChk2.FormValue)) {
                    bit_ExtraChk2.AddErrorMessage(ConvertToString(bit_ExtraChk2.RequiredErrorMessage).Replace("%s", bit_ExtraChk2.Caption));
                }
            }
            if (str_ExtraDrpDown1.Required) {
                if (!str_ExtraDrpDown1.IsDetailKey && Empty(str_ExtraDrpDown1.FormValue)) {
                    str_ExtraDrpDown1.AddErrorMessage(ConvertToString(str_ExtraDrpDown1.RequiredErrorMessage).Replace("%s", str_ExtraDrpDown1.Caption));
                }
            }
            if (str_ExtraDrpDown2.Required) {
                if (!str_ExtraDrpDown2.IsDetailKey && Empty(str_ExtraDrpDown2.FormValue)) {
                    str_ExtraDrpDown2.AddErrorMessage(ConvertToString(str_ExtraDrpDown2.RequiredErrorMessage).Replace("%s", str_ExtraDrpDown2.Caption));
                }
            }
            if (str_Extratxt1.Required) {
                if (!str_Extratxt1.IsDetailKey && Empty(str_Extratxt1.FormValue)) {
                    str_Extratxt1.AddErrorMessage(ConvertToString(str_Extratxt1.RequiredErrorMessage).Replace("%s", str_Extratxt1.Caption));
                }
            }
            if (str_Extratxt2.Required) {
                if (!str_Extratxt2.IsDetailKey && Empty(str_Extratxt2.FormValue)) {
                    str_Extratxt2.AddErrorMessage(ConvertToString(str_Extratxt2.RequiredErrorMessage).Replace("%s", str_Extratxt2.Caption));
                }
            }
            if (str_OBHours.Required) {
                if (!str_OBHours.IsDetailKey && Empty(str_OBHours.FormValue)) {
                    str_OBHours.AddErrorMessage(ConvertToString(str_OBHours.RequiredErrorMessage).Replace("%s", str_OBHours.Caption));
                }
            }
            if (str_OBMinutes.Required) {
                if (!str_OBMinutes.IsDetailKey && Empty(str_OBMinutes.FormValue)) {
                    str_OBMinutes.AddErrorMessage(ConvertToString(str_OBMinutes.RequiredErrorMessage).Replace("%s", str_OBMinutes.Caption));
                }
            }
            if (str_TotalOB_Mins.Required) {
                if (!str_TotalOB_Mins.IsDetailKey && Empty(str_TotalOB_Mins.FormValue)) {
                    str_TotalOB_Mins.AddErrorMessage(ConvertToString(str_TotalOB_Mins.RequiredErrorMessage).Replace("%s", str_TotalOB_Mins.Caption));
                }
            }
            if (LMSProductID.Required) {
                if (!LMSProductID.IsDetailKey && Empty(LMSProductID.FormValue)) {
                    LMSProductID.AddErrorMessage(ConvertToString(LMSProductID.RequiredErrorMessage).Replace("%s", LMSProductID.Caption));
                }
            }
            if (!CheckInteger(LMSProductID.FormValue)) {
                LMSProductID.AddErrorMessage(LMSProductID.GetErrorMessage(false));
            }
            if (LMSNoOfAttempts.Required) {
                if (!LMSNoOfAttempts.IsDetailKey && Empty(LMSNoOfAttempts.FormValue)) {
                    LMSNoOfAttempts.AddErrorMessage(ConvertToString(LMSNoOfAttempts.RequiredErrorMessage).Replace("%s", LMSNoOfAttempts.Caption));
                }
            }
            if (!CheckInteger(LMSNoOfAttempts.FormValue)) {
                LMSNoOfAttempts.AddErrorMessage(LMSNoOfAttempts.GetErrorMessage(false));
            }
            if (int_LMSLinkExpirationDays.Required) {
                if (!int_LMSLinkExpirationDays.IsDetailKey && Empty(int_LMSLinkExpirationDays.FormValue)) {
                    int_LMSLinkExpirationDays.AddErrorMessage(ConvertToString(int_LMSLinkExpirationDays.RequiredErrorMessage).Replace("%s", int_LMSLinkExpirationDays.Caption));
                }
            }
            if (!CheckInteger(int_LMSLinkExpirationDays.FormValue)) {
                int_LMSLinkExpirationDays.AddErrorMessage(int_LMSLinkExpirationDays.GetErrorMessage(false));
            }
            if (IGD_product_id.Required) {
                if (!IGD_product_id.IsDetailKey && Empty(IGD_product_id.FormValue)) {
                    IGD_product_id.AddErrorMessage(ConvertToString(IGD_product_id.RequiredErrorMessage).Replace("%s", IGD_product_id.Caption));
                }
            }
            if (!CheckInteger(IGD_product_id.FormValue)) {
                IGD_product_id.AddErrorMessage(IGD_product_id.GetErrorMessage(false));
            }
            if (IEC_product_id.Required) {
                if (!IEC_product_id.IsDetailKey && Empty(IEC_product_id.FormValue)) {
                    IEC_product_id.AddErrorMessage(ConvertToString(IEC_product_id.RequiredErrorMessage).Replace("%s", IEC_product_id.Caption));
                }
            }
            if (!CheckInteger(IEC_product_id.FormValue)) {
                IEC_product_id.AddErrorMessage(IEC_product_id.GetErrorMessage(false));
            }
            if (Somastream_Product_ID.Required) {
                if (!Somastream_Product_ID.IsDetailKey && Empty(Somastream_Product_ID.FormValue)) {
                    Somastream_Product_ID.AddErrorMessage(ConvertToString(Somastream_Product_ID.RequiredErrorMessage).Replace("%s", Somastream_Product_ID.Caption));
                }
            }
            if (!CheckInteger(Somastream_Product_ID.FormValue)) {
                Somastream_Product_ID.AddErrorMessage(Somastream_Product_ID.GetErrorMessage(false));
            }
            if (ProTREAD_Product_ID.Required) {
                if (!ProTREAD_Product_ID.IsDetailKey && Empty(ProTREAD_Product_ID.FormValue)) {
                    ProTREAD_Product_ID.AddErrorMessage(ConvertToString(ProTREAD_Product_ID.RequiredErrorMessage).Replace("%s", ProTREAD_Product_ID.Caption));
                }
            }
            if (!CheckInteger(ProTREAD_Product_ID.FormValue)) {
                ProTREAD_Product_ID.AddErrorMessage(ProTREAD_Product_ID.GetErrorMessage(false));
            }
            if (ASD_product_id.Required) {
                if (!ASD_product_id.IsDetailKey && Empty(ASD_product_id.FormValue)) {
                    ASD_product_id.AddErrorMessage(ConvertToString(ASD_product_id.RequiredErrorMessage).Replace("%s", ASD_product_id.Caption));
                }
            }
            if (!CheckInteger(ASD_product_id.FormValue)) {
                ASD_product_id.AddErrorMessage(ASD_product_id.GetErrorMessage(false));
            }
            if (D2L_product_Id.Required) {
                if (!D2L_product_Id.IsDetailKey && Empty(D2L_product_Id.FormValue)) {
                    D2L_product_Id.AddErrorMessage(ConvertToString(D2L_product_Id.RequiredErrorMessage).Replace("%s", D2L_product_Id.Caption));
                }
            }
            if (!CheckInteger(D2L_product_Id.FormValue)) {
                D2L_product_Id.AddErrorMessage(D2L_product_Id.GetErrorMessage(false));
            }
            if (int_Course_Duration.Required) {
                if (!int_Course_Duration.IsDetailKey && Empty(int_Course_Duration.FormValue)) {
                    int_Course_Duration.AddErrorMessage(ConvertToString(int_Course_Duration.RequiredErrorMessage).Replace("%s", int_Course_Duration.Caption));
                }
            }
            if (!CheckInteger(int_Course_Duration.FormValue)) {
                int_Course_Duration.AddErrorMessage(int_Course_Duration.GetErrorMessage(false));
            }
            if (Moodle_product_Id.Required) {
                if (!Moodle_product_Id.IsDetailKey && Empty(Moodle_product_Id.FormValue)) {
                    Moodle_product_Id.AddErrorMessage(ConvertToString(Moodle_product_Id.RequiredErrorMessage).Replace("%s", Moodle_product_Id.Caption));
                }
            }
            if (!CheckInteger(Moodle_product_Id.FormValue)) {
                Moodle_product_Id.AddErrorMessage(Moodle_product_Id.GetErrorMessage(false));
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
                // int_Product_Id
                int_Product_Id.SetDbValue(rsnew, int_Product_Id.CurrentValue);

                // str_Product_Name
                str_Product_Name.SetDbValue(rsnew, str_Product_Name.CurrentValue);

                // str_Item_Code
                str_Item_Code.SetDbValue(rsnew, str_Item_Code.CurrentValue);

                // mny_Price
                mny_Price.SetDbValue(rsnew, mny_Price.CurrentValue);

                // bit_IsTaxable
                bit_IsTaxable.SetDbValue(rsnew, ConvertToBool(bit_IsTaxable.CurrentValue));

                // str_Web_Description
                str_Web_Description.SetDbValue(rsnew, str_Web_Description.CurrentValue);

                // dec_StateTax
                dec_StateTax.SetDbValue(rsnew, dec_StateTax.CurrentValue);

                // dec_AddTax
                dec_AddTax.SetDbValue(rsnew, dec_AddTax.CurrentValue);

                // mny_TotalPrice
                mny_TotalPrice.SetDbValue(rsnew, mny_TotalPrice.CurrentValue);

                // int_Product_Type
                int_Product_Type.SetDbValue(rsnew, int_Product_Type.CurrentValue);

                // int_Product_Sub_Type
                int_Product_Sub_Type.SetDbValue(rsnew, int_Product_Sub_Type.CurrentValue);

                // int_Status
                int_Status.SetDbValue(rsnew, int_Status.CurrentValue);

                // bit_Is_Web_Purchase
                bit_Is_Web_Purchase.SetDbValue(rsnew, ConvertToBool(bit_Is_Web_Purchase.CurrentValue));

                // str_BTW_Hours
                str_BTW_Hours.SetDbValue(rsnew, str_BTW_Hours.CurrentValue);

                // str_Hour
                str_Hour.SetDbValue(rsnew, str_Hour.CurrentValue);

                // Str_Minutes
                Str_Minutes.SetDbValue(rsnew, Str_Minutes.CurrentValue);

                // str_Appointment_Duration
                str_Appointment_Duration.SetDbValue(rsnew, str_Appointment_Duration.CurrentValue);

                // str_Notes
                str_Notes.SetDbValue(rsnew, str_Notes.CurrentValue);

                // int_Created_By
                int_Created_By.SetDbValue(rsnew, int_Created_By.CurrentValue);

                // int_Modified_By
                int_Modified_By.SetDbValue(rsnew, int_Modified_By.CurrentValue);

                // date_Created
                date_Created.SetDbValue(rsnew, ConvertToDateTime(date_Created.CurrentValue, date_Created.FormatPattern));

                // date_Modified
                date_Modified.SetDbValue(rsnew, ConvertToDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern));

                // bit_IsDeleted
                bit_IsDeleted.SetDbValue(rsnew, ConvertToBool(bit_IsDeleted.CurrentValue));

                // int_Dollar
                int_Dollar.SetDbValue(rsnew, int_Dollar.CurrentValue);

                // bit_PortalPurchase
                bit_PortalPurchase.SetDbValue(rsnew, ConvertToBool(bit_PortalPurchase.CurrentValue));

                // str_WebName
                str_WebName.SetDbValue(rsnew, str_WebName.CurrentValue);

                // bit_ExtraChk1
                bit_ExtraChk1.SetDbValue(rsnew, ConvertToBool(bit_ExtraChk1.CurrentValue));

                // bit_ExtraChk2
                bit_ExtraChk2.SetDbValue(rsnew, ConvertToBool(bit_ExtraChk2.CurrentValue));

                // str_ExtraDrpDown1
                str_ExtraDrpDown1.SetDbValue(rsnew, str_ExtraDrpDown1.CurrentValue);

                // str_ExtraDrpDown2
                str_ExtraDrpDown2.SetDbValue(rsnew, str_ExtraDrpDown2.CurrentValue);

                // str_Extratxt1
                str_Extratxt1.SetDbValue(rsnew, str_Extratxt1.CurrentValue);

                // str_Extratxt2
                str_Extratxt2.SetDbValue(rsnew, str_Extratxt2.CurrentValue);

                // str_OBHours
                str_OBHours.SetDbValue(rsnew, str_OBHours.CurrentValue);

                // str_OBMinutes
                str_OBMinutes.SetDbValue(rsnew, str_OBMinutes.CurrentValue);

                // str_TotalOB_Mins
                str_TotalOB_Mins.SetDbValue(rsnew, str_TotalOB_Mins.CurrentValue);

                // LMSProductID
                LMSProductID.SetDbValue(rsnew, LMSProductID.CurrentValue);

                // LMSNoOfAttempts
                LMSNoOfAttempts.SetDbValue(rsnew, LMSNoOfAttempts.CurrentValue);

                // int_LMSLinkExpirationDays
                int_LMSLinkExpirationDays.SetDbValue(rsnew, int_LMSLinkExpirationDays.CurrentValue);

                // IGD_product_id
                IGD_product_id.SetDbValue(rsnew, IGD_product_id.CurrentValue);

                // IEC_product_id
                IEC_product_id.SetDbValue(rsnew, IEC_product_id.CurrentValue);

                // Somastream_Product_ID
                Somastream_Product_ID.SetDbValue(rsnew, Somastream_Product_ID.CurrentValue);

                // ProTREAD_Product_ID
                ProTREAD_Product_ID.SetDbValue(rsnew, ProTREAD_Product_ID.CurrentValue);

                // ASD_product_id
                ASD_product_id.SetDbValue(rsnew, ASD_product_id.CurrentValue);

                // D2L_product_Id
                D2L_product_Id.SetDbValue(rsnew, D2L_product_Id.CurrentValue);

                // int_Course_Duration
                int_Course_Duration.SetDbValue(rsnew, int_Course_Duration.CurrentValue);

                // Moodle_product_Id
                Moodle_product_Id.SetDbValue(rsnew, Moodle_product_Id.CurrentValue);
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblProductInfoList")), "", TableVar, true);
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
