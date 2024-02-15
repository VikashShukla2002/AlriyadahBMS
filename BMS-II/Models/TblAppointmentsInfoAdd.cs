namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAppointmentsInfoAdd
    /// </summary>
    public static TblAppointmentsInfoAdd tblAppointmentsInfoAdd
    {
        get => HttpData.Get<TblAppointmentsInfoAdd>("tblAppointmentsInfoAdd")!;
        set => HttpData["tblAppointmentsInfoAdd"] = value;
    }

    /// <summary>
    /// Page class for tblAppointmentsInfo
    /// </summary>
    public class TblAppointmentsInfoAdd : TblAppointmentsInfoAddBase
    {
        // Constructor
        public TblAppointmentsInfoAdd(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAppointmentsInfoAdd() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblAppointmentsInfoAddBase : TblAppointmentsInfo
    {
        // Page ID
        public string PageID = "add";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAppointmentsInfo";

        // Page object name
        public string PageObjName = "tblAppointmentsInfoAdd";

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
        public TblAppointmentsInfoAddBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-add-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblAppointmentsInfo)
            if (tblAppointmentsInfo == null || tblAppointmentsInfo is TblAppointmentsInfo)
                tblAppointmentsInfo = this;

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
        public string PageName => "TblAppointmentsInfoAdd";

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
            int_Appt_id.Visible = false;
            str_AppName.SetVisibility();
            str_App_Date.SetVisibility();
            str_StartTime.SetVisibility();
            str_EndTime.SetVisibility();
            str_PickupTime.SetVisibility();
            str_DropOffTime.SetVisibility();
            int_VehicleID.SetVisibility();
            dec_InstID.SetVisibility();
            dec_StudentID.SetVisibility();
            dec_Observed_StudentID.SetVisibility();
            int_Apptype.SetVisibility();
            int_AppStatus.SetVisibility();
            mny_AppCost.SetVisibility();
            mny_AmountPaid.SetVisibility();
            bit_CheckAppPaid.SetVisibility();
            bit_Confirmation.SetVisibility();
            str_Instructions.SetVisibility();
            str_Instructions1.SetVisibility();
            str_AppNotes.SetVisibility();
            str_PickupLocation.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_Interval.SetVisibility();
            RemM1.SetVisibility();
            RemM2.SetVisibility();
            RemM3.SetVisibility();
            int_Location_ID.SetVisibility();
            SPID.SetVisibility();
            Chk_Trace.SetVisibility();
            str_DropOffLocation.SetVisibility();
            imgInstructorSignature.SetVisibility();
            imgStudentSignature.SetVisibility();
            imgObserverSignature.SetVisibility();
            dt_apptstart.SetVisibility();
            dt_apptComplete.SetVisibility();
            int_apptstartedBy.SetVisibility();
            int_apptCompletedBy.SetVisibility();
            SMSReminder1.SetVisibility();
            SMSReminder2.SetVisibility();
            SMSReminder3.SetVisibility();
            VoiceReminder1.SetVisibility();
            VoiceReminder2.SetVisibility();
            VoiceReminder3.SetVisibility();
            bit_isroadtest.SetVisibility();
            int_slotType.SetVisibility();
            bit_VisibleOnPortal.SetVisibility();
            IsDataRetrieved.SetVisibility();
            bit_chargesApplied.SetVisibility();
            dec_DistanceTravelled.SetVisibility();
            btwProductIdsforSSRules.SetVisibility();
            int_evaluateApptWithEmail.SetVisibility();
            PublicNotesId.SetVisibility();
            NationalID.SetVisibility();
            str_Username.SetVisibility();
            int_PackageID.SetVisibility();
            int_ApptCldr_ID.SetVisibility();
            str_CRSS_ID.SetVisibility();
        }

        // Constructor
        public TblAppointmentsInfoAddBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblAppointmentsInfoView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Appt_id") ? dict["int_Appt_id"] : int_Appt_id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Appt_id.Visible = false;
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
            await SetupLookupOptions(int_Apptype);
            await SetupLookupOptions(int_AppStatus);
            await SetupLookupOptions(bit_CheckAppPaid);
            await SetupLookupOptions(bit_Confirmation);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(RemM1);
            await SetupLookupOptions(RemM2);
            await SetupLookupOptions(RemM3);
            await SetupLookupOptions(SMSReminder1);
            await SetupLookupOptions(SMSReminder2);
            await SetupLookupOptions(SMSReminder3);
            await SetupLookupOptions(VoiceReminder1);
            await SetupLookupOptions(VoiceReminder2);
            await SetupLookupOptions(VoiceReminder3);
            await SetupLookupOptions(bit_isroadtest);
            await SetupLookupOptions(bit_VisibleOnPortal);
            await SetupLookupOptions(IsDataRetrieved);
            await SetupLookupOptions(bit_chargesApplied);

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
                if (RouteValues.TryGetValue("int_Appt_id", out rv)) { // DN
                    int_Appt_id.QueryValue = UrlDecode(rv); // DN
                } else if (Get("int_Appt_id", out sv)) {
                    int_Appt_id.QueryValue = sv.ToString();
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
                        return Terminate("TblAppointmentsInfoList"); // No matching record, return to List page // DN
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
                        if (GetPageName(returnUrl) == "TblAppointmentsInfoList")
                            returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                        else if (GetPageName(returnUrl) == "TblAppointmentsInfoView")
                            returnUrl = ViewUrl; // View page, return to View page with key URL directly

                        // Handle UseAjaxActions
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblAppointmentsInfoList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblAppointmentsInfoList"; // Return list page content
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
                tblAppointmentsInfoAdd?.PageRender();
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
            imgInstructorSignature.Upload.Index = CurrentForm.Index;
            if (!await imgInstructorSignature.Upload.UploadFile()) // DN
                End(imgInstructorSignature.Upload.Message);
            imgStudentSignature.Upload.Index = CurrentForm.Index;
            if (!await imgStudentSignature.Upload.UploadFile()) // DN
                End(imgStudentSignature.Upload.Message);
            imgObserverSignature.Upload.Index = CurrentForm.Index;
            if (!await imgObserverSignature.Upload.UploadFile()) // DN
                End(imgObserverSignature.Upload.Message);
        }
        #pragma warning restore 1998

        // Load default values
        protected void LoadDefaultValues() {
            bit_IsDeleted.DefaultValue = bit_IsDeleted.GetDefault(); // DN
            bit_IsDeleted.OldValue = bit_IsDeleted.DefaultValue;
            str_Interval.DefaultValue = str_Interval.GetDefault(); // DN
            str_Interval.OldValue = str_Interval.DefaultValue;
            RemM1.DefaultValue = RemM1.GetDefault(); // DN
            RemM1.OldValue = RemM1.DefaultValue;
            RemM2.DefaultValue = RemM2.GetDefault(); // DN
            RemM2.OldValue = RemM2.DefaultValue;
            RemM3.DefaultValue = RemM3.GetDefault(); // DN
            RemM3.OldValue = RemM3.DefaultValue;
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'str_AppName' before field var 'x_str_AppName'
            val = CurrentForm.HasValue("str_AppName") ? CurrentForm.GetValue("str_AppName") : CurrentForm.GetValue("x_str_AppName");
            if (!str_AppName.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_AppName") && !CurrentForm.HasValue("x_str_AppName")) // DN
                    str_AppName.Visible = false; // Disable update for API request
                else
                    str_AppName.SetFormValue(val);
            }

            // Check field name 'str_App_Date' before field var 'x_str_App_Date'
            val = CurrentForm.HasValue("str_App_Date") ? CurrentForm.GetValue("str_App_Date") : CurrentForm.GetValue("x_str_App_Date");
            if (!str_App_Date.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_App_Date") && !CurrentForm.HasValue("x_str_App_Date")) // DN
                    str_App_Date.Visible = false; // Disable update for API request
                else
                    str_App_Date.SetFormValue(val);
            }

            // Check field name 'str_StartTime' before field var 'x_str_StartTime'
            val = CurrentForm.HasValue("str_StartTime") ? CurrentForm.GetValue("str_StartTime") : CurrentForm.GetValue("x_str_StartTime");
            if (!str_StartTime.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_StartTime") && !CurrentForm.HasValue("x_str_StartTime")) // DN
                    str_StartTime.Visible = false; // Disable update for API request
                else
                    str_StartTime.SetFormValue(val);
            }

            // Check field name 'str_EndTime' before field var 'x_str_EndTime'
            val = CurrentForm.HasValue("str_EndTime") ? CurrentForm.GetValue("str_EndTime") : CurrentForm.GetValue("x_str_EndTime");
            if (!str_EndTime.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_EndTime") && !CurrentForm.HasValue("x_str_EndTime")) // DN
                    str_EndTime.Visible = false; // Disable update for API request
                else
                    str_EndTime.SetFormValue(val);
            }

            // Check field name 'str_PickupTime' before field var 'x_str_PickupTime'
            val = CurrentForm.HasValue("str_PickupTime") ? CurrentForm.GetValue("str_PickupTime") : CurrentForm.GetValue("x_str_PickupTime");
            if (!str_PickupTime.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_PickupTime") && !CurrentForm.HasValue("x_str_PickupTime")) // DN
                    str_PickupTime.Visible = false; // Disable update for API request
                else
                    str_PickupTime.SetFormValue(val);
            }

            // Check field name 'str_DropOffTime' before field var 'x_str_DropOffTime'
            val = CurrentForm.HasValue("str_DropOffTime") ? CurrentForm.GetValue("str_DropOffTime") : CurrentForm.GetValue("x_str_DropOffTime");
            if (!str_DropOffTime.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_DropOffTime") && !CurrentForm.HasValue("x_str_DropOffTime")) // DN
                    str_DropOffTime.Visible = false; // Disable update for API request
                else
                    str_DropOffTime.SetFormValue(val);
            }

            // Check field name 'int_VehicleID' before field var 'x_int_VehicleID'
            val = CurrentForm.HasValue("int_VehicleID") ? CurrentForm.GetValue("int_VehicleID") : CurrentForm.GetValue("x_int_VehicleID");
            if (!int_VehicleID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_VehicleID") && !CurrentForm.HasValue("x_int_VehicleID")) // DN
                    int_VehicleID.Visible = false; // Disable update for API request
                else
                    int_VehicleID.SetFormValue(val, true, validate);
            }

            // Check field name 'dec_InstID' before field var 'x_dec_InstID'
            val = CurrentForm.HasValue("dec_InstID") ? CurrentForm.GetValue("dec_InstID") : CurrentForm.GetValue("x_dec_InstID");
            if (!dec_InstID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_InstID") && !CurrentForm.HasValue("x_dec_InstID")) // DN
                    dec_InstID.Visible = false; // Disable update for API request
                else
                    dec_InstID.SetFormValue(val, true, validate);
            }

            // Check field name 'dec_StudentID' before field var 'x_dec_StudentID'
            val = CurrentForm.HasValue("dec_StudentID") ? CurrentForm.GetValue("dec_StudentID") : CurrentForm.GetValue("x_dec_StudentID");
            if (!dec_StudentID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_StudentID") && !CurrentForm.HasValue("x_dec_StudentID")) // DN
                    dec_StudentID.Visible = false; // Disable update for API request
                else
                    dec_StudentID.SetFormValue(val, true, validate);
            }

            // Check field name 'dec_Observed_StudentID' before field var 'x_dec_Observed_StudentID'
            val = CurrentForm.HasValue("dec_Observed_StudentID") ? CurrentForm.GetValue("dec_Observed_StudentID") : CurrentForm.GetValue("x_dec_Observed_StudentID");
            if (!dec_Observed_StudentID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_Observed_StudentID") && !CurrentForm.HasValue("x_dec_Observed_StudentID")) // DN
                    dec_Observed_StudentID.Visible = false; // Disable update for API request
                else
                    dec_Observed_StudentID.SetFormValue(val, true, validate);
            }

            // Check field name 'int_Apptype' before field var 'x_int_Apptype'
            val = CurrentForm.HasValue("int_Apptype") ? CurrentForm.GetValue("int_Apptype") : CurrentForm.GetValue("x_int_Apptype");
            if (!int_Apptype.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Apptype") && !CurrentForm.HasValue("x_int_Apptype")) // DN
                    int_Apptype.Visible = false; // Disable update for API request
                else
                    int_Apptype.SetFormValue(val, true, validate);
            }

            // Check field name 'int_AppStatus' before field var 'x_int_AppStatus'
            val = CurrentForm.HasValue("int_AppStatus") ? CurrentForm.GetValue("int_AppStatus") : CurrentForm.GetValue("x_int_AppStatus");
            if (!int_AppStatus.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_AppStatus") && !CurrentForm.HasValue("x_int_AppStatus")) // DN
                    int_AppStatus.Visible = false; // Disable update for API request
                else
                    int_AppStatus.SetFormValue(val);
            }

            // Check field name 'mny_AppCost' before field var 'x_mny_AppCost'
            val = CurrentForm.HasValue("mny_AppCost") ? CurrentForm.GetValue("mny_AppCost") : CurrentForm.GetValue("x_mny_AppCost");
            if (!mny_AppCost.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_AppCost") && !CurrentForm.HasValue("x_mny_AppCost")) // DN
                    mny_AppCost.Visible = false; // Disable update for API request
                else
                    mny_AppCost.SetFormValue(val, true, validate);
            }

            // Check field name 'mny_AmountPaid' before field var 'x_mny_AmountPaid'
            val = CurrentForm.HasValue("mny_AmountPaid") ? CurrentForm.GetValue("mny_AmountPaid") : CurrentForm.GetValue("x_mny_AmountPaid");
            if (!mny_AmountPaid.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_AmountPaid") && !CurrentForm.HasValue("x_mny_AmountPaid")) // DN
                    mny_AmountPaid.Visible = false; // Disable update for API request
                else
                    mny_AmountPaid.SetFormValue(val, true, validate);
            }

            // Check field name 'bit_CheckAppPaid' before field var 'x_bit_CheckAppPaid'
            val = CurrentForm.HasValue("bit_CheckAppPaid") ? CurrentForm.GetValue("bit_CheckAppPaid") : CurrentForm.GetValue("x_bit_CheckAppPaid");
            if (!bit_CheckAppPaid.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_CheckAppPaid") && !CurrentForm.HasValue("x_bit_CheckAppPaid")) // DN
                    bit_CheckAppPaid.Visible = false; // Disable update for API request
                else
                    bit_CheckAppPaid.SetFormValue(val);
            }

            // Check field name 'bit_Confirmation' before field var 'x_bit_Confirmation'
            val = CurrentForm.HasValue("bit_Confirmation") ? CurrentForm.GetValue("bit_Confirmation") : CurrentForm.GetValue("x_bit_Confirmation");
            if (!bit_Confirmation.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_Confirmation") && !CurrentForm.HasValue("x_bit_Confirmation")) // DN
                    bit_Confirmation.Visible = false; // Disable update for API request
                else
                    bit_Confirmation.SetFormValue(val);
            }

            // Check field name 'str_Instructions' before field var 'x_str_Instructions'
            val = CurrentForm.HasValue("str_Instructions") ? CurrentForm.GetValue("str_Instructions") : CurrentForm.GetValue("x_str_Instructions");
            if (!str_Instructions.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Instructions") && !CurrentForm.HasValue("x_str_Instructions")) // DN
                    str_Instructions.Visible = false; // Disable update for API request
                else
                    str_Instructions.SetFormValue(val);
            }

            // Check field name 'str_Instructions1' before field var 'x_str_Instructions1'
            val = CurrentForm.HasValue("str_Instructions1") ? CurrentForm.GetValue("str_Instructions1") : CurrentForm.GetValue("x_str_Instructions1");
            if (!str_Instructions1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Instructions1") && !CurrentForm.HasValue("x_str_Instructions1")) // DN
                    str_Instructions1.Visible = false; // Disable update for API request
                else
                    str_Instructions1.SetFormValue(val);
            }

            // Check field name 'str_AppNotes' before field var 'x_str_AppNotes'
            val = CurrentForm.HasValue("str_AppNotes") ? CurrentForm.GetValue("str_AppNotes") : CurrentForm.GetValue("x_str_AppNotes");
            if (!str_AppNotes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_AppNotes") && !CurrentForm.HasValue("x_str_AppNotes")) // DN
                    str_AppNotes.Visible = false; // Disable update for API request
                else
                    str_AppNotes.SetFormValue(val);
            }

            // Check field name 'str_PickupLocation' before field var 'x_str_PickupLocation'
            val = CurrentForm.HasValue("str_PickupLocation") ? CurrentForm.GetValue("str_PickupLocation") : CurrentForm.GetValue("x_str_PickupLocation");
            if (!str_PickupLocation.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_PickupLocation") && !CurrentForm.HasValue("x_str_PickupLocation")) // DN
                    str_PickupLocation.Visible = false; // Disable update for API request
                else
                    str_PickupLocation.SetFormValue(val);
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
                    date_Created.SetFormValue(val);
                date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
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

            // Check field name 'bit_IsDeleted' before field var 'x_bit_IsDeleted'
            val = CurrentForm.HasValue("bit_IsDeleted") ? CurrentForm.GetValue("bit_IsDeleted") : CurrentForm.GetValue("x_bit_IsDeleted");
            if (!bit_IsDeleted.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsDeleted") && !CurrentForm.HasValue("x_bit_IsDeleted")) // DN
                    bit_IsDeleted.Visible = false; // Disable update for API request
                else
                    bit_IsDeleted.SetFormValue(val);
            }

            // Check field name 'str_Interval' before field var 'x_str_Interval'
            val = CurrentForm.HasValue("str_Interval") ? CurrentForm.GetValue("str_Interval") : CurrentForm.GetValue("x_str_Interval");
            if (!str_Interval.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Interval") && !CurrentForm.HasValue("x_str_Interval")) // DN
                    str_Interval.Visible = false; // Disable update for API request
                else
                    str_Interval.SetFormValue(val);
            }

            // Check field name 'RemM1' before field var 'x_RemM1'
            val = CurrentForm.HasValue("RemM1") ? CurrentForm.GetValue("RemM1") : CurrentForm.GetValue("x_RemM1");
            if (!RemM1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("RemM1") && !CurrentForm.HasValue("x_RemM1")) // DN
                    RemM1.Visible = false; // Disable update for API request
                else
                    RemM1.SetFormValue(val);
            }

            // Check field name 'RemM2' before field var 'x_RemM2'
            val = CurrentForm.HasValue("RemM2") ? CurrentForm.GetValue("RemM2") : CurrentForm.GetValue("x_RemM2");
            if (!RemM2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("RemM2") && !CurrentForm.HasValue("x_RemM2")) // DN
                    RemM2.Visible = false; // Disable update for API request
                else
                    RemM2.SetFormValue(val);
            }

            // Check field name 'RemM3' before field var 'x_RemM3'
            val = CurrentForm.HasValue("RemM3") ? CurrentForm.GetValue("RemM3") : CurrentForm.GetValue("x_RemM3");
            if (!RemM3.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("RemM3") && !CurrentForm.HasValue("x_RemM3")) // DN
                    RemM3.Visible = false; // Disable update for API request
                else
                    RemM3.SetFormValue(val);
            }

            // Check field name 'int_Location_ID' before field var 'x_int_Location_ID'
            val = CurrentForm.HasValue("int_Location_ID") ? CurrentForm.GetValue("int_Location_ID") : CurrentForm.GetValue("x_int_Location_ID");
            if (!int_Location_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Location_ID") && !CurrentForm.HasValue("x_int_Location_ID")) // DN
                    int_Location_ID.Visible = false; // Disable update for API request
                else
                    int_Location_ID.SetFormValue(val, true, validate);
            }

            // Check field name 'SPID' before field var 'x_SPID'
            val = CurrentForm.HasValue("SPID") ? CurrentForm.GetValue("SPID") : CurrentForm.GetValue("x_SPID");
            if (!SPID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("SPID") && !CurrentForm.HasValue("x_SPID")) // DN
                    SPID.Visible = false; // Disable update for API request
                else
                    SPID.SetFormValue(val, true, validate);
            }

            // Check field name 'Chk_Trace' before field var 'x_Chk_Trace'
            val = CurrentForm.HasValue("Chk_Trace") ? CurrentForm.GetValue("Chk_Trace") : CurrentForm.GetValue("x_Chk_Trace");
            if (!Chk_Trace.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Chk_Trace") && !CurrentForm.HasValue("x_Chk_Trace")) // DN
                    Chk_Trace.Visible = false; // Disable update for API request
                else
                    Chk_Trace.SetFormValue(val);
            }

            // Check field name 'str_DropOffLocation' before field var 'x_str_DropOffLocation'
            val = CurrentForm.HasValue("str_DropOffLocation") ? CurrentForm.GetValue("str_DropOffLocation") : CurrentForm.GetValue("x_str_DropOffLocation");
            if (!str_DropOffLocation.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_DropOffLocation") && !CurrentForm.HasValue("x_str_DropOffLocation")) // DN
                    str_DropOffLocation.Visible = false; // Disable update for API request
                else
                    str_DropOffLocation.SetFormValue(val);
            }

            // Check field name 'dt_apptstart' before field var 'x_dt_apptstart'
            val = CurrentForm.HasValue("dt_apptstart") ? CurrentForm.GetValue("dt_apptstart") : CurrentForm.GetValue("x_dt_apptstart");
            if (!dt_apptstart.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dt_apptstart") && !CurrentForm.HasValue("x_dt_apptstart")) // DN
                    dt_apptstart.Visible = false; // Disable update for API request
                else
                    dt_apptstart.SetFormValue(val, true, validate);
                dt_apptstart.CurrentValue = UnformatDateTime(dt_apptstart.CurrentValue, dt_apptstart.FormatPattern);
            }

            // Check field name 'dt_apptComplete' before field var 'x_dt_apptComplete'
            val = CurrentForm.HasValue("dt_apptComplete") ? CurrentForm.GetValue("dt_apptComplete") : CurrentForm.GetValue("x_dt_apptComplete");
            if (!dt_apptComplete.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dt_apptComplete") && !CurrentForm.HasValue("x_dt_apptComplete")) // DN
                    dt_apptComplete.Visible = false; // Disable update for API request
                else
                    dt_apptComplete.SetFormValue(val, true, validate);
                dt_apptComplete.CurrentValue = UnformatDateTime(dt_apptComplete.CurrentValue, dt_apptComplete.FormatPattern);
            }

            // Check field name 'int_apptstartedBy' before field var 'x_int_apptstartedBy'
            val = CurrentForm.HasValue("int_apptstartedBy") ? CurrentForm.GetValue("int_apptstartedBy") : CurrentForm.GetValue("x_int_apptstartedBy");
            if (!int_apptstartedBy.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_apptstartedBy") && !CurrentForm.HasValue("x_int_apptstartedBy")) // DN
                    int_apptstartedBy.Visible = false; // Disable update for API request
                else
                    int_apptstartedBy.SetFormValue(val, true, validate);
            }

            // Check field name 'int_apptCompletedBy' before field var 'x_int_apptCompletedBy'
            val = CurrentForm.HasValue("int_apptCompletedBy") ? CurrentForm.GetValue("int_apptCompletedBy") : CurrentForm.GetValue("x_int_apptCompletedBy");
            if (!int_apptCompletedBy.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_apptCompletedBy") && !CurrentForm.HasValue("x_int_apptCompletedBy")) // DN
                    int_apptCompletedBy.Visible = false; // Disable update for API request
                else
                    int_apptCompletedBy.SetFormValue(val, true, validate);
            }

            // Check field name 'SMSReminder1' before field var 'x_SMSReminder1'
            val = CurrentForm.HasValue("SMSReminder1") ? CurrentForm.GetValue("SMSReminder1") : CurrentForm.GetValue("x_SMSReminder1");
            if (!SMSReminder1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("SMSReminder1") && !CurrentForm.HasValue("x_SMSReminder1")) // DN
                    SMSReminder1.Visible = false; // Disable update for API request
                else
                    SMSReminder1.SetFormValue(val);
            }

            // Check field name 'SMSReminder2' before field var 'x_SMSReminder2'
            val = CurrentForm.HasValue("SMSReminder2") ? CurrentForm.GetValue("SMSReminder2") : CurrentForm.GetValue("x_SMSReminder2");
            if (!SMSReminder2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("SMSReminder2") && !CurrentForm.HasValue("x_SMSReminder2")) // DN
                    SMSReminder2.Visible = false; // Disable update for API request
                else
                    SMSReminder2.SetFormValue(val);
            }

            // Check field name 'SMSReminder3' before field var 'x_SMSReminder3'
            val = CurrentForm.HasValue("SMSReminder3") ? CurrentForm.GetValue("SMSReminder3") : CurrentForm.GetValue("x_SMSReminder3");
            if (!SMSReminder3.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("SMSReminder3") && !CurrentForm.HasValue("x_SMSReminder3")) // DN
                    SMSReminder3.Visible = false; // Disable update for API request
                else
                    SMSReminder3.SetFormValue(val);
            }

            // Check field name 'VoiceReminder1' before field var 'x_VoiceReminder1'
            val = CurrentForm.HasValue("VoiceReminder1") ? CurrentForm.GetValue("VoiceReminder1") : CurrentForm.GetValue("x_VoiceReminder1");
            if (!VoiceReminder1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("VoiceReminder1") && !CurrentForm.HasValue("x_VoiceReminder1")) // DN
                    VoiceReminder1.Visible = false; // Disable update for API request
                else
                    VoiceReminder1.SetFormValue(val);
            }

            // Check field name 'VoiceReminder2' before field var 'x_VoiceReminder2'
            val = CurrentForm.HasValue("VoiceReminder2") ? CurrentForm.GetValue("VoiceReminder2") : CurrentForm.GetValue("x_VoiceReminder2");
            if (!VoiceReminder2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("VoiceReminder2") && !CurrentForm.HasValue("x_VoiceReminder2")) // DN
                    VoiceReminder2.Visible = false; // Disable update for API request
                else
                    VoiceReminder2.SetFormValue(val);
            }

            // Check field name 'VoiceReminder3' before field var 'x_VoiceReminder3'
            val = CurrentForm.HasValue("VoiceReminder3") ? CurrentForm.GetValue("VoiceReminder3") : CurrentForm.GetValue("x_VoiceReminder3");
            if (!VoiceReminder3.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("VoiceReminder3") && !CurrentForm.HasValue("x_VoiceReminder3")) // DN
                    VoiceReminder3.Visible = false; // Disable update for API request
                else
                    VoiceReminder3.SetFormValue(val);
            }

            // Check field name 'bit_isroadtest' before field var 'x_bit_isroadtest'
            val = CurrentForm.HasValue("bit_isroadtest") ? CurrentForm.GetValue("bit_isroadtest") : CurrentForm.GetValue("x_bit_isroadtest");
            if (!bit_isroadtest.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_isroadtest") && !CurrentForm.HasValue("x_bit_isroadtest")) // DN
                    bit_isroadtest.Visible = false; // Disable update for API request
                else
                    bit_isroadtest.SetFormValue(val);
            }

            // Check field name 'int_slotType' before field var 'x_int_slotType'
            val = CurrentForm.HasValue("int_slotType") ? CurrentForm.GetValue("int_slotType") : CurrentForm.GetValue("x_int_slotType");
            if (!int_slotType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_slotType") && !CurrentForm.HasValue("x_int_slotType")) // DN
                    int_slotType.Visible = false; // Disable update for API request
                else
                    int_slotType.SetFormValue(val, true, validate);
            }

            // Check field name 'bit_VisibleOnPortal' before field var 'x_bit_VisibleOnPortal'
            val = CurrentForm.HasValue("bit_VisibleOnPortal") ? CurrentForm.GetValue("bit_VisibleOnPortal") : CurrentForm.GetValue("x_bit_VisibleOnPortal");
            if (!bit_VisibleOnPortal.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_VisibleOnPortal") && !CurrentForm.HasValue("x_bit_VisibleOnPortal")) // DN
                    bit_VisibleOnPortal.Visible = false; // Disable update for API request
                else
                    bit_VisibleOnPortal.SetFormValue(val);
            }

            // Check field name 'IsDataRetrieved' before field var 'x_IsDataRetrieved'
            val = CurrentForm.HasValue("IsDataRetrieved") ? CurrentForm.GetValue("IsDataRetrieved") : CurrentForm.GetValue("x_IsDataRetrieved");
            if (!IsDataRetrieved.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDataRetrieved") && !CurrentForm.HasValue("x_IsDataRetrieved")) // DN
                    IsDataRetrieved.Visible = false; // Disable update for API request
                else
                    IsDataRetrieved.SetFormValue(val);
            }

            // Check field name 'bit_chargesApplied' before field var 'x_bit_chargesApplied'
            val = CurrentForm.HasValue("bit_chargesApplied") ? CurrentForm.GetValue("bit_chargesApplied") : CurrentForm.GetValue("x_bit_chargesApplied");
            if (!bit_chargesApplied.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_chargesApplied") && !CurrentForm.HasValue("x_bit_chargesApplied")) // DN
                    bit_chargesApplied.Visible = false; // Disable update for API request
                else
                    bit_chargesApplied.SetFormValue(val);
            }

            // Check field name 'dec_DistanceTravelled' before field var 'x_dec_DistanceTravelled'
            val = CurrentForm.HasValue("dec_DistanceTravelled") ? CurrentForm.GetValue("dec_DistanceTravelled") : CurrentForm.GetValue("x_dec_DistanceTravelled");
            if (!dec_DistanceTravelled.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_DistanceTravelled") && !CurrentForm.HasValue("x_dec_DistanceTravelled")) // DN
                    dec_DistanceTravelled.Visible = false; // Disable update for API request
                else
                    dec_DistanceTravelled.SetFormValue(val, true, validate);
            }

            // Check field name 'btwProductIdsforSSRules' before field var 'x_btwProductIdsforSSRules'
            val = CurrentForm.HasValue("btwProductIdsforSSRules") ? CurrentForm.GetValue("btwProductIdsforSSRules") : CurrentForm.GetValue("x_btwProductIdsforSSRules");
            if (!btwProductIdsforSSRules.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("btwProductIdsforSSRules") && !CurrentForm.HasValue("x_btwProductIdsforSSRules")) // DN
                    btwProductIdsforSSRules.Visible = false; // Disable update for API request
                else
                    btwProductIdsforSSRules.SetFormValue(val);
            }

            // Check field name 'int_evaluateApptWithEmail' before field var 'x_int_evaluateApptWithEmail'
            val = CurrentForm.HasValue("int_evaluateApptWithEmail") ? CurrentForm.GetValue("int_evaluateApptWithEmail") : CurrentForm.GetValue("x_int_evaluateApptWithEmail");
            if (!int_evaluateApptWithEmail.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_evaluateApptWithEmail") && !CurrentForm.HasValue("x_int_evaluateApptWithEmail")) // DN
                    int_evaluateApptWithEmail.Visible = false; // Disable update for API request
                else
                    int_evaluateApptWithEmail.SetFormValue(val, true, validate);
            }

            // Check field name 'PublicNotesId' before field var 'x_PublicNotesId'
            val = CurrentForm.HasValue("PublicNotesId") ? CurrentForm.GetValue("PublicNotesId") : CurrentForm.GetValue("x_PublicNotesId");
            if (!PublicNotesId.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("PublicNotesId") && !CurrentForm.HasValue("x_PublicNotesId")) // DN
                    PublicNotesId.Visible = false; // Disable update for API request
                else
                    PublicNotesId.SetFormValue(val);
            }

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val, true, validate);
            }

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }

            // Check field name 'int_PackageID' before field var 'x_int_PackageID'
            val = CurrentForm.HasValue("int_PackageID") ? CurrentForm.GetValue("int_PackageID") : CurrentForm.GetValue("x_int_PackageID");
            if (!int_PackageID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_PackageID") && !CurrentForm.HasValue("x_int_PackageID")) // DN
                    int_PackageID.Visible = false; // Disable update for API request
                else
                    int_PackageID.SetFormValue(val, true, validate);
            }

            // Check field name 'int_ApptCldr_ID' before field var 'x_int_ApptCldr_ID'
            val = CurrentForm.HasValue("int_ApptCldr_ID") ? CurrentForm.GetValue("int_ApptCldr_ID") : CurrentForm.GetValue("x_int_ApptCldr_ID");
            if (!int_ApptCldr_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_ApptCldr_ID") && !CurrentForm.HasValue("x_int_ApptCldr_ID")) // DN
                    int_ApptCldr_ID.Visible = false; // Disable update for API request
                else
                    int_ApptCldr_ID.SetFormValue(val, true, validate);
            }

            // Check field name 'str_CRSS_ID' before field var 'x_str_CRSS_ID'
            val = CurrentForm.HasValue("str_CRSS_ID") ? CurrentForm.GetValue("str_CRSS_ID") : CurrentForm.GetValue("x_str_CRSS_ID");
            if (!str_CRSS_ID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_CRSS_ID") && !CurrentForm.HasValue("x_str_CRSS_ID")) // DN
                    str_CRSS_ID.Visible = false; // Disable update for API request
                else
                    str_CRSS_ID.SetFormValue(val);
            }

            // Check field name 'int_Appt_id' before field var 'x_int_Appt_id'
            val = CurrentForm.HasValue("int_Appt_id") ? CurrentForm.GetValue("int_Appt_id") : CurrentForm.GetValue("x_int_Appt_id");
            await GetUploadFiles(); // Get upload files
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            str_AppName.CurrentValue = str_AppName.FormValue;
            str_App_Date.CurrentValue = str_App_Date.FormValue;
            str_StartTime.CurrentValue = str_StartTime.FormValue;
            str_EndTime.CurrentValue = str_EndTime.FormValue;
            str_PickupTime.CurrentValue = str_PickupTime.FormValue;
            str_DropOffTime.CurrentValue = str_DropOffTime.FormValue;
            int_VehicleID.CurrentValue = int_VehicleID.FormValue;
            dec_InstID.CurrentValue = dec_InstID.FormValue;
            dec_StudentID.CurrentValue = dec_StudentID.FormValue;
            dec_Observed_StudentID.CurrentValue = dec_Observed_StudentID.FormValue;
            int_Apptype.CurrentValue = int_Apptype.FormValue;
            int_AppStatus.CurrentValue = int_AppStatus.FormValue;
            mny_AppCost.CurrentValue = mny_AppCost.FormValue;
            mny_AmountPaid.CurrentValue = mny_AmountPaid.FormValue;
            bit_CheckAppPaid.CurrentValue = bit_CheckAppPaid.FormValue;
            bit_Confirmation.CurrentValue = bit_Confirmation.FormValue;
            str_Instructions.CurrentValue = str_Instructions.FormValue;
            str_Instructions1.CurrentValue = str_Instructions1.FormValue;
            str_AppNotes.CurrentValue = str_AppNotes.FormValue;
            str_PickupLocation.CurrentValue = str_PickupLocation.FormValue;
            int_Created_By.CurrentValue = int_Created_By.FormValue;
            int_Modified_By.CurrentValue = int_Modified_By.FormValue;
            date_Created.CurrentValue = date_Created.FormValue;
            date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            date_Modified.CurrentValue = date_Modified.FormValue;
            date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            bit_IsDeleted.CurrentValue = bit_IsDeleted.FormValue;
            str_Interval.CurrentValue = str_Interval.FormValue;
            RemM1.CurrentValue = RemM1.FormValue;
            RemM2.CurrentValue = RemM2.FormValue;
            RemM3.CurrentValue = RemM3.FormValue;
            int_Location_ID.CurrentValue = int_Location_ID.FormValue;
            SPID.CurrentValue = SPID.FormValue;
            Chk_Trace.CurrentValue = Chk_Trace.FormValue;
            str_DropOffLocation.CurrentValue = str_DropOffLocation.FormValue;
            dt_apptstart.CurrentValue = dt_apptstart.FormValue;
            dt_apptstart.CurrentValue = UnformatDateTime(dt_apptstart.CurrentValue, dt_apptstart.FormatPattern);
            dt_apptComplete.CurrentValue = dt_apptComplete.FormValue;
            dt_apptComplete.CurrentValue = UnformatDateTime(dt_apptComplete.CurrentValue, dt_apptComplete.FormatPattern);
            int_apptstartedBy.CurrentValue = int_apptstartedBy.FormValue;
            int_apptCompletedBy.CurrentValue = int_apptCompletedBy.FormValue;
            SMSReminder1.CurrentValue = SMSReminder1.FormValue;
            SMSReminder2.CurrentValue = SMSReminder2.FormValue;
            SMSReminder3.CurrentValue = SMSReminder3.FormValue;
            VoiceReminder1.CurrentValue = VoiceReminder1.FormValue;
            VoiceReminder2.CurrentValue = VoiceReminder2.FormValue;
            VoiceReminder3.CurrentValue = VoiceReminder3.FormValue;
            bit_isroadtest.CurrentValue = bit_isroadtest.FormValue;
            int_slotType.CurrentValue = int_slotType.FormValue;
            bit_VisibleOnPortal.CurrentValue = bit_VisibleOnPortal.FormValue;
            IsDataRetrieved.CurrentValue = IsDataRetrieved.FormValue;
            bit_chargesApplied.CurrentValue = bit_chargesApplied.FormValue;
            dec_DistanceTravelled.CurrentValue = dec_DistanceTravelled.FormValue;
            btwProductIdsforSSRules.CurrentValue = btwProductIdsforSSRules.FormValue;
            int_evaluateApptWithEmail.CurrentValue = int_evaluateApptWithEmail.FormValue;
            PublicNotesId.CurrentValue = PublicNotesId.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            int_PackageID.CurrentValue = int_PackageID.FormValue;
            int_ApptCldr_ID.CurrentValue = int_ApptCldr_ID.FormValue;
            str_CRSS_ID.CurrentValue = str_CRSS_ID.FormValue;
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
            int_Appt_id.SetDbValue(row["int_Appt_id"]);
            str_AppName.SetDbValue(row["str_AppName"]);
            str_App_Date.SetDbValue(row["str_App_Date"]);
            str_StartTime.SetDbValue(row["str_StartTime"]);
            str_EndTime.SetDbValue(row["str_EndTime"]);
            str_PickupTime.SetDbValue(row["str_PickupTime"]);
            str_DropOffTime.SetDbValue(row["str_DropOffTime"]);
            int_VehicleID.SetDbValue(row["int_VehicleID"]);
            dec_InstID.SetDbValue(IsNull(row["dec_InstID"]) ? DbNullValue : ConvertToDouble(row["dec_InstID"]));
            dec_StudentID.SetDbValue(row["dec_StudentID"]);
            dec_Observed_StudentID.SetDbValue(row["dec_Observed_StudentID"]);
            int_Apptype.SetDbValue(row["int_Apptype"]);
            int_AppStatus.SetDbValue(row["int_AppStatus"]);
            mny_AppCost.SetDbValue(row["mny_AppCost"]);
            mny_AmountPaid.SetDbValue(row["mny_AmountPaid"]);
            bit_CheckAppPaid.SetDbValue((ConvertToBool(row["bit_CheckAppPaid"]) ? "1" : "0"));
            bit_Confirmation.SetDbValue((ConvertToBool(row["bit_Confirmation"]) ? "1" : "0"));
            str_Instructions.SetDbValue(row["str_Instructions"]);
            str_Instructions1.SetDbValue(row["str_Instructions1"]);
            str_AppNotes.SetDbValue(row["str_AppNotes"]);
            str_PickupLocation.SetDbValue(row["str_PickupLocation"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_Interval.SetDbValue(row["str_Interval"]);
            RemM1.SetDbValue((ConvertToBool(row["RemM1"]) ? "1" : "0"));
            RemM2.SetDbValue((ConvertToBool(row["RemM2"]) ? "1" : "0"));
            RemM3.SetDbValue((ConvertToBool(row["RemM3"]) ? "1" : "0"));
            int_Location_ID.SetDbValue(IsNull(row["int_Location_ID"]) ? DbNullValue : ConvertToDouble(row["int_Location_ID"]));
            SPID.SetDbValue(IsNull(row["SPID"]) ? DbNullValue : ConvertToDouble(row["SPID"]));
            Chk_Trace.SetDbValue(row["Chk_Trace"]);
            str_DropOffLocation.SetDbValue(row["str_DropOffLocation"]);
            imgInstructorSignature.Upload.DbValue = row["imgInstructorSignature"];
            imgStudentSignature.Upload.DbValue = row["imgStudentSignature"];
            imgObserverSignature.Upload.DbValue = row["imgObserverSignature"];
            dt_apptstart.SetDbValue(row["dt_apptstart"]);
            dt_apptComplete.SetDbValue(row["dt_apptComplete"]);
            int_apptstartedBy.SetDbValue(row["int_apptstartedBy"]);
            int_apptCompletedBy.SetDbValue(row["int_apptCompletedBy"]);
            SMSReminder1.SetDbValue((ConvertToBool(row["SMSReminder1"]) ? "1" : "0"));
            SMSReminder2.SetDbValue((ConvertToBool(row["SMSReminder2"]) ? "1" : "0"));
            SMSReminder3.SetDbValue((ConvertToBool(row["SMSReminder3"]) ? "1" : "0"));
            VoiceReminder1.SetDbValue((ConvertToBool(row["VoiceReminder1"]) ? "1" : "0"));
            VoiceReminder2.SetDbValue((ConvertToBool(row["VoiceReminder2"]) ? "1" : "0"));
            VoiceReminder3.SetDbValue((ConvertToBool(row["VoiceReminder3"]) ? "1" : "0"));
            bit_isroadtest.SetDbValue((ConvertToBool(row["bit_isroadtest"]) ? "1" : "0"));
            int_slotType.SetDbValue(row["int_slotType"]);
            bit_VisibleOnPortal.SetDbValue((ConvertToBool(row["bit_VisibleOnPortal"]) ? "1" : "0"));
            IsDataRetrieved.SetDbValue((ConvertToBool(row["IsDataRetrieved"]) ? "1" : "0"));
            bit_chargesApplied.SetDbValue((ConvertToBool(row["bit_chargesApplied"]) ? "1" : "0"));
            dec_DistanceTravelled.SetDbValue(IsNull(row["dec_DistanceTravelled"]) ? DbNullValue : ConvertToDouble(row["dec_DistanceTravelled"]));
            btwProductIdsforSSRules.SetDbValue(row["btwProductIdsforSSRules"]);
            int_evaluateApptWithEmail.SetDbValue(row["int_evaluateApptWithEmail"]);
            PublicNotesId.SetDbValue(row["PublicNotesId"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_PackageID.SetDbValue(row["int_PackageID"]);
            int_ApptCldr_ID.SetDbValue(row["int_ApptCldr_ID"]);
            str_CRSS_ID.SetDbValue(row["str_CRSS_ID"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Appt_id", int_Appt_id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AppName", str_AppName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_App_Date", str_App_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("str_StartTime", str_StartTime.DefaultValue ?? DbNullValue); // DN
            row.Add("str_EndTime", str_EndTime.DefaultValue ?? DbNullValue); // DN
            row.Add("str_PickupTime", str_PickupTime.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DropOffTime", str_DropOffTime.DefaultValue ?? DbNullValue); // DN
            row.Add("int_VehicleID", int_VehicleID.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_InstID", dec_InstID.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_StudentID", dec_StudentID.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Observed_StudentID", dec_Observed_StudentID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Apptype", int_Apptype.DefaultValue ?? DbNullValue); // DN
            row.Add("int_AppStatus", int_AppStatus.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_AppCost", mny_AppCost.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_AmountPaid", mny_AmountPaid.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_CheckAppPaid", bit_CheckAppPaid.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Confirmation", bit_Confirmation.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Instructions", str_Instructions.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Instructions1", str_Instructions1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AppNotes", str_AppNotes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_PickupLocation", str_PickupLocation.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Interval", str_Interval.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM1", RemM1.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM2", RemM2.DefaultValue ?? DbNullValue); // DN
            row.Add("RemM3", RemM3.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_ID", int_Location_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("SPID", SPID.DefaultValue ?? DbNullValue); // DN
            row.Add("Chk_Trace", Chk_Trace.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DropOffLocation", str_DropOffLocation.DefaultValue ?? DbNullValue); // DN
            row.Add("imgInstructorSignature", imgInstructorSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("imgStudentSignature", imgStudentSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("imgObserverSignature", imgObserverSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_apptstart", dt_apptstart.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_apptComplete", dt_apptComplete.DefaultValue ?? DbNullValue); // DN
            row.Add("int_apptstartedBy", int_apptstartedBy.DefaultValue ?? DbNullValue); // DN
            row.Add("int_apptCompletedBy", int_apptCompletedBy.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder1", SMSReminder1.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder2", SMSReminder2.DefaultValue ?? DbNullValue); // DN
            row.Add("SMSReminder3", SMSReminder3.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder1", VoiceReminder1.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder2", VoiceReminder2.DefaultValue ?? DbNullValue); // DN
            row.Add("VoiceReminder3", VoiceReminder3.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_isroadtest", bit_isroadtest.DefaultValue ?? DbNullValue); // DN
            row.Add("int_slotType", int_slotType.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_VisibleOnPortal", bit_VisibleOnPortal.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDataRetrieved", IsDataRetrieved.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_chargesApplied", bit_chargesApplied.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_DistanceTravelled", dec_DistanceTravelled.DefaultValue ?? DbNullValue); // DN
            row.Add("btwProductIdsforSSRules", btwProductIdsforSSRules.DefaultValue ?? DbNullValue); // DN
            row.Add("int_evaluateApptWithEmail", int_evaluateApptWithEmail.DefaultValue ?? DbNullValue); // DN
            row.Add("PublicNotesId", PublicNotesId.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PackageID", int_PackageID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ApptCldr_ID", int_ApptCldr_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CRSS_ID", str_CRSS_ID.DefaultValue ?? DbNullValue); // DN
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

            // int_Appt_id
            int_Appt_id.RowCssClass = "row";

            // str_AppName
            str_AppName.RowCssClass = "row";

            // str_App_Date
            str_App_Date.RowCssClass = "row";

            // str_StartTime
            str_StartTime.RowCssClass = "row";

            // str_EndTime
            str_EndTime.RowCssClass = "row";

            // str_PickupTime
            str_PickupTime.RowCssClass = "row";

            // str_DropOffTime
            str_DropOffTime.RowCssClass = "row";

            // int_VehicleID
            int_VehicleID.RowCssClass = "row";

            // dec_InstID
            dec_InstID.RowCssClass = "row";

            // dec_StudentID
            dec_StudentID.RowCssClass = "row";

            // dec_Observed_StudentID
            dec_Observed_StudentID.RowCssClass = "row";

            // int_Apptype
            int_Apptype.RowCssClass = "row";

            // int_AppStatus
            int_AppStatus.RowCssClass = "row";

            // mny_AppCost
            mny_AppCost.RowCssClass = "row";

            // mny_AmountPaid
            mny_AmountPaid.RowCssClass = "row";

            // bit_CheckAppPaid
            bit_CheckAppPaid.RowCssClass = "row";

            // bit_Confirmation
            bit_Confirmation.RowCssClass = "row";

            // str_Instructions
            str_Instructions.RowCssClass = "row";

            // str_Instructions1
            str_Instructions1.RowCssClass = "row";

            // str_AppNotes
            str_AppNotes.RowCssClass = "row";

            // str_PickupLocation
            str_PickupLocation.RowCssClass = "row";

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

            // str_Interval
            str_Interval.RowCssClass = "row";

            // RemM1
            RemM1.RowCssClass = "row";

            // RemM2
            RemM2.RowCssClass = "row";

            // RemM3
            RemM3.RowCssClass = "row";

            // int_Location_ID
            int_Location_ID.RowCssClass = "row";

            // SPID
            SPID.RowCssClass = "row";

            // Chk_Trace
            Chk_Trace.RowCssClass = "row";

            // str_DropOffLocation
            str_DropOffLocation.RowCssClass = "row";

            // imgInstructorSignature
            imgInstructorSignature.RowCssClass = "row";

            // imgStudentSignature
            imgStudentSignature.RowCssClass = "row";

            // imgObserverSignature
            imgObserverSignature.RowCssClass = "row";

            // dt_apptstart
            dt_apptstart.RowCssClass = "row";

            // dt_apptComplete
            dt_apptComplete.RowCssClass = "row";

            // int_apptstartedBy
            int_apptstartedBy.RowCssClass = "row";

            // int_apptCompletedBy
            int_apptCompletedBy.RowCssClass = "row";

            // SMSReminder1
            SMSReminder1.RowCssClass = "row";

            // SMSReminder2
            SMSReminder2.RowCssClass = "row";

            // SMSReminder3
            SMSReminder3.RowCssClass = "row";

            // VoiceReminder1
            VoiceReminder1.RowCssClass = "row";

            // VoiceReminder2
            VoiceReminder2.RowCssClass = "row";

            // VoiceReminder3
            VoiceReminder3.RowCssClass = "row";

            // bit_isroadtest
            bit_isroadtest.RowCssClass = "row";

            // int_slotType
            int_slotType.RowCssClass = "row";

            // bit_VisibleOnPortal
            bit_VisibleOnPortal.RowCssClass = "row";

            // IsDataRetrieved
            IsDataRetrieved.RowCssClass = "row";

            // bit_chargesApplied
            bit_chargesApplied.RowCssClass = "row";

            // dec_DistanceTravelled
            dec_DistanceTravelled.RowCssClass = "row";

            // btwProductIdsforSSRules
            btwProductIdsforSSRules.RowCssClass = "row";

            // int_evaluateApptWithEmail
            int_evaluateApptWithEmail.RowCssClass = "row";

            // PublicNotesId
            PublicNotesId.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // int_PackageID
            int_PackageID.RowCssClass = "row";

            // int_ApptCldr_ID
            int_ApptCldr_ID.RowCssClass = "row";

            // str_CRSS_ID
            str_CRSS_ID.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // int_Appt_id
                int_Appt_id.ViewValue = int_Appt_id.CurrentValue;
                int_Appt_id.ViewCustomAttributes = "";

                // str_AppName
                str_AppName.ViewValue = ConvertToString(str_AppName.CurrentValue); // DN
                str_AppName.ViewCustomAttributes = "";

                // str_App_Date
                str_App_Date.ViewValue = ConvertToString(str_App_Date.CurrentValue); // DN
                str_App_Date.ViewCustomAttributes = "";

                // str_StartTime
                str_StartTime.ViewValue = ConvertToString(str_StartTime.CurrentValue); // DN
                str_StartTime.ViewCustomAttributes = "";

                // str_EndTime
                str_EndTime.ViewValue = ConvertToString(str_EndTime.CurrentValue); // DN
                str_EndTime.ViewCustomAttributes = "";

                // str_PickupTime
                str_PickupTime.ViewValue = ConvertToString(str_PickupTime.CurrentValue); // DN
                str_PickupTime.ViewCustomAttributes = "";

                // str_DropOffTime
                str_DropOffTime.ViewValue = ConvertToString(str_DropOffTime.CurrentValue); // DN
                str_DropOffTime.ViewCustomAttributes = "";

                // int_VehicleID
                int_VehicleID.ViewValue = int_VehicleID.CurrentValue;
                int_VehicleID.ViewValue = FormatNumber(int_VehicleID.ViewValue, int_VehicleID.FormatPattern);
                int_VehicleID.ViewCustomAttributes = "";

                // dec_InstID
                dec_InstID.ViewValue = dec_InstID.CurrentValue;
                dec_InstID.ViewValue = FormatNumber(dec_InstID.ViewValue, dec_InstID.FormatPattern);
                dec_InstID.ViewCustomAttributes = "";

                // dec_StudentID
                dec_StudentID.ViewValue = dec_StudentID.CurrentValue;
                dec_StudentID.ViewValue = FormatNumber(dec_StudentID.ViewValue, dec_StudentID.FormatPattern);
                dec_StudentID.ViewCustomAttributes = "";

                // dec_Observed_StudentID
                dec_Observed_StudentID.ViewValue = dec_Observed_StudentID.CurrentValue;
                dec_Observed_StudentID.ViewValue = FormatNumber(dec_Observed_StudentID.ViewValue, dec_Observed_StudentID.FormatPattern);
                dec_Observed_StudentID.ViewCustomAttributes = "";

                // int_Apptype
                int_Apptype.ViewValue = int_Apptype.CurrentValue;
                curVal = ConvertToString(int_Apptype.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Apptype.Lookup != null && IsDictionary(int_Apptype.Lookup?.Options) && int_Apptype.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Apptype.ViewValue = int_Apptype.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_AppType]", "=", int_Apptype.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Apptype.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Apptype.Lookup != null) { // Lookup values found
                            var listwrk = int_Apptype.Lookup?.RenderViewRow(rswrk[0]);
                            int_Apptype.ViewValue = int_Apptype.HighlightLookup(ConvertToString(rswrk[0]), int_Apptype.DisplayValue(listwrk));
                        } else {
                            int_Apptype.ViewValue = FormatNumber(int_Apptype.CurrentValue, int_Apptype.FormatPattern);
                        }
                    }
                } else {
                    int_Apptype.ViewValue = DbNullValue;
                }
                int_Apptype.ViewCustomAttributes = "";

                // int_AppStatus
                if (!Empty(int_AppStatus.CurrentValue)) {
                    int_AppStatus.ViewValue = int_AppStatus.HighlightLookup(ConvertToString(int_AppStatus.CurrentValue), int_AppStatus.OptionCaption(ConvertToString(int_AppStatus.CurrentValue)));
                } else {
                    int_AppStatus.ViewValue = DbNullValue;
                }
                int_AppStatus.ViewCustomAttributes = "";

                // mny_AppCost
                mny_AppCost.ViewValue = mny_AppCost.CurrentValue;
                mny_AppCost.ViewValue = FormatNumber(mny_AppCost.ViewValue, mny_AppCost.FormatPattern);
                mny_AppCost.ViewCustomAttributes = "";

                // mny_AmountPaid
                mny_AmountPaid.ViewValue = mny_AmountPaid.CurrentValue;
                mny_AmountPaid.ViewValue = FormatNumber(mny_AmountPaid.ViewValue, mny_AmountPaid.FormatPattern);
                mny_AmountPaid.ViewCustomAttributes = "";

                // bit_CheckAppPaid
                if (ConvertToBool(bit_CheckAppPaid.CurrentValue)) {
                    bit_CheckAppPaid.ViewValue = bit_CheckAppPaid.TagCaption(1) != "" ? bit_CheckAppPaid.TagCaption(1) : "Yes";
                } else {
                    bit_CheckAppPaid.ViewValue = bit_CheckAppPaid.TagCaption(2) != "" ? bit_CheckAppPaid.TagCaption(2) : "No";
                }
                bit_CheckAppPaid.ViewCustomAttributes = "";

                // bit_Confirmation
                if (ConvertToBool(bit_Confirmation.CurrentValue)) {
                    bit_Confirmation.ViewValue = bit_Confirmation.TagCaption(1) != "" ? bit_Confirmation.TagCaption(1) : "Yes";
                } else {
                    bit_Confirmation.ViewValue = bit_Confirmation.TagCaption(2) != "" ? bit_Confirmation.TagCaption(2) : "No";
                }
                bit_Confirmation.ViewCustomAttributes = "";

                // str_Instructions
                str_Instructions.ViewValue = ConvertToString(str_Instructions.CurrentValue); // DN
                str_Instructions.ViewCustomAttributes = "";

                // str_Instructions1
                str_Instructions1.ViewValue = ConvertToString(str_Instructions1.CurrentValue); // DN
                str_Instructions1.ViewCustomAttributes = "";

                // str_AppNotes
                str_AppNotes.ViewValue = ConvertToString(str_AppNotes.CurrentValue); // DN
                str_AppNotes.ViewCustomAttributes = "";

                // str_PickupLocation
                str_PickupLocation.ViewValue = ConvertToString(str_PickupLocation.CurrentValue); // DN
                str_PickupLocation.ViewCustomAttributes = "";

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

                // str_Interval
                str_Interval.ViewValue = ConvertToString(str_Interval.CurrentValue); // DN
                str_Interval.ViewCustomAttributes = "";

                // RemM1
                if (ConvertToBool(RemM1.CurrentValue)) {
                    RemM1.ViewValue = RemM1.TagCaption(1) != "" ? RemM1.TagCaption(1) : "Yes";
                } else {
                    RemM1.ViewValue = RemM1.TagCaption(2) != "" ? RemM1.TagCaption(2) : "No";
                }
                RemM1.ViewCustomAttributes = "";

                // RemM2
                if (ConvertToBool(RemM2.CurrentValue)) {
                    RemM2.ViewValue = RemM2.TagCaption(1) != "" ? RemM2.TagCaption(1) : "Yes";
                } else {
                    RemM2.ViewValue = RemM2.TagCaption(2) != "" ? RemM2.TagCaption(2) : "No";
                }
                RemM2.ViewCustomAttributes = "";

                // RemM3
                if (ConvertToBool(RemM3.CurrentValue)) {
                    RemM3.ViewValue = RemM3.TagCaption(1) != "" ? RemM3.TagCaption(1) : "Yes";
                } else {
                    RemM3.ViewValue = RemM3.TagCaption(2) != "" ? RemM3.TagCaption(2) : "No";
                }
                RemM3.ViewCustomAttributes = "";

                // int_Location_ID
                int_Location_ID.ViewValue = int_Location_ID.CurrentValue;
                int_Location_ID.ViewValue = FormatNumber(int_Location_ID.ViewValue, int_Location_ID.FormatPattern);
                int_Location_ID.ViewCustomAttributes = "";

                // SPID
                SPID.ViewValue = SPID.CurrentValue;
                SPID.ViewValue = FormatNumber(SPID.ViewValue, SPID.FormatPattern);
                SPID.ViewCustomAttributes = "";

                // Chk_Trace
                Chk_Trace.ViewValue = ConvertToString(Chk_Trace.CurrentValue); // DN
                Chk_Trace.ViewCustomAttributes = "";

                // str_DropOffLocation
                str_DropOffLocation.ViewValue = ConvertToString(str_DropOffLocation.CurrentValue); // DN
                str_DropOffLocation.ViewCustomAttributes = "";

                // imgInstructorSignature
                if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                    imgInstructorSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgInstructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgInstructorSignature.Upload.DbValue));
                } else {
                    imgInstructorSignature.ViewValue = "";
                }
                imgInstructorSignature.ViewCustomAttributes = "";

                // imgStudentSignature
                if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                    imgStudentSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgStudentSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgStudentSignature.Upload.DbValue));
                } else {
                    imgStudentSignature.ViewValue = "";
                }
                imgStudentSignature.ViewCustomAttributes = "";

                // imgObserverSignature
                if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                    imgObserverSignature.ViewValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgObserverSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgObserverSignature.Upload.DbValue));
                } else {
                    imgObserverSignature.ViewValue = "";
                }
                imgObserverSignature.ViewCustomAttributes = "";

                // dt_apptstart
                dt_apptstart.ViewValue = dt_apptstart.CurrentValue;
                dt_apptstart.ViewValue = FormatDateTime(dt_apptstart.ViewValue, dt_apptstart.FormatPattern);
                dt_apptstart.ViewCustomAttributes = "";

                // dt_apptComplete
                dt_apptComplete.ViewValue = dt_apptComplete.CurrentValue;
                dt_apptComplete.ViewValue = FormatDateTime(dt_apptComplete.ViewValue, dt_apptComplete.FormatPattern);
                dt_apptComplete.ViewCustomAttributes = "";

                // int_apptstartedBy
                int_apptstartedBy.ViewValue = int_apptstartedBy.CurrentValue;
                int_apptstartedBy.ViewValue = FormatNumber(int_apptstartedBy.ViewValue, int_apptstartedBy.FormatPattern);
                int_apptstartedBy.ViewCustomAttributes = "";

                // int_apptCompletedBy
                int_apptCompletedBy.ViewValue = int_apptCompletedBy.CurrentValue;
                int_apptCompletedBy.ViewValue = FormatNumber(int_apptCompletedBy.ViewValue, int_apptCompletedBy.FormatPattern);
                int_apptCompletedBy.ViewCustomAttributes = "";

                // SMSReminder1
                if (ConvertToBool(SMSReminder1.CurrentValue)) {
                    SMSReminder1.ViewValue = SMSReminder1.TagCaption(1) != "" ? SMSReminder1.TagCaption(1) : "Yes";
                } else {
                    SMSReminder1.ViewValue = SMSReminder1.TagCaption(2) != "" ? SMSReminder1.TagCaption(2) : "No";
                }
                SMSReminder1.ViewCustomAttributes = "";

                // SMSReminder2
                if (ConvertToBool(SMSReminder2.CurrentValue)) {
                    SMSReminder2.ViewValue = SMSReminder2.TagCaption(1) != "" ? SMSReminder2.TagCaption(1) : "Yes";
                } else {
                    SMSReminder2.ViewValue = SMSReminder2.TagCaption(2) != "" ? SMSReminder2.TagCaption(2) : "No";
                }
                SMSReminder2.ViewCustomAttributes = "";

                // SMSReminder3
                if (ConvertToBool(SMSReminder3.CurrentValue)) {
                    SMSReminder3.ViewValue = SMSReminder3.TagCaption(1) != "" ? SMSReminder3.TagCaption(1) : "Yes";
                } else {
                    SMSReminder3.ViewValue = SMSReminder3.TagCaption(2) != "" ? SMSReminder3.TagCaption(2) : "No";
                }
                SMSReminder3.ViewCustomAttributes = "";

                // VoiceReminder1
                if (ConvertToBool(VoiceReminder1.CurrentValue)) {
                    VoiceReminder1.ViewValue = VoiceReminder1.TagCaption(1) != "" ? VoiceReminder1.TagCaption(1) : "Yes";
                } else {
                    VoiceReminder1.ViewValue = VoiceReminder1.TagCaption(2) != "" ? VoiceReminder1.TagCaption(2) : "No";
                }
                VoiceReminder1.ViewCustomAttributes = "";

                // VoiceReminder2
                if (ConvertToBool(VoiceReminder2.CurrentValue)) {
                    VoiceReminder2.ViewValue = VoiceReminder2.TagCaption(1) != "" ? VoiceReminder2.TagCaption(1) : "Yes";
                } else {
                    VoiceReminder2.ViewValue = VoiceReminder2.TagCaption(2) != "" ? VoiceReminder2.TagCaption(2) : "No";
                }
                VoiceReminder2.ViewCustomAttributes = "";

                // VoiceReminder3
                if (ConvertToBool(VoiceReminder3.CurrentValue)) {
                    VoiceReminder3.ViewValue = VoiceReminder3.TagCaption(1) != "" ? VoiceReminder3.TagCaption(1) : "Yes";
                } else {
                    VoiceReminder3.ViewValue = VoiceReminder3.TagCaption(2) != "" ? VoiceReminder3.TagCaption(2) : "No";
                }
                VoiceReminder3.ViewCustomAttributes = "";

                // bit_isroadtest
                if (ConvertToBool(bit_isroadtest.CurrentValue)) {
                    bit_isroadtest.ViewValue = bit_isroadtest.TagCaption(1) != "" ? bit_isroadtest.TagCaption(1) : "Yes";
                } else {
                    bit_isroadtest.ViewValue = bit_isroadtest.TagCaption(2) != "" ? bit_isroadtest.TagCaption(2) : "No";
                }
                bit_isroadtest.ViewCustomAttributes = "";

                // int_slotType
                int_slotType.ViewValue = int_slotType.CurrentValue;
                int_slotType.ViewValue = FormatNumber(int_slotType.ViewValue, int_slotType.FormatPattern);
                int_slotType.ViewCustomAttributes = "";

                // bit_VisibleOnPortal
                if (ConvertToBool(bit_VisibleOnPortal.CurrentValue)) {
                    bit_VisibleOnPortal.ViewValue = bit_VisibleOnPortal.TagCaption(1) != "" ? bit_VisibleOnPortal.TagCaption(1) : "Yes";
                } else {
                    bit_VisibleOnPortal.ViewValue = bit_VisibleOnPortal.TagCaption(2) != "" ? bit_VisibleOnPortal.TagCaption(2) : "No";
                }
                bit_VisibleOnPortal.ViewCustomAttributes = "";

                // IsDataRetrieved
                if (ConvertToBool(IsDataRetrieved.CurrentValue)) {
                    IsDataRetrieved.ViewValue = IsDataRetrieved.TagCaption(1) != "" ? IsDataRetrieved.TagCaption(1) : "Yes";
                } else {
                    IsDataRetrieved.ViewValue = IsDataRetrieved.TagCaption(2) != "" ? IsDataRetrieved.TagCaption(2) : "No";
                }
                IsDataRetrieved.ViewCustomAttributes = "";

                // bit_chargesApplied
                if (ConvertToBool(bit_chargesApplied.CurrentValue)) {
                    bit_chargesApplied.ViewValue = bit_chargesApplied.TagCaption(1) != "" ? bit_chargesApplied.TagCaption(1) : "Yes";
                } else {
                    bit_chargesApplied.ViewValue = bit_chargesApplied.TagCaption(2) != "" ? bit_chargesApplied.TagCaption(2) : "No";
                }
                bit_chargesApplied.ViewCustomAttributes = "";

                // dec_DistanceTravelled
                dec_DistanceTravelled.ViewValue = dec_DistanceTravelled.CurrentValue;
                dec_DistanceTravelled.ViewValue = FormatNumber(dec_DistanceTravelled.ViewValue, dec_DistanceTravelled.FormatPattern);
                dec_DistanceTravelled.ViewCustomAttributes = "";

                // btwProductIdsforSSRules
                btwProductIdsforSSRules.ViewValue = btwProductIdsforSSRules.CurrentValue;
                btwProductIdsforSSRules.ViewCustomAttributes = "";

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.ViewValue = int_evaluateApptWithEmail.CurrentValue;
                int_evaluateApptWithEmail.ViewValue = FormatNumber(int_evaluateApptWithEmail.ViewValue, int_evaluateApptWithEmail.FormatPattern);
                int_evaluateApptWithEmail.ViewCustomAttributes = "";

                // PublicNotesId
                PublicNotesId.ViewValue = PublicNotesId.CurrentValue;
                PublicNotesId.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
                NationalID.ViewValue = FormatNumber(NationalID.ViewValue, NationalID.FormatPattern);
                NationalID.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // int_PackageID
                int_PackageID.ViewValue = int_PackageID.CurrentValue;
                int_PackageID.ViewValue = FormatNumber(int_PackageID.ViewValue, int_PackageID.FormatPattern);
                int_PackageID.ViewCustomAttributes = "";

                // int_ApptCldr_ID
                int_ApptCldr_ID.ViewValue = int_ApptCldr_ID.CurrentValue;
                int_ApptCldr_ID.ViewValue = FormatNumber(int_ApptCldr_ID.ViewValue, int_ApptCldr_ID.FormatPattern);
                int_ApptCldr_ID.ViewCustomAttributes = "";

                // str_CRSS_ID
                str_CRSS_ID.ViewValue = ConvertToString(str_CRSS_ID.CurrentValue); // DN
                str_CRSS_ID.ViewCustomAttributes = "";

                // str_AppName
                str_AppName.HrefValue = "";

                // str_App_Date
                str_App_Date.HrefValue = "";

                // str_StartTime
                str_StartTime.HrefValue = "";

                // str_EndTime
                str_EndTime.HrefValue = "";

                // str_PickupTime
                str_PickupTime.HrefValue = "";

                // str_DropOffTime
                str_DropOffTime.HrefValue = "";

                // int_VehicleID
                int_VehicleID.HrefValue = "";

                // dec_InstID
                dec_InstID.HrefValue = "";

                // dec_StudentID
                dec_StudentID.HrefValue = "";

                // dec_Observed_StudentID
                dec_Observed_StudentID.HrefValue = "";

                // int_Apptype
                int_Apptype.HrefValue = "";
                int_Apptype.TooltipValue = "";

                // int_AppStatus
                int_AppStatus.HrefValue = "";

                // mny_AppCost
                mny_AppCost.HrefValue = "";
                mny_AppCost.TooltipValue = "";

                // mny_AmountPaid
                mny_AmountPaid.HrefValue = "";
                mny_AmountPaid.TooltipValue = "";

                // bit_CheckAppPaid
                bit_CheckAppPaid.HrefValue = "";

                // bit_Confirmation
                bit_Confirmation.HrefValue = "";

                // str_Instructions
                str_Instructions.HrefValue = "";

                // str_Instructions1
                str_Instructions1.HrefValue = "";

                // str_AppNotes
                str_AppNotes.HrefValue = "";

                // str_PickupLocation
                str_PickupLocation.HrefValue = "";

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

                // str_Interval
                str_Interval.HrefValue = "";

                // RemM1
                RemM1.HrefValue = "";

                // RemM2
                RemM2.HrefValue = "";

                // RemM3
                RemM3.HrefValue = "";

                // int_Location_ID
                int_Location_ID.HrefValue = "";

                // SPID
                SPID.HrefValue = "";

                // Chk_Trace
                Chk_Trace.HrefValue = "";

                // str_DropOffLocation
                str_DropOffLocation.HrefValue = "";

                // imgInstructorSignature
                if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                    imgInstructorSignature.HrefValue = AppPath(GetFileUploadUrl(imgInstructorSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgInstructorSignature.LinkAttrs["target"] = "";
                    if (imgInstructorSignature.IsBlobImage && Empty(imgInstructorSignature.LinkAttrs["target"]))
                        imgInstructorSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgInstructorSignature.HrefValue = FullUrl(ConvertToString(imgInstructorSignature.HrefValue), "href");
                } else {
                    imgInstructorSignature.HrefValue = "";
                }
                imgInstructorSignature.ExportHrefValue = GetFileUploadUrl(imgInstructorSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));

                // imgStudentSignature
                if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                    imgStudentSignature.HrefValue = AppPath(GetFileUploadUrl(imgStudentSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgStudentSignature.LinkAttrs["target"] = "";
                    if (imgStudentSignature.IsBlobImage && Empty(imgStudentSignature.LinkAttrs["target"]))
                        imgStudentSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgStudentSignature.HrefValue = FullUrl(ConvertToString(imgStudentSignature.HrefValue), "href");
                } else {
                    imgStudentSignature.HrefValue = "";
                }
                imgStudentSignature.ExportHrefValue = GetFileUploadUrl(imgStudentSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));

                // imgObserverSignature
                if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                    imgObserverSignature.HrefValue = AppPath(GetFileUploadUrl(imgObserverSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgObserverSignature.LinkAttrs["target"] = "";
                    if (imgObserverSignature.IsBlobImage && Empty(imgObserverSignature.LinkAttrs["target"]))
                        imgObserverSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgObserverSignature.HrefValue = FullUrl(ConvertToString(imgObserverSignature.HrefValue), "href");
                } else {
                    imgObserverSignature.HrefValue = "";
                }
                imgObserverSignature.ExportHrefValue = GetFileUploadUrl(imgObserverSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));

                // dt_apptstart
                dt_apptstart.HrefValue = "";

                // dt_apptComplete
                dt_apptComplete.HrefValue = "";

                // int_apptstartedBy
                int_apptstartedBy.HrefValue = "";

                // int_apptCompletedBy
                int_apptCompletedBy.HrefValue = "";

                // SMSReminder1
                SMSReminder1.HrefValue = "";

                // SMSReminder2
                SMSReminder2.HrefValue = "";

                // SMSReminder3
                SMSReminder3.HrefValue = "";

                // VoiceReminder1
                VoiceReminder1.HrefValue = "";

                // VoiceReminder2
                VoiceReminder2.HrefValue = "";

                // VoiceReminder3
                VoiceReminder3.HrefValue = "";

                // bit_isroadtest
                bit_isroadtest.HrefValue = "";

                // int_slotType
                int_slotType.HrefValue = "";

                // bit_VisibleOnPortal
                bit_VisibleOnPortal.HrefValue = "";

                // IsDataRetrieved
                IsDataRetrieved.HrefValue = "";

                // bit_chargesApplied
                bit_chargesApplied.HrefValue = "";

                // dec_DistanceTravelled
                dec_DistanceTravelled.HrefValue = "";

                // btwProductIdsforSSRules
                btwProductIdsforSSRules.HrefValue = "";

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.HrefValue = "";

                // PublicNotesId
                PublicNotesId.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // int_PackageID
                int_PackageID.HrefValue = "";

                // int_ApptCldr_ID
                int_ApptCldr_ID.HrefValue = "";

                // str_CRSS_ID
                str_CRSS_ID.HrefValue = "";
            } else if (RowType == RowType.Add) {
                // str_AppName
                str_AppName.SetupEditAttributes();
                if (!str_AppName.Raw)
                    str_AppName.CurrentValue = HtmlDecode(str_AppName.CurrentValue);
                str_AppName.EditValue = HtmlEncode(str_AppName.CurrentValue);
                str_AppName.PlaceHolder = RemoveHtml(str_AppName.Caption);

                // str_App_Date
                str_App_Date.SetupEditAttributes();
                if (!str_App_Date.Raw)
                    str_App_Date.CurrentValue = HtmlDecode(str_App_Date.CurrentValue);
                str_App_Date.EditValue = HtmlEncode(str_App_Date.CurrentValue);
                str_App_Date.PlaceHolder = RemoveHtml(str_App_Date.Caption);

                // str_StartTime
                str_StartTime.SetupEditAttributes();
                if (!str_StartTime.Raw)
                    str_StartTime.CurrentValue = HtmlDecode(str_StartTime.CurrentValue);
                str_StartTime.EditValue = HtmlEncode(str_StartTime.CurrentValue);
                str_StartTime.PlaceHolder = RemoveHtml(str_StartTime.Caption);

                // str_EndTime
                str_EndTime.SetupEditAttributes();
                if (!str_EndTime.Raw)
                    str_EndTime.CurrentValue = HtmlDecode(str_EndTime.CurrentValue);
                str_EndTime.EditValue = HtmlEncode(str_EndTime.CurrentValue);
                str_EndTime.PlaceHolder = RemoveHtml(str_EndTime.Caption);

                // str_PickupTime
                str_PickupTime.SetupEditAttributes();
                if (!str_PickupTime.Raw)
                    str_PickupTime.CurrentValue = HtmlDecode(str_PickupTime.CurrentValue);
                str_PickupTime.EditValue = HtmlEncode(str_PickupTime.CurrentValue);
                str_PickupTime.PlaceHolder = RemoveHtml(str_PickupTime.Caption);

                // str_DropOffTime
                str_DropOffTime.SetupEditAttributes();
                if (!str_DropOffTime.Raw)
                    str_DropOffTime.CurrentValue = HtmlDecode(str_DropOffTime.CurrentValue);
                str_DropOffTime.EditValue = HtmlEncode(str_DropOffTime.CurrentValue);
                str_DropOffTime.PlaceHolder = RemoveHtml(str_DropOffTime.Caption);

                // int_VehicleID
                int_VehicleID.SetupEditAttributes();
                int_VehicleID.EditValue = int_VehicleID.CurrentValue; // DN
                int_VehicleID.PlaceHolder = RemoveHtml(int_VehicleID.Caption);
                if (!Empty(int_VehicleID.EditValue) && IsNumeric(int_VehicleID.EditValue))
                    int_VehicleID.EditValue = FormatNumber(int_VehicleID.EditValue, null);

                // dec_InstID
                dec_InstID.SetupEditAttributes();
                dec_InstID.EditValue = dec_InstID.CurrentValue; // DN
                dec_InstID.PlaceHolder = RemoveHtml(dec_InstID.Caption);
                if (!Empty(dec_InstID.EditValue) && IsNumeric(dec_InstID.EditValue))
                    dec_InstID.EditValue = FormatNumber(dec_InstID.EditValue, null);

                // dec_StudentID
                dec_StudentID.SetupEditAttributes();
                dec_StudentID.EditValue = dec_StudentID.CurrentValue; // DN
                dec_StudentID.PlaceHolder = RemoveHtml(dec_StudentID.Caption);
                if (!Empty(dec_StudentID.EditValue) && IsNumeric(dec_StudentID.EditValue))
                    dec_StudentID.EditValue = FormatNumber(dec_StudentID.EditValue, null);

                // dec_Observed_StudentID
                dec_Observed_StudentID.SetupEditAttributes();
                dec_Observed_StudentID.EditValue = dec_Observed_StudentID.CurrentValue; // DN
                dec_Observed_StudentID.PlaceHolder = RemoveHtml(dec_Observed_StudentID.Caption);
                if (!Empty(dec_Observed_StudentID.EditValue) && IsNumeric(dec_Observed_StudentID.EditValue))
                    dec_Observed_StudentID.EditValue = FormatNumber(dec_Observed_StudentID.EditValue, null);

                // int_Apptype
                int_Apptype.SetupEditAttributes();
                int_Apptype.EditValue = int_Apptype.CurrentValue; // DN
                curVal = ConvertToString(int_Apptype.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Apptype.Lookup != null && IsDictionary(int_Apptype.Lookup?.Options) && int_Apptype.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Apptype.EditValue = int_Apptype.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_AppType]", "=", int_Apptype.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Apptype.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Apptype.Lookup != null) { // Lookup values found
                            var listwrk = int_Apptype.Lookup?.RenderViewRow(rswrk[0]);
                            int_Apptype.EditValue = int_Apptype.HighlightLookup(ConvertToString(rswrk[0]), int_Apptype.DisplayValue(listwrk));
                        } else {
                            int_Apptype.EditValue = HtmlEncode(FormatNumber(int_Apptype.CurrentValue, int_Apptype.FormatPattern));
                        }
                    }
                } else {
                    int_Apptype.EditValue = DbNullValue;
                }
                int_Apptype.PlaceHolder = RemoveHtml(int_Apptype.Caption);
                if (!Empty(int_Apptype.EditValue) && IsNumeric(int_Apptype.EditValue))
                    int_Apptype.EditValue = FormatNumber(int_Apptype.EditValue, null);

                // int_AppStatus
                int_AppStatus.SetupEditAttributes();
                int_AppStatus.EditValue = int_AppStatus.Options(true);
                int_AppStatus.PlaceHolder = RemoveHtml(int_AppStatus.Caption);
                if (!Empty(int_AppStatus.EditValue) && IsNumeric(int_AppStatus.EditValue))
                    int_AppStatus.EditValue = FormatNumber(int_AppStatus.EditValue, null);

                // mny_AppCost
                mny_AppCost.SetupEditAttributes();
                mny_AppCost.EditValue = mny_AppCost.CurrentValue; // DN
                mny_AppCost.PlaceHolder = RemoveHtml(mny_AppCost.Caption);
                if (!Empty(mny_AppCost.EditValue) && IsNumeric(mny_AppCost.EditValue))
                    mny_AppCost.EditValue = FormatNumber(mny_AppCost.EditValue, null);

                // mny_AmountPaid
                mny_AmountPaid.SetupEditAttributes();
                mny_AmountPaid.EditValue = mny_AmountPaid.CurrentValue; // DN
                mny_AmountPaid.PlaceHolder = RemoveHtml(mny_AmountPaid.Caption);
                if (!Empty(mny_AmountPaid.EditValue) && IsNumeric(mny_AmountPaid.EditValue))
                    mny_AmountPaid.EditValue = FormatNumber(mny_AmountPaid.EditValue, null);

                // bit_CheckAppPaid
                bit_CheckAppPaid.EditValue = bit_CheckAppPaid.Options(false);
                bit_CheckAppPaid.PlaceHolder = RemoveHtml(bit_CheckAppPaid.Caption);

                // bit_Confirmation
                bit_Confirmation.EditValue = bit_Confirmation.Options(false);
                bit_Confirmation.PlaceHolder = RemoveHtml(bit_Confirmation.Caption);

                // str_Instructions
                str_Instructions.SetupEditAttributes();
                if (!str_Instructions.Raw)
                    str_Instructions.CurrentValue = HtmlDecode(str_Instructions.CurrentValue);
                str_Instructions.EditValue = HtmlEncode(str_Instructions.CurrentValue);
                str_Instructions.PlaceHolder = RemoveHtml(str_Instructions.Caption);

                // str_Instructions1
                str_Instructions1.SetupEditAttributes();
                if (!str_Instructions1.Raw)
                    str_Instructions1.CurrentValue = HtmlDecode(str_Instructions1.CurrentValue);
                str_Instructions1.EditValue = HtmlEncode(str_Instructions1.CurrentValue);
                str_Instructions1.PlaceHolder = RemoveHtml(str_Instructions1.Caption);

                // str_AppNotes
                str_AppNotes.SetupEditAttributes();
                if (!str_AppNotes.Raw)
                    str_AppNotes.CurrentValue = HtmlDecode(str_AppNotes.CurrentValue);
                str_AppNotes.EditValue = HtmlEncode(str_AppNotes.CurrentValue);
                str_AppNotes.PlaceHolder = RemoveHtml(str_AppNotes.Caption);

                // str_PickupLocation
                str_PickupLocation.SetupEditAttributes();
                if (!str_PickupLocation.Raw)
                    str_PickupLocation.CurrentValue = HtmlDecode(str_PickupLocation.CurrentValue);
                str_PickupLocation.EditValue = HtmlEncode(str_PickupLocation.CurrentValue);
                str_PickupLocation.PlaceHolder = RemoveHtml(str_PickupLocation.Caption);

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

                // date_Modified

                // bit_IsDeleted
                bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
                bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

                // str_Interval
                str_Interval.SetupEditAttributes();
                if (!str_Interval.Raw)
                    str_Interval.CurrentValue = HtmlDecode(str_Interval.CurrentValue);
                str_Interval.EditValue = HtmlEncode(str_Interval.CurrentValue);
                str_Interval.PlaceHolder = RemoveHtml(str_Interval.Caption);

                // RemM1
                RemM1.EditValue = RemM1.Options(false);
                RemM1.PlaceHolder = RemoveHtml(RemM1.Caption);

                // RemM2
                RemM2.EditValue = RemM2.Options(false);
                RemM2.PlaceHolder = RemoveHtml(RemM2.Caption);

                // RemM3
                RemM3.EditValue = RemM3.Options(false);
                RemM3.PlaceHolder = RemoveHtml(RemM3.Caption);

                // int_Location_ID
                int_Location_ID.SetupEditAttributes();
                int_Location_ID.EditValue = int_Location_ID.CurrentValue; // DN
                int_Location_ID.PlaceHolder = RemoveHtml(int_Location_ID.Caption);
                if (!Empty(int_Location_ID.EditValue) && IsNumeric(int_Location_ID.EditValue))
                    int_Location_ID.EditValue = FormatNumber(int_Location_ID.EditValue, null);

                // SPID
                SPID.SetupEditAttributes();
                SPID.EditValue = SPID.CurrentValue; // DN
                SPID.PlaceHolder = RemoveHtml(SPID.Caption);
                if (!Empty(SPID.EditValue) && IsNumeric(SPID.EditValue))
                    SPID.EditValue = FormatNumber(SPID.EditValue, null);

                // Chk_Trace
                Chk_Trace.SetupEditAttributes();
                if (!Chk_Trace.Raw)
                    Chk_Trace.CurrentValue = HtmlDecode(Chk_Trace.CurrentValue);
                Chk_Trace.EditValue = HtmlEncode(Chk_Trace.CurrentValue);
                Chk_Trace.PlaceHolder = RemoveHtml(Chk_Trace.Caption);

                // str_DropOffLocation
                str_DropOffLocation.SetupEditAttributes();
                if (!str_DropOffLocation.Raw)
                    str_DropOffLocation.CurrentValue = HtmlDecode(str_DropOffLocation.CurrentValue);
                str_DropOffLocation.EditValue = HtmlEncode(str_DropOffLocation.CurrentValue);
                str_DropOffLocation.PlaceHolder = RemoveHtml(str_DropOffLocation.Caption);

                // imgInstructorSignature
                imgInstructorSignature.SetupEditAttributes();
                if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                    imgInstructorSignature.EditValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgInstructorSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgInstructorSignature.Upload.DbValue));
                } else {
                    imgInstructorSignature.EditValue = "";
                }
                if ((IsShow || IsCopy) && !EventCancelled)
                    await RenderUploadField(imgInstructorSignature);

                // imgStudentSignature
                imgStudentSignature.SetupEditAttributes();
                if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                    imgStudentSignature.EditValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgStudentSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgStudentSignature.Upload.DbValue));
                } else {
                    imgStudentSignature.EditValue = "";
                }
                if ((IsShow || IsCopy) && !EventCancelled)
                    await RenderUploadField(imgStudentSignature);

                // imgObserverSignature
                imgObserverSignature.SetupEditAttributes();
                if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                    imgObserverSignature.EditValue = RawUrlEncode(int_Appt_id.CurrentValue);
                    imgObserverSignature.IsBlobImage = IsImageFile(ContentExtension((byte[])imgObserverSignature.Upload.DbValue));
                } else {
                    imgObserverSignature.EditValue = "";
                }
                if ((IsShow || IsCopy) && !EventCancelled)
                    await RenderUploadField(imgObserverSignature);

                // dt_apptstart
                dt_apptstart.SetupEditAttributes();
                dt_apptstart.EditValue = FormatDateTime(dt_apptstart.CurrentValue, dt_apptstart.FormatPattern); // DN
                dt_apptstart.PlaceHolder = RemoveHtml(dt_apptstart.Caption);

                // dt_apptComplete
                dt_apptComplete.SetupEditAttributes();
                dt_apptComplete.EditValue = FormatDateTime(dt_apptComplete.CurrentValue, dt_apptComplete.FormatPattern); // DN
                dt_apptComplete.PlaceHolder = RemoveHtml(dt_apptComplete.Caption);

                // int_apptstartedBy
                int_apptstartedBy.SetupEditAttributes();
                int_apptstartedBy.EditValue = int_apptstartedBy.CurrentValue; // DN
                int_apptstartedBy.PlaceHolder = RemoveHtml(int_apptstartedBy.Caption);
                if (!Empty(int_apptstartedBy.EditValue) && IsNumeric(int_apptstartedBy.EditValue))
                    int_apptstartedBy.EditValue = FormatNumber(int_apptstartedBy.EditValue, null);

                // int_apptCompletedBy
                int_apptCompletedBy.SetupEditAttributes();
                int_apptCompletedBy.EditValue = int_apptCompletedBy.CurrentValue; // DN
                int_apptCompletedBy.PlaceHolder = RemoveHtml(int_apptCompletedBy.Caption);
                if (!Empty(int_apptCompletedBy.EditValue) && IsNumeric(int_apptCompletedBy.EditValue))
                    int_apptCompletedBy.EditValue = FormatNumber(int_apptCompletedBy.EditValue, null);

                // SMSReminder1
                SMSReminder1.EditValue = SMSReminder1.Options(false);
                SMSReminder1.PlaceHolder = RemoveHtml(SMSReminder1.Caption);

                // SMSReminder2
                SMSReminder2.EditValue = SMSReminder2.Options(false);
                SMSReminder2.PlaceHolder = RemoveHtml(SMSReminder2.Caption);

                // SMSReminder3
                SMSReminder3.EditValue = SMSReminder3.Options(false);
                SMSReminder3.PlaceHolder = RemoveHtml(SMSReminder3.Caption);

                // VoiceReminder1
                VoiceReminder1.EditValue = VoiceReminder1.Options(false);
                VoiceReminder1.PlaceHolder = RemoveHtml(VoiceReminder1.Caption);

                // VoiceReminder2
                VoiceReminder2.EditValue = VoiceReminder2.Options(false);
                VoiceReminder2.PlaceHolder = RemoveHtml(VoiceReminder2.Caption);

                // VoiceReminder3
                VoiceReminder3.EditValue = VoiceReminder3.Options(false);
                VoiceReminder3.PlaceHolder = RemoveHtml(VoiceReminder3.Caption);

                // bit_isroadtest
                bit_isroadtest.EditValue = bit_isroadtest.Options(false);
                bit_isroadtest.PlaceHolder = RemoveHtml(bit_isroadtest.Caption);

                // int_slotType
                int_slotType.SetupEditAttributes();
                int_slotType.EditValue = int_slotType.CurrentValue; // DN
                int_slotType.PlaceHolder = RemoveHtml(int_slotType.Caption);
                if (!Empty(int_slotType.EditValue) && IsNumeric(int_slotType.EditValue))
                    int_slotType.EditValue = FormatNumber(int_slotType.EditValue, null);

                // bit_VisibleOnPortal
                bit_VisibleOnPortal.EditValue = bit_VisibleOnPortal.Options(false);
                bit_VisibleOnPortal.PlaceHolder = RemoveHtml(bit_VisibleOnPortal.Caption);

                // IsDataRetrieved
                IsDataRetrieved.EditValue = IsDataRetrieved.Options(false);
                IsDataRetrieved.PlaceHolder = RemoveHtml(IsDataRetrieved.Caption);

                // bit_chargesApplied
                bit_chargesApplied.EditValue = bit_chargesApplied.Options(false);
                bit_chargesApplied.PlaceHolder = RemoveHtml(bit_chargesApplied.Caption);

                // dec_DistanceTravelled
                dec_DistanceTravelled.SetupEditAttributes();
                dec_DistanceTravelled.EditValue = dec_DistanceTravelled.CurrentValue; // DN
                dec_DistanceTravelled.PlaceHolder = RemoveHtml(dec_DistanceTravelled.Caption);
                if (!Empty(dec_DistanceTravelled.EditValue) && IsNumeric(dec_DistanceTravelled.EditValue))
                    dec_DistanceTravelled.EditValue = FormatNumber(dec_DistanceTravelled.EditValue, null);

                // btwProductIdsforSSRules
                btwProductIdsforSSRules.SetupEditAttributes();
                btwProductIdsforSSRules.EditValue = btwProductIdsforSSRules.CurrentValue; // DN
                btwProductIdsforSSRules.PlaceHolder = RemoveHtml(btwProductIdsforSSRules.Caption);

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.SetupEditAttributes();
                int_evaluateApptWithEmail.EditValue = int_evaluateApptWithEmail.CurrentValue; // DN
                int_evaluateApptWithEmail.PlaceHolder = RemoveHtml(int_evaluateApptWithEmail.Caption);
                if (!Empty(int_evaluateApptWithEmail.EditValue) && IsNumeric(int_evaluateApptWithEmail.EditValue))
                    int_evaluateApptWithEmail.EditValue = FormatNumber(int_evaluateApptWithEmail.EditValue, null);

                // PublicNotesId
                PublicNotesId.SetupEditAttributes();
                PublicNotesId.EditValue = PublicNotesId.CurrentValue; // DN
                PublicNotesId.PlaceHolder = RemoveHtml(PublicNotesId.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.CurrentValue; // DN
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue))
                    NationalID.EditValue = FormatNumber(NationalID.EditValue, null);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("add")) { // Non system admin
                    str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
                } else {
                    if (!str_Username.Raw)
                        str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                    str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                    str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
                }

                // int_PackageID
                int_PackageID.SetupEditAttributes();
                int_PackageID.EditValue = int_PackageID.CurrentValue; // DN
                int_PackageID.PlaceHolder = RemoveHtml(int_PackageID.Caption);
                if (!Empty(int_PackageID.EditValue) && IsNumeric(int_PackageID.EditValue))
                    int_PackageID.EditValue = FormatNumber(int_PackageID.EditValue, null);

                // int_ApptCldr_ID
                int_ApptCldr_ID.SetupEditAttributes();
                int_ApptCldr_ID.EditValue = int_ApptCldr_ID.CurrentValue; // DN
                int_ApptCldr_ID.PlaceHolder = RemoveHtml(int_ApptCldr_ID.Caption);
                if (!Empty(int_ApptCldr_ID.EditValue) && IsNumeric(int_ApptCldr_ID.EditValue))
                    int_ApptCldr_ID.EditValue = FormatNumber(int_ApptCldr_ID.EditValue, null);

                // str_CRSS_ID
                str_CRSS_ID.SetupEditAttributes();
                if (!str_CRSS_ID.Raw)
                    str_CRSS_ID.CurrentValue = HtmlDecode(str_CRSS_ID.CurrentValue);
                str_CRSS_ID.EditValue = HtmlEncode(str_CRSS_ID.CurrentValue);
                str_CRSS_ID.PlaceHolder = RemoveHtml(str_CRSS_ID.Caption);

                // Add refer script

                // str_AppName
                str_AppName.HrefValue = "";

                // str_App_Date
                str_App_Date.HrefValue = "";

                // str_StartTime
                str_StartTime.HrefValue = "";

                // str_EndTime
                str_EndTime.HrefValue = "";

                // str_PickupTime
                str_PickupTime.HrefValue = "";

                // str_DropOffTime
                str_DropOffTime.HrefValue = "";

                // int_VehicleID
                int_VehicleID.HrefValue = "";

                // dec_InstID
                dec_InstID.HrefValue = "";

                // dec_StudentID
                dec_StudentID.HrefValue = "";

                // dec_Observed_StudentID
                dec_Observed_StudentID.HrefValue = "";

                // int_Apptype
                int_Apptype.HrefValue = "";

                // int_AppStatus
                int_AppStatus.HrefValue = "";

                // mny_AppCost
                mny_AppCost.HrefValue = "";

                // mny_AmountPaid
                mny_AmountPaid.HrefValue = "";

                // bit_CheckAppPaid
                bit_CheckAppPaid.HrefValue = "";

                // bit_Confirmation
                bit_Confirmation.HrefValue = "";

                // str_Instructions
                str_Instructions.HrefValue = "";

                // str_Instructions1
                str_Instructions1.HrefValue = "";

                // str_AppNotes
                str_AppNotes.HrefValue = "";

                // str_PickupLocation
                str_PickupLocation.HrefValue = "";

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

                // str_Interval
                str_Interval.HrefValue = "";

                // RemM1
                RemM1.HrefValue = "";

                // RemM2
                RemM2.HrefValue = "";

                // RemM3
                RemM3.HrefValue = "";

                // int_Location_ID
                int_Location_ID.HrefValue = "";

                // SPID
                SPID.HrefValue = "";

                // Chk_Trace
                Chk_Trace.HrefValue = "";

                // str_DropOffLocation
                str_DropOffLocation.HrefValue = "";

                // imgInstructorSignature
                if (!IsNull(imgInstructorSignature.Upload.DbValue)) {
                    imgInstructorSignature.HrefValue = AppPath(GetFileUploadUrl(imgInstructorSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgInstructorSignature.LinkAttrs["target"] = "";
                    if (imgInstructorSignature.IsBlobImage && Empty(imgInstructorSignature.LinkAttrs["target"]))
                        imgInstructorSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgInstructorSignature.HrefValue = FullUrl(ConvertToString(imgInstructorSignature.HrefValue), "href");
                } else {
                    imgInstructorSignature.HrefValue = "";
                }
                imgInstructorSignature.ExportHrefValue = GetFileUploadUrl(imgInstructorSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));

                // imgStudentSignature
                if (!IsNull(imgStudentSignature.Upload.DbValue)) {
                    imgStudentSignature.HrefValue = AppPath(GetFileUploadUrl(imgStudentSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgStudentSignature.LinkAttrs["target"] = "";
                    if (imgStudentSignature.IsBlobImage && Empty(imgStudentSignature.LinkAttrs["target"]))
                        imgStudentSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgStudentSignature.HrefValue = FullUrl(ConvertToString(imgStudentSignature.HrefValue), "href");
                } else {
                    imgStudentSignature.HrefValue = "";
                }
                imgStudentSignature.ExportHrefValue = GetFileUploadUrl(imgStudentSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));

                // imgObserverSignature
                if (!IsNull(imgObserverSignature.Upload.DbValue)) {
                    imgObserverSignature.HrefValue = AppPath(GetFileUploadUrl(imgObserverSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)))); // DN
                    imgObserverSignature.LinkAttrs["target"] = "";
                    if (imgObserverSignature.IsBlobImage && Empty(imgObserverSignature.LinkAttrs["target"]))
                        imgObserverSignature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        imgObserverSignature.HrefValue = FullUrl(ConvertToString(imgObserverSignature.HrefValue), "href");
                } else {
                    imgObserverSignature.HrefValue = "";
                }
                imgObserverSignature.ExportHrefValue = GetFileUploadUrl(imgObserverSignature, ConvertToString(RawUrlEncode(int_Appt_id.CurrentValue)));

                // dt_apptstart
                dt_apptstart.HrefValue = "";

                // dt_apptComplete
                dt_apptComplete.HrefValue = "";

                // int_apptstartedBy
                int_apptstartedBy.HrefValue = "";

                // int_apptCompletedBy
                int_apptCompletedBy.HrefValue = "";

                // SMSReminder1
                SMSReminder1.HrefValue = "";

                // SMSReminder2
                SMSReminder2.HrefValue = "";

                // SMSReminder3
                SMSReminder3.HrefValue = "";

                // VoiceReminder1
                VoiceReminder1.HrefValue = "";

                // VoiceReminder2
                VoiceReminder2.HrefValue = "";

                // VoiceReminder3
                VoiceReminder3.HrefValue = "";

                // bit_isroadtest
                bit_isroadtest.HrefValue = "";

                // int_slotType
                int_slotType.HrefValue = "";

                // bit_VisibleOnPortal
                bit_VisibleOnPortal.HrefValue = "";

                // IsDataRetrieved
                IsDataRetrieved.HrefValue = "";

                // bit_chargesApplied
                bit_chargesApplied.HrefValue = "";

                // dec_DistanceTravelled
                dec_DistanceTravelled.HrefValue = "";

                // btwProductIdsforSSRules
                btwProductIdsforSSRules.HrefValue = "";

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.HrefValue = "";

                // PublicNotesId
                PublicNotesId.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // int_PackageID
                int_PackageID.HrefValue = "";

                // int_ApptCldr_ID
                int_ApptCldr_ID.HrefValue = "";

                // str_CRSS_ID
                str_CRSS_ID.HrefValue = "";
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
            if (str_AppName.Required) {
                if (!str_AppName.IsDetailKey && Empty(str_AppName.FormValue)) {
                    str_AppName.AddErrorMessage(ConvertToString(str_AppName.RequiredErrorMessage).Replace("%s", str_AppName.Caption));
                }
            }
            if (str_App_Date.Required) {
                if (!str_App_Date.IsDetailKey && Empty(str_App_Date.FormValue)) {
                    str_App_Date.AddErrorMessage(ConvertToString(str_App_Date.RequiredErrorMessage).Replace("%s", str_App_Date.Caption));
                }
            }
            if (str_StartTime.Required) {
                if (!str_StartTime.IsDetailKey && Empty(str_StartTime.FormValue)) {
                    str_StartTime.AddErrorMessage(ConvertToString(str_StartTime.RequiredErrorMessage).Replace("%s", str_StartTime.Caption));
                }
            }
            if (str_EndTime.Required) {
                if (!str_EndTime.IsDetailKey && Empty(str_EndTime.FormValue)) {
                    str_EndTime.AddErrorMessage(ConvertToString(str_EndTime.RequiredErrorMessage).Replace("%s", str_EndTime.Caption));
                }
            }
            if (str_PickupTime.Required) {
                if (!str_PickupTime.IsDetailKey && Empty(str_PickupTime.FormValue)) {
                    str_PickupTime.AddErrorMessage(ConvertToString(str_PickupTime.RequiredErrorMessage).Replace("%s", str_PickupTime.Caption));
                }
            }
            if (str_DropOffTime.Required) {
                if (!str_DropOffTime.IsDetailKey && Empty(str_DropOffTime.FormValue)) {
                    str_DropOffTime.AddErrorMessage(ConvertToString(str_DropOffTime.RequiredErrorMessage).Replace("%s", str_DropOffTime.Caption));
                }
            }
            if (int_VehicleID.Required) {
                if (!int_VehicleID.IsDetailKey && Empty(int_VehicleID.FormValue)) {
                    int_VehicleID.AddErrorMessage(ConvertToString(int_VehicleID.RequiredErrorMessage).Replace("%s", int_VehicleID.Caption));
                }
            }
            if (!CheckInteger(int_VehicleID.FormValue)) {
                int_VehicleID.AddErrorMessage(int_VehicleID.GetErrorMessage(false));
            }
            if (dec_InstID.Required) {
                if (!dec_InstID.IsDetailKey && Empty(dec_InstID.FormValue)) {
                    dec_InstID.AddErrorMessage(ConvertToString(dec_InstID.RequiredErrorMessage).Replace("%s", dec_InstID.Caption));
                }
            }
            if (!CheckNumber(dec_InstID.FormValue)) {
                dec_InstID.AddErrorMessage(dec_InstID.GetErrorMessage(false));
            }
            if (dec_StudentID.Required) {
                if (!dec_StudentID.IsDetailKey && Empty(dec_StudentID.FormValue)) {
                    dec_StudentID.AddErrorMessage(ConvertToString(dec_StudentID.RequiredErrorMessage).Replace("%s", dec_StudentID.Caption));
                }
            }
            if (!CheckInteger(dec_StudentID.FormValue)) {
                dec_StudentID.AddErrorMessage(dec_StudentID.GetErrorMessage(false));
            }
            if (dec_Observed_StudentID.Required) {
                if (!dec_Observed_StudentID.IsDetailKey && Empty(dec_Observed_StudentID.FormValue)) {
                    dec_Observed_StudentID.AddErrorMessage(ConvertToString(dec_Observed_StudentID.RequiredErrorMessage).Replace("%s", dec_Observed_StudentID.Caption));
                }
            }
            if (!CheckInteger(dec_Observed_StudentID.FormValue)) {
                dec_Observed_StudentID.AddErrorMessage(dec_Observed_StudentID.GetErrorMessage(false));
            }
            if (int_Apptype.Required) {
                if (!int_Apptype.IsDetailKey && Empty(int_Apptype.FormValue)) {
                    int_Apptype.AddErrorMessage(ConvertToString(int_Apptype.RequiredErrorMessage).Replace("%s", int_Apptype.Caption));
                }
            }
            if (!CheckInteger(int_Apptype.FormValue)) {
                int_Apptype.AddErrorMessage(int_Apptype.GetErrorMessage(false));
            }
            if (int_AppStatus.Required) {
                if (!int_AppStatus.IsDetailKey && Empty(int_AppStatus.FormValue)) {
                    int_AppStatus.AddErrorMessage(ConvertToString(int_AppStatus.RequiredErrorMessage).Replace("%s", int_AppStatus.Caption));
                }
            }
            if (mny_AppCost.Required) {
                if (!mny_AppCost.IsDetailKey && Empty(mny_AppCost.FormValue)) {
                    mny_AppCost.AddErrorMessage(ConvertToString(mny_AppCost.RequiredErrorMessage).Replace("%s", mny_AppCost.Caption));
                }
            }
            if (!CheckNumber(mny_AppCost.FormValue)) {
                mny_AppCost.AddErrorMessage(mny_AppCost.GetErrorMessage(false));
            }
            if (mny_AmountPaid.Required) {
                if (!mny_AmountPaid.IsDetailKey && Empty(mny_AmountPaid.FormValue)) {
                    mny_AmountPaid.AddErrorMessage(ConvertToString(mny_AmountPaid.RequiredErrorMessage).Replace("%s", mny_AmountPaid.Caption));
                }
            }
            if (!CheckNumber(mny_AmountPaid.FormValue)) {
                mny_AmountPaid.AddErrorMessage(mny_AmountPaid.GetErrorMessage(false));
            }
            if (bit_CheckAppPaid.Required) {
                if (Empty(bit_CheckAppPaid.FormValue)) {
                    bit_CheckAppPaid.AddErrorMessage(ConvertToString(bit_CheckAppPaid.RequiredErrorMessage).Replace("%s", bit_CheckAppPaid.Caption));
                }
            }
            if (bit_Confirmation.Required) {
                if (Empty(bit_Confirmation.FormValue)) {
                    bit_Confirmation.AddErrorMessage(ConvertToString(bit_Confirmation.RequiredErrorMessage).Replace("%s", bit_Confirmation.Caption));
                }
            }
            if (str_Instructions.Required) {
                if (!str_Instructions.IsDetailKey && Empty(str_Instructions.FormValue)) {
                    str_Instructions.AddErrorMessage(ConvertToString(str_Instructions.RequiredErrorMessage).Replace("%s", str_Instructions.Caption));
                }
            }
            if (str_Instructions1.Required) {
                if (!str_Instructions1.IsDetailKey && Empty(str_Instructions1.FormValue)) {
                    str_Instructions1.AddErrorMessage(ConvertToString(str_Instructions1.RequiredErrorMessage).Replace("%s", str_Instructions1.Caption));
                }
            }
            if (str_AppNotes.Required) {
                if (!str_AppNotes.IsDetailKey && Empty(str_AppNotes.FormValue)) {
                    str_AppNotes.AddErrorMessage(ConvertToString(str_AppNotes.RequiredErrorMessage).Replace("%s", str_AppNotes.Caption));
                }
            }
            if (str_PickupLocation.Required) {
                if (!str_PickupLocation.IsDetailKey && Empty(str_PickupLocation.FormValue)) {
                    str_PickupLocation.AddErrorMessage(ConvertToString(str_PickupLocation.RequiredErrorMessage).Replace("%s", str_PickupLocation.Caption));
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
            if (date_Modified.Required) {
                if (!date_Modified.IsDetailKey && Empty(date_Modified.FormValue)) {
                    date_Modified.AddErrorMessage(ConvertToString(date_Modified.RequiredErrorMessage).Replace("%s", date_Modified.Caption));
                }
            }
            if (bit_IsDeleted.Required) {
                if (Empty(bit_IsDeleted.FormValue)) {
                    bit_IsDeleted.AddErrorMessage(ConvertToString(bit_IsDeleted.RequiredErrorMessage).Replace("%s", bit_IsDeleted.Caption));
                }
            }
            if (str_Interval.Required) {
                if (!str_Interval.IsDetailKey && Empty(str_Interval.FormValue)) {
                    str_Interval.AddErrorMessage(ConvertToString(str_Interval.RequiredErrorMessage).Replace("%s", str_Interval.Caption));
                }
            }
            if (RemM1.Required) {
                if (Empty(RemM1.FormValue)) {
                    RemM1.AddErrorMessage(ConvertToString(RemM1.RequiredErrorMessage).Replace("%s", RemM1.Caption));
                }
            }
            if (RemM2.Required) {
                if (Empty(RemM2.FormValue)) {
                    RemM2.AddErrorMessage(ConvertToString(RemM2.RequiredErrorMessage).Replace("%s", RemM2.Caption));
                }
            }
            if (RemM3.Required) {
                if (Empty(RemM3.FormValue)) {
                    RemM3.AddErrorMessage(ConvertToString(RemM3.RequiredErrorMessage).Replace("%s", RemM3.Caption));
                }
            }
            if (int_Location_ID.Required) {
                if (!int_Location_ID.IsDetailKey && Empty(int_Location_ID.FormValue)) {
                    int_Location_ID.AddErrorMessage(ConvertToString(int_Location_ID.RequiredErrorMessage).Replace("%s", int_Location_ID.Caption));
                }
            }
            if (!CheckNumber(int_Location_ID.FormValue)) {
                int_Location_ID.AddErrorMessage(int_Location_ID.GetErrorMessage(false));
            }
            if (SPID.Required) {
                if (!SPID.IsDetailKey && Empty(SPID.FormValue)) {
                    SPID.AddErrorMessage(ConvertToString(SPID.RequiredErrorMessage).Replace("%s", SPID.Caption));
                }
            }
            if (!CheckNumber(SPID.FormValue)) {
                SPID.AddErrorMessage(SPID.GetErrorMessage(false));
            }
            if (Chk_Trace.Required) {
                if (!Chk_Trace.IsDetailKey && Empty(Chk_Trace.FormValue)) {
                    Chk_Trace.AddErrorMessage(ConvertToString(Chk_Trace.RequiredErrorMessage).Replace("%s", Chk_Trace.Caption));
                }
            }
            if (str_DropOffLocation.Required) {
                if (!str_DropOffLocation.IsDetailKey && Empty(str_DropOffLocation.FormValue)) {
                    str_DropOffLocation.AddErrorMessage(ConvertToString(str_DropOffLocation.RequiredErrorMessage).Replace("%s", str_DropOffLocation.Caption));
                }
            }
            if (imgInstructorSignature.Required) {
                if (imgInstructorSignature.Upload.FileName == "" && !imgInstructorSignature.Upload.KeepFile) {
                    imgInstructorSignature.AddErrorMessage(ConvertToString(imgInstructorSignature.RequiredErrorMessage).Replace("%s", imgInstructorSignature.Caption));
                }
            }
            if (imgStudentSignature.Required) {
                if (imgStudentSignature.Upload.FileName == "" && !imgStudentSignature.Upload.KeepFile) {
                    imgStudentSignature.AddErrorMessage(ConvertToString(imgStudentSignature.RequiredErrorMessage).Replace("%s", imgStudentSignature.Caption));
                }
            }
            if (imgObserverSignature.Required) {
                if (imgObserverSignature.Upload.FileName == "" && !imgObserverSignature.Upload.KeepFile) {
                    imgObserverSignature.AddErrorMessage(ConvertToString(imgObserverSignature.RequiredErrorMessage).Replace("%s", imgObserverSignature.Caption));
                }
            }
            if (dt_apptstart.Required) {
                if (!dt_apptstart.IsDetailKey && Empty(dt_apptstart.FormValue)) {
                    dt_apptstart.AddErrorMessage(ConvertToString(dt_apptstart.RequiredErrorMessage).Replace("%s", dt_apptstart.Caption));
                }
            }
            if (!CheckDate(dt_apptstart.FormValue, dt_apptstart.FormatPattern)) {
                dt_apptstart.AddErrorMessage(dt_apptstart.GetErrorMessage(false));
            }
            if (dt_apptComplete.Required) {
                if (!dt_apptComplete.IsDetailKey && Empty(dt_apptComplete.FormValue)) {
                    dt_apptComplete.AddErrorMessage(ConvertToString(dt_apptComplete.RequiredErrorMessage).Replace("%s", dt_apptComplete.Caption));
                }
            }
            if (!CheckDate(dt_apptComplete.FormValue, dt_apptComplete.FormatPattern)) {
                dt_apptComplete.AddErrorMessage(dt_apptComplete.GetErrorMessage(false));
            }
            if (int_apptstartedBy.Required) {
                if (!int_apptstartedBy.IsDetailKey && Empty(int_apptstartedBy.FormValue)) {
                    int_apptstartedBy.AddErrorMessage(ConvertToString(int_apptstartedBy.RequiredErrorMessage).Replace("%s", int_apptstartedBy.Caption));
                }
            }
            if (!CheckInteger(int_apptstartedBy.FormValue)) {
                int_apptstartedBy.AddErrorMessage(int_apptstartedBy.GetErrorMessage(false));
            }
            if (int_apptCompletedBy.Required) {
                if (!int_apptCompletedBy.IsDetailKey && Empty(int_apptCompletedBy.FormValue)) {
                    int_apptCompletedBy.AddErrorMessage(ConvertToString(int_apptCompletedBy.RequiredErrorMessage).Replace("%s", int_apptCompletedBy.Caption));
                }
            }
            if (!CheckInteger(int_apptCompletedBy.FormValue)) {
                int_apptCompletedBy.AddErrorMessage(int_apptCompletedBy.GetErrorMessage(false));
            }
            if (SMSReminder1.Required) {
                if (Empty(SMSReminder1.FormValue)) {
                    SMSReminder1.AddErrorMessage(ConvertToString(SMSReminder1.RequiredErrorMessage).Replace("%s", SMSReminder1.Caption));
                }
            }
            if (SMSReminder2.Required) {
                if (Empty(SMSReminder2.FormValue)) {
                    SMSReminder2.AddErrorMessage(ConvertToString(SMSReminder2.RequiredErrorMessage).Replace("%s", SMSReminder2.Caption));
                }
            }
            if (SMSReminder3.Required) {
                if (Empty(SMSReminder3.FormValue)) {
                    SMSReminder3.AddErrorMessage(ConvertToString(SMSReminder3.RequiredErrorMessage).Replace("%s", SMSReminder3.Caption));
                }
            }
            if (VoiceReminder1.Required) {
                if (Empty(VoiceReminder1.FormValue)) {
                    VoiceReminder1.AddErrorMessage(ConvertToString(VoiceReminder1.RequiredErrorMessage).Replace("%s", VoiceReminder1.Caption));
                }
            }
            if (VoiceReminder2.Required) {
                if (Empty(VoiceReminder2.FormValue)) {
                    VoiceReminder2.AddErrorMessage(ConvertToString(VoiceReminder2.RequiredErrorMessage).Replace("%s", VoiceReminder2.Caption));
                }
            }
            if (VoiceReminder3.Required) {
                if (Empty(VoiceReminder3.FormValue)) {
                    VoiceReminder3.AddErrorMessage(ConvertToString(VoiceReminder3.RequiredErrorMessage).Replace("%s", VoiceReminder3.Caption));
                }
            }
            if (bit_isroadtest.Required) {
                if (Empty(bit_isroadtest.FormValue)) {
                    bit_isroadtest.AddErrorMessage(ConvertToString(bit_isroadtest.RequiredErrorMessage).Replace("%s", bit_isroadtest.Caption));
                }
            }
            if (int_slotType.Required) {
                if (!int_slotType.IsDetailKey && Empty(int_slotType.FormValue)) {
                    int_slotType.AddErrorMessage(ConvertToString(int_slotType.RequiredErrorMessage).Replace("%s", int_slotType.Caption));
                }
            }
            if (!CheckInteger(int_slotType.FormValue)) {
                int_slotType.AddErrorMessage(int_slotType.GetErrorMessage(false));
            }
            if (bit_VisibleOnPortal.Required) {
                if (Empty(bit_VisibleOnPortal.FormValue)) {
                    bit_VisibleOnPortal.AddErrorMessage(ConvertToString(bit_VisibleOnPortal.RequiredErrorMessage).Replace("%s", bit_VisibleOnPortal.Caption));
                }
            }
            if (IsDataRetrieved.Required) {
                if (Empty(IsDataRetrieved.FormValue)) {
                    IsDataRetrieved.AddErrorMessage(ConvertToString(IsDataRetrieved.RequiredErrorMessage).Replace("%s", IsDataRetrieved.Caption));
                }
            }
            if (bit_chargesApplied.Required) {
                if (Empty(bit_chargesApplied.FormValue)) {
                    bit_chargesApplied.AddErrorMessage(ConvertToString(bit_chargesApplied.RequiredErrorMessage).Replace("%s", bit_chargesApplied.Caption));
                }
            }
            if (dec_DistanceTravelled.Required) {
                if (!dec_DistanceTravelled.IsDetailKey && Empty(dec_DistanceTravelled.FormValue)) {
                    dec_DistanceTravelled.AddErrorMessage(ConvertToString(dec_DistanceTravelled.RequiredErrorMessage).Replace("%s", dec_DistanceTravelled.Caption));
                }
            }
            if (!CheckNumber(dec_DistanceTravelled.FormValue)) {
                dec_DistanceTravelled.AddErrorMessage(dec_DistanceTravelled.GetErrorMessage(false));
            }
            if (btwProductIdsforSSRules.Required) {
                if (!btwProductIdsforSSRules.IsDetailKey && Empty(btwProductIdsforSSRules.FormValue)) {
                    btwProductIdsforSSRules.AddErrorMessage(ConvertToString(btwProductIdsforSSRules.RequiredErrorMessage).Replace("%s", btwProductIdsforSSRules.Caption));
                }
            }
            if (int_evaluateApptWithEmail.Required) {
                if (!int_evaluateApptWithEmail.IsDetailKey && Empty(int_evaluateApptWithEmail.FormValue)) {
                    int_evaluateApptWithEmail.AddErrorMessage(ConvertToString(int_evaluateApptWithEmail.RequiredErrorMessage).Replace("%s", int_evaluateApptWithEmail.Caption));
                }
            }
            if (!CheckInteger(int_evaluateApptWithEmail.FormValue)) {
                int_evaluateApptWithEmail.AddErrorMessage(int_evaluateApptWithEmail.GetErrorMessage(false));
            }
            if (PublicNotesId.Required) {
                if (!PublicNotesId.IsDetailKey && Empty(PublicNotesId.FormValue)) {
                    PublicNotesId.AddErrorMessage(ConvertToString(PublicNotesId.RequiredErrorMessage).Replace("%s", PublicNotesId.Caption));
                }
            }
            if (NationalID.Required) {
                if (!NationalID.IsDetailKey && Empty(NationalID.FormValue)) {
                    NationalID.AddErrorMessage(ConvertToString(NationalID.RequiredErrorMessage).Replace("%s", NationalID.Caption));
                }
            }
            if (!CheckInteger(NationalID.FormValue)) {
                NationalID.AddErrorMessage(NationalID.GetErrorMessage(false));
            }
            if (str_Username.Required) {
                if (!str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (int_PackageID.Required) {
                if (!int_PackageID.IsDetailKey && Empty(int_PackageID.FormValue)) {
                    int_PackageID.AddErrorMessage(ConvertToString(int_PackageID.RequiredErrorMessage).Replace("%s", int_PackageID.Caption));
                }
            }
            if (!CheckInteger(int_PackageID.FormValue)) {
                int_PackageID.AddErrorMessage(int_PackageID.GetErrorMessage(false));
            }
            if (int_ApptCldr_ID.Required) {
                if (!int_ApptCldr_ID.IsDetailKey && Empty(int_ApptCldr_ID.FormValue)) {
                    int_ApptCldr_ID.AddErrorMessage(ConvertToString(int_ApptCldr_ID.RequiredErrorMessage).Replace("%s", int_ApptCldr_ID.Caption));
                }
            }
            if (!CheckInteger(int_ApptCldr_ID.FormValue)) {
                int_ApptCldr_ID.AddErrorMessage(int_ApptCldr_ID.GetErrorMessage(false));
            }
            if (str_CRSS_ID.Required) {
                if (!str_CRSS_ID.IsDetailKey && Empty(str_CRSS_ID.FormValue)) {
                    str_CRSS_ID.AddErrorMessage(ConvertToString(str_CRSS_ID.RequiredErrorMessage).Replace("%s", str_CRSS_ID.Caption));
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
                // str_AppName
                str_AppName.SetDbValue(rsnew, str_AppName.CurrentValue);

                // str_App_Date
                str_App_Date.SetDbValue(rsnew, str_App_Date.CurrentValue);

                // str_StartTime
                str_StartTime.SetDbValue(rsnew, str_StartTime.CurrentValue);

                // str_EndTime
                str_EndTime.SetDbValue(rsnew, str_EndTime.CurrentValue);

                // str_PickupTime
                str_PickupTime.SetDbValue(rsnew, str_PickupTime.CurrentValue);

                // str_DropOffTime
                str_DropOffTime.SetDbValue(rsnew, str_DropOffTime.CurrentValue);

                // int_VehicleID
                int_VehicleID.SetDbValue(rsnew, int_VehicleID.CurrentValue);

                // dec_InstID
                dec_InstID.SetDbValue(rsnew, dec_InstID.CurrentValue);

                // dec_StudentID
                dec_StudentID.SetDbValue(rsnew, dec_StudentID.CurrentValue);

                // dec_Observed_StudentID
                dec_Observed_StudentID.SetDbValue(rsnew, dec_Observed_StudentID.CurrentValue);

                // int_Apptype
                int_Apptype.SetDbValue(rsnew, int_Apptype.CurrentValue);

                // int_AppStatus
                int_AppStatus.SetDbValue(rsnew, int_AppStatus.CurrentValue);

                // mny_AppCost
                mny_AppCost.SetDbValue(rsnew, mny_AppCost.CurrentValue);

                // mny_AmountPaid
                mny_AmountPaid.SetDbValue(rsnew, mny_AmountPaid.CurrentValue);

                // bit_CheckAppPaid
                bit_CheckAppPaid.SetDbValue(rsnew, ConvertToBool(bit_CheckAppPaid.CurrentValue));

                // bit_Confirmation
                bit_Confirmation.SetDbValue(rsnew, ConvertToBool(bit_Confirmation.CurrentValue));

                // str_Instructions
                str_Instructions.SetDbValue(rsnew, str_Instructions.CurrentValue);

                // str_Instructions1
                str_Instructions1.SetDbValue(rsnew, str_Instructions1.CurrentValue);

                // str_AppNotes
                str_AppNotes.SetDbValue(rsnew, str_AppNotes.CurrentValue);

                // str_PickupLocation
                str_PickupLocation.SetDbValue(rsnew, str_PickupLocation.CurrentValue);

                // int_Created_By
                int_Created_By.SetDbValue(rsnew, int_Created_By.CurrentValue);

                // int_Modified_By
                int_Modified_By.SetDbValue(rsnew, int_Modified_By.CurrentValue);

                // date_Created
                date_Created.CurrentValue = date_Created.GetAutoUpdateValue();
                date_Created.SetDbValue(rsnew, date_Created.CurrentValue, false);

                // date_Modified
                date_Modified.CurrentValue = date_Modified.GetAutoUpdateValue();
                date_Modified.SetDbValue(rsnew, date_Modified.CurrentValue, false);

                // bit_IsDeleted
                bit_IsDeleted.SetDbValue(rsnew, ConvertToBool(bit_IsDeleted.CurrentValue));

                // str_Interval
                str_Interval.SetDbValue(rsnew, str_Interval.CurrentValue);

                // RemM1
                RemM1.SetDbValue(rsnew, ConvertToBool(RemM1.CurrentValue));

                // RemM2
                RemM2.SetDbValue(rsnew, ConvertToBool(RemM2.CurrentValue));

                // RemM3
                RemM3.SetDbValue(rsnew, ConvertToBool(RemM3.CurrentValue));

                // int_Location_ID
                int_Location_ID.SetDbValue(rsnew, int_Location_ID.CurrentValue);

                // SPID
                SPID.SetDbValue(rsnew, SPID.CurrentValue);

                // Chk_Trace
                Chk_Trace.SetDbValue(rsnew, Chk_Trace.CurrentValue);

                // str_DropOffLocation
                str_DropOffLocation.SetDbValue(rsnew, str_DropOffLocation.CurrentValue);

                // imgInstructorSignature
                if (imgInstructorSignature.Visible && !imgInstructorSignature.Upload.KeepFile) {
                    rsnew["imgInstructorSignature"] = new SqlBinaryParameter(imgInstructorSignature.Upload.Value);
                }

                // imgStudentSignature
                if (imgStudentSignature.Visible && !imgStudentSignature.Upload.KeepFile) {
                    rsnew["imgStudentSignature"] = new SqlBinaryParameter(imgStudentSignature.Upload.Value);
                }

                // imgObserverSignature
                if (imgObserverSignature.Visible && !imgObserverSignature.Upload.KeepFile) {
                    rsnew["imgObserverSignature"] = new SqlBinaryParameter(imgObserverSignature.Upload.Value);
                }

                // dt_apptstart
                dt_apptstart.SetDbValue(rsnew, ConvertToDateTime(dt_apptstart.CurrentValue, dt_apptstart.FormatPattern));

                // dt_apptComplete
                dt_apptComplete.SetDbValue(rsnew, ConvertToDateTime(dt_apptComplete.CurrentValue, dt_apptComplete.FormatPattern));

                // int_apptstartedBy
                int_apptstartedBy.SetDbValue(rsnew, int_apptstartedBy.CurrentValue);

                // int_apptCompletedBy
                int_apptCompletedBy.SetDbValue(rsnew, int_apptCompletedBy.CurrentValue);

                // SMSReminder1
                SMSReminder1.SetDbValue(rsnew, ConvertToBool(SMSReminder1.CurrentValue));

                // SMSReminder2
                SMSReminder2.SetDbValue(rsnew, ConvertToBool(SMSReminder2.CurrentValue));

                // SMSReminder3
                SMSReminder3.SetDbValue(rsnew, ConvertToBool(SMSReminder3.CurrentValue));

                // VoiceReminder1
                VoiceReminder1.SetDbValue(rsnew, ConvertToBool(VoiceReminder1.CurrentValue));

                // VoiceReminder2
                VoiceReminder2.SetDbValue(rsnew, ConvertToBool(VoiceReminder2.CurrentValue));

                // VoiceReminder3
                VoiceReminder3.SetDbValue(rsnew, ConvertToBool(VoiceReminder3.CurrentValue));

                // bit_isroadtest
                bit_isroadtest.SetDbValue(rsnew, ConvertToBool(bit_isroadtest.CurrentValue));

                // int_slotType
                int_slotType.SetDbValue(rsnew, int_slotType.CurrentValue);

                // bit_VisibleOnPortal
                bit_VisibleOnPortal.SetDbValue(rsnew, ConvertToBool(bit_VisibleOnPortal.CurrentValue));

                // IsDataRetrieved
                IsDataRetrieved.SetDbValue(rsnew, ConvertToBool(IsDataRetrieved.CurrentValue));

                // bit_chargesApplied
                bit_chargesApplied.SetDbValue(rsnew, ConvertToBool(bit_chargesApplied.CurrentValue));

                // dec_DistanceTravelled
                dec_DistanceTravelled.SetDbValue(rsnew, dec_DistanceTravelled.CurrentValue);

                // btwProductIdsforSSRules
                btwProductIdsforSSRules.SetDbValue(rsnew, btwProductIdsforSSRules.CurrentValue);

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.SetDbValue(rsnew, int_evaluateApptWithEmail.CurrentValue);

                // PublicNotesId
                PublicNotesId.SetDbValue(rsnew, PublicNotesId.CurrentValue);

                // NationalID
                NationalID.SetDbValue(rsnew, NationalID.CurrentValue);

                // str_Username
                str_Username.SetDbValue(rsnew, str_Username.CurrentValue);

                // int_PackageID
                int_PackageID.SetDbValue(rsnew, int_PackageID.CurrentValue);

                // int_ApptCldr_ID
                int_ApptCldr_ID.SetDbValue(rsnew, int_ApptCldr_ID.CurrentValue);

                // str_CRSS_ID
                str_CRSS_ID.SetDbValue(rsnew, str_CRSS_ID.CurrentValue);
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
                    rsnew["int_Appt_id"] = int_Appt_id.CurrentValue!;
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblAppointmentsInfoList")), "", TableVar, true);
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
