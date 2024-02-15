namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblEvaluationMbGrid
    /// </summary>
    public static TblEvaluationMbGrid tblEvaluationMbGrid
    {
        get => HttpData.Get<TblEvaluationMbGrid>("tblEvaluationMbGrid")!;
        set => HttpData["tblEvaluationMbGrid"] = value;
    }

    /// <summary>
    /// Page class for tblEvaluationMB
    /// </summary>
    public class TblEvaluationMbGrid : TblEvaluationMbGridBase
    {
        // Constructor
        public TblEvaluationMbGrid() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblEvaluationMbGridBase : TblEvaluationMb
    {
        // Page ID
        public string PageID = "grid";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblEvaluationMB";

        // Page object name
        public string PageObjName = "tblEvaluationMbGrid";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblEvaluationMBgrid";

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
        public TblEvaluationMbGridBase()
        {
            // CSS class name as context
            TableVar = "tblEvaluationMB";
            ContextClass = CheckClassName(TableVar);
            TableGridClass = AppendClass(TableGridClass, ContextClass);
            FormActionName = Config.FormRowActionName;
            FormBlankRowName = Config.FormBlankRowName;
            FormKeyCountName = Config.FormKeyCountName;

            // Initialize
            FormActionName += "_" + FormName;
            OldKeyName += "_" + FormName;
            FormBlankRowName += "_" + FormName;
            FormKeyCountName += "_" + FormName;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-table";

            // CSS class name as context
            ContextClass = CheckClassName(TableVar);
            TableGridClass = AppendClass(TableGridClass, ContextClass);

            // Language object
            Language = ResolveLanguage();
            AddUrl = "TblEvaluationMbAdd";

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
        public string PageName => "TblEvaluationMbGrid";

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
            Eval_ID.Visible = false;
            int_Student_ID.Visible = false;
            AssessmentID.Visible = false;
            str_Full_Name_Hdr.SetVisibility();
            NationalID.SetVisibility();
            str_Cell_Phone.SetVisibility();
            str_Username.Visible = false;
            intDrivinglicenseType.SetVisibility();
            Date_Entered.Visible = false;
            Examination_Number.Visible = false;
            Retake.SetVisibility();
            Section_1.Visible = false;
            Q1.Visible = false;
            Q2.Visible = false;
            Q3.Visible = false;
            Q4.Visible = false;
            Q5.Visible = false;
            Section_2.Visible = false;
            Q6.Visible = false;
            Q7.Visible = false;
            Q8.Visible = false;
            Q9.Visible = false;
            Q10.Visible = false;
            Q11.Visible = false;
            Q12.Visible = false;
            Q13.Visible = false;
            Q14.Visible = false;
            Q15.Visible = false;
            Section_3.Visible = false;
            Q16.Visible = false;
            Q17.Visible = false;
            Q18.Visible = false;
            Q19.Visible = false;
            Q20.Visible = false;
            Q21.Visible = false;
            Section_4.Visible = false;
            Q22.Visible = false;
            Q23.Visible = false;
            Q24.Visible = false;
            Q25.Visible = false;
            Q26.Visible = false;
            Section_5.Visible = false;
            Q27.Visible = false;
            Q28.Visible = false;
            Q29.Visible = false;
            Q30.Visible = false;
            Q31.Visible = false;
            Q32.Visible = false;
            Q33.Visible = false;
            Q34.Visible = false;
            Q35.Visible = false;
            Section_6.Visible = false;
            Q36.Visible = false;
            Q37.Visible = false;
            Q38.Visible = false;
            Q39.Visible = false;
            Q40.Visible = false;
            Q41.Visible = false;
            Q42.Visible = false;
            Q43.Visible = false;
            Section_7.Visible = false;
            Q44.Visible = false;
            Q45.Visible = false;
            Q46.Visible = false;
            Q47.Visible = false;
            Q48.Visible = false;
            Q49.Visible = false;
            Q50.Visible = false;
            Section_8.Visible = false;
            Q51.Visible = false;
            Q52.Visible = false;
            Q53.Visible = false;
            Q54.Visible = false;
            Q55.Visible = false;
            Section_9.Visible = false;
            Q56.Visible = false;
            Q57.Visible = false;
            Q58.Visible = false;
            Q59.Visible = false;
            Section_10.Visible = false;
            Q60.Visible = false;
            Q61.Visible = false;
            Q62.Visible = false;
            Q63.Visible = false;
            Q64.Visible = false;
            Q65.Visible = false;
            Section_11.Visible = false;
            Q66.Visible = false;
            Q67.Visible = false;
            Q68.Visible = false;
            Q69.Visible = false;
            Q70.Visible = false;
            Notes_3.Visible = false;
            Examiner_Signature.Visible = false;
            Student_Signature.Visible = false;
            AbsherApptNbr.SetVisibility();
            IsDrivingexperience.SetVisibility();
            date_Birth_Hijri.Visible = false;
            date_Birth.Visible = false;
            str_Email.Visible = false;
            UserlevelID.Visible = false;
            DriveTypelink.Visible = false;
            intEvaluationType.Visible = false;
            Institution.Visible = false;
            Scores_S1.Visible = false;
            S1.Visible = false;
            S2.Visible = false;
            S3.Visible = false;
            S4.Visible = false;
            S5.Visible = false;
            Scores_S2.Visible = false;
            S6.Visible = false;
            S7.Visible = false;
            S8.Visible = false;
            S9.Visible = false;
            S10.Visible = false;
            S11.Visible = false;
            S12.Visible = false;
            S13.Visible = false;
            S14.Visible = false;
            S15.Visible = false;
            Scores_S3.Visible = false;
            S16.Visible = false;
            S17.Visible = false;
            S18.Visible = false;
            S19.Visible = false;
            S20.Visible = false;
            S21.Visible = false;
            Scores_S4.Visible = false;
            S22.Visible = false;
            S23.Visible = false;
            S24.Visible = false;
            S25.Visible = false;
            S26.Visible = false;
            Scores_S5.Visible = false;
            S27.Visible = false;
            S28.Visible = false;
            S29.Visible = false;
            S30.Visible = false;
            S31.Visible = false;
            S32.Visible = false;
            S33.Visible = false;
            S34.Visible = false;
            S35.Visible = false;
            Scores_S6.Visible = false;
            S36.Visible = false;
            S37.Visible = false;
            S38.Visible = false;
            S39.Visible = false;
            S40.Visible = false;
            S41.Visible = false;
            S42.Visible = false;
            S43.Visible = false;
            Scores_S7.Visible = false;
            S44.Visible = false;
            S45.Visible = false;
            S46.Visible = false;
            S47.Visible = false;
            S48.Visible = false;
            S49.Visible = false;
            S50.Visible = false;
            Scores_S8.Visible = false;
            S51.Visible = false;
            S52.Visible = false;
            S53.Visible = false;
            S54.Visible = false;
            S55.Visible = false;
            Scores_S9.Visible = false;
            S56.Visible = false;
            S57.Visible = false;
            S58.Visible = false;
            S59.Visible = false;
            Scores_S10.Visible = false;
            S60.Visible = false;
            S61.Visible = false;
            S62.Visible = false;
            S63.Visible = false;
            S64.Visible = false;
            S65.Visible = false;
            Scores_S11.Visible = false;
            S66.Visible = false;
            S67.Visible = false;
            S68.Visible = false;
            S69.Visible = false;
            S70.Visible = false;
            Evaluation_Score.Visible = false;
            Immediate_Failure_Score.Visible = false;
            Required_Program.Visible = false;
            Price.Visible = false;
        }

        /// <summary>
        /// Terminate page
        /// </summary>
        /// <param name="url">URL to rediect to</param>
        /// <returns>Page result</returns>
        public override IActionResult Terminate(string url = "") { // DN
            if (_terminated) // DN
                return new EmptyResult();
            if (Empty(url))
                return new EmptyResult();
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("Eval_ID") ? dict["Eval_ID"] : Eval_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                Eval_ID.Visible = false;
            if (IsAddOrEdit)
                str_Username.Visible = false;
            if (IsAddOrEdit)
                Date_Entered.Visible = false;
            if (IsAddOrEdit)
                UserlevelID.Visible = false;
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

        #pragma warning disable 169

        public bool ShowOtherOptions = false;

        private DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType>? _connection;
        #pragma warning restore 169

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

        public string MultiColumnGridClass = "row-cols-md";

        public string MultiColumnEditClass = "col-12 w-100";

        public string MultiColumnCardClass = "card h-100 ew-card";

        public string MultiColumnListOptionsPosition = "bottom-start";

        public string DbMasterFilter = ""; // Master filter

        public string DbDetailFilter = ""; // Detail filter

        public bool MasterRecordExists;

        public string MultiSelectKey = "";

        public string UserAction = ""; // User action

        public bool RestoreSearch = false;

        public SubPages? DetailPages; // Detail pages object

        public DbDataReader? Recordset;

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

        #pragma warning disable 618
        // Connection
        public override DatabaseConnectionBase<SqlConnection, SqlCommand, SqlDataReader, SqlDbType> Connection
        {
            get {
                _connection ??= GetConnection2(DbId);
                return _connection;
            }
        }
        #pragma warning restore 618

        /// <summary>
        /// Load recordset from filter
        /// <param name="filter">Record filter</param>
        /// </summary>
        public async Task LoadRecordsetFromFilter(string filter)
        {
            // Set up list options
            await SetupListOptions();

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

            // Get grid add count
            int gridaddcnt = Get<int>(Config.TableGridAddRowCount);
            if (gridaddcnt > 0)
                GridAddRowCount = gridaddcnt;

            // Set up list options
            await SetupListOptions();
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

            // Set up master detail parameters
            SetupMasterParms();

            // Setup other options
            SetupOtherOptions();

            // Set up lookup cache
            await SetupLookupOptions(Retake);
            await SetupLookupOptions(Q1);
            await SetupLookupOptions(Q2);
            await SetupLookupOptions(Q3);
            await SetupLookupOptions(Q4);
            await SetupLookupOptions(Q5);
            await SetupLookupOptions(Q6);
            await SetupLookupOptions(Q7);
            await SetupLookupOptions(Q8);
            await SetupLookupOptions(Q9);
            await SetupLookupOptions(Q10);
            await SetupLookupOptions(Q11);
            await SetupLookupOptions(Q12);
            await SetupLookupOptions(Q13);
            await SetupLookupOptions(Q14);
            await SetupLookupOptions(Q15);
            await SetupLookupOptions(Q16);
            await SetupLookupOptions(Q17);
            await SetupLookupOptions(Q18);
            await SetupLookupOptions(Q19);
            await SetupLookupOptions(Q20);
            await SetupLookupOptions(Q21);
            await SetupLookupOptions(Q22);
            await SetupLookupOptions(Q23);
            await SetupLookupOptions(Q24);
            await SetupLookupOptions(Q25);
            await SetupLookupOptions(Q26);
            await SetupLookupOptions(Q27);
            await SetupLookupOptions(Q28);
            await SetupLookupOptions(Q29);
            await SetupLookupOptions(Q30);
            await SetupLookupOptions(Q31);
            await SetupLookupOptions(Q32);
            await SetupLookupOptions(Q33);
            await SetupLookupOptions(Q34);
            await SetupLookupOptions(Q35);
            await SetupLookupOptions(Q36);
            await SetupLookupOptions(Q37);
            await SetupLookupOptions(Q38);
            await SetupLookupOptions(Q39);
            await SetupLookupOptions(Q40);
            await SetupLookupOptions(Q41);
            await SetupLookupOptions(Q42);
            await SetupLookupOptions(Q43);
            await SetupLookupOptions(Q44);
            await SetupLookupOptions(Q45);
            await SetupLookupOptions(Q46);
            await SetupLookupOptions(Q47);
            await SetupLookupOptions(Q48);
            await SetupLookupOptions(Q49);
            await SetupLookupOptions(Q50);
            await SetupLookupOptions(Q51);
            await SetupLookupOptions(Q52);
            await SetupLookupOptions(Q53);
            await SetupLookupOptions(Q54);
            await SetupLookupOptions(Q55);
            await SetupLookupOptions(Q56);
            await SetupLookupOptions(Q57);
            await SetupLookupOptions(Q58);
            await SetupLookupOptions(Q59);
            await SetupLookupOptions(Q60);
            await SetupLookupOptions(Q61);
            await SetupLookupOptions(Q62);
            await SetupLookupOptions(Q63);
            await SetupLookupOptions(Q64);
            await SetupLookupOptions(Q65);
            await SetupLookupOptions(Q66);
            await SetupLookupOptions(Q67);
            await SetupLookupOptions(Q68);
            await SetupLookupOptions(Q69);
            await SetupLookupOptions(Q70);
            await SetupLookupOptions(IsDrivingexperience);
            await SetupLookupOptions(S1);
            await SetupLookupOptions(S2);
            await SetupLookupOptions(S3);
            await SetupLookupOptions(S4);
            await SetupLookupOptions(S5);
            await SetupLookupOptions(S6);
            await SetupLookupOptions(S7);
            await SetupLookupOptions(S8);
            await SetupLookupOptions(S9);
            await SetupLookupOptions(S10);
            await SetupLookupOptions(S11);
            await SetupLookupOptions(S12);
            await SetupLookupOptions(S13);
            await SetupLookupOptions(S14);
            await SetupLookupOptions(S15);
            await SetupLookupOptions(S16);
            await SetupLookupOptions(S17);
            await SetupLookupOptions(S18);
            await SetupLookupOptions(S19);
            await SetupLookupOptions(S20);
            await SetupLookupOptions(S21);
            await SetupLookupOptions(S22);
            await SetupLookupOptions(S23);
            await SetupLookupOptions(S24);
            await SetupLookupOptions(S25);
            await SetupLookupOptions(S26);
            await SetupLookupOptions(S27);
            await SetupLookupOptions(S28);
            await SetupLookupOptions(S29);
            await SetupLookupOptions(S30);
            await SetupLookupOptions(S31);
            await SetupLookupOptions(S32);
            await SetupLookupOptions(S33);
            await SetupLookupOptions(S34);
            await SetupLookupOptions(S35);
            await SetupLookupOptions(S36);
            await SetupLookupOptions(S37);
            await SetupLookupOptions(S38);
            await SetupLookupOptions(S39);
            await SetupLookupOptions(S40);
            await SetupLookupOptions(S41);
            await SetupLookupOptions(S42);
            await SetupLookupOptions(S43);
            await SetupLookupOptions(S44);
            await SetupLookupOptions(S45);
            await SetupLookupOptions(S46);
            await SetupLookupOptions(S47);
            await SetupLookupOptions(S48);
            await SetupLookupOptions(S49);
            await SetupLookupOptions(S50);
            await SetupLookupOptions(S51);
            await SetupLookupOptions(S52);
            await SetupLookupOptions(S53);
            await SetupLookupOptions(S54);
            await SetupLookupOptions(S55);
            await SetupLookupOptions(S56);
            await SetupLookupOptions(S57);
            await SetupLookupOptions(S58);
            await SetupLookupOptions(S59);
            await SetupLookupOptions(S60);
            await SetupLookupOptions(S61);
            await SetupLookupOptions(S62);
            await SetupLookupOptions(S63);
            await SetupLookupOptions(S64);
            await SetupLookupOptions(S65);
            await SetupLookupOptions(S66);
            await SetupLookupOptions(S67);
            await SetupLookupOptions(S68);
            await SetupLookupOptions(S69);
            await SetupLookupOptions(S70);

            // Load default values for add
            LoadDefaultValues();

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblEvaluationMBgrid";

            // Set up infinite scroll
            UseInfiniteScroll = Param<bool>("infinitescroll");

            // Search filters
            string srchAdvanced = ""; // Advanced search filter
            string srchBasic = ""; // Basic search filter
            string filter = ""; // Filter
            string query = ""; // Query builder

            // Get command
            Command = Get("cmd").ToLower();

            // Set up records per page
            SetupDisplayRecords();

            // Handle reset command
            ResetCommand();

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

            // Show grid delete link for grid add / grid edit
            if (AllowAddDeleteRow) {
                if (IsGridAdd || IsGridEdit) {
                    var item = ListOptions["griddelete"];
                    if (item != null)
                        item.Visible = false;
                }
            }

            // Set up sorting order
            SetupSortOrder();

            // Restore display records
            if (Command != "json" && (RecordsPerPage == -1 || RecordsPerPage > 0)) {
                DisplayRecords = RecordsPerPage; // Restore from Session
            } else {
                DisplayRecords = 20; // Load default
                RecordsPerPage = DisplayRecords; // Save default to session
            }

            // Build filter
            filter = "";
            if (!Security.CanList)
                filter = "(0=1)"; // Filter all records

            // Restore master/detail filter from session
            DbMasterFilter = MasterFilterFromSession;
            DbDetailFilter = DetailFilterFromSession;

            // Add master User ID filter
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin) { // Non system admin
                if (CurrentMasterTable == "tblAssessment")
                    DbMasterFilter = AddMasterUserIDFilter(DbMasterFilter, "tblAssessment"); // Add master User ID filter
            }
            AddFilter(ref filter, DbDetailFilter);
            AddFilter(ref filter, SearchWhere);

            // Load master record
            if (CurrentMode != "add" && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblAssessment") {
                tblAssessment = Resolve("tblAssessment")!;
                if (tblAssessment != null) {
                    using (var rsmaster = await tblAssessment.LoadReader(DbMasterFilter)) { // Note: Use {}
                        MasterRecordExists = rsmaster != null && await rsmaster.ReadAsync();
                        if (!MasterRecordExists) {
                            FailureMessage = Language.Phrase("NoRecord"); // Set no record found
                            return Terminate("TblAssessmentList"); // Return to master page
                        } else {
                            tblAssessment.LoadListRowValues(rsmaster);
                        }
                    }
                    tblAssessment.RowType = RowType.Master; // Master row
                    await tblAssessment.RenderListRow(); // Note: Do it outside "using" // DN
                }
            }

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
                if (CurrentMode == "copy") {
                    TotalRecords = await ListRecordCountAsync();
                    Recordset = await LoadRecordset(StartRecord - 1, TotalRecords);
                    StartRecord = 1;
                    DisplayRecords = TotalRecords;
                } else {
                    CurrentFilter = "0=1";
                    StartRecord = 1;
                    DisplayRecords = GridAddRowCount;
                }
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
                DisplayRecords = TotalRecords; // Display all records

                // Recordset
                bool selectLimit = UseSelectLimit;
                if (selectLimit)
                    Recordset = await LoadRecordset(StartRecord - 1, DisplayRecords);
            }

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
                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                tblEvaluationMbGrid?.PageRender();
            }
            return new EmptyResult();
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

        // Exit inline mode
        protected void ClearInlineMode() {
            LastAction = CurrentAction; // Save last action
            CurrentAction = ""; // Clear action
            Session[Config.SessionInlineMode] = ""; // Clear inline mode
        }

        // Switch to grid add mode
        protected void GridAddMode() {
            CurrentAction = "gridadd";
            Session[Config.SessionInlineMode] = "gridadd"; // Enabled grid add
            HideFieldsForAddEdit();
        }

        // Switch to grid edit mode
        protected void GridEditMode() {
            CurrentAction = "gridedit";
            Session[Config.SessionInlineMode] = "gridedit"; // Enabled grid edit
            HideFieldsForAddEdit();
        }

        // Perform update to grid
        public async Task<bool> GridUpdate()
        {
            bool gridUpdate = true;

            // Get old recordset
            CurrentFilter = BuildKeyFilter();
            if (Empty(CurrentFilter))
                CurrentFilter = "0=1";
            string sql = CurrentSql;
            List<Dictionary<string, object>> rsold = await Connection.GetRowsAsync(sql);

            // Call Grid Updating event
            if (!GridUpdating(rsold)) {
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("GridEditCancelled"); // Set grid edit cancelled message
                EventCancelled = true;
                return false;
            }
            if (AuditTrailOnEdit) await WriteAuditTrailLog(Language.Phrase("BatchUpdateBegin")); // Batch update begin
            string wrkFilter = "";
            string key = "";

            // Update row index and get row key
            CurrentForm?.ResetIndex();
            int rowcnt = CurrentForm?.GetInt(FormKeyCountName) ?? 0;

            // Load default values for emptyRow checking // DN
            LoadDefaultValues();

            // Update all rows based on key
            try {
                for (int rowindex = 1; rowindex <= rowcnt; rowindex++) {
                    CurrentForm!.Index = rowindex;
                    SetKey(CurrentForm.GetValue(OldKeyName));
                    string rowaction = CurrentForm.GetValue(FormActionName);

                    // Load all values and keys
                    if (rowaction != "insertdelete" && rowaction != "hide") { // Skip insert then deleted rows / hidden rows for grid edit
                        await LoadFormValues(); // Get form values
                        if (Empty(rowaction) || rowaction == "edit" || rowaction == "delete") {
                            gridUpdate = !Empty(OldKey); // Key must not be empty
                        } else {
                            gridUpdate = true;
                        }

                        // Skip empty row
                        if (rowaction == "insert" && EmptyRow()) {
                            // No action required
                        } else if (gridUpdate) { // Validate form and insert/update/delete record
                            if (rowaction == "delete") {
                                CurrentFilter = GetRecordFilter();
                                gridUpdate = await DeleteRows(); // Delete this row
                            } else {
                                if (rowaction == "insert") {
                                    gridUpdate = await AddRow(); // Insert this row
                                } else {
                                    if (!Empty(OldKey)) {
                                        SendEmail = false; // Do not send email on update success
                                        gridUpdate = await EditRow(); // Update this row
                                    }
                                } // End update
                                if (gridUpdate) // Get inserted or updated filter
                                    AddFilter(ref wrkFilter, GetRecordFilter(), "OR");
                            }
                        }
                        if (gridUpdate) {
                            if (!Empty(key))
                                key += ", ";
                            key += OldKey;
                        } else {
                            EventCancelled = true;
                            break;
                        }
                    }
                }
            } catch (Exception e) {
                FailureMessage = e.Message;
                gridUpdate = false;
            }
            if (gridUpdate) {
                FilterForModalActions = wrkFilter;

                // Get new recordset
                List<Dictionary<string, object>> rsnew = await Connection.GetRowsAsync(sql, true); // Use main connection (faster) // DN

                // Call Grid Updated event
                GridUpdated(rsold, rsnew);
                if (AuditTrailOnEdit)
                    await WriteAuditTrailLog(Language.Phrase("BatchUpdateSuccess")); // Batch update success
                ClearInlineMode(); // Clear inline edit mode
            } else {
                if (AuditTrailOnEdit)
                    await WriteAuditTrailLog(Language.Phrase("BatchUpdateRollback")); // Batch update rollback
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("UpdateFailed"); // Set update failed message
            }
            return gridUpdate;
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

        // Perform Grid Add
        #pragma warning disable 168, 219

        public async Task<bool> GridInsert()
        {
            int addcnt = 0;
            bool gridInsert = false;

            // Call Grid Inserting event
            if (!GridInserting()) {
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("GridAddCancelled"); // Set grid add cancelled message
                EventCancelled = true;
                return false;
            }

            // Init key filter
            string wrkFilter = "";
            if (AuditTrailOnAdd)
                await WriteAuditTrailLog(Language.Phrase("BatchInsertBegin")); // Batch insert begin
            string key = "";

            // Get row count
            CurrentForm?.ResetIndex();
            int rowcnt = CurrentForm?.GetInt(FormKeyCountName) ?? 0;

            // Load default values for emptyRow checking // DN
            LoadDefaultValues();

            // Insert all rows
            try {
                for (int rowindex = 1; rowindex <= rowcnt; rowindex++) {
                    // Load current row values
                    CurrentForm!.Index = rowindex;
                    string rowaction = CurrentForm.GetValue(FormActionName);
                    Dictionary<string, object>? rsold = null;
                    if (!Empty(rowaction) && rowaction != "insert")
                        continue; // Skip
                    if (rowaction == "insert") {
                        OldKey = CurrentForm.GetValue(OldKeyName);
                        rsold = await LoadOldRecord(); // Load old record
                    }
                    await LoadFormValues(); // Get form values
                    if (!EmptyRow()) {
                        addcnt++;
                        SendEmail = false; // Do not send email on insert success
                        gridInsert = await AddRow(rsold); // Insert row (already validated by validateGridForm())
                        if (gridInsert) {
                            if (!Empty(key))
                                key += Config.CompositeKeySeparator;
                            key += ConvertToString(Eval_ID.CurrentValue);

                            // Add filter for this record
                            AddFilter(ref wrkFilter, GetRecordFilter(), "OR");
                        } else {
                            EventCancelled = true;
                            break;
                        }
                    }
                }
                if (addcnt == 0) { // No record inserted
                    ClearInlineMode(); // Clear grid add mode and return
                    return true;
                }
            } catch (Exception e) {
                FailureMessage = e.Message;
                gridInsert = false;
            }
            if (gridInsert) {
                // Get new recordset
                CurrentFilter = wrkFilter;
                FilterForModalActions = wrkFilter;
                string sql = CurrentSql;
                List<Dictionary<string, object>> rsnew = await Connection.GetRowsAsync(sql, true); // Use main connection (faster) // DN

                // Call Grid Inserted event
                GridInserted(rsnew);
                if (AuditTrailOnAdd)
                    await WriteAuditTrailLog(Language.Phrase("BatchInsertSuccess")); // Batch insert success
                ClearInlineMode(); // Clear grid add mode
            } else {
                if (AuditTrailOnAdd)
                    await WriteAuditTrailLog(Language.Phrase("BatchInsertRollback")); // Batch insert rollback
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("InsertFailed"); // Set insert failed message
            }
            return gridInsert;
        }
        #pragma warning restore 168, 219

        // Check if empty row
        public bool EmptyRow()
        {
            if (CurrentForm == null)
                return true;
            if (CurrentForm.HasValue("x_str_Full_Name_Hdr") && CurrentForm.HasValue("o_str_Full_Name_Hdr") && !SameString(str_Full_Name_Hdr.CurrentValue, str_Full_Name_Hdr.DefaultValue) &&
            !(str_Full_Name_Hdr.IsForeignKey && CurrentMasterTable != "" && SameString(str_Full_Name_Hdr.CurrentValue, str_Full_Name_Hdr.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_NationalID") && CurrentForm.HasValue("o_NationalID") && !SameString(NationalID.CurrentValue, NationalID.DefaultValue) &&
            !(NationalID.IsForeignKey && CurrentMasterTable != "" && SameString(NationalID.CurrentValue, NationalID.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Cell_Phone") && CurrentForm.HasValue("o_str_Cell_Phone") && !SameString(str_Cell_Phone.CurrentValue, str_Cell_Phone.DefaultValue) &&
            !(str_Cell_Phone.IsForeignKey && CurrentMasterTable != "" && SameString(str_Cell_Phone.CurrentValue, str_Cell_Phone.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_intDrivinglicenseType") && CurrentForm.HasValue("o_intDrivinglicenseType") && !SameString(intDrivinglicenseType.CurrentValue, intDrivinglicenseType.DefaultValue) &&
            !(intDrivinglicenseType.IsForeignKey && CurrentMasterTable != "" && SameString(intDrivinglicenseType.CurrentValue, intDrivinglicenseType.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_Retake") && CurrentForm.HasValue("o_Retake") && ConvertToBool(Retake.CurrentValue) != ConvertToBool(Retake.DefaultValue) &&
            !(Retake.IsForeignKey && CurrentMasterTable != "" && ConvertToBool(Retake.CurrentValue) == ConvertToBool(Retake.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_AbsherApptNbr") && CurrentForm.HasValue("o_AbsherApptNbr") && !SameString(AbsherApptNbr.CurrentValue, AbsherApptNbr.DefaultValue) &&
            !(AbsherApptNbr.IsForeignKey && CurrentMasterTable != "" && SameString(AbsherApptNbr.CurrentValue, AbsherApptNbr.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_IsDrivingexperience") && CurrentForm.HasValue("o_IsDrivingexperience") && ConvertToBool(IsDrivingexperience.CurrentValue) != ConvertToBool(IsDrivingexperience.DefaultValue) &&
            !(IsDrivingexperience.IsForeignKey && CurrentMasterTable != "" && ConvertToBool(IsDrivingexperience.CurrentValue) == ConvertToBool(IsDrivingexperience.SessionValue)))
                return false;
            return true;
        }

        // Validate grid form
        public async Task<bool> ValidateGridForm()
        {
            // Get row count
            CurrentForm?.ResetIndex();
            int rowcnt = CurrentForm?.GetInt(FormKeyCountName) ?? 0;

            // Load default values for emptyRow checking
            LoadDefaultValues();

            // Validate all records
            for (int rowindex = 1; rowindex <= rowcnt; rowindex++) {
                // Load current row values
                CurrentForm!.Index = rowindex;
                string rowaction = CurrentForm.GetValue(FormActionName);
                if (rowaction != "delete" && rowaction != "insertdelete" && rowaction != "hide") {
                    await LoadFormValues(); // Get form values
                    if (rowaction == "insert" && EmptyRow()) {
                        // Ignore
                    } else if (!await ValidateForm()) {
                        return false;
                    }
                }
            }
            return true;
        }

        // Get all form values of the grid
        public List<Dictionary<string, string?>> GetGridFormValues()
        {
            // Get row count
            CurrentForm?.ResetIndex();
            int rowcnt = CurrentForm?.GetInt(FormKeyCountName) ?? 0;
            List<Dictionary<string, string?>> rows = new ();

            // Loop through all records
            for (int rowindex = 1; rowindex <= rowcnt; rowindex++) {
                // Load current row values
                CurrentForm!.Index = rowindex;
                string rowaction = CurrentForm.GetValue(FormActionName);
                if (rowaction != "delete" && rowaction != "insertdelete") {
                    LoadFormValues().GetAwaiter().GetResult(); // Load form values (sync)
                    if (rowaction == "insert" && EmptyRow()) {
                        // Ignore
                    } else {
                        rows.Add(GetFormValues()); // Return row as array
                    }
                }
            }
            return rows; // Return as array of array
        }

        // Restore form values for current row
        public async Task RestoreCurrentRowFormValues(object index)
        {
            // Get row based on current index
            if (index is int idx)
                CurrentForm!.Index = idx;
            string rowaction = CurrentForm.GetValue(FormActionName);
            await LoadFormValues(); // Load form values
            // Set up invalid status correctly
            ResetFormError();
            if (rowaction == "insert" && EmptyRow()) {
                // Ignore
            } else {
                await ValidateForm();
            }
        }

        // Reset form status
        public void ResetFormError()
        {
            str_Full_Name_Hdr.ClearErrorMessage();
            NationalID.ClearErrorMessage();
            str_Cell_Phone.ClearErrorMessage();
            intDrivinglicenseType.ClearErrorMessage();
            Retake.ClearErrorMessage();
            AbsherApptNbr.ClearErrorMessage();
            IsDrivingexperience.ClearErrorMessage();
        }

        // Set up sort parameters
        protected void SetupSortOrder() {
            // Load default Sorting Order
            if (Command != "json") {
                string defaultSort = ""; // Set up default sort
                if (Empty(SessionOrderBy) && !Empty(defaultSort))
                    SessionOrderBy = defaultSort;
            }

            // Check for "order" parameter
            if (Get("order", out StringValues sv)) {
                CurrentOrder = sv.ToString();
                CurrentOrderType = Get("ordertype");
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
                // Reset master/detail keys
                if (SameText(Command, "resetall")) {
                    CurrentMasterTable = ""; // Clear master table
                    DbMasterFilter = "";
                    DbDetailFilter = "";
                    AssessmentID.SessionValue = "";
                }

                // Reset (clear) sorting order
                if (SameText(Command, "resetsort")) {
                    string orderBy = "";
                    SessionOrderBy = orderBy;
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

            // "griddelete"
            if (AllowAddDeleteRow) {
                item = ListOptions.Add("griddelete");
                item.CssClass = "text-nowrap";
                item.OnLeft = true;
                item.Visible = false; // Default hidden
            }

            // Add group option item
            item = ListOptions.AddGroupOption();
            item.Body = "";
            item.OnLeft = true;
            item.Visible = false;

            // "view"
            item = ListOptions.Add("view");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanView;
            item.OnLeft = true;

            // "edit"
            item = ListOptions.Add("edit");
            item.CssClass = "text-nowrap";
            item.Visible = Security.CanEdit;
            item.OnLeft = true;

            // Drop down button for ListOptions
            ListOptions.UseDropDownButton = false;
            ListOptions.DropDownButtonPhrase = "ButtonListOptions";
            ListOptions.UseButtonGroup = false;
            if (ListOptions.UseButtonGroup && IsMobile())
                ListOptions.UseDropDownButton = true;

            //ListOptions.ButtonClass = ""; // Class for button group
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

            // Set up row action and key
            if (IsNumeric(RowIndex) && RowType != RowType.View) {
                CurrentForm!.Index = ConvertToInt(RowIndex);
                var actionName = FormActionName.Replace("k_", "k" + ConvertToString(RowIndex) + "_");
                var oldKeyName = OldKeyName.Replace("k_", "k" + ConvertToString(RowIndex) + "_");
                var blankRowName = FormBlankRowName.Replace("k_", "k" + ConvertToString(RowIndex) + "_");
                if (!Empty(RowAction))
                    MultiSelectKey += "<input type=\"hidden\" name=\"" + actionName + "\" id=\"" + actionName + "\" value=\"" + RowAction + "\">";
                string oldKey = GetKey(false); // Get from OldValue
                if (!Empty(oldKeyName) && !Empty(oldKey)) {
                    MultiSelectKey += "<input type=\"hidden\" name=\"" + oldKeyName + "\" id=\"" + oldKeyName + "\" value=\"" + HtmlEncode(oldKey) + "\">";
                }
                if (RowAction == "insert" && IsConfirm && EmptyRow())
                    MultiSelectKey += "<input type=\"hidden\" name=\"" + blankRowName + "\" id=\"" + blankRowName + "\" value=\"1\">";
            }

            // "delete"
            if (AllowAddDeleteRow) {
                if (CurrentMode == "add" || CurrentMode == "copy" || CurrentMode == "edit") {
                    var options = ListOptions;
                    options.UseButtonGroup = true; // Use button group for grid delete button
                    listOption = options["griddelete"];
                    if (IsNumeric(RowIndex) && (RowAction == "" || RowAction == "edit")) { // Do not allow delete existing record
                        listOption?.SetBody("&nbsp;");
                    } else {
                        listOption?.SetBody("<a class=\"ew-grid-link ew-grid-delete\" title=\"" + Language.Phrase("DeleteLink", true) + "\" data-caption=\"" + Language.Phrase("DeleteLink", true) + "\" data-ew-action=\"delete-grid-row\" data-rowindex=\"" + RowIndex + "\">" + Language.Phrase("DeleteLink") + "</a>");
                    }
                }
            }
            if (CurrentMode == "view") {
            // "view"
            listOption = ListOptions["view"];
            string viewcaption = Language.Phrase("ViewLink", true);
            isVisible = Security.CanView && ShowOptionLink("view");
            if (isVisible) {
                if (ModalView && !IsMobile())
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-table=""tblEvaluationMB"" data-caption=""{viewcaption}"" data-ew-action=""modal"" data-action=""view"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(ViewUrl)) + "\" data-btn=\"null\">" + Language.Phrase("ViewLink") + "</a>");
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
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblEvaluationMB"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
                else
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-caption=""{editcaption}"" href=""" + HtmlEncode(AppPath(EditUrl)) + "\">" + Language.Phrase("EditLink") + "</a>");
            } else {
                listOption?.Clear();
            }
            } // End View mode
            RenderListOptionsExt();

            // Call ListOptions Rendered event
            ListOptionsRendered();
        }

        // Render list options (extensions)
        protected void RenderListOptionsExt() {
            // Render list options (to be implemented by extensions)
        }

        // Set up other options
        protected void SetupOtherOptions() {
            ListOptions option;
            ListOption item;
            option = OtherOptions["addedit"];
            option.UseDropDownButton = false;
            option.DropDownButtonPhrase = "ButtonAddEdit";
            option.UseButtonGroup = true;
            option.ButtonClass = ""; // Class for button group
            item = option.AddGroupOption();
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
                if ((CurrentMode == "add" || CurrentMode == "copy" || CurrentMode == "edit") && !IsConfirm) { // Check add/copy/edit mode
                    if (AllowAddDeleteRow) {
                        option = options["addedit"];
                        option.UseDropDownButton = false;
                        item = option.Add("addblankrow");
                        item.Body = "<a class=\"ew-add-edit ew-add-blank-row\" title=\"" + Language.Phrase("AddBlankRow", true) + "\" data-caption=\"" + Language.Phrase("AddBlankRow", true) + "\" data-ew-action=\"add-grid-row\">" + Language.Phrase("AddBlankRow") + "</a>";
                        item.Visible = false;
                        ShowOtherOptions = item.Visible;
                    }
                }
                if (CurrentMode == "view") { // Check view mode
                    option = options["addedit"];
                    item = option.GetItem("add");
                    ShowOtherOptions = !Empty(item) && item.Visible;
                }
        }

        // Set up Grid
        public async Task SetupGrid()
        {
            StartRecord = 1;
            StopRecord = TotalRecords; // Show all records

            // Restore number of post back records
            if (CurrentForm != null && (IsConfirm || EventCancelled)) {
                CurrentForm!.ResetIndex(); // DN
                if (CurrentForm!.HasValue(FormKeyCountName) && (IsGridAdd || IsGridEdit || IsConfirm)) {
                    KeyCount = CurrentForm.GetInt(FormKeyCountName);
                    StopRecord = StartRecord + KeyCount - 1;
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
            if ((IsGridAdd || IsGridEdit)) // Render template row first
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
                    RowAttrs.Add("id", "r0_tblEvaluationMB");
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
            if (CurrentForm != null && (IsGridAdd || IsGridEdit || IsConfirm || IsMultiEdit)) {
                RowIndex = ConvertToInt(RowIndex) + 1;
                CurrentForm!.SetIndex(ConvertToInt(RowIndex));
                if (CurrentForm!.HasValue(FormActionName) && (IsConfirm || EventCancelled))
                    RowAction = CurrentForm.GetValue(FormActionName);
                else if (IsGridAdd)
                    RowAction = "insert";
                else
                    RowAction = "";
            }

            // Set up key count
            KeyCount = ConvertToInt(RowIndex);

            // Init row class and style
            ResetAttributes();
            CssClass = "";
            if (IsGridAdd) {
                if (CurrentMode == "copy") {
                    await LoadRowValues(Recordset); // Load row values
                    OldKey = GetKey(true); // Get from CurrentValue
                } else {
                    await LoadRowValues(); // Load default values
                    OldKey = "";
                }
            } else {
                await LoadRowValues(Recordset); // Load row values
                OldKey = GetKey(true); // Get from CurrentValue
            }
            SetKey(OldKey);
            RowType = RowType.View; // Render view
            if ((IsAdd || IsCopy) && InlineRowCount == 0 || IsGridAdd) // Add
                RowType = RowType.Add; // Render add
            if (IsGridAdd && EventCancelled && !CurrentForm!.HasValue(FormBlankRowName)) // Insert failed
                await RestoreCurrentRowFormValues(RowIndex); // Restore form values
            if (IsGridEdit) { // Grid edit
                if (EventCancelled)
                    await RestoreCurrentRowFormValues(RowIndex); // Restore form values
                if (RowAction == "insert")
                    RowType = RowType.Add; // Render add
                else
                    RowType = RowType.Edit; // Render edit
            }
            if (IsGridEdit && (RowType == RowType.Edit || RowType == RowType.Add) && EventCancelled) // Update failed
                await RestoreCurrentRowFormValues(RowIndex); // Restore form values
            if (IsConfirm) // Confirm row
                await RestoreCurrentRowFormValues(RowIndex); // Restore form values

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
            RowAttrs.Add("data-rowindex", ConvertToString(tblEvaluationMbGrid.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblEvaluationMbGrid.RowCount) + "_tblEvaluationMB");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblEvaluationMbGrid.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblEvaluationMbGrid.RowType == RowType.Add || IsEdit && tblEvaluationMbGrid.RowType == RowType.Edit) // Inline-Add/Edit row
                RowAttrs.AppendClass("table-active");

            // Render row
            await RenderRow();

            // Render list options
            await RenderListOptions();
        }

        // Confirm page
        public bool ConfirmPage = false; // DN

        #pragma warning disable 1998
        // Get upload files
        public async Task GetUploadFiles()
        {
            // Get upload data
        }
        #pragma warning restore 1998

        // Load default values
        protected void LoadDefaultValues() {
            str_Username.DefaultValue = CurrentUserID();
            str_Username.OldValue = str_Username.DefaultValue;
            Section_2.DefaultValue = Section_2.GetDefault(); // DN
            Section_2.OldValue = Section_2.DefaultValue;
            Section_3.DefaultValue = Section_3.GetDefault(); // DN
            Section_3.OldValue = Section_3.DefaultValue;
            Section_4.DefaultValue = Section_4.GetDefault(); // DN
            Section_4.OldValue = Section_4.DefaultValue;
            Section_5.DefaultValue = Section_5.GetDefault(); // DN
            Section_5.OldValue = Section_5.DefaultValue;
            Section_6.DefaultValue = Section_6.GetDefault(); // DN
            Section_6.OldValue = Section_6.DefaultValue;
            Section_7.DefaultValue = Section_7.GetDefault(); // DN
            Section_7.OldValue = Section_7.DefaultValue;
            Section_8.DefaultValue = Section_8.GetDefault(); // DN
            Section_8.OldValue = Section_8.DefaultValue;
            Section_9.DefaultValue = Section_9.GetDefault(); // DN
            Section_9.OldValue = Section_9.DefaultValue;
            Section_10.DefaultValue = Section_10.GetDefault(); // DN
            Section_10.OldValue = Section_10.DefaultValue;
            Section_11.DefaultValue = Section_11.GetDefault(); // DN
            Section_11.OldValue = Section_11.DefaultValue;
            DriveTypelink.DefaultValue = DriveTypelink.GetDefault(); // DN
            DriveTypelink.OldValue = DriveTypelink.DefaultValue;
            Scores_S2.DefaultValue = Scores_S2.GetDefault(); // DN
            Scores_S2.OldValue = Scores_S2.DefaultValue;
            Scores_S3.DefaultValue = Scores_S3.GetDefault(); // DN
            Scores_S3.OldValue = Scores_S3.DefaultValue;
            Scores_S4.DefaultValue = Scores_S4.GetDefault(); // DN
            Scores_S4.OldValue = Scores_S4.DefaultValue;
            Scores_S5.DefaultValue = Scores_S5.GetDefault(); // DN
            Scores_S5.OldValue = Scores_S5.DefaultValue;
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            CurrentForm.FormName = FormName;
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
            if (CurrentForm.HasValue("o_str_Full_Name_Hdr"))
                str_Full_Name_Hdr.OldValue = CurrentForm.GetValue("o_str_Full_Name_Hdr");

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_NationalID"))
                NationalID.OldValue = CurrentForm.GetValue("o_NationalID");

            // Check field name 'str_Cell_Phone' before field var 'x_str_Cell_Phone'
            val = CurrentForm.HasValue("str_Cell_Phone") ? CurrentForm.GetValue("str_Cell_Phone") : CurrentForm.GetValue("x_str_Cell_Phone");
            if (!str_Cell_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Cell_Phone") && !CurrentForm.HasValue("x_str_Cell_Phone")) // DN
                    str_Cell_Phone.Visible = false; // Disable update for API request
                else
                    str_Cell_Phone.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_Cell_Phone"))
                str_Cell_Phone.OldValue = CurrentForm.GetValue("o_str_Cell_Phone");

            // Check field name 'intDrivinglicenseType' before field var 'x_intDrivinglicenseType'
            val = CurrentForm.HasValue("intDrivinglicenseType") ? CurrentForm.GetValue("intDrivinglicenseType") : CurrentForm.GetValue("x_intDrivinglicenseType");
            if (!intDrivinglicenseType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("intDrivinglicenseType") && !CurrentForm.HasValue("x_intDrivinglicenseType")) // DN
                    intDrivinglicenseType.Visible = false; // Disable update for API request
                else
                    intDrivinglicenseType.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_intDrivinglicenseType"))
                intDrivinglicenseType.OldValue = CurrentForm.GetValue("o_intDrivinglicenseType");

            // Check field name 'Retake' before field var 'x_Retake'
            val = CurrentForm.HasValue("Retake") ? CurrentForm.GetValue("Retake") : CurrentForm.GetValue("x_Retake");
            if (!Retake.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Retake") && !CurrentForm.HasValue("x_Retake")) // DN
                    Retake.Visible = false; // Disable update for API request
                else
                    Retake.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_Retake"))
                Retake.OldValue = CurrentForm.GetValue("o_Retake");

            // Check field name 'AbsherApptNbr' before field var 'x_AbsherApptNbr'
            val = CurrentForm.HasValue("AbsherApptNbr") ? CurrentForm.GetValue("AbsherApptNbr") : CurrentForm.GetValue("x_AbsherApptNbr");
            if (!AbsherApptNbr.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AbsherApptNbr") && !CurrentForm.HasValue("x_AbsherApptNbr")) // DN
                    AbsherApptNbr.Visible = false; // Disable update for API request
                else
                    AbsherApptNbr.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_AbsherApptNbr"))
                AbsherApptNbr.OldValue = CurrentForm.GetValue("o_AbsherApptNbr");

            // Check field name 'IsDrivingexperience' before field var 'x_IsDrivingexperience'
            val = CurrentForm.HasValue("IsDrivingexperience") ? CurrentForm.GetValue("IsDrivingexperience") : CurrentForm.GetValue("x_IsDrivingexperience");
            if (!IsDrivingexperience.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDrivingexperience") && !CurrentForm.HasValue("x_IsDrivingexperience")) // DN
                    IsDrivingexperience.Visible = false; // Disable update for API request
                else
                    IsDrivingexperience.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_IsDrivingexperience"))
                IsDrivingexperience.OldValue = CurrentForm.GetValue("o_IsDrivingexperience");

            // Check field name 'Eval_ID' before field var 'x_Eval_ID'
            val = CurrentForm.HasValue("Eval_ID") ? CurrentForm.GetValue("Eval_ID") : CurrentForm.GetValue("x_Eval_ID");
            if (!Eval_ID.IsDetailKey && !IsGridAdd && !IsAdd)
                Eval_ID.SetFormValue(val);
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            if (!IsGridAdd && !IsAdd)
                Eval_ID.CurrentValue = Eval_ID.FormValue;
            str_Full_Name_Hdr.CurrentValue = str_Full_Name_Hdr.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            str_Cell_Phone.CurrentValue = str_Cell_Phone.FormValue;
            intDrivinglicenseType.CurrentValue = intDrivinglicenseType.FormValue;
            Retake.CurrentValue = Retake.FormValue;
            AbsherApptNbr.CurrentValue = AbsherApptNbr.FormValue;
            IsDrivingexperience.CurrentValue = IsDrivingexperience.FormValue;
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
            Eval_ID.SetDbValue(row["Eval_ID"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            AssessmentID.SetDbValue(row["AssessmentID"]);
            str_Full_Name_Hdr.SetDbValue(row["str_Full_Name_Hdr"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_Cell_Phone.SetDbValue(row["str_Cell_Phone"]);
            str_Username.SetDbValue(row["str_Username"]);
            intDrivinglicenseType.SetDbValue(row["intDrivinglicenseType"]);
            Date_Entered.SetDbValue(row["Date_Entered"]);
            Examination_Number.SetDbValue(row["Examination_Number"]);
            Retake.SetDbValue((ConvertToBool(row["Retake"]) ? "1" : "0"));
            Section_1.SetDbValue(row["Section_1"]);
            Q1.SetDbValue((ConvertToBool(row["Q1"]) ? "1" : "0"));
            Q2.SetDbValue((ConvertToBool(row["Q2"]) ? "1" : "0"));
            Q3.SetDbValue((ConvertToBool(row["Q3"]) ? "1" : "0"));
            Q4.SetDbValue((ConvertToBool(row["Q4"]) ? "1" : "0"));
            Q5.SetDbValue((ConvertToBool(row["Q5"]) ? "1" : "0"));
            Section_2.SetDbValue(row["Section_2"]);
            Q6.SetDbValue((ConvertToBool(row["Q6"]) ? "1" : "0"));
            Q7.SetDbValue((ConvertToBool(row["Q7"]) ? "1" : "0"));
            Q8.SetDbValue((ConvertToBool(row["Q8"]) ? "1" : "0"));
            Q9.SetDbValue((ConvertToBool(row["Q9"]) ? "1" : "0"));
            Q10.SetDbValue((ConvertToBool(row["Q10"]) ? "1" : "0"));
            Q11.SetDbValue((ConvertToBool(row["Q11"]) ? "1" : "0"));
            Q12.SetDbValue((ConvertToBool(row["Q12"]) ? "1" : "0"));
            Q13.SetDbValue((ConvertToBool(row["Q13"]) ? "1" : "0"));
            Q14.SetDbValue((ConvertToBool(row["Q14"]) ? "1" : "0"));
            Q15.SetDbValue((ConvertToBool(row["Q15"]) ? "1" : "0"));
            Section_3.SetDbValue(row["Section_3"]);
            Q16.SetDbValue((ConvertToBool(row["Q16"]) ? "1" : "0"));
            Q17.SetDbValue((ConvertToBool(row["Q17"]) ? "1" : "0"));
            Q18.SetDbValue((ConvertToBool(row["Q18"]) ? "1" : "0"));
            Q19.SetDbValue((ConvertToBool(row["Q19"]) ? "1" : "0"));
            Q20.SetDbValue((ConvertToBool(row["Q20"]) ? "1" : "0"));
            Q21.SetDbValue((ConvertToBool(row["Q21"]) ? "1" : "0"));
            Section_4.SetDbValue(row["Section_4"]);
            Q22.SetDbValue((ConvertToBool(row["Q22"]) ? "1" : "0"));
            Q23.SetDbValue((ConvertToBool(row["Q23"]) ? "1" : "0"));
            Q24.SetDbValue((ConvertToBool(row["Q24"]) ? "1" : "0"));
            Q25.SetDbValue((ConvertToBool(row["Q25"]) ? "1" : "0"));
            Q26.SetDbValue((ConvertToBool(row["Q26"]) ? "1" : "0"));
            Section_5.SetDbValue(row["Section_5"]);
            Q27.SetDbValue((ConvertToBool(row["Q27"]) ? "1" : "0"));
            Q28.SetDbValue((ConvertToBool(row["Q28"]) ? "1" : "0"));
            Q29.SetDbValue((ConvertToBool(row["Q29"]) ? "1" : "0"));
            Q30.SetDbValue((ConvertToBool(row["Q30"]) ? "1" : "0"));
            Q31.SetDbValue((ConvertToBool(row["Q31"]) ? "1" : "0"));
            Q32.SetDbValue((ConvertToBool(row["Q32"]) ? "1" : "0"));
            Q33.SetDbValue((ConvertToBool(row["Q33"]) ? "1" : "0"));
            Q34.SetDbValue((ConvertToBool(row["Q34"]) ? "1" : "0"));
            Q35.SetDbValue((ConvertToBool(row["Q35"]) ? "1" : "0"));
            Section_6.SetDbValue(row["Section_6"]);
            Q36.SetDbValue((ConvertToBool(row["Q36"]) ? "1" : "0"));
            Q37.SetDbValue((ConvertToBool(row["Q37"]) ? "1" : "0"));
            Q38.SetDbValue((ConvertToBool(row["Q38"]) ? "1" : "0"));
            Q39.SetDbValue((ConvertToBool(row["Q39"]) ? "1" : "0"));
            Q40.SetDbValue((ConvertToBool(row["Q40"]) ? "1" : "0"));
            Q41.SetDbValue((ConvertToBool(row["Q41"]) ? "1" : "0"));
            Q42.SetDbValue((ConvertToBool(row["Q42"]) ? "1" : "0"));
            Q43.SetDbValue((ConvertToBool(row["Q43"]) ? "1" : "0"));
            Section_7.SetDbValue(row["Section_7"]);
            Q44.SetDbValue((ConvertToBool(row["Q44"]) ? "1" : "0"));
            Q45.SetDbValue((ConvertToBool(row["Q45"]) ? "1" : "0"));
            Q46.SetDbValue((ConvertToBool(row["Q46"]) ? "1" : "0"));
            Q47.SetDbValue((ConvertToBool(row["Q47"]) ? "1" : "0"));
            Q48.SetDbValue((ConvertToBool(row["Q48"]) ? "1" : "0"));
            Q49.SetDbValue((ConvertToBool(row["Q49"]) ? "1" : "0"));
            Q50.SetDbValue((ConvertToBool(row["Q50"]) ? "1" : "0"));
            Section_8.SetDbValue(row["Section_8"]);
            Q51.SetDbValue((ConvertToBool(row["Q51"]) ? "1" : "0"));
            Q52.SetDbValue((ConvertToBool(row["Q52"]) ? "1" : "0"));
            Q53.SetDbValue((ConvertToBool(row["Q53"]) ? "1" : "0"));
            Q54.SetDbValue((ConvertToBool(row["Q54"]) ? "1" : "0"));
            Q55.SetDbValue((ConvertToBool(row["Q55"]) ? "1" : "0"));
            Section_9.SetDbValue(row["Section_9"]);
            Q56.SetDbValue((ConvertToBool(row["Q56"]) ? "1" : "0"));
            Q57.SetDbValue((ConvertToBool(row["Q57"]) ? "1" : "0"));
            Q58.SetDbValue((ConvertToBool(row["Q58"]) ? "1" : "0"));
            Q59.SetDbValue((ConvertToBool(row["Q59"]) ? "1" : "0"));
            Section_10.SetDbValue(row["Section_10"]);
            Q60.SetDbValue((ConvertToBool(row["Q60"]) ? "1" : "0"));
            Q61.SetDbValue((ConvertToBool(row["Q61"]) ? "1" : "0"));
            Q62.SetDbValue((ConvertToBool(row["Q62"]) ? "1" : "0"));
            Q63.SetDbValue((ConvertToBool(row["Q63"]) ? "1" : "0"));
            Q64.SetDbValue((ConvertToBool(row["Q64"]) ? "1" : "0"));
            Q65.SetDbValue((ConvertToBool(row["Q65"]) ? "1" : "0"));
            Section_11.SetDbValue(row["Section_11"]);
            Q66.SetDbValue((ConvertToBool(row["Q66"]) ? "1" : "0"));
            Q67.SetDbValue((ConvertToBool(row["Q67"]) ? "1" : "0"));
            Q68.SetDbValue((ConvertToBool(row["Q68"]) ? "1" : "0"));
            Q69.SetDbValue((ConvertToBool(row["Q69"]) ? "1" : "0"));
            Q70.SetDbValue((ConvertToBool(row["Q70"]) ? "1" : "0"));
            Notes_3.SetDbValue(row["Notes_3"]);
            Examiner_Signature.SetDbValue(row["Examiner_Signature"]);
            Student_Signature.SetDbValue(row["Student_Signature"]);
            AbsherApptNbr.SetDbValue(row["AbsherApptNbr"]);
            IsDrivingexperience.SetDbValue((ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"));
            date_Birth_Hijri.SetDbValue(row["date_Birth_Hijri"]);
            date_Birth.SetDbValue(row["date_Birth"]);
            str_Email.SetDbValue(row["str_Email"]);
            UserlevelID.SetDbValue(row["UserlevelID"]);
            DriveTypelink.SetDbValue(row["DriveTypelink"]);
            intEvaluationType.SetDbValue(row["intEvaluationType"]);
            Institution.SetDbValue(row["Institution"]);
            Scores_S1.SetDbValue(row["Scores_S1"]);
            S1.SetDbValue((ConvertToBool(row["S1"]) ? "1" : "0"));
            S2.SetDbValue((ConvertToBool(row["S2"]) ? "1" : "0"));
            S3.SetDbValue((ConvertToBool(row["S3"]) ? "1" : "0"));
            S4.SetDbValue((ConvertToBool(row["S4"]) ? "1" : "0"));
            S5.SetDbValue((ConvertToBool(row["S5"]) ? "1" : "0"));
            Scores_S2.SetDbValue(row["Scores_S2"]);
            S6.SetDbValue((ConvertToBool(row["S6"]) ? "1" : "0"));
            S7.SetDbValue((ConvertToBool(row["S7"]) ? "1" : "0"));
            S8.SetDbValue((ConvertToBool(row["S8"]) ? "1" : "0"));
            S9.SetDbValue((ConvertToBool(row["S9"]) ? "1" : "0"));
            S10.SetDbValue((ConvertToBool(row["S10"]) ? "1" : "0"));
            S11.SetDbValue((ConvertToBool(row["S11"]) ? "1" : "0"));
            S12.SetDbValue((ConvertToBool(row["S12"]) ? "1" : "0"));
            S13.SetDbValue((ConvertToBool(row["S13"]) ? "1" : "0"));
            S14.SetDbValue((ConvertToBool(row["S14"]) ? "1" : "0"));
            S15.SetDbValue((ConvertToBool(row["S15"]) ? "1" : "0"));
            Scores_S3.SetDbValue(row["Scores_S3"]);
            S16.SetDbValue((ConvertToBool(row["S16"]) ? "1" : "0"));
            S17.SetDbValue((ConvertToBool(row["S17"]) ? "1" : "0"));
            S18.SetDbValue((ConvertToBool(row["S18"]) ? "1" : "0"));
            S19.SetDbValue((ConvertToBool(row["S19"]) ? "1" : "0"));
            S20.SetDbValue((ConvertToBool(row["S20"]) ? "1" : "0"));
            S21.SetDbValue((ConvertToBool(row["S21"]) ? "1" : "0"));
            Scores_S4.SetDbValue(row["Scores_S4"]);
            S22.SetDbValue((ConvertToBool(row["S22"]) ? "1" : "0"));
            S23.SetDbValue((ConvertToBool(row["S23"]) ? "1" : "0"));
            S24.SetDbValue((ConvertToBool(row["S24"]) ? "1" : "0"));
            S25.SetDbValue((ConvertToBool(row["S25"]) ? "1" : "0"));
            S26.SetDbValue((ConvertToBool(row["S26"]) ? "1" : "0"));
            Scores_S5.SetDbValue(row["Scores_S5"]);
            S27.SetDbValue((ConvertToBool(row["S27"]) ? "1" : "0"));
            S28.SetDbValue((ConvertToBool(row["S28"]) ? "1" : "0"));
            S29.SetDbValue((ConvertToBool(row["S29"]) ? "1" : "0"));
            S30.SetDbValue((ConvertToBool(row["S30"]) ? "1" : "0"));
            S31.SetDbValue((ConvertToBool(row["S31"]) ? "1" : "0"));
            S32.SetDbValue((ConvertToBool(row["S32"]) ? "1" : "0"));
            S33.SetDbValue((ConvertToBool(row["S33"]) ? "1" : "0"));
            S34.SetDbValue((ConvertToBool(row["S34"]) ? "1" : "0"));
            S35.SetDbValue((ConvertToBool(row["S35"]) ? "1" : "0"));
            Scores_S6.SetDbValue(row["Scores_S6"]);
            S36.SetDbValue((ConvertToBool(row["S36"]) ? "1" : "0"));
            S37.SetDbValue((ConvertToBool(row["S37"]) ? "1" : "0"));
            S38.SetDbValue((ConvertToBool(row["S38"]) ? "1" : "0"));
            S39.SetDbValue((ConvertToBool(row["S39"]) ? "1" : "0"));
            S40.SetDbValue((ConvertToBool(row["S40"]) ? "1" : "0"));
            S41.SetDbValue((ConvertToBool(row["S41"]) ? "1" : "0"));
            S42.SetDbValue((ConvertToBool(row["S42"]) ? "1" : "0"));
            S43.SetDbValue((ConvertToBool(row["S43"]) ? "1" : "0"));
            Scores_S7.SetDbValue(row["Scores_S7"]);
            S44.SetDbValue((ConvertToBool(row["S44"]) ? "1" : "0"));
            S45.SetDbValue((ConvertToBool(row["S45"]) ? "1" : "0"));
            S46.SetDbValue((ConvertToBool(row["S46"]) ? "1" : "0"));
            S47.SetDbValue((ConvertToBool(row["S47"]) ? "1" : "0"));
            S48.SetDbValue((ConvertToBool(row["S48"]) ? "1" : "0"));
            S49.SetDbValue((ConvertToBool(row["S49"]) ? "1" : "0"));
            S50.SetDbValue((ConvertToBool(row["S50"]) ? "1" : "0"));
            Scores_S8.SetDbValue(row["Scores_S8"]);
            S51.SetDbValue((ConvertToBool(row["S51"]) ? "1" : "0"));
            S52.SetDbValue((ConvertToBool(row["S52"]) ? "1" : "0"));
            S53.SetDbValue((ConvertToBool(row["S53"]) ? "1" : "0"));
            S54.SetDbValue((ConvertToBool(row["S54"]) ? "1" : "0"));
            S55.SetDbValue((ConvertToBool(row["S55"]) ? "1" : "0"));
            Scores_S9.SetDbValue(row["Scores_S9"]);
            S56.SetDbValue((ConvertToBool(row["S56"]) ? "1" : "0"));
            S57.SetDbValue((ConvertToBool(row["S57"]) ? "1" : "0"));
            S58.SetDbValue((ConvertToBool(row["S58"]) ? "1" : "0"));
            S59.SetDbValue((ConvertToBool(row["S59"]) ? "1" : "0"));
            Scores_S10.SetDbValue(row["Scores_S10"]);
            S60.SetDbValue((ConvertToBool(row["S60"]) ? "1" : "0"));
            S61.SetDbValue((ConvertToBool(row["S61"]) ? "1" : "0"));
            S62.SetDbValue((ConvertToBool(row["S62"]) ? "1" : "0"));
            S63.SetDbValue((ConvertToBool(row["S63"]) ? "1" : "0"));
            S64.SetDbValue((ConvertToBool(row["S64"]) ? "1" : "0"));
            S65.SetDbValue((ConvertToBool(row["S65"]) ? "1" : "0"));
            Scores_S11.SetDbValue(row["Scores_S11"]);
            S66.SetDbValue((ConvertToBool(row["S66"]) ? "1" : "0"));
            S67.SetDbValue((ConvertToBool(row["S67"]) ? "1" : "0"));
            S68.SetDbValue((ConvertToBool(row["S68"]) ? "1" : "0"));
            S69.SetDbValue((ConvertToBool(row["S69"]) ? "1" : "0"));
            S70.SetDbValue((ConvertToBool(row["S70"]) ? "1" : "0"));
            Evaluation_Score.SetDbValue(row["Evaluation_Score"]);
            Immediate_Failure_Score.SetDbValue(row["Immediate_Failure_Score"]);
            Required_Program.SetDbValue(row["Required_Program"]);
            Price.SetDbValue(row["Price"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("Eval_ID", Eval_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentID", AssessmentID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Full_Name_Hdr", str_Full_Name_Hdr.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Cell_Phone", str_Cell_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("intDrivinglicenseType", intDrivinglicenseType.DefaultValue ?? DbNullValue); // DN
            row.Add("Date_Entered", Date_Entered.DefaultValue ?? DbNullValue); // DN
            row.Add("Examination_Number", Examination_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("Retake", Retake.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_1", Section_1.DefaultValue ?? DbNullValue); // DN
            row.Add("Q1", Q1.DefaultValue ?? DbNullValue); // DN
            row.Add("Q2", Q2.DefaultValue ?? DbNullValue); // DN
            row.Add("Q3", Q3.DefaultValue ?? DbNullValue); // DN
            row.Add("Q4", Q4.DefaultValue ?? DbNullValue); // DN
            row.Add("Q5", Q5.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_2", Section_2.DefaultValue ?? DbNullValue); // DN
            row.Add("Q6", Q6.DefaultValue ?? DbNullValue); // DN
            row.Add("Q7", Q7.DefaultValue ?? DbNullValue); // DN
            row.Add("Q8", Q8.DefaultValue ?? DbNullValue); // DN
            row.Add("Q9", Q9.DefaultValue ?? DbNullValue); // DN
            row.Add("Q10", Q10.DefaultValue ?? DbNullValue); // DN
            row.Add("Q11", Q11.DefaultValue ?? DbNullValue); // DN
            row.Add("Q12", Q12.DefaultValue ?? DbNullValue); // DN
            row.Add("Q13", Q13.DefaultValue ?? DbNullValue); // DN
            row.Add("Q14", Q14.DefaultValue ?? DbNullValue); // DN
            row.Add("Q15", Q15.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_3", Section_3.DefaultValue ?? DbNullValue); // DN
            row.Add("Q16", Q16.DefaultValue ?? DbNullValue); // DN
            row.Add("Q17", Q17.DefaultValue ?? DbNullValue); // DN
            row.Add("Q18", Q18.DefaultValue ?? DbNullValue); // DN
            row.Add("Q19", Q19.DefaultValue ?? DbNullValue); // DN
            row.Add("Q20", Q20.DefaultValue ?? DbNullValue); // DN
            row.Add("Q21", Q21.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_4", Section_4.DefaultValue ?? DbNullValue); // DN
            row.Add("Q22", Q22.DefaultValue ?? DbNullValue); // DN
            row.Add("Q23", Q23.DefaultValue ?? DbNullValue); // DN
            row.Add("Q24", Q24.DefaultValue ?? DbNullValue); // DN
            row.Add("Q25", Q25.DefaultValue ?? DbNullValue); // DN
            row.Add("Q26", Q26.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_5", Section_5.DefaultValue ?? DbNullValue); // DN
            row.Add("Q27", Q27.DefaultValue ?? DbNullValue); // DN
            row.Add("Q28", Q28.DefaultValue ?? DbNullValue); // DN
            row.Add("Q29", Q29.DefaultValue ?? DbNullValue); // DN
            row.Add("Q30", Q30.DefaultValue ?? DbNullValue); // DN
            row.Add("Q31", Q31.DefaultValue ?? DbNullValue); // DN
            row.Add("Q32", Q32.DefaultValue ?? DbNullValue); // DN
            row.Add("Q33", Q33.DefaultValue ?? DbNullValue); // DN
            row.Add("Q34", Q34.DefaultValue ?? DbNullValue); // DN
            row.Add("Q35", Q35.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_6", Section_6.DefaultValue ?? DbNullValue); // DN
            row.Add("Q36", Q36.DefaultValue ?? DbNullValue); // DN
            row.Add("Q37", Q37.DefaultValue ?? DbNullValue); // DN
            row.Add("Q38", Q38.DefaultValue ?? DbNullValue); // DN
            row.Add("Q39", Q39.DefaultValue ?? DbNullValue); // DN
            row.Add("Q40", Q40.DefaultValue ?? DbNullValue); // DN
            row.Add("Q41", Q41.DefaultValue ?? DbNullValue); // DN
            row.Add("Q42", Q42.DefaultValue ?? DbNullValue); // DN
            row.Add("Q43", Q43.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_7", Section_7.DefaultValue ?? DbNullValue); // DN
            row.Add("Q44", Q44.DefaultValue ?? DbNullValue); // DN
            row.Add("Q45", Q45.DefaultValue ?? DbNullValue); // DN
            row.Add("Q46", Q46.DefaultValue ?? DbNullValue); // DN
            row.Add("Q47", Q47.DefaultValue ?? DbNullValue); // DN
            row.Add("Q48", Q48.DefaultValue ?? DbNullValue); // DN
            row.Add("Q49", Q49.DefaultValue ?? DbNullValue); // DN
            row.Add("Q50", Q50.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_8", Section_8.DefaultValue ?? DbNullValue); // DN
            row.Add("Q51", Q51.DefaultValue ?? DbNullValue); // DN
            row.Add("Q52", Q52.DefaultValue ?? DbNullValue); // DN
            row.Add("Q53", Q53.DefaultValue ?? DbNullValue); // DN
            row.Add("Q54", Q54.DefaultValue ?? DbNullValue); // DN
            row.Add("Q55", Q55.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_9", Section_9.DefaultValue ?? DbNullValue); // DN
            row.Add("Q56", Q56.DefaultValue ?? DbNullValue); // DN
            row.Add("Q57", Q57.DefaultValue ?? DbNullValue); // DN
            row.Add("Q58", Q58.DefaultValue ?? DbNullValue); // DN
            row.Add("Q59", Q59.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_10", Section_10.DefaultValue ?? DbNullValue); // DN
            row.Add("Q60", Q60.DefaultValue ?? DbNullValue); // DN
            row.Add("Q61", Q61.DefaultValue ?? DbNullValue); // DN
            row.Add("Q62", Q62.DefaultValue ?? DbNullValue); // DN
            row.Add("Q63", Q63.DefaultValue ?? DbNullValue); // DN
            row.Add("Q64", Q64.DefaultValue ?? DbNullValue); // DN
            row.Add("Q65", Q65.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_11", Section_11.DefaultValue ?? DbNullValue); // DN
            row.Add("Q66", Q66.DefaultValue ?? DbNullValue); // DN
            row.Add("Q67", Q67.DefaultValue ?? DbNullValue); // DN
            row.Add("Q68", Q68.DefaultValue ?? DbNullValue); // DN
            row.Add("Q69", Q69.DefaultValue ?? DbNullValue); // DN
            row.Add("Q70", Q70.DefaultValue ?? DbNullValue); // DN
            row.Add("Notes_3", Notes_3.DefaultValue ?? DbNullValue); // DN
            row.Add("Examiner_Signature", Examiner_Signature.DefaultValue ?? DbNullValue); // DN
            row.Add("Student_Signature", Student_Signature.DefaultValue ?? DbNullValue); // DN
            row.Add("AbsherApptNbr", AbsherApptNbr.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDrivingexperience", IsDrivingexperience.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth_Hijri", date_Birth_Hijri.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth", date_Birth.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email", str_Email.DefaultValue ?? DbNullValue); // DN
            row.Add("UserlevelID", UserlevelID.DefaultValue ?? DbNullValue); // DN
            row.Add("DriveTypelink", DriveTypelink.DefaultValue ?? DbNullValue); // DN
            row.Add("intEvaluationType", intEvaluationType.DefaultValue ?? DbNullValue); // DN
            row.Add("Institution", Institution.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S1", Scores_S1.DefaultValue ?? DbNullValue); // DN
            row.Add("S1", S1.DefaultValue ?? DbNullValue); // DN
            row.Add("S2", S2.DefaultValue ?? DbNullValue); // DN
            row.Add("S3", S3.DefaultValue ?? DbNullValue); // DN
            row.Add("S4", S4.DefaultValue ?? DbNullValue); // DN
            row.Add("S5", S5.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S2", Scores_S2.DefaultValue ?? DbNullValue); // DN
            row.Add("S6", S6.DefaultValue ?? DbNullValue); // DN
            row.Add("S7", S7.DefaultValue ?? DbNullValue); // DN
            row.Add("S8", S8.DefaultValue ?? DbNullValue); // DN
            row.Add("S9", S9.DefaultValue ?? DbNullValue); // DN
            row.Add("S10", S10.DefaultValue ?? DbNullValue); // DN
            row.Add("S11", S11.DefaultValue ?? DbNullValue); // DN
            row.Add("S12", S12.DefaultValue ?? DbNullValue); // DN
            row.Add("S13", S13.DefaultValue ?? DbNullValue); // DN
            row.Add("S14", S14.DefaultValue ?? DbNullValue); // DN
            row.Add("S15", S15.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S3", Scores_S3.DefaultValue ?? DbNullValue); // DN
            row.Add("S16", S16.DefaultValue ?? DbNullValue); // DN
            row.Add("S17", S17.DefaultValue ?? DbNullValue); // DN
            row.Add("S18", S18.DefaultValue ?? DbNullValue); // DN
            row.Add("S19", S19.DefaultValue ?? DbNullValue); // DN
            row.Add("S20", S20.DefaultValue ?? DbNullValue); // DN
            row.Add("S21", S21.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S4", Scores_S4.DefaultValue ?? DbNullValue); // DN
            row.Add("S22", S22.DefaultValue ?? DbNullValue); // DN
            row.Add("S23", S23.DefaultValue ?? DbNullValue); // DN
            row.Add("S24", S24.DefaultValue ?? DbNullValue); // DN
            row.Add("S25", S25.DefaultValue ?? DbNullValue); // DN
            row.Add("S26", S26.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S5", Scores_S5.DefaultValue ?? DbNullValue); // DN
            row.Add("S27", S27.DefaultValue ?? DbNullValue); // DN
            row.Add("S28", S28.DefaultValue ?? DbNullValue); // DN
            row.Add("S29", S29.DefaultValue ?? DbNullValue); // DN
            row.Add("S30", S30.DefaultValue ?? DbNullValue); // DN
            row.Add("S31", S31.DefaultValue ?? DbNullValue); // DN
            row.Add("S32", S32.DefaultValue ?? DbNullValue); // DN
            row.Add("S33", S33.DefaultValue ?? DbNullValue); // DN
            row.Add("S34", S34.DefaultValue ?? DbNullValue); // DN
            row.Add("S35", S35.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S6", Scores_S6.DefaultValue ?? DbNullValue); // DN
            row.Add("S36", S36.DefaultValue ?? DbNullValue); // DN
            row.Add("S37", S37.DefaultValue ?? DbNullValue); // DN
            row.Add("S38", S38.DefaultValue ?? DbNullValue); // DN
            row.Add("S39", S39.DefaultValue ?? DbNullValue); // DN
            row.Add("S40", S40.DefaultValue ?? DbNullValue); // DN
            row.Add("S41", S41.DefaultValue ?? DbNullValue); // DN
            row.Add("S42", S42.DefaultValue ?? DbNullValue); // DN
            row.Add("S43", S43.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S7", Scores_S7.DefaultValue ?? DbNullValue); // DN
            row.Add("S44", S44.DefaultValue ?? DbNullValue); // DN
            row.Add("S45", S45.DefaultValue ?? DbNullValue); // DN
            row.Add("S46", S46.DefaultValue ?? DbNullValue); // DN
            row.Add("S47", S47.DefaultValue ?? DbNullValue); // DN
            row.Add("S48", S48.DefaultValue ?? DbNullValue); // DN
            row.Add("S49", S49.DefaultValue ?? DbNullValue); // DN
            row.Add("S50", S50.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S8", Scores_S8.DefaultValue ?? DbNullValue); // DN
            row.Add("S51", S51.DefaultValue ?? DbNullValue); // DN
            row.Add("S52", S52.DefaultValue ?? DbNullValue); // DN
            row.Add("S53", S53.DefaultValue ?? DbNullValue); // DN
            row.Add("S54", S54.DefaultValue ?? DbNullValue); // DN
            row.Add("S55", S55.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S9", Scores_S9.DefaultValue ?? DbNullValue); // DN
            row.Add("S56", S56.DefaultValue ?? DbNullValue); // DN
            row.Add("S57", S57.DefaultValue ?? DbNullValue); // DN
            row.Add("S58", S58.DefaultValue ?? DbNullValue); // DN
            row.Add("S59", S59.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S10", Scores_S10.DefaultValue ?? DbNullValue); // DN
            row.Add("S60", S60.DefaultValue ?? DbNullValue); // DN
            row.Add("S61", S61.DefaultValue ?? DbNullValue); // DN
            row.Add("S62", S62.DefaultValue ?? DbNullValue); // DN
            row.Add("S63", S63.DefaultValue ?? DbNullValue); // DN
            row.Add("S64", S64.DefaultValue ?? DbNullValue); // DN
            row.Add("S65", S65.DefaultValue ?? DbNullValue); // DN
            row.Add("Scores_S11", Scores_S11.DefaultValue ?? DbNullValue); // DN
            row.Add("S66", S66.DefaultValue ?? DbNullValue); // DN
            row.Add("S67", S67.DefaultValue ?? DbNullValue); // DN
            row.Add("S68", S68.DefaultValue ?? DbNullValue); // DN
            row.Add("S69", S69.DefaultValue ?? DbNullValue); // DN
            row.Add("S70", S70.DefaultValue ?? DbNullValue); // DN
            row.Add("Evaluation_Score", Evaluation_Score.DefaultValue ?? DbNullValue); // DN
            row.Add("Immediate_Failure_Score", Immediate_Failure_Score.DefaultValue ?? DbNullValue); // DN
            row.Add("Required_Program", Required_Program.DefaultValue ?? DbNullValue); // DN
            row.Add("Price", Price.DefaultValue ?? DbNullValue); // DN
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

            // Eval_ID
            Eval_ID.CellCssStyle = "white-space: nowrap;";

            // int_Student_ID
            int_Student_ID.CellCssStyle = "white-space: nowrap;";

            // AssessmentID

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.CellCssStyle = "white-space: nowrap;";

            // NationalID
            NationalID.CellCssStyle = "white-space: nowrap;";

            // str_Cell_Phone
            str_Cell_Phone.CellCssStyle = "white-space: nowrap;";

            // str_Username

            // intDrivinglicenseType
            intDrivinglicenseType.CellCssStyle = "white-space: nowrap;";

            // Date_Entered

            // Examination_Number
            Examination_Number.CellCssStyle = "white-space: nowrap;";

            // Retake

            // Section_1
            Section_1.CellCssStyle = "white-space: nowrap;";

            // Q1

            // Q2

            // Q3

            // Q4

            // Q5

            // Section_2

            // Q6

            // Q7

            // Q8

            // Q9

            // Q10

            // Q11

            // Q12

            // Q13

            // Q14

            // Q15

            // Section_3

            // Q16

            // Q17

            // Q18

            // Q19

            // Q20

            // Q21

            // Section_4

            // Q22

            // Q23

            // Q24

            // Q25

            // Q26

            // Section_5

            // Q27

            // Q28

            // Q29

            // Q30

            // Q31

            // Q32

            // Q33

            // Q34

            // Q35

            // Section_6

            // Q36

            // Q37

            // Q38

            // Q39

            // Q40

            // Q41

            // Q42

            // Q43

            // Section_7

            // Q44

            // Q45

            // Q46

            // Q47

            // Q48

            // Q49

            // Q50

            // Section_8

            // Q51

            // Q52

            // Q53

            // Q54

            // Q55

            // Section_9

            // Q56

            // Q57

            // Q58

            // Q59

            // Section_10

            // Q60

            // Q61

            // Q62

            // Q63

            // Q64

            // Q65

            // Section_11

            // Q66

            // Q67

            // Q68

            // Q69

            // Q70

            // Notes_3

            // Examiner_Signature

            // Student_Signature

            // AbsherApptNbr

            // IsDrivingexperience

            // date_Birth_Hijri

            // date_Birth

            // str_Email

            // UserlevelID

            // DriveTypelink

            // intEvaluationType

            // Institution

            // Scores_S1
            Scores_S1.CellCssStyle = "white-space: nowrap;";

            // S1
            S1.CellCssStyle = "white-space: nowrap;";

            // S2
            S2.CellCssStyle = "white-space: nowrap;";

            // S3
            S3.CellCssStyle = "white-space: nowrap;";

            // S4
            S4.CellCssStyle = "white-space: nowrap;";

            // S5
            S5.CellCssStyle = "white-space: nowrap;";

            // Scores_S2
            Scores_S2.CellCssStyle = "min-width: 45px; white-space: nowrap;";

            // S6
            S6.CellCssStyle = "white-space: nowrap;";

            // S7
            S7.CellCssStyle = "white-space: nowrap;";

            // S8
            S8.CellCssStyle = "white-space: nowrap;";

            // S9
            S9.CellCssStyle = "white-space: nowrap;";

            // S10
            S10.CellCssStyle = "white-space: nowrap;";

            // S11
            S11.CellCssStyle = "white-space: nowrap;";

            // S12
            S12.CellCssStyle = "white-space: nowrap;";

            // S13
            S13.CellCssStyle = "white-space: nowrap;";

            // S14
            S14.CellCssStyle = "white-space: nowrap;";

            // S15
            S15.CellCssStyle = "white-space: nowrap;";

            // Scores_S3
            Scores_S3.CellCssStyle = "white-space: nowrap;";

            // S16
            S16.CellCssStyle = "white-space: nowrap;";

            // S17
            S17.CellCssStyle = "white-space: nowrap;";

            // S18
            S18.CellCssStyle = "white-space: nowrap;";

            // S19
            S19.CellCssStyle = "white-space: nowrap;";

            // S20
            S20.CellCssStyle = "white-space: nowrap;";

            // S21
            S21.CellCssStyle = "white-space: nowrap;";

            // Scores_S4
            Scores_S4.CellCssStyle = "white-space: nowrap;";

            // S22
            S22.CellCssStyle = "white-space: nowrap;";

            // S23
            S23.CellCssStyle = "white-space: nowrap;";

            // S24

            // S25
            S25.CellCssStyle = "white-space: nowrap;";

            // S26
            S26.CellCssStyle = "white-space: nowrap;";

            // Scores_S5
            Scores_S5.CellCssStyle = "white-space: nowrap;";

            // S27
            S27.CellCssStyle = "white-space: nowrap;";

            // S28
            S28.CellCssStyle = "white-space: nowrap;";

            // S29
            S29.CellCssStyle = "white-space: nowrap;";

            // S30
            S30.CellCssStyle = "white-space: nowrap;";

            // S31
            S31.CellCssStyle = "white-space: nowrap;";

            // S32
            S32.CellCssStyle = "white-space: nowrap;";

            // S33
            S33.CellCssStyle = "white-space: nowrap;";

            // S34
            S34.CellCssStyle = "white-space: nowrap;";

            // S35
            S35.CellCssStyle = "white-space: nowrap;";

            // Scores_S6
            Scores_S6.CellCssStyle = "white-space: nowrap;";

            // S36
            S36.CellCssStyle = "white-space: nowrap;";

            // S37
            S37.CellCssStyle = "white-space: nowrap;";

            // S38
            S38.CellCssStyle = "white-space: nowrap;";

            // S39
            S39.CellCssStyle = "white-space: nowrap;";

            // S40
            S40.CellCssStyle = "white-space: nowrap;";

            // S41
            S41.CellCssStyle = "white-space: nowrap;";

            // S42
            S42.CellCssStyle = "white-space: nowrap;";

            // S43
            S43.CellCssStyle = "white-space: nowrap;";

            // Scores_S7
            Scores_S7.CellCssStyle = "white-space: nowrap;";

            // S44
            S44.CellCssStyle = "white-space: nowrap;";

            // S45
            S45.CellCssStyle = "white-space: nowrap;";

            // S46
            S46.CellCssStyle = "white-space: nowrap;";

            // S47
            S47.CellCssStyle = "white-space: nowrap;";

            // S48
            S48.CellCssStyle = "white-space: nowrap;";

            // S49
            S49.CellCssStyle = "white-space: nowrap;";

            // S50
            S50.CellCssStyle = "white-space: nowrap;";

            // Scores_S8
            Scores_S8.CellCssStyle = "white-space: nowrap;";

            // S51
            S51.CellCssStyle = "white-space: nowrap;";

            // S52
            S52.CellCssStyle = "white-space: nowrap;";

            // S53
            S53.CellCssStyle = "white-space: nowrap;";

            // S54
            S54.CellCssStyle = "white-space: nowrap;";

            // S55
            S55.CellCssStyle = "white-space: nowrap;";

            // Scores_S9
            Scores_S9.CellCssStyle = "white-space: nowrap;";

            // S56
            S56.CellCssStyle = "white-space: nowrap;";

            // S57
            S57.CellCssStyle = "white-space: nowrap;";

            // S58
            S58.CellCssStyle = "white-space: nowrap;";

            // S59
            S59.CellCssStyle = "white-space: nowrap;";

            // Scores_S10
            Scores_S10.CellCssStyle = "white-space: nowrap;";

            // S60
            S60.CellCssStyle = "white-space: nowrap;";

            // S61
            S61.CellCssStyle = "white-space: nowrap;";

            // S62
            S62.CellCssStyle = "white-space: nowrap;";

            // S63
            S63.CellCssStyle = "white-space: nowrap;";

            // S64
            S64.CellCssStyle = "white-space: nowrap;";

            // S65
            S65.CellCssStyle = "white-space: nowrap;";

            // Scores_S11
            Scores_S11.CellCssStyle = "white-space: nowrap;";

            // S66
            S66.CellCssStyle = "white-space: nowrap;";

            // S67
            S67.CellCssStyle = "white-space: nowrap;";

            // S68
            S68.CellCssStyle = "white-space: nowrap;";

            // S69
            S69.CellCssStyle = "white-space: nowrap;";

            // S70
            S70.CellCssStyle = "white-space: nowrap;";

            // Evaluation_Score
            Evaluation_Score.CellCssStyle = "white-space: nowrap;";

            // Immediate_Failure_Score
            Immediate_Failure_Score.CellCssStyle = "white-space: nowrap;";

            // Required_Program
            Required_Program.CellCssStyle = "white-space: nowrap;";

            // Price
            Price.CellCssStyle = "white-space: nowrap;";

            // View row
            if (RowType == RowType.View) {
                // AssessmentID
                AssessmentID.ViewValue = AssessmentID.CurrentValue;
                AssessmentID.ViewValue = FormatNumber(AssessmentID.ViewValue, AssessmentID.FormatPattern);
                AssessmentID.ViewCustomAttributes = "";

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.ViewValue = ConvertToString(str_Full_Name_Hdr.CurrentValue); // DN
                str_Full_Name_Hdr.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
                NationalID.ViewCustomAttributes = "";

                // str_Cell_Phone
                str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
                str_Cell_Phone.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = str_Username.CurrentValue;
                str_Username.ViewCustomAttributes = "";

                // intDrivinglicenseType
                intDrivinglicenseType.ViewValue = intDrivinglicenseType.CurrentValue;
                intDrivinglicenseType.ViewValue = FormatNumber(intDrivinglicenseType.ViewValue, intDrivinglicenseType.FormatPattern);
                intDrivinglicenseType.CellCssStyle += "text-align: center;";
                intDrivinglicenseType.ViewCustomAttributes = "";

                // Date_Entered
                Date_Entered.ViewValue = Date_Entered.CurrentValue;
                Date_Entered.ViewValue = FormatDateTime(Date_Entered.ViewValue, Date_Entered.FormatPattern);
                Date_Entered.ViewCustomAttributes = "";

                // Examination_Number
                Examination_Number.ViewValue = Examination_Number.CurrentValue;
                Examination_Number.ViewValue = FormatNumber(Examination_Number.ViewValue, Examination_Number.FormatPattern);
                Examination_Number.ViewCustomAttributes = "";

                // Retake
                if (ConvertToBool(Retake.CurrentValue)) {
                    Retake.ViewValue = Retake.TagCaption(1) != "" ? Retake.TagCaption(1) : "Yes";
                } else {
                    Retake.ViewValue = Retake.TagCaption(2) != "" ? Retake.TagCaption(2) : "No";
                }
                Retake.ViewCustomAttributes = "";

                // Q1
                if (ConvertToBool(Q1.CurrentValue)) {
                    Q1.ViewValue = Q1.TagCaption(1) != "" ? Q1.TagCaption(1) : "Yes";
                } else {
                    Q1.ViewValue = Q1.TagCaption(2) != "" ? Q1.TagCaption(2) : "No";
                }
                Q1.ViewCustomAttributes = "";

                // Q2
                if (ConvertToBool(Q2.CurrentValue)) {
                    Q2.ViewValue = Q2.TagCaption(1) != "" ? Q2.TagCaption(1) : "Yes";
                } else {
                    Q2.ViewValue = Q2.TagCaption(2) != "" ? Q2.TagCaption(2) : "No";
                }
                Q2.ViewCustomAttributes = "";

                // Q3
                if (ConvertToBool(Q3.CurrentValue)) {
                    Q3.ViewValue = Q3.TagCaption(1) != "" ? Q3.TagCaption(1) : "Yes";
                } else {
                    Q3.ViewValue = Q3.TagCaption(2) != "" ? Q3.TagCaption(2) : "No";
                }
                Q3.ViewCustomAttributes = "";

                // Q4
                if (ConvertToBool(Q4.CurrentValue)) {
                    Q4.ViewValue = Q4.TagCaption(1) != "" ? Q4.TagCaption(1) : "Yes";
                } else {
                    Q4.ViewValue = Q4.TagCaption(2) != "" ? Q4.TagCaption(2) : "No";
                }
                Q4.ViewCustomAttributes = "";

                // Q5
                if (ConvertToBool(Q5.CurrentValue)) {
                    Q5.ViewValue = Q5.TagCaption(1) != "" ? Q5.TagCaption(1) : "Yes";
                } else {
                    Q5.ViewValue = Q5.TagCaption(2) != "" ? Q5.TagCaption(2) : "No";
                }
                Q5.ViewCustomAttributes = "";

                // Section_2
                Section_2.ViewValue = ConvertToString(Section_2.CurrentValue); // DN
                Section_2.ViewCustomAttributes = "";

                // Q6
                if (ConvertToBool(Q6.CurrentValue)) {
                    Q6.ViewValue = Q6.TagCaption(1) != "" ? Q6.TagCaption(1) : "Yes";
                } else {
                    Q6.ViewValue = Q6.TagCaption(2) != "" ? Q6.TagCaption(2) : "No";
                }
                Q6.ViewCustomAttributes = "";

                // Q7
                if (ConvertToBool(Q7.CurrentValue)) {
                    Q7.ViewValue = Q7.TagCaption(1) != "" ? Q7.TagCaption(1) : "Yes";
                } else {
                    Q7.ViewValue = Q7.TagCaption(2) != "" ? Q7.TagCaption(2) : "No";
                }
                Q7.ViewCustomAttributes = "";

                // Q8
                if (ConvertToBool(Q8.CurrentValue)) {
                    Q8.ViewValue = Q8.TagCaption(1) != "" ? Q8.TagCaption(1) : "Yes";
                } else {
                    Q8.ViewValue = Q8.TagCaption(2) != "" ? Q8.TagCaption(2) : "No";
                }
                Q8.ViewCustomAttributes = "";

                // Q9
                if (ConvertToBool(Q9.CurrentValue)) {
                    Q9.ViewValue = Q9.TagCaption(1) != "" ? Q9.TagCaption(1) : "Yes";
                } else {
                    Q9.ViewValue = Q9.TagCaption(2) != "" ? Q9.TagCaption(2) : "No";
                }
                Q9.ViewCustomAttributes = "";

                // Q10
                if (ConvertToBool(Q10.CurrentValue)) {
                    Q10.ViewValue = Q10.TagCaption(1) != "" ? Q10.TagCaption(1) : "Yes";
                } else {
                    Q10.ViewValue = Q10.TagCaption(2) != "" ? Q10.TagCaption(2) : "No";
                }
                Q10.ViewCustomAttributes = "";

                // Q11
                if (ConvertToBool(Q11.CurrentValue)) {
                    Q11.ViewValue = Q11.TagCaption(1) != "" ? Q11.TagCaption(1) : "Yes";
                } else {
                    Q11.ViewValue = Q11.TagCaption(2) != "" ? Q11.TagCaption(2) : "No";
                }
                Q11.ViewCustomAttributes = "";

                // Q12
                if (ConvertToBool(Q12.CurrentValue)) {
                    Q12.ViewValue = Q12.TagCaption(1) != "" ? Q12.TagCaption(1) : "Yes";
                } else {
                    Q12.ViewValue = Q12.TagCaption(2) != "" ? Q12.TagCaption(2) : "No";
                }
                Q12.ViewCustomAttributes = "";

                // Q13
                if (ConvertToBool(Q13.CurrentValue)) {
                    Q13.ViewValue = Q13.TagCaption(1) != "" ? Q13.TagCaption(1) : "Yes";
                } else {
                    Q13.ViewValue = Q13.TagCaption(2) != "" ? Q13.TagCaption(2) : "No";
                }
                Q13.ViewCustomAttributes = "";

                // Q14
                if (ConvertToBool(Q14.CurrentValue)) {
                    Q14.ViewValue = Q14.TagCaption(1) != "" ? Q14.TagCaption(1) : "Yes";
                } else {
                    Q14.ViewValue = Q14.TagCaption(2) != "" ? Q14.TagCaption(2) : "No";
                }
                Q14.ViewCustomAttributes = "";

                // Q15
                if (ConvertToBool(Q15.CurrentValue)) {
                    Q15.ViewValue = Q15.TagCaption(1) != "" ? Q15.TagCaption(1) : "Yes";
                } else {
                    Q15.ViewValue = Q15.TagCaption(2) != "" ? Q15.TagCaption(2) : "No";
                }
                Q15.ViewCustomAttributes = "";

                // Section_3
                Section_3.ViewValue = ConvertToString(Section_3.CurrentValue); // DN
                Section_3.ViewCustomAttributes = "";

                // Q16
                if (ConvertToBool(Q16.CurrentValue)) {
                    Q16.ViewValue = Q16.TagCaption(1) != "" ? Q16.TagCaption(1) : "Yes";
                } else {
                    Q16.ViewValue = Q16.TagCaption(2) != "" ? Q16.TagCaption(2) : "No";
                }
                Q16.ViewCustomAttributes = "";

                // Q17
                if (ConvertToBool(Q17.CurrentValue)) {
                    Q17.ViewValue = Q17.TagCaption(1) != "" ? Q17.TagCaption(1) : "Yes";
                } else {
                    Q17.ViewValue = Q17.TagCaption(2) != "" ? Q17.TagCaption(2) : "No";
                }
                Q17.ViewCustomAttributes = "";

                // Q18
                if (ConvertToBool(Q18.CurrentValue)) {
                    Q18.ViewValue = Q18.TagCaption(1) != "" ? Q18.TagCaption(1) : "Yes";
                } else {
                    Q18.ViewValue = Q18.TagCaption(2) != "" ? Q18.TagCaption(2) : "No";
                }
                Q18.ViewCustomAttributes = "";

                // Q19
                if (ConvertToBool(Q19.CurrentValue)) {
                    Q19.ViewValue = Q19.TagCaption(1) != "" ? Q19.TagCaption(1) : "Yes";
                } else {
                    Q19.ViewValue = Q19.TagCaption(2) != "" ? Q19.TagCaption(2) : "No";
                }
                Q19.ViewCustomAttributes = "";

                // Q20
                if (ConvertToBool(Q20.CurrentValue)) {
                    Q20.ViewValue = Q20.TagCaption(1) != "" ? Q20.TagCaption(1) : "Yes";
                } else {
                    Q20.ViewValue = Q20.TagCaption(2) != "" ? Q20.TagCaption(2) : "No";
                }
                Q20.ViewCustomAttributes = "";

                // Q21
                if (ConvertToBool(Q21.CurrentValue)) {
                    Q21.ViewValue = Q21.TagCaption(1) != "" ? Q21.TagCaption(1) : "Yes";
                } else {
                    Q21.ViewValue = Q21.TagCaption(2) != "" ? Q21.TagCaption(2) : "No";
                }
                Q21.ViewCustomAttributes = "";

                // Section_4
                Section_4.ViewValue = ConvertToString(Section_4.CurrentValue); // DN
                Section_4.ViewCustomAttributes = "";

                // Q22
                if (ConvertToBool(Q22.CurrentValue)) {
                    Q22.ViewValue = Q22.TagCaption(1) != "" ? Q22.TagCaption(1) : "Yes";
                } else {
                    Q22.ViewValue = Q22.TagCaption(2) != "" ? Q22.TagCaption(2) : "No";
                }
                Q22.ViewCustomAttributes = "";

                // Q23
                if (ConvertToBool(Q23.CurrentValue)) {
                    Q23.ViewValue = Q23.TagCaption(1) != "" ? Q23.TagCaption(1) : "Yes";
                } else {
                    Q23.ViewValue = Q23.TagCaption(2) != "" ? Q23.TagCaption(2) : "No";
                }
                Q23.ViewCustomAttributes = "";

                // Q24
                if (ConvertToBool(Q24.CurrentValue)) {
                    Q24.ViewValue = Q24.TagCaption(1) != "" ? Q24.TagCaption(1) : "Yes";
                } else {
                    Q24.ViewValue = Q24.TagCaption(2) != "" ? Q24.TagCaption(2) : "No";
                }
                Q24.ViewCustomAttributes = "";

                // Q25
                if (ConvertToBool(Q25.CurrentValue)) {
                    Q25.ViewValue = Q25.TagCaption(1) != "" ? Q25.TagCaption(1) : "Yes";
                } else {
                    Q25.ViewValue = Q25.TagCaption(2) != "" ? Q25.TagCaption(2) : "No";
                }
                Q25.ViewCustomAttributes = "";

                // Q26
                if (ConvertToBool(Q26.CurrentValue)) {
                    Q26.ViewValue = Q26.TagCaption(1) != "" ? Q26.TagCaption(1) : "Yes";
                } else {
                    Q26.ViewValue = Q26.TagCaption(2) != "" ? Q26.TagCaption(2) : "No";
                }
                Q26.ViewCustomAttributes = "";

                // Section_5
                Section_5.ViewValue = ConvertToString(Section_5.CurrentValue); // DN
                Section_5.ViewCustomAttributes = "";

                // Q27
                if (ConvertToBool(Q27.CurrentValue)) {
                    Q27.ViewValue = Q27.TagCaption(1) != "" ? Q27.TagCaption(1) : "Yes";
                } else {
                    Q27.ViewValue = Q27.TagCaption(2) != "" ? Q27.TagCaption(2) : "No";
                }
                Q27.ViewCustomAttributes = "";

                // Q28
                if (ConvertToBool(Q28.CurrentValue)) {
                    Q28.ViewValue = Q28.TagCaption(1) != "" ? Q28.TagCaption(1) : "Yes";
                } else {
                    Q28.ViewValue = Q28.TagCaption(2) != "" ? Q28.TagCaption(2) : "No";
                }
                Q28.ViewCustomAttributes = "";

                // Q29
                if (ConvertToBool(Q29.CurrentValue)) {
                    Q29.ViewValue = Q29.TagCaption(1) != "" ? Q29.TagCaption(1) : "Yes";
                } else {
                    Q29.ViewValue = Q29.TagCaption(2) != "" ? Q29.TagCaption(2) : "No";
                }
                Q29.ViewCustomAttributes = "";

                // Q30
                if (ConvertToBool(Q30.CurrentValue)) {
                    Q30.ViewValue = Q30.TagCaption(1) != "" ? Q30.TagCaption(1) : "Yes";
                } else {
                    Q30.ViewValue = Q30.TagCaption(2) != "" ? Q30.TagCaption(2) : "No";
                }
                Q30.ViewCustomAttributes = "";

                // Q31
                if (ConvertToBool(Q31.CurrentValue)) {
                    Q31.ViewValue = Q31.TagCaption(1) != "" ? Q31.TagCaption(1) : "Yes";
                } else {
                    Q31.ViewValue = Q31.TagCaption(2) != "" ? Q31.TagCaption(2) : "No";
                }
                Q31.ViewCustomAttributes = "";

                // Q32
                if (ConvertToBool(Q32.CurrentValue)) {
                    Q32.ViewValue = Q32.TagCaption(1) != "" ? Q32.TagCaption(1) : "Yes";
                } else {
                    Q32.ViewValue = Q32.TagCaption(2) != "" ? Q32.TagCaption(2) : "No";
                }
                Q32.ViewCustomAttributes = "";

                // Q33
                if (ConvertToBool(Q33.CurrentValue)) {
                    Q33.ViewValue = Q33.TagCaption(1) != "" ? Q33.TagCaption(1) : "Yes";
                } else {
                    Q33.ViewValue = Q33.TagCaption(2) != "" ? Q33.TagCaption(2) : "No";
                }
                Q33.ViewCustomAttributes = "";

                // Q34
                if (ConvertToBool(Q34.CurrentValue)) {
                    Q34.ViewValue = Q34.TagCaption(1) != "" ? Q34.TagCaption(1) : "Yes";
                } else {
                    Q34.ViewValue = Q34.TagCaption(2) != "" ? Q34.TagCaption(2) : "No";
                }
                Q34.ViewCustomAttributes = "";

                // Q35
                if (ConvertToBool(Q35.CurrentValue)) {
                    Q35.ViewValue = Q35.TagCaption(1) != "" ? Q35.TagCaption(1) : "Yes";
                } else {
                    Q35.ViewValue = Q35.TagCaption(2) != "" ? Q35.TagCaption(2) : "No";
                }
                Q35.ViewCustomAttributes = "";

                // Section_6
                Section_6.ViewValue = ConvertToString(Section_6.CurrentValue); // DN
                Section_6.ViewCustomAttributes = "";

                // Q36
                if (ConvertToBool(Q36.CurrentValue)) {
                    Q36.ViewValue = Q36.TagCaption(1) != "" ? Q36.TagCaption(1) : "Yes";
                } else {
                    Q36.ViewValue = Q36.TagCaption(2) != "" ? Q36.TagCaption(2) : "No";
                }
                Q36.ViewCustomAttributes = "";

                // Q37
                if (ConvertToBool(Q37.CurrentValue)) {
                    Q37.ViewValue = Q37.TagCaption(1) != "" ? Q37.TagCaption(1) : "Yes";
                } else {
                    Q37.ViewValue = Q37.TagCaption(2) != "" ? Q37.TagCaption(2) : "No";
                }
                Q37.ViewCustomAttributes = "";

                // Q38
                if (ConvertToBool(Q38.CurrentValue)) {
                    Q38.ViewValue = Q38.TagCaption(1) != "" ? Q38.TagCaption(1) : "Yes";
                } else {
                    Q38.ViewValue = Q38.TagCaption(2) != "" ? Q38.TagCaption(2) : "No";
                }
                Q38.ViewCustomAttributes = "";

                // Q39
                if (ConvertToBool(Q39.CurrentValue)) {
                    Q39.ViewValue = Q39.TagCaption(1) != "" ? Q39.TagCaption(1) : "Yes";
                } else {
                    Q39.ViewValue = Q39.TagCaption(2) != "" ? Q39.TagCaption(2) : "No";
                }
                Q39.ViewCustomAttributes = "";

                // Q40
                if (ConvertToBool(Q40.CurrentValue)) {
                    Q40.ViewValue = Q40.TagCaption(1) != "" ? Q40.TagCaption(1) : "Yes";
                } else {
                    Q40.ViewValue = Q40.TagCaption(2) != "" ? Q40.TagCaption(2) : "No";
                }
                Q40.ViewCustomAttributes = "";

                // Q41
                if (ConvertToBool(Q41.CurrentValue)) {
                    Q41.ViewValue = Q41.TagCaption(1) != "" ? Q41.TagCaption(1) : "Yes";
                } else {
                    Q41.ViewValue = Q41.TagCaption(2) != "" ? Q41.TagCaption(2) : "No";
                }
                Q41.ViewCustomAttributes = "";

                // Q42
                if (ConvertToBool(Q42.CurrentValue)) {
                    Q42.ViewValue = Q42.TagCaption(1) != "" ? Q42.TagCaption(1) : "Yes";
                } else {
                    Q42.ViewValue = Q42.TagCaption(2) != "" ? Q42.TagCaption(2) : "No";
                }
                Q42.ViewCustomAttributes = "";

                // Q43
                if (ConvertToBool(Q43.CurrentValue)) {
                    Q43.ViewValue = Q43.TagCaption(1) != "" ? Q43.TagCaption(1) : "Yes";
                } else {
                    Q43.ViewValue = Q43.TagCaption(2) != "" ? Q43.TagCaption(2) : "No";
                }
                Q43.ViewCustomAttributes = "";

                // Section_7
                Section_7.ViewValue = ConvertToString(Section_7.CurrentValue); // DN
                Section_7.ViewCustomAttributes = "";

                // Q44
                if (ConvertToBool(Q44.CurrentValue)) {
                    Q44.ViewValue = Q44.TagCaption(1) != "" ? Q44.TagCaption(1) : "Yes";
                } else {
                    Q44.ViewValue = Q44.TagCaption(2) != "" ? Q44.TagCaption(2) : "No";
                }
                Q44.ViewCustomAttributes = "";

                // Q45
                if (ConvertToBool(Q45.CurrentValue)) {
                    Q45.ViewValue = Q45.TagCaption(1) != "" ? Q45.TagCaption(1) : "Yes";
                } else {
                    Q45.ViewValue = Q45.TagCaption(2) != "" ? Q45.TagCaption(2) : "No";
                }
                Q45.ViewCustomAttributes = "";

                // Q46
                if (ConvertToBool(Q46.CurrentValue)) {
                    Q46.ViewValue = Q46.TagCaption(1) != "" ? Q46.TagCaption(1) : "Yes";
                } else {
                    Q46.ViewValue = Q46.TagCaption(2) != "" ? Q46.TagCaption(2) : "No";
                }
                Q46.ViewCustomAttributes = "";

                // Q47
                if (ConvertToBool(Q47.CurrentValue)) {
                    Q47.ViewValue = Q47.TagCaption(1) != "" ? Q47.TagCaption(1) : "Yes";
                } else {
                    Q47.ViewValue = Q47.TagCaption(2) != "" ? Q47.TagCaption(2) : "No";
                }
                Q47.ViewCustomAttributes = "";

                // Q48
                if (ConvertToBool(Q48.CurrentValue)) {
                    Q48.ViewValue = Q48.TagCaption(1) != "" ? Q48.TagCaption(1) : "Yes";
                } else {
                    Q48.ViewValue = Q48.TagCaption(2) != "" ? Q48.TagCaption(2) : "No";
                }
                Q48.ViewCustomAttributes = "";

                // Q49
                if (ConvertToBool(Q49.CurrentValue)) {
                    Q49.ViewValue = Q49.TagCaption(1) != "" ? Q49.TagCaption(1) : "Yes";
                } else {
                    Q49.ViewValue = Q49.TagCaption(2) != "" ? Q49.TagCaption(2) : "No";
                }
                Q49.ViewCustomAttributes = "";

                // Q50
                if (ConvertToBool(Q50.CurrentValue)) {
                    Q50.ViewValue = Q50.TagCaption(1) != "" ? Q50.TagCaption(1) : "Yes";
                } else {
                    Q50.ViewValue = Q50.TagCaption(2) != "" ? Q50.TagCaption(2) : "No";
                }
                Q50.ViewCustomAttributes = "";

                // Section_8
                Section_8.ViewValue = ConvertToString(Section_8.CurrentValue); // DN
                Section_8.ViewCustomAttributes = "";

                // Q51
                if (ConvertToBool(Q51.CurrentValue)) {
                    Q51.ViewValue = Q51.TagCaption(1) != "" ? Q51.TagCaption(1) : "Yes";
                } else {
                    Q51.ViewValue = Q51.TagCaption(2) != "" ? Q51.TagCaption(2) : "No";
                }
                Q51.ViewCustomAttributes = "";

                // Q52
                if (ConvertToBool(Q52.CurrentValue)) {
                    Q52.ViewValue = Q52.TagCaption(1) != "" ? Q52.TagCaption(1) : "Yes";
                } else {
                    Q52.ViewValue = Q52.TagCaption(2) != "" ? Q52.TagCaption(2) : "No";
                }
                Q52.ViewCustomAttributes = "";

                // Q53
                if (ConvertToBool(Q53.CurrentValue)) {
                    Q53.ViewValue = Q53.TagCaption(1) != "" ? Q53.TagCaption(1) : "Yes";
                } else {
                    Q53.ViewValue = Q53.TagCaption(2) != "" ? Q53.TagCaption(2) : "No";
                }
                Q53.ViewCustomAttributes = "";

                // Q54
                if (ConvertToBool(Q54.CurrentValue)) {
                    Q54.ViewValue = Q54.TagCaption(1) != "" ? Q54.TagCaption(1) : "Yes";
                } else {
                    Q54.ViewValue = Q54.TagCaption(2) != "" ? Q54.TagCaption(2) : "No";
                }
                Q54.ViewCustomAttributes = "";

                // Q55
                if (ConvertToBool(Q55.CurrentValue)) {
                    Q55.ViewValue = Q55.TagCaption(1) != "" ? Q55.TagCaption(1) : "Yes";
                } else {
                    Q55.ViewValue = Q55.TagCaption(2) != "" ? Q55.TagCaption(2) : "No";
                }
                Q55.ViewCustomAttributes = "";

                // Section_9
                Section_9.ViewValue = ConvertToString(Section_9.CurrentValue); // DN
                Section_9.ViewCustomAttributes = "";

                // Q56
                if (ConvertToBool(Q56.CurrentValue)) {
                    Q56.ViewValue = Q56.TagCaption(1) != "" ? Q56.TagCaption(1) : "Yes";
                } else {
                    Q56.ViewValue = Q56.TagCaption(2) != "" ? Q56.TagCaption(2) : "No";
                }
                Q56.ViewCustomAttributes = "";

                // Q57
                if (ConvertToBool(Q57.CurrentValue)) {
                    Q57.ViewValue = Q57.TagCaption(1) != "" ? Q57.TagCaption(1) : "Yes";
                } else {
                    Q57.ViewValue = Q57.TagCaption(2) != "" ? Q57.TagCaption(2) : "No";
                }
                Q57.ViewCustomAttributes = "";

                // Q58
                if (ConvertToBool(Q58.CurrentValue)) {
                    Q58.ViewValue = Q58.TagCaption(1) != "" ? Q58.TagCaption(1) : "Yes";
                } else {
                    Q58.ViewValue = Q58.TagCaption(2) != "" ? Q58.TagCaption(2) : "No";
                }
                Q58.ViewCustomAttributes = "";

                // Q59
                if (ConvertToBool(Q59.CurrentValue)) {
                    Q59.ViewValue = Q59.TagCaption(1) != "" ? Q59.TagCaption(1) : "Yes";
                } else {
                    Q59.ViewValue = Q59.TagCaption(2) != "" ? Q59.TagCaption(2) : "No";
                }
                Q59.ViewCustomAttributes = "";

                // Section_10
                Section_10.ViewValue = ConvertToString(Section_10.CurrentValue); // DN
                Section_10.ViewCustomAttributes = "";

                // Q60
                if (ConvertToBool(Q60.CurrentValue)) {
                    Q60.ViewValue = Q60.TagCaption(1) != "" ? Q60.TagCaption(1) : "Yes";
                } else {
                    Q60.ViewValue = Q60.TagCaption(2) != "" ? Q60.TagCaption(2) : "No";
                }
                Q60.ViewCustomAttributes = "";

                // Q61
                if (ConvertToBool(Q61.CurrentValue)) {
                    Q61.ViewValue = Q61.TagCaption(1) != "" ? Q61.TagCaption(1) : "Yes";
                } else {
                    Q61.ViewValue = Q61.TagCaption(2) != "" ? Q61.TagCaption(2) : "No";
                }
                Q61.ViewCustomAttributes = "";

                // Q62
                if (ConvertToBool(Q62.CurrentValue)) {
                    Q62.ViewValue = Q62.TagCaption(1) != "" ? Q62.TagCaption(1) : "Yes";
                } else {
                    Q62.ViewValue = Q62.TagCaption(2) != "" ? Q62.TagCaption(2) : "No";
                }
                Q62.ViewCustomAttributes = "";

                // Q63
                if (ConvertToBool(Q63.CurrentValue)) {
                    Q63.ViewValue = Q63.TagCaption(1) != "" ? Q63.TagCaption(1) : "Yes";
                } else {
                    Q63.ViewValue = Q63.TagCaption(2) != "" ? Q63.TagCaption(2) : "No";
                }
                Q63.ViewCustomAttributes = "";

                // Q64
                if (ConvertToBool(Q64.CurrentValue)) {
                    Q64.ViewValue = Q64.TagCaption(1) != "" ? Q64.TagCaption(1) : "Yes";
                } else {
                    Q64.ViewValue = Q64.TagCaption(2) != "" ? Q64.TagCaption(2) : "No";
                }
                Q64.ViewCustomAttributes = "";

                // Q65
                if (ConvertToBool(Q65.CurrentValue)) {
                    Q65.ViewValue = Q65.TagCaption(1) != "" ? Q65.TagCaption(1) : "Yes";
                } else {
                    Q65.ViewValue = Q65.TagCaption(2) != "" ? Q65.TagCaption(2) : "No";
                }
                Q65.ViewCustomAttributes = "";

                // Section_11
                Section_11.ViewValue = ConvertToString(Section_11.CurrentValue); // DN
                Section_11.ViewCustomAttributes = "";

                // Q66
                if (ConvertToBool(Q66.CurrentValue)) {
                    Q66.ViewValue = Q66.TagCaption(1) != "" ? Q66.TagCaption(1) : "Yes";
                } else {
                    Q66.ViewValue = Q66.TagCaption(2) != "" ? Q66.TagCaption(2) : "No";
                }
                Q66.ViewCustomAttributes = "";

                // Q67
                if (ConvertToBool(Q67.CurrentValue)) {
                    Q67.ViewValue = Q67.TagCaption(1) != "" ? Q67.TagCaption(1) : "Yes";
                } else {
                    Q67.ViewValue = Q67.TagCaption(2) != "" ? Q67.TagCaption(2) : "No";
                }
                Q67.ViewCustomAttributes = "";

                // Q68
                if (ConvertToBool(Q68.CurrentValue)) {
                    Q68.ViewValue = Q68.TagCaption(1) != "" ? Q68.TagCaption(1) : "Yes";
                } else {
                    Q68.ViewValue = Q68.TagCaption(2) != "" ? Q68.TagCaption(2) : "No";
                }
                Q68.ViewCustomAttributes = "";

                // Q69
                if (ConvertToBool(Q69.CurrentValue)) {
                    Q69.ViewValue = Q69.TagCaption(1) != "" ? Q69.TagCaption(1) : "Yes";
                } else {
                    Q69.ViewValue = Q69.TagCaption(2) != "" ? Q69.TagCaption(2) : "No";
                }
                Q69.ViewCustomAttributes = "";

                // Q70
                if (ConvertToBool(Q70.CurrentValue)) {
                    Q70.ViewValue = Q70.TagCaption(1) != "" ? Q70.TagCaption(1) : "Yes";
                } else {
                    Q70.ViewValue = Q70.TagCaption(2) != "" ? Q70.TagCaption(2) : "No";
                }
                Q70.ViewCustomAttributes = "";

                // AbsherApptNbr
                AbsherApptNbr.ViewValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
                AbsherApptNbr.ViewCustomAttributes = "";

                // IsDrivingexperience
                if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
                } else {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
                }
                IsDrivingexperience.CellCssStyle += "text-align: center;";
                IsDrivingexperience.ViewCustomAttributes = "";

                // date_Birth_Hijri
                date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // date_Birth
                date_Birth.ViewValue = date_Birth.CurrentValue;
                date_Birth.ViewValue = FormatDateTime(date_Birth.ViewValue, date_Birth.FormatPattern);
                date_Birth.ViewCustomAttributes = "";

                // str_Email
                str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
                str_Email.ViewCustomAttributes = "";

                // UserlevelID
                UserlevelID.ViewValue = UserlevelID.CurrentValue;
                UserlevelID.ViewValue = FormatNumber(UserlevelID.ViewValue, UserlevelID.FormatPattern);
                UserlevelID.ViewCustomAttributes = "";

                // intEvaluationType
                intEvaluationType.ViewValue = intEvaluationType.CurrentValue;
                intEvaluationType.ViewValue = FormatNumber(intEvaluationType.ViewValue, intEvaluationType.FormatPattern);
                intEvaluationType.ViewCustomAttributes = "";

                // Institution
                Institution.ViewValue = ConvertToString(Institution.CurrentValue); // DN
                Institution.ViewCustomAttributes = "";

                // Scores_S1
                Scores_S1.ViewValue = ConvertToString(Scores_S1.CurrentValue); // DN
                Scores_S1.ViewCustomAttributes = "";

                // S1
                if (ConvertToBool(S1.CurrentValue)) {
                    S1.ViewValue = S1.TagCaption(1) != "" ? S1.TagCaption(1) : "Yes";
                } else {
                    S1.ViewValue = S1.TagCaption(2) != "" ? S1.TagCaption(2) : "No";
                }
                S1.ViewCustomAttributes = "";

                // S2
                if (ConvertToBool(S2.CurrentValue)) {
                    S2.ViewValue = S2.TagCaption(1) != "" ? S2.TagCaption(1) : "Yes";
                } else {
                    S2.ViewValue = S2.TagCaption(2) != "" ? S2.TagCaption(2) : "No";
                }
                S2.ViewCustomAttributes = "";

                // S3
                if (ConvertToBool(S3.CurrentValue)) {
                    S3.ViewValue = S3.TagCaption(1) != "" ? S3.TagCaption(1) : "Yes";
                } else {
                    S3.ViewValue = S3.TagCaption(2) != "" ? S3.TagCaption(2) : "No";
                }
                S3.ViewCustomAttributes = "";

                // S4
                if (ConvertToBool(S4.CurrentValue)) {
                    S4.ViewValue = S4.TagCaption(1) != "" ? S4.TagCaption(1) : "Yes";
                } else {
                    S4.ViewValue = S4.TagCaption(2) != "" ? S4.TagCaption(2) : "No";
                }
                S4.ViewCustomAttributes = "";

                // S5
                if (ConvertToBool(S5.CurrentValue)) {
                    S5.ViewValue = S5.TagCaption(1) != "" ? S5.TagCaption(1) : "Yes";
                } else {
                    S5.ViewValue = S5.TagCaption(2) != "" ? S5.TagCaption(2) : "No";
                }
                S5.ViewCustomAttributes = "";

                // Scores_S2
                Scores_S2.ViewValue = ConvertToString(Scores_S2.CurrentValue); // DN
                Scores_S2.ViewCustomAttributes = "";

                // S6
                if (ConvertToBool(S6.CurrentValue)) {
                    S6.ViewValue = S6.TagCaption(1) != "" ? S6.TagCaption(1) : "Yes";
                } else {
                    S6.ViewValue = S6.TagCaption(2) != "" ? S6.TagCaption(2) : "No";
                }
                S6.ViewCustomAttributes = "";

                // S7
                if (ConvertToBool(S7.CurrentValue)) {
                    S7.ViewValue = S7.TagCaption(1) != "" ? S7.TagCaption(1) : "Yes";
                } else {
                    S7.ViewValue = S7.TagCaption(2) != "" ? S7.TagCaption(2) : "No";
                }
                S7.ViewCustomAttributes = "";

                // S8
                if (ConvertToBool(S8.CurrentValue)) {
                    S8.ViewValue = S8.TagCaption(1) != "" ? S8.TagCaption(1) : "Yes";
                } else {
                    S8.ViewValue = S8.TagCaption(2) != "" ? S8.TagCaption(2) : "No";
                }
                S8.ViewCustomAttributes = "";

                // S9
                if (ConvertToBool(S9.CurrentValue)) {
                    S9.ViewValue = S9.TagCaption(1) != "" ? S9.TagCaption(1) : "Yes";
                } else {
                    S9.ViewValue = S9.TagCaption(2) != "" ? S9.TagCaption(2) : "No";
                }
                S9.ViewCustomAttributes = "";

                // S10
                if (ConvertToBool(S10.CurrentValue)) {
                    S10.ViewValue = S10.TagCaption(1) != "" ? S10.TagCaption(1) : "Yes";
                } else {
                    S10.ViewValue = S10.TagCaption(2) != "" ? S10.TagCaption(2) : "No";
                }
                S10.ViewCustomAttributes = "";

                // S11
                if (ConvertToBool(S11.CurrentValue)) {
                    S11.ViewValue = S11.TagCaption(1) != "" ? S11.TagCaption(1) : "Yes";
                } else {
                    S11.ViewValue = S11.TagCaption(2) != "" ? S11.TagCaption(2) : "No";
                }
                S11.ViewCustomAttributes = "";

                // S12
                if (ConvertToBool(S12.CurrentValue)) {
                    S12.ViewValue = S12.TagCaption(1) != "" ? S12.TagCaption(1) : "Yes";
                } else {
                    S12.ViewValue = S12.TagCaption(2) != "" ? S12.TagCaption(2) : "No";
                }
                S12.ViewCustomAttributes = "";

                // S13
                if (ConvertToBool(S13.CurrentValue)) {
                    S13.ViewValue = S13.TagCaption(1) != "" ? S13.TagCaption(1) : "Yes";
                } else {
                    S13.ViewValue = S13.TagCaption(2) != "" ? S13.TagCaption(2) : "No";
                }
                S13.ViewCustomAttributes = "";

                // S14
                if (ConvertToBool(S14.CurrentValue)) {
                    S14.ViewValue = S14.TagCaption(1) != "" ? S14.TagCaption(1) : "Yes";
                } else {
                    S14.ViewValue = S14.TagCaption(2) != "" ? S14.TagCaption(2) : "No";
                }
                S14.ViewCustomAttributes = "";

                // S15
                if (ConvertToBool(S15.CurrentValue)) {
                    S15.ViewValue = S15.TagCaption(1) != "" ? S15.TagCaption(1) : "Yes";
                } else {
                    S15.ViewValue = S15.TagCaption(2) != "" ? S15.TagCaption(2) : "No";
                }
                S15.ViewCustomAttributes = "";

                // Scores_S3
                Scores_S3.ViewValue = ConvertToString(Scores_S3.CurrentValue); // DN
                Scores_S3.ViewCustomAttributes = "";

                // S16
                if (ConvertToBool(S16.CurrentValue)) {
                    S16.ViewValue = S16.TagCaption(1) != "" ? S16.TagCaption(1) : "Yes";
                } else {
                    S16.ViewValue = S16.TagCaption(2) != "" ? S16.TagCaption(2) : "No";
                }
                S16.ViewCustomAttributes = "";

                // S17
                if (ConvertToBool(S17.CurrentValue)) {
                    S17.ViewValue = S17.TagCaption(1) != "" ? S17.TagCaption(1) : "Yes";
                } else {
                    S17.ViewValue = S17.TagCaption(2) != "" ? S17.TagCaption(2) : "No";
                }
                S17.ViewCustomAttributes = "";

                // S18
                if (ConvertToBool(S18.CurrentValue)) {
                    S18.ViewValue = S18.TagCaption(1) != "" ? S18.TagCaption(1) : "Yes";
                } else {
                    S18.ViewValue = S18.TagCaption(2) != "" ? S18.TagCaption(2) : "No";
                }
                S18.ViewCustomAttributes = "";

                // S19
                if (ConvertToBool(S19.CurrentValue)) {
                    S19.ViewValue = S19.TagCaption(1) != "" ? S19.TagCaption(1) : "Yes";
                } else {
                    S19.ViewValue = S19.TagCaption(2) != "" ? S19.TagCaption(2) : "No";
                }
                S19.ViewCustomAttributes = "";

                // S20
                if (ConvertToBool(S20.CurrentValue)) {
                    S20.ViewValue = S20.TagCaption(1) != "" ? S20.TagCaption(1) : "Yes";
                } else {
                    S20.ViewValue = S20.TagCaption(2) != "" ? S20.TagCaption(2) : "No";
                }
                S20.ViewCustomAttributes = "";

                // S21
                if (ConvertToBool(S21.CurrentValue)) {
                    S21.ViewValue = S21.TagCaption(1) != "" ? S21.TagCaption(1) : "Yes";
                } else {
                    S21.ViewValue = S21.TagCaption(2) != "" ? S21.TagCaption(2) : "No";
                }
                S21.ViewCustomAttributes = "";

                // Scores_S4
                Scores_S4.ViewValue = ConvertToString(Scores_S4.CurrentValue); // DN
                Scores_S4.ViewCustomAttributes = "";

                // S22
                if (ConvertToBool(S22.CurrentValue)) {
                    S22.ViewValue = S22.TagCaption(1) != "" ? S22.TagCaption(1) : "Yes";
                } else {
                    S22.ViewValue = S22.TagCaption(2) != "" ? S22.TagCaption(2) : "No";
                }
                S22.ViewCustomAttributes = "";

                // S23
                if (ConvertToBool(S23.CurrentValue)) {
                    S23.ViewValue = S23.TagCaption(1) != "" ? S23.TagCaption(1) : "Yes";
                } else {
                    S23.ViewValue = S23.TagCaption(2) != "" ? S23.TagCaption(2) : "No";
                }
                S23.ViewCustomAttributes = "";

                // S24
                if (ConvertToBool(S24.CurrentValue)) {
                    S24.ViewValue = S24.TagCaption(1) != "" ? S24.TagCaption(1) : "Yes";
                } else {
                    S24.ViewValue = S24.TagCaption(2) != "" ? S24.TagCaption(2) : "No";
                }
                S24.ViewCustomAttributes = "";

                // S25
                if (ConvertToBool(S25.CurrentValue)) {
                    S25.ViewValue = S25.TagCaption(1) != "" ? S25.TagCaption(1) : "Yes";
                } else {
                    S25.ViewValue = S25.TagCaption(2) != "" ? S25.TagCaption(2) : "No";
                }
                S25.ViewCustomAttributes = "";

                // S26
                if (ConvertToBool(S26.CurrentValue)) {
                    S26.ViewValue = S26.TagCaption(1) != "" ? S26.TagCaption(1) : "Yes";
                } else {
                    S26.ViewValue = S26.TagCaption(2) != "" ? S26.TagCaption(2) : "No";
                }
                S26.ViewCustomAttributes = "";

                // Scores_S5
                Scores_S5.ViewValue = ConvertToString(Scores_S5.CurrentValue); // DN
                Scores_S5.ViewCustomAttributes = "";

                // S27
                if (ConvertToBool(S27.CurrentValue)) {
                    S27.ViewValue = S27.TagCaption(1) != "" ? S27.TagCaption(1) : "Yes";
                } else {
                    S27.ViewValue = S27.TagCaption(2) != "" ? S27.TagCaption(2) : "No";
                }
                S27.ViewCustomAttributes = "";

                // S28
                if (ConvertToBool(S28.CurrentValue)) {
                    S28.ViewValue = S28.TagCaption(1) != "" ? S28.TagCaption(1) : "Yes";
                } else {
                    S28.ViewValue = S28.TagCaption(2) != "" ? S28.TagCaption(2) : "No";
                }
                S28.ViewCustomAttributes = "";

                // S29
                if (ConvertToBool(S29.CurrentValue)) {
                    S29.ViewValue = S29.TagCaption(1) != "" ? S29.TagCaption(1) : "Yes";
                } else {
                    S29.ViewValue = S29.TagCaption(2) != "" ? S29.TagCaption(2) : "No";
                }
                S29.ViewCustomAttributes = "";

                // S30
                if (ConvertToBool(S30.CurrentValue)) {
                    S30.ViewValue = S30.TagCaption(1) != "" ? S30.TagCaption(1) : "Yes";
                } else {
                    S30.ViewValue = S30.TagCaption(2) != "" ? S30.TagCaption(2) : "No";
                }
                S30.ViewCustomAttributes = "";

                // S31
                if (ConvertToBool(S31.CurrentValue)) {
                    S31.ViewValue = S31.TagCaption(1) != "" ? S31.TagCaption(1) : "Yes";
                } else {
                    S31.ViewValue = S31.TagCaption(2) != "" ? S31.TagCaption(2) : "No";
                }
                S31.ViewCustomAttributes = "";

                // S32
                if (ConvertToBool(S32.CurrentValue)) {
                    S32.ViewValue = S32.TagCaption(1) != "" ? S32.TagCaption(1) : "Yes";
                } else {
                    S32.ViewValue = S32.TagCaption(2) != "" ? S32.TagCaption(2) : "No";
                }
                S32.ViewCustomAttributes = "";

                // S33
                if (ConvertToBool(S33.CurrentValue)) {
                    S33.ViewValue = S33.TagCaption(1) != "" ? S33.TagCaption(1) : "Yes";
                } else {
                    S33.ViewValue = S33.TagCaption(2) != "" ? S33.TagCaption(2) : "No";
                }
                S33.ViewCustomAttributes = "";

                // S34
                if (ConvertToBool(S34.CurrentValue)) {
                    S34.ViewValue = S34.TagCaption(1) != "" ? S34.TagCaption(1) : "Yes";
                } else {
                    S34.ViewValue = S34.TagCaption(2) != "" ? S34.TagCaption(2) : "No";
                }
                S34.ViewCustomAttributes = "";

                // S35
                if (ConvertToBool(S35.CurrentValue)) {
                    S35.ViewValue = S35.TagCaption(1) != "" ? S35.TagCaption(1) : "Yes";
                } else {
                    S35.ViewValue = S35.TagCaption(2) != "" ? S35.TagCaption(2) : "No";
                }
                S35.ViewCustomAttributes = "";

                // Scores_S6
                Scores_S6.ViewValue = ConvertToString(Scores_S6.CurrentValue); // DN
                Scores_S6.ViewCustomAttributes = "";

                // S36
                if (ConvertToBool(S36.CurrentValue)) {
                    S36.ViewValue = S36.TagCaption(1) != "" ? S36.TagCaption(1) : "Yes";
                } else {
                    S36.ViewValue = S36.TagCaption(2) != "" ? S36.TagCaption(2) : "No";
                }
                S36.ViewCustomAttributes = "";

                // S37
                if (ConvertToBool(S37.CurrentValue)) {
                    S37.ViewValue = S37.TagCaption(1) != "" ? S37.TagCaption(1) : "Yes";
                } else {
                    S37.ViewValue = S37.TagCaption(2) != "" ? S37.TagCaption(2) : "No";
                }
                S37.ViewCustomAttributes = "";

                // S38
                if (ConvertToBool(S38.CurrentValue)) {
                    S38.ViewValue = S38.TagCaption(1) != "" ? S38.TagCaption(1) : "Yes";
                } else {
                    S38.ViewValue = S38.TagCaption(2) != "" ? S38.TagCaption(2) : "No";
                }
                S38.ViewCustomAttributes = "";

                // S39
                if (ConvertToBool(S39.CurrentValue)) {
                    S39.ViewValue = S39.TagCaption(1) != "" ? S39.TagCaption(1) : "Yes";
                } else {
                    S39.ViewValue = S39.TagCaption(2) != "" ? S39.TagCaption(2) : "No";
                }
                S39.ViewCustomAttributes = "";

                // S40
                if (ConvertToBool(S40.CurrentValue)) {
                    S40.ViewValue = S40.TagCaption(1) != "" ? S40.TagCaption(1) : "Yes";
                } else {
                    S40.ViewValue = S40.TagCaption(2) != "" ? S40.TagCaption(2) : "No";
                }
                S40.ViewCustomAttributes = "";

                // S41
                if (ConvertToBool(S41.CurrentValue)) {
                    S41.ViewValue = S41.TagCaption(1) != "" ? S41.TagCaption(1) : "Yes";
                } else {
                    S41.ViewValue = S41.TagCaption(2) != "" ? S41.TagCaption(2) : "No";
                }
                S41.ViewCustomAttributes = "";

                // S42
                if (ConvertToBool(S42.CurrentValue)) {
                    S42.ViewValue = S42.TagCaption(1) != "" ? S42.TagCaption(1) : "Yes";
                } else {
                    S42.ViewValue = S42.TagCaption(2) != "" ? S42.TagCaption(2) : "No";
                }
                S42.ViewCustomAttributes = "";

                // S43
                if (ConvertToBool(S43.CurrentValue)) {
                    S43.ViewValue = S43.TagCaption(1) != "" ? S43.TagCaption(1) : "Yes";
                } else {
                    S43.ViewValue = S43.TagCaption(2) != "" ? S43.TagCaption(2) : "No";
                }
                S43.ViewCustomAttributes = "";

                // Scores_S7
                Scores_S7.ViewValue = ConvertToString(Scores_S7.CurrentValue); // DN
                Scores_S7.ViewCustomAttributes = "";

                // S44
                if (ConvertToBool(S44.CurrentValue)) {
                    S44.ViewValue = S44.TagCaption(1) != "" ? S44.TagCaption(1) : "Yes";
                } else {
                    S44.ViewValue = S44.TagCaption(2) != "" ? S44.TagCaption(2) : "No";
                }
                S44.ViewCustomAttributes = "";

                // S45
                if (ConvertToBool(S45.CurrentValue)) {
                    S45.ViewValue = S45.TagCaption(1) != "" ? S45.TagCaption(1) : "Yes";
                } else {
                    S45.ViewValue = S45.TagCaption(2) != "" ? S45.TagCaption(2) : "No";
                }
                S45.ViewCustomAttributes = "";

                // S46
                if (ConvertToBool(S46.CurrentValue)) {
                    S46.ViewValue = S46.TagCaption(1) != "" ? S46.TagCaption(1) : "Yes";
                } else {
                    S46.ViewValue = S46.TagCaption(2) != "" ? S46.TagCaption(2) : "No";
                }
                S46.ViewCustomAttributes = "";

                // S47
                if (ConvertToBool(S47.CurrentValue)) {
                    S47.ViewValue = S47.TagCaption(1) != "" ? S47.TagCaption(1) : "Yes";
                } else {
                    S47.ViewValue = S47.TagCaption(2) != "" ? S47.TagCaption(2) : "No";
                }
                S47.ViewCustomAttributes = "";

                // S48
                if (ConvertToBool(S48.CurrentValue)) {
                    S48.ViewValue = S48.TagCaption(1) != "" ? S48.TagCaption(1) : "Yes";
                } else {
                    S48.ViewValue = S48.TagCaption(2) != "" ? S48.TagCaption(2) : "No";
                }
                S48.ViewCustomAttributes = "";

                // S49
                if (ConvertToBool(S49.CurrentValue)) {
                    S49.ViewValue = S49.TagCaption(1) != "" ? S49.TagCaption(1) : "Yes";
                } else {
                    S49.ViewValue = S49.TagCaption(2) != "" ? S49.TagCaption(2) : "No";
                }
                S49.ViewCustomAttributes = "";

                // S50
                if (ConvertToBool(S50.CurrentValue)) {
                    S50.ViewValue = S50.TagCaption(1) != "" ? S50.TagCaption(1) : "Yes";
                } else {
                    S50.ViewValue = S50.TagCaption(2) != "" ? S50.TagCaption(2) : "No";
                }
                S50.ViewCustomAttributes = "";

                // Scores_S8
                Scores_S8.ViewValue = ConvertToString(Scores_S8.CurrentValue); // DN
                Scores_S8.ViewCustomAttributes = "";

                // S51
                if (ConvertToBool(S51.CurrentValue)) {
                    S51.ViewValue = S51.TagCaption(1) != "" ? S51.TagCaption(1) : "Yes";
                } else {
                    S51.ViewValue = S51.TagCaption(2) != "" ? S51.TagCaption(2) : "No";
                }
                S51.ViewCustomAttributes = "";

                // S52
                if (ConvertToBool(S52.CurrentValue)) {
                    S52.ViewValue = S52.TagCaption(1) != "" ? S52.TagCaption(1) : "Yes";
                } else {
                    S52.ViewValue = S52.TagCaption(2) != "" ? S52.TagCaption(2) : "No";
                }
                S52.ViewCustomAttributes = "";

                // S53
                if (ConvertToBool(S53.CurrentValue)) {
                    S53.ViewValue = S53.TagCaption(1) != "" ? S53.TagCaption(1) : "Yes";
                } else {
                    S53.ViewValue = S53.TagCaption(2) != "" ? S53.TagCaption(2) : "No";
                }
                S53.ViewCustomAttributes = "";

                // S54
                if (ConvertToBool(S54.CurrentValue)) {
                    S54.ViewValue = S54.TagCaption(1) != "" ? S54.TagCaption(1) : "Yes";
                } else {
                    S54.ViewValue = S54.TagCaption(2) != "" ? S54.TagCaption(2) : "No";
                }
                S54.ViewCustomAttributes = "";

                // S55
                if (ConvertToBool(S55.CurrentValue)) {
                    S55.ViewValue = S55.TagCaption(1) != "" ? S55.TagCaption(1) : "Yes";
                } else {
                    S55.ViewValue = S55.TagCaption(2) != "" ? S55.TagCaption(2) : "No";
                }
                S55.ViewCustomAttributes = "";

                // Scores_S9
                Scores_S9.ViewValue = ConvertToString(Scores_S9.CurrentValue); // DN
                Scores_S9.ViewCustomAttributes = "";

                // S56
                if (ConvertToBool(S56.CurrentValue)) {
                    S56.ViewValue = S56.TagCaption(1) != "" ? S56.TagCaption(1) : "Yes";
                } else {
                    S56.ViewValue = S56.TagCaption(2) != "" ? S56.TagCaption(2) : "No";
                }
                S56.ViewCustomAttributes = "";

                // S57
                if (ConvertToBool(S57.CurrentValue)) {
                    S57.ViewValue = S57.TagCaption(1) != "" ? S57.TagCaption(1) : "Yes";
                } else {
                    S57.ViewValue = S57.TagCaption(2) != "" ? S57.TagCaption(2) : "No";
                }
                S57.ViewCustomAttributes = "";

                // S58
                if (ConvertToBool(S58.CurrentValue)) {
                    S58.ViewValue = S58.TagCaption(1) != "" ? S58.TagCaption(1) : "Yes";
                } else {
                    S58.ViewValue = S58.TagCaption(2) != "" ? S58.TagCaption(2) : "No";
                }
                S58.ViewCustomAttributes = "";

                // S59
                if (ConvertToBool(S59.CurrentValue)) {
                    S59.ViewValue = S59.TagCaption(1) != "" ? S59.TagCaption(1) : "Yes";
                } else {
                    S59.ViewValue = S59.TagCaption(2) != "" ? S59.TagCaption(2) : "No";
                }
                S59.ViewCustomAttributes = "";

                // Scores_S10
                Scores_S10.ViewValue = ConvertToString(Scores_S10.CurrentValue); // DN
                Scores_S10.ViewCustomAttributes = "";

                // S60
                if (ConvertToBool(S60.CurrentValue)) {
                    S60.ViewValue = S60.TagCaption(1) != "" ? S60.TagCaption(1) : "Yes";
                } else {
                    S60.ViewValue = S60.TagCaption(2) != "" ? S60.TagCaption(2) : "No";
                }
                S60.ViewCustomAttributes = "";

                // S61
                if (ConvertToBool(S61.CurrentValue)) {
                    S61.ViewValue = S61.TagCaption(1) != "" ? S61.TagCaption(1) : "Yes";
                } else {
                    S61.ViewValue = S61.TagCaption(2) != "" ? S61.TagCaption(2) : "No";
                }
                S61.ViewCustomAttributes = "";

                // S62
                if (ConvertToBool(S62.CurrentValue)) {
                    S62.ViewValue = S62.TagCaption(1) != "" ? S62.TagCaption(1) : "Yes";
                } else {
                    S62.ViewValue = S62.TagCaption(2) != "" ? S62.TagCaption(2) : "No";
                }
                S62.ViewCustomAttributes = "";

                // S63
                if (ConvertToBool(S63.CurrentValue)) {
                    S63.ViewValue = S63.TagCaption(1) != "" ? S63.TagCaption(1) : "Yes";
                } else {
                    S63.ViewValue = S63.TagCaption(2) != "" ? S63.TagCaption(2) : "No";
                }
                S63.ViewCustomAttributes = "";

                // S64
                if (ConvertToBool(S64.CurrentValue)) {
                    S64.ViewValue = S64.TagCaption(1) != "" ? S64.TagCaption(1) : "Yes";
                } else {
                    S64.ViewValue = S64.TagCaption(2) != "" ? S64.TagCaption(2) : "No";
                }
                S64.ViewCustomAttributes = "";

                // S65
                if (ConvertToBool(S65.CurrentValue)) {
                    S65.ViewValue = S65.TagCaption(1) != "" ? S65.TagCaption(1) : "Yes";
                } else {
                    S65.ViewValue = S65.TagCaption(2) != "" ? S65.TagCaption(2) : "No";
                }
                S65.ViewCustomAttributes = "";

                // Scores_S11
                Scores_S11.ViewValue = ConvertToString(Scores_S11.CurrentValue); // DN
                Scores_S11.ViewCustomAttributes = "";

                // S66
                if (ConvertToBool(S66.CurrentValue)) {
                    S66.ViewValue = S66.TagCaption(1) != "" ? S66.TagCaption(1) : "Yes";
                } else {
                    S66.ViewValue = S66.TagCaption(2) != "" ? S66.TagCaption(2) : "No";
                }
                S66.ViewCustomAttributes = "";

                // S67
                if (ConvertToBool(S67.CurrentValue)) {
                    S67.ViewValue = S67.TagCaption(1) != "" ? S67.TagCaption(1) : "Yes";
                } else {
                    S67.ViewValue = S67.TagCaption(2) != "" ? S67.TagCaption(2) : "No";
                }
                S67.ViewCustomAttributes = "";

                // S68
                if (ConvertToBool(S68.CurrentValue)) {
                    S68.ViewValue = S68.TagCaption(1) != "" ? S68.TagCaption(1) : "Yes";
                } else {
                    S68.ViewValue = S68.TagCaption(2) != "" ? S68.TagCaption(2) : "No";
                }
                S68.ViewCustomAttributes = "";

                // S69
                if (ConvertToBool(S69.CurrentValue)) {
                    S69.ViewValue = S69.TagCaption(1) != "" ? S69.TagCaption(1) : "Yes";
                } else {
                    S69.ViewValue = S69.TagCaption(2) != "" ? S69.TagCaption(2) : "No";
                }
                S69.ViewCustomAttributes = "";

                // S70
                if (ConvertToBool(S70.CurrentValue)) {
                    S70.ViewValue = S70.TagCaption(1) != "" ? S70.TagCaption(1) : "Yes";
                } else {
                    S70.ViewValue = S70.TagCaption(2) != "" ? S70.TagCaption(2) : "No";
                }
                S70.ViewCustomAttributes = "";

                // Evaluation_Score
                Evaluation_Score.ViewValue = Evaluation_Score.CurrentValue;
                Evaluation_Score.ViewValue = FormatNumber(Evaluation_Score.ViewValue, Evaluation_Score.FormatPattern);
                Evaluation_Score.ViewCustomAttributes = "";

                // Immediate_Failure_Score
                Immediate_Failure_Score.ViewValue = Immediate_Failure_Score.CurrentValue;
                Immediate_Failure_Score.ViewValue = FormatNumber(Immediate_Failure_Score.ViewValue, Immediate_Failure_Score.FormatPattern);
                Immediate_Failure_Score.ViewCustomAttributes = "";

                // Required_Program
                Required_Program.ViewValue = ConvertToString(Required_Program.CurrentValue); // DN
                Required_Program.ViewCustomAttributes = "";

                // Price
                Price.ViewValue = Price.CurrentValue;
                Price.ViewValue = FormatNumber(Price.ViewValue, Price.FormatPattern);
                Price.ViewCustomAttributes = "";

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.HrefValue = "";
                str_Full_Name_Hdr.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // intDrivinglicenseType
                if (!IsNull(DriveTypelink.CurrentValue)) {
                    intDrivinglicenseType.HrefValue = ConvertToString(!Empty(DriveTypelink.ViewValue) && !IsList(DriveTypelink.ViewValue) ? RemoveHtml(ConvertToString(DriveTypelink.ViewValue)) : ConvertToString(DriveTypelink.CurrentValue)); // Add prefix/suffix
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
                    intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblEvaluationMB_x" + RowCount + "_intDrivinglicenseType";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                    intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
                }

                // Retake
                Retake.HrefValue = "";
                Retake.TooltipValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";
                AbsherApptNbr.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";
            } else if (RowType == RowType.Add) {
                // str_Full_Name_Hdr
                str_Full_Name_Hdr.SetupEditAttributes();
                if (!str_Full_Name_Hdr.Raw)
                    str_Full_Name_Hdr.CurrentValue = HtmlDecode(str_Full_Name_Hdr.CurrentValue);
                str_Full_Name_Hdr.EditValue = HtmlEncode(str_Full_Name_Hdr.CurrentValue);
                str_Full_Name_Hdr.PlaceHolder = RemoveHtml(str_Full_Name_Hdr.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.CurrentValue; // DN
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                if (!Empty(NationalID.EditValue) && IsNumeric(NationalID.EditValue)) {
                }

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.CurrentValue = HtmlDecode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.CurrentValue; // DN
                intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);
                if (!Empty(intDrivinglicenseType.EditValue) && IsNumeric(intDrivinglicenseType.EditValue)) {
                    intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, null);
                }

                // Retake
                Retake.EditValue = Retake.Options(false);
                Retake.PlaceHolder = RemoveHtml(Retake.Caption);

                // AbsherApptNbr
                AbsherApptNbr.SetupEditAttributes();
                if (!AbsherApptNbr.Raw)
                    AbsherApptNbr.CurrentValue = HtmlDecode(AbsherApptNbr.CurrentValue);
                AbsherApptNbr.EditValue = HtmlEncode(AbsherApptNbr.CurrentValue);
                AbsherApptNbr.PlaceHolder = RemoveHtml(AbsherApptNbr.Caption);

                // IsDrivingexperience
                IsDrivingexperience.EditValue = IsDrivingexperience.Options(false);
                IsDrivingexperience.PlaceHolder = RemoveHtml(IsDrivingexperience.Caption);

                // Add refer script

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.HrefValue = "";

                // NationalID
                NationalID.HrefValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";

                // intDrivinglicenseType
                if (!IsNull(DriveTypelink.CurrentValue)) {
                    intDrivinglicenseType.HrefValue = ConvertToString(!Empty(DriveTypelink.EditValue) && !IsList(DriveTypelink.EditValue) ? RemoveHtml(ConvertToString(DriveTypelink.EditValue)) : ConvertToString(DriveTypelink.CurrentValue)); // Add prefix/suffix
                    intDrivinglicenseType.LinkAttrs["target"] = ""; // Add target
                    if (IsExport())
                        intDrivinglicenseType.HrefValue = FullUrl(ConvertToString(intDrivinglicenseType.HrefValue), "href");
                } else {
                    intDrivinglicenseType.HrefValue = "";
                }

                // Retake
                Retake.HrefValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // str_Full_Name_Hdr
                str_Full_Name_Hdr.SetupEditAttributes();
                str_Full_Name_Hdr.EditValue = ConvertToString(str_Full_Name_Hdr.CurrentValue); // DN
                str_Full_Name_Hdr.ViewCustomAttributes = "";

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.CurrentValue;
                NationalID.ViewCustomAttributes = "";

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                str_Cell_Phone.EditValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
                str_Cell_Phone.ViewCustomAttributes = "";

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.CurrentValue;
                intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, intDrivinglicenseType.FormatPattern);
                intDrivinglicenseType.CellCssStyle += "text-align: center;";
                intDrivinglicenseType.ViewCustomAttributes = "";

                // Retake
                Retake.EditValue = Retake.Options(false);
                Retake.PlaceHolder = RemoveHtml(Retake.Caption);

                // AbsherApptNbr
                AbsherApptNbr.SetupEditAttributes();
                AbsherApptNbr.EditValue = ConvertToString(AbsherApptNbr.CurrentValue); // DN
                AbsherApptNbr.ViewCustomAttributes = "";

                // IsDrivingexperience
                IsDrivingexperience.SetupEditAttributes();
                if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                    IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
                } else {
                    IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
                }
                IsDrivingexperience.CellCssStyle += "text-align: center;";
                IsDrivingexperience.ViewCustomAttributes = "";

                // Edit refer script

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.HrefValue = "";
                str_Full_Name_Hdr.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // intDrivinglicenseType
                if (!IsNull(DriveTypelink.CurrentValue)) {
                    intDrivinglicenseType.HrefValue = ConvertToString(!Empty(DriveTypelink.EditValue) && !IsList(DriveTypelink.EditValue) ? RemoveHtml(ConvertToString(DriveTypelink.EditValue)) : ConvertToString(DriveTypelink.CurrentValue)); // Add prefix/suffix
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
                    intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblEvaluationMB_x" + RowCount + "_intDrivinglicenseType";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                    intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
                }

                // Retake
                Retake.HrefValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";
                AbsherApptNbr.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";
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
            if (str_Cell_Phone.Required) {
                if (!str_Cell_Phone.IsDetailKey && Empty(str_Cell_Phone.FormValue)) {
                    str_Cell_Phone.AddErrorMessage(ConvertToString(str_Cell_Phone.RequiredErrorMessage).Replace("%s", str_Cell_Phone.Caption));
                }
            }
            if (intDrivinglicenseType.Required) {
                if (!intDrivinglicenseType.IsDetailKey && Empty(intDrivinglicenseType.FormValue)) {
                    intDrivinglicenseType.AddErrorMessage(ConvertToString(intDrivinglicenseType.RequiredErrorMessage).Replace("%s", intDrivinglicenseType.Caption));
                }
            }
            if (Retake.Required) {
                if (Empty(Retake.FormValue)) {
                    Retake.AddErrorMessage(ConvertToString(Retake.RequiredErrorMessage).Replace("%s", Retake.Caption));
                }
            }
            if (AbsherApptNbr.Required) {
                if (!AbsherApptNbr.IsDetailKey && Empty(AbsherApptNbr.FormValue)) {
                    AbsherApptNbr.AddErrorMessage(ConvertToString(AbsherApptNbr.RequiredErrorMessage).Replace("%s", AbsherApptNbr.Caption));
                }
            }
            if (IsDrivingexperience.Required) {
                if (Empty(IsDrivingexperience.FormValue)) {
                    IsDrivingexperience.AddErrorMessage(ConvertToString(IsDrivingexperience.RequiredErrorMessage).Replace("%s", IsDrivingexperience.Caption));
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

            // Retake
            Retake.SetDbValue(rsnew, ConvertToBool(Retake.CurrentValue), Retake.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);
            bool validMasterRecord;
            object keyValue;
            object? v;
            string? masterFilter;
            Dictionary<string, object?> detailKeys;

            // Check referential integrity for master table 'tblAssessment'
            detailKeys = new ();
            keyValue = rsnew.TryGetValue("AssessmentID", out v) ? v : rsold["AssessmentID"];
            detailKeys.Add("AssessmentID", keyValue);
            masterFilter = MasterFilter(tblAssessment, detailKeys); // DN
            if (!Empty(masterFilter) && tblAssessment != null) {
                using var rsmaster = await Connection.GetDataReaderAsync(tblAssessment.GetSql(masterFilter)); // DN
                validMasterRecord = rsmaster?.HasRows ?? false;
            } else { // Allow null value if not required field
                validMasterRecord = masterFilter == null;
            }
            if (!validMasterRecord) {
                FailureMessage = Language.Phrase("RelatedRecordRequired").Replace("%t", "tblAssessment");
                return JsonBoolResult.FalseResult;
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

        // Add record
        #pragma warning disable 168, 219

        protected async Task<JsonBoolResult> AddRow(Dictionary<string, object>? rsold = null) { // DN
            bool result = false;

            // Set up foreign key field value from Session
            if (CurrentMasterTable == "tblAssessment") {
                AssessmentID.CurrentValue = AssessmentID.SessionValue;
            }

            // Set new row
            Dictionary<string, object> rsnew = new ();
            try {
                // str_Full_Name_Hdr
                str_Full_Name_Hdr.SetDbValue(rsnew, str_Full_Name_Hdr.CurrentValue);

                // NationalID
                NationalID.SetDbValue(rsnew, NationalID.CurrentValue);

                // str_Cell_Phone
                str_Cell_Phone.SetDbValue(rsnew, str_Cell_Phone.CurrentValue);

                // intDrivinglicenseType
                intDrivinglicenseType.SetDbValue(rsnew, intDrivinglicenseType.CurrentValue);

                // Retake
                Retake.SetDbValue(rsnew, ConvertToBool(Retake.CurrentValue));

                // AbsherApptNbr
                AbsherApptNbr.SetDbValue(rsnew, AbsherApptNbr.CurrentValue);

                // IsDrivingexperience
                IsDrivingexperience.SetDbValue(rsnew, ConvertToBool(IsDrivingexperience.CurrentValue));

                // AssessmentID
                if (!Empty(AssessmentID.SessionValue)) {
                    rsnew["AssessmentID"] = AssessmentID.SessionValue;
                }

                // str_Username
                if (!Security.IsAdmin && Security.IsLoggedIn) { // Non system admin
                    rsnew["str_Username"] = CurrentUserID();
                }
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }

            // Update current values
            SetCurrentValues(rsnew);
            string? masterFilter;
            Dictionary<string, object?> detailKeys;
            bool validMasterRecord;

            // Check referential integrity for master table 'tblAssessment'
            validMasterRecord = true;
            detailKeys = new ();
            detailKeys.Add("AssessmentID", AssessmentID.SessionValue);
            masterFilter = MasterFilter(tblAssessment, detailKeys); // DN
            if (!Empty(masterFilter) && tblAssessment != null) {
                using var rsmaster = await Connection.GetDataReaderAsync(tblAssessment.GetSql(masterFilter)); // DN
                validMasterRecord = rsmaster?.HasRows ?? false;
            } else { // Allow null value if not required field
                validMasterRecord = masterFilter == null;
            }
            if (!validMasterRecord) {
                FailureMessage = Language.Phrase("RelatedRecordRequired").Replace("%t", "tblAssessment");
                return JsonBoolResult.FalseResult;
            }

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
                    rsnew["Eval_ID"] = Eval_ID.CurrentValue!;
                } catch (Exception e) {
                    if (Config.Debug)
                        throw;
                    FailureMessage = e.Message;
                    result = false;
                }
            } else {
                if (SuccessMessage != "" || FailureMessage != "") {
                    // Use the message, do nothing
                } else if (CancelMessage != "") {
                    FailureMessage = CancelMessage;
                    CancelMessage = "";
                } else {
                    FailureMessage = Language.Phrase("InsertCancelled");
                }
                result = false;
            }

            // Call Row Inserted event
            if (result)
                RowInserted(rsold, rsnew);

            // Write JSON for API request
            Dictionary<string, object> d = new ();
            d.Add("success", result);
            if (IsJsonResponse() && result) {
                if (GetRecordFromDictionary(rsnew) is var row && row != null) {
                    string table = TableVar;
                    d.Add(table, row);
                }
                d.Add("action", Config.ApiAddAction);
                d.Add("version", Config.ProductVersion);
                return new JsonBoolResult(d, result);
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
            // Hide foreign keys
            string masterTblVar = CurrentMasterTable;
            if (masterTblVar == "tblAssessment") {
                AssessmentID.Visible = false;

                //if (tblAssessment.EventCancelled) EventCancelled = true;
                if (Get<bool>("mastereventcancelled"))
                    EventCancelled = true;
            }
            DbMasterFilter = MasterFilterFromSession; // Get master filter from session
            DbDetailFilter = DetailFilterFromSession; // Get detail filter from session
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
