namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStaffEdit
    /// </summary>
    public static TblStaffEdit tblStaffEdit
    {
        get => HttpData.Get<TblStaffEdit>("tblStaffEdit")!;
        set => HttpData["tblStaffEdit"] = value;
    }

    /// <summary>
    /// Page class for tblStaff
    /// </summary>
    public class TblStaffEdit : TblStaffEditBase
    {
        // Constructor
        public TblStaffEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblStaffEdit() : base()
        {
        }

        // Page Data Rendering event
        public override void PageDataRendering(ref string header) {
        header = ("<p class=MsoNormal align=right style='text-align:right'><b><span style='font-size:12.0pt;line-height:106%;font-family:Segoe UI,sans-serif;color:#243F92'>Current User: "  + CurrentUserName() + "</span></b></p>");
        }
        // Page Data Rendered event
        public override void PageDataRendered(ref string footer) {
        	footer = $"<p class='text-start'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{GetCurrentUserLevelName()}</span></p>";
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblStaffEditBase : TblStaff
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblStaff";

        // Page object name
        public string PageObjName = "tblStaffEdit";

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
        public TblStaffEditBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblStaff)
            if (tblStaff == null || tblStaff is TblStaff)
                tblStaff = this;

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
        public string PageName => "TblStaffEdit";

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
            int_Staff_Id.Visible = false;
            str_Full_Name.Visible = false;
            str_First_Name.SetVisibility();
            str_Middle_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Username.Visible = false;
            str_Password.SetVisibility();
            NationalID.SetVisibility();
            str_NationalID_Iqama.SetVisibility();
            str_Address.SetVisibility();
            str_City.SetVisibility();
            int_State.SetVisibility();
            str_Zip.SetVisibility();
            str_Home_Phone.SetVisibility();
            str_Cell_Phone.SetVisibility();
            str_Email.SetVisibility();
            date_Birth.Visible = false;
            date_Birth_Hijri.Visible = false;
            int_Location.Visible = false;
            str_InstLicenceDate.Visible = false;
            str_DLNum.Visible = false;
            str_DLExp.Visible = false;
            User_Role.SetVisibility();
            UserlevelID.SetVisibility();
            Activated.SetVisibility();
            Supervisor_Username.SetVisibility();
            str_Staff_Username.SetVisibility();
            Hijri_Year.SetVisibility();
            Hijri_Month.SetVisibility();
            Hijri_Day.SetVisibility();
            int_Nationality.SetVisibility();
            date_Created.Visible = false;
            date_Modified.SetVisibility();
            int_Created_By.Visible = false;
            int_Modified_By.SetVisibility();
            str_Emergency_Contact_Name.SetVisibility();
            str_Emergency_Contact_Phone.SetVisibility();
            str_Emergency_Contact_Relation.SetVisibility();
            ProfileField.Visible = false;
            Absherphoto.SetVisibility();
            AbsherApptNbr.Visible = false;
        }

        // Constructor
        public TblStaffEditBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblStaffView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Staff_Id") ? dict["int_Staff_Id"] : int_Staff_Id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Staff_Id.Visible = false;
            if (IsAddOrEdit)
                str_Full_Name.Visible = false;
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
            await SetupLookupOptions(str_City);
            await SetupLookupOptions(int_State);
            await SetupLookupOptions(UserlevelID);
            await SetupLookupOptions(Activated);
            await SetupLookupOptions(Supervisor_Username);
            await SetupLookupOptions(Hijri_Year);
            await SetupLookupOptions(Hijri_Month);
            await SetupLookupOptions(Hijri_Day);
            await SetupLookupOptions(int_Nationality);
            await SetupLookupOptions(str_Emergency_Contact_Relation);

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
                if (RouteValues.TryGetValue("int_Staff_Id", out rv)) { // DN
                    int_Staff_Id.FormValue = UrlDecode(rv); // DN
                    int_Staff_Id.OldValue = int_Staff_Id.FormValue;
                } else if (CurrentForm.HasValue("x_int_Staff_Id")) {
                    int_Staff_Id.FormValue = CurrentForm.GetValue("x_int_Staff_Id");
                    int_Staff_Id.OldValue = int_Staff_Id.FormValue;
                } else if (!Empty(keyValues)) {
                    int_Staff_Id.OldValue = ConvertToString(keyValues[0]);
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
                    if (RouteValues.TryGetValue("int_Staff_Id", out rv)) { // DN
                        int_Staff_Id.QueryValue = UrlDecode(rv); // DN
                        loadByQuery = true;
                    } else if (Get("int_Staff_Id", out sv)) {
                        int_Staff_Id.QueryValue = sv.ToString();
                        loadByQuery = true;
                    } else {
                        int_Staff_Id.CurrentValue = DbNullValue;
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
                int_Staff_Id.FormValue = ConvertToString(keyValues[0]);
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
                            return Terminate("TblStaffList"); // No matching record, return to list
                        }
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = ViewUrl;
                    if (GetPageName(returnUrl) == "TblStaffList")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblStaffList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblStaffList"; // Return list page content
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
                tblStaffEdit?.PageRender();
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

            // Check field name 'str_First_Name' before field var 'x_str_First_Name'
            val = CurrentForm.HasValue("str_First_Name") ? CurrentForm.GetValue("str_First_Name") : CurrentForm.GetValue("x_str_First_Name");
            if (!str_First_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_First_Name") && !CurrentForm.HasValue("x_str_First_Name")) // DN
                    str_First_Name.Visible = false; // Disable update for API request
                else
                    str_First_Name.SetFormValue(val);
            }

            // Check field name 'str_Middle_Name' before field var 'x_str_Middle_Name'
            val = CurrentForm.HasValue("str_Middle_Name") ? CurrentForm.GetValue("str_Middle_Name") : CurrentForm.GetValue("x_str_Middle_Name");
            if (!str_Middle_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Middle_Name") && !CurrentForm.HasValue("x_str_Middle_Name")) // DN
                    str_Middle_Name.Visible = false; // Disable update for API request
                else
                    str_Middle_Name.SetFormValue(val);
            }

            // Check field name 'str_Last_Name' before field var 'x_str_Last_Name'
            val = CurrentForm.HasValue("str_Last_Name") ? CurrentForm.GetValue("str_Last_Name") : CurrentForm.GetValue("x_str_Last_Name");
            if (!str_Last_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Last_Name") && !CurrentForm.HasValue("x_str_Last_Name")) // DN
                    str_Last_Name.Visible = false; // Disable update for API request
                else
                    str_Last_Name.SetFormValue(val);
            }

            // Check field name 'str_Password' before field var 'x_str_Password'
            val = CurrentForm.HasValue("str_Password") ? CurrentForm.GetValue("str_Password") : CurrentForm.GetValue("x_str_Password");
            if (!str_Password.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Password") && !CurrentForm.HasValue("x_str_Password")) // DN
                    str_Password.Visible = false; // Disable update for API request
                else
                    str_Password.SetFormValue(val);
            }

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val, true, validate);
            }

            // Check field name 'str_NationalID_Iqama' before field var 'x_str_NationalID_Iqama'
            val = CurrentForm.HasValue("str_NationalID_Iqama") ? CurrentForm.GetValue("str_NationalID_Iqama") : CurrentForm.GetValue("x_str_NationalID_Iqama");
            if (!str_NationalID_Iqama.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_NationalID_Iqama") && !CurrentForm.HasValue("x_str_NationalID_Iqama")) // DN
                    str_NationalID_Iqama.Visible = false; // Disable update for API request
                else
                    str_NationalID_Iqama.SetFormValue(val);
            }

            // Check field name 'str_Address' before field var 'x_str_Address'
            val = CurrentForm.HasValue("str_Address") ? CurrentForm.GetValue("str_Address") : CurrentForm.GetValue("x_str_Address");
            if (!str_Address.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Address") && !CurrentForm.HasValue("x_str_Address")) // DN
                    str_Address.Visible = false; // Disable update for API request
                else
                    str_Address.SetFormValue(val);
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
                    int_State.SetFormValue(val);
            }

            // Check field name 'str_Zip' before field var 'x_str_Zip'
            val = CurrentForm.HasValue("str_Zip") ? CurrentForm.GetValue("str_Zip") : CurrentForm.GetValue("x_str_Zip");
            if (!str_Zip.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Zip") && !CurrentForm.HasValue("x_str_Zip")) // DN
                    str_Zip.Visible = false; // Disable update for API request
                else
                    str_Zip.SetFormValue(val);
            }

            // Check field name 'str_Home_Phone' before field var 'x_str_Home_Phone'
            val = CurrentForm.HasValue("str_Home_Phone") ? CurrentForm.GetValue("str_Home_Phone") : CurrentForm.GetValue("x_str_Home_Phone");
            if (!str_Home_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Home_Phone") && !CurrentForm.HasValue("x_str_Home_Phone")) // DN
                    str_Home_Phone.Visible = false; // Disable update for API request
                else
                    str_Home_Phone.SetFormValue(val);
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
                    str_Email.SetFormValue(val, true, validate);
            }

            // Check field name 'User_Role' before field var 'x_User_Role'
            val = CurrentForm.HasValue("User_Role") ? CurrentForm.GetValue("User_Role") : CurrentForm.GetValue("x_User_Role");
            if (!User_Role.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("User_Role") && !CurrentForm.HasValue("x_User_Role")) // DN
                    User_Role.Visible = false; // Disable update for API request
                else
                    User_Role.SetFormValue(val);
            }

            // Check field name 'UserlevelID' before field var 'x_UserlevelID'
            val = CurrentForm.HasValue("UserlevelID") ? CurrentForm.GetValue("UserlevelID") : CurrentForm.GetValue("x_UserlevelID");
            if (!UserlevelID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("UserlevelID") && !CurrentForm.HasValue("x_UserlevelID")) // DN
                    UserlevelID.Visible = false; // Disable update for API request
                else
                    UserlevelID.SetFormValue(val);
            }

            // Check field name 'Activated' before field var 'x_Activated'
            val = CurrentForm.HasValue("Activated") ? CurrentForm.GetValue("Activated") : CurrentForm.GetValue("x_Activated");
            if (!Activated.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Activated") && !CurrentForm.HasValue("x_Activated")) // DN
                    Activated.Visible = false; // Disable update for API request
                else
                    Activated.SetFormValue(val);
            }

            // Check field name 'Supervisor_Username' before field var 'x_Supervisor_Username'
            val = CurrentForm.HasValue("Supervisor_Username") ? CurrentForm.GetValue("Supervisor_Username") : CurrentForm.GetValue("x_Supervisor_Username");
            if (!Supervisor_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Supervisor_Username") && !CurrentForm.HasValue("x_Supervisor_Username")) // DN
                    Supervisor_Username.Visible = false; // Disable update for API request
                else
                    Supervisor_Username.SetFormValue(val);
            }

            // Check field name 'str_Staff_Username' before field var 'x_str_Staff_Username'
            val = CurrentForm.HasValue("str_Staff_Username") ? CurrentForm.GetValue("str_Staff_Username") : CurrentForm.GetValue("x_str_Staff_Username");
            if (!str_Staff_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Staff_Username") && !CurrentForm.HasValue("x_str_Staff_Username")) // DN
                    str_Staff_Username.Visible = false; // Disable update for API request
                else
                    str_Staff_Username.SetFormValue(val);
            }

            // Check field name 'Hijri_Year' before field var 'x_Hijri_Year'
            val = CurrentForm.HasValue("Hijri_Year") ? CurrentForm.GetValue("Hijri_Year") : CurrentForm.GetValue("x_Hijri_Year");
            if (!Hijri_Year.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Year") && !CurrentForm.HasValue("x_Hijri_Year")) // DN
                    Hijri_Year.Visible = false; // Disable update for API request
                else
                    Hijri_Year.SetFormValue(val);
            }

            // Check field name 'Hijri_Month' before field var 'x_Hijri_Month'
            val = CurrentForm.HasValue("Hijri_Month") ? CurrentForm.GetValue("Hijri_Month") : CurrentForm.GetValue("x_Hijri_Month");
            if (!Hijri_Month.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Month") && !CurrentForm.HasValue("x_Hijri_Month")) // DN
                    Hijri_Month.Visible = false; // Disable update for API request
                else
                    Hijri_Month.SetFormValue(val);
            }

            // Check field name 'Hijri_Day' before field var 'x_Hijri_Day'
            val = CurrentForm.HasValue("Hijri_Day") ? CurrentForm.GetValue("Hijri_Day") : CurrentForm.GetValue("x_Hijri_Day");
            if (!Hijri_Day.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Day") && !CurrentForm.HasValue("x_Hijri_Day")) // DN
                    Hijri_Day.Visible = false; // Disable update for API request
                else
                    Hijri_Day.SetFormValue(val);
            }

            // Check field name 'int_Nationality' before field var 'x_int_Nationality'
            val = CurrentForm.HasValue("int_Nationality") ? CurrentForm.GetValue("int_Nationality") : CurrentForm.GetValue("x_int_Nationality");
            if (!int_Nationality.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Nationality") && !CurrentForm.HasValue("x_int_Nationality")) // DN
                    int_Nationality.Visible = false; // Disable update for API request
                else
                    int_Nationality.SetFormValue(val);
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

            // Check field name 'int_Modified_By' before field var 'x_int_Modified_By'
            val = CurrentForm.HasValue("int_Modified_By") ? CurrentForm.GetValue("int_Modified_By") : CurrentForm.GetValue("x_int_Modified_By");
            if (!int_Modified_By.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Modified_By") && !CurrentForm.HasValue("x_int_Modified_By")) // DN
                    int_Modified_By.Visible = false; // Disable update for API request
                else
                    int_Modified_By.SetFormValue(val);
            }

            // Check field name 'str_Emergency_Contact_Name' before field var 'x_str_Emergency_Contact_Name'
            val = CurrentForm.HasValue("str_Emergency_Contact_Name") ? CurrentForm.GetValue("str_Emergency_Contact_Name") : CurrentForm.GetValue("x_str_Emergency_Contact_Name");
            if (!str_Emergency_Contact_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Name") && !CurrentForm.HasValue("x_str_Emergency_Contact_Name")) // DN
                    str_Emergency_Contact_Name.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Name.SetFormValue(val);
            }

            // Check field name 'str_Emergency_Contact_Phone' before field var 'x_str_Emergency_Contact_Phone'
            val = CurrentForm.HasValue("str_Emergency_Contact_Phone") ? CurrentForm.GetValue("str_Emergency_Contact_Phone") : CurrentForm.GetValue("x_str_Emergency_Contact_Phone");
            if (!str_Emergency_Contact_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Phone") && !CurrentForm.HasValue("x_str_Emergency_Contact_Phone")) // DN
                    str_Emergency_Contact_Phone.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Phone.SetFormValue(val);
            }

            // Check field name 'str_Emergency_Contact_Relation' before field var 'x_str_Emergency_Contact_Relation'
            val = CurrentForm.HasValue("str_Emergency_Contact_Relation") ? CurrentForm.GetValue("str_Emergency_Contact_Relation") : CurrentForm.GetValue("x_str_Emergency_Contact_Relation");
            if (!str_Emergency_Contact_Relation.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Relation") && !CurrentForm.HasValue("x_str_Emergency_Contact_Relation")) // DN
                    str_Emergency_Contact_Relation.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Relation.SetFormValue(val);
            }

            // Check field name 'int_Staff_Id' before field var 'x_int_Staff_Id'
            val = CurrentForm.HasValue("int_Staff_Id") ? CurrentForm.GetValue("int_Staff_Id") : CurrentForm.GetValue("x_int_Staff_Id");
            if (!int_Staff_Id.IsDetailKey)
                int_Staff_Id.SetFormValue(val);
            await GetUploadFiles(); // Get upload files
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Staff_Id.CurrentValue = int_Staff_Id.FormValue;
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Middle_Name.CurrentValue = str_Middle_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            str_Password.CurrentValue = str_Password.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            str_NationalID_Iqama.CurrentValue = str_NationalID_Iqama.FormValue;
            str_Address.CurrentValue = str_Address.FormValue;
            str_City.CurrentValue = str_City.FormValue;
            int_State.CurrentValue = int_State.FormValue;
            str_Zip.CurrentValue = str_Zip.FormValue;
            str_Home_Phone.CurrentValue = str_Home_Phone.FormValue;
            str_Cell_Phone.CurrentValue = str_Cell_Phone.FormValue;
            str_Email.CurrentValue = str_Email.FormValue;
            User_Role.CurrentValue = User_Role.FormValue;
            UserlevelID.CurrentValue = UserlevelID.FormValue;
            Activated.CurrentValue = Activated.FormValue;
            Supervisor_Username.CurrentValue = Supervisor_Username.FormValue;
            str_Staff_Username.CurrentValue = str_Staff_Username.FormValue;
            Hijri_Year.CurrentValue = Hijri_Year.FormValue;
            Hijri_Month.CurrentValue = Hijri_Month.FormValue;
            Hijri_Day.CurrentValue = Hijri_Day.FormValue;
            int_Nationality.CurrentValue = int_Nationality.FormValue;
            date_Modified.CurrentValue = date_Modified.FormValue;
            date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            int_Modified_By.CurrentValue = int_Modified_By.FormValue;
            str_Emergency_Contact_Name.CurrentValue = str_Emergency_Contact_Name.FormValue;
            str_Emergency_Contact_Phone.CurrentValue = str_Emergency_Contact_Phone.FormValue;
            str_Emergency_Contact_Relation.CurrentValue = str_Emergency_Contact_Relation.FormValue;
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
            int_Staff_Id.SetDbValue(row["int_Staff_Id"]);
            str_Full_Name.SetDbValue(row["str_Full_Name"]);
            str_First_Name.SetDbValue(row["str_First_Name"]);
            str_Middle_Name.SetDbValue(row["str_Middle_Name"]);
            str_Last_Name.SetDbValue(row["str_Last_Name"]);
            str_Username.SetDbValue(row["str_Username"]);
            str_Password.SetDbValue(row["str_Password"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_NationalID_Iqama.SetDbValue(row["str_NationalID_Iqama"]);
            str_Address.SetDbValue(row["str_Address"]);
            str_City.SetDbValue(row["str_City"]);
            int_State.SetDbValue(row["int_State"]);
            str_Zip.SetDbValue(row["str_Zip"]);
            str_Home_Phone.SetDbValue(row["str_Home_Phone"]);
            str_Cell_Phone.SetDbValue(row["str_Cell_Phone"]);
            str_Email.SetDbValue(row["str_Email"]);
            date_Birth.SetDbValue(row["date_Birth"]);
            date_Birth_Hijri.SetDbValue(row["date_Birth_Hijri"]);
            int_Location.SetDbValue(row["int_Location"]);
            str_InstLicenceDate.SetDbValue(row["str_InstLicenceDate"]);
            str_DLNum.SetDbValue(row["str_DLNum"]);
            str_DLExp.SetDbValue(row["str_DLExp"]);
            User_Role.SetDbValue(row["User_Role"]);
            UserlevelID.SetDbValue(row["UserlevelID"]);
            Activated.SetDbValue((ConvertToBool(row["Activated"]) ? "1" : "0"));
            Supervisor_Username.SetDbValue(row["Supervisor_Username"]);
            str_Staff_Username.SetDbValue(row["str_Staff_Username"]);
            Hijri_Year.SetDbValue(row["Hijri_Year"]);
            Hijri_Month.SetDbValue(row["Hijri_Month"]);
            Hijri_Day.SetDbValue(row["Hijri_Day"]);
            int_Nationality.SetDbValue(row["int_Nationality"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            str_Emergency_Contact_Name.SetDbValue(row["str_Emergency_Contact_Name"]);
            str_Emergency_Contact_Phone.SetDbValue(row["str_Emergency_Contact_Phone"]);
            str_Emergency_Contact_Relation.SetDbValue(row["str_Emergency_Contact_Relation"]);
            ProfileField.SetDbValue(row["ProfileField"]);
            Absherphoto.Upload.DbValue = row["Absherphoto"];
            Absherphoto.SetDbValue(Absherphoto.Upload.DbValue);
            AbsherApptNbr.SetDbValue(row["AbsherApptNbr"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Staff_Id", int_Staff_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Full_Name", str_Full_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_First_Name", str_First_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Middle_Name", str_Middle_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last_Name", str_Last_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Password", str_Password.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_NationalID_Iqama", str_NationalID_Iqama.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Address", str_Address.DefaultValue ?? DbNullValue); // DN
            row.Add("str_City", str_City.DefaultValue ?? DbNullValue); // DN
            row.Add("int_State", int_State.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Zip", str_Zip.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Home_Phone", str_Home_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Cell_Phone", str_Cell_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email", str_Email.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth", date_Birth.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth_Hijri", date_Birth_Hijri.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location", int_Location.DefaultValue ?? DbNullValue); // DN
            row.Add("str_InstLicenceDate", str_InstLicenceDate.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DLNum", str_DLNum.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DLExp", str_DLExp.DefaultValue ?? DbNullValue); // DN
            row.Add("User_Role", User_Role.DefaultValue ?? DbNullValue); // DN
            row.Add("UserlevelID", UserlevelID.DefaultValue ?? DbNullValue); // DN
            row.Add("Activated", Activated.DefaultValue ?? DbNullValue); // DN
            row.Add("Supervisor_Username", Supervisor_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Staff_Username", str_Staff_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Year", Hijri_Year.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Month", Hijri_Month.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Day", Hijri_Day.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Nationality", int_Nationality.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Name", str_Emergency_Contact_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Phone", str_Emergency_Contact_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Relation", str_Emergency_Contact_Relation.DefaultValue ?? DbNullValue); // DN
            row.Add("ProfileField", ProfileField.DefaultValue ?? DbNullValue); // DN
            row.Add("Absherphoto", Absherphoto.DefaultValue ?? DbNullValue); // DN
            row.Add("AbsherApptNbr", AbsherApptNbr.DefaultValue ?? DbNullValue); // DN
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

            // int_Staff_Id
            int_Staff_Id.RowCssClass = "row";

            // str_Full_Name
            str_Full_Name.RowCssClass = "row";

            // str_First_Name
            str_First_Name.RowCssClass = "row";

            // str_Middle_Name
            str_Middle_Name.RowCssClass = "row";

            // str_Last_Name
            str_Last_Name.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // str_Password
            str_Password.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // str_NationalID_Iqama
            str_NationalID_Iqama.RowCssClass = "row";

            // str_Address
            str_Address.RowCssClass = "row";

            // str_City
            str_City.RowCssClass = "row";

            // int_State
            int_State.RowCssClass = "row";

            // str_Zip
            str_Zip.RowCssClass = "row";

            // str_Home_Phone
            str_Home_Phone.RowCssClass = "row";

            // str_Cell_Phone
            str_Cell_Phone.RowCssClass = "row";

            // str_Email
            str_Email.RowCssClass = "row";

            // date_Birth
            date_Birth.RowCssClass = "row";

            // date_Birth_Hijri
            date_Birth_Hijri.RowCssClass = "row";

            // int_Location
            int_Location.RowCssClass = "row";

            // str_InstLicenceDate
            str_InstLicenceDate.RowCssClass = "row";

            // str_DLNum
            str_DLNum.RowCssClass = "row";

            // str_DLExp
            str_DLExp.RowCssClass = "row";

            // User_Role
            User_Role.RowCssClass = "row";

            // UserlevelID
            UserlevelID.RowCssClass = "row";

            // Activated
            Activated.RowCssClass = "row";

            // Supervisor_Username
            Supervisor_Username.RowCssClass = "row";

            // str_Staff_Username
            str_Staff_Username.RowCssClass = "row";

            // Hijri_Year
            Hijri_Year.RowCssClass = "row";

            // Hijri_Month
            Hijri_Month.RowCssClass = "row";

            // Hijri_Day
            Hijri_Day.RowCssClass = "row";

            // int_Nationality
            int_Nationality.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.RowCssClass = "row";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.RowCssClass = "row";

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.RowCssClass = "row";

            // ProfileField
            ProfileField.RowCssClass = "row";

            // Absherphoto
            Absherphoto.RowCssClass = "row";

            // AbsherApptNbr
            AbsherApptNbr.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // int_Staff_Id
                int_Staff_Id.ViewValue = int_Staff_Id.CurrentValue;
                int_Staff_Id.ViewValue = FormatNumber(int_Staff_Id.ViewValue, int_Staff_Id.FormatPattern);
                int_Staff_Id.ViewCustomAttributes = "";

                // str_Full_Name
                str_Full_Name.ViewValue = ConvertToString(str_Full_Name.CurrentValue); // DN
                str_Full_Name.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Middle_Name
                str_Middle_Name.ViewValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
                str_Middle_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = str_Username.CurrentValue;
                str_Username.ViewCustomAttributes = "";

                // str_Password
                str_Password.ViewValue = ConvertToString(str_Password.CurrentValue); // DN
                str_Password.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
                NationalID.ViewCustomAttributes = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.ViewValue = ConvertToString(str_NationalID_Iqama.CurrentValue); // DN
                str_NationalID_Iqama.ViewCustomAttributes = "";

                // str_Address
                str_Address.ViewValue = ConvertToString(str_Address.CurrentValue); // DN
                str_Address.ViewCustomAttributes = "";

                // str_City
                curVal = ConvertToString(str_City.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_City.Lookup != null && IsDictionary(str_City.Lookup?.Options) && str_City.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_City.ViewValue = str_City.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[City]", "=", str_City.CurrentValue, DataType.String, "");
                        sqlWrk = str_City.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_City.Lookup != null) { // Lookup values found
                            var listwrk = str_City.Lookup?.RenderViewRow(rswrk[0]);
                            str_City.ViewValue = str_City.HighlightLookup(ConvertToString(rswrk[0]), str_City.DisplayValue(listwrk));
                        } else {
                            str_City.ViewValue = str_City.CurrentValue;
                        }
                    }
                } else {
                    str_City.ViewValue = DbNullValue;
                }
                str_City.ViewCustomAttributes = "";

                // int_State
                curVal = ConvertToString(int_State.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_State.Lookup != null && IsDictionary(int_State.Lookup?.Options) && int_State.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_State.ViewValue = int_State.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Province_ID]", "=", int_State.CurrentValue, DataType.Number, "");
                        sqlWrk = int_State.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_State.Lookup != null) { // Lookup values found
                            var listwrk = int_State.Lookup?.RenderViewRow(rswrk[0]);
                            int_State.ViewValue = int_State.HighlightLookup(ConvertToString(rswrk[0]), int_State.DisplayValue(listwrk));
                        } else {
                            int_State.ViewValue = FormatNumber(int_State.CurrentValue, int_State.FormatPattern);
                        }
                    }
                } else {
                    int_State.ViewValue = DbNullValue;
                }
                int_State.ViewCustomAttributes = "";

                // str_Zip
                str_Zip.ViewValue = ConvertToString(str_Zip.CurrentValue); // DN
                str_Zip.ViewCustomAttributes = "";

                // str_Home_Phone
                str_Home_Phone.ViewValue = ConvertToString(str_Home_Phone.CurrentValue); // DN
                str_Home_Phone.ViewCustomAttributes = "";

                // str_Cell_Phone
                str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
                str_Cell_Phone.ViewCustomAttributes = "";

                // str_Email
                str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
                str_Email.ViewCustomAttributes = "";

                // date_Birth
                date_Birth.ViewValue = date_Birth.CurrentValue;
                date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
                date_Birth.ViewCustomAttributes = "";

                // date_Birth_Hijri
                date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // int_Location
                int_Location.ViewValue = int_Location.CurrentValue;
                int_Location.ViewValue = FormatNumber(int_Location.ViewValue, int_Location.FormatPattern);
                int_Location.ViewCustomAttributes = "";

                // str_InstLicenceDate
                str_InstLicenceDate.ViewValue = ConvertToString(str_InstLicenceDate.CurrentValue); // DN
                str_InstLicenceDate.ViewCustomAttributes = "";

                // str_DLNum
                str_DLNum.ViewValue = ConvertToString(str_DLNum.CurrentValue); // DN
                str_DLNum.ViewCustomAttributes = "";

                // str_DLExp
                str_DLExp.ViewValue = ConvertToString(str_DLExp.CurrentValue); // DN
                str_DLExp.ViewCustomAttributes = "";

                // User_Role
                User_Role.ViewValue = User_Role.CurrentValue;
                User_Role.ViewCustomAttributes = "";

                // UserlevelID
                curVal = ConvertToString(UserlevelID.CurrentValue);
                if (!Empty(curVal)) {
                    if (UserlevelID.Lookup != null && IsDictionary(UserlevelID.Lookup?.Options) && UserlevelID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        UserlevelID.ViewValue = UserlevelID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[UserLevelID]", "=", UserlevelID.CurrentValue, DataType.Number, "");
                        sqlWrk = UserlevelID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && UserlevelID.Lookup != null) { // Lookup values found
                            var listwrk = UserlevelID.Lookup?.RenderViewRow(rswrk[0]);
                            UserlevelID.ViewValue = UserlevelID.HighlightLookup(ConvertToString(rswrk[0]), UserlevelID.DisplayValue(listwrk));
                        } else {
                            UserlevelID.ViewValue = FormatNumber(UserlevelID.CurrentValue, UserlevelID.FormatPattern);
                        }
                    }
                } else {
                    UserlevelID.ViewValue = DbNullValue;
                }
                UserlevelID.ViewCustomAttributes = "";

                // Activated
                if (ConvertToBool(Activated.CurrentValue)) {
                    Activated.ViewValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
                } else {
                    Activated.ViewValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
                }
                Activated.ViewCustomAttributes = "";

                // Supervisor_Username
                curVal = ConvertToString(Supervisor_Username.CurrentValue);
                if (!Empty(curVal)) {
                    if (Supervisor_Username.Lookup != null && IsDictionary(Supervisor_Username.Lookup?.Options) && Supervisor_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Supervisor_Username.ViewValue = Supervisor_Username.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Staff_Username]", "=", Supervisor_Username.CurrentValue, DataType.String, "");
                        sqlWrk = Supervisor_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Supervisor_Username.Lookup != null) { // Lookup values found
                            var listwrk = Supervisor_Username.Lookup?.RenderViewRow(rswrk[0]);
                            Supervisor_Username.ViewValue = Supervisor_Username.HighlightLookup(ConvertToString(rswrk[0]), Supervisor_Username.DisplayValue(listwrk));
                        } else {
                            Supervisor_Username.ViewValue = Supervisor_Username.CurrentValue;
                        }
                    }
                } else {
                    Supervisor_Username.ViewValue = DbNullValue;
                }
                Supervisor_Username.ViewCustomAttributes = "";

                // str_Staff_Username
                str_Staff_Username.ViewValue = ConvertToString(str_Staff_Username.CurrentValue); // DN
                str_Staff_Username.ViewCustomAttributes = "";

                // Hijri_Year
                curVal = ConvertToString(Hijri_Year.CurrentValue);
                if (!Empty(curVal)) {
                    if (Hijri_Year.Lookup != null && IsDictionary(Hijri_Year.Lookup?.Options) && Hijri_Year.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Hijri_Year.ViewValue = Hijri_Year.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Hijri_Year]", "=", Hijri_Year.CurrentValue, DataType.Number, "");
                        sqlWrk = Hijri_Year.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Hijri_Year.Lookup != null) { // Lookup values found
                            var listwrk = Hijri_Year.Lookup?.RenderViewRow(rswrk[0]);
                            Hijri_Year.ViewValue = Hijri_Year.HighlightLookup(ConvertToString(rswrk[0]), Hijri_Year.DisplayValue(listwrk));
                        } else {
                            Hijri_Year.ViewValue = Hijri_Year.CurrentValue;
                        }
                    }
                } else {
                    Hijri_Year.ViewValue = DbNullValue;
                }
                Hijri_Year.ViewCustomAttributes = "";

                // Hijri_Month
                curVal = ConvertToString(Hijri_Month.CurrentValue);
                if (!Empty(curVal)) {
                    if (Hijri_Month.Lookup != null && IsDictionary(Hijri_Month.Lookup?.Options) && Hijri_Month.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Hijri_Month.ViewValue = Hijri_Month.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Hijri_Month]", "=", Hijri_Month.CurrentValue, DataType.Number, "");
                        lookupFilter = () => Hijri_Month.GetSelectFilter();
                        sqlWrk = Hijri_Month.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Hijri_Month.Lookup != null) { // Lookup values found
                            var listwrk = Hijri_Month.Lookup?.RenderViewRow(rswrk[0]);
                            Hijri_Month.ViewValue = Hijri_Month.HighlightLookup(ConvertToString(rswrk[0]), Hijri_Month.DisplayValue(listwrk));
                        } else {
                            Hijri_Month.ViewValue = FormatNumber(Hijri_Month.CurrentValue, Hijri_Month.FormatPattern);
                        }
                    }
                } else {
                    Hijri_Month.ViewValue = DbNullValue;
                }
                Hijri_Month.ViewCustomAttributes = "";

                // Hijri_Day
                curVal = ConvertToString(Hijri_Day.CurrentValue);
                if (!Empty(curVal)) {
                    if (Hijri_Day.Lookup != null && IsDictionary(Hijri_Day.Lookup?.Options) && Hijri_Day.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Hijri_Day.ViewValue = Hijri_Day.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Hijri_Day]", "=", Hijri_Day.CurrentValue, DataType.Number, "");
                        lookupFilter = () => Hijri_Day.GetSelectFilter();
                        sqlWrk = Hijri_Day.Lookup?.GetSql(false, filterWrk, lookupFilter, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Hijri_Day.Lookup != null) { // Lookup values found
                            var listwrk = Hijri_Day.Lookup?.RenderViewRow(rswrk[0]);
                            Hijri_Day.ViewValue = Hijri_Day.HighlightLookup(ConvertToString(rswrk[0]), Hijri_Day.DisplayValue(listwrk));
                        } else {
                            Hijri_Day.ViewValue = FormatNumber(Hijri_Day.CurrentValue, Hijri_Day.FormatPattern);
                        }
                    }
                } else {
                    Hijri_Day.ViewValue = DbNullValue;
                }
                Hijri_Day.ViewCustomAttributes = "";

                // int_Nationality
                curVal = ConvertToString(int_Nationality.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Nationality.Lookup != null && IsDictionary(int_Nationality.Lookup?.Options) && int_Nationality.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Nationality.ViewValue = int_Nationality.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[ID]", "=", int_Nationality.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Nationality.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Nationality.Lookup != null) { // Lookup values found
                            var listwrk = int_Nationality.Lookup?.RenderViewRow(rswrk[0]);
                            int_Nationality.ViewValue = int_Nationality.HighlightLookup(ConvertToString(rswrk[0]), int_Nationality.DisplayValue(listwrk));
                        } else {
                            int_Nationality.ViewValue = FormatNumber(int_Nationality.CurrentValue, int_Nationality.FormatPattern);
                        }
                    }
                } else {
                    int_Nationality.ViewValue = DbNullValue;
                }
                int_Nationality.ViewCustomAttributes = "";

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

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.ViewValue = ConvertToString(str_Emergency_Contact_Name.CurrentValue); // DN
                str_Emergency_Contact_Name.ViewCustomAttributes = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.ViewValue = ConvertToString(str_Emergency_Contact_Phone.CurrentValue); // DN
                str_Emergency_Contact_Phone.ViewCustomAttributes = "";

                // str_Emergency_Contact_Relation
                if (!Empty(str_Emergency_Contact_Relation.CurrentValue)) {
                    str_Emergency_Contact_Relation.ViewValue = str_Emergency_Contact_Relation.HighlightLookup(ConvertToString(str_Emergency_Contact_Relation.CurrentValue), str_Emergency_Contact_Relation.OptionCaption(ConvertToString(str_Emergency_Contact_Relation.CurrentValue)));
                } else {
                    str_Emergency_Contact_Relation.ViewValue = DbNullValue;
                }
                str_Emergency_Contact_Relation.ViewCustomAttributes = "";

                // Absherphoto
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.ViewValue = Absherphoto.Upload.DbValue;
                } else {
                    Absherphoto.ViewValue = "";
                }
                Absherphoto.ViewCustomAttributes = "";

                // AbsherApptNbr
                AbsherApptNbr.ViewValue = AbsherApptNbr.CurrentValue;
                AbsherApptNbr.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // str_Password
                str_Password.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";

                // str_Address
                str_Address.HrefValue = "";

                // str_City
                str_City.HrefValue = "";

                // int_State
                int_State.HrefValue = "";

                // str_Zip
                str_Zip.HrefValue = "";

                // str_Home_Phone
                str_Home_Phone.HrefValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";

                // str_Email
                str_Email.HrefValue = "";

                // User_Role
                User_Role.HrefValue = "";
                User_Role.TooltipValue = "";

                // UserlevelID
                UserlevelID.HrefValue = "";

                // Activated
                Activated.HrefValue = "";

                // Supervisor_Username
                Supervisor_Username.HrefValue = "";

                // str_Staff_Username
                str_Staff_Username.HrefValue = "";

                // Hijri_Year
                Hijri_Year.HrefValue = "";

                // Hijri_Month
                Hijri_Month.HrefValue = "";

                // Hijri_Day
                Hijri_Day.HrefValue = "";

                // int_Nationality
                int_Nationality.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";
                int_Modified_By.TooltipValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
            } else if (RowType == RowType.Edit) {
                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.CurrentValue = HtmlDecode(str_First_Name.CurrentValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.CurrentValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Middle_Name
                str_Middle_Name.SetupEditAttributes();
                if (!str_Middle_Name.Raw)
                    str_Middle_Name.CurrentValue = HtmlDecode(str_Middle_Name.CurrentValue);
                str_Middle_Name.EditValue = HtmlEncode(str_Middle_Name.CurrentValue);
                str_Middle_Name.PlaceHolder = RemoveHtml(str_Middle_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.CurrentValue = HtmlDecode(str_Last_Name.CurrentValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.CurrentValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Password
                str_Password.SetupEditAttributes();
                if (!str_Password.Raw)
                    str_Password.CurrentValue = HtmlDecode(str_Password.CurrentValue);
                str_Password.EditValue = HtmlEncode(str_Password.CurrentValue);
                str_Password.PlaceHolder = RemoveHtml(str_Password.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.CurrentValue; // DN
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

                // str_NationalID_Iqama
                str_NationalID_Iqama.SetupEditAttributes();
                if (!str_NationalID_Iqama.Raw)
                    str_NationalID_Iqama.CurrentValue = HtmlDecode(str_NationalID_Iqama.CurrentValue);
                str_NationalID_Iqama.EditValue = HtmlEncode(str_NationalID_Iqama.CurrentValue);
                str_NationalID_Iqama.PlaceHolder = RemoveHtml(str_NationalID_Iqama.Caption);

                // str_Address
                str_Address.SetupEditAttributes();
                if (!str_Address.Raw)
                    str_Address.CurrentValue = HtmlDecode(str_Address.CurrentValue);
                str_Address.EditValue = HtmlEncode(str_Address.CurrentValue);
                str_Address.PlaceHolder = RemoveHtml(str_Address.Caption);

                // str_City
                str_City.SetupEditAttributes();
                curVal = ConvertToString(str_City.CurrentValue)?.Trim() ?? "";
                if (str_City.Lookup != null && IsDictionary(str_City.Lookup?.Options) && str_City.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_City.EditValue = str_City.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[City]", "=", str_City.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = str_City.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_City.EditValue = rswrk;
                }
                str_City.PlaceHolder = RemoveHtml(str_City.Caption);

                // int_State
                int_State.SetupEditAttributes();
                curVal = ConvertToString(int_State.CurrentValue)?.Trim() ?? "";
                if (int_State.Lookup != null && IsDictionary(int_State.Lookup?.Options) && int_State.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_State.EditValue = int_State.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Province_ID]", "=", int_State.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_State.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_State.EditValue = rswrk;
                }
                int_State.PlaceHolder = RemoveHtml(int_State.Caption);
                if (!Empty(int_State.EditValue) && IsNumeric(int_State.EditValue))
                    int_State.EditValue = FormatNumber(int_State.EditValue, null);

                // str_Zip
                str_Zip.SetupEditAttributes();
                if (!str_Zip.Raw)
                    str_Zip.CurrentValue = HtmlDecode(str_Zip.CurrentValue);
                str_Zip.EditValue = HtmlEncode(str_Zip.CurrentValue);
                str_Zip.PlaceHolder = RemoveHtml(str_Zip.Caption);

                // str_Home_Phone
                str_Home_Phone.SetupEditAttributes();
                if (!str_Home_Phone.Raw)
                    str_Home_Phone.CurrentValue = HtmlDecode(str_Home_Phone.CurrentValue);
                str_Home_Phone.EditValue = HtmlEncode(str_Home_Phone.CurrentValue);
                str_Home_Phone.PlaceHolder = RemoveHtml(str_Home_Phone.Caption);

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.CurrentValue = HtmlDecode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

                // str_Email
                str_Email.SetupEditAttributes();
                if (!str_Email.Raw)
                    str_Email.CurrentValue = HtmlDecode(str_Email.CurrentValue);
                str_Email.EditValue = HtmlEncode(str_Email.CurrentValue);
                str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

                // User_Role
                User_Role.SetupEditAttributes();

                // UserlevelID
                UserlevelID.SetupEditAttributes();
                curVal = ConvertToString(UserlevelID.CurrentValue)?.Trim() ?? "";
                if (UserlevelID.Lookup != null && IsDictionary(UserlevelID.Lookup?.Options) && UserlevelID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    UserlevelID.EditValue = UserlevelID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[UserLevelID]", "=", UserlevelID.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = UserlevelID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    UserlevelID.EditValue = rswrk;
                }
                UserlevelID.PlaceHolder = RemoveHtml(UserlevelID.Caption);
                if (!Empty(UserlevelID.EditValue) && IsNumeric(UserlevelID.EditValue))
                    UserlevelID.EditValue = FormatNumber(UserlevelID.EditValue, null);

                // Activated
                Activated.EditValue = Activated.Options(false);
                Activated.PlaceHolder = RemoveHtml(Activated.Caption);

                // Supervisor_Username
                Supervisor_Username.SetupEditAttributes();
                curVal = ConvertToString(Supervisor_Username.CurrentValue)?.Trim() ?? "";
                if (Supervisor_Username.Lookup != null && IsDictionary(Supervisor_Username.Lookup?.Options) && Supervisor_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Supervisor_Username.EditValue = Supervisor_Username.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Staff_Username]", "=", Supervisor_Username.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = Supervisor_Username.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    Supervisor_Username.EditValue = rswrk;
                }
                Supervisor_Username.PlaceHolder = RemoveHtml(Supervisor_Username.Caption);

                // str_Staff_Username
                str_Staff_Username.SetupEditAttributes();
                if (!str_Staff_Username.Raw)
                    str_Staff_Username.CurrentValue = HtmlDecode(str_Staff_Username.CurrentValue);
                str_Staff_Username.EditValue = HtmlEncode(str_Staff_Username.CurrentValue);
                str_Staff_Username.PlaceHolder = RemoveHtml(str_Staff_Username.Caption);

                // Hijri_Year
                Hijri_Year.SetupEditAttributes();
                curVal = ConvertToString(Hijri_Year.CurrentValue)?.Trim() ?? "";
                if (Hijri_Year.Lookup != null && IsDictionary(Hijri_Year.Lookup?.Options) && Hijri_Year.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Hijri_Year.EditValue = Hijri_Year.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Hijri_Year]", "=", Hijri_Year.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = Hijri_Year.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    Hijri_Year.EditValue = rswrk;
                }
                Hijri_Year.PlaceHolder = RemoveHtml(Hijri_Year.Caption);

                // Hijri_Month
                Hijri_Month.SetupEditAttributes();
                curVal = ConvertToString(Hijri_Month.CurrentValue)?.Trim() ?? "";
                if (Hijri_Month.Lookup != null && IsDictionary(Hijri_Month.Lookup?.Options) && Hijri_Month.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Hijri_Month.EditValue = Hijri_Month.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Hijri_Month]", "=", Hijri_Month.CurrentValue, DataType.Number, "");
                    }
                    lookupFilter = () => Hijri_Month.GetSelectFilter();
                    sqlWrk = Hijri_Month.Lookup?.GetSql(true, filterWrk, lookupFilter, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    Hijri_Month.EditValue = rswrk;
                }
                Hijri_Month.PlaceHolder = RemoveHtml(Hijri_Month.Caption);
                if (!Empty(Hijri_Month.EditValue) && IsNumeric(Hijri_Month.EditValue))
                    Hijri_Month.EditValue = FormatNumber(Hijri_Month.EditValue, null);

                // Hijri_Day
                Hijri_Day.SetupEditAttributes();
                curVal = ConvertToString(Hijri_Day.CurrentValue)?.Trim() ?? "";
                if (Hijri_Day.Lookup != null && IsDictionary(Hijri_Day.Lookup?.Options) && Hijri_Day.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Hijri_Day.EditValue = Hijri_Day.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Hijri_Day]", "=", Hijri_Day.CurrentValue, DataType.Number, "");
                    }
                    lookupFilter = () => Hijri_Day.GetSelectFilter();
                    sqlWrk = Hijri_Day.Lookup?.GetSql(true, filterWrk, lookupFilter, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    Hijri_Day.EditValue = rswrk;
                }
                Hijri_Day.PlaceHolder = RemoveHtml(Hijri_Day.Caption);
                if (!Empty(Hijri_Day.EditValue) && IsNumeric(Hijri_Day.EditValue))
                    Hijri_Day.EditValue = FormatNumber(Hijri_Day.EditValue, null);

                // int_Nationality
                int_Nationality.SetupEditAttributes();
                curVal = ConvertToString(int_Nationality.CurrentValue)?.Trim() ?? "";
                if (int_Nationality.Lookup != null && IsDictionary(int_Nationality.Lookup?.Options) && int_Nationality.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Nationality.EditValue = int_Nationality.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[ID]", "=", int_Nationality.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_Nationality.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Nationality.EditValue = rswrk;
                }
                int_Nationality.PlaceHolder = RemoveHtml(int_Nationality.Caption);
                if (!Empty(int_Nationality.EditValue) && IsNumeric(int_Nationality.EditValue))
                    int_Nationality.EditValue = FormatNumber(int_Nationality.EditValue, null);

                // date_Modified

                // int_Modified_By

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.SetupEditAttributes();
                if (!str_Emergency_Contact_Name.Raw)
                    str_Emergency_Contact_Name.CurrentValue = HtmlDecode(str_Emergency_Contact_Name.CurrentValue);
                str_Emergency_Contact_Name.EditValue = HtmlEncode(str_Emergency_Contact_Name.CurrentValue);
                str_Emergency_Contact_Name.PlaceHolder = RemoveHtml(str_Emergency_Contact_Name.Caption);

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.SetupEditAttributes();
                if (!str_Emergency_Contact_Phone.Raw)
                    str_Emergency_Contact_Phone.CurrentValue = HtmlDecode(str_Emergency_Contact_Phone.CurrentValue);
                str_Emergency_Contact_Phone.EditValue = HtmlEncode(str_Emergency_Contact_Phone.CurrentValue);
                str_Emergency_Contact_Phone.PlaceHolder = RemoveHtml(str_Emergency_Contact_Phone.Caption);

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.SetupEditAttributes();
                str_Emergency_Contact_Relation.EditValue = str_Emergency_Contact_Relation.Options(true);
                str_Emergency_Contact_Relation.PlaceHolder = RemoveHtml(str_Emergency_Contact_Relation.Caption);

                // Absherphoto
                Absherphoto.SetupEditAttributes();
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.EditValue = Absherphoto.Upload.DbValue;
                } else {
                    Absherphoto.EditValue = "";
                }
                if (!Empty(Absherphoto.CurrentValue))
                        Absherphoto.Upload.FileName = ConvertToString(Absherphoto.CurrentValue);
                if (IsShow && !EventCancelled)
                    await RenderUploadField(Absherphoto);

                // Edit refer script

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // str_Password
                str_Password.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";

                // str_Address
                str_Address.HrefValue = "";

                // str_City
                str_City.HrefValue = "";

                // int_State
                int_State.HrefValue = "";

                // str_Zip
                str_Zip.HrefValue = "";

                // str_Home_Phone
                str_Home_Phone.HrefValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";

                // str_Email
                str_Email.HrefValue = "";

                // User_Role
                User_Role.HrefValue = "";
                User_Role.TooltipValue = "";

                // UserlevelID
                UserlevelID.HrefValue = "";

                // Activated
                Activated.HrefValue = "";

                // Supervisor_Username
                Supervisor_Username.HrefValue = "";

                // str_Staff_Username
                str_Staff_Username.HrefValue = "";

                // Hijri_Year
                Hijri_Year.HrefValue = "";

                // Hijri_Month
                Hijri_Month.HrefValue = "";

                // Hijri_Day
                Hijri_Day.HrefValue = "";

                // int_Nationality
                int_Nationality.HrefValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";
                int_Modified_By.TooltipValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
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
            if (str_First_Name.Required) {
                if (!str_First_Name.IsDetailKey && Empty(str_First_Name.FormValue)) {
                    str_First_Name.AddErrorMessage(ConvertToString(str_First_Name.RequiredErrorMessage).Replace("%s", str_First_Name.Caption));
                }
            }
            if (str_Middle_Name.Required) {
                if (!str_Middle_Name.IsDetailKey && Empty(str_Middle_Name.FormValue)) {
                    str_Middle_Name.AddErrorMessage(ConvertToString(str_Middle_Name.RequiredErrorMessage).Replace("%s", str_Middle_Name.Caption));
                }
            }
            if (str_Last_Name.Required) {
                if (!str_Last_Name.IsDetailKey && Empty(str_Last_Name.FormValue)) {
                    str_Last_Name.AddErrorMessage(ConvertToString(str_Last_Name.RequiredErrorMessage).Replace("%s", str_Last_Name.Caption));
                }
            }
            if (str_Password.Required) {
                if (!str_Password.IsDetailKey && Empty(str_Password.FormValue)) {
                    str_Password.AddErrorMessage(ConvertToString(str_Password.RequiredErrorMessage).Replace("%s", str_Password.Caption));
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
            if (str_NationalID_Iqama.Required) {
                if (!str_NationalID_Iqama.IsDetailKey && Empty(str_NationalID_Iqama.FormValue)) {
                    str_NationalID_Iqama.AddErrorMessage(ConvertToString(str_NationalID_Iqama.RequiredErrorMessage).Replace("%s", str_NationalID_Iqama.Caption));
                }
            }
            if (str_Address.Required) {
                if (!str_Address.IsDetailKey && Empty(str_Address.FormValue)) {
                    str_Address.AddErrorMessage(ConvertToString(str_Address.RequiredErrorMessage).Replace("%s", str_Address.Caption));
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
            if (str_Zip.Required) {
                if (!str_Zip.IsDetailKey && Empty(str_Zip.FormValue)) {
                    str_Zip.AddErrorMessage(ConvertToString(str_Zip.RequiredErrorMessage).Replace("%s", str_Zip.Caption));
                }
            }
            if (str_Home_Phone.Required) {
                if (!str_Home_Phone.IsDetailKey && Empty(str_Home_Phone.FormValue)) {
                    str_Home_Phone.AddErrorMessage(ConvertToString(str_Home_Phone.RequiredErrorMessage).Replace("%s", str_Home_Phone.Caption));
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
            if (!CheckEmail(str_Email.FormValue)) {
                str_Email.AddErrorMessage(str_Email.GetErrorMessage(false));
            }
            if (User_Role.Required) {
                if (!User_Role.IsDetailKey && Empty(User_Role.FormValue)) {
                    User_Role.AddErrorMessage(ConvertToString(User_Role.RequiredErrorMessage).Replace("%s", User_Role.Caption));
                }
            }
            if (UserlevelID.Required) {
                if (!UserlevelID.IsDetailKey && Empty(UserlevelID.FormValue)) {
                    UserlevelID.AddErrorMessage(ConvertToString(UserlevelID.RequiredErrorMessage).Replace("%s", UserlevelID.Caption));
                }
            }
            if (Activated.Required) {
                if (Empty(Activated.FormValue)) {
                    Activated.AddErrorMessage(ConvertToString(Activated.RequiredErrorMessage).Replace("%s", Activated.Caption));
                }
            }
            if (Supervisor_Username.Required) {
                if (!Supervisor_Username.IsDetailKey && Empty(Supervisor_Username.FormValue)) {
                    Supervisor_Username.AddErrorMessage(ConvertToString(Supervisor_Username.RequiredErrorMessage).Replace("%s", Supervisor_Username.Caption));
                }
            }
            if (str_Staff_Username.Required) {
                if (!str_Staff_Username.IsDetailKey && Empty(str_Staff_Username.FormValue)) {
                    str_Staff_Username.AddErrorMessage(ConvertToString(str_Staff_Username.RequiredErrorMessage).Replace("%s", str_Staff_Username.Caption));
                }
            }
            if (Hijri_Year.Required) {
                if (!Hijri_Year.IsDetailKey && Empty(Hijri_Year.FormValue)) {
                    Hijri_Year.AddErrorMessage(ConvertToString(Hijri_Year.RequiredErrorMessage).Replace("%s", Hijri_Year.Caption));
                }
            }
            if (Hijri_Month.Required) {
                if (!Hijri_Month.IsDetailKey && Empty(Hijri_Month.FormValue)) {
                    Hijri_Month.AddErrorMessage(ConvertToString(Hijri_Month.RequiredErrorMessage).Replace("%s", Hijri_Month.Caption));
                }
            }
            if (Hijri_Day.Required) {
                if (!Hijri_Day.IsDetailKey && Empty(Hijri_Day.FormValue)) {
                    Hijri_Day.AddErrorMessage(ConvertToString(Hijri_Day.RequiredErrorMessage).Replace("%s", Hijri_Day.Caption));
                }
            }
            if (int_Nationality.Required) {
                if (!int_Nationality.IsDetailKey && Empty(int_Nationality.FormValue)) {
                    int_Nationality.AddErrorMessage(ConvertToString(int_Nationality.RequiredErrorMessage).Replace("%s", int_Nationality.Caption));
                }
            }
            if (date_Modified.Required) {
                if (!date_Modified.IsDetailKey && Empty(date_Modified.FormValue)) {
                    date_Modified.AddErrorMessage(ConvertToString(date_Modified.RequiredErrorMessage).Replace("%s", date_Modified.Caption));
                }
            }
            if (int_Modified_By.Required) {
                if (!int_Modified_By.IsDetailKey && Empty(int_Modified_By.FormValue)) {
                    int_Modified_By.AddErrorMessage(ConvertToString(int_Modified_By.RequiredErrorMessage).Replace("%s", int_Modified_By.Caption));
                }
            }
            if (str_Emergency_Contact_Name.Required) {
                if (!str_Emergency_Contact_Name.IsDetailKey && Empty(str_Emergency_Contact_Name.FormValue)) {
                    str_Emergency_Contact_Name.AddErrorMessage(ConvertToString(str_Emergency_Contact_Name.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Name.Caption));
                }
            }
            if (str_Emergency_Contact_Phone.Required) {
                if (!str_Emergency_Contact_Phone.IsDetailKey && Empty(str_Emergency_Contact_Phone.FormValue)) {
                    str_Emergency_Contact_Phone.AddErrorMessage(ConvertToString(str_Emergency_Contact_Phone.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Phone.Caption));
                }
            }
            if (str_Emergency_Contact_Relation.Required) {
                if (!str_Emergency_Contact_Relation.IsDetailKey && Empty(str_Emergency_Contact_Relation.FormValue)) {
                    str_Emergency_Contact_Relation.AddErrorMessage(ConvertToString(str_Emergency_Contact_Relation.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Relation.Caption));
                }
            }
            if (Absherphoto.Required) {
                if (Absherphoto.Upload.FileName == "" && !Absherphoto.Upload.KeepFile) {
                    Absherphoto.AddErrorMessage(ConvertToString(Absherphoto.RequiredErrorMessage).Replace("%s", Absherphoto.Caption));
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

            // str_First_Name
            str_First_Name.SetDbValue(rsnew, str_First_Name.CurrentValue, str_First_Name.ReadOnly);

            // str_Middle_Name
            str_Middle_Name.SetDbValue(rsnew, str_Middle_Name.CurrentValue, str_Middle_Name.ReadOnly);

            // str_Last_Name
            str_Last_Name.SetDbValue(rsnew, str_Last_Name.CurrentValue, str_Last_Name.ReadOnly);

            // str_Password
            str_Password.SetDbValue(rsnew, str_Password.CurrentValue, str_Password.ReadOnly);

            // NationalID
            NationalID.SetDbValue(rsnew, NationalID.CurrentValue, NationalID.ReadOnly);

            // str_NationalID_Iqama
            str_NationalID_Iqama.SetDbValue(rsnew, str_NationalID_Iqama.CurrentValue, str_NationalID_Iqama.ReadOnly);

            // str_Address
            str_Address.SetDbValue(rsnew, str_Address.CurrentValue, str_Address.ReadOnly);

            // str_City
            str_City.SetDbValue(rsnew, str_City.CurrentValue, str_City.ReadOnly);

            // int_State
            int_State.SetDbValue(rsnew, int_State.CurrentValue, int_State.ReadOnly);

            // str_Zip
            str_Zip.SetDbValue(rsnew, str_Zip.CurrentValue, str_Zip.ReadOnly);

            // str_Home_Phone
            str_Home_Phone.SetDbValue(rsnew, str_Home_Phone.CurrentValue, str_Home_Phone.ReadOnly);

            // str_Cell_Phone
            str_Cell_Phone.SetDbValue(rsnew, str_Cell_Phone.CurrentValue, str_Cell_Phone.ReadOnly);

            // str_Email
            str_Email.SetDbValue(rsnew, str_Email.CurrentValue, str_Email.ReadOnly);

            // UserlevelID
            UserlevelID.SetDbValue(rsnew, UserlevelID.CurrentValue, UserlevelID.ReadOnly);

            // Activated
            Activated.SetDbValue(rsnew, ConvertToBool(Activated.CurrentValue), Activated.ReadOnly);

            // Supervisor_Username
            Supervisor_Username.SetDbValue(rsnew, Supervisor_Username.CurrentValue, Supervisor_Username.ReadOnly);

            // str_Staff_Username
            str_Staff_Username.SetDbValue(rsnew, str_Staff_Username.CurrentValue, str_Staff_Username.ReadOnly);

            // Hijri_Year
            Hijri_Year.SetDbValue(rsnew, Hijri_Year.CurrentValue, Hijri_Year.ReadOnly);

            // Hijri_Month
            Hijri_Month.SetDbValue(rsnew, Hijri_Month.CurrentValue, Hijri_Month.ReadOnly);

            // Hijri_Day
            Hijri_Day.SetDbValue(rsnew, Hijri_Day.CurrentValue, Hijri_Day.ReadOnly);

            // int_Nationality
            int_Nationality.SetDbValue(rsnew, int_Nationality.CurrentValue, int_Nationality.ReadOnly);

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.SetDbValue(rsnew, str_Emergency_Contact_Name.CurrentValue, str_Emergency_Contact_Name.ReadOnly);

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.SetDbValue(rsnew, str_Emergency_Contact_Phone.CurrentValue, str_Emergency_Contact_Phone.ReadOnly);

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.SetDbValue(rsnew, str_Emergency_Contact_Relation.CurrentValue, str_Emergency_Contact_Relation.ReadOnly);

            // Absherphoto
            if (Absherphoto.Visible && !Absherphoto.ReadOnly && !Absherphoto.Upload.KeepFile) {
                Absherphoto.Upload.DbValue = rsold["Absherphoto"]; // Get original value
                if (Empty(Absherphoto.Upload.FileName)) {
                    rsnew["Absherphoto"] = DbNullValue;
                } else {
                    FixUploadTempFileNames(Absherphoto);
                    rsnew["Absherphoto"] = Absherphoto.Upload.FileName;
                }
            }

            // Update current values
            SetCurrentValues(rsnew);
            if (Absherphoto.Visible && !Absherphoto.Upload.KeepFile) {
                if (!Empty(Absherphoto.Upload.FileName)) {
                    FixUploadFileNames(Absherphoto);
                    Absherphoto.SetDbValue(rsnew, Absherphoto.Upload.FileName, Absherphoto.ReadOnly);
                }
            }

            // Call Row Updating event
            bool updateRow = RowUpdating(rsold, rsnew);
            if (updateRow) {
                try {
                    if (rsnew.Count > 0)
                        result = await UpdateAsync(rsnew, null, rsold) > 0;
                    else
                        result = true;
                    if (result) {
                        if (Absherphoto.Visible && !Absherphoto.Upload.KeepFile) {
                            if (!await SaveUploadFiles(Absherphoto, ConvertToString(rsnew["Absherphoto"]), false))
                            {
                                FailureMessage = Language.Phrase("UploadError7");
                                return JsonBoolResult.FalseResult;
                            }
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblStaffList")), "", TableVar, true);
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
            pages.Add(3);
            pages.Add(4);
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
                    case "x_Hijri_Month":
                        lookupFilter = () => fld.GetSelectFilter();
                        break;
                    case "x_Hijri_Day":
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
