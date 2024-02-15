namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAppointmentsInfoDelete
    /// </summary>
    public static TblAppointmentsInfoDelete tblAppointmentsInfoDelete
    {
        get => HttpData.Get<TblAppointmentsInfoDelete>("tblAppointmentsInfoDelete")!;
        set => HttpData["tblAppointmentsInfoDelete"] = value;
    }

    /// <summary>
    /// Page class for tblAppointmentsInfo
    /// </summary>
    public class TblAppointmentsInfoDelete : TblAppointmentsInfoDeleteBase
    {
        // Constructor
        public TblAppointmentsInfoDelete(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAppointmentsInfoDelete() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblAppointmentsInfoDeleteBase : TblAppointmentsInfo
    {
        // Page ID
        public string PageID = "delete";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAppointmentsInfo";

        // Page object name
        public string PageObjName = "tblAppointmentsInfoDelete";

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
        public TblAppointmentsInfoDeleteBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-table";

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
        public string PageName => "TblAppointmentsInfoDelete";

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
        public TblAppointmentsInfoDeleteBase(Controller? controller = null): this() { // DN
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Appt_id") ? dict["int_Appt_id"] : int_Appt_id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Appt_id.Visible = false;
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

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Load key parameters
            RecordKeys = GetRecordKeys(); // Load record keys
            string filter = GetFilterFromRecordKeys();
            if (Empty(filter))
                return Terminate("TblAppointmentsInfoList"); // Prevent SQL injection, return to List page

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
                        return Terminate("TblAppointmentsInfoList"); // Return to List page
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
                    return Terminate("TblAppointmentsInfoList"); // Return to list
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
                tblAppointmentsInfoDelete?.PageRender();
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

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_Appt_id

            // str_AppName

            // str_App_Date

            // str_StartTime

            // str_EndTime

            // str_PickupTime

            // str_DropOffTime

            // int_VehicleID

            // dec_InstID

            // dec_StudentID

            // dec_Observed_StudentID

            // int_Apptype

            // int_AppStatus

            // mny_AppCost

            // mny_AmountPaid

            // bit_CheckAppPaid

            // bit_Confirmation

            // str_Instructions

            // str_Instructions1

            // str_AppNotes

            // str_PickupLocation

            // int_Created_By

            // int_Modified_By

            // date_Created

            // date_Modified

            // bit_IsDeleted

            // str_Interval

            // RemM1

            // RemM2

            // RemM3

            // int_Location_ID

            // SPID

            // Chk_Trace

            // str_DropOffLocation

            // imgInstructorSignature

            // imgStudentSignature

            // imgObserverSignature

            // dt_apptstart

            // dt_apptComplete

            // int_apptstartedBy

            // int_apptCompletedBy

            // SMSReminder1

            // SMSReminder2

            // SMSReminder3

            // VoiceReminder1

            // VoiceReminder2

            // VoiceReminder3

            // bit_isroadtest

            // int_slotType

            // bit_VisibleOnPortal

            // IsDataRetrieved

            // bit_chargesApplied

            // dec_DistanceTravelled

            // btwProductIdsforSSRules

            // int_evaluateApptWithEmail

            // PublicNotesId

            // NationalID

            // str_Username

            // int_PackageID

            // int_ApptCldr_ID

            // str_CRSS_ID

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
                str_AppName.TooltipValue = "";

                // str_App_Date
                str_App_Date.HrefValue = "";
                str_App_Date.TooltipValue = "";

                // str_StartTime
                str_StartTime.HrefValue = "";
                str_StartTime.TooltipValue = "";

                // int_Apptype
                int_Apptype.HrefValue = "";
                int_Apptype.TooltipValue = "";

                // int_AppStatus
                int_AppStatus.HrefValue = "";
                int_AppStatus.TooltipValue = "";

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
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblAppointmentsInfoList")), "", TableVar, true);
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
