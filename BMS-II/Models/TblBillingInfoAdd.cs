namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblBillingInfoAdd
    /// </summary>
    public static TblBillingInfoAdd tblBillingInfoAdd
    {
        get => HttpData.Get<TblBillingInfoAdd>("tblBillingInfoAdd")!;
        set => HttpData["tblBillingInfoAdd"] = value;
    }

    /// <summary>
    /// Page class for tblBillingInfo
    /// </summary>
    public class TblBillingInfoAdd : TblBillingInfoAddBase
    {
        // Constructor
        public TblBillingInfoAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblBillingInfoAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblBillingInfoAddBase : TblBillingInfo
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblBillingInfo";

        // Page object name
        public string PageObjName = "tblBillingInfoAdd";

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
        public TblBillingInfoAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblBillingInfo)
            if (tblBillingInfo == null || tblBillingInfo is TblBillingInfo)
                tblBillingInfo = this;

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
        public string PageName => "TblBillingInfoAdd";

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
            int_Bill_ID.Visible = false;
            NationalID.SetVisibility();
            str_First_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Username.SetVisibility();
            int_Student_ID.SetVisibility();
            int_Payment_Method.SetVisibility();
            date_Paid.SetVisibility();
            str_ApprovalCode.SetVisibility();
            Payment_Number.Visible = false;
            Pricelist.Visible = false;
            date_Created.SetVisibility();
            str_Amount.SetVisibility();
            str_CC_Holder_Name.SetVisibility();
            str_CC_Number.SetVisibility();
            int_CC_ExpMonth.SetVisibility();
            int_CC_ExpYear.SetVisibility();
            int_CC_Type.SetVisibility();
            str_Card_Id.SetVisibility();
            str_CC_ValidationNum.SetVisibility();
            str_reference.SetVisibility();
            str_Amount_Pay.SetVisibility();
            mny_Running_Payments.Visible = false;
            mny_Running_Balance.Visible = false;
            str_Payment_Reference.SetVisibility();
            int_Accepted_By.Visible = false;
            str_Check_Number.Visible = false;
            bit_Is_Check_Deposited.Visible = false;
            str_Adjustment_Type.Visible = false;
            str_Adjust_Sub_Type.Visible = false;
            bit_Archive.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            date_Modified.Visible = false;
            bit_IsDeleted.Visible = false;
            str_CardHolder_Address.Visible = false;
            str_CH_City.Visible = false;
            str_CH_Zip.Visible = false;
            int_State.Visible = false;
            bit_IsAuthDotNet.Visible = false;
            bit_IsRefund.SetVisibility();
            str_Receipt.Visible = false;
            str_TransactionNumber.Visible = false;
            str_OrderId.Visible = false;
            str_TransactionTime.SetVisibility();
            int_Location_Id.Visible = false;
            str_Enrollment_Id.Visible = false;
            str_Notes.Visible = false;
            str_Payment_Note.SetVisibility();
            int_Package_ID.SetVisibility();
            Package_Name.SetVisibility();
            Price.SetVisibility();
            AssessmentID.Visible = false;
            course.Visible = false;
            institution.Visible = false;
            UniqueIdx.Visible = false;
        }

        // Constructor
        public TblBillingInfoAddBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblBillingInfoView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Bill_ID") ? dict["int_Bill_ID"] : int_Bill_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Bill_ID.Visible = false;
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
            await SetupLookupOptions(NationalID);
            await SetupLookupOptions(str_Username);
            await SetupLookupOptions(int_Student_ID);
            await SetupLookupOptions(int_Payment_Method);
            await SetupLookupOptions(bit_Is_Check_Deposited);
            await SetupLookupOptions(bit_Archive);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_IsAuthDotNet);
            await SetupLookupOptions(bit_IsRefund);
            await SetupLookupOptions(int_Package_ID);
            await SetupLookupOptions(Package_Name);
            await SetupLookupOptions(Price);

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
                if (RouteValues.TryGetValue("int_Bill_ID", out rv)) { // DN
                    int_Bill_ID.QueryValue = UrlDecode(rv); // DN
                } else if (Get("int_Bill_ID", out sv)) {
                    int_Bill_ID.QueryValue = sv.ToString();
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

            // Set up master/detail parameters
            // NOTE: must be after loadOldRecord to prevent master key values overwritten
            SetupMasterParms();

            // Load form values
            if (postBack) {
                await LoadFormValues(); // Load form values
            }

            // Set up detail parameters
            SetupDetailParms();

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
                        return Terminate("TblBillingInfoList"); // No matching record, return to List page // DN
                    }

                    // Set up detail parameters
                    SetupDetailParms();
                    break;
                case "insert": // Add new record // DN
                    SendEmail = true; // Send email on add success
                    var res = await AddRow(rsold);
                    if (res) { // Add successful
                        if (Empty(SuccessMessage) && Post("addopt") != "1") // Skip success message for addopt (done in JavaScript)
                            SuccessMessage = Language.Phrase("AddSuccess"); // Set up success message
                        string returnUrl = "";
                        returnUrl = "TblBillingInfoList";
                        if (GetPageName(returnUrl) == "TblBillingInfoList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "TblBillingInfoView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblBillingInfoList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblBillingInfoList"; // Return list page content
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

                        // Set up detail parameters
                        SetupDetailParms();
                    }
                    break;
            }

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Render row based on row type
            if (IsConfirm) { // Confirm page
                RowType = RowType.View; // Render view type
            } else {
                RowType = RowType.Add; // Render add type
            }

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
                tblBillingInfoAdd?.PageRender();
            }
            return PageResult();
        }

        // Confirm page
        public bool ConfirmPage = true; // DN

        #pragma warning disable 1998
        // Get upload files
        public async Task GetUploadFiles()
        {
            // Get upload data
        }
        #pragma warning restore 1998

        // Load default values
        protected void LoadDefaultValues() {
            bit_IsDeleted.DefaultValue = bit_IsDeleted.GetDefault(); // DN
            bit_IsDeleted.OldValue = bit_IsDeleted.DefaultValue;
            bit_IsAuthDotNet.DefaultValue = bit_IsAuthDotNet.GetDefault(); // DN
            bit_IsAuthDotNet.OldValue = bit_IsAuthDotNet.DefaultValue;
            bit_IsRefund.DefaultValue = bit_IsRefund.GetDefault(); // DN
            bit_IsRefund.OldValue = bit_IsRefund.DefaultValue;
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val);
            }

            // Check field name 'str_First_Name' before field var 'x_str_First_Name'
            val = CurrentForm.HasValue("str_First_Name") ? CurrentForm.GetValue("str_First_Name") : CurrentForm.GetValue("x_str_First_Name");
            if (!str_First_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_First_Name") && !CurrentForm.HasValue("x_str_First_Name")) // DN
                    str_First_Name.Visible = false; // Disable update for API request
                else
                    str_First_Name.SetFormValue(val);
            }

            // Check field name 'str_Last_Name' before field var 'x_str_Last_Name'
            val = CurrentForm.HasValue("str_Last_Name") ? CurrentForm.GetValue("str_Last_Name") : CurrentForm.GetValue("x_str_Last_Name");
            if (!str_Last_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Last_Name") && !CurrentForm.HasValue("x_str_Last_Name")) // DN
                    str_Last_Name.Visible = false; // Disable update for API request
                else
                    str_Last_Name.SetFormValue(val);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }

            // Check field name 'int_Student_ID' before field var 'x_int_Student_ID'
            val = CurrentForm.HasValue("int_Student_ID") ? CurrentForm.GetValue("int_Student_ID") : CurrentForm.GetValue("x_int_Student_ID");
            if (!int_Student_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Student_ID") && !CurrentForm.HasValue("x_int_Student_ID")) // DN
                    int_Student_ID.Visible = false; // Disable update for API request
                else
                    int_Student_ID.SetFormValue(val);
            }

            // Check field name 'int_Payment_Method' before field var 'x_int_Payment_Method'
            val = CurrentForm.HasValue("int_Payment_Method") ? CurrentForm.GetValue("int_Payment_Method") : CurrentForm.GetValue("x_int_Payment_Method");
            if (!int_Payment_Method.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Payment_Method") && !CurrentForm.HasValue("x_int_Payment_Method")) // DN
                    int_Payment_Method.Visible = false; // Disable update for API request
                else
                    int_Payment_Method.SetFormValue(val);
            }

            // Check field name 'date_Paid' before field var 'x_date_Paid'
            val = CurrentForm.HasValue("date_Paid") ? CurrentForm.GetValue("date_Paid") : CurrentForm.GetValue("x_date_Paid");
            if (!date_Paid.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Paid") && !CurrentForm.HasValue("x_date_Paid")) // DN
                    date_Paid.Visible = false; // Disable update for API request
                else
                    date_Paid.SetFormValue(val, true, validate);
                date_Paid.CurrentValue = UnformatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern);
            }

            // Check field name 'str_ApprovalCode' before field var 'x_str_ApprovalCode'
            val = CurrentForm.HasValue("str_ApprovalCode") ? CurrentForm.GetValue("str_ApprovalCode") : CurrentForm.GetValue("x_str_ApprovalCode");
            if (!str_ApprovalCode.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ApprovalCode") && !CurrentForm.HasValue("x_str_ApprovalCode")) // DN
                    str_ApprovalCode.Visible = false; // Disable update for API request
                else
                    str_ApprovalCode.SetFormValue(val);
            }

            // Check field name 'date_Created' before field var 'x_date_Created'
            val = CurrentForm.HasValue("date_Created") ? CurrentForm.GetValue("date_Created") : CurrentForm.GetValue("x_date_Created");
            if (!date_Created.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Created") && !CurrentForm.HasValue("x_date_Created")) // DN
                    date_Created.Visible = false; // Disable update for API request
                else
                    date_Created.SetFormValue(val);
                date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            }

            // Check field name 'str_Amount' before field var 'x_str_Amount'
            val = CurrentForm.HasValue("str_Amount") ? CurrentForm.GetValue("str_Amount") : CurrentForm.GetValue("x_str_Amount");
            if (!str_Amount.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Amount") && !CurrentForm.HasValue("x_str_Amount")) // DN
                    str_Amount.Visible = false; // Disable update for API request
                else
                    str_Amount.SetFormValue(val, true, validate);
            }

            // Check field name 'str_CC_Holder_Name' before field var 'x_str_CC_Holder_Name'
            val = CurrentForm.HasValue("str_CC_Holder_Name") ? CurrentForm.GetValue("str_CC_Holder_Name") : CurrentForm.GetValue("x_str_CC_Holder_Name");
            if (!str_CC_Holder_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_CC_Holder_Name") && !CurrentForm.HasValue("x_str_CC_Holder_Name")) // DN
                    str_CC_Holder_Name.Visible = false; // Disable update for API request
                else
                    str_CC_Holder_Name.SetFormValue(val);
            }

            // Check field name 'str_CC_Number' before field var 'x_str_CC_Number'
            val = CurrentForm.HasValue("str_CC_Number") ? CurrentForm.GetValue("str_CC_Number") : CurrentForm.GetValue("x_str_CC_Number");
            if (!str_CC_Number.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_CC_Number") && !CurrentForm.HasValue("x_str_CC_Number")) // DN
                    str_CC_Number.Visible = false; // Disable update for API request
                else
                    str_CC_Number.SetFormValue(val, true, validate);
            }

            // Check field name 'int_CC_ExpMonth' before field var 'x_int_CC_ExpMonth'
            val = CurrentForm.HasValue("int_CC_ExpMonth") ? CurrentForm.GetValue("int_CC_ExpMonth") : CurrentForm.GetValue("x_int_CC_ExpMonth");
            if (!int_CC_ExpMonth.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CC_ExpMonth") && !CurrentForm.HasValue("x_int_CC_ExpMonth")) // DN
                    int_CC_ExpMonth.Visible = false; // Disable update for API request
                else
                    int_CC_ExpMonth.SetFormValue(val, true, validate);
            }

            // Check field name 'int_CC_ExpYear' before field var 'x_int_CC_ExpYear'
            val = CurrentForm.HasValue("int_CC_ExpYear") ? CurrentForm.GetValue("int_CC_ExpYear") : CurrentForm.GetValue("x_int_CC_ExpYear");
            if (!int_CC_ExpYear.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CC_ExpYear") && !CurrentForm.HasValue("x_int_CC_ExpYear")) // DN
                    int_CC_ExpYear.Visible = false; // Disable update for API request
                else
                    int_CC_ExpYear.SetFormValue(val, true, validate);
            }

            // Check field name 'int_CC_Type' before field var 'x_int_CC_Type'
            val = CurrentForm.HasValue("int_CC_Type") ? CurrentForm.GetValue("int_CC_Type") : CurrentForm.GetValue("x_int_CC_Type");
            if (!int_CC_Type.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_CC_Type") && !CurrentForm.HasValue("x_int_CC_Type")) // DN
                    int_CC_Type.Visible = false; // Disable update for API request
                else
                    int_CC_Type.SetFormValue(val, true, validate);
            }

            // Check field name 'str_Card_Id' before field var 'x_str_Card_Id'
            val = CurrentForm.HasValue("str_Card_Id") ? CurrentForm.GetValue("str_Card_Id") : CurrentForm.GetValue("x_str_Card_Id");
            if (!str_Card_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Card_Id") && !CurrentForm.HasValue("x_str_Card_Id")) // DN
                    str_Card_Id.Visible = false; // Disable update for API request
                else
                    str_Card_Id.SetFormValue(val);
            }

            // Check field name 'str_CC_ValidationNum' before field var 'x_str_CC_ValidationNum'
            val = CurrentForm.HasValue("str_CC_ValidationNum") ? CurrentForm.GetValue("str_CC_ValidationNum") : CurrentForm.GetValue("x_str_CC_ValidationNum");
            if (!str_CC_ValidationNum.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_CC_ValidationNum") && !CurrentForm.HasValue("x_str_CC_ValidationNum")) // DN
                    str_CC_ValidationNum.Visible = false; // Disable update for API request
                else
                    str_CC_ValidationNum.SetFormValue(val);
            }

            // Check field name 'str_reference' before field var 'x_str_reference'
            val = CurrentForm.HasValue("str_reference") ? CurrentForm.GetValue("str_reference") : CurrentForm.GetValue("x_str_reference");
            if (!str_reference.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_reference") && !CurrentForm.HasValue("x_str_reference")) // DN
                    str_reference.Visible = false; // Disable update for API request
                else
                    str_reference.SetFormValue(val);
            }

            // Check field name 'str_Amount_Pay' before field var 'x_str_Amount_Pay'
            val = CurrentForm.HasValue("str_Amount_Pay") ? CurrentForm.GetValue("str_Amount_Pay") : CurrentForm.GetValue("x_str_Amount_Pay");
            if (!str_Amount_Pay.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Amount_Pay") && !CurrentForm.HasValue("x_str_Amount_Pay")) // DN
                    str_Amount_Pay.Visible = false; // Disable update for API request
                else
                    str_Amount_Pay.SetFormValue(val);
            }

            // Check field name 'str_Payment_Reference' before field var 'x_str_Payment_Reference'
            val = CurrentForm.HasValue("str_Payment_Reference") ? CurrentForm.GetValue("str_Payment_Reference") : CurrentForm.GetValue("x_str_Payment_Reference");
            if (!str_Payment_Reference.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Payment_Reference") && !CurrentForm.HasValue("x_str_Payment_Reference")) // DN
                    str_Payment_Reference.Visible = false; // Disable update for API request
                else
                    str_Payment_Reference.SetFormValue(val);
            }

            // Check field name 'bit_IsRefund' before field var 'x_bit_IsRefund'
            val = CurrentForm.HasValue("bit_IsRefund") ? CurrentForm.GetValue("bit_IsRefund") : CurrentForm.GetValue("x_bit_IsRefund");
            if (!bit_IsRefund.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsRefund") && !CurrentForm.HasValue("x_bit_IsRefund")) // DN
                    bit_IsRefund.Visible = false; // Disable update for API request
                else
                    bit_IsRefund.SetFormValue(val);
            }

            // Check field name 'str_TransactionTime' before field var 'x_str_TransactionTime'
            val = CurrentForm.HasValue("str_TransactionTime") ? CurrentForm.GetValue("str_TransactionTime") : CurrentForm.GetValue("x_str_TransactionTime");
            if (!str_TransactionTime.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_TransactionTime") && !CurrentForm.HasValue("x_str_TransactionTime")) // DN
                    str_TransactionTime.Visible = false; // Disable update for API request
                else
                    str_TransactionTime.SetFormValue(val);
            }

            // Check field name 'str_Payment_Note' before field var 'x_str_Payment_Note'
            val = CurrentForm.HasValue("str_Payment_Note") ? CurrentForm.GetValue("str_Payment_Note") : CurrentForm.GetValue("x_str_Payment_Note");
            if (!str_Payment_Note.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Payment_Note") && !CurrentForm.HasValue("x_str_Payment_Note")) // DN
                    str_Payment_Note.Visible = false; // Disable update for API request
                else
                    str_Payment_Note.SetFormValue(val);
            }

            // Check field name 'int_Package_ID' before field var 'x_int_Package_ID'
            val = CurrentForm.HasValue("int_Package_ID") ? CurrentForm.GetValue("int_Package_ID") : CurrentForm.GetValue("x_int_Package_ID");
            if (!int_Package_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Package_ID") && !CurrentForm.HasValue("x_int_Package_ID")) // DN
                    int_Package_ID.Visible = false; // Disable update for API request
                else
                    int_Package_ID.SetFormValue(val);
            }

            // Check field name 'Package_Name' before field var 'x_Package_Name'
            val = CurrentForm.HasValue("Package_Name") ? CurrentForm.GetValue("Package_Name") : CurrentForm.GetValue("x_Package_Name");
            if (!Package_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Package_Name") && !CurrentForm.HasValue("x_Package_Name")) // DN
                    Package_Name.Visible = false; // Disable update for API request
                else
                    Package_Name.SetFormValue(val);
            }

            // Check field name 'Price' before field var 'x_Price'
            val = CurrentForm.HasValue("Price") ? CurrentForm.GetValue("Price") : CurrentForm.GetValue("x_Price");
            if (!Price.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Price") && !CurrentForm.HasValue("x_Price")) // DN
                    Price.Visible = false; // Disable update for API request
                else
                    Price.SetFormValue(val);
            }

            // Check field name 'int_Bill_ID' before field var 'x_int_Bill_ID'
            val = CurrentForm.HasValue("int_Bill_ID") ? CurrentForm.GetValue("int_Bill_ID") : CurrentForm.GetValue("x_int_Bill_ID");
            ResetDetailParms();
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            NationalID.CurrentValue = NationalID.FormValue;
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            int_Student_ID.CurrentValue = int_Student_ID.FormValue;
            int_Payment_Method.CurrentValue = int_Payment_Method.FormValue;
            date_Paid.CurrentValue = date_Paid.FormValue;
            date_Paid.CurrentValue = UnformatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern);
            str_ApprovalCode.CurrentValue = str_ApprovalCode.FormValue;
            date_Created.CurrentValue = date_Created.FormValue;
            date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            str_Amount.CurrentValue = str_Amount.FormValue;
            str_CC_Holder_Name.CurrentValue = str_CC_Holder_Name.FormValue;
            str_CC_Number.CurrentValue = str_CC_Number.FormValue;
            int_CC_ExpMonth.CurrentValue = int_CC_ExpMonth.FormValue;
            int_CC_ExpYear.CurrentValue = int_CC_ExpYear.FormValue;
            int_CC_Type.CurrentValue = int_CC_Type.FormValue;
            str_Card_Id.CurrentValue = str_Card_Id.FormValue;
            str_CC_ValidationNum.CurrentValue = str_CC_ValidationNum.FormValue;
            str_reference.CurrentValue = str_reference.FormValue;
            str_Amount_Pay.CurrentValue = str_Amount_Pay.FormValue;
            str_Payment_Reference.CurrentValue = str_Payment_Reference.FormValue;
            bit_IsRefund.CurrentValue = bit_IsRefund.FormValue;
            str_TransactionTime.CurrentValue = str_TransactionTime.FormValue;
            str_Payment_Note.CurrentValue = str_Payment_Note.FormValue;
            int_Package_ID.CurrentValue = int_Package_ID.FormValue;
            Package_Name.CurrentValue = Package_Name.FormValue;
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
            int_Bill_ID.SetDbValue(row["int_Bill_ID"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_First_Name.SetDbValue(row["str_First_Name"]);
            str_Last_Name.SetDbValue(row["str_Last_Name"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            int_Payment_Method.SetDbValue(row["int_Payment_Method"]);
            date_Paid.SetDbValue(row["date_Paid"]);
            str_ApprovalCode.SetDbValue(row["str_ApprovalCode"]);
            Payment_Number.SetDbValue(row["Payment_Number"]);
            Pricelist.SetDbValue(row["Pricelist"]);
            date_Created.SetDbValue(row["date_Created"]);
            str_Amount.SetDbValue(row["str_Amount"]);
            str_CC_Holder_Name.SetDbValue(row["str_CC_Holder_Name"]);
            str_CC_Number.SetDbValue(row["str_CC_Number"]);
            int_CC_ExpMonth.SetDbValue(row["int_CC_ExpMonth"]);
            int_CC_ExpYear.SetDbValue(row["int_CC_ExpYear"]);
            int_CC_Type.SetDbValue(row["int_CC_Type"]);
            str_Card_Id.SetDbValue(row["str_Card_Id"]);
            str_CC_ValidationNum.SetDbValue(row["str_CC_ValidationNum"]);
            str_reference.SetDbValue(row["str_reference"]);
            str_Amount_Pay.SetDbValue(row["str_Amount_Pay"]);
            mny_Running_Payments.SetDbValue(row["mny_Running_Payments"]);
            mny_Running_Balance.SetDbValue(row["mny_Running_Balance"]);
            str_Payment_Reference.SetDbValue(row["str_Payment_Reference"]);
            int_Accepted_By.SetDbValue(row["int_Accepted_By"]);
            str_Check_Number.SetDbValue(row["str_Check_Number"]);
            bit_Is_Check_Deposited.SetDbValue((ConvertToBool(row["bit_Is_Check_Deposited"]) ? "1" : "0"));
            str_Adjustment_Type.SetDbValue(row["str_Adjustment_Type"]);
            str_Adjust_Sub_Type.SetDbValue(row["str_Adjust_Sub_Type"]);
            bit_Archive.SetDbValue((ConvertToBool(row["bit_Archive"]) ? "1" : "0"));
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_CardHolder_Address.SetDbValue(row["str_CardHolder_Address"]);
            str_CH_City.SetDbValue(row["str_CH_City"]);
            str_CH_Zip.SetDbValue(row["str_CH_Zip"]);
            int_State.SetDbValue(row["int_State"]);
            bit_IsAuthDotNet.SetDbValue((ConvertToBool(row["bit_IsAuthDotNet"]) ? "1" : "0"));
            bit_IsRefund.SetDbValue((ConvertToBool(row["bit_IsRefund"]) ? "1" : "0"));
            str_Receipt.SetDbValue(row["str_Receipt"]);
            str_TransactionNumber.SetDbValue(row["str_TransactionNumber"]);
            str_OrderId.SetDbValue(row["str_OrderId"]);
            str_TransactionTime.SetDbValue(row["str_TransactionTime"]);
            int_Location_Id.SetDbValue(row["int_Location_Id"]);
            str_Enrollment_Id.SetDbValue(row["str_Enrollment_Id"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            str_Payment_Note.SetDbValue(row["str_Payment_Note"]);
            int_Package_ID.SetDbValue(row["int_Package_ID"]);
            Package_Name.SetDbValue(row["Package_Name"]);
            Price.SetDbValue(row["Price"]);
            AssessmentID.SetDbValue(row["AssessmentID"]);
            course.SetDbValue(row["course"]);
            institution.SetDbValue(row["institution"]);
            UniqueIdx.SetDbValue(row["UniqueIdx"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Bill_ID", int_Bill_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_First_Name", str_First_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last_Name", str_Last_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Payment_Method", int_Payment_Method.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Paid", date_Paid.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ApprovalCode", str_ApprovalCode.DefaultValue ?? DbNullValue); // DN
            row.Add("Payment_Number", Payment_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("Pricelist", Pricelist.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Amount", str_Amount.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_Holder_Name", str_CC_Holder_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_Number", str_CC_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_ExpMonth", int_CC_ExpMonth.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_ExpYear", int_CC_ExpYear.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_Type", int_CC_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Card_Id", str_Card_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_ValidationNum", str_CC_ValidationNum.DefaultValue ?? DbNullValue); // DN
            row.Add("str_reference", str_reference.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Amount_Pay", str_Amount_Pay.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Running_Payments", mny_Running_Payments.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Running_Balance", mny_Running_Balance.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Payment_Reference", str_Payment_Reference.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Accepted_By", int_Accepted_By.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Check_Number", str_Check_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Is_Check_Deposited", bit_Is_Check_Deposited.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Adjustment_Type", str_Adjustment_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Adjust_Sub_Type", str_Adjust_Sub_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Archive", bit_Archive.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardHolder_Address", str_CardHolder_Address.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CH_City", str_CH_City.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CH_Zip", str_CH_Zip.DefaultValue ?? DbNullValue); // DN
            row.Add("int_State", int_State.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsAuthDotNet", bit_IsAuthDotNet.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsRefund", bit_IsRefund.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Receipt", str_Receipt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_TransactionNumber", str_TransactionNumber.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OrderId", str_OrderId.DefaultValue ?? DbNullValue); // DN
            row.Add("str_TransactionTime", str_TransactionTime.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_Id", int_Location_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Enrollment_Id", str_Enrollment_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Payment_Note", str_Payment_Note.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Package_ID", int_Package_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Package_Name", Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("Price", Price.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentID", AssessmentID.DefaultValue ?? DbNullValue); // DN
            row.Add("course", course.DefaultValue ?? DbNullValue); // DN
            row.Add("institution", institution.DefaultValue ?? DbNullValue); // DN
            row.Add("UniqueIdx", UniqueIdx.DefaultValue ?? DbNullValue); // DN
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

            // int_Bill_ID
            int_Bill_ID.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // str_First_Name
            str_First_Name.RowCssClass = "row";

            // str_Last_Name
            str_Last_Name.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // int_Student_ID
            int_Student_ID.RowCssClass = "row";

            // int_Payment_Method
            int_Payment_Method.RowCssClass = "row";

            // date_Paid
            date_Paid.RowCssClass = "row";

            // str_ApprovalCode
            str_ApprovalCode.RowCssClass = "row";

            // Payment_Number
            Payment_Number.RowCssClass = "row";

            // Pricelist
            Pricelist.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // str_Amount
            str_Amount.RowCssClass = "row";

            // str_CC_Holder_Name
            str_CC_Holder_Name.RowCssClass = "row";

            // str_CC_Number
            str_CC_Number.RowCssClass = "row";

            // int_CC_ExpMonth
            int_CC_ExpMonth.RowCssClass = "row";

            // int_CC_ExpYear
            int_CC_ExpYear.RowCssClass = "row";

            // int_CC_Type
            int_CC_Type.RowCssClass = "row";

            // str_Card_Id
            str_Card_Id.RowCssClass = "row";

            // str_CC_ValidationNum
            str_CC_ValidationNum.RowCssClass = "row";

            // str_reference
            str_reference.RowCssClass = "row";

            // str_Amount_Pay
            str_Amount_Pay.RowCssClass = "row";

            // mny_Running_Payments
            mny_Running_Payments.RowCssClass = "row";

            // mny_Running_Balance
            mny_Running_Balance.RowCssClass = "row";

            // str_Payment_Reference
            str_Payment_Reference.RowCssClass = "row";

            // int_Accepted_By
            int_Accepted_By.RowCssClass = "row";

            // str_Check_Number
            str_Check_Number.RowCssClass = "row";

            // bit_Is_Check_Deposited
            bit_Is_Check_Deposited.RowCssClass = "row";

            // str_Adjustment_Type
            str_Adjustment_Type.RowCssClass = "row";

            // str_Adjust_Sub_Type
            str_Adjust_Sub_Type.RowCssClass = "row";

            // bit_Archive
            bit_Archive.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // bit_IsDeleted
            bit_IsDeleted.RowCssClass = "row";

            // str_CardHolder_Address
            str_CardHolder_Address.RowCssClass = "row";

            // str_CH_City
            str_CH_City.RowCssClass = "row";

            // str_CH_Zip
            str_CH_Zip.RowCssClass = "row";

            // int_State
            int_State.RowCssClass = "row";

            // bit_IsAuthDotNet
            bit_IsAuthDotNet.RowCssClass = "row";

            // bit_IsRefund
            bit_IsRefund.RowCssClass = "row";

            // str_Receipt
            str_Receipt.RowCssClass = "row";

            // str_TransactionNumber
            str_TransactionNumber.RowCssClass = "row";

            // str_OrderId
            str_OrderId.RowCssClass = "row";

            // str_TransactionTime
            str_TransactionTime.RowCssClass = "row";

            // int_Location_Id
            int_Location_Id.RowCssClass = "row";

            // str_Enrollment_Id
            str_Enrollment_Id.RowCssClass = "row";

            // str_Notes
            str_Notes.RowCssClass = "row";

            // str_Payment_Note
            str_Payment_Note.RowCssClass = "row";

            // int_Package_ID
            int_Package_ID.RowCssClass = "row";

            // Package_Name
            Package_Name.RowCssClass = "row";

            // Price
            Price.RowCssClass = "row";

            // AssessmentID
            AssessmentID.RowCssClass = "row";

            // course
            course.RowCssClass = "row";

            // institution
            institution.RowCssClass = "row";

            // UniqueIdx
            UniqueIdx.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // int_Bill_ID
                int_Bill_ID.ViewValue = int_Bill_ID.CurrentValue;
                int_Bill_ID.ViewCustomAttributes = "";

                // NationalID
                curVal = ConvertToString(NationalID.CurrentValue);
                if (!Empty(curVal)) {
                    if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        NationalID.ViewValue = NationalID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                        sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && NationalID.Lookup != null) { // Lookup values found
                            var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                            NationalID.ViewValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                        } else {
                            NationalID.ViewValue = NationalID.CurrentValue;
                        }
                    }
                } else {
                    NationalID.ViewValue = DbNullValue;
                }
                NationalID.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // str_Username
                curVal = ConvertToString(str_Username.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Username.ViewValue = str_Username.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                        sqlWrk = str_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Username.Lookup != null) { // Lookup values found
                            var listwrk = str_Username.Lookup?.RenderViewRow(rswrk[0]);
                            str_Username.ViewValue = str_Username.HighlightLookup(ConvertToString(rswrk[0]), str_Username.DisplayValue(listwrk));
                        } else {
                            str_Username.ViewValue = str_Username.CurrentValue;
                        }
                    }
                } else {
                    str_Username.ViewValue = DbNullValue;
                }
                str_Username.ViewCustomAttributes = "";

                // int_Student_ID
                curVal = ConvertToString(int_Student_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Student_ID.Lookup != null && IsDictionary(int_Student_ID.Lookup?.Options) && int_Student_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Student_ID.ViewValue = int_Student_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Student_ID]", "=", int_Student_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Student_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Student_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Student_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Student_ID.ViewValue = int_Student_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Student_ID.DisplayValue(listwrk));
                        } else {
                            int_Student_ID.ViewValue = FormatNumber(int_Student_ID.CurrentValue, int_Student_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Student_ID.ViewValue = DbNullValue;
                }
                int_Student_ID.ViewCustomAttributes = "";

                // int_Payment_Method
                if (!Empty(int_Payment_Method.CurrentValue)) {
                    int_Payment_Method.ViewValue = int_Payment_Method.HighlightLookup(ConvertToString(int_Payment_Method.CurrentValue), int_Payment_Method.OptionCaption(ConvertToString(int_Payment_Method.CurrentValue)));
                } else {
                    int_Payment_Method.ViewValue = DbNullValue;
                }
                int_Payment_Method.ViewCustomAttributes = "";

                // date_Paid
                date_Paid.ViewValue = date_Paid.CurrentValue;
                date_Paid.ViewValue = FormatDateTime(date_Paid.ViewValue, date_Paid.FormatPattern);
                date_Paid.ViewCustomAttributes = "";

                // str_ApprovalCode
                str_ApprovalCode.ViewValue = ConvertToString(str_ApprovalCode.CurrentValue); // DN
                str_ApprovalCode.ViewCustomAttributes = "";

                // Payment_Number
                Payment_Number.ViewValue = Payment_Number.CurrentValue;
                Payment_Number.ViewValue = FormatNumber(Payment_Number.ViewValue, Payment_Number.FormatPattern);
                Payment_Number.CellCssStyle += "text-align: center;";
                Payment_Number.ViewCustomAttributes = "";

                // Pricelist
                Pricelist.ViewValue = Pricelist.CurrentValue;
                Pricelist.ViewValue = FormatNumber(Pricelist.ViewValue, Pricelist.FormatPattern);
                Pricelist.CellCssStyle += "text-align: right;";
                Pricelist.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // str_Amount
                str_Amount.ViewValue = ConvertToString(str_Amount.CurrentValue); // DN
                str_Amount.ViewCustomAttributes = "";

                // str_CC_Holder_Name
                str_CC_Holder_Name.ViewValue = ConvertToString(str_CC_Holder_Name.CurrentValue); // DN
                str_CC_Holder_Name.ViewCustomAttributes = "";

                // str_CC_Number
                str_CC_Number.ViewValue = ConvertToString(str_CC_Number.CurrentValue); // DN
                str_CC_Number.ViewCustomAttributes = "";

                // int_CC_ExpMonth
                int_CC_ExpMonth.ViewValue = int_CC_ExpMonth.CurrentValue;
                int_CC_ExpMonth.ViewValue = FormatNumber(int_CC_ExpMonth.ViewValue, int_CC_ExpMonth.FormatPattern);
                int_CC_ExpMonth.ViewCustomAttributes = "";

                // int_CC_ExpYear
                int_CC_ExpYear.ViewValue = int_CC_ExpYear.CurrentValue;
                int_CC_ExpYear.ViewValue = FormatNumber(int_CC_ExpYear.ViewValue, int_CC_ExpYear.FormatPattern);
                int_CC_ExpYear.ViewCustomAttributes = "";

                // int_CC_Type
                int_CC_Type.ViewValue = int_CC_Type.CurrentValue;
                int_CC_Type.ViewValue = FormatNumber(int_CC_Type.ViewValue, int_CC_Type.FormatPattern);
                int_CC_Type.ViewCustomAttributes = "";

                // str_Card_Id
                str_Card_Id.ViewValue = ConvertToString(str_Card_Id.CurrentValue); // DN
                str_Card_Id.ViewCustomAttributes = "";

                // str_CC_ValidationNum
                str_CC_ValidationNum.ViewValue = ConvertToString(str_CC_ValidationNum.CurrentValue); // DN
                str_CC_ValidationNum.ViewCustomAttributes = "";

                // str_reference
                str_reference.ViewValue = ConvertToString(str_reference.CurrentValue); // DN
                str_reference.ViewCustomAttributes = "";

                // str_Amount_Pay
                str_Amount_Pay.ViewValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
                str_Amount_Pay.CellCssStyle += "text-align: right;";
                str_Amount_Pay.ViewCustomAttributes = "";

                // mny_Running_Payments
                mny_Running_Payments.ViewValue = mny_Running_Payments.CurrentValue;
                mny_Running_Payments.ViewValue = FormatNumber(mny_Running_Payments.ViewValue, mny_Running_Payments.FormatPattern);
                mny_Running_Payments.CellCssStyle += "text-align: right;";
                mny_Running_Payments.ViewCustomAttributes = "";

                // mny_Running_Balance
                mny_Running_Balance.ViewValue = mny_Running_Balance.CurrentValue;
                mny_Running_Balance.ViewValue = FormatNumber(mny_Running_Balance.ViewValue, mny_Running_Balance.FormatPattern);
                mny_Running_Balance.CellCssStyle += "text-align: right;";
                mny_Running_Balance.ViewCustomAttributes = "";

                // str_Payment_Reference
                str_Payment_Reference.ViewValue = ConvertToString(str_Payment_Reference.CurrentValue); // DN
                str_Payment_Reference.ViewCustomAttributes = "";

                // int_Accepted_By
                int_Accepted_By.ViewValue = int_Accepted_By.CurrentValue;
                int_Accepted_By.ViewValue = FormatNumber(int_Accepted_By.ViewValue, int_Accepted_By.FormatPattern);
                int_Accepted_By.ViewCustomAttributes = "";

                // str_Check_Number
                str_Check_Number.ViewValue = ConvertToString(str_Check_Number.CurrentValue); // DN
                str_Check_Number.ViewCustomAttributes = "";

                // bit_Is_Check_Deposited
                if (ConvertToBool(bit_Is_Check_Deposited.CurrentValue)) {
                    bit_Is_Check_Deposited.ViewValue = bit_Is_Check_Deposited.TagCaption(1) != "" ? bit_Is_Check_Deposited.TagCaption(1) : "Yes";
                } else {
                    bit_Is_Check_Deposited.ViewValue = bit_Is_Check_Deposited.TagCaption(2) != "" ? bit_Is_Check_Deposited.TagCaption(2) : "No";
                }
                bit_Is_Check_Deposited.ViewCustomAttributes = "";

                // str_Adjustment_Type
                str_Adjustment_Type.ViewValue = ConvertToString(str_Adjustment_Type.CurrentValue); // DN
                str_Adjustment_Type.ViewCustomAttributes = "";

                // str_Adjust_Sub_Type
                str_Adjust_Sub_Type.ViewValue = ConvertToString(str_Adjust_Sub_Type.CurrentValue); // DN
                str_Adjust_Sub_Type.ViewCustomAttributes = "";

                // bit_Archive
                if (ConvertToBool(bit_Archive.CurrentValue)) {
                    bit_Archive.ViewValue = bit_Archive.TagCaption(1) != "" ? bit_Archive.TagCaption(1) : "Yes";
                } else {
                    bit_Archive.ViewValue = bit_Archive.TagCaption(2) != "" ? bit_Archive.TagCaption(2) : "No";
                }
                bit_Archive.ViewCustomAttributes = "";

                // int_Created_By
                int_Created_By.ViewValue = int_Created_By.CurrentValue;
                int_Created_By.ViewValue = FormatNumber(int_Created_By.ViewValue, int_Created_By.FormatPattern);
                int_Created_By.ViewCustomAttributes = "";

                // int_Modified_By
                int_Modified_By.ViewValue = int_Modified_By.CurrentValue;
                int_Modified_By.ViewValue = FormatNumber(int_Modified_By.ViewValue, int_Modified_By.FormatPattern);
                int_Modified_By.ViewCustomAttributes = "";

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

                // str_CardHolder_Address
                str_CardHolder_Address.ViewValue = ConvertToString(str_CardHolder_Address.CurrentValue); // DN
                str_CardHolder_Address.ViewCustomAttributes = "";

                // str_CH_City
                str_CH_City.ViewValue = ConvertToString(str_CH_City.CurrentValue); // DN
                str_CH_City.ViewCustomAttributes = "";

                // str_CH_Zip
                str_CH_Zip.ViewValue = ConvertToString(str_CH_Zip.CurrentValue); // DN
                str_CH_Zip.ViewCustomAttributes = "";

                // int_State
                int_State.ViewValue = int_State.CurrentValue;
                int_State.ViewValue = FormatNumber(int_State.ViewValue, int_State.FormatPattern);
                int_State.ViewCustomAttributes = "";

                // bit_IsAuthDotNet
                if (ConvertToBool(bit_IsAuthDotNet.CurrentValue)) {
                    bit_IsAuthDotNet.ViewValue = bit_IsAuthDotNet.TagCaption(1) != "" ? bit_IsAuthDotNet.TagCaption(1) : "Yes";
                } else {
                    bit_IsAuthDotNet.ViewValue = bit_IsAuthDotNet.TagCaption(2) != "" ? bit_IsAuthDotNet.TagCaption(2) : "No";
                }
                bit_IsAuthDotNet.ViewCustomAttributes = "";

                // bit_IsRefund
                if (ConvertToBool(bit_IsRefund.CurrentValue)) {
                    bit_IsRefund.ViewValue = bit_IsRefund.TagCaption(1) != "" ? bit_IsRefund.TagCaption(1) : "Yes";
                } else {
                    bit_IsRefund.ViewValue = bit_IsRefund.TagCaption(2) != "" ? bit_IsRefund.TagCaption(2) : "No";
                }
                bit_IsRefund.ViewCustomAttributes = "";

                // str_Receipt
                str_Receipt.ViewValue = ConvertToString(str_Receipt.CurrentValue); // DN
                str_Receipt.ViewCustomAttributes = "";

                // str_TransactionNumber
                str_TransactionNumber.ViewValue = ConvertToString(str_TransactionNumber.CurrentValue); // DN
                str_TransactionNumber.ViewCustomAttributes = "";

                // str_OrderId
                str_OrderId.ViewValue = ConvertToString(str_OrderId.CurrentValue); // DN
                str_OrderId.ViewCustomAttributes = "";

                // str_TransactionTime
                str_TransactionTime.ViewValue = str_TransactionTime.CurrentValue;
                str_TransactionTime.ViewCustomAttributes = "";

                // int_Location_Id
                int_Location_Id.ViewValue = int_Location_Id.CurrentValue;
                int_Location_Id.ViewValue = FormatNumber(int_Location_Id.ViewValue, int_Location_Id.FormatPattern);
                int_Location_Id.ViewCustomAttributes = "";

                // str_Enrollment_Id
                str_Enrollment_Id.ViewValue = ConvertToString(str_Enrollment_Id.CurrentValue); // DN
                str_Enrollment_Id.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // str_Payment_Note
                str_Payment_Note.ViewValue = str_Payment_Note.CurrentValue;
                str_Payment_Note.ViewCustomAttributes = "";

                // int_Package_ID
                curVal = ConvertToString(int_Package_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Package_ID.Lookup != null && IsDictionary(int_Package_ID.Lookup?.Options) && int_Package_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Package_ID.ViewValue = int_Package_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_Package_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Package_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Package_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Package_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Package_ID.ViewValue = int_Package_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Package_ID.DisplayValue(listwrk));
                        } else {
                            int_Package_ID.ViewValue = FormatNumber(int_Package_ID.CurrentValue, int_Package_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Package_ID.ViewValue = DbNullValue;
                }
                int_Package_ID.ViewCustomAttributes = "";

                // Package_Name
                Package_Name.ViewValue = ConvertToString(Package_Name.CurrentValue); // DN
                curVal = ConvertToString(Package_Name.CurrentValue);
                if (!Empty(curVal)) {
                    if (Package_Name.Lookup != null && IsDictionary(Package_Name.Lookup?.Options) && Package_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Package_Name.ViewValue = Package_Name.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Package_Name]", "=", Package_Name.CurrentValue, DataType.String, "");
                        sqlWrk = Package_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Package_Name.Lookup != null) { // Lookup values found
                            var listwrk = Package_Name.Lookup?.RenderViewRow(rswrk[0]);
                            Package_Name.ViewValue = Package_Name.HighlightLookup(ConvertToString(rswrk[0]), Package_Name.DisplayValue(listwrk));
                        } else {
                            Package_Name.ViewValue = Package_Name.CurrentValue;
                        }
                    }
                } else {
                    Package_Name.ViewValue = DbNullValue;
                }
                Package_Name.ViewCustomAttributes = "";

                // Price
                curVal = ConvertToString(Price.CurrentValue);
                if (!Empty(curVal)) {
                    if (Price.Lookup != null && IsDictionary(Price.Lookup?.Options) && Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Price.ViewValue = Price.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[mny_Price]", "=", Price.CurrentValue, DataType.Number, "");
                        sqlWrk = Price.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Price.Lookup != null) { // Lookup values found
                            var listwrk = Price.Lookup?.RenderViewRow(rswrk[0]);
                            Price.ViewValue = Price.HighlightLookup(ConvertToString(rswrk[0]), Price.DisplayValue(listwrk));
                        } else {
                            Price.ViewValue = FormatCurrency(Price.CurrentValue, Price.FormatPattern);
                        }
                    }
                } else {
                    Price.ViewValue = DbNullValue;
                }
                Price.ViewCustomAttributes = "";

                // AssessmentID
                AssessmentID.ViewValue = AssessmentID.CurrentValue;
                AssessmentID.ViewValue = FormatNumber(AssessmentID.ViewValue, AssessmentID.FormatPattern);
                AssessmentID.ViewCustomAttributes = "";

                // course
                course.ViewValue = ConvertToString(course.CurrentValue); // DN
                course.ViewCustomAttributes = "";

                // institution
                institution.ViewValue = ConvertToString(institution.CurrentValue); // DN
                institution.ViewCustomAttributes = "";

                // UniqueIdx
                UniqueIdx.ViewValue = ConvertToString(UniqueIdx.CurrentValue); // DN
                UniqueIdx.ViewCustomAttributes = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // int_Student_ID
                int_Student_ID.HrefValue = "";

                // int_Payment_Method
                int_Payment_Method.HrefValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

                // date_Created
                date_Created.HrefValue = "";

                // str_Amount
                str_Amount.HrefValue = "";

                // str_CC_Holder_Name
                str_CC_Holder_Name.HrefValue = "";

                // str_CC_Number
                str_CC_Number.HrefValue = "";

                // int_CC_ExpMonth
                int_CC_ExpMonth.HrefValue = "";

                // int_CC_ExpYear
                int_CC_ExpYear.HrefValue = "";

                // int_CC_Type
                int_CC_Type.HrefValue = "";

                // str_Card_Id
                str_Card_Id.HrefValue = "";

                // str_CC_ValidationNum
                str_CC_ValidationNum.HrefValue = "";

                // str_reference
                str_reference.HrefValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";

                // str_Payment_Reference
                str_Payment_Reference.HrefValue = "";

                // bit_IsRefund
                bit_IsRefund.HrefValue = "";

                // str_TransactionTime
                str_TransactionTime.HrefValue = "";

                // str_Payment_Note
                str_Payment_Note.HrefValue = "";

                // int_Package_ID
                int_Package_ID.HrefValue = "";

                // Package_Name
                Package_Name.HrefValue = "";
                Package_Name.TooltipValue = "";

                // Price
                Price.HrefValue = "";
                Price.TooltipValue = "";
            } else if (RowType == RowType.Add) {
                // NationalID
                NationalID.SetupEditAttributes();
                if (!Empty(NationalID.SessionValue)) {
                    NationalID.CurrentValue = ForeignKeyValue(NationalID.SessionValue);
                    curVal = ConvertToString(NationalID.CurrentValue);
                    if (!Empty(curVal)) {
                        if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                            NationalID.ViewValue = NationalID.LookupCacheOption(curVal);
                        } else { // Lookup from database // DN
                            filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                            sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                            rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                            if (rswrk?.Count > 0 && NationalID.Lookup != null) { // Lookup values found
                                var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                                NationalID.ViewValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                            } else {
                                NationalID.ViewValue = NationalID.CurrentValue;
                            }
                        }
                    } else {
                        NationalID.ViewValue = DbNullValue;
                    }
                    NationalID.ViewCustomAttributes = "";
                } else {
                    curVal = ConvertToString(NationalID.CurrentValue)?.Trim() ?? "";
                    if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        NationalID.EditValue = NationalID.Lookup?.Options.Values.ToList();
                    } else { // Lookup from database
                        if (curVal == "") {
                            filterWrk = "0=1";
                        } else {
                            filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                        }
                        sqlWrk = NationalID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        NationalID.EditValue = rswrk;
                    }
                    NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                }

                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.CurrentValue = HtmlDecode(str_First_Name.CurrentValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.CurrentValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.CurrentValue = HtmlDecode(str_Last_Name.CurrentValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.CurrentValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("add")) { // Non system admin
                    str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
                    if (Empty(str_Username.CurrentValue)) {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = str_Username.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                        rswrk = sqlWrk != null ? await Connection.GetRowsAsync(sqlWrk) : null;
                    str_Username.EditValue = rswrk;
                } else {
                    curVal = ConvertToString(str_Username.CurrentValue)?.Trim() ?? "";
                    if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Username.EditValue = str_Username.Lookup?.Options.Values.ToList();
                    } else { // Lookup from database
                        if (curVal == "") {
                            filterWrk = "0=1";
                        } else {
                            filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                        }
                        sqlWrk = str_Username.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        str_Username.EditValue = rswrk;
                    }
                    str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
                }

                // int_Student_ID
                int_Student_ID.SetupEditAttributes();
                curVal = ConvertToString(int_Student_ID.CurrentValue)?.Trim() ?? "";
                if (int_Student_ID.Lookup != null && IsDictionary(int_Student_ID.Lookup?.Options) && int_Student_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Student_ID.EditValue = int_Student_ID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Student_ID]", "=", int_Student_ID.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_Student_ID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Student_ID.EditValue = rswrk;
                }
                int_Student_ID.PlaceHolder = RemoveHtml(int_Student_ID.Caption);
                if (!Empty(int_Student_ID.EditValue) && IsNumeric(int_Student_ID.EditValue))
                    int_Student_ID.EditValue = FormatNumber(int_Student_ID.EditValue, null);

                // int_Payment_Method
                int_Payment_Method.SetupEditAttributes();
                int_Payment_Method.EditValue = int_Payment_Method.Options(true);
                int_Payment_Method.PlaceHolder = RemoveHtml(int_Payment_Method.Caption);
                if (!Empty(int_Payment_Method.EditValue) && IsNumeric(int_Payment_Method.EditValue))
                    int_Payment_Method.EditValue = FormatNumber(int_Payment_Method.EditValue, null);

                // date_Paid
                date_Paid.SetupEditAttributes();
                date_Paid.EditValue = FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern); // DN
                date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

                // str_ApprovalCode
                str_ApprovalCode.SetupEditAttributes();
                if (!str_ApprovalCode.Raw)
                    str_ApprovalCode.CurrentValue = HtmlDecode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

                // date_Created

                // str_Amount
                str_Amount.SetupEditAttributes();
                if (!str_Amount.Raw)
                    str_Amount.CurrentValue = HtmlDecode(str_Amount.CurrentValue);
                str_Amount.EditValue = HtmlEncode(str_Amount.CurrentValue);
                str_Amount.PlaceHolder = RemoveHtml(str_Amount.Caption);

                // str_CC_Holder_Name
                str_CC_Holder_Name.SetupEditAttributes();
                if (!str_CC_Holder_Name.Raw)
                    str_CC_Holder_Name.CurrentValue = HtmlDecode(str_CC_Holder_Name.CurrentValue);
                str_CC_Holder_Name.EditValue = HtmlEncode(str_CC_Holder_Name.CurrentValue);
                str_CC_Holder_Name.PlaceHolder = RemoveHtml(str_CC_Holder_Name.Caption);

                // str_CC_Number
                str_CC_Number.SetupEditAttributes();
                if (!str_CC_Number.Raw)
                    str_CC_Number.CurrentValue = HtmlDecode(str_CC_Number.CurrentValue);
                str_CC_Number.EditValue = HtmlEncode(str_CC_Number.CurrentValue);
                str_CC_Number.PlaceHolder = RemoveHtml(str_CC_Number.Caption);

                // int_CC_ExpMonth
                int_CC_ExpMonth.SetupEditAttributes();
                int_CC_ExpMonth.EditValue = int_CC_ExpMonth.CurrentValue; // DN
                int_CC_ExpMonth.PlaceHolder = RemoveHtml(int_CC_ExpMonth.Caption);
                if (!Empty(int_CC_ExpMonth.EditValue) && IsNumeric(int_CC_ExpMonth.EditValue))
                    int_CC_ExpMonth.EditValue = FormatNumber(int_CC_ExpMonth.EditValue, null);

                // int_CC_ExpYear
                int_CC_ExpYear.SetupEditAttributes();
                int_CC_ExpYear.EditValue = int_CC_ExpYear.CurrentValue; // DN
                int_CC_ExpYear.PlaceHolder = RemoveHtml(int_CC_ExpYear.Caption);
                if (!Empty(int_CC_ExpYear.EditValue) && IsNumeric(int_CC_ExpYear.EditValue))
                    int_CC_ExpYear.EditValue = FormatNumber(int_CC_ExpYear.EditValue, null);

                // int_CC_Type
                int_CC_Type.SetupEditAttributes();
                int_CC_Type.EditValue = int_CC_Type.CurrentValue; // DN
                int_CC_Type.PlaceHolder = RemoveHtml(int_CC_Type.Caption);
                if (!Empty(int_CC_Type.EditValue) && IsNumeric(int_CC_Type.EditValue))
                    int_CC_Type.EditValue = FormatNumber(int_CC_Type.EditValue, null);

                // str_Card_Id
                str_Card_Id.SetupEditAttributes();
                if (!str_Card_Id.Raw)
                    str_Card_Id.CurrentValue = HtmlDecode(str_Card_Id.CurrentValue);
                str_Card_Id.EditValue = HtmlEncode(str_Card_Id.CurrentValue);
                str_Card_Id.PlaceHolder = RemoveHtml(str_Card_Id.Caption);

                // str_CC_ValidationNum
                str_CC_ValidationNum.SetupEditAttributes();
                if (!str_CC_ValidationNum.Raw)
                    str_CC_ValidationNum.CurrentValue = HtmlDecode(str_CC_ValidationNum.CurrentValue);
                str_CC_ValidationNum.EditValue = HtmlEncode(str_CC_ValidationNum.CurrentValue);
                str_CC_ValidationNum.PlaceHolder = RemoveHtml(str_CC_ValidationNum.Caption);

                // str_reference
                str_reference.SetupEditAttributes();
                if (!str_reference.Raw)
                    str_reference.CurrentValue = HtmlDecode(str_reference.CurrentValue);
                str_reference.EditValue = HtmlEncode(str_reference.CurrentValue);
                str_reference.PlaceHolder = RemoveHtml(str_reference.Caption);

                // str_Amount_Pay
                str_Amount_Pay.SetupEditAttributes();
                if (!str_Amount_Pay.Raw)
                    str_Amount_Pay.CurrentValue = HtmlDecode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

                // str_Payment_Reference
                str_Payment_Reference.SetupEditAttributes();
                if (!str_Payment_Reference.Raw)
                    str_Payment_Reference.CurrentValue = HtmlDecode(str_Payment_Reference.CurrentValue);
                str_Payment_Reference.EditValue = HtmlEncode(str_Payment_Reference.CurrentValue);
                str_Payment_Reference.PlaceHolder = RemoveHtml(str_Payment_Reference.Caption);

                // bit_IsRefund
                bit_IsRefund.EditValue = bit_IsRefund.Options(false);
                bit_IsRefund.PlaceHolder = RemoveHtml(bit_IsRefund.Caption);

                // str_TransactionTime

                // str_Payment_Note
                str_Payment_Note.SetupEditAttributes();
                str_Payment_Note.EditValue = str_Payment_Note.CurrentValue; // DN
                str_Payment_Note.PlaceHolder = RemoveHtml(str_Payment_Note.Caption);

                // int_Package_ID
                int_Package_ID.SetupEditAttributes();
                curVal = ConvertToString(int_Package_ID.CurrentValue)?.Trim() ?? "";
                if (int_Package_ID.Lookup != null && IsDictionary(int_Package_ID.Lookup?.Options) && int_Package_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Package_ID.EditValue = int_Package_ID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_Package_ID.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_Package_ID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Package_ID.EditValue = rswrk;
                }
                int_Package_ID.PlaceHolder = RemoveHtml(int_Package_ID.Caption);
                if (!Empty(int_Package_ID.EditValue) && IsNumeric(int_Package_ID.EditValue))
                    int_Package_ID.EditValue = FormatNumber(int_Package_ID.EditValue, null);

                // Package_Name
                Package_Name.SetupEditAttributes();
                if (!Package_Name.Raw)
                    Package_Name.CurrentValue = HtmlDecode(Package_Name.CurrentValue);
                Package_Name.EditValue = HtmlEncode(Package_Name.CurrentValue);
                curVal = ConvertToString(Package_Name.CurrentValue);
                if (!Empty(curVal)) {
                    if (Package_Name.Lookup != null && IsDictionary(Package_Name.Lookup?.Options) && Package_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Package_Name.EditValue = Package_Name.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Package_Name]", "=", Package_Name.CurrentValue, DataType.String, "");
                        sqlWrk = Package_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Package_Name.Lookup != null) { // Lookup values found
                            var listwrk = Package_Name.Lookup?.RenderViewRow(rswrk[0]);
                            Package_Name.EditValue = Package_Name.HighlightLookup(ConvertToString(rswrk[0]), Package_Name.DisplayValue(listwrk));
                        } else {
                            Package_Name.EditValue = HtmlEncode(Package_Name.CurrentValue);
                        }
                    }
                } else {
                    Package_Name.EditValue = DbNullValue;
                }
                Package_Name.PlaceHolder = RemoveHtml(Package_Name.Caption);

                // Price
                Price.SetupEditAttributes();
                curVal = ConvertToString(Price.CurrentValue)?.Trim() ?? "";
                if (Price.Lookup != null && IsDictionary(Price.Lookup?.Options) && Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Price.EditValue = Price.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[mny_Price]", "=", Price.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = Price.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    Price.EditValue = rswrk;
                }
                Price.PlaceHolder = RemoveHtml(Price.Caption);
                if (!Empty(Price.EditValue) && IsNumeric(Price.EditValue))
                    Price.EditValue = FormatNumber(Price.EditValue, null);

                // Add refer script

                // NationalID
                NationalID.HrefValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // int_Student_ID
                int_Student_ID.HrefValue = "";

                // int_Payment_Method
                int_Payment_Method.HrefValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

                // date_Created
                date_Created.HrefValue = "";

                // str_Amount
                str_Amount.HrefValue = "";

                // str_CC_Holder_Name
                str_CC_Holder_Name.HrefValue = "";

                // str_CC_Number
                str_CC_Number.HrefValue = "";

                // int_CC_ExpMonth
                int_CC_ExpMonth.HrefValue = "";

                // int_CC_ExpYear
                int_CC_ExpYear.HrefValue = "";

                // int_CC_Type
                int_CC_Type.HrefValue = "";

                // str_Card_Id
                str_Card_Id.HrefValue = "";

                // str_CC_ValidationNum
                str_CC_ValidationNum.HrefValue = "";

                // str_reference
                str_reference.HrefValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";

                // str_Payment_Reference
                str_Payment_Reference.HrefValue = "";

                // bit_IsRefund
                bit_IsRefund.HrefValue = "";

                // str_TransactionTime
                str_TransactionTime.HrefValue = "";

                // str_Payment_Note
                str_Payment_Note.HrefValue = "";

                // int_Package_ID
                int_Package_ID.HrefValue = "";

                // Package_Name
                Package_Name.HrefValue = "";

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
            if (NationalID.Required) {
                if (!NationalID.IsDetailKey && Empty(NationalID.FormValue)) {
                    NationalID.AddErrorMessage(ConvertToString(NationalID.RequiredErrorMessage).Replace("%s", NationalID.Caption));
                }
            }
            if (str_First_Name.Required) {
                if (!str_First_Name.IsDetailKey && Empty(str_First_Name.FormValue)) {
                    str_First_Name.AddErrorMessage(ConvertToString(str_First_Name.RequiredErrorMessage).Replace("%s", str_First_Name.Caption));
                }
            }
            if (str_Last_Name.Required) {
                if (!str_Last_Name.IsDetailKey && Empty(str_Last_Name.FormValue)) {
                    str_Last_Name.AddErrorMessage(ConvertToString(str_Last_Name.RequiredErrorMessage).Replace("%s", str_Last_Name.Caption));
                }
            }
            if (str_Username.Required) {
                if (!str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (int_Student_ID.Required) {
                if (!int_Student_ID.IsDetailKey && Empty(int_Student_ID.FormValue)) {
                    int_Student_ID.AddErrorMessage(ConvertToString(int_Student_ID.RequiredErrorMessage).Replace("%s", int_Student_ID.Caption));
                }
            }
            if (int_Payment_Method.Required) {
                if (!int_Payment_Method.IsDetailKey && Empty(int_Payment_Method.FormValue)) {
                    int_Payment_Method.AddErrorMessage(ConvertToString(int_Payment_Method.RequiredErrorMessage).Replace("%s", int_Payment_Method.Caption));
                }
            }
            if (date_Paid.Required) {
                if (!date_Paid.IsDetailKey && Empty(date_Paid.FormValue)) {
                    date_Paid.AddErrorMessage(ConvertToString(date_Paid.RequiredErrorMessage).Replace("%s", date_Paid.Caption));
                }
            }
            if (!CheckDate(date_Paid.FormValue, date_Paid.FormatPattern)) {
                date_Paid.AddErrorMessage(date_Paid.GetErrorMessage(false));
            }
            if (str_ApprovalCode.Required) {
                if (!str_ApprovalCode.IsDetailKey && Empty(str_ApprovalCode.FormValue)) {
                    str_ApprovalCode.AddErrorMessage(ConvertToString(str_ApprovalCode.RequiredErrorMessage).Replace("%s", str_ApprovalCode.Caption));
                }
            }
            if (date_Created.Required) {
                if (!date_Created.IsDetailKey && Empty(date_Created.FormValue)) {
                    date_Created.AddErrorMessage(ConvertToString(date_Created.RequiredErrorMessage).Replace("%s", date_Created.Caption));
                }
            }
            if (str_Amount.Required) {
                if (!str_Amount.IsDetailKey && Empty(str_Amount.FormValue)) {
                    str_Amount.AddErrorMessage(ConvertToString(str_Amount.RequiredErrorMessage).Replace("%s", str_Amount.Caption));
                }
            }
            if (!CheckNumber(str_Amount.FormValue)) {
                str_Amount.AddErrorMessage(str_Amount.GetErrorMessage(false));
            }
            if (str_CC_Holder_Name.Required) {
                if (!str_CC_Holder_Name.IsDetailKey && Empty(str_CC_Holder_Name.FormValue)) {
                    str_CC_Holder_Name.AddErrorMessage(ConvertToString(str_CC_Holder_Name.RequiredErrorMessage).Replace("%s", str_CC_Holder_Name.Caption));
                }
            }
            if (str_CC_Number.Required) {
                if (!str_CC_Number.IsDetailKey && Empty(str_CC_Number.FormValue)) {
                    str_CC_Number.AddErrorMessage(ConvertToString(str_CC_Number.RequiredErrorMessage).Replace("%s", str_CC_Number.Caption));
                }
            }
            if (!CheckCreditCard(str_CC_Number.FormValue)) {
                str_CC_Number.AddErrorMessage(str_CC_Number.GetErrorMessage(false));
            }
            if (int_CC_ExpMonth.Required) {
                if (!int_CC_ExpMonth.IsDetailKey && Empty(int_CC_ExpMonth.FormValue)) {
                    int_CC_ExpMonth.AddErrorMessage(ConvertToString(int_CC_ExpMonth.RequiredErrorMessage).Replace("%s", int_CC_ExpMonth.Caption));
                }
            }
            if (!CheckInteger(int_CC_ExpMonth.FormValue)) {
                int_CC_ExpMonth.AddErrorMessage(int_CC_ExpMonth.GetErrorMessage(false));
            }
            if (int_CC_ExpYear.Required) {
                if (!int_CC_ExpYear.IsDetailKey && Empty(int_CC_ExpYear.FormValue)) {
                    int_CC_ExpYear.AddErrorMessage(ConvertToString(int_CC_ExpYear.RequiredErrorMessage).Replace("%s", int_CC_ExpYear.Caption));
                }
            }
            if (!CheckInteger(int_CC_ExpYear.FormValue)) {
                int_CC_ExpYear.AddErrorMessage(int_CC_ExpYear.GetErrorMessage(false));
            }
            if (int_CC_Type.Required) {
                if (!int_CC_Type.IsDetailKey && Empty(int_CC_Type.FormValue)) {
                    int_CC_Type.AddErrorMessage(ConvertToString(int_CC_Type.RequiredErrorMessage).Replace("%s", int_CC_Type.Caption));
                }
            }
            if (!CheckInteger(int_CC_Type.FormValue)) {
                int_CC_Type.AddErrorMessage(int_CC_Type.GetErrorMessage(false));
            }
            if (str_Card_Id.Required) {
                if (!str_Card_Id.IsDetailKey && Empty(str_Card_Id.FormValue)) {
                    str_Card_Id.AddErrorMessage(ConvertToString(str_Card_Id.RequiredErrorMessage).Replace("%s", str_Card_Id.Caption));
                }
            }
            if (str_CC_ValidationNum.Required) {
                if (!str_CC_ValidationNum.IsDetailKey && Empty(str_CC_ValidationNum.FormValue)) {
                    str_CC_ValidationNum.AddErrorMessage(ConvertToString(str_CC_ValidationNum.RequiredErrorMessage).Replace("%s", str_CC_ValidationNum.Caption));
                }
            }
            if (str_reference.Required) {
                if (!str_reference.IsDetailKey && Empty(str_reference.FormValue)) {
                    str_reference.AddErrorMessage(ConvertToString(str_reference.RequiredErrorMessage).Replace("%s", str_reference.Caption));
                }
            }
            if (str_Amount_Pay.Required) {
                if (!str_Amount_Pay.IsDetailKey && Empty(str_Amount_Pay.FormValue)) {
                    str_Amount_Pay.AddErrorMessage(ConvertToString(str_Amount_Pay.RequiredErrorMessage).Replace("%s", str_Amount_Pay.Caption));
                }
            }
            if (str_Payment_Reference.Required) {
                if (!str_Payment_Reference.IsDetailKey && Empty(str_Payment_Reference.FormValue)) {
                    str_Payment_Reference.AddErrorMessage(ConvertToString(str_Payment_Reference.RequiredErrorMessage).Replace("%s", str_Payment_Reference.Caption));
                }
            }
            if (bit_IsRefund.Required) {
                if (Empty(bit_IsRefund.FormValue)) {
                    bit_IsRefund.AddErrorMessage(ConvertToString(bit_IsRefund.RequiredErrorMessage).Replace("%s", bit_IsRefund.Caption));
                }
            }
            if (str_TransactionTime.Required) {
                if (!str_TransactionTime.IsDetailKey && Empty(str_TransactionTime.FormValue)) {
                    str_TransactionTime.AddErrorMessage(ConvertToString(str_TransactionTime.RequiredErrorMessage).Replace("%s", str_TransactionTime.Caption));
                }
            }
            if (str_Payment_Note.Required) {
                if (!str_Payment_Note.IsDetailKey && Empty(str_Payment_Note.FormValue)) {
                    str_Payment_Note.AddErrorMessage(ConvertToString(str_Payment_Note.RequiredErrorMessage).Replace("%s", str_Payment_Note.Caption));
                }
            }
            if (int_Package_ID.Required) {
                if (!int_Package_ID.IsDetailKey && Empty(int_Package_ID.FormValue)) {
                    int_Package_ID.AddErrorMessage(ConvertToString(int_Package_ID.RequiredErrorMessage).Replace("%s", int_Package_ID.Caption));
                }
            }
            if (Package_Name.Required) {
                if (!Package_Name.IsDetailKey && Empty(Package_Name.FormValue)) {
                    Package_Name.AddErrorMessage(ConvertToString(Package_Name.RequiredErrorMessage).Replace("%s", Package_Name.Caption));
                }
            }
            if (Price.Required) {
                if (!Price.IsDetailKey && Empty(Price.FormValue)) {
                    Price.AddErrorMessage(ConvertToString(Price.RequiredErrorMessage).Replace("%s", Price.Caption));
                }
            }

            // Validate detail grid
            var detailTblVar = CurrentDetailTables;
            if (detailTblVar.Contains("tblStudentEnrollment") && tblStudentEnrollment?.DetailAdd == true) {
                tblStudentEnrollmentGrid = Resolve("TblStudentEnrollmentGrid")!; // Get detail page object
                if (tblStudentEnrollmentGrid != null)
                    validateForm = validateForm && await tblStudentEnrollmentGrid.ValidateGridForm();
            }
            if (detailTblVar.Contains("qryBillingDetails_v2") && qryBillingDetailsV2?.DetailAdd == true) {
                qryBillingDetailsV2Grid = Resolve("QryBillingDetailsV2Grid")!; // Get detail page object
                if (qryBillingDetailsV2Grid != null)
                    validateForm = validateForm && await qryBillingDetailsV2Grid.ValidateGridForm();
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
                // NationalID
                NationalID.SetDbValue(rsnew, NationalID.CurrentValue);

                // str_First_Name
                str_First_Name.SetDbValue(rsnew, str_First_Name.CurrentValue);

                // str_Last_Name
                str_Last_Name.SetDbValue(rsnew, str_Last_Name.CurrentValue);

                // str_Username
                str_Username.SetDbValue(rsnew, str_Username.CurrentValue);

                // int_Student_ID
                int_Student_ID.SetDbValue(rsnew, int_Student_ID.CurrentValue);

                // int_Payment_Method
                int_Payment_Method.SetDbValue(rsnew, int_Payment_Method.CurrentValue);

                // date_Paid
                date_Paid.SetDbValue(rsnew, ConvertToDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern));

                // str_ApprovalCode
                str_ApprovalCode.SetDbValue(rsnew, str_ApprovalCode.CurrentValue);

                // date_Created
                date_Created.CurrentValue = date_Created.GetAutoUpdateValue();
                date_Created.SetDbValue(rsnew, date_Created.CurrentValue, false);

                // str_Amount
                str_Amount.SetDbValue(rsnew, str_Amount.CurrentValue);

                // str_CC_Holder_Name
                str_CC_Holder_Name.SetDbValue(rsnew, str_CC_Holder_Name.CurrentValue);

                // str_CC_Number
                str_CC_Number.SetDbValue(rsnew, str_CC_Number.CurrentValue);

                // int_CC_ExpMonth
                int_CC_ExpMonth.SetDbValue(rsnew, int_CC_ExpMonth.CurrentValue);

                // int_CC_ExpYear
                int_CC_ExpYear.SetDbValue(rsnew, int_CC_ExpYear.CurrentValue);

                // int_CC_Type
                int_CC_Type.SetDbValue(rsnew, int_CC_Type.CurrentValue);

                // str_Card_Id
                str_Card_Id.SetDbValue(rsnew, str_Card_Id.CurrentValue);

                // str_CC_ValidationNum
                str_CC_ValidationNum.SetDbValue(rsnew, str_CC_ValidationNum.CurrentValue);

                // str_reference
                str_reference.SetDbValue(rsnew, str_reference.CurrentValue);

                // str_Amount_Pay
                str_Amount_Pay.SetDbValue(rsnew, str_Amount_Pay.CurrentValue);

                // str_Payment_Reference
                str_Payment_Reference.SetDbValue(rsnew, str_Payment_Reference.CurrentValue);

                // bit_IsRefund
                bit_IsRefund.SetDbValue(rsnew, ConvertToBool(bit_IsRefund.CurrentValue));

                // str_TransactionTime
                str_TransactionTime.CurrentValue = str_TransactionTime.GetAutoUpdateValue();
                str_TransactionTime.SetDbValue(rsnew, str_TransactionTime.CurrentValue, false);

                // str_Payment_Note
                str_Payment_Note.SetDbValue(rsnew, str_Payment_Note.CurrentValue);

                // int_Package_ID
                int_Package_ID.SetDbValue(rsnew, int_Package_ID.CurrentValue);

                // Package_Name
                Package_Name.SetDbValue(rsnew, Package_Name.CurrentValue);

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
            string? masterFilter;
            Dictionary<string, object?> detailKeys;

            // Check if valid key values for master user
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin) { // Non system admin
                detailKeys = new ();
                detailKeys.Add("NationalID", NationalID.CurrentValue);
                masterFilter = MasterFilter(tblPotentialStudentInfo, detailKeys); // DN
                if (!Empty(masterFilter) && tblPotentialStudentInfo != null) {
                    bool validMasterKey = true;
                    using var rsmaster = await tblPotentialStudentInfo.LoadReader(masterFilter);
                    if (rsmaster?.HasRows ?? false) { // DN
                        await rsmaster.ReadAsync();
                        validMasterKey = Security.IsValidUserID(rsmaster["str_Username"]);
                    } else if (CurrentMasterTable == "tblPotentialStudentInfo") {
                        validMasterKey = false;
                    }
                    if (!validMasterKey) {
                        string masterUserIdMsg = Language.Phrase("UnAuthorizedMasterUserID").Replace("%c", ConvertToString(Security.CurrentUserID));
                        masterUserIdMsg = masterUserIdMsg.Replace("%f", masterFilter);
                        FailureMessage = masterUserIdMsg;
                        return JsonBoolResult.FalseResult;
                    }
                }
            }
            if (!Empty(str_ApprovalCode.CurrentValue)) { // Check field with unique index
                var filter = "(str_ApprovalCode = '" + AdjustSql(str_ApprovalCode.CurrentValue, DbId) + "')";
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupIndex").Replace("%f", str_ApprovalCode.Caption).Replace("%v", ConvertToString(str_ApprovalCode.CurrentValue));
                    return JsonBoolResult.FalseResult;
                }
            }
            bool validMasterRecord;

            // Begin transaction
            if (!Empty(CurrentDetailTable) && UseTransaction)
                Connection.BeginTrans();

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
                    rsnew["int_Bill_ID"] = int_Bill_ID.CurrentValue!;
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

            // Add detail records
            var detailTblVar = CurrentDetailTables;
            if (detailTblVar.Contains("tblStudentEnrollment") && tblStudentEnrollment?.DetailAdd == true && result) {
                tblStudentEnrollment.NationalID.SessionValue = ConvertToString(NationalID.CurrentValue); // Set master key
                tblStudentEnrollmentGrid = Resolve("TblStudentEnrollmentGrid")!; // Get detail page object
                if (tblStudentEnrollmentGrid != null) {
                    Security.LoadCurrentUserLevel(ProjectID + "tblStudentEnrollment"); // Load user level of detail table
                    result = await tblStudentEnrollmentGrid.GridInsert();
                    Security.LoadCurrentUserLevel(ProjectID + TableName); // Restore user level of master table
                }
            }
            if (detailTblVar.Contains("qryBillingDetails_v2") && qryBillingDetailsV2?.DetailAdd == true && result) {
                qryBillingDetailsV2.NationalID.SessionValue = ConvertToString(NationalID.CurrentValue); // Set master key
                qryBillingDetailsV2Grid = Resolve("QryBillingDetailsV2Grid")!; // Get detail page object
                if (qryBillingDetailsV2Grid != null) {
                    Security.LoadCurrentUserLevel(ProjectID + "qryBillingDetails_v2"); // Load user level of detail table
                    result = await qryBillingDetailsV2Grid.GridInsert();
                    Security.LoadCurrentUserLevel(ProjectID + TableName); // Restore user level of master table
                }
            }

            // Commit/Rollback transaction
            if (!Empty(CurrentDetailTable) && UseTransaction) {
                if (result) {
                    Connection.CommitTrans(); // Commit transaction
                } else {
                    Connection.RollbackTrans(); // Rollback transaction
                }
            }

            // Call Row Inserted event
            if (result)
                RowInserted(rsold, rsnew);
            if (result && SendEmail) {
                var res = await SendEmailOnAdd(rsnew); // DN
                if (res != "OK")
                    FailureMessage = res;
            }

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

        // Show link optionally based on User ID
        protected bool ShowOptionLink(string pageId = "") { // DN
            if (Security.IsLoggedIn && !Security.IsAdmin && !UserIDAllow(pageId))
                return Security.IsValidUserID(str_Username.CurrentValue);
            return true;
        }

        // Set up master/detail based on QueryString
        protected void SetupMasterParms() {
            bool validMaster = false;
            StringValues masterTblVar;
            StringValues fk;
            Dictionary<string, object> foreignKeys = new ();

            // Get the keys for master table
            if (Query.TryGetValue(Config.TableShowMaster, out masterTblVar) || Query.TryGetValue(Config.TableMaster, out masterTblVar)) { // Do not use Get()
                if (Empty(masterTblVar)) {
                    validMaster = true;
                    DbMasterFilter = "";
                    DbDetailFilter = "";
                }
                if (masterTblVar == "tblPotentialStudentInfo") {
                    validMaster = true;
                    if (tblPotentialStudentInfo != null && (Get("fk_NationalID", out fk) || Get("NationalID", out fk))) {
                        tblPotentialStudentInfo.NationalID.QueryValue = fk;
                        NationalID.QueryValue = tblPotentialStudentInfo.NationalID.QueryValue;
                        NationalID.SessionValue = NationalID.QueryValue;
                        foreignKeys.Add("NationalID", fk);
                        if (!IsNumeric(NationalID.QueryValue))
                            validMaster = false;
                    } else {
                        validMaster = false;
                    }
                }
            } else if (Form.TryGetValue(Config.TableShowMaster, out masterTblVar) || Form.TryGetValue(Config.TableMaster, out masterTblVar)) {
                if (masterTblVar == "") {
                    validMaster = true;
                    DbMasterFilter = "";
                    DbDetailFilter = "";
                }
                if (masterTblVar == "tblPotentialStudentInfo") {
                    validMaster = true;
                    if (tblPotentialStudentInfo != null && (Post("fk_NationalID", out fk) || Post("NationalID", out fk))) {
                        tblPotentialStudentInfo.NationalID.FormValue = fk;
                        NationalID.FormValue = tblPotentialStudentInfo.NationalID.FormValue;
                        NationalID.SessionValue = NationalID.FormValue;
                        foreignKeys.Add("NationalID", fk);
                        if (!IsNumeric(NationalID.FormValue))
                            validMaster = false;
                    } else {
                        validMaster = false;
                    }
                }
            }
            if (validMaster) {
                // Save current master table
                CurrentMasterTable = masterTblVar.ToString();

                // Clear previous master key from Session
                if (masterTblVar != "tblPotentialStudentInfo") {
                    if (!foreignKeys.ContainsKey("NationalID")) // Not current foreign key
                        NationalID.SessionValue = "";
                }
            }
            DbMasterFilter = MasterFilterFromSession; // Get master filter from session
            DbDetailFilter = DetailFilterFromSession; // Get detail filter from session
        }

        // Set up detail parms based on QueryString
        protected void SetupDetailParms() {
            StringValues detailTblVar = "";
            // Get the keys for master table
            if (Query.TryGetValue(Config.TableShowDetail, out detailTblVar)) { // Do not use Get()
                CurrentDetailTable = detailTblVar.ToString();
            } else {
                detailTblVar = CurrentDetailTable;
            }
            if (!Empty(detailTblVar)) {
                var detailTblVars = detailTblVar.ToString().Split(',');
                if (detailTblVars.Contains("tblStudentEnrollment")) {
                    tblStudentEnrollmentGrid = Resolve("TblStudentEnrollmentGrid")!;
                    if (tblStudentEnrollmentGrid?.DetailAdd ?? false) {
                        if (CopyRecord)
                            tblStudentEnrollmentGrid.CurrentMode = "copy";
                        else
                            tblStudentEnrollmentGrid.CurrentMode = "add";
                        if (IsConfirm)
                            tblStudentEnrollmentGrid.CurrentAction = "confirm";
                        else
                            tblStudentEnrollmentGrid.CurrentAction = "gridadd";
                        if (IsCancel)
                            tblStudentEnrollmentGrid.EventCancelled = true;

                        // Save current master table to detail table
                        tblStudentEnrollmentGrid.CurrentMasterTable = TableVar;
                        tblStudentEnrollmentGrid.StartRecordNumber = 1;
                        tblStudentEnrollmentGrid.NationalID.IsDetailKey = true;
                        tblStudentEnrollmentGrid.NationalID.CurrentValue = NationalID.CurrentValue;
                        tblStudentEnrollmentGrid.NationalID.SessionValue = tblStudentEnrollmentGrid.NationalID.CurrentValue;
                    }
                }
                if (detailTblVars.Contains("qryBillingDetails_v2")) {
                    qryBillingDetailsV2Grid = Resolve("QryBillingDetailsV2Grid")!;
                    if (qryBillingDetailsV2Grid?.DetailAdd ?? false) {
                        if (CopyRecord)
                            qryBillingDetailsV2Grid.CurrentMode = "copy";
                        else
                            qryBillingDetailsV2Grid.CurrentMode = "add";
                        if (IsConfirm)
                            qryBillingDetailsV2Grid.CurrentAction = "confirm";
                        else
                            qryBillingDetailsV2Grid.CurrentAction = "gridadd";
                        if (IsCancel)
                            qryBillingDetailsV2Grid.EventCancelled = true;

                        // Save current master table to detail table
                        qryBillingDetailsV2Grid.CurrentMasterTable = TableVar;
                        qryBillingDetailsV2Grid.StartRecordNumber = 1;
                        qryBillingDetailsV2Grid.NationalID.IsDetailKey = true;
                        qryBillingDetailsV2Grid.NationalID.CurrentValue = NationalID.CurrentValue;
                        qryBillingDetailsV2Grid.NationalID.SessionValue = qryBillingDetailsV2Grid.NationalID.CurrentValue;
                    }
                }
            }
        }

        // Reset detail parms
        protected void ResetDetailParms() {
            StringValues detailTblVar = "";
            // Get the keys for master table
            if (Query.TryGetValue(Config.TableShowDetail, out detailTblVar)) { // Do not use Get()
                CurrentDetailTable = detailTblVar.ToString();
            } else {
                detailTblVar = CurrentDetailTable;
            }
            if (!Empty(detailTblVar)) {
                var detailTblVars = detailTblVar.ToString().Split(',');
                if (detailTblVars.Contains("tblStudentEnrollment")) {
                    tblStudentEnrollmentGrid = Resolve("TblStudentEnrollmentGrid")!;
                    if (tblStudentEnrollmentGrid?.DetailAdd ?? false) {
                        tblStudentEnrollmentGrid.CurrentAction = "gridadd";
                    }
                }
                if (detailTblVars.Contains("qryBillingDetails_v2")) {
                    qryBillingDetailsV2Grid = Resolve("QryBillingDetailsV2Grid")!;
                    if (qryBillingDetailsV2Grid?.DetailAdd ?? false) {
                        qryBillingDetailsV2Grid.CurrentAction = "gridadd";
                    }
                }
            }
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblBillingInfoList")), "", TableVar, true);
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
