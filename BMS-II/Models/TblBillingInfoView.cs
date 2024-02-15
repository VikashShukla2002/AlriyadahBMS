namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblBillingInfoView
    /// </summary>
    public static TblBillingInfoView tblBillingInfoView
    {
        get => HttpData.Get<TblBillingInfoView>("tblBillingInfoView")!;
        set => HttpData["tblBillingInfoView"] = value;
    }

    /// <summary>
    /// Page class for tblBillingInfo
    /// </summary>
    public class TblBillingInfoView : TblBillingInfoViewBase
    {
        // Constructor
        public TblBillingInfoView(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblBillingInfoView() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblBillingInfoViewBase : TblBillingInfo
    {
        // Page ID
        public string PageID = "view";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblBillingInfo";

        // Page object name
        public string PageObjName = "tblBillingInfoView";

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
        public TblBillingInfoViewBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-view-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblBillingInfo)
            if (tblBillingInfo == null || tblBillingInfo is TblBillingInfo)
                tblBillingInfo = this;

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
                    RecordKeys["int_Bill_ID"] = keys[0];
            } else {
                RecordKeys["int_Bill_ID"] = RouteValues.TryGetValue("int_Bill_ID", out obj) && obj != null ? UrlDecode(obj) : Get("int_Bill_ID"); // DN
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
        public string PageName => "TblBillingInfoView";

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
            int_Bill_ID.SetVisibility();
            NationalID.SetVisibility();
            str_First_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Username.SetVisibility();
            int_Student_ID.SetVisibility();
            int_Payment_Method.SetVisibility();
            date_Paid.SetVisibility();
            str_ApprovalCode.SetVisibility();
            Payment_Number.SetVisibility();
            Pricelist.SetVisibility();
            date_Created.SetVisibility();
            str_Amount.SetVisibility();
            str_CC_Holder_Name.SetVisibility();
            str_CC_Number.SetVisibility();
            int_CC_ExpMonth.SetVisibility();
            int_CC_ExpYear.SetVisibility();
            int_CC_Type.SetVisibility();
            str_Card_Id.SetVisibility();
            str_CC_ValidationNum.SetVisibility();
            str_reference.SetVisibility();
            str_Amount_Pay.SetVisibility();
            mny_Running_Payments.SetVisibility();
            mny_Running_Balance.SetVisibility();
            str_Payment_Reference.SetVisibility();
            int_Accepted_By.SetVisibility();
            str_Check_Number.SetVisibility();
            bit_Is_Check_Deposited.SetVisibility();
            str_Adjustment_Type.SetVisibility();
            str_Adjust_Sub_Type.SetVisibility();
            bit_Archive.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            date_Modified.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_CardHolder_Address.SetVisibility();
            str_CH_City.SetVisibility();
            str_CH_Zip.SetVisibility();
            int_State.SetVisibility();
            bit_IsAuthDotNet.SetVisibility();
            bit_IsRefund.SetVisibility();
            str_Receipt.SetVisibility();
            str_TransactionNumber.SetVisibility();
            str_OrderId.SetVisibility();
            str_TransactionTime.SetVisibility();
            int_Location_Id.SetVisibility();
            str_Enrollment_Id.SetVisibility();
            str_Notes.SetVisibility();
            str_Payment_Note.SetVisibility();
            int_Package_ID.SetVisibility();
            Package_Name.SetVisibility();
            Price.SetVisibility();
            AssessmentID.SetVisibility();
            course.SetVisibility();
            institution.SetVisibility();
            UniqueIdx.SetVisibility();
        }

        // Constructor
        public TblBillingInfoViewBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblBillingInfoView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Bill_ID") ? dict["int_Bill_ID"] : int_Bill_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Bill_ID.Visible = false;
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
            await SetupLookupOptions(NationalID);
            await SetupLookupOptions(str_Username);
            await SetupLookupOptions(int_Student_ID);
            await SetupLookupOptions(int_Payment_Method);
            await SetupLookupOptions(bit_Is_Check_Deposited);
            await SetupLookupOptions(bit_Archive);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(bit_IsAuthDotNet);
            await SetupLookupOptions(bit_IsRefund);
            await SetupLookupOptions(int_Package_ID);
            await SetupLookupOptions(Package_Name);
            await SetupLookupOptions(Price);

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
            if (RouteValues.TryGetValue("int_Bill_ID", out v) && !Empty(v)) { // DN
                int_Bill_ID.QueryValue = UrlDecode(v); // DN
                RecordKeys["int_Bill_ID"] = int_Bill_ID.QueryValue;
            } else if (Get("int_Bill_ID", out sv)) {
                int_Bill_ID.QueryValue = sv.ToString();
                RecordKeys["int_Bill_ID"] = int_Bill_ID.QueryValue;
            } else if (IsApi() && !Empty(keyValues)) {
                int_Bill_ID.QueryValue = ConvertToString(keyValues[0]);
                RecordKeys["int_Bill_ID"] = int_Bill_ID.QueryValue;
            } else if (!loadCurrentRecord) {
                returnUrl = "TblBillingInfoList"; // Return to list
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
                                return Terminate("TblBillingInfoList"); // Return to list page
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
                tblBillingInfoView?.PageRender();
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

            // Add
            item = option.Add("add");
            string addTitle = Language.Phrase("ViewPageAddLink", true);
            if (IsModal) // Modal
                item.Body = "<a class=\"ew-action ew-add\" title=\"" + addTitle + "\" data-caption=\"" + addTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(AppPath(AddUrl)) + "\">" + Language.Phrase("ViewPageAddLink") + "</a>";
            else
                item.Body = "<a class=\"ew-action ew-add\" title=\"" + addTitle + "\" data-caption=\"" + addTitle + "\" href=\"" + HtmlEncode(AppPath(AddUrl)) + "\">" + Language.Phrase("ViewPageAddLink") + "</a>";
                item.Visible = AddUrl != "" && Security.CanAdd;

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

            // "detail_tblStudentEnrollment"
            item = option.Add("detail_tblStudentEnrollment");
            body = Language.Phrase("ViewPageDetailLink") + Language.TablePhrase("tblStudentEnrollment", "TblCaption");
            body = "<a class=\"btn btn-default btn-sm ew-row-link ew-detail\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblStudentEnrollmentList?" + Config.TableShowMaster + "=tblBillingInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "")) + "\">" + body + "</a>";
            links = "";
            detailPage = Resolve("TblStudentEnrollmentGrid");
            if (detailPage?.DetailView && Security.CanView && Security.AllowView(CurrentProjectID + "tblBillingInfo") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + Language.Phrase("MasterDetailViewLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetViewUrl(Config.TableShowDetail + "=tblStudentEnrollment"))) + "\">" + Language.Phrase("MasterDetailViewLink", null) + "</a></li>";
                if (!Empty(detailViewTblVar))
                    detailViewTblVar += ",";
                detailViewTblVar += "tblStudentEnrollment";
            }
            if (detailPage?.DetailEdit && Security.CanEdit && Security.AllowEdit(CurrentProjectID + "tblBillingInfo") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + Language.Phrase("MasterDetailEditLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetEditUrl(Config.TableShowDetail + "=tblStudentEnrollment"))) + "\">" + Language.Phrase("MasterDetailEditLink", null) + "</a></li>";
                if (!Empty(detailEditTblVar))
                    detailEditTblVar += ",";
                detailEditTblVar += "tblStudentEnrollment";
            }
            if (!Empty(links)) {
                body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-detail\" data-bs-toggle=\"dropdown\"></button>";
                body += "<ul class=\"dropdown-menu\">" + links + "</ul>";
            } else {
                body = Regex.Replace(body, @"\b\s+dropdown-toggle\b", "");
            }
            body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
            item.Body = body;
            item.Visible = Security.AllowList(CurrentProjectID + "tblStudentEnrollment");
            if (item.Visible) {
                if (!Empty(detailTableLink))
                    detailTableLink += ",";
                detailTableLink += "tblStudentEnrollment";
            }
            if (ShowMultipleDetails)
                item.Visible = false;

            // "detail_qryBillingDetails_v2"
            item = option.Add("detail_qryBillingDetails_v2");
            body = Language.Phrase("ViewPageDetailLink") + Language.TablePhrase("qryBillingDetails_v2", "TblCaption");
            body = "<a class=\"btn btn-default btn-sm ew-row-link ew-detail\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("QryBillingDetailsV2List?" + Config.TableShowMaster + "=tblBillingInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "")) + "\">" + body + "</a>";
            links = "";
            detailPage = Resolve("QryBillingDetailsV2Grid");
            if (detailPage?.DetailView && Security.CanView && Security.AllowView(CurrentProjectID + "tblBillingInfo") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + Language.Phrase("MasterDetailViewLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetViewUrl(Config.TableShowDetail + "=qryBillingDetails_v2"))) + "\">" + Language.Phrase("MasterDetailViewLink", null) + "</a></li>";
                if (!Empty(detailViewTblVar))
                    detailViewTblVar += ",";
                detailViewTblVar += "qryBillingDetails_v2";
            }
            if (detailPage?.DetailEdit && Security.CanEdit && Security.AllowEdit(CurrentProjectID + "tblBillingInfo") ?? false) {
                links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + Language.Phrase("MasterDetailEditLink", true) + "\" href=\"" + HtmlEncode(AppPath(GetEditUrl(Config.TableShowDetail + "=qryBillingDetails_v2"))) + "\">" + Language.Phrase("MasterDetailEditLink", null) + "</a></li>";
                if (!Empty(detailEditTblVar))
                    detailEditTblVar += ",";
                detailEditTblVar += "qryBillingDetails_v2";
            }
            if (!Empty(links)) {
                body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-detail\" data-bs-toggle=\"dropdown\"></button>";
                body += "<ul class=\"dropdown-menu\">" + links + "</ul>";
            } else {
                body = Regex.Replace(body, @"\b\s+dropdown-toggle\b", "");
            }
            body = "<div class=\"btn-group btn-group-sm ew-btn-group\">" + body + "</div>";
            item.Body = body;
            item.Visible = Security.AllowList(CurrentProjectID + "qryBillingDetails_v2");
            if (item.Visible) {
                if (!Empty(detailTableLink))
                    detailTableLink += ",";
                detailTableLink += "qryBillingDetails_v2";
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
            int_Bill_ID.SetDbValue(row["int_Bill_ID"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_First_Name.SetDbValue(row["str_First_Name"]);
            str_Last_Name.SetDbValue(row["str_Last_Name"]);
            str_Username.SetDbValue(row["str_Username"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            int_Payment_Method.SetDbValue(row["int_Payment_Method"]);
            date_Paid.SetDbValue(row["date_Paid"]);
            str_ApprovalCode.SetDbValue(row["str_ApprovalCode"]);
            Payment_Number.SetDbValue(row["Payment_Number"]);
            Pricelist.SetDbValue(row["Pricelist"]);
            date_Created.SetDbValue(row["date_Created"]);
            str_Amount.SetDbValue(row["str_Amount"]);
            str_CC_Holder_Name.SetDbValue(row["str_CC_Holder_Name"]);
            str_CC_Number.SetDbValue(row["str_CC_Number"]);
            int_CC_ExpMonth.SetDbValue(row["int_CC_ExpMonth"]);
            int_CC_ExpYear.SetDbValue(row["int_CC_ExpYear"]);
            int_CC_Type.SetDbValue(row["int_CC_Type"]);
            str_Card_Id.SetDbValue(row["str_Card_Id"]);
            str_CC_ValidationNum.SetDbValue(row["str_CC_ValidationNum"]);
            str_reference.SetDbValue(row["str_reference"]);
            str_Amount_Pay.SetDbValue(row["str_Amount_Pay"]);
            mny_Running_Payments.SetDbValue(row["mny_Running_Payments"]);
            mny_Running_Balance.SetDbValue(row["mny_Running_Balance"]);
            str_Payment_Reference.SetDbValue(row["str_Payment_Reference"]);
            int_Accepted_By.SetDbValue(row["int_Accepted_By"]);
            str_Check_Number.SetDbValue(row["str_Check_Number"]);
            bit_Is_Check_Deposited.SetDbValue((ConvertToBool(row["bit_Is_Check_Deposited"]) ? "1" : "0"));
            str_Adjustment_Type.SetDbValue(row["str_Adjustment_Type"]);
            str_Adjust_Sub_Type.SetDbValue(row["str_Adjust_Sub_Type"]);
            bit_Archive.SetDbValue((ConvertToBool(row["bit_Archive"]) ? "1" : "0"));
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_CardHolder_Address.SetDbValue(row["str_CardHolder_Address"]);
            str_CH_City.SetDbValue(row["str_CH_City"]);
            str_CH_Zip.SetDbValue(row["str_CH_Zip"]);
            int_State.SetDbValue(row["int_State"]);
            bit_IsAuthDotNet.SetDbValue((ConvertToBool(row["bit_IsAuthDotNet"]) ? "1" : "0"));
            bit_IsRefund.SetDbValue((ConvertToBool(row["bit_IsRefund"]) ? "1" : "0"));
            str_Receipt.SetDbValue(row["str_Receipt"]);
            str_TransactionNumber.SetDbValue(row["str_TransactionNumber"]);
            str_OrderId.SetDbValue(row["str_OrderId"]);
            str_TransactionTime.SetDbValue(row["str_TransactionTime"]);
            int_Location_Id.SetDbValue(row["int_Location_Id"]);
            str_Enrollment_Id.SetDbValue(row["str_Enrollment_Id"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            str_Payment_Note.SetDbValue(row["str_Payment_Note"]);
            int_Package_ID.SetDbValue(row["int_Package_ID"]);
            Package_Name.SetDbValue(row["Package_Name"]);
            Price.SetDbValue(row["Price"]);
            AssessmentID.SetDbValue(row["AssessmentID"]);
            course.SetDbValue(row["course"]);
            institution.SetDbValue(row["institution"]);
            UniqueIdx.SetDbValue(row["UniqueIdx"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Bill_ID", int_Bill_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_First_Name", str_First_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last_Name", str_Last_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Payment_Method", int_Payment_Method.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Paid", date_Paid.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ApprovalCode", str_ApprovalCode.DefaultValue ?? DbNullValue); // DN
            row.Add("Payment_Number", Payment_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("Pricelist", Pricelist.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Amount", str_Amount.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_Holder_Name", str_CC_Holder_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_Number", str_CC_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_ExpMonth", int_CC_ExpMonth.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_ExpYear", int_CC_ExpYear.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CC_Type", int_CC_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Card_Id", str_Card_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CC_ValidationNum", str_CC_ValidationNum.DefaultValue ?? DbNullValue); // DN
            row.Add("str_reference", str_reference.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Amount_Pay", str_Amount_Pay.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Running_Payments", mny_Running_Payments.DefaultValue ?? DbNullValue); // DN
            row.Add("mny_Running_Balance", mny_Running_Balance.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Payment_Reference", str_Payment_Reference.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Accepted_By", int_Accepted_By.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Check_Number", str_Check_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Is_Check_Deposited", bit_Is_Check_Deposited.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Adjustment_Type", str_Adjustment_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Adjust_Sub_Type", str_Adjust_Sub_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Archive", bit_Archive.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardHolder_Address", str_CardHolder_Address.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CH_City", str_CH_City.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CH_Zip", str_CH_Zip.DefaultValue ?? DbNullValue); // DN
            row.Add("int_State", int_State.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsAuthDotNet", bit_IsAuthDotNet.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsRefund", bit_IsRefund.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Receipt", str_Receipt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_TransactionNumber", str_TransactionNumber.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OrderId", str_OrderId.DefaultValue ?? DbNullValue); // DN
            row.Add("str_TransactionTime", str_TransactionTime.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_Id", int_Location_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Enrollment_Id", str_Enrollment_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Payment_Note", str_Payment_Note.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Package_ID", int_Package_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("Package_Name", Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("Price", Price.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentID", AssessmentID.DefaultValue ?? DbNullValue); // DN
            row.Add("course", course.DefaultValue ?? DbNullValue); // DN
            row.Add("institution", institution.DefaultValue ?? DbNullValue); // DN
            row.Add("UniqueIdx", UniqueIdx.DefaultValue ?? DbNullValue); // DN
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

            // int_Bill_ID

            // NationalID

            // str_First_Name

            // str_Last_Name

            // str_Username

            // int_Student_ID

            // int_Payment_Method

            // date_Paid

            // str_ApprovalCode

            // Payment_Number

            // Pricelist

            // date_Created

            // str_Amount

            // str_CC_Holder_Name

            // str_CC_Number

            // int_CC_ExpMonth

            // int_CC_ExpYear

            // int_CC_Type

            // str_Card_Id

            // str_CC_ValidationNum

            // str_reference

            // str_Amount_Pay

            // mny_Running_Payments

            // mny_Running_Balance

            // str_Payment_Reference

            // int_Accepted_By

            // str_Check_Number

            // bit_Is_Check_Deposited

            // str_Adjustment_Type

            // str_Adjust_Sub_Type

            // bit_Archive

            // int_Created_By

            // int_Modified_By

            // date_Modified

            // bit_IsDeleted

            // str_CardHolder_Address

            // str_CH_City

            // str_CH_Zip

            // int_State

            // bit_IsAuthDotNet

            // bit_IsRefund

            // str_Receipt

            // str_TransactionNumber

            // str_OrderId

            // str_TransactionTime

            // int_Location_Id

            // str_Enrollment_Id

            // str_Notes

            // str_Payment_Note

            // int_Package_ID

            // Package_Name

            // Price

            // AssessmentID

            // course

            // institution

            // UniqueIdx

            // View row
            if (RowType == RowType.View) {
                // int_Bill_ID
                int_Bill_ID.ViewValue = int_Bill_ID.CurrentValue;
                int_Bill_ID.ViewCustomAttributes = "";

                // NationalID
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

                // str_First_Name
                str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // str_Username
                curVal = ConvertToString(str_Username.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Username.Lookup != null && IsDictionary(str_Username.Lookup?.Options) && str_Username.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Username.ViewValue = str_Username.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Username]", "=", str_Username.CurrentValue, DataType.String, "");
                        sqlWrk = str_Username.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Username.Lookup != null) { // Lookup values found
                            var listwrk = str_Username.Lookup?.RenderViewRow(rswrk[0]);
                            str_Username.ViewValue = str_Username.HighlightLookup(ConvertToString(rswrk[0]), str_Username.DisplayValue(listwrk));
                        } else {
                            str_Username.ViewValue = str_Username.CurrentValue;
                        }
                    }
                } else {
                    str_Username.ViewValue = DbNullValue;
                }
                str_Username.ViewCustomAttributes = "";

                // int_Student_ID
                curVal = ConvertToString(int_Student_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Student_ID.Lookup != null && IsDictionary(int_Student_ID.Lookup?.Options) && int_Student_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Student_ID.ViewValue = int_Student_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Student_ID]", "=", int_Student_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Student_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Student_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Student_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Student_ID.ViewValue = int_Student_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Student_ID.DisplayValue(listwrk));
                        } else {
                            int_Student_ID.ViewValue = FormatNumber(int_Student_ID.CurrentValue, int_Student_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Student_ID.ViewValue = DbNullValue;
                }
                int_Student_ID.ViewCustomAttributes = "";

                // int_Payment_Method
                if (!Empty(int_Payment_Method.CurrentValue)) {
                    int_Payment_Method.ViewValue = int_Payment_Method.HighlightLookup(ConvertToString(int_Payment_Method.CurrentValue), int_Payment_Method.OptionCaption(ConvertToString(int_Payment_Method.CurrentValue)));
                } else {
                    int_Payment_Method.ViewValue = DbNullValue;
                }
                int_Payment_Method.ViewCustomAttributes = "";

                // date_Paid
                date_Paid.ViewValue = date_Paid.CurrentValue;
                date_Paid.ViewValue = FormatDateTime(date_Paid.ViewValue, date_Paid.FormatPattern);
                date_Paid.ViewCustomAttributes = "";

                // str_ApprovalCode
                str_ApprovalCode.ViewValue = ConvertToString(str_ApprovalCode.CurrentValue); // DN
                str_ApprovalCode.ViewCustomAttributes = "";

                // Payment_Number
                Payment_Number.ViewValue = Payment_Number.CurrentValue;
                Payment_Number.ViewValue = FormatNumber(Payment_Number.ViewValue, Payment_Number.FormatPattern);
                Payment_Number.CellCssStyle += "text-align: center;";
                Payment_Number.ViewCustomAttributes = "";

                // Pricelist
                Pricelist.ViewValue = Pricelist.CurrentValue;
                Pricelist.ViewValue = FormatNumber(Pricelist.ViewValue, Pricelist.FormatPattern);
                Pricelist.CellCssStyle += "text-align: right;";
                Pricelist.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // str_Amount
                str_Amount.ViewValue = ConvertToString(str_Amount.CurrentValue); // DN
                str_Amount.ViewCustomAttributes = "";

                // str_CC_Holder_Name
                str_CC_Holder_Name.ViewValue = ConvertToString(str_CC_Holder_Name.CurrentValue); // DN
                str_CC_Holder_Name.ViewCustomAttributes = "";

                // str_CC_Number
                str_CC_Number.ViewValue = ConvertToString(str_CC_Number.CurrentValue); // DN
                str_CC_Number.ViewCustomAttributes = "";

                // int_CC_ExpMonth
                int_CC_ExpMonth.ViewValue = int_CC_ExpMonth.CurrentValue;
                int_CC_ExpMonth.ViewValue = FormatNumber(int_CC_ExpMonth.ViewValue, int_CC_ExpMonth.FormatPattern);
                int_CC_ExpMonth.ViewCustomAttributes = "";

                // int_CC_ExpYear
                int_CC_ExpYear.ViewValue = int_CC_ExpYear.CurrentValue;
                int_CC_ExpYear.ViewValue = FormatNumber(int_CC_ExpYear.ViewValue, int_CC_ExpYear.FormatPattern);
                int_CC_ExpYear.ViewCustomAttributes = "";

                // int_CC_Type
                int_CC_Type.ViewValue = int_CC_Type.CurrentValue;
                int_CC_Type.ViewValue = FormatNumber(int_CC_Type.ViewValue, int_CC_Type.FormatPattern);
                int_CC_Type.ViewCustomAttributes = "";

                // str_Card_Id
                str_Card_Id.ViewValue = ConvertToString(str_Card_Id.CurrentValue); // DN
                str_Card_Id.ViewCustomAttributes = "";

                // str_CC_ValidationNum
                str_CC_ValidationNum.ViewValue = ConvertToString(str_CC_ValidationNum.CurrentValue); // DN
                str_CC_ValidationNum.ViewCustomAttributes = "";

                // str_reference
                str_reference.ViewValue = ConvertToString(str_reference.CurrentValue); // DN
                str_reference.ViewCustomAttributes = "";

                // str_Amount_Pay
                str_Amount_Pay.ViewValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
                str_Amount_Pay.CellCssStyle += "text-align: right;";
                str_Amount_Pay.ViewCustomAttributes = "";

                // mny_Running_Payments
                mny_Running_Payments.ViewValue = mny_Running_Payments.CurrentValue;
                mny_Running_Payments.ViewValue = FormatNumber(mny_Running_Payments.ViewValue, mny_Running_Payments.FormatPattern);
                mny_Running_Payments.CellCssStyle += "text-align: right;";
                mny_Running_Payments.ViewCustomAttributes = "";

                // mny_Running_Balance
                mny_Running_Balance.ViewValue = mny_Running_Balance.CurrentValue;
                mny_Running_Balance.ViewValue = FormatNumber(mny_Running_Balance.ViewValue, mny_Running_Balance.FormatPattern);
                mny_Running_Balance.CellCssStyle += "text-align: right;";
                mny_Running_Balance.ViewCustomAttributes = "";

                // str_Payment_Reference
                str_Payment_Reference.ViewValue = ConvertToString(str_Payment_Reference.CurrentValue); // DN
                str_Payment_Reference.ViewCustomAttributes = "";

                // int_Accepted_By
                int_Accepted_By.ViewValue = int_Accepted_By.CurrentValue;
                int_Accepted_By.ViewValue = FormatNumber(int_Accepted_By.ViewValue, int_Accepted_By.FormatPattern);
                int_Accepted_By.ViewCustomAttributes = "";

                // str_Check_Number
                str_Check_Number.ViewValue = ConvertToString(str_Check_Number.CurrentValue); // DN
                str_Check_Number.ViewCustomAttributes = "";

                // bit_Is_Check_Deposited
                if (ConvertToBool(bit_Is_Check_Deposited.CurrentValue)) {
                    bit_Is_Check_Deposited.ViewValue = bit_Is_Check_Deposited.TagCaption(1) != "" ? bit_Is_Check_Deposited.TagCaption(1) : "Yes";
                } else {
                    bit_Is_Check_Deposited.ViewValue = bit_Is_Check_Deposited.TagCaption(2) != "" ? bit_Is_Check_Deposited.TagCaption(2) : "No";
                }
                bit_Is_Check_Deposited.ViewCustomAttributes = "";

                // str_Adjustment_Type
                str_Adjustment_Type.ViewValue = ConvertToString(str_Adjustment_Type.CurrentValue); // DN
                str_Adjustment_Type.ViewCustomAttributes = "";

                // str_Adjust_Sub_Type
                str_Adjust_Sub_Type.ViewValue = ConvertToString(str_Adjust_Sub_Type.CurrentValue); // DN
                str_Adjust_Sub_Type.ViewCustomAttributes = "";

                // bit_Archive
                if (ConvertToBool(bit_Archive.CurrentValue)) {
                    bit_Archive.ViewValue = bit_Archive.TagCaption(1) != "" ? bit_Archive.TagCaption(1) : "Yes";
                } else {
                    bit_Archive.ViewValue = bit_Archive.TagCaption(2) != "" ? bit_Archive.TagCaption(2) : "No";
                }
                bit_Archive.ViewCustomAttributes = "";

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

                // str_CardHolder_Address
                str_CardHolder_Address.ViewValue = ConvertToString(str_CardHolder_Address.CurrentValue); // DN
                str_CardHolder_Address.ViewCustomAttributes = "";

                // str_CH_City
                str_CH_City.ViewValue = ConvertToString(str_CH_City.CurrentValue); // DN
                str_CH_City.ViewCustomAttributes = "";

                // str_CH_Zip
                str_CH_Zip.ViewValue = ConvertToString(str_CH_Zip.CurrentValue); // DN
                str_CH_Zip.ViewCustomAttributes = "";

                // int_State
                int_State.ViewValue = int_State.CurrentValue;
                int_State.ViewValue = FormatNumber(int_State.ViewValue, int_State.FormatPattern);
                int_State.ViewCustomAttributes = "";

                // bit_IsAuthDotNet
                if (ConvertToBool(bit_IsAuthDotNet.CurrentValue)) {
                    bit_IsAuthDotNet.ViewValue = bit_IsAuthDotNet.TagCaption(1) != "" ? bit_IsAuthDotNet.TagCaption(1) : "Yes";
                } else {
                    bit_IsAuthDotNet.ViewValue = bit_IsAuthDotNet.TagCaption(2) != "" ? bit_IsAuthDotNet.TagCaption(2) : "No";
                }
                bit_IsAuthDotNet.ViewCustomAttributes = "";

                // bit_IsRefund
                if (ConvertToBool(bit_IsRefund.CurrentValue)) {
                    bit_IsRefund.ViewValue = bit_IsRefund.TagCaption(1) != "" ? bit_IsRefund.TagCaption(1) : "Yes";
                } else {
                    bit_IsRefund.ViewValue = bit_IsRefund.TagCaption(2) != "" ? bit_IsRefund.TagCaption(2) : "No";
                }
                bit_IsRefund.ViewCustomAttributes = "";

                // str_Receipt
                str_Receipt.ViewValue = ConvertToString(str_Receipt.CurrentValue); // DN
                str_Receipt.ViewCustomAttributes = "";

                // str_TransactionNumber
                str_TransactionNumber.ViewValue = ConvertToString(str_TransactionNumber.CurrentValue); // DN
                str_TransactionNumber.ViewCustomAttributes = "";

                // str_OrderId
                str_OrderId.ViewValue = ConvertToString(str_OrderId.CurrentValue); // DN
                str_OrderId.ViewCustomAttributes = "";

                // str_TransactionTime
                str_TransactionTime.ViewValue = str_TransactionTime.CurrentValue;
                str_TransactionTime.ViewCustomAttributes = "";

                // int_Location_Id
                int_Location_Id.ViewValue = int_Location_Id.CurrentValue;
                int_Location_Id.ViewValue = FormatNumber(int_Location_Id.ViewValue, int_Location_Id.FormatPattern);
                int_Location_Id.ViewCustomAttributes = "";

                // str_Enrollment_Id
                str_Enrollment_Id.ViewValue = ConvertToString(str_Enrollment_Id.CurrentValue); // DN
                str_Enrollment_Id.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // str_Payment_Note
                str_Payment_Note.ViewValue = str_Payment_Note.CurrentValue;
                str_Payment_Note.ViewCustomAttributes = "";

                // int_Package_ID
                curVal = ConvertToString(int_Package_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Package_ID.Lookup != null && IsDictionary(int_Package_ID.Lookup?.Options) && int_Package_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Package_ID.ViewValue = int_Package_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Package_Id]", "=", int_Package_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Package_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Package_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_Package_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_Package_ID.ViewValue = int_Package_ID.HighlightLookup(ConvertToString(rswrk[0]), int_Package_ID.DisplayValue(listwrk));
                        } else {
                            int_Package_ID.ViewValue = FormatNumber(int_Package_ID.CurrentValue, int_Package_ID.FormatPattern);
                        }
                    }
                } else {
                    int_Package_ID.ViewValue = DbNullValue;
                }
                int_Package_ID.ViewCustomAttributes = "";

                // Package_Name
                Package_Name.ViewValue = ConvertToString(Package_Name.CurrentValue); // DN
                curVal = ConvertToString(Package_Name.CurrentValue);
                if (!Empty(curVal)) {
                    if (Package_Name.Lookup != null && IsDictionary(Package_Name.Lookup?.Options) && Package_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Package_Name.ViewValue = Package_Name.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Package_Name]", "=", Package_Name.CurrentValue, DataType.String, "");
                        sqlWrk = Package_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Package_Name.Lookup != null) { // Lookup values found
                            var listwrk = Package_Name.Lookup?.RenderViewRow(rswrk[0]);
                            Package_Name.ViewValue = Package_Name.HighlightLookup(ConvertToString(rswrk[0]), Package_Name.DisplayValue(listwrk));
                        } else {
                            Package_Name.ViewValue = Package_Name.CurrentValue;
                        }
                    }
                } else {
                    Package_Name.ViewValue = DbNullValue;
                }
                Package_Name.ViewCustomAttributes = "";

                // Price
                curVal = ConvertToString(Price.CurrentValue);
                if (!Empty(curVal)) {
                    if (Price.Lookup != null && IsDictionary(Price.Lookup?.Options) && Price.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        Price.ViewValue = Price.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[mny_Price]", "=", Price.CurrentValue, DataType.Number, "");
                        sqlWrk = Price.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && Price.Lookup != null) { // Lookup values found
                            var listwrk = Price.Lookup?.RenderViewRow(rswrk[0]);
                            Price.ViewValue = Price.HighlightLookup(ConvertToString(rswrk[0]), Price.DisplayValue(listwrk));
                        } else {
                            Price.ViewValue = FormatCurrency(Price.CurrentValue, Price.FormatPattern);
                        }
                    }
                } else {
                    Price.ViewValue = DbNullValue;
                }
                Price.ViewCustomAttributes = "";

                // AssessmentID
                AssessmentID.ViewValue = AssessmentID.CurrentValue;
                AssessmentID.ViewValue = FormatNumber(AssessmentID.ViewValue, AssessmentID.FormatPattern);
                AssessmentID.ViewCustomAttributes = "";

                // course
                course.ViewValue = ConvertToString(course.CurrentValue); // DN
                course.ViewCustomAttributes = "";

                // institution
                institution.ViewValue = ConvertToString(institution.CurrentValue); // DN
                institution.ViewCustomAttributes = "";

                // UniqueIdx
                UniqueIdx.ViewValue = ConvertToString(UniqueIdx.CurrentValue); // DN
                UniqueIdx.ViewCustomAttributes = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // int_Payment_Method
                int_Payment_Method.HrefValue = "";
                int_Payment_Method.TooltipValue = "";

                // date_Paid
                date_Paid.HrefValue = "";
                date_Paid.TooltipValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";
                str_ApprovalCode.TooltipValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";
                str_Amount_Pay.TooltipValue = "";

                // mny_Running_Payments
                mny_Running_Payments.HrefValue = "";
                mny_Running_Payments.TooltipValue = "";

                // mny_Running_Balance
                mny_Running_Balance.HrefValue = "";
                mny_Running_Balance.TooltipValue = "";

                // str_TransactionTime
                str_TransactionTime.HrefValue = "";
                str_TransactionTime.TooltipValue = "";

                // str_Payment_Note
                str_Payment_Note.HrefValue = "";
                str_Payment_Note.TooltipValue = "";

                // Package_Name
                Package_Name.HrefValue = "";
                Package_Name.TooltipValue = "";

                // Price
                Price.HrefValue = "";
                Price.TooltipValue = "";

                // course
                course.HrefValue = "";
                course.TooltipValue = "";

                // institution
                institution.HrefValue = "";
                institution.TooltipValue = "";
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblBillingInfoview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblBillingInfoview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblBillingInfoview\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblBillingInfoview\" data-ew-action=\"email\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-key='" + HtmlEncode(ConvertToJsonAttribute(RecordKeys)) + "' data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
                int_Bill_ID.OldValue = keys[0];
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

            // Export detail records (tblStudentEnrollment)
            if (Config.ExportDetailRecords && CurrentDetailTables.Contains("tblStudentEnrollment")) {
                tblStudentEnrollment = new TblStudentEnrollmentList();
                if (tblStudentEnrollment != null) {
                    var c = await GetConnection2Async(tblStudentEnrollment.DbId); // Note: Use new connection for detail records // DN
                    using var rsdetail = await tblStudentEnrollment.LoadReader(tblStudentEnrollment.DetailFilterFromSession, tblStudentEnrollment.SessionOrderBy, c); // Load detail records
                    if (rsdetail?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("h"); // Change to horizontal
                        if (Export != "csv" || Config.ExportDetailRecordsForCsv) {
                            doc.ExportEmptyRow();
                            int detailcnt = await tblStudentEnrollment.LoadRecordCountAsync(tblStudentEnrollment.DetailFilterFromSession); // DN
                            var oldtbl = doc.Table;
                            doc.Table = tblStudentEnrollment;
                            await tblStudentEnrollment.ExportDocument(doc, rsdetail, 1, detailcnt);
                            doc.Table = oldtbl;
                        }
                        doc.SetStyle(exportStyle); // Restore
                    }
                }
            }

            // Export detail records (qryBillingDetails_v2)
            if (Config.ExportDetailRecords && CurrentDetailTables.Contains("qryBillingDetails_v2")) {
                qryBillingDetailsV2 = new QryBillingDetailsV2List();
                if (qryBillingDetailsV2 != null) {
                    var c = await GetConnection2Async(qryBillingDetailsV2.DbId); // Note: Use new connection for detail records // DN
                    using var rsdetail = await qryBillingDetailsV2.LoadReader(qryBillingDetailsV2.DetailFilterFromSession, qryBillingDetailsV2.SessionOrderBy, c); // Load detail records
                    if (rsdetail?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("h"); // Change to horizontal
                        if (Export != "csv" || Config.ExportDetailRecordsForCsv) {
                            doc.ExportEmptyRow();
                            int detailcnt = await qryBillingDetailsV2.LoadRecordCountAsync(qryBillingDetailsV2.DetailFilterFromSession); // DN
                            var oldtbl = doc.Table;
                            doc.Table = qryBillingDetailsV2;
                            await qryBillingDetailsV2.ExportDocument(doc, rsdetail, 1, detailcnt);
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
                if (masterTblVar == "tblPotentialStudentInfo") {
                    validMaster = true;
                    if (tblPotentialStudentInfo != null && (Get("fk_NationalID", out fk) || Get("NationalID", out fk))) {
                        tblPotentialStudentInfo.NationalID.QueryValue = fk;
                        NationalID.QueryValue = tblPotentialStudentInfo.NationalID.QueryValue;
                        NationalID.SessionValue = NationalID.QueryValue;
                        foreignKeys.Add("NationalID", fk);
                        if (!IsNumeric(NationalID.QueryValue))
                            validMaster = false;
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
                if (masterTblVar == "tblPotentialStudentInfo") {
                    validMaster = true;
                    if (tblPotentialStudentInfo != null && (Post("fk_NationalID", out fk) || Post("NationalID", out fk))) {
                        tblPotentialStudentInfo.NationalID.FormValue = fk;
                        NationalID.FormValue = tblPotentialStudentInfo.NationalID.FormValue;
                        NationalID.SessionValue = NationalID.FormValue;
                        foreignKeys.Add("NationalID", fk);
                        if (!IsNumeric(NationalID.FormValue))
                            validMaster = false;
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
                if (masterTblVar != "tblPotentialStudentInfo") {
                    if (!foreignKeys.ContainsKey("NationalID")) // Not current foreign key
                        NationalID.SessionValue = "";
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
                if (detailTblVars.Contains("tblStudentEnrollment")) {
                    tblStudentEnrollmentGrid = Resolve("TblStudentEnrollmentGrid")!;
                    if (tblStudentEnrollmentGrid?.DetailView ?? false) {
                        tblStudentEnrollmentGrid.CurrentMode = "view";

                        // Save current master table to detail table
                        tblStudentEnrollmentGrid.CurrentMasterTable = TableVar;
                        tblStudentEnrollmentGrid.StartRecordNumber = 1;
                        tblStudentEnrollmentGrid.NationalID.IsDetailKey = true;
                        tblStudentEnrollmentGrid.NationalID.CurrentValue = NationalID.CurrentValue;
                        tblStudentEnrollmentGrid.NationalID.SessionValue = tblStudentEnrollmentGrid.NationalID.CurrentValue;
                    }
                }
                if (detailTblVars.Contains("qryBillingDetails_v2")) {
                    qryBillingDetailsV2Grid = Resolve("QryBillingDetailsV2Grid")!;
                    if (qryBillingDetailsV2Grid?.DetailView ?? false) {
                        qryBillingDetailsV2Grid.CurrentMode = "view";

                        // Save current master table to detail table
                        qryBillingDetailsV2Grid.CurrentMasterTable = TableVar;
                        qryBillingDetailsV2Grid.StartRecordNumber = 1;
                        qryBillingDetailsV2Grid.NationalID.IsDetailKey = true;
                        qryBillingDetailsV2Grid.NationalID.CurrentValue = NationalID.CurrentValue;
                        qryBillingDetailsV2Grid.NationalID.SessionValue = qryBillingDetailsV2Grid.NationalID.CurrentValue;
                    }
                }
            }
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblBillingInfoList")), "", TableVar, true);
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
