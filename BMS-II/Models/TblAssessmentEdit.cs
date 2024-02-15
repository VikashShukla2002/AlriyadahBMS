namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAssessmentEdit
    /// </summary>
    public static TblAssessmentEdit tblAssessmentEdit
    {
        get => HttpData.Get<TblAssessmentEdit>("tblAssessmentEdit")!;
        set => HttpData["tblAssessmentEdit"] = value;
    }

    /// <summary>
    /// Page class for tblAssessment
    /// </summary>
    public class TblAssessmentEdit : TblAssessmentEditBase
    {
        // Constructor
        public TblAssessmentEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAssessmentEdit() : base()
        {
        }

        // Message Showing event
        // type = ""|"success"|"failure"|"warning"
        public override void MessageShowing(ref string msg, string type) {
            // Note: Do not change msg outside the following 4 cases.
            if (type == "success") 
            {if (CurrentPageID()=="edit")
                msg = "NOTE: All datetimes are instants in time, not spans of a finite length, and they can exist in only one day.\r\n"+
                      "The instant that represents Midnight is by definition, in the next day, the day in which it is the start of the day, \r\n"+
                      "i.e., a day is closed on its beginning and open at its end, or, to phrase it again, valid allowable time values within a single calendar date vary from 00:00:00.00000, to 23:59:59.9999.\r\n"+
                      "Thus, if you entered 00:00 as a time in the [Assessment Date], it will automatically change to 23:59. \r\n"+
                      "Please see link: https://stackoverflow.com/questions/16742799/datetime-manipulation-replace-all-dates-with-0000-time-with-2400-the-previous";
            } else if (type == "failure") {
                //msg = "your failure message";
            } else if (type == "warning") {
                //msg = "your warning message";
            } else {
                //msg = "your message";
            }
        }

        // Page Data Rendered event
        public override void PageDataRendered(ref string footer) {
        	footer = $"<p class='text-start'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{GetCurrentUserLevelName()}</span></p>";
        }
        // Form Custom Validate event
        public override bool FormCustomValidate(ref string customError) {
            var rs = GetFormValues(); // Get the form values as Dictionary<string, string>
            if (Convert.ToDateTime(rs["AssessmentDate"]) <= DateTime.Today) {
                // Return error message in customError
                customError = "The [Assessment Date] must be the current or a future date.";
                return false;
            }
            return true;
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblAssessmentEditBase : TblAssessment
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAssessment";

        // Page object name
        public string PageObjName = "tblAssessmentEdit";

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
        public TblAssessmentEditBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblAssessment)
            if (tblAssessment == null || tblAssessment is TblAssessment)
                tblAssessment = this;

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
        public string PageName => "TblAssessmentEdit";

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
            AssessmentID.Visible = false;
            str_Full_Name_Hdr.SetVisibility();
            str_First_Name.Visible = false;
            str_Middle_Name.Visible = false;
            str_Last_Name.Visible = false;
            str_Username.Visible = false;
            int_Student_ID.Visible = false;
            NationalID.SetVisibility();
            Assessment_Type.SetVisibility();
            AssessmentDate.SetVisibility();
            AssessmentTime.Visible = false;
            isAssessmentDone.SetVisibility();
            AssessmentScore.SetVisibility();
            Assessment_Instructor.SetVisibility();
            Date_Entered.Visible = false;
            IsDrivingexperience.Visible = false;
            intDrivinglicenseType.SetVisibility();
            AbsherApptNbr.SetVisibility();
            Absherphoto.SetVisibility();
            date_Birth.SetVisibility();
            date_Birth_Hijri.SetVisibility();
            str_Cell_Phone.SetVisibility();
            str_Email.SetVisibility();
            UserlevelID.Visible = false;
            BackDateChk.Visible = false;
            DriveTypelink.Visible = false;
            Calendar_ID.Visible = false;
            Assessmnt_Time.Visible = false;
            Institution.Visible = false;
            TheoreticalScore.Visible = false;
            dt_TheoreticalScore.Visible = false;
            RoadTestScore.Visible = false;
            dt_RoadTestScore.Visible = false;
            AccidentOccurrence.SetVisibility();
            Dt_AccidentOccurrence.SetVisibility();
            AccidentNotes.SetVisibility();
        }

        // Constructor
        public TblAssessmentEditBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblAssessmentView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("AssessmentID") ? dict["AssessmentID"] : AssessmentID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                AssessmentID.Visible = false;
            if (IsAddOrEdit)
                BackDateChk.Visible = false;
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
            await SetupLookupOptions(str_Full_Name_Hdr);
            await SetupLookupOptions(NationalID);
            await SetupLookupOptions(Assessment_Type);
            await SetupLookupOptions(isAssessmentDone);
            await SetupLookupOptions(Assessment_Instructor);
            await SetupLookupOptions(IsDrivingexperience);
            await SetupLookupOptions(AccidentOccurrence);

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
                if (RouteValues.TryGetValue("AssessmentID", out rv)) { // DN
                    AssessmentID.FormValue = UrlDecode(rv); // DN
                    AssessmentID.OldValue = AssessmentID.FormValue;
                } else if (CurrentForm.HasValue("x_AssessmentID")) {
                    AssessmentID.FormValue = CurrentForm.GetValue("x_AssessmentID");
                    AssessmentID.OldValue = AssessmentID.FormValue;
                } else if (!Empty(keyValues)) {
                    AssessmentID.OldValue = ConvertToString(keyValues[0]);
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
                    if (RouteValues.TryGetValue("AssessmentID", out rv)) { // DN
                        AssessmentID.QueryValue = UrlDecode(rv); // DN
                        loadByQuery = true;
                    } else if (Get("AssessmentID", out sv)) {
                        AssessmentID.QueryValue = sv.ToString();
                        loadByQuery = true;
                    } else {
                        AssessmentID.CurrentValue = DbNullValue;
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
                AssessmentID.FormValue = ConvertToString(keyValues[0]);
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
                            return Terminate("TblAssessmentList"); // No matching record, return to list
                        }

                    // Set up detail parameters
                    SetupDetailParms();
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = ViewUrl;
                    if (GetPageName(returnUrl) == "TblAssessmentList")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblAssessmentList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblAssessmentList"; // Return list page content
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
                tblAssessmentEdit?.PageRender();
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
            Absherphoto.Upload.Index = CurrentForm.Index;
            if (!await Absherphoto.Upload.UploadFile()) // DN
                End(Absherphoto.Upload.Message);
            Absherphoto.CurrentValue = Absherphoto.Upload.FileName;
        }
        #pragma warning restore 1998

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'str_Full_Name_Hdr' before field var 'x_str_Full_Name_Hdr'
            val = CurrentForm.HasValue("str_Full_Name_Hdr") ? CurrentForm.GetValue("str_Full_Name_Hdr") : CurrentForm.GetValue("x_str_Full_Name_Hdr");
            if (!str_Full_Name_Hdr.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Full_Name_Hdr") && !CurrentForm.HasValue("x_str_Full_Name_Hdr")) // DN
                    str_Full_Name_Hdr.Visible = false; // Disable update for API request
                else
                    str_Full_Name_Hdr.SetFormValue(val);
            }

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val, true, validate);
            }

            // Check field name 'Assessment_Type' before field var 'x_Assessment_Type'
            val = CurrentForm.HasValue("Assessment_Type") ? CurrentForm.GetValue("Assessment_Type") : CurrentForm.GetValue("x_Assessment_Type");
            if (!Assessment_Type.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Assessment_Type") && !CurrentForm.HasValue("x_Assessment_Type")) // DN
                    Assessment_Type.Visible = false; // Disable update for API request
                else
                    Assessment_Type.SetFormValue(val);
            }

            // Check field name 'AssessmentDate' before field var 'x_AssessmentDate'
            val = CurrentForm.HasValue("AssessmentDate") ? CurrentForm.GetValue("AssessmentDate") : CurrentForm.GetValue("x_AssessmentDate");
            if (!AssessmentDate.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AssessmentDate") && !CurrentForm.HasValue("x_AssessmentDate")) // DN
                    AssessmentDate.Visible = false; // Disable update for API request
                else
                    AssessmentDate.SetFormValue(val, true, validate);
                AssessmentDate.CurrentValue = UnformatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern);
            }

            // Check field name 'isAssessmentDone' before field var 'x_isAssessmentDone'
            val = CurrentForm.HasValue("isAssessmentDone") ? CurrentForm.GetValue("isAssessmentDone") : CurrentForm.GetValue("x_isAssessmentDone");
            if (!isAssessmentDone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("isAssessmentDone") && !CurrentForm.HasValue("x_isAssessmentDone")) // DN
                    isAssessmentDone.Visible = false; // Disable update for API request
                else
                    isAssessmentDone.SetFormValue(val);
            }

            // Check field name 'AssessmentScore' before field var 'x_AssessmentScore'
            val = CurrentForm.HasValue("AssessmentScore") ? CurrentForm.GetValue("AssessmentScore") : CurrentForm.GetValue("x_AssessmentScore");
            if (!AssessmentScore.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AssessmentScore") && !CurrentForm.HasValue("x_AssessmentScore")) // DN
                    AssessmentScore.Visible = false; // Disable update for API request
                else
                    AssessmentScore.SetFormValue(val);
            }

            // Check field name 'Assessment_Instructor' before field var 'x_Assessment_Instructor'
            val = CurrentForm.HasValue("Assessment_Instructor") ? CurrentForm.GetValue("Assessment_Instructor") : CurrentForm.GetValue("x_Assessment_Instructor");
            if (!Assessment_Instructor.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Assessment_Instructor") && !CurrentForm.HasValue("x_Assessment_Instructor")) // DN
                    Assessment_Instructor.Visible = false; // Disable update for API request
                else
                    Assessment_Instructor.SetFormValue(val);
            }

            // Check field name 'intDrivinglicenseType' before field var 'x_intDrivinglicenseType'
            val = CurrentForm.HasValue("intDrivinglicenseType") ? CurrentForm.GetValue("intDrivinglicenseType") : CurrentForm.GetValue("x_intDrivinglicenseType");
            if (!intDrivinglicenseType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("intDrivinglicenseType") && !CurrentForm.HasValue("x_intDrivinglicenseType")) // DN
                    intDrivinglicenseType.Visible = false; // Disable update for API request
                else
                    intDrivinglicenseType.SetFormValue(val);
            }

            // Check field name 'AbsherApptNbr' before field var 'x_AbsherApptNbr'
            val = CurrentForm.HasValue("AbsherApptNbr") ? CurrentForm.GetValue("AbsherApptNbr") : CurrentForm.GetValue("x_AbsherApptNbr");
            if (!AbsherApptNbr.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AbsherApptNbr") && !CurrentForm.HasValue("x_AbsherApptNbr")) // DN
                    AbsherApptNbr.Visible = false; // Disable update for API request
                else
                    AbsherApptNbr.SetFormValue(val);
            }

            // Check field name 'date_Birth' before field var 'x_date_Birth'
            val = CurrentForm.HasValue("date_Birth") ? CurrentForm.GetValue("date_Birth") : CurrentForm.GetValue("x_date_Birth");
            if (!date_Birth.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Birth") && !CurrentForm.HasValue("x_date_Birth")) // DN
                    date_Birth.Visible = false; // Disable update for API request
                else
                    date_Birth.SetFormValue(val);
                date_Birth.CurrentValue = UnformatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern);
            }

            // Check field name 'date_Birth_Hijri' before field var 'x_date_Birth_Hijri'
            val = CurrentForm.HasValue("date_Birth_Hijri") ? CurrentForm.GetValue("date_Birth_Hijri") : CurrentForm.GetValue("x_date_Birth_Hijri");
            if (!date_Birth_Hijri.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Birth_Hijri") && !CurrentForm.HasValue("x_date_Birth_Hijri")) // DN
                    date_Birth_Hijri.Visible = false; // Disable update for API request
                else
                    date_Birth_Hijri.SetFormValue(val);
            }

            // Check field name 'str_Cell_Phone' before field var 'x_str_Cell_Phone'
            val = CurrentForm.HasValue("str_Cell_Phone") ? CurrentForm.GetValue("str_Cell_Phone") : CurrentForm.GetValue("x_str_Cell_Phone");
            if (!str_Cell_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Cell_Phone") && !CurrentForm.HasValue("x_str_Cell_Phone")) // DN
                    str_Cell_Phone.Visible = false; // Disable update for API request
                else
                    str_Cell_Phone.SetFormValue(val);
            }

            // Check field name 'str_Email' before field var 'x_str_Email'
            val = CurrentForm.HasValue("str_Email") ? CurrentForm.GetValue("str_Email") : CurrentForm.GetValue("x_str_Email");
            if (!str_Email.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Email") && !CurrentForm.HasValue("x_str_Email")) // DN
                    str_Email.Visible = false; // Disable update for API request
                else
                    str_Email.SetFormValue(val);
            }

            // Check field name 'AccidentOccurrence' before field var 'x_AccidentOccurrence'
            val = CurrentForm.HasValue("AccidentOccurrence") ? CurrentForm.GetValue("AccidentOccurrence") : CurrentForm.GetValue("x_AccidentOccurrence");
            if (!AccidentOccurrence.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AccidentOccurrence") && !CurrentForm.HasValue("x_AccidentOccurrence")) // DN
                    AccidentOccurrence.Visible = false; // Disable update for API request
                else
                    AccidentOccurrence.SetFormValue(val);
            }

            // Check field name 'Dt_AccidentOccurrence' before field var 'x_Dt_AccidentOccurrence'
            val = CurrentForm.HasValue("Dt_AccidentOccurrence") ? CurrentForm.GetValue("Dt_AccidentOccurrence") : CurrentForm.GetValue("x_Dt_AccidentOccurrence");
            if (!Dt_AccidentOccurrence.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Dt_AccidentOccurrence") && !CurrentForm.HasValue("x_Dt_AccidentOccurrence")) // DN
                    Dt_AccidentOccurrence.Visible = false; // Disable update for API request
                else
                    Dt_AccidentOccurrence.SetFormValue(val);
                Dt_AccidentOccurrence.CurrentValue = UnformatDateTime(Dt_AccidentOccurrence.CurrentValue, Dt_AccidentOccurrence.FormatPattern);
            }

            // Check field name 'AccidentNotes' before field var 'x_AccidentNotes'
            val = CurrentForm.HasValue("AccidentNotes") ? CurrentForm.GetValue("AccidentNotes") : CurrentForm.GetValue("x_AccidentNotes");
            if (!AccidentNotes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AccidentNotes") && !CurrentForm.HasValue("x_AccidentNotes")) // DN
                    AccidentNotes.Visible = false; // Disable update for API request
                else
                    AccidentNotes.SetFormValue(val);
            }

            // Check field name 'AssessmentID' before field var 'x_AssessmentID'
            val = CurrentForm.HasValue("AssessmentID") ? CurrentForm.GetValue("AssessmentID") : CurrentForm.GetValue("x_AssessmentID");
            if (!AssessmentID.IsDetailKey)
                AssessmentID.SetFormValue(val);
            await GetUploadFiles(); // Get upload files
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            AssessmentID.CurrentValue = AssessmentID.FormValue;
            str_Full_Name_Hdr.CurrentValue = str_Full_Name_Hdr.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            Assessment_Type.CurrentValue = Assessment_Type.FormValue;
            AssessmentDate.CurrentValue = AssessmentDate.FormValue;
            AssessmentDate.CurrentValue = UnformatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern);
            isAssessmentDone.CurrentValue = isAssessmentDone.FormValue;
            AssessmentScore.CurrentValue = AssessmentScore.FormValue;
            Assessment_Instructor.CurrentValue = Assessment_Instructor.FormValue;
            intDrivinglicenseType.CurrentValue = intDrivinglicenseType.FormValue;
            AbsherApptNbr.CurrentValue = AbsherApptNbr.FormValue;
            date_Birth.CurrentValue = date_Birth.FormValue;
            date_Birth.CurrentValue = UnformatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern);
            date_Birth_Hijri.CurrentValue = date_Birth_Hijri.FormValue;
            str_Cell_Phone.CurrentValue = str_Cell_Phone.FormValue;
            str_Email.CurrentValue = str_Email.FormValue;
            AccidentOccurrence.CurrentValue = AccidentOccurrence.FormValue;
            Dt_AccidentOccurrence.CurrentValue = Dt_AccidentOccurrence.FormValue;
            Dt_AccidentOccurrence.CurrentValue = UnformatDateTime(Dt_AccidentOccurrence.CurrentValue, Dt_AccidentOccurrence.FormatPattern);
            AccidentNotes.CurrentValue = AccidentNotes.FormValue;
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
            AssessmentID.SetDbValue(row["AssessmentID"]);
            str_Full_Name_Hdr.SetDbValue(row["str_Full_Name_Hdr"]);
            str_First_Name.SetDbValue(row["str_First_Name"]);
            str_Middle_Name.SetDbValue(row["str_Middle_Name"]);
            str_Last_Name.SetDbValue(row["str_Last_Name"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            NationalID.SetDbValue(row["NationalID"]);
            Assessment_Type.SetDbValue(row["Assessment_Type"]);
            AssessmentDate.SetDbValue(row["AssessmentDate"]);
            AssessmentTime.SetDbValue(row["AssessmentTime"]);
            isAssessmentDone.SetDbValue(row["isAssessmentDone"]);
            AssessmentScore.SetDbValue(row["AssessmentScore"]);
            Assessment_Instructor.SetDbValue(row["Assessment_Instructor"]);
            Date_Entered.SetDbValue(row["Date_Entered"]);
            IsDrivingexperience.SetDbValue((ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"));
            intDrivinglicenseType.SetDbValue(row["intDrivinglicenseType"]);
            AbsherApptNbr.SetDbValue(row["AbsherApptNbr"]);
            Absherphoto.Upload.DbValue = row["Absherphoto"];
            Absherphoto.SetDbValue(Absherphoto.Upload.DbValue);
            date_Birth.SetDbValue(row["date_Birth"]);
            date_Birth_Hijri.SetDbValue(row["date_Birth_Hijri"]);
            str_Cell_Phone.SetDbValue(row["str_Cell_Phone"]);
            str_Email.SetDbValue(row["str_Email"]);
            UserlevelID.SetDbValue(row["UserlevelID"]);
            BackDateChk.SetDbValue(row["BackDateChk"]);
            DriveTypelink.SetDbValue(row["DriveTypelink"]);
            Calendar_ID.SetDbValue(row["Calendar_ID"]);
            Assessmnt_Time.SetDbValue(row["Assessmnt_Time"]);
            Institution.SetDbValue(row["Institution"]);
            TheoreticalScore.SetDbValue(IsNull(row["TheoreticalScore"]) ? DbNullValue : ConvertToDouble(row["TheoreticalScore"]));
            dt_TheoreticalScore.SetDbValue(row["dt_TheoreticalScore"]);
            RoadTestScore.SetDbValue(IsNull(row["RoadTestScore"]) ? DbNullValue : ConvertToDouble(row["RoadTestScore"]));
            dt_RoadTestScore.SetDbValue(row["dt_RoadTestScore"]);
            AccidentOccurrence.SetDbValue((ConvertToBool(row["AccidentOccurrence"]) ? "1" : "0"));
            Dt_AccidentOccurrence.SetDbValue(row["Dt_AccidentOccurrence"]);
            AccidentNotes.SetDbValue(row["AccidentNotes"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("AssessmentID", AssessmentID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Full_Name_Hdr", str_Full_Name_Hdr.DefaultValue ?? DbNullValue); // DN
            row.Add("str_First_Name", str_First_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Middle_Name", str_Middle_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last_Name", str_Last_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("Assessment_Type", Assessment_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentDate", AssessmentDate.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentTime", AssessmentTime.DefaultValue ?? DbNullValue); // DN
            row.Add("isAssessmentDone", isAssessmentDone.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentScore", AssessmentScore.DefaultValue ?? DbNullValue); // DN
            row.Add("Assessment_Instructor", Assessment_Instructor.DefaultValue ?? DbNullValue); // DN
            row.Add("Date_Entered", Date_Entered.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDrivingexperience", IsDrivingexperience.DefaultValue ?? DbNullValue); // DN
            row.Add("intDrivinglicenseType", intDrivinglicenseType.DefaultValue ?? DbNullValue); // DN
            row.Add("AbsherApptNbr", AbsherApptNbr.DefaultValue ?? DbNullValue); // DN
            row.Add("Absherphoto", Absherphoto.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth", date_Birth.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth_Hijri", date_Birth_Hijri.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Cell_Phone", str_Cell_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email", str_Email.DefaultValue ?? DbNullValue); // DN
            row.Add("UserlevelID", UserlevelID.DefaultValue ?? DbNullValue); // DN
            row.Add("BackDateChk", BackDateChk.DefaultValue ?? DbNullValue); // DN
            row.Add("DriveTypelink", DriveTypelink.DefaultValue ?? DbNullValue); // DN
            row.Add("Calendar_ID", Calendar_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Assessmnt_Time", Assessmnt_Time.DefaultValue ?? DbNullValue); // DN
            row.Add("Institution", Institution.DefaultValue ?? DbNullValue); // DN
            row.Add("TheoreticalScore", TheoreticalScore.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_TheoreticalScore", dt_TheoreticalScore.DefaultValue ?? DbNullValue); // DN
            row.Add("RoadTestScore", RoadTestScore.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_RoadTestScore", dt_RoadTestScore.DefaultValue ?? DbNullValue); // DN
            row.Add("AccidentOccurrence", AccidentOccurrence.DefaultValue ?? DbNullValue); // DN
            row.Add("Dt_AccidentOccurrence", Dt_AccidentOccurrence.DefaultValue ?? DbNullValue); // DN
            row.Add("AccidentNotes", AccidentNotes.DefaultValue ?? DbNullValue); // DN
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

            // AssessmentID
            AssessmentID.RowCssClass = "row";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.RowCssClass = "row";

            // str_First_Name
            str_First_Name.RowCssClass = "row";

            // str_Middle_Name
            str_Middle_Name.RowCssClass = "row";

            // str_Last_Name
            str_Last_Name.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // int_Student_ID
            int_Student_ID.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // Assessment_Type
            Assessment_Type.RowCssClass = "row";

            // AssessmentDate
            AssessmentDate.RowCssClass = "row";

            // AssessmentTime
            AssessmentTime.RowCssClass = "row";

            // isAssessmentDone
            isAssessmentDone.RowCssClass = "row";

            // AssessmentScore
            AssessmentScore.RowCssClass = "row";

            // Assessment_Instructor
            Assessment_Instructor.RowCssClass = "row";

            // Date_Entered
            Date_Entered.RowCssClass = "row";

            // IsDrivingexperience
            IsDrivingexperience.RowCssClass = "row";

            // intDrivinglicenseType
            intDrivinglicenseType.RowCssClass = "row";

            // AbsherApptNbr
            AbsherApptNbr.RowCssClass = "row";

            // Absherphoto
            Absherphoto.RowCssClass = "row";

            // date_Birth
            date_Birth.RowCssClass = "row";

            // date_Birth_Hijri
            date_Birth_Hijri.RowCssClass = "row";

            // str_Cell_Phone
            str_Cell_Phone.RowCssClass = "row";

            // str_Email
            str_Email.RowCssClass = "row";

            // UserlevelID
            UserlevelID.RowCssClass = "row";

            // BackDateChk
            BackDateChk.RowCssClass = "row";

            // DriveTypelink
            DriveTypelink.RowCssClass = "row";

            // Calendar_ID
            Calendar_ID.RowCssClass = "row";

            // Assessmnt_Time
            Assessmnt_Time.RowCssClass = "row";

            // Institution
            Institution.RowCssClass = "row";

            // TheoreticalScore
            TheoreticalScore.RowCssClass = "row";

            // dt_TheoreticalScore
            dt_TheoreticalScore.RowCssClass = "row";

            // RoadTestScore
            RoadTestScore.RowCssClass = "row";

            // dt_RoadTestScore
            dt_RoadTestScore.RowCssClass = "row";

            // AccidentOccurrence
            AccidentOccurrence.RowCssClass = "row";

            // Dt_AccidentOccurrence
            Dt_AccidentOccurrence.RowCssClass = "row";

            // AccidentNotes
            AccidentNotes.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // AssessmentID
                AssessmentID.ViewValue = AssessmentID.CurrentValue;
                AssessmentID.ViewCustomAttributes = "";

                // str_Full_Name_Hdr
                curVal = ConvertToString(str_Full_Name_Hdr.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Full_Name_Hdr.Lookup != null && IsDictionary(str_Full_Name_Hdr.Lookup?.Options) && str_Full_Name_Hdr.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name_Hdr.CurrentValue, DataType.String, "");
                        lookupFilter = () => str_Full_Name_Hdr.GetSelectFilter();
                        sqlWrk = str_Full_Name_Hdr.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Full_Name_Hdr.Lookup != null) { // Lookup values found
                            var listwrk = str_Full_Name_Hdr.Lookup?.RenderViewRow(rswrk[0]);
                            str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.HighlightLookup(ConvertToString(rswrk[0]), str_Full_Name_Hdr.DisplayValue(listwrk));
                        } else {
                            str_Full_Name_Hdr.ViewValue = str_Full_Name_Hdr.CurrentValue;
                        }
                    }
                } else {
                    str_Full_Name_Hdr.ViewValue = DbNullValue;
                }
                str_Full_Name_Hdr.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Middle_Name
                str_Middle_Name.ViewValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
                str_Middle_Name.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // int_Student_ID
                int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
                int_Student_ID.ImageAlt = int_Student_ID.Alt;
                    int_Student_ID.ImageCssClass = "ew-image";
                int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
                int_Student_ID.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
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

                // Assessment_Type
                if (!Empty(Assessment_Type.CurrentValue)) {
                    Assessment_Type.ViewValue = Assessment_Type.HighlightLookup(ConvertToString(Assessment_Type.CurrentValue), Assessment_Type.OptionCaption(ConvertToString(Assessment_Type.CurrentValue)));
                } else {
                    Assessment_Type.ViewValue = DbNullValue;
                }
                Assessment_Type.ViewCustomAttributes = "";

                // AssessmentDate
                AssessmentDate.ViewValue = AssessmentDate.CurrentValue;
                AssessmentDate.ViewValue = FormatDateTime(AssessmentDate.ViewValue, AssessmentDate.FormatPattern);
                AssessmentDate.ViewCustomAttributes = "";

                // AssessmentTime
                AssessmentTime.ViewValue = ConvertToString(AssessmentTime.CurrentValue); // DN
                AssessmentTime.ViewCustomAttributes = "";

                // isAssessmentDone
                if (!Empty(isAssessmentDone.CurrentValue)) {
                    isAssessmentDone.ViewValue = isAssessmentDone.HighlightLookup(ConvertToString(isAssessmentDone.CurrentValue), isAssessmentDone.OptionCaption(ConvertToString(isAssessmentDone.CurrentValue)));
                } else {
                    isAssessmentDone.ViewValue = DbNullValue;
                }
                isAssessmentDone.ViewCustomAttributes = "";

                // AssessmentScore
                AssessmentScore.ViewValue = ConvertToString(AssessmentScore.CurrentValue); // DN
                AssessmentScore.ViewCustomAttributes = "";

                // Assessment_Instructor
                curVal = ConvertToString(Assessment_Instructor.CurrentValue);
                if (!Empty(curVal)) {
                    if (Assessment_Instructor.Lookup != null && IsDictionary(Assessment_Instructor.Lookup?.Options) && Assessment_Instructor.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Assessment_Instructor.ViewValue = Assessment_Instructor.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Full_Name]", "=", Assessment_Instructor.CurrentValue, DataType.String, "");
                        sqlWrk = Assessment_Instructor.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Assessment_Instructor.Lookup != null) { // Lookup values found
                            var listwrk = Assessment_Instructor.Lookup?.RenderViewRow(rswrk[0]);
                            Assessment_Instructor.ViewValue = Assessment_Instructor.HighlightLookup(ConvertToString(rswrk[0]), Assessment_Instructor.DisplayValue(listwrk));
                        } else {
                            Assessment_Instructor.ViewValue = Assessment_Instructor.CurrentValue;
                        }
                    }
                } else {
                    Assessment_Instructor.ViewValue = DbNullValue;
                }
                Assessment_Instructor.ViewCustomAttributes = "";

                // Date_Entered
                Date_Entered.ViewValue = Date_Entered.CurrentValue;
                Date_Entered.ViewValue = FormatDateTime(Date_Entered.ViewValue, Date_Entered.FormatPattern);
                Date_Entered.ViewCustomAttributes = "";

                // IsDrivingexperience
                if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
                } else {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
                }
                IsDrivingexperience.ViewCustomAttributes = "";

                // intDrivinglicenseType
                intDrivinglicenseType.ViewValue = intDrivinglicenseType.CurrentValue;
                intDrivinglicenseType.ViewValue = FormatNumber(intDrivinglicenseType.ViewValue, intDrivinglicenseType.FormatPattern);
                intDrivinglicenseType.ViewCustomAttributes = "";

                // AbsherApptNbr
                AbsherApptNbr.ViewValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
                AbsherApptNbr.ViewCustomAttributes = "";

                // Absherphoto
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.ImageWidth = 200;
                    Absherphoto.ImageHeight = 200;
                    Absherphoto.ImageAlt = Absherphoto.Alt;
                    Absherphoto.ImageCssClass = "ew-image";
                    Absherphoto.ViewValue = Absherphoto.Upload.DbValue;
                } else {
                    Absherphoto.ViewValue = "";
                }
                Absherphoto.ViewCustomAttributes = "";

                // date_Birth
                date_Birth.ViewValue = date_Birth.CurrentValue;
                date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
                date_Birth.ViewCustomAttributes = "";

                // date_Birth_Hijri
                date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // str_Cell_Phone
                str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
                str_Cell_Phone.ViewCustomAttributes = "";

                // str_Email
                str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
                str_Email.ViewCustomAttributes = "";

                // UserlevelID
                UserlevelID.ViewValue = UserlevelID.CurrentValue;
                UserlevelID.ViewValue = FormatNumber(UserlevelID.ViewValue, UserlevelID.FormatPattern);
                UserlevelID.ViewCustomAttributes = "";

                // Calendar_ID
                Calendar_ID.ViewValue = Calendar_ID.CurrentValue;
                Calendar_ID.ViewValue = FormatNumber(Calendar_ID.ViewValue, Calendar_ID.FormatPattern);
                Calendar_ID.ViewCustomAttributes = "";

                // Assessmnt_Time
                Assessmnt_Time.ViewValue = Assessmnt_Time.CurrentValue;
                Assessmnt_Time.ViewValue = FormatDateTime(Assessmnt_Time.ViewValue, Assessmnt_Time.FormatPattern);
                Assessmnt_Time.ViewCustomAttributes = "";

                // Institution
                Institution.ViewValue = ConvertToString(Institution.CurrentValue); // DN
                Institution.ViewCustomAttributes = "";

                // TheoreticalScore
                TheoreticalScore.ViewValue = TheoreticalScore.CurrentValue;
                TheoreticalScore.ViewValue = FormatNumber(TheoreticalScore.ViewValue, TheoreticalScore.FormatPattern);
                TheoreticalScore.ViewCustomAttributes = "";

                // dt_TheoreticalScore
                dt_TheoreticalScore.ViewValue = dt_TheoreticalScore.CurrentValue;
                dt_TheoreticalScore.ViewValue = FormatDateTime(dt_TheoreticalScore.ViewValue, dt_TheoreticalScore.FormatPattern);
                dt_TheoreticalScore.ViewCustomAttributes = "";

                // RoadTestScore
                RoadTestScore.ViewValue = RoadTestScore.CurrentValue;
                RoadTestScore.ViewValue = FormatNumber(RoadTestScore.ViewValue, RoadTestScore.FormatPattern);
                RoadTestScore.ViewCustomAttributes = "";

                // dt_RoadTestScore
                dt_RoadTestScore.ViewValue = dt_RoadTestScore.CurrentValue;
                dt_RoadTestScore.ViewValue = FormatDateTime(dt_RoadTestScore.ViewValue, dt_RoadTestScore.FormatPattern);
                dt_RoadTestScore.ViewCustomAttributes = "";

                // AccidentOccurrence
                if (ConvertToBool(AccidentOccurrence.CurrentValue)) {
                    AccidentOccurrence.ViewValue = AccidentOccurrence.TagCaption(1) != "" ? AccidentOccurrence.TagCaption(1) : "Yes";
                } else {
                    AccidentOccurrence.ViewValue = AccidentOccurrence.TagCaption(2) != "" ? AccidentOccurrence.TagCaption(2) : "No";
                }
                AccidentOccurrence.ViewCustomAttributes = "";

                // Dt_AccidentOccurrence
                Dt_AccidentOccurrence.ViewValue = Dt_AccidentOccurrence.CurrentValue;
                Dt_AccidentOccurrence.ViewValue = FormatDateTime(Dt_AccidentOccurrence.ViewValue, Dt_AccidentOccurrence.FormatPattern);
                Dt_AccidentOccurrence.ViewCustomAttributes = "";

                // AccidentNotes
                AccidentNotes.ViewValue = AccidentNotes.CurrentValue;
                AccidentNotes.ViewCustomAttributes = "";

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // Assessment_Type
                Assessment_Type.HrefValue = "";

                // AssessmentDate
                AssessmentDate.HrefValue = "";

                // isAssessmentDone
                isAssessmentDone.HrefValue = "";

                // AssessmentScore
                AssessmentScore.HrefValue = "";
                AssessmentScore.TooltipValue = "";

                // Assessment_Instructor
                Assessment_Instructor.HrefValue = "";

                // intDrivinglicenseType
                if (!IsNull(intDrivinglicenseType.CurrentValue)) {
                    intDrivinglicenseType.HrefValue = ConvertToString(!Empty(intDrivinglicenseType.EditValue) && !IsList(intDrivinglicenseType.EditValue) ? RemoveHtml(ConvertToString(intDrivinglicenseType.EditValue)) : ConvertToString(intDrivinglicenseType.CurrentValue)); // Add prefix/suffix
                    intDrivinglicenseType.LinkAttrs["target"] = ""; // Add target
                    if (IsExport())
                        intDrivinglicenseType.HrefValue = FullUrl(ConvertToString(intDrivinglicenseType.HrefValue), "href");
                } else {
                    intDrivinglicenseType.HrefValue = "";
                }
                if (!IsExport()) {
                    intDrivinglicenseType.TooltipValue = ConvertToString(DriveTypelink.CurrentValue);
                    if (Empty(intDrivinglicenseType.HrefValue))
                        intDrivinglicenseType.HrefValue = "javascript:void(0);";
                    intDrivinglicenseType.LinkAttrs["class"] = "ew-tooltip-link";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblAssessment_x_intDrivinglicenseType";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                    intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
                }

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";
                AbsherApptNbr.TooltipValue = "";

                // Absherphoto
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.HrefValue = ConvertToString(GetFileUploadUrl(Absherphoto, Absherphoto.HtmlDecode(ConvertToString(Absherphoto.Upload.DbValue)))); // Add prefix/suffix
                    Absherphoto.LinkAttrs["target"] = "_blank"; // Add target
                    if (IsExport())
                        Absherphoto.HrefValue = FullUrl(ConvertToString(Absherphoto.HrefValue), "href");
                } else {
                    Absherphoto.HrefValue = "";
                }
                Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
                Absherphoto.TooltipValue = "";
                if (Absherphoto.UseColorbox) {
                    if (Empty(Absherphoto.TooltipValue))
                        Absherphoto.LinkAttrs["title"] = Language.Phrase("ViewImageGallery");
                    Absherphoto.LinkAttrs["data-rel"] = "tblAssessment_x_Absherphoto";
                    if (Absherphoto.LinkAttrs.ContainsKey("class")) {
                        Absherphoto.LinkAttrs.AppendClass("ew-lightbox");
                    } else {
                        Absherphoto.LinkAttrs["class"] = "ew-lightbox";
                    }
                }

                // date_Birth
                date_Birth.HrefValue = "";
                date_Birth.TooltipValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";
                date_Birth_Hijri.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // str_Email
                str_Email.HrefValue = "";
                str_Email.TooltipValue = "";

                // AccidentOccurrence
                AccidentOccurrence.HrefValue = "";

                // Dt_AccidentOccurrence
                Dt_AccidentOccurrence.HrefValue = "";
                Dt_AccidentOccurrence.TooltipValue = "";

                // AccidentNotes
                AccidentNotes.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // str_Full_Name_Hdr
                str_Full_Name_Hdr.SetupEditAttributes();
                curVal = ConvertToString(str_Full_Name_Hdr.CurrentValue)?.Trim() ?? "";
                if (str_Full_Name_Hdr.Lookup != null && IsDictionary(str_Full_Name_Hdr.Lookup?.Options) && str_Full_Name_Hdr.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Full_Name_Hdr.EditValue = str_Full_Name_Hdr.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name_Hdr.CurrentValue, DataType.String, "");
                    }
                    lookupFilter = () => str_Full_Name_Hdr.GetSelectFilter();
                    sqlWrk = str_Full_Name_Hdr.Lookup?.GetSql(true, filterWrk, lookupFilter, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_Full_Name_Hdr.EditValue = rswrk;
                }
                str_Full_Name_Hdr.PlaceHolder = RemoveHtml(str_Full_Name_Hdr.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.CurrentValue; // DN
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
                            NationalID.EditValue = HtmlEncode(NationalID.CurrentValue);
                        }
                    }
                } else {
                    NationalID.EditValue = DbNullValue;
                }
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

                // Assessment_Type
                Assessment_Type.SetupEditAttributes();
                Assessment_Type.EditValue = Assessment_Type.Options(true);
                Assessment_Type.PlaceHolder = RemoveHtml(Assessment_Type.Caption);

                // AssessmentDate
                AssessmentDate.SetupEditAttributes();
                AssessmentDate.EditValue = FormatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern); // DN
                AssessmentDate.PlaceHolder = RemoveHtml(AssessmentDate.Caption);

                // isAssessmentDone
                isAssessmentDone.EditValue = isAssessmentDone.Options(false);
                isAssessmentDone.PlaceHolder = RemoveHtml(isAssessmentDone.Caption);

                // AssessmentScore
                AssessmentScore.SetupEditAttributes();
                AssessmentScore.EditValue = ConvertToString(AssessmentScore.CurrentValue); // DN
                AssessmentScore.ViewCustomAttributes = "";

                // Assessment_Instructor
                Assessment_Instructor.SetupEditAttributes();
                curVal = ConvertToString(Assessment_Instructor.CurrentValue)?.Trim() ?? "";
                if (Assessment_Instructor.Lookup != null && IsDictionary(Assessment_Instructor.Lookup?.Options) && Assessment_Instructor.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Assessment_Instructor.EditValue = Assessment_Instructor.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Full_Name]", "=", Assessment_Instructor.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = Assessment_Instructor.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    Assessment_Instructor.EditValue = rswrk;
                }
                Assessment_Instructor.PlaceHolder = RemoveHtml(Assessment_Instructor.Caption);

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.CurrentValue;
                intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, intDrivinglicenseType.FormatPattern);
                intDrivinglicenseType.ViewCustomAttributes = "";

                // AbsherApptNbr
                AbsherApptNbr.SetupEditAttributes();
                AbsherApptNbr.EditValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
                AbsherApptNbr.ViewCustomAttributes = "";

                // Absherphoto
                Absherphoto.SetupEditAttributes();
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.ImageWidth = 200;
                    Absherphoto.ImageHeight = 200;
                    Absherphoto.ImageAlt = Absherphoto.Alt;
                    Absherphoto.ImageCssClass = "ew-image";
                    Absherphoto.EditValue = Absherphoto.Upload.DbValue;
                } else {
                    Absherphoto.EditValue = "";
                }
                Absherphoto.ViewCustomAttributes = "";

                // date_Birth
                date_Birth.SetupEditAttributes();
                date_Birth.EditValue = date_Birth.CurrentValue;
                date_Birth.EditValue = FormatDateTime(date_Birth.EditValue, date_Birth.FormatPattern);
                date_Birth.ViewCustomAttributes = "";

                // date_Birth_Hijri
                date_Birth_Hijri.SetupEditAttributes();
                date_Birth_Hijri.EditValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                str_Cell_Phone.EditValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
                str_Cell_Phone.ViewCustomAttributes = "";

                // str_Email
                str_Email.SetupEditAttributes();
                str_Email.EditValue = ConvertToString(str_Email.CurrentValue); // DN
                str_Email.ViewCustomAttributes = "";

                // AccidentOccurrence
                AccidentOccurrence.EditValue = AccidentOccurrence.Options(false);
                AccidentOccurrence.PlaceHolder = RemoveHtml(AccidentOccurrence.Caption);

                // Dt_AccidentOccurrence
                Dt_AccidentOccurrence.SetupEditAttributes();
                Dt_AccidentOccurrence.EditValue = Dt_AccidentOccurrence.CurrentValue;
                Dt_AccidentOccurrence.EditValue = FormatDateTime(Dt_AccidentOccurrence.EditValue, Dt_AccidentOccurrence.FormatPattern);
                Dt_AccidentOccurrence.ViewCustomAttributes = "";

                // AccidentNotes
                AccidentNotes.SetupEditAttributes();
                AccidentNotes.EditValue = AccidentNotes.CurrentValue; // DN
                AccidentNotes.PlaceHolder = RemoveHtml(AccidentNotes.Caption);

                // Edit refer script

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // Assessment_Type
                Assessment_Type.HrefValue = "";

                // AssessmentDate
                AssessmentDate.HrefValue = "";

                // isAssessmentDone
                isAssessmentDone.HrefValue = "";

                // AssessmentScore
                AssessmentScore.HrefValue = "";
                AssessmentScore.TooltipValue = "";

                // Assessment_Instructor
                Assessment_Instructor.HrefValue = "";

                // intDrivinglicenseType
                if (!IsNull(intDrivinglicenseType.CurrentValue)) {
                    intDrivinglicenseType.HrefValue = ConvertToString(!Empty(intDrivinglicenseType.EditValue) && !IsList(intDrivinglicenseType.EditValue) ? RemoveHtml(ConvertToString(intDrivinglicenseType.EditValue)) : ConvertToString(intDrivinglicenseType.CurrentValue)); // Add prefix/suffix
                    intDrivinglicenseType.LinkAttrs["target"] = ""; // Add target
                    if (IsExport())
                        intDrivinglicenseType.HrefValue = FullUrl(ConvertToString(intDrivinglicenseType.HrefValue), "href");
                } else {
                    intDrivinglicenseType.HrefValue = "";
                }
                if (!IsExport()) {
                    intDrivinglicenseType.TooltipValue = ConvertToString(DriveTypelink.CurrentValue);
                    if (Empty(intDrivinglicenseType.HrefValue))
                        intDrivinglicenseType.HrefValue = "javascript:void(0);";
                    intDrivinglicenseType.LinkAttrs["class"] = "ew-tooltip-link";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblAssessment_x_intDrivinglicenseType";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                    intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
                }

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";
                AbsherApptNbr.TooltipValue = "";

                // Absherphoto
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.HrefValue = ConvertToString(GetFileUploadUrl(Absherphoto, Absherphoto.HtmlDecode(ConvertToString(Absherphoto.Upload.DbValue)))); // Add prefix/suffix
                    Absherphoto.LinkAttrs["target"] = "_blank"; // Add target
                    if (IsExport())
                        Absherphoto.HrefValue = FullUrl(ConvertToString(Absherphoto.HrefValue), "href");
                } else {
                    Absherphoto.HrefValue = "";
                }
                Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
                Absherphoto.TooltipValue = "";
                if (Absherphoto.UseColorbox) {
                    if (Empty(Absherphoto.TooltipValue))
                        Absherphoto.LinkAttrs["title"] = Language.Phrase("ViewImageGallery");
                    Absherphoto.LinkAttrs["data-rel"] = "tblAssessment_x_Absherphoto";
                    if (Absherphoto.LinkAttrs.ContainsKey("class")) {
                        Absherphoto.LinkAttrs.AppendClass("ew-lightbox");
                    } else {
                        Absherphoto.LinkAttrs["class"] = "ew-lightbox";
                    }
                }

                // date_Birth
                date_Birth.HrefValue = "";
                date_Birth.TooltipValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";
                date_Birth_Hijri.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // str_Email
                str_Email.HrefValue = "";
                str_Email.TooltipValue = "";

                // AccidentOccurrence
                AccidentOccurrence.HrefValue = "";

                // Dt_AccidentOccurrence
                Dt_AccidentOccurrence.HrefValue = "";
                Dt_AccidentOccurrence.TooltipValue = "";

                // AccidentNotes
                AccidentNotes.HrefValue = "";
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
            if (str_Full_Name_Hdr.Required) {
                if (!str_Full_Name_Hdr.IsDetailKey && Empty(str_Full_Name_Hdr.FormValue)) {
                    str_Full_Name_Hdr.AddErrorMessage(ConvertToString(str_Full_Name_Hdr.RequiredErrorMessage).Replace("%s", str_Full_Name_Hdr.Caption));
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
            if (Assessment_Type.Required) {
                if (!Assessment_Type.IsDetailKey && Empty(Assessment_Type.FormValue)) {
                    Assessment_Type.AddErrorMessage(ConvertToString(Assessment_Type.RequiredErrorMessage).Replace("%s", Assessment_Type.Caption));
                }
            }
            if (AssessmentDate.Required) {
                if (!AssessmentDate.IsDetailKey && Empty(AssessmentDate.FormValue)) {
                    AssessmentDate.AddErrorMessage(ConvertToString(AssessmentDate.RequiredErrorMessage).Replace("%s", AssessmentDate.Caption));
                }
            }
            if (!CheckDate(AssessmentDate.FormValue, AssessmentDate.FormatPattern)) {
                AssessmentDate.AddErrorMessage(AssessmentDate.GetErrorMessage(false));
            }
            if (isAssessmentDone.Required) {
                if (Empty(isAssessmentDone.FormValue)) {
                    isAssessmentDone.AddErrorMessage(ConvertToString(isAssessmentDone.RequiredErrorMessage).Replace("%s", isAssessmentDone.Caption));
                }
            }
            if (AssessmentScore.Required) {
                if (!AssessmentScore.IsDetailKey && Empty(AssessmentScore.FormValue)) {
                    AssessmentScore.AddErrorMessage(ConvertToString(AssessmentScore.RequiredErrorMessage).Replace("%s", AssessmentScore.Caption));
                }
            }
            if (Assessment_Instructor.Required) {
                if (!Assessment_Instructor.IsDetailKey && Empty(Assessment_Instructor.FormValue)) {
                    Assessment_Instructor.AddErrorMessage(ConvertToString(Assessment_Instructor.RequiredErrorMessage).Replace("%s", Assessment_Instructor.Caption));
                }
            }
            if (intDrivinglicenseType.Required) {
                if (!intDrivinglicenseType.IsDetailKey && Empty(intDrivinglicenseType.FormValue)) {
                    intDrivinglicenseType.AddErrorMessage(ConvertToString(intDrivinglicenseType.RequiredErrorMessage).Replace("%s", intDrivinglicenseType.Caption));
                }
            }
            if (AbsherApptNbr.Required) {
                if (!AbsherApptNbr.IsDetailKey && Empty(AbsherApptNbr.FormValue)) {
                    AbsherApptNbr.AddErrorMessage(ConvertToString(AbsherApptNbr.RequiredErrorMessage).Replace("%s", AbsherApptNbr.Caption));
                }
            }
            if (Absherphoto.Required) {
                if (Absherphoto.Upload.FileName == "" && !Absherphoto.Upload.KeepFile) {
                    Absherphoto.AddErrorMessage(ConvertToString(Absherphoto.RequiredErrorMessage).Replace("%s", Absherphoto.Caption));
                }
            }
            if (date_Birth.Required) {
                if (!date_Birth.IsDetailKey && Empty(date_Birth.FormValue)) {
                    date_Birth.AddErrorMessage(ConvertToString(date_Birth.RequiredErrorMessage).Replace("%s", date_Birth.Caption));
                }
            }
            if (date_Birth_Hijri.Required) {
                if (!date_Birth_Hijri.IsDetailKey && Empty(date_Birth_Hijri.FormValue)) {
                    date_Birth_Hijri.AddErrorMessage(ConvertToString(date_Birth_Hijri.RequiredErrorMessage).Replace("%s", date_Birth_Hijri.Caption));
                }
            }
            if (str_Cell_Phone.Required) {
                if (!str_Cell_Phone.IsDetailKey && Empty(str_Cell_Phone.FormValue)) {
                    str_Cell_Phone.AddErrorMessage(ConvertToString(str_Cell_Phone.RequiredErrorMessage).Replace("%s", str_Cell_Phone.Caption));
                }
            }
            if (str_Email.Required) {
                if (!str_Email.IsDetailKey && Empty(str_Email.FormValue)) {
                    str_Email.AddErrorMessage(ConvertToString(str_Email.RequiredErrorMessage).Replace("%s", str_Email.Caption));
                }
            }
            if (AccidentOccurrence.Required) {
                if (Empty(AccidentOccurrence.FormValue)) {
                    AccidentOccurrence.AddErrorMessage(ConvertToString(AccidentOccurrence.RequiredErrorMessage).Replace("%s", AccidentOccurrence.Caption));
                }
            }
            if (Dt_AccidentOccurrence.Required) {
                if (!Dt_AccidentOccurrence.IsDetailKey && Empty(Dt_AccidentOccurrence.FormValue)) {
                    Dt_AccidentOccurrence.AddErrorMessage(ConvertToString(Dt_AccidentOccurrence.RequiredErrorMessage).Replace("%s", Dt_AccidentOccurrence.Caption));
                }
            }
            if (AccidentNotes.Required) {
                if (!AccidentNotes.IsDetailKey && Empty(AccidentNotes.FormValue)) {
                    AccidentNotes.AddErrorMessage(ConvertToString(AccidentNotes.RequiredErrorMessage).Replace("%s", AccidentNotes.Caption));
                }
            }

            // Validate detail grid
            var detailTblVar = CurrentDetailTables;
            if (detailTblVar.Contains("tblEvaluation") && tblEvaluation?.DetailEdit == true) {
                tblEvaluationGrid = Resolve("TblEvaluationGrid")!; // Get detail page object
                if (tblEvaluationGrid != null)
                    validateForm = validateForm && await tblEvaluationGrid.ValidateGridForm();
            }
            if (detailTblVar.Contains("tblEvaluationMB") && tblEvaluationMb?.DetailEdit == true) {
                tblEvaluationMbGrid = Resolve("TblEvaluationMbGrid")!; // Get detail page object
                if (tblEvaluationMbGrid != null)
                    validateForm = validateForm && await tblEvaluationMbGrid.ValidateGridForm();
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

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.SetDbValue(rsnew, str_Full_Name_Hdr.CurrentValue, str_Full_Name_Hdr.ReadOnly);

            // NationalID
            NationalID.SetDbValue(rsnew, NationalID.CurrentValue, NationalID.ReadOnly);

            // Assessment_Type
            Assessment_Type.SetDbValue(rsnew, Assessment_Type.CurrentValue, Assessment_Type.ReadOnly);

            // AssessmentDate
            AssessmentDate.SetDbValue(rsnew, ConvertToDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern), AssessmentDate.ReadOnly);

            // isAssessmentDone
            isAssessmentDone.SetDbValue(rsnew, isAssessmentDone.CurrentValue, isAssessmentDone.ReadOnly);

            // Assessment_Instructor
            Assessment_Instructor.SetDbValue(rsnew, Assessment_Instructor.CurrentValue, Assessment_Instructor.ReadOnly);

            // AccidentOccurrence
            AccidentOccurrence.SetDbValue(rsnew, ConvertToBool(AccidentOccurrence.CurrentValue), AccidentOccurrence.ReadOnly);

            // AccidentNotes
            AccidentNotes.SetDbValue(rsnew, AccidentNotes.CurrentValue, AccidentNotes.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

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
                    if (detailTblVar.Contains("tblEvaluation") && tblEvaluation?.DetailEdit == true && result) {
                        tblEvaluationGrid = Resolve("TblEvaluationGrid")!; // Get detail page object
                        if (tblEvaluationGrid != null) {
                            Security.LoadCurrentUserLevel(ProjectID + "tblEvaluation"); // Load user level of detail table
                            result = await tblEvaluationGrid.GridUpdate();
                            Security.LoadCurrentUserLevel(ProjectID + TableName); // Restore user level of master table
                        }
                    }
                    if (detailTblVar.Contains("tblEvaluationMB") && tblEvaluationMb?.DetailEdit == true && result) {
                        tblEvaluationMbGrid = Resolve("TblEvaluationMbGrid")!; // Get detail page object
                        if (tblEvaluationMbGrid != null) {
                            Security.LoadCurrentUserLevel(ProjectID + "tblEvaluationMB"); // Load user level of detail table
                            result = await tblEvaluationMbGrid.GridUpdate();
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
                if (masterTblVar == "tblStudents") {
                    validMaster = true;
                    if (tblStudents != null && (Get("fk_str_Username", out fk) || Get("str_Username", out fk))) {
                        tblStudents.str_Username.QueryValue = fk;
                        str_Username.QueryValue = tblStudents.str_Username.QueryValue;
                        str_Username.SessionValue = str_Username.QueryValue;
                        foreignKeys.Add("str_Username", fk);
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
                if (masterTblVar == "tblStudents") {
                    validMaster = true;
                    if (tblStudents != null && (Post("fk_str_Username", out fk) || Post("str_Username", out fk))) {
                        tblStudents.str_Username.FormValue = fk;
                        str_Username.FormValue = tblStudents.str_Username.FormValue;
                        str_Username.SessionValue = str_Username.FormValue;
                        foreignKeys.Add("str_Username", fk);
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
                if (masterTblVar != "tblStudents") {
                    if (!foreignKeys.ContainsKey("str_Username")) // Not current foreign key
                        str_Username.SessionValue = "";
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
                if (detailTblVars.Contains("tblEvaluation")) {
                    tblEvaluationGrid = Resolve("TblEvaluationGrid")!;
                    if (tblEvaluationGrid?.DetailEdit ?? false) {
                        tblEvaluationGrid.CurrentMode = "edit";
                        tblEvaluationGrid.CurrentAction = "gridedit";

                        // Save current master table to detail table
                        tblEvaluationGrid.CurrentMasterTable = TableVar;
                        tblEvaluationGrid.StartRecordNumber = 1;
                        tblEvaluationGrid.AssessmentID.IsDetailKey = true;
                        tblEvaluationGrid.AssessmentID.CurrentValue = AssessmentID.CurrentValue;
                        tblEvaluationGrid.AssessmentID.SessionValue = tblEvaluationGrid.AssessmentID.CurrentValue;
                    }
                }
                if (detailTblVars.Contains("tblEvaluationMB")) {
                    tblEvaluationMbGrid = Resolve("TblEvaluationMbGrid")!;
                    if (tblEvaluationMbGrid?.DetailEdit ?? false) {
                        tblEvaluationMbGrid.CurrentMode = "edit";
                        tblEvaluationMbGrid.CurrentAction = "gridedit";

                        // Save current master table to detail table
                        tblEvaluationMbGrid.CurrentMasterTable = TableVar;
                        tblEvaluationMbGrid.StartRecordNumber = 1;
                        tblEvaluationMbGrid.AssessmentID.IsDetailKey = true;
                        tblEvaluationMbGrid.AssessmentID.CurrentValue = AssessmentID.CurrentValue;
                        tblEvaluationMbGrid.AssessmentID.SessionValue = tblEvaluationMbGrid.AssessmentID.CurrentValue;
                    }
                }
            }
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblAssessmentList")), "", TableVar, true);
            string pageId = "edit";
            breadcrumb.Add("edit", pageId, url);
            CurrentBreadcrumb = breadcrumb;
        }

        // Set up multi pages
        protected void SetupMultiPages() {
            var pages = new SubPages();
            pages.Style = "pills";
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
                // Set up lookup SQL
                switch (fld.FieldVar) {
                    case "x_str_Full_Name_Hdr":
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
