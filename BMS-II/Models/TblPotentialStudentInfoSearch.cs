namespace ASPNETMaker2023.Models;

// Partial class
public partial class JUN26 {
    /// <summary>
    /// tblPotentialStudentInfoSearch
    /// </summary>
    public static TblPotentialStudentInfoSearch tblPotentialStudentInfoSearch
    {
        get => HttpData.Get<TblPotentialStudentInfoSearch>("tblPotentialStudentInfoSearch")!;
        set => HttpData["tblPotentialStudentInfoSearch"] = value;
    }

    /// <summary>
    /// Page class for tblPotentialStudentInfo
    /// </summary>
    public class TblPotentialStudentInfoSearch : TblPotentialStudentInfoSearchBase
    {
        // Constructor
        public TblPotentialStudentInfoSearch(Controller controller) : base(controller)
        {
        }

        // Constructor
        public TblPotentialStudentInfoSearch() : base()
        {
        }
    }

    /// <summary>
    /// Page base class
    /// </summary>
    public class TblPotentialStudentInfoSearchBase : TblPotentialStudentInfo
    {
        // Page ID
        public string PageID = "search";

        // Project ID
        public string ProjectID = "{58F886EE-30CC-4C06-BB53-F2D76AC39924}";

        // Table name
        public string TableName { get; set; } = "tblPotentialStudentInfo";

        // Page object name
        public string PageObjName = "tblPotentialStudentInfoSearch";

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
        public TblPotentialStudentInfoSearchBase()
        {
            // Initialize
            CurrentPage = this;

            // Table CSS class
            TableClass = "table table-bordered table-hover ew-desktop-table ew-search-table";

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
        public string PageName => "TblPotentialStudentInfoSearch";

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
            int_Potential_Student_ID.SetVisibility();
            int_Student_Id.SetVisibility();
            str_NationalID_Iqama.SetVisibility();
            NationalID.SetVisibility();
            str_First_Name.SetVisibility();
            str_Middle_Name.SetVisibility();
            str_Last_Name.SetVisibility();
            str_Address1.SetVisibility();
            str_Address2.SetVisibility();
            int_State.SetVisibility();
            str_City.SetVisibility();
            str_Zip.SetVisibility();
            int_Instructor.SetVisibility();
            int_Driver.SetVisibility();
            str_Home_Phone.SetVisibility();
            str_Cell_Phone.SetVisibility();
            str_Parent_Phone.SetVisibility();
            str_Other_Phone.SetVisibility();
            str_Email.SetVisibility();
            str_ParentName.SetVisibility();
            str_ParentEmail1.SetVisibility();
            str_ParentEmail2.SetVisibility();
            str_Username.SetVisibility();
            str_Password.SetVisibility();
            str_DOB.SetVisibility();
            int_DOB_Day.SetVisibility();
            int_DOB_Month.SetVisibility();
            int_DOB_Year.SetVisibility();
            int_Age.SetVisibility();
            int_Type.SetVisibility();
            int_Wear_Glasses.SetVisibility();
            int_Sex.SetVisibility();
            str_DLPermit.SetVisibility();
            dt_Date_PermitIssue.SetVisibility();
            dt_Date_ExpirePermit.SetVisibility();
            int_Hs_ID.SetVisibility();
            str_Emergency_Contact_Name.SetVisibility();
            str_Emergency_Contact_Phone.SetVisibility();
            str_Emergency_Contact_Relation.SetVisibility();
            str_Student_Notes.SetVisibility();
            str_Driving_Notes.SetVisibility();
            int_Location_Id.SetVisibility();
            int_Permit_Number.SetVisibility();
            Permit_Issue_Date.SetVisibility();
            Permit_Expiry_Date.SetVisibility();
            int_Status.SetVisibility();
            int_Lead_Id.SetVisibility();
            int_Activated_By.SetVisibility();
            date_Activated.SetVisibility();
            date_Created.SetVisibility();
            date_Modified.SetVisibility();
            date_Complete.SetVisibility();
            int_Created_By.SetVisibility();
            int_Modified_By.SetVisibility();
            bit_IsDeleted.SetVisibility();
            str_CardHolderName.SetVisibility();
            str_CardHolderAddress.SetVisibility();
            str_CardHolderCity.SetVisibility();
            str_CardHolderZip.SetVisibility();
            str_CardType.SetVisibility();
            str_CardExpMonth.SetVisibility();
            str_CardExpYear.SetVisibility();
            str_CardNo.SetVisibility();
            str_Certificate_No.SetVisibility();
            str_AmountPaid.SetVisibility();
            str_PermitValidated.SetVisibility();
            strSMSNotification.SetVisibility();
            strVoiceNotification.SetVisibility();
            str_Weight.SetVisibility();
            str_SpecialNeeds.SetVisibility();
            str_MedicalConditions.SetVisibility();
            bit_Verified_PIC_InSAW.SetVisibility();
            bit_Permit_Waiver_Entered.SetVisibility();
            bit_TermsConditions.SetVisibility();
            bit_Disable_Self_Scheduling.SetVisibility();
            int_EyeColor.SetVisibility();
            int_HairColor.SetVisibility();
            int_ColorBlind.SetVisibility();
            int_HeightFeet.SetVisibility();
            int_HeightInches.SetVisibility();
            str_reference_code.SetVisibility();
            dt_ParentClassAttendedDt.SetVisibility();
            str_ParentClassAttendedLoc.SetVisibility();
            dt_SiblingClassAttendedDt.SetVisibility();
            str_SiblingClassAttendedLoc.SetVisibility();
            bit_PoliciesAndProcedures.SetVisibility();
            dt_CourseCompletionDt.SetVisibility();
            dt_ExtensionDt.SetVisibility();
            str_MedicalCondition.SetVisibility();
            str_MajorCrossStreets.SetVisibility();
            str_DriverEdCertNo.SetVisibility();
            dt_DriverEdCertIssuedDt.SetVisibility();
            str_BTWDriversEdCertNo.SetVisibility();
            dt_BTWCertIssuedDt.SetVisibility();
            str_OLDriversEdCertNo.SetVisibility();
            dt_OLCertIssuedDt.SetVisibility();
            str_height.SetVisibility();
            dt_BTWCompletionDt.SetVisibility();
            dt_CRCompletionDt.SetVisibility();
            strTextBox5.SetVisibility();
            strTextBox6.SetVisibility();
            str_ApartmentNo.SetVisibility();
            dt_PermitTestDate.SetVisibility();
            str_OnlineDriverEdLogin.SetVisibility();
            str_OnlineDriverEdPassword.SetVisibility();
            bit_IsSMSEnabled.SetVisibility();
            dt_SMSModified.SetVisibility();
            str_confirmPassword.SetVisibility();
            DE_Certificate.SetVisibility();
            Discuss.SetVisibility();
            int_UnlicensedSibling.SetVisibility();
            int_YearSiblingIsEligible.SetVisibility();
            BTW_Certificate.SetVisibility();
            dt_DECertIssueDate.SetVisibility();
            str_StudentSignature.SetVisibility();
            str_ParentSignature.SetVisibility();
            str_Last6DigitsOfParentDriversLicense.SetVisibility();
            str_FACControl.SetVisibility();
            Classroom_Status_Code.SetVisibility();
            Laboratory_Status_Code.SetVisibility();
            bit_EnrollmentForm.SetVisibility();
            bit_ParentStudentContract.SetVisibility();
            bit_ParentalAgreement.SetVisibility();
            int_SF_GR_WA_HS.SetVisibility();
            bit_DisableOnRMV.SetVisibility();
            bit_UploadedToRMV.SetVisibility();
            str_Mother_Name.SetVisibility();
            str_Guardians_Name.SetVisibility();
            str_Mother_Phone.SetVisibility();
            bit_terms.SetVisibility();
            int_Nationality.SetVisibility();
            str_National_ID_en.SetVisibility();
            str_National_ID_arabic.SetVisibility();
            Quallification_Id.SetVisibility();
            Job_Id.SetVisibility();
            str_DOB_arabic.SetVisibility();
            int_Language.SetVisibility();
            strRefId.SetVisibility();
            int_Program_Id.SetVisibility();
            IsDrivingexperience.SetVisibility();
            IsScheduleassessment.SetVisibility();
            IsEnrollbyyourself.SetVisibility();
            AssessmentTime.SetVisibility();
            AssessmentDate.SetVisibility();
            isAssessmentDone.SetVisibility();
            AssessmentScore.SetVisibility();
            dt_WrittenTestPassed.SetVisibility();
            dt_RoadTestPassed.SetVisibility();
            bit_Archive.SetVisibility();
            ArchiveNotes.SetVisibility();
            dtArchived.SetVisibility();
            SrNo9Dec21.SetVisibility();
            REGNNUMB.SetVisibility();
            REGNLOCN.SetVisibility();
            SrNo11DecF1S1.SetVisibility();
            IsInterestedInTraining.SetVisibility();
            StudentEncryptID.SetVisibility();
            StudentConfirURL.SetVisibility();
            SrNo15DecF1S2.SetVisibility();
            SrNo15DecF1S3.SetVisibility();
            SrNo16DecF2S2.SetVisibility();
            SrNo16DecF2S3.SetVisibility();
            SrNo16DecF3S1.SetVisibility();
            SrNo16DecF3S2.SetVisibility();
            SrNo16DecF4S1.SetVisibility();
            SrNo16DecF4S2.SetVisibility();
            SrNo16DecF4S3.SetVisibility();
            StudentAssementBookingURL.SetVisibility();
            intDrivinglicenseType.SetVisibility();
            Isdrivinglicense.SetVisibility();
            drivinglicensenumber.SetVisibility();
            Absher_Appointment_number.SetVisibility();
            DataImportId.SetVisibility();
            date_Birth_Hijri.SetVisibility();
            UserlevelID.SetVisibility();
            Activated.SetVisibility();
            Absherphoto.SetVisibility();
            Fingerprint.SetVisibility();
            Required_Program.SetVisibility();
            Price.SetVisibility();
            Hijri_Day.SetVisibility();
            Hijri_Month.SetVisibility();
            Hijri_Year.SetVisibility();
            Course_Price.SetVisibility();
            Vat_Tax_15.SetVisibility();
            dec_Balance.SetVisibility();
            Total_Price.SetVisibility();
            Payment_Online.SetVisibility();
            Institution.SetVisibility();
            WaitingList.SetVisibility();
            Assessment_ID.SetVisibility();
        }

        // Constructor
        public TblPotentialStudentInfoSearchBase(Controller? controller = null): this() { // DN
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
                    srchStr = "TblPotentialStudentInfoList?" + srchStr;
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
                tblPotentialStudentInfoSearch?.PageRender();
            }
            return PageResult();
        }

