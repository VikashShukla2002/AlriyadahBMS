namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblBillingInfoPreview
    /// </summary>
    public static TblBillingInfoPreview tblBillingInfoPreview
    {
        get => HttpData.Get<TblBillingInfoPreview>("tblBillingInfoPreview")!;
        set => HttpData["tblBillingInfoPreview"] = value;
    }

    /// <summary>
    /// Page class for tblBillingInfo
    /// </summary>
    public class TblBillingInfoPreview : TblBillingInfoPreviewBase
    {
        // Constructor
        public TblBillingInfoPreview(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblBillingInfoPreview() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblBillingInfoPreviewBase : TblBillingInfo
    {
        // Page ID
        public string PageID = "preview";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblBillingInfo";

        // Page object name
        public string PageObjName = "tblBillingInfoPreview";

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
        public TblBillingInfoPreviewBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-table ew-preview-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblBillingInfo)
            if (tblBillingInfo == null || tblBillingInfo is TblBillingInfo)
                tblBillingInfo = this;

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
        public string PageName => "TblBillingInfoPreview";

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

        // Constructor
        public TblBillingInfoPreviewBase(Controller? controller = null): this() { // DN
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
        }

            // Properties
            public DbDataReader? Recordset = null;

            public int TotalRecords = 0;

            public int RecordCount = 0;

            public Pager? _pager;

            public int StartRecord = 1;

            public int DisplayRecords = 0;

            public bool UseModalLinks = false;

            public string PreviewUrl = ""; // DN

            // Pager
            public Pager Pager
            {
                get {
                    _pager ??= new PrevNextPager(this, StartRecord, DisplayRecords, TotalRecords, usePageSizeSelector: false, url: PreviewUrl, isModal: true);
                    return _pager;
                }
            }

            /// <summary>
            /// Page run
            /// </summary>
            /// <returns>Page result</returns>
            public override async Task<IActionResult> Run()
            {
            // Use layout
            if (!Empty(Param("layout")) && !Param<bool>("layout"))
                UseLayout = false;

            // User profile
            Profile = ResolveProfile();

            // Security
            Security = ResolveSecurity();
            if (TableVar != "")
                Security.LoadTablePermissions(TableVar);
            CurrentAction = Param("action"); // Set up current action

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

                // Load filter
                string[] tokens = Decrypt(Get("f")).Split('|');
                string filter = tokens[0];
                string[] masterKeys = tokens.Skip(1).ToArray();
                if (Empty(filter))
                    filter = "0=1";

                // Preview URL // DN
                PreviewUrl = AppPath(CurrentPageName() + "?t=" + Get("t") + "&f=" + Get("f")); // Add table/filter parameters only

                // Set up sort order
                SetupSortOrder();

                // Set up foreign keys
                SetupForeignKeys(masterKeys);

                // Call Recordset Selecting event
                RecordsetSelecting(ref filter);

                // Load recordset
                filter = ApplyUserIDFilters(filter);
                TotalRecords = await LoadRecordCountAsync(filter);
                string defaultSort = NationalID.Expression + " ASC" + ", " + date_Paid.Expression + " ASC"; // Default sort // DN
                string sql = PreviewSql(filter);
                if (DisplayRecords > 0)
                    Recordset = await Connection.SelectLimit(sql, DisplayRecords, StartRecord - 1, !Empty(CurrentOrder) || !Empty(SessionOrderBy) || !Empty(defaultSort));
                Recordset ??= await Connection.GetDataReaderAsync(sql);
                if (Recordset != null && await Recordset.ReadAsync()) {
                    // Call Recordset Selected event
                    RecordsetSelected(Recordset);
                    LoadListRowValues(Recordset);
                }
                RenderOtherOptions();

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);

                // Global Page Rendering event
                PageRendering();

                // Page Render event
                tblBillingInfoPreview?.PageRender();
            }
                return PageResult();
            }

            // Set up sort order
            public void SetupSortOrder()
            {
                string defaultSort = NationalID.Expression + " ASC" + ", " + date_Paid.Expression + " ASC"; // Set up default sort
                if (Empty(SessionOrderBy) && !Empty(defaultSort))
                    SessionOrderBy = defaultSort;

                // Check for Ctrl pressed
                bool ctrl = Get<bool>("ctrl");
                if (SameText(Get("cmd"), "resetsort")) {
                    StartRecord = 1;
                    CurrentOrder = "";
                    CurrentOrderType = "";
                    int_Bill_ID.Sort = "";
                    NationalID.Sort = "";
                    str_First_Name.Sort = "";
                    str_Last_Name.Sort = "";
                    str_Username.Sort = "";
                    int_Student_ID.Sort = "";
                    int_Payment_Method.Sort = "";
                    date_Paid.Sort = "";
                    str_ApprovalCode.Sort = "";
                    Payment_Number.Sort = "";
                    Pricelist.Sort = "";
                    date_Created.Sort = "";
                    str_Amount.Sort = "";
                    str_CC_Holder_Name.Sort = "";
                    str_CC_Number.Sort = "";
                    int_CC_ExpMonth.Sort = "";
                    int_CC_ExpYear.Sort = "";
                    int_CC_Type.Sort = "";
                    str_Card_Id.Sort = "";
                    str_CC_ValidationNum.Sort = "";
                    str_reference.Sort = "";
                    str_Amount_Pay.Sort = "";
                    mny_Running_Payments.Sort = "";
                    mny_Running_Balance.Sort = "";
                    str_Payment_Reference.Sort = "";
                    int_Accepted_By.Sort = "";
                    str_Check_Number.Sort = "";
                    bit_Is_Check_Deposited.Sort = "";
                    str_Adjustment_Type.Sort = "";
                    str_Adjust_Sub_Type.Sort = "";
                    bit_Archive.Sort = "";
                    int_Created_By.Sort = "";
                    int_Modified_By.Sort = "";
                    date_Modified.Sort = "";
                    bit_IsDeleted.Sort = "";
                    str_CardHolder_Address.Sort = "";
                    str_CH_City.Sort = "";
                    str_CH_Zip.Sort = "";
                    int_State.Sort = "";
                    bit_IsAuthDotNet.Sort = "";
                    bit_IsRefund.Sort = "";
                    str_Receipt.Sort = "";
                    str_TransactionNumber.Sort = "";
                    str_OrderId.Sort = "";
                    str_TransactionTime.Sort = "";
                    int_Location_Id.Sort = "";
                    str_Enrollment_Id.Sort = "";
                    str_Notes.Sort = "";
                    str_Payment_Note.Sort = "";
                    int_Package_ID.Sort = "";
                    Package_Name.Sort = "";
                    Price.Sort = "";
                    AssessmentID.Sort = "";
                    course.Sort = "";
                    institution.Sort = "";
                    UniqueIdx.Sort = "";

                    // Save sort to session
                    SessionOrderBy = "";
                } else {
                    StartRecord = Math.Max(Get<int>("start"), 1);
                    StartRecord = 1;
                    int pageNo = ConvertToInt(Get(Config.TablePageNumber));
                    int startRec = ConvertToInt(Get(Config.TableStartRec));
                    if (pageNo > 0) // Check for page parameter
                        StartRecord = (pageNo - 1) * DisplayRecords + 1;
                    else if (startRec > 0) // Check for "start" parameter
                        StartRecord = startRec;
                    CurrentOrder = Get("sort");
                    CurrentOrderType = Get("sortorder");
                }

                // Check for sort field
                if (!Empty(CurrentOrder)) {
                    UpdateSort(NationalID, ctrl); // NationalID
                    UpdateSort(str_First_Name, ctrl); // str_First_Name
                    UpdateSort(str_Last_Name, ctrl); // str_Last_Name
                    UpdateSort(date_Paid, ctrl); // date_Paid
                    UpdateSort(str_ApprovalCode, ctrl); // str_ApprovalCode
                    UpdateSort(Payment_Number, ctrl); // Payment_Number
                    UpdateSort(Pricelist, ctrl); // Pricelist
                    UpdateSort(str_Amount_Pay, ctrl); // str_Amount_Pay
                    UpdateSort(mny_Running_Payments, ctrl); // mny_Running_Payments
                    UpdateSort(mny_Running_Balance, ctrl); // mny_Running_Balance
                }

                // Update field sort
                UpdateFieldSort();
            }

            // Get preview SQL
            protected string PreviewSql(string filter) {
                string sort = SessionOrderBy;
                return BuildSelectSql(SqlSelect, SqlWhere, SqlGroupBy, SqlHaving, SqlOrderBy, filter, sort);
            }

            #pragma warning disable 1998
            // Set up list options
            protected async Task SetupListOptions() {
                ListOption item;

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
                ListOptions.ButtonClass = ""; // Class for button group

                // Call ListOptions Load event
                ListOptionsLoad();
                ListOptions[ListOptions.GroupOptionName]?.SetVisible(ListOptions.GroupOptionVisible);
            }
            #pragma warning restore 1998

            // Render list options
            #pragma warning disable 168, 219, 1998

            public async Task RenderListOptions()
            {
                ListOption? listOption;
                ListOptions.LoadDefault();

                // Call ListOptions Rendering event
                ListOptionsRendering();
                var masterKeyUrl = MasterKeyUrl();

                // "view"
                listOption = ListOptions["view"];
                listOption?.Clear();
                if (Security.CanView) {
                    string viewCaption = Language.Phrase("ViewLink");
                    string viewTitle = Language.Phrase("ViewLink", true);
                    string viewUrl = AppPath(GetViewUrl(masterKeyUrl));
                    if (UseModalLinks && !IsMobile())
                        listOption?.SetBody("<a class=\"ew-row-link ew-view\" title=\"" + viewTitle + "\" data-caption=\"" + viewTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(viewUrl) + "\" data-btn=\"null\">" + viewCaption + "</a>");
                    else
                        listOption?.SetBody("<a class=\"ew-row-link ew-view\" title=\"" + viewTitle + "\" data-caption=\"" + viewTitle + "\" href=\"" + HtmlEncode(viewUrl) + "\">" + viewCaption + "</a>");
                }

                // "edit"
                listOption = ListOptions["edit"];
                listOption?.Clear();
                if (Security.CanEdit) {
                    string editCaption = Language.Phrase("EditLink");
                    string editTitle = Language.Phrase("EditLink", true);
                    string editUrl = AppPath(GetEditUrl(masterKeyUrl));
                    if (UseModalLinks && !IsMobile())
                        listOption?.SetBody("<a class=\"ew-row-link ew-edit\" title=\"" + editTitle + "\" data-caption=\"" + editTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(editUrl) + "\" data-btn=\"SaveBtn\">" + editCaption + "</a>");
                    else
                        listOption?.SetBody("<a class=\"ew-row-link ew-edit\" title=\"" + editTitle + "\" data-caption=\"" + editTitle + "\" href=\"" + HtmlEncode(editUrl) + "\">" + editCaption + "</a>");
                }

                // Call ListOptions Rendered event
                ListOptionsRendered();
            }
            #pragma warning restore 168, 219, 1998

            // Set up other options
            protected void SetupOtherOptions() {
                var options = OtherOptions;
                var option = options["addedit"];
                option.UseButtonGroup = false;

                // Add group option item
                var item = option.AddGroupOption();
                item.Body = "";
                item.OnLeft = true;
                item.Visible = false;

                // Add
                item = option.Add("add");
                item.Visible = Security.CanAdd;
            }

            // Render other options
            #pragma warning disable 168, 219

            public void RenderOtherOptions() {
                var options = OtherOptions;
                var option = options["addedit"];

                // Add
                var item = option?["add"];
                if (item != null && Security.CanAdd) {
                    string addCaption = Language.Phrase("AddLink");
                    string addTitle = Language.Phrase("AddLink", true);
                    string addUrl = AppPath(GetAddUrl(MasterKeyUrl()));
                    if (UseModalLinks && !IsMobile())
                        item.Body = "<a class=\"btn btn-default btn-sm ew-add-edit ew-add\" title=\"" + addTitle + "\" data-caption=\"" + addTitle + "\" data-ew-action=\"modal\" data-url=\"" + HtmlEncode(addUrl) + "\" data-btn=\"AddBtn\">" + addCaption + "</a>";
                    else
                        item.Body = "<a class=\"btn btn-default btn-sm ew-add-edit ew-add\" title=\"" + addTitle + "\" data-caption=\"" + addTitle + "\" href=\"" + HtmlEncode(addUrl) + "\">" + addCaption + "</a>";
                }
            }
            #pragma warning restore 168, 219

            // Get master foreign key URL
            protected string MasterKeyUrl() {
                string masterTblVar = Get("t"), url = "";
                if (masterTblVar == "tblPotentialStudentInfo") {
                    url = "" + Config.TableShowMaster + "=tblPotentialStudentInfo&" + ForeignKeyUrl("fk_NationalID", NationalID.QueryValue) + "";
                }
                return url;
            }

            #pragma warning disable 168
            // Set up foreign keys
            protected void SetupForeignKeys(string[] keys) {
                string masterTblVar = Get("t");
                if (masterTblVar == "tblPotentialStudentInfo") {
         		        NationalID.QueryValue = keys.ElementAtOrDefault(0);
                }
            }
            #pragma warning restore 168

            // Unquote value
            protected string UnquoteValue(string val) { // DN
                if (val.StartsWith("'") && val.EndsWith("'") && Connection != null) {
                    if (Connection.IsMySql)
                        return val.Substring(1, val.Length - 2).Replace(@"\'", "'");
                    else
                        return val.Substring(1, val.Length - 2).Replace("''", "'");
                } else if (val.StartsWith("N'") && val.EndsWith("'") && (Connection?.IsMsSql ?? false)) {
                    return val.Substring(2, val.Length - 3).Replace("''", "'");
                }
                return val;
            }

            // Close recordset
            public void CloseRecordset()
            {
                using (Recordset) {}
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

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblBillingInfoList")), "", TableVar, true);
            string pageId = "preview";
            breadcrumb.Add("preview", pageId, url);
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
    } // End page class
} // End Partial class
