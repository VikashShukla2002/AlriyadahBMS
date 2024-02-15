namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblStudentEnrollmentSearch
    /// </summary>
    public static TblStudentEnrollmentSearch tblStudentEnrollmentSearch
    {
        get => HttpData.Get<TblStudentEnrollmentSearch>("tblStudentEnrollmentSearch")!;
        set => HttpData["tblStudentEnrollmentSearch"] = value;
    }

    /// <summary>
    /// Page class for tblStudentEnrollment
    /// </summary>
    public class TblStudentEnrollmentSearch : TblStudentEnrollmentSearchBase
    {
        // Constructor
        public TblStudentEnrollmentSearch(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblStudentEnrollmentSearch() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblStudentEnrollmentSearchBase : TblStudentEnrollment
    {
        // Page ID
        public string PageID = "search";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblStudentEnrollment";

        // Page object name
        public string PageObjName = "tblStudentEnrollmentSearch";

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
        public TblStudentEnrollmentSearchBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-search-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblStudentEnrollment)
            if (tblStudentEnrollment == null || tblStudentEnrollment is TblStudentEnrollment)
                tblStudentEnrollment = this;

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
        public string PageName => "TblStudentEnrollmentSearch";

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
            int_Enrollement_Id.SetVisibility();
            str_Full_Name.SetVisibility();
            str_Username.SetVisibility();
            NationalID.SetVisibility();
            int_CR_ID.SetVisibility();
            int_Student_Id.SetVisibility();
            int_BTW_Id.SetVisibility();
            int_Item_Id.SetVisibility();
            int_Package_Id.SetVisibility();
            str_Package_Name.SetVisibility();
            int_PackageCR_Id.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            str_PurchaseAmount.SetVisibility();
            int_ApptId.SetVisibility();
            course.SetVisibility();
            institution.SetVisibility();
            str_Notes.SetVisibility();
            int_SoldBy.SetVisibility();
            int_Bill_ID.SetVisibility();
            str_Amount_Pay.SetVisibility();
            int_ApptCldr_ID.SetVisibility();
            UniqueIdx.SetVisibility();
        }

        // Constructor
        public TblStudentEnrollmentSearchBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblStudentEnrollmentView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Enrollement_Id") ? dict["int_Enrollement_Id"] : int_Enrollement_Id.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Enrollement_Id.Visible = false;
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

        public string FormClassName = "ew-form ew-search-form";

        public bool IsModal = false;

        public bool IsMobileOrModal = false;

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
            await SetupLookupOptions(str_Full_Name);
            await SetupLookupOptions(NationalID);
            await SetupLookupOptions(int_CR_ID);
            await SetupLookupOptions(int_Package_Id);
            await SetupLookupOptions(course);

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Check modal
            if (IsModal)
                SkipHeaderFooter = true;
            IsMobileOrModal = IsMobile() || IsModal;

            // Get action
            CurrentAction = CurrentForm.GetValue("action");
            if (IsSearch) {
                // Build search string for advanced search, remove blank field
                LoadSearchValues(); // Get search values
                string srchStr = ValidateSearch() ? BuildAdvancedSearch() : "";
                if (!Empty(srchStr)) {
                    srchStr = "TblStudentEnrollmentList?" + srchStr;
                    // Do not return Json for UseAjaxActions
                    if (IsModal && UseAjaxActions)
                        IsModal = false;
                    return Terminate(srchStr); // Go to List page
                }
            }

            // Restore search settings from Session
            if (!HasInvalidFields())
                LoadAdvancedSearch();

            // Render row for search
            RowType = RowType.Search;
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
                tblStudentEnrollmentSearch?.PageRender();
            }
            return PageResult();
        }

        // Build advanced search
        protected string BuildAdvancedSearch() {
            string srchUrl = "";
            BuildSearchUrl(ref srchUrl, int_Enrollement_Id); // int_Enrollement_Id
            BuildSearchUrl(ref srchUrl, str_Full_Name); // str_Full_Name
            BuildSearchUrl(ref srchUrl, str_Username); // str_Username
            BuildSearchUrl(ref srchUrl, NationalID); // NationalID
            BuildSearchUrl(ref srchUrl, int_CR_ID); // int_CR_ID
            BuildSearchUrl(ref srchUrl, int_Student_Id); // int_Student_Id
            BuildSearchUrl(ref srchUrl, int_BTW_Id); // int_BTW_Id
            BuildSearchUrl(ref srchUrl, int_Item_Id); // int_Item_Id
            BuildSearchUrl(ref srchUrl, int_Package_Id); // int_Package_Id
            BuildSearchUrl(ref srchUrl, str_Package_Name); // str_Package_Name
            BuildSearchUrl(ref srchUrl, int_PackageCR_Id); // int_PackageCR_Id
            BuildSearchUrl(ref srchUrl, date_Created); // date_Created
            BuildSearchUrl(ref srchUrl, date_Modified); // date_Modified
            BuildSearchUrl(ref srchUrl, int_Created_By); // int_Created_By
            BuildSearchUrl(ref srchUrl, int_Modified_By); // int_Modified_By
            BuildSearchUrl(ref srchUrl, str_PurchaseAmount); // str_PurchaseAmount
            BuildSearchUrl(ref srchUrl, int_ApptId); // int_ApptId
            BuildSearchUrl(ref srchUrl, course); // course
            BuildSearchUrl(ref srchUrl, institution); // institution
            BuildSearchUrl(ref srchUrl, str_Notes); // str_Notes
            BuildSearchUrl(ref srchUrl, int_SoldBy); // int_SoldBy
            BuildSearchUrl(ref srchUrl, int_Bill_ID); // int_Bill_ID
            BuildSearchUrl(ref srchUrl, str_Amount_Pay); // str_Amount_Pay
            BuildSearchUrl(ref srchUrl, int_ApptCldr_ID); // int_ApptCldr_ID
            BuildSearchUrl(ref srchUrl, UniqueIdx); // UniqueIdx
            if (!Empty(srchUrl))
                srchUrl += "&";
            srchUrl += "cmd=search";
            return srchUrl;
        }

        // Build search URL
        protected void BuildSearchUrl(ref string url, DbField fld, bool oprOnly = false) {
            bool isValid;
            string wrk = "";
            string fldParm = fld.Param;
            string ctl = "x_" + fldParm;
            string ctl2 = "y_" + fldParm;
            if (fld.IsMultiSelect) { // DN
                ctl += "[]";
                ctl2 += "[]";
            }
            string fldVal = CurrentForm.GetValue(ctl);
            string fldOpr = CurrentForm.GetValue("z_" + fldParm);
            string fldCond = CurrentForm.GetValue("v_" + fldParm);
            string fldVal2 = CurrentForm.GetValue(ctl2);
            string fldOpr2 = CurrentForm.GetValue("w_" + fldParm);
            DataType fldDataType = fld.IsVirtual ? DataType.String : fld.DataType;
            fldVal = ConvertSearchValue(fldVal, fldOpr, fld); // For testing if numeric only
            fldVal2 = ConvertSearchValue(fldVal2, fldOpr2, fld); // For testing if numeric only
            fldOpr = ConvertSearchOperator(fldOpr, fld, fldVal);
            fldOpr2 = ConvertSearchOperator(fldOpr2, fld, fldVal2);
            if ((new [] { "BETWEEN", "NOT BETWEEN" }).Contains(fldOpr)) {
                isValid = fldDataType != DataType.Number || fld.VirtualSearch || IsNumericSearchValue(fldVal, fldOpr, fld) && IsNumericSearchValue(fldVal2, fldOpr2, fld);
                if (!Empty(fldVal) && !Empty(fldVal2) && isValid)
                    wrk = ctl + "=" + UrlEncode(fldVal) + "&" + ctl2 + "=" + UrlEncode(fldVal2) + "&z_" + fldParm + "=" + UrlEncode(fldOpr);
            } else {
                isValid = fldDataType != DataType.Number || fld.VirtualSearch || IsNumericSearchValue(fldVal, fldOpr, fld);
                if (!Empty(fldVal) && isValid && IsValidOperator(fldOpr)) {
                    wrk = ctl + "=" + UrlEncode(fldVal) + "&z_" + fldParm + "=" + UrlEncode(fldOpr);
                } else if ((new [] { "IS NULL", "IS NOT NULL", "IS EMPTY", "IS NOT EMPTY" }).Contains(fldOpr) || !Empty(fldOpr) && oprOnly && IsValidOperator(fldOpr)) {
                    wrk = "z_" + fldParm + "=" + UrlEncode(fldOpr);
                }
                isValid = fldDataType != DataType.Number || fld.VirtualSearch || IsNumericSearchValue(fldVal2, fldOpr2, fld);
                if (!Empty(fldVal2) && isValid && IsValidOperator(fldOpr2)) {
                    if (!Empty(wrk))
                        wrk += "&v_" + fldParm + "=" + fldCond + "&";
                    wrk += ctl2 + "=" + UrlEncode(fldVal2) + "&w_" + fldParm + "=" + UrlEncode(fldOpr2);
                } else if ((new [] { "IS NULL", "IS NOT NULL", "IS EMPTY", "IS NOT EMPTY" }).Contains(fldOpr2) || !Empty(fldOpr2) && oprOnly && IsValidOperator(fldOpr2)) {
                    if (!Empty(wrk))
                        wrk += "&v_" + fldParm + "=" + UrlEncode(fldCond) + "&";
                    wrk += "w_" + fldParm + "=" + UrlEncode(fldOpr2);
                }
            }
            if (!Empty(wrk)) {
                if (!Empty(url))
                    url += "&";
                url += wrk;
            }
        }

        // Load search values for validation // DN
        protected void LoadSearchValues() {
            // int_Enrollement_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Enrollement_Id"))
                    int_Enrollement_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Enrollement_Id");
            if (Form.ContainsKey("z_int_Enrollement_Id"))
                int_Enrollement_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Enrollement_Id");

            // str_Full_Name
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Full_Name"))
                    str_Full_Name.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Full_Name");
            if (Form.ContainsKey("z_str_Full_Name"))
                str_Full_Name.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Full_Name");

            // str_Username
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Username"))
                    str_Username.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Username");
            if (Form.ContainsKey("z_str_Username"))
                str_Username.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Username");

            // NationalID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_NationalID"))
                    NationalID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_NationalID");
            if (Form.ContainsKey("z_NationalID"))
                NationalID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_NationalID");

            // int_CR_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_CR_ID"))
                    int_CR_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_CR_ID");
            if (Form.ContainsKey("z_int_CR_ID"))
                int_CR_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_CR_ID");

            // int_Student_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Student_Id"))
                    int_Student_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Student_Id");
            if (Form.ContainsKey("z_int_Student_Id"))
                int_Student_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Student_Id");

            // int_BTW_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_BTW_Id"))
                    int_BTW_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_BTW_Id");
            if (Form.ContainsKey("z_int_BTW_Id"))
                int_BTW_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_BTW_Id");

            // int_Item_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Item_Id"))
                    int_Item_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Item_Id");
            if (Form.ContainsKey("z_int_Item_Id"))
                int_Item_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Item_Id");

            // int_Package_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Package_Id"))
                    int_Package_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Package_Id");
            if (Form.ContainsKey("z_int_Package_Id"))
                int_Package_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Package_Id");

            // str_Package_Name
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Package_Name"))
                    str_Package_Name.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Package_Name");
            if (Form.ContainsKey("z_str_Package_Name"))
                str_Package_Name.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Package_Name");

            // int_PackageCR_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_PackageCR_Id"))
                    int_PackageCR_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_PackageCR_Id");
            if (Form.ContainsKey("z_int_PackageCR_Id"))
                int_PackageCR_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_PackageCR_Id");

            // date_Created
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Created"))
                    date_Created.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Created");
            if (Form.ContainsKey("z_date_Created"))
                date_Created.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Created");

            // date_Modified
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Modified"))
                    date_Modified.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Modified");
            if (Form.ContainsKey("z_date_Modified"))
                date_Modified.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Modified");

            // int_Created_By
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Created_By"))
                    int_Created_By.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Created_By");
            if (Form.ContainsKey("z_int_Created_By"))
                int_Created_By.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Created_By");

            // int_Modified_By
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Modified_By"))
                    int_Modified_By.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Modified_By");
            if (Form.ContainsKey("z_int_Modified_By"))
                int_Modified_By.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Modified_By");

            // str_PurchaseAmount
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_PurchaseAmount"))
                    str_PurchaseAmount.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_PurchaseAmount");
            if (Form.ContainsKey("z_str_PurchaseAmount"))
                str_PurchaseAmount.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_PurchaseAmount");

            // int_ApptId
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_ApptId"))
                    int_ApptId.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_ApptId");
            if (Form.ContainsKey("z_int_ApptId"))
                int_ApptId.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_ApptId");

            // course
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_course"))
                    course.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_course");
            if (Form.ContainsKey("z_course"))
                course.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_course");

            // institution
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_institution"))
                    institution.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_institution");
            if (Form.ContainsKey("z_institution"))
                institution.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_institution");

            // str_Notes
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Notes"))
                    str_Notes.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Notes");
            if (Form.ContainsKey("z_str_Notes"))
                str_Notes.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Notes");

            // int_SoldBy
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_SoldBy"))
                    int_SoldBy.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_SoldBy");
            if (Form.ContainsKey("z_int_SoldBy"))
                int_SoldBy.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_SoldBy");

            // int_Bill_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Bill_ID"))
                    int_Bill_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Bill_ID");
            if (Form.ContainsKey("z_int_Bill_ID"))
                int_Bill_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Bill_ID");

            // str_Amount_Pay
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Amount_Pay"))
                    str_Amount_Pay.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Amount_Pay");
            if (Form.ContainsKey("z_str_Amount_Pay"))
                str_Amount_Pay.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Amount_Pay");

            // int_ApptCldr_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_ApptCldr_ID"))
                    int_ApptCldr_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_ApptCldr_ID");
            if (Form.ContainsKey("z_int_ApptCldr_ID"))
                int_ApptCldr_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_ApptCldr_ID");

            // UniqueIdx
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_UniqueIdx"))
                    UniqueIdx.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_UniqueIdx");
            if (Form.ContainsKey("z_UniqueIdx"))
                UniqueIdx.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_UniqueIdx");
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
            int_Enrollement_Id.SetDbValue(row["int_Enrollement_Id"]);
            str_Full_Name.SetDbValue(row["str_Full_Name"]);
            str_Username.SetDbValue(row["str_Username"]);
            NationalID.SetDbValue(row["NationalID"]);
            int_CR_ID.SetDbValue(row["int_CR_ID"]);
            int_Student_Id.SetDbValue(row["int_Student_Id"]);
            int_BTW_Id.SetDbValue(row["int_BTW_Id"]);
            int_Item_Id.SetDbValue(row["int_Item_Id"]);
            int_Package_Id.SetDbValue(row["int_Package_Id"]);
            str_Package_Name.SetDbValue(row["str_Package_Name"]);
            int_PackageCR_Id.SetDbValue(row["int_PackageCR_Id"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            str_PurchaseAmount.SetDbValue(IsNull(row["str_PurchaseAmount"]) ? DbNullValue : ConvertToDouble(row["str_PurchaseAmount"]));
            int_ApptId.SetDbValue(row["int_ApptId"]);
            course.SetDbValue(row["course"]);
            institution.SetDbValue(row["institution"]);
            str_Notes.SetDbValue(row["str_Notes"]);
            int_SoldBy.SetDbValue(row["int_SoldBy"]);
            int_Bill_ID.SetDbValue(row["int_Bill_ID"]);
            str_Amount_Pay.SetDbValue(row["str_Amount_Pay"]);
            int_ApptCldr_ID.SetDbValue(row["int_ApptCldr_ID"]);
            UniqueIdx.SetDbValue(row["UniqueIdx"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Enrollement_Id", int_Enrollement_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Full_Name", str_Full_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_CR_ID", int_CR_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_Id", int_Student_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_BTW_Id", int_BTW_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Item_Id", int_Item_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Package_Id", int_Package_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Package_Name", str_Package_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("int_PackageCR_Id", int_PackageCR_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("str_PurchaseAmount", str_PurchaseAmount.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ApptId", int_ApptId.DefaultValue ?? DbNullValue); // DN
            row.Add("course", course.DefaultValue ?? DbNullValue); // DN
            row.Add("institution", institution.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Notes", str_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_SoldBy", int_SoldBy.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Bill_ID", int_Bill_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Amount_Pay", str_Amount_Pay.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ApptCldr_ID", int_ApptCldr_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("UniqueIdx", UniqueIdx.DefaultValue ?? DbNullValue); // DN
            return row;
        }

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_Enrollement_Id
            int_Enrollement_Id.RowCssClass = "row";

            // str_Full_Name
            str_Full_Name.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // int_CR_ID
            int_CR_ID.RowCssClass = "row";

            // int_Student_Id
            int_Student_Id.RowCssClass = "row";

            // int_BTW_Id
            int_BTW_Id.RowCssClass = "row";

            // int_Item_Id
            int_Item_Id.RowCssClass = "row";

            // int_Package_Id
            int_Package_Id.RowCssClass = "row";

            // str_Package_Name
            str_Package_Name.RowCssClass = "row";

            // int_PackageCR_Id
            int_PackageCR_Id.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // str_PurchaseAmount
            str_PurchaseAmount.RowCssClass = "row";

            // int_ApptId
            int_ApptId.RowCssClass = "row";

            // course
            course.RowCssClass = "row";

            // institution
            institution.RowCssClass = "row";

            // str_Notes
            str_Notes.RowCssClass = "row";

            // int_SoldBy
            int_SoldBy.RowCssClass = "row";

            // int_Bill_ID
            int_Bill_ID.RowCssClass = "row";

            // str_Amount_Pay
            str_Amount_Pay.RowCssClass = "row";

            // int_ApptCldr_ID
            int_ApptCldr_ID.RowCssClass = "row";

            // UniqueIdx
            UniqueIdx.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // int_Enrollement_Id
                int_Enrollement_Id.ViewValue = int_Enrollement_Id.CurrentValue;
                int_Enrollement_Id.ViewCustomAttributes = "";

                // str_Full_Name
                curVal = ConvertToString(str_Full_Name.CurrentValue);
                if (!Empty(curVal)) {
                    if (str_Full_Name.Lookup != null && IsDictionary(str_Full_Name.Lookup?.Options) && str_Full_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        str_Full_Name.ViewValue = str_Full_Name.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name.CurrentValue, DataType.String, "");
                        sqlWrk = str_Full_Name.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && str_Full_Name.Lookup != null) { // Lookup values found
                            var listwrk = str_Full_Name.Lookup?.RenderViewRow(rswrk[0]);
                            str_Full_Name.ViewValue = str_Full_Name.HighlightLookup(ConvertToString(rswrk[0]), str_Full_Name.DisplayValue(listwrk));
                        } else {
                            str_Full_Name.ViewValue = str_Full_Name.CurrentValue;
                        }
                    }
                } else {
                    str_Full_Name.ViewValue = DbNullValue;
                }
                str_Full_Name.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = str_Username.CurrentValue;
                str_Username.ViewCustomAttributes = "";

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

                // int_CR_ID
                curVal = ConvertToString(int_CR_ID.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_CR_ID.Lookup != null && IsDictionary(int_CR_ID.Lookup?.Options) && int_CR_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_CR_ID.ViewValue = int_CR_ID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_CR_ID]", "=", int_CR_ID.CurrentValue, DataType.Number, "");
                        sqlWrk = int_CR_ID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_CR_ID.Lookup != null) { // Lookup values found
                            var listwrk = int_CR_ID.Lookup?.RenderViewRow(rswrk[0]);
                            int_CR_ID.ViewValue = int_CR_ID.HighlightLookup(ConvertToString(rswrk[0]), int_CR_ID.DisplayValue(listwrk));
                        } else {
                            int_CR_ID.ViewValue = FormatNumber(int_CR_ID.CurrentValue, int_CR_ID.FormatPattern);
                        }
                    }
                } else {
                    int_CR_ID.ViewValue = DbNullValue;
                }
                int_CR_ID.ViewCustomAttributes = "";

                // int_Student_Id
                int_Student_Id.ViewValue = int_Student_Id.CurrentValue;
                int_Student_Id.ViewValue = FormatNumber(int_Student_Id.ViewValue, int_Student_Id.FormatPattern);
                int_Student_Id.ViewCustomAttributes = "";

                // int_BTW_Id
                int_BTW_Id.ViewValue = int_BTW_Id.CurrentValue;
                int_BTW_Id.ViewValue = FormatNumber(int_BTW_Id.ViewValue, int_BTW_Id.FormatPattern);
                int_BTW_Id.ViewCustomAttributes = "";

                // int_Item_Id
                int_Item_Id.ViewValue = int_Item_Id.CurrentValue;
                int_Item_Id.ViewValue = FormatNumber(int_Item_Id.ViewValue, int_Item_Id.FormatPattern);
                int_Item_Id.ViewCustomAttributes = "";

                // int_Package_Id
                curVal = ConvertToString(int_Package_Id.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Package_Id.Lookup != null && IsDictionary(int_Package_Id.Lookup?.Options) && int_Package_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Package_Id.ViewValue = int_Package_Id.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_CR_Product_ID]", "=", int_Package_Id.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Package_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Package_Id.Lookup != null) { // Lookup values found
                            var listwrk = int_Package_Id.Lookup?.RenderViewRow(rswrk[0]);
                            int_Package_Id.ViewValue = int_Package_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Package_Id.DisplayValue(listwrk));
                        } else {
                            int_Package_Id.ViewValue = FormatNumber(int_Package_Id.CurrentValue, int_Package_Id.FormatPattern);
                        }
                    }
                } else {
                    int_Package_Id.ViewValue = DbNullValue;
                }
                int_Package_Id.ViewCustomAttributes = "";

                // str_Package_Name
                str_Package_Name.ViewValue = ConvertToString(str_Package_Name.CurrentValue); // DN
                str_Package_Name.ViewCustomAttributes = "";

                // int_PackageCR_Id
                int_PackageCR_Id.ViewValue = FormatNumber(int_PackageCR_Id.ViewValue, int_PackageCR_Id.FormatPattern);
                int_PackageCR_Id.ViewCustomAttributes = "";

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

                // str_PurchaseAmount
                str_PurchaseAmount.ViewValue = str_PurchaseAmount.CurrentValue;
                str_PurchaseAmount.ViewValue = FormatNumber(str_PurchaseAmount.ViewValue, str_PurchaseAmount.FormatPattern);
                str_PurchaseAmount.ViewCustomAttributes = "";

                // int_ApptId
                int_ApptId.ViewValue = int_ApptId.CurrentValue;
                int_ApptId.ViewValue = FormatNumber(int_ApptId.ViewValue, int_ApptId.FormatPattern);
                int_ApptId.ViewCustomAttributes = "";

                // course
                course.ViewValue = ConvertToString(course.CurrentValue); // DN
                course.ViewCustomAttributes = "";

                // institution
                institution.ViewValue = ConvertToString(institution.CurrentValue); // DN
                institution.ViewCustomAttributes = "";

                // str_Notes
                str_Notes.ViewValue = ConvertToString(str_Notes.CurrentValue); // DN
                str_Notes.ViewCustomAttributes = "";

                // int_SoldBy
                int_SoldBy.ViewValue = int_SoldBy.CurrentValue;
                int_SoldBy.ViewValue = FormatNumber(int_SoldBy.ViewValue, int_SoldBy.FormatPattern);
                int_SoldBy.ViewCustomAttributes = "";

                // int_Bill_ID
                int_Bill_ID.ViewValue = int_Bill_ID.CurrentValue;
                int_Bill_ID.ViewValue = FormatNumber(int_Bill_ID.ViewValue, int_Bill_ID.FormatPattern);
                int_Bill_ID.ViewCustomAttributes = "";

                // str_Amount_Pay
                str_Amount_Pay.ViewValue = ConvertToString(str_Amount_Pay.CurrentValue); // DN
                str_Amount_Pay.ViewCustomAttributes = "";

                // int_ApptCldr_ID
                int_ApptCldr_ID.ViewValue = int_ApptCldr_ID.CurrentValue;
                int_ApptCldr_ID.ViewValue = FormatNumber(int_ApptCldr_ID.ViewValue, int_ApptCldr_ID.FormatPattern);
                int_ApptCldr_ID.ViewCustomAttributes = "";

                // UniqueIdx
                UniqueIdx.ViewValue = ConvertToString(UniqueIdx.CurrentValue); // DN
                UniqueIdx.ViewCustomAttributes = "";

                // int_Enrollement_Id
                int_Enrollement_Id.HrefValue = "";
                int_Enrollement_Id.TooltipValue = "";

                // str_Full_Name
                str_Full_Name.HrefValue = "";
                str_Full_Name.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // int_CR_ID
                int_CR_ID.HrefValue = "";
                int_CR_ID.TooltipValue = "";

                // int_Student_Id
                int_Student_Id.HrefValue = "";
                int_Student_Id.TooltipValue = "";

                // int_BTW_Id
                int_BTW_Id.HrefValue = "";
                int_BTW_Id.TooltipValue = "";

                // int_Item_Id
                int_Item_Id.HrefValue = "";
                int_Item_Id.TooltipValue = "";

                // int_Package_Id
                int_Package_Id.HrefValue = "";
                int_Package_Id.TooltipValue = "";

                // str_Package_Name
                str_Package_Name.HrefValue = "";
                str_Package_Name.TooltipValue = "";

                // int_PackageCR_Id
                int_PackageCR_Id.HrefValue = "";
                int_PackageCR_Id.TooltipValue = "";

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

                // str_PurchaseAmount
                str_PurchaseAmount.HrefValue = "";
                str_PurchaseAmount.TooltipValue = "";

                // int_ApptId
                int_ApptId.HrefValue = "";
                int_ApptId.TooltipValue = "";

                // course
                course.HrefValue = "";
                course.TooltipValue = "";

                // institution
                institution.HrefValue = "";
                institution.TooltipValue = "";

                // str_Notes
                str_Notes.HrefValue = "";
                str_Notes.TooltipValue = "";

                // int_SoldBy
                int_SoldBy.HrefValue = "";
                int_SoldBy.TooltipValue = "";

                // int_Bill_ID
                int_Bill_ID.HrefValue = "";
                int_Bill_ID.TooltipValue = "";

                // str_Amount_Pay
                str_Amount_Pay.HrefValue = "";
                str_Amount_Pay.TooltipValue = "";

                // int_ApptCldr_ID
                int_ApptCldr_ID.HrefValue = "";
                int_ApptCldr_ID.TooltipValue = "";

                // UniqueIdx
                UniqueIdx.HrefValue = "";
                UniqueIdx.TooltipValue = "";
            } else if (RowType == RowType.Search) {
                // int_Enrollement_Id
                int_Enrollement_Id.SetupEditAttributes();
                int_Enrollement_Id.EditValue = int_Enrollement_Id.AdvancedSearch.SearchValue; // DN
                int_Enrollement_Id.PlaceHolder = RemoveHtml(int_Enrollement_Id.Caption);

                // str_Full_Name
                str_Full_Name.SetupEditAttributes();
                curVal = ConvertToString(str_Full_Name.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (str_Full_Name.Lookup != null && IsDictionary(str_Full_Name.Lookup?.Options) && str_Full_Name.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Full_Name.EditValue = str_Full_Name.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name.AdvancedSearch.SearchValue, DataType.String, "");
                    }
                    sqlWrk = str_Full_Name.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_Full_Name.EditValue = rswrk;
                }
                str_Full_Name.PlaceHolder = RemoveHtml(str_Full_Name.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!str_Username.Raw)
                    str_Username.AdvancedSearch.SearchValue = HtmlDecode(str_Username.AdvancedSearch.SearchValue);
                str_Username.EditValue = HtmlEncode(str_Username.AdvancedSearch.SearchValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                curVal = ConvertToString(NationalID.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    NationalID.EditValue = NationalID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[NationalID]", "=", NationalID.AdvancedSearch.SearchValue, DataType.Number, "");
                    }
                    sqlWrk = NationalID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    NationalID.EditValue = rswrk;
                }
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

                // int_CR_ID
                int_CR_ID.SetupEditAttributes();
                curVal = ConvertToString(int_CR_ID.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (int_CR_ID.Lookup != null && IsDictionary(int_CR_ID.Lookup?.Options) && int_CR_ID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_CR_ID.EditValue = int_CR_ID.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_CR_ID]", "=", int_CR_ID.AdvancedSearch.SearchValue, DataType.Number, "");
                    }
                    sqlWrk = int_CR_ID.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_CR_ID.EditValue = rswrk;
                }
                int_CR_ID.PlaceHolder = RemoveHtml(int_CR_ID.Caption);

                // int_Student_Id
                int_Student_Id.SetupEditAttributes();
                int_Student_Id.EditValue = int_Student_Id.AdvancedSearch.SearchValue; // DN
                int_Student_Id.PlaceHolder = RemoveHtml(int_Student_Id.Caption);

                // int_BTW_Id
                int_BTW_Id.SetupEditAttributes();
                int_BTW_Id.EditValue = int_BTW_Id.AdvancedSearch.SearchValue; // DN
                int_BTW_Id.PlaceHolder = RemoveHtml(int_BTW_Id.Caption);

                // int_Item_Id
                int_Item_Id.SetupEditAttributes();
                int_Item_Id.EditValue = int_Item_Id.AdvancedSearch.SearchValue; // DN
                int_Item_Id.PlaceHolder = RemoveHtml(int_Item_Id.Caption);

                // int_Package_Id
                int_Package_Id.SetupEditAttributes();
                curVal = ConvertToString(int_Package_Id.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (int_Package_Id.Lookup != null && IsDictionary(int_Package_Id.Lookup?.Options) && int_Package_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Package_Id.EditValue = int_Package_Id.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_CR_Product_ID]", "=", int_Package_Id.AdvancedSearch.SearchValue, DataType.Number, "");
                    }
                    sqlWrk = int_Package_Id.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Package_Id.EditValue = rswrk;
                }
                int_Package_Id.PlaceHolder = RemoveHtml(int_Package_Id.Caption);

                // str_Package_Name
                str_Package_Name.SetupEditAttributes();
                if (!str_Package_Name.Raw)
                    str_Package_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Package_Name.AdvancedSearch.SearchValue);
                str_Package_Name.EditValue = HtmlEncode(str_Package_Name.AdvancedSearch.SearchValue);
                str_Package_Name.PlaceHolder = RemoveHtml(str_Package_Name.Caption);

                // int_PackageCR_Id
                int_PackageCR_Id.SetupEditAttributes();
                int_PackageCR_Id.PlaceHolder = RemoveHtml(int_PackageCR_Id.Caption);

                // date_Created
                date_Created.SetupEditAttributes();
                date_Created.EditValue = FormatDateTime(UnformatDateTime(date_Created.AdvancedSearch.SearchValue, date_Created.FormatPattern), date_Created.FormatPattern); // DN
                date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

                // date_Modified
                date_Modified.SetupEditAttributes();
                date_Modified.EditValue = FormatDateTime(UnformatDateTime(date_Modified.AdvancedSearch.SearchValue, date_Modified.FormatPattern), date_Modified.FormatPattern); // DN
                date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

                // int_Created_By
                int_Created_By.SetupEditAttributes();
                int_Created_By.EditValue = int_Created_By.AdvancedSearch.SearchValue; // DN
                int_Created_By.PlaceHolder = RemoveHtml(int_Created_By.Caption);

                // int_Modified_By
                int_Modified_By.SetupEditAttributes();
                int_Modified_By.EditValue = int_Modified_By.AdvancedSearch.SearchValue; // DN
                int_Modified_By.PlaceHolder = RemoveHtml(int_Modified_By.Caption);

                // str_PurchaseAmount
                str_PurchaseAmount.SetupEditAttributes();
                str_PurchaseAmount.EditValue = str_PurchaseAmount.AdvancedSearch.SearchValue; // DN
                str_PurchaseAmount.PlaceHolder = RemoveHtml(str_PurchaseAmount.Caption);

                // int_ApptId
                int_ApptId.SetupEditAttributes();
                int_ApptId.EditValue = int_ApptId.AdvancedSearch.SearchValue; // DN
                int_ApptId.PlaceHolder = RemoveHtml(int_ApptId.Caption);

                // course
                course.SetupEditAttributes();
                if (!course.Raw)
                    course.AdvancedSearch.SearchValue = HtmlDecode(course.AdvancedSearch.SearchValue);
                course.EditValue = HtmlEncode(course.AdvancedSearch.SearchValue);
                course.PlaceHolder = RemoveHtml(course.Caption);

                // institution
                institution.SetupEditAttributes();
                if (!institution.Raw)
                    institution.AdvancedSearch.SearchValue = HtmlDecode(institution.AdvancedSearch.SearchValue);
                institution.EditValue = HtmlEncode(institution.AdvancedSearch.SearchValue);
                institution.PlaceHolder = RemoveHtml(institution.Caption);

                // str_Notes
                str_Notes.SetupEditAttributes();
                if (!str_Notes.Raw)
                    str_Notes.AdvancedSearch.SearchValue = HtmlDecode(str_Notes.AdvancedSearch.SearchValue);
                str_Notes.EditValue = HtmlEncode(str_Notes.AdvancedSearch.SearchValue);
                str_Notes.PlaceHolder = RemoveHtml(str_Notes.Caption);

                // int_SoldBy
                int_SoldBy.SetupEditAttributes();
                int_SoldBy.EditValue = int_SoldBy.AdvancedSearch.SearchValue; // DN
                int_SoldBy.PlaceHolder = RemoveHtml(int_SoldBy.Caption);

                // int_Bill_ID
                int_Bill_ID.SetupEditAttributes();
                int_Bill_ID.EditValue = int_Bill_ID.AdvancedSearch.SearchValue; // DN
                int_Bill_ID.PlaceHolder = RemoveHtml(int_Bill_ID.Caption);

                // str_Amount_Pay
                str_Amount_Pay.SetupEditAttributes();
                if (!str_Amount_Pay.Raw)
                    str_Amount_Pay.AdvancedSearch.SearchValue = HtmlDecode(str_Amount_Pay.AdvancedSearch.SearchValue);
                str_Amount_Pay.EditValue = HtmlEncode(str_Amount_Pay.AdvancedSearch.SearchValue);
                str_Amount_Pay.PlaceHolder = RemoveHtml(str_Amount_Pay.Caption);

                // int_ApptCldr_ID
                int_ApptCldr_ID.SetupEditAttributes();
                int_ApptCldr_ID.EditValue = int_ApptCldr_ID.AdvancedSearch.SearchValue; // DN
                int_ApptCldr_ID.PlaceHolder = RemoveHtml(int_ApptCldr_ID.Caption);

                // UniqueIdx
                UniqueIdx.SetupEditAttributes();
                if (!UniqueIdx.Raw)
                    UniqueIdx.AdvancedSearch.SearchValue = HtmlDecode(UniqueIdx.AdvancedSearch.SearchValue);
                UniqueIdx.EditValue = HtmlEncode(UniqueIdx.AdvancedSearch.SearchValue);
                UniqueIdx.PlaceHolder = RemoveHtml(UniqueIdx.Caption);
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
            if (!CheckInteger(ConvertToString(int_Enrollement_Id.AdvancedSearch.SearchValue))) {
                int_Enrollement_Id.AddErrorMessage(int_Enrollement_Id.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Student_Id.AdvancedSearch.SearchValue))) {
                int_Student_Id.AddErrorMessage(int_Student_Id.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_BTW_Id.AdvancedSearch.SearchValue))) {
                int_BTW_Id.AddErrorMessage(int_BTW_Id.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Item_Id.AdvancedSearch.SearchValue))) {
                int_Item_Id.AddErrorMessage(int_Item_Id.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(date_Created.AdvancedSearch.SearchValue), date_Created.FormatPattern)) {
                date_Created.AddErrorMessage(date_Created.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(date_Modified.AdvancedSearch.SearchValue), date_Modified.FormatPattern)) {
                date_Modified.AddErrorMessage(date_Modified.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Created_By.AdvancedSearch.SearchValue))) {
                int_Created_By.AddErrorMessage(int_Created_By.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Modified_By.AdvancedSearch.SearchValue))) {
                int_Modified_By.AddErrorMessage(int_Modified_By.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(str_PurchaseAmount.AdvancedSearch.SearchValue))) {
                str_PurchaseAmount.AddErrorMessage(str_PurchaseAmount.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_ApptId.AdvancedSearch.SearchValue))) {
                int_ApptId.AddErrorMessage(int_ApptId.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_SoldBy.AdvancedSearch.SearchValue))) {
                int_SoldBy.AddErrorMessage(int_SoldBy.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Bill_ID.AdvancedSearch.SearchValue))) {
                int_Bill_ID.AddErrorMessage(int_Bill_ID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_ApptCldr_ID.AdvancedSearch.SearchValue))) {
                int_ApptCldr_ID.AddErrorMessage(int_ApptCldr_ID.GetErrorMessage(false));
            }

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
            int_Enrollement_Id.AdvancedSearch.Load();
            str_Full_Name.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            int_CR_ID.AdvancedSearch.Load();
            int_Student_Id.AdvancedSearch.Load();
            int_BTW_Id.AdvancedSearch.Load();
            int_Item_Id.AdvancedSearch.Load();
            int_Package_Id.AdvancedSearch.Load();
            str_Package_Name.AdvancedSearch.Load();
            int_PackageCR_Id.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            int_Created_By.AdvancedSearch.Load();
            int_Modified_By.AdvancedSearch.Load();
            str_PurchaseAmount.AdvancedSearch.Load();
            int_ApptId.AdvancedSearch.Load();
            course.AdvancedSearch.Load();
            institution.AdvancedSearch.Load();
            str_Notes.AdvancedSearch.Load();
            int_SoldBy.AdvancedSearch.Load();
            int_Bill_ID.AdvancedSearch.Load();
            str_Amount_Pay.AdvancedSearch.Load();
            int_ApptCldr_ID.AdvancedSearch.Load();
            UniqueIdx.AdvancedSearch.Load();
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblStudentEnrollmentList")), "", TableVar, true);
            string pageId = "search";
            breadcrumb.Add("search", pageId, url);
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
