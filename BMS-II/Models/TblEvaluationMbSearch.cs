namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblEvaluationMbSearch
    /// </summary>
    public static TblEvaluationMbSearch tblEvaluationMbSearch
    {
        get => HttpData.Get<TblEvaluationMbSearch>("tblEvaluationMbSearch")!;
        set => HttpData["tblEvaluationMbSearch"] = value;
    }

    /// <summary>
    /// Page class for tblEvaluationMB
    /// </summary>
    public class TblEvaluationMbSearch : TblEvaluationMbSearchBase
    {
        // Constructor
        public TblEvaluationMbSearch(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblEvaluationMbSearch() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblEvaluationMbSearchBase : TblEvaluationMb
    {
        // Page ID
        public string PageID = "search";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblEvaluationMB";

        // Page object name
        public string PageObjName = "tblEvaluationMbSearch";

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
        public TblEvaluationMbSearchBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-search-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblEvaluationMb)
            if (tblEvaluationMb == null || tblEvaluationMb is TblEvaluationMb)
                tblEvaluationMb = this;

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
        public string PageName => "TblEvaluationMbSearch";

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
            Eval_ID.SetVisibility();
            int_Student_ID.SetVisibility();
            AssessmentID.SetVisibility();
            str_Full_Name_Hdr.SetVisibility();
            NationalID.SetVisibility();
            str_Cell_Phone.SetVisibility();
            str_Username.SetVisibility();
            intDrivinglicenseType.SetVisibility();
            Date_Entered.SetVisibility();
            Examination_Number.SetVisibility();
            Retake.SetVisibility();
            Section_1.SetVisibility();
            Q1.SetVisibility();
            Q2.SetVisibility();
            Q3.SetVisibility();
            Q4.SetVisibility();
            Q5.SetVisibility();
            Section_2.SetVisibility();
            Q6.SetVisibility();
            Q7.SetVisibility();
            Q8.SetVisibility();
            Q9.SetVisibility();
            Q10.SetVisibility();
            Q11.SetVisibility();
            Q12.SetVisibility();
            Q13.SetVisibility();
            Q14.SetVisibility();
            Q15.SetVisibility();
            Section_3.SetVisibility();
            Q16.SetVisibility();
            Q17.SetVisibility();
            Q18.SetVisibility();
            Q19.SetVisibility();
            Q20.SetVisibility();
            Q21.SetVisibility();
            Section_4.SetVisibility();
            Q22.SetVisibility();
            Q23.SetVisibility();
            Q24.SetVisibility();
            Q25.SetVisibility();
            Q26.SetVisibility();
            Section_5.SetVisibility();
            Q27.SetVisibility();
            Q28.SetVisibility();
            Q29.SetVisibility();
            Q30.SetVisibility();
            Q31.SetVisibility();
            Q32.SetVisibility();
            Q33.SetVisibility();
            Q34.SetVisibility();
            Q35.SetVisibility();
            Section_6.SetVisibility();
            Q36.SetVisibility();
            Q37.SetVisibility();
            Q38.SetVisibility();
            Q39.SetVisibility();
            Q40.SetVisibility();
            Q41.SetVisibility();
            Q42.SetVisibility();
            Q43.SetVisibility();
            Section_7.SetVisibility();
            Q44.SetVisibility();
            Q45.SetVisibility();
            Q46.SetVisibility();
            Q47.SetVisibility();
            Q48.SetVisibility();
            Q49.SetVisibility();
            Q50.SetVisibility();
            Section_8.SetVisibility();
            Q51.SetVisibility();
            Q52.SetVisibility();
            Q53.SetVisibility();
            Q54.SetVisibility();
            Q55.SetVisibility();
            Section_9.SetVisibility();
            Q56.SetVisibility();
            Q57.SetVisibility();
            Q58.SetVisibility();
            Q59.SetVisibility();
            Section_10.SetVisibility();
            Q60.SetVisibility();
            Q61.SetVisibility();
            Q62.SetVisibility();
            Q63.SetVisibility();
            Q64.SetVisibility();
            Q65.SetVisibility();
            Section_11.SetVisibility();
            Q66.SetVisibility();
            Q67.SetVisibility();
            Q68.SetVisibility();
            Q69.SetVisibility();
            Q70.SetVisibility();
            Notes_3.SetVisibility();
            Examiner_Signature.SetVisibility();
            Student_Signature.SetVisibility();
            AbsherApptNbr.SetVisibility();
            IsDrivingexperience.SetVisibility();
            date_Birth_Hijri.SetVisibility();
            date_Birth.SetVisibility();
            str_Email.SetVisibility();
            UserlevelID.SetVisibility();
            DriveTypelink.SetVisibility();
            intEvaluationType.SetVisibility();
            Institution.SetVisibility();
            Scores_S1.SetVisibility();
            S1.SetVisibility();
            S2.SetVisibility();
            S3.SetVisibility();
            S4.SetVisibility();
            S5.SetVisibility();
            Scores_S2.SetVisibility();
            S6.SetVisibility();
            S7.SetVisibility();
            S8.SetVisibility();
            S9.SetVisibility();
            S10.SetVisibility();
            S11.SetVisibility();
            S12.SetVisibility();
            S13.SetVisibility();
            S14.SetVisibility();
            S15.SetVisibility();
            Scores_S3.SetVisibility();
            S16.SetVisibility();
            S17.SetVisibility();
            S18.SetVisibility();
            S19.SetVisibility();
            S20.SetVisibility();
            S21.SetVisibility();
            Scores_S4.SetVisibility();
            S22.SetVisibility();
            S23.SetVisibility();
            S24.SetVisibility();
            S25.SetVisibility();
            S26.SetVisibility();
            Scores_S5.SetVisibility();
            S27.SetVisibility();
            S28.SetVisibility();
            S29.SetVisibility();
            S30.SetVisibility();
            S31.SetVisibility();
            S32.SetVisibility();
            S33.SetVisibility();
            S34.SetVisibility();
            S35.SetVisibility();
            Scores_S6.SetVisibility();
            S36.SetVisibility();
            S37.SetVisibility();
            S38.SetVisibility();
            S39.SetVisibility();
            S40.SetVisibility();
            S41.SetVisibility();
            S42.SetVisibility();
            S43.SetVisibility();
            Scores_S7.SetVisibility();
            S44.SetVisibility();
            S45.SetVisibility();
            S46.SetVisibility();
            S47.SetVisibility();
            S48.SetVisibility();
            S49.SetVisibility();
            S50.SetVisibility();
            Scores_S8.SetVisibility();
            S51.SetVisibility();
            S52.SetVisibility();
            S53.SetVisibility();
            S54.SetVisibility();
            S55.SetVisibility();
            Scores_S9.SetVisibility();
            S56.SetVisibility();
            S57.SetVisibility();
            S58.SetVisibility();
            S59.SetVisibility();
            Scores_S10.SetVisibility();
            S60.SetVisibility();
            S61.SetVisibility();
            S62.SetVisibility();
            S63.SetVisibility();
            S64.SetVisibility();
            S65.SetVisibility();
            Scores_S11.SetVisibility();
            S66.SetVisibility();
            S67.SetVisibility();
            S68.SetVisibility();
            S69.SetVisibility();
            S70.SetVisibility();
            Evaluation_Score.SetVisibility();
            Immediate_Failure_Score.SetVisibility();
            Required_Program.SetVisibility();
            Price.SetVisibility();
        }

        // Constructor
        public TblEvaluationMbSearchBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblEvaluationMbView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("Eval_ID") ? dict["Eval_ID"] : Eval_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                Eval_ID.Visible = false;
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
                    srchStr = "TblEvaluationMbList?" + srchStr;
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
                tblEvaluationMbSearch?.PageRender();
            }
            return PageResult();
        }

        // Build advanced search
        protected string BuildAdvancedSearch() {
            string srchUrl = "";
            BuildSearchUrl(ref srchUrl, Eval_ID); // Eval_ID
            BuildSearchUrl(ref srchUrl, int_Student_ID); // int_Student_ID
            BuildSearchUrl(ref srchUrl, AssessmentID); // AssessmentID
            BuildSearchUrl(ref srchUrl, str_Full_Name_Hdr); // str_Full_Name_Hdr
            BuildSearchUrl(ref srchUrl, NationalID); // NationalID
            BuildSearchUrl(ref srchUrl, str_Cell_Phone); // str_Cell_Phone
            BuildSearchUrl(ref srchUrl, str_Username); // str_Username
            BuildSearchUrl(ref srchUrl, intDrivinglicenseType); // intDrivinglicenseType
            BuildSearchUrl(ref srchUrl, Date_Entered); // Date_Entered
            BuildSearchUrl(ref srchUrl, Examination_Number); // Examination_Number
            BuildSearchUrl(ref srchUrl, Retake, true); // Retake
            BuildSearchUrl(ref srchUrl, Section_1); // Section_1
            BuildSearchUrl(ref srchUrl, Q1, true); // Q1
            BuildSearchUrl(ref srchUrl, Q2, true); // Q2
            BuildSearchUrl(ref srchUrl, Q3, true); // Q3
            BuildSearchUrl(ref srchUrl, Q4, true); // Q4
            BuildSearchUrl(ref srchUrl, Q5, true); // Q5
            BuildSearchUrl(ref srchUrl, Section_2); // Section_2
            BuildSearchUrl(ref srchUrl, Q6, true); // Q6
            BuildSearchUrl(ref srchUrl, Q7, true); // Q7
            BuildSearchUrl(ref srchUrl, Q8, true); // Q8
            BuildSearchUrl(ref srchUrl, Q9, true); // Q9
            BuildSearchUrl(ref srchUrl, Q10, true); // Q10
            BuildSearchUrl(ref srchUrl, Q11, true); // Q11
            BuildSearchUrl(ref srchUrl, Q12, true); // Q12
            BuildSearchUrl(ref srchUrl, Q13, true); // Q13
            BuildSearchUrl(ref srchUrl, Q14, true); // Q14
            BuildSearchUrl(ref srchUrl, Q15, true); // Q15
            BuildSearchUrl(ref srchUrl, Section_3); // Section_3
            BuildSearchUrl(ref srchUrl, Q16, true); // Q16
            BuildSearchUrl(ref srchUrl, Q17, true); // Q17
            BuildSearchUrl(ref srchUrl, Q18, true); // Q18
            BuildSearchUrl(ref srchUrl, Q19, true); // Q19
            BuildSearchUrl(ref srchUrl, Q20, true); // Q20
            BuildSearchUrl(ref srchUrl, Q21, true); // Q21
            BuildSearchUrl(ref srchUrl, Section_4); // Section_4
            BuildSearchUrl(ref srchUrl, Q22, true); // Q22
            BuildSearchUrl(ref srchUrl, Q23, true); // Q23
            BuildSearchUrl(ref srchUrl, Q24, true); // Q24
            BuildSearchUrl(ref srchUrl, Q25, true); // Q25
            BuildSearchUrl(ref srchUrl, Q26, true); // Q26
            BuildSearchUrl(ref srchUrl, Section_5); // Section_5
            BuildSearchUrl(ref srchUrl, Q27, true); // Q27
            BuildSearchUrl(ref srchUrl, Q28, true); // Q28
            BuildSearchUrl(ref srchUrl, Q29, true); // Q29
            BuildSearchUrl(ref srchUrl, Q30, true); // Q30
            BuildSearchUrl(ref srchUrl, Q31, true); // Q31
            BuildSearchUrl(ref srchUrl, Q32, true); // Q32
            BuildSearchUrl(ref srchUrl, Q33, true); // Q33
            BuildSearchUrl(ref srchUrl, Q34, true); // Q34
            BuildSearchUrl(ref srchUrl, Q35, true); // Q35
            BuildSearchUrl(ref srchUrl, Section_6); // Section_6
            BuildSearchUrl(ref srchUrl, Q36, true); // Q36
            BuildSearchUrl(ref srchUrl, Q37, true); // Q37
            BuildSearchUrl(ref srchUrl, Q38, true); // Q38
            BuildSearchUrl(ref srchUrl, Q39, true); // Q39
            BuildSearchUrl(ref srchUrl, Q40, true); // Q40
            BuildSearchUrl(ref srchUrl, Q41, true); // Q41
            BuildSearchUrl(ref srchUrl, Q42, true); // Q42
            BuildSearchUrl(ref srchUrl, Q43, true); // Q43
            BuildSearchUrl(ref srchUrl, Section_7); // Section_7
            BuildSearchUrl(ref srchUrl, Q44, true); // Q44
            BuildSearchUrl(ref srchUrl, Q45, true); // Q45
            BuildSearchUrl(ref srchUrl, Q46, true); // Q46
            BuildSearchUrl(ref srchUrl, Q47, true); // Q47
            BuildSearchUrl(ref srchUrl, Q48, true); // Q48
            BuildSearchUrl(ref srchUrl, Q49, true); // Q49
            BuildSearchUrl(ref srchUrl, Q50, true); // Q50
            BuildSearchUrl(ref srchUrl, Section_8); // Section_8
            BuildSearchUrl(ref srchUrl, Q51, true); // Q51
            BuildSearchUrl(ref srchUrl, Q52, true); // Q52
            BuildSearchUrl(ref srchUrl, Q53, true); // Q53
            BuildSearchUrl(ref srchUrl, Q54, true); // Q54
            BuildSearchUrl(ref srchUrl, Q55, true); // Q55
            BuildSearchUrl(ref srchUrl, Section_9); // Section_9
            BuildSearchUrl(ref srchUrl, Q56, true); // Q56
            BuildSearchUrl(ref srchUrl, Q57, true); // Q57
            BuildSearchUrl(ref srchUrl, Q58, true); // Q58
            BuildSearchUrl(ref srchUrl, Q59, true); // Q59
            BuildSearchUrl(ref srchUrl, Section_10); // Section_10
            BuildSearchUrl(ref srchUrl, Q60, true); // Q60
            BuildSearchUrl(ref srchUrl, Q61, true); // Q61
            BuildSearchUrl(ref srchUrl, Q62, true); // Q62
            BuildSearchUrl(ref srchUrl, Q63, true); // Q63
            BuildSearchUrl(ref srchUrl, Q64, true); // Q64
            BuildSearchUrl(ref srchUrl, Q65, true); // Q65
            BuildSearchUrl(ref srchUrl, Section_11); // Section_11
            BuildSearchUrl(ref srchUrl, Q66, true); // Q66
            BuildSearchUrl(ref srchUrl, Q67, true); // Q67
            BuildSearchUrl(ref srchUrl, Q68, true); // Q68
            BuildSearchUrl(ref srchUrl, Q69, true); // Q69
            BuildSearchUrl(ref srchUrl, Q70, true); // Q70
            BuildSearchUrl(ref srchUrl, Notes_3); // Notes_3
            BuildSearchUrl(ref srchUrl, Examiner_Signature); // Examiner_Signature
            BuildSearchUrl(ref srchUrl, Student_Signature); // Student_Signature
            BuildSearchUrl(ref srchUrl, AbsherApptNbr); // AbsherApptNbr
            BuildSearchUrl(ref srchUrl, IsDrivingexperience, true); // IsDrivingexperience
            BuildSearchUrl(ref srchUrl, date_Birth_Hijri); // date_Birth_Hijri
            BuildSearchUrl(ref srchUrl, date_Birth); // date_Birth
            BuildSearchUrl(ref srchUrl, str_Email); // str_Email
            BuildSearchUrl(ref srchUrl, UserlevelID); // UserlevelID
            BuildSearchUrl(ref srchUrl, DriveTypelink); // DriveTypelink
            BuildSearchUrl(ref srchUrl, intEvaluationType); // intEvaluationType
            BuildSearchUrl(ref srchUrl, Institution); // Institution
            BuildSearchUrl(ref srchUrl, Scores_S1); // Scores_S1
            BuildSearchUrl(ref srchUrl, S1, true); // S1
            BuildSearchUrl(ref srchUrl, S2, true); // S2
            BuildSearchUrl(ref srchUrl, S3, true); // S3
            BuildSearchUrl(ref srchUrl, S4, true); // S4
            BuildSearchUrl(ref srchUrl, S5, true); // S5
            BuildSearchUrl(ref srchUrl, Scores_S2); // Scores_S2
            BuildSearchUrl(ref srchUrl, S6, true); // S6
            BuildSearchUrl(ref srchUrl, S7, true); // S7
            BuildSearchUrl(ref srchUrl, S8, true); // S8
            BuildSearchUrl(ref srchUrl, S9, true); // S9
            BuildSearchUrl(ref srchUrl, S10, true); // S10
            BuildSearchUrl(ref srchUrl, S11, true); // S11
            BuildSearchUrl(ref srchUrl, S12, true); // S12
            BuildSearchUrl(ref srchUrl, S13, true); // S13
            BuildSearchUrl(ref srchUrl, S14, true); // S14
            BuildSearchUrl(ref srchUrl, S15, true); // S15
            BuildSearchUrl(ref srchUrl, Scores_S3); // Scores_S3
            BuildSearchUrl(ref srchUrl, S16, true); // S16
            BuildSearchUrl(ref srchUrl, S17, true); // S17
            BuildSearchUrl(ref srchUrl, S18, true); // S18
            BuildSearchUrl(ref srchUrl, S19, true); // S19
            BuildSearchUrl(ref srchUrl, S20, true); // S20
            BuildSearchUrl(ref srchUrl, S21, true); // S21
            BuildSearchUrl(ref srchUrl, Scores_S4); // Scores_S4
            BuildSearchUrl(ref srchUrl, S22, true); // S22
            BuildSearchUrl(ref srchUrl, S23, true); // S23
            BuildSearchUrl(ref srchUrl, S24, true); // S24
            BuildSearchUrl(ref srchUrl, S25, true); // S25
            BuildSearchUrl(ref srchUrl, S26, true); // S26
            BuildSearchUrl(ref srchUrl, Scores_S5); // Scores_S5
            BuildSearchUrl(ref srchUrl, S27, true); // S27
            BuildSearchUrl(ref srchUrl, S28, true); // S28
            BuildSearchUrl(ref srchUrl, S29, true); // S29
            BuildSearchUrl(ref srchUrl, S30, true); // S30
            BuildSearchUrl(ref srchUrl, S31, true); // S31
            BuildSearchUrl(ref srchUrl, S32, true); // S32
            BuildSearchUrl(ref srchUrl, S33, true); // S33
            BuildSearchUrl(ref srchUrl, S34, true); // S34
            BuildSearchUrl(ref srchUrl, S35, true); // S35
            BuildSearchUrl(ref srchUrl, Scores_S6); // Scores_S6
            BuildSearchUrl(ref srchUrl, S36, true); // S36
            BuildSearchUrl(ref srchUrl, S37, true); // S37
            BuildSearchUrl(ref srchUrl, S38, true); // S38
            BuildSearchUrl(ref srchUrl, S39, true); // S39
            BuildSearchUrl(ref srchUrl, S40, true); // S40
            BuildSearchUrl(ref srchUrl, S41, true); // S41
            BuildSearchUrl(ref srchUrl, S42, true); // S42
            BuildSearchUrl(ref srchUrl, S43, true); // S43
            BuildSearchUrl(ref srchUrl, Scores_S7); // Scores_S7
            BuildSearchUrl(ref srchUrl, S44, true); // S44
            BuildSearchUrl(ref srchUrl, S45, true); // S45
            BuildSearchUrl(ref srchUrl, S46, true); // S46
            BuildSearchUrl(ref srchUrl, S47, true); // S47
            BuildSearchUrl(ref srchUrl, S48, true); // S48
            BuildSearchUrl(ref srchUrl, S49, true); // S49
            BuildSearchUrl(ref srchUrl, S50, true); // S50
            BuildSearchUrl(ref srchUrl, Scores_S8); // Scores_S8
            BuildSearchUrl(ref srchUrl, S51, true); // S51
            BuildSearchUrl(ref srchUrl, S52, true); // S52
            BuildSearchUrl(ref srchUrl, S53, true); // S53
            BuildSearchUrl(ref srchUrl, S54, true); // S54
            BuildSearchUrl(ref srchUrl, S55, true); // S55
            BuildSearchUrl(ref srchUrl, Scores_S9); // Scores_S9
            BuildSearchUrl(ref srchUrl, S56, true); // S56
            BuildSearchUrl(ref srchUrl, S57, true); // S57
            BuildSearchUrl(ref srchUrl, S58, true); // S58
            BuildSearchUrl(ref srchUrl, S59, true); // S59
            BuildSearchUrl(ref srchUrl, Scores_S10); // Scores_S10
            BuildSearchUrl(ref srchUrl, S60, true); // S60
            BuildSearchUrl(ref srchUrl, S61, true); // S61
            BuildSearchUrl(ref srchUrl, S62, true); // S62
            BuildSearchUrl(ref srchUrl, S63, true); // S63
            BuildSearchUrl(ref srchUrl, S64, true); // S64
            BuildSearchUrl(ref srchUrl, S65, true); // S65
            BuildSearchUrl(ref srchUrl, Scores_S11); // Scores_S11
            BuildSearchUrl(ref srchUrl, S66, true); // S66
            BuildSearchUrl(ref srchUrl, S67, true); // S67
            BuildSearchUrl(ref srchUrl, S68, true); // S68
            BuildSearchUrl(ref srchUrl, S69, true); // S69
            BuildSearchUrl(ref srchUrl, S70, true); // S70
            BuildSearchUrl(ref srchUrl, Evaluation_Score); // Evaluation_Score
            BuildSearchUrl(ref srchUrl, Immediate_Failure_Score); // Immediate_Failure_Score
            BuildSearchUrl(ref srchUrl, Required_Program); // Required_Program
            BuildSearchUrl(ref srchUrl, Price); // Price
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
            // Eval_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Eval_ID"))
                    Eval_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Eval_ID");
            if (Form.ContainsKey("z_Eval_ID"))
                Eval_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Eval_ID");

            // int_Student_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Student_ID"))
                    int_Student_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Student_ID");
            if (Form.ContainsKey("z_int_Student_ID"))
                int_Student_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Student_ID");

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

            // NationalID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_NationalID"))
                    NationalID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_NationalID");
            if (Form.ContainsKey("z_NationalID"))
                NationalID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_NationalID");

            // str_Cell_Phone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Cell_Phone"))
                    str_Cell_Phone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Cell_Phone");
            if (Form.ContainsKey("z_str_Cell_Phone"))
                str_Cell_Phone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Cell_Phone");

            // str_Username
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Username"))
                    str_Username.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Username");
            if (Form.ContainsKey("z_str_Username"))
                str_Username.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Username");

            // intDrivinglicenseType
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_intDrivinglicenseType"))
                    intDrivinglicenseType.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_intDrivinglicenseType");
            if (Form.ContainsKey("z_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_intDrivinglicenseType");

            // Date_Entered
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Date_Entered"))
                    Date_Entered.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Date_Entered");
            if (Form.ContainsKey("z_Date_Entered"))
                Date_Entered.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Date_Entered");

            // Examination_Number
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Examination_Number"))
                    Examination_Number.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Examination_Number");
            if (Form.ContainsKey("z_Examination_Number"))
                Examination_Number.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Examination_Number");

            // Retake
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Retake"))
                    Retake.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Retake");
            if (Form.ContainsKey("z_Retake"))
                Retake.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Retake");

            // Section_1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_1"))
                    Section_1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_1");
            if (Form.ContainsKey("z_Section_1"))
                Section_1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_1");

            // Q1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q1"))
                    Q1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q1");
            if (Form.ContainsKey("z_Q1"))
                Q1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q1");

            // Q2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q2"))
                    Q2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q2");
            if (Form.ContainsKey("z_Q2"))
                Q2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q2");

            // Q3
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q3"))
                    Q3.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q3");
            if (Form.ContainsKey("z_Q3"))
                Q3.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q3");

            // Q4
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q4"))
                    Q4.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q4");
            if (Form.ContainsKey("z_Q4"))
                Q4.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q4");

            // Q5
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q5"))
                    Q5.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q5");
            if (Form.ContainsKey("z_Q5"))
                Q5.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q5");

            // Section_2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_2"))
                    Section_2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_2");
            if (Form.ContainsKey("z_Section_2"))
                Section_2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_2");

            // Q6
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q6"))
                    Q6.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q6");
            if (Form.ContainsKey("z_Q6"))
                Q6.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q6");

            // Q7
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q7"))
                    Q7.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q7");
            if (Form.ContainsKey("z_Q7"))
                Q7.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q7");

            // Q8
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q8"))
                    Q8.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q8");
            if (Form.ContainsKey("z_Q8"))
                Q8.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q8");

            // Q9
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q9"))
                    Q9.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q9");
            if (Form.ContainsKey("z_Q9"))
                Q9.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q9");

            // Q10
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q10"))
                    Q10.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q10");
            if (Form.ContainsKey("z_Q10"))
                Q10.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q10");

            // Q11
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q11"))
                    Q11.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q11");
            if (Form.ContainsKey("z_Q11"))
                Q11.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q11");

            // Q12
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q12"))
                    Q12.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q12");
            if (Form.ContainsKey("z_Q12"))
                Q12.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q12");

            // Q13
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q13"))
                    Q13.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q13");
            if (Form.ContainsKey("z_Q13"))
                Q13.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q13");

            // Q14
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q14"))
                    Q14.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q14");
            if (Form.ContainsKey("z_Q14"))
                Q14.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q14");

            // Q15
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q15"))
                    Q15.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q15");
            if (Form.ContainsKey("z_Q15"))
                Q15.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q15");

            // Section_3
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_3"))
                    Section_3.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_3");
            if (Form.ContainsKey("z_Section_3"))
                Section_3.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_3");

            // Q16
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q16"))
                    Q16.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q16");
            if (Form.ContainsKey("z_Q16"))
                Q16.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q16");

            // Q17
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q17"))
                    Q17.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q17");
            if (Form.ContainsKey("z_Q17"))
                Q17.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q17");

            // Q18
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q18"))
                    Q18.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q18");
            if (Form.ContainsKey("z_Q18"))
                Q18.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q18");

            // Q19
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q19"))
                    Q19.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q19");
            if (Form.ContainsKey("z_Q19"))
                Q19.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q19");

            // Q20
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q20"))
                    Q20.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q20");
            if (Form.ContainsKey("z_Q20"))
                Q20.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q20");

            // Q21
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q21"))
                    Q21.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q21");
            if (Form.ContainsKey("z_Q21"))
                Q21.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q21");

            // Section_4
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_4"))
                    Section_4.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_4");
            if (Form.ContainsKey("z_Section_4"))
                Section_4.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_4");

            // Q22
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q22"))
                    Q22.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q22");
            if (Form.ContainsKey("z_Q22"))
                Q22.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q22");

            // Q23
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q23"))
                    Q23.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q23");
            if (Form.ContainsKey("z_Q23"))
                Q23.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q23");

            // Q24
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q24"))
                    Q24.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q24");
            if (Form.ContainsKey("z_Q24"))
                Q24.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q24");

            // Q25
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q25"))
                    Q25.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q25");
            if (Form.ContainsKey("z_Q25"))
                Q25.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q25");

            // Q26
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q26"))
                    Q26.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q26");
            if (Form.ContainsKey("z_Q26"))
                Q26.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q26");

            // Section_5
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_5"))
                    Section_5.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_5");
            if (Form.ContainsKey("z_Section_5"))
                Section_5.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_5");

            // Q27
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q27"))
                    Q27.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q27");
            if (Form.ContainsKey("z_Q27"))
                Q27.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q27");

            // Q28
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q28"))
                    Q28.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q28");
            if (Form.ContainsKey("z_Q28"))
                Q28.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q28");

            // Q29
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q29"))
                    Q29.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q29");
            if (Form.ContainsKey("z_Q29"))
                Q29.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q29");

            // Q30
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q30"))
                    Q30.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q30");
            if (Form.ContainsKey("z_Q30"))
                Q30.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q30");

            // Q31
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q31"))
                    Q31.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q31");
            if (Form.ContainsKey("z_Q31"))
                Q31.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q31");

            // Q32
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q32"))
                    Q32.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q32");
            if (Form.ContainsKey("z_Q32"))
                Q32.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q32");

            // Q33
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q33"))
                    Q33.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q33");
            if (Form.ContainsKey("z_Q33"))
                Q33.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q33");

            // Q34
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q34"))
                    Q34.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q34");
            if (Form.ContainsKey("z_Q34"))
                Q34.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q34");

            // Q35
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q35"))
                    Q35.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q35");
            if (Form.ContainsKey("z_Q35"))
                Q35.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q35");

            // Section_6
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_6"))
                    Section_6.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_6");
            if (Form.ContainsKey("z_Section_6"))
                Section_6.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_6");

            // Q36
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q36"))
                    Q36.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q36");
            if (Form.ContainsKey("z_Q36"))
                Q36.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q36");

            // Q37
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q37"))
                    Q37.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q37");
            if (Form.ContainsKey("z_Q37"))
                Q37.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q37");

            // Q38
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q38"))
                    Q38.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q38");
            if (Form.ContainsKey("z_Q38"))
                Q38.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q38");

            // Q39
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q39"))
                    Q39.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q39");
            if (Form.ContainsKey("z_Q39"))
                Q39.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q39");

            // Q40
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q40"))
                    Q40.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q40");
            if (Form.ContainsKey("z_Q40"))
                Q40.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q40");

            // Q41
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q41"))
                    Q41.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q41");
            if (Form.ContainsKey("z_Q41"))
                Q41.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q41");

            // Q42
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q42"))
                    Q42.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q42");
            if (Form.ContainsKey("z_Q42"))
                Q42.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q42");

            // Q43
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q43"))
                    Q43.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q43");
            if (Form.ContainsKey("z_Q43"))
                Q43.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q43");

            // Section_7
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_7"))
                    Section_7.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_7");
            if (Form.ContainsKey("z_Section_7"))
                Section_7.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_7");

            // Q44
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q44"))
                    Q44.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q44");
            if (Form.ContainsKey("z_Q44"))
                Q44.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q44");

            // Q45
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q45"))
                    Q45.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q45");
            if (Form.ContainsKey("z_Q45"))
                Q45.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q45");

            // Q46
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q46"))
                    Q46.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q46");
            if (Form.ContainsKey("z_Q46"))
                Q46.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q46");

            // Q47
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q47"))
                    Q47.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q47");
            if (Form.ContainsKey("z_Q47"))
                Q47.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q47");

            // Q48
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q48"))
                    Q48.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q48");
            if (Form.ContainsKey("z_Q48"))
                Q48.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q48");

            // Q49
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q49"))
                    Q49.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q49");
            if (Form.ContainsKey("z_Q49"))
                Q49.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q49");

            // Q50
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q50"))
                    Q50.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q50");
            if (Form.ContainsKey("z_Q50"))
                Q50.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q50");

            // Section_8
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_8"))
                    Section_8.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_8");
            if (Form.ContainsKey("z_Section_8"))
                Section_8.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_8");

            // Q51
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q51"))
                    Q51.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q51");
            if (Form.ContainsKey("z_Q51"))
                Q51.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q51");

            // Q52
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q52"))
                    Q52.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q52");
            if (Form.ContainsKey("z_Q52"))
                Q52.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q52");

            // Q53
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q53"))
                    Q53.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q53");
            if (Form.ContainsKey("z_Q53"))
                Q53.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q53");

            // Q54
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q54"))
                    Q54.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q54");
            if (Form.ContainsKey("z_Q54"))
                Q54.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q54");

            // Q55
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q55"))
                    Q55.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q55");
            if (Form.ContainsKey("z_Q55"))
                Q55.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q55");

            // Section_9
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_9"))
                    Section_9.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_9");
            if (Form.ContainsKey("z_Section_9"))
                Section_9.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_9");

            // Q56
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q56"))
                    Q56.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q56");
            if (Form.ContainsKey("z_Q56"))
                Q56.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q56");

            // Q57
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q57"))
                    Q57.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q57");
            if (Form.ContainsKey("z_Q57"))
                Q57.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q57");

            // Q58
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q58"))
                    Q58.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q58");
            if (Form.ContainsKey("z_Q58"))
                Q58.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q58");

            // Q59
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q59"))
                    Q59.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q59");
            if (Form.ContainsKey("z_Q59"))
                Q59.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q59");

            // Section_10
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_10"))
                    Section_10.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_10");
            if (Form.ContainsKey("z_Section_10"))
                Section_10.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_10");

            // Q60
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q60"))
                    Q60.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q60");
            if (Form.ContainsKey("z_Q60"))
                Q60.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q60");

            // Q61
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q61"))
                    Q61.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q61");
            if (Form.ContainsKey("z_Q61"))
                Q61.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q61");

            // Q62
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q62"))
                    Q62.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q62");
            if (Form.ContainsKey("z_Q62"))
                Q62.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q62");

            // Q63
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q63"))
                    Q63.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q63");
            if (Form.ContainsKey("z_Q63"))
                Q63.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q63");

            // Q64
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q64"))
                    Q64.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q64");
            if (Form.ContainsKey("z_Q64"))
                Q64.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q64");

            // Q65
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q65"))
                    Q65.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q65");
            if (Form.ContainsKey("z_Q65"))
                Q65.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q65");

            // Section_11
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Section_11"))
                    Section_11.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Section_11");
            if (Form.ContainsKey("z_Section_11"))
                Section_11.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Section_11");

            // Q66
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q66"))
                    Q66.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q66");
            if (Form.ContainsKey("z_Q66"))
                Q66.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q66");

            // Q67
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q67"))
                    Q67.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q67");
            if (Form.ContainsKey("z_Q67"))
                Q67.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q67");

            // Q68
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q68"))
                    Q68.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q68");
            if (Form.ContainsKey("z_Q68"))
                Q68.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q68");

            // Q69
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q69"))
                    Q69.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q69");
            if (Form.ContainsKey("z_Q69"))
                Q69.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q69");

            // Q70
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Q70"))
                    Q70.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Q70");
            if (Form.ContainsKey("z_Q70"))
                Q70.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Q70");

            // Notes_3
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Notes_3"))
                    Notes_3.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Notes_3");
            if (Form.ContainsKey("z_Notes_3"))
                Notes_3.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Notes_3");

            // Examiner_Signature
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Examiner_Signature"))
                    Examiner_Signature.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Examiner_Signature");
            if (Form.ContainsKey("z_Examiner_Signature"))
                Examiner_Signature.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Examiner_Signature");

            // Student_Signature
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Student_Signature"))
                    Student_Signature.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Student_Signature");
            if (Form.ContainsKey("z_Student_Signature"))
                Student_Signature.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Student_Signature");

            // AbsherApptNbr
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AbsherApptNbr"))
                    AbsherApptNbr.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AbsherApptNbr");
            if (Form.ContainsKey("z_AbsherApptNbr"))
                AbsherApptNbr.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AbsherApptNbr");

            // IsDrivingexperience
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_IsDrivingexperience"))
                    IsDrivingexperience.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_IsDrivingexperience");
            if (Form.ContainsKey("z_IsDrivingexperience"))
                IsDrivingexperience.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_IsDrivingexperience");

            // date_Birth_Hijri
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Birth_Hijri"))
                    date_Birth_Hijri.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Birth_Hijri");
            if (Form.ContainsKey("z_date_Birth_Hijri"))
                date_Birth_Hijri.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Birth_Hijri");

            // date_Birth
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Birth"))
                    date_Birth.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Birth");
            if (Form.ContainsKey("z_date_Birth"))
                date_Birth.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Birth");

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

            // intEvaluationType
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_intEvaluationType"))
                    intEvaluationType.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_intEvaluationType");
            if (Form.ContainsKey("z_intEvaluationType"))
                intEvaluationType.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_intEvaluationType");

            // Institution
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Institution"))
                    Institution.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Institution");
            if (Form.ContainsKey("z_Institution"))
                Institution.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Institution");

            // Scores_S1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S1"))
                    Scores_S1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S1");
            if (Form.ContainsKey("z_Scores_S1"))
                Scores_S1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S1");

            // S1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S1"))
                    S1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S1");
            if (Form.ContainsKey("z_S1"))
                S1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S1");

            // S2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S2"))
                    S2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S2");
            if (Form.ContainsKey("z_S2"))
                S2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S2");

            // S3
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S3"))
                    S3.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S3");
            if (Form.ContainsKey("z_S3"))
                S3.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S3");

            // S4
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S4"))
                    S4.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S4");
            if (Form.ContainsKey("z_S4"))
                S4.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S4");

            // S5
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S5"))
                    S5.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S5");
            if (Form.ContainsKey("z_S5"))
                S5.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S5");

            // Scores_S2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S2"))
                    Scores_S2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S2");
            if (Form.ContainsKey("z_Scores_S2"))
                Scores_S2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S2");

            // S6
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S6"))
                    S6.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S6");
            if (Form.ContainsKey("z_S6"))
                S6.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S6");

            // S7
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S7"))
                    S7.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S7");
            if (Form.ContainsKey("z_S7"))
                S7.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S7");

            // S8
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S8"))
                    S8.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S8");
            if (Form.ContainsKey("z_S8"))
                S8.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S8");

            // S9
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S9"))
                    S9.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S9");
            if (Form.ContainsKey("z_S9"))
                S9.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S9");

            // S10
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S10"))
                    S10.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S10");
            if (Form.ContainsKey("z_S10"))
                S10.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S10");

            // S11
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S11"))
                    S11.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S11");
            if (Form.ContainsKey("z_S11"))
                S11.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S11");

            // S12
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S12"))
                    S12.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S12");
            if (Form.ContainsKey("z_S12"))
                S12.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S12");

            // S13
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S13"))
                    S13.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S13");
            if (Form.ContainsKey("z_S13"))
                S13.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S13");

            // S14
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S14"))
                    S14.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S14");
            if (Form.ContainsKey("z_S14"))
                S14.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S14");

            // S15
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S15"))
                    S15.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S15");
            if (Form.ContainsKey("z_S15"))
                S15.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S15");

            // Scores_S3
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S3"))
                    Scores_S3.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S3");
            if (Form.ContainsKey("z_Scores_S3"))
                Scores_S3.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S3");

            // S16
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S16"))
                    S16.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S16");
            if (Form.ContainsKey("z_S16"))
                S16.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S16");

            // S17
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S17"))
                    S17.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S17");
            if (Form.ContainsKey("z_S17"))
                S17.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S17");

            // S18
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S18"))
                    S18.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S18");
            if (Form.ContainsKey("z_S18"))
                S18.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S18");

            // S19
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S19"))
                    S19.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S19");
            if (Form.ContainsKey("z_S19"))
                S19.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S19");

            // S20
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S20"))
                    S20.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S20");
            if (Form.ContainsKey("z_S20"))
                S20.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S20");

            // S21
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S21"))
                    S21.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S21");
            if (Form.ContainsKey("z_S21"))
                S21.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S21");

            // Scores_S4
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S4"))
                    Scores_S4.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S4");
            if (Form.ContainsKey("z_Scores_S4"))
                Scores_S4.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S4");

            // S22
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S22"))
                    S22.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S22");
            if (Form.ContainsKey("z_S22"))
                S22.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S22");

            // S23
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S23"))
                    S23.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S23");
            if (Form.ContainsKey("z_S23"))
                S23.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S23");

            // S24
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S24"))
                    S24.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S24");
            if (Form.ContainsKey("z_S24"))
                S24.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S24");

            // S25
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S25"))
                    S25.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S25");
            if (Form.ContainsKey("z_S25"))
                S25.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S25");

            // S26
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S26"))
                    S26.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S26");
            if (Form.ContainsKey("z_S26"))
                S26.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S26");

            // Scores_S5
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S5"))
                    Scores_S5.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S5");
            if (Form.ContainsKey("z_Scores_S5"))
                Scores_S5.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S5");

            // S27
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S27"))
                    S27.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S27");
            if (Form.ContainsKey("z_S27"))
                S27.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S27");

            // S28
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S28"))
                    S28.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S28");
            if (Form.ContainsKey("z_S28"))
                S28.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S28");

            // S29
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S29"))
                    S29.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S29");
            if (Form.ContainsKey("z_S29"))
                S29.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S29");

            // S30
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S30"))
                    S30.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S30");
            if (Form.ContainsKey("z_S30"))
                S30.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S30");

            // S31
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S31"))
                    S31.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S31");
            if (Form.ContainsKey("z_S31"))
                S31.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S31");

            // S32
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S32"))
                    S32.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S32");
            if (Form.ContainsKey("z_S32"))
                S32.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S32");

            // S33
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S33"))
                    S33.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S33");
            if (Form.ContainsKey("z_S33"))
                S33.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S33");

            // S34
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S34"))
                    S34.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S34");
            if (Form.ContainsKey("z_S34"))
                S34.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S34");

            // S35
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S35"))
                    S35.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S35");
            if (Form.ContainsKey("z_S35"))
                S35.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S35");

            // Scores_S6
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S6"))
                    Scores_S6.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S6");
            if (Form.ContainsKey("z_Scores_S6"))
                Scores_S6.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S6");

            // S36
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S36"))
                    S36.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S36");
            if (Form.ContainsKey("z_S36"))
                S36.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S36");

            // S37
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S37"))
                    S37.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S37");
            if (Form.ContainsKey("z_S37"))
                S37.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S37");

            // S38
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S38"))
                    S38.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S38");
            if (Form.ContainsKey("z_S38"))
                S38.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S38");

            // S39
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S39"))
                    S39.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S39");
            if (Form.ContainsKey("z_S39"))
                S39.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S39");

            // S40
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S40"))
                    S40.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S40");
            if (Form.ContainsKey("z_S40"))
                S40.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S40");

            // S41
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S41"))
                    S41.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S41");
            if (Form.ContainsKey("z_S41"))
                S41.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S41");

            // S42
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S42"))
                    S42.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S42");
            if (Form.ContainsKey("z_S42"))
                S42.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S42");

            // S43
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S43"))
                    S43.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S43");
            if (Form.ContainsKey("z_S43"))
                S43.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S43");

            // Scores_S7
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S7"))
                    Scores_S7.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S7");
            if (Form.ContainsKey("z_Scores_S7"))
                Scores_S7.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S7");

            // S44
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S44"))
                    S44.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S44");
            if (Form.ContainsKey("z_S44"))
                S44.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S44");

            // S45
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S45"))
                    S45.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S45");
            if (Form.ContainsKey("z_S45"))
                S45.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S45");

            // S46
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S46"))
                    S46.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S46");
            if (Form.ContainsKey("z_S46"))
                S46.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S46");

            // S47
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S47"))
                    S47.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S47");
            if (Form.ContainsKey("z_S47"))
                S47.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S47");

            // S48
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S48"))
                    S48.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S48");
            if (Form.ContainsKey("z_S48"))
                S48.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S48");

            // S49
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S49"))
                    S49.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S49");
            if (Form.ContainsKey("z_S49"))
                S49.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S49");

            // S50
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S50"))
                    S50.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S50");
            if (Form.ContainsKey("z_S50"))
                S50.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S50");

            // Scores_S8
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S8"))
                    Scores_S8.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S8");
            if (Form.ContainsKey("z_Scores_S8"))
                Scores_S8.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S8");

            // S51
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S51"))
                    S51.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S51");
            if (Form.ContainsKey("z_S51"))
                S51.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S51");

            // S52
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S52"))
                    S52.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S52");
            if (Form.ContainsKey("z_S52"))
                S52.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S52");

            // S53
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S53"))
                    S53.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S53");
            if (Form.ContainsKey("z_S53"))
                S53.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S53");

            // S54
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S54"))
                    S54.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S54");
            if (Form.ContainsKey("z_S54"))
                S54.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S54");

            // S55
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S55"))
                    S55.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S55");
            if (Form.ContainsKey("z_S55"))
                S55.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S55");

            // Scores_S9
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S9"))
                    Scores_S9.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S9");
            if (Form.ContainsKey("z_Scores_S9"))
                Scores_S9.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S9");

            // S56
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S56"))
                    S56.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S56");
            if (Form.ContainsKey("z_S56"))
                S56.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S56");

            // S57
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S57"))
                    S57.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S57");
            if (Form.ContainsKey("z_S57"))
                S57.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S57");

            // S58
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S58"))
                    S58.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S58");
            if (Form.ContainsKey("z_S58"))
                S58.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S58");

            // S59
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S59"))
                    S59.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S59");
            if (Form.ContainsKey("z_S59"))
                S59.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S59");

            // Scores_S10
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S10"))
                    Scores_S10.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S10");
            if (Form.ContainsKey("z_Scores_S10"))
                Scores_S10.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S10");

            // S60
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S60"))
                    S60.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S60");
            if (Form.ContainsKey("z_S60"))
                S60.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S60");

            // S61
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S61"))
                    S61.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S61");
            if (Form.ContainsKey("z_S61"))
                S61.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S61");

            // S62
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S62"))
                    S62.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S62");
            if (Form.ContainsKey("z_S62"))
                S62.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S62");

            // S63
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S63"))
                    S63.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S63");
            if (Form.ContainsKey("z_S63"))
                S63.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S63");

            // S64
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S64"))
                    S64.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S64");
            if (Form.ContainsKey("z_S64"))
                S64.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S64");

            // S65
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S65"))
                    S65.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S65");
            if (Form.ContainsKey("z_S65"))
                S65.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S65");

            // Scores_S11
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Scores_S11"))
                    Scores_S11.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Scores_S11");
            if (Form.ContainsKey("z_Scores_S11"))
                Scores_S11.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Scores_S11");

            // S66
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S66"))
                    S66.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S66");
            if (Form.ContainsKey("z_S66"))
                S66.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S66");

            // S67
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S67"))
                    S67.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S67");
            if (Form.ContainsKey("z_S67"))
                S67.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S67");

            // S68
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S68"))
                    S68.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S68");
            if (Form.ContainsKey("z_S68"))
                S68.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S68");

            // S69
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S69"))
                    S69.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S69");
            if (Form.ContainsKey("z_S69"))
                S69.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S69");

            // S70
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_S70"))
                    S70.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_S70");
            if (Form.ContainsKey("z_S70"))
                S70.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_S70");

            // Evaluation_Score
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Evaluation_Score"))
                    Evaluation_Score.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Evaluation_Score");
            if (Form.ContainsKey("z_Evaluation_Score"))
                Evaluation_Score.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Evaluation_Score");

            // Immediate_Failure_Score
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Immediate_Failure_Score"))
                    Immediate_Failure_Score.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Immediate_Failure_Score");
            if (Form.ContainsKey("z_Immediate_Failure_Score"))
                Immediate_Failure_Score.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Immediate_Failure_Score");

            // Required_Program
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Required_Program"))
                    Required_Program.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Required_Program");
            if (Form.ContainsKey("z_Required_Program"))
                Required_Program.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Required_Program");

            // Price
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Price"))
                    Price.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Price");
            if (Form.ContainsKey("z_Price"))
                Price.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Price");
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

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // Eval_ID
            Eval_ID.RowCssClass = "row";

            // int_Student_ID
            int_Student_ID.RowCssClass = "row";

            // AssessmentID
            AssessmentID.RowCssClass = "row";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // str_Cell_Phone
            str_Cell_Phone.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // intDrivinglicenseType
            intDrivinglicenseType.RowCssClass = "row";

            // Date_Entered
            Date_Entered.RowCssClass = "row";

            // Examination_Number
            Examination_Number.RowCssClass = "row";

            // Retake
            Retake.RowCssClass = "row";

            // Section_1
            Section_1.RowCssClass = "row";

            // Q1
            Q1.RowCssClass = "row";

            // Q2
            Q2.RowCssClass = "row";

            // Q3
            Q3.RowCssClass = "row";

            // Q4
            Q4.RowCssClass = "row";

            // Q5
            Q5.RowCssClass = "row";

            // Section_2
            Section_2.RowCssClass = "row";

            // Q6
            Q6.RowCssClass = "row";

            // Q7
            Q7.RowCssClass = "row";

            // Q8
            Q8.RowCssClass = "row";

            // Q9
            Q9.RowCssClass = "row";

            // Q10
            Q10.RowCssClass = "row";

            // Q11
            Q11.RowCssClass = "row";

            // Q12
            Q12.RowCssClass = "row";

            // Q13
            Q13.RowCssClass = "row";

            // Q14
            Q14.RowCssClass = "row";

            // Q15
            Q15.RowCssClass = "row";

            // Section_3
            Section_3.RowCssClass = "row";

            // Q16
            Q16.RowCssClass = "row";

            // Q17
            Q17.RowCssClass = "row";

            // Q18
            Q18.RowCssClass = "row";

            // Q19
            Q19.RowCssClass = "row";

            // Q20
            Q20.RowCssClass = "row";

            // Q21
            Q21.RowCssClass = "row";

            // Section_4
            Section_4.RowCssClass = "row";

            // Q22
            Q22.RowCssClass = "row";

            // Q23
            Q23.RowCssClass = "row";

            // Q24
            Q24.RowCssClass = "row";

            // Q25
            Q25.RowCssClass = "row";

            // Q26
            Q26.RowCssClass = "row";

            // Section_5
            Section_5.RowCssClass = "row";

            // Q27
            Q27.RowCssClass = "row";

            // Q28
            Q28.RowCssClass = "row";

            // Q29
            Q29.RowCssClass = "row";

            // Q30
            Q30.RowCssClass = "row";

            // Q31
            Q31.RowCssClass = "row";

            // Q32
            Q32.RowCssClass = "row";

            // Q33
            Q33.RowCssClass = "row";

            // Q34
            Q34.RowCssClass = "row";

            // Q35
            Q35.RowCssClass = "row";

            // Section_6
            Section_6.RowCssClass = "row";

            // Q36
            Q36.RowCssClass = "row";

            // Q37
            Q37.RowCssClass = "row";

            // Q38
            Q38.RowCssClass = "row";

            // Q39
            Q39.RowCssClass = "row";

            // Q40
            Q40.RowCssClass = "row";

            // Q41
            Q41.RowCssClass = "row";

            // Q42
            Q42.RowCssClass = "row";

            // Q43
            Q43.RowCssClass = "row";

            // Section_7
            Section_7.RowCssClass = "row";

            // Q44
            Q44.RowCssClass = "row";

            // Q45
            Q45.RowCssClass = "row";

            // Q46
            Q46.RowCssClass = "row";

            // Q47
            Q47.RowCssClass = "row";

            // Q48
            Q48.RowCssClass = "row";

            // Q49
            Q49.RowCssClass = "row";

            // Q50
            Q50.RowCssClass = "row";

            // Section_8
            Section_8.RowCssClass = "row";

            // Q51
            Q51.RowCssClass = "row";

            // Q52
            Q52.RowCssClass = "row";

            // Q53
            Q53.RowCssClass = "row";

            // Q54
            Q54.RowCssClass = "row";

            // Q55
            Q55.RowCssClass = "row";

            // Section_9
            Section_9.RowCssClass = "row";

            // Q56
            Q56.RowCssClass = "row";

            // Q57
            Q57.RowCssClass = "row";

            // Q58
            Q58.RowCssClass = "row";

            // Q59
            Q59.RowCssClass = "row";

            // Section_10
            Section_10.RowCssClass = "row";

            // Q60
            Q60.RowCssClass = "row";

            // Q61
            Q61.RowCssClass = "row";

            // Q62
            Q62.RowCssClass = "row";

            // Q63
            Q63.RowCssClass = "row";

            // Q64
            Q64.RowCssClass = "row";

            // Q65
            Q65.RowCssClass = "row";

            // Section_11
            Section_11.RowCssClass = "row";

            // Q66
            Q66.RowCssClass = "row";

            // Q67
            Q67.RowCssClass = "row";

            // Q68
            Q68.RowCssClass = "row";

            // Q69
            Q69.RowCssClass = "row";

            // Q70
            Q70.RowCssClass = "row";

            // Notes_3
            Notes_3.RowCssClass = "row";

            // Examiner_Signature
            Examiner_Signature.RowCssClass = "row";

            // Student_Signature
            Student_Signature.RowCssClass = "row";

            // AbsherApptNbr
            AbsherApptNbr.RowCssClass = "row";

            // IsDrivingexperience
            IsDrivingexperience.RowCssClass = "row";

            // date_Birth_Hijri
            date_Birth_Hijri.RowCssClass = "row";

            // date_Birth
            date_Birth.RowCssClass = "row";

            // str_Email
            str_Email.RowCssClass = "row";

            // UserlevelID
            UserlevelID.RowCssClass = "row";

            // DriveTypelink
            DriveTypelink.RowCssClass = "row";

            // intEvaluationType
            intEvaluationType.RowCssClass = "row";

            // Institution
            Institution.RowCssClass = "row";

            // Scores_S1
            Scores_S1.RowCssClass = "row";

            // S1
            S1.RowCssClass = "row";

            // S2
            S2.RowCssClass = "row";

            // S3
            S3.RowCssClass = "row";

            // S4
            S4.RowCssClass = "row";

            // S5
            S5.RowCssClass = "row";

            // Scores_S2
            Scores_S2.RowCssClass = "row";

            // S6
            S6.RowCssClass = "row";

            // S7
            S7.RowCssClass = "row";

            // S8
            S8.RowCssClass = "row";

            // S9
            S9.RowCssClass = "row";

            // S10
            S10.RowCssClass = "row";

            // S11
            S11.RowCssClass = "row";

            // S12
            S12.RowCssClass = "row";

            // S13
            S13.RowCssClass = "row";

            // S14
            S14.RowCssClass = "row";

            // S15
            S15.RowCssClass = "row";

            // Scores_S3
            Scores_S3.RowCssClass = "row";

            // S16
            S16.RowCssClass = "row";

            // S17
            S17.RowCssClass = "row";

            // S18
            S18.RowCssClass = "row";

            // S19
            S19.RowCssClass = "row";

            // S20
            S20.RowCssClass = "row";

            // S21
            S21.RowCssClass = "row";

            // Scores_S4
            Scores_S4.RowCssClass = "row";

            // S22
            S22.RowCssClass = "row";

            // S23
            S23.RowCssClass = "row";

            // S24
            S24.RowCssClass = "row";

            // S25
            S25.RowCssClass = "row";

            // S26
            S26.RowCssClass = "row";

            // Scores_S5
            Scores_S5.RowCssClass = "row";

            // S27
            S27.RowCssClass = "row";

            // S28
            S28.RowCssClass = "row";

            // S29
            S29.RowCssClass = "row";

            // S30
            S30.RowCssClass = "row";

            // S31
            S31.RowCssClass = "row";

            // S32
            S32.RowCssClass = "row";

            // S33
            S33.RowCssClass = "row";

            // S34
            S34.RowCssClass = "row";

            // S35
            S35.RowCssClass = "row";

            // Scores_S6
            Scores_S6.RowCssClass = "row";

            // S36
            S36.RowCssClass = "row";

            // S37
            S37.RowCssClass = "row";

            // S38
            S38.RowCssClass = "row";

            // S39
            S39.RowCssClass = "row";

            // S40
            S40.RowCssClass = "row";

            // S41
            S41.RowCssClass = "row";

            // S42
            S42.RowCssClass = "row";

            // S43
            S43.RowCssClass = "row";

            // Scores_S7
            Scores_S7.RowCssClass = "row";

            // S44
            S44.RowCssClass = "row";

            // S45
            S45.RowCssClass = "row";

            // S46
            S46.RowCssClass = "row";

            // S47
            S47.RowCssClass = "row";

            // S48
            S48.RowCssClass = "row";

            // S49
            S49.RowCssClass = "row";

            // S50
            S50.RowCssClass = "row";

            // Scores_S8
            Scores_S8.RowCssClass = "row";

            // S51
            S51.RowCssClass = "row";

            // S52
            S52.RowCssClass = "row";

            // S53
            S53.RowCssClass = "row";

            // S54
            S54.RowCssClass = "row";

            // S55
            S55.RowCssClass = "row";

            // Scores_S9
            Scores_S9.RowCssClass = "row";

            // S56
            S56.RowCssClass = "row";

            // S57
            S57.RowCssClass = "row";

            // S58
            S58.RowCssClass = "row";

            // S59
            S59.RowCssClass = "row";

            // Scores_S10
            Scores_S10.RowCssClass = "row";

            // S60
            S60.RowCssClass = "row";

            // S61
            S61.RowCssClass = "row";

            // S62
            S62.RowCssClass = "row";

            // S63
            S63.RowCssClass = "row";

            // S64
            S64.RowCssClass = "row";

            // S65
            S65.RowCssClass = "row";

            // Scores_S11
            Scores_S11.RowCssClass = "row";

            // S66
            S66.RowCssClass = "row";

            // S67
            S67.RowCssClass = "row";

            // S68
            S68.RowCssClass = "row";

            // S69
            S69.RowCssClass = "row";

            // S70
            S70.RowCssClass = "row";

            // Evaluation_Score
            Evaluation_Score.RowCssClass = "row";

            // Immediate_Failure_Score
            Immediate_Failure_Score.RowCssClass = "row";

            // Required_Program
            Required_Program.RowCssClass = "row";

            // Price
            Price.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // Eval_ID
                Eval_ID.ViewValue = Eval_ID.CurrentValue;
                Eval_ID.ViewCustomAttributes = "";

                // int_Student_ID
                int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
                int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
                int_Student_ID.ViewCustomAttributes = "";

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

                // Section_1
                Section_1.ViewValue = ConvertToString(Section_1.CurrentValue); // DN
                Section_1.ViewCustomAttributes = "";

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

                // Notes_3
                Notes_3.ViewValue = Notes_3.CurrentValue;
                Notes_3.ViewCustomAttributes = "";

                // Examiner_Signature
                Examiner_Signature.ViewValue = Examiner_Signature.CurrentValue;
                Examiner_Signature.ViewCustomAttributes = "";

                // Student_Signature
                Student_Signature.ViewValue = Student_Signature.CurrentValue;
                Student_Signature.ViewCustomAttributes = "";

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

                // DriveTypelink
                DriveTypelink.ViewValue = DriveTypelink.CurrentValue;
                DriveTypelink.ViewCustomAttributes = "";

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

                // Eval_ID
                Eval_ID.HrefValue = "";
                Eval_ID.TooltipValue = "";

                // int_Student_ID
                int_Student_ID.HrefValue = "";
                int_Student_ID.TooltipValue = "";

                // AssessmentID
                AssessmentID.HrefValue = "";
                AssessmentID.TooltipValue = "";

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.HrefValue = "";
                str_Full_Name_Hdr.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

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
                    intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblEvaluationMB_x_intDrivinglicenseType";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                    intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
                }

                // Date_Entered
                Date_Entered.HrefValue = "";
                Date_Entered.TooltipValue = "";

                // Examination_Number
                Examination_Number.HrefValue = "";
                Examination_Number.TooltipValue = "";

                // Retake
                Retake.HrefValue = "";
                Retake.TooltipValue = "";

                // Section_1
                Section_1.HrefValue = "";
                Section_1.TooltipValue = "";

                // Q1
                Q1.HrefValue = "";
                Q1.TooltipValue = "";

                // Q2
                Q2.HrefValue = "";
                Q2.TooltipValue = "";

                // Q3
                Q3.HrefValue = "";
                Q3.TooltipValue = "";

                // Q4
                Q4.HrefValue = "";
                Q4.TooltipValue = "";

                // Q5
                Q5.HrefValue = "";
                Q5.TooltipValue = "";

                // Section_2
                Section_2.HrefValue = "";
                Section_2.TooltipValue = "";

                // Q6
                Q6.HrefValue = "";
                Q6.TooltipValue = "";

                // Q7
                Q7.HrefValue = "";
                Q7.TooltipValue = "";

                // Q8
                Q8.HrefValue = "";
                Q8.TooltipValue = "";

                // Q9
                Q9.HrefValue = "";
                Q9.TooltipValue = "";

                // Q10
                Q10.HrefValue = "";
                Q10.TooltipValue = "";

                // Q11
                Q11.HrefValue = "";
                Q11.TooltipValue = "";

                // Q12
                Q12.HrefValue = "";
                Q12.TooltipValue = "";

                // Q13
                Q13.HrefValue = "";
                Q13.TooltipValue = "";

                // Q14
                Q14.HrefValue = "";
                Q14.TooltipValue = "";

                // Q15
                Q15.HrefValue = "";
                Q15.TooltipValue = "";

                // Section_3
                Section_3.HrefValue = "";
                Section_3.TooltipValue = "";

                // Q16
                Q16.HrefValue = "";
                Q16.TooltipValue = "";

                // Q17
                Q17.HrefValue = "";
                Q17.TooltipValue = "";

                // Q18
                Q18.HrefValue = "";
                Q18.TooltipValue = "";

                // Q19
                Q19.HrefValue = "";
                Q19.TooltipValue = "";

                // Q20
                Q20.HrefValue = "";
                Q20.TooltipValue = "";

                // Q21
                Q21.HrefValue = "";
                Q21.TooltipValue = "";

                // Section_4
                Section_4.HrefValue = "";
                Section_4.TooltipValue = "";

                // Q22
                Q22.HrefValue = "";
                Q22.TooltipValue = "";

                // Q23
                Q23.HrefValue = "";
                Q23.TooltipValue = "";

                // Q24
                Q24.HrefValue = "";
                Q24.TooltipValue = "";

                // Q25
                Q25.HrefValue = "";
                Q25.TooltipValue = "";

                // Q26
                Q26.HrefValue = "";
                Q26.TooltipValue = "";

                // Section_5
                Section_5.HrefValue = "";
                Section_5.TooltipValue = "";

                // Q27
                Q27.HrefValue = "";
                Q27.TooltipValue = "";

                // Q28
                Q28.HrefValue = "";
                Q28.TooltipValue = "";

                // Q29
                Q29.HrefValue = "";
                Q29.TooltipValue = "";

                // Q30
                Q30.HrefValue = "";
                Q30.TooltipValue = "";

                // Q31
                Q31.HrefValue = "";
                Q31.TooltipValue = "";

                // Q32
                Q32.HrefValue = "";
                Q32.TooltipValue = "";

                // Q33
                Q33.HrefValue = "";
                Q33.TooltipValue = "";

                // Q34
                Q34.HrefValue = "";
                Q34.TooltipValue = "";

                // Q35
                Q35.HrefValue = "";
                Q35.TooltipValue = "";

                // Section_6
                Section_6.HrefValue = "";
                Section_6.TooltipValue = "";

                // Q36
                Q36.HrefValue = "";
                Q36.TooltipValue = "";

                // Q37
                Q37.HrefValue = "";
                Q37.TooltipValue = "";

                // Q38
                Q38.HrefValue = "";
                Q38.TooltipValue = "";

                // Q39
                Q39.HrefValue = "";
                Q39.TooltipValue = "";

                // Q40
                Q40.HrefValue = "";
                Q40.TooltipValue = "";

                // Q41
                Q41.HrefValue = "";
                Q41.TooltipValue = "";

                // Q42
                Q42.HrefValue = "";
                Q42.TooltipValue = "";

                // Q43
                Q43.HrefValue = "";
                Q43.TooltipValue = "";

                // Section_7
                Section_7.HrefValue = "";
                Section_7.TooltipValue = "";

                // Q44
                Q44.HrefValue = "";
                Q44.TooltipValue = "";

                // Q45
                Q45.HrefValue = "";
                Q45.TooltipValue = "";

                // Q46
                Q46.HrefValue = "";
                Q46.TooltipValue = "";

                // Q47
                Q47.HrefValue = "";
                Q47.TooltipValue = "";

                // Q48
                Q48.HrefValue = "";
                Q48.TooltipValue = "";

                // Q49
                Q49.HrefValue = "";
                Q49.TooltipValue = "";

                // Q50
                Q50.HrefValue = "";
                Q50.TooltipValue = "";

                // Section_8
                Section_8.HrefValue = "";
                Section_8.TooltipValue = "";

                // Q51
                Q51.HrefValue = "";
                Q51.TooltipValue = "";

                // Q52
                Q52.HrefValue = "";
                Q52.TooltipValue = "";

                // Q53
                Q53.HrefValue = "";
                Q53.TooltipValue = "";

                // Q54
                Q54.HrefValue = "";
                Q54.TooltipValue = "";

                // Q55
                Q55.HrefValue = "";
                Q55.TooltipValue = "";

                // Section_9
                Section_9.HrefValue = "";
                Section_9.TooltipValue = "";

                // Q56
                Q56.HrefValue = "";
                Q56.TooltipValue = "";

                // Q57
                Q57.HrefValue = "";
                Q57.TooltipValue = "";

                // Q58
                Q58.HrefValue = "";
                Q58.TooltipValue = "";

                // Q59
                Q59.HrefValue = "";
                Q59.TooltipValue = "";

                // Section_10
                Section_10.HrefValue = "";
                Section_10.TooltipValue = "";

                // Q60
                Q60.HrefValue = "";
                Q60.TooltipValue = "";

                // Q61
                Q61.HrefValue = "";
                Q61.TooltipValue = "";

                // Q62
                Q62.HrefValue = "";
                Q62.TooltipValue = "";

                // Q63
                Q63.HrefValue = "";
                Q63.TooltipValue = "";

                // Q64
                Q64.HrefValue = "";
                Q64.TooltipValue = "";

                // Q65
                Q65.HrefValue = "";
                Q65.TooltipValue = "";

                // Section_11
                Section_11.HrefValue = "";
                Section_11.TooltipValue = "";

                // Q66
                Q66.HrefValue = "";
                Q66.TooltipValue = "";

                // Q67
                Q67.HrefValue = "";
                Q67.TooltipValue = "";

                // Q68
                Q68.HrefValue = "";
                Q68.TooltipValue = "";

                // Q69
                Q69.HrefValue = "";
                Q69.TooltipValue = "";

                // Q70
                Q70.HrefValue = "";
                Q70.TooltipValue = "";

                // Notes_3
                Notes_3.HrefValue = "";
                Notes_3.TooltipValue = "";

                // Examiner_Signature
                Examiner_Signature.HrefValue = "";
                Examiner_Signature.TooltipValue = "";

                // Student_Signature
                Student_Signature.HrefValue = "";
                Student_Signature.TooltipValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";
                AbsherApptNbr.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";
                date_Birth_Hijri.TooltipValue = "";

                // date_Birth
                date_Birth.HrefValue = "";
                date_Birth.TooltipValue = "";

                // str_Email
                str_Email.HrefValue = "";
                str_Email.TooltipValue = "";

                // UserlevelID
                UserlevelID.HrefValue = "";
                UserlevelID.TooltipValue = "";

                // DriveTypelink
                DriveTypelink.HrefValue = "";
                DriveTypelink.TooltipValue = "";

                // intEvaluationType
                intEvaluationType.HrefValue = "";
                intEvaluationType.TooltipValue = "";

                // Institution
                Institution.HrefValue = "";
                Institution.TooltipValue = "";

                // Scores_S1
                Scores_S1.HrefValue = "";
                Scores_S1.TooltipValue = "";

                // S1
                S1.HrefValue = "";
                S1.TooltipValue = "";

                // S2
                S2.HrefValue = "";
                S2.TooltipValue = "";

                // S3
                S3.HrefValue = "";
                S3.TooltipValue = "";

                // S4
                S4.HrefValue = "";
                S4.TooltipValue = "";

                // S5
                S5.HrefValue = "";
                S5.TooltipValue = "";

                // Scores_S2
                Scores_S2.HrefValue = "";
                Scores_S2.TooltipValue = "";

                // S6
                S6.HrefValue = "";
                S6.TooltipValue = "";

                // S7
                S7.HrefValue = "";
                S7.TooltipValue = "";

                // S8
                S8.HrefValue = "";
                S8.TooltipValue = "";

                // S9
                S9.HrefValue = "";
                S9.TooltipValue = "";

                // S10
                S10.HrefValue = "";
                S10.TooltipValue = "";

                // S11
                S11.HrefValue = "";
                S11.TooltipValue = "";

                // S12
                S12.HrefValue = "";
                S12.TooltipValue = "";

                // S13
                S13.HrefValue = "";
                S13.TooltipValue = "";

                // S14
                S14.HrefValue = "";
                S14.TooltipValue = "";

                // S15
                S15.HrefValue = "";
                S15.TooltipValue = "";

                // Scores_S3
                Scores_S3.HrefValue = "";
                Scores_S3.TooltipValue = "";

                // S16
                S16.HrefValue = "";
                S16.TooltipValue = "";

                // S17
                S17.HrefValue = "";
                S17.TooltipValue = "";

                // S18
                S18.HrefValue = "";
                S18.TooltipValue = "";

                // S19
                S19.HrefValue = "";
                S19.TooltipValue = "";

                // S20
                S20.HrefValue = "";
                S20.TooltipValue = "";

                // S21
                S21.HrefValue = "";
                S21.TooltipValue = "";

                // Scores_S4
                Scores_S4.HrefValue = "";
                Scores_S4.TooltipValue = "";

                // S22
                S22.HrefValue = "";
                S22.TooltipValue = "";

                // S23
                S23.HrefValue = "";
                S23.TooltipValue = "";

                // S24
                S24.HrefValue = "";
                S24.TooltipValue = "";

                // S25
                S25.HrefValue = "";
                S25.TooltipValue = "";

                // S26
                S26.HrefValue = "";
                S26.TooltipValue = "";

                // Scores_S5
                Scores_S5.HrefValue = "";
                Scores_S5.TooltipValue = "";

                // S27
                S27.HrefValue = "";
                S27.TooltipValue = "";

                // S28
                S28.HrefValue = "";
                S28.TooltipValue = "";

                // S29
                S29.HrefValue = "";
                S29.TooltipValue = "";

                // S30
                S30.HrefValue = "";
                S30.TooltipValue = "";

                // S31
                S31.HrefValue = "";
                S31.TooltipValue = "";

                // S32
                S32.HrefValue = "";
                S32.TooltipValue = "";

                // S33
                S33.HrefValue = "";
                S33.TooltipValue = "";

                // S34
                S34.HrefValue = "";
                S34.TooltipValue = "";

                // S35
                S35.HrefValue = "";
                S35.TooltipValue = "";

                // Scores_S6
                Scores_S6.HrefValue = "";
                Scores_S6.TooltipValue = "";

                // S36
                S36.HrefValue = "";
                S36.TooltipValue = "";

                // S37
                S37.HrefValue = "";
                S37.TooltipValue = "";

                // S38
                S38.HrefValue = "";
                S38.TooltipValue = "";

                // S39
                S39.HrefValue = "";
                S39.TooltipValue = "";

                // S40
                S40.HrefValue = "";
                S40.TooltipValue = "";

                // S41
                S41.HrefValue = "";
                S41.TooltipValue = "";

                // S42
                S42.HrefValue = "";
                S42.TooltipValue = "";

                // S43
                S43.HrefValue = "";
                S43.TooltipValue = "";

                // Scores_S7
                Scores_S7.HrefValue = "";
                Scores_S7.TooltipValue = "";

                // S44
                S44.HrefValue = "";
                S44.TooltipValue = "";

                // S45
                S45.HrefValue = "";
                S45.TooltipValue = "";

                // S46
                S46.HrefValue = "";
                S46.TooltipValue = "";

                // S47
                S47.HrefValue = "";
                S47.TooltipValue = "";

                // S48
                S48.HrefValue = "";
                S48.TooltipValue = "";

                // S49
                S49.HrefValue = "";
                S49.TooltipValue = "";

                // S50
                S50.HrefValue = "";
                S50.TooltipValue = "";

                // Scores_S8
                Scores_S8.HrefValue = "";
                Scores_S8.TooltipValue = "";

                // S51
                S51.HrefValue = "";
                S51.TooltipValue = "";

                // S52
                S52.HrefValue = "";
                S52.TooltipValue = "";

                // S53
                S53.HrefValue = "";
                S53.TooltipValue = "";

                // S54
                S54.HrefValue = "";
                S54.TooltipValue = "";

                // S55
                S55.HrefValue = "";
                S55.TooltipValue = "";

                // Scores_S9
                Scores_S9.HrefValue = "";
                Scores_S9.TooltipValue = "";

                // S56
                S56.HrefValue = "";
                S56.TooltipValue = "";

                // S57
                S57.HrefValue = "";
                S57.TooltipValue = "";

                // S58
                S58.HrefValue = "";
                S58.TooltipValue = "";

                // S59
                S59.HrefValue = "";
                S59.TooltipValue = "";

                // Scores_S10
                Scores_S10.HrefValue = "";
                Scores_S10.TooltipValue = "";

                // S60
                S60.HrefValue = "";
                S60.TooltipValue = "";

                // S61
                S61.HrefValue = "";
                S61.TooltipValue = "";

                // S62
                S62.HrefValue = "";
                S62.TooltipValue = "";

                // S63
                S63.HrefValue = "";
                S63.TooltipValue = "";

                // S64
                S64.HrefValue = "";
                S64.TooltipValue = "";

                // S65
                S65.HrefValue = "";
                S65.TooltipValue = "";

                // Scores_S11
                Scores_S11.HrefValue = "";
                Scores_S11.TooltipValue = "";

                // S66
                S66.HrefValue = "";
                S66.TooltipValue = "";

                // S67
                S67.HrefValue = "";
                S67.TooltipValue = "";

                // S68
                S68.HrefValue = "";
                S68.TooltipValue = "";

                // S69
                S69.HrefValue = "";
                S69.TooltipValue = "";

                // S70
                S70.HrefValue = "";
                S70.TooltipValue = "";

                // Evaluation_Score
                Evaluation_Score.HrefValue = "";
                Evaluation_Score.TooltipValue = "";

                // Immediate_Failure_Score
                Immediate_Failure_Score.HrefValue = "";
                Immediate_Failure_Score.TooltipValue = "";

                // Required_Program
                Required_Program.HrefValue = "";
                Required_Program.TooltipValue = "";

                // Price
                Price.HrefValue = "";
                Price.TooltipValue = "";
            } else if (RowType == RowType.Search) {
                // Eval_ID
                Eval_ID.SetupEditAttributes();
                Eval_ID.EditValue = Eval_ID.AdvancedSearch.SearchValue; // DN
                Eval_ID.PlaceHolder = RemoveHtml(Eval_ID.Caption);

                // int_Student_ID
                int_Student_ID.SetupEditAttributes();
                int_Student_ID.EditValue = int_Student_ID.AdvancedSearch.SearchValue; // DN
                int_Student_ID.PlaceHolder = RemoveHtml(int_Student_ID.Caption);

                // AssessmentID
                AssessmentID.SetupEditAttributes();
                AssessmentID.EditValue = AssessmentID.AdvancedSearch.SearchValue; // DN
                AssessmentID.PlaceHolder = RemoveHtml(AssessmentID.Caption);

                // str_Full_Name_Hdr
                str_Full_Name_Hdr.SetupEditAttributes();
                if (!str_Full_Name_Hdr.Raw)
                    str_Full_Name_Hdr.AdvancedSearch.SearchValue = HtmlDecode(str_Full_Name_Hdr.AdvancedSearch.SearchValue);
                str_Full_Name_Hdr.EditValue = HtmlEncode(str_Full_Name_Hdr.AdvancedSearch.SearchValue);
                str_Full_Name_Hdr.PlaceHolder = RemoveHtml(str_Full_Name_Hdr.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.AdvancedSearch.SearchValue; // DN
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Cell_Phone.AdvancedSearch.SearchValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.AdvancedSearch.SearchValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!str_Username.Raw)
                    str_Username.AdvancedSearch.SearchValue = HtmlDecode(str_Username.AdvancedSearch.SearchValue);
                str_Username.EditValue = HtmlEncode(str_Username.AdvancedSearch.SearchValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.AdvancedSearch.SearchValue; // DN
                intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);

                // Date_Entered
                Date_Entered.SetupEditAttributes();
                Date_Entered.EditValue = FormatDateTime(UnformatDateTime(Date_Entered.AdvancedSearch.SearchValue, Date_Entered.FormatPattern), Date_Entered.FormatPattern); // DN
                Date_Entered.PlaceHolder = RemoveHtml(Date_Entered.Caption);

                // Examination_Number
                Examination_Number.SetupEditAttributes();
                Examination_Number.EditValue = Examination_Number.AdvancedSearch.SearchValue; // DN
                Examination_Number.PlaceHolder = RemoveHtml(Examination_Number.Caption);

                // Retake
                Retake.EditValue = Retake.Options(false);
                Retake.PlaceHolder = RemoveHtml(Retake.Caption);

                // Section_1
                Section_1.SetupEditAttributes();
                if (!Section_1.Raw)
                    Section_1.AdvancedSearch.SearchValue = HtmlDecode(Section_1.AdvancedSearch.SearchValue);
                Section_1.EditValue = HtmlEncode(Section_1.AdvancedSearch.SearchValue);
                Section_1.PlaceHolder = RemoveHtml(Section_1.Caption);

                // Q1
                Q1.EditValue = Q1.Options(false);
                Q1.PlaceHolder = RemoveHtml(Q1.Caption);

                // Q2
                Q2.EditValue = Q2.Options(false);
                Q2.PlaceHolder = RemoveHtml(Q2.Caption);

                // Q3
                Q3.EditValue = Q3.Options(false);
                Q3.PlaceHolder = RemoveHtml(Q3.Caption);

                // Q4
                Q4.EditValue = Q4.Options(false);
                Q4.PlaceHolder = RemoveHtml(Q4.Caption);

                // Q5
                Q5.EditValue = Q5.Options(false);
                Q5.PlaceHolder = RemoveHtml(Q5.Caption);

                // Section_2
                Section_2.SetupEditAttributes();
                if (!Section_2.Raw)
                    Section_2.AdvancedSearch.SearchValue = HtmlDecode(Section_2.AdvancedSearch.SearchValue);
                Section_2.EditValue = HtmlEncode(Section_2.AdvancedSearch.SearchValue);
                Section_2.PlaceHolder = RemoveHtml(Section_2.Caption);

                // Q6
                Q6.EditValue = Q6.Options(false);
                Q6.PlaceHolder = RemoveHtml(Q6.Caption);

                // Q7
                Q7.EditValue = Q7.Options(false);
                Q7.PlaceHolder = RemoveHtml(Q7.Caption);

                // Q8
                Q8.EditValue = Q8.Options(false);
                Q8.PlaceHolder = RemoveHtml(Q8.Caption);

                // Q9
                Q9.EditValue = Q9.Options(false);
                Q9.PlaceHolder = RemoveHtml(Q9.Caption);

                // Q10
                Q10.EditValue = Q10.Options(false);
                Q10.PlaceHolder = RemoveHtml(Q10.Caption);

                // Q11
                Q11.EditValue = Q11.Options(false);
                Q11.PlaceHolder = RemoveHtml(Q11.Caption);

                // Q12
                Q12.EditValue = Q12.Options(false);
                Q12.PlaceHolder = RemoveHtml(Q12.Caption);

                // Q13
                Q13.EditValue = Q13.Options(false);
                Q13.PlaceHolder = RemoveHtml(Q13.Caption);

                // Q14
                Q14.EditValue = Q14.Options(false);
                Q14.PlaceHolder = RemoveHtml(Q14.Caption);

                // Q15
                Q15.EditValue = Q15.Options(false);
                Q15.PlaceHolder = RemoveHtml(Q15.Caption);

                // Section_3
                Section_3.SetupEditAttributes();
                if (!Section_3.Raw)
                    Section_3.AdvancedSearch.SearchValue = HtmlDecode(Section_3.AdvancedSearch.SearchValue);
                Section_3.EditValue = HtmlEncode(Section_3.AdvancedSearch.SearchValue);
                Section_3.PlaceHolder = RemoveHtml(Section_3.Caption);

                // Q16
                Q16.EditValue = Q16.Options(false);
                Q16.PlaceHolder = RemoveHtml(Q16.Caption);

                // Q17
                Q17.EditValue = Q17.Options(false);
                Q17.PlaceHolder = RemoveHtml(Q17.Caption);

                // Q18
                Q18.EditValue = Q18.Options(false);
                Q18.PlaceHolder = RemoveHtml(Q18.Caption);

                // Q19
                Q19.EditValue = Q19.Options(false);
                Q19.PlaceHolder = RemoveHtml(Q19.Caption);

                // Q20
                Q20.EditValue = Q20.Options(false);
                Q20.PlaceHolder = RemoveHtml(Q20.Caption);

                // Q21
                Q21.EditValue = Q21.Options(false);
                Q21.PlaceHolder = RemoveHtml(Q21.Caption);

                // Section_4
                Section_4.SetupEditAttributes();
                if (!Section_4.Raw)
                    Section_4.AdvancedSearch.SearchValue = HtmlDecode(Section_4.AdvancedSearch.SearchValue);
                Section_4.EditValue = HtmlEncode(Section_4.AdvancedSearch.SearchValue);
                Section_4.PlaceHolder = RemoveHtml(Section_4.Caption);

                // Q22
                Q22.EditValue = Q22.Options(false);
                Q22.PlaceHolder = RemoveHtml(Q22.Caption);

                // Q23
                Q23.EditValue = Q23.Options(false);
                Q23.PlaceHolder = RemoveHtml(Q23.Caption);

                // Q24
                Q24.EditValue = Q24.Options(false);
                Q24.PlaceHolder = RemoveHtml(Q24.Caption);

                // Q25
                Q25.EditValue = Q25.Options(false);
                Q25.PlaceHolder = RemoveHtml(Q25.Caption);

                // Q26
                Q26.EditValue = Q26.Options(false);
                Q26.PlaceHolder = RemoveHtml(Q26.Caption);

                // Section_5
                Section_5.SetupEditAttributes();
                if (!Section_5.Raw)
                    Section_5.AdvancedSearch.SearchValue = HtmlDecode(Section_5.AdvancedSearch.SearchValue);
                Section_5.EditValue = HtmlEncode(Section_5.AdvancedSearch.SearchValue);
                Section_5.PlaceHolder = RemoveHtml(Section_5.Caption);

                // Q27
                Q27.EditValue = Q27.Options(false);
                Q27.PlaceHolder = RemoveHtml(Q27.Caption);

                // Q28
                Q28.EditValue = Q28.Options(false);
                Q28.PlaceHolder = RemoveHtml(Q28.Caption);

                // Q29
                Q29.EditValue = Q29.Options(false);
                Q29.PlaceHolder = RemoveHtml(Q29.Caption);

                // Q30
                Q30.EditValue = Q30.Options(false);
                Q30.PlaceHolder = RemoveHtml(Q30.Caption);

                // Q31
                Q31.EditValue = Q31.Options(false);
                Q31.PlaceHolder = RemoveHtml(Q31.Caption);

                // Q32
                Q32.EditValue = Q32.Options(false);
                Q32.PlaceHolder = RemoveHtml(Q32.Caption);

                // Q33
                Q33.EditValue = Q33.Options(false);
                Q33.PlaceHolder = RemoveHtml(Q33.Caption);

                // Q34
                Q34.EditValue = Q34.Options(false);
                Q34.PlaceHolder = RemoveHtml(Q34.Caption);

                // Q35
                Q35.EditValue = Q35.Options(false);
                Q35.PlaceHolder = RemoveHtml(Q35.Caption);

                // Section_6
                Section_6.SetupEditAttributes();
                if (!Section_6.Raw)
                    Section_6.AdvancedSearch.SearchValue = HtmlDecode(Section_6.AdvancedSearch.SearchValue);
                Section_6.EditValue = HtmlEncode(Section_6.AdvancedSearch.SearchValue);
                Section_6.PlaceHolder = RemoveHtml(Section_6.Caption);

                // Q36
                Q36.EditValue = Q36.Options(false);
                Q36.PlaceHolder = RemoveHtml(Q36.Caption);

                // Q37
                Q37.EditValue = Q37.Options(false);
                Q37.PlaceHolder = RemoveHtml(Q37.Caption);

                // Q38
                Q38.EditValue = Q38.Options(false);
                Q38.PlaceHolder = RemoveHtml(Q38.Caption);

                // Q39
                Q39.EditValue = Q39.Options(false);
                Q39.PlaceHolder = RemoveHtml(Q39.Caption);

                // Q40
                Q40.EditValue = Q40.Options(false);
                Q40.PlaceHolder = RemoveHtml(Q40.Caption);

                // Q41
                Q41.EditValue = Q41.Options(false);
                Q41.PlaceHolder = RemoveHtml(Q41.Caption);

                // Q42
                Q42.EditValue = Q42.Options(false);
                Q42.PlaceHolder = RemoveHtml(Q42.Caption);

                // Q43
                Q43.EditValue = Q43.Options(false);
                Q43.PlaceHolder = RemoveHtml(Q43.Caption);

                // Section_7
                Section_7.SetupEditAttributes();
                if (!Section_7.Raw)
                    Section_7.AdvancedSearch.SearchValue = HtmlDecode(Section_7.AdvancedSearch.SearchValue);
                Section_7.EditValue = HtmlEncode(Section_7.AdvancedSearch.SearchValue);
                Section_7.PlaceHolder = RemoveHtml(Section_7.Caption);

                // Q44
                Q44.EditValue = Q44.Options(false);
                Q44.PlaceHolder = RemoveHtml(Q44.Caption);

                // Q45
                Q45.EditValue = Q45.Options(false);
                Q45.PlaceHolder = RemoveHtml(Q45.Caption);

                // Q46
                Q46.EditValue = Q46.Options(false);
                Q46.PlaceHolder = RemoveHtml(Q46.Caption);

                // Q47
                Q47.EditValue = Q47.Options(false);
                Q47.PlaceHolder = RemoveHtml(Q47.Caption);

                // Q48
                Q48.EditValue = Q48.Options(false);
                Q48.PlaceHolder = RemoveHtml(Q48.Caption);

                // Q49
                Q49.EditValue = Q49.Options(false);
                Q49.PlaceHolder = RemoveHtml(Q49.Caption);

                // Q50
                Q50.EditValue = Q50.Options(false);
                Q50.PlaceHolder = RemoveHtml(Q50.Caption);

                // Section_8
                Section_8.SetupEditAttributes();
                if (!Section_8.Raw)
                    Section_8.AdvancedSearch.SearchValue = HtmlDecode(Section_8.AdvancedSearch.SearchValue);
                Section_8.EditValue = HtmlEncode(Section_8.AdvancedSearch.SearchValue);
                Section_8.PlaceHolder = RemoveHtml(Section_8.Caption);

                // Q51
                Q51.EditValue = Q51.Options(false);
                Q51.PlaceHolder = RemoveHtml(Q51.Caption);

                // Q52
                Q52.EditValue = Q52.Options(false);
                Q52.PlaceHolder = RemoveHtml(Q52.Caption);

                // Q53
                Q53.EditValue = Q53.Options(false);
                Q53.PlaceHolder = RemoveHtml(Q53.Caption);

                // Q54
                Q54.EditValue = Q54.Options(false);
                Q54.PlaceHolder = RemoveHtml(Q54.Caption);

                // Q55
                Q55.EditValue = Q55.Options(false);
                Q55.PlaceHolder = RemoveHtml(Q55.Caption);

                // Section_9
                Section_9.SetupEditAttributes();
                if (!Section_9.Raw)
                    Section_9.AdvancedSearch.SearchValue = HtmlDecode(Section_9.AdvancedSearch.SearchValue);
                Section_9.EditValue = HtmlEncode(Section_9.AdvancedSearch.SearchValue);
                Section_9.PlaceHolder = RemoveHtml(Section_9.Caption);

                // Q56
                Q56.EditValue = Q56.Options(false);
                Q56.PlaceHolder = RemoveHtml(Q56.Caption);

                // Q57
                Q57.EditValue = Q57.Options(false);
                Q57.PlaceHolder = RemoveHtml(Q57.Caption);

                // Q58
                Q58.EditValue = Q58.Options(false);
                Q58.PlaceHolder = RemoveHtml(Q58.Caption);

                // Q59
                Q59.EditValue = Q59.Options(false);
                Q59.PlaceHolder = RemoveHtml(Q59.Caption);

                // Section_10
                Section_10.SetupEditAttributes();
                if (!Section_10.Raw)
                    Section_10.AdvancedSearch.SearchValue = HtmlDecode(Section_10.AdvancedSearch.SearchValue);
                Section_10.EditValue = HtmlEncode(Section_10.AdvancedSearch.SearchValue);
                Section_10.PlaceHolder = RemoveHtml(Section_10.Caption);

                // Q60
                Q60.EditValue = Q60.Options(false);
                Q60.PlaceHolder = RemoveHtml(Q60.Caption);

                // Q61
                Q61.EditValue = Q61.Options(false);
                Q61.PlaceHolder = RemoveHtml(Q61.Caption);

                // Q62
                Q62.EditValue = Q62.Options(false);
                Q62.PlaceHolder = RemoveHtml(Q62.Caption);

                // Q63
                Q63.EditValue = Q63.Options(false);
                Q63.PlaceHolder = RemoveHtml(Q63.Caption);

                // Q64
                Q64.EditValue = Q64.Options(false);
                Q64.PlaceHolder = RemoveHtml(Q64.Caption);

                // Q65
                Q65.EditValue = Q65.Options(false);
                Q65.PlaceHolder = RemoveHtml(Q65.Caption);

                // Section_11
                Section_11.SetupEditAttributes();
                if (!Section_11.Raw)
                    Section_11.AdvancedSearch.SearchValue = HtmlDecode(Section_11.AdvancedSearch.SearchValue);
                Section_11.EditValue = HtmlEncode(Section_11.AdvancedSearch.SearchValue);
                Section_11.PlaceHolder = RemoveHtml(Section_11.Caption);

                // Q66
                Q66.EditValue = Q66.Options(false);
                Q66.PlaceHolder = RemoveHtml(Q66.Caption);

                // Q67
                Q67.EditValue = Q67.Options(false);
                Q67.PlaceHolder = RemoveHtml(Q67.Caption);

                // Q68
                Q68.EditValue = Q68.Options(false);
                Q68.PlaceHolder = RemoveHtml(Q68.Caption);

                // Q69
                Q69.EditValue = Q69.Options(false);
                Q69.PlaceHolder = RemoveHtml(Q69.Caption);

                // Q70
                Q70.EditValue = Q70.Options(false);
                Q70.PlaceHolder = RemoveHtml(Q70.Caption);

                // Notes_3
                Notes_3.SetupEditAttributes();
                Notes_3.EditValue = Notes_3.AdvancedSearch.SearchValue; // DN
                Notes_3.PlaceHolder = RemoveHtml(Notes_3.Caption);

                // Examiner_Signature
                Examiner_Signature.SetupEditAttributes();
                if (!Examiner_Signature.Raw)
                    Examiner_Signature.AdvancedSearch.SearchValue = HtmlDecode(Examiner_Signature.AdvancedSearch.SearchValue);
                Examiner_Signature.EditValue = HtmlEncode(Examiner_Signature.AdvancedSearch.SearchValue);
                Examiner_Signature.PlaceHolder = RemoveHtml(Examiner_Signature.Caption);

                // Student_Signature
                Student_Signature.SetupEditAttributes();
                if (!Student_Signature.Raw)
                    Student_Signature.AdvancedSearch.SearchValue = HtmlDecode(Student_Signature.AdvancedSearch.SearchValue);
                Student_Signature.EditValue = HtmlEncode(Student_Signature.AdvancedSearch.SearchValue);
                Student_Signature.PlaceHolder = RemoveHtml(Student_Signature.Caption);

                // AbsherApptNbr
                AbsherApptNbr.SetupEditAttributes();
                if (!AbsherApptNbr.Raw)
                    AbsherApptNbr.AdvancedSearch.SearchValue = HtmlDecode(AbsherApptNbr.AdvancedSearch.SearchValue);
                AbsherApptNbr.EditValue = HtmlEncode(AbsherApptNbr.AdvancedSearch.SearchValue);
                AbsherApptNbr.PlaceHolder = RemoveHtml(AbsherApptNbr.Caption);

                // IsDrivingexperience
                IsDrivingexperience.EditValue = IsDrivingexperience.Options(false);
                IsDrivingexperience.PlaceHolder = RemoveHtml(IsDrivingexperience.Caption);

                // date_Birth_Hijri
                date_Birth_Hijri.SetupEditAttributes();
                if (!date_Birth_Hijri.Raw)
                    date_Birth_Hijri.AdvancedSearch.SearchValue = HtmlDecode(date_Birth_Hijri.AdvancedSearch.SearchValue);
                date_Birth_Hijri.EditValue = HtmlEncode(date_Birth_Hijri.AdvancedSearch.SearchValue);
                date_Birth_Hijri.PlaceHolder = RemoveHtml(date_Birth_Hijri.Caption);

                // date_Birth
                date_Birth.SetupEditAttributes();
                date_Birth.EditValue = FormatDateTime(UnformatDateTime(date_Birth.AdvancedSearch.SearchValue, date_Birth.FormatPattern), date_Birth.FormatPattern); // DN
                date_Birth.PlaceHolder = RemoveHtml(date_Birth.Caption);

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

                // intEvaluationType
                intEvaluationType.SetupEditAttributes();
                intEvaluationType.EditValue = intEvaluationType.AdvancedSearch.SearchValue; // DN
                intEvaluationType.PlaceHolder = RemoveHtml(intEvaluationType.Caption);

                // Institution
                Institution.SetupEditAttributes();
                if (!Institution.Raw)
                    Institution.AdvancedSearch.SearchValue = HtmlDecode(Institution.AdvancedSearch.SearchValue);
                Institution.EditValue = HtmlEncode(Institution.AdvancedSearch.SearchValue);
                Institution.PlaceHolder = RemoveHtml(Institution.Caption);

                // Scores_S1
                Scores_S1.SetupEditAttributes();
                if (!Scores_S1.Raw)
                    Scores_S1.AdvancedSearch.SearchValue = HtmlDecode(Scores_S1.AdvancedSearch.SearchValue);
                Scores_S1.EditValue = HtmlEncode(Scores_S1.AdvancedSearch.SearchValue);
                Scores_S1.PlaceHolder = RemoveHtml(Scores_S1.Caption);

                // S1
                S1.EditValue = S1.Options(false);
                S1.PlaceHolder = RemoveHtml(S1.Caption);

                // S2
                S2.EditValue = S2.Options(false);
                S2.PlaceHolder = RemoveHtml(S2.Caption);

                // S3
                S3.EditValue = S3.Options(false);
                S3.PlaceHolder = RemoveHtml(S3.Caption);

                // S4
                S4.EditValue = S4.Options(false);
                S4.PlaceHolder = RemoveHtml(S4.Caption);

                // S5
                S5.EditValue = S5.Options(false);
                S5.PlaceHolder = RemoveHtml(S5.Caption);

                // Scores_S2
                Scores_S2.SetupEditAttributes();
                if (!Scores_S2.Raw)
                    Scores_S2.AdvancedSearch.SearchValue = HtmlDecode(Scores_S2.AdvancedSearch.SearchValue);
                Scores_S2.EditValue = HtmlEncode(Scores_S2.AdvancedSearch.SearchValue);
                Scores_S2.PlaceHolder = RemoveHtml(Scores_S2.Caption);

                // S6
                S6.EditValue = S6.Options(false);
                S6.PlaceHolder = RemoveHtml(S6.Caption);

                // S7
                S7.EditValue = S7.Options(false);
                S7.PlaceHolder = RemoveHtml(S7.Caption);

                // S8
                S8.EditValue = S8.Options(false);
                S8.PlaceHolder = RemoveHtml(S8.Caption);

                // S9
                S9.EditValue = S9.Options(false);
                S9.PlaceHolder = RemoveHtml(S9.Caption);

                // S10
                S10.EditValue = S10.Options(false);
                S10.PlaceHolder = RemoveHtml(S10.Caption);

                // S11
                S11.EditValue = S11.Options(false);
                S11.PlaceHolder = RemoveHtml(S11.Caption);

                // S12
                S12.EditValue = S12.Options(false);
                S12.PlaceHolder = RemoveHtml(S12.Caption);

                // S13
                S13.EditValue = S13.Options(false);
                S13.PlaceHolder = RemoveHtml(S13.Caption);

                // S14
                S14.EditValue = S14.Options(false);
                S14.PlaceHolder = RemoveHtml(S14.Caption);

                // S15
                S15.EditValue = S15.Options(false);
                S15.PlaceHolder = RemoveHtml(S15.Caption);

                // Scores_S3
                Scores_S3.SetupEditAttributes();
                if (!Scores_S3.Raw)
                    Scores_S3.AdvancedSearch.SearchValue = HtmlDecode(Scores_S3.AdvancedSearch.SearchValue);
                Scores_S3.EditValue = HtmlEncode(Scores_S3.AdvancedSearch.SearchValue);
                Scores_S3.PlaceHolder = RemoveHtml(Scores_S3.Caption);

                // S16
                S16.EditValue = S16.Options(false);
                S16.PlaceHolder = RemoveHtml(S16.Caption);

                // S17
                S17.EditValue = S17.Options(false);
                S17.PlaceHolder = RemoveHtml(S17.Caption);

                // S18
                S18.EditValue = S18.Options(false);
                S18.PlaceHolder = RemoveHtml(S18.Caption);

                // S19
                S19.EditValue = S19.Options(false);
                S19.PlaceHolder = RemoveHtml(S19.Caption);

                // S20
                S20.EditValue = S20.Options(false);
                S20.PlaceHolder = RemoveHtml(S20.Caption);

                // S21
                S21.EditValue = S21.Options(false);
                S21.PlaceHolder = RemoveHtml(S21.Caption);

                // Scores_S4
                Scores_S4.SetupEditAttributes();
                if (!Scores_S4.Raw)
                    Scores_S4.AdvancedSearch.SearchValue = HtmlDecode(Scores_S4.AdvancedSearch.SearchValue);
                Scores_S4.EditValue = HtmlEncode(Scores_S4.AdvancedSearch.SearchValue);
                Scores_S4.PlaceHolder = RemoveHtml(Scores_S4.Caption);

                // S22
                S22.EditValue = S22.Options(false);
                S22.PlaceHolder = RemoveHtml(S22.Caption);

                // S23
                S23.EditValue = S23.Options(false);
                S23.PlaceHolder = RemoveHtml(S23.Caption);

                // S24
                S24.EditValue = S24.Options(false);
                S24.PlaceHolder = RemoveHtml(S24.Caption);

                // S25
                S25.EditValue = S25.Options(false);
                S25.PlaceHolder = RemoveHtml(S25.Caption);

                // S26
                S26.EditValue = S26.Options(false);
                S26.PlaceHolder = RemoveHtml(S26.Caption);

                // Scores_S5
                Scores_S5.SetupEditAttributes();
                if (!Scores_S5.Raw)
                    Scores_S5.AdvancedSearch.SearchValue = HtmlDecode(Scores_S5.AdvancedSearch.SearchValue);
                Scores_S5.EditValue = HtmlEncode(Scores_S5.AdvancedSearch.SearchValue);
                Scores_S5.PlaceHolder = RemoveHtml(Scores_S5.Caption);

                // S27
                S27.EditValue = S27.Options(false);
                S27.PlaceHolder = RemoveHtml(S27.Caption);

                // S28
                S28.EditValue = S28.Options(false);
                S28.PlaceHolder = RemoveHtml(S28.Caption);

                // S29
                S29.EditValue = S29.Options(false);
                S29.PlaceHolder = RemoveHtml(S29.Caption);

                // S30
                S30.EditValue = S30.Options(false);
                S30.PlaceHolder = RemoveHtml(S30.Caption);

                // S31
                S31.EditValue = S31.Options(false);
                S31.PlaceHolder = RemoveHtml(S31.Caption);

                // S32
                S32.EditValue = S32.Options(false);
                S32.PlaceHolder = RemoveHtml(S32.Caption);

                // S33
                S33.EditValue = S33.Options(false);
                S33.PlaceHolder = RemoveHtml(S33.Caption);

                // S34
                S34.EditValue = S34.Options(false);
                S34.PlaceHolder = RemoveHtml(S34.Caption);

                // S35
                S35.EditValue = S35.Options(false);
                S35.PlaceHolder = RemoveHtml(S35.Caption);

                // Scores_S6
                Scores_S6.SetupEditAttributes();
                if (!Scores_S6.Raw)
                    Scores_S6.AdvancedSearch.SearchValue = HtmlDecode(Scores_S6.AdvancedSearch.SearchValue);
                Scores_S6.EditValue = HtmlEncode(Scores_S6.AdvancedSearch.SearchValue);
                Scores_S6.PlaceHolder = RemoveHtml(Scores_S6.Caption);

                // S36
                S36.EditValue = S36.Options(false);
                S36.PlaceHolder = RemoveHtml(S36.Caption);

                // S37
                S37.EditValue = S37.Options(false);
                S37.PlaceHolder = RemoveHtml(S37.Caption);

                // S38
                S38.EditValue = S38.Options(false);
                S38.PlaceHolder = RemoveHtml(S38.Caption);

                // S39
                S39.EditValue = S39.Options(false);
                S39.PlaceHolder = RemoveHtml(S39.Caption);

                // S40
                S40.EditValue = S40.Options(false);
                S40.PlaceHolder = RemoveHtml(S40.Caption);

                // S41
                S41.EditValue = S41.Options(false);
                S41.PlaceHolder = RemoveHtml(S41.Caption);

                // S42
                S42.EditValue = S42.Options(false);
                S42.PlaceHolder = RemoveHtml(S42.Caption);

                // S43
                S43.EditValue = S43.Options(false);
                S43.PlaceHolder = RemoveHtml(S43.Caption);

                // Scores_S7
                Scores_S7.SetupEditAttributes();
                if (!Scores_S7.Raw)
                    Scores_S7.AdvancedSearch.SearchValue = HtmlDecode(Scores_S7.AdvancedSearch.SearchValue);
                Scores_S7.EditValue = HtmlEncode(Scores_S7.AdvancedSearch.SearchValue);
                Scores_S7.PlaceHolder = RemoveHtml(Scores_S7.Caption);

                // S44
                S44.EditValue = S44.Options(false);
                S44.PlaceHolder = RemoveHtml(S44.Caption);

                // S45
                S45.EditValue = S45.Options(false);
                S45.PlaceHolder = RemoveHtml(S45.Caption);

                // S46
                S46.EditValue = S46.Options(false);
                S46.PlaceHolder = RemoveHtml(S46.Caption);

                // S47
                S47.EditValue = S47.Options(false);
                S47.PlaceHolder = RemoveHtml(S47.Caption);

                // S48
                S48.EditValue = S48.Options(false);
                S48.PlaceHolder = RemoveHtml(S48.Caption);

                // S49
                S49.EditValue = S49.Options(false);
                S49.PlaceHolder = RemoveHtml(S49.Caption);

                // S50
                S50.EditValue = S50.Options(false);
                S50.PlaceHolder = RemoveHtml(S50.Caption);

                // Scores_S8
                Scores_S8.SetupEditAttributes();
                if (!Scores_S8.Raw)
                    Scores_S8.AdvancedSearch.SearchValue = HtmlDecode(Scores_S8.AdvancedSearch.SearchValue);
                Scores_S8.EditValue = HtmlEncode(Scores_S8.AdvancedSearch.SearchValue);
                Scores_S8.PlaceHolder = RemoveHtml(Scores_S8.Caption);

                // S51
                S51.EditValue = S51.Options(false);
                S51.PlaceHolder = RemoveHtml(S51.Caption);

                // S52
                S52.EditValue = S52.Options(false);
                S52.PlaceHolder = RemoveHtml(S52.Caption);

                // S53
                S53.EditValue = S53.Options(false);
                S53.PlaceHolder = RemoveHtml(S53.Caption);

                // S54
                S54.EditValue = S54.Options(false);
                S54.PlaceHolder = RemoveHtml(S54.Caption);

                // S55
                S55.EditValue = S55.Options(false);
                S55.PlaceHolder = RemoveHtml(S55.Caption);

                // Scores_S9
                Scores_S9.SetupEditAttributes();
                if (!Scores_S9.Raw)
                    Scores_S9.AdvancedSearch.SearchValue = HtmlDecode(Scores_S9.AdvancedSearch.SearchValue);
                Scores_S9.EditValue = HtmlEncode(Scores_S9.AdvancedSearch.SearchValue);
                Scores_S9.PlaceHolder = RemoveHtml(Scores_S9.Caption);

                // S56
                S56.EditValue = S56.Options(false);
                S56.PlaceHolder = RemoveHtml(S56.Caption);

                // S57
                S57.EditValue = S57.Options(false);
                S57.PlaceHolder = RemoveHtml(S57.Caption);

                // S58
                S58.EditValue = S58.Options(false);
                S58.PlaceHolder = RemoveHtml(S58.Caption);

                // S59
                S59.EditValue = S59.Options(false);
                S59.PlaceHolder = RemoveHtml(S59.Caption);

                // Scores_S10
                Scores_S10.SetupEditAttributes();
                if (!Scores_S10.Raw)
                    Scores_S10.AdvancedSearch.SearchValue = HtmlDecode(Scores_S10.AdvancedSearch.SearchValue);
                Scores_S10.EditValue = HtmlEncode(Scores_S10.AdvancedSearch.SearchValue);
                Scores_S10.PlaceHolder = RemoveHtml(Scores_S10.Caption);

                // S60
                S60.EditValue = S60.Options(false);
                S60.PlaceHolder = RemoveHtml(S60.Caption);

                // S61
                S61.EditValue = S61.Options(false);
                S61.PlaceHolder = RemoveHtml(S61.Caption);

                // S62
                S62.EditValue = S62.Options(false);
                S62.PlaceHolder = RemoveHtml(S62.Caption);

                // S63
                S63.EditValue = S63.Options(false);
                S63.PlaceHolder = RemoveHtml(S63.Caption);

                // S64
                S64.EditValue = S64.Options(false);
                S64.PlaceHolder = RemoveHtml(S64.Caption);

                // S65
                S65.EditValue = S65.Options(false);
                S65.PlaceHolder = RemoveHtml(S65.Caption);

                // Scores_S11
                Scores_S11.SetupEditAttributes();
                if (!Scores_S11.Raw)
                    Scores_S11.AdvancedSearch.SearchValue = HtmlDecode(Scores_S11.AdvancedSearch.SearchValue);
                Scores_S11.EditValue = HtmlEncode(Scores_S11.AdvancedSearch.SearchValue);
                Scores_S11.PlaceHolder = RemoveHtml(Scores_S11.Caption);

                // S66
                S66.EditValue = S66.Options(false);
                S66.PlaceHolder = RemoveHtml(S66.Caption);

                // S67
                S67.EditValue = S67.Options(false);
                S67.PlaceHolder = RemoveHtml(S67.Caption);

                // S68
                S68.EditValue = S68.Options(false);
                S68.PlaceHolder = RemoveHtml(S68.Caption);

                // S69
                S69.EditValue = S69.Options(false);
                S69.PlaceHolder = RemoveHtml(S69.Caption);

                // S70
                S70.EditValue = S70.Options(false);
                S70.PlaceHolder = RemoveHtml(S70.Caption);

                // Evaluation_Score
                Evaluation_Score.SetupEditAttributes();
                Evaluation_Score.EditValue = Evaluation_Score.AdvancedSearch.SearchValue; // DN
                Evaluation_Score.PlaceHolder = RemoveHtml(Evaluation_Score.Caption);

                // Immediate_Failure_Score
                Immediate_Failure_Score.SetupEditAttributes();
                Immediate_Failure_Score.EditValue = Immediate_Failure_Score.AdvancedSearch.SearchValue; // DN
                Immediate_Failure_Score.PlaceHolder = RemoveHtml(Immediate_Failure_Score.Caption);

                // Required_Program
                Required_Program.SetupEditAttributes();
                if (!Required_Program.Raw)
                    Required_Program.AdvancedSearch.SearchValue = HtmlDecode(Required_Program.AdvancedSearch.SearchValue);
                Required_Program.EditValue = HtmlEncode(Required_Program.AdvancedSearch.SearchValue);
                Required_Program.PlaceHolder = RemoveHtml(Required_Program.Caption);

                // Price
                Price.SetupEditAttributes();
                Price.EditValue = Price.AdvancedSearch.SearchValue; // DN
                Price.PlaceHolder = RemoveHtml(Price.Caption);
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
            if (!CheckInteger(ConvertToString(Eval_ID.AdvancedSearch.SearchValue))) {
                Eval_ID.AddErrorMessage(Eval_ID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Student_ID.AdvancedSearch.SearchValue))) {
                int_Student_ID.AddErrorMessage(int_Student_ID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(AssessmentID.AdvancedSearch.SearchValue))) {
                AssessmentID.AddErrorMessage(AssessmentID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(NationalID.AdvancedSearch.SearchValue))) {
                NationalID.AddErrorMessage(NationalID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(intDrivinglicenseType.AdvancedSearch.SearchValue))) {
                intDrivinglicenseType.AddErrorMessage(intDrivinglicenseType.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(Date_Entered.AdvancedSearch.SearchValue), Date_Entered.FormatPattern)) {
                Date_Entered.AddErrorMessage(Date_Entered.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(Examination_Number.AdvancedSearch.SearchValue))) {
                Examination_Number.AddErrorMessage(Examination_Number.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(date_Birth.AdvancedSearch.SearchValue), date_Birth.FormatPattern)) {
                date_Birth.AddErrorMessage(date_Birth.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(UserlevelID.AdvancedSearch.SearchValue))) {
                UserlevelID.AddErrorMessage(UserlevelID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(intEvaluationType.AdvancedSearch.SearchValue))) {
                intEvaluationType.AddErrorMessage(intEvaluationType.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(Evaluation_Score.AdvancedSearch.SearchValue))) {
                Evaluation_Score.AddErrorMessage(Evaluation_Score.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(Immediate_Failure_Score.AdvancedSearch.SearchValue))) {
                Immediate_Failure_Score.AddErrorMessage(Immediate_Failure_Score.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(Price.AdvancedSearch.SearchValue))) {
                Price.AddErrorMessage(Price.GetErrorMessage(false));
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
            Eval_ID.AdvancedSearch.Load();
            int_Student_ID.AdvancedSearch.Load();
            AssessmentID.AdvancedSearch.Load();
            str_Full_Name_Hdr.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            str_Cell_Phone.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            intDrivinglicenseType.AdvancedSearch.Load();
            Date_Entered.AdvancedSearch.Load();
            Examination_Number.AdvancedSearch.Load();
            Retake.AdvancedSearch.Load();
            Section_1.AdvancedSearch.Load();
            Q1.AdvancedSearch.Load();
            Q2.AdvancedSearch.Load();
            Q3.AdvancedSearch.Load();
            Q4.AdvancedSearch.Load();
            Q5.AdvancedSearch.Load();
            Section_2.AdvancedSearch.Load();
            Q6.AdvancedSearch.Load();
            Q7.AdvancedSearch.Load();
            Q8.AdvancedSearch.Load();
            Q9.AdvancedSearch.Load();
            Q10.AdvancedSearch.Load();
            Q11.AdvancedSearch.Load();
            Q12.AdvancedSearch.Load();
            Q13.AdvancedSearch.Load();
            Q14.AdvancedSearch.Load();
            Q15.AdvancedSearch.Load();
            Section_3.AdvancedSearch.Load();
            Q16.AdvancedSearch.Load();
            Q17.AdvancedSearch.Load();
            Q18.AdvancedSearch.Load();
            Q19.AdvancedSearch.Load();
            Q20.AdvancedSearch.Load();
            Q21.AdvancedSearch.Load();
            Section_4.AdvancedSearch.Load();
            Q22.AdvancedSearch.Load();
            Q23.AdvancedSearch.Load();
            Q24.AdvancedSearch.Load();
            Q25.AdvancedSearch.Load();
            Q26.AdvancedSearch.Load();
            Section_5.AdvancedSearch.Load();
            Q27.AdvancedSearch.Load();
            Q28.AdvancedSearch.Load();
            Q29.AdvancedSearch.Load();
            Q30.AdvancedSearch.Load();
            Q31.AdvancedSearch.Load();
            Q32.AdvancedSearch.Load();
            Q33.AdvancedSearch.Load();
            Q34.AdvancedSearch.Load();
            Q35.AdvancedSearch.Load();
            Section_6.AdvancedSearch.Load();
            Q36.AdvancedSearch.Load();
            Q37.AdvancedSearch.Load();
            Q38.AdvancedSearch.Load();
            Q39.AdvancedSearch.Load();
            Q40.AdvancedSearch.Load();
            Q41.AdvancedSearch.Load();
            Q42.AdvancedSearch.Load();
            Q43.AdvancedSearch.Load();
            Section_7.AdvancedSearch.Load();
            Q44.AdvancedSearch.Load();
            Q45.AdvancedSearch.Load();
            Q46.AdvancedSearch.Load();
            Q47.AdvancedSearch.Load();
            Q48.AdvancedSearch.Load();
            Q49.AdvancedSearch.Load();
            Q50.AdvancedSearch.Load();
            Section_8.AdvancedSearch.Load();
            Q51.AdvancedSearch.Load();
            Q52.AdvancedSearch.Load();
            Q53.AdvancedSearch.Load();
            Q54.AdvancedSearch.Load();
            Q55.AdvancedSearch.Load();
            Section_9.AdvancedSearch.Load();
            Q56.AdvancedSearch.Load();
            Q57.AdvancedSearch.Load();
            Q58.AdvancedSearch.Load();
            Q59.AdvancedSearch.Load();
            Section_10.AdvancedSearch.Load();
            Q60.AdvancedSearch.Load();
            Q61.AdvancedSearch.Load();
            Q62.AdvancedSearch.Load();
            Q63.AdvancedSearch.Load();
            Q64.AdvancedSearch.Load();
            Q65.AdvancedSearch.Load();
            Section_11.AdvancedSearch.Load();
            Q66.AdvancedSearch.Load();
            Q67.AdvancedSearch.Load();
            Q68.AdvancedSearch.Load();
            Q69.AdvancedSearch.Load();
            Q70.AdvancedSearch.Load();
            Notes_3.AdvancedSearch.Load();
            Examiner_Signature.AdvancedSearch.Load();
            Student_Signature.AdvancedSearch.Load();
            AbsherApptNbr.AdvancedSearch.Load();
            IsDrivingexperience.AdvancedSearch.Load();
            date_Birth_Hijri.AdvancedSearch.Load();
            date_Birth.AdvancedSearch.Load();
            str_Email.AdvancedSearch.Load();
            UserlevelID.AdvancedSearch.Load();
            DriveTypelink.AdvancedSearch.Load();
            intEvaluationType.AdvancedSearch.Load();
            Institution.AdvancedSearch.Load();
            Scores_S1.AdvancedSearch.Load();
            S1.AdvancedSearch.Load();
            S2.AdvancedSearch.Load();
            S3.AdvancedSearch.Load();
            S4.AdvancedSearch.Load();
            S5.AdvancedSearch.Load();
            Scores_S2.AdvancedSearch.Load();
            S6.AdvancedSearch.Load();
            S7.AdvancedSearch.Load();
            S8.AdvancedSearch.Load();
            S9.AdvancedSearch.Load();
            S10.AdvancedSearch.Load();
            S11.AdvancedSearch.Load();
            S12.AdvancedSearch.Load();
            S13.AdvancedSearch.Load();
            S14.AdvancedSearch.Load();
            S15.AdvancedSearch.Load();
            Scores_S3.AdvancedSearch.Load();
            S16.AdvancedSearch.Load();
            S17.AdvancedSearch.Load();
            S18.AdvancedSearch.Load();
            S19.AdvancedSearch.Load();
            S20.AdvancedSearch.Load();
            S21.AdvancedSearch.Load();
            Scores_S4.AdvancedSearch.Load();
            S22.AdvancedSearch.Load();
            S23.AdvancedSearch.Load();
            S24.AdvancedSearch.Load();
            S25.AdvancedSearch.Load();
            S26.AdvancedSearch.Load();
            Scores_S5.AdvancedSearch.Load();
            S27.AdvancedSearch.Load();
            S28.AdvancedSearch.Load();
            S29.AdvancedSearch.Load();
            S30.AdvancedSearch.Load();
            S31.AdvancedSearch.Load();
            S32.AdvancedSearch.Load();
            S33.AdvancedSearch.Load();
            S34.AdvancedSearch.Load();
            S35.AdvancedSearch.Load();
            Scores_S6.AdvancedSearch.Load();
            S36.AdvancedSearch.Load();
            S37.AdvancedSearch.Load();
            S38.AdvancedSearch.Load();
            S39.AdvancedSearch.Load();
            S40.AdvancedSearch.Load();
            S41.AdvancedSearch.Load();
            S42.AdvancedSearch.Load();
            S43.AdvancedSearch.Load();
            Scores_S7.AdvancedSearch.Load();
            S44.AdvancedSearch.Load();
            S45.AdvancedSearch.Load();
            S46.AdvancedSearch.Load();
            S47.AdvancedSearch.Load();
            S48.AdvancedSearch.Load();
            S49.AdvancedSearch.Load();
            S50.AdvancedSearch.Load();
            Scores_S8.AdvancedSearch.Load();
            S51.AdvancedSearch.Load();
            S52.AdvancedSearch.Load();
            S53.AdvancedSearch.Load();
            S54.AdvancedSearch.Load();
            S55.AdvancedSearch.Load();
            Scores_S9.AdvancedSearch.Load();
            S56.AdvancedSearch.Load();
            S57.AdvancedSearch.Load();
            S58.AdvancedSearch.Load();
            S59.AdvancedSearch.Load();
            Scores_S10.AdvancedSearch.Load();
            S60.AdvancedSearch.Load();
            S61.AdvancedSearch.Load();
            S62.AdvancedSearch.Load();
            S63.AdvancedSearch.Load();
            S64.AdvancedSearch.Load();
            S65.AdvancedSearch.Load();
            Scores_S11.AdvancedSearch.Load();
            S66.AdvancedSearch.Load();
            S67.AdvancedSearch.Load();
            S68.AdvancedSearch.Load();
            S69.AdvancedSearch.Load();
            S70.AdvancedSearch.Load();
            Evaluation_Score.AdvancedSearch.Load();
            Immediate_Failure_Score.AdvancedSearch.Load();
            Required_Program.AdvancedSearch.Load();
            Price.AdvancedSearch.Load();
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblEvaluationMbList")), "", TableVar, true);
            string pageId = "search";
            breadcrumb.Add("search", pageId, url);
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
            pages.Add(4);
            pages.Add(5);
            pages.Add(6);
            pages.Add(7);
            pages.Add(8);
            pages.Add(9);
            pages.Add(10);
            pages.Add(11);
            pages.Add(12);
            pages.Add(13);
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
