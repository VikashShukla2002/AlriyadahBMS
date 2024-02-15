namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStudentsList
    /// </summary>
    public static TblStudentsList tblStudentsList
    {
        get => HttpData.Get<TblStudentsList>("tblStudentsList")!;
        set => HttpData["tblStudentsList"] = value;
    }

    /// <summary>
    /// Page class for tblStudents
    /// </summary>
    public class TblStudentsList : TblStudentsListBase
    {
        // Constructor
        public TblStudentsList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblStudentsList() : base()
        {
        }

        // Page Data Rendering event
        public override void PageDataRendering(ref string header) {
            header = $"<p class='text-end'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{CurrentUserName()}</span></p>";
        }
        // Page Data Rendered event
        public override void PageDataRendered(ref string footer) {
        	footer = $"<p class='text-start'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{GetCurrentUserLevelName()}</span></p>";
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblStudentsListBase : TblStudents
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblStudents";

        // Page object name
        public string PageObjName = "tblStudentsList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblStudentslist";

        public string FormActionName = "";

        public string FormBlankRowName = "";

        public string FormKeyCountName = "";

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
        public TblStudentsListBase()
        {
            // CSS class name as context
            TableVar = "tblStudents";
            ContextClass = CheckClassName(TableVar);
            TableGridClass = AppendClass(TableGridClass, ContextClass);
            FormActionName = Config.FormRowActionName;
            FormBlankRowName = Config.FormBlankRowName;
            FormKeyCountName = Config.FormKeyCountName;

            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-table";

            // CSS class name as context
            ContextClass = CheckClassName(TableVar);
            TableGridClass = AppendClass(TableGridClass, ContextClass);

            // Language object
            Language = ResolveLanguage();

            // Table object (tblStudents)
            if (tblStudents == null || tblStudents is TblStudents)
                tblStudents = this;

            // Initialize URLs
            AddUrl = "TblStudentsAdd?" + Config.TableShowDetail + "=";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblStudentsDelete";
            MultiUpdateUrl = "TblStudentsUpdate";

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
            OtherOptions["addedit"] = new () {
                TagClassName = "ew-add-edit-option",
                UseDropDownButton = false,
                DropDownButtonPhrase = "ButtonAddEdit",
                UseButtonGroup = true
            };

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
        public string PageName => "TblStudentsList";

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
            int_Student_ID.Visible = false;
            str_First_Name.SetVisibility();
            str_Middle_Name.Visible = false;
            str_Last_Name.SetVisibility();
            str_Full_Name.Visible = false;
            str_Address.Visible = false;
            str_City.Visible = false;
            int_State.Visible = false;
            str_Zip.Visible = false;
            date_Hired.Visible = false;
            date_Left.Visible = false;
            str_CertNumber.Visible = false;
            date_CertExp.Visible = false;
            str_Cell_Phone.SetVisibility();
            str_Home_Phone.Visible = false;
            str_Other_Phone.Visible = false;
            str_Email.SetVisibility();
            str_Code.Visible = false;
            str_Username.Visible = false;
            str_Password.Visible = false;
            date_Birth_Hijri.Visible = false;
            date_Birth.Visible = false;
            Hijri_Year.Visible = false;
            Hijri_Month.Visible = false;
            Hijri_Day.Visible = false;
            date_Started.Visible = false;
            str_DateHired.Visible = false;
            str_DateLeft.Visible = false;
            str_Emergency_Contact_Name.Visible = false;
            str_Emergency_Contact_Phone.Visible = false;
            str_Emergency_Contact_Relation.Visible = false;
            str_Notes.Visible = false;
            int_ClassType.Visible = false;
            str_ZipCodes.Visible = false;
            int_VehicleAssigned.Visible = false;
            int_Status.Visible = false;
            int_Type.Visible = false;
            int_Location.Visible = false;
            date_Created.Visible = false;
            date_Modified.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            bit_IsDeleted.Visible = false;
            str_InstPermitNo.Visible = false;
            date_PermitExpiration.Visible = false;
            date_InCarPermitIssue.Visible = false;
            str_InClassPermitNo.Visible = false;
            date_InClassPermitIssue.Visible = false;
            instructor_caption.Visible = false;
            str_LicType.Visible = false;
            int_Order.Visible = false;
            str_InstLicenceDate.Visible = false;
            str_DLNum.Visible = false;
            str_DLExp.Visible = false;
            bit_appointmentColor.Visible = false;
            str_appointmentColorCode.Visible = false;
            bit_IsSuperAdmin.Visible = false;
            IsDistanceBasedScheduling.Visible = false;
            str_Package_Code.Visible = false;
            str_NationalID_Iqama.SetVisibility();
            NationalID.Visible = false;
            int_RoadDistanceCoverage.Visible = false;
            str_Badge.Visible = false;
            strZoomHostUrl.Visible = false;
            strZoomUserUrl.Visible = false;
            Signature.Visible = false;
            str_VehicleType.Visible = false;
            ProfilePicturePath.Visible = false;
            Institution.Visible = false;
            IsDrivingexperience.Visible = false;
            intDrivinglicenseType.SetVisibility();
            AbsherApptNbr.SetVisibility();
            Absherphoto.Visible = false;
            Fingerprint.Visible = false;
            ProfileField.Visible = false;
            UserlevelID.Visible = false;
            Parent_Username.Visible = false;
            Activated.Visible = false;
            int_Nationality.Visible = false;
            User_Role.Visible = false;
            int_Staff_Id.Visible = false;
        }

        // Constructor
        public TblStudentsListBase(Controller? controller = null): this() { // DN
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

        /// <summary>
        /// Run chart
        /// </summary>
        /// <param name="chartVar">Chart variable name</param>
        /// <returns>Page result</returns>
        public async Task<IActionResult> RunChart(string chartVar = "") { // DN
            IActionResult res = await Run();
            DbChart? chart = ChartByParam(chartVar);
            if (!IsTerminated && chart != null) {
                string chartClass = (chart.PageBreakType == "before") ? "ew-chart-bottom" : "ew-chart-top";
                int chartWidth = Query.TryGetValue("width", out StringValues sv) ? ConvertToInt(sv) : -1;
                int chartHeight = Query.TryGetValue("height", out StringValues sv2) ? ConvertToInt(sv2) : -1;
                return Controller.Content(ConvertToString(await chart.Render(chartClass, chartWidth, chartHeight)), "text/html", Encoding.UTF8);
            }
            return res;
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
                            if (fld.DataType == DataType.Memo && fld.MemoMaxLength > 0 && !Empty(val))
                                val = TruncateMemo(val, fld.MemoMaxLength, fld.TruncateMemoRemoveHtml);
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
            if (IsAddOrEdit)
                date_Created.Visible = false;
            if (IsAddOrEdit)
                date_Modified.Visible = false;
            if (IsAddOrEdit)
                int_Created_By.Visible = false;
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

        // Properties
        private Pager? _pager; // DN

        public int SelectedCount = 0;

        public int SelectedIndex = 0;

        public int DisplayRecords = 20; // Number of display records

        public int StartRecord;

        public int StopRecord;

        public int TotalRecords = -1;

        public int RecordRange = 10;

        public string PageSizes = "10,20,50,-1"; // Page sizes (comma separated)

        public string DefaultSearchWhere = ""; // Default search WHERE clause

        public string SearchWhere = ""; // Search WHERE clause

        public string SearchPanelClass = "ew-search-panel collapse show"; // Search panel class

        public int SearchColumnCount = 0; // For extended search

        public int SearchFieldsPerRow = 1; // For extended search

        public int RecordCount = 0; // Record count

        public int InlineRowCount = 0;

        public int StartRowCount = 1;

        public List<Tuple<string, Dictionary<string, string>>> Attributes = new (); // Row attributes and cell attributes

        public object RowIndex = 0; // Row index

        public int KeyCount = 0; // Key count

        public string MultiColumnGridClass = "row-cols-md-2";

        public string MultiColumnEditClass = "col-12 w-100";

        public string MultiColumnCardClass = "card h-100 ew-card";

        public string MultiColumnListOptionsPosition = "bottom-start";

        public string MultiColumnLayout = "cards";

        public string DbMasterFilter = ""; // Master filter

        public string DbDetailFilter = ""; // Detail filter

        public bool MasterRecordExists;

        public string MultiSelectKey = "";

        public string UserAction = ""; // User action

        public bool RestoreSearch = false;

        public SubPages? DetailPages; // Detail pages object

        public DbDataReader? Recordset;

        public string TopContentClass = "ew-top";

        public string MiddleContentClass = "ew-middle";

        public string BottomContentClass = "ew-bottom";

        public List<string> RecordKeys = new ();

        public bool IsModal = false;

        private string FilterForModalActions = "";

        private bool UseInfiniteScroll = false;

        // Pager
        public Pager Pager
        {
            get {
                _pager ??= new PrevNextPager(this, StartRecord, RecordsPerPage, TotalRecords, PageSizes, RecordRange, AutoHidePager, AutoHidePageSizeSelector);
                return _pager;
            }
        }

        /// <summary>
        /// Load recordset from filter
        /// <param name="filter">Record filter</param>
        /// </summary>
        public async Task LoadRecordsetFromFilter(string filter)
        {
            // Set up list options
            await SetupListOptions();

            // Search options
            SetupSearchOptions();

            // Other options
            SetupOtherOptions();

            // Set visibility
            SetVisibility();

            // Load recordset
            TotalRecords = LoadRecordCount(filter);
            StartRecord = 1;
            StopRecord = DisplayRecords;
            CurrentFilter = filter;
            Recordset = await LoadRecordset();
        }

        #pragma warning disable 219
        /// <summary>
        /// Page run
        /// </summary>
        /// <returns>Page result</returns>
        public override async Task<IActionResult> Run()
        {
            // Multi column button position
            MultiColumnListOptionsPosition = Config.MultiColumnListOptionsPosition;
            DashboardReport = DashboardReport || Param<bool>(Config.PageDashboard);

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

            // Get grid add count
            int gridaddcnt = Get<int>(Config.TableGridAddRowCount);
            if (gridaddcnt > 0)
                GridAddRowCount = gridaddcnt;

            // Set up list options
            await SetupListOptions();

            // Setup export options
            SetupExportOptions();
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

            // Setup other options
            SetupOtherOptions();
            ListActions.Add("resendregisteremail", Language.Phrase("ResendRegisterEmailBtn"), Security.IsAdmin, Config.ActionAjax, Config.ActionSingle);
            ListActions.Add("resetloginretry", Language.Phrase("ResetLoginRetryBtn"), Security.IsAdmin, Config.ActionAjax, Config.ActionSingle);

            // Set up custom action (compatible with old version)
            ListActions.Add(CustomActions);

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

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblStudentsgrid";

            // Set up infinite scroll
            UseInfiniteScroll = Param<bool>("infinitescroll");

            // Search filters
            string srchAdvanced = ""; // Advanced search filter
            string srchBasic = ""; // Basic search filter
            string filter = ""; // Filter
            string query = ""; // Query builder

            // Get command
            Command = Get("cmd").ToLower();

            // Process list action first
            var result = await ProcessListAction();
            if (result is not EmptyResult) // Ajax request
                return result;

            // Set up records per page
            SetupDisplayRecords();

            // Handle reset command
            ResetCommand();

            // Set up Breadcrumb
            if (!IsExport())
                SetupBreadcrumb();

            // Hide list options
            if (IsExport()) {
                ListOptions.HideAllOptions(new () {"sequence"});
                ListOptions.UseDropDownButton = false; // Disable drop down button
                ListOptions.UseButtonGroup = false; // Disable button group
            } else if (IsGridAdd || IsGridEdit || IsMultiEdit || IsConfirm) {
                ListOptions.HideAllOptions();
                ListOptions.UseDropDownButton = false; // Disable drop down button
                ListOptions.UseButtonGroup = false; // Disable button group
            }

            // Hide options
            if (IsExport() || !Empty(CurrentAction) || IsSearch) {
                ExportOptions.HideAllOptions();
                FilterOptions.HideAllOptions();
                ImportOptions.HideAllOptions();
            }

            // Hide other options
            if (IsExport()) {
                foreach (var (key, value) in OtherOptions)
                    value.HideAllOptions();
            }

            // Get default search criteria
            AddFilter(ref DefaultSearchWhere, BasicSearchWhere(true));
            AddFilter(ref DefaultSearchWhere, AdvancedSearchWhere(true));

            // Get basic search values
            LoadBasicSearchValues();

            // Get and validate search values for advanced search
            if (Empty(UserAction)) // Skip if user action
                LoadSearchValues(); // Get search values

            // Process filter list
            var filterResult = await ProcessFilterList();
            if (filterResult != null) {
                // Clean output buffer
                if (!Config.Debug)
                    Response?.Clear();
                return Controller.Json(filterResult);
            }
            CurrentForm?.ResetIndex();
            if (!ValidateSearch()) {
                // Nothing to do
            }

            // Restore search parms from Session if not searching / reset / export
            if ((IsExport() || Command != "search" && Command != "reset" && Command != "resetall") && Command != "json" && CheckSearchParms())
                RestoreSearchParms();

            // Call Recordset SearchValidated event
            RecordsetSearchValidated();

            // Set up sorting order
            SetupSortOrder();

            // Get basic search criteria
            if (!HasInvalidFields())
                srchBasic = BasicSearchWhere();

            // Get search criteria for advanced search
            if (!HasInvalidFields())
                srchAdvanced = AdvancedSearchWhere();

            // Get query builder criteria
            query = QueryBuilderWhere();

            // Restore display records
            if (Command != "json" && (RecordsPerPage == -1 || RecordsPerPage > 0)) {
                DisplayRecords = RecordsPerPage; // Restore from Session
            } else {
                DisplayRecords = 20; // Load default
                RecordsPerPage = DisplayRecords; // Save default to session
            }

            // Load search default if no existing search criteria
            if (!CheckSearchParms() && Empty(query)) {
                // Load basic search from default
                BasicSearch.LoadDefault();
                if (!Empty(BasicSearch.Keyword))
                    srchBasic = BasicSearchWhere(); // Save to session

                // Load advanced search from default
                if (LoadAdvancedSearchDefault())
                    srchAdvanced = AdvancedSearchWhere(); // Save to session
            }

            // Restore search settings from Session
            if (!HasInvalidFields())
                LoadAdvancedSearch();

            // Build search criteria
            if (!Empty(query)) {
                AddFilter(ref SearchWhere, query);
            } else {
                AddFilter(ref SearchWhere, srchAdvanced);
                AddFilter(ref SearchWhere, srchBasic);
            }

            // Call Recordset Searching event
            RecordsetSearching(ref SearchWhere);

            // Save search criteria
            if (Command == "search" && !RestoreSearch) {
                SessionSearchWhere = SearchWhere; // Save to Session (rename as SessionSearchWhere property)
                StartRecord = 1; // Reset start record counter
                StartRecordNumber = StartRecord;
            } else if (Command != "json" && Empty(query)) {
                SearchWhere = SessionSearchWhere;
            }

            // Build filter
            filter = "";
            if (!Security.CanList)
                filter = "(0=1)"; // Filter all records
            AddFilter(ref filter, DbDetailFilter);
            AddFilter(ref filter, SearchWhere);

            // Set up filter
            if (Command == "json") {
                UseSessionForListSql = false; // Do not use session for ListSql
                CurrentFilter = filter;
            } else {
                SessionWhere = filter;
                CurrentFilter = "";
            }
            Filter = ApplyUserIDFilters(filter);
            if (IsGridAdd) {
                CurrentFilter = "0=1";
                StartRecord = 1;
                DisplayRecords = GridAddRowCount;
                TotalRecords = DisplayRecords;
                StopRecord = DisplayRecords;
            } else if ((IsEdit || IsCopy || IsInlineInserted || IsInlineUpdated) && UseInfiniteScroll) { // Get current record only
                CurrentFilter = IsInlineUpdated ? GetRecordFilter() : GetFilterFromRecordKeys();
                TotalRecords = ListRecordCount();
                StartRecord = 1;
                StopRecord = DisplayRecords;
                Recordset = await LoadRecordset();
            } else if (
                UseInfiniteScroll && IsGridInserted ||
                UseInfiniteScroll && (IsGridEdit || IsGridUpdated) ||
                IsMultiEdit ||
                UseInfiniteScroll && IsMultiUpdated
            ) { // Get current records only
                CurrentFilter = FilterForModalActions; // Restore filter
                TotalRecords = ListRecordCount();
                StartRecord = 1;
                StopRecord = DisplayRecords;
                Recordset = await LoadRecordset();
            } else {
                TotalRecords = await ListRecordCountAsync();
                StopRecord = DisplayRecords;
                StartRecord = 1;
                if (DisplayRecords <= 0 || (IsExport() && ExportAll)) // Display all records
                    DisplayRecords = TotalRecords;
                if (!(IsExport() && ExportAll)) // Set up start record position
                    SetupStartRecord();

                // Recordset
                bool selectLimit = UseSelectLimit;

                // Set up list action columns, must be before LoadRecordset // DN
                foreach (var (key, act) in ListActions.Items.Where(kvp => kvp.Value.Allowed)) {
                    if (act.Select == Config.ActionMultiple && ListOptions["checkbox"] is ListOption listOpt) { // Show checkbox column if multiple action
                        listOpt.Visible = true;
                    } else if (act.Select == Config.ActionSingle) { // Show list action column
                            ListOptions["listactions"]?.SetVisible(true); // Set visible if any list action is allowed
                    }
                }
                if (selectLimit)
                    Recordset = await LoadRecordset(StartRecord - 1, DisplayRecords);

                // Set no record found message
                if ((Empty(CurrentAction) || IsSearch) && TotalRecords == 0) {
                    if (!Security.CanList)
                        WarningMessage = DeniedMessage();
                    if (SearchWhere == "0=101")
                        WarningMessage = Language.Phrase("EnterSearchCriteria");
                    else
                        WarningMessage = Language.Phrase("NoRecord");
                }
            }

            // Search options
            SetupSearchOptions();

            // Set up search panel class
            if (!Empty(SearchWhere)) {
                if (!Empty(query)) { // Hide search panel if using QueryBuilder
                    SearchPanelClass = RemoveClass(SearchPanelClass, "show");
                } else {
                    SearchPanelClass = AppendClass(SearchPanelClass, "show");
                }
            }

            // Handle inline add for custom template in table layout with no records
            if (UseCustomTemplate && MultiColumnLayout == "table" && IsAdd && TotalRecords == 0)
                MultiColumnLayout = "cards";

            // No custom template for cards layout
            if (MultiColumnLayout == "cards")
                UseCustomTemplate = false;

            // API list action
            if (IsApi()) {
                if (CurrentPageName().EndsWith(Config.ApiListAction)) { // DN
                    if (!IsExport()) {
                        if (!Connection.SelectOffset && Recordset != null) { // DN
                            for (var i = 1; i <= StartRecord - 1; i++) // Move to first record
                                await Recordset.ReadAsync();
                        }
                        using (Recordset) {
                            return Controller.Json(new Dictionary<string, object> { {"success", true}, {TableVar, await GetRecordsFromRecordset(Recordset)}, {"totalRecordCount", TotalRecords}, {"version", Config.ProductVersion} });
                        }
                    }
                } else if (!Empty(FailureMessage)) {
                    return Controller.Json(new { success = false, error = GetFailureMessage() });
                }
                return new EmptyResult();
            }

            // Render other options
            RenderOtherOptions();

            // Set ReturnUrl in header if necessary
            if (TempData["Return-Url"] != null)
                AddHeader("Return-Url", ConvertToString(TempData["Return-Url"]));

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                tblStudentsList?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 219

        // Get page number
        public int PageNumber => DisplayRecords > 0 && StartRecord > 0 ? ConvertToInt(Math.Ceiling((double)StartRecord / DisplayRecords)) : 1;

        // Set up number of records displayed per page
        protected void SetupDisplayRecords() {
            string wrk = Get(Config.TableRecordsPerPage);
            if (!Empty(wrk)) {
                if (IsNumeric(wrk)) {
                    DisplayRecords = ConvertToInt(wrk);
                } else {
                    if (SameText(wrk, "all")) { // Display all records
                        DisplayRecords = -1;
                    } else {
                        DisplayRecords = 20; // Non-numeric, load default
                    }
                }
                RecordsPerPage = DisplayRecords; // Save to Session
                // Reset start position
                StartRecord = 1;
                StartRecordNumber = StartRecord;
            }
        }

        // Build filter for all keys
        protected string BuildKeyFilter() {
            string wrkFilter = "";

            // Update row index and get row key
            int rowindex = 1;
            CurrentForm!.Index = rowindex;
            string thisKey = CurrentForm.GetValue(OldKeyName);
            while (!Empty(thisKey)) {
                SetKey(thisKey);
                if (!Empty(OldKey)) {
                    string filter = GetRecordFilter();
                    if (!Empty(wrkFilter))
                        wrkFilter += " OR ";
                    wrkFilter += filter;
                } else {
                    wrkFilter = "0=1";
                    break;
                }

                // Update row index and get row key
                rowindex++; // next row
                CurrentForm!.Index = rowindex;
                thisKey = CurrentForm.GetValue(OldKeyName);
            }
            return wrkFilter;
        }

        // Check if empty row
        public bool EmptyRow() => false;

        #pragma warning disable 162, 1998
        // Get list of filters
        public async Task<string> GetFilterList()
        {
            string filterList = "";
            string savedFilterList = "";

            // Load server side filters
            if (Config.SearchFilterOption == "Server")
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblStudentssrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(int_Student_ID.AdvancedSearch.ToJson())); // Field int_Student_ID
            filters.Merge(JObject.Parse(str_First_Name.AdvancedSearch.ToJson())); // Field str_First_Name
            filters.Merge(JObject.Parse(str_Middle_Name.AdvancedSearch.ToJson())); // Field str_Middle_Name
            filters.Merge(JObject.Parse(str_Last_Name.AdvancedSearch.ToJson())); // Field str_Last_Name
            filters.Merge(JObject.Parse(str_Full_Name.AdvancedSearch.ToJson())); // Field str_Full_Name
            filters.Merge(JObject.Parse(str_Address.AdvancedSearch.ToJson())); // Field str_Address
            filters.Merge(JObject.Parse(str_City.AdvancedSearch.ToJson())); // Field str_City
            filters.Merge(JObject.Parse(int_State.AdvancedSearch.ToJson())); // Field int_State
            filters.Merge(JObject.Parse(str_Zip.AdvancedSearch.ToJson())); // Field str_Zip
            filters.Merge(JObject.Parse(date_Hired.AdvancedSearch.ToJson())); // Field date_Hired
            filters.Merge(JObject.Parse(date_Left.AdvancedSearch.ToJson())); // Field date_Left
            filters.Merge(JObject.Parse(str_CertNumber.AdvancedSearch.ToJson())); // Field str_CertNumber
            filters.Merge(JObject.Parse(date_CertExp.AdvancedSearch.ToJson())); // Field date_CertExp
            filters.Merge(JObject.Parse(str_Cell_Phone.AdvancedSearch.ToJson())); // Field str_Cell_Phone
            filters.Merge(JObject.Parse(str_Home_Phone.AdvancedSearch.ToJson())); // Field str_Home_Phone
            filters.Merge(JObject.Parse(str_Other_Phone.AdvancedSearch.ToJson())); // Field str_Other_Phone
            filters.Merge(JObject.Parse(str_Email.AdvancedSearch.ToJson())); // Field str_Email
            filters.Merge(JObject.Parse(str_Code.AdvancedSearch.ToJson())); // Field str_Code
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(str_Password.AdvancedSearch.ToJson())); // Field str_Password
            filters.Merge(JObject.Parse(date_Birth_Hijri.AdvancedSearch.ToJson())); // Field date_Birth_Hijri
            filters.Merge(JObject.Parse(date_Birth.AdvancedSearch.ToJson())); // Field date_Birth
            filters.Merge(JObject.Parse(Hijri_Year.AdvancedSearch.ToJson())); // Field Hijri_Year
            filters.Merge(JObject.Parse(Hijri_Month.AdvancedSearch.ToJson())); // Field Hijri_Month
            filters.Merge(JObject.Parse(Hijri_Day.AdvancedSearch.ToJson())); // Field Hijri_Day
            filters.Merge(JObject.Parse(date_Started.AdvancedSearch.ToJson())); // Field date_Started
            filters.Merge(JObject.Parse(str_DateHired.AdvancedSearch.ToJson())); // Field str_DateHired
            filters.Merge(JObject.Parse(str_DateLeft.AdvancedSearch.ToJson())); // Field str_DateLeft
            filters.Merge(JObject.Parse(str_Emergency_Contact_Name.AdvancedSearch.ToJson())); // Field str_Emergency_Contact_Name
            filters.Merge(JObject.Parse(str_Emergency_Contact_Phone.AdvancedSearch.ToJson())); // Field str_Emergency_Contact_Phone
            filters.Merge(JObject.Parse(str_Emergency_Contact_Relation.AdvancedSearch.ToJson())); // Field str_Emergency_Contact_Relation
            filters.Merge(JObject.Parse(str_Notes.AdvancedSearch.ToJson())); // Field str_Notes
            filters.Merge(JObject.Parse(int_ClassType.AdvancedSearch.ToJson())); // Field int_ClassType
            filters.Merge(JObject.Parse(str_ZipCodes.AdvancedSearch.ToJson())); // Field str_ZipCodes
            filters.Merge(JObject.Parse(int_VehicleAssigned.AdvancedSearch.ToJson())); // Field int_VehicleAssigned
            filters.Merge(JObject.Parse(int_Status.AdvancedSearch.ToJson())); // Field int_Status
            filters.Merge(JObject.Parse(int_Type.AdvancedSearch.ToJson())); // Field int_Type
            filters.Merge(JObject.Parse(int_Location.AdvancedSearch.ToJson())); // Field int_Location
            filters.Merge(JObject.Parse(date_Created.AdvancedSearch.ToJson())); // Field date_Created
            filters.Merge(JObject.Parse(date_Modified.AdvancedSearch.ToJson())); // Field date_Modified
            filters.Merge(JObject.Parse(int_Created_By.AdvancedSearch.ToJson())); // Field int_Created_By
            filters.Merge(JObject.Parse(int_Modified_By.AdvancedSearch.ToJson())); // Field int_Modified_By
            filters.Merge(JObject.Parse(bit_IsDeleted.AdvancedSearch.ToJson())); // Field bit_IsDeleted
            filters.Merge(JObject.Parse(str_InstPermitNo.AdvancedSearch.ToJson())); // Field str_InstPermitNo
            filters.Merge(JObject.Parse(date_PermitExpiration.AdvancedSearch.ToJson())); // Field date_PermitExpiration
            filters.Merge(JObject.Parse(date_InCarPermitIssue.AdvancedSearch.ToJson())); // Field date_InCarPermitIssue
            filters.Merge(JObject.Parse(str_InClassPermitNo.AdvancedSearch.ToJson())); // Field str_InClassPermitNo
            filters.Merge(JObject.Parse(date_InClassPermitIssue.AdvancedSearch.ToJson())); // Field date_InClassPermitIssue
            filters.Merge(JObject.Parse(instructor_caption.AdvancedSearch.ToJson())); // Field instructor_caption
            filters.Merge(JObject.Parse(str_LicType.AdvancedSearch.ToJson())); // Field str_LicType
            filters.Merge(JObject.Parse(int_Order.AdvancedSearch.ToJson())); // Field int_Order
            filters.Merge(JObject.Parse(str_InstLicenceDate.AdvancedSearch.ToJson())); // Field str_InstLicenceDate
            filters.Merge(JObject.Parse(str_DLNum.AdvancedSearch.ToJson())); // Field str_DLNum
            filters.Merge(JObject.Parse(str_DLExp.AdvancedSearch.ToJson())); // Field str_DLExp
            filters.Merge(JObject.Parse(bit_appointmentColor.AdvancedSearch.ToJson())); // Field bit_appointmentColor
            filters.Merge(JObject.Parse(str_appointmentColorCode.AdvancedSearch.ToJson())); // Field str_appointmentColorCode
            filters.Merge(JObject.Parse(bit_IsSuperAdmin.AdvancedSearch.ToJson())); // Field bit_IsSuperAdmin
            filters.Merge(JObject.Parse(IsDistanceBasedScheduling.AdvancedSearch.ToJson())); // Field IsDistanceBasedScheduling
            filters.Merge(JObject.Parse(str_Package_Code.AdvancedSearch.ToJson())); // Field str_Package_Code
            filters.Merge(JObject.Parse(str_NationalID_Iqama.AdvancedSearch.ToJson())); // Field str_NationalID_Iqama
            filters.Merge(JObject.Parse(NationalID.AdvancedSearch.ToJson())); // Field NationalID
            filters.Merge(JObject.Parse(int_RoadDistanceCoverage.AdvancedSearch.ToJson())); // Field int_RoadDistanceCoverage
            filters.Merge(JObject.Parse(str_Badge.AdvancedSearch.ToJson())); // Field str_Badge
            filters.Merge(JObject.Parse(strZoomHostUrl.AdvancedSearch.ToJson())); // Field strZoomHostUrl
            filters.Merge(JObject.Parse(strZoomUserUrl.AdvancedSearch.ToJson())); // Field strZoomUserUrl
            filters.Merge(JObject.Parse(str_VehicleType.AdvancedSearch.ToJson())); // Field str_VehicleType
            filters.Merge(JObject.Parse(ProfilePicturePath.AdvancedSearch.ToJson())); // Field ProfilePicturePath
            filters.Merge(JObject.Parse(Institution.AdvancedSearch.ToJson())); // Field Institution
            filters.Merge(JObject.Parse(IsDrivingexperience.AdvancedSearch.ToJson())); // Field IsDrivingexperience
            filters.Merge(JObject.Parse(intDrivinglicenseType.AdvancedSearch.ToJson())); // Field intDrivinglicenseType
            filters.Merge(JObject.Parse(AbsherApptNbr.AdvancedSearch.ToJson())); // Field AbsherApptNbr
            filters.Merge(JObject.Parse(Absherphoto.AdvancedSearch.ToJson())); // Field Absherphoto
            filters.Merge(JObject.Parse(Fingerprint.AdvancedSearch.ToJson())); // Field Fingerprint
            filters.Merge(JObject.Parse(ProfileField.AdvancedSearch.ToJson())); // Field ProfileField
            filters.Merge(JObject.Parse(UserlevelID.AdvancedSearch.ToJson())); // Field UserlevelID
            filters.Merge(JObject.Parse(Parent_Username.AdvancedSearch.ToJson())); // Field Parent_Username
            filters.Merge(JObject.Parse(Activated.AdvancedSearch.ToJson())); // Field Activated
            filters.Merge(JObject.Parse(int_Nationality.AdvancedSearch.ToJson())); // Field int_Nationality
            filters.Merge(JObject.Parse(User_Role.AdvancedSearch.ToJson())); // Field User_Role
            filters.Merge(JObject.Parse(int_Staff_Id.AdvancedSearch.ToJson())); // Field int_Staff_Id
            filters.Merge(JObject.Parse(BasicSearch.ToJson()));

            // Return filter list in JSON
            if (filters.HasValues)
                filterList = "\"data\":" + filters.ToString();
            if (savedFilterList != "") {
                if (filterList != "")
                    filterList += ",";
                filterList += "\"filters\":" + savedFilterList;
            }
            return (filterList != "") ? "{" + filterList + "}" : "null";
        }

        // Process filter list
        protected async Task<object?> ProcessFilterList() {
            if (Post("ajax") == "savefilters") {
                string filters = Post("filters");
                await Profile.SetSearchFilters(CurrentUserName(), "ftblStudentssrch", filters);
                return new [] { new { success = true } }; // Return success
            } else if (Post("cmd") == "resetfilter") {
                RestoreFilterList();
            }
            return null;
        }
        #pragma warning restore 162, 1998

        // Restore list of filters
        protected bool RestoreFilterList() {
            // Return if not reset filter
            if (Post("cmd") != "resetfilter")
                return false;
            var filter = JsonConvert.DeserializeObject<Dictionary<string, string>>(Post("filter"));
            Command = "search";
            string? sv;

            // Field int_Student_ID
            if (filter?.TryGetValue("x_int_Student_ID", out sv) ?? false) {
                int_Student_ID.AdvancedSearch.SearchValue = sv;
                int_Student_ID.AdvancedSearch.SearchOperator = filter["z_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchCondition = filter["v_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchValue2 = filter["y_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Student_ID"];
                int_Student_ID.AdvancedSearch.Save();
            }

            // Field str_First_Name
            if (filter?.TryGetValue("x_str_First_Name", out sv) ?? false) {
                str_First_Name.AdvancedSearch.SearchValue = sv;
                str_First_Name.AdvancedSearch.SearchOperator = filter["z_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchCondition = filter["v_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchValue2 = filter["y_str_First_Name"];
                str_First_Name.AdvancedSearch.SearchOperator2 = filter["w_str_First_Name"];
                str_First_Name.AdvancedSearch.Save();
            }

            // Field str_Middle_Name
            if (filter?.TryGetValue("x_str_Middle_Name", out sv) ?? false) {
                str_Middle_Name.AdvancedSearch.SearchValue = sv;
                str_Middle_Name.AdvancedSearch.SearchOperator = filter["z_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchCondition = filter["v_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchValue2 = filter["y_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Middle_Name"];
                str_Middle_Name.AdvancedSearch.Save();
            }

            // Field str_Last_Name
            if (filter?.TryGetValue("x_str_Last_Name", out sv) ?? false) {
                str_Last_Name.AdvancedSearch.SearchValue = sv;
                str_Last_Name.AdvancedSearch.SearchOperator = filter["z_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchCondition = filter["v_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchValue2 = filter["y_str_Last_Name"];
                str_Last_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Last_Name"];
                str_Last_Name.AdvancedSearch.Save();
            }

            // Field str_Full_Name
            if (filter?.TryGetValue("x_str_Full_Name", out sv) ?? false) {
                str_Full_Name.AdvancedSearch.SearchValue = sv;
                str_Full_Name.AdvancedSearch.SearchOperator = filter["z_str_Full_Name"];
                str_Full_Name.AdvancedSearch.SearchCondition = filter["v_str_Full_Name"];
                str_Full_Name.AdvancedSearch.SearchValue2 = filter["y_str_Full_Name"];
                str_Full_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Full_Name"];
                str_Full_Name.AdvancedSearch.Save();
            }

            // Field str_Address
            if (filter?.TryGetValue("x_str_Address", out sv) ?? false) {
                str_Address.AdvancedSearch.SearchValue = sv;
                str_Address.AdvancedSearch.SearchOperator = filter["z_str_Address"];
                str_Address.AdvancedSearch.SearchCondition = filter["v_str_Address"];
                str_Address.AdvancedSearch.SearchValue2 = filter["y_str_Address"];
                str_Address.AdvancedSearch.SearchOperator2 = filter["w_str_Address"];
                str_Address.AdvancedSearch.Save();
            }

            // Field str_City
            if (filter?.TryGetValue("x_str_City", out sv) ?? false) {
                str_City.AdvancedSearch.SearchValue = sv;
                str_City.AdvancedSearch.SearchOperator = filter["z_str_City"];
                str_City.AdvancedSearch.SearchCondition = filter["v_str_City"];
                str_City.AdvancedSearch.SearchValue2 = filter["y_str_City"];
                str_City.AdvancedSearch.SearchOperator2 = filter["w_str_City"];
                str_City.AdvancedSearch.Save();
            }

            // Field int_State
            if (filter?.TryGetValue("x_int_State", out sv) ?? false) {
                int_State.AdvancedSearch.SearchValue = sv;
                int_State.AdvancedSearch.SearchOperator = filter["z_int_State"];
                int_State.AdvancedSearch.SearchCondition = filter["v_int_State"];
                int_State.AdvancedSearch.SearchValue2 = filter["y_int_State"];
                int_State.AdvancedSearch.SearchOperator2 = filter["w_int_State"];
                int_State.AdvancedSearch.Save();
            }

            // Field str_Zip
            if (filter?.TryGetValue("x_str_Zip", out sv) ?? false) {
                str_Zip.AdvancedSearch.SearchValue = sv;
                str_Zip.AdvancedSearch.SearchOperator = filter["z_str_Zip"];
                str_Zip.AdvancedSearch.SearchCondition = filter["v_str_Zip"];
                str_Zip.AdvancedSearch.SearchValue2 = filter["y_str_Zip"];
                str_Zip.AdvancedSearch.SearchOperator2 = filter["w_str_Zip"];
                str_Zip.AdvancedSearch.Save();
            }

            // Field date_Hired
            if (filter?.TryGetValue("x_date_Hired", out sv) ?? false) {
                date_Hired.AdvancedSearch.SearchValue = sv;
                date_Hired.AdvancedSearch.SearchOperator = filter["z_date_Hired"];
                date_Hired.AdvancedSearch.SearchCondition = filter["v_date_Hired"];
                date_Hired.AdvancedSearch.SearchValue2 = filter["y_date_Hired"];
                date_Hired.AdvancedSearch.SearchOperator2 = filter["w_date_Hired"];
                date_Hired.AdvancedSearch.Save();
            }

            // Field date_Left
            if (filter?.TryGetValue("x_date_Left", out sv) ?? false) {
                date_Left.AdvancedSearch.SearchValue = sv;
                date_Left.AdvancedSearch.SearchOperator = filter["z_date_Left"];
                date_Left.AdvancedSearch.SearchCondition = filter["v_date_Left"];
                date_Left.AdvancedSearch.SearchValue2 = filter["y_date_Left"];
                date_Left.AdvancedSearch.SearchOperator2 = filter["w_date_Left"];
                date_Left.AdvancedSearch.Save();
            }

            // Field str_CertNumber
            if (filter?.TryGetValue("x_str_CertNumber", out sv) ?? false) {
                str_CertNumber.AdvancedSearch.SearchValue = sv;
                str_CertNumber.AdvancedSearch.SearchOperator = filter["z_str_CertNumber"];
                str_CertNumber.AdvancedSearch.SearchCondition = filter["v_str_CertNumber"];
                str_CertNumber.AdvancedSearch.SearchValue2 = filter["y_str_CertNumber"];
                str_CertNumber.AdvancedSearch.SearchOperator2 = filter["w_str_CertNumber"];
                str_CertNumber.AdvancedSearch.Save();
            }

            // Field date_CertExp
            if (filter?.TryGetValue("x_date_CertExp", out sv) ?? false) {
                date_CertExp.AdvancedSearch.SearchValue = sv;
                date_CertExp.AdvancedSearch.SearchOperator = filter["z_date_CertExp"];
                date_CertExp.AdvancedSearch.SearchCondition = filter["v_date_CertExp"];
                date_CertExp.AdvancedSearch.SearchValue2 = filter["y_date_CertExp"];
                date_CertExp.AdvancedSearch.SearchOperator2 = filter["w_date_CertExp"];
                date_CertExp.AdvancedSearch.Save();
            }

            // Field str_Cell_Phone
            if (filter?.TryGetValue("x_str_Cell_Phone", out sv) ?? false) {
                str_Cell_Phone.AdvancedSearch.SearchValue = sv;
                str_Cell_Phone.AdvancedSearch.SearchOperator = filter["z_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchCondition = filter["v_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.Save();
            }

            // Field str_Home_Phone
            if (filter?.TryGetValue("x_str_Home_Phone", out sv) ?? false) {
                str_Home_Phone.AdvancedSearch.SearchValue = sv;
                str_Home_Phone.AdvancedSearch.SearchOperator = filter["z_str_Home_Phone"];
                str_Home_Phone.AdvancedSearch.SearchCondition = filter["v_str_Home_Phone"];
                str_Home_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Home_Phone"];
                str_Home_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Home_Phone"];
                str_Home_Phone.AdvancedSearch.Save();
            }

            // Field str_Other_Phone
            if (filter?.TryGetValue("x_str_Other_Phone", out sv) ?? false) {
                str_Other_Phone.AdvancedSearch.SearchValue = sv;
                str_Other_Phone.AdvancedSearch.SearchOperator = filter["z_str_Other_Phone"];
                str_Other_Phone.AdvancedSearch.SearchCondition = filter["v_str_Other_Phone"];
                str_Other_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Other_Phone"];
                str_Other_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Other_Phone"];
                str_Other_Phone.AdvancedSearch.Save();
            }

            // Field str_Email
            if (filter?.TryGetValue("x_str_Email", out sv) ?? false) {
                str_Email.AdvancedSearch.SearchValue = sv;
                str_Email.AdvancedSearch.SearchOperator = filter["z_str_Email"];
                str_Email.AdvancedSearch.SearchCondition = filter["v_str_Email"];
                str_Email.AdvancedSearch.SearchValue2 = filter["y_str_Email"];
                str_Email.AdvancedSearch.SearchOperator2 = filter["w_str_Email"];
                str_Email.AdvancedSearch.Save();
            }

            // Field str_Code
            if (filter?.TryGetValue("x_str_Code", out sv) ?? false) {
                str_Code.AdvancedSearch.SearchValue = sv;
                str_Code.AdvancedSearch.SearchOperator = filter["z_str_Code"];
                str_Code.AdvancedSearch.SearchCondition = filter["v_str_Code"];
                str_Code.AdvancedSearch.SearchValue2 = filter["y_str_Code"];
                str_Code.AdvancedSearch.SearchOperator2 = filter["w_str_Code"];
                str_Code.AdvancedSearch.Save();
            }

            // Field str_Username
            if (filter?.TryGetValue("x_str_Username", out sv) ?? false) {
                str_Username.AdvancedSearch.SearchValue = sv;
                str_Username.AdvancedSearch.SearchOperator = filter["z_str_Username"];
                str_Username.AdvancedSearch.SearchCondition = filter["v_str_Username"];
                str_Username.AdvancedSearch.SearchValue2 = filter["y_str_Username"];
                str_Username.AdvancedSearch.SearchOperator2 = filter["w_str_Username"];
                str_Username.AdvancedSearch.Save();
            }

            // Field str_Password
            if (filter?.TryGetValue("x_str_Password", out sv) ?? false) {
                str_Password.AdvancedSearch.SearchValue = sv;
                str_Password.AdvancedSearch.SearchOperator = filter["z_str_Password"];
                str_Password.AdvancedSearch.SearchCondition = filter["v_str_Password"];
                str_Password.AdvancedSearch.SearchValue2 = filter["y_str_Password"];
                str_Password.AdvancedSearch.SearchOperator2 = filter["w_str_Password"];
                str_Password.AdvancedSearch.Save();
            }

            // Field date_Birth_Hijri
            if (filter?.TryGetValue("x_date_Birth_Hijri", out sv) ?? false) {
                date_Birth_Hijri.AdvancedSearch.SearchValue = sv;
                date_Birth_Hijri.AdvancedSearch.SearchOperator = filter["z_date_Birth_Hijri"];
                date_Birth_Hijri.AdvancedSearch.SearchCondition = filter["v_date_Birth_Hijri"];
                date_Birth_Hijri.AdvancedSearch.SearchValue2 = filter["y_date_Birth_Hijri"];
                date_Birth_Hijri.AdvancedSearch.SearchOperator2 = filter["w_date_Birth_Hijri"];
                date_Birth_Hijri.AdvancedSearch.Save();
            }

            // Field date_Birth
            if (filter?.TryGetValue("x_date_Birth", out sv) ?? false) {
                date_Birth.AdvancedSearch.SearchValue = sv;
                date_Birth.AdvancedSearch.SearchOperator = filter["z_date_Birth"];
                date_Birth.AdvancedSearch.SearchCondition = filter["v_date_Birth"];
                date_Birth.AdvancedSearch.SearchValue2 = filter["y_date_Birth"];
                date_Birth.AdvancedSearch.SearchOperator2 = filter["w_date_Birth"];
                date_Birth.AdvancedSearch.Save();
            }

            // Field Hijri_Year
            if (filter?.TryGetValue("x_Hijri_Year", out sv) ?? false) {
                Hijri_Year.AdvancedSearch.SearchValue = sv;
                Hijri_Year.AdvancedSearch.SearchOperator = filter["z_Hijri_Year"];
                Hijri_Year.AdvancedSearch.SearchCondition = filter["v_Hijri_Year"];
                Hijri_Year.AdvancedSearch.SearchValue2 = filter["y_Hijri_Year"];
                Hijri_Year.AdvancedSearch.SearchOperator2 = filter["w_Hijri_Year"];
                Hijri_Year.AdvancedSearch.Save();
            }

            // Field Hijri_Month
            if (filter?.TryGetValue("x_Hijri_Month", out sv) ?? false) {
                Hijri_Month.AdvancedSearch.SearchValue = sv;
                Hijri_Month.AdvancedSearch.SearchOperator = filter["z_Hijri_Month"];
                Hijri_Month.AdvancedSearch.SearchCondition = filter["v_Hijri_Month"];
                Hijri_Month.AdvancedSearch.SearchValue2 = filter["y_Hijri_Month"];
                Hijri_Month.AdvancedSearch.SearchOperator2 = filter["w_Hijri_Month"];
                Hijri_Month.AdvancedSearch.Save();
            }

            // Field Hijri_Day
            if (filter?.TryGetValue("x_Hijri_Day", out sv) ?? false) {
                Hijri_Day.AdvancedSearch.SearchValue = sv;
                Hijri_Day.AdvancedSearch.SearchOperator = filter["z_Hijri_Day"];
                Hijri_Day.AdvancedSearch.SearchCondition = filter["v_Hijri_Day"];
                Hijri_Day.AdvancedSearch.SearchValue2 = filter["y_Hijri_Day"];
                Hijri_Day.AdvancedSearch.SearchOperator2 = filter["w_Hijri_Day"];
                Hijri_Day.AdvancedSearch.Save();
            }

            // Field date_Started
            if (filter?.TryGetValue("x_date_Started", out sv) ?? false) {
                date_Started.AdvancedSearch.SearchValue = sv;
                date_Started.AdvancedSearch.SearchOperator = filter["z_date_Started"];
                date_Started.AdvancedSearch.SearchCondition = filter["v_date_Started"];
                date_Started.AdvancedSearch.SearchValue2 = filter["y_date_Started"];
                date_Started.AdvancedSearch.SearchOperator2 = filter["w_date_Started"];
                date_Started.AdvancedSearch.Save();
            }

            // Field str_DateHired
            if (filter?.TryGetValue("x_str_DateHired", out sv) ?? false) {
                str_DateHired.AdvancedSearch.SearchValue = sv;
                str_DateHired.AdvancedSearch.SearchOperator = filter["z_str_DateHired"];
                str_DateHired.AdvancedSearch.SearchCondition = filter["v_str_DateHired"];
                str_DateHired.AdvancedSearch.SearchValue2 = filter["y_str_DateHired"];
                str_DateHired.AdvancedSearch.SearchOperator2 = filter["w_str_DateHired"];
                str_DateHired.AdvancedSearch.Save();
            }

            // Field str_DateLeft
            if (filter?.TryGetValue("x_str_DateLeft", out sv) ?? false) {
                str_DateLeft.AdvancedSearch.SearchValue = sv;
                str_DateLeft.AdvancedSearch.SearchOperator = filter["z_str_DateLeft"];
                str_DateLeft.AdvancedSearch.SearchCondition = filter["v_str_DateLeft"];
                str_DateLeft.AdvancedSearch.SearchValue2 = filter["y_str_DateLeft"];
                str_DateLeft.AdvancedSearch.SearchOperator2 = filter["w_str_DateLeft"];
                str_DateLeft.AdvancedSearch.Save();
            }

            // Field str_Emergency_Contact_Name
            if (filter?.TryGetValue("x_str_Emergency_Contact_Name", out sv) ?? false) {
                str_Emergency_Contact_Name.AdvancedSearch.SearchValue = sv;
                str_Emergency_Contact_Name.AdvancedSearch.SearchOperator = filter["z_str_Emergency_Contact_Name"];
                str_Emergency_Contact_Name.AdvancedSearch.SearchCondition = filter["v_str_Emergency_Contact_Name"];
                str_Emergency_Contact_Name.AdvancedSearch.SearchValue2 = filter["y_str_Emergency_Contact_Name"];
                str_Emergency_Contact_Name.AdvancedSearch.SearchOperator2 = filter["w_str_Emergency_Contact_Name"];
                str_Emergency_Contact_Name.AdvancedSearch.Save();
            }

            // Field str_Emergency_Contact_Phone
            if (filter?.TryGetValue("x_str_Emergency_Contact_Phone", out sv) ?? false) {
                str_Emergency_Contact_Phone.AdvancedSearch.SearchValue = sv;
                str_Emergency_Contact_Phone.AdvancedSearch.SearchOperator = filter["z_str_Emergency_Contact_Phone"];
                str_Emergency_Contact_Phone.AdvancedSearch.SearchCondition = filter["v_str_Emergency_Contact_Phone"];
                str_Emergency_Contact_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Emergency_Contact_Phone"];
                str_Emergency_Contact_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Emergency_Contact_Phone"];
                str_Emergency_Contact_Phone.AdvancedSearch.Save();
            }

            // Field str_Emergency_Contact_Relation
            if (filter?.TryGetValue("x_str_Emergency_Contact_Relation", out sv) ?? false) {
                str_Emergency_Contact_Relation.AdvancedSearch.SearchValue = sv;
                str_Emergency_Contact_Relation.AdvancedSearch.SearchOperator = filter["z_str_Emergency_Contact_Relation"];
                str_Emergency_Contact_Relation.AdvancedSearch.SearchCondition = filter["v_str_Emergency_Contact_Relation"];
                str_Emergency_Contact_Relation.AdvancedSearch.SearchValue2 = filter["y_str_Emergency_Contact_Relation"];
                str_Emergency_Contact_Relation.AdvancedSearch.SearchOperator2 = filter["w_str_Emergency_Contact_Relation"];
                str_Emergency_Contact_Relation.AdvancedSearch.Save();
            }

            // Field str_Notes
            if (filter?.TryGetValue("x_str_Notes", out sv) ?? false) {
                str_Notes.AdvancedSearch.SearchValue = sv;
                str_Notes.AdvancedSearch.SearchOperator = filter["z_str_Notes"];
                str_Notes.AdvancedSearch.SearchCondition = filter["v_str_Notes"];
                str_Notes.AdvancedSearch.SearchValue2 = filter["y_str_Notes"];
                str_Notes.AdvancedSearch.SearchOperator2 = filter["w_str_Notes"];
                str_Notes.AdvancedSearch.Save();
            }

            // Field int_ClassType
            if (filter?.TryGetValue("x_int_ClassType", out sv) ?? false) {
                int_ClassType.AdvancedSearch.SearchValue = sv;
                int_ClassType.AdvancedSearch.SearchOperator = filter["z_int_ClassType"];
                int_ClassType.AdvancedSearch.SearchCondition = filter["v_int_ClassType"];
                int_ClassType.AdvancedSearch.SearchValue2 = filter["y_int_ClassType"];
                int_ClassType.AdvancedSearch.SearchOperator2 = filter["w_int_ClassType"];
                int_ClassType.AdvancedSearch.Save();
            }

            // Field str_ZipCodes
            if (filter?.TryGetValue("x_str_ZipCodes", out sv) ?? false) {
                str_ZipCodes.AdvancedSearch.SearchValue = sv;
                str_ZipCodes.AdvancedSearch.SearchOperator = filter["z_str_ZipCodes"];
                str_ZipCodes.AdvancedSearch.SearchCondition = filter["v_str_ZipCodes"];
                str_ZipCodes.AdvancedSearch.SearchValue2 = filter["y_str_ZipCodes"];
                str_ZipCodes.AdvancedSearch.SearchOperator2 = filter["w_str_ZipCodes"];
                str_ZipCodes.AdvancedSearch.Save();
            }

            // Field int_VehicleAssigned
            if (filter?.TryGetValue("x_int_VehicleAssigned", out sv) ?? false) {
                int_VehicleAssigned.AdvancedSearch.SearchValue = sv;
                int_VehicleAssigned.AdvancedSearch.SearchOperator = filter["z_int_VehicleAssigned"];
                int_VehicleAssigned.AdvancedSearch.SearchCondition = filter["v_int_VehicleAssigned"];
                int_VehicleAssigned.AdvancedSearch.SearchValue2 = filter["y_int_VehicleAssigned"];
                int_VehicleAssigned.AdvancedSearch.SearchOperator2 = filter["w_int_VehicleAssigned"];
                int_VehicleAssigned.AdvancedSearch.Save();
            }

            // Field int_Status
            if (filter?.TryGetValue("x_int_Status", out sv) ?? false) {
                int_Status.AdvancedSearch.SearchValue = sv;
                int_Status.AdvancedSearch.SearchOperator = filter["z_int_Status"];
                int_Status.AdvancedSearch.SearchCondition = filter["v_int_Status"];
                int_Status.AdvancedSearch.SearchValue2 = filter["y_int_Status"];
                int_Status.AdvancedSearch.SearchOperator2 = filter["w_int_Status"];
                int_Status.AdvancedSearch.Save();
            }

            // Field int_Type
            if (filter?.TryGetValue("x_int_Type", out sv) ?? false) {
                int_Type.AdvancedSearch.SearchValue = sv;
                int_Type.AdvancedSearch.SearchOperator = filter["z_int_Type"];
                int_Type.AdvancedSearch.SearchCondition = filter["v_int_Type"];
                int_Type.AdvancedSearch.SearchValue2 = filter["y_int_Type"];
                int_Type.AdvancedSearch.SearchOperator2 = filter["w_int_Type"];
                int_Type.AdvancedSearch.Save();
            }

            // Field int_Location
            if (filter?.TryGetValue("x_int_Location", out sv) ?? false) {
                int_Location.AdvancedSearch.SearchValue = sv;
                int_Location.AdvancedSearch.SearchOperator = filter["z_int_Location"];
                int_Location.AdvancedSearch.SearchCondition = filter["v_int_Location"];
                int_Location.AdvancedSearch.SearchValue2 = filter["y_int_Location"];
                int_Location.AdvancedSearch.SearchOperator2 = filter["w_int_Location"];
                int_Location.AdvancedSearch.Save();
            }

            // Field date_Created
            if (filter?.TryGetValue("x_date_Created", out sv) ?? false) {
                date_Created.AdvancedSearch.SearchValue = sv;
                date_Created.AdvancedSearch.SearchOperator = filter["z_date_Created"];
                date_Created.AdvancedSearch.SearchCondition = filter["v_date_Created"];
                date_Created.AdvancedSearch.SearchValue2 = filter["y_date_Created"];
                date_Created.AdvancedSearch.SearchOperator2 = filter["w_date_Created"];
                date_Created.AdvancedSearch.Save();
            }

            // Field date_Modified
            if (filter?.TryGetValue("x_date_Modified", out sv) ?? false) {
                date_Modified.AdvancedSearch.SearchValue = sv;
                date_Modified.AdvancedSearch.SearchOperator = filter["z_date_Modified"];
                date_Modified.AdvancedSearch.SearchCondition = filter["v_date_Modified"];
                date_Modified.AdvancedSearch.SearchValue2 = filter["y_date_Modified"];
                date_Modified.AdvancedSearch.SearchOperator2 = filter["w_date_Modified"];
                date_Modified.AdvancedSearch.Save();
            }

            // Field int_Created_By
            if (filter?.TryGetValue("x_int_Created_By", out sv) ?? false) {
                int_Created_By.AdvancedSearch.SearchValue = sv;
                int_Created_By.AdvancedSearch.SearchOperator = filter["z_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchCondition = filter["v_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchValue2 = filter["y_int_Created_By"];
                int_Created_By.AdvancedSearch.SearchOperator2 = filter["w_int_Created_By"];
                int_Created_By.AdvancedSearch.Save();
            }

            // Field int_Modified_By
            if (filter?.TryGetValue("x_int_Modified_By", out sv) ?? false) {
                int_Modified_By.AdvancedSearch.SearchValue = sv;
                int_Modified_By.AdvancedSearch.SearchOperator = filter["z_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchCondition = filter["v_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchValue2 = filter["y_int_Modified_By"];
                int_Modified_By.AdvancedSearch.SearchOperator2 = filter["w_int_Modified_By"];
                int_Modified_By.AdvancedSearch.Save();
            }

            // Field bit_IsDeleted
            if (filter?.TryGetValue("x_bit_IsDeleted", out sv) ?? false) {
                bit_IsDeleted.AdvancedSearch.SearchValue = sv;
                bit_IsDeleted.AdvancedSearch.SearchOperator = filter["z_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchCondition = filter["v_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchValue2 = filter["y_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.SearchOperator2 = filter["w_bit_IsDeleted"];
                bit_IsDeleted.AdvancedSearch.Save();
            }

            // Field str_InstPermitNo
            if (filter?.TryGetValue("x_str_InstPermitNo", out sv) ?? false) {
                str_InstPermitNo.AdvancedSearch.SearchValue = sv;
                str_InstPermitNo.AdvancedSearch.SearchOperator = filter["z_str_InstPermitNo"];
                str_InstPermitNo.AdvancedSearch.SearchCondition = filter["v_str_InstPermitNo"];
                str_InstPermitNo.AdvancedSearch.SearchValue2 = filter["y_str_InstPermitNo"];
                str_InstPermitNo.AdvancedSearch.SearchOperator2 = filter["w_str_InstPermitNo"];
                str_InstPermitNo.AdvancedSearch.Save();
            }

            // Field date_PermitExpiration
            if (filter?.TryGetValue("x_date_PermitExpiration", out sv) ?? false) {
                date_PermitExpiration.AdvancedSearch.SearchValue = sv;
                date_PermitExpiration.AdvancedSearch.SearchOperator = filter["z_date_PermitExpiration"];
                date_PermitExpiration.AdvancedSearch.SearchCondition = filter["v_date_PermitExpiration"];
                date_PermitExpiration.AdvancedSearch.SearchValue2 = filter["y_date_PermitExpiration"];
                date_PermitExpiration.AdvancedSearch.SearchOperator2 = filter["w_date_PermitExpiration"];
                date_PermitExpiration.AdvancedSearch.Save();
            }

            // Field date_InCarPermitIssue
            if (filter?.TryGetValue("x_date_InCarPermitIssue", out sv) ?? false) {
                date_InCarPermitIssue.AdvancedSearch.SearchValue = sv;
                date_InCarPermitIssue.AdvancedSearch.SearchOperator = filter["z_date_InCarPermitIssue"];
                date_InCarPermitIssue.AdvancedSearch.SearchCondition = filter["v_date_InCarPermitIssue"];
                date_InCarPermitIssue.AdvancedSearch.SearchValue2 = filter["y_date_InCarPermitIssue"];
                date_InCarPermitIssue.AdvancedSearch.SearchOperator2 = filter["w_date_InCarPermitIssue"];
                date_InCarPermitIssue.AdvancedSearch.Save();
            }

            // Field str_InClassPermitNo
            if (filter?.TryGetValue("x_str_InClassPermitNo", out sv) ?? false) {
                str_InClassPermitNo.AdvancedSearch.SearchValue = sv;
                str_InClassPermitNo.AdvancedSearch.SearchOperator = filter["z_str_InClassPermitNo"];
                str_InClassPermitNo.AdvancedSearch.SearchCondition = filter["v_str_InClassPermitNo"];
                str_InClassPermitNo.AdvancedSearch.SearchValue2 = filter["y_str_InClassPermitNo"];
                str_InClassPermitNo.AdvancedSearch.SearchOperator2 = filter["w_str_InClassPermitNo"];
                str_InClassPermitNo.AdvancedSearch.Save();
            }

            // Field date_InClassPermitIssue
            if (filter?.TryGetValue("x_date_InClassPermitIssue", out sv) ?? false) {
                date_InClassPermitIssue.AdvancedSearch.SearchValue = sv;
                date_InClassPermitIssue.AdvancedSearch.SearchOperator = filter["z_date_InClassPermitIssue"];
                date_InClassPermitIssue.AdvancedSearch.SearchCondition = filter["v_date_InClassPermitIssue"];
                date_InClassPermitIssue.AdvancedSearch.SearchValue2 = filter["y_date_InClassPermitIssue"];
                date_InClassPermitIssue.AdvancedSearch.SearchOperator2 = filter["w_date_InClassPermitIssue"];
                date_InClassPermitIssue.AdvancedSearch.Save();
            }

            // Field instructor_caption
            if (filter?.TryGetValue("x_instructor_caption", out sv) ?? false) {
                instructor_caption.AdvancedSearch.SearchValue = sv;
                instructor_caption.AdvancedSearch.SearchOperator = filter["z_instructor_caption"];
                instructor_caption.AdvancedSearch.SearchCondition = filter["v_instructor_caption"];
                instructor_caption.AdvancedSearch.SearchValue2 = filter["y_instructor_caption"];
                instructor_caption.AdvancedSearch.SearchOperator2 = filter["w_instructor_caption"];
                instructor_caption.AdvancedSearch.Save();
            }

            // Field str_LicType
            if (filter?.TryGetValue("x_str_LicType", out sv) ?? false) {
                str_LicType.AdvancedSearch.SearchValue = sv;
                str_LicType.AdvancedSearch.SearchOperator = filter["z_str_LicType"];
                str_LicType.AdvancedSearch.SearchCondition = filter["v_str_LicType"];
                str_LicType.AdvancedSearch.SearchValue2 = filter["y_str_LicType"];
                str_LicType.AdvancedSearch.SearchOperator2 = filter["w_str_LicType"];
                str_LicType.AdvancedSearch.Save();
            }

            // Field int_Order
            if (filter?.TryGetValue("x_int_Order", out sv) ?? false) {
                int_Order.AdvancedSearch.SearchValue = sv;
                int_Order.AdvancedSearch.SearchOperator = filter["z_int_Order"];
                int_Order.AdvancedSearch.SearchCondition = filter["v_int_Order"];
                int_Order.AdvancedSearch.SearchValue2 = filter["y_int_Order"];
                int_Order.AdvancedSearch.SearchOperator2 = filter["w_int_Order"];
                int_Order.AdvancedSearch.Save();
            }

            // Field str_InstLicenceDate
            if (filter?.TryGetValue("x_str_InstLicenceDate", out sv) ?? false) {
                str_InstLicenceDate.AdvancedSearch.SearchValue = sv;
                str_InstLicenceDate.AdvancedSearch.SearchOperator = filter["z_str_InstLicenceDate"];
                str_InstLicenceDate.AdvancedSearch.SearchCondition = filter["v_str_InstLicenceDate"];
                str_InstLicenceDate.AdvancedSearch.SearchValue2 = filter["y_str_InstLicenceDate"];
                str_InstLicenceDate.AdvancedSearch.SearchOperator2 = filter["w_str_InstLicenceDate"];
                str_InstLicenceDate.AdvancedSearch.Save();
            }

            // Field str_DLNum
            if (filter?.TryGetValue("x_str_DLNum", out sv) ?? false) {
                str_DLNum.AdvancedSearch.SearchValue = sv;
                str_DLNum.AdvancedSearch.SearchOperator = filter["z_str_DLNum"];
                str_DLNum.AdvancedSearch.SearchCondition = filter["v_str_DLNum"];
                str_DLNum.AdvancedSearch.SearchValue2 = filter["y_str_DLNum"];
                str_DLNum.AdvancedSearch.SearchOperator2 = filter["w_str_DLNum"];
                str_DLNum.AdvancedSearch.Save();
            }

            // Field str_DLExp
            if (filter?.TryGetValue("x_str_DLExp", out sv) ?? false) {
                str_DLExp.AdvancedSearch.SearchValue = sv;
                str_DLExp.AdvancedSearch.SearchOperator = filter["z_str_DLExp"];
                str_DLExp.AdvancedSearch.SearchCondition = filter["v_str_DLExp"];
                str_DLExp.AdvancedSearch.SearchValue2 = filter["y_str_DLExp"];
                str_DLExp.AdvancedSearch.SearchOperator2 = filter["w_str_DLExp"];
                str_DLExp.AdvancedSearch.Save();
            }

            // Field bit_appointmentColor
            if (filter?.TryGetValue("x_bit_appointmentColor", out sv) ?? false) {
                bit_appointmentColor.AdvancedSearch.SearchValue = sv;
                bit_appointmentColor.AdvancedSearch.SearchOperator = filter["z_bit_appointmentColor"];
                bit_appointmentColor.AdvancedSearch.SearchCondition = filter["v_bit_appointmentColor"];
                bit_appointmentColor.AdvancedSearch.SearchValue2 = filter["y_bit_appointmentColor"];
                bit_appointmentColor.AdvancedSearch.SearchOperator2 = filter["w_bit_appointmentColor"];
                bit_appointmentColor.AdvancedSearch.Save();
            }

            // Field str_appointmentColorCode
            if (filter?.TryGetValue("x_str_appointmentColorCode", out sv) ?? false) {
                str_appointmentColorCode.AdvancedSearch.SearchValue = sv;
                str_appointmentColorCode.AdvancedSearch.SearchOperator = filter["z_str_appointmentColorCode"];
                str_appointmentColorCode.AdvancedSearch.SearchCondition = filter["v_str_appointmentColorCode"];
                str_appointmentColorCode.AdvancedSearch.SearchValue2 = filter["y_str_appointmentColorCode"];
                str_appointmentColorCode.AdvancedSearch.SearchOperator2 = filter["w_str_appointmentColorCode"];
                str_appointmentColorCode.AdvancedSearch.Save();
            }

            // Field bit_IsSuperAdmin
            if (filter?.TryGetValue("x_bit_IsSuperAdmin", out sv) ?? false) {
                bit_IsSuperAdmin.AdvancedSearch.SearchValue = sv;
                bit_IsSuperAdmin.AdvancedSearch.SearchOperator = filter["z_bit_IsSuperAdmin"];
                bit_IsSuperAdmin.AdvancedSearch.SearchCondition = filter["v_bit_IsSuperAdmin"];
                bit_IsSuperAdmin.AdvancedSearch.SearchValue2 = filter["y_bit_IsSuperAdmin"];
                bit_IsSuperAdmin.AdvancedSearch.SearchOperator2 = filter["w_bit_IsSuperAdmin"];
                bit_IsSuperAdmin.AdvancedSearch.Save();
            }

            // Field IsDistanceBasedScheduling
            if (filter?.TryGetValue("x_IsDistanceBasedScheduling", out sv) ?? false) {
                IsDistanceBasedScheduling.AdvancedSearch.SearchValue = sv;
                IsDistanceBasedScheduling.AdvancedSearch.SearchOperator = filter["z_IsDistanceBasedScheduling"];
                IsDistanceBasedScheduling.AdvancedSearch.SearchCondition = filter["v_IsDistanceBasedScheduling"];
                IsDistanceBasedScheduling.AdvancedSearch.SearchValue2 = filter["y_IsDistanceBasedScheduling"];
                IsDistanceBasedScheduling.AdvancedSearch.SearchOperator2 = filter["w_IsDistanceBasedScheduling"];
                IsDistanceBasedScheduling.AdvancedSearch.Save();
            }

            // Field str_Package_Code
            if (filter?.TryGetValue("x_str_Package_Code", out sv) ?? false) {
                str_Package_Code.AdvancedSearch.SearchValue = sv;
                str_Package_Code.AdvancedSearch.SearchOperator = filter["z_str_Package_Code"];
                str_Package_Code.AdvancedSearch.SearchCondition = filter["v_str_Package_Code"];
                str_Package_Code.AdvancedSearch.SearchValue2 = filter["y_str_Package_Code"];
                str_Package_Code.AdvancedSearch.SearchOperator2 = filter["w_str_Package_Code"];
                str_Package_Code.AdvancedSearch.Save();
            }

            // Field str_NationalID_Iqama
            if (filter?.TryGetValue("x_str_NationalID_Iqama", out sv) ?? false) {
                str_NationalID_Iqama.AdvancedSearch.SearchValue = sv;
                str_NationalID_Iqama.AdvancedSearch.SearchOperator = filter["z_str_NationalID_Iqama"];
                str_NationalID_Iqama.AdvancedSearch.SearchCondition = filter["v_str_NationalID_Iqama"];
                str_NationalID_Iqama.AdvancedSearch.SearchValue2 = filter["y_str_NationalID_Iqama"];
                str_NationalID_Iqama.AdvancedSearch.SearchOperator2 = filter["w_str_NationalID_Iqama"];
                str_NationalID_Iqama.AdvancedSearch.Save();
            }

            // Field NationalID
            if (filter?.TryGetValue("x_NationalID", out sv) ?? false) {
                NationalID.AdvancedSearch.SearchValue = sv;
                NationalID.AdvancedSearch.SearchOperator = filter["z_NationalID"];
                NationalID.AdvancedSearch.SearchCondition = filter["v_NationalID"];
                NationalID.AdvancedSearch.SearchValue2 = filter["y_NationalID"];
                NationalID.AdvancedSearch.SearchOperator2 = filter["w_NationalID"];
                NationalID.AdvancedSearch.Save();
            }

            // Field int_RoadDistanceCoverage
            if (filter?.TryGetValue("x_int_RoadDistanceCoverage", out sv) ?? false) {
                int_RoadDistanceCoverage.AdvancedSearch.SearchValue = sv;
                int_RoadDistanceCoverage.AdvancedSearch.SearchOperator = filter["z_int_RoadDistanceCoverage"];
                int_RoadDistanceCoverage.AdvancedSearch.SearchCondition = filter["v_int_RoadDistanceCoverage"];
                int_RoadDistanceCoverage.AdvancedSearch.SearchValue2 = filter["y_int_RoadDistanceCoverage"];
                int_RoadDistanceCoverage.AdvancedSearch.SearchOperator2 = filter["w_int_RoadDistanceCoverage"];
                int_RoadDistanceCoverage.AdvancedSearch.Save();
            }

            // Field str_Badge
            if (filter?.TryGetValue("x_str_Badge", out sv) ?? false) {
                str_Badge.AdvancedSearch.SearchValue = sv;
                str_Badge.AdvancedSearch.SearchOperator = filter["z_str_Badge"];
                str_Badge.AdvancedSearch.SearchCondition = filter["v_str_Badge"];
                str_Badge.AdvancedSearch.SearchValue2 = filter["y_str_Badge"];
                str_Badge.AdvancedSearch.SearchOperator2 = filter["w_str_Badge"];
                str_Badge.AdvancedSearch.Save();
            }

            // Field strZoomHostUrl
            if (filter?.TryGetValue("x_strZoomHostUrl", out sv) ?? false) {
                strZoomHostUrl.AdvancedSearch.SearchValue = sv;
                strZoomHostUrl.AdvancedSearch.SearchOperator = filter["z_strZoomHostUrl"];
                strZoomHostUrl.AdvancedSearch.SearchCondition = filter["v_strZoomHostUrl"];
                strZoomHostUrl.AdvancedSearch.SearchValue2 = filter["y_strZoomHostUrl"];
                strZoomHostUrl.AdvancedSearch.SearchOperator2 = filter["w_strZoomHostUrl"];
                strZoomHostUrl.AdvancedSearch.Save();
            }

            // Field strZoomUserUrl
            if (filter?.TryGetValue("x_strZoomUserUrl", out sv) ?? false) {
                strZoomUserUrl.AdvancedSearch.SearchValue = sv;
                strZoomUserUrl.AdvancedSearch.SearchOperator = filter["z_strZoomUserUrl"];
                strZoomUserUrl.AdvancedSearch.SearchCondition = filter["v_strZoomUserUrl"];
                strZoomUserUrl.AdvancedSearch.SearchValue2 = filter["y_strZoomUserUrl"];
                strZoomUserUrl.AdvancedSearch.SearchOperator2 = filter["w_strZoomUserUrl"];
                strZoomUserUrl.AdvancedSearch.Save();
            }

            // Field str_VehicleType
            if (filter?.TryGetValue("x_str_VehicleType", out sv) ?? false) {
                str_VehicleType.AdvancedSearch.SearchValue = sv;
                str_VehicleType.AdvancedSearch.SearchOperator = filter["z_str_VehicleType"];
                str_VehicleType.AdvancedSearch.SearchCondition = filter["v_str_VehicleType"];
                str_VehicleType.AdvancedSearch.SearchValue2 = filter["y_str_VehicleType"];
                str_VehicleType.AdvancedSearch.SearchOperator2 = filter["w_str_VehicleType"];
                str_VehicleType.AdvancedSearch.Save();
            }

            // Field ProfilePicturePath
            if (filter?.TryGetValue("x_ProfilePicturePath", out sv) ?? false) {
                ProfilePicturePath.AdvancedSearch.SearchValue = sv;
                ProfilePicturePath.AdvancedSearch.SearchOperator = filter["z_ProfilePicturePath"];
                ProfilePicturePath.AdvancedSearch.SearchCondition = filter["v_ProfilePicturePath"];
                ProfilePicturePath.AdvancedSearch.SearchValue2 = filter["y_ProfilePicturePath"];
                ProfilePicturePath.AdvancedSearch.SearchOperator2 = filter["w_ProfilePicturePath"];
                ProfilePicturePath.AdvancedSearch.Save();
            }

            // Field Institution
            if (filter?.TryGetValue("x_Institution", out sv) ?? false) {
                Institution.AdvancedSearch.SearchValue = sv;
                Institution.AdvancedSearch.SearchOperator = filter["z_Institution"];
                Institution.AdvancedSearch.SearchCondition = filter["v_Institution"];
                Institution.AdvancedSearch.SearchValue2 = filter["y_Institution"];
                Institution.AdvancedSearch.SearchOperator2 = filter["w_Institution"];
                Institution.AdvancedSearch.Save();
            }

            // Field IsDrivingexperience
            if (filter?.TryGetValue("x_IsDrivingexperience", out sv) ?? false) {
                IsDrivingexperience.AdvancedSearch.SearchValue = sv;
                IsDrivingexperience.AdvancedSearch.SearchOperator = filter["z_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchCondition = filter["v_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchValue2 = filter["y_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchOperator2 = filter["w_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.Save();
            }

            // Field intDrivinglicenseType
            if (filter?.TryGetValue("x_intDrivinglicenseType", out sv) ?? false) {
                intDrivinglicenseType.AdvancedSearch.SearchValue = sv;
                intDrivinglicenseType.AdvancedSearch.SearchOperator = filter["z_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchCondition = filter["v_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchValue2 = filter["y_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchOperator2 = filter["w_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.Save();
            }

            // Field AbsherApptNbr
            if (filter?.TryGetValue("x_AbsherApptNbr", out sv) ?? false) {
                AbsherApptNbr.AdvancedSearch.SearchValue = sv;
                AbsherApptNbr.AdvancedSearch.SearchOperator = filter["z_AbsherApptNbr"];
                AbsherApptNbr.AdvancedSearch.SearchCondition = filter["v_AbsherApptNbr"];
                AbsherApptNbr.AdvancedSearch.SearchValue2 = filter["y_AbsherApptNbr"];
                AbsherApptNbr.AdvancedSearch.SearchOperator2 = filter["w_AbsherApptNbr"];
                AbsherApptNbr.AdvancedSearch.Save();
            }

            // Field Absherphoto
            if (filter?.TryGetValue("x_Absherphoto", out sv) ?? false) {
                Absherphoto.AdvancedSearch.SearchValue = sv;
                Absherphoto.AdvancedSearch.SearchOperator = filter["z_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchCondition = filter["v_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchValue2 = filter["y_Absherphoto"];
                Absherphoto.AdvancedSearch.SearchOperator2 = filter["w_Absherphoto"];
                Absherphoto.AdvancedSearch.Save();
            }

            // Field Fingerprint
            if (filter?.TryGetValue("x_Fingerprint", out sv) ?? false) {
                Fingerprint.AdvancedSearch.SearchValue = sv;
                Fingerprint.AdvancedSearch.SearchOperator = filter["z_Fingerprint"];
                Fingerprint.AdvancedSearch.SearchCondition = filter["v_Fingerprint"];
                Fingerprint.AdvancedSearch.SearchValue2 = filter["y_Fingerprint"];
                Fingerprint.AdvancedSearch.SearchOperator2 = filter["w_Fingerprint"];
                Fingerprint.AdvancedSearch.Save();
            }

            // Field ProfileField
            if (filter?.TryGetValue("x_ProfileField", out sv) ?? false) {
                ProfileField.AdvancedSearch.SearchValue = sv;
                ProfileField.AdvancedSearch.SearchOperator = filter["z_ProfileField"];
                ProfileField.AdvancedSearch.SearchCondition = filter["v_ProfileField"];
                ProfileField.AdvancedSearch.SearchValue2 = filter["y_ProfileField"];
                ProfileField.AdvancedSearch.SearchOperator2 = filter["w_ProfileField"];
                ProfileField.AdvancedSearch.Save();
            }

            // Field UserlevelID
            if (filter?.TryGetValue("x_UserlevelID", out sv) ?? false) {
                UserlevelID.AdvancedSearch.SearchValue = sv;
                UserlevelID.AdvancedSearch.SearchOperator = filter["z_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchCondition = filter["v_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchValue2 = filter["y_UserlevelID"];
                UserlevelID.AdvancedSearch.SearchOperator2 = filter["w_UserlevelID"];
                UserlevelID.AdvancedSearch.Save();
            }

            // Field Parent_Username
            if (filter?.TryGetValue("x_Parent_Username", out sv) ?? false) {
                Parent_Username.AdvancedSearch.SearchValue = sv;
                Parent_Username.AdvancedSearch.SearchOperator = filter["z_Parent_Username"];
                Parent_Username.AdvancedSearch.SearchCondition = filter["v_Parent_Username"];
                Parent_Username.AdvancedSearch.SearchValue2 = filter["y_Parent_Username"];
                Parent_Username.AdvancedSearch.SearchOperator2 = filter["w_Parent_Username"];
                Parent_Username.AdvancedSearch.Save();
            }

            // Field Activated
            if (filter?.TryGetValue("x_Activated", out sv) ?? false) {
                Activated.AdvancedSearch.SearchValue = sv;
                Activated.AdvancedSearch.SearchOperator = filter["z_Activated"];
                Activated.AdvancedSearch.SearchCondition = filter["v_Activated"];
                Activated.AdvancedSearch.SearchValue2 = filter["y_Activated"];
                Activated.AdvancedSearch.SearchOperator2 = filter["w_Activated"];
                Activated.AdvancedSearch.Save();
            }

            // Field int_Nationality
            if (filter?.TryGetValue("x_int_Nationality", out sv) ?? false) {
                int_Nationality.AdvancedSearch.SearchValue = sv;
                int_Nationality.AdvancedSearch.SearchOperator = filter["z_int_Nationality"];
                int_Nationality.AdvancedSearch.SearchCondition = filter["v_int_Nationality"];
                int_Nationality.AdvancedSearch.SearchValue2 = filter["y_int_Nationality"];
                int_Nationality.AdvancedSearch.SearchOperator2 = filter["w_int_Nationality"];
                int_Nationality.AdvancedSearch.Save();
            }

            // Field User_Role
            if (filter?.TryGetValue("x_User_Role", out sv) ?? false) {
                User_Role.AdvancedSearch.SearchValue = sv;
                User_Role.AdvancedSearch.SearchOperator = filter["z_User_Role"];
                User_Role.AdvancedSearch.SearchCondition = filter["v_User_Role"];
                User_Role.AdvancedSearch.SearchValue2 = filter["y_User_Role"];
                User_Role.AdvancedSearch.SearchOperator2 = filter["w_User_Role"];
                User_Role.AdvancedSearch.Save();
            }

            // Field int_Staff_Id
            if (filter?.TryGetValue("x_int_Staff_Id", out sv) ?? false) {
                int_Staff_Id.AdvancedSearch.SearchValue = sv;
                int_Staff_Id.AdvancedSearch.SearchOperator = filter["z_int_Staff_Id"];
                int_Staff_Id.AdvancedSearch.SearchCondition = filter["v_int_Staff_Id"];
                int_Staff_Id.AdvancedSearch.SearchValue2 = filter["y_int_Staff_Id"];
                int_Staff_Id.AdvancedSearch.SearchOperator2 = filter["w_int_Staff_Id"];
                int_Staff_Id.AdvancedSearch.Save();
            }
            if (filter?.TryGetValue(Config.TableBasicSearch, out string? keyword) ?? false)
                BasicSearch.SessionKeyword = keyword;
            if (filter?.TryGetValue(Config.TableBasicSearchType, out string? type) ?? false)
                BasicSearch.SessionType = type;
            return true;
        }

        // Advanced search WHERE clause based on QueryString
        public string AdvancedSearchWhere(bool def = false) {
            string where = "";
            if (!Security.CanSearch)
                return "";
            BuildSearchSql(ref where, int_Student_ID, def, false); // int_Student_ID
            BuildSearchSql(ref where, str_First_Name, def, false); // str_First_Name
            BuildSearchSql(ref where, str_Middle_Name, def, false); // str_Middle_Name
            BuildSearchSql(ref where, str_Last_Name, def, false); // str_Last_Name
            BuildSearchSql(ref where, str_Full_Name, def, false); // str_Full_Name
            BuildSearchSql(ref where, str_Address, def, false); // str_Address
            BuildSearchSql(ref where, str_City, def, false); // str_City
            BuildSearchSql(ref where, int_State, def, false); // int_State
            BuildSearchSql(ref where, str_Zip, def, false); // str_Zip
            BuildSearchSql(ref where, date_Hired, def, false); // date_Hired
            BuildSearchSql(ref where, date_Left, def, false); // date_Left
            BuildSearchSql(ref where, str_CertNumber, def, false); // str_CertNumber
            BuildSearchSql(ref where, date_CertExp, def, false); // date_CertExp
            BuildSearchSql(ref where, str_Cell_Phone, def, false); // str_Cell_Phone
            BuildSearchSql(ref where, str_Home_Phone, def, false); // str_Home_Phone
            BuildSearchSql(ref where, str_Other_Phone, def, false); // str_Other_Phone
            BuildSearchSql(ref where, str_Email, def, false); // str_Email
            BuildSearchSql(ref where, str_Code, def, false); // str_Code
            BuildSearchSql(ref where, str_Username, def, false); // str_Username
            BuildSearchSql(ref where, str_Password, def, false); // str_Password
            BuildSearchSql(ref where, date_Birth_Hijri, def, false); // date_Birth_Hijri
            BuildSearchSql(ref where, date_Birth, def, false); // date_Birth
            BuildSearchSql(ref where, Hijri_Year, def, false); // Hijri_Year
            BuildSearchSql(ref where, Hijri_Month, def, false); // Hijri_Month
            BuildSearchSql(ref where, Hijri_Day, def, false); // Hijri_Day
            BuildSearchSql(ref where, date_Started, def, false); // date_Started
            BuildSearchSql(ref where, str_DateHired, def, false); // str_DateHired
            BuildSearchSql(ref where, str_DateLeft, def, false); // str_DateLeft
            BuildSearchSql(ref where, str_Emergency_Contact_Name, def, false); // str_Emergency_Contact_Name
            BuildSearchSql(ref where, str_Emergency_Contact_Phone, def, false); // str_Emergency_Contact_Phone
            BuildSearchSql(ref where, str_Emergency_Contact_Relation, def, false); // str_Emergency_Contact_Relation
            BuildSearchSql(ref where, str_Notes, def, false); // str_Notes
            BuildSearchSql(ref where, int_ClassType, def, false); // int_ClassType
            BuildSearchSql(ref where, str_ZipCodes, def, false); // str_ZipCodes
            BuildSearchSql(ref where, int_VehicleAssigned, def, false); // int_VehicleAssigned
            BuildSearchSql(ref where, int_Status, def, false); // int_Status
            BuildSearchSql(ref where, int_Type, def, false); // int_Type
            BuildSearchSql(ref where, int_Location, def, false); // int_Location
            BuildSearchSql(ref where, date_Created, def, false); // date_Created
            BuildSearchSql(ref where, date_Modified, def, false); // date_Modified
            BuildSearchSql(ref where, int_Created_By, def, false); // int_Created_By
            BuildSearchSql(ref where, int_Modified_By, def, false); // int_Modified_By
            BuildSearchSql(ref where, bit_IsDeleted, def, false); // bit_IsDeleted
            BuildSearchSql(ref where, str_InstPermitNo, def, false); // str_InstPermitNo
            BuildSearchSql(ref where, date_PermitExpiration, def, false); // date_PermitExpiration
            BuildSearchSql(ref where, date_InCarPermitIssue, def, false); // date_InCarPermitIssue
            BuildSearchSql(ref where, str_InClassPermitNo, def, false); // str_InClassPermitNo
            BuildSearchSql(ref where, date_InClassPermitIssue, def, false); // date_InClassPermitIssue
            BuildSearchSql(ref where, instructor_caption, def, false); // instructor_caption
            BuildSearchSql(ref where, str_LicType, def, false); // str_LicType
            BuildSearchSql(ref where, int_Order, def, false); // int_Order
            BuildSearchSql(ref where, str_InstLicenceDate, def, false); // str_InstLicenceDate
            BuildSearchSql(ref where, str_DLNum, def, false); // str_DLNum
            BuildSearchSql(ref where, str_DLExp, def, false); // str_DLExp
            BuildSearchSql(ref where, bit_appointmentColor, def, false); // bit_appointmentColor
            BuildSearchSql(ref where, str_appointmentColorCode, def, false); // str_appointmentColorCode
            BuildSearchSql(ref where, bit_IsSuperAdmin, def, false); // bit_IsSuperAdmin
            BuildSearchSql(ref where, IsDistanceBasedScheduling, def, false); // IsDistanceBasedScheduling
            BuildSearchSql(ref where, str_Package_Code, def, false); // str_Package_Code
            BuildSearchSql(ref where, str_NationalID_Iqama, def, false); // str_NationalID_Iqama
            BuildSearchSql(ref where, NationalID, def, false); // NationalID
            BuildSearchSql(ref where, int_RoadDistanceCoverage, def, false); // int_RoadDistanceCoverage
            BuildSearchSql(ref where, str_Badge, def, false); // str_Badge
            BuildSearchSql(ref where, strZoomHostUrl, def, false); // strZoomHostUrl
            BuildSearchSql(ref where, strZoomUserUrl, def, false); // strZoomUserUrl
            BuildSearchSql(ref where, str_VehicleType, def, false); // str_VehicleType
            BuildSearchSql(ref where, ProfilePicturePath, def, false); // ProfilePicturePath
            BuildSearchSql(ref where, Institution, def, false); // Institution
            BuildSearchSql(ref where, IsDrivingexperience, def, false); // IsDrivingexperience
            BuildSearchSql(ref where, intDrivinglicenseType, def, true); // intDrivinglicenseType
            BuildSearchSql(ref where, AbsherApptNbr, def, false); // AbsherApptNbr
            BuildSearchSql(ref where, Absherphoto, def, false); // Absherphoto
            BuildSearchSql(ref where, Fingerprint, def, false); // Fingerprint
            BuildSearchSql(ref where, ProfileField, def, false); // ProfileField
            BuildSearchSql(ref where, UserlevelID, def, false); // UserlevelID
            BuildSearchSql(ref where, Parent_Username, def, false); // Parent_Username
            BuildSearchSql(ref where, Activated, def, false); // Activated
            BuildSearchSql(ref where, int_Nationality, def, false); // int_Nationality
            BuildSearchSql(ref where, User_Role, def, false); // User_Role
            BuildSearchSql(ref where, int_Staff_Id, def, false); // int_Staff_Id

            // Set up search command
            if (!def && !Empty(where) && (new[] { "", "reset", "resetall" }).Contains(Command))
                Command = "search";
            if (!def && Command == "search") {
                int_Student_ID.AdvancedSearch.Save(); // int_Student_ID
                str_First_Name.AdvancedSearch.Save(); // str_First_Name
                str_Middle_Name.AdvancedSearch.Save(); // str_Middle_Name
                str_Last_Name.AdvancedSearch.Save(); // str_Last_Name
                str_Full_Name.AdvancedSearch.Save(); // str_Full_Name
                str_Address.AdvancedSearch.Save(); // str_Address
                str_City.AdvancedSearch.Save(); // str_City
                int_State.AdvancedSearch.Save(); // int_State
                str_Zip.AdvancedSearch.Save(); // str_Zip
                date_Hired.AdvancedSearch.Save(); // date_Hired
                date_Left.AdvancedSearch.Save(); // date_Left
                str_CertNumber.AdvancedSearch.Save(); // str_CertNumber
                date_CertExp.AdvancedSearch.Save(); // date_CertExp
                str_Cell_Phone.AdvancedSearch.Save(); // str_Cell_Phone
                str_Home_Phone.AdvancedSearch.Save(); // str_Home_Phone
                str_Other_Phone.AdvancedSearch.Save(); // str_Other_Phone
                str_Email.AdvancedSearch.Save(); // str_Email
                str_Code.AdvancedSearch.Save(); // str_Code
                str_Username.AdvancedSearch.Save(); // str_Username
                str_Password.AdvancedSearch.Save(); // str_Password
                date_Birth_Hijri.AdvancedSearch.Save(); // date_Birth_Hijri
                date_Birth.AdvancedSearch.Save(); // date_Birth
                Hijri_Year.AdvancedSearch.Save(); // Hijri_Year
                Hijri_Month.AdvancedSearch.Save(); // Hijri_Month
                Hijri_Day.AdvancedSearch.Save(); // Hijri_Day
                date_Started.AdvancedSearch.Save(); // date_Started
                str_DateHired.AdvancedSearch.Save(); // str_DateHired
                str_DateLeft.AdvancedSearch.Save(); // str_DateLeft
                str_Emergency_Contact_Name.AdvancedSearch.Save(); // str_Emergency_Contact_Name
                str_Emergency_Contact_Phone.AdvancedSearch.Save(); // str_Emergency_Contact_Phone
                str_Emergency_Contact_Relation.AdvancedSearch.Save(); // str_Emergency_Contact_Relation
                str_Notes.AdvancedSearch.Save(); // str_Notes
                int_ClassType.AdvancedSearch.Save(); // int_ClassType
                str_ZipCodes.AdvancedSearch.Save(); // str_ZipCodes
                int_VehicleAssigned.AdvancedSearch.Save(); // int_VehicleAssigned
                int_Status.AdvancedSearch.Save(); // int_Status
                int_Type.AdvancedSearch.Save(); // int_Type
                int_Location.AdvancedSearch.Save(); // int_Location
                date_Created.AdvancedSearch.Save(); // date_Created
                date_Modified.AdvancedSearch.Save(); // date_Modified
                int_Created_By.AdvancedSearch.Save(); // int_Created_By
                int_Modified_By.AdvancedSearch.Save(); // int_Modified_By
                bit_IsDeleted.AdvancedSearch.Save(); // bit_IsDeleted
                str_InstPermitNo.AdvancedSearch.Save(); // str_InstPermitNo
                date_PermitExpiration.AdvancedSearch.Save(); // date_PermitExpiration
                date_InCarPermitIssue.AdvancedSearch.Save(); // date_InCarPermitIssue
                str_InClassPermitNo.AdvancedSearch.Save(); // str_InClassPermitNo
                date_InClassPermitIssue.AdvancedSearch.Save(); // date_InClassPermitIssue
                instructor_caption.AdvancedSearch.Save(); // instructor_caption
                str_LicType.AdvancedSearch.Save(); // str_LicType
                int_Order.AdvancedSearch.Save(); // int_Order
                str_InstLicenceDate.AdvancedSearch.Save(); // str_InstLicenceDate
                str_DLNum.AdvancedSearch.Save(); // str_DLNum
                str_DLExp.AdvancedSearch.Save(); // str_DLExp
                bit_appointmentColor.AdvancedSearch.Save(); // bit_appointmentColor
                str_appointmentColorCode.AdvancedSearch.Save(); // str_appointmentColorCode
                bit_IsSuperAdmin.AdvancedSearch.Save(); // bit_IsSuperAdmin
                IsDistanceBasedScheduling.AdvancedSearch.Save(); // IsDistanceBasedScheduling
                str_Package_Code.AdvancedSearch.Save(); // str_Package_Code
                str_NationalID_Iqama.AdvancedSearch.Save(); // str_NationalID_Iqama
                NationalID.AdvancedSearch.Save(); // NationalID
                int_RoadDistanceCoverage.AdvancedSearch.Save(); // int_RoadDistanceCoverage
                str_Badge.AdvancedSearch.Save(); // str_Badge
                strZoomHostUrl.AdvancedSearch.Save(); // strZoomHostUrl
                strZoomUserUrl.AdvancedSearch.Save(); // strZoomUserUrl
                str_VehicleType.AdvancedSearch.Save(); // str_VehicleType
                ProfilePicturePath.AdvancedSearch.Save(); // ProfilePicturePath
                Institution.AdvancedSearch.Save(); // Institution
                IsDrivingexperience.AdvancedSearch.Save(); // IsDrivingexperience
                intDrivinglicenseType.AdvancedSearch.Save(); // intDrivinglicenseType
                AbsherApptNbr.AdvancedSearch.Save(); // AbsherApptNbr
                Absherphoto.AdvancedSearch.Save(); // Absherphoto
                Fingerprint.AdvancedSearch.Save(); // Fingerprint
                ProfileField.AdvancedSearch.Save(); // ProfileField
                UserlevelID.AdvancedSearch.Save(); // UserlevelID
                Parent_Username.AdvancedSearch.Save(); // Parent_Username
                Activated.AdvancedSearch.Save(); // Activated
                int_Nationality.AdvancedSearch.Save(); // int_Nationality
                User_Role.AdvancedSearch.Save(); // User_Role
                int_Staff_Id.AdvancedSearch.Save(); // int_Staff_Id

                // Clear rules for QueryBuilder
                SessionRules = "";
            }
            return where;
        }

        // Parse query builder rule function
        protected string ParseRules(Dictionary<string, object>? group, string fieldName = "") {
            if (group == null)
                return "";
            string condition = group.ContainsKey("condition") ? ConvertToString(group["condition"]) : "AND";
            if (!(new [] { "AND", "OR" }).Contains(condition))
                throw new System.Exception("Unable to build SQL query with condition '" + condition + "'");
            List<string> parts = new ();
            string where = "";
            var groupRules = group.ContainsKey("rules") ? group["rules"] : null;
            if (groupRules is IEnumerable<object> rules) {
                foreach (object rule in rules) {
                    var subRules = JObject.FromObject(rule).ToObject<Dictionary<string, object>>();
                    if (subRules == null)
                        continue;
                    if (subRules.ContainsKey("rules")) {
                        parts.Add("(" + " " + ParseRules(subRules, fieldName) + " " + ")" + " ");
                    } else {
                        string field = subRules.ContainsKey("field") ? ConvertToString(subRules["field"]) : "";
                        var fld = FieldByParam(field);
                        if (fld == null)
                            throw new System.Exception("Failed to find field '" + field + "'");
                        if (Empty(fieldName) || fld.Name == fieldName) { // Field name not specified or matched field name
                            string opr = subRules.ContainsKey("operator") ? ConvertToString(subRules["operator"]) : "";
                            string fldOpr = Config.ClientSearchOperators.FirstOrDefault(o => o.Value == opr).Key;
                            Dictionary<string, object>? ope = Config.QueryBuilderOperators.ContainsKey(opr) ? Config.QueryBuilderOperators[opr] : null;
                            if (ope == null || Empty(fldOpr))
                                throw new System.Exception("Unknown SQL operation for operator '" + opr + "'");
                            int nb_inputs = ope.ContainsKey("nb_inputs") ? ConvertToInt(ope["nb_inputs"]) : 0;
                            object val = subRules.ContainsKey("value") ? subRules["value"] : "";
                            if (nb_inputs > 0 && !Empty(val) || IsNullOrEmptyOperator(fldOpr)) {
                                string fldVal = val is List<object> list
                                    ? (list[0] is IEnumerable<string> ? String.Join(Config.MultipleOptionSeparator, list[0]) : ConvertToString(list[0]))
                                    : ConvertToString(val);
                                bool useFilter = fld.UseFilter; // Query builder does not use filter
                                try {
                                    if (fld.IsMultiSelect) {
                                        parts.Add(!Empty(fldVal) ? GetMultiSearchSql(fld, fldOpr, ConvertSearchValue(fldVal, fldOpr, fld), DbId) : "");
                                    } else {
                                        string fldVal2 = fldOpr.Contains("BETWEEN")
                                            ? (val is List<object> list2 && list2.Count > 1
                                                ? (list2[1] is IEnumerable<string> ? String.Join(Config.MultipleOptionSeparator, list2[1]) : ConvertToString(list2[1]))
                                                : "")
                                            : ""; // BETWEEN
                                        parts.Add(GetSearchSql(
                                            fld,
                                            ConvertSearchValue(fldVal, fldOpr, fld), // fldVal
                                            fldOpr,
                                            "", // fldCond not used
                                            ConvertSearchValue(fldVal2, fldOpr, fld), // $fldVal2
                                            "", // fldOpr2 not used
                                            DbId
                                        ));
                                    }
                                } finally {
                                    fld.UseFilter = useFilter;
                                }
                            }
                        }
                    }
                }
                where = String.Join(" " + condition + " ", parts);
                bool not = group.ContainsKey("not") ? ConvertToBool(group["not"]) : false;
                if (not)
                    where = "NOT (" + where + ")";
            }
            return where;
        }

        // Quey builder WHERE clause
        public string QueryBuilderWhere(string fieldName = "")
        {
            if (!Security.CanSearch)
                return "";

            // Get rules by query builder
            string rules = "";
            if (Post("rules", out StringValues sv))
                rules = sv.ToString();
            else
                rules = SessionRules;

            // Decode and parse rules
            string where = !Empty(rules) ? ParseRules(JsonConvert.DeserializeObject<Dictionary<string, object>>(rules), fieldName) : "";

            // Clear other search and save rules to session
            if (!Empty(where) && Empty(fieldName)) { // Skip if get query for specific field
                ResetSearchParms();
                SessionRules = rules;
            }

            // Return query
            return where;
        }

        // Build search SQL
        public void BuildSearchSql(ref string where, DbField fld, bool def, bool multiValue)
        {
            string fldParm = fld.Param;
            string fldVal = def ? ConvertToString(fld.AdvancedSearch.SearchValueDefault) : ConvertToString(fld.AdvancedSearch.SearchValue);
            string fldOpr = def ? fld.AdvancedSearch.SearchOperatorDefault : fld.AdvancedSearch.SearchOperator;
            string fldCond = def ? fld.AdvancedSearch.SearchConditionDefault : fld.AdvancedSearch.SearchCondition;
            string fldVal2 = def ? ConvertToString(fld.AdvancedSearch.SearchValue2Default) : ConvertToString(fld.AdvancedSearch.SearchValue2);
            string fldOpr2 = def ? fld.AdvancedSearch.SearchOperator2Default : fld.AdvancedSearch.SearchOperator2;
            fldVal = ConvertSearchValue(fldVal, fldOpr, fld);
            fldVal2 = ConvertSearchValue(fldVal2, fldOpr2, fld);
            fldOpr = ConvertSearchOperator(fldOpr, fld, fldVal);
            fldOpr2 = ConvertSearchOperator(fldOpr2, fld, fldVal2);
            string wrk = "";
            if (Config.SearchMultiValueOption == 1 && !fld.UseFilter || !IsMultiSearchOperator(fldOpr))
                multiValue = false;
            if (multiValue) {
                wrk = !Empty(fldVal) ? GetMultiSearchSql(fld, fldOpr, fldVal, DbId) : ""; // Field value 1
                string wrk2 = !Empty(fldVal2) ? GetMultiSearchSql(fld, fldOpr2, fldVal2, DbId) : ""; // Field value 2
                AddFilter(ref wrk, wrk2, fldCond);
            } else {
                wrk = GetSearchSql(fld, fldVal, fldOpr, fldCond, fldVal2, fldOpr2, DbId);
            }
            string cond = SearchOption == "AUTO" && (new[] {"AND", "OR"}).Contains(BasicSearch.Type)
                ? BasicSearch.Type
                : SameText(SearchOption, "OR") ? "OR" : "AND";
            AddFilter(ref where, wrk, cond);
        }

        // Show list of filters
        public void ShowFilterList()
        {
            // Initialize
            string filterList = "",
                filter = "",
                captionClass = IsExport("email") ? "ew-filter-caption-email" : "ew-filter-caption",
                captionSuffix = IsExport("email") ? ": " : "";

            // Field str_First_Name
            filter = QueryBuilderWhere("str_First_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_First_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_First_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Last_Name
            filter = QueryBuilderWhere("str_Last_Name");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Last_Name, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Last_Name.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Cell_Phone
            filter = QueryBuilderWhere("str_Cell_Phone");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Cell_Phone, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Cell_Phone.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Email
            filter = QueryBuilderWhere("str_Email");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Email, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Email.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_NationalID_Iqama
            filter = QueryBuilderWhere("str_NationalID_Iqama");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_NationalID_Iqama, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_NationalID_Iqama.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field intDrivinglicenseType
            filter = QueryBuilderWhere("intDrivinglicenseType");
            if (Empty(filter))
                BuildSearchSql(ref filter, intDrivinglicenseType, false, true);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + intDrivinglicenseType.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field AbsherApptNbr
            filter = QueryBuilderWhere("AbsherApptNbr");
            if (Empty(filter))
                BuildSearchSql(ref filter, AbsherApptNbr, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + AbsherApptNbr.Caption + "</span>" + captionSuffix + filter + "</div>";
            if (!Empty(BasicSearch.Keyword))
                filterList += "<div><span class=\"" + captionClass + "\">" + Language.Phrase("BasicSearchKeyword") + "</span>" + captionSuffix + BasicSearch.Keyword + "</div>";

            // Show Filters
            if (!Empty(filterList)) {
                string message = "<div id=\"ew-filter-list\" class=\"callout callout-info d-table\"><div id=\"ew-current-filters\">" +
                    Language.Phrase("CurrentFilters") + "</div>" + filterList + "</div>";
                MessageShowing(ref message, "");
                Write(message);
            } else { // Output empty tag
                Write("<div id=\"ew-filter-list\"></div>");
            }
        }

        // Return basic search WHERE clause based on search keyword and type
        public string BasicSearchWhere(bool def = false) {
            string searchStr = "";
            if (!Security.CanSearch)
                return "";

            // Fields to search
            List<DbField> searchFlds = new ();
            searchFlds.Add(str_First_Name);
            searchFlds.Add(str_Middle_Name);
            searchFlds.Add(str_Last_Name);
            searchFlds.Add(str_Full_Name);
            searchFlds.Add(str_Address);
            searchFlds.Add(str_City);
            searchFlds.Add(str_Zip);
            searchFlds.Add(str_CertNumber);
            searchFlds.Add(date_CertExp);
            searchFlds.Add(str_Cell_Phone);
            searchFlds.Add(str_Home_Phone);
            searchFlds.Add(str_Other_Phone);
            searchFlds.Add(str_Email);
            searchFlds.Add(str_Code);
            searchFlds.Add(str_Username);
            searchFlds.Add(str_Password);
            searchFlds.Add(date_Birth_Hijri);
            searchFlds.Add(Hijri_Year);
            searchFlds.Add(Hijri_Month);
            searchFlds.Add(Hijri_Day);
            searchFlds.Add(date_Started);
            searchFlds.Add(str_DateHired);
            searchFlds.Add(str_DateLeft);
            searchFlds.Add(str_Emergency_Contact_Name);
            searchFlds.Add(str_Emergency_Contact_Phone);
            searchFlds.Add(str_Emergency_Contact_Relation);
            searchFlds.Add(str_Notes);
            searchFlds.Add(str_ZipCodes);
            searchFlds.Add(str_InstPermitNo);
            searchFlds.Add(date_PermitExpiration);
            searchFlds.Add(date_InCarPermitIssue);
            searchFlds.Add(str_InClassPermitNo);
            searchFlds.Add(date_InClassPermitIssue);
            searchFlds.Add(instructor_caption);
            searchFlds.Add(str_LicType);
            searchFlds.Add(str_InstLicenceDate);
            searchFlds.Add(str_DLNum);
            searchFlds.Add(str_DLExp);
            searchFlds.Add(str_appointmentColorCode);
            searchFlds.Add(str_Package_Code);
            searchFlds.Add(str_NationalID_Iqama);
            searchFlds.Add(str_Badge);
            searchFlds.Add(strZoomHostUrl);
            searchFlds.Add(strZoomUserUrl);
            searchFlds.Add(str_VehicleType);
            searchFlds.Add(ProfilePicturePath);
            searchFlds.Add(Institution);
            searchFlds.Add(intDrivinglicenseType);
            searchFlds.Add(AbsherApptNbr);
            searchFlds.Add(Absherphoto);
            searchFlds.Add(Fingerprint);
            searchFlds.Add(ProfileField);
            searchFlds.Add(Parent_Username);
            searchFlds.Add(User_Role);
            string searchKeyword = def ? BasicSearch.KeywordDefault : BasicSearch.Keyword;
            string searchType = def ? BasicSearch.TypeDefault : BasicSearch.Type;

            // Get search SQL
            if (!Empty(searchKeyword)) {
                List<string> list = BasicSearch.KeywordList(def);
                searchStr = GetQuickSearchFilter(searchFlds, list, searchType, BasicSearch.BasicSearchAnyFields, DbId);
                if (!def && (new[] {"", "reset", "resetall"}).Contains(Command))
                    Command = "search";
            }
            if (!def && Command == "search") {
                BasicSearch.SessionKeyword = searchKeyword;
                BasicSearch.SessionType = searchType;

                // Clear rules for QueryBuilder
                SessionRules = "";
            }
            return searchStr;
        }

        // Check if search parm exists
        protected bool CheckSearchParms() {
            // Check basic search
            if (BasicSearch.IssetSession)
                return true;
            if (int_Student_ID.AdvancedSearch.IssetSession)
                return true;
            if (str_First_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Middle_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Last_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Full_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Address.AdvancedSearch.IssetSession)
                return true;
            if (str_City.AdvancedSearch.IssetSession)
                return true;
            if (int_State.AdvancedSearch.IssetSession)
                return true;
            if (str_Zip.AdvancedSearch.IssetSession)
                return true;
            if (date_Hired.AdvancedSearch.IssetSession)
                return true;
            if (date_Left.AdvancedSearch.IssetSession)
                return true;
            if (str_CertNumber.AdvancedSearch.IssetSession)
                return true;
            if (date_CertExp.AdvancedSearch.IssetSession)
                return true;
            if (str_Cell_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Home_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Other_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Email.AdvancedSearch.IssetSession)
                return true;
            if (str_Code.AdvancedSearch.IssetSession)
                return true;
            if (str_Username.AdvancedSearch.IssetSession)
                return true;
            if (str_Password.AdvancedSearch.IssetSession)
                return true;
            if (date_Birth_Hijri.AdvancedSearch.IssetSession)
                return true;
            if (date_Birth.AdvancedSearch.IssetSession)
                return true;
            if (Hijri_Year.AdvancedSearch.IssetSession)
                return true;
            if (Hijri_Month.AdvancedSearch.IssetSession)
                return true;
            if (Hijri_Day.AdvancedSearch.IssetSession)
                return true;
            if (date_Started.AdvancedSearch.IssetSession)
                return true;
            if (str_DateHired.AdvancedSearch.IssetSession)
                return true;
            if (str_DateLeft.AdvancedSearch.IssetSession)
                return true;
            if (str_Emergency_Contact_Name.AdvancedSearch.IssetSession)
                return true;
            if (str_Emergency_Contact_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Emergency_Contact_Relation.AdvancedSearch.IssetSession)
                return true;
            if (str_Notes.AdvancedSearch.IssetSession)
                return true;
            if (int_ClassType.AdvancedSearch.IssetSession)
                return true;
            if (str_ZipCodes.AdvancedSearch.IssetSession)
                return true;
            if (int_VehicleAssigned.AdvancedSearch.IssetSession)
                return true;
            if (int_Status.AdvancedSearch.IssetSession)
                return true;
            if (int_Type.AdvancedSearch.IssetSession)
                return true;
            if (int_Location.AdvancedSearch.IssetSession)
                return true;
            if (date_Created.AdvancedSearch.IssetSession)
                return true;
            if (date_Modified.AdvancedSearch.IssetSession)
                return true;
            if (int_Created_By.AdvancedSearch.IssetSession)
                return true;
            if (int_Modified_By.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsDeleted.AdvancedSearch.IssetSession)
                return true;
            if (str_InstPermitNo.AdvancedSearch.IssetSession)
                return true;
            if (date_PermitExpiration.AdvancedSearch.IssetSession)
                return true;
            if (date_InCarPermitIssue.AdvancedSearch.IssetSession)
                return true;
            if (str_InClassPermitNo.AdvancedSearch.IssetSession)
                return true;
            if (date_InClassPermitIssue.AdvancedSearch.IssetSession)
                return true;
            if (instructor_caption.AdvancedSearch.IssetSession)
                return true;
            if (str_LicType.AdvancedSearch.IssetSession)
                return true;
            if (int_Order.AdvancedSearch.IssetSession)
                return true;
            if (str_InstLicenceDate.AdvancedSearch.IssetSession)
                return true;
            if (str_DLNum.AdvancedSearch.IssetSession)
                return true;
            if (str_DLExp.AdvancedSearch.IssetSession)
                return true;
            if (bit_appointmentColor.AdvancedSearch.IssetSession)
                return true;
            if (str_appointmentColorCode.AdvancedSearch.IssetSession)
                return true;
            if (bit_IsSuperAdmin.AdvancedSearch.IssetSession)
                return true;
            if (IsDistanceBasedScheduling.AdvancedSearch.IssetSession)
                return true;
            if (str_Package_Code.AdvancedSearch.IssetSession)
                return true;
            if (str_NationalID_Iqama.AdvancedSearch.IssetSession)
                return true;
            if (NationalID.AdvancedSearch.IssetSession)
                return true;
            if (int_RoadDistanceCoverage.AdvancedSearch.IssetSession)
                return true;
            if (str_Badge.AdvancedSearch.IssetSession)
                return true;
            if (strZoomHostUrl.AdvancedSearch.IssetSession)
                return true;
            if (strZoomUserUrl.AdvancedSearch.IssetSession)
                return true;
            if (str_VehicleType.AdvancedSearch.IssetSession)
                return true;
            if (ProfilePicturePath.AdvancedSearch.IssetSession)
                return true;
            if (Institution.AdvancedSearch.IssetSession)
                return true;
            if (IsDrivingexperience.AdvancedSearch.IssetSession)
                return true;
            if (intDrivinglicenseType.AdvancedSearch.IssetSession)
                return true;
            if (AbsherApptNbr.AdvancedSearch.IssetSession)
                return true;
            if (Absherphoto.AdvancedSearch.IssetSession)
                return true;
            if (Fingerprint.AdvancedSearch.IssetSession)
                return true;
            if (ProfileField.AdvancedSearch.IssetSession)
                return true;
            if (UserlevelID.AdvancedSearch.IssetSession)
                return true;
            if (Parent_Username.AdvancedSearch.IssetSession)
                return true;
            if (Activated.AdvancedSearch.IssetSession)
                return true;
            if (int_Nationality.AdvancedSearch.IssetSession)
                return true;
            if (User_Role.AdvancedSearch.IssetSession)
                return true;
            if (int_Staff_Id.AdvancedSearch.IssetSession)
                return true;
            return false;
        }

        // Clear all search parameters
        protected void ResetSearchParms() {
            SearchWhere = "";
            SessionSearchWhere = SearchWhere;

            // Clear basic search parameters
            ResetBasicSearchParms();

            // Clear advanced search parameters
            ResetAdvancedSearchParms();

            // Clear queryBuilder
            SessionRules = "";
        }

        // Load advanced search default values
        protected bool LoadAdvancedSearchDefault() {
        return false;
        }

        // Clear all basic search parameters
        protected void ResetBasicSearchParms() {
            BasicSearch.UnsetSession();
        }

        // Clear all advanced search parameters
        protected void ResetAdvancedSearchParms() {
            int_Student_ID.AdvancedSearch.UnsetSession();
            str_First_Name.AdvancedSearch.UnsetSession();
            str_Middle_Name.AdvancedSearch.UnsetSession();
            str_Last_Name.AdvancedSearch.UnsetSession();
            str_Full_Name.AdvancedSearch.UnsetSession();
            str_Address.AdvancedSearch.UnsetSession();
            str_City.AdvancedSearch.UnsetSession();
            int_State.AdvancedSearch.UnsetSession();
            str_Zip.AdvancedSearch.UnsetSession();
            date_Hired.AdvancedSearch.UnsetSession();
            date_Left.AdvancedSearch.UnsetSession();
            str_CertNumber.AdvancedSearch.UnsetSession();
            date_CertExp.AdvancedSearch.UnsetSession();
            str_Cell_Phone.AdvancedSearch.UnsetSession();
            str_Home_Phone.AdvancedSearch.UnsetSession();
            str_Other_Phone.AdvancedSearch.UnsetSession();
            str_Email.AdvancedSearch.UnsetSession();
            str_Code.AdvancedSearch.UnsetSession();
            str_Username.AdvancedSearch.UnsetSession();
            str_Password.AdvancedSearch.UnsetSession();
            date_Birth_Hijri.AdvancedSearch.UnsetSession();
            date_Birth.AdvancedSearch.UnsetSession();
            Hijri_Year.AdvancedSearch.UnsetSession();
            Hijri_Month.AdvancedSearch.UnsetSession();
            Hijri_Day.AdvancedSearch.UnsetSession();
            date_Started.AdvancedSearch.UnsetSession();
            str_DateHired.AdvancedSearch.UnsetSession();
            str_DateLeft.AdvancedSearch.UnsetSession();
            str_Emergency_Contact_Name.AdvancedSearch.UnsetSession();
            str_Emergency_Contact_Phone.AdvancedSearch.UnsetSession();
            str_Emergency_Contact_Relation.AdvancedSearch.UnsetSession();
            str_Notes.AdvancedSearch.UnsetSession();
            int_ClassType.AdvancedSearch.UnsetSession();
            str_ZipCodes.AdvancedSearch.UnsetSession();
            int_VehicleAssigned.AdvancedSearch.UnsetSession();
            int_Status.AdvancedSearch.UnsetSession();
            int_Type.AdvancedSearch.UnsetSession();
            int_Location.AdvancedSearch.UnsetSession();
            date_Created.AdvancedSearch.UnsetSession();
            date_Modified.AdvancedSearch.UnsetSession();
            int_Created_By.AdvancedSearch.UnsetSession();
            int_Modified_By.AdvancedSearch.UnsetSession();
            bit_IsDeleted.AdvancedSearch.UnsetSession();
            str_InstPermitNo.AdvancedSearch.UnsetSession();
            date_PermitExpiration.AdvancedSearch.UnsetSession();
            date_InCarPermitIssue.AdvancedSearch.UnsetSession();
            str_InClassPermitNo.AdvancedSearch.UnsetSession();
            date_InClassPermitIssue.AdvancedSearch.UnsetSession();
            instructor_caption.AdvancedSearch.UnsetSession();
            str_LicType.AdvancedSearch.UnsetSession();
            int_Order.AdvancedSearch.UnsetSession();
            str_InstLicenceDate.AdvancedSearch.UnsetSession();
            str_DLNum.AdvancedSearch.UnsetSession();
            str_DLExp.AdvancedSearch.UnsetSession();
            bit_appointmentColor.AdvancedSearch.UnsetSession();
            str_appointmentColorCode.AdvancedSearch.UnsetSession();
            bit_IsSuperAdmin.AdvancedSearch.UnsetSession();
            IsDistanceBasedScheduling.AdvancedSearch.UnsetSession();
            str_Package_Code.AdvancedSearch.UnsetSession();
            str_NationalID_Iqama.AdvancedSearch.UnsetSession();
            NationalID.AdvancedSearch.UnsetSession();
            int_RoadDistanceCoverage.AdvancedSearch.UnsetSession();
            str_Badge.AdvancedSearch.UnsetSession();
            strZoomHostUrl.AdvancedSearch.UnsetSession();
            strZoomUserUrl.AdvancedSearch.UnsetSession();
            str_VehicleType.AdvancedSearch.UnsetSession();
            ProfilePicturePath.AdvancedSearch.UnsetSession();
            Institution.AdvancedSearch.UnsetSession();
            IsDrivingexperience.AdvancedSearch.UnsetSession();
            intDrivinglicenseType.AdvancedSearch.UnsetSession();
            AbsherApptNbr.AdvancedSearch.UnsetSession();
            Absherphoto.AdvancedSearch.UnsetSession();
            Fingerprint.AdvancedSearch.UnsetSession();
            ProfileField.AdvancedSearch.UnsetSession();
            UserlevelID.AdvancedSearch.UnsetSession();
            Parent_Username.AdvancedSearch.UnsetSession();
            Activated.AdvancedSearch.UnsetSession();
            int_Nationality.AdvancedSearch.UnsetSession();
            User_Role.AdvancedSearch.UnsetSession();
            int_Staff_Id.AdvancedSearch.UnsetSession();
        }

        // Restore all search parameters
        protected void RestoreSearchParms() {
            RestoreSearch = true;

            // Restore basic search values
            BasicSearch.Load();

            // Restore advanced search values
            int_Student_ID.AdvancedSearch.Load();
            str_First_Name.AdvancedSearch.Load();
            str_Middle_Name.AdvancedSearch.Load();
            str_Last_Name.AdvancedSearch.Load();
            str_Full_Name.AdvancedSearch.Load();
            str_Address.AdvancedSearch.Load();
            str_City.AdvancedSearch.Load();
            int_State.AdvancedSearch.Load();
            str_Zip.AdvancedSearch.Load();
            date_Hired.AdvancedSearch.Load();
            date_Left.AdvancedSearch.Load();
            str_CertNumber.AdvancedSearch.Load();
            date_CertExp.AdvancedSearch.Load();
            str_Cell_Phone.AdvancedSearch.Load();
            str_Home_Phone.AdvancedSearch.Load();
            str_Other_Phone.AdvancedSearch.Load();
            str_Email.AdvancedSearch.Load();
            str_Code.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            str_Password.AdvancedSearch.Load();
            date_Birth_Hijri.AdvancedSearch.Load();
            date_Birth.AdvancedSearch.Load();
            Hijri_Year.AdvancedSearch.Load();
            Hijri_Month.AdvancedSearch.Load();
            Hijri_Day.AdvancedSearch.Load();
            date_Started.AdvancedSearch.Load();
            str_DateHired.AdvancedSearch.Load();
            str_DateLeft.AdvancedSearch.Load();
            str_Emergency_Contact_Name.AdvancedSearch.Load();
            str_Emergency_Contact_Phone.AdvancedSearch.Load();
            str_Emergency_Contact_Relation.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            int_ClassType.AdvancedSearch.Load();
            str_ZipCodes.AdvancedSearch.Load();
            int_VehicleAssigned.AdvancedSearch.Load();
            int_Status.AdvancedSearch.Load();
            int_Type.AdvancedSearch.Load();
            int_Location.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            int_Created_By.AdvancedSearch.Load();
            int_Modified_By.AdvancedSearch.Load();
            bit_IsDeleted.AdvancedSearch.Load();
            str_InstPermitNo.AdvancedSearch.Load();
            date_PermitExpiration.AdvancedSearch.Load();
            date_InCarPermitIssue.AdvancedSearch.Load();
            str_InClassPermitNo.AdvancedSearch.Load();
            date_InClassPermitIssue.AdvancedSearch.Load();
            instructor_caption.AdvancedSearch.Load();
            str_LicType.AdvancedSearch.Load();
            int_Order.AdvancedSearch.Load();
            str_InstLicenceDate.AdvancedSearch.Load();
            str_DLNum.AdvancedSearch.Load();
            str_DLExp.AdvancedSearch.Load();
            bit_appointmentColor.AdvancedSearch.Load();
            str_appointmentColorCode.AdvancedSearch.Load();
            bit_IsSuperAdmin.AdvancedSearch.Load();
            IsDistanceBasedScheduling.AdvancedSearch.Load();
            str_Package_Code.AdvancedSearch.Load();
            str_NationalID_Iqama.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            int_RoadDistanceCoverage.AdvancedSearch.Load();
            str_Badge.AdvancedSearch.Load();
            strZoomHostUrl.AdvancedSearch.Load();
            strZoomUserUrl.AdvancedSearch.Load();
            str_VehicleType.AdvancedSearch.Load();
            ProfilePicturePath.AdvancedSearch.Load();
            Institution.AdvancedSearch.Load();
            IsDrivingexperience.AdvancedSearch.Load();
            intDrivinglicenseType.AdvancedSearch.Load();
            AbsherApptNbr.AdvancedSearch.Load();
            Absherphoto.AdvancedSearch.Load();
            Fingerprint.AdvancedSearch.Load();
            ProfileField.AdvancedSearch.Load();
            UserlevelID.AdvancedSearch.Load();
            Parent_Username.AdvancedSearch.Load();
            Activated.AdvancedSearch.Load();
            int_Nationality.AdvancedSearch.Load();
            User_Role.AdvancedSearch.Load();
            int_Staff_Id.AdvancedSearch.Load();
        }

        // Set up sort parameters
        protected void SetupSortOrder() {
            // Load default Sorting Order
            if (Command != "json") {
                string defaultSort = ""; // Set up default sort
                if (Empty(SessionOrderBy) && !Empty(defaultSort))
                    SessionOrderBy = defaultSort;
            }

            // Check for Ctrl pressed
            bool ctrl = Get<bool>("ctrl");

            // Check for "order" parameter
            if (Get("order", out StringValues sv)) {
                CurrentOrder = sv.ToString();
                CurrentOrderType = Get("ordertype");
                UpdateSort(str_First_Name, ctrl); // str_First_Name
                UpdateSort(str_Last_Name, ctrl); // str_Last_Name
                UpdateSort(str_Cell_Phone, ctrl); // str_Cell_Phone
                UpdateSort(str_Email, ctrl); // str_Email
                UpdateSort(str_NationalID_Iqama, ctrl); // str_NationalID_Iqama
                UpdateSort(intDrivinglicenseType, ctrl); // intDrivinglicenseType
                UpdateSort(AbsherApptNbr, ctrl); // AbsherApptNbr
                StartRecordNumber = 1; // Reset start position
            }

            // Update field sort
            UpdateFieldSort();
        }

        /// <summary>
        /// Reset command
        /// cmd=reset (Reset search parameters)
        /// cmd=resetall (Reset search and master/detail parameters)
        /// cmd=resetsort (Reset sort parameters)
        /// </summary>
        protected void ResetCommand() {
            // Get reset cmd
            if (Command.ToLower().StartsWith("reset")) {
                // Reset search criteria
                if (SameText(Command, "reset") || SameText(Command, "resetall"))
                    ResetSearchParms();

                // Reset (clear) sorting order
                if (SameText(Command, "resetsort")) {
                    string orderBy = "";
                    SessionOrderBy = orderBy;
                    int_Student_ID.Sort = "";
                    str_First_Name.Sort = "";
                    str_Middle_Name.Sort = "";
                    str_Last_Name.Sort = "";
                    str_Full_Name.Sort = "";
                    str_Address.Sort = "";
                    str_City.Sort = "";
                    int_State.Sort = "";
                    str_Zip.Sort = "";
                    date_Hired.Sort = "";
                    date_Left.Sort = "";
                    str_CertNumber.Sort = "";
                    date_CertExp.Sort = "";
                    str_Cell_Phone.Sort = "";
                    str_Home_Phone.Sort = "";
                    str_Other_Phone.Sort = "";
                    str_Email.Sort = "";
                    str_Code.Sort = "";
                    str_Username.Sort = "";
                    str_Password.Sort = "";
                    date_Birth_Hijri.Sort = "";
                    date_Birth.Sort = "";
                    Hijri_Year.Sort = "";
                    Hijri_Month.Sort = "";
                    Hijri_Day.Sort = "";
                    date_Started.Sort = "";
                    str_DateHired.Sort = "";
                    str_DateLeft.Sort = "";
                    str_Emergency_Contact_Name.Sort = "";
                    str_Emergency_Contact_Phone.Sort = "";
                    str_Emergency_Contact_Relation.Sort = "";
                    str_Notes.Sort = "";
                    int_ClassType.Sort = "";
                    str_ZipCodes.Sort = "";
                    int_VehicleAssigned.Sort = "";
                    int_Status.Sort = "";
                    int_Type.Sort = "";
                    int_Location.Sort = "";
                    date_Created.Sort = "";
                    date_Modified.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    bit_IsDeleted.Sort = "";
                    str_InstPermitNo.Sort = "";
                    date_PermitExpiration.Sort = "";
                    date_InCarPermitIssue.Sort = "";
                    str_InClassPermitNo.Sort = "";
                    date_InClassPermitIssue.Sort = "";
                    instructor_caption.Sort = "";
                    str_LicType.Sort = "";
                    int_Order.Sort = "";
                    str_InstLicenceDate.Sort = "";
                    str_DLNum.Sort = "";
                    str_DLExp.Sort = "";
                    bit_appointmentColor.Sort = "";
                    str_appointmentColorCode.Sort = "";
                    bit_IsSuperAdmin.Sort = "";
                    IsDistanceBasedScheduling.Sort = "";
                    str_Package_Code.Sort = "";
                    str_NationalID_Iqama.Sort = "";
                    NationalID.Sort = "";
                    int_RoadDistanceCoverage.Sort = "";
                    str_Badge.Sort = "";
                    strZoomHostUrl.Sort = "";
                    strZoomUserUrl.Sort = "";
                    str_VehicleType.Sort = "";
                    ProfilePicturePath.Sort = "";
                    Institution.Sort = "";
                    IsDrivingexperience.Sort = "";
                    intDrivinglicenseType.Sort = "";
                    AbsherApptNbr.Sort = "";
                    Absherphoto.Sort = "";
                    Fingerprint.Sort = "";
                    ProfileField.Sort = "";
                    UserlevelID.Sort = "";
                    Parent_Username.Sort = "";
                    Activated.Sort = "";
                    int_Nationality.Sort = "";
                    User_Role.Sort = "";
                    int_Staff_Id.Sort = "";
                }

                // Reset start position
                StartRecord = 1;
                StartRecordNumber = StartRecord;
            }
        }

        #pragma warning disable 1998
        // Set up list options
        protected async Task SetupListOptions() {
            ListOption item;
            MultiColumnLayout = Param(Config.PageLayout);
            if (Config.PageLayouts.Contains(MultiColumnLayout))
                SessionLayout = MultiColumnLayout;
            else
                MultiColumnLayout = !Empty(SessionLayout) ? SessionLayout : "cards";

            // Add group option item
            item = ListOptions.AddGroupOption();
            item.Body = "";
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.Visible = false;

            // "view"
            item = ListOptions.Add("view");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanView;
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;

            // "edit"
            item = ListOptions.Add("edit");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanEdit;
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;

            // "detail_tblAssessment"
            item = ListOptions.Add("detail_tblAssessment");
            item.CssClass = "text-nowrap";
            item.Visible = Security.AllowList(CurrentProjectID + "tblAssessment");
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.ShowInButtonGroup = false;
            tblAssessmentGrid = Resolve("TblAssessmentGrid")!;

            // Multiple details
            if (ShowMultipleDetails) {
                item = ListOptions.Add("details");
                item.CssClass = "text-nowrap";
                item.Visible = ShowMultipleDetails && ListOptions.DetailVisible();
                item.OnLeft = MultiColumnLayout == "cards" ? false : true;
                item.ShowInButtonGroup = false;
            }

            // Set up detail pages
            var _pages = new SubPages();
            _pages.Add("tblAssessment");
            DetailPages = _pages;

            // List actions
            item = ListOptions.Add("listactions");
            item.CssClass = "text-nowrap";
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.Visible = false;
            item.ShowInButtonGroup = false;
            item.ShowInDropDown = false;

            // "checkbox"
            item = ListOptions.Add("checkbox");
            item.CssStyle = "white-space: nowrap; text-align: center; vertical-align: middle; margin: 0px;";
            item.Visible = Security.CanEdit;
            item.OnLeft = MultiColumnLayout == "cards" ? false : true;
            item.Header = "<div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\"></div>";
            if (item.OnLeft)
                item.MoveTo(0);
            item.ShowInDropDown = false;
            item.ShowInButtonGroup = false;

            // Drop down button for ListOptions
            ListOptions.UseDropDownButton = false;
            if (MultiColumnLayout == "cards") { // Multi column layout
                ListOptions.DropDownButtonPhrase = "ButtonListOptionsCard";
                ListOptions.TagClassName = "ew-multi-column-list-option-card m-1";
            } else {
                ListOptions.DropDownButtonPhrase = "ButtonListOptions";
                ListOptions.TagClassName = "ew-multi-column-list-option-table";
            }
            ListOptions.UseButtonGroup = false;
            if (ListOptions.UseButtonGroup && IsMobile())
                ListOptions.UseDropDownButton = true;

            //ListOptions.ButtonClass = ""; // Class for button group

            // Call ListOptions Load event
            ListOptionsLoad();
            SetupListOptionsExt();
            ListOptions[ListOptions.GroupOptionName]?.SetVisible(ListOptions.GroupOptionVisible);
        }
        #pragma warning restore 1998

        // Set up list options (extensions)
        protected void SetupListOptionsExt() {
            // Preview extension
            ListOptions.HideDetailItemsForDropDown(); // Hide detail items for dropdown if necessary
        }

        // Add "hash" parameter to URL
        public string UrlAddHash(string url, string hash)
        {
            return UseAjaxActions ? url : UrlAddQuery(url, "hash=" + hash);
        }

        // Render list options
        #pragma warning disable 168, 219, 1998

        public async Task RenderListOptions()
        {
            ListOption? listOption;
            bool isVisible = false; // DN
            ListOptions.LoadDefault();

            // Call ListOptions Rendering event
            ListOptionsRendering();

            // Add row attributes for expandable row (preview field)
            if (RowType == RowType.View) {
                RowAttrs["data-widget"] = "expandable-table";
                RowAttrs["aria-expanded"] = "false";
            } else if (RowType == RowType.PreviewField) {
                CssClass = "expandable-body";
            }

            // "view"
            listOption = ListOptions["view"];
            string viewcaption = Language.Phrase("ViewLink", true);
            isVisible = Security.CanView && ShowOptionLink("view");
            if (isVisible) {
                if (ModalView && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-table=""tblStudents"" data-caption=""{viewcaption}"" data-ew-action=""modal"" data-action=""view"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(ViewUrl)) + "\" data-btn=\"null\">" + Language.Phrase("ViewLink") + "</a>");
                else
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-caption=""{viewcaption}"" href=""" + HtmlEncode(AppPath(ViewUrl)) + "\">" + Language.Phrase("ViewLink") + "</a>");
            } else {
                listOption?.Clear();
            }

            // "edit"
            listOption = ListOptions["edit"];
            string editcaption = Language.Phrase("EditLink", true);
            isVisible = Security.CanEdit && ShowOptionLink("edit");
            if (isVisible) {
                if (ModalEdit && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblStudents"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
                else
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-caption=""{editcaption}"" href=""" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("EditLink") + "</a>");
            } else {
                listOption?.Clear();
            }

            // Set up list action buttons
            listOption = ListOptions["listactions"];
            if (listOption != null && !IsExport() && CurrentAction == "") {
                string body = "";
                var links = new List<string>();
                foreach (var (key, act) in ListActions.Items) {
                    if (act.Select == Config.ActionSingle && act.Allowed) {
                        var action = act.Action;
                        string caption = act.Caption;
                        var icon = (act.Icon != "") ? "<i class=\"" + HtmlEncode(act.Icon.Replace(" ew-icon", "")) + "\" data-caption=\"" + HtmlTitle(caption) + "\"></i> " : "";
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblStudentslist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblStudentslist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
                        }
                    }
                }
                if (links.Count > 1) { // More than one buttons, use dropdown
                    body = "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-actions\" title=\"" + Language.Phrase("ListActionButton", true) + "\" data-bs-toggle=\"dropdown\">" + Language.Phrase("ListActionButton") + "</button>";
                    string content = links.Aggregate("", (result, link) => result + "<li>" + link + "</li>");
                    body += "<ul class=\"dropdown-menu" + (listOption?.OnLeft ?? false ? "" : " dropdown-menu-right") + "\">" + content + "</ul>";
                    body = "<div class=\"btn-group btn-group-sm\">" + body + "</div>";
                }
                if (links.Count > 0)
                    listOption?.SetBody(body);
            }
            var detailViewTblVar = "";
            var detailCopyTblVar = "";
            var detailEditTblVar = "";
            dynamic? detailPage = null;
            string detailFilter = "";

            // "detail_tblAssessment"
            listOption = ListOptions["detail_tblAssessment"];
            isVisible = Security.AllowList(CurrentProjectID + "tblAssessment") && ShowOptionLink();
            if (isVisible) {
                string caption, title, url;
                var body = Language.Phrase("DetailLink") + Language.TablePhrase("tblAssessment", "TblCaption");
                body = "<a class=\"btn btn-default ew-row-link ew-detail" + (ListOptions.UseDropDownButton ? " dropdown-toggle" : "") + "\" data-action=\"list\" href=\"" + HtmlEncode(AppPath("TblAssessmentList?" + Config.TableShowMaster + "=tblStudents&" + ForeignKeyUrl("fk_str_Username", str_Username.CurrentValue) + "")) + "\">" + body + "</a>";
                string links = "";
                detailPage = Resolve("TblAssessmentGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblStudents") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink", null);
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = GetViewUrl(Config.TableShowDetail + "=tblAssessment");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-view\" data-action=\"view\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
                    if (!Empty(detailViewTblVar))
                        detailViewTblVar += ",";
                    detailViewTblVar += "tblAssessment";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblStudents") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink", null);
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = GetEditUrl(Config.TableShowDetail + "=tblAssessment");
                    links += "<li><a class=\"dropdown-item ew-row-link ew-detail-edit\" data-action=\"edit\" data-caption=\"" + title + "\" href=\"" + HtmlEncode(AppPath(url)) + "\">" + caption + "</a></li>";
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
                listOption?.SetBody(body);
                if (ShowMultipleDetails)
                    listOption?.SetVisible(false);
            }
            if (ShowMultipleDetails) {
                var body = Language.Phrase("MultipleMasterDetails");
                body = "<div class=\"btn-group btn-group-sm ew-btn-group\">";
                string links = "";
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
                    body += "<button type=\"button\" class=\"dropdown-toggle btn btn-default ew-master-detail\" title=\"" + HtmlEncode(Language.Phrase("MultipleMasterDetails", true)) + "\" data-bs-toggle=\"dropdown\">" + Language.Phrase("MultipleMasterDetails") + "</button>";
                    body += "<ul class=\"dropdown-menu ew-dropdown-menu\">" + links + "</ul>";
                }
                body += "</div>";
                // Multiple details
                listOption = ListOptions["details"];
                listOption?.SetBody(body);
            }

            // "checkbox"
            listOption = ListOptions["checkbox"];
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(int_Student_ID.CurrentValue) + "\"></div>");
            RenderListOptionsExt();

            // Call ListOptions Rendered event
            ListOptionsRendered();
        }

        // Render list options (extensions)
        protected void RenderListOptionsExt() {
            // Preview extension
            string links = "", btngrps = "", sqlwrk, detaillnk, link, url, btngrp, caption, title, icon, detailFilter;
            List<string> masterKeys = new ();
            ListOption? option;
            dynamic? detailTbl = null, detailPage = null;
            masterKeys.Clear();
            sqlwrk = KeyFilter(Resolve("tblAssessment")!.str_Username, str_Username.CurrentValue, str_Username.DataType, DbId);
            masterKeys.Add(ConvertToString(str_Username.CurrentValue));

            // Column "detail_tblAssessment"
            if ((DetailPages?["tblAssessment"]?.Visible ?? false) && Security.AllowList(CurrentProjectID + "tblAssessment")) {
                link = "";
                option = ListOptions["detail_tblAssessment"];
                url = "TblAssessmentPreview?t=tblStudents&f=" + Encrypt(sqlwrk + "|" + String.Join("|", masterKeys));
                btngrp = "<div data-table=\"tblAssessment\" data-url=\"" + AppPath(url) + "\" class=\"ew-detail-btn-group d-none\">";
                if (Security.AllowList(CurrentProjectID + "tblStudents")) {
                    string label = Language.TablePhrase("tblAssessment", "TblCaption");
                    link = "<button class=\"nav-link\" data-bs-toggle=\"tab\" data-table=\"tblAssessment\" data-url=\"" + AppPath(url) + "\" type=\"button\" role=\"tab\" aria-selected=\"false\">" + label + "</button>";
                    detaillnk = AppPath("TblAssessmentList?" + Config.TableShowMaster + "=tblStudents&" + ForeignKeyUrl("fk_str_Username", str_Username.CurrentValue) + "");
                    title = Language.TablePhrase("tblAssessment", "TblCaption");
                    caption = Language.Phrase("MasterDetailListLink");
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(detaillnk) + "\">" + caption + "</a>";
                }
                detailPage = Resolve("TblAssessmentGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblStudents") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink");
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = AppPath(GetViewUrl(Config.TableShowDetail + "=tblAssessment"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblStudents") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink");
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = AppPath(GetEditUrl(Config.TableShowDetail + "=tblAssessment"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                btngrp += "</div>";
                if (link != "") {
                    link = "<li class=\"nav-item\">" + btngrp + link + "</li>";  // Note: Place btngrp before link
                    links += link;
                    option?.AddBody("<div class=\"ew-preview d-none\">" + link + "</div>");
                }
            }

            // Add row attributes for expandable row
            if (RowType == RowType.View) {
                RowAttrs["data-widget"] = "expandable-table";
                RowAttrs["aria-expanded"] = "false";
            }

            // Column "preview"
            option = ListOptions["preview"];
            if (option == null) { // Add preview column
                option = ListOptions.Add("preview");
                option.OnLeft = MultiColumnLayout == "cards" ? false : true;
                option.MoveTo(option.OnLeft ? ListOptions.GetItemIndex("checkbox") + 1 : ListOptions.GetItemIndex("checkbox"));
                option.Visible = !(IsExport() || IsGridAdd || IsGridEdit || IsMultiEdit);
                option.ShowInDropDown = false;
                option.ShowInButtonGroup = false;
            }
            icon = "fa-solid fa-caret-right"; // Right
            if (SameText(GetPropertyValue(this, "MultiColumnLayout"), "table")) {
                option.CssStyle = "width: 1%;";
                if (!option.OnLeft)
                    icon = Regex.Replace(icon, @"\bright\b", "left");
            }
            if (IsRTL) { // Reverse
                if (Regex.IsMatch(icon, @"\bleft\b"))
                    icon = Regex.Replace(icon, @"\bleft\b", "right");
                else if (Regex.IsMatch(icon, @"\bright\b"))
                    icon = Regex.Replace(icon, @"\bright\b", "left");
            }
            option.SetBody("<i role=\"button\" class=\"ew-preview-btn expandable-table-caret ew-icon " + icon + "\"></i>" +
                "<div class=\"ew-preview d-none\">" + links + "</div>");
            if (option.Visible)
                option.Visible = links != "";

            // Column "details" (Multiple details)
            option = ListOptions["details"];
            option?.AddBody("<div class=\"ew-preview d-none\">" + links + "</div>");
            if (option?.Visible ?? false)
                option.Visible = links != "";
        }

        // Set up other options
        protected void SetupOtherOptions() {
            ListOptions option;
            ListOption item;
            var options = OtherOptions;
            option = options["action"];

            // Add multi update
            item = option.Add("multiupdate");
            string updateTitle = Language.Phrase("UpdateSelectedLink", true);
            item.Body = $@"<button type=""button"" class=""ew-action ew-multi-update"" title=""{updateTitle}"" data-table=""tblStudents"" data-caption=""{updateTitle}"" form=""ftblStudentslist"" data-ew-action=""" +
                (ModalUpdate && !IsMobile() ? "modal" : "submit") + "\"" +
                (ModalUpdate && !IsMobile() ? " data-action=\"update\"" : "") +
                (UseAjaxActions ? " data-ajax=\"true\"" : "") +
                " data-url=\"" + HtmlEncode(AppPath(MultiUpdateUrl)) + "\">" + Language.Phrase("UpdateSelectedLink") + "</button>";
            item.Visible = Security.CanEdit;

            // Set up layout buttons/select all checkbox for multi column list page
            item = LayoutOptions.Add("cards");
            string classname = MultiColumnLayout == "cards" ? " disabled" : "";
            item.Body = "<button type=\"button\" class=\"btn btn-default " + classname + "\" title=\"" + Language.Phrase("MultiColumnCards", true) + "\" data-ew-action=\"layout\" data-layout=\"cards\" data-url=\"" + PageUrl + "\">" + Language.Phrase("MultiColumnCards") + "</button>";
            item.Visible = true;
            item = LayoutOptions.Add("table");
            classname = MultiColumnLayout == "table" ? " disabled" : "";
            item.Body = "<button type=\"button\" class=\"btn btn-default " + classname + "\" title=\"" + Language.Phrase("MultiColumnTable", true) + "\" data-ew-action=\"layout\" data-layout=\"table\" data-url=\"" + PageUrl + "\">" + Language.Phrase("MultiColumnTable") + "</button>";
            item.Visible = true;
            item = LayoutOptions.Add("checkbox");
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblStudentslist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
            item.ShowInButtonGroup = true;
            item.Visible = Security.CanEdit && ShowOptionLink("edit") && MultiColumnLayout == "cards";
            LayoutOptions.AddGroupOption();
            LayoutOptions.UseDropDownButton = false;
            LayoutOptions.UseButtonGroup = true;
            if (IsExport("print") || IsModal)
                LayoutOptions.HideAllOptions();

            // Set up options default
            foreach (var (key, opt) in options) {
                if (key != "column") { // Always use dropdown for column
                    opt.UseDropDownButton = true;
                    opt.UseButtonGroup = true;
                }
                //opt.ButtonClass = ""; // Class for button group
                item = opt.AddGroupOption();
                item.Body = "";
                item.Visible = false;
            }
            options["addedit"].DropDownButtonPhrase = "ButtonAddEdit";
            options["detail"].DropDownButtonPhrase = "ButtonDetails";
            options["action"].DropDownButtonPhrase = "ButtonActions";

            // Filter button
            item = FilterOptions.Add("savecurrentfilter");
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblStudentssrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblStudentssrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
            item.Visible = true;
            FilterOptions.UseDropDownButton = true;
            FilterOptions.UseButtonGroup = !FilterOptions.UseDropDownButton;
            FilterOptions.DropDownButtonPhrase = "Filters";

            // Add group option item
            item = FilterOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;
        }

        // Create new column option // DN
        public void CreateColumnOption(ListOption item)
        {
            var field = FieldByName(item.Name);
            if (field?.Visible ?? false) {
                item.Body = "<button class=\"dropdown-item\">" +
                    "<div class=\"form-check ew-dropdown-checkbox\">" +
                    "<div class=\"form-check-input ew-dropdown-check-input\" data-field=\"" + field.Param + "\"></div>" +
                    "<label class=\"form-check-label ew-dropdown-check-label\">" + field.Caption + "</label></div></button>";
            }
        }

        // Render other options
        public void RenderOtherOptions()
        {
            ListOptions option;
            ListOption? item;
            var options = OtherOptions;
                option = options["action"];

                // Set up list action buttons
                foreach (var (key, act) in ListActions.Items.Where(kvp => kvp.Value.Select == Config.ActionMultiple)) {
                    item = option.Add("custom_" + act.Action);
                    string caption = act.Caption;
                    var icon = (act.Icon != "") ? "<i class=\"" + HtmlEncode(act.Icon) + "\" data-caption=\"" + HtmlEncode(caption) + "\"></i>" + caption : caption;
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblStudentslist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
                    item.Visible = act.Allowed;
                }

                // Hide multi edit, grid edit and other options
                if (TotalRecords <= 0) {
                    option = options["addedit"];
                    option?["gridedit"]?.SetVisible(false);
                    option = options["action"];
                    option.HideAllOptions();
                }
        }

        // Process list action
        public async Task<IActionResult> ProcessListAction()
        {
            string userlist = "", user = "";
            string filter = GetFilterFromRecordKeys();
            string userAction = Post("action");
            if (filter != "" && userAction != "") {
                // Check permission first
                string actionCaption = userAction;
                foreach (var (key, act) in ListActions.Items) {
                    if (SameString(key, userAction)) {
                        actionCaption = act.Caption;
                        if (CustomActions.ContainsKey(userAction)) {
                            UserAction = userAction;
                            CurrentAction = "";
                        }
                        if (!act.Allowed) {
                            string errmsg = Language.Phrase("CustomActionNotAllowed").Replace("%s", actionCaption);
                            if (Post("ajax") == userAction) // Ajax
                                return Controller.Content("<p class=\"text-danger\">" + errmsg + "</p>", "text/plain", Encoding.UTF8);
                            else
                                FailureMessage = errmsg;
                            return new EmptyResult();
                        }
                    }
                }
                CurrentFilter = filter;
                string sql = CurrentSql;
                var rsuser = await Connection.GetRowsAsync(sql);
                ActionValue = Post("actionvalue");

                // Call row custom action event
                if (rsuser != null) {
                    if (UseTransaction)
                        Connection.BeginTrans();
                    bool processed = true;
                    SelectedCount = rsuser.Count();
                    SelectedIndex = 0;
                    foreach (var row in rsuser) {
                        SelectedIndex++;
                        user = ConvertToString(GetUserInfo(Config.LoginUsernameFieldName, row));
                        if (userlist != "")
                            userlist += ",";
                        userlist += user;
                        if (userAction == "resendregisteremail") {
                            processed = await SendRegisterEmail(row);
                        } else if (userAction == "resetconcurrentuser") {
                            processed = false;
                        } else if (userAction == "resetloginretry") {
                            processed = await Profile.ResetLoginRetry(user);
                        } else if (userAction == "setpasswordexpired") {
                            processed = false;
                        } else if (userAction == "resetusersecret") {
                            processed = false;
                        } else {
                            processed = RowCustomAction(userAction, row);
                        }
                        if (!processed)
                            break;
                    }
                    if (processed) {
                        if (UseTransaction)
                            Connection.CommitTrans(); // Commit the changes
                        if (userAction == "resendregisteremail")
                            SuccessMessage = Language.Phrase("ResendRegisterEmailSuccess").Replace("%u", userlist);
                        if (userAction == "resetloginretry")
                            SuccessMessage = Language.Phrase("ResetLoginRetrySuccess").Replace("%u", userlist);
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("CustomActionCompleted").Replace("%s", actionCaption); // Set up success message
                    } else {
                        if (UseTransaction)
                            Connection.RollbackTrans(); // Rollback changes
                        if (userAction == "resendregisteremail")
                            FailureMessage = Language.Phrase("ResendRegisterEmailFailure").Replace("%u", userlist);
                        if (userAction == "resetloginretry")
                            FailureMessage = Language.Phrase("ResetLoginRetryFailure").Replace("%u", user);

                        // Set up error message
                        if (!Empty(SuccessMessage) || !Empty(FailureMessage)) {
                            // Use the message, do nothing
                        } else if (!Empty(CancelMessage)) {
                            FailureMessage = CancelMessage;
                            CancelMessage = "";
                        } else {
                            FailureMessage = Language.Phrase("CustomActionFailed").Replace("%s", actionCaption);
                        }
                    }
                }
                CurrentAction = ""; // Clear action
                if (Post("ajax") == userAction) { // Ajax
                    if (ActionResult != null) // Action result set by Row CustomAction event // DN
                        return ActionResult;
                    string msg = "";
                    if (SuccessMessage != "") {
                        msg = "<p class=\"text-success\">" + SuccessMessage + "</p>";
                        ClearSuccessMessage(); // Clear message
                    }
                    if (FailureMessage != "") {
                        msg = "<p class=\"text-danger\">" + FailureMessage + "</p>";
                        ClearFailureMessage(); // Clear message
                    }
                    if (!Empty(msg))
                        return Controller.Content(msg, "text/plain", Encoding.UTF8);
                }
            }
            return new EmptyResult(); // Not ajax request
        }

        // Get multi-column row CSS class
        public string GetMultiColumnRowClass()
        {
            if (IsAddOrEdit && (RowType == RowType.Add || RowType == RowType.Edit))
                return "row"; // Full row
            return "row row-cols-1 " + MultiColumnGridClass + " g-4 ew-multi-column-row";
        }

        // Get multi-column col-* CSS class
        public string GetMultiColumnColClass()
        {
            if (IsAddOrEdit && (RowType == RowType.Add || RowType == RowType.Edit))
                return MultiColumnEditClass; // Full row
            return "col";
        }

        // Set up Grid
        public async Task SetupGrid()
        {
            if (ExportAll && IsExport()) {
                StopRecord = TotalRecords;
            } else {
                // Set the last record to display
                if (TotalRecords > StartRecord + DisplayRecords - 1) {
                    StopRecord = StartRecord + DisplayRecords - 1;
                } else {
                    StopRecord = TotalRecords;
                }
            }
            if (Recordset != null && Recordset.HasRows) {
                if (!Connection.SelectOffset) { // DN
                    for (int i = 1; i <= StartRecord - 1; i++) { // Move to first record
                        if (await Recordset.ReadAsync())
                            RecordCount++;
                    }
                } else {
                    RecordCount = StartRecord - 1;
                }
            } else if (IsGridAdd && !AllowAddDeleteRow && StopRecord == 0) { // Grid-Add with no records
                StopRecord = GridAddRowCount;
            } else if (IsAdd && TotalRecords == 0) { // Inline-Add with no records
                StopRecord = 1;
            }

            // Initialize aggregate
            RowType = RowType.AggregateInit;
            ResetAttributes();
            await RenderRow();
            if ((IsGridAdd || IsGridEdit) && MultiColumnLayout == "table") // Render template row first
                RowIndex = "$rowindex$";
        }

        // Set up Row
        public async Task SetupRow()
        {
            if (IsGridAdd || IsGridEdit) {
                if (SameString(RowIndex, "$rowindex$")) { // Render template row first
                    await LoadRowValues();

                    // Set row properties
                    ResetAttributes();
                    RowAttrs.Add("data-rowindex", ConvertToString(RowIndex));
                    RowAttrs.Add("id", "r0_tblStudents");
                    RowAttrs.Add("data-rowtype", ConvertToString((int)RowType.Add));
                    RowAttrs.Add("data-inline", (IsAdd || IsCopy || IsEdit) ? "true" : "false");
                    RowAttrs.AppendClass("ew-template");

                    // Render row
                    RowType = RowType.Add;
                    await RenderRow();

                    // Render list options
                    await RenderListOptions();

                    // Reset record count for template row
                    RecordCount--;
                    return;
                }
            }

            // Set up key count
            KeyCount = ConvertToInt(RowIndex);

            // Init row class and style
            ResetAttributes();
            CssClass = "";
            if (IsCopy && InlineRowCount == 0 && !await LoadRow()) { // Inline copy
                CurrentAction = "add";
            }
            if (IsAdd && InlineRowCount == 0 || IsGridAdd) {
                await LoadRowValues(); // Load default values
                OldKey = "";
                SetKey(OldKey);
            } else if (IsInlineInserted && UseInfiniteScroll) {
                // Nothing to do, just use current values
            } else if (!(IsCopy && InlineRowCount == 0)) {
                await LoadRowValues(Recordset); // Load row values
                if (IsGridEdit || IsMultiEdit) {
                    OldKey = GetKey(true); // Get from CurrentValue
                    SetKey(OldKey);
                }
            }
            RowType = RowType.View; // Render view
            if ((IsAdd || IsCopy) && InlineRowCount == 0 || IsGridAdd) // Add
                RowType = RowType.Add; // Render add

            // Inline Add/Copy row (row 0)
            if (RowType == RowType.Add && (IsAdd || IsCopy)) {
                InlineRowCount++;
                RecordCount--; // Reset record count for inline add/copy row
                if (TotalRecords == 0) // Reset stop record if no records
                    StopRecord = 0;
            } else {
                // Inline Edit row
                if (RowType == RowType.Edit && IsEdit)
                    InlineRowCount++;
                RowCount++; // Increment row count
            }

            // Set up row attributes
            RowAttrs.Add("data-rowindex", ConvertToString(tblStudentsList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblStudentsList.RowCount) + "_tblStudents");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblStudentsList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblStudentsList.RowType == RowType.Add || IsEdit && tblStudentsList.RowType == RowType.Edit) // Inline-Add/Edit row
                RowAttrs.AppendClass("table-active");

            // Render row
            await RenderRow();

            // Render list options
            await RenderListOptions();
        }

        // Load basic search values // DN
        protected void LoadBasicSearchValues() {
            if (Get(Config.TableBasicSearch, out StringValues keyword))
                BasicSearch.Keyword = keyword.ToString();
            if (!Empty(BasicSearch.Keyword) && Empty(Command))
                Command = "search";
            if (Get(Config.TableBasicSearchType, out StringValues type))
                BasicSearch.Type = type.ToString();
        }

        // Load search values for validation // DN
        protected void LoadSearchValues() {
            // Load query builder rules
            string rules = Post("rules");
            if (!Empty(rules) && Empty(Command)) {
                QueryRules = rules;
                Command = "search";
            }

            // int_Student_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Student_ID"))
                    int_Student_ID.AdvancedSearch.SearchValue = Get("x_int_Student_ID");
                else
                    int_Student_ID.AdvancedSearch.SearchValue = Get("int_Student_ID"); // Default Value // DN
            if (!Empty(int_Student_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Student_ID"))
                int_Student_ID.AdvancedSearch.SearchOperator = Get("z_int_Student_ID");

            // str_First_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_First_Name"))
                    str_First_Name.AdvancedSearch.SearchValue = Get("x_str_First_Name");
                else
                    str_First_Name.AdvancedSearch.SearchValue = Get("str_First_Name"); // Default Value // DN
            if (!Empty(str_First_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_First_Name"))
                str_First_Name.AdvancedSearch.SearchOperator = Get("z_str_First_Name");

            // str_Middle_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Middle_Name"))
                    str_Middle_Name.AdvancedSearch.SearchValue = Get("x_str_Middle_Name");
                else
                    str_Middle_Name.AdvancedSearch.SearchValue = Get("str_Middle_Name"); // Default Value // DN
            if (!Empty(str_Middle_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Middle_Name"))
                str_Middle_Name.AdvancedSearch.SearchOperator = Get("z_str_Middle_Name");

            // str_Last_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Last_Name"))
                    str_Last_Name.AdvancedSearch.SearchValue = Get("x_str_Last_Name");
                else
                    str_Last_Name.AdvancedSearch.SearchValue = Get("str_Last_Name"); // Default Value // DN
            if (!Empty(str_Last_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Last_Name"))
                str_Last_Name.AdvancedSearch.SearchOperator = Get("z_str_Last_Name");

            // str_Full_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Full_Name"))
                    str_Full_Name.AdvancedSearch.SearchValue = Get("x_str_Full_Name");
                else
                    str_Full_Name.AdvancedSearch.SearchValue = Get("str_Full_Name"); // Default Value // DN
            if (!Empty(str_Full_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Full_Name"))
                str_Full_Name.AdvancedSearch.SearchOperator = Get("z_str_Full_Name");

            // str_Address
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Address"))
                    str_Address.AdvancedSearch.SearchValue = Get("x_str_Address");
                else
                    str_Address.AdvancedSearch.SearchValue = Get("str_Address"); // Default Value // DN
            if (!Empty(str_Address.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Address"))
                str_Address.AdvancedSearch.SearchOperator = Get("z_str_Address");

            // str_City
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_City"))
                    str_City.AdvancedSearch.SearchValue = Get("x_str_City");
                else
                    str_City.AdvancedSearch.SearchValue = Get("str_City"); // Default Value // DN
            if (!Empty(str_City.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_City"))
                str_City.AdvancedSearch.SearchOperator = Get("z_str_City");

            // int_State
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_State"))
                    int_State.AdvancedSearch.SearchValue = Get("x_int_State");
                else
                    int_State.AdvancedSearch.SearchValue = Get("int_State"); // Default Value // DN
            if (!Empty(int_State.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_State"))
                int_State.AdvancedSearch.SearchOperator = Get("z_int_State");

            // str_Zip
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Zip"))
                    str_Zip.AdvancedSearch.SearchValue = Get("x_str_Zip");
                else
                    str_Zip.AdvancedSearch.SearchValue = Get("str_Zip"); // Default Value // DN
            if (!Empty(str_Zip.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Zip"))
                str_Zip.AdvancedSearch.SearchOperator = Get("z_str_Zip");

            // date_Hired
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Hired"))
                    date_Hired.AdvancedSearch.SearchValue = Get("x_date_Hired");
                else
                    date_Hired.AdvancedSearch.SearchValue = Get("date_Hired"); // Default Value // DN
            if (!Empty(date_Hired.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Hired"))
                date_Hired.AdvancedSearch.SearchOperator = Get("z_date_Hired");

            // date_Left
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Left"))
                    date_Left.AdvancedSearch.SearchValue = Get("x_date_Left");
                else
                    date_Left.AdvancedSearch.SearchValue = Get("date_Left"); // Default Value // DN
            if (!Empty(date_Left.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Left"))
                date_Left.AdvancedSearch.SearchOperator = Get("z_date_Left");

            // str_CertNumber
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_CertNumber"))
                    str_CertNumber.AdvancedSearch.SearchValue = Get("x_str_CertNumber");
                else
                    str_CertNumber.AdvancedSearch.SearchValue = Get("str_CertNumber"); // Default Value // DN
            if (!Empty(str_CertNumber.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_CertNumber"))
                str_CertNumber.AdvancedSearch.SearchOperator = Get("z_str_CertNumber");

            // date_CertExp
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_CertExp"))
                    date_CertExp.AdvancedSearch.SearchValue = Get("x_date_CertExp");
                else
                    date_CertExp.AdvancedSearch.SearchValue = Get("date_CertExp"); // Default Value // DN
            if (!Empty(date_CertExp.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_CertExp"))
                date_CertExp.AdvancedSearch.SearchOperator = Get("z_date_CertExp");

            // str_Cell_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Cell_Phone"))
                    str_Cell_Phone.AdvancedSearch.SearchValue = Get("x_str_Cell_Phone");
                else
                    str_Cell_Phone.AdvancedSearch.SearchValue = Get("str_Cell_Phone"); // Default Value // DN
            if (!Empty(str_Cell_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Cell_Phone"))
                str_Cell_Phone.AdvancedSearch.SearchOperator = Get("z_str_Cell_Phone");

            // str_Home_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Home_Phone"))
                    str_Home_Phone.AdvancedSearch.SearchValue = Get("x_str_Home_Phone");
                else
                    str_Home_Phone.AdvancedSearch.SearchValue = Get("str_Home_Phone"); // Default Value // DN
            if (!Empty(str_Home_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Home_Phone"))
                str_Home_Phone.AdvancedSearch.SearchOperator = Get("z_str_Home_Phone");

            // str_Other_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Other_Phone"))
                    str_Other_Phone.AdvancedSearch.SearchValue = Get("x_str_Other_Phone");
                else
                    str_Other_Phone.AdvancedSearch.SearchValue = Get("str_Other_Phone"); // Default Value // DN
            if (!Empty(str_Other_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Other_Phone"))
                str_Other_Phone.AdvancedSearch.SearchOperator = Get("z_str_Other_Phone");

            // str_Email
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Email"))
                    str_Email.AdvancedSearch.SearchValue = Get("x_str_Email");
                else
                    str_Email.AdvancedSearch.SearchValue = Get("str_Email"); // Default Value // DN
            if (!Empty(str_Email.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Email"))
                str_Email.AdvancedSearch.SearchOperator = Get("z_str_Email");

            // str_Code
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Code"))
                    str_Code.AdvancedSearch.SearchValue = Get("x_str_Code");
                else
                    str_Code.AdvancedSearch.SearchValue = Get("str_Code"); // Default Value // DN
            if (!Empty(str_Code.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Code"))
                str_Code.AdvancedSearch.SearchOperator = Get("z_str_Code");

            // str_Username
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Username"))
                    str_Username.AdvancedSearch.SearchValue = Get("x_str_Username");
                else
                    str_Username.AdvancedSearch.SearchValue = Get("str_Username"); // Default Value // DN
            if (!Empty(str_Username.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Username"))
                str_Username.AdvancedSearch.SearchOperator = Get("z_str_Username");

            // str_Password
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Password"))
                    str_Password.AdvancedSearch.SearchValue = Get("x_str_Password");
                else
                    str_Password.AdvancedSearch.SearchValue = Get("str_Password"); // Default Value // DN
            if (!Empty(str_Password.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Password"))
                str_Password.AdvancedSearch.SearchOperator = Get("z_str_Password");

            // date_Birth_Hijri
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Birth_Hijri"))
                    date_Birth_Hijri.AdvancedSearch.SearchValue = Get("x_date_Birth_Hijri");
                else
                    date_Birth_Hijri.AdvancedSearch.SearchValue = Get("date_Birth_Hijri"); // Default Value // DN
            if (!Empty(date_Birth_Hijri.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Birth_Hijri"))
                date_Birth_Hijri.AdvancedSearch.SearchOperator = Get("z_date_Birth_Hijri");

            // date_Birth
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Birth"))
                    date_Birth.AdvancedSearch.SearchValue = Get("x_date_Birth");
                else
                    date_Birth.AdvancedSearch.SearchValue = Get("date_Birth"); // Default Value // DN
            if (!Empty(date_Birth.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Birth"))
                date_Birth.AdvancedSearch.SearchOperator = Get("z_date_Birth");

            // Hijri_Year
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Hijri_Year"))
                    Hijri_Year.AdvancedSearch.SearchValue = Get("x_Hijri_Year");
                else
                    Hijri_Year.AdvancedSearch.SearchValue = Get("Hijri_Year"); // Default Value // DN
            if (!Empty(Hijri_Year.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Hijri_Year"))
                Hijri_Year.AdvancedSearch.SearchOperator = Get("z_Hijri_Year");

            // Hijri_Month
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Hijri_Month"))
                    Hijri_Month.AdvancedSearch.SearchValue = Get("x_Hijri_Month");
                else
                    Hijri_Month.AdvancedSearch.SearchValue = Get("Hijri_Month"); // Default Value // DN
            if (!Empty(Hijri_Month.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Hijri_Month"))
                Hijri_Month.AdvancedSearch.SearchOperator = Get("z_Hijri_Month");

            // Hijri_Day
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Hijri_Day"))
                    Hijri_Day.AdvancedSearch.SearchValue = Get("x_Hijri_Day");
                else
                    Hijri_Day.AdvancedSearch.SearchValue = Get("Hijri_Day"); // Default Value // DN
            if (!Empty(Hijri_Day.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Hijri_Day"))
                Hijri_Day.AdvancedSearch.SearchOperator = Get("z_Hijri_Day");

            // date_Started
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Started"))
                    date_Started.AdvancedSearch.SearchValue = Get("x_date_Started");
                else
                    date_Started.AdvancedSearch.SearchValue = Get("date_Started"); // Default Value // DN
            if (!Empty(date_Started.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Started"))
                date_Started.AdvancedSearch.SearchOperator = Get("z_date_Started");

            // str_DateHired
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_DateHired"))
                    str_DateHired.AdvancedSearch.SearchValue = Get("x_str_DateHired");
                else
                    str_DateHired.AdvancedSearch.SearchValue = Get("str_DateHired"); // Default Value // DN
            if (!Empty(str_DateHired.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_DateHired"))
                str_DateHired.AdvancedSearch.SearchOperator = Get("z_str_DateHired");

            // str_DateLeft
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_DateLeft"))
                    str_DateLeft.AdvancedSearch.SearchValue = Get("x_str_DateLeft");
                else
                    str_DateLeft.AdvancedSearch.SearchValue = Get("str_DateLeft"); // Default Value // DN
            if (!Empty(str_DateLeft.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_DateLeft"))
                str_DateLeft.AdvancedSearch.SearchOperator = Get("z_str_DateLeft");

            // str_Emergency_Contact_Name
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Emergency_Contact_Name"))
                    str_Emergency_Contact_Name.AdvancedSearch.SearchValue = Get("x_str_Emergency_Contact_Name");
                else
                    str_Emergency_Contact_Name.AdvancedSearch.SearchValue = Get("str_Emergency_Contact_Name"); // Default Value // DN
            if (!Empty(str_Emergency_Contact_Name.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Emergency_Contact_Name"))
                str_Emergency_Contact_Name.AdvancedSearch.SearchOperator = Get("z_str_Emergency_Contact_Name");

            // str_Emergency_Contact_Phone
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Emergency_Contact_Phone"))
                    str_Emergency_Contact_Phone.AdvancedSearch.SearchValue = Get("x_str_Emergency_Contact_Phone");
                else
                    str_Emergency_Contact_Phone.AdvancedSearch.SearchValue = Get("str_Emergency_Contact_Phone"); // Default Value // DN
            if (!Empty(str_Emergency_Contact_Phone.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Emergency_Contact_Phone"))
                str_Emergency_Contact_Phone.AdvancedSearch.SearchOperator = Get("z_str_Emergency_Contact_Phone");

            // str_Emergency_Contact_Relation
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Emergency_Contact_Relation"))
                    str_Emergency_Contact_Relation.AdvancedSearch.SearchValue = Get("x_str_Emergency_Contact_Relation");
                else
                    str_Emergency_Contact_Relation.AdvancedSearch.SearchValue = Get("str_Emergency_Contact_Relation"); // Default Value // DN
            if (!Empty(str_Emergency_Contact_Relation.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Emergency_Contact_Relation"))
                str_Emergency_Contact_Relation.AdvancedSearch.SearchOperator = Get("z_str_Emergency_Contact_Relation");

            // str_Notes
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Notes"))
                    str_Notes.AdvancedSearch.SearchValue = Get("x_str_Notes");
                else
                    str_Notes.AdvancedSearch.SearchValue = Get("str_Notes"); // Default Value // DN
            if (!Empty(str_Notes.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Notes"))
                str_Notes.AdvancedSearch.SearchOperator = Get("z_str_Notes");

            // int_ClassType
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_ClassType"))
                    int_ClassType.AdvancedSearch.SearchValue = Get("x_int_ClassType");
                else
                    int_ClassType.AdvancedSearch.SearchValue = Get("int_ClassType"); // Default Value // DN
            if (!Empty(int_ClassType.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_ClassType"))
                int_ClassType.AdvancedSearch.SearchOperator = Get("z_int_ClassType");

            // str_ZipCodes
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_ZipCodes"))
                    str_ZipCodes.AdvancedSearch.SearchValue = Get("x_str_ZipCodes");
                else
                    str_ZipCodes.AdvancedSearch.SearchValue = Get("str_ZipCodes"); // Default Value // DN
            if (!Empty(str_ZipCodes.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_ZipCodes"))
                str_ZipCodes.AdvancedSearch.SearchOperator = Get("z_str_ZipCodes");

            // int_VehicleAssigned
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_VehicleAssigned"))
                    int_VehicleAssigned.AdvancedSearch.SearchValue = Get("x_int_VehicleAssigned");
                else
                    int_VehicleAssigned.AdvancedSearch.SearchValue = Get("int_VehicleAssigned"); // Default Value // DN
            if (!Empty(int_VehicleAssigned.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_VehicleAssigned"))
                int_VehicleAssigned.AdvancedSearch.SearchOperator = Get("z_int_VehicleAssigned");

            // int_Status
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Status"))
                    int_Status.AdvancedSearch.SearchValue = Get("x_int_Status");
                else
                    int_Status.AdvancedSearch.SearchValue = Get("int_Status"); // Default Value // DN
            if (!Empty(int_Status.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Status"))
                int_Status.AdvancedSearch.SearchOperator = Get("z_int_Status");

            // int_Type
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Type"))
                    int_Type.AdvancedSearch.SearchValue = Get("x_int_Type");
                else
                    int_Type.AdvancedSearch.SearchValue = Get("int_Type"); // Default Value // DN
            if (!Empty(int_Type.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Type"))
                int_Type.AdvancedSearch.SearchOperator = Get("z_int_Type");

            // int_Location
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Location"))
                    int_Location.AdvancedSearch.SearchValue = Get("x_int_Location");
                else
                    int_Location.AdvancedSearch.SearchValue = Get("int_Location"); // Default Value // DN
            if (!Empty(int_Location.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Location"))
                int_Location.AdvancedSearch.SearchOperator = Get("z_int_Location");

            // date_Created
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Created"))
                    date_Created.AdvancedSearch.SearchValue = Get("x_date_Created");
                else
                    date_Created.AdvancedSearch.SearchValue = Get("date_Created"); // Default Value // DN
            if (!Empty(date_Created.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Created"))
                date_Created.AdvancedSearch.SearchOperator = Get("z_date_Created");

            // date_Modified
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_Modified"))
                    date_Modified.AdvancedSearch.SearchValue = Get("x_date_Modified");
                else
                    date_Modified.AdvancedSearch.SearchValue = Get("date_Modified"); // Default Value // DN
            if (!Empty(date_Modified.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_Modified"))
                date_Modified.AdvancedSearch.SearchOperator = Get("z_date_Modified");

            // int_Created_By
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Created_By"))
                    int_Created_By.AdvancedSearch.SearchValue = Get("x_int_Created_By");
                else
                    int_Created_By.AdvancedSearch.SearchValue = Get("int_Created_By"); // Default Value // DN
            if (!Empty(int_Created_By.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Created_By"))
                int_Created_By.AdvancedSearch.SearchOperator = Get("z_int_Created_By");

            // int_Modified_By
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Modified_By"))
                    int_Modified_By.AdvancedSearch.SearchValue = Get("x_int_Modified_By");
                else
                    int_Modified_By.AdvancedSearch.SearchValue = Get("int_Modified_By"); // Default Value // DN
            if (!Empty(int_Modified_By.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Modified_By"))
                int_Modified_By.AdvancedSearch.SearchOperator = Get("z_int_Modified_By");

            // bit_IsDeleted
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_IsDeleted"))
                    bit_IsDeleted.AdvancedSearch.SearchValue = Get("x_bit_IsDeleted");
                else
                    bit_IsDeleted.AdvancedSearch.SearchValue = Get("bit_IsDeleted"); // Default Value // DN
            if (!Empty(bit_IsDeleted.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_IsDeleted"))
                bit_IsDeleted.AdvancedSearch.SearchOperator = Get("z_bit_IsDeleted");

            // str_InstPermitNo
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_InstPermitNo"))
                    str_InstPermitNo.AdvancedSearch.SearchValue = Get("x_str_InstPermitNo");
                else
                    str_InstPermitNo.AdvancedSearch.SearchValue = Get("str_InstPermitNo"); // Default Value // DN
            if (!Empty(str_InstPermitNo.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_InstPermitNo"))
                str_InstPermitNo.AdvancedSearch.SearchOperator = Get("z_str_InstPermitNo");

            // date_PermitExpiration
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_PermitExpiration"))
                    date_PermitExpiration.AdvancedSearch.SearchValue = Get("x_date_PermitExpiration");
                else
                    date_PermitExpiration.AdvancedSearch.SearchValue = Get("date_PermitExpiration"); // Default Value // DN
            if (!Empty(date_PermitExpiration.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_PermitExpiration"))
                date_PermitExpiration.AdvancedSearch.SearchOperator = Get("z_date_PermitExpiration");

            // date_InCarPermitIssue
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_InCarPermitIssue"))
                    date_InCarPermitIssue.AdvancedSearch.SearchValue = Get("x_date_InCarPermitIssue");
                else
                    date_InCarPermitIssue.AdvancedSearch.SearchValue = Get("date_InCarPermitIssue"); // Default Value // DN
            if (!Empty(date_InCarPermitIssue.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_InCarPermitIssue"))
                date_InCarPermitIssue.AdvancedSearch.SearchOperator = Get("z_date_InCarPermitIssue");

            // str_InClassPermitNo
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_InClassPermitNo"))
                    str_InClassPermitNo.AdvancedSearch.SearchValue = Get("x_str_InClassPermitNo");
                else
                    str_InClassPermitNo.AdvancedSearch.SearchValue = Get("str_InClassPermitNo"); // Default Value // DN
            if (!Empty(str_InClassPermitNo.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_InClassPermitNo"))
                str_InClassPermitNo.AdvancedSearch.SearchOperator = Get("z_str_InClassPermitNo");

            // date_InClassPermitIssue
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_date_InClassPermitIssue"))
                    date_InClassPermitIssue.AdvancedSearch.SearchValue = Get("x_date_InClassPermitIssue");
                else
                    date_InClassPermitIssue.AdvancedSearch.SearchValue = Get("date_InClassPermitIssue"); // Default Value // DN
            if (!Empty(date_InClassPermitIssue.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_date_InClassPermitIssue"))
                date_InClassPermitIssue.AdvancedSearch.SearchOperator = Get("z_date_InClassPermitIssue");

            // instructor_caption
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_instructor_caption"))
                    instructor_caption.AdvancedSearch.SearchValue = Get("x_instructor_caption");
                else
                    instructor_caption.AdvancedSearch.SearchValue = Get("instructor_caption"); // Default Value // DN
            if (!Empty(instructor_caption.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_instructor_caption"))
                instructor_caption.AdvancedSearch.SearchOperator = Get("z_instructor_caption");

            // str_LicType
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_LicType"))
                    str_LicType.AdvancedSearch.SearchValue = Get("x_str_LicType");
                else
                    str_LicType.AdvancedSearch.SearchValue = Get("str_LicType"); // Default Value // DN
            if (!Empty(str_LicType.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_LicType"))
                str_LicType.AdvancedSearch.SearchOperator = Get("z_str_LicType");

            // int_Order
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Order"))
                    int_Order.AdvancedSearch.SearchValue = Get("x_int_Order");
                else
                    int_Order.AdvancedSearch.SearchValue = Get("int_Order"); // Default Value // DN
            if (!Empty(int_Order.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Order"))
                int_Order.AdvancedSearch.SearchOperator = Get("z_int_Order");

            // str_InstLicenceDate
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_InstLicenceDate"))
                    str_InstLicenceDate.AdvancedSearch.SearchValue = Get("x_str_InstLicenceDate");
                else
                    str_InstLicenceDate.AdvancedSearch.SearchValue = Get("str_InstLicenceDate"); // Default Value // DN
            if (!Empty(str_InstLicenceDate.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_InstLicenceDate"))
                str_InstLicenceDate.AdvancedSearch.SearchOperator = Get("z_str_InstLicenceDate");

            // str_DLNum
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_DLNum"))
                    str_DLNum.AdvancedSearch.SearchValue = Get("x_str_DLNum");
                else
                    str_DLNum.AdvancedSearch.SearchValue = Get("str_DLNum"); // Default Value // DN
            if (!Empty(str_DLNum.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_DLNum"))
                str_DLNum.AdvancedSearch.SearchOperator = Get("z_str_DLNum");

            // str_DLExp
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_DLExp"))
                    str_DLExp.AdvancedSearch.SearchValue = Get("x_str_DLExp");
                else
                    str_DLExp.AdvancedSearch.SearchValue = Get("str_DLExp"); // Default Value // DN
            if (!Empty(str_DLExp.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_DLExp"))
                str_DLExp.AdvancedSearch.SearchOperator = Get("z_str_DLExp");

            // bit_appointmentColor
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_appointmentColor"))
                    bit_appointmentColor.AdvancedSearch.SearchValue = Get("x_bit_appointmentColor");
                else
                    bit_appointmentColor.AdvancedSearch.SearchValue = Get("bit_appointmentColor"); // Default Value // DN
            if (!Empty(bit_appointmentColor.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_appointmentColor"))
                bit_appointmentColor.AdvancedSearch.SearchOperator = Get("z_bit_appointmentColor");

            // str_appointmentColorCode
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_appointmentColorCode"))
                    str_appointmentColorCode.AdvancedSearch.SearchValue = Get("x_str_appointmentColorCode");
                else
                    str_appointmentColorCode.AdvancedSearch.SearchValue = Get("str_appointmentColorCode"); // Default Value // DN
            if (!Empty(str_appointmentColorCode.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_appointmentColorCode"))
                str_appointmentColorCode.AdvancedSearch.SearchOperator = Get("z_str_appointmentColorCode");

            // bit_IsSuperAdmin
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_bit_IsSuperAdmin"))
                    bit_IsSuperAdmin.AdvancedSearch.SearchValue = Get("x_bit_IsSuperAdmin");
                else
                    bit_IsSuperAdmin.AdvancedSearch.SearchValue = Get("bit_IsSuperAdmin"); // Default Value // DN
            if (!Empty(bit_IsSuperAdmin.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_bit_IsSuperAdmin"))
                bit_IsSuperAdmin.AdvancedSearch.SearchOperator = Get("z_bit_IsSuperAdmin");

            // IsDistanceBasedScheduling
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_IsDistanceBasedScheduling"))
                    IsDistanceBasedScheduling.AdvancedSearch.SearchValue = Get("x_IsDistanceBasedScheduling");
                else
                    IsDistanceBasedScheduling.AdvancedSearch.SearchValue = Get("IsDistanceBasedScheduling"); // Default Value // DN
            if (!Empty(IsDistanceBasedScheduling.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_IsDistanceBasedScheduling"))
                IsDistanceBasedScheduling.AdvancedSearch.SearchOperator = Get("z_IsDistanceBasedScheduling");

            // str_Package_Code
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Package_Code"))
                    str_Package_Code.AdvancedSearch.SearchValue = Get("x_str_Package_Code");
                else
                    str_Package_Code.AdvancedSearch.SearchValue = Get("str_Package_Code"); // Default Value // DN
            if (!Empty(str_Package_Code.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Package_Code"))
                str_Package_Code.AdvancedSearch.SearchOperator = Get("z_str_Package_Code");

            // str_NationalID_Iqama
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_NationalID_Iqama"))
                    str_NationalID_Iqama.AdvancedSearch.SearchValue = Get("x_str_NationalID_Iqama");
                else
                    str_NationalID_Iqama.AdvancedSearch.SearchValue = Get("str_NationalID_Iqama"); // Default Value // DN
            if (!Empty(str_NationalID_Iqama.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_NationalID_Iqama"))
                str_NationalID_Iqama.AdvancedSearch.SearchOperator = Get("z_str_NationalID_Iqama");

            // NationalID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_NationalID"))
                    NationalID.AdvancedSearch.SearchValue = Get("x_NationalID");
                else
                    NationalID.AdvancedSearch.SearchValue = Get("NationalID"); // Default Value // DN
            if (!Empty(NationalID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_NationalID"))
                NationalID.AdvancedSearch.SearchOperator = Get("z_NationalID");

            // int_RoadDistanceCoverage
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_RoadDistanceCoverage"))
                    int_RoadDistanceCoverage.AdvancedSearch.SearchValue = Get("x_int_RoadDistanceCoverage");
                else
                    int_RoadDistanceCoverage.AdvancedSearch.SearchValue = Get("int_RoadDistanceCoverage"); // Default Value // DN
            if (!Empty(int_RoadDistanceCoverage.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_RoadDistanceCoverage"))
                int_RoadDistanceCoverage.AdvancedSearch.SearchOperator = Get("z_int_RoadDistanceCoverage");

            // str_Badge
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Badge"))
                    str_Badge.AdvancedSearch.SearchValue = Get("x_str_Badge");
                else
                    str_Badge.AdvancedSearch.SearchValue = Get("str_Badge"); // Default Value // DN
            if (!Empty(str_Badge.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Badge"))
                str_Badge.AdvancedSearch.SearchOperator = Get("z_str_Badge");

            // strZoomHostUrl
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strZoomHostUrl"))
                    strZoomHostUrl.AdvancedSearch.SearchValue = Get("x_strZoomHostUrl");
                else
                    strZoomHostUrl.AdvancedSearch.SearchValue = Get("strZoomHostUrl"); // Default Value // DN
            if (!Empty(strZoomHostUrl.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strZoomHostUrl"))
                strZoomHostUrl.AdvancedSearch.SearchOperator = Get("z_strZoomHostUrl");

            // strZoomUserUrl
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_strZoomUserUrl"))
                    strZoomUserUrl.AdvancedSearch.SearchValue = Get("x_strZoomUserUrl");
                else
                    strZoomUserUrl.AdvancedSearch.SearchValue = Get("strZoomUserUrl"); // Default Value // DN
            if (!Empty(strZoomUserUrl.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_strZoomUserUrl"))
                strZoomUserUrl.AdvancedSearch.SearchOperator = Get("z_strZoomUserUrl");

            // str_VehicleType
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_VehicleType"))
                    str_VehicleType.AdvancedSearch.SearchValue = Get("x_str_VehicleType");
                else
                    str_VehicleType.AdvancedSearch.SearchValue = Get("str_VehicleType"); // Default Value // DN
            if (!Empty(str_VehicleType.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_VehicleType"))
                str_VehicleType.AdvancedSearch.SearchOperator = Get("z_str_VehicleType");

            // ProfilePicturePath
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_ProfilePicturePath"))
                    ProfilePicturePath.AdvancedSearch.SearchValue = Get("x_ProfilePicturePath");
                else
                    ProfilePicturePath.AdvancedSearch.SearchValue = Get("ProfilePicturePath"); // Default Value // DN
            if (!Empty(ProfilePicturePath.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_ProfilePicturePath"))
                ProfilePicturePath.AdvancedSearch.SearchOperator = Get("z_ProfilePicturePath");

            // Institution
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Institution"))
                    Institution.AdvancedSearch.SearchValue = Get("x_Institution");
                else
                    Institution.AdvancedSearch.SearchValue = Get("Institution"); // Default Value // DN
            if (!Empty(Institution.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Institution"))
                Institution.AdvancedSearch.SearchOperator = Get("z_Institution");

            // IsDrivingexperience
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_IsDrivingexperience"))
                    IsDrivingexperience.AdvancedSearch.SearchValue = Get("x_IsDrivingexperience");
                else
                    IsDrivingexperience.AdvancedSearch.SearchValue = Get("IsDrivingexperience"); // Default Value // DN
            if (!Empty(IsDrivingexperience.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_IsDrivingexperience"))
                IsDrivingexperience.AdvancedSearch.SearchOperator = Get("z_IsDrivingexperience");

            // intDrivinglicenseType
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_intDrivinglicenseType[]"))
                    intDrivinglicenseType.AdvancedSearch.SearchValue = Get("x_intDrivinglicenseType[]");
                else
                    intDrivinglicenseType.AdvancedSearch.SearchValue = Get("intDrivinglicenseType"); // Default Value // DN
            if (!Empty(intDrivinglicenseType.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchOperator = Get("z_intDrivinglicenseType");
            if (Query.ContainsKey("v_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchCondition = Get("v_intDrivinglicenseType");
            if (Query.ContainsKey("y_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchValue2 = Get("y_intDrivinglicenseType");
            if (!Empty(intDrivinglicenseType.AdvancedSearch.SearchValue2) && Command == "")
                Command = "search";
            if (Query.ContainsKey("w_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchOperator2 = Get("w_intDrivinglicenseType");

            // AbsherApptNbr
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AbsherApptNbr"))
                    AbsherApptNbr.AdvancedSearch.SearchValue = Get("x_AbsherApptNbr");
                else
                    AbsherApptNbr.AdvancedSearch.SearchValue = Get("AbsherApptNbr"); // Default Value // DN
            if (!Empty(AbsherApptNbr.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AbsherApptNbr"))
                AbsherApptNbr.AdvancedSearch.SearchOperator = Get("z_AbsherApptNbr");

            // Absherphoto
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Absherphoto"))
                    Absherphoto.AdvancedSearch.SearchValue = Get("x_Absherphoto");
                else
                    Absherphoto.AdvancedSearch.SearchValue = Get("Absherphoto"); // Default Value // DN
            if (!Empty(Absherphoto.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Absherphoto"))
                Absherphoto.AdvancedSearch.SearchOperator = Get("z_Absherphoto");

            // Fingerprint
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Fingerprint"))
                    Fingerprint.AdvancedSearch.SearchValue = Get("x_Fingerprint");
                else
                    Fingerprint.AdvancedSearch.SearchValue = Get("Fingerprint"); // Default Value // DN
            if (!Empty(Fingerprint.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Fingerprint"))
                Fingerprint.AdvancedSearch.SearchOperator = Get("z_Fingerprint");

            // ProfileField
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_ProfileField"))
                    ProfileField.AdvancedSearch.SearchValue = Get("x_ProfileField");
                else
                    ProfileField.AdvancedSearch.SearchValue = Get("ProfileField"); // Default Value // DN
            if (!Empty(ProfileField.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_ProfileField"))
                ProfileField.AdvancedSearch.SearchOperator = Get("z_ProfileField");

            // UserlevelID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_UserlevelID"))
                    UserlevelID.AdvancedSearch.SearchValue = Get("x_UserlevelID");
                else
                    UserlevelID.AdvancedSearch.SearchValue = Get("UserlevelID"); // Default Value // DN
            if (!Empty(UserlevelID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_UserlevelID"))
                UserlevelID.AdvancedSearch.SearchOperator = Get("z_UserlevelID");

            // Parent_Username
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Parent_Username"))
                    Parent_Username.AdvancedSearch.SearchValue = Get("x_Parent_Username");
                else
                    Parent_Username.AdvancedSearch.SearchValue = Get("Parent_Username"); // Default Value // DN
            if (!Empty(Parent_Username.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Parent_Username"))
                Parent_Username.AdvancedSearch.SearchOperator = Get("z_Parent_Username");

            // Activated
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Activated"))
                    Activated.AdvancedSearch.SearchValue = Get("x_Activated");
                else
                    Activated.AdvancedSearch.SearchValue = Get("Activated"); // Default Value // DN
            if (!Empty(Activated.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Activated"))
                Activated.AdvancedSearch.SearchOperator = Get("z_Activated");

            // int_Nationality
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Nationality"))
                    int_Nationality.AdvancedSearch.SearchValue = Get("x_int_Nationality");
                else
                    int_Nationality.AdvancedSearch.SearchValue = Get("int_Nationality"); // Default Value // DN
            if (!Empty(int_Nationality.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Nationality"))
                int_Nationality.AdvancedSearch.SearchOperator = Get("z_int_Nationality");

            // User_Role
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_User_Role"))
                    User_Role.AdvancedSearch.SearchValue = Get("x_User_Role");
                else
                    User_Role.AdvancedSearch.SearchValue = Get("User_Role"); // Default Value // DN
            if (!Empty(User_Role.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_User_Role"))
                User_Role.AdvancedSearch.SearchOperator = Get("z_User_Role");

            // int_Staff_Id
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_int_Staff_Id"))
                    int_Staff_Id.AdvancedSearch.SearchValue = Get("x_int_Staff_Id");
                else
                    int_Staff_Id.AdvancedSearch.SearchValue = Get("int_Staff_Id"); // Default Value // DN
            if (!Empty(int_Staff_Id.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_int_Staff_Id"))
                int_Staff_Id.AdvancedSearch.SearchOperator = Get("z_int_Staff_Id");
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

            // int_Student_ID

            // str_First_Name

            // str_Middle_Name

            // str_Last_Name

            // str_Full_Name
            str_Full_Name.CellCssStyle = "white-space: nowrap;";

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
            IsDrivingexperience.CellCssStyle = "white-space: nowrap;";

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

            // Preview field row
            if (RowType == RowType.PreviewField) {
                // str_Full_Name
                str_Full_Name.ViewValue = ConvertToString(str_Full_Name.CurrentValue); // DN
                str_Full_Name.ViewCustomAttributes = "";
            }

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

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // str_Email
                str_Email.HrefValue = "";
                str_Email.TooltipValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";
                str_NationalID_Iqama.TooltipValue = "";

                // intDrivinglicenseType
                intDrivinglicenseType.HrefValue = "";
                intDrivinglicenseType.TooltipValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";
                AbsherApptNbr.TooltipValue = "";
            } else if (RowType == RowType.Search) {
                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.AdvancedSearch.SearchValue = HtmlDecode(str_First_Name.AdvancedSearch.SearchValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.AdvancedSearch.SearchValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Cell_Phone.AdvancedSearch.SearchValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.AdvancedSearch.SearchValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

                // str_Email
                str_Email.SetupEditAttributes();
                if (!str_Email.Raw)
                    str_Email.AdvancedSearch.SearchValue = HtmlDecode(str_Email.AdvancedSearch.SearchValue);
                str_Email.EditValue = HtmlEncode(str_Email.AdvancedSearch.SearchValue);
                str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

                // str_NationalID_Iqama
                str_NationalID_Iqama.SetupEditAttributes();
                if (!str_NationalID_Iqama.Raw)
                    str_NationalID_Iqama.AdvancedSearch.SearchValue = HtmlDecode(str_NationalID_Iqama.AdvancedSearch.SearchValue);
                str_NationalID_Iqama.EditValue = HtmlEncode(str_NationalID_Iqama.AdvancedSearch.SearchValue);
                str_NationalID_Iqama.PlaceHolder = RemoveHtml(str_NationalID_Iqama.Caption);

                // intDrivinglicenseType
                if (intDrivinglicenseType.UseFilter && !Empty(intDrivinglicenseType.AdvancedSearch.SearchValue)) {
                    intDrivinglicenseType.EditValue = ConvertToString(intDrivinglicenseType.AdvancedSearch.SearchValue).Split(Config.MultipleOptionSeparator).ToList();
                }
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue2 = intDrivinglicenseType.Options(true);
                intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);

                // AbsherApptNbr
                AbsherApptNbr.SetupEditAttributes();
                if (!AbsherApptNbr.Raw)
                    AbsherApptNbr.AdvancedSearch.SearchValue = HtmlDecode(AbsherApptNbr.AdvancedSearch.SearchValue);
                AbsherApptNbr.EditValue = HtmlEncode(AbsherApptNbr.AdvancedSearch.SearchValue);
                AbsherApptNbr.PlaceHolder = RemoveHtml(AbsherApptNbr.Caption);
            }
            if (RowType == RowType.Add || RowType == RowType.Edit || RowType == RowType.Search) // Add/Edit/Search row
                SetupFieldTitles();

            // Call Row Rendered event
            if (RowType != RowType.AggregateInit)
                RowRendered();
        }
        #pragma warning restore 1998

        // Validate search
        protected bool ValidateSearch() {
            // Check if validation required
            if (!Config.ServerValidate)
                return true;

            // Return validate result
            bool validateSearch = !HasInvalidFields();

            // Call Form CustomValidate event
            string formCustomError = "";
            validateSearch = validateSearch && FormCustomValidate(ref formCustomError);
            if (!Empty(formCustomError))
                FailureMessage = formCustomError;
            return validateSearch;
        }

        // Load advanced search
        public void LoadAdvancedSearch()
        {
            int_Student_ID.AdvancedSearch.Load();
            str_First_Name.AdvancedSearch.Load();
            str_Middle_Name.AdvancedSearch.Load();
            str_Last_Name.AdvancedSearch.Load();
            str_Full_Name.AdvancedSearch.Load();
            str_Address.AdvancedSearch.Load();
            str_City.AdvancedSearch.Load();
            int_State.AdvancedSearch.Load();
            str_Zip.AdvancedSearch.Load();
            date_Hired.AdvancedSearch.Load();
            date_Left.AdvancedSearch.Load();
            str_CertNumber.AdvancedSearch.Load();
            date_CertExp.AdvancedSearch.Load();
            str_Cell_Phone.AdvancedSearch.Load();
            str_Home_Phone.AdvancedSearch.Load();
            str_Other_Phone.AdvancedSearch.Load();
            str_Email.AdvancedSearch.Load();
            str_Code.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            str_Password.AdvancedSearch.Load();
            date_Birth_Hijri.AdvancedSearch.Load();
            date_Birth.AdvancedSearch.Load();
            Hijri_Year.AdvancedSearch.Load();
            Hijri_Month.AdvancedSearch.Load();
            Hijri_Day.AdvancedSearch.Load();
            date_Started.AdvancedSearch.Load();
            str_DateHired.AdvancedSearch.Load();
            str_DateLeft.AdvancedSearch.Load();
            str_Emergency_Contact_Name.AdvancedSearch.Load();
            str_Emergency_Contact_Phone.AdvancedSearch.Load();
            str_Emergency_Contact_Relation.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            int_ClassType.AdvancedSearch.Load();
            str_ZipCodes.AdvancedSearch.Load();
            int_VehicleAssigned.AdvancedSearch.Load();
            int_Status.AdvancedSearch.Load();
            int_Type.AdvancedSearch.Load();
            int_Location.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            int_Created_By.AdvancedSearch.Load();
            int_Modified_By.AdvancedSearch.Load();
            bit_IsDeleted.AdvancedSearch.Load();
            str_InstPermitNo.AdvancedSearch.Load();
            date_PermitExpiration.AdvancedSearch.Load();
            date_InCarPermitIssue.AdvancedSearch.Load();
            str_InClassPermitNo.AdvancedSearch.Load();
            date_InClassPermitIssue.AdvancedSearch.Load();
            instructor_caption.AdvancedSearch.Load();
            str_LicType.AdvancedSearch.Load();
            int_Order.AdvancedSearch.Load();
            str_InstLicenceDate.AdvancedSearch.Load();
            str_DLNum.AdvancedSearch.Load();
            str_DLExp.AdvancedSearch.Load();
            bit_appointmentColor.AdvancedSearch.Load();
            str_appointmentColorCode.AdvancedSearch.Load();
            bit_IsSuperAdmin.AdvancedSearch.Load();
            IsDistanceBasedScheduling.AdvancedSearch.Load();
            str_Package_Code.AdvancedSearch.Load();
            str_NationalID_Iqama.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            int_RoadDistanceCoverage.AdvancedSearch.Load();
            str_Badge.AdvancedSearch.Load();
            strZoomHostUrl.AdvancedSearch.Load();
            strZoomUserUrl.AdvancedSearch.Load();
            str_VehicleType.AdvancedSearch.Load();
            ProfilePicturePath.AdvancedSearch.Load();
            Institution.AdvancedSearch.Load();
            IsDrivingexperience.AdvancedSearch.Load();
            intDrivinglicenseType.AdvancedSearch.Load();
            AbsherApptNbr.AdvancedSearch.Load();
            Absherphoto.AdvancedSearch.Load();
            Fingerprint.AdvancedSearch.Load();
            ProfileField.AdvancedSearch.Load();
            UserlevelID.AdvancedSearch.Load();
            Parent_Username.AdvancedSearch.Load();
            Activated.AdvancedSearch.Load();
            int_Nationality.AdvancedSearch.Load();
            User_Role.AdvancedSearch.Load();
            int_Staff_Id.AdvancedSearch.Load();
        }

        // Get export HTML tag
        protected string GetExportTag(string type, bool custom = false) {
            string exportUrl = AppPath(CurrentPageName()); // DN
            if (type == "print" || custom) { // Printer friendly / custom export
                exportUrl += "?export=" + type + (custom ? "&amp;custom=1" : "");
            } else {
                exportUrl = AppPath(Config.ApiUrl + Config.ApiExportAction + "/" + type + "/" + TableVar);
            }
            if (SameText(type, "excel")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblStudentslist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblStudentslist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblStudentslist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblStudentslist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            if (!Security.CanExport) // Export not allowed
                ExportOptions.HideAllOptions();
        }

        // Set up search options
        protected void SetupSearchOptions() {
            ListOption item;

            // Search button
            item = SearchOptions.Add("searchtoggle");
            var searchToggleClass = !Empty(SearchWhere) ? " active" : " active";
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblStudentssrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
            item.Visible = true;

            // Show all button
            item = SearchOptions.Add("showall");
            if (UseCustomTemplate || !UseAjaxActions)
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ShowAll") + "\" data-caption=\"" + Language.Phrase("ShowAll") + "\" href=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ShowAllBtn") + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ShowAll") + "\" data-caption=\"" + Language.Phrase("ShowAll") + "\" data-ew-action=\"refresh\" data-url=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ShowAllBtn") + "</a>";
            item.Visible = (SearchWhere != DefaultSearchWhere && SearchWhere != "0=101");

            // Button group for search
            SearchOptions.UseDropDownButton = false;
            SearchOptions.UseButtonGroup = true;
            SearchOptions.DropDownButtonPhrase = "ButtonSearch";

            // Add group option item
            item = SearchOptions.AddGroupOption();
            item.Body = "";
            item.Visible = false;

            // Hide search options
            if (IsExport() || !Empty(CurrentAction) && CurrentAction != "search")
                SearchOptions.HideAllOptions();
            if (!Security.CanSearch) {
                SearchOptions.HideAllOptions();
                FilterOptions.HideAllOptions();
            }
        }

        // Check if any search fields
        public bool HasSearchFields()
        {
            return true;
        }

        // Render search options
        protected void RenderSearchOptions()
        {
            if (!HasSearchFields() && SearchOptions["searchtoggle"] is ListOption opt)
                opt.Visible = false;
        }

        #pragma warning disable 168

        /// <summary>
        /// Export data
        /// </summary>
        public async Task ExportData(dynamic? doc)
        {
            // Load recordset // DN
            DbDataReader? dr = null;
            if (TotalRecords < 0)
                TotalRecords = await ListRecordCountAsync();
            StartRecord = 1;

            // Export all
            if (ExportAll) {
                DisplayRecords = TotalRecords;
                StopRecord = TotalRecords;
            } else { // Export one page only
                SetupStartRecord(); // Set up start record position
                // Set the last record to display
                if (DisplayRecords < 0) {
                    StopRecord = TotalRecords;
                } else {
                    StopRecord = StartRecord + DisplayRecords - 1;
                }
            }
            CloseRecordset(); // DN
            dr = await LoadRecordset(StartRecord - 1, (DisplayRecords <= 0) ? TotalRecords : DisplayRecords); // DN
            if (doc == null) { // DN
                RemoveHeader("Content-Type"); // Remove header
                RemoveHeader("Content-Disposition");
                FailureMessage = Language.Phrase("ExportClassNotFound"); // Export class not found
                return;
            }

            // Call Page Exporting server event
            doc.ExportCustom = !PageExporting(ref doc);

            // Page header
            string header = PageHeader;
            PageDataRendering(ref header);
            doc.Text.Append(header);

            // Export
            if (dr != null)
                await ExportDocument(doc, dr, StartRecord, StopRecord, "");

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

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            url = Regex.Replace(url, @"\?cmd=reset(all)?$", ""); // Remove cmd=reset / cmd=resetall
            breadcrumb.Add("list", TableVar, url, "", TableVar, true);
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

        // Set up starting record parameters
        public void SetupStartRecord()
        {
            // Exit if DisplayRecords = 0
            if (DisplayRecords == 0)
                return;
            string pageNo = Get(Config.TablePageNumber);
            string startRec = Get(Config.TableStartRec);
            bool infiniteScroll = false;
            infiniteScroll = Param<bool>("infinitescroll");
            if (!Empty(pageNo) && IsNumeric(pageNo)) {
                int page = ConvertToInt(pageNo);
                StartRecord = (page - 1) * DisplayRecords + 1;
                if (StartRecord <= 0)
                    StartRecord = 1;
                else if (StartRecord >= ((TotalRecords - 1) / DisplayRecords) * DisplayRecords + 1)
                    StartRecord = ((TotalRecords - 1) / DisplayRecords) * DisplayRecords + 1;
            } else if (!Empty(startRec) && IsNumeric(startRec)) {
                StartRecord = ConvertToInt(startRec);
            } else if (!infiniteScroll) {
                StartRecord = StartRecordNumber;
            }

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

        // ListOptions Load event
        public virtual void ListOptionsLoad() {
            // Example:
            //var opt = ListOptions.Add("new");
            //opt.Header = "xxx";
            //opt.OnLeft = true; // Link on left
            //opt.MoveTo(0); // Move to first column
        }

        // ListOptions Rendering event
        public virtual void ListOptionsRendering() {
            //xxxGrid.DetailAdd = (...condition...); // Set to true or false conditionally
            //xxxGrid.DetailEdit = (...condition...); // Set to true or false conditionally
            //xxxGrid.DetailView = (...condition...); // Set to true or false conditionally
        }

        // ListOptions Rendered event
        public virtual void ListOptionsRendered() {
            //Example:
            //ListOptions["new"].Body = "xxx";
        }

        // Row Custom Action event
        public virtual bool RowCustomAction(string action, Dictionary<string, object> row) {
            // Return false to abort
            return true;
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

        // Grid Inserting event
        public virtual bool GridInserting() {
            // Enter your code here
            // To reject grid insert, set return value to false
            return true;
        }

        // Grid Inserted event
        public virtual void GridInserted(List<Dictionary<string, object>> rsnew) {
            //Log("Grid Inserted");
        }

        // Grid Updating event
        public virtual bool GridUpdating(List<Dictionary<string, object>> rsold) {
            // Enter your code here
            // To reject grid update, set return value to false
            return true;
        }

        // Grid Updated event
        public virtual void GridUpdated(List<Dictionary<string, object>> rsold, List<Dictionary<string, object>> rsnew) {
            //Log("Grid Updated");
        }
    } // End page class
} // End Partial class