        // Build advanced search
        protected string BuildAdvancedSearch() {
            string srchUrl = "";
            BuildSearchUrl(ref srchUrl, int_Potential_Student_ID); // int_Potential_Student_ID
            BuildSearchUrl(ref srchUrl, int_Student_Id); // int_Student_Id
            BuildSearchUrl(ref srchUrl, str_NationalID_Iqama); // str_NationalID_Iqama
            BuildSearchUrl(ref srchUrl, NationalID); // NationalID
            BuildSearchUrl(ref srchUrl, str_First_Name); // str_First_Name
            BuildSearchUrl(ref srchUrl, str_Middle_Name); // str_Middle_Name
            BuildSearchUrl(ref srchUrl, str_Last_Name); // str_Last_Name
            BuildSearchUrl(ref srchUrl, str_Address1); // str_Address1
            BuildSearchUrl(ref srchUrl, str_Address2); // str_Address2
            BuildSearchUrl(ref srchUrl, int_State); // int_State
            BuildSearchUrl(ref srchUrl, str_City); // str_City
            BuildSearchUrl(ref srchUrl, str_Zip); // str_Zip
            BuildSearchUrl(ref srchUrl, int_Instructor); // int_Instructor
            BuildSearchUrl(ref srchUrl, int_Driver); // int_Driver
            BuildSearchUrl(ref srchUrl, str_Home_Phone); // str_Home_Phone
            BuildSearchUrl(ref srchUrl, str_Cell_Phone); // str_Cell_Phone
            BuildSearchUrl(ref srchUrl, str_Parent_Phone); // str_Parent_Phone
            BuildSearchUrl(ref srchUrl, str_Other_Phone); // str_Other_Phone
            BuildSearchUrl(ref srchUrl, str_Email); // str_Email
            BuildSearchUrl(ref srchUrl, str_ParentName); // str_ParentName
            BuildSearchUrl(ref srchUrl, str_ParentEmail1); // str_ParentEmail1
            BuildSearchUrl(ref srchUrl, str_ParentEmail2); // str_ParentEmail2
            BuildSearchUrl(ref srchUrl, str_Username); // str_Username
            BuildSearchUrl(ref srchUrl, str_Password); // str_Password
            BuildSearchUrl(ref srchUrl, str_DOB); // str_DOB
            BuildSearchUrl(ref srchUrl, int_DOB_Day); // int_DOB_Day
            BuildSearchUrl(ref srchUrl, int_DOB_Month); // int_DOB_Month
            BuildSearchUrl(ref srchUrl, int_DOB_Year); // int_DOB_Year
            BuildSearchUrl(ref srchUrl, int_Age); // int_Age
            BuildSearchUrl(ref srchUrl, int_Type); // int_Type
            BuildSearchUrl(ref srchUrl, int_Wear_Glasses); // int_Wear_Glasses
            BuildSearchUrl(ref srchUrl, int_Sex); // int_Sex
            BuildSearchUrl(ref srchUrl, str_DLPermit); // str_DLPermit
            BuildSearchUrl(ref srchUrl, dt_Date_PermitIssue); // dt_Date_PermitIssue
            BuildSearchUrl(ref srchUrl, dt_Date_ExpirePermit); // dt_Date_ExpirePermit
            BuildSearchUrl(ref srchUrl, int_Hs_ID); // int_Hs_ID
            BuildSearchUrl(ref srchUrl, str_Emergency_Contact_Name); // str_Emergency_Contact_Name
            BuildSearchUrl(ref srchUrl, str_Emergency_Contact_Phone); // str_Emergency_Contact_Phone
            BuildSearchUrl(ref srchUrl, str_Emergency_Contact_Relation); // str_Emergency_Contact_Relation
            BuildSearchUrl(ref srchUrl, str_Student_Notes); // str_Student_Notes
            BuildSearchUrl(ref srchUrl, str_Driving_Notes); // str_Driving_Notes
            BuildSearchUrl(ref srchUrl, int_Location_Id); // int_Location_Id
            BuildSearchUrl(ref srchUrl, int_Permit_Number); // int_Permit_Number
            BuildSearchUrl(ref srchUrl, Permit_Issue_Date); // Permit_Issue_Date
            BuildSearchUrl(ref srchUrl, Permit_Expiry_Date); // Permit_Expiry_Date
            BuildSearchUrl(ref srchUrl, int_Status); // int_Status
            BuildSearchUrl(ref srchUrl, int_Lead_Id); // int_Lead_Id
            BuildSearchUrl(ref srchUrl, int_Activated_By); // int_Activated_By
            BuildSearchUrl(ref srchUrl, date_Activated); // date_Activated
            BuildSearchUrl(ref srchUrl, date_Created); // date_Created
            BuildSearchUrl(ref srchUrl, date_Modified); // date_Modified
            BuildSearchUrl(ref srchUrl, date_Complete); // date_Complete
            BuildSearchUrl(ref srchUrl, int_Created_By); // int_Created_By
            BuildSearchUrl(ref srchUrl, int_Modified_By); // int_Modified_By
            BuildSearchUrl(ref srchUrl, bit_IsDeleted, true); // bit_IsDeleted
            BuildSearchUrl(ref srchUrl, str_CardHolderName); // str_CardHolderName
            BuildSearchUrl(ref srchUrl, str_CardHolderAddress); // str_CardHolderAddress
            BuildSearchUrl(ref srchUrl, str_CardHolderCity); // str_CardHolderCity
            BuildSearchUrl(ref srchUrl, str_CardHolderZip); // str_CardHolderZip
            BuildSearchUrl(ref srchUrl, str_CardType); // str_CardType
            BuildSearchUrl(ref srchUrl, str_CardExpMonth); // str_CardExpMonth
            BuildSearchUrl(ref srchUrl, str_CardExpYear); // str_CardExpYear
            BuildSearchUrl(ref srchUrl, str_CardNo); // str_CardNo
            BuildSearchUrl(ref srchUrl, str_Certificate_No); // str_Certificate_No
            BuildSearchUrl(ref srchUrl, str_AmountPaid); // str_AmountPaid
            BuildSearchUrl(ref srchUrl, str_PermitValidated); // str_PermitValidated
            BuildSearchUrl(ref srchUrl, strSMSNotification); // strSMSNotification
            BuildSearchUrl(ref srchUrl, strVoiceNotification); // strVoiceNotification
            BuildSearchUrl(ref srchUrl, str_Weight); // str_Weight
            BuildSearchUrl(ref srchUrl, str_SpecialNeeds); // str_SpecialNeeds
            BuildSearchUrl(ref srchUrl, str_MedicalConditions); // str_MedicalConditions
            BuildSearchUrl(ref srchUrl, bit_Verified_PIC_InSAW); // bit_Verified_PIC_InSAW
            BuildSearchUrl(ref srchUrl, bit_Permit_Waiver_Entered); // bit_Permit_Waiver_Entered
            BuildSearchUrl(ref srchUrl, bit_TermsConditions); // bit_TermsConditions
            BuildSearchUrl(ref srchUrl, bit_Disable_Self_Scheduling); // bit_Disable_Self_Scheduling
            BuildSearchUrl(ref srchUrl, int_EyeColor); // int_EyeColor
            BuildSearchUrl(ref srchUrl, int_HairColor); // int_HairColor
            BuildSearchUrl(ref srchUrl, int_ColorBlind); // int_ColorBlind
            BuildSearchUrl(ref srchUrl, int_HeightFeet); // int_HeightFeet
            BuildSearchUrl(ref srchUrl, int_HeightInches); // int_HeightInches
            BuildSearchUrl(ref srchUrl, str_reference_code); // str_reference_code
            BuildSearchUrl(ref srchUrl, dt_ParentClassAttendedDt); // dt_ParentClassAttendedDt
            BuildSearchUrl(ref srchUrl, str_ParentClassAttendedLoc); // str_ParentClassAttendedLoc
            BuildSearchUrl(ref srchUrl, dt_SiblingClassAttendedDt); // dt_SiblingClassAttendedDt
            BuildSearchUrl(ref srchUrl, str_SiblingClassAttendedLoc); // str_SiblingClassAttendedLoc
            BuildSearchUrl(ref srchUrl, bit_PoliciesAndProcedures, true); // bit_PoliciesAndProcedures
            BuildSearchUrl(ref srchUrl, dt_CourseCompletionDt); // dt_CourseCompletionDt
            BuildSearchUrl(ref srchUrl, dt_ExtensionDt); // dt_ExtensionDt
            BuildSearchUrl(ref srchUrl, str_MedicalCondition); // str_MedicalCondition
            BuildSearchUrl(ref srchUrl, str_MajorCrossStreets); // str_MajorCrossStreets
            BuildSearchUrl(ref srchUrl, str_DriverEdCertNo); // str_DriverEdCertNo
            BuildSearchUrl(ref srchUrl, dt_DriverEdCertIssuedDt); // dt_DriverEdCertIssuedDt
            BuildSearchUrl(ref srchUrl, str_BTWDriversEdCertNo); // str_BTWDriversEdCertNo
            BuildSearchUrl(ref srchUrl, dt_BTWCertIssuedDt); // dt_BTWCertIssuedDt
            BuildSearchUrl(ref srchUrl, str_OLDriversEdCertNo); // str_OLDriversEdCertNo
            BuildSearchUrl(ref srchUrl, dt_OLCertIssuedDt); // dt_OLCertIssuedDt
            BuildSearchUrl(ref srchUrl, str_height); // str_height
            BuildSearchUrl(ref srchUrl, dt_BTWCompletionDt); // dt_BTWCompletionDt
            BuildSearchUrl(ref srchUrl, dt_CRCompletionDt); // dt_CRCompletionDt
            BuildSearchUrl(ref srchUrl, strTextBox5); // strTextBox5
            BuildSearchUrl(ref srchUrl, strTextBox6); // strTextBox6
            BuildSearchUrl(ref srchUrl, str_ApartmentNo); // str_ApartmentNo
            BuildSearchUrl(ref srchUrl, dt_PermitTestDate); // dt_PermitTestDate
            BuildSearchUrl(ref srchUrl, str_OnlineDriverEdLogin); // str_OnlineDriverEdLogin
            BuildSearchUrl(ref srchUrl, str_OnlineDriverEdPassword); // str_OnlineDriverEdPassword
            BuildSearchUrl(ref srchUrl, bit_IsSMSEnabled, true); // bit_IsSMSEnabled
            BuildSearchUrl(ref srchUrl, dt_SMSModified); // dt_SMSModified
            BuildSearchUrl(ref srchUrl, str_confirmPassword); // str_confirmPassword
            BuildSearchUrl(ref srchUrl, DE_Certificate); // DE_Certificate
            BuildSearchUrl(ref srchUrl, Discuss); // Discuss
            BuildSearchUrl(ref srchUrl, int_UnlicensedSibling); // int_UnlicensedSibling
            BuildSearchUrl(ref srchUrl, int_YearSiblingIsEligible); // int_YearSiblingIsEligible
            BuildSearchUrl(ref srchUrl, BTW_Certificate); // BTW_Certificate
            BuildSearchUrl(ref srchUrl, dt_DECertIssueDate); // dt_DECertIssueDate
            BuildSearchUrl(ref srchUrl, str_StudentSignature); // str_StudentSignature
            BuildSearchUrl(ref srchUrl, str_ParentSignature); // str_ParentSignature
            BuildSearchUrl(ref srchUrl, str_Last6DigitsOfParentDriversLicense); // str_Last6DigitsOfParentDriversLicense
            BuildSearchUrl(ref srchUrl, str_FACControl); // str_FACControl
            BuildSearchUrl(ref srchUrl, Classroom_Status_Code); // Classroom_Status_Code
            BuildSearchUrl(ref srchUrl, Laboratory_Status_Code); // Laboratory_Status_Code
            BuildSearchUrl(ref srchUrl, bit_EnrollmentForm, true); // bit_EnrollmentForm
            BuildSearchUrl(ref srchUrl, bit_ParentStudentContract, true); // bit_ParentStudentContract
            BuildSearchUrl(ref srchUrl, bit_ParentalAgreement, true); // bit_ParentalAgreement
            BuildSearchUrl(ref srchUrl, int_SF_GR_WA_HS); // int_SF_GR_WA_HS
            BuildSearchUrl(ref srchUrl, bit_DisableOnRMV, true); // bit_DisableOnRMV
            BuildSearchUrl(ref srchUrl, bit_UploadedToRMV, true); // bit_UploadedToRMV
            BuildSearchUrl(ref srchUrl, str_Mother_Name); // str_Mother_Name
            BuildSearchUrl(ref srchUrl, str_Guardians_Name); // str_Guardians_Name
            BuildSearchUrl(ref srchUrl, str_Mother_Phone); // str_Mother_Phone
            BuildSearchUrl(ref srchUrl, bit_terms, true); // bit_terms
            BuildSearchUrl(ref srchUrl, int_Nationality); // int_Nationality
            BuildSearchUrl(ref srchUrl, str_National_ID_en); // str_National_ID_en
            BuildSearchUrl(ref srchUrl, str_National_ID_arabic); // str_National_ID_arabic
            BuildSearchUrl(ref srchUrl, Quallification_Id); // Quallification_Id
            BuildSearchUrl(ref srchUrl, Job_Id); // Job_Id
            BuildSearchUrl(ref srchUrl, str_DOB_arabic); // str_DOB_arabic
            BuildSearchUrl(ref srchUrl, int_Language); // int_Language
            BuildSearchUrl(ref srchUrl, strRefId); // strRefId
            BuildSearchUrl(ref srchUrl, int_Program_Id); // int_Program_Id
            BuildSearchUrl(ref srchUrl, IsDrivingexperience, true); // IsDrivingexperience
            BuildSearchUrl(ref srchUrl, IsScheduleassessment, true); // IsScheduleassessment
            BuildSearchUrl(ref srchUrl, IsEnrollbyyourself, true); // IsEnrollbyyourself
            BuildSearchUrl(ref srchUrl, AssessmentTime); // AssessmentTime
            BuildSearchUrl(ref srchUrl, AssessmentDate); // AssessmentDate
            BuildSearchUrl(ref srchUrl, isAssessmentDone, true); // isAssessmentDone
            BuildSearchUrl(ref srchUrl, AssessmentScore); // AssessmentScore
            BuildSearchUrl(ref srchUrl, dt_WrittenTestPassed); // dt_WrittenTestPassed
            BuildSearchUrl(ref srchUrl, dt_RoadTestPassed); // dt_RoadTestPassed
            BuildSearchUrl(ref srchUrl, bit_Archive, true); // bit_Archive
            BuildSearchUrl(ref srchUrl, ArchiveNotes); // ArchiveNotes
            BuildSearchUrl(ref srchUrl, dtArchived); // dtArchived
            BuildSearchUrl(ref srchUrl, SrNo9Dec21); // SrNo9Dec21
            BuildSearchUrl(ref srchUrl, REGNNUMB); // REGNNUMB
            BuildSearchUrl(ref srchUrl, REGNLOCN); // REGNLOCN
            BuildSearchUrl(ref srchUrl, SrNo11DecF1S1); // SrNo11DecF1S1
            BuildSearchUrl(ref srchUrl, IsInterestedInTraining); // IsInterestedInTraining
            BuildSearchUrl(ref srchUrl, StudentEncryptID); // StudentEncryptID
            BuildSearchUrl(ref srchUrl, StudentConfirURL); // StudentConfirURL
            BuildSearchUrl(ref srchUrl, SrNo15DecF1S2); // SrNo15DecF1S2
            BuildSearchUrl(ref srchUrl, SrNo15DecF1S3); // SrNo15DecF1S3
            BuildSearchUrl(ref srchUrl, SrNo16DecF2S2); // SrNo16DecF2S2
            BuildSearchUrl(ref srchUrl, SrNo16DecF2S3); // SrNo16DecF2S3
            BuildSearchUrl(ref srchUrl, SrNo16DecF3S1); // SrNo16DecF3S1
            BuildSearchUrl(ref srchUrl, SrNo16DecF3S2); // SrNo16DecF3S2
            BuildSearchUrl(ref srchUrl, SrNo16DecF4S1); // SrNo16DecF4S1
            BuildSearchUrl(ref srchUrl, SrNo16DecF4S2); // SrNo16DecF4S2
            BuildSearchUrl(ref srchUrl, SrNo16DecF4S3); // SrNo16DecF4S3
            BuildSearchUrl(ref srchUrl, StudentAssementBookingURL); // StudentAssementBookingURL
            BuildSearchUrl(ref srchUrl, intDrivinglicenseType); // intDrivinglicenseType
            BuildSearchUrl(ref srchUrl, Isdrivinglicense, true); // Isdrivinglicense
            BuildSearchUrl(ref srchUrl, drivinglicensenumber); // drivinglicensenumber
            BuildSearchUrl(ref srchUrl, Absher_Appointment_number); // Absher_Appointment_number
            BuildSearchUrl(ref srchUrl, DataImportId); // DataImportId
            BuildSearchUrl(ref srchUrl, date_Birth_Hijri); // date_Birth_Hijri
            BuildSearchUrl(ref srchUrl, UserlevelID); // UserlevelID
            BuildSearchUrl(ref srchUrl, Activated, true); // Activated
            BuildSearchUrl(ref srchUrl, Absherphoto); // Absherphoto
            BuildSearchUrl(ref srchUrl, Fingerprint); // Fingerprint
            BuildSearchUrl(ref srchUrl, Required_Program); // Required_Program
            BuildSearchUrl(ref srchUrl, Price); // Price
            BuildSearchUrl(ref srchUrl, Hijri_Day); // Hijri_Day
            BuildSearchUrl(ref srchUrl, Hijri_Month); // Hijri_Month
            BuildSearchUrl(ref srchUrl, Hijri_Year); // Hijri_Year
            BuildSearchUrl(ref srchUrl, Course_Price); // Course_Price
            BuildSearchUrl(ref srchUrl, Vat_Tax_15); // Vat_Tax_15
            BuildSearchUrl(ref srchUrl, dec_Balance); // dec_Balance
            BuildSearchUrl(ref srchUrl, Total_Price); // Total_Price
            BuildSearchUrl(ref srchUrl, Payment_Online); // Payment_Online
            BuildSearchUrl(ref srchUrl, Institution); // Institution
            BuildSearchUrl(ref srchUrl, WaitingList, true); // WaitingList
            BuildSearchUrl(ref srchUrl, Assessment_ID); // Assessment_ID
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
            // int_Potential_Student_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Potential_Student_ID"))
                    int_Potential_Student_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Potential_Student_ID");
            if (Form.ContainsKey("z_int_Potential_Student_ID"))
                int_Potential_Student_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Potential_Student_ID");

            // int_Student_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Student_Id"))
                    int_Student_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Student_Id");
            if (Form.ContainsKey("z_int_Student_Id"))
                int_Student_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Student_Id");

            // str_NationalID_Iqama
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_NationalID_Iqama"))
                    str_NationalID_Iqama.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_NationalID_Iqama");
            if (Form.ContainsKey("z_str_NationalID_Iqama"))
                str_NationalID_Iqama.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_NationalID_Iqama");

            // NationalID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_NationalID"))
                    NationalID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_NationalID");
            if (Form.ContainsKey("z_NationalID"))
                NationalID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_NationalID");

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

            // str_Address1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Address1"))
                    str_Address1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Address1");
            if (Form.ContainsKey("z_str_Address1"))
                str_Address1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Address1");

            // str_Address2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Address2"))
                    str_Address2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Address2");
            if (Form.ContainsKey("z_str_Address2"))
                str_Address2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Address2");

            // int_State
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_State"))
                    int_State.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_State");
            if (Form.ContainsKey("z_int_State"))
                int_State.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_State");

            // str_City
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_City"))
                    str_City.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_City");
            if (Form.ContainsKey("z_str_City"))
                str_City.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_City");

            // str_Zip
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Zip"))
                    str_Zip.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Zip");
            if (Form.ContainsKey("z_str_Zip"))
                str_Zip.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Zip");

            // int_Instructor
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Instructor"))
                    int_Instructor.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Instructor");
            if (Form.ContainsKey("z_int_Instructor"))
                int_Instructor.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Instructor");

            // int_Driver
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Driver"))
                    int_Driver.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Driver");
            if (Form.ContainsKey("z_int_Driver"))
                int_Driver.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Driver");

            // str_Home_Phone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Home_Phone"))
                    str_Home_Phone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Home_Phone");
            if (Form.ContainsKey("z_str_Home_Phone"))
                str_Home_Phone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Home_Phone");

            // str_Cell_Phone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Cell_Phone"))
                    str_Cell_Phone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Cell_Phone");
            if (Form.ContainsKey("z_str_Cell_Phone"))
                str_Cell_Phone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Cell_Phone");

            // str_Parent_Phone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Parent_Phone"))
                    str_Parent_Phone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Parent_Phone");
            if (Form.ContainsKey("z_str_Parent_Phone"))
                str_Parent_Phone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Parent_Phone");

            // str_Other_Phone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Other_Phone"))
                    str_Other_Phone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Other_Phone");
            if (Form.ContainsKey("z_str_Other_Phone"))
                str_Other_Phone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Other_Phone");

            // str_Email
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Email"))
                    str_Email.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Email");
            if (Form.ContainsKey("z_str_Email"))
                str_Email.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Email");

            // str_ParentName
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_ParentName"))
                    str_ParentName.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_ParentName");
            if (Form.ContainsKey("z_str_ParentName"))
                str_ParentName.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_ParentName");

            // str_ParentEmail1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_ParentEmail1"))
                    str_ParentEmail1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_ParentEmail1");
            if (Form.ContainsKey("z_str_ParentEmail1"))
                str_ParentEmail1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_ParentEmail1");

            // str_ParentEmail2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_ParentEmail2"))
                    str_ParentEmail2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_ParentEmail2");
            if (Form.ContainsKey("z_str_ParentEmail2"))
                str_ParentEmail2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_ParentEmail2");

            // str_Username
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Username"))
                    str_Username.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Username");
            if (Form.ContainsKey("z_str_Username"))
                str_Username.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Username");

            // str_Password
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Password"))
                    str_Password.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Password");
            if (Form.ContainsKey("z_str_Password"))
                str_Password.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Password");

            // str_DOB
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_DOB"))
                    str_DOB.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_DOB");
            if (Form.ContainsKey("z_str_DOB"))
                str_DOB.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_DOB");

            // int_DOB_Day
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_DOB_Day"))
                    int_DOB_Day.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_DOB_Day");
            if (Form.ContainsKey("z_int_DOB_Day"))
                int_DOB_Day.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_DOB_Day");

            // int_DOB_Month
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_DOB_Month"))
                    int_DOB_Month.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_DOB_Month");
            if (Form.ContainsKey("z_int_DOB_Month"))
                int_DOB_Month.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_DOB_Month");

            // int_DOB_Year
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_DOB_Year"))
                    int_DOB_Year.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_DOB_Year");
            if (Form.ContainsKey("z_int_DOB_Year"))
                int_DOB_Year.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_DOB_Year");

            // int_Age
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Age"))
                    int_Age.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Age");
            if (Form.ContainsKey("z_int_Age"))
                int_Age.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Age");

            // int_Type
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Type"))
                    int_Type.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Type");
            if (Form.ContainsKey("z_int_Type"))
                int_Type.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Type");

            // int_Wear_Glasses
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Wear_Glasses"))
                    int_Wear_Glasses.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Wear_Glasses");
            if (Form.ContainsKey("z_int_Wear_Glasses"))
                int_Wear_Glasses.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Wear_Glasses");

            // int_Sex
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Sex"))
                    int_Sex.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Sex");
            if (Form.ContainsKey("z_int_Sex"))
                int_Sex.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Sex");

            // str_DLPermit
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_DLPermit"))
                    str_DLPermit.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_DLPermit");
            if (Form.ContainsKey("z_str_DLPermit"))
                str_DLPermit.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_DLPermit");

            // dt_Date_PermitIssue
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_Date_PermitIssue"))
                    dt_Date_PermitIssue.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_Date_PermitIssue");
            if (Form.ContainsKey("z_dt_Date_PermitIssue"))
                dt_Date_PermitIssue.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_Date_PermitIssue");

            // dt_Date_ExpirePermit
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_Date_ExpirePermit"))
                    dt_Date_ExpirePermit.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_Date_ExpirePermit");
            if (Form.ContainsKey("z_dt_Date_ExpirePermit"))
                dt_Date_ExpirePermit.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_Date_ExpirePermit");

            // int_Hs_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Hs_ID"))
                    int_Hs_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Hs_ID");
            if (Form.ContainsKey("z_int_Hs_ID"))
                int_Hs_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Hs_ID");

            // str_Emergency_Contact_Name
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Emergency_Contact_Name"))
                    str_Emergency_Contact_Name.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Emergency_Contact_Name");
            if (Form.ContainsKey("z_str_Emergency_Contact_Name"))
                str_Emergency_Contact_Name.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Emergency_Contact_Name");

            // str_Emergency_Contact_Phone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Emergency_Contact_Phone"))
                    str_Emergency_Contact_Phone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Emergency_Contact_Phone");
            if (Form.ContainsKey("z_str_Emergency_Contact_Phone"))
                str_Emergency_Contact_Phone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Emergency_Contact_Phone");

            // str_Emergency_Contact_Relation
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Emergency_Contact_Relation"))
                    str_Emergency_Contact_Relation.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Emergency_Contact_Relation");
            if (Form.ContainsKey("z_str_Emergency_Contact_Relation"))
                str_Emergency_Contact_Relation.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Emergency_Contact_Relation");

            // str_Student_Notes
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Student_Notes"))
                    str_Student_Notes.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Student_Notes");
            if (Form.ContainsKey("z_str_Student_Notes"))
                str_Student_Notes.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Student_Notes");

            // str_Driving_Notes
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Driving_Notes"))
                    str_Driving_Notes.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Driving_Notes");
            if (Form.ContainsKey("z_str_Driving_Notes"))
                str_Driving_Notes.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Driving_Notes");

            // int_Location_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Location_Id"))
                    int_Location_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Location_Id");
            if (Form.ContainsKey("z_int_Location_Id"))
                int_Location_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Location_Id");

            // int_Permit_Number
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Permit_Number"))
                    int_Permit_Number.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Permit_Number");
            if (Form.ContainsKey("z_int_Permit_Number"))
                int_Permit_Number.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Permit_Number");

            // Permit_Issue_Date
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Permit_Issue_Date"))
                    Permit_Issue_Date.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Permit_Issue_Date");
            if (Form.ContainsKey("z_Permit_Issue_Date"))
                Permit_Issue_Date.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Permit_Issue_Date");

            // Permit_Expiry_Date
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Permit_Expiry_Date"))
                    Permit_Expiry_Date.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Permit_Expiry_Date");
            if (Form.ContainsKey("z_Permit_Expiry_Date"))
                Permit_Expiry_Date.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Permit_Expiry_Date");

            // int_Status
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Status"))
                    int_Status.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Status");
            if (Form.ContainsKey("z_int_Status"))
                int_Status.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Status");

            // int_Lead_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Lead_Id"))
                    int_Lead_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Lead_Id");
            if (Form.ContainsKey("z_int_Lead_Id"))
                int_Lead_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Lead_Id");

            // int_Activated_By
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Activated_By"))
                    int_Activated_By.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Activated_By");
            if (Form.ContainsKey("z_int_Activated_By"))
                int_Activated_By.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Activated_By");

            // date_Activated
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Activated"))
                    date_Activated.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Activated");
            if (Form.ContainsKey("z_date_Activated"))
                date_Activated.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Activated");

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

            // date_Complete
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Complete"))
                    date_Complete.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Complete");
            if (Form.ContainsKey("z_date_Complete"))
                date_Complete.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Complete");

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

            // bit_IsDeleted
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_IsDeleted"))
                    bit_IsDeleted.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_IsDeleted");
            if (Form.ContainsKey("z_bit_IsDeleted"))
                bit_IsDeleted.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_IsDeleted");

            // str_CardHolderName
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_CardHolderName"))
                    str_CardHolderName.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_CardHolderName");
            if (Form.ContainsKey("z_str_CardHolderName"))
                str_CardHolderName.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_CardHolderName");

            // str_CardHolderAddress
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_CardHolderAddress"))
                    str_CardHolderAddress.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_CardHolderAddress");
            if (Form.ContainsKey("z_str_CardHolderAddress"))
                str_CardHolderAddress.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_CardHolderAddress");

            // str_CardHolderCity
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_CardHolderCity"))
                    str_CardHolderCity.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_CardHolderCity");
            if (Form.ContainsKey("z_str_CardHolderCity"))
                str_CardHolderCity.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_CardHolderCity");

            // str_CardHolderZip
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_CardHolderZip"))
                    str_CardHolderZip.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_CardHolderZip");
            if (Form.ContainsKey("z_str_CardHolderZip"))
                str_CardHolderZip.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_CardHolderZip");

            // str_CardType
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_CardType"))
                    str_CardType.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_CardType");
            if (Form.ContainsKey("z_str_CardType"))
                str_CardType.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_CardType");

            // str_CardExpMonth
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_CardExpMonth"))
                    str_CardExpMonth.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_CardExpMonth");
            if (Form.ContainsKey("z_str_CardExpMonth"))
                str_CardExpMonth.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_CardExpMonth");

            // str_CardExpYear
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_CardExpYear"))
                    str_CardExpYear.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_CardExpYear");
            if (Form.ContainsKey("z_str_CardExpYear"))
                str_CardExpYear.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_CardExpYear");

            // str_CardNo
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_CardNo"))
                    str_CardNo.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_CardNo");
            if (Form.ContainsKey("z_str_CardNo"))
                str_CardNo.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_CardNo");

            // str_Certificate_No
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Certificate_No"))
                    str_Certificate_No.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Certificate_No");
            if (Form.ContainsKey("z_str_Certificate_No"))
                str_Certificate_No.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Certificate_No");

            // str_AmountPaid
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_AmountPaid"))
                    str_AmountPaid.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_AmountPaid");
            if (Form.ContainsKey("z_str_AmountPaid"))
                str_AmountPaid.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_AmountPaid");

            // str_PermitValidated
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_PermitValidated"))
                    str_PermitValidated.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_PermitValidated");
            if (Form.ContainsKey("z_str_PermitValidated"))
                str_PermitValidated.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_PermitValidated");

            // strSMSNotification
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_strSMSNotification"))
                    strSMSNotification.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_strSMSNotification");
            if (Form.ContainsKey("z_strSMSNotification"))
                strSMSNotification.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_strSMSNotification");

            // strVoiceNotification
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_strVoiceNotification"))
                    strVoiceNotification.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_strVoiceNotification");
            if (Form.ContainsKey("z_strVoiceNotification"))
                strVoiceNotification.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_strVoiceNotification");

            // str_Weight
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Weight"))
                    str_Weight.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Weight");
            if (Form.ContainsKey("z_str_Weight"))
                str_Weight.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Weight");

            // str_SpecialNeeds
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_SpecialNeeds"))
                    str_SpecialNeeds.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_SpecialNeeds");
            if (Form.ContainsKey("z_str_SpecialNeeds"))
                str_SpecialNeeds.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_SpecialNeeds");

            // str_MedicalConditions
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_MedicalConditions"))
                    str_MedicalConditions.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_MedicalConditions");
            if (Form.ContainsKey("z_str_MedicalConditions"))
                str_MedicalConditions.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_MedicalConditions");

            // bit_Verified_PIC_InSAW
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_Verified_PIC_InSAW"))
                    bit_Verified_PIC_InSAW.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_Verified_PIC_InSAW");
            if (Form.ContainsKey("z_bit_Verified_PIC_InSAW"))
                bit_Verified_PIC_InSAW.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_Verified_PIC_InSAW");

            // bit_Permit_Waiver_Entered
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_Permit_Waiver_Entered"))
                    bit_Permit_Waiver_Entered.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_Permit_Waiver_Entered");
            if (Form.ContainsKey("z_bit_Permit_Waiver_Entered"))
                bit_Permit_Waiver_Entered.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_Permit_Waiver_Entered");

            // bit_TermsConditions
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_TermsConditions"))
                    bit_TermsConditions.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_TermsConditions");
            if (Form.ContainsKey("z_bit_TermsConditions"))
                bit_TermsConditions.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_TermsConditions");

            // bit_Disable_Self_Scheduling
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_Disable_Self_Scheduling"))
                    bit_Disable_Self_Scheduling.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_Disable_Self_Scheduling");
            if (Form.ContainsKey("z_bit_Disable_Self_Scheduling"))
                bit_Disable_Self_Scheduling.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_Disable_Self_Scheduling");

            // int_EyeColor
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_EyeColor"))
                    int_EyeColor.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_EyeColor");
            if (Form.ContainsKey("z_int_EyeColor"))
                int_EyeColor.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_EyeColor");

            // int_HairColor
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_HairColor"))
                    int_HairColor.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_HairColor");
            if (Form.ContainsKey("z_int_HairColor"))
                int_HairColor.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_HairColor");

            // int_ColorBlind
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_ColorBlind"))
                    int_ColorBlind.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_ColorBlind");
            if (Form.ContainsKey("z_int_ColorBlind"))
                int_ColorBlind.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_ColorBlind");

            // int_HeightFeet
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_HeightFeet"))
                    int_HeightFeet.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_HeightFeet");
            if (Form.ContainsKey("z_int_HeightFeet"))
                int_HeightFeet.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_HeightFeet");

            // int_HeightInches
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_HeightInches"))
                    int_HeightInches.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_HeightInches");
            if (Form.ContainsKey("z_int_HeightInches"))
                int_HeightInches.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_HeightInches");

            // str_reference_code
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_reference_code"))
                    str_reference_code.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_reference_code");
            if (Form.ContainsKey("z_str_reference_code"))
                str_reference_code.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_reference_code");

            // dt_ParentClassAttendedDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_ParentClassAttendedDt"))
                    dt_ParentClassAttendedDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_ParentClassAttendedDt");
            if (Form.ContainsKey("z_dt_ParentClassAttendedDt"))
                dt_ParentClassAttendedDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_ParentClassAttendedDt");

            // str_ParentClassAttendedLoc
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_ParentClassAttendedLoc"))
                    str_ParentClassAttendedLoc.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_ParentClassAttendedLoc");
            if (Form.ContainsKey("z_str_ParentClassAttendedLoc"))
                str_ParentClassAttendedLoc.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_ParentClassAttendedLoc");

            // dt_SiblingClassAttendedDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_SiblingClassAttendedDt"))
                    dt_SiblingClassAttendedDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_SiblingClassAttendedDt");
            if (Form.ContainsKey("z_dt_SiblingClassAttendedDt"))
                dt_SiblingClassAttendedDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_SiblingClassAttendedDt");

            // str_SiblingClassAttendedLoc
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_SiblingClassAttendedLoc"))
                    str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_SiblingClassAttendedLoc");
            if (Form.ContainsKey("z_str_SiblingClassAttendedLoc"))
                str_SiblingClassAttendedLoc.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_SiblingClassAttendedLoc");

            // bit_PoliciesAndProcedures
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_PoliciesAndProcedures"))
                    bit_PoliciesAndProcedures.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_PoliciesAndProcedures");
            if (Form.ContainsKey("z_bit_PoliciesAndProcedures"))
                bit_PoliciesAndProcedures.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_PoliciesAndProcedures");

            // dt_CourseCompletionDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_CourseCompletionDt"))
                    dt_CourseCompletionDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_CourseCompletionDt");
            if (Form.ContainsKey("z_dt_CourseCompletionDt"))
                dt_CourseCompletionDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_CourseCompletionDt");

            // dt_ExtensionDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_ExtensionDt"))
                    dt_ExtensionDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_ExtensionDt");
            if (Form.ContainsKey("z_dt_ExtensionDt"))
                dt_ExtensionDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_ExtensionDt");

            // str_MedicalCondition
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_MedicalCondition"))
                    str_MedicalCondition.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_MedicalCondition");
            if (Form.ContainsKey("z_str_MedicalCondition"))
                str_MedicalCondition.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_MedicalCondition");

            // str_MajorCrossStreets
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_MajorCrossStreets"))
                    str_MajorCrossStreets.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_MajorCrossStreets");
            if (Form.ContainsKey("z_str_MajorCrossStreets"))
                str_MajorCrossStreets.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_MajorCrossStreets");

            // str_DriverEdCertNo
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_DriverEdCertNo"))
                    str_DriverEdCertNo.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_DriverEdCertNo");
            if (Form.ContainsKey("z_str_DriverEdCertNo"))
                str_DriverEdCertNo.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_DriverEdCertNo");

            // dt_DriverEdCertIssuedDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_DriverEdCertIssuedDt"))
                    dt_DriverEdCertIssuedDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_DriverEdCertIssuedDt");
            if (Form.ContainsKey("z_dt_DriverEdCertIssuedDt"))
                dt_DriverEdCertIssuedDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_DriverEdCertIssuedDt");

            // str_BTWDriversEdCertNo
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_BTWDriversEdCertNo"))
                    str_BTWDriversEdCertNo.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_BTWDriversEdCertNo");
            if (Form.ContainsKey("z_str_BTWDriversEdCertNo"))
                str_BTWDriversEdCertNo.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_BTWDriversEdCertNo");

            // dt_BTWCertIssuedDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_BTWCertIssuedDt"))
                    dt_BTWCertIssuedDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_BTWCertIssuedDt");
            if (Form.ContainsKey("z_dt_BTWCertIssuedDt"))
                dt_BTWCertIssuedDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_BTWCertIssuedDt");

            // str_OLDriversEdCertNo
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_OLDriversEdCertNo"))
                    str_OLDriversEdCertNo.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_OLDriversEdCertNo");
            if (Form.ContainsKey("z_str_OLDriversEdCertNo"))
                str_OLDriversEdCertNo.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_OLDriversEdCertNo");

            // dt_OLCertIssuedDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_OLCertIssuedDt"))
                    dt_OLCertIssuedDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_OLCertIssuedDt");
            if (Form.ContainsKey("z_dt_OLCertIssuedDt"))
                dt_OLCertIssuedDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_OLCertIssuedDt");

            // str_height
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_height"))
                    str_height.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_height");
            if (Form.ContainsKey("z_str_height"))
                str_height.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_height");

            // dt_BTWCompletionDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_BTWCompletionDt"))
                    dt_BTWCompletionDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_BTWCompletionDt");
            if (Form.ContainsKey("z_dt_BTWCompletionDt"))
                dt_BTWCompletionDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_BTWCompletionDt");

            // dt_CRCompletionDt
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_CRCompletionDt"))
                    dt_CRCompletionDt.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_CRCompletionDt");
            if (Form.ContainsKey("z_dt_CRCompletionDt"))
                dt_CRCompletionDt.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_CRCompletionDt");

            // strTextBox5
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_strTextBox5"))
                    strTextBox5.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_strTextBox5");
            if (Form.ContainsKey("z_strTextBox5"))
                strTextBox5.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_strTextBox5");

            // strTextBox6
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_strTextBox6"))
                    strTextBox6.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_strTextBox6");
            if (Form.ContainsKey("z_strTextBox6"))
                strTextBox6.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_strTextBox6");

            // str_ApartmentNo
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_ApartmentNo"))
                    str_ApartmentNo.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_ApartmentNo");
            if (Form.ContainsKey("z_str_ApartmentNo"))
                str_ApartmentNo.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_ApartmentNo");

            // dt_PermitTestDate
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_PermitTestDate"))
                    dt_PermitTestDate.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_PermitTestDate");
            if (Form.ContainsKey("z_dt_PermitTestDate"))
                dt_PermitTestDate.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_PermitTestDate");

            // str_OnlineDriverEdLogin
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_OnlineDriverEdLogin"))
                    str_OnlineDriverEdLogin.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_OnlineDriverEdLogin");
            if (Form.ContainsKey("z_str_OnlineDriverEdLogin"))
                str_OnlineDriverEdLogin.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_OnlineDriverEdLogin");

            // str_OnlineDriverEdPassword
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_OnlineDriverEdPassword"))
                    str_OnlineDriverEdPassword.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_OnlineDriverEdPassword");
            if (Form.ContainsKey("z_str_OnlineDriverEdPassword"))
                str_OnlineDriverEdPassword.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_OnlineDriverEdPassword");

            // bit_IsSMSEnabled
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_IsSMSEnabled"))
                    bit_IsSMSEnabled.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_IsSMSEnabled");
            if (Form.ContainsKey("z_bit_IsSMSEnabled"))
                bit_IsSMSEnabled.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_IsSMSEnabled");

            // dt_SMSModified
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_SMSModified"))
                    dt_SMSModified.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_SMSModified");
            if (Form.ContainsKey("z_dt_SMSModified"))
                dt_SMSModified.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_SMSModified");

            // str_confirmPassword
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_confirmPassword"))
                    str_confirmPassword.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_confirmPassword");
            if (Form.ContainsKey("z_str_confirmPassword"))
                str_confirmPassword.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_confirmPassword");

            // DE_Certificate
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_DE_Certificate"))
                    DE_Certificate.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_DE_Certificate");
            if (Form.ContainsKey("z_DE_Certificate"))
                DE_Certificate.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_DE_Certificate");

            // Discuss
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Discuss"))
                    Discuss.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Discuss");
            if (Form.ContainsKey("z_Discuss"))
                Discuss.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Discuss");

            // int_UnlicensedSibling
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_UnlicensedSibling"))
                    int_UnlicensedSibling.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_UnlicensedSibling");
            if (Form.ContainsKey("z_int_UnlicensedSibling"))
                int_UnlicensedSibling.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_UnlicensedSibling");

            // int_YearSiblingIsEligible
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_YearSiblingIsEligible"))
                    int_YearSiblingIsEligible.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_YearSiblingIsEligible");
            if (Form.ContainsKey("z_int_YearSiblingIsEligible"))
                int_YearSiblingIsEligible.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_YearSiblingIsEligible");

            // BTW_Certificate
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_BTW_Certificate"))
                    BTW_Certificate.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_BTW_Certificate");
            if (Form.ContainsKey("z_BTW_Certificate"))
                BTW_Certificate.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_BTW_Certificate");

            // dt_DECertIssueDate
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_DECertIssueDate"))
                    dt_DECertIssueDate.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_DECertIssueDate");
            if (Form.ContainsKey("z_dt_DECertIssueDate"))
                dt_DECertIssueDate.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_DECertIssueDate");

            // str_StudentSignature
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_StudentSignature"))
                    str_StudentSignature.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_StudentSignature");
            if (Form.ContainsKey("z_str_StudentSignature"))
                str_StudentSignature.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_StudentSignature");

            // str_ParentSignature
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_ParentSignature"))
                    str_ParentSignature.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_ParentSignature");
            if (Form.ContainsKey("z_str_ParentSignature"))
                str_ParentSignature.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_ParentSignature");

            // str_Last6DigitsOfParentDriversLicense
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Last6DigitsOfParentDriversLicense"))
                    str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Last6DigitsOfParentDriversLicense");
            if (Form.ContainsKey("z_str_Last6DigitsOfParentDriversLicense"))
                str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Last6DigitsOfParentDriversLicense");

            // str_FACControl
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_FACControl"))
                    str_FACControl.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_FACControl");
            if (Form.ContainsKey("z_str_FACControl"))
                str_FACControl.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_FACControl");

            // Classroom_Status_Code
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Classroom_Status_Code"))
                    Classroom_Status_Code.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Classroom_Status_Code");
            if (Form.ContainsKey("z_Classroom_Status_Code"))
                Classroom_Status_Code.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Classroom_Status_Code");

            // Laboratory_Status_Code
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Laboratory_Status_Code"))
                    Laboratory_Status_Code.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Laboratory_Status_Code");
            if (Form.ContainsKey("z_Laboratory_Status_Code"))
                Laboratory_Status_Code.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Laboratory_Status_Code");

            // bit_EnrollmentForm
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_EnrollmentForm"))
                    bit_EnrollmentForm.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_EnrollmentForm");
            if (Form.ContainsKey("z_bit_EnrollmentForm"))
                bit_EnrollmentForm.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_EnrollmentForm");

            // bit_ParentStudentContract
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_ParentStudentContract"))
                    bit_ParentStudentContract.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_ParentStudentContract");
            if (Form.ContainsKey("z_bit_ParentStudentContract"))
                bit_ParentStudentContract.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_ParentStudentContract");

            // bit_ParentalAgreement
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_ParentalAgreement"))
                    bit_ParentalAgreement.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_ParentalAgreement");
            if (Form.ContainsKey("z_bit_ParentalAgreement"))
                bit_ParentalAgreement.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_ParentalAgreement");

            // int_SF_GR_WA_HS
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_SF_GR_WA_HS"))
                    int_SF_GR_WA_HS.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_SF_GR_WA_HS");
            if (Form.ContainsKey("z_int_SF_GR_WA_HS"))
                int_SF_GR_WA_HS.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_SF_GR_WA_HS");

            // bit_DisableOnRMV
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_DisableOnRMV"))
                    bit_DisableOnRMV.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_DisableOnRMV");
            if (Form.ContainsKey("z_bit_DisableOnRMV"))
                bit_DisableOnRMV.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_DisableOnRMV");

            // bit_UploadedToRMV
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_UploadedToRMV"))
                    bit_UploadedToRMV.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_UploadedToRMV");
            if (Form.ContainsKey("z_bit_UploadedToRMV"))
                bit_UploadedToRMV.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_UploadedToRMV");

            // str_Mother_Name
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Mother_Name"))
                    str_Mother_Name.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Mother_Name");
            if (Form.ContainsKey("z_str_Mother_Name"))
                str_Mother_Name.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Mother_Name");

            // str_Guardians_Name
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Guardians_Name"))
                    str_Guardians_Name.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Guardians_Name");
            if (Form.ContainsKey("z_str_Guardians_Name"))
                str_Guardians_Name.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Guardians_Name");

            // str_Mother_Phone
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_Mother_Phone"))
                    str_Mother_Phone.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_Mother_Phone");
            if (Form.ContainsKey("z_str_Mother_Phone"))
                str_Mother_Phone.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_Mother_Phone");

            // bit_terms
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_terms"))
                    bit_terms.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_terms");
            if (Form.ContainsKey("z_bit_terms"))
                bit_terms.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_terms");

            // int_Nationality
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Nationality"))
                    int_Nationality.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Nationality");
            if (Form.ContainsKey("z_int_Nationality"))
                int_Nationality.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Nationality");

            // str_National_ID_en
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_National_ID_en"))
                    str_National_ID_en.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_National_ID_en");
            if (Form.ContainsKey("z_str_National_ID_en"))
                str_National_ID_en.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_National_ID_en");

            // str_National_ID_arabic
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_National_ID_arabic"))
                    str_National_ID_arabic.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_National_ID_arabic");
            if (Form.ContainsKey("z_str_National_ID_arabic"))
                str_National_ID_arabic.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_National_ID_arabic");

            // Quallification_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Quallification_Id"))
                    Quallification_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Quallification_Id");
            if (Form.ContainsKey("z_Quallification_Id"))
                Quallification_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Quallification_Id");

            // Job_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Job_Id"))
                    Job_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Job_Id");
            if (Form.ContainsKey("z_Job_Id"))
                Job_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Job_Id");

            // str_DOB_arabic
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_str_DOB_arabic[]"))
                    str_DOB_arabic.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_str_DOB_arabic[]");
            if (Form.ContainsKey("z_str_DOB_arabic"))
                str_DOB_arabic.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_str_DOB_arabic");

            // int_Language
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Language"))
                    int_Language.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Language");
            if (Form.ContainsKey("z_int_Language"))
                int_Language.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Language");

            // strRefId
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_strRefId"))
                    strRefId.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_strRefId");
            if (Form.ContainsKey("z_strRefId"))
                strRefId.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_strRefId");

            // int_Program_Id
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_int_Program_Id"))
                    int_Program_Id.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_int_Program_Id");
            if (Form.ContainsKey("z_int_Program_Id"))
                int_Program_Id.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_int_Program_Id");

            // IsDrivingexperience
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_IsDrivingexperience"))
                    IsDrivingexperience.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_IsDrivingexperience");
            if (Form.ContainsKey("z_IsDrivingexperience"))
                IsDrivingexperience.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_IsDrivingexperience");

            // IsScheduleassessment
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_IsScheduleassessment"))
                    IsScheduleassessment.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_IsScheduleassessment");
            if (Form.ContainsKey("z_IsScheduleassessment"))
                IsScheduleassessment.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_IsScheduleassessment");

            // IsEnrollbyyourself
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_IsEnrollbyyourself"))
                    IsEnrollbyyourself.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_IsEnrollbyyourself");
            if (Form.ContainsKey("z_IsEnrollbyyourself"))
                IsEnrollbyyourself.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_IsEnrollbyyourself");

            // AssessmentTime
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AssessmentTime"))
                    AssessmentTime.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AssessmentTime");
            if (Form.ContainsKey("z_AssessmentTime"))
                AssessmentTime.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AssessmentTime");

            // AssessmentDate
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_AssessmentDate"))
                    AssessmentDate.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_AssessmentDate");
            if (Form.ContainsKey("z_AssessmentDate"))
                AssessmentDate.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_AssessmentDate");

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

            // dt_WrittenTestPassed
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_WrittenTestPassed[]"))
                    dt_WrittenTestPassed.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_WrittenTestPassed[]");
            if (Form.ContainsKey("z_dt_WrittenTestPassed"))
                dt_WrittenTestPassed.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_WrittenTestPassed");

            // dt_RoadTestPassed
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dt_RoadTestPassed[]"))
                    dt_RoadTestPassed.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dt_RoadTestPassed[]");
            if (Form.ContainsKey("z_dt_RoadTestPassed"))
                dt_RoadTestPassed.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dt_RoadTestPassed");

            // bit_Archive
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_bit_Archive"))
                    bit_Archive.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_bit_Archive");
            if (Form.ContainsKey("z_bit_Archive"))
                bit_Archive.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_bit_Archive");

            // ArchiveNotes
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_ArchiveNotes"))
                    ArchiveNotes.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_ArchiveNotes");
            if (Form.ContainsKey("z_ArchiveNotes"))
                ArchiveNotes.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_ArchiveNotes");

            // dtArchived
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dtArchived"))
                    dtArchived.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dtArchived");
            if (Form.ContainsKey("z_dtArchived"))
                dtArchived.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dtArchived");

            // SrNo9Dec21
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo9Dec21"))
                    SrNo9Dec21.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo9Dec21");
            if (Form.ContainsKey("z_SrNo9Dec21"))
                SrNo9Dec21.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo9Dec21");

            // REGNNUMB
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_REGNNUMB"))
                    REGNNUMB.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_REGNNUMB");
            if (Form.ContainsKey("z_REGNNUMB"))
                REGNNUMB.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_REGNNUMB");

            // REGNLOCN
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_REGNLOCN"))
                    REGNLOCN.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_REGNLOCN");
            if (Form.ContainsKey("z_REGNLOCN"))
                REGNLOCN.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_REGNLOCN");

            // SrNo11DecF1S1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo11DecF1S1"))
                    SrNo11DecF1S1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo11DecF1S1");
            if (Form.ContainsKey("z_SrNo11DecF1S1"))
                SrNo11DecF1S1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo11DecF1S1");

            // IsInterestedInTraining
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_IsInterestedInTraining"))
                    IsInterestedInTraining.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_IsInterestedInTraining");
            if (Form.ContainsKey("z_IsInterestedInTraining"))
                IsInterestedInTraining.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_IsInterestedInTraining");

            // StudentEncryptID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_StudentEncryptID"))
                    StudentEncryptID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_StudentEncryptID");
            if (Form.ContainsKey("z_StudentEncryptID"))
                StudentEncryptID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_StudentEncryptID");

            // StudentConfirURL
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_StudentConfirURL"))
                    StudentConfirURL.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_StudentConfirURL");
            if (Form.ContainsKey("z_StudentConfirURL"))
                StudentConfirURL.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_StudentConfirURL");

            // SrNo15DecF1S2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo15DecF1S2"))
                    SrNo15DecF1S2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo15DecF1S2");
            if (Form.ContainsKey("z_SrNo15DecF1S2"))
                SrNo15DecF1S2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo15DecF1S2");

            // SrNo15DecF1S3
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo15DecF1S3"))
                    SrNo15DecF1S3.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo15DecF1S3");
            if (Form.ContainsKey("z_SrNo15DecF1S3"))
                SrNo15DecF1S3.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo15DecF1S3");

            // SrNo16DecF2S2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo16DecF2S2"))
                    SrNo16DecF2S2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo16DecF2S2");
            if (Form.ContainsKey("z_SrNo16DecF2S2"))
                SrNo16DecF2S2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo16DecF2S2");

            // SrNo16DecF2S3
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo16DecF2S3"))
                    SrNo16DecF2S3.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo16DecF2S3");
            if (Form.ContainsKey("z_SrNo16DecF2S3"))
                SrNo16DecF2S3.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo16DecF2S3");

            // SrNo16DecF3S1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo16DecF3S1"))
                    SrNo16DecF3S1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo16DecF3S1");
            if (Form.ContainsKey("z_SrNo16DecF3S1"))
                SrNo16DecF3S1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo16DecF3S1");

            // SrNo16DecF3S2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo16DecF3S2"))
                    SrNo16DecF3S2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo16DecF3S2");
            if (Form.ContainsKey("z_SrNo16DecF3S2"))
                SrNo16DecF3S2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo16DecF3S2");

            // SrNo16DecF4S1
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo16DecF4S1"))
                    SrNo16DecF4S1.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo16DecF4S1");
            if (Form.ContainsKey("z_SrNo16DecF4S1"))
                SrNo16DecF4S1.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo16DecF4S1");

            // SrNo16DecF4S2
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo16DecF4S2"))
                    SrNo16DecF4S2.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo16DecF4S2");
            if (Form.ContainsKey("z_SrNo16DecF4S2"))
                SrNo16DecF4S2.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo16DecF4S2");

            // SrNo16DecF4S3
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_SrNo16DecF4S3"))
                    SrNo16DecF4S3.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_SrNo16DecF4S3");
            if (Form.ContainsKey("z_SrNo16DecF4S3"))
                SrNo16DecF4S3.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_SrNo16DecF4S3");

            // StudentAssementBookingURL
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_StudentAssementBookingURL"))
                    StudentAssementBookingURL.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_StudentAssementBookingURL");
            if (Form.ContainsKey("z_StudentAssementBookingURL"))
                StudentAssementBookingURL.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_StudentAssementBookingURL");

            // intDrivinglicenseType
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_intDrivinglicenseType"))
                    intDrivinglicenseType.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_intDrivinglicenseType");
            if (Form.ContainsKey("z_intDrivinglicenseType"))
                intDrivinglicenseType.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_intDrivinglicenseType");

            // Isdrivinglicense
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Isdrivinglicense"))
                    Isdrivinglicense.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Isdrivinglicense");
            if (Form.ContainsKey("z_Isdrivinglicense"))
                Isdrivinglicense.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Isdrivinglicense");

            // drivinglicensenumber
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_drivinglicensenumber"))
                    drivinglicensenumber.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_drivinglicensenumber");
            if (Form.ContainsKey("z_drivinglicensenumber"))
                drivinglicensenumber.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_drivinglicensenumber");

            // Absher_Appointment_number
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Absher_Appointment_number"))
                    Absher_Appointment_number.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Absher_Appointment_number");
            if (Form.ContainsKey("z_Absher_Appointment_number"))
                Absher_Appointment_number.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Absher_Appointment_number");

            // DataImportId
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_DataImportId"))
                    DataImportId.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_DataImportId");
            if (Form.ContainsKey("z_DataImportId"))
                DataImportId.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_DataImportId");

            // date_Birth_Hijri
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_date_Birth_Hijri"))
                    date_Birth_Hijri.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_date_Birth_Hijri");
            if (Form.ContainsKey("z_date_Birth_Hijri"))
                date_Birth_Hijri.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_date_Birth_Hijri");

            // UserlevelID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_UserlevelID"))
                    UserlevelID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_UserlevelID");
            if (Form.ContainsKey("z_UserlevelID"))
                UserlevelID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_UserlevelID");

            // Activated
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Activated"))
                    Activated.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Activated");
            if (Form.ContainsKey("z_Activated"))
                Activated.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Activated");

            // Absherphoto
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Absherphoto"))
                    Absherphoto.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Absherphoto");
            if (Form.ContainsKey("z_Absherphoto"))
                Absherphoto.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Absherphoto");

            // Fingerprint
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Fingerprint"))
                    Fingerprint.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Fingerprint");
            if (Form.ContainsKey("z_Fingerprint"))
                Fingerprint.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Fingerprint");

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

            // Hijri_Day
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Hijri_Day"))
                    Hijri_Day.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Hijri_Day");
            if (Form.ContainsKey("z_Hijri_Day"))
                Hijri_Day.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Hijri_Day");

            // Hijri_Month
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Hijri_Month"))
                    Hijri_Month.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Hijri_Month");
            if (Form.ContainsKey("z_Hijri_Month"))
                Hijri_Month.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Hijri_Month");

            // Hijri_Year
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Hijri_Year"))
                    Hijri_Year.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Hijri_Year");
            if (Form.ContainsKey("z_Hijri_Year"))
                Hijri_Year.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Hijri_Year");

            // Course_Price
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Course_Price"))
                    Course_Price.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Course_Price");
            if (Form.ContainsKey("z_Course_Price"))
                Course_Price.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Course_Price");

            // Vat_Tax_15
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Vat_Tax_15"))
                    Vat_Tax_15.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Vat_Tax_15");
            if (Form.ContainsKey("z_Vat_Tax_15"))
                Vat_Tax_15.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Vat_Tax_15");

            // dec_Balance
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_dec_Balance"))
                    dec_Balance.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_dec_Balance");
            if (Form.ContainsKey("z_dec_Balance"))
                dec_Balance.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_dec_Balance");

            // Total_Price
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Total_Price"))
                    Total_Price.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Total_Price");
            if (Form.ContainsKey("z_Total_Price"))
                Total_Price.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Total_Price");

            // Payment_Online
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Payment_Online"))
                    Payment_Online.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Payment_Online");
            if (Form.ContainsKey("z_Payment_Online"))
                Payment_Online.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Payment_Online");

            // Institution
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Institution"))
                    Institution.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Institution");
            if (Form.ContainsKey("z_Institution"))
                Institution.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Institution");

            // WaitingList
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_WaitingList"))
                    WaitingList.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_WaitingList");
            if (Form.ContainsKey("z_WaitingList"))
                WaitingList.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_WaitingList");

            // Assessment_ID
            if (!IsAddOrEdit)
                if (Form.ContainsKey("x_Assessment_ID"))
                    Assessment_ID.AdvancedSearch.SearchValue = CurrentForm.GetValue("x_Assessment_ID");
            if (Form.ContainsKey("z_Assessment_ID"))
                Assessment_ID.AdvancedSearch.SearchOperator = CurrentForm.GetValue("z_Assessment_ID");
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
                // int_Potential_Student_ID
                int_Potential_Student_ID.ViewValue = int_Potential_Student_ID.CurrentValue;
                int_Potential_Student_ID.ViewCustomAttributes = "";

                // int_Student_Id
                int_Student_Id.ViewValue = int_Student_Id.CurrentValue;
                int_Student_Id.ViewValue = FormatNumber(int_Student_Id.ViewValue, int_Student_Id.FormatPattern);
                int_Student_Id.ViewCustomAttributes = "";

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

                // int_Potential_Student_ID
                int_Potential_Student_ID.HrefValue = "";
                int_Potential_Student_ID.TooltipValue = "";

                // int_Student_Id
                int_Student_Id.HrefValue = "";
                int_Student_Id.TooltipValue = "";

                // str_NationalID_Iqama
                str_NationalID_Iqama.HrefValue = "";
                str_NationalID_Iqama.TooltipValue = "";

                // NationalID
                NationalID.HrefValue = "";
                NationalID.TooltipValue = "";

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
                str_Address1.TooltipValue = "";

                // str_Address2
                str_Address2.HrefValue = "";
                str_Address2.TooltipValue = "";

                // int_State
                int_State.HrefValue = "";
                int_State.TooltipValue = "";

                // str_City
                str_City.HrefValue = "";
                str_City.TooltipValue = "";

                // str_Zip
                str_Zip.HrefValue = "";
                str_Zip.TooltipValue = "";

                // int_Instructor
                int_Instructor.HrefValue = "";
                int_Instructor.TooltipValue = "";

                // int_Driver
                int_Driver.HrefValue = "";
                int_Driver.TooltipValue = "";

                // str_Home_Phone
                str_Home_Phone.HrefValue = "";
                str_Home_Phone.TooltipValue = "";

                // str_Cell_Phone
                str_Cell_Phone.HrefValue = "";
                str_Cell_Phone.TooltipValue = "";

                // str_Parent_Phone
                str_Parent_Phone.HrefValue = "";
                str_Parent_Phone.TooltipValue = "";

                // str_Other_Phone
                str_Other_Phone.HrefValue = "";
                str_Other_Phone.TooltipValue = "";

                // str_Email
                str_Email.HrefValue = "";
                str_Email.TooltipValue = "";

                // str_ParentName
                str_ParentName.HrefValue = "";
                str_ParentName.TooltipValue = "";

                // str_ParentEmail1
                str_ParentEmail1.HrefValue = "";
                str_ParentEmail1.TooltipValue = "";

                // str_ParentEmail2
                str_ParentEmail2.HrefValue = "";
                str_ParentEmail2.TooltipValue = "";

                // str_Username
                str_Username.HrefValue = "";
                str_Username.TooltipValue = "";

                // str_Password
                str_Password.HrefValue = "";
                str_Password.TooltipValue = "";

                // str_DOB
                str_DOB.HrefValue = "";
                str_DOB.TooltipValue = "";

                // int_DOB_Day
                int_DOB_Day.HrefValue = "";
                int_DOB_Day.TooltipValue = "";

                // int_DOB_Month
                int_DOB_Month.HrefValue = "";
                int_DOB_Month.TooltipValue = "";

                // int_DOB_Year
                int_DOB_Year.HrefValue = "";
                int_DOB_Year.TooltipValue = "";

                // int_Age
                int_Age.HrefValue = "";
                int_Age.TooltipValue = "";

                // int_Type
                int_Type.HrefValue = "";
                int_Type.TooltipValue = "";

                // int_Wear_Glasses
                int_Wear_Glasses.HrefValue = "";
                int_Wear_Glasses.TooltipValue = "";

                // int_Sex
                int_Sex.HrefValue = "";
                int_Sex.TooltipValue = "";

                // str_DLPermit
                str_DLPermit.HrefValue = "";
                str_DLPermit.TooltipValue = "";

                // dt_Date_PermitIssue
                dt_Date_PermitIssue.HrefValue = "";
                dt_Date_PermitIssue.TooltipValue = "";

                // dt_Date_ExpirePermit
                dt_Date_ExpirePermit.HrefValue = "";
                dt_Date_ExpirePermit.TooltipValue = "";

                // int_Hs_ID
                int_Hs_ID.HrefValue = "";
                int_Hs_ID.TooltipValue = "";

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.HrefValue = "";
                str_Emergency_Contact_Name.TooltipValue = "";

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.HrefValue = "";
                str_Emergency_Contact_Phone.TooltipValue = "";

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.HrefValue = "";
                str_Emergency_Contact_Relation.TooltipValue = "";

                // str_Student_Notes
                str_Student_Notes.HrefValue = "";
                str_Student_Notes.TooltipValue = "";

                // str_Driving_Notes
                str_Driving_Notes.HrefValue = "";
                str_Driving_Notes.TooltipValue = "";

                // int_Location_Id
                int_Location_Id.HrefValue = "";
                int_Location_Id.TooltipValue = "";

                // int_Permit_Number
                int_Permit_Number.HrefValue = "";
                int_Permit_Number.TooltipValue = "";

                // Permit_Issue_Date
                Permit_Issue_Date.HrefValue = "";
                Permit_Issue_Date.TooltipValue = "";

                // Permit_Expiry_Date
                Permit_Expiry_Date.HrefValue = "";
                Permit_Expiry_Date.TooltipValue = "";

                // int_Status
                int_Status.HrefValue = "";
                int_Status.TooltipValue = "";

                // int_Lead_Id
                int_Lead_Id.HrefValue = "";
                int_Lead_Id.TooltipValue = "";

                // int_Activated_By
                int_Activated_By.HrefValue = "";
                int_Activated_By.TooltipValue = "";

                // date_Activated
                date_Activated.HrefValue = "";
                date_Activated.TooltipValue = "";

                // date_Created
                date_Created.HrefValue = "";
                date_Created.TooltipValue = "";

                // date_Modified
                date_Modified.HrefValue = "";
                date_Modified.TooltipValue = "";

                // date_Complete
                date_Complete.HrefValue = "";
                date_Complete.TooltipValue = "";

                // int_Created_By
                int_Created_By.HrefValue = "";
                int_Created_By.TooltipValue = "";

                // int_Modified_By
                int_Modified_By.HrefValue = "";
                int_Modified_By.TooltipValue = "";

                // bit_IsDeleted
                bit_IsDeleted.HrefValue = "";
                bit_IsDeleted.TooltipValue = "";

                // str_CardHolderName
                str_CardHolderName.HrefValue = "";
                str_CardHolderName.TooltipValue = "";

                // str_CardHolderAddress
                str_CardHolderAddress.HrefValue = "";
                str_CardHolderAddress.TooltipValue = "";

                // str_CardHolderCity
                str_CardHolderCity.HrefValue = "";
                str_CardHolderCity.TooltipValue = "";

                // str_CardHolderZip
                str_CardHolderZip.HrefValue = "";
                str_CardHolderZip.TooltipValue = "";

                // str_CardType
                str_CardType.HrefValue = "";
                str_CardType.TooltipValue = "";

                // str_CardExpMonth
                str_CardExpMonth.HrefValue = "";
                str_CardExpMonth.TooltipValue = "";

                // str_CardExpYear
                str_CardExpYear.HrefValue = "";
                str_CardExpYear.TooltipValue = "";

                // str_CardNo
                str_CardNo.HrefValue = "";
                str_CardNo.TooltipValue = "";

                // str_Certificate_No
                str_Certificate_No.HrefValue = "";
                str_Certificate_No.TooltipValue = "";

                // str_AmountPaid
                str_AmountPaid.HrefValue = "";
                str_AmountPaid.TooltipValue = "";

                // str_PermitValidated
                str_PermitValidated.HrefValue = "";
                str_PermitValidated.TooltipValue = "";

                // strSMSNotification
                strSMSNotification.HrefValue = "";
                strSMSNotification.TooltipValue = "";

                // strVoiceNotification
                strVoiceNotification.HrefValue = "";
                strVoiceNotification.TooltipValue = "";

                // str_Weight
                str_Weight.HrefValue = "";
                str_Weight.TooltipValue = "";

                // str_SpecialNeeds
                str_SpecialNeeds.HrefValue = "";
                str_SpecialNeeds.TooltipValue = "";

                // str_MedicalConditions
                str_MedicalConditions.HrefValue = "";
                str_MedicalConditions.TooltipValue = "";

                // bit_Verified_PIC_InSAW
                bit_Verified_PIC_InSAW.HrefValue = "";
                bit_Verified_PIC_InSAW.TooltipValue = "";

                // bit_Permit_Waiver_Entered
                bit_Permit_Waiver_Entered.HrefValue = "";
                bit_Permit_Waiver_Entered.TooltipValue = "";

                // bit_TermsConditions
                bit_TermsConditions.HrefValue = "";
                bit_TermsConditions.TooltipValue = "";

                // bit_Disable_Self_Scheduling
                bit_Disable_Self_Scheduling.HrefValue = "";
                bit_Disable_Self_Scheduling.TooltipValue = "";

                // int_EyeColor
                int_EyeColor.HrefValue = "";
                int_EyeColor.TooltipValue = "";

                // int_HairColor
                int_HairColor.HrefValue = "";
                int_HairColor.TooltipValue = "";

                // int_ColorBlind
                int_ColorBlind.HrefValue = "";
                int_ColorBlind.TooltipValue = "";

                // int_HeightFeet
                int_HeightFeet.HrefValue = "";
                int_HeightFeet.TooltipValue = "";

                // int_HeightInches
                int_HeightInches.HrefValue = "";
                int_HeightInches.TooltipValue = "";

                // str_reference_code
                str_reference_code.HrefValue = "";
                str_reference_code.TooltipValue = "";

                // dt_ParentClassAttendedDt
                dt_ParentClassAttendedDt.HrefValue = "";
                dt_ParentClassAttendedDt.TooltipValue = "";

                // str_ParentClassAttendedLoc
                str_ParentClassAttendedLoc.HrefValue = "";
                str_ParentClassAttendedLoc.TooltipValue = "";

                // dt_SiblingClassAttendedDt
                dt_SiblingClassAttendedDt.HrefValue = "";
                dt_SiblingClassAttendedDt.TooltipValue = "";

                // str_SiblingClassAttendedLoc
                str_SiblingClassAttendedLoc.HrefValue = "";
                str_SiblingClassAttendedLoc.TooltipValue = "";

                // bit_PoliciesAndProcedures
                bit_PoliciesAndProcedures.HrefValue = "";
                bit_PoliciesAndProcedures.TooltipValue = "";

                // dt_CourseCompletionDt
                dt_CourseCompletionDt.HrefValue = "";
                dt_CourseCompletionDt.TooltipValue = "";

                // dt_ExtensionDt
                dt_ExtensionDt.HrefValue = "";
                dt_ExtensionDt.TooltipValue = "";

                // str_MedicalCondition
                str_MedicalCondition.HrefValue = "";
                str_MedicalCondition.TooltipValue = "";

                // str_MajorCrossStreets
                str_MajorCrossStreets.HrefValue = "";
                str_MajorCrossStreets.TooltipValue = "";

                // str_DriverEdCertNo
                str_DriverEdCertNo.HrefValue = "";
                str_DriverEdCertNo.TooltipValue = "";

                // dt_DriverEdCertIssuedDt
                dt_DriverEdCertIssuedDt.HrefValue = "";
                dt_DriverEdCertIssuedDt.TooltipValue = "";

                // str_BTWDriversEdCertNo
                str_BTWDriversEdCertNo.HrefValue = "";
                str_BTWDriversEdCertNo.TooltipValue = "";

                // dt_BTWCertIssuedDt
                dt_BTWCertIssuedDt.HrefValue = "";
                dt_BTWCertIssuedDt.TooltipValue = "";

                // str_OLDriversEdCertNo
                str_OLDriversEdCertNo.HrefValue = "";
                str_OLDriversEdCertNo.TooltipValue = "";

                // dt_OLCertIssuedDt
                dt_OLCertIssuedDt.HrefValue = "";
                dt_OLCertIssuedDt.TooltipValue = "";

                // str_height
                str_height.HrefValue = "";
                str_height.TooltipValue = "";

                // dt_BTWCompletionDt
                dt_BTWCompletionDt.HrefValue = "";
                dt_BTWCompletionDt.TooltipValue = "";

                // dt_CRCompletionDt
                dt_CRCompletionDt.HrefValue = "";
                dt_CRCompletionDt.TooltipValue = "";

                // strTextBox5
                strTextBox5.HrefValue = "";
                strTextBox5.TooltipValue = "";

                // strTextBox6
                strTextBox6.HrefValue = "";
                strTextBox6.TooltipValue = "";

                // str_ApartmentNo
                str_ApartmentNo.HrefValue = "";
                str_ApartmentNo.TooltipValue = "";

                // dt_PermitTestDate
                dt_PermitTestDate.HrefValue = "";
                dt_PermitTestDate.TooltipValue = "";

                // str_OnlineDriverEdLogin
                str_OnlineDriverEdLogin.HrefValue = "";
                str_OnlineDriverEdLogin.TooltipValue = "";

                // str_OnlineDriverEdPassword
                str_OnlineDriverEdPassword.HrefValue = "";
                str_OnlineDriverEdPassword.TooltipValue = "";

                // bit_IsSMSEnabled
                bit_IsSMSEnabled.HrefValue = "";
                bit_IsSMSEnabled.TooltipValue = "";

                // dt_SMSModified
                dt_SMSModified.HrefValue = "";
                dt_SMSModified.TooltipValue = "";

                // str_confirmPassword
                str_confirmPassword.HrefValue = "";
                str_confirmPassword.TooltipValue = "";

                // DE_Certificate
                DE_Certificate.HrefValue = "";
                DE_Certificate.TooltipValue = "";

                // Discuss
                Discuss.HrefValue = "";
                Discuss.TooltipValue = "";

                // int_UnlicensedSibling
                int_UnlicensedSibling.HrefValue = "";
                int_UnlicensedSibling.TooltipValue = "";

                // int_YearSiblingIsEligible
                int_YearSiblingIsEligible.HrefValue = "";
                int_YearSiblingIsEligible.TooltipValue = "";

                // BTW_Certificate
                BTW_Certificate.HrefValue = "";
                BTW_Certificate.TooltipValue = "";

                // dt_DECertIssueDate
                dt_DECertIssueDate.HrefValue = "";
                dt_DECertIssueDate.TooltipValue = "";

                // str_StudentSignature
                str_StudentSignature.HrefValue = "";
                str_StudentSignature.TooltipValue = "";

                // str_ParentSignature
                str_ParentSignature.HrefValue = "";
                str_ParentSignature.TooltipValue = "";

                // str_Last6DigitsOfParentDriversLicense
                str_Last6DigitsOfParentDriversLicense.HrefValue = "";
                str_Last6DigitsOfParentDriversLicense.TooltipValue = "";

                // str_FACControl
                str_FACControl.HrefValue = "";
                str_FACControl.TooltipValue = "";

                // Classroom_Status_Code
                Classroom_Status_Code.HrefValue = "";
                Classroom_Status_Code.TooltipValue = "";

                // Laboratory_Status_Code
                Laboratory_Status_Code.HrefValue = "";
                Laboratory_Status_Code.TooltipValue = "";

                // bit_EnrollmentForm
                bit_EnrollmentForm.HrefValue = "";
                bit_EnrollmentForm.TooltipValue = "";

                // bit_ParentStudentContract
                bit_ParentStudentContract.HrefValue = "";
                bit_ParentStudentContract.TooltipValue = "";

                // bit_ParentalAgreement
                bit_ParentalAgreement.HrefValue = "";
                bit_ParentalAgreement.TooltipValue = "";

                // int_SF_GR_WA_HS
                int_SF_GR_WA_HS.HrefValue = "";
                int_SF_GR_WA_HS.TooltipValue = "";

                // bit_DisableOnRMV
                bit_DisableOnRMV.HrefValue = "";
                bit_DisableOnRMV.TooltipValue = "";

                // bit_UploadedToRMV
                bit_UploadedToRMV.HrefValue = "";
                bit_UploadedToRMV.TooltipValue = "";

                // str_Mother_Name
                str_Mother_Name.HrefValue = "";
                str_Mother_Name.TooltipValue = "";

                // str_Guardians_Name
                str_Guardians_Name.HrefValue = "";
                str_Guardians_Name.TooltipValue = "";

                // str_Mother_Phone
                str_Mother_Phone.HrefValue = "";
                str_Mother_Phone.TooltipValue = "";

                // bit_terms
                bit_terms.HrefValue = "";
                bit_terms.TooltipValue = "";

                // int_Nationality
                int_Nationality.HrefValue = "";
                int_Nationality.TooltipValue = "";

                // str_National_ID_en
                str_National_ID_en.HrefValue = "";
                str_National_ID_en.TooltipValue = "";

                // str_National_ID_arabic
                str_National_ID_arabic.HrefValue = "";
                str_National_ID_arabic.TooltipValue = "";

                // Quallification_Id
                Quallification_Id.HrefValue = "";
                Quallification_Id.TooltipValue = "";

                // Job_Id
                Job_Id.HrefValue = "";
                Job_Id.TooltipValue = "";

                // str_DOB_arabic
                str_DOB_arabic.HrefValue = "";
                str_DOB_arabic.TooltipValue = "";

                // int_Language
                int_Language.HrefValue = "";
                int_Language.TooltipValue = "";

                // strRefId
                strRefId.HrefValue = "";
                strRefId.TooltipValue = "";

                // int_Program_Id
                int_Program_Id.HrefValue = "";
                int_Program_Id.TooltipValue = "";

                // IsDrivingexperience
                IsDrivingexperience.HrefValue = "";
                IsDrivingexperience.TooltipValue = "";

                // IsScheduleassessment
                IsScheduleassessment.HrefValue = "";
                IsScheduleassessment.TooltipValue = "";

                // IsEnrollbyyourself
                IsEnrollbyyourself.HrefValue = "";
                IsEnrollbyyourself.TooltipValue = "";

                // AssessmentTime
                AssessmentTime.HrefValue = "";
                AssessmentTime.TooltipValue = "";

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

                // bit_Archive
                bit_Archive.HrefValue = "";
                bit_Archive.TooltipValue = "";

                // ArchiveNotes
                ArchiveNotes.HrefValue = "";
                ArchiveNotes.TooltipValue = "";

                // dtArchived
                dtArchived.HrefValue = "";
                dtArchived.TooltipValue = "";

                // SrNo9Dec21
                SrNo9Dec21.HrefValue = "";
                SrNo9Dec21.TooltipValue = "";

                // REGNNUMB
                REGNNUMB.HrefValue = "";
                REGNNUMB.TooltipValue = "";

                // REGNLOCN
                REGNLOCN.HrefValue = "";
                REGNLOCN.TooltipValue = "";

                // SrNo11DecF1S1
                SrNo11DecF1S1.HrefValue = "";
                SrNo11DecF1S1.TooltipValue = "";

                // IsInterestedInTraining
                IsInterestedInTraining.HrefValue = "";
                IsInterestedInTraining.TooltipValue = "";

                // StudentEncryptID
                StudentEncryptID.HrefValue = "";
                StudentEncryptID.TooltipValue = "";

                // StudentConfirURL
                StudentConfirURL.HrefValue = "";
                StudentConfirURL.TooltipValue = "";

                // SrNo15DecF1S2
                SrNo15DecF1S2.HrefValue = "";
                SrNo15DecF1S2.TooltipValue = "";

                // SrNo15DecF1S3
                SrNo15DecF1S3.HrefValue = "";
                SrNo15DecF1S3.TooltipValue = "";

                // SrNo16DecF2S2
                SrNo16DecF2S2.HrefValue = "";
                SrNo16DecF2S2.TooltipValue = "";

                // SrNo16DecF2S3
                SrNo16DecF2S3.HrefValue = "";
                SrNo16DecF2S3.TooltipValue = "";

                // SrNo16DecF3S1
                SrNo16DecF3S1.HrefValue = "";
                SrNo16DecF3S1.TooltipValue = "";

                // SrNo16DecF3S2
                SrNo16DecF3S2.HrefValue = "";
                SrNo16DecF3S2.TooltipValue = "";

                // SrNo16DecF4S1
                SrNo16DecF4S1.HrefValue = "";
                SrNo16DecF4S1.TooltipValue = "";

                // SrNo16DecF4S2
                SrNo16DecF4S2.HrefValue = "";
                SrNo16DecF4S2.TooltipValue = "";

                // SrNo16DecF4S3
                SrNo16DecF4S3.HrefValue = "";
                SrNo16DecF4S3.TooltipValue = "";

                // StudentAssementBookingURL
                StudentAssementBookingURL.HrefValue = "";
                StudentAssementBookingURL.TooltipValue = "";

                // intDrivinglicenseType
                intDrivinglicenseType.HrefValue = "";
                intDrivinglicenseType.TooltipValue = "";

                // Isdrivinglicense
                Isdrivinglicense.HrefValue = "";
                Isdrivinglicense.TooltipValue = "";

                // drivinglicensenumber
                drivinglicensenumber.HrefValue = "";
                drivinglicensenumber.TooltipValue = "";

                // Absher_Appointment_number
                Absher_Appointment_number.HrefValue = "";
                Absher_Appointment_number.TooltipValue = "";

                // DataImportId
                DataImportId.HrefValue = "";
                DataImportId.TooltipValue = "";

                // date_Birth_Hijri
                date_Birth_Hijri.HrefValue = "";
                date_Birth_Hijri.TooltipValue = "";

                // UserlevelID
                UserlevelID.HrefValue = "";
                UserlevelID.TooltipValue = "";

                // Activated
                Activated.HrefValue = "";
                Activated.TooltipValue = "";

                // Absherphoto
                Absherphoto.HrefValue = "";
                Absherphoto.TooltipValue = "";

                // Fingerprint
                Fingerprint.HrefValue = "";
                Fingerprint.TooltipValue = "";

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

                // Course_Price
                Course_Price.HrefValue = "";
                Course_Price.TooltipValue = "";

                // Vat_Tax_15
                Vat_Tax_15.HrefValue = "";
                Vat_Tax_15.TooltipValue = "";

                // dec_Balance
                dec_Balance.HrefValue = "";
                dec_Balance.TooltipValue = "";

                // Total_Price
                Total_Price.HrefValue = "";
                Total_Price.TooltipValue = "";

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
                WaitingList.TooltipValue = "";

                // Assessment_ID
                Assessment_ID.HrefValue = "";
                Assessment_ID.TooltipValue = "";
            } else if (RowType == RowType.Search) {
                // int_Potential_Student_ID
                int_Potential_Student_ID.SetupEditAttributes();
                int_Potential_Student_ID.EditValue = int_Potential_Student_ID.AdvancedSearch.SearchValue; // DN
                int_Potential_Student_ID.PlaceHolder = RemoveHtml(int_Potential_Student_ID.Caption);

                // int_Student_Id
                int_Student_Id.SetupEditAttributes();
                int_Student_Id.EditValue = int_Student_Id.AdvancedSearch.SearchValue; // DN
                int_Student_Id.PlaceHolder = RemoveHtml(int_Student_Id.Caption);

                // str_NationalID_Iqama
                str_NationalID_Iqama.SetupEditAttributes();
                if (!str_NationalID_Iqama.Raw)
                    str_NationalID_Iqama.AdvancedSearch.SearchValue = HtmlDecode(str_NationalID_Iqama.AdvancedSearch.SearchValue);
                str_NationalID_Iqama.EditValue = HtmlEncode(str_NationalID_Iqama.AdvancedSearch.SearchValue);
                str_NationalID_Iqama.PlaceHolder = RemoveHtml(str_NationalID_Iqama.Caption);

                // NationalID
                NationalID.SetupEditAttributes();
                NationalID.EditValue = NationalID.AdvancedSearch.SearchValue; // DN
                NationalID.PlaceHolder = RemoveHtml(NationalID.Caption);

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

                // str_Address1
                str_Address1.SetupEditAttributes();
                if (!str_Address1.Raw)
                    str_Address1.AdvancedSearch.SearchValue = HtmlDecode(str_Address1.AdvancedSearch.SearchValue);
                str_Address1.EditValue = HtmlEncode(str_Address1.AdvancedSearch.SearchValue);
                str_Address1.PlaceHolder = RemoveHtml(str_Address1.Caption);

                // str_Address2
                str_Address2.SetupEditAttributes();
                if (!str_Address2.Raw)
                    str_Address2.AdvancedSearch.SearchValue = HtmlDecode(str_Address2.AdvancedSearch.SearchValue);
                str_Address2.EditValue = HtmlEncode(str_Address2.AdvancedSearch.SearchValue);
                str_Address2.PlaceHolder = RemoveHtml(str_Address2.Caption);

                // int_State
                int_State.SetupEditAttributes();
                curVal = ConvertToString(int_State.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (int_State.Lookup != null && IsDictionary(int_State.Lookup?.Options) && int_State.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_State.EditValue = int_State.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[Province_ID]", "=", int_State.AdvancedSearch.SearchValue, DataType.Number, "");
                    }
                    sqlWrk = int_State.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_State.EditValue = rswrk;
                }
                int_State.PlaceHolder = RemoveHtml(int_State.Caption);

                // str_City
                str_City.SetupEditAttributes();
                curVal = ConvertToString(str_City.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (str_City.Lookup != null && IsDictionary(str_City.Lookup?.Options) && str_City.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    str_City.EditValue = str_City.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[City]", "=", str_City.AdvancedSearch.SearchValue, DataType.String, "");
                    }
                    sqlWrk = str_City.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    str_City.EditValue = rswrk;
                }
                str_City.PlaceHolder = RemoveHtml(str_City.Caption);

                // str_Zip
                str_Zip.SetupEditAttributes();
                if (!str_Zip.Raw)
                    str_Zip.AdvancedSearch.SearchValue = HtmlDecode(str_Zip.AdvancedSearch.SearchValue);
                str_Zip.EditValue = HtmlEncode(str_Zip.AdvancedSearch.SearchValue);
                str_Zip.PlaceHolder = RemoveHtml(str_Zip.Caption);

                // int_Instructor
                int_Instructor.SetupEditAttributes();
                curVal = ConvertToString(int_Instructor.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (int_Instructor.Lookup != null && IsDictionary(int_Instructor.Lookup?.Options) && int_Instructor.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Instructor.EditValue = int_Instructor.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Staff_Id]", "=", int_Instructor.AdvancedSearch.SearchValue, DataType.Number, "");
                    }
                    sqlWrk = int_Instructor.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Instructor.EditValue = rswrk;
                }
                int_Instructor.PlaceHolder = RemoveHtml(int_Instructor.Caption);

