namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblBillingInfoEdit
    /// </summary>
    public static TblBillingInfoEdit tblBillingInfoEdit
    {
        get => HttpData.Get<TblBillingInfoEdit>("tblBillingInfoEdit")!;
        set => HttpData["tblBillingInfoEdit"] = value;
    }

    /// <summary>
    /// Page class for tblBillingInfo
    /// </summary>
    public class TblBillingInfoEdit : TblBillingInfoEditBase
    {
        // Constructor
        public TblBillingInfoEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblBillingInfoEdit() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblBillingInfoEditBase : TblBillingInfo
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblBillingInfo";

        // Page object name
        public string PageObjName = "tblBillingInfoEdit";

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
        public TblBillingInfoEditBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

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
        public string PageName => "TblBillingInfoEdit";

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
            str_Username.Visible = false;
            int_Student_ID.Visible = false;
            int_Payment_Method.SetVisibility();
            date_Paid.SetVisibility();
            str_ApprovalCode.SetVisibility();
            Payment_Number.Visible = false;
            Pricelist.Visible = false;
            date_Created.Visible = false;
            str_Amount.Visible = false;
            str_CC_Holder_Name.SetVisibility();
            str_CC_Number.SetVisibility();
            int_CC_ExpMonth.SetVisibility();
            int_CC_ExpYear.SetVisibility();
            int_CC_Type.SetVisibility();
            str_Card_Id.SetVisibility();
            str_CC_ValidationNum.SetVisibility();
            str_reference.Visible = false;
            str_Amount_Pay.SetVisibility();
            mny_Running_Payments.Visible = false;
            mny_Running_Balance.SetVisibility();
            str_Payment_Reference.Visible = false;
            int_Accepted_By.Visible = false;
            str_Check_Number.Visible = false;
            bit_Is_Check_Deposited.Visible = false;
            str_Adjustment_Type.Visible = false;
            str_Adjust_Sub_Type.Visible = false;
            bit_Archive.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.SetVisibility();
            date_Modified.SetVisibility();
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
            str_TransactionTime.Visible = false;
            int_Location_Id.Visible = false;
            str_Enrollment_Id.Visible = false;
            str_Notes.Visible = false;
            str_Payment_Note.SetVisibility();
            int_Package_ID.Visible = false;
            Package_Name.SetVisibility();
            Price.SetVisibility();
            AssessmentID.Visible = false;
            course.Visible = false;
            institution.Visible = false;
            UniqueIdx.Visible = false;
        }

        // Constructor
        public TblBillingInfoEditBase(Controller? controller = null): this() { // DN
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

        public SubPages? MultiPages; // Multi pages object

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
            Package_Name.Required = false;
            Price.Required = false;

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
                if (RouteValues.TryGetValue("int_Bill_ID", out rv)) { // DN
                    int_Bill_ID.FormValue = UrlDecode(rv); // DN
                    int_Bill_ID.OldValue = int_Bill_ID.FormValue;
                } else if (CurrentForm.HasValue("x_int_Bill_ID")) {
                    int_Bill_ID.FormValue = CurrentForm.GetValue("x_int_Bill_ID");
                    int_Bill_ID.OldValue = int_Bill_ID.FormValue;
                } else if (!Empty(keyValues)) {
                    int_Bill_ID.OldValue = ConvertToString(keyValues[0]);
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
                    if (RouteValues.TryGetValue("int_Bill_ID", out rv)) { // DN
                        int_Bill_ID.QueryValue = UrlDecode(rv); // DN
                        loadByQuery = true;
                    } else if (Get("int_Bill_ID", out sv)) {
                        int_Bill_ID.QueryValue = sv.ToString();
                        loadByQuery = true;
                    } else {
                        int_Bill_ID.CurrentValue = DbNullValue;
                    }
                }

                // Set up master detail parameters
                SetupMasterParms();

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
                int_Bill_ID.FormValue = ConvertToString(keyValues[0]);
            }

            // Set up detail parameters
            SetupDetailParms();
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
                            return Terminate("TblBillingInfoList"); // No matching record, return to list
                        }

                    // Set up detail parameters
                    SetupDetailParms();
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = "TblBillingInfoList";
                    if (GetPageName(returnUrl) == "TblBillingInfoList")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblBillingInfoList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblBillingInfoList"; // Return list page content
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

                        // Set up detail parameters
                        SetupDetailParms();
                    }
                    break;
            }

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Render the record
            if (IsConfirm) { // Confirm page
                RowType = RowType.View; // Render as View
            } else {
                RowType = RowType.Edit; // Render as Edit
            }
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
                tblBillingInfoEdit?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 219

        // Confirm page
        public bool ConfirmPage = true; // DN

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

            // Check field name 'str_Amount_Pay' before field var 'x_str_Amount_Pay'
            val = CurrentForm.HasValue("str_Amount_Pay") ? CurrentForm.GetValue("str_Amount_Pay") : CurrentForm.GetValue("x_str_Amount_Pay");
            if (!str_Amount_Pay.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Amount_Pay") && !CurrentForm.HasValue("x_str_Amount_Pay")) // DN
                    str_Amount_Pay.Visible = false; // Disable update for API request
                else
                    str_Amount_Pay.SetFormValue(val);
            }

            // Check field name 'mny_Running_Balance' before field var 'x_mny_Running_Balance'
            val = CurrentForm.HasValue("mny_Running_Balance") ? CurrentForm.GetValue("mny_Running_Balance") : CurrentForm.GetValue("x_mny_Running_Balance");
            if (!mny_Running_Balance.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_Running_Balance") && !CurrentForm.HasValue("x_mny_Running_Balance")) // DN
                    mny_Running_Balance.Visible = false; // Disable update for API request
                else
                    mny_Running_Balance.SetFormValue(val);
            }

            // Check field name 'int_Modified_By' before field var 'x_int_Modified_By'
            val = CurrentForm.HasValue("int_Modified_By") ? CurrentForm.GetValue("int_Modified_By") : CurrentForm.GetValue("x_int_Modified_By");
            if (!int_Modified_By.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Modified_By") && !CurrentForm.HasValue("x_int_Modified_By")) // DN
                    int_Modified_By.Visible = false; // Disable update for API request
                else
                    int_Modified_By.SetFormValue(val);
            }

            // Check field name 'date_Modified' before field var 'x_date_Modified'
            val = CurrentForm.HasValue("date_Modified") ? CurrentForm.GetValue("date_Modified") : CurrentForm.GetValue("x_date_Modified");
            if (!date_Modified.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Modified") && !CurrentForm.HasValue("x_date_Modified")) // DN
                    date_Modified.Visible = false; // Disable update for API request
                else
                    date_Modified.SetFormValue(val);
                date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            }

            // Check field name 'bit_IsRefund' before field var 'x_bit_IsRefund'
            val = CurrentForm.HasValue("bit_IsRefund") ? CurrentForm.GetValue("bit_IsRefund") : CurrentForm.GetValue("x_bit_IsRefund");
            if (!bit_IsRefund.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsRefund") && !CurrentForm.HasValue("x_bit_IsRefund")) // DN
                    bit_IsRefund.Visible = false; // Disable update for API request
                else
                    bit_IsRefund.SetFormValue(val);
            }

            // Check field name 'str_Payment_Note' before field var 'x_str_Payment_Note'
            val = CurrentForm.HasValue("str_Payment_Note") ? CurrentForm.GetValue("str_Payment_Note") : CurrentForm.GetValue("x_str_Payment_Note");
            if (!str_Payment_Note.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Payment_Note") && !CurrentForm.HasValue("x_str_Payment_Note")) // DN
                    str_Payment_Note.Visible = false; // Disable update for API request
                else
                    str_Payment_Note.SetFormValue(val);
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
            if (!int_Bill_ID.IsDetailKey)
                int_Bill_ID.SetFormValue(val);
            ResetDetailParms();
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Bill_ID.CurrentValue = int_Bill_ID.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            int_Payment_Method.CurrentValue = int_Payment_Method.FormValue;
            date_Paid.CurrentValue = date_Paid.FormValue;
            date_Paid.CurrentValue = UnformatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern);
            str_ApprovalCode.CurrentValue = str_ApprovalCode.FormValue;
            str_CC_Holder_Name.CurrentValue = str_CC_Holder_Name.FormValue;
            str_CC_Number.CurrentValue = str_CC_Number.FormValue;
            int_CC_ExpMonth.CurrentValue = int_CC_ExpMonth.FormValue;
            int_CC_ExpYear.CurrentValue = int_CC_ExpYear.FormValue;
            int_CC_Type.CurrentValue = int_CC_Type.FormValue;
            str_Card_Id.CurrentValue = str_Card_Id.FormValue;
            str_CC_ValidationNum.CurrentValue = str_CC_ValidationNum.FormValue;
            str_Amount_Pay.CurrentValue = str_Amount_Pay.FormValue;
            mny_Running_Balance.CurrentValue = mny_Running_Balance.FormValue;
            int_Modified_By.CurrentValue = int_Modified_By.FormValue;
            date_Modified.CurrentValue = date_Modified.FormValue;
            date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            bit_IsRefund.CurrentValue = bit_IsRefund.FormValue;
            str_Payment_Note.CurrentValue = str_Payment_Note.FormValue;
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

                // int_Payment_Method
                int_Payment_Method.HrefValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

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

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";

                // mny_Running_Balance
                mny_Running_Balance.HrefValue = "";
                mny_Running_Balance.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";

                // bit_IsRefund
                bit_IsRefund.HrefValue = "";

                // str_Payment_Note
                str_Payment_Note.HrefValue = "";

                // Package_Name
                Package_Name.HrefValue = "";
                Package_Name.TooltipValue = "";

                // Price
                Price.HrefValue = "";
                Price.TooltipValue = "";
            } else if (RowType == RowType.Edit) {
                // NationalID
                NationalID.SetupEditAttributes();
                curVal = ConvertToString(NationalID.CurrentValue);
                if (!Empty(curVal)) {
                    if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        NationalID.EditValue = NationalID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                        sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && NationalID.Lookup != null) { // Lookup values found
                            var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                            NationalID.EditValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                        } else {
                            NationalID.EditValue = NationalID.CurrentValue;
                        }
                    }
                } else {
                    NationalID.EditValue = DbNullValue;
                }
                NationalID.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.SetupEditAttributes();
                str_First_Name.EditValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                str_Last_Name.EditValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

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

                // str_Amount_Pay
                str_Amount_Pay.SetupEditAttributes();
                if (!str_Amount_Pay.Raw)
                    str_Amount_Pay.CurrentValue = HtmlDecode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

                // mny_Running_Balance
                mny_Running_Balance.SetupEditAttributes();
                mny_Running_Balance.EditValue = mny_Running_Balance.CurrentValue;
                mny_Running_Balance.EditValue = FormatNumber(mny_Running_Balance.EditValue, mny_Running_Balance.FormatPattern);
                mny_Running_Balance.CellCssStyle += "text-align: right;";
                mny_Running_Balance.ViewCustomAttributes = "";

                // int_Modified_By

                // date_Modified

                // bit_IsRefund
                bit_IsRefund.EditValue = bit_IsRefund.Options(false);
                bit_IsRefund.PlaceHolder = RemoveHtml(bit_IsRefund.Caption);

                // str_Payment_Note
                str_Payment_Note.SetupEditAttributes();
                str_Payment_Note.EditValue = str_Payment_Note.CurrentValue; // DN
                str_Payment_Note.PlaceHolder = RemoveHtml(str_Payment_Note.Caption);

                // Package_Name
                Package_Name.SetupEditAttributes();
                Package_Name.EditValue = ConvertToString(Package_Name.CurrentValue); // DN
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
                            Package_Name.EditValue = Package_Name.CurrentValue;
                        }
                    }
                } else {
                    Package_Name.EditValue = DbNullValue;
                }
                Package_Name.ViewCustomAttributes = "";

                // Price
                Price.SetupEditAttributes();
                curVal = ConvertToString(Price.CurrentValue);
                if (!Empty(curVal)) {
                    if (Price.Lookup != null && IsDictionary(Price.Lookup?.Options) && Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Price.EditValue = Price.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[mny_Price]", "=", Price.CurrentValue, DataType.Number, "");
                        sqlWrk = Price.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Price.Lookup != null) { // Lookup values found
                            var listwrk = Price.Lookup?.RenderViewRow(rswrk[0]);
                            Price.EditValue = Price.HighlightLookup(ConvertToString(rswrk[0]), Price.DisplayValue(listwrk));
                        } else {
                            Price.EditValue = FormatCurrency(Price.CurrentValue, Price.FormatPattern);
                        }
                    }
                } else {
                    Price.EditValue = DbNullValue;
                }
                Price.ViewCustomAttributes = "";

                // Edit refer script

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // int_Payment_Method
                int_Payment_Method.HrefValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

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

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";

                // mny_Running_Balance
                mny_Running_Balance.HrefValue = "";
                mny_Running_Balance.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";

                // bit_IsRefund
                bit_IsRefund.HrefValue = "";

                // str_Payment_Note
                str_Payment_Note.HrefValue = "";

                // Package_Name
                Package_Name.HrefValue = "";
                Package_Name.TooltipValue = "";

                // Price
                Price.HrefValue = "";
                Price.TooltipValue = "";
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
            if (str_Amount_Pay.Required) {
                if (!str_Amount_Pay.IsDetailKey && Empty(str_Amount_Pay.FormValue)) {
                    str_Amount_Pay.AddErrorMessage(ConvertToString(str_Amount_Pay.RequiredErrorMessage).Replace("%s", str_Amount_Pay.Caption));
                }
            }
            if (mny_Running_Balance.Required) {
                if (!mny_Running_Balance.IsDetailKey && Empty(mny_Running_Balance.FormValue)) {
                    mny_Running_Balance.AddErrorMessage(ConvertToString(mny_Running_Balance.RequiredErrorMessage).Replace("%s", mny_Running_Balance.Caption));
                }
            }
            if (int_Modified_By.Required) {
                if (!int_Modified_By.IsDetailKey && Empty(int_Modified_By.FormValue)) {
                    int_Modified_By.AddErrorMessage(ConvertToString(int_Modified_By.RequiredErrorMessage).Replace("%s", int_Modified_By.Caption));
                }
            }
            if (date_Modified.Required) {
                if (!date_Modified.IsDetailKey && Empty(date_Modified.FormValue)) {
                    date_Modified.AddErrorMessage(ConvertToString(date_Modified.RequiredErrorMessage).Replace("%s", date_Modified.Caption));
                }
            }
            if (bit_IsRefund.Required) {
                if (Empty(bit_IsRefund.FormValue)) {
                    bit_IsRefund.AddErrorMessage(ConvertToString(bit_IsRefund.RequiredErrorMessage).Replace("%s", bit_IsRefund.Caption));
                }
            }
            if (str_Payment_Note.Required) {
                if (!str_Payment_Note.IsDetailKey && Empty(str_Payment_Note.FormValue)) {
                    str_Payment_Note.AddErrorMessage(ConvertToString(str_Payment_Note.RequiredErrorMessage).Replace("%s", str_Payment_Note.Caption));
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
            if (detailTblVar.Contains("tblStudentEnrollment") && tblStudentEnrollment?.DetailEdit == true) {
                tblStudentEnrollmentGrid = Resolve("TblStudentEnrollmentGrid")!; // Get detail page object
                if (tblStudentEnrollmentGrid != null)
                    validateForm = validateForm && await tblStudentEnrollmentGrid.ValidateGridForm();
            }
            if (detailTblVar.Contains("qryBillingDetails_v2") && qryBillingDetailsV2?.DetailEdit == true) {
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

            // int_Payment_Method
            int_Payment_Method.SetDbValue(rsnew, int_Payment_Method.CurrentValue, int_Payment_Method.ReadOnly);

            // date_Paid
            date_Paid.SetDbValue(rsnew, ConvertToDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), date_Paid.ReadOnly);

            // str_ApprovalCode
            str_ApprovalCode.SetDbValue(rsnew, str_ApprovalCode.CurrentValue, str_ApprovalCode.ReadOnly);

            // str_CC_Holder_Name
            str_CC_Holder_Name.SetDbValue(rsnew, str_CC_Holder_Name.CurrentValue, str_CC_Holder_Name.ReadOnly);

            // str_CC_Number
            str_CC_Number.SetDbValue(rsnew, str_CC_Number.CurrentValue, str_CC_Number.ReadOnly);

            // int_CC_ExpMonth
            int_CC_ExpMonth.SetDbValue(rsnew, int_CC_ExpMonth.CurrentValue, int_CC_ExpMonth.ReadOnly);

            // int_CC_ExpYear
            int_CC_ExpYear.SetDbValue(rsnew, int_CC_ExpYear.CurrentValue, int_CC_ExpYear.ReadOnly);

            // int_CC_Type
            int_CC_Type.SetDbValue(rsnew, int_CC_Type.CurrentValue, int_CC_Type.ReadOnly);

            // str_Card_Id
            str_Card_Id.SetDbValue(rsnew, str_Card_Id.CurrentValue, str_Card_Id.ReadOnly);

            // str_CC_ValidationNum
            str_CC_ValidationNum.SetDbValue(rsnew, str_CC_ValidationNum.CurrentValue, str_CC_ValidationNum.ReadOnly);

            // str_Amount_Pay
            str_Amount_Pay.SetDbValue(rsnew, str_Amount_Pay.CurrentValue, str_Amount_Pay.ReadOnly);

            // int_Modified_By
            int_Modified_By.CurrentValue = int_Modified_By.GetAutoUpdateValue();
            int_Modified_By.SetDbValue(rsnew, int_Modified_By.CurrentValue, false);

            // date_Modified
            date_Modified.CurrentValue = date_Modified.GetAutoUpdateValue();
            date_Modified.SetDbValue(rsnew, date_Modified.CurrentValue, false);

            // bit_IsRefund
            bit_IsRefund.SetDbValue(rsnew, ConvertToBool(bit_IsRefund.CurrentValue), bit_IsRefund.ReadOnly);

            // str_Payment_Note
            str_Payment_Note.SetDbValue(rsnew, str_Payment_Note.CurrentValue, str_Payment_Note.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

            // Check field with unique index (str_ApprovalCode)
            if (!Empty(str_ApprovalCode.CurrentValue)) {
                string filterChk = "([str_ApprovalCode] = '" + AdjustSql(str_ApprovalCode.CurrentValue, DbId) + "')";
                filterChk = filterChk + " AND NOT (" + filter + ")";
                try {
                    using var rschk = await LoadReader(filterChk);
                    if (rschk?.HasRows ?? false) {
                        var idxErrMsg = Language.Phrase("DupIndex").Replace("%f", str_ApprovalCode.Caption);
                        idxErrMsg = idxErrMsg.Replace("%v", ConvertToString(str_ApprovalCode.CurrentValue));
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

            // Begin transaction
            if (!Empty(CurrentDetailTable) && UseTransaction)
                Connection.BeginTrans();
            bool validMasterRecord;
            object keyValue;
            object? v;
            string? masterFilter;
            Dictionary<string, object?> detailKeys;

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

                    // Update detail records
                    var detailTblVar = CurrentDetailTables;
                    if (detailTblVar.Contains("tblStudentEnrollment") && tblStudentEnrollment?.DetailEdit == true && result) {
                        tblStudentEnrollmentGrid = Resolve("TblStudentEnrollmentGrid")!; // Get detail page object
                        if (tblStudentEnrollmentGrid != null) {
                            Security.LoadCurrentUserLevel(ProjectID + "tblStudentEnrollment"); // Load user level of detail table
                            result = await tblStudentEnrollmentGrid.GridUpdate();
                            Security.LoadCurrentUserLevel(ProjectID + TableName); // Restore user level of master table
                        }
                    }
                    if (detailTblVar.Contains("qryBillingDetails_v2") && qryBillingDetailsV2?.DetailEdit == true && result) {
                        qryBillingDetailsV2Grid = Resolve("QryBillingDetailsV2Grid")!; // Get detail page object
                        if (qryBillingDetailsV2Grid != null) {
                            Security.LoadCurrentUserLevel(ProjectID + "qryBillingDetails_v2"); // Load user level of detail table
                            result = await qryBillingDetailsV2Grid.GridUpdate();
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
            if (result && SendEmail) {
                var res = await SendEmailOnEdit(rsold, rsnew); // DN
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
                SessionWhere = DetailFilterFromSession;

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
                    if (tblStudentEnrollmentGrid?.DetailEdit ?? false) {
                        tblStudentEnrollmentGrid.CurrentMode = "edit";
                        if (IsConfirm)
                            tblStudentEnrollmentGrid.CurrentAction = "confirm";
                        else
                            tblStudentEnrollmentGrid.CurrentAction = "gridedit";
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
                    if (qryBillingDetailsV2Grid?.DetailEdit ?? false) {
                        qryBillingDetailsV2Grid.CurrentMode = "edit";
                        if (IsConfirm)
                            qryBillingDetailsV2Grid.CurrentAction = "confirm";
                        else
                            qryBillingDetailsV2Grid.CurrentAction = "gridedit";
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
                    if (tblStudentEnrollmentGrid?.DetailEdit ?? false) {
                        tblStudentEnrollmentGrid.CurrentAction = "gridedit";
                    }
                }
                if (detailTblVars.Contains("qryBillingDetails_v2")) {
                    qryBillingDetailsV2Grid = Resolve("QryBillingDetailsV2Grid")!;
                    if (qryBillingDetailsV2Grid?.DetailEdit ?? false) {
                        qryBillingDetailsV2Grid.CurrentAction = "gridedit";
                    }
                }
            }
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblBillingInfoList")), "", TableVar, true);
            string pageId = "edit";
            breadcrumb.Add("edit", pageId, url);
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
