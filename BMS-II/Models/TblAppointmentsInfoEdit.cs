namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAppointmentsInfoEdit
    /// </summary>
    public static TblAppointmentsInfoEdit tblAppointmentsInfoEdit
    {
        get => HttpData.Get<TblAppointmentsInfoEdit>("tblAppointmentsInfoEdit")!;
        set => HttpData["tblAppointmentsInfoEdit"] = value;
    }

    /// <summary>
    /// Page class for tblAppointmentsInfo
    /// </summary>
    public class TblAppointmentsInfoEdit : TblAppointmentsInfoEditBase
    {
        // Constructor
        public TblAppointmentsInfoEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAppointmentsInfoEdit() : base()
        {
        }

        // Page Data Rendered event
        public override void PageDataRendered(ref string footer) {
            footer = $"<p class='text-start'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{GetCurrentUserLevelName()}</span></p>";
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblAppointmentsInfoEditBase : TblAppointmentsInfo
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAppointmentsInfo";

        // Page object name
        public string PageObjName = "tblAppointmentsInfoEdit";

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
        public TblAppointmentsInfoEditBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

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
        public string PageName => "TblAppointmentsInfoEdit";

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
            str_EndTime.Visible = false;
            str_PickupTime.Visible = false;
            str_DropOffTime.Visible = false;
            int_VehicleID.Visible = false;
            dec_InstID.Visible = false;
            dec_StudentID.Visible = false;
            dec_Observed_StudentID.Visible = false;
            int_Apptype.SetVisibility();
            int_AppStatus.SetVisibility();
            mny_AppCost.SetVisibility();
            mny_AmountPaid.SetVisibility();
            bit_CheckAppPaid.Visible = false;
            bit_Confirmation.Visible = false;
            str_Instructions.Visible = false;
            str_Instructions1.Visible = false;
            str_AppNotes.Visible = false;
            str_PickupLocation.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            date_Created.Visible = false;
            date_Modified.Visible = false;
            bit_IsDeleted.Visible = false;
            str_Interval.Visible = false;
            RemM1.Visible = false;
            RemM2.Visible = false;
            RemM3.Visible = false;
            int_Location_ID.Visible = false;
            SPID.Visible = false;
            Chk_Trace.Visible = false;
            str_DropOffLocation.Visible = false;
            imgInstructorSignature.Visible = false;
            imgStudentSignature.Visible = false;
            imgObserverSignature.Visible = false;
            dt_apptstart.Visible = false;
            dt_apptComplete.Visible = false;
            int_apptstartedBy.Visible = false;
            int_apptCompletedBy.Visible = false;
            SMSReminder1.Visible = false;
            SMSReminder2.Visible = false;
            SMSReminder3.Visible = false;
            VoiceReminder1.Visible = false;
            VoiceReminder2.Visible = false;
            VoiceReminder3.Visible = false;
            bit_isroadtest.Visible = false;
            int_slotType.Visible = false;
            bit_VisibleOnPortal.Visible = false;
            IsDataRetrieved.Visible = false;
            bit_chargesApplied.Visible = false;
            dec_DistanceTravelled.Visible = false;
            btwProductIdsforSSRules.Visible = false;
            int_evaluateApptWithEmail.Visible = false;
            PublicNotesId.Visible = false;
            NationalID.SetVisibility();
            str_Username.Visible = false;
            int_PackageID.Visible = false;
            int_ApptCldr_ID.Visible = false;
            str_CRSS_ID.Visible = false;
        }

        // Constructor
        public TblAppointmentsInfoEditBase(Controller? controller = null): this() { // DN
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
            int_Apptype.Required = false;

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
                if (RouteValues.TryGetValue("int_Appt_id", out rv)) { // DN
                    int_Appt_id.FormValue = UrlDecode(rv); // DN
                    int_Appt_id.OldValue = int_Appt_id.FormValue;
                } else if (CurrentForm.HasValue("x_int_Appt_id")) {
                    int_Appt_id.FormValue = CurrentForm.GetValue("x_int_Appt_id");
                    int_Appt_id.OldValue = int_Appt_id.FormValue;
                } else if (!Empty(keyValues)) {
                    int_Appt_id.OldValue = ConvertToString(keyValues[0]);
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
                    if (RouteValues.TryGetValue("int_Appt_id", out rv)) { // DN
                        int_Appt_id.QueryValue = UrlDecode(rv); // DN
                        loadByQuery = true;
                    } else if (Get("int_Appt_id", out sv)) {
                        int_Appt_id.QueryValue = sv.ToString();
                        loadByQuery = true;
                    } else {
                        int_Appt_id.CurrentValue = DbNullValue;
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
                int_Appt_id.FormValue = ConvertToString(keyValues[0]);
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
                            return Terminate("TblAppointmentsInfoList"); // No matching record, return to list
                        }
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = ReturnUrl;
                    if (GetPageName(returnUrl) == "TblAppointmentsInfoList")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblAppointmentsInfoList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblAppointmentsInfoList"; // Return list page content
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
                tblAppointmentsInfoEdit?.PageRender();
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

            // Check field name 'int_Apptype' before field var 'x_int_Apptype'
            val = CurrentForm.HasValue("int_Apptype") ? CurrentForm.GetValue("int_Apptype") : CurrentForm.GetValue("x_int_Apptype");
            if (!int_Apptype.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Apptype") && !CurrentForm.HasValue("x_int_Apptype")) // DN
                    int_Apptype.Visible = false; // Disable update for API request
                else
                    int_Apptype.SetFormValue(val);
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
                    mny_AppCost.SetFormValue(val);
            }

            // Check field name 'mny_AmountPaid' before field var 'x_mny_AmountPaid'
            val = CurrentForm.HasValue("mny_AmountPaid") ? CurrentForm.GetValue("mny_AmountPaid") : CurrentForm.GetValue("x_mny_AmountPaid");
            if (!mny_AmountPaid.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_AmountPaid") && !CurrentForm.HasValue("x_mny_AmountPaid")) // DN
                    mny_AmountPaid.Visible = false; // Disable update for API request
                else
                    mny_AmountPaid.SetFormValue(val);
            }

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val);
            }

            // Check field name 'int_Appt_id' before field var 'x_int_Appt_id'
            val = CurrentForm.HasValue("int_Appt_id") ? CurrentForm.GetValue("int_Appt_id") : CurrentForm.GetValue("x_int_Appt_id");
            if (!int_Appt_id.IsDetailKey)
                int_Appt_id.SetFormValue(val);
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Appt_id.CurrentValue = int_Appt_id.FormValue;
            str_AppName.CurrentValue = str_AppName.FormValue;
            str_App_Date.CurrentValue = str_App_Date.FormValue;
            str_StartTime.CurrentValue = str_StartTime.FormValue;
            int_Apptype.CurrentValue = int_Apptype.FormValue;
            int_AppStatus.CurrentValue = int_AppStatus.FormValue;
            mny_AppCost.CurrentValue = mny_AppCost.FormValue;
            mny_AmountPaid.CurrentValue = mny_AmountPaid.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
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

                // int_evaluateApptWithEmail
                int_evaluateApptWithEmail.ViewValue = int_evaluateApptWithEmail.CurrentValue;
                int_evaluateApptWithEmail.ViewValue = FormatNumber(int_evaluateApptWithEmail.ViewValue, int_evaluateApptWithEmail.FormatPattern);
                int_evaluateApptWithEmail.ViewCustomAttributes = "";

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

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";
            } else if (RowType == RowType.Edit) {
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

                // int_Apptype
                int_Apptype.SetupEditAttributes();
                int_Apptype.EditValue = int_Apptype.CurrentValue;
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
                            int_Apptype.EditValue = FormatNumber(int_Apptype.CurrentValue, int_Apptype.FormatPattern);
                        }
                    }
                } else {
                    int_Apptype.EditValue = DbNullValue;
                }
                int_Apptype.ViewCustomAttributes = "";

                // int_AppStatus
                int_AppStatus.SetupEditAttributes();
                int_AppStatus.EditValue = int_AppStatus.Options(true);
                int_AppStatus.PlaceHolder = RemoveHtml(int_AppStatus.Caption);
                if (!Empty(int_AppStatus.EditValue) && IsNumeric(int_AppStatus.EditValue))
                    int_AppStatus.EditValue = FormatNumber(int_AppStatus.EditValue, null);

                // mny_AppCost
                mny_AppCost.SetupEditAttributes();
                mny_AppCost.EditValue = mny_AppCost.CurrentValue;
                mny_AppCost.EditValue = FormatNumber(mny_AppCost.EditValue, mny_AppCost.FormatPattern);
                mny_AppCost.ViewCustomAttributes = "";

                // mny_AmountPaid
                mny_AmountPaid.SetupEditAttributes();
                mny_AmountPaid.EditValue = mny_AmountPaid.CurrentValue;
                mny_AmountPaid.EditValue = FormatNumber(mny_AmountPaid.EditValue, mny_AmountPaid.FormatPattern);
                mny_AmountPaid.ViewCustomAttributes = "";

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.CurrentValue;
                NationalID.EditValue = FormatNumber(NationalID.EditValue, NationalID.FormatPattern);
                NationalID.ViewCustomAttributes = "";

                // Edit refer script

                // str_AppName
                str_AppName.HrefValue = "";

                // str_App_Date
                str_App_Date.HrefValue = "";

                // str_StartTime
                str_StartTime.HrefValue = "";

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

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";
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
            if (int_Apptype.Required) {
                if (!int_Apptype.IsDetailKey && Empty(int_Apptype.FormValue)) {
                    int_Apptype.AddErrorMessage(ConvertToString(int_Apptype.RequiredErrorMessage).Replace("%s", int_Apptype.Caption));
                }
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
            if (mny_AmountPaid.Required) {
                if (!mny_AmountPaid.IsDetailKey && Empty(mny_AmountPaid.FormValue)) {
                    mny_AmountPaid.AddErrorMessage(ConvertToString(mny_AmountPaid.RequiredErrorMessage).Replace("%s", mny_AmountPaid.Caption));
                }
            }
            if (NationalID.Required) {
                if (!NationalID.IsDetailKey && Empty(NationalID.FormValue)) {
                    NationalID.AddErrorMessage(ConvertToString(NationalID.RequiredErrorMessage).Replace("%s", NationalID.Caption));
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

            // str_AppName
            str_AppName.SetDbValue(rsnew, str_AppName.CurrentValue, str_AppName.ReadOnly);

            // str_App_Date
            str_App_Date.SetDbValue(rsnew, str_App_Date.CurrentValue, str_App_Date.ReadOnly);

            // str_StartTime
            str_StartTime.SetDbValue(rsnew, str_StartTime.CurrentValue, str_StartTime.ReadOnly);

            // int_AppStatus
            int_AppStatus.SetDbValue(rsnew, int_AppStatus.CurrentValue, int_AppStatus.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

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

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblAppointmentsInfoList")), "", TableVar, true);
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