                // int_Driver
                int_Driver.SetupEditAttributes();
                int_Driver.EditValue = int_Driver.AdvancedSearch.SearchValue; // DN
                int_Driver.PlaceHolder = RemoveHtml(int_Driver.Caption);

                // str_Home_Phone
                str_Home_Phone.SetupEditAttributes();
                if (!str_Home_Phone.Raw)
                    str_Home_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Home_Phone.AdvancedSearch.SearchValue);
                str_Home_Phone.EditValue = HtmlEncode(str_Home_Phone.AdvancedSearch.SearchValue);
                str_Home_Phone.PlaceHolder = RemoveHtml(str_Home_Phone.Caption);

                // str_Cell_Phone
                str_Cell_Phone.SetupEditAttributes();
                if (!str_Cell_Phone.Raw)
                    str_Cell_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Cell_Phone.AdvancedSearch.SearchValue);
                str_Cell_Phone.EditValue = HtmlEncode(str_Cell_Phone.AdvancedSearch.SearchValue);
                str_Cell_Phone.PlaceHolder = RemoveHtml(str_Cell_Phone.Caption);

                // str_Parent_Phone
                str_Parent_Phone.SetupEditAttributes();
                if (!str_Parent_Phone.Raw)
                    str_Parent_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Parent_Phone.AdvancedSearch.SearchValue);
                str_Parent_Phone.EditValue = HtmlEncode(str_Parent_Phone.AdvancedSearch.SearchValue);
                str_Parent_Phone.PlaceHolder = RemoveHtml(str_Parent_Phone.Caption);

                // str_Other_Phone
                str_Other_Phone.SetupEditAttributes();
                if (!str_Other_Phone.Raw)
                    str_Other_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Other_Phone.AdvancedSearch.SearchValue);
                str_Other_Phone.EditValue = HtmlEncode(str_Other_Phone.AdvancedSearch.SearchValue);
                str_Other_Phone.PlaceHolder = RemoveHtml(str_Other_Phone.Caption);

                // str_Email
                str_Email.SetupEditAttributes();
                if (!str_Email.Raw)
                    str_Email.AdvancedSearch.SearchValue = HtmlDecode(str_Email.AdvancedSearch.SearchValue);
                str_Email.EditValue = HtmlEncode(str_Email.AdvancedSearch.SearchValue);
                str_Email.PlaceHolder = RemoveHtml(str_Email.Caption);

                // str_ParentName
                str_ParentName.SetupEditAttributes();
                if (!str_ParentName.Raw)
                    str_ParentName.AdvancedSearch.SearchValue = HtmlDecode(str_ParentName.AdvancedSearch.SearchValue);
                str_ParentName.EditValue = HtmlEncode(str_ParentName.AdvancedSearch.SearchValue);
                str_ParentName.PlaceHolder = RemoveHtml(str_ParentName.Caption);

                // str_ParentEmail1
                str_ParentEmail1.SetupEditAttributes();
                if (!str_ParentEmail1.Raw)
                    str_ParentEmail1.AdvancedSearch.SearchValue = HtmlDecode(str_ParentEmail1.AdvancedSearch.SearchValue);
                str_ParentEmail1.EditValue = HtmlEncode(str_ParentEmail1.AdvancedSearch.SearchValue);
                str_ParentEmail1.PlaceHolder = RemoveHtml(str_ParentEmail1.Caption);

                // str_ParentEmail2
                str_ParentEmail2.SetupEditAttributes();
                if (!str_ParentEmail2.Raw)
                    str_ParentEmail2.AdvancedSearch.SearchValue = HtmlDecode(str_ParentEmail2.AdvancedSearch.SearchValue);
                str_ParentEmail2.EditValue = HtmlEncode(str_ParentEmail2.AdvancedSearch.SearchValue);
                str_ParentEmail2.PlaceHolder = RemoveHtml(str_ParentEmail2.Caption);

                // str_Username
                str_Username.SetupEditAttributes();
                if (!str_Username.Raw)
                    str_Username.AdvancedSearch.SearchValue = HtmlDecode(str_Username.AdvancedSearch.SearchValue);
                str_Username.EditValue = HtmlEncode(str_Username.AdvancedSearch.SearchValue);
                str_Username.PlaceHolder = RemoveHtml(str_Username.Caption);

                // str_Password
                str_Password.SetupEditAttributes();
                if (!str_Password.Raw)
                    str_Password.AdvancedSearch.SearchValue = HtmlDecode(str_Password.AdvancedSearch.SearchValue);
                str_Password.EditValue = HtmlEncode(str_Password.AdvancedSearch.SearchValue);
                str_Password.PlaceHolder = RemoveHtml(str_Password.Caption);

                // str_DOB
                str_DOB.SetupEditAttributes();
                str_DOB.EditValue = FormatDateTime(UnformatDateTime(str_DOB.AdvancedSearch.SearchValue, str_DOB.FormatPattern), str_DOB.FormatPattern); // DN
                str_DOB.PlaceHolder = RemoveHtml(str_DOB.Caption);

                // int_DOB_Day
                int_DOB_Day.SetupEditAttributes();
                int_DOB_Day.EditValue = int_DOB_Day.AdvancedSearch.SearchValue; // DN
                int_DOB_Day.PlaceHolder = RemoveHtml(int_DOB_Day.Caption);

                // int_DOB_Month
                int_DOB_Month.SetupEditAttributes();
                int_DOB_Month.EditValue = int_DOB_Month.AdvancedSearch.SearchValue; // DN
                int_DOB_Month.PlaceHolder = RemoveHtml(int_DOB_Month.Caption);

                // int_DOB_Year
                int_DOB_Year.SetupEditAttributes();
                int_DOB_Year.EditValue = int_DOB_Year.AdvancedSearch.SearchValue; // DN
                int_DOB_Year.PlaceHolder = RemoveHtml(int_DOB_Year.Caption);

                // int_Age
                int_Age.SetupEditAttributes();
                int_Age.EditValue = int_Age.AdvancedSearch.SearchValue; // DN
                int_Age.PlaceHolder = RemoveHtml(int_Age.Caption);

                // int_Type
                int_Type.SetupEditAttributes();
                int_Type.EditValue = int_Type.AdvancedSearch.SearchValue; // DN
                int_Type.PlaceHolder = RemoveHtml(int_Type.Caption);

                // int_Wear_Glasses
                int_Wear_Glasses.SetupEditAttributes();
                int_Wear_Glasses.EditValue = int_Wear_Glasses.AdvancedSearch.SearchValue; // DN
                int_Wear_Glasses.PlaceHolder = RemoveHtml(int_Wear_Glasses.Caption);

                // int_Sex
                int_Sex.SetupEditAttributes();
                int_Sex.EditValue = int_Sex.Options(true);
                int_Sex.PlaceHolder = RemoveHtml(int_Sex.Caption);

                // str_DLPermit
                str_DLPermit.SetupEditAttributes();
                if (!str_DLPermit.Raw)
                    str_DLPermit.AdvancedSearch.SearchValue = HtmlDecode(str_DLPermit.AdvancedSearch.SearchValue);
                str_DLPermit.EditValue = HtmlEncode(str_DLPermit.AdvancedSearch.SearchValue);
                str_DLPermit.PlaceHolder = RemoveHtml(str_DLPermit.Caption);

                // dt_Date_PermitIssue
                dt_Date_PermitIssue.SetupEditAttributes();
                dt_Date_PermitIssue.EditValue = FormatDateTime(UnformatDateTime(dt_Date_PermitIssue.AdvancedSearch.SearchValue, dt_Date_PermitIssue.FormatPattern), dt_Date_PermitIssue.FormatPattern); // DN
                dt_Date_PermitIssue.PlaceHolder = RemoveHtml(dt_Date_PermitIssue.Caption);

                // dt_Date_ExpirePermit
                dt_Date_ExpirePermit.SetupEditAttributes();
                dt_Date_ExpirePermit.EditValue = FormatDateTime(UnformatDateTime(dt_Date_ExpirePermit.AdvancedSearch.SearchValue, dt_Date_ExpirePermit.FormatPattern), dt_Date_ExpirePermit.FormatPattern); // DN
                dt_Date_ExpirePermit.PlaceHolder = RemoveHtml(dt_Date_ExpirePermit.Caption);

                // int_Hs_ID
                int_Hs_ID.SetupEditAttributes();
                int_Hs_ID.EditValue = int_Hs_ID.AdvancedSearch.SearchValue; // DN
                int_Hs_ID.PlaceHolder = RemoveHtml(int_Hs_ID.Caption);

                // str_Emergency_Contact_Name
                str_Emergency_Contact_Name.SetupEditAttributes();
                if (!str_Emergency_Contact_Name.Raw)
                    str_Emergency_Contact_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Emergency_Contact_Name.AdvancedSearch.SearchValue);
                str_Emergency_Contact_Name.EditValue = HtmlEncode(str_Emergency_Contact_Name.AdvancedSearch.SearchValue);
                str_Emergency_Contact_Name.PlaceHolder = RemoveHtml(str_Emergency_Contact_Name.Caption);

                // str_Emergency_Contact_Phone
                str_Emergency_Contact_Phone.SetupEditAttributes();
                if (!str_Emergency_Contact_Phone.Raw)
                    str_Emergency_Contact_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Emergency_Contact_Phone.AdvancedSearch.SearchValue);
                str_Emergency_Contact_Phone.EditValue = HtmlEncode(str_Emergency_Contact_Phone.AdvancedSearch.SearchValue);
                str_Emergency_Contact_Phone.PlaceHolder = RemoveHtml(str_Emergency_Contact_Phone.Caption);

                // str_Emergency_Contact_Relation
                str_Emergency_Contact_Relation.SetupEditAttributes();
                if (!str_Emergency_Contact_Relation.Raw)
                    str_Emergency_Contact_Relation.AdvancedSearch.SearchValue = HtmlDecode(str_Emergency_Contact_Relation.AdvancedSearch.SearchValue);
                str_Emergency_Contact_Relation.EditValue = HtmlEncode(str_Emergency_Contact_Relation.AdvancedSearch.SearchValue);
                str_Emergency_Contact_Relation.PlaceHolder = RemoveHtml(str_Emergency_Contact_Relation.Caption);

                // str_Student_Notes
                str_Student_Notes.SetupEditAttributes();
                str_Student_Notes.EditValue = str_Student_Notes.AdvancedSearch.SearchValue; // DN
                str_Student_Notes.PlaceHolder = RemoveHtml(str_Student_Notes.Caption);

                // str_Driving_Notes
                str_Driving_Notes.SetupEditAttributes();
                str_Driving_Notes.EditValue = str_Driving_Notes.AdvancedSearch.SearchValue; // DN
                str_Driving_Notes.PlaceHolder = RemoveHtml(str_Driving_Notes.Caption);

                // int_Location_Id
                int_Location_Id.SetupEditAttributes();
                curVal = ConvertToString(int_Location_Id.AdvancedSearch.SearchValue)?.Trim() ?? "";
                if (int_Location_Id.Lookup != null && IsDictionary(int_Location_Id.Lookup?.Options) && int_Location_Id.Lookup?.Options.Values.Count > 0) { // Load from cache // DN
                    int_Location_Id.EditValue = int_Location_Id.Lookup?.Options.Values.ToList();
                } else { // Lookup from database
                    if (curVal == "") {
                        filterWrk = "0=1";
                    } else {
                        filterWrk = SearchFilter("[int_Location_Id]", "=", int_Location_Id.AdvancedSearch.SearchValue, DataType.Number, "");
                    }
                    sqlWrk = int_Location_Id.Lookup?.GetSql(true, filterWrk, null, this, false, true);
                    rswrk = sqlWrk != null ? Connection.GetRows(sqlWrk) : null; // Must use Sync to avoid overwriting ViewValue in RenderViewRow
                    int_Location_Id.EditValue = rswrk;
                }
                int_Location_Id.PlaceHolder = RemoveHtml(int_Location_Id.Caption);

                // int_Permit_Number
                int_Permit_Number.SetupEditAttributes();
                if (!int_Permit_Number.Raw)
                    int_Permit_Number.AdvancedSearch.SearchValue = HtmlDecode(int_Permit_Number.AdvancedSearch.SearchValue);
                int_Permit_Number.EditValue = HtmlEncode(int_Permit_Number.AdvancedSearch.SearchValue);
                int_Permit_Number.PlaceHolder = RemoveHtml(int_Permit_Number.Caption);

                // Permit_Issue_Date
                Permit_Issue_Date.SetupEditAttributes();
                if (!Permit_Issue_Date.Raw)
                    Permit_Issue_Date.AdvancedSearch.SearchValue = HtmlDecode(Permit_Issue_Date.AdvancedSearch.SearchValue);
                Permit_Issue_Date.EditValue = HtmlEncode(Permit_Issue_Date.AdvancedSearch.SearchValue);
                Permit_Issue_Date.PlaceHolder = RemoveHtml(Permit_Issue_Date.Caption);

                // Permit_Expiry_Date
                Permit_Expiry_Date.SetupEditAttributes();
                Permit_Expiry_Date.EditValue = FormatDateTime(UnformatDateTime(Permit_Expiry_Date.AdvancedSearch.SearchValue, Permit_Expiry_Date.FormatPattern), Permit_Expiry_Date.FormatPattern); // DN
                Permit_Expiry_Date.PlaceHolder = RemoveHtml(Permit_Expiry_Date.Caption);

                // int_Status
                int_Status.SetupEditAttributes();
                int_Status.EditValue = int_Status.AdvancedSearch.SearchValue; // DN
                int_Status.PlaceHolder = RemoveHtml(int_Status.Caption);

                // int_Lead_Id
                int_Lead_Id.SetupEditAttributes();
                int_Lead_Id.EditValue = int_Lead_Id.AdvancedSearch.SearchValue; // DN
                int_Lead_Id.PlaceHolder = RemoveHtml(int_Lead_Id.Caption);

                // int_Activated_By
                int_Activated_By.SetupEditAttributes();
                int_Activated_By.EditValue = int_Activated_By.AdvancedSearch.SearchValue; // DN
                int_Activated_By.PlaceHolder = RemoveHtml(int_Activated_By.Caption);

                // date_Activated
                date_Activated.SetupEditAttributes();
                date_Activated.EditValue = FormatDateTime(UnformatDateTime(date_Activated.AdvancedSearch.SearchValue, date_Activated.FormatPattern), date_Activated.FormatPattern); // DN
                date_Activated.PlaceHolder = RemoveHtml(date_Activated.Caption);

                // date_Created
                date_Created.SetupEditAttributes();
                date_Created.EditValue = FormatDateTime(UnformatDateTime(date_Created.AdvancedSearch.SearchValue, date_Created.FormatPattern), date_Created.FormatPattern); // DN
                date_Created.PlaceHolder = RemoveHtml(date_Created.Caption);

                // date_Modified
                date_Modified.SetupEditAttributes();
                date_Modified.EditValue = FormatDateTime(UnformatDateTime(date_Modified.AdvancedSearch.SearchValue, date_Modified.FormatPattern), date_Modified.FormatPattern); // DN
                date_Modified.PlaceHolder = RemoveHtml(date_Modified.Caption);

                // date_Complete
                date_Complete.SetupEditAttributes();
                date_Complete.EditValue = FormatDateTime(UnformatDateTime(date_Complete.AdvancedSearch.SearchValue, date_Complete.FormatPattern), date_Complete.FormatPattern); // DN
                date_Complete.PlaceHolder = RemoveHtml(date_Complete.Caption);

                // int_Created_By
                int_Created_By.SetupEditAttributes();
                int_Created_By.EditValue = int_Created_By.AdvancedSearch.SearchValue; // DN
                int_Created_By.PlaceHolder = RemoveHtml(int_Created_By.Caption);

                // int_Modified_By
                int_Modified_By.SetupEditAttributes();
                int_Modified_By.EditValue = int_Modified_By.AdvancedSearch.SearchValue; // DN
                int_Modified_By.PlaceHolder = RemoveHtml(int_Modified_By.Caption);

                // bit_IsDeleted
                bit_IsDeleted.EditValue = bit_IsDeleted.Options(false);
                bit_IsDeleted.PlaceHolder = RemoveHtml(bit_IsDeleted.Caption);

                // str_CardHolderName
                str_CardHolderName.SetupEditAttributes();
                if (!str_CardHolderName.Raw)
                    str_CardHolderName.AdvancedSearch.SearchValue = HtmlDecode(str_CardHolderName.AdvancedSearch.SearchValue);
                str_CardHolderName.EditValue = HtmlEncode(str_CardHolderName.AdvancedSearch.SearchValue);
                str_CardHolderName.PlaceHolder = RemoveHtml(str_CardHolderName.Caption);

                // str_CardHolderAddress
                str_CardHolderAddress.SetupEditAttributes();
                if (!str_CardHolderAddress.Raw)
                    str_CardHolderAddress.AdvancedSearch.SearchValue = HtmlDecode(str_CardHolderAddress.AdvancedSearch.SearchValue);
                str_CardHolderAddress.EditValue = HtmlEncode(str_CardHolderAddress.AdvancedSearch.SearchValue);
                str_CardHolderAddress.PlaceHolder = RemoveHtml(str_CardHolderAddress.Caption);

                // str_CardHolderCity
                str_CardHolderCity.SetupEditAttributes();
                if (!str_CardHolderCity.Raw)
                    str_CardHolderCity.AdvancedSearch.SearchValue = HtmlDecode(str_CardHolderCity.AdvancedSearch.SearchValue);
                str_CardHolderCity.EditValue = HtmlEncode(str_CardHolderCity.AdvancedSearch.SearchValue);
                str_CardHolderCity.PlaceHolder = RemoveHtml(str_CardHolderCity.Caption);

                // str_CardHolderZip
                str_CardHolderZip.SetupEditAttributes();
                if (!str_CardHolderZip.Raw)
                    str_CardHolderZip.AdvancedSearch.SearchValue = HtmlDecode(str_CardHolderZip.AdvancedSearch.SearchValue);
                str_CardHolderZip.EditValue = HtmlEncode(str_CardHolderZip.AdvancedSearch.SearchValue);
                str_CardHolderZip.PlaceHolder = RemoveHtml(str_CardHolderZip.Caption);

                // str_CardType
                str_CardType.SetupEditAttributes();
                if (!str_CardType.Raw)
                    str_CardType.AdvancedSearch.SearchValue = HtmlDecode(str_CardType.AdvancedSearch.SearchValue);
                str_CardType.EditValue = HtmlEncode(str_CardType.AdvancedSearch.SearchValue);
                str_CardType.PlaceHolder = RemoveHtml(str_CardType.Caption);

                // str_CardExpMonth
                str_CardExpMonth.SetupEditAttributes();
                if (!str_CardExpMonth.Raw)
                    str_CardExpMonth.AdvancedSearch.SearchValue = HtmlDecode(str_CardExpMonth.AdvancedSearch.SearchValue);
                str_CardExpMonth.EditValue = HtmlEncode(str_CardExpMonth.AdvancedSearch.SearchValue);
                str_CardExpMonth.PlaceHolder = RemoveHtml(str_CardExpMonth.Caption);

                // str_CardExpYear
                str_CardExpYear.SetupEditAttributes();
                if (!str_CardExpYear.Raw)
                    str_CardExpYear.AdvancedSearch.SearchValue = HtmlDecode(str_CardExpYear.AdvancedSearch.SearchValue);
                str_CardExpYear.EditValue = HtmlEncode(str_CardExpYear.AdvancedSearch.SearchValue);
                str_CardExpYear.PlaceHolder = RemoveHtml(str_CardExpYear.Caption);

                // str_CardNo
                str_CardNo.SetupEditAttributes();
                if (!str_CardNo.Raw)
                    str_CardNo.AdvancedSearch.SearchValue = HtmlDecode(str_CardNo.AdvancedSearch.SearchValue);
                str_CardNo.EditValue = HtmlEncode(str_CardNo.AdvancedSearch.SearchValue);
                str_CardNo.PlaceHolder = RemoveHtml(str_CardNo.Caption);

                // str_Certificate_No
                str_Certificate_No.SetupEditAttributes();
                if (!str_Certificate_No.Raw)
                    str_Certificate_No.AdvancedSearch.SearchValue = HtmlDecode(str_Certificate_No.AdvancedSearch.SearchValue);
                str_Certificate_No.EditValue = HtmlEncode(str_Certificate_No.AdvancedSearch.SearchValue);
                str_Certificate_No.PlaceHolder = RemoveHtml(str_Certificate_No.Caption);

                // str_AmountPaid
                str_AmountPaid.SetupEditAttributes();
                str_AmountPaid.EditValue = str_AmountPaid.AdvancedSearch.SearchValue; // DN
                str_AmountPaid.PlaceHolder = RemoveHtml(str_AmountPaid.Caption);

                // str_PermitValidated
                str_PermitValidated.SetupEditAttributes();
                if (!str_PermitValidated.Raw)
                    str_PermitValidated.AdvancedSearch.SearchValue = HtmlDecode(str_PermitValidated.AdvancedSearch.SearchValue);
                str_PermitValidated.EditValue = HtmlEncode(str_PermitValidated.AdvancedSearch.SearchValue);
                str_PermitValidated.PlaceHolder = RemoveHtml(str_PermitValidated.Caption);

                // strSMSNotification
                strSMSNotification.SetupEditAttributes();
                strSMSNotification.EditValue = strSMSNotification.Options(true);
                strSMSNotification.PlaceHolder = RemoveHtml(strSMSNotification.Caption);

                // strVoiceNotification
                strVoiceNotification.SetupEditAttributes();
                if (!strVoiceNotification.Raw)
                    strVoiceNotification.AdvancedSearch.SearchValue = HtmlDecode(strVoiceNotification.AdvancedSearch.SearchValue);
                strVoiceNotification.EditValue = HtmlEncode(strVoiceNotification.AdvancedSearch.SearchValue);
                strVoiceNotification.PlaceHolder = RemoveHtml(strVoiceNotification.Caption);

                // str_Weight
                str_Weight.SetupEditAttributes();
                if (!str_Weight.Raw)
                    str_Weight.AdvancedSearch.SearchValue = HtmlDecode(str_Weight.AdvancedSearch.SearchValue);
                str_Weight.EditValue = HtmlEncode(str_Weight.AdvancedSearch.SearchValue);
                str_Weight.PlaceHolder = RemoveHtml(str_Weight.Caption);

                // str_SpecialNeeds
                str_SpecialNeeds.SetupEditAttributes();
                str_SpecialNeeds.EditValue = str_SpecialNeeds.Options(true);
                str_SpecialNeeds.PlaceHolder = RemoveHtml(str_SpecialNeeds.Caption);

                // str_MedicalConditions
                str_MedicalConditions.SetupEditAttributes();
                str_MedicalConditions.EditValue = str_MedicalConditions.AdvancedSearch.SearchValue; // DN
                str_MedicalConditions.PlaceHolder = RemoveHtml(str_MedicalConditions.Caption);

                // bit_Verified_PIC_InSAW
                bit_Verified_PIC_InSAW.SetupEditAttributes();
                bit_Verified_PIC_InSAW.EditValue = bit_Verified_PIC_InSAW.AdvancedSearch.SearchValue; // DN
                bit_Verified_PIC_InSAW.PlaceHolder = RemoveHtml(bit_Verified_PIC_InSAW.Caption);

                // bit_Permit_Waiver_Entered
                bit_Permit_Waiver_Entered.SetupEditAttributes();
                bit_Permit_Waiver_Entered.EditValue = bit_Permit_Waiver_Entered.AdvancedSearch.SearchValue; // DN
                bit_Permit_Waiver_Entered.PlaceHolder = RemoveHtml(bit_Permit_Waiver_Entered.Caption);

                // bit_TermsConditions
                bit_TermsConditions.SetupEditAttributes();
                bit_TermsConditions.EditValue = bit_TermsConditions.AdvancedSearch.SearchValue; // DN
                bit_TermsConditions.PlaceHolder = RemoveHtml(bit_TermsConditions.Caption);

                // bit_Disable_Self_Scheduling
                bit_Disable_Self_Scheduling.SetupEditAttributes();
                bit_Disable_Self_Scheduling.EditValue = bit_Disable_Self_Scheduling.AdvancedSearch.SearchValue; // DN
                bit_Disable_Self_Scheduling.PlaceHolder = RemoveHtml(bit_Disable_Self_Scheduling.Caption);

                // int_EyeColor
                int_EyeColor.SetupEditAttributes();
                int_EyeColor.EditValue = int_EyeColor.AdvancedSearch.SearchValue; // DN
                int_EyeColor.PlaceHolder = RemoveHtml(int_EyeColor.Caption);

                // int_HairColor
                int_HairColor.SetupEditAttributes();
                int_HairColor.EditValue = int_HairColor.AdvancedSearch.SearchValue; // DN
                int_HairColor.PlaceHolder = RemoveHtml(int_HairColor.Caption);

                // int_ColorBlind
                int_ColorBlind.SetupEditAttributes();
                int_ColorBlind.EditValue = int_ColorBlind.AdvancedSearch.SearchValue; // DN
                int_ColorBlind.PlaceHolder = RemoveHtml(int_ColorBlind.Caption);

                // int_HeightFeet
                int_HeightFeet.SetupEditAttributes();
                int_HeightFeet.EditValue = int_HeightFeet.AdvancedSearch.SearchValue; // DN
                int_HeightFeet.PlaceHolder = RemoveHtml(int_HeightFeet.Caption);

                // int_HeightInches
                int_HeightInches.SetupEditAttributes();
                int_HeightInches.EditValue = int_HeightInches.AdvancedSearch.SearchValue; // DN
                int_HeightInches.PlaceHolder = RemoveHtml(int_HeightInches.Caption);

                // str_reference_code
                str_reference_code.SetupEditAttributes();
                if (!str_reference_code.Raw)
                    str_reference_code.AdvancedSearch.SearchValue = HtmlDecode(str_reference_code.AdvancedSearch.SearchValue);
                str_reference_code.EditValue = HtmlEncode(str_reference_code.AdvancedSearch.SearchValue);
                str_reference_code.PlaceHolder = RemoveHtml(str_reference_code.Caption);

                // dt_ParentClassAttendedDt
                dt_ParentClassAttendedDt.SetupEditAttributes();
                dt_ParentClassAttendedDt.EditValue = FormatDateTime(UnformatDateTime(dt_ParentClassAttendedDt.AdvancedSearch.SearchValue, dt_ParentClassAttendedDt.FormatPattern), dt_ParentClassAttendedDt.FormatPattern); // DN
                dt_ParentClassAttendedDt.PlaceHolder = RemoveHtml(dt_ParentClassAttendedDt.Caption);

                // str_ParentClassAttendedLoc
                str_ParentClassAttendedLoc.SetupEditAttributes();
                if (!str_ParentClassAttendedLoc.Raw)
                    str_ParentClassAttendedLoc.AdvancedSearch.SearchValue = HtmlDecode(str_ParentClassAttendedLoc.AdvancedSearch.SearchValue);
                str_ParentClassAttendedLoc.EditValue = HtmlEncode(str_ParentClassAttendedLoc.AdvancedSearch.SearchValue);
                str_ParentClassAttendedLoc.PlaceHolder = RemoveHtml(str_ParentClassAttendedLoc.Caption);

                // dt_SiblingClassAttendedDt
                dt_SiblingClassAttendedDt.SetupEditAttributes();
                dt_SiblingClassAttendedDt.EditValue = FormatDateTime(UnformatDateTime(dt_SiblingClassAttendedDt.AdvancedSearch.SearchValue, dt_SiblingClassAttendedDt.FormatPattern), dt_SiblingClassAttendedDt.FormatPattern); // DN
                dt_SiblingClassAttendedDt.PlaceHolder = RemoveHtml(dt_SiblingClassAttendedDt.Caption);

                // str_SiblingClassAttendedLoc
                str_SiblingClassAttendedLoc.SetupEditAttributes();
                if (!str_SiblingClassAttendedLoc.Raw)
                    str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue = HtmlDecode(str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue);
                str_SiblingClassAttendedLoc.EditValue = HtmlEncode(str_SiblingClassAttendedLoc.AdvancedSearch.SearchValue);
                str_SiblingClassAttendedLoc.PlaceHolder = RemoveHtml(str_SiblingClassAttendedLoc.Caption);

                // bit_PoliciesAndProcedures
                bit_PoliciesAndProcedures.EditValue = bit_PoliciesAndProcedures.Options(false);
                bit_PoliciesAndProcedures.PlaceHolder = RemoveHtml(bit_PoliciesAndProcedures.Caption);

                // dt_CourseCompletionDt
                dt_CourseCompletionDt.SetupEditAttributes();
                dt_CourseCompletionDt.EditValue = FormatDateTime(UnformatDateTime(dt_CourseCompletionDt.AdvancedSearch.SearchValue, dt_CourseCompletionDt.FormatPattern), dt_CourseCompletionDt.FormatPattern); // DN
                dt_CourseCompletionDt.PlaceHolder = RemoveHtml(dt_CourseCompletionDt.Caption);

                // dt_ExtensionDt
                dt_ExtensionDt.SetupEditAttributes();
                dt_ExtensionDt.EditValue = FormatDateTime(UnformatDateTime(dt_ExtensionDt.AdvancedSearch.SearchValue, dt_ExtensionDt.FormatPattern), dt_ExtensionDt.FormatPattern); // DN
                dt_ExtensionDt.PlaceHolder = RemoveHtml(dt_ExtensionDt.Caption);

                // str_MedicalCondition
                str_MedicalCondition.SetupEditAttributes();
                if (!str_MedicalCondition.Raw)
                    str_MedicalCondition.AdvancedSearch.SearchValue = HtmlDecode(str_MedicalCondition.AdvancedSearch.SearchValue);
                str_MedicalCondition.EditValue = HtmlEncode(str_MedicalCondition.AdvancedSearch.SearchValue);
                str_MedicalCondition.PlaceHolder = RemoveHtml(str_MedicalCondition.Caption);

                // str_MajorCrossStreets
                str_MajorCrossStreets.SetupEditAttributes();
                if (!str_MajorCrossStreets.Raw)
                    str_MajorCrossStreets.AdvancedSearch.SearchValue = HtmlDecode(str_MajorCrossStreets.AdvancedSearch.SearchValue);
                str_MajorCrossStreets.EditValue = HtmlEncode(str_MajorCrossStreets.AdvancedSearch.SearchValue);
                str_MajorCrossStreets.PlaceHolder = RemoveHtml(str_MajorCrossStreets.Caption);

                // str_DriverEdCertNo
                str_DriverEdCertNo.SetupEditAttributes();
                if (!str_DriverEdCertNo.Raw)
                    str_DriverEdCertNo.AdvancedSearch.SearchValue = HtmlDecode(str_DriverEdCertNo.AdvancedSearch.SearchValue);
                str_DriverEdCertNo.EditValue = HtmlEncode(str_DriverEdCertNo.AdvancedSearch.SearchValue);
                str_DriverEdCertNo.PlaceHolder = RemoveHtml(str_DriverEdCertNo.Caption);

                // dt_DriverEdCertIssuedDt
                dt_DriverEdCertIssuedDt.SetupEditAttributes();
                dt_DriverEdCertIssuedDt.EditValue = FormatDateTime(UnformatDateTime(dt_DriverEdCertIssuedDt.AdvancedSearch.SearchValue, dt_DriverEdCertIssuedDt.FormatPattern), dt_DriverEdCertIssuedDt.FormatPattern); // DN
                dt_DriverEdCertIssuedDt.PlaceHolder = RemoveHtml(dt_DriverEdCertIssuedDt.Caption);

                // str_BTWDriversEdCertNo
                str_BTWDriversEdCertNo.SetupEditAttributes();
                if (!str_BTWDriversEdCertNo.Raw)
                    str_BTWDriversEdCertNo.AdvancedSearch.SearchValue = HtmlDecode(str_BTWDriversEdCertNo.AdvancedSearch.SearchValue);
                str_BTWDriversEdCertNo.EditValue = HtmlEncode(str_BTWDriversEdCertNo.AdvancedSearch.SearchValue);
                str_BTWDriversEdCertNo.PlaceHolder = RemoveHtml(str_BTWDriversEdCertNo.Caption);

                // dt_BTWCertIssuedDt
                dt_BTWCertIssuedDt.SetupEditAttributes();
                dt_BTWCertIssuedDt.EditValue = FormatDateTime(UnformatDateTime(dt_BTWCertIssuedDt.AdvancedSearch.SearchValue, dt_BTWCertIssuedDt.FormatPattern), dt_BTWCertIssuedDt.FormatPattern); // DN
                dt_BTWCertIssuedDt.PlaceHolder = RemoveHtml(dt_BTWCertIssuedDt.Caption);

                // str_OLDriversEdCertNo
                str_OLDriversEdCertNo.SetupEditAttributes();
                if (!str_OLDriversEdCertNo.Raw)
                    str_OLDriversEdCertNo.AdvancedSearch.SearchValue = HtmlDecode(str_OLDriversEdCertNo.AdvancedSearch.SearchValue);
                str_OLDriversEdCertNo.EditValue = HtmlEncode(str_OLDriversEdCertNo.AdvancedSearch.SearchValue);
                str_OLDriversEdCertNo.PlaceHolder = RemoveHtml(str_OLDriversEdCertNo.Caption);

                // dt_OLCertIssuedDt
                dt_OLCertIssuedDt.SetupEditAttributes();
                dt_OLCertIssuedDt.EditValue = FormatDateTime(UnformatDateTime(dt_OLCertIssuedDt.AdvancedSearch.SearchValue, dt_OLCertIssuedDt.FormatPattern), dt_OLCertIssuedDt.FormatPattern); // DN
                dt_OLCertIssuedDt.PlaceHolder = RemoveHtml(dt_OLCertIssuedDt.Caption);

                // str_height
                str_height.SetupEditAttributes();
                if (!str_height.Raw)
                    str_height.AdvancedSearch.SearchValue = HtmlDecode(str_height.AdvancedSearch.SearchValue);
                str_height.EditValue = HtmlEncode(str_height.AdvancedSearch.SearchValue);
                str_height.PlaceHolder = RemoveHtml(str_height.Caption);

                // dt_BTWCompletionDt
                dt_BTWCompletionDt.SetupEditAttributes();
                dt_BTWCompletionDt.EditValue = FormatDateTime(UnformatDateTime(dt_BTWCompletionDt.AdvancedSearch.SearchValue, dt_BTWCompletionDt.FormatPattern), dt_BTWCompletionDt.FormatPattern); // DN
                dt_BTWCompletionDt.PlaceHolder = RemoveHtml(dt_BTWCompletionDt.Caption);

                // dt_CRCompletionDt
                dt_CRCompletionDt.SetupEditAttributes();
                dt_CRCompletionDt.EditValue = FormatDateTime(UnformatDateTime(dt_CRCompletionDt.AdvancedSearch.SearchValue, dt_CRCompletionDt.FormatPattern), dt_CRCompletionDt.FormatPattern); // DN
                dt_CRCompletionDt.PlaceHolder = RemoveHtml(dt_CRCompletionDt.Caption);

                // strTextBox5
                strTextBox5.SetupEditAttributes();
                if (!strTextBox5.Raw)
                    strTextBox5.AdvancedSearch.SearchValue = HtmlDecode(strTextBox5.AdvancedSearch.SearchValue);
                strTextBox5.EditValue = HtmlEncode(strTextBox5.AdvancedSearch.SearchValue);
                strTextBox5.PlaceHolder = RemoveHtml(strTextBox5.Caption);

                // strTextBox6
                strTextBox6.SetupEditAttributes();
                if (!strTextBox6.Raw)
                    strTextBox6.AdvancedSearch.SearchValue = HtmlDecode(strTextBox6.AdvancedSearch.SearchValue);
                strTextBox6.EditValue = HtmlEncode(strTextBox6.AdvancedSearch.SearchValue);
                strTextBox6.PlaceHolder = RemoveHtml(strTextBox6.Caption);

                // str_ApartmentNo
                str_ApartmentNo.SetupEditAttributes();
                if (!str_ApartmentNo.Raw)
                    str_ApartmentNo.AdvancedSearch.SearchValue = HtmlDecode(str_ApartmentNo.AdvancedSearch.SearchValue);
                str_ApartmentNo.EditValue = HtmlEncode(str_ApartmentNo.AdvancedSearch.SearchValue);
                str_ApartmentNo.PlaceHolder = RemoveHtml(str_ApartmentNo.Caption);

                // dt_PermitTestDate
                dt_PermitTestDate.SetupEditAttributes();
                dt_PermitTestDate.EditValue = FormatDateTime(UnformatDateTime(dt_PermitTestDate.AdvancedSearch.SearchValue, dt_PermitTestDate.FormatPattern), dt_PermitTestDate.FormatPattern); // DN
                dt_PermitTestDate.PlaceHolder = RemoveHtml(dt_PermitTestDate.Caption);

                // str_OnlineDriverEdLogin
                str_OnlineDriverEdLogin.SetupEditAttributes();
                if (!str_OnlineDriverEdLogin.Raw)
                    str_OnlineDriverEdLogin.AdvancedSearch.SearchValue = HtmlDecode(str_OnlineDriverEdLogin.AdvancedSearch.SearchValue);
                str_OnlineDriverEdLogin.EditValue = HtmlEncode(str_OnlineDriverEdLogin.AdvancedSearch.SearchValue);
                str_OnlineDriverEdLogin.PlaceHolder = RemoveHtml(str_OnlineDriverEdLogin.Caption);

                // str_OnlineDriverEdPassword
                str_OnlineDriverEdPassword.SetupEditAttributes();
                if (!str_OnlineDriverEdPassword.Raw)
                    str_OnlineDriverEdPassword.AdvancedSearch.SearchValue = HtmlDecode(str_OnlineDriverEdPassword.AdvancedSearch.SearchValue);
                str_OnlineDriverEdPassword.EditValue = HtmlEncode(str_OnlineDriverEdPassword.AdvancedSearch.SearchValue);
                str_OnlineDriverEdPassword.PlaceHolder = RemoveHtml(str_OnlineDriverEdPassword.Caption);

                // bit_IsSMSEnabled
                bit_IsSMSEnabled.EditValue = bit_IsSMSEnabled.Options(false);
                bit_IsSMSEnabled.PlaceHolder = RemoveHtml(bit_IsSMSEnabled.Caption);

                // dt_SMSModified
                dt_SMSModified.SetupEditAttributes();
                dt_SMSModified.EditValue = FormatDateTime(UnformatDateTime(dt_SMSModified.AdvancedSearch.SearchValue, dt_SMSModified.FormatPattern), dt_SMSModified.FormatPattern); // DN
                dt_SMSModified.PlaceHolder = RemoveHtml(dt_SMSModified.Caption);

                // str_confirmPassword
                str_confirmPassword.SetupEditAttributes();
                if (!str_confirmPassword.Raw)
                    str_confirmPassword.AdvancedSearch.SearchValue = HtmlDecode(str_confirmPassword.AdvancedSearch.SearchValue);
                str_confirmPassword.EditValue = HtmlEncode(str_confirmPassword.AdvancedSearch.SearchValue);
                str_confirmPassword.PlaceHolder = RemoveHtml(str_confirmPassword.Caption);

                // DE_Certificate
                DE_Certificate.SetupEditAttributes();
                if (!DE_Certificate.Raw)
                    DE_Certificate.AdvancedSearch.SearchValue = HtmlDecode(DE_Certificate.AdvancedSearch.SearchValue);
                DE_Certificate.EditValue = HtmlEncode(DE_Certificate.AdvancedSearch.SearchValue);
                DE_Certificate.PlaceHolder = RemoveHtml(DE_Certificate.Caption);

                // Discuss
                Discuss.SetupEditAttributes();
                if (!Discuss.Raw)
                    Discuss.AdvancedSearch.SearchValue = HtmlDecode(Discuss.AdvancedSearch.SearchValue);
                Discuss.EditValue = HtmlEncode(Discuss.AdvancedSearch.SearchValue);
                Discuss.PlaceHolder = RemoveHtml(Discuss.Caption);

                // int_UnlicensedSibling
                int_UnlicensedSibling.SetupEditAttributes();
                int_UnlicensedSibling.EditValue = int_UnlicensedSibling.AdvancedSearch.SearchValue; // DN
                int_UnlicensedSibling.PlaceHolder = RemoveHtml(int_UnlicensedSibling.Caption);

                // int_YearSiblingIsEligible
                int_YearSiblingIsEligible.SetupEditAttributes();
                int_YearSiblingIsEligible.EditValue = int_YearSiblingIsEligible.AdvancedSearch.SearchValue; // DN
                int_YearSiblingIsEligible.PlaceHolder = RemoveHtml(int_YearSiblingIsEligible.Caption);

                // BTW_Certificate
                BTW_Certificate.SetupEditAttributes();
                if (!BTW_Certificate.Raw)
                    BTW_Certificate.AdvancedSearch.SearchValue = HtmlDecode(BTW_Certificate.AdvancedSearch.SearchValue);
                BTW_Certificate.EditValue = HtmlEncode(BTW_Certificate.AdvancedSearch.SearchValue);
                BTW_Certificate.PlaceHolder = RemoveHtml(BTW_Certificate.Caption);

                // dt_DECertIssueDate
                dt_DECertIssueDate.SetupEditAttributes();
                if (!dt_DECertIssueDate.Raw)
                    dt_DECertIssueDate.AdvancedSearch.SearchValue = HtmlDecode(dt_DECertIssueDate.AdvancedSearch.SearchValue);
                dt_DECertIssueDate.EditValue = HtmlEncode(dt_DECertIssueDate.AdvancedSearch.SearchValue);
                dt_DECertIssueDate.PlaceHolder = RemoveHtml(dt_DECertIssueDate.Caption);

                // str_StudentSignature
                str_StudentSignature.SetupEditAttributes();
                if (!str_StudentSignature.Raw)
                    str_StudentSignature.AdvancedSearch.SearchValue = HtmlDecode(str_StudentSignature.AdvancedSearch.SearchValue);
                str_StudentSignature.EditValue = HtmlEncode(str_StudentSignature.AdvancedSearch.SearchValue);
                str_StudentSignature.PlaceHolder = RemoveHtml(str_StudentSignature.Caption);

                // str_ParentSignature
                str_ParentSignature.SetupEditAttributes();
                if (!str_ParentSignature.Raw)
                    str_ParentSignature.AdvancedSearch.SearchValue = HtmlDecode(str_ParentSignature.AdvancedSearch.SearchValue);
                str_ParentSignature.EditValue = HtmlEncode(str_ParentSignature.AdvancedSearch.SearchValue);
                str_ParentSignature.PlaceHolder = RemoveHtml(str_ParentSignature.Caption);

                // str_Last6DigitsOfParentDriversLicense
                str_Last6DigitsOfParentDriversLicense.SetupEditAttributes();
                if (!str_Last6DigitsOfParentDriversLicense.Raw)
                    str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue = HtmlDecode(str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue);
                str_Last6DigitsOfParentDriversLicense.EditValue = HtmlEncode(str_Last6DigitsOfParentDriversLicense.AdvancedSearch.SearchValue);
                str_Last6DigitsOfParentDriversLicense.PlaceHolder = RemoveHtml(str_Last6DigitsOfParentDriversLicense.Caption);

                // str_FACControl
                str_FACControl.SetupEditAttributes();
                if (!str_FACControl.Raw)
                    str_FACControl.AdvancedSearch.SearchValue = HtmlDecode(str_FACControl.AdvancedSearch.SearchValue);
                str_FACControl.EditValue = HtmlEncode(str_FACControl.AdvancedSearch.SearchValue);
                str_FACControl.PlaceHolder = RemoveHtml(str_FACControl.Caption);

                // Classroom_Status_Code
                Classroom_Status_Code.SetupEditAttributes();
                if (!Classroom_Status_Code.Raw)
                    Classroom_Status_Code.AdvancedSearch.SearchValue = HtmlDecode(Classroom_Status_Code.AdvancedSearch.SearchValue);
                Classroom_Status_Code.EditValue = HtmlEncode(Classroom_Status_Code.AdvancedSearch.SearchValue);
                Classroom_Status_Code.PlaceHolder = RemoveHtml(Classroom_Status_Code.Caption);

                // Laboratory_Status_Code
                Laboratory_Status_Code.SetupEditAttributes();
                if (!Laboratory_Status_Code.Raw)
                    Laboratory_Status_Code.AdvancedSearch.SearchValue = HtmlDecode(Laboratory_Status_Code.AdvancedSearch.SearchValue);
                Laboratory_Status_Code.EditValue = HtmlEncode(Laboratory_Status_Code.AdvancedSearch.SearchValue);
                Laboratory_Status_Code.PlaceHolder = RemoveHtml(Laboratory_Status_Code.Caption);

                // bit_EnrollmentForm
                bit_EnrollmentForm.EditValue = bit_EnrollmentForm.Options(false);
                bit_EnrollmentForm.PlaceHolder = RemoveHtml(bit_EnrollmentForm.Caption);

                // bit_ParentStudentContract
                bit_ParentStudentContract.EditValue = bit_ParentStudentContract.Options(false);
                bit_ParentStudentContract.PlaceHolder = RemoveHtml(bit_ParentStudentContract.Caption);

                // bit_ParentalAgreement
                bit_ParentalAgreement.EditValue = bit_ParentalAgreement.Options(false);
                bit_ParentalAgreement.PlaceHolder = RemoveHtml(bit_ParentalAgreement.Caption);

                // int_SF_GR_WA_HS
                int_SF_GR_WA_HS.SetupEditAttributes();
                int_SF_GR_WA_HS.EditValue = int_SF_GR_WA_HS.AdvancedSearch.SearchValue; // DN
                int_SF_GR_WA_HS.PlaceHolder = RemoveHtml(int_SF_GR_WA_HS.Caption);

                // bit_DisableOnRMV
                bit_DisableOnRMV.EditValue = bit_DisableOnRMV.Options(false);
                bit_DisableOnRMV.PlaceHolder = RemoveHtml(bit_DisableOnRMV.Caption);

                // bit_UploadedToRMV
                bit_UploadedToRMV.EditValue = bit_UploadedToRMV.Options(false);
                bit_UploadedToRMV.PlaceHolder = RemoveHtml(bit_UploadedToRMV.Caption);

                // str_Mother_Name
                str_Mother_Name.SetupEditAttributes();
                if (!str_Mother_Name.Raw)
                    str_Mother_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Mother_Name.AdvancedSearch.SearchValue);
                str_Mother_Name.EditValue = HtmlEncode(str_Mother_Name.AdvancedSearch.SearchValue);
                str_Mother_Name.PlaceHolder = RemoveHtml(str_Mother_Name.Caption);

                // str_Guardians_Name
                str_Guardians_Name.SetupEditAttributes();
                if (!str_Guardians_Name.Raw)
                    str_Guardians_Name.AdvancedSearch.SearchValue = HtmlDecode(str_Guardians_Name.AdvancedSearch.SearchValue);
                str_Guardians_Name.EditValue = HtmlEncode(str_Guardians_Name.AdvancedSearch.SearchValue);
                str_Guardians_Name.PlaceHolder = RemoveHtml(str_Guardians_Name.Caption);

                // str_Mother_Phone
                str_Mother_Phone.SetupEditAttributes();
                if (!str_Mother_Phone.Raw)
                    str_Mother_Phone.AdvancedSearch.SearchValue = HtmlDecode(str_Mother_Phone.AdvancedSearch.SearchValue);
                str_Mother_Phone.EditValue = HtmlEncode(str_Mother_Phone.AdvancedSearch.SearchValue);
                str_Mother_Phone.PlaceHolder = RemoveHtml(str_Mother_Phone.Caption);

                // bit_terms
                bit_terms.EditValue = bit_terms.Options(false);
                bit_terms.PlaceHolder = RemoveHtml(bit_terms.Caption);

                // int_Nationality
                int_Nationality.SetupEditAttributes();
                int_Nationality.EditValue = int_Nationality.AdvancedSearch.SearchValue; // DN
                int_Nationality.PlaceHolder = RemoveHtml(int_Nationality.Caption);

                // str_National_ID_en
                str_National_ID_en.SetupEditAttributes();
                if (!str_National_ID_en.Raw)
                    str_National_ID_en.AdvancedSearch.SearchValue = HtmlDecode(str_National_ID_en.AdvancedSearch.SearchValue);
                str_National_ID_en.EditValue = HtmlEncode(str_National_ID_en.AdvancedSearch.SearchValue);
                str_National_ID_en.PlaceHolder = RemoveHtml(str_National_ID_en.Caption);

                // str_National_ID_arabic
                str_National_ID_arabic.SetupEditAttributes();
                if (!str_National_ID_arabic.Raw)
                    str_National_ID_arabic.AdvancedSearch.SearchValue = HtmlDecode(str_National_ID_arabic.AdvancedSearch.SearchValue);
                str_National_ID_arabic.EditValue = HtmlEncode(str_National_ID_arabic.AdvancedSearch.SearchValue);
                str_National_ID_arabic.PlaceHolder = RemoveHtml(str_National_ID_arabic.Caption);

                // Quallification_Id
                Quallification_Id.SetupEditAttributes();
                Quallification_Id.EditValue = Quallification_Id.AdvancedSearch.SearchValue; // DN
                Quallification_Id.PlaceHolder = RemoveHtml(Quallification_Id.Caption);

                // Job_Id
                Job_Id.SetupEditAttributes();
                Job_Id.EditValue = Job_Id.AdvancedSearch.SearchValue; // DN
                Job_Id.PlaceHolder = RemoveHtml(Job_Id.Caption);

                // str_DOB_arabic
                str_DOB_arabic.PlaceHolder = RemoveHtml(str_DOB_arabic.Caption);

                // int_Language
                int_Language.SetupEditAttributes();
                int_Language.EditValue = int_Language.AdvancedSearch.SearchValue; // DN
                int_Language.PlaceHolder = RemoveHtml(int_Language.Caption);

                // strRefId
                strRefId.SetupEditAttributes();
                if (!strRefId.Raw)
                    strRefId.AdvancedSearch.SearchValue = HtmlDecode(strRefId.AdvancedSearch.SearchValue);
                strRefId.EditValue = HtmlEncode(strRefId.AdvancedSearch.SearchValue);
                strRefId.PlaceHolder = RemoveHtml(strRefId.Caption);

                // int_Program_Id
                int_Program_Id.SetupEditAttributes();
                int_Program_Id.EditValue = int_Program_Id.Options(true);
                int_Program_Id.PlaceHolder = RemoveHtml(int_Program_Id.Caption);

                // IsDrivingexperience
                IsDrivingexperience.EditValue = IsDrivingexperience.Options(false);
                IsDrivingexperience.PlaceHolder = RemoveHtml(IsDrivingexperience.Caption);

                // IsScheduleassessment
                IsScheduleassessment.EditValue = IsScheduleassessment.Options(false);
                IsScheduleassessment.PlaceHolder = RemoveHtml(IsScheduleassessment.Caption);

                // IsEnrollbyyourself
                IsEnrollbyyourself.EditValue = IsEnrollbyyourself.Options(false);
                IsEnrollbyyourself.PlaceHolder = RemoveHtml(IsEnrollbyyourself.Caption);

                // AssessmentTime
                AssessmentTime.SetupEditAttributes();
                if (!AssessmentTime.Raw)
                    AssessmentTime.AdvancedSearch.SearchValue = HtmlDecode(AssessmentTime.AdvancedSearch.SearchValue);
                AssessmentTime.EditValue = HtmlEncode(AssessmentTime.AdvancedSearch.SearchValue);
                AssessmentTime.PlaceHolder = RemoveHtml(AssessmentTime.Caption);

                // AssessmentDate
                AssessmentDate.SetupEditAttributes();
                AssessmentDate.EditValue = FormatDateTime(UnformatDateTime(AssessmentDate.AdvancedSearch.SearchValue, AssessmentDate.FormatPattern), AssessmentDate.FormatPattern); // DN
                AssessmentDate.PlaceHolder = RemoveHtml(AssessmentDate.Caption);

                // isAssessmentDone
                isAssessmentDone.EditValue = isAssessmentDone.Options(false);
                isAssessmentDone.PlaceHolder = RemoveHtml(isAssessmentDone.Caption);

                // AssessmentScore
                AssessmentScore.SetupEditAttributes();
                AssessmentScore.EditValue = AssessmentScore.AdvancedSearch.SearchValue; // DN
                AssessmentScore.PlaceHolder = RemoveHtml(AssessmentScore.Caption);

                // dt_WrittenTestPassed
                dt_WrittenTestPassed.EditValue = dt_WrittenTestPassed.Options(false);
                dt_WrittenTestPassed.PlaceHolder = RemoveHtml(dt_WrittenTestPassed.Caption);

                // dt_RoadTestPassed
                dt_RoadTestPassed.EditValue = dt_RoadTestPassed.Options(false);
                dt_RoadTestPassed.PlaceHolder = RemoveHtml(dt_RoadTestPassed.Caption);

                // bit_Archive
                bit_Archive.EditValue = bit_Archive.Options(false);
                bit_Archive.PlaceHolder = RemoveHtml(bit_Archive.Caption);

                // ArchiveNotes
                ArchiveNotes.SetupEditAttributes();
                if (!ArchiveNotes.Raw)
                    ArchiveNotes.AdvancedSearch.SearchValue = HtmlDecode(ArchiveNotes.AdvancedSearch.SearchValue);
                ArchiveNotes.EditValue = HtmlEncode(ArchiveNotes.AdvancedSearch.SearchValue);
                ArchiveNotes.PlaceHolder = RemoveHtml(ArchiveNotes.Caption);

                // dtArchived
                dtArchived.SetupEditAttributes();
                dtArchived.EditValue = FormatDateTime(UnformatDateTime(dtArchived.AdvancedSearch.SearchValue, dtArchived.FormatPattern), dtArchived.FormatPattern); // DN
                dtArchived.PlaceHolder = RemoveHtml(dtArchived.Caption);

                // SrNo9Dec21
                SrNo9Dec21.SetupEditAttributes();
                SrNo9Dec21.EditValue = SrNo9Dec21.AdvancedSearch.SearchValue; // DN
                SrNo9Dec21.PlaceHolder = RemoveHtml(SrNo9Dec21.Caption);

                // REGNNUMB
                REGNNUMB.SetupEditAttributes();
                if (!REGNNUMB.Raw)
                    REGNNUMB.AdvancedSearch.SearchValue = HtmlDecode(REGNNUMB.AdvancedSearch.SearchValue);
                REGNNUMB.EditValue = HtmlEncode(REGNNUMB.AdvancedSearch.SearchValue);
                REGNNUMB.PlaceHolder = RemoveHtml(REGNNUMB.Caption);

                // REGNLOCN
                REGNLOCN.SetupEditAttributes();
                if (!REGNLOCN.Raw)
                    REGNLOCN.AdvancedSearch.SearchValue = HtmlDecode(REGNLOCN.AdvancedSearch.SearchValue);
                REGNLOCN.EditValue = HtmlEncode(REGNLOCN.AdvancedSearch.SearchValue);
                REGNLOCN.PlaceHolder = RemoveHtml(REGNLOCN.Caption);

                // SrNo11DecF1S1
                SrNo11DecF1S1.SetupEditAttributes();
                SrNo11DecF1S1.EditValue = SrNo11DecF1S1.AdvancedSearch.SearchValue; // DN
                SrNo11DecF1S1.PlaceHolder = RemoveHtml(SrNo11DecF1S1.Caption);

                // IsInterestedInTraining
                IsInterestedInTraining.SetupEditAttributes();
                IsInterestedInTraining.EditValue = IsInterestedInTraining.AdvancedSearch.SearchValue; // DN
                IsInterestedInTraining.PlaceHolder = RemoveHtml(IsInterestedInTraining.Caption);

                // StudentEncryptID
                StudentEncryptID.SetupEditAttributes();
                if (!StudentEncryptID.Raw)
                    StudentEncryptID.AdvancedSearch.SearchValue = HtmlDecode(StudentEncryptID.AdvancedSearch.SearchValue);
                StudentEncryptID.EditValue = HtmlEncode(StudentEncryptID.AdvancedSearch.SearchValue);
                StudentEncryptID.PlaceHolder = RemoveHtml(StudentEncryptID.Caption);

                // StudentConfirURL
                StudentConfirURL.SetupEditAttributes();
                if (!StudentConfirURL.Raw)
                    StudentConfirURL.AdvancedSearch.SearchValue = HtmlDecode(StudentConfirURL.AdvancedSearch.SearchValue);
                StudentConfirURL.EditValue = HtmlEncode(StudentConfirURL.AdvancedSearch.SearchValue);
                StudentConfirURL.PlaceHolder = RemoveHtml(StudentConfirURL.Caption);

                // SrNo15DecF1S2
                SrNo15DecF1S2.SetupEditAttributes();
                SrNo15DecF1S2.EditValue = SrNo15DecF1S2.AdvancedSearch.SearchValue; // DN
                SrNo15DecF1S2.PlaceHolder = RemoveHtml(SrNo15DecF1S2.Caption);

                // SrNo15DecF1S3
                SrNo15DecF1S3.SetupEditAttributes();
                SrNo15DecF1S3.EditValue = SrNo15DecF1S3.AdvancedSearch.SearchValue; // DN
                SrNo15DecF1S3.PlaceHolder = RemoveHtml(SrNo15DecF1S3.Caption);

                // SrNo16DecF2S2
                SrNo16DecF2S2.SetupEditAttributes();
                SrNo16DecF2S2.EditValue = SrNo16DecF2S2.AdvancedSearch.SearchValue; // DN
                SrNo16DecF2S2.PlaceHolder = RemoveHtml(SrNo16DecF2S2.Caption);

                // SrNo16DecF2S3
                SrNo16DecF2S3.SetupEditAttributes();
                SrNo16DecF2S3.EditValue = SrNo16DecF2S3.AdvancedSearch.SearchValue; // DN
                SrNo16DecF2S3.PlaceHolder = RemoveHtml(SrNo16DecF2S3.Caption);

                // SrNo16DecF3S1
                SrNo16DecF3S1.SetupEditAttributes();
                SrNo16DecF3S1.EditValue = SrNo16DecF3S1.AdvancedSearch.SearchValue; // DN
                SrNo16DecF3S1.PlaceHolder = RemoveHtml(SrNo16DecF3S1.Caption);

                // SrNo16DecF3S2
                SrNo16DecF3S2.SetupEditAttributes();
                SrNo16DecF3S2.EditValue = SrNo16DecF3S2.AdvancedSearch.SearchValue; // DN
                SrNo16DecF3S2.PlaceHolder = RemoveHtml(SrNo16DecF3S2.Caption);

                // SrNo16DecF4S1
                SrNo16DecF4S1.SetupEditAttributes();
                SrNo16DecF4S1.EditValue = SrNo16DecF4S1.AdvancedSearch.SearchValue; // DN
                SrNo16DecF4S1.PlaceHolder = RemoveHtml(SrNo16DecF4S1.Caption);

                // SrNo16DecF4S2
                SrNo16DecF4S2.SetupEditAttributes();
                SrNo16DecF4S2.EditValue = SrNo16DecF4S2.AdvancedSearch.SearchValue; // DN
                SrNo16DecF4S2.PlaceHolder = RemoveHtml(SrNo16DecF4S2.Caption);

                // SrNo16DecF4S3
                SrNo16DecF4S3.SetupEditAttributes();
                SrNo16DecF4S3.EditValue = SrNo16DecF4S3.AdvancedSearch.SearchValue; // DN
                SrNo16DecF4S3.PlaceHolder = RemoveHtml(SrNo16DecF4S3.Caption);

                // StudentAssementBookingURL
                StudentAssementBookingURL.SetupEditAttributes();
                if (!StudentAssementBookingURL.Raw)
                    StudentAssementBookingURL.AdvancedSearch.SearchValue = HtmlDecode(StudentAssementBookingURL.AdvancedSearch.SearchValue);
                StudentAssementBookingURL.EditValue = HtmlEncode(StudentAssementBookingURL.AdvancedSearch.SearchValue);
                StudentAssementBookingURL.PlaceHolder = RemoveHtml(StudentAssementBookingURL.Caption);

                // intDrivinglicenseType
                intDrivinglicenseType.SetupEditAttributes();
                intDrivinglicenseType.EditValue = intDrivinglicenseType.AdvancedSearch.SearchValue; // DN
                intDrivinglicenseType.PlaceHolder = RemoveHtml(intDrivinglicenseType.Caption);

                // Isdrivinglicense
                Isdrivinglicense.EditValue = Isdrivinglicense.Options(false);
                Isdrivinglicense.PlaceHolder = RemoveHtml(Isdrivinglicense.Caption);

                // drivinglicensenumber
                drivinglicensenumber.SetupEditAttributes();
                if (!drivinglicensenumber.Raw)
                    drivinglicensenumber.AdvancedSearch.SearchValue = HtmlDecode(drivinglicensenumber.AdvancedSearch.SearchValue);
                drivinglicensenumber.EditValue = HtmlEncode(drivinglicensenumber.AdvancedSearch.SearchValue);
                drivinglicensenumber.PlaceHolder = RemoveHtml(drivinglicensenumber.Caption);

                // Absher_Appointment_number
                Absher_Appointment_number.SetupEditAttributes();
                if (!Absher_Appointment_number.Raw)
                    Absher_Appointment_number.AdvancedSearch.SearchValue = HtmlDecode(Absher_Appointment_number.AdvancedSearch.SearchValue);
                Absher_Appointment_number.EditValue = HtmlEncode(Absher_Appointment_number.AdvancedSearch.SearchValue);
                Absher_Appointment_number.PlaceHolder = RemoveHtml(Absher_Appointment_number.Caption);

                // DataImportId
                DataImportId.SetupEditAttributes();
                DataImportId.EditValue = DataImportId.AdvancedSearch.SearchValue; // DN
                DataImportId.PlaceHolder = RemoveHtml(DataImportId.Caption);

                // date_Birth_Hijri
                date_Birth_Hijri.SetupEditAttributes();
                if (!date_Birth_Hijri.Raw)
                    date_Birth_Hijri.AdvancedSearch.SearchValue = HtmlDecode(date_Birth_Hijri.AdvancedSearch.SearchValue);
                date_Birth_Hijri.EditValue = HtmlEncode(date_Birth_Hijri.AdvancedSearch.SearchValue);
                date_Birth_Hijri.PlaceHolder = RemoveHtml(date_Birth_Hijri.Caption);

                // UserlevelID
                UserlevelID.SetupEditAttributes();
                UserlevelID.EditValue = UserlevelID.AdvancedSearch.SearchValue; // DN
                UserlevelID.PlaceHolder = RemoveHtml(UserlevelID.Caption);

                // Activated
                Activated.EditValue = Activated.Options(false);
                Activated.PlaceHolder = RemoveHtml(Activated.Caption);

                // Absherphoto
                Absherphoto.SetupEditAttributes();
                if (!Absherphoto.Raw)
                    Absherphoto.AdvancedSearch.SearchValue = HtmlDecode(Absherphoto.AdvancedSearch.SearchValue);
                Absherphoto.EditValue = HtmlEncode(Absherphoto.AdvancedSearch.SearchValue);
                Absherphoto.PlaceHolder = RemoveHtml(Absherphoto.Caption);

                // Fingerprint
                Fingerprint.SetupEditAttributes();
                if (!Fingerprint.Raw)
                    Fingerprint.AdvancedSearch.SearchValue = HtmlDecode(Fingerprint.AdvancedSearch.SearchValue);
                Fingerprint.EditValue = HtmlEncode(Fingerprint.AdvancedSearch.SearchValue);
                Fingerprint.PlaceHolder = RemoveHtml(Fingerprint.Caption);

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

                // Hijri_Day
                Hijri_Day.SetupEditAttributes();
                Hijri_Day.EditValue = Hijri_Day.AdvancedSearch.SearchValue; // DN
                Hijri_Day.PlaceHolder = RemoveHtml(Hijri_Day.Caption);

                // Hijri_Month
                Hijri_Month.SetupEditAttributes();
                Hijri_Month.EditValue = Hijri_Month.AdvancedSearch.SearchValue; // DN
                Hijri_Month.PlaceHolder = RemoveHtml(Hijri_Month.Caption);

                // Hijri_Year
                Hijri_Year.SetupEditAttributes();
                Hijri_Year.EditValue = Hijri_Year.AdvancedSearch.SearchValue; // DN
                Hijri_Year.PlaceHolder = RemoveHtml(Hijri_Year.Caption);

                // Course_Price
                Course_Price.SetupEditAttributes();
                Course_Price.EditValue = Course_Price.AdvancedSearch.SearchValue; // DN
                Course_Price.PlaceHolder = RemoveHtml(Course_Price.Caption);

                // Vat_Tax_15
                Vat_Tax_15.SetupEditAttributes();
                Vat_Tax_15.EditValue = Vat_Tax_15.AdvancedSearch.SearchValue; // DN
                Vat_Tax_15.PlaceHolder = RemoveHtml(Vat_Tax_15.Caption);

                // dec_Balance
                dec_Balance.SetupEditAttributes();
                dec_Balance.EditValue = dec_Balance.AdvancedSearch.SearchValue; // DN
                dec_Balance.PlaceHolder = RemoveHtml(dec_Balance.Caption);

                // Total_Price
                Total_Price.SetupEditAttributes();
                Total_Price.EditValue = Total_Price.AdvancedSearch.SearchValue; // DN
                Total_Price.PlaceHolder = RemoveHtml(Total_Price.Caption);

                // Payment_Online
                Payment_Online.SetupEditAttributes();
                if (!Payment_Online.Raw)
                    Payment_Online.AdvancedSearch.SearchValue = HtmlDecode(Payment_Online.AdvancedSearch.SearchValue);
                Payment_Online.EditValue = HtmlEncode(Payment_Online.AdvancedSearch.SearchValue);
                Payment_Online.PlaceHolder = RemoveHtml(Payment_Online.Caption);

                // Institution
                Institution.SetupEditAttributes();
                if (!Institution.Raw)
                    Institution.AdvancedSearch.SearchValue = HtmlDecode(Institution.AdvancedSearch.SearchValue);
                Institution.EditValue = HtmlEncode(Institution.AdvancedSearch.SearchValue);
                Institution.PlaceHolder = RemoveHtml(Institution.Caption);

                // WaitingList
                WaitingList.EditValue = WaitingList.Options(false);
                WaitingList.PlaceHolder = RemoveHtml(WaitingList.Caption);

                // Assessment_ID
                Assessment_ID.SetupEditAttributes();
                Assessment_ID.EditValue = Assessment_ID.AdvancedSearch.SearchValue; // DN
                Assessment_ID.PlaceHolder = RemoveHtml(Assessment_ID.Caption);
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
            if (!CheckInteger(ConvertToString(int_Potential_Student_ID.AdvancedSearch.SearchValue))) {
                int_Potential_Student_ID.AddErrorMessage(int_Potential_Student_ID.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Student_Id.AdvancedSearch.SearchValue))) {
                int_Student_Id.AddErrorMessage(int_Student_Id.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(NationalID.AdvancedSearch.SearchValue))) {
                NationalID.AddErrorMessage(NationalID.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(int_Driver.AdvancedSearch.SearchValue))) {
                int_Driver.AddErrorMessage(int_Driver.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(str_DOB.AdvancedSearch.SearchValue), str_DOB.FormatPattern)) {
                str_DOB.AddErrorMessage(str_DOB.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_DOB_Day.AdvancedSearch.SearchValue))) {
                int_DOB_Day.AddErrorMessage(int_DOB_Day.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_DOB_Month.AdvancedSearch.SearchValue))) {
                int_DOB_Month.AddErrorMessage(int_DOB_Month.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_DOB_Year.AdvancedSearch.SearchValue))) {
                int_DOB_Year.AddErrorMessage(int_DOB_Year.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Age.AdvancedSearch.SearchValue))) {
                int_Age.AddErrorMessage(int_Age.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Type.AdvancedSearch.SearchValue))) {
                int_Type.AddErrorMessage(int_Type.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Wear_Glasses.AdvancedSearch.SearchValue))) {
                int_Wear_Glasses.AddErrorMessage(int_Wear_Glasses.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_Date_PermitIssue.AdvancedSearch.SearchValue), dt_Date_PermitIssue.FormatPattern)) {
                dt_Date_PermitIssue.AddErrorMessage(dt_Date_PermitIssue.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_Date_ExpirePermit.AdvancedSearch.SearchValue), dt_Date_ExpirePermit.FormatPattern)) {
                dt_Date_ExpirePermit.AddErrorMessage(dt_Date_ExpirePermit.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Hs_ID.AdvancedSearch.SearchValue))) {
                int_Hs_ID.AddErrorMessage(int_Hs_ID.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(Permit_Expiry_Date.AdvancedSearch.SearchValue), Permit_Expiry_Date.FormatPattern)) {
                Permit_Expiry_Date.AddErrorMessage(Permit_Expiry_Date.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Status.AdvancedSearch.SearchValue))) {
                int_Status.AddErrorMessage(int_Status.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(int_Lead_Id.AdvancedSearch.SearchValue))) {
                int_Lead_Id.AddErrorMessage(int_Lead_Id.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(int_Activated_By.AdvancedSearch.SearchValue))) {
                int_Activated_By.AddErrorMessage(int_Activated_By.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(date_Activated.AdvancedSearch.SearchValue), date_Activated.FormatPattern)) {
                date_Activated.AddErrorMessage(date_Activated.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(date_Complete.AdvancedSearch.SearchValue), date_Complete.FormatPattern)) {
                date_Complete.AddErrorMessage(date_Complete.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Created_By.AdvancedSearch.SearchValue))) {
                int_Created_By.AddErrorMessage(int_Created_By.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Modified_By.AdvancedSearch.SearchValue))) {
                int_Modified_By.AddErrorMessage(int_Modified_By.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(str_AmountPaid.AdvancedSearch.SearchValue))) {
                str_AmountPaid.AddErrorMessage(str_AmountPaid.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(bit_Verified_PIC_InSAW.AdvancedSearch.SearchValue))) {
                bit_Verified_PIC_InSAW.AddErrorMessage(bit_Verified_PIC_InSAW.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(bit_Permit_Waiver_Entered.AdvancedSearch.SearchValue))) {
                bit_Permit_Waiver_Entered.AddErrorMessage(bit_Permit_Waiver_Entered.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(bit_TermsConditions.AdvancedSearch.SearchValue))) {
                bit_TermsConditions.AddErrorMessage(bit_TermsConditions.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(bit_Disable_Self_Scheduling.AdvancedSearch.SearchValue))) {
                bit_Disable_Self_Scheduling.AddErrorMessage(bit_Disable_Self_Scheduling.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_EyeColor.AdvancedSearch.SearchValue))) {
                int_EyeColor.AddErrorMessage(int_EyeColor.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_HairColor.AdvancedSearch.SearchValue))) {
                int_HairColor.AddErrorMessage(int_HairColor.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_ColorBlind.AdvancedSearch.SearchValue))) {
                int_ColorBlind.AddErrorMessage(int_ColorBlind.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_HeightFeet.AdvancedSearch.SearchValue))) {
                int_HeightFeet.AddErrorMessage(int_HeightFeet.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_HeightInches.AdvancedSearch.SearchValue))) {
                int_HeightInches.AddErrorMessage(int_HeightInches.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_ParentClassAttendedDt.AdvancedSearch.SearchValue), dt_ParentClassAttendedDt.FormatPattern)) {
                dt_ParentClassAttendedDt.AddErrorMessage(dt_ParentClassAttendedDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_SiblingClassAttendedDt.AdvancedSearch.SearchValue), dt_SiblingClassAttendedDt.FormatPattern)) {
                dt_SiblingClassAttendedDt.AddErrorMessage(dt_SiblingClassAttendedDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_CourseCompletionDt.AdvancedSearch.SearchValue), dt_CourseCompletionDt.FormatPattern)) {
                dt_CourseCompletionDt.AddErrorMessage(dt_CourseCompletionDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_ExtensionDt.AdvancedSearch.SearchValue), dt_ExtensionDt.FormatPattern)) {
                dt_ExtensionDt.AddErrorMessage(dt_ExtensionDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_DriverEdCertIssuedDt.AdvancedSearch.SearchValue), dt_DriverEdCertIssuedDt.FormatPattern)) {
                dt_DriverEdCertIssuedDt.AddErrorMessage(dt_DriverEdCertIssuedDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_BTWCertIssuedDt.AdvancedSearch.SearchValue), dt_BTWCertIssuedDt.FormatPattern)) {
                dt_BTWCertIssuedDt.AddErrorMessage(dt_BTWCertIssuedDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_OLCertIssuedDt.AdvancedSearch.SearchValue), dt_OLCertIssuedDt.FormatPattern)) {
                dt_OLCertIssuedDt.AddErrorMessage(dt_OLCertIssuedDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_BTWCompletionDt.AdvancedSearch.SearchValue), dt_BTWCompletionDt.FormatPattern)) {
                dt_BTWCompletionDt.AddErrorMessage(dt_BTWCompletionDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_CRCompletionDt.AdvancedSearch.SearchValue), dt_CRCompletionDt.FormatPattern)) {
                dt_CRCompletionDt.AddErrorMessage(dt_CRCompletionDt.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_PermitTestDate.AdvancedSearch.SearchValue), dt_PermitTestDate.FormatPattern)) {
                dt_PermitTestDate.AddErrorMessage(dt_PermitTestDate.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dt_SMSModified.AdvancedSearch.SearchValue), dt_SMSModified.FormatPattern)) {
                dt_SMSModified.AddErrorMessage(dt_SMSModified.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_UnlicensedSibling.AdvancedSearch.SearchValue))) {
                int_UnlicensedSibling.AddErrorMessage(int_UnlicensedSibling.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_YearSiblingIsEligible.AdvancedSearch.SearchValue))) {
                int_YearSiblingIsEligible.AddErrorMessage(int_YearSiblingIsEligible.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_SF_GR_WA_HS.AdvancedSearch.SearchValue))) {
                int_SF_GR_WA_HS.AddErrorMessage(int_SF_GR_WA_HS.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Nationality.AdvancedSearch.SearchValue))) {
                int_Nationality.AddErrorMessage(int_Nationality.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(Quallification_Id.AdvancedSearch.SearchValue))) {
                Quallification_Id.AddErrorMessage(Quallification_Id.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(Job_Id.AdvancedSearch.SearchValue))) {
                Job_Id.AddErrorMessage(Job_Id.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(int_Language.AdvancedSearch.SearchValue))) {
                int_Language.AddErrorMessage(int_Language.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(AssessmentDate.AdvancedSearch.SearchValue), AssessmentDate.FormatPattern)) {
                AssessmentDate.AddErrorMessage(AssessmentDate.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(AssessmentScore.AdvancedSearch.SearchValue))) {
                AssessmentScore.AddErrorMessage(AssessmentScore.GetErrorMessage(false));
            }
            if (!CheckDate(ConvertToString(dtArchived.AdvancedSearch.SearchValue), dtArchived.FormatPattern)) {
                dtArchived.AddErrorMessage(dtArchived.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo9Dec21.AdvancedSearch.SearchValue))) {
                SrNo9Dec21.AddErrorMessage(SrNo9Dec21.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo11DecF1S1.AdvancedSearch.SearchValue))) {
                SrNo11DecF1S1.AddErrorMessage(SrNo11DecF1S1.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(IsInterestedInTraining.AdvancedSearch.SearchValue))) {
                IsInterestedInTraining.AddErrorMessage(IsInterestedInTraining.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo15DecF1S2.AdvancedSearch.SearchValue))) {
                SrNo15DecF1S2.AddErrorMessage(SrNo15DecF1S2.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo15DecF1S3.AdvancedSearch.SearchValue))) {
                SrNo15DecF1S3.AddErrorMessage(SrNo15DecF1S3.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo16DecF2S2.AdvancedSearch.SearchValue))) {
                SrNo16DecF2S2.AddErrorMessage(SrNo16DecF2S2.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo16DecF2S3.AdvancedSearch.SearchValue))) {
                SrNo16DecF2S3.AddErrorMessage(SrNo16DecF2S3.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo16DecF3S1.AdvancedSearch.SearchValue))) {
                SrNo16DecF3S1.AddErrorMessage(SrNo16DecF3S1.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo16DecF3S2.AdvancedSearch.SearchValue))) {
                SrNo16DecF3S2.AddErrorMessage(SrNo16DecF3S2.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo16DecF4S1.AdvancedSearch.SearchValue))) {
                SrNo16DecF4S1.AddErrorMessage(SrNo16DecF4S1.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo16DecF4S2.AdvancedSearch.SearchValue))) {
                SrNo16DecF4S2.AddErrorMessage(SrNo16DecF4S2.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(SrNo16DecF4S3.AdvancedSearch.SearchValue))) {
                SrNo16DecF4S3.AddErrorMessage(SrNo16DecF4S3.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(intDrivinglicenseType.AdvancedSearch.SearchValue))) {
                intDrivinglicenseType.AddErrorMessage(intDrivinglicenseType.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(DataImportId.AdvancedSearch.SearchValue))) {
                DataImportId.AddErrorMessage(DataImportId.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(UserlevelID.AdvancedSearch.SearchValue))) {
                UserlevelID.AddErrorMessage(UserlevelID.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(Price.AdvancedSearch.SearchValue))) {
                Price.AddErrorMessage(Price.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(Hijri_Day.AdvancedSearch.SearchValue))) {
                Hijri_Day.AddErrorMessage(Hijri_Day.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(Hijri_Month.AdvancedSearch.SearchValue))) {
                Hijri_Month.AddErrorMessage(Hijri_Month.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(Hijri_Year.AdvancedSearch.SearchValue))) {
                Hijri_Year.AddErrorMessage(Hijri_Year.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(Course_Price.AdvancedSearch.SearchValue))) {
                Course_Price.AddErrorMessage(Course_Price.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(Vat_Tax_15.AdvancedSearch.SearchValue))) {
                Vat_Tax_15.AddErrorMessage(Vat_Tax_15.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(dec_Balance.AdvancedSearch.SearchValue))) {
                dec_Balance.AddErrorMessage(dec_Balance.GetErrorMessage(false));
            }
            if (!CheckNumber(ConvertToString(Total_Price.AdvancedSearch.SearchValue))) {
                Total_Price.AddErrorMessage(Total_Price.GetErrorMessage(false));
            }
            if (!CheckInteger(ConvertToString(Assessment_ID.AdvancedSearch.SearchValue))) {
                Assessment_ID.AddErrorMessage(Assessment_ID.GetErrorMessage(false));
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
            int_Potential_Student_ID.AdvancedSearch.Load();
            int_Student_Id.AdvancedSearch.Load();
            str_NationalID_Iqama.AdvancedSearch.Load();
            NationalID.AdvancedSearch.Load();
            str_First_Name.AdvancedSearch.Load();
            str_Middle_Name.AdvancedSearch.Load();
            str_Last_Name.AdvancedSearch.Load();
            str_Address1.AdvancedSearch.Load();
            str_Address2.AdvancedSearch.Load();
            int_State.AdvancedSearch.Load();
            str_City.AdvancedSearch.Load();
            str_Zip.AdvancedSearch.Load();
            int_Instructor.AdvancedSearch.Load();
            int_Driver.AdvancedSearch.Load();
            str_Home_Phone.AdvancedSearch.Load();
            str_Cell_Phone.AdvancedSearch.Load();
            str_Parent_Phone.AdvancedSearch.Load();
            str_Other_Phone.AdvancedSearch.Load();
            str_Email.AdvancedSearch.Load();
            str_ParentName.AdvancedSearch.Load();
            str_ParentEmail1.AdvancedSearch.Load();
            str_ParentEmail2.AdvancedSearch.Load();
            str_Username.AdvancedSearch.Load();
            str_Password.AdvancedSearch.Load();
            str_DOB.AdvancedSearch.Load();
            int_DOB_Day.AdvancedSearch.Load();
            int_DOB_Month.AdvancedSearch.Load();
            int_DOB_Year.AdvancedSearch.Load();
            int_Age.AdvancedSearch.Load();
            int_Type.AdvancedSearch.Load();
            int_Wear_Glasses.AdvancedSearch.Load();
            int_Sex.AdvancedSearch.Load();
            str_DLPermit.AdvancedSearch.Load();
            dt_Date_PermitIssue.AdvancedSearch.Load();
            dt_Date_ExpirePermit.AdvancedSearch.Load();
            int_Hs_ID.AdvancedSearch.Load();
            str_Emergency_Contact_Name.AdvancedSearch.Load();
            str_Emergency_Contact_Phone.AdvancedSearch.Load();
            str_Emergency_Contact_Relation.AdvancedSearch.Load();
            str_Student_Notes.AdvancedSearch.Load();
            str_Driving_Notes.AdvancedSearch.Load();
            int_Location_Id.AdvancedSearch.Load();
            int_Permit_Number.AdvancedSearch.Load();
            Permit_Issue_Date.AdvancedSearch.Load();
            Permit_Expiry_Date.AdvancedSearch.Load();
            int_Status.AdvancedSearch.Load();
            int_Lead_Id.AdvancedSearch.Load();
            int_Activated_By.AdvancedSearch.Load();
            date_Activated.AdvancedSearch.Load();
            date_Created.AdvancedSearch.Load();
            date_Modified.AdvancedSearch.Load();
            date_Complete.AdvancedSearch.Load();
            int_Created_By.AdvancedSearch.Load();
            int_Modified_By.AdvancedSearch.Load();
            bit_IsDeleted.AdvancedSearch.Load();
            str_CardHolderName.AdvancedSearch.Load();
            str_CardHolderAddress.AdvancedSearch.Load();
            str_CardHolderCity.AdvancedSearch.Load();
            str_CardHolderZip.AdvancedSearch.Load();
            str_CardType.AdvancedSearch.Load();
            str_CardExpMonth.AdvancedSearch.Load();
            str_CardExpYear.AdvancedSearch.Load();
            str_CardNo.AdvancedSearch.Load();
            str_Certificate_No.AdvancedSearch.Load();
            str_AmountPaid.AdvancedSearch.Load();
            str_PermitValidated.AdvancedSearch.Load();
            strSMSNotification.AdvancedSearch.Load();
            strVoiceNotification.AdvancedSearch.Load();
            str_Weight.AdvancedSearch.Load();
            str_SpecialNeeds.AdvancedSearch.Load();
            str_MedicalConditions.AdvancedSearch.Load();
            bit_Verified_PIC_InSAW.AdvancedSearch.Load();
            bit_Permit_Waiver_Entered.AdvancedSearch.Load();
            bit_TermsConditions.AdvancedSearch.Load();
            bit_Disable_Self_Scheduling.AdvancedSearch.Load();
            int_EyeColor.AdvancedSearch.Load();
            int_HairColor.AdvancedSearch.Load();
            int_ColorBlind.AdvancedSearch.Load();
            int_HeightFeet.AdvancedSearch.Load();
            int_HeightInches.AdvancedSearch.Load();
            str_reference_code.AdvancedSearch.Load();
            dt_ParentClassAttendedDt.AdvancedSearch.Load();
            str_ParentClassAttendedLoc.AdvancedSearch.Load();
            dt_SiblingClassAttendedDt.AdvancedSearch.Load();
            str_SiblingClassAttendedLoc.AdvancedSearch.Load();
            bit_PoliciesAndProcedures.AdvancedSearch.Load();
            dt_CourseCompletionDt.AdvancedSearch.Load();
            dt_ExtensionDt.AdvancedSearch.Load();
            str_MedicalCondition.AdvancedSearch.Load();
            str_MajorCrossStreets.AdvancedSearch.Load();
            str_DriverEdCertNo.AdvancedSearch.Load();
            dt_DriverEdCertIssuedDt.AdvancedSearch.Load();
            str_BTWDriversEdCertNo.AdvancedSearch.Load();
            dt_BTWCertIssuedDt.AdvancedSearch.Load();
            str_OLDriversEdCertNo.AdvancedSearch.Load();
            dt_OLCertIssuedDt.AdvancedSearch.Load();
            str_height.AdvancedSearch.Load();
            dt_BTWCompletionDt.AdvancedSearch.Load();
            dt_CRCompletionDt.AdvancedSearch.Load();
            strTextBox5.AdvancedSearch.Load();
            strTextBox6.AdvancedSearch.Load();
            str_ApartmentNo.AdvancedSearch.Load();
            dt_PermitTestDate.AdvancedSearch.Load();
            str_OnlineDriverEdLogin.AdvancedSearch.Load();
            str_OnlineDriverEdPassword.AdvancedSearch.Load();
            bit_IsSMSEnabled.AdvancedSearch.Load();
            dt_SMSModified.AdvancedSearch.Load();
            str_confirmPassword.AdvancedSearch.Load();
            DE_Certificate.AdvancedSearch.Load();
            Discuss.AdvancedSearch.Load();
            int_UnlicensedSibling.AdvancedSearch.Load();
            int_YearSiblingIsEligible.AdvancedSearch.Load();
            BTW_Certificate.AdvancedSearch.Load();
            dt_DECertIssueDate.AdvancedSearch.Load();
            str_StudentSignature.AdvancedSearch.Load();
            str_ParentSignature.AdvancedSearch.Load();
            str_Last6DigitsOfParentDriversLicense.AdvancedSearch.Load();
            str_FACControl.AdvancedSearch.Load();
            Classroom_Status_Code.AdvancedSearch.Load();
            Laboratory_Status_Code.AdvancedSearch.Load();
            bit_EnrollmentForm.AdvancedSearch.Load();
            bit_ParentStudentContract.AdvancedSearch.Load();
            bit_ParentalAgreement.AdvancedSearch.Load();
            int_SF_GR_WA_HS.AdvancedSearch.Load();
            bit_DisableOnRMV.AdvancedSearch.Load();
            bit_UploadedToRMV.AdvancedSearch.Load();
            str_Mother_Name.AdvancedSearch.Load();
            str_Guardians_Name.AdvancedSearch.Load();
            str_Mother_Phone.AdvancedSearch.Load();
            bit_terms.AdvancedSearch.Load();
            int_Nationality.AdvancedSearch.Load();
            str_National_ID_en.AdvancedSearch.Load();
            str_National_ID_arabic.AdvancedSearch.Load();
            Quallification_Id.AdvancedSearch.Load();
            Job_Id.AdvancedSearch.Load();
            str_DOB_arabic.AdvancedSearch.Load();
            int_Language.AdvancedSearch.Load();
            strRefId.AdvancedSearch.Load();
            int_Program_Id.AdvancedSearch.Load();
            IsDrivingexperience.AdvancedSearch.Load();
            IsScheduleassessment.AdvancedSearch.Load();
            IsEnrollbyyourself.AdvancedSearch.Load();
            AssessmentTime.AdvancedSearch.Load();
            AssessmentDate.AdvancedSearch.Load();
            isAssessmentDone.AdvancedSearch.Load();
            AssessmentScore.AdvancedSearch.Load();
            dt_WrittenTestPassed.AdvancedSearch.Load();
            dt_RoadTestPassed.AdvancedSearch.Load();
            bit_Archive.AdvancedSearch.Load();
            ArchiveNotes.AdvancedSearch.Load();
            dtArchived.AdvancedSearch.Load();
            SrNo9Dec21.AdvancedSearch.Load();
            REGNNUMB.AdvancedSearch.Load();
            REGNLOCN.AdvancedSearch.Load();
            SrNo11DecF1S1.AdvancedSearch.Load();
            IsInterestedInTraining.AdvancedSearch.Load();
            StudentEncryptID.AdvancedSearch.Load();
            StudentConfirURL.AdvancedSearch.Load();
            SrNo15DecF1S2.AdvancedSearch.Load();
            SrNo15DecF1S3.AdvancedSearch.Load();
            SrNo16DecF2S2.AdvancedSearch.Load();
            SrNo16DecF2S3.AdvancedSearch.Load();
            SrNo16DecF3S1.AdvancedSearch.Load();
            SrNo16DecF3S2.AdvancedSearch.Load();
            SrNo16DecF4S1.AdvancedSearch.Load();
            SrNo16DecF4S2.AdvancedSearch.Load();
            SrNo16DecF4S3.AdvancedSearch.Load();
            StudentAssementBookingURL.AdvancedSearch.Load();
            intDrivinglicenseType.AdvancedSearch.Load();
            Isdrivinglicense.AdvancedSearch.Load();
            drivinglicensenumber.AdvancedSearch.Load();
            Absher_Appointment_number.AdvancedSearch.Load();
            DataImportId.AdvancedSearch.Load();
            date_Birth_Hijri.AdvancedSearch.Load();
            UserlevelID.AdvancedSearch.Load();
            Activated.AdvancedSearch.Load();
            Absherphoto.AdvancedSearch.Load();
            Fingerprint.AdvancedSearch.Load();
            Required_Program.AdvancedSearch.Load();
            Price.AdvancedSearch.Load();
            Hijri_Day.AdvancedSearch.Load();
            Hijri_Month.AdvancedSearch.Load();
            Hijri_Year.AdvancedSearch.Load();
            Course_Price.AdvancedSearch.Load();
            Vat_Tax_15.AdvancedSearch.Load();
            dec_Balance.AdvancedSearch.Load();
            Total_Price.AdvancedSearch.Load();
            Payment_Online.AdvancedSearch.Load();
            Institution.AdvancedSearch.Load();
            WaitingList.AdvancedSearch.Load();
            Assessment_ID.AdvancedSearch.Load();
        }

        // Set up Breadcrumb
        protected void SetupBreadcrumb() {
            var breadcrumb = new Breadcrumb();
            string url = CurrentUrl();
            breadcrumb.Add("list", TableVar, AppPath(AddMasterUrl("TblPotentialStudentInfoList")), "", TableVar, true);
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
