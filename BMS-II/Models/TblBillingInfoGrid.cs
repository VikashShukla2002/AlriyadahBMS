namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblBillingInfoGrid
    /// </summary>
    public static TblBillingInfoGrid tblBillingInfoGrid
    {
        get => HttpData.Get<TblBillingInfoGrid>("tblBillingInfoGrid")!;
        set => HttpData["tblBillingInfoGrid"] = value;
    }

    /// <summary>
    /// Page class for tblBillingInfo
    /// </summary>
    public class TblBillingInfoGrid : TblBillingInfoGridBase
    {
        // Constructor
        public TblBillingInfoGrid() : base()
        {
        }

        // Page Load event
        public override void PageLoad() {
        //UPD_Package_Name;
            string sUpdateSq24 = "UPD_Package_Name";
        Execute (sUpdateSq24); 

        //UPD_BILL_RB;
            string sUpdateSq241 = "UPD_BILL_RB";
        Execute (sUpdateSq241); 

        //UPD_BILL_Pricelist;
            string sUpdateSq242 = "UPD_BILL_PriceList";
        Execute (sUpdateSq242);

        //UPD_BILL_Names;
            string sUpdateSq245 = "UPD_BILL_Names";
        Execute (sUpdateSq245);
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
    public class TblBillingInfoGridBase : TblBillingInfo
    {
        // Page ID
        public string PageID = "grid";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblBillingInfo";

        // Page object name
        public string PageObjName = "tblBillingInfoGrid";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblBillingInfogrid";

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
        public TblBillingInfoGridBase()
        {
            // CSS class name as context
            TableVar = "tblBillingInfo";
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
            AddUrl = "TblBillingInfoAdd";

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
        public string PageName => "TblBillingInfoGrid";

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
            int_Bill_ID.Visible = false;
            NationalID.SetVisibility();
            str_First_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Username.Visible = false;
            int_Student_ID.Visible = false;
            int_Payment_Method.Visible = false;
            date_Paid.SetVisibility();
            str_ApprovalCode.SetVisibility();
            Payment_Number.SetVisibility();
            Pricelist.SetVisibility();
            date_Created.Visible = false;
            str_Amount.Visible = false;
            str_CC_Holder_Name.Visible = false;
            str_CC_Number.Visible = false;
            int_CC_ExpMonth.Visible = false;
            int_CC_ExpYear.Visible = false;
            int_CC_Type.Visible = false;
            str_Card_Id.Visible = false;
            str_CC_ValidationNum.Visible = false;
            str_reference.Visible = false;
            str_Amount_Pay.SetVisibility();
            mny_Running_Payments.SetVisibility();
            mny_Running_Balance.SetVisibility();
            str_Payment_Reference.Visible = false;
            int_Accepted_By.Visible = false;
            str_Check_Number.Visible = false;
            bit_Is_Check_Deposited.Visible = false;
            str_Adjustment_Type.Visible = false;
            str_Adjust_Sub_Type.Visible = false;
            bit_Archive.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            date_Modified.Visible = false;
            bit_IsDeleted.Visible = false;
            str_CardHolder_Address.Visible = false;
            str_CH_City.Visible = false;
            str_CH_Zip.Visible = false;
            int_State.Visible = false;
            bit_IsAuthDotNet.Visible = false;
            bit_IsRefund.Visible = false;
            str_Receipt.Visible = false;
            str_TransactionNumber.Visible = false;
            str_OrderId.Visible = false;
            str_TransactionTime.Visible = false;
            int_Location_Id.Visible = false;
            str_Enrollment_Id.Visible = false;
            str_Notes.Visible = false;
            str_Payment_Note.Visible = false;
            int_Package_ID.Visible = false;
            Package_Name.Visible = false;
            Price.Visible = false;
            AssessmentID.Visible = false;
            course.Visible = false;
            institution.Visible = false;
            UniqueIdx.Visible = false;
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Bill_ID") ? dict["int_Bill_ID"] : int_Bill_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Bill_ID.Visible = false;
            if (IsAddOrEdit)
                date_Created.Visible = false;
            if (IsAddOrEdit)
                int_Accepted_By.Visible = false;
            if (IsAddOrEdit)
                int_Modified_By.Visible = false;
            if (IsAddOrEdit)
                date_Modified.Visible = false;
            if (IsAddOrEdit)
                str_TransactionTime.Visible = false;
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

            // Load default values for add
            LoadDefaultValues();

            // Update form name to avoid conflict
            if (IsModal)
                FormName = "ftblBillingInfogrid";

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
                if (CurrentMasterTable == "tblPotentialStudentInfo")
                    DbMasterFilter = AddMasterUserIDFilter(DbMasterFilter, "tblPotentialStudentInfo"); // Add master User ID filter
            }
            AddFilter(ref filter, DbDetailFilter);
            AddFilter(ref filter, SearchWhere);

            // Load master record
            if (CurrentMode != "add" && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblPotentialStudentInfo") {
                tblPotentialStudentInfo = Resolve("tblPotentialStudentInfo")!;
                if (tblPotentialStudentInfo != null) {
                    using (var rsmaster = await tblPotentialStudentInfo.LoadReader(DbMasterFilter)) { // Note: Use {}
                        MasterRecordExists = rsmaster != null && await rsmaster.ReadAsync();
                        if (!MasterRecordExists) {
                            FailureMessage = Language.Phrase("NoRecord"); // Set no record found
                            return Terminate("TblPotentialStudentInfoList"); // Return to master page
                        } else {
                            tblPotentialStudentInfo.LoadListRowValues(rsmaster);
                        }
                    }
                    tblPotentialStudentInfo.RowType = RowType.Master; // Master row
                    await tblPotentialStudentInfo.RenderListRow(); // Note: Do it outside "using" // DN
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
                tblBillingInfoGrid?.PageRender();
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
            Pricelist.SetFormValue("", false); // Clear form value
            mny_Running_Payments.SetFormValue("", false); // Clear form value
            mny_Running_Balance.SetFormValue("", false); // Clear form value
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

                // Send notify email
                string table = "tblBillingInfo";
                string subject = table + " " + Language.Phrase("RecordUpdated");
                string action = Language.Phrase("ActionUpdatedGridEdit");
                var email = new Email();
                await email.Load(Config.EmailNotifyTemplate);
                email.ReplaceSender(Config.SenderEmail); // Replace Sender
                email.ReplaceRecipient(Config.RecipientEmail); // Replace Recipient
                email.ReplaceSubject(subject); // Replace Subject
                email.ReplaceContent("<!--table-->", table);
                email.ReplaceContent("<!--key-->", key);
                email.ReplaceContent("<!--action-->", action);
                bool emailSent = false;
                if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsold = rsold, rsnew = rsnew })))
                    emailSent = await email.SendAsync();

                // Set up error message
                if (!emailSent)
                    FailureMessage = email.SendError;
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
                            key += ConvertToString(int_Bill_ID.CurrentValue);

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

                // Send notify email
                string table = "tblBillingInfo";
                string subject = table + " " + Language.Phrase("RecordInserted");
                string action = Language.Phrase("ActionInsertedGridAdd");
                var email = new Email();
                await email.Load(Config.EmailNotifyTemplate);
                email.ReplaceSender(Config.SenderEmail); // Replace Sender
                email.ReplaceRecipient(Config.RecipientEmail); // Replace Recipient
                email.ReplaceSubject(subject); // Replace Subject
                email.ReplaceContent("<!--table-->", table);
                email.ReplaceContent("<!--key-->", key);
                email.ReplaceContent("<!--action-->", action);
                bool emailSent = false;
                if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsnew = rsnew })))
                    emailSent = await email.SendAsync();
                if (!emailSent)
                    FailureMessage = email.SendError;
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
            if (CurrentForm.HasValue("x_NationalID") && CurrentForm.HasValue("o_NationalID") && !SameString(NationalID.CurrentValue, NationalID.DefaultValue) &&
            !(NationalID.IsForeignKey && CurrentMasterTable != "" && SameString(NationalID.CurrentValue, NationalID.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_First_Name") && CurrentForm.HasValue("o_str_First_Name") && !SameString(str_First_Name.CurrentValue, str_First_Name.DefaultValue) &&
            !(str_First_Name.IsForeignKey && CurrentMasterTable != "" && SameString(str_First_Name.CurrentValue, str_First_Name.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Last_Name") && CurrentForm.HasValue("o_str_Last_Name") && !SameString(str_Last_Name.CurrentValue, str_Last_Name.DefaultValue) &&
            !(str_Last_Name.IsForeignKey && CurrentMasterTable != "" && SameString(str_Last_Name.CurrentValue, str_Last_Name.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_date_Paid") && CurrentForm.HasValue("o_date_Paid") && !SameString(FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), FormatDateTime(date_Paid.DefaultValue, date_Paid.FormatPattern)) &&
            !(date_Paid.IsForeignKey && CurrentMasterTable != "" && SameString(FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), FormatDateTime(date_Paid.SessionValue, date_Paid.FormatPattern))))
                return false;
            if (CurrentForm.HasValue("x_str_ApprovalCode") && CurrentForm.HasValue("o_str_ApprovalCode") && !SameString(str_ApprovalCode.CurrentValue, str_ApprovalCode.DefaultValue) &&
            !(str_ApprovalCode.IsForeignKey && CurrentMasterTable != "" && SameString(str_ApprovalCode.CurrentValue, str_ApprovalCode.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_Payment_Number") && CurrentForm.HasValue("o_Payment_Number") && !SameString(Payment_Number.CurrentValue, Payment_Number.DefaultValue) &&
            !(Payment_Number.IsForeignKey && CurrentMasterTable != "" && SameString(Payment_Number.CurrentValue, Payment_Number.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_Pricelist") && CurrentForm.HasValue("o_Pricelist") && !SameString(Pricelist.CurrentValue, Pricelist.DefaultValue) &&
            !(Pricelist.IsForeignKey && CurrentMasterTable != "" && SameString(Pricelist.CurrentValue, Pricelist.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_str_Amount_Pay") && CurrentForm.HasValue("o_str_Amount_Pay") && !SameString(str_Amount_Pay.CurrentValue, str_Amount_Pay.DefaultValue) &&
            !(str_Amount_Pay.IsForeignKey && CurrentMasterTable != "" && SameString(str_Amount_Pay.CurrentValue, str_Amount_Pay.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_mny_Running_Payments") && CurrentForm.HasValue("o_mny_Running_Payments") && !SameString(mny_Running_Payments.CurrentValue, mny_Running_Payments.DefaultValue) &&
            !(mny_Running_Payments.IsForeignKey && CurrentMasterTable != "" && SameString(mny_Running_Payments.CurrentValue, mny_Running_Payments.SessionValue)))
                return false;
            if (CurrentForm.HasValue("x_mny_Running_Balance") && CurrentForm.HasValue("o_mny_Running_Balance") && !SameString(mny_Running_Balance.CurrentValue, mny_Running_Balance.DefaultValue) &&
            !(mny_Running_Balance.IsForeignKey && CurrentMasterTable != "" && SameString(mny_Running_Balance.CurrentValue, mny_Running_Balance.SessionValue)))
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
            NationalID.ClearErrorMessage();
            str_First_Name.ClearErrorMessage();
            str_Last_Name.ClearErrorMessage();
            date_Paid.ClearErrorMessage();
            str_ApprovalCode.ClearErrorMessage();
            Payment_Number.ClearErrorMessage();
            Pricelist.ClearErrorMessage();
            str_Amount_Pay.ClearErrorMessage();
            mny_Running_Payments.ClearErrorMessage();
            mny_Running_Balance.ClearErrorMessage();
        }

        // Set up sort parameters
        protected void SetupSortOrder() {
            // Load default Sorting Order
            if (Command != "json") {
                string defaultSort = NationalID.Expression + " ASC" + ", " + date_Paid.Expression + " ASC"; // Set up default sort
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
                    NationalID.SessionValue = "";
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
                    listOption?.SetBody($@"<a class=""ew-row-link ew-view"" title=""{viewcaption}"" data-table=""tblBillingInfo"" data-caption=""{viewcaption}"" data-ew-action=""modal"" data-action=""view"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(ViewUrl)) + "\" data-btn=\"null\">" + Language.Phrase("ViewLink") + "</a>");
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
                    listOption?.SetBody($@"<a class=""ew-row-link ew-edit"" title=""{editcaption}"" data-table=""tblBillingInfo"" data-caption=""{editcaption}"" data-ew-action=""modal"" data-action=""edit"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(EditUrl)) + "\" data-btn=\"SaveBtn\">" + Language.Phrase("EditLink") + "</a>");
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
            // Preview extension
            string links = "", btngrps = "", sqlwrk, detaillnk, link, url, btngrp, caption, title, icon, detailFilter;
            List<string> masterKeys = new ();
            ListOption? option;
            dynamic? detailTbl = null, detailPage = null;
            masterKeys.Clear();
            sqlwrk = KeyFilter(Resolve("tblStudentEnrollment")!.NationalID, NationalID.CurrentValue, NationalID.DataType, DbId);
            masterKeys.Add(ConvertToString(NationalID.CurrentValue));

            // Column "detail_tblStudentEnrollment"
            if ((DetailPages?["tblStudentEnrollment"]?.Visible ?? false) && Security.AllowList(CurrentProjectID + "tblStudentEnrollment")) {
                link = "";
                option = ListOptions["detail_tblStudentEnrollment"];
                url = "TblStudentEnrollmentPreview?t=tblBillingInfo&f=" + Encrypt(sqlwrk + "|" + String.Join("|", masterKeys));
                btngrp = "<div data-table=\"tblStudentEnrollment\" data-url=\"" + AppPath(url) + "\" class=\"ew-detail-btn-group d-none\">";
                if (Security.AllowList(CurrentProjectID + "tblBillingInfo")) {
                    string label = Language.TablePhrase("tblStudentEnrollment", "TblCaption");
                    link = "<button class=\"nav-link\" data-bs-toggle=\"tab\" data-table=\"tblStudentEnrollment\" data-url=\"" + AppPath(url) + "\" type=\"button\" role=\"tab\" aria-selected=\"false\">" + label + "</button>";
                    detaillnk = AppPath("TblStudentEnrollmentList?" + Config.TableShowMaster + "=tblBillingInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "");
                    title = Language.TablePhrase("tblStudentEnrollment", "TblCaption");
                    caption = Language.Phrase("MasterDetailListLink");
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(detaillnk) + "\">" + caption + "</a>";
                }
                detailPage = Resolve("TblStudentEnrollmentGrid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink");
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = AppPath(GetViewUrl(Config.TableShowDetail + "=tblStudentEnrollment"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink");
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = AppPath(GetEditUrl(Config.TableShowDetail + "=tblStudentEnrollment"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                btngrp += "</div>";
                if (link != "") {
                    link = "<li class=\"nav-item\">" + btngrp + link + "</li>";  // Note: Place btngrp before link
                    links += link;
                    option?.AddBody("<div class=\"ew-preview d-none\">" + link + "</div>");
                }
            }
            masterKeys.Clear();
            sqlwrk = KeyFilter(Resolve("qryBillingDetails_v2")!.NationalID, NationalID.CurrentValue, NationalID.DataType, DbId);
            masterKeys.Add(ConvertToString(NationalID.CurrentValue));

            // Column "detail_qryBillingDetails_v2"
            if ((DetailPages?["qryBillingDetails_v2"]?.Visible ?? false) && Security.AllowList(CurrentProjectID + "qryBillingDetails_v2")) {
                link = "";
                option = ListOptions["detail_qryBillingDetails_v2"];
                url = "QryBillingDetailsV2Preview?t=tblBillingInfo&f=" + Encrypt(sqlwrk + "|" + String.Join("|", masterKeys));
                btngrp = "<div data-table=\"qryBillingDetails_v2\" data-url=\"" + AppPath(url) + "\" class=\"ew-detail-btn-group d-none\">";
                if (Security.AllowList(CurrentProjectID + "tblBillingInfo")) {
                    string label = Language.TablePhrase("qryBillingDetails_v2", "TblCaption");
                    link = "<button class=\"nav-link\" data-bs-toggle=\"tab\" data-table=\"qryBillingDetails_v2\" data-url=\"" + AppPath(url) + "\" type=\"button\" role=\"tab\" aria-selected=\"false\">" + label + "</button>";
                    detaillnk = AppPath("QryBillingDetailsV2List?" + Config.TableShowMaster + "=tblBillingInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.CurrentValue) + "");
                    title = Language.TablePhrase("qryBillingDetails_v2", "TblCaption");
                    caption = Language.Phrase("MasterDetailListLink");
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(detaillnk) + "\">" + caption + "</a>";
                }
                detailPage = Resolve("QryBillingDetailsV2Grid")!;
                if (detailPage?.DetailView && Security.CanView && ShowOptionLink("view") && Security.AllowView(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailViewLink");
                    title = Language.Phrase("MasterDetailViewLink", true);
                    url = AppPath(GetViewUrl(Config.TableShowDetail + "=qryBillingDetails_v2"));
                    btngrp += "<a href=\"#\" class=\"me-2\" title=\"" + title + "\" data-ew-action=\"redirect\" data-url=\"" + HtmlEncode(url) + "\">" + caption + "</a>";
                }
                if (detailPage?.DetailEdit && Security.CanEdit && ShowOptionLink("edit") && Security.AllowEdit(CurrentProjectID + "tblBillingInfo") ?? false) {
                    caption = Language.Phrase("MasterDetailEditLink");
                    title = Language.Phrase("MasterDetailEditLink", true);
                    url = AppPath(GetEditUrl(Config.TableShowDetail + "=qryBillingDetails_v2"));
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
                option.OnLeft = true;
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
            option = OtherOptions["addedit"];
            option.UseDropDownButton = false;
            option.DropDownButtonPhrase = "ButtonAddEdit";
            option.UseButtonGroup = true;
            option.ButtonClass = ""; // Class for button group
            item = option.AddGroupOption();
            item.Body = "";
            item.Visible = false;

            // Add
            if (CurrentMode == "view") { // Check view mode
                item = option.Add("add");
                string addTitle = Language.Phrase("AddLink", true);
                AddUrl = GetAddUrl();
                if (ModalAdd && !IsMobile())
                    item.Body = $@"<a class=""ew-add-edit ew-add"" title=""{addTitle}"" data-table=""tblBillingInfo"" data-caption=""{addTitle}"" data-ew-action=""modal"" data-action=""add"" data-ajax=""" + (UseAjaxActions ? "true" : "false") + "\" data-url=\"" + HtmlEncode(AppPath(AddUrl)) + "\" data-btn=\"AddBtn\">" + Language.Phrase("AddLink") + "</a>";
                else
                    item.Body = $@"<a class=""ew-add-edit ew-add"" title=\""{addTitle}"" data-caption=""{addTitle}"" href=""" + HtmlEncode(AppPath(AddUrl)) + "\">" + Language.Phrase("AddLink") + "</a>";
                item.Visible = (AddUrl != "" && Security.CanAdd);
            }
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
                        item.Visible = Security.CanAdd;
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
                    RowAttrs.Add("id", "r0_tblBillingInfo");
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
            RowAttrs.Add("data-rowindex", ConvertToString(tblBillingInfoGrid.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblBillingInfoGrid.RowCount) + "_tblBillingInfo");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblBillingInfoGrid.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblBillingInfoGrid.RowType == RowType.Add || IsEdit && tblBillingInfoGrid.RowType == RowType.Edit) // Inline-Add/Edit row
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
            bit_IsDeleted.DefaultValue = bit_IsDeleted.GetDefault(); // DN
            bit_IsDeleted.OldValue = bit_IsDeleted.DefaultValue;
            bit_IsAuthDotNet.DefaultValue = bit_IsAuthDotNet.GetDefault(); // DN
            bit_IsAuthDotNet.OldValue = bit_IsAuthDotNet.DefaultValue;
            bit_IsRefund.DefaultValue = bit_IsRefund.GetDefault(); // DN
            bit_IsRefund.OldValue = bit_IsRefund.DefaultValue;
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            CurrentForm.FormName = FormName;
            bool validate = !Config.ServerValidate;
            string val;

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

            // Check field name 'str_First_Name' before field var 'x_str_First_Name'
            val = CurrentForm.HasValue("str_First_Name") ? CurrentForm.GetValue("str_First_Name") : CurrentForm.GetValue("x_str_First_Name");
            if (!str_First_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_First_Name") && !CurrentForm.HasValue("x_str_First_Name")) // DN
                    str_First_Name.Visible = false; // Disable update for API request
                else
                    str_First_Name.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_First_Name"))
                str_First_Name.OldValue = CurrentForm.GetValue("o_str_First_Name");

            // Check field name 'str_Last_Name' before field var 'x_str_Last_Name'
            val = CurrentForm.HasValue("str_Last_Name") ? CurrentForm.GetValue("str_Last_Name") : CurrentForm.GetValue("x_str_Last_Name");
            if (!str_Last_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Last_Name") && !CurrentForm.HasValue("x_str_Last_Name")) // DN
                    str_Last_Name.Visible = false; // Disable update for API request
                else
                    str_Last_Name.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_Last_Name"))
                str_Last_Name.OldValue = CurrentForm.GetValue("o_str_Last_Name");

            // Check field name 'date_Paid' before field var 'x_date_Paid'
            val = CurrentForm.HasValue("date_Paid") ? CurrentForm.GetValue("date_Paid") : CurrentForm.GetValue("x_date_Paid");
            if (!date_Paid.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Paid") && !CurrentForm.HasValue("x_date_Paid")) // DN
                    date_Paid.Visible = false; // Disable update for API request
                else
                    date_Paid.SetFormValue(val, true, validate);
                date_Paid.CurrentValue = UnformatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern);
            }
            date_Paid.OldValue = UnformatDateTime(CurrentForm.GetValue("o_date_Paid"), date_Paid.FormatPattern);

            // Check field name 'str_ApprovalCode' before field var 'x_str_ApprovalCode'
            val = CurrentForm.HasValue("str_ApprovalCode") ? CurrentForm.GetValue("str_ApprovalCode") : CurrentForm.GetValue("x_str_ApprovalCode");
            if (!str_ApprovalCode.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ApprovalCode") && !CurrentForm.HasValue("x_str_ApprovalCode")) // DN
                    str_ApprovalCode.Visible = false; // Disable update for API request
                else
                    str_ApprovalCode.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_ApprovalCode"))
                str_ApprovalCode.OldValue = CurrentForm.GetValue("o_str_ApprovalCode");

            // Check field name 'Payment_Number' before field var 'x_Payment_Number'
            val = CurrentForm.HasValue("Payment_Number") ? CurrentForm.GetValue("Payment_Number") : CurrentForm.GetValue("x_Payment_Number");
            if (!Payment_Number.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Payment_Number") && !CurrentForm.HasValue("x_Payment_Number")) // DN
                    Payment_Number.Visible = false; // Disable update for API request
                else
                    Payment_Number.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_Payment_Number"))
                Payment_Number.OldValue = CurrentForm.GetValue("o_Payment_Number");

            // Check field name 'Pricelist' before field var 'x_Pricelist'
            val = CurrentForm.HasValue("Pricelist") ? CurrentForm.GetValue("Pricelist") : CurrentForm.GetValue("x_Pricelist");
            if (!Pricelist.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Pricelist") && !CurrentForm.HasValue("x_Pricelist")) // DN
                    Pricelist.Visible = false; // Disable update for API request
                else
                    Pricelist.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_Pricelist"))
                Pricelist.OldValue = CurrentForm.GetValue("o_Pricelist");

            // Check field name 'str_Amount_Pay' before field var 'x_str_Amount_Pay'
            val = CurrentForm.HasValue("str_Amount_Pay") ? CurrentForm.GetValue("str_Amount_Pay") : CurrentForm.GetValue("x_str_Amount_Pay");
            if (!str_Amount_Pay.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Amount_Pay") && !CurrentForm.HasValue("x_str_Amount_Pay")) // DN
                    str_Amount_Pay.Visible = false; // Disable update for API request
                else
                    str_Amount_Pay.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_str_Amount_Pay"))
                str_Amount_Pay.OldValue = CurrentForm.GetValue("o_str_Amount_Pay");

            // Check field name 'mny_Running_Payments' before field var 'x_mny_Running_Payments'
            val = CurrentForm.HasValue("mny_Running_Payments") ? CurrentForm.GetValue("mny_Running_Payments") : CurrentForm.GetValue("x_mny_Running_Payments");
            if (!mny_Running_Payments.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_Running_Payments") && !CurrentForm.HasValue("x_mny_Running_Payments")) // DN
                    mny_Running_Payments.Visible = false; // Disable update for API request
                else
                    mny_Running_Payments.SetFormValue(val, true, validate);
            }
            if (CurrentForm.HasValue("o_mny_Running_Payments"))
                mny_Running_Payments.OldValue = CurrentForm.GetValue("o_mny_Running_Payments");

            // Check field name 'mny_Running_Balance' before field var 'x_mny_Running_Balance'
            val = CurrentForm.HasValue("mny_Running_Balance") ? CurrentForm.GetValue("mny_Running_Balance") : CurrentForm.GetValue("x_mny_Running_Balance");
            if (!mny_Running_Balance.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("mny_Running_Balance") && !CurrentForm.HasValue("x_mny_Running_Balance")) // DN
                    mny_Running_Balance.Visible = false; // Disable update for API request
                else
                    mny_Running_Balance.SetFormValue(val);
            }
            if (CurrentForm.HasValue("o_mny_Running_Balance"))
                mny_Running_Balance.OldValue = CurrentForm.GetValue("o_mny_Running_Balance");

            // Check field name 'int_Bill_ID' before field var 'x_int_Bill_ID'
            val = CurrentForm.HasValue("int_Bill_ID") ? CurrentForm.GetValue("int_Bill_ID") : CurrentForm.GetValue("x_int_Bill_ID");
            if (!int_Bill_ID.IsDetailKey && !IsGridAdd && !IsAdd)
                int_Bill_ID.SetFormValue(val);
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            if (!IsGridAdd && !IsAdd)
                int_Bill_ID.CurrentValue = int_Bill_ID.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            date_Paid.CurrentValue = date_Paid.FormValue;
            date_Paid.CurrentValue = UnformatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern);
            str_ApprovalCode.CurrentValue = str_ApprovalCode.FormValue;
            Payment_Number.CurrentValue = Payment_Number.FormValue;
            Pricelist.CurrentValue = Pricelist.FormValue;
            str_Amount_Pay.CurrentValue = str_Amount_Pay.FormValue;
            mny_Running_Payments.CurrentValue = mny_Running_Payments.FormValue;
            mny_Running_Balance.CurrentValue = mny_Running_Balance.FormValue;
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

            // int_Bill_ID

            // NationalID

            // str_First_Name

            // str_Last_Name

            // str_Username

            // int_Student_ID

            // int_Payment_Method

            // date_Paid
            date_Paid.CellCssStyle = "white-space: nowrap;";

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

                // date_Paid
                date_Paid.HrefValue = "";
                date_Paid.TooltipValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";
                str_ApprovalCode.TooltipValue = "";

                // Payment_Number
                Payment_Number.HrefValue = "";
                Payment_Number.TooltipValue = "";

                // Pricelist
                Pricelist.HrefValue = "";
                Pricelist.TooltipValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";
                str_Amount_Pay.TooltipValue = "";

                // mny_Running_Payments
                mny_Running_Payments.HrefValue = "";
                mny_Running_Payments.TooltipValue = "";

                // mny_Running_Balance
                mny_Running_Balance.HrefValue = "";
                mny_Running_Balance.TooltipValue = "";
            } else if (RowType == RowType.Add) {
                // NationalID
                NationalID.SetupEditAttributes();
                if (!Empty(NationalID.SessionValue)) {
                    NationalID.CurrentValue = ForeignKeyValue(NationalID.SessionValue);
                    NationalID.OldValue = NationalID.CurrentValue;
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
                } else {
                    curVal = ConvertToString(NationalID.CurrentValue)?.Trim() ?? "";
                    if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        NationalID.EditValue = NationalID.Lookup?.Options.Values.ToList();
                    } else { // Lookup from database
                        if (curVal == "") {
                            filterWrk = "0=1";
                        } else {
                            filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                        }
                        sqlWrk = NationalID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        NationalID.EditValue = rswrk;
                    }
                    NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);
                }

                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.CurrentValue = HtmlDecode(str_First_Name.CurrentValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.CurrentValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.CurrentValue = HtmlDecode(str_Last_Name.CurrentValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.CurrentValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // date_Paid
                date_Paid.SetupEditAttributes();
                date_Paid.EditValue = FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern); // DN
                date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

                // str_ApprovalCode
                str_ApprovalCode.SetupEditAttributes();
                if (!str_ApprovalCode.Raw)
                    str_ApprovalCode.CurrentValue = HtmlDecode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

                // Payment_Number
                Payment_Number.SetupEditAttributes();
                Payment_Number.EditValue = Payment_Number.CurrentValue; // DN
                Payment_Number.PlaceHolder = RemoveHtml(Payment_Number.Caption);
                if (!Empty(Payment_Number.EditValue) && IsNumeric(Payment_Number.EditValue)) {
                    Payment_Number.EditValue = FormatNumber(Payment_Number.EditValue, null);
                }

                // Pricelist
                Pricelist.SetupEditAttributes();
                Pricelist.EditValue = Pricelist.CurrentValue; // DN
                Pricelist.PlaceHolder = RemoveHtml(Pricelist.Caption);
                if (!Empty(Pricelist.EditValue) && IsNumeric(Pricelist.EditValue)) {
                    Pricelist.EditValue = FormatNumber(Pricelist.EditValue, null);
                }

                // str_Amount_Pay
                str_Amount_Pay.SetupEditAttributes();
                if (!str_Amount_Pay.Raw)
                    str_Amount_Pay.CurrentValue = HtmlDecode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

                // mny_Running_Payments
                mny_Running_Payments.SetupEditAttributes();
                mny_Running_Payments.EditValue = mny_Running_Payments.CurrentValue; // DN
                mny_Running_Payments.PlaceHolder = RemoveHtml(mny_Running_Payments.Caption);
                if (!Empty(mny_Running_Payments.EditValue) && IsNumeric(mny_Running_Payments.EditValue)) {
                    mny_Running_Payments.EditValue = FormatNumber(mny_Running_Payments.EditValue, null);
                }

                // mny_Running_Balance
                mny_Running_Balance.SetupEditAttributes();
                mny_Running_Balance.EditValue = mny_Running_Balance.CurrentValue; // DN
                mny_Running_Balance.PlaceHolder = RemoveHtml(mny_Running_Balance.Caption);
                if (!Empty(mny_Running_Balance.EditValue) && IsNumeric(mny_Running_Balance.EditValue)) {
                    mny_Running_Balance.EditValue = FormatNumber(mny_Running_Balance.EditValue, null);
                }

                // Add refer script

                // NationalID
                NationalID.HrefValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

                // Payment_Number
                Payment_Number.HrefValue = "";

                // Pricelist
                Pricelist.HrefValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";

                // mny_Running_Payments
                mny_Running_Payments.HrefValue = "";

                // mny_Running_Balance
                mny_Running_Balance.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // NationalID
                NationalID.SetupEditAttributes();
                curVal = ConvertToString(NationalID.CurrentValue);
                if (!Empty(curVal)) {
                    if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        NationalID.EditValue = NationalID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[NationalID]", "=", NationalID.CurrentValue, DataType.Number, "");
                        sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && NationalID.Lookup != null) { // Lookup values found
                            var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                            NationalID.EditValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                        } else {
                            NationalID.EditValue = NationalID.CurrentValue;
                        }
                    }
                } else {
                    NationalID.EditValue = DbNullValue;
                }
                NationalID.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.SetupEditAttributes();
                str_First_Name.EditValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                str_Last_Name.EditValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // date_Paid
                date_Paid.SetupEditAttributes();
                date_Paid.EditValue = FormatDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern); // DN
                date_Paid.PlaceHolder = RemoveHtml(date_Paid.Caption);

                // str_ApprovalCode
                str_ApprovalCode.SetupEditAttributes();
                if (!str_ApprovalCode.Raw)
                    str_ApprovalCode.CurrentValue = HtmlDecode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.EditValue = HtmlEncode(str_ApprovalCode.CurrentValue);
                str_ApprovalCode.PlaceHolder = RemoveHtml(str_ApprovalCode.Caption);

                // Payment_Number
                Payment_Number.SetupEditAttributes();
                Payment_Number.EditValue = Payment_Number.CurrentValue; // DN
                Payment_Number.PlaceHolder = RemoveHtml(Payment_Number.Caption);
                if (!Empty(Payment_Number.EditValue) && IsNumeric(Payment_Number.EditValue)) {
                    Payment_Number.EditValue = FormatNumber(Payment_Number.EditValue, null);
                }

                // Pricelist
                Pricelist.SetupEditAttributes();
                Pricelist.EditValue = Pricelist.CurrentValue; // DN
                Pricelist.PlaceHolder = RemoveHtml(Pricelist.Caption);
                if (!Empty(Pricelist.EditValue) && IsNumeric(Pricelist.EditValue)) {
                    Pricelist.EditValue = FormatNumber(Pricelist.EditValue, null);
                }

                // str_Amount_Pay
                str_Amount_Pay.SetupEditAttributes();
                if (!str_Amount_Pay.Raw)
                    str_Amount_Pay.CurrentValue = HtmlDecode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.CurrentValue);
                str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

                // mny_Running_Payments
                mny_Running_Payments.SetupEditAttributes();
                mny_Running_Payments.EditValue = mny_Running_Payments.CurrentValue; // DN
                mny_Running_Payments.PlaceHolder = RemoveHtml(mny_Running_Payments.Caption);
                if (!Empty(mny_Running_Payments.EditValue) && IsNumeric(mny_Running_Payments.EditValue)) {
                    mny_Running_Payments.EditValue = FormatNumber(mny_Running_Payments.EditValue, null);
                }

                // mny_Running_Balance
                mny_Running_Balance.SetupEditAttributes();
                mny_Running_Balance.EditValue = mny_Running_Balance.CurrentValue;
                mny_Running_Balance.EditValue = FormatNumber(mny_Running_Balance.EditValue, mny_Running_Balance.FormatPattern);
                mny_Running_Balance.CellCssStyle += "text-align: right;";
                mny_Running_Balance.ViewCustomAttributes = "";

                // Edit refer script

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // date_Paid
                date_Paid.HrefValue = "";

                // str_ApprovalCode
                str_ApprovalCode.HrefValue = "";

                // Payment_Number
                Payment_Number.HrefValue = "";

                // Pricelist
                Pricelist.HrefValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";

                // mny_Running_Payments
                mny_Running_Payments.HrefValue = "";

                // mny_Running_Balance
                mny_Running_Balance.HrefValue = "";
                mny_Running_Balance.TooltipValue = "";
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
            if (NationalID.Required) {
                if (!NationalID.IsDetailKey && Empty(NationalID.FormValue)) {
                    NationalID.AddErrorMessage(ConvertToString(NationalID.RequiredErrorMessage).Replace("%s", NationalID.Caption));
                }
            }
            if (str_First_Name.Required) {
                if (!str_First_Name.IsDetailKey && Empty(str_First_Name.FormValue)) {
                    str_First_Name.AddErrorMessage(ConvertToString(str_First_Name.RequiredErrorMessage).Replace("%s", str_First_Name.Caption));
                }
            }
            if (str_Last_Name.Required) {
                if (!str_Last_Name.IsDetailKey && Empty(str_Last_Name.FormValue)) {
                    str_Last_Name.AddErrorMessage(ConvertToString(str_Last_Name.RequiredErrorMessage).Replace("%s", str_Last_Name.Caption));
                }
            }
            if (date_Paid.Required) {
                if (!date_Paid.IsDetailKey && Empty(date_Paid.FormValue)) {
                    date_Paid.AddErrorMessage(ConvertToString(date_Paid.RequiredErrorMessage).Replace("%s", date_Paid.Caption));
                }
            }
            if (!CheckDate(date_Paid.FormValue, date_Paid.FormatPattern)) {
                date_Paid.AddErrorMessage(date_Paid.GetErrorMessage(false));
            }
            if (str_ApprovalCode.Required) {
                if (!str_ApprovalCode.IsDetailKey && Empty(str_ApprovalCode.FormValue)) {
                    str_ApprovalCode.AddErrorMessage(ConvertToString(str_ApprovalCode.RequiredErrorMessage).Replace("%s", str_ApprovalCode.Caption));
                }
            }
            if (Payment_Number.Required) {
                if (!Payment_Number.IsDetailKey && Empty(Payment_Number.FormValue)) {
                    Payment_Number.AddErrorMessage(ConvertToString(Payment_Number.RequiredErrorMessage).Replace("%s", Payment_Number.Caption));
                }
            }
            if (!CheckInteger(Payment_Number.FormValue)) {
                Payment_Number.AddErrorMessage(Payment_Number.GetErrorMessage(false));
            }
            if (Pricelist.Required) {
                if (!Pricelist.IsDetailKey && Empty(Pricelist.FormValue)) {
                    Pricelist.AddErrorMessage(ConvertToString(Pricelist.RequiredErrorMessage).Replace("%s", Pricelist.Caption));
                }
            }
            if (!CheckNumber(Pricelist.FormValue)) {
                Pricelist.AddErrorMessage(Pricelist.GetErrorMessage(false));
            }
            if (str_Amount_Pay.Required) {
                if (!str_Amount_Pay.IsDetailKey && Empty(str_Amount_Pay.FormValue)) {
                    str_Amount_Pay.AddErrorMessage(ConvertToString(str_Amount_Pay.RequiredErrorMessage).Replace("%s", str_Amount_Pay.Caption));
                }
            }
            if (mny_Running_Payments.Required) {
                if (!mny_Running_Payments.IsDetailKey && Empty(mny_Running_Payments.FormValue)) {
                    mny_Running_Payments.AddErrorMessage(ConvertToString(mny_Running_Payments.RequiredErrorMessage).Replace("%s", mny_Running_Payments.Caption));
                }
            }
            if (!CheckNumber(mny_Running_Payments.FormValue)) {
                mny_Running_Payments.AddErrorMessage(mny_Running_Payments.GetErrorMessage(false));
            }
            if (mny_Running_Balance.Required) {
                if (!mny_Running_Balance.IsDetailKey && Empty(mny_Running_Balance.FormValue)) {
                    mny_Running_Balance.AddErrorMessage(ConvertToString(mny_Running_Balance.RequiredErrorMessage).Replace("%s", mny_Running_Balance.Caption));
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

            // date_Paid
            date_Paid.SetDbValue(rsnew, ConvertToDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern), date_Paid.ReadOnly);

            // str_ApprovalCode
            str_ApprovalCode.SetDbValue(rsnew, str_ApprovalCode.CurrentValue, str_ApprovalCode.ReadOnly);

            // Payment_Number
            Payment_Number.SetDbValue(rsnew, Payment_Number.CurrentValue, Payment_Number.ReadOnly);

            // Pricelist
            Pricelist.SetDbValue(rsnew, Pricelist.CurrentValue, Pricelist.ReadOnly);

            // str_Amount_Pay
            str_Amount_Pay.SetDbValue(rsnew, str_Amount_Pay.CurrentValue, str_Amount_Pay.ReadOnly);

            // mny_Running_Payments
            mny_Running_Payments.SetDbValue(rsnew, mny_Running_Payments.CurrentValue, mny_Running_Payments.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

            // Check field with unique index (str_ApprovalCode)
            if (!Empty(str_ApprovalCode.CurrentValue)) {
                string filterChk = "([str_ApprovalCode] = '" + AdjustSql(str_ApprovalCode.CurrentValue, DbId) + "')";
                filterChk = filterChk + " AND NOT (" + filter + ")";
                try {
                    using var rschk = await LoadReader(filterChk);
                    if (rschk?.HasRows ?? false) {
                        var idxErrMsg = Language.Phrase("DupIndex").Replace("%f", str_ApprovalCode.Caption);
                        idxErrMsg = idxErrMsg.Replace("%v", ConvertToString(str_ApprovalCode.CurrentValue));
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
            bool validMasterRecord;
            object keyValue;
            object? v;
            string? masterFilter;
            Dictionary<string, object?> detailKeys;

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
            if (CurrentMasterTable == "tblPotentialStudentInfo") {
                NationalID.CurrentValue = NationalID.SessionValue;
            }

            // Set new row
            Dictionary<string, object> rsnew = new ();
            try {
                // NationalID
                NationalID.SetDbValue(rsnew, NationalID.CurrentValue);

                // str_First_Name
                str_First_Name.SetDbValue(rsnew, str_First_Name.CurrentValue);

                // str_Last_Name
                str_Last_Name.SetDbValue(rsnew, str_Last_Name.CurrentValue);

                // date_Paid
                date_Paid.SetDbValue(rsnew, ConvertToDateTime(date_Paid.CurrentValue, date_Paid.FormatPattern));

                // str_ApprovalCode
                str_ApprovalCode.SetDbValue(rsnew, str_ApprovalCode.CurrentValue);

                // Payment_Number
                Payment_Number.SetDbValue(rsnew, Payment_Number.CurrentValue);

                // Pricelist
                Pricelist.SetDbValue(rsnew, Pricelist.CurrentValue);

                // str_Amount_Pay
                str_Amount_Pay.SetDbValue(rsnew, str_Amount_Pay.CurrentValue);

                // mny_Running_Payments
                mny_Running_Payments.SetDbValue(rsnew, mny_Running_Payments.CurrentValue);

                // mny_Running_Balance
                mny_Running_Balance.SetDbValue(rsnew, mny_Running_Balance.CurrentValue);

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

            // Check if valid User ID
            bool validUser = false;
            string userIdMsg;
            if (!Empty(Security.CurrentUserID) && !Security.IsAdmin) { // Non system admin
                validUser = Security.IsValidUserID(str_Username.CurrentValue);
                if (!validUser) {
                    userIdMsg = Language.Phrase("UnAuthorizedUserID").Replace("%c", ConvertToString(Security.CurrentUserID));
                    userIdMsg = userIdMsg.Replace("%u", ConvertToString(str_Username.CurrentValue));
                    FailureMessage = userIdMsg;
                    return JsonBoolResult.FalseResult;
                }
            }
            string? masterFilter;
            Dictionary<string, object?> detailKeys;
            if (!Empty(str_ApprovalCode.CurrentValue)) { // Check field with unique index
                var filter = "(str_ApprovalCode = '" + AdjustSql(str_ApprovalCode.CurrentValue, DbId) + "')";
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupIndex").Replace("%f", str_ApprovalCode.Caption).Replace("%v", ConvertToString(str_ApprovalCode.CurrentValue));
                    return JsonBoolResult.FalseResult;
                }
            }
            bool validMasterRecord;

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
                    rsnew["int_Bill_ID"] = int_Bill_ID.CurrentValue!;
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
            if (masterTblVar == "tblPotentialStudentInfo") {
                NationalID.Visible = false;

                //if (tblPotentialStudentInfo.EventCancelled) EventCancelled = true;
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
