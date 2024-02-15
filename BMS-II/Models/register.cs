namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// register
    /// </summary>
    public static Register register
    {
        get => HttpData.Get<Register>("register")!;
        set => HttpData["register"] = value;
    }

    /// <summary>
    /// Page class (register)
    /// </summary>
    public class Register : RegisterBase
    {
        // Constructor
        public Register(Controller controller) : base(controller)
        {
        }

        // Constructor
        public Register() : base()
        {
        }

        // Server events

        // Message Showing event
        // type = ""|"success"|"failure"|"warning"
        public override void MessageShowing(ref string msg, string type) {
            // Note: Do not change msg outside the following 4 cases.
            if (type == "success") {
                //msg = "Please fill out the form with the required information:";
            } else if (type == "failure") {
                //msg = "your failure message";
            } else if (type == "warning") {
                //msg = "your warning message";
            } else {
                //msg = "your message";
            }
        }

        // Form Custom Validate event
        public override bool FormCustomValidate(ref string customError) {
            //Return error message in customError
                var rs = GetFormValues(); // Get the form values as Dictionary<string, string>
            if (Convert.ToInt32(rs["str_NationalID_Iqama"].Length) != 10) {
                // Return error message in customError
                customError = "The NationalID or Iqama must have 10 digits and begine with a 1 or 2."+ "\r\n\n" +
                               " يجب أن تتكون الهوية الوطنيةاوالإقامة من 10 أرقام وتبدأ بالرقم 1 أو 2";
                return false;}
        	if (Convert.ToInt32(rs["int_Status"])==1 && Convert.ToString(rs["AbsherApptNbr"]) == "") {
                //Return error message if AbsherApptNbr blank for customer
                customError = "Absher appointment number can not be blank if [Status] field is Customer."+ "\r\n\n" +
                               " .لا يمكن أن يكون رقم موعد أبشر فارغًا إذا كان حقل [الحالة] هو العميل";
                return false;}
        	if (Convert.ToInt32(rs["int_Status"])==1 && Convert.ToString(rs["ProfileField"]) != "3") {
                // Return error message if status is customer and profile is not
                customError = "If Staus is customer, then profile field must be customer."+ "\r\n\n" +
                               ".إذا كانت الحالة عميلًا، فيجب أن يكون مجال الملف الشخصي عميلًا";
                return false;}
        	if (Convert.ToInt32(rs["int_Status"])==1 && Convert.ToString(rs["AbsherApptNbr"]) != "" && Convert.ToString(rs["Absherphoto"]) == ""){
                //Return error message if Absherphoto is blank
                customError = "Absherphoto can not be blank if [Status] field is Customer and AbsherApptNbr is not blank."+ "\r\n\n" +
                               " .لا يمكن أن تكون صورة أبشر فارغة إذا كان حقل [الحالة] هو العميل";
                return false;}
              return true;
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class RegisterBase : TblStudents
    {
        // Page ID
        public string PageID = "register";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Page object name
        public string PageObjName = "register";

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
        public RegisterBase()
        {
            // Custom template // DN
            UseCustomTemplate = true;

            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-register-table d-none";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblStudents)
            if (tblStudents == null || tblStudents is TblStudents)
                tblStudents = this;
            tblStudents = Resolve("tblStudents")!;

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
                return "";
            }
        }

        // Page name
        public string PageName => "register";

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

        // Constructor
        public RegisterBase(Controller? controller = null): this() { // DN
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
                    // Handle modal response
                    if (IsModal) { // Show as modal
                        var result = new { url = GetUrl(url) };
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Student_ID") ? dict["int_Student_ID"] : int_Student_ID.CurrentValue));
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

        public string FormClassName = "ew-form ew-register-form";

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

            // Load default values for add
            LoadDefaultValues();

            // Check modal
            if (IsModal)
                SkipHeaderFooter = true;
            IsMobileOrModal = IsMobile() || IsModal;

            // Set up Breadcrumb
            CurrentBreadcrumb = new ();
            string url = CurrentUrl(); // DN
            CurrentBreadcrumb.Add("register", "RegisterPage", url, "", "", true);
            Heading = Language.Phrase("RegisterPage");
            bool userExists = false;
            await LoadRowValues(); // Load default values

            // Get action
            string currentAction = "";
            StringValues sv;
            if (IsApi())
                currentAction = "insert";
            else if (Post("action", out sv))
                currentAction = sv.ToString();
            if (!Empty(currentAction)) {
                CurrentAction = currentAction;
                await LoadFormValues(); // Get form values

                // Validate form
                if (!await ValidateForm()) {
                    if (IsApi())
                        return Terminate();
                    else
                        CurrentAction = "show"; // Form error, reset action
                }
            } else {
                CurrentAction = "show"; // Display blank record
            }
            var model = new LoginModel();

            // Handle email activation
            if (Get("action", out sv)) {
                string action = sv.ToString();
                string userName = Get("user");
                string code = Get("activatetoken");
                string emailAddress = "", approvalCode = "";
                var ar = code.Split(',');
                if (ar.Length >= 3) {
                    emailAddress = Decrypt(ar[0]);
                    approvalCode = Decrypt(ar[1]);
                    model.Username = userName;
                    model.Password = Decrypt(ar[2]);
                }
                if (userName == approvalCode) {
                    if (SameText(action, "confirm")) { // Email activation
                        if (await ActivateUser(userName)) { // Activate this user
                            if (Empty(SuccessMessage))
                                SuccessMessage = Language.Phrase("ActivateAccount"); // Set up message acount activated
                            return Terminate("login"); // Go to login page
                        }
                    }
                }
                if (Empty(FailureMessage))
                    FailureMessage = Language.Phrase("ActivateFailed"); // Set activate failed message
                return Terminate("login"); // Go to login page
            }

                // Insert record
                if (IsInsert) {
                    // Check for duplicate User ID
                    string filter = GetUserFilter(Config.LoginUsernameFieldName, str_Username.CurrentValue);
                    using var rschk = await LoadReader(filter);
                    if (rschk?.HasRows ?? false) { // DN
                        userExists = true;
                        RestoreFormValues(); // Restore form values
                        FailureMessage = Language.Phrase("UserExists"); // Set user exist message
                    }
                    if (!userExists) {
                        SendEmail = true; // Send email on add success
                        var res = await AddRow(); // Add record
                        if (res) {
                            Email email = await PrepareRegisterEmail();

                            // Get new recordset
                            CurrentFilter = GetRecordFilter();
                            var sql = CurrentSql;
                            var row = await UserTableConn.GetRowAsync(sql, true); // Use main connection (faster)
                            bool emailSent = false;
                            if (EmailSending(email, ConvertToDictionary<dynamic>(new { rsnew = row })))
                                emailSent = await email.SendAsync();

                            // Send email failed
                            if (!emailSent)
                                FailureMessage = email.SendError;

                            // Save user language
                            string username = ConvertToString(GetUserInfo(Config.LoginUsernameFieldName, row));
                            await Profile.SetLanguageId(username, CurrentLanguage);
                            if (Empty(SuccessMessage))
                                SuccessMessage = Language.Phrase("RegisterSuccessActivate"); // Activate success
                            if (IsApi()) { // Return to caller
                                return res;
                            } else {
                                if (Config.UseTwoFactorAuthentication && Config.ForceTwoFactorAuthentication) { // Add two factor authentication
                                    Session[Config.SessionStatus] = "loggingin2fa";
                                    Session[Config.SessionUserProfileUserName] = str_Username.CurrentValue;
                                    Session[Config.SessionUserProfilePassword] = ""; // DO NOT auto login
                                    return Terminate("login2fa"); // Add two factor authentication
                                } else {
                                    return Terminate("login"); // Return
                                }
                            }
                        } else if (IsApi()) { // API request, return
                            return Terminate();
                        } else {
                            RestoreFormValues(); // Restore form values
                        }
                    } else if (IsApi()) { // API request, return
                        return Terminate();
                    }
            }

            // Render row
            if (IsConfirm) { // Confirm page
                RowType = RowType.View; // Render view
            } else {
                RowType = RowType.Add; // Render add
            }
            ResetAttributes();
            await RenderRow();

            // Set LoginStatus, Page Rendering and Page Render
            if (!IsApi() && !IsTerminated) {
                SetupLoginStatus(); // Setup login status

                // Pass login status to client side
                SetClientVar("login", LoginStatus);
            }
            return PageResult();
        }

        // Activate account based on user
        protected async Task<bool> ActivateUser(string usr) {
            string filter = GetUserFilter(Config.LoginUsernameFieldName, usr);
            string sql = GetSql(filter);
            try {
                using var dr = await UserTableConn.OpenDataReaderAsync(sql);
                if (dr != null && await dr.ReadAsync()) {
                    var row = UserTableConn.GetRow(dr);
                    await LoadRowValues(dr); // Load row values
                    dr.Dispose(); // DN
                    var rowact = new Dictionary<string, object> { {Config.RegisterActivateFieldName, 1} }; // Auto register
                    CurrentFilter = filter;
                    bool res = await UpdateAsync(rowact) > 0;
                    if (res) { // Call User Activated event
                        row[Config.RegisterActivateFieldName] = 1;
                        UserActivated(row);
                    }
                    return res;
                } else {
                    FailureMessage = Language.Phrase("NoRecord");
                    return false;
                }
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return false;
            }
        }

        // Confirm page
        public bool ConfirmPage = true; // DN

        #pragma warning disable 1998
        // Get upload files
        public async Task GetUploadFiles()
        {
            // Get upload data
            Absherphoto.Upload.Index = CurrentForm.Index;
            if (!await Absherphoto.Upload.UploadFile()) // DN
                End(Absherphoto.Upload.Message);
            Absherphoto.CurrentValue = Absherphoto.Upload.FileName;
        }
        #pragma warning restore 1998

        // Load default values
        protected void LoadDefaultValues() {
        }

        #pragma warning disable 1998
        // Load form values
        protected async Task LoadFormValues() {
            if (CurrentForm == null)
                return;
            bool validate = !Config.ServerValidate;
            string val;

            // Check field name 'str_First_Name' before field var 'x_str_First_Name'
            val = CurrentForm.HasValue("str_First_Name") ? CurrentForm.GetValue("str_First_Name") : CurrentForm.GetValue("x_str_First_Name");
            if (!str_First_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_First_Name") && !CurrentForm.HasValue("x_str_First_Name")) // DN
                    str_First_Name.Visible = false; // Disable update for API request
                else
                    str_First_Name.SetFormValue(val);
            }

            // Check field name 'str_Middle_Name' before field var 'x_str_Middle_Name'
            val = CurrentForm.HasValue("str_Middle_Name") ? CurrentForm.GetValue("str_Middle_Name") : CurrentForm.GetValue("x_str_Middle_Name");
            if (!str_Middle_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Middle_Name") && !CurrentForm.HasValue("x_str_Middle_Name")) // DN
                    str_Middle_Name.Visible = false; // Disable update for API request
                else
                    str_Middle_Name.SetFormValue(val);
            }

            // Check field name 'str_Last_Name' before field var 'x_str_Last_Name'
            val = CurrentForm.HasValue("str_Last_Name") ? CurrentForm.GetValue("str_Last_Name") : CurrentForm.GetValue("x_str_Last_Name");
            if (!str_Last_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Last_Name") && !CurrentForm.HasValue("x_str_Last_Name")) // DN
                    str_Last_Name.Visible = false; // Disable update for API request
                else
                    str_Last_Name.SetFormValue(val);
            }

            // Check field name 'str_Cell_Phone' before field var 'x_str_Cell_Phone'
            val = CurrentForm.HasValue("str_Cell_Phone") ? CurrentForm.GetValue("str_Cell_Phone") : CurrentForm.GetValue("x_str_Cell_Phone");
            if (!str_Cell_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Cell_Phone") && !CurrentForm.HasValue("x_str_Cell_Phone")) // DN
                    str_Cell_Phone.Visible = false; // Disable update for API request
                else
                    str_Cell_Phone.SetFormValue(val);
            }

            // Check field name 'str_Email' before field var 'x_str_Email'
            val = CurrentForm.HasValue("str_Email") ? CurrentForm.GetValue("str_Email") : CurrentForm.GetValue("x_str_Email");
            if (!str_Email.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Email") && !CurrentForm.HasValue("x_str_Email")) // DN
                    str_Email.Visible = false; // Disable update for API request
                else
                    str_Email.SetFormValue(val, true, validate);
            }

            // Check field name 'str_Password' before field var 'x_str_Password'
            val = CurrentForm.HasValue("str_Password") ? CurrentForm.GetValue("str_Password") : CurrentForm.GetValue("x_str_Password");
            if (!str_Password.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Password") && !CurrentForm.HasValue("x_str_Password")) // DN
                    str_Password.Visible = false; // Disable update for API request
                else
                    str_Password.SetFormValue(val);
            }

            // Note: ConfirmValue will be compared with FormValue
            if (Config.EncryptedPassword) // Encrypted password, use raw value
                str_Password.ConfirmValue = CurrentForm.GetValue("c_str_Password");
            else
                str_Password.ConfirmValue = RemoveXss(CurrentForm.GetValue("c_str_Password"));

            // Check field name 'Hijri_Year' before field var 'x_Hijri_Year'
            val = CurrentForm.HasValue("Hijri_Year") ? CurrentForm.GetValue("Hijri_Year") : CurrentForm.GetValue("x_Hijri_Year");
            if (!Hijri_Year.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Year") && !CurrentForm.HasValue("x_Hijri_Year")) // DN
                    Hijri_Year.Visible = false; // Disable update for API request
                else
                    Hijri_Year.SetFormValue(val);
            }

            // Check field name 'Hijri_Month' before field var 'x_Hijri_Month'
            val = CurrentForm.HasValue("Hijri_Month") ? CurrentForm.GetValue("Hijri_Month") : CurrentForm.GetValue("x_Hijri_Month");
            if (!Hijri_Month.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Month") && !CurrentForm.HasValue("x_Hijri_Month")) // DN
                    Hijri_Month.Visible = false; // Disable update for API request
                else
                    Hijri_Month.SetFormValue(val);
            }

            // Check field name 'Hijri_Day' before field var 'x_Hijri_Day'
            val = CurrentForm.HasValue("Hijri_Day") ? CurrentForm.GetValue("Hijri_Day") : CurrentForm.GetValue("x_Hijri_Day");
            if (!Hijri_Day.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Day") && !CurrentForm.HasValue("x_Hijri_Day")) // DN
                    Hijri_Day.Visible = false; // Disable update for API request
                else
                    Hijri_Day.SetFormValue(val);
            }

            // Check field name 'str_Emergency_Contact_Name' before field var 'x_str_Emergency_Contact_Name'
            val = CurrentForm.HasValue("str_Emergency_Contact_Name") ? CurrentForm.GetValue("str_Emergency_Contact_Name") : CurrentForm.GetValue("x_str_Emergency_Contact_Name");
            if (!str_Emergency_Contact_Name.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Name") && !CurrentForm.HasValue("x_str_Emergency_Contact_Name")) // DN
                    str_Emergency_Contact_Name.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Name.SetFormValue(val);
            }

            // Check field name 'str_Emergency_Contact_Phone' before field var 'x_str_Emergency_Contact_Phone'
            val = CurrentForm.HasValue("str_Emergency_Contact_Phone") ? CurrentForm.GetValue("str_Emergency_Contact_Phone") : CurrentForm.GetValue("x_str_Emergency_Contact_Phone");
            if (!str_Emergency_Contact_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Phone") && !CurrentForm.HasValue("x_str_Emergency_Contact_Phone")) // DN
                    str_Emergency_Contact_Phone.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Phone.SetFormValue(val);
            }

            // Check field name 'str_Emergency_Contact_Relation' before field var 'x_str_Emergency_Contact_Relation'
            val = CurrentForm.HasValue("str_Emergency_Contact_Relation") ? CurrentForm.GetValue("str_Emergency_Contact_Relation") : CurrentForm.GetValue("x_str_Emergency_Contact_Relation");
            if (!str_Emergency_Contact_Relation.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Emergency_Contact_Relation") && !CurrentForm.HasValue("x_str_Emergency_Contact_Relation")) // DN
                    str_Emergency_Contact_Relation.Visible = false; // Disable update for API request
                else
                    str_Emergency_Contact_Relation.SetFormValue(val);
            }

            // Check field name 'str_NationalID_Iqama' before field var 'x_str_NationalID_Iqama'
            val = CurrentForm.HasValue("str_NationalID_Iqama") ? CurrentForm.GetValue("str_NationalID_Iqama") : CurrentForm.GetValue("x_str_NationalID_Iqama");
            if (!str_NationalID_Iqama.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_NationalID_Iqama") && !CurrentForm.HasValue("x_str_NationalID_Iqama")) // DN
                    str_NationalID_Iqama.Visible = false; // Disable update for API request
                else
                    str_NationalID_Iqama.SetFormValue(val, true, validate);
            }

            // Check field name 'IsDrivingexperience' before field var 'x_IsDrivingexperience'
            val = CurrentForm.HasValue("IsDrivingexperience") ? CurrentForm.GetValue("IsDrivingexperience") : CurrentForm.GetValue("x_IsDrivingexperience");
            if (!IsDrivingexperience.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDrivingexperience") && !CurrentForm.HasValue("x_IsDrivingexperience")) // DN
                    IsDrivingexperience.Visible = false; // Disable update for API request
                else
                    IsDrivingexperience.SetFormValue(val);
            }

            // Check field name 'intDrivinglicenseType' before field var 'x_intDrivinglicenseType'
            val = CurrentForm.HasValue("intDrivinglicenseType") ? CurrentForm.GetValue("intDrivinglicenseType") : CurrentForm.GetValue("x_intDrivinglicenseType");
            if (!intDrivinglicenseType.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("intDrivinglicenseType") && !CurrentForm.HasValue("x_intDrivinglicenseType")) // DN
                    intDrivinglicenseType.Visible = false; // Disable update for API request
                else
                    intDrivinglicenseType.SetFormValue(val);
            }

            // Check field name 'AbsherApptNbr' before field var 'x_AbsherApptNbr'
            val = CurrentForm.HasValue("AbsherApptNbr") ? CurrentForm.GetValue("AbsherApptNbr") : CurrentForm.GetValue("x_AbsherApptNbr");
            if (!AbsherApptNbr.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AbsherApptNbr") && !CurrentForm.HasValue("x_AbsherApptNbr")) // DN
                    AbsherApptNbr.Visible = false; // Disable update for API request
                else
                    AbsherApptNbr.SetFormValue(val);
            }

            // Check field name 'int_Student_ID' before field var 'x_int_Student_ID'
            val = CurrentForm.HasValue("int_Student_ID") ? CurrentForm.GetValue("int_Student_ID") : CurrentForm.GetValue("x_int_Student_ID");
            await GetUploadFiles(); // Get upload files
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Middle_Name.CurrentValue = str_Middle_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            str_Cell_Phone.CurrentValue = str_Cell_Phone.FormValue;
            str_Email.CurrentValue = str_Email.FormValue;
            str_Password.CurrentValue = str_Password.FormValue;
            Hijri_Year.CurrentValue = Hijri_Year.FormValue;
            Hijri_Month.CurrentValue = Hijri_Month.FormValue;
            Hijri_Day.CurrentValue = Hijri_Day.FormValue;
            str_Emergency_Contact_Name.CurrentValue = str_Emergency_Contact_Name.FormValue;
            str_Emergency_Contact_Phone.CurrentValue = str_Emergency_Contact_Phone.FormValue;
            str_Emergency_Contact_Relation.CurrentValue = str_Emergency_Contact_Relation.FormValue;
            str_NationalID_Iqama.CurrentValue = str_NationalID_Iqama.FormValue;
            IsDrivingexperience.CurrentValue = IsDrivingexperience.FormValue;
            intDrivinglicenseType.CurrentValue = intDrivinglicenseType.FormValue;
            AbsherApptNbr.CurrentValue = AbsherApptNbr.FormValue;
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

        #pragma warning disable 1998
        // Render row values based on field settings
        public async Task RenderRow()
        {
            // Call Row Rendering event
            RowRendering();

            // Common render codes for all row types

            // int_Student_ID
            int_Student_ID.RowCssClass = "row";

            // str_First_Name
            str_First_Name.RowCssClass = "row";

            // str_Middle_Name
            str_Middle_Name.RowCssClass = "row";

            // str_Last_Name
            str_Last_Name.RowCssClass = "row";

            // str_Full_Name
            str_Full_Name.RowCssClass = "row";

            // str_Address
            str_Address.RowCssClass = "row";

            // str_City
            str_City.RowCssClass = "row";

            // int_State
            int_State.RowCssClass = "row";

            // str_Zip
            str_Zip.RowCssClass = "row";

            // date_Hired
            date_Hired.RowCssClass = "row";

            // date_Left
            date_Left.RowCssClass = "row";

            // str_CertNumber
            str_CertNumber.RowCssClass = "row";

            // date_CertExp
            date_CertExp.RowCssClass = "row";

            // str_Cell_Phone
            str_Cell_Phone.RowCssClass = "row";

            // str_Home_Phone
            str_Home_Phone.RowCssClass = "row";

            // str_Other_Phone
            str_Other_Phone.RowCssClass = "row";

            // str_Email
            str_Email.RowCssClass = "row";

            // str_Code
            str_Code.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // str_Password
            str_Password.RowCssClass = "row";

            // date_Birth_Hijri
            date_Birth_Hijri.RowCssClass = "row";

            // date_Birth
            date_Birth.RowCssClass = "row";

            // Hijri_Year
            Hijri_Year.RowCssClass = "row";

            // Hijri_Month
            Hijri_Month.RowCssClass = "row";

            // Hijri_Day
            Hijri_Day.RowCssClass = "row";

            // date_Started
            date_Started.RowCssClass = "row";

            // str_DateHired
            str_DateHired.RowCssClass = "row";

            // str_DateLeft
            str_DateLeft.RowCssClass = "row";

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.RowCssClass = "row";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.RowCssClass = "row";

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.RowCssClass = "row";

            // str_Notes
            str_Notes.RowCssClass = "row";

            // int_ClassType
            int_ClassType.RowCssClass = "row";

            // str_ZipCodes
            str_ZipCodes.RowCssClass = "row";

            // int_VehicleAssigned
            int_VehicleAssigned.RowCssClass = "row";

            // int_Status
            int_Status.RowCssClass = "row";

            // int_Type
            int_Type.RowCssClass = "row";

            // int_Location
            int_Location.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // bit_IsDeleted
            bit_IsDeleted.RowCssClass = "row";

            // str_InstPermitNo
            str_InstPermitNo.RowCssClass = "row";

            // date_PermitExpiration
            date_PermitExpiration.RowCssClass = "row";

            // date_InCarPermitIssue
            date_InCarPermitIssue.RowCssClass = "row";

            // str_InClassPermitNo
            str_InClassPermitNo.RowCssClass = "row";

            // date_InClassPermitIssue
            date_InClassPermitIssue.RowCssClass = "row";

            // instructor_caption
            instructor_caption.RowCssClass = "row";

            // str_LicType
            str_LicType.RowCssClass = "row";

            // int_Order
            int_Order.RowCssClass = "row";

            // str_InstLicenceDate
            str_InstLicenceDate.RowCssClass = "row";

            // str_DLNum
            str_DLNum.RowCssClass = "row";

            // str_DLExp
            str_DLExp.RowCssClass = "row";

            // bit_appointmentColor
            bit_appointmentColor.RowCssClass = "row";

            // str_appointmentColorCode
            str_appointmentColorCode.RowCssClass = "row";

            // bit_IsSuperAdmin
            bit_IsSuperAdmin.RowCssClass = "row";

            // IsDistanceBasedScheduling
            IsDistanceBasedScheduling.RowCssClass = "row";

            // str_Package_Code
            str_Package_Code.RowCssClass = "row";

            // str_NationalID_Iqama
            str_NationalID_Iqama.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // int_RoadDistanceCoverage
            int_RoadDistanceCoverage.RowCssClass = "row";

            // str_Badge
            str_Badge.RowCssClass = "row";

            // strZoomHostUrl
            strZoomHostUrl.RowCssClass = "row";

            // strZoomUserUrl
            strZoomUserUrl.RowCssClass = "row";

            // Signature
            Signature.RowCssClass = "row";

            // str_VehicleType
            str_VehicleType.RowCssClass = "row";

            // ProfilePicturePath
            ProfilePicturePath.RowCssClass = "row";

            // Institution
            Institution.RowCssClass = "row";

            // IsDrivingexperience
            IsDrivingexperience.RowCssClass = "row";

            // intDrivinglicenseType
            intDrivinglicenseType.RowCssClass = "row";

            // AbsherApptNbr
            AbsherApptNbr.RowCssClass = "row";

            // Absherphoto
            Absherphoto.RowCssClass = "row";

            // Fingerprint
            Fingerprint.RowCssClass = "row";

            // ProfileField
            ProfileField.RowCssClass = "row";

            // UserlevelID
            UserlevelID.RowCssClass = "row";

            // Parent_Username
            Parent_Username.RowCssClass = "row";

            // Activated
            Activated.RowCssClass = "row";

            // int_Nationality
            int_Nationality.RowCssClass = "row";

            // User_Role
            User_Role.RowCssClass = "row";

            // int_Staff_Id
            int_Staff_Id.RowCssClass = "row";

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

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";
                str_Middle_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // str_Email
                str_Email.HrefValue = "";
                str_Email.TooltipValue = "";

                // str_Password
                str_Password.HrefValue = "";
                str_Password.TooltipValue = "";

                // Hijri_Year
                Hijri_Year.HrefValue = "";
                Hijri_Year.TooltipValue = "";

                // Hijri_Month
                Hijri_Month.HrefValue = "";
                Hijri_Month.TooltipValue = "";

                // Hijri_Day
                Hijri_Day.HrefValue = "";
                Hijri_Day.TooltipValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";
                str_Emergency_Contact_Name.TooltipValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";
                str_Emergency_Contact_Phone.TooltipValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";
                str_Emergency_Contact_Relation.TooltipValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";
                str_NationalID_Iqama.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";

                // intDrivinglicenseType
                intDrivinglicenseType.HrefValue = "";
                intDrivinglicenseType.TooltipValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";
                AbsherApptNbr.TooltipValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
                Absherphoto.TooltipValue = "";
            } else if (RowType == RowType.Add) {
                // str_First_Name
                str_First_Name.SetupEditAttributes();
                if (!str_First_Name.Raw)
                    str_First_Name.CurrentValue = HtmlDecode(str_First_Name.CurrentValue);
                str_First_Name.EditValue = HtmlEncode(str_First_Name.CurrentValue);
                str_First_Name.PlaceHolder = RemoveHtml(str_First_Name.Caption);

                // str_Middle_Name
                str_Middle_Name.SetupEditAttributes();
                if (!str_Middle_Name.Raw)
                    str_Middle_Name.CurrentValue = HtmlDecode(str_Middle_Name.CurrentValue);
                str_Middle_Name.EditValue = HtmlEncode(str_Middle_Name.CurrentValue);
                str_Middle_Name.PlaceHolder = RemoveHtml(str_Middle_Name.Caption);

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                if (!str_Last_Name.Raw)
                    str_Last_Name.CurrentValue = HtmlDecode(str_Last_Name.CurrentValue);
                str_Last_Name.EditValue = HtmlEncode(str_Last_Name.CurrentValue);
                str_Last_Name.PlaceHolder = RemoveHtml(str_Last_Name.Caption);

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.CurrentValue = HtmlDecode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

                // str_Email
                str_Email.SetupEditAttributes();
                if (!str_Email.Raw)
                    str_Email.CurrentValue = HtmlDecode(str_Email.CurrentValue);
                str_Email.EditValue = HtmlEncode(str_Email.CurrentValue);
                str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

                // str_Password
                str_Password.SetupEditAttributes();
                str_Password.EditValue = Language.Phrase("PasswordMask"); // Show as masked password
                str_Password.PlaceHolder = RemoveHtml(str_Password.Caption);

                // Hijri_Year
                Hijri_Year.SetupEditAttributes();
                Hijri_Year.EditValue = Hijri_Year.Options(true);
                Hijri_Year.PlaceHolder = RemoveHtml(Hijri_Year.Caption);
                if (!Empty(Hijri_Year.EditValue) && IsNumeric(Hijri_Year.EditValue))
                    Hijri_Year.EditValue = FormatNumber(Hijri_Year.EditValue, null);

                // Hijri_Month
                Hijri_Month.SetupEditAttributes();
                Hijri_Month.EditValue = Hijri_Month.Options(true);
                Hijri_Month.PlaceHolder = RemoveHtml(Hijri_Month.Caption);
                if (!Empty(Hijri_Month.EditValue) && IsNumeric(Hijri_Month.EditValue))
                    Hijri_Month.EditValue = FormatNumber(Hijri_Month.EditValue, null);

                // Hijri_Day
                Hijri_Day.SetupEditAttributes();
                Hijri_Day.EditValue = Hijri_Day.Options(true);
                Hijri_Day.PlaceHolder = RemoveHtml(Hijri_Day.Caption);
                if (!Empty(Hijri_Day.EditValue) && IsNumeric(Hijri_Day.EditValue))
                    Hijri_Day.EditValue = FormatNumber(Hijri_Day.EditValue, null);

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.SetupEditAttributes();
                if (!str_Emergency_Contact_Name.Raw)
                    str_Emergency_Contact_Name.CurrentValue = HtmlDecode(str_Emergency_Contact_Name.CurrentValue);
                str_Emergency_Contact_Name.EditValue = HtmlEncode(str_Emergency_Contact_Name.CurrentValue);
                str_Emergency_Contact_Name.PlaceHolder = RemoveHtml(str_Emergency_Contact_Name.Caption);

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.SetupEditAttributes();
                if (!str_Emergency_Contact_Phone.Raw)
                    str_Emergency_Contact_Phone.CurrentValue = HtmlDecode(str_Emergency_Contact_Phone.CurrentValue);
                str_Emergency_Contact_Phone.EditValue = HtmlEncode(str_Emergency_Contact_Phone.CurrentValue);
                str_Emergency_Contact_Phone.PlaceHolder = RemoveHtml(str_Emergency_Contact_Phone.Caption);

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.SetupEditAttributes();
                str_Emergency_Contact_Relation.EditValue = str_Emergency_Contact_Relation.Options(true);
                str_Emergency_Contact_Relation.PlaceHolder = RemoveHtml(str_Emergency_Contact_Relation.Caption);

                // str_NationalID_Iqama
                str_NationalID_Iqama.SetupEditAttributes();
                if (!str_NationalID_Iqama.Raw)
                    str_NationalID_Iqama.CurrentValue = HtmlDecode(str_NationalID_Iqama.CurrentValue);
                str_NationalID_Iqama.EditValue = HtmlEncode(str_NationalID_Iqama.CurrentValue);
                str_NationalID_Iqama.PlaceHolder = RemoveHtml(str_NationalID_Iqama.Caption);

                // IsDrivingexperience
                IsDrivingexperience.EditValue = IsDrivingexperience.Options(false);
                IsDrivingexperience.PlaceHolder = RemoveHtml(IsDrivingexperience.Caption);

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.Options(true);
                intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);
                if (!Empty(intDrivinglicenseType.EditValue) && IsNumeric(intDrivinglicenseType.EditValue))
                    intDrivinglicenseType.EditValue = FormatNumber(intDrivinglicenseType.EditValue, null);

                // AbsherApptNbr
                AbsherApptNbr.SetupEditAttributes();
                if (!AbsherApptNbr.Raw)
                    AbsherApptNbr.CurrentValue = HtmlDecode(AbsherApptNbr.CurrentValue);
                AbsherApptNbr.EditValue = HtmlEncode(AbsherApptNbr.CurrentValue);
                AbsherApptNbr.PlaceHolder = RemoveHtml(AbsherApptNbr.Caption);

                // Absherphoto
                Absherphoto.SetupEditAttributes();
                if (!IsNull(Absherphoto.Upload.DbValue)) {
                    Absherphoto.EditValue = Absherphoto.Upload.DbValue;
                } else {
                    Absherphoto.EditValue = "";
                }
                if (!Empty(Absherphoto.CurrentValue))
                        Absherphoto.Upload.FileName = ConvertToString(Absherphoto.CurrentValue);
                if (IsShow && !EventCancelled)
                    await RenderUploadField(Absherphoto);

                // Add refer script

                // str_First_Name
                str_First_Name.HrefValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";

                // str_Email
                str_Email.HrefValue = "";

                // str_Password
                str_Password.HrefValue = "";

                // Hijri_Year
                Hijri_Year.HrefValue = "";

                // Hijri_Month
                Hijri_Month.HrefValue = "";

                // Hijri_Day
                Hijri_Day.HrefValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";

                // intDrivinglicenseType
                intDrivinglicenseType.HrefValue = "";

                // AbsherApptNbr
                AbsherApptNbr.HrefValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.ExportHrefValue = Absherphoto.UploadPath + Absherphoto.Upload.DbValue;
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
            if (str_First_Name.Required) {
                if (!str_First_Name.IsDetailKey && Empty(str_First_Name.FormValue)) {
                    str_First_Name.AddErrorMessage(ConvertToString(str_First_Name.RequiredErrorMessage).Replace("%s", str_First_Name.Caption));
                }
            }
            if (str_Middle_Name.Required) {
                if (!str_Middle_Name.IsDetailKey && Empty(str_Middle_Name.FormValue)) {
                    str_Middle_Name.AddErrorMessage(ConvertToString(str_Middle_Name.RequiredErrorMessage).Replace("%s", str_Middle_Name.Caption));
                }
            }
            if (str_Last_Name.Required) {
                if (!str_Last_Name.IsDetailKey && Empty(str_Last_Name.FormValue)) {
                    str_Last_Name.AddErrorMessage(ConvertToString(str_Last_Name.RequiredErrorMessage).Replace("%s", str_Last_Name.Caption));
                }
            }
            if (str_Cell_Phone.Required) {
                if (!str_Cell_Phone.IsDetailKey && Empty(str_Cell_Phone.FormValue)) {
                    str_Cell_Phone.AddErrorMessage(ConvertToString(str_Cell_Phone.RequiredErrorMessage).Replace("%s", str_Cell_Phone.Caption));
                }
            }
            if (str_Email.Required) {
                if (!str_Email.IsDetailKey && Empty(str_Email.FormValue)) {
                    str_Email.AddErrorMessage(ConvertToString(str_Email.RequiredErrorMessage).Replace("%s", str_Email.Caption));
                }
            }
            if (!CheckEmail(str_Email.FormValue)) {
                str_Email.AddErrorMessage(str_Email.GetErrorMessage(false));
            }
            if (str_Password.Required) {
                if (!str_Password.IsDetailKey && Empty(str_Password.FormValue)) {
                    str_Password.AddErrorMessage(Language.Phrase("EnterPassword"));
                }
            }
            if (!SameString(str_Password.ConfirmValue, str_Password.FormValue)) { // DN
                str_Password.AddErrorMessage(Language.Phrase("MismatchPassword"));
            }
            if (!str_Password.Raw && Config.RemoveXss && CheckPassword(str_Password.FormValue)) {
                str_Password.AddErrorMessage(Language.Phrase("InvalidPasswordChars"));
            }
            if (Hijri_Year.Required) {
                if (!Hijri_Year.IsDetailKey && Empty(Hijri_Year.FormValue)) {
                    Hijri_Year.AddErrorMessage(ConvertToString(Hijri_Year.RequiredErrorMessage).Replace("%s", Hijri_Year.Caption));
                }
            }
            if (Hijri_Month.Required) {
                if (!Hijri_Month.IsDetailKey && Empty(Hijri_Month.FormValue)) {
                    Hijri_Month.AddErrorMessage(ConvertToString(Hijri_Month.RequiredErrorMessage).Replace("%s", Hijri_Month.Caption));
                }
            }
            if (Hijri_Day.Required) {
                if (!Hijri_Day.IsDetailKey && Empty(Hijri_Day.FormValue)) {
                    Hijri_Day.AddErrorMessage(ConvertToString(Hijri_Day.RequiredErrorMessage).Replace("%s", Hijri_Day.Caption));
                }
            }
            if (str_Emergency_Contact_Name.Required) {
                if (!str_Emergency_Contact_Name.IsDetailKey && Empty(str_Emergency_Contact_Name.FormValue)) {
                    str_Emergency_Contact_Name.AddErrorMessage(ConvertToString(str_Emergency_Contact_Name.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Name.Caption));
                }
            }
            if (str_Emergency_Contact_Phone.Required) {
                if (!str_Emergency_Contact_Phone.IsDetailKey && Empty(str_Emergency_Contact_Phone.FormValue)) {
                    str_Emergency_Contact_Phone.AddErrorMessage(ConvertToString(str_Emergency_Contact_Phone.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Phone.Caption));
                }
            }
            if (str_Emergency_Contact_Relation.Required) {
                if (!str_Emergency_Contact_Relation.IsDetailKey && Empty(str_Emergency_Contact_Relation.FormValue)) {
                    str_Emergency_Contact_Relation.AddErrorMessage(ConvertToString(str_Emergency_Contact_Relation.RequiredErrorMessage).Replace("%s", str_Emergency_Contact_Relation.Caption));
                }
            }
            if (str_NationalID_Iqama.Required) {
                if (!str_NationalID_Iqama.IsDetailKey && Empty(str_NationalID_Iqama.FormValue)) {
                    str_NationalID_Iqama.AddErrorMessage(ConvertToString(str_NationalID_Iqama.RequiredErrorMessage).Replace("%s", str_NationalID_Iqama.Caption));
                }
            }
            if (!CheckInteger(str_NationalID_Iqama.FormValue)) {
                str_NationalID_Iqama.AddErrorMessage(str_NationalID_Iqama.GetErrorMessage(false));
            }
            if (IsDrivingexperience.Required) {
                if (Empty(IsDrivingexperience.FormValue)) {
                    IsDrivingexperience.AddErrorMessage(ConvertToString(IsDrivingexperience.RequiredErrorMessage).Replace("%s", IsDrivingexperience.Caption));
                }
            }
            if (intDrivinglicenseType.Required) {
                if (!intDrivinglicenseType.IsDetailKey && Empty(intDrivinglicenseType.FormValue)) {
                    intDrivinglicenseType.AddErrorMessage(ConvertToString(intDrivinglicenseType.RequiredErrorMessage).Replace("%s", intDrivinglicenseType.Caption));
                }
            }
            if (AbsherApptNbr.Required) {
                if (!AbsherApptNbr.IsDetailKey && Empty(AbsherApptNbr.FormValue)) {
                    AbsherApptNbr.AddErrorMessage(ConvertToString(AbsherApptNbr.RequiredErrorMessage).Replace("%s", AbsherApptNbr.Caption));
                }
            }
            if (Absherphoto.Required) {
                if (Absherphoto.Upload.FileName == "" && !Absherphoto.Upload.KeepFile) {
                    Absherphoto.AddErrorMessage(ConvertToString(Absherphoto.RequiredErrorMessage).Replace("%s", Absherphoto.Caption));
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

        // Add record
        #pragma warning disable 168, 219

        protected async Task<JsonBoolResult> AddRow(Dictionary<string, object>? rsold = null) { // DN
            bool result = false;

            // Set new row
            Dictionary<string, object> rsnew = new ();
            try {
                // str_First_Name
                str_First_Name.SetDbValue(rsnew, str_First_Name.CurrentValue);

                // str_Middle_Name
                str_Middle_Name.SetDbValue(rsnew, str_Middle_Name.CurrentValue);

                // str_Last_Name
                str_Last_Name.SetDbValue(rsnew, str_Last_Name.CurrentValue);

                // str_Cell_Phone
                str_Cell_Phone.SetDbValue(rsnew, str_Cell_Phone.CurrentValue);

                // str_Email
                str_Email.SetDbValue(rsnew, str_Email.CurrentValue);

                // str_Password
                if (Config.EncryptedPassword && !IsMaskedPassword(str_Password.CurrentValue)) {
                    str_Password.CurrentValue = EncryptPassword(Config.CaseSensitivePassword ? ConvertToString(str_Password.CurrentValue) : ConvertToString(str_Password.CurrentValue).ToLower());
                }
                str_Password.SetDbValue(rsnew, str_Password.CurrentValue);

                // Hijri_Year
                Hijri_Year.SetDbValue(rsnew, Hijri_Year.CurrentValue);

                // Hijri_Month
                Hijri_Month.SetDbValue(rsnew, Hijri_Month.CurrentValue);

                // Hijri_Day
                Hijri_Day.SetDbValue(rsnew, Hijri_Day.CurrentValue);

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.SetDbValue(rsnew, str_Emergency_Contact_Name.CurrentValue);

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.SetDbValue(rsnew, str_Emergency_Contact_Phone.CurrentValue);

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.SetDbValue(rsnew, str_Emergency_Contact_Relation.CurrentValue);

                // str_NationalID_Iqama
                str_NationalID_Iqama.SetDbValue(rsnew, str_NationalID_Iqama.CurrentValue);

                // IsDrivingexperience
                IsDrivingexperience.SetDbValue(rsnew, ConvertToBool(IsDrivingexperience.CurrentValue));

                // intDrivinglicenseType
                intDrivinglicenseType.SetDbValue(rsnew, intDrivinglicenseType.CurrentValue);

                // AbsherApptNbr
                AbsherApptNbr.SetDbValue(rsnew, AbsherApptNbr.CurrentValue);

                // Absherphoto
                if (Absherphoto.Visible && !Absherphoto.Upload.KeepFile) {
                    Absherphoto.Upload.DbValue = ""; // No need to delete old file
                    if (Empty(Absherphoto.Upload.FileName)) {
                        rsnew["Absherphoto"] = DbNullValue;
                    } else {
                        FixUploadTempFileNames(Absherphoto);
                        rsnew["Absherphoto"] = Absherphoto.Upload.FileName;
                    }
                }

                // str_Username

                // Parent_Username
            } catch (Exception e) {
                if (Config.Debug)
                    throw;
                FailureMessage = e.Message;
                return JsonBoolResult.FalseResult;
            }
            if (Absherphoto.Visible && !Absherphoto.Upload.KeepFile) {
                if (!Empty(Absherphoto.Upload.FileName)) {
                    Absherphoto.Upload.DbValue = DbNullValue;
                    FixUploadFileNames(Absherphoto);
                    Absherphoto.SetDbValue(rsnew, Absherphoto.Upload.FileName);
                }
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
            if (!Empty(str_Cell_Phone.CurrentValue)) { // Check field with unique index
                var filter = "(str_Cell_Phone = '" + AdjustSql(str_Cell_Phone.CurrentValue, DbId) + "')";
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupIndex").Replace("%f", str_Cell_Phone.Caption).Replace("%v", ConvertToString(str_Cell_Phone.CurrentValue));
                    return JsonBoolResult.FalseResult;
                }
            }
            if (!Empty(AbsherApptNbr.CurrentValue)) { // Check field with unique index
                var filter = "(AbsherApptNbr = '" + AdjustSql(AbsherApptNbr.CurrentValue, DbId) + "')";
                using var rschk = await LoadReader(filter);
                if (rschk?.HasRows ?? false) { // DN
                    FailureMessage = Language.Phrase("DupIndex").Replace("%f", AbsherApptNbr.Caption).Replace("%v", ConvertToString(AbsherApptNbr.CurrentValue));
                    return JsonBoolResult.FalseResult;
                }
            }

            // Load db values from rsold
            LoadDbValues(rsold);

            // Call Row Inserting event
            bool insertRow = RowInserting(rsold, rsnew);
            if (insertRow) {
                try {
                    result = ConvertToBool(await InsertAsync(rsnew));
                    rsnew["int_Student_ID"] = int_Student_ID.CurrentValue!;
                } catch (Exception e) {
                    if (Config.Debug)
                        throw;
                    FailureMessage = e.Message;
                    result = false;
                }
                if (result) {
                    if (Absherphoto.Visible && !Absherphoto.Upload.KeepFile) {
                        Absherphoto.Upload.DbValue = DbNullValue;
                        if (!await SaveUploadFiles(Absherphoto, ConvertToString(rsnew["Absherphoto"]), false))
                        {
                            FailureMessage = Language.Phrase("UploadError7");
                            return JsonBoolResult.FalseResult;
                        }
                    }
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
            if (result && SendEmail) {
                var res = await SendEmailOnAdd(rsnew); // DN
                if (res != "OK")
                    FailureMessage = res;
            }

            // Call User Registered event
            if (result)
                UserRegistered(rsnew);

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

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
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

        // Form Custom Validate event
        public virtual bool FormCustomValidate(ref string customError) {
            //Return error message in customError
            return true;
        }

        // User Registered event
        public virtual void UserRegistered(Dictionary<string, object> rs) {
            //Log("User_Registered");
        }

        // User Activated event
        public virtual void UserActivated(Dictionary<string, object> rs) {
            //Log("User_Activated");
        }
    } // End page class
} // End Partial class
