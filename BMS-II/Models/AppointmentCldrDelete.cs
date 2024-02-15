namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// appointmentCldrDelete
    /// </summary>
    public static AppointmentCldrDelete appointmentCldrDelete
    {
        get => HttpData.Get<AppointmentCldrDelete>("appointmentCldrDelete")!;
        set => HttpData["appointmentCldrDelete"] = value;
    }

    /// <summary>
    /// Page class for Appointment_Cldr
    /// </summary>
    public class AppointmentCldrDelete : AppointmentCldrDeleteBase
    {
        // Constructor
        public AppointmentCldrDelete(Controller controller) : base(controller)
        {
        }

        // Constructor
        public AppointmentCldrDelete() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class AppointmentCldrDeleteBase : AppointmentCldr
    {
        // Page ID
        public string PageID = "delete";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "Appointment_Cldr";

        // Page object name
        public string PageObjName = "appointmentCldrDelete";

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
        public AppointmentCldrDeleteBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (appointmentCldr)
            if (appointmentCldr == null || appointmentCldr is AppointmentCldr)
                appointmentCldr = this;

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
        public string PageName => "AppointmentCldrDelete";

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
            Id.Visible = false;
            int_Enrollement_Id.SetVisibility();
            int_PackageID.SetVisibility();
            _Title.Visible = false;
            Start.SetVisibility();
            End.SetVisibility();
            AllDay.Visible = false;
            Description.Visible = false;
            _Url.Visible = false;
            Display.Visible = false;
            BackgroundColor.Visible = false;
            CRSS_ID.Visible = false;
            str_AppointmentType.SetVisibility();
            str_AppointmentStatus.SetVisibility();
            str_Username.Visible = false;
            str_CRSS_IDUSER.Visible = false;
        }

        // Constructor
        public AppointmentCldrDeleteBase(Controller? controller = null): this() { // DN
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("Id") ? dict["Id"] : Id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                Id.Visible = false;
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
            await SetupLookupOptions(int_Enrollement_Id);
            await SetupLookupOptions(int_PackageID);
            await SetupLookupOptions(AllDay);
            await SetupLookupOptions(str_AppointmentType);
            await SetupLookupOptions(str_AppointmentStatus);

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Load key parameters
            RecordKeys = GetRecordKeys(); // Load record keys
            string filter = GetFilterFromRecordKeys();
            if (Empty(filter))
                return Terminate("AppointmentCldrList"); // Prevent SQL injection, return to List page

            // Set up filter (WHERE Clause)
            CurrentFilter = filter;

            // Check if valid User ID
            string sql = GetSql(CurrentFilter);
            using (Recordset = await Connection.OpenDataReaderAsync(sql)) {
                if (Recordset != null) {
                    bool res = true;
                    while (await Recordset.ReadAsync()) {
                        await LoadRowValues(Recordset);
                        if (!ShowOptionLink("delete")) {
                            string userIdMsg = Language.Phrase("NoDeletePermission");
                            FailureMessage = userIdMsg;
                            res = false;
                            break;
                        }
                    }
                    if (!res)
                        return Terminate("AppointmentCldrList"); // Return to List page
                }
            }

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
                    return Terminate("AppointmentCldrList"); // Return to list
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
                appointmentCldrDelete?.PageRender();
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
            Id.SetDbValue(row["Id"]);
            int_Enrollement_Id.SetDbValue(row["int_Enrollement_Id"]);
            int_PackageID.SetDbValue(row["int_PackageID"]);
            _Title.SetDbValue(row["Title"]);
            Start.SetDbValue(row["Start"]);
            End.SetDbValue(row["End"]);
            AllDay.SetDbValue((ConvertToBool(row["AllDay"]) ? "1" : "0"));
            Description.SetDbValue(row["Description"]);
            _Url.SetDbValue(row["Url"]);
            Display.SetDbValue(row["Display"]);
            BackgroundColor.SetDbValue(row["BackgroundColor"]);
            CRSS_ID.SetDbValue(row["CRSS_ID"]);
            str_AppointmentType.SetDbValue(row["str_AppointmentType"]);
            str_AppointmentStatus.SetDbValue(row["str_AppointmentStatus"]);
            str_Username.SetDbValue(row["str_Username"]);
            str_CRSS_IDUSER.SetDbValue(row["str_CRSS_IDUSER"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("Id", Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Enrollement_Id", int_Enrollement_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PackageID", int_PackageID.DefaultValue ?? DbNullValue); // DN
            row.Add("Title", _Title.DefaultValue ?? DbNullValue); // DN
            row.Add("Start", Start.DefaultValue ?? DbNullValue); // DN
            row.Add("End", End.DefaultValue ?? DbNullValue); // DN
            row.Add("AllDay", AllDay.DefaultValue ?? DbNullValue); // DN
            row.Add("Description", Description.DefaultValue ?? DbNullValue); // DN
            row.Add("Url", _Url.DefaultValue ?? DbNullValue); // DN
            row.Add("Display", Display.DefaultValue ?? DbNullValue); // DN
            row.Add("BackgroundColor", BackgroundColor.DefaultValue ?? DbNullValue); // DN
            row.Add("CRSS_ID", CRSS_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AppointmentType", str_AppointmentType.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AppointmentStatus", str_AppointmentStatus.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CRSS_IDUSER", str_CRSS_IDUSER.DefaultValue ?? DbNullValue); // DN
            return row;
        }

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // Id

            // int_Enrollement_Id

            // int_PackageID

            // Title

            // Start

            // End

            // AllDay

            // Description

            // Url

            // Display

            // BackgroundColor

            // CRSS_ID

            // str_AppointmentType

            // str_AppointmentStatus

            // str_Username

            // str_CRSS_IDUSER
            str_CRSS_IDUSER.CellCssStyle = "white-space: nowrap;";

            // View row
            if (RowType == RowType.View) {
                // Id
                Id.ViewValue = Id.CurrentValue;
                Id.ViewCustomAttributes = "";

                // int_Enrollement_Id
                curVal = ConvertToString(int_Enrollement_Id.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Enrollement_Id.Lookup != null && IsDictionary(int_Enrollement_Id.Lookup?.Options) && int_Enrollement_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Enrollement_Id.ViewValue = int_Enrollement_Id.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Enrollement_Id]", "=", int_Enrollement_Id.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Enrollement_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Enrollement_Id.Lookup != null) { // Lookup values found
                            var listwrk = int_Enrollement_Id.Lookup?.RenderViewRow(rswrk[0]);
                            int_Enrollement_Id.ViewValue = int_Enrollement_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Enrollement_Id.DisplayValue(listwrk));
                        } else {
                            int_Enrollement_Id.ViewValue = FormatNumber(int_Enrollement_Id.CurrentValue, int_Enrollement_Id.FormatPattern);
                        }
                    }
                } else {
                    int_Enrollement_Id.ViewValue = DbNullValue;
                }
                int_Enrollement_Id.ViewCustomAttributes = "";

                // int_PackageID
                curVal = ConvertToString(int_PackageID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_PackageID.Lookup != null && IsDictionary(int_PackageID.Lookup?.Options) && int_PackageID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_PackageID.ViewValue = int_PackageID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_PackageID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_PackageID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_PackageID.Lookup != null) { // Lookup values found
                            var listwrk = int_PackageID.Lookup?.RenderViewRow(rswrk[0]);
                            int_PackageID.ViewValue = int_PackageID.HighlightLookup(ConvertToString(rswrk[0]), int_PackageID.DisplayValue(listwrk));
                        } else {
                            int_PackageID.ViewValue = FormatNumber(int_PackageID.CurrentValue, int_PackageID.FormatPattern);
                        }
                    }
                } else {
                    int_PackageID.ViewValue = DbNullValue;
                }
                int_PackageID.ViewCustomAttributes = "";

                // Title
                _Title.ViewValue = ConvertToString(_Title.CurrentValue); // DN
                _Title.ViewCustomAttributes = "";

                // Start
                Start.ViewValue = Start.CurrentValue;
                Start.ViewValue = FormatDateTime(Start.ViewValue, Start.FormatPattern);
                Start.ViewCustomAttributes = "";

                // End
                End.ViewValue = End.CurrentValue;
                End.ViewValue = FormatDateTime(End.ViewValue, End.FormatPattern);
                End.ViewCustomAttributes = "";

                // AllDay
                if (ConvertToBool(AllDay.CurrentValue)) {
                    AllDay.ViewValue = AllDay.TagCaption(1) != "" ? AllDay.TagCaption(1) : "Yes";
                } else {
                    AllDay.ViewValue = AllDay.TagCaption(2) != "" ? AllDay.TagCaption(2) : "No";
                }
                AllDay.ViewCustomAttributes = "";

                // Url
                _Url.ViewValue = ConvertToString(_Url.CurrentValue); // DN
                _Url.ViewCustomAttributes = "";

                // Display
                Display.ViewValue = ConvertToString(Display.CurrentValue); // DN
                Display.ViewCustomAttributes = "";

                // BackgroundColor
                BackgroundColor.ViewValue = ConvertToString(BackgroundColor.CurrentValue); // DN
                BackgroundColor.ViewCustomAttributes = "";

                // CRSS_ID
                CRSS_ID.ViewValue = ConvertToString(CRSS_ID.CurrentValue); // DN
                CRSS_ID.ViewCustomAttributes = "";

                // str_AppointmentType
                curVal = ConvertToString(str_AppointmentType.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_AppointmentType.Lookup != null && IsDictionary(str_AppointmentType.Lookup?.Options) && str_AppointmentType.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_AppointmentType.ViewValue = str_AppointmentType.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[Service_Description]", "=", str_AppointmentType.CurrentValue, DataType.String, "");
                        sqlWrk = str_AppointmentType.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_AppointmentType.Lookup != null) { // Lookup values found
                            var listwrk = str_AppointmentType.Lookup?.RenderViewRow(rswrk[0]);
                            str_AppointmentType.ViewValue = str_AppointmentType.HighlightLookup(ConvertToString(rswrk[0]), str_AppointmentType.DisplayValue(listwrk));
                        } else {
                            str_AppointmentType.ViewValue = str_AppointmentType.CurrentValue;
                        }
                    }
                } else {
                    str_AppointmentType.ViewValue = DbNullValue;
                }
                str_AppointmentType.ViewCustomAttributes = "";

                // str_AppointmentStatus
                if (!Empty(str_AppointmentStatus.CurrentValue)) {
                    str_AppointmentStatus.ViewValue = str_AppointmentStatus.HighlightLookup(ConvertToString(str_AppointmentStatus.CurrentValue), str_AppointmentStatus.OptionCaption(ConvertToString(str_AppointmentStatus.CurrentValue)));
                } else {
                    str_AppointmentStatus.ViewValue = DbNullValue;
                }
                str_AppointmentStatus.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = str_Username.CurrentValue;
                str_Username.ViewCustomAttributes = "";

                // str_CRSS_IDUSER
                str_CRSS_IDUSER.ViewValue = ConvertToString(str_CRSS_IDUSER.CurrentValue); // DN
                str_CRSS_IDUSER.ViewCustomAttributes = "";

                // int_Enrollement_Id
                int_Enrollement_Id.HrefValue = "";
                int_Enrollement_Id.TooltipValue = "";

                // int_PackageID
                int_PackageID.HrefValue = "";
                int_PackageID.TooltipValue = "";

                // Start
                Start.HrefValue = "";
                Start.TooltipValue = "";

                // End
                End.HrefValue = "";
                End.TooltipValue = "";

                // str_AppointmentType
                str_AppointmentType.HrefValue = "";
                str_AppointmentType.TooltipValue = "";

                // str_AppointmentStatus
                str_AppointmentStatus.HrefValue = "";
                str_AppointmentStatus.TooltipValue = "";
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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("AppointmentCldrList")), "", TableVar, true);
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
