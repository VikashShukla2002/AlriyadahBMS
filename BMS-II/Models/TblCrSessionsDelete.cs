namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblCrSessionsDelete
    /// </summary>
    public static TblCrSessionsDelete tblCrSessionsDelete
    {
        get => HttpData.Get<TblCrSessionsDelete>("tblCrSessionsDelete")!;
        set => HttpData["tblCrSessionsDelete"] = value;
    }

    /// <summary>
    /// Page class for tblCRSessions
    /// </summary>
    public class TblCrSessionsDelete : TblCrSessionsDeleteBase
    {
        // Constructor
        public TblCrSessionsDelete(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblCrSessionsDelete() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblCrSessionsDeleteBase : TblCrSessions
    {
        // Page ID
        public string PageID = "delete";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblCRSessions";

        // Page object name
        public string PageObjName = "tblCrSessionsDelete";

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
        public TblCrSessionsDeleteBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblCrSessions)
            if (tblCrSessions == null || tblCrSessions is TblCrSessions)
                tblCrSessions = this;

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
        public string PageName => "TblCrSessionsDelete";

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
            int_CRSession_ID.Visible = false;
            str_CR_Number.SetVisibility();
            int_Status.SetVisibility();
            int_Staff_Id.Visible = false;
            Instructor.SetVisibility();
            int_Location_Id.Visible = false;
            Location.SetVisibility();
            int_Session_ID.SetVisibility();
            str_Session_Date.SetVisibility();
            int_Day_ID.SetVisibility();
            str_Day_Name.Visible = false;
            str_Time_Start.SetVisibility();
            str_Time_End.SetVisibility();
            date_Created.Visible = false;
            int_CR_Id.Visible = false;
            str_Notes.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            date_Modified.Visible = false;
            bit_IsDeleted.Visible = false;
            str_Session_Notes.Visible = false;
            is_Rescheduled.Visible = false;
            instructorSignature.Visible = false;
            IsZoomMeet.Visible = false;
            str_ZoomHostUrl.Visible = false;
            str_ZoomUserUrl.Visible = false;
            CR_Row_Index.Visible = false;
            CRSS_ID.Visible = false;
            int_Student_Id.SetVisibility();
            str_Username.SetVisibility();
            str_Status.SetVisibility();
        }

        // Constructor
        public TblCrSessionsDeleteBase(Controller? controller = null): this() { // DN
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
                    SaveDebugMessage();
                    return Controller.LocalRedirect(AppPath(url));
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_CRSession_ID") ? dict["int_CRSession_ID"] : int_CRSession_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_CRSession_ID.Visible = false;
        }

        public string DbMasterFilter = "";

        public string DbDetailFilter = "";

        public int StartRecord;

        public int TotalRecords;

        public int RecordCount;

        public List<string> RecordKeys = new ();

        public DbDataReader? Recordset;

        public int StartRowCount = 1;

        public bool IsModal = false;

        /// <summary>
        /// Page run
        /// </summary>
        /// <returns>Page result</returns>
        public override async Task<IActionResult> Run()
        {
            // Use layout
            if (!Empty(Param("layout")) && !Param<bool>("layout"))
                UseLayout = false;

            // User profile
            Profile = ResolveProfile();

            // Security
            Security = ResolveSecurity();
            if (TableVar != "")
                Security.LoadTablePermissions(TableVar);
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
            await SetupLookupOptions(IsZoomMeet);

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Load key parameters
            RecordKeys = GetRecordKeys(); // Load record keys
            string filter = GetFilterFromRecordKeys();
            if (Empty(filter))
                return Terminate("TblCrSessionsList"); // Prevent SQL injection, return to List page

            // Set up filter (WHERE Clause)
            CurrentFilter = filter;

            // Get action
            if (IsApi()) {
                CurrentAction = "delete"; // Delete record directly
            } else if (!Empty(Param("action"))) {
                CurrentAction = Param("action") == "delete" ? "delete" : "show";
            } else {
                CurrentAction = InlineDelete ?
                    "delete" : // Delete record directly
                    "show"; // Display record
            }
            if (IsDelete) { // DN
                SendEmail = true; // Send email on delete success
                var res = await DeleteRows();
                if (res) { // Delete rows
                    if (Empty(SuccessMessage))
                        SuccessMessage = Language.Phrase("DeleteSuccess"); // Set up success message
                    if (IsJsonResponse()) {
                        ClearMessages(); // Clear messages for Json response
                        return res;
                    } else {
                        return Terminate(ReturnUrl); // Return to caller
                    }
                } else { // Delete failed
                    if (IsJsonResponse()) {
                        return Terminate();
                    }
                    // Return JSON error message if UseAjaxActions
                    if (UseAjaxActions)
                        return Controller.Json(new { success = false, error = GetFailureMessage() });
                    if (InlineDelete)
                        return Terminate(ReturnUrl); // Return to caller
                    else
                        CurrentAction = "show"; // Display record
                }
            }
            if (IsShow) { // Load records for display // DN
                Recordset = await LoadRecordset();
                TotalRecords = await ListRecordCountAsync(); // Get record count
                if (TotalRecords <= 0) { // No record found, exit
                    CloseRecordset(); // DN
                    return Terminate("TblCrSessionsList"); // Return to list
                }
            }

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                tblCrSessionsDelete?.PageRender();
            }
            return PageResult();
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
            int_CRSession_ID.SetDbValue(row["int_CRSession_ID"]);
            str_CR_Number.SetDbValue(row["str_CR_Number"]);
            int_Status.SetDbValue(row["int_Status"]);
            int_Staff_Id.SetDbValue(row["int_Staff_Id"]);
            Instructor.SetDbValue(row["Instructor"]);
            int_Location_Id.SetDbValue(row["int_Location_Id"]);
            Location.SetDbValue(row["Location"]);
            int_Session_ID.SetDbValue(row["int_Session_ID"]);
            str_Session_Date.SetDbValue(row["str_Session_Date"]);
            int_Day_ID.SetDbValue(row["int_Day_ID"]);
            str_Day_Name.SetDbValue(row["str_Day_Name"]);
            str_Time_Start.SetDbValue(row["str_Time_Start"]);
            str_Time_End.SetDbValue(row["str_Time_End"]);
            date_Created.SetDbValue(row["date_Created"]);
            int_CR_Id.SetDbValue(row["int_CR_Id"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_Session_Notes.SetDbValue(row["str_Session_Notes"]);
            is_Rescheduled.SetDbValue(row["is_Rescheduled"]);
            instructorSignature.Upload.DbValue = row["instructorSignature"];
            IsZoomMeet.SetDbValue((ConvertToBool(row["IsZoomMeet"]) ? "1" : "0"));
            str_ZoomHostUrl.SetDbValue(row["str_ZoomHostUrl"]);
            str_ZoomUserUrl.SetDbValue(row["str_ZoomUserUrl"]);
            CR_Row_Index.SetDbValue(row["CR_Row_Index"]);
            CRSS_ID.SetDbValue(row["CRSS_ID"]);
            int_Student_Id.SetDbValue(row["int_Student_Id"]);
            str_Username.SetDbValue(row["str_Username"]);
            str_Status.SetDbValue(row["str_Status"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_CRSession_ID", int_CRSession_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CR_Number", str_CR_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Staff_Id", int_Staff_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("Instructor", Instructor.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_Id", int_Location_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("Location", Location.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Session_ID", int_Session_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Session_Date", str_Session_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Day_ID", int_Day_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Day_Name", str_Day_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Time_Start", str_Time_Start.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Time_End", str_Time_End.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_Id", int_CR_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Session_Notes", str_Session_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("is_Rescheduled", is_Rescheduled.DefaultValue ?? DbNullValue); // DN
            row.Add("instructorSignature", instructorSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("IsZoomMeet", IsZoomMeet.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ZoomHostUrl", str_ZoomHostUrl.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ZoomUserUrl", str_ZoomUserUrl.DefaultValue ?? DbNullValue); // DN
            row.Add("CR_Row_Index", CR_Row_Index.DefaultValue ?? DbNullValue); // DN
            row.Add("CRSS_ID", CRSS_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_Id", int_Student_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Status", str_Status.DefaultValue ?? DbNullValue); // DN
            return row;
        }

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_CRSession_ID

            // str_CR_Number

            // int_Status

            // int_Staff_Id

            // Instructor

            // int_Location_Id

            // Location

            // int_Session_ID

            // str_Session_Date

            // int_Day_ID

            // str_Day_Name

            // str_Time_Start

            // str_Time_End

            // date_Created

            // int_CR_Id

            // str_Notes

            // int_Created_By

            // int_Modified_By

            // date_Modified

            // bit_IsDeleted

            // str_Session_Notes

            // is_Rescheduled

            // instructorSignature

            // IsZoomMeet

            // str_ZoomHostUrl

            // str_ZoomUserUrl

            // CR_Row_Index

            // CRSS_ID

            // int_Student_Id

            // str_Username

            // str_Status

            // View row
            if (RowType == RowType.View) {
                // int_CRSession_ID
                int_CRSession_ID.ViewValue = int_CRSession_ID.CurrentValue;
                int_CRSession_ID.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.ViewValue = ConvertToString(str_CR_Number.CurrentValue); // DN
                str_CR_Number.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // int_Staff_Id
                int_Staff_Id.ViewValue = int_Staff_Id.CurrentValue;
                int_Staff_Id.ViewValue = FormatNumber(int_Staff_Id.ViewValue, int_Staff_Id.FormatPattern);
                int_Staff_Id.ViewCustomAttributes = "";

                // Instructor
                Instructor.ViewValue = ConvertToString(Instructor.CurrentValue); // DN
                Instructor.ViewCustomAttributes = "";

                // int_Location_Id
                int_Location_Id.ViewValue = int_Location_Id.CurrentValue;
                int_Location_Id.ViewValue = FormatNumber(int_Location_Id.ViewValue, int_Location_Id.FormatPattern);
                int_Location_Id.ViewCustomAttributes = "";

                // Location
                Location.ViewValue = ConvertToString(Location.CurrentValue); // DN
                Location.ViewCustomAttributes = "";

                // int_Session_ID
                int_Session_ID.ViewValue = int_Session_ID.CurrentValue;
                int_Session_ID.ViewValue = FormatNumber(int_Session_ID.ViewValue, int_Session_ID.FormatPattern);
                int_Session_ID.ViewCustomAttributes = "";

                // str_Session_Date
                str_Session_Date.ViewValue = ConvertToString(str_Session_Date.CurrentValue); // DN
                str_Session_Date.ViewCustomAttributes = "";

                // int_Day_ID
                int_Day_ID.ViewValue = int_Day_ID.CurrentValue;
                int_Day_ID.ViewValue = FormatNumber(int_Day_ID.ViewValue, int_Day_ID.FormatPattern);
                int_Day_ID.ViewCustomAttributes = "";

                // str_Day_Name
                str_Day_Name.ViewValue = ConvertToString(str_Day_Name.CurrentValue); // DN
                str_Day_Name.ViewCustomAttributes = "";

                // str_Time_Start
                str_Time_Start.ViewValue = ConvertToString(str_Time_Start.CurrentValue); // DN
                str_Time_Start.ViewCustomAttributes = "";

                // str_Time_End
                str_Time_End.ViewValue = ConvertToString(str_Time_End.CurrentValue); // DN
                str_Time_End.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // int_CR_Id
                int_CR_Id.ViewValue = int_CR_Id.CurrentValue;
                int_CR_Id.ViewValue = FormatNumber(int_CR_Id.ViewValue, int_CR_Id.FormatPattern);
                int_CR_Id.ViewCustomAttributes = "";

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

                // str_Session_Notes
                str_Session_Notes.ViewValue = ConvertToString(str_Session_Notes.CurrentValue); // DN
                str_Session_Notes.ViewCustomAttributes = "";

                // is_Rescheduled
                is_Rescheduled.ViewValue = is_Rescheduled.CurrentValue;
                is_Rescheduled.ViewValue = FormatNumber(is_Rescheduled.ViewValue, is_Rescheduled.FormatPattern);
                is_Rescheduled.ViewCustomAttributes = "";

                // IsZoomMeet
                if (ConvertToBool(IsZoomMeet.CurrentValue)) {
                    IsZoomMeet.ViewValue = IsZoomMeet.TagCaption(1) != "" ? IsZoomMeet.TagCaption(1) : "Yes";
                } else {
                    IsZoomMeet.ViewValue = IsZoomMeet.TagCaption(2) != "" ? IsZoomMeet.TagCaption(2) : "No";
                }
                IsZoomMeet.ViewCustomAttributes = "";

                // str_ZoomHostUrl
                str_ZoomHostUrl.ViewValue = ConvertToString(str_ZoomHostUrl.CurrentValue); // DN
                str_ZoomHostUrl.ViewCustomAttributes = "";

                // str_ZoomUserUrl
                str_ZoomUserUrl.ViewValue = ConvertToString(str_ZoomUserUrl.CurrentValue); // DN
                str_ZoomUserUrl.ViewCustomAttributes = "";

                // CR_Row_Index
                CR_Row_Index.ViewValue = CR_Row_Index.CurrentValue;
                CR_Row_Index.ViewValue = FormatNumber(CR_Row_Index.ViewValue, CR_Row_Index.FormatPattern);
                CR_Row_Index.ViewCustomAttributes = "";

                // CRSS_ID
                CRSS_ID.ViewValue = CRSS_ID.CurrentValue;
                CRSS_ID.ViewValue = FormatNumber(CRSS_ID.ViewValue, CRSS_ID.FormatPattern);
                CRSS_ID.ViewCustomAttributes = "";

                // int_Student_Id
                int_Student_Id.ViewValue = int_Student_Id.CurrentValue;
                int_Student_Id.ViewValue = FormatNumber(int_Student_Id.ViewValue, int_Student_Id.FormatPattern);
                int_Student_Id.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // str_Status
                str_Status.ViewValue = ConvertToString(str_Status.CurrentValue); // DN
                str_Status.ViewCustomAttributes = "";

                // str_CR_Number
                str_CR_Number.HrefValue = "";
                str_CR_Number.TooltipValue = "";

                // int_Status
                int_Status.HrefValue = "";
                int_Status.TooltipValue = "";

                // Instructor
                Instructor.HrefValue = "";
                Instructor.TooltipValue = "";

                // Location
                Location.HrefValue = "";
                Location.TooltipValue = "";

                // int_Session_ID
                int_Session_ID.HrefValue = "";
                int_Session_ID.TooltipValue = "";

                // str_Session_Date
                str_Session_Date.HrefValue = "";
                str_Session_Date.TooltipValue = "";

                // int_Day_ID
                int_Day_ID.HrefValue = "";
                int_Day_ID.TooltipValue = "";

                // str_Time_Start
                str_Time_Start.HrefValue = "";
                str_Time_Start.TooltipValue = "";

                // str_Time_End
                str_Time_End.HrefValue = "";
                str_Time_End.TooltipValue = "";

                // int_Student_Id
                int_Student_Id.HrefValue = "";
                int_Student_Id.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // str_Status
                str_Status.HrefValue = "";
                str_Status.TooltipValue = "";
            }

            // Call Row Rendered event
            if (RowType != RowType.AggregateInit)
                RowRendered();
        }
        #pragma warning restore 1998

        // Delete records (based on current filter)
        protected async Task<JsonBoolResult> DeleteRows() { // DN
            if (!Security.CanDelete) {
                FailureMessage = Language.Phrase("NoDeletePermission"); // No delete permission
                return JsonBoolResult.FalseResult; // No delete permission
            }
            List<Dictionary<string, object>>? rsold = null;
            bool result = true;
            try {
                string sql = CurrentSql;
                using var rs = await Connection.GetDataReaderAsync(sql);
                if (rs == null) {
                    return JsonBoolResult.FalseResult;
                } else if (!rs.HasRows) {
                    FailureMessage = Language.Phrase("NoRecord"); // No record found
                    return JsonBoolResult.FalseResult;
                } else { // Clone old rows
                    rsold = await Connection.GetRowsAsync(rs);
                }
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }
            if (UseTransaction)
                Connection.BeginTrans();
            if (AuditTrailOnDelete)
                await WriteAuditTrailLog(Language.Phrase("BatchDeleteBegin")); // Batch delete begin
            List<string> successKeys = new (), failKeys = new ();
            try {
                // Call Row Deleting event
                if (result)
                    result = rsold.All(row => RowDeleting(row));
                if (result) {
                    foreach (var row in rsold) {
                        try {
                            result = await DeleteAsync(row) > 0;
                        } catch (Exception e) {
                            if (Config.Debug)
                                throw;
                            FailureMessage = e.Message; // Set up error message
                            result = false;
                        }
                        if (!result) {
                            if (UseTransaction) {
                                successKeys.Clear();
                                break;
                            }
                            failKeys.Add(GetKey(row)); // DN
                        } else {
                            if (Config.DeleteUploadFiles)
                                DeleteUploadedFiles(row);
                            RowDeleted(row);
                            successKeys.Add(GetKey(row)); // DN
                        }
                    }
                }
                result = successKeys.Count > 0;
                if (!result) {
                    // Set up error message
                    if (!Empty(SuccessMessage) || !Empty(FailureMessage)) {
                        // Use the message, do nothing
                    } else if (!Empty(CancelMessage)) {
                        FailureMessage = CancelMessage;
                        CancelMessage = "";
                    } else {
                        FailureMessage = Language.Phrase("DeleteCancelled");
                    }
                }
            } catch (Exception e) {
                FailureMessage = e.Message;
                result = false;
            }
            if (result) {
                if (UseTransaction)
                    Connection.CommitTrans(); // Commit the changes

                // Set warning message if delete some records failed
                if (failKeys.Count > 0)
                    WarningMessage = Language.Phrase("DeleteRecordsFailed").Replace("%k", String.Join(", ", failKeys));
                if (AuditTrailOnDelete)
                    await WriteAuditTrailLog(Language.Phrase("BatchDeleteSuccess")); // Batch delete success
            } else {
                if (UseTransaction)
                    Connection.RollbackTrans(); // Rollback changes
                if (AuditTrailOnDelete)
                    await WriteAuditTrailLog(Language.Phrase("BatchDeleteRollback")); // Batch delete rollback
            }

            // Write JSON for API request
            Dictionary<string, object> d = new ();
            d.Add("success", result);
            if (IsJsonResponse() && result) {
                var rows = await GetRecordsFromRecordset(rsold);
                string table = TableVar;
                d.Add(table, RouteValues.Count > 2 && rows.Count == 1 ? rows[0] : rows); // If single-delete, route values are controller/action/id (count > 2)
                d.Add("action", Config.ApiDeleteAction);
                d.Add("version", Config.ProductVersion);
                return new JsonBoolResult(d, true);
            }
            return new JsonBoolResult(d, result);
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblCrSessionsList")), "", TableVar, true);
            string pageId = "delete";
            breadcrumb.Add("delete", pageId, url);
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
    } // End page class
} // End Partial class
