namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblEvaluationMbList
    /// </summary>
    public static TblEvaluationMbList tblEvaluationMbList
    {
        get => HttpData.Get<TblEvaluationMbList>("tblEvaluationMbList")!;
        set => HttpData["tblEvaluationMbList"] = value;
    }

    /// <summary>
    /// Page class for tblEvaluationMB
    /// </summary>
    public class TblEvaluationMbList : TblEvaluationMbListBase
    {
        // Constructor
        public TblEvaluationMbList(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblEvaluationMbList() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblEvaluationMbListBase : TblEvaluationMb
    {
        // Page ID
        public string PageID = "list";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblEvaluationMB";

        // Page object name
        public string PageObjName = "tblEvaluationMbList";

        // Title
        public string? Title = null; // Title for <title> tag

        // Grid form hidden field names
        public string FormName = "ftblEvaluationMBlist";

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
        public TblEvaluationMbListBase()
        {
            // CSS class name as context
            TableVar = "tblEvaluationMB";
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

            // Table object (tblEvaluationMb)
            if (tblEvaluationMb == null || tblEvaluationMb is TblEvaluationMb)
                tblEvaluationMb = this;

            // Initialize URLs
            AddUrl = "TblEvaluationMbAdd";
            InlineAddUrl = PageUrl + "action=add";
            GridAddUrl = PageUrl + "action=gridadd";
            GridEditUrl = PageUrl + "action=gridedit";
            MultiEditUrl = PageUrl + "action=multiedit";
            MultiDeleteUrl = "TblEvaluationMbDelete";
            MultiUpdateUrl = "TblEvaluationMbUpdate";

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
        public string PageName => "TblEvaluationMbList";

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
            DriveTypelink.SetVisibility();
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

        // Constructor
        public TblEvaluationMbListBase(Controller? controller = null): this() { // DN
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

            // Set up master detail parameters
            SetupMasterParms();

            // Setup other options
            SetupOtherOptions();

            // Set up custom action (compatible with old version)
            ListActions.Add(CustomActions);

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
                tblEvaluationMbList?.PageRender();
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
                savedFilterList = await Profile.GetSearchFilters(CurrentUserName(), "ftblEvaluationMBsrch");

            // Initialize
            var filters = new JObject(); // DN
            filters.Merge(JObject.Parse(Eval_ID.AdvancedSearch.ToJson())); // Field Eval_ID
            filters.Merge(JObject.Parse(int_Student_ID.AdvancedSearch.ToJson())); // Field int_Student_ID
            filters.Merge(JObject.Parse(AssessmentID.AdvancedSearch.ToJson())); // Field AssessmentID
            filters.Merge(JObject.Parse(str_Full_Name_Hdr.AdvancedSearch.ToJson())); // Field str_Full_Name_Hdr
            filters.Merge(JObject.Parse(NationalID.AdvancedSearch.ToJson())); // Field NationalID
            filters.Merge(JObject.Parse(str_Cell_Phone.AdvancedSearch.ToJson())); // Field str_Cell_Phone
            filters.Merge(JObject.Parse(str_Username.AdvancedSearch.ToJson())); // Field str_Username
            filters.Merge(JObject.Parse(intDrivinglicenseType.AdvancedSearch.ToJson())); // Field intDrivinglicenseType
            filters.Merge(JObject.Parse(Date_Entered.AdvancedSearch.ToJson())); // Field Date_Entered
            filters.Merge(JObject.Parse(Examination_Number.AdvancedSearch.ToJson())); // Field Examination_Number
            filters.Merge(JObject.Parse(Retake.AdvancedSearch.ToJson())); // Field Retake
            filters.Merge(JObject.Parse(Section_1.AdvancedSearch.ToJson())); // Field Section_1
            filters.Merge(JObject.Parse(Q1.AdvancedSearch.ToJson())); // Field Q1
            filters.Merge(JObject.Parse(Q2.AdvancedSearch.ToJson())); // Field Q2
            filters.Merge(JObject.Parse(Q3.AdvancedSearch.ToJson())); // Field Q3
            filters.Merge(JObject.Parse(Q4.AdvancedSearch.ToJson())); // Field Q4
            filters.Merge(JObject.Parse(Q5.AdvancedSearch.ToJson())); // Field Q5
            filters.Merge(JObject.Parse(Section_2.AdvancedSearch.ToJson())); // Field Section_2
            filters.Merge(JObject.Parse(Q6.AdvancedSearch.ToJson())); // Field Q6
            filters.Merge(JObject.Parse(Q7.AdvancedSearch.ToJson())); // Field Q7
            filters.Merge(JObject.Parse(Q8.AdvancedSearch.ToJson())); // Field Q8
            filters.Merge(JObject.Parse(Q9.AdvancedSearch.ToJson())); // Field Q9
            filters.Merge(JObject.Parse(Q10.AdvancedSearch.ToJson())); // Field Q10
            filters.Merge(JObject.Parse(Q11.AdvancedSearch.ToJson())); // Field Q11
            filters.Merge(JObject.Parse(Q12.AdvancedSearch.ToJson())); // Field Q12
            filters.Merge(JObject.Parse(Q13.AdvancedSearch.ToJson())); // Field Q13
            filters.Merge(JObject.Parse(Q14.AdvancedSearch.ToJson())); // Field Q14
            filters.Merge(JObject.Parse(Q15.AdvancedSearch.ToJson())); // Field Q15
            filters.Merge(JObject.Parse(Section_3.AdvancedSearch.ToJson())); // Field Section_3
            filters.Merge(JObject.Parse(Q16.AdvancedSearch.ToJson())); // Field Q16
            filters.Merge(JObject.Parse(Q17.AdvancedSearch.ToJson())); // Field Q17
            filters.Merge(JObject.Parse(Q18.AdvancedSearch.ToJson())); // Field Q18
            filters.Merge(JObject.Parse(Q19.AdvancedSearch.ToJson())); // Field Q19
            filters.Merge(JObject.Parse(Q20.AdvancedSearch.ToJson())); // Field Q20
            filters.Merge(JObject.Parse(Q21.AdvancedSearch.ToJson())); // Field Q21
            filters.Merge(JObject.Parse(Section_4.AdvancedSearch.ToJson())); // Field Section_4
            filters.Merge(JObject.Parse(Q22.AdvancedSearch.ToJson())); // Field Q22
            filters.Merge(JObject.Parse(Q23.AdvancedSearch.ToJson())); // Field Q23
            filters.Merge(JObject.Parse(Q24.AdvancedSearch.ToJson())); // Field Q24
            filters.Merge(JObject.Parse(Q25.AdvancedSearch.ToJson())); // Field Q25
            filters.Merge(JObject.Parse(Q26.AdvancedSearch.ToJson())); // Field Q26
            filters.Merge(JObject.Parse(Section_5.AdvancedSearch.ToJson())); // Field Section_5
            filters.Merge(JObject.Parse(Q27.AdvancedSearch.ToJson())); // Field Q27
            filters.Merge(JObject.Parse(Q28.AdvancedSearch.ToJson())); // Field Q28
            filters.Merge(JObject.Parse(Q29.AdvancedSearch.ToJson())); // Field Q29
            filters.Merge(JObject.Parse(Q30.AdvancedSearch.ToJson())); // Field Q30
            filters.Merge(JObject.Parse(Q31.AdvancedSearch.ToJson())); // Field Q31
            filters.Merge(JObject.Parse(Q32.AdvancedSearch.ToJson())); // Field Q32
            filters.Merge(JObject.Parse(Q33.AdvancedSearch.ToJson())); // Field Q33
            filters.Merge(JObject.Parse(Q34.AdvancedSearch.ToJson())); // Field Q34
            filters.Merge(JObject.Parse(Q35.AdvancedSearch.ToJson())); // Field Q35
            filters.Merge(JObject.Parse(Section_6.AdvancedSearch.ToJson())); // Field Section_6
            filters.Merge(JObject.Parse(Q36.AdvancedSearch.ToJson())); // Field Q36
            filters.Merge(JObject.Parse(Q37.AdvancedSearch.ToJson())); // Field Q37
            filters.Merge(JObject.Parse(Q38.AdvancedSearch.ToJson())); // Field Q38
            filters.Merge(JObject.Parse(Q39.AdvancedSearch.ToJson())); // Field Q39
            filters.Merge(JObject.Parse(Q40.AdvancedSearch.ToJson())); // Field Q40
            filters.Merge(JObject.Parse(Q41.AdvancedSearch.ToJson())); // Field Q41
            filters.Merge(JObject.Parse(Q42.AdvancedSearch.ToJson())); // Field Q42
            filters.Merge(JObject.Parse(Q43.AdvancedSearch.ToJson())); // Field Q43
            filters.Merge(JObject.Parse(Section_7.AdvancedSearch.ToJson())); // Field Section_7
            filters.Merge(JObject.Parse(Q44.AdvancedSearch.ToJson())); // Field Q44
            filters.Merge(JObject.Parse(Q45.AdvancedSearch.ToJson())); // Field Q45
            filters.Merge(JObject.Parse(Q46.AdvancedSearch.ToJson())); // Field Q46
            filters.Merge(JObject.Parse(Q47.AdvancedSearch.ToJson())); // Field Q47
            filters.Merge(JObject.Parse(Q48.AdvancedSearch.ToJson())); // Field Q48
            filters.Merge(JObject.Parse(Q49.AdvancedSearch.ToJson())); // Field Q49
            filters.Merge(JObject.Parse(Q50.AdvancedSearch.ToJson())); // Field Q50
            filters.Merge(JObject.Parse(Section_8.AdvancedSearch.ToJson())); // Field Section_8
            filters.Merge(JObject.Parse(Q51.AdvancedSearch.ToJson())); // Field Q51
            filters.Merge(JObject.Parse(Q52.AdvancedSearch.ToJson())); // Field Q52
            filters.Merge(JObject.Parse(Q53.AdvancedSearch.ToJson())); // Field Q53
            filters.Merge(JObject.Parse(Q54.AdvancedSearch.ToJson())); // Field Q54
            filters.Merge(JObject.Parse(Q55.AdvancedSearch.ToJson())); // Field Q55
            filters.Merge(JObject.Parse(Section_9.AdvancedSearch.ToJson())); // Field Section_9
            filters.Merge(JObject.Parse(Q56.AdvancedSearch.ToJson())); // Field Q56
            filters.Merge(JObject.Parse(Q57.AdvancedSearch.ToJson())); // Field Q57
            filters.Merge(JObject.Parse(Q58.AdvancedSearch.ToJson())); // Field Q58
            filters.Merge(JObject.Parse(Q59.AdvancedSearch.ToJson())); // Field Q59
            filters.Merge(JObject.Parse(Section_10.AdvancedSearch.ToJson())); // Field Section_10
            filters.Merge(JObject.Parse(Q60.AdvancedSearch.ToJson())); // Field Q60
            filters.Merge(JObject.Parse(Q61.AdvancedSearch.ToJson())); // Field Q61
            filters.Merge(JObject.Parse(Q62.AdvancedSearch.ToJson())); // Field Q62
            filters.Merge(JObject.Parse(Q63.AdvancedSearch.ToJson())); // Field Q63
            filters.Merge(JObject.Parse(Q64.AdvancedSearch.ToJson())); // Field Q64
            filters.Merge(JObject.Parse(Q65.AdvancedSearch.ToJson())); // Field Q65
            filters.Merge(JObject.Parse(Section_11.AdvancedSearch.ToJson())); // Field Section_11
            filters.Merge(JObject.Parse(Q66.AdvancedSearch.ToJson())); // Field Q66
            filters.Merge(JObject.Parse(Q67.AdvancedSearch.ToJson())); // Field Q67
            filters.Merge(JObject.Parse(Q68.AdvancedSearch.ToJson())); // Field Q68
            filters.Merge(JObject.Parse(Q69.AdvancedSearch.ToJson())); // Field Q69
            filters.Merge(JObject.Parse(Q70.AdvancedSearch.ToJson())); // Field Q70
            filters.Merge(JObject.Parse(Notes_3.AdvancedSearch.ToJson())); // Field Notes_3
            filters.Merge(JObject.Parse(Examiner_Signature.AdvancedSearch.ToJson())); // Field Examiner_Signature
            filters.Merge(JObject.Parse(Student_Signature.AdvancedSearch.ToJson())); // Field Student_Signature
            filters.Merge(JObject.Parse(AbsherApptNbr.AdvancedSearch.ToJson())); // Field AbsherApptNbr
            filters.Merge(JObject.Parse(IsDrivingexperience.AdvancedSearch.ToJson())); // Field IsDrivingexperience
            filters.Merge(JObject.Parse(date_Birth_Hijri.AdvancedSearch.ToJson())); // Field date_Birth_Hijri
            filters.Merge(JObject.Parse(date_Birth.AdvancedSearch.ToJson())); // Field date_Birth
            filters.Merge(JObject.Parse(str_Email.AdvancedSearch.ToJson())); // Field str_Email
            filters.Merge(JObject.Parse(UserlevelID.AdvancedSearch.ToJson())); // Field UserlevelID
            filters.Merge(JObject.Parse(DriveTypelink.AdvancedSearch.ToJson())); // Field DriveTypelink
            filters.Merge(JObject.Parse(intEvaluationType.AdvancedSearch.ToJson())); // Field intEvaluationType
            filters.Merge(JObject.Parse(Institution.AdvancedSearch.ToJson())); // Field Institution
            filters.Merge(JObject.Parse(Scores_S1.AdvancedSearch.ToJson())); // Field Scores_S1
            filters.Merge(JObject.Parse(S1.AdvancedSearch.ToJson())); // Field S1
            filters.Merge(JObject.Parse(S2.AdvancedSearch.ToJson())); // Field S2
            filters.Merge(JObject.Parse(S3.AdvancedSearch.ToJson())); // Field S3
            filters.Merge(JObject.Parse(S4.AdvancedSearch.ToJson())); // Field S4
            filters.Merge(JObject.Parse(S5.AdvancedSearch.ToJson())); // Field S5
            filters.Merge(JObject.Parse(Scores_S2.AdvancedSearch.ToJson())); // Field Scores_S2
            filters.Merge(JObject.Parse(S6.AdvancedSearch.ToJson())); // Field S6
            filters.Merge(JObject.Parse(S7.AdvancedSearch.ToJson())); // Field S7
            filters.Merge(JObject.Parse(S8.AdvancedSearch.ToJson())); // Field S8
            filters.Merge(JObject.Parse(S9.AdvancedSearch.ToJson())); // Field S9
            filters.Merge(JObject.Parse(S10.AdvancedSearch.ToJson())); // Field S10
            filters.Merge(JObject.Parse(S11.AdvancedSearch.ToJson())); // Field S11
            filters.Merge(JObject.Parse(S12.AdvancedSearch.ToJson())); // Field S12
            filters.Merge(JObject.Parse(S13.AdvancedSearch.ToJson())); // Field S13
            filters.Merge(JObject.Parse(S14.AdvancedSearch.ToJson())); // Field S14
            filters.Merge(JObject.Parse(S15.AdvancedSearch.ToJson())); // Field S15
            filters.Merge(JObject.Parse(Scores_S3.AdvancedSearch.ToJson())); // Field Scores_S3
            filters.Merge(JObject.Parse(S16.AdvancedSearch.ToJson())); // Field S16
            filters.Merge(JObject.Parse(S17.AdvancedSearch.ToJson())); // Field S17
            filters.Merge(JObject.Parse(S18.AdvancedSearch.ToJson())); // Field S18
            filters.Merge(JObject.Parse(S19.AdvancedSearch.ToJson())); // Field S19
            filters.Merge(JObject.Parse(S20.AdvancedSearch.ToJson())); // Field S20
            filters.Merge(JObject.Parse(S21.AdvancedSearch.ToJson())); // Field S21
            filters.Merge(JObject.Parse(Scores_S4.AdvancedSearch.ToJson())); // Field Scores_S4
            filters.Merge(JObject.Parse(S22.AdvancedSearch.ToJson())); // Field S22
            filters.Merge(JObject.Parse(S23.AdvancedSearch.ToJson())); // Field S23
            filters.Merge(JObject.Parse(S24.AdvancedSearch.ToJson())); // Field S24
            filters.Merge(JObject.Parse(S25.AdvancedSearch.ToJson())); // Field S25
            filters.Merge(JObject.Parse(S26.AdvancedSearch.ToJson())); // Field S26
            filters.Merge(JObject.Parse(Scores_S5.AdvancedSearch.ToJson())); // Field Scores_S5
            filters.Merge(JObject.Parse(S27.AdvancedSearch.ToJson())); // Field S27
            filters.Merge(JObject.Parse(S28.AdvancedSearch.ToJson())); // Field S28
            filters.Merge(JObject.Parse(S29.AdvancedSearch.ToJson())); // Field S29
            filters.Merge(JObject.Parse(S30.AdvancedSearch.ToJson())); // Field S30
            filters.Merge(JObject.Parse(S31.AdvancedSearch.ToJson())); // Field S31
            filters.Merge(JObject.Parse(S32.AdvancedSearch.ToJson())); // Field S32
            filters.Merge(JObject.Parse(S33.AdvancedSearch.ToJson())); // Field S33
            filters.Merge(JObject.Parse(S34.AdvancedSearch.ToJson())); // Field S34
            filters.Merge(JObject.Parse(S35.AdvancedSearch.ToJson())); // Field S35
            filters.Merge(JObject.Parse(Scores_S6.AdvancedSearch.ToJson())); // Field Scores_S6
            filters.Merge(JObject.Parse(S36.AdvancedSearch.ToJson())); // Field S36
            filters.Merge(JObject.Parse(S37.AdvancedSearch.ToJson())); // Field S37
            filters.Merge(JObject.Parse(S38.AdvancedSearch.ToJson())); // Field S38
            filters.Merge(JObject.Parse(S39.AdvancedSearch.ToJson())); // Field S39
            filters.Merge(JObject.Parse(S40.AdvancedSearch.ToJson())); // Field S40
            filters.Merge(JObject.Parse(S41.AdvancedSearch.ToJson())); // Field S41
            filters.Merge(JObject.Parse(S42.AdvancedSearch.ToJson())); // Field S42
            filters.Merge(JObject.Parse(S43.AdvancedSearch.ToJson())); // Field S43
            filters.Merge(JObject.Parse(Scores_S7.AdvancedSearch.ToJson())); // Field Scores_S7
            filters.Merge(JObject.Parse(S44.AdvancedSearch.ToJson())); // Field S44
            filters.Merge(JObject.Parse(S45.AdvancedSearch.ToJson())); // Field S45
            filters.Merge(JObject.Parse(S46.AdvancedSearch.ToJson())); // Field S46
            filters.Merge(JObject.Parse(S47.AdvancedSearch.ToJson())); // Field S47
            filters.Merge(JObject.Parse(S48.AdvancedSearch.ToJson())); // Field S48
            filters.Merge(JObject.Parse(S49.AdvancedSearch.ToJson())); // Field S49
            filters.Merge(JObject.Parse(S50.AdvancedSearch.ToJson())); // Field S50
            filters.Merge(JObject.Parse(Scores_S8.AdvancedSearch.ToJson())); // Field Scores_S8
            filters.Merge(JObject.Parse(S51.AdvancedSearch.ToJson())); // Field S51
            filters.Merge(JObject.Parse(S52.AdvancedSearch.ToJson())); // Field S52
            filters.Merge(JObject.Parse(S53.AdvancedSearch.ToJson())); // Field S53
            filters.Merge(JObject.Parse(S54.AdvancedSearch.ToJson())); // Field S54
            filters.Merge(JObject.Parse(S55.AdvancedSearch.ToJson())); // Field S55
            filters.Merge(JObject.Parse(Scores_S9.AdvancedSearch.ToJson())); // Field Scores_S9
            filters.Merge(JObject.Parse(S56.AdvancedSearch.ToJson())); // Field S56
            filters.Merge(JObject.Parse(S57.AdvancedSearch.ToJson())); // Field S57
            filters.Merge(JObject.Parse(S58.AdvancedSearch.ToJson())); // Field S58
            filters.Merge(JObject.Parse(S59.AdvancedSearch.ToJson())); // Field S59
            filters.Merge(JObject.Parse(Scores_S10.AdvancedSearch.ToJson())); // Field Scores_S10
            filters.Merge(JObject.Parse(S60.AdvancedSearch.ToJson())); // Field S60
            filters.Merge(JObject.Parse(S61.AdvancedSearch.ToJson())); // Field S61
            filters.Merge(JObject.Parse(S62.AdvancedSearch.ToJson())); // Field S62
            filters.Merge(JObject.Parse(S63.AdvancedSearch.ToJson())); // Field S63
            filters.Merge(JObject.Parse(S64.AdvancedSearch.ToJson())); // Field S64
            filters.Merge(JObject.Parse(S65.AdvancedSearch.ToJson())); // Field S65
            filters.Merge(JObject.Parse(Scores_S11.AdvancedSearch.ToJson())); // Field Scores_S11
            filters.Merge(JObject.Parse(S66.AdvancedSearch.ToJson())); // Field S66
            filters.Merge(JObject.Parse(S67.AdvancedSearch.ToJson())); // Field S67
            filters.Merge(JObject.Parse(S68.AdvancedSearch.ToJson())); // Field S68
            filters.Merge(JObject.Parse(S69.AdvancedSearch.ToJson())); // Field S69
            filters.Merge(JObject.Parse(S70.AdvancedSearch.ToJson())); // Field S70
            filters.Merge(JObject.Parse(Evaluation_Score.AdvancedSearch.ToJson())); // Field Evaluation_Score
            filters.Merge(JObject.Parse(Immediate_Failure_Score.AdvancedSearch.ToJson())); // Field Immediate_Failure_Score
            filters.Merge(JObject.Parse(Required_Program.AdvancedSearch.ToJson())); // Field Required_Program
            filters.Merge(JObject.Parse(Price.AdvancedSearch.ToJson())); // Field Price
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
                await Profile.SetSearchFilters(CurrentUserName(), "ftblEvaluationMBsrch", filters);
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

            // Field Eval_ID
            if (filter?.TryGetValue("x_Eval_ID", out sv) ?? false) {
                Eval_ID.AdvancedSearch.SearchValue = sv;
                Eval_ID.AdvancedSearch.SearchOperator = filter["z_Eval_ID"];
                Eval_ID.AdvancedSearch.SearchCondition = filter["v_Eval_ID"];
                Eval_ID.AdvancedSearch.SearchValue2 = filter["y_Eval_ID"];
                Eval_ID.AdvancedSearch.SearchOperator2 = filter["w_Eval_ID"];
                Eval_ID.AdvancedSearch.Save();
            }

            // Field int_Student_ID
            if (filter?.TryGetValue("x_int_Student_ID", out sv) ?? false) {
                int_Student_ID.AdvancedSearch.SearchValue = sv;
                int_Student_ID.AdvancedSearch.SearchOperator = filter["z_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchCondition = filter["v_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchValue2 = filter["y_int_Student_ID"];
                int_Student_ID.AdvancedSearch.SearchOperator2 = filter["w_int_Student_ID"];
                int_Student_ID.AdvancedSearch.Save();
            }

            // Field AssessmentID
            if (filter?.TryGetValue("x_AssessmentID", out sv) ?? false) {
                AssessmentID.AdvancedSearch.SearchValue = sv;
                AssessmentID.AdvancedSearch.SearchOperator = filter["z_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchCondition = filter["v_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchValue2 = filter["y_AssessmentID"];
                AssessmentID.AdvancedSearch.SearchOperator2 = filter["w_AssessmentID"];
                AssessmentID.AdvancedSearch.Save();
            }

            // Field str_Full_Name_Hdr
            if (filter?.TryGetValue("x_str_Full_Name_Hdr", out sv) ?? false) {
                str_Full_Name_Hdr.AdvancedSearch.SearchValue = sv;
                str_Full_Name_Hdr.AdvancedSearch.SearchOperator = filter["z_str_Full_Name_Hdr"];
                str_Full_Name_Hdr.AdvancedSearch.SearchCondition = filter["v_str_Full_Name_Hdr"];
                str_Full_Name_Hdr.AdvancedSearch.SearchValue2 = filter["y_str_Full_Name_Hdr"];
                str_Full_Name_Hdr.AdvancedSearch.SearchOperator2 = filter["w_str_Full_Name_Hdr"];
                str_Full_Name_Hdr.AdvancedSearch.Save();
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

            // Field str_Cell_Phone
            if (filter?.TryGetValue("x_str_Cell_Phone", out sv) ?? false) {
                str_Cell_Phone.AdvancedSearch.SearchValue = sv;
                str_Cell_Phone.AdvancedSearch.SearchOperator = filter["z_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchCondition = filter["v_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchValue2 = filter["y_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.SearchOperator2 = filter["w_str_Cell_Phone"];
                str_Cell_Phone.AdvancedSearch.Save();
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

            // Field intDrivinglicenseType
            if (filter?.TryGetValue("x_intDrivinglicenseType", out sv) ?? false) {
                intDrivinglicenseType.AdvancedSearch.SearchValue = sv;
                intDrivinglicenseType.AdvancedSearch.SearchOperator = filter["z_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchCondition = filter["v_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchValue2 = filter["y_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.SearchOperator2 = filter["w_intDrivinglicenseType"];
                intDrivinglicenseType.AdvancedSearch.Save();
            }

            // Field Date_Entered
            if (filter?.TryGetValue("x_Date_Entered", out sv) ?? false) {
                Date_Entered.AdvancedSearch.SearchValue = sv;
                Date_Entered.AdvancedSearch.SearchOperator = filter["z_Date_Entered"];
                Date_Entered.AdvancedSearch.SearchCondition = filter["v_Date_Entered"];
                Date_Entered.AdvancedSearch.SearchValue2 = filter["y_Date_Entered"];
                Date_Entered.AdvancedSearch.SearchOperator2 = filter["w_Date_Entered"];
                Date_Entered.AdvancedSearch.Save();
            }

            // Field Examination_Number
            if (filter?.TryGetValue("x_Examination_Number", out sv) ?? false) {
                Examination_Number.AdvancedSearch.SearchValue = sv;
                Examination_Number.AdvancedSearch.SearchOperator = filter["z_Examination_Number"];
                Examination_Number.AdvancedSearch.SearchCondition = filter["v_Examination_Number"];
                Examination_Number.AdvancedSearch.SearchValue2 = filter["y_Examination_Number"];
                Examination_Number.AdvancedSearch.SearchOperator2 = filter["w_Examination_Number"];
                Examination_Number.AdvancedSearch.Save();
            }

            // Field Retake
            if (filter?.TryGetValue("x_Retake", out sv) ?? false) {
                Retake.AdvancedSearch.SearchValue = sv;
                Retake.AdvancedSearch.SearchOperator = filter["z_Retake"];
                Retake.AdvancedSearch.SearchCondition = filter["v_Retake"];
                Retake.AdvancedSearch.SearchValue2 = filter["y_Retake"];
                Retake.AdvancedSearch.SearchOperator2 = filter["w_Retake"];
                Retake.AdvancedSearch.Save();
            }

            // Field Section_1
            if (filter?.TryGetValue("x_Section_1", out sv) ?? false) {
                Section_1.AdvancedSearch.SearchValue = sv;
                Section_1.AdvancedSearch.SearchOperator = filter["z_Section_1"];
                Section_1.AdvancedSearch.SearchCondition = filter["v_Section_1"];
                Section_1.AdvancedSearch.SearchValue2 = filter["y_Section_1"];
                Section_1.AdvancedSearch.SearchOperator2 = filter["w_Section_1"];
                Section_1.AdvancedSearch.Save();
            }

            // Field Q1
            if (filter?.TryGetValue("x_Q1", out sv) ?? false) {
                Q1.AdvancedSearch.SearchValue = sv;
                Q1.AdvancedSearch.SearchOperator = filter["z_Q1"];
                Q1.AdvancedSearch.SearchCondition = filter["v_Q1"];
                Q1.AdvancedSearch.SearchValue2 = filter["y_Q1"];
                Q1.AdvancedSearch.SearchOperator2 = filter["w_Q1"];
                Q1.AdvancedSearch.Save();
            }

            // Field Q2
            if (filter?.TryGetValue("x_Q2", out sv) ?? false) {
                Q2.AdvancedSearch.SearchValue = sv;
                Q2.AdvancedSearch.SearchOperator = filter["z_Q2"];
                Q2.AdvancedSearch.SearchCondition = filter["v_Q2"];
                Q2.AdvancedSearch.SearchValue2 = filter["y_Q2"];
                Q2.AdvancedSearch.SearchOperator2 = filter["w_Q2"];
                Q2.AdvancedSearch.Save();
            }

            // Field Q3
            if (filter?.TryGetValue("x_Q3", out sv) ?? false) {
                Q3.AdvancedSearch.SearchValue = sv;
                Q3.AdvancedSearch.SearchOperator = filter["z_Q3"];
                Q3.AdvancedSearch.SearchCondition = filter["v_Q3"];
                Q3.AdvancedSearch.SearchValue2 = filter["y_Q3"];
                Q3.AdvancedSearch.SearchOperator2 = filter["w_Q3"];
                Q3.AdvancedSearch.Save();
            }

            // Field Q4
            if (filter?.TryGetValue("x_Q4", out sv) ?? false) {
                Q4.AdvancedSearch.SearchValue = sv;
                Q4.AdvancedSearch.SearchOperator = filter["z_Q4"];
                Q4.AdvancedSearch.SearchCondition = filter["v_Q4"];
                Q4.AdvancedSearch.SearchValue2 = filter["y_Q4"];
                Q4.AdvancedSearch.SearchOperator2 = filter["w_Q4"];
                Q4.AdvancedSearch.Save();
            }

            // Field Q5
            if (filter?.TryGetValue("x_Q5", out sv) ?? false) {
                Q5.AdvancedSearch.SearchValue = sv;
                Q5.AdvancedSearch.SearchOperator = filter["z_Q5"];
                Q5.AdvancedSearch.SearchCondition = filter["v_Q5"];
                Q5.AdvancedSearch.SearchValue2 = filter["y_Q5"];
                Q5.AdvancedSearch.SearchOperator2 = filter["w_Q5"];
                Q5.AdvancedSearch.Save();
            }

            // Field Section_2
            if (filter?.TryGetValue("x_Section_2", out sv) ?? false) {
                Section_2.AdvancedSearch.SearchValue = sv;
                Section_2.AdvancedSearch.SearchOperator = filter["z_Section_2"];
                Section_2.AdvancedSearch.SearchCondition = filter["v_Section_2"];
                Section_2.AdvancedSearch.SearchValue2 = filter["y_Section_2"];
                Section_2.AdvancedSearch.SearchOperator2 = filter["w_Section_2"];
                Section_2.AdvancedSearch.Save();
            }

            // Field Q6
            if (filter?.TryGetValue("x_Q6", out sv) ?? false) {
                Q6.AdvancedSearch.SearchValue = sv;
                Q6.AdvancedSearch.SearchOperator = filter["z_Q6"];
                Q6.AdvancedSearch.SearchCondition = filter["v_Q6"];
                Q6.AdvancedSearch.SearchValue2 = filter["y_Q6"];
                Q6.AdvancedSearch.SearchOperator2 = filter["w_Q6"];
                Q6.AdvancedSearch.Save();
            }

            // Field Q7
            if (filter?.TryGetValue("x_Q7", out sv) ?? false) {
                Q7.AdvancedSearch.SearchValue = sv;
                Q7.AdvancedSearch.SearchOperator = filter["z_Q7"];
                Q7.AdvancedSearch.SearchCondition = filter["v_Q7"];
                Q7.AdvancedSearch.SearchValue2 = filter["y_Q7"];
                Q7.AdvancedSearch.SearchOperator2 = filter["w_Q7"];
                Q7.AdvancedSearch.Save();
            }

            // Field Q8
            if (filter?.TryGetValue("x_Q8", out sv) ?? false) {
                Q8.AdvancedSearch.SearchValue = sv;
                Q8.AdvancedSearch.SearchOperator = filter["z_Q8"];
                Q8.AdvancedSearch.SearchCondition = filter["v_Q8"];
                Q8.AdvancedSearch.SearchValue2 = filter["y_Q8"];
                Q8.AdvancedSearch.SearchOperator2 = filter["w_Q8"];
                Q8.AdvancedSearch.Save();
            }

            // Field Q9
            if (filter?.TryGetValue("x_Q9", out sv) ?? false) {
                Q9.AdvancedSearch.SearchValue = sv;
                Q9.AdvancedSearch.SearchOperator = filter["z_Q9"];
                Q9.AdvancedSearch.SearchCondition = filter["v_Q9"];
                Q9.AdvancedSearch.SearchValue2 = filter["y_Q9"];
                Q9.AdvancedSearch.SearchOperator2 = filter["w_Q9"];
                Q9.AdvancedSearch.Save();
            }

            // Field Q10
            if (filter?.TryGetValue("x_Q10", out sv) ?? false) {
                Q10.AdvancedSearch.SearchValue = sv;
                Q10.AdvancedSearch.SearchOperator = filter["z_Q10"];
                Q10.AdvancedSearch.SearchCondition = filter["v_Q10"];
                Q10.AdvancedSearch.SearchValue2 = filter["y_Q10"];
                Q10.AdvancedSearch.SearchOperator2 = filter["w_Q10"];
                Q10.AdvancedSearch.Save();
            }

            // Field Q11
            if (filter?.TryGetValue("x_Q11", out sv) ?? false) {
                Q11.AdvancedSearch.SearchValue = sv;
                Q11.AdvancedSearch.SearchOperator = filter["z_Q11"];
                Q11.AdvancedSearch.SearchCondition = filter["v_Q11"];
                Q11.AdvancedSearch.SearchValue2 = filter["y_Q11"];
                Q11.AdvancedSearch.SearchOperator2 = filter["w_Q11"];
                Q11.AdvancedSearch.Save();
            }

            // Field Q12
            if (filter?.TryGetValue("x_Q12", out sv) ?? false) {
                Q12.AdvancedSearch.SearchValue = sv;
                Q12.AdvancedSearch.SearchOperator = filter["z_Q12"];
                Q12.AdvancedSearch.SearchCondition = filter["v_Q12"];
                Q12.AdvancedSearch.SearchValue2 = filter["y_Q12"];
                Q12.AdvancedSearch.SearchOperator2 = filter["w_Q12"];
                Q12.AdvancedSearch.Save();
            }

            // Field Q13
            if (filter?.TryGetValue("x_Q13", out sv) ?? false) {
                Q13.AdvancedSearch.SearchValue = sv;
                Q13.AdvancedSearch.SearchOperator = filter["z_Q13"];
                Q13.AdvancedSearch.SearchCondition = filter["v_Q13"];
                Q13.AdvancedSearch.SearchValue2 = filter["y_Q13"];
                Q13.AdvancedSearch.SearchOperator2 = filter["w_Q13"];
                Q13.AdvancedSearch.Save();
            }

            // Field Q14
            if (filter?.TryGetValue("x_Q14", out sv) ?? false) {
                Q14.AdvancedSearch.SearchValue = sv;
                Q14.AdvancedSearch.SearchOperator = filter["z_Q14"];
                Q14.AdvancedSearch.SearchCondition = filter["v_Q14"];
                Q14.AdvancedSearch.SearchValue2 = filter["y_Q14"];
                Q14.AdvancedSearch.SearchOperator2 = filter["w_Q14"];
                Q14.AdvancedSearch.Save();
            }

            // Field Q15
            if (filter?.TryGetValue("x_Q15", out sv) ?? false) {
                Q15.AdvancedSearch.SearchValue = sv;
                Q15.AdvancedSearch.SearchOperator = filter["z_Q15"];
                Q15.AdvancedSearch.SearchCondition = filter["v_Q15"];
                Q15.AdvancedSearch.SearchValue2 = filter["y_Q15"];
                Q15.AdvancedSearch.SearchOperator2 = filter["w_Q15"];
                Q15.AdvancedSearch.Save();
            }

            // Field Section_3
            if (filter?.TryGetValue("x_Section_3", out sv) ?? false) {
                Section_3.AdvancedSearch.SearchValue = sv;
                Section_3.AdvancedSearch.SearchOperator = filter["z_Section_3"];
                Section_3.AdvancedSearch.SearchCondition = filter["v_Section_3"];
                Section_3.AdvancedSearch.SearchValue2 = filter["y_Section_3"];
                Section_3.AdvancedSearch.SearchOperator2 = filter["w_Section_3"];
                Section_3.AdvancedSearch.Save();
            }

            // Field Q16
            if (filter?.TryGetValue("x_Q16", out sv) ?? false) {
                Q16.AdvancedSearch.SearchValue = sv;
                Q16.AdvancedSearch.SearchOperator = filter["z_Q16"];
                Q16.AdvancedSearch.SearchCondition = filter["v_Q16"];
                Q16.AdvancedSearch.SearchValue2 = filter["y_Q16"];
                Q16.AdvancedSearch.SearchOperator2 = filter["w_Q16"];
                Q16.AdvancedSearch.Save();
            }

            // Field Q17
            if (filter?.TryGetValue("x_Q17", out sv) ?? false) {
                Q17.AdvancedSearch.SearchValue = sv;
                Q17.AdvancedSearch.SearchOperator = filter["z_Q17"];
                Q17.AdvancedSearch.SearchCondition = filter["v_Q17"];
                Q17.AdvancedSearch.SearchValue2 = filter["y_Q17"];
                Q17.AdvancedSearch.SearchOperator2 = filter["w_Q17"];
                Q17.AdvancedSearch.Save();
            }

            // Field Q18
            if (filter?.TryGetValue("x_Q18", out sv) ?? false) {
                Q18.AdvancedSearch.SearchValue = sv;
                Q18.AdvancedSearch.SearchOperator = filter["z_Q18"];
                Q18.AdvancedSearch.SearchCondition = filter["v_Q18"];
                Q18.AdvancedSearch.SearchValue2 = filter["y_Q18"];
                Q18.AdvancedSearch.SearchOperator2 = filter["w_Q18"];
                Q18.AdvancedSearch.Save();
            }

            // Field Q19
            if (filter?.TryGetValue("x_Q19", out sv) ?? false) {
                Q19.AdvancedSearch.SearchValue = sv;
                Q19.AdvancedSearch.SearchOperator = filter["z_Q19"];
                Q19.AdvancedSearch.SearchCondition = filter["v_Q19"];
                Q19.AdvancedSearch.SearchValue2 = filter["y_Q19"];
                Q19.AdvancedSearch.SearchOperator2 = filter["w_Q19"];
                Q19.AdvancedSearch.Save();
            }

            // Field Q20
            if (filter?.TryGetValue("x_Q20", out sv) ?? false) {
                Q20.AdvancedSearch.SearchValue = sv;
                Q20.AdvancedSearch.SearchOperator = filter["z_Q20"];
                Q20.AdvancedSearch.SearchCondition = filter["v_Q20"];
                Q20.AdvancedSearch.SearchValue2 = filter["y_Q20"];
                Q20.AdvancedSearch.SearchOperator2 = filter["w_Q20"];
                Q20.AdvancedSearch.Save();
            }

            // Field Q21
            if (filter?.TryGetValue("x_Q21", out sv) ?? false) {
                Q21.AdvancedSearch.SearchValue = sv;
                Q21.AdvancedSearch.SearchOperator = filter["z_Q21"];
                Q21.AdvancedSearch.SearchCondition = filter["v_Q21"];
                Q21.AdvancedSearch.SearchValue2 = filter["y_Q21"];
                Q21.AdvancedSearch.SearchOperator2 = filter["w_Q21"];
                Q21.AdvancedSearch.Save();
            }

            // Field Section_4
            if (filter?.TryGetValue("x_Section_4", out sv) ?? false) {
                Section_4.AdvancedSearch.SearchValue = sv;
                Section_4.AdvancedSearch.SearchOperator = filter["z_Section_4"];
                Section_4.AdvancedSearch.SearchCondition = filter["v_Section_4"];
                Section_4.AdvancedSearch.SearchValue2 = filter["y_Section_4"];
                Section_4.AdvancedSearch.SearchOperator2 = filter["w_Section_4"];
                Section_4.AdvancedSearch.Save();
            }

            // Field Q22
            if (filter?.TryGetValue("x_Q22", out sv) ?? false) {
                Q22.AdvancedSearch.SearchValue = sv;
                Q22.AdvancedSearch.SearchOperator = filter["z_Q22"];
                Q22.AdvancedSearch.SearchCondition = filter["v_Q22"];
                Q22.AdvancedSearch.SearchValue2 = filter["y_Q22"];
                Q22.AdvancedSearch.SearchOperator2 = filter["w_Q22"];
                Q22.AdvancedSearch.Save();
            }

            // Field Q23
            if (filter?.TryGetValue("x_Q23", out sv) ?? false) {
                Q23.AdvancedSearch.SearchValue = sv;
                Q23.AdvancedSearch.SearchOperator = filter["z_Q23"];
                Q23.AdvancedSearch.SearchCondition = filter["v_Q23"];
                Q23.AdvancedSearch.SearchValue2 = filter["y_Q23"];
                Q23.AdvancedSearch.SearchOperator2 = filter["w_Q23"];
                Q23.AdvancedSearch.Save();
            }

            // Field Q24
            if (filter?.TryGetValue("x_Q24", out sv) ?? false) {
                Q24.AdvancedSearch.SearchValue = sv;
                Q24.AdvancedSearch.SearchOperator = filter["z_Q24"];
                Q24.AdvancedSearch.SearchCondition = filter["v_Q24"];
                Q24.AdvancedSearch.SearchValue2 = filter["y_Q24"];
                Q24.AdvancedSearch.SearchOperator2 = filter["w_Q24"];
                Q24.AdvancedSearch.Save();
            }

            // Field Q25
            if (filter?.TryGetValue("x_Q25", out sv) ?? false) {
                Q25.AdvancedSearch.SearchValue = sv;
                Q25.AdvancedSearch.SearchOperator = filter["z_Q25"];
                Q25.AdvancedSearch.SearchCondition = filter["v_Q25"];
                Q25.AdvancedSearch.SearchValue2 = filter["y_Q25"];
                Q25.AdvancedSearch.SearchOperator2 = filter["w_Q25"];
                Q25.AdvancedSearch.Save();
            }

            // Field Q26
            if (filter?.TryGetValue("x_Q26", out sv) ?? false) {
                Q26.AdvancedSearch.SearchValue = sv;
                Q26.AdvancedSearch.SearchOperator = filter["z_Q26"];
                Q26.AdvancedSearch.SearchCondition = filter["v_Q26"];
                Q26.AdvancedSearch.SearchValue2 = filter["y_Q26"];
                Q26.AdvancedSearch.SearchOperator2 = filter["w_Q26"];
                Q26.AdvancedSearch.Save();
            }

            // Field Section_5
            if (filter?.TryGetValue("x_Section_5", out sv) ?? false) {
                Section_5.AdvancedSearch.SearchValue = sv;
                Section_5.AdvancedSearch.SearchOperator = filter["z_Section_5"];
                Section_5.AdvancedSearch.SearchCondition = filter["v_Section_5"];
                Section_5.AdvancedSearch.SearchValue2 = filter["y_Section_5"];
                Section_5.AdvancedSearch.SearchOperator2 = filter["w_Section_5"];
                Section_5.AdvancedSearch.Save();
            }

            // Field Q27
            if (filter?.TryGetValue("x_Q27", out sv) ?? false) {
                Q27.AdvancedSearch.SearchValue = sv;
                Q27.AdvancedSearch.SearchOperator = filter["z_Q27"];
                Q27.AdvancedSearch.SearchCondition = filter["v_Q27"];
                Q27.AdvancedSearch.SearchValue2 = filter["y_Q27"];
                Q27.AdvancedSearch.SearchOperator2 = filter["w_Q27"];
                Q27.AdvancedSearch.Save();
            }

            // Field Q28
            if (filter?.TryGetValue("x_Q28", out sv) ?? false) {
                Q28.AdvancedSearch.SearchValue = sv;
                Q28.AdvancedSearch.SearchOperator = filter["z_Q28"];
                Q28.AdvancedSearch.SearchCondition = filter["v_Q28"];
                Q28.AdvancedSearch.SearchValue2 = filter["y_Q28"];
                Q28.AdvancedSearch.SearchOperator2 = filter["w_Q28"];
                Q28.AdvancedSearch.Save();
            }

            // Field Q29
            if (filter?.TryGetValue("x_Q29", out sv) ?? false) {
                Q29.AdvancedSearch.SearchValue = sv;
                Q29.AdvancedSearch.SearchOperator = filter["z_Q29"];
                Q29.AdvancedSearch.SearchCondition = filter["v_Q29"];
                Q29.AdvancedSearch.SearchValue2 = filter["y_Q29"];
                Q29.AdvancedSearch.SearchOperator2 = filter["w_Q29"];
                Q29.AdvancedSearch.Save();
            }

            // Field Q30
            if (filter?.TryGetValue("x_Q30", out sv) ?? false) {
                Q30.AdvancedSearch.SearchValue = sv;
                Q30.AdvancedSearch.SearchOperator = filter["z_Q30"];
                Q30.AdvancedSearch.SearchCondition = filter["v_Q30"];
                Q30.AdvancedSearch.SearchValue2 = filter["y_Q30"];
                Q30.AdvancedSearch.SearchOperator2 = filter["w_Q30"];
                Q30.AdvancedSearch.Save();
            }

            // Field Q31
            if (filter?.TryGetValue("x_Q31", out sv) ?? false) {
                Q31.AdvancedSearch.SearchValue = sv;
                Q31.AdvancedSearch.SearchOperator = filter["z_Q31"];
                Q31.AdvancedSearch.SearchCondition = filter["v_Q31"];
                Q31.AdvancedSearch.SearchValue2 = filter["y_Q31"];
                Q31.AdvancedSearch.SearchOperator2 = filter["w_Q31"];
                Q31.AdvancedSearch.Save();
            }

            // Field Q32
            if (filter?.TryGetValue("x_Q32", out sv) ?? false) {
                Q32.AdvancedSearch.SearchValue = sv;
                Q32.AdvancedSearch.SearchOperator = filter["z_Q32"];
                Q32.AdvancedSearch.SearchCondition = filter["v_Q32"];
                Q32.AdvancedSearch.SearchValue2 = filter["y_Q32"];
                Q32.AdvancedSearch.SearchOperator2 = filter["w_Q32"];
                Q32.AdvancedSearch.Save();
            }

            // Field Q33
            if (filter?.TryGetValue("x_Q33", out sv) ?? false) {
                Q33.AdvancedSearch.SearchValue = sv;
                Q33.AdvancedSearch.SearchOperator = filter["z_Q33"];
                Q33.AdvancedSearch.SearchCondition = filter["v_Q33"];
                Q33.AdvancedSearch.SearchValue2 = filter["y_Q33"];
                Q33.AdvancedSearch.SearchOperator2 = filter["w_Q33"];
                Q33.AdvancedSearch.Save();
            }

            // Field Q34
            if (filter?.TryGetValue("x_Q34", out sv) ?? false) {
                Q34.AdvancedSearch.SearchValue = sv;
                Q34.AdvancedSearch.SearchOperator = filter["z_Q34"];
                Q34.AdvancedSearch.SearchCondition = filter["v_Q34"];
                Q34.AdvancedSearch.SearchValue2 = filter["y_Q34"];
                Q34.AdvancedSearch.SearchOperator2 = filter["w_Q34"];
                Q34.AdvancedSearch.Save();
            }

            // Field Q35
            if (filter?.TryGetValue("x_Q35", out sv) ?? false) {
                Q35.AdvancedSearch.SearchValue = sv;
                Q35.AdvancedSearch.SearchOperator = filter["z_Q35"];
                Q35.AdvancedSearch.SearchCondition = filter["v_Q35"];
                Q35.AdvancedSearch.SearchValue2 = filter["y_Q35"];
                Q35.AdvancedSearch.SearchOperator2 = filter["w_Q35"];
                Q35.AdvancedSearch.Save();
            }

            // Field Section_6
            if (filter?.TryGetValue("x_Section_6", out sv) ?? false) {
                Section_6.AdvancedSearch.SearchValue = sv;
                Section_6.AdvancedSearch.SearchOperator = filter["z_Section_6"];
                Section_6.AdvancedSearch.SearchCondition = filter["v_Section_6"];
                Section_6.AdvancedSearch.SearchValue2 = filter["y_Section_6"];
                Section_6.AdvancedSearch.SearchOperator2 = filter["w_Section_6"];
                Section_6.AdvancedSearch.Save();
            }

            // Field Q36
            if (filter?.TryGetValue("x_Q36", out sv) ?? false) {
                Q36.AdvancedSearch.SearchValue = sv;
                Q36.AdvancedSearch.SearchOperator = filter["z_Q36"];
                Q36.AdvancedSearch.SearchCondition = filter["v_Q36"];
                Q36.AdvancedSearch.SearchValue2 = filter["y_Q36"];
                Q36.AdvancedSearch.SearchOperator2 = filter["w_Q36"];
                Q36.AdvancedSearch.Save();
            }

            // Field Q37
            if (filter?.TryGetValue("x_Q37", out sv) ?? false) {
                Q37.AdvancedSearch.SearchValue = sv;
                Q37.AdvancedSearch.SearchOperator = filter["z_Q37"];
                Q37.AdvancedSearch.SearchCondition = filter["v_Q37"];
                Q37.AdvancedSearch.SearchValue2 = filter["y_Q37"];
                Q37.AdvancedSearch.SearchOperator2 = filter["w_Q37"];
                Q37.AdvancedSearch.Save();
            }

            // Field Q38
            if (filter?.TryGetValue("x_Q38", out sv) ?? false) {
                Q38.AdvancedSearch.SearchValue = sv;
                Q38.AdvancedSearch.SearchOperator = filter["z_Q38"];
                Q38.AdvancedSearch.SearchCondition = filter["v_Q38"];
                Q38.AdvancedSearch.SearchValue2 = filter["y_Q38"];
                Q38.AdvancedSearch.SearchOperator2 = filter["w_Q38"];
                Q38.AdvancedSearch.Save();
            }

            // Field Q39
            if (filter?.TryGetValue("x_Q39", out sv) ?? false) {
                Q39.AdvancedSearch.SearchValue = sv;
                Q39.AdvancedSearch.SearchOperator = filter["z_Q39"];
                Q39.AdvancedSearch.SearchCondition = filter["v_Q39"];
                Q39.AdvancedSearch.SearchValue2 = filter["y_Q39"];
                Q39.AdvancedSearch.SearchOperator2 = filter["w_Q39"];
                Q39.AdvancedSearch.Save();
            }

            // Field Q40
            if (filter?.TryGetValue("x_Q40", out sv) ?? false) {
                Q40.AdvancedSearch.SearchValue = sv;
                Q40.AdvancedSearch.SearchOperator = filter["z_Q40"];
                Q40.AdvancedSearch.SearchCondition = filter["v_Q40"];
                Q40.AdvancedSearch.SearchValue2 = filter["y_Q40"];
                Q40.AdvancedSearch.SearchOperator2 = filter["w_Q40"];
                Q40.AdvancedSearch.Save();
            }

            // Field Q41
            if (filter?.TryGetValue("x_Q41", out sv) ?? false) {
                Q41.AdvancedSearch.SearchValue = sv;
                Q41.AdvancedSearch.SearchOperator = filter["z_Q41"];
                Q41.AdvancedSearch.SearchCondition = filter["v_Q41"];
                Q41.AdvancedSearch.SearchValue2 = filter["y_Q41"];
                Q41.AdvancedSearch.SearchOperator2 = filter["w_Q41"];
                Q41.AdvancedSearch.Save();
            }

            // Field Q42
            if (filter?.TryGetValue("x_Q42", out sv) ?? false) {
                Q42.AdvancedSearch.SearchValue = sv;
                Q42.AdvancedSearch.SearchOperator = filter["z_Q42"];
                Q42.AdvancedSearch.SearchCondition = filter["v_Q42"];
                Q42.AdvancedSearch.SearchValue2 = filter["y_Q42"];
                Q42.AdvancedSearch.SearchOperator2 = filter["w_Q42"];
                Q42.AdvancedSearch.Save();
            }

            // Field Q43
            if (filter?.TryGetValue("x_Q43", out sv) ?? false) {
                Q43.AdvancedSearch.SearchValue = sv;
                Q43.AdvancedSearch.SearchOperator = filter["z_Q43"];
                Q43.AdvancedSearch.SearchCondition = filter["v_Q43"];
                Q43.AdvancedSearch.SearchValue2 = filter["y_Q43"];
                Q43.AdvancedSearch.SearchOperator2 = filter["w_Q43"];
                Q43.AdvancedSearch.Save();
            }

            // Field Section_7
            if (filter?.TryGetValue("x_Section_7", out sv) ?? false) {
                Section_7.AdvancedSearch.SearchValue = sv;
                Section_7.AdvancedSearch.SearchOperator = filter["z_Section_7"];
                Section_7.AdvancedSearch.SearchCondition = filter["v_Section_7"];
                Section_7.AdvancedSearch.SearchValue2 = filter["y_Section_7"];
                Section_7.AdvancedSearch.SearchOperator2 = filter["w_Section_7"];
                Section_7.AdvancedSearch.Save();
            }

            // Field Q44
            if (filter?.TryGetValue("x_Q44", out sv) ?? false) {
                Q44.AdvancedSearch.SearchValue = sv;
                Q44.AdvancedSearch.SearchOperator = filter["z_Q44"];
                Q44.AdvancedSearch.SearchCondition = filter["v_Q44"];
                Q44.AdvancedSearch.SearchValue2 = filter["y_Q44"];
                Q44.AdvancedSearch.SearchOperator2 = filter["w_Q44"];
                Q44.AdvancedSearch.Save();
            }

            // Field Q45
            if (filter?.TryGetValue("x_Q45", out sv) ?? false) {
                Q45.AdvancedSearch.SearchValue = sv;
                Q45.AdvancedSearch.SearchOperator = filter["z_Q45"];
                Q45.AdvancedSearch.SearchCondition = filter["v_Q45"];
                Q45.AdvancedSearch.SearchValue2 = filter["y_Q45"];
                Q45.AdvancedSearch.SearchOperator2 = filter["w_Q45"];
                Q45.AdvancedSearch.Save();
            }

            // Field Q46
            if (filter?.TryGetValue("x_Q46", out sv) ?? false) {
                Q46.AdvancedSearch.SearchValue = sv;
                Q46.AdvancedSearch.SearchOperator = filter["z_Q46"];
                Q46.AdvancedSearch.SearchCondition = filter["v_Q46"];
                Q46.AdvancedSearch.SearchValue2 = filter["y_Q46"];
                Q46.AdvancedSearch.SearchOperator2 = filter["w_Q46"];
                Q46.AdvancedSearch.Save();
            }

            // Field Q47
            if (filter?.TryGetValue("x_Q47", out sv) ?? false) {
                Q47.AdvancedSearch.SearchValue = sv;
                Q47.AdvancedSearch.SearchOperator = filter["z_Q47"];
                Q47.AdvancedSearch.SearchCondition = filter["v_Q47"];
                Q47.AdvancedSearch.SearchValue2 = filter["y_Q47"];
                Q47.AdvancedSearch.SearchOperator2 = filter["w_Q47"];
                Q47.AdvancedSearch.Save();
            }

            // Field Q48
            if (filter?.TryGetValue("x_Q48", out sv) ?? false) {
                Q48.AdvancedSearch.SearchValue = sv;
                Q48.AdvancedSearch.SearchOperator = filter["z_Q48"];
                Q48.AdvancedSearch.SearchCondition = filter["v_Q48"];
                Q48.AdvancedSearch.SearchValue2 = filter["y_Q48"];
                Q48.AdvancedSearch.SearchOperator2 = filter["w_Q48"];
                Q48.AdvancedSearch.Save();
            }

            // Field Q49
            if (filter?.TryGetValue("x_Q49", out sv) ?? false) {
                Q49.AdvancedSearch.SearchValue = sv;
                Q49.AdvancedSearch.SearchOperator = filter["z_Q49"];
                Q49.AdvancedSearch.SearchCondition = filter["v_Q49"];
                Q49.AdvancedSearch.SearchValue2 = filter["y_Q49"];
                Q49.AdvancedSearch.SearchOperator2 = filter["w_Q49"];
                Q49.AdvancedSearch.Save();
            }

            // Field Q50
            if (filter?.TryGetValue("x_Q50", out sv) ?? false) {
                Q50.AdvancedSearch.SearchValue = sv;
                Q50.AdvancedSearch.SearchOperator = filter["z_Q50"];
                Q50.AdvancedSearch.SearchCondition = filter["v_Q50"];
                Q50.AdvancedSearch.SearchValue2 = filter["y_Q50"];
                Q50.AdvancedSearch.SearchOperator2 = filter["w_Q50"];
                Q50.AdvancedSearch.Save();
            }

            // Field Section_8
            if (filter?.TryGetValue("x_Section_8", out sv) ?? false) {
                Section_8.AdvancedSearch.SearchValue = sv;
                Section_8.AdvancedSearch.SearchOperator = filter["z_Section_8"];
                Section_8.AdvancedSearch.SearchCondition = filter["v_Section_8"];
                Section_8.AdvancedSearch.SearchValue2 = filter["y_Section_8"];
                Section_8.AdvancedSearch.SearchOperator2 = filter["w_Section_8"];
                Section_8.AdvancedSearch.Save();
            }

            // Field Q51
            if (filter?.TryGetValue("x_Q51", out sv) ?? false) {
                Q51.AdvancedSearch.SearchValue = sv;
                Q51.AdvancedSearch.SearchOperator = filter["z_Q51"];
                Q51.AdvancedSearch.SearchCondition = filter["v_Q51"];
                Q51.AdvancedSearch.SearchValue2 = filter["y_Q51"];
                Q51.AdvancedSearch.SearchOperator2 = filter["w_Q51"];
                Q51.AdvancedSearch.Save();
            }

            // Field Q52
            if (filter?.TryGetValue("x_Q52", out sv) ?? false) {
                Q52.AdvancedSearch.SearchValue = sv;
                Q52.AdvancedSearch.SearchOperator = filter["z_Q52"];
                Q52.AdvancedSearch.SearchCondition = filter["v_Q52"];
                Q52.AdvancedSearch.SearchValue2 = filter["y_Q52"];
                Q52.AdvancedSearch.SearchOperator2 = filter["w_Q52"];
                Q52.AdvancedSearch.Save();
            }

            // Field Q53
            if (filter?.TryGetValue("x_Q53", out sv) ?? false) {
                Q53.AdvancedSearch.SearchValue = sv;
                Q53.AdvancedSearch.SearchOperator = filter["z_Q53"];
                Q53.AdvancedSearch.SearchCondition = filter["v_Q53"];
                Q53.AdvancedSearch.SearchValue2 = filter["y_Q53"];
                Q53.AdvancedSearch.SearchOperator2 = filter["w_Q53"];
                Q53.AdvancedSearch.Save();
            }

            // Field Q54
            if (filter?.TryGetValue("x_Q54", out sv) ?? false) {
                Q54.AdvancedSearch.SearchValue = sv;
                Q54.AdvancedSearch.SearchOperator = filter["z_Q54"];
                Q54.AdvancedSearch.SearchCondition = filter["v_Q54"];
                Q54.AdvancedSearch.SearchValue2 = filter["y_Q54"];
                Q54.AdvancedSearch.SearchOperator2 = filter["w_Q54"];
                Q54.AdvancedSearch.Save();
            }

            // Field Q55
            if (filter?.TryGetValue("x_Q55", out sv) ?? false) {
                Q55.AdvancedSearch.SearchValue = sv;
                Q55.AdvancedSearch.SearchOperator = filter["z_Q55"];
                Q55.AdvancedSearch.SearchCondition = filter["v_Q55"];
                Q55.AdvancedSearch.SearchValue2 = filter["y_Q55"];
                Q55.AdvancedSearch.SearchOperator2 = filter["w_Q55"];
                Q55.AdvancedSearch.Save();
            }

            // Field Section_9
            if (filter?.TryGetValue("x_Section_9", out sv) ?? false) {
                Section_9.AdvancedSearch.SearchValue = sv;
                Section_9.AdvancedSearch.SearchOperator = filter["z_Section_9"];
                Section_9.AdvancedSearch.SearchCondition = filter["v_Section_9"];
                Section_9.AdvancedSearch.SearchValue2 = filter["y_Section_9"];
                Section_9.AdvancedSearch.SearchOperator2 = filter["w_Section_9"];
                Section_9.AdvancedSearch.Save();
            }

            // Field Q56
            if (filter?.TryGetValue("x_Q56", out sv) ?? false) {
                Q56.AdvancedSearch.SearchValue = sv;
                Q56.AdvancedSearch.SearchOperator = filter["z_Q56"];
                Q56.AdvancedSearch.SearchCondition = filter["v_Q56"];
                Q56.AdvancedSearch.SearchValue2 = filter["y_Q56"];
                Q56.AdvancedSearch.SearchOperator2 = filter["w_Q56"];
                Q56.AdvancedSearch.Save();
            }

            // Field Q57
            if (filter?.TryGetValue("x_Q57", out sv) ?? false) {
                Q57.AdvancedSearch.SearchValue = sv;
                Q57.AdvancedSearch.SearchOperator = filter["z_Q57"];
                Q57.AdvancedSearch.SearchCondition = filter["v_Q57"];
                Q57.AdvancedSearch.SearchValue2 = filter["y_Q57"];
                Q57.AdvancedSearch.SearchOperator2 = filter["w_Q57"];
                Q57.AdvancedSearch.Save();
            }

            // Field Q58
            if (filter?.TryGetValue("x_Q58", out sv) ?? false) {
                Q58.AdvancedSearch.SearchValue = sv;
                Q58.AdvancedSearch.SearchOperator = filter["z_Q58"];
                Q58.AdvancedSearch.SearchCondition = filter["v_Q58"];
                Q58.AdvancedSearch.SearchValue2 = filter["y_Q58"];
                Q58.AdvancedSearch.SearchOperator2 = filter["w_Q58"];
                Q58.AdvancedSearch.Save();
            }

            // Field Q59
            if (filter?.TryGetValue("x_Q59", out sv) ?? false) {
                Q59.AdvancedSearch.SearchValue = sv;
                Q59.AdvancedSearch.SearchOperator = filter["z_Q59"];
                Q59.AdvancedSearch.SearchCondition = filter["v_Q59"];
                Q59.AdvancedSearch.SearchValue2 = filter["y_Q59"];
                Q59.AdvancedSearch.SearchOperator2 = filter["w_Q59"];
                Q59.AdvancedSearch.Save();
            }

            // Field Section_10
            if (filter?.TryGetValue("x_Section_10", out sv) ?? false) {
                Section_10.AdvancedSearch.SearchValue = sv;
                Section_10.AdvancedSearch.SearchOperator = filter["z_Section_10"];
                Section_10.AdvancedSearch.SearchCondition = filter["v_Section_10"];
                Section_10.AdvancedSearch.SearchValue2 = filter["y_Section_10"];
                Section_10.AdvancedSearch.SearchOperator2 = filter["w_Section_10"];
                Section_10.AdvancedSearch.Save();
            }

            // Field Q60
            if (filter?.TryGetValue("x_Q60", out sv) ?? false) {
                Q60.AdvancedSearch.SearchValue = sv;
                Q60.AdvancedSearch.SearchOperator = filter["z_Q60"];
                Q60.AdvancedSearch.SearchCondition = filter["v_Q60"];
                Q60.AdvancedSearch.SearchValue2 = filter["y_Q60"];
                Q60.AdvancedSearch.SearchOperator2 = filter["w_Q60"];
                Q60.AdvancedSearch.Save();
            }

            // Field Q61
            if (filter?.TryGetValue("x_Q61", out sv) ?? false) {
                Q61.AdvancedSearch.SearchValue = sv;
                Q61.AdvancedSearch.SearchOperator = filter["z_Q61"];
                Q61.AdvancedSearch.SearchCondition = filter["v_Q61"];
                Q61.AdvancedSearch.SearchValue2 = filter["y_Q61"];
                Q61.AdvancedSearch.SearchOperator2 = filter["w_Q61"];
                Q61.AdvancedSearch.Save();
            }

            // Field Q62
            if (filter?.TryGetValue("x_Q62", out sv) ?? false) {
                Q62.AdvancedSearch.SearchValue = sv;
                Q62.AdvancedSearch.SearchOperator = filter["z_Q62"];
                Q62.AdvancedSearch.SearchCondition = filter["v_Q62"];
                Q62.AdvancedSearch.SearchValue2 = filter["y_Q62"];
                Q62.AdvancedSearch.SearchOperator2 = filter["w_Q62"];
                Q62.AdvancedSearch.Save();
            }

            // Field Q63
            if (filter?.TryGetValue("x_Q63", out sv) ?? false) {
                Q63.AdvancedSearch.SearchValue = sv;
                Q63.AdvancedSearch.SearchOperator = filter["z_Q63"];
                Q63.AdvancedSearch.SearchCondition = filter["v_Q63"];
                Q63.AdvancedSearch.SearchValue2 = filter["y_Q63"];
                Q63.AdvancedSearch.SearchOperator2 = filter["w_Q63"];
                Q63.AdvancedSearch.Save();
            }

            // Field Q64
            if (filter?.TryGetValue("x_Q64", out sv) ?? false) {
                Q64.AdvancedSearch.SearchValue = sv;
                Q64.AdvancedSearch.SearchOperator = filter["z_Q64"];
                Q64.AdvancedSearch.SearchCondition = filter["v_Q64"];
                Q64.AdvancedSearch.SearchValue2 = filter["y_Q64"];
                Q64.AdvancedSearch.SearchOperator2 = filter["w_Q64"];
                Q64.AdvancedSearch.Save();
            }

            // Field Q65
            if (filter?.TryGetValue("x_Q65", out sv) ?? false) {
                Q65.AdvancedSearch.SearchValue = sv;
                Q65.AdvancedSearch.SearchOperator = filter["z_Q65"];
                Q65.AdvancedSearch.SearchCondition = filter["v_Q65"];
                Q65.AdvancedSearch.SearchValue2 = filter["y_Q65"];
                Q65.AdvancedSearch.SearchOperator2 = filter["w_Q65"];
                Q65.AdvancedSearch.Save();
            }

            // Field Section_11
            if (filter?.TryGetValue("x_Section_11", out sv) ?? false) {
                Section_11.AdvancedSearch.SearchValue = sv;
                Section_11.AdvancedSearch.SearchOperator = filter["z_Section_11"];
                Section_11.AdvancedSearch.SearchCondition = filter["v_Section_11"];
                Section_11.AdvancedSearch.SearchValue2 = filter["y_Section_11"];
                Section_11.AdvancedSearch.SearchOperator2 = filter["w_Section_11"];
                Section_11.AdvancedSearch.Save();
            }

            // Field Q66
            if (filter?.TryGetValue("x_Q66", out sv) ?? false) {
                Q66.AdvancedSearch.SearchValue = sv;
                Q66.AdvancedSearch.SearchOperator = filter["z_Q66"];
                Q66.AdvancedSearch.SearchCondition = filter["v_Q66"];
                Q66.AdvancedSearch.SearchValue2 = filter["y_Q66"];
                Q66.AdvancedSearch.SearchOperator2 = filter["w_Q66"];
                Q66.AdvancedSearch.Save();
            }

            // Field Q67
            if (filter?.TryGetValue("x_Q67", out sv) ?? false) {
                Q67.AdvancedSearch.SearchValue = sv;
                Q67.AdvancedSearch.SearchOperator = filter["z_Q67"];
                Q67.AdvancedSearch.SearchCondition = filter["v_Q67"];
                Q67.AdvancedSearch.SearchValue2 = filter["y_Q67"];
                Q67.AdvancedSearch.SearchOperator2 = filter["w_Q67"];
                Q67.AdvancedSearch.Save();
            }

            // Field Q68
            if (filter?.TryGetValue("x_Q68", out sv) ?? false) {
                Q68.AdvancedSearch.SearchValue = sv;
                Q68.AdvancedSearch.SearchOperator = filter["z_Q68"];
                Q68.AdvancedSearch.SearchCondition = filter["v_Q68"];
                Q68.AdvancedSearch.SearchValue2 = filter["y_Q68"];
                Q68.AdvancedSearch.SearchOperator2 = filter["w_Q68"];
                Q68.AdvancedSearch.Save();
            }

            // Field Q69
            if (filter?.TryGetValue("x_Q69", out sv) ?? false) {
                Q69.AdvancedSearch.SearchValue = sv;
                Q69.AdvancedSearch.SearchOperator = filter["z_Q69"];
                Q69.AdvancedSearch.SearchCondition = filter["v_Q69"];
                Q69.AdvancedSearch.SearchValue2 = filter["y_Q69"];
                Q69.AdvancedSearch.SearchOperator2 = filter["w_Q69"];
                Q69.AdvancedSearch.Save();
            }

            // Field Q70
            if (filter?.TryGetValue("x_Q70", out sv) ?? false) {
                Q70.AdvancedSearch.SearchValue = sv;
                Q70.AdvancedSearch.SearchOperator = filter["z_Q70"];
                Q70.AdvancedSearch.SearchCondition = filter["v_Q70"];
                Q70.AdvancedSearch.SearchValue2 = filter["y_Q70"];
                Q70.AdvancedSearch.SearchOperator2 = filter["w_Q70"];
                Q70.AdvancedSearch.Save();
            }

            // Field Notes_3
            if (filter?.TryGetValue("x_Notes_3", out sv) ?? false) {
                Notes_3.AdvancedSearch.SearchValue = sv;
                Notes_3.AdvancedSearch.SearchOperator = filter["z_Notes_3"];
                Notes_3.AdvancedSearch.SearchCondition = filter["v_Notes_3"];
                Notes_3.AdvancedSearch.SearchValue2 = filter["y_Notes_3"];
                Notes_3.AdvancedSearch.SearchOperator2 = filter["w_Notes_3"];
                Notes_3.AdvancedSearch.Save();
            }

            // Field Examiner_Signature
            if (filter?.TryGetValue("x_Examiner_Signature", out sv) ?? false) {
                Examiner_Signature.AdvancedSearch.SearchValue = sv;
                Examiner_Signature.AdvancedSearch.SearchOperator = filter["z_Examiner_Signature"];
                Examiner_Signature.AdvancedSearch.SearchCondition = filter["v_Examiner_Signature"];
                Examiner_Signature.AdvancedSearch.SearchValue2 = filter["y_Examiner_Signature"];
                Examiner_Signature.AdvancedSearch.SearchOperator2 = filter["w_Examiner_Signature"];
                Examiner_Signature.AdvancedSearch.Save();
            }

            // Field Student_Signature
            if (filter?.TryGetValue("x_Student_Signature", out sv) ?? false) {
                Student_Signature.AdvancedSearch.SearchValue = sv;
                Student_Signature.AdvancedSearch.SearchOperator = filter["z_Student_Signature"];
                Student_Signature.AdvancedSearch.SearchCondition = filter["v_Student_Signature"];
                Student_Signature.AdvancedSearch.SearchValue2 = filter["y_Student_Signature"];
                Student_Signature.AdvancedSearch.SearchOperator2 = filter["w_Student_Signature"];
                Student_Signature.AdvancedSearch.Save();
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

            // Field IsDrivingexperience
            if (filter?.TryGetValue("x_IsDrivingexperience", out sv) ?? false) {
                IsDrivingexperience.AdvancedSearch.SearchValue = sv;
                IsDrivingexperience.AdvancedSearch.SearchOperator = filter["z_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchCondition = filter["v_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchValue2 = filter["y_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.SearchOperator2 = filter["w_IsDrivingexperience"];
                IsDrivingexperience.AdvancedSearch.Save();
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

            // Field str_Email
            if (filter?.TryGetValue("x_str_Email", out sv) ?? false) {
                str_Email.AdvancedSearch.SearchValue = sv;
                str_Email.AdvancedSearch.SearchOperator = filter["z_str_Email"];
                str_Email.AdvancedSearch.SearchCondition = filter["v_str_Email"];
                str_Email.AdvancedSearch.SearchValue2 = filter["y_str_Email"];
                str_Email.AdvancedSearch.SearchOperator2 = filter["w_str_Email"];
                str_Email.AdvancedSearch.Save();
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

            // Field DriveTypelink
            if (filter?.TryGetValue("x_DriveTypelink", out sv) ?? false) {
                DriveTypelink.AdvancedSearch.SearchValue = sv;
                DriveTypelink.AdvancedSearch.SearchOperator = filter["z_DriveTypelink"];
                DriveTypelink.AdvancedSearch.SearchCondition = filter["v_DriveTypelink"];
                DriveTypelink.AdvancedSearch.SearchValue2 = filter["y_DriveTypelink"];
                DriveTypelink.AdvancedSearch.SearchOperator2 = filter["w_DriveTypelink"];
                DriveTypelink.AdvancedSearch.Save();
            }

            // Field intEvaluationType
            if (filter?.TryGetValue("x_intEvaluationType", out sv) ?? false) {
                intEvaluationType.AdvancedSearch.SearchValue = sv;
                intEvaluationType.AdvancedSearch.SearchOperator = filter["z_intEvaluationType"];
                intEvaluationType.AdvancedSearch.SearchCondition = filter["v_intEvaluationType"];
                intEvaluationType.AdvancedSearch.SearchValue2 = filter["y_intEvaluationType"];
                intEvaluationType.AdvancedSearch.SearchOperator2 = filter["w_intEvaluationType"];
                intEvaluationType.AdvancedSearch.Save();
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

            // Field Scores_S1
            if (filter?.TryGetValue("x_Scores_S1", out sv) ?? false) {
                Scores_S1.AdvancedSearch.SearchValue = sv;
                Scores_S1.AdvancedSearch.SearchOperator = filter["z_Scores_S1"];
                Scores_S1.AdvancedSearch.SearchCondition = filter["v_Scores_S1"];
                Scores_S1.AdvancedSearch.SearchValue2 = filter["y_Scores_S1"];
                Scores_S1.AdvancedSearch.SearchOperator2 = filter["w_Scores_S1"];
                Scores_S1.AdvancedSearch.Save();
            }

            // Field S1
            if (filter?.TryGetValue("x_S1", out sv) ?? false) {
                S1.AdvancedSearch.SearchValue = sv;
                S1.AdvancedSearch.SearchOperator = filter["z_S1"];
                S1.AdvancedSearch.SearchCondition = filter["v_S1"];
                S1.AdvancedSearch.SearchValue2 = filter["y_S1"];
                S1.AdvancedSearch.SearchOperator2 = filter["w_S1"];
                S1.AdvancedSearch.Save();
            }

            // Field S2
            if (filter?.TryGetValue("x_S2", out sv) ?? false) {
                S2.AdvancedSearch.SearchValue = sv;
                S2.AdvancedSearch.SearchOperator = filter["z_S2"];
                S2.AdvancedSearch.SearchCondition = filter["v_S2"];
                S2.AdvancedSearch.SearchValue2 = filter["y_S2"];
                S2.AdvancedSearch.SearchOperator2 = filter["w_S2"];
                S2.AdvancedSearch.Save();
            }

            // Field S3
            if (filter?.TryGetValue("x_S3", out sv) ?? false) {
                S3.AdvancedSearch.SearchValue = sv;
                S3.AdvancedSearch.SearchOperator = filter["z_S3"];
                S3.AdvancedSearch.SearchCondition = filter["v_S3"];
                S3.AdvancedSearch.SearchValue2 = filter["y_S3"];
                S3.AdvancedSearch.SearchOperator2 = filter["w_S3"];
                S3.AdvancedSearch.Save();
            }

            // Field S4
            if (filter?.TryGetValue("x_S4", out sv) ?? false) {
                S4.AdvancedSearch.SearchValue = sv;
                S4.AdvancedSearch.SearchOperator = filter["z_S4"];
                S4.AdvancedSearch.SearchCondition = filter["v_S4"];
                S4.AdvancedSearch.SearchValue2 = filter["y_S4"];
                S4.AdvancedSearch.SearchOperator2 = filter["w_S4"];
                S4.AdvancedSearch.Save();
            }

            // Field S5
            if (filter?.TryGetValue("x_S5", out sv) ?? false) {
                S5.AdvancedSearch.SearchValue = sv;
                S5.AdvancedSearch.SearchOperator = filter["z_S5"];
                S5.AdvancedSearch.SearchCondition = filter["v_S5"];
                S5.AdvancedSearch.SearchValue2 = filter["y_S5"];
                S5.AdvancedSearch.SearchOperator2 = filter["w_S5"];
                S5.AdvancedSearch.Save();
            }

            // Field Scores_S2
            if (filter?.TryGetValue("x_Scores_S2", out sv) ?? false) {
                Scores_S2.AdvancedSearch.SearchValue = sv;
                Scores_S2.AdvancedSearch.SearchOperator = filter["z_Scores_S2"];
                Scores_S2.AdvancedSearch.SearchCondition = filter["v_Scores_S2"];
                Scores_S2.AdvancedSearch.SearchValue2 = filter["y_Scores_S2"];
                Scores_S2.AdvancedSearch.SearchOperator2 = filter["w_Scores_S2"];
                Scores_S2.AdvancedSearch.Save();
            }

            // Field S6
            if (filter?.TryGetValue("x_S6", out sv) ?? false) {
                S6.AdvancedSearch.SearchValue = sv;
                S6.AdvancedSearch.SearchOperator = filter["z_S6"];
                S6.AdvancedSearch.SearchCondition = filter["v_S6"];
                S6.AdvancedSearch.SearchValue2 = filter["y_S6"];
                S6.AdvancedSearch.SearchOperator2 = filter["w_S6"];
                S6.AdvancedSearch.Save();
            }

            // Field S7
            if (filter?.TryGetValue("x_S7", out sv) ?? false) {
                S7.AdvancedSearch.SearchValue = sv;
                S7.AdvancedSearch.SearchOperator = filter["z_S7"];
                S7.AdvancedSearch.SearchCondition = filter["v_S7"];
                S7.AdvancedSearch.SearchValue2 = filter["y_S7"];
                S7.AdvancedSearch.SearchOperator2 = filter["w_S7"];
                S7.AdvancedSearch.Save();
            }

            // Field S8
            if (filter?.TryGetValue("x_S8", out sv) ?? false) {
                S8.AdvancedSearch.SearchValue = sv;
                S8.AdvancedSearch.SearchOperator = filter["z_S8"];
                S8.AdvancedSearch.SearchCondition = filter["v_S8"];
                S8.AdvancedSearch.SearchValue2 = filter["y_S8"];
                S8.AdvancedSearch.SearchOperator2 = filter["w_S8"];
                S8.AdvancedSearch.Save();
            }

            // Field S9
            if (filter?.TryGetValue("x_S9", out sv) ?? false) {
                S9.AdvancedSearch.SearchValue = sv;
                S9.AdvancedSearch.SearchOperator = filter["z_S9"];
                S9.AdvancedSearch.SearchCondition = filter["v_S9"];
                S9.AdvancedSearch.SearchValue2 = filter["y_S9"];
                S9.AdvancedSearch.SearchOperator2 = filter["w_S9"];
                S9.AdvancedSearch.Save();
            }

            // Field S10
            if (filter?.TryGetValue("x_S10", out sv) ?? false) {
                S10.AdvancedSearch.SearchValue = sv;
                S10.AdvancedSearch.SearchOperator = filter["z_S10"];
                S10.AdvancedSearch.SearchCondition = filter["v_S10"];
                S10.AdvancedSearch.SearchValue2 = filter["y_S10"];
                S10.AdvancedSearch.SearchOperator2 = filter["w_S10"];
                S10.AdvancedSearch.Save();
            }

            // Field S11
            if (filter?.TryGetValue("x_S11", out sv) ?? false) {
                S11.AdvancedSearch.SearchValue = sv;
                S11.AdvancedSearch.SearchOperator = filter["z_S11"];
                S11.AdvancedSearch.SearchCondition = filter["v_S11"];
                S11.AdvancedSearch.SearchValue2 = filter["y_S11"];
                S11.AdvancedSearch.SearchOperator2 = filter["w_S11"];
                S11.AdvancedSearch.Save();
            }

            // Field S12
            if (filter?.TryGetValue("x_S12", out sv) ?? false) {
                S12.AdvancedSearch.SearchValue = sv;
                S12.AdvancedSearch.SearchOperator = filter["z_S12"];
                S12.AdvancedSearch.SearchCondition = filter["v_S12"];
                S12.AdvancedSearch.SearchValue2 = filter["y_S12"];
                S12.AdvancedSearch.SearchOperator2 = filter["w_S12"];
                S12.AdvancedSearch.Save();
            }

            // Field S13
            if (filter?.TryGetValue("x_S13", out sv) ?? false) {
                S13.AdvancedSearch.SearchValue = sv;
                S13.AdvancedSearch.SearchOperator = filter["z_S13"];
                S13.AdvancedSearch.SearchCondition = filter["v_S13"];
                S13.AdvancedSearch.SearchValue2 = filter["y_S13"];
                S13.AdvancedSearch.SearchOperator2 = filter["w_S13"];
                S13.AdvancedSearch.Save();
            }

            // Field S14
            if (filter?.TryGetValue("x_S14", out sv) ?? false) {
                S14.AdvancedSearch.SearchValue = sv;
                S14.AdvancedSearch.SearchOperator = filter["z_S14"];
                S14.AdvancedSearch.SearchCondition = filter["v_S14"];
                S14.AdvancedSearch.SearchValue2 = filter["y_S14"];
                S14.AdvancedSearch.SearchOperator2 = filter["w_S14"];
                S14.AdvancedSearch.Save();
            }

            // Field S15
            if (filter?.TryGetValue("x_S15", out sv) ?? false) {
                S15.AdvancedSearch.SearchValue = sv;
                S15.AdvancedSearch.SearchOperator = filter["z_S15"];
                S15.AdvancedSearch.SearchCondition = filter["v_S15"];
                S15.AdvancedSearch.SearchValue2 = filter["y_S15"];
                S15.AdvancedSearch.SearchOperator2 = filter["w_S15"];
                S15.AdvancedSearch.Save();
            }

            // Field Scores_S3
            if (filter?.TryGetValue("x_Scores_S3", out sv) ?? false) {
                Scores_S3.AdvancedSearch.SearchValue = sv;
                Scores_S3.AdvancedSearch.SearchOperator = filter["z_Scores_S3"];
                Scores_S3.AdvancedSearch.SearchCondition = filter["v_Scores_S3"];
                Scores_S3.AdvancedSearch.SearchValue2 = filter["y_Scores_S3"];
                Scores_S3.AdvancedSearch.SearchOperator2 = filter["w_Scores_S3"];
                Scores_S3.AdvancedSearch.Save();
            }

            // Field S16
            if (filter?.TryGetValue("x_S16", out sv) ?? false) {
                S16.AdvancedSearch.SearchValue = sv;
                S16.AdvancedSearch.SearchOperator = filter["z_S16"];
                S16.AdvancedSearch.SearchCondition = filter["v_S16"];
                S16.AdvancedSearch.SearchValue2 = filter["y_S16"];
                S16.AdvancedSearch.SearchOperator2 = filter["w_S16"];
                S16.AdvancedSearch.Save();
            }

            // Field S17
            if (filter?.TryGetValue("x_S17", out sv) ?? false) {
                S17.AdvancedSearch.SearchValue = sv;
                S17.AdvancedSearch.SearchOperator = filter["z_S17"];
                S17.AdvancedSearch.SearchCondition = filter["v_S17"];
                S17.AdvancedSearch.SearchValue2 = filter["y_S17"];
                S17.AdvancedSearch.SearchOperator2 = filter["w_S17"];
                S17.AdvancedSearch.Save();
            }

            // Field S18
            if (filter?.TryGetValue("x_S18", out sv) ?? false) {
                S18.AdvancedSearch.SearchValue = sv;
                S18.AdvancedSearch.SearchOperator = filter["z_S18"];
                S18.AdvancedSearch.SearchCondition = filter["v_S18"];
                S18.AdvancedSearch.SearchValue2 = filter["y_S18"];
                S18.AdvancedSearch.SearchOperator2 = filter["w_S18"];
                S18.AdvancedSearch.Save();
            }

            // Field S19
            if (filter?.TryGetValue("x_S19", out sv) ?? false) {
                S19.AdvancedSearch.SearchValue = sv;
                S19.AdvancedSearch.SearchOperator = filter["z_S19"];
                S19.AdvancedSearch.SearchCondition = filter["v_S19"];
                S19.AdvancedSearch.SearchValue2 = filter["y_S19"];
                S19.AdvancedSearch.SearchOperator2 = filter["w_S19"];
                S19.AdvancedSearch.Save();
            }

            // Field S20
            if (filter?.TryGetValue("x_S20", out sv) ?? false) {
                S20.AdvancedSearch.SearchValue = sv;
                S20.AdvancedSearch.SearchOperator = filter["z_S20"];
                S20.AdvancedSearch.SearchCondition = filter["v_S20"];
                S20.AdvancedSearch.SearchValue2 = filter["y_S20"];
                S20.AdvancedSearch.SearchOperator2 = filter["w_S20"];
                S20.AdvancedSearch.Save();
            }

            // Field S21
            if (filter?.TryGetValue("x_S21", out sv) ?? false) {
                S21.AdvancedSearch.SearchValue = sv;
                S21.AdvancedSearch.SearchOperator = filter["z_S21"];
                S21.AdvancedSearch.SearchCondition = filter["v_S21"];
                S21.AdvancedSearch.SearchValue2 = filter["y_S21"];
                S21.AdvancedSearch.SearchOperator2 = filter["w_S21"];
                S21.AdvancedSearch.Save();
            }

            // Field Scores_S4
            if (filter?.TryGetValue("x_Scores_S4", out sv) ?? false) {
                Scores_S4.AdvancedSearch.SearchValue = sv;
                Scores_S4.AdvancedSearch.SearchOperator = filter["z_Scores_S4"];
                Scores_S4.AdvancedSearch.SearchCondition = filter["v_Scores_S4"];
                Scores_S4.AdvancedSearch.SearchValue2 = filter["y_Scores_S4"];
                Scores_S4.AdvancedSearch.SearchOperator2 = filter["w_Scores_S4"];
                Scores_S4.AdvancedSearch.Save();
            }

            // Field S22
            if (filter?.TryGetValue("x_S22", out sv) ?? false) {
                S22.AdvancedSearch.SearchValue = sv;
                S22.AdvancedSearch.SearchOperator = filter["z_S22"];
                S22.AdvancedSearch.SearchCondition = filter["v_S22"];
                S22.AdvancedSearch.SearchValue2 = filter["y_S22"];
                S22.AdvancedSearch.SearchOperator2 = filter["w_S22"];
                S22.AdvancedSearch.Save();
            }

            // Field S23
            if (filter?.TryGetValue("x_S23", out sv) ?? false) {
                S23.AdvancedSearch.SearchValue = sv;
                S23.AdvancedSearch.SearchOperator = filter["z_S23"];
                S23.AdvancedSearch.SearchCondition = filter["v_S23"];
                S23.AdvancedSearch.SearchValue2 = filter["y_S23"];
                S23.AdvancedSearch.SearchOperator2 = filter["w_S23"];
                S23.AdvancedSearch.Save();
            }

            // Field S24
            if (filter?.TryGetValue("x_S24", out sv) ?? false) {
                S24.AdvancedSearch.SearchValue = sv;
                S24.AdvancedSearch.SearchOperator = filter["z_S24"];
                S24.AdvancedSearch.SearchCondition = filter["v_S24"];
                S24.AdvancedSearch.SearchValue2 = filter["y_S24"];
                S24.AdvancedSearch.SearchOperator2 = filter["w_S24"];
                S24.AdvancedSearch.Save();
            }

            // Field S25
            if (filter?.TryGetValue("x_S25", out sv) ?? false) {
                S25.AdvancedSearch.SearchValue = sv;
                S25.AdvancedSearch.SearchOperator = filter["z_S25"];
                S25.AdvancedSearch.SearchCondition = filter["v_S25"];
                S25.AdvancedSearch.SearchValue2 = filter["y_S25"];
                S25.AdvancedSearch.SearchOperator2 = filter["w_S25"];
                S25.AdvancedSearch.Save();
            }

            // Field S26
            if (filter?.TryGetValue("x_S26", out sv) ?? false) {
                S26.AdvancedSearch.SearchValue = sv;
                S26.AdvancedSearch.SearchOperator = filter["z_S26"];
                S26.AdvancedSearch.SearchCondition = filter["v_S26"];
                S26.AdvancedSearch.SearchValue2 = filter["y_S26"];
                S26.AdvancedSearch.SearchOperator2 = filter["w_S26"];
                S26.AdvancedSearch.Save();
            }

            // Field Scores_S5
            if (filter?.TryGetValue("x_Scores_S5", out sv) ?? false) {
                Scores_S5.AdvancedSearch.SearchValue = sv;
                Scores_S5.AdvancedSearch.SearchOperator = filter["z_Scores_S5"];
                Scores_S5.AdvancedSearch.SearchCondition = filter["v_Scores_S5"];
                Scores_S5.AdvancedSearch.SearchValue2 = filter["y_Scores_S5"];
                Scores_S5.AdvancedSearch.SearchOperator2 = filter["w_Scores_S5"];
                Scores_S5.AdvancedSearch.Save();
            }

            // Field S27
            if (filter?.TryGetValue("x_S27", out sv) ?? false) {
                S27.AdvancedSearch.SearchValue = sv;
                S27.AdvancedSearch.SearchOperator = filter["z_S27"];
                S27.AdvancedSearch.SearchCondition = filter["v_S27"];
                S27.AdvancedSearch.SearchValue2 = filter["y_S27"];
                S27.AdvancedSearch.SearchOperator2 = filter["w_S27"];
                S27.AdvancedSearch.Save();
            }

            // Field S28
            if (filter?.TryGetValue("x_S28", out sv) ?? false) {
                S28.AdvancedSearch.SearchValue = sv;
                S28.AdvancedSearch.SearchOperator = filter["z_S28"];
                S28.AdvancedSearch.SearchCondition = filter["v_S28"];
                S28.AdvancedSearch.SearchValue2 = filter["y_S28"];
                S28.AdvancedSearch.SearchOperator2 = filter["w_S28"];
                S28.AdvancedSearch.Save();
            }

            // Field S29
            if (filter?.TryGetValue("x_S29", out sv) ?? false) {
                S29.AdvancedSearch.SearchValue = sv;
                S29.AdvancedSearch.SearchOperator = filter["z_S29"];
                S29.AdvancedSearch.SearchCondition = filter["v_S29"];
                S29.AdvancedSearch.SearchValue2 = filter["y_S29"];
                S29.AdvancedSearch.SearchOperator2 = filter["w_S29"];
                S29.AdvancedSearch.Save();
            }

            // Field S30
            if (filter?.TryGetValue("x_S30", out sv) ?? false) {
                S30.AdvancedSearch.SearchValue = sv;
                S30.AdvancedSearch.SearchOperator = filter["z_S30"];
                S30.AdvancedSearch.SearchCondition = filter["v_S30"];
                S30.AdvancedSearch.SearchValue2 = filter["y_S30"];
                S30.AdvancedSearch.SearchOperator2 = filter["w_S30"];
                S30.AdvancedSearch.Save();
            }

            // Field S31
            if (filter?.TryGetValue("x_S31", out sv) ?? false) {
                S31.AdvancedSearch.SearchValue = sv;
                S31.AdvancedSearch.SearchOperator = filter["z_S31"];
                S31.AdvancedSearch.SearchCondition = filter["v_S31"];
                S31.AdvancedSearch.SearchValue2 = filter["y_S31"];
                S31.AdvancedSearch.SearchOperator2 = filter["w_S31"];
                S31.AdvancedSearch.Save();
            }

            // Field S32
            if (filter?.TryGetValue("x_S32", out sv) ?? false) {
                S32.AdvancedSearch.SearchValue = sv;
                S32.AdvancedSearch.SearchOperator = filter["z_S32"];
                S32.AdvancedSearch.SearchCondition = filter["v_S32"];
                S32.AdvancedSearch.SearchValue2 = filter["y_S32"];
                S32.AdvancedSearch.SearchOperator2 = filter["w_S32"];
                S32.AdvancedSearch.Save();
            }

            // Field S33
            if (filter?.TryGetValue("x_S33", out sv) ?? false) {
                S33.AdvancedSearch.SearchValue = sv;
                S33.AdvancedSearch.SearchOperator = filter["z_S33"];
                S33.AdvancedSearch.SearchCondition = filter["v_S33"];
                S33.AdvancedSearch.SearchValue2 = filter["y_S33"];
                S33.AdvancedSearch.SearchOperator2 = filter["w_S33"];
                S33.AdvancedSearch.Save();
            }

            // Field S34
            if (filter?.TryGetValue("x_S34", out sv) ?? false) {
                S34.AdvancedSearch.SearchValue = sv;
                S34.AdvancedSearch.SearchOperator = filter["z_S34"];
                S34.AdvancedSearch.SearchCondition = filter["v_S34"];
                S34.AdvancedSearch.SearchValue2 = filter["y_S34"];
                S34.AdvancedSearch.SearchOperator2 = filter["w_S34"];
                S34.AdvancedSearch.Save();
            }

            // Field S35
            if (filter?.TryGetValue("x_S35", out sv) ?? false) {
                S35.AdvancedSearch.SearchValue = sv;
                S35.AdvancedSearch.SearchOperator = filter["z_S35"];
                S35.AdvancedSearch.SearchCondition = filter["v_S35"];
                S35.AdvancedSearch.SearchValue2 = filter["y_S35"];
                S35.AdvancedSearch.SearchOperator2 = filter["w_S35"];
                S35.AdvancedSearch.Save();
            }

            // Field Scores_S6
            if (filter?.TryGetValue("x_Scores_S6", out sv) ?? false) {
                Scores_S6.AdvancedSearch.SearchValue = sv;
                Scores_S6.AdvancedSearch.SearchOperator = filter["z_Scores_S6"];
                Scores_S6.AdvancedSearch.SearchCondition = filter["v_Scores_S6"];
                Scores_S6.AdvancedSearch.SearchValue2 = filter["y_Scores_S6"];
                Scores_S6.AdvancedSearch.SearchOperator2 = filter["w_Scores_S6"];
                Scores_S6.AdvancedSearch.Save();
            }

            // Field S36
            if (filter?.TryGetValue("x_S36", out sv) ?? false) {
                S36.AdvancedSearch.SearchValue = sv;
                S36.AdvancedSearch.SearchOperator = filter["z_S36"];
                S36.AdvancedSearch.SearchCondition = filter["v_S36"];
                S36.AdvancedSearch.SearchValue2 = filter["y_S36"];
                S36.AdvancedSearch.SearchOperator2 = filter["w_S36"];
                S36.AdvancedSearch.Save();
            }

            // Field S37
            if (filter?.TryGetValue("x_S37", out sv) ?? false) {
                S37.AdvancedSearch.SearchValue = sv;
                S37.AdvancedSearch.SearchOperator = filter["z_S37"];
                S37.AdvancedSearch.SearchCondition = filter["v_S37"];
                S37.AdvancedSearch.SearchValue2 = filter["y_S37"];
                S37.AdvancedSearch.SearchOperator2 = filter["w_S37"];
                S37.AdvancedSearch.Save();
            }

            // Field S38
            if (filter?.TryGetValue("x_S38", out sv) ?? false) {
                S38.AdvancedSearch.SearchValue = sv;
                S38.AdvancedSearch.SearchOperator = filter["z_S38"];
                S38.AdvancedSearch.SearchCondition = filter["v_S38"];
                S38.AdvancedSearch.SearchValue2 = filter["y_S38"];
                S38.AdvancedSearch.SearchOperator2 = filter["w_S38"];
                S38.AdvancedSearch.Save();
            }

            // Field S39
            if (filter?.TryGetValue("x_S39", out sv) ?? false) {
                S39.AdvancedSearch.SearchValue = sv;
                S39.AdvancedSearch.SearchOperator = filter["z_S39"];
                S39.AdvancedSearch.SearchCondition = filter["v_S39"];
                S39.AdvancedSearch.SearchValue2 = filter["y_S39"];
                S39.AdvancedSearch.SearchOperator2 = filter["w_S39"];
                S39.AdvancedSearch.Save();
            }

            // Field S40
            if (filter?.TryGetValue("x_S40", out sv) ?? false) {
                S40.AdvancedSearch.SearchValue = sv;
                S40.AdvancedSearch.SearchOperator = filter["z_S40"];
                S40.AdvancedSearch.SearchCondition = filter["v_S40"];
                S40.AdvancedSearch.SearchValue2 = filter["y_S40"];
                S40.AdvancedSearch.SearchOperator2 = filter["w_S40"];
                S40.AdvancedSearch.Save();
            }

            // Field S41
            if (filter?.TryGetValue("x_S41", out sv) ?? false) {
                S41.AdvancedSearch.SearchValue = sv;
                S41.AdvancedSearch.SearchOperator = filter["z_S41"];
                S41.AdvancedSearch.SearchCondition = filter["v_S41"];
                S41.AdvancedSearch.SearchValue2 = filter["y_S41"];
                S41.AdvancedSearch.SearchOperator2 = filter["w_S41"];
                S41.AdvancedSearch.Save();
            }

            // Field S42
            if (filter?.TryGetValue("x_S42", out sv) ?? false) {
                S42.AdvancedSearch.SearchValue = sv;
                S42.AdvancedSearch.SearchOperator = filter["z_S42"];
                S42.AdvancedSearch.SearchCondition = filter["v_S42"];
                S42.AdvancedSearch.SearchValue2 = filter["y_S42"];
                S42.AdvancedSearch.SearchOperator2 = filter["w_S42"];
                S42.AdvancedSearch.Save();
            }

            // Field S43
            if (filter?.TryGetValue("x_S43", out sv) ?? false) {
                S43.AdvancedSearch.SearchValue = sv;
                S43.AdvancedSearch.SearchOperator = filter["z_S43"];
                S43.AdvancedSearch.SearchCondition = filter["v_S43"];
                S43.AdvancedSearch.SearchValue2 = filter["y_S43"];
                S43.AdvancedSearch.SearchOperator2 = filter["w_S43"];
                S43.AdvancedSearch.Save();
            }

            // Field Scores_S7
            if (filter?.TryGetValue("x_Scores_S7", out sv) ?? false) {
                Scores_S7.AdvancedSearch.SearchValue = sv;
                Scores_S7.AdvancedSearch.SearchOperator = filter["z_Scores_S7"];
                Scores_S7.AdvancedSearch.SearchCondition = filter["v_Scores_S7"];
                Scores_S7.AdvancedSearch.SearchValue2 = filter["y_Scores_S7"];
                Scores_S7.AdvancedSearch.SearchOperator2 = filter["w_Scores_S7"];
                Scores_S7.AdvancedSearch.Save();
            }

            // Field S44
            if (filter?.TryGetValue("x_S44", out sv) ?? false) {
                S44.AdvancedSearch.SearchValue = sv;
                S44.AdvancedSearch.SearchOperator = filter["z_S44"];
                S44.AdvancedSearch.SearchCondition = filter["v_S44"];
                S44.AdvancedSearch.SearchValue2 = filter["y_S44"];
                S44.AdvancedSearch.SearchOperator2 = filter["w_S44"];
                S44.AdvancedSearch.Save();
            }

            // Field S45
            if (filter?.TryGetValue("x_S45", out sv) ?? false) {
                S45.AdvancedSearch.SearchValue = sv;
                S45.AdvancedSearch.SearchOperator = filter["z_S45"];
                S45.AdvancedSearch.SearchCondition = filter["v_S45"];
                S45.AdvancedSearch.SearchValue2 = filter["y_S45"];
                S45.AdvancedSearch.SearchOperator2 = filter["w_S45"];
                S45.AdvancedSearch.Save();
            }

            // Field S46
            if (filter?.TryGetValue("x_S46", out sv) ?? false) {
                S46.AdvancedSearch.SearchValue = sv;
                S46.AdvancedSearch.SearchOperator = filter["z_S46"];
                S46.AdvancedSearch.SearchCondition = filter["v_S46"];
                S46.AdvancedSearch.SearchValue2 = filter["y_S46"];
                S46.AdvancedSearch.SearchOperator2 = filter["w_S46"];
                S46.AdvancedSearch.Save();
            }

            // Field S47
            if (filter?.TryGetValue("x_S47", out sv) ?? false) {
                S47.AdvancedSearch.SearchValue = sv;
                S47.AdvancedSearch.SearchOperator = filter["z_S47"];
                S47.AdvancedSearch.SearchCondition = filter["v_S47"];
                S47.AdvancedSearch.SearchValue2 = filter["y_S47"];
                S47.AdvancedSearch.SearchOperator2 = filter["w_S47"];
                S47.AdvancedSearch.Save();
            }

            // Field S48
            if (filter?.TryGetValue("x_S48", out sv) ?? false) {
                S48.AdvancedSearch.SearchValue = sv;
                S48.AdvancedSearch.SearchOperator = filter["z_S48"];
                S48.AdvancedSearch.SearchCondition = filter["v_S48"];
                S48.AdvancedSearch.SearchValue2 = filter["y_S48"];
                S48.AdvancedSearch.SearchOperator2 = filter["w_S48"];
                S48.AdvancedSearch.Save();
            }

            // Field S49
            if (filter?.TryGetValue("x_S49", out sv) ?? false) {
                S49.AdvancedSearch.SearchValue = sv;
                S49.AdvancedSearch.SearchOperator = filter["z_S49"];
                S49.AdvancedSearch.SearchCondition = filter["v_S49"];
                S49.AdvancedSearch.SearchValue2 = filter["y_S49"];
                S49.AdvancedSearch.SearchOperator2 = filter["w_S49"];
                S49.AdvancedSearch.Save();
            }

            // Field S50
            if (filter?.TryGetValue("x_S50", out sv) ?? false) {
                S50.AdvancedSearch.SearchValue = sv;
                S50.AdvancedSearch.SearchOperator = filter["z_S50"];
                S50.AdvancedSearch.SearchCondition = filter["v_S50"];
                S50.AdvancedSearch.SearchValue2 = filter["y_S50"];
                S50.AdvancedSearch.SearchOperator2 = filter["w_S50"];
                S50.AdvancedSearch.Save();
            }

            // Field Scores_S8
            if (filter?.TryGetValue("x_Scores_S8", out sv) ?? false) {
                Scores_S8.AdvancedSearch.SearchValue = sv;
                Scores_S8.AdvancedSearch.SearchOperator = filter["z_Scores_S8"];
                Scores_S8.AdvancedSearch.SearchCondition = filter["v_Scores_S8"];
                Scores_S8.AdvancedSearch.SearchValue2 = filter["y_Scores_S8"];
                Scores_S8.AdvancedSearch.SearchOperator2 = filter["w_Scores_S8"];
                Scores_S8.AdvancedSearch.Save();
            }

            // Field S51
            if (filter?.TryGetValue("x_S51", out sv) ?? false) {
                S51.AdvancedSearch.SearchValue = sv;
                S51.AdvancedSearch.SearchOperator = filter["z_S51"];
                S51.AdvancedSearch.SearchCondition = filter["v_S51"];
                S51.AdvancedSearch.SearchValue2 = filter["y_S51"];
                S51.AdvancedSearch.SearchOperator2 = filter["w_S51"];
                S51.AdvancedSearch.Save();
            }

            // Field S52
            if (filter?.TryGetValue("x_S52", out sv) ?? false) {
                S52.AdvancedSearch.SearchValue = sv;
                S52.AdvancedSearch.SearchOperator = filter["z_S52"];
                S52.AdvancedSearch.SearchCondition = filter["v_S52"];
                S52.AdvancedSearch.SearchValue2 = filter["y_S52"];
                S52.AdvancedSearch.SearchOperator2 = filter["w_S52"];
                S52.AdvancedSearch.Save();
            }

            // Field S53
            if (filter?.TryGetValue("x_S53", out sv) ?? false) {
                S53.AdvancedSearch.SearchValue = sv;
                S53.AdvancedSearch.SearchOperator = filter["z_S53"];
                S53.AdvancedSearch.SearchCondition = filter["v_S53"];
                S53.AdvancedSearch.SearchValue2 = filter["y_S53"];
                S53.AdvancedSearch.SearchOperator2 = filter["w_S53"];
                S53.AdvancedSearch.Save();
            }

            // Field S54
            if (filter?.TryGetValue("x_S54", out sv) ?? false) {
                S54.AdvancedSearch.SearchValue = sv;
                S54.AdvancedSearch.SearchOperator = filter["z_S54"];
                S54.AdvancedSearch.SearchCondition = filter["v_S54"];
                S54.AdvancedSearch.SearchValue2 = filter["y_S54"];
                S54.AdvancedSearch.SearchOperator2 = filter["w_S54"];
                S54.AdvancedSearch.Save();
            }

            // Field S55
            if (filter?.TryGetValue("x_S55", out sv) ?? false) {
                S55.AdvancedSearch.SearchValue = sv;
                S55.AdvancedSearch.SearchOperator = filter["z_S55"];
                S55.AdvancedSearch.SearchCondition = filter["v_S55"];
                S55.AdvancedSearch.SearchValue2 = filter["y_S55"];
                S55.AdvancedSearch.SearchOperator2 = filter["w_S55"];
                S55.AdvancedSearch.Save();
            }

            // Field Scores_S9
            if (filter?.TryGetValue("x_Scores_S9", out sv) ?? false) {
                Scores_S9.AdvancedSearch.SearchValue = sv;
                Scores_S9.AdvancedSearch.SearchOperator = filter["z_Scores_S9"];
                Scores_S9.AdvancedSearch.SearchCondition = filter["v_Scores_S9"];
                Scores_S9.AdvancedSearch.SearchValue2 = filter["y_Scores_S9"];
                Scores_S9.AdvancedSearch.SearchOperator2 = filter["w_Scores_S9"];
                Scores_S9.AdvancedSearch.Save();
            }

            // Field S56
            if (filter?.TryGetValue("x_S56", out sv) ?? false) {
                S56.AdvancedSearch.SearchValue = sv;
                S56.AdvancedSearch.SearchOperator = filter["z_S56"];
                S56.AdvancedSearch.SearchCondition = filter["v_S56"];
                S56.AdvancedSearch.SearchValue2 = filter["y_S56"];
                S56.AdvancedSearch.SearchOperator2 = filter["w_S56"];
                S56.AdvancedSearch.Save();
            }

            // Field S57
            if (filter?.TryGetValue("x_S57", out sv) ?? false) {
                S57.AdvancedSearch.SearchValue = sv;
                S57.AdvancedSearch.SearchOperator = filter["z_S57"];
                S57.AdvancedSearch.SearchCondition = filter["v_S57"];
                S57.AdvancedSearch.SearchValue2 = filter["y_S57"];
                S57.AdvancedSearch.SearchOperator2 = filter["w_S57"];
                S57.AdvancedSearch.Save();
            }

            // Field S58
            if (filter?.TryGetValue("x_S58", out sv) ?? false) {
                S58.AdvancedSearch.SearchValue = sv;
                S58.AdvancedSearch.SearchOperator = filter["z_S58"];
                S58.AdvancedSearch.SearchCondition = filter["v_S58"];
                S58.AdvancedSearch.SearchValue2 = filter["y_S58"];
                S58.AdvancedSearch.SearchOperator2 = filter["w_S58"];
                S58.AdvancedSearch.Save();
            }

            // Field S59
            if (filter?.TryGetValue("x_S59", out sv) ?? false) {
                S59.AdvancedSearch.SearchValue = sv;
                S59.AdvancedSearch.SearchOperator = filter["z_S59"];
                S59.AdvancedSearch.SearchCondition = filter["v_S59"];
                S59.AdvancedSearch.SearchValue2 = filter["y_S59"];
                S59.AdvancedSearch.SearchOperator2 = filter["w_S59"];
                S59.AdvancedSearch.Save();
            }

            // Field Scores_S10
            if (filter?.TryGetValue("x_Scores_S10", out sv) ?? false) {
                Scores_S10.AdvancedSearch.SearchValue = sv;
                Scores_S10.AdvancedSearch.SearchOperator = filter["z_Scores_S10"];
                Scores_S10.AdvancedSearch.SearchCondition = filter["v_Scores_S10"];
                Scores_S10.AdvancedSearch.SearchValue2 = filter["y_Scores_S10"];
                Scores_S10.AdvancedSearch.SearchOperator2 = filter["w_Scores_S10"];
                Scores_S10.AdvancedSearch.Save();
            }

            // Field S60
            if (filter?.TryGetValue("x_S60", out sv) ?? false) {
                S60.AdvancedSearch.SearchValue = sv;
                S60.AdvancedSearch.SearchOperator = filter["z_S60"];
                S60.AdvancedSearch.SearchCondition = filter["v_S60"];
                S60.AdvancedSearch.SearchValue2 = filter["y_S60"];
                S60.AdvancedSearch.SearchOperator2 = filter["w_S60"];
                S60.AdvancedSearch.Save();
            }

            // Field S61
            if (filter?.TryGetValue("x_S61", out sv) ?? false) {
                S61.AdvancedSearch.SearchValue = sv;
                S61.AdvancedSearch.SearchOperator = filter["z_S61"];
                S61.AdvancedSearch.SearchCondition = filter["v_S61"];
                S61.AdvancedSearch.SearchValue2 = filter["y_S61"];
                S61.AdvancedSearch.SearchOperator2 = filter["w_S61"];
                S61.AdvancedSearch.Save();
            }

            // Field S62
            if (filter?.TryGetValue("x_S62", out sv) ?? false) {
                S62.AdvancedSearch.SearchValue = sv;
                S62.AdvancedSearch.SearchOperator = filter["z_S62"];
                S62.AdvancedSearch.SearchCondition = filter["v_S62"];
                S62.AdvancedSearch.SearchValue2 = filter["y_S62"];
                S62.AdvancedSearch.SearchOperator2 = filter["w_S62"];
                S62.AdvancedSearch.Save();
            }

            // Field S63
            if (filter?.TryGetValue("x_S63", out sv) ?? false) {
                S63.AdvancedSearch.SearchValue = sv;
                S63.AdvancedSearch.SearchOperator = filter["z_S63"];
                S63.AdvancedSearch.SearchCondition = filter["v_S63"];
                S63.AdvancedSearch.SearchValue2 = filter["y_S63"];
                S63.AdvancedSearch.SearchOperator2 = filter["w_S63"];
                S63.AdvancedSearch.Save();
            }

            // Field S64
            if (filter?.TryGetValue("x_S64", out sv) ?? false) {
                S64.AdvancedSearch.SearchValue = sv;
                S64.AdvancedSearch.SearchOperator = filter["z_S64"];
                S64.AdvancedSearch.SearchCondition = filter["v_S64"];
                S64.AdvancedSearch.SearchValue2 = filter["y_S64"];
                S64.AdvancedSearch.SearchOperator2 = filter["w_S64"];
                S64.AdvancedSearch.Save();
            }

            // Field S65
            if (filter?.TryGetValue("x_S65", out sv) ?? false) {
                S65.AdvancedSearch.SearchValue = sv;
                S65.AdvancedSearch.SearchOperator = filter["z_S65"];
                S65.AdvancedSearch.SearchCondition = filter["v_S65"];
                S65.AdvancedSearch.SearchValue2 = filter["y_S65"];
                S65.AdvancedSearch.SearchOperator2 = filter["w_S65"];
                S65.AdvancedSearch.Save();
            }

            // Field Scores_S11
            if (filter?.TryGetValue("x_Scores_S11", out sv) ?? false) {
                Scores_S11.AdvancedSearch.SearchValue = sv;
                Scores_S11.AdvancedSearch.SearchOperator = filter["z_Scores_S11"];
                Scores_S11.AdvancedSearch.SearchCondition = filter["v_Scores_S11"];
                Scores_S11.AdvancedSearch.SearchValue2 = filter["y_Scores_S11"];
                Scores_S11.AdvancedSearch.SearchOperator2 = filter["w_Scores_S11"];
                Scores_S11.AdvancedSearch.Save();
            }

            // Field S66
            if (filter?.TryGetValue("x_S66", out sv) ?? false) {
                S66.AdvancedSearch.SearchValue = sv;
                S66.AdvancedSearch.SearchOperator = filter["z_S66"];
                S66.AdvancedSearch.SearchCondition = filter["v_S66"];
                S66.AdvancedSearch.SearchValue2 = filter["y_S66"];
                S66.AdvancedSearch.SearchOperator2 = filter["w_S66"];
                S66.AdvancedSearch.Save();
            }

            // Field S67
            if (filter?.TryGetValue("x_S67", out sv) ?? false) {
                S67.AdvancedSearch.SearchValue = sv;
                S67.AdvancedSearch.SearchOperator = filter["z_S67"];
                S67.AdvancedSearch.SearchCondition = filter["v_S67"];
                S67.AdvancedSearch.SearchValue2 = filter["y_S67"];
                S67.AdvancedSearch.SearchOperator2 = filter["w_S67"];
                S67.AdvancedSearch.Save();
            }

            // Field S68
            if (filter?.TryGetValue("x_S68", out sv) ?? false) {
                S68.AdvancedSearch.SearchValue = sv;
                S68.AdvancedSearch.SearchOperator = filter["z_S68"];
                S68.AdvancedSearch.SearchCondition = filter["v_S68"];
                S68.AdvancedSearch.SearchValue2 = filter["y_S68"];
                S68.AdvancedSearch.SearchOperator2 = filter["w_S68"];
                S68.AdvancedSearch.Save();
            }

            // Field S69
            if (filter?.TryGetValue("x_S69", out sv) ?? false) {
                S69.AdvancedSearch.SearchValue = sv;
                S69.AdvancedSearch.SearchOperator = filter["z_S69"];
                S69.AdvancedSearch.SearchCondition = filter["v_S69"];
                S69.AdvancedSearch.SearchValue2 = filter["y_S69"];
                S69.AdvancedSearch.SearchOperator2 = filter["w_S69"];
                S69.AdvancedSearch.Save();
            }

            // Field S70
            if (filter?.TryGetValue("x_S70", out sv) ?? false) {
                S70.AdvancedSearch.SearchValue = sv;
                S70.AdvancedSearch.SearchOperator = filter["z_S70"];
                S70.AdvancedSearch.SearchCondition = filter["v_S70"];
                S70.AdvancedSearch.SearchValue2 = filter["y_S70"];
                S70.AdvancedSearch.SearchOperator2 = filter["w_S70"];
                S70.AdvancedSearch.Save();
            }

            // Field Evaluation_Score
            if (filter?.TryGetValue("x_Evaluation_Score", out sv) ?? false) {
                Evaluation_Score.AdvancedSearch.SearchValue = sv;
                Evaluation_Score.AdvancedSearch.SearchOperator = filter["z_Evaluation_Score"];
                Evaluation_Score.AdvancedSearch.SearchCondition = filter["v_Evaluation_Score"];
                Evaluation_Score.AdvancedSearch.SearchValue2 = filter["y_Evaluation_Score"];
                Evaluation_Score.AdvancedSearch.SearchOperator2 = filter["w_Evaluation_Score"];
                Evaluation_Score.AdvancedSearch.Save();
            }

            // Field Immediate_Failure_Score
            if (filter?.TryGetValue("x_Immediate_Failure_Score", out sv) ?? false) {
                Immediate_Failure_Score.AdvancedSearch.SearchValue = sv;
                Immediate_Failure_Score.AdvancedSearch.SearchOperator = filter["z_Immediate_Failure_Score"];
                Immediate_Failure_Score.AdvancedSearch.SearchCondition = filter["v_Immediate_Failure_Score"];
                Immediate_Failure_Score.AdvancedSearch.SearchValue2 = filter["y_Immediate_Failure_Score"];
                Immediate_Failure_Score.AdvancedSearch.SearchOperator2 = filter["w_Immediate_Failure_Score"];
                Immediate_Failure_Score.AdvancedSearch.Save();
            }

            // Field Required_Program
            if (filter?.TryGetValue("x_Required_Program", out sv) ?? false) {
                Required_Program.AdvancedSearch.SearchValue = sv;
                Required_Program.AdvancedSearch.SearchOperator = filter["z_Required_Program"];
                Required_Program.AdvancedSearch.SearchCondition = filter["v_Required_Program"];
                Required_Program.AdvancedSearch.SearchValue2 = filter["y_Required_Program"];
                Required_Program.AdvancedSearch.SearchOperator2 = filter["w_Required_Program"];
                Required_Program.AdvancedSearch.Save();
            }

            // Field Price
            if (filter?.TryGetValue("x_Price", out sv) ?? false) {
                Price.AdvancedSearch.SearchValue = sv;
                Price.AdvancedSearch.SearchOperator = filter["z_Price"];
                Price.AdvancedSearch.SearchCondition = filter["v_Price"];
                Price.AdvancedSearch.SearchValue2 = filter["y_Price"];
                Price.AdvancedSearch.SearchOperator2 = filter["w_Price"];
                Price.AdvancedSearch.Save();
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
            BuildSearchSql(ref where, Eval_ID, def, false); // Eval_ID
            BuildSearchSql(ref where, int_Student_ID, def, false); // int_Student_ID
            BuildSearchSql(ref where, AssessmentID, def, false); // AssessmentID
            BuildSearchSql(ref where, str_Full_Name_Hdr, def, false); // str_Full_Name_Hdr
            BuildSearchSql(ref where, NationalID, def, false); // NationalID
            BuildSearchSql(ref where, str_Cell_Phone, def, false); // str_Cell_Phone
            BuildSearchSql(ref where, str_Username, def, false); // str_Username
            BuildSearchSql(ref where, intDrivinglicenseType, def, false); // intDrivinglicenseType
            BuildSearchSql(ref where, Date_Entered, def, false); // Date_Entered
            BuildSearchSql(ref where, Examination_Number, def, false); // Examination_Number
            BuildSearchSql(ref where, Retake, def, true); // Retake
            BuildSearchSql(ref where, Section_1, def, false); // Section_1
            BuildSearchSql(ref where, Q1, def, false); // Q1
            BuildSearchSql(ref where, Q2, def, false); // Q2
            BuildSearchSql(ref where, Q3, def, false); // Q3
            BuildSearchSql(ref where, Q4, def, false); // Q4
            BuildSearchSql(ref where, Q5, def, false); // Q5
            BuildSearchSql(ref where, Section_2, def, false); // Section_2
            BuildSearchSql(ref where, Q6, def, false); // Q6
            BuildSearchSql(ref where, Q7, def, false); // Q7
            BuildSearchSql(ref where, Q8, def, false); // Q8
            BuildSearchSql(ref where, Q9, def, false); // Q9
            BuildSearchSql(ref where, Q10, def, false); // Q10
            BuildSearchSql(ref where, Q11, def, false); // Q11
            BuildSearchSql(ref where, Q12, def, false); // Q12
            BuildSearchSql(ref where, Q13, def, false); // Q13
            BuildSearchSql(ref where, Q14, def, false); // Q14
            BuildSearchSql(ref where, Q15, def, false); // Q15
            BuildSearchSql(ref where, Section_3, def, false); // Section_3
            BuildSearchSql(ref where, Q16, def, false); // Q16
            BuildSearchSql(ref where, Q17, def, false); // Q17
            BuildSearchSql(ref where, Q18, def, false); // Q18
            BuildSearchSql(ref where, Q19, def, false); // Q19
            BuildSearchSql(ref where, Q20, def, false); // Q20
            BuildSearchSql(ref where, Q21, def, false); // Q21
            BuildSearchSql(ref where, Section_4, def, false); // Section_4
            BuildSearchSql(ref where, Q22, def, false); // Q22
            BuildSearchSql(ref where, Q23, def, false); // Q23
            BuildSearchSql(ref where, Q24, def, false); // Q24
            BuildSearchSql(ref where, Q25, def, false); // Q25
            BuildSearchSql(ref where, Q26, def, false); // Q26
            BuildSearchSql(ref where, Section_5, def, false); // Section_5
            BuildSearchSql(ref where, Q27, def, false); // Q27
            BuildSearchSql(ref where, Q28, def, false); // Q28
            BuildSearchSql(ref where, Q29, def, false); // Q29
            BuildSearchSql(ref where, Q30, def, false); // Q30
            BuildSearchSql(ref where, Q31, def, false); // Q31
            BuildSearchSql(ref where, Q32, def, false); // Q32
            BuildSearchSql(ref where, Q33, def, false); // Q33
            BuildSearchSql(ref where, Q34, def, false); // Q34
            BuildSearchSql(ref where, Q35, def, false); // Q35
            BuildSearchSql(ref where, Section_6, def, false); // Section_6
            BuildSearchSql(ref where, Q36, def, false); // Q36
            BuildSearchSql(ref where, Q37, def, false); // Q37
            BuildSearchSql(ref where, Q38, def, false); // Q38
            BuildSearchSql(ref where, Q39, def, false); // Q39
            BuildSearchSql(ref where, Q40, def, false); // Q40
            BuildSearchSql(ref where, Q41, def, false); // Q41
            BuildSearchSql(ref where, Q42, def, false); // Q42
            BuildSearchSql(ref where, Q43, def, false); // Q43
            BuildSearchSql(ref where, Section_7, def, false); // Section_7
            BuildSearchSql(ref where, Q44, def, false); // Q44
            BuildSearchSql(ref where, Q45, def, false); // Q45
            BuildSearchSql(ref where, Q46, def, false); // Q46
            BuildSearchSql(ref where, Q47, def, false); // Q47
            BuildSearchSql(ref where, Q48, def, false); // Q48
            BuildSearchSql(ref where, Q49, def, false); // Q49
            BuildSearchSql(ref where, Q50, def, false); // Q50
            BuildSearchSql(ref where, Section_8, def, false); // Section_8
            BuildSearchSql(ref where, Q51, def, false); // Q51
            BuildSearchSql(ref where, Q52, def, false); // Q52
            BuildSearchSql(ref where, Q53, def, false); // Q53
            BuildSearchSql(ref where, Q54, def, false); // Q54
            BuildSearchSql(ref where, Q55, def, false); // Q55
            BuildSearchSql(ref where, Section_9, def, false); // Section_9
            BuildSearchSql(ref where, Q56, def, false); // Q56
            BuildSearchSql(ref where, Q57, def, false); // Q57
            BuildSearchSql(ref where, Q58, def, false); // Q58
            BuildSearchSql(ref where, Q59, def, false); // Q59
            BuildSearchSql(ref where, Section_10, def, false); // Section_10
            BuildSearchSql(ref where, Q60, def, false); // Q60
            BuildSearchSql(ref where, Q61, def, false); // Q61
            BuildSearchSql(ref where, Q62, def, false); // Q62
            BuildSearchSql(ref where, Q63, def, false); // Q63
            BuildSearchSql(ref where, Q64, def, false); // Q64
            BuildSearchSql(ref where, Q65, def, false); // Q65
            BuildSearchSql(ref where, Section_11, def, false); // Section_11
            BuildSearchSql(ref where, Q66, def, false); // Q66
            BuildSearchSql(ref where, Q67, def, false); // Q67
            BuildSearchSql(ref where, Q68, def, false); // Q68
            BuildSearchSql(ref where, Q69, def, false); // Q69
            BuildSearchSql(ref where, Q70, def, false); // Q70
            BuildSearchSql(ref where, Notes_3, def, false); // Notes_3
            BuildSearchSql(ref where, Examiner_Signature, def, false); // Examiner_Signature
            BuildSearchSql(ref where, Student_Signature, def, false); // Student_Signature
            BuildSearchSql(ref where, AbsherApptNbr, def, true); // AbsherApptNbr
            BuildSearchSql(ref where, IsDrivingexperience, def, false); // IsDrivingexperience
            BuildSearchSql(ref where, date_Birth_Hijri, def, false); // date_Birth_Hijri
            BuildSearchSql(ref where, date_Birth, def, false); // date_Birth
            BuildSearchSql(ref where, str_Email, def, false); // str_Email
            BuildSearchSql(ref where, UserlevelID, def, false); // UserlevelID
            BuildSearchSql(ref where, DriveTypelink, def, false); // DriveTypelink
            BuildSearchSql(ref where, intEvaluationType, def, false); // intEvaluationType
            BuildSearchSql(ref where, Institution, def, false); // Institution
            BuildSearchSql(ref where, Scores_S1, def, false); // Scores_S1
            BuildSearchSql(ref where, S1, def, false); // S1
            BuildSearchSql(ref where, S2, def, false); // S2
            BuildSearchSql(ref where, S3, def, false); // S3
            BuildSearchSql(ref where, S4, def, false); // S4
            BuildSearchSql(ref where, S5, def, false); // S5
            BuildSearchSql(ref where, Scores_S2, def, false); // Scores_S2
            BuildSearchSql(ref where, S6, def, false); // S6
            BuildSearchSql(ref where, S7, def, false); // S7
            BuildSearchSql(ref where, S8, def, false); // S8
            BuildSearchSql(ref where, S9, def, false); // S9
            BuildSearchSql(ref where, S10, def, false); // S10
            BuildSearchSql(ref where, S11, def, false); // S11
            BuildSearchSql(ref where, S12, def, false); // S12
            BuildSearchSql(ref where, S13, def, false); // S13
            BuildSearchSql(ref where, S14, def, false); // S14
            BuildSearchSql(ref where, S15, def, false); // S15
            BuildSearchSql(ref where, Scores_S3, def, false); // Scores_S3
            BuildSearchSql(ref where, S16, def, false); // S16
            BuildSearchSql(ref where, S17, def, false); // S17
            BuildSearchSql(ref where, S18, def, false); // S18
            BuildSearchSql(ref where, S19, def, false); // S19
            BuildSearchSql(ref where, S20, def, false); // S20
            BuildSearchSql(ref where, S21, def, false); // S21
            BuildSearchSql(ref where, Scores_S4, def, false); // Scores_S4
            BuildSearchSql(ref where, S22, def, false); // S22
            BuildSearchSql(ref where, S23, def, false); // S23
            BuildSearchSql(ref where, S24, def, false); // S24
            BuildSearchSql(ref where, S25, def, false); // S25
            BuildSearchSql(ref where, S26, def, false); // S26
            BuildSearchSql(ref where, Scores_S5, def, false); // Scores_S5
            BuildSearchSql(ref where, S27, def, false); // S27
            BuildSearchSql(ref where, S28, def, false); // S28
            BuildSearchSql(ref where, S29, def, false); // S29
            BuildSearchSql(ref where, S30, def, false); // S30
            BuildSearchSql(ref where, S31, def, false); // S31
            BuildSearchSql(ref where, S32, def, false); // S32
            BuildSearchSql(ref where, S33, def, false); // S33
            BuildSearchSql(ref where, S34, def, false); // S34
            BuildSearchSql(ref where, S35, def, false); // S35
            BuildSearchSql(ref where, Scores_S6, def, false); // Scores_S6
            BuildSearchSql(ref where, S36, def, false); // S36
            BuildSearchSql(ref where, S37, def, false); // S37
            BuildSearchSql(ref where, S38, def, false); // S38
            BuildSearchSql(ref where, S39, def, false); // S39
            BuildSearchSql(ref where, S40, def, false); // S40
            BuildSearchSql(ref where, S41, def, false); // S41
            BuildSearchSql(ref where, S42, def, false); // S42
            BuildSearchSql(ref where, S43, def, false); // S43
            BuildSearchSql(ref where, Scores_S7, def, false); // Scores_S7
            BuildSearchSql(ref where, S44, def, false); // S44
            BuildSearchSql(ref where, S45, def, false); // S45
            BuildSearchSql(ref where, S46, def, false); // S46
            BuildSearchSql(ref where, S47, def, false); // S47
            BuildSearchSql(ref where, S48, def, false); // S48
            BuildSearchSql(ref where, S49, def, false); // S49
            BuildSearchSql(ref where, S50, def, false); // S50
            BuildSearchSql(ref where, Scores_S8, def, false); // Scores_S8
            BuildSearchSql(ref where, S51, def, false); // S51
            BuildSearchSql(ref where, S52, def, false); // S52
            BuildSearchSql(ref where, S53, def, false); // S53
            BuildSearchSql(ref where, S54, def, false); // S54
            BuildSearchSql(ref where, S55, def, false); // S55
            BuildSearchSql(ref where, Scores_S9, def, false); // Scores_S9
            BuildSearchSql(ref where, S56, def, false); // S56
            BuildSearchSql(ref where, S57, def, false); // S57
            BuildSearchSql(ref where, S58, def, false); // S58
            BuildSearchSql(ref where, S59, def, false); // S59
            BuildSearchSql(ref where, Scores_S10, def, false); // Scores_S10
            BuildSearchSql(ref where, S60, def, false); // S60
            BuildSearchSql(ref where, S61, def, false); // S61
            BuildSearchSql(ref where, S62, def, false); // S62
            BuildSearchSql(ref where, S63, def, false); // S63
            BuildSearchSql(ref where, S64, def, false); // S64
            BuildSearchSql(ref where, S65, def, false); // S65
            BuildSearchSql(ref where, Scores_S11, def, false); // Scores_S11
            BuildSearchSql(ref where, S66, def, false); // S66
            BuildSearchSql(ref where, S67, def, false); // S67
            BuildSearchSql(ref where, S68, def, false); // S68
            BuildSearchSql(ref where, S69, def, false); // S69
            BuildSearchSql(ref where, S70, def, false); // S70
            BuildSearchSql(ref where, Evaluation_Score, def, false); // Evaluation_Score
            BuildSearchSql(ref where, Immediate_Failure_Score, def, false); // Immediate_Failure_Score
            BuildSearchSql(ref where, Required_Program, def, false); // Required_Program
            BuildSearchSql(ref where, Price, def, false); // Price

            // Set up search command
            if (!def && !Empty(where) && (new[] { "", "reset", "resetall" }).Contains(Command))
                Command = "search";
            if (!def && Command == "search") {
                Eval_ID.AdvancedSearch.Save(); // Eval_ID
                int_Student_ID.AdvancedSearch.Save(); // int_Student_ID
                AssessmentID.AdvancedSearch.Save(); // AssessmentID
                str_Full_Name_Hdr.AdvancedSearch.Save(); // str_Full_Name_Hdr
                NationalID.AdvancedSearch.Save(); // NationalID
                str_Cell_Phone.AdvancedSearch.Save(); // str_Cell_Phone
                str_Username.AdvancedSearch.Save(); // str_Username
                intDrivinglicenseType.AdvancedSearch.Save(); // intDrivinglicenseType
                Date_Entered.AdvancedSearch.Save(); // Date_Entered
                Examination_Number.AdvancedSearch.Save(); // Examination_Number
                Retake.AdvancedSearch.Save(); // Retake
                Section_1.AdvancedSearch.Save(); // Section_1
                Q1.AdvancedSearch.Save(); // Q1
                Q2.AdvancedSearch.Save(); // Q2
                Q3.AdvancedSearch.Save(); // Q3
                Q4.AdvancedSearch.Save(); // Q4
                Q5.AdvancedSearch.Save(); // Q5
                Section_2.AdvancedSearch.Save(); // Section_2
                Q6.AdvancedSearch.Save(); // Q6
                Q7.AdvancedSearch.Save(); // Q7
                Q8.AdvancedSearch.Save(); // Q8
                Q9.AdvancedSearch.Save(); // Q9
                Q10.AdvancedSearch.Save(); // Q10
                Q11.AdvancedSearch.Save(); // Q11
                Q12.AdvancedSearch.Save(); // Q12
                Q13.AdvancedSearch.Save(); // Q13
                Q14.AdvancedSearch.Save(); // Q14
                Q15.AdvancedSearch.Save(); // Q15
                Section_3.AdvancedSearch.Save(); // Section_3
                Q16.AdvancedSearch.Save(); // Q16
                Q17.AdvancedSearch.Save(); // Q17
                Q18.AdvancedSearch.Save(); // Q18
                Q19.AdvancedSearch.Save(); // Q19
                Q20.AdvancedSearch.Save(); // Q20
                Q21.AdvancedSearch.Save(); // Q21
                Section_4.AdvancedSearch.Save(); // Section_4
                Q22.AdvancedSearch.Save(); // Q22
                Q23.AdvancedSearch.Save(); // Q23
                Q24.AdvancedSearch.Save(); // Q24
                Q25.AdvancedSearch.Save(); // Q25
                Q26.AdvancedSearch.Save(); // Q26
                Section_5.AdvancedSearch.Save(); // Section_5
                Q27.AdvancedSearch.Save(); // Q27
                Q28.AdvancedSearch.Save(); // Q28
                Q29.AdvancedSearch.Save(); // Q29
                Q30.AdvancedSearch.Save(); // Q30
                Q31.AdvancedSearch.Save(); // Q31
                Q32.AdvancedSearch.Save(); // Q32
                Q33.AdvancedSearch.Save(); // Q33
                Q34.AdvancedSearch.Save(); // Q34
                Q35.AdvancedSearch.Save(); // Q35
                Section_6.AdvancedSearch.Save(); // Section_6
                Q36.AdvancedSearch.Save(); // Q36
                Q37.AdvancedSearch.Save(); // Q37
                Q38.AdvancedSearch.Save(); // Q38
                Q39.AdvancedSearch.Save(); // Q39
                Q40.AdvancedSearch.Save(); // Q40
                Q41.AdvancedSearch.Save(); // Q41
                Q42.AdvancedSearch.Save(); // Q42
                Q43.AdvancedSearch.Save(); // Q43
                Section_7.AdvancedSearch.Save(); // Section_7
                Q44.AdvancedSearch.Save(); // Q44
                Q45.AdvancedSearch.Save(); // Q45
                Q46.AdvancedSearch.Save(); // Q46
                Q47.AdvancedSearch.Save(); // Q47
                Q48.AdvancedSearch.Save(); // Q48
                Q49.AdvancedSearch.Save(); // Q49
                Q50.AdvancedSearch.Save(); // Q50
                Section_8.AdvancedSearch.Save(); // Section_8
                Q51.AdvancedSearch.Save(); // Q51
                Q52.AdvancedSearch.Save(); // Q52
                Q53.AdvancedSearch.Save(); // Q53
                Q54.AdvancedSearch.Save(); // Q54
                Q55.AdvancedSearch.Save(); // Q55
                Section_9.AdvancedSearch.Save(); // Section_9
                Q56.AdvancedSearch.Save(); // Q56
                Q57.AdvancedSearch.Save(); // Q57
                Q58.AdvancedSearch.Save(); // Q58
                Q59.AdvancedSearch.Save(); // Q59
                Section_10.AdvancedSearch.Save(); // Section_10
                Q60.AdvancedSearch.Save(); // Q60
                Q61.AdvancedSearch.Save(); // Q61
                Q62.AdvancedSearch.Save(); // Q62
                Q63.AdvancedSearch.Save(); // Q63
                Q64.AdvancedSearch.Save(); // Q64
                Q65.AdvancedSearch.Save(); // Q65
                Section_11.AdvancedSearch.Save(); // Section_11
                Q66.AdvancedSearch.Save(); // Q66
                Q67.AdvancedSearch.Save(); // Q67
                Q68.AdvancedSearch.Save(); // Q68
                Q69.AdvancedSearch.Save(); // Q69
                Q70.AdvancedSearch.Save(); // Q70
                Notes_3.AdvancedSearch.Save(); // Notes_3
                Examiner_Signature.AdvancedSearch.Save(); // Examiner_Signature
                Student_Signature.AdvancedSearch.Save(); // Student_Signature
                AbsherApptNbr.AdvancedSearch.Save(); // AbsherApptNbr
                IsDrivingexperience.AdvancedSearch.Save(); // IsDrivingexperience
                date_Birth_Hijri.AdvancedSearch.Save(); // date_Birth_Hijri
                date_Birth.AdvancedSearch.Save(); // date_Birth
                str_Email.AdvancedSearch.Save(); // str_Email
                UserlevelID.AdvancedSearch.Save(); // UserlevelID
                DriveTypelink.AdvancedSearch.Save(); // DriveTypelink
                intEvaluationType.AdvancedSearch.Save(); // intEvaluationType
                Institution.AdvancedSearch.Save(); // Institution
                Scores_S1.AdvancedSearch.Save(); // Scores_S1
                S1.AdvancedSearch.Save(); // S1
                S2.AdvancedSearch.Save(); // S2
                S3.AdvancedSearch.Save(); // S3
                S4.AdvancedSearch.Save(); // S4
                S5.AdvancedSearch.Save(); // S5
                Scores_S2.AdvancedSearch.Save(); // Scores_S2
                S6.AdvancedSearch.Save(); // S6
                S7.AdvancedSearch.Save(); // S7
                S8.AdvancedSearch.Save(); // S8
                S9.AdvancedSearch.Save(); // S9
                S10.AdvancedSearch.Save(); // S10
                S11.AdvancedSearch.Save(); // S11
                S12.AdvancedSearch.Save(); // S12
                S13.AdvancedSearch.Save(); // S13
                S14.AdvancedSearch.Save(); // S14
                S15.AdvancedSearch.Save(); // S15
                Scores_S3.AdvancedSearch.Save(); // Scores_S3
                S16.AdvancedSearch.Save(); // S16
                S17.AdvancedSearch.Save(); // S17
                S18.AdvancedSearch.Save(); // S18
                S19.AdvancedSearch.Save(); // S19
                S20.AdvancedSearch.Save(); // S20
                S21.AdvancedSearch.Save(); // S21
                Scores_S4.AdvancedSearch.Save(); // Scores_S4
                S22.AdvancedSearch.Save(); // S22
                S23.AdvancedSearch.Save(); // S23
                S24.AdvancedSearch.Save(); // S24
                S25.AdvancedSearch.Save(); // S25
                S26.AdvancedSearch.Save(); // S26
                Scores_S5.AdvancedSearch.Save(); // Scores_S5
                S27.AdvancedSearch.Save(); // S27
                S28.AdvancedSearch.Save(); // S28
                S29.AdvancedSearch.Save(); // S29
                S30.AdvancedSearch.Save(); // S30
                S31.AdvancedSearch.Save(); // S31
                S32.AdvancedSearch.Save(); // S32
                S33.AdvancedSearch.Save(); // S33
                S34.AdvancedSearch.Save(); // S34
                S35.AdvancedSearch.Save(); // S35
                Scores_S6.AdvancedSearch.Save(); // Scores_S6
                S36.AdvancedSearch.Save(); // S36
                S37.AdvancedSearch.Save(); // S37
                S38.AdvancedSearch.Save(); // S38
                S39.AdvancedSearch.Save(); // S39
                S40.AdvancedSearch.Save(); // S40
                S41.AdvancedSearch.Save(); // S41
                S42.AdvancedSearch.Save(); // S42
                S43.AdvancedSearch.Save(); // S43
                Scores_S7.AdvancedSearch.Save(); // Scores_S7
                S44.AdvancedSearch.Save(); // S44
                S45.AdvancedSearch.Save(); // S45
                S46.AdvancedSearch.Save(); // S46
                S47.AdvancedSearch.Save(); // S47
                S48.AdvancedSearch.Save(); // S48
                S49.AdvancedSearch.Save(); // S49
                S50.AdvancedSearch.Save(); // S50
                Scores_S8.AdvancedSearch.Save(); // Scores_S8
                S51.AdvancedSearch.Save(); // S51
                S52.AdvancedSearch.Save(); // S52
                S53.AdvancedSearch.Save(); // S53
                S54.AdvancedSearch.Save(); // S54
                S55.AdvancedSearch.Save(); // S55
                Scores_S9.AdvancedSearch.Save(); // Scores_S9
                S56.AdvancedSearch.Save(); // S56
                S57.AdvancedSearch.Save(); // S57
                S58.AdvancedSearch.Save(); // S58
                S59.AdvancedSearch.Save(); // S59
                Scores_S10.AdvancedSearch.Save(); // Scores_S10
                S60.AdvancedSearch.Save(); // S60
                S61.AdvancedSearch.Save(); // S61
                S62.AdvancedSearch.Save(); // S62
                S63.AdvancedSearch.Save(); // S63
                S64.AdvancedSearch.Save(); // S64
                S65.AdvancedSearch.Save(); // S65
                Scores_S11.AdvancedSearch.Save(); // Scores_S11
                S66.AdvancedSearch.Save(); // S66
                S67.AdvancedSearch.Save(); // S67
                S68.AdvancedSearch.Save(); // S68
                S69.AdvancedSearch.Save(); // S69
                S70.AdvancedSearch.Save(); // S70
                Evaluation_Score.AdvancedSearch.Save(); // Evaluation_Score
                Immediate_Failure_Score.AdvancedSearch.Save(); // Immediate_Failure_Score
                Required_Program.AdvancedSearch.Save(); // Required_Program
                Price.AdvancedSearch.Save(); // Price

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

            // Field str_Full_Name_Hdr
            filter = QueryBuilderWhere("str_Full_Name_Hdr");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Full_Name_Hdr, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Full_Name_Hdr.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field NationalID
            filter = QueryBuilderWhere("NationalID");
            if (Empty(filter))
                BuildSearchSql(ref filter, NationalID, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + NationalID.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field str_Cell_Phone
            filter = QueryBuilderWhere("str_Cell_Phone");
            if (Empty(filter))
                BuildSearchSql(ref filter, str_Cell_Phone, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + str_Cell_Phone.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field intDrivinglicenseType
            filter = QueryBuilderWhere("intDrivinglicenseType");
            if (Empty(filter))
                BuildSearchSql(ref filter, intDrivinglicenseType, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + intDrivinglicenseType.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field Retake
            filter = QueryBuilderWhere("Retake");
            if (Empty(filter))
                BuildSearchSql(ref filter, Retake, false, true);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + Retake.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field AbsherApptNbr
            filter = QueryBuilderWhere("AbsherApptNbr");
            if (Empty(filter))
                BuildSearchSql(ref filter, AbsherApptNbr, false, true);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + AbsherApptNbr.Caption + "</span>" + captionSuffix + filter + "</div>";

            // Field IsDrivingexperience
            filter = QueryBuilderWhere("IsDrivingexperience");
            if (Empty(filter))
                BuildSearchSql(ref filter, IsDrivingexperience, false, false);
            if (!Empty(filter))
                filterList += "<div><span class=\"" + captionClass + "\">" + IsDrivingexperience.Caption + "</span>" + captionSuffix + filter + "</div>";
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
            searchFlds.Add(str_Full_Name_Hdr);
            searchFlds.Add(NationalID);
            searchFlds.Add(str_Cell_Phone);
            searchFlds.Add(str_Username);
            searchFlds.Add(Section_2);
            searchFlds.Add(Section_3);
            searchFlds.Add(Section_4);
            searchFlds.Add(Section_5);
            searchFlds.Add(Section_6);
            searchFlds.Add(Section_7);
            searchFlds.Add(Section_8);
            searchFlds.Add(Section_9);
            searchFlds.Add(Section_10);
            searchFlds.Add(Section_11);
            searchFlds.Add(Notes_3);
            searchFlds.Add(Examiner_Signature);
            searchFlds.Add(Student_Signature);
            searchFlds.Add(AbsherApptNbr);
            searchFlds.Add(date_Birth_Hijri);
            searchFlds.Add(str_Email);
            searchFlds.Add(DriveTypelink);
            searchFlds.Add(Institution);
            searchFlds.Add(Scores_S1);
            searchFlds.Add(Scores_S2);
            searchFlds.Add(Scores_S3);
            searchFlds.Add(Scores_S4);
            searchFlds.Add(Scores_S5);
            searchFlds.Add(Scores_S6);
            searchFlds.Add(Scores_S7);
            searchFlds.Add(Scores_S8);
            searchFlds.Add(Scores_S9);
            searchFlds.Add(Scores_S10);
            searchFlds.Add(Scores_S11);
            searchFlds.Add(Required_Program);
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
            if (Eval_ID.AdvancedSearch.IssetSession)
                return true;
            if (int_Student_ID.AdvancedSearch.IssetSession)
                return true;
            if (AssessmentID.AdvancedSearch.IssetSession)
                return true;
            if (str_Full_Name_Hdr.AdvancedSearch.IssetSession)
                return true;
            if (NationalID.AdvancedSearch.IssetSession)
                return true;
            if (str_Cell_Phone.AdvancedSearch.IssetSession)
                return true;
            if (str_Username.AdvancedSearch.IssetSession)
                return true;
            if (intDrivinglicenseType.AdvancedSearch.IssetSession)
                return true;
            if (Date_Entered.AdvancedSearch.IssetSession)
                return true;
            if (Examination_Number.AdvancedSearch.IssetSession)
                return true;
            if (Retake.AdvancedSearch.IssetSession)
                return true;
            if (Section_1.AdvancedSearch.IssetSession)
                return true;
            if (Q1.AdvancedSearch.IssetSession)
                return true;
            if (Q2.AdvancedSearch.IssetSession)
                return true;
            if (Q3.AdvancedSearch.IssetSession)
                return true;
            if (Q4.AdvancedSearch.IssetSession)
                return true;
            if (Q5.AdvancedSearch.IssetSession)
                return true;
            if (Section_2.AdvancedSearch.IssetSession)
                return true;
            if (Q6.AdvancedSearch.IssetSession)
                return true;
            if (Q7.AdvancedSearch.IssetSession)
                return true;
            if (Q8.AdvancedSearch.IssetSession)
                return true;
            if (Q9.AdvancedSearch.IssetSession)
                return true;
            if (Q10.AdvancedSearch.IssetSession)
                return true;
            if (Q11.AdvancedSearch.IssetSession)
                return true;
            if (Q12.AdvancedSearch.IssetSession)
                return true;
            if (Q13.AdvancedSearch.IssetSession)
                return true;
            if (Q14.AdvancedSearch.IssetSession)
                return true;
            if (Q15.AdvancedSearch.IssetSession)
                return true;
            if (Section_3.AdvancedSearch.IssetSession)
                return true;
            if (Q16.AdvancedSearch.IssetSession)
                return true;
            if (Q17.AdvancedSearch.IssetSession)
                return true;
            if (Q18.AdvancedSearch.IssetSession)
                return true;
            if (Q19.AdvancedSearch.IssetSession)
                return true;
            if (Q20.AdvancedSearch.IssetSession)
                return true;
            if (Q21.AdvancedSearch.IssetSession)
                return true;
            if (Section_4.AdvancedSearch.IssetSession)
                return true;
            if (Q22.AdvancedSearch.IssetSession)
                return true;
            if (Q23.AdvancedSearch.IssetSession)
                return true;
            if (Q24.AdvancedSearch.IssetSession)
                return true;
            if (Q25.AdvancedSearch.IssetSession)
                return true;
            if (Q26.AdvancedSearch.IssetSession)
                return true;
            if (Section_5.AdvancedSearch.IssetSession)
                return true;
            if (Q27.AdvancedSearch.IssetSession)
                return true;
            if (Q28.AdvancedSearch.IssetSession)
                return true;
            if (Q29.AdvancedSearch.IssetSession)
                return true;
            if (Q30.AdvancedSearch.IssetSession)
                return true;
            if (Q31.AdvancedSearch.IssetSession)
                return true;
            if (Q32.AdvancedSearch.IssetSession)
                return true;
            if (Q33.AdvancedSearch.IssetSession)
                return true;
            if (Q34.AdvancedSearch.IssetSession)
                return true;
            if (Q35.AdvancedSearch.IssetSession)
                return true;
            if (Section_6.AdvancedSearch.IssetSession)
                return true;
            if (Q36.AdvancedSearch.IssetSession)
                return true;
            if (Q37.AdvancedSearch.IssetSession)
                return true;
            if (Q38.AdvancedSearch.IssetSession)
                return true;
            if (Q39.AdvancedSearch.IssetSession)
                return true;
            if (Q40.AdvancedSearch.IssetSession)
                return true;
            if (Q41.AdvancedSearch.IssetSession)
                return true;
            if (Q42.AdvancedSearch.IssetSession)
                return true;
            if (Q43.AdvancedSearch.IssetSession)
                return true;
            if (Section_7.AdvancedSearch.IssetSession)
                return true;
            if (Q44.AdvancedSearch.IssetSession)
                return true;
            if (Q45.AdvancedSearch.IssetSession)
                return true;
            if (Q46.AdvancedSearch.IssetSession)
                return true;
            if (Q47.AdvancedSearch.IssetSession)
                return true;
            if (Q48.AdvancedSearch.IssetSession)
                return true;
            if (Q49.AdvancedSearch.IssetSession)
                return true;
            if (Q50.AdvancedSearch.IssetSession)
                return true;
            if (Section_8.AdvancedSearch.IssetSession)
                return true;
            if (Q51.AdvancedSearch.IssetSession)
                return true;
            if (Q52.AdvancedSearch.IssetSession)
                return true;
            if (Q53.AdvancedSearch.IssetSession)
                return true;
            if (Q54.AdvancedSearch.IssetSession)
                return true;
            if (Q55.AdvancedSearch.IssetSession)
                return true;
            if (Section_9.AdvancedSearch.IssetSession)
                return true;
            if (Q56.AdvancedSearch.IssetSession)
                return true;
            if (Q57.AdvancedSearch.IssetSession)
                return true;
            if (Q58.AdvancedSearch.IssetSession)
                return true;
            if (Q59.AdvancedSearch.IssetSession)
                return true;
            if (Section_10.AdvancedSearch.IssetSession)
                return true;
            if (Q60.AdvancedSearch.IssetSession)
                return true;
            if (Q61.AdvancedSearch.IssetSession)
                return true;
            if (Q62.AdvancedSearch.IssetSession)
                return true;
            if (Q63.AdvancedSearch.IssetSession)
                return true;
            if (Q64.AdvancedSearch.IssetSession)
                return true;
            if (Q65.AdvancedSearch.IssetSession)
                return true;
            if (Section_11.AdvancedSearch.IssetSession)
                return true;
            if (Q66.AdvancedSearch.IssetSession)
                return true;
            if (Q67.AdvancedSearch.IssetSession)
                return true;
            if (Q68.AdvancedSearch.IssetSession)
                return true;
            if (Q69.AdvancedSearch.IssetSession)
                return true;
            if (Q70.AdvancedSearch.IssetSession)
                return true;
            if (Notes_3.AdvancedSearch.IssetSession)
                return true;
            if (Examiner_Signature.AdvancedSearch.IssetSession)
                return true;
            if (Student_Signature.AdvancedSearch.IssetSession)
                return true;
            if (AbsherApptNbr.AdvancedSearch.IssetSession)
                return true;
            if (IsDrivingexperience.AdvancedSearch.IssetSession)
                return true;
            if (date_Birth_Hijri.AdvancedSearch.IssetSession)
                return true;
            if (date_Birth.AdvancedSearch.IssetSession)
                return true;
            if (str_Email.AdvancedSearch.IssetSession)
                return true;
            if (UserlevelID.AdvancedSearch.IssetSession)
                return true;
            if (DriveTypelink.AdvancedSearch.IssetSession)
                return true;
            if (intEvaluationType.AdvancedSearch.IssetSession)
                return true;
            if (Institution.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S1.AdvancedSearch.IssetSession)
                return true;
            if (S1.AdvancedSearch.IssetSession)
                return true;
            if (S2.AdvancedSearch.IssetSession)
                return true;
            if (S3.AdvancedSearch.IssetSession)
                return true;
            if (S4.AdvancedSearch.IssetSession)
                return true;
            if (S5.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S2.AdvancedSearch.IssetSession)
                return true;
            if (S6.AdvancedSearch.IssetSession)
                return true;
            if (S7.AdvancedSearch.IssetSession)
                return true;
            if (S8.AdvancedSearch.IssetSession)
                return true;
            if (S9.AdvancedSearch.IssetSession)
                return true;
            if (S10.AdvancedSearch.IssetSession)
                return true;
            if (S11.AdvancedSearch.IssetSession)
                return true;
            if (S12.AdvancedSearch.IssetSession)
                return true;
            if (S13.AdvancedSearch.IssetSession)
                return true;
            if (S14.AdvancedSearch.IssetSession)
                return true;
            if (S15.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S3.AdvancedSearch.IssetSession)
                return true;
            if (S16.AdvancedSearch.IssetSession)
                return true;
            if (S17.AdvancedSearch.IssetSession)
                return true;
            if (S18.AdvancedSearch.IssetSession)
                return true;
            if (S19.AdvancedSearch.IssetSession)
                return true;
            if (S20.AdvancedSearch.IssetSession)
                return true;
            if (S21.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S4.AdvancedSearch.IssetSession)
                return true;
            if (S22.AdvancedSearch.IssetSession)
                return true;
            if (S23.AdvancedSearch.IssetSession)
                return true;
            if (S24.AdvancedSearch.IssetSession)
                return true;
            if (S25.AdvancedSearch.IssetSession)
                return true;
            if (S26.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S5.AdvancedSearch.IssetSession)
                return true;
            if (S27.AdvancedSearch.IssetSession)
                return true;
            if (S28.AdvancedSearch.IssetSession)
                return true;
            if (S29.AdvancedSearch.IssetSession)
                return true;
            if (S30.AdvancedSearch.IssetSession)
                return true;
            if (S31.AdvancedSearch.IssetSession)
                return true;
            if (S32.AdvancedSearch.IssetSession)
                return true;
            if (S33.AdvancedSearch.IssetSession)
                return true;
            if (S34.AdvancedSearch.IssetSession)
                return true;
            if (S35.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S6.AdvancedSearch.IssetSession)
                return true;
            if (S36.AdvancedSearch.IssetSession)
                return true;
            if (S37.AdvancedSearch.IssetSession)
                return true;
            if (S38.AdvancedSearch.IssetSession)
                return true;
            if (S39.AdvancedSearch.IssetSession)
                return true;
            if (S40.AdvancedSearch.IssetSession)
                return true;
            if (S41.AdvancedSearch.IssetSession)
                return true;
            if (S42.AdvancedSearch.IssetSession)
                return true;
            if (S43.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S7.AdvancedSearch.IssetSession)
                return true;
            if (S44.AdvancedSearch.IssetSession)
                return true;
            if (S45.AdvancedSearch.IssetSession)
                return true;
            if (S46.AdvancedSearch.IssetSession)
                return true;
            if (S47.AdvancedSearch.IssetSession)
                return true;
            if (S48.AdvancedSearch.IssetSession)
                return true;
            if (S49.AdvancedSearch.IssetSession)
                return true;
            if (S50.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S8.AdvancedSearch.IssetSession)
                return true;
            if (S51.AdvancedSearch.IssetSession)
                return true;
            if (S52.AdvancedSearch.IssetSession)
                return true;
            if (S53.AdvancedSearch.IssetSession)
                return true;
            if (S54.AdvancedSearch.IssetSession)
                return true;
            if (S55.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S9.AdvancedSearch.IssetSession)
                return true;
            if (S56.AdvancedSearch.IssetSession)
                return true;
            if (S57.AdvancedSearch.IssetSession)
                return true;
            if (S58.AdvancedSearch.IssetSession)
                return true;
            if (S59.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S10.AdvancedSearch.IssetSession)
                return true;
            if (S60.AdvancedSearch.IssetSession)
                return true;
            if (S61.AdvancedSearch.IssetSession)
                return true;
            if (S62.AdvancedSearch.IssetSession)
                return true;
            if (S63.AdvancedSearch.IssetSession)
                return true;
            if (S64.AdvancedSearch.IssetSession)
                return true;
            if (S65.AdvancedSearch.IssetSession)
                return true;
            if (Scores_S11.AdvancedSearch.IssetSession)
                return true;
            if (S66.AdvancedSearch.IssetSession)
                return true;
            if (S67.AdvancedSearch.IssetSession)
                return true;
            if (S68.AdvancedSearch.IssetSession)
                return true;
            if (S69.AdvancedSearch.IssetSession)
                return true;
            if (S70.AdvancedSearch.IssetSession)
                return true;
            if (Evaluation_Score.AdvancedSearch.IssetSession)
                return true;
            if (Immediate_Failure_Score.AdvancedSearch.IssetSession)
                return true;
            if (Required_Program.AdvancedSearch.IssetSession)
                return true;
            if (Price.AdvancedSearch.IssetSession)
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
            Eval_ID.AdvancedSearch.UnsetSession();
            int_Student_ID.AdvancedSearch.UnsetSession();
            AssessmentID.AdvancedSearch.UnsetSession();
            str_Full_Name_Hdr.AdvancedSearch.UnsetSession();
            NationalID.AdvancedSearch.UnsetSession();
            str_Cell_Phone.AdvancedSearch.UnsetSession();
            str_Username.AdvancedSearch.UnsetSession();
            intDrivinglicenseType.AdvancedSearch.UnsetSession();
            Date_Entered.AdvancedSearch.UnsetSession();
            Examination_Number.AdvancedSearch.UnsetSession();
            Retake.AdvancedSearch.UnsetSession();
            Section_1.AdvancedSearch.UnsetSession();
            Q1.AdvancedSearch.UnsetSession();
            Q2.AdvancedSearch.UnsetSession();
            Q3.AdvancedSearch.UnsetSession();
            Q4.AdvancedSearch.UnsetSession();
            Q5.AdvancedSearch.UnsetSession();
            Section_2.AdvancedSearch.UnsetSession();
            Q6.AdvancedSearch.UnsetSession();
            Q7.AdvancedSearch.UnsetSession();
            Q8.AdvancedSearch.UnsetSession();
            Q9.AdvancedSearch.UnsetSession();
            Q10.AdvancedSearch.UnsetSession();
            Q11.AdvancedSearch.UnsetSession();
            Q12.AdvancedSearch.UnsetSession();
            Q13.AdvancedSearch.UnsetSession();
            Q14.AdvancedSearch.UnsetSession();
            Q15.AdvancedSearch.UnsetSession();
            Section_3.AdvancedSearch.UnsetSession();
            Q16.AdvancedSearch.UnsetSession();
            Q17.AdvancedSearch.UnsetSession();
            Q18.AdvancedSearch.UnsetSession();
            Q19.AdvancedSearch.UnsetSession();
            Q20.AdvancedSearch.UnsetSession();
            Q21.AdvancedSearch.UnsetSession();
            Section_4.AdvancedSearch.UnsetSession();
            Q22.AdvancedSearch.UnsetSession();
            Q23.AdvancedSearch.UnsetSession();
            Q24.AdvancedSearch.UnsetSession();
            Q25.AdvancedSearch.UnsetSession();
            Q26.AdvancedSearch.UnsetSession();
            Section_5.AdvancedSearch.UnsetSession();
            Q27.AdvancedSearch.UnsetSession();
            Q28.AdvancedSearch.UnsetSession();
            Q29.AdvancedSearch.UnsetSession();
            Q30.AdvancedSearch.UnsetSession();
            Q31.AdvancedSearch.UnsetSession();
            Q32.AdvancedSearch.UnsetSession();
            Q33.AdvancedSearch.UnsetSession();
            Q34.AdvancedSearch.UnsetSession();
            Q35.AdvancedSearch.UnsetSession();
            Section_6.AdvancedSearch.UnsetSession();
            Q36.AdvancedSearch.UnsetSession();
            Q37.AdvancedSearch.UnsetSession();
            Q38.AdvancedSearch.UnsetSession();
            Q39.AdvancedSearch.UnsetSession();
            Q40.AdvancedSearch.UnsetSession();
            Q41.AdvancedSearch.UnsetSession();
            Q42.AdvancedSearch.UnsetSession();
            Q43.AdvancedSearch.UnsetSession();
            Section_7.AdvancedSearch.UnsetSession();
            Q44.AdvancedSearch.UnsetSession();
            Q45.AdvancedSearch.UnsetSession();
            Q46.AdvancedSearch.UnsetSession();
            Q47.AdvancedSearch.UnsetSession();
            Q48.AdvancedSearch.UnsetSession();
            Q49.AdvancedSearch.UnsetSession();
            Q50.AdvancedSearch.UnsetSession();
            Section_8.AdvancedSearch.UnsetSession();
            Q51.AdvancedSearch.UnsetSession();
            Q52.AdvancedSearch.UnsetSession();
            Q53.AdvancedSearch.UnsetSession();
            Q54.AdvancedSearch.UnsetSession();
            Q55.AdvancedSearch.UnsetSession();
            Section_9.AdvancedSearch.UnsetSession();
            Q56.AdvancedSearch.UnsetSession();
            Q57.AdvancedSearch.UnsetSession();
            Q58.AdvancedSearch.UnsetSession();
            Q59.AdvancedSearch.UnsetSession();
            Section_10.AdvancedSearch.UnsetSession();
            Q60.AdvancedSearch.UnsetSession();
            Q61.AdvancedSearch.UnsetSession();
            Q62.AdvancedSearch.UnsetSession();
            Q63.AdvancedSearch.UnsetSession();
            Q64.AdvancedSearch.UnsetSession();
            Q65.AdvancedSearch.UnsetSession();
            Section_11.AdvancedSearch.UnsetSession();
            Q66.AdvancedSearch.UnsetSession();
            Q67.AdvancedSearch.UnsetSession();
            Q68.AdvancedSearch.UnsetSession();
            Q69.AdvancedSearch.UnsetSession();
            Q70.AdvancedSearch.UnsetSession();
            Notes_3.AdvancedSearch.UnsetSession();
            Examiner_Signature.AdvancedSearch.UnsetSession();
            Student_Signature.AdvancedSearch.UnsetSession();
            AbsherApptNbr.AdvancedSearch.UnsetSession();
            IsDrivingexperience.AdvancedSearch.UnsetSession();
            date_Birth_Hijri.AdvancedSearch.UnsetSession();
            date_Birth.AdvancedSearch.UnsetSession();
            str_Email.AdvancedSearch.UnsetSession();
            UserlevelID.AdvancedSearch.UnsetSession();
            DriveTypelink.AdvancedSearch.UnsetSession();
            intEvaluationType.AdvancedSearch.UnsetSession();
            Institution.AdvancedSearch.UnsetSession();
            Scores_S1.AdvancedSearch.UnsetSession();
            S1.AdvancedSearch.UnsetSession();
            S2.AdvancedSearch.UnsetSession();
            S3.AdvancedSearch.UnsetSession();
            S4.AdvancedSearch.UnsetSession();
            S5.AdvancedSearch.UnsetSession();
            Scores_S2.AdvancedSearch.UnsetSession();
            S6.AdvancedSearch.UnsetSession();
            S7.AdvancedSearch.UnsetSession();
            S8.AdvancedSearch.UnsetSession();
            S9.AdvancedSearch.UnsetSession();
            S10.AdvancedSearch.UnsetSession();
            S11.AdvancedSearch.UnsetSession();
            S12.AdvancedSearch.UnsetSession();
            S13.AdvancedSearch.UnsetSession();
            S14.AdvancedSearch.UnsetSession();
            S15.AdvancedSearch.UnsetSession();
            Scores_S3.AdvancedSearch.UnsetSession();
            S16.AdvancedSearch.UnsetSession();
            S17.AdvancedSearch.UnsetSession();
            S18.AdvancedSearch.UnsetSession();
            S19.AdvancedSearch.UnsetSession();
            S20.AdvancedSearch.UnsetSession();
            S21.AdvancedSearch.UnsetSession();
            Scores_S4.AdvancedSearch.UnsetSession();
            S22.AdvancedSearch.UnsetSession();
            S23.AdvancedSearch.UnsetSession();
            S24.AdvancedSearch.UnsetSession();
            S25.AdvancedSearch.UnsetSession();
            S26.AdvancedSearch.UnsetSession();
            Scores_S5.AdvancedSearch.UnsetSession();
            S27.AdvancedSearch.UnsetSession();
            S28.AdvancedSearch.UnsetSession();
            S29.AdvancedSearch.UnsetSession();
            S30.AdvancedSearch.UnsetSession();
            S31.AdvancedSearch.UnsetSession();
            S32.AdvancedSearch.UnsetSession();
            S33.AdvancedSearch.UnsetSession();
            S34.AdvancedSearch.UnsetSession();
            S35.AdvancedSearch.UnsetSession();
            Scores_S6.AdvancedSearch.UnsetSession();
            S36.AdvancedSearch.UnsetSession();
            S37.AdvancedSearch.UnsetSession();
            S38.AdvancedSearch.UnsetSession();
            S39.AdvancedSearch.UnsetSession();
            S40.AdvancedSearch.UnsetSession();
            S41.AdvancedSearch.UnsetSession();
            S42.AdvancedSearch.UnsetSession();
            S43.AdvancedSearch.UnsetSession();
            Scores_S7.AdvancedSearch.UnsetSession();
            S44.AdvancedSearch.UnsetSession();
            S45.AdvancedSearch.UnsetSession();
            S46.AdvancedSearch.UnsetSession();
            S47.AdvancedSearch.UnsetSession();
            S48.AdvancedSearch.UnsetSession();
            S49.AdvancedSearch.UnsetSession();
            S50.AdvancedSearch.UnsetSession();
            Scores_S8.AdvancedSearch.UnsetSession();
            S51.AdvancedSearch.UnsetSession();
            S52.AdvancedSearch.UnsetSession();
            S53.AdvancedSearch.UnsetSession();
            S54.AdvancedSearch.UnsetSession();
            S55.AdvancedSearch.UnsetSession();
            Scores_S9.AdvancedSearch.UnsetSession();
            S56.AdvancedSearch.UnsetSession();
            S57.AdvancedSearch.UnsetSession();
            S58.AdvancedSearch.UnsetSession();
            S59.AdvancedSearch.UnsetSession();
            Scores_S10.AdvancedSearch.UnsetSession();
            S60.AdvancedSearch.UnsetSession();
            S61.AdvancedSearch.UnsetSession();
            S62.AdvancedSearch.UnsetSession();
            S63.AdvancedSearch.UnsetSession();
            S64.AdvancedSearch.UnsetSession();
            S65.AdvancedSearch.UnsetSession();
            Scores_S11.AdvancedSearch.UnsetSession();
            S66.AdvancedSearch.UnsetSession();
            S67.AdvancedSearch.UnsetSession();
            S68.AdvancedSearch.UnsetSession();
            S69.AdvancedSearch.UnsetSession();
            S70.AdvancedSearch.UnsetSession();
            Evaluation_Score.AdvancedSearch.UnsetSession();
            Immediate_Failure_Score.AdvancedSearch.UnsetSession();
            Required_Program.AdvancedSearch.UnsetSession();
            Price.AdvancedSearch.UnsetSession();
        }

        // Restore all search parameters
        protected void RestoreSearchParms() {
            RestoreSearch = true;

            // Restore basic search values
            BasicSearch.Load();

            // Restore advanced search values
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
                UpdateSort(str_Full_Name_Hdr, ctrl); // str_Full_Name_Hdr
                UpdateSort(NationalID, ctrl); // NationalID
                UpdateSort(str_Cell_Phone, ctrl); // str_Cell_Phone
                UpdateSort(intDrivinglicenseType, ctrl); // intDrivinglicenseType
                UpdateSort(Retake, ctrl); // Retake
                UpdateSort(AbsherApptNbr, ctrl); // AbsherApptNbr
                UpdateSort(IsDrivingexperience, ctrl); // IsDrivingexperience
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
                    Eval_ID.Sort = "";
                    int_Student_ID.Sort = "";
                    AssessmentID.Sort = "";
                    str_Full_Name_Hdr.Sort = "";
                    NationalID.Sort = "";
                    str_Cell_Phone.Sort = "";
                    str_Username.Sort = "";
                    intDrivinglicenseType.Sort = "";
                    Date_Entered.Sort = "";
                    Examination_Number.Sort = "";
                    Retake.Sort = "";
                    Section_1.Sort = "";
                    Q1.Sort = "";
                    Q2.Sort = "";
                    Q3.Sort = "";
                    Q4.Sort = "";
                    Q5.Sort = "";
                    Section_2.Sort = "";
                    Q6.Sort = "";
                    Q7.Sort = "";
                    Q8.Sort = "";
                    Q9.Sort = "";
                    Q10.Sort = "";
                    Q11.Sort = "";
                    Q12.Sort = "";
                    Q13.Sort = "";
                    Q14.Sort = "";
                    Q15.Sort = "";
                    Section_3.Sort = "";
                    Q16.Sort = "";
                    Q17.Sort = "";
                    Q18.Sort = "";
                    Q19.Sort = "";
                    Q20.Sort = "";
                    Q21.Sort = "";
                    Section_4.Sort = "";
                    Q22.Sort = "";
                    Q23.Sort = "";
                    Q24.Sort = "";
                    Q25.Sort = "";
                    Q26.Sort = "";
                    Section_5.Sort = "";
                    Q27.Sort = "";
                    Q28.Sort = "";
                    Q29.Sort = "";
                    Q30.Sort = "";
                    Q31.Sort = "";
                    Q32.Sort = "";
                    Q33.Sort = "";
                    Q34.Sort = "";
                    Q35.Sort = "";
                    Section_6.Sort = "";
                    Q36.Sort = "";
                    Q37.Sort = "";
                    Q38.Sort = "";
                    Q39.Sort = "";
                    Q40.Sort = "";
                    Q41.Sort = "";
                    Q42.Sort = "";
                    Q43.Sort = "";
                    Section_7.Sort = "";
                    Q44.Sort = "";
                    Q45.Sort = "";
                    Q46.Sort = "";
                    Q47.Sort = "";
                    Q48.Sort = "";
                    Q49.Sort = "";
                    Q50.Sort = "";
                    Section_8.Sort = "";
                    Q51.Sort = "";
                    Q52.Sort = "";
                    Q53.Sort = "";
                    Q54.Sort = "";
                    Q55.Sort = "";
                    Section_9.Sort = "";
                    Q56.Sort = "";
                    Q57.Sort = "";
                    Q58.Sort = "";
                    Q59.Sort = "";
                    Section_10.Sort = "";
                    Q60.Sort = "";
                    Q61.Sort = "";
                    Q62.Sort = "";
                    Q63.Sort = "";
                    Q64.Sort = "";
                    Q65.Sort = "";
                    Section_11.Sort = "";
                    Q66.Sort = "";
                    Q67.Sort = "";
                    Q68.Sort = "";
                    Q69.Sort = "";
                    Q70.Sort = "";
                    Notes_3.Sort = "";
                    Examiner_Signature.Sort = "";
                    Student_Signature.Sort = "";
                    AbsherApptNbr.Sort = "";
                    IsDrivingexperience.Sort = "";
                    date_Birth_Hijri.Sort = "";
                    date_Birth.Sort = "";
                    str_Email.Sort = "";
                    UserlevelID.Sort = "";
                    DriveTypelink.Sort = "";
                    intEvaluationType.Sort = "";
                    Institution.Sort = "";
                    Scores_S1.Sort = "";
                    S1.Sort = "";
                    S2.Sort = "";
                    S3.Sort = "";
                    S4.Sort = "";
                    S5.Sort = "";
                    Scores_S2.Sort = "";
                    S6.Sort = "";
                    S7.Sort = "";
                    S8.Sort = "";
                    S9.Sort = "";
                    S10.Sort = "";
                    S11.Sort = "";
                    S12.Sort = "";
                    S13.Sort = "";
                    S14.Sort = "";
                    S15.Sort = "";
                    Scores_S3.Sort = "";
                    S16.Sort = "";
                    S17.Sort = "";
                    S18.Sort = "";
                    S19.Sort = "";
                    S20.Sort = "";
                    S21.Sort = "";
                    Scores_S4.Sort = "";
                    S22.Sort = "";
                    S23.Sort = "";
                    S24.Sort = "";
                    S25.Sort = "";
                    S26.Sort = "";
                    Scores_S5.Sort = "";
                    S27.Sort = "";
                    S28.Sort = "";
                    S29.Sort = "";
                    S30.Sort = "";
                    S31.Sort = "";
                    S32.Sort = "";
                    S33.Sort = "";
                    S34.Sort = "";
                    S35.Sort = "";
                    Scores_S6.Sort = "";
                    S36.Sort = "";
                    S37.Sort = "";
                    S38.Sort = "";
                    S39.Sort = "";
                    S40.Sort = "";
                    S41.Sort = "";
                    S42.Sort = "";
                    S43.Sort = "";
                    Scores_S7.Sort = "";
                    S44.Sort = "";
                    S45.Sort = "";
                    S46.Sort = "";
                    S47.Sort = "";
                    S48.Sort = "";
                    S49.Sort = "";
                    S50.Sort = "";
                    Scores_S8.Sort = "";
                    S51.Sort = "";
                    S52.Sort = "";
                    S53.Sort = "";
                    S54.Sort = "";
                    S55.Sort = "";
                    Scores_S9.Sort = "";
                    S56.Sort = "";
                    S57.Sort = "";
                    S58.Sort = "";
                    S59.Sort = "";
                    Scores_S10.Sort = "";
                    S60.Sort = "";
                    S61.Sort = "";
                    S62.Sort = "";
                    S63.Sort = "";
                    S64.Sort = "";
                    S65.Sort = "";
                    Scores_S11.Sort = "";
                    S66.Sort = "";
                    S67.Sort = "";
                    S68.Sort = "";
                    S69.Sort = "";
                    S70.Sort = "";
                    Evaluation_Score.Sort = "";
                    Immediate_Failure_Score.Sort = "";
                    Required_Program.Sort = "";
                    Price.Sort = "";
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
            item.Visible = false;
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
                        string link = "<li><button type=\"button\" class=\"dropdown-item ew-action ew-list-action\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblEvaluationMBlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + " " + caption + "</button></li>";
                        if (!Empty(link)) {
                            links.Add(link);
                            if (Empty(body)) // Setup first button
                                body = "<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlTitle(caption) + "\" data-caption=\"" + HtmlTitle(caption) + "\" data-ew-action=\"submit\" form=\"ftblEvaluationMBlist\" data-key=\"" + KeyToJson(true) + "\"" + act.ToDataAttrs() + ">" + icon + caption + "</button>";
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

            // "checkbox"
            listOption = ListOptions["checkbox"];
            listOption?.SetBody("<div class=\"form-check\"><input type=\"checkbox\" id=\"key_m_" + RowCount + "\" name=\"key_m[]\" class=\"form-check-input ew-multi-select\" value=\"" + HtmlEncode(Eval_ID.CurrentValue) + "\"></div>");
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
            var options = OtherOptions;
            option = options["action"];

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
            item.Body = "<div class=\"btn-group\"><div class=\"form-check\"><input type=\"checkbox\" name=\"key\" id=\"key\" class=\"form-check-input\" data-ew-action=\"select-all-keys\" form=\"ftblEvaluationMBlist\"><label class=\"form-check-label\" for=\"key\">" + Language.Phrase("SelectAll") + "</label></div></div>";
            item.ShowInButtonGroup = true;
            item.Visible = false && MultiColumnLayout == "cards";
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
            item.Body = "<a class=\"ew-save-filter\" data-form=\"ftblEvaluationMBsrch\" data-ew-action=\"none\">" + Language.Phrase("SaveCurrentFilter") + "</a>";
            item.Visible = true;
            item = FilterOptions.Add("deletefilter");
            item.Body = "<a class=\"ew-delete-filter\" data-form=\"ftblEvaluationMBsrch\" data-ew-action=\"none\">" + Language.Phrase("DeleteFilter") + "</a>";
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
                    item.Body = "<<button type=\"button\" class=\"btn btn-default ew-action ew-list-action\" title=\"" + HtmlEncode(caption) + "\" data-caption=\"" + HtmlEncode(caption) + "\" data-ew-action=\"submit\" form=\"ftblEvaluationMBlist\"" + act.ToDataAttrs() + ">" + icon + "</button>";
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
                        processed = RowCustomAction(userAction, row);
                        if (!processed)
                            break;
                    }
                    if (processed) {
                        if (UseTransaction)
                            Connection.CommitTrans(); // Commit the changes
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("CustomActionCompleted").Replace("%s", actionCaption); // Set up success message
                    } else {
                        if (UseTransaction)
                            Connection.RollbackTrans(); // Rollback changes

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
            RowAttrs.Add("data-rowindex", ConvertToString(tblEvaluationMbList.RowCount));
            RowAttrs.Add("data-key", GetKey(true));
            RowAttrs.Add("id", "r" + ConvertToString(tblEvaluationMbList.RowCount) + "_tblEvaluationMB");
            RowAttrs.Add("data-rowtype", ConvertToString((int)RowType));
            RowAttrs.AppendClass(tblEvaluationMbList.RowCount % 2 != 1 ? "ew-table-alt-row" : "");
            if (IsAdd && tblEvaluationMbList.RowType == RowType.Add || IsEdit && tblEvaluationMbList.RowType == RowType.Edit) // Inline-Add/Edit row
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

            // Eval_ID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Eval_ID"))
                    Eval_ID.AdvancedSearch.SearchValue = Get("x_Eval_ID");
                else
                    Eval_ID.AdvancedSearch.SearchValue = Get("Eval_ID"); // Default Value // DN
            if (!Empty(Eval_ID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Eval_ID"))
                Eval_ID.AdvancedSearch.SearchOperator = Get("z_Eval_ID");

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

            // AssessmentID
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AssessmentID"))
                    AssessmentID.AdvancedSearch.SearchValue = Get("x_AssessmentID");
                else
                    AssessmentID.AdvancedSearch.SearchValue = Get("AssessmentID"); // Default Value // DN
            if (!Empty(AssessmentID.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AssessmentID"))
                AssessmentID.AdvancedSearch.SearchOperator = Get("z_AssessmentID");

            // str_Full_Name_Hdr
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_str_Full_Name_Hdr"))
                    str_Full_Name_Hdr.AdvancedSearch.SearchValue = Get("x_str_Full_Name_Hdr");
                else
                    str_Full_Name_Hdr.AdvancedSearch.SearchValue = Get("str_Full_Name_Hdr"); // Default Value // DN
            if (!Empty(str_Full_Name_Hdr.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_str_Full_Name_Hdr"))
                str_Full_Name_Hdr.AdvancedSearch.SearchOperator = Get("z_str_Full_Name_Hdr");

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

            // intDrivinglicenseType
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_intDrivinglicenseType"))
                    intDrivinglicenseType.AdvancedSearch.SearchValue = Get("x_intDrivinglicenseType");
                else
                    intDrivinglicenseType.AdvancedSearch.SearchValue = Get("intDrivinglicenseType"); // Default Value // DN
            if (!Empty(intDrivinglicenseType.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchOperator = Get("z_intDrivinglicenseType");

            // Date_Entered
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Date_Entered"))
                    Date_Entered.AdvancedSearch.SearchValue = Get("x_Date_Entered");
                else
                    Date_Entered.AdvancedSearch.SearchValue = Get("Date_Entered"); // Default Value // DN
            if (!Empty(Date_Entered.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Date_Entered"))
                Date_Entered.AdvancedSearch.SearchOperator = Get("z_Date_Entered");

            // Examination_Number
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Examination_Number"))
                    Examination_Number.AdvancedSearch.SearchValue = Get("x_Examination_Number");
                else
                    Examination_Number.AdvancedSearch.SearchValue = Get("Examination_Number"); // Default Value // DN
            if (!Empty(Examination_Number.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Examination_Number"))
                Examination_Number.AdvancedSearch.SearchOperator = Get("z_Examination_Number");

            // Retake
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Retake[]"))
                    Retake.AdvancedSearch.SearchValue = Get("x_Retake[]");
                else
                    Retake.AdvancedSearch.SearchValue = Get("Retake"); // Default Value // DN
            if (!Empty(Retake.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Retake"))
                Retake.AdvancedSearch.SearchOperator = Get("z_Retake");

            // Section_1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_1"))
                    Section_1.AdvancedSearch.SearchValue = Get("x_Section_1");
                else
                    Section_1.AdvancedSearch.SearchValue = Get("Section_1"); // Default Value // DN
            if (!Empty(Section_1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_1"))
                Section_1.AdvancedSearch.SearchOperator = Get("z_Section_1");

            // Q1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q1"))
                    Q1.AdvancedSearch.SearchValue = Get("x_Q1");
                else
                    Q1.AdvancedSearch.SearchValue = Get("Q1"); // Default Value // DN
            if (!Empty(Q1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q1"))
                Q1.AdvancedSearch.SearchOperator = Get("z_Q1");

            // Q2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q2"))
                    Q2.AdvancedSearch.SearchValue = Get("x_Q2");
                else
                    Q2.AdvancedSearch.SearchValue = Get("Q2"); // Default Value // DN
            if (!Empty(Q2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q2"))
                Q2.AdvancedSearch.SearchOperator = Get("z_Q2");

            // Q3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q3"))
                    Q3.AdvancedSearch.SearchValue = Get("x_Q3");
                else
                    Q3.AdvancedSearch.SearchValue = Get("Q3"); // Default Value // DN
            if (!Empty(Q3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q3"))
                Q3.AdvancedSearch.SearchOperator = Get("z_Q3");

            // Q4
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q4"))
                    Q4.AdvancedSearch.SearchValue = Get("x_Q4");
                else
                    Q4.AdvancedSearch.SearchValue = Get("Q4"); // Default Value // DN
            if (!Empty(Q4.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q4"))
                Q4.AdvancedSearch.SearchOperator = Get("z_Q4");

            // Q5
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q5"))
                    Q5.AdvancedSearch.SearchValue = Get("x_Q5");
                else
                    Q5.AdvancedSearch.SearchValue = Get("Q5"); // Default Value // DN
            if (!Empty(Q5.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q5"))
                Q5.AdvancedSearch.SearchOperator = Get("z_Q5");

            // Section_2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_2"))
                    Section_2.AdvancedSearch.SearchValue = Get("x_Section_2");
                else
                    Section_2.AdvancedSearch.SearchValue = Get("Section_2"); // Default Value // DN
            if (!Empty(Section_2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_2"))
                Section_2.AdvancedSearch.SearchOperator = Get("z_Section_2");

            // Q6
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q6"))
                    Q6.AdvancedSearch.SearchValue = Get("x_Q6");
                else
                    Q6.AdvancedSearch.SearchValue = Get("Q6"); // Default Value // DN
            if (!Empty(Q6.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q6"))
                Q6.AdvancedSearch.SearchOperator = Get("z_Q6");

            // Q7
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q7"))
                    Q7.AdvancedSearch.SearchValue = Get("x_Q7");
                else
                    Q7.AdvancedSearch.SearchValue = Get("Q7"); // Default Value // DN
            if (!Empty(Q7.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q7"))
                Q7.AdvancedSearch.SearchOperator = Get("z_Q7");

            // Q8
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q8"))
                    Q8.AdvancedSearch.SearchValue = Get("x_Q8");
                else
                    Q8.AdvancedSearch.SearchValue = Get("Q8"); // Default Value // DN
            if (!Empty(Q8.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q8"))
                Q8.AdvancedSearch.SearchOperator = Get("z_Q8");

            // Q9
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q9"))
                    Q9.AdvancedSearch.SearchValue = Get("x_Q9");
                else
                    Q9.AdvancedSearch.SearchValue = Get("Q9"); // Default Value // DN
            if (!Empty(Q9.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q9"))
                Q9.AdvancedSearch.SearchOperator = Get("z_Q9");

            // Q10
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q10"))
                    Q10.AdvancedSearch.SearchValue = Get("x_Q10");
                else
                    Q10.AdvancedSearch.SearchValue = Get("Q10"); // Default Value // DN
            if (!Empty(Q10.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q10"))
                Q10.AdvancedSearch.SearchOperator = Get("z_Q10");

            // Q11
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q11"))
                    Q11.AdvancedSearch.SearchValue = Get("x_Q11");
                else
                    Q11.AdvancedSearch.SearchValue = Get("Q11"); // Default Value // DN
            if (!Empty(Q11.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q11"))
                Q11.AdvancedSearch.SearchOperator = Get("z_Q11");

            // Q12
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q12"))
                    Q12.AdvancedSearch.SearchValue = Get("x_Q12");
                else
                    Q12.AdvancedSearch.SearchValue = Get("Q12"); // Default Value // DN
            if (!Empty(Q12.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q12"))
                Q12.AdvancedSearch.SearchOperator = Get("z_Q12");

            // Q13
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q13"))
                    Q13.AdvancedSearch.SearchValue = Get("x_Q13");
                else
                    Q13.AdvancedSearch.SearchValue = Get("Q13"); // Default Value // DN
            if (!Empty(Q13.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q13"))
                Q13.AdvancedSearch.SearchOperator = Get("z_Q13");

            // Q14
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q14"))
                    Q14.AdvancedSearch.SearchValue = Get("x_Q14");
                else
                    Q14.AdvancedSearch.SearchValue = Get("Q14"); // Default Value // DN
            if (!Empty(Q14.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q14"))
                Q14.AdvancedSearch.SearchOperator = Get("z_Q14");

            // Q15
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q15"))
                    Q15.AdvancedSearch.SearchValue = Get("x_Q15");
                else
                    Q15.AdvancedSearch.SearchValue = Get("Q15"); // Default Value // DN
            if (!Empty(Q15.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q15"))
                Q15.AdvancedSearch.SearchOperator = Get("z_Q15");

            // Section_3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_3"))
                    Section_3.AdvancedSearch.SearchValue = Get("x_Section_3");
                else
                    Section_3.AdvancedSearch.SearchValue = Get("Section_3"); // Default Value // DN
            if (!Empty(Section_3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_3"))
                Section_3.AdvancedSearch.SearchOperator = Get("z_Section_3");

            // Q16
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q16"))
                    Q16.AdvancedSearch.SearchValue = Get("x_Q16");
                else
                    Q16.AdvancedSearch.SearchValue = Get("Q16"); // Default Value // DN
            if (!Empty(Q16.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q16"))
                Q16.AdvancedSearch.SearchOperator = Get("z_Q16");

            // Q17
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q17"))
                    Q17.AdvancedSearch.SearchValue = Get("x_Q17");
                else
                    Q17.AdvancedSearch.SearchValue = Get("Q17"); // Default Value // DN
            if (!Empty(Q17.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q17"))
                Q17.AdvancedSearch.SearchOperator = Get("z_Q17");

            // Q18
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q18"))
                    Q18.AdvancedSearch.SearchValue = Get("x_Q18");
                else
                    Q18.AdvancedSearch.SearchValue = Get("Q18"); // Default Value // DN
            if (!Empty(Q18.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q18"))
                Q18.AdvancedSearch.SearchOperator = Get("z_Q18");

            // Q19
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q19"))
                    Q19.AdvancedSearch.SearchValue = Get("x_Q19");
                else
                    Q19.AdvancedSearch.SearchValue = Get("Q19"); // Default Value // DN
            if (!Empty(Q19.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q19"))
                Q19.AdvancedSearch.SearchOperator = Get("z_Q19");

            // Q20
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q20"))
                    Q20.AdvancedSearch.SearchValue = Get("x_Q20");
                else
                    Q20.AdvancedSearch.SearchValue = Get("Q20"); // Default Value // DN
            if (!Empty(Q20.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q20"))
                Q20.AdvancedSearch.SearchOperator = Get("z_Q20");

            // Q21
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q21"))
                    Q21.AdvancedSearch.SearchValue = Get("x_Q21");
                else
                    Q21.AdvancedSearch.SearchValue = Get("Q21"); // Default Value // DN
            if (!Empty(Q21.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q21"))
                Q21.AdvancedSearch.SearchOperator = Get("z_Q21");

            // Section_4
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_4"))
                    Section_4.AdvancedSearch.SearchValue = Get("x_Section_4");
                else
                    Section_4.AdvancedSearch.SearchValue = Get("Section_4"); // Default Value // DN
            if (!Empty(Section_4.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_4"))
                Section_4.AdvancedSearch.SearchOperator = Get("z_Section_4");

            // Q22
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q22"))
                    Q22.AdvancedSearch.SearchValue = Get("x_Q22");
                else
                    Q22.AdvancedSearch.SearchValue = Get("Q22"); // Default Value // DN
            if (!Empty(Q22.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q22"))
                Q22.AdvancedSearch.SearchOperator = Get("z_Q22");

            // Q23
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q23"))
                    Q23.AdvancedSearch.SearchValue = Get("x_Q23");
                else
                    Q23.AdvancedSearch.SearchValue = Get("Q23"); // Default Value // DN
            if (!Empty(Q23.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q23"))
                Q23.AdvancedSearch.SearchOperator = Get("z_Q23");

            // Q24
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q24"))
                    Q24.AdvancedSearch.SearchValue = Get("x_Q24");
                else
                    Q24.AdvancedSearch.SearchValue = Get("Q24"); // Default Value // DN
            if (!Empty(Q24.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q24"))
                Q24.AdvancedSearch.SearchOperator = Get("z_Q24");

            // Q25
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q25"))
                    Q25.AdvancedSearch.SearchValue = Get("x_Q25");
                else
                    Q25.AdvancedSearch.SearchValue = Get("Q25"); // Default Value // DN
            if (!Empty(Q25.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q25"))
                Q25.AdvancedSearch.SearchOperator = Get("z_Q25");

            // Q26
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q26"))
                    Q26.AdvancedSearch.SearchValue = Get("x_Q26");
                else
                    Q26.AdvancedSearch.SearchValue = Get("Q26"); // Default Value // DN
            if (!Empty(Q26.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q26"))
                Q26.AdvancedSearch.SearchOperator = Get("z_Q26");

            // Section_5
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_5"))
                    Section_5.AdvancedSearch.SearchValue = Get("x_Section_5");
                else
                    Section_5.AdvancedSearch.SearchValue = Get("Section_5"); // Default Value // DN
            if (!Empty(Section_5.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_5"))
                Section_5.AdvancedSearch.SearchOperator = Get("z_Section_5");

            // Q27
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q27"))
                    Q27.AdvancedSearch.SearchValue = Get("x_Q27");
                else
                    Q27.AdvancedSearch.SearchValue = Get("Q27"); // Default Value // DN
            if (!Empty(Q27.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q27"))
                Q27.AdvancedSearch.SearchOperator = Get("z_Q27");

            // Q28
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q28"))
                    Q28.AdvancedSearch.SearchValue = Get("x_Q28");
                else
                    Q28.AdvancedSearch.SearchValue = Get("Q28"); // Default Value // DN
            if (!Empty(Q28.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q28"))
                Q28.AdvancedSearch.SearchOperator = Get("z_Q28");

            // Q29
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q29"))
                    Q29.AdvancedSearch.SearchValue = Get("x_Q29");
                else
                    Q29.AdvancedSearch.SearchValue = Get("Q29"); // Default Value // DN
            if (!Empty(Q29.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q29"))
                Q29.AdvancedSearch.SearchOperator = Get("z_Q29");

            // Q30
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q30"))
                    Q30.AdvancedSearch.SearchValue = Get("x_Q30");
                else
                    Q30.AdvancedSearch.SearchValue = Get("Q30"); // Default Value // DN
            if (!Empty(Q30.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q30"))
                Q30.AdvancedSearch.SearchOperator = Get("z_Q30");

            // Q31
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q31"))
                    Q31.AdvancedSearch.SearchValue = Get("x_Q31");
                else
                    Q31.AdvancedSearch.SearchValue = Get("Q31"); // Default Value // DN
            if (!Empty(Q31.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q31"))
                Q31.AdvancedSearch.SearchOperator = Get("z_Q31");

            // Q32
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q32"))
                    Q32.AdvancedSearch.SearchValue = Get("x_Q32");
                else
                    Q32.AdvancedSearch.SearchValue = Get("Q32"); // Default Value // DN
            if (!Empty(Q32.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q32"))
                Q32.AdvancedSearch.SearchOperator = Get("z_Q32");

            // Q33
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q33"))
                    Q33.AdvancedSearch.SearchValue = Get("x_Q33");
                else
                    Q33.AdvancedSearch.SearchValue = Get("Q33"); // Default Value // DN
            if (!Empty(Q33.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q33"))
                Q33.AdvancedSearch.SearchOperator = Get("z_Q33");

            // Q34
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q34"))
                    Q34.AdvancedSearch.SearchValue = Get("x_Q34");
                else
                    Q34.AdvancedSearch.SearchValue = Get("Q34"); // Default Value // DN
            if (!Empty(Q34.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q34"))
                Q34.AdvancedSearch.SearchOperator = Get("z_Q34");

            // Q35
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q35"))
                    Q35.AdvancedSearch.SearchValue = Get("x_Q35");
                else
                    Q35.AdvancedSearch.SearchValue = Get("Q35"); // Default Value // DN
            if (!Empty(Q35.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q35"))
                Q35.AdvancedSearch.SearchOperator = Get("z_Q35");

            // Section_6
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_6"))
                    Section_6.AdvancedSearch.SearchValue = Get("x_Section_6");
                else
                    Section_6.AdvancedSearch.SearchValue = Get("Section_6"); // Default Value // DN
            if (!Empty(Section_6.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_6"))
                Section_6.AdvancedSearch.SearchOperator = Get("z_Section_6");

            // Q36
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q36"))
                    Q36.AdvancedSearch.SearchValue = Get("x_Q36");
                else
                    Q36.AdvancedSearch.SearchValue = Get("Q36"); // Default Value // DN
            if (!Empty(Q36.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q36"))
                Q36.AdvancedSearch.SearchOperator = Get("z_Q36");

            // Q37
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q37"))
                    Q37.AdvancedSearch.SearchValue = Get("x_Q37");
                else
                    Q37.AdvancedSearch.SearchValue = Get("Q37"); // Default Value // DN
            if (!Empty(Q37.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q37"))
                Q37.AdvancedSearch.SearchOperator = Get("z_Q37");

            // Q38
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q38"))
                    Q38.AdvancedSearch.SearchValue = Get("x_Q38");
                else
                    Q38.AdvancedSearch.SearchValue = Get("Q38"); // Default Value // DN
            if (!Empty(Q38.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q38"))
                Q38.AdvancedSearch.SearchOperator = Get("z_Q38");

            // Q39
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q39"))
                    Q39.AdvancedSearch.SearchValue = Get("x_Q39");
                else
                    Q39.AdvancedSearch.SearchValue = Get("Q39"); // Default Value // DN
            if (!Empty(Q39.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q39"))
                Q39.AdvancedSearch.SearchOperator = Get("z_Q39");

            // Q40
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q40"))
                    Q40.AdvancedSearch.SearchValue = Get("x_Q40");
                else
                    Q40.AdvancedSearch.SearchValue = Get("Q40"); // Default Value // DN
            if (!Empty(Q40.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q40"))
                Q40.AdvancedSearch.SearchOperator = Get("z_Q40");

            // Q41
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q41"))
                    Q41.AdvancedSearch.SearchValue = Get("x_Q41");
                else
                    Q41.AdvancedSearch.SearchValue = Get("Q41"); // Default Value // DN
            if (!Empty(Q41.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q41"))
                Q41.AdvancedSearch.SearchOperator = Get("z_Q41");

            // Q42
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q42"))
                    Q42.AdvancedSearch.SearchValue = Get("x_Q42");
                else
                    Q42.AdvancedSearch.SearchValue = Get("Q42"); // Default Value // DN
            if (!Empty(Q42.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q42"))
                Q42.AdvancedSearch.SearchOperator = Get("z_Q42");

            // Q43
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q43"))
                    Q43.AdvancedSearch.SearchValue = Get("x_Q43");
                else
                    Q43.AdvancedSearch.SearchValue = Get("Q43"); // Default Value // DN
            if (!Empty(Q43.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q43"))
                Q43.AdvancedSearch.SearchOperator = Get("z_Q43");

            // Section_7
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_7"))
                    Section_7.AdvancedSearch.SearchValue = Get("x_Section_7");
                else
                    Section_7.AdvancedSearch.SearchValue = Get("Section_7"); // Default Value // DN
            if (!Empty(Section_7.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_7"))
                Section_7.AdvancedSearch.SearchOperator = Get("z_Section_7");

            // Q44
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q44"))
                    Q44.AdvancedSearch.SearchValue = Get("x_Q44");
                else
                    Q44.AdvancedSearch.SearchValue = Get("Q44"); // Default Value // DN
            if (!Empty(Q44.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q44"))
                Q44.AdvancedSearch.SearchOperator = Get("z_Q44");

            // Q45
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q45"))
                    Q45.AdvancedSearch.SearchValue = Get("x_Q45");
                else
                    Q45.AdvancedSearch.SearchValue = Get("Q45"); // Default Value // DN
            if (!Empty(Q45.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q45"))
                Q45.AdvancedSearch.SearchOperator = Get("z_Q45");

            // Q46
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q46"))
                    Q46.AdvancedSearch.SearchValue = Get("x_Q46");
                else
                    Q46.AdvancedSearch.SearchValue = Get("Q46"); // Default Value // DN
            if (!Empty(Q46.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q46"))
                Q46.AdvancedSearch.SearchOperator = Get("z_Q46");

            // Q47
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q47"))
                    Q47.AdvancedSearch.SearchValue = Get("x_Q47");
                else
                    Q47.AdvancedSearch.SearchValue = Get("Q47"); // Default Value // DN
            if (!Empty(Q47.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q47"))
                Q47.AdvancedSearch.SearchOperator = Get("z_Q47");

            // Q48
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q48"))
                    Q48.AdvancedSearch.SearchValue = Get("x_Q48");
                else
                    Q48.AdvancedSearch.SearchValue = Get("Q48"); // Default Value // DN
            if (!Empty(Q48.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q48"))
                Q48.AdvancedSearch.SearchOperator = Get("z_Q48");

            // Q49
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q49"))
                    Q49.AdvancedSearch.SearchValue = Get("x_Q49");
                else
                    Q49.AdvancedSearch.SearchValue = Get("Q49"); // Default Value // DN
            if (!Empty(Q49.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q49"))
                Q49.AdvancedSearch.SearchOperator = Get("z_Q49");

            // Q50
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q50"))
                    Q50.AdvancedSearch.SearchValue = Get("x_Q50");
                else
                    Q50.AdvancedSearch.SearchValue = Get("Q50"); // Default Value // DN
            if (!Empty(Q50.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q50"))
                Q50.AdvancedSearch.SearchOperator = Get("z_Q50");

            // Section_8
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_8"))
                    Section_8.AdvancedSearch.SearchValue = Get("x_Section_8");
                else
                    Section_8.AdvancedSearch.SearchValue = Get("Section_8"); // Default Value // DN
            if (!Empty(Section_8.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_8"))
                Section_8.AdvancedSearch.SearchOperator = Get("z_Section_8");

            // Q51
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q51"))
                    Q51.AdvancedSearch.SearchValue = Get("x_Q51");
                else
                    Q51.AdvancedSearch.SearchValue = Get("Q51"); // Default Value // DN
            if (!Empty(Q51.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q51"))
                Q51.AdvancedSearch.SearchOperator = Get("z_Q51");

            // Q52
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q52"))
                    Q52.AdvancedSearch.SearchValue = Get("x_Q52");
                else
                    Q52.AdvancedSearch.SearchValue = Get("Q52"); // Default Value // DN
            if (!Empty(Q52.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q52"))
                Q52.AdvancedSearch.SearchOperator = Get("z_Q52");

            // Q53
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q53"))
                    Q53.AdvancedSearch.SearchValue = Get("x_Q53");
                else
                    Q53.AdvancedSearch.SearchValue = Get("Q53"); // Default Value // DN
            if (!Empty(Q53.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q53"))
                Q53.AdvancedSearch.SearchOperator = Get("z_Q53");

            // Q54
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q54"))
                    Q54.AdvancedSearch.SearchValue = Get("x_Q54");
                else
                    Q54.AdvancedSearch.SearchValue = Get("Q54"); // Default Value // DN
            if (!Empty(Q54.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q54"))
                Q54.AdvancedSearch.SearchOperator = Get("z_Q54");

            // Q55
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q55"))
                    Q55.AdvancedSearch.SearchValue = Get("x_Q55");
                else
                    Q55.AdvancedSearch.SearchValue = Get("Q55"); // Default Value // DN
            if (!Empty(Q55.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q55"))
                Q55.AdvancedSearch.SearchOperator = Get("z_Q55");

            // Section_9
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_9"))
                    Section_9.AdvancedSearch.SearchValue = Get("x_Section_9");
                else
                    Section_9.AdvancedSearch.SearchValue = Get("Section_9"); // Default Value // DN
            if (!Empty(Section_9.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_9"))
                Section_9.AdvancedSearch.SearchOperator = Get("z_Section_9");

            // Q56
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q56"))
                    Q56.AdvancedSearch.SearchValue = Get("x_Q56");
                else
                    Q56.AdvancedSearch.SearchValue = Get("Q56"); // Default Value // DN
            if (!Empty(Q56.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q56"))
                Q56.AdvancedSearch.SearchOperator = Get("z_Q56");

            // Q57
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q57"))
                    Q57.AdvancedSearch.SearchValue = Get("x_Q57");
                else
                    Q57.AdvancedSearch.SearchValue = Get("Q57"); // Default Value // DN
            if (!Empty(Q57.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q57"))
                Q57.AdvancedSearch.SearchOperator = Get("z_Q57");

            // Q58
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q58"))
                    Q58.AdvancedSearch.SearchValue = Get("x_Q58");
                else
                    Q58.AdvancedSearch.SearchValue = Get("Q58"); // Default Value // DN
            if (!Empty(Q58.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q58"))
                Q58.AdvancedSearch.SearchOperator = Get("z_Q58");

            // Q59
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q59"))
                    Q59.AdvancedSearch.SearchValue = Get("x_Q59");
                else
                    Q59.AdvancedSearch.SearchValue = Get("Q59"); // Default Value // DN
            if (!Empty(Q59.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q59"))
                Q59.AdvancedSearch.SearchOperator = Get("z_Q59");

            // Section_10
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_10"))
                    Section_10.AdvancedSearch.SearchValue = Get("x_Section_10");
                else
                    Section_10.AdvancedSearch.SearchValue = Get("Section_10"); // Default Value // DN
            if (!Empty(Section_10.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_10"))
                Section_10.AdvancedSearch.SearchOperator = Get("z_Section_10");

            // Q60
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q60"))
                    Q60.AdvancedSearch.SearchValue = Get("x_Q60");
                else
                    Q60.AdvancedSearch.SearchValue = Get("Q60"); // Default Value // DN
            if (!Empty(Q60.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q60"))
                Q60.AdvancedSearch.SearchOperator = Get("z_Q60");

            // Q61
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q61"))
                    Q61.AdvancedSearch.SearchValue = Get("x_Q61");
                else
                    Q61.AdvancedSearch.SearchValue = Get("Q61"); // Default Value // DN
            if (!Empty(Q61.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q61"))
                Q61.AdvancedSearch.SearchOperator = Get("z_Q61");

            // Q62
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q62"))
                    Q62.AdvancedSearch.SearchValue = Get("x_Q62");
                else
                    Q62.AdvancedSearch.SearchValue = Get("Q62"); // Default Value // DN
            if (!Empty(Q62.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q62"))
                Q62.AdvancedSearch.SearchOperator = Get("z_Q62");

            // Q63
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q63"))
                    Q63.AdvancedSearch.SearchValue = Get("x_Q63");
                else
                    Q63.AdvancedSearch.SearchValue = Get("Q63"); // Default Value // DN
            if (!Empty(Q63.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q63"))
                Q63.AdvancedSearch.SearchOperator = Get("z_Q63");

            // Q64
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q64"))
                    Q64.AdvancedSearch.SearchValue = Get("x_Q64");
                else
                    Q64.AdvancedSearch.SearchValue = Get("Q64"); // Default Value // DN
            if (!Empty(Q64.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q64"))
                Q64.AdvancedSearch.SearchOperator = Get("z_Q64");

            // Q65
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q65"))
                    Q65.AdvancedSearch.SearchValue = Get("x_Q65");
                else
                    Q65.AdvancedSearch.SearchValue = Get("Q65"); // Default Value // DN
            if (!Empty(Q65.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q65"))
                Q65.AdvancedSearch.SearchOperator = Get("z_Q65");

            // Section_11
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Section_11"))
                    Section_11.AdvancedSearch.SearchValue = Get("x_Section_11");
                else
                    Section_11.AdvancedSearch.SearchValue = Get("Section_11"); // Default Value // DN
            if (!Empty(Section_11.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Section_11"))
                Section_11.AdvancedSearch.SearchOperator = Get("z_Section_11");

            // Q66
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q66"))
                    Q66.AdvancedSearch.SearchValue = Get("x_Q66");
                else
                    Q66.AdvancedSearch.SearchValue = Get("Q66"); // Default Value // DN
            if (!Empty(Q66.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q66"))
                Q66.AdvancedSearch.SearchOperator = Get("z_Q66");

            // Q67
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q67"))
                    Q67.AdvancedSearch.SearchValue = Get("x_Q67");
                else
                    Q67.AdvancedSearch.SearchValue = Get("Q67"); // Default Value // DN
            if (!Empty(Q67.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q67"))
                Q67.AdvancedSearch.SearchOperator = Get("z_Q67");

            // Q68
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q68"))
                    Q68.AdvancedSearch.SearchValue = Get("x_Q68");
                else
                    Q68.AdvancedSearch.SearchValue = Get("Q68"); // Default Value // DN
            if (!Empty(Q68.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q68"))
                Q68.AdvancedSearch.SearchOperator = Get("z_Q68");

            // Q69
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q69"))
                    Q69.AdvancedSearch.SearchValue = Get("x_Q69");
                else
                    Q69.AdvancedSearch.SearchValue = Get("Q69"); // Default Value // DN
            if (!Empty(Q69.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q69"))
                Q69.AdvancedSearch.SearchOperator = Get("z_Q69");

            // Q70
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Q70"))
                    Q70.AdvancedSearch.SearchValue = Get("x_Q70");
                else
                    Q70.AdvancedSearch.SearchValue = Get("Q70"); // Default Value // DN
            if (!Empty(Q70.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Q70"))
                Q70.AdvancedSearch.SearchOperator = Get("z_Q70");

            // Notes_3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Notes_3"))
                    Notes_3.AdvancedSearch.SearchValue = Get("x_Notes_3");
                else
                    Notes_3.AdvancedSearch.SearchValue = Get("Notes_3"); // Default Value // DN
            if (!Empty(Notes_3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Notes_3"))
                Notes_3.AdvancedSearch.SearchOperator = Get("z_Notes_3");

            // Examiner_Signature
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Examiner_Signature"))
                    Examiner_Signature.AdvancedSearch.SearchValue = Get("x_Examiner_Signature");
                else
                    Examiner_Signature.AdvancedSearch.SearchValue = Get("Examiner_Signature"); // Default Value // DN
            if (!Empty(Examiner_Signature.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Examiner_Signature"))
                Examiner_Signature.AdvancedSearch.SearchOperator = Get("z_Examiner_Signature");

            // Student_Signature
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Student_Signature"))
                    Student_Signature.AdvancedSearch.SearchValue = Get("x_Student_Signature");
                else
                    Student_Signature.AdvancedSearch.SearchValue = Get("Student_Signature"); // Default Value // DN
            if (!Empty(Student_Signature.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Student_Signature"))
                Student_Signature.AdvancedSearch.SearchOperator = Get("z_Student_Signature");

            // AbsherApptNbr
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_AbsherApptNbr[]"))
                    AbsherApptNbr.AdvancedSearch.SearchValue = Get("x_AbsherApptNbr[]");
                else
                    AbsherApptNbr.AdvancedSearch.SearchValue = Get("AbsherApptNbr"); // Default Value // DN
            if (!Empty(AbsherApptNbr.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_AbsherApptNbr"))
                AbsherApptNbr.AdvancedSearch.SearchOperator = Get("z_AbsherApptNbr");

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

            // DriveTypelink
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_DriveTypelink"))
                    DriveTypelink.AdvancedSearch.SearchValue = Get("x_DriveTypelink");
                else
                    DriveTypelink.AdvancedSearch.SearchValue = Get("DriveTypelink"); // Default Value // DN
            if (!Empty(DriveTypelink.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_DriveTypelink"))
                DriveTypelink.AdvancedSearch.SearchOperator = Get("z_DriveTypelink");

            // intEvaluationType
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_intEvaluationType"))
                    intEvaluationType.AdvancedSearch.SearchValue = Get("x_intEvaluationType");
                else
                    intEvaluationType.AdvancedSearch.SearchValue = Get("intEvaluationType"); // Default Value // DN
            if (!Empty(intEvaluationType.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_intEvaluationType"))
                intEvaluationType.AdvancedSearch.SearchOperator = Get("z_intEvaluationType");

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

            // Scores_S1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S1"))
                    Scores_S1.AdvancedSearch.SearchValue = Get("x_Scores_S1");
                else
                    Scores_S1.AdvancedSearch.SearchValue = Get("Scores_S1"); // Default Value // DN
            if (!Empty(Scores_S1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S1"))
                Scores_S1.AdvancedSearch.SearchOperator = Get("z_Scores_S1");

            // S1
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S1"))
                    S1.AdvancedSearch.SearchValue = Get("x_S1");
                else
                    S1.AdvancedSearch.SearchValue = Get("S1"); // Default Value // DN
            if (!Empty(S1.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S1"))
                S1.AdvancedSearch.SearchOperator = Get("z_S1");

            // S2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S2"))
                    S2.AdvancedSearch.SearchValue = Get("x_S2");
                else
                    S2.AdvancedSearch.SearchValue = Get("S2"); // Default Value // DN
            if (!Empty(S2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S2"))
                S2.AdvancedSearch.SearchOperator = Get("z_S2");

            // S3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S3"))
                    S3.AdvancedSearch.SearchValue = Get("x_S3");
                else
                    S3.AdvancedSearch.SearchValue = Get("S3"); // Default Value // DN
            if (!Empty(S3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S3"))
                S3.AdvancedSearch.SearchOperator = Get("z_S3");

            // S4
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S4"))
                    S4.AdvancedSearch.SearchValue = Get("x_S4");
                else
                    S4.AdvancedSearch.SearchValue = Get("S4"); // Default Value // DN
            if (!Empty(S4.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S4"))
                S4.AdvancedSearch.SearchOperator = Get("z_S4");

            // S5
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S5"))
                    S5.AdvancedSearch.SearchValue = Get("x_S5");
                else
                    S5.AdvancedSearch.SearchValue = Get("S5"); // Default Value // DN
            if (!Empty(S5.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S5"))
                S5.AdvancedSearch.SearchOperator = Get("z_S5");

            // Scores_S2
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S2"))
                    Scores_S2.AdvancedSearch.SearchValue = Get("x_Scores_S2");
                else
                    Scores_S2.AdvancedSearch.SearchValue = Get("Scores_S2"); // Default Value // DN
            if (!Empty(Scores_S2.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S2"))
                Scores_S2.AdvancedSearch.SearchOperator = Get("z_Scores_S2");

            // S6
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S6"))
                    S6.AdvancedSearch.SearchValue = Get("x_S6");
                else
                    S6.AdvancedSearch.SearchValue = Get("S6"); // Default Value // DN
            if (!Empty(S6.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S6"))
                S6.AdvancedSearch.SearchOperator = Get("z_S6");

            // S7
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S7"))
                    S7.AdvancedSearch.SearchValue = Get("x_S7");
                else
                    S7.AdvancedSearch.SearchValue = Get("S7"); // Default Value // DN
            if (!Empty(S7.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S7"))
                S7.AdvancedSearch.SearchOperator = Get("z_S7");

            // S8
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S8"))
                    S8.AdvancedSearch.SearchValue = Get("x_S8");
                else
                    S8.AdvancedSearch.SearchValue = Get("S8"); // Default Value // DN
            if (!Empty(S8.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S8"))
                S8.AdvancedSearch.SearchOperator = Get("z_S8");

            // S9
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S9"))
                    S9.AdvancedSearch.SearchValue = Get("x_S9");
                else
                    S9.AdvancedSearch.SearchValue = Get("S9"); // Default Value // DN
            if (!Empty(S9.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S9"))
                S9.AdvancedSearch.SearchOperator = Get("z_S9");

            // S10
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S10"))
                    S10.AdvancedSearch.SearchValue = Get("x_S10");
                else
                    S10.AdvancedSearch.SearchValue = Get("S10"); // Default Value // DN
            if (!Empty(S10.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S10"))
                S10.AdvancedSearch.SearchOperator = Get("z_S10");

            // S11
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S11"))
                    S11.AdvancedSearch.SearchValue = Get("x_S11");
                else
                    S11.AdvancedSearch.SearchValue = Get("S11"); // Default Value // DN
            if (!Empty(S11.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S11"))
                S11.AdvancedSearch.SearchOperator = Get("z_S11");

            // S12
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S12"))
                    S12.AdvancedSearch.SearchValue = Get("x_S12");
                else
                    S12.AdvancedSearch.SearchValue = Get("S12"); // Default Value // DN
            if (!Empty(S12.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S12"))
                S12.AdvancedSearch.SearchOperator = Get("z_S12");

            // S13
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S13"))
                    S13.AdvancedSearch.SearchValue = Get("x_S13");
                else
                    S13.AdvancedSearch.SearchValue = Get("S13"); // Default Value // DN
            if (!Empty(S13.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S13"))
                S13.AdvancedSearch.SearchOperator = Get("z_S13");

            // S14
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S14"))
                    S14.AdvancedSearch.SearchValue = Get("x_S14");
                else
                    S14.AdvancedSearch.SearchValue = Get("S14"); // Default Value // DN
            if (!Empty(S14.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S14"))
                S14.AdvancedSearch.SearchOperator = Get("z_S14");

            // S15
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S15"))
                    S15.AdvancedSearch.SearchValue = Get("x_S15");
                else
                    S15.AdvancedSearch.SearchValue = Get("S15"); // Default Value // DN
            if (!Empty(S15.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S15"))
                S15.AdvancedSearch.SearchOperator = Get("z_S15");

            // Scores_S3
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S3"))
                    Scores_S3.AdvancedSearch.SearchValue = Get("x_Scores_S3");
                else
                    Scores_S3.AdvancedSearch.SearchValue = Get("Scores_S3"); // Default Value // DN
            if (!Empty(Scores_S3.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S3"))
                Scores_S3.AdvancedSearch.SearchOperator = Get("z_Scores_S3");

            // S16
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S16"))
                    S16.AdvancedSearch.SearchValue = Get("x_S16");
                else
                    S16.AdvancedSearch.SearchValue = Get("S16"); // Default Value // DN
            if (!Empty(S16.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S16"))
                S16.AdvancedSearch.SearchOperator = Get("z_S16");

            // S17
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S17"))
                    S17.AdvancedSearch.SearchValue = Get("x_S17");
                else
                    S17.AdvancedSearch.SearchValue = Get("S17"); // Default Value // DN
            if (!Empty(S17.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S17"))
                S17.AdvancedSearch.SearchOperator = Get("z_S17");

            // S18
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S18"))
                    S18.AdvancedSearch.SearchValue = Get("x_S18");
                else
                    S18.AdvancedSearch.SearchValue = Get("S18"); // Default Value // DN
            if (!Empty(S18.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S18"))
                S18.AdvancedSearch.SearchOperator = Get("z_S18");

            // S19
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S19"))
                    S19.AdvancedSearch.SearchValue = Get("x_S19");
                else
                    S19.AdvancedSearch.SearchValue = Get("S19"); // Default Value // DN
            if (!Empty(S19.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S19"))
                S19.AdvancedSearch.SearchOperator = Get("z_S19");

            // S20
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S20"))
                    S20.AdvancedSearch.SearchValue = Get("x_S20");
                else
                    S20.AdvancedSearch.SearchValue = Get("S20"); // Default Value // DN
            if (!Empty(S20.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S20"))
                S20.AdvancedSearch.SearchOperator = Get("z_S20");

            // S21
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S21"))
                    S21.AdvancedSearch.SearchValue = Get("x_S21");
                else
                    S21.AdvancedSearch.SearchValue = Get("S21"); // Default Value // DN
            if (!Empty(S21.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S21"))
                S21.AdvancedSearch.SearchOperator = Get("z_S21");

            // Scores_S4
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S4"))
                    Scores_S4.AdvancedSearch.SearchValue = Get("x_Scores_S4");
                else
                    Scores_S4.AdvancedSearch.SearchValue = Get("Scores_S4"); // Default Value // DN
            if (!Empty(Scores_S4.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S4"))
                Scores_S4.AdvancedSearch.SearchOperator = Get("z_Scores_S4");

            // S22
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S22"))
                    S22.AdvancedSearch.SearchValue = Get("x_S22");
                else
                    S22.AdvancedSearch.SearchValue = Get("S22"); // Default Value // DN
            if (!Empty(S22.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S22"))
                S22.AdvancedSearch.SearchOperator = Get("z_S22");

            // S23
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S23"))
                    S23.AdvancedSearch.SearchValue = Get("x_S23");
                else
                    S23.AdvancedSearch.SearchValue = Get("S23"); // Default Value // DN
            if (!Empty(S23.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S23"))
                S23.AdvancedSearch.SearchOperator = Get("z_S23");

            // S24
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S24"))
                    S24.AdvancedSearch.SearchValue = Get("x_S24");
                else
                    S24.AdvancedSearch.SearchValue = Get("S24"); // Default Value // DN
            if (!Empty(S24.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S24"))
                S24.AdvancedSearch.SearchOperator = Get("z_S24");

            // S25
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S25"))
                    S25.AdvancedSearch.SearchValue = Get("x_S25");
                else
                    S25.AdvancedSearch.SearchValue = Get("S25"); // Default Value // DN
            if (!Empty(S25.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S25"))
                S25.AdvancedSearch.SearchOperator = Get("z_S25");

            // S26
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S26"))
                    S26.AdvancedSearch.SearchValue = Get("x_S26");
                else
                    S26.AdvancedSearch.SearchValue = Get("S26"); // Default Value // DN
            if (!Empty(S26.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S26"))
                S26.AdvancedSearch.SearchOperator = Get("z_S26");

            // Scores_S5
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S5"))
                    Scores_S5.AdvancedSearch.SearchValue = Get("x_Scores_S5");
                else
                    Scores_S5.AdvancedSearch.SearchValue = Get("Scores_S5"); // Default Value // DN
            if (!Empty(Scores_S5.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S5"))
                Scores_S5.AdvancedSearch.SearchOperator = Get("z_Scores_S5");

            // S27
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S27"))
                    S27.AdvancedSearch.SearchValue = Get("x_S27");
                else
                    S27.AdvancedSearch.SearchValue = Get("S27"); // Default Value // DN
            if (!Empty(S27.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S27"))
                S27.AdvancedSearch.SearchOperator = Get("z_S27");

            // S28
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S28"))
                    S28.AdvancedSearch.SearchValue = Get("x_S28");
                else
                    S28.AdvancedSearch.SearchValue = Get("S28"); // Default Value // DN
            if (!Empty(S28.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S28"))
                S28.AdvancedSearch.SearchOperator = Get("z_S28");

            // S29
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S29"))
                    S29.AdvancedSearch.SearchValue = Get("x_S29");
                else
                    S29.AdvancedSearch.SearchValue = Get("S29"); // Default Value // DN
            if (!Empty(S29.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S29"))
                S29.AdvancedSearch.SearchOperator = Get("z_S29");

            // S30
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S30"))
                    S30.AdvancedSearch.SearchValue = Get("x_S30");
                else
                    S30.AdvancedSearch.SearchValue = Get("S30"); // Default Value // DN
            if (!Empty(S30.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S30"))
                S30.AdvancedSearch.SearchOperator = Get("z_S30");

            // S31
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S31"))
                    S31.AdvancedSearch.SearchValue = Get("x_S31");
                else
                    S31.AdvancedSearch.SearchValue = Get("S31"); // Default Value // DN
            if (!Empty(S31.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S31"))
                S31.AdvancedSearch.SearchOperator = Get("z_S31");

            // S32
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S32"))
                    S32.AdvancedSearch.SearchValue = Get("x_S32");
                else
                    S32.AdvancedSearch.SearchValue = Get("S32"); // Default Value // DN
            if (!Empty(S32.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S32"))
                S32.AdvancedSearch.SearchOperator = Get("z_S32");

            // S33
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S33"))
                    S33.AdvancedSearch.SearchValue = Get("x_S33");
                else
                    S33.AdvancedSearch.SearchValue = Get("S33"); // Default Value // DN
            if (!Empty(S33.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S33"))
                S33.AdvancedSearch.SearchOperator = Get("z_S33");

            // S34
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S34"))
                    S34.AdvancedSearch.SearchValue = Get("x_S34");
                else
                    S34.AdvancedSearch.SearchValue = Get("S34"); // Default Value // DN
            if (!Empty(S34.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S34"))
                S34.AdvancedSearch.SearchOperator = Get("z_S34");

            // S35
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S35"))
                    S35.AdvancedSearch.SearchValue = Get("x_S35");
                else
                    S35.AdvancedSearch.SearchValue = Get("S35"); // Default Value // DN
            if (!Empty(S35.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S35"))
                S35.AdvancedSearch.SearchOperator = Get("z_S35");

            // Scores_S6
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S6"))
                    Scores_S6.AdvancedSearch.SearchValue = Get("x_Scores_S6");
                else
                    Scores_S6.AdvancedSearch.SearchValue = Get("Scores_S6"); // Default Value // DN
            if (!Empty(Scores_S6.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S6"))
                Scores_S6.AdvancedSearch.SearchOperator = Get("z_Scores_S6");

            // S36
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S36"))
                    S36.AdvancedSearch.SearchValue = Get("x_S36");
                else
                    S36.AdvancedSearch.SearchValue = Get("S36"); // Default Value // DN
            if (!Empty(S36.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S36"))
                S36.AdvancedSearch.SearchOperator = Get("z_S36");

            // S37
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S37"))
                    S37.AdvancedSearch.SearchValue = Get("x_S37");
                else
                    S37.AdvancedSearch.SearchValue = Get("S37"); // Default Value // DN
            if (!Empty(S37.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S37"))
                S37.AdvancedSearch.SearchOperator = Get("z_S37");

            // S38
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S38"))
                    S38.AdvancedSearch.SearchValue = Get("x_S38");
                else
                    S38.AdvancedSearch.SearchValue = Get("S38"); // Default Value // DN
            if (!Empty(S38.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S38"))
                S38.AdvancedSearch.SearchOperator = Get("z_S38");

            // S39
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S39"))
                    S39.AdvancedSearch.SearchValue = Get("x_S39");
                else
                    S39.AdvancedSearch.SearchValue = Get("S39"); // Default Value // DN
            if (!Empty(S39.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S39"))
                S39.AdvancedSearch.SearchOperator = Get("z_S39");

            // S40
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S40"))
                    S40.AdvancedSearch.SearchValue = Get("x_S40");
                else
                    S40.AdvancedSearch.SearchValue = Get("S40"); // Default Value // DN
            if (!Empty(S40.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S40"))
                S40.AdvancedSearch.SearchOperator = Get("z_S40");

            // S41
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S41"))
                    S41.AdvancedSearch.SearchValue = Get("x_S41");
                else
                    S41.AdvancedSearch.SearchValue = Get("S41"); // Default Value // DN
            if (!Empty(S41.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S41"))
                S41.AdvancedSearch.SearchOperator = Get("z_S41");

            // S42
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S42"))
                    S42.AdvancedSearch.SearchValue = Get("x_S42");
                else
                    S42.AdvancedSearch.SearchValue = Get("S42"); // Default Value // DN
            if (!Empty(S42.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S42"))
                S42.AdvancedSearch.SearchOperator = Get("z_S42");

            // S43
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S43"))
                    S43.AdvancedSearch.SearchValue = Get("x_S43");
                else
                    S43.AdvancedSearch.SearchValue = Get("S43"); // Default Value // DN
            if (!Empty(S43.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S43"))
                S43.AdvancedSearch.SearchOperator = Get("z_S43");

            // Scores_S7
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S7"))
                    Scores_S7.AdvancedSearch.SearchValue = Get("x_Scores_S7");
                else
                    Scores_S7.AdvancedSearch.SearchValue = Get("Scores_S7"); // Default Value // DN
            if (!Empty(Scores_S7.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S7"))
                Scores_S7.AdvancedSearch.SearchOperator = Get("z_Scores_S7");

            // S44
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S44"))
                    S44.AdvancedSearch.SearchValue = Get("x_S44");
                else
                    S44.AdvancedSearch.SearchValue = Get("S44"); // Default Value // DN
            if (!Empty(S44.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S44"))
                S44.AdvancedSearch.SearchOperator = Get("z_S44");

            // S45
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S45"))
                    S45.AdvancedSearch.SearchValue = Get("x_S45");
                else
                    S45.AdvancedSearch.SearchValue = Get("S45"); // Default Value // DN
            if (!Empty(S45.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S45"))
                S45.AdvancedSearch.SearchOperator = Get("z_S45");

            // S46
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S46"))
                    S46.AdvancedSearch.SearchValue = Get("x_S46");
                else
                    S46.AdvancedSearch.SearchValue = Get("S46"); // Default Value // DN
            if (!Empty(S46.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S46"))
                S46.AdvancedSearch.SearchOperator = Get("z_S46");

            // S47
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S47"))
                    S47.AdvancedSearch.SearchValue = Get("x_S47");
                else
                    S47.AdvancedSearch.SearchValue = Get("S47"); // Default Value // DN
            if (!Empty(S47.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S47"))
                S47.AdvancedSearch.SearchOperator = Get("z_S47");

            // S48
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S48"))
                    S48.AdvancedSearch.SearchValue = Get("x_S48");
                else
                    S48.AdvancedSearch.SearchValue = Get("S48"); // Default Value // DN
            if (!Empty(S48.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S48"))
                S48.AdvancedSearch.SearchOperator = Get("z_S48");

            // S49
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S49"))
                    S49.AdvancedSearch.SearchValue = Get("x_S49");
                else
                    S49.AdvancedSearch.SearchValue = Get("S49"); // Default Value // DN
            if (!Empty(S49.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S49"))
                S49.AdvancedSearch.SearchOperator = Get("z_S49");

            // S50
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S50"))
                    S50.AdvancedSearch.SearchValue = Get("x_S50");
                else
                    S50.AdvancedSearch.SearchValue = Get("S50"); // Default Value // DN
            if (!Empty(S50.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S50"))
                S50.AdvancedSearch.SearchOperator = Get("z_S50");

            // Scores_S8
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S8"))
                    Scores_S8.AdvancedSearch.SearchValue = Get("x_Scores_S8");
                else
                    Scores_S8.AdvancedSearch.SearchValue = Get("Scores_S8"); // Default Value // DN
            if (!Empty(Scores_S8.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S8"))
                Scores_S8.AdvancedSearch.SearchOperator = Get("z_Scores_S8");

            // S51
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S51"))
                    S51.AdvancedSearch.SearchValue = Get("x_S51");
                else
                    S51.AdvancedSearch.SearchValue = Get("S51"); // Default Value // DN
            if (!Empty(S51.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S51"))
                S51.AdvancedSearch.SearchOperator = Get("z_S51");

            // S52
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S52"))
                    S52.AdvancedSearch.SearchValue = Get("x_S52");
                else
                    S52.AdvancedSearch.SearchValue = Get("S52"); // Default Value // DN
            if (!Empty(S52.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S52"))
                S52.AdvancedSearch.SearchOperator = Get("z_S52");

            // S53
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S53"))
                    S53.AdvancedSearch.SearchValue = Get("x_S53");
                else
                    S53.AdvancedSearch.SearchValue = Get("S53"); // Default Value // DN
            if (!Empty(S53.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S53"))
                S53.AdvancedSearch.SearchOperator = Get("z_S53");

            // S54
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S54"))
                    S54.AdvancedSearch.SearchValue = Get("x_S54");
                else
                    S54.AdvancedSearch.SearchValue = Get("S54"); // Default Value // DN
            if (!Empty(S54.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S54"))
                S54.AdvancedSearch.SearchOperator = Get("z_S54");

            // S55
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S55"))
                    S55.AdvancedSearch.SearchValue = Get("x_S55");
                else
                    S55.AdvancedSearch.SearchValue = Get("S55"); // Default Value // DN
            if (!Empty(S55.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S55"))
                S55.AdvancedSearch.SearchOperator = Get("z_S55");

            // Scores_S9
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S9"))
                    Scores_S9.AdvancedSearch.SearchValue = Get("x_Scores_S9");
                else
                    Scores_S9.AdvancedSearch.SearchValue = Get("Scores_S9"); // Default Value // DN
            if (!Empty(Scores_S9.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S9"))
                Scores_S9.AdvancedSearch.SearchOperator = Get("z_Scores_S9");

            // S56
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S56"))
                    S56.AdvancedSearch.SearchValue = Get("x_S56");
                else
                    S56.AdvancedSearch.SearchValue = Get("S56"); // Default Value // DN
            if (!Empty(S56.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S56"))
                S56.AdvancedSearch.SearchOperator = Get("z_S56");

            // S57
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S57"))
                    S57.AdvancedSearch.SearchValue = Get("x_S57");
                else
                    S57.AdvancedSearch.SearchValue = Get("S57"); // Default Value // DN
            if (!Empty(S57.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S57"))
                S57.AdvancedSearch.SearchOperator = Get("z_S57");

            // S58
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S58"))
                    S58.AdvancedSearch.SearchValue = Get("x_S58");
                else
                    S58.AdvancedSearch.SearchValue = Get("S58"); // Default Value // DN
            if (!Empty(S58.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S58"))
                S58.AdvancedSearch.SearchOperator = Get("z_S58");

            // S59
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S59"))
                    S59.AdvancedSearch.SearchValue = Get("x_S59");
                else
                    S59.AdvancedSearch.SearchValue = Get("S59"); // Default Value // DN
            if (!Empty(S59.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S59"))
                S59.AdvancedSearch.SearchOperator = Get("z_S59");

            // Scores_S10
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S10"))
                    Scores_S10.AdvancedSearch.SearchValue = Get("x_Scores_S10");
                else
                    Scores_S10.AdvancedSearch.SearchValue = Get("Scores_S10"); // Default Value // DN
            if (!Empty(Scores_S10.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S10"))
                Scores_S10.AdvancedSearch.SearchOperator = Get("z_Scores_S10");

            // S60
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S60"))
                    S60.AdvancedSearch.SearchValue = Get("x_S60");
                else
                    S60.AdvancedSearch.SearchValue = Get("S60"); // Default Value // DN
            if (!Empty(S60.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S60"))
                S60.AdvancedSearch.SearchOperator = Get("z_S60");

            // S61
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S61"))
                    S61.AdvancedSearch.SearchValue = Get("x_S61");
                else
                    S61.AdvancedSearch.SearchValue = Get("S61"); // Default Value // DN
            if (!Empty(S61.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S61"))
                S61.AdvancedSearch.SearchOperator = Get("z_S61");

            // S62
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S62"))
                    S62.AdvancedSearch.SearchValue = Get("x_S62");
                else
                    S62.AdvancedSearch.SearchValue = Get("S62"); // Default Value // DN
            if (!Empty(S62.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S62"))
                S62.AdvancedSearch.SearchOperator = Get("z_S62");

            // S63
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S63"))
                    S63.AdvancedSearch.SearchValue = Get("x_S63");
                else
                    S63.AdvancedSearch.SearchValue = Get("S63"); // Default Value // DN
            if (!Empty(S63.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S63"))
                S63.AdvancedSearch.SearchOperator = Get("z_S63");

            // S64
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S64"))
                    S64.AdvancedSearch.SearchValue = Get("x_S64");
                else
                    S64.AdvancedSearch.SearchValue = Get("S64"); // Default Value // DN
            if (!Empty(S64.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S64"))
                S64.AdvancedSearch.SearchOperator = Get("z_S64");

            // S65
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S65"))
                    S65.AdvancedSearch.SearchValue = Get("x_S65");
                else
                    S65.AdvancedSearch.SearchValue = Get("S65"); // Default Value // DN
            if (!Empty(S65.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S65"))
                S65.AdvancedSearch.SearchOperator = Get("z_S65");

            // Scores_S11
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Scores_S11"))
                    Scores_S11.AdvancedSearch.SearchValue = Get("x_Scores_S11");
                else
                    Scores_S11.AdvancedSearch.SearchValue = Get("Scores_S11"); // Default Value // DN
            if (!Empty(Scores_S11.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Scores_S11"))
                Scores_S11.AdvancedSearch.SearchOperator = Get("z_Scores_S11");

            // S66
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S66"))
                    S66.AdvancedSearch.SearchValue = Get("x_S66");
                else
                    S66.AdvancedSearch.SearchValue = Get("S66"); // Default Value // DN
            if (!Empty(S66.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S66"))
                S66.AdvancedSearch.SearchOperator = Get("z_S66");

            // S67
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S67"))
                    S67.AdvancedSearch.SearchValue = Get("x_S67");
                else
                    S67.AdvancedSearch.SearchValue = Get("S67"); // Default Value // DN
            if (!Empty(S67.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S67"))
                S67.AdvancedSearch.SearchOperator = Get("z_S67");

            // S68
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S68"))
                    S68.AdvancedSearch.SearchValue = Get("x_S68");
                else
                    S68.AdvancedSearch.SearchValue = Get("S68"); // Default Value // DN
            if (!Empty(S68.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S68"))
                S68.AdvancedSearch.SearchOperator = Get("z_S68");

            // S69
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S69"))
                    S69.AdvancedSearch.SearchValue = Get("x_S69");
                else
                    S69.AdvancedSearch.SearchValue = Get("S69"); // Default Value // DN
            if (!Empty(S69.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S69"))
                S69.AdvancedSearch.SearchOperator = Get("z_S69");

            // S70
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_S70"))
                    S70.AdvancedSearch.SearchValue = Get("x_S70");
                else
                    S70.AdvancedSearch.SearchValue = Get("S70"); // Default Value // DN
            if (!Empty(S70.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_S70"))
                S70.AdvancedSearch.SearchOperator = Get("z_S70");

            // Evaluation_Score
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Evaluation_Score"))
                    Evaluation_Score.AdvancedSearch.SearchValue = Get("x_Evaluation_Score");
                else
                    Evaluation_Score.AdvancedSearch.SearchValue = Get("Evaluation_Score"); // Default Value // DN
            if (!Empty(Evaluation_Score.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Evaluation_Score"))
                Evaluation_Score.AdvancedSearch.SearchOperator = Get("z_Evaluation_Score");

            // Immediate_Failure_Score
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Immediate_Failure_Score"))
                    Immediate_Failure_Score.AdvancedSearch.SearchValue = Get("x_Immediate_Failure_Score");
                else
                    Immediate_Failure_Score.AdvancedSearch.SearchValue = Get("Immediate_Failure_Score"); // Default Value // DN
            if (!Empty(Immediate_Failure_Score.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Immediate_Failure_Score"))
                Immediate_Failure_Score.AdvancedSearch.SearchOperator = Get("z_Immediate_Failure_Score");

            // Required_Program
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Required_Program"))
                    Required_Program.AdvancedSearch.SearchValue = Get("x_Required_Program");
                else
                    Required_Program.AdvancedSearch.SearchValue = Get("Required_Program"); // Default Value // DN
            if (!Empty(Required_Program.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Required_Program"))
                Required_Program.AdvancedSearch.SearchOperator = Get("z_Required_Program");

            // Price
            if (!IsAddOrEdit)
                if (Query.ContainsKey("x_Price"))
                    Price.AdvancedSearch.SearchValue = Get("x_Price");
                else
                    Price.AdvancedSearch.SearchValue = Get("Price"); // Default Value // DN
            if (!Empty(Price.AdvancedSearch.SearchValue) && Command == "")
                Command = "search";
            if (Query.ContainsKey("z_Price"))
                Price.AdvancedSearch.SearchOperator = Get("z_Price");
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
            } else if (RowType == RowType.Search) {
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

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.AdvancedSearch.SearchValue; // DN
                intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);

                // Retake
                if (Retake.UseFilter && !Empty(Retake.AdvancedSearch.SearchValue)) {
                    Retake.EditValue = ConvertToString(Retake.AdvancedSearch.SearchValue).Split(Config.MultipleOptionSeparator).ToList();
                }

                // AbsherApptNbr
                if (AbsherApptNbr.UseFilter && !Empty(AbsherApptNbr.AdvancedSearch.SearchValue)) {
                    AbsherApptNbr.EditValue = ConvertToString(AbsherApptNbr.AdvancedSearch.SearchValue).Split(Config.MultipleOptionSeparator).ToList();
                }

                // IsDrivingexperience
                IsDrivingexperience.EditValue = IsDrivingexperience.Options(false);
                IsDrivingexperience.PlaceHolder = RemoveHtml(IsDrivingexperience.Caption);
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
            if (!CheckInteger(ConvertToString(NationalID.AdvancedSearch.SearchValue))) {
                NationalID.AddErrorMessage(NationalID.GetErrorMessage(false));
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
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" form=\"ftblEvaluationMBlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"excel\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToExcel") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-excel\" title=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToExcel", true)) + "\">" + Language.Phrase("ExportToExcel") + "</a>";
            } else if (SameText(type, "word")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" form=\"ftblEvaluationMBlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"word\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToWord") + "</button>";
                else
                    return "<a href=\"" + exportUrl + "\" class=\"btn btn-default ew-export-link ew-word\" title=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToWord", true)) + "\">" + Language.Phrase("ExportToWord") + "</a>";
            } else if (SameText(type, "pdf")) {
                if (custom)
                    return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-pdf\" title=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" data-caption=\"" + HtmlEncode(Language.Phrase("ExportToPdf", true)) + "\" form=\"ftblEvaluationMBlist\" data-url=\"" + exportUrl + "\" data-ew-action=\"export\" data-export=\"pdf\" data-custom=\"true\" data-export-selected=\"false\">" + Language.Phrase("ExportToPDF") + "</button>";
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
                return "<button type=\"button\" class=\"btn btn-default ew-export-link ew-email\" title=\"" + Language.Phrase("ExportToEmail", true) + "\" data-caption=\"" + Language.Phrase("ExportToEmail", true) + "\" form=\"ftblEvaluationMBlist\" data-ew-action=\"email\" data-custom=\"false\" data-hdr=\"" + Language.Phrase("ExportToEmail", true) + "\" data-export-selected=\"false\"" + url + ">" + Language.Phrase("ExportToEmail") + "</button>";
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
            item.Body = "<a class=\"btn btn-default ew-search-toggle" + searchToggleClass + "\" role=\"button\" title=\"" + Language.Phrase("SearchPanel") + "\" data-caption=\"" + Language.Phrase("SearchPanel") + "\" data-ew-action=\"search-toggle\" data-form=\"ftblEvaluationMBsrch\" aria-pressed=\"" + (searchToggleClass == " active" ? "true" : "false") + "\">" + Language.Phrase("SearchLink") + "</a>";
            item.Visible = true;

            // Show all button
            item = SearchOptions.Add("showall");
            if (UseCustomTemplate || !UseAjaxActions)
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ShowAll") + "\" data-caption=\"" + Language.Phrase("ShowAll") + "\" href=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ShowAllBtn") + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-show-all\" role=\"button\" title=\"" + Language.Phrase("ShowAll") + "\" data-caption=\"" + Language.Phrase("ShowAll") + "\" data-ew-action=\"refresh\" data-url=\"" + AppPath(PageUrl) + "cmd=reset\">" + Language.Phrase("ShowAllBtn") + "</a>";
            item.Visible = (SearchWhere != DefaultSearchWhere && SearchWhere != "0=101");

            // Advanced search button
            item = SearchOptions.Add("advancedsearch");
            if (ModalSearch && !IsMobile())
                item.Body = "<a class=\"btn btn-default ew-advanced-search\" title=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-table=\"tblEvaluationMB\" data-caption=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-ew-action=\"modal\" data-url=\"" + AppPath("TblEvaluationMbSearch") + "\" data-btn=\"SearchBtn\">" + Language.Phrase("AdvancedSearch", false) + "</a>";
            else
                item.Body = "<a class=\"btn btn-default ew-advanced-search\" title=\"" + Language.Phrase("AdvancedSearch", true) + "\" data-caption=\"" + Language.Phrase("AdvancedSearch", true) + "\" href=\"" + AppPath("TblEvaluationMbSearch") + "\">" + Language.Phrase("AdvancedSearch", false) + "</a>";
            item.Visible = true;

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
            string exportStyle;

            // Export master record
            if (Config.ExportMasterRecord && !Empty(MasterFilterFromSession) && CurrentMasterTable == "tblAssessment") {
                tblAssessment = new TblAssessmentList();
                if (tblAssessment != null) {
                    var c = await GetConnection2Async(tblAssessment.DbId); // Note: Use new connection for master record // DN
                    using var rsmaster = await tblAssessment.LoadReader(DbMasterFilter, "", c); // Load master record
                    if (rsmaster?.HasRows ?? false) { // DN
                        exportStyle = doc.Style;
                        doc.SetStyle("v"); // Change to vertical
                        if (!IsExport("csv") || Config.ExportMasterRecordForCsv) {
                            doc.Table = tblAssessment;
                            await tblAssessment.ExportDocument(doc, rsmaster, 1, 1);
                            doc.ExportEmptyRow();
                            doc.Table = this;
                        }
                        doc.SetStyle(exportStyle); // Restore
                    }
                }
            }

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

                // Update URL
                AddUrl = AddMasterUrl(AddUrl);
                InlineAddUrl = AddMasterUrl(InlineAddUrl);
                GridAddUrl = AddMasterUrl(GridAddUrl);
                GridEditUrl = AddMasterUrl(GridEditUrl);
                MultiEditUrl = AddMasterUrl(MultiEditUrl);

                // Reset start record counter (new master key)
                if (!IsAddOrEdit) {
                    StartRecord = 1;
                    StartRecordNumber = StartRecord;
                }

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
