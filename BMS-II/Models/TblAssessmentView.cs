namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAssessmentView
    /// </summary>
    public static TblAssessmentView tblAssessmentView
    {
        get => HttpData.Get<TblAssessmentView>("tblAssessmentView")!;
        set => HttpData["tblAssessmentView"] = value;
    }

    /// <summary>
    /// Page class for tblAssessment
    /// </summary>
    public class TblAssessmentView : TblAssessmentViewBase
    {
        // Constructor
        public TblAssessmentView(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAssessmentView() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblAssessmentViewBase : TblAssessment
    {
        // Page ID
        public string PageID = "view";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAssessment";

        // Page object name
        public string PageObjName = "tblAssessmentView";

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
        public TblAssessmentViewBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-view-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblAssessment)
            if (tblAssessment == null || tblAssessment is TblAssessment)
                tblAssessment = this;

            // DN
            string[] keys = new string[0];
            StringValues str = "";
            object? obj = null;
            string currentPageName = CurrentPageName();
            string currentUrl = AppPath(currentPageName); // DN
            if (IsApi()) {
                if (RouteValues.TryGetValue("key", out object? k) && !Empty(k))
                    keys = ConvertToString(k).Split('/');
                if (keys.Length > 0)
                    RecordKeys["AssessmentID"] = keys[0];
            } else {
                RecordKeys["AssessmentID"] = RouteValues.TryGetValue("AssessmentID", out obj) && obj != null ? UrlDecode(obj) : Get("AssessmentID"); // DN
            }

            // Start time
            StartTime = Environment.TickCount;

            // Debug message
            LoadDebugMessage();

            // Open connection
            Conn = Connection; // DN

            // User table object (tblStudents)
            UserTable = Resolve("usertable")!;
            UserTableConn = GetConnection(UserTable.DbId);

            // Other options
            OtherOptions["detail"] = new () { TagClassName = "ew-detail-option" };
            OtherOptions["action"] = new () { TagClassName = "ew-action-option" };
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
        public string PageName => "TblAssessmentView";

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

        // Update URLs
        public string InlineAddUrl = "";

        public string GridAddUrl = "";

        public string GridEditUrl = "";

        public string MultiEditUrl = "";

        public string MultiDeleteUrl = "";

        public string MultiUpdateUrl = "";

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
            AssessmentID.SetVisibility();
            str_Full_Name_Hdr.SetVisibility();
            str_First_Name.SetVisibility();
            str_Middle_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Username.SetVisibility();
            int_Student_ID.SetVisibility();
            NationalID.SetVisibility();
            Assessment_Type.SetVisibility();
            AssessmentDate.SetVisibility();
            AssessmentTime.SetVisibility();
            isAssessmentDone.SetVisibility();
            AssessmentScore.SetVisibility();
            Assessment_Instructor.SetVisibility();
            Date_Entered.SetVisibility();
            IsDrivingexperience.SetVisibility();
            intDrivinglicenseType.SetVisibility();
            AbsherApptNbr.SetVisibility();
            Absherphoto.SetVisibility();
            date_Birth.SetVisibility();
            date_Birth_Hijri.SetVisibility();
            str_Cell_Phone.SetVisibility();
            str_Email.SetVisibility();
            UserlevelID.SetVisibility();
            BackDateChk.SetVisibility();
            DriveTypelink.SetVisibility();
            Calendar_ID.SetVisibility();
            Assessmnt_Time.SetVisibility();
            Institution.SetVisibility();
            TheoreticalScore.SetVisibility();
            dt_TheoreticalScore.SetVisibility();
            RoadTestScore.SetVisibility();
            dt_RoadTestScore.SetVisibility();
            AccidentOccurrence.SetVisibility();
            Dt_AccidentOccurrence.SetVisibility();
            AccidentNotes.SetVisibility();
        }

        // Constructor
        public TblAssessmentViewBase(Controller? controller = null): this() { // DN
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

        public int DisplayRecords = 1; // Number of display records

        public int StartRecord;

        public int StopRecord;

        public int TotalRecords = -1;

        public int RecordRange = 10;

        public int RecordCount;

        public Dictionary<string, string> RecordKeys = new ();

        public bool IsModal = false;

        public string SearchWhere = "";

        public string DbMasterFilter = "";

        public string DbDetailFilter = "";

        public bool MasterRecordExists;

        public DbDataReader? Recordset = null;

        public SubPages? MultiPages; // Multi pages object

        #pragma warning disable 168, 219
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

            // Get export parameters
            string custom = "";
            if (!Empty(Param("export"))) {
                Export = Param("export");
                custom = Param("custom");
            } else {
                ExportReturnUrl = CurrentUrl();
            }
            ExportType = Export; // Get export parameter, used in header
            if (!Empty(ExportType))
                SkipHeaderFooter = true;
            if (!Empty(Export) && !SameText(Export, "print") && Empty(custom)) // No layout for export // DN
                UseLayout = false;
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

            // Load current record
            bool loadCurrentRecord = false;
            string returnUrl = "";
            bool matchRecord = false;

            // Set up master/detail parameters
            SetupMasterParms();
            string[] keyValues = {};
            object? v;
            StringValues sv;
            if (IsApi()) {
                if (RouteValues.TryGetValue(Config.ApiKeyName, out object? k)) {
                    if (!Empty(k))
                        keyValues = ConvertToString(k).Split('/');
                } else { // Get key from query string
                    string key = Get(Config.ApiKeyName);
                    if (!Empty(key))
                        keyValues = key.Split(',');
                }
                if (keyValues.Length == 0)
                    return new JsonBoolResult(new { success = false, error = Language.Phrase("NoRecord"), version = Config.ProductVersion }, false);
            }
            if (RouteValues.TryGetValue("AssessmentID", out v) && !Empty(v)) { // DN
                AssessmentID.QueryValue = UrlDecode(v); // DN
                RecordKeys["AssessmentID"] = AssessmentID.QueryValue;
            } else if (Get("AssessmentID", out sv)) {
                AssessmentID.QueryValue = sv.ToString();
                RecordKeys["AssessmentID"] = AssessmentID.QueryValue;
            } else if (IsApi() && !Empty(keyValues)) {
                AssessmentID.QueryValue = ConvertToString(keyValues[0]);
                RecordKeys["AssessmentID"] = AssessmentID.QueryValue;
            } else if (!loadCurrentRecord) {
                returnUrl = "TblAssessmentList"; // Return to list
            }

            // Get action
            CurrentAction = "show"; // Display form
            switch (CurrentAction) {
                case "show": // Get a record to display
                        bool res;
                        if (IsApi()) {
                            string filter = GetRecordFilter();
                            CurrentFilter = filter;
                            string sql = CurrentSql;
                            var conn = await GetConnectionAsync();
                            Recordset = await conn.GetDataReaderAsync(sql);
                            res = !Empty(Recordset) && await Recordset.ReadAsync();
                        } else {
                            res = await LoadRow();
                        }
                        if (!res) { // Load record based on key
                            if (Empty(SuccessMessage) && Empty(FailureMessage))
                                FailureMessage = Language.Phrase("NoRecord"); // Set no record message
                            if (IsApi()) {
                                if (!Empty(SuccessMessage))
                                    return new JsonBoolResult(new { success = true, message = SuccessMessage, version = Config.ProductVersion }, true);
                                else
                                    return new JsonBoolResult(new { success = false, error = FailureMessage, version = Config.ProductVersion }, false);
                            } else {
                                return Terminate("TblAssessmentList"); // Return to list page
                            }
                        }
                    break;
            }
            if (!Empty(returnUrl))
                return Terminate(returnUrl);

            // Render row
            RowType = RowType.View;
            ResetAttributes();
            await RenderRow();

            // Setup export options
            SetupExportOptions();

            // Set up Breadcrumb
            if (!IsExport())
                SetupBreadcrumb();

            // Set up detail parameters
            SetupDetailParms();

            // Normal return
            if (IsApi()) // Get current record only
                if (!IsExport())
                    return Controller.Json(new { success = true, TableVar = await GetRecordFromRecordset(Recordset), version = Config.ProductVersion });

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                tblAssessmentView?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 168, 219

        // Set up other options
        #pragma warning disable 168, 219

        public void SetupOtherOptions()
        {
            var options = OtherOptions;
            var option = options["action"];
            ListOption item;
            string links = "";

            // Edit
            item = option.Add("edit");
            var editTitle = Language.Phrase("ViewPageEditLink", true);
            if (IsModal) // Modal
                item.Body = "<a class=\"ew-action ew-edit\" title=\"" + editTitle + "\" data-caption=\"" + editTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("ViewPageEditLink") + "</a>";
            else
                item.Body = "<a class=\"ew-action ew-edit\" title=\"" + editTitle + "\" data-caption=\"" + editTitle + "\" href=\"" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("ViewPageEditLink") + "</a>";
                item.Visible = EditUrl != "" && Security.CanEdit && ShowOptionLink("edit");
            string body = "";
            option = options["detail"];
            string detailTableLink = "";
            string detailViewTblVar = "";
            string detailCopyTblVar = "";
            string detailEditTblVar = "";
            dynamic? detailPage = null;
            string detailFilter = "";

            // "detail_tblEvaluation"
            item = option.Add("detail_tblEvaluation");
            body = Language.Phrase("ViewPageDetailLink") + Language.TablePhrase("tblEvaluation", "TblCaption");
            body = "<a class=\"btn btn-default btn-sm ew-row-link ew-detail\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblEvaluationList?" + Config.TableShowMaster + "=tblAssessment&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.CurrentValue) + "")) + "\">" + body + "</a>";
            links = "";
            detailPage = Resolve("TblEvaluationGrid");
            if (detailPage?.DetailView && Security.CanView && Security.AllowView(CurrentProjectID + "tblAssessment") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + Language.Phrase("MasterDetailViewLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetViewUrl(Config.TableShowDetail + "=tblEvaluation"))) + "\">" + Language.Phrase("MasterDetailViewLink", null) + "</a></li>";
                if (!Empty(detailViewTblVar))
                    detailViewTblVar += ",";
                detailViewTblVar += "tblEvaluation";
            }
            if (detailPage?.DetailEdit && Security.CanEdit && Security.AllowEdit(CurrentProjectID + "tblAssessment") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + Language.Phrase("MasterDetailEditLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetEditUrl(Config.TableShowDetail + "=tblEvaluation"))) + "\">" + Language.Phrase("MasterDetailEditLink", null) + "</a></li>";
                if (!Empty(detailEditTblVar))
                    detailEditTblVar += ",";
                detailEditTblVar += "tblEvaluation";
            }
            if (!Empty(links)) {
                body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-detail\" data-bs-toggle=\"dropdown\"></button>";
                body += "<ul class=\"dropdown-menu\">" + links + "</ul>";
            } else {
                body = Regex.Replace(body, @"\b\s+dropdown-toggle\b", "");
            }
            body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
            item.Body = body;
            item.Visible = Security.AllowList(CurrentProjectID + "tblEvaluation");
            if (item.Visible) {
                if (!Empty(detailTableLink))
                    detailTableLink += ",";
                detailTableLink += "tblEvaluation";
            }
            if (ShowMultipleDetails)
                item.Visible = false;

            // "detail_tblEvaluationMB"
            item = option.Add("detail_tblEvaluationMB");
            body = Language.Phrase("ViewPageDetailLink") + Language.TablePhrase("tblEvaluationMB", "TblCaption");
            body = "<a class=\"btn btn-default btn-sm ew-row-link ew-detail\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblEvaluationMbList?" + Config.TableShowMaster + "=tblAssessment&" + ForeignKeyUrl("fk_AssessmentID", AssessmentID.CurrentValue) + "")) + "\">" + body + "</a>";
            links = "";
            detailPage = Resolve("TblEvaluationMbGrid");
            if (detailPage?.DetailView && Security.CanView && Security.AllowView(CurrentProjectID + "tblAssessment") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + Language.Phrase("MasterDetailViewLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetViewUrl(Config.TableShowDetail + "=tblEvaluationMB"))) + "\">" + Language.Phrase("MasterDetailViewLink", null) + "</a></li>";
                if (!Empty(detailViewTblVar))
                    detailViewTblVar += ",";
                detailViewTblVar += "tblEvaluationMB";
            }
            if (detailPage?.DetailEdit && Security.CanEdit && Security.AllowEdit(CurrentProjectID + "tblAssessment") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + Language.Phrase("MasterDetailEditLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetEditUrl(Config.TableShowDetail + "=tblEvaluationMB"))) + "\">" + Language.Phrase("MasterDetailEditLink", null) + "</a></li>";
                if (!Empty(detailEditTblVar))
                    detailEditTblVar += ",";
                detailEditTblVar += "tblEvaluationMB";
            }
            if (!Empty(links)) {
                body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-detail\" data-bs-toggle=\"dropdown\"></button>";
                body += "<ul class=\"dropdown-menu\">" + links + "</ul>";
            } else {
                body = Regex.Replace(body, @"\b\s+dropdown-toggle\b", "");
            }
            body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
            item.Body = body;
            item.Visible = Security.AllowList(CurrentProjectID + "tblEvaluationMB");
            if (item.Visible) {
                if (!Empty(detailTableLink))
                    detailTableLink += ",";
                detailTableLink += "tblEvaluationMB";
            }
            if (ShowMultipleDetails)
                item.Visible = false;

            // Multiple details
            if (ShowMultipleDetails) {
                body = "<div class=\"btn-group btn-group-sm ew-btn-group\">";
                links = "";
                if (!Empty(detailViewTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailViewLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetViewUrl(Config.TableShowDetail + "=" + detailViewTblVar))) + "\">" + Language.Phrase("MasterDetailViewLink", null) + "</a></li>";
                }
                if (!Empty(detailEditTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailEditLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetEditUrl(Config.TableShowDetail + "=" + detailEditTblVar))) + "\">" + Language.Phrase("MasterDetailEditLink", null) + "</a></li>";
                }
                if (!Empty(detailCopyTblVar)) {
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-copy\" data-action=\"add\" data-caption=\"" + HtmlEncode(Language.Phrase("MasterDetailCopyLink", true)) + "\" href=\"" + HtmlEncode(AppPath(GetCopyUrl(Config.TableShowDetail + "=" + detailCopyTblVar))) + "\">" + Language.Phrase("MasterDetailCopyLink", null) + "</a></li>";
                }
                if (!Empty(links)) {
                    body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default btn-sm ew-master-detail\" title=\"" + HtmlEncode(Language.Phrase("MultipleMasterDetails", true)) + "\" data-bs-toggle=\"dropdown\">" + Language.Phrase("MultipleMasterDetails") + "</button>";
                    body += "<ul class=\"dropdown-menu ew-dropdown-menu\">" + links + "</ul>";
                }
                body += "</div>";
                // Multiple details
                item = option.Add("details");
                item.Body = body;
            }

            // Set up detail default
            option = options["detail"];
            options["detail"].DropDownButtonPhrase = "ButtonDetails";
            var ar = detailTableLink.Split(',');
            option.UseDropDownButton = (ar.Length > 1);
            option.UseButtonGroup = true;
            item = option.AddGroupOption();
            item.Body = "";
            item.Visible = false;

            // Set up action default
            option = options["action"];
            option.DropDownButtonPhrase = "ButtonActions";
            option.UseDropDownButton = !IsJsonResponse() && false;
            option.UseButtonGroup = true;
            item = option.AddGroupOption();
            item.Body = "";
            item.Visible = false;
        }
        #pragma warning restore 168, 219

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

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            SetupOtherOptions();

            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // AssessmentID

            // str_Full_Name_Hdr

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Username

            // int_Student_ID

            // NationalID

            // Assessment_Type

            // AssessmentDate

            // AssessmentTime

            // isAssessmentDone

            // AssessmentScore

            // Assessment_Instructor

            // Date_Entered

            // IsDrivingexperience

            // intDrivinglicenseType

            // AbsherApptNbr

            // Absherphoto

            // date_Birth

            // date_Birth_Hijri

            // str_Cell_Phone

            // str_Email

            // UserlevelID

            // BackDateChk

            // DriveTypelink

            // Calendar_ID

            // Assessmnt_Time

            // Institution

            // TheoreticalScore

            // dt_TheoreticalScore

            // RoadTestScore

            // dt_RoadTestScore

            // AccidentOccurrence

            // Dt_AccidentOccurrence

            // AccidentNotes

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
                str_Full_Name_Hdr.TooltipValue = "";

                // Assessment_Type
                Assessment_Type.HrefValue = "";
                Assessment_Type.TooltipValue = "";

                // AssessmentDate
                AssessmentDate.HrefValue = "";
                AssessmentDate.TooltipValue = "";

                // AssessmentTime
                AssessmentTime.HrefValue = "";
                AssessmentTime.TooltipValue = "";

                // isAssessmentDone
                isAssessmentDone.HrefValue = "";
                isAssessmentDone.TooltipValue = "";

                // AssessmentScore
                AssessmentScore.HrefValue = "";
                AssessmentScore.TooltipValue = "";

                // Assessment_Instructor
                Assessment_Instructor.HrefValue = "";
                Assessment_Instructor.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";

                // intDrivinglicenseType
                if (!IsNull(intDrivinglicenseType.CurrentValue)) {
                    intDrivinglicenseType.HrefValue = ConvertToString(!Empty(intDrivinglicenseType.ViewValue) && !IsList(intDrivinglicenseType.ViewValue) ? RemoveHtml(ConvertToString(intDrivinglicenseType.ViewValue)) : ConvertToString(intDrivinglicenseType.CurrentValue)); // Add prefix/suffix
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

                // Institution
                Institution.HrefValue = "";
                Institution.TooltipValue = "";

                // TheoreticalScore
                TheoreticalScore.HrefValue = "";
                TheoreticalScore.TooltipValue = "";

                // dt_TheoreticalScore
                dt_TheoreticalScore.HrefValue = "";
                dt_TheoreticalScore.TooltipValue = "";

                // RoadTestScore
                RoadTestScore.HrefValue = "";
                RoadTestScore.TooltipValue = "";

                // dt_RoadTestScore
                dt_RoadTestScore.HrefValue = "";
                dt_RoadTestScore.TooltipValue = "";

                // AccidentOccurrence
                AccidentOccurrence.HrefValue = "";
                AccidentOccurrence.TooltipValue = "";

                // Dt_AccidentOccurrence
                Dt_AccidentOccurrence.HrefValue = "";
                Dt_AccidentOccurrence.TooltipValue = "";

                // AccidentNotes
                AccidentNotes.HrefValue = "";
                AccidentNotes.TooltipValue = "";
            }

            // Call Row Rendered event
            if (RowType != RowType.AggregateInit)
                RowRendered();
        }
        #pragma warning restore 1998

        // Get export HTML tag
        protected string GetExportTag(string type, bool custom = false) {
            string exportUrl = AppPath(CurrentPageName()); // DN
            if (type == "print" || custom) { // Printer friendly / custom export
                List<string> keys = GetKey(true).Split(Config.CompositeKeySeparator).ToList();
                foreach (string key in keys)
                    exportUrl += "/" + UrlEncode(key);
                exportUrl += "?export=" + type + (custom ? "&amp;custom=1" : "");
            } else {
                exportUrl = AppPath(Config.ApiUrl + Config.ApiExportAction + "/" + type + "/" + TableVar);
                exportUrl += "?" + Config.ApiKeyName + "=" + GetKey(true);
            }
            if (SameText(type, "excel")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblAssessmentview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblAssessmentview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblAssessmentview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\">" + Language.Phrase("ExportToPDF") + "</a>";
            } else if (SameText(type, "html")) {
                return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-html\" title=\"" + HtmlEncode(Language.Phrase("ExportToHtml", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToHtml", true)) + "\">" + Language.Phrase("ExportToHtml") + "</a>";
            } else if (SameText(type, "xml")) {
                return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-xml\" title=\"" + HtmlEncode(Language.Phrase("ExportToXml", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToXml", true)) + "\">" + Language.Phrase("ExportToXml") + "</a>";
            } else if (SameText(type, "csv")) {
                return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-csv\" title=\"" + HtmlEncode(Language.Phrase("ExportToCsv", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToCsv", true)) + "\">" + Language.Phrase("ExportToCsv") + "</a>";
            } else if (SameText(type, "email")) {
                string url = custom ? " data-url=\"" + exportUrl + "\"" : "";
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblAssessmentview\" data-ew-action=\"email\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-key='" + HtmlEncode(ConvertToJsonAttribute(RecordKeys)) + "' data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
            } else if (SameText(type, "print")) {
                return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-print\" title=\"" + HtmlEncode(Language.Phrase("PrinterFriendly", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("PrinterFriendly", true)) + "\">" + Language.Phrase("PrinterFriendly") + "</a>";
            }
            return "";
        }

        // Set up export options
        protected void SetupExportOptions() {
            ListOption item;

            // Printer friendly
            item = ExportOptions.Add("print");
            item.Body = GetExportTag("print");
            item.Visible = true;

            // Export to Excel
            item = ExportOptions.Add("excel");
            item.Body = GetExportTag("excel");
            item.Visible = true;

            // Export to Word
            item = ExportOptions.Add("word");
            item.Body = GetExportTag("word");
            item.Visible = false;

            // Export to HTML
            item = ExportOptions.Add("html");
            item.Body = GetExportTag("html");
            item.Visible = false;

            // Export to XML
            item = ExportOptions.Add("xml");
            item.Body = GetExportTag("xml");
            item.Visible = false;

            // Export to CSV
            item = ExportOptions.Add("csv");
            item.Body = GetExportTag("csv");
            item.Visible = false;

            // Export to PDF
            item = ExportOptions.Add("pdf");
            item.Body = GetExportTag("pdf");
            item.Visible = true;

            // Export to Email
            item = ExportOptions.Add("email");
            item.Body = GetExportTag("email");
            item.Visible = true;

            // Drop down button for export
            ExportOptions.UseButtonGroup = true;
            ExportOptions.UseDropDownButton = false;
            if (ExportOptions.UseButtonGroup && IsMobile())
                ExportOptions.UseDropDownButton = true;
            ExportOptions.DropDownButtonPhrase = "ButtonExport";

            // Add group option item
            item = ExportOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;

            // Hide options for export
            if (IsExport())
                ExportOptions.HideAllOptions();

            // Hide options if json response
            if (IsJsonResponse())
                ExportOptions.HideAllOptions();
            if (!Security.CanExport) // Export not allowed
                ExportOptions.HideAllOptions();
        }

        #pragma warning disable 168

        /// <summary>
        /// Export data
        /// </summary>
        public async Task ExportData(dynamic? doc, string[] keys)
        {
            // Load recordset // DN
            DbDataReader? dr = null;
            if (TotalRecords < 0)
                TotalRecords = await ListRecordCountAsync();
            StartRecord = 1;
            if (keys.Length >= 1) {
                AssessmentID.OldValue = keys[0];
                var c = await GetConnection2Async(DbId); // Note: Use new connection for view page export // DN
                dr = await LoadReader(GetRecordFilter(), "", c);
            }
            if (doc == null) { // DN
                RemoveHeader("Content-Type"); // Remove header
                RemoveHeader("Content-Disposition");
                FailureMessage = Language.Phrase("ExportClassNotFound"); // Export class not found
                return;
            }

            // Call Page Exporting server event
            doc.ExportCustom = !PageExporting(ref doc);
            string exportStyle;

            // Page header
            string header = PageHeader;
            PageDataRendering(ref header);
            doc.Text.Append(header);

            // Export
            if (dr != null)
                await ExportDocument(doc, dr, StartRecord, StopRecord, "view");

            // Export detail records (tblEvaluation)
            if (Config.ExportDetailRecords && CurrentDetailTables.Contains("tblEvaluation")) {
                tblEvaluation = new TblEvaluationList();
                if (tblEvaluation != null) {
                    var c = await GetConnection2Async(tblEvaluation.DbId); // Note: Use new connection for detail records // DN
                    using var rsdetail = await tblEvaluation.LoadReader(tblEvaluation.DetailFilterFromSession, tblEvaluation.SessionOrderBy, c); // Load detail records
                    if (rsdetail?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("h"); // Change to horizontal
                        if (Export != "csv" || Config.ExportDetailRecordsForCsv) {
                            doc.ExportEmptyRow();
                            int detailcnt = await tblEvaluation.LoadRecordCountAsync(tblEvaluation.DetailFilterFromSession); // DN
                            var oldtbl = doc.Table;
                            doc.Table = tblEvaluation;
                            await tblEvaluation.ExportDocument(doc, rsdetail, 1, detailcnt);
                            doc.Table = oldtbl;
                        }
                        doc.SetStyle(exportStyle); // Restore
                    }
                }
            }

            // Export detail records (tblEvaluationMB)
            if (Config.ExportDetailRecords && CurrentDetailTables.Contains("tblEvaluationMB")) {
                tblEvaluationMb = new TblEvaluationMbList();
                if (tblEvaluationMb != null) {
                    var c = await GetConnection2Async(tblEvaluationMb.DbId); // Note: Use new connection for detail records // DN
                    using var rsdetail = await tblEvaluationMb.LoadReader(tblEvaluationMb.DetailFilterFromSession, tblEvaluationMb.SessionOrderBy, c); // Load detail records
                    if (rsdetail?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("h"); // Change to horizontal
                        if (Export != "csv" || Config.ExportDetailRecordsForCsv) {
                            doc.ExportEmptyRow();
                            int detailcnt = await tblEvaluationMb.LoadRecordCountAsync(tblEvaluationMb.DetailFilterFromSession); // DN
                            var oldtbl = doc.Table;
                            doc.Table = tblEvaluationMb;
                            await tblEvaluationMb.ExportDocument(doc, rsdetail, 1, detailcnt);
                            doc.Table = oldtbl;
                        }
                        doc.SetStyle(exportStyle); // Restore
                    }
                }
            }

            // Page footer
            string footer = PageFooter;
            PageDataRendered(ref footer);
            doc.Text.Append(footer);

            // Close recordset
            using (dr) {} // Dispose

            // Export header and footer
            await doc.ExportHeaderAndFooter();

            // Call Page Exported server event
            PageExported(doc);
        }
        #pragma warning restore 168

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

                // Reset start record counter (new master key)
                if (!IsAddOrEdit) {
                    StartRecord = 1;
                    StartRecordNumber = StartRecord;
                }

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
                    if (tblEvaluationGrid?.DetailView ?? false) {
                        tblEvaluationGrid.CurrentMode = "view";

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
                    if (tblEvaluationMbGrid?.DetailView ?? false) {
                        tblEvaluationMbGrid.CurrentMode = "view";

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
            string pageId = "view";
            breadcrumb.Add("view", pageId, url);
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

        // Page Exporting event
        // doc = export document object
        public virtual bool PageExporting(ref dynamic doc) {
            //doc.Text.Append("<p>" + "my header" + "</p>"); // Export header
            //return false; // Return false to skip default export and use Row_Export event
            return true; // Return true to use default export and skip Row_Export event
        }

        // Page Exported event
        // doc = export document object
        public virtual void PageExported(dynamic doc) {
            //doc.Text.Append("my footer"); // Export footer
            //Log("Text: {Text}", doc.Text.ToString());
        }
    } // End page class
} // End Partial class
