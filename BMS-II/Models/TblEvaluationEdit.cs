namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblEvaluationEdit
    /// </summary>
    public static TblEvaluationEdit tblEvaluationEdit
    {
        get => HttpData.Get<TblEvaluationEdit>("tblEvaluationEdit")!;
        set => HttpData["tblEvaluationEdit"] = value;
    }

    /// <summary>
    /// Page class for tblEvaluation
    /// </summary>
    public class TblEvaluationEdit : TblEvaluationEditBase
    {
        // Constructor
        public TblEvaluationEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblEvaluationEdit() : base()
        {
        }

        // Page Data Rendered event
        public override void PageDataRendered(ref string footer) {
        	footer = $"<p class='text-start'><span class='MsoNormal fw-light '>Current User: </span><span class='fw-semibold'>{GetCurrentUserLevelName()}</span></p>";
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblEvaluationEditBase : TblEvaluation
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblEvaluation";

        // Page object name
        public string PageObjName = "tblEvaluationEdit";

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
        public TblEvaluationEditBase()
        {
            // Custom template // DN
            UseCustomTemplate = true;

            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table d-none";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblEvaluation)
            if (tblEvaluation == null || tblEvaluation is TblEvaluation)
                tblEvaluation = this;

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
        public string PageName => "TblEvaluationEdit";

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
            AssessmentID.Visible = false;
            str_Full_Name_Hdr.SetVisibility();
            NationalID.SetVisibility();
            str_Cell_Phone.SetVisibility();
            int_Student_ID.Visible = false;
            intDrivinglicenseType.SetVisibility();
            Date_Entered.SetVisibility();
            Examination_Number.Visible = false;
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
            Q60.SetVisibility();
            Section_10.SetVisibility();
            Q61.SetVisibility();
            Q62.SetVisibility();
            Q63.SetVisibility();
            Q64.SetVisibility();
            Q65.SetVisibility();
            Q66.SetVisibility();
            Section_11.SetVisibility();
            Q67.SetVisibility();
            Q68.SetVisibility();
            Q69.SetVisibility();
            Q70.SetVisibility();
            Notes_3.SetVisibility();
            Student_Signature.SetVisibility();
            Examiner_Signature.SetVisibility();
            str_Username.Visible = false;
            Retake.SetVisibility();
            AbsherApptNbr.SetVisibility();
            IsDrivingexperience.SetVisibility();
            date_Birth_Hijri.SetVisibility();
            date_Birth.SetVisibility();
            str_Email.SetVisibility();
            UserlevelID.SetVisibility();
            Assigned_int_Package_Id.Visible = false;
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
            DriveTypelink.Visible = false;
            Evaluation_Score.Visible = false;
            Immediate_Failure_Score.Visible = false;
            Required_Program.Visible = false;
            Price.Visible = false;
            intEvaluationType.SetVisibility();
            Institution.Visible = false;
        }

        // Constructor
        public TblEvaluationEditBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblEvaluationView" ? "1" : "0"); // If View page, no primary button
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

        public int DisplayRecords = 1; // Number of display records

        public int StartRecord;

        public int StopRecord;

        public int TotalRecords = -1;

        public int RecordRange = 10;

        public int RecordCount;

        public Dictionary<string, string> RecordKeys = new ();

        public string FormClassName = "ew-form ew-edit-form overlay-wrapper";

        public bool IsModal = false;

        public bool IsMobileOrModal = false;

        public string DbMasterFilter = "";

        public string DbDetailFilter = "";

        public DbDataReader? Recordset; // DN

        #pragma warning disable 219
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
            await SetupLookupOptions(Retake);
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

            // Check modal
            if (IsModal)
                SkipHeaderFooter = true;
            IsMobileOrModal = IsMobile() || IsModal;
            bool loaded = false;
            bool postBack = false;
            StringValues sv;
            object? rv;

            // Set up current action and primary key
            if (IsApi()) {
                loaded = true;

                // Load key from form
                string[] keyValues = {};
                if (RouteValues.TryGetValue("key", out object? k))
                    keyValues = ConvertToString(k).Split('/');
                if (RouteValues.TryGetValue("Eval_ID", out rv)) { // DN
                    Eval_ID.FormValue = UrlDecode(rv); // DN
                    Eval_ID.OldValue = Eval_ID.FormValue;
                } else if (CurrentForm.HasValue("x_Eval_ID")) {
                    Eval_ID.FormValue = CurrentForm.GetValue("x_Eval_ID");
                    Eval_ID.OldValue = Eval_ID.FormValue;
                } else if (!Empty(keyValues)) {
                    Eval_ID.OldValue = ConvertToString(keyValues[0]);
                } else {
                    loaded = false; // Unable to load key
                }

                // Load record
                if (loaded)
                    loaded = await LoadRow();
                if (!loaded) {
                    FailureMessage = Language.Phrase("NoRecord"); // Set no record message
                    return Terminate();
                }
                CurrentAction = "update"; // Update record directly
                OldKey = GetKey(true); // Get from CurrentValue
                postBack = true;
            } else {
                if (!Empty(Post("action"))) {
                    CurrentAction = Post("action"); // Get action code
                    if (!IsShow) // Not reload record, handle as postback
                        postBack = true;

                    // Get key from Form
                    if (Post(OldKeyName, out sv))
                        SetKey(sv.ToString(), IsShow);
                } else {
                    CurrentAction = "show"; // Default action is display

                    // Load key from QueryString
                    bool loadByQuery = false;
                    if (RouteValues.TryGetValue("Eval_ID", out rv)) { // DN
                        Eval_ID.QueryValue = UrlDecode(rv); // DN
                        loadByQuery = true;
                    } else if (Get("Eval_ID", out sv)) {
                        Eval_ID.QueryValue = sv.ToString();
                        loadByQuery = true;
                    } else {
                        Eval_ID.CurrentValue = DbNullValue;
                    }
                }

                // Set up master detail parameters
                SetupMasterParms();

                // Load recordset
                if (IsShow) {
                    // Load current record
                    loaded = await LoadRow();
                OldKey = loaded ? GetKey(true) : ""; // Get from CurrentValue
            }
        }

        // Process form if post back
        if (postBack) {
            await LoadFormValues(); // Get form values
            if (IsApi() && RouteValues.TryGetValue("key", out object? k)) {
                var keyValues = ConvertToString(k).Split('/');
                Eval_ID.FormValue = ConvertToString(keyValues[0]);
            }
        }

        // Validate form if post back
        if (postBack) {
            if (!await ValidateForm()) {
                EventCancelled = true; // Event cancelled
                RestoreFormValues();
                if (IsApi())
                    return Terminate();
                else
                    CurrentAction = ""; // Form error, reset action
            }
        }

        // Perform current action
        switch (CurrentAction) {
                case "show": // Get a record to display
                        if (!loaded) { // Load record based on key
                            if (Empty(FailureMessage))
                                FailureMessage = Language.Phrase("NoRecord"); // No record found
                            return Terminate("TblEvaluationList"); // No matching record, return to list
                        }
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = ViewUrl;
                    if (GetPageName(returnUrl) == "TblEvaluationList")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblEvaluationList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblEvaluationList"; // Return list page content
                            }
                        }
                        if (IsJsonResponse()) {
                            ClearMessages(); // Clear messages for Json response
                            return res;
                        } else {
                            return Terminate(returnUrl); // Return to caller
                        }
                    } else if (IsApi()) { // API request, return
                        return Terminate();
                    } else if (IsModal && UseAjaxActions) { // Return JSON error message
                        return Controller.Json(new { success = false, error = GetFailureMessage() });
                    } else if (FailureMessage == Language.Phrase("NoRecord")) {
                        return Terminate(returnUrl); // Return to caller
                    } else {
                        EventCancelled = true; // Event cancelled
                        RestoreFormValues(); // Restore form values if update failed
                    }
                    break;
            }

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Render the record
            RowType = RowType.Edit; // Render as Edit
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
                tblEvaluationEdit?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 219

        // Confirm page
        public bool ConfirmPage = false; // DN

        #pragma warning disable 1998
        // Get upload files
        public async Task GetUploadFiles()
        {
            // Get upload data
        }
        #pragma warning restore 1998

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
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

            // Check field name 'NationalID' before field var 'x_NationalID'
            val = CurrentForm.HasValue("NationalID") ? CurrentForm.GetValue("NationalID") : CurrentForm.GetValue("x_NationalID");
            if (!NationalID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("NationalID") && !CurrentForm.HasValue("x_NationalID")) // DN
                    NationalID.Visible = false; // Disable update for API request
                else
                    NationalID.SetFormValue(val);
            }

            // Check field name 'str_Cell_Phone' before field var 'x_str_Cell_Phone'
            val = CurrentForm.HasValue("str_Cell_Phone") ? CurrentForm.GetValue("str_Cell_Phone") : CurrentForm.GetValue("x_str_Cell_Phone");
            if (!str_Cell_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Cell_Phone") && !CurrentForm.HasValue("x_str_Cell_Phone")) // DN
                    str_Cell_Phone.Visible = false; // Disable update for API request
                else
                    str_Cell_Phone.SetFormValue(val);
            }

            // Check field name 'intDrivinglicenseType' before field var 'x_intDrivinglicenseType'
            val = CurrentForm.HasValue("intDrivinglicenseType") ? CurrentForm.GetValue("intDrivinglicenseType") : CurrentForm.GetValue("x_intDrivinglicenseType");
            if (!intDrivinglicenseType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("intDrivinglicenseType") && !CurrentForm.HasValue("x_intDrivinglicenseType")) // DN
                    intDrivinglicenseType.Visible = false; // Disable update for API request
                else
                    intDrivinglicenseType.SetFormValue(val);
            }

            // Check field name 'Date_Entered' before field var 'x_Date_Entered'
            val = CurrentForm.HasValue("Date_Entered") ? CurrentForm.GetValue("Date_Entered") : CurrentForm.GetValue("x_Date_Entered");
            if (!Date_Entered.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Date_Entered") && !CurrentForm.HasValue("x_Date_Entered")) // DN
                    Date_Entered.Visible = false; // Disable update for API request
                else
                    Date_Entered.SetFormValue(val);
                Date_Entered.CurrentValue = UnformatDateTime(Date_Entered.CurrentValue, Date_Entered.FormatPattern);
            }

            // Check field name 'Section_1' before field var 'x_Section_1'
            val = CurrentForm.HasValue("Section_1") ? CurrentForm.GetValue("Section_1") : CurrentForm.GetValue("x_Section_1");
            if (!Section_1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_1") && !CurrentForm.HasValue("x_Section_1")) // DN
                    Section_1.Visible = false; // Disable update for API request
                else
                    Section_1.SetFormValue(val);
            }

            // Check field name 'Q1' before field var 'x_Q1'
            val = CurrentForm.HasValue("Q1") ? CurrentForm.GetValue("Q1") : CurrentForm.GetValue("x_Q1");
            if (!Q1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q1") && !CurrentForm.HasValue("x_Q1")) // DN
                    Q1.Visible = false; // Disable update for API request
                else
                    Q1.SetFormValue(val);
            }

            // Check field name 'Q2' before field var 'x_Q2'
            val = CurrentForm.HasValue("Q2") ? CurrentForm.GetValue("Q2") : CurrentForm.GetValue("x_Q2");
            if (!Q2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q2") && !CurrentForm.HasValue("x_Q2")) // DN
                    Q2.Visible = false; // Disable update for API request
                else
                    Q2.SetFormValue(val);
            }

            // Check field name 'Q3' before field var 'x_Q3'
            val = CurrentForm.HasValue("Q3") ? CurrentForm.GetValue("Q3") : CurrentForm.GetValue("x_Q3");
            if (!Q3.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q3") && !CurrentForm.HasValue("x_Q3")) // DN
                    Q3.Visible = false; // Disable update for API request
                else
                    Q3.SetFormValue(val);
            }

            // Check field name 'Q4' before field var 'x_Q4'
            val = CurrentForm.HasValue("Q4") ? CurrentForm.GetValue("Q4") : CurrentForm.GetValue("x_Q4");
            if (!Q4.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q4") && !CurrentForm.HasValue("x_Q4")) // DN
                    Q4.Visible = false; // Disable update for API request
                else
                    Q4.SetFormValue(val);
            }

            // Check field name 'Q5' before field var 'x_Q5'
            val = CurrentForm.HasValue("Q5") ? CurrentForm.GetValue("Q5") : CurrentForm.GetValue("x_Q5");
            if (!Q5.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q5") && !CurrentForm.HasValue("x_Q5")) // DN
                    Q5.Visible = false; // Disable update for API request
                else
                    Q5.SetFormValue(val);
            }

            // Check field name 'Section_2' before field var 'x_Section_2'
            val = CurrentForm.HasValue("Section_2") ? CurrentForm.GetValue("Section_2") : CurrentForm.GetValue("x_Section_2");
            if (!Section_2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_2") && !CurrentForm.HasValue("x_Section_2")) // DN
                    Section_2.Visible = false; // Disable update for API request
                else
                    Section_2.SetFormValue(val);
            }

            // Check field name 'Q6' before field var 'x_Q6'
            val = CurrentForm.HasValue("Q6") ? CurrentForm.GetValue("Q6") : CurrentForm.GetValue("x_Q6");
            if (!Q6.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q6") && !CurrentForm.HasValue("x_Q6")) // DN
                    Q6.Visible = false; // Disable update for API request
                else
                    Q6.SetFormValue(val);
            }

            // Check field name 'Q7' before field var 'x_Q7'
            val = CurrentForm.HasValue("Q7") ? CurrentForm.GetValue("Q7") : CurrentForm.GetValue("x_Q7");
            if (!Q7.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q7") && !CurrentForm.HasValue("x_Q7")) // DN
                    Q7.Visible = false; // Disable update for API request
                else
                    Q7.SetFormValue(val);
            }

            // Check field name 'Q8' before field var 'x_Q8'
            val = CurrentForm.HasValue("Q8") ? CurrentForm.GetValue("Q8") : CurrentForm.GetValue("x_Q8");
            if (!Q8.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q8") && !CurrentForm.HasValue("x_Q8")) // DN
                    Q8.Visible = false; // Disable update for API request
                else
                    Q8.SetFormValue(val);
            }

            // Check field name 'Q9' before field var 'x_Q9'
            val = CurrentForm.HasValue("Q9") ? CurrentForm.GetValue("Q9") : CurrentForm.GetValue("x_Q9");
            if (!Q9.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q9") && !CurrentForm.HasValue("x_Q9")) // DN
                    Q9.Visible = false; // Disable update for API request
                else
                    Q9.SetFormValue(val);
            }

            // Check field name 'Q10' before field var 'x_Q10'
            val = CurrentForm.HasValue("Q10") ? CurrentForm.GetValue("Q10") : CurrentForm.GetValue("x_Q10");
            if (!Q10.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q10") && !CurrentForm.HasValue("x_Q10")) // DN
                    Q10.Visible = false; // Disable update for API request
                else
                    Q10.SetFormValue(val);
            }

            // Check field name 'Q11' before field var 'x_Q11'
            val = CurrentForm.HasValue("Q11") ? CurrentForm.GetValue("Q11") : CurrentForm.GetValue("x_Q11");
            if (!Q11.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q11") && !CurrentForm.HasValue("x_Q11")) // DN
                    Q11.Visible = false; // Disable update for API request
                else
                    Q11.SetFormValue(val);
            }

            // Check field name 'Q12' before field var 'x_Q12'
            val = CurrentForm.HasValue("Q12") ? CurrentForm.GetValue("Q12") : CurrentForm.GetValue("x_Q12");
            if (!Q12.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q12") && !CurrentForm.HasValue("x_Q12")) // DN
                    Q12.Visible = false; // Disable update for API request
                else
                    Q12.SetFormValue(val);
            }

            // Check field name 'Q13' before field var 'x_Q13'
            val = CurrentForm.HasValue("Q13") ? CurrentForm.GetValue("Q13") : CurrentForm.GetValue("x_Q13");
            if (!Q13.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q13") && !CurrentForm.HasValue("x_Q13")) // DN
                    Q13.Visible = false; // Disable update for API request
                else
                    Q13.SetFormValue(val);
            }

            // Check field name 'Q14' before field var 'x_Q14'
            val = CurrentForm.HasValue("Q14") ? CurrentForm.GetValue("Q14") : CurrentForm.GetValue("x_Q14");
            if (!Q14.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q14") && !CurrentForm.HasValue("x_Q14")) // DN
                    Q14.Visible = false; // Disable update for API request
                else
                    Q14.SetFormValue(val);
            }

            // Check field name 'Q15' before field var 'x_Q15'
            val = CurrentForm.HasValue("Q15") ? CurrentForm.GetValue("Q15") : CurrentForm.GetValue("x_Q15");
            if (!Q15.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q15") && !CurrentForm.HasValue("x_Q15")) // DN
                    Q15.Visible = false; // Disable update for API request
                else
                    Q15.SetFormValue(val);
            }

            // Check field name 'Section_3' before field var 'x_Section_3'
            val = CurrentForm.HasValue("Section_3") ? CurrentForm.GetValue("Section_3") : CurrentForm.GetValue("x_Section_3");
            if (!Section_3.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_3") && !CurrentForm.HasValue("x_Section_3")) // DN
                    Section_3.Visible = false; // Disable update for API request
                else
                    Section_3.SetFormValue(val);
            }

            // Check field name 'Q16' before field var 'x_Q16'
            val = CurrentForm.HasValue("Q16") ? CurrentForm.GetValue("Q16") : CurrentForm.GetValue("x_Q16");
            if (!Q16.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q16") && !CurrentForm.HasValue("x_Q16")) // DN
                    Q16.Visible = false; // Disable update for API request
                else
                    Q16.SetFormValue(val);
            }

            // Check field name 'Q17' before field var 'x_Q17'
            val = CurrentForm.HasValue("Q17") ? CurrentForm.GetValue("Q17") : CurrentForm.GetValue("x_Q17");
            if (!Q17.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q17") && !CurrentForm.HasValue("x_Q17")) // DN
                    Q17.Visible = false; // Disable update for API request
                else
                    Q17.SetFormValue(val);
            }

            // Check field name 'Q18' before field var 'x_Q18'
            val = CurrentForm.HasValue("Q18") ? CurrentForm.GetValue("Q18") : CurrentForm.GetValue("x_Q18");
            if (!Q18.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q18") && !CurrentForm.HasValue("x_Q18")) // DN
                    Q18.Visible = false; // Disable update for API request
                else
                    Q18.SetFormValue(val);
            }

            // Check field name 'Q19' before field var 'x_Q19'
            val = CurrentForm.HasValue("Q19") ? CurrentForm.GetValue("Q19") : CurrentForm.GetValue("x_Q19");
            if (!Q19.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q19") && !CurrentForm.HasValue("x_Q19")) // DN
                    Q19.Visible = false; // Disable update for API request
                else
                    Q19.SetFormValue(val);
            }

            // Check field name 'Q20' before field var 'x_Q20'
            val = CurrentForm.HasValue("Q20") ? CurrentForm.GetValue("Q20") : CurrentForm.GetValue("x_Q20");
            if (!Q20.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q20") && !CurrentForm.HasValue("x_Q20")) // DN
                    Q20.Visible = false; // Disable update for API request
                else
                    Q20.SetFormValue(val);
            }

            // Check field name 'Q21' before field var 'x_Q21'
            val = CurrentForm.HasValue("Q21") ? CurrentForm.GetValue("Q21") : CurrentForm.GetValue("x_Q21");
            if (!Q21.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q21") && !CurrentForm.HasValue("x_Q21")) // DN
                    Q21.Visible = false; // Disable update for API request
                else
                    Q21.SetFormValue(val);
            }

            // Check field name 'Section_4' before field var 'x_Section_4'
            val = CurrentForm.HasValue("Section_4") ? CurrentForm.GetValue("Section_4") : CurrentForm.GetValue("x_Section_4");
            if (!Section_4.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_4") && !CurrentForm.HasValue("x_Section_4")) // DN
                    Section_4.Visible = false; // Disable update for API request
                else
                    Section_4.SetFormValue(val);
            }

            // Check field name 'Q22' before field var 'x_Q22'
            val = CurrentForm.HasValue("Q22") ? CurrentForm.GetValue("Q22") : CurrentForm.GetValue("x_Q22");
            if (!Q22.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q22") && !CurrentForm.HasValue("x_Q22")) // DN
                    Q22.Visible = false; // Disable update for API request
                else
                    Q22.SetFormValue(val);
            }

            // Check field name 'Q23' before field var 'x_Q23'
            val = CurrentForm.HasValue("Q23") ? CurrentForm.GetValue("Q23") : CurrentForm.GetValue("x_Q23");
            if (!Q23.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q23") && !CurrentForm.HasValue("x_Q23")) // DN
                    Q23.Visible = false; // Disable update for API request
                else
                    Q23.SetFormValue(val);
            }

            // Check field name 'Q24' before field var 'x_Q24'
            val = CurrentForm.HasValue("Q24") ? CurrentForm.GetValue("Q24") : CurrentForm.GetValue("x_Q24");
            if (!Q24.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q24") && !CurrentForm.HasValue("x_Q24")) // DN
                    Q24.Visible = false; // Disable update for API request
                else
                    Q24.SetFormValue(val);
            }

            // Check field name 'Q25' before field var 'x_Q25'
            val = CurrentForm.HasValue("Q25") ? CurrentForm.GetValue("Q25") : CurrentForm.GetValue("x_Q25");
            if (!Q25.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q25") && !CurrentForm.HasValue("x_Q25")) // DN
                    Q25.Visible = false; // Disable update for API request
                else
                    Q25.SetFormValue(val);
            }

            // Check field name 'Q26' before field var 'x_Q26'
            val = CurrentForm.HasValue("Q26") ? CurrentForm.GetValue("Q26") : CurrentForm.GetValue("x_Q26");
            if (!Q26.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q26") && !CurrentForm.HasValue("x_Q26")) // DN
                    Q26.Visible = false; // Disable update for API request
                else
                    Q26.SetFormValue(val);
            }

            // Check field name 'Section_5' before field var 'x_Section_5'
            val = CurrentForm.HasValue("Section_5") ? CurrentForm.GetValue("Section_5") : CurrentForm.GetValue("x_Section_5");
            if (!Section_5.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_5") && !CurrentForm.HasValue("x_Section_5")) // DN
                    Section_5.Visible = false; // Disable update for API request
                else
                    Section_5.SetFormValue(val);
            }

            // Check field name 'Q27' before field var 'x_Q27'
            val = CurrentForm.HasValue("Q27") ? CurrentForm.GetValue("Q27") : CurrentForm.GetValue("x_Q27");
            if (!Q27.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q27") && !CurrentForm.HasValue("x_Q27")) // DN
                    Q27.Visible = false; // Disable update for API request
                else
                    Q27.SetFormValue(val);
            }

            // Check field name 'Q28' before field var 'x_Q28'
            val = CurrentForm.HasValue("Q28") ? CurrentForm.GetValue("Q28") : CurrentForm.GetValue("x_Q28");
            if (!Q28.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q28") && !CurrentForm.HasValue("x_Q28")) // DN
                    Q28.Visible = false; // Disable update for API request
                else
                    Q28.SetFormValue(val);
            }

            // Check field name 'Q29' before field var 'x_Q29'
            val = CurrentForm.HasValue("Q29") ? CurrentForm.GetValue("Q29") : CurrentForm.GetValue("x_Q29");
            if (!Q29.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q29") && !CurrentForm.HasValue("x_Q29")) // DN
                    Q29.Visible = false; // Disable update for API request
                else
                    Q29.SetFormValue(val);
            }

            // Check field name 'Q30' before field var 'x_Q30'
            val = CurrentForm.HasValue("Q30") ? CurrentForm.GetValue("Q30") : CurrentForm.GetValue("x_Q30");
            if (!Q30.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q30") && !CurrentForm.HasValue("x_Q30")) // DN
                    Q30.Visible = false; // Disable update for API request
                else
                    Q30.SetFormValue(val);
            }

            // Check field name 'Q31' before field var 'x_Q31'
            val = CurrentForm.HasValue("Q31") ? CurrentForm.GetValue("Q31") : CurrentForm.GetValue("x_Q31");
            if (!Q31.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q31") && !CurrentForm.HasValue("x_Q31")) // DN
                    Q31.Visible = false; // Disable update for API request
                else
                    Q31.SetFormValue(val);
            }

            // Check field name 'Q32' before field var 'x_Q32'
            val = CurrentForm.HasValue("Q32") ? CurrentForm.GetValue("Q32") : CurrentForm.GetValue("x_Q32");
            if (!Q32.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q32") && !CurrentForm.HasValue("x_Q32")) // DN
                    Q32.Visible = false; // Disable update for API request
                else
                    Q32.SetFormValue(val);
            }

            // Check field name 'Q33' before field var 'x_Q33'
            val = CurrentForm.HasValue("Q33") ? CurrentForm.GetValue("Q33") : CurrentForm.GetValue("x_Q33");
            if (!Q33.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q33") && !CurrentForm.HasValue("x_Q33")) // DN
                    Q33.Visible = false; // Disable update for API request
                else
                    Q33.SetFormValue(val);
            }

            // Check field name 'Q34' before field var 'x_Q34'
            val = CurrentForm.HasValue("Q34") ? CurrentForm.GetValue("Q34") : CurrentForm.GetValue("x_Q34");
            if (!Q34.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q34") && !CurrentForm.HasValue("x_Q34")) // DN
                    Q34.Visible = false; // Disable update for API request
                else
                    Q34.SetFormValue(val);
            }

            // Check field name 'Q35' before field var 'x_Q35'
            val = CurrentForm.HasValue("Q35") ? CurrentForm.GetValue("Q35") : CurrentForm.GetValue("x_Q35");
            if (!Q35.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q35") && !CurrentForm.HasValue("x_Q35")) // DN
                    Q35.Visible = false; // Disable update for API request
                else
                    Q35.SetFormValue(val);
            }

            // Check field name 'Section_6' before field var 'x_Section_6'
            val = CurrentForm.HasValue("Section_6") ? CurrentForm.GetValue("Section_6") : CurrentForm.GetValue("x_Section_6");
            if (!Section_6.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_6") && !CurrentForm.HasValue("x_Section_6")) // DN
                    Section_6.Visible = false; // Disable update for API request
                else
                    Section_6.SetFormValue(val);
            }

            // Check field name 'Q36' before field var 'x_Q36'
            val = CurrentForm.HasValue("Q36") ? CurrentForm.GetValue("Q36") : CurrentForm.GetValue("x_Q36");
            if (!Q36.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q36") && !CurrentForm.HasValue("x_Q36")) // DN
                    Q36.Visible = false; // Disable update for API request
                else
                    Q36.SetFormValue(val);
            }

            // Check field name 'Q37' before field var 'x_Q37'
            val = CurrentForm.HasValue("Q37") ? CurrentForm.GetValue("Q37") : CurrentForm.GetValue("x_Q37");
            if (!Q37.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q37") && !CurrentForm.HasValue("x_Q37")) // DN
                    Q37.Visible = false; // Disable update for API request
                else
                    Q37.SetFormValue(val);
            }

            // Check field name 'Q38' before field var 'x_Q38'
            val = CurrentForm.HasValue("Q38") ? CurrentForm.GetValue("Q38") : CurrentForm.GetValue("x_Q38");
            if (!Q38.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q38") && !CurrentForm.HasValue("x_Q38")) // DN
                    Q38.Visible = false; // Disable update for API request
                else
                    Q38.SetFormValue(val);
            }

            // Check field name 'Q39' before field var 'x_Q39'
            val = CurrentForm.HasValue("Q39") ? CurrentForm.GetValue("Q39") : CurrentForm.GetValue("x_Q39");
            if (!Q39.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q39") && !CurrentForm.HasValue("x_Q39")) // DN
                    Q39.Visible = false; // Disable update for API request
                else
                    Q39.SetFormValue(val);
            }

            // Check field name 'Q40' before field var 'x_Q40'
            val = CurrentForm.HasValue("Q40") ? CurrentForm.GetValue("Q40") : CurrentForm.GetValue("x_Q40");
            if (!Q40.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q40") && !CurrentForm.HasValue("x_Q40")) // DN
                    Q40.Visible = false; // Disable update for API request
                else
                    Q40.SetFormValue(val);
            }

            // Check field name 'Q41' before field var 'x_Q41'
            val = CurrentForm.HasValue("Q41") ? CurrentForm.GetValue("Q41") : CurrentForm.GetValue("x_Q41");
            if (!Q41.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q41") && !CurrentForm.HasValue("x_Q41")) // DN
                    Q41.Visible = false; // Disable update for API request
                else
                    Q41.SetFormValue(val);
            }

            // Check field name 'Q42' before field var 'x_Q42'
            val = CurrentForm.HasValue("Q42") ? CurrentForm.GetValue("Q42") : CurrentForm.GetValue("x_Q42");
            if (!Q42.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q42") && !CurrentForm.HasValue("x_Q42")) // DN
                    Q42.Visible = false; // Disable update for API request
                else
                    Q42.SetFormValue(val);
            }

            // Check field name 'Q43' before field var 'x_Q43'
            val = CurrentForm.HasValue("Q43") ? CurrentForm.GetValue("Q43") : CurrentForm.GetValue("x_Q43");
            if (!Q43.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q43") && !CurrentForm.HasValue("x_Q43")) // DN
                    Q43.Visible = false; // Disable update for API request
                else
                    Q43.SetFormValue(val);
            }

            // Check field name 'Section_7' before field var 'x_Section_7'
            val = CurrentForm.HasValue("Section_7") ? CurrentForm.GetValue("Section_7") : CurrentForm.GetValue("x_Section_7");
            if (!Section_7.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_7") && !CurrentForm.HasValue("x_Section_7")) // DN
                    Section_7.Visible = false; // Disable update for API request
                else
                    Section_7.SetFormValue(val);
            }

            // Check field name 'Q44' before field var 'x_Q44'
            val = CurrentForm.HasValue("Q44") ? CurrentForm.GetValue("Q44") : CurrentForm.GetValue("x_Q44");
            if (!Q44.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q44") && !CurrentForm.HasValue("x_Q44")) // DN
                    Q44.Visible = false; // Disable update for API request
                else
                    Q44.SetFormValue(val);
            }

            // Check field name 'Q45' before field var 'x_Q45'
            val = CurrentForm.HasValue("Q45") ? CurrentForm.GetValue("Q45") : CurrentForm.GetValue("x_Q45");
            if (!Q45.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q45") && !CurrentForm.HasValue("x_Q45")) // DN
                    Q45.Visible = false; // Disable update for API request
                else
                    Q45.SetFormValue(val);
            }

            // Check field name 'Q46' before field var 'x_Q46'
            val = CurrentForm.HasValue("Q46") ? CurrentForm.GetValue("Q46") : CurrentForm.GetValue("x_Q46");
            if (!Q46.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q46") && !CurrentForm.HasValue("x_Q46")) // DN
                    Q46.Visible = false; // Disable update for API request
                else
                    Q46.SetFormValue(val);
            }

            // Check field name 'Q47' before field var 'x_Q47'
            val = CurrentForm.HasValue("Q47") ? CurrentForm.GetValue("Q47") : CurrentForm.GetValue("x_Q47");
            if (!Q47.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q47") && !CurrentForm.HasValue("x_Q47")) // DN
                    Q47.Visible = false; // Disable update for API request
                else
                    Q47.SetFormValue(val);
            }

            // Check field name 'Q48' before field var 'x_Q48'
            val = CurrentForm.HasValue("Q48") ? CurrentForm.GetValue("Q48") : CurrentForm.GetValue("x_Q48");
            if (!Q48.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q48") && !CurrentForm.HasValue("x_Q48")) // DN
                    Q48.Visible = false; // Disable update for API request
                else
                    Q48.SetFormValue(val);
            }

            // Check field name 'Q49' before field var 'x_Q49'
            val = CurrentForm.HasValue("Q49") ? CurrentForm.GetValue("Q49") : CurrentForm.GetValue("x_Q49");
            if (!Q49.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q49") && !CurrentForm.HasValue("x_Q49")) // DN
                    Q49.Visible = false; // Disable update for API request
                else
                    Q49.SetFormValue(val);
            }

            // Check field name 'Q50' before field var 'x_Q50'
            val = CurrentForm.HasValue("Q50") ? CurrentForm.GetValue("Q50") : CurrentForm.GetValue("x_Q50");
            if (!Q50.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q50") && !CurrentForm.HasValue("x_Q50")) // DN
                    Q50.Visible = false; // Disable update for API request
                else
                    Q50.SetFormValue(val);
            }

            // Check field name 'Section_8' before field var 'x_Section_8'
            val = CurrentForm.HasValue("Section_8") ? CurrentForm.GetValue("Section_8") : CurrentForm.GetValue("x_Section_8");
            if (!Section_8.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_8") && !CurrentForm.HasValue("x_Section_8")) // DN
                    Section_8.Visible = false; // Disable update for API request
                else
                    Section_8.SetFormValue(val);
            }

            // Check field name 'Q51' before field var 'x_Q51'
            val = CurrentForm.HasValue("Q51") ? CurrentForm.GetValue("Q51") : CurrentForm.GetValue("x_Q51");
            if (!Q51.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q51") && !CurrentForm.HasValue("x_Q51")) // DN
                    Q51.Visible = false; // Disable update for API request
                else
                    Q51.SetFormValue(val);
            }

            // Check field name 'Q52' before field var 'x_Q52'
            val = CurrentForm.HasValue("Q52") ? CurrentForm.GetValue("Q52") : CurrentForm.GetValue("x_Q52");
            if (!Q52.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q52") && !CurrentForm.HasValue("x_Q52")) // DN
                    Q52.Visible = false; // Disable update for API request
                else
                    Q52.SetFormValue(val);
            }

            // Check field name 'Q53' before field var 'x_Q53'
            val = CurrentForm.HasValue("Q53") ? CurrentForm.GetValue("Q53") : CurrentForm.GetValue("x_Q53");
            if (!Q53.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q53") && !CurrentForm.HasValue("x_Q53")) // DN
                    Q53.Visible = false; // Disable update for API request
                else
                    Q53.SetFormValue(val);
            }

            // Check field name 'Q54' before field var 'x_Q54'
            val = CurrentForm.HasValue("Q54") ? CurrentForm.GetValue("Q54") : CurrentForm.GetValue("x_Q54");
            if (!Q54.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q54") && !CurrentForm.HasValue("x_Q54")) // DN
                    Q54.Visible = false; // Disable update for API request
                else
                    Q54.SetFormValue(val);
            }

            // Check field name 'Q55' before field var 'x_Q55'
            val = CurrentForm.HasValue("Q55") ? CurrentForm.GetValue("Q55") : CurrentForm.GetValue("x_Q55");
            if (!Q55.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q55") && !CurrentForm.HasValue("x_Q55")) // DN
                    Q55.Visible = false; // Disable update for API request
                else
                    Q55.SetFormValue(val);
            }

            // Check field name 'Section_9' before field var 'x_Section_9'
            val = CurrentForm.HasValue("Section_9") ? CurrentForm.GetValue("Section_9") : CurrentForm.GetValue("x_Section_9");
            if (!Section_9.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_9") && !CurrentForm.HasValue("x_Section_9")) // DN
                    Section_9.Visible = false; // Disable update for API request
                else
                    Section_9.SetFormValue(val);
            }

            // Check field name 'Q56' before field var 'x_Q56'
            val = CurrentForm.HasValue("Q56") ? CurrentForm.GetValue("Q56") : CurrentForm.GetValue("x_Q56");
            if (!Q56.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q56") && !CurrentForm.HasValue("x_Q56")) // DN
                    Q56.Visible = false; // Disable update for API request
                else
                    Q56.SetFormValue(val);
            }

            // Check field name 'Q57' before field var 'x_Q57'
            val = CurrentForm.HasValue("Q57") ? CurrentForm.GetValue("Q57") : CurrentForm.GetValue("x_Q57");
            if (!Q57.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q57") && !CurrentForm.HasValue("x_Q57")) // DN
                    Q57.Visible = false; // Disable update for API request
                else
                    Q57.SetFormValue(val);
            }

            // Check field name 'Q58' before field var 'x_Q58'
            val = CurrentForm.HasValue("Q58") ? CurrentForm.GetValue("Q58") : CurrentForm.GetValue("x_Q58");
            if (!Q58.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q58") && !CurrentForm.HasValue("x_Q58")) // DN
                    Q58.Visible = false; // Disable update for API request
                else
                    Q58.SetFormValue(val);
            }

            // Check field name 'Q59' before field var 'x_Q59'
            val = CurrentForm.HasValue("Q59") ? CurrentForm.GetValue("Q59") : CurrentForm.GetValue("x_Q59");
            if (!Q59.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q59") && !CurrentForm.HasValue("x_Q59")) // DN
                    Q59.Visible = false; // Disable update for API request
                else
                    Q59.SetFormValue(val);
            }

            // Check field name 'Q60' before field var 'x_Q60'
            val = CurrentForm.HasValue("Q60") ? CurrentForm.GetValue("Q60") : CurrentForm.GetValue("x_Q60");
            if (!Q60.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q60") && !CurrentForm.HasValue("x_Q60")) // DN
                    Q60.Visible = false; // Disable update for API request
                else
                    Q60.SetFormValue(val);
            }

            // Check field name 'Section_10' before field var 'x_Section_10'
            val = CurrentForm.HasValue("Section_10") ? CurrentForm.GetValue("Section_10") : CurrentForm.GetValue("x_Section_10");
            if (!Section_10.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_10") && !CurrentForm.HasValue("x_Section_10")) // DN
                    Section_10.Visible = false; // Disable update for API request
                else
                    Section_10.SetFormValue(val);
            }

            // Check field name 'Q61' before field var 'x_Q61'
            val = CurrentForm.HasValue("Q61") ? CurrentForm.GetValue("Q61") : CurrentForm.GetValue("x_Q61");
            if (!Q61.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q61") && !CurrentForm.HasValue("x_Q61")) // DN
                    Q61.Visible = false; // Disable update for API request
                else
                    Q61.SetFormValue(val);
            }

            // Check field name 'Q62' before field var 'x_Q62'
            val = CurrentForm.HasValue("Q62") ? CurrentForm.GetValue("Q62") : CurrentForm.GetValue("x_Q62");
            if (!Q62.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q62") && !CurrentForm.HasValue("x_Q62")) // DN
                    Q62.Visible = false; // Disable update for API request
                else
                    Q62.SetFormValue(val);
            }

            // Check field name 'Q63' before field var 'x_Q63'
            val = CurrentForm.HasValue("Q63") ? CurrentForm.GetValue("Q63") : CurrentForm.GetValue("x_Q63");
            if (!Q63.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q63") && !CurrentForm.HasValue("x_Q63")) // DN
                    Q63.Visible = false; // Disable update for API request
                else
                    Q63.SetFormValue(val);
            }

            // Check field name 'Q64' before field var 'x_Q64'
            val = CurrentForm.HasValue("Q64") ? CurrentForm.GetValue("Q64") : CurrentForm.GetValue("x_Q64");
            if (!Q64.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q64") && !CurrentForm.HasValue("x_Q64")) // DN
                    Q64.Visible = false; // Disable update for API request
                else
                    Q64.SetFormValue(val);
            }

            // Check field name 'Q65' before field var 'x_Q65'
            val = CurrentForm.HasValue("Q65") ? CurrentForm.GetValue("Q65") : CurrentForm.GetValue("x_Q65");
            if (!Q65.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q65") && !CurrentForm.HasValue("x_Q65")) // DN
                    Q65.Visible = false; // Disable update for API request
                else
                    Q65.SetFormValue(val);
            }

            // Check field name 'Q66' before field var 'x_Q66'
            val = CurrentForm.HasValue("Q66") ? CurrentForm.GetValue("Q66") : CurrentForm.GetValue("x_Q66");
            if (!Q66.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q66") && !CurrentForm.HasValue("x_Q66")) // DN
                    Q66.Visible = false; // Disable update for API request
                else
                    Q66.SetFormValue(val);
            }

            // Check field name 'Section_11' before field var 'x_Section_11'
            val = CurrentForm.HasValue("Section_11") ? CurrentForm.GetValue("Section_11") : CurrentForm.GetValue("x_Section_11");
            if (!Section_11.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Section_11") && !CurrentForm.HasValue("x_Section_11")) // DN
                    Section_11.Visible = false; // Disable update for API request
                else
                    Section_11.SetFormValue(val);
            }

            // Check field name 'Q67' before field var 'x_Q67'
            val = CurrentForm.HasValue("Q67") ? CurrentForm.GetValue("Q67") : CurrentForm.GetValue("x_Q67");
            if (!Q67.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q67") && !CurrentForm.HasValue("x_Q67")) // DN
                    Q67.Visible = false; // Disable update for API request
                else
                    Q67.SetFormValue(val);
            }

            // Check field name 'Q68' before field var 'x_Q68'
            val = CurrentForm.HasValue("Q68") ? CurrentForm.GetValue("Q68") : CurrentForm.GetValue("x_Q68");
            if (!Q68.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q68") && !CurrentForm.HasValue("x_Q68")) // DN
                    Q68.Visible = false; // Disable update for API request
                else
                    Q68.SetFormValue(val);
            }

            // Check field name 'Q69' before field var 'x_Q69'
            val = CurrentForm.HasValue("Q69") ? CurrentForm.GetValue("Q69") : CurrentForm.GetValue("x_Q69");
            if (!Q69.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q69") && !CurrentForm.HasValue("x_Q69")) // DN
                    Q69.Visible = false; // Disable update for API request
                else
                    Q69.SetFormValue(val);
            }

            // Check field name 'Q70' before field var 'x_Q70'
            val = CurrentForm.HasValue("Q70") ? CurrentForm.GetValue("Q70") : CurrentForm.GetValue("x_Q70");
            if (!Q70.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Q70") && !CurrentForm.HasValue("x_Q70")) // DN
                    Q70.Visible = false; // Disable update for API request
                else
                    Q70.SetFormValue(val);
            }

            // Check field name 'Notes_3' before field var 'x_Notes_3'
            val = CurrentForm.HasValue("Notes_3") ? CurrentForm.GetValue("Notes_3") : CurrentForm.GetValue("x_Notes_3");
            if (!Notes_3.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Notes_3") && !CurrentForm.HasValue("x_Notes_3")) // DN
                    Notes_3.Visible = false; // Disable update for API request
                else
                    Notes_3.SetFormValue(val);
            }

            // Check field name 'Student_Signature' before field var 'x_Student_Signature'
            val = CurrentForm.HasValue("Student_Signature") ? CurrentForm.GetValue("Student_Signature") : CurrentForm.GetValue("x_Student_Signature");
            if (!Student_Signature.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Student_Signature") && !CurrentForm.HasValue("x_Student_Signature")) // DN
                    Student_Signature.Visible = false; // Disable update for API request
                else
                    Student_Signature.SetFormValue(val);
            }

            // Check field name 'Examiner_Signature' before field var 'x_Examiner_Signature'
            val = CurrentForm.HasValue("Examiner_Signature") ? CurrentForm.GetValue("Examiner_Signature") : CurrentForm.GetValue("x_Examiner_Signature");
            if (!Examiner_Signature.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Examiner_Signature") && !CurrentForm.HasValue("x_Examiner_Signature")) // DN
                    Examiner_Signature.Visible = false; // Disable update for API request
                else
                    Examiner_Signature.SetFormValue(val);
            }

            // Check field name 'Retake' before field var 'x_Retake'
            val = CurrentForm.HasValue("Retake") ? CurrentForm.GetValue("Retake") : CurrentForm.GetValue("x_Retake");
            if (!Retake.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Retake") && !CurrentForm.HasValue("x_Retake")) // DN
                    Retake.Visible = false; // Disable update for API request
                else
                    Retake.SetFormValue(val);
            }

            // Check field name 'AbsherApptNbr' before field var 'x_AbsherApptNbr'
            val = CurrentForm.HasValue("AbsherApptNbr") ? CurrentForm.GetValue("AbsherApptNbr") : CurrentForm.GetValue("x_AbsherApptNbr");
            if (!AbsherApptNbr.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AbsherApptNbr") && !CurrentForm.HasValue("x_AbsherApptNbr")) // DN
                    AbsherApptNbr.Visible = false; // Disable update for API request
                else
                    AbsherApptNbr.SetFormValue(val);
            }

            // Check field name 'IsDrivingexperience' before field var 'x_IsDrivingexperience'
            val = CurrentForm.HasValue("IsDrivingexperience") ? CurrentForm.GetValue("IsDrivingexperience") : CurrentForm.GetValue("x_IsDrivingexperience");
            if (!IsDrivingexperience.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDrivingexperience") && !CurrentForm.HasValue("x_IsDrivingexperience")) // DN
                    IsDrivingexperience.Visible = false; // Disable update for API request
                else
                    IsDrivingexperience.SetFormValue(val);
            }

            // Check field name 'date_Birth_Hijri' before field var 'x_date_Birth_Hijri'
            val = CurrentForm.HasValue("date_Birth_Hijri") ? CurrentForm.GetValue("date_Birth_Hijri") : CurrentForm.GetValue("x_date_Birth_Hijri");
            if (!date_Birth_Hijri.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Birth_Hijri") && !CurrentForm.HasValue("x_date_Birth_Hijri")) // DN
                    date_Birth_Hijri.Visible = false; // Disable update for API request
                else
                    date_Birth_Hijri.SetFormValue(val);
            }

            // Check field name 'date_Birth' before field var 'x_date_Birth'
            val = CurrentForm.HasValue("date_Birth") ? CurrentForm.GetValue("date_Birth") : CurrentForm.GetValue("x_date_Birth");
            if (!date_Birth.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Birth") && !CurrentForm.HasValue("x_date_Birth")) // DN
                    date_Birth.Visible = false; // Disable update for API request
                else
                    date_Birth.SetFormValue(val);
                date_Birth.CurrentValue = UnformatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern);
            }

            // Check field name 'str_Email' before field var 'x_str_Email'
            val = CurrentForm.HasValue("str_Email") ? CurrentForm.GetValue("str_Email") : CurrentForm.GetValue("x_str_Email");
            if (!str_Email.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Email") && !CurrentForm.HasValue("x_str_Email")) // DN
                    str_Email.Visible = false; // Disable update for API request
                else
                    str_Email.SetFormValue(val);
            }

            // Check field name 'UserlevelID' before field var 'x_UserlevelID'
            val = CurrentForm.HasValue("UserlevelID") ? CurrentForm.GetValue("UserlevelID") : CurrentForm.GetValue("x_UserlevelID");
            if (!UserlevelID.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("UserlevelID") && !CurrentForm.HasValue("x_UserlevelID")) // DN
                    UserlevelID.Visible = false; // Disable update for API request
                else
                    UserlevelID.SetFormValue(val);
            }

            // Check field name 'intEvaluationType' before field var 'x_intEvaluationType'
            val = CurrentForm.HasValue("intEvaluationType") ? CurrentForm.GetValue("intEvaluationType") : CurrentForm.GetValue("x_intEvaluationType");
            if (!intEvaluationType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("intEvaluationType") && !CurrentForm.HasValue("x_intEvaluationType")) // DN
                    intEvaluationType.Visible = false; // Disable update for API request
                else
                    intEvaluationType.SetFormValue(val, true, validate);
            }

            // Check field name 'Eval_ID' before field var 'x_Eval_ID'
            val = CurrentForm.HasValue("Eval_ID") ? CurrentForm.GetValue("Eval_ID") : CurrentForm.GetValue("x_Eval_ID");
            if (!Eval_ID.IsDetailKey)
                Eval_ID.SetFormValue(val);
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            Eval_ID.CurrentValue = Eval_ID.FormValue;
            str_Full_Name_Hdr.CurrentValue = str_Full_Name_Hdr.FormValue;
            NationalID.CurrentValue = NationalID.FormValue;
            str_Cell_Phone.CurrentValue = str_Cell_Phone.FormValue;
            intDrivinglicenseType.CurrentValue = intDrivinglicenseType.FormValue;
            Date_Entered.CurrentValue = Date_Entered.FormValue;
            Date_Entered.CurrentValue = UnformatDateTime(Date_Entered.CurrentValue, Date_Entered.FormatPattern);
            Section_1.CurrentValue = Section_1.FormValue;
            Q1.CurrentValue = Q1.FormValue;
            Q2.CurrentValue = Q2.FormValue;
            Q3.CurrentValue = Q3.FormValue;
            Q4.CurrentValue = Q4.FormValue;
            Q5.CurrentValue = Q5.FormValue;
            Section_2.CurrentValue = Section_2.FormValue;
            Q6.CurrentValue = Q6.FormValue;
            Q7.CurrentValue = Q7.FormValue;
            Q8.CurrentValue = Q8.FormValue;
            Q9.CurrentValue = Q9.FormValue;
            Q10.CurrentValue = Q10.FormValue;
            Q11.CurrentValue = Q11.FormValue;
            Q12.CurrentValue = Q12.FormValue;
            Q13.CurrentValue = Q13.FormValue;
            Q14.CurrentValue = Q14.FormValue;
            Q15.CurrentValue = Q15.FormValue;
            Section_3.CurrentValue = Section_3.FormValue;
            Q16.CurrentValue = Q16.FormValue;
            Q17.CurrentValue = Q17.FormValue;
            Q18.CurrentValue = Q18.FormValue;
            Q19.CurrentValue = Q19.FormValue;
            Q20.CurrentValue = Q20.FormValue;
            Q21.CurrentValue = Q21.FormValue;
            Section_4.CurrentValue = Section_4.FormValue;
            Q22.CurrentValue = Q22.FormValue;
            Q23.CurrentValue = Q23.FormValue;
            Q24.CurrentValue = Q24.FormValue;
            Q25.CurrentValue = Q25.FormValue;
            Q26.CurrentValue = Q26.FormValue;
            Section_5.CurrentValue = Section_5.FormValue;
            Q27.CurrentValue = Q27.FormValue;
            Q28.CurrentValue = Q28.FormValue;
            Q29.CurrentValue = Q29.FormValue;
            Q30.CurrentValue = Q30.FormValue;
            Q31.CurrentValue = Q31.FormValue;
            Q32.CurrentValue = Q32.FormValue;
            Q33.CurrentValue = Q33.FormValue;
            Q34.CurrentValue = Q34.FormValue;
            Q35.CurrentValue = Q35.FormValue;
            Section_6.CurrentValue = Section_6.FormValue;
            Q36.CurrentValue = Q36.FormValue;
            Q37.CurrentValue = Q37.FormValue;
            Q38.CurrentValue = Q38.FormValue;
            Q39.CurrentValue = Q39.FormValue;
            Q40.CurrentValue = Q40.FormValue;
            Q41.CurrentValue = Q41.FormValue;
            Q42.CurrentValue = Q42.FormValue;
            Q43.CurrentValue = Q43.FormValue;
            Section_7.CurrentValue = Section_7.FormValue;
            Q44.CurrentValue = Q44.FormValue;
            Q45.CurrentValue = Q45.FormValue;
            Q46.CurrentValue = Q46.FormValue;
            Q47.CurrentValue = Q47.FormValue;
            Q48.CurrentValue = Q48.FormValue;
            Q49.CurrentValue = Q49.FormValue;
            Q50.CurrentValue = Q50.FormValue;
            Section_8.CurrentValue = Section_8.FormValue;
            Q51.CurrentValue = Q51.FormValue;
            Q52.CurrentValue = Q52.FormValue;
            Q53.CurrentValue = Q53.FormValue;
            Q54.CurrentValue = Q54.FormValue;
            Q55.CurrentValue = Q55.FormValue;
            Section_9.CurrentValue = Section_9.FormValue;
            Q56.CurrentValue = Q56.FormValue;
            Q57.CurrentValue = Q57.FormValue;
            Q58.CurrentValue = Q58.FormValue;
            Q59.CurrentValue = Q59.FormValue;
            Q60.CurrentValue = Q60.FormValue;
            Section_10.CurrentValue = Section_10.FormValue;
            Q61.CurrentValue = Q61.FormValue;
            Q62.CurrentValue = Q62.FormValue;
            Q63.CurrentValue = Q63.FormValue;
            Q64.CurrentValue = Q64.FormValue;
            Q65.CurrentValue = Q65.FormValue;
            Q66.CurrentValue = Q66.FormValue;
            Section_11.CurrentValue = Section_11.FormValue;
            Q67.CurrentValue = Q67.FormValue;
            Q68.CurrentValue = Q68.FormValue;
            Q69.CurrentValue = Q69.FormValue;
            Q70.CurrentValue = Q70.FormValue;
            Notes_3.CurrentValue = Notes_3.FormValue;
            Student_Signature.CurrentValue = Student_Signature.FormValue;
            Examiner_Signature.CurrentValue = Examiner_Signature.FormValue;
            Retake.CurrentValue = Retake.FormValue;
            AbsherApptNbr.CurrentValue = AbsherApptNbr.FormValue;
            IsDrivingexperience.CurrentValue = IsDrivingexperience.FormValue;
            date_Birth_Hijri.CurrentValue = date_Birth_Hijri.FormValue;
            date_Birth.CurrentValue = date_Birth.FormValue;
            date_Birth.CurrentValue = UnformatDateTime(date_Birth.CurrentValue, date_Birth.FormatPattern);
            str_Email.CurrentValue = str_Email.FormValue;
            UserlevelID.CurrentValue = UserlevelID.FormValue;
            intEvaluationType.CurrentValue = intEvaluationType.FormValue;
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

            // Check if valid User ID
            if (res) {
                res = ShowOptionLink("edit");
                if (!res)
                    FailureMessage = DeniedMessage();
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
            AssessmentID.SetDbValue(row["AssessmentID"]);
            str_Full_Name_Hdr.SetDbValue(row["str_Full_Name_Hdr"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_Cell_Phone.SetDbValue(row["str_Cell_Phone"]);
            int_Student_ID.SetDbValue(row["int_Student_ID"]);
            intDrivinglicenseType.SetDbValue(row["intDrivinglicenseType"]);
            Date_Entered.SetDbValue(row["Date_Entered"]);
            Examination_Number.SetDbValue(row["Examination_Number"]);
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
            Q60.SetDbValue((ConvertToBool(row["Q60"]) ? "1" : "0"));
            Section_10.SetDbValue(row["Section_10"]);
            Q61.SetDbValue((ConvertToBool(row["Q61"]) ? "1" : "0"));
            Q62.SetDbValue((ConvertToBool(row["Q62"]) ? "1" : "0"));
            Q63.SetDbValue((ConvertToBool(row["Q63"]) ? "1" : "0"));
            Q64.SetDbValue((ConvertToBool(row["Q64"]) ? "1" : "0"));
            Q65.SetDbValue((ConvertToBool(row["Q65"]) ? "1" : "0"));
            Q66.SetDbValue((ConvertToBool(row["Q66"]) ? "1" : "0"));
            Section_11.SetDbValue(row["Section_11"]);
            Q67.SetDbValue((ConvertToBool(row["Q67"]) ? "1" : "0"));
            Q68.SetDbValue((ConvertToBool(row["Q68"]) ? "1" : "0"));
            Q69.SetDbValue((ConvertToBool(row["Q69"]) ? "1" : "0"));
            Q70.SetDbValue((ConvertToBool(row["Q70"]) ? "1" : "0"));
            Notes_3.SetDbValue(row["Notes_3"]);
            Student_Signature.SetDbValue(row["Student_Signature"]);
            Examiner_Signature.SetDbValue(row["Examiner_Signature"]);
            str_Username.SetDbValue(row["str_Username"]);
            Retake.SetDbValue((ConvertToBool(row["Retake"]) ? "1" : "0"));
            AbsherApptNbr.SetDbValue(row["AbsherApptNbr"]);
            IsDrivingexperience.SetDbValue((ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"));
            date_Birth_Hijri.SetDbValue(row["date_Birth_Hijri"]);
            date_Birth.SetDbValue(row["date_Birth"]);
            str_Email.SetDbValue(row["str_Email"]);
            UserlevelID.SetDbValue(row["UserlevelID"]);
            Assigned_int_Package_Id.SetDbValue(row["Assigned_int_Package_Id"]);
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
            DriveTypelink.SetDbValue(row["DriveTypelink"]);
            Evaluation_Score.SetDbValue(row["Evaluation_Score"]);
            Immediate_Failure_Score.SetDbValue(row["Immediate_Failure_Score"]);
            Required_Program.SetDbValue(row["Required_Program"]);
            Price.SetDbValue(row["Price"]);
            intEvaluationType.SetDbValue(row["intEvaluationType"]);
            Institution.SetDbValue(row["Institution"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("Eval_ID", Eval_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentID", AssessmentID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Full_Name_Hdr", str_Full_Name_Hdr.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Cell_Phone", str_Cell_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_ID", int_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("intDrivinglicenseType", intDrivinglicenseType.DefaultValue ?? DbNullValue); // DN
            row.Add("Date_Entered", Date_Entered.DefaultValue ?? DbNullValue); // DN
            row.Add("Examination_Number", Examination_Number.DefaultValue ?? DbNullValue); // DN
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
            row.Add("Q60", Q60.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_10", Section_10.DefaultValue ?? DbNullValue); // DN
            row.Add("Q61", Q61.DefaultValue ?? DbNullValue); // DN
            row.Add("Q62", Q62.DefaultValue ?? DbNullValue); // DN
            row.Add("Q63", Q63.DefaultValue ?? DbNullValue); // DN
            row.Add("Q64", Q64.DefaultValue ?? DbNullValue); // DN
            row.Add("Q65", Q65.DefaultValue ?? DbNullValue); // DN
            row.Add("Q66", Q66.DefaultValue ?? DbNullValue); // DN
            row.Add("Section_11", Section_11.DefaultValue ?? DbNullValue); // DN
            row.Add("Q67", Q67.DefaultValue ?? DbNullValue); // DN
            row.Add("Q68", Q68.DefaultValue ?? DbNullValue); // DN
            row.Add("Q69", Q69.DefaultValue ?? DbNullValue); // DN
            row.Add("Q70", Q70.DefaultValue ?? DbNullValue); // DN
            row.Add("Notes_3", Notes_3.DefaultValue ?? DbNullValue); // DN
            row.Add("Student_Signature", Student_Signature.DefaultValue ?? DbNullValue); // DN
            row.Add("Examiner_Signature", Examiner_Signature.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("Retake", Retake.DefaultValue ?? DbNullValue); // DN
            row.Add("AbsherApptNbr", AbsherApptNbr.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDrivingexperience", IsDrivingexperience.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth_Hijri", date_Birth_Hijri.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth", date_Birth.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email", str_Email.DefaultValue ?? DbNullValue); // DN
            row.Add("UserlevelID", UserlevelID.DefaultValue ?? DbNullValue); // DN
            row.Add("Assigned_int_Package_Id", Assigned_int_Package_Id.DefaultValue ?? DbNullValue); // DN
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
            row.Add("DriveTypelink", DriveTypelink.DefaultValue ?? DbNullValue); // DN
            row.Add("Evaluation_Score", Evaluation_Score.DefaultValue ?? DbNullValue); // DN
            row.Add("Immediate_Failure_Score", Immediate_Failure_Score.DefaultValue ?? DbNullValue); // DN
            row.Add("Required_Program", Required_Program.DefaultValue ?? DbNullValue); // DN
            row.Add("Price", Price.DefaultValue ?? DbNullValue); // DN
            row.Add("intEvaluationType", intEvaluationType.DefaultValue ?? DbNullValue); // DN
            row.Add("Institution", Institution.DefaultValue ?? DbNullValue); // DN
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
            Eval_ID.RowCssClass = "row";

            // AssessmentID
            AssessmentID.RowCssClass = "row";

            // str_Full_Name_Hdr
            str_Full_Name_Hdr.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // str_Cell_Phone
            str_Cell_Phone.RowCssClass = "row";

            // int_Student_ID
            int_Student_ID.RowCssClass = "row";

            // intDrivinglicenseType
            intDrivinglicenseType.RowCssClass = "row";

            // Date_Entered
            Date_Entered.RowCssClass = "row";

            // Examination_Number
            Examination_Number.RowCssClass = "row";

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

            // Q60
            Q60.RowCssClass = "row";

            // Section_10
            Section_10.RowCssClass = "row";

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

            // Q66
            Q66.RowCssClass = "row";

            // Section_11
            Section_11.RowCssClass = "row";

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

            // Student_Signature
            Student_Signature.RowCssClass = "row";

            // Examiner_Signature
            Examiner_Signature.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // Retake
            Retake.RowCssClass = "row";

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

            // Assigned_int_Package_Id
            Assigned_int_Package_Id.RowCssClass = "row";

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

            // DriveTypelink
            DriveTypelink.RowCssClass = "row";

            // Evaluation_Score
            Evaluation_Score.RowCssClass = "row";

            // Immediate_Failure_Score
            Immediate_Failure_Score.RowCssClass = "row";

            // Required_Program
            Required_Program.RowCssClass = "row";

            // Price
            Price.RowCssClass = "row";

            // intEvaluationType
            intEvaluationType.RowCssClass = "row";

            // Institution
            Institution.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // Eval_ID
                Eval_ID.ViewValue = Eval_ID.CurrentValue;
                Eval_ID.ViewCustomAttributes = "";

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

                // int_Student_ID
                int_Student_ID.ViewValue = int_Student_ID.CurrentValue;
                int_Student_ID.ViewValue = FormatNumber(int_Student_ID.ViewValue, int_Student_ID.FormatPattern);
                int_Student_ID.ViewCustomAttributes = "";

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

                // Q60
                if (ConvertToBool(Q60.CurrentValue)) {
                    Q60.ViewValue = Q60.TagCaption(1) != "" ? Q60.TagCaption(1) : "Yes";
                } else {
                    Q60.ViewValue = Q60.TagCaption(2) != "" ? Q60.TagCaption(2) : "No";
                }
                Q60.ViewCustomAttributes = "";

                // Section_10
                Section_10.ViewValue = ConvertToString(Section_10.CurrentValue); // DN
                Section_10.ViewCustomAttributes = "";

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

                // Q66
                if (ConvertToBool(Q66.CurrentValue)) {
                    Q66.ViewValue = Q66.TagCaption(1) != "" ? Q66.TagCaption(1) : "Yes";
                } else {
                    Q66.ViewValue = Q66.TagCaption(2) != "" ? Q66.TagCaption(2) : "No";
                }
                Q66.ViewCustomAttributes = "";

                // Section_11
                Section_11.ViewValue = ConvertToString(Section_11.CurrentValue); // DN
                Section_11.ViewCustomAttributes = "";

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

                // Student_Signature
                Student_Signature.ViewValue = Student_Signature.CurrentValue;
                Student_Signature.ViewCustomAttributes = "";

                // Examiner_Signature
                Examiner_Signature.ViewValue = Examiner_Signature.CurrentValue;
                Examiner_Signature.ViewCustomAttributes = "";

                // Retake
                if (ConvertToBool(Retake.CurrentValue)) {
                    Retake.ViewValue = Retake.TagCaption(1) != "" ? Retake.TagCaption(1) : "Yes";
                } else {
                    Retake.ViewValue = Retake.TagCaption(2) != "" ? Retake.TagCaption(2) : "No";
                }
                Retake.ViewCustomAttributes = "";

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

                // intEvaluationType
                intEvaluationType.ViewValue = intEvaluationType.CurrentValue;
                intEvaluationType.ViewValue = FormatNumber(intEvaluationType.ViewValue, intEvaluationType.FormatPattern);
                intEvaluationType.ViewCustomAttributes = "";

                // Institution
                Institution.ViewValue = ConvertToString(Institution.CurrentValue); // DN
                Institution.ViewCustomAttributes = "";

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
                    intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblEvaluation_x_intDrivinglicenseType";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                    intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
                }

                // Date_Entered
                Date_Entered.HrefValue = "";

                // Section_1
                Section_1.HrefValue = "";

                // Q1
                Q1.HrefValue = "";

                // Q2
                Q2.HrefValue = "";

                // Q3
                Q3.HrefValue = "";

                // Q4
                Q4.HrefValue = "";

                // Q5
                Q5.HrefValue = "";

                // Section_2
                Section_2.HrefValue = "";
                Section_2.TooltipValue = "";

                // Q6
                Q6.HrefValue = "";

                // Q7
                Q7.HrefValue = "";

                // Q8
                Q8.HrefValue = "";

                // Q9
                Q9.HrefValue = "";

                // Q10
                Q10.HrefValue = "";

                // Q11
                Q11.HrefValue = "";

                // Q12
                Q12.HrefValue = "";

                // Q13
                Q13.HrefValue = "";

                // Q14
                Q14.HrefValue = "";

                // Q15
                Q15.HrefValue = "";

                // Section_3
                Section_3.HrefValue = "";
                Section_3.TooltipValue = "";

                // Q16
                Q16.HrefValue = "";

                // Q17
                Q17.HrefValue = "";

                // Q18
                Q18.HrefValue = "";

                // Q19
                Q19.HrefValue = "";

                // Q20
                Q20.HrefValue = "";

                // Q21
                Q21.HrefValue = "";

                // Section_4
                Section_4.HrefValue = "";
                Section_4.TooltipValue = "";

                // Q22
                Q22.HrefValue = "";

                // Q23
                Q23.HrefValue = "";

                // Q24
                Q24.HrefValue = "";

                // Q25
                Q25.HrefValue = "";

                // Q26
                Q26.HrefValue = "";

                // Section_5
                Section_5.HrefValue = "";
                Section_5.TooltipValue = "";

                // Q27
                Q27.HrefValue = "";

                // Q28
                Q28.HrefValue = "";

                // Q29
                Q29.HrefValue = "";

                // Q30
                Q30.HrefValue = "";

                // Q31
                Q31.HrefValue = "";

                // Q32
                Q32.HrefValue = "";

                // Q33
                Q33.HrefValue = "";

                // Q34
                Q34.HrefValue = "";

                // Q35
                Q35.HrefValue = "";

                // Section_6
                Section_6.HrefValue = "";
                Section_6.TooltipValue = "";

                // Q36
                Q36.HrefValue = "";

                // Q37
                Q37.HrefValue = "";

                // Q38
                Q38.HrefValue = "";

                // Q39
                Q39.HrefValue = "";

                // Q40
                Q40.HrefValue = "";

                // Q41
                Q41.HrefValue = "";

                // Q42
                Q42.HrefValue = "";

                // Q43
                Q43.HrefValue = "";

                // Section_7
                Section_7.HrefValue = "";
                Section_7.TooltipValue = "";

                // Q44
                Q44.HrefValue = "";

                // Q45
                Q45.HrefValue = "";

                // Q46
                Q46.HrefValue = "";

                // Q47
                Q47.HrefValue = "";

                // Q48
                Q48.HrefValue = "";

                // Q49
                Q49.HrefValue = "";

                // Q50
                Q50.HrefValue = "";

                // Section_8
                Section_8.HrefValue = "";
                Section_8.TooltipValue = "";

                // Q51
                Q51.HrefValue = "";

                // Q52
                Q52.HrefValue = "";

                // Q53
                Q53.HrefValue = "";

                // Q54
                Q54.HrefValue = "";

                // Q55
                Q55.HrefValue = "";

                // Section_9
                Section_9.HrefValue = "";
                Section_9.TooltipValue = "";

                // Q56
                Q56.HrefValue = "";

                // Q57
                Q57.HrefValue = "";

                // Q58
                Q58.HrefValue = "";

                // Q59
                Q59.HrefValue = "";

                // Q60
                Q60.HrefValue = "";

                // Section_10
                Section_10.HrefValue = "";
                Section_10.TooltipValue = "";

                // Q61
                Q61.HrefValue = "";

                // Q62
                Q62.HrefValue = "";

                // Q63
                Q63.HrefValue = "";

                // Q64
                Q64.HrefValue = "";

                // Q65
                Q65.HrefValue = "";

                // Q66
                Q66.HrefValue = "";

                // Section_11
                Section_11.HrefValue = "";
                Section_11.TooltipValue = "";

                // Q67
                Q67.HrefValue = "";

                // Q68
                Q68.HrefValue = "";

                // Q69
                Q69.HrefValue = "";

                // Q70
                Q70.HrefValue = "";

                // Notes_3
                Notes_3.HrefValue = "";

                // Student_Signature
                Student_Signature.HrefValue = "";

                // Examiner_Signature
                Examiner_Signature.HrefValue = "";

                // Retake
                Retake.HrefValue = "";

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

                // intEvaluationType
                intEvaluationType.HrefValue = "";
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

                // Date_Entered

                // Section_1
                Section_1.SetupEditAttributes();
                if (!Section_1.Raw)
                    Section_1.CurrentValue = HtmlDecode(Section_1.CurrentValue);
                Section_1.EditValue = HtmlEncode(Section_1.CurrentValue);
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
                Section_2.EditValue = ConvertToString(Section_2.CurrentValue); // DN
                Section_2.ViewCustomAttributes = "";

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
                Section_3.EditValue = ConvertToString(Section_3.CurrentValue); // DN
                Section_3.ViewCustomAttributes = "";

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
                Section_4.EditValue = ConvertToString(Section_4.CurrentValue); // DN
                Section_4.ViewCustomAttributes = "";

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
                Section_5.EditValue = ConvertToString(Section_5.CurrentValue); // DN
                Section_5.ViewCustomAttributes = "";

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
                Section_6.EditValue = ConvertToString(Section_6.CurrentValue); // DN
                Section_6.ViewCustomAttributes = "";

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
                Section_7.EditValue = ConvertToString(Section_7.CurrentValue); // DN
                Section_7.ViewCustomAttributes = "";

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
                Section_8.EditValue = ConvertToString(Section_8.CurrentValue); // DN
                Section_8.ViewCustomAttributes = "";

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
                Section_9.EditValue = ConvertToString(Section_9.CurrentValue); // DN
                Section_9.ViewCustomAttributes = "";

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

                // Q60
                Q60.EditValue = Q60.Options(false);
                Q60.PlaceHolder = RemoveHtml(Q60.Caption);

                // Section_10
                Section_10.SetupEditAttributes();
                Section_10.EditValue = ConvertToString(Section_10.CurrentValue); // DN
                Section_10.ViewCustomAttributes = "";

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

                // Q66
                Q66.EditValue = Q66.Options(false);
                Q66.PlaceHolder = RemoveHtml(Q66.Caption);

                // Section_11
                Section_11.SetupEditAttributes();
                Section_11.EditValue = ConvertToString(Section_11.CurrentValue); // DN
                Section_11.ViewCustomAttributes = "";

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
                Notes_3.EditValue = Notes_3.CurrentValue; // DN
                Notes_3.PlaceHolder = RemoveHtml(Notes_3.Caption);

                // Student_Signature
                Student_Signature.SetupEditAttributes();

                // Examiner_Signature
                Examiner_Signature.SetupEditAttributes();

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

                // date_Birth_Hijri
                date_Birth_Hijri.SetupEditAttributes();
                date_Birth_Hijri.EditValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // date_Birth
                date_Birth.SetupEditAttributes();
                date_Birth.EditValue = date_Birth.CurrentValue;
                date_Birth.EditValue = FormatDateTime(date_Birth.EditValue, date_Birth.FormatPattern);
                date_Birth.ViewCustomAttributes = "";

                // str_Email
                str_Email.SetupEditAttributes();
                str_Email.EditValue = ConvertToString(str_Email.CurrentValue); // DN
                str_Email.ViewCustomAttributes = "";

                // UserlevelID

                // intEvaluationType
                intEvaluationType.SetupEditAttributes();
                intEvaluationType.EditValue = intEvaluationType.CurrentValue; // DN
                intEvaluationType.PlaceHolder = RemoveHtml(intEvaluationType.Caption);
                if (!Empty(intEvaluationType.EditValue) && IsNumeric(intEvaluationType.EditValue))
                    intEvaluationType.EditValue = FormatNumber(intEvaluationType.EditValue, null);

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
                    intDrivinglicenseType.LinkAttrs["data-tooltip-id"] = "tt_tblEvaluation_x_intDrivinglicenseType";
                    intDrivinglicenseType.LinkAttrs["data-tooltip-width"] = ConvertToString(intDrivinglicenseType.TooltipWidth);
                    intDrivinglicenseType.LinkAttrs["data-bs-placement"] = IsRTL ? "left" : "right";
                }

                // Date_Entered
                Date_Entered.HrefValue = "";

                // Section_1
                Section_1.HrefValue = "";

                // Q1
                Q1.HrefValue = "";

                // Q2
                Q2.HrefValue = "";

                // Q3
                Q3.HrefValue = "";

                // Q4
                Q4.HrefValue = "";

                // Q5
                Q5.HrefValue = "";

                // Section_2
                Section_2.HrefValue = "";
                Section_2.TooltipValue = "";

                // Q6
                Q6.HrefValue = "";

                // Q7
                Q7.HrefValue = "";

                // Q8
                Q8.HrefValue = "";

                // Q9
                Q9.HrefValue = "";

                // Q10
                Q10.HrefValue = "";

                // Q11
                Q11.HrefValue = "";

                // Q12
                Q12.HrefValue = "";

                // Q13
                Q13.HrefValue = "";

                // Q14
                Q14.HrefValue = "";

                // Q15
                Q15.HrefValue = "";

                // Section_3
                Section_3.HrefValue = "";
                Section_3.TooltipValue = "";

                // Q16
                Q16.HrefValue = "";

                // Q17
                Q17.HrefValue = "";

                // Q18
                Q18.HrefValue = "";

                // Q19
                Q19.HrefValue = "";

                // Q20
                Q20.HrefValue = "";

                // Q21
                Q21.HrefValue = "";

                // Section_4
                Section_4.HrefValue = "";
                Section_4.TooltipValue = "";

                // Q22
                Q22.HrefValue = "";

                // Q23
                Q23.HrefValue = "";

                // Q24
                Q24.HrefValue = "";

                // Q25
                Q25.HrefValue = "";

                // Q26
                Q26.HrefValue = "";

                // Section_5
                Section_5.HrefValue = "";
                Section_5.TooltipValue = "";

                // Q27
                Q27.HrefValue = "";

                // Q28
                Q28.HrefValue = "";

                // Q29
                Q29.HrefValue = "";

                // Q30
                Q30.HrefValue = "";

                // Q31
                Q31.HrefValue = "";

                // Q32
                Q32.HrefValue = "";

                // Q33
                Q33.HrefValue = "";

                // Q34
                Q34.HrefValue = "";

                // Q35
                Q35.HrefValue = "";

                // Section_6
                Section_6.HrefValue = "";
                Section_6.TooltipValue = "";

                // Q36
                Q36.HrefValue = "";

                // Q37
                Q37.HrefValue = "";

                // Q38
                Q38.HrefValue = "";

                // Q39
                Q39.HrefValue = "";

                // Q40
                Q40.HrefValue = "";

                // Q41
                Q41.HrefValue = "";

                // Q42
                Q42.HrefValue = "";

                // Q43
                Q43.HrefValue = "";

                // Section_7
                Section_7.HrefValue = "";
                Section_7.TooltipValue = "";

                // Q44
                Q44.HrefValue = "";

                // Q45
                Q45.HrefValue = "";

                // Q46
                Q46.HrefValue = "";

                // Q47
                Q47.HrefValue = "";

                // Q48
                Q48.HrefValue = "";

                // Q49
                Q49.HrefValue = "";

                // Q50
                Q50.HrefValue = "";

                // Section_8
                Section_8.HrefValue = "";
                Section_8.TooltipValue = "";

                // Q51
                Q51.HrefValue = "";

                // Q52
                Q52.HrefValue = "";

                // Q53
                Q53.HrefValue = "";

                // Q54
                Q54.HrefValue = "";

                // Q55
                Q55.HrefValue = "";

                // Section_9
                Section_9.HrefValue = "";
                Section_9.TooltipValue = "";

                // Q56
                Q56.HrefValue = "";

                // Q57
                Q57.HrefValue = "";

                // Q58
                Q58.HrefValue = "";

                // Q59
                Q59.HrefValue = "";

                // Q60
                Q60.HrefValue = "";

                // Section_10
                Section_10.HrefValue = "";
                Section_10.TooltipValue = "";

                // Q61
                Q61.HrefValue = "";

                // Q62
                Q62.HrefValue = "";

                // Q63
                Q63.HrefValue = "";

                // Q64
                Q64.HrefValue = "";

                // Q65
                Q65.HrefValue = "";

                // Q66
                Q66.HrefValue = "";

                // Section_11
                Section_11.HrefValue = "";
                Section_11.TooltipValue = "";

                // Q67
                Q67.HrefValue = "";

                // Q68
                Q68.HrefValue = "";

                // Q69
                Q69.HrefValue = "";

                // Q70
                Q70.HrefValue = "";

                // Notes_3
                Notes_3.HrefValue = "";

                // Student_Signature
                Student_Signature.HrefValue = "";

                // Examiner_Signature
                Examiner_Signature.HrefValue = "";

                // Retake
                Retake.HrefValue = "";

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

                // intEvaluationType
                intEvaluationType.HrefValue = "";
            }
            if (RowType == RowType.Add || RowType == RowType.Edit || RowType == RowType.Search) // Add/Edit/Search row
                SetupFieldTitles();

            // Call Row Rendered event
            if (RowType != RowType.AggregateInit)
                RowRendered();

            // Save data for Custom Template
            if (RowType == RowType.View || RowType == RowType.Edit || RowType == RowType.Add)
                Rows.Add(CustomTemplateFieldValues());
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
            if (Date_Entered.Required) {
                if (!Date_Entered.IsDetailKey && Empty(Date_Entered.FormValue)) {
                    Date_Entered.AddErrorMessage(ConvertToString(Date_Entered.RequiredErrorMessage).Replace("%s", Date_Entered.Caption));
                }
            }
            if (Section_1.Required) {
                if (!Section_1.IsDetailKey && Empty(Section_1.FormValue)) {
                    Section_1.AddErrorMessage(ConvertToString(Section_1.RequiredErrorMessage).Replace("%s", Section_1.Caption));
                }
            }
            if (Q1.Required) {
                if (Empty(Q1.FormValue)) {
                    Q1.AddErrorMessage(ConvertToString(Q1.RequiredErrorMessage).Replace("%s", Q1.Caption));
                }
            }
            if (Q2.Required) {
                if (Empty(Q2.FormValue)) {
                    Q2.AddErrorMessage(ConvertToString(Q2.RequiredErrorMessage).Replace("%s", Q2.Caption));
                }
            }
            if (Q3.Required) {
                if (Empty(Q3.FormValue)) {
                    Q3.AddErrorMessage(ConvertToString(Q3.RequiredErrorMessage).Replace("%s", Q3.Caption));
                }
            }
            if (Q4.Required) {
                if (Empty(Q4.FormValue)) {
                    Q4.AddErrorMessage(ConvertToString(Q4.RequiredErrorMessage).Replace("%s", Q4.Caption));
                }
            }
            if (Q5.Required) {
                if (Empty(Q5.FormValue)) {
                    Q5.AddErrorMessage(ConvertToString(Q5.RequiredErrorMessage).Replace("%s", Q5.Caption));
                }
            }
            if (Section_2.Required) {
                if (!Section_2.IsDetailKey && Empty(Section_2.FormValue)) {
                    Section_2.AddErrorMessage(ConvertToString(Section_2.RequiredErrorMessage).Replace("%s", Section_2.Caption));
                }
            }
            if (Q6.Required) {
                if (Empty(Q6.FormValue)) {
                    Q6.AddErrorMessage(ConvertToString(Q6.RequiredErrorMessage).Replace("%s", Q6.Caption));
                }
            }
            if (Q7.Required) {
                if (Empty(Q7.FormValue)) {
                    Q7.AddErrorMessage(ConvertToString(Q7.RequiredErrorMessage).Replace("%s", Q7.Caption));
                }
            }
            if (Q8.Required) {
                if (Empty(Q8.FormValue)) {
                    Q8.AddErrorMessage(ConvertToString(Q8.RequiredErrorMessage).Replace("%s", Q8.Caption));
                }
            }
            if (Q9.Required) {
                if (Empty(Q9.FormValue)) {
                    Q9.AddErrorMessage(ConvertToString(Q9.RequiredErrorMessage).Replace("%s", Q9.Caption));
                }
            }
            if (Q10.Required) {
                if (Empty(Q10.FormValue)) {
                    Q10.AddErrorMessage(ConvertToString(Q10.RequiredErrorMessage).Replace("%s", Q10.Caption));
                }
            }
            if (Q11.Required) {
                if (Empty(Q11.FormValue)) {
                    Q11.AddErrorMessage(ConvertToString(Q11.RequiredErrorMessage).Replace("%s", Q11.Caption));
                }
            }
            if (Q12.Required) {
                if (Empty(Q12.FormValue)) {
                    Q12.AddErrorMessage(ConvertToString(Q12.RequiredErrorMessage).Replace("%s", Q12.Caption));
                }
            }
            if (Q13.Required) {
                if (Empty(Q13.FormValue)) {
                    Q13.AddErrorMessage(ConvertToString(Q13.RequiredErrorMessage).Replace("%s", Q13.Caption));
                }
            }
            if (Q14.Required) {
                if (Empty(Q14.FormValue)) {
                    Q14.AddErrorMessage(ConvertToString(Q14.RequiredErrorMessage).Replace("%s", Q14.Caption));
                }
            }
            if (Q15.Required) {
                if (Empty(Q15.FormValue)) {
                    Q15.AddErrorMessage(ConvertToString(Q15.RequiredErrorMessage).Replace("%s", Q15.Caption));
                }
            }
            if (Section_3.Required) {
                if (!Section_3.IsDetailKey && Empty(Section_3.FormValue)) {
                    Section_3.AddErrorMessage(ConvertToString(Section_3.RequiredErrorMessage).Replace("%s", Section_3.Caption));
                }
            }
            if (Q16.Required) {
                if (Empty(Q16.FormValue)) {
                    Q16.AddErrorMessage(ConvertToString(Q16.RequiredErrorMessage).Replace("%s", Q16.Caption));
                }
            }
            if (Q17.Required) {
                if (Empty(Q17.FormValue)) {
                    Q17.AddErrorMessage(ConvertToString(Q17.RequiredErrorMessage).Replace("%s", Q17.Caption));
                }
            }
            if (Q18.Required) {
                if (Empty(Q18.FormValue)) {
                    Q18.AddErrorMessage(ConvertToString(Q18.RequiredErrorMessage).Replace("%s", Q18.Caption));
                }
            }
            if (Q19.Required) {
                if (Empty(Q19.FormValue)) {
                    Q19.AddErrorMessage(ConvertToString(Q19.RequiredErrorMessage).Replace("%s", Q19.Caption));
                }
            }
            if (Q20.Required) {
                if (Empty(Q20.FormValue)) {
                    Q20.AddErrorMessage(ConvertToString(Q20.RequiredErrorMessage).Replace("%s", Q20.Caption));
                }
            }
            if (Q21.Required) {
                if (Empty(Q21.FormValue)) {
                    Q21.AddErrorMessage(ConvertToString(Q21.RequiredErrorMessage).Replace("%s", Q21.Caption));
                }
            }
            if (Section_4.Required) {
                if (!Section_4.IsDetailKey && Empty(Section_4.FormValue)) {
                    Section_4.AddErrorMessage(ConvertToString(Section_4.RequiredErrorMessage).Replace("%s", Section_4.Caption));
                }
            }
            if (Q22.Required) {
                if (Empty(Q22.FormValue)) {
                    Q22.AddErrorMessage(ConvertToString(Q22.RequiredErrorMessage).Replace("%s", Q22.Caption));
                }
            }
            if (Q23.Required) {
                if (Empty(Q23.FormValue)) {
                    Q23.AddErrorMessage(ConvertToString(Q23.RequiredErrorMessage).Replace("%s", Q23.Caption));
                }
            }
            if (Q24.Required) {
                if (Empty(Q24.FormValue)) {
                    Q24.AddErrorMessage(ConvertToString(Q24.RequiredErrorMessage).Replace("%s", Q24.Caption));
                }
            }
            if (Q25.Required) {
                if (Empty(Q25.FormValue)) {
                    Q25.AddErrorMessage(ConvertToString(Q25.RequiredErrorMessage).Replace("%s", Q25.Caption));
                }
            }
            if (Q26.Required) {
                if (Empty(Q26.FormValue)) {
                    Q26.AddErrorMessage(ConvertToString(Q26.RequiredErrorMessage).Replace("%s", Q26.Caption));
                }
            }
            if (Section_5.Required) {
                if (!Section_5.IsDetailKey && Empty(Section_5.FormValue)) {
                    Section_5.AddErrorMessage(ConvertToString(Section_5.RequiredErrorMessage).Replace("%s", Section_5.Caption));
                }
            }
            if (Q27.Required) {
                if (Empty(Q27.FormValue)) {
                    Q27.AddErrorMessage(ConvertToString(Q27.RequiredErrorMessage).Replace("%s", Q27.Caption));
                }
            }
            if (Q28.Required) {
                if (Empty(Q28.FormValue)) {
                    Q28.AddErrorMessage(ConvertToString(Q28.RequiredErrorMessage).Replace("%s", Q28.Caption));
                }
            }
            if (Q29.Required) {
                if (Empty(Q29.FormValue)) {
                    Q29.AddErrorMessage(ConvertToString(Q29.RequiredErrorMessage).Replace("%s", Q29.Caption));
                }
            }
            if (Q30.Required) {
                if (Empty(Q30.FormValue)) {
                    Q30.AddErrorMessage(ConvertToString(Q30.RequiredErrorMessage).Replace("%s", Q30.Caption));
                }
            }
            if (Q31.Required) {
                if (Empty(Q31.FormValue)) {
                    Q31.AddErrorMessage(ConvertToString(Q31.RequiredErrorMessage).Replace("%s", Q31.Caption));
                }
            }
            if (Q32.Required) {
                if (Empty(Q32.FormValue)) {
                    Q32.AddErrorMessage(ConvertToString(Q32.RequiredErrorMessage).Replace("%s", Q32.Caption));
                }
            }
            if (Q33.Required) {
                if (Empty(Q33.FormValue)) {
                    Q33.AddErrorMessage(ConvertToString(Q33.RequiredErrorMessage).Replace("%s", Q33.Caption));
                }
            }
            if (Q34.Required) {
                if (Empty(Q34.FormValue)) {
                    Q34.AddErrorMessage(ConvertToString(Q34.RequiredErrorMessage).Replace("%s", Q34.Caption));
                }
            }
            if (Q35.Required) {
                if (Empty(Q35.FormValue)) {
                    Q35.AddErrorMessage(ConvertToString(Q35.RequiredErrorMessage).Replace("%s", Q35.Caption));
                }
            }
            if (Section_6.Required) {
                if (!Section_6.IsDetailKey && Empty(Section_6.FormValue)) {
                    Section_6.AddErrorMessage(ConvertToString(Section_6.RequiredErrorMessage).Replace("%s", Section_6.Caption));
                }
            }
            if (Q36.Required) {
                if (Empty(Q36.FormValue)) {
                    Q36.AddErrorMessage(ConvertToString(Q36.RequiredErrorMessage).Replace("%s", Q36.Caption));
                }
            }
            if (Q37.Required) {
                if (Empty(Q37.FormValue)) {
                    Q37.AddErrorMessage(ConvertToString(Q37.RequiredErrorMessage).Replace("%s", Q37.Caption));
                }
            }
            if (Q38.Required) {
                if (Empty(Q38.FormValue)) {
                    Q38.AddErrorMessage(ConvertToString(Q38.RequiredErrorMessage).Replace("%s", Q38.Caption));
                }
            }
            if (Q39.Required) {
                if (Empty(Q39.FormValue)) {
                    Q39.AddErrorMessage(ConvertToString(Q39.RequiredErrorMessage).Replace("%s", Q39.Caption));
                }
            }
            if (Q40.Required) {
                if (Empty(Q40.FormValue)) {
                    Q40.AddErrorMessage(ConvertToString(Q40.RequiredErrorMessage).Replace("%s", Q40.Caption));
                }
            }
            if (Q41.Required) {
                if (Empty(Q41.FormValue)) {
                    Q41.AddErrorMessage(ConvertToString(Q41.RequiredErrorMessage).Replace("%s", Q41.Caption));
                }
            }
            if (Q42.Required) {
                if (Empty(Q42.FormValue)) {
                    Q42.AddErrorMessage(ConvertToString(Q42.RequiredErrorMessage).Replace("%s", Q42.Caption));
                }
            }
            if (Q43.Required) {
                if (Empty(Q43.FormValue)) {
                    Q43.AddErrorMessage(ConvertToString(Q43.RequiredErrorMessage).Replace("%s", Q43.Caption));
                }
            }
            if (Section_7.Required) {
                if (!Section_7.IsDetailKey && Empty(Section_7.FormValue)) {
                    Section_7.AddErrorMessage(ConvertToString(Section_7.RequiredErrorMessage).Replace("%s", Section_7.Caption));
                }
            }
            if (Q44.Required) {
                if (Empty(Q44.FormValue)) {
                    Q44.AddErrorMessage(ConvertToString(Q44.RequiredErrorMessage).Replace("%s", Q44.Caption));
                }
            }
            if (Q45.Required) {
                if (Empty(Q45.FormValue)) {
                    Q45.AddErrorMessage(ConvertToString(Q45.RequiredErrorMessage).Replace("%s", Q45.Caption));
                }
            }
            if (Q46.Required) {
                if (Empty(Q46.FormValue)) {
                    Q46.AddErrorMessage(ConvertToString(Q46.RequiredErrorMessage).Replace("%s", Q46.Caption));
                }
            }
            if (Q47.Required) {
                if (Empty(Q47.FormValue)) {
                    Q47.AddErrorMessage(ConvertToString(Q47.RequiredErrorMessage).Replace("%s", Q47.Caption));
                }
            }
            if (Q48.Required) {
                if (Empty(Q48.FormValue)) {
                    Q48.AddErrorMessage(ConvertToString(Q48.RequiredErrorMessage).Replace("%s", Q48.Caption));
                }
            }
            if (Q49.Required) {
                if (Empty(Q49.FormValue)) {
                    Q49.AddErrorMessage(ConvertToString(Q49.RequiredErrorMessage).Replace("%s", Q49.Caption));
                }
            }
            if (Q50.Required) {
                if (Empty(Q50.FormValue)) {
                    Q50.AddErrorMessage(ConvertToString(Q50.RequiredErrorMessage).Replace("%s", Q50.Caption));
                }
            }
            if (Section_8.Required) {
                if (!Section_8.IsDetailKey && Empty(Section_8.FormValue)) {
                    Section_8.AddErrorMessage(ConvertToString(Section_8.RequiredErrorMessage).Replace("%s", Section_8.Caption));
                }
            }
            if (Q51.Required) {
                if (Empty(Q51.FormValue)) {
                    Q51.AddErrorMessage(ConvertToString(Q51.RequiredErrorMessage).Replace("%s", Q51.Caption));
                }
            }
            if (Q52.Required) {
                if (Empty(Q52.FormValue)) {
                    Q52.AddErrorMessage(ConvertToString(Q52.RequiredErrorMessage).Replace("%s", Q52.Caption));
                }
            }
            if (Q53.Required) {
                if (Empty(Q53.FormValue)) {
                    Q53.AddErrorMessage(ConvertToString(Q53.RequiredErrorMessage).Replace("%s", Q53.Caption));
                }
            }
            if (Q54.Required) {
                if (Empty(Q54.FormValue)) {
                    Q54.AddErrorMessage(ConvertToString(Q54.RequiredErrorMessage).Replace("%s", Q54.Caption));
                }
            }
            if (Q55.Required) {
                if (Empty(Q55.FormValue)) {
                    Q55.AddErrorMessage(ConvertToString(Q55.RequiredErrorMessage).Replace("%s", Q55.Caption));
                }
            }
            if (Section_9.Required) {
                if (!Section_9.IsDetailKey && Empty(Section_9.FormValue)) {
                    Section_9.AddErrorMessage(ConvertToString(Section_9.RequiredErrorMessage).Replace("%s", Section_9.Caption));
                }
            }
            if (Q56.Required) {
                if (Empty(Q56.FormValue)) {
                    Q56.AddErrorMessage(ConvertToString(Q56.RequiredErrorMessage).Replace("%s", Q56.Caption));
                }
            }
            if (Q57.Required) {
                if (Empty(Q57.FormValue)) {
                    Q57.AddErrorMessage(ConvertToString(Q57.RequiredErrorMessage).Replace("%s", Q57.Caption));
                }
            }
            if (Q58.Required) {
                if (Empty(Q58.FormValue)) {
                    Q58.AddErrorMessage(ConvertToString(Q58.RequiredErrorMessage).Replace("%s", Q58.Caption));
                }
            }
            if (Q59.Required) {
                if (Empty(Q59.FormValue)) {
                    Q59.AddErrorMessage(ConvertToString(Q59.RequiredErrorMessage).Replace("%s", Q59.Caption));
                }
            }
            if (Q60.Required) {
                if (Empty(Q60.FormValue)) {
                    Q60.AddErrorMessage(ConvertToString(Q60.RequiredErrorMessage).Replace("%s", Q60.Caption));
                }
            }
            if (Section_10.Required) {
                if (!Section_10.IsDetailKey && Empty(Section_10.FormValue)) {
                    Section_10.AddErrorMessage(ConvertToString(Section_10.RequiredErrorMessage).Replace("%s", Section_10.Caption));
                }
            }
            if (Q61.Required) {
                if (Empty(Q61.FormValue)) {
                    Q61.AddErrorMessage(ConvertToString(Q61.RequiredErrorMessage).Replace("%s", Q61.Caption));
                }
            }
            if (Q62.Required) {
                if (Empty(Q62.FormValue)) {
                    Q62.AddErrorMessage(ConvertToString(Q62.RequiredErrorMessage).Replace("%s", Q62.Caption));
                }
            }
            if (Q63.Required) {
                if (Empty(Q63.FormValue)) {
                    Q63.AddErrorMessage(ConvertToString(Q63.RequiredErrorMessage).Replace("%s", Q63.Caption));
                }
            }
            if (Q64.Required) {
                if (Empty(Q64.FormValue)) {
                    Q64.AddErrorMessage(ConvertToString(Q64.RequiredErrorMessage).Replace("%s", Q64.Caption));
                }
            }
            if (Q65.Required) {
                if (Empty(Q65.FormValue)) {
                    Q65.AddErrorMessage(ConvertToString(Q65.RequiredErrorMessage).Replace("%s", Q65.Caption));
                }
            }
            if (Q66.Required) {
                if (Empty(Q66.FormValue)) {
                    Q66.AddErrorMessage(ConvertToString(Q66.RequiredErrorMessage).Replace("%s", Q66.Caption));
                }
            }
            if (Section_11.Required) {
                if (!Section_11.IsDetailKey && Empty(Section_11.FormValue)) {
                    Section_11.AddErrorMessage(ConvertToString(Section_11.RequiredErrorMessage).Replace("%s", Section_11.Caption));
                }
            }
            if (Q67.Required) {
                if (Empty(Q67.FormValue)) {
                    Q67.AddErrorMessage(ConvertToString(Q67.RequiredErrorMessage).Replace("%s", Q67.Caption));
                }
            }
            if (Q68.Required) {
                if (Empty(Q68.FormValue)) {
                    Q68.AddErrorMessage(ConvertToString(Q68.RequiredErrorMessage).Replace("%s", Q68.Caption));
                }
            }
            if (Q69.Required) {
                if (Empty(Q69.FormValue)) {
                    Q69.AddErrorMessage(ConvertToString(Q69.RequiredErrorMessage).Replace("%s", Q69.Caption));
                }
            }
            if (Q70.Required) {
                if (Empty(Q70.FormValue)) {
                    Q70.AddErrorMessage(ConvertToString(Q70.RequiredErrorMessage).Replace("%s", Q70.Caption));
                }
            }
            if (Notes_3.Required) {
                if (!Notes_3.IsDetailKey && Empty(Notes_3.FormValue)) {
                    Notes_3.AddErrorMessage(ConvertToString(Notes_3.RequiredErrorMessage).Replace("%s", Notes_3.Caption));
                }
            }
            if (Student_Signature.Required) {
                if (!Student_Signature.IsDetailKey && Empty(Student_Signature.FormValue)) {
                    Student_Signature.AddErrorMessage(ConvertToString(Student_Signature.RequiredErrorMessage).Replace("%s", Student_Signature.Caption));
                }
            }
            if (Examiner_Signature.Required) {
                if (!Examiner_Signature.IsDetailKey && Empty(Examiner_Signature.FormValue)) {
                    Examiner_Signature.AddErrorMessage(ConvertToString(Examiner_Signature.RequiredErrorMessage).Replace("%s", Examiner_Signature.Caption));
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
            if (date_Birth_Hijri.Required) {
                if (!date_Birth_Hijri.IsDetailKey && Empty(date_Birth_Hijri.FormValue)) {
                    date_Birth_Hijri.AddErrorMessage(ConvertToString(date_Birth_Hijri.RequiredErrorMessage).Replace("%s", date_Birth_Hijri.Caption));
                }
            }
            if (date_Birth.Required) {
                if (!date_Birth.IsDetailKey && Empty(date_Birth.FormValue)) {
                    date_Birth.AddErrorMessage(ConvertToString(date_Birth.RequiredErrorMessage).Replace("%s", date_Birth.Caption));
                }
            }
            if (str_Email.Required) {
                if (!str_Email.IsDetailKey && Empty(str_Email.FormValue)) {
                    str_Email.AddErrorMessage(ConvertToString(str_Email.RequiredErrorMessage).Replace("%s", str_Email.Caption));
                }
            }
            if (UserlevelID.Required) {
                if (!UserlevelID.IsDetailKey && Empty(UserlevelID.FormValue)) {
                    UserlevelID.AddErrorMessage(ConvertToString(UserlevelID.RequiredErrorMessage).Replace("%s", UserlevelID.Caption));
                }
            }
            if (intEvaluationType.Required) {
                if (!intEvaluationType.IsDetailKey && Empty(intEvaluationType.FormValue)) {
                    intEvaluationType.AddErrorMessage(ConvertToString(intEvaluationType.RequiredErrorMessage).Replace("%s", intEvaluationType.Caption));
                }
            }
            if (!CheckInteger(intEvaluationType.FormValue)) {
                intEvaluationType.AddErrorMessage(intEvaluationType.GetErrorMessage(false));
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

            // Date_Entered
            Date_Entered.CurrentValue = Date_Entered.GetAutoUpdateValue();
            Date_Entered.SetDbValue(rsnew, Date_Entered.CurrentValue, false);

            // Section_1
            Section_1.SetDbValue(rsnew, Section_1.CurrentValue, Section_1.ReadOnly);

            // Q1
            Q1.SetDbValue(rsnew, ConvertToBool(Q1.CurrentValue), Q1.ReadOnly);

            // Q2
            Q2.SetDbValue(rsnew, ConvertToBool(Q2.CurrentValue), Q2.ReadOnly);

            // Q3
            Q3.SetDbValue(rsnew, ConvertToBool(Q3.CurrentValue), Q3.ReadOnly);

            // Q4
            Q4.SetDbValue(rsnew, ConvertToBool(Q4.CurrentValue), Q4.ReadOnly);

            // Q5
            Q5.SetDbValue(rsnew, ConvertToBool(Q5.CurrentValue), Q5.ReadOnly);

            // Q6
            Q6.SetDbValue(rsnew, ConvertToBool(Q6.CurrentValue), Q6.ReadOnly);

            // Q7
            Q7.SetDbValue(rsnew, ConvertToBool(Q7.CurrentValue), Q7.ReadOnly);

            // Q8
            Q8.SetDbValue(rsnew, ConvertToBool(Q8.CurrentValue), Q8.ReadOnly);

            // Q9
            Q9.SetDbValue(rsnew, ConvertToBool(Q9.CurrentValue), Q9.ReadOnly);

            // Q10
            Q10.SetDbValue(rsnew, ConvertToBool(Q10.CurrentValue), Q10.ReadOnly);

            // Q11
            Q11.SetDbValue(rsnew, ConvertToBool(Q11.CurrentValue), Q11.ReadOnly);

            // Q12
            Q12.SetDbValue(rsnew, ConvertToBool(Q12.CurrentValue), Q12.ReadOnly);

            // Q13
            Q13.SetDbValue(rsnew, ConvertToBool(Q13.CurrentValue), Q13.ReadOnly);

            // Q14
            Q14.SetDbValue(rsnew, ConvertToBool(Q14.CurrentValue), Q14.ReadOnly);

            // Q15
            Q15.SetDbValue(rsnew, ConvertToBool(Q15.CurrentValue), Q15.ReadOnly);

            // Q16
            Q16.SetDbValue(rsnew, ConvertToBool(Q16.CurrentValue), Q16.ReadOnly);

            // Q17
            Q17.SetDbValue(rsnew, ConvertToBool(Q17.CurrentValue), Q17.ReadOnly);

            // Q18
            Q18.SetDbValue(rsnew, ConvertToBool(Q18.CurrentValue), Q18.ReadOnly);

            // Q19
            Q19.SetDbValue(rsnew, ConvertToBool(Q19.CurrentValue), Q19.ReadOnly);

            // Q20
            Q20.SetDbValue(rsnew, ConvertToBool(Q20.CurrentValue), Q20.ReadOnly);

            // Q21
            Q21.SetDbValue(rsnew, ConvertToBool(Q21.CurrentValue), Q21.ReadOnly);

            // Q22
            Q22.SetDbValue(rsnew, ConvertToBool(Q22.CurrentValue), Q22.ReadOnly);

            // Q23
            Q23.SetDbValue(rsnew, ConvertToBool(Q23.CurrentValue), Q23.ReadOnly);

            // Q24
            Q24.SetDbValue(rsnew, ConvertToBool(Q24.CurrentValue), Q24.ReadOnly);

            // Q25
            Q25.SetDbValue(rsnew, ConvertToBool(Q25.CurrentValue), Q25.ReadOnly);

            // Q26
            Q26.SetDbValue(rsnew, ConvertToBool(Q26.CurrentValue), Q26.ReadOnly);

            // Q27
            Q27.SetDbValue(rsnew, ConvertToBool(Q27.CurrentValue), Q27.ReadOnly);

            // Q28
            Q28.SetDbValue(rsnew, ConvertToBool(Q28.CurrentValue), Q28.ReadOnly);

            // Q29
            Q29.SetDbValue(rsnew, ConvertToBool(Q29.CurrentValue), Q29.ReadOnly);

            // Q30
            Q30.SetDbValue(rsnew, ConvertToBool(Q30.CurrentValue), Q30.ReadOnly);

            // Q31
            Q31.SetDbValue(rsnew, ConvertToBool(Q31.CurrentValue), Q31.ReadOnly);

            // Q32
            Q32.SetDbValue(rsnew, ConvertToBool(Q32.CurrentValue), Q32.ReadOnly);

            // Q33
            Q33.SetDbValue(rsnew, ConvertToBool(Q33.CurrentValue), Q33.ReadOnly);

            // Q34
            Q34.SetDbValue(rsnew, ConvertToBool(Q34.CurrentValue), Q34.ReadOnly);

            // Q35
            Q35.SetDbValue(rsnew, ConvertToBool(Q35.CurrentValue), Q35.ReadOnly);

            // Q36
            Q36.SetDbValue(rsnew, ConvertToBool(Q36.CurrentValue), Q36.ReadOnly);

            // Q37
            Q37.SetDbValue(rsnew, ConvertToBool(Q37.CurrentValue), Q37.ReadOnly);

            // Q38
            Q38.SetDbValue(rsnew, ConvertToBool(Q38.CurrentValue), Q38.ReadOnly);

            // Q39
            Q39.SetDbValue(rsnew, ConvertToBool(Q39.CurrentValue), Q39.ReadOnly);

            // Q40
            Q40.SetDbValue(rsnew, ConvertToBool(Q40.CurrentValue), Q40.ReadOnly);

            // Q41
            Q41.SetDbValue(rsnew, ConvertToBool(Q41.CurrentValue), Q41.ReadOnly);

            // Q42
            Q42.SetDbValue(rsnew, ConvertToBool(Q42.CurrentValue), Q42.ReadOnly);

            // Q43
            Q43.SetDbValue(rsnew, ConvertToBool(Q43.CurrentValue), Q43.ReadOnly);

            // Q44
            Q44.SetDbValue(rsnew, ConvertToBool(Q44.CurrentValue), Q44.ReadOnly);

            // Q45
            Q45.SetDbValue(rsnew, ConvertToBool(Q45.CurrentValue), Q45.ReadOnly);

            // Q46
            Q46.SetDbValue(rsnew, ConvertToBool(Q46.CurrentValue), Q46.ReadOnly);

            // Q47
            Q47.SetDbValue(rsnew, ConvertToBool(Q47.CurrentValue), Q47.ReadOnly);

            // Q48
            Q48.SetDbValue(rsnew, ConvertToBool(Q48.CurrentValue), Q48.ReadOnly);

            // Q49
            Q49.SetDbValue(rsnew, ConvertToBool(Q49.CurrentValue), Q49.ReadOnly);

            // Q50
            Q50.SetDbValue(rsnew, ConvertToBool(Q50.CurrentValue), Q50.ReadOnly);

            // Q51
            Q51.SetDbValue(rsnew, ConvertToBool(Q51.CurrentValue), Q51.ReadOnly);

            // Q52
            Q52.SetDbValue(rsnew, ConvertToBool(Q52.CurrentValue), Q52.ReadOnly);

            // Q53
            Q53.SetDbValue(rsnew, ConvertToBool(Q53.CurrentValue), Q53.ReadOnly);

            // Q54
            Q54.SetDbValue(rsnew, ConvertToBool(Q54.CurrentValue), Q54.ReadOnly);

            // Q55
            Q55.SetDbValue(rsnew, ConvertToBool(Q55.CurrentValue), Q55.ReadOnly);

            // Q56
            Q56.SetDbValue(rsnew, ConvertToBool(Q56.CurrentValue), Q56.ReadOnly);

            // Q57
            Q57.SetDbValue(rsnew, ConvertToBool(Q57.CurrentValue), Q57.ReadOnly);

            // Q58
            Q58.SetDbValue(rsnew, ConvertToBool(Q58.CurrentValue), Q58.ReadOnly);

            // Q59
            Q59.SetDbValue(rsnew, ConvertToBool(Q59.CurrentValue), Q59.ReadOnly);

            // Q60
            Q60.SetDbValue(rsnew, ConvertToBool(Q60.CurrentValue), Q60.ReadOnly);

            // Q61
            Q61.SetDbValue(rsnew, ConvertToBool(Q61.CurrentValue), Q61.ReadOnly);

            // Q62
            Q62.SetDbValue(rsnew, ConvertToBool(Q62.CurrentValue), Q62.ReadOnly);

            // Q63
            Q63.SetDbValue(rsnew, ConvertToBool(Q63.CurrentValue), Q63.ReadOnly);

            // Q64
            Q64.SetDbValue(rsnew, ConvertToBool(Q64.CurrentValue), Q64.ReadOnly);

            // Q65
            Q65.SetDbValue(rsnew, ConvertToBool(Q65.CurrentValue), Q65.ReadOnly);

            // Q66
            Q66.SetDbValue(rsnew, ConvertToBool(Q66.CurrentValue), Q66.ReadOnly);

            // Q67
            Q67.SetDbValue(rsnew, ConvertToBool(Q67.CurrentValue), Q67.ReadOnly);

            // Q68
            Q68.SetDbValue(rsnew, ConvertToBool(Q68.CurrentValue), Q68.ReadOnly);

            // Q69
            Q69.SetDbValue(rsnew, ConvertToBool(Q69.CurrentValue), Q69.ReadOnly);

            // Q70
            Q70.SetDbValue(rsnew, ConvertToBool(Q70.CurrentValue), Q70.ReadOnly);

            // Notes_3
            Notes_3.SetDbValue(rsnew, Notes_3.CurrentValue, Notes_3.ReadOnly);

            // Student_Signature
            Student_Signature.SetDbValue(rsnew, Student_Signature.CurrentValue, Student_Signature.ReadOnly);

            // Examiner_Signature
            Examiner_Signature.SetDbValue(rsnew, Examiner_Signature.CurrentValue, Examiner_Signature.ReadOnly);

            // Retake
            Retake.SetDbValue(rsnew, ConvertToBool(Retake.CurrentValue), Retake.ReadOnly);

            // UserlevelID
            UserlevelID.CurrentValue = UserlevelID.GetAutoUpdateValue();
            UserlevelID.SetDbValue(rsnew, UserlevelID.CurrentValue, false);

            // intEvaluationType
            intEvaluationType.SetDbValue(rsnew, intEvaluationType.CurrentValue, intEvaluationType.ReadOnly);

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
                if (masterTblVar == "tblAssessment") {
                    validMaster = true;
                    if (tblAssessment != null && (Get("fk_AssessmentID", out fk) || Get("AssessmentID", out fk))) {
                        tblAssessment.AssessmentID.QueryValue = fk;
                        AssessmentID.QueryValue = tblAssessment.AssessmentID.QueryValue;
                        AssessmentID.SessionValue = AssessmentID.QueryValue;
                        foreignKeys.Add("AssessmentID", fk);
                        if (!IsNumeric(AssessmentID.QueryValue))
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
                if (masterTblVar == "tblAssessment") {
                    validMaster = true;
                    if (tblAssessment != null && (Post("fk_AssessmentID", out fk) || Post("AssessmentID", out fk))) {
                        tblAssessment.AssessmentID.FormValue = fk;
                        AssessmentID.FormValue = tblAssessment.AssessmentID.FormValue;
                        AssessmentID.SessionValue = AssessmentID.FormValue;
                        foreignKeys.Add("AssessmentID", fk);
                        if (!IsNumeric(AssessmentID.FormValue))
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

                // Clear previous master key from Session
                if (masterTblVar != "tblAssessment") {
                    if (!foreignKeys.ContainsKey("AssessmentID")) // Not current foreign key
                        AssessmentID.SessionValue = "";
                }
            }
            DbMasterFilter = MasterFilterFromSession; // Get master filter from session
            DbDetailFilter = DetailFilterFromSession; // Get detail filter from session
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblEvaluationList")), "", TableVar, true);
            string pageId = "edit";
            breadcrumb.Add("edit", pageId, url);
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

        // Form Custom Validate event
        public virtual bool FormCustomValidate(ref string customError) {
            //Return error message in customError
            return true;
        }
    } // End page class
} // End Partial class
