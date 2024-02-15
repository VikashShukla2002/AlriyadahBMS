namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStudentsView
    /// </summary>
    public static TblStudentsView tblStudentsView
    {
        get => HttpData.Get<TblStudentsView>("tblStudentsView")!;
        set => HttpData["tblStudentsView"] = value;
    }

    /// <summary>
    /// Page class for tblStudents
    /// </summary>
    public class TblStudentsView : TblStudentsViewBase
    {
        // Constructor
        public TblStudentsView(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblStudentsView() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblStudentsViewBase : TblStudents
    {
        // Page ID
        public string PageID = "view";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblStudents";

        // Page object name
        public string PageObjName = "tblStudentsView";

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
        public TblStudentsViewBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-view-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblStudents)
            if (tblStudents == null || tblStudents is TblStudents)
                tblStudents = this;

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
                    RecordKeys["int_Student_ID"] = keys[0];
            } else {
                RecordKeys["int_Student_ID"] = RouteValues.TryGetValue("int_Student_ID", out obj) && obj != null ? UrlDecode(obj) : Get("int_Student_ID"); // DN
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
        public string PageName => "TblStudentsView";

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
            int_Student_ID.SetVisibility();
            str_First_Name.SetVisibility();
            str_Middle_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Full_Name.SetVisibility();
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
        public TblStudentsViewBase(Controller? controller = null): this() { // DN
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

            // Load current record
            bool loadCurrentRecord = false;
            string returnUrl = "";
            bool matchRecord = false;
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
            if (RouteValues.TryGetValue("int_Student_ID", out v) && !Empty(v)) { // DN
                int_Student_ID.QueryValue = UrlDecode(v); // DN
                RecordKeys["int_Student_ID"] = int_Student_ID.QueryValue;
            } else if (Get("int_Student_ID", out sv)) {
                int_Student_ID.QueryValue = sv.ToString();
                RecordKeys["int_Student_ID"] = int_Student_ID.QueryValue;
            } else if (IsApi() && !Empty(keyValues)) {
                int_Student_ID.QueryValue = ConvertToString(keyValues[0]);
                RecordKeys["int_Student_ID"] = int_Student_ID.QueryValue;
            } else if (!loadCurrentRecord) {
                returnUrl = "TblStudentsList"; // Return to list
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
                                return Terminate("TblStudentsList"); // Return to list page
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
                tblStudentsView?.PageRender();
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

            // "detail_tblAssessment"
            item = option.Add("detail_tblAssessment");
            body = Language.Phrase("ViewPageDetailLink") + Language.TablePhrase("tblAssessment", "TblCaption");
            body = "<a class=\"btn btn-default btn-sm ew-row-link ew-detail\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblAssessmentList?" + Config.TableShowMaster + "=tblStudents&" + ForeignKeyUrl("fk_str_Username", str_Username.CurrentValue) + "")) + "\">" + body + "</a>";
            links = "";
            detailPage = Resolve("TblAssessmentGrid");
            if (detailPage?.DetailView && Security.CanView && Security.AllowView(CurrentProjectID + "tblStudents") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + Language.Phrase("MasterDetailViewLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetViewUrl(Config.TableShowDetail + "=tblAssessment"))) + "\">" + Language.Phrase("MasterDetailViewLink", null) + "</a></li>";
                if (!Empty(detailViewTblVar))
                    detailViewTblVar += ",";
                detailViewTblVar += "tblAssessment";
            }
            if (detailPage?.DetailEdit && Security.CanEdit && Security.AllowEdit(CurrentProjectID + "tblStudents") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + Language.Phrase("MasterDetailEditLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetEditUrl(Config.TableShowDetail + "=tblAssessment"))) + "\">" + Language.Phrase("MasterDetailEditLink", null) + "</a></li>";
                if (!Empty(detailEditTblVar))
                    detailEditTblVar += ",";
                detailEditTblVar += "tblAssessment";
            }
            if (!Empty(links)) {
                body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-detail\" data-bs-toggle=\"dropdown\"></button>";
                body += "<ul class=\"dropdown-menu\">" + links + "</ul>";
            } else {
                body = Regex.Replace(body, @"\b\s+dropdown-toggle\b", "");
            }
            body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
            item.Body = body;
            item.Visible = Security.AllowList(CurrentProjectID + "tblAssessment");
            if (item.Visible) {
                if (!Empty(detailTableLink))
                    detailTableLink += ",";
                detailTableLink += "tblAssessment";
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
            SetupOtherOptions();

            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_Student_ID

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Full_Name

            // str_Address

            // str_City

            // int_State

            // str_Zip

            // date_Hired

            // date_Left

            // str_CertNumber

            // date_CertExp

            // str_Cell_Phone

            // str_Home_Phone

            // str_Other_Phone

            // str_Email

            // str_Code

            // str_Username

            // str_Password

            // date_Birth_Hijri

            // date_Birth

            // Hijri_Year

            // Hijri_Month

            // Hijri_Day

            // date_Started

            // str_DateHired

            // str_DateLeft

            // str_Emergency_Contact_Name

            // str_Emergency_Contact_Phone

            // str_Emergency_Contact_Relation

            // str_Notes

            // int_ClassType

            // str_ZipCodes

            // int_VehicleAssigned

            // int_Status

            // int_Type

            // int_Location

            // date_Created

            // date_Modified

            // int_Created_By

            // int_Modified_By

            // bit_IsDeleted

            // str_InstPermitNo

            // date_PermitExpiration

            // date_InCarPermitIssue

            // str_InClassPermitNo

            // date_InClassPermitIssue

            // instructor_caption

            // str_LicType

            // int_Order

            // str_InstLicenceDate

            // str_DLNum

            // str_DLExp

            // bit_appointmentColor

            // str_appointmentColorCode

            // bit_IsSuperAdmin

            // IsDistanceBasedScheduling

            // str_Package_Code

            // str_NationalID_Iqama

            // NationalID

            // int_RoadDistanceCoverage

            // str_Badge

            // strZoomHostUrl

            // strZoomUserUrl

            // Signature

            // str_VehicleType

            // ProfilePicturePath

            // Institution

            // IsDrivingexperience

            // intDrivinglicenseType

            // AbsherApptNbr

            // Absherphoto

            // Fingerprint

            // ProfileField

            // UserlevelID

            // Parent_Username

            // Activated

            // int_Nationality

            // User_Role

            // int_Staff_Id

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

                // str_Full_Name
                str_Full_Name.HrefValue = "";
                str_Full_Name.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // str_Email
                str_Email.HrefValue = "";
                str_Email.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";
                date_Birth_Hijri.TooltipValue = "";

                // date_Birth
                date_Birth.HrefValue = "";
                date_Birth.TooltipValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";
                str_NationalID_Iqama.TooltipValue = "";

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

                // Parent_Username
                Parent_Username.HrefValue = "";
                Parent_Username.TooltipValue = "";

                // int_Nationality
                int_Nationality.HrefValue = "";
                int_Nationality.TooltipValue = "";

                // User_Role
                User_Role.HrefValue = "";
                User_Role.TooltipValue = "";

                // int_Staff_Id
                int_Staff_Id.HrefValue = "";
                int_Staff_Id.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblStudentsview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblStudentsview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblStudentsview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblStudentsview\" data-ew-action=\"email\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-key='" + HtmlEncode(ConvertToJsonAttribute(RecordKeys)) + "' data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
                int_Student_ID.OldValue = keys[0];
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

            // Export detail records (tblAssessment)
            if (Config.ExportDetailRecords && CurrentDetailTables.Contains("tblAssessment")) {
                tblAssessment = new TblAssessmentList();
                if (tblAssessment != null) {
                    var c = await GetConnection2Async(tblAssessment.DbId); // Note: Use new connection for detail records // DN
                    using var rsdetail = await tblAssessment.LoadReader(tblAssessment.DetailFilterFromSession, tblAssessment.SessionOrderBy, c); // Load detail records
                    if (rsdetail?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("h"); // Change to horizontal
                        if (Export != "csv" || Config.ExportDetailRecordsForCsv) {
                            doc.ExportEmptyRow();
                            int detailcnt = await tblAssessment.LoadRecordCountAsync(tblAssessment.DetailFilterFromSession); // DN
                            var oldtbl = doc.Table;
                            doc.Table = tblAssessment;
                            await tblAssessment.ExportDocument(doc, rsdetail, 1, detailcnt);
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
                if (detailTblVars.Contains("tblAssessment")) {
                    tblAssessmentGrid = Resolve("TblAssessmentGrid")!;
                    if (tblAssessmentGrid?.DetailView ?? false) {
                        tblAssessmentGrid.CurrentMode = "view";

                        // Save current master table to detail table
                        tblAssessmentGrid.CurrentMasterTable = TableVar;
                        tblAssessmentGrid.StartRecordNumber = 1;
                        tblAssessmentGrid.str_Username.IsDetailKey = true;
                        tblAssessmentGrid.str_Username.CurrentValue = str_Username.CurrentValue;
                        tblAssessmentGrid.str_Username.SessionValue = tblAssessmentGrid.str_Username.CurrentValue;
                    }
                }
            }
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblStudentsList")), "", TableVar, true);
            string pageId = "view";
            breadcrumb.Add("view", pageId, url);
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
