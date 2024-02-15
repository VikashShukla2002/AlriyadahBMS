namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblAssessmentSearch
    /// </summary>
    public static TblAssessmentSearch tblAssessmentSearch
    {
        get => HttpData.Get<TblAssessmentSearch>("tblAssessmentSearch")!;
        set => HttpData["tblAssessmentSearch"] = value;
    }

    /// <summary>
    /// Page class for tblAssessment
    /// </summary>
    public class TblAssessmentSearch : TblAssessmentSearchBase
    {
        // Constructor
        public TblAssessmentSearch(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblAssessmentSearch() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblAssessmentSearchBase : TblAssessment
    {
        // Page ID
        public string PageID = "search";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblAssessment";

        // Page object name
        public string PageObjName = "tblAssessmentSearch";

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
        public TblAssessmentSearchBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-search-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblAssessment)
            if (tblAssessment == null || tblAssessment is TblAssessment)
                tblAssessment = this;

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
        public string PageName => "TblAssessmentSearch";

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
            BackDateChk.Visible = false;
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
        public TblAssessmentSearchBase(Controller? controller = null): this() { // DN
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

        public SubPages? MultiPages; // Multi pages object

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
                    srchStr = "TblAssessmentList?" + srchStr;
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
                tblAssessmentSearch?.PageRender();
            }
            return PageResult();
        }

        // Build advanced search
        protected string BuildAdvancedSearch() {
            string srchUrl = "";
            BuildSearchUrl(ref srchUrl, AssessmentID); // AssessmentID
            BuildSearchUrl(ref srchUrl, str_Full_Name_Hdr); // str_Full_Name_Hdr
            BuildSearchUrl(ref srchUrl, str_First_Name); // str_First_Name
            BuildSearchUrl(ref srchUrl, str_Middle_Name); // str_Middle_Name
            BuildSearchUrl(ref srchUrl, str_Last_Name); // str_Last_Name
            BuildSearchUrl(ref srchUrl, str_Username); // str_Username
            BuildSearchUrl(ref srchUrl, int_Student_ID); // int_Student_ID
            BuildSearchUrl(ref srchUrl, NationalID); // NationalID
            BuildSearchUrl(ref srchUrl, Assessment_Type); // Assessment_Type
            BuildSearchUrl(ref srchUrl, AssessmentDate); // AssessmentDate
            BuildSearchUrl(ref srchUrl, AssessmentTime); // AssessmentTime
            BuildSearchUrl(ref srchUrl, isAssessmentDone); // isAssessmentDone
            BuildSearchUrl(ref srchUrl, AssessmentScore); // AssessmentScore
            BuildSearchUrl(ref srchUrl, Assessment_Instructor); // Assessment_Instructor
            BuildSearchUrl(ref srchUrl, Date_Entered); // Date_Entered
            BuildSearchUrl(ref srchUrl, IsDrivingexperience, true); // IsDrivingexperience
            BuildSearchUrl(ref srchUrl, intDrivinglicenseType); // intDrivinglicenseType
            BuildSearchUrl(ref srchUrl, AbsherApptNbr); // AbsherApptNbr
            BuildSearchUrl(ref srchUrl, Absherphoto); // Absherphoto
            BuildSearchUrl(ref srchUrl, date_Birth); // date_Birth
            BuildSearchUrl(ref srchUrl, date_Birth_Hijri); // date_Birth_Hijri
            BuildSearchUrl(ref srchUrl, str_Cell_Phone); // str_Cell_Phone
            BuildSearchUrl(ref srchUrl, str_Email); // str_Email
            BuildSearchUrl(ref srchUrl, UserlevelID); // UserlevelID
            BuildSearchUrl(ref srchUrl, DriveTypelink); // DriveTypelink
            BuildSearchUrl(ref srchUrl, Calendar_ID); // Calendar_ID
            BuildSearchUrl(ref srchUrl, Assessmnt_Time); // Assessmnt_Time
            BuildSearchUrl(ref srchUrl, Institution); // Institution
            BuildSearchUrl(ref srchUrl, TheoreticalScore); // TheoreticalScore
            BuildSearchUrl(ref srchUrl, dt_TheoreticalScore); // dt_TheoreticalScore
            BuildSearchUrl(ref srchUrl, RoadTestScore); // RoadTestScore
            BuildSearchUrl(ref srchUrl, dt_RoadTestScore); // dt_RoadTestScore
            BuildSearchUrl(ref srchUrl, AccidentOccurrence, true); // AccidentOccurrence
            BuildSearchUrl(ref srchUrl, Dt_AccidentOccurrence); // Dt_AccidentOccurrence
            BuildSearchUrl(ref srchUrl, AccidentNotes); // AccidentNotes
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
            // AssessmentID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AssessmentID"))
                    AssessmentID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AssessmentID");
            if (Form.ContainsKey("z_AssessmentID"))
                AssessmentID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AssessmentID");

            // str_Full_Name_Hdr
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Full_Name_Hdr"))
                    str_Full_Name_Hdr.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Full_Name_Hdr");
            if (Form.ContainsKey("z_str_Full_Name_Hdr"))
                str_Full_Name_Hdr.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Full_Name_Hdr");

            // str_First_Name
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_First_Name"))
                    str_First_Name.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_First_Name");
            if (Form.ContainsKey("z_str_First_Name"))
                str_First_Name.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_First_Name");

            // str_Middle_Name
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Middle_Name"))
                    str_Middle_Name.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Middle_Name");
            if (Form.ContainsKey("z_str_Middle_Name"))
                str_Middle_Name.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Middle_Name");

            // str_Last_Name
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Last_Name"))
                    str_Last_Name.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Last_Name");
            if (Form.ContainsKey("z_str_Last_Name"))
                str_Last_Name.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Last_Name");

            // str_Username
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Username"))
                    str_Username.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Username");
            if (Form.ContainsKey("z_str_Username"))
                str_Username.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Username");

            // int_Student_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Student_ID"))
                    int_Student_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Student_ID");
            if (Form.ContainsKey("z_int_Student_ID"))
                int_Student_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Student_ID");

            // NationalID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_NationalID"))
                    NationalID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_NationalID");
            if (Form.ContainsKey("z_NationalID"))
                NationalID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_NationalID");

            // Assessment_Type
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Assessment_Type"))
                    Assessment_Type.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Assessment_Type");
            if (Form.ContainsKey("z_Assessment_Type"))
                Assessment_Type.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Assessment_Type");

            // AssessmentDate
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AssessmentDate"))
                    AssessmentDate.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AssessmentDate");
            if (Form.ContainsKey("z_AssessmentDate"))
                AssessmentDate.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AssessmentDate");

            // AssessmentTime
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AssessmentTime"))
                    AssessmentTime.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AssessmentTime");
            if (Form.ContainsKey("z_AssessmentTime"))
                AssessmentTime.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AssessmentTime");

            // isAssessmentDone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_isAssessmentDone"))
                    isAssessmentDone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_isAssessmentDone");
            if (Form.ContainsKey("z_isAssessmentDone"))
                isAssessmentDone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_isAssessmentDone");

            // AssessmentScore
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AssessmentScore"))
                    AssessmentScore.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AssessmentScore");
            if (Form.ContainsKey("z_AssessmentScore"))
                AssessmentScore.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AssessmentScore");

            // Assessment_Instructor
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Assessment_Instructor"))
                    Assessment_Instructor.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Assessment_Instructor");
            if (Form.ContainsKey("z_Assessment_Instructor"))
                Assessment_Instructor.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Assessment_Instructor");

            // Date_Entered
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Date_Entered"))
                    Date_Entered.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Date_Entered");
            if (Form.ContainsKey("z_Date_Entered"))
                Date_Entered.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Date_Entered");

            // IsDrivingexperience
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_IsDrivingexperience"))
                    IsDrivingexperience.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_IsDrivingexperience");
            if (Form.ContainsKey("z_IsDrivingexperience"))
                IsDrivingexperience.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_IsDrivingexperience");

            // intDrivinglicenseType
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_intDrivinglicenseType"))
                    intDrivinglicenseType.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_intDrivinglicenseType");
            if (Form.ContainsKey("z_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_intDrivinglicenseType");

            // AbsherApptNbr
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AbsherApptNbr"))
                    AbsherApptNbr.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AbsherApptNbr");
            if (Form.ContainsKey("z_AbsherApptNbr"))
                AbsherApptNbr.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AbsherApptNbr");

            // Absherphoto
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Absherphoto"))
                    Absherphoto.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Absherphoto");
            if (Form.ContainsKey("z_Absherphoto"))
                Absherphoto.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Absherphoto");

            // date_Birth
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Birth"))
                    date_Birth.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Birth");
            if (Form.ContainsKey("z_date_Birth"))
                date_Birth.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Birth");

            // date_Birth_Hijri
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Birth_Hijri"))
                    date_Birth_Hijri.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Birth_Hijri");
            if (Form.ContainsKey("z_date_Birth_Hijri"))
                date_Birth_Hijri.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Birth_Hijri");

            // str_Cell_Phone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Cell_Phone"))
                    str_Cell_Phone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Cell_Phone");
            if (Form.ContainsKey("z_str_Cell_Phone"))
                str_Cell_Phone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Cell_Phone");

            // str_Email
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Email"))
                    str_Email.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Email");
            if (Form.ContainsKey("z_str_Email"))
                str_Email.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Email");

            // UserlevelID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_UserlevelID"))
                    UserlevelID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_UserlevelID");
            if (Form.ContainsKey("z_UserlevelID"))
                UserlevelID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_UserlevelID");

            // DriveTypelink
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_DriveTypelink"))
                    DriveTypelink.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_DriveTypelink");
            if (Form.ContainsKey("z_DriveTypelink"))
                DriveTypelink.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_DriveTypelink");

            // Calendar_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Calendar_ID"))
                    Calendar_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Calendar_ID");
            if (Form.ContainsKey("z_Calendar_ID"))
                Calendar_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Calendar_ID");

            // Assessmnt_Time
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Assessmnt_Time"))
                    Assessmnt_Time.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Assessmnt_Time");
            if (Form.ContainsKey("z_Assessmnt_Time"))
                Assessmnt_Time.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Assessmnt_Time");

            // Institution
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Institution"))
                    Institution.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Institution");
            if (Form.ContainsKey("z_Institution"))
                Institution.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Institution");

            // TheoreticalScore
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_TheoreticalScore"))
                    TheoreticalScore.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_TheoreticalScore");
            if (Form.ContainsKey("z_TheoreticalScore"))
                TheoreticalScore.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_TheoreticalScore");

            // dt_TheoreticalScore
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_TheoreticalScore"))
                    dt_TheoreticalScore.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_TheoreticalScore");
            if (Form.ContainsKey("z_dt_TheoreticalScore"))
                dt_TheoreticalScore.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_TheoreticalScore");

            // RoadTestScore
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_RoadTestScore"))
                    RoadTestScore.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_RoadTestScore");
            if (Form.ContainsKey("z_RoadTestScore"))
                RoadTestScore.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_RoadTestScore");

            // dt_RoadTestScore
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_RoadTestScore"))
                    dt_RoadTestScore.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_RoadTestScore");
            if (Form.ContainsKey("z_dt_RoadTestScore"))
                dt_RoadTestScore.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_RoadTestScore");

            // AccidentOccurrence
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AccidentOccurrence"))
                    AccidentOccurrence.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AccidentOccurrence");
            if (Form.ContainsKey("z_AccidentOccurrence"))
                AccidentOccurrence.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AccidentOccurrence");

            // Dt_AccidentOccurrence
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Dt_AccidentOccurrence"))
                    Dt_AccidentOccurrence.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Dt_AccidentOccurrence");
            if (Form.ContainsKey("z_Dt_AccidentOccurrence"))
                Dt_AccidentOccurrence.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Dt_AccidentOccurrence");

            // AccidentNotes
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AccidentNotes"))
                    AccidentNotes.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AccidentNotes");
            if (Form.ContainsKey("z_AccidentNotes"))
                AccidentNotes.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AccidentNotes");
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
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // AssessmentID
            AssessmentID.RowCssClass = "row";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.RowCssClass = "row";

            // str_First_Name
            str_First_Name.RowCssClass = "row";

            // str_Middle_Name
            str_Middle_Name.RowCssClass = "row";

            // str_Last_Name
            str_Last_Name.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // int_Student_ID
            int_Student_ID.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // Assessment_Type
            Assessment_Type.RowCssClass = "row";

            // AssessmentDate
            AssessmentDate.RowCssClass = "row";

            // AssessmentTime
            AssessmentTime.RowCssClass = "row";

            // isAssessmentDone
            isAssessmentDone.RowCssClass = "row";

            // AssessmentScore
            AssessmentScore.RowCssClass = "row";

            // Assessment_Instructor
            Assessment_Instructor.RowCssClass = "row";

            // Date_Entered
            Date_Entered.RowCssClass = "row";

            // IsDrivingexperience
            IsDrivingexperience.RowCssClass = "row";

            // intDrivinglicenseType
            intDrivinglicenseType.RowCssClass = "row";

            // AbsherApptNbr
            AbsherApptNbr.RowCssClass = "row";

            // Absherphoto
            Absherphoto.RowCssClass = "row";

            // date_Birth
            date_Birth.RowCssClass = "row";

            // date_Birth_Hijri
            date_Birth_Hijri.RowCssClass = "row";

            // str_Cell_Phone
            str_Cell_Phone.RowCssClass = "row";

            // str_Email
            str_Email.RowCssClass = "row";

            // UserlevelID
            UserlevelID.RowCssClass = "row";

            // BackDateChk
            BackDateChk.RowCssClass = "row";

            // DriveTypelink
            DriveTypelink.RowCssClass = "row";

            // Calendar_ID
            Calendar_ID.RowCssClass = "row";

            // Assessmnt_Time
            Assessmnt_Time.RowCssClass = "row";

            // Institution
            Institution.RowCssClass = "row";

            // TheoreticalScore
            TheoreticalScore.RowCssClass = "row";

            // dt_TheoreticalScore
            dt_TheoreticalScore.RowCssClass = "row";

            // RoadTestScore
            RoadTestScore.RowCssClass = "row";

            // dt_RoadTestScore
            dt_RoadTestScore.RowCssClass = "row";

            // AccidentOccurrence
            AccidentOccurrence.RowCssClass = "row";

            // Dt_AccidentOccurrence
            Dt_AccidentOccurrence.RowCssClass = "row";

            // AccidentNotes
            AccidentNotes.RowCssClass = "row";

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

                // str_Last_Name
                str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // int_Student_ID
                int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
                int_Student_ID.ImageAlt = int_Student_ID.Alt;
                    int_Student_ID.ImageCssClass = "ew-image";
                int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
                int_Student_ID.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
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

                // DriveTypelink
                DriveTypelink.ViewValue = DriveTypelink.CurrentValue;
                DriveTypelink.ViewCustomAttributes = "";

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

                // AssessmentID
                AssessmentID.HrefValue = "";
                AssessmentID.TooltipValue = "";

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.HrefValue = "";
                str_Full_Name_Hdr.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";
                str_Middle_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // int_Student_ID
                int_Student_ID.HrefValue = "";
                int_Student_ID.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

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

                // Date_Entered
                Date_Entered.HrefValue = "";
                Date_Entered.TooltipValue = "";

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

                // UserlevelID
                UserlevelID.HrefValue = "";
                UserlevelID.TooltipValue = "";

                // DriveTypelink
                DriveTypelink.HrefValue = "";
                DriveTypelink.TooltipValue = "";

                // Calendar_ID
                Calendar_ID.HrefValue = "";
                Calendar_ID.TooltipValue = "";

                // Assessmnt_Time
                Assessmnt_Time.HrefValue = "";
                Assessmnt_Time.TooltipValue = "";

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
            } else if (RowType == RowType.Search) {
                // AssessmentID
                AssessmentID.SetupEditAttributes();
                AssessmentID.EditValue = AssessmentID.AdvancedSearch.SearchValue; // DN
                AssessmentID.PlaceHolder = RemoveHtml(AssessmentID.Caption);

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.SetupEditAttributes();
                curVal = ConvertToString(str_Full_Name_Hdr.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (str_Full_Name_Hdr.Lookup != null && IsDictionary(str_Full_Name_Hdr.Lookup?.Options) && str_Full_Name_Hdr.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_Full_Name_Hdr.EditValue = str_Full_Name_Hdr.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Full_Name]", "=", str_Full_Name_Hdr.AdvancedSearch.SearchValue, DataType.String, "");
                    }
                    lookupFilter = () => str_Full_Name_Hdr.GetSelectFilter();
                    sqlWrk = str_Full_Name_Hdr.Lookup?.GetSql(true, filterWrk, lookupFilter, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_Full_Name_Hdr.EditValue = rswrk;
                }
                str_Full_Name_Hdr.PlaceHolder = RemoveHtml(str_Full_Name_Hdr.Caption);

                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.AdvancedSearch.SearchValue = HtmlDecode(str_First_Name.AdvancedSearch.SearchValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.AdvancedSearch.SearchValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Middle_Name
                str_Middle_Name.SetupEditAttributes();
                if (!str_Middle_Name.Raw)
                    str_Middle_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Middle_Name.AdvancedSearch.SearchValue);
                str_Middle_Name.EditValue = HtmlEncode(str_Middle_Name.AdvancedSearch.SearchValue);
                str_Middle_Name.PlaceHolder = RemoveHtml(str_Middle_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.AdvancedSearch.SearchValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!str_Username.Raw)
                    str_Username.AdvancedSearch.SearchValue = HtmlDecode(str_Username.AdvancedSearch.SearchValue);
                str_Username.EditValue = HtmlEncode(str_Username.AdvancedSearch.SearchValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // int_Student_ID
                int_Student_ID.SetupEditAttributes();
                int_Student_ID.EditValue = int_Student_ID.AdvancedSearch.SearchValue; // DN
                int_Student_ID.PlaceHolder = RemoveHtml(int_Student_ID.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.AdvancedSearch.SearchValue; // DN
                curVal = ConvertToString(NationalID.AdvancedSearch.SearchValue);
                if (!Empty(curVal)) {
                    if (NationalID.Lookup != null && IsDictionary(NationalID.Lookup?.Options) && NationalID.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        NationalID.EditValue = NationalID.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[NationalID]", "=", NationalID.AdvancedSearch.SearchValue, DataType.Number, "");
                        sqlWrk = NationalID.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && NationalID.Lookup != null) { // Lookup values found
                            var listwrk = NationalID.Lookup?.RenderViewRow(rswrk[0]);
                            NationalID.EditValue = NationalID.HighlightLookup(ConvertToString(rswrk[0]), NationalID.DisplayValue(listwrk));
                        } else {
                            NationalID.EditValue = HtmlEncode(NationalID.AdvancedSearch.SearchValue);
                        }
                    }
                } else {
                    NationalID.EditValue = DbNullValue;
                }
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

                // Assessment_Type
                Assessment_Type.SetupEditAttributes();
                Assessment_Type.EditValue = Assessment_Type.Options(true);
                Assessment_Type.PlaceHolder = RemoveHtml(Assessment_Type.Caption);

                // AssessmentDate
                AssessmentDate.SetupEditAttributes();
                AssessmentDate.EditValue = FormatDateTime(UnformatDateTime(AssessmentDate.AdvancedSearch.SearchValue, AssessmentDate.FormatPattern), AssessmentDate.FormatPattern); // DN
                AssessmentDate.PlaceHolder = RemoveHtml(AssessmentDate.Caption);

                // AssessmentTime
                AssessmentTime.SetupEditAttributes();
                if (!AssessmentTime.Raw)
                    AssessmentTime.AdvancedSearch.SearchValue = HtmlDecode(AssessmentTime.AdvancedSearch.SearchValue);
                AssessmentTime.EditValue = HtmlEncode(AssessmentTime.AdvancedSearch.SearchValue);
                AssessmentTime.PlaceHolder = RemoveHtml(AssessmentTime.Caption);

                // isAssessmentDone
                isAssessmentDone.EditValue = isAssessmentDone.Options(false);
                isAssessmentDone.PlaceHolder = RemoveHtml(isAssessmentDone.Caption);

                // AssessmentScore
                AssessmentScore.SetupEditAttributes();
                if (!AssessmentScore.Raw)
                    AssessmentScore.AdvancedSearch.SearchValue = HtmlDecode(AssessmentScore.AdvancedSearch.SearchValue);
                AssessmentScore.EditValue = HtmlEncode(AssessmentScore.AdvancedSearch.SearchValue);
                AssessmentScore.PlaceHolder = RemoveHtml(AssessmentScore.Caption);

                // Assessment_Instructor
                Assessment_Instructor.SetupEditAttributes();
                curVal = ConvertToString(Assessment_Instructor.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (Assessment_Instructor.Lookup != null && IsDictionary(Assessment_Instructor.Lookup?.Options) && Assessment_Instructor.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    Assessment_Instructor.EditValue = Assessment_Instructor.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[str_Full_Name]", "=", Assessment_Instructor.AdvancedSearch.SearchValue, DataType.String, "");
                    }
                    sqlWrk = Assessment_Instructor.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    Assessment_Instructor.EditValue = rswrk;
                }
                Assessment_Instructor.PlaceHolder = RemoveHtml(Assessment_Instructor.Caption);

                // Date_Entered
                Date_Entered.SetupEditAttributes();
                Date_Entered.EditValue = FormatDateTime(UnformatDateTime(Date_Entered.AdvancedSearch.SearchValue, Date_Entered.FormatPattern), Date_Entered.FormatPattern); // DN
                Date_Entered.PlaceHolder = RemoveHtml(Date_Entered.Caption);

                // IsDrivingexperience
                IsDrivingexperience.EditValue = IsDrivingexperience.Options(false);
                IsDrivingexperience.PlaceHolder = RemoveHtml(IsDrivingexperience.Caption);

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.AdvancedSearch.SearchValue; // DN
                intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);

                // AbsherApptNbr
                AbsherApptNbr.SetupEditAttributes();
                if (!AbsherApptNbr.Raw)
                    AbsherApptNbr.AdvancedSearch.SearchValue = HtmlDecode(AbsherApptNbr.AdvancedSearch.SearchValue);
                AbsherApptNbr.EditValue = HtmlEncode(AbsherApptNbr.AdvancedSearch.SearchValue);
                AbsherApptNbr.PlaceHolder = RemoveHtml(AbsherApptNbr.Caption);

                // Absherphoto
                Absherphoto.SetupEditAttributes();
                if (!Absherphoto.Raw)
                    Absherphoto.AdvancedSearch.SearchValue = HtmlDecode(Absherphoto.AdvancedSearch.SearchValue);
                Absherphoto.EditValue = HtmlEncode(Absherphoto.AdvancedSearch.SearchValue);
                Absherphoto.PlaceHolder = RemoveHtml(Absherphoto.Caption);

                // date_Birth
                date_Birth.SetupEditAttributes();
                date_Birth.EditValue = FormatDateTime(UnformatDateTime(date_Birth.AdvancedSearch.SearchValue, date_Birth.FormatPattern), date_Birth.FormatPattern); // DN
                date_Birth.PlaceHolder = RemoveHtml(date_Birth.Caption);

                // date_Birth_Hijri
                date_Birth_Hijri.SetupEditAttributes();
                if (!date_Birth_Hijri.Raw)
                    date_Birth_Hijri.AdvancedSearch.SearchValue = HtmlDecode(date_Birth_Hijri.AdvancedSearch.SearchValue);
                date_Birth_Hijri.EditValue = HtmlEncode(date_Birth_Hijri.AdvancedSearch.SearchValue);
                date_Birth_Hijri.PlaceHolder = RemoveHtml(date_Birth_Hijri.Caption);

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

                // UserlevelID
                UserlevelID.SetupEditAttributes();
                UserlevelID.EditValue = UserlevelID.AdvancedSearch.SearchValue; // DN
                UserlevelID.PlaceHolder = RemoveHtml(UserlevelID.Caption);

                // DriveTypelink
                DriveTypelink.SetupEditAttributes();
                DriveTypelink.EditValue = DriveTypelink.AdvancedSearch.SearchValue; // DN
                DriveTypelink.PlaceHolder = RemoveHtml(DriveTypelink.Caption);

                // Calendar_ID
                Calendar_ID.SetupEditAttributes();
                Calendar_ID.EditValue = Calendar_ID.AdvancedSearch.SearchValue; // DN
                Calendar_ID.PlaceHolder = RemoveHtml(Calendar_ID.Caption);

                // Assessmnt_Time
                Assessmnt_Time.SetupEditAttributes();
                Assessmnt_Time.EditValue = FormatDateTime(UnformatDateTime(Assessmnt_Time.AdvancedSearch.SearchValue, Assessmnt_Time.FormatPattern), Assessmnt_Time.FormatPattern); // DN
                Assessmnt_Time.PlaceHolder = RemoveHtml(Assessmnt_Time.Caption);

                // Institution
                Institution.SetupEditAttributes();
                if (!Institution.Raw)
                    Institution.AdvancedSearch.SearchValue = HtmlDecode(Institution.AdvancedSearch.SearchValue);
                Institution.EditValue = HtmlEncode(Institution.AdvancedSearch.SearchValue);
                Institution.PlaceHolder = RemoveHtml(Institution.Caption);

                // TheoreticalScore
                TheoreticalScore.SetupEditAttributes();
                TheoreticalScore.EditValue = TheoreticalScore.AdvancedSearch.SearchValue; // DN
                TheoreticalScore.PlaceHolder = RemoveHtml(TheoreticalScore.Caption);

                // dt_TheoreticalScore
                dt_TheoreticalScore.SetupEditAttributes();
                dt_TheoreticalScore.EditValue = FormatDateTime(UnformatDateTime(dt_TheoreticalScore.AdvancedSearch.SearchValue, dt_TheoreticalScore.FormatPattern), dt_TheoreticalScore.FormatPattern); // DN
                dt_TheoreticalScore.PlaceHolder = RemoveHtml(dt_TheoreticalScore.Caption);

                // RoadTestScore
                RoadTestScore.SetupEditAttributes();
                RoadTestScore.EditValue = RoadTestScore.AdvancedSearch.SearchValue; // DN
                RoadTestScore.PlaceHolder = RemoveHtml(RoadTestScore.Caption);

                // dt_RoadTestScore
                dt_RoadTestScore.SetupEditAttributes();
                dt_RoadTestScore.EditValue = FormatDateTime(UnformatDateTime(dt_RoadTestScore.AdvancedSearch.SearchValue, dt_RoadTestScore.FormatPattern), dt_RoadTestScore.FormatPattern); // DN
                dt_RoadTestScore.PlaceHolder = RemoveHtml(dt_RoadTestScore.Caption);

                // AccidentOccurrence
                AccidentOccurrence.EditValue = AccidentOccurrence.Options(false);
                AccidentOccurrence.PlaceHolder = RemoveHtml(AccidentOccurrence.Caption);

                // Dt_AccidentOccurrence
                Dt_AccidentOccurrence.SetupEditAttributes();
                Dt_AccidentOccurrence.EditValue = FormatDateTime(UnformatDateTime(Dt_AccidentOccurrence.AdvancedSearch.SearchValue, Dt_AccidentOccurrence.FormatPattern), Dt_AccidentOccurrence.FormatPattern); // DN
                Dt_AccidentOccurrence.PlaceHolder = RemoveHtml(Dt_AccidentOccurrence.Caption);

                // AccidentNotes
                AccidentNotes.SetupEditAttributes();
                AccidentNotes.EditValue = AccidentNotes.AdvancedSearch.SearchValue; // DN
                AccidentNotes.PlaceHolder = RemoveHtml(AccidentNotes.Caption);
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
            if (!CheckInteger(ConvertToString(AssessmentID.AdvancedSearch.SearchValue))) {
                AssessmentID.AddErrorMessage(AssessmentID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Student_ID.AdvancedSearch.SearchValue))) {
                int_Student_ID.AddErrorMessage(int_Student_ID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(NationalID.AdvancedSearch.SearchValue))) {
                NationalID.AddErrorMessage(NationalID.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(AssessmentDate.AdvancedSearch.SearchValue), AssessmentDate.FormatPattern)) {
                AssessmentDate.AddErrorMessage(AssessmentDate.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(Date_Entered.AdvancedSearch.SearchValue), Date_Entered.FormatPattern)) {
                Date_Entered.AddErrorMessage(Date_Entered.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(intDrivinglicenseType.AdvancedSearch.SearchValue))) {
                intDrivinglicenseType.AddErrorMessage(intDrivinglicenseType.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(date_Birth.AdvancedSearch.SearchValue), date_Birth.FormatPattern)) {
                date_Birth.AddErrorMessage(date_Birth.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(UserlevelID.AdvancedSearch.SearchValue))) {
                UserlevelID.AddErrorMessage(UserlevelID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(Calendar_ID.AdvancedSearch.SearchValue))) {
                Calendar_ID.AddErrorMessage(Calendar_ID.GetErrorMessage(false));
            }
            if (!CheckTime(ConvertToString(Assessmnt_Time.AdvancedSearch.SearchValue), Assessmnt_Time.FormatPattern)) {
                Assessmnt_Time.AddErrorMessage(Assessmnt_Time.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(TheoreticalScore.AdvancedSearch.SearchValue))) {
                TheoreticalScore.AddErrorMessage(TheoreticalScore.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_TheoreticalScore.AdvancedSearch.SearchValue), dt_TheoreticalScore.FormatPattern)) {
                dt_TheoreticalScore.AddErrorMessage(dt_TheoreticalScore.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(RoadTestScore.AdvancedSearch.SearchValue))) {
                RoadTestScore.AddErrorMessage(RoadTestScore.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_RoadTestScore.AdvancedSearch.SearchValue), dt_RoadTestScore.FormatPattern)) {
                dt_RoadTestScore.AddErrorMessage(dt_RoadTestScore.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(Dt_AccidentOccurrence.AdvancedSearch.SearchValue), Dt_AccidentOccurrence.FormatPattern)) {
                Dt_AccidentOccurrence.AddErrorMessage(Dt_AccidentOccurrence.GetErrorMessage(false));
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
            AssessmentID.AdvancedSearch.Load();
            str_Full_Name_Hdr.AdvancedSearch.Load();
            str_First_Name.AdvancedSearch.Load();
            str_Middle_Name.AdvancedSearch.Load();
            str_Last_Name.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            int_Student_ID.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            Assessment_Type.AdvancedSearch.Load();
            AssessmentDate.AdvancedSearch.Load();
            AssessmentTime.AdvancedSearch.Load();
            isAssessmentDone.AdvancedSearch.Load();
            AssessmentScore.AdvancedSearch.Load();
            Assessment_Instructor.AdvancedSearch.Load();
            Date_Entered.AdvancedSearch.Load();
            IsDrivingexperience.AdvancedSearch.Load();
            intDrivinglicenseType.AdvancedSearch.Load();
            AbsherApptNbr.AdvancedSearch.Load();
            Absherphoto.AdvancedSearch.Load();
            date_Birth.AdvancedSearch.Load();
            date_Birth_Hijri.AdvancedSearch.Load();
            str_Cell_Phone.AdvancedSearch.Load();
            str_Email.AdvancedSearch.Load();
            UserlevelID.AdvancedSearch.Load();
            DriveTypelink.AdvancedSearch.Load();
            Calendar_ID.AdvancedSearch.Load();
            Assessmnt_Time.AdvancedSearch.Load();
            Institution.AdvancedSearch.Load();
            TheoreticalScore.AdvancedSearch.Load();
            dt_TheoreticalScore.AdvancedSearch.Load();
            RoadTestScore.AdvancedSearch.Load();
            dt_RoadTestScore.AdvancedSearch.Load();
            AccidentOccurrence.AdvancedSearch.Load();
            Dt_AccidentOccurrence.AdvancedSearch.Load();
            AccidentNotes.AdvancedSearch.Load();
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblAssessmentList")), "", TableVar, true);
            string pageId = "search";
            breadcrumb.Add("search", pageId, url);
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
