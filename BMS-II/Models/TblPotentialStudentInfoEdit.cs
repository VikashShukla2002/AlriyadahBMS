namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblPotentialStudentInfoEdit
    /// </summary>
    public static TblPotentialStudentInfoEdit tblPotentialStudentInfoEdit
    {
        get => HttpData.Get<TblPotentialStudentInfoEdit>("tblPotentialStudentInfoEdit")!;
        set => HttpData["tblPotentialStudentInfoEdit"] = value;
    }

    /// <summary>
    /// Page class for tblPotentialStudentInfo
    /// </summary>
    public class TblPotentialStudentInfoEdit : TblPotentialStudentInfoEditBase
    {
        // Constructor
        public TblPotentialStudentInfoEdit(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblPotentialStudentInfoEdit() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblPotentialStudentInfoEditBase : TblPotentialStudentInfo
    {
        // Page ID
        public string PageID = "edit";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblPotentialStudentInfo";

        // Page object name
        public string PageObjName = "tblPotentialStudentInfoEdit";

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
        public TblPotentialStudentInfoEditBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-edit-table";

            // Language object
            Language = ResolveLanguage();

            // Table object (tblPotentialStudentInfo)
            if (tblPotentialStudentInfo == null || tblPotentialStudentInfo is TblPotentialStudentInfo)
                tblPotentialStudentInfo = this;

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
        public string PageName => "TblPotentialStudentInfoEdit";

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
            int_Potential_Student_ID.Visible = false;
            int_Student_Id.Visible = false;
            str_NationalID_Iqama.SetVisibility();
            NationalID.Visible = false;
            str_First_Name.SetVisibility();
            str_Middle_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Address1.SetVisibility();
            str_Address2.SetVisibility();
            int_State.SetVisibility();
            str_City.SetVisibility();
            str_Zip.SetVisibility();
            int_Instructor.Visible = false;
            int_Driver.Visible = false;
            str_Home_Phone.SetVisibility();
            str_Cell_Phone.SetVisibility();
            str_Parent_Phone.SetVisibility();
            str_Other_Phone.Visible = false;
            str_Email.SetVisibility();
            str_ParentName.SetVisibility();
            str_ParentEmail1.Visible = false;
            str_ParentEmail2.Visible = false;
            str_Username.Visible = false;
            str_Password.Visible = false;
            str_DOB.SetVisibility();
            int_DOB_Day.Visible = false;
            int_DOB_Month.Visible = false;
            int_DOB_Year.Visible = false;
            int_Age.SetVisibility();
            int_Type.Visible = false;
            int_Wear_Glasses.Visible = false;
            int_Sex.SetVisibility();
            str_DLPermit.Visible = false;
            dt_Date_PermitIssue.Visible = false;
            dt_Date_ExpirePermit.Visible = false;
            int_Hs_ID.Visible = false;
            str_Emergency_Contact_Name.SetVisibility();
            str_Emergency_Contact_Phone.SetVisibility();
            str_Emergency_Contact_Relation.SetVisibility();
            str_Student_Notes.SetVisibility();
            str_Driving_Notes.Visible = false;
            int_Location_Id.SetVisibility();
            int_Permit_Number.Visible = false;
            Permit_Issue_Date.Visible = false;
            Permit_Expiry_Date.Visible = false;
            int_Status.Visible = false;
            int_Lead_Id.Visible = false;
            int_Activated_By.Visible = false;
            date_Activated.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            date_Complete.Visible = false;
            int_Created_By.Visible = false;
            int_Modified_By.Visible = false;
            bit_IsDeleted.Visible = false;
            str_CardHolderName.Visible = false;
            str_CardHolderAddress.Visible = false;
            str_CardHolderCity.Visible = false;
            str_CardHolderZip.Visible = false;
            str_CardType.Visible = false;
            str_CardExpMonth.Visible = false;
            str_CardExpYear.Visible = false;
            str_CardNo.Visible = false;
            str_Certificate_No.Visible = false;
            str_AmountPaid.Visible = false;
            str_PermitValidated.Visible = false;
            strSMSNotification.SetVisibility();
            strVoiceNotification.Visible = false;
            str_Weight.SetVisibility();
            str_SpecialNeeds.SetVisibility();
            str_MedicalConditions.SetVisibility();
            bit_Verified_PIC_InSAW.Visible = false;
            bit_Permit_Waiver_Entered.Visible = false;
            bit_TermsConditions.Visible = false;
            bit_Disable_Self_Scheduling.Visible = false;
            int_EyeColor.Visible = false;
            int_HairColor.Visible = false;
            int_ColorBlind.Visible = false;
            int_HeightFeet.Visible = false;
            int_HeightInches.Visible = false;
            str_reference_code.Visible = false;
            dt_ParentClassAttendedDt.Visible = false;
            str_ParentClassAttendedLoc.Visible = false;
            dt_SiblingClassAttendedDt.Visible = false;
            str_SiblingClassAttendedLoc.Visible = false;
            bit_PoliciesAndProcedures.Visible = false;
            dt_CourseCompletionDt.Visible = false;
            dt_ExtensionDt.Visible = false;
            str_MedicalCondition.Visible = false;
            str_MajorCrossStreets.Visible = false;
            str_DriverEdCertNo.Visible = false;
            dt_DriverEdCertIssuedDt.Visible = false;
            str_BTWDriversEdCertNo.Visible = false;
            dt_BTWCertIssuedDt.Visible = false;
            str_OLDriversEdCertNo.Visible = false;
            dt_OLCertIssuedDt.Visible = false;
            str_height.Visible = false;
            dt_BTWCompletionDt.Visible = false;
            dt_CRCompletionDt.Visible = false;
            strTextBox5.Visible = false;
            strTextBox6.Visible = false;
            str_ApartmentNo.Visible = false;
            dt_PermitTestDate.Visible = false;
            str_OnlineDriverEdLogin.Visible = false;
            str_OnlineDriverEdPassword.Visible = false;
            bit_IsSMSEnabled.Visible = false;
            dt_SMSModified.Visible = false;
            str_confirmPassword.Visible = false;
            DE_Certificate.Visible = false;
            Discuss.Visible = false;
            int_UnlicensedSibling.Visible = false;
            int_YearSiblingIsEligible.Visible = false;
            BTW_Certificate.Visible = false;
            dt_DECertIssueDate.Visible = false;
            str_StudentSignature.Visible = false;
            str_ParentSignature.Visible = false;
            str_Last6DigitsOfParentDriversLicense.Visible = false;
            str_FACControl.Visible = false;
            Classroom_Status_Code.Visible = false;
            Laboratory_Status_Code.Visible = false;
            bit_EnrollmentForm.Visible = false;
            bit_ParentStudentContract.Visible = false;
            bit_ParentalAgreement.Visible = false;
            int_SF_GR_WA_HS.Visible = false;
            bit_DisableOnRMV.Visible = false;
            bit_UploadedToRMV.Visible = false;
            str_Mother_Name.Visible = false;
            str_Guardians_Name.Visible = false;
            str_Mother_Phone.Visible = false;
            bit_terms.Visible = false;
            int_Nationality.SetVisibility();
            str_National_ID_en.Visible = false;
            str_National_ID_arabic.Visible = false;
            Quallification_Id.Visible = false;
            Job_Id.Visible = false;
            str_DOB_arabic.Visible = false;
            int_Language.Visible = false;
            strRefId.Visible = false;
            int_Program_Id.Visible = false;
            IsDrivingexperience.SetVisibility();
            IsScheduleassessment.SetVisibility();
            IsEnrollbyyourself.Visible = false;
            AssessmentTime.Visible = false;
            AssessmentDate.SetVisibility();
            isAssessmentDone.SetVisibility();
            AssessmentScore.SetVisibility();
            dt_WrittenTestPassed.SetVisibility();
            dt_RoadTestPassed.SetVisibility();
            bit_Archive.Visible = false;
            ArchiveNotes.Visible = false;
            dtArchived.Visible = false;
            SrNo9Dec21.Visible = false;
            REGNNUMB.Visible = false;
            REGNLOCN.Visible = false;
            SrNo11DecF1S1.Visible = false;
            IsInterestedInTraining.Visible = false;
            StudentEncryptID.Visible = false;
            StudentConfirURL.Visible = false;
            SrNo15DecF1S2.Visible = false;
            SrNo15DecF1S3.Visible = false;
            SrNo16DecF2S2.Visible = false;
            SrNo16DecF2S3.Visible = false;
            SrNo16DecF3S1.Visible = false;
            SrNo16DecF3S2.Visible = false;
            SrNo16DecF4S1.Visible = false;
            SrNo16DecF4S2.Visible = false;
            SrNo16DecF4S3.Visible = false;
            StudentAssementBookingURL.Visible = false;
            intDrivinglicenseType.Visible = false;
            Isdrivinglicense.Visible = false;
            drivinglicensenumber.Visible = false;
            Absher_Appointment_number.SetVisibility();
            DataImportId.Visible = false;
            date_Birth_Hijri.SetVisibility();
            UserlevelID.Visible = false;
            Activated.SetVisibility();
            Absherphoto.SetVisibility();
            Fingerprint.Visible = false;
            Required_Program.SetVisibility();
            Price.SetVisibility();
            Hijri_Day.SetVisibility();
            Hijri_Month.SetVisibility();
            Hijri_Year.SetVisibility();
            Course_Price.Visible = false;
            Vat_Tax_15.Visible = false;
            dec_Balance.SetVisibility();
            Total_Price.Visible = false;
            Payment_Online.SetVisibility();
            Institution.SetVisibility();
            WaitingList.SetVisibility();
            Assessment_ID.Visible = false;
        }

        // Constructor
        public TblPotentialStudentInfoEditBase(Controller? controller = null): this() { // DN
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
                            result.Add("view", pageName == "TblPotentialStudentInfoView" ? "1" : "0"); // If View page, no primary button
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
            key += UrlEncode(ConvertToString(dict.ContainsKey("int_Potential_Student_ID") ? dict["int_Potential_Student_ID"] : int_Potential_Student_ID.CurrentValue));
            return key;
        }

        // Hide fields for Add/Edit
        protected void HideFieldsForAddEdit() {
            if (IsAdd || IsCopy || IsGridAdd)
                int_Potential_Student_ID.Visible = false;
            if (IsAddOrEdit)
                Course_Price.Visible = false;
            if (IsAddOrEdit)
                Vat_Tax_15.Visible = false;
            if (IsAddOrEdit)
                Total_Price.Visible = false;
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

        public SubPages? MultiPages; // Multi pages object

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
            await SetupLookupOptions(int_State);
            await SetupLookupOptions(str_City);
            await SetupLookupOptions(int_Instructor);
            await SetupLookupOptions(int_Sex);
            await SetupLookupOptions(bit_IsDeleted);
            await SetupLookupOptions(strSMSNotification);
            await SetupLookupOptions(str_SpecialNeeds);
            await SetupLookupOptions(bit_PoliciesAndProcedures);
            await SetupLookupOptions(bit_IsSMSEnabled);
            await SetupLookupOptions(bit_EnrollmentForm);
            await SetupLookupOptions(bit_ParentStudentContract);
            await SetupLookupOptions(bit_ParentalAgreement);
            await SetupLookupOptions(bit_DisableOnRMV);
            await SetupLookupOptions(bit_UploadedToRMV);
            await SetupLookupOptions(bit_terms);
            await SetupLookupOptions(int_Program_Id);
            await SetupLookupOptions(IsDrivingexperience);
            await SetupLookupOptions(IsScheduleassessment);
            await SetupLookupOptions(IsEnrollbyyourself);
            await SetupLookupOptions(isAssessmentDone);
            await SetupLookupOptions(AssessmentScore);
            await SetupLookupOptions(dt_WrittenTestPassed);
            await SetupLookupOptions(dt_RoadTestPassed);
            await SetupLookupOptions(bit_Archive);
            await SetupLookupOptions(intDrivinglicenseType);
            await SetupLookupOptions(Isdrivinglicense);
            await SetupLookupOptions(Activated);
            await SetupLookupOptions(WaitingList);

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
                if (RouteValues.TryGetValue("int_Potential_Student_ID", out rv)) { // DN
                    int_Potential_Student_ID.FormValue = UrlDecode(rv); // DN
                    int_Potential_Student_ID.OldValue = int_Potential_Student_ID.FormValue;
                } else if (CurrentForm.HasValue("x_int_Potential_Student_ID")) {
                    int_Potential_Student_ID.FormValue = CurrentForm.GetValue("x_int_Potential_Student_ID");
                    int_Potential_Student_ID.OldValue = int_Potential_Student_ID.FormValue;
                } else if (!Empty(keyValues)) {
                    int_Potential_Student_ID.OldValue = ConvertToString(keyValues[0]);
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
                    if (RouteValues.TryGetValue("int_Potential_Student_ID", out rv)) { // DN
                        int_Potential_Student_ID.QueryValue = UrlDecode(rv); // DN
                        loadByQuery = true;
                    } else if (Get("int_Potential_Student_ID", out sv)) {
                        int_Potential_Student_ID.QueryValue = sv.ToString();
                        loadByQuery = true;
                    } else {
                        int_Potential_Student_ID.CurrentValue = DbNullValue;
                    }
                }

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
                int_Potential_Student_ID.FormValue = ConvertToString(keyValues[0]);
            }

            // Set up detail parameters
            SetupDetailParms();
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
                            return Terminate("TblPotentialStudentInfoList"); // No matching record, return to list
                        }

                    // Set up detail parameters
                    SetupDetailParms();
                    break;
                case "update": // Update // DN
                    CloseRecordset(); // DN
                    string returnUrl = "TblPotentialStudentInfoList";
                    if (GetPageName(returnUrl) == "TblPotentialStudentInfoList")
                        returnUrl = AddMasterUrl(ListUrl); // List page, return to List page with correct master key if necessary
                    SendEmail = true; // Send email on update success
                    var res = await EditRow();
                    if (res) { // Update record based on key
                        if (Empty(SuccessMessage))
                            SuccessMessage = Language.Phrase("UpdateSuccess"); // Update success

                        // Handle UseAjaxActions with return page
                        if (IsModal && UseAjaxActions) {
                            IsModal = false;
                            if (GetPageName(returnUrl) != "TblPotentialStudentInfoList") {
                                TempData["Return-Url"] = returnUrl; // Save return URL
                                returnUrl = "TblPotentialStudentInfoList"; // Return list page content
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

                        // Set up detail parameters
                        SetupDetailParms();
                    }
                    break;
            }

            // Set up Breadcrumb
            SetupBreadcrumb();

            // Render the record
            if (IsConfirm) { // Confirm page
                RowType = RowType.View; // Render as View
            } else {
                RowType = RowType.Edit; // Render as Edit
            }
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
                tblPotentialStudentInfoEdit?.PageRender();
            }
            return PageResult();
        }
        #pragma warning restore 219

        // Confirm page
        public bool ConfirmPage = true; // DN

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

            // Check field name 'str_NationalID_Iqama' before field var 'x_str_NationalID_Iqama'
            val = CurrentForm.HasValue("str_NationalID_Iqama") ? CurrentForm.GetValue("str_NationalID_Iqama") : CurrentForm.GetValue("x_str_NationalID_Iqama");
            if (!str_NationalID_Iqama.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_NationalID_Iqama") && !CurrentForm.HasValue("x_str_NationalID_Iqama")) // DN
                    str_NationalID_Iqama.Visible = false; // Disable update for API request
                else
                    str_NationalID_Iqama.SetFormValue(val);
            }

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

            // Check field name 'str_Address1' before field var 'x_str_Address1'
            val = CurrentForm.HasValue("str_Address1") ? CurrentForm.GetValue("str_Address1") : CurrentForm.GetValue("x_str_Address1");
            if (!str_Address1.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Address1") && !CurrentForm.HasValue("x_str_Address1")) // DN
                    str_Address1.Visible = false; // Disable update for API request
                else
                    str_Address1.SetFormValue(val);
            }

            // Check field name 'str_Address2' before field var 'x_str_Address2'
            val = CurrentForm.HasValue("str_Address2") ? CurrentForm.GetValue("str_Address2") : CurrentForm.GetValue("x_str_Address2");
            if (!str_Address2.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Address2") && !CurrentForm.HasValue("x_str_Address2")) // DN
                    str_Address2.Visible = false; // Disable update for API request
                else
                    str_Address2.SetFormValue(val);
            }

            // Check field name 'int_State' before field var 'x_int_State'
            val = CurrentForm.HasValue("int_State") ? CurrentForm.GetValue("int_State") : CurrentForm.GetValue("x_int_State");
            if (!int_State.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_State") && !CurrentForm.HasValue("x_int_State")) // DN
                    int_State.Visible = false; // Disable update for API request
                else
                    int_State.SetFormValue(val);
            }

            // Check field name 'str_City' before field var 'x_str_City'
            val = CurrentForm.HasValue("str_City") ? CurrentForm.GetValue("str_City") : CurrentForm.GetValue("x_str_City");
            if (!str_City.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_City") && !CurrentForm.HasValue("x_str_City")) // DN
                    str_City.Visible = false; // Disable update for API request
                else
                    str_City.SetFormValue(val);
            }

            // Check field name 'str_Zip' before field var 'x_str_Zip'
            val = CurrentForm.HasValue("str_Zip") ? CurrentForm.GetValue("str_Zip") : CurrentForm.GetValue("x_str_Zip");
            if (!str_Zip.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Zip") && !CurrentForm.HasValue("x_str_Zip")) // DN
                    str_Zip.Visible = false; // Disable update for API request
                else
                    str_Zip.SetFormValue(val);
            }

            // Check field name 'str_Home_Phone' before field var 'x_str_Home_Phone'
            val = CurrentForm.HasValue("str_Home_Phone") ? CurrentForm.GetValue("str_Home_Phone") : CurrentForm.GetValue("x_str_Home_Phone");
            if (!str_Home_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Home_Phone") && !CurrentForm.HasValue("x_str_Home_Phone")) // DN
                    str_Home_Phone.Visible = false; // Disable update for API request
                else
                    str_Home_Phone.SetFormValue(val);
            }

            // Check field name 'str_Cell_Phone' before field var 'x_str_Cell_Phone'
            val = CurrentForm.HasValue("str_Cell_Phone") ? CurrentForm.GetValue("str_Cell_Phone") : CurrentForm.GetValue("x_str_Cell_Phone");
            if (!str_Cell_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Cell_Phone") && !CurrentForm.HasValue("x_str_Cell_Phone")) // DN
                    str_Cell_Phone.Visible = false; // Disable update for API request
                else
                    str_Cell_Phone.SetFormValue(val);
            }

            // Check field name 'str_Parent_Phone' before field var 'x_str_Parent_Phone'
            val = CurrentForm.HasValue("str_Parent_Phone") ? CurrentForm.GetValue("str_Parent_Phone") : CurrentForm.GetValue("x_str_Parent_Phone");
            if (!str_Parent_Phone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Parent_Phone") && !CurrentForm.HasValue("x_str_Parent_Phone")) // DN
                    str_Parent_Phone.Visible = false; // Disable update for API request
                else
                    str_Parent_Phone.SetFormValue(val);
            }

            // Check field name 'str_Email' before field var 'x_str_Email'
            val = CurrentForm.HasValue("str_Email") ? CurrentForm.GetValue("str_Email") : CurrentForm.GetValue("x_str_Email");
            if (!str_Email.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Email") && !CurrentForm.HasValue("x_str_Email")) // DN
                    str_Email.Visible = false; // Disable update for API request
                else
                    str_Email.SetFormValue(val);
            }

            // Check field name 'str_ParentName' before field var 'x_str_ParentName'
            val = CurrentForm.HasValue("str_ParentName") ? CurrentForm.GetValue("str_ParentName") : CurrentForm.GetValue("x_str_ParentName");
            if (!str_ParentName.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_ParentName") && !CurrentForm.HasValue("x_str_ParentName")) // DN
                    str_ParentName.Visible = false; // Disable update for API request
                else
                    str_ParentName.SetFormValue(val);
            }

            // Check field name 'str_DOB' before field var 'x_str_DOB'
            val = CurrentForm.HasValue("str_DOB") ? CurrentForm.GetValue("str_DOB") : CurrentForm.GetValue("x_str_DOB");
            if (!str_DOB.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_DOB") && !CurrentForm.HasValue("x_str_DOB")) // DN
                    str_DOB.Visible = false; // Disable update for API request
                else
                    str_DOB.SetFormValue(val);
                str_DOB.CurrentValue = UnformatDateTime(str_DOB.CurrentValue, str_DOB.FormatPattern);
            }

            // Check field name 'int_Age' before field var 'x_int_Age'
            val = CurrentForm.HasValue("int_Age") ? CurrentForm.GetValue("int_Age") : CurrentForm.GetValue("x_int_Age");
            if (!int_Age.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Age") && !CurrentForm.HasValue("x_int_Age")) // DN
                    int_Age.Visible = false; // Disable update for API request
                else
                    int_Age.SetFormValue(val);
            }

            // Check field name 'int_Sex' before field var 'x_int_Sex'
            val = CurrentForm.HasValue("int_Sex") ? CurrentForm.GetValue("int_Sex") : CurrentForm.GetValue("x_int_Sex");
            if (!int_Sex.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Sex") && !CurrentForm.HasValue("x_int_Sex")) // DN
                    int_Sex.Visible = false; // Disable update for API request
                else
                    int_Sex.SetFormValue(val);
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

            // Check field name 'str_Student_Notes' before field var 'x_str_Student_Notes'
            val = CurrentForm.HasValue("str_Student_Notes") ? CurrentForm.GetValue("str_Student_Notes") : CurrentForm.GetValue("x_str_Student_Notes");
            if (!str_Student_Notes.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Student_Notes") && !CurrentForm.HasValue("x_str_Student_Notes")) // DN
                    str_Student_Notes.Visible = false; // Disable update for API request
                else
                    str_Student_Notes.SetFormValue(val);
            }

            // Check field name 'int_Location_Id' before field var 'x_int_Location_Id'
            val = CurrentForm.HasValue("int_Location_Id") ? CurrentForm.GetValue("int_Location_Id") : CurrentForm.GetValue("x_int_Location_Id");
            if (!int_Location_Id.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Location_Id") && !CurrentForm.HasValue("x_int_Location_Id")) // DN
                    int_Location_Id.Visible = false; // Disable update for API request
                else
                    int_Location_Id.SetFormValue(val);
            }

            // Check field name 'date_Activated' before field var 'x_date_Activated'
            val = CurrentForm.HasValue("date_Activated") ? CurrentForm.GetValue("date_Activated") : CurrentForm.GetValue("x_date_Activated");
            if (!date_Activated.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Activated") && !CurrentForm.HasValue("x_date_Activated")) // DN
                    date_Activated.Visible = false; // Disable update for API request
                else
                    date_Activated.SetFormValue(val);
                date_Activated.CurrentValue = UnformatDateTime(date_Activated.CurrentValue, date_Activated.FormatPattern);
            }

            // Check field name 'date_Created' before field var 'x_date_Created'
            val = CurrentForm.HasValue("date_Created") ? CurrentForm.GetValue("date_Created") : CurrentForm.GetValue("x_date_Created");
            if (!date_Created.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Created") && !CurrentForm.HasValue("x_date_Created")) // DN
                    date_Created.Visible = false; // Disable update for API request
                else
                    date_Created.SetFormValue(val);
                date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            }

            // Check field name 'date_Modified' before field var 'x_date_Modified'
            val = CurrentForm.HasValue("date_Modified") ? CurrentForm.GetValue("date_Modified") : CurrentForm.GetValue("x_date_Modified");
            if (!date_Modified.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Modified") && !CurrentForm.HasValue("x_date_Modified")) // DN
                    date_Modified.Visible = false; // Disable update for API request
                else
                    date_Modified.SetFormValue(val);
                date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            }

            // Check field name 'strSMSNotification' before field var 'x_strSMSNotification'
            val = CurrentForm.HasValue("strSMSNotification") ? CurrentForm.GetValue("strSMSNotification") : CurrentForm.GetValue("x_strSMSNotification");
            if (!strSMSNotification.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("strSMSNotification") && !CurrentForm.HasValue("x_strSMSNotification")) // DN
                    strSMSNotification.Visible = false; // Disable update for API request
                else
                    strSMSNotification.SetFormValue(val);
            }

            // Check field name 'str_Weight' before field var 'x_str_Weight'
            val = CurrentForm.HasValue("str_Weight") ? CurrentForm.GetValue("str_Weight") : CurrentForm.GetValue("x_str_Weight");
            if (!str_Weight.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_Weight") && !CurrentForm.HasValue("x_str_Weight")) // DN
                    str_Weight.Visible = false; // Disable update for API request
                else
                    str_Weight.SetFormValue(val);
            }

            // Check field name 'str_SpecialNeeds' before field var 'x_str_SpecialNeeds'
            val = CurrentForm.HasValue("str_SpecialNeeds") ? CurrentForm.GetValue("str_SpecialNeeds") : CurrentForm.GetValue("x_str_SpecialNeeds");
            if (!str_SpecialNeeds.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_SpecialNeeds") && !CurrentForm.HasValue("x_str_SpecialNeeds")) // DN
                    str_SpecialNeeds.Visible = false; // Disable update for API request
                else
                    str_SpecialNeeds.SetFormValue(val);
            }

            // Check field name 'str_MedicalConditions' before field var 'x_str_MedicalConditions'
            val = CurrentForm.HasValue("str_MedicalConditions") ? CurrentForm.GetValue("str_MedicalConditions") : CurrentForm.GetValue("x_str_MedicalConditions");
            if (!str_MedicalConditions.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("str_MedicalConditions") && !CurrentForm.HasValue("x_str_MedicalConditions")) // DN
                    str_MedicalConditions.Visible = false; // Disable update for API request
                else
                    str_MedicalConditions.SetFormValue(val);
            }

            // Check field name 'int_Nationality' before field var 'x_int_Nationality'
            val = CurrentForm.HasValue("int_Nationality") ? CurrentForm.GetValue("int_Nationality") : CurrentForm.GetValue("x_int_Nationality");
            if (!int_Nationality.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("int_Nationality") && !CurrentForm.HasValue("x_int_Nationality")) // DN
                    int_Nationality.Visible = false; // Disable update for API request
                else
                    int_Nationality.SetFormValue(val);
            }

            // Check field name 'IsDrivingexperience' before field var 'x_IsDrivingexperience'
            val = CurrentForm.HasValue("IsDrivingexperience") ? CurrentForm.GetValue("IsDrivingexperience") : CurrentForm.GetValue("x_IsDrivingexperience");
            if (!IsDrivingexperience.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsDrivingexperience") && !CurrentForm.HasValue("x_IsDrivingexperience")) // DN
                    IsDrivingexperience.Visible = false; // Disable update for API request
                else
                    IsDrivingexperience.SetFormValue(val);
            }

            // Check field name 'IsScheduleassessment' before field var 'x_IsScheduleassessment'
            val = CurrentForm.HasValue("IsScheduleassessment") ? CurrentForm.GetValue("IsScheduleassessment") : CurrentForm.GetValue("x_IsScheduleassessment");
            if (!IsScheduleassessment.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("IsScheduleassessment") && !CurrentForm.HasValue("x_IsScheduleassessment")) // DN
                    IsScheduleassessment.Visible = false; // Disable update for API request
                else
                    IsScheduleassessment.SetFormValue(val);
            }

            // Check field name 'AssessmentDate' before field var 'x_AssessmentDate'
            val = CurrentForm.HasValue("AssessmentDate") ? CurrentForm.GetValue("AssessmentDate") : CurrentForm.GetValue("x_AssessmentDate");
            if (!AssessmentDate.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AssessmentDate") && !CurrentForm.HasValue("x_AssessmentDate")) // DN
                    AssessmentDate.Visible = false; // Disable update for API request
                else
                    AssessmentDate.SetFormValue(val);
                AssessmentDate.CurrentValue = UnformatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern);
            }

            // Check field name 'isAssessmentDone' before field var 'x_isAssessmentDone'
            val = CurrentForm.HasValue("isAssessmentDone") ? CurrentForm.GetValue("isAssessmentDone") : CurrentForm.GetValue("x_isAssessmentDone");
            if (!isAssessmentDone.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("isAssessmentDone") && !CurrentForm.HasValue("x_isAssessmentDone")) // DN
                    isAssessmentDone.Visible = false; // Disable update for API request
                else
                    isAssessmentDone.SetFormValue(val);
            }

            // Check field name 'AssessmentScore' before field var 'x_AssessmentScore'
            val = CurrentForm.HasValue("AssessmentScore") ? CurrentForm.GetValue("AssessmentScore") : CurrentForm.GetValue("x_AssessmentScore");
            if (!AssessmentScore.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("AssessmentScore") && !CurrentForm.HasValue("x_AssessmentScore")) // DN
                    AssessmentScore.Visible = false; // Disable update for API request
                else
                    AssessmentScore.SetFormValue(val);
            }

            // Check field name 'dt_WrittenTestPassed' before field var 'x_dt_WrittenTestPassed[]'
            val = CurrentForm.HasValue("dt_WrittenTestPassed") ? CurrentForm.GetValue("dt_WrittenTestPassed") : CurrentForm.GetValue("x_dt_WrittenTestPassed[]");
            if (!dt_WrittenTestPassed.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dt_WrittenTestPassed") && !CurrentForm.HasValue("x_dt_WrittenTestPassed[]")) // DN
                    dt_WrittenTestPassed.Visible = false; // Disable update for API request
                else
                    dt_WrittenTestPassed.SetFormValue(val);
                dt_WrittenTestPassed.CurrentValue = UnformatDateTime(dt_WrittenTestPassed.CurrentValue, dt_WrittenTestPassed.FormatPattern);
            }

            // Check field name 'dt_RoadTestPassed' before field var 'x_dt_RoadTestPassed[]'
            val = CurrentForm.HasValue("dt_RoadTestPassed") ? CurrentForm.GetValue("dt_RoadTestPassed") : CurrentForm.GetValue("x_dt_RoadTestPassed[]");
            if (!dt_RoadTestPassed.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dt_RoadTestPassed") && !CurrentForm.HasValue("x_dt_RoadTestPassed[]")) // DN
                    dt_RoadTestPassed.Visible = false; // Disable update for API request
                else
                    dt_RoadTestPassed.SetFormValue(val);
                dt_RoadTestPassed.CurrentValue = UnformatDateTime(dt_RoadTestPassed.CurrentValue, dt_RoadTestPassed.FormatPattern);
            }

            // Check field name 'Absher_Appointment_number' before field var 'x_Absher_Appointment_number'
            val = CurrentForm.HasValue("Absher_Appointment_number") ? CurrentForm.GetValue("Absher_Appointment_number") : CurrentForm.GetValue("x_Absher_Appointment_number");
            if (!Absher_Appointment_number.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Absher_Appointment_number") && !CurrentForm.HasValue("x_Absher_Appointment_number")) // DN
                    Absher_Appointment_number.Visible = false; // Disable update for API request
                else
                    Absher_Appointment_number.SetFormValue(val);
            }

            // Check field name 'date_Birth_Hijri' before field var 'x_date_Birth_Hijri'
            val = CurrentForm.HasValue("date_Birth_Hijri") ? CurrentForm.GetValue("date_Birth_Hijri") : CurrentForm.GetValue("x_date_Birth_Hijri");
            if (!date_Birth_Hijri.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("date_Birth_Hijri") && !CurrentForm.HasValue("x_date_Birth_Hijri")) // DN
                    date_Birth_Hijri.Visible = false; // Disable update for API request
                else
                    date_Birth_Hijri.SetFormValue(val);
            }

            // Check field name 'Activated' before field var 'x_Activated'
            val = CurrentForm.HasValue("Activated") ? CurrentForm.GetValue("Activated") : CurrentForm.GetValue("x_Activated");
            if (!Activated.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Activated") && !CurrentForm.HasValue("x_Activated")) // DN
                    Activated.Visible = false; // Disable update for API request
                else
                    Activated.SetFormValue(val);
            }

            // Check field name 'Absherphoto' before field var 'x_Absherphoto'
            val = CurrentForm.HasValue("Absherphoto") ? CurrentForm.GetValue("Absherphoto") : CurrentForm.GetValue("x_Absherphoto");
            if (!Absherphoto.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Absherphoto") && !CurrentForm.HasValue("x_Absherphoto")) // DN
                    Absherphoto.Visible = false; // Disable update for API request
                else
                    Absherphoto.SetFormValue(val);
            }

            // Check field name 'Required_Program' before field var 'x_Required_Program'
            val = CurrentForm.HasValue("Required_Program") ? CurrentForm.GetValue("Required_Program") : CurrentForm.GetValue("x_Required_Program");
            if (!Required_Program.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Required_Program") && !CurrentForm.HasValue("x_Required_Program")) // DN
                    Required_Program.Visible = false; // Disable update for API request
                else
                    Required_Program.SetFormValue(val);
            }

            // Check field name 'Price' before field var 'x_Price'
            val = CurrentForm.HasValue("Price") ? CurrentForm.GetValue("Price") : CurrentForm.GetValue("x_Price");
            if (!Price.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Price") && !CurrentForm.HasValue("x_Price")) // DN
                    Price.Visible = false; // Disable update for API request
                else
                    Price.SetFormValue(val);
            }

            // Check field name 'Hijri_Day' before field var 'x_Hijri_Day'
            val = CurrentForm.HasValue("Hijri_Day") ? CurrentForm.GetValue("Hijri_Day") : CurrentForm.GetValue("x_Hijri_Day");
            if (!Hijri_Day.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Day") && !CurrentForm.HasValue("x_Hijri_Day")) // DN
                    Hijri_Day.Visible = false; // Disable update for API request
                else
                    Hijri_Day.SetFormValue(val);
            }

            // Check field name 'Hijri_Month' before field var 'x_Hijri_Month'
            val = CurrentForm.HasValue("Hijri_Month") ? CurrentForm.GetValue("Hijri_Month") : CurrentForm.GetValue("x_Hijri_Month");
            if (!Hijri_Month.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Month") && !CurrentForm.HasValue("x_Hijri_Month")) // DN
                    Hijri_Month.Visible = false; // Disable update for API request
                else
                    Hijri_Month.SetFormValue(val);
            }

            // Check field name 'Hijri_Year' before field var 'x_Hijri_Year'
            val = CurrentForm.HasValue("Hijri_Year") ? CurrentForm.GetValue("Hijri_Year") : CurrentForm.GetValue("x_Hijri_Year");
            if (!Hijri_Year.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Hijri_Year") && !CurrentForm.HasValue("x_Hijri_Year")) // DN
                    Hijri_Year.Visible = false; // Disable update for API request
                else
                    Hijri_Year.SetFormValue(val);
            }

            // Check field name 'dec_Balance' before field var 'x_dec_Balance'
            val = CurrentForm.HasValue("dec_Balance") ? CurrentForm.GetValue("dec_Balance") : CurrentForm.GetValue("x_dec_Balance");
            if (!dec_Balance.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("dec_Balance") && !CurrentForm.HasValue("x_dec_Balance")) // DN
                    dec_Balance.Visible = false; // Disable update for API request
                else
                    dec_Balance.SetFormValue(val);
            }

            // Check field name 'Payment_Online' before field var 'x_Payment_Online'
            val = CurrentForm.HasValue("Payment_Online") ? CurrentForm.GetValue("Payment_Online") : CurrentForm.GetValue("x_Payment_Online");
            if (!Payment_Online.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Payment_Online") && !CurrentForm.HasValue("x_Payment_Online")) // DN
                    Payment_Online.Visible = false; // Disable update for API request
                else
                    Payment_Online.SetFormValue(val);
            }

            // Check field name 'Institution' before field var 'x_Institution'
            val = CurrentForm.HasValue("Institution") ? CurrentForm.GetValue("Institution") : CurrentForm.GetValue("x_Institution");
            if (!Institution.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("Institution") && !CurrentForm.HasValue("x_Institution")) // DN
                    Institution.Visible = false; // Disable update for API request
                else
                    Institution.SetFormValue(val);
            }

            // Check field name 'WaitingList' before field var 'x_WaitingList'
            val = CurrentForm.HasValue("WaitingList") ? CurrentForm.GetValue("WaitingList") : CurrentForm.GetValue("x_WaitingList");
            if (!WaitingList.IsDetailKey) {
                if (IsApi() && !CurrentForm.HasValue("WaitingList") && !CurrentForm.HasValue("x_WaitingList")) // DN
                    WaitingList.Visible = false; // Disable update for API request
                else
                    WaitingList.SetFormValue(val);
            }

            // Check field name 'int_Potential_Student_ID' before field var 'x_int_Potential_Student_ID'
            val = CurrentForm.HasValue("int_Potential_Student_ID") ? CurrentForm.GetValue("int_Potential_Student_ID") : CurrentForm.GetValue("x_int_Potential_Student_ID");
            if (!int_Potential_Student_ID.IsDetailKey)
                int_Potential_Student_ID.SetFormValue(val);
            ResetDetailParms();
        }
        #pragma warning restore 1998

        // Restore form values
        public void RestoreFormValues()
        {
            int_Potential_Student_ID.CurrentValue = int_Potential_Student_ID.FormValue;
            str_NationalID_Iqama.CurrentValue = str_NationalID_Iqama.FormValue;
            str_First_Name.CurrentValue = str_First_Name.FormValue;
            str_Middle_Name.CurrentValue = str_Middle_Name.FormValue;
            str_Last_Name.CurrentValue = str_Last_Name.FormValue;
            str_Address1.CurrentValue = str_Address1.FormValue;
            str_Address2.CurrentValue = str_Address2.FormValue;
            int_State.CurrentValue = int_State.FormValue;
            str_City.CurrentValue = str_City.FormValue;
            str_Zip.CurrentValue = str_Zip.FormValue;
            str_Home_Phone.CurrentValue = str_Home_Phone.FormValue;
            str_Cell_Phone.CurrentValue = str_Cell_Phone.FormValue;
            str_Parent_Phone.CurrentValue = str_Parent_Phone.FormValue;
            str_Email.CurrentValue = str_Email.FormValue;
            str_ParentName.CurrentValue = str_ParentName.FormValue;
            str_DOB.CurrentValue = str_DOB.FormValue;
            str_DOB.CurrentValue = UnformatDateTime(str_DOB.CurrentValue, str_DOB.FormatPattern);
            int_Age.CurrentValue = int_Age.FormValue;
            int_Sex.CurrentValue = int_Sex.FormValue;
            str_Emergency_Contact_Name.CurrentValue = str_Emergency_Contact_Name.FormValue;
            str_Emergency_Contact_Phone.CurrentValue = str_Emergency_Contact_Phone.FormValue;
            str_Emergency_Contact_Relation.CurrentValue = str_Emergency_Contact_Relation.FormValue;
            str_Student_Notes.CurrentValue = str_Student_Notes.FormValue;
            int_Location_Id.CurrentValue = int_Location_Id.FormValue;
            date_Activated.CurrentValue = date_Activated.FormValue;
            date_Activated.CurrentValue = UnformatDateTime(date_Activated.CurrentValue, date_Activated.FormatPattern);
            date_Created.CurrentValue = date_Created.FormValue;
            date_Created.CurrentValue = UnformatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);
            date_Modified.CurrentValue = date_Modified.FormValue;
            date_Modified.CurrentValue = UnformatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);
            strSMSNotification.CurrentValue = strSMSNotification.FormValue;
            str_Weight.CurrentValue = str_Weight.FormValue;
            str_SpecialNeeds.CurrentValue = str_SpecialNeeds.FormValue;
            str_MedicalConditions.CurrentValue = str_MedicalConditions.FormValue;
            int_Nationality.CurrentValue = int_Nationality.FormValue;
            IsDrivingexperience.CurrentValue = IsDrivingexperience.FormValue;
            IsScheduleassessment.CurrentValue = IsScheduleassessment.FormValue;
            AssessmentDate.CurrentValue = AssessmentDate.FormValue;
            AssessmentDate.CurrentValue = UnformatDateTime(AssessmentDate.CurrentValue, AssessmentDate.FormatPattern);
            isAssessmentDone.CurrentValue = isAssessmentDone.FormValue;
            AssessmentScore.CurrentValue = AssessmentScore.FormValue;
            dt_WrittenTestPassed.CurrentValue = dt_WrittenTestPassed.FormValue;
            dt_WrittenTestPassed.CurrentValue = UnformatDateTime(dt_WrittenTestPassed.CurrentValue, dt_WrittenTestPassed.FormatPattern);
            dt_RoadTestPassed.CurrentValue = dt_RoadTestPassed.FormValue;
            dt_RoadTestPassed.CurrentValue = UnformatDateTime(dt_RoadTestPassed.CurrentValue, dt_RoadTestPassed.FormatPattern);
            Absher_Appointment_number.CurrentValue = Absher_Appointment_number.FormValue;
            date_Birth_Hijri.CurrentValue = date_Birth_Hijri.FormValue;
            Activated.CurrentValue = Activated.FormValue;
            Absherphoto.CurrentValue = Absherphoto.FormValue;
            Required_Program.CurrentValue = Required_Program.FormValue;
            Price.CurrentValue = Price.FormValue;
            Hijri_Day.CurrentValue = Hijri_Day.FormValue;
            Hijri_Month.CurrentValue = Hijri_Month.FormValue;
            Hijri_Year.CurrentValue = Hijri_Year.FormValue;
            dec_Balance.CurrentValue = dec_Balance.FormValue;
            Payment_Online.CurrentValue = Payment_Online.FormValue;
            Institution.CurrentValue = Institution.FormValue;
            WaitingList.CurrentValue = WaitingList.FormValue;
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
            int_Potential_Student_ID.SetDbValue(row["int_Potential_Student_ID"]);
            int_Student_Id.SetDbValue(row["int_Student_Id"]);
            str_NationalID_Iqama.SetDbValue(row["str_NationalID_Iqama"]);
            NationalID.SetDbValue(row["NationalID"]);
            str_First_Name.SetDbValue(row["str_First_Name"]);
            str_Middle_Name.SetDbValue(row["str_Middle_Name"]);
            str_Last_Name.SetDbValue(row["str_Last_Name"]);
            str_Address1.SetDbValue(row["str_Address1"]);
            str_Address2.SetDbValue(row["str_Address2"]);
            int_State.SetDbValue(row["int_State"]);
            str_City.SetDbValue(row["str_City"]);
            str_Zip.SetDbValue(row["str_Zip"]);
            int_Instructor.SetDbValue(IsNull(row["int_Instructor"]) ? DbNullValue : ConvertToDouble(row["int_Instructor"]));
            int_Driver.SetDbValue(IsNull(row["int_Driver"]) ? DbNullValue : ConvertToDouble(row["int_Driver"]));
            str_Home_Phone.SetDbValue(row["str_Home_Phone"]);
            str_Cell_Phone.SetDbValue(row["str_Cell_Phone"]);
            str_Parent_Phone.SetDbValue(row["str_Parent_Phone"]);
            str_Other_Phone.SetDbValue(row["str_Other_Phone"]);
            str_Email.SetDbValue(row["str_Email"]);
            str_ParentName.SetDbValue(row["str_ParentName"]);
            str_ParentEmail1.SetDbValue(row["str_ParentEmail1"]);
            str_ParentEmail2.SetDbValue(row["str_ParentEmail2"]);
            str_Username.SetDbValue(row["str_Username"]);
            str_Password.SetDbValue(row["str_Password"]);
            str_DOB.SetDbValue(row["str_DOB"]);
            int_DOB_Day.SetDbValue(row["int_DOB_Day"]);
            int_DOB_Month.SetDbValue(row["int_DOB_Month"]);
            int_DOB_Year.SetDbValue(row["int_DOB_Year"]);
            int_Age.SetDbValue(row["int_Age"]);
            int_Type.SetDbValue(row["int_Type"]);
            int_Wear_Glasses.SetDbValue(row["int_Wear_Glasses"]);
            int_Sex.SetDbValue(row["int_Sex"]);
            str_DLPermit.SetDbValue(row["str_DLPermit"]);
            dt_Date_PermitIssue.SetDbValue(row["dt_Date_PermitIssue"]);
            dt_Date_ExpirePermit.SetDbValue(row["dt_Date_ExpirePermit"]);
            int_Hs_ID.SetDbValue(row["int_Hs_ID"]);
            str_Emergency_Contact_Name.SetDbValue(row["str_Emergency_Contact_Name"]);
            str_Emergency_Contact_Phone.SetDbValue(row["str_Emergency_Contact_Phone"]);
            str_Emergency_Contact_Relation.SetDbValue(row["str_Emergency_Contact_Relation"]);
            str_Student_Notes.SetDbValue(row["str_Student_Notes"]);
            str_Driving_Notes.SetDbValue(row["str_Driving_Notes"]);
            int_Location_Id.SetDbValue(row["int_Location_Id"]);
            int_Permit_Number.SetDbValue(row["int_Permit_Number"]);
            Permit_Issue_Date.SetDbValue(row["Permit_Issue_Date"]);
            Permit_Expiry_Date.SetDbValue(row["Permit_Expiry_Date"]);
            int_Status.SetDbValue(row["int_Status"]);
            int_Lead_Id.SetDbValue(IsNull(row["int_Lead_Id"]) ? DbNullValue : ConvertToDouble(row["int_Lead_Id"]));
            int_Activated_By.SetDbValue(IsNull(row["int_Activated_By"]) ? DbNullValue : ConvertToDouble(row["int_Activated_By"]));
            date_Activated.SetDbValue(row["date_Activated"]);
            date_Created.SetDbValue(row["date_Created"]);
            date_Modified.SetDbValue(row["date_Modified"]);
            date_Complete.SetDbValue(row["date_Complete"]);
            int_Created_By.SetDbValue(row["int_Created_By"]);
            int_Modified_By.SetDbValue(row["int_Modified_By"]);
            bit_IsDeleted.SetDbValue((ConvertToBool(row["bit_IsDeleted"]) ? "1" : "0"));
            str_CardHolderName.SetDbValue(row["str_CardHolderName"]);
            str_CardHolderAddress.SetDbValue(row["str_CardHolderAddress"]);
            str_CardHolderCity.SetDbValue(row["str_CardHolderCity"]);
            str_CardHolderZip.SetDbValue(row["str_CardHolderZip"]);
            str_CardType.SetDbValue(row["str_CardType"]);
            str_CardExpMonth.SetDbValue(row["str_CardExpMonth"]);
            str_CardExpYear.SetDbValue(row["str_CardExpYear"]);
            str_CardNo.SetDbValue(row["str_CardNo"]);
            str_Certificate_No.SetDbValue(row["str_Certificate_No"]);
            str_AmountPaid.SetDbValue(IsNull(row["str_AmountPaid"]) ? DbNullValue : ConvertToDouble(row["str_AmountPaid"]));
            str_PermitValidated.SetDbValue(row["str_PermitValidated"]);
            strSMSNotification.SetDbValue(row["strSMSNotification"]);
            strVoiceNotification.SetDbValue(row["strVoiceNotification"]);
            str_Weight.SetDbValue(row["str_Weight"]);
            str_SpecialNeeds.SetDbValue(row["str_SpecialNeeds"]);
            str_MedicalConditions.SetDbValue(row["str_MedicalConditions"]);
            bit_Verified_PIC_InSAW.SetDbValue(row["bit_Verified_PIC_InSAW"]);
            bit_Permit_Waiver_Entered.SetDbValue(row["bit_Permit_Waiver_Entered"]);
            bit_TermsConditions.SetDbValue(row["bit_TermsConditions"]);
            bit_Disable_Self_Scheduling.SetDbValue(row["bit_Disable_Self_Scheduling"]);
            int_EyeColor.SetDbValue(row["int_EyeColor"]);
            int_HairColor.SetDbValue(row["int_HairColor"]);
            int_ColorBlind.SetDbValue(row["int_ColorBlind"]);
            int_HeightFeet.SetDbValue(row["int_HeightFeet"]);
            int_HeightInches.SetDbValue(row["int_HeightInches"]);
            str_reference_code.SetDbValue(row["str_reference_code"]);
            dt_ParentClassAttendedDt.SetDbValue(row["dt_ParentClassAttendedDt"]);
            str_ParentClassAttendedLoc.SetDbValue(row["str_ParentClassAttendedLoc"]);
            dt_SiblingClassAttendedDt.SetDbValue(row["dt_SiblingClassAttendedDt"]);
            str_SiblingClassAttendedLoc.SetDbValue(row["str_SiblingClassAttendedLoc"]);
            bit_PoliciesAndProcedures.SetDbValue((ConvertToBool(row["bit_PoliciesAndProcedures"]) ? "1" : "0"));
            dt_CourseCompletionDt.SetDbValue(row["dt_CourseCompletionDt"]);
            dt_ExtensionDt.SetDbValue(row["dt_ExtensionDt"]);
            str_MedicalCondition.SetDbValue(row["str_MedicalCondition"]);
            str_MajorCrossStreets.SetDbValue(row["str_MajorCrossStreets"]);
            str_DriverEdCertNo.SetDbValue(row["str_DriverEdCertNo"]);
            dt_DriverEdCertIssuedDt.SetDbValue(row["dt_DriverEdCertIssuedDt"]);
            str_BTWDriversEdCertNo.SetDbValue(row["str_BTWDriversEdCertNo"]);
            dt_BTWCertIssuedDt.SetDbValue(row["dt_BTWCertIssuedDt"]);
            str_OLDriversEdCertNo.SetDbValue(row["str_OLDriversEdCertNo"]);
            dt_OLCertIssuedDt.SetDbValue(row["dt_OLCertIssuedDt"]);
            str_height.SetDbValue(row["str_height"]);
            dt_BTWCompletionDt.SetDbValue(row["dt_BTWCompletionDt"]);
            dt_CRCompletionDt.SetDbValue(row["dt_CRCompletionDt"]);
            strTextBox5.SetDbValue(row["strTextBox5"]);
            strTextBox6.SetDbValue(row["strTextBox6"]);
            str_ApartmentNo.SetDbValue(row["str_ApartmentNo"]);
            dt_PermitTestDate.SetDbValue(row["dt_PermitTestDate"]);
            str_OnlineDriverEdLogin.SetDbValue(row["str_OnlineDriverEdLogin"]);
            str_OnlineDriverEdPassword.SetDbValue(row["str_OnlineDriverEdPassword"]);
            bit_IsSMSEnabled.SetDbValue((ConvertToBool(row["bit_IsSMSEnabled"]) ? "1" : "0"));
            dt_SMSModified.SetDbValue(row["dt_SMSModified"]);
            str_confirmPassword.SetDbValue(row["str_confirmPassword"]);
            DE_Certificate.SetDbValue(row["DE_Certificate"]);
            Discuss.SetDbValue(row["Discuss"]);
            int_UnlicensedSibling.SetDbValue(row["int_UnlicensedSibling"]);
            int_YearSiblingIsEligible.SetDbValue(row["int_YearSiblingIsEligible"]);
            BTW_Certificate.SetDbValue(row["BTW_Certificate"]);
            dt_DECertIssueDate.SetDbValue(row["dt_DECertIssueDate"]);
            str_StudentSignature.SetDbValue(row["str_StudentSignature"]);
            str_ParentSignature.SetDbValue(row["str_ParentSignature"]);
            str_Last6DigitsOfParentDriversLicense.SetDbValue(row["str_Last6DigitsOfParentDriversLicense"]);
            str_FACControl.SetDbValue(row["str_FACControl"]);
            Classroom_Status_Code.SetDbValue(row["Classroom_Status_Code"]);
            Laboratory_Status_Code.SetDbValue(row["Laboratory_Status_Code"]);
            bit_EnrollmentForm.SetDbValue((ConvertToBool(row["bit_EnrollmentForm"]) ? "1" : "0"));
            bit_ParentStudentContract.SetDbValue((ConvertToBool(row["bit_ParentStudentContract"]) ? "1" : "0"));
            bit_ParentalAgreement.SetDbValue((ConvertToBool(row["bit_ParentalAgreement"]) ? "1" : "0"));
            int_SF_GR_WA_HS.SetDbValue(row["int_SF_GR_WA_HS"]);
            bit_DisableOnRMV.SetDbValue((ConvertToBool(row["bit_DisableOnRMV"]) ? "1" : "0"));
            bit_UploadedToRMV.SetDbValue((ConvertToBool(row["bit_UploadedToRMV"]) ? "1" : "0"));
            str_Mother_Name.SetDbValue(row["str_Mother_Name"]);
            str_Guardians_Name.SetDbValue(row["str_Guardians_Name"]);
            str_Mother_Phone.SetDbValue(row["str_Mother_Phone"]);
            bit_terms.SetDbValue((ConvertToBool(row["bit_terms"]) ? "1" : "0"));
            int_Nationality.SetDbValue(row["int_Nationality"]);
            str_National_ID_en.SetDbValue(row["str_National_ID_en"]);
            str_National_ID_arabic.SetDbValue(row["str_National_ID_arabic"]);
            Quallification_Id.SetDbValue(row["Quallification_Id"]);
            Job_Id.SetDbValue(row["Job_Id"]);
            str_DOB_arabic.SetDbValue(row["str_DOB_arabic"]);
            int_Language.SetDbValue(row["int_Language"]);
            strRefId.SetDbValue(row["strRefId"]);
            int_Program_Id.SetDbValue(row["int_Program_Id"]);
            IsDrivingexperience.SetDbValue((ConvertToBool(row["IsDrivingexperience"]) ? "1" : "0"));
            IsScheduleassessment.SetDbValue((ConvertToBool(row["IsScheduleassessment"]) ? "1" : "0"));
            IsEnrollbyyourself.SetDbValue((ConvertToBool(row["IsEnrollbyyourself"]) ? "1" : "0"));
            AssessmentTime.SetDbValue(row["AssessmentTime"]);
            AssessmentDate.SetDbValue(row["AssessmentDate"]);
            isAssessmentDone.SetDbValue((ConvertToBool(row["isAssessmentDone"]) ? "1" : "0"));
            AssessmentScore.SetDbValue(row["AssessmentScore"]);
            dt_WrittenTestPassed.SetDbValue(row["dt_WrittenTestPassed"]);
            dt_RoadTestPassed.SetDbValue(row["dt_RoadTestPassed"]);
            bit_Archive.SetDbValue((ConvertToBool(row["bit_Archive"]) ? "1" : "0"));
            ArchiveNotes.SetDbValue(row["ArchiveNotes"]);
            dtArchived.SetDbValue(row["dtArchived"]);
            SrNo9Dec21.SetDbValue(row["SrNo9Dec21"]);
            REGNNUMB.SetDbValue(row["REGNNUMB"]);
            REGNLOCN.SetDbValue(row["REGNLOCN"]);
            SrNo11DecF1S1.SetDbValue(row["SrNo11DecF1S1"]);
            IsInterestedInTraining.SetDbValue(row["IsInterestedInTraining"]);
            StudentEncryptID.SetDbValue(row["StudentEncryptID"]);
            StudentConfirURL.SetDbValue(row["StudentConfirURL"]);
            SrNo15DecF1S2.SetDbValue(row["SrNo15DecF1S2"]);
            SrNo15DecF1S3.SetDbValue(row["SrNo15DecF1S3"]);
            SrNo16DecF2S2.SetDbValue(row["SrNo16DecF2S2"]);
            SrNo16DecF2S3.SetDbValue(row["SrNo16DecF2S3"]);
            SrNo16DecF3S1.SetDbValue(row["SrNo16DecF3S1"]);
            SrNo16DecF3S2.SetDbValue(row["SrNo16DecF3S2"]);
            SrNo16DecF4S1.SetDbValue(row["SrNo16DecF4S1"]);
            SrNo16DecF4S2.SetDbValue(row["SrNo16DecF4S2"]);
            SrNo16DecF4S3.SetDbValue(row["SrNo16DecF4S3"]);
            StudentAssementBookingURL.SetDbValue(row["StudentAssementBookingURL"]);
            intDrivinglicenseType.SetDbValue(row["intDrivinglicenseType"]);
            Isdrivinglicense.SetDbValue((ConvertToBool(row["Isdrivinglicense"]) ? "1" : "0"));
            drivinglicensenumber.SetDbValue(row["drivinglicensenumber"]);
            Absher_Appointment_number.SetDbValue(row["Absher_Appointment_number"]);
            DataImportId.SetDbValue(row["DataImportId"]);
            date_Birth_Hijri.SetDbValue(row["date_Birth_Hijri"]);
            UserlevelID.SetDbValue(row["UserlevelID"]);
            Activated.SetDbValue((ConvertToBool(row["Activated"]) ? "1" : "0"));
            Absherphoto.SetDbValue(row["Absherphoto"]);
            Fingerprint.SetDbValue(row["Fingerprint"]);
            Required_Program.SetDbValue(row["Required_Program"]);
            Price.SetDbValue(row["Price"]);
            Hijri_Day.SetDbValue(row["Hijri_Day"]);
            Hijri_Month.SetDbValue(row["Hijri_Month"]);
            Hijri_Year.SetDbValue(row["Hijri_Year"]);
            Course_Price.SetDbValue(IsNull(row["Course_Price"]) ? DbNullValue : ConvertToDouble(row["Course_Price"]));
            Vat_Tax_15.SetDbValue(IsNull(row["Vat_Tax_15"]) ? DbNullValue : ConvertToDouble(row["Vat_Tax_15"]));
            dec_Balance.SetDbValue(IsNull(row["dec_Balance"]) ? DbNullValue : ConvertToDouble(row["dec_Balance"]));
            Total_Price.SetDbValue(IsNull(row["Total_Price"]) ? DbNullValue : ConvertToDouble(row["Total_Price"]));
            Payment_Online.SetDbValue(row["Payment_Online"]);
            Institution.SetDbValue(row["Institution"]);
            WaitingList.SetDbValue((ConvertToBool(row["WaitingList"]) ? "1" : "0"));
            Assessment_ID.SetDbValue(row["Assessment_ID"]);
        }
        #pragma warning restore 162, 168, 1998, 4014

        // Return a row with default values
        protected Dictionary<string, object> NewRow() {
            var row = new Dictionary<string, object>();
            row.Add("int_Potential_Student_ID", int_Potential_Student_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Student_Id", int_Student_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_NationalID_Iqama", str_NationalID_Iqama.DefaultValue ?? DbNullValue); // DN
            row.Add("NationalID", NationalID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_First_Name", str_First_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Middle_Name", str_Middle_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last_Name", str_Last_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Address1", str_Address1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Address2", str_Address2.DefaultValue ?? DbNullValue); // DN
            row.Add("int_State", int_State.DefaultValue ?? DbNullValue); // DN
            row.Add("str_City", str_City.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Zip", str_Zip.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Instructor", int_Instructor.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Driver", int_Driver.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Home_Phone", str_Home_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Cell_Phone", str_Cell_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Parent_Phone", str_Parent_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Other_Phone", str_Other_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Email", str_Email.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ParentName", str_ParentName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ParentEmail1", str_ParentEmail1.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ParentEmail2", str_ParentEmail2.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Username", str_Username.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Password", str_Password.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DOB", str_DOB.DefaultValue ?? DbNullValue); // DN
            row.Add("int_DOB_Day", int_DOB_Day.DefaultValue ?? DbNullValue); // DN
            row.Add("int_DOB_Month", int_DOB_Month.DefaultValue ?? DbNullValue); // DN
            row.Add("int_DOB_Year", int_DOB_Year.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Age", int_Age.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Type", int_Type.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Wear_Glasses", int_Wear_Glasses.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Sex", int_Sex.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DLPermit", str_DLPermit.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_Date_PermitIssue", dt_Date_PermitIssue.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_Date_ExpirePermit", dt_Date_ExpirePermit.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Hs_ID", int_Hs_ID.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Name", str_Emergency_Contact_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Phone", str_Emergency_Contact_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Emergency_Contact_Relation", str_Emergency_Contact_Relation.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Student_Notes", str_Student_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Driving_Notes", str_Driving_Notes.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Location_Id", int_Location_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Permit_Number", int_Permit_Number.DefaultValue ?? DbNullValue); // DN
            row.Add("Permit_Issue_Date", Permit_Issue_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("Permit_Expiry_Date", Permit_Expiry_Date.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Status", int_Status.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Lead_Id", int_Lead_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Activated_By", int_Activated_By.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Activated", date_Activated.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Created", date_Created.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Modified", date_Modified.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Complete", date_Complete.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Created_By", int_Created_By.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Modified_By", int_Modified_By.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsDeleted", bit_IsDeleted.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardHolderName", str_CardHolderName.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardHolderAddress", str_CardHolderAddress.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardHolderCity", str_CardHolderCity.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardHolderZip", str_CardHolderZip.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardType", str_CardType.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardExpMonth", str_CardExpMonth.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardExpYear", str_CardExpYear.DefaultValue ?? DbNullValue); // DN
            row.Add("str_CardNo", str_CardNo.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Certificate_No", str_Certificate_No.DefaultValue ?? DbNullValue); // DN
            row.Add("str_AmountPaid", str_AmountPaid.DefaultValue ?? DbNullValue); // DN
            row.Add("str_PermitValidated", str_PermitValidated.DefaultValue ?? DbNullValue); // DN
            row.Add("strSMSNotification", strSMSNotification.DefaultValue ?? DbNullValue); // DN
            row.Add("strVoiceNotification", strVoiceNotification.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Weight", str_Weight.DefaultValue ?? DbNullValue); // DN
            row.Add("str_SpecialNeeds", str_SpecialNeeds.DefaultValue ?? DbNullValue); // DN
            row.Add("str_MedicalConditions", str_MedicalConditions.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Verified_PIC_InSAW", bit_Verified_PIC_InSAW.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Permit_Waiver_Entered", bit_Permit_Waiver_Entered.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_TermsConditions", bit_TermsConditions.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Disable_Self_Scheduling", bit_Disable_Self_Scheduling.DefaultValue ?? DbNullValue); // DN
            row.Add("int_EyeColor", int_EyeColor.DefaultValue ?? DbNullValue); // DN
            row.Add("int_HairColor", int_HairColor.DefaultValue ?? DbNullValue); // DN
            row.Add("int_ColorBlind", int_ColorBlind.DefaultValue ?? DbNullValue); // DN
            row.Add("int_HeightFeet", int_HeightFeet.DefaultValue ?? DbNullValue); // DN
            row.Add("int_HeightInches", int_HeightInches.DefaultValue ?? DbNullValue); // DN
            row.Add("str_reference_code", str_reference_code.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_ParentClassAttendedDt", dt_ParentClassAttendedDt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ParentClassAttendedLoc", str_ParentClassAttendedLoc.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_SiblingClassAttendedDt", dt_SiblingClassAttendedDt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_SiblingClassAttendedLoc", str_SiblingClassAttendedLoc.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_PoliciesAndProcedures", bit_PoliciesAndProcedures.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_CourseCompletionDt", dt_CourseCompletionDt.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_ExtensionDt", dt_ExtensionDt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_MedicalCondition", str_MedicalCondition.DefaultValue ?? DbNullValue); // DN
            row.Add("str_MajorCrossStreets", str_MajorCrossStreets.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DriverEdCertNo", str_DriverEdCertNo.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_DriverEdCertIssuedDt", dt_DriverEdCertIssuedDt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_BTWDriversEdCertNo", str_BTWDriversEdCertNo.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_BTWCertIssuedDt", dt_BTWCertIssuedDt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OLDriversEdCertNo", str_OLDriversEdCertNo.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_OLCertIssuedDt", dt_OLCertIssuedDt.DefaultValue ?? DbNullValue); // DN
            row.Add("str_height", str_height.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_BTWCompletionDt", dt_BTWCompletionDt.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_CRCompletionDt", dt_CRCompletionDt.DefaultValue ?? DbNullValue); // DN
            row.Add("strTextBox5", strTextBox5.DefaultValue ?? DbNullValue); // DN
            row.Add("strTextBox6", strTextBox6.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ApartmentNo", str_ApartmentNo.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_PermitTestDate", dt_PermitTestDate.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OnlineDriverEdLogin", str_OnlineDriverEdLogin.DefaultValue ?? DbNullValue); // DN
            row.Add("str_OnlineDriverEdPassword", str_OnlineDriverEdPassword.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_IsSMSEnabled", bit_IsSMSEnabled.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_SMSModified", dt_SMSModified.DefaultValue ?? DbNullValue); // DN
            row.Add("str_confirmPassword", str_confirmPassword.DefaultValue ?? DbNullValue); // DN
            row.Add("DE_Certificate", DE_Certificate.DefaultValue ?? DbNullValue); // DN
            row.Add("Discuss", Discuss.DefaultValue ?? DbNullValue); // DN
            row.Add("int_UnlicensedSibling", int_UnlicensedSibling.DefaultValue ?? DbNullValue); // DN
            row.Add("int_YearSiblingIsEligible", int_YearSiblingIsEligible.DefaultValue ?? DbNullValue); // DN
            row.Add("BTW_Certificate", BTW_Certificate.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_DECertIssueDate", dt_DECertIssueDate.DefaultValue ?? DbNullValue); // DN
            row.Add("str_StudentSignature", str_StudentSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("str_ParentSignature", str_ParentSignature.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Last6DigitsOfParentDriversLicense", str_Last6DigitsOfParentDriversLicense.DefaultValue ?? DbNullValue); // DN
            row.Add("str_FACControl", str_FACControl.DefaultValue ?? DbNullValue); // DN
            row.Add("Classroom_Status_Code", Classroom_Status_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("Laboratory_Status_Code", Laboratory_Status_Code.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_EnrollmentForm", bit_EnrollmentForm.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_ParentStudentContract", bit_ParentStudentContract.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_ParentalAgreement", bit_ParentalAgreement.DefaultValue ?? DbNullValue); // DN
            row.Add("int_SF_GR_WA_HS", int_SF_GR_WA_HS.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_DisableOnRMV", bit_DisableOnRMV.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_UploadedToRMV", bit_UploadedToRMV.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Mother_Name", str_Mother_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Guardians_Name", str_Guardians_Name.DefaultValue ?? DbNullValue); // DN
            row.Add("str_Mother_Phone", str_Mother_Phone.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_terms", bit_terms.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Nationality", int_Nationality.DefaultValue ?? DbNullValue); // DN
            row.Add("str_National_ID_en", str_National_ID_en.DefaultValue ?? DbNullValue); // DN
            row.Add("str_National_ID_arabic", str_National_ID_arabic.DefaultValue ?? DbNullValue); // DN
            row.Add("Quallification_Id", Quallification_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("Job_Id", Job_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("str_DOB_arabic", str_DOB_arabic.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Language", int_Language.DefaultValue ?? DbNullValue); // DN
            row.Add("strRefId", strRefId.DefaultValue ?? DbNullValue); // DN
            row.Add("int_Program_Id", int_Program_Id.DefaultValue ?? DbNullValue); // DN
            row.Add("IsDrivingexperience", IsDrivingexperience.DefaultValue ?? DbNullValue); // DN
            row.Add("IsScheduleassessment", IsScheduleassessment.DefaultValue ?? DbNullValue); // DN
            row.Add("IsEnrollbyyourself", IsEnrollbyyourself.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentTime", AssessmentTime.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentDate", AssessmentDate.DefaultValue ?? DbNullValue); // DN
            row.Add("isAssessmentDone", isAssessmentDone.DefaultValue ?? DbNullValue); // DN
            row.Add("AssessmentScore", AssessmentScore.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_WrittenTestPassed", dt_WrittenTestPassed.DefaultValue ?? DbNullValue); // DN
            row.Add("dt_RoadTestPassed", dt_RoadTestPassed.DefaultValue ?? DbNullValue); // DN
            row.Add("bit_Archive", bit_Archive.DefaultValue ?? DbNullValue); // DN
            row.Add("ArchiveNotes", ArchiveNotes.DefaultValue ?? DbNullValue); // DN
            row.Add("dtArchived", dtArchived.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo9Dec21", SrNo9Dec21.DefaultValue ?? DbNullValue); // DN
            row.Add("REGNNUMB", REGNNUMB.DefaultValue ?? DbNullValue); // DN
            row.Add("REGNLOCN", REGNLOCN.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo11DecF1S1", SrNo11DecF1S1.DefaultValue ?? DbNullValue); // DN
            row.Add("IsInterestedInTraining", IsInterestedInTraining.DefaultValue ?? DbNullValue); // DN
            row.Add("StudentEncryptID", StudentEncryptID.DefaultValue ?? DbNullValue); // DN
            row.Add("StudentConfirURL", StudentConfirURL.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo15DecF1S2", SrNo15DecF1S2.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo15DecF1S3", SrNo15DecF1S3.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo16DecF2S2", SrNo16DecF2S2.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo16DecF2S3", SrNo16DecF2S3.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo16DecF3S1", SrNo16DecF3S1.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo16DecF3S2", SrNo16DecF3S2.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo16DecF4S1", SrNo16DecF4S1.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo16DecF4S2", SrNo16DecF4S2.DefaultValue ?? DbNullValue); // DN
            row.Add("SrNo16DecF4S3", SrNo16DecF4S3.DefaultValue ?? DbNullValue); // DN
            row.Add("StudentAssementBookingURL", StudentAssementBookingURL.DefaultValue ?? DbNullValue); // DN
            row.Add("intDrivinglicenseType", intDrivinglicenseType.DefaultValue ?? DbNullValue); // DN
            row.Add("Isdrivinglicense", Isdrivinglicense.DefaultValue ?? DbNullValue); // DN
            row.Add("drivinglicensenumber", drivinglicensenumber.DefaultValue ?? DbNullValue); // DN
            row.Add("Absher_Appointment_number", Absher_Appointment_number.DefaultValue ?? DbNullValue); // DN
            row.Add("DataImportId", DataImportId.DefaultValue ?? DbNullValue); // DN
            row.Add("date_Birth_Hijri", date_Birth_Hijri.DefaultValue ?? DbNullValue); // DN
            row.Add("UserlevelID", UserlevelID.DefaultValue ?? DbNullValue); // DN
            row.Add("Activated", Activated.DefaultValue ?? DbNullValue); // DN
            row.Add("Absherphoto", Absherphoto.DefaultValue ?? DbNullValue); // DN
            row.Add("Fingerprint", Fingerprint.DefaultValue ?? DbNullValue); // DN
            row.Add("Required_Program", Required_Program.DefaultValue ?? DbNullValue); // DN
            row.Add("Price", Price.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Day", Hijri_Day.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Month", Hijri_Month.DefaultValue ?? DbNullValue); // DN
            row.Add("Hijri_Year", Hijri_Year.DefaultValue ?? DbNullValue); // DN
            row.Add("Course_Price", Course_Price.DefaultValue ?? DbNullValue); // DN
            row.Add("Vat_Tax_15", Vat_Tax_15.DefaultValue ?? DbNullValue); // DN
            row.Add("dec_Balance", dec_Balance.DefaultValue ?? DbNullValue); // DN
            row.Add("Total_Price", Total_Price.DefaultValue ?? DbNullValue); // DN
            row.Add("Payment_Online", Payment_Online.DefaultValue ?? DbNullValue); // DN
            row.Add("Institution", Institution.DefaultValue ?? DbNullValue); // DN
            row.Add("WaitingList", WaitingList.DefaultValue ?? DbNullValue); // DN
            row.Add("Assessment_ID", Assessment_ID.DefaultValue ?? DbNullValue); // DN
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

            // int_Potential_Student_ID
            int_Potential_Student_ID.RowCssClass = "row";

            // int_Student_Id
            int_Student_Id.RowCssClass = "row";

            // str_NationalID_Iqama
            str_NationalID_Iqama.RowCssClass = "row";

            // NationalID
            NationalID.RowCssClass = "row";

            // str_First_Name
            str_First_Name.RowCssClass = "row";

            // str_Middle_Name
            str_Middle_Name.RowCssClass = "row";

            // str_Last_Name
            str_Last_Name.RowCssClass = "row";

            // str_Address1
            str_Address1.RowCssClass = "row";

            // str_Address2
            str_Address2.RowCssClass = "row";

            // int_State
            int_State.RowCssClass = "row";

            // str_City
            str_City.RowCssClass = "row";

            // str_Zip
            str_Zip.RowCssClass = "row";

            // int_Instructor
            int_Instructor.RowCssClass = "row";

            // int_Driver
            int_Driver.RowCssClass = "row";

            // str_Home_Phone
            str_Home_Phone.RowCssClass = "row";

            // str_Cell_Phone
            str_Cell_Phone.RowCssClass = "row";

            // str_Parent_Phone
            str_Parent_Phone.RowCssClass = "row";

            // str_Other_Phone
            str_Other_Phone.RowCssClass = "row";

            // str_Email
            str_Email.RowCssClass = "row";

            // str_ParentName
            str_ParentName.RowCssClass = "row";

            // str_ParentEmail1
            str_ParentEmail1.RowCssClass = "row";

            // str_ParentEmail2
            str_ParentEmail2.RowCssClass = "row";

            // str_Username
            str_Username.RowCssClass = "row";

            // str_Password
            str_Password.RowCssClass = "row";

            // str_DOB
            str_DOB.RowCssClass = "row";

            // int_DOB_Day
            int_DOB_Day.RowCssClass = "row";

            // int_DOB_Month
            int_DOB_Month.RowCssClass = "row";

            // int_DOB_Year
            int_DOB_Year.RowCssClass = "row";

            // int_Age
            int_Age.RowCssClass = "row";

            // int_Type
            int_Type.RowCssClass = "row";

            // int_Wear_Glasses
            int_Wear_Glasses.RowCssClass = "row";

            // int_Sex
            int_Sex.RowCssClass = "row";

            // str_DLPermit
            str_DLPermit.RowCssClass = "row";

            // dt_Date_PermitIssue
            dt_Date_PermitIssue.RowCssClass = "row";

            // dt_Date_ExpirePermit
            dt_Date_ExpirePermit.RowCssClass = "row";

            // int_Hs_ID
            int_Hs_ID.RowCssClass = "row";

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.RowCssClass = "row";

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.RowCssClass = "row";

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.RowCssClass = "row";

            // str_Student_Notes
            str_Student_Notes.RowCssClass = "row";

            // str_Driving_Notes
            str_Driving_Notes.RowCssClass = "row";

            // int_Location_Id
            int_Location_Id.RowCssClass = "row";

            // int_Permit_Number
            int_Permit_Number.RowCssClass = "row";

            // Permit_Issue_Date
            Permit_Issue_Date.RowCssClass = "row";

            // Permit_Expiry_Date
            Permit_Expiry_Date.RowCssClass = "row";

            // int_Status
            int_Status.RowCssClass = "row";

            // int_Lead_Id
            int_Lead_Id.RowCssClass = "row";

            // int_Activated_By
            int_Activated_By.RowCssClass = "row";

            // date_Activated
            date_Activated.RowCssClass = "row";

            // date_Created
            date_Created.RowCssClass = "row";

            // date_Modified
            date_Modified.RowCssClass = "row";

            // date_Complete
            date_Complete.RowCssClass = "row";

            // int_Created_By
            int_Created_By.RowCssClass = "row";

            // int_Modified_By
            int_Modified_By.RowCssClass = "row";

            // bit_IsDeleted
            bit_IsDeleted.RowCssClass = "row";

            // str_CardHolderName
            str_CardHolderName.RowCssClass = "row";

            // str_CardHolderAddress
            str_CardHolderAddress.RowCssClass = "row";

            // str_CardHolderCity
            str_CardHolderCity.RowCssClass = "row";

            // str_CardHolderZip
            str_CardHolderZip.RowCssClass = "row";

            // str_CardType
            str_CardType.RowCssClass = "row";

            // str_CardExpMonth
            str_CardExpMonth.RowCssClass = "row";

            // str_CardExpYear
            str_CardExpYear.RowCssClass = "row";

            // str_CardNo
            str_CardNo.RowCssClass = "row";

            // str_Certificate_No
            str_Certificate_No.RowCssClass = "row";

            // str_AmountPaid
            str_AmountPaid.RowCssClass = "row";

            // str_PermitValidated
            str_PermitValidated.RowCssClass = "row";

            // strSMSNotification
            strSMSNotification.RowCssClass = "row";

            // strVoiceNotification
            strVoiceNotification.RowCssClass = "row";

            // str_Weight
            str_Weight.RowCssClass = "row";

            // str_SpecialNeeds
            str_SpecialNeeds.RowCssClass = "row";

            // str_MedicalConditions
            str_MedicalConditions.RowCssClass = "row";

            // bit_Verified_PIC_InSAW
            bit_Verified_PIC_InSAW.RowCssClass = "row";

            // bit_Permit_Waiver_Entered
            bit_Permit_Waiver_Entered.RowCssClass = "row";

            // bit_TermsConditions
            bit_TermsConditions.RowCssClass = "row";

            // bit_Disable_Self_Scheduling
            bit_Disable_Self_Scheduling.RowCssClass = "row";

            // int_EyeColor
            int_EyeColor.RowCssClass = "row";

            // int_HairColor
            int_HairColor.RowCssClass = "row";

            // int_ColorBlind
            int_ColorBlind.RowCssClass = "row";

            // int_HeightFeet
            int_HeightFeet.RowCssClass = "row";

            // int_HeightInches
            int_HeightInches.RowCssClass = "row";

            // str_reference_code
            str_reference_code.RowCssClass = "row";

            // dt_ParentClassAttendedDt
            dt_ParentClassAttendedDt.RowCssClass = "row";

            // str_ParentClassAttendedLoc
            str_ParentClassAttendedLoc.RowCssClass = "row";

            // dt_SiblingClassAttendedDt
            dt_SiblingClassAttendedDt.RowCssClass = "row";

            // str_SiblingClassAttendedLoc
            str_SiblingClassAttendedLoc.RowCssClass = "row";

            // bit_PoliciesAndProcedures
            bit_PoliciesAndProcedures.RowCssClass = "row";

            // dt_CourseCompletionDt
            dt_CourseCompletionDt.RowCssClass = "row";

            // dt_ExtensionDt
            dt_ExtensionDt.RowCssClass = "row";

            // str_MedicalCondition
            str_MedicalCondition.RowCssClass = "row";

            // str_MajorCrossStreets
            str_MajorCrossStreets.RowCssClass = "row";

            // str_DriverEdCertNo
            str_DriverEdCertNo.RowCssClass = "row";

            // dt_DriverEdCertIssuedDt
            dt_DriverEdCertIssuedDt.RowCssClass = "row";

            // str_BTWDriversEdCertNo
            str_BTWDriversEdCertNo.RowCssClass = "row";

            // dt_BTWCertIssuedDt
            dt_BTWCertIssuedDt.RowCssClass = "row";

            // str_OLDriversEdCertNo
            str_OLDriversEdCertNo.RowCssClass = "row";

            // dt_OLCertIssuedDt
            dt_OLCertIssuedDt.RowCssClass = "row";

            // str_height
            str_height.RowCssClass = "row";

            // dt_BTWCompletionDt
            dt_BTWCompletionDt.RowCssClass = "row";

            // dt_CRCompletionDt
            dt_CRCompletionDt.RowCssClass = "row";

            // strTextBox5
            strTextBox5.RowCssClass = "row";

            // strTextBox6
            strTextBox6.RowCssClass = "row";

            // str_ApartmentNo
            str_ApartmentNo.RowCssClass = "row";

            // dt_PermitTestDate
            dt_PermitTestDate.RowCssClass = "row";

            // str_OnlineDriverEdLogin
            str_OnlineDriverEdLogin.RowCssClass = "row";

            // str_OnlineDriverEdPassword
            str_OnlineDriverEdPassword.RowCssClass = "row";

            // bit_IsSMSEnabled
            bit_IsSMSEnabled.RowCssClass = "row";

            // dt_SMSModified
            dt_SMSModified.RowCssClass = "row";

            // str_confirmPassword
            str_confirmPassword.RowCssClass = "row";

            // DE_Certificate
            DE_Certificate.RowCssClass = "row";

            // Discuss
            Discuss.RowCssClass = "row";

            // int_UnlicensedSibling
            int_UnlicensedSibling.RowCssClass = "row";

            // int_YearSiblingIsEligible
            int_YearSiblingIsEligible.RowCssClass = "row";

            // BTW_Certificate
            BTW_Certificate.RowCssClass = "row";

            // dt_DECertIssueDate
            dt_DECertIssueDate.RowCssClass = "row";

            // str_StudentSignature
            str_StudentSignature.RowCssClass = "row";

            // str_ParentSignature
            str_ParentSignature.RowCssClass = "row";

            // str_Last6DigitsOfParentDriversLicense
            str_Last6DigitsOfParentDriversLicense.RowCssClass = "row";

            // str_FACControl
            str_FACControl.RowCssClass = "row";

            // Classroom_Status_Code
            Classroom_Status_Code.RowCssClass = "row";

            // Laboratory_Status_Code
            Laboratory_Status_Code.RowCssClass = "row";

            // bit_EnrollmentForm
            bit_EnrollmentForm.RowCssClass = "row";

            // bit_ParentStudentContract
            bit_ParentStudentContract.RowCssClass = "row";

            // bit_ParentalAgreement
            bit_ParentalAgreement.RowCssClass = "row";

            // int_SF_GR_WA_HS
            int_SF_GR_WA_HS.RowCssClass = "row";

            // bit_DisableOnRMV
            bit_DisableOnRMV.RowCssClass = "row";

            // bit_UploadedToRMV
            bit_UploadedToRMV.RowCssClass = "row";

            // str_Mother_Name
            str_Mother_Name.RowCssClass = "row";

            // str_Guardians_Name
            str_Guardians_Name.RowCssClass = "row";

            // str_Mother_Phone
            str_Mother_Phone.RowCssClass = "row";

            // bit_terms
            bit_terms.RowCssClass = "row";

            // int_Nationality
            int_Nationality.RowCssClass = "row";

            // str_National_ID_en
            str_National_ID_en.RowCssClass = "row";

            // str_National_ID_arabic
            str_National_ID_arabic.RowCssClass = "row";

            // Quallification_Id
            Quallification_Id.RowCssClass = "row";

            // Job_Id
            Job_Id.RowCssClass = "row";

            // str_DOB_arabic
            str_DOB_arabic.RowCssClass = "row";

            // int_Language
            int_Language.RowCssClass = "row";

            // strRefId
            strRefId.RowCssClass = "row";

            // int_Program_Id
            int_Program_Id.RowCssClass = "row";

            // IsDrivingexperience
            IsDrivingexperience.RowCssClass = "row";

            // IsScheduleassessment
            IsScheduleassessment.RowCssClass = "row";

            // IsEnrollbyyourself
            IsEnrollbyyourself.RowCssClass = "row";

            // AssessmentTime
            AssessmentTime.RowCssClass = "row";

            // AssessmentDate
            AssessmentDate.RowCssClass = "row";

            // isAssessmentDone
            isAssessmentDone.RowCssClass = "row";

            // AssessmentScore
            AssessmentScore.RowCssClass = "row";

            // dt_WrittenTestPassed
            dt_WrittenTestPassed.RowCssClass = "row";

            // dt_RoadTestPassed
            dt_RoadTestPassed.RowCssClass = "row";

            // bit_Archive
            bit_Archive.RowCssClass = "row";

            // ArchiveNotes
            ArchiveNotes.RowCssClass = "row";

            // dtArchived
            dtArchived.RowCssClass = "row";

            // SrNo9Dec21
            SrNo9Dec21.RowCssClass = "row";

            // REGNNUMB
            REGNNUMB.RowCssClass = "row";

            // REGNLOCN
            REGNLOCN.RowCssClass = "row";

            // SrNo11DecF1S1
            SrNo11DecF1S1.RowCssClass = "row";

            // IsInterestedInTraining
            IsInterestedInTraining.RowCssClass = "row";

            // StudentEncryptID
            StudentEncryptID.RowCssClass = "row";

            // StudentConfirURL
            StudentConfirURL.RowCssClass = "row";

            // SrNo15DecF1S2
            SrNo15DecF1S2.RowCssClass = "row";

            // SrNo15DecF1S3
            SrNo15DecF1S3.RowCssClass = "row";

            // SrNo16DecF2S2
            SrNo16DecF2S2.RowCssClass = "row";

            // SrNo16DecF2S3
            SrNo16DecF2S3.RowCssClass = "row";

            // SrNo16DecF3S1
            SrNo16DecF3S1.RowCssClass = "row";

            // SrNo16DecF3S2
            SrNo16DecF3S2.RowCssClass = "row";

            // SrNo16DecF4S1
            SrNo16DecF4S1.RowCssClass = "row";

            // SrNo16DecF4S2
            SrNo16DecF4S2.RowCssClass = "row";

            // SrNo16DecF4S3
            SrNo16DecF4S3.RowCssClass = "row";

            // StudentAssementBookingURL
            StudentAssementBookingURL.RowCssClass = "row";

            // intDrivinglicenseType
            intDrivinglicenseType.RowCssClass = "row";

            // Isdrivinglicense
            Isdrivinglicense.RowCssClass = "row";

            // drivinglicensenumber
            drivinglicensenumber.RowCssClass = "row";

            // Absher_Appointment_number
            Absher_Appointment_number.RowCssClass = "row";

            // DataImportId
            DataImportId.RowCssClass = "row";

            // date_Birth_Hijri
            date_Birth_Hijri.RowCssClass = "row";

            // UserlevelID
            UserlevelID.RowCssClass = "row";

            // Activated
            Activated.RowCssClass = "row";

            // Absherphoto
            Absherphoto.RowCssClass = "row";

            // Fingerprint
            Fingerprint.RowCssClass = "row";

            // Required_Program
            Required_Program.RowCssClass = "row";

            // Price
            Price.RowCssClass = "row";

            // Hijri_Day
            Hijri_Day.RowCssClass = "row";

            // Hijri_Month
            Hijri_Month.RowCssClass = "row";

            // Hijri_Year
            Hijri_Year.RowCssClass = "row";

            // Course_Price
            Course_Price.RowCssClass = "row";

            // Vat_Tax_15
            Vat_Tax_15.RowCssClass = "row";

            // dec_Balance
            dec_Balance.RowCssClass = "row";

            // Total_Price
            Total_Price.RowCssClass = "row";

            // Payment_Online
            Payment_Online.RowCssClass = "row";

            // Institution
            Institution.RowCssClass = "row";

            // WaitingList
            WaitingList.RowCssClass = "row";

            // Assessment_ID
            Assessment_ID.RowCssClass = "row";

            // View row
            if (RowType == RowType.View) {
                // str_NationalID_Iqama
                str_NationalID_Iqama.ViewValue = ConvertToString(str_NationalID_Iqama.CurrentValue); // DN
                str_NationalID_Iqama.ViewCustomAttributes = "";

                // NationalID
                NationalID.ViewValue = NationalID.CurrentValue;
                NationalID.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.ViewValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Middle_Name
                str_Middle_Name.ViewValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
                str_Middle_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.ViewValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // str_Address1
                str_Address1.ViewValue = ConvertToString(str_Address1.CurrentValue); // DN
                str_Address1.ViewCustomAttributes = "";

                // str_Address2
                str_Address2.ViewValue = ConvertToString(str_Address2.CurrentValue); // DN
                str_Address2.ViewCustomAttributes = "";

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

                // str_Zip
                str_Zip.ViewValue = ConvertToString(str_Zip.CurrentValue); // DN
                str_Zip.ViewCustomAttributes = "";

                // int_Instructor
                curVal = ConvertToString(int_Instructor.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Instructor.Lookup != null && IsDictionary(int_Instructor.Lookup?.Options) && int_Instructor.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Instructor.ViewValue = int_Instructor.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Staff_Id]", "=", int_Instructor.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Instructor.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Instructor.Lookup != null) { // Lookup values found
                            var listwrk = int_Instructor.Lookup?.RenderViewRow(rswrk[0]);
                            int_Instructor.ViewValue = int_Instructor.HighlightLookup(ConvertToString(rswrk[0]), int_Instructor.DisplayValue(listwrk));
                        } else {
                            int_Instructor.ViewValue = FormatNumber(int_Instructor.CurrentValue, int_Instructor.FormatPattern);
                        }
                    }
                } else {
                    int_Instructor.ViewValue = DbNullValue;
                }
                int_Instructor.ViewCustomAttributes = "";

                // int_Driver
                int_Driver.ViewValue = int_Driver.CurrentValue;
                int_Driver.ViewValue = FormatNumber(int_Driver.ViewValue, int_Driver.FormatPattern);
                int_Driver.ViewCustomAttributes = "";

                // str_Home_Phone
                str_Home_Phone.ViewValue = ConvertToString(str_Home_Phone.CurrentValue); // DN
                str_Home_Phone.ViewCustomAttributes = "";

                // str_Cell_Phone
                str_Cell_Phone.ViewValue = ConvertToString(str_Cell_Phone.CurrentValue); // DN
                str_Cell_Phone.ViewCustomAttributes = "";

                // str_Parent_Phone
                str_Parent_Phone.ViewValue = ConvertToString(str_Parent_Phone.CurrentValue); // DN
                str_Parent_Phone.ViewCustomAttributes = "";

                // str_Other_Phone
                str_Other_Phone.ViewValue = ConvertToString(str_Other_Phone.CurrentValue); // DN
                str_Other_Phone.ViewCustomAttributes = "";

                // str_Email
                str_Email.ViewValue = ConvertToString(str_Email.CurrentValue); // DN
                str_Email.ViewCustomAttributes = "";

                // str_ParentName
                str_ParentName.ViewValue = ConvertToString(str_ParentName.CurrentValue); // DN
                str_ParentName.ViewCustomAttributes = "";

                // str_ParentEmail1
                str_ParentEmail1.ViewValue = ConvertToString(str_ParentEmail1.CurrentValue); // DN
                str_ParentEmail1.ViewCustomAttributes = "";

                // str_ParentEmail2
                str_ParentEmail2.ViewValue = ConvertToString(str_ParentEmail2.CurrentValue); // DN
                str_ParentEmail2.ViewCustomAttributes = "";

                // str_Username
                str_Username.ViewValue = ConvertToString(str_Username.CurrentValue); // DN
                str_Username.ViewCustomAttributes = "";

                // str_Password
                str_Password.ViewValue = ConvertToString(str_Password.CurrentValue); // DN
                str_Password.ViewCustomAttributes = "";

                // str_DOB
                str_DOB.ViewValue = str_DOB.CurrentValue;
                str_DOB.ViewValue = FormatDateTime(str_DOB.ViewValue, str_DOB.FormatPattern);
                str_DOB.ViewCustomAttributes = "";

                // int_DOB_Day
                int_DOB_Day.ViewValue = int_DOB_Day.CurrentValue;
                int_DOB_Day.ViewValue = FormatNumber(int_DOB_Day.ViewValue, int_DOB_Day.FormatPattern);
                int_DOB_Day.ViewCustomAttributes = "";

                // int_DOB_Month
                int_DOB_Month.ViewValue = int_DOB_Month.CurrentValue;
                int_DOB_Month.ViewValue = FormatNumber(int_DOB_Month.ViewValue, int_DOB_Month.FormatPattern);
                int_DOB_Month.ViewCustomAttributes = "";

                // int_DOB_Year
                int_DOB_Year.ViewValue = int_DOB_Year.CurrentValue;
                int_DOB_Year.ViewCustomAttributes = "";

                // int_Age
                int_Age.ViewValue = int_Age.CurrentValue;
                int_Age.ViewCustomAttributes = "";

                // int_Type
                int_Type.ViewValue = int_Type.CurrentValue;
                int_Type.ViewValue = FormatNumber(int_Type.ViewValue, int_Type.FormatPattern);
                int_Type.ViewCustomAttributes = "";

                // int_Wear_Glasses
                int_Wear_Glasses.ViewValue = int_Wear_Glasses.CurrentValue;
                int_Wear_Glasses.ViewValue = FormatNumber(int_Wear_Glasses.ViewValue, int_Wear_Glasses.FormatPattern);
                int_Wear_Glasses.ViewCustomAttributes = "";

                // int_Sex
                if (!Empty(int_Sex.CurrentValue)) {
                    int_Sex.ViewValue = int_Sex.HighlightLookup(ConvertToString(int_Sex.CurrentValue), int_Sex.OptionCaption(ConvertToString(int_Sex.CurrentValue)));
                } else {
                    int_Sex.ViewValue = DbNullValue;
                }
                int_Sex.ViewCustomAttributes = "";

                // str_DLPermit
                str_DLPermit.ViewValue = ConvertToString(str_DLPermit.CurrentValue); // DN
                str_DLPermit.ViewCustomAttributes = "";

                // dt_Date_PermitIssue
                dt_Date_PermitIssue.ViewValue = dt_Date_PermitIssue.CurrentValue;
                dt_Date_PermitIssue.ViewValue = FormatDateTime(dt_Date_PermitIssue.ViewValue, dt_Date_PermitIssue.FormatPattern);
                dt_Date_PermitIssue.ViewCustomAttributes = "";

                // dt_Date_ExpirePermit
                dt_Date_ExpirePermit.ViewValue = dt_Date_ExpirePermit.CurrentValue;
                dt_Date_ExpirePermit.ViewValue = FormatDateTime(dt_Date_ExpirePermit.ViewValue, dt_Date_ExpirePermit.FormatPattern);
                dt_Date_ExpirePermit.ViewCustomAttributes = "";

                // int_Hs_ID
                int_Hs_ID.ViewValue = int_Hs_ID.CurrentValue;
                int_Hs_ID.ViewValue = FormatNumber(int_Hs_ID.ViewValue, int_Hs_ID.FormatPattern);
                int_Hs_ID.ViewCustomAttributes = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.ViewValue = ConvertToString(str_Emergency_Contact_Name.CurrentValue); // DN
                str_Emergency_Contact_Name.ViewCustomAttributes = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.ViewValue = ConvertToString(str_Emergency_Contact_Phone.CurrentValue); // DN
                str_Emergency_Contact_Phone.ViewCustomAttributes = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.ViewValue = ConvertToString(str_Emergency_Contact_Relation.CurrentValue); // DN
                str_Emergency_Contact_Relation.ViewCustomAttributes = "";

                // str_Student_Notes
                str_Student_Notes.ViewValue = str_Student_Notes.CurrentValue;
                str_Student_Notes.ViewCustomAttributes = "";

                // str_Driving_Notes
                str_Driving_Notes.ViewValue = str_Driving_Notes.CurrentValue;
                str_Driving_Notes.ViewCustomAttributes = "";

                // int_Location_Id
                curVal = ConvertToString(int_Location_Id.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Location_Id.Lookup != null && IsDictionary(int_Location_Id.Lookup?.Options) && int_Location_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Location_Id.ViewValue = int_Location_Id.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_Id.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Location_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Location_Id.Lookup != null) { // Lookup values found
                            var listwrk = int_Location_Id.Lookup?.RenderViewRow(rswrk[0]);
                            int_Location_Id.ViewValue = int_Location_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Location_Id.DisplayValue(listwrk));
                        } else {
                            int_Location_Id.ViewValue = FormatNumber(int_Location_Id.CurrentValue, int_Location_Id.FormatPattern);
                        }
                    }
                } else {
                    int_Location_Id.ViewValue = DbNullValue;
                }
                int_Location_Id.ViewCustomAttributes = "";

                // int_Permit_Number
                int_Permit_Number.ViewValue = ConvertToString(int_Permit_Number.CurrentValue); // DN
                int_Permit_Number.ViewCustomAttributes = "";

                // Permit_Issue_Date
                Permit_Issue_Date.ViewValue = ConvertToString(Permit_Issue_Date.CurrentValue); // DN
                Permit_Issue_Date.ViewCustomAttributes = "";

                // Permit_Expiry_Date
                Permit_Expiry_Date.ViewValue = Permit_Expiry_Date.CurrentValue;
                Permit_Expiry_Date.ViewValue = FormatDateTime(Permit_Expiry_Date.ViewValue, Permit_Expiry_Date.FormatPattern);
                Permit_Expiry_Date.ViewCustomAttributes = "";

                // int_Status
                int_Status.ViewValue = int_Status.CurrentValue;
                int_Status.ViewValue = FormatNumber(int_Status.ViewValue, int_Status.FormatPattern);
                int_Status.ViewCustomAttributes = "";

                // int_Lead_Id
                int_Lead_Id.ViewValue = int_Lead_Id.CurrentValue;
                int_Lead_Id.ViewValue = FormatNumber(int_Lead_Id.ViewValue, int_Lead_Id.FormatPattern);
                int_Lead_Id.ViewCustomAttributes = "";

                // int_Activated_By
                int_Activated_By.ViewValue = int_Activated_By.CurrentValue;
                int_Activated_By.ViewValue = FormatNumber(int_Activated_By.ViewValue, int_Activated_By.FormatPattern);
                int_Activated_By.ViewCustomAttributes = "";

                // date_Activated
                date_Activated.ViewValue = date_Activated.CurrentValue;
                date_Activated.ViewValue = FormatDateTime(date_Activated.ViewValue, date_Activated.FormatPattern);
                date_Activated.ViewCustomAttributes = "";

                // date_Created
                date_Created.ViewValue = date_Created.CurrentValue;
                date_Created.ViewValue = FormatDateTime(date_Created.ViewValue, date_Created.FormatPattern);
                date_Created.ViewCustomAttributes = "";

                // date_Modified
                date_Modified.ViewValue = date_Modified.CurrentValue;
                date_Modified.ViewValue = FormatDateTime(date_Modified.ViewValue, date_Modified.FormatPattern);
                date_Modified.ViewCustomAttributes = "";

                // date_Complete
                date_Complete.ViewValue = date_Complete.CurrentValue;
                date_Complete.ViewValue = FormatDateTime(date_Complete.ViewValue, date_Complete.FormatPattern);
                date_Complete.ViewCustomAttributes = "";

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

                // str_CardHolderName
                str_CardHolderName.ViewValue = ConvertToString(str_CardHolderName.CurrentValue); // DN
                str_CardHolderName.ViewCustomAttributes = "";

                // str_CardHolderAddress
                str_CardHolderAddress.ViewValue = ConvertToString(str_CardHolderAddress.CurrentValue); // DN
                str_CardHolderAddress.ViewCustomAttributes = "";

                // str_CardHolderCity
                str_CardHolderCity.ViewValue = ConvertToString(str_CardHolderCity.CurrentValue); // DN
                str_CardHolderCity.ViewCustomAttributes = "";

                // str_CardHolderZip
                str_CardHolderZip.ViewValue = ConvertToString(str_CardHolderZip.CurrentValue); // DN
                str_CardHolderZip.ViewCustomAttributes = "";

                // str_CardType
                str_CardType.ViewValue = ConvertToString(str_CardType.CurrentValue); // DN
                str_CardType.ViewCustomAttributes = "";

                // str_CardExpMonth
                str_CardExpMonth.ViewValue = ConvertToString(str_CardExpMonth.CurrentValue); // DN
                str_CardExpMonth.ViewCustomAttributes = "";

                // str_CardExpYear
                str_CardExpYear.ViewValue = ConvertToString(str_CardExpYear.CurrentValue); // DN
                str_CardExpYear.ViewCustomAttributes = "";

                // str_CardNo
                str_CardNo.ViewValue = ConvertToString(str_CardNo.CurrentValue); // DN
                str_CardNo.ViewCustomAttributes = "";

                // str_Certificate_No
                str_Certificate_No.ViewValue = ConvertToString(str_Certificate_No.CurrentValue); // DN
                str_Certificate_No.ViewCustomAttributes = "";

                // str_AmountPaid
                str_AmountPaid.ViewValue = str_AmountPaid.CurrentValue;
                str_AmountPaid.ViewValue = FormatNumber(str_AmountPaid.ViewValue, str_AmountPaid.FormatPattern);
                str_AmountPaid.ViewCustomAttributes = "";

                // str_PermitValidated
                str_PermitValidated.ViewValue = ConvertToString(str_PermitValidated.CurrentValue); // DN
                str_PermitValidated.ViewCustomAttributes = "";

                // strSMSNotification
                if (!Empty(strSMSNotification.CurrentValue)) {
                    strSMSNotification.ViewValue = strSMSNotification.HighlightLookup(ConvertToString(strSMSNotification.CurrentValue), strSMSNotification.OptionCaption(ConvertToString(strSMSNotification.CurrentValue)));
                } else {
                    strSMSNotification.ViewValue = DbNullValue;
                }
                strSMSNotification.ViewCustomAttributes = "";

                // strVoiceNotification
                strVoiceNotification.ViewValue = ConvertToString(strVoiceNotification.CurrentValue); // DN
                strVoiceNotification.ViewCustomAttributes = "";

                // str_Weight
                str_Weight.ViewValue = ConvertToString(str_Weight.CurrentValue); // DN
                str_Weight.ViewCustomAttributes = "";

                // str_SpecialNeeds
                if (!Empty(str_SpecialNeeds.CurrentValue)) {
                    str_SpecialNeeds.ViewValue = str_SpecialNeeds.HighlightLookup(ConvertToString(str_SpecialNeeds.CurrentValue), str_SpecialNeeds.OptionCaption(ConvertToString(str_SpecialNeeds.CurrentValue)));
                } else {
                    str_SpecialNeeds.ViewValue = DbNullValue;
                }
                str_SpecialNeeds.ViewCustomAttributes = "";

                // str_MedicalConditions
                str_MedicalConditions.ViewValue = str_MedicalConditions.CurrentValue;
                str_MedicalConditions.ViewCustomAttributes = "";

                // bit_Verified_PIC_InSAW
                bit_Verified_PIC_InSAW.ViewValue = bit_Verified_PIC_InSAW.CurrentValue;
                bit_Verified_PIC_InSAW.ViewValue = FormatNumber(bit_Verified_PIC_InSAW.ViewValue, bit_Verified_PIC_InSAW.FormatPattern);
                bit_Verified_PIC_InSAW.ViewCustomAttributes = "";

                // bit_Permit_Waiver_Entered
                bit_Permit_Waiver_Entered.ViewValue = bit_Permit_Waiver_Entered.CurrentValue;
                bit_Permit_Waiver_Entered.ViewValue = FormatNumber(bit_Permit_Waiver_Entered.ViewValue, bit_Permit_Waiver_Entered.FormatPattern);
                bit_Permit_Waiver_Entered.ViewCustomAttributes = "";

                // bit_TermsConditions
                bit_TermsConditions.ViewValue = bit_TermsConditions.CurrentValue;
                bit_TermsConditions.ViewValue = FormatNumber(bit_TermsConditions.ViewValue, bit_TermsConditions.FormatPattern);
                bit_TermsConditions.ViewCustomAttributes = "";

                // bit_Disable_Self_Scheduling
                bit_Disable_Self_Scheduling.ViewValue = bit_Disable_Self_Scheduling.CurrentValue;
                bit_Disable_Self_Scheduling.ViewValue = FormatNumber(bit_Disable_Self_Scheduling.ViewValue, bit_Disable_Self_Scheduling.FormatPattern);
                bit_Disable_Self_Scheduling.ViewCustomAttributes = "";

                // int_EyeColor
                int_EyeColor.ViewValue = int_EyeColor.CurrentValue;
                int_EyeColor.ViewValue = FormatNumber(int_EyeColor.ViewValue, int_EyeColor.FormatPattern);
                int_EyeColor.ViewCustomAttributes = "";

                // int_HairColor
                int_HairColor.ViewValue = int_HairColor.CurrentValue;
                int_HairColor.ViewValue = FormatNumber(int_HairColor.ViewValue, int_HairColor.FormatPattern);
                int_HairColor.ViewCustomAttributes = "";

                // int_ColorBlind
                int_ColorBlind.ViewValue = int_ColorBlind.CurrentValue;
                int_ColorBlind.ViewValue = FormatNumber(int_ColorBlind.ViewValue, int_ColorBlind.FormatPattern);
                int_ColorBlind.ViewCustomAttributes = "";

                // int_HeightFeet
                int_HeightFeet.ViewValue = int_HeightFeet.CurrentValue;
                int_HeightFeet.ViewValue = FormatNumber(int_HeightFeet.ViewValue, int_HeightFeet.FormatPattern);
                int_HeightFeet.ViewCustomAttributes = "";

                // int_HeightInches
                int_HeightInches.ViewValue = int_HeightInches.CurrentValue;
                int_HeightInches.ViewValue = FormatNumber(int_HeightInches.ViewValue, int_HeightInches.FormatPattern);
                int_HeightInches.ViewCustomAttributes = "";

                // str_reference_code
                str_reference_code.ViewValue = ConvertToString(str_reference_code.CurrentValue); // DN
                str_reference_code.ViewCustomAttributes = "";

                // dt_ParentClassAttendedDt
                dt_ParentClassAttendedDt.ViewValue = dt_ParentClassAttendedDt.CurrentValue;
                dt_ParentClassAttendedDt.ViewValue = FormatDateTime(dt_ParentClassAttendedDt.ViewValue, dt_ParentClassAttendedDt.FormatPattern);
                dt_ParentClassAttendedDt.ViewCustomAttributes = "";

                // str_ParentClassAttendedLoc
                str_ParentClassAttendedLoc.ViewValue = ConvertToString(str_ParentClassAttendedLoc.CurrentValue); // DN
                str_ParentClassAttendedLoc.ViewCustomAttributes = "";

                // dt_SiblingClassAttendedDt
                dt_SiblingClassAttendedDt.ViewValue = dt_SiblingClassAttendedDt.CurrentValue;
                dt_SiblingClassAttendedDt.ViewValue = FormatDateTime(dt_SiblingClassAttendedDt.ViewValue, dt_SiblingClassAttendedDt.FormatPattern);
                dt_SiblingClassAttendedDt.ViewCustomAttributes = "";

                // str_SiblingClassAttendedLoc
                str_SiblingClassAttendedLoc.ViewValue = ConvertToString(str_SiblingClassAttendedLoc.CurrentValue); // DN
                str_SiblingClassAttendedLoc.ViewCustomAttributes = "";

                // bit_PoliciesAndProcedures
                if (ConvertToBool(bit_PoliciesAndProcedures.CurrentValue)) {
                    bit_PoliciesAndProcedures.ViewValue = bit_PoliciesAndProcedures.TagCaption(1) != "" ? bit_PoliciesAndProcedures.TagCaption(1) : "Yes";
                } else {
                    bit_PoliciesAndProcedures.ViewValue = bit_PoliciesAndProcedures.TagCaption(2) != "" ? bit_PoliciesAndProcedures.TagCaption(2) : "No";
                }
                bit_PoliciesAndProcedures.ViewCustomAttributes = "";

                // dt_CourseCompletionDt
                dt_CourseCompletionDt.ViewValue = dt_CourseCompletionDt.CurrentValue;
                dt_CourseCompletionDt.ViewValue = FormatDateTime(dt_CourseCompletionDt.ViewValue, dt_CourseCompletionDt.FormatPattern);
                dt_CourseCompletionDt.ViewCustomAttributes = "";

                // dt_ExtensionDt
                dt_ExtensionDt.ViewValue = dt_ExtensionDt.CurrentValue;
                dt_ExtensionDt.ViewValue = FormatDateTime(dt_ExtensionDt.ViewValue, dt_ExtensionDt.FormatPattern);
                dt_ExtensionDt.ViewCustomAttributes = "";

                // str_MedicalCondition
                str_MedicalCondition.ViewValue = ConvertToString(str_MedicalCondition.CurrentValue); // DN
                str_MedicalCondition.ViewCustomAttributes = "";

                // str_MajorCrossStreets
                str_MajorCrossStreets.ViewValue = ConvertToString(str_MajorCrossStreets.CurrentValue); // DN
                str_MajorCrossStreets.ViewCustomAttributes = "";

                // str_DriverEdCertNo
                str_DriverEdCertNo.ViewValue = ConvertToString(str_DriverEdCertNo.CurrentValue); // DN
                str_DriverEdCertNo.ViewCustomAttributes = "";

                // dt_DriverEdCertIssuedDt
                dt_DriverEdCertIssuedDt.ViewValue = dt_DriverEdCertIssuedDt.CurrentValue;
                dt_DriverEdCertIssuedDt.ViewValue = FormatDateTime(dt_DriverEdCertIssuedDt.ViewValue, dt_DriverEdCertIssuedDt.FormatPattern);
                dt_DriverEdCertIssuedDt.ViewCustomAttributes = "";

                // str_BTWDriversEdCertNo
                str_BTWDriversEdCertNo.ViewValue = ConvertToString(str_BTWDriversEdCertNo.CurrentValue); // DN
                str_BTWDriversEdCertNo.ViewCustomAttributes = "";

                // dt_BTWCertIssuedDt
                dt_BTWCertIssuedDt.ViewValue = dt_BTWCertIssuedDt.CurrentValue;
                dt_BTWCertIssuedDt.ViewValue = FormatDateTime(dt_BTWCertIssuedDt.ViewValue, dt_BTWCertIssuedDt.FormatPattern);
                dt_BTWCertIssuedDt.ViewCustomAttributes = "";

                // str_OLDriversEdCertNo
                str_OLDriversEdCertNo.ViewValue = ConvertToString(str_OLDriversEdCertNo.CurrentValue); // DN
                str_OLDriversEdCertNo.ViewCustomAttributes = "";

                // dt_OLCertIssuedDt
                dt_OLCertIssuedDt.ViewValue = dt_OLCertIssuedDt.CurrentValue;
                dt_OLCertIssuedDt.ViewValue = FormatDateTime(dt_OLCertIssuedDt.ViewValue, dt_OLCertIssuedDt.FormatPattern);
                dt_OLCertIssuedDt.ViewCustomAttributes = "";

                // str_height
                str_height.ViewValue = ConvertToString(str_height.CurrentValue); // DN
                str_height.ViewCustomAttributes = "";

                // dt_BTWCompletionDt
                dt_BTWCompletionDt.ViewValue = dt_BTWCompletionDt.CurrentValue;
                dt_BTWCompletionDt.ViewValue = FormatDateTime(dt_BTWCompletionDt.ViewValue, dt_BTWCompletionDt.FormatPattern);
                dt_BTWCompletionDt.ViewCustomAttributes = "";

                // dt_CRCompletionDt
                dt_CRCompletionDt.ViewValue = dt_CRCompletionDt.CurrentValue;
                dt_CRCompletionDt.ViewValue = FormatDateTime(dt_CRCompletionDt.ViewValue, dt_CRCompletionDt.FormatPattern);
                dt_CRCompletionDt.ViewCustomAttributes = "";

                // strTextBox5
                strTextBox5.ViewValue = ConvertToString(strTextBox5.CurrentValue); // DN
                strTextBox5.ViewCustomAttributes = "";

                // strTextBox6
                strTextBox6.ViewValue = ConvertToString(strTextBox6.CurrentValue); // DN
                strTextBox6.ViewCustomAttributes = "";

                // str_ApartmentNo
                str_ApartmentNo.ViewValue = ConvertToString(str_ApartmentNo.CurrentValue); // DN
                str_ApartmentNo.ViewCustomAttributes = "";

                // dt_PermitTestDate
                dt_PermitTestDate.ViewValue = dt_PermitTestDate.CurrentValue;
                dt_PermitTestDate.ViewValue = FormatDateTime(dt_PermitTestDate.ViewValue, dt_PermitTestDate.FormatPattern);
                dt_PermitTestDate.ViewCustomAttributes = "";

                // str_OnlineDriverEdLogin
                str_OnlineDriverEdLogin.ViewValue = ConvertToString(str_OnlineDriverEdLogin.CurrentValue); // DN
                str_OnlineDriverEdLogin.ViewCustomAttributes = "";

                // str_OnlineDriverEdPassword
                str_OnlineDriverEdPassword.ViewValue = ConvertToString(str_OnlineDriverEdPassword.CurrentValue); // DN
                str_OnlineDriverEdPassword.ViewCustomAttributes = "";

                // bit_IsSMSEnabled
                if (ConvertToBool(bit_IsSMSEnabled.CurrentValue)) {
                    bit_IsSMSEnabled.ViewValue = bit_IsSMSEnabled.TagCaption(1) != "" ? bit_IsSMSEnabled.TagCaption(1) : "Yes";
                } else {
                    bit_IsSMSEnabled.ViewValue = bit_IsSMSEnabled.TagCaption(2) != "" ? bit_IsSMSEnabled.TagCaption(2) : "No";
                }
                bit_IsSMSEnabled.ViewCustomAttributes = "";

                // dt_SMSModified
                dt_SMSModified.ViewValue = dt_SMSModified.CurrentValue;
                dt_SMSModified.ViewValue = FormatDateTime(dt_SMSModified.ViewValue, dt_SMSModified.FormatPattern);
                dt_SMSModified.ViewCustomAttributes = "";

                // str_confirmPassword
                str_confirmPassword.ViewValue = ConvertToString(str_confirmPassword.CurrentValue); // DN
                str_confirmPassword.ViewCustomAttributes = "";

                // DE_Certificate
                DE_Certificate.ViewValue = ConvertToString(DE_Certificate.CurrentValue); // DN
                DE_Certificate.ViewCustomAttributes = "";

                // Discuss
                Discuss.ViewValue = ConvertToString(Discuss.CurrentValue); // DN
                Discuss.ViewCustomAttributes = "";

                // int_UnlicensedSibling
                int_UnlicensedSibling.ViewValue = int_UnlicensedSibling.CurrentValue;
                int_UnlicensedSibling.ViewValue = FormatNumber(int_UnlicensedSibling.ViewValue, int_UnlicensedSibling.FormatPattern);
                int_UnlicensedSibling.ViewCustomAttributes = "";

                // int_YearSiblingIsEligible
                int_YearSiblingIsEligible.ViewValue = int_YearSiblingIsEligible.CurrentValue;
                int_YearSiblingIsEligible.ViewValue = FormatNumber(int_YearSiblingIsEligible.ViewValue, int_YearSiblingIsEligible.FormatPattern);
                int_YearSiblingIsEligible.ViewCustomAttributes = "";

                // BTW_Certificate
                BTW_Certificate.ViewValue = ConvertToString(BTW_Certificate.CurrentValue); // DN
                BTW_Certificate.ViewCustomAttributes = "";

                // dt_DECertIssueDate
                dt_DECertIssueDate.ViewValue = ConvertToString(dt_DECertIssueDate.CurrentValue); // DN
                dt_DECertIssueDate.ViewCustomAttributes = "";

                // str_StudentSignature
                str_StudentSignature.ViewValue = ConvertToString(str_StudentSignature.CurrentValue); // DN
                str_StudentSignature.ViewCustomAttributes = "";

                // str_ParentSignature
                str_ParentSignature.ViewValue = ConvertToString(str_ParentSignature.CurrentValue); // DN
                str_ParentSignature.ViewCustomAttributes = "";

                // str_Last6DigitsOfParentDriversLicense
                str_Last6DigitsOfParentDriversLicense.ViewValue = ConvertToString(str_Last6DigitsOfParentDriversLicense.CurrentValue); // DN
                str_Last6DigitsOfParentDriversLicense.ViewCustomAttributes = "";

                // str_FACControl
                str_FACControl.ViewValue = ConvertToString(str_FACControl.CurrentValue); // DN
                str_FACControl.ViewCustomAttributes = "";

                // Classroom_Status_Code
                Classroom_Status_Code.ViewValue = ConvertToString(Classroom_Status_Code.CurrentValue); // DN
                Classroom_Status_Code.ViewCustomAttributes = "";

                // Laboratory_Status_Code
                Laboratory_Status_Code.ViewValue = ConvertToString(Laboratory_Status_Code.CurrentValue); // DN
                Laboratory_Status_Code.ViewCustomAttributes = "";

                // bit_EnrollmentForm
                if (ConvertToBool(bit_EnrollmentForm.CurrentValue)) {
                    bit_EnrollmentForm.ViewValue = bit_EnrollmentForm.TagCaption(1) != "" ? bit_EnrollmentForm.TagCaption(1) : "Yes";
                } else {
                    bit_EnrollmentForm.ViewValue = bit_EnrollmentForm.TagCaption(2) != "" ? bit_EnrollmentForm.TagCaption(2) : "No";
                }
                bit_EnrollmentForm.ViewCustomAttributes = "";

                // bit_ParentStudentContract
                if (ConvertToBool(bit_ParentStudentContract.CurrentValue)) {
                    bit_ParentStudentContract.ViewValue = bit_ParentStudentContract.TagCaption(1) != "" ? bit_ParentStudentContract.TagCaption(1) : "Yes";
                } else {
                    bit_ParentStudentContract.ViewValue = bit_ParentStudentContract.TagCaption(2) != "" ? bit_ParentStudentContract.TagCaption(2) : "No";
                }
                bit_ParentStudentContract.ViewCustomAttributes = "";

                // bit_ParentalAgreement
                if (ConvertToBool(bit_ParentalAgreement.CurrentValue)) {
                    bit_ParentalAgreement.ViewValue = bit_ParentalAgreement.TagCaption(1) != "" ? bit_ParentalAgreement.TagCaption(1) : "Yes";
                } else {
                    bit_ParentalAgreement.ViewValue = bit_ParentalAgreement.TagCaption(2) != "" ? bit_ParentalAgreement.TagCaption(2) : "No";
                }
                bit_ParentalAgreement.ViewCustomAttributes = "";

                // int_SF_GR_WA_HS
                int_SF_GR_WA_HS.ViewValue = int_SF_GR_WA_HS.CurrentValue;
                int_SF_GR_WA_HS.ViewValue = FormatNumber(int_SF_GR_WA_HS.ViewValue, int_SF_GR_WA_HS.FormatPattern);
                int_SF_GR_WA_HS.ViewCustomAttributes = "";

                // bit_DisableOnRMV
                if (ConvertToBool(bit_DisableOnRMV.CurrentValue)) {
                    bit_DisableOnRMV.ViewValue = bit_DisableOnRMV.TagCaption(1) != "" ? bit_DisableOnRMV.TagCaption(1) : "Yes";
                } else {
                    bit_DisableOnRMV.ViewValue = bit_DisableOnRMV.TagCaption(2) != "" ? bit_DisableOnRMV.TagCaption(2) : "No";
                }
                bit_DisableOnRMV.ViewCustomAttributes = "";

                // bit_UploadedToRMV
                if (ConvertToBool(bit_UploadedToRMV.CurrentValue)) {
                    bit_UploadedToRMV.ViewValue = bit_UploadedToRMV.TagCaption(1) != "" ? bit_UploadedToRMV.TagCaption(1) : "Yes";
                } else {
                    bit_UploadedToRMV.ViewValue = bit_UploadedToRMV.TagCaption(2) != "" ? bit_UploadedToRMV.TagCaption(2) : "No";
                }
                bit_UploadedToRMV.ViewCustomAttributes = "";

                // str_Mother_Name
                str_Mother_Name.ViewValue = ConvertToString(str_Mother_Name.CurrentValue); // DN
                str_Mother_Name.ViewCustomAttributes = "";

                // str_Guardians_Name
                str_Guardians_Name.ViewValue = ConvertToString(str_Guardians_Name.CurrentValue); // DN
                str_Guardians_Name.ViewCustomAttributes = "";

                // str_Mother_Phone
                str_Mother_Phone.ViewValue = ConvertToString(str_Mother_Phone.CurrentValue); // DN
                str_Mother_Phone.ViewCustomAttributes = "";

                // bit_terms
                if (ConvertToBool(bit_terms.CurrentValue)) {
                    bit_terms.ViewValue = bit_terms.TagCaption(1) != "" ? bit_terms.TagCaption(1) : "Yes";
                } else {
                    bit_terms.ViewValue = bit_terms.TagCaption(2) != "" ? bit_terms.TagCaption(2) : "No";
                }
                bit_terms.ViewCustomAttributes = "";

                // int_Nationality
                int_Nationality.ViewValue = int_Nationality.CurrentValue;
                int_Nationality.ViewValue = FormatNumber(int_Nationality.ViewValue, int_Nationality.FormatPattern);
                int_Nationality.ViewCustomAttributes = "";

                // str_National_ID_en
                str_National_ID_en.ViewValue = ConvertToString(str_National_ID_en.CurrentValue); // DN
                str_National_ID_en.ViewCustomAttributes = "";

                // str_National_ID_arabic
                str_National_ID_arabic.ViewValue = ConvertToString(str_National_ID_arabic.CurrentValue); // DN
                str_National_ID_arabic.ViewCustomAttributes = "";

                // Quallification_Id
                Quallification_Id.ViewValue = Quallification_Id.CurrentValue;
                Quallification_Id.ViewValue = FormatNumber(Quallification_Id.ViewValue, Quallification_Id.FormatPattern);
                Quallification_Id.ViewCustomAttributes = "";

                // Job_Id
                Job_Id.ViewValue = Job_Id.CurrentValue;
                Job_Id.ViewValue = FormatNumber(Job_Id.ViewValue, Job_Id.FormatPattern);
                Job_Id.ViewCustomAttributes = "";

                // str_DOB_arabic
                str_DOB_arabic.ViewCustomAttributes = "";

                // int_Language
                int_Language.ViewValue = int_Language.CurrentValue;
                int_Language.ViewValue = FormatNumber(int_Language.ViewValue, int_Language.FormatPattern);
                int_Language.ViewCustomAttributes = "";

                // strRefId
                strRefId.ViewValue = ConvertToString(strRefId.CurrentValue); // DN
                strRefId.ViewCustomAttributes = "";

                // int_Program_Id
                if (!Empty(int_Program_Id.CurrentValue)) {
                    int_Program_Id.ViewValue = int_Program_Id.HighlightLookup(ConvertToString(int_Program_Id.CurrentValue), int_Program_Id.OptionCaption(ConvertToString(int_Program_Id.CurrentValue)));
                } else {
                    int_Program_Id.ViewValue = DbNullValue;
                }
                int_Program_Id.ViewCustomAttributes = "";

                // IsDrivingexperience
                if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
                } else {
                    IsDrivingexperience.ViewValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
                }
                IsDrivingexperience.ViewCustomAttributes = "";

                // IsScheduleassessment
                if (ConvertToBool(IsScheduleassessment.CurrentValue)) {
                    IsScheduleassessment.ViewValue = IsScheduleassessment.TagCaption(1) != "" ? IsScheduleassessment.TagCaption(1) : "Yes";
                } else {
                    IsScheduleassessment.ViewValue = IsScheduleassessment.TagCaption(2) != "" ? IsScheduleassessment.TagCaption(2) : "No";
                }
                IsScheduleassessment.ViewCustomAttributes = "";

                // IsEnrollbyyourself
                if (ConvertToBool(IsEnrollbyyourself.CurrentValue)) {
                    IsEnrollbyyourself.ViewValue = IsEnrollbyyourself.TagCaption(1) != "" ? IsEnrollbyyourself.TagCaption(1) : "Yes";
                } else {
                    IsEnrollbyyourself.ViewValue = IsEnrollbyyourself.TagCaption(2) != "" ? IsEnrollbyyourself.TagCaption(2) : "No";
                }
                IsEnrollbyyourself.ViewCustomAttributes = "";

                // AssessmentTime
                AssessmentTime.ViewValue = ConvertToString(AssessmentTime.CurrentValue); // DN
                AssessmentTime.ViewCustomAttributes = "";

                // AssessmentDate
                AssessmentDate.ViewValue = AssessmentDate.CurrentValue;
                AssessmentDate.ViewValue = FormatDateTime(AssessmentDate.ViewValue, AssessmentDate.FormatPattern);
                AssessmentDate.ViewCustomAttributes = "";

                // isAssessmentDone
                if (ConvertToBool(isAssessmentDone.CurrentValue)) {
                    isAssessmentDone.ViewValue = isAssessmentDone.TagCaption(1) != "" ? isAssessmentDone.TagCaption(1) : "Yes";
                } else {
                    isAssessmentDone.ViewValue = isAssessmentDone.TagCaption(2) != "" ? isAssessmentDone.TagCaption(2) : "No";
                }
                isAssessmentDone.ViewCustomAttributes = "";

                // AssessmentScore
                AssessmentScore.ViewValue = AssessmentScore.CurrentValue;
                AssessmentScore.ViewCustomAttributes = "";

                // dt_WrittenTestPassed
                if (!Empty(dt_WrittenTestPassed.CurrentValue)) {
                    var optionsWrk = new OptionValues();
                    arWrk = ConvertToString(dt_WrittenTestPassed.CurrentValue).Split(Config.MultipleOptionSeparator);
                    for (int i = 0; i < arWrk.Length; i++) {
                        optionsWrk.Add(dt_WrittenTestPassed.HighlightLookup(arWrk[i].Trim(), dt_WrittenTestPassed.OptionCaption(arWrk[i].Trim())));
                    }
                    dt_WrittenTestPassed.ViewValue = optionsWrk.ToString(); // DN
                } else {
                    dt_WrittenTestPassed.ViewValue = DbNullValue;
                }
                dt_WrittenTestPassed.ViewCustomAttributes = "";

                // dt_RoadTestPassed
                if (!Empty(dt_RoadTestPassed.CurrentValue)) {
                    var optionsWrk = new OptionValues();
                    arWrk = ConvertToString(dt_RoadTestPassed.CurrentValue).Split(Config.MultipleOptionSeparator);
                    for (int i = 0; i < arWrk.Length; i++) {
                        optionsWrk.Add(dt_RoadTestPassed.HighlightLookup(arWrk[i].Trim(), dt_RoadTestPassed.OptionCaption(arWrk[i].Trim())));
                    }
                    dt_RoadTestPassed.ViewValue = optionsWrk.ToString(); // DN
                } else {
                    dt_RoadTestPassed.ViewValue = DbNullValue;
                }
                dt_RoadTestPassed.ViewCustomAttributes = "";

                // bit_Archive
                if (ConvertToBool(bit_Archive.CurrentValue)) {
                    bit_Archive.ViewValue = bit_Archive.TagCaption(1) != "" ? bit_Archive.TagCaption(1) : "Yes";
                } else {
                    bit_Archive.ViewValue = bit_Archive.TagCaption(2) != "" ? bit_Archive.TagCaption(2) : "No";
                }
                bit_Archive.ViewCustomAttributes = "";

                // ArchiveNotes
                ArchiveNotes.ViewValue = ConvertToString(ArchiveNotes.CurrentValue); // DN
                ArchiveNotes.ViewCustomAttributes = "";

                // dtArchived
                dtArchived.ViewValue = dtArchived.CurrentValue;
                dtArchived.ViewValue = FormatDateTime(dtArchived.ViewValue, dtArchived.FormatPattern);
                dtArchived.ViewCustomAttributes = "";

                // SrNo9Dec21
                SrNo9Dec21.ViewValue = SrNo9Dec21.CurrentValue;
                SrNo9Dec21.ViewValue = FormatNumber(SrNo9Dec21.ViewValue, SrNo9Dec21.FormatPattern);
                SrNo9Dec21.ViewCustomAttributes = "";

                // REGNNUMB
                REGNNUMB.ViewValue = ConvertToString(REGNNUMB.CurrentValue); // DN
                REGNNUMB.ViewCustomAttributes = "";

                // REGNLOCN
                REGNLOCN.ViewValue = ConvertToString(REGNLOCN.CurrentValue); // DN
                REGNLOCN.ViewCustomAttributes = "";

                // SrNo11DecF1S1
                SrNo11DecF1S1.ViewValue = SrNo11DecF1S1.CurrentValue;
                SrNo11DecF1S1.ViewValue = FormatNumber(SrNo11DecF1S1.ViewValue, SrNo11DecF1S1.FormatPattern);
                SrNo11DecF1S1.ViewCustomAttributes = "";

                // IsInterestedInTraining
                IsInterestedInTraining.ViewValue = IsInterestedInTraining.CurrentValue;
                IsInterestedInTraining.ViewValue = FormatNumber(IsInterestedInTraining.ViewValue, IsInterestedInTraining.FormatPattern);
                IsInterestedInTraining.ViewCustomAttributes = "";

                // StudentEncryptID
                StudentEncryptID.ViewValue = ConvertToString(StudentEncryptID.CurrentValue); // DN
                StudentEncryptID.ViewCustomAttributes = "";

                // StudentConfirURL
                StudentConfirURL.ViewValue = ConvertToString(StudentConfirURL.CurrentValue); // DN
                StudentConfirURL.ViewCustomAttributes = "";

                // SrNo15DecF1S2
                SrNo15DecF1S2.ViewValue = SrNo15DecF1S2.CurrentValue;
                SrNo15DecF1S2.ViewValue = FormatNumber(SrNo15DecF1S2.ViewValue, SrNo15DecF1S2.FormatPattern);
                SrNo15DecF1S2.ViewCustomAttributes = "";

                // SrNo15DecF1S3
                SrNo15DecF1S3.ViewValue = SrNo15DecF1S3.CurrentValue;
                SrNo15DecF1S3.ViewValue = FormatNumber(SrNo15DecF1S3.ViewValue, SrNo15DecF1S3.FormatPattern);
                SrNo15DecF1S3.ViewCustomAttributes = "";

                // SrNo16DecF2S2
                SrNo16DecF2S2.ViewValue = SrNo16DecF2S2.CurrentValue;
                SrNo16DecF2S2.ViewValue = FormatNumber(SrNo16DecF2S2.ViewValue, SrNo16DecF2S2.FormatPattern);
                SrNo16DecF2S2.ViewCustomAttributes = "";

                // SrNo16DecF2S3
                SrNo16DecF2S3.ViewValue = SrNo16DecF2S3.CurrentValue;
                SrNo16DecF2S3.ViewValue = FormatNumber(SrNo16DecF2S3.ViewValue, SrNo16DecF2S3.FormatPattern);
                SrNo16DecF2S3.ViewCustomAttributes = "";

                // SrNo16DecF3S1
                SrNo16DecF3S1.ViewValue = SrNo16DecF3S1.CurrentValue;
                SrNo16DecF3S1.ViewValue = FormatNumber(SrNo16DecF3S1.ViewValue, SrNo16DecF3S1.FormatPattern);
                SrNo16DecF3S1.ViewCustomAttributes = "";

                // SrNo16DecF3S2
                SrNo16DecF3S2.ViewValue = SrNo16DecF3S2.CurrentValue;
                SrNo16DecF3S2.ViewValue = FormatNumber(SrNo16DecF3S2.ViewValue, SrNo16DecF3S2.FormatPattern);
                SrNo16DecF3S2.ViewCustomAttributes = "";

                // SrNo16DecF4S1
                SrNo16DecF4S1.ViewValue = SrNo16DecF4S1.CurrentValue;
                SrNo16DecF4S1.ViewValue = FormatNumber(SrNo16DecF4S1.ViewValue, SrNo16DecF4S1.FormatPattern);
                SrNo16DecF4S1.ViewCustomAttributes = "";

                // SrNo16DecF4S2
                SrNo16DecF4S2.ViewValue = SrNo16DecF4S2.CurrentValue;
                SrNo16DecF4S2.ViewValue = FormatNumber(SrNo16DecF4S2.ViewValue, SrNo16DecF4S2.FormatPattern);
                SrNo16DecF4S2.ViewCustomAttributes = "";

                // SrNo16DecF4S3
                SrNo16DecF4S3.ViewValue = SrNo16DecF4S3.CurrentValue;
                SrNo16DecF4S3.ViewValue = FormatNumber(SrNo16DecF4S3.ViewValue, SrNo16DecF4S3.FormatPattern);
                SrNo16DecF4S3.ViewCustomAttributes = "";

                // StudentAssementBookingURL
                StudentAssementBookingURL.ViewValue = ConvertToString(StudentAssementBookingURL.CurrentValue); // DN
                StudentAssementBookingURL.ViewCustomAttributes = "";

                // intDrivinglicenseType
                intDrivinglicenseType.ViewValue = intDrivinglicenseType.CurrentValue;
                intDrivinglicenseType.ViewCustomAttributes = "";

                // Isdrivinglicense
                if (ConvertToBool(Isdrivinglicense.CurrentValue)) {
                    Isdrivinglicense.ViewValue = Isdrivinglicense.TagCaption(1) != "" ? Isdrivinglicense.TagCaption(1) : "Yes";
                } else {
                    Isdrivinglicense.ViewValue = Isdrivinglicense.TagCaption(2) != "" ? Isdrivinglicense.TagCaption(2) : "No";
                }
                Isdrivinglicense.ViewCustomAttributes = "";

                // drivinglicensenumber
                drivinglicensenumber.ViewValue = ConvertToString(drivinglicensenumber.CurrentValue); // DN
                drivinglicensenumber.ViewCustomAttributes = "";

                // Absher_Appointment_number
                Absher_Appointment_number.ViewValue = ConvertToString(Absher_Appointment_number.CurrentValue); // DN
                Absher_Appointment_number.ViewCustomAttributes = "";

                // DataImportId
                DataImportId.ViewValue = DataImportId.CurrentValue;
                DataImportId.ViewValue = FormatNumber(DataImportId.ViewValue, DataImportId.FormatPattern);
                DataImportId.ViewCustomAttributes = "";

                // date_Birth_Hijri
                date_Birth_Hijri.ViewValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // UserlevelID
                UserlevelID.ViewValue = UserlevelID.CurrentValue;
                UserlevelID.ViewValue = FormatNumber(UserlevelID.ViewValue, UserlevelID.FormatPattern);
                UserlevelID.ViewCustomAttributes = "";

                // Activated
                if (ConvertToBool(Activated.CurrentValue)) {
                    Activated.ViewValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
                } else {
                    Activated.ViewValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
                }
                Activated.ViewCustomAttributes = "";

                // Absherphoto
                Absherphoto.ViewValue = ConvertToString(Absherphoto.CurrentValue); // DN
                Absherphoto.ViewCustomAttributes = "";

                // Fingerprint
                Fingerprint.ViewValue = ConvertToString(Fingerprint.CurrentValue); // DN
                Fingerprint.ViewCustomAttributes = "";

                // Required_Program
                Required_Program.ViewValue = ConvertToString(Required_Program.CurrentValue); // DN
                Required_Program.ViewCustomAttributes = "";

                // Price
                Price.ViewValue = Price.CurrentValue;
                Price.ViewValue = FormatCurrency(Price.ViewValue, Price.FormatPattern);
                Price.ViewCustomAttributes = "";

                // Hijri_Day
                Hijri_Day.ViewValue = Hijri_Day.CurrentValue;
                Hijri_Day.ViewValue = FormatNumber(Hijri_Day.ViewValue, Hijri_Day.FormatPattern);
                Hijri_Day.ViewCustomAttributes = "";

                // Hijri_Month
                Hijri_Month.ViewValue = Hijri_Month.CurrentValue;
                Hijri_Month.ViewValue = FormatNumber(Hijri_Month.ViewValue, Hijri_Month.FormatPattern);
                Hijri_Month.ViewCustomAttributes = "";

                // Hijri_Year
                Hijri_Year.ViewValue = Hijri_Year.CurrentValue;
                Hijri_Year.ViewCustomAttributes = "";

                // Course_Price
                Course_Price.ViewValue = Course_Price.CurrentValue;
                Course_Price.ViewValue = FormatNumber(Course_Price.ViewValue, Course_Price.FormatPattern);
                Course_Price.ViewCustomAttributes = "";

                // Vat_Tax_15
                Vat_Tax_15.ViewValue = Vat_Tax_15.CurrentValue;
                Vat_Tax_15.ViewValue = FormatNumber(Vat_Tax_15.ViewValue, Vat_Tax_15.FormatPattern);
                Vat_Tax_15.ViewCustomAttributes = "";

                // dec_Balance
                dec_Balance.ViewValue = dec_Balance.CurrentValue;
                dec_Balance.ViewValue = FormatCurrency(dec_Balance.ViewValue, dec_Balance.FormatPattern);
                dec_Balance.ViewCustomAttributes = "";

                // Total_Price
                Total_Price.ViewValue = Total_Price.CurrentValue;
                Total_Price.ViewValue = FormatNumber(Total_Price.ViewValue, Total_Price.FormatPattern);
                Total_Price.ViewCustomAttributes = "";

                // Payment_Online
                Payment_Online.ViewValue = ConvertToString(Payment_Online.CurrentValue); // DN
                Payment_Online.ViewCustomAttributes = "";

                // Institution
                Institution.ViewValue = ConvertToString(Institution.CurrentValue); // DN
                Institution.ViewCustomAttributes = "";

                // WaitingList
                if (ConvertToBool(WaitingList.CurrentValue)) {
                    WaitingList.ViewValue = WaitingList.TagCaption(1) != "" ? WaitingList.TagCaption(1) : "Yes";
                } else {
                    WaitingList.ViewValue = WaitingList.TagCaption(2) != "" ? WaitingList.TagCaption(2) : "No";
                }
                WaitingList.ViewCustomAttributes = "";

                // Assessment_ID
                Assessment_ID.ViewValue = Assessment_ID.CurrentValue;
                Assessment_ID.ViewValue = FormatNumber(Assessment_ID.ViewValue, Assessment_ID.FormatPattern);
                Assessment_ID.ViewCustomAttributes = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";
                str_NationalID_Iqama.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";
                str_Middle_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Address1
                str_Address1.HrefValue = "";

                // str_Address2
                str_Address2.HrefValue = "";

                // int_State
                int_State.HrefValue = "";

                // str_City
                str_City.HrefValue = "";

                // str_Zip
                str_Zip.HrefValue = "";

                // str_Home_Phone
                str_Home_Phone.HrefValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";

                // str_Parent_Phone
                str_Parent_Phone.HrefValue = "";

                // str_Email
                str_Email.HrefValue = "";

                // str_ParentName
                str_ParentName.HrefValue = "";

                // str_DOB
                str_DOB.HrefValue = "";
                str_DOB.TooltipValue = "";

                // int_Age
                int_Age.HrefValue = "";
                int_Age.TooltipValue = "";

                // int_Sex
                int_Sex.HrefValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";

                // str_Student_Notes
                str_Student_Notes.HrefValue = "";

                // int_Location_Id
                int_Location_Id.HrefValue = "";
                int_Location_Id.TooltipValue = "";

                // date_Activated
                date_Activated.HrefValue = "";
                date_Activated.TooltipValue = "";

                // date_Created
                date_Created.HrefValue = "";
                date_Created.TooltipValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // strSMSNotification
                strSMSNotification.HrefValue = "";
                strSMSNotification.TooltipValue = "";

                // str_Weight
                str_Weight.HrefValue = "";

                // str_SpecialNeeds
                str_SpecialNeeds.HrefValue = "";

                // str_MedicalConditions
                str_MedicalConditions.HrefValue = "";

                // int_Nationality
                int_Nationality.HrefValue = "";
                int_Nationality.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";

                // IsScheduleassessment
                IsScheduleassessment.HrefValue = "";
                IsScheduleassessment.TooltipValue = "";

                // AssessmentDate
                AssessmentDate.HrefValue = "";
                AssessmentDate.TooltipValue = "";

                // isAssessmentDone
                isAssessmentDone.HrefValue = "";
                isAssessmentDone.TooltipValue = "";

                // AssessmentScore
                AssessmentScore.HrefValue = "";
                AssessmentScore.TooltipValue = "";

                // dt_WrittenTestPassed
                dt_WrittenTestPassed.HrefValue = "";
                dt_WrittenTestPassed.TooltipValue = "";

                // dt_RoadTestPassed
                dt_RoadTestPassed.HrefValue = "";
                dt_RoadTestPassed.TooltipValue = "";

                // Absher_Appointment_number
                Absher_Appointment_number.HrefValue = "";
                Absher_Appointment_number.TooltipValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";
                date_Birth_Hijri.TooltipValue = "";

                // Activated
                Activated.HrefValue = "";
                Activated.TooltipValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.TooltipValue = "";

                // Required_Program
                Required_Program.HrefValue = "";
                Required_Program.TooltipValue = "";

                // Price
                Price.HrefValue = "";
                Price.TooltipValue = "";

                // Hijri_Day
                Hijri_Day.HrefValue = "";
                Hijri_Day.TooltipValue = "";

                // Hijri_Month
                Hijri_Month.HrefValue = "";
                Hijri_Month.TooltipValue = "";

                // Hijri_Year
                Hijri_Year.HrefValue = "";
                Hijri_Year.TooltipValue = "";

                // dec_Balance
                dec_Balance.HrefValue = "";
                dec_Balance.TooltipValue = "";

                // Payment_Online
                if (!IsNull(Payment_Online.CurrentValue)) {
                    Payment_Online.HrefValue = Payment_Online.GetLinkPrefix() + ConvertToString(Payment_Online.CurrentValue); // Add prefix/suffix
                    Payment_Online.LinkAttrs["target"] = "_blank"; // Add target
                    if (IsExport())
                        Payment_Online.HrefValue = FullUrl(ConvertToString(Payment_Online.HrefValue), "href");
                } else {
                    Payment_Online.HrefValue = "";
                }
                Payment_Online.TooltipValue = "";

                // Institution
                Institution.HrefValue = "";
                Institution.TooltipValue = "";

                // WaitingList
                WaitingList.HrefValue = "";
            } else if (RowType == RowType.Edit) {
                // str_NationalID_Iqama
                str_NationalID_Iqama.SetupEditAttributes();
                str_NationalID_Iqama.EditValue = ConvertToString(str_NationalID_Iqama.CurrentValue); // DN
                str_NationalID_Iqama.ViewCustomAttributes = "";

                // str_First_Name
                str_First_Name.SetupEditAttributes();
                str_First_Name.EditValue = ConvertToString(str_First_Name.CurrentValue); // DN
                str_First_Name.ViewCustomAttributes = "";

                // str_Middle_Name
                str_Middle_Name.SetupEditAttributes();
                str_Middle_Name.EditValue = ConvertToString(str_Middle_Name.CurrentValue); // DN
                str_Middle_Name.ViewCustomAttributes = "";

                // str_Last_Name
                str_Last_Name.SetupEditAttributes();
                str_Last_Name.EditValue = ConvertToString(str_Last_Name.CurrentValue); // DN
                str_Last_Name.ViewCustomAttributes = "";

                // str_Address1
                str_Address1.SetupEditAttributes();
                if (!str_Address1.Raw)
                    str_Address1.CurrentValue = HtmlDecode(str_Address1.CurrentValue);
                str_Address1.EditValue = HtmlEncode(str_Address1.CurrentValue);
                str_Address1.PlaceHolder = RemoveHtml(str_Address1.Caption);

                // str_Address2
                str_Address2.SetupEditAttributes();
                if (!str_Address2.Raw)
                    str_Address2.CurrentValue = HtmlDecode(str_Address2.CurrentValue);
                str_Address2.EditValue = HtmlEncode(str_Address2.CurrentValue);
                str_Address2.PlaceHolder = RemoveHtml(str_Address2.Caption);

                // int_State
                int_State.SetupEditAttributes();
                curVal = ConvertToString(int_State.CurrentValue)?.Trim() ?? "";
                if (int_State.Lookup != null && IsDictionary(int_State.Lookup?.Options) && int_State.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_State.EditValue = int_State.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Province_ID]", "=", int_State.CurrentValue, DataType.Number, "");
                    }
                    sqlWrk = int_State.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_State.EditValue = rswrk;
                }
                int_State.PlaceHolder = RemoveHtml(int_State.Caption);
                if (!Empty(int_State.EditValue) && IsNumeric(int_State.EditValue))
                    int_State.EditValue = FormatNumber(int_State.EditValue, null);

                // str_City
                str_City.SetupEditAttributes();
                curVal = ConvertToString(str_City.CurrentValue)?.Trim() ?? "";
                if (str_City.Lookup != null && IsDictionary(str_City.Lookup?.Options) && str_City.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_City.EditValue = str_City.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[City]", "=", str_City.CurrentValue, DataType.String, "");
                    }
                    sqlWrk = str_City.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_City.EditValue = rswrk;
                }
                str_City.PlaceHolder = RemoveHtml(str_City.Caption);

                // str_Zip
                str_Zip.SetupEditAttributes();
                if (!str_Zip.Raw)
                    str_Zip.CurrentValue = HtmlDecode(str_Zip.CurrentValue);
                str_Zip.EditValue = HtmlEncode(str_Zip.CurrentValue);
                str_Zip.PlaceHolder = RemoveHtml(str_Zip.Caption);

                // str_Home_Phone
                str_Home_Phone.SetupEditAttributes();
                if (!str_Home_Phone.Raw)
                    str_Home_Phone.CurrentValue = HtmlDecode(str_Home_Phone.CurrentValue);
                str_Home_Phone.EditValue = HtmlEncode(str_Home_Phone.CurrentValue);
                str_Home_Phone.PlaceHolder = RemoveHtml(str_Home_Phone.Caption);

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.CurrentValue = HtmlDecode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.CurrentValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

                // str_Parent_Phone
                str_Parent_Phone.SetupEditAttributes();
                if (!str_Parent_Phone.Raw)
                    str_Parent_Phone.CurrentValue = HtmlDecode(str_Parent_Phone.CurrentValue);
                str_Parent_Phone.EditValue = HtmlEncode(str_Parent_Phone.CurrentValue);
                str_Parent_Phone.PlaceHolder = RemoveHtml(str_Parent_Phone.Caption);

                // str_Email
                str_Email.SetupEditAttributes();
                if (!str_Email.Raw)
                    str_Email.CurrentValue = HtmlDecode(str_Email.CurrentValue);
                str_Email.EditValue = HtmlEncode(str_Email.CurrentValue);
                str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

                // str_ParentName
                str_ParentName.SetupEditAttributes();
                if (!str_ParentName.Raw)
                    str_ParentName.CurrentValue = HtmlDecode(str_ParentName.CurrentValue);
                str_ParentName.EditValue = HtmlEncode(str_ParentName.CurrentValue);
                str_ParentName.PlaceHolder = RemoveHtml(str_ParentName.Caption);

                // str_DOB
                str_DOB.SetupEditAttributes();
                str_DOB.EditValue = str_DOB.CurrentValue;
                str_DOB.EditValue = FormatDateTime(str_DOB.EditValue, str_DOB.FormatPattern);
                str_DOB.ViewCustomAttributes = "";

                // int_Age
                int_Age.SetupEditAttributes();
                int_Age.EditValue = int_Age.CurrentValue;
                int_Age.ViewCustomAttributes = "";

                // int_Sex
                int_Sex.SetupEditAttributes();
                int_Sex.EditValue = int_Sex.Options(true);
                int_Sex.PlaceHolder = RemoveHtml(int_Sex.Caption);
                if (!Empty(int_Sex.EditValue) && IsNumeric(int_Sex.EditValue))
                    int_Sex.EditValue = FormatNumber(int_Sex.EditValue, null);

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
                if (!str_Emergency_Contact_Relation.Raw)
                    str_Emergency_Contact_Relation.CurrentValue = HtmlDecode(str_Emergency_Contact_Relation.CurrentValue);
                str_Emergency_Contact_Relation.EditValue = HtmlEncode(str_Emergency_Contact_Relation.CurrentValue);
                str_Emergency_Contact_Relation.PlaceHolder = RemoveHtml(str_Emergency_Contact_Relation.Caption);

                // str_Student_Notes
                str_Student_Notes.SetupEditAttributes();
                str_Student_Notes.EditValue = str_Student_Notes.CurrentValue; // DN
                str_Student_Notes.PlaceHolder = RemoveHtml(str_Student_Notes.Caption);

                // int_Location_Id
                int_Location_Id.SetupEditAttributes();
                curVal = ConvertToString(int_Location_Id.CurrentValue);
                if (!Empty(curVal)) {
                    if (int_Location_Id.Lookup != null && IsDictionary(int_Location_Id.Lookup?.Options) && int_Location_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                        int_Location_Id.EditValue = int_Location_Id.LookupCacheOption(curVal);
                    } else { // Lookup from database // DN
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_Id.CurrentValue, DataType.Number, "");
                        sqlWrk = int_Location_Id.Lookup?.GetSql(false, filterWrk, null, this, true, true);
                        rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                        if (rswrk?.Count > 0 && int_Location_Id.Lookup != null) { // Lookup values found
                            var listwrk = int_Location_Id.Lookup?.RenderViewRow(rswrk[0]);
                            int_Location_Id.EditValue = int_Location_Id.HighlightLookup(ConvertToString(rswrk[0]), int_Location_Id.DisplayValue(listwrk));
                        } else {
                            int_Location_Id.EditValue = FormatNumber(int_Location_Id.CurrentValue, int_Location_Id.FormatPattern);
                        }
                    }
                } else {
                    int_Location_Id.EditValue = DbNullValue;
                }
                int_Location_Id.ViewCustomAttributes = "";

                // date_Activated
                date_Activated.SetupEditAttributes();
                date_Activated.EditValue = date_Activated.CurrentValue;
                date_Activated.EditValue = FormatDateTime(date_Activated.EditValue, date_Activated.FormatPattern);
                date_Activated.ViewCustomAttributes = "";

                // date_Created
                date_Created.SetupEditAttributes();
                date_Created.CurrentValue = FormatDateTime(date_Created.CurrentValue, date_Created.FormatPattern);

                // date_Modified
                date_Modified.SetupEditAttributes();
                date_Modified.CurrentValue = FormatDateTime(date_Modified.CurrentValue, date_Modified.FormatPattern);

                // strSMSNotification
                strSMSNotification.SetupEditAttributes();
                if (!Empty(strSMSNotification.CurrentValue)) {
                    strSMSNotification.EditValue = strSMSNotification.HighlightLookup(ConvertToString(strSMSNotification.CurrentValue), strSMSNotification.OptionCaption(ConvertToString(strSMSNotification.CurrentValue)));
                } else {
                    strSMSNotification.EditValue = DbNullValue;
                }
                strSMSNotification.ViewCustomAttributes = "";

                // str_Weight
                str_Weight.SetupEditAttributes();
                if (!str_Weight.Raw)
                    str_Weight.CurrentValue = HtmlDecode(str_Weight.CurrentValue);
                str_Weight.EditValue = HtmlEncode(str_Weight.CurrentValue);
                str_Weight.PlaceHolder = RemoveHtml(str_Weight.Caption);

                // str_SpecialNeeds
                str_SpecialNeeds.SetupEditAttributes();
                str_SpecialNeeds.EditValue = str_SpecialNeeds.Options(true);
                str_SpecialNeeds.PlaceHolder = RemoveHtml(str_SpecialNeeds.Caption);

                // str_MedicalConditions
                str_MedicalConditions.SetupEditAttributes();
                str_MedicalConditions.EditValue = str_MedicalConditions.CurrentValue; // DN
                str_MedicalConditions.PlaceHolder = RemoveHtml(str_MedicalConditions.Caption);

                // int_Nationality
                int_Nationality.SetupEditAttributes();
                int_Nationality.EditValue = int_Nationality.CurrentValue;
                int_Nationality.EditValue = FormatNumber(int_Nationality.EditValue, int_Nationality.FormatPattern);
                int_Nationality.ViewCustomAttributes = "";

                // IsDrivingexperience
                IsDrivingexperience.SetupEditAttributes();
                if (ConvertToBool(IsDrivingexperience.CurrentValue)) {
                    IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(1) != "" ? IsDrivingexperience.TagCaption(1) : "Yes";
                } else {
                    IsDrivingexperience.EditValue = IsDrivingexperience.TagCaption(2) != "" ? IsDrivingexperience.TagCaption(2) : "No";
                }
                IsDrivingexperience.ViewCustomAttributes = "";

                // IsScheduleassessment
                IsScheduleassessment.SetupEditAttributes();
                if (ConvertToBool(IsScheduleassessment.CurrentValue)) {
                    IsScheduleassessment.EditValue = IsScheduleassessment.TagCaption(1) != "" ? IsScheduleassessment.TagCaption(1) : "Yes";
                } else {
                    IsScheduleassessment.EditValue = IsScheduleassessment.TagCaption(2) != "" ? IsScheduleassessment.TagCaption(2) : "No";
                }
                IsScheduleassessment.ViewCustomAttributes = "";

                // AssessmentDate
                AssessmentDate.SetupEditAttributes();
                AssessmentDate.EditValue = AssessmentDate.CurrentValue;
                AssessmentDate.EditValue = FormatDateTime(AssessmentDate.EditValue, AssessmentDate.FormatPattern);
                AssessmentDate.ViewCustomAttributes = "";

                // isAssessmentDone
                isAssessmentDone.SetupEditAttributes();
                if (ConvertToBool(isAssessmentDone.CurrentValue)) {
                    isAssessmentDone.EditValue = isAssessmentDone.TagCaption(1) != "" ? isAssessmentDone.TagCaption(1) : "Yes";
                } else {
                    isAssessmentDone.EditValue = isAssessmentDone.TagCaption(2) != "" ? isAssessmentDone.TagCaption(2) : "No";
                }
                isAssessmentDone.ViewCustomAttributes = "";

                // AssessmentScore
                AssessmentScore.SetupEditAttributes();
                AssessmentScore.EditValue = AssessmentScore.CurrentValue;
                AssessmentScore.ViewCustomAttributes = "";

                // dt_WrittenTestPassed
                dt_WrittenTestPassed.SetupEditAttributes();
                if (!Empty(dt_WrittenTestPassed.CurrentValue)) {
                    var optionsWrk = new OptionValues();
                    arWrk = ConvertToString(dt_WrittenTestPassed.CurrentValue).Split(Config.MultipleOptionSeparator);
                    for (int i = 0; i < arWrk.Length; i++) {
                        optionsWrk.Add(dt_WrittenTestPassed.HighlightLookup(arWrk[i].Trim(), dt_WrittenTestPassed.OptionCaption(arWrk[i].Trim())));
                    }
                    dt_WrittenTestPassed.EditValue = optionsWrk.ToString(); // DN
                } else {
                    dt_WrittenTestPassed.EditValue = DbNullValue;
                }
                dt_WrittenTestPassed.ViewCustomAttributes = "";

                // dt_RoadTestPassed
                dt_RoadTestPassed.SetupEditAttributes();
                if (!Empty(dt_RoadTestPassed.CurrentValue)) {
                    var optionsWrk = new OptionValues();
                    arWrk = ConvertToString(dt_RoadTestPassed.CurrentValue).Split(Config.MultipleOptionSeparator);
                    for (int i = 0; i < arWrk.Length; i++) {
                        optionsWrk.Add(dt_RoadTestPassed.HighlightLookup(arWrk[i].Trim(), dt_RoadTestPassed.OptionCaption(arWrk[i].Trim())));
                    }
                    dt_RoadTestPassed.EditValue = optionsWrk.ToString(); // DN
                } else {
                    dt_RoadTestPassed.EditValue = DbNullValue;
                }
                dt_RoadTestPassed.ViewCustomAttributes = "";

                // Absher_Appointment_number
                Absher_Appointment_number.SetupEditAttributes();
                Absher_Appointment_number.EditValue = ConvertToString(Absher_Appointment_number.CurrentValue); // DN
                Absher_Appointment_number.ViewCustomAttributes = "";

                // date_Birth_Hijri
                date_Birth_Hijri.SetupEditAttributes();
                date_Birth_Hijri.EditValue = ConvertToString(date_Birth_Hijri.CurrentValue); // DN
                date_Birth_Hijri.ViewCustomAttributes = "";

                // Activated
                Activated.SetupEditAttributes();
                if (ConvertToBool(Activated.CurrentValue)) {
                    Activated.EditValue = Activated.TagCaption(1) != "" ? Activated.TagCaption(1) : "Yes";
                } else {
                    Activated.EditValue = Activated.TagCaption(2) != "" ? Activated.TagCaption(2) : "No";
                }
                Activated.ViewCustomAttributes = "";

                // Absherphoto
                Absherphoto.SetupEditAttributes();
                Absherphoto.EditValue = ConvertToString(Absherphoto.CurrentValue); // DN
                Absherphoto.ViewCustomAttributes = "";

                // Required_Program
                Required_Program.SetupEditAttributes();
                Required_Program.EditValue = ConvertToString(Required_Program.CurrentValue); // DN
                Required_Program.ViewCustomAttributes = "";

                // Price
                Price.SetupEditAttributes();
                Price.EditValue = Price.CurrentValue;
                Price.EditValue = FormatCurrency(Price.EditValue, Price.FormatPattern);
                Price.ViewCustomAttributes = "";

                // Hijri_Day
                Hijri_Day.SetupEditAttributes();
                Hijri_Day.EditValue = Hijri_Day.CurrentValue;
                Hijri_Day.EditValue = FormatNumber(Hijri_Day.EditValue, Hijri_Day.FormatPattern);
                Hijri_Day.ViewCustomAttributes = "";

                // Hijri_Month
                Hijri_Month.SetupEditAttributes();
                Hijri_Month.EditValue = Hijri_Month.CurrentValue;
                Hijri_Month.EditValue = FormatNumber(Hijri_Month.EditValue, Hijri_Month.FormatPattern);
                Hijri_Month.ViewCustomAttributes = "";

                // Hijri_Year
                Hijri_Year.SetupEditAttributes();
                Hijri_Year.EditValue = Hijri_Year.CurrentValue;
                Hijri_Year.ViewCustomAttributes = "";

                // dec_Balance
                dec_Balance.SetupEditAttributes();
                dec_Balance.EditValue = dec_Balance.CurrentValue;
                dec_Balance.EditValue = FormatCurrency(dec_Balance.EditValue, dec_Balance.FormatPattern);
                dec_Balance.ViewCustomAttributes = "";

                // Payment_Online
                Payment_Online.SetupEditAttributes();
                Payment_Online.EditValue = ConvertToString(Payment_Online.CurrentValue); // DN
                Payment_Online.ViewCustomAttributes = "";

                // Institution
                Institution.SetupEditAttributes();
                Institution.EditValue = ConvertToString(Institution.CurrentValue); // DN
                Institution.ViewCustomAttributes = "";

                // WaitingList
                WaitingList.EditValue = WaitingList.Options(false);
                WaitingList.PlaceHolder = RemoveHtml(WaitingList.Caption);

                // Edit refer script

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";
                str_NationalID_Iqama.TooltipValue = "";

                // str_First_Name
                str_First_Name.HrefValue = "";
                str_First_Name.TooltipValue = "";

                // str_Middle_Name
                str_Middle_Name.HrefValue = "";
                str_Middle_Name.TooltipValue = "";

                // str_Last_Name
                str_Last_Name.HrefValue = "";
                str_Last_Name.TooltipValue = "";

                // str_Address1
                str_Address1.HrefValue = "";

                // str_Address2
                str_Address2.HrefValue = "";

                // int_State
                int_State.HrefValue = "";

                // str_City
                str_City.HrefValue = "";

                // str_Zip
                str_Zip.HrefValue = "";

                // str_Home_Phone
                str_Home_Phone.HrefValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";

                // str_Parent_Phone
                str_Parent_Phone.HrefValue = "";

                // str_Email
                str_Email.HrefValue = "";

                // str_ParentName
                str_ParentName.HrefValue = "";

                // str_DOB
                str_DOB.HrefValue = "";
                str_DOB.TooltipValue = "";

                // int_Age
                int_Age.HrefValue = "";
                int_Age.TooltipValue = "";

                // int_Sex
                int_Sex.HrefValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";

                // str_Student_Notes
                str_Student_Notes.HrefValue = "";

                // int_Location_Id
                int_Location_Id.HrefValue = "";
                int_Location_Id.TooltipValue = "";

                // date_Activated
                date_Activated.HrefValue = "";
                date_Activated.TooltipValue = "";

                // date_Created
                date_Created.HrefValue = "";
                date_Created.TooltipValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // strSMSNotification
                strSMSNotification.HrefValue = "";
                strSMSNotification.TooltipValue = "";

                // str_Weight
                str_Weight.HrefValue = "";

                // str_SpecialNeeds
                str_SpecialNeeds.HrefValue = "";

                // str_MedicalConditions
                str_MedicalConditions.HrefValue = "";

                // int_Nationality
                int_Nationality.HrefValue = "";
                int_Nationality.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";

                // IsScheduleassessment
                IsScheduleassessment.HrefValue = "";
                IsScheduleassessment.TooltipValue = "";

                // AssessmentDate
                AssessmentDate.HrefValue = "";
                AssessmentDate.TooltipValue = "";

                // isAssessmentDone
                isAssessmentDone.HrefValue = "";
                isAssessmentDone.TooltipValue = "";

                // AssessmentScore
                AssessmentScore.HrefValue = "";
                AssessmentScore.TooltipValue = "";

                // dt_WrittenTestPassed
                dt_WrittenTestPassed.HrefValue = "";
                dt_WrittenTestPassed.TooltipValue = "";

                // dt_RoadTestPassed
                dt_RoadTestPassed.HrefValue = "";
                dt_RoadTestPassed.TooltipValue = "";

                // Absher_Appointment_number
                Absher_Appointment_number.HrefValue = "";
                Absher_Appointment_number.TooltipValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";
                date_Birth_Hijri.TooltipValue = "";

                // Activated
                Activated.HrefValue = "";
                Activated.TooltipValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.TooltipValue = "";

                // Required_Program
                Required_Program.HrefValue = "";
                Required_Program.TooltipValue = "";

                // Price
                Price.HrefValue = "";
                Price.TooltipValue = "";

                // Hijri_Day
                Hijri_Day.HrefValue = "";
                Hijri_Day.TooltipValue = "";

                // Hijri_Month
                Hijri_Month.HrefValue = "";
                Hijri_Month.TooltipValue = "";

                // Hijri_Year
                Hijri_Year.HrefValue = "";
                Hijri_Year.TooltipValue = "";

                // dec_Balance
                dec_Balance.HrefValue = "";
                dec_Balance.TooltipValue = "";

                // Payment_Online
                if (!IsNull(Payment_Online.CurrentValue)) {
                    Payment_Online.HrefValue = Payment_Online.GetLinkPrefix() + ConvertToString(Payment_Online.CurrentValue); // Add prefix/suffix
                    Payment_Online.LinkAttrs["target"] = "_blank"; // Add target
                    if (IsExport())
                        Payment_Online.HrefValue = FullUrl(ConvertToString(Payment_Online.HrefValue), "href");
                } else {
                    Payment_Online.HrefValue = "";
                }
                Payment_Online.TooltipValue = "";

                // Institution
                Institution.HrefValue = "";
                Institution.TooltipValue = "";

                // WaitingList
                WaitingList.HrefValue = "";
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
            if (str_NationalID_Iqama.Required) {
                if (!str_NationalID_Iqama.IsDetailKey && Empty(str_NationalID_Iqama.FormValue)) {
                    str_NationalID_Iqama.AddErrorMessage(ConvertToString(str_NationalID_Iqama.RequiredErrorMessage).Replace("%s", str_NationalID_Iqama.Caption));
                }
            }
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
            if (str_Address1.Required) {
                if (!str_Address1.IsDetailKey && Empty(str_Address1.FormValue)) {
                    str_Address1.AddErrorMessage(ConvertToString(str_Address1.RequiredErrorMessage).Replace("%s", str_Address1.Caption));
                }
            }
            if (str_Address2.Required) {
                if (!str_Address2.IsDetailKey && Empty(str_Address2.FormValue)) {
                    str_Address2.AddErrorMessage(ConvertToString(str_Address2.RequiredErrorMessage).Replace("%s", str_Address2.Caption));
                }
            }
            if (int_State.Required) {
                if (!int_State.IsDetailKey && Empty(int_State.FormValue)) {
                    int_State.AddErrorMessage(ConvertToString(int_State.RequiredErrorMessage).Replace("%s", int_State.Caption));
                }
            }
            if (str_City.Required) {
                if (!str_City.IsDetailKey && Empty(str_City.FormValue)) {
                    str_City.AddErrorMessage(ConvertToString(str_City.RequiredErrorMessage).Replace("%s", str_City.Caption));
                }
            }
            if (str_Zip.Required) {
                if (!str_Zip.IsDetailKey && Empty(str_Zip.FormValue)) {
                    str_Zip.AddErrorMessage(ConvertToString(str_Zip.RequiredErrorMessage).Replace("%s", str_Zip.Caption));
                }
            }
            if (str_Home_Phone.Required) {
                if (!str_Home_Phone.IsDetailKey && Empty(str_Home_Phone.FormValue)) {
                    str_Home_Phone.AddErrorMessage(ConvertToString(str_Home_Phone.RequiredErrorMessage).Replace("%s", str_Home_Phone.Caption));
                }
            }
            if (str_Cell_Phone.Required) {
                if (!str_Cell_Phone.IsDetailKey && Empty(str_Cell_Phone.FormValue)) {
                    str_Cell_Phone.AddErrorMessage(ConvertToString(str_Cell_Phone.RequiredErrorMessage).Replace("%s", str_Cell_Phone.Caption));
                }
            }
            if (str_Parent_Phone.Required) {
                if (!str_Parent_Phone.IsDetailKey && Empty(str_Parent_Phone.FormValue)) {
                    str_Parent_Phone.AddErrorMessage(ConvertToString(str_Parent_Phone.RequiredErrorMessage).Replace("%s", str_Parent_Phone.Caption));
                }
            }
            if (str_Email.Required) {
                if (!str_Email.IsDetailKey && Empty(str_Email.FormValue)) {
                    str_Email.AddErrorMessage(ConvertToString(str_Email.RequiredErrorMessage).Replace("%s", str_Email.Caption));
                }
            }
            if (str_ParentName.Required) {
                if (!str_ParentName.IsDetailKey && Empty(str_ParentName.FormValue)) {
                    str_ParentName.AddErrorMessage(ConvertToString(str_ParentName.RequiredErrorMessage).Replace("%s", str_ParentName.Caption));
                }
            }
            if (str_DOB.Required) {
                if (!str_DOB.IsDetailKey && Empty(str_DOB.FormValue)) {
                    str_DOB.AddErrorMessage(ConvertToString(str_DOB.RequiredErrorMessage).Replace("%s", str_DOB.Caption));
                }
            }
            if (int_Age.Required) {
                if (!int_Age.IsDetailKey && Empty(int_Age.FormValue)) {
                    int_Age.AddErrorMessage(ConvertToString(int_Age.RequiredErrorMessage).Replace("%s", int_Age.Caption));
                }
            }
            if (int_Sex.Required) {
                if (!int_Sex.IsDetailKey && Empty(int_Sex.FormValue)) {
                    int_Sex.AddErrorMessage(ConvertToString(int_Sex.RequiredErrorMessage).Replace("%s", int_Sex.Caption));
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
            if (str_Student_Notes.Required) {
                if (!str_Student_Notes.IsDetailKey && Empty(str_Student_Notes.FormValue)) {
                    str_Student_Notes.AddErrorMessage(ConvertToString(str_Student_Notes.RequiredErrorMessage).Replace("%s", str_Student_Notes.Caption));
                }
            }
            if (int_Location_Id.Required) {
                if (!int_Location_Id.IsDetailKey && Empty(int_Location_Id.FormValue)) {
                    int_Location_Id.AddErrorMessage(ConvertToString(int_Location_Id.RequiredErrorMessage).Replace("%s", int_Location_Id.Caption));
                }
            }
            if (date_Activated.Required) {
                if (!date_Activated.IsDetailKey && Empty(date_Activated.FormValue)) {
                    date_Activated.AddErrorMessage(ConvertToString(date_Activated.RequiredErrorMessage).Replace("%s", date_Activated.Caption));
                }
            }
            if (date_Created.Required) {
                if (!date_Created.IsDetailKey && Empty(date_Created.FormValue)) {
                    date_Created.AddErrorMessage(ConvertToString(date_Created.RequiredErrorMessage).Replace("%s", date_Created.Caption));
                }
            }
            if (date_Modified.Required) {
                if (!date_Modified.IsDetailKey && Empty(date_Modified.FormValue)) {
                    date_Modified.AddErrorMessage(ConvertToString(date_Modified.RequiredErrorMessage).Replace("%s", date_Modified.Caption));
                }
            }
            if (strSMSNotification.Required) {
                if (!strSMSNotification.IsDetailKey && Empty(strSMSNotification.FormValue)) {
                    strSMSNotification.AddErrorMessage(ConvertToString(strSMSNotification.RequiredErrorMessage).Replace("%s", strSMSNotification.Caption));
                }
            }
            if (str_Weight.Required) {
                if (!str_Weight.IsDetailKey && Empty(str_Weight.FormValue)) {
                    str_Weight.AddErrorMessage(ConvertToString(str_Weight.RequiredErrorMessage).Replace("%s", str_Weight.Caption));
                }
            }
            if (str_SpecialNeeds.Required) {
                if (!str_SpecialNeeds.IsDetailKey && Empty(str_SpecialNeeds.FormValue)) {
                    str_SpecialNeeds.AddErrorMessage(ConvertToString(str_SpecialNeeds.RequiredErrorMessage).Replace("%s", str_SpecialNeeds.Caption));
                }
            }
            if (str_MedicalConditions.Required) {
                if (!str_MedicalConditions.IsDetailKey && Empty(str_MedicalConditions.FormValue)) {
                    str_MedicalConditions.AddErrorMessage(ConvertToString(str_MedicalConditions.RequiredErrorMessage).Replace("%s", str_MedicalConditions.Caption));
                }
            }
            if (int_Nationality.Required) {
                if (!int_Nationality.IsDetailKey && Empty(int_Nationality.FormValue)) {
                    int_Nationality.AddErrorMessage(ConvertToString(int_Nationality.RequiredErrorMessage).Replace("%s", int_Nationality.Caption));
                }
            }
            if (IsDrivingexperience.Required) {
                if (Empty(IsDrivingexperience.FormValue)) {
                    IsDrivingexperience.AddErrorMessage(ConvertToString(IsDrivingexperience.RequiredErrorMessage).Replace("%s", IsDrivingexperience.Caption));
                }
            }
            if (IsScheduleassessment.Required) {
                if (Empty(IsScheduleassessment.FormValue)) {
                    IsScheduleassessment.AddErrorMessage(ConvertToString(IsScheduleassessment.RequiredErrorMessage).Replace("%s", IsScheduleassessment.Caption));
                }
            }
            if (AssessmentDate.Required) {
                if (!AssessmentDate.IsDetailKey && Empty(AssessmentDate.FormValue)) {
                    AssessmentDate.AddErrorMessage(ConvertToString(AssessmentDate.RequiredErrorMessage).Replace("%s", AssessmentDate.Caption));
                }
            }
            if (isAssessmentDone.Required) {
                if (Empty(isAssessmentDone.FormValue)) {
                    isAssessmentDone.AddErrorMessage(ConvertToString(isAssessmentDone.RequiredErrorMessage).Replace("%s", isAssessmentDone.Caption));
                }
            }
            if (AssessmentScore.Required) {
                if (!AssessmentScore.IsDetailKey && Empty(AssessmentScore.FormValue)) {
                    AssessmentScore.AddErrorMessage(ConvertToString(AssessmentScore.RequiredErrorMessage).Replace("%s", AssessmentScore.Caption));
                }
            }
            if (dt_WrittenTestPassed.Required) {
                if (Empty(dt_WrittenTestPassed.FormValue)) {
                    dt_WrittenTestPassed.AddErrorMessage(ConvertToString(dt_WrittenTestPassed.RequiredErrorMessage).Replace("%s", dt_WrittenTestPassed.Caption));
                }
            }
            if (dt_RoadTestPassed.Required) {
                if (Empty(dt_RoadTestPassed.FormValue)) {
                    dt_RoadTestPassed.AddErrorMessage(ConvertToString(dt_RoadTestPassed.RequiredErrorMessage).Replace("%s", dt_RoadTestPassed.Caption));
                }
            }
            if (Absher_Appointment_number.Required) {
                if (!Absher_Appointment_number.IsDetailKey && Empty(Absher_Appointment_number.FormValue)) {
                    Absher_Appointment_number.AddErrorMessage(ConvertToString(Absher_Appointment_number.RequiredErrorMessage).Replace("%s", Absher_Appointment_number.Caption));
                }
            }
            if (date_Birth_Hijri.Required) {
                if (!date_Birth_Hijri.IsDetailKey && Empty(date_Birth_Hijri.FormValue)) {
                    date_Birth_Hijri.AddErrorMessage(ConvertToString(date_Birth_Hijri.RequiredErrorMessage).Replace("%s", date_Birth_Hijri.Caption));
                }
            }
            if (Activated.Required) {
                if (Empty(Activated.FormValue)) {
                    Activated.AddErrorMessage(ConvertToString(Activated.RequiredErrorMessage).Replace("%s", Activated.Caption));
                }
            }
            if (Absherphoto.Required) {
                if (!Absherphoto.IsDetailKey && Empty(Absherphoto.FormValue)) {
                    Absherphoto.AddErrorMessage(ConvertToString(Absherphoto.RequiredErrorMessage).Replace("%s", Absherphoto.Caption));
                }
            }
            if (Required_Program.Required) {
                if (!Required_Program.IsDetailKey && Empty(Required_Program.FormValue)) {
                    Required_Program.AddErrorMessage(ConvertToString(Required_Program.RequiredErrorMessage).Replace("%s", Required_Program.Caption));
                }
            }
            if (Price.Required) {
                if (!Price.IsDetailKey && Empty(Price.FormValue)) {
                    Price.AddErrorMessage(ConvertToString(Price.RequiredErrorMessage).Replace("%s", Price.Caption));
                }
            }
            if (Hijri_Day.Required) {
                if (!Hijri_Day.IsDetailKey && Empty(Hijri_Day.FormValue)) {
                    Hijri_Day.AddErrorMessage(ConvertToString(Hijri_Day.RequiredErrorMessage).Replace("%s", Hijri_Day.Caption));
                }
            }
            if (Hijri_Month.Required) {
                if (!Hijri_Month.IsDetailKey && Empty(Hijri_Month.FormValue)) {
                    Hijri_Month.AddErrorMessage(ConvertToString(Hijri_Month.RequiredErrorMessage).Replace("%s", Hijri_Month.Caption));
                }
            }
            if (Hijri_Year.Required) {
                if (!Hijri_Year.IsDetailKey && Empty(Hijri_Year.FormValue)) {
                    Hijri_Year.AddErrorMessage(ConvertToString(Hijri_Year.RequiredErrorMessage).Replace("%s", Hijri_Year.Caption));
                }
            }
            if (dec_Balance.Required) {
                if (!dec_Balance.IsDetailKey && Empty(dec_Balance.FormValue)) {
                    dec_Balance.AddErrorMessage(ConvertToString(dec_Balance.RequiredErrorMessage).Replace("%s", dec_Balance.Caption));
                }
            }
            if (Payment_Online.Required) {
                if (!Payment_Online.IsDetailKey && Empty(Payment_Online.FormValue)) {
                    Payment_Online.AddErrorMessage(ConvertToString(Payment_Online.RequiredErrorMessage).Replace("%s", Payment_Online.Caption));
                }
            }
            if (Institution.Required) {
                if (!Institution.IsDetailKey && Empty(Institution.FormValue)) {
                    Institution.AddErrorMessage(ConvertToString(Institution.RequiredErrorMessage).Replace("%s", Institution.Caption));
                }
            }
            if (WaitingList.Required) {
                if (Empty(WaitingList.FormValue)) {
                    WaitingList.AddErrorMessage(ConvertToString(WaitingList.RequiredErrorMessage).Replace("%s", WaitingList.Caption));
                }
            }

            // Validate detail grid
            var detailTblVar = CurrentDetailTables;
            if (detailTblVar.Contains("tblBillingInfo") && tblBillingInfo?.DetailEdit == true) {
                tblBillingInfoGrid = Resolve("TblBillingInfoGrid")!; // Get detail page object
                if (tblBillingInfoGrid != null)
                    validateForm = validateForm && await tblBillingInfoGrid.ValidateGridForm();
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

            // str_Address1
            str_Address1.SetDbValue(rsnew, str_Address1.CurrentValue, str_Address1.ReadOnly);

            // str_Address2
            str_Address2.SetDbValue(rsnew, str_Address2.CurrentValue, str_Address2.ReadOnly);

            // int_State
            int_State.SetDbValue(rsnew, int_State.CurrentValue, int_State.ReadOnly);

            // str_City
            str_City.SetDbValue(rsnew, str_City.CurrentValue, str_City.ReadOnly);

            // str_Zip
            str_Zip.SetDbValue(rsnew, str_Zip.CurrentValue, str_Zip.ReadOnly);

            // str_Home_Phone
            str_Home_Phone.SetDbValue(rsnew, str_Home_Phone.CurrentValue, str_Home_Phone.ReadOnly);

            // str_Cell_Phone
            str_Cell_Phone.SetDbValue(rsnew, str_Cell_Phone.CurrentValue, str_Cell_Phone.ReadOnly);

            // str_Parent_Phone
            str_Parent_Phone.SetDbValue(rsnew, str_Parent_Phone.CurrentValue, str_Parent_Phone.ReadOnly);

            // str_Email
            str_Email.SetDbValue(rsnew, str_Email.CurrentValue, str_Email.ReadOnly);

            // str_ParentName
            str_ParentName.SetDbValue(rsnew, str_ParentName.CurrentValue, str_ParentName.ReadOnly);

            // int_Sex
            int_Sex.SetDbValue(rsnew, int_Sex.CurrentValue, int_Sex.ReadOnly);

            // str_Emergency_Contact_Name
            str_Emergency_Contact_Name.SetDbValue(rsnew, str_Emergency_Contact_Name.CurrentValue, str_Emergency_Contact_Name.ReadOnly);

            // str_Emergency_Contact_Phone
            str_Emergency_Contact_Phone.SetDbValue(rsnew, str_Emergency_Contact_Phone.CurrentValue, str_Emergency_Contact_Phone.ReadOnly);

            // str_Emergency_Contact_Relation
            str_Emergency_Contact_Relation.SetDbValue(rsnew, str_Emergency_Contact_Relation.CurrentValue, str_Emergency_Contact_Relation.ReadOnly);

            // str_Student_Notes
            str_Student_Notes.SetDbValue(rsnew, str_Student_Notes.CurrentValue, str_Student_Notes.ReadOnly);

            // str_Weight
            str_Weight.SetDbValue(rsnew, str_Weight.CurrentValue, str_Weight.ReadOnly);

            // str_SpecialNeeds
            str_SpecialNeeds.SetDbValue(rsnew, str_SpecialNeeds.CurrentValue, str_SpecialNeeds.ReadOnly);

            // str_MedicalConditions
            str_MedicalConditions.SetDbValue(rsnew, str_MedicalConditions.CurrentValue, str_MedicalConditions.ReadOnly);

            // WaitingList
            WaitingList.SetDbValue(rsnew, ConvertToBool(WaitingList.CurrentValue), WaitingList.ReadOnly);

            // Update current values
            SetCurrentValues(rsnew);

            // Begin transaction
            if (!Empty(CurrentDetailTable) && UseTransaction)
                Connection.BeginTrans();

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

                    // Update detail records
                    var detailTblVar = CurrentDetailTables;
                    if (detailTblVar.Contains("tblBillingInfo") && tblBillingInfo?.DetailEdit == true && result) {
                        tblBillingInfoGrid = Resolve("TblBillingInfoGrid")!; // Get detail page object
                        if (tblBillingInfoGrid != null) {
                            Security.LoadCurrentUserLevel(ProjectID + "tblBillingInfo"); // Load user level of detail table
                            result = await tblBillingInfoGrid.GridUpdate();
                            Security.LoadCurrentUserLevel(ProjectID + TableName); // Restore user level of master table
                        }
                    }

                    // Commit/Rollback transaction
                    if (!Empty(CurrentDetailTable) && UseTransaction) {
                        if (result) {
                            Connection.CommitTrans(); // Commit transaction
                        } else {
                            Connection.RollbackTrans(); // Rollback transaction
                        }
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

        // Set up detail parms based on QueryString
        protected void SetupDetailParms() {
            StringValues detailTblVar = "";
            // Get the keys for master table
            if (Query.TryGetValue(Config.TableShowDetail, out detailTblVar)) { // Do not use Get()
                CurrentDetailTable = detailTblVar.ToString();
            } else {
                detailTblVar = CurrentDetailTable;
            }
            if (!Empty(detailTblVar)) {
                var detailTblVars = detailTblVar.ToString().Split(',');
                if (detailTblVars.Contains("tblBillingInfo")) {
                    tblBillingInfoGrid = Resolve("TblBillingInfoGrid")!;
                    if (tblBillingInfoGrid?.DetailEdit ?? false) {
                        tblBillingInfoGrid.CurrentMode = "edit";
                        if (IsConfirm)
                            tblBillingInfoGrid.CurrentAction = "confirm";
                        else
                            tblBillingInfoGrid.CurrentAction = "gridedit";
                        if (IsCancel)
                            tblBillingInfoGrid.EventCancelled = true;

                        // Save current master table to detail table
                        tblBillingInfoGrid.CurrentMasterTable = TableVar;
                        tblBillingInfoGrid.StartRecordNumber = 1;
                        tblBillingInfoGrid.NationalID.IsDetailKey = true;
                        tblBillingInfoGrid.NationalID.CurrentValue = NationalID.CurrentValue;
                        tblBillingInfoGrid.NationalID.SessionValue = tblBillingInfoGrid.NationalID.CurrentValue;
                    }
                }
            }
        }

        // Reset detail parms
        protected void ResetDetailParms() {
            StringValues detailTblVar = "";
            // Get the keys for master table
            if (Query.TryGetValue(Config.TableShowDetail, out detailTblVar)) { // Do not use Get()
                CurrentDetailTable = detailTblVar.ToString();
            } else {
                detailTblVar = CurrentDetailTable;
            }
            if (!Empty(detailTblVar)) {
                var detailTblVars = detailTblVar.ToString().Split(',');
                if (detailTblVars.Contains("tblBillingInfo")) {
                    tblBillingInfoGrid = Resolve("TblBillingInfoGrid")!;
                    if (tblBillingInfoGrid?.DetailEdit ?? false) {
                        tblBillingInfoGrid.CurrentAction = "gridedit";
                    }
                }
            }
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblPotentialStudentInfoList")), "", TableVar, true);
            string pageId = "edit";
            breadcrumb.Add("edit", pageId, url);
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
            pages.Add(4);
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
