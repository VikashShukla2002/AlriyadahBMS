namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStudentsUpdate
    /// </summary>
    public static TblStudentsUpdate tblStudentsUpdate
    {
        get => HttpData.Get<TblStudentsUpdate>("tblStudentsUpdate")!;
        set => HttpData["tblStudentsUpdate"] = value;
    }

    /// <summary>
    /// Page class for tblStudents
    /// </summary>
    public class TblStudentsUpdate : TblStudentsUpdateBase
    {
        // Constructor
        public TblStudentsUpdate(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblStudentsUpdate() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblStudentsUpdateBase : TblStudents
    {
        // Page ID
        public string PageID = "update";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblStudents";

        // Page object name
        public string PageObjName = "tblStudentsUpdate";

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
        public TblStudentsUpdateBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-update-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblStudents)
            if (tblStudents == null || tblStudents is TblStudents)
                tblStudents = this;

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
        public string PageName => "TblStudentsUpdate";

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
            int_Student_ID.Visible = false;
            str_First_Name.SetVisibility();
            str_Middle_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Full_Name.Visible = false;
            str_Address.SetVisibility();
            str_City.SetVisibility();
            int_State.SetVisibility();
            str_Zip.SetVisibility();
            date_Hired.SetVisibility();
            date_Left.SetVisibility();
            str_CertNumber.SetVisibility();
            date_CertExp.SetVisibility();
            str_Cell_Phone.SetVisibility();
            str_Home_Phone.SetVisibility();
            str_Other_Phone.SetVisibility();
            str_Email.SetVisibility();
            str_Code.SetVisibility();
            str_Username.SetVisibility();
            str_Password.SetVisibility();
            date_Birth_Hijri.SetVisibility();
            date_Birth.SetVisibility();
            Hijri_Year.SetVisibility();
            Hijri_Month.SetVisibility();
            Hijri_Day.SetVisibility();
            date_Started.SetVisibility();
            str_DateHired.SetVisibility();
            str_DateLeft.SetVisibility();
            str_Emergency_Contact_Name.SetVisibility();
            str_Emergency_Contact_Phone.SetVisibility();
            str_Emergency_Contact_Relation.SetVisibility();
            str_Notes.SetVisibility();
            int_ClassType.SetVisibility();
            str_ZipCodes.SetVisibility();
            int_VehicleAssigned.SetVisibility();
            int_Status.SetVisibility();
            int_Type.SetVisibility();
            int_Location.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_InstPermitNo.SetVisibility();
            date_PermitExpiration.SetVisibility();
            date_InCarPermitIssue.SetVisibility();
            str_InClassPermitNo.SetVisibility();
            date_InClassPermitIssue.SetVisibility();
            instructor_caption.SetVisibility();
            str_LicType.SetVisibility();
            int_Order.SetVisibility();
            str_InstLicenceDate.SetVisibility();
            str_DLNum.SetVisibility();
            str_DLExp.SetVisibility();
            bit_appointmentColor.SetVisibility();
            str_appointmentColorCode.SetVisibility();
            bit_IsSuperAdmin.SetVisibility();
            IsDistanceBasedScheduling.SetVisibility();
            str_Package_Code.SetVisibility();
            str_NationalID_Iqama.SetVisibility();
            NationalID.SetVisibility();
            int_RoadDistanceCoverage.SetVisibility();
            str_Badge.SetVisibility();
            strZoomHostUrl.SetVisibility();
            strZoomUserUrl.SetVisibility();
            Signature.SetVisibility();
            str_VehicleType.SetVisibility();
            ProfilePicturePath.SetVisibility();
            Institution.SetVisibility();
            IsDrivingexperience.SetVisibility();
            intDrivinglicenseType.SetVisibility();
            AbsherApptNbr.SetVisibility();
            Absherphoto.SetVisibility();
            Fingerprint.SetVisibility();
            ProfileField.SetVisibility();
            UserlevelID.SetVisibility();
            Parent_Username.SetVisibility();
            Activated.SetVisibility();
            int_Nationality.SetVisibility();
            User_Role.SetVisibility();
            int_Staff_Id.SetVisibility();
        }

        // Constructor
        public TblStudentsUpdateBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblStudentsView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Student_ID") ? dict["int_Student_ID"] : int_Student_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Student_ID.Visible = false;
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

    public string FormClassName = "ew-form ew-update-form";

    public bool IsModal = false;

    public bool IsMobileOrModal = false;

    public DbDataReader? Recordset;

    public List<string> RecordKeys = new ();

    public bool Disabled; // DN

    public int TotalRecords;

    public int UpdateCount = 0;

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
            await SetupLookupOptions(str_City);
            await SetupLookupOptions(int_State);
            await SetupLookupOptions(Hijri_Year);
            await SetupLookupOptions(Hijri_Month);
            await SetupLookupOptions(Hijri_Day);
            await SetupLookupOptions(str_Emergency_Contact_Relation);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_appointmentColor);
            await SetupLookupOptions(bit_IsSuperAdmin);
            await SetupLookupOptions(IsDrivingexperience);
            await SetupLookupOptions(intDrivinglicenseType);
            await SetupLookupOptions(UserlevelID);
            await SetupLookupOptions(Parent_Username);
            await SetupLookupOptions(Activated);
            await SetupLookupOptions(User_Role);

        // Check modal
        if (IsModal)
            SkipHeaderFooter = true;
        IsMobileOrModal = IsMobile() || IsModal;

        // Set up Breadcrumb
        SetupBreadcrumb();

        // Try to load keys from list form
        RecordKeys = GetRecordKeys(); // Load record keys

        // Check if valid User ID
        string sql = GetSql(GetFilterFromRecordKeys(false));
        using (Recordset = await Connection.OpenDataReaderAsync(sql)) {
            if (Recordset != null) {
                while (await Recordset.ReadAsync()) {
                    await LoadRowValues(Recordset);
                    if (!ShowOptionLink("update")) {
                        string userIdMsg = Language.Phrase("NoEditPermission");
                        FailureMessage = userIdMsg;
                        return Terminate("TblStudentsList"); // Return to list
                    }
                }
            }
        }
        if (Post("action", out StringValues sv) && !Empty(sv)) {
            // Get action
            CurrentAction = sv.ToString();
            await LoadFormValues(); // Get form values

            // Validate form
            if (!await ValidateForm()) {
                CurrentAction = "show"; // Form error, reset action
                if (!HasInvalidFields()) // No fields selected
                    FailureMessage = Language.Phrase("NoFieldSelected");
            }
        } else {
            await LoadMultiUpdateValues(); // Load initial values to form
        }
        if (RecordKeys.Count <= 0)
            return Terminate("TblStudentsList"); // No records selected, return to list
        if (IsUpdate) {
            if (await UpdateRows()) { // Update Records based on key
                if (Empty(SuccessMessage))
                    SuccessMessage = Language.Phrase("UpdateSuccess"); // Set update success message

                // Do not return Json for UseAjaxActions
                if (IsModal && UseAjaxActions)
                    IsModal = false;
                return Terminate(ReturnUrl); // Return to caller
            } else if (IsModal && UseAjaxActions) { // Return JSON error message
                return Controller.Json(new { success = false, error = GetFailureMessage() });
            } else {
                RestoreFormValues(); // Restore form values
            }
        }

        // Render row
        RowType = RowType.Edit; // Render edit
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
                tblStudentsUpdate?.PageRender();
            }
        return PageResult();
    }

    // Load initial values to form if field values are identical in all selected records
    public async Task LoadMultiUpdateValues()
    {
        CurrentFilter = GetFilterFromRecordKeys();
        int i = 1;

        // Load recordset
        using var rs = await LoadRecordset();
        try {
            while (rs != null && await rs.ReadAsync()) {
                if (i == 1) {
                    str_First_Name.SetDbValue(rs["str_First_Name"]);
                    str_Middle_Name.SetDbValue(rs["str_Middle_Name"]);
                    str_Last_Name.SetDbValue(rs["str_Last_Name"]);
                    str_Address.SetDbValue(rs["str_Address"]);
                    str_City.SetDbValue(rs["str_City"]);
                    int_State.SetDbValue(rs["int_State"]);
                    str_Zip.SetDbValue(rs["str_Zip"]);
                    date_Hired.SetDbValue(rs["date_Hired"]);
                    date_Left.SetDbValue(rs["date_Left"]);
                    str_CertNumber.SetDbValue(rs["str_CertNumber"]);
                    date_CertExp.SetDbValue(rs["date_CertExp"]);
                    str_Cell_Phone.SetDbValue(rs["str_Cell_Phone"]);
                    str_Home_Phone.SetDbValue(rs["str_Home_Phone"]);
                    str_Other_Phone.SetDbValue(rs["str_Other_Phone"]);
                    str_Email.SetDbValue(rs["str_Email"]);
                    str_Code.SetDbValue(rs["str_Code"]);
                    str_Username.SetDbValue(rs["str_Username"]);
                    str_Password.SetDbValue(rs["str_Password"]);
                    date_Birth_Hijri.SetDbValue(rs["date_Birth_Hijri"]);
                    date_Birth.SetDbValue(rs["date_Birth"]);
                    Hijri_Year.SetDbValue(rs["Hijri_Year"]);
                    Hijri_Month.SetDbValue(rs["Hijri_Month"]);
                    Hijri_Day.SetDbValue(rs["Hijri_Day"]);
                    date_Started.SetDbValue(rs["date_Started"]);
                    str_DateHired.SetDbValue(rs["str_DateHired"]);
                    str_DateLeft.SetDbValue(rs["str_DateLeft"]);
                    str_Emergency_Contact_Name.SetDbValue(rs["str_Emergency_Contact_Name"]);
                    str_Emergency_Contact_Phone.SetDbValue(rs["str_Emergency_Contact_Phone"]);
                    str_Emergency_Contact_Relation.SetDbValue(rs["str_Emergency_Contact_Relation"]);
                    str_Notes.SetDbValue(rs["str_Notes"]);
                    int_ClassType.SetDbValue(rs["int_ClassType"]);
                    str_ZipCodes.SetDbValue(rs["str_ZipCodes"]);
                    int_VehicleAssigned.SetDbValue(rs["int_VehicleAssigned"]);
                    int_Status.SetDbValue(rs["int_Status"]);
                    int_Type.SetDbValue(rs["int_Type"]);
                    int_Location.SetDbValue(rs["int_Location"]);
                    date_Created.SetDbValue(rs["date_Created"]);
                    date_Modified.SetDbValue(rs["date_Modified"]);
                    int_Created_By.SetDbValue(rs["int_Created_By"]);
                    int_Modified_By.SetDbValue(rs["int_Modified_By"]);
                    bit_IsDeleted.SetDbValue(rs["bit_IsDeleted"]);
                    str_InstPermitNo.SetDbValue(rs["str_InstPermitNo"]);
                    date_PermitExpiration.SetDbValue(rs["date_PermitExpiration"]);
                    date_InCarPermitIssue.SetDbValue(rs["date_InCarPermitIssue"]);
                    str_InClassPermitNo.SetDbValue(rs["str_InClassPermitNo"]);
                    date_InClassPermitIssue.SetDbValue(rs["date_InClassPermitIssue"]);
                    instructor_caption.SetDbValue(rs["instructor_caption"]);
                    str_LicType.SetDbValue(rs["str_LicType"]);
                    int_Order.SetDbValue(rs["int_Order"]);
                    str_InstLicenceDate.SetDbValue(rs["str_InstLicenceDate"]);
                    str_DLNum.SetDbValue(rs["str_DLNum"]);
                    str_DLExp.SetDbValue(rs["str_DLExp"]);
                    bit_appointmentColor.SetDbValue(rs["bit_appointmentColor"]);
                    str_appointmentColorCode.SetDbValue(rs["str_appointmentColorCode"]);
                    bit_IsSuperAdmin.SetDbValue(rs["bit_IsSuperAdmin"]);
                    IsDistanceBasedScheduling.SetDbValue(rs["IsDistanceBasedScheduling"]);
                    str_Package_Code.SetDbValue(rs["str_Package_Code"]);
                    str_NationalID_Iqama.SetDbValue(rs["str_NationalID_Iqama"]);
                    NationalID.SetDbValue(rs["NationalID"]);
                    int_RoadDistanceCoverage.SetDbValue(rs["int_RoadDistanceCoverage"]);
                    str_Badge.SetDbValue(rs["str_Badge"]);
                    strZoomHostUrl.SetDbValue(rs["strZoomHostUrl"]);
                    strZoomUserUrl.SetDbValue(rs["strZoomUserUrl"]);
                    str_VehicleType.SetDbValue(rs["str_VehicleType"]);
                    ProfilePicturePath.SetDbValue(rs["ProfilePicturePath"]);
                    Institution.SetDbValue(rs["Institution"]);
                    IsDrivingexperience.SetDbValue(rs["IsDrivingexperience"]);
                    intDrivinglicenseType.SetDbValue(rs["intDrivinglicenseType"]);
                    AbsherApptNbr.SetDbValue(rs["AbsherApptNbr"]);
                    ProfileField.SetDbValue(rs["ProfileField"]);
                    UserlevelID.SetDbValue(rs["UserlevelID"]);
                    Parent_Username.SetDbValue(rs["Parent_Username"]);
                    Activated.SetDbValue(rs["Activated"]);
                    int_Nationality.SetDbValue(rs["int_Nationality"]);
                    User_Role.SetDbValue(rs["User_Role"]);
                    int_Staff_Id.SetDbValue(rs["int_Staff_Id"]);
                } else {
                    if (!CompareValue(str_First_Name.DbValue, rs["str_First_Name"]))
                        str_First_Name.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Middle_Name.DbValue, rs["str_Middle_Name"]))
                        str_Middle_Name.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Last_Name.DbValue, rs["str_Last_Name"]))
                        str_Last_Name.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Address.DbValue, rs["str_Address"]))
                        str_Address.CurrentValue = DbNullValue;
                    if (!CompareValue(str_City.DbValue, rs["str_City"]))
                        str_City.CurrentValue = DbNullValue;
                    if (!CompareValue(int_State.DbValue, rs["int_State"]))
                        int_State.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Zip.DbValue, rs["str_Zip"]))
                        str_Zip.CurrentValue = DbNullValue;
                    if (!CompareValue(date_Hired.DbValue, rs["date_Hired"]))
                        date_Hired.CurrentValue = DbNullValue;
                    if (!CompareValue(date_Left.DbValue, rs["date_Left"]))
                        date_Left.CurrentValue = DbNullValue;
                    if (!CompareValue(str_CertNumber.DbValue, rs["str_CertNumber"]))
                        str_CertNumber.CurrentValue = DbNullValue;
                    if (!CompareValue(date_CertExp.DbValue, rs["date_CertExp"]))
                        date_CertExp.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Cell_Phone.DbValue, rs["str_Cell_Phone"]))
                        str_Cell_Phone.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Home_Phone.DbValue, rs["str_Home_Phone"]))
                        str_Home_Phone.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Other_Phone.DbValue, rs["str_Other_Phone"]))
                        str_Other_Phone.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Email.DbValue, rs["str_Email"]))
                        str_Email.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Code.DbValue, rs["str_Code"]))
                        str_Code.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Username.DbValue, rs["str_Username"]))
                        str_Username.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Password.DbValue, rs["str_Password"]))
                        str_Password.CurrentValue = DbNullValue;
                    if (!CompareValue(date_Birth_Hijri.DbValue, rs["date_Birth_Hijri"]))
                        date_Birth_Hijri.CurrentValue = DbNullValue;
                    if (!CompareValue(date_Birth.DbValue, rs["date_Birth"]))
                        date_Birth.CurrentValue = DbNullValue;
                    if (!CompareValue(Hijri_Year.DbValue, rs["Hijri_Year"]))
                        Hijri_Year.CurrentValue = DbNullValue;
                    if (!CompareValue(Hijri_Month.DbValue, rs["Hijri_Month"]))
                        Hijri_Month.CurrentValue = DbNullValue;
                    if (!CompareValue(Hijri_Day.DbValue, rs["Hijri_Day"]))
                        Hijri_Day.CurrentValue = DbNullValue;
                    if (!CompareValue(date_Started.DbValue, rs["date_Started"]))
                        date_Started.CurrentValue = DbNullValue;
                    if (!CompareValue(str_DateHired.DbValue, rs["str_DateHired"]))
                        str_DateHired.CurrentValue = DbNullValue;
                    if (!CompareValue(str_DateLeft.DbValue, rs["str_DateLeft"]))
                        str_DateLeft.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Emergency_Contact_Name.DbValue, rs["str_Emergency_Contact_Name"]))
                        str_Emergency_Contact_Name.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Emergency_Contact_Phone.DbValue, rs["str_Emergency_Contact_Phone"]))
                        str_Emergency_Contact_Phone.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Emergency_Contact_Relation.DbValue, rs["str_Emergency_Contact_Relation"]))
                        str_Emergency_Contact_Relation.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Notes.DbValue, rs["str_Notes"]))
                        str_Notes.CurrentValue = DbNullValue;
                    if (!CompareValue(int_ClassType.DbValue, rs["int_ClassType"]))
                        int_ClassType.CurrentValue = DbNullValue;
                    if (!CompareValue(str_ZipCodes.DbValue, rs["str_ZipCodes"]))
                        str_ZipCodes.CurrentValue = DbNullValue;
                    if (!CompareValue(int_VehicleAssigned.DbValue, rs["int_VehicleAssigned"]))
                        int_VehicleAssigned.CurrentValue = DbNullValue;
                    if (!CompareValue(int_Status.DbValue, rs["int_Status"]))
                        int_Status.CurrentValue = DbNullValue;
                    if (!CompareValue(int_Type.DbValue, rs["int_Type"]))
                        int_Type.CurrentValue = DbNullValue;
                    if (!CompareValue(int_Location.DbValue, rs["int_Location"]))
                        int_Location.CurrentValue = DbNullValue;
                    if (!CompareValue(date_Created.DbValue, rs["date_Created"]))
                        date_Created.CurrentValue = DbNullValue;
                    if (!CompareValue(date_Modified.DbValue, rs["date_Modified"]))
                        date_Modified.CurrentValue = DbNullValue;
                    if (!CompareValue(int_Created_By.DbValue, rs["int_Created_By"]))
                        int_Created_By.CurrentValue = DbNullValue;
                    if (!CompareValue(int_Modified_By.DbValue, rs["int_Modified_By"]))
                        int_Modified_By.CurrentValue = DbNullValue;
                    if (!CompareValue(bit_IsDeleted.DbValue, rs["bit_IsDeleted"]))
                        bit_IsDeleted.CurrentValue = DbNullValue;
                    if (!CompareValue(str_InstPermitNo.DbValue, rs["str_InstPermitNo"]))
                        str_InstPermitNo.CurrentValue = DbNullValue;
                    if (!CompareValue(date_PermitExpiration.DbValue, rs["date_PermitExpiration"]))
                        date_PermitExpiration.CurrentValue = DbNullValue;
                    if (!CompareValue(date_InCarPermitIssue.DbValue, rs["date_InCarPermitIssue"]))
                        date_InCarPermitIssue.CurrentValue = DbNullValue;
                    if (!CompareValue(str_InClassPermitNo.DbValue, rs["str_InClassPermitNo"]))
                        str_InClassPermitNo.CurrentValue = DbNullValue;
                    if (!CompareValue(date_InClassPermitIssue.DbValue, rs["date_InClassPermitIssue"]))
                        date_InClassPermitIssue.CurrentValue = DbNullValue;
                    if (!CompareValue(instructor_caption.DbValue, rs["instructor_caption"]))
                        instructor_caption.CurrentValue = DbNullValue;
                    if (!CompareValue(str_LicType.DbValue, rs["str_LicType"]))
                        str_LicType.CurrentValue = DbNullValue;
                    if (!CompareValue(int_Order.DbValue, rs["int_Order"]))
                        int_Order.CurrentValue = DbNullValue;
                    if (!CompareValue(str_InstLicenceDate.DbValue, rs["str_InstLicenceDate"]))
                        str_InstLicenceDate.CurrentValue = DbNullValue;
                    if (!CompareValue(str_DLNum.DbValue, rs["str_DLNum"]))
                        str_DLNum.CurrentValue = DbNullValue;
                    if (!CompareValue(str_DLExp.DbValue, rs["str_DLExp"]))
                        str_DLExp.CurrentValue = DbNullValue;
                    if (!CompareValue(bit_appointmentColor.DbValue, rs["bit_appointmentColor"]))
                        bit_appointmentColor.CurrentValue = DbNullValue;
                    if (!CompareValue(str_appointmentColorCode.DbValue, rs["str_appointmentColorCode"]))
                        str_appointmentColorCode.CurrentValue = DbNullValue;
                    if (!CompareValue(bit_IsSuperAdmin.DbValue, rs["bit_IsSuperAdmin"]))
                        bit_IsSuperAdmin.CurrentValue = DbNullValue;
                    if (!CompareValue(IsDistanceBasedScheduling.DbValue, rs["IsDistanceBasedScheduling"]))
                        IsDistanceBasedScheduling.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Package_Code.DbValue, rs["str_Package_Code"]))
                        str_Package_Code.CurrentValue = DbNullValue;
                    if (!CompareValue(str_NationalID_Iqama.DbValue, rs["str_NationalID_Iqama"]))
                        str_NationalID_Iqama.CurrentValue = DbNullValue;
                    if (!CompareValue(NationalID.DbValue, rs["NationalID"]))
                        NationalID.CurrentValue = DbNullValue;
                    if (!CompareValue(int_RoadDistanceCoverage.DbValue, rs["int_RoadDistanceCoverage"]))
                        int_RoadDistanceCoverage.CurrentValue = DbNullValue;
                    if (!CompareValue(str_Badge.DbValue, rs["str_Badge"]))
                        str_Badge.CurrentValue = DbNullValue;
                    if (!CompareValue(strZoomHostUrl.DbValue, rs["strZoomHostUrl"]))
                        strZoomHostUrl.CurrentValue = DbNullValue;
                    if (!CompareValue(strZoomUserUrl.DbValue, rs["strZoomUserUrl"]))
                        strZoomUserUrl.CurrentValue = DbNullValue;
                    if (!CompareValue(str_VehicleType.DbValue, rs["str_VehicleType"]))
                        str_VehicleType.CurrentValue = DbNullValue;
                    if (!CompareValue(ProfilePicturePath.DbValue, rs["ProfilePicturePath"]))
                        ProfilePicturePath.CurrentValue = DbNullValue;
                    if (!CompareValue(Institution.DbValue, rs["Institution"]))
                        Institution.CurrentValue = DbNullValue;
                    if (!CompareValue(IsDrivingexperience.DbValue, rs["IsDrivingexperience"]))
                        IsDrivingexperience.CurrentValue = DbNullValue;
                    if (!CompareValue(intDrivinglicenseType.DbValue, rs["intDrivinglicenseType"]))
                        intDrivinglicenseType.CurrentValue = DbNullValue;
                    if (!CompareValue(AbsherApptNbr.DbValue, rs["AbsherApptNbr"]))
                        AbsherApptNbr.CurrentValue = DbNullValue;
                    if (!CompareValue(ProfileField.DbValue, rs["ProfileField"]))
                        ProfileField.CurrentValue = DbNullValue;
                    if (!CompareValue(UserlevelID.DbValue, rs["UserlevelID"]))
                        UserlevelID.CurrentValue = DbNullValue;
                    if (!CompareValue(Parent_Username.DbValue, rs["Parent_Username"]))
                        Parent_Username.CurrentValue = DbNullValue;
                    if (!CompareValue(Activated.DbValue, rs["Activated"]))
                        Activated.CurrentValue = DbNullValue;
                    if (!CompareValue(int_Nationality.DbValue, rs["int_Nationality"]))
                        int_Nationality.CurrentValue = DbNullValue;
                    if (!CompareValue(User_Role.DbValue, rs["User_Role"]))
                        User_Role.CurrentValue = DbNullValue;
                    if (!CompareValue(int_Staff_Id.DbValue, rs["int_Staff_Id"]))
                        int_Staff_Id.CurrentValue = DbNullValue;
                }
                i++;
            }
        } catch {
            if (Config.Debug)
                throw;
        }
    }

    // Set up key value
    public bool SetupKeyValues(object key)
    {
        string keyFld = "";
        keyFld = ConvertToString(key);
        if (!IsNumeric(keyFld))
            return false;
        int_Student_ID.OldValue = keyFld;
        return true;
    }

    // Update all selected rows
    public async Task<bool> UpdateRows()
    {
        bool result = false;
        List<string> successKeys = new ();
        List<string> failKeys = new ();
        string thisKey = "";
        string sql;
        List<Dictionary<string, object>> rsold, rsnew;
        if (UseTransaction)
            Connection.BeginTrans(); // Begin transaction
        if (AuditTrailOnEdit)
            await WriteAuditTrailLog(Language.Phrase("BatchUpdateBegin")); // Batch update begin

        // Get old recordset
        CurrentFilter = GetFilterFromRecordKeys(false);
        sql = CurrentSql;
        rsold = await Connection.GetRowsAsync(sql);

        // Update all rows
        try {
            foreach (string recordKey in RecordKeys) {
                if (SetupKeyValues(recordKey)) {
                    thisKey = recordKey;
                    SendEmail = false; // Do not send email on update success
                    UpdateCount++; // Update record count for records being updated
                    result = await EditRow(); // Update this row
                } else {
                    result = false;
                }
                if (!result) {
                    if (UseTransaction) { // Update failed
                        successKeys.Clear();
                        break;
                    }
                    failKeys.Add(thisKey);
                } else {
                    successKeys.Add(thisKey);
                }
            }
        } catch (Exception e) {
            FailureMessage = e.Message;
            result = false;
        }

        // Check if any rows updated
        if (successKeys.Count > 0) {
            if (UseTransaction)
                Connection.CommitTrans(); // Commit transaction

            // Set warning message if update some records failed
            if (failKeys.Count > 0)
                WarningMessage = Language.Phrase("UpdateSomeRecordsFailed").Replace("%k", String.Join(", ", failKeys));

            // Get new recordset
            rsnew = await Connection.GetRowsAsync(sql);
            if (AuditTrailOnEdit)
                await WriteAuditTrailLog(Language.Phrase("BatchUpdateSuccess")); // Batch update success
            string table = "tblStudents";
            string subject = table + " " + Language.Phrase("RecordUpdated");
            string action = Language.Phrase("ActionUpdatedMultiUpdate");
            var email = new Email();
            await email.Load(Config.EmailNotifyTemplate);
            email.ReplaceSender(Config.SenderEmail); // Replace Sender
            email.ReplaceRecipient(Config.RecipientEmail); // Replace Recipient
            email.ReplaceSubject(subject); // Replace Subject
            email.ReplaceContent("<!--table-->", table);
            email.ReplaceContent("<!--key-->", String.Join(", ", successKeys));
            email.ReplaceContent("<!--action-->", action);
            bool emailSent = false;
            if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsold = rsold, rsnew = rsnew })))
                emailSent = await email.SendAsync();

            // Send email failed
            if (!emailSent)
                FailureMessage = email.SendError;
        } else {
            if (UseTransaction)
                Connection.RollbackTrans(); // Rollback transaction
            if (AuditTrailOnEdit)
                await WriteAuditTrailLog(Language.Phrase("BatchUpdateRollback")); // Batch update rollback
        }
        return result;
    }

        // Confirm page
        public bool ConfirmPage = false; // DN

        #pragma warning disable 1998
        // Get upload files
        public async Task GetUploadFiles()
        {
            // Get upload data
            Signature.Upload.Index = CurrentForm.Index;
            if (!await Signature.Upload.UploadFile()) // DN
                End(Signature.Upload.Message);
            Signature.MultiUpdate = CurrentForm.GetValue("u_Signature");
            Absherphoto.Upload.Index = CurrentForm.Index;
            if (!await Absherphoto.Upload.UploadFile()) // DN
                End(Absherphoto.Upload.Message);
            Absherphoto.CurrentValue = Absherphoto.Upload.FileName;
            Absherphoto.MultiUpdate = CurrentForm.GetValue("u_Absherphoto");
            Fingerprint.Upload.Index = CurrentForm.Index;
            if (!await Fingerprint.Upload.UploadFile()) // DN
                End(Fingerprint.Upload.Message);
            Fingerprint.CurrentValue = Fingerprint.Upload.FileName;
            Fingerprint.MultiUpdate = CurrentForm.GetValue("u_Fingerprint");
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
            str_First_Name.MultiUpdate = CurrentForm.GetValue("u_str_First_Name");

            // Check field name 'str_Middle_Name' before field var 'x_str_Middle_Name'
            val = CurrentForm.HasValue("str_Middle_Name") ? CurrentForm.GetValue("str_Middle_Name") : CurrentForm.GetValue("x_str_Middle_Name");
            if (!str_Middle_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Middle_Name") && !CurrentForm.HasValue("x_str_Middle_Name")) // DN
                    str_Middle_Name.Visible = false; // Disable update for API request
                else
                    str_Middle_Name.SetFormValue(val);
            }
            str_Middle_Name.MultiUpdate = CurrentForm.GetValue("u_str_Middle_Name");

            // Check field name 'str_Last_Name' before field var 'x_str_Last_Name'
            val = CurrentForm.HasValue("str_Last_Name") ? CurrentForm.GetValue("str_Last_Name") : CurrentForm.GetValue("x_str_Last_Name");
            if (!str_Last_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Last_Name") && !CurrentForm.HasValue("x_str_Last_Name")) // DN
                    str_Last_Name.Visible = false; // Disable update for API request
                else
                    str_Last_Name.SetFormValue(val);
            }
            str_Last_Name.MultiUpdate = CurrentForm.GetValue("u_str_Last_Name");

            // Check field name 'str_Address' before field var 'x_str_Address'
            val = CurrentForm.HasValue("str_Address") ? CurrentForm.GetValue("str_Address") : CurrentForm.GetValue("x_str_Address");
            if (!str_Address.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Address") && !CurrentForm.HasValue("x_str_Address")) // DN
                    str_Address.Visible = false; // Disable update for API request
                else
                    str_Address.SetFormValue(val);
            }
            str_Address.MultiUpdate = CurrentForm.GetValue("u_str_Address");

            // Check field name 'str_City' before field var 'x_str_City'
            val = CurrentForm.HasValue("str_City") ? CurrentForm.GetValue("str_City") : CurrentForm.GetValue("x_str_City");
            if (!str_City.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_City") && !CurrentForm.HasValue("x_str_City")) // DN
                    str_City.Visible = false; // Disable update for API request
                else
                    str_City.SetFormValue(val);
            }
            str_City.MultiUpdate = CurrentForm.GetValue("u_str_City");

            // Check field name 'int_State' before field var 'x_int_State'
            val = CurrentForm.HasValue("int_State") ? CurrentForm.GetValue("int_State") : CurrentForm.GetValue("x_int_State");
            if (!int_State.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_State") && !CurrentForm.HasValue("x_int_State")) // DN
                    int_State.Visible = false; // Disable update for API request
                else
                    int_State.SetFormValue(val);
            }
            int_State.MultiUpdate = CurrentForm.GetValue("u_int_State");

            // Check field name 'str_Zip' before field var 'x_str_Zip'
            val = CurrentForm.HasValue("str_Zip") ? CurrentForm.GetValue("str_Zip") : CurrentForm.GetValue("x_str_Zip");
            if (!str_Zip.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Zip") && !CurrentForm.HasValue("x_str_Zip")) // DN
                    str_Zip.Visible = false; // Disable update for API request
                else
                    str_Zip.SetFormValue(val);
            }
            str_Zip.MultiUpdate = CurrentForm.GetValue("u_str_Zip");

            // Check field name 'date_Hired' before field var 'x_date_Hired'
            val = CurrentForm.HasValue("date_Hired") ? CurrentForm.GetValue("date_Hired") : CurrentForm.GetValue("x_date_Hired");
            if (!date_Hired.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Hired") && !CurrentForm.HasValue("x_date_Hired")) // DN
                    date_Hired.Visible = false; // Disable update for API request
                else
                    date_Hired.SetFormValue(val);
                date_Hired.CurrentValue = UnformatDateTime(date_Hired.CurrentValue, date_Hired.FormatPattern);
            }
            date_Hired.MultiUpdate = CurrentForm.GetValue("u_date_Hired");

            // Check field name 'date_Left' before field var 'x_date_Left'
            val = CurrentForm.HasValue("date_Left") ? CurrentForm.GetValue("date_Left") : CurrentForm.GetValue("x_date_Left");
            if (!date_Left.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Left") && !CurrentForm.HasValue("x_date_Left")) // DN
                    date_Left.Visible = false; // Disable update for API request
                else
                    date_Left.SetFormValue(val, true, validate);
                date_Left.CurrentValue = UnformatDateTime(date_Left.CurrentValue, date_Left.FormatPattern);
            }
            date_Left.MultiUpdate = CurrentForm.GetValue("u_date_Left");

            // Check field name 'str_CertNumber' before field var 'x_str_CertNumber'
            val = CurrentForm.HasValue("str_CertNumber") ? CurrentForm.GetValue("str_CertNumber") : CurrentForm.GetValue("x_str_CertNumber");
            if (!str_CertNumber.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_CertNumber") && !CurrentForm.HasValue("x_str_CertNumber")) // DN
                    str_CertNumber.Visible = false; // Disable update for API request
                else
                    str_CertNumber.SetFormValue(val);
            }
            str_CertNumber.MultiUpdate = CurrentForm.GetValue("u_str_CertNumber");

            // Check field name 'date_CertExp' before field var 'x_date_CertExp'
            val = CurrentForm.HasValue("date_CertExp") ? CurrentForm.GetValue("date_CertExp") : CurrentForm.GetValue("x_date_CertExp");
            if (!date_CertExp.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_CertExp") && !CurrentForm.HasValue("x_date_CertExp")) // DN
                    date_CertExp.Visible = false; // Disable update for API request
                else
                    date_CertExp.SetFormValue(val);
            }
            date_CertExp.MultiUpdate = CurrentForm.GetValue("u_date_CertExp");

            // Check field name 'str_Cell_Phone' before field var 'x_str_Cell_Phone'
            val = CurrentForm.HasValue("str_Cell_Phone") ? CurrentForm.GetValue("str_Cell_Phone") : CurrentForm.GetValue("x_str_Cell_Phone");
            if (!str_Cell_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Cell_Phone") && !CurrentForm.HasValue("x_str_Cell_Phone")) // DN
                    str_Cell_Phone.Visible = false; // Disable update for API request
                else
                    str_Cell_Phone.SetFormValue(val);
            }
            str_Cell_Phone.MultiUpdate = CurrentForm.GetValue("u_str_Cell_Phone");

            // Check field name 'str_Home_Phone' before field var 'x_str_Home_Phone'
            val = CurrentForm.HasValue("str_Home_Phone") ? CurrentForm.GetValue("str_Home_Phone") : CurrentForm.GetValue("x_str_Home_Phone");
            if (!str_Home_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Home_Phone") && !CurrentForm.HasValue("x_str_Home_Phone")) // DN
                    str_Home_Phone.Visible = false; // Disable update for API request
                else
                    str_Home_Phone.SetFormValue(val);
            }
            str_Home_Phone.MultiUpdate = CurrentForm.GetValue("u_str_Home_Phone");

            // Check field name 'str_Other_Phone' before field var 'x_str_Other_Phone'
            val = CurrentForm.HasValue("str_Other_Phone") ? CurrentForm.GetValue("str_Other_Phone") : CurrentForm.GetValue("x_str_Other_Phone");
            if (!str_Other_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Other_Phone") && !CurrentForm.HasValue("x_str_Other_Phone")) // DN
                    str_Other_Phone.Visible = false; // Disable update for API request
                else
                    str_Other_Phone.SetFormValue(val);
            }
            str_Other_Phone.MultiUpdate = CurrentForm.GetValue("u_str_Other_Phone");

            // Check field name 'str_Email' before field var 'x_str_Email'
            val = CurrentForm.HasValue("str_Email") ? CurrentForm.GetValue("str_Email") : CurrentForm.GetValue("x_str_Email");
            if (!str_Email.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Email") && !CurrentForm.HasValue("x_str_Email")) // DN
                    str_Email.Visible = false; // Disable update for API request
                else
                    str_Email.SetFormValue(val, true, validate);
            }
            str_Email.MultiUpdate = CurrentForm.GetValue("u_str_Email");

            // Check field name 'str_Code' before field var 'x_str_Code'
            val = CurrentForm.HasValue("str_Code") ? CurrentForm.GetValue("str_Code") : CurrentForm.GetValue("x_str_Code");
            if (!str_Code.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Code") && !CurrentForm.HasValue("x_str_Code")) // DN
                    str_Code.Visible = false; // Disable update for API request
                else
                    str_Code.SetFormValue(val);
            }
            str_Code.MultiUpdate = CurrentForm.GetValue("u_str_Code");

            // Check field name 'str_Username' before field var 'x_str_Username'
            val = CurrentForm.HasValue("str_Username") ? CurrentForm.GetValue("str_Username") : CurrentForm.GetValue("x_str_Username");
            if (!str_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Username") && !CurrentForm.HasValue("x_str_Username")) // DN
                    str_Username.Visible = false; // Disable update for API request
                else
                    str_Username.SetFormValue(val);
            }
            str_Username.MultiUpdate = CurrentForm.GetValue("u_str_Username");

            // Check field name 'str_Password' before field var 'x_str_Password'
            val = CurrentForm.HasValue("str_Password") ? CurrentForm.GetValue("str_Password") : CurrentForm.GetValue("x_str_Password");
            if (!str_Password.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Password") && !CurrentForm.HasValue("x_str_Password")) // DN
                    str_Password.Visible = false; // Disable update for API request
                else
                    str_Password.SetFormValue(val);
            }
            str_Password.MultiUpdate = CurrentForm.GetValue("u_str_Password");

            // Check field name 'date_Birth_Hijri' before field var 'x_date_Birth_Hijri'
            val = CurrentForm.HasValue("date_Birth_Hijri") ? CurrentForm.GetValue("date_Birth_Hijri") : CurrentForm.GetValue("x_date_Birth_Hijri");
            if (!date_Birth_Hijri.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Birth_Hijri") && !CurrentForm.HasValue("x_date_Birth_Hijri")) // DN
                    date_Birth_Hijri.Visible = false; // Disable update for API request
                else
                    date_Birth_Hijri.SetFormValue(val, true, validate);
            }
            date_Birth_Hijri.MultiUpdate = CurrentForm.GetValue("u_date_Birth_Hijri");

            // Check field name 'date_Birth' before field var 'x_date_Birth'
            val = CurrentForm.HasValue("date_Birth") ? CurrentForm.GetValue("date_Birth") : CurrentForm.GetValue("x_date_Birth");
            if (!date_Birth.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Birth") && !CurrentForm.HasValue("x_date_Birth")) // DN
                    date_Birth.Visible = false; // Disable update for API request
                else
                    date_Birth.SetFormValue(val, true, validate);
                date_Birth.CurrentValue = UnformatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern);
            }
            date_Birth.MultiUpdate = CurrentForm.GetValue("u_date_Birth");

            // Check field name 'Hijri_Year' before field var 'x_Hijri_Year'
            val = CurrentForm.HasValue("Hijri_Year") ? CurrentForm.GetValue("Hijri_Year") : CurrentForm.GetValue("x_Hijri_Year");
            if (!Hijri_Year.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Year") && !CurrentForm.HasValue("x_Hijri_Year")) // DN
                    Hijri_Year.Visible = false; // Disable update for API request
                else
                    Hijri_Year.SetFormValue(val);
            }
            Hijri_Year.MultiUpdate = CurrentForm.GetValue("u_Hijri_Year");

            // Check field name 'Hijri_Month' before field var 'x_Hijri_Month'
            val = CurrentForm.HasValue("Hijri_Month") ? CurrentForm.GetValue("Hijri_Month") : CurrentForm.GetValue("x_Hijri_Month");
            if (!Hijri_Month.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Month") && !CurrentForm.HasValue("x_Hijri_Month")) // DN
                    Hijri_Month.Visible = false; // Disable update for API request
                else
                    Hijri_Month.SetFormValue(val);
            }
            Hijri_Month.MultiUpdate = CurrentForm.GetValue("u_Hijri_Month");

            // Check field name 'Hijri_Day' before field var 'x_Hijri_Day'
            val = CurrentForm.HasValue("Hijri_Day") ? CurrentForm.GetValue("Hijri_Day") : CurrentForm.GetValue("x_Hijri_Day");
            if (!Hijri_Day.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Day") && !CurrentForm.HasValue("x_Hijri_Day")) // DN
                    Hijri_Day.Visible = false; // Disable update for API request
                else
                    Hijri_Day.SetFormValue(val);
            }
            Hijri_Day.MultiUpdate = CurrentForm.GetValue("u_Hijri_Day");

            // Check field name 'date_Started' before field var 'x_date_Started'
            val = CurrentForm.HasValue("date_Started") ? CurrentForm.GetValue("date_Started") : CurrentForm.GetValue("x_date_Started");
            if (!date_Started.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Started") && !CurrentForm.HasValue("x_date_Started")) // DN
                    date_Started.Visible = false; // Disable update for API request
                else
                    date_Started.SetFormValue(val);
            }
            date_Started.MultiUpdate = CurrentForm.GetValue("u_date_Started");

            // Check field name 'str_DateHired' before field var 'x_str_DateHired'
            val = CurrentForm.HasValue("str_DateHired") ? CurrentForm.GetValue("str_DateHired") : CurrentForm.GetValue("x_str_DateHired");
            if (!str_DateHired.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_DateHired") && !CurrentForm.HasValue("x_str_DateHired")) // DN
                    str_DateHired.Visible = false; // Disable update for API request
                else
                    str_DateHired.SetFormValue(val);
            }
            str_DateHired.MultiUpdate = CurrentForm.GetValue("u_str_DateHired");

            // Check field name 'str_DateLeft' before field var 'x_str_DateLeft'
            val = CurrentForm.HasValue("str_DateLeft") ? CurrentForm.GetValue("str_DateLeft") : CurrentForm.GetValue("x_str_DateLeft");
            if (!str_DateLeft.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_DateLeft") && !CurrentForm.HasValue("x_str_DateLeft")) // DN
                    str_DateLeft.Visible = false; // Disable update for API request
                else
                    str_DateLeft.SetFormValue(val);
            }
            str_DateLeft.MultiUpdate = CurrentForm.GetValue("u_str_DateLeft");

            // Check field name 'str_Emergency_Contact_Name' before field var 'x_str_Emergency_Contact_Name'
            val = CurrentForm.HasValue("str_Emergency_Contact_Name") ? CurrentForm.GetValue("str_Emergency_Contact_Name") : CurrentForm.GetValue("x_str_Emergency_Contact_Name");
            if (!str_Emergency_Contact_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Name") && !CurrentForm.HasValue("x_str_Emergency_Contact_Name")) // DN
                    str_Emergency_Contact_Name.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Name.SetFormValue(val);
            }
            str_Emergency_Contact_Name.MultiUpdate = CurrentForm.GetValue("u_str_Emergency_Contact_Name");

            // Check field name 'str_Emergency_Contact_Phone' before field var 'x_str_Emergency_Contact_Phone'
            val = CurrentForm.HasValue("str_Emergency_Contact_Phone") ? CurrentForm.GetValue("str_Emergency_Contact_Phone") : CurrentForm.GetValue("x_str_Emergency_Contact_Phone");
            if (!str_Emergency_Contact_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Phone") && !CurrentForm.HasValue("x_str_Emergency_Contact_Phone")) // DN
                    str_Emergency_Contact_Phone.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Phone.SetFormValue(val);
            }
            str_Emergency_Contact_Phone.MultiUpdate = CurrentForm.GetValue("u_str_Emergency_Contact_Phone");

            // Check field name 'str_Emergency_Contact_Relation' before field var 'x_str_Emergency_Contact_Relation'
            val = CurrentForm.HasValue("str_Emergency_Contact_Relation") ? CurrentForm.GetValue("str_Emergency_Contact_Relation") : CurrentForm.GetValue("x_str_Emergency_Contact_Relation");
            if (!str_Emergency_Contact_Relation.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Relation") && !CurrentForm.HasValue("x_str_Emergency_Contact_Relation")) // DN
                    str_Emergency_Contact_Relation.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Relation.SetFormValue(val);
            }
            str_Emergency_Contact_Relation.MultiUpdate = CurrentForm.GetValue("u_str_Emergency_Contact_Relation");

            // Check field name 'str_Notes' before field var 'x_str_Notes'
            val = CurrentForm.HasValue("str_Notes") ? CurrentForm.GetValue("str_Notes") : CurrentForm.GetValue("x_str_Notes");
            if (!str_Notes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Notes") && !CurrentForm.HasValue("x_str_Notes")) // DN
                    str_Notes.Visible = false; // Disable update for API request
                else
                    str_Notes.SetFormValue(val);
            }
            str_Notes.MultiUpdate = CurrentForm.GetValue("u_str_Notes");

            // Check field name 'int_ClassType' before field var 'x_int_ClassType'
            val = CurrentForm.HasValue("int_ClassType") ? CurrentForm.GetValue("int_ClassType") : CurrentForm.GetValue("x_int_ClassType");
            if (!int_ClassType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_ClassType") && !CurrentForm.HasValue("x_int_ClassType")) // DN
                    int_ClassType.Visible = false; // Disable update for API request
                else
                    int_ClassType.SetFormValue(val, true, validate);
            }
            int_ClassType.MultiUpdate = CurrentForm.GetValue("u_int_ClassType");

            // Check field name 'str_ZipCodes' before field var 'x_str_ZipCodes'
            val = CurrentForm.HasValue("str_ZipCodes") ? CurrentForm.GetValue("str_ZipCodes") : CurrentForm.GetValue("x_str_ZipCodes");
            if (!str_ZipCodes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ZipCodes") && !CurrentForm.HasValue("x_str_ZipCodes")) // DN
                    str_ZipCodes.Visible = false; // Disable update for API request
                else
                    str_ZipCodes.SetFormValue(val);
            }
            str_ZipCodes.MultiUpdate = CurrentForm.GetValue("u_str_ZipCodes");

            // Check field name 'int_VehicleAssigned' before field var 'x_int_VehicleAssigned'
            val = CurrentForm.HasValue("int_VehicleAssigned") ? CurrentForm.GetValue("int_VehicleAssigned") : CurrentForm.GetValue("x_int_VehicleAssigned");
            if (!int_VehicleAssigned.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_VehicleAssigned") && !CurrentForm.HasValue("x_int_VehicleAssigned")) // DN
                    int_VehicleAssigned.Visible = false; // Disable update for API request
                else
                    int_VehicleAssigned.SetFormValue(val, true, validate);
            }
            int_VehicleAssigned.MultiUpdate = CurrentForm.GetValue("u_int_VehicleAssigned");

            // Check field name 'int_Status' before field var 'x_int_Status'
            val = CurrentForm.HasValue("int_Status") ? CurrentForm.GetValue("int_Status") : CurrentForm.GetValue("x_int_Status");
            if (!int_Status.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Status") && !CurrentForm.HasValue("x_int_Status")) // DN
                    int_Status.Visible = false; // Disable update for API request
                else
                    int_Status.SetFormValue(val, true, validate);
            }
            int_Status.MultiUpdate = CurrentForm.GetValue("u_int_Status");

            // Check field name 'int_Type' before field var 'x_int_Type'
            val = CurrentForm.HasValue("int_Type") ? CurrentForm.GetValue("int_Type") : CurrentForm.GetValue("x_int_Type");
            if (!int_Type.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Type") && !CurrentForm.HasValue("x_int_Type")) // DN
                    int_Type.Visible = false; // Disable update for API request
                else
                    int_Type.SetFormValue(val, true, validate);
            }
            int_Type.MultiUpdate = CurrentForm.GetValue("u_int_Type");

            // Check field name 'int_Location' before field var 'x_int_Location'
            val = CurrentForm.HasValue("int_Location") ? CurrentForm.GetValue("int_Location") : CurrentForm.GetValue("x_int_Location");
            if (!int_Location.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Location") && !CurrentForm.HasValue("x_int_Location")) // DN
                    int_Location.Visible = false; // Disable update for API request
                else
                    int_Location.SetFormValue(val, true, validate);
            }
            int_Location.MultiUpdate = CurrentForm.GetValue("u_int_Location");

            // Check field name 'date_Created' before field var 'x_date_Created'
            val = CurrentForm.HasValue("date_Created") ? CurrentForm.GetValue("date_Created") : CurrentForm.GetValue("x_date_Created");
            if (!date_Created.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Created") && !CurrentForm.HasValue("x_date_Created")) // DN
                    date_Created.Visible = false; // Disable update for API request
                else
                    date_Created.SetFormValue(val);
                date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            }
            date_Created.MultiUpdate = CurrentForm.GetValue("u_date_Created");

            // Check field name 'date_Modified' before field var 'x_date_Modified'
            val = CurrentForm.HasValue("date_Modified") ? CurrentForm.GetValue("date_Modified") : CurrentForm.GetValue("x_date_Modified");
            if (!date_Modified.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Modified") && !CurrentForm.HasValue("x_date_Modified")) // DN
                    date_Modified.Visible = false; // Disable update for API request
                else
                    date_Modified.SetFormValue(val);
                date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            }
            date_Modified.MultiUpdate = CurrentForm.GetValue("u_date_Modified");

            // Check field name 'int_Created_By' before field var 'x_int_Created_By'
            val = CurrentForm.HasValue("int_Created_By") ? CurrentForm.GetValue("int_Created_By") : CurrentForm.GetValue("x_int_Created_By");
            if (!int_Created_By.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Created_By") && !CurrentForm.HasValue("x_int_Created_By")) // DN
                    int_Created_By.Visible = false; // Disable update for API request
                else
                    int_Created_By.SetFormValue(val);
            }
            int_Created_By.MultiUpdate = CurrentForm.GetValue("u_int_Created_By");

            // Check field name 'int_Modified_By' before field var 'x_int_Modified_By'
            val = CurrentForm.HasValue("int_Modified_By") ? CurrentForm.GetValue("int_Modified_By") : CurrentForm.GetValue("x_int_Modified_By");
            if (!int_Modified_By.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Modified_By") && !CurrentForm.HasValue("x_int_Modified_By")) // DN
                    int_Modified_By.Visible = false; // Disable update for API request
                else
                    int_Modified_By.SetFormValue(val, true, validate);
            }
            int_Modified_By.MultiUpdate = CurrentForm.GetValue("u_int_Modified_By");

            // Check field name 'bit_IsDeleted' before field var 'x_bit_IsDeleted'
            val = CurrentForm.HasValue("bit_IsDeleted") ? CurrentForm.GetValue("bit_IsDeleted") : CurrentForm.GetValue("x_bit_IsDeleted");
            if (!bit_IsDeleted.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsDeleted") && !CurrentForm.HasValue("x_bit_IsDeleted")) // DN
                    bit_IsDeleted.Visible = false; // Disable update for API request
                else
                    bit_IsDeleted.SetFormValue(val);
            }
            bit_IsDeleted.MultiUpdate = CurrentForm.GetValue("u_bit_IsDeleted");

            // Check field name 'str_InstPermitNo' before field var 'x_str_InstPermitNo'
            val = CurrentForm.HasValue("str_InstPermitNo") ? CurrentForm.GetValue("str_InstPermitNo") : CurrentForm.GetValue("x_str_InstPermitNo");
            if (!str_InstPermitNo.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_InstPermitNo") && !CurrentForm.HasValue("x_str_InstPermitNo")) // DN
                    str_InstPermitNo.Visible = false; // Disable update for API request
                else
                    str_InstPermitNo.SetFormValue(val);
            }
            str_InstPermitNo.MultiUpdate = CurrentForm.GetValue("u_str_InstPermitNo");

            // Check field name 'date_PermitExpiration' before field var 'x_date_PermitExpiration'
            val = CurrentForm.HasValue("date_PermitExpiration") ? CurrentForm.GetValue("date_PermitExpiration") : CurrentForm.GetValue("x_date_PermitExpiration");
            if (!date_PermitExpiration.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_PermitExpiration") && !CurrentForm.HasValue("x_date_PermitExpiration")) // DN
                    date_PermitExpiration.Visible = false; // Disable update for API request
                else
                    date_PermitExpiration.SetFormValue(val);
            }
            date_PermitExpiration.MultiUpdate = CurrentForm.GetValue("u_date_PermitExpiration");

            // Check field name 'date_InCarPermitIssue' before field var 'x_date_InCarPermitIssue'
            val = CurrentForm.HasValue("date_InCarPermitIssue") ? CurrentForm.GetValue("date_InCarPermitIssue") : CurrentForm.GetValue("x_date_InCarPermitIssue");
            if (!date_InCarPermitIssue.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_InCarPermitIssue") && !CurrentForm.HasValue("x_date_InCarPermitIssue")) // DN
                    date_InCarPermitIssue.Visible = false; // Disable update for API request
                else
                    date_InCarPermitIssue.SetFormValue(val);
            }
            date_InCarPermitIssue.MultiUpdate = CurrentForm.GetValue("u_date_InCarPermitIssue");

            // Check field name 'str_InClassPermitNo' before field var 'x_str_InClassPermitNo'
            val = CurrentForm.HasValue("str_InClassPermitNo") ? CurrentForm.GetValue("str_InClassPermitNo") : CurrentForm.GetValue("x_str_InClassPermitNo");
            if (!str_InClassPermitNo.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_InClassPermitNo") && !CurrentForm.HasValue("x_str_InClassPermitNo")) // DN
                    str_InClassPermitNo.Visible = false; // Disable update for API request
                else
                    str_InClassPermitNo.SetFormValue(val);
            }
            str_InClassPermitNo.MultiUpdate = CurrentForm.GetValue("u_str_InClassPermitNo");

            // Check field name 'date_InClassPermitIssue' before field var 'x_date_InClassPermitIssue'
            val = CurrentForm.HasValue("date_InClassPermitIssue") ? CurrentForm.GetValue("date_InClassPermitIssue") : CurrentForm.GetValue("x_date_InClassPermitIssue");
            if (!date_InClassPermitIssue.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_InClassPermitIssue") && !CurrentForm.HasValue("x_date_InClassPermitIssue")) // DN
                    date_InClassPermitIssue.Visible = false; // Disable update for API request
                else
                    date_InClassPermitIssue.SetFormValue(val);
            }
            date_InClassPermitIssue.MultiUpdate = CurrentForm.GetValue("u_date_InClassPermitIssue");

            // Check field name 'instructor_caption' before field var 'x_instructor_caption'
            val = CurrentForm.HasValue("instructor_caption") ? CurrentForm.GetValue("instructor_caption") : CurrentForm.GetValue("x_instructor_caption");
            if (!instructor_caption.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("instructor_caption") && !CurrentForm.HasValue("x_instructor_caption")) // DN
                    instructor_caption.Visible = false; // Disable update for API request
                else
                    instructor_caption.SetFormValue(val);
            }
            instructor_caption.MultiUpdate = CurrentForm.GetValue("u_instructor_caption");

            // Check field name 'str_LicType' before field var 'x_str_LicType'
            val = CurrentForm.HasValue("str_LicType") ? CurrentForm.GetValue("str_LicType") : CurrentForm.GetValue("x_str_LicType");
            if (!str_LicType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_LicType") && !CurrentForm.HasValue("x_str_LicType")) // DN
                    str_LicType.Visible = false; // Disable update for API request
                else
                    str_LicType.SetFormValue(val);
            }
            str_LicType.MultiUpdate = CurrentForm.GetValue("u_str_LicType");

            // Check field name 'int_Order' before field var 'x_int_Order'
            val = CurrentForm.HasValue("int_Order") ? CurrentForm.GetValue("int_Order") : CurrentForm.GetValue("x_int_Order");
            if (!int_Order.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Order") && !CurrentForm.HasValue("x_int_Order")) // DN
                    int_Order.Visible = false; // Disable update for API request
                else
                    int_Order.SetFormValue(val, true, validate);
            }
            int_Order.MultiUpdate = CurrentForm.GetValue("u_int_Order");

            // Check field name 'str_InstLicenceDate' before field var 'x_str_InstLicenceDate'
            val = CurrentForm.HasValue("str_InstLicenceDate") ? CurrentForm.GetValue("str_InstLicenceDate") : CurrentForm.GetValue("x_str_InstLicenceDate");
            if (!str_InstLicenceDate.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_InstLicenceDate") && !CurrentForm.HasValue("x_str_InstLicenceDate")) // DN
                    str_InstLicenceDate.Visible = false; // Disable update for API request
                else
                    str_InstLicenceDate.SetFormValue(val);
            }
            str_InstLicenceDate.MultiUpdate = CurrentForm.GetValue("u_str_InstLicenceDate");

            // Check field name 'str_DLNum' before field var 'x_str_DLNum'
            val = CurrentForm.HasValue("str_DLNum") ? CurrentForm.GetValue("str_DLNum") : CurrentForm.GetValue("x_str_DLNum");
            if (!str_DLNum.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_DLNum") && !CurrentForm.HasValue("x_str_DLNum")) // DN
                    str_DLNum.Visible = false; // Disable update for API request
                else
                    str_DLNum.SetFormValue(val);
            }
            str_DLNum.MultiUpdate = CurrentForm.GetValue("u_str_DLNum");

            // Check field name 'str_DLExp' before field var 'x_str_DLExp'
            val = CurrentForm.HasValue("str_DLExp") ? CurrentForm.GetValue("str_DLExp") : CurrentForm.GetValue("x_str_DLExp");
            if (!str_DLExp.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_DLExp") && !CurrentForm.HasValue("x_str_DLExp")) // DN
                    str_DLExp.Visible = false; // Disable update for API request
                else
                    str_DLExp.SetFormValue(val);
            }
            str_DLExp.MultiUpdate = CurrentForm.GetValue("u_str_DLExp");

            // Check field name 'bit_appointmentColor' before field var 'x_bit_appointmentColor'
            val = CurrentForm.HasValue("bit_appointmentColor") ? CurrentForm.GetValue("bit_appointmentColor") : CurrentForm.GetValue("x_bit_appointmentColor");
            if (!bit_appointmentColor.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_appointmentColor") && !CurrentForm.HasValue("x_bit_appointmentColor")) // DN
                    bit_appointmentColor.Visible = false; // Disable update for API request
                else
                    bit_appointmentColor.SetFormValue(val);
            }
            bit_appointmentColor.MultiUpdate = CurrentForm.GetValue("u_bit_appointmentColor");

            // Check field name 'str_appointmentColorCode' before field var 'x_str_appointmentColorCode'
            val = CurrentForm.HasValue("str_appointmentColorCode") ? CurrentForm.GetValue("str_appointmentColorCode") : CurrentForm.GetValue("x_str_appointmentColorCode");
            if (!str_appointmentColorCode.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_appointmentColorCode") && !CurrentForm.HasValue("x_str_appointmentColorCode")) // DN
                    str_appointmentColorCode.Visible = false; // Disable update for API request
                else
                    str_appointmentColorCode.SetFormValue(val);
            }
            str_appointmentColorCode.MultiUpdate = CurrentForm.GetValue("u_str_appointmentColorCode");

            // Check field name 'bit_IsSuperAdmin' before field var 'x_bit_IsSuperAdmin'
            val = CurrentForm.HasValue("bit_IsSuperAdmin") ? CurrentForm.GetValue("bit_IsSuperAdmin") : CurrentForm.GetValue("x_bit_IsSuperAdmin");
            if (!bit_IsSuperAdmin.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("bit_IsSuperAdmin") && !CurrentForm.HasValue("x_bit_IsSuperAdmin")) // DN
                    bit_IsSuperAdmin.Visible = false; // Disable update for API request
                else
                    bit_IsSuperAdmin.SetFormValue(val);
            }
            bit_IsSuperAdmin.MultiUpdate = CurrentForm.GetValue("u_bit_IsSuperAdmin");

            // Check field name 'IsDistanceBasedScheduling' before field var 'x_IsDistanceBasedScheduling'
            val = CurrentForm.HasValue("IsDistanceBasedScheduling") ? CurrentForm.GetValue("IsDistanceBasedScheduling") : CurrentForm.GetValue("x_IsDistanceBasedScheduling");
            if (!IsDistanceBasedScheduling.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDistanceBasedScheduling") && !CurrentForm.HasValue("x_IsDistanceBasedScheduling")) // DN
                    IsDistanceBasedScheduling.Visible = false; // Disable update for API request
                else
                    IsDistanceBasedScheduling.SetFormValue(val, true, validate);
            }
            IsDistanceBasedScheduling.MultiUpdate = CurrentForm.GetValue("u_IsDistanceBasedScheduling");

            // Check field name 'str_Package_Code' before field var 'x_str_Package_Code'
            val = CurrentForm.HasValue("str_Package_Code") ? CurrentForm.GetValue("str_Package_Code") : CurrentForm.GetValue("x_str_Package_Code");
            if (!str_Package_Code.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Package_Code") && !CurrentForm.HasValue("x_str_Package_Code")) // DN
                    str_Package_Code.Visible = false; // Disable update for API request
                else
                    str_Package_Code.SetFormValue(val);
            }
            str_Package_Code.MultiUpdate = CurrentForm.GetValue("u_str_Package_Code");

            // Check field name 'str_NationalID_Iqama' before field var 'x_str_NationalID_Iqama'
            val = CurrentForm.HasValue("str_NationalID_Iqama") ? CurrentForm.GetValue("str_NationalID_Iqama") : CurrentForm.GetValue("x_str_NationalID_Iqama");
            if (!str_NationalID_Iqama.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_NationalID_Iqama") && !CurrentForm.HasValue("x_str_NationalID_Iqama")) // DN
                    str_NationalID_Iqama.Visible = false; // Disable update for API request
                else
                    str_NationalID_Iqama.SetFormValue(val, true, validate);
            }
            str_NationalID_Iqama.MultiUpdate = CurrentForm.GetValue("u_str_NationalID_Iqama");

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val, true, validate);
            }
            NationalID.MultiUpdate = CurrentForm.GetValue("u_NationalID");

            // Check field name 'int_RoadDistanceCoverage' before field var 'x_int_RoadDistanceCoverage'
            val = CurrentForm.HasValue("int_RoadDistanceCoverage") ? CurrentForm.GetValue("int_RoadDistanceCoverage") : CurrentForm.GetValue("x_int_RoadDistanceCoverage");
            if (!int_RoadDistanceCoverage.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_RoadDistanceCoverage") && !CurrentForm.HasValue("x_int_RoadDistanceCoverage")) // DN
                    int_RoadDistanceCoverage.Visible = false; // Disable update for API request
                else
                    int_RoadDistanceCoverage.SetFormValue(val);
            }
            int_RoadDistanceCoverage.MultiUpdate = CurrentForm.GetValue("u_int_RoadDistanceCoverage");

            // Check field name 'str_Badge' before field var 'x_str_Badge'
            val = CurrentForm.HasValue("str_Badge") ? CurrentForm.GetValue("str_Badge") : CurrentForm.GetValue("x_str_Badge");
            if (!str_Badge.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Badge") && !CurrentForm.HasValue("x_str_Badge")) // DN
                    str_Badge.Visible = false; // Disable update for API request
                else
                    str_Badge.SetFormValue(val);
            }
            str_Badge.MultiUpdate = CurrentForm.GetValue("u_str_Badge");

            // Check field name 'strZoomHostUrl' before field var 'x_strZoomHostUrl'
            val = CurrentForm.HasValue("strZoomHostUrl") ? CurrentForm.GetValue("strZoomHostUrl") : CurrentForm.GetValue("x_strZoomHostUrl");
            if (!strZoomHostUrl.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("strZoomHostUrl") && !CurrentForm.HasValue("x_strZoomHostUrl")) // DN
                    strZoomHostUrl.Visible = false; // Disable update for API request
                else
                    strZoomHostUrl.SetFormValue(val);
            }
            strZoomHostUrl.MultiUpdate = CurrentForm.GetValue("u_strZoomHostUrl");

            // Check field name 'strZoomUserUrl' before field var 'x_strZoomUserUrl'
            val = CurrentForm.HasValue("strZoomUserUrl") ? CurrentForm.GetValue("strZoomUserUrl") : CurrentForm.GetValue("x_strZoomUserUrl");
            if (!strZoomUserUrl.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("strZoomUserUrl") && !CurrentForm.HasValue("x_strZoomUserUrl")) // DN
                    strZoomUserUrl.Visible = false; // Disable update for API request
                else
                    strZoomUserUrl.SetFormValue(val);
            }
            strZoomUserUrl.MultiUpdate = CurrentForm.GetValue("u_strZoomUserUrl");

            // Check field name 'str_VehicleType' before field var 'x_str_VehicleType'
            val = CurrentForm.HasValue("str_VehicleType") ? CurrentForm.GetValue("str_VehicleType") : CurrentForm.GetValue("x_str_VehicleType");
            if (!str_VehicleType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_VehicleType") && !CurrentForm.HasValue("x_str_VehicleType")) // DN
                    str_VehicleType.Visible = false; // Disable update for API request
                else
                    str_VehicleType.SetFormValue(val);
            }
            str_VehicleType.MultiUpdate = CurrentForm.GetValue("u_str_VehicleType");

            // Check field name 'ProfilePicturePath' before field var 'x_ProfilePicturePath'
            val = CurrentForm.HasValue("ProfilePicturePath") ? CurrentForm.GetValue("ProfilePicturePath") : CurrentForm.GetValue("x_ProfilePicturePath");
            if (!ProfilePicturePath.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("ProfilePicturePath") && !CurrentForm.HasValue("x_ProfilePicturePath")) // DN
                    ProfilePicturePath.Visible = false; // Disable update for API request
                else
                    ProfilePicturePath.SetFormValue(val);
            }
            ProfilePicturePath.MultiUpdate = CurrentForm.GetValue("u_ProfilePicturePath");

            // Check field name 'Institution' before field var 'x_Institution'
            val = CurrentForm.HasValue("Institution") ? CurrentForm.GetValue("Institution") : CurrentForm.GetValue("x_Institution");
            if (!Institution.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Institution") && !CurrentForm.HasValue("x_Institution")) // DN
                    Institution.Visible = false; // Disable update for API request
                else
                    Institution.SetFormValue(val);
            }
            Institution.MultiUpdate = CurrentForm.GetValue("u_Institution");

            // Check field name 'IsDrivingexperience' before field var 'x_IsDrivingexperience'
            val = CurrentForm.HasValue("IsDrivingexperience") ? CurrentForm.GetValue("IsDrivingexperience") : CurrentForm.GetValue("x_IsDrivingexperience");
            if (!IsDrivingexperience.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDrivingexperience") && !CurrentForm.HasValue("x_IsDrivingexperience")) // DN
                    IsDrivingexperience.Visible = false; // Disable update for API request
                else
                    IsDrivingexperience.SetFormValue(val);
            }
            IsDrivingexperience.MultiUpdate = CurrentForm.GetValue("u_IsDrivingexperience");

            // Check field name 'intDrivinglicenseType' before field var 'x_intDrivinglicenseType'
            val = CurrentForm.HasValue("intDrivinglicenseType") ? CurrentForm.GetValue("intDrivinglicenseType") : CurrentForm.GetValue("x_intDrivinglicenseType");
            if (!intDrivinglicenseType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("intDrivinglicenseType") && !CurrentForm.HasValue("x_intDrivinglicenseType")) // DN
                    intDrivinglicenseType.Visible = false; // Disable update for API request
                else
                    intDrivinglicenseType.SetFormValue(val);
            }
            intDrivinglicenseType.MultiUpdate = CurrentForm.GetValue("u_intDrivinglicenseType");

            // Check field name 'AbsherApptNbr' before field var 'x_AbsherApptNbr'
            val = CurrentForm.HasValue("AbsherApptNbr") ? CurrentForm.GetValue("AbsherApptNbr") : CurrentForm.GetValue("x_AbsherApptNbr");
            if (!AbsherApptNbr.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AbsherApptNbr") && !CurrentForm.HasValue("x_AbsherApptNbr")) // DN
                    AbsherApptNbr.Visible = false; // Disable update for API request
                else
                    AbsherApptNbr.SetFormValue(val);
            }
            AbsherApptNbr.MultiUpdate = CurrentForm.GetValue("u_AbsherApptNbr");

            // Check field name 'ProfileField' before field var 'x_ProfileField'
            val = CurrentForm.HasValue("ProfileField") ? CurrentForm.GetValue("ProfileField") : CurrentForm.GetValue("x_ProfileField");
            if (!ProfileField.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("ProfileField") && !CurrentForm.HasValue("x_ProfileField")) // DN
                    ProfileField.Visible = false; // Disable update for API request
                else
                    ProfileField.SetFormValue(val);
            }
            ProfileField.MultiUpdate = CurrentForm.GetValue("u_ProfileField");

            // Check field name 'UserlevelID' before field var 'x_UserlevelID'
            val = CurrentForm.HasValue("UserlevelID") ? CurrentForm.GetValue("UserlevelID") : CurrentForm.GetValue("x_UserlevelID");
            if (!UserlevelID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("UserlevelID") && !CurrentForm.HasValue("x_UserlevelID")) // DN
                    UserlevelID.Visible = false; // Disable update for API request
                else
                    UserlevelID.SetFormValue(val);
            }
            UserlevelID.MultiUpdate = CurrentForm.GetValue("u_UserlevelID");

            // Check field name 'Parent_Username' before field var 'x_Parent_Username'
            val = CurrentForm.HasValue("Parent_Username") ? CurrentForm.GetValue("Parent_Username") : CurrentForm.GetValue("x_Parent_Username");
            if (!Parent_Username.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Parent_Username") && !CurrentForm.HasValue("x_Parent_Username")) // DN
                    Parent_Username.Visible = false; // Disable update for API request
                else
                    Parent_Username.SetFormValue(val);
            }
            Parent_Username.MultiUpdate = CurrentForm.GetValue("u_Parent_Username");

            // Check field name 'Activated' before field var 'x_Activated'
            val = CurrentForm.HasValue("Activated") ? CurrentForm.GetValue("Activated") : CurrentForm.GetValue("x_Activated");
            if (!Activated.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Activated") && !CurrentForm.HasValue("x_Activated")) // DN
                    Activated.Visible = false; // Disable update for API request
                else
                    Activated.SetFormValue(val);
            }
            Activated.MultiUpdate = CurrentForm.GetValue("u_Activated");

            // Check field name 'int_Nationality' before field var 'x_int_Nationality'
            val = CurrentForm.HasValue("int_Nationality") ? CurrentForm.GetValue("int_Nationality") : CurrentForm.GetValue("x_int_Nationality");
            if (!int_Nationality.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Nationality") && !CurrentForm.HasValue("x_int_Nationality")) // DN
                    int_Nationality.Visible = false; // Disable update for API request
                else
                    int_Nationality.SetFormValue(val, true, validate);
            }
            int_Nationality.MultiUpdate = CurrentForm.GetValue("u_int_Nationality");

            // Check field name 'User_Role' before field var 'x_User_Role'
            val = CurrentForm.HasValue("User_Role") ? CurrentForm.GetValue("User_Role") : CurrentForm.GetValue("x_User_Role");
            if (!User_Role.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("User_Role") && !CurrentForm.HasValue("x_User_Role")) // DN
                    User_Role.Visible = false; // Disable update for API request
                else
                    User_Role.SetFormValue(val);
            }
            User_Role.MultiUpdate = CurrentForm.GetValue("u_User_Role");

            // Check field name 'int_Staff_Id' before field var 'x_int_Staff_Id'
            val = CurrentForm.HasValue("int_Staff_Id") ? CurrentForm.GetValue("int_Staff_Id") : CurrentForm.GetValue("x_int_Staff_Id");
            if (!int_Staff_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Staff_Id") && !CurrentForm.HasValue("x_int_Staff_Id")) // DN
                    int_Staff_Id.Visible = false; // Disable update for API request
                else
                    int_Staff_Id.SetFormValue(val, true, validate);
            }
            int_Staff_Id.MultiUpdate = CurrentForm.GetValue("u_int_Staff_Id");

            // Check field name 'int_Student_ID' before field var 'x_int_Student_ID'
            val = CurrentForm.HasValue("int_Student_ID") ? CurrentForm.GetValue("int_Student_ID") : CurrentForm.GetValue("x_int_Student_ID");
            if (!int_Student_ID.IsDetailKey)
                int_Student_ID.SetFormValue(val);
            await GetUploadFiles(); // Get upload files
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Student_ID.CurrentValue = int_Student_ID.FormValue;
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Middle_Name.CurrentValue = str_Middle_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            str_Address.CurrentValue = str_Address.FormValue;
            str_City.CurrentValue = str_City.FormValue;
            int_State.CurrentValue = int_State.FormValue;
            str_Zip.CurrentValue = str_Zip.FormValue;
            date_Hired.CurrentValue = date_Hired.FormValue;
            date_Hired.CurrentValue = UnformatDateTime(date_Hired.CurrentValue, date_Hired.FormatPattern);
            date_Left.CurrentValue = date_Left.FormValue;
            date_Left.CurrentValue = UnformatDateTime(date_Left.CurrentValue, date_Left.FormatPattern);
            str_CertNumber.CurrentValue = str_CertNumber.FormValue;
            date_CertExp.CurrentValue = date_CertExp.FormValue;
            str_Cell_Phone.CurrentValue = str_Cell_Phone.FormValue;
            str_Home_Phone.CurrentValue = str_Home_Phone.FormValue;
            str_Other_Phone.CurrentValue = str_Other_Phone.FormValue;
            str_Email.CurrentValue = str_Email.FormValue;
            str_Code.CurrentValue = str_Code.FormValue;
            str_Username.CurrentValue = str_Username.FormValue;
            str_Password.CurrentValue = str_Password.FormValue;
            date_Birth_Hijri.CurrentValue = date_Birth_Hijri.FormValue;
            date_Birth.CurrentValue = date_Birth.FormValue;
            date_Birth.CurrentValue = UnformatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern);
            Hijri_Year.CurrentValue = Hijri_Year.FormValue;
            Hijri_Month.CurrentValue = Hijri_Month.FormValue;
            Hijri_Day.CurrentValue = Hijri_Day.FormValue;
            date_Started.CurrentValue = date_Started.FormValue;
            str_DateHired.CurrentValue = str_DateHired.FormValue;
            str_DateLeft.CurrentValue = str_DateLeft.FormValue;
            str_Emergency_Contact_Name.CurrentValue = str_Emergency_Contact_Name.FormValue;
            str_Emergency_Contact_Phone.CurrentValue = str_Emergency_Contact_Phone.FormValue;
            str_Emergency_Contact_Relation.CurrentValue = str_Emergency_Contact_Relation.FormValue;
            str_Notes.CurrentValue = str_Notes.FormValue;
            int_ClassType.CurrentValue = int_ClassType.FormValue;
            str_ZipCodes.CurrentValue = str_ZipCodes.FormValue;
            int_VehicleAssigned.CurrentValue = int_VehicleAssigned.FormValue;
            int_Status.CurrentValue = int_Status.FormValue;
            int_Type.CurrentValue = int_Type.FormValue;
            int_Location.CurrentValue = int_Location.FormValue;
            date_Created.CurrentValue = date_Created.FormValue;
            date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            date_Modified.CurrentValue = date_Modified.FormValue;
            date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            int_Created_By.CurrentValue = int_Created_By.FormValue;
            int_Modified_By.CurrentValue = int_Modified_By.FormValue;
            bit_IsDeleted.CurrentValue = bit_IsDeleted.FormValue;
            str_InstPermitNo.CurrentValue = str_InstPermitNo.FormValue;
            date_PermitExpiration.CurrentValue = date_PermitExpiration.FormValue;
            date_InCarPermitIssue.CurrentValue = date_InCarPermitIssue.FormValue;
            str_InClassPermitNo.CurrentValue = str_InClassPermitNo.FormValue;
            date_InClassPermitIssue.CurrentValue = date_InClassPermitIssue.FormValue;
            instructor_caption.CurrentValue = instructor_caption.FormValue;
            str_LicType.CurrentValue = str_LicType.FormValue;
            int_Order.CurrentValue = int_Order.FormValue;
            str_InstLicenceDate.CurrentValue = str_InstLicenceDate.FormValue;
            str_DLNum.CurrentValue = str_DLNum.FormValue;
            str_DLExp.CurrentValue = str_DLExp.FormValue;
            bit_appointmentColor.CurrentValue = bit_appointmentColor.FormValue;
            str_appointmentColorCode.CurrentValue = str_appointmentColorCode.FormValue;
            bit_IsSuperAdmin.CurrentValue = bit_IsSuperAdmin.FormValue;
            IsDistanceBasedScheduling.CurrentValue = IsDistanceBasedScheduling.FormValue;
            str_Package_Code.CurrentValue = str_Package_Code.FormValue;
            str_NationalID_Iqama.CurrentValue = str_NationalID_Iqama.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            int_RoadDistanceCoverage.CurrentValue = int_RoadDistanceCoverage.FormValue;
            str_Badge.CurrentValue = str_Badge.FormValue;
            strZoomHostUrl.CurrentValue = strZoomHostUrl.FormValue;
            strZoomUserUrl.CurrentValue = strZoomUserUrl.FormValue;
            str_VehicleType.CurrentValue = str_VehicleType.FormValue;
            ProfilePicturePath.CurrentValue = ProfilePicturePath.FormValue;
            Institution.CurrentValue = Institution.FormValue;
            IsDrivingexperience.CurrentValue = IsDrivingexperience.FormValue;
            intDrivinglicenseType.CurrentValue = intDrivinglicenseType.FormValue;
            AbsherApptNbr.CurrentValue = AbsherApptNbr.FormValue;
            ProfileField.CurrentValue = ProfileField.FormValue;
            UserlevelID.CurrentValue = UserlevelID.FormValue;
            Parent_Username.CurrentValue = Parent_Username.FormValue;
            Activated.CurrentValue = Activated.FormValue;
            int_Nationality.CurrentValue = int_Nationality.FormValue;
            User_Role.CurrentValue = User_Role.FormValue;
            int_Staff_Id.CurrentValue = int_Staff_Id.FormValue;
        }

        // Load recordset // DN
        public async Task<DbDataReader?> LoadRecordset(int offset = -1, int rowcnt = -1)
        {
            // Load list page SQL
            string sql = ListSql;

            // Load recordset // DN
            var dr = await Connection.SelectLimit(sql, rowcnt, offset, !Empty(OrderBy) || !Empty(SessionOrderBy));

            // Call Recordset Selected event
            RecordsetSelected(dr);
            return dr;
        }

        // Load rows // DN
        public async Task<List<Dictionary<string, object>>> LoadRows(int offset = -1, int rowcnt = -1)
        {
            // Load list page SQL
            string sql = ListSql;

            // Load rows // DN
            using var dr = await Connection.SelectLimit(sql, rowcnt, offset, !Empty(OrderBy) || !Empty(SessionOrderBy));
            var rows = await Connection.GetRowsAsync(dr);
            dr.Close(); // Close datareader before return
            return rows;
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
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            str_First_Name.SetDbValue(row["str_First_Name"]);
            str_Middle_Name.SetDbValue(row["str_Middle_Name"]);
            str_Last_Name.SetDbValue(row["str_Last_Name"]);
            str_Full_Name.SetDbValue(row["str_Full_Name"]);
            str_Address.SetDbValue(row["str_Address"]);
            str_City.SetDbValue(row["str_City"]);
            int_State.SetDbValue(row["int_State"]);
            str_Zip.SetDbValue(row["str_Zip"]);
            date_Hired.SetDbValue(row["date_Hired"]);
            date_Left.SetDbValue(row["date_Left"]);
            str_CertNumber.SetDbValue(row["str_CertNumber"]);
            date_CertExp.SetDbValue(row["date_CertExp"]);
            str_Cell_Phone.SetDbValue(row["str_Cell_Phone"]);
            str_Home_Phone.SetDbValue(row["str_Home_Phone"]);
            str_Other_Phone.SetDbValue(row["str_Other_Phone"]);
            str_Email.SetDbValue(row["str_Email"]);
            str_Code.SetDbValue(row["str_Code"]);
            str_Username.SetDbValue(row["str_Username"]);
            str_Password.SetDbValue(row["str_Password"]);
            date_Birth_Hijri.SetDbValue(row["date_Birth_Hijri"]);
            date_Birth.SetDbValue(row["date_Birth"]);
            Hijri_Year.SetDbValue(row["Hijri_Year"]);
            Hijri_Month.SetDbValue(row["Hijri_Month"]);
            Hijri_Day.SetDbValue(row["Hijri_Day"]);
            date_Started.SetDbValue(row["date_Started"]);
            str_DateHired.SetDbValue(row["str_DateHired"]);
            str_DateLeft.SetDbValue(row["str_DateLeft"]);
            str_Emergency_Contact_Name.SetDbValue(row["str_Emergency_Contact_Name"]);
            str_Emergency_Contact_Phone.SetDbValue(row["str_Emergency_Contact_Phone"]);
            str_Emergency_Contact_Relation.SetDbValue(row["str_Emergency_Contact_Relation"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            int_ClassType.SetDbValue(row["int_ClassType"]);
            str_ZipCodes.SetDbValue(row["str_ZipCodes"]);
            int_VehicleAssigned.SetDbValue(row["int_VehicleAssigned"]);
            int_Status.SetDbValue(row["int_Status"]);
            int_Type.SetDbValue(row["int_Type"]);
            int_Location.SetDbValue(row["int_Location"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            int_Created_By.SetDbValue(IsNull(row["int_Created_By"]) ? DbNullValue : ConvertToDouble(row["int_Created_By"]));
            int_Modified_By.SetDbValue(IsNull(row["int_Modified_By"]) ? DbNullValue : ConvertToDouble(row["int_Modified_By"]));
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_InstPermitNo.SetDbValue(row["str_InstPermitNo"]);
            date_PermitExpiration.SetDbValue(row["date_PermitExpiration"]);
            date_InCarPermitIssue.SetDbValue(row["date_InCarPermitIssue"]);
            str_InClassPermitNo.SetDbValue(row["str_InClassPermitNo"]);
            date_InClassPermitIssue.SetDbValue(row["date_InClassPermitIssue"]);
            instructor_caption.SetDbValue(row["instructor_caption"]);
            str_LicType.SetDbValue(row["str_LicType"]);
            int_Order.SetDbValue(row["int_Order"]);
            str_InstLicenceDate.SetDbValue(row["str_InstLicenceDate"]);
            str_DLNum.SetDbValue(row["str_DLNum"]);
            str_DLExp.SetDbValue(row["str_DLExp"]);
            bit_appointmentColor.SetDbValue((ConvertToBool(row["bit_appointmentColor"]) ? "1" : "0"));
            str_appointmentColorCode.SetDbValue(row["str_appointmentColorCode"]);
            bit_IsSuperAdmin.SetDbValue((ConvertToBool(row["bit_IsSuperAdmin"]) ? "1" : "0"));
            IsDistanceBasedScheduling.SetDbValue(row["IsDistanceBasedScheduling"]);
            str_Package_Code.SetDbValue(row["str_Package_Code"]);
            str_NationalID_Iqama.SetDbValue(row["str_NationalID_Iqama"]);
            NationalID.SetDbValue(row["NationalID"]);
            int_RoadDistanceCoverage.SetDbValue(row["int_RoadDistanceCoverage"]);
            str_Badge.SetDbValue(row["str_Badge"]);
            strZoomHostUrl.SetDbValue(row["strZoomHostUrl"]);
            strZoomUserUrl.SetDbValue(row["strZoomUserUrl"]);
            Signature.Upload.DbValue = row["Signature"];
            str_VehicleType.SetDbValue(row["str_VehicleType"]);
            ProfilePicturePath.SetDbValue(row["ProfilePicturePath"]);
            Institution.SetDbValue(row["Institution"]);
            IsDrivingexperience.SetDbValue((ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"));
            intDrivinglicenseType.SetDbValue(row["intDrivinglicenseType"]);
            AbsherApptNbr.SetDbValue(row["AbsherApptNbr"]);
            Absherphoto.Upload.DbValue = row["Absherphoto"];
            Absherphoto.SetDbValue(Absherphoto.Upload.DbValue);
            Fingerprint.Upload.DbValue = row["Fingerprint"];
            Fingerprint.SetDbValue(Fingerprint.Upload.DbValue);
            ProfileField.SetDbValue(row["ProfileField"]);
            UserlevelID.SetDbValue(row["UserlevelID"]);
            Parent_Username.SetDbValue(row["Parent_Username"]);
            Activated.SetDbValue((ConvertToBool(row["Activated"]) ? "1" : "0"));
            int_Nationality.SetDbValue(row["int_Nationality"]);
            User_Role.SetDbValue(row["User_Role"]);
            int_Staff_Id.SetDbValue(row["int_Staff_Id"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_First_Name", str_First_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Middle_Name", str_Middle_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last_Name", str_Last_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Full_Name", str_Full_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Address", str_Address.DefaultValue ?? DbNullValue); // DN
            row.Add("str_City", str_City.DefaultValue ?? DbNullValue); // DN
            row.Add("int_State", int_State.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Zip", str_Zip.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Hired", date_Hired.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Left", date_Left.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CertNumber", str_CertNumber.DefaultValue ?? DbNullValue); // DN
            row.Add("date_CertExp", date_CertExp.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Cell_Phone", str_Cell_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Home_Phone", str_Home_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Other_Phone", str_Other_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email", str_Email.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Code", str_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Password", str_Password.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth_Hijri", date_Birth_Hijri.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth", date_Birth.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Year", Hijri_Year.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Month", Hijri_Month.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Day", Hijri_Day.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Started", date_Started.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DateHired", str_DateHired.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DateLeft", str_DateLeft.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Name", str_Emergency_Contact_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Phone", str_Emergency_Contact_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Relation", str_Emergency_Contact_Relation.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ClassType", int_ClassType.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ZipCodes", str_ZipCodes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_VehicleAssigned", int_VehicleAssigned.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Type", int_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location", int_Location.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_InstPermitNo", str_InstPermitNo.DefaultValue ?? DbNullValue); // DN
            row.Add("date_PermitExpiration", date_PermitExpiration.DefaultValue ?? DbNullValue); // DN
            row.Add("date_InCarPermitIssue", date_InCarPermitIssue.DefaultValue ?? DbNullValue); // DN
            row.Add("str_InClassPermitNo", str_InClassPermitNo.DefaultValue ?? DbNullValue); // DN
            row.Add("date_InClassPermitIssue", date_InClassPermitIssue.DefaultValue ?? DbNullValue); // DN
            row.Add("instructor_caption", instructor_caption.DefaultValue ?? DbNullValue); // DN
            row.Add("str_LicType", str_LicType.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Order", int_Order.DefaultValue ?? DbNullValue); // DN
            row.Add("str_InstLicenceDate", str_InstLicenceDate.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DLNum", str_DLNum.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DLExp", str_DLExp.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_appointmentColor", bit_appointmentColor.DefaultValue ?? DbNullValue); // DN
            row.Add("str_appointmentColorCode", str_appointmentColorCode.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsSuperAdmin", bit_IsSuperAdmin.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDistanceBasedScheduling", IsDistanceBasedScheduling.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Package_Code", str_Package_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("str_NationalID_Iqama", str_NationalID_Iqama.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_RoadDistanceCoverage", int_RoadDistanceCoverage.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Badge", str_Badge.DefaultValue ?? DbNullValue); // DN
            row.Add("strZoomHostUrl", strZoomHostUrl.DefaultValue ?? DbNullValue); // DN
            row.Add("strZoomUserUrl", strZoomUserUrl.DefaultValue ?? DbNullValue); // DN
            row.Add("Signature", Signature.DefaultValue ?? DbNullValue); // DN
            row.Add("str_VehicleType", str_VehicleType.DefaultValue ?? DbNullValue); // DN
            row.Add("ProfilePicturePath", ProfilePicturePath.DefaultValue ?? DbNullValue); // DN
            row.Add("Institution", Institution.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDrivingexperience", IsDrivingexperience.DefaultValue ?? DbNullValue); // DN
            row.Add("intDrivinglicenseType", intDrivinglicenseType.DefaultValue ?? DbNullValue); // DN
            row.Add("AbsherApptNbr", AbsherApptNbr.DefaultValue ?? DbNullValue); // DN
            row.Add("Absherphoto", Absherphoto.DefaultValue ?? DbNullValue); // DN
            row.Add("Fingerprint", Fingerprint.DefaultValue ?? DbNullValue); // DN
            row.Add("ProfileField", ProfileField.DefaultValue ?? DbNullValue); // DN
            row.Add("UserlevelID", UserlevelID.DefaultValue ?? DbNullValue); // DN
            row.Add("Parent_Username", Parent_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("Activated", Activated.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Nationality", int_Nationality.DefaultValue ?? DbNullValue); // DN
            row.Add("User_Role", User_Role.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Staff_Id", int_Staff_Id.DefaultValue ?? DbNullValue); // DN
            return row;
        }

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_Student_ID
            int_Student_ID.RowCssClass = "row";

            // str_First_Name
            str_First_Name.RowCssClass = "row";

            // str_Middle_Name
            str_Middle_Name.RowCssClass = "row";

            // str_Last_Name
            str_Last_Name.RowCssClass = "row";

            // str_Full_Name
            str_Full_Name.RowCssClass = "row";

            // str_Address
            str_Address.RowCssClass = "row";

            // str_City
            str_City.RowCssClass = "row";

            // int_State
            int_State.RowCssClass = "row";

            // str_Zip
            str_Zip.RowCssClass = "row";

            // date_Hired
            date_Hired.RowCssClass = "row";

            // date_Left
            date_Left.RowCssClass = "row";

            // str_CertNumber
            str_CertNumber.RowCssClass = "row";

            // date_CertExp
            date_CertExp.RowCssClass = "row";

            // str_Cell_Phone
            str_Cell_Phone.RowCssClass = "row";

            // str_Home_Phone
            str_Home_Phone.RowCssClass = "row";

            // str_Other_Phone
            str_Other_Phone.RowCssClass = "row";

            // str_Email
            str_Email.RowCssClass = "row";

            // str_Code
            str_Code.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // str_Password
            str_Password.RowCssClass = "row";

            // date_Birth_Hijri
            date_Birth_Hijri.RowCssClass = "row";

            // date_Birth
            date_Birth.RowCssClass = "row";

            // Hijri_Year
            Hijri_Year.RowCssClass = "row";

            // Hijri_Month
            Hijri_Month.RowCssClass = "row";

            // Hijri_Day
            Hijri_Day.RowCssClass = "row";

            // date_Started
            date_Started.RowCssClass = "row";

            // str_DateHired
            str_DateHired.RowCssClass = "row";

            // str_DateLeft
            str_DateLeft.RowCssClass = "row";

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.RowCssClass = "row";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.RowCssClass = "row";

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.RowCssClass = "row";

            // str_Notes
            str_Notes.RowCssClass = "row";

            // int_ClassType
            int_ClassType.RowCssClass = "row";

            // str_ZipCodes
            str_ZipCodes.RowCssClass = "row";

            // int_VehicleAssigned
            int_VehicleAssigned.RowCssClass = "row";

            // int_Status
            int_Status.RowCssClass = "row";

            // int_Type
            int_Type.RowCssClass = "row";

            // int_Location
            int_Location.RowCssClass = "row";

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

            // str_InstPermitNo
            str_InstPermitNo.RowCssClass = "row";

            // date_PermitExpiration
            date_PermitExpiration.RowCssClass = "row";

            // date_InCarPermitIssue
            date_InCarPermitIssue.RowCssClass = "row";

            // str_InClassPermitNo
            str_InClassPermitNo.RowCssClass = "row";

            // date_InClassPermitIssue
            date_InClassPermitIssue.RowCssClass = "row";

            // instructor_caption
            instructor_caption.RowCssClass = "row";

            // str_LicType
            str_LicType.RowCssClass = "row";

            // int_Order
            int_Order.RowCssClass = "row";

            // str_InstLicenceDate
            str_InstLicenceDate.RowCssClass = "row";

            // str_DLNum
            str_DLNum.RowCssClass = "row";

            // str_DLExp
            str_DLExp.RowCssClass = "row";

            // bit_appointmentColor
            bit_appointmentColor.RowCssClass = "row";

            // str_appointmentColorCode
            str_appointmentColorCode.RowCssClass = "row";

            // bit_IsSuperAdmin
            bit_IsSuperAdmin.RowCssClass = "row";

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.RowCssClass = "row";

            // str_Package_Code
            str_Package_Code.RowCssClass = "row";

            // str_NationalID_Iqama
            str_NationalID_Iqama.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.RowCssClass = "row";

            // str_Badge
            str_Badge.RowCssClass = "row";

            // strZoomHostUrl
            strZoomHostUrl.RowCssClass = "row";

            // strZoomUserUrl
            strZoomUserUrl.RowCssClass = "row";

            // Signature
            Signature.RowCssClass = "row";

            // str_VehicleType
            str_VehicleType.RowCssClass = "row";

            // ProfilePicturePath
            ProfilePicturePath.RowCssClass = "row";

            // Institution
            Institution.RowCssClass = "row";

            // IsDrivingexperience
            IsDrivingexperience.RowCssClass = "row";

            // intDrivinglicenseType
            intDrivinglicenseType.RowCssClass = "row";

            // AbsherApptNbr
            AbsherApptNbr.RowCssClass = "row";

            // Absherphoto
            Absherphoto.RowCssClass = "row";

            // Fingerprint
            Fingerprint.RowCssClass = "row";

            // ProfileField
            ProfileField.RowCssClass = "row";

            // UserlevelID
            UserlevelID.RowCssClass = "row";

            // Parent_Username
            Parent_Username.RowCssClass = "row";

            // Activated
            Activated.RowCssClass = "row";

            // int_Nationality
            int_Nationality.RowCssClass = "row";

            // User_Role
            User_Role.RowCssClass = "row";

            // int_Staff_Id
            int_Staff_Id.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // int_Student_ID
                int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
                int_Student_ID.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Middle_Name
                str_Middle_Name.ViewValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
                str_Middle_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // str_Full_Name
                str_Full_Name.ViewValue = ConvertToString(str_Full_Name.CurrentValue); // DN
                str_Full_Name.ViewCustomAttributes = "";

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

                // date_Hired
                date_Hired.ViewValue = date_Hired.CurrentValue;
                date_Hired.ViewValue = FormatDateTime(date_Hired.ViewValue, date_Hired.FormatPattern);
                date_Hired.ViewCustomAttributes = "";

                // date_Left
                date_Left.ViewValue = date_Left.CurrentValue;
                date_Left.ViewValue = FormatDateTime(date_Left.ViewValue, date_Left.FormatPattern);
                date_Left.ViewCustomAttributes = "";

                // str_CertNumber
                str_CertNumber.ViewValue = ConvertToString(str_CertNumber.CurrentValue); // DN
                str_CertNumber.ViewCustomAttributes = "";

                // date_CertExp
                date_CertExp.ViewValue = ConvertToString(date_CertExp.CurrentValue); // DN
                date_CertExp.ViewCustomAttributes = "";

                // str_Cell_Phone
                str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
                str_Cell_Phone.ViewCustomAttributes = "";

                // str_Home_Phone
                str_Home_Phone.ViewValue = ConvertToString(str_Home_Phone.CurrentValue); // DN
                str_Home_Phone.ViewCustomAttributes = "";

                // str_Other_Phone
                str_Other_Phone.ViewValue = ConvertToString(str_Other_Phone.CurrentValue); // DN
                str_Other_Phone.ViewCustomAttributes = "";

                // str_Email
                str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
                str_Email.ViewCustomAttributes = "";

                // str_Code
                str_Code.ViewValue = ConvertToString(str_Code.CurrentValue); // DN
                str_Code.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // str_Password
                str_Password.ViewValue = Language.Phrase("PasswordMask");
                str_Password.ViewCustomAttributes = "";

                // date_Birth_Hijri
                date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // date_Birth
                date_Birth.ViewValue = date_Birth.CurrentValue;
                date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
                date_Birth.ViewCustomAttributes = "";

                // Hijri_Year
                if (!Empty(Hijri_Year.CurrentValue)) {
                    Hijri_Year.ViewValue = Hijri_Year.HighlightLookup(ConvertToString(Hijri_Year.CurrentValue), Hijri_Year.OptionCaption(ConvertToString(Hijri_Year.CurrentValue)));
                } else {
                    Hijri_Year.ViewValue = DbNullValue;
                }
                Hijri_Year.ViewCustomAttributes = "";

                // Hijri_Month
                if (!Empty(Hijri_Month.CurrentValue)) {
                    Hijri_Month.ViewValue = Hijri_Month.HighlightLookup(ConvertToString(Hijri_Month.CurrentValue), Hijri_Month.OptionCaption(ConvertToString(Hijri_Month.CurrentValue)));
                } else {
                    Hijri_Month.ViewValue = DbNullValue;
                }
                Hijri_Month.ViewCustomAttributes = "";

                // Hijri_Day
                if (!Empty(Hijri_Day.CurrentValue)) {
                    Hijri_Day.ViewValue = Hijri_Day.HighlightLookup(ConvertToString(Hijri_Day.CurrentValue), Hijri_Day.OptionCaption(ConvertToString(Hijri_Day.CurrentValue)));
                } else {
                    Hijri_Day.ViewValue = DbNullValue;
                }
                Hijri_Day.ViewCustomAttributes = "";

                // date_Started
                date_Started.ViewValue = ConvertToString(date_Started.CurrentValue); // DN
                date_Started.ViewCustomAttributes = "";

                // str_DateHired
                str_DateHired.ViewValue = ConvertToString(str_DateHired.CurrentValue); // DN
                str_DateHired.ViewCustomAttributes = "";

                // str_DateLeft
                str_DateLeft.ViewValue = ConvertToString(str_DateLeft.CurrentValue); // DN
                str_DateLeft.ViewCustomAttributes = "";

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

                // str_Notes
                str_Notes.ViewValue = str_Notes.CurrentValue;
                str_Notes.ViewCustomAttributes = "";

                // int_ClassType
                int_ClassType.ViewValue = int_ClassType.CurrentValue;
                int_ClassType.ViewValue = FormatNumber(int_ClassType.ViewValue, int_ClassType.FormatPattern);
                int_ClassType.ViewCustomAttributes = "";

                // str_ZipCodes
                str_ZipCodes.ViewValue = str_ZipCodes.CurrentValue;
                str_ZipCodes.ViewCustomAttributes = "";

                // int_VehicleAssigned
                int_VehicleAssigned.ViewValue = int_VehicleAssigned.CurrentValue;
                int_VehicleAssigned.ViewValue = FormatNumber(int_VehicleAssigned.ViewValue, int_VehicleAssigned.FormatPattern);
                int_VehicleAssigned.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // int_Type
                int_Type.ViewValue = int_Type.CurrentValue;
                int_Type.ViewValue = FormatNumber(int_Type.ViewValue, int_Type.FormatPattern);
                int_Type.ViewCustomAttributes = "";

                // int_Location
                int_Location.ViewValue = int_Location.CurrentValue;
                int_Location.ViewValue = FormatNumber(int_Location.ViewValue, int_Location.FormatPattern);
                int_Location.ViewCustomAttributes = "";

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

                // str_InstPermitNo
                str_InstPermitNo.ViewValue = ConvertToString(str_InstPermitNo.CurrentValue); // DN
                str_InstPermitNo.ViewCustomAttributes = "";

                // date_PermitExpiration
                date_PermitExpiration.ViewValue = ConvertToString(date_PermitExpiration.CurrentValue); // DN
                date_PermitExpiration.ViewCustomAttributes = "";

                // date_InCarPermitIssue
                date_InCarPermitIssue.ViewValue = ConvertToString(date_InCarPermitIssue.CurrentValue); // DN
                date_InCarPermitIssue.ViewCustomAttributes = "";

                // str_InClassPermitNo
                str_InClassPermitNo.ViewValue = ConvertToString(str_InClassPermitNo.CurrentValue); // DN
                str_InClassPermitNo.ViewCustomAttributes = "";

                // date_InClassPermitIssue
                date_InClassPermitIssue.ViewValue = ConvertToString(date_InClassPermitIssue.CurrentValue); // DN
                date_InClassPermitIssue.ViewCustomAttributes = "";

                // instructor_caption
                instructor_caption.ViewValue = ConvertToString(instructor_caption.CurrentValue); // DN
                instructor_caption.ViewCustomAttributes = "";

                // str_LicType
                str_LicType.ViewValue = ConvertToString(str_LicType.CurrentValue); // DN
                str_LicType.ViewCustomAttributes = "";

                // int_Order
                int_Order.ViewValue = int_Order.CurrentValue;
                int_Order.ViewValue = FormatNumber(int_Order.ViewValue, int_Order.FormatPattern);
                int_Order.ViewCustomAttributes = "";

                // str_InstLicenceDate
                str_InstLicenceDate.ViewValue = ConvertToString(str_InstLicenceDate.CurrentValue); // DN
                str_InstLicenceDate.ViewCustomAttributes = "";

                // str_DLNum
                str_DLNum.ViewValue = ConvertToString(str_DLNum.CurrentValue); // DN
                str_DLNum.ViewCustomAttributes = "";

                // str_DLExp
                str_DLExp.ViewValue = ConvertToString(str_DLExp.CurrentValue); // DN
                str_DLExp.ViewCustomAttributes = "";

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

                // bit_IsSuperAdmin
                if (ConvertToBool(bit_IsSuperAdmin.CurrentValue)) {
                    bit_IsSuperAdmin.ViewValue = bit_IsSuperAdmin.TagCaption(1) != "" ? bit_IsSuperAdmin.TagCaption(1) : "Yes";
                } else {
                    bit_IsSuperAdmin.ViewValue = bit_IsSuperAdmin.TagCaption(2) != "" ? bit_IsSuperAdmin.TagCaption(2) : "No";
                }
                bit_IsSuperAdmin.ViewCustomAttributes = "";

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.ViewValue = IsDistanceBasedScheduling.CurrentValue;
                IsDistanceBasedScheduling.ViewValue = FormatNumber(IsDistanceBasedScheduling.ViewValue, IsDistanceBasedScheduling.FormatPattern);
                IsDistanceBasedScheduling.ViewCustomAttributes = "";

                // str_Package_Code
                str_Package_Code.ViewValue = ConvertToString(str_Package_Code.CurrentValue); // DN
                str_Package_Code.ViewCustomAttributes = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.ViewValue = ConvertToString(str_NationalID_Iqama.CurrentValue); // DN
                str_NationalID_Iqama.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
                NationalID.ViewValue = FormatNumber(NationalID.ViewValue, NationalID.FormatPattern);
                NationalID.ViewCustomAttributes = "";

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.ViewValue = int_RoadDistanceCoverage.CurrentValue;
                int_RoadDistanceCoverage.ViewValue = FormatNumber(int_RoadDistanceCoverage.ViewValue, int_RoadDistanceCoverage.FormatPattern);
                int_RoadDistanceCoverage.ViewCustomAttributes = "";

                // str_Badge
                str_Badge.ViewValue = ConvertToString(str_Badge.CurrentValue); // DN
                str_Badge.ViewCustomAttributes = "";

                // strZoomHostUrl
                strZoomHostUrl.ViewValue = strZoomHostUrl.CurrentValue;
                strZoomHostUrl.ViewCustomAttributes = "";

                // strZoomUserUrl
                strZoomUserUrl.ViewValue = strZoomUserUrl.CurrentValue;
                strZoomUserUrl.ViewCustomAttributes = "";

                // Signature
                if (!IsNull(Signature.Upload.DbValue)) {
                    Signature.ViewValue = RawUrlEncode(int_Student_ID.CurrentValue);
                    Signature.IsBlobImage = IsImageFile(ContentExtension((byte[])Signature.Upload.DbValue));
                } else {
                    Signature.ViewValue = "";
                }
                Signature.ViewCustomAttributes = "";

                // str_VehicleType
                str_VehicleType.ViewValue = ConvertToString(str_VehicleType.CurrentValue); // DN
                str_VehicleType.ViewCustomAttributes = "";

                // ProfilePicturePath
                ProfilePicturePath.ViewValue = ConvertToString(ProfilePicturePath.CurrentValue); // DN
                ProfilePicturePath.ViewCustomAttributes = "";

                // Institution
                Institution.ViewValue = ConvertToString(Institution.CurrentValue); // DN
                Institution.ViewCustomAttributes = "";

                // IsDrivingexperience
                if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
                } else {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
                }
                IsDrivingexperience.ViewCustomAttributes = "";

                // intDrivinglicenseType
                if (!Empty(intDrivinglicenseType.CurrentValue)) {
                    intDrivinglicenseType.ViewValue = intDrivinglicenseType.HighlightLookup(ConvertToString(intDrivinglicenseType.CurrentValue), intDrivinglicenseType.OptionCaption(ConvertToString(intDrivinglicenseType.CurrentValue)));
                } else {
                    intDrivinglicenseType.ViewValue = DbNullValue;
                }
                intDrivinglicenseType.ViewCustomAttributes = "";

                // AbsherApptNbr
                AbsherApptNbr.ViewValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
                AbsherApptNbr.ViewCustomAttributes = "";

                // Absherphoto
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.ViewValue = Absherphoto.Upload.DbValue;
                } else {
                    Absherphoto.ViewValue = "";
                }
                Absherphoto.ViewCustomAttributes = "";

                // Fingerprint
                if (!IsNull(Fingerprint.Upload.DbValue)) {
                    Fingerprint.ViewValue = Fingerprint.Upload.DbValue;
                } else {
                    Fingerprint.ViewValue = "";
                }
                Fingerprint.ViewCustomAttributes = "";

                // ProfileField
                ProfileField.ViewValue = ProfileField.CurrentValue;
                ProfileField.ViewCustomAttributes = "";

                // UserlevelID
                if (Security.CanAdmin) { // System admin
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
                } else {
                    UserlevelID.ViewValue = Language.Phrase("PasswordMask");
                }
                UserlevelID.ViewCustomAttributes = "";

                // Parent_Username
                curVal = ConvertToString(Parent_Username.CurrentValue);
                if (!Empty(curVal)) {
                    if (Parent_Username.Lookup != null && IsDictionary(Parent_Username.Lookup?.Options) && Parent_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Parent_Username.ViewValue = Parent_Username.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Username]", "=", Parent_Username.CurrentValue, DataType.String, "");
                        sqlWrk = Parent_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Parent_Username.Lookup != null) { // Lookup values found
                            var listwrk = Parent_Username.Lookup?.RenderViewRow(rswrk[0]);
                            Parent_Username.ViewValue = Parent_Username.HighlightLookup(ConvertToString(rswrk[0]), Parent_Username.DisplayValue(listwrk));
                        } else {
                            Parent_Username.ViewValue = Parent_Username.CurrentValue;
                        }
                    }
                } else {
                    Parent_Username.ViewValue = DbNullValue;
                }
                Parent_Username.ViewCustomAttributes = "";

                // Activated
                if (ConvertToBool(Activated.CurrentValue)) {
                    Activated.ViewValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
                } else {
                    Activated.ViewValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
                }
                Activated.ViewCustomAttributes = "";

                // int_Nationality
                int_Nationality.ViewValue = int_Nationality.CurrentValue;
                int_Nationality.ViewValue = FormatNumber(int_Nationality.ViewValue, int_Nationality.FormatPattern);
                int_Nationality.ViewCustomAttributes = "";

                // User_Role
                if (!Empty(User_Role.CurrentValue)) {
                    User_Role.ViewValue = User_Role.HighlightLookup(ConvertToString(User_Role.CurrentValue), User_Role.OptionCaption(ConvertToString(User_Role.CurrentValue)));
                } else {
                    User_Role.ViewValue = DbNullValue;
                }
                User_Role.ViewCustomAttributes = "";

                // int_Staff_Id
                int_Staff_Id.ViewValue = int_Staff_Id.CurrentValue;
                int_Staff_Id.ViewValue = FormatNumber(int_Staff_Id.ViewValue, int_Staff_Id.FormatPattern);
                int_Staff_Id.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";
                str_Middle_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Address
                str_Address.HrefValue = "";
                str_Address.TooltipValue = "";

                // str_City
                str_City.HrefValue = "";
                str_City.TooltipValue = "";

                // int_State
                int_State.HrefValue = "";
                int_State.TooltipValue = "";

                // str_Zip
                str_Zip.HrefValue = "";
                str_Zip.TooltipValue = "";

                // date_Hired
                date_Hired.HrefValue = "";
                date_Hired.TooltipValue = "";

                // date_Left
                date_Left.HrefValue = "";
                date_Left.TooltipValue = "";

                // str_CertNumber
                str_CertNumber.HrefValue = "";
                str_CertNumber.TooltipValue = "";

                // date_CertExp
                date_CertExp.HrefValue = "";
                date_CertExp.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // str_Home_Phone
                str_Home_Phone.HrefValue = "";
                str_Home_Phone.TooltipValue = "";

                // str_Other_Phone
                str_Other_Phone.HrefValue = "";
                str_Other_Phone.TooltipValue = "";

                // str_Email
                str_Email.HrefValue = "";
                str_Email.TooltipValue = "";

                // str_Code
                str_Code.HrefValue = "";
                str_Code.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // str_Password
                str_Password.HrefValue = "";
                str_Password.TooltipValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";
                date_Birth_Hijri.TooltipValue = "";

                // date_Birth
                date_Birth.HrefValue = "";
                date_Birth.TooltipValue = "";

                // Hijri_Year
                Hijri_Year.HrefValue = "";
                Hijri_Year.TooltipValue = "";

                // Hijri_Month
                Hijri_Month.HrefValue = "";
                Hijri_Month.TooltipValue = "";

                // Hijri_Day
                Hijri_Day.HrefValue = "";
                Hijri_Day.TooltipValue = "";

                // date_Started
                date_Started.HrefValue = "";
                date_Started.TooltipValue = "";

                // str_DateHired
                str_DateHired.HrefValue = "";
                str_DateHired.TooltipValue = "";

                // str_DateLeft
                str_DateLeft.HrefValue = "";
                str_DateLeft.TooltipValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";
                str_Emergency_Contact_Name.TooltipValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";
                str_Emergency_Contact_Phone.TooltipValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";
                str_Emergency_Contact_Relation.TooltipValue = "";

                // str_Notes
                str_Notes.HrefValue = "";
                str_Notes.TooltipValue = "";

                // int_ClassType
                int_ClassType.HrefValue = "";
                int_ClassType.TooltipValue = "";

                // str_ZipCodes
                str_ZipCodes.HrefValue = "";
                str_ZipCodes.TooltipValue = "";

                // int_VehicleAssigned
                int_VehicleAssigned.HrefValue = "";
                int_VehicleAssigned.TooltipValue = "";

                // int_Status
                int_Status.HrefValue = "";
                int_Status.TooltipValue = "";

                // int_Type
                int_Type.HrefValue = "";
                int_Type.TooltipValue = "";

                // int_Location
                int_Location.HrefValue = "";
                int_Location.TooltipValue = "";

                // date_Created
                date_Created.HrefValue = "";
                date_Created.TooltipValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";
                int_Created_By.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";
                int_Modified_By.TooltipValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";
                bit_IsDeleted.TooltipValue = "";

                // str_InstPermitNo
                str_InstPermitNo.HrefValue = "";
                str_InstPermitNo.TooltipValue = "";

                // date_PermitExpiration
                date_PermitExpiration.HrefValue = "";
                date_PermitExpiration.TooltipValue = "";

                // date_InCarPermitIssue
                date_InCarPermitIssue.HrefValue = "";
                date_InCarPermitIssue.TooltipValue = "";

                // str_InClassPermitNo
                str_InClassPermitNo.HrefValue = "";
                str_InClassPermitNo.TooltipValue = "";

                // date_InClassPermitIssue
                date_InClassPermitIssue.HrefValue = "";
                date_InClassPermitIssue.TooltipValue = "";

                // instructor_caption
                instructor_caption.HrefValue = "";
                instructor_caption.TooltipValue = "";

                // str_LicType
                str_LicType.HrefValue = "";
                str_LicType.TooltipValue = "";

                // int_Order
                int_Order.HrefValue = "";
                int_Order.TooltipValue = "";

                // str_InstLicenceDate
                str_InstLicenceDate.HrefValue = "";
                str_InstLicenceDate.TooltipValue = "";

                // str_DLNum
                str_DLNum.HrefValue = "";
                str_DLNum.TooltipValue = "";

                // str_DLExp
                str_DLExp.HrefValue = "";
                str_DLExp.TooltipValue = "";

                // bit_appointmentColor
                bit_appointmentColor.HrefValue = "";
                bit_appointmentColor.TooltipValue = "";

                // str_appointmentColorCode
                str_appointmentColorCode.HrefValue = "";
                str_appointmentColorCode.TooltipValue = "";

                // bit_IsSuperAdmin
                bit_IsSuperAdmin.HrefValue = "";
                bit_IsSuperAdmin.TooltipValue = "";

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.HrefValue = "";
                IsDistanceBasedScheduling.TooltipValue = "";

                // str_Package_Code
                str_Package_Code.HrefValue = "";
                str_Package_Code.TooltipValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";
                str_NationalID_Iqama.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.HrefValue = "";
                int_RoadDistanceCoverage.TooltipValue = "";

                // str_Badge
                str_Badge.HrefValue = "";
                str_Badge.TooltipValue = "";

                // strZoomHostUrl
                strZoomHostUrl.HrefValue = "";
                strZoomHostUrl.TooltipValue = "";

                // strZoomUserUrl
                strZoomUserUrl.HrefValue = "";
                strZoomUserUrl.TooltipValue = "";

                // Signature
                if (!IsNull(Signature.Upload.DbValue)) {
                    Signature.HrefValue = AppPath(GetFileUploadUrl(Signature, ConvertToString(RawUrlEncode(int_Student_ID.CurrentValue)))); // DN
                    Signature.LinkAttrs["target"] = "";
                    if (Signature.IsBlobImage && Empty(Signature.LinkAttrs["target"]))
                        Signature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        Signature.HrefValue = FullUrl(ConvertToString(Signature.HrefValue), "href");
                } else {
                    Signature.HrefValue = "";
                }
                Signature.ExportHrefValue = GetFileUploadUrl(Signature, ConvertToString(RawUrlEncode(int_Student_ID.CurrentValue)));
                Signature.TooltipValue = "";

                // str_VehicleType
                str_VehicleType.HrefValue = "";
                str_VehicleType.TooltipValue = "";

                // ProfilePicturePath
                ProfilePicturePath.HrefValue = "";
                ProfilePicturePath.TooltipValue = "";

                // Institution
                Institution.HrefValue = "";
                Institution.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";

                // intDrivinglicenseType
                intDrivinglicenseType.HrefValue = "";
                intDrivinglicenseType.TooltipValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";
                AbsherApptNbr.TooltipValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
                Absherphoto.TooltipValue = "";

                // Fingerprint
                Fingerprint.HrefValue = "";
                Fingerprint.ExportHrefValue = Fingerprint.UploadPath + Fingerprint.Upload.DbValue;
                Fingerprint.TooltipValue = "";

                // ProfileField
                ProfileField.HrefValue = "";
                ProfileField.TooltipValue = "";

                // UserlevelID
                UserlevelID.HrefValue = "";
                UserlevelID.TooltipValue = "";

                // Parent_Username
                Parent_Username.HrefValue = "";
                Parent_Username.TooltipValue = "";

                // Activated
                Activated.HrefValue = "";
                Activated.TooltipValue = "";

                // int_Nationality
                int_Nationality.HrefValue = "";
                int_Nationality.TooltipValue = "";

                // User_Role
                User_Role.HrefValue = "";
                User_Role.TooltipValue = "";

                // int_Staff_Id
                int_Staff_Id.HrefValue = "";
                int_Staff_Id.TooltipValue = "";
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

                // date_Hired
                date_Hired.SetupEditAttributes();
                date_Hired.EditValue = date_Hired.CurrentValue;
                date_Hired.EditValue = FormatDateTime(date_Hired.EditValue, date_Hired.FormatPattern);
                date_Hired.ViewCustomAttributes = "";

                // date_Left
                date_Left.SetupEditAttributes();
                date_Left.EditValue = FormatDateTime(date_Left.CurrentValue, date_Left.FormatPattern); // DN
                date_Left.PlaceHolder = RemoveHtml(date_Left.Caption);

                // str_CertNumber
                str_CertNumber.SetupEditAttributes();
                if (!str_CertNumber.Raw)
                    str_CertNumber.CurrentValue = HtmlDecode(str_CertNumber.CurrentValue);
                str_CertNumber.EditValue = HtmlEncode(str_CertNumber.CurrentValue);
                str_CertNumber.PlaceHolder = RemoveHtml(str_CertNumber.Caption);

                // date_CertExp
                date_CertExp.SetupEditAttributes();
                if (!date_CertExp.Raw)
                    date_CertExp.CurrentValue = HtmlDecode(date_CertExp.CurrentValue);
                date_CertExp.EditValue = HtmlEncode(date_CertExp.CurrentValue);
                date_CertExp.PlaceHolder = RemoveHtml(date_CertExp.Caption);

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.CurrentValue = HtmlDecode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

                // str_Home_Phone
                str_Home_Phone.SetupEditAttributes();
                if (!str_Home_Phone.Raw)
                    str_Home_Phone.CurrentValue = HtmlDecode(str_Home_Phone.CurrentValue);
                str_Home_Phone.EditValue = HtmlEncode(str_Home_Phone.CurrentValue);
                str_Home_Phone.PlaceHolder = RemoveHtml(str_Home_Phone.Caption);

                // str_Other_Phone
                str_Other_Phone.SetupEditAttributes();
                if (!str_Other_Phone.Raw)
                    str_Other_Phone.CurrentValue = HtmlDecode(str_Other_Phone.CurrentValue);
                str_Other_Phone.EditValue = HtmlEncode(str_Other_Phone.CurrentValue);
                str_Other_Phone.PlaceHolder = RemoveHtml(str_Other_Phone.Caption);

                // str_Email
                str_Email.SetupEditAttributes();
                if (!str_Email.Raw)
                    str_Email.CurrentValue = HtmlDecode(str_Email.CurrentValue);
                str_Email.EditValue = HtmlEncode(str_Email.CurrentValue);
                str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

                // str_Code
                str_Code.SetupEditAttributes();
                if (!str_Code.Raw)
                    str_Code.CurrentValue = HtmlDecode(str_Code.CurrentValue);
                str_Code.EditValue = HtmlEncode(str_Code.CurrentValue);
                str_Code.PlaceHolder = RemoveHtml(str_Code.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!Security.IsAdmin && Security.IsLoggedIn && !UserIDAllow("update")) { // Non system admin
                    str_Username.CurrentValue = Empty(str_Username.CurrentValue) ? CurrentUserID() : str_Username.CurrentValue;
                } else {
                    if (!str_Username.Raw)
                        str_Username.CurrentValue = HtmlDecode(str_Username.CurrentValue);
                    str_Username.EditValue = HtmlEncode(str_Username.CurrentValue);
                    str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);
                }

                // str_Password
                str_Password.SetupEditAttributes();
                str_Password.EditValue = Language.Phrase("PasswordMask"); // Show as masked password
                str_Password.PlaceHolder = RemoveHtml(str_Password.Caption);

                // date_Birth_Hijri
                date_Birth_Hijri.SetupEditAttributes();
                if (!date_Birth_Hijri.Raw)
                    date_Birth_Hijri.CurrentValue = HtmlDecode(date_Birth_Hijri.CurrentValue);
                date_Birth_Hijri.EditValue = HtmlEncode(date_Birth_Hijri.CurrentValue);
                date_Birth_Hijri.PlaceHolder = RemoveHtml(date_Birth_Hijri.Caption);

                // date_Birth
                date_Birth.SetupEditAttributes();
                date_Birth.EditValue = FormatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern); // DN
                date_Birth.PlaceHolder = RemoveHtml(date_Birth.Caption);

                // Hijri_Year
                Hijri_Year.SetupEditAttributes();
                Hijri_Year.EditValue = Hijri_Year.Options(true);
                Hijri_Year.PlaceHolder = RemoveHtml(Hijri_Year.Caption);
                if (!Empty(Hijri_Year.EditValue) && IsNumeric(Hijri_Year.EditValue))
                    Hijri_Year.EditValue = FormatNumber(Hijri_Year.EditValue, null);

                // Hijri_Month
                Hijri_Month.SetupEditAttributes();
                Hijri_Month.EditValue = Hijri_Month.Options(true);
                Hijri_Month.PlaceHolder = RemoveHtml(Hijri_Month.Caption);
                if (!Empty(Hijri_Month.EditValue) && IsNumeric(Hijri_Month.EditValue))
                    Hijri_Month.EditValue = FormatNumber(Hijri_Month.EditValue, null);

                // Hijri_Day
                Hijri_Day.SetupEditAttributes();
                Hijri_Day.EditValue = Hijri_Day.Options(true);
                Hijri_Day.PlaceHolder = RemoveHtml(Hijri_Day.Caption);
                if (!Empty(Hijri_Day.EditValue) && IsNumeric(Hijri_Day.EditValue))
                    Hijri_Day.EditValue = FormatNumber(Hijri_Day.EditValue, null);

                // date_Started
                date_Started.SetupEditAttributes();
                date_Started.EditValue = ConvertToString(date_Started.CurrentValue); // DN
                date_Started.ViewCustomAttributes = "";

                // str_DateHired
                str_DateHired.SetupEditAttributes();
                str_DateHired.EditValue = ConvertToString(str_DateHired.CurrentValue); // DN
                str_DateHired.ViewCustomAttributes = "";

                // str_DateLeft
                str_DateLeft.SetupEditAttributes();
                str_DateLeft.EditValue = ConvertToString(str_DateLeft.CurrentValue); // DN
                str_DateLeft.ViewCustomAttributes = "";

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

                // str_Notes
                str_Notes.SetupEditAttributes();
                str_Notes.EditValue = str_Notes.CurrentValue; // DN
                str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

                // int_ClassType
                int_ClassType.SetupEditAttributes();
                int_ClassType.EditValue = int_ClassType.CurrentValue; // DN
                int_ClassType.PlaceHolder = RemoveHtml(int_ClassType.Caption);
                if (!Empty(int_ClassType.EditValue) && IsNumeric(int_ClassType.EditValue))
                    int_ClassType.EditValue = FormatNumber(int_ClassType.EditValue, null);

                // str_ZipCodes
                str_ZipCodes.SetupEditAttributes();
                str_ZipCodes.EditValue = str_ZipCodes.CurrentValue; // DN
                str_ZipCodes.PlaceHolder = RemoveHtml(str_ZipCodes.Caption);

                // int_VehicleAssigned
                int_VehicleAssigned.SetupEditAttributes();
                int_VehicleAssigned.EditValue = int_VehicleAssigned.CurrentValue; // DN
                int_VehicleAssigned.PlaceHolder = RemoveHtml(int_VehicleAssigned.Caption);
                if (!Empty(int_VehicleAssigned.EditValue) && IsNumeric(int_VehicleAssigned.EditValue))
                    int_VehicleAssigned.EditValue = FormatNumber(int_VehicleAssigned.EditValue, null);

                // int_Status
                int_Status.SetupEditAttributes();
                int_Status.EditValue = int_Status.CurrentValue; // DN
                int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);
                if (!Empty(int_Status.EditValue) && IsNumeric(int_Status.EditValue))
                    int_Status.EditValue = FormatNumber(int_Status.EditValue, null);

                // int_Type
                int_Type.SetupEditAttributes();
                int_Type.EditValue = int_Type.CurrentValue; // DN
                int_Type.PlaceHolder = RemoveHtml(int_Type.Caption);
                if (!Empty(int_Type.EditValue) && IsNumeric(int_Type.EditValue))
                    int_Type.EditValue = FormatNumber(int_Type.EditValue, null);

                // int_Location
                int_Location.SetupEditAttributes();
                int_Location.EditValue = int_Location.CurrentValue; // DN
                int_Location.PlaceHolder = RemoveHtml(int_Location.Caption);
                if (!Empty(int_Location.EditValue) && IsNumeric(int_Location.EditValue))
                    int_Location.EditValue = FormatNumber(int_Location.EditValue, null);

                // date_Created

                // date_Modified

                // int_Created_By

                // int_Modified_By
                int_Modified_By.SetupEditAttributes();
                int_Modified_By.EditValue = int_Modified_By.CurrentValue; // DN
                int_Modified_By.PlaceHolder = RemoveHtml(int_Modified_By.Caption);
                if (!Empty(int_Modified_By.EditValue) && IsNumeric(int_Modified_By.EditValue))
                    int_Modified_By.EditValue = FormatNumber(int_Modified_By.EditValue, null);

                // bit_IsDeleted
                bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
                bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

                // str_InstPermitNo
                str_InstPermitNo.SetupEditAttributes();
                if (!str_InstPermitNo.Raw)
                    str_InstPermitNo.CurrentValue = HtmlDecode(str_InstPermitNo.CurrentValue);
                str_InstPermitNo.EditValue = HtmlEncode(str_InstPermitNo.CurrentValue);
                str_InstPermitNo.PlaceHolder = RemoveHtml(str_InstPermitNo.Caption);

                // date_PermitExpiration
                date_PermitExpiration.SetupEditAttributes();
                if (!date_PermitExpiration.Raw)
                    date_PermitExpiration.CurrentValue = HtmlDecode(date_PermitExpiration.CurrentValue);
                date_PermitExpiration.EditValue = HtmlEncode(date_PermitExpiration.CurrentValue);
                date_PermitExpiration.PlaceHolder = RemoveHtml(date_PermitExpiration.Caption);

                // date_InCarPermitIssue
                date_InCarPermitIssue.SetupEditAttributes();
                if (!date_InCarPermitIssue.Raw)
                    date_InCarPermitIssue.CurrentValue = HtmlDecode(date_InCarPermitIssue.CurrentValue);
                date_InCarPermitIssue.EditValue = HtmlEncode(date_InCarPermitIssue.CurrentValue);
                date_InCarPermitIssue.PlaceHolder = RemoveHtml(date_InCarPermitIssue.Caption);

                // str_InClassPermitNo
                str_InClassPermitNo.SetupEditAttributes();
                if (!str_InClassPermitNo.Raw)
                    str_InClassPermitNo.CurrentValue = HtmlDecode(str_InClassPermitNo.CurrentValue);
                str_InClassPermitNo.EditValue = HtmlEncode(str_InClassPermitNo.CurrentValue);
                str_InClassPermitNo.PlaceHolder = RemoveHtml(str_InClassPermitNo.Caption);

                // date_InClassPermitIssue
                date_InClassPermitIssue.SetupEditAttributes();
                if (!date_InClassPermitIssue.Raw)
                    date_InClassPermitIssue.CurrentValue = HtmlDecode(date_InClassPermitIssue.CurrentValue);
                date_InClassPermitIssue.EditValue = HtmlEncode(date_InClassPermitIssue.CurrentValue);
                date_InClassPermitIssue.PlaceHolder = RemoveHtml(date_InClassPermitIssue.Caption);

                // instructor_caption
                instructor_caption.SetupEditAttributes();
                if (!instructor_caption.Raw)
                    instructor_caption.CurrentValue = HtmlDecode(instructor_caption.CurrentValue);
                instructor_caption.EditValue = HtmlEncode(instructor_caption.CurrentValue);
                instructor_caption.PlaceHolder = RemoveHtml(instructor_caption.Caption);

                // str_LicType
                str_LicType.SetupEditAttributes();
                if (!str_LicType.Raw)
                    str_LicType.CurrentValue = HtmlDecode(str_LicType.CurrentValue);
                str_LicType.EditValue = HtmlEncode(str_LicType.CurrentValue);
                str_LicType.PlaceHolder = RemoveHtml(str_LicType.Caption);

                // int_Order
                int_Order.SetupEditAttributes();
                int_Order.EditValue = int_Order.CurrentValue; // DN
                int_Order.PlaceHolder = RemoveHtml(int_Order.Caption);
                if (!Empty(int_Order.EditValue) && IsNumeric(int_Order.EditValue))
                    int_Order.EditValue = FormatNumber(int_Order.EditValue, null);

                // str_InstLicenceDate
                str_InstLicenceDate.SetupEditAttributes();
                if (!str_InstLicenceDate.Raw)
                    str_InstLicenceDate.CurrentValue = HtmlDecode(str_InstLicenceDate.CurrentValue);
                str_InstLicenceDate.EditValue = HtmlEncode(str_InstLicenceDate.CurrentValue);
                str_InstLicenceDate.PlaceHolder = RemoveHtml(str_InstLicenceDate.Caption);

                // str_DLNum
                str_DLNum.SetupEditAttributes();
                if (!str_DLNum.Raw)
                    str_DLNum.CurrentValue = HtmlDecode(str_DLNum.CurrentValue);
                str_DLNum.EditValue = HtmlEncode(str_DLNum.CurrentValue);
                str_DLNum.PlaceHolder = RemoveHtml(str_DLNum.Caption);

                // str_DLExp
                str_DLExp.SetupEditAttributes();
                if (!str_DLExp.Raw)
                    str_DLExp.CurrentValue = HtmlDecode(str_DLExp.CurrentValue);
                str_DLExp.EditValue = HtmlEncode(str_DLExp.CurrentValue);
                str_DLExp.PlaceHolder = RemoveHtml(str_DLExp.Caption);

                // bit_appointmentColor
                bit_appointmentColor.EditValue = bit_appointmentColor.Options(false);
                bit_appointmentColor.PlaceHolder = RemoveHtml(bit_appointmentColor.Caption);

                // str_appointmentColorCode
                str_appointmentColorCode.SetupEditAttributes();
                if (!str_appointmentColorCode.Raw)
                    str_appointmentColorCode.CurrentValue = HtmlDecode(str_appointmentColorCode.CurrentValue);
                str_appointmentColorCode.EditValue = HtmlEncode(str_appointmentColorCode.CurrentValue);
                str_appointmentColorCode.PlaceHolder = RemoveHtml(str_appointmentColorCode.Caption);

                // bit_IsSuperAdmin
                bit_IsSuperAdmin.EditValue = bit_IsSuperAdmin.Options(false);
                bit_IsSuperAdmin.PlaceHolder = RemoveHtml(bit_IsSuperAdmin.Caption);

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.SetupEditAttributes();
                IsDistanceBasedScheduling.EditValue = IsDistanceBasedScheduling.CurrentValue; // DN
                IsDistanceBasedScheduling.PlaceHolder = RemoveHtml(IsDistanceBasedScheduling.Caption);
                if (!Empty(IsDistanceBasedScheduling.EditValue) && IsNumeric(IsDistanceBasedScheduling.EditValue))
                    IsDistanceBasedScheduling.EditValue = FormatNumber(IsDistanceBasedScheduling.EditValue, null);

                // str_Package_Code
                str_Package_Code.SetupEditAttributes();
                if (!str_Package_Code.Raw)
                    str_Package_Code.CurrentValue = HtmlDecode(str_Package_Code.CurrentValue);
                str_Package_Code.EditValue = HtmlEncode(str_Package_Code.CurrentValue);
                str_Package_Code.PlaceHolder = RemoveHtml(str_Package_Code.Caption);

                // str_NationalID_Iqama
                str_NationalID_Iqama.SetupEditAttributes();
                if (!str_NationalID_Iqama.Raw)
                    str_NationalID_Iqama.CurrentValue = HtmlDecode(str_NationalID_Iqama.CurrentValue);
                str_NationalID_Iqama.EditValue = HtmlEncode(str_NationalID_Iqama.CurrentValue);
                str_NationalID_Iqama.PlaceHolder = RemoveHtml(str_NationalID_Iqama.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.CurrentValue; // DN
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue))
                    NationalID.EditValue = FormatNumber(NationalID.EditValue, null);

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.SetupEditAttributes();
                int_RoadDistanceCoverage.EditValue = int_RoadDistanceCoverage.CurrentValue; // DN
                int_RoadDistanceCoverage.PlaceHolder = RemoveHtml(int_RoadDistanceCoverage.Caption);
                if (!Empty(int_RoadDistanceCoverage.EditValue) && IsNumeric(int_RoadDistanceCoverage.EditValue))
                    int_RoadDistanceCoverage.EditValue = FormatNumber(int_RoadDistanceCoverage.EditValue, null);

                // str_Badge
                str_Badge.SetupEditAttributes();
                if (!str_Badge.Raw)
                    str_Badge.CurrentValue = HtmlDecode(str_Badge.CurrentValue);
                str_Badge.EditValue = HtmlEncode(str_Badge.CurrentValue);
                str_Badge.PlaceHolder = RemoveHtml(str_Badge.Caption);

                // strZoomHostUrl
                strZoomHostUrl.SetupEditAttributes();
                strZoomHostUrl.EditValue = strZoomHostUrl.CurrentValue; // DN
                strZoomHostUrl.PlaceHolder = RemoveHtml(strZoomHostUrl.Caption);

                // strZoomUserUrl
                strZoomUserUrl.SetupEditAttributes();
                strZoomUserUrl.EditValue = strZoomUserUrl.CurrentValue; // DN
                strZoomUserUrl.PlaceHolder = RemoveHtml(strZoomUserUrl.Caption);

                // Signature
                Signature.SetupEditAttributes();
                if (!IsNull(Signature.Upload.DbValue)) {
                    Signature.EditValue = RawUrlEncode(int_Student_ID.CurrentValue);
                    Signature.IsBlobImage = IsImageFile(ContentExtension((byte[])Signature.Upload.DbValue));
                } else {
                    Signature.EditValue = "";
                }

                // str_VehicleType
                str_VehicleType.SetupEditAttributes();
                if (!str_VehicleType.Raw)
                    str_VehicleType.CurrentValue = HtmlDecode(str_VehicleType.CurrentValue);
                str_VehicleType.EditValue = HtmlEncode(str_VehicleType.CurrentValue);
                str_VehicleType.PlaceHolder = RemoveHtml(str_VehicleType.Caption);

                // ProfilePicturePath
                ProfilePicturePath.SetupEditAttributes();
                if (!ProfilePicturePath.Raw)
                    ProfilePicturePath.CurrentValue = HtmlDecode(ProfilePicturePath.CurrentValue);
                ProfilePicturePath.EditValue = HtmlEncode(ProfilePicturePath.CurrentValue);
                ProfilePicturePath.PlaceHolder = RemoveHtml(ProfilePicturePath.Caption);

                // Institution
                Institution.SetupEditAttributes();
                if (!Institution.Raw)
                    Institution.CurrentValue = HtmlDecode(Institution.CurrentValue);
                Institution.EditValue = HtmlEncode(Institution.CurrentValue);
                Institution.PlaceHolder = RemoveHtml(Institution.Caption);

                // IsDrivingexperience
                IsDrivingexperience.EditValue = IsDrivingexperience.Options(false);
                IsDrivingexperience.PlaceHolder = RemoveHtml(IsDrivingexperience.Caption);

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.Options(true);
                intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);
                if (!Empty(intDrivinglicenseType.EditValue) && IsNumeric(intDrivinglicenseType.EditValue))
                    intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, null);

                // AbsherApptNbr
                AbsherApptNbr.SetupEditAttributes();
                if (!AbsherApptNbr.Raw)
                    AbsherApptNbr.CurrentValue = HtmlDecode(AbsherApptNbr.CurrentValue);
                AbsherApptNbr.EditValue = HtmlEncode(AbsherApptNbr.CurrentValue);
                AbsherApptNbr.PlaceHolder = RemoveHtml(AbsherApptNbr.Caption);

                // Absherphoto
                Absherphoto.SetupEditAttributes();
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.EditValue = Absherphoto.Upload.DbValue;
                } else {
                    Absherphoto.EditValue = "";
                }
                if (!Empty(Absherphoto.CurrentValue))
                        Absherphoto.Upload.FileName = ConvertToString(Absherphoto.CurrentValue);

                // Fingerprint
                Fingerprint.SetupEditAttributes();
                if (!IsNull(Fingerprint.Upload.DbValue)) {
                    Fingerprint.EditValue = Fingerprint.Upload.DbValue;
                } else {
                    Fingerprint.EditValue = "";
                }
                if (!Empty(Fingerprint.CurrentValue))
                        Fingerprint.Upload.FileName = ConvertToString(Fingerprint.CurrentValue);

                // ProfileField
                ProfileField.SetupEditAttributes();
                ProfileField.EditValue = ProfileField.CurrentValue; // DN
                ProfileField.PlaceHolder = RemoveHtml(ProfileField.Caption);

                // UserlevelID
                UserlevelID.SetupEditAttributes();
                if (Security.CanAdmin) { // System admin
                    curVal = ConvertToString(UserlevelID.CurrentValue);
                    if (!Empty(curVal)) {
                        if (UserlevelID.Lookup != null && IsDictionary(UserlevelID.Lookup?.Options) && UserlevelID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                            UserlevelID.EditValue = UserlevelID.LookupCacheOption(curVal);
                        } else { // Lookup from database // DN
                            filterWrk = SearchFilter("[UserLevelID]", "=", UserlevelID.CurrentValue, DataType.Number, "");
                            sqlWrk = UserlevelID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                            rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                            if (rswrk?.Count > 0 && UserlevelID.Lookup != null) { // Lookup values found
                                var listwrk = UserlevelID.Lookup?.RenderViewRow(rswrk[0]);
                                UserlevelID.EditValue = UserlevelID.HighlightLookup(ConvertToString(rswrk[0]), UserlevelID.DisplayValue(listwrk));
                            } else {
                                UserlevelID.EditValue = FormatNumber(UserlevelID.CurrentValue, UserlevelID.FormatPattern);
                            }
                        }
                    } else {
                        UserlevelID.EditValue = DbNullValue;
                    }
                } else {
                    UserlevelID.EditValue = Language.Phrase("PasswordMask");
                }
                UserlevelID.ViewCustomAttributes = "";

                // Parent_Username
                Parent_Username.SetupEditAttributes();
                curVal = ConvertToString(Parent_Username.CurrentValue);
                if (!Empty(curVal)) {
                    if (Parent_Username.Lookup != null && IsDictionary(Parent_Username.Lookup?.Options) && Parent_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Parent_Username.EditValue = Parent_Username.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Username]", "=", Parent_Username.CurrentValue, DataType.String, "");
                        sqlWrk = Parent_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Parent_Username.Lookup != null) { // Lookup values found
                            var listwrk = Parent_Username.Lookup?.RenderViewRow(rswrk[0]);
                            Parent_Username.EditValue = Parent_Username.HighlightLookup(ConvertToString(rswrk[0]), Parent_Username.DisplayValue(listwrk));
                        } else {
                            Parent_Username.EditValue = Parent_Username.CurrentValue;
                        }
                    }
                } else {
                    Parent_Username.EditValue = DbNullValue;
                }
                Parent_Username.ViewCustomAttributes = "";

                // Activated
                Activated.SetupEditAttributes();
                if (ConvertToBool(Activated.CurrentValue)) {
                    Activated.EditValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
                } else {
                    Activated.EditValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
                }
                Activated.ViewCustomAttributes = "";

                // int_Nationality
                int_Nationality.SetupEditAttributes();
                int_Nationality.EditValue = int_Nationality.CurrentValue; // DN
                int_Nationality.PlaceHolder = RemoveHtml(int_Nationality.Caption);
                if (!Empty(int_Nationality.EditValue) && IsNumeric(int_Nationality.EditValue))
                    int_Nationality.EditValue = FormatNumber(int_Nationality.EditValue, null);

                // User_Role
                User_Role.SetupEditAttributes();
                User_Role.EditValue = User_Role.Options(true);
                User_Role.PlaceHolder = RemoveHtml(User_Role.Caption);

                // int_Staff_Id
                int_Staff_Id.SetupEditAttributes();
                int_Staff_Id.EditValue = int_Staff_Id.CurrentValue; // DN
                int_Staff_Id.PlaceHolder = RemoveHtml(int_Staff_Id.Caption);
                if (!Empty(int_Staff_Id.EditValue) && IsNumeric(int_Staff_Id.EditValue))
                    int_Staff_Id.EditValue = FormatNumber(int_Staff_Id.EditValue, null);

                // Edit refer script

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // str_Address
                str_Address.HrefValue = "";

                // str_City
                str_City.HrefValue = "";

                // int_State
                int_State.HrefValue = "";

                // str_Zip
                str_Zip.HrefValue = "";

                // date_Hired
                date_Hired.HrefValue = "";
                date_Hired.TooltipValue = "";

                // date_Left
                date_Left.HrefValue = "";

                // str_CertNumber
                str_CertNumber.HrefValue = "";

                // date_CertExp
                date_CertExp.HrefValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";

                // str_Home_Phone
                str_Home_Phone.HrefValue = "";

                // str_Other_Phone
                str_Other_Phone.HrefValue = "";

                // str_Email
                str_Email.HrefValue = "";

                // str_Code
                str_Code.HrefValue = "";

                // str_Username
                str_Username.HrefValue = "";

                // str_Password
                str_Password.HrefValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";

                // date_Birth
                date_Birth.HrefValue = "";

                // Hijri_Year
                Hijri_Year.HrefValue = "";

                // Hijri_Month
                Hijri_Month.HrefValue = "";

                // Hijri_Day
                Hijri_Day.HrefValue = "";

                // date_Started
                date_Started.HrefValue = "";
                date_Started.TooltipValue = "";

                // str_DateHired
                str_DateHired.HrefValue = "";
                str_DateHired.TooltipValue = "";

                // str_DateLeft
                str_DateLeft.HrefValue = "";
                str_DateLeft.TooltipValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";

                // str_Notes
                str_Notes.HrefValue = "";

                // int_ClassType
                int_ClassType.HrefValue = "";

                // str_ZipCodes
                str_ZipCodes.HrefValue = "";

                // int_VehicleAssigned
                int_VehicleAssigned.HrefValue = "";

                // int_Status
                int_Status.HrefValue = "";

                // int_Type
                int_Type.HrefValue = "";

                // int_Location
                int_Location.HrefValue = "";

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

                // str_InstPermitNo
                str_InstPermitNo.HrefValue = "";

                // date_PermitExpiration
                date_PermitExpiration.HrefValue = "";

                // date_InCarPermitIssue
                date_InCarPermitIssue.HrefValue = "";

                // str_InClassPermitNo
                str_InClassPermitNo.HrefValue = "";

                // date_InClassPermitIssue
                date_InClassPermitIssue.HrefValue = "";

                // instructor_caption
                instructor_caption.HrefValue = "";

                // str_LicType
                str_LicType.HrefValue = "";

                // int_Order
                int_Order.HrefValue = "";

                // str_InstLicenceDate
                str_InstLicenceDate.HrefValue = "";

                // str_DLNum
                str_DLNum.HrefValue = "";

                // str_DLExp
                str_DLExp.HrefValue = "";

                // bit_appointmentColor
                bit_appointmentColor.HrefValue = "";

                // str_appointmentColorCode
                str_appointmentColorCode.HrefValue = "";

                // bit_IsSuperAdmin
                bit_IsSuperAdmin.HrefValue = "";

                // IsDistanceBasedScheduling
                IsDistanceBasedScheduling.HrefValue = "";

                // str_Package_Code
                str_Package_Code.HrefValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // int_RoadDistanceCoverage
                int_RoadDistanceCoverage.HrefValue = "";

                // str_Badge
                str_Badge.HrefValue = "";

                // strZoomHostUrl
                strZoomHostUrl.HrefValue = "";

                // strZoomUserUrl
                strZoomUserUrl.HrefValue = "";

                // Signature
                if (!IsNull(Signature.Upload.DbValue)) {
                    Signature.HrefValue = AppPath(GetFileUploadUrl(Signature, ConvertToString(RawUrlEncode(int_Student_ID.CurrentValue)))); // DN
                    Signature.LinkAttrs["target"] = "";
                    if (Signature.IsBlobImage && Empty(Signature.LinkAttrs["target"]))
                        Signature.LinkAttrs["target"] = "_blank";
                    if (IsExport())
                        Signature.HrefValue = FullUrl(ConvertToString(Signature.HrefValue), "href");
                } else {
                    Signature.HrefValue = "";
                }
                Signature.ExportHrefValue = GetFileUploadUrl(Signature, ConvertToString(RawUrlEncode(int_Student_ID.CurrentValue)));

                // str_VehicleType
                str_VehicleType.HrefValue = "";

                // ProfilePicturePath
                ProfilePicturePath.HrefValue = "";

                // Institution
                Institution.HrefValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";

                // intDrivinglicenseType
                intDrivinglicenseType.HrefValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;

                // Fingerprint
                Fingerprint.HrefValue = "";
                Fingerprint.ExportHrefValue = Fingerprint.UploadPath + Fingerprint.Upload.DbValue;

                // ProfileField
                ProfileField.HrefValue = "";

                // UserlevelID
                UserlevelID.HrefValue = "";
                UserlevelID.TooltipValue = "";

                // Parent_Username
                Parent_Username.HrefValue = "";
                Parent_Username.TooltipValue = "";

                // Activated
                Activated.HrefValue = "";
                Activated.TooltipValue = "";

                // int_Nationality
                int_Nationality.HrefValue = "";

                // User_Role
                User_Role.HrefValue = "";

                // int_Staff_Id
                int_Staff_Id.HrefValue = "";
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
            int updateCnt = 0;
            if (str_First_Name.MultiUpdateSelected)
                updateCnt++;
            if (str_Middle_Name.MultiUpdateSelected)
                updateCnt++;
            if (str_Last_Name.MultiUpdateSelected)
                updateCnt++;
            if (str_Address.MultiUpdateSelected)
                updateCnt++;
            if (str_City.MultiUpdateSelected)
                updateCnt++;
            if (int_State.MultiUpdateSelected)
                updateCnt++;
            if (str_Zip.MultiUpdateSelected)
                updateCnt++;
            if (date_Hired.MultiUpdateSelected)
                updateCnt++;
            if (date_Left.MultiUpdateSelected)
                updateCnt++;
            if (str_CertNumber.MultiUpdateSelected)
                updateCnt++;
            if (date_CertExp.MultiUpdateSelected)
                updateCnt++;
            if (str_Cell_Phone.MultiUpdateSelected)
                updateCnt++;
            if (str_Home_Phone.MultiUpdateSelected)
                updateCnt++;
            if (str_Other_Phone.MultiUpdateSelected)
                updateCnt++;
            if (str_Email.MultiUpdateSelected)
                updateCnt++;
            if (str_Code.MultiUpdateSelected)
                updateCnt++;
            if (str_Username.MultiUpdateSelected)
                updateCnt++;
            if (str_Password.MultiUpdateSelected)
                updateCnt++;
            if (date_Birth_Hijri.MultiUpdateSelected)
                updateCnt++;
            if (date_Birth.MultiUpdateSelected)
                updateCnt++;
            if (Hijri_Year.MultiUpdateSelected)
                updateCnt++;
            if (Hijri_Month.MultiUpdateSelected)
                updateCnt++;
            if (Hijri_Day.MultiUpdateSelected)
                updateCnt++;
            if (date_Started.MultiUpdateSelected)
                updateCnt++;
            if (str_DateHired.MultiUpdateSelected)
                updateCnt++;
            if (str_DateLeft.MultiUpdateSelected)
                updateCnt++;
            if (str_Emergency_Contact_Name.MultiUpdateSelected)
                updateCnt++;
            if (str_Emergency_Contact_Phone.MultiUpdateSelected)
                updateCnt++;
            if (str_Emergency_Contact_Relation.MultiUpdateSelected)
                updateCnt++;
            if (str_Notes.MultiUpdateSelected)
                updateCnt++;
            if (int_ClassType.MultiUpdateSelected)
                updateCnt++;
            if (str_ZipCodes.MultiUpdateSelected)
                updateCnt++;
            if (int_VehicleAssigned.MultiUpdateSelected)
                updateCnt++;
            if (int_Status.MultiUpdateSelected)
                updateCnt++;
            if (int_Type.MultiUpdateSelected)
                updateCnt++;
            if (int_Location.MultiUpdateSelected)
                updateCnt++;
            if (date_Created.MultiUpdateSelected)
                updateCnt++;
            if (date_Modified.MultiUpdateSelected)
                updateCnt++;
            if (int_Created_By.MultiUpdateSelected)
                updateCnt++;
            if (int_Modified_By.MultiUpdateSelected)
                updateCnt++;
            if (bit_IsDeleted.MultiUpdateSelected)
                updateCnt++;
            if (str_InstPermitNo.MultiUpdateSelected)
                updateCnt++;
            if (date_PermitExpiration.MultiUpdateSelected)
                updateCnt++;
            if (date_InCarPermitIssue.MultiUpdateSelected)
                updateCnt++;
            if (str_InClassPermitNo.MultiUpdateSelected)
                updateCnt++;
            if (date_InClassPermitIssue.MultiUpdateSelected)
                updateCnt++;
            if (instructor_caption.MultiUpdateSelected)
                updateCnt++;
            if (str_LicType.MultiUpdateSelected)
                updateCnt++;
            if (int_Order.MultiUpdateSelected)
                updateCnt++;
            if (str_InstLicenceDate.MultiUpdateSelected)
                updateCnt++;
            if (str_DLNum.MultiUpdateSelected)
                updateCnt++;
            if (str_DLExp.MultiUpdateSelected)
                updateCnt++;
            if (bit_appointmentColor.MultiUpdateSelected)
                updateCnt++;
            if (str_appointmentColorCode.MultiUpdateSelected)
                updateCnt++;
            if (bit_IsSuperAdmin.MultiUpdateSelected)
                updateCnt++;
            if (IsDistanceBasedScheduling.MultiUpdateSelected)
                updateCnt++;
            if (str_Package_Code.MultiUpdateSelected)
                updateCnt++;
            if (str_NationalID_Iqama.MultiUpdateSelected)
                updateCnt++;
            if (NationalID.MultiUpdateSelected)
                updateCnt++;
            if (int_RoadDistanceCoverage.MultiUpdateSelected)
                updateCnt++;
            if (str_Badge.MultiUpdateSelected)
                updateCnt++;
            if (strZoomHostUrl.MultiUpdateSelected)
                updateCnt++;
            if (strZoomUserUrl.MultiUpdateSelected)
                updateCnt++;
            if (Signature.MultiUpdateSelected)
                updateCnt++;
            if (str_VehicleType.MultiUpdateSelected)
                updateCnt++;
            if (ProfilePicturePath.MultiUpdateSelected)
                updateCnt++;
            if (Institution.MultiUpdateSelected)
                updateCnt++;
            if (IsDrivingexperience.MultiUpdateSelected)
                updateCnt++;
            if (intDrivinglicenseType.MultiUpdateSelected)
                updateCnt++;
            if (AbsherApptNbr.MultiUpdateSelected)
                updateCnt++;
            if (Absherphoto.MultiUpdateSelected)
                updateCnt++;
            if (Fingerprint.MultiUpdateSelected)
                updateCnt++;
            if (ProfileField.MultiUpdateSelected)
                updateCnt++;
            if (UserlevelID.MultiUpdateSelected)
                updateCnt++;
            if (Parent_Username.MultiUpdateSelected)
                updateCnt++;
            if (Activated.MultiUpdateSelected)
                updateCnt++;
            if (int_Nationality.MultiUpdateSelected)
                updateCnt++;
            if (User_Role.MultiUpdateSelected)
                updateCnt++;
            if (int_Staff_Id.MultiUpdateSelected)
                updateCnt++;
            if (updateCnt == 0) {
                return false;
            }

            // Check if validation required
            if (!Config.ServerValidate)
                return true;
            bool validateForm = true;
            if (str_First_Name.Required) {
                if (str_First_Name.MultiUpdate != "" && !str_First_Name.IsDetailKey && Empty(str_First_Name.FormValue)) {
                    str_First_Name.AddErrorMessage(ConvertToString(str_First_Name.RequiredErrorMessage).Replace("%s", str_First_Name.Caption));
                }
            }
            if (str_Middle_Name.Required) {
                if (str_Middle_Name.MultiUpdate != "" && !str_Middle_Name.IsDetailKey && Empty(str_Middle_Name.FormValue)) {
                    str_Middle_Name.AddErrorMessage(ConvertToString(str_Middle_Name.RequiredErrorMessage).Replace("%s", str_Middle_Name.Caption));
                }
            }
            if (str_Last_Name.Required) {
                if (str_Last_Name.MultiUpdate != "" && !str_Last_Name.IsDetailKey && Empty(str_Last_Name.FormValue)) {
                    str_Last_Name.AddErrorMessage(ConvertToString(str_Last_Name.RequiredErrorMessage).Replace("%s", str_Last_Name.Caption));
                }
            }
            if (str_Address.Required) {
                if (str_Address.MultiUpdate != "" && !str_Address.IsDetailKey && Empty(str_Address.FormValue)) {
                    str_Address.AddErrorMessage(ConvertToString(str_Address.RequiredErrorMessage).Replace("%s", str_Address.Caption));
                }
            }
            if (str_City.Required) {
                if (str_City.MultiUpdate != "" && !str_City.IsDetailKey && Empty(str_City.FormValue)) {
                    str_City.AddErrorMessage(ConvertToString(str_City.RequiredErrorMessage).Replace("%s", str_City.Caption));
                }
            }
            if (int_State.Required) {
                if (int_State.MultiUpdate != "" && !int_State.IsDetailKey && Empty(int_State.FormValue)) {
                    int_State.AddErrorMessage(ConvertToString(int_State.RequiredErrorMessage).Replace("%s", int_State.Caption));
                }
            }
            if (str_Zip.Required) {
                if (str_Zip.MultiUpdate != "" && !str_Zip.IsDetailKey && Empty(str_Zip.FormValue)) {
                    str_Zip.AddErrorMessage(ConvertToString(str_Zip.RequiredErrorMessage).Replace("%s", str_Zip.Caption));
                }
            }
            if (date_Hired.Required) {
                if (date_Hired.MultiUpdate != "" && !date_Hired.IsDetailKey && Empty(date_Hired.FormValue)) {
                    date_Hired.AddErrorMessage(ConvertToString(date_Hired.RequiredErrorMessage).Replace("%s", date_Hired.Caption));
                }
            }
            if (date_Left.Required) {
                if (date_Left.MultiUpdate != "" && !date_Left.IsDetailKey && Empty(date_Left.FormValue)) {
                    date_Left.AddErrorMessage(ConvertToString(date_Left.RequiredErrorMessage).Replace("%s", date_Left.Caption));
                }
            }
            if (date_Left.MultiUpdate != "") {
                if (!CheckDate(date_Left.FormValue, date_Left.FormatPattern)) {
                    date_Left.AddErrorMessage(date_Left.GetErrorMessage(false));
                }
            }
            if (str_CertNumber.Required) {
                if (str_CertNumber.MultiUpdate != "" && !str_CertNumber.IsDetailKey && Empty(str_CertNumber.FormValue)) {
                    str_CertNumber.AddErrorMessage(ConvertToString(str_CertNumber.RequiredErrorMessage).Replace("%s", str_CertNumber.Caption));
                }
            }
            if (date_CertExp.Required) {
                if (date_CertExp.MultiUpdate != "" && !date_CertExp.IsDetailKey && Empty(date_CertExp.FormValue)) {
                    date_CertExp.AddErrorMessage(ConvertToString(date_CertExp.RequiredErrorMessage).Replace("%s", date_CertExp.Caption));
                }
            }
            if (str_Cell_Phone.Required) {
                if (str_Cell_Phone.MultiUpdate != "" && !str_Cell_Phone.IsDetailKey && Empty(str_Cell_Phone.FormValue)) {
                    str_Cell_Phone.AddErrorMessage(ConvertToString(str_Cell_Phone.RequiredErrorMessage).Replace("%s", str_Cell_Phone.Caption));
                }
            }
            if (str_Home_Phone.Required) {
                if (str_Home_Phone.MultiUpdate != "" && !str_Home_Phone.IsDetailKey && Empty(str_Home_Phone.FormValue)) {
                    str_Home_Phone.AddErrorMessage(ConvertToString(str_Home_Phone.RequiredErrorMessage).Replace("%s", str_Home_Phone.Caption));
                }
            }
            if (str_Other_Phone.Required) {
                if (str_Other_Phone.MultiUpdate != "" && !str_Other_Phone.IsDetailKey && Empty(str_Other_Phone.FormValue)) {
                    str_Other_Phone.AddErrorMessage(ConvertToString(str_Other_Phone.RequiredErrorMessage).Replace("%s", str_Other_Phone.Caption));
                }
            }
            if (str_Email.Required) {
                if (str_Email.MultiUpdate != "" && !str_Email.IsDetailKey && Empty(str_Email.FormValue)) {
                    str_Email.AddErrorMessage(ConvertToString(str_Email.RequiredErrorMessage).Replace("%s", str_Email.Caption));
                }
            }
            if (str_Email.MultiUpdate != "") {
                if (!CheckEmail(str_Email.FormValue)) {
                    str_Email.AddErrorMessage(str_Email.GetErrorMessage(false));
                }
            }
            if (str_Code.Required) {
                if (str_Code.MultiUpdate != "" && !str_Code.IsDetailKey && Empty(str_Code.FormValue)) {
                    str_Code.AddErrorMessage(ConvertToString(str_Code.RequiredErrorMessage).Replace("%s", str_Code.Caption));
                }
            }
            if (str_Username.Required) {
                if (str_Username.MultiUpdate != "" && !str_Username.IsDetailKey && Empty(str_Username.FormValue)) {
                    str_Username.AddErrorMessage(ConvertToString(str_Username.RequiredErrorMessage).Replace("%s", str_Username.Caption));
                }
            }
            if (!str_Username.Raw && Config.RemoveXss && CheckUsername(str_Username.FormValue)) {
                str_Username.AddErrorMessage(Language.Phrase("InvalidUsernameChars"));
            }
            if (str_Password.Required) {
                if (str_Password.MultiUpdate != "" && !str_Password.IsDetailKey && Empty(str_Password.FormValue)) {
                    str_Password.AddErrorMessage(ConvertToString(str_Password.RequiredErrorMessage).Replace("%s", str_Password.Caption));
                }
            }
            if (!str_Password.Raw && Config.RemoveXss && CheckPassword(str_Password.FormValue)) {
                str_Password.AddErrorMessage(Language.Phrase("InvalidPasswordChars"));
            }
            if (date_Birth_Hijri.Required) {
                if (date_Birth_Hijri.MultiUpdate != "" && !date_Birth_Hijri.IsDetailKey && Empty(date_Birth_Hijri.FormValue)) {
                    date_Birth_Hijri.AddErrorMessage(ConvertToString(date_Birth_Hijri.RequiredErrorMessage).Replace("%s", date_Birth_Hijri.Caption));
                }
            }
            if (date_Birth_Hijri.MultiUpdate != "") {
                if (!CheckDate(date_Birth_Hijri.FormValue, date_Birth_Hijri.FormatPattern)) {
                    date_Birth_Hijri.AddErrorMessage(date_Birth_Hijri.GetErrorMessage(false));
                }
            }
            if (date_Birth.Required) {
                if (date_Birth.MultiUpdate != "" && !date_Birth.IsDetailKey && Empty(date_Birth.FormValue)) {
                    date_Birth.AddErrorMessage(ConvertToString(date_Birth.RequiredErrorMessage).Replace("%s", date_Birth.Caption));
                }
            }
            if (date_Birth.MultiUpdate != "") {
                if (!CheckDate(date_Birth.FormValue, date_Birth.FormatPattern)) {
                    date_Birth.AddErrorMessage(date_Birth.GetErrorMessage(false));
                }
            }
            if (Hijri_Year.Required) {
                if (Hijri_Year.MultiUpdate != "" && !Hijri_Year.IsDetailKey && Empty(Hijri_Year.FormValue)) {
                    Hijri_Year.AddErrorMessage(ConvertToString(Hijri_Year.RequiredErrorMessage).Replace("%s", Hijri_Year.Caption));
                }
            }
            if (Hijri_Month.Required) {
                if (Hijri_Month.MultiUpdate != "" && !Hijri_Month.IsDetailKey && Empty(Hijri_Month.FormValue)) {
                    Hijri_Month.AddErrorMessage(ConvertToString(Hijri_Month.RequiredErrorMessage).Replace("%s", Hijri_Month.Caption));
                }
            }
            if (Hijri_Day.Required) {
                if (Hijri_Day.MultiUpdate != "" && !Hijri_Day.IsDetailKey && Empty(Hijri_Day.FormValue)) {
                    Hijri_Day.AddErrorMessage(ConvertToString(Hijri_Day.RequiredErrorMessage).Replace("%s", Hijri_Day.Caption));
                }
            }
            if (date_Started.Required) {
                if (date_Started.MultiUpdate != "" && !date_Started.IsDetailKey && Empty(date_Started.FormValue)) {
                    date_Started.AddErrorMessage(ConvertToString(date_Started.RequiredErrorMessage).Replace("%s", date_Started.Caption));
                }
            }
            if (str_DateHired.Required) {
                if (str_DateHired.MultiUpdate != "" && !str_DateHired.IsDetailKey && Empty(str_DateHired.FormValue)) {
                    str_DateHired.AddErrorMessage(ConvertToString(str_DateHired.RequiredErrorMessage).Replace("%s", str_DateHired.Caption));
                }
            }
            if (str_DateLeft.Required) {
                if (str_DateLeft.MultiUpdate != "" && !str_DateLeft.IsDetailKey && Empty(str_DateLeft.FormValue)) {
                    str_DateLeft.AddErrorMessage(ConvertToString(str_DateLeft.RequiredErrorMessage).Replace("%s", str_DateLeft.Caption));
                }
            }
            if (str_Emergency_Contact_Name.Required) {
                if (str_Emergency_Contact_Name.MultiUpdate != "" && !str_Emergency_Contact_Name.IsDetailKey && Empty(str_Emergency_Contact_Name.FormValue)) {
                    str_Emergency_Contact_Name.AddErrorMessage(ConvertToString(str_Emergency_Contact_Name.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Name.Caption));
                }
            }
            if (str_Emergency_Contact_Phone.Required) {
                if (str_Emergency_Contact_Phone.MultiUpdate != "" && !str_Emergency_Contact_Phone.IsDetailKey && Empty(str_Emergency_Contact_Phone.FormValue)) {
                    str_Emergency_Contact_Phone.AddErrorMessage(ConvertToString(str_Emergency_Contact_Phone.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Phone.Caption));
                }
            }
            if (str_Emergency_Contact_Relation.Required) {
                if (str_Emergency_Contact_Relation.MultiUpdate != "" && !str_Emergency_Contact_Relation.IsDetailKey && Empty(str_Emergency_Contact_Relation.FormValue)) {
                    str_Emergency_Contact_Relation.AddErrorMessage(ConvertToString(str_Emergency_Contact_Relation.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Relation.Caption));
                }
            }
            if (str_Notes.Required) {
                if (str_Notes.MultiUpdate != "" && !str_Notes.IsDetailKey && Empty(str_Notes.FormValue)) {
                    str_Notes.AddErrorMessage(ConvertToString(str_Notes.RequiredErrorMessage).Replace("%s", str_Notes.Caption));
                }
            }
            if (int_ClassType.Required) {
                if (int_ClassType.MultiUpdate != "" && !int_ClassType.IsDetailKey && Empty(int_ClassType.FormValue)) {
                    int_ClassType.AddErrorMessage(ConvertToString(int_ClassType.RequiredErrorMessage).Replace("%s", int_ClassType.Caption));
                }
            }
            if (int_ClassType.MultiUpdate != "") {
                if (!CheckInteger(int_ClassType.FormValue)) {
                    int_ClassType.AddErrorMessage(int_ClassType.GetErrorMessage(false));
                }
            }
            if (str_ZipCodes.Required) {
                if (str_ZipCodes.MultiUpdate != "" && !str_ZipCodes.IsDetailKey && Empty(str_ZipCodes.FormValue)) {
                    str_ZipCodes.AddErrorMessage(ConvertToString(str_ZipCodes.RequiredErrorMessage).Replace("%s", str_ZipCodes.Caption));
                }
            }
            if (int_VehicleAssigned.Required) {
                if (int_VehicleAssigned.MultiUpdate != "" && !int_VehicleAssigned.IsDetailKey && Empty(int_VehicleAssigned.FormValue)) {
                    int_VehicleAssigned.AddErrorMessage(ConvertToString(int_VehicleAssigned.RequiredErrorMessage).Replace("%s", int_VehicleAssigned.Caption));
                }
            }
            if (int_VehicleAssigned.MultiUpdate != "") {
                if (!CheckInteger(int_VehicleAssigned.FormValue)) {
                    int_VehicleAssigned.AddErrorMessage(int_VehicleAssigned.GetErrorMessage(false));
                }
            }
            if (int_Status.Required) {
                if (int_Status.MultiUpdate != "" && !int_Status.IsDetailKey && Empty(int_Status.FormValue)) {
                    int_Status.AddErrorMessage(ConvertToString(int_Status.RequiredErrorMessage).Replace("%s", int_Status.Caption));
                }
            }
            if (int_Status.MultiUpdate != "") {
                if (!CheckInteger(int_Status.FormValue)) {
                    int_Status.AddErrorMessage(int_Status.GetErrorMessage(false));
                }
            }
            if (int_Type.Required) {
                if (int_Type.MultiUpdate != "" && !int_Type.IsDetailKey && Empty(int_Type.FormValue)) {
                    int_Type.AddErrorMessage(ConvertToString(int_Type.RequiredErrorMessage).Replace("%s", int_Type.Caption));
                }
            }
            if (int_Type.MultiUpdate != "") {
                if (!CheckInteger(int_Type.FormValue)) {
                    int_Type.AddErrorMessage(int_Type.GetErrorMessage(false));
                }
            }
            if (int_Location.Required) {
                if (int_Location.MultiUpdate != "" && !int_Location.IsDetailKey && Empty(int_Location.FormValue)) {
                    int_Location.AddErrorMessage(ConvertToString(int_Location.RequiredErrorMessage).Replace("%s", int_Location.Caption));
                }
            }
            if (int_Location.MultiUpdate != "") {
                if (!CheckInteger(int_Location.FormValue)) {
                    int_Location.AddErrorMessage(int_Location.GetErrorMessage(false));
                }
            }
            if (date_Created.Required) {
                if (date_Created.MultiUpdate != "" && !date_Created.IsDetailKey && Empty(date_Created.FormValue)) {
                    date_Created.AddErrorMessage(ConvertToString(date_Created.RequiredErrorMessage).Replace("%s", date_Created.Caption));
                }
            }
            if (date_Modified.Required) {
                if (date_Modified.MultiUpdate != "" && !date_Modified.IsDetailKey && Empty(date_Modified.FormValue)) {
                    date_Modified.AddErrorMessage(ConvertToString(date_Modified.RequiredErrorMessage).Replace("%s", date_Modified.Caption));
                }
            }
            if (int_Created_By.Required) {
                if (int_Created_By.MultiUpdate != "" && !int_Created_By.IsDetailKey && Empty(int_Created_By.FormValue)) {
                    int_Created_By.AddErrorMessage(ConvertToString(int_Created_By.RequiredErrorMessage).Replace("%s", int_Created_By.Caption));
                }
            }
            if (int_Modified_By.Required) {
                if (int_Modified_By.MultiUpdate != "" && !int_Modified_By.IsDetailKey && Empty(int_Modified_By.FormValue)) {
                    int_Modified_By.AddErrorMessage(ConvertToString(int_Modified_By.RequiredErrorMessage).Replace("%s", int_Modified_By.Caption));
                }
            }
            if (int_Modified_By.MultiUpdate != "") {
                if (!CheckNumber(int_Modified_By.FormValue)) {
                    int_Modified_By.AddErrorMessage(int_Modified_By.GetErrorMessage(false));
                }
            }
            if (bit_IsDeleted.Required) {
                if (bit_IsDeleted.MultiUpdate != "" && Empty(bit_IsDeleted.FormValue)) {
                    bit_IsDeleted.AddErrorMessage(ConvertToString(bit_IsDeleted.RequiredErrorMessage).Replace("%s", bit_IsDeleted.Caption));
                }
            }
            if (str_InstPermitNo.Required) {
                if (str_InstPermitNo.MultiUpdate != "" && !str_InstPermitNo.IsDetailKey && Empty(str_InstPermitNo.FormValue)) {
                    str_InstPermitNo.AddErrorMessage(ConvertToString(str_InstPermitNo.RequiredErrorMessage).Replace("%s", str_InstPermitNo.Caption));
                }
            }
            if (date_PermitExpiration.Required) {
                if (date_PermitExpiration.MultiUpdate != "" && !date_PermitExpiration.IsDetailKey && Empty(date_PermitExpiration.FormValue)) {
                    date_PermitExpiration.AddErrorMessage(ConvertToString(date_PermitExpiration.RequiredErrorMessage).Replace("%s", date_PermitExpiration.Caption));
                }
            }
            if (date_InCarPermitIssue.Required) {
                if (date_InCarPermitIssue.MultiUpdate != "" && !date_InCarPermitIssue.IsDetailKey && Empty(date_InCarPermitIssue.FormValue)) {
                    date_InCarPermitIssue.AddErrorMessage(ConvertToString(date_InCarPermitIssue.RequiredErrorMessage).Replace("%s", date_InCarPermitIssue.Caption));
                }
            }
            if (str_InClassPermitNo.Required) {
                if (str_InClassPermitNo.MultiUpdate != "" && !str_InClassPermitNo.IsDetailKey && Empty(str_InClassPermitNo.FormValue)) {
                    str_InClassPermitNo.AddErrorMessage(ConvertToString(str_InClassPermitNo.RequiredErrorMessage).Replace("%s", str_InClassPermitNo.Caption));
                }
            }
            if (date_InClassPermitIssue.Required) {
                if (date_InClassPermitIssue.MultiUpdate != "" && !date_InClassPermitIssue.IsDetailKey && Empty(date_InClassPermitIssue.FormValue)) {
                    date_InClassPermitIssue.AddErrorMessage(ConvertToString(date_InClassPermitIssue.RequiredErrorMessage).Replace("%s", date_InClassPermitIssue.Caption));
                }
            }
            if (instructor_caption.Required) {
                if (instructor_caption.MultiUpdate != "" && !instructor_caption.IsDetailKey && Empty(instructor_caption.FormValue)) {
                    instructor_caption.AddErrorMessage(ConvertToString(instructor_caption.RequiredErrorMessage).Replace("%s", instructor_caption.Caption));
                }
            }
            if (str_LicType.Required) {
                if (str_LicType.MultiUpdate != "" && !str_LicType.IsDetailKey && Empty(str_LicType.FormValue)) {
                    str_LicType.AddErrorMessage(ConvertToString(str_LicType.RequiredErrorMessage).Replace("%s", str_LicType.Caption));
                }
            }
            if (int_Order.Required) {
                if (int_Order.MultiUpdate != "" && !int_Order.IsDetailKey && Empty(int_Order.FormValue)) {
                    int_Order.AddErrorMessage(ConvertToString(int_Order.RequiredErrorMessage).Replace("%s", int_Order.Caption));
                }
            }
            if (int_Order.MultiUpdate != "") {
                if (!CheckInteger(int_Order.FormValue)) {
                    int_Order.AddErrorMessage(int_Order.GetErrorMessage(false));
                }
            }
            if (str_InstLicenceDate.Required) {
                if (str_InstLicenceDate.MultiUpdate != "" && !str_InstLicenceDate.IsDetailKey && Empty(str_InstLicenceDate.FormValue)) {
                    str_InstLicenceDate.AddErrorMessage(ConvertToString(str_InstLicenceDate.RequiredErrorMessage).Replace("%s", str_InstLicenceDate.Caption));
                }
            }
            if (str_DLNum.Required) {
                if (str_DLNum.MultiUpdate != "" && !str_DLNum.IsDetailKey && Empty(str_DLNum.FormValue)) {
                    str_DLNum.AddErrorMessage(ConvertToString(str_DLNum.RequiredErrorMessage).Replace("%s", str_DLNum.Caption));
                }
            }
            if (str_DLExp.Required) {
                if (str_DLExp.MultiUpdate != "" && !str_DLExp.IsDetailKey && Empty(str_DLExp.FormValue)) {
                    str_DLExp.AddErrorMessage(ConvertToString(str_DLExp.RequiredErrorMessage).Replace("%s", str_DLExp.Caption));
                }
            }
            if (bit_appointmentColor.Required) {
                if (bit_appointmentColor.MultiUpdate != "" && Empty(bit_appointmentColor.FormValue)) {
                    bit_appointmentColor.AddErrorMessage(ConvertToString(bit_appointmentColor.RequiredErrorMessage).Replace("%s", bit_appointmentColor.Caption));
                }
            }
            if (str_appointmentColorCode.Required) {
                if (str_appointmentColorCode.MultiUpdate != "" && !str_appointmentColorCode.IsDetailKey && Empty(str_appointmentColorCode.FormValue)) {
                    str_appointmentColorCode.AddErrorMessage(ConvertToString(str_appointmentColorCode.RequiredErrorMessage).Replace("%s", str_appointmentColorCode.Caption));
                }
            }
            if (bit_IsSuperAdmin.Required) {
                if (bit_IsSuperAdmin.MultiUpdate != "" && Empty(bit_IsSuperAdmin.FormValue)) {
                    bit_IsSuperAdmin.AddErrorMessage(ConvertToString(bit_IsSuperAdmin.RequiredErrorMessage).Replace("%s", bit_IsSuperAdmin.Caption));
                }
            }
            if (IsDistanceBasedScheduling.Required) {
                if (IsDistanceBasedScheduling.MultiUpdate != "" && !IsDistanceBasedScheduling.IsDetailKey && Empty(IsDistanceBasedScheduling.FormValue)) {
                    IsDistanceBasedScheduling.AddErrorMessage(ConvertToString(IsDistanceBasedScheduling.RequiredErrorMessage).Replace("%s", IsDistanceBasedScheduling.Caption));
                }
            }
            if (IsDistanceBasedScheduling.MultiUpdate != "") {
                if (!CheckInteger(IsDistanceBasedScheduling.FormValue)) {
                    IsDistanceBasedScheduling.AddErrorMessage(IsDistanceBasedScheduling.GetErrorMessage(false));
                }
            }
            if (str_Package_Code.Required) {
                if (str_Package_Code.MultiUpdate != "" && !str_Package_Code.IsDetailKey && Empty(str_Package_Code.FormValue)) {
                    str_Package_Code.AddErrorMessage(ConvertToString(str_Package_Code.RequiredErrorMessage).Replace("%s", str_Package_Code.Caption));
                }
            }
            if (str_NationalID_Iqama.Required) {
                if (str_NationalID_Iqama.MultiUpdate != "" && !str_NationalID_Iqama.IsDetailKey && Empty(str_NationalID_Iqama.FormValue)) {
                    str_NationalID_Iqama.AddErrorMessage(ConvertToString(str_NationalID_Iqama.RequiredErrorMessage).Replace("%s", str_NationalID_Iqama.Caption));
                }
            }
            if (str_NationalID_Iqama.MultiUpdate != "") {
                if (!CheckInteger(str_NationalID_Iqama.FormValue)) {
                    str_NationalID_Iqama.AddErrorMessage(str_NationalID_Iqama.GetErrorMessage(false));
                }
            }
            if (NationalID.Required) {
                if (NationalID.MultiUpdate != "" && !NationalID.IsDetailKey && Empty(NationalID.FormValue)) {
                    NationalID.AddErrorMessage(ConvertToString(NationalID.RequiredErrorMessage).Replace("%s", NationalID.Caption));
                }
            }
            if (NationalID.MultiUpdate != "") {
                if (!CheckInteger(NationalID.FormValue)) {
                    NationalID.AddErrorMessage(NationalID.GetErrorMessage(false));
                }
            }
            if (int_RoadDistanceCoverage.Required) {
                if (int_RoadDistanceCoverage.MultiUpdate != "" && !int_RoadDistanceCoverage.IsDetailKey && Empty(int_RoadDistanceCoverage.FormValue)) {
                    int_RoadDistanceCoverage.AddErrorMessage(ConvertToString(int_RoadDistanceCoverage.RequiredErrorMessage).Replace("%s", int_RoadDistanceCoverage.Caption));
                }
            }
            if (str_Badge.Required) {
                if (str_Badge.MultiUpdate != "" && !str_Badge.IsDetailKey && Empty(str_Badge.FormValue)) {
                    str_Badge.AddErrorMessage(ConvertToString(str_Badge.RequiredErrorMessage).Replace("%s", str_Badge.Caption));
                }
            }
            if (strZoomHostUrl.Required) {
                if (strZoomHostUrl.MultiUpdate != "" && !strZoomHostUrl.IsDetailKey && Empty(strZoomHostUrl.FormValue)) {
                    strZoomHostUrl.AddErrorMessage(ConvertToString(strZoomHostUrl.RequiredErrorMessage).Replace("%s", strZoomHostUrl.Caption));
                }
            }
            if (strZoomUserUrl.Required) {
                if (strZoomUserUrl.MultiUpdate != "" && !strZoomUserUrl.IsDetailKey && Empty(strZoomUserUrl.FormValue)) {
                    strZoomUserUrl.AddErrorMessage(ConvertToString(strZoomUserUrl.RequiredErrorMessage).Replace("%s", strZoomUserUrl.Caption));
                }
            }
            if (Signature.Required) {
                if (Signature.MultiUpdate != "" && Signature.Upload.FileName == "" && !Signature.Upload.KeepFile) {
                    Signature.AddErrorMessage(ConvertToString(Signature.RequiredErrorMessage).Replace("%s", Signature.Caption));
                }
            }
            if (str_VehicleType.Required) {
                if (str_VehicleType.MultiUpdate != "" && !str_VehicleType.IsDetailKey && Empty(str_VehicleType.FormValue)) {
                    str_VehicleType.AddErrorMessage(ConvertToString(str_VehicleType.RequiredErrorMessage).Replace("%s", str_VehicleType.Caption));
                }
            }
            if (ProfilePicturePath.Required) {
                if (ProfilePicturePath.MultiUpdate != "" && !ProfilePicturePath.IsDetailKey && Empty(ProfilePicturePath.FormValue)) {
                    ProfilePicturePath.AddErrorMessage(ConvertToString(ProfilePicturePath.RequiredErrorMessage).Replace("%s", ProfilePicturePath.Caption));
                }
            }
            if (Institution.Required) {
                if (Institution.MultiUpdate != "" && !Institution.IsDetailKey && Empty(Institution.FormValue)) {
                    Institution.AddErrorMessage(ConvertToString(Institution.RequiredErrorMessage).Replace("%s", Institution.Caption));
                }
            }
            if (IsDrivingexperience.Required) {
                if (IsDrivingexperience.MultiUpdate != "" && Empty(IsDrivingexperience.FormValue)) {
                    IsDrivingexperience.AddErrorMessage(ConvertToString(IsDrivingexperience.RequiredErrorMessage).Replace("%s", IsDrivingexperience.Caption));
                }
            }
            if (intDrivinglicenseType.Required) {
                if (intDrivinglicenseType.MultiUpdate != "" && !intDrivinglicenseType.IsDetailKey && Empty(intDrivinglicenseType.FormValue)) {
                    intDrivinglicenseType.AddErrorMessage(ConvertToString(intDrivinglicenseType.RequiredErrorMessage).Replace("%s", intDrivinglicenseType.Caption));
                }
            }
            if (AbsherApptNbr.Required) {
                if (AbsherApptNbr.MultiUpdate != "" && !AbsherApptNbr.IsDetailKey && Empty(AbsherApptNbr.FormValue)) {
                    AbsherApptNbr.AddErrorMessage(ConvertToString(AbsherApptNbr.RequiredErrorMessage).Replace("%s", AbsherApptNbr.Caption));
                }
            }
            if (Absherphoto.Required) {
                if (Absherphoto.MultiUpdate != "" && Absherphoto.Upload.FileName == "" && !Absherphoto.Upload.KeepFile) {
                    Absherphoto.AddErrorMessage(ConvertToString(Absherphoto.RequiredErrorMessage).Replace("%s", Absherphoto.Caption));
                }
            }
            if (Fingerprint.Required) {
                if (Fingerprint.MultiUpdate != "" && Fingerprint.Upload.FileName == "" && !Fingerprint.Upload.KeepFile) {
                    Fingerprint.AddErrorMessage(ConvertToString(Fingerprint.RequiredErrorMessage).Replace("%s", Fingerprint.Caption));
                }
            }
            if (ProfileField.Required) {
                if (ProfileField.MultiUpdate != "" && !ProfileField.IsDetailKey && Empty(ProfileField.FormValue)) {
                    ProfileField.AddErrorMessage(ConvertToString(ProfileField.RequiredErrorMessage).Replace("%s", ProfileField.Caption));
                }
            }
            if (UserlevelID.Required) {
                if (UserlevelID.MultiUpdate != "" && Security.CanAdmin && !UserlevelID.IsDetailKey && Empty(UserlevelID.FormValue)) {
                    UserlevelID.AddErrorMessage(ConvertToString(UserlevelID.RequiredErrorMessage).Replace("%s", UserlevelID.Caption));
                }
            }
            if (Parent_Username.Required) {
                if (Parent_Username.MultiUpdate != "" && !Parent_Username.IsDetailKey && Empty(Parent_Username.FormValue)) {
                    Parent_Username.AddErrorMessage(ConvertToString(Parent_Username.RequiredErrorMessage).Replace("%s", Parent_Username.Caption));
                }
            }
            if (Activated.Required) {
                if (Activated.MultiUpdate != "" && Empty(Activated.FormValue)) {
                    Activated.AddErrorMessage(ConvertToString(Activated.RequiredErrorMessage).Replace("%s", Activated.Caption));
                }
            }
            if (int_Nationality.Required) {
                if (int_Nationality.MultiUpdate != "" && !int_Nationality.IsDetailKey && Empty(int_Nationality.FormValue)) {
                    int_Nationality.AddErrorMessage(ConvertToString(int_Nationality.RequiredErrorMessage).Replace("%s", int_Nationality.Caption));
                }
            }
            if (int_Nationality.MultiUpdate != "") {
                if (!CheckInteger(int_Nationality.FormValue)) {
                    int_Nationality.AddErrorMessage(int_Nationality.GetErrorMessage(false));
                }
            }
            if (User_Role.Required) {
                if (User_Role.MultiUpdate != "" && !User_Role.IsDetailKey && Empty(User_Role.FormValue)) {
                    User_Role.AddErrorMessage(ConvertToString(User_Role.RequiredErrorMessage).Replace("%s", User_Role.Caption));
                }
            }
            if (int_Staff_Id.Required) {
                if (int_Staff_Id.MultiUpdate != "" && !int_Staff_Id.IsDetailKey && Empty(int_Staff_Id.FormValue)) {
                    int_Staff_Id.AddErrorMessage(ConvertToString(int_Staff_Id.RequiredErrorMessage).Replace("%s", int_Staff_Id.Caption));
                }
            }
            if (int_Staff_Id.MultiUpdate != "") {
                if (!CheckInteger(int_Staff_Id.FormValue)) {
                    int_Staff_Id.AddErrorMessage(int_Staff_Id.GetErrorMessage(false));
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
            str_First_Name.SetDbValue(rsnew, str_First_Name.CurrentValue, str_First_Name.ReadOnly || str_First_Name.MultiUpdate != "1");

            // str_Middle_Name
            str_Middle_Name.SetDbValue(rsnew, str_Middle_Name.CurrentValue, str_Middle_Name.ReadOnly || str_Middle_Name.MultiUpdate != "1");

            // str_Last_Name
            str_Last_Name.SetDbValue(rsnew, str_Last_Name.CurrentValue, str_Last_Name.ReadOnly || str_Last_Name.MultiUpdate != "1");

            // str_Address
            str_Address.SetDbValue(rsnew, str_Address.CurrentValue, str_Address.ReadOnly || str_Address.MultiUpdate != "1");

            // str_City
            str_City.SetDbValue(rsnew, str_City.CurrentValue, str_City.ReadOnly || str_City.MultiUpdate != "1");

            // int_State
            int_State.SetDbValue(rsnew, int_State.CurrentValue, int_State.ReadOnly || int_State.MultiUpdate != "1");

            // str_Zip
            str_Zip.SetDbValue(rsnew, str_Zip.CurrentValue, str_Zip.ReadOnly || str_Zip.MultiUpdate != "1");

            // date_Left
            date_Left.SetDbValue(rsnew, ConvertToDateTime(date_Left.CurrentValue, date_Left.FormatPattern), date_Left.ReadOnly || date_Left.MultiUpdate != "1");

            // str_CertNumber
            str_CertNumber.SetDbValue(rsnew, str_CertNumber.CurrentValue, str_CertNumber.ReadOnly || str_CertNumber.MultiUpdate != "1");

            // date_CertExp
            date_CertExp.SetDbValue(rsnew, date_CertExp.CurrentValue, date_CertExp.ReadOnly || date_CertExp.MultiUpdate != "1");

            // str_Cell_Phone
            str_Cell_Phone.SetDbValue(rsnew, str_Cell_Phone.CurrentValue, str_Cell_Phone.ReadOnly || str_Cell_Phone.MultiUpdate != "1");

            // str_Home_Phone
            str_Home_Phone.SetDbValue(rsnew, str_Home_Phone.CurrentValue, str_Home_Phone.ReadOnly || str_Home_Phone.MultiUpdate != "1");

            // str_Other_Phone
            str_Other_Phone.SetDbValue(rsnew, str_Other_Phone.CurrentValue, str_Other_Phone.ReadOnly || str_Other_Phone.MultiUpdate != "1");

            // str_Email
            str_Email.SetDbValue(rsnew, str_Email.CurrentValue, str_Email.ReadOnly || str_Email.MultiUpdate != "1");

            // str_Code
            str_Code.SetDbValue(rsnew, str_Code.CurrentValue, str_Code.ReadOnly || str_Code.MultiUpdate != "1");

            // str_Username
            str_Username.SetDbValue(rsnew, str_Username.CurrentValue, str_Username.ReadOnly || str_Username.MultiUpdate != "1");

            // str_Password
            if (Config.EncryptedPassword && !IsMaskedPassword(str_Password.CurrentValue)) {
                str_Password.CurrentValue = EncryptPassword(Config.CaseSensitivePassword ? ConvertToString(str_Password.CurrentValue) : ConvertToString(str_Password.CurrentValue).ToLower());
            }
            str_Password.SetDbValue(rsnew, str_Password.CurrentValue, str_Password.ReadOnly || str_Password.MultiUpdate != "1" || Config.EncryptedPassword && SameString(rsold["str_Password"], str_Password.CurrentValue) || IsMaskedPassword(str_Password.CurrentValue));

            // date_Birth_Hijri
            date_Birth_Hijri.SetDbValue(rsnew, date_Birth_Hijri.CurrentValue, date_Birth_Hijri.ReadOnly || date_Birth_Hijri.MultiUpdate != "1");

            // date_Birth
            date_Birth.SetDbValue(rsnew, ConvertToDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern), date_Birth.ReadOnly || date_Birth.MultiUpdate != "1");

            // Hijri_Year
            Hijri_Year.SetDbValue(rsnew, Hijri_Year.CurrentValue, Hijri_Year.ReadOnly || Hijri_Year.MultiUpdate != "1");

            // Hijri_Month
            Hijri_Month.SetDbValue(rsnew, Hijri_Month.CurrentValue, Hijri_Month.ReadOnly || Hijri_Month.MultiUpdate != "1");

            // Hijri_Day
            Hijri_Day.SetDbValue(rsnew, Hijri_Day.CurrentValue, Hijri_Day.ReadOnly || Hijri_Day.MultiUpdate != "1");

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.SetDbValue(rsnew, str_Emergency_Contact_Name.CurrentValue, str_Emergency_Contact_Name.ReadOnly || str_Emergency_Contact_Name.MultiUpdate != "1");

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.SetDbValue(rsnew, str_Emergency_Contact_Phone.CurrentValue, str_Emergency_Contact_Phone.ReadOnly || str_Emergency_Contact_Phone.MultiUpdate != "1");

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.SetDbValue(rsnew, str_Emergency_Contact_Relation.CurrentValue, str_Emergency_Contact_Relation.ReadOnly || str_Emergency_Contact_Relation.MultiUpdate != "1");

            // str_Notes
            str_Notes.SetDbValue(rsnew, str_Notes.CurrentValue, str_Notes.ReadOnly || str_Notes.MultiUpdate != "1");

            // int_ClassType
            int_ClassType.SetDbValue(rsnew, int_ClassType.CurrentValue, int_ClassType.ReadOnly || int_ClassType.MultiUpdate != "1");

            // str_ZipCodes
            str_ZipCodes.SetDbValue(rsnew, str_ZipCodes.CurrentValue, str_ZipCodes.ReadOnly || str_ZipCodes.MultiUpdate != "1");

            // int_VehicleAssigned
            int_VehicleAssigned.SetDbValue(rsnew, int_VehicleAssigned.CurrentValue, int_VehicleAssigned.ReadOnly || int_VehicleAssigned.MultiUpdate != "1");

            // int_Status
            int_Status.SetDbValue(rsnew, int_Status.CurrentValue, int_Status.ReadOnly || int_Status.MultiUpdate != "1");

            // int_Type
            int_Type.SetDbValue(rsnew, int_Type.CurrentValue, int_Type.ReadOnly || int_Type.MultiUpdate != "1");

            // int_Location
            int_Location.SetDbValue(rsnew, int_Location.CurrentValue, int_Location.ReadOnly || int_Location.MultiUpdate != "1");

            // date_Created
            date_Created.CurrentValue = date_Created.GetAutoUpdateValue();
            date_Created.SetDbValue(rsnew, date_Created.CurrentValue, false);

            // date_Modified
            date_Modified.CurrentValue = date_Modified.GetAutoUpdateValue();
            date_Modified.SetDbValue(rsnew, date_Modified.CurrentValue, false);

            // int_Created_By
            int_Created_By.CurrentValue = int_Created_By.GetAutoUpdateValue();
            int_Created_By.SetDbValue(rsnew, int_Created_By.CurrentValue, false);

            // int_Modified_By
            int_Modified_By.SetDbValue(rsnew, int_Modified_By.CurrentValue, int_Modified_By.ReadOnly || int_Modified_By.MultiUpdate != "1");

            // bit_IsDeleted
            bit_IsDeleted.SetDbValue(rsnew, ConvertToBool(bit_IsDeleted.CurrentValue), bit_IsDeleted.ReadOnly || bit_IsDeleted.MultiUpdate != "1");

            // str_InstPermitNo
            str_InstPermitNo.SetDbValue(rsnew, str_InstPermitNo.CurrentValue, str_InstPermitNo.ReadOnly || str_InstPermitNo.MultiUpdate != "1");

            // date_PermitExpiration
            date_PermitExpiration.SetDbValue(rsnew, date_PermitExpiration.CurrentValue, date_PermitExpiration.ReadOnly || date_PermitExpiration.MultiUpdate != "1");

            // date_InCarPermitIssue
            date_InCarPermitIssue.SetDbValue(rsnew, date_InCarPermitIssue.CurrentValue, date_InCarPermitIssue.ReadOnly || date_InCarPermitIssue.MultiUpdate != "1");

            // str_InClassPermitNo
            str_InClassPermitNo.SetDbValue(rsnew, str_InClassPermitNo.CurrentValue, str_InClassPermitNo.ReadOnly || str_InClassPermitNo.MultiUpdate != "1");

            // date_InClassPermitIssue
            date_InClassPermitIssue.SetDbValue(rsnew, date_InClassPermitIssue.CurrentValue, date_InClassPermitIssue.ReadOnly || date_InClassPermitIssue.MultiUpdate != "1");

            // instructor_caption
            instructor_caption.SetDbValue(rsnew, instructor_caption.CurrentValue, instructor_caption.ReadOnly || instructor_caption.MultiUpdate != "1");

            // str_LicType
            str_LicType.SetDbValue(rsnew, str_LicType.CurrentValue, str_LicType.ReadOnly || str_LicType.MultiUpdate != "1");

            // int_Order
            int_Order.SetDbValue(rsnew, int_Order.CurrentValue, int_Order.ReadOnly || int_Order.MultiUpdate != "1");

            // str_InstLicenceDate
            str_InstLicenceDate.SetDbValue(rsnew, str_InstLicenceDate.CurrentValue, str_InstLicenceDate.ReadOnly || str_InstLicenceDate.MultiUpdate != "1");

            // str_DLNum
            str_DLNum.SetDbValue(rsnew, str_DLNum.CurrentValue, str_DLNum.ReadOnly || str_DLNum.MultiUpdate != "1");

            // str_DLExp
            str_DLExp.SetDbValue(rsnew, str_DLExp.CurrentValue, str_DLExp.ReadOnly || str_DLExp.MultiUpdate != "1");

            // bit_appointmentColor
            bit_appointmentColor.SetDbValue(rsnew, ConvertToBool(bit_appointmentColor.CurrentValue), bit_appointmentColor.ReadOnly || bit_appointmentColor.MultiUpdate != "1");

            // str_appointmentColorCode
            str_appointmentColorCode.SetDbValue(rsnew, str_appointmentColorCode.CurrentValue, str_appointmentColorCode.ReadOnly || str_appointmentColorCode.MultiUpdate != "1");

            // bit_IsSuperAdmin
            bit_IsSuperAdmin.SetDbValue(rsnew, ConvertToBool(bit_IsSuperAdmin.CurrentValue), bit_IsSuperAdmin.ReadOnly || bit_IsSuperAdmin.MultiUpdate != "1");

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.SetDbValue(rsnew, IsDistanceBasedScheduling.CurrentValue, IsDistanceBasedScheduling.ReadOnly || IsDistanceBasedScheduling.MultiUpdate != "1");

            // str_Package_Code
            str_Package_Code.SetDbValue(rsnew, str_Package_Code.CurrentValue, str_Package_Code.ReadOnly || str_Package_Code.MultiUpdate != "1");

            // str_NationalID_Iqama
            str_NationalID_Iqama.SetDbValue(rsnew, str_NationalID_Iqama.CurrentValue, str_NationalID_Iqama.ReadOnly || str_NationalID_Iqama.MultiUpdate != "1");

            // NationalID
            NationalID.SetDbValue(rsnew, NationalID.CurrentValue, NationalID.ReadOnly || NationalID.MultiUpdate != "1");

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.SetDbValue(rsnew, int_RoadDistanceCoverage.CurrentValue, int_RoadDistanceCoverage.ReadOnly || int_RoadDistanceCoverage.MultiUpdate != "1");

            // str_Badge
            str_Badge.SetDbValue(rsnew, str_Badge.CurrentValue, str_Badge.ReadOnly || str_Badge.MultiUpdate != "1");

            // strZoomHostUrl
            strZoomHostUrl.SetDbValue(rsnew, strZoomHostUrl.CurrentValue, strZoomHostUrl.ReadOnly || strZoomHostUrl.MultiUpdate != "1");

            // strZoomUserUrl
            strZoomUserUrl.SetDbValue(rsnew, strZoomUserUrl.CurrentValue, strZoomUserUrl.ReadOnly || strZoomUserUrl.MultiUpdate != "1");

            // Signature
            if (Signature.Visible && !Signature.ReadOnly && ConvertToString(Signature.MultiUpdate) == "1" && !Signature.Upload.KeepFile) {
                rsnew["Signature"] = new SqlBinaryParameter(Signature.Upload.Value);
            }

            // str_VehicleType
            str_VehicleType.SetDbValue(rsnew, str_VehicleType.CurrentValue, str_VehicleType.ReadOnly || str_VehicleType.MultiUpdate != "1");

            // ProfilePicturePath
            ProfilePicturePath.SetDbValue(rsnew, ProfilePicturePath.CurrentValue, ProfilePicturePath.ReadOnly || ProfilePicturePath.MultiUpdate != "1");

            // Institution
            Institution.SetDbValue(rsnew, Institution.CurrentValue, Institution.ReadOnly || Institution.MultiUpdate != "1");

            // IsDrivingexperience
            IsDrivingexperience.SetDbValue(rsnew, ConvertToBool(IsDrivingexperience.CurrentValue), IsDrivingexperience.ReadOnly || IsDrivingexperience.MultiUpdate != "1");

            // intDrivinglicenseType
            intDrivinglicenseType.SetDbValue(rsnew, intDrivinglicenseType.CurrentValue, intDrivinglicenseType.ReadOnly || intDrivinglicenseType.MultiUpdate != "1");

            // AbsherApptNbr
            AbsherApptNbr.SetDbValue(rsnew, AbsherApptNbr.CurrentValue, AbsherApptNbr.ReadOnly || AbsherApptNbr.MultiUpdate != "1");

            // Absherphoto
            if (Absherphoto.Visible && !Absherphoto.ReadOnly && ConvertToString(Absherphoto.MultiUpdate) == "1" && !Absherphoto.Upload.KeepFile) {
                Absherphoto.Upload.DbValue = rsold["Absherphoto"]; // Get original value
                if (Empty(Absherphoto.Upload.FileName)) {
                    rsnew["Absherphoto"] = DbNullValue;
                } else {
                    FixUploadTempFileNames(Absherphoto);
                    rsnew["Absherphoto"] = Absherphoto.Upload.FileName;
                }
            }

            // Fingerprint
            if (Fingerprint.Visible && !Fingerprint.ReadOnly && ConvertToString(Fingerprint.MultiUpdate) == "1" && !Fingerprint.Upload.KeepFile) {
                Fingerprint.Upload.DbValue = rsold["Fingerprint"]; // Get original value
                if (Empty(Fingerprint.Upload.FileName)) {
                    rsnew["Fingerprint"] = DbNullValue;
                } else {
                    FixUploadTempFileNames(Fingerprint);
                    rsnew["Fingerprint"] = Fingerprint.Upload.FileName;
                }
            }

            // ProfileField
            ProfileField.SetDbValue(rsnew, ProfileField.CurrentValue, ProfileField.ReadOnly || ProfileField.MultiUpdate != "1");

            // int_Nationality
            int_Nationality.SetDbValue(rsnew, int_Nationality.CurrentValue, int_Nationality.ReadOnly || int_Nationality.MultiUpdate != "1");

            // User_Role
            User_Role.SetDbValue(rsnew, User_Role.CurrentValue, User_Role.ReadOnly || User_Role.MultiUpdate != "1");

            // int_Staff_Id
            int_Staff_Id.SetDbValue(rsnew, int_Staff_Id.CurrentValue, int_Staff_Id.ReadOnly || int_Staff_Id.MultiUpdate != "1");

            // Update current values
            SetCurrentValues(rsnew);

            // Check field with unique index (str_Cell_Phone)
            if (!Empty(str_Cell_Phone.CurrentValue)) {
                string filterChk = "([str_Cell_Phone] = '" + AdjustSql(str_Cell_Phone.CurrentValue, DbId) + "')";
                filterChk = filterChk + " AND NOT (" + filter + ")";
                try {
                    using var rschk = await LoadReader(filterChk);
                    if (rschk?.HasRows ?? false) {
                        var idxErrMsg = Language.Phrase("DupIndex").Replace("%f", str_Cell_Phone.Caption);
                        idxErrMsg = idxErrMsg.Replace("%v", ConvertToString(str_Cell_Phone.CurrentValue));
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

            // Check field with unique index (AbsherApptNbr)
            if (!Empty(AbsherApptNbr.CurrentValue)) {
                string filterChk = "([AbsherApptNbr] = '" + AdjustSql(AbsherApptNbr.CurrentValue, DbId) + "')";
                filterChk = filterChk + " AND NOT (" + filter + ")";
                try {
                    using var rschk = await LoadReader(filterChk);
                    if (rschk?.HasRows ?? false) {
                        var idxErrMsg = Language.Phrase("DupIndex").Replace("%f", AbsherApptNbr.Caption);
                        idxErrMsg = idxErrMsg.Replace("%v", ConvertToString(AbsherApptNbr.CurrentValue));
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
            if (Absherphoto.Visible && !Absherphoto.Upload.KeepFile) {
                if (!Empty(Absherphoto.Upload.FileName) && UpdateCount == 1) {
                    FixUploadFileNames(Absherphoto);
                    Absherphoto.SetDbValue(rsnew, Absherphoto.Upload.FileName, Absherphoto.ReadOnly || Absherphoto.MultiUpdate != "1");
                }
            }
            if (Fingerprint.Visible && !Fingerprint.Upload.KeepFile) {
                if (!Empty(Fingerprint.Upload.FileName) && UpdateCount == 1) {
                    FixUploadFileNames(Fingerprint);
                    Fingerprint.SetDbValue(rsnew, Fingerprint.Upload.FileName, Fingerprint.ReadOnly || Fingerprint.MultiUpdate != "1");
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
                        if (Fingerprint.Visible && !Fingerprint.Upload.KeepFile) {
                            if (!await SaveUploadFiles(Fingerprint, ConvertToString(rsnew["Fingerprint"]), false))
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblStudentsList")), "", TableVar, true);
            string pageId = "update";
            breadcrumb.Add("update", pageId, url);
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
                // Set up lookup SQL
                switch (fld.FieldVar) {
                    case "x_Hijri_Month":
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
